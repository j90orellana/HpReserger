using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPResergerCapaLogica.Contable
{
    public class Contabilidad
    {
        private readonly string _connectionString;
        public Contabilidad()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }
        public DataTable PeriodoCerrado(int empresa, DateTime fecha)
        {
            var dt = new DataTable();
            string query = @"
        SELECT Año, Mes, Empresa, Estado, usuario, fecha
        FROM TBL_Periodo
        WHERE Empresa = @empresa
          AND Año = YEAR(@fecha)
          AND Mes = MONTH(@fecha)
          AND Estado = 2"; // Período cerrado

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@empresa", SqlDbType.Int).Value = empresa;
                cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        public object ListarCuentasSinUsarEnEFyER()
        {
            var dt = new DataTable();
            string query = @"

                declare @data as nvarchar(max)=''
                declare @data2 as nvarchar(max)=''

                select @data= STRING_AGG(cuenta_contable,',' )from TBL_Balance_Parametros
                select @data2= STRING_AGG(cuenta_contable,',' )from TBL_Balance_Ganacias_Parametros

                select @data = concat(@data, ',' ,@data2)


                SELECT  DISTINCT  Cuenta_Contable cuentaContable , MAX(Fecha_Asiento_Valor) fecha FROM TBL_Asiento_Contable  --665  --185
                where estado in (1,3,4) and  Cuenta_Contable not in
			                (SELECT 
			                LTRIM(RTRIM(value)) AS Codigo
			                FROM 
			                STRING_SPLIT(@data, ',')
			                WHERE 
			                LTRIM(RTRIM(value)) <> '')

                group by Cuenta_Contable
                order by fecha desc;";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
              

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        public DataTable FacturaVenta_BuscarTC(string ruc, string nro)
        {
            var dt = new DataTable();
            string query = @"
                select * from TBL_VentaManual

                where cliente = @ruc
                and NroComprobante = @NumComp
                AND IdComprobante IN(1,2,3,4)
                order by 1 desc";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@ruc", ruc);
                cmd.Parameters.AddWithValue("@NumComp", nro);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
        public DataTable RevisarCuentasEEFF(int idEmpresa, DateTime fecha)
        {
            var dt = new DataTable();
            string query = @"
      
                    DECLARE @FechaInicial AS DATE = DATEFROMPARTS(YEAR(@año), 1, 1)
                    DECLARE @FechaFinal AS DATE = EOMONTH(@año)

                    -- Pre-calcular cuentas excluidas (asientos de cierre)
                    DECLARE @AsientosExcluidos TABLE (Cod_Asiento_Contable VARCHAR(50))
                    INSERT INTO @AsientosExcluidos
                    SELECT DISTINCT h.Cod_Asiento_Contable
                    FROM TBL_Asiento_Contable h
                    INNER JOIN TBL_Proyecto po ON po.Id_Proyecto = h.id_proyecto
                    WHERE po.Id_Empresa = @Empresa AND h.Estado = 4 ;

                    -- Consulta principal optimizada
                    WITH SplitCuentas AS (
                        SELECT 
                            Posicion,
                            Cod_Balance,
                            Nombre_Balance,
                            value AS Cuenta_Contable,
                            Usuario,
                            Fecha
                        FROM TBL_Balance_Parametros
                        CROSS APPLY STRING_SPLIT(REPLACE(Cuenta_Contable, ' ', ''), ',')
                        WHERE Cuenta_Contable IS NOT NULL AND Cuenta_Contable <> ''
                    )

                   select Posicion,	id,	campo,	isnull(Cuenta_Contable,'')Cuenta_Contable, isnull(total	,0)total,empresa 
                        FROM (

                    SELECT 
                        P.Posicion,   p.cod_balance AS id,
                        p.nombre_balance AS campo,s.Cuenta_Contable,
                        CASE
                            WHEN RIGHT(p.Cod_Balance, 2) = '00' THEN NULL -- Cabeceras
                            WHEN RIGHT(p.Cod_Balance, 2) = '99' THEN 0.00 -- Cálculo Totales
                            ELSE ISNULL((
                                SELECT SUM(c.sumas)
                                FROM (
                                    SELECT 
                                        CASE 
                                            WHEN p.Cuenta_Contable LIKE '10%' AND p.cod_balance LIKE '1%' THEN 
                                                CASE WHEN SUM(ac.Saldo_debe - ac.saldo_haber) > 0 THEN SUM(ac.Saldo_debe - ac.saldo_haber) ELSE 0.00 END
                                            WHEN p.Cuenta_Contable LIKE '10%' AND p.cod_balance LIKE '2%' THEN 
                                                CASE WHEN SUM(-ac.Saldo_debe + ac.saldo_haber) > 0 THEN SUM(-ac.Saldo_debe + ac.saldo_haber) ELSE 0 END
                                            WHEN p.cod_balance LIKE '1%' THEN SUM(ac.Saldo_debe - ac.saldo_haber)
                                            ELSE SUM(-ac.Saldo_debe + ac.saldo_haber)
                                        END AS sumas
                                    FROM (
                                        SELECT 
                                            a.Cuenta_Contable,
                                            a.Estado,
                                            a.id_proyecto,
                                            CASE 
                                                WHEN a.saldo_haber > 0 THEN 1 ELSE 0 
                                            END * ISNULL(ax.Importe_MN, ABS(
                                                CASE 
                                                    WHEN a.moneda = 1 THEN (a.saldo_haber - a.saldo_debe)
                                                    ELSE (a.saldo_haber - a.saldo_debe) * a.tc
                                                END
                                            )) AS saldo_haber,
                                            CASE 
                                                WHEN a.Saldo_debe > 0 THEN 1 ELSE 0 
                                            END * ISNULL(ax.Importe_MN, ABS(
                                                CASE 
                                                    WHEN a.moneda = 1 THEN (a.saldo_haber - a.saldo_debe)
                                                    ELSE (a.saldo_haber - a.saldo_debe) * a.tc
                                                END
                                            )) AS Saldo_debe
                                        FROM TBL_Asiento_Contable a
                                        LEFT JOIN TBL_Asiento_Contable_Aux ax ON 
                                            a.Id_Asiento_Contable = ax.Id_Asiento_Contable AND
                                            a.id_Asiento = ax.Id_Aux AND
                                            a.Cuenta_Contable = Ax.Cuenta_Contable AND
                                            a.id_proyecto = ax.fk_proyecto AND
                                            CAST(ISNULL(a.Fecha_Asiento_Valor, a.Fecha_Asiento) AS DATE) = ax.Fecha_Asiento
                                        WHERE 
                                            CAST(ISNULL(a.fecha_asiento_Valor, a.fecha_asiento) AS DATE) BETWEEN @FechaInicial AND @FechaFinal AND
                                            a.Cod_Asiento_Contable NOT IN (SELECT Cod_Asiento_Contable FROM @AsientosExcluidos) AND
                                            a.estado IN (1, 3) AND
                                            a.Id_Dinamica_Contable NOT IN (-50) -- Asiento Cierre= -50; Asiento Apertura = -51
						                    and  CAST(ISNULL(a.Fecha_Asiento_Valor, a.fecha_asiento) AS DATE) BETWEEN @FechaInicial AND @FechaFinal
                                    ) AS ac
                                    INNER JOIN TBL_Proyecto pr ON pr.Id_Proyecto = ac.id_proyecto AND pr.Id_Empresa = @empresa
                                    INNER JOIN TBL_Cuenta_Contable c ON c.Id_Cuenta_Contable = ac.Cuenta_Contable
                                    WHERE 
                                        ac.estado IN (1, 3)
                                        and ac.Cuenta_Contable = s.Cuenta_Contable
                                ) AS c
                            ), 0)
                        END AS total,
                        @empresa AS empresa
                    FROM TBL_Balance_Parametros p
                    LEFT JOIN SplitCuentas s ON p.Posicion = s.Posicion


                    WHERE 
                        p.Cuenta_Contable != '' OR
                        RIGHT(p.Cod_Balance, 2) IN ('00', '99') OR
                        p.Nombre_Balance LIKE 'Resultados del Período'

	                    ) as x 

	                    where total !=0 or Cuenta_Contable is null

                    ORDER BY x.Posicion ASC 


";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@empresa", SqlDbType.Int).Value = idEmpresa;
                cmd.Parameters.Add("@año", SqlDbType.Date).Value = fecha;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }


            return dt;
        }

        public DataTable RevisarCuentasEERR(int idEmpresa, DateTime fecha)
        {
            var dt = new DataTable();
            string query = @"
      
                  
DECLARE @FechaInicial AS DATE = DATEFROMPARTS(YEAR(@año), 1, 1)
DECLARE @FechaFinal AS DATE = EOMONTH(@año)

-- Pre-calcular cuentas excluidas (asientos de cierre)
DECLARE @AsientosExcluidos TABLE (Cod_Asiento_Contable VARCHAR(50))
INSERT INTO @AsientosExcluidos
SELECT DISTINCT h.Cod_Asiento_Contable
FROM TBL_Asiento_Contable h
INNER JOIN TBL_Proyecto po ON po.Id_Proyecto = h.id_proyecto
WHERE po.Id_Empresa = @Empresa AND h.Estado = 4 ;
					
  -- Consulta principal optimizada
WITH SplitCuentas AS (
    SELECT 
        Posicion,
        Cod_Balance,
        Nombre_Balance,
        value AS Cuenta_Contable,
        Usuario,
        Fecha
    FROM TBL_Balance_Ganacias_Parametros
    CROSS APPLY STRING_SPLIT(REPLACE(Cuenta_Contable, ' ', ''), ',')
    WHERE Cuenta_Contable IS NOT NULL AND Cuenta_Contable <> ''
)

    select Posicion,	id,	campo,	isnull(Cuenta_Contable,'')Cuenta_Contable, isnull(total	,0)total,empresa  from (


					  select  p.Posicion,p.Cod_Balance id,  p.nombre_balance AS campo,s.Cuenta_Contable, 
					  
					  ( SELECT IIF(p.signo = '-',SUM(-1 * v.sumas),SUM(v.sumas))
             FROM
                 (
                  SELECT SUM(c.sumas) sumas
                  FROM
                      (                      
                       SELECT SUM(ISNULL(IIF(ac.CREDITO + ac.debito = 0,IIF(ac.Cuenta_Contable = '7599103'
                                                                            OR ac.Cuenta_Contable = '7761101'
                                                                            OR ac.Cuenta_Contable = '6595101'
                                                                            OR ac.Cuenta_Contable = '6761101',1,-1),IIF(ac.credito > 0,1,-1)),00) --
                                  * ac.Importe_MN) sumas
                       FROM
                           (
                            SELECT a.Cuenta_Contable,a.Estado,a.id_proyecto,a.Fecha_Asiento_Valor,a.Fecha_Asiento,a.saldo_haber credito,a.saldo_debe
                            debito,--+--
                            --IIF(a.saldo_haber + a.saldo_debe = 0,IIF(a.Cuenta_Contable = '6595101'
                            --                                         OR a.Cuenta_Contable = '6761101'
                            --                                         OR a.Cuenta_Contable = '7599103'
                            --                                         OR a.Cuenta_Contable = '7761101',-1,0),1) * ISNULL(ax.Importe_MN,--
                            --abs(IIF(a.moneda = 1,(a.saldo_haber - a.saldo_debe),(a.saldo_haber - a.saldo_debe) * a.tc))) saldo_haber,--+--
                            --IIF(a.saldo_haber + a.saldo_debe = 0,IIF(a.Cuenta_Contable = '6595101'
                            --                                         OR a.Cuenta_Contable = '6761101'
                            --                                         OR a.Cuenta_Contable = '7599103'
                            --                                         OR a.Cuenta_Contable = '7761101',-1,0),1) * ISNULL(ax.Importe_MN,--
                            --abs(IIF(a.moneda = 1,(a.saldo_debe - a.saldo_haber),(a.saldo_debe - a.saldo_haber) * a.tc))) Saldo_debe--+--
                            ISNULL(ax.Importe_MN,ABS(IIF(a.moneda = 1,(a.saldo_haber - a.saldo_debe),(a.saldo_haber - a.saldo_debe) * a.tc)))
                            Importe_MN
                            FROM dbo.TBL_Asiento_Contable a
                                 LEFT JOIN dbo.TBL_Asiento_Contable_Aux ax ON a.Id_Asiento_Contable = ax.Id_Asiento_Contable
                                                                              AND a.id_Asiento = ax.Id_Aux
                                                                              AND a.Cuenta_Contable = Ax.Cuenta_Contable
                                                                              AND a.id_proyecto = ax.fk_proyecto
                                                                              AND CAST(ISNULL(a.Fecha_Asiento_Valor,a.Fecha_Asiento) AS DATE) = ax.
                                                                              Fecha_Asiento
                            WHERE 
							CAST(ISNULL(a.fecha_asiento_Valor, a.fecha_asiento) AS DATE) BETWEEN @FechaInicial AND @FechaFinal AND
                                            a.Cod_Asiento_Contable NOT IN (SELECT Cod_Asiento_Contable FROM @AsientosExcluidos) AND
                                            a.estado IN (1, 3) AND
                                            a.Id_Dinamica_Contable NOT IN (-50) -- Asiento Cierre= -50; Asiento Apertura = -51
						                  
                           ) --
                      AS ac
                           INNER JOIN dbo.TBL_Proyecto pr ON pr.Id_Proyecto = ac.id_proyecto
                                                             AND pr.Id_Empresa = @empresa
                          
                       WHERE ac.estado IN(1,3)
                      AND ac.Cuenta_Contable = s.Cuenta_Contable
                      AND CAST(ISNULL(ac.fecha_asiento_Valor,ac.fecha_asiento) AS DATE) BETWEEN @FechaInicial AND EOMONTH(@año)
                 --GROUP BY 
                      ) AS c
                 ) AS v)
					  
					  total, @Empresa empresa

					  from TBL_Balance_Ganacias_Parametros p
					 LEFT JOIN SplitCuentas s ON p.Posicion = s.Posicion
					WHERE 
                        p.Cuenta_Contable != '' 
						 
						 ) as x

						   where total !=0 or Cuenta_Contable is null

                    ORDER BY x.Posicion ASC 



";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@empresa", SqlDbType.Int).Value = idEmpresa;
                cmd.Parameters.Add("@año", SqlDbType.Date).Value = fecha;
                cmd.CommandTimeout = 0;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        public DataTable ListarAsientosFiltrados(int empresa, DateTime Fechaini, DateTime Fechafin, string cuo, string cuenta, string glosa, string suboperacion, int Activos = 1)
        {
            var dt = new DataTable();
            string query = @"
    SELECT DISTINCT 
           a.Id_Asiento_Contable AS ID,
           Cod_Asiento_Contable AS cuo,
           CAST(a.Fecha_Asiento AS DATE) AS FECHA,
           CAST(ISNULL(Fecha_Asiento_Valor, Fecha_Asiento) AS DATE) AS Fecha_Asiento,
           ISNULL(s.SubOperacion, dbo.nombredinamicas(a.Id_Dinamica_Contable)) AS 'SUB-OPERACION',
           a.Id_Dinamica_Contable AS IDDINAMICA,
           CASE A.Estado
               WHEN 1 THEN 1
               WHEN 3 THEN 1
               ELSE a.Estado
           END AS ESTADO,
           CASE A.Estado
               WHEN 1 THEN 'Activo'
               WHEN 3 THEN 'Activo'
               WHEN 4 THEN 'Reversado'
               ELSE 'Inactivo'
           END AS Estados,
           emp.Id_Empresa AS empresa,
           pro.Id_Proyecto AS proyecto,
           fk_id_Etapa AS etapa,
           CAST(Fecha_Asiento_Valor AS DATE) AS fechavalor,
           a.glosa,
           a.moneda,
           tc
    FROM TBL_Asiento_Contable AS a
    INNER JOIN TBL_Cuenta_Contable AS c ON c.Id_Cuenta_Contable = a.Cuenta_Contable
    LEFT JOIN TBL_Proyecto AS pro ON pro.Id_Proyecto = a.id_proyecto
    LEFT JOIN TBL_Empresa AS emp ON emp.Id_Empresa = pro.Id_Empresa
    LEFT JOIN TBL_Dinamica_Contable AS d ON d.Id_Dinamica_Contable = a.Id_Dinamica_Contable
    LEFT JOIN TBL_Operacion AS o ON o.Id_Operacion = d.Cod_Operacion
    LEFT JOIN TBL_SubOperacion AS s ON s.Id_Operacion = o.Id_Operacion AND s.Id_SubOperacion = d.Cod_SubOperacion
    WHERE emp.Id_Empresa = @Empresa
          AND a.Estado != 3
          AND (a.Estado = @Activos OR @Activos = 0)
          AND a.Cod_Asiento_Contable LIKE CASE @cuo
                                              WHEN '' THEN '%'
                                              ELSE @cuo + '%'
                                              END
              AND c.Cuenta_Contable LIKE CASE @cuenta
                                         WHEN '' THEN '%'
                                         ELSE @cuenta + '%'
                                         END
              AND a.Glosa LIKE CASE @glosa
                               WHEN '' THEN '%'
                               ELSE '%' + @glosa + '%'
                               END
              AND CAST(ISNULL(Fecha_Asiento_Valor,Fecha_Asiento) AS DATE) BETWEEN @Fechaini AND @Fechafin
              AND ISNULL(s.SubOperacion,dbo.nombredinamicas(a.Id_Dinamica_Contable)) LIKE CASE @SubOperacion
                                                                                          WHEN '' THEN '%'
                                                                                          ELSE '%' + @SubOperacion + '%'
                                                                                          END
    ORDER BY cuo DESC;";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                // Asegúrate de que los nombres de parámetros coincidan exactamente
                cmd.Parameters.Add("@Empresa", SqlDbType.Int).Value = empresa;
                cmd.Parameters.Add("@Fechaini", SqlDbType.DateTime).Value = Fechaini;
                cmd.Parameters.Add("@Fechafin", SqlDbType.DateTime).Value = Fechafin;
                cmd.Parameters.AddWithValue("@Cuo", cuo);
                cmd.Parameters.AddWithValue("@Cuenta", cuenta);
                cmd.Parameters.AddWithValue("@Glosa", glosa);
                cmd.Parameters.AddWithValue("@SubOperacion", suboperacion);
                cmd.Parameters.Add("@Activos", SqlDbType.Int).Value = Activos;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
    }
}
