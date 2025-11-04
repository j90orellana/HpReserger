using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica.FlujoCaja
{
    public class SaldosCuentasBancarias
    {
        public int Id { get; set; } = 0;
        public int IdCtaBancaria { get; set; } = 0;
        public DateTime Fecha { get; set; } = DateTime.Now.Date;
        public decimal SaldoInicial { get; set; } = 0;
        public decimal SaldoFinal { get; set; } = 0;
        public int IdUsuario { get; set; } = 0;
        public string NroCuentaBancaria { get; set; } = "";

        private readonly string _connectionString;

        public SaldosCuentasBancarias()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }
        public int InsertarSaldoInicial(SaldosCuentasBancarias saldo)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
            declare @idCtaBancaria as int=0
            select @idCtaBancaria=Id_Tipo_Cta from TBL_CtaBancaria where Nro_Cta  = @nrocuenta            

            IF EXISTS (SELECT 1 FROM TBL_SaldosCuentasBancarias 
                       WHERE idCtaBancaria = @idCtaBancaria AND fecha = @fecha)
            BEGIN
                UPDATE TBL_SaldosCuentasBancarias
                SET saldoInicial = @saldoInicial,
                    idUsuario = @idUsuario
                WHERE idCtaBancaria = @idCtaBancaria AND fecha = @fecha;

                SELECT id FROM TBL_SaldosCuentasBancarias 
                WHERE idCtaBancaria = @idCtaBancaria AND fecha = @fecha;
            END
            ELSE
            BEGIN
                INSERT INTO TBL_SaldosCuentasBancarias 
                    (idCtaBancaria, fecha, saldoInicial, saldoFinal, idUsuario)
                OUTPUT INSERTED.id
                VALUES (@idCtaBancaria, @fecha, @saldoInicial, 0, @idUsuario);
            END";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nrocuenta", saldo.NroCuentaBancaria);
                cmd.Parameters.AddWithValue("@fecha", saldo.Fecha);
                cmd.Parameters.AddWithValue("@saldoInicial", saldo.SaldoInicial);
                cmd.Parameters.AddWithValue("@idUsuario", saldo.IdUsuario);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public object ObtenerMovimientossindatos()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"




select 
*

from (
SELECT DISTINCT
   e.Id_Empresa idempresa,cb.Id_Tipo_Cta idCtaBanco,a.Cuenta_Contable,
   e.Empresa,   
    --a.Id_Asiento_Contable fkid,
    --a.id_Asiento fkiddet,
    --a.Cuenta_Contable cuenta,
    --a.id_proyecto fkproyecto,
    --CAST(ISNULL(a.fecha_asiento_Valor, a.fecha_asiento) AS DATE) fecha,
    (CAST(eomonth( ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento)) AS DATE)) AS FechaOperacion,
ISNULL(NULLIF(cb.Nro_Cta, ''), '') 'CtaBancaria',
    --CAST(ISNULL(NULLIF(a.Glosa, ''), '-') AS NVARCHAR(200)) AS Glosa,
    --ISNULL(tp.Cod_Sunat, '-') AS TipoDoc,
    --ISNULL(NULLIF(ax.Num_Doc, '0'), '-') AS NumDoc,
    --CAST(ISNULL(NULLIF(ax.Razon_Social, ''), 'VARIOS') AS NVARCHAR(200)) AS Beneficiario,
    --CAST(ISNULL(NULLIF(ax.NroOPBanco, ''), '-') AS NVARCHAR(20)) AS NroOpBanco,
    IIF(Saldo_Debe>0,1,-1)* ax.Importe_MN SOLES,
    IIF(Saldo_Debe>0,1,-1)* ax.Importe_ME DOLARES, cb.Banco,cb.Moneda idmoneda ,m.Moneda
    --ISNULL(NULLIF(ax.Num_Comprobante, '0'), '-') AS NumComprobante,

	--IIF( IIF(Saldo_Debe>0,1,-1)* ax.Importe_MN +  IIF(Saldo_Debe>0,1,-1)* ax.Importe_ME >0 ,'INGRESO','EGRESO') 'Tipo' ,

    --idpartida pkidpp, 
    --idpartida IdPP
	,a.Cod_Asiento_Contable cuo
	
