using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class SCH_Estrate_Problemas
    {
        public int ID { get; set; }
        public int FkIdEstrate { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        private string connectionString;

        public SCH_Estrate_Problemas()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertProblema(SCH_Estrate_Problemas problema)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"SCH_Estrate_Problemas\"(\"fkid_Estrate\", \"nombre\", \"estado\", \"fechacreacion\") VALUES (@FkIdEstrate, @Nombre, @Estado, @FechaCreacion)";
                    cmd.Parameters.AddWithValue("@FkIdEstrate", problema.FkIdEstrate);
                    cmd.Parameters.AddWithValue("@Nombre", problema.Nombre);
                    cmd.Parameters.AddWithValue("@Estado", problema.Estado);
                    cmd.Parameters.AddWithValue("@FechaCreacion", problema.FechaCreacion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public SCH_Estrate_Problemas ReadProblema(int id)
        {
            SCH_Estrate_Problemas problema = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Estrate_Problemas\" WHERE \"id\" = @ID", connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            problema = new SCH_Estrate_Problemas
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                FkIdEstrate = Convert.ToInt32(reader["fkid_Estrate"]),
                                Nombre = reader["nombre"].ToString(),
                                Estado = Convert.ToInt32(reader["estado"]),
                                FechaCreacion = Convert.ToDateTime(reader["fechacreacion"])
                            };
                        }
                    }
                }
            }

            return problema;
        }

        public bool UpdateProblema(SCH_Estrate_Problemas problema)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"SCH_Estrate_Problemas\" SET \"fkid_Estrate\" = @FkIdEstrate, \"nombre\" = @Nombre, \"estado\" = @Estado, \"fechacreacion\" = @FechaCreacion WHERE \"id\" = @ID";
                    cmd.Parameters.AddWithValue("@ID", problema.ID);
                    cmd.Parameters.AddWithValue("@FkIdEstrate", problema.FkIdEstrate);
                    cmd.Parameters.AddWithValue("@Nombre", problema.Nombre);
                    cmd.Parameters.AddWithValue("@Estado", problema.Estado);
                    cmd.Parameters.AddWithValue("@FechaCreacion", problema.FechaCreacion);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    success = rowsAffected > 0;
                }
            }

            return success;
        }
        public bool UpdateProblemaNombre(SCH_Estrate_Problemas problema)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"SCH_Estrate_Problemas\" SET   \"nombre\" = @Nombre WHERE \"id\" = @ID";
                    cmd.Parameters.AddWithValue("@ID", problema.ID);
                    cmd.Parameters.AddWithValue("@Nombre", problema.Nombre);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    success = rowsAffected > 0;
                }
            }

            return success;
        }
        public void DeleteProblema(int id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"SCH_Estrate_Problemas\" WHERE \"id\" = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllProblemas()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Estrate_Problemas\"", connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public DataTable GetProblemasByFkIdEstrate(int fkIdEstrate)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Estrate_Problemas\" WHERE \"fkid_Estrate\" = @FkIdEstrate", connection))
                {
                    cmd.Parameters.AddWithValue("@FkIdEstrate", fkIdEstrate);

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
