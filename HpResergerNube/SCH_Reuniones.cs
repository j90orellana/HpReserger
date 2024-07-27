using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class SCH_Reuniones
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Participantes { get; set; }
        public int Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        private string connectionString;

        public SCH_Reuniones()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public int InsertReunion(SCH_Reuniones reunion)
        {
            int newId = 0;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"SCH_Reuniones\"(\"Fecha\", \"Cliente\", \"Participantes\", \"Estado\", \"FechaCreacion\") VALUES (@Fecha, @Cliente, @Participantes, @Estado, @FechaCreacion) RETURNING \"id\"";
                    cmd.Parameters.AddWithValue("@Fecha", reunion.Fecha);
                    cmd.Parameters.AddWithValue("@Cliente", reunion.Cliente);
                    cmd.Parameters.AddWithValue("@Participantes", reunion.Participantes);
                    cmd.Parameters.AddWithValue("@Estado", reunion.Estado);
                    cmd.Parameters.AddWithValue("@FechaCreacion", reunion.FechaCreacion);

                    newId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return newId;
        }

        public SCH_Reuniones ReadReunion(int id)
        {
            SCH_Reuniones reunion = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Reuniones\" WHERE \"id\" = @ID", connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            reunion = new SCH_Reuniones
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Cliente = reader["Cliente"].ToString(),
                                Participantes = reader["Participantes"].ToString(),
                                Estado = Convert.ToInt32(reader["Estado"]),
                                FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"])
                            };
                        }
                    }
                }
            }

            return reunion;
        }

        public bool UpdateReunion(SCH_Reuniones reunion)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"SCH_Reuniones\" SET \"Fecha\" = @Fecha, \"Cliente\" = @Cliente, \"Participantes\" = @Participantes, \"Estado\" = @Estado, \"FechaCreacion\" = @FechaCreacion WHERE \"id\" = @ID";
                    cmd.Parameters.AddWithValue("@ID", reunion.ID);
                    cmd.Parameters.AddWithValue("@Fecha", reunion.Fecha);
                    cmd.Parameters.AddWithValue("@Cliente", reunion.Cliente);
                    cmd.Parameters.AddWithValue("@Participantes", reunion.Participantes);
                    cmd.Parameters.AddWithValue("@Estado", reunion.Estado);
                    cmd.Parameters.AddWithValue("@FechaCreacion", reunion.FechaCreacion);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    success = rowsAffected > 0;
                }
            }

            return success;
        }
        public bool UpdateReunionEliminar(int id)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"SCH_Reuniones\" SET \"Estado\" = @Estado WHERE \"id\" = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Estado", 0);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    success = rowsAffected > 0;
                }
            }

            return success;
        }

        public void DeleteReunion(int id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"SCH_Reuniones\" WHERE \"id\" = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllReuniones()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Reuniones\"", connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
        public DataTable GetReunionesByClienteYFecha( DateTime? fechaInicio, DateTime? fechaFin)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT 
                r.id,
                CASE c.""ID_Tipo_persona"" 
                    WHEN 'J' THEN c.""Razon_Social""
                    ELSE CONCAT(c.""Nombre"", ' ', c.""Apellido1"", ' ', c.""Apellido2"")
                END AS nombre,
                r.""Fecha"", 
                r.""Cliente"", 
                r.""Participantes"", 
                r.""Estado"", 
                r.""FechaCreacion""
            FROM public.""SCH_Reuniones"" r
            INNER JOIN public.""CRM_Cliente"" c ON r.""Cliente"" = c.""ID_Cliente""
            WHERE r.""Estado"" = 1";

                // Añadir condiciones de fecha si se proporcionan
                if (fechaInicio.HasValue)
                {
                    query += " AND r.\"Fecha\" >= @FechaInicio";
                }
                if (fechaFin.HasValue)
                {
                    query += " AND r.\"Fecha\" <= @FechaFin";
                }

                query += " ORDER BY r.\"Fecha\" DESC";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    
                    if (fechaInicio.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio.Value);
                    }
                    if (fechaFin.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin.Value);
                    }

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public DataTable GetReunionesByCliente(string cliente)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Reuniones\" WHERE \"Cliente\" = @Cliente and \"Estado\"=1", connection))
                {
                    cmd.Parameters.AddWithValue("@Cliente", cliente);

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
