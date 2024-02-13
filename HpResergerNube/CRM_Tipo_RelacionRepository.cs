using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
namespace HpResergerNube
{


    public class CRM_Tipo_RelacionRepository
    {
        private readonly string connectionString;

        public CRM_Tipo_RelacionRepository()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertTipoRelacion(long idRelacion, string detalleRelacion)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Tipo_Relacion\" (\"ID_Relacion\", \"Detalle_Relacion\") VALUES (@ID_Relacion, @Detalle_Relacion)";
                    cmd.Parameters.AddWithValue("@ID_Relacion", idRelacion);
                    cmd.Parameters.AddWithValue("@Detalle_Relacion", detalleRelacion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTipoRelacion(long idRelacion, string nuevoDetalleRelacion)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"CRM_Tipo_Relacion\" SET \"Detalle_Relacion\" = @Detalle_Relacion WHERE \"ID_Relacion\" = @ID_Relacion";
                    cmd.Parameters.AddWithValue("@Detalle_Relacion", nuevoDetalleRelacion);
                    cmd.Parameters.AddWithValue("@ID_Relacion", idRelacion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTipoRelacion(long idRelacion)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Tipo_Relacion\" WHERE \"ID_Relacion\" = @ID_Relacion";
                    cmd.Parameters.AddWithValue("@ID_Relacion", idRelacion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllTipoRelacion()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Tipo_Relacion\"", connection))
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