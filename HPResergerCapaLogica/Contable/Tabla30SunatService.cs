using System;
using System.Data;
using System.Data.SqlClient;
using HPResergerCapaDatos;

namespace HPResergerCapaLogica.Contable
{
    public class ClaseContable
    {
        private readonly string _connectionString;

        public ClaseContable()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }
        // Obtener todos los registros como DataTable
        public DataTable GetAllAsDataTable30Sunat()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT Numero, Descripcion FROM TBL_Tabla30Sunat";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
        public DataTable GetAllCuentasValidasDetalle()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
                SELECT 
                    Id_Cuenta_Contable AS 'id', 
                    Cuenta_Contable AS 'cuentacontable'
                FROM
                    TBL_Cuenta_Contable
                WHERE
                    EstadoCta = 1
                    AND CtaDetalle = 1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public object reporteRegistrosPorUsuario(DateTime fechaReportar)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"            

                    SELECT 
                        u.Login_User AS usuario,
                        CAST(ax.Fecha AS DATE) AS fecha,
                        DATEPART(HOUR, ax.Fecha) AS hora,
                        COUNT(ax.Usuario) AS registros
                    FROM 
                        TBL_Asiento_Contable_Aux ax
                    LEFT JOIN 
                        tbl_usuario u ON u.Codigo_User = ax.Usuario
                    WHERE 
                        MONTH(ax.Fecha) = MONTH(@fecha)
                        AND YEAR(ax.Fecha) = YEAR(@fecha)
                        AND u.Login_User IS NOT NULL
                    GROUP BY 
                        u.Login_User,
                        CAST(ax.Fecha AS DATE),
                        DATEPART(HOUR, ax.Fecha)
                    ORDER BY 
                        Fecha DESC,usuario asc, Hora DESC, Registros DESC;


                    
";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@fecha", fechaReportar);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public DataTable GetAllCuentasValidasDetalleRango(int all, string de, string a)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
                SELECT 
                    Id_Cuenta_Contable AS 'id', 
                    Cuenta_Contable AS 'cuentacontable'
                FROM
                    TBL_Cuenta_Contable
                WHERE
                    EstadoCta = 1
                    AND CtaDetalle = 1
                AND (
                        @all = 1
                        OR Id_Cuenta_Contable BETWEEN @rangode AND @rangoa
                    )
";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@all", all);
                adapter.SelectCommand.Parameters.AddWithValue("@rangode", de);
                adapter.SelectCommand.Parameters.AddWithValue("@rangoa", a);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public DataTable MayorporCuentas(DateTime fechaIni, DateTime fechaFin, string buscarcuenta, string buscarGlosa, string buscarDocumento, string buscarEmpresa, string buscarRazon)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
      	DECLARE @EmpresasFiltro TABLE (Id_Empresa INT)    
	-- Insertar valores en la tabla temporal si no es el valor por defecto
	IF @Empresa <> '0'
	BEGIN
		INSERT INTO @EmpresasFiltro (Id_Empresa)
		SELECT value FROM STRING_SPLIT(REPLACE(@Empresa, ' ', ''), ',')
		WHERE value <> ''
	END

DECLARE @GlosaFiltro TABLE (GlosaBusqueda NVARCHAR(max))
-- Insertar valores en la tabla temporal si no es el valor por defecto
IF @Glosas <> ''
BEGIN
-- Limpiar espacios y dividir los valores
INSERT INTO @GlosaFiltro (GlosaBusqueda)
SELECT LTRIM(RTRIM(value)) 
FROM STRING_SPLIT(REPLACE(@Glosas, ' ', ''), ';')
WHERE value <> ''
END

	DECLARE @CuentasFiltro TABLE (CodigoCuenta NVARCHAR(50))
	-- Insertar valores en la tabla temporal si no es el valor por defecto
	IF @cuentas <> '(0=0)'
	BEGIN
	-- Limpiar espacios y dividir los valores
	INSERT INTO @CuentasFiltro (CodigoCuenta)
	SELECT LTRIM(RTRIM(value)) 
	FROM STRING_SPLIT(REPLACE(@cuentas, ' ', ''), ';')
	WHERE value <> ''
	END

DECLARE @nroDocFiltro TABLE (NumDocFitros NVARCHAR(max))
-- Insertar valores en la tabla temporal si no es el valor por defecto
IF @NroDoc <> ''
BEGIN
-- Limpiar espacios y dividir los valores
INSERT INTO @nroDocFiltro(NumDocFitros)
SELECT LTRIM(RTRIM(value)) 
FROM STRING_SPLIT(REPLACE(@NroDoc, ' ', ''), ';')
WHERE value <> ''
END

	DECLARE @RazonSocialFiltro TABLE (RazonSocialF NVARCHAR(max))
	-- Insertar valores en la tabla temporal si no es el valor por defecto
	IF @RazonSocial <> ''
	BEGIN
	-- Limpiar espacios y dividir los valores
	INSERT INTO @RazonSocialFiltro(RazonSocialF)
	SELECT LTRIM(RTRIM(value)) 
	FROM STRING_SPLIT(REPLACE(@RazonSocial, ' ', ''), ';')
	WHERE value <> ''
	END

