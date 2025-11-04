using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HPResergerCapaLogica.Finanzas
{
    public class EvoltaApiService
    {
        private readonly HttpClient _httpClient;
        private string _accessToken;

        private const string BaseUrl = "https://webapi.evolta.pe";
        private const string TokenUrl = "/oauth2/token";
        private const string ProyectoUrl = "/api/proyecto";
        private const string PagoAprobadoUrl = "/api/pagoaprobado";

        public EvoltaApiService()
        {
            _httpClient = new HttpClient();
        }
        private readonly string _connectionString;
        public EvoltaApiService(Boolean UsoTablas)
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }
        public void Insert(PagoAprobado pago)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    IF NOT EXISTS (SELECT 1 FROM TBL_PagoAprobado WHERE Id = @id)
                    BEGIN
                        INSERT INTO TBL_PagoAprobado (
                            Id, Empresa, Proyecto, Etapa, Edificio, Tipo_Unidad, Numero_Unidad, 
                            Numero_Cliente, Cliente, Direccion, Email_Cliente, Email_Vendedor, 
                            Concepto, Detalle, Cuota, Banco, Cuenta_Banco, Forma_Pago, 
                            Numero_Pago, Numero_Operacion, Fecha_Pago, Moneda, Monto, 
                            Vendedor, IdUsuarioCreador, IdUsuarioPagador, Estado, FechaRegistro
                        )
                        VALUES (
                            @id, @Empresa, @Proyecto, @Etapa, @Edificio, @Tipo_Unidad, @Numero_Unidad, 
                            @Numero_Cliente, @Cliente, @Direccion, @Email_Cliente, @Email_Vendedor, 
                            @Concepto, @Detalle, @Cuota, @Banco, @Cuenta_Banco, @Forma_Pago, 
                            @Numero_Pago, @Numero_Operacion, @Fecha_Pago, @Moneda, @Monto, 
                            @Vendedor, @IdUsuarioCreador, @IdUsuarioPagador, @estado, @FechaRegistro
                        )
                    END";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Agregar parámetros
                cmd.Parameters.AddWithValue("@id", pago.Id);
                cmd.Parameters.AddWithValue("@Empresa", pago.Empresa);
                cmd.Parameters.AddWithValue("@Proyecto", pago.Proyecto);
                cmd.Parameters.AddWithValue("@Etapa", pago.Etapa);
                cmd.Parameters.AddWithValue("@Edificio", pago.Edificio);
                cmd.Parameters.AddWithValue("@Tipo_Unidad", pago.Tipo_Unidad);
                cmd.Parameters.AddWithValue("@Numero_Unidad", pago.Numero_Unidad);
                cmd.Parameters.AddWithValue("@Numero_Cliente", pago.Numero_Cliente);
                cmd.Parameters.AddWithValue("@Cliente", pago.Cliente);
                cmd.Parameters.AddWithValue("@Direccion", pago.Direccion);
                cmd.Parameters.AddWithValue("@Email_Cliente", pago.Email_Cliente);
                cmd.Parameters.AddWithValue("@Email_Vendedor", pago.Email_Vendedor);
                cmd.Parameters.AddWithValue("@Concepto", pago.Concepto);
                cmd.Parameters.AddWithValue("@Detalle", pago.Detalle);
                cmd.Parameters.AddWithValue("@Cuota", pago.Cuota);
                cmd.Parameters.AddWithValue("@Banco", pago.Banco);
                cmd.Parameters.AddWithValue("@Cuenta_Banco", pago.Cuenta_Banco);
                cmd.Parameters.AddWithValue("@Forma_Pago", pago.Forma_Pago);
                cmd.Parameters.AddWithValue("@Numero_Pago", pago.Numero_Pago);
                cmd.Parameters.AddWithValue("@Numero_Operacion", pago.Numero_Operacion);
                cmd.Parameters.AddWithValue("@Fecha_Pago", pago.Fecha_Pago);
                cmd.Parameters.AddWithValue("@Moneda", pago.Moneda);
                cmd.Parameters.AddWithValue("@Monto", pago.Monto);
                cmd.Parameters.AddWithValue("@Vendedor", pago.Vendedor);
                cmd.Parameters.AddWithValue("@IdUsuarioCreador", pago.IdUsuarioCreador);
                cmd.Parameters.AddWithValue("@IdUsuarioPagador", pago.IdUsuarioPagador);
                cmd.Parameters.AddWithValue("@estado", pago.Estado);
                cmd.Parameters.AddWithValue("@FechaRegistro", pago.FechaRegistro);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public PagoAprobado GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM TBL_PagoAprobado WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new PagoAprobado
                    {
                        Id = (int)reader["Id"],
                        Empresa = reader["Empresa"].ToString(),
                        Proyecto = reader["Proyecto"].ToString(),
                        Etapa = reader["Etapa"].ToString(),
                        Edificio = reader["Edificio"].ToString(),
                        Tipo_Unidad = reader["Tipo_Unidad"].ToString(),
                        Numero_Unidad = reader["Numero_Unidad"].ToString(),
                        Numero_Cliente = reader["Numero_Cliente"].ToString(),
                        Cliente = reader["Cliente"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        Email_Cliente = reader["Email_Cliente"].ToString(),
                        Email_Vendedor = reader["Email_Vendedor"].ToString(),
                        Concepto = reader["Concepto"].ToString(),
                        Detalle = reader["Detalle"].ToString(),
                        Cuota = reader["Cuota"].ToString(),
                        Banco = reader["Banco"].ToString(),
                        Cuenta_Banco = reader["Cuenta_Banco"].ToString(),
                        Forma_Pago = reader["Forma_Pago"].ToString(),
                        Numero_Pago = reader["Numero_Pago"].ToString(),
                        Numero_Operacion = reader["Numero_Operacion"].ToString(),
                        Fecha_Pago = (DateTime)reader["Fecha_Pago"],
                        Moneda = reader["Moneda"].ToString(),
                        Monto = (decimal)reader["Monto"],
                        Vendedor = reader["Vendedor"].ToString(),
                        IdUsuarioCreador = (int)reader["IdUsuarioCreador"],
                        IdUsuarioPagador = (int)reader["IdUsuarioPagador"],
                        FechaRegistro = (DateTime)reader["FechaRegistro"],
                        Estado = (int)reader["Estado"]

                    };
                }

                return null;
            }
        }
        // UPDATE
        public void Update(PagoAprobado pago)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE TBL_PagoAprobado SET 
                Empresa = @Empresa, 
                Proyecto = @Proyecto, 
                Etapa = @Etapa, 
                Edificio = @Edificio, 
                Tipo_Unidad = @Tipo_Unidad, 
                Numero_Unidad = @Numero_Unidad, 
                Numero_Cliente = @Numero_Cliente, 
                Cliente = @Cliente, 
                Direccion = @Direccion, 
                Email_Cliente = @Email_Cliente, 
                Email_Vendedor = @Email_Vendedor, 
                Concepto = @Concepto, 
                Detalle = @Detalle, 
                Cuota = @Cuota, 
                Banco = @Banco, 
                Cuenta_Banco = @Cuenta_Banco, 
                Forma_Pago = @Forma_Pago, 
                Numero_Pago = @Numero_Pago, 
                Numero_Operacion = @Numero_Operacion, 
                Fecha_Pago = @Fecha_Pago, 
                Moneda = @Moneda, 
                Monto = @Monto, 
                Vendedor = @Vendedor, 
                IdUsuarioCreador = @IdUsuarioCreador, 
                IdUsuarioPagador = @IdUsuarioPagador,
                FechaRegistro =@FechaRegistro,
                Estado =@estado
                WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                // Agregar parámetros (similar al Insert)
                cmd.Parameters.AddWithValue("@Id", pago.Id);
                cmd.Parameters.AddWithValue("@Empresa", pago.Empresa);
                cmd.Parameters.AddWithValue("@Proyecto", pago.Proyecto);
                cmd.Parameters.AddWithValue("@Etapa", pago.Etapa);
                cmd.Parameters.AddWithValue("@Edificio", pago.Edificio);
                cmd.Parameters.AddWithValue("@Tipo_Unidad", pago.Tipo_Unidad);
                cmd.Parameters.AddWithValue("@Numero_Unidad", pago.Numero_Unidad);
                cmd.Parameters.AddWithValue("@Numero_Cliente", pago.Numero_Cliente);
                cmd.Parameters.AddWithValue("@Cliente", pago.Cliente);
                cmd.Parameters.AddWithValue("@Direccion", pago.Direccion);
                cmd.Parameters.AddWithValue("@Email_Cliente", pago.Email_Cliente);
                cmd.Parameters.AddWithValue("@Email_Vendedor", pago.Email_Vendedor);
                cmd.Parameters.AddWithValue("@Concepto", pago.Concepto);
                cmd.Parameters.AddWithValue("@Detalle", pago.Detalle);
                cmd.Parameters.AddWithValue("@Cuota", pago.Cuota);
                cmd.Parameters.AddWithValue("@Banco", pago.Banco);
                cmd.Parameters.AddWithValue("@Cuenta_Banco", pago.Cuenta_Banco);
                cmd.Parameters.AddWithValue("@Forma_Pago", pago.Forma_Pago);
                cmd.Parameters.AddWithValue("@Numero_Pago", pago.Numero_Pago);
                cmd.Parameters.AddWithValue("@Numero_Operacion", pago.Numero_Operacion);
                cmd.Parameters.AddWithValue("@Fecha_Pago", pago.Fecha_Pago);
                cmd.Parameters.AddWithValue("@Moneda", pago.Moneda);
                cmd.Parameters.AddWithValue("@Monto", pago.Monto);
                cmd.Parameters.AddWithValue("@Vendedor", pago.Vendedor);
                cmd.Parameters.AddWithValue("@IdUsuarioCreador", pago.IdUsuarioCreador);
                cmd.Parameters.AddWithValue("@IdUsuarioPagador", pago.IdUsuarioPagador);
                cmd.Parameters.AddWithValue("@estado", pago.Estado);
                cmd.Parameters.AddWithValue("@FechaRegistro", pago.FechaRegistro);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public bool UpdatePagado(PagoAprobado pago)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE TBL_PagoAprobado SET                
                IdUsuarioPagador = @IdUsuarioPagador,
                FechaRegistro =@FechaRegistro,
                Estado =@estado
                WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                // Agregar parámetros (similar al Insert)
                cmd.Parameters.AddWithValue("@Id", pago.Id);
                cmd.Parameters.AddWithValue("@IdUsuarioPagador", pago.IdUsuarioPagador);
                cmd.Parameters.AddWithValue("@estado", pago.Estado);
                cmd.Parameters.AddWithValue("@FechaRegistro", pago.FechaRegistro);

                conn.Open();
                int FilasAfectadas = cmd.ExecuteNonQuery();
                return FilasAfectadas > 0;
            }
        }


        // DELETE
        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM TBL_PagoAprobado WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // GET ALL BY FECHAS
        public DataTable GetAllByFechasDataTable(DateTime fechaDesde, DateTime fechaHasta)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                        SELECT 
                        p.*,
                        CASE p.estado 
                            WHEN 0 THEN 'Anulado' 
                            WHEN 1 THEN 'Pendiente' 
                            WHEN 2 THEN 'Facturado' 
                            ELSE 'Vacio' 
                        END AS EstadoPago,
                        isnull(u1.Login_User,'SISADMIN') AS UsuarioCreador,
                        ISNULL(u2.Login_User,'NINGUNO') AS UsuarioPagador
                    FROM TBL_PagoAprobado p
                    LEFT JOIN TBL_Usuario u1 ON p.IdUsuarioCreador = u1.Codigo_User
                    LEFT JOIN TBL_Usuario u2 ON p.IdUsuarioPagador = u2.Codigo_User
                        WHERE Fecha_Pago BETWEEN @FechaDesde AND @FechaHasta
                            ORDER BY Fecha_Pago DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                conn.Open();

                // Usar SqlDataAdapter para llenar el DataTable
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
        public List<PagoAprobado> GetAllByFechas(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<PagoAprobado> pagos = new List<PagoAprobado>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"SELECT * FROM TBL_PagoAprobado 
                            WHERE Fecha_Pago BETWEEN @FechaDesde AND @FechaHasta
                            ORDER BY Fecha_Pago DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pagos.Add(new PagoAprobado
                    {
                        Id = (int)reader["Id"],
                        Empresa = reader["Empresa"].ToString(),
                        Proyecto = reader["Proyecto"].ToString(),
                        Etapa = reader["Etapa"].ToString(),
                        Edificio = reader["Edificio"].ToString(),
                        Tipo_Unidad = reader["Tipo_Unidad"].ToString(),
                        Numero_Unidad = reader["Numero_Unidad"].ToString(),
                        Numero_Cliente = reader["Numero_Cliente"].ToString(),
                        Cliente = reader["Cliente"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        Email_Cliente = reader["Email_Cliente"].ToString(),
                        Email_Vendedor = reader["Email_Vendedor"].ToString(),
                        Concepto = reader["Concepto"].ToString(),
                        Detalle = reader["Detalle"].ToString(),
                        Cuota = reader["Cuota"].ToString(),
                        Banco = reader["Banco"].ToString(),
                        Cuenta_Banco = reader["Cuenta_Banco"].ToString(),
                        Forma_Pago = reader["Forma_Pago"].ToString(),
                        Numero_Pago = reader["Numero_Pago"].ToString(),
                        Numero_Operacion = reader["Numero_Operacion"].ToString(),
                        Fecha_Pago = (DateTime)reader["Fecha_Pago"],
                        Moneda = reader["Moneda"].ToString(),
                        Monto = (decimal)reader["Monto"],
                        Vendedor = reader["Vendedor"].ToString(),
                        IdUsuarioCreador = (int)reader["IdUsuarioCreador"],
                        IdUsuarioPagador = (int)reader["IdUsuarioPagador"],
                        FechaRegistro = (DateTime)reader["FechaRegistro"],
                        Estado = (int)reader["Estado"]
                    });
                }
            }

            return pagos;
        }

        public class TokenResponse
        {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public int expires_in { get; set; }
        }

        public class Proyecto
        {
            public int idProyecto { get; set; }
            public string proyecto { get; set; }
            public int idEmpresa { get; set; }
            public string direccion { get; set; }
            public DateTime fechaCreacion { get; set; }
            public DateTime fechaInicio { get; set; }
            public DateTime fechaEntrega { get; set; }
            public string direccionReferencia { get; set; }
            public string urbanizacion { get; set; }
            public int idEstado { get; set; }
            public bool techoPropio { get; set; }
            public bool miVivienda { get; set; }
            public string observaciones { get; set; }
            public int numeroInmuebles { get; set; }
            public bool anulado { get; set; }
        }
        public class PagoAprobado
        {
            public int Id { get; set; }
            public string Empresa { get; set; }
            public string Proyecto { get; set; }
            public string Etapa { get; set; }
            public string Edificio { get; set; }
            public string Tipo_Unidad { get; set; }
            public string Numero_Unidad { get; set; }
            public string Numero_Cliente { get; set; }
            public string Cliente { get; set; }
            public string Direccion { get; set; }
            public string Email_Cliente { get; set; }
            public string Email_Vendedor { get; set; }
            public string Concepto { get; set; }
            public string Detalle { get; set; }
            public string Cuota { get; set; }
            public string Banco { get; set; }
            public string Cuenta_Banco { get; set; }
            public string Forma_Pago { get; set; }
            public string Numero_Pago { get; set; } = "";
            public string Numero_Operacion { get; set; }
            public DateTime Fecha_Pago { get; set; }
            public string Moneda { get; set; }
            public decimal Monto { get; set; }
            public string Vendedor { get; set; }
            public int IdUsuarioCreador { get; set; } = 0;
            public int IdUsuarioPagador { get; set; } = -1;
            public DateTime FechaRegistro { get; set; } = DateTime.Now;
            public int Estado { get; set; } = 1;

        }

        // 1. Obtener el Token
        public async Task<bool> GetTokenAsync(string username, string password, string grant)
        {
            var values = new Dictionary<string, string>
                    {
                        { "username", username },
                        { "password", password },
                        { "grant_type", grant }
                    };

            var content = new FormUrlEncodedContent(values);
            var response = await _httpClient.PostAsync($"{BaseUrl}{TokenUrl}", content);

            if (!response.IsSuccessStatusCode)
                return false;

            var json = await response.Content.ReadAsStringAsync();
            //json = "[ " + json + "]";
            // Deserialización directa del objeto JSON
            TokenResponse tokenData = JsonConvert.DeserializeObject<TokenResponse>(json);

            _accessToken = tokenData?.access_token;

            return !string.IsNullOrEmpty(_accessToken);
        }
        // 2. Obtener lista de Proyectos
        public async Task<List<Proyecto>> GetProyectosAsync()
        {
            if (string.IsNullOrEmpty(_accessToken))
                throw new InvalidOperationException("Debe autenticarse primero.");

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);

            var response = await _httpClient.GetAsync($"{BaseUrl}{ProyectoUrl}");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var proyectos = JsonConvert.DeserializeObject<List<Proyecto>>(json);

            return proyectos;
        }


        // 3. Obtener Pagos Aprobados
        public async Task<List<PagoAprobado>> GetPagosAprobadosAsync(int proyectoId, string fechaInicio, string fechaFin)
        {
            if (string.IsNullOrEmpty(_accessToken))
                throw new InvalidOperationException("Debe autenticarse primero.");

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);

            string url = $"{BaseUrl}{PagoAprobadoUrl}?proyecto={proyectoId}&fecpagoini={fechaInicio}&fecpagofin={fechaFin}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var pagos = JsonConvert.DeserializeObject<List<PagoAprobado>>(json);

            return pagos;
        }

    }
}
