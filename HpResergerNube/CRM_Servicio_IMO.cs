using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_Servicio_IMORepository
    {
        private readonly string connectionString;

        public CRM_Servicio_IMORepository()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public DataTable GetAll()
        {
            DataTable dataTable = new DataTable();
            string sql = "SELECT * FROM \"CRM_Servicio_IMO\"";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, connection))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        public DataTable GetAllActivos()
        {
            DataTable dataTable = new DataTable();
            string sql = "SELECT * FROM \"CRM_Servicio_IMO\" WHERE estado_activo = true";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, connection))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
        public bool Update(CRM_Servicio_IMO servicio)
        {
            string sql = @"UPDATE ""CRM_Servicio_IMO"" 
                           SET sku = @SKU, tipo = @Tipo, area = @Area, detalle = @Detalle, u_inmob = @U_Inmob, 
                               d1 = @D1, d2 = @D2, d3 = @D3, adjuntar_cot = @Adjuntar_Cot, precio1 = @Precio1, 
                               precio2 = @Precio2, precio3 = @Precio3, estado_activo = @Estado_Activo, 
                               estado_separado = @Estado_Separado
                           WHERE id = @ID";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", servicio.ID);
                    cmd.Parameters.AddWithValue("@SKU", servicio.SKU);
                    cmd.Parameters.AddWithValue("@Tipo", servicio.Tipo);
                    cmd.Parameters.AddWithValue("@Area", servicio.Area);
                    cmd.Parameters.AddWithValue("@Detalle", servicio.Detalle);
                    cmd.Parameters.AddWithValue("@U_Inmob", servicio.U_Inmob);
                    cmd.Parameters.AddWithValue("@D1", servicio.D1);
                    cmd.Parameters.AddWithValue("@D2", servicio.D2);
                    cmd.Parameters.AddWithValue("@D3", servicio.D3);
                    cmd.Parameters.AddWithValue("@Adjuntar_Cot", servicio.Adjuntar_Cot);
                    cmd.Parameters.AddWithValue("@Precio1", servicio.Precio1);
                    cmd.Parameters.AddWithValue("@Precio2", servicio.Precio2);
                    cmd.Parameters.AddWithValue("@Precio3", servicio.Precio3);
                    cmd.Parameters.AddWithValue("@Estado_Activo", servicio.Estado_Activo);
                    cmd.Parameters.AddWithValue("@Estado_Separado", servicio.Estado_Separado);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool Delete(int id)
        {
            string sql = @"UPDATE ""CRM_Servicio_IMO"" 
                           SET estado_activo = false
                           WHERE id = @ID";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public DataTable GetAllActivosNoSeparados()
        {
            DataTable dataTable = new DataTable();
            string sql = @"SELECT * FROM ""CRM_Servicio_IMO"" WHERE estado_activo = true AND estado_separado = 1";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, connection))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
        public int Insert(CRM_Servicio_IMO servicio)
        {
            int newId = 0;
            string sql = @"INSERT INTO ""CRM_Servicio_IMO"" (sku, tipo, area, detalle, u_inmob, d1, d2, d3, adjuntar_cot, precio1, precio2, precio3, estado_activo, estado_separado) 
                           VALUES (@SKU, @Tipo, @Area, @Detalle, @U_Inmob, @D1, @D2, @D3, @Adjuntar_Cot, @Precio1, @Precio2, @Precio3, @Estado_Activo, @Estado_Separado) 
                           RETURNING id";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@SKU", servicio.SKU);
                    cmd.Parameters.AddWithValue("@Tipo", servicio.Tipo);
                    cmd.Parameters.AddWithValue("@Area", servicio.Area);
                    cmd.Parameters.AddWithValue("@Detalle", servicio.Detalle);
                    cmd.Parameters.AddWithValue("@U_Inmob", servicio.U_Inmob);
                    cmd.Parameters.AddWithValue("@D1", servicio.D1);
                    cmd.Parameters.AddWithValue("@D2", servicio.D2);
                    cmd.Parameters.AddWithValue("@D3", servicio.D3);
                    cmd.Parameters.AddWithValue("@Adjuntar_Cot", servicio.Adjuntar_Cot);
                    cmd.Parameters.AddWithValue("@Precio1", servicio.Precio1);
                    cmd.Parameters.AddWithValue("@Precio2", servicio.Precio2);
                    cmd.Parameters.AddWithValue("@Precio3", servicio.Precio3);
                    cmd.Parameters.AddWithValue("@Estado_Activo", servicio.Estado_Activo);
                    cmd.Parameters.AddWithValue("@Estado_Separado", servicio.Estado_Separado);

                    newId = (int)cmd.ExecuteScalar();
                }
            }

            return newId;
        }
    }
    public class CRM_Servicio_IMO
    {
        public int ID { get; set; }
        public string SKU { get; set; }
        public string Tipo { get; set; }
        public string Area { get; set; }
        public string Detalle { get; set; }
        public string U_Inmob { get; set; }
        public string D1 { get; set; }
        public string D2 { get; set; }
        public string D3 { get; set; }
        public string Adjuntar_Cot { get; set; }
        public decimal Precio1 { get; set; }
        public decimal Precio2 { get; set; }
        public decimal Precio3 { get; set; }
        public bool Estado_Activo { get; set; }
        public int Estado_Separado { get; set; }
    }
}
