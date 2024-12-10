using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica
{
    // Clase oMetodoDepreciacion que representa la entidad de la tabla
    public class oMetodoDepreciacion
    {
        public int Pkid { get; set; }
        public int IdS { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }
    }

    // Clase principal para las operaciones sobre la tabla TBL_AF_MetodoDepreciacion
    public class T20MetodoDepreciacion
    {
        private readonly string _connectionString;

        public T20MetodoDepreciacion()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }

        // Obtener todos los registros como DataTable
        public DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM TBL_AF_MetodoDepreciacion where estado=1 ";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);  // Llenar el DataTable con los datos de la consulta
            }

            return dataTable;
        }

        // Obtener un registro por ID y mapear a la clase oMetodoDepreciacion
        public oMetodoDepreciacion GetById(int pkid)
        {
            oMetodoDepreciacion metodoDepreciacion = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM TBL_AF_MetodoDepreciacion WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pkid", pkid);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        metodoDepreciacion = new oMetodoDepreciacion
                        {
                            Pkid = reader.GetInt32(reader.GetOrdinal("pkid")),
                            IdS = reader.GetInt32(reader.GetOrdinal("idS")),
                            Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                            Estado = reader.GetInt32(reader.GetOrdinal("Estado"))
                        };
                    }
                }
            }

            return metodoDepreciacion;
        }

        // Insertar un nuevo registro, retorna true si se afecta alguna fila
        public bool Insert(oMetodoDepreciacion metodoDepreciacion)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "INSERT INTO TBL_AF_MetodoDepreciacion (idS, Nombre, Estado) VALUES (@idS, @Nombre, @Estado)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@idS", metodoDepreciacion.IdS);
                command.Parameters.AddWithValue("@Nombre", metodoDepreciacion.Nombre);
                command.Parameters.AddWithValue("@Estado", metodoDepreciacion.Estado);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Actualizar un registro existente, retorna true si se afecta alguna fila
        public bool Update(oMetodoDepreciacion metodoDepreciacion)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "UPDATE TBL_AF_MetodoDepreciacion SET idS = @idS, Nombre = @Nombre, Estado = @Estado WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@pkid", metodoDepreciacion.Pkid);
                command.Parameters.AddWithValue("@idS", metodoDepreciacion.IdS);
                command.Parameters.AddWithValue("@Nombre", metodoDepreciacion.Nombre);
                command.Parameters.AddWithValue("@Estado", metodoDepreciacion.Estado);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Eliminar un registro, retorna true si se afecta alguna fila
        public bool Delete(int pkid)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "DELETE FROM TBL_AF_MetodoDepreciacion WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pkid", pkid);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public bool EliminarxEstado(int pkid)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "UPDATE TBL_AF_MetodoDepreciacion SET Estado = 0 " +
                               "WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pkid", pkid);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
