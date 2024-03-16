// Decompiled with JetBrains decompiler
// Type: HpResergerNube.CRM_SeguimientoRepository
// Assembly: HpResergerNube, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5C6333DA-4256-4581-8176-EBEE3D8E696F
// Assembly location: C:\Users\user\OneDrive\Escritorio\HpResergerNubex.dll

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
            }
            return dataTable;
        }

        public DataTable FilterSeguimientosByDateRange(
          DateTime startDate,
          DateTime endDate,
          string userID,
          string projectID)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand selectCommand = new NpgsqlCommand("\r\n            SELECT \r\n                s.*, \r\n                u.\"Nombre\" AS \"Nombre_Usuario\"\r\n            FROM \r\n                public.\"CRM_Seguimiento\" AS s\r\n            INNER JOIN \r\n                public.\"CRM_Usuario\" AS u ON s.\"Usuario_Creacion\" = u.\"ID_Usuario\"\r\n            WHERE \r\n                (@UserID = '0' OR u.\"ID_Usuario\" = @UserID) AND\r\n                (@ProjectID = 0 OR s.\"ID_Proyecto\" = @ProjectID) AND\r\n                s.\"Fecha_Seguimiento\" >= @StartDate AND \r\n                s.\"Fecha_Seguimiento\" <= @EndDate \r\n            ORDER BY \r\n                s.\"Fecha_Seguimiento\" DESC", connection))
                    {
                        selectCommand.Parameters.AddWithValue("@StartDate", (object)startDate);
                        selectCommand.Parameters.AddWithValue("@EndDate", (object)endDate);
                        selectCommand.Parameters.AddWithValue("@UserID", (object)userID);
                        selectCommand.Parameters.AddWithValue("@ProjectID", (object)Convert.ToInt32(projectID));
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

        public int InsertSeguimiento(
          CRM_SeguimientoRepository.CRM_Seguimiento seguimiento)
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
                        npgsqlCommand.CommandText = "INSERT INTO public.\"CRM_Seguimiento\" (\"ID_Seguimiento\", \"ID_Proyecto\", \"Nombre_Proyecto\", \"Usuario_Creacion\", \"ID_Tipo_Seguimiento\", \"Detalle_Tipo_Seguimiento\", \"ID_Contacto\", \"Contacto\", \"Fecha_Seguimiento\", \"Fecha_Prox_Seguimiento\", \"Descripción\") VALUES ((SELECT COALESCE(MAX(\"ID_Seguimiento\"), 0) + 1 FROM public.\"CRM_Seguimiento\"), @ID_Proyecto, @Nombre_Proyecto, @Usuario_Creacion, @ID_Tipo_Seguimiento, @Detalle_Tipo_Seguimiento, @ID_Contacto, @Contacto, @Fecha_Seguimiento, @Fecha_Prox_Seguimiento, @Descripcion) RETURNING \"ID_Seguimiento\"";
                        npgsqlCommand.Parameters.AddWithValue("@ID_Proyecto", (object)seguimiento.ID_Proyecto);
                        npgsqlCommand.Parameters.AddWithValue("@Nombre_Proyecto", (object)seguimiento.Nombre_Proyecto);
                        npgsqlCommand.Parameters.AddWithValue("@Usuario_Creacion", (object)seguimiento.Usuario_Creacion);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Tipo_Seguimiento", (object)seguimiento.ID_Tipo_Seguimiento);
                        npgsqlCommand.Parameters.AddWithValue("@Detalle_Tipo_Seguimiento", (object)seguimiento.Detalle_Tipo_Seguimiento);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Contacto", (object)seguimiento.ID_Contacto);
                        npgsqlCommand.Parameters.AddWithValue("@Contacto", (object)seguimiento.Contacto);
                        npgsqlCommand.Parameters.AddWithValue("@Fecha_Seguimiento", (object)seguimiento.Fecha_Seguimiento);
                        npgsqlCommand.Parameters.AddWithValue("@Fecha_Prox_Seguimiento", (object)seguimiento.Fecha_Prox_Seguimiento);
                        npgsqlCommand.Parameters.AddWithValue("@Descripcion", (object)seguimiento.Descripción);
                        num = Convert.ToInt32(npgsqlCommand.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return num;
        }

        public bool UpdateSeguimiento(
          CRM_SeguimientoRepository.CRM_Seguimiento seguimiento)
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
                        npgsqlCommand.CommandText = "UPDATE public.\"CRM_Seguimiento\" SET \"ID_Proyecto\" = @ID_Proyecto, \"Nombre_Proyecto\" = @Nombre_Proyecto, \"Usuario_Creacion\" = @Usuario_Creacion, \"ID_Tipo_Seguimiento\" = @ID_Tipo_Seguimiento, \"Detalle_Tipo_Seguimiento\" = @Detalle_Tipo_Seguimiento, \"ID_Contacto\" = @ID_Contacto, \"Contacto\" = @Contacto, \"Fecha_Seguimiento\" = @Fecha_Seguimiento, \"Fecha_Prox_Seguimiento\" = @Fecha_Prox_Seguimiento, \"Descripción\" = @Descripcion WHERE \"ID_Seguimiento\" = @ID_Seguimiento";
                        npgsqlCommand.Parameters.AddWithValue("@ID_Seguimiento", (object)seguimiento.ID_Seguimiento);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Proyecto", (object)seguimiento.ID_Proyecto);
                        npgsqlCommand.Parameters.AddWithValue("@Nombre_Proyecto", (object)seguimiento.Nombre_Proyecto);
                        npgsqlCommand.Parameters.AddWithValue("@Usuario_Creacion", (object)seguimiento.Usuario_Creacion);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Tipo_Seguimiento", (object)seguimiento.ID_Tipo_Seguimiento);
                        npgsqlCommand.Parameters.AddWithValue("@Detalle_Tipo_Seguimiento", (object)seguimiento.Detalle_Tipo_Seguimiento);
                        npgsqlCommand.Parameters.AddWithValue("@ID_Contacto", (object)seguimiento.ID_Contacto);
                        npgsqlCommand.Parameters.AddWithValue("@Contacto", (object)seguimiento.Contacto);
                        npgsqlCommand.Parameters.AddWithValue("@Fecha_Seguimiento", (object)seguimiento.Fecha_Seguimiento);
                        npgsqlCommand.Parameters.AddWithValue("@Fecha_Prox_Seguimiento", (object)seguimiento.Fecha_Prox_Seguimiento);
                        npgsqlCommand.Parameters.AddWithValue("@Descripcion", (object)seguimiento.Descripción);
                        flag = npgsqlCommand.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
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
            return new CRM_Seguimiento
            {
                ID_Seguimiento = Convert.ToDecimal(reader["ID_Seguimiento"]),
                ID_Proyecto = Convert.ToDecimal(reader["ID_Proyecto"]),
                Nombre_Proyecto = reader["Nombre_Proyecto"].ToString(),
                Usuario_Creacion = reader["Usuario_Creacion"].ToString(),
                ID_Tipo_Seguimiento = reader["ID_Tipo_Seguimiento"].ToString(),
                Detalle_Tipo_Seguimiento = reader["Detalle_Tipo_Seguimiento"].ToString(),
                ID_Contacto = reader["ID_Contacto"].ToString(),
                Contacto = reader["Contacto"].ToString(),
                Fecha_Seguimiento = Convert.ToDateTime(reader["Fecha_Seguimiento"]),
                Fecha_Prox_Seguimiento = Convert.ToDateTime(reader["Fecha_Prox_Seguimiento"]),
                Descripción = reader["Descripcion"].ToString()
            };
        }
        public class CRM_Seguimiento
        {
            public Decimal ID_Seguimiento { get; set; }

            public Decimal ID_Proyecto { get; set; }

            public string Nombre_Proyecto { get; set; }

            public string Usuario_Creacion { get; set; }

            public string ID_Tipo_Seguimiento { get; set; }

            public string Detalle_Tipo_Seguimiento { get; set; }

            public string ID_Contacto { get; set; }

            public string Contacto { get; set; }

            public DateTime Fecha_Seguimiento { get; set; }

            public DateTime Fecha_Prox_Seguimiento { get; set; }

            public string Descripción { get; set; }
        }
    }
}
