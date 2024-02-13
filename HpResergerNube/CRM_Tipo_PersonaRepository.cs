using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;

namespace HpResergerNube
{

    public class CRM_Tipo_PersonaRepository
    {
        private readonly string connectionString;

        public CRM_Tipo_PersonaRepository()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void InsertTipoPersona(string idTipoPersona, string detalleTipoPersona)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO public.\"CRM_Tipo_Persona\" (\"ID_Tipo_persona\", \"Detalle_Tipo_Persona\") VALUES (@ID_Tipo_persona, @Detalle_Tipo_Persona)";
                    cmd.Parameters.AddWithValue("@ID_Tipo_persona", idTipoPersona);
                    cmd.Parameters.AddWithValue("@Detalle_Tipo_Persona", detalleTipoPersona);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTipoPersona(string idTipoPersona, string nuevoDetalleTipoPersona)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE public.\"CRM_Tipo_Persona\" SET \"Detalle_Tipo_Persona\" = @Detalle_Tipo_Persona WHERE \"ID_Tipo_persona\" = @ID_Tipo_persona";
                    cmd.Parameters.AddWithValue("@Detalle_Tipo_Persona", nuevoDetalleTipoPersona);
                    cmd.Parameters.AddWithValue("@ID_Tipo_persona", idTipoPersona);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTipoPersona(string idTipoPersona)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM public.\"CRM_Tipo_Persona\" WHERE \"ID_Tipo_persona\" = @ID_Tipo_persona";
                    cmd.Parameters.AddWithValue("@ID_Tipo_persona", idTipoPersona);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllTipoPersonas()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"CRM_Tipo_Persona\"", connection))
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
