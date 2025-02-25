using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class SCH_Status
    {
        public int ID_Status { get; set; } = 0;
        public string Detalle_Status { get; set; } = "Nuevo Estado";
        public int Importar { get; set; } = 0;// Nueva columna

        private string connectionString;

        public SCH_Status()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public bool InsertStatus(SCH_Status status)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    int newId = 1; // Valor por defecto si la tabla está vacía

                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT COALESCE(MAX(\"ID_Status\"), 0) + 1 FROM public.\"SCH_Status\"", connection))
                    {
                        newId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "INSERT INTO public.\"SCH_Status\"(\"ID_Status\", \"Detalle_Status\", \"importar\") VALUES (@ID_Status, @Detalle_Status, @Importar)";
                        cmd.Parameters.AddWithValue("@ID_Status", newId);
                        cmd.Parameters.AddWithValue("@Detalle_Status", status.Detalle_Status);
                        cmd.Parameters.AddWithValue("@Importar", status.Importar);
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        public SCH_Status ReadStatus(int idStatus)
        {
            try
            {
                SCH_Status status = null;

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Status\" WHERE \"ID_Status\" = @ID_Status", connection))
                    {
                        cmd.Parameters.AddWithValue("@ID_Status", idStatus);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                status = new SCH_Status
                                {
                                    ID_Status = Convert.ToInt32(reader["ID_Status"]),
                                    Detalle_Status = reader["Detalle_Status"].ToString(),
                                    Importar = Convert.ToInt32(reader["importar"])
                                };
                            }
                        }
                    }
                }
                return status;
            }
            catch
            {
                return null;
            }
        }

        public bool UpdateStatus(SCH_Status status)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "UPDATE public.\"SCH_Status\" SET \"Detalle_Status\" = @Detalle_Status, \"importar\" = @Importar WHERE \"ID_Status\" = @ID_Status";
                        cmd.Parameters.AddWithValue("@ID_Status", status.ID_Status);
                        cmd.Parameters.AddWithValue("@Detalle_Status", status.Detalle_Status);
                        cmd.Parameters.AddWithValue("@Importar", status.Importar);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteStatus(int idStatus)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "DELETE FROM public.\"SCH_Status\" WHERE \"ID_Status\" = @ID_Status";
                        cmd.Parameters.AddWithValue("@ID_Status", idStatus);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetAllStatus()
        {
            try
            {
                DataTable dataTable = new DataTable();

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Status\"", connection))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                return dataTable;
            }
            catch
            {
                return null;
            }
        }
    }
}
