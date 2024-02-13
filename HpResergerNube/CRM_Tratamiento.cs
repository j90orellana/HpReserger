using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_Tratamiento
    {
        public long ID_Tratamiento { get; set; }
        public long Detalle_tratamiento { get; set; }

        private string connectionString;

        public CRM_Tratamiento()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertTratamiento()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Tratamiento\"(\"ID_Tratamiento\", \"Detalle_tratamiento\") VALUES (@ID_Tratamiento, @Detalle_tratamiento)";
                    cmd.Parameters.AddWithValue("@ID_Tratamiento", ID_Tratamiento);
                    cmd.Parameters.AddWithValue("@Detalle_tratamiento", Detalle_tratamiento);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTratamiento()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"CRM_Tratamiento\" SET \"Detalle_tratamiento\" = @Detalle_tratamiento WHERE \"ID_Tratamiento\" = @ID_Tratamiento";
                    cmd.Parameters.AddWithValue("@ID_Tratamiento", ID_Tratamiento);
                    cmd.Parameters.AddWithValue("@Detalle_tratamiento", Detalle_tratamiento);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTratamiento()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Tratamiento\" WHERE \"ID_Tratamiento\" = @ID_Tratamiento";
                    cmd.Parameters.AddWithValue("@ID_Tratamiento", ID_Tratamiento);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllTratamientos()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Tratamiento\"", connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public DataRow ReadTratamientoById(long idTratamiento)
        {
            DataRow tratamiento = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Tratamiento\" WHERE \"ID_Tratamiento\" = @ID_Tratamiento", connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Tratamiento", idTratamiento);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            tratamiento = dataTable.Rows[0];
                        }
                    }
                }
            }

            return tratamiento;
        }
    }
}
