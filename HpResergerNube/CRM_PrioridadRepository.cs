using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_PrioridadRepository
    {
        private readonly string connectionString;

        public CRM_PrioridadRepository()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertPrioridad(string idPrioridad, string detallePrioridad)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Prioridad\" (\"ID_Prioridad\", \"Detalle_Prioridad\") VALUES (@ID_Prioridad, @Detalle_Prioridad)";
                    cmd.Parameters.AddWithValue("@ID_Prioridad", idPrioridad);
                    cmd.Parameters.AddWithValue("@Detalle_Prioridad", detallePrioridad);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllPrioridades()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Prioridad\"", connection))
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