FROM TBL_Asiento_Contable a
INNER JOIN TBL_Proyecto p ON a.id_proyecto = p.Id_Proyecto
INNER JOIN TBL_Empresa e ON p.Id_Empresa = e.Id_Empresa
--and (e.Id_Empresa IN (
--    SELECT TRY_CAST(value AS INT)
--    FROM STRING_SPLIT(@EMPRESA, ',')
--    WHERE TRY_CAST(value AS INT) IS NOT NULL
--) OR @EMPRESA =''
--)

LEFT JOIN TBL_Asiento_Contable_Aux ax ON a.Id_Asiento_Contable = ax.Id_Asiento_Contable
    AND a.id_Asiento = ax.Id_Aux
    AND a.Cuenta_Contable = Ax.Cuenta_Contable
    AND a.id_proyecto = ax.fk_proyecto
    AND CAST(ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento) AS DATE) = ax.Fecha_Asiento
--LEFT JOIN TBL_Tipo_ID tp ON tp.Codigo_Tipo_ID = ax.Tipo_Doc
left join TBL_CtaBancaria cb on cb.Id_Tipo_Cta = ax.Cta_Banco
left join TBL_Moneda m on m.Id_Moneda = cb.Moneda

--LEFT JOIN TBL_MovimientoPartidas pp ON pp.fkid = a.Id_Asiento_Contable 
    --AND pp.fkiddet = id_Asiento 
    --AND pp.fecha = CAST(ISNULL(a.fecha_asiento_Valor, a.fecha_asiento) AS DATE)
    --AND pp.cuenta = a.Cuenta_Contable
    --AND pp.fkproyecto = a.id_proyecto
--LEFT JOIN TBL_Partidas_Control pc ON pc.id = pp.idPartida AND pc.Tipo = e.ppto
WHERE a.Cuenta_Contable BETWEEN '104' AND '108'
and Id_Dinamica_Contable not in (-30)
    --AND CAST(ISNULL(a.fecha_asiento_Valor, a.fecha_asiento) AS DATE) BETWEEN @fechade AND @fechaa
    --AND (E.Empresa LIKE '%' + @EMPRESA + '%')
    --AND (ax.Razon_Social LIKE '%' + @PROVEEDOR + '%' OR ax.Num_Doc LIKE '%' + @PROVEEDOR + '%')
    --AND a.Glosa LIKE '%' + @GLOSA + '%'  
    --AND CONCAT(ax.Cod_Comprobante,'-', ax.Num_Comprobante) LIKE '%' + @nrocompro + '%'
    --AND (ISNULL(pc.id,0) = @ocultar OR @ocultar = 1)
    AND NOT EXISTS (
        SELECT 1
        FROM TBL_Asiento_Contable h
        INNER JOIN TBL_Proyecto po ON po.Id_Proyecto = h.id_proyecto
        INNER JOIN TBL_Empresa ex ON po.Id_Empresa = ex.Id_Empresa AND ex.Id_Empresa = e.Id_Empresa
        WHERE h.Estado in(0,4)
            AND h.Cod_Asiento_Contable = a.Cod_Asiento_Contable
            --AND CAST(ISNULL(h.Fecha_Asiento_Valor, h.Fecha_Asiento) AS DATE) BETWEEN @fechade AND @fechaa
    )
)as x
 --where   (CtaBancaria LIKE '%' + @CUENTABANCARIA + '%')
   --AND (Tipo LIKE '%' + @TIPOMOVIMIENTO + '%')

   --GROUP BY idempresa,	idCtaBanco,	Empresa,	FechaOperacion,	CtaBancaria,			Banco,	idmoneda,	Moneda
   --where ( SOLES) IS  NULL AND (	DOLARES)  IS  NULL
   where x.CtaBancaria =''

