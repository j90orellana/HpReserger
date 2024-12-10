using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica
{
    // Clase oEstadoActivoFijo que representa la entidad de la tabla
    public class oEstadoActivoFijo
    {
        public int Pkid { get; set; }
        public int IdS { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }
    }

    // Clase principal para las operaciones sobre la tabla TBL_AF_Estado_Activo_Fijo
    public class T19EstadoActivoFijo
    {
        private readonly string _connectionString;

        public T19EstadoActivoFijo()
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

                string query = "SELECT * FROM TBL_AF_Estado_Activo_Fijo where estado=1 ";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);  // Llenar el DataTable con los datos de la consulta
            }

            return dataTable;
        }

        // Obtener un registro por ID y mapear a la clase oEstadoActivoFijo
        public oEstadoActivoFijo GetById(int pkid)
        {
            oEstadoActivoFijo estadoActivo = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM TBL_AF_Estado_Activo_Fijo WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pkid", pkid);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        estadoActivo = new oEstadoActivoFijo
                        {
                            Pkid = reader.GetInt32(reader.GetOrdinal("pkid")),
                            IdS = reader.GetInt32(reader.GetOrdinal("idS")),
                            Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                            Estado = reader.GetInt32(reader.GetOrdinal("Estado"))
                        };
                    }
                }
            }

            return estadoActivo;
        }

        // Insertar un nuevo registro, retorna true si se afecta alguna fila
        public bool Insert(oEstadoActivoFijo estadoActivo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "INSERT INTO TBL_AF_Estado_Activo_Fijo (idS, Nombre, Estado) VALUES (@idS, @Nombre, @Estado)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@idS", estadoActivo.IdS);
                command.Parameters.AddWithValue("@Nombre", estadoActivo.Nombre);
                command.Parameters.AddWithValue("@Estado", estadoActivo.Estado);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Actualizar un registro existente, retorna true si se afecta alguna fila
        public bool Update(oEstadoActivoFijo estadoActivo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "UPDATE TBL_AF_Estado_Activo_Fijo SET idS = @idS, Nombre = @Nombre, Estado = @Estado WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@pkid", estadoActivo.Pkid);
                command.Parameters.AddWithValue("@idS", estadoActivo.IdS);
                command.Parameters.AddWithValue("@Nombre", estadoActivo.Nombre);
                command.Parameters.AddWithValue("@Estado", estadoActivo.Estado);

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

                string query = "DELETE FROM TBL_AF_Estado_Activo_Fijo WHERE pkid = @pkid";
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

                string query = "UPDATE TBL_AF_Estado_Activo_Fijo SET Estado = 0 " +
                               "WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pkid", pkid);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
