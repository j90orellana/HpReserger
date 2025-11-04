using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica.Configuracion
{
    public class ConfiguracionEmpresa
    {
        public int Id { get; set; }
        public int Tipo { get; set; } = 0;
        public string Descripcion { get; set; } = string.Empty;
        public int Valor { get; set; } = 0;
        public string Texto { get; set; } = string.Empty;

        private readonly string _connectionString;

        public ConfiguracionEmpresa()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }

        public void VerificarCrearTabla()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string checkTableQuery = @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='TBL_ConfiguracionesEmpresa' AND xtype='U')
                BEGIN
                    CREATE TABLE TBL_ConfiguracionesEmpresa (
                        Id INT IDENTITY(1,1) PRIMARY KEY,
                        Tipo INT NOT NULL,
                        Descripcion VARCHAR(255),
                        Valor INT DEFAULT 0,
                        Texto VARCHAR(100)
                    )
                END";

                SqlCommand cmd = new SqlCommand(checkTableQuery, conn);
                cmd.ExecuteNonQuery();
            }
        }

        public int InsertOrUpdate(ConfiguracionEmpresa config)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                IF EXISTS (SELECT 1 FROM TBL_ConfiguracionesEmpresa WHERE Tipo = @Tipo)
                BEGIN
                    UPDATE TBL_ConfiguracionesEmpresa 
                    SET Descripcion = @Descripcion, 
                        Valor = @Valor, 
                        Texto = @Texto
                    WHERE Tipo = @Tipo
                    
                    SELECT Id FROM TBL_ConfiguracionesEmpresa WHERE Tipo = @Tipo
                END
                ELSE
                BEGIN
                    INSERT INTO TBL_ConfiguracionesEmpresa 
                    (Tipo, Descripcion, Valor, Texto)
                    OUTPUT INSERTED.Id
                    VALUES (@Tipo, @Descripcion, @Valor, @Texto)
                END";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Tipo", config.Tipo);
                cmd.Parameters.AddWithValue("@Descripcion", (object)config.Descripcion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Valor", config.Valor);
                cmd.Parameters.AddWithValue("@Texto", (object)config.Texto ?? DBNull.Value);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public ConfiguracionEmpresa GetByTipo(int tipo)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM TBL_ConfiguracionesEmpresa WHERE Tipo = @Tipo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Tipo", tipo);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ConfiguracionEmpresa
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Tipo = Convert.ToInt32(reader["Tipo"]),
                            Descripcion = reader["Descripcion"].ToString(),
                            Valor = Convert.ToInt32(reader["Valor"]),
                            Texto = reader["Texto"].ToString()
                        };
                    }
                }
            }
            return null;
        }
        public DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT Id,Tipo,Descripcion,Valor,Texto 'Dato' FROM TBL_ConfiguracionesEmpresa ";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        public DataTable GetAllByTipo(int tipo)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM TBL_ConfiguracionesEmpresa WHERE Tipo = @Tipo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Tipo", tipo);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public bool Update(ConfiguracionEmpresa config)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                UPDATE TBL_ConfiguracionesEmpresa 
                SET Descripcion = @Descripcion, 
                    Valor = @Valor, 
                    Texto = @Texto
                WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", config.Id);
                cmd.Parameters.AddWithValue("@Descripcion", (object)config.Descripcion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Valor", config.Valor);
                cmd.Parameters.AddWithValue("@Texto", (object)config.Texto ?? DBNull.Value);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM TBL_ConfiguracionesEmpresa WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}