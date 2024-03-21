using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_Cotizador
    {
        public string ID_Cotización { get; set; }
        public string ID_Tipo_Documento { get; set; }
        public decimal ID_Numero_Doc { get; set; }
        public string ID_Tipo_persona { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Razon_Social { get; set; }
        public string Cod_proyecto { get; set; }
        public string Nombre_Proyecto { get; set; }
        public string ID_Producto { get; set; }
        public string Detalle_Producto { get; set; }
        public string ID_Moneda { get; set; }
        public string Costo { get; set; }
        public string IGV { get; set; }
        public string Precio_venta { get; set; }
        public string Usuario { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Fecha_registro { get; set; }

        private string connectionString;

        public CRM_Cotizador()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public string InsertCotizacion(CRM_Cotizador cotizacion)
        {
            string newIDCotizacion = "";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Obtener el último número de correlativo de la base de datos
                string queryLastCorrelative = "SELECT MAX(CAST(SUBSTRING(\"ID_Cotización\", 3) AS INT)) FROM public.\"CRM_Cotizador\"";
                using (NpgsqlCommand cmdLastCorrelative = new NpgsqlCommand(queryLastCorrelative, connection))
                {
                    object lastCorrelative = cmdLastCorrelative.ExecuteScalar();
                    int lastCorrelativeNumber = lastCorrelative == DBNull.Value ? 0 : Convert.ToInt32(lastCorrelative);

                    // Generar el nuevo correlativo
                    int newCorrelativeNumber = lastCorrelativeNumber + 1;

                    // Formar el nuevo ID_Cotizacion con el formato "CTXXX"
                    string newCorrelativeString = newCorrelativeNumber.ToString("D3");
                    newIDCotizacion = "CT" + newCorrelativeString;
                }

                // Insertar la nueva cotización con el nuevo ID_Cotización
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Cotizador\"(\"ID_Cotización\", \"ID_Tipo_Documento\", \"ID_Numero_Doc\", \"ID_Tipo_persona\", " +
                        "\"Nombre\", \"Apellido1\", \"Apellido2\", \"Razon_Social\", \"Cod_proyecto\", " +
                        "\"Nombre_Proyecto\", \"ID_Producto\", \"Detalle_Producto\", \"ID_Moneda\", \"Costo\", " +
                        "\"IGV\", \"Precio_venta\", \"Usuario\", \"Fecha\", \"Fecha_registro\") " +
                        "VALUES (@ID_Cotización, @ID_Tipo_Documento, @ID_Numero_Doc, @ID_Tipo_persona, " +
                        "@Nombre, @Apellido1, @Apellido2, @Razon_Social, @Cod_proyecto, " +
                        "@Nombre_Proyecto, @ID_Producto, @Detalle_Producto, @ID_Moneda, @Costo, " +
                        "@IGV, @Precio_venta, @Usuario, @Fecha, @Fecha_registro)";
                    cmd.Parameters.AddWithValue("@ID_Cotización", newIDCotizacion);
                    cmd.Parameters.AddWithValue("@ID_Tipo_Documento", cotizacion.ID_Tipo_Documento);
                    cmd.Parameters.AddWithValue("@ID_Numero_Doc", cotizacion.ID_Numero_Doc);
                    cmd.Parameters.AddWithValue("@ID_Tipo_persona", cotizacion.ID_Tipo_persona);
                    cmd.Parameters.AddWithValue("@Nombre", cotizacion.Nombre ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Apellido1", cotizacion.Apellido1 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Apellido2", cotizacion.Apellido2 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Razon_Social", cotizacion.Razon_Social ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Cod_proyecto", cotizacion.Cod_proyecto);
                    cmd.Parameters.AddWithValue("@Nombre_Proyecto", cotizacion.Nombre_Proyecto ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Producto", cotizacion.ID_Producto);
                    cmd.Parameters.AddWithValue("@Detalle_Producto", cotizacion.Detalle_Producto);
                    cmd.Parameters.AddWithValue("@ID_Moneda", cotizacion.ID_Moneda);
                    cmd.Parameters.AddWithValue("@Costo", cotizacion.Costo);
                    cmd.Parameters.AddWithValue("@IGV", cotizacion.IGV ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Precio_venta", cotizacion.Precio_venta ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Usuario", cotizacion.Usuario ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fecha", cotizacion.Fecha ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fecha_registro", cotizacion.Fecha_registro ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }

            return newIDCotizacion;
        }
        public void DeleteItemsCotizacion(string idCotizacion)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM public.\"CRM_Items_Cotizador\" WHERE \"ID_Cotización\" = @ID_Cotización", connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Cotización", idCotizacion);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public CRM_Cotizador ReadCotizacion(string idCotizacion)
        {
            CRM_Cotizador cotizacion = null;
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM public.\"CRM_Cotizador\" WHERE \"ID_Cotización\" like '{idCotizacion}'", connection);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cotizacion = new CRM_Cotizador
                    {
                        ID_Cotización = reader["ID_Cotización"].ToString(),
                        ID_Tipo_Documento = reader["ID_Tipo_Documento"].ToString(),
                        ID_Numero_Doc = Convert.ToDecimal(reader["ID_Numero_Doc"]),
                        ID_Tipo_persona = reader["ID_Tipo_persona"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido1 = reader["Apellido1"].ToString(),
                        Apellido2 = reader["Apellido2"].ToString(),
                        Razon_Social = reader["Razon_Social"].ToString(),
                        Cod_proyecto = reader["Cod_proyecto"].ToString(),
                        Nombre_Proyecto = reader["Nombre_Proyecto"].ToString(),
                        ID_Producto = reader["ID_Producto"].ToString(),
                        Detalle_Producto = reader["Detalle_Producto"].ToString(),
                        ID_Moneda = reader["ID_Moneda"].ToString(),
                        Costo = reader["Costo"].ToString(),
                        IGV = reader["IGV"].ToString(),
                        Precio_venta = reader["Precio_venta"].ToString(),
                        Usuario = reader["Usuario"].ToString(),
                        Fecha = reader["Fecha"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["Fecha"]),
                        Fecha_registro = reader["Fecha_registro"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["Fecha_registro"])
                    };
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones aquí, por ejemplo, registrar el error
                Console.WriteLine("Error al leer la cotización: " + ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }

            return cotizacion;
        }

        public bool UpdateCotizacion(CRM_Cotizador cotizacion)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"CRM_Cotizador\" SET " +
                        "\"ID_Tipo_Documento\" = @ID_Tipo_Documento, " +
                        "\"ID_Numero_Doc\" = @ID_Numero_Doc, " +
                        "\"ID_Tipo_persona\" = @ID_Tipo_persona, " +
                        "\"Nombre\" = @Nombre, " +
                        "\"Apellido1\" = @Apellido1, " +
                        "\"Apellido2\" = @Apellido2, " +
                        "\"Razon_Social\" = @Razon_Social, " +
                        "\"Cod_proyecto\" = @Cod_proyecto, " +
                        "\"Nombre_Proyecto\" = @Nombre_Proyecto, " +
                        "\"ID_Producto\" = @ID_Producto, " +
                        "\"Detalle_Producto\" = @Detalle_Producto, " +
                        "\"ID_Moneda\" = @ID_Moneda, " +
                        "\"Costo\" = @Costo, " +
                        "\"IGV\" = @IGV, " +
                        "\"Precio_venta\" = @Precio_venta, " +
                        "\"Usuario\" = @Usuario, " +
                        "\"Fecha\" = @Fecha, " +
                        "\"Fecha_registro\" = @Fecha_registro " +
                        "WHERE \"ID_Cotización\" = @ID_Cotización";
                    cmd.Parameters.AddWithValue("@ID_Cotización", cotizacion.ID_Cotización);
                    cmd.Parameters.AddWithValue("@ID_Tipo_Documento", cotizacion.ID_Tipo_Documento);
                    cmd.Parameters.AddWithValue("@ID_Numero_Doc", cotizacion.ID_Numero_Doc);
                    cmd.Parameters.AddWithValue("@ID_Tipo_persona", cotizacion.ID_Tipo_persona);
                    cmd.Parameters.AddWithValue("@Nombre", cotizacion.Nombre ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Apellido1", cotizacion.Apellido1 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Apellido2", cotizacion.Apellido2 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Razon_Social", cotizacion.Razon_Social ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Cod_proyecto", cotizacion.Cod_proyecto);
                    cmd.Parameters.AddWithValue("@Nombre_Proyecto", cotizacion.Nombre_Proyecto ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Producto", cotizacion.ID_Producto);
                    cmd.Parameters.AddWithValue("@Detalle_Producto", cotizacion.Detalle_Producto);
                    cmd.Parameters.AddWithValue("@ID_Moneda", cotizacion.ID_Moneda);
                    cmd.Parameters.AddWithValue("@Costo", cotizacion.Costo);
                    cmd.Parameters.AddWithValue("@IGV", cotizacion.IGV ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Precio_venta", cotizacion.Precio_venta ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Usuario", cotizacion.Usuario ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fecha", cotizacion.Fecha ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Fecha_registro", cotizacion.Fecha_registro ?? (object)DBNull.Value);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Verificar si la actualización fue exitosa
                    success = rowsAffected > 0;
                }
            }

            return success;
        }
        public DataTable FilterCotizacionesByDateRange(DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM public.\"CRM_Cotizador\" WHERE \"Fecha\" BETWEEN @StartDate AND @EndDate";

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

        public bool DeleteCotizacion(string idCotizacion)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Cotizador\" WHERE \"ID_Cotización\" = @ID_Cotización";
                    cmd.Parameters.AddWithValue("@ID_Cotización", idCotizacion);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Verificar si se eliminó al menos una fila
                    success = rowsAffected > 0;
                }
            }

            return success;
        }

    }
}