-- Ajustar fecha de inicio
--SET @Fechaini = DATEFROMPARTS(YEAR(@fechaini), MONTH(@fechaini), 1)
    
    SELECT 
        X.Periodo,
        X.RUC,
        X.Cod_Asiento_Contable,
        X.Empresa,
        X.FechaContable,
        x.FechaRegistro,
        X.FechaEmision,
        x.Id_Comprobante,
        x.TipoComprobante,
        X.Cod_Comprobante,
        X.Num_Comprobante,
        x.Num_Doc,
        UPPER(x.Razon_Social) AS Razon_Social,
        UPPER(ISNULL(X.Glosa, '')) AS Glosa,
        X.Cuenta_Contable,
        X.DESCRIPCION,
        ISNULL(x.nro_cta, '') AS CuentaBanco,
        X.Moneda,
        CAST(IIF(x.credito+x.debito=0,
                IIF(X.Cuenta_Contable='7599103' OR X.Cuenta_Contable='7761101' OR X.Cuenta_Contable='6595101' OR X.Cuenta_Contable='6761101', -1, 1),
                IIF(X.CREDITO > 0, -1, 1)) * x.Importe_MN AS DECIMAL(20,6)) AS PEN,
        CAST(IIF(X.CREDITO+x.debito=0,
                IIF(X.Cuenta_Contable='7599103' OR X.Cuenta_Contable='7761101' OR X.Cuenta_Contable='6595101' OR X.Cuenta_Contable='6761101', -1, 1),
                IIF(x.credito > 0, -1, 1)) * X.Importe_ME AS DECIMAL(20,6)) AS USD,
        X.Mes,
        ISNULL(X.TipoCambio, x.TC) AS TipoCambio,
        ISNULL(Login_User, 'SYSADMIN') AS Users
    FROM
    (
        SELECT 
            CONCAT(YEAR(ISNULL(Fecha_Asiento_Valor, a.Fecha_Asiento)), FORMAT(MONTH(ISNULL(Fecha_Asiento_Valor, a.Fecha_Asiento)), '00')) AS Periodo,
            e.ruc AS RUC,
            a.Cod_Asiento_Contable,
            e.Empresa,
            e.id_empresa,
            CAST(ISNULL(a.Fecha_Asiento_Valor, A.Fecha_Asiento) AS DATE) AS FechaContable,
            CAST(ISNULL(f.fecha, ISNULL(a.Fecha_Asiento, a.Fecha_Asiento)) AS DATE) AS FechaRegistro,
            CAST(f.Fecha_Emision AS DATE) AS FechaEmision,
            g.Cod_sunat AS Id_Comprobante,
            g.Nombre AS TipoComprobante,
            f.Cod_Comprobante AS Cod_Comprobante,
            f.Num_Comprobante AS Num_Comprobante,
            f.Num_Doc,
            f.Razon_Social,
            ISNULL(F.GLOSA, a.Glosa) AS GLOSA,
            a.Cuenta_Contable,
            b.Cuenta_Contable AS Descripcion,
            c.NameCorto AS Moneda,
            a.Saldo_Debe AS Debito,
            a.Saldo_Haber AS Credito,
            MONTH(ISNULL(Fecha_Asiento_Valor, a.Fecha_Asiento)) AS Mes,
            IIF(f.Tipo_Cambio = 0, a.tc, f.Tipo_Cambio) AS TipoCambio,
            IIF(a.Moneda = 2, 
                CAST(ROUND(((a.saldo_debe + a.saldo_haber) * a.tc), 2) AS NUMERIC(15,4)), 
                CAST(ROUND((a.saldo_debe + a.saldo_haber), 2) AS NUMERIC(15,4))) AS Conversion,
            ISNULL(f.Importe_ME, ABS(IIF(a.moneda = 1, (a.saldo_haber - a.saldo_debe) / a.tc, (a.saldo_haber - a.saldo_debe)))) AS Importe_ME,
            ISNULL(f.Importe_MN, ABS(IIF(a.moneda = 1, (a.saldo_haber - a.saldo_debe), (a.saldo_haber - a.saldo_debe) * a.tc))) AS Importe_MN,
            a.id_Asiento,
            a.TC,
            u.Login_User,
            cb.Nro_Cta,
            ISNULL(f.fecha, a.Fecha_Asiento_Valor) AS FechaAX
        FROM TBL_Asiento_Contable a
        INNER JOIN TBL_Cuenta_Contable b ON a.Cuenta_Contable = b.Id_Cuenta_Contable
        INNER JOIN TBL_Proyecto d ON a.id_proyecto = a.id_proyecto AND a.id_proyecto = d.Id_Proyecto
        INNER JOIN TBL_Empresa e ON d.Id_Empresa = e.Id_Empresa
        LEFT JOIN TBL_Asiento_Contable_Aux f ON a.id_Asiento = f.Id_Aux
            AND a.Id_Asiento_Contable = f.Id_Asiento_Contable
            AND a.id_proyecto = f.fk_proyecto
            AND a.Cuenta_Contable = f.Cuenta_Contable
            AND CAST(ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento) AS DATE) = f.Fecha_Asiento
        LEFT JOIN TBL_CtaBancaria cb ON cb.Id_Tipo_Cta = f.Cta_Banco
        LEFT JOIN TBL_Usuario u ON u.Codigo_User = f.Usuario
        LEFT JOIN TBL_Comprobante_Pago g ON IIF(ISNULL(f.Id_Comprobante, 0) = 0, 1, f.Id_Comprobante) = g.Id_Comprobante
        INNER JOIN TBL_Moneda c ON c.Id_Moneda = ISNULL(f.fk_moneda, a.Moneda)
        WHERE a.Cuenta_Contable = b.Id_Cuenta_Contable
            AND a.Cod_Asiento_Contable NOT IN (
                SELECT DISTINCT h.Cod_Asiento_Contable
                FROM TBL_Asiento_Contable h
                INNER JOIN TBL_Proyecto po ON po.Id_Proyecto = h.id_proyecto
                INNER JOIN TBL_Empresa ex ON po.Id_Empresa = ex.Id_Empresa AND ex.Id_Empresa = e.Id_Empresa
                WHERE h.Estado IN (4)
                AND CAST(ISNULL(h.Fecha_Asiento_Valor, h.Fecha_Asiento) AS DATE) BETWEEN @Fechaini AND @FechaFin
            )
            AND CAST(ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento) AS DATE) BETWEEN @Fechaini AND @FechaFin

			AND (@Empresa = '0' OR e.Id_Empresa IN (SELECT Id_Empresa FROM @EmpresasFiltro)) -- Condición modificada

            --AND (@Glosas = '(0=0)' OR (@Glosas <> '(0=0)' AND @Glosas))           
            --AND (@Ruc = '(0=0)' OR (@Ruc <> '(0=0)' AND @Ruc)) 
            --AND (@RazonSocial = '(0=0)' OR (@RazonSocial <> '(0=0)' AND @RazonSocial))

			AND (@cuentas = '' OR 
			EXISTS (
				SELECT CodigoCuenta
				FROM @CuentasFiltro cf 
				WHERE A.Cuenta_Contable LIKE cf.CodigoCuenta + '%'
			    )   
            )

			AND (@Glosas = '' OR 
			EXISTS (
				SELECT GlosaBusqueda
				FROM @GlosaFiltro cf 
				WHERE ( a.Glosa LIKE '%' + cf.GlosaBusqueda + '%'
				or f.Glosa	 LIKE '%' + cf.GlosaBusqueda + '%')
				)
			)

			AND (@RazonSocial = ';' OR 
			EXISTS (
				SELECT cf.RazonSocialF
				FROM @RazonSocialFiltro cf 
				WHERE ( f.Razon_Social LIKE '%' + cf.RazonSocialF + '%'
				or f.Num_Doc LIKE '%' + cf.RazonSocialF + '%')
				)
			)

			AND (@NroDoc = '' OR 
			EXISTS (
				SELECT cf.NumDocFitros
				FROM @nroDocFiltro cf 
				WHERE CONCAT(f.Cod_Comprobante ,'-', f.Num_Comprobante) LIKE '%' + cf.NumDocFitros + '%'				
				)
			)

            AND Id_Dinamica_Contable NOT IN (-50)
    ) AS X
   
    ORDER BY Empresa, periodo, cod_asiento_contable, Cuenta_Contable
