using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_Tipo_PSRepository
    {
        private readonly string connectionString;

        public CRM_Tipo_PSRepository()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertTipoPS(long idTipoPS, string detalleTipoPS)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Tipo_PS\" (\"ID_Tipo_PS\", \"Detalle_Tipo_PS\") VALUES (@ID_Tipo_PS, @Detalle_Tipo_PS)";
                    cmd.Parameters.AddWithValue("@ID_Tipo_PS", idTipoPS);
                    cmd.Parameters.AddWithValue("@Detalle_Tipo_PS", detalleTipoPS);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTipoPS(long idTipoPS, string nuevoDetalleTipoPS)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"CRM_Tipo_PS\" SET \"Detalle_Tipo_PS\" = @Detalle_Tipo_PS WHERE \"ID_Tipo_PS\" = @ID_Tipo_PS";
                    cmd.Parameters.AddWithValue("@Detalle_Tipo_PS", nuevoDetalleTipoPS);
                    cmd.Parameters.AddWithValue("@ID_Tipo_PS", idTipoPS);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTipoPS(long idTipoPS)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Tipo_PS\" WHERE \"ID_Tipo_PS\" = @ID_Tipo_PS";
                    cmd.Parameters.AddWithValue("@ID_Tipo_PS", idTipoPS);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllTipoPS()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Tipo_PS\"", connection))
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