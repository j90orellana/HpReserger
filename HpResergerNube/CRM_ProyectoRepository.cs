
using Npgsql;
using System;
using System.Data;

namespace HpResergerNube
{
    public class CRM_ProyectoRepository
    {
        private readonly string connectionString;

        public CRM_ProyectoRepository()
        {
            this.connectionString = new DLConexion().GetConnectionString();
        }

        public int InsertProyecto(Proyecto proyecto)
        {
            int num = 0;
            using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
            {
                connection.Open();
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand("SELECT MAX(\"ID_Proyecto\") FROM public.\"CRM_Proyecto\"", connection))
                {
                    object obj = npgsqlCommand.ExecuteScalar();
                    num = obj == DBNull.Value || obj == null ? 1 : Convert.ToInt32(obj) + 1;
                }
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand("INSERT INTO public.\"CRM_Proyecto\" (\"ID_Proyecto\", \"Nombre_Proyecto\", \"Referencia\", \"ID_Codigo_postal\", \"Direccion\", \"ID_Tipo_proyecto\", \"ID_Prioridad\", \"ID_Estado\", \"ID_Situacion\", \"Requerimiento\", \"Usuario_Creacion\", \"Fecha_Creacion\", \"Fecha_Recordatorio\", \"Fecha_Cotizacion\", \"Fecha_Cierre\", \"Observaciones\", \"ID_Tipo_Seguimiento\", \"ID_Usuario\", \"ID_Contacto\", \"Archivo\", \"Fotos\", \"Imagen\", \"ID_Cliente\") VALUES (@ID_Proyecto, @Nombre_Proyecto, @Referencia, @ID_Codigo_postal, @Direccion, @ID_Tipo_proyecto, @ID_Prioridad, @ID_Estado, @ID_Situacion, @Requerimiento, @Usuario_Creacion, @Fecha_Creacion, @Fecha_Recordatorio, @Fecha_Cotizacion, @Fecha_Cierre, @Observaciones, @ID_Tipo_Seguimiento, @ID_Usuario, @ID_Contacto, @Archivo, @Fotos, @Imagen,@ID_Cliente)", connection))
                {
                    npgsqlCommand.Parameters.AddWithValue("@ID_Proyecto", (object)num);
                    npgsqlCommand.Parameters.AddWithValue("@Nombre_Proyecto", (object)proyecto.Nombre_Proyecto);
                    npgsqlCommand.Parameters.AddWithValue("@Referencia", (object)proyecto.Referencia);
                    npgsqlCommand.Parameters.AddWithValue("@ID_Codigo_postal", (object)proyecto.ID_Codigo_postal);
                    npgsqlCommand.Parameters.AddWithValue("@Direccion", (object)proyecto.Direccion);
                    npgsqlCommand.Parameters.AddWithValue("@ID_Tipo_proyecto", (object)proyecto.ID_Tipo_proyecto);
                    npgsqlCommand.Parameters.AddWithValue("@ID_Prioridad", (object)proyecto.ID_Prioridad);
                    npgsqlCommand.Parameters.AddWithValue("@ID_Estado", (object)proyecto.ID_Estado);
                    npgsqlCommand.Parameters.AddWithValue("@ID_Situacion", (object)proyecto.ID_Situacion);
                    npgsqlCommand.Parameters.AddWithValue("@Requerimiento", (object)proyecto.Requerimiento);
                    npgsqlCommand.Parameters.AddWithValue("@Usuario_Creacion", (object)proyecto.Usuario_Creacion);
                    npgsqlCommand.Parameters.AddWithValue("@Fecha_Creacion", (object)proyecto.Fecha_Creacion);
                    npgsqlCommand.Parameters.AddWithValue("@Fecha_Recordatorio", (object)proyecto.Fecha_Recordatorio);
                    npgsqlCommand.Parameters.AddWithValue("@Fecha_Cotizacion", (object)proyecto.Fecha_Cotizacion);
                    npgsqlCommand.Parameters.AddWithValue("@Fecha_Cierre", (object)proyecto.Fecha_Cierre);
                    npgsqlCommand.Parameters.AddWithValue("@Observaciones", (object)proyecto.Observaciones ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@ID_Tipo_Seguimiento", (object)proyecto.ID_Tipo_Seguimiento);
                    npgsqlCommand.Parameters.AddWithValue("@ID_Usuario", (object)proyecto.ID_Usuario);
                    npgsqlCommand.Parameters.AddWithValue("@ID_Contacto", (object)proyecto.ID_Contacto);
                    npgsqlCommand.Parameters.AddWithValue("@Archivo", (object)proyecto.Archivo ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Fotos", (object)proyecto.Fotos ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Imagen", (object)proyecto.Imagen ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@ID_Cliente", (object)proyecto.idcliente ?? (object)DBNull.Value);
                    npgsqlCommand.ExecuteNonQuery();
                }
            }
            return num;
        }

