using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class SCH_Nivel
    {
        public int ID_Nivel { get; set; }
        public string Detalle_Nivel { get; set; }

        private string connectionString;

        public SCH_Nivel()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertNivel(SCH_Nivel nivel)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"SCH_NIVEL\"(\"ID_NIVEL\", \"Detalle_nivel\") VALUES (@ID_NIVEL, @Detalle_nivel)";
                    cmd.Parameters.AddWithValue("@ID_NIVEL", nivel.ID_Nivel);
                    cmd.Parameters.AddWithValue("@Detalle_nivel", nivel.Detalle_Nivel);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public SCH_Nivel ReadNivel(int idNivel)
        {
            SCH_Nivel nivel = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_NIVEL\" WHERE \"ID_NIVEL\" = @ID_NIVEL", connection))
                {
                    cmd.Parameters.AddWithValue("@ID_NIVEL", idNivel);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nivel = new SCH_Nivel
                            {
                                ID_Nivel = Convert.ToInt32(reader["ID_NIVEL"]),
                                Detalle_Nivel = reader["Detalle_nivel"].ToString()
                            };
                        }
                    }
                }
            }

            return nivel;
        }

        public bool UpdateNivel(SCH_Nivel nivel)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"SCH_NIVEL\" SET \"Detalle_nivel\" = @Detalle_nivel WHERE \"ID_NIVEL\" = @ID_NIVEL";
                    cmd.Parameters.AddWithValue("@ID_NIVEL", nivel.ID_Nivel);
                    cmd.Parameters.AddWithValue("@Detalle_nivel", nivel.Detalle_Nivel);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Verificar si la actualización fue exitosa
                    success = rowsAffected > 0;
                }
            }

            return success;
        }

        public void DeleteNivel(int idNivel)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"SCH_NIVEL\" WHERE \"ID_NIVEL\" = @ID_NIVEL";
                    cmd.Parameters.AddWithValue("@ID_NIVEL", idNivel);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllNiveles()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_NIVEL\"", connection))
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
