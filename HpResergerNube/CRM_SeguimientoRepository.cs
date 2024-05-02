using Npgsql;
using System;
using System.Data;

namespace HpResergerNube
{
    public class CRM_SeguimientoRepository
    {
        private readonly string connectionString;


        public CRM_SeguimientoRepository()
        {
            this.connectionString = new DLConexion().GetConnectionString();
        }

        public DataTable FilterSeguimientosByDateRange(DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand selectCommand = new NpgsqlCommand("\r\n                SELECT \r\n                    s.*, \r\n                    u.\"Nombre\" AS \"Nombre_Usuario\"\r\n                FROM \r\n                    public.\"CRM_Seguimiento\" AS s\r\n                INNER JOIN \r\n                    public.\"CRM_Usuario\" AS u ON s.\"Usuario_Creacion\" = u.\"ID_Usuario\"\r\n                WHERE \r\n                    s.\"Fecha_Seguimiento\" >= @StartDate AND \r\n                    s.\"Fecha_Seguimiento\" <= @EndDate \r\n                ORDER BY \r\n                    s.\"Fecha_Seguimiento\" DESC", connection))
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
                // Manejo de excepciones
            }
            return dataTable;
        }
        public DataTable FilterSeguimientosByDateRangeUnicos(DateTime startDate, DateTime endDate, string userID, string projectID)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand selectCommand = new NpgsqlCommand(
                        "SELECT " +
                        "    s.\"ID_Seguimiento\", " +
                        "    s.\"ID_Proyecto\", " +
                        "    s.\"Nombre_Proyecto\", " +
                        "    s.\"ID_Cliente\", " +
                        "    s.\"ID_Tipo_Documento\", " +
                        "    s.\"ID_Numero_Doc\", " +
                        "    s.\"Nombre\", " +
                        "    s.\"Apellido1\", " +
                        "    s.\"Apellido2\", " +
                        "    s.\"Razon_Social\", " +
                        "    s.\"ID_Tipo_Seguimiento\", " +
                        "    s.\"Detalle_Tipo_Seguimiento\", " +
                        "    s.\"ID_Contacto\", " +
                        "    s.\"Contacto\", " +
                        "    s.\"Fecha_Seguimiento\", " +
                        "    s.\"Fecha_Prox_Seguimiento\", " +
                        "    s.\"Descripcion\", " +
                        "    s.\"Usuario\", " +
                        "    s.\"Fecha_Registro\", " +
                        "    (u.\"Nombre\" || ' ' || u.\"Apellido1\" || ' ' || u.\"Apellido2\") AS \"Nombre_Usuario\"" +
                        "FROM " +
                        "    public.\"CRM_Seguimiento\" AS s " +
                        "LEFT JOIN " +
                        "    public.\"CRM_Usuario\" AS u ON s.\"Usuario\" = u.\"ID_Usuario\" " +
                        "WHERE " +
                        "    (@UserID = '0' OR u.\"ID_Usuario\" = @UserID) AND " +
                        "    (@ProjectID = 0 OR s.\"ID_Proyecto\" = @ProjectID) AND " +
                        "    s.\"Fecha_Prox_Seguimiento\" >= @StartDate AND " +
                        "    s.\"Fecha_Prox_Seguimiento\" <= @EndDate AND " +
                        "    s.\"ID_Seguimiento\" IN (SELECT MAX(\"ID_Seguimiento\") FROM public.\"CRM_Seguimiento\" GROUP BY \"ID_Proyecto\")", connection))
                    {
                        selectCommand.Parameters.AddWithValue("@StartDate", startDate);
                        selectCommand.Parameters.AddWithValue("@EndDate", endDate.AddDays(0));
                        selectCommand.Parameters.AddWithValue("@UserID", userID);
                        selectCommand.Parameters.AddWithValue("@ProjectID", Convert.ToInt32(projectID));
                        using (NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(selectCommand))
                            npgsqlDataAdapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
            }
            return dataTable;
        }



        public DataTable FilterSeguimientosByDateRange(DateTime startDate, DateTime endDate, string userID, string projectID)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand selectCommand = new NpgsqlCommand(
                        "SELECT " +
                        "    s.*, " +
                        "     (u.\"Nombre\" || ' ' || u.\"Apellido1\" || ' ' || u.\"Apellido2\") AS \"Nombre_Usuario\"" +
                        "FROM " +
                        "    public.\"CRM_Seguimiento\" AS s " +
                        "left  JOIN " +
                        "    public.\"CRM_Usuario\" AS u ON s.\"Usuario\" = u.\"ID_Usuario\" " +
                        "WHERE " +
                        "    (@UserID = '0' OR u.\"ID_Usuario\" = @UserID) AND " +
                        "    (@ProjectID = 0 OR s.\"ID_Proyecto\" = @ProjectID) AND " +
                        "    s.\"Fecha_Prox_Seguimiento\" >= @StartDate AND " +
                        "    s.\"Fecha_Prox_Seguimiento\" <= @EndDate " +
                         " --  AND s.\"Fecha_Seguimiento\" >= CURRENT_DATE  " +

                        "ORDER BY " +
                        "    s.\"Fecha_Seguimiento\" DESC", connection))
                    {
                        selectCommand.Parameters.AddWithValue("@StartDate", (object)startDate);
                        selectCommand.Parameters.AddWithValue("@EndDate", (object)endDate.AddDays(0));
                        selectCommand.Parameters.AddWithValue("@UserID", (object)userID);
                        selectCommand.Parameters.AddWithValue("@ProjectID", (object)Convert.ToInt32(projectID));
                        using (NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(selectCommand))
                            npgsqlDataAdapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
            }
            return dataTable;
        }




        public int InsertSeguimiento(CRM_Seguimiento seguimiento)
        {
            int num = -1;
            try
            {
                using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(this.connectionString))
                {
                    npgsqlConnection.Open();
                    using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand())
                    {
                        npgsqlCommand.Connection = npgsqlConnection;
                        npgsqlCommand.CommandText = "INSERT INTO public.\"CRM_Seguimiento\" ( \"ID_Proyecto\", \"Nombre_Proyecto\", \"ID_Cliente\", \"ID_Tipo_Documento\", \"ID_Numero_Doc\", \"Nombre\", \"Apellido1\", \"Apellido2\", \"Razon_Social\", \"ID_Tipo_Seguimiento\", \"Detalle_Tipo_Seguimiento\", \"ID_Contacto\", \"Contacto\", \"Fecha_Seguimiento\", \"Fecha_Prox_Seguimiento\", \"Descripcion\", \"Usuario\", \"Fecha_Registro\") VALUES ( @ID_Proyecto, @Nombre_Proyecto, @ID_Cliente, @ID_Tipo_Documento, @ID_Numero_Doc, @Nombre, @Apellido1, @Apellido2, @Razon_Social, @ID_Tipo_Seguimiento, @Detalle_Tipo_Seguimiento, @ID_Contacto, @Contacto, @Fecha_Seguimiento, @Fecha_Prox_Seguimiento, @Descripcion, @Usuario, @Fecha_Registro) RETURNING \"ID_Seguimiento\"";
                        npgsqlCommand.Parameters.AddWithValue("@ID_Proyecto", (object)seguimiento.ID_Proyecto);
                        npgsqlCommand.Parameters.AddWithValue("@Nombre_Proyecto", (object)seguimiento.Nombre_Proyecto);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Cliente", (object)seguimiento.ID_Cliente);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Tipo_Documento", 0);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Numero_Doc", 0);
                        npgsqlCommand.Parameters.AddWithValue("@Nombre", "");
                        npgsqlCommand.Parameters.AddWithValue("@Apellido1", "");
                        npgsqlCommand.Parameters.AddWithValue("@Apellido2", "");
                        npgsqlCommand.Parameters.AddWithValue("@Razon_Social", "");
                        npgsqlCommand.Parameters.AddWithValue("@ID_Tipo_Seguimiento", (object)seguimiento.ID_Tipo_Seguimiento);
                        npgsqlCommand.Parameters.AddWithValue("@Detalle_Tipo_Seguimiento", (object)seguimiento.Detalle_Tipo_Seguimiento);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Contacto", (object)seguimiento.ID_Contacto);
                        npgsqlCommand.Parameters.AddWithValue("@Contacto", (object)seguimiento.Contacto);
                        npgsqlCommand.Parameters.AddWithValue("@Fecha_Seguimiento", (object)seguimiento.Fecha_Seguimiento);
                        npgsqlCommand.Parameters.AddWithValue("@Fecha_Prox_Seguimiento", (object)seguimiento.Fecha_Prox_Seguimiento);
                        npgsqlCommand.Parameters.AddWithValue("@Descripcion", (object)seguimiento.Descripcion);
                        npgsqlCommand.Parameters.AddWithValue("@Usuario", (object)seguimiento.Usuario_Creacion);
                        npgsqlCommand.Parameters.AddWithValue("@Fecha_Registro", (object)seguimiento.Fecha_Registro);
                        num = Convert.ToInt32(npgsqlCommand.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
            }
            return num;
        }


        public bool UpdateSeguimiento(CRM_Seguimiento seguimiento)
        {
            bool flag = false;
            try
            {
                using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(this.connectionString))
                {
                    npgsqlConnection.Open();
                    using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand())
                    {
                        npgsqlCommand.Connection = npgsqlConnection;
                        npgsqlCommand.CommandText = "UPDATE public.\"CRM_Seguimiento\" SET \"ID_Proyecto\" = @ID_Proyecto, \"Nombre_Proyecto\" = @Nombre_Proyecto, \"ID_Cliente\" = @ID_Cliente, \"ID_Tipo_Documento\" = @ID_Tipo_Documento, \"ID_Numero_Doc\" = @ID_Numero_Doc, \"Nombre\" = @Nombre, \"Apellido1\" = @Apellido1, \"Apellido2\" = @Apellido2, \"Razon_Social\" = @Razon_Social,  \"ID_Tipo_Seguimiento\" = @ID_Tipo_Seguimiento, \"Detalle_Tipo_Seguimiento\" = @Detalle_Tipo_Seguimiento, \"ID_Contacto\" = @ID_Contacto, \"Contacto\" = @Contacto, \"Fecha_Seguimiento\" = @Fecha_Seguimiento, \"Fecha_Prox_Seguimiento\" = @Fecha_Prox_Seguimiento, \"Descripcion\" = @Descripcion WHERE \"ID_Seguimiento\" = @ID_Seguimiento";
                        npgsqlCommand.Parameters.AddWithValue("@ID_Proyecto", (object)seguimiento.ID_Proyecto);
                        npgsqlCommand.Parameters.AddWithValue("@Nombre_Proyecto", (object)seguimiento.Nombre_Proyecto);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Cliente", (object)seguimiento.ID_Cliente);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Tipo_Documento", 0);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Numero_Doc", 0);
                        npgsqlCommand.Parameters.AddWithValue("@Nombre", "");
                        npgsqlCommand.Parameters.AddWithValue("@Apellido1", "");
                        npgsqlCommand.Parameters.AddWithValue("@Apellido2", "");
                        npgsqlCommand.Parameters.AddWithValue("@Razon_Social", "");
                        npgsqlCommand.Parameters.AddWithValue("@ID_Tipo_Seguimiento", (object)seguimiento.ID_Tipo_Seguimiento);
                        npgsqlCommand.Parameters.AddWithValue("@Detalle_Tipo_Seguimiento", (object)seguimiento.Detalle_Tipo_Seguimiento);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Contacto", (object)seguimiento.ID_Contacto);
                        npgsqlCommand.Parameters.AddWithValue("@Contacto", (object)seguimiento.Contacto);
                        npgsqlCommand.Parameters.AddWithValue("@Fecha_Seguimiento", (object)seguimiento.Fecha_Seguimiento);
                        npgsqlCommand.Parameters.AddWithValue("@Fecha_Prox_Seguimiento", (object)seguimiento.Fecha_Prox_Seguimiento);
                        npgsqlCommand.Parameters.AddWithValue("@Descripcion", (object)seguimiento.Descripcion);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Seguimiento", (object)seguimiento.ID_Seguimiento);
                        flag = npgsqlCommand.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
            }
            return flag;
        }


        public void DeleteSeguimiento(Decimal seguimientoID)
        {
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(this.connectionString))
            {
                npgsqlConnection.Open();
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand())
                {
                    npgsqlCommand.Connection = npgsqlConnection;
                    npgsqlCommand.CommandText = "DELETE FROM public.\"CRM_Seguimiento\" WHERE \"ID_Seguimiento\" = @ID_Seguimiento";
                    npgsqlCommand.Parameters.AddWithValue("@ID_Seguimiento", (object)seguimientoID);
                    npgsqlCommand.ExecuteNonQuery();
                }
            }
        }

        public CRM_Seguimiento SelectSeguimiento(decimal seguimientoID)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM public.\"CRM_Seguimiento\" WHERE \"ID_Seguimiento\" = " + seguimientoID;

                    // Set parameter
                    //cmd.Parameters.AddWithValue("@ID_Seguimiento", seguimientoID);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapSeguimientoFromDataReader(reader);
                        }
                    }
                }

                return null;
            }
        }

        private CRM_Seguimiento MapSeguimientoFromDataReader(IDataReader reader)
        {
            try
            {
                return new CRM_Seguimiento
                {
                    ID_Seguimiento = Convert.ToDecimal(reader["ID_Seguimiento"]),
                    ID_Proyecto = Convert.ToDecimal(reader["ID_Proyecto"]),
                    Nombre_Proyecto = reader["Nombre_Proyecto"].ToString(),
                    ID_Cliente = reader["ID_Cliente"].ToString(),
                    ID_Tipo_Documento = reader["ID_Tipo_Documento"].ToString(),
                    ID_Numero_Doc = Convert.ToDecimal(reader["ID_Numero_Doc"]),
                    Nombre = reader["Nombre"].ToString(),
                    Apellido1 = reader["Apellido1"].ToString(),
                    Apellido2 = reader["Apellido2"].ToString(),
                    Razon_Social = reader["Razon_Social"].ToString(),
                    Usuario_Creacion = reader["Usuario"].ToString(),
                    ID_Tipo_Seguimiento = reader["ID_Tipo_Seguimiento"].ToString(),
                    Detalle_Tipo_Seguimiento = reader["Detalle_Tipo_Seguimiento"].ToString(),
                    ID_Contacto = reader["ID_Contacto"].ToString(),
                    Contacto = reader["Contacto"].ToString(),
                    Fecha_Seguimiento = Convert.ToDateTime(reader["Fecha_Seguimiento"]),
                    Fecha_Prox_Seguimiento = Convert.ToDateTime(reader["Fecha_Prox_Seguimiento"]),
                    Descripcion = reader["Descripcion"].ToString()
                };
            }
            catch (InvalidCastException ex)
            {
                // Manejar la excepción específica si hay problemas de conversión de tipos
                // Aquí puedes registrar o manejar el error de alguna manera
                return null; // O lanza la excepción nuevamente si prefieres
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales, si es necesario
                // Aquí puedes registrar o manejar el error de alguna manera
                return null; // O lanza la excepción nuevamente si prefieres
            }
        }


        public class CRM_Seguimiento
        {
            public Decimal ID_Seguimiento { get; set; }
            public Decimal ID_Proyecto { get; set; }
            public string Nombre_Proyecto { get; set; }
            public string ID_Cliente { get; set; }
            public string ID_Tipo_Documento { get; set; }
            public Decimal ID_Numero_Doc { get; set; }
            public string Nombre { get; set; }
            public string Apellido1 { get; set; }
            public string Apellido2 { get; set; }
            public string Razon_Social { get; set; }
            public string Usuario_Creacion { get; set; }
            public string ID_Tipo_Seguimiento { get; set; }
            public string Detalle_Tipo_Seguimiento { get; set; }
            public string ID_Contacto { get; set; }
            public string Contacto { get; set; }
            public DateTime Fecha_Seguimiento { get; set; }
            public DateTime Fecha_Prox_Seguimiento { get; set; }
            public string Descripcion { get; set; }
            public DateTime Fecha_Registro { get; set; }
        }

    }
}
