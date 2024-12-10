using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica
{
    public class CatalogoExistencias
    {
        private readonly string _connectionString;
        public class oCatalogoExistencias
        {
            public int Pkid { get; set; }
            public int IdS { get; set; }
            public string Nombre { get; set; }
            public int Estado { get; set; }
        }

        public CatalogoExistencias()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }

        // Obtener todos los registros como una lista de clases
        public DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM TBL_AF_CatalogoExistencias WHERE ESTADO = 1 ";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);  // Llenar el DataTable con los datos de la consulta
            }

            return dataTable;
        }

        // Obtener un registro por ID como clase
        public oCatalogoExistencias GetById(int pkid)
        {
            oCatalogoExistencias catalogo = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM TBL_AF_CatalogoExistencias WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pkid", pkid);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        catalogo = new oCatalogoExistencias
                        {
                            Pkid = reader.GetInt32(0),
                            IdS = reader.GetInt32(1),
                            Nombre = reader.GetString(2),
                            Estado = reader.GetInt32(3)
                        };
                    }
                }
            }

            return catalogo;
        }

        // Insertar un nuevo registro, retorna true si se afecta alguna fila
        public bool Insert(oCatalogoExistencias catalogo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "INSERT INTO TBL_AF_CatalogoExistencias (idS, Nombre, Estado) VALUES (@idS, @Nombre, @Estado)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@idS", catalogo.IdS);
                command.Parameters.AddWithValue("@Nombre", catalogo.Nombre);
                command.Parameters.AddWithValue("@Estado", catalogo.Estado);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Actualizar un registro existente, retorna true si se afecta alguna fila
        public bool Update(oCatalogoExistencias catalogo)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "UPDATE TBL_AF_CatalogoExistencias SET idS = @idS, Nombre = @Nombre, Estado = @Estado WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@pkid", catalogo.Pkid);
                command.Parameters.AddWithValue("@idS", catalogo.IdS);
                command.Parameters.AddWithValue("@Nombre", catalogo.Nombre);
                command.Parameters.AddWithValue("@Estado", catalogo.Estado);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        public bool EliminarxEstado(int pkid)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "UPDATE TBL_AF_CatalogoExistencias SET Estado = 0 " +
                               "WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pkid", pkid);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        // Eliminar un registro, retorna true si se afecta alguna fila
        public bool Delete(int pkid)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "DELETE FROM TBL_AF_CatalogoExistencias WHERE pkid = @pkid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pkid", pkid);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
