using System.Data;
using System.Data.SqlClient;
using HPResergerCapaDatos;

namespace HPResergerCapaLogica.Contable
{
    public class ClaseContable
    {
        private readonly string _connectionString;

        public ClaseContable()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }
        // Obtener todos los registros como DataTable
        public DataTable GetAllAsDataTable30Sunat()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT Numero, Descripcion FROM TBL_Tabla30Sunat";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
        // Obtener registro por Id_Empresa como DataTable
        public DataTable GetEmpresaById(int idEmpresa)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM TBL_Empresa WHERE Id_Empresa = @Id_Empresa";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Id_Empresa", idEmpresa);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
        // Obtener registros con número 0 y descripción "ninguno" y luego todos los datos como DataTable
        public DataTable GetAllWithDefaultAsDataTable30Sunat()
        {
            DataTable dataTable = GetAllAsDataTable30Sunat();

            // Agregar fila predeterminada
            DataRow defaultRow = dataTable.NewRow();
            defaultRow["Numero"] = 0;
            defaultRow["Descripcion"] = "NINGUNO";
            dataTable.Rows.InsertAt(defaultRow, 0);

            return dataTable;
        }
        public DataTable GetRelacionByFacturaId(int idFactura)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM TBL_RelacionFacturaSunat WHERE Id_Factura = @Id_Factura";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Id_Factura", idFactura);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }
        public void UpdateOrInsertRelacion(int idFactura, int numeroTablaSunat)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Verificar si el registro existe
                string checkQuery = "SELECT COUNT(*) FROM TBL_RelacionFacturaSunat WHERE Id_Factura = @Id_Factura";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@Id_Factura", idFactura);

                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    // Actualizar el registro existente
                    string updateQuery = "UPDATE TBL_RelacionFacturaSunat SET Numero_TablaSunat = @Numero_TablaSunat WHERE Id_Factura = @Id_Factura";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@Id_Factura", idFactura);
                    updateCommand.Parameters.AddWithValue("@Numero_TablaSunat", numeroTablaSunat);

                    updateCommand.ExecuteNonQuery();
                }
                else
                {
                    // Insertar nuevo registro
                    string insertQuery = "INSERT INTO TBL_RelacionFacturaSunat (Id_Factura, Numero_TablaSunat) VALUES (@Id_Factura, @Numero_TablaSunat)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@Id_Factura", idFactura);
                    insertCommand.Parameters.AddWithValue("@Numero_TablaSunat", numeroTablaSunat);

                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
