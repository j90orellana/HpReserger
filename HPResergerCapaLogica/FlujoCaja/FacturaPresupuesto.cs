using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica.FlujoCaja
{
    public class FacturaPresupuesto
    {
        public int Id { get; set; } = 0;
        public int IdFactura { get; set; } = 0;
        public int TipoFactura { get; set; } = 0;
        public int IdPartida { get; set; } = 0;
        public int TipoPartida { get; set; } = 0;

        private readonly string _connectionString;

        public FacturaPresupuesto()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }

        // Verifica si la tabla existe, si no, la crea
        public void ValidarTablaExiste()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                              -- Verificar y crear la tabla TBL_FacturasPresupuestos si no existe
                                IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TBL_FacturasPresupuestos')
                                BEGIN
                                    CREATE TABLE dbo.TBL_FacturasPresupuestos (
                                        id INT IDENTITY(1,1) PRIMARY KEY,
                                        idFactura INT NOT NULL,
                                        TipoFactura INT NOT NULL,
                                        idPartida INT NOT NULL,
                                        TipoPartida INT NOT NULL
                                    );
                                END;

                                -- Verificar y crear la tabla TBL_Partidas_Control si no existe
                                IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE name = 'TBL_Partidas_Control' AND xtype = 'U')
                                BEGIN
                                    CREATE TABLE dbo.TBL_Partidas_Control (
                                        id INT IDENTITY(1,1) PRIMARY KEY,
                                        Codigo NVARCHAR(50) NOT NULL DEFAULT (''),
                                        Descripcion NVARCHAR(150) NOT NULL DEFAULT (''),
                                        completo NVARCHAR(MAX) NULL,
                                        Tipo INT NOT NULL,
                                        cabecera INT NOT NULL DEFAULT (0),
                                        tag NVARCHAR(50) NOT NULL DEFAULT (''),
                                        estado INT NOT NULL DEFAULT (1),
                                        fecha DATETIME NOT NULL DEFAULT (GETDATE()),
                                        pkempresa INT NOT NULL DEFAULT (0)
                                    );
                                END;