";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Fechaini", fechaIni);
                adapter.SelectCommand.Parameters.AddWithValue("@FechaFin", fechaFin);
                adapter.SelectCommand.Parameters.AddWithValue("@cuentas", buscarcuenta);
                adapter.SelectCommand.Parameters.AddWithValue("@Glosas", buscarGlosa);
                adapter.SelectCommand.Parameters.AddWithValue("@NroDoc", buscarDocumento);
                adapter.SelectCommand.Parameters.AddWithValue("@Empresa", buscarEmpresa);
                adapter.SelectCommand.Parameters.AddWithValue("@RazonSocial", buscarRazon);

                adapter.SelectCommand.CommandTimeout = 0;

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public DataTable CompensacionDeCuentas(int empresa, string cuentas, string rucs, string docs, DateTime fechade, DateTime fechahasta)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"  

          
DECLARE @nroDocFiltro TABLE (NumDocFitros NVARCHAR(max))
-- Insertar valores en la tabla temporal si no es el valor por defecto
IF @numdoc <> ''
BEGIN
-- Limpiar espacios y dividir los valores
INSERT INTO @nroDocFiltro(NumDocFitros)
SELECT LTRIM(RTRIM(value)) 
FROM STRING_SPLIT(REPLACE(@numdoc, ' ', ''), ',')
WHERE value <> ''
END

DECLARE @RazonSocialFiltro TABLE (RazonSocialF NVARCHAR(max))
-- Insertar valores en la tabla temporal si no es el valor por defecto
IF @rucs <> ''
BEGIN
-- Limpiar espacios y dividir los valores
INSERT INTO @RazonSocialFiltro(RazonSocialF)
SELECT LTRIM(RTRIM(value)) 
FROM STRING_SPLIT(REPLACE(@rucs, ' ', ''), ',')
WHERE value <> ''
END

	SELECT 0 ok,FORMAT(max(ax.Fecha_Asiento),'yyyyMM') PERIODO,MAX(A.Cod_Asiento_Contable) CUO,max(ax.Fecha_Asiento) FechaContable,min(ax.Fecha_Emision) FechaEmision
			,MAX(ax.Id_Comprobante) IdComprobante,ax.Cod_Comprobante CodComprobante,ax.Num_Comprobante NumComprobante,max(ax.Tipo_Doc )tipodoc,
			ax.Num_Doc NumDoc,MAX(ax.Razon_Social) RazonSocial,max(ax.Cuenta_Contable) Cuenta,c.Cuenta_Contable Descripcion,
			max(ax.Tipo_Cambio) TC,MIN (ax.fk_Moneda) fkmoneda,max(m.NameCorto) NMoneda,
			SUM(IIF(a.Saldo_Debe > 0, ax.Importe_MN, -ax.Importe_MN)) AS PEN,
			SUM(IIF(a.Saldo_Debe > 0, ax.Importe_ME, -ax.Importe_ME)) AS USD,
						 						 
			concat(ax.Cod_Comprobante,'-', ax.Num_Comprobante) NroComprobante,0 CC,MAX(ax.Fecha_Vencimiento) FechaVence,
			MAX(AX.Fecha_Recepcion)FechaRecepcion,MAX(AX.Glosa)Glosa,MAX(ax.Cta_Banco)CtaBanco
            FROM 
                TBL_Asiento_Contable a 
				inner join TBL_Cuenta_Contable c on c.Id_Cuenta_Contable = a.Cuenta_Contable
                INNER JOIN TBL_Proyecto p ON a.id_proyecto = p.Id_Proyecto
                INNER JOIN TBL_Empresa e ON e.Id_Empresa = p.Id_Empresa
                INNER JOIN TBL_Asiento_Contable_Aux ax ON a.Id_Asiento_Contable = ax.Id_Asiento_Contable								
                    AND ax.Id_Aux = a.id_Asiento
                    AND a.id_proyecto = ax.fk_proyecto
                    AND ax.Cuenta_Contable = a.Cuenta_Contable
                    AND ax.Fecha_Asiento = CAST(ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento) AS DATE)

					left join TBL_Moneda m on m.Id_Moneda = ax.fk_Moneda
            WHERE 
                e.Id_Empresa IN (SELECT value FROM STRING_SPLIT(@empresa, ','))
                AND EXISTS (
                    SELECT 1 FROM STRING_SPLIT(@cuentas, ',') 
                    WHERE LEFT(a.Cuenta_Contable, LEN(value)) = value
                )
                AND a.Estado = 1

			AND (@numdoc = '' OR 
			EXISTS (
				SELECT cf.NumDocFitros
				FROM @nroDocFiltro cf 
				WHERE CONCAT(ax.Cod_Comprobante ,'-', ax.Num_Comprobante) LIKE '%' + cf.NumDocFitros + '%'				
				)
			)

			AND (@rucs = '' OR 
			EXISTS (
				SELECT rf.RazonSocialF
				FROM @RazonSocialFiltro rf
				WHERE CONCAT(ax.Num_Doc ,'-', ax.Razon_Social) LIKE '%' + rf.RazonSocialF + '%'				
				)
			)

				and ax.Fecha_Asiento between @fechade and @fechahasta
                and Id_Dinamica_Contable not in (-30,-31,-50,-20,-51)

            GROUP BY
                e.Empresa,
                c.Cuenta_Contable,ax.Num_Comprobante,Cod_Comprobante,Num_Doc
            HAVING
               SUM(IIF(a.Saldo_Debe > 0, -ax.Importe_MN, ax.Importe_MN)) <> 0
                or SUM(IIF(a.Saldo_Debe > 0, -ax.Importe_ME, ax.Importe_ME)) <> 0
            ORDER BY 
                e.Empresa ASC, 
                RazonSocial asc, NroComprobante asc;

";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@empresa", empresa.ToString());
                adapter.SelectCommand.Parameters.AddWithValue("@cuentas", cuentas);
                adapter.SelectCommand.Parameters.AddWithValue("@numdoc", docs);
                adapter.SelectCommand.Parameters.AddWithValue("@rucs", rucs);
                adapter.SelectCommand.Parameters.Add("@fechade", SqlDbType.Date).Value = fechade;
                adapter.SelectCommand.Parameters.Add("@fechahasta", SqlDbType.Date).Value = fechahasta;

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
        public DataTable BusquedaProveedorEmpleadoCliente(string ruc)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"    SELECT Tipo_Id tipoid,@numdoc numdoc,Nombre,tipo
                                        FROM
                                            (
                                                SELECT Tipo_Id , razon_social Nombre,1 tipo
                                                FROM TBL_Proveedor
                                                WHERE ruc LIKE @numdoc
                                                    --AND Tipo_Id = @tipoid
                                                UNION all
                                                SELECT Tipo_ID_Emp, UPPER(CONCAT(IIF(Apepat_Emp = '','',apepat_emp + ' '),IIF(Apemat_Emp = '','',Apemat_Emp + ' '),Nombres_Emp)) Nombre,3
                                                FROM TBL_Empleado
                                                WHERE Nro_ID_Emp = @numdoc
                                                UNION AlL
                                                SELECT Tipo_Id_Cli,UPPER(CONCAT(IIF(RTRIM(Apepat_RazSoc_Cli) = ' ','',Apepat_RazSoc_Cli + ' '),IIF(RTRIM(Apemat_Cli) = '','',LTRIM(Apemat_Cli) + ' '),
                                                RTRIM(LTRIM(Nombres_Cli)))) Nombre,2
                                                FROM TBL_Cliente
                                                WHERE  Nro_Id_Cli = @numdoc
                                            ) a;
