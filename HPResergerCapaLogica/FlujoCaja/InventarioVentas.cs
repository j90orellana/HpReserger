using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace HPResergerCapaLogica.FlujoCaja
{
    public class InventarioVentas
    {
        public int Id { get; set; } = 0;
        public string Proyecto { get; set; } = string.Empty;
        public int Etapa { get; set; } = 0;
        public string Manzana { get; set; } = string.Empty;
        public int Tipo { get; set; } = 0;
        public int Cantidad { get; set; } = 0;
        public string Uso { get; set; } = string.Empty;
        public decimal AreaOcupadaVendible { get; set; } = 0m;
        public decimal? AreaEmpinada { get; set; } = null;
        public decimal PrecioVentaSinEstacionamiento { get; set; } = 0m;
        public decimal PrecioPorMetroCuadradoSinEstacionamiento { get; set; } = 0m;
        public decimal AreaOcupadaTotal { get; set; } = 0m;
        public decimal ListaPreciosRegular { get; set; } = 0m;
        public decimal ListaPreciosFeria { get; set; } = 0m;
        public decimal ListaPreciosInversionistas { get; set; } = 0m;
        public string Estatus { get; set; } = string.Empty;
        public string Comentario { get; set; } = string.Empty;
        public string Ubicacion { get; set; } = string.Empty;
        public string Forma { get; set; } = string.Empty;
        public string Tamaño { get; set; } = string.Empty;
        public decimal FactorUbicacion { get; set; } = 0m;
        public decimal FactorForma { get; set; } = 0m;
        public decimal FactorTamaño { get; set; } = 0m;

        private readonly string _connectionString;

        public InventarioVentas()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }

        // Create
        public int Insertar(InventarioVentas inventario)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO tbl_InventarioVentas (Proyecto, Etapa, Manzana, Tipo, Cantidad, Uso, 
                                AreaOcupadaVendible, AreaEmpinada, PrecioVentaSinEstacionamiento, 
                                PrecioPorMetroCuadradoSinEstacionamiento, AreaOcupadaTotal, 
                                ListaPreciosRegular, ListaPreciosFeria, ListaPreciosInversionistas, 
                                Estatus, Comentario, Ubicacion, Forma, Tamaño, 
                                FactorUbicacion, FactorForma, FactorTamaño)
                                OUTPUT INSERTED.id 
                                VALUES (@Proyecto, @Etapa, @Manzana, @Tipo, @Cantidad, @Uso, 
                                        @AreaOcupadaVendible, @AreaEmpinada, @PrecioVentaSinEstacionamiento, 
                                        @PrecioPorMetroCuadradoSinEstacionamiento, @AreaOcupadaTotal, 
                                        @ListaPreciosRegular, @ListaPreciosFeria, @ListaPreciosInversionistas, 
                                        @Estatus, @Comentario, @Ubicacion, @Forma, @Tamaño, 
                                        @FactorUbicacion, @FactorForma, @FactorTamaño)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Proyecto", inventario.Proyecto);
                cmd.Parameters.AddWithValue("@Etapa", inventario.Etapa);
                cmd.Parameters.AddWithValue("@Manzana", inventario.Manzana);
                cmd.Parameters.AddWithValue("@Tipo", inventario.Tipo);
                cmd.Parameters.AddWithValue("@Cantidad", inventario.Cantidad);
                cmd.Parameters.AddWithValue("@Uso", inventario.Uso);
                cmd.Parameters.AddWithValue("@AreaOcupadaVendible", inventario.AreaOcupadaVendible);
                cmd.Parameters.AddWithValue("@AreaEmpinada", (object)inventario.AreaEmpinada ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PrecioVentaSinEstacionamiento", inventario.PrecioVentaSinEstacionamiento);
                cmd.Parameters.AddWithValue("@PrecioPorMetroCuadradoSinEstacionamiento", inventario.PrecioPorMetroCuadradoSinEstacionamiento);
                cmd.Parameters.AddWithValue("@AreaOcupadaTotal", inventario.AreaOcupadaTotal);
                cmd.Parameters.AddWithValue("@ListaPreciosRegular", inventario.ListaPreciosRegular);
                cmd.Parameters.AddWithValue("@ListaPreciosFeria", inventario.ListaPreciosFeria);
                cmd.Parameters.AddWithValue("@ListaPreciosInversionistas", inventario.ListaPreciosInversionistas);
                cmd.Parameters.AddWithValue("@Estatus", inventario.Estatus);
                cmd.Parameters.AddWithValue("@Comentario", (object)inventario.Comentario ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Ubicacion", inventario.Ubicacion);
                cmd.Parameters.AddWithValue("@Forma", inventario.Forma);
                cmd.Parameters.AddWithValue("@Tamaño", inventario.Tamaño);
                cmd.Parameters.AddWithValue("@FactorUbicacion", inventario.FactorUbicacion);
                cmd.Parameters.AddWithValue("@FactorForma", inventario.FactorForma);
                cmd.Parameters.AddWithValue("@FactorTamaño", inventario.FactorTamaño);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        // Read
        // Read - Obtener todos
        public List<InventarioVentas> ObtenerTodos()
        {
            List<InventarioVentas> lista = new List<InventarioVentas>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM tbl_InventarioVentas   ORDER BY Proyecto asc , id asc";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    InventarioVentas item = new InventarioVentas
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("Id")),
                        Proyecto = reader.GetString(reader.GetOrdinal("Proyecto")),
                        Etapa = reader.GetInt32(reader.GetOrdinal("Etapa")),
                        Manzana = reader.GetString(reader.GetOrdinal("Manzana")),
                        Tipo = reader.GetInt32(reader.GetOrdinal("Tipo")),
                        Cantidad = reader.GetInt32(reader.GetOrdinal("Cantidad")),
                        Uso = reader.GetString(reader.GetOrdinal("Uso")),
                        AreaOcupadaVendible = reader.GetDecimal(reader.GetOrdinal("AreaOcupadaVendible")),
                        AreaEmpinada = reader.IsDBNull(reader.GetOrdinal("AreaEmpinada")) ? (decimal?)null : reader.GetDecimal(reader.GetOrdinal("AreaEmpinada")),
                        PrecioVentaSinEstacionamiento = reader.GetDecimal(reader.GetOrdinal("PrecioVentaSinEstacionamiento")),
                        PrecioPorMetroCuadradoSinEstacionamiento = reader.GetDecimal(reader.GetOrdinal("PrecioPorMetroCuadradoSinEstacionamiento")),
                        AreaOcupadaTotal = reader.GetDecimal(reader.GetOrdinal("AreaOcupadaTotal")),
                        ListaPreciosRegular = reader.GetDecimal(reader.GetOrdinal("ListaPreciosRegular")),
                        ListaPreciosFeria = reader.GetDecimal(reader.GetOrdinal("ListaPreciosFeria")),
                        ListaPreciosInversionistas = reader.GetDecimal(reader.GetOrdinal("ListaPreciosInversionistas")),
                        Estatus = reader.GetString(reader.GetOrdinal("Estatus")),
                        Comentario = reader.IsDBNull(reader.GetOrdinal("Comentario")) ? null : reader.GetString(reader.GetOrdinal("Comentario")),
                        Ubicacion = reader.IsDBNull(reader.GetOrdinal("Ubicacion")) ? null : reader.GetString(reader.GetOrdinal("Ubicacion")),
                        Forma = reader.IsDBNull(reader.GetOrdinal("Forma")) ? null : reader.GetString(reader.GetOrdinal("Forma")),
                        Tamaño = reader.IsDBNull(reader.GetOrdinal("Tamaño")) ? null : reader.GetString(reader.GetOrdinal("Tamaño")),
                        FactorUbicacion = reader.GetDecimal(reader.GetOrdinal("FactorUbicacion")),
                        FactorForma = reader.GetDecimal(reader.GetOrdinal("FactorForma")),
                        FactorTamaño = reader.GetDecimal(reader.GetOrdinal("FactorTamaño"))
                    };

                    lista.Add(item);
                }
            }

            return lista;
        }


        // Update
        public bool Actualizar(InventarioVentas inventario)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE tbl_InventarioVentas 
                                 SET Proyecto = @Proyecto, Etapa = @Etapa, Manzana = @Manzana, 
                                     Tipo = @Tipo, Cantidad = @Cantidad, Uso = @Uso, 
                                     AreaOcupadaVendible = @AreaOcupadaVendible, AreaEmpinada = @AreaEmpinada, 
                                     PrecioVentaSinEstacionamiento = @PrecioVentaSinEstacionamiento, 
                                     PrecioPorMetroCuadradoSinEstacionamiento = @PrecioPorMetroCuadradoSinEstacionamiento, 
                                     AreaOcupadaTotal = @AreaOcupadaTotal, ListaPreciosRegular = @ListaPreciosRegular, 
                                     ListaPreciosFeria = @ListaPreciosFeria, ListaPreciosInversionistas = @ListaPreciosInversionistas, 
                                     Estatus = @Estatus, Comentario = @Comentario, Ubicacion = @Ubicacion, 
                                     Forma = @Forma, Tamaño = @Tamaño, FactorUbicacion = @FactorUbicacion, 
                                     FactorForma = @FactorForma, FactorTamaño = @FactorTamaño 
                                 WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Proyecto", inventario.Proyecto);
                cmd.Parameters.AddWithValue("@Etapa", inventario.Etapa);
                cmd.Parameters.AddWithValue("@Manzana", inventario.Manzana);
                cmd.Parameters.AddWithValue("@Tipo", inventario.Tipo);
                cmd.Parameters.AddWithValue("@Cantidad", inventario.Cantidad);
                cmd.Parameters.AddWithValue("@Uso", inventario.Uso);
                cmd.Parameters.AddWithValue("@AreaOcupadaVendible", inventario.AreaOcupadaVendible);
                cmd.Parameters.AddWithValue("@AreaEmpinada", (object)inventario.AreaEmpinada ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PrecioVentaSinEstacionamiento", inventario.PrecioVentaSinEstacionamiento);
                cmd.Parameters.AddWithValue("@PrecioPorMetroCuadradoSinEstacionamiento", inventario.PrecioPorMetroCuadradoSinEstacionamiento);
                cmd.Parameters.AddWithValue("@AreaOcupadaTotal", inventario.AreaOcupadaTotal);
                cmd.Parameters.AddWithValue("@ListaPreciosRegular", inventario.ListaPreciosRegular);
                cmd.Parameters.AddWithValue("@ListaPreciosFeria", inventario.ListaPreciosFeria);
                cmd.Parameters.AddWithValue("@ListaPreciosInversionistas", inventario.ListaPreciosInversionistas);
                cmd.Parameters.AddWithValue("@Estatus", inventario.Estatus);
                cmd.Parameters.AddWithValue("@Comentario", (object)inventario.Comentario ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Ubicacion", inventario.Ubicacion);
                cmd.Parameters.AddWithValue("@Forma", inventario.Forma);
                cmd.Parameters.AddWithValue("@Tamaño", inventario.Tamaño);
                cmd.Parameters.AddWithValue("@FactorUbicacion", inventario.FactorUbicacion);
                cmd.Parameters.AddWithValue("@FactorForma", inventario.FactorForma);
                cmd.Parameters.AddWithValue("@FactorTamaño", inventario.FactorTamaño);
                cmd.Parameters.AddWithValue("@Id", inventario.Id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Delete
        public bool Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM tbl_InventarioVentas WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}