using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica.Compras
{
    public class FacturaManual
    {
        private readonly string _connectionString;

        public FacturaManual()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }

        // Create
        public DataTable BuscarFiltradoCompras(DateTime fechade, DateTime fechaa, string empresa, string proveedor, string glosa, int ocultarpp, string nrocomprobante)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT
                      e.empresa AS Empresa, x.Id id,
                        cp.nombre AS Comprobante, 
                        p.razon_social AS RazonSocial, 
                        m.NameCorto AS Moneda, 
                        X.NroComprobante AS NumeroComprobante,
	                    X.Proveedor,
                        FORMAT(X.FechaEmision, 'yyyy-MM-dd') AS FechaEmision,
                        FORMAT(X.FechaContable, 'yyyy-MM-dd') AS FechaContable,
                        CASE X.estado
                            WHEN 1 THEN 'COMPLETA'
                            WHEN 2 THEN 'PAGADA'

                            WHEN 3 THEN 'COMPENSADA'
                        END AS EstadoFactura,
                        X.Tipo, 
                        X.Total, 
                        X.IGV,
                        X.TC AS TipoCambio,
                        X.Detraccion, 
                        X.Glosa, 
	                    pc.id IdPP,--,pc.Codigo CodigoPP, pc.Tipo tipopartida,
                         ISNULL(U.Login_User, 'ADMIN') AS Usuario , isnull(pp.id,0) pkidpp
                    FROM(
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
                        FROM TBL_FacturaManual


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
                        FROM TBL_NC_ND_CompraManual
                    ) X

                    INNER JOIN TBL_Empresa e ON e.Id_Empresa = X.Empresa
                    LEFT JOIN TBL_Comprobante_Pago cp ON cp.Id_Comprobante = X.IdComprobante
                    LEFT JOIN TBL_Proveedor p ON p.ruc = X.Proveedor
                    LEFT JOIN TBL_Moneda m ON m.Id_Moneda = X.Moneda
                    LEFT JOIN TBL_Usuario U ON U.Codigo_User = X.Usuario
                    left join TBL_FacturasPresupuestos pp on pp.idFactura = x.Id and pp.tipofactura = x.tipofactura
                    left join TBL_Partidas_Control pc on pc.id = pp.idPartida and pc.Tipo = pp.TipoPartida and e.ppto = pc.Tipo

                    WHERE X.fechacontable BETWEEN @fechade AND @fechaa
                    AND(E.Empresa LIKE '%' + @EMPRESA + '%')
                    AND(P.razon_social LIKE '%' + @PROVEEDOR + '%' OR P.RUC LIKE '%' + @PROVEEDOR + '%')
                    AND X.Glosa LIKE '%' + @GLOSA + '%'  AND X.NroComprobante LIKE '%' + @nrocompro + '%'
                    and (isnull(pc.id,0)= @ocultar or @ocultar=1)
                    ORDER BY Empresa ASC, FechaContable ASC; ";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fechade", fechade);
                cmd.Parameters.AddWithValue("@fechaa", fechaa);
                cmd.Parameters.AddWithValue("@EMPRESA", empresa);
                cmd.Parameters.AddWithValue("@PROVEEDOR", proveedor);
                cmd.Parameters.AddWithValue("@GLOSA", glosa);
                cmd.Parameters.AddWithValue("@nrocompro", nrocomprobante);
                cmd.Parameters.AddWithValue("@ocultar", ocultarpp);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public object ListarFacturasxAño(DateTime Fecha)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"

      
