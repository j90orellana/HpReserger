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
        public int idcalendario { get; set; }
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
                    cmd.CommandText = "INSERT INTO public.\"SCH_Reuniones\"(\"idcalendario\",\"Fecha\", \"Cliente\", \"Participantes\", \"Estado\", \"FechaCreacion\") VALUES (@idcalendario,@Fecha, @Cliente, @Participantes, @Estado, @FechaCreacion) RETURNING \"id\"";
                    cmd.Parameters.AddWithValue("@Fecha", reunion.Fecha);
                    cmd.Parameters.AddWithValue("@Cliente", reunion.Cliente);
                    cmd.Parameters.AddWithValue("@Participantes", reunion.Participantes);
                    cmd.Parameters.AddWithValue("@Estado", reunion.Estado);
                    cmd.Parameters.AddWithValue("@FechaCreacion", reunion.FechaCreacion);
                    cmd.Parameters.AddWithValue("@idcalendario", reunion.idcalendario);

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
                                FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]),
                                idcalendario = Convert.ToInt32(reader["idcalendario"])
                            };
                        }
                    }
                }
            }

            return reunion;
        }

        public DataTable FilterReunionesBySeguimiento(DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(this.connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand selectCommand = new NpgsqlCommand(
                        "SELECT " +
                        "  reu.id,  det.fkid, " +
                        "    det.\"Accion\", " +
                        "    det.\"Nivel\", " +
                        "    det.\"Seguimiento\", " +
                        "    det.\"Responsable_Oficina\", " +
                        "    det.\"Responsable_Cliente\", " +
                        "    det.\"Objetivo_Relacionado\", " +
                        "    det.idstatus, " +
                        "    concat(con.\"Nombre\", ' ', con.\"Apellido1\", ' ', con.\"Apellido2\") AS contacto, " +
                        "    clie.\"Razon_Social\" " +
                        "FROM " +
                        "    public.\"SCH_Reuniones_det\" det " +
                        "LEFT JOIN " +
                        "    \"SCH_Reuniones\" reu ON reu.id = det.\"fkid\" " +
                        "LEFT JOIN " +
                        "    \"CRM_Cliente\" clie ON clie.\"ID_Cliente\" = reu.\"Cliente\" " +
                        "LEFT JOIN " +
                        "    \"CRM_Contacto\" con ON con.\"ID_Contacto\" = det.\"Responsable_Cliente\" " +
                        "WHERE " +
                        "  \"Accion\" not like 'Ingrese Accion' and  det.\"Seguimiento\" >= @StartDate AND " +
                        "    det.\"Seguimiento\" <= @EndDate " +
                        "ORDER BY " +
                        "    det.\"Seguimiento\" DESC", connection))
                    {
                        selectCommand.Parameters.AddWithValue("@StartDate", startDate);
                        selectCommand.Parameters.AddWithValue("@EndDate", endDate);

                        using (NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(selectCommand))
                        {
                            npgsqlDataAdapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
            }
            return dataTable;
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
                    cmd.CommandText = "UPDATE public.\"SCH_Reuniones\" SET \"idcalendario\" = @idcalendario, \"Fecha\" = @Fecha, \"Cliente\" = @Cliente, \"Participantes\" = @Participantes, \"Estado\" = @Estado, \"FechaCreacion\" = @FechaCreacion WHERE \"id\" = @ID";
                    cmd.Parameters.AddWithValue("@ID", reunion.ID);
                    cmd.Parameters.AddWithValue("@Fecha", reunion.Fecha);
                    cmd.Parameters.AddWithValue("@Cliente", reunion.Cliente);
                    cmd.Parameters.AddWithValue("@Participantes", reunion.Participantes);
                    cmd.Parameters.AddWithValue("@Estado", reunion.Estado);
                    cmd.Parameters.AddWithValue("@FechaCreacion", reunion.FechaCreacion);
                    cmd.Parameters.AddWithValue("@idcalendario", reunion.idcalendario);
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
        public DataTable GetReunionesByClienteYFecha(DateTime? fechaInicio, DateTime? fechaFin)
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
                r.""Estado"",    r.""idcalendario"", 
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
