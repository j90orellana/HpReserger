using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;

namespace HpResergerNube
{

    public class CRM_Tipo_ComprobanteRepository
    {
        private readonly string connectionString;

        public CRM_Tipo_ComprobanteRepository()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertTipoComprobante(long idCodigoComprobante, string descripcionComprobante)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Tipo_Comprobante\" (\"ID_Codigo_Comprobante\", \"Descripcion_Comprobante\") VALUES (@ID_Codigo_Comprobante, @Descripcion_Comprobante)";
                    cmd.Parameters.AddWithValue("@ID_Codigo_Comprobante", idCodigoComprobante);
                    cmd.Parameters.AddWithValue("@Descripcion_Comprobante", descripcionComprobante);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTipoComprobante(long idCodigoComprobante, string nuevaDescripcionComprobante)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"CRM_Tipo_Comprobante\" SET \"Descripcion_Comprobante\" = @Descripcion_Comprobante WHERE \"ID_Codigo_Comprobante\" = @ID_Codigo_Comprobante";
                    cmd.Parameters.AddWithValue("@Descripcion_Comprobante", nuevaDescripcionComprobante);
                    cmd.Parameters.AddWithValue("@ID_Codigo_Comprobante", idCodigoComprobante);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTipoComprobante(long idCodigoComprobante)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Tipo_Comprobante\" WHERE \"ID_Codigo_Comprobante\" = @ID_Codigo_Comprobante";
                    cmd.Parameters.AddWithValue("@ID_Codigo_Comprobante", idCodigoComprobante);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllTipoComprobantes()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Tipo_Comprobante\"", connection))
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