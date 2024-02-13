using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_SeguimientoRepository
    {
        private readonly string connectionString;

        public CRM_SeguimientoRepository()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }
        public DataTable FilterSeguimientosByDateRange(DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM public.\"CRM_Seguimiento\" WHERE \"Fecha_Seguimiento\" >= @StartDate AND \"Fecha_Seguimiento\" <= @EndDate ORDER BY \"Fecha_Seguimiento\" DESC";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public int InsertSeguimiento(CRM_Seguimiento seguimiento)
        {
            int insertedId = -1; // Valor predeterminado en caso de error

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "INSERT INTO public.\"CRM_Seguimiento\" (\"ID_Seguimiento\", \"ID_Proyecto\", \"Nombre_Proyecto\", \"Usuario_Creacion\", \"ID_Tipo_Seguimiento\", \"Detalle_Tipo_Seguimiento\", \"ID_Contacto\", \"Contacto\", \"Fecha_Seguimiento\", \"Fecha_Prox_Seguimiento\", \"Descripción\") VALUES ((SELECT COALESCE(MAX(\"ID_Seguimiento\"), 0) + 1 FROM public.\"CRM_Seguimiento\"), @ID_Proyecto, @Nombre_Proyecto, @Usuario_Creacion, @ID_Tipo_Seguimiento, @Detalle_Tipo_Seguimiento, @ID_Contacto, @Contacto, @Fecha_Seguimiento, @Fecha_Prox_Seguimiento, @Descripcion) RETURNING \"ID_Seguimiento\"";

                        // Set parameters
                        cmd.Parameters.AddWithValue("@ID_Proyecto", seguimiento.ID_Proyecto);
                        cmd.Parameters.AddWithValue("@Nombre_Proyecto", seguimiento.Nombre_Proyecto);
                        cmd.Parameters.AddWithValue("@Usuario_Creacion", seguimiento.Usuario_Creacion);
                        cmd.Parameters.AddWithValue("@ID_Tipo_Seguimiento", seguimiento.ID_Tipo_Seguimiento);
                        cmd.Parameters.AddWithValue("@Detalle_Tipo_Seguimiento", seguimiento.Detalle_Tipo_Seguimiento);
                        cmd.Parameters.AddWithValue("@ID_Contacto", seguimiento.ID_Contacto);
                        cmd.Parameters.AddWithValue("@Contacto", seguimiento.Contacto);
                        cmd.Parameters.AddWithValue("@Fecha_Seguimiento", seguimiento.Fecha_Seguimiento);
                        cmd.Parameters.AddWithValue("@Fecha_Prox_Seguimiento", seguimiento.Fecha_Prox_Seguimiento);
                        cmd.Parameters.AddWithValue("@Descripcion", seguimiento.Descripción);

                        // Execute the command and get the inserted ID
                        insertedId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions here, if needed
                // You may want to log the exception or display an error message
            }

            return insertedId;
        }

        public bool UpdateSeguimiento(CRM_Seguimiento seguimiento)
        {
            bool success = false;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "UPDATE public.\"CRM_Seguimiento\" SET \"ID_Proyecto\" = @ID_Proyecto, \"Nombre_Proyecto\" = @Nombre_Proyecto, \"Usuario_Creacion\" = @Usuario_Creacion, \"ID_Tipo_Seguimiento\" = @ID_Tipo_Seguimiento, \"Detalle_Tipo_Seguimiento\" = @Detalle_Tipo_Seguimiento, \"ID_Contacto\" = @ID_Contacto, \"Contacto\" = @Contacto, \"Fecha_Seguimiento\" = @Fecha_Seguimiento, \"Fecha_Prox_Seguimiento\" = @Fecha_Prox_Seguimiento, \"Descripción\" = @Descripcion WHERE \"ID_Seguimiento\" = @ID_Seguimiento";

                        // Set parameters
                        cmd.Parameters.AddWithValue("@ID_Seguimiento", seguimiento.ID_Seguimiento);
                        cmd.Parameters.AddWithValue("@ID_Proyecto", seguimiento.ID_Proyecto);
                        cmd.Parameters.AddWithValue("@Nombre_Proyecto", seguimiento.Nombre_Proyecto);
                        cmd.Parameters.AddWithValue("@Usuario_Creacion", seguimiento.Usuario_Creacion);
                        cmd.Parameters.AddWithValue("@ID_Tipo_Seguimiento", seguimiento.ID_Tipo_Seguimiento);
                        cmd.Parameters.AddWithValue("@Detalle_Tipo_Seguimiento", seguimiento.Detalle_Tipo_Seguimiento);
                        cmd.Parameters.AddWithValue("@ID_Contacto", seguimiento.ID_Contacto);
                        cmd.Parameters.AddWithValue("@Contacto", seguimiento.Contacto);
                        cmd.Parameters.AddWithValue("@Fecha_Seguimiento", seguimiento.Fecha_Seguimiento);
                        cmd.Parameters.AddWithValue("@Fecha_Prox_Seguimiento", seguimiento.Fecha_Prox_Seguimiento);
                        cmd.Parameters.AddWithValue("@Descripcion", seguimiento.Descripción);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Si al menos una fila fue afectada, considerar la operación como exitosa
                        success = rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción aquí, si es necesario
                // Puedes querer registrar la excepción o mostrar un mensaje de error
            }

            return success;
        }

        public void DeleteSeguimiento(decimal seguimientoID)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Seguimiento\" WHERE \"ID_Seguimiento\" = @ID_Seguimiento";

                    // Set parameter
                    cmd.Parameters.AddWithValue("@ID_Seguimiento", seguimientoID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public CRM_Seguimiento SelectSeguimiento(decimal seguimientoID)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM public.\"CRM_Seguimiento\" WHERE \"ID_Seguimiento\" = @ID_Seguimiento";

                    // Set parameter
                    cmd.Parameters.AddWithValue("@ID_Seguimiento", seguimientoID);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapSeguimientoFromDataReader(reader);
                        }
                    }
                }

                return null;
            }
        }

        private CRM_Seguimiento MapSeguimientoFromDataReader(IDataReader reader)
        {
            return new CRM_Seguimiento
            {
                ID_Seguimiento = Convert.ToDecimal(reader["ID_Seguimiento"]),
                ID_Proyecto = Convert.ToDecimal(reader["ID_Proyecto"]),
                Nombre_Proyecto = reader["Nombre_Proyecto"].ToString(),
                Usuario_Creacion = reader["Usuario_Creacion"].ToString(),
                ID_Tipo_Seguimiento = reader["ID_Tipo_Seguimiento"].ToString(),
                Detalle_Tipo_Seguimiento = reader["Detalle_Tipo_Seguimiento"].ToString(),
                ID_Contacto = reader["ID_Contacto"].ToString(),
                Contacto = reader["Contacto"].ToString(),
                Fecha_Seguimiento = Convert.ToDateTime(reader["Fecha_Seguimiento"]),
                Fecha_Prox_Seguimiento = Convert.ToDateTime(reader["Fecha_Prox_Seguimiento"]),
                Descripción = reader["Descripción"].ToString()
            };
        }
        public class CRM_Seguimiento
        {
            public decimal ID_Seguimiento { get; set; }
            public decimal ID_Proyecto { get; set; }
            public string Nombre_Proyecto { get; set; }
            public string Usuario_Creacion { get; set; }
            public string ID_Tipo_Seguimiento { get; set; }
            public string Detalle_Tipo_Seguimiento { get; set; }
            public string ID_Contacto { get; set; }
            public string Contacto { get; set; }
            public DateTime Fecha_Seguimiento { get; set; }
            public DateTime Fecha_Prox_Seguimiento { get; set; }
            public string Descripción { get; set; }
        }
    }
}