ORDER BY x.Empresa ASC,X.MONEDA ASC, X.CtaBancaria ASC,FechaOperacion DESC





";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public int InsertarSaldoFinal(SaldosCuentasBancarias saldo)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
            declare @idCtaBancaria as int=0
            select @idCtaBancaria=Id_Tipo_Cta from TBL_CtaBancaria where Nro_Cta  = @nrocuenta            

            IF EXISTS (SELECT 1 FROM TBL_SaldosCuentasBancarias 
                       WHERE idCtaBancaria = @idCtaBancaria AND fecha = @fecha)
            BEGIN
                UPDATE TBL_SaldosCuentasBancarias
                SET saldoFinal = @saldoFinal,
                    idUsuario = @idUsuario
                WHERE idCtaBancaria = @idCtaBancaria AND fecha = @fecha;

                SELECT id FROM TBL_SaldosCuentasBancarias 
                WHERE idCtaBancaria = @idCtaBancaria AND fecha = @fecha;
            END
            ELSE
            BEGIN
                INSERT INTO TBL_SaldosCuentasBancarias 
                    (idCtaBancaria, fecha, saldoInicial, saldoFinal, idUsuario)
                OUTPUT INSERTED.id
                VALUES (@idCtaBancaria, @fecha, 0, @saldoFinal, @idUsuario);
            END";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nrocuenta", saldo.NroCuentaBancaria);
                cmd.Parameters.AddWithValue("@fecha", saldo.Fecha);
                cmd.Parameters.AddWithValue("@saldoFinal", saldo.SaldoFinal);
                cmd.Parameters.AddWithValue("@idUsuario", saldo.IdUsuario);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        // Create
        public int Insertar(SaldosCuentasBancarias saldo)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    INSERT INTO TBL_SaldosCuentasBancarias 
                        (idCtaBancaria, fecha, saldoInicial, saldoFinal, idUsuario)
                    OUTPUT INSERTED.id
                    VALUES (@idCtaBancaria, @fecha, @saldoInicial, @saldoFinal, @idUsuario)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idCtaBancaria", saldo.IdCtaBancaria);
                cmd.Parameters.AddWithValue("@fecha", saldo.Fecha);
                cmd.Parameters.AddWithValue("@saldoInicial", saldo.SaldoInicial);
                cmd.Parameters.AddWithValue("@saldoFinal", saldo.SaldoFinal);
                cmd.Parameters.AddWithValue("@idUsuario", saldo.IdUsuario);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public DataTable ObtenerCuadraturaMF()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
DECLARE @FechaIni DATE = '2025-01-01';
DECLARE @FechaFin DATE = '2025-12-31';

select @FechaIni= MIN(ISNULL(Fecha_Asiento_Valor, Fecha_Asiento) ),@FechaFin= MAX(ISNULL(Fecha_Asiento_Valor, Fecha_Asiento) ) from TBL_Asiento_Contable
    WHERE Cuenta_Contable BETWEEN '104' AND '108' and estado=1 ;

-- 1️⃣ Tabla de meses (primer día de cada mes)
WITH Meses AS (
    SELECT DATEFROMPARTS(YEAR(@FechaIni), MONTH(@FechaIni), 1) AS FechaOperacion
    UNION ALL
    SELECT DATEADD(MONTH, 1, FechaOperacion)
    FROM Meses
    WHERE DATEADD(MONTH, 1, FechaOperacion) <= @FechaFin
),

