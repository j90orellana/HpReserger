using System;
using System.Data;
using Npgsql;
namespace HpResergerNube
{

    public class CRM_ClienteRepository
    {
        private readonly string connectionString;

        public CRM_ClienteRepository()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        // Método InsertCliente modificado
        public bool InsertCliente(CRM_Cliente cliente)
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
                        cmd.CommandText = "INSERT INTO public.\"CRM_Cliente\" (\"ID_Cliente\", \"ID_Tipo_persona\", \"Nombre\", \"Apellido1\", \"Apellido2\", \"Razon_Social\", \"ID_TIpo_Documento\", \"ID_Numero_Doc\", \"Direccion\", \"Interior\", \"Piso\", \"ID_Codigo_postal\", \"Telefono1\", \"Telefono2\", \"email1\", \"email2\", \"web\", \"ID_Contacto\", \"Usuario_Creacion\", \"Fecha_Creacion\", \"Usuario_Modificacion\", \"Fecha_Modificacion\", \"Usuario_Eliminacion\", \"Fecha_Eliminacion\") VALUES (@ID_Cliente, @ID_Tipo_persona, @Nombre, @Apellido1, @Apellido2, @Razon_Social, @ID_TIpo_Documento, @ID_Numero_Doc, @Direccion, @Interior, @Piso, @ID_Codigo_postal, @Telefono1, @Telefono2, @email1, @email2, @web, @ID_Contacto, @Usuario_Creacion, @Fecha_Creacion, @Usuario_Modificacion, @Fecha_Modificacion, @Usuario_Eliminacion, @Fecha_Eliminacion)";

                        // Set parameters (exclude ID_Relacion)
                        cmd.Parameters.AddWithValue("@ID_Cliente", cliente.ID_Cliente);
                        cmd.Parameters.AddWithValue("@ID_Tipo_persona", cliente.ID_Tipo_persona);
                        cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido1", cliente.Apellido1);
                        cmd.Parameters.AddWithValue("@Apellido2", cliente.Apellido2);
                        cmd.Parameters.AddWithValue("@Razon_Social", cliente.Razon_Social);
                        cmd.Parameters.AddWithValue("@ID_TIpo_Documento", cliente.ID_TIpo_Documento);
                        cmd.Parameters.AddWithValue("@ID_Numero_Doc", cliente.ID_Numero_Doc);
                        cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                        cmd.Parameters.AddWithValue("@Interior", cliente.Interior);
                        cmd.Parameters.AddWithValue("@Piso", cliente.Piso);
                        cmd.Parameters.AddWithValue("@ID_Codigo_postal", cliente.ID_Codigo_postal);
                        cmd.Parameters.AddWithValue("@Telefono1", cliente.Telefono1);
                        cmd.Parameters.AddWithValue("@Telefono2", cliente.Telefono2);
                        cmd.Parameters.AddWithValue("@email1", cliente.email1);
                        cmd.Parameters.AddWithValue("@email2", cliente.email2);
                        cmd.Parameters.AddWithValue("@web", cliente.web);
                        cmd.Parameters.AddWithValue("@ID_Contacto", cliente.ID_Contacto);
                        cmd.Parameters.AddWithValue("@Usuario_Creacion", cliente.Usuario_Creacion);
                        cmd.Parameters.AddWithValue("@Fecha_Creacion", cliente.Fecha_Creacion);
                        cmd.Parameters.AddWithValue("@Usuario_Modificacion", cliente.Usuario_Modificacion);
                        cmd.Parameters.AddWithValue("@Fecha_Modificacion", cliente.Fecha_Modificacion);
                        cmd.Parameters.AddWithValue("@Usuario_Eliminacion", cliente.Usuario_Eliminacion);
                        cmd.Parameters.AddWithValue("@Fecha_Eliminacion", cliente.Fecha_Eliminacion);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        // If at least one row was affected, consider it a success
                        success = rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions here, if needed
                return false;
            }

