using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_Sexo
    {
        public long ID_Sexo { get; set; }
        public long Detalle_FM { get; set; }

        private string connectionString;

        public CRM_Sexo()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertSexo()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Sexo\"(\"ID_Sexo\", \"Detalle_FM\") VALUES (@ID_Sexo, @Detalle_FM)";
                    cmd.Parameters.AddWithValue("@ID_Sexo", ID_Sexo);
                    cmd.Parameters.AddWithValue("@Detalle_FM", Detalle_FM);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateSexo()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"CRM_Sexo\" SET \"Detalle_FM\" = @Detalle_FM WHERE \"ID_Sexo\" = @ID_Sexo";
                    cmd.Parameters.AddWithValue("@ID_Sexo", ID_Sexo);
                    cmd.Parameters.AddWithValue("@Detalle_FM", Detalle_FM);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteSexo()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Sexo\" WHERE \"ID_Sexo\" = @ID_Sexo";
                    cmd.Parameters.AddWithValue("@ID_Sexo", ID_Sexo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllSexos()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Sexo\"", connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public DataRow ReadSexoById(long idSexo)
        {
            DataRow sexo = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Sexo\" WHERE \"ID_Sexo\" = @ID_Sexo", connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Sexo", idSexo);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            sexo = dataTable.Rows[0];
                        }
                    }
                }
            }

            return sexo;
        }
    }
}
