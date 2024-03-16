using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
namespace HpResergerNube
{


    public class CRM_Tipo_SeguimientoRepository
    {
        private readonly string connectionString;

        public CRM_Tipo_SeguimientoRepository()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertTipoSeguimiento(string idTipoSeguimiento, string detalleTipoSeguimiento)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Tipo_seguimiento\" (\"ID_Tipo_seguimiento\", \"Detalle_Tipo_seguimiento\") VALUES (@ID_Tipo_seguimiento, @Detalle_Tipo_seguimiento)";
                    cmd.Parameters.AddWithValue("@ID_Tipo_seguimiento", idTipoSeguimiento);
                    cmd.Parameters.AddWithValue("@Detalle_Tipo_seguimiento", detalleTipoSeguimiento);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTipoSeguimiento(string idTipoSeguimiento, string nuevoDetalleTipoSeguimiento)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"CRM_Tipo_seguimiento\" SET \"Detalle_Tipo_seguimiento\" = @Detalle_Tipo_seguimiento WHERE \"ID_Tipo_seguimiento\" = @ID_Tipo_seguimiento";
                    cmd.Parameters.AddWithValue("@Detalle_Tipo_seguimiento", nuevoDetalleTipoSeguimiento);
                    cmd.Parameters.AddWithValue("@ID_Tipo_seguimiento", idTipoSeguimiento);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTipoSeguimiento(string idTipoSeguimiento)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Tipo_seguimiento\" WHERE \"ID_Tipo_seguimiento\" = @ID_Tipo_seguimiento";
                    cmd.Parameters.AddWithValue("@ID_Tipo_seguimiento", idTipoSeguimiento);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllTipoSeguimientos()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Tipo_seguimiento\"", connection))
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