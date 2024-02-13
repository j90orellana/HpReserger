using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_ProyectoRepository
    {
        private readonly string connectionString;

        public CRM_ProyectoRepository()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public int InsertProyecto(Proyecto proyecto)
        {
            int nuevoID = 0;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Obtener el máximo valor actual de ID_Proyecto
                string getMaxIdQuery = "SELECT MAX(\"ID_Proyecto\") FROM public.\"CRM_Proyecto\"";
                using (NpgsqlCommand getMaxIdCmd = new NpgsqlCommand(getMaxIdQuery, connection))
                {
                    object result = getMaxIdCmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        nuevoID = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        nuevoID = 1; // Si no hay registros, comenzar desde 1
                    }
                }

                // Insertar el nuevo proyecto con el nuevo ID
                string insertQuery = "INSERT INTO public.\"CRM_Proyecto\" " +
                    "(\"ID_Proyecto\", \"Nombre_Proyecto\", \"Referencia\", \"ID_Codigo_postal\", \"Direccion\", \"ID_Tipo_proyecto\", " +
                    "\"ID_Prioridad\", \"ID_Estado\", \"ID_Situacion\", \"Requerimiento\", \"Usuario_Creacion\", \"Fecha_Creacion\", " +
                    "\"Fecha_Recordatorio\", \"Fecha_Cotizacion\", \"Fecha_Cierre\", \"Observaciones\", \"ID_Tipo_Seguimiento\", " +
                    "\"ID_Usuario\", \"ID_Contacto\", \"Archivo\", \"Fotos\") " +
                    "VALUES (@ID_Proyecto, @Nombre_Proyecto, @Referencia, @ID_Codigo_postal, @Direccion, @ID_Tipo_proyecto, " +
                    "@ID_Prioridad, @ID_Estado, @ID_Situacion, @Requerimiento, @Usuario_Creacion, @Fecha_Creacion, " +
                    "@Fecha_Recordatorio, @Fecha_Cotizacion, @Fecha_Cierre, @Observaciones, @ID_Tipo_Seguimiento, " +
                    "@ID_Usuario, @ID_Contacto, @Archivo, @Fotos)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Proyecto", nuevoID);
                    cmd.Parameters.AddWithValue("@Nombre_Proyecto", proyecto.Nombre_Proyecto);
                    cmd.Parameters.AddWithValue("@Referencia", proyecto.Referencia);
                    cmd.Parameters.AddWithValue("@ID_Codigo_postal", proyecto.ID_Codigo_postal);
                    cmd.Parameters.AddWithValue("@Direccion", proyecto.Direccion);
                    cmd.Parameters.AddWithValue("@ID_Tipo_proyecto", proyecto.ID_Tipo_proyecto);
                    cmd.Parameters.AddWithValue("@ID_Prioridad", proyecto.ID_Prioridad);
                    cmd.Parameters.AddWithValue("@ID_Estado", proyecto.ID_Estado);
                    cmd.Parameters.AddWithValue("@ID_Situacion", proyecto.ID_Situacion);
                    cmd.Parameters.AddWithValue("@Requerimiento", proyecto.Requerimiento);
                    cmd.Parameters.AddWithValue("@Usuario_Creacion", proyecto.Usuario_Creacion);
                    cmd.Parameters.AddWithValue("@Fecha_Creacion", proyecto.Fecha_Creacion);
                    cmd.Parameters.AddWithValue("@Fecha_Recordatorio", proyecto.Fecha_Recordatorio);
                    cmd.Parameters.AddWithValue("@Fecha_Cotizacion", proyecto.Fecha_Cotizacion);
                    cmd.Parameters.AddWithValue("@Fecha_Cierre", proyecto.Fecha_Cierre);
                    cmd.Parameters.AddWithValue("@Observaciones", proyecto.Observaciones ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Tipo_Seguimiento", proyecto.ID_Tipo_Seguimiento);
                    cmd.Parameters.AddWithValue("@ID_Usuario", proyecto.ID_Usuario);
                    cmd.Parameters.AddWithValue("@ID_Contacto", proyecto.ID_Contacto);
                    cmd.Parameters.AddWithValue("@Archivo", proyecto.Archivo ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fotos", proyecto.Fotos ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }

            return nuevoID; // Retornar el nuevo ID generado
        }

        public bool UpdateProyecto(Proyecto proyecto)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "UPDATE public.\"CRM_Proyecto\" " +
                            "SET \"Nombre_Proyecto\" = @Nombre_Proyecto, \"Referencia\" = @Referencia, \"ID_Codigo_postal\" = @ID_Codigo_postal, " +
                            "\"Direccion\" = @Direccion, \"ID_Tipo_proyecto\" = @ID_Tipo_proyecto, \"ID_Prioridad\" = @ID_Prioridad, " +
                            "\"ID_Estado\" = @ID_Estado, \"ID_Situacion\" = @ID_Situacion, \"Requerimiento\" = @Requerimiento, " +
                            "\"Fecha_Creacion\" = @Fecha_Creacion, \"Fecha_Recordatorio\" = @Fecha_Recordatorio, \"Fecha_Cotizacion\" = @Fecha_Cotizacion, " +
                            "\"Fecha_Cierre\" = @Fecha_Cierre, \"Observaciones\" = @Observaciones, \"ID_Tipo_Seguimiento\" = @ID_Tipo_Seguimiento, " +
                            "\"ID_Usuario\" = @ID_Usuario, \"ID_Contacto\" = @ID_Contacto, \"Archivo\" = @Archivo, \"Fotos\" = @Fotos " +
                            "WHERE \"ID_Proyecto\" = @ID_Proyecto";
                        cmd.Parameters.AddWithValue("@ID_Proyecto", proyecto.ID_Proyecto);
                        cmd.Parameters.AddWithValue("@Nombre_Proyecto", proyecto.Nombre_Proyecto);
                        cmd.Parameters.AddWithValue("@Referencia", proyecto.Referencia);
                        cmd.Parameters.AddWithValue("@ID_Codigo_postal", proyecto.ID_Codigo_postal);
                        cmd.Parameters.AddWithValue("@Direccion", proyecto.Direccion);
                        cmd.Parameters.AddWithValue("@ID_Tipo_proyecto", proyecto.ID_Tipo_proyecto);
                        cmd.Parameters.AddWithValue("@ID_Prioridad", proyecto.ID_Prioridad);
                        cmd.Parameters.AddWithValue("@ID_Estado", proyecto.ID_Estado);
                        cmd.Parameters.AddWithValue("@ID_Situacion", proyecto.ID_Situacion);
                        cmd.Parameters.AddWithValue("@Requerimiento", proyecto.Requerimiento);
                        cmd.Parameters.AddWithValue("@Fecha_Creacion", proyecto.Fecha_Creacion);
                        cmd.Parameters.AddWithValue("@Fecha_Recordatorio", proyecto.Fecha_Recordatorio);
                        cmd.Parameters.AddWithValue("@Fecha_Cotizacion", proyecto.Fecha_Cotizacion);
                        cmd.Parameters.AddWithValue("@Fecha_Cierre", proyecto.Fecha_Cierre);
                        cmd.Parameters.AddWithValue("@Observaciones", proyecto.Observaciones ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@ID_Tipo_Seguimiento", proyecto.ID_Tipo_Seguimiento);
                        cmd.Parameters.AddWithValue("@ID_Usuario", proyecto.ID_Usuario);
                        cmd.Parameters.AddWithValue("@ID_Contacto", proyecto.ID_Contacto);
                        cmd.Parameters.AddWithValue("@Archivo", proyecto.Archivo ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Fotos", proyecto.Fotos ?? (object)DBNull.Value);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine("Error al actualizar el proyecto: " + ex.Message);
                return false;
            }
        }


        public void DeleteProyecto(int idProyecto)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Proyecto\" WHERE \"ID_Proyecto\" = @ID_Proyecto";
                    cmd.Parameters.AddWithValue("@ID_Proyecto", idProyecto);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public Proyecto ReadProyecto(int idProyecto)
        {
            Proyecto proyecto = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Proyecto\" WHERE \"ID_Proyecto\" = @ID_Proyecto", connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Proyecto", idProyecto);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            proyecto = new Proyecto
                            {
                                ID_Proyecto = Convert.ToInt32(reader["ID_Proyecto"]),
                                Nombre_Proyecto = reader["Nombre_Proyecto"].ToString(),
                                Referencia = reader["Referencia"].ToString(),
                                ID_Codigo_postal = Convert.ToInt32(reader["ID_Codigo_postal"]),
                                Direccion = reader["Direccion"].ToString(),
                                ID_Tipo_proyecto = reader["ID_Tipo_proyecto"].ToString(),
                                ID_Prioridad = reader["ID_Prioridad"].ToString(),
                                ID_Estado = reader["ID_Estado"].ToString(),
                                ID_Situacion = reader["ID_Situacion"].ToString(),
                                Requerimiento = reader["Requerimiento"].ToString(),
                                Usuario_Creacion = reader["Usuario_Creacion"].ToString(),
                                Fecha_Creacion = Convert.ToDateTime(reader["Fecha_Creacion"]),
                                Fecha_Recordatorio = Convert.ToDateTime(reader["Fecha_Recordatorio"]),
                                Fecha_Cotizacion = Convert.ToDateTime(reader["Fecha_Cotizacion"]),
                                Fecha_Cierre = Convert.ToDateTime(reader["Fecha_Cierre"]),
                                Observaciones = reader["Observaciones"].ToString(),
                                ID_Tipo_Seguimiento = reader["ID_Tipo_Seguimiento"].ToString(),
                                ID_Usuario = reader["ID_Usuario"].ToString(),
                                ID_Contacto = reader["ID_Contacto"].ToString(),
                                Archivo = reader["Archivo"].ToString(),
                                Fotos = reader["Fotos"].ToString()
                            };
                        }
                    }
                }
            }

            return proyecto;
        }

        public DataTable GetAllProyectos()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Proyecto\"", connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
        public DataTable FilterProyectosByDateRange(DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM public.\"CRM_Proyecto\" WHERE \"Fecha_Creacion\" >= @StartDate AND \"Fecha_Creacion\" <= @EndDate ORDER BY  \"Fecha_Creacion\" DESC";

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

    }

    public class Proyecto
    {
        public int ID_Proyecto { get; set; }
        public string Nombre_Proyecto { get; set; }
        public string Referencia { get; set; }
        public int ID_Codigo_postal { get; set; }
        public string Direccion { get; set; }
        public string ID_Tipo_proyecto { get; set; }
        public string ID_Prioridad { get; set; }
        public string ID_Estado { get; set; }
        public string ID_Situacion { get; set; }
        public string Requerimiento { get; set; }
        public string Usuario_Creacion { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public DateTime Fecha_Recordatorio { get; set; }
        public DateTime Fecha_Cotizacion { get; set; }
        public DateTime Fecha_Cierre { get; set; }
        public string Observaciones { get; set; }
        public string ID_Tipo_Seguimiento { get; set; }
        public string ID_Usuario { get; set; }
        public string ID_Contacto { get; set; }
        public string Archivo { get; set; }
        public string Fotos { get; set; }
    }
}