";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@numdoc", ruc);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public DataTable ListarCuentasContablesActivas()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"select* from TBL_Cuenta_Contable where EstadoCta = 1 and CtaDetalle = 1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public DataTable getDocumentosPendientes(string empresa, string cuentas, DateTime fecha)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
           
				SELECT 
                                e.Empresa, 
                                c.Cuenta_Contable Cuenta_Contable, 
                               sum  (IIF(a.Saldo_Debe > 0, ax.Importe_MN, -ax.Importe_MN)) AS Saldo_Soles,
                              sum   (IIF(a.Saldo_Debe > 0, ax.Importe_ME, -ax.Importe_ME)) AS Saldo_Dolares,
	                            concat(ax.Cod_Comprobante,'-', ax.Num_Comprobante) NroComprobante,Num_Doc, max(Razon_Social)RazonSocial
                                , max(ax.Fecha_Asiento) FechaAsiento,min (A.Cod_Asiento_Contable)Cuo
                            FROM 
                                TBL_Asiento_Contable a 
								inner join TBL_Cuenta_Contable c on c.Id_Cuenta_Contable = a.Cuenta_Contable
                                INNER JOIN TBL_Proyecto p ON a.id_proyecto = p.Id_Proyecto
                                INNER JOIN TBL_Empresa e ON e.Id_Empresa = p.Id_Empresa
                                INNER JOIN TBL_Asiento_Contable_Aux ax ON a.Id_Asiento_Contable = ax.Id_Asiento_Contable
                                    AND ax.Id_Aux = a.id_Asiento
                                    AND a.id_proyecto = ax.fk_proyecto
                                    AND ax.Cuenta_Contable = a.Cuenta_Contable
                                    AND ax.Fecha_Asiento = CAST(ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento) AS DATE)
                            WHERE 
                                e.Id_Empresa IN (SELECT value FROM STRING_SPLIT(@empresa, ','))
                                AND EXISTS (
                                    SELECT 1 FROM STRING_SPLIT(@cuentas, ',') 
                                    WHERE LEFT(a.Cuenta_Contable, LEN(value)) = value
                                )
                                AND a.Estado = 1
                                   and Id_Dinamica_Contable not in (-10)

								   AND ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento) >= DATEFROMPARTS(YEAR(@fecha), 1, 1)
                                 AND ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento) <  DATEADD(DAY, 1, EOMONTH(@fecha))

                            GROUP BY
                                e.Empresa,
                                c.Cuenta_Contable,ax.Num_Comprobante,Cod_Comprobante,Num_Doc
                            HAVING
                                sum  (IIF(a.Saldo_Debe > 0, ax.Importe_MN, -ax.Importe_MN)) <>0 
                              --and sum   (IIF(a.Saldo_Debe > 0, ax.Importe_ME, -ax.Importe_ME)) <>0
                            ORDER BY 
                                e.Empresa ASC,Cuo asc, 
                                RazonSocial asc, NroComprobante asc;