";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Insertar
        public int Insertar(int idfac, int tipofac, int empresa, string codigo)
        {
            if (codigo == null) return 0;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"

                            declare @id as int=0
                            declare @tipo as int =0

                            select @id = p.id, @tipo = p.Tipo from TBL_Partidas_Control p where codigo =@codigo and pkempresa = @empresa
                            select @id,@tipo
                            INSERT INTO TBL_FacturasPresupuestos (idFactura, TipoFactura, idPartida, TipoPartida)
                                                             OUTPUT INSERTED.id
                                                             VALUES (@idFactura, @TipoFactura, @id, @tipo)

";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idFactura", idfac);
                cmd.Parameters.AddWithValue("@TipoFactura", tipofac);
                cmd.Parameters.AddWithValue("@empresa", empresa);
                cmd.Parameters.AddWithValue("@codigo", codigo);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        public DataTable FlujodeCajaMovimientos(int empresa, int movimientos)
        {
            var dt = new DataTable();
            string query = @"             
                SELECT DISTINCT
	                e.Empresa 'empresa', 
	                ISNULL(NULLIF(cp.nombre, ''), 'OTROS') 'Comprobante',
	                CAST(ISNULL(NULLIF(ax.Razon_Social, ''), 'VARIOS') AS NVARCHAR(200))  'RazonSocial',
	                concat(ISNULL(NULLIF(ax.Cod_Comprobante, '0'),'0')  ,'-',ISNULL(NULLIF(ax.Num_Comprobante, '0'),'0')) 'NumeroComprobante',
	                ax.Num_Doc 'Proveedor',
                    CAST(AX.Fecha_Asiento AS DATE)'FechaEmision',
	                --CAST(AX.Fecha_Emision AS DATE)'FechaEmision',
	                CAST(AX.Fecha_Asiento AS DATE)'FechaContable',

	                IIF(Saldo_Debe>0,1,-1)* ax.Importe_MN 'PEN',
	                IIF(Saldo_Debe>0,1,-1)* ax.Importe_ME 'USD', 

	                CAST(ISNULL(NULLIF(a.Glosa, ''), '-') AS NVARCHAR(200)) AS Glosa,
	                concat(pc.Codigo,' ', pc.partida) 'Presupuesto',CONCAT(CodigoPadre,' ',PatidaPadre)PartidaPadre,
		                case pc.tipo
		                when 1 then 'SPV'
		                WHEN 2 THEN 'Servicio'
		                when 3 then 'Holding'
		                when 4 then 'Constructora'
		                else 'Desconocido'
		                END  'Tipo'
                FROM TBL_Asiento_Contable a
                INNER JOIN TBL_Proyecto p ON a.id_proyecto = p.Id_Proyecto
                INNER JOIN TBL_Empresa e ON p.Id_Empresa = e.Id_Empresa
                LEFT JOIN TBL_Asiento_Contable_Aux ax ON a.Id_Asiento_Contable = ax.Id_Asiento_Contable
                    AND a.id_Asiento = ax.Id_Aux
                    AND a.Cuenta_Contable = Ax.Cuenta_Contable
                    AND a.id_proyecto = ax.fk_proyecto
                    AND CAST(ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento) AS DATE) = ax.Fecha_Asiento
                LEFT JOIN TBL_Tipo_ID tp ON tp.Codigo_Tipo_ID = ax.Tipo_Doc
                 LEFT JOIN TBL_Comprobante_Pago cp ON cp.Id_Comprobante = ax.Id_Comprobante
                LEFT JOIN TBL_MovimientoPartidas pp ON pp.fkid = a.Id_Asiento_Contable 
                    AND pp.fkiddet = id_Asiento 
                    AND pp.fecha = CAST(ISNULL(a.fecha_asiento_Valor, a.fecha_asiento) AS DATE)
                    AND pp.cuenta = a.Cuenta_Contable
                    AND pp.fkproyecto = a.id_proyecto
                INNER JOIN TBL_Partidas_Control pc ON pc.id = pp.idPartida AND  e.ppto = pc.Tipo
                WHERE a.Cuenta_Contable BETWEEN '104' AND '108'
                    --AND CAST(ISNULL(a.fecha_asiento_Valor, a.fecha_asiento) AS DATE) BETWEEN @fechade AND @fechaa
                   AND  e.Id_Empresa= @empresa
                    --AND (ax.Razon_Social LIKE '%' + @PROVEEDOR + '%' OR ax.Num_Doc LIKE '%' + @PROVEEDOR + '%')
                    --AND a.Glosa LIKE '%' + @GLOSA + '%'  
                    --AND CONCAT(ax.Cod_Comprobante,'-', ax.Num_Comprobante) LIKE '%' + @nrocompro + '%'
                    --AND (ISNULL(pc.id,0) = @ocultar OR @ocultar = 1)
                    AND NOT EXISTS (
                        SELECT 1
                        FROM TBL_Asiento_Contable h
                        INNER JOIN TBL_Proyecto po ON po.Id_Proyecto = h.id_proyecto
                        INNER JOIN TBL_Empresa ex ON po.Id_Empresa = ex.Id_Empresa AND ex.Id_Empresa = e.Id_Empresa
                        WHERE h.Estado = 4
                            AND h.Cod_Asiento_Contable = a.Cod_Asiento_Contable
                            --AND CAST(ISNULL(h.Fecha_Asiento_Valor, h.Fecha_Asiento) AS DATE) BETWEEN @fechade AND @fechaa
                    )
                ORDER BY e.Empresa ASC, 6 ASC;";


            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@empresa", SqlDbType.Int).Value = empresa;
                //cmd.Parameters.Add("@pagos", SqlDbType.Int).Value = movimientos;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;

        }

        public DataTable FlujodeCaja(int empresa, int compras, int ventas, int pagos)
        {
            var dt = new DataTable();
            string query = @"
 
declare @fecha as date = null

select @fecha= max(fecha) from (
select   max(FechaEmision )fecha from TBL_FacturaManual where empresa	= @empresa
and Estado = 1
and @compras =1
union all
select   max(FechaEmision )fecha from TBL_VentaManual where empresa	= @empresa
and Estado = 1
and @ventas =1
union all
select   max(FechaPago )fecha from TBL_Factura_Det where fkempresa	= @empresa
and Estado = 1
and @pagos =1
) x

select e.empresa, cp.nombre AS Comprobante, 
 p.razon_social AS RazonSocial, 
  X.NroComprobante AS NumeroComprobante,
	                    X.Proveedor,
                  
				--		x.FechaEmision AS FechaEmision,
                --    x.FechaContable AS FechaContable,
	             isnull(x.FechaEmision,@fecha ) AS FechaEmision,
                   isnull(x.FechaContable,@fecha ) AS FechaContable,

			isnull(	ROUND(	IIF(	x.Moneda =1, TOTAL, TOTAL*TC),2),0) 'PEN',
				isnull(		ROUND(	IIF(	x.Moneda =2, TOTAL, TOTAL/TC),2) ,0) 'USD',

						  X.Glosa, 

concat(pc.Codigo,' ', pc.Descripcion) 'Presupuesto' , PartidaPadre,
case pc.tipo
when 1 then 'SPV'
WHEN 2 THEN 'Servicio'
when 3 then 'Holding'
when 4 then 'Constructora'
else 'Desconocido'

END  'Tipo'


from TBL_Partidas_Control pc 
 INNER JOIN TBL_Empresa e ON e.Id_Empresa = pc.pkempresa
left join TBL_FacturasPresupuestos pp on pp.idPartida = pc.id and pp.TipoPartida = pc.Tipo

left join (
                        SELECT
                            'Facturas Compras' AS Tipo,
                            Id,
                            IdComprobante,
                            NroComprobante,
                            Proveedor,
                            Empresa,
                            Moneda,
                            TC,
                            Total,
                            IGV,
                            FechaEmision,
                            FechaContable,
                            Estado,
                            Detraccion,
                            Glosa,
                            Usuario, 1 tipofactura
                        FROM TBL_FacturaManual ff
							where  ff.Empresa = @empresa
							and Estado !=0
                        UNION ALL


                        SELECT
                            'Notas Compras' AS Tipo,
                            Id,
                            IdComprobante,
                            NroComprobante,
                            Proveedor,
                            Empresa,
                            Moneda,
                            TC,
                            Total,
                            IGV,
                            FechaEmision,
                            FechaContable,
                            Estado,
                            0 AS Detraccion,
                            Glosa,
                            Usuario, 100
                        FROM TBL_NC_ND_CompraManual fff
						where fff.Empresa = @empresa 
							and Estado !=0
                    ) X

					on x.Id = pp.idFactura  and pp.TipoFactura = x.tipofactura

					 LEFT JOIN TBL_Comprobante_Pago cp ON cp.Id_Comprobante = X.IdComprobante
					 LEFT JOIN TBL_Proveedor p ON p.ruc = X.Proveedor
where pc.pkempresa = @empresa
and pc.estado =1
and @compras = 1

UNION ALL


select e.empresa, cp.nombre AS Comprobante, 
 p.razon_social AS RazonSocial, 
  X.NroComprobante AS NumeroComprobante,
	                    X.Proveedor,
                    
			--		x.FechaEmision AS FechaEmision,
                --    x.FechaContable AS FechaContable,
	                 isnull(x.FechaEmision,@fecha ) AS FechaEmision,
                     isnull(x.FechaContable,@fecha ) AS FechaContable,

		isnull(		ROUND(	IIF(	x.Moneda =1, TOTAL, TOTAL*TC),2),0) 'PEN',
				isnull(		ROUND(	IIF(	x.Moneda =2, TOTAL, TOTAL/TC),2),0)  'USD',

						  X.Glosa, 

concat(pc.Codigo,' ', pc.Descripcion) 'Presupuesto' ,PartidaPadre,
case pc.tipo
when 1 then 'SPV'
WHEN 2 THEN 'Servicio'
when 3 then 'Holding'
when 4 then 'Constructora'
else 'Desconocido'

END  'Tipo'


from TBL_Partidas_Control pc 
 INNER JOIN TBL_Empresa e ON e.Id_Empresa = pc.pkempresa
left join TBL_FacturasPresupuestos pp on pp.idPartida = pc.id and pp.TipoPartida = pc.Tipo

left join (
                      
                        SELECT
                            'Facturas Ventas' AS Tipo,
                            Id,
                            IdComprobante,
                            NroComprobante,
                           Cliente Proveedor,
                            Empresa,
                            Moneda,
                            TC,
                            Total,
                            IGV,
                            FechaEmision,
                            FechaContable,
                            Estado,
                            Detraccion,
                            Glosa,
                            Usuario, 2 tipofactura
                        FROM TBL_VentaManual fff
						where fff.Empresa = @empresa
							and Estado !=0


                        UNION ALL


                        SELECT
                            'Notas Ventas' AS Tipo,
                            Id,
                            IdComprobante,
                            NroComprobante,
                        Cliente    Proveedor,
                            Empresa,
                            Moneda,
                            TC,
                            Total,
                            IGV,
                            FechaEmision,
                            FechaContable,
                            Estado,
                            0 AS Detraccion,
                            Glosa,
                            Usuario, 200
                        FROM TBL_NC_ND_VentaManual ffff
						where ffff.Empresa = @empresa
							and Estado !=0

                    ) X

					on x.Id = pp.idFactura  and pp.TipoFactura = x.tipofactura

					 LEFT JOIN TBL_Comprobante_Pago cp ON cp.Id_Comprobante = X.IdComprobante
					 LEFT JOIN TBL_Proveedor p ON p.ruc = X.Proveedor
where pc.pkempresa = @empresa
and pc.estado =1
and @ventas =1


union all


select e.empresa, TipoDocumento AS Comprobante, 
 Razon AS RazonSocial, 
  X.NroComprobante AS NumeroComprobante,
	                   x.Ruc,
               --      x.FechaPago AS FechaEmision,
               --      x.FechaPago AS FechaContable,
                 isnull(x.FechaPago,@fecha ) AS FechaEmision,
                  isnull(x.FechaPago,@fecha ) AS FechaContable,

		isnull(		ROUND(	IIF(	x.Moneda =1, TOTAL, TOTAL*TC),2),0) 'PEN',
				isnull(		ROUND(	IIF(	x.Moneda =2, TOTAL, TOTAL/TC),2),0)  'USD',

						  ''Glosa, 

concat(pc.Codigo,' ', pc.Descripcion) 'Presupuesto' ,PartidaPadre,
case pc.tipo
when 1 then 'SPV'
WHEN 2 THEN 'Servicio'
when 3 then 'Holding'
when 4 then 'Constructora'
else 'Desconocido'

END  'Tipo'


from TBL_Partidas_Control pc 
 INNER JOIN TBL_Empresa e ON e.Id_Empresa = pc.pkempresa
left join TBL_FacturasPresupuestos pp on pp.idPartida = pc.id and pp.TipoPartida = pc.Tipo

left join (
                      
                         select 
                e.Empresa Empresa,
                Proveedor Ruc,
                p.razon_social Razon,
                cp.Nombre TipoDocumento,
                f.NroFactura NroComprobante
                ,f.FechaPago FechaPago
                ,eb.Entidad_Financiera Banco
                ,CtaBanco Cuenta
                ,Total 
                ,tc.Compra TCC,
                tc.Venta tc, cb.Moneda
                ,m.NameCorto
                ,f.NroFacturaDet id, e. Id_Empresa , 5 tipofactura
                 from tbl_factura_Det f
                inner join TBL_Empresa e on e.Id_Empresa  = f.fkempresa
                inner join TBL_Proveedor p on f.Proveedor = p.RUC
                Inner join TBL_Comprobante_Pago cp on cp.Id_Comprobante  = f.Id_Comprobante
                left join TBL_CtaBancaria cb on cb.Nro_Cta  = CtaBanco
                inner join TBL_Moneda m on m.Id_Moneda = cb.moneda
                left join TBL_Entidad_Financiera eb on eb.ID_Entidad = cb.Banco
                left join TBL_Tipo_Cambio tc on tc.Anio = year(FechaPago) and tc.Mes = MONTH(fechapago) and tc.Dia = DAY(FechaPago)

 

                WHERE f.Estado =1
                    ) X

					on x.Id = pp.idFactura  and pp.TipoFactura = x.tipofactura


where pc.pkempresa = @empresa
and pc.estado =1
and @pagos =1

union all
select e. Empresa,	COMPROBANTE,RAZONSOCIAL,NUMEROCOMPROBANTE,PROVEEDOR,FECHAEMISION,FECHACONTABLE,PEN,USD,GLOSA,concat(pc.Codigo,' ', pc.Descripcion) 'Presupuesto',PartidaPadre ,case pc.tipo
when 1 then 'SPV'
WHEN 2 THEN 'Servicio'
when 3 then 'Holding'
when 4 then 'Constructora'
else 'Desconocido'
END  'Tipo'

from TBL_MovimientosCaja c
inner join TBL_Empresa e on c.IDEMPRESA = e.Id_Empresa
inner join TBL_Partidas_Control pc on pc.id = c.PARTIDA

where pc.pkempresa = @empresa
and pc.estado =1
and @pagos = 1

--order by pc.tipo,TRY_CAST(Codigo AS INT) ASC

";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@empresa", SqlDbType.Int).Value = empresa;
                cmd.Parameters.Add("@compras", SqlDbType.Int).Value = compras;
                cmd.Parameters.Add("@ventas", SqlDbType.Int).Value = ventas;
                cmd.Parameters.Add("@pagos", SqlDbType.Int).Value = pagos;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        public int InsertarUpdate(int idfac, int TipoFactura, int idPartida)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"

                            DECLARE @id AS INT = 0;
                            DECLARE @tipoPartida AS INT = 0;

                            -- Obtener el ID si ya existe en TBL_FacturasPresupuestos
                            SELECT @id = id 
                            FROM TBL_FacturasPresupuestos
                            WHERE idFactura = @idFactura AND TipoFactura = @tipoFacturas;

                            -- Obtener el tipo de partida
                            SELECT @tipoPartida = p.Tipo 
                            FROM TBL_Partidas_Control p 
                            WHERE p.id = @idPartida;

                            -- Validar si el tipo de partida es NULL (para evitar errores en el insert)
                            IF @tipoPartida IS NULL 
                                SET @tipoPartida = 0;

                            -- Si no existe, insertar un nuevo registro
                            IF @id = 0 
                            BEGIN
                                INSERT INTO TBL_FacturasPresupuestos (idFactura, TipoFactura, idPartida, TipoPartida)
                                OUTPUT INSERTED.id
                                VALUES (@idFactura, @tipoFacturas, @idPartida, @tipoPartida);
                            END
                            ELSE 
                            BEGIN
                                -- Si ya existe, actualizar
                                UPDATE TBL_FacturasPresupuestos
                                SET idFactura = @idFactura, 
                                    TipoFactura = @tipoFacturas, 
                                    idPartida = @idPartida, 
                                    TipoPartida = @tipoPartida
                                WHERE id = @id;
                            END

