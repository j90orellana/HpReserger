using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaDatos
{
    public class Tabla30SunatRepository
    {
        private readonly string connectionString;

        public Tabla30SunatRepository()
        {
            this.connectionString = HPResergerCapaDatos.HPResergerCD.Conexion;
        }
        public DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Numero, Descripcion FROM TBL_Tabla30Sunat";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;
        }
        public class Tabla30SunatItem
        {
            public int Numero { get; set; }
            public string Descripcion { get; set; }
        }
    }
}