-- 2️⃣ Tu consulta original SIN el ORDER BY final
Datos AS (
    SELECT  
        Y.*,
        ISNULL(Y.saldoFinal,0.00) - ISNULL(Y.saldoInicial,0.00) AS MOVIMIENTO,
        (ISNULL(Y.saldoFinal,0.00) - ISNULL(Y.saldoInicial,0.00)) + MONTO AS DIFERENCIA
    FROM (
        SELECT 
            IDEMPRESA,
            ISNULL(idCtaBanco,0) AS IDCTABANCO,
            EMPRESA,
            CTABANCARIA,
            ISNULL(MONEDA,'SIN DETALLE') AS MONEDA,
            FECHAOPERACION,
            IIF(IDMONEDA=2, SUM(DOLARES), SUM(SOLES)) AS MONTO,
            SUM(SALDOINICIAL) AS SALDOINICIAL,
            SUM(SALDOFINAL) AS SALDOFINAL
        FROM (
            SELECT DISTINCT
                e.Id_Empresa AS idempresa,
                cb.Id_Tipo_Cta AS idCtaBanco,
                e.Empresa,   
                        CAST(DATEFROMPARTS(
    YEAR(ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento)),
    MONTH(ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento)),
    1
) AS DATE) AS FechaOperacion,
                ISNULL(NULLIF(cb.Nro_Cta, ''), '') AS CtaBancaria,
                IIF(Saldo_Debe>0,1,-1) * ax.Importe_MN AS SOLES,
                IIF(Saldo_Debe>0,1,-1) * ax.Importe_ME AS DOLARES,
                cb.Moneda AS idmoneda,
                m.Moneda,
                0.00 AS SALDOINICIAL,
                0.00 AS SALDOFINAL
            FROM TBL_Asiento_Contable a
            INNER JOIN TBL_Proyecto p ON a.id_proyecto = p.Id_Proyecto
            INNER JOIN TBL_Empresa e ON p.Id_Empresa = e.Id_Empresa
            LEFT JOIN TBL_Asiento_Contable_Aux ax 
                   ON a.Id_Asiento_Contable = ax.Id_Asiento_Contable
                  AND a.id_Asiento = ax.Id_Aux
                  AND a.Cuenta_Contable = ax.Cuenta_Contable
                  AND a.id_proyecto = ax.fk_proyecto
                  AND CAST(ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento) AS DATE) = ax.Fecha_Asiento
            LEFT JOIN TBL_CtaBancaria cb ON cb.Id_Tipo_Cta = ax.Cta_Banco
            LEFT JOIN TBL_Moneda m ON m.Id_Moneda = cb.Moneda
            WHERE a.Cuenta_Contable BETWEEN '104' AND '108'
              AND Id_Dinamica_Contable NOT IN (-30)
              AND NOT EXISTS (
                    SELECT 1
                    FROM TBL_Asiento_Contable h
                    INNER JOIN TBL_Proyecto po ON po.Id_Proyecto = h.id_proyecto
                    INNER JOIN TBL_Empresa ex ON po.Id_Empresa = ex.Id_Empresa 
                                              AND ex.Id_Empresa = e.Id_Empresa
                    WHERE h.Estado IN (4,0)
                      AND h.Cod_Asiento_Contable = a.Cod_Asiento_Contable
                )
            UNION ALL
            SELECT e.Id_Empresa,
                   cb.Id_Tipo_Cta,
                   e.Empresa,
                   sb.Fecha,
                   cb.Nro_Cta,
                   0,0,
                   m.Id_Moneda,
                   m.Moneda,
                   sb.SaldoInicial,
                   sb.SaldoFinal
            FROM TBL_SaldosCuentasBancarias sb
            INNER JOIN TBL_CtaBancaria cb ON sb.idCtaBancaria = cb.Id_Tipo_Cta
            INNER JOIN TBL_Empresa e ON e.Id_Empresa = cb.Empresa
            INNER JOIN TBL_Moneda m ON m.Id_Moneda = cb.Moneda
        ) AS x
        GROUP BY idempresa, idCtaBanco, Empresa, FechaOperacion, CtaBancaria, idmoneda, Moneda
        HAVING SUM(SOLES) IS NOT NULL 
           AND SUM(DOLARES) IS NOT NULL
    ) AS Y
)



