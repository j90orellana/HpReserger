using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class SCH_Estrate_Estrategia
    {
        public int ID { get; set; }
        public int FkIdEstrate { get; set; }
        public string Nombre { get; set; }
        public int Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        private string connectionString;

        public SCH_Estrate_Estrategia()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertEstrateEstrategia(SCH_Estrate_Estrategia estrategia)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"SCH_Estrate_Estrategia\"(\"fkid_Estrate\", \"nombre\", \"estado\", \"fechacreacion\") VALUES (@FkIdEstrate, @Nombre, @Estado, @FechaCreacion)";
                    cmd.Parameters.AddWithValue("@FkIdEstrate", estrategia.FkIdEstrate);
                    cmd.Parameters.AddWithValue("@Nombre", estrategia.Nombre);
                    cmd.Parameters.AddWithValue("@Estado", estrategia.Estado);
                    cmd.Parameters.AddWithValue("@FechaCreacion", estrategia.FechaCreacion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public SCH_Estrate_Estrategia ReadEstrateEstrategia(int id)
        {
            SCH_Estrate_Estrategia estrategia = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Estrate_Estrategia\" WHERE \"id\" = @ID", connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            estrategia = new SCH_Estrate_Estrategia
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

            return estrategia;
        }

        public bool UpdateEstrateEstrategia(SCH_Estrate_Estrategia estrategia)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"SCH_Estrate_Estrategia\" SET \"fkid_Estrate\" = @FkIdEstrate, \"nombre\" = @Nombre, \"estado\" = @Estado, \"fechacreacion\" = @FechaCreacion WHERE \"id\" = @ID";
                    cmd.Parameters.AddWithValue("@ID", estrategia.ID);
                    cmd.Parameters.AddWithValue("@FkIdEstrate", estrategia.FkIdEstrate);
                    cmd.Parameters.AddWithValue("@Nombre", estrategia.Nombre);
                    cmd.Parameters.AddWithValue("@Estado", estrategia.Estado);
                    cmd.Parameters.AddWithValue("@FechaCreacion", estrategia.FechaCreacion);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    success = rowsAffected > 0;
                }
            }

            return success;
        }
        public bool UpdateEstrateEstrategiaNombre(SCH_Estrate_Estrategia estrategia)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"SCH_Estrate_Estrategia\" SET \"nombre\" = @Nombre WHERE \"id\" = @ID";
                    cmd.Parameters.AddWithValue("@ID", estrategia.ID);
                    //cmd.Parameters.AddWithValue("@FkIdEstrate", estrategia.FkIdEstrate);
                    cmd.Parameters.AddWithValue("@Nombre", estrategia.Nombre);
                    //cmd.Parameters.AddWithValue("@Estado", estrategia.Estado);
                    //cmd.Parameters.AddWithValue("@FechaCreacion", estrategia.FechaCreacion);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    success = rowsAffected > 0;
                }
            }

            return success;
        }

        public void DeleteEstrateEstrategia(int id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"SCH_Estrate_Estrategia\" WHERE \"id\" = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllEstrateEstrategias()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Estrate_Estrategia\"", connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public DataTable GetEstrateEstrategiasByFkIdEstrate(int fkIdEstrate)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Estrate_Estrategia\" WHERE \"fkid_Estrate\" = @FkIdEstrate", connection))
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
