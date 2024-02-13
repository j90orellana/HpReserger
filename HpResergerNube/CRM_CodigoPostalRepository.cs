using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
namespace HpResergerNube
{



    public class CRM_CodigoPostalRepository
    {
        private readonly string connectionString;

        public CRM_CodigoPostalRepository()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertCodigoPostal(decimal idCodigoPostal, string departamento, string provincia, string distrito)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Codigo_postal\" (\"ID_Codigo_postal\", \"Departamento\", \"Provincia\", \"Distrito\") VALUES (@ID_Codigo_postal, @Departamento, @Provincia, @Distrito)";
                    cmd.Parameters.AddWithValue("@ID_Codigo_postal", idCodigoPostal);
                    cmd.Parameters.AddWithValue("@Departamento", departamento);
                    cmd.Parameters.AddWithValue("@Provincia", provincia);
                    cmd.Parameters.AddWithValue("@Distrito", distrito);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateCodigoPostal(decimal idCodigoPostal, string nuevoDepartamento, string nuevaProvincia, string nuevoDistrito)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"CRM_Codigo_postal\" SET \"Departamento\" = @Departamento, \"Provincia\" = @Provincia, \"Distrito\" = @Distrito WHERE \"ID_Codigo_postal\" = @ID_Codigo_postal";
                    cmd.Parameters.AddWithValue("@Departamento", nuevoDepartamento);
                    cmd.Parameters.AddWithValue("@Provincia", nuevaProvincia);
                    cmd.Parameters.AddWithValue("@Distrito", nuevoDistrito);
                    cmd.Parameters.AddWithValue("@ID_Codigo_postal", idCodigoPostal);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCodigoPostal(decimal idCodigoPostal)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Codigo_postal\" WHERE \"ID_Codigo_postal\" = @ID_Codigo_postal";
                    cmd.Parameters.AddWithValue("@ID_Codigo_postal", idCodigoPostal);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllCodigosPostales()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT \"ID_Codigo_postal\", \"Departamento\", \"Provincia\", \"Distrito\", CONCAT(\"Departamento\", ', ', \"Provincia\", ', ', \"Distrito\") AS \"Ubicacion\" FROM public.\"CRM_Codigo_postal\"";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
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