SELECT 
e.Empresa, Proveedor,p.razon_social RazonSocial,IdComprobante,dbo.NameComprobante(IdComprobante)Comprobante ,NroComprobante,FechaEmision,Total,Glosa,
CASE Compensacion
when 0 then 'NINGUNA'
WHEN 1 THEN 'FONDO FIJO'
WHEN 2 THEN 'REEMBOLSO GASTOS'
WHEN 3 THEN 'ENTREGAS A RENDIR'
WHEN 4 THEN 'ANTICIPO PROVEEDOR'
ELSE 'NINGUNA'
END Compensacion
,case Estado
when 1 then 'PENDIENTE'
when 2 then 'PAGADA'
when 3 then 'COMPENSADA'
else 'Incompleta'
end EstadoCP



FROM (
select Empresa, Proveedor,IdComprobante,NroComprobante,FechaEmision,Total,Glosa,Compensacion,Estado from TBL_FacturaManual 
UNION ALL
select Empresa, Proveedor,IdComprobante,NroComprobante,FechaEmision,Total,Glosa,Compensacion,Estado from TBL_NC_ND_CompraManual
) AS X
left join TBL_Proveedor p on p.ruc = X.Proveedor
left join TBL_Empresa e on e.Id_Empresa = x.Empresa
where Estado >=1
and year(FechaEmision)= year(@fecha	)
;

";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fecha", Fecha);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable BuscarFiltradoMovimientosFinancieros(DateTime fechade, DateTime fechaa, string empresa, string proveedor, string glosa, int ocultarpp, string nrocomprobante,
            string cuentabancaria, string tipo)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
select * from (
SELECT DISTINCT
   e.Id_Empresa idempresa, e.Empresa,   
    a.Id_Asiento_Contable fkid,
    a.id_Asiento fkiddet,
    a.Cuenta_Contable cuenta,
    a.id_proyecto fkproyecto,
    CAST(ISNULL(a.fecha_asiento_Valor, a.fecha_asiento) AS DATE) fecha,
    FORMAT(CAST(ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento) AS DATE), 'dd/MM/yyyy') AS FechaOperacion,
ISNULL(NULLIF(cb.Nro_Cta, ''), '') 'CtaBancaria',
    CAST(ISNULL(NULLIF(a.Glosa, ''), '-') AS NVARCHAR(200)) AS Glosa,
    ISNULL(tp.Cod_Sunat, '-') AS TipoDoc,
    ISNULL(NULLIF(ax.Num_Doc, '0'), '-') AS NumDoc,
    CAST(ISNULL(NULLIF(ax.Razon_Social, ''), 'VARIOS') AS NVARCHAR(200)) AS Beneficiario,
    CAST(ISNULL(NULLIF(ax.NroOPBanco, ''), '-') AS NVARCHAR(20)) AS NroOpBanco,
    IIF(Saldo_Debe>0,1,-1)* ax.Importe_MN SOLES,
    IIF(Saldo_Debe>0,1,-1)* ax.Importe_ME DOLARES,
    ISNULL(NULLIF(ax.Num_Comprobante, '0'), '-') AS NumComprobante,

	IIF( IIF(Saldo_Debe>0,1,-1)* ax.Importe_MN +  IIF(Saldo_Debe>0,1,-1)* ax.Importe_ME >0 ,'INGRESO','EGRESO') 'Tipo' ,

    idpartida pkidpp, 
    idpartida IdPP, a.Cod_Asiento_Contable cuo
FROM TBL_Asiento_Contable a
INNER JOIN TBL_Proyecto p ON a.id_proyecto = p.Id_Proyecto
INNER JOIN TBL_Empresa e ON p.Id_Empresa = e.Id_Empresa

and (e.Id_Empresa IN (
    SELECT TRY_CAST(value AS INT)
    FROM STRING_SPLIT(@EMPRESA, ',')
    WHERE TRY_CAST(value AS INT) IS NOT NULL
) OR @EMPRESA =''
)

LEFT JOIN TBL_Asiento_Contable_Aux ax ON a.Id_Asiento_Contable = ax.Id_Asiento_Contable
    AND a.id_Asiento = ax.Id_Aux
    AND a.Cuenta_Contable = Ax.Cuenta_Contable
    AND a.id_proyecto = ax.fk_proyecto
    AND CAST(ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento) AS DATE) = ax.Fecha_Asiento
