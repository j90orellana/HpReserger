 
using Npgsql;
using System;
using System.Data;

namespace HpResergerNube
{
    public class CRM_ProveedorRepository
    {
        private readonly string connectionString;

        public CRM_ProveedorRepository()
        {
            this.connectionString = new DLConexion().GetConnectionString();
        }
        public class CRM_Proveedor
        {
            public string ID_Proveedor { get; set; }

            public string ID_Tipo_persona { get; set; }

            public string Nombre { get; set; }

            public string Apellido1 { get; set; }

            public string Apellido2 { get; set; }

            public string Razon_Social { get; set; }

            public string ID_Tipo_Documento { get; set; }

            public Decimal ID_Numero_Doc { get; set; }

            public string Direccion { get; set; }

            public string Interior { get; set; }

            public string Piso { get; set; }

            public Decimal ID_Codigo_postal { get; set; }

            public Decimal Telefono1 { get; set; }

            public Decimal? Telefono2 { get; set; }

            public string email1 { get; set; }

            public string email2 { get; set; }

            public string web { get; set; }

            public string ID_Contacto { get; set; }

            public string Usuario_Creacion { get; set; }

            public DateTime Fecha_Creacion { get; set; }

            public string Usuario_Modificacion { get; set; }

            public DateTime? Fecha_Modificacion { get; set; }

            public string Usuario_Eliminacion { get; set; }

            public DateTime? Fecha_Eliminacion { get; set; }
        }
        public DataTable GetAll()
        {
            DataTable all = new DataTable();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand("SELECT * FROM public.\"CRM_Proveedor\"", connection))
                    {
                        using (NpgsqlDataReader reader = npgsqlCommand.ExecuteReader())
                            all.Load((IDataReader)reader);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return all;
        }

        public string Insert(CRM_Proveedor proveedor)
        {
            string str = "";
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand("INSERT INTO public.\"CRM_Proveedor\" (\"ID_Proveedor\", \"ID_Tipo_persona\", \"Nombre\", \"Apellido1\", \"Apellido2\", \"Razon_Social\", \"ID_Tipo_Documento\", \"ID_Numero_Doc\", \"Direccion\", \"Interior\", \"Piso\", \"ID_Codigo_postal\", \"Telefono1\", \"Telefono2\", \"email1\", \"email2\", \"web\", \"ID_Contacto\", \"Usuario_Creacion\", \"Fecha_Creacion\", \"Usuario_Modificacion\", \"Fecha_Modificacion\", \"Usuario_Eliminacion\", \"Fecha_Eliminacion\") VALUES (@ID_Proveedor, @ID_Tipo_persona, @Nombre, @Apellido1, @Apellido2, @Razon_Social, @ID_Tipo_Documento, @ID_Numero_Doc, @Direccion, @Interior, @Piso, @ID_Codigo_postal, @Telefono1, @Telefono2, @email1, @email2, @web, @ID_Contacto, @Usuario_Creacion, @Fecha_Creacion, @Usuario_Modificacion, @Fecha_Modificacion, @Usuario_Eliminacion, @Fecha_Eliminacion)", connection))
                    {
                        npgsqlCommand.Parameters.AddWithValue("@ID_Proveedor", (object)proveedor.ID_Proveedor);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Tipo_persona", (object)proveedor.ID_Tipo_persona);
                        npgsqlCommand.Parameters.AddWithValue("@Nombre", (object)proveedor.Nombre);
                        npgsqlCommand.Parameters.AddWithValue("@Apellido1", (object)proveedor.Apellido1);
                        npgsqlCommand.Parameters.AddWithValue("@Apellido2", (object)proveedor.Apellido2);
                        npgsqlCommand.Parameters.AddWithValue("@Razon_Social", (object)proveedor.Razon_Social);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Tipo_Documento", (object)proveedor.ID_Tipo_Documento);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Numero_Doc", (object)proveedor.ID_Numero_Doc);
                        npgsqlCommand.Parameters.AddWithValue("@Direccion", (object)proveedor.Direccion);
                        npgsqlCommand.Parameters.AddWithValue("@Interior", (object)proveedor.Interior);
                        npgsqlCommand.Parameters.AddWithValue("@Piso", (object)proveedor.Piso);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Codigo_postal", (object)proveedor.ID_Codigo_postal);
                        npgsqlCommand.Parameters.AddWithValue("@Telefono1", (object)proveedor.Telefono1);
                        npgsqlCommand.Parameters.AddWithValue("@Telefono2", (object)proveedor.Telefono2);
                        npgsqlCommand.Parameters.AddWithValue("@email1", (object)proveedor.email1);
                        npgsqlCommand.Parameters.AddWithValue("@email2", (object)proveedor.email2);
                        npgsqlCommand.Parameters.AddWithValue("@web", (object)proveedor.web);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Contacto", (object)proveedor.ID_Contacto);
                        npgsqlCommand.Parameters.AddWithValue("@Usuario_Creacion", (object)proveedor.Usuario_Creacion);
                        npgsqlCommand.Parameters.AddWithValue("@Fecha_Creacion", (object)proveedor.Fecha_Creacion);
                        npgsqlCommand.Parameters.AddWithValue("@Usuario_Modificacion", (object)proveedor.Usuario_Modificacion);
                        npgsqlCommand.Parameters.AddWithValue("@Fecha_Modificacion", (object)proveedor.Fecha_Modificacion);
                        npgsqlCommand.Parameters.AddWithValue("@Usuario_Eliminacion", (object)proveedor.Usuario_Eliminacion);
                        npgsqlCommand.Parameters.AddWithValue("@Fecha_Eliminacion", (object)proveedor.Fecha_Eliminacion);
                        npgsqlCommand.ExecuteScalar();
                        str = proveedor.ID_Proveedor;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return str;
        }

