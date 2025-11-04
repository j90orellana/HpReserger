using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;

namespace HpResergerNube
{


    public class CRM_Tipo_DocumentoRepository
    {
        private readonly string connectionString;

        public CRM_Tipo_DocumentoRepository()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertTipoDocumento(long idTipoDocumento, string detalleTipoDocumento)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Tipo_documento\" (\"ID_Tipo_documento\", \"Detalle_Tipo_documento\") VALUES (@ID_Tipo_documento, @Detalle_Tipo_documento)";
                    cmd.Parameters.AddWithValue("@ID_Tipo_documento", idTipoDocumento);
                    cmd.Parameters.AddWithValue("@Detalle_Tipo_documento", detalleTipoDocumento);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTipoDocumento(long idTipoDocumento, string nuevoDetalleTipoDocumento)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"CRM_Tipo_documento\" SET \"Detalle_Tipo_documento\" = @Detalle_Tipo_documento WHERE \"ID_Tipo_documento\" = @ID_Tipo_documento";
                    cmd.Parameters.AddWithValue("@Detalle_Tipo_documento", nuevoDetalleTipoDocumento);
                    cmd.Parameters.AddWithValue("@ID_Tipo_documento", idTipoDocumento);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTipoDocumento(long idTipoDocumento)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Tipo_documento\" WHERE \"ID_Tipo_documento\" = @ID_Tipo_documento";
                    cmd.Parameters.AddWithValue("@ID_Tipo_documento", idTipoDocumento);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllTipoDocumentosPersonas()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT COUNT(cc.""ID_TIpo_Documento"") AS cantidad_clientes, d.*
                    FROM public.""CRM_Tipo_documento"" d
                    LEFT JOIN public.""CRM_Cliente"" cc ON d.""ID_Tipo_documento"" = cc.""ID_TIpo_Documento""
                    GROUP BY d.""ID_Tipo_documento""
                    ORDER BY 1 DESC;
";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
        public DataTable GetAllTipoDocumentosEmpresas()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                        SELECT COUNT(d.""ID_Tipo_documento"") AS cantidad, d.*
                        FROM public.""CRM_Tipo_documento"" d
                        LEFT JOIN public.""CRM_Proveedor"" cc ON d.""ID_Tipo_documento"" = cc.""ID_Tipo_Documento""
                        GROUP BY d.""ID_Tipo_documento""
                        ORDER BY 1 DESC;
";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
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