        public object FilterProyectosByDateRange(DateTime startDate, DateTime endDate, string cliente, string usuario)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand selectCommand = new NpgsqlCommand(@"SELECT PRO.*, PRI.*, USU.""Nombre"" || ' ' || USU.""Apellido1"" || ' ' || USU.""Apellido2"" AS ""Nombre_Usuario"", 
                CASE WHEN CLI.""ID_Tipo_persona"" = 'J' THEN CLI.""Razon_Social"" ELSE CONCAT(CLI.""Nombre"", ' ', COALESCE(CLI.""Apellido1"", ''), ' ', COALESCE(CLI.""Apellido2"", '')) END AS ""Nombre_Cliente"" 
                	, (SELECT COUNT(1) FROM public.""CRM_Seguimiento"" SEG WHERE SEG.""ID_Proyecto"" = PRO.""ID_Proyecto"") AS ""Seguimientos""


                FROM public.""CRM_Proyecto"" PRO
                LEFT JOIN public.""CRM_Prioridad"" PRI ON PRO.""ID_Prioridad"" = PRI.""ID_Prioridad""
                LEFT JOIN public.""CRM_Cliente"" CLI ON PRO.""ID_Cliente"" = CLI.""ID_Cliente""
                LEFT JOIN public.""CRM_Usuario"" USU ON PRO.""ID_Usuario"" = USU.""ID_Usuario""
                WHERE PRO.""Fecha_Creacion"" BETWEEN @DATE1 AND @DATE2
                AND ('0' = @USER OR PRO.""ID_Usuario"" = @USER)
                AND ('0' = @CLIENTE OR PRO.""ID_Cliente"" = @CLIENTE)
                ORDER BY PRO.""Fecha_Creacion"" DESC;", connection))
                    {
                        selectCommand.Parameters.AddWithValue("@DATE1", startDate);
                        selectCommand.Parameters.AddWithValue("@DATE2", endDate);
                        selectCommand.Parameters.AddWithValue("@CLIENTE", cliente);
                        selectCommand.Parameters.AddWithValue("@USER", usuario);
                        using (NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(selectCommand))
                        {
                            npgsqlDataAdapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al filtrar proyectos: " + ex.Message);
            }
            return dataTable;
        }



        public bool UpdateProyecto(Proyecto proyecto)
        {
            try
            {
                using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(this.connectionString))
                {
                    npgsqlConnection.Open();
                    using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand())
                    {
                        npgsqlCommand.Connection = npgsqlConnection;
                        npgsqlCommand.CommandText = "UPDATE public.\"CRM_Proyecto\" SET \"ID_Cliente\" = @ID_Cliente, \"Nombre_Proyecto\" = @Nombre_Proyecto, \"Referencia\" = @Referencia, \"ID_Codigo_postal\" = @ID_Codigo_postal, \"Direccion\" = @Direccion, \"ID_Tipo_proyecto\" = @ID_Tipo_proyecto, \"ID_Prioridad\" = @ID_Prioridad, \"ID_Estado\" = @ID_Estado, \"ID_Situacion\" = @ID_Situacion, \"Requerimiento\" = @Requerimiento, \"Fecha_Creacion\" = @Fecha_Creacion, \"Fecha_Recordatorio\" = @Fecha_Recordatorio, \"Fecha_Cotizacion\" = @Fecha_Cotizacion, \"Fecha_Cierre\" = @Fecha_Cierre, \"Observaciones\" = @Observaciones, \"ID_Tipo_Seguimiento\" = @ID_Tipo_Seguimiento, \"ID_Usuario\" = @ID_Usuario, \"ID_Contacto\" = @ID_Contacto, \"Archivo\" = @Archivo, \"Fotos\" = @Fotos, \"Imagen\" = @Imagen WHERE \"ID_Proyecto\" = @ID_Proyecto";
                        npgsqlCommand.Parameters.AddWithValue("@ID_Proyecto", (object)proyecto.ID_Proyecto);
                        npgsqlCommand.Parameters.AddWithValue("@Nombre_Proyecto", (object)proyecto.Nombre_Proyecto);
                        npgsqlCommand.Parameters.AddWithValue("@Referencia", (object)proyecto.Referencia);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Codigo_postal", (object)proyecto.ID_Codigo_postal);
                        npgsqlCommand.Parameters.AddWithValue("@Direccion", (object)proyecto.Direccion);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Tipo_proyecto", (object)proyecto.ID_Tipo_proyecto);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Prioridad", (object)proyecto.ID_Prioridad);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Estado", (object)proyecto.ID_Estado);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Situacion", (object)proyecto.ID_Situacion);
                        npgsqlCommand.Parameters.AddWithValue("@Requerimiento", (object)proyecto.Requerimiento);
                        npgsqlCommand.Parameters.AddWithValue("@Fecha_Creacion", (object)proyecto.Fecha_Creacion);
                        npgsqlCommand.Parameters.AddWithValue("@Fecha_Recordatorio", (object)proyecto.Fecha_Recordatorio);
                        npgsqlCommand.Parameters.AddWithValue("@Fecha_Cotizacion", (object)proyecto.Fecha_Cotizacion);
                        npgsqlCommand.Parameters.AddWithValue("@Fecha_Cierre", (object)proyecto.Fecha_Cierre);
                        npgsqlCommand.Parameters.AddWithValue("@Observaciones", (object)proyecto.Observaciones ?? (object)DBNull.Value);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Tipo_Seguimiento", (object)proyecto.ID_Tipo_Seguimiento);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Usuario", (object)proyecto.ID_Usuario);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Contacto", (object)proyecto.ID_Contacto);
                        npgsqlCommand.Parameters.AddWithValue("@Archivo", (object)proyecto.Archivo ?? (object)DBNull.Value);
                        npgsqlCommand.Parameters.AddWithValue("@Fotos", (object)proyecto.Fotos ?? (object)DBNull.Value);
                        npgsqlCommand.Parameters.AddWithValue("@Imagen", (object)proyecto.Imagen ?? (object)DBNull.Value);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Cliente", (object)proyecto.idcliente ?? (object)DBNull.Value);
                        return npgsqlCommand.ExecuteNonQuery() > 0;
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
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(this.connectionString))
            {
                npgsqlConnection.Open();
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand())
                {
                    npgsqlCommand.Connection = npgsqlConnection;
                    npgsqlCommand.CommandText = "DELETE FROM public.\"CRM_Proyecto\" WHERE \"ID_Proyecto\" = @ID_Proyecto";
                    npgsqlCommand.Parameters.AddWithValue("@ID_Proyecto", (object)idProyecto);
                    npgsqlCommand.ExecuteNonQuery();
                }
            }
        }

        public Proyecto ReadProyecto(int idProyecto)
        {
            Proyecto proyecto = (Proyecto)null;
            using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
            {
                connection.Open();
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand("SELECT * FROM public.\"CRM_Proyecto\" WHERE \"ID_Proyecto\" = @ID_Proyecto", connection))
                {
                    npgsqlCommand.Parameters.AddWithValue("@ID_Proyecto", (object)idProyecto);
                    using (NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader())
                    {
                        if (npgsqlDataReader.Read())
                            proyecto = new Proyecto()
                            {
                                ID_Proyecto = Convert.ToInt32(npgsqlDataReader["ID_Proyecto"]),
                                Nombre_Proyecto = npgsqlDataReader["Nombre_Proyecto"].ToString(),
                                Referencia = npgsqlDataReader["Referencia"].ToString(),
                                ID_Codigo_postal = Convert.ToInt32(npgsqlDataReader["ID_Codigo_postal"]),
                                Direccion = npgsqlDataReader["Direccion"].ToString(),
                                ID_Tipo_proyecto = npgsqlDataReader["ID_Tipo_proyecto"].ToString(),
                                ID_Prioridad = npgsqlDataReader["ID_Prioridad"].ToString(),
                                ID_Estado = npgsqlDataReader["ID_Estado"].ToString(),
                                ID_Situacion = npgsqlDataReader["ID_Situacion"].ToString(),
                                Requerimiento = npgsqlDataReader["Requerimiento"].ToString(),
                                Usuario_Creacion = npgsqlDataReader["Usuario_Creacion"].ToString(),
                                Fecha_Creacion = Convert.ToDateTime(npgsqlDataReader["Fecha_Creacion"]),
                                Fecha_Recordatorio = Convert.ToDateTime(npgsqlDataReader["Fecha_Recordatorio"]),
                                Fecha_Cotizacion = Convert.ToDateTime(npgsqlDataReader["Fecha_Cotizacion"]),
                                Fecha_Cierre = Convert.ToDateTime(npgsqlDataReader["Fecha_Cierre"]),
                                Observaciones = npgsqlDataReader["Observaciones"].ToString(),
                                ID_Tipo_Seguimiento = npgsqlDataReader["ID_Tipo_Seguimiento"].ToString(),
                                ID_Usuario = npgsqlDataReader["ID_Usuario"].ToString(),
                                ID_Contacto = npgsqlDataReader["ID_Contacto"].ToString(),
                                Archivo = npgsqlDataReader["Archivo"].ToString(),
                                Fotos = npgsqlDataReader["Fotos"].ToString(),
                                Imagen = npgsqlDataReader["Imagen"] == DBNull.Value ? (byte[])null : (byte[])npgsqlDataReader["Imagen"]
                                ,
                                idcliente = npgsqlDataReader["ID_Cliente"].ToString()
                            };
                    }
                }
            }
            return proyecto;
        }

        public DataTable GetAllProyectos()
        {
            DataTable dataTable = new DataTable();
            using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
            {
                connection.Open();
                using (NpgsqlCommand selectCommand = new NpgsqlCommand("SELECT * FROM public.\"CRM_Proyecto\"", connection))
                {
                    using (NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(selectCommand))
                        npgsqlDataAdapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        public DataTable FilterProyectosByDateRange(DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();
            using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
            {
                connection.Open();
                using (NpgsqlCommand selectCommand = new NpgsqlCommand("SELECT * FROM public.\"CRM_Proyecto\" WHERE \"Fecha_Creacion\" >= @StartDate AND \"Fecha_Creacion\" <= @EndDate ORDER BY  \"Fecha_Creacion\" DESC", connection))
                {
                    selectCommand.Parameters.AddWithValue("@StartDate", (object)startDate);
                    selectCommand.Parameters.AddWithValue("@EndDate", (object)endDate);
                    using (NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(selectCommand))
                        npgsqlDataAdapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        public DataTable GetAllProyectosConTodos()
        {
            DataTable dataTable = new DataTable();
            using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
            {
                connection.Open();
                using (NpgsqlCommand selectCommand = new NpgsqlCommand("SELECT 0 AS ID_Proyecto, 'TODOS' AS Nombre_Proyecto UNION ALL SELECT \"ID_Proyecto\", \"Nombre_Proyecto\" FROM public.\"CRM_Proyecto\"", connection))
                {
                    using (NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(selectCommand))
                        npgsqlDataAdapter.Fill(dataTable);
                }
            }
            return dataTable;
        }
    }
    public class Proyecto
    {
        public int ID_Proyecto { get; set; }

        public string Nombre_Proyecto { get; set; }
        public string idcliente { get; set; }

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

        public byte[] Imagen { get; set; }
    }
}