LEFT JOIN TBL_Tipo_ID tp ON tp.Codigo_Tipo_ID = ax.Tipo_Doc
left join TBL_CtaBancaria cb on cb.Id_Tipo_Cta = ax.Cta_Banco
LEFT JOIN TBL_MovimientoPartidas pp ON pp.fkid = a.Id_Asiento_Contable 
    AND pp.fkiddet = id_Asiento 
    AND pp.fecha = CAST(ISNULL(a.fecha_asiento_Valor, a.fecha_asiento) AS DATE)
    AND pp.cuenta = a.Cuenta_Contable
    AND pp.fkproyecto = a.id_proyecto
LEFT JOIN TBL_Partidas_Control pc ON pc.id = pp.idPartida AND pc.Tipo = e.ppto
WHERE a.Cuenta_Contable BETWEEN '104' AND '108'
    AND CAST(ISNULL(a.fecha_asiento_Valor, a.fecha_asiento) AS DATE) BETWEEN @fechade AND @fechaa
    --AND (E.Empresa LIKE '%' + @EMPRESA + '%')
    AND (ax.Razon_Social LIKE '%' + @PROVEEDOR + '%' OR ax.Num_Doc LIKE '%' + @PROVEEDOR + '%')
    AND a.Glosa LIKE '%' + @GLOSA + '%'  
    AND CONCAT(ax.Cod_Comprobante,'-', ax.Num_Comprobante) LIKE '%' + @nrocompro + '%'
    AND (ISNULL(pc.id,0) = @ocultar OR @ocultar = 1)
        AND Id_Dinamica_Contable NOT IN (-30,-31)
    AND NOT EXISTS (
        SELECT 1
        FROM TBL_Asiento_Contable h
        INNER JOIN TBL_Proyecto po ON po.Id_Proyecto = h.id_proyecto
        INNER JOIN TBL_Empresa ex ON po.Id_Empresa = ex.Id_Empresa AND ex.Id_Empresa = e.Id_Empresa
        WHERE h.Estado = 4
            AND h.Cod_Asiento_Contable = a.Cod_Asiento_Contable
            AND CAST(ISNULL(h.Fecha_Asiento_Valor, h.Fecha_Asiento) AS DATE) BETWEEN @fechade AND @fechaa
    )
)as x
 where   (CtaBancaria LIKE '%' + @CUENTABANCARIA + '%')
   AND (Tipo LIKE '%' + @TIPOMOVIMIENTO + '%')
ORDER BY x.Empresa ASC, fecha ASC;";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fechade", fechade);
                cmd.Parameters.AddWithValue("@fechaa", fechaa);
                cmd.Parameters.AddWithValue("@EMPRESA", empresa);
                cmd.Parameters.AddWithValue("@PROVEEDOR", proveedor);
                cmd.Parameters.AddWithValue("@GLOSA", glosa);
                cmd.Parameters.AddWithValue("@nrocompro", nrocomprobante);
                cmd.Parameters.AddWithValue("@ocultar", ocultarpp);

                cmd.Parameters.AddWithValue("@TIPOMOVIMIENTO", tipo);
                cmd.Parameters.AddWithValue("@CUENTABANCARIA", cuentabancaria);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        public DataTable BuscarFiltradoMovimientosFinancierosMov(DateTime fechade, DateTime fechaa, string empresa, string proveedor, string glosa, int ocultarpp, string nrocomprobante,
            string cuentabancaria, string tipo)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"


