using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica.FlujoCaja
{
    public class EstatusInventario
    {
        public int IdEstatusInventario { get; set; } = 0;
        public string Estatus { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public int UsuarioCreacion { get; set; } = 0;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        private readonly string _connectionString;

        public EstatusInventario()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }

        // Create
        public int Insertar(EstatusInventario estatus)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    INSERT INTO TBL_EstatusInventario (Estatus, Descripcion, UsuarioCreacion, FechaCreacion)
                    OUTPUT INSERTED.IdEstatusInventario
                    VALUES (@Estatus, @Descripcion, @UsuarioCreacion, @FechaCreacion)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Estatus", estatus.Estatus);
                cmd.Parameters.AddWithValue("@Descripcion", estatus.Descripcion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@UsuarioCreacion", estatus.UsuarioCreacion);
                cmd.Parameters.AddWithValue("@FechaCreacion", estatus.FechaCreacion);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        // Read
        public DataTable ObtenerTodos()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM TBL_EstatusInventario where fechacreacion is not null ORDER BY Estatus";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        // Update
        public bool Actualizar(EstatusInventario estatus)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    UPDATE TBL_EstatusInventario
                    SET Estatus = @Estatus, 
                        Descripcion = @Descripcion, 
                        UsuarioCreacion = @UsuarioCreacion,
                        FechaCreacion = @FechaCreacion
                    WHERE IdEstatusInventario = @IdEstatusInventario";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Estatus", estatus.Estatus);
                cmd.Parameters.AddWithValue("@Descripcion", estatus.Descripcion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@UsuarioCreacion", estatus.UsuarioCreacion);
                cmd.Parameters.AddWithValue("@FechaCreacion", estatus.FechaCreacion);
                cmd.Parameters.AddWithValue("@IdEstatusInventario", estatus.IdEstatusInventario);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Delete (Logical)
        public bool EliminarLogico(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    UPDATE TBL_EstatusInventario
                    SET fechacreacion = null -- Marcar como eliminado (por lógica, sin borrar el registro físico)
                    WHERE IdEstatusInventario = @IdEstatusInventario";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdEstatusInventario", id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Delete (Physical)
        public bool EliminarFisico(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM TBL_EstatusInventario WHERE IdEstatusInventario = @IdEstatusInventario";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdEstatusInventario", id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Filter
        public DataTable FiltrarPorEstatus(string estatus)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT * 
                    FROM TBL_EstatusInventario
                    WHERE Estatus LIKE @Estatus
                    ORDER BY Estatus";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Estatus", $"%{estatus}%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}
