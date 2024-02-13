using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_Situacion
    {
        public string ID_Situacion { get; set; }
        public string Detalle_Situacion { get; set; }

        private string connectionString;

        public CRM_Situacion()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertSituacion()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Situacion\"(\"ID_Situacion\", \"Detalle_Situacion\") VALUES (@ID_Situacion, @Detalle_Situacion)";
                    cmd.Parameters.AddWithValue("@ID_Situacion", ID_Situacion);
                    cmd.Parameters.AddWithValue("@Detalle_Situacion", Detalle_Situacion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateSituacion()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"CRM_Situacion\" SET \"Detalle_Situacion\" = @Detalle_Situacion WHERE \"ID_Situacion\" = @ID_Situacion";
                    cmd.Parameters.AddWithValue("@ID_Situacion", ID_Situacion);
                    cmd.Parameters.AddWithValue("@Detalle_Situacion", Detalle_Situacion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteSituacion()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Situacion\" WHERE \"ID_Situacion\" = @ID_Situacion";
                    cmd.Parameters.AddWithValue("@ID_Situacion", ID_Situacion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllSituaciones()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Situacion\"", connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public DataRow ReadSituacionById(string idSituacion)
        {
            DataRow situacion = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Situacion\" WHERE \"ID_Situacion\" = @ID_Situacion", connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Situacion", idSituacion);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            situacion = dataTable.Rows[0];
                        }
                    }
                }
            }

            return situacion;
        }
    }
}
