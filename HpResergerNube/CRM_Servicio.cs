using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_Servicio
    {
        public long ID_Servicio { get; set; }
        public long Detalle_Servicio { get; set; }
        public long Detalle_1 { get; set; }
        public long? Detalle_2 { get; set; }
        public long? Detalle_3 { get; set; }
        public long? Detalle_4 { get; set; }
        public long? Detalle_5 { get; set; }
        public long? Detalle_6 { get; set; }
        public long? Detalle_7 { get; set; }
        public long? Detalle_8 { get; set; }

        private string connectionString;

        public CRM_Servicio()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertServicio()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Servicio\"(\"ID_Servicio\", \"Detalle_Servicio\", \"Detalle_1\", \"Detalle_2\", \"Detalle_3\", \"Detalle_4\", \"Detalle_5\", \"Detalle_6\", \"Detalle_7\", \"Detalle_8\") " +
                        "VALUES (@ID_Servicio, @Detalle_Servicio, @Detalle_1, @Detalle_2, @Detalle_3, @Detalle_4, @Detalle_5, @Detalle_6, @Detalle_7, @Detalle_8)";
                    cmd.Parameters.AddWithValue("@ID_Servicio", ID_Servicio);
                    cmd.Parameters.AddWithValue("@Detalle_Servicio", Detalle_Servicio);
                    cmd.Parameters.AddWithValue("@Detalle_1", Detalle_1);
                    cmd.Parameters.AddWithValue("@Detalle_2", Detalle_2 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_3", Detalle_3 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_4", Detalle_4 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_5", Detalle_5 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_6", Detalle_6 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_7", Detalle_7 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_8", Detalle_8 ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateServicio()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"CRM_Servicio\" SET \"Detalle_Servicio\" = @Detalle_Servicio, \"Detalle_1\" = @Detalle_1, \"Detalle_2\" = @Detalle_2, " +
                        "\"Detalle_3\" = @Detalle_3, \"Detalle_4\" = @Detalle_4, \"Detalle_5\" = @Detalle_5, \"Detalle_6\" = @Detalle_6, \"Detalle_7\" = @Detalle_7, " +
                        "\"Detalle_8\" = @Detalle_8 WHERE \"ID_Servicio\" = @ID_Servicio";
                    cmd.Parameters.AddWithValue("@ID_Servicio", ID_Servicio);
                    cmd.Parameters.AddWithValue("@Detalle_Servicio", Detalle_Servicio);
                    cmd.Parameters.AddWithValue("@Detalle_1", Detalle_1);
                    cmd.Parameters.AddWithValue("@Detalle_2", Detalle_2 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_3", Detalle_3 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_4", Detalle_4 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_5", Detalle_5 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_6", Detalle_6 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_7", Detalle_7 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_8", Detalle_8 ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteServicio()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Servicio\" WHERE \"ID_Servicio\" = @ID_Servicio";
                    cmd.Parameters.AddWithValue("@ID_Servicio", ID_Servicio);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllServicios()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Servicio\"", connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public DataRow ReadServicioById(long idServicio)
        {
            DataRow servicio = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Servicio\" WHERE \"ID_Servicio\" = @ID_Servicio", connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Servicio", idServicio);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            servicio = dataTable.Rows[0];
                        }
                    }
                }
            }

            return servicio;
        }
    }
}
