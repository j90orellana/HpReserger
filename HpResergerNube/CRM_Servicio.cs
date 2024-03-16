// Decompiled with JetBrains decompiler
// Type: HpResergerNube.CRM_Servicio
// Assembly: HpResergerNube, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5C6333DA-4256-4581-8176-EBEE3D8E696F
// Assembly location: C:\Users\user\OneDrive\Escritorio\HpResergerNubex.dll

using Npgsql;
using System;
using System.Data;

namespace HpResergerNube
{
    public class CRM_Servicio
    {
        private string connectionString;
        public class Servicio
        {
            public string ID_Servicio { get; set; }

            public string Detalle_Servicio { get; set; }

            public string Detalle_1 { get; set; }

            public string Detalle_2 { get; set; }

            public string Detalle_3 { get; set; }

            public string Detalle_4 { get; set; }

            public string Detalle_5 { get; set; }

            public string Detalle_6 { get; set; }

            public string Detalle_7 { get; set; }

            public string Detalle_8 { get; set; }

            public string Precio_1 { get; set; }

            public string Precio_2 { get; set; }

            public string Precio_3 { get; set; }

            public string Usuario { get; set; }

            public DateTime? Fecha_creacion { get; set; }

            public byte[] Imagen { get; set; }
        }
        public CRM_Servicio() => this.connectionString = new DLConexion().GetConnectionString();

