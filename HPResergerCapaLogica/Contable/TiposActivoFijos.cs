using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica
{
    // Clase oTipoActivoFijo que representa la entidad de la tabla
    public class oTipoActivoFijo
    {
        public int Pkid { get; set; }
        public string Nombre { get; set; }
        public string Cuenta { get; set; }
        public int Estado { get; set; }
    }

    // Clase principal para las operaciones sobre la tabla TBL_AF_TipoActivoFijos
    public class TiposActivoFijos
    {
        private readonly string _connectionString;

        public TiposActivoFijos()
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

                string query = "SELECT * FROM TBL_AF_TipoActivoFijos WHERE ESTADO=1";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);  // Llenar el DataTable con los datos de la consulta
            }

            return dataTable;
        }
        public DataTable GetAllCuentasContables(int pkid)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"SELECT * 
                                FROM TBL_Cuenta_Contable
                                WHERE CtaDetalle = 1
                                  AND EstadoCta = 1
                                  AND Id_Cuenta_Contable LIKE(
                                      SELECT TOP 1 Cuenta
                                      FROM TBL_AF_TipoActivoFijos
                                      WHERE ESTADO = 1
                                        AND pkid = @pkid
                                  ) + '%' ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pkid", pkid);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);  // Llenar el DataTable con los datos de la consulta
            }

            return dataTable;
        }

        // Obtener un registro por ID y mapear a la clase oTipoActivoFijo
        public oTipoActivoFijo GetById(int pkid)
        {
            oTipoActivoFijo tipoActivoFijo = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM TBL_AF_TipoActivoFijos WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pkid", pkid);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        tipoActivoFijo = new oTipoActivoFijo
                        {
                            Pkid = reader.GetInt32(reader.GetOrdinal("pkid")),
                            Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                            Cuenta = reader.GetString(reader.GetOrdinal("Cuenta")),
                            Estado = reader.GetInt32(reader.GetOrdinal("Estado"))
                        };
                    }
                }
            }

            return tipoActivoFijo;
        }

        // Insertar un nuevo registro, retorna true si se afecta alguna fila
        public bool Insert(oTipoActivoFijo tipoActivoFijo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "INSERT INTO TBL_AF_TipoActivoFijos (Nombre, Cuenta, Estado) VALUES (@Nombre, @Cuenta, @Estado)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Nombre", tipoActivoFijo.Nombre);
                command.Parameters.AddWithValue("@Cuenta", tipoActivoFijo.Cuenta);
                command.Parameters.AddWithValue("@Estado", tipoActivoFijo.Estado);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Actualizar un registro existente, retorna true si se afecta alguna fila
        public bool Update(oTipoActivoFijo tipoActivoFijo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "UPDATE TBL_AF_TipoActivoFijos SET Nombre = @Nombre, Cuenta = @Cuenta, Estado = @Estado WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@pkid", tipoActivoFijo.Pkid);
                command.Parameters.AddWithValue("@Nombre", tipoActivoFijo.Nombre);
                command.Parameters.AddWithValue("@Cuenta", tipoActivoFijo.Cuenta);
                command.Parameters.AddWithValue("@Estado", tipoActivoFijo.Estado);

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

                string query = "DELETE FROM TBL_AF_TipoActivoFijos WHERE pkid = @pkid";
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

                string query = "UPDATE TBL_AF_TipoActivoFijos SET Estado = 0 " +
                               "WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pkid", pkid);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
