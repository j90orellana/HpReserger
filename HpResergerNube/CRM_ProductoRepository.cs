// Decompiled with JetBrains decompiler
// Type: HpResergerNube.CRM_ProductoRepository
// Assembly: HpResergerNube, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5C6333DA-4256-4581-8176-EBEE3D8E696F
// Assembly location: C:\Users\user\OneDrive\Escritorio\HpResergerNubex.dll

using Npgsql;
using System;
using System.Data;

namespace HpResergerNube
{
    public class CRM_ProductoRepository
    {
        private string connectionString;
        public class Producto
        {
            public string ID_Producto { get; set; }

            public string Detalle_Producto { get; set; }

            public string Marca { get; set; }

            public string Modelo { get; set; }

            public string Tipo { get; set; }

            public string Uso { get; set; }

            public string Detalle_1 { get; set; }

            public string Detalle_2 { get; set; }

            public string Detalle_3 { get; set; }

            public string Detalle_4 { get; set; }

            public string Detalle_5 { get; set; }

            public string Detalle_6 { get; set; }

            public string Detalle_7 { get; set; }

            public string Detalle_8 { get; set; }

            public string Fotos { get; set; }

            public string Archivo { get; set; }

            public string Precio_1 { get; set; }

            public string Precio_2 { get; set; }

            public string Precio_3 { get; set; }

            public string ID_Moneda { get; set; }

            public string Usuario { get; set; }

            public DateTime? Fecha { get; set; }