";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@cuentas", cuentas);
                adapter.SelectCommand.Parameters.AddWithValue("@empresa", empresa);
                adapter.SelectCommand.Parameters.AddWithValue("@fecha", fecha);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public DataTable ListarFechasDisponibles(int idEmpresa)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
                        select DISTINCT DATEFROMPARTS( year(isnull(Fecha_Asiento_Valor,Fecha_Asiento)), MONTH(isnull(Fecha_Asiento_Valor,Fecha_Asiento)),1)FECHA from TBL_Asiento_Contable  a
                        inner join TBL_Proyecto p on p.id_proyecto = a.id_proyecto and p.id_empresa = @empresa
                        WHERE Cuenta_Contable < '51' and Estado =1
                        ORDER BY 1 desc";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@empresa", idEmpresa);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public DataTable ListarCuentasUsadas2Digitos(int idEmpresa)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
                    select DISTINCT substring( cuenta_contable,1,2)CUENTA from TBL_Asiento_Contable  a
                    inner join TBL_Proyecto p on p.id_proyecto = a.id_proyecto and p.id_empresa = @empresa
                    WHERE Cuenta_Contable< '51' and Estado =1
                    ORDER BY 1 ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@empresa", idEmpresa);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        // Obtener registro por Id_Empresa como DataTable
        public DataTable GetEmpresaById(int idEmpresa)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM TBL_Empresa WHERE Id_Empresa = @Id_Empresa";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Id_Empresa", idEmpresa);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
        public bool UpdateAsientoContableAux(int idProyecto, DateTime fechaAsiento, string cuenta, int tipoNuevo, string numeroNuevo, string razonNuevo, int iddocNuevo,
            string coddocNuevo, string numdocNuevo, int tipoActual, string numeroActual, string razonActual, int iddocActual, string coddocActual, string numdocActual)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
            UPDATE ax SET 
                Tipo_Doc = @tipoNuevo, 
                Num_Doc = @numeroNuevo, 
                Razon_Social = @razonNuevo, 
                Id_Comprobante = @iddocNuevo, 
                Cod_Comprobante = @coddocNuevo, 
                Num_Comprobante = @numdocNuevo
            FROM TBL_Asiento_Contable_Aux ax 
                 left join TBL_Tipo_ID t on t.Codigo_Tipo_ID = ax.Tipo_Doc
                where fk_proyecto = @idproyecto
                and Cuenta_Contable = @cuenta
                   and isnull(t.Cod_Sunat,0)  = @tipoActual 
              AND ax.Num_Doc = @numeroActual
              AND ax.Razon_Social = @razonActual
              AND ISNULL(ax.Id_Comprobante, 0) = @iddocActual
              AND ISNULL(ax.Cod_Comprobante, '') = @coddocActual
              AND ISNULL(ax.Num_Comprobante, '') = @numdocActual
              AND YEAR(ax.Fecha_Asiento) = YEAR(@fechaAsiento)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parámetros nuevos
                    command.Parameters.AddWithValue("@tipoNuevo", tipoNuevo);
                    command.Parameters.AddWithValue("@numeroNuevo", numeroNuevo);
                    command.Parameters.AddWithValue("@razonNuevo", razonNuevo);
                    command.Parameters.AddWithValue("@iddocNuevo", iddocNuevo);
                    command.Parameters.AddWithValue("@coddocNuevo", coddocNuevo);
                    command.Parameters.AddWithValue("@numdocNuevo", numdocNuevo);

                    // Parámetros actuales (para filtro)
                    command.Parameters.AddWithValue("@tipoActual", tipoActual);
                    command.Parameters.AddWithValue("@numeroActual", numeroActual);
                    command.Parameters.AddWithValue("@razonActual", razonActual);
                    command.Parameters.AddWithValue("@iddocActual", iddocActual);
                    command.Parameters.AddWithValue("@coddocActual", coddocActual);
                    command.Parameters.AddWithValue("@numdocActual", numdocActual);

                    command.Parameters.AddWithValue("@idProyecto", idProyecto);
                    command.Parameters.AddWithValue("@fechaAsiento", fechaAsiento);
                    command.Parameters.AddWithValue("@cuenta", cuenta);

                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }


        public DataTable ListarSaldodelasCuentas(int idEmpresa, string cuentas, DateTime date, out string result)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = @"                    
                    
                     SELECT Empresa, max(fk_proyecto)idProyecto,min(Fecha_Asiento )FechaAsiento,max( Id_Aux)Id_Aux,max (Id_Asiento_Contable)Id_Asiento_Contable	,IdCuentaContable	,CuentaContable	,Tipo,	SubQuery.Numero,	max(Razon_Social )Razon_Social ,	IdComprobante,	Cod_Comprobante,	Num_Comprobante	,min(FechaEmision)FechaEmision,SUM(	Importe_MN)Importe_MN,SUM(	Importe_ME)Importe_ME ,MIN( Cod_Asiento_Contable)  CUO
                          FROM (
                                select ax.Fecha_Asiento,  ax.fk_proyecto, Id_Aux, ax.Id_Asiento_Contable, e.Empresa,a.Cuenta_Contable IdCuentaContable, c.Cuenta_Contable CuentaContable,
                            isnull(t.Cod_Sunat ,0)Tipo,ax.Num_Doc Numero,ax.Razon_Social,ax.Id_Comprobante IdComprobante,ax.Cod_Comprobante,ax.Num_Comprobante,cast(ax.Fecha_Emision as date)FechaEmision,
                            IIF(a.Saldo_Debe>0,1,-1)* Importe_MN Importe_MN,IIF(a.Saldo_Debe>0,1,-1)* Importe_ME Importe_ME ,Cod_Asiento_Contable
                            from TBL_Asiento_Contable a 
                            inner join TBL_Cuenta_Contable c on c.Id_Cuenta_Contable = a.Cuenta_Contable
                            inner join TBL_Proyecto p on p.Id_Proyecto = a.id_proyecto and p.Id_Empresa = @empresa
                            inner join TBL_Empresa e on e.Id_Empresa = p.Id_Empresa
                            left join TBL_Asiento_Contable_Aux ax on ax.Id_Asiento_Contable = a.Id_Asiento_Contable 
                                and ax.Id_Aux = a.id_Asiento 
                                and ax.fk_proyecto = a.id_proyecto
                                and ax.Cuenta_Contable = a.Cuenta_Contable
                                and ax.Fecha_Asiento= CAST(ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento) AS DATE)
                            left join TBL_Tipo_ID t on t.Codigo_Tipo_ID = ax.Tipo_Doc
                       WHERE ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento) >= DATEFROMPARTS(YEAR(@fecha), 1, 1)
                                 AND ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento) <  DATEADD(DAY, 1, EOMONTH(@fecha))

                            and a.Estado in (1,3)
                                and Id_Dinamica_Contable not in (-10)

	                        --and Id_Dinamica_Contable not in (-30,-31)
                            and a.Cuenta_Contable like @cuenta + '%'
                        ) AS SubQuery
                        inner join (
                           SELECT *
                            FROM (
                                SELECT Numero, SUM(Importe_MN) AS TotalImporteMN,SUM(Importe_ME) AS TotalImporte_ME,Cuenta_Contable  
                                FROM (
                                    select isnull( ax.Num_Doc ,0) as Numero,a.Moneda,Cod_Asiento_Contable,a.Cuenta_Contable,a.Fecha_Asiento,
                                    IIF(a.Saldo_Debe>0,1,-1)* isnull(Importe_MN,a.Saldo_Debe+a.Saldo_Haber) * iif(a.Moneda=1,1,a.tc) as Importe_MN,
			                        IIF(a.Saldo_Debe>0,1,-1)* isnull(Importe_ME,a.Saldo_Debe+a.Saldo_Haber) / iif(a.Moneda=2,1,a.tc) as Importe_ME
                                    from TBL_Asiento_Contable a 
                                    inner join TBL_Cuenta_Contable c on c.Id_Cuenta_Contable = a.Cuenta_Contable
                                    inner join TBL_Proyecto p on p.Id_Proyecto = a.id_proyecto and p.Id_Empresa = @empresa
                                    left join TBL_Asiento_Contable_Aux ax on ax.Id_Asiento_Contable = a.Id_Asiento_Contable 
                                        and ax.Id_Aux = a.id_Asiento 
                                        and ax.fk_proyecto = a.id_proyecto
                                        and ax.Cuenta_Contable = a.Cuenta_Contable
                                        and ax.Fecha_Asiento= CAST(ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento) AS DATE)
               
                                    where a.Estado in (1,3) 
                                        and Id_Dinamica_Contable not in (-10)-- and Id_Dinamica_Contable not in (-30,-31)
                                    and a.Cuenta_Contable like @cuenta + '%'
			                        AND ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento) >= DATEFROMPARTS(YEAR(@fecha), 1, 1)
                                 AND ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento) <  DATEADD(DAY, 1, EOMONTH(@fecha))
                                ) AS InnerSubQuery
  
	                         GROUP BY Numero,Cuenta_Contable 
		                           --having SUM(Importe_MN) <> 0 and SUM(Importe_ME) <> 0  
                            ) AS SumQuery
	                           where TotalImporteMN + TotalImporte_ME <> 0 
   
   
                        ) as SumQuery
                           on  SumQuery.Numero = SubQuery.Numero and SumQuery.Cuenta_Contable = SubQuery.IdCuentaContable

                           group by Empresa	,IdCuentaContable	,CuentaContable	,Tipo,	SubQuery.Numero,	IdComprobante,	Cod_Comprobante,	Num_Comprobante

                           having SUM(	Importe_MN) <> 0 --+ SUM(	Importe_ME) <> 0  

                          order by IdCuentaContable, Numero,Cod_Comprobante,Num_Comprobante
                    ";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@empresa", idEmpresa);
                    adapter.SelectCommand.Parameters.AddWithValue("@cuenta", cuentas);
                    adapter.SelectCommand.Parameters.AddWithValue("@fecha", date);

                    adapter.SelectCommand.CommandTimeout = 60;
                    adapter.Fill(dataTable);


                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return dataTable;
            }
            result = string.Empty;
            return dataTable;
        }

        // Obtener registros con número 0 y descripción "ninguno" y luego todos los datos como DataTable
        public DataTable GetAllWithDefaultAsDataTable30Sunat()
        {
            DataTable dataTable = GetAllAsDataTable30Sunat();

            // Agregar fila predeterminada
            DataRow defaultRow = dataTable.NewRow();
            defaultRow["Numero"] = 0;
            defaultRow["Descripcion"] = "NINGUNO";
            dataTable.Rows.InsertAt(defaultRow, 0);

            return dataTable;
        }
        public DataTable GetRelacionByFacturaId(int idFactura)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM TBL_RelacionFacturaSunat WHERE Id_Factura = @Id_Factura";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Id_Factura", idFactura);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
        public bool ActualizarRazonSocialIndividualProveedor(string RUC)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Consulta SQL corregida
                string query = @"
                        UPDATE a 
                        SET a.Razon_Social = p.razon_social
                        FROM TBL_Asiento_Contable_Aux a
                        INNER JOIN TBL_Proveedor p ON a.Num_Doc = p.RUC
                        WHERE p.RUC = @RUC 
                        AND p.razon_social != a.Razon_Social";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RUC", RUC);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool ActualizarRazonSocialIndividualCliente(string RUC)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Consulta SQL corregida
                string query = @"
                        WITH ClientesConRazonSocial AS (
                        SELECT 
                            Nro_Id_Cli,
                            CASE 
                                WHEN Tipo_Persona = 1 THEN LTRIM(RTRIM(Nombres_Cli))
                                WHEN Tipo_Persona = 2 THEN LTRIM(RTRIM(
                                    CONCAT(
                                        COALESCE(Apepat_RazSoc_Cli, ''), 
                                        CASE WHEN Apepat_RazSoc_Cli IS NOT NULL AND Apemat_Cli IS NOT NULL THEN ' ' ELSE '' END,
                                        COALESCE(Apemat_Cli, ''), 
                                        CASE WHEN (Apepat_RazSoc_Cli IS NOT NULL OR Apemat_Cli IS NOT NULL) AND Nombres_Cli IS NOT NULL THEN ' ' ELSE '' END,
                                        COALESCE(Nombres_Cli, '')
                                    )
                                ))
                            END AS Razon_Social_Calculada
                        FROM TBL_Cliente
                        WHERE Nro_Id_Cli NOT IN (SELECT RUC FROM TBL_Proveedor UNION ALL SELECT Nro_ID_Emp FROM TBL_Empleado)
                    )
                    UPDATE a
                    SET a.Razon_Social = c.Razon_Social_Calculada
                    FROM TBL_Asiento_Contable_Aux a
                    INNER JOIN ClientesConRazonSocial c ON a.Num_Doc = c.Nro_Id_Cli 
                    WHERE a.Razon_Social != c.Razon_Social_Calculada
                    AND C.Nro_Id_Cli = @RUC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RUC", RUC);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool ActualizarRazonSocialIndividualEmpleado(string RUC)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Consulta SQL corregida
                string query = @"
                    WITH EmpleadosConRazonSocial AS (
                        SELECT 
                            Nro_ID_Emp,
                            LTRIM(RTRIM(
                                CONCAT(
                                    COALESCE(Apepat_Emp, ''), 
                                    CASE WHEN Apepat_Emp IS NOT NULL AND Apemat_Emp IS NOT NULL THEN ' ' ELSE '' END,
                                    COALESCE(Apemat_Emp, ''), 
                                    CASE WHEN (Apepat_Emp IS NOT NULL OR Apemat_Emp IS NOT NULL) AND Nombres_Emp IS NOT NULL THEN ' ' ELSE '' END,
                                    COALESCE(Nombres_Emp, '')
                                )
                            )) AS Razon_Social_Calculada
                        FROM TBL_Empleado
                        WHERE Nro_ID_Emp NOT IN (SELECT RUC FROM TBL_Proveedor)
                    )
                    UPDATE a
                    SET a.Razon_Social = e.Razon_Social_Calculada
                    FROM TBL_Asiento_Contable_Aux a
                    INNER JOIN EmpleadosConRazonSocial e ON a.Num_Doc = e.Nro_ID_Emp 
                    WHERE a.Razon_Social != e.Razon_Social_Calculada
                    and e.Nro_ID_Emp = @RUC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RUC", RUC);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public DataTable ReemplazarRazonesSocialesCambiadas()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
                -- Primera CTE y UPDATE para Proveedores
                WITH ProveedoresParaActualizar AS (
                    SELECT p.RUC, p.razon_social
                    FROM TBL_Proveedor p
                    INNER JOIN TBL_Asiento_Contable_Aux a ON a.Num_Doc = p.RUC 
                    WHERE p.razon_social != a.Razon_Social
                )
                UPDATE a
                SET a.Razon_Social = p.razon_social
                FROM TBL_Asiento_Contable_Aux a
                INNER JOIN ProveedoresParaActualizar p ON a.Num_Doc = p.RUC;

                -- Segunda CTE y UPDATE para Clientes
                WITH ClientesConRazonSocial AS (
                    SELECT 
                        Nro_Id_Cli,
                        CASE 
                            WHEN Tipo_Persona = 1 THEN LTRIM(RTRIM(Nombres_Cli))
                            WHEN Tipo_Persona = 2 THEN LTRIM(RTRIM(
                                CONCAT(
                                    COALESCE(Apepat_RazSoc_Cli, ''), 
                                    CASE WHEN Apepat_RazSoc_Cli IS NOT NULL AND Apemat_Cli IS NOT NULL THEN ' ' ELSE '' END,
                                    COALESCE(Apemat_Cli, ''), 
                                    CASE WHEN (Apepat_RazSoc_Cli IS NOT NULL OR Apemat_Cli IS NOT NULL) AND Nombres_Cli IS NOT NULL THEN ' ' ELSE '' END,
                                    COALESCE(Nombres_Cli, '')
                                )
                            ))
                        END AS Razon_Social_Calculada
                    FROM TBL_Cliente
                    WHERE Nro_Id_Cli NOT IN (SELECT RUC FROM TBL_Proveedor UNION ALL SELECT Nro_ID_Emp FROM TBL_Empleado)
                )
                UPDATE a
                SET a.Razon_Social = c.Razon_Social_Calculada
                FROM TBL_Asiento_Contable_Aux a
                INNER JOIN ClientesConRazonSocial c ON a.Num_Doc = c.Nro_Id_Cli 
                WHERE a.Razon_Social != c.Razon_Social_Calculada;

                -- Tercera CTE y UPDATE para Empleados
                WITH EmpleadosConRazonSocial AS (
                    SELECT 
                        Nro_ID_Emp,
                        LTRIM(RTRIM(
                            CONCAT(
                                COALESCE(Apepat_Emp, ''), 
                                CASE WHEN Apepat_Emp IS NOT NULL AND Apemat_Emp IS NOT NULL THEN ' ' ELSE '' END,
                                COALESCE(Apemat_Emp, ''), 
                                CASE WHEN (Apepat_Emp IS NOT NULL OR Apemat_Emp IS NOT NULL) AND Nombres_Emp IS NOT NULL THEN ' ' ELSE '' END,
                                COALESCE(Nombres_Emp, '')
                            )
                        )) AS Razon_Social_Calculada
                    FROM TBL_Empleado
                    WHERE Nro_ID_Emp NOT IN (SELECT RUC FROM TBL_Proveedor)
                )
                UPDATE a
                SET a.Razon_Social = e.Razon_Social_Calculada
                FROM TBL_Asiento_Contable_Aux a
                INNER JOIN EmpleadosConRazonSocial e ON a.Num_Doc = e.Nro_ID_Emp 
                WHERE a.Razon_Social != e.Razon_Social_Calculada;

                -- Para proveedores
                SELECT a.*, p.razon_social AS NuevoValor
                FROM TBL_Asiento_Contable_Aux a
                INNER JOIN TBL_Proveedor p ON a.Num_Doc = p.RUC 
                WHERE p.razon_social != a.Razon_Social;
