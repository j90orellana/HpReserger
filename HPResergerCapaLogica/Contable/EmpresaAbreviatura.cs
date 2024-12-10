using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica.Contable
{
    public class EmpresaAbreviatura
    {
        private readonly string _connectionString;
        public class OEmpresaAbreviatura
        {
            public int Id { get; set; }
            public int FkEmpresa { get; set; }
            public string Abreviatura { get; set; }
            public int Usuario { get; set; }
            public DateTime Fecha { get; set; }
        }

        public EmpresaAbreviatura()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }

        // Obtener todos los registros
        public DataTable GetAll()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM TBL_Empresa_Abreviatura";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
public DataTable GetAllEmpresas()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"select e.Id_Empresa,e.Empresa, ruc,abreviatura,isnull(ae.id ,0) id from TBL_Empresa e
                    left join TBL_Empresa_Abreviatura ae on ae.fk_empresa = e.Id_Empresa order by 2 asc";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        // Obtener registro por ID
        // Obtener un registro por ID como clase
        public OEmpresaAbreviatura GetById(int id)
        {
            OEmpresaAbreviatura empresaAbreviatura = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM TBL_Empresa_Abreviatura WHERE fk_empresa = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        empresaAbreviatura = new OEmpresaAbreviatura
                        {
                            Id = reader.GetInt32(0),
                            FkEmpresa = reader.GetInt32(1),
                            Abreviatura = reader.GetString(2),
                            Usuario = reader.GetInt32(3),
                            Fecha = reader.GetDateTime(4)
                        };
                    }
                }
            }

            return empresaAbreviatura;
        }

        // Insertar nuevo registro
        public void Insert(OEmpresaAbreviatura empresaAbreviatura)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "INSERT INTO TBL_Empresa_Abreviatura (fk_empresa, abreviatura, usuario, fecha) VALUES (@fk_empresa, @abreviatura, @usuario, @fecha)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@fk_empresa", empresaAbreviatura.FkEmpresa);
                command.Parameters.AddWithValue("@abreviatura", empresaAbreviatura.Abreviatura);
                command.Parameters.AddWithValue("@usuario", empresaAbreviatura.Usuario);
                command.Parameters.AddWithValue("@fecha", empresaAbreviatura.Fecha);

                command.ExecuteNonQuery();
            }
        }

        // Actualizar un registro existente
        public void Update(OEmpresaAbreviatura empresaAbreviatura)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "UPDATE TBL_Empresa_Abreviatura SET fk_empresa = @fk_empresa, abreviatura = @abreviatura, usuario = @usuario, fecha = @fecha WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", empresaAbreviatura.Id);
                command.Parameters.AddWithValue("@fk_empresa", empresaAbreviatura.FkEmpresa);
                command.Parameters.AddWithValue("@abreviatura", empresaAbreviatura.Abreviatura);
                command.Parameters.AddWithValue("@usuario", empresaAbreviatura.Usuario);
                command.Parameters.AddWithValue("@fecha", empresaAbreviatura.Fecha);

                command.ExecuteNonQuery();
            }
        }

        // Eliminar un registro
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "DELETE FROM TBL_Empresa_Abreviatura WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
        }
    }
}
