using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_ProductoRepository
    {
        private string connectionString;

        public CRM_ProductoRepository()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertProducto(int idProducto, int detalleProducto, int marca, int modelo, int tipo, int uso, int? detalle1, int? detalle2, int? detalle3, int? detalle4, int? detalle5, int? detalle6, int? detalle7, int? detalle8, int? fotos, int? archivo, int precio1, int? precio2, int? precio3, int idMoneda)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Producto\"(\"ID_Producto\", \"Detalle_Producto\", \"Marca\", \"Modelo\", \"Tipo\", \"Uso\", \"Detalle_1\", \"Detalle_2\", \"Detalle_3\", \"Detalle_4\", \"Detalle_5\", \"Detalle_6\", \"Detalle_7\", \"Detalle_8\", \"Fotos\", \"Archivo\", \"Precio_1\", \"Precio_2\", \"Precio_3\", \"ID_Moneda\") VALUES (@ID_Producto, @Detalle_Producto, @Marca, @Modelo, @Tipo, @Uso, @Detalle_1, @Detalle_2, @Detalle_3, @Detalle_4, @Detalle_5, @Detalle_6, @Detalle_7, @Detalle_8, @Fotos, @Archivo, @Precio_1, @Precio_2, @Precio_3, @ID_Moneda)";
                    cmd.Parameters.AddWithValue("@ID_Producto", idProducto);
                    cmd.Parameters.AddWithValue("@Detalle_Producto", detalleProducto);
                    cmd.Parameters.AddWithValue("@Marca", marca);
                    cmd.Parameters.AddWithValue("@Modelo", modelo);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Uso", uso);
                    cmd.Parameters.AddWithValue("@Detalle_1", detalle1 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_2", detalle2 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_3", detalle3 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_4", detalle4 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_5", detalle5 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_6", detalle6 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_7", detalle7 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_8", detalle8 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fotos", fotos ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Archivo", archivo ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Precio_1", precio1);
                    cmd.Parameters.AddWithValue("@Precio_2", precio2 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Precio_3", precio3 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Moneda", idMoneda);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProducto(int idProducto, int detalleProducto, int marca, int modelo, int tipo, int uso, int? detalle1, int? detalle2, int? detalle3, int? detalle4, int? detalle5, int? detalle6, int? detalle7, int? detalle8, int? fotos, int? archivo, int precio1, int? precio2, int? precio3, int idMoneda)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"CRM_Producto\" SET \"Detalle_Producto\" = @Detalle_Producto, \"Marca\" = @Marca, \"Modelo\" = @Modelo, \"Tipo\" = @Tipo, \"Uso\" = @Uso, \"Detalle_1\" = @Detalle_1, \"Detalle_2\" = @Detalle_2, \"Detalle_3\" = @Detalle_3, \"Detalle_4\" = @Detalle_4, \"Detalle_5\" = @Detalle_5, \"Detalle_6\" = @Detalle_6, \"Detalle_7\" = @Detalle_7, \"Detalle_8\" = @Detalle_8, \"Fotos\" = @Fotos, \"Archivo\" = @Archivo, \"Precio_1\" = @Precio_1, \"Precio_2\" = @Precio_2, \"Precio_3\" = @Precio_3, \"ID_Moneda\" = @ID_Moneda WHERE \"ID_Producto\" = @ID_Producto";
                    cmd.Parameters.AddWithValue("@ID_Producto", idProducto);
                    cmd.Parameters.AddWithValue("@Detalle_Producto", detalleProducto);
                    cmd.Parameters.AddWithValue("@Marca", marca);
                    cmd.Parameters.AddWithValue("@Modelo", modelo);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Uso", uso);
                    cmd.Parameters.AddWithValue("@Detalle_1", detalle1 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_2", detalle2 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_3", detalle3 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_4", detalle4 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_5", detalle5 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_6", detalle6 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_7", detalle7 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Detalle_8", detalle8 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fotos", fotos ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Archivo", archivo ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Precio_1", precio1);
                    cmd.Parameters.AddWithValue("@Precio_2", precio2 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Precio_3", precio3 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Moneda", idMoneda);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProducto(int idProducto)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Producto\" WHERE \"ID_Producto\" = @ID_Producto";
                    cmd.Parameters.AddWithValue("@ID_Producto", idProducto);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public DataTable FilterProductosByDateRange(DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM public.\"CRM_Producto\" WHERE \"Fecha_Modificacion\" >= @StartDate AND \"Fecha_Modificacion\" <= @EndDate ORDER BY \"Fecha_Modificacion\" DESC";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public DataTable GetAllProductos()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Producto\"", connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public DataRow ReadProducto(int idProducto)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Producto\" WHERE \"ID_Producto\" = @ID_Producto", connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Producto", idProducto);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0];
            }
            else
            {
                return null;
            }
        }
    }
}
