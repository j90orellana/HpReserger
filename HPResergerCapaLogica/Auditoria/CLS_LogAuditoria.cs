using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.Reflection;

namespace HPResergerCapaLogica.Auditoria
{
    public class CLS_LogAuditoria
    {
        private readonly string _connectionString;
        private static bool _tablaVerificada = false;
        // Se genera una sola vez cuando inicia el ERP
        public static Guid SesionActual { get; private set; } = Guid.NewGuid();

        public long IdLog { get; set; }
        public Guid IdSesion { get; set; }
        public DateTime FechaHora { get; set; }
        public int CodigoUsuario { get; set; }
        public string Empresa { get; set; }
        public string Modulo { get; set; }
        public string Formulario { get; set; }
        public string Accion { get; set; }
        public string Descripcion { get; set; }
        public string Equipo { get; set; }
        public string IP { get; set; }
        public string Version { get; set; }

        public CLS_LogAuditoria()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();

            FechaHora = DateTime.Now;
            Equipo = Environment.MachineName;
            IP = ObtenerIP();
            IdSesion = SesionActual;

            Empresa = "";
            Modulo = "";
            Formulario = "";
            Accion = "";
            Descripcion = "";
   
            Version = System.Windows.Forms.Application.ProductVersion;

            if (!_tablaVerificada)
            {
                CrearTablaSiNoExiste();
                _tablaVerificada = true;
            }
        }