";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
        public DataTable ListarRazonesSocialesCambiadas()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
                    WITH EmpleadosConRazonSocial AS(
                        SELECT
                            Nro_ID_Emp,
                            LTRIM(RTRIM(
                                CONCAT(
                                    COALESCE(Apepat_Emp, ''),
                                    CASE WHEN Apepat_Emp IS NOT NULL AND Apemat_Emp IS NOT NULL THEN ' ' ELSE '' END,
                                    COALESCE(Apemat_Emp, ''),
                                    CASE WHEN(Apepat_Emp IS NOT NULL OR Apemat_Emp IS NOT NULL) AND Nombres_Emp IS NOT NULL THEN ' ' ELSE '' END,
                                    COALESCE(Nombres_Emp, '')
                                )
                            )) AS Razon_Social_Calculada
                        FROM TBL_Empleado
                        WHERE Nro_ID_Emp NOT IN(SELECT RUC FROM TBL_Proveedor)
                    ),
                    ClientesConRazonSocial AS(
                        SELECT
                            Nro_Id_Cli,
                            CASE
                                WHEN Tipo_Persona = 1 THEN LTRIM(RTRIM(Nombres_Cli))
                                WHEN Tipo_Persona = 2 THEN LTRIM(RTRIM(
                                    CONCAT(
                                        COALESCE(Apepat_RazSoc_Cli, ''), 
                                        CASE WHEN Apepat_RazSoc_Cli IS NOT NULL AND Apemat_Cli IS NOT NULL THEN ' ' ELSE '' END,
                                        COALESCE(Apemat_Cli, ''), 
                                        CASE WHEN(Apepat_RazSoc_Cli IS NOT NULL OR Apemat_Cli IS NOT NULL) AND Nombres_Cli IS NOT NULL THEN ' ' ELSE '' END,
                                        COALESCE(Nombres_Cli, '')
                                    )
                                ))
                            END AS Razon_Social_Calculada
                        FROM TBL_Cliente
                        WHERE Nro_Id_Cli NOT IN(SELECT RUC FROM TBL_Proveedor UNION ALL SELECT Nro_ID_Emp FROM TBL_Empleado)
                    )


                        --CORRECCIÓN DE RAZONES SOCIALES EN ASIENTOS CONTABLES DONDE LA RAZÓN DEL PROVEEDOR ESTÁ MAL
                       SELECT 'RAZÓN SOCIAL DE PROVEEDOR MAL' AS Tipo, p.ruc RUC,
                               p.razon_social AS RazonSocialReal,
                               a.Razon_Social AS RazonSocialGuardada
                    --update a set a.Razon_Social = p.razon_social
                       FROM TBL_Asiento_Contable_Aux a
                        INNER JOIN TBL_Proveedor p ON a.Num_Doc = p.RUC AND p.razon_social != a.Razon_Social


                        UNION ALL
                        --CORRECCIÓN DE LAS RAZONES SOCIALES EN ASIENTOS CONTABLES DE EMPLEADOS Y QUE NO SEAN PROVEEDORES

                        SELECT 'RAZÓN SOCIAL DE EMPLEADO MAL' AS TIPO, E.Nro_ID_Emp,
                               e.Razon_Social_Calculada AS RazonSocialReal, 
                               a.Razon_Social AS RazonSocialGuardada
                    --UPDATE a
                    --SET a.Razon_Social = e.Razon_Social_Calculada

                        FROM TBL_Asiento_Contable_Aux a
                        INNER JOIN EmpleadosConRazonSocial e ON a.Num_Doc = e.Nro_ID_Emp
                                                          AND a.Razon_Social != e.Razon_Social_Calculada


                        UNION ALL
                        --CORRECCIÓN DE LAS RAZONES SOCIALES EN ASIENTOS CONTABLES DE CLIENTES Y QUE NO SEAN PROVEEDORES NI EMPLEADOS
                        SELECT 'RAZÓN SOCIAL DE CLIENTE MAL' AS TIPO, c.Nro_Id_Cli ,
                               c.Razon_Social_Calculada AS RazonSocialReal,
                               a.Razon_Social AS RazonSocialGuardada
                    --UPDATE a
                    --SET a.Razon_Social = e.Razon_Social_Calculada
                    FROM TBL_Asiento_Contable_Aux a
                        INNER JOIN ClientesConRazonSocial c ON a.Num_Doc = c.Nro_Id_Cli
                                                         AND a.Razon_Social != c.Razon_Social_Calculada;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public DataTable RevisionAsientos(int empresa, string cuo, int comparar = 1)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
                               
