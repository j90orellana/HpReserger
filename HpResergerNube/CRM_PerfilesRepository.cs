using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_PerfilesRepository
    {
        private string connectionString;

        public CRM_PerfilesRepository()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertPerfil(string idPerfil, string detallePerfil, string otro)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Perfiles\"(\"ID_Perfiles\", \"Detalle_Perfiles\", \"Otro\") VALUES (@ID_Perfiles, @Detalle_Perfiles, @Otro)";
                    cmd.Parameters.AddWithValue("@ID_Perfiles", idPerfil);
                    cmd.Parameters.AddWithValue("@Detalle_Perfiles", detallePerfil);
                    cmd.Parameters.AddWithValue("@Otro", otro ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdatePerfil(string idPerfil, string detallePerfil, string otro)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"CRM_Perfiles\" SET \"Detalle_Perfiles\" = @Detalle_Perfiles, \"Otro\" = @Otro WHERE \"ID_Perfiles\" = @ID_Perfiles";
                    cmd.Parameters.AddWithValue("@ID_Perfiles", idPerfil);
                    cmd.Parameters.AddWithValue("@Detalle_Perfiles", detallePerfil);
                    cmd.Parameters.AddWithValue("@Otro", otro ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeletePerfil(string idPerfil)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Perfiles\" WHERE \"ID_Perfiles\" = @ID_Perfiles";
                    cmd.Parameters.AddWithValue("@ID_Perfiles", idPerfil);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllPerfiles()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Perfiles\"", connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public DataRow ReadPerfilById(string idPerfil)
        {
            DataRow perfil = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Perfiles\" WHERE \"ID_Perfiles\" = @ID_Perfiles", connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Perfiles", idPerfil);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            perfil = dataTable.Rows[0];
                        }
                    }
                }
            }

            return perfil;
        }
    }
}
