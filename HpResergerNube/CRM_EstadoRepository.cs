using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_EstadoRepository
    {
        private readonly string connectionString;

        public CRM_EstadoRepository()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertEstado(string idEstado, string detalleEstado)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Estado\" (\"ID_Estado\", \"Detalle_Estado\") VALUES (@ID_Estado, @Detalle_Estado)";
                    cmd.Parameters.AddWithValue("@ID_Estado", idEstado);
                    cmd.Parameters.AddWithValue("@Detalle_Estado", detalleEstado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateEstado(string idEstado, string detalleEstado)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"CRM_Estado\" SET \"Detalle_Estado\" = @Detalle_Estado WHERE \"ID_Estado\" = @ID_Estado";
                    cmd.Parameters.AddWithValue("@ID_Estado", idEstado);
                    cmd.Parameters.AddWithValue("@Detalle_Estado", detalleEstado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteEstado(string idEstado)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Estado\" WHERE \"ID_Estado\" = @ID_Estado";
                    cmd.Parameters.AddWithValue("@ID_Estado", idEstado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllEstados()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Estado\"", connection))
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