select @id

";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idFactura", idfac);
                cmd.Parameters.AddWithValue("@idPartida", idPartida);
                cmd.Parameters.AddWithValue("@tipoFacturas", TipoFactura);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        public int InsertarUpdateBuscarCompras(int idfac, int TipoFactura, int idPartida)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                            DECLARE @id AS INT = 0;
                            DECLARE @tipoPartida AS INT = 0;

                            -- Obtener el ID si ya existe en TBL_FacturasPresupuestos
                            SELECT @id = id 
                            FROM TBL_FacturasPresupuestos
                            WHERE idFactura = @idFactura AND TipoFactura = @tipoFacturas;

                            -- Obtener el tipo de partida y el ID de partida
                            SELECT TOP 1 
                                @tipoPartida = COALESCE(p.Tipo, 0), 
                                @idpartida = COALESCE(p.id, 0)
                            FROM TBL_Partidas_Control p
                            WHERE p.Codigo IN (SELECT codigo FROM TBL_Partidas_Control WHERE id = @idpartida)
                            AND p.pkempresa IN (
                                SELECT Empresa FROM TBL_FacturaManual WHERE Id = @idfactura AND @tipofacturas = 1
                                UNION ALL 
                                SELECT Empresa FROM TBL_NC_ND_CompraManual WHERE Id = @idfactura AND @tipofacturas = 100
                            );

                            -- Si no se encuentra la partida, evitar INSERT o UPDATE
                            IF @idpartida <> 0 
                            BEGIN
                                IF @id = 0 
                                BEGIN
                                    -- Insertar solo si no existe el registro
                                    INSERT INTO TBL_FacturasPresupuestos (idFactura, TipoFactura, idPartida, TipoPartida)
                                    OUTPUT INSERTED.id
                                    VALUES (@idFactura, @tipoFacturas, @idpartida, @tipoPartida);
                                END
                                ELSE 
                                BEGIN
                                    -- Si ya existe, actualizar
                                    UPDATE TBL_FacturasPresupuestos
                                    SET idFactura = @idFactura, 
                                        TipoFactura = @tipoFacturas, 
                                        idPartida = @idpartida, 
                                        TipoPartida = @tipoPartida
                                    WHERE id = @id;
                                END
                            END;

                            SELECT @id;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idFactura", idfac);
                cmd.Parameters.AddWithValue("@idPartida", idPartida);
                cmd.Parameters.AddWithValue("@tipoFacturas", TipoFactura);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public int InsertarUpdateBuscarMovimientoFinancieros(int fkid, int fkiddet, int fkproyecto, DateTime fecha, string cuenta, int idpartida)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                         
                            DECLARE @id AS INT = 0; 

                            DECLARE @IDPARTIDAEMPRESA AS INT = 0; 
    
	
	                        SELECT @IDPARTIDAEMPRESA=PC.ID FROM TBL_Partidas_Control PC
	                        INNER JOIN TBL_Empresa E ON e.ppto = pc.Tipo
	                        INNER JOIN TBL_Proyecto P ON P.Id_Proyecto = @fkproyecto AND P.Id_Empresa = E.Id_Empresa
	                        INNER JOIN TBL_Partidas_Control PP ON PP.id =@idpartida
	                        AND PC.Codigo = PP.Codigo AND PP.Tipo = PC.Tipo


                            -- Obtener el ID si ya existe en TBL_FacturasPresupuestos
                            SELECT @id = id 
                            FROM TBL_MovimientoPartidas x
                            WHERE x.cuenta =@cuenta
                            and x.fkid = @fkid
                            and x.fkiddet = @fkiddet
                            and x.fkproyecto = @fkproyecto
                            and x.fecha = @fecha
 
  
                            BEGIN
                                IF @id = 0 
                                BEGIN
                                    -- Insertar solo si no existe el registro
                                    INSERT INTO TBL_MovimientoPartidas
                                    OUTPUT INSERTED.id
                                    VALUES (@fkid,@fkiddet,@cuenta,@fkproyecto,@fecha,@IDPARTIDAEMPRESA);
                                END
                                ELSE 
                                BEGIN
                                    -- Si ya existe, actualizar
                                    UPDATE TBL_MovimientoPartidas
			                            SET  fkid = @fkid,
			                            fkiddet = @fkiddet,
			                            fkproyecto =@fkproyecto,
			                            cuenta = @cuenta,
			                            fecha = @fecha,
                                        idpartida = @IDPARTIDAEMPRESA

                                    WHERE id = @id;
                                END
                            END;

                            SELECT @id;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fkid", fkid);
                cmd.Parameters.AddWithValue("@fkiddet", fkiddet);
                cmd.Parameters.AddWithValue("@fkproyecto", fkproyecto);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@idpartida", idpartida);
                cmd.Parameters.AddWithValue("@cuenta", cuenta);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        public int InsertarUpdateBuscarVentas(int idfac, int TipoFactura, int idPartida)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                            DECLARE @id AS INT = 0;
                            DECLARE @tipoPartida AS INT = 0;

                            -- Obtener el ID si ya existe en TBL_FacturasPresupuestos
                            SELECT @id = id 
                            FROM TBL_FacturasPresupuestos
                            WHERE idFactura = @idFactura AND TipoFactura = @tipoFacturas;

                            -- Obtener el tipo de partida y el ID de partida
                            SELECT TOP 1 
                                @tipoPartida = COALESCE(p.Tipo, 0), 
                                @idpartida = COALESCE(p.id, 0)
                            FROM TBL_Partidas_Control p
                            WHERE p.Codigo IN (SELECT codigo FROM TBL_Partidas_Control WHERE id = @idpartida)
                            AND p.pkempresa IN (
                                SELECT Empresa FROM TBL_VentaManual WHERE Id = @idfactura AND @tipofacturas = 2
                                UNION ALL 
                                SELECT Empresa FROM TBL_NC_ND_VentaManual WHERE Id = @idfactura AND @tipofacturas = 200
                            );

                            -- Si no se encuentra la partida, evitar INSERT o UPDATE
                            IF @idpartida <> 0 
                            BEGIN
                                IF @id = 0 
                                BEGIN
                                    -- Insertar solo si no existe el registro
                                    INSERT INTO TBL_FacturasPresupuestos (idFactura, TipoFactura, idPartida, TipoPartida)
                                    OUTPUT INSERTED.id
                                    VALUES (@idFactura, @tipoFacturas, @idpartida, @tipoPartida);
                                END
                                ELSE 
                                BEGIN
                                    -- Si ya existe, actualizar
                                    UPDATE TBL_FacturasPresupuestos
                                    SET idFactura = @idFactura, 
                                        TipoFactura = @tipoFacturas, 
                                        idPartida = @idpartida, 
                                        TipoPartida = @tipoPartida
                                    WHERE id = @id;
                                END
                            END;

                            SELECT @id;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idFactura", idfac);
                cmd.Parameters.AddWithValue("@idPartida", idPartida);
                cmd.Parameters.AddWithValue("@tipoFacturas", TipoFactura);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        public int InsertarUpdateBuscarPagos(int idfac, int TipoFactura, int idPartida)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
 
							DECLARE @id AS INT = 0;
                            DECLARE @tipoPartida AS INT = 0;

                            -- Obtener el ID si ya existe en TBL_FacturasPresupuestos
                            SELECT @id = id 
                            FROM TBL_FacturasPresupuestos
                            WHERE idFactura = @idFactura AND TipoFactura = @tipoFacturas;

                            -- Obtener el tipo de partida y el ID de partida
                            SELECT TOP 1 
                                @tipoPartida = COALESCE(p.Tipo, 0), 
                                @idpartida = COALESCE(p.id, 0)
                            FROM TBL_Partidas_Control p
                            WHERE p.Codigo IN (SELECT codigo FROM TBL_Partidas_Control WHERE id = @idpartida)
                            AND p.pkempresa IN (
                                SELECT fkempresa FROM TBL_Factura_Det WHERE NroFacturaDet = @idfactura AND @tipofacturas = 5
                                
                            );

                            -- Si no se encuentra la partida, evitar INSERT o UPDATE
                            IF @idpartida <> 0 
                            BEGIN
                                IF @id = 0 
                                BEGIN
                                    -- Insertar solo si no existe el registro
                                    INSERT INTO TBL_FacturasPresupuestos (idFactura, TipoFactura, idPartida, TipoPartida)
                                    OUTPUT INSERTED.id
                                    VALUES (@idFactura, @tipoFacturas, @idpartida, @tipoPartida);
                                END
                                ELSE 
                                BEGIN
                                    -- Si ya existe, actualizar
                                    UPDATE TBL_FacturasPresupuestos
                                    SET idFactura = @idFactura, 
                                        TipoFactura = @tipoFacturas, 
                                        idPartida = @idpartida, 
                                        TipoPartida = @tipoPartida
                                    WHERE id = @id;
                                END
                            END;

                            SELECT @id;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idFactura", idfac);
                cmd.Parameters.AddWithValue("@idPartida", idPartida);
                cmd.Parameters.AddWithValue("@tipoFacturas", TipoFactura);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        // Obtener todos los registros
        public DataTable ObtenerTodos()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM TBL_FacturasPresupuestos ORDER BY id";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                conn.Open();
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        // Actualizar
        public bool Actualizar(FacturaPresupuesto factura)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE TBL_FacturasPresupuestos
                                 SET idFactura = @idFactura, TipoFactura = @TipoFactura, 
                                     idPartida = @idPartida, TipoPartida = @TipoPartida
                                 WHERE id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", factura.Id);
                cmd.Parameters.AddWithValue("@idFactura", factura.IdFactura);
                cmd.Parameters.AddWithValue("@TipoFactura", factura.TipoFactura);
                cmd.Parameters.AddWithValue("@idPartida", factura.IdPartida);
                cmd.Parameters.AddWithValue("@TipoPartida", factura.TipoPartida);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool ActualizarR(FacturaPresupuesto factura)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                            declare @id as int=0
                            declare @tipo as int =0

                            select @id = p.id, @tipo = p.Tipo from TBL_Partidas_Control p where p.id= @idPartida


                                UPDATE TBL_FacturasPresupuestos
                                 SET idFactura = @idFactura, TipoFactura = @TipoFactura, 
                                     idPartida = @idPartida, TipoPartida = @tipo
                                 WHERE id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", factura.Id);
                cmd.Parameters.AddWithValue("@idFactura", factura.IdFactura);
                cmd.Parameters.AddWithValue("@TipoFactura", factura.TipoFactura);
                cmd.Parameters.AddWithValue("@idPartida", factura.IdPartida);
                cmd.Parameters.AddWithValue("@TipoPartida", factura.TipoPartida);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        // Eliminar
        public bool Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM TBL_FacturasPresupuestos WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
