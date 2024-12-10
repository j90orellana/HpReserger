using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica
{
    // Clase oSubTipo que representa la entidad de la tabla
    public class oSubTipo
    {
        public int Pkid { get; set; }
        public string Descripcion { get; set; }
        public string Abreviatura { get; set; }
        public int TipoActivo { get; set; }
        public string CtaContable { get; set; }
        public string CtaContableDepreciacion { get; set; }
        public string CtaContableGasto { get; set; }
        public decimal PorcentajeDepreciacion { get; set; }
        public string CtaGastoEnajenacion { get; set; }
        public string CtaIngresoEnajenacion { get; set; }
        public int Estado { get; set; }
    }

    // Clase principal para las operaciones sobre la tabla TBL_AF_SubTipos
    public class SubTiposActivoFijos
    {
        private readonly string _connectionString;

        public SubTiposActivoFijos()
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

                string query = "SELECT * FROM TBL_AF_SubTipos where estado=1";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);  // Llenar el DataTable con los datos de la consulta
            }

            return dataTable;
        }
        public DataTable GetAllxTipo(int tipo)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = $"SELECT * FROM TBL_AF_SubTipos where estado=1 and tipoactivo= {tipo}";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);  // Llenar el DataTable con los datos de la consulta
            }

            return dataTable;
        }

        // Obtener un registro por ID y mapear a la clase oSubTipo
        public oSubTipo GetById(int pkid)
        {
            oSubTipo subTipo = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM TBL_AF_SubTipos WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pkid", pkid);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        subTipo = new oSubTipo
                        {
                            Pkid = reader.GetInt32(reader.GetOrdinal("pkid")),
                            Descripcion = reader.GetString(reader.GetOrdinal("Descripcion")),
                            Abreviatura = reader.GetString(reader.GetOrdinal("Abreviatura")),
                            TipoActivo = reader.GetInt32(reader.GetOrdinal("TipoActivo")),
                            CtaContable = reader.GetString(reader.GetOrdinal("CtaContable")),
                            CtaContableDepreciacion = reader.IsDBNull(reader.GetOrdinal("CtaContableDepreciacion")) ? null : reader.GetString(reader.GetOrdinal("CtaContableDepreciacion")),
                            CtaContableGasto = reader.IsDBNull(reader.GetOrdinal("CtaContableGasto")) ? null : reader.GetString(reader.GetOrdinal("CtaContableGasto")),
                            PorcentajeDepreciacion = reader.GetDecimal(reader.GetOrdinal("PorcentajeDepreciacion")),
                            CtaGastoEnajenacion = reader.IsDBNull(reader.GetOrdinal("CtaGastoEnajenacion")) ? null : reader.GetString(reader.GetOrdinal("CtaGastoEnajenacion")),
                            CtaIngresoEnajenacion = reader.IsDBNull(reader.GetOrdinal("CtaIngresoEnajenacion")) ? null : reader.GetString(reader.GetOrdinal("CtaIngresoEnajenacion")),
                            Estado = reader.GetInt32(reader.GetOrdinal("Estado"))
                        };
                    }
                }
            }

            return subTipo;
        }

        // Insertar un nuevo registro, retorna true si se afecta alguna fila
        public bool Insert(oSubTipo subTipo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "INSERT INTO TBL_AF_SubTipos (Descripcion, Abreviatura, TipoActivo, CtaContable, CtaContableDepreciacion, CtaContableGasto, PorcentajeDepreciacion, CtaGastoEnajenacion, CtaIngresoEnajenacion, Estado) " +
                               "VALUES (@Descripcion, @Abreviatura, @TipoActivo, @CtaContable, @CtaContableDepreciacion, @CtaContableGasto, @PorcentajeDepreciacion, @CtaGastoEnajenacion, @CtaIngresoEnajenacion, @Estado)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Descripcion", subTipo.Descripcion);
                command.Parameters.AddWithValue("@Abreviatura", subTipo.Abreviatura);
                command.Parameters.AddWithValue("@TipoActivo", subTipo.TipoActivo);
                command.Parameters.AddWithValue("@CtaContable", subTipo.CtaContable);
                command.Parameters.AddWithValue("@CtaContableDepreciacion", (object)subTipo.CtaContableDepreciacion ?? DBNull.Value);
                command.Parameters.AddWithValue("@CtaContableGasto", (object)subTipo.CtaContableGasto ?? DBNull.Value);
                command.Parameters.AddWithValue("@PorcentajeDepreciacion", subTipo.PorcentajeDepreciacion);
                command.Parameters.AddWithValue("@CtaGastoEnajenacion", (object)subTipo.CtaGastoEnajenacion ?? DBNull.Value);
                command.Parameters.AddWithValue("@CtaIngresoEnajenacion", (object)subTipo.CtaIngresoEnajenacion ?? DBNull.Value);
                command.Parameters.AddWithValue("@Estado", subTipo.Estado);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Actualizar un registro existente, retorna true si se afecta alguna fila
        public bool Update(oSubTipo subTipo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "UPDATE TBL_AF_SubTipos SET Descripcion = @Descripcion, Abreviatura = @Abreviatura, TipoActivo = @TipoActivo, " +
                               "CtaContable = @CtaContable, CtaContableDepreciacion = @CtaContableDepreciacion, CtaContableGasto = @CtaContableGasto, " +
                               "PorcentajeDepreciacion = @PorcentajeDepreciacion, CtaGastoEnajenacion = @CtaGastoEnajenacion, CtaIngresoEnajenacion = @CtaIngresoEnajenacion, Estado = @Estado " +
                               "WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@pkid", subTipo.Pkid);
                command.Parameters.AddWithValue("@Descripcion", subTipo.Descripcion);
                command.Parameters.AddWithValue("@Abreviatura", subTipo.Abreviatura);
                command.Parameters.AddWithValue("@TipoActivo", subTipo.TipoActivo);
                command.Parameters.AddWithValue("@CtaContable", subTipo.CtaContable);
                command.Parameters.AddWithValue("@CtaContableDepreciacion", (object)subTipo.CtaContableDepreciacion ?? DBNull.Value);
                command.Parameters.AddWithValue("@CtaContableGasto", (object)subTipo.CtaContableGasto ?? DBNull.Value);
                command.Parameters.AddWithValue("@PorcentajeDepreciacion", subTipo.PorcentajeDepreciacion);
                command.Parameters.AddWithValue("@CtaGastoEnajenacion", (object)subTipo.CtaGastoEnajenacion ?? DBNull.Value);
                command.Parameters.AddWithValue("@CtaIngresoEnajenacion", (object)subTipo.CtaIngresoEnajenacion ?? DBNull.Value);
                command.Parameters.AddWithValue("@Estado", subTipo.Estado);

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

                string query = "DELETE FROM TBL_AF_SubTipos WHERE pkid = @pkid";
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

                string query = "UPDATE TBL_AF_SubTipos SET Estado = 0 " +
                               "WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pkid", pkid);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
