using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class SCH_Estrate_Objetivos
    {
        public int ID { get; set; }
        public int FkIdEstrate { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        private string connectionString;

        public SCH_Estrate_Objetivos()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertEstrateObjetivo(SCH_Estrate_Objetivos objetivo)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"SCH_Estrate_Objetivos\"(\"fkid_Estrate\", \"nombre\", \"estado\", \"fechacreacion\") VALUES (@FkIdEstrate, @Nombre, @Estado, @FechaCreacion)";
                    cmd.Parameters.AddWithValue("@FkIdEstrate", objetivo.FkIdEstrate);
                    cmd.Parameters.AddWithValue("@Nombre", objetivo.Nombre);
                    cmd.Parameters.AddWithValue("@Estado", objetivo.Estado);
                    cmd.Parameters.AddWithValue("@FechaCreacion", objetivo.FechaCreacion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public SCH_Estrate_Objetivos ReadEstrateObjetivo(int id)
        {
            SCH_Estrate_Objetivos objetivo = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Estrate_Objetivos\" WHERE \"id\" = @ID", connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            objetivo = new SCH_Estrate_Objetivos
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

            return objetivo;
        }

        public bool UpdateEstrateObjetivo(SCH_Estrate_Objetivos objetivo)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"SCH_Estrate_Objetivos\" SET \"fkid_Estrate\" = @FkIdEstrate, \"nombre\" = @Nombre, \"estado\" = @Estado, \"fechacreacion\" = @FechaCreacion WHERE \"id\" = @ID";
                    cmd.Parameters.AddWithValue("@ID", objetivo.ID);
                    cmd.Parameters.AddWithValue("@FkIdEstrate", objetivo.FkIdEstrate);
                    cmd.Parameters.AddWithValue("@Nombre", objetivo.Nombre);
                    cmd.Parameters.AddWithValue("@Estado", objetivo.Estado);
                    cmd.Parameters.AddWithValue("@FechaCreacion", objetivo.FechaCreacion);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    success = rowsAffected > 0;
                }
            }

            return success;
        }
        public bool UpdateEstrateObjetivoNombre(SCH_Estrate_Objetivos objetivo)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"SCH_Estrate_Objetivos\" SET  \"nombre\" = @Nombre  WHERE \"id\" = @ID";
                    cmd.Parameters.AddWithValue("@ID", objetivo.ID);
                    cmd.Parameters.AddWithValue("@Nombre", objetivo.Nombre);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    success = rowsAffected > 0;
                }
            }

            return success;
        }
        public void DeleteEstrateObjetivo(int id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"SCH_Estrate_Objetivos\" WHERE \"id\" = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllEstrateObjetivos()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Estrate_Objetivos\"", connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public DataTable GetEstrateObjetivosByFkIdEstrate(int fkIdEstrate)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Estrate_Objetivos\" WHERE \"fkid_Estrate\" = @FkIdEstrate", connection))
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
