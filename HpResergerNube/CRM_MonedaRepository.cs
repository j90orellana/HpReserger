using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_MonedaRepository
    {
        private readonly string connectionString;

        public CRM_MonedaRepository()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertMoneda(long idMoneda, long detalleMoneda)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Moneda\" (\"ID_Moneda\", \"Detalle_Moneda\") VALUES (@ID_Moneda, @Detalle_Moneda)";
                    cmd.Parameters.AddWithValue("@ID_Moneda", idMoneda);
                    cmd.Parameters.AddWithValue("@Detalle_Moneda", detalleMoneda);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllMonedas()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Moneda\"", connection))
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
