using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_Tipo_ProyectoRepository
    {
        private readonly string connectionString;

        public CRM_Tipo_ProyectoRepository()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertTipoProyecto(string idTipoProyecto, string detalleTipoProyecto)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Tipo_proyecto\" (\"ID_Tipo_proyecto\", \"Detalle_Tipo_proyecto\") VALUES (@ID_Tipo_proyecto, @Detalle_Tipo_proyecto)";
                    cmd.Parameters.AddWithValue("@ID_Tipo_proyecto", idTipoProyecto);
                    cmd.Parameters.AddWithValue("@Detalle_Tipo_proyecto", detalleTipoProyecto);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTipoProyecto(string idTipoProyecto, string nuevoDetalleTipoProyecto)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"CRM_Tipo_proyecto\" SET \"Detalle_Tipo_proyecto\" = @Detalle_Tipo_proyecto WHERE \"ID_Tipo_proyecto\" = @ID_Tipo_proyecto";
                    cmd.Parameters.AddWithValue("@Detalle_Tipo_proyecto", nuevoDetalleTipoProyecto);
                    cmd.Parameters.AddWithValue("@ID_Tipo_proyecto", idTipoProyecto);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTipoProyecto(string idTipoProyecto)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Tipo_proyecto\" WHERE \"ID_Tipo_proyecto\" = @ID_Tipo_proyecto";
                    cmd.Parameters.AddWithValue("@ID_Tipo_proyecto", idTipoProyecto);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllTipoProyectos()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Tipo_proyecto\"", connection))
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