        public bool Registrar(int codigoUsuario, string empresa, string accion, string descripcion, string modulo = "", string formulario = "")
        {
            CLS_LogAuditoria log = new CLS_LogAuditoria
            {
                CodigoUsuario = codigoUsuario,
                Empresa = empresa,
                Accion = accion,
                Descripcion = descripcion,
                Modulo = modulo,
                Formulario = formulario
            };

            return Insertar(log);
        }
        private void CrearTablaSiNoExiste()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_connectionString))
                {
                    cn.Open();

                    string sql = @"
            IF NOT EXISTS (
                SELECT 1
                FROM sys.tables
                WHERE name = 'TBL_LogAuditoria'
            )
            BEGIN
                CREATE TABLE TBL_LogAuditoria
                (
                    IdLog BIGINT IDENTITY(1,1) PRIMARY KEY,
                    IdSesion UNIQUEIDENTIFIER NOT NULL,
                    FechaHora DATETIME NOT NULL,
                    CodigoUsuario INT NOT NULL,
                    Empresa VARCHAR(50),
                    Modulo VARCHAR(100),
                    Formulario VARCHAR(100),
                    Accion VARCHAR(100),
                    Descripcion VARCHAR(MAX),
                    Equipo VARCHAR(100),
                    IP VARCHAR(50),
                    Version VARCHAR(50)
                );

                CREATE INDEX IX_LogAuditoria_Fecha
                ON TBL_LogAuditoria(FechaHora);

                CREATE INDEX IX_LogAuditoria_Usuario
                ON TBL_LogAuditoria(CodigoUsuario);
            END";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                // No detener el ERP por auditoría
            }
        }
        public bool Insertar(CLS_LogAuditoria log)
        {
            try
            {
                return InsertarInterno(log);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 208) // Tabla no existe
                {
                    try
                    {
                        CrearTablaSiNoExiste();

                        return InsertarInterno(log);
                    }
                    catch
                    {
                        return false;
                    }
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        private bool InsertarInterno(CLS_LogAuditoria log)
        {
            using (SqlConnection cn = new SqlConnection(_connectionString))
            {
                string sql = @"
        INSERT INTO TBL_LogAuditoria
        (
            IdSesion,
            FechaHora,
            CodigoUsuario,
            Empresa,
            Modulo,
            Formulario,
            Accion,
            Descripcion,
            Equipo,
            IP, Version
        )
        VALUES
        (
            @IdSesion,
            @FechaHora,
            @CodigoUsuario,
            @Empresa,
            @Modulo,
            @Formulario,
            @Accion,
            @Descripcion,
            @Equipo,
            @IP, @version
        )";

                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@IdSesion", log.IdSesion);
                cmd.Parameters.AddWithValue("@FechaHora", log.FechaHora);
                cmd.Parameters.AddWithValue("@CodigoUsuario", log.CodigoUsuario);
                cmd.Parameters.AddWithValue("@Empresa", log.Empresa ?? "");
                cmd.Parameters.AddWithValue("@Modulo", log.Modulo ?? "");
                cmd.Parameters.AddWithValue("@Formulario", log.Formulario ?? "");
                cmd.Parameters.AddWithValue("@Accion", log.Accion ?? "");
                cmd.Parameters.AddWithValue("@Descripcion", log.Descripcion ?? "");
                cmd.Parameters.AddWithValue("@Equipo", log.Equipo ?? "");
                cmd.Parameters.AddWithValue("@IP", log.IP ?? "");
                cmd.Parameters.AddWithValue("@version", log.Version ?? "");

                cn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public DataTable Listar(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(_connectionString))
            {
                string sql = @"
                SELECT
                    IdLog,
                    IdSesion,
                    FechaHora,
                    CodigoUsuario,
                    Empresa,
                    Modulo,
                    Formulario,
                    Accion,
                    Descripcion,
                    Equipo,
                    IP,Version
                FROM TBL_LogAuditoria
                WHERE FechaHora BETWEEN @FechaInicio AND @FechaFin
                ORDER BY FechaHora DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);

                da.SelectCommand.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                da.SelectCommand.Parameters.AddWithValue("@FechaFin", fechaFin);

                da.Fill(dt);
            }

            return dt;
        }
  public DataTable Listar(DateTime fecha)
{
    DataTable dt = new DataTable();

    using (SqlConnection cn = new SqlConnection(_connectionString))
    {
        try
        {
            string sql = @"
                SELECT
                    IdLog,
                    IdSesion,
                    FechaHora,
                    u.Login_User Usuario,
                    Empresa,
                    Modulo,
                    Formulario,
                    Accion,
                    Descripcion,
                    Equipo,
                    IP,
                    Version
                FROM TBL_LogAuditoria a
                INNER JOIN TBL_Usuario u ON a.CodigoUsuario = u.Codigo_User
                WHERE FechaHora BETWEEN DATEFROMPARTS(YEAR(@fecha), MONTH(@fecha), 1)
                                    AND EOMONTH(@fecha)
                ORDER BY FechaHora ASC";

            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.SelectCommand.Parameters.AddWithValue("@fecha", fecha);
            da.Fill(dt);
        }
        catch (SqlException ex)
        {
            if (ex.Message.Contains("'Version'") &&
                ex.Message.Contains("column"))
            {
                cn.Open();

                string alterSql = @"
                    ALTER TABLE TBL_LogAuditoria
                    ADD Version VARCHAR(50) NULL";

                using (SqlCommand cmd = new SqlCommand(alterSql, cn))
                {
                    cmd.ExecuteNonQuery();
                }

                cn.Close();

                // Reintentar consulta
                return Listar(fecha);
            }

            throw;
        }
    }

    return dt;
}

        public DataTable Listar(int codigoUsuario, DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(_connectionString))
            {
                string sql = @"
                SELECT
                    IdLog,
                    IdSesion,
                    FechaHora,
                    CodigoUsuario,
                    Empresa,
                    Modulo,
                    Formulario,
                    Accion,
                    Descripcion,
                    Equipo,
                    IP,Version
                FROM TBL_LogAuditoria
                WHERE CodigoUsuario = @CodigoUsuario
                AND FechaHora BETWEEN @FechaInicio AND @FechaFin
                ORDER BY FechaHora DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);

                da.SelectCommand.Parameters.AddWithValue("@CodigoUsuario", codigoUsuario);
                da.SelectCommand.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                da.SelectCommand.Parameters.AddWithValue("@FechaFin", fechaFin);

                da.Fill(dt);
            }

            return dt;
        }

        public bool RegistrarInicioSesion(int codigoUsuario, string empresa)
        {
            return Registrar(
                codigoUsuario,
                empresa,
                "INICIO_SESION",
                "Ingreso al ERP",
                "SEGURIDAD",
                "LOGIN");
        }

        public bool RegistrarFinSesion(int codigoUsuario, string empresa)
        {
            return Registrar(
                codigoUsuario,
                empresa,
                "FIN_SESION",
                "Salida del ERP",
                "SEGURIDAD",
                "PRINCIPAL");
        }
        public bool RegistrarSalidaSistema(int codigoUsuario, string empresa)
        {
            return Registrar(
                codigoUsuario,
                empresa,
                "SALIDA_SISTEMA",
                "Salida del ERP",
                "SEGURIDAD",
                "PRINCIPAL");
        }

        private string ObtenerIP()
        {
            try
            {
                string ip = "";

                foreach (IPAddress direccion in Dns.GetHostAddresses(Dns.GetHostName()))
                {
                    if (direccion.AddressFamily == AddressFamily.InterNetwork)
                    {
                        ip = direccion.ToString();
                        break;
                    }
                }

                return ip;
            }
            catch
            {
                return "";
            }
        }
    }
}