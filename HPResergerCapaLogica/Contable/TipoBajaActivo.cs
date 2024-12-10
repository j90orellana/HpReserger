using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica
{
    // Clase oTipoBajaActivo que representa la entidad de la tabla
    public class oTipoBajaActivo
    {
        public int Pkid { get; set; }
        public string Nombre { get; set; }
        public string CuentasAsociadas { get; set; }
        public int Estado { get; set; }
    }

    // Clase principal para las operaciones sobre la tabla TBL_AF_TipoBajaActivo
    public class TipoBajaActivo
    {
        private readonly string _connectionString;

        public TipoBajaActivo()
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

                string query = "SELECT * FROM TBL_AF_TipoBajaActivo WHERE ESTADO = 1";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);  // Llenar el DataTable con los datos de la consulta
            }

            return dataTable;
        }

        // Obtener un registro por ID y mapear a la clase oTipoBajaActivo
        public oTipoBajaActivo GetById(int pkid)
        {
            oTipoBajaActivo tipoBajaActivo = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM TBL_AF_TipoBajaActivo WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pkid", pkid);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        tipoBajaActivo = new oTipoBajaActivo
                        {
                            Pkid = reader.GetInt32(reader.GetOrdinal("pkid")),
                            Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                            CuentasAsociadas = reader.GetString(reader.GetOrdinal("CuentasAsociadas")),
                            Estado = reader.GetInt32(reader.GetOrdinal("Estado"))
                        };
                    }
                }
            }

            return tipoBajaActivo;
        }

        // Insertar un nuevo registro, retorna true si se afecta alguna fila
        public bool Insert(oTipoBajaActivo tipoBajaActivo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "INSERT INTO TBL_AF_TipoBajaActivo (Nombre, CuentasAsociadas, Estado) " +
                               "VALUES (@Nombre, @CuentasAsociadas, @Estado)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Nombre", tipoBajaActivo.Nombre);
                command.Parameters.AddWithValue("@CuentasAsociadas", tipoBajaActivo.CuentasAsociadas);
                command.Parameters.AddWithValue("@Estado", tipoBajaActivo.Estado);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Actualizar un registro existente, retorna true si se afecta alguna fila
        public bool Update(oTipoBajaActivo tipoBajaActivo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "UPDATE TBL_AF_TipoBajaActivo SET Nombre = @Nombre, CuentasAsociadas = @CuentasAsociadas, Estado = @Estado " +
                               "WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@pkid", tipoBajaActivo.Pkid);
                command.Parameters.AddWithValue("@Nombre", tipoBajaActivo.Nombre);
                command.Parameters.AddWithValue("@CuentasAsociadas", tipoBajaActivo.CuentasAsociadas);
                command.Parameters.AddWithValue("@Estado", tipoBajaActivo.Estado);

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

                string query = "DELETE FROM TBL_AF_TipoBajaActivo WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query,connection);
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

                string query = "UPDATE TBL_AF_TipoBajaActivo SET Estado = 0 " +
                               "WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@pkid", pkid);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