select 
    a.id_Asiento Pos,
    a.Cuenta_Contable Cuenta,
    a.Saldo_Debe Debe,
    a.Saldo_Haber Haber,
    a.Moneda Moneda,
    sum(
        case 
            when a.Saldo_Debe > 0 then ax.Importe_MN
            when a.Saldo_Haber > 0 then -ax.Importe_MN
            else 0
        end
    ) as ImporteMN,
    sum(
        case 
            when a.Saldo_Debe > 0 then ax.Importe_ME
            when a.Saldo_Haber > 0 then -ax.Importe_ME
            else 0
        end
    ) as ImporteME,
    iif(a.moneda=1, a.Saldo_Debe + a.Saldo_Haber - 
        sum(
            case 
                when a.Saldo_Debe > 0 then ax.Importe_MN
                when a.Saldo_Haber > 0 then ax.Importe_MN
                else 0
            end
        ), 
        a.Saldo_Debe + a.Saldo_Haber - 
        sum(
            case 
                when a.Saldo_Debe > 0 then ax.Importe_ME
                when a.Saldo_Haber > 0 then ax.Importe_ME
                else 0
            end
        )
    ) as Diferencia
from TBL_Asiento_Contable a  
inner join TBL_Proyecto p on a.id_proyecto = p.Id_Proyecto
left join TBL_Asiento_Contable_Aux ax 
    on a.Id_Asiento_Contable = ax.Id_Asiento_Contable
    and a.id_Asiento = ax.Id_Aux
    and a.Cuenta_Contable = ax.Cuenta_Contable
    and a.id_proyecto = ax.fk_proyecto
    and CAST(ISNULL(a.Fecha_Asiento_Valor,a.Fecha_Asiento) AS DATE) = ax.Fecha_Asiento