select * from (

SELECT DISTINCT
   
e.Id_Empresa idempresa, e.Empresa,   
    a.Id_Asiento_Contable fkid,
    a.id_Asiento fkiddet,
    a.Cuenta_Contable cuenta,
    a.id_proyecto fkproyecto,
    CAST(ISNULL(a.fecha_asiento_Valor, a.fecha_asiento) AS DATE) fecha,
    FORMAT(CAST(ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento) AS DATE), 'dd/MM/yyyy') AS FechaOperacion,
    FORMAT(CAST(isnull(ax.Fecha_Asiento,ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento)) AS DATE), 'dd/MM/yyyy') AS FechaPago,
	
	ISNULL(NULLIF(cb.Nro_Cta, ''), '') 'CtaBancaria',

	IIF( IIF(Saldo_Debe>0,1,-1)* ax.Importe_MN +  IIF(Saldo_Debe>0,1,-1)* ax.Importe_ME >0 ,'INGRESO','EGRESO') 'Tipo' 

    ,CAST(ISNULL(NULLIF(a.Glosa, ''), '-') AS NVARCHAR(200)) AS Glosa,
    ISNULL(tp.Cod_Sunat, '-') AS TipoDoc,
    ISNULL(NULLIF(ax.Num_Doc, '0'), '-') AS NumDoc,
    CAST(ISNULL(NULLIF(ax.Razon_Social, ''), 'VARIOS') AS NVARCHAR(200)) AS Beneficiario,
    CAST(ISNULL(NULLIF(ax.NroOPBanco, ''), '-') AS NVARCHAR(20)) AS NroOpBanco,
    IIF(Saldo_Debe>0,1,-1)* ax.Importe_MN SOLES,
    IIF(Saldo_Debe>0,1,-1)* ax.Importe_ME DOLARES,
    ISNULL(NULLIF(ax.Num_Comprobante, '0'), '-') AS NumComprobante,
    idpartida pkidpp, 
    idpartida IdPP, a.Cod_Asiento_Contable cuo
FROM TBL_Asiento_Contable a
INNER JOIN TBL_Proyecto p ON a.id_proyecto = p.Id_Proyecto
INNER JOIN TBL_Empresa e ON p.Id_Empresa = e.Id_Empresa

and (e.Id_Empresa IN (
    SELECT TRY_CAST(value AS INT)
    FROM STRING_SPLIT(@EMPRESA, ',')
    WHERE TRY_CAST(value AS INT) IS NOT NULL
) OR @EMPRESA =''
)

LEFT JOIN TBL_Asiento_Contable_Aux ax ON a.Id_Asiento_Contable = ax.Id_Asiento_Contable
    AND a.id_Asiento = ax.Id_Aux
    AND a.Cuenta_Contable = Ax.Cuenta_Contable
    AND a.id_proyecto = ax.fk_proyecto
    AND CAST(ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento) AS DATE) = ax.Fecha_Asiento
LEFT JOIN TBL_Tipo_ID tp ON tp.Codigo_Tipo_ID = ax.Tipo_Doc
LEFT JOIN TBL_MovimientoPartidas pp ON pp.fkid = a.Id_Asiento_Contable 
    AND pp.fkiddet = id_Asiento 
    AND pp.fecha = CAST(ISNULL(a.fecha_asiento_Valor, a.fecha_asiento) AS DATE)
    AND pp.cuenta = a.Cuenta_Contable
    AND pp.fkproyecto = a.id_proyecto
