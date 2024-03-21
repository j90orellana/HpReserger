using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_Items_Cotizador
    {
        public string ID_Cotización { get; set; }
        public string ID_Item_Cotización { get; set; }
        public string ID_Moneda { get; set; }
        public string ID_Tipo_PS { get; set; }
        public string ID_Producto { get; set; }
        public string Detalle_Producto { get; set; }
        public string Cantidad_Producto { get; set; }
        public string Costo_Unit_Producto { get; set; }
        public string Costo_Item_Producto { get; set; }
        public string IGV_Producto { get; set; }
        public string Precio_venta_Producto { get; set; }
        public string ID_Servicio { get; set; }
        public string Detalle_Servicio { get; set; }
        public string Cantidad_Servicio { get; set; }
        public string Costo_Unit_Servicio { get; set; }
        public string Costo_Item_Servicio { get; set; }
        public string IGV_Servicio { get; set; }
        public string Precio_venta_Servicio { get; set; }
        public string Usuario { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Fecha_registro { get; set; }

        private string connectionString;

        public CRM_Items_Cotizador()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertItemCotizacion(CRM_Items_Cotizador item)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Items_Cotizador\"(" +
                        "\"ID_Cotización\", \"ID_Item_Cotización\", \"ID_Moneda\", \"ID_Tipo_PS\", " +
                        "\"ID_Producto\", \"Detalle_Producto\", \"Cantidad_Producto\", \"Costo_Unit_Producto\", " +
                        "\"Costo_Item_Producto\", \"IGV_Producto\", \"Precio_venta_Producto\", \"ID_Servicio\", " +
                        "\"Detalle_Servicio\", \"Cantidad_Servicio\", \"Costo_Unit_Servicio\", \"Costo_Item_Servicio\", " +
                        "\"IGV_Servicio\", \"Precio_venta_Servicio\", \"Usuario\", \"Fecha\", \"Fecha_registro\") " +
                        "VALUES (@ID_Cotización, @ID_Item_Cotización, @ID_Moneda, @ID_Tipo_PS, " +
                        "@ID_Producto, @Detalle_Producto, @Cantidad_Producto, @Costo_Unit_Producto, " +
                        "@Costo_Item_Producto, @IGV_Producto, @Precio_venta_Producto, @ID_Servicio, " +
                        "@Detalle_Servicio, @Cantidad_Servicio, @Costo_Unit_Servicio, @Costo_Item_Servicio, " +
                        "@IGV_Servicio, @Precio_venta_Servicio, @Usuario, @Fecha, @Fecha_registro)";
                    cmd.Parameters.AddWithValue("@ID_Cotización", item.ID_Cotización);
                    cmd.Parameters.AddWithValue("@ID_Item_Cotización", item.ID_Item_Cotización);
                    cmd.Parameters.AddWithValue("@ID_Moneda", item.ID_Moneda);
                    cmd.Parameters.AddWithValue("@ID_Tipo_PS", item.ID_Tipo_PS ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Producto", item.ID_Producto);
                    cmd.Parameters.AddWithValue("@Detalle_Producto", item.Detalle_Producto);
                    cmd.Parameters.AddWithValue("@Cantidad_Producto", item.Cantidad_Producto);
                    cmd.Parameters.AddWithValue("@Costo_Unit_Producto", item.Costo_Unit_Producto);
                    cmd.Parameters.AddWithValue("@Costo_Item_Producto", item.Costo_Item_Producto);
                    cmd.Parameters.AddWithValue("@IGV_Producto", item.IGV_Producto ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Precio_venta_Producto", item.Precio_venta_Producto ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Servicio", item.ID_Servicio);
                    cmd.Parameters.AddWithValue("@Detalle_Servicio", item.Detalle_Servicio);
                    cmd.Parameters.AddWithValue("@Cantidad_Servicio", item.Cantidad_Servicio);
                    cmd.Parameters.AddWithValue("@Costo_Unit_Servicio", item.Costo_Unit_Servicio);
                    cmd.Parameters.AddWithValue("@Costo_Item_Servicio", item.Costo_Item_Servicio);
                    cmd.Parameters.AddWithValue("@IGV_Servicio", item.IGV_Servicio ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Precio_venta_Servicio", item.Precio_venta_Servicio ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Usuario", item.Usuario ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fecha", item.Fecha ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fecha_registro", item.Fecha_registro ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public DataTable ReadItemsCotizacion(string idCotizacion)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM public.\"CRM_Items_Cotizador\" WHERE \"ID_Cotización\" = '{idCotizacion}'", connection))
                {
                    //cmd.Parameters.AddWithValue("@ID_Cotización", idCotizacion);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public CRM_Items_Cotizador ReadItemCotizacion(string idCotizacion, string idItemCotizacion)
        {
            CRM_Items_Cotizador item = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Items_Cotizador\" WHERE \"ID_Cotización\" = @ID_Cotización AND \"ID_Item_Cotización\" = @ID_Item_Cotización", connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Cotización", idCotizacion);
                    cmd.Parameters.AddWithValue("@ID_Item_Cotización", idItemCotizacion);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            item = new CRM_Items_Cotizador
                            {
                                ID_Cotización = reader["ID_Cotización"].ToString(),
                                ID_Item_Cotización = reader["ID_Item_Cotización"].ToString(),
                                ID_Moneda = reader["ID_Moneda"].ToString(),
                                ID_Tipo_PS = reader["ID_Tipo_PS"]?.ToString(),
                                ID_Producto = reader["ID_Producto"].ToString(),
                                Detalle_Producto = reader["Detalle_Producto"].ToString(),
                                Cantidad_Producto = reader["Cantidad_Producto"].ToString(),
                                Costo_Unit_Producto = reader["Costo_Unit_Producto"].ToString(),
                                Costo_Item_Producto = reader["Costo_Item_Producto"].ToString(),
                                IGV_Producto = reader["IGV_Producto"]?.ToString(),
                                Precio_venta_Producto = reader["Precio_venta_Producto"]?.ToString(),
                                ID_Servicio = reader["ID_Servicio"].ToString(),
                                Detalle_Servicio = reader["Detalle_Servicio"].ToString(),
                                Cantidad_Servicio = reader["Cantidad_Servicio"].ToString(),
                                Costo_Unit_Servicio = reader["Costo_Unit_Servicio"].ToString(),
                                Costo_Item_Servicio = reader["Costo_Item_Servicio"].ToString(),
                                IGV_Servicio = reader["IGV_Servicio"]?.ToString(),
                                Precio_venta_Servicio = reader["Precio_venta_Servicio"]?.ToString(),
                                Usuario = reader["Usuario"]?.ToString(),
                                Fecha = reader["Fecha"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["Fecha"]),
                                Fecha_registro = reader["Fecha_registro"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["Fecha_registro"])
                            };
                        }
                    }
                }
            }

            return item;
        }

    }
}

