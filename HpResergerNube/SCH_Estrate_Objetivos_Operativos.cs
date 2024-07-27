using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class SCH_Estrate_Objetivos_Operativos
    {
        public int ID { get; set; }
        public int FkId { get; set; }
        public string Nombre { get; set; }
        public string DetalleObjetivo { get; set; }
        public string Status { get; set; }
        public DateTime? FechaRecordatorio { get; set; }
        public string Comentario { get; set; }
        public int? ObjetivoRelacionado { get; set; }
        public string Responsable { get; set; }
        public int Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        private string connectionString;

        public SCH_Estrate_Objetivos_Operativos()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertObjetivoOperativo(SCH_Estrate_Objetivos_Operativos objetivoOperativo)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"SCH_Estrate_Objetivos_Operativos\"(\"fkid\", \"Nombre\", \"DetalleObjetivo\", \"status\", \"fechaRecordatorio\", \"comentario\", \"objetivorelacionado\", \"responsable\", \"estado\", \"fechacreacion\") VALUES (@FkId, @Nombre, @DetalleObjetivo, @Status, @FechaRecordatorio, @Comentario, @ObjetivoRelacionado, @Responsable, @Estado, @FechaCreacion)";
                    cmd.Parameters.AddWithValue("@FkId", objetivoOperativo.FkId);
                    cmd.Parameters.AddWithValue("@Nombre", objetivoOperativo.Nombre);
                    cmd.Parameters.AddWithValue("@DetalleObjetivo", objetivoOperativo.DetalleObjetivo);
                    cmd.Parameters.AddWithValue("@Status", objetivoOperativo.Status);
                    cmd.Parameters.AddWithValue("@FechaRecordatorio", (object)objetivoOperativo.FechaRecordatorio ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Comentario", (object)objetivoOperativo.Comentario ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ObjetivoRelacionado", (object)objetivoOperativo.ObjetivoRelacionado ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Responsable", objetivoOperativo.Responsable);
                    cmd.Parameters.AddWithValue("@Estado", objetivoOperativo.Estado);
                    cmd.Parameters.AddWithValue("@FechaCreacion", objetivoOperativo.FechaCreacion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public SCH_Estrate_Objetivos_Operativos ReadObjetivoOperativo(int id)
        {
            SCH_Estrate_Objetivos_Operativos objetivoOperativo = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Estrate_Objetivos_Operativos\" WHERE \"id\" = @ID", connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            objetivoOperativo = new SCH_Estrate_Objetivos_Operativos
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                FkId = Convert.ToInt32(reader["fkid"]),
                                Nombre = reader["Nombre"].ToString(),
                                DetalleObjetivo = reader["DetalleObjetivo"].ToString(),
                                Status = reader["status"].ToString(),
                                FechaRecordatorio = reader["fechaRecordatorio"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(reader["fechaRecordatorio"]) : null,
                                Comentario = reader["comentario"].ToString(),
                                ObjetivoRelacionado = reader["objetivorelacionado"] != DBNull.Value ? (int?)Convert.ToInt32(reader["objetivorelacionado"]) : null,
                                Responsable = reader["responsable"].ToString(),
                                Estado = Convert.ToInt32(reader["estado"]),
                                FechaCreacion = Convert.ToDateTime(reader["fechacreacion"])
                            };
                        }
                    }
                }
            }

            return objetivoOperativo;
        }

        public bool UpdateObjetivoOperativo(SCH_Estrate_Objetivos_Operativos objetivoOperativo)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"SCH_Estrate_Objetivos_Operativos\" SET \"fkid\" = @FkId, \"Nombre\" = @Nombre, \"DetalleObjetivo\" = @DetalleObjetivo, \"status\" = @Status, \"fechaRecordatorio\" = @FechaRecordatorio, \"comentario\" = @Comentario, \"objetivorelacionado\" = @ObjetivoRelacionado, \"responsable\" = @Responsable, \"estado\" = @Estado, \"fechacreacion\" = @FechaCreacion WHERE \"id\" = @ID";
                    cmd.Parameters.AddWithValue("@ID", objetivoOperativo.ID);
                    cmd.Parameters.AddWithValue("@FkId", objetivoOperativo.FkId);
                    cmd.Parameters.AddWithValue("@Nombre", objetivoOperativo.Nombre);
                    cmd.Parameters.AddWithValue("@DetalleObjetivo", objetivoOperativo.DetalleObjetivo);
                    cmd.Parameters.AddWithValue("@Status", objetivoOperativo.Status);
                    cmd.Parameters.AddWithValue("@FechaRecordatorio", (object)objetivoOperativo.FechaRecordatorio ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Comentario", (object)objetivoOperativo.Comentario ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ObjetivoRelacionado", (object)objetivoOperativo.ObjetivoRelacionado ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Responsable", objetivoOperativo.Responsable);
                    cmd.Parameters.AddWithValue("@Estado", objetivoOperativo.Estado);
                    cmd.Parameters.AddWithValue("@FechaCreacion", objetivoOperativo.FechaCreacion);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    success = rowsAffected > 0;
                }
            }

            return success;
        }
        public bool UpdateObjetivoOperativoGrilla(SCH_Estrate_Objetivos_Operativos objetivoOperativo)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"SCH_Estrate_Objetivos_Operativos\" SET \"Nombre\" = @Nombre, \"DetalleObjetivo\" = @DetalleObjetivo, \"status\" = @Status, \"fechaRecordatorio\" = @FechaRecordatorio, \"comentario\" = @Comentario, \"objetivorelacionado\" = @ObjetivoRelacionado, \"responsable\" = @Responsable  WHERE \"id\" = @ID";
                    cmd.Parameters.AddWithValue("@ID", objetivoOperativo.ID);
                    cmd.Parameters.AddWithValue("@Nombre", objetivoOperativo.Nombre);
                    cmd.Parameters.AddWithValue("@DetalleObjetivo", objetivoOperativo.DetalleObjetivo);
                    cmd.Parameters.AddWithValue("@Status", objetivoOperativo.Status);
                    cmd.Parameters.AddWithValue("@FechaRecordatorio", (object)objetivoOperativo.FechaRecordatorio ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Comentario", (object)objetivoOperativo.Comentario ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ObjetivoRelacionado", (object)objetivoOperativo.ObjetivoRelacionado ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Responsable", objetivoOperativo.Responsable);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    success = rowsAffected > 0;
                }
            }

            return success;
        }
        public void DeleteObjetivoOperativo(int id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"SCH_Estrate_Objetivos_Operativos\" WHERE \"id\" = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllObjetivosOperativos()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Estrate_Objetivos_Operativos\"", connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public DataTable GetObjetivosOperativosByFkId(int fkId)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Estrate_Objetivos_Operativos\" WHERE \"fkid\" = @FkId", connection))
                {
                    cmd.Parameters.AddWithValue("@FkId", fkId);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
        public DataTable GetObjetivosOperativosByFkIdNombre(int fkId)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Estrate_Objetivos_Operativos\" WHERE \"fkid\" = @FkId and \"estado\" =3", connection))
                {
                    cmd.Parameters.AddWithValue("@FkId", fkId);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
        public DataTable GetObjetivosOperativosByFkIdNombreEstado(int fkId,int estado)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Estrate_Objetivos_Operativos\" WHERE \"fkid\" = @FkId and \"estado\" =@estado", connection))
                {
                    cmd.Parameters.AddWithValue("@FkId", fkId);
                    cmd.Parameters.AddWithValue("@estado", estado);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
        public DataTable GetObjetivosOperativosByFkIdNombreEstadoAgrúpados(int fkId, int estado)
        {
            DataTable dataTable = new DataTable();

            // Definir la consulta SQL con la lógica para manejar múltiples IDs de responsables
            string query = @"
                WITH responsables AS (
                    SELECT 
                        f.id AS objetivo_id,
                        trim(unnest(string_to_array(f.responsable, ','))) AS id_usuario
                    FROM 
                        public.""SCH_Estrate_Objetivos_Operativos"" f
                    WHERE 
                        f.estado = @estado
                ),
                usuarios AS (
                    SELECT 
                        u.""ID_Usuario"",
                        CONCAT(u.""Nombre"", ' ', u.""Apellido1"", ' ', u.""Apellido2"") AS nombre_completo
                    FROM 
                        public.""CRM_Usuario"" u
                ),
                nombres_responsables AS (
                    SELECT 
                        r.objetivo_id,
                        STRING_AGG(u.nombre_completo, ', ') AS nombres_responsables
                    FROM 
                        responsables r
                    LEFT JOIN 
                        usuarios u
                    ON 
                        r.id_usuario = u.""ID_Usuario""
                    GROUP BY 
                        r.objetivo_id
                )
                SELECT 
                    f.id, 
                    f.fkid, 
                    f.""Nombre"" NombreProyecto, 
                    f.""DetalleObjetivo"", 
                    s.""Detalle_Status"" AS Status, 
                    f.""fechaRecordatorio"", 
                    f.comentario, 
                    f.objetivorelacionado, 
                    f.responsable,
                    f.estado, 
                    f.fechacreacion,
                    o.nombre NombreObjetivo,
                    nr.nombres_responsables
                FROM 
                    public.""SCH_Estrate_Objetivos_Operativos"" f
                INNER JOIN 
                    public.""SCH_Status"" s 
                    ON f.""status"" = s.""ID_Status""::varchar
                INNER JOIN 
                    public.""SCH_Estrate_Objetivos"" o
                    ON f.objetivorelacionado = o.""id""
                LEFT JOIN
                    nombres_responsables nr
                    ON f.id = nr.objetivo_id
                WHERE 
                    f.""fkid"" = @FkId and f.estado= @estado
                ORDER BY 
                    f.""Nombre"" DESC;
                ";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    // Agregar los parámetros a la consulta SQL
                    cmd.Parameters.AddWithValue("@FkId", fkId);
                    cmd.Parameters.AddWithValue("@estado", estado);

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
