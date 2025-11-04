using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_Documentos
    {
        private readonly string connectionString;

        public CRM_Documentos()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public void Insert(int fk_id, string ventana, string nombreCompletoFtp, string nombreArchivo, DateTime fecha)
        {
            string newIDDocumento = "";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Obtener el último número de correlativo de la base de datos
                    string queryLastCorrelative = "SELECT MAX(\"ID_Documento\") FROM public.\"CRM_Documentos\"";
                    using (NpgsqlCommand cmdLastCorrelative = new NpgsqlCommand(queryLastCorrelative, connection))
                    {
                        object lastCorrelative = cmdLastCorrelative.ExecuteScalar();
                        int lastCorrelativeNumber = lastCorrelative == DBNull.Value ? 0 : Convert.ToInt32(lastCorrelative);

                        // Generar el nuevo correlativo
                        int newCorrelativeNumber = lastCorrelativeNumber + 1;

                        newIDDocumento = newCorrelativeNumber.ToString();
                    }

                    // Insertar el nuevo documento con el nuevo ID_Documento
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "INSERT INTO public.\"CRM_Documentos\"(\"ID_Documento\", fk_id, \"Ventana\", \"Nombre_Completo_ftp\", \"Nombre_Archivo\", \"Fecha\") " +
                            "VALUES (@ID_Documento, @fk_id, @Ventana, @Nombre_Completo_ftp, @Nombre_Archivo, @Fecha)";
                        cmd.Parameters.AddWithValue("@ID_Documento", Convert.ToInt32(newIDDocumento));
                        cmd.Parameters.AddWithValue("@fk_id", fk_id);
                        cmd.Parameters.AddWithValue("@Ventana", ventana ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Nombre_Completo_ftp", nombreCompletoFtp ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Nombre_Archivo", nombreArchivo ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Fecha", fecha);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el documento: " + ex.Message);
            }

            //return newIDDocumento;
        }

        public void Update(int idDocumento, int fk_id, string ventana, string nombreCompletoFtp, string nombreArchivo, DateTime fecha)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE public.\"CRM_Documentos\" " +
                                   "SET fk_id = @fk_id, \"Ventana\" = @ventana, \"Nombre_Completo_ftp\" = @nombreCompletoFtp, " +
                                   "\"Nombre_Archivo\" = @nombreArchivo, \"Fecha\" = @fecha " +
                                   "WHERE \"ID_Documento\" = @idDocumento";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idDocumento", idDocumento);
                        command.Parameters.AddWithValue("@fk_id", fk_id);
                        command.Parameters.AddWithValue("@ventana", ventana);
                        command.Parameters.AddWithValue("@nombreCompletoFtp", nombreCompletoFtp);
                        command.Parameters.AddWithValue("@nombreArchivo", nombreArchivo);
                        command.Parameters.AddWithValue("@fecha", fecha);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el documento: " + ex.Message);
            }
        }

        public void Delete(int idDocumento)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM public.\"CRM_Documentos\" WHERE \"ID_Documento\" = @idDocumento";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idDocumento", idDocumento);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el documento: " + ex.Message);
            }
        }
        public DataTable ListByFkIdAndVentana(int fk_id, string ventana)
        {
            DataTable documentos = new DataTable();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM public.\"CRM_Documentos\" WHERE fk_id = @fk_id AND \"Ventana\" = @ventana ORDER BY \"Fecha\" DESC";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@fk_id", fk_id);
                        adapter.SelectCommand.Parameters.AddWithValue("@ventana", ventana);
                        adapter.Fill(documentos);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar los documentos: " + ex.Message);
            }
            return documentos;
        }
        public bool EliminarLogica(int idDocumento, string NombreEliminado)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE public.\"CRM_Documentos\" " +
                                   "SET \"Ventana\" = @ventana " +
                                   "WHERE \"ID_Documento\" = @idDocumento";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idDocumento", idDocumento);
                        command.Parameters.AddWithValue("@ventana", NombreEliminado);

                        return command.ExecuteNonQuery() > 0 ? true : false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el documento: " + ex.Message);
                return false;
            }
        }
    }
}