        public string InsertServicio(Servicio servicio)
        {
            string str1 = string.Empty;
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(this.connectionString))
            {
                npgsqlConnection.Open();
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand())
                {
                    npgsqlCommand.Connection = npgsqlConnection;
                    npgsqlCommand.CommandText = "SELECT MAX(\"ID_Servicio\") FROM public.\"CRM_Servicio\"";
                    string str2 = npgsqlCommand.ExecuteScalar() as string;
                    int result = 0;
                    if (!string.IsNullOrEmpty(str2))
                        int.TryParse(str2.Substring(3), out result);
                    ++result;
                    str1 = "SV" + result.ToString().PadLeft(5, '0');
                    npgsqlCommand.CommandText = "INSERT INTO public.\"CRM_Servicio\"(\"ID_Servicio\", \"Detalle_Servicio\", \"Detalle_1\", \"Detalle_2\", \"Detalle_3\", \"Detalle_4\", \"Detalle_5\", \"Detalle_6\", \"Detalle_7\", \"Detalle_8\", \"Precio_1\", \"Precio_2\", \"Precio_3\", \"Usuario\", \"Fecha_creacion\", \"Imagen\") VALUES (@ID_Servicio, @Detalle_Servicio, @Detalle_1, @Detalle_2, @Detalle_3, @Detalle_4, @Detalle_5, @Detalle_6, @Detalle_7, @Detalle_8, @Precio_1, @Precio_2, @Precio_3, @Usuario, @Fecha_creacion, @Imagen)";
                    npgsqlCommand.Parameters.AddWithValue("@ID_Servicio", (object)str1);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_Servicio", (object)servicio.Detalle_Servicio);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_1", (object)servicio.Detalle_1);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_2", (object)servicio.Detalle_2 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_3", (object)servicio.Detalle_3 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_4", (object)servicio.Detalle_4 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_5", (object)servicio.Detalle_5 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_6", (object)servicio.Detalle_6 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_7", (object)servicio.Detalle_7 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_8", (object)servicio.Detalle_8 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Precio_1", (object)servicio.Precio_1);
                    npgsqlCommand.Parameters.AddWithValue("@Precio_2", (object)servicio.Precio_2 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Precio_3", (object)servicio.Precio_3 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Usuario", (object)servicio.Usuario ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Fecha_creacion", (object)servicio.Fecha_creacion ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Imagen", (object)servicio.Imagen ?? (object)DBNull.Value);
                    npgsqlCommand.ExecuteNonQuery();
                }
            }
            return str1;
        }

        public void UpdateServicio(Servicio servicio)
        {
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(this.connectionString))
            {
                npgsqlConnection.Open();
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand())
                {
                    npgsqlCommand.Connection = npgsqlConnection;
                    npgsqlCommand.CommandText = "UPDATE public.\"CRM_Servicio\" SET \"Detalle_Servicio\" = @Detalle_Servicio, \"Detalle_1\" = @Detalle_1, \"Detalle_2\" = @Detalle_2, \"Detalle_3\" = @Detalle_3, \"Detalle_4\" = @Detalle_4, \"Detalle_5\" = @Detalle_5, \"Detalle_6\" = @Detalle_6, \"Detalle_7\" = @Detalle_7, \"Detalle_8\" = @Detalle_8, \"Precio_1\" = @Precio_1, \"Precio_2\" = @Precio_2, \"Precio_3\" = @Precio_3, \"Usuario\" = @Usuario, \"Fecha_creacion\" = @Fecha_creacion, \"Imagen\" = @Imagen WHERE \"ID_Servicio\" = @ID_Servicio";
                    npgsqlCommand.Parameters.AddWithValue("@ID_Servicio", (object)servicio.ID_Servicio);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_Servicio", (object)servicio.Detalle_Servicio);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_1", (object)servicio.Detalle_1);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_2", (object)servicio.Detalle_2 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_3", (object)servicio.Detalle_3 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_4", (object)servicio.Detalle_4 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_5", (object)servicio.Detalle_5 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_6", (object)servicio.Detalle_6 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_7", (object)servicio.Detalle_7 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Detalle_8", (object)servicio.Detalle_8 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Precio_1", (object)servicio.Precio_1);
                    npgsqlCommand.Parameters.AddWithValue("@Precio_2", (object)servicio.Precio_2 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Precio_3", (object)servicio.Precio_3 ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Usuario", (object)servicio.Usuario ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Fecha_creacion", (object)servicio.Fecha_creacion ?? (object)DBNull.Value);
                    npgsqlCommand.Parameters.AddWithValue("@Imagen", (object)servicio.Imagen ?? (object)DBNull.Value);
                    npgsqlCommand.ExecuteNonQuery();
                }
            }
        }

        public void DeleteServicio(string idServicio)
        {
            using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(this.connectionString))
            {
                npgsqlConnection.Open();
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand())
                {
                    npgsqlCommand.Connection = npgsqlConnection;
                    npgsqlCommand.CommandText = "DELETE FROM public.\"CRM_Servicio\" WHERE \"ID_Servicio\" = @ID_Servicio";
                    npgsqlCommand.Parameters.AddWithValue("@ID_Servicio", (object)idServicio);
                    npgsqlCommand.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllServicios()
        {
            DataTable dataTable = new DataTable();
            using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
            {
                connection.Open();
                using (NpgsqlCommand selectCommand = new NpgsqlCommand("SELECT * FROM public.\"CRM_Servicio\"", connection))
                {
                    using (NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(selectCommand))
                        npgsqlDataAdapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        public Servicio ReadServicioById(string idServicio)
        {
            Servicio servicio = (Servicio)null;
            using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
            {
                connection.Open();
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand("SELECT * FROM public.\"CRM_Servicio\" WHERE \"ID_Servicio\" = @ID_Servicio", connection))
                {
                    npgsqlCommand.Parameters.AddWithValue("@ID_Servicio", (object)idServicio);
                    using (NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader())
                    {
                        if (npgsqlDataReader.Read())
                            servicio = new Servicio()
                            {
                                ID_Servicio = npgsqlDataReader["ID_Servicio"].ToString(),
                                Detalle_Servicio = npgsqlDataReader["Detalle_Servicio"].ToString(),
                                Detalle_1 = npgsqlDataReader["Detalle_1"].ToString(),
                                Detalle_2 = npgsqlDataReader["Detalle_2"].ToString(),
                                Detalle_3 = npgsqlDataReader["Detalle_3"].ToString(),
                                Detalle_4 = npgsqlDataReader["Detalle_4"].ToString(),
                                Detalle_5 = npgsqlDataReader["Detalle_5"].ToString(),
                                Detalle_6 = npgsqlDataReader["Detalle_6"].ToString(),
                                Detalle_7 = npgsqlDataReader["Detalle_7"].ToString(),
                                Detalle_8 = npgsqlDataReader["Detalle_8"].ToString(),
                                Precio_1 = npgsqlDataReader["Precio_1"].ToString(),
                                Precio_2 = npgsqlDataReader["Precio_2"].ToString(),
                                Precio_3 = npgsqlDataReader["Precio_3"].ToString(),
                                Usuario = npgsqlDataReader["Usuario"].ToString(),
                                Fecha_creacion = npgsqlDataReader["Fecha_creacion"] == DBNull.Value ? new DateTime?() : (DateTime?)npgsqlDataReader["Fecha_creacion"],
                                Imagen = npgsqlDataReader["Imagen"] as byte[]
                            };
                    }
                }
            }
            return servicio;
        }
    }
}
