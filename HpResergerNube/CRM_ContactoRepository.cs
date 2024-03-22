using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_ContactoRepository
    {
        private readonly string connectionString;

        public CRM_ContactoRepository()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }
        public class Contacto
        {
            public string ID_Contacto { get; set; }
            public string ID_Cliente { get; set; }
            public string ID_Tratamiento { get; set; }
            public string Nombre { get; set; }
            public string Apellido1 { get; set; }
            public string Apellido2 { get; set; }
            public string Cargo { get; set; }
            public decimal Telefono1 { get; set; }
            public decimal? Telefono2 { get; set; }
            public string Email1 { get; set; }
            public string Email2 { get; set; }
            public string Otros { get; set; }
            public string ID_Sexo { get; set; }
            public string ID_Usuario { get; set; }
            public string Usuario_Creacion { get; set; }
            public DateTime Fecha_Creacion { get; set; }
            public string Usuario_Modificacion { get; set; }
            public DateTime? Fecha_Modificacion { get; set; }
        }

        public string InsertContacto(Contacto contacto)
        {
            string newIDContacto = "";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Obtener el último ID_Contacto de la base de datos
                string queryLastID = "SELECT MAX(\"ID_Contacto\") FROM public.\"CRM_Contacto\"";
                using (NpgsqlCommand cmdLastID = new NpgsqlCommand(queryLastID, connection))
                {
                    object lastID = cmdLastID.ExecuteScalar();
                    int lastIDNumber = 0;
                    if (lastID != DBNull.Value)
                    {
                        string lastIDString = lastID.ToString().Substring(1); // Ignorar el primer carácter "C"
                        if (int.TryParse(lastIDString, out lastIDNumber))
                        {
                            lastIDNumber++; // Incrementar el último ID
                        }
                    }
                    else
                    {
                        lastIDNumber = 1; // Si no hay registros, comenzar desde 1
                    }

                    // Formar el nuevo ID_Contacto
                    newIDContacto = "C" + lastIDNumber.ToString("D4");
                }

                // Insertar el nuevo contacto con el nuevo ID_Contacto
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Contacto\" (\"ID_Contacto\", \"ID_Tratamiento\", \"Nombre\", \"Apellido1\", \"Apellido2\", \"Cargo\", \"Telefono1\", \"Telefono2\", \"email1\", \"email2\", \"Otros\", \"ID_Sexo\", \"ID_Usuario\", \"Usuario_Creacion\", \"Fecha_Creacion\",\"ID_Cliente\") VALUES (@ID_Contacto, @ID_Tratamiento, @Nombre, @Apellido1, @Apellido2, @Cargo, @Telefono1, @Telefono2, @email1, @email2, @Otros, @ID_Sexo, @ID_Usuario, @Usuario_Creacion, @Fecha_Creacion,@ID_Cliente)";
                    cmd.Parameters.AddWithValue("@ID_Contacto", newIDContacto);
                    cmd.Parameters.AddWithValue("@ID_Tratamiento", contacto.ID_Tratamiento);
                    cmd.Parameters.AddWithValue("@Nombre", contacto.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido1", contacto.Apellido1);
                    cmd.Parameters.AddWithValue("@Apellido2", contacto.Apellido2);
                    cmd.Parameters.AddWithValue("@Cargo", contacto.Cargo);
                    cmd.Parameters.AddWithValue("@Telefono1", contacto.Telefono1);
                    cmd.Parameters.AddWithValue("@Telefono2", contacto.Telefono2 != null ? contacto.Telefono2 : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@email1", contacto.Email1);
                    cmd.Parameters.AddWithValue("@email2", contacto.Email2 != null ? contacto.Email2 : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Otros", contacto.Otros != null ? contacto.Otros : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Sexo", contacto.ID_Sexo != null ? contacto.ID_Sexo : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Usuario", contacto.ID_Usuario);
                    cmd.Parameters.AddWithValue("@Usuario_Creacion", contacto.Usuario_Creacion);
                    cmd.Parameters.AddWithValue("@Fecha_Creacion", contacto.Fecha_Creacion);
                    cmd.Parameters.AddWithValue("@ID_Cliente", contacto.ID_Cliente);
                    cmd.ExecuteNonQuery();
                }
            }

            return newIDContacto; // Retornar el nuevo ID_Contacto generado
        }
        public DataTable GetContactosPorCliente(string idCliente)
        {
            DataTable contactosDataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Consulta SQL para seleccionar los contactos de un cliente específico
                string query = @"SELECT C.*, (C.""Nombre"" || ' ' || C.""Apellido1"" || ' ' || C.""Apellido2"") AS ""NombreCompleto""  FROM public.""CRM_Contacto"" C 
                        LEFT JOIN public.""CRM_Cliente"" CLI ON CLI.""ID_Contacto"" = C.""ID_Contacto"" 
                        WHERE CLI.""ID_Cliente"" = @ID_Cliente
                        union all
                        SELECT C.*, (C.""Nombre"" || ' ' || C.""Apellido1"" || ' ' || C.""Apellido2"") AS ""NombreCompleto""  FROM public.""CRM_Contacto"" C

                                                WHERE C.""ID_Cliente"" = @ID_Cliente";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Cliente", idCliente);

                    // Utilizar un NpgsqlDataAdapter para llenar el DataTable
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(contactosDataTable);
                    }
                }
            }

            return contactosDataTable;
        }


        public bool UpdateContacto(Contacto contacto)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"CRM_Contacto\" SET \"ID_Cliente\" = @ID_Cliente, \"ID_Tratamiento\" = @ID_Tratamiento, \"Nombre\" = @Nombre, \"Apellido1\" = @Apellido1, \"Apellido2\" = @Apellido2, \"Cargo\" = @Cargo, \"Telefono1\" = @Telefono1, \"Telefono2\" = @Telefono2, \"email1\" = @email1, \"email2\" = @email2, \"Otros\" = @Otros, \"ID_Sexo\" = @ID_Sexo, \"ID_Usuario\" = @ID_Usuario, \"Usuario_Modificacion\" = @Usuario_Modificacion, \"Fecha_Modificacion\" = @Fecha_Modificacion WHERE \"ID_Contacto\" = @ID_Contacto";
                    cmd.Parameters.AddWithValue("@ID_Contacto", contacto.ID_Contacto);
                    cmd.Parameters.AddWithValue("@ID_Tratamiento", contacto.ID_Tratamiento);
                    cmd.Parameters.AddWithValue("@Nombre", contacto.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido1", contacto.Apellido1);
                    cmd.Parameters.AddWithValue("@Apellido2", contacto.Apellido2);
                    cmd.Parameters.AddWithValue("@Cargo", contacto.Cargo);
                    cmd.Parameters.AddWithValue("@Telefono1", contacto.Telefono1);
                    cmd.Parameters.AddWithValue("@Telefono2", contacto.Telefono2 != null ? (object)contacto.Telefono2 : DBNull.Value);
                    cmd.Parameters.AddWithValue("@email1", contacto.Email1);
                    cmd.Parameters.AddWithValue("@email2", contacto.Email2 != null ? (object)contacto.Email2 : DBNull.Value);
                    cmd.Parameters.AddWithValue("@Otros", contacto.Otros != null ? (object)contacto.Otros : DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Sexo", contacto.ID_Sexo != null ? (object)contacto.ID_Sexo : DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Usuario", contacto.ID_Usuario);
                    cmd.Parameters.AddWithValue("@ID_Cliente", contacto.ID_Cliente);
                    cmd.Parameters.AddWithValue("@Usuario_Modificacion", contacto.Usuario_Modificacion);
                    cmd.Parameters.AddWithValue("@Fecha_Modificacion", contacto.Fecha_Modificacion.HasValue ? (object)contacto.Fecha_Modificacion : DBNull.Value);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Verificar si se ha actualizado al menos una fila
                    success = rowsAffected > 0;
                }
            }

            return success; // Retornar true si fue exitoso, false en caso contrario
        }


        public void DeleteContacto(string idContacto)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Contacto\" WHERE \"ID_Contacto\" = @ID_Contacto";
                    cmd.Parameters.AddWithValue("@ID_Contacto", idContacto);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable FilterClientesByDateRange(DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT \"ID_Contacto\", \"ID_Tratamiento\", \"Nombre\", \"Apellido1\", \"Apellido2\", \"Cargo\", \"Telefono1\", \"Telefono2\", \"email1\", \"email2\", \"Otros\", \"ID_Sexo\", \"ID_Usuario\", \"Usuario_Creacion\", \"Fecha_Creacion\", CONCAT(\"Nombre\", ' ', \"Apellido1\", ' ', \"Apellido2\") AS \"NombreCompleto\" " +
                              "FROM public.\"CRM_Contacto\" " +
                              "WHERE \"Fecha_Creacion\" >= @StartDate AND \"Fecha_Creacion\" <= @EndDate " +
                              "ORDER BY COALESCE(\"Fecha_Modificacion\", \"Fecha_Creacion\") DESC";

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
        public Contacto ReadContacto(string idContacto)
        {
            Contacto contacto = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Contacto\" WHERE \"ID_Contacto\" = @ID_Contacto", connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Contacto", idContacto);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            contacto = new Contacto
                            {
                                ID_Contacto = reader["ID_Contacto"].ToString(),
                                ID_Tratamiento = reader["ID_Tratamiento"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido1 = reader["Apellido1"].ToString(),
                                Apellido2 = reader["Apellido2"].ToString(),
                                Cargo = reader["Cargo"].ToString(),
                                Telefono1 = Convert.ToDecimal(reader["Telefono1"]),
                                Telefono2 = reader["Telefono2"] != DBNull.Value ? Convert.ToDecimal(reader["Telefono2"]) : (decimal?)null,
                                Email1 = reader["email1"].ToString(),
                                Email2 = reader["email2"].ToString(),
                                Otros = reader["Otros"].ToString(),
                                ID_Sexo = reader["ID_Sexo"].ToString(),
                                ID_Usuario = reader["ID_Usuario"].ToString(),
                                Usuario_Creacion = reader["Usuario_Creacion"].ToString(),
                                Fecha_Creacion = Convert.ToDateTime(reader["Fecha_Creacion"]),
                                ID_Cliente = reader["ID_Cliente"].ToString()
                            };
                        }
                    }
                }
            }

            return contacto;
        }

        public DataTable GetAllContactos()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT *, (\"Nombre\" || ' ' || \"Apellido1\" || ' ' || \"Apellido2\") AS \"NombreCompleto\" FROM public.\"CRM_Contacto\"";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
    }
}
