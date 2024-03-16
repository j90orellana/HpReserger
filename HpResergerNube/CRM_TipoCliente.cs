using HpResergerNube;
using Npgsql;
using System;
using System.Data;
namespace HpResergerNube
{
    public class CRM_Tipo_Cliente
    {
        private string connectionString;

        public CRM_Tipo_Cliente()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public DataTable GetAll()
        {
            DataTable resultTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT \"ID_Tipo_Cliente\", \"Detalle_Tipo_Cliente\", \"Usuario_Creación\", \"Fecha\" FROM public.\"CRM_Tipo_Cliente\"";

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    adapter.Fill(resultTable);
                }
            }

            return resultTable;
        }

        public string Insert(string detalleTipoCliente, string usuarioCreacion)
        {
            string nuevoIDTipoCliente = "";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;

                    // Obtener el nuevo ID
                    cmd.CommandText = "SELECT 'TC' || (COALESCE(MAX(CAST(SUBSTRING(\"ID_Tipo_Cliente\", 3) AS INTEGER)), 0) + 1) FROM public.\"CRM_Tipo_Cliente\"";
                    nuevoIDTipoCliente = (string)cmd.ExecuteScalar();

                    // Insertar el nuevo registro
                    cmd.CommandText = "INSERT INTO public.\"CRM_Tipo_Cliente\"(\"ID_Tipo_Cliente\", \"Detalle_Tipo_Cliente\", \"Usuario_Creación\", \"Fecha\") " +
                                      "VALUES (@IDTipoCliente, @DetalleTipoCliente, @UsuarioCreacion, @Fecha)";
                    cmd.Parameters.AddWithValue("@IDTipoCliente", nuevoIDTipoCliente);
                    cmd.Parameters.AddWithValue("@DetalleTipoCliente", detalleTipoCliente);
                    cmd.Parameters.AddWithValue("@UsuarioCreacion", usuarioCreacion);
                    cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }

            return nuevoIDTipoCliente;
        }

        public bool Update(string idTipoCliente, string detalleTipoCliente, string usuarioCreacion)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;

                    cmd.CommandText = "UPDATE public.\"CRM_Tipo_Cliente\" " +
                                      "SET \"Detalle_Tipo_Cliente\" = @DetalleTipoCliente, " +
                                      "\"Usuario_Creación\" = @UsuarioCreacion, " +
                                      "\"Fecha\" = @Fecha " +
                                      "WHERE \"ID_Tipo_Cliente\" = @IDTipoCliente";
                    cmd.Parameters.AddWithValue("@DetalleTipoCliente", detalleTipoCliente);
                    cmd.Parameters.AddWithValue("@UsuarioCreacion", usuarioCreacion);
                    cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@IDTipoCliente", idTipoCliente);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public bool Delete(string idTipoCliente)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;

                    cmd.CommandText = "DELETE FROM public.\"CRM_Tipo_Cliente\" WHERE \"ID_Tipo_Cliente\" = @IDTipoCliente";
                    cmd.Parameters.AddWithValue("@IDTipoCliente", idTipoCliente);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public CRM_Tipo_Cliente GetById(string idTipoCliente)
        {
            CRM_Tipo_Cliente tipoCliente = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT \"ID_Tipo_Cliente\", \"Detalle_Tipo_Cliente\", \"Usuario_Creación\", \"Fecha\" " +
                                      "FROM public.\"CRM_Tipo_Cliente\" WHERE \"ID_Tipo_Cliente\" = @IDTipoCliente";
                    cmd.Parameters.AddWithValue("@IDTipoCliente", idTipoCliente);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tipoCliente = new CRM_Tipo_Cliente()
                            {
                                ID_Tipo_Cliente = reader.GetString(0),
                                Detalle_Tipo_Cliente = reader.GetString(1),
                                Usuario_Creación = reader.GetString(2),
                                Fecha = reader.GetDateTime(3)
                            };
                        }
                    }
                }
            }

            return tipoCliente;
        }

        // Propiedades de la clase CRM_Tipo_Cliente
        public string ID_Tipo_Cliente { get; set; }
        public string Detalle_Tipo_Cliente { get; set; }
        public string Usuario_Creación { get; set; }
        public DateTime Fecha { get; set; }
    }
}