            public byte[] Imagen { get; set; }
        }
        public CRM_ProductoRepository()
        {
            this.connectionString = new DLConexion().GetConnectionString();
        }
        public DataTable ObtenerProductosYServicios()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT ""ID_Producto"" AS ID, ""Detalle_Producto"" AS Nombre, ""Precio_1"" AS Precio FROM public.""CRM_Producto""
                                 UNION ALL
                                 SELECT ""ID_Servicio"" AS ID, ""Detalle_Servicio"" AS Nombre, ""Precio_Venta"" AS Precio FROM public.""CRM_Servicio""";

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
        public DataTable ObtenerProductosYServiciosPorID(string idProducto, string idServicio)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT ""ID_Producto"" AS ID, ""Detalle_Producto"" AS Nombre, ""Precio_1"" AS Precio FROM public.""CRM_Producto"" WHERE ""ID_Producto"" = @ID_Producto
                         UNION ALL
                         SELECT ""ID_Servicio"" AS ID, ""Detalle_Servicio"" AS Nombre, ""Precio_Venta"" AS Precio FROM public.""CRM_Servicio"" WHERE ""ID_Servicio"" = @ID_Servicio";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Producto", idProducto);
                    cmd.Parameters.AddWithValue("@ID_Servicio", idServicio);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public string InsertProducto(Producto producto)
        {
            string str1 = string.Empty;
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(this.connectionString))
            {
                npgsqlConnection.Open();
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand())
                {
                    npgsqlCommand.Connection = npgsqlConnection;
                    npgsqlCommand.CommandText = "SELECT MAX(\"ID_Producto\") FROM public.\"CRM_Producto\"";
                    string str2 = npgsqlCommand.ExecuteScalar() as string;
                    int result = 0;
                    if (!string.IsNullOrEmpty(str2))
                        int.TryParse(str2.Substring(2), out result);
                    ++result;
                    str1 = "PR" + result.ToString().PadLeft(5, '0');
                    npgsqlCommand.CommandText = "INSERT INTO public.\"CRM_Producto\"(\"ID_Producto\", \"Detalle_Producto\", \"Marca\", \"Modelo\", \"Tipo\", \"Uso\", \"Detalle_1\", \"Detalle_2\", \"Detalle_3\", \"Detalle_4\", \"Detalle_5\", \"Detalle_6\", \"Detalle_7\", \"Detalle_8\", \"Fotos\", \"Archivo\", \"Precio_1\", \"Precio_2\", \"Precio_3\", \"ID_Moneda\", \"Usuario\", \"Fecha\", \"Imagen\") VALUES (@ID_Producto, @Detalle_Producto, @Marca, @Modelo, @Tipo, @Uso, @Detalle_1, @Detalle_2, @Detalle_3, @Detalle_4, @Detalle_5, @Detalle_6, @Detalle_7, @Detalle_8, @Fotos, @Archivo, @Precio_1, @Precio_2, @Precio_3, @ID_Moneda, @Usuario, @Fecha, @Imagen)";
                    npgsqlCommand.Parameters.AddWithValue("@ID_Producto", (object)str1);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_Producto", (object)producto.Detalle_Producto);
                    npgsqlCommand.Parameters.AddWithValue("@Marca", (object)producto.Marca);
                    npgsqlCommand.Parameters.AddWithValue("@Modelo", (object)producto.Modelo);
                    npgsqlCommand.Parameters.AddWithValue("@Tipo", (object)producto.Tipo);
                    npgsqlCommand.Parameters.AddWithValue("@Uso", (object)producto.Uso);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_1", (object)producto.Detalle_1 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_2", (object)producto.Detalle_2 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_3", (object)producto.Detalle_3 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_4", (object)producto.Detalle_4 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_5", (object)producto.Detalle_5 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_6", (object)producto.Detalle_6 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_7", (object)producto.Detalle_7 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_8", (object)producto.Detalle_8 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Fotos", (object)producto.Fotos ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Archivo", (object)producto.Archivo ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Precio_1", (object)producto.Precio_1);
                    npgsqlCommand.Parameters.AddWithValue("@Precio_2", (object)producto.Precio_2 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Precio_3", (object)producto.Precio_3 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@ID_Moneda", (object)producto.ID_Moneda);
                    npgsqlCommand.Parameters.AddWithValue("@Usuario", (object)producto.Usuario ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Fecha", (object)producto.Fecha ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Imagen", (object)producto.Imagen ?? (object)DBNull.Value);
                    npgsqlCommand.ExecuteNonQuery();
                }
            }
            return str1;
        }

        public void UpdateProducto(Producto producto)
        {
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(this.connectionString))
            {
                npgsqlConnection.Open();
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand())
                {
                    npgsqlCommand.Connection = npgsqlConnection;
                    npgsqlCommand.CommandText = "UPDATE public.\"CRM_Producto\" SET \"Detalle_Producto\" = @Detalle_Producto, \"Marca\" = @Marca, \"Modelo\" = @Modelo, \"Tipo\" = @Tipo, \"Uso\" = @Uso, \"Detalle_1\" = @Detalle_1, \"Detalle_2\" = @Detalle_2, \"Detalle_3\" = @Detalle_3, \"Detalle_4\" = @Detalle_4, \"Detalle_5\" = @Detalle_5, \"Detalle_6\" = @Detalle_6, \"Detalle_7\" = @Detalle_7, \"Detalle_8\" = @Detalle_8, \"Fotos\" = @Fotos, \"Archivo\" = @Archivo, \"Precio_1\" = @Precio_1, \"Precio_2\" = @Precio_2, \"Precio_3\" = @Precio_3, \"ID_Moneda\" = @ID_Moneda, \"Usuario\" = @Usuario, \"Fecha\" = @Fecha, \"Imagen\" = @Imagen WHERE \"ID_Producto\" = @ID_Producto";
                    npgsqlCommand.Parameters.AddWithValue("@ID_Producto", (object)producto.ID_Producto);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_Producto", (object)producto.Detalle_Producto);
                    npgsqlCommand.Parameters.AddWithValue("@Marca", (object)producto.Marca);
                    npgsqlCommand.Parameters.AddWithValue("@Modelo", (object)producto.Modelo);
                    npgsqlCommand.Parameters.AddWithValue("@Tipo", (object)producto.Tipo);
                    npgsqlCommand.Parameters.AddWithValue("@Uso", (object)producto.Uso);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_1", (object)producto.Detalle_1 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_2", (object)producto.Detalle_2 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_3", (object)producto.Detalle_3 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_4", (object)producto.Detalle_4 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_5", (object)producto.Detalle_5 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_6", (object)producto.Detalle_6 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_7", (object)producto.Detalle_7 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_8", (object)producto.Detalle_8 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Fotos", (object)producto.Fotos ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Archivo", (object)producto.Archivo ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Precio_1", (object)producto.Precio_1);
                    npgsqlCommand.Parameters.AddWithValue("@Precio_2", (object)producto.Precio_2 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Precio_3", (object)producto.Precio_3 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@ID_Moneda", (object)producto.ID_Moneda);
                    npgsqlCommand.Parameters.AddWithValue("@Usuario", (object)producto.Usuario ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Fecha", (object)producto.Fecha ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Imagen", (object)producto.Imagen ?? (object)DBNull.Value);
                    npgsqlCommand.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProducto(string idProducto)
        {
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(this.connectionString))
            {
                npgsqlConnection.Open();
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand())
                {
                    npgsqlCommand.Connection = npgsqlConnection;
                    npgsqlCommand.CommandText = "DELETE FROM public.\"CRM_Producto\" WHERE \"ID_Producto\" = @ID_Producto";
                    npgsqlCommand.Parameters.AddWithValue("@ID_Producto", (object)idProducto);
                    npgsqlCommand.ExecuteNonQuery();
                }
            }
        }

        public DataTable FilterProductosByDateRange(DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();
            using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
            {
                connection.Open();
                using (NpgsqlCommand selectCommand = new NpgsqlCommand("SELECT * FROM public.\"CRM_Producto\" WHERE \"Fecha\" >= @StartDate AND \"Fecha\" <= @EndDate ORDER BY \"Fecha\" DESC", connection))
                {
                    selectCommand.Parameters.AddWithValue("@StartDate", (object)startDate);
                    selectCommand.Parameters.AddWithValue("@EndDate", (object)endDate);
                    using (NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(selectCommand))
                        npgsqlDataAdapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        public DataTable GetAllProductos()
        {
            DataTable dataTable = new DataTable();
            using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
            {
                connection.Open();
                using (NpgsqlCommand selectCommand = new NpgsqlCommand("SELECT * FROM public.\"CRM_Producto\"", connection))
                {
                    using (NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(selectCommand))
                        npgsqlDataAdapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        public Producto ReadProducto(string idProducto)
        {
            Producto producto = (Producto)null;
            using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
            {
                connection.Open();
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand("SELECT * FROM public.\"CRM_Producto\" WHERE \"ID_Producto\" = @ID_Producto", connection))
                {
                    npgsqlCommand.Parameters.AddWithValue("@ID_Producto", (object)idProducto);
                    using (NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader())
                    {
                        if (npgsqlDataReader.Read())
                            producto = new Producto()
                            {
                                ID_Producto = npgsqlDataReader["ID_Producto"].ToString(),
                                Detalle_Producto = npgsqlDataReader["Detalle_Producto"].ToString(),
                                Marca = npgsqlDataReader["Marca"].ToString(),
                                Modelo = npgsqlDataReader["Modelo"].ToString(),
                                Tipo = npgsqlDataReader["Tipo"].ToString(),
                                Uso = npgsqlDataReader["Uso"].ToString(),
                                Detalle_1 = npgsqlDataReader["Detalle_1"].ToString(),
                                Detalle_2 = npgsqlDataReader["Detalle_2"].ToString(),
                                Detalle_3 = npgsqlDataReader["Detalle_3"].ToString(),
                                Detalle_4 = npgsqlDataReader["Detalle_4"].ToString(),
                                Detalle_5 = npgsqlDataReader["Detalle_5"].ToString(),
                                Detalle_6 = npgsqlDataReader["Detalle_6"].ToString(),
                                Detalle_7 = npgsqlDataReader["Detalle_7"].ToString(),
                                Detalle_8 = npgsqlDataReader["Detalle_8"].ToString(),
                                Fotos = npgsqlDataReader["Fotos"].ToString(),
                                Archivo = npgsqlDataReader["Archivo"].ToString(),
                                Precio_1 = npgsqlDataReader["Precio_1"].ToString(),
                                Precio_2 = npgsqlDataReader["Precio_2"].ToString(),
                                Precio_3 = npgsqlDataReader["Precio_3"].ToString(),
                                ID_Moneda = npgsqlDataReader["ID_Moneda"].ToString(),
                                Usuario = npgsqlDataReader["Usuario"].ToString(),
                                Fecha = npgsqlDataReader["Fecha"] == DBNull.Value ? new DateTime?() : (DateTime?)npgsqlDataReader["Fecha"],
                                Imagen = npgsqlDataReader["Imagen"] as byte[]
                            };
                    }
                }
            }
            return producto;
        }
    }
}
