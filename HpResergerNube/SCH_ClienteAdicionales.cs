using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class SCH_ClienteAdicionales
    {
        public int pk_id { get; set; }
        public string fk_ID_Cliente { get; set; }
        public string NombreComercial { get; set; }
        public string EspacioEnNube { get; set; }
        public string OficinaReunion { get; set; }
        public string ContactoCierre { get; set; }
        public string COORDINACION_CLIENTE1 { get; set; }
        public string COORDINACION_CLIENTE2 { get; set; }
        public string COORDINACION_CLIENTE3 { get; set; }
        public string COORDINACION_CLIENTE4 { get; set; }

        private string connectionString;

        public SCH_ClienteAdicionales()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public int InsertClienteAdicional(SCH_ClienteAdicionales clienteAdicional)
        {
            int newPkId = -1; // Valor predeterminado en caso de error

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Insertar el nuevo cliente adicional
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "INSERT INTO public.\"SCH_Cliente_Adicionales\"(" +
                            "\"fk_id_cliente\", \"Nombre Comercial\", \"Espacio en nube\", \"oficina reunion\", \"contacto cierre\", " +
                            "\"COORDINACION_CLIENTE1\", \"COORDINACION_CLIENTE2\", \"COORDINACION_CLIENTE3\", \"COORDINACION_CLIENTE4\") " +
                            "VALUES (@fk_ID_Cliente, @NombreComercial, @EspacioEnNube, @OficinaReunion, @ContactoCierre, " +
                            "@COORDINACION_CLIENTE1, @COORDINACION_CLIENTE2, @COORDINACION_CLIENTE3, @COORDINACION_CLIENTE4) RETURNING \"pk_id\"";
                        cmd.Parameters.AddWithValue("@fk_ID_Cliente", clienteAdicional.fk_ID_Cliente);
                        cmd.Parameters.AddWithValue("@NombreComercial", clienteAdicional.NombreComercial ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@EspacioEnNube", clienteAdicional.EspacioEnNube ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@OficinaReunion", clienteAdicional.OficinaReunion ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@ContactoCierre", clienteAdicional.ContactoCierre ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@COORDINACION_CLIENTE1", clienteAdicional.COORDINACION_CLIENTE1 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@COORDINACION_CLIENTE2", clienteAdicional.COORDINACION_CLIENTE2 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@COORDINACION_CLIENTE3", clienteAdicional.COORDINACION_CLIENTE3 ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@COORDINACION_CLIENTE4", clienteAdicional.COORDINACION_CLIENTE4 ?? (object)DBNull.Value);
                        newPkId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo del error (puedes loguear el error o lanzar una excepción personalizada)
                Console.WriteLine($"Error al insertar el cliente adicional: {ex.Message}");
                // Opción: lanzar una excepción personalizada
                // throw new Exception("Error al insertar el cliente adicional", ex);
            }

            return newPkId; // Retornar el nuevo pk_id generado o -1 en caso de error
        }


        public SCH_ClienteAdicionales ReadClienteAdicional(int pkId)
        {
            SCH_ClienteAdicionales clienteAdicional = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Cliente_Adicionales\" WHERE \"pk_id\" = @pk_id", connection))
                {
                    cmd.Parameters.AddWithValue("@pk_id", pkId);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            clienteAdicional = new SCH_ClienteAdicionales
                            {
                                pk_id = Convert.ToInt32(reader["pk_id"]),
                                fk_ID_Cliente = reader["fk_ID_Cliente"].ToString(),
                                NombreComercial = reader["Nombre Comercial"]?.ToString(),
                                EspacioEnNube = reader["Espacio en nube"]?.ToString(),
                                OficinaReunion = reader["oficina reunion"]?.ToString(),
                                ContactoCierre = reader["contacto cierre"]?.ToString(),
                                COORDINACION_CLIENTE1 = reader["COORDINACION_CLIENTE1"]?.ToString(),
                                COORDINACION_CLIENTE2 = reader["COORDINACION_CLIENTE2"]?.ToString(),
                                COORDINACION_CLIENTE3 = reader["COORDINACION_CLIENTE3"]?.ToString(),
                                COORDINACION_CLIENTE4 = reader["COORDINACION_CLIENTE4"]?.ToString()
                            };
                        }
                    }
                }
            }

            return clienteAdicional;
        }

        public bool UpdateClienteAdicional(SCH_ClienteAdicionales clienteAdicional)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"SCH_Cliente_Adicionales\" SET \"fk_id_cliente\" = @fk_ID_Cliente, \"Nombre Comercial\" = @NombreComercial, " +
                        "\"Espacio en nube\" = @EspacioEnNube, \"oficina reunion\" = @OficinaReunion, \"contacto cierre\" = @ContactoCierre, " +
                        "\"COORDINACION_CLIENTE1\" = @COORDINACION_CLIENTE1, \"COORDINACION_CLIENTE2\" = @COORDINACION_CLIENTE2, \"COORDINACION_CLIENTE3\" = @COORDINACION_CLIENTE3, " +
                        "\"COORDINACION_CLIENTE4\" = @COORDINACION_CLIENTE4 WHERE \"pk_id\" = @pk_id";
                    cmd.Parameters.AddWithValue("@pk_id", clienteAdicional.pk_id);
                    cmd.Parameters.AddWithValue("@fk_ID_Cliente", clienteAdicional.fk_ID_Cliente);
                    cmd.Parameters.AddWithValue("@NombreComercial", clienteAdicional.NombreComercial ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@EspacioEnNube", clienteAdicional.EspacioEnNube ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@OficinaReunion", clienteAdicional.OficinaReunion ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ContactoCierre", clienteAdicional.ContactoCierre ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@COORDINACION_CLIENTE1", clienteAdicional.COORDINACION_CLIENTE1 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@COORDINACION_CLIENTE2", clienteAdicional.COORDINACION_CLIENTE2 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@COORDINACION_CLIENTE3", clienteAdicional.COORDINACION_CLIENTE3 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@COORDINACION_CLIENTE4", clienteAdicional.COORDINACION_CLIENTE4 ?? (object)DBNull.Value);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Verificar si la actualización fue exitosa
                    success = rowsAffected > 0;
                }
            }

            return success;
        }

        public void DeleteClienteAdicional(int pkId)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"SCH_Cliente_Adicionales\" WHERE \"pk_id\" = @pk_id";
                    cmd.Parameters.AddWithValue("@pk_id", pkId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllSCH_ClienteAdicionales()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Cliente_Adicionales\"", connection))
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
