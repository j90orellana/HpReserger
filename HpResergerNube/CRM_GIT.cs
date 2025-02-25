using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_GIT
    {
        public string Nombre { get; set; }

        private string connectionString;

        public CRM_GIT()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionStringAdmin();
        }

        // Insertar un registro en CRM_GIT
        public void InsertGIT()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_GIT\"(\"Nombre\") VALUES (@Nombre)";
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Actualizar un registro en CRM_GIT
        public void UpdateGIT(string nuevoNombre)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"CRM_GIT\" SET \"Nombre\" = @NuevoNombre WHERE \"Nombre\" = @Nombre";
                    cmd.CommandText = "UPDATE public.\"CRM_GIT\" SET \"Nombre\" = @NuevoNombre  ";
                    cmd.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
                    //cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Eliminar un registro en CRM_GIT
        public void DeleteGIT()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_GIT\" WHERE \"Nombre\" = @Nombre";
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Obtener todos los registros de CRM_GIT
        public DataTable GetAllGITs()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_GIT\"", connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
        // Obtener el primer registro como objeto CRM_GIT
        public CRM_GIT GetOne()
        {
            CRM_GIT git = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_GIT\" LIMIT 1", connection))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            git = new CRM_GIT
                            {
                                Nombre = reader["Nombre"].ToString()
                            };
                        }
                    }
                }
            }

            return git;
        }

        // Leer un registro de CRM_GIT por nombre
        public DataRow ReadGITByNombre(string nombre)
        {
            DataRow git = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_GIT\" WHERE \"Nombre\" = @Nombre", connection))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            git = dataTable.Rows[0];
                        }
                    }
                }
            }

            return git;
        }
    }
}
