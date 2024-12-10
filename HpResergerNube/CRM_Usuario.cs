using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_Usuario
    {
        public string ID_Usuario { get; set; }
        public string ID_Tipo_Documento { get; set; }
        public decimal ID_Numero_Doc { get; set; }
        public string ID_Sexo { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public decimal Telefono1 { get; set; }
        public decimal? Telefono2 { get; set; }
        public string email1 { get; set; }
        public string email2 { get; set; }
        public string Direccion { get; set; }
        public string Interior { get; set; }
        public string Piso { get; set; }
        public decimal ID_Codigo_postal { get; set; }
        public string ID_Tratamiento { get; set; }
        public string Otros { get; set; }
        public string Usuario_Creacion { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public string Usuario_Modificacion { get; set; }
        public DateTime? Fecha_Modificacion { get; set; }
        public string Usuario_Eliminacion { get; set; }
        public DateTime? Fecha_Eliminacion { get; set; }
        public string ID_Perfiles { get; set; }
        public string password { get; set; }
        public int estado { get; set; }

        private string connectionString;

        public CRM_Usuario()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }
        public DataTable FilterClientesByDateRange(DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT *, (\"Nombre\" || ' ' || \"Apellido1\" || ' ' || \"Apellido2\") AS \"NombreCompleto\" FROM public.\"CRM_Usuario\" WHERE \"Fecha_Creacion\" >= @StartDate AND \"Fecha_Creacion\" <= @EndDate ORDER BY COALESCE(\"Fecha_Modificacion\", \"Fecha_Creacion\") DESC";

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
        public int InsertUsuario(CRM_Usuario usuario)
        {
            int nuevoIDUsuario = 0;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT COALESCE(MAX(CAST(\"ID_Usuario\" AS INTEGER)), 0) + 1 FROM public.\"CRM_Usuario\";";
                    nuevoIDUsuario = (int)cmd.ExecuteScalar();

                    cmd.CommandText = "INSERT INTO public.\"CRM_Usuario\"(" +
                        "\"ID_Usuario\", \"ID_Tipo_Documento\", \"ID_Numero_Doc\", \"ID_Sexo\", \"Nombre\", " +
                        "\"Apellido1\", \"Apellido2\", \"Telefono1\", \"Telefono2\", \"email1\", \"email2\", \"Direccion\", " +
                        "\"Interior\", \"Piso\", \"ID_Codigo_postal\", \"ID_Tratamiento\", \"Otros\", \"Usuario_Creacion\", " +
                        "\"Fecha_Creacion\", \"Usuario_Modificacion\", \"Fecha_Modificacion\", \"Usuario_Eliminacion\", " +
                        "\"Fecha_Eliminacion\", \"ID_Perfiles\" ,\"Estado\" ,\"Password\") " +
                        "VALUES(@ID_Usuario, @ID_Tipo_Documento, @ID_Numero_Doc, @ID_Sexo, @Nombre, " +
                        "@Apellido1, @Apellido2, @Telefono1, @Telefono2, @email1, @email2, @Direccion, " +
                        "@Interior, @Piso, @ID_Codigo_postal, @ID_Tratamiento, @Otros, @Usuario_Creacion, " +
                        "@Fecha_Creacion, @Usuario_Modificacion, @Fecha_Modificacion, @Usuario_Eliminacion, " +
                        "@Fecha_Eliminacion, @ID_Perfiles, @estado, @password);";

                    cmd.Parameters.AddWithValue("@ID_Usuario", nuevoIDUsuario);
                    cmd.Parameters.AddWithValue("@ID_Tipo_Documento", usuario.ID_Tipo_Documento ?? "");
                    cmd.Parameters.AddWithValue("@ID_Numero_Doc", usuario.ID_Numero_Doc);
                    cmd.Parameters.AddWithValue("@ID_Sexo", usuario.ID_Sexo ?? "");
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre ?? "");
                    cmd.Parameters.AddWithValue("@Apellido1", usuario.Apellido1 ?? "");
                    cmd.Parameters.AddWithValue("@Apellido2", usuario.Apellido2 ?? "");
                    cmd.Parameters.AddWithValue("@Telefono1", usuario.Telefono1);
                    cmd.Parameters.AddWithValue("@Telefono2", usuario.Telefono2 ?? 0);
                    cmd.Parameters.AddWithValue("@email1", usuario.email1 ?? "");
                    cmd.Parameters.AddWithValue("@email2", usuario.email2 ?? "");
                    cmd.Parameters.AddWithValue("@Direccion", usuario.Direccion ?? "");
                    cmd.Parameters.AddWithValue("@Interior", usuario.Interior ?? "");
                    cmd.Parameters.AddWithValue("@Piso", usuario.Piso ?? "");
                    cmd.Parameters.AddWithValue("@ID_Codigo_postal", usuario.ID_Codigo_postal);
                    cmd.Parameters.AddWithValue("@ID_Tratamiento", usuario.ID_Tratamiento ?? "");
                    cmd.Parameters.AddWithValue("@Otros", usuario.Otros ?? "");
                    cmd.Parameters.AddWithValue("@Usuario_Creacion", usuario.Usuario_Creacion ?? "");
                    cmd.Parameters.AddWithValue("@Fecha_Creacion", usuario.Fecha_Creacion);
                    cmd.Parameters.AddWithValue("@Usuario_Modificacion", usuario.Usuario_Modificacion ?? "");
                    cmd.Parameters.AddWithValue("@Fecha_Modificacion", usuario.Fecha_Modificacion ?? DateTime.MinValue);
                    cmd.Parameters.AddWithValue("@Usuario_Eliminacion", usuario.Usuario_Eliminacion ?? "");
                    cmd.Parameters.AddWithValue("@Fecha_Eliminacion", usuario.Fecha_Eliminacion ?? DateTime.MinValue);
                    cmd.Parameters.AddWithValue("@ID_Perfiles", usuario.ID_Perfiles ?? "");

                    cmd.Parameters.AddWithValue("@estado", usuario.estado);
                    cmd.Parameters.AddWithValue("@password", usuario.password ?? "");

                    cmd.ExecuteNonQuery();
                }
            }

            return nuevoIDUsuario;
        }
        public int ContarUsuariosActivos()
        {
            int cantidadUsuariosActivos = 0;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT COUNT(*) FROM public.\"CRM_Usuario\" WHERE \"Estado\" = 1";
                    cantidadUsuariosActivos = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return cantidadUsuariosActivos;
        }
        public DataTable ConsultarUsuarioPorEmailYContraseña(string email, string password)
        {
            DataTable resultTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT * FROM public.\"CRM_Usuario\" WHERE UPPER(\"email1\") = UPPER(@Email) AND \"Password\" = @Password AND \"Estado\" = 1";
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    adapter.Fill(resultTable);
                }
            }

            return resultTable;
        }

        public DataTable ConsultarUsuarioPorEmail(string email)
        {
            DataTable resultTable = new DataTable();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "SELECT * FROM public.\"CRM_Usuario\" WHERE UPPER(\"email1\") = UPPER(@Email)";
                        cmd.Parameters.AddWithValue("@Email", email);

                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                        adapter.Fill(resultTable);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                // Manejo específico para excepciones de Npgsql (base de datos)
                Console.WriteLine($"Error de base de datos: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Manejo de excepciones generales
                Console.WriteLine($"Error: {ex.Message}");
            }

            return resultTable;
        }

        public bool UpdateUsuario(CRM_Usuario usuario)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("UPDATE public.\"CRM_Usuario\" SET " +
                    "\"ID_Tipo_Documento\" = @ID_Tipo_Documento, \"ID_Numero_Doc\" = @ID_Numero_Doc, " +
                    "\"ID_Sexo\" = @ID_Sexo, \"Nombre\" = @Nombre, \"Apellido1\" = @Apellido1, " +
                    "\"Apellido2\" = @Apellido2, \"Telefono1\" = @Telefono1, \"Telefono2\" = @Telefono2, " +
                    "\"email1\" = @email1, \"email2\" = @email2, \"Direccion\" = @Direccion, " +
                    "\"Interior\" = @Interior, \"Piso\" = @Piso, \"ID_Codigo_postal\" = @ID_Codigo_postal, " +
                    "\"ID_Tratamiento\" = @ID_Tratamiento, \"Otros\" = @Otros, " +
                    "\"Usuario_Modificacion\" = @Usuario_Modificacion, \"Fecha_Modificacion\" = @Fecha_Modificacion, " +
                    "\"Usuario_Eliminacion\" = @Usuario_Eliminacion, \"Fecha_Eliminacion\" = @Fecha_Eliminacion, \"Estado\" = @estado , \"Password\" = @password ," +
                    "\"ID_Perfiles\" = @ID_Perfiles " +
                    "WHERE \"ID_Usuario\" = @ID_Usuario;", connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Usuario", usuario.ID_Usuario);
                    cmd.Parameters.AddWithValue("@ID_Tipo_Documento", usuario.ID_Tipo_Documento ?? "");
                    cmd.Parameters.AddWithValue("@ID_Numero_Doc", usuario.ID_Numero_Doc);
                    cmd.Parameters.AddWithValue("@ID_Sexo", usuario.ID_Sexo ?? "");
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre ?? "");
                    cmd.Parameters.AddWithValue("@Apellido1", usuario.Apellido1 ?? "");
                    cmd.Parameters.AddWithValue("@Apellido2", usuario.Apellido2 ?? "");
                    cmd.Parameters.AddWithValue("@Telefono1", usuario.Telefono1);
                    cmd.Parameters.AddWithValue("@Telefono2", usuario.Telefono2 ?? 0);
                    cmd.Parameters.AddWithValue("@email1", usuario.email1 ?? "");
                    cmd.Parameters.AddWithValue("@email2", usuario.email2 ?? "");
                    cmd.Parameters.AddWithValue("@Direccion", usuario.Direccion ?? "");
                    cmd.Parameters.AddWithValue("@Interior", usuario.Interior ?? "");
                    cmd.Parameters.AddWithValue("@Piso", usuario.Piso ?? "");
                    cmd.Parameters.AddWithValue("@ID_Codigo_postal", usuario.ID_Codigo_postal);
                    cmd.Parameters.AddWithValue("@ID_Tratamiento", usuario.ID_Tratamiento ?? "");
                    cmd.Parameters.AddWithValue("@Otros", usuario.Otros ?? "");
                    cmd.Parameters.AddWithValue("@Usuario_Modificacion", usuario.Usuario_Modificacion ?? "");
                    cmd.Parameters.AddWithValue("@Fecha_Modificacion", usuario.Fecha_Modificacion ?? DateTime.MinValue);
                    cmd.Parameters.AddWithValue("@Usuario_Eliminacion", usuario.Usuario_Eliminacion ?? "");
                    cmd.Parameters.AddWithValue("@Fecha_Eliminacion", usuario.Fecha_Eliminacion ?? DateTime.MinValue);
                    cmd.Parameters.AddWithValue("@ID_Perfiles", usuario.ID_Perfiles ?? "");

                    cmd.Parameters.AddWithValue("@estado", usuario.estado);
                    cmd.Parameters.AddWithValue("@password", usuario.password ?? "");

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }


        public void DeleteUsuario()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Usuario\" WHERE \"ID_Usuario\" = @ID_Usuario";
                    cmd.Parameters.AddWithValue("@ID_Usuario", ID_Usuario);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllUsuarios()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT \"ID_Usuario\", \"ID_Tipo_Documento\", \"ID_Numero_Doc\", \"ID_Sexo\", " +
                        "\"Nombre\" || ' ' || \"Apellido1\" || ' ' || \"Apellido2\" AS \"Nombre_Completo\", " +
                        "\"Apellido1\", \"Apellido2\", \"Telefono1\", \"Telefono2\", \"email1\", \"email2\", " +
                        "\"Direccion\", \"Interior\", \"Piso\", \"ID_Codigo_postal\", \"ID_Tratamiento\", " +
                        "\"Otros\", \"Usuario_Creacion\", \"Fecha_Creacion\", \"Usuario_Modificacion\", " +
                        "\"Fecha_Modificacion\", \"Usuario_Eliminacion\", \"Fecha_Eliminacion\", " +
                        "\"ID_Perfiles\" FROM public.\"CRM_Usuario\"", connection))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción aquí, si es necesario
                Console.WriteLine("Error al obtener usuarios: " + ex.Message);
            }

            return dataTable;
        }

        public DataTable GetAllUsuariosConTodos()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand selectCommand = new NpgsqlCommand("SELECT '0' AS ID_Usuario, 'TODOS' AS Nombre_Completo UNION ALL SELECT \"ID_Usuario\", \"Nombre\" || ' ' || \"Apellido1\" || ' ' || \"Apellido2\" AS \"Nombre_Completo\" FROM public.\"CRM_Usuario\"", connection))
                    {
                        using (NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(selectCommand))
                            npgsqlDataAdapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener usuarios: " + ex.Message);
            }
            return dataTable;
        }
        public CRM_Usuario ReadUsuario(string idUsuario)
        {
            CRM_Usuario usuario = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Usuario\" WHERE \"ID_Usuario\" = @ID_Usuario", connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Usuario", idUsuario);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new CRM_Usuario
                            {
                                ID_Usuario = reader["ID_Usuario"].ToString(),
                                ID_Tipo_Documento = reader["ID_Tipo_Documento"].ToString(),
                                ID_Numero_Doc = Convert.ToDecimal(reader["ID_Numero_Doc"]),
                                ID_Sexo = reader["ID_Sexo"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido1 = reader["Apellido1"].ToString(),
                                Apellido2 = reader["Apellido2"].ToString(),
                                Telefono1 = Convert.ToDecimal(reader["Telefono1"]),
                                Telefono2 = reader["Telefono2"] != DBNull.Value ? Convert.ToDecimal(reader["Telefono2"]) : (decimal?)null,
                                email1 = reader["email1"].ToString(),
                                email2 = reader["email2"].ToString(),
                                Direccion = reader["Direccion"].ToString(),
                                Interior = reader["Interior"].ToString(),
                                Piso = reader["Piso"].ToString(),
                                ID_Codigo_postal = Convert.ToDecimal(reader["ID_Codigo_postal"]),
                                ID_Tratamiento = reader["ID_Tratamiento"].ToString(),
                                Otros = reader["Otros"].ToString(),
                                Usuario_Creacion = reader["Usuario_Creacion"].ToString(),
                                Fecha_Creacion = Convert.ToDateTime(reader["Fecha_Creacion"]),
                                Usuario_Modificacion = reader["Usuario_Modificacion"].ToString(),
                                Fecha_Modificacion = reader["Fecha_Modificacion"] != DBNull.Value ? Convert.ToDateTime(reader["Fecha_Modificacion"]) : (DateTime?)null,
                                Usuario_Eliminacion = reader["Usuario_Eliminacion"].ToString(),
                                Fecha_Eliminacion = reader["Fecha_Eliminacion"] != DBNull.Value ? Convert.ToDateTime(reader["Fecha_Eliminacion"]) : (DateTime?)null,
                                ID_Perfiles = reader["ID_Perfiles"].ToString(),
                                estado =Convert.ToInt32( reader["estado"]),
                                password =  reader["password"].ToString()
                            };
                        }
                    }
                }
            }

            return usuario;
        }
    }
}
