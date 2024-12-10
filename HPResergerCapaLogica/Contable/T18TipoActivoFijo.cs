using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica
{
    public class T18TipoActivoFijo
    {
        private readonly string _connectionString;
        public class oTipoActivoFijo
        {
            public int Pkid { get; set; }
            public int IdS { get; set; }
            public string Nombre { get; set; }
            public int Estado { get; set; }
        }

        public T18TipoActivoFijo()
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

                string query = "SELECT * FROM TBL_AF_TipoActivoFijo WHERE ESTADO = 1";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);  // Llenar el DataTable con los datos de la consulta
            }

            return dataTable;
        }

        // Obtener un registro por ID como clase
        public oTipoActivoFijo GetById(int pkid)
        {
            oTipoActivoFijo tipoActivo = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM TBL_AF_TipoActivoFijo WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pkid", pkid);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        tipoActivo = new oTipoActivoFijo
                        {
                            Pkid = reader.GetInt32(0),
                            IdS = reader.GetInt32(1),
                            Nombre = reader.GetString(2),
                            Estado = reader.GetInt32(3)
                        };
                    }
                }
            }

            return tipoActivo;
        }

        // Insertar un nuevo registro, retorna true si se afecta alguna fila
        public bool Insert(oTipoActivoFijo tipoActivo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "INSERT INTO TBL_AF_TipoActivoFijo (idS, Nombre, Estado) VALUES (@idS, @Nombre, @Estado)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@idS", tipoActivo.IdS);
                command.Parameters.AddWithValue("@Nombre", tipoActivo.Nombre);
                command.Parameters.AddWithValue("@Estado", tipoActivo.Estado);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Actualizar un registro existente, retorna true si se afecta alguna fila
        public bool Update(oTipoActivoFijo tipoActivo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "UPDATE TBL_AF_TipoActivoFijo SET idS = @idS, Nombre = @Nombre, Estado = @Estado WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@pkid", tipoActivo.Pkid);
                command.Parameters.AddWithValue("@idS", tipoActivo.IdS);
                command.Parameters.AddWithValue("@Nombre", tipoActivo.Nombre);
                command.Parameters.AddWithValue("@Estado", tipoActivo.Estado);

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

                string query = "DELETE FROM TBL_AF_TipoActivoFijo WHERE pkid = @pkid";
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

                string query = "UPDATE TBL_AF_TipoActivoFijo SET Estado = 0 " +
                               "WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pkid", pkid);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
