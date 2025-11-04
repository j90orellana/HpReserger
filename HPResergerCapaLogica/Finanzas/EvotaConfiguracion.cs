using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica.Finanzas
{
    public class EvotaConfiguracion
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string GrantType { get; set; }

        private readonly string _connectionString;

        public EvotaConfiguracion()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }

        // Obtener todos los registros
        public DataTable GetAll()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT username, password, grant_type FROM Tbl_EvotaConfiguracion";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                conn.Open();
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        // Obtener solo la primera fila
        public EvotaConfiguracion GetFirst()
        {
            DataTable dt = GetAll();
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new EvotaConfiguracion
                {
                    Username = row["username"].ToString(),
                    Password = row["password"].ToString(),
                    GrantType = row["grant_type"].ToString()
                };
            }
            return null;
        }

        // Insertar nueva configuración
        public void Insert(string username, string password, string grantType)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Tbl_EvotaConfiguracion (username, password, grant_type) VALUES (@username, @password, @grant_type)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@grant_type", grantType);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Actualizar configuración existente (por username)
        public void Update(string username, string password, string grantType)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Tbl_EvotaConfiguracion SET password = @password, grant_type = @grant_type WHERE username = @username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@grant_type", grantType);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Eliminar configuración por username
        public void Delete(string username)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Tbl_EvotaConfiguracion WHERE username = @username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
