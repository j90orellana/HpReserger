﻿using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class SCH_ReunionesDet
    {
        public int ID { get; set; }
        public int FKID { get; set; }
        public string Accion { get; set; }
        public int Nivel { get; set; }
        public DateTime Seguimiento { get; set; }
        public string ResponsableOficina { get; set; }
        public string ResponsableCliente { get; set; }
        public int ObjetivoRelacionado { get; set; }

        private string connectionString;
        public int idstatus { get; set; }
        public int idcalendario { get; set; }

        public SCH_ReunionesDet()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public int InsertReunionDet(SCH_ReunionesDet reunionDet)
        {
            int newId = 0;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"SCH_Reuniones_det\"(\"idcalendario\", \"fkid\", \"Accion\", \"Nivel\", \"Seguimiento\", \"Responsable_Oficina\", \"Responsable_Cliente\", \"Objetivo_Relacionado\",\"idstatus\") VALUES (@idcalendario,@FKID, @Accion, @Nivel, @Seguimiento, @ResponsableOficina, @ResponsableCliente, @ObjetivoRelacionado,@idstatus) RETURNING \"id\"";
                    cmd.Parameters.AddWithValue("@FKID", reunionDet.FKID);
                    cmd.Parameters.AddWithValue("@Accion", reunionDet.Accion);
                    cmd.Parameters.AddWithValue("@Nivel", reunionDet.Nivel);
                    cmd.Parameters.AddWithValue("@Seguimiento", reunionDet.Seguimiento);
                    cmd.Parameters.AddWithValue("@ResponsableOficina", reunionDet.ResponsableOficina);
                    cmd.Parameters.AddWithValue("@ResponsableCliente", reunionDet.ResponsableCliente ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ObjetivoRelacionado", reunionDet.ObjetivoRelacionado);
                    cmd.Parameters.AddWithValue("@idstatus", reunionDet.idstatus);
                    cmd.Parameters.AddWithValue("@idcalendario", reunionDet.idcalendario);

                    newId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return newId;
        }

        public SCH_ReunionesDet ReadReunionDet(int id)
        {
            SCH_ReunionesDet reunionDet = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Reuniones_det\" WHERE \"id\" = @ID", connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            reunionDet = new SCH_ReunionesDet
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                FKID = Convert.ToInt32(reader["fkid"]),
                                Accion = reader["Accion"].ToString(),
                                Nivel = Convert.ToInt32(reader["Nivel"]),
                                idcalendario = Convert.ToInt32(reader["idcalendario"]),
                                Seguimiento = Convert.ToDateTime(reader["Seguimiento"]),
                                ResponsableOficina = reader["Responsable_Oficina"].ToString(),
                                ResponsableCliente = reader["Responsable_Cliente"] as string,
                                ObjetivoRelacionado = Convert.ToInt32(reader["Objetivo_Relacionado"])
                            };
                        }
                    }
                }
            }

            return reunionDet;
        }

        public bool UpdateReunionDet(SCH_ReunionesDet reunionDet)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"SCH_Reuniones_det\" SET \"idcalendario\"=@idcalendario,\"idstatus\"=@idstatus, \"fkid\" = @FKID, \"Accion\" = @Accion, \"Nivel\" = @Nivel, \"Seguimiento\" = @Seguimiento, \"Responsable_Oficina\" = @ResponsableOficina, \"Responsable_Cliente\" = @ResponsableCliente, \"Objetivo_Relacionado\" = @ObjetivoRelacionado WHERE \"id\" = @ID";
                    cmd.Parameters.AddWithValue("@ID", reunionDet.ID);
                    cmd.Parameters.AddWithValue("@FKID", reunionDet.FKID);
                    cmd.Parameters.AddWithValue("@Accion", reunionDet.Accion);
                    cmd.Parameters.AddWithValue("@Nivel", reunionDet.Nivel);
                    cmd.Parameters.AddWithValue("@Seguimiento", reunionDet.Seguimiento);
                    cmd.Parameters.AddWithValue("@ResponsableOficina", reunionDet.ResponsableOficina);
                    cmd.Parameters.AddWithValue("@ResponsableCliente", reunionDet.ResponsableCliente ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ObjetivoRelacionado", reunionDet.ObjetivoRelacionado);
                    cmd.Parameters.AddWithValue("@idstatus", reunionDet.idstatus);
                    cmd.Parameters.AddWithValue("@idcalendario", reunionDet.idcalendario);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    success = rowsAffected > 0;
                }
            }

            return success;
        }

        public bool DeleteReunionDet(int id)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "DELETE FROM public.\"SCH_Reuniones_det\" WHERE \"id\" = @ID";
                        cmd.Parameters.AddWithValue("@ID", id);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch
            {
                return false;
            }

        }

        public DataTable GetAllReunionesDet()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Reuniones_det\"", connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
        public DataTable ObtenerTareasPendientesDelCliente(string clienteId)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                                SELECT d.* 
                                FROM public.""SCH_Reuniones"" c 
                                INNER JOIN public.""SCH_Reuniones_det"" d ON c.id = d.fkid
                                INNER JOIN public.""SCH_Status"" s ON d.idstatus = s.""ID_Status"" 
                                WHERE c.""Cliente"" = @ClienteId
                                AND c.""Estado"" = 1
                                AND s.importar = 1";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ClienteId", clienteId);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }


        public DataTable GetReunionesDetByFKID(int fkid)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Reuniones_det\" WHERE \"fkid\" = @FKID order by 1 asc", connection))
                {
                    cmd.Parameters.AddWithValue("@FKID", fkid);

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