            return success;
        }

        // Método UpdateCliente modificado
        public bool UpdateCliente(CRM_Cliente cliente)
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
                        cmd.CommandText = "UPDATE public.\"CRM_Cliente\" SET \"ID_Tipo_persona\" = @ID_Tipo_persona, \"Nombre\" = @Nombre, \"Apellido1\" = @Apellido1, \"Apellido2\" = @Apellido2, \"Razon_Social\" = @Razon_Social, \"ID_TIpo_Documento\" = @ID_TIpo_Documento, \"ID_Numero_Doc\" = @ID_Numero_Doc, \"Direccion\" = @Direccion, \"Interior\" = @Interior, \"Piso\" = @Piso, \"ID_Codigo_postal\" = @ID_Codigo_postal, \"Telefono1\" = @Telefono1, \"Telefono2\" = @Telefono2, \"email1\" = @email1, \"email2\" = @email2, \"web\" = @web, \"ID_Contacto\" = @ID_Contacto, \"Usuario_Modificacion\" = @Usuario_Modificacion, \"Fecha_Modificacion\" = @Fecha_Modificacion WHERE \"ID_Cliente\" = @ID_Cliente";

                        // Set parameters (exclude ID_Relacion)
                        cmd.Parameters.AddWithValue("@ID_Cliente", cliente.ID_Cliente);
                        cmd.Parameters.AddWithValue("@ID_Tipo_persona", cliente.ID_Tipo_persona);
                        cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido1", cliente.Apellido1);
                        cmd.Parameters.AddWithValue("@Apellido2", cliente.Apellido2);
                        cmd.Parameters.AddWithValue("@Razon_Social", cliente.Razon_Social);
                        cmd.Parameters.AddWithValue("@ID_TIpo_Documento", cliente.ID_TIpo_Documento);
                        cmd.Parameters.AddWithValue("@ID_Numero_Doc", cliente.ID_Numero_Doc);
                        cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                        cmd.Parameters.AddWithValue("@Interior", cliente.Interior);
                        cmd.Parameters.AddWithValue("@Piso", cliente.Piso);
                        cmd.Parameters.AddWithValue("@ID_Codigo_postal", cliente.ID_Codigo_postal);
                        cmd.Parameters.AddWithValue("@Telefono1", cliente.Telefono1);
                        cmd.Parameters.AddWithValue("@Telefono2", cliente.Telefono2);
                        cmd.Parameters.AddWithValue("@email1", cliente.email1);
                        cmd.Parameters.AddWithValue("@email2", cliente.email2);
                        cmd.Parameters.AddWithValue("@web", cliente.web);
                        cmd.Parameters.AddWithValue("@ID_Contacto", cliente.ID_Contacto);
                        cmd.Parameters.AddWithValue("@Usuario_Modificacion", cliente.Usuario_Modificacion);
                        cmd.Parameters.AddWithValue("@Fecha_Modificacion", cliente.Fecha_Modificacion);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        // If at least one row was affected, consider it a success
                        success = rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return success;
        }


        public void DeleteCliente(string clienteID)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Cliente\" WHERE \"ID_Cliente\" = @ID_Cliente";

                    // Set parameter
                    cmd.Parameters.AddWithValue("@ID_Cliente", clienteID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public CRM_Cliente SelectCliente(string clienteID)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM public.\"CRM_Cliente\" WHERE \"ID_Cliente\" = @ID_Cliente";

                    // Set parameter
                    cmd.Parameters.AddWithValue("@ID_Cliente", clienteID);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapClienteFromDataReader(reader);
                        }
                    }
                }

                return null;
            }
        }
        public DataTable FilterClientesByDateRange(DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT *, CASE WHEN \"ID_Tipo_persona\" = 'J' THEN \"Razon_Social\" ELSE CONCAT(\"Nombre\", ' ', COALESCE(\"Apellido1\", ''), ' ', COALESCE(\"Apellido2\", '')) END AS nombrecompleto FROM public.\"CRM_Cliente\" WHERE \"Fecha_Creacion\" >= @StartDate AND \"Fecha_Creacion\" <= @EndDate ORDER BY COALESCE(\"Fecha_Modificacion\", \"Fecha_Creacion\") DESC";

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


        private CRM_Cliente MapClienteFromDataReader(IDataReader reader)
        {
            return new CRM_Cliente
            {
                ID_Cliente = reader["ID_Cliente"].ToString(),
                ID_Tipo_persona = reader["ID_Tipo_persona"].ToString(),
                Nombre = reader["Nombre"].ToString(),
                Apellido1 = reader["Apellido1"].ToString(),
                Apellido2 = reader["Apellido2"].ToString(),
                Razon_Social = reader["Razon_Social"].ToString(),
                ID_TIpo_Documento = reader["ID_TIpo_Documento"].ToString(),
                ID_Numero_Doc = Convert.ToDecimal(reader["ID_Numero_Doc"]),
                Direccion = reader["Direccion"].ToString(),
                Interior = reader["Interior"].ToString(),
                Piso = reader["Piso"].ToString(),
                ID_Codigo_postal = Convert.ToDecimal(reader["ID_Codigo_postal"]),
                Telefono1 = Convert.ToDecimal(reader["Telefono1"]),
                Telefono2 = reader["Telefono2"] != DBNull.Value ? Convert.ToDecimal(reader["Telefono2"]) : (decimal?)null,
                email1 = reader["email1"].ToString(),
                email2 = reader["email2"].ToString(),
                web = reader["web"].ToString(),
                ID_Contacto = reader["ID_Contacto"].ToString(),
                Usuario_Creacion = reader["Usuario_Creacion"].ToString(),
                Fecha_Creacion = Convert.ToDateTime(reader["Fecha_Creacion"]),
                Usuario_Modificacion = reader["Usuario_Modificacion"] != DBNull.Value ? reader["Usuario_Modificacion"].ToString() : null,
                Fecha_Modificacion = reader["Fecha_Modificacion"] != DBNull.Value ? Convert.ToDateTime(reader["Fecha_Modificacion"]) : (DateTime?)null,
                Usuario_Eliminacion = reader["Usuario_Eliminacion"] != DBNull.Value ? reader["Usuario_Eliminacion"].ToString() : null,
                Fecha_Eliminacion = reader["Fecha_Eliminacion"] != DBNull.Value ? Convert.ToDateTime(reader["Fecha_Eliminacion"]) : (DateTime?)null
            };
        }
    }

    public class CRM_Cliente
    {
        public string ID_Cliente { get; set; }
        public string ID_Tipo_persona { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Razon_Social { get; set; }
        public string ID_TIpo_Documento { get; set; }
        public decimal ID_Numero_Doc { get; set; }
        public string Direccion { get; set; }
        public string Interior { get; set; }
        public string Piso { get; set; }
        public decimal ID_Codigo_postal { get; set; }
        public decimal Telefono1 { get; set; }
        public decimal? Telefono2 { get; set; }
        public string email1 { get; set; }
        public string email2 { get; set; }
        public string web { get; set; }
        public string ID_Contacto { get; set; }
        public string Usuario_Creacion { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public string Usuario_Modificacion { get; set; }
        public DateTime? Fecha_Modificacion { get; set; }
        public string Usuario_Eliminacion { get; set; }
        public DateTime? Fecha_Eliminacion { get; set; }
    }
}