-- 3️⃣ CROSS JOIN de Meses y cuentas bancarias → LEFT JOIN con Datos
select *,
(saldofinal- SALDOINICIAL) MOVIMIENTO,
MONTO - (saldofinal- SALDOINICIAL)DIFERENCIA
from (
SELECT 
    c.IDEMPRESA,
    c.IDCTABANCO,
    c.EMPRESA,
    c.CTABANCARIA,
    c.MONEDA,
    m.FECHAOPERACION,
  ISNULL(d.Monto,0) AS MONTO,
     isnull( iif( ISNULL(d.SaldoInicial,0)=0,tsb.saldofinal,d.SaldoInicial),0) AS SALDOINICIAL,
    ISNULL(d.SaldoFinal,0) AS SALDOFINAL
	--,	iif( ISNULL(d.SaldoInicial,0)=0,tsb.saldofinal- ISNULL(d.SaldoFinal,0) ,d.MOVIMIENTO) MOVIMIENTO,
	--iif( ISNULL(d.SaldoInicial,0)=0,tsb.saldofinal- ISNULL(d.SaldoFinal,0)-ISNULL(d.Monto,0),d.Diferencia) DIFERENCIA
FROM Meses m
CROSS JOIN (
    SELECT DISTINCT IDEMPRESA AS IdEmpresa,
                    IDCTABANCO AS IdCtaBanco,
                    EMPRESA,
                    CTABANCARIA AS CtaBancaria,
                    MONEDA
    FROM Datos
) AS c
LEFT JOIN Datos d
       ON d.FechaOperacion = m.FechaOperacion
      AND d.IDEMPRESA     = c.IdEmpresa
      AND d.IDCTABANCO    = c.IdCtaBanco
      AND d.CTABANCARIA   = c.CtaBancaria
      AND d.MONEDA        = c.Moneda

	  left join  TBL_SaldosCuentasBancarias TSB on TSB.idCtaBancaria = d.IDCTABANCO
					and DATEADD(month,1, TSB.fecha) = d.FechaOperacion

					) as xx
ORDER BY xx.Empresa, xx.Moneda, xx.CtaBancaria, xx.FechaOperacion
OPTION (MAXRECURSION 0);



                    ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        // Read
        public DataTable ObtenerTodos()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM TBL_SaldosCuentasBancarias ORDER BY fecha DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        // Update
        public bool Actualizar(SaldosCuentasBancarias saldo)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    UPDATE TBL_SaldosCuentasBancarias
                    SET idCtaBancaria = @idCtaBancaria,
                        fecha = @fecha,
                        saldoInicial = @saldoInicial,
                        saldoFinal = @saldoFinal,
                        idUsuario = @idUsuario
                    WHERE id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idCtaBancaria", saldo.IdCtaBancaria);
                cmd.Parameters.AddWithValue("@fecha", saldo.Fecha);
                cmd.Parameters.AddWithValue("@saldoInicial", saldo.SaldoInicial);
                cmd.Parameters.AddWithValue("@saldoFinal", saldo.SaldoFinal);
                cmd.Parameters.AddWithValue("@idUsuario", saldo.IdUsuario);
                cmd.Parameters.AddWithValue("@id", saldo.Id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Delete (Physical)
        public bool EliminarFisico(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM TBL_SaldosCuentasBancarias WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Filter: Por Cuenta Bancaria y Rango de Fechas
        public DataTable FiltrarPorCuentaYFecha(int idCtaBancaria, DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT * 
                    FROM TBL_SaldosCuentasBancarias
                    WHERE idCtaBancaria = @idCtaBancaria
                      AND fecha BETWEEN @fechaInicio AND @fechaFin
                    ORDER BY fecha";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idCtaBancaria", idCtaBancaria);
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}
