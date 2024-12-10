using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica.Contable
{
    public class ActivosFijos
    { // Clase oActivoFijo que representa la entidad de la tabla TBL_Activos_Fijos
        public class oActivoFijo
    {
        public int Id { get; set; }                  // Id no necesita valor por defecto si es auto-incremental en la base de datos
        public int EmpresaId { get; set; } = 0;      // Valor predeterminado a 0 para IDs
        public string Codigo { get; set; } = "";     // Valor predeterminado a cadena vacía
        public int TipoActivoId { get; set; } = 0;
        public int ClasificacionId { get; set; } = 0;
        public int MetodoDepreciacionId { get; set; } = 0;
        public decimal ValorActivo { get; set; } = 0.0m;            // Valor predeterminado a 0.0
        public decimal ValorResidual { get; set; } = 0.0m;
        public decimal DepreciacionContable { get; set; } = 0.0m;
        public decimal DepreciacionTributaria { get; set; } = 0.0m;
        public DateTime FechaAdquisicion { get; set; } = DateTime.Now;  // Fecha predeterminada al día actual
        public DateTime FechaAlta { get; set; } = DateTime.Now;
        public string Marca { get; set; } = "";
        public string Modelo { get; set; } = "";
        public string NumeroSerie { get; set; } = "";
        public string CuentaActivo { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public int CatalogoExistenciaId { get; set; } = 0;
        public string CodigoExistencia { get; set; } = "";
        public int TipoActivoFijoId { get; set; } = 0;
        public int EstadoActivoFijoId { get; set; } = 0;
        public DateTime LE_Fecha { get; set; } = DateTime.Now;
        public int LE_NumeroContrato { get; set; } = 0;
        public DateTime LE_FechaInicio { get; set; } = DateTime.Now;
        public int LE_NumeroCuotas { get; set; } = 0;
        public decimal LE_MontoTotal { get; set; } = 0.0m;
        public int Estado { get; set; } = 1;         // Estado predeterminado a 1 (activo)
    }

    // Clase principal para las operaciones sobre la tabla TBL_Activos_Fijos
   
        private readonly string _connectionString;

        public ActivosFijos()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }

        // Obtener todos los registros como DataTable
        public DataTable GetAll(int pkempresa)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = $"SELECT * FROM TBL_Activos_Fijos where (empresaid = {pkempresa} or {pkempresa}=0) ";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
  public DataTable GetAll( )
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = $" SELECT e.Empresa, a.* FROM TBL_Activos_Fijos a inner join TBL_Empresa e on a.EmpresaId = e.Id_Empresa order by 1, FechaAlta desc";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        // Obtener un registro por ID y mapear a la clase oActivoFijo
        public oActivoFijo GetById(int id)
        {
            oActivoFijo activoFijo = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM TBL_Activos_Fijos WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        activoFijo = new oActivoFijo
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            EmpresaId = reader.GetInt32(reader.GetOrdinal("EmpresaId")),
                            Codigo = reader.GetString(reader.GetOrdinal("Codigo")),
                            TipoActivoId = reader.GetInt32(reader.GetOrdinal("TipoActivoId")),
                            ClasificacionId = reader.GetInt32(reader.GetOrdinal("ClasificacionId")),
                            MetodoDepreciacionId = reader.GetInt32(reader.GetOrdinal("MetodoDepreciacionId")),
                            ValorActivo = reader.GetDecimal(reader.GetOrdinal("ValorActivo")),
                            ValorResidual = reader.GetDecimal(reader.GetOrdinal("ValorResidual")),
                            DepreciacionContable = reader.GetDecimal(reader.GetOrdinal("DepreciacionContable")),
                            DepreciacionTributaria = reader.GetDecimal(reader.GetOrdinal("DepreciacionTributaria")),
                            FechaAdquisicion = reader.GetDateTime(reader.GetOrdinal("FechaAdquisicion")),
                            FechaAlta = reader.GetDateTime(reader.GetOrdinal("FechaAlta")),
                            Marca = reader.GetString(reader.GetOrdinal("Marca")),
                            Modelo = reader.GetString(reader.GetOrdinal("Modelo")),
                            NumeroSerie = reader.GetString(reader.GetOrdinal("NumeroSerie")),
                            CuentaActivo = reader.GetString(reader.GetOrdinal("CuentaActivo")),
                            Descripcion = reader.GetString(reader.GetOrdinal("Descripcion")),
                            CatalogoExistenciaId = reader.GetInt32(reader.GetOrdinal("CatalogoExistenciaId")),
                            CodigoExistencia = reader.GetString(reader.GetOrdinal("CodigoExistencia")),
                            TipoActivoFijoId = reader.GetInt32(reader.GetOrdinal("TipoActivoFijoId")),
                            EstadoActivoFijoId = reader.GetInt32(reader.GetOrdinal("EstadoActivoFijoId")),
                            LE_Fecha = reader.GetDateTime(reader.GetOrdinal("LE_Fecha")),
                            LE_NumeroContrato = reader.GetInt32(reader.GetOrdinal("LE_NumeroContrato")),
                            LE_FechaInicio = reader.GetDateTime(reader.GetOrdinal("LE_FechaInicio")),
                            LE_NumeroCuotas = reader.GetInt32(reader.GetOrdinal("LE_NumeroCuotas")),
                            LE_MontoTotal = reader.GetDecimal(reader.GetOrdinal("LE_MontoTotal")),
                            Estado = reader.GetInt32(reader.GetOrdinal("Estado"))

                        };
                    }
                }
            }

            return activoFijo;
        }

        // Insertar un nuevo registro, retorna true si se afecta alguna fila
        public int Insert(oActivoFijo activoFijo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"
            INSERT INTO TBL_Activos_Fijos 
            (EmpresaId, Codigo, TipoActivoId, ClasificacionId, MetodoDepreciacionId, ValorActivo, 
             ValorResidual, DepreciacionContable, DepreciacionTributaria, FechaAdquisicion, FechaAlta, 
             Marca, Modelo, NumeroSerie, CuentaActivo, Descripcion, CatalogoExistenciaId, CodigoExistencia, 
             TipoActivoFijoId, EstadoActivoFijoId, LE_Fecha, LE_NumeroContrato, LE_FechaInicio, 
             LE_NumeroCuotas, LE_MontoTotal, Estado)
            VALUES 
            (@EmpresaId, @Codigo, @TipoActivoId, @ClasificacionId, @MetodoDepreciacionId, @ValorActivo, 
             @ValorResidual, @DepreciacionContable, @DepreciacionTributaria, @FechaAdquisicion, @FechaAlta, 
             @Marca, @Modelo, @NumeroSerie, @CuentaActivo, @Descripcion, @CatalogoExistenciaId, 
             @CodigoExistencia, @TipoActivoFijoId, @EstadoActivoFijoId, @LE_Fecha, @LE_NumeroContrato, 
             @LE_FechaInicio, @LE_NumeroCuotas, @LE_MontoTotal, @Estado);
            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@EmpresaId", activoFijo.EmpresaId);
                command.Parameters.AddWithValue("@Codigo", activoFijo.Codigo);
                command.Parameters.AddWithValue("@TipoActivoId", activoFijo.TipoActivoId);
                command.Parameters.AddWithValue("@ClasificacionId", activoFijo.ClasificacionId);
                command.Parameters.AddWithValue("@MetodoDepreciacionId", activoFijo.MetodoDepreciacionId);
                command.Parameters.AddWithValue("@ValorActivo", activoFijo.ValorActivo);
                command.Parameters.AddWithValue("@ValorResidual", activoFijo.ValorResidual);
                command.Parameters.AddWithValue("@DepreciacionContable", activoFijo.DepreciacionContable);
                command.Parameters.AddWithValue("@DepreciacionTributaria", activoFijo.DepreciacionTributaria);
                command.Parameters.AddWithValue("@FechaAdquisicion", activoFijo.FechaAdquisicion);
                command.Parameters.AddWithValue("@FechaAlta", activoFijo.FechaAlta);
                command.Parameters.AddWithValue("@Marca", activoFijo.Marca);
                command.Parameters.AddWithValue("@Modelo", activoFijo.Modelo);
                command.Parameters.AddWithValue("@NumeroSerie", activoFijo.NumeroSerie);
                command.Parameters.AddWithValue("@CuentaActivo", activoFijo.CuentaActivo);
                command.Parameters.AddWithValue("@Descripcion", activoFijo.Descripcion);
                command.Parameters.AddWithValue("@CatalogoExistenciaId", activoFijo.CatalogoExistenciaId);
                command.Parameters.AddWithValue("@CodigoExistencia", activoFijo.CodigoExistencia);
                command.Parameters.AddWithValue("@TipoActivoFijoId", activoFijo.TipoActivoFijoId);
                command.Parameters.AddWithValue("@EstadoActivoFijoId", activoFijo.EstadoActivoFijoId);
                command.Parameters.AddWithValue("@LE_Fecha", activoFijo.LE_Fecha);
                command.Parameters.AddWithValue("@LE_NumeroContrato", activoFijo.LE_NumeroContrato);
                command.Parameters.AddWithValue("@LE_FechaInicio", activoFijo.LE_FechaInicio);
                command.Parameters.AddWithValue("@LE_NumeroCuotas", activoFijo.LE_NumeroCuotas);
                command.Parameters.AddWithValue("@LE_MontoTotal", activoFijo.LE_MontoTotal);
                command.Parameters.AddWithValue("@Estado", activoFijo.Estado);

                object result = command.ExecuteScalar();

                // Devuelve el ID insertado o 0 si el resultado es nulo.
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }


        // Actualizar un registro existente
        public bool Update(oActivoFijo activoFijo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"UPDATE TBL_Activos_Fijos SET 
                    EmpresaId = @EmpresaId, Codigo = @Codigo, TipoActivoId = @TipoActivoId, 
                    ClasificacionId = @ClasificacionId, MetodoDepreciacionId = @MetodoDepreciacionId, 
                    ValorActivo = @ValorActivo, ValorResidual = @ValorResidual, DepreciacionContable = @DepreciacionContable, 
                    DepreciacionTributaria = @DepreciacionTributaria, FechaAdquisicion = @FechaAdquisicion, FechaAlta = @FechaAlta, 
                    Marca = @Marca, Modelo = @Modelo, NumeroSerie = @NumeroSerie, CuentaActivo = @CuentaActivo, 
                    Descripcion = @Descripcion, CatalogoExistenciaId = @CatalogoExistenciaId, CodigoExistencia = @CodigoExistencia, 
                    TipoActivoFijoId = @TipoActivoFijoId, EstadoActivoFijoId = @EstadoActivoFijoId, LE_Fecha = @LE_Fecha, 
                    LE_NumeroContrato = @LE_NumeroContrato, LE_FechaInicio = @LE_FechaInicio, LE_NumeroCuotas = @LE_NumeroCuotas, 
                    LE_MontoTotal = @LE_MontoTotal,Estado=@Estado WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", activoFijo.Id);
                command.Parameters.AddWithValue("@EmpresaId", activoFijo.EmpresaId);
                command.Parameters.AddWithValue("@Codigo", activoFijo.Codigo);
                command.Parameters.AddWithValue("@TipoActivoId", activoFijo.TipoActivoId);
                command.Parameters.AddWithValue("@ClasificacionId", activoFijo.ClasificacionId);
                command.Parameters.AddWithValue("@MetodoDepreciacionId", activoFijo.MetodoDepreciacionId);
                command.Parameters.AddWithValue("@ValorActivo", activoFijo.ValorActivo);
                command.Parameters.AddWithValue("@ValorResidual", activoFijo.ValorResidual);
                command.Parameters.AddWithValue("@DepreciacionContable", activoFijo.DepreciacionContable);
                command.Parameters.AddWithValue("@DepreciacionTributaria", activoFijo.DepreciacionTributaria);
                command.Parameters.AddWithValue("@FechaAdquisicion", activoFijo.FechaAdquisicion);
                command.Parameters.AddWithValue("@FechaAlta", activoFijo.FechaAlta);
                command.Parameters.AddWithValue("@Marca", activoFijo.Marca);
                command.Parameters.AddWithValue("@Modelo", activoFijo.Modelo);
                command.Parameters.AddWithValue("@NumeroSerie", activoFijo.NumeroSerie);
                command.Parameters.AddWithValue("@CuentaActivo", activoFijo.CuentaActivo);
                command.Parameters.AddWithValue("@Descripcion", activoFijo.Descripcion);
                command.Parameters.AddWithValue("@CatalogoExistenciaId", activoFijo.CatalogoExistenciaId);
                command.Parameters.AddWithValue("@CodigoExistencia", activoFijo.CodigoExistencia);
                command.Parameters.AddWithValue("@TipoActivoFijoId", activoFijo.TipoActivoFijoId);
                command.Parameters.AddWithValue("@EstadoActivoFijoId", activoFijo.EstadoActivoFijoId);
                command.Parameters.AddWithValue("@LE_Fecha", activoFijo.LE_Fecha);
                command.Parameters.AddWithValue("@LE_NumeroContrato", activoFijo.LE_NumeroContrato);
                command.Parameters.AddWithValue("@LE_FechaInicio", activoFijo.LE_FechaInicio);
                command.Parameters.AddWithValue("@LE_NumeroCuotas", activoFijo.LE_NumeroCuotas);
                command.Parameters.AddWithValue("@LE_MontoTotal", activoFijo.LE_MontoTotal);
                command.Parameters.AddWithValue("@Estado", activoFijo.Estado);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Eliminar un registro, retorna true si se afecta alguna fila
        public bool Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "DELETE FROM TBL_Activos_Fijos WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        // Cambiar el estado a inactivo en lugar de eliminar el registro
        public bool EliminarLogicoActivoFijo(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "UPDATE TBL_Activos_Fijos SET Estado = 0 WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

    }
}