LEFT JOIN TBL_Partidas_Control pc ON pc.id = pp.idPartida AND pc.Tipo = e.ppto
left join TBL_CtaBancaria cb on cb.Id_Tipo_Cta = ax.Cta_Banco
WHERE a.Cuenta_Contable BETWEEN '104' AND '108'
    AND CAST(ISNULL(a.fecha_asiento_Valor, a.fecha_asiento) AS DATE) BETWEEN @fechade AND @fechaa
    --AND (E.Empresa LIKE '%' + @EMPRESA + '%')
    AND (ax.Razon_Social LIKE '%' + @PROVEEDOR + '%' OR ax.Num_Doc LIKE '%' + @PROVEEDOR + '%')
    AND a.Glosa LIKE '%' + @GLOSA + '%'  
    AND CONCAT(ax.Cod_Comprobante,'-', ax.Num_Comprobante) LIKE '%' + @nrocompro + '%'
    AND (ISNULL(pc.id,0) = @ocultar OR @ocultar = 1)
    AND NOT EXISTS (
        SELECT 1
        FROM TBL_Asiento_Contable h
        INNER JOIN TBL_Proyecto po ON po.Id_Proyecto = h.id_proyecto
        INNER JOIN TBL_Empresa ex ON po.Id_Empresa = ex.Id_Empresa AND ex.Id_Empresa = e.Id_Empresa
        WHERE h.Estado = 4
            AND h.Cod_Asiento_Contable = a.Cod_Asiento_Contable
            AND CAST(ISNULL(h.Fecha_Asiento_Valor, h.Fecha_Asiento) AS DATE) BETWEEN @fechade AND @fechaa
    )
)as x
 where   (CtaBancaria LIKE '%' + @CUENTABANCARIA + '%')
   AND (Tipo LIKE '%' + @TIPOMOVIMIENTO + '%')
