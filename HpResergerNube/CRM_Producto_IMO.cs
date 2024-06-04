using System;
using System.Data;
using Npgsql;

namespace HpResergerNube
{
    public class CRM_Producto_IMORepository
    {
        private readonly string connectionString;

        public CRM_Producto_IMORepository()
        {
            DLConexion dx = new DLConexion();
            this.connectionString = dx.GetConnectionString();
        }

        public DataTable GetAll()
        {
            DataTable dataTable = new DataTable();
            string sql = "SELECT * FROM \"CRM_Producto_IMO\"";

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
            string sql = "SELECT * FROM \"CRM_Producto_IMO\" WHERE estado_activo = true";

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
        public DataTable GetAllActivosNoSeparados()
        {
            DataTable dataTable = new DataTable();
            string sql = @"SELECT * FROM ""CRM_Producto_IMO"" WHERE estado_activo = true AND estado_separado = false";

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
        public bool Update(CRM_Producto_IMO producto)
        {
            string sql = @"UPDATE ""CRM_Producto_IMO"" 
                           SET sku = @SKU, tipo = @Tipo, detalle = @Detalle, area = @Area, material = @Material, 
                               u_inmob = @U_Inmob, piso = @Piso, d1 = @D1, d2 = @D2, d3 = @D3, adjuntar_cot = @Adjuntar_Cot, 
                               precio1 = @Precio1, precio2 = @Precio2, precio3 = @Precio3, estado_activo = @Estado_Activo, 
                               estado_separado = @Estado_Separado
                           WHERE id = @ID";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", producto.ID);
                    cmd.Parameters.AddWithValue("@SKU", producto.SKU);
                    cmd.Parameters.AddWithValue("@Tipo", producto.Tipo);
                    cmd.Parameters.AddWithValue("@Detalle", producto.Detalle);
                    cmd.Parameters.AddWithValue("@Area", producto.Area);
                    cmd.Parameters.AddWithValue("@Material", producto.Material);
                    cmd.Parameters.AddWithValue("@U_Inmob", producto.U_Inmob);
                    cmd.Parameters.AddWithValue("@Piso", producto.Piso);
                    cmd.Parameters.AddWithValue("@D1", producto.D1);
                    cmd.Parameters.AddWithValue("@D2", producto.D2);
                    cmd.Parameters.AddWithValue("@D3", producto.D3);
                    cmd.Parameters.AddWithValue("@Adjuntar_Cot", producto.Adjuntar_Cot);
                    cmd.Parameters.AddWithValue("@Precio1", producto.Precio1);
                    cmd.Parameters.AddWithValue("@Precio2", producto.Precio2);
                    cmd.Parameters.AddWithValue("@Precio3", producto.Precio3);
                    cmd.Parameters.AddWithValue("@Estado_Activo", producto.Estado_Activo);
                    cmd.Parameters.AddWithValue("@Estado_Separado", producto.Estado_Separado);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool Delete(int id)
        {
            string sql = @"UPDATE ""CRM_Producto_IMO"" 
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
        public int Insert(CRM_Producto_IMO producto)
        {
            int newId = 0;
            string sql = @"INSERT INTO ""CRM_Producto_IMO"" (sku, tipo, detalle, area, material, u_inmob, piso, d1, d2, d3, adjuntar_cot, precio1, precio2, precio3, estado_activo, estado_separado) 
                           VALUES (@SKU, @Tipo, @Detalle, @Area, @Material, @U_Inmob, @Piso, @D1, @D2, @D3, @Adjuntar_Cot, @Precio1, @Precio2, @Precio3, @Estado_Activo, @Estado_Separado) 
                           RETURNING id";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@SKU", producto.SKU);
                    cmd.Parameters.AddWithValue("@Tipo", producto.Tipo);
                    cmd.Parameters.AddWithValue("@Detalle", producto.Detalle);
                    cmd.Parameters.AddWithValue("@Area", producto.Area);
                    cmd.Parameters.AddWithValue("@Material", producto.Material);
                    cmd.Parameters.AddWithValue("@U_Inmob", producto.U_Inmob);
                    cmd.Parameters.AddWithValue("@Piso", producto.Piso);
                    cmd.Parameters.AddWithValue("@D1", producto.D1);
                    cmd.Parameters.AddWithValue("@D2", producto.D2);
                    cmd.Parameters.AddWithValue("@D3", producto.D3);
                    cmd.Parameters.AddWithValue("@Adjuntar_Cot", producto.Adjuntar_Cot);
                    cmd.Parameters.AddWithValue("@Precio1", producto.Precio1);
                    cmd.Parameters.AddWithValue("@Precio2", producto.Precio2);
                    cmd.Parameters.AddWithValue("@Precio3", producto.Precio3);
                    cmd.Parameters.AddWithValue("@Estado_Activo", producto.Estado_Activo);
                    cmd.Parameters.AddWithValue("@Estado_Separado", producto.Estado_Separado);

                    newId = (int)cmd.ExecuteScalar();
                }
            }

            return newId;
        }
    }
    public class CRM_Producto_IMO
    {
        public int ID { get; set; }
        public string SKU { get; set; }
        public string Tipo { get; set; }
        public string Detalle { get; set; }
        public string Area { get; set; }
        public string Material { get; set; }
        public string U_Inmob { get; set; }
        public string Piso { get; set; }
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

