using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class SCH_Estrate
    {
        public int ID { get; set; }
        public string IDCliente { get; set; }
        public DateTime FechaCreacion { get; set; }

        private string connectionString;

        public SCH_Estrate()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public int InsertEstrate(SCH_Estrate estrate)
        {
            int newId = 0;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"SCH_Estrate\"(\"idcliente\", \"fecha_creacion\") VALUES (@IDCliente, @FechaCreacion) RETURNING \"id\"";
                    cmd.Parameters.AddWithValue("@IDCliente", estrate.IDCliente);
                    cmd.Parameters.AddWithValue("@FechaCreacion", estrate.FechaCreacion);

                    // Ejecutar la consulta y obtener el valor del nuevo ID
                    newId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return newId;
        }


        public SCH_Estrate ReadEstrate(int id)
        {
            SCH_Estrate estrate = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Estrate\" WHERE \"id\" = @ID", connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            estrate = new SCH_Estrate
                            {
                                ID = Convert.ToInt32(reader["id"]),
                                IDCliente = reader["idcliente"].ToString(),
                                FechaCreacion = Convert.ToDateTime(reader["fecha_creacion"])
                            };
                        }
                    }
                }
            }

            return estrate;
        }

        public bool UpdateEstrate(SCH_Estrate estrate)
        {
            bool success = false;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"SCH_Estrate\" SET \"idcliente\" = @IDCliente, \"fecha_creacion\" = @FechaCreacion WHERE \"id\" = @ID";
                    cmd.Parameters.AddWithValue("@ID", estrate.ID);
                    cmd.Parameters.AddWithValue("@IDCliente", estrate.IDCliente);
                    cmd.Parameters.AddWithValue("@FechaCreacion", estrate.FechaCreacion);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    success = rowsAffected > 0;
                }
            }

            return success;
        }

        public void DeleteEstrate(int id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"SCH_Estrate\" WHERE \"id\" = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllEstrates()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Estrate\"", connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public DataTable GetEstratesByCliente(string idCliente)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"SCH_Estrate\" WHERE \"idcliente\" = @IDCliente", connection))
                {
                    cmd.Parameters.AddWithValue("@IDCliente", idCliente);

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
