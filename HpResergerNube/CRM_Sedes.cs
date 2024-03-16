using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_Sedes
    {
        public string ID_Sedes { get; set; }
        public string Nombre { get; set; }
        public string Dirección { get; set; }
        public string Interior { get; set; }
        public string Piso { get; set; }
        public decimal ID_Codigo_postal { get; set; }
        public decimal Telefono { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public decimal Usuario_Creacion { get; set; }
        public string Observaciones { get; set; }

        private string connectionString;

        public CRM_Sedes()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public string InsertSede(CRM_Sedes sede)
        {
            string newIDSede = "";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Obtener el último ID_Sedes de la base de datos
                string queryLastID = "SELECT MAX(\"ID_Sedes\") FROM public.\"CRM_Sedes\"";
                using (NpgsqlCommand cmdLastID = new NpgsqlCommand(queryLastID, connection))
                {
                    object lastID = cmdLastID.ExecuteScalar();
                    int lastIDNumber = 0;
                    if (lastID != DBNull.Value)
                    {
                        string lastIDString = lastID.ToString().Substring(1); // Ignorar el primer carácter "S"
                        if (int.TryParse(lastIDString, out lastIDNumber))
                        {
                            lastIDNumber++; // Incrementar el último ID
                        }
                    }
                    else
                    {
                        lastIDNumber = 1; // Si no hay registros, comenzar desde 1
                    }

                    // Formar el nuevo ID_Sedes
                    newIDSede = "S" + lastIDNumber.ToString("D4");
                }

                // Insertar la nueva sede con el nuevo ID_Sedes
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Sedes\"(\"ID_Sedes\", \"Nombre\", \"Dirección\", \"Interior\", \"Piso\", \"ID_Codigo_postal\", \"Telefono\", \"Fecha_Creacion\", \"Usuario_Creacion\", \"Observaciones\") " +
                        "VALUES (@ID_Sedes, @Nombre, @Dirección, @Interior, @Piso, @ID_Codigo_postal, @Telefono, @Fecha_Creacion, @Usuario_Creacion, @Observaciones)";
                    cmd.Parameters.AddWithValue("@ID_Sedes", newIDSede);
                    cmd.Parameters.AddWithValue("@Nombre", sede.Nombre);
                    cmd.Parameters.AddWithValue("@Dirección", sede.Dirección);
                    cmd.Parameters.AddWithValue("@Interior", sede.Interior ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Piso", sede.Piso ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Codigo_postal", sede.ID_Codigo_postal);
                    cmd.Parameters.AddWithValue("@Telefono", sede.Telefono);
                    cmd.Parameters.AddWithValue("@Fecha_Creacion", sede.Fecha_Creacion);
                    cmd.Parameters.AddWithValue("@Usuario_Creacion", sede.Usuario_Creacion);
                    cmd.Parameters.AddWithValue("@Observaciones", sede.Observaciones ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }

            return newIDSede; // Retornar el nuevo ID_Sedes generado
        }

        public CRM_Sedes ReadSede(string idSede)
        {
            CRM_Sedes sede = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Sedes\" WHERE \"ID_Sedes\" = @ID_Sedes", connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Sedes", idSede);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            sede = new CRM_Sedes
                            {
                                ID_Sedes = reader["ID_Sedes"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Dirección = reader["Dirección"].ToString(),
                                Interior = reader["Interior"]?.ToString(),
                                Piso = reader["Piso"]?.ToString(),
                                ID_Codigo_postal = Convert.ToInt32(reader["ID_Codigo_postal"]),
                                Telefono = Convert.ToDecimal(reader["Telefono"]),
                                Fecha_Creacion = Convert.ToDateTime(reader["Fecha_Creacion"]),
                                Usuario_Creacion = Convert.ToInt32(reader["Usuario_Creacion"]),
                                Observaciones = reader["Observaciones"]?.ToString()
                            };
                        }
                    }
                }
            }

            return sede;
        }
        public bool UpdateSede(CRM_Sedes sede)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"CRM_Sedes\" SET \"Nombre\" = @Nombre, \"Dirección\" = @Dirección, \"Interior\" = @Interior, \"Piso\" = @Piso, " +
                        "\"ID_Codigo_postal\" = @ID_Codigo_postal, \"Telefono\" = @Telefono, \"Fecha_Creacion\" = @Fecha_Creacion, \"Usuario_Creacion\" = @Usuario_Creacion, " +
                        "\"Observaciones\" = @Observaciones WHERE \"ID_Sedes\" = @ID_Sedes";
                    cmd.Parameters.AddWithValue("@ID_Sedes", sede.ID_Sedes);
                    cmd.Parameters.AddWithValue("@Nombre", sede.Nombre);
                    cmd.Parameters.AddWithValue("@Dirección", sede.Dirección);
                    cmd.Parameters.AddWithValue("@Interior", sede.Interior ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Piso", sede.Piso ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ID_Codigo_postal", sede.ID_Codigo_postal);
                    cmd.Parameters.AddWithValue("@Telefono", sede.Telefono);
                    cmd.Parameters.AddWithValue("@Fecha_Creacion", sede.Fecha_Creacion);
                    cmd.Parameters.AddWithValue("@Usuario_Creacion", sede.Usuario_Creacion);
                    cmd.Parameters.AddWithValue("@Observaciones", sede.Observaciones ?? (object)DBNull.Value);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Verificar si la actualización fue exitosa
                    success = rowsAffected > 0;
                }
            }

            return success;
        }

        public DataTable FilterSedesByDateRange(DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM public.\"CRM_Sedes\" WHERE \"Fecha_Creacion\" >= @StartDate AND \"Fecha_Creacion\" <= @EndDate ORDER BY \"Fecha_Creacion\" DESC";

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
        public void DeleteSede()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Sedes\" WHERE \"ID_Sedes\" = @ID_Sedes";
                    cmd.Parameters.AddWithValue("@ID_Sedes", ID_Sedes);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllSedes()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Sedes\"", connection))
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