ORDER BY x.Empresa ASC, fecha ASC;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fechade", fechade);
                cmd.Parameters.AddWithValue("@fechaa", fechaa);
                cmd.Parameters.AddWithValue("@EMPRESA", empresa);
                cmd.Parameters.AddWithValue("@PROVEEDOR", proveedor);
                cmd.Parameters.AddWithValue("@TIPOMOVIMIENTO", tipo);
                cmd.Parameters.AddWithValue("@CUENTABANCARIA", cuentabancaria);
                cmd.Parameters.AddWithValue("@GLOSA", glosa);
                cmd.Parameters.AddWithValue("@nrocompro", nrocomprobante);
                cmd.Parameters.AddWithValue("@ocultar", ocultarpp);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        public DataTable BuscarFiltradoVentas(DateTime fechade, DateTime fechaa, string empresa, string proveedor, string glosa, int ocultarpp, string nrocomprobante)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                SELECT
                      e.empresa AS Empresa, x.Id id,
                        cp.nombre AS Comprobante, 
                    trim(    CONCAT(Apepat_RazSoc_Cli, ' ', Apemat_Cli, ' ', Nombres_Cli)) AS Nombre_Completo , 
                        m.NameCorto AS Moneda, 
                        X.NroComprobante AS NumeroComprobante,
	                    X.Proveedor,
                        FORMAT(X.FechaEmision, 'yyyy-MM-dd') AS FechaEmision,
                        FORMAT(X.FechaContable, 'yyyy-MM-dd') AS FechaContable,
                        CASE X.estado
                            WHEN 1 THEN 'COMPLETA'
                            WHEN 2 THEN 'PAGADA'

                            WHEN 3 THEN 'COMPENSADA'
                        END AS EstadoFactura,
                        X.Tipo, 
                        X.Total, 
                        X.IGV,
                        X.TC AS TipoCambio,
                        X.Detraccion, 
                        X.Glosa, 
	                    pc.id IdPP,--,pc.Codigo CodigoPP, pc.Tipo tipopartida,
                         ISNULL(U.Login_User, 'ADMIN') AS Usuario , isnull(pp.id,0) pkidpp
                    FROM(
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
                        FROM TBL_VentaManual


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
                        FROM TBL_NC_ND_VentaManual
                    ) X

                    INNER JOIN TBL_Empresa e ON e.Id_Empresa = X.Empresa
                    LEFT JOIN TBL_Comprobante_Pago cp ON cp.Id_Comprobante = X.IdComprobante
                    LEFT JOIN TBL_Cliente p On p.Nro_Id_Cli = X.Proveedor
                    LEFT JOIN TBL_Moneda m ON m.Id_Moneda = X.Moneda
                    LEFT JOIN TBL_Usuario U ON U.Codigo_User = X.Usuario
                    left join TBL_FacturasPresupuestos pp on pp.idFactura = x.Id and pp.tipofactura = x.tipofactura
                    left join TBL_Partidas_Control pc on pc.id = pp.idPartida and pc.Tipo = pp.TipoPartida and e.ppto = pc.Tipo

                    WHERE X.fechacontable BETWEEN @fechade AND @fechaa
                    AND(E.Empresa LIKE '%' + @EMPRESA + '%')
                    AND(CONCAT(Apepat_RazSoc_Cli, ' ', Apemat_Cli, ' ', Nombres_Cli)  LIKE '%' + @PROVEEDOR + '%' OR P.Nro_Id_Cli LIKE '%' + @PROVEEDOR + '%')
                    AND X.Glosa LIKE '%' + @GLOSA + '%'  AND X.NroComprobante LIKE '%' + @nrocompro + '%'
                    and (isnull(pc.id,0)= @ocultar or @ocultar=1)
                    ORDER BY Empresa ASC, FechaContable ASC; ";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fechade", fechade);
                cmd.Parameters.AddWithValue("@fechaa", fechaa);
                cmd.Parameters.AddWithValue("@EMPRESA", empresa);
                cmd.Parameters.AddWithValue("@PROVEEDOR", proveedor);
                cmd.Parameters.AddWithValue("@GLOSA", glosa);
                cmd.Parameters.AddWithValue("@nrocompro", nrocomprobante);
                cmd.Parameters.AddWithValue("@ocultar", ocultarpp);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        public DataTable BuscarFiltradoPagoCompras(DateTime fechade, DateTime fechaa, string empresa, string proveedor, string nrocta, int ocultarpp, string nrocomprobante)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                select Empresa, Ruc,Razon,TipoDocumento,NroComprobante,FechaPago,Banco,Cuenta
                ,NameCorto Moneda,
                IIF(moneda=2, total,total/tcv)
                PagoDolares , 
                IIF(moneda=1, total,total*tcv)
                PagoSoles
                ,TCV TC
                , pc.id IdPP, isnull(pp.id,0) pkidpp ,x.id,x.Id_Empresa pkempresa
                from (
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
                tc.Venta TCV, cb.Moneda
                ,m.NameCorto
                ,f.NroFacturaDet id, e. Id_Empresa,e.ppto
                 from tbl_factura_Det f
                inner join TBL_Empresa e on e.Id_Empresa  = f.fkempresa
                inner join TBL_Proveedor p on f.Proveedor = p.RUC
                Inner join TBL_Comprobante_Pago cp on cp.Id_Comprobante  = f.Id_Comprobante
                left join TBL_CtaBancaria cb on cb.Nro_Cta  = CtaBanco
                inner join TBL_Moneda m on m.Id_Moneda = cb.moneda
                left join TBL_Entidad_Financiera eb on eb.ID_Entidad = cb.Banco
                left join TBL_Tipo_Cambio tc on tc.Anio = year(FechaPago) and tc.Mes = MONTH(fechapago) and tc.Dia = DAY(FechaPago)

 

                WHERE f.Estado =1
                ) as x
                 left join TBL_FacturasPresupuestos pp on pp.idFactura = x.Id and pp.tipofactura = 5
                                    left join TBL_Partidas_Control pc on pc.id = pp.idPartida and pc.Tipo = pp.TipoPartida and x.ppto = pc.Tipo

                  WHERE X.FechaPago BETWEEN @fechade AND @fechaa
                                    AND(x.Empresa LIKE '%' + @EMPRESA + '%')
                                    AND(Ruc  LIKE '%' + @PROVEEDOR + '%' OR Razon LIKE '%' + @PROVEEDOR + '%')
                                    AND X.Cuenta LIKE '%' + @GLOSA + '%'  AND X.NroComprobante LIKE '%' + @nrocompro + '%'
                                    and (isnull(pc.id,0)= @ocultar or @ocultar=1)
                                    ORDER BY Empresa ASC, FechaPago ASC; 
 ";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fechade", fechade);
                cmd.Parameters.AddWithValue("@fechaa", fechaa);
                cmd.Parameters.AddWithValue("@EMPRESA", empresa);
                cmd.Parameters.AddWithValue("@PROVEEDOR", proveedor);
                cmd.Parameters.AddWithValue("@GLOSA", nrocta);
                cmd.Parameters.AddWithValue("@nrocompro", nrocomprobante);
                cmd.Parameters.AddWithValue("@ocultar", ocultarpp);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable DetraccionesPorPAgarFechas(int idEmpresa, DateTime fechade, DateTime fechaa)

        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                 SELECT 0 AS opcion,IIF(f.tipo = 0,2,3) id_comprobante,dbo.NameComprobante(IIF(f.tipo = 0,2,3)) Tipo,f.NroFactura,f.Proveedor,pro.razon_social
        AS razon,f.Moneda,m.NameCorto,dbo.GetTipodeCambio(f.FechaEmision,'Venta') TC,AVG(Detraccion) - ISNULL--
                                                                                     (
                                                                                      (
               SELECT SUM(x.importepen)
               FROM TBL_Detraccion_Pago AS x
               WHERE x.NroFactura = f.NroFactura
                     AND x.Proveedor = f.Proveedor
                     AND estado = 1
                     AND x.id_comprobante = IIF(f.tipo = 0,2,3)
                                                                                      ),0) AS BaseMO--
        ,IIF(f.Moneda = 1,AVG(Detraccion) - ISNULL(
                                                   (
                                                    (
               SELECT SUM(x.importepen)
               FROM TBL_Detraccion_Pago AS x
               WHERE x.NroFactura = f.NroFactura
                     AND x.Proveedor = f.Proveedor
                     AND estado = 1
                     AND x.id_comprobante = IIF(f.tipo = 0,2,3)
                                                    )
                                                   ),0),AVG(Detraccion) * dbo.GetTipodeCambio(f.FechaEmision,'Venta') - ISNULL--
                                                        (
                                                         (
                                                          (
               SELECT SUM(x.importepen)
               FROM TBL_Detraccion_Pago AS x
               WHERE x.NroFactura = f.NroFactura
                     AND x.Proveedor = f.Proveedor
                     AND estado = 1
                     AND x.id_comprobante = IIF(f.tipo = 0,2,3)
                                                          )
                                                         ),0)) AS BasePEN,0.00 redondeo,0.00 diferencia,FechaEmision,FechaRecepcion,FechaCancelado,
                                                         FechaEmision FechaContable,ISNULL(nro_cta_detracciones,0) AS nro_cta_detracciones,SUM(total)
                                                         total,'0' cod_detraccion
        --select *  
        FROM TBL_Factura AS f
             INNER JOIN TBL_Orden_Compra AS o ON o.Numero = f.OrdenCompra
             INNER JOIN TBL_Orden_Pedido_Cabecera AS p ON p.Numero = o.Pedido
             INNER JOIN TBL_Proyecto AS pr ON pr.Id_Proyecto = p.id_proyecto
                                              AND pr.Id_Empresa = @Empresa
             INNER JOIN TBL_Proveedor AS pro ON pro.RUC = f.Proveedor
             INNER JOIN TBL_Moneda AS m ON m.Id_Moneda = f.Moneda
        --LEFT JOIN (select sum(x.Importe)importe,x.NroFactura,x.Proveedor  from TBL_Detraccion_Pago x
        --group by NroFactura,Proveedor) AS pg ON pg.nrofactura = f.NroFactura
        --																			AND f.Proveedor = pg.proveedor
        GROUP BY f.NroFactura,f.Proveedor,f.Moneda,f.FechaEmision,f.FechaRecepcion,f.FechaCancelado,NameCorto,Detraccion,pro.razon_social,
        nro_cta_detracciones,f.Tipo
        HAVING AVG(Detraccion) - (ISNULL(
                                         (
               SELECT SUM(x.importemo)
               FROM TBL_Detraccion_Pago AS x
               WHERE x.NroFactura = f.NroFactura
                     AND x.Proveedor = f.Proveedor
                     AND estado = 1
                     AND x.id_comprobante = IIF(f.tipo = 0,2,3)
                                         ),0)) != 0
        --FACTURA MANUAL
        UNION
        SELECT 0 AS opcion,f.IdComprobante,dbo.NameComprobante(f.IdComprobante),f.NroComprobante,f.Proveedor,pro.razon_social AS razon,f.Moneda,m.
        NameCorto,dbo.GetTipodeCambio(f.FechaEmision,'Venta') TC,--
        AVG(Detraccion) - ISNULL--
        (
         (
               SELECT SUM(x.ImporteMO)
               FROM TBL_Detraccion_Pago AS x
               WHERE x.NroFactura = f.NroComprobante
                     AND x.Proveedor = f.Proveedor
                     AND estado = 1
                     AND x.id_comprobante = f.IdComprobante
         ),0) AS BaseMO,--
        IIF(f.Moneda = 1,AVG(Detraccion) - ISNULL--
                         (
                          (
                           (
               SELECT SUM(x.importepen)
               FROM TBL_Detraccion_Pago AS x
               WHERE x.NroFactura = f.NroComprobante
                     AND x.Proveedor = f.Proveedor
                     AND estado = 1
                     AND x.id_comprobante = f.IdComprobante
                           )
                          ),0),AVG(Detraccion) * dbo.GetTipodeCambio(f.FechaEmision,'Venta') - ISNULL--
                               (
                                (--
               (
               SELECT SUM(x.importepen)
               FROM TBL_Detraccion_Pago AS x
               WHERE x.NroFactura = f.NroComprobante
                     AND x.Proveedor = f.Proveedor
                     AND estado = 1
                     AND x.id_comprobante = f.IdComprobante
               )
                                ),0)) AS BasePEN--
        ,0.0 redondeo,0.0 diferencia,FechaEmision,FechaRecepcion,FechaVencimiento,FechaContable,ISNULL(nro_cta_detracciones,0) AS
        nro_cta_detracciones,SUM(total) total,Cod_Detraccion
        FROM TBL_FacturaManual AS f
             INNER JOIN TBL_Proyecto AS pr ON pr.Id_Proyecto = f.Proyecto
                                              AND pr.Id_Empresa = @Empresa
             INNER JOIN TBL_Proveedor AS pro ON pro.RUC = f.Proveedor
             INNER JOIN TBL_Moneda AS m ON m.Id_Moneda = f.Moneda
        WHERE Estado != 0
              AND Compensacion = 0
			  and FechaContable between @fechade and @fechaa
        GROUP BY f.NroComprobante,f.Proveedor,f.Moneda,f.FechaEmision,f.FechaRecepcion,f.FechaVencimiento,FechaContable,NameCorto,Detraccion,pro.
        razon_social,nro_cta_detracciones,f.IdComprobante,Cod_Detraccion
        HAVING AVG(Detraccion) - (ISNULL(
                                         (
               SELECT SUM(x.importemo)
               FROM TBL_Detraccion_Pago AS x
               WHERE x.NroFactura = f.NroComprobante
                     AND x.Proveedor = f.Proveedor
                     AND estado = 1
                     AND x.id_comprobante = f.IdComprobante
                                         ),0)) > 1
        ORDER BY f.FechaCancelado ASC
 ";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fechade", fechade);
                cmd.Parameters.AddWithValue("@fechaa", fechaa);
                cmd.Parameters.AddWithValue("@Empresa", idEmpresa);


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}