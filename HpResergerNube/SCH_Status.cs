using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class SCH_Status
    {
        public int ID_Status { get; set; }
        public string Detalle_Status { get; set; }

        private string connectionString;

        public SCH_Status()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertStatus(SCH_Status status)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"SCH_Status\"(\"ID_Status\", \"Detalle_Status\") VALUES (@ID_Status, @Detalle_Status)";
                    cmd.Parameters.AddWithValue("@ID_Status", status.ID_Status);
                    cmd.Parameters.AddWithValue("@Detalle_Status", status.Detalle_Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public SCH_Status ReadStatus(int idStatus)
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
                                Detalle_Status = reader["Detalle_Status"].ToString()
                            };
                        }
                    }
                }
            }

            return status;
        }

        public bool UpdateStatus(SCH_Status status)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"SCH_Status\" SET \"Detalle_Status\" = @Detalle_Status WHERE \"ID_Status\" = @ID_Status";
                    cmd.Parameters.AddWithValue("@ID_Status", status.ID_Status);
                    cmd.Parameters.AddWithValue("@Detalle_Status", status.Detalle_Status);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Verificar si la actualización fue exitosa
                    success = rowsAffected > 0;
                }
            }

            return success;
        }

        public void DeleteStatus(int idStatus)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"SCH_Status\" WHERE \"ID_Status\" = @ID_Status";
                    cmd.Parameters.AddWithValue("@ID_Status", idStatus);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllStatus()
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
    }
}
