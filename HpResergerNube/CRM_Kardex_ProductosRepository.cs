using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_Kardex_ProductosRepository
    {
        private readonly string connectionString;

        public CRM_Kardex_ProductosRepository()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertKardexProducto(long idProducto, long producto, decimal cantidad, decimal codigo, long idSedes, long idCodigoComprobante, long idTipoDocumento, DateTime fechaIngreso, long? observaciones, long idUsuario, long? archivo, long? fotos, string idNumeroDoc)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Kardex_Productos\" " +
                        "(\"ID_Producto\", \"Producto\", \"Cantidad\", \"Codigo\", \"ID_Sedes\", \"ID_Codigo_Comprobante\", \"ID_Tipo_Documento\", \"Fecha_Ingreso\", \"Observaciones\", \"ID_Usuario\", \"Archivo\", \"Fotos\", \"ID_Numero_Doc\") " +
                        "VALUES (@ID_Producto, @Producto, @Cantidad, @Codigo, @ID_Sedes, @ID_Codigo_Comprobante, @ID_Tipo_Documento, @Fecha_Ingreso, @Observaciones, @ID_Usuario, @Archivo, @Fotos, @ID_Numero_Doc)";
                    cmd.Parameters.AddWithValue("@ID_Producto", idProducto);
                    cmd.Parameters.AddWithValue("@Producto", producto);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cmd.Parameters.AddWithValue("@ID_Sedes", idSedes);
                    cmd.Parameters.AddWithValue("@ID_Codigo_Comprobante", idCodigoComprobante);
                    cmd.Parameters.AddWithValue("@ID_Tipo_Documento", idTipoDocumento);
                    cmd.Parameters.AddWithValue("@Fecha_Ingreso", fechaIngreso);
                    cmd.Parameters.AddWithValue("@Observaciones", observaciones ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Usuario", idUsuario);
                    cmd.Parameters.AddWithValue("@Archivo", archivo ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fotos", fotos ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Numero_Doc", idNumeroDoc);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllKardexProductos()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Kardex_Productos\"", connection))
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