        public bool Update(CRM_Proveedor proveedor)
        {
            bool flag = false;
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand("UPDATE public.\"CRM_Proveedor\" SET \"ID_Tipo_persona\" = @ID_Tipo_persona, \"Nombre\" = @Nombre, \"Apellido1\" = @Apellido1, \"Apellido2\" = @Apellido2, \"Razon_Social\" = @Razon_Social, \"ID_Tipo_Documento\" = @ID_Tipo_Documento, \"ID_Numero_Doc\" = @ID_Numero_Doc, \"Direccion\" = @Direccion, \"Interior\" = @Interior, \"Piso\" = @Piso, \"ID_Codigo_postal\" = @ID_Codigo_postal, \"Telefono1\" = @Telefono1, \"Telefono2\" = @Telefono2, \"email1\" = @email1, \"email2\" = @email2, \"web\" = @web, \"ID_Contacto\" = @ID_Contacto, \"Usuario_Modificacion\" = @Usuario_Modificacion, \"Fecha_Modificacion\" = @Fecha_Modificacion, \"Usuario_Eliminacion\" = @Usuario_Eliminacion, \"Fecha_Eliminacion\" = @Fecha_Eliminacion WHERE \"ID_Proveedor\" = @ID_Proveedor", connection))
                    {
                        npgsqlCommand.Parameters.AddWithValue("@ID_Proveedor", (object)proveedor.ID_Proveedor);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Tipo_persona", (object)proveedor.ID_Tipo_persona);
                        npgsqlCommand.Parameters.AddWithValue("@Nombre", (object)proveedor.Nombre);
                        npgsqlCommand.Parameters.AddWithValue("@Apellido1", (object)proveedor.Apellido1);
                        npgsqlCommand.Parameters.AddWithValue("@Apellido2", (object)proveedor.Apellido2);
                        npgsqlCommand.Parameters.AddWithValue("@Razon_Social", (object)proveedor.Razon_Social);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Tipo_Documento", (object)proveedor.ID_Tipo_Documento);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Numero_Doc", (object)proveedor.ID_Numero_Doc);
                        npgsqlCommand.Parameters.AddWithValue("@Direccion", (object)proveedor.Direccion);
                        npgsqlCommand.Parameters.AddWithValue("@Interior", (object)proveedor.Interior);
                        npgsqlCommand.Parameters.AddWithValue("@Piso", (object)proveedor.Piso);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Codigo_postal", (object)proveedor.ID_Codigo_postal);
                        npgsqlCommand.Parameters.AddWithValue("@Telefono1", (object)proveedor.Telefono1);
                        npgsqlCommand.Parameters.AddWithValue("@Telefono2", (object)proveedor.Telefono2);
                        npgsqlCommand.Parameters.AddWithValue("@email1", (object)proveedor.email1);
                        npgsqlCommand.Parameters.AddWithValue("@email2", (object)proveedor.email2);
                        npgsqlCommand.Parameters.AddWithValue("@web", (object)proveedor.web);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Contacto", (object)proveedor.ID_Contacto);
                        npgsqlCommand.Parameters.AddWithValue("@Usuario_Modificacion", (object)proveedor.Usuario_Modificacion);
                        npgsqlCommand.Parameters.AddWithValue("@Fecha_Modificacion", (object)proveedor.Fecha_Modificacion);
                        npgsqlCommand.Parameters.AddWithValue("@Usuario_Eliminacion", (object)proveedor.Usuario_Eliminacion);
                        npgsqlCommand.Parameters.AddWithValue("@Fecha_Eliminacion", (object)proveedor.Fecha_Eliminacion);
                        flag = npgsqlCommand.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return flag;
        }

        public bool Delete(string id)
        {
            bool flag = false;
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand("DELETE FROM public.\"CRM_Proveedor\" WHERE \"ID_Proveedor\" = @ID", connection))
                    {
                        npgsqlCommand.Parameters.AddWithValue("@ID", (object)id);
                        flag = npgsqlCommand.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return flag;
        }

        public CRM_Proveedor GetById(string id)
        {
            CRM_Proveedor byId = (CRM_Proveedor)null;
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand("SELECT * FROM public.\"CRM_Proveedor\" WHERE \"ID_Proveedor\" = @ID", connection))
                    {
                        npgsqlCommand.Parameters.AddWithValue("@ID", (object)id);
                        using (NpgsqlDataReader reader = npgsqlCommand.ExecuteReader())
                        {
                            if (reader.Read())
                                byId = this.MapRowToCRM_Proveedor(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return byId;
        }

        private CRM_Proveedor MapRowToCRM_Proveedor(NpgsqlDataReader reader)
        {
            CRM_Proveedor crmProveedor = new CRM_Proveedor();
            crmProveedor.ID_Proveedor = reader["ID_Proveedor"].ToString();
            crmProveedor.ID_Tipo_persona = reader["ID_Tipo_persona"].ToString();
            crmProveedor.Nombre = reader["Nombre"].ToString();
            crmProveedor.Apellido1 = reader["Apellido1"].ToString();
            crmProveedor.Apellido2 = reader["Apellido2"].ToString();
            crmProveedor.Razon_Social = reader["Razon_Social"].ToString();
            crmProveedor.ID_Tipo_Documento = reader["ID_Tipo_Documento"].ToString();
            crmProveedor.ID_Numero_Doc = Convert.ToDecimal(reader["ID_Numero_Doc"]);
            crmProveedor.Direccion = reader["Direccion"].ToString();
            crmProveedor.Interior = reader["Interior"].ToString();
            crmProveedor.Piso = reader["Piso"].ToString();
            crmProveedor.ID_Codigo_postal = Convert.ToDecimal(reader["ID_Codigo_postal"]);
            crmProveedor.Telefono1 = Convert.ToDecimal(reader["Telefono1"]);
            if (reader["Telefono2"] != DBNull.Value)
                crmProveedor.Telefono2 = new Decimal?(Convert.ToDecimal(reader["Telefono2"]));
            crmProveedor.email1 = reader["email1"].ToString();
            crmProveedor.email2 = reader["email2"].ToString();
            crmProveedor.web = reader["web"].ToString();
            crmProveedor.ID_Contacto = reader["ID_Contacto"].ToString();
            crmProveedor.Usuario_Creacion = reader["Usuario_Creacion"].ToString();
            crmProveedor.Fecha_Creacion = Convert.ToDateTime(reader["Fecha_Creacion"]);
            crmProveedor.Usuario_Modificacion = reader["Usuario_Modificacion"].ToString();
            if (reader["Fecha_Modificacion"] != DBNull.Value)
                crmProveedor.Fecha_Modificacion = new DateTime?(Convert.ToDateTime(reader["Fecha_Modificacion"]));
            crmProveedor.Usuario_Eliminacion = reader["Usuario_Eliminacion"].ToString();
            if (reader["Fecha_Eliminacion"] != DBNull.Value)
                crmProveedor.Fecha_Eliminacion = new DateTime?(Convert.ToDateTime(reader["Fecha_Eliminacion"]));
            return crmProveedor;
        }

        public DataTable FilterProveedoresByDateRange(DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand selectCommand = new NpgsqlCommand("SELECT *, CASE WHEN \"ID_Tipo_persona\" = 'J' THEN \"Razon_Social\" ELSE CONCAT(\"Nombre\", ' ', COALESCE(\"Apellido1\", ''), ' ', COALESCE(\"Apellido2\", '')) END AS NombreCompleto FROM public.\"CRM_Proveedor\" WHERE \"Fecha_Creacion\" >= @StartDate AND \"Fecha_Creacion\" <= @EndDate ORDER BY COALESCE(\"Fecha_Modificacion\", \"Fecha_Creacion\") DESC", connection))
                    {
                        selectCommand.Parameters.AddWithValue("@StartDate", (object)startDate);
                        selectCommand.Parameters.AddWithValue("@EndDate", (object)endDate);
                        using (NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(selectCommand))
                            npgsqlDataAdapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return dataTable;
        }
    }
}