where 
    Cod_Asiento_Contable = @cuo
    and p.Id_Empresa = @empresa
    and a.Cuenta_Contable != ''
    and a.Cod_Asiento_Contable not in (
        select distinct h.Cod_Asiento_Contable
        from TBL_Asiento_Contable h
        inner join TBL_Proyecto po on po.Id_Proyecto = h.id_proyecto
        inner join TBL_Empresa ex on po.Id_Empresa = ex.Id_Empresa
        where h.Estado in (4) and ex.Id_Empresa = @empresa
    )
group by 
    a.id_Asiento, 
    a.Cuenta_Contable, 
    a.Saldo_Debe, 
    a.Saldo_Haber, 
    a.Moneda
having 
    (iif(a.moneda=1, a.Saldo_Debe + a.Saldo_Haber - 
        sum(
            case 
                when a.Saldo_Debe > 0 then ax.Importe_MN
                when a.Saldo_Haber > 0 then -ax.Importe_MN
                else 0
            end
        ),
        a.Saldo_Debe + a.Saldo_Haber - 
        sum(
            case 
                when a.Saldo_Debe > 0 then ax.Importe_ME
                when a.Saldo_Haber > 0 then -ax.Importe_ME
                else 0
            end
        )
    )) != 0 
    or @comparar = 0
order by Diferencia desc;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.SelectCommand.Parameters.Add(new SqlParameter("@empresa", SqlDbType.Int) { Value = empresa });
                adapter.SelectCommand.Parameters.Add(new SqlParameter("@cuo", SqlDbType.VarChar, 20) { Value = cuo }); // Ajusta el tamaño según tu campo
                adapter.SelectCommand.Parameters.Add(new SqlParameter("@comparar", SqlDbType.Int) { Value = comparar });

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public void UpdateOrInsertRelacion(int idFactura, int numeroTablaSunat)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Verificar si el registro existe
                string checkQuery = "SELECT COUNT(*) FROM TBL_RelacionFacturaSunat WHERE Id_Factura = @Id_Factura";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@Id_Factura", idFactura);

                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    // Actualizar el registro existente
                    string updateQuery = "UPDATE TBL_RelacionFacturaSunat SET Numero_TablaSunat = @Numero_TablaSunat WHERE Id_Factura = @Id_Factura";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@Id_Factura", idFactura);
                    updateCommand.Parameters.AddWithValue("@Numero_TablaSunat", numeroTablaSunat);

                    updateCommand.ExecuteNonQuery();
                }
                else
                {
                    // Insertar nuevo registro
                    string insertQuery = "INSERT INTO TBL_RelacionFacturaSunat (Id_Factura, Numero_TablaSunat) VALUES (@Id_Factura, @Numero_TablaSunat)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@Id_Factura", idFactura);
                    insertCommand.Parameters.AddWithValue("@Numero_TablaSunat", numeroTablaSunat);

                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        public bool ActualizarDetalledeAsientos(int idProyecto, int i, int idAsiento, DateTime fecha)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Consulta SQL corregida
                string query = @"

                 declare @factor as decimal(20,10) =0

                select  @factor=iif(a.Moneda =1,  
                    (Saldo_Debe + Saldo_Haber) / NULLIF(SUM(Importe_MN), 0),
                    (Saldo_Debe + Saldo_Haber) / NULLIF(SUM(Importe_ME), 0))

                    FROM TBL_Asiento_Contable a
                                            INNER JOIN TBL_Proyecto p ON a.id_proyecto = p.Id_Proyecto	
                                            --Detalle
                                            LEFT JOIN TBL_Asiento_Contable_Aux ax ON a.Id_Asiento_Contable = ax.Id_Asiento_Contable
                                                                                        AND a.id_Asiento = ax.Id_Aux
                                                                                        AND a.Cuenta_Contable = Ax.Cuenta_Contable
                                                                                        AND a.id_proyecto = ax.fk_proyecto
                                                                                        AND CAST(ISNULL(a.Fecha_Asiento_Valor,a.Fecha_Asiento) AS DATE) = ax.
                                                                                        Fecha_Asiento
                where 

                    p.Id_Proyecto =@proyecto 
                    and a.Id_Asiento_Contable =@idasiento
                    and id_Asiento = @i
                    and cast(isnull(a.Fecha_Asiento_Valor ,a.Fecha_Asiento) as date)= @fecha
                    group by Saldo_Debe,Saldo_Haber,a.Moneda

                    --select @factor factor
                 UPDATE ax set ax.Importe_MN= round(ax.Importe_MN * @factor,2), ax.Importe_ME= round(Importe_ME *@factor ,2)
                    FROM TBL_Asiento_Contable a
                                            INNER JOIN TBL_Proyecto p ON a.id_proyecto = p.Id_Proyecto	
                                            --Detalle
                                            LEFT JOIN TBL_Asiento_Contable_Aux ax ON a.Id_Asiento_Contable = ax.Id_Asiento_Contable
                                                                                        AND a.id_Asiento = ax.Id_Aux
                                                                                        AND a.Cuenta_Contable = Ax.Cuenta_Contable
                                                                                        AND a.id_proyecto = ax.fk_proyecto
                                                                                        AND CAST(ISNULL(a.Fecha_Asiento_Valor,a.Fecha_Asiento) AS DATE) = ax.
                                                                                        Fecha_Asiento
                where 
                    (Saldo_Debe + Saldo_Haber) !=0 and
                    p.Id_Proyecto =@proyecto 
                    and a.Id_Asiento_Contable =@idasiento
                    and id_Asiento = @i
                    and cast(isnull(a.Fecha_Asiento_Valor ,a.Fecha_Asiento) as date)= @fecha

";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@proyecto", idProyecto);
                    command.Parameters.AddWithValue("@idasiento", idAsiento);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@i", i);



                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
