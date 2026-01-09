using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica.Compras
{  
    public class oNC_ND_CompraManual
    {
        public int Id { get; set; }
        public int IdComprobante { get; set; }
        public string NroComprobante { get; set; }
        public string Proveedor { get; set; }
        public string NroComprobante_Ref { get; set; }
        public int Empresa { get; set; }
        public int Proyecto { get; set; }
        public int Etapa { get; set; }
        public int Compensacion { get; set; }
        public string UsuarioCompensacion { get; set; }
        public DateTime? FechaCompensacion { get; set; }
        public int Moneda { get; set; }
        public decimal TC { get; set; }
        public decimal Total { get; set; }
        public int GravaIgv { get; set; }
        public decimal? Igv { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime? FechaContable { get; set; }
        public int Estado { get; set; }
        public byte[] ImgFactura { get; set; }
        public string Glosa { get; set; }
        public int Usuario { get; set; }
        public DateTime FechaModifica { get; set; }
    }


    public class NC_ND_CompraManualCompra
    {
        private readonly string _connectionString;

        public NC_ND_CompraManualCompra()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM TBL_NC_ND_CompraManual WHERE Estado = 1";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
        
        public oNC_ND_CompraManual GetById(int id)
        {
            oNC_ND_CompraManual obj = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM TBL_NC_ND_CompraManual WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    obj = new oNC_ND_CompraManual()
                    {
                        Id = (int)dr["Id"],
                        IdComprobante = (int)dr["IdComprobante"],
                        NroComprobante = dr["NroComprobante"].ToString(),
                        Proveedor = dr["Proveedor"].ToString(),
                        NroComprobante_Ref = dr["NroComprobante_Ref"].ToString(),
                        Empresa = (int)dr["Empresa"],
                        Proyecto = (int)dr["Proyecto"],
                        Etapa = (int)dr["Etapa"],
                        Compensacion = (int)dr["Compensacion"],
                        UsuarioCompensacion = dr["UsuarioCompensacion"] as string,
                        FechaCompensacion = dr["FechaCompensacion"] as DateTime?,
                        Moneda = (int)dr["Moneda"],
                        TC = (decimal)dr["TC"],
                        Total = (decimal)dr["Total"],
                        GravaIgv = (int)dr["GravaIgv"],
                        Igv = dr["Igv"] as decimal?,
                        FechaEmision = (DateTime)dr["FechaEmision"],
                        FechaRecepcion = (DateTime)dr["FechaRecepcion"],
                        FechaVencimiento = (DateTime)dr["FechaVencimiento"],
                        FechaContable = dr["FechaContable"] as DateTime?,
                        Estado = (int)dr["Estado"],
                        ImgFactura = dr["ImgFactura"] as byte[],
                        Glosa = dr["Glosa"] as string,
                        Usuario = (int)dr["Usuario"],
                        FechaModifica = (DateTime)dr["FechaModifica"]
                    };
                }
            }

            return obj;
        }

        // =======================================================
        // INSERT — RETORNA ID
        // =======================================================
        public int Insert(oNC_ND_CompraManual obj)
        {
            int idGenerado = 0;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = @"
                INSERT INTO TBL_NC_ND_CompraManual
                (IdComprobante, NroComprobante, Proveedor, NroComprobante_Ref, Empresa, Proyecto, Etapa, 
                 Compensacion, UsuarioCompensacion, FechaCompensacion, Moneda, TC, Total, GravaIgv, Igv,
                 FechaEmision, FechaRecepcion, FechaVencimiento, FechaContable, Estado, ImgFactura, Glosa, Usuario, FechaModifica)
                VALUES
                (@IdComprobante, @NroComprobante, @Proveedor, @NroComprobante_Ref, @Empresa, @Proyecto, @Etapa,
                 @Compensacion, @UsuarioCompensacion, @FechaCompensacion, @Moneda, @TC, @Total, @GravaIgv, @Igv,
                 @FechaEmision, @FechaRecepcion, @FechaVencimiento, @FechaContable, @Estado, @ImgFactura, @Glosa, @Usuario, @FechaModifica);
                SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@IdComprobante", obj.IdComprobante);
                cmd.Parameters.AddWithValue("@NroComprobante", obj.NroComprobante);
                cmd.Parameters.AddWithValue("@Proveedor", obj.Proveedor);
                cmd.Parameters.AddWithValue("@NroComprobante_Ref", obj.NroComprobante_Ref);
                cmd.Parameters.AddWithValue("@Empresa", obj.Empresa);
                cmd.Parameters.AddWithValue("@Proyecto", obj.Proyecto);
                cmd.Parameters.AddWithValue("@Etapa", obj.Etapa);
                cmd.Parameters.AddWithValue("@Compensacion", obj.Compensacion);

                cmd.Parameters.AddWithValue("@UsuarioCompensacion", (object)obj.UsuarioCompensacion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaCompensacion", (object)obj.FechaCompensacion ?? DBNull.Value);


                cmd.Parameters.AddWithValue("@Moneda", obj.Moneda);
                cmd.Parameters.AddWithValue("@TC", obj.TC);
                cmd.Parameters.AddWithValue("@Total", obj.Total);
                cmd.Parameters.AddWithValue("@GravaIgv", obj.GravaIgv);
                cmd.Parameters.AddWithValue("@Igv", (object)obj.Igv ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@FechaEmision", obj.FechaEmision);
                cmd.Parameters.AddWithValue("@FechaRecepcion", obj.FechaRecepcion);
                cmd.Parameters.AddWithValue("@FechaVencimiento", obj.FechaVencimiento);
                cmd.Parameters.AddWithValue("@FechaContable", (object)obj.FechaContable ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@Estado", obj.Estado);
                cmd.Parameters.AddWithValue("@ImgFactura", (object)obj.ImgFactura ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Glosa", (object)obj.Glosa ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Usuario", obj.Usuario);
                cmd.Parameters.AddWithValue("@FechaModifica", obj.FechaModifica);

                idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return idGenerado;
        }

        public bool Update(oNC_ND_CompraManual obj)
        {
            bool ok = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = @"
                UPDATE TBL_NC_ND_CompraManual SET
                    IdComprobante = @IdComprobante,
                    NroComprobante = @NroComprobante,
                    Proveedor = @Proveedor,
                    NroComprobante_Ref = @NroComprobante_Ref,
                    Empresa = @Empresa,
                    Proyecto = @Proyecto,
                    Etapa = @Etapa,
                    Compensacion = @Compensacion,
                    UsuarioCompensacion = @UsuarioCompensacion,
                    FechaCompensacion = @FechaCompensacion,
                    Moneda = @Moneda,
                    TC = @TC,
                    Total = @Total,
                    GravaIgv = @GravaIgv,
                    Igv = @Igv,
                    FechaEmision = @FechaEmision,
                    FechaRecepcion = @FechaRecepcion,
                    FechaVencimiento = @FechaVencimiento,
                    FechaContable = @FechaContable,
                    Estado = @Estado,
                    ImgFactura = @ImgFactura,
                    Glosa = @Glosa,
                    Usuario = @Usuario,
                    FechaModifica = @FechaModifica
                WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", obj.Id);
                cmd.Parameters.AddWithValue("@IdComprobante", obj.IdComprobante);
                cmd.Parameters.AddWithValue("@NroComprobante", obj.NroComprobante);
                cmd.Parameters.AddWithValue("@Proveedor", obj.Proveedor);
                cmd.Parameters.AddWithValue("@NroComprobante_Ref", obj.NroComprobante_Ref);
                cmd.Parameters.AddWithValue("@Empresa", obj.Empresa);
                cmd.Parameters.AddWithValue("@Proyecto", obj.Proyecto);
                cmd.Parameters.AddWithValue("@Etapa", obj.Etapa);
                cmd.Parameters.AddWithValue("@Compensacion", obj.Compensacion);

                cmd.Parameters.AddWithValue("@UsuarioCompensacion", (object)obj.UsuarioCompensacion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaCompensacion", (object)obj.FechaCompensacion ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@Moneda", obj.Moneda);
                cmd.Parameters.AddWithValue("@TC", obj.TC);
                cmd.Parameters.AddWithValue("@Total", obj.Total);
                cmd.Parameters.AddWithValue("@GravaIgv", obj.GravaIgv);
                cmd.Parameters.AddWithValue("@Igv", (object)obj.Igv ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@FechaEmision", obj.FechaEmision);
                cmd.Parameters.AddWithValue("@FechaRecepcion", obj.FechaRecepcion);
                cmd.Parameters.AddWithValue("@FechaVencimiento", obj.FechaVencimiento);
                cmd.Parameters.AddWithValue("@FechaContable", (object)obj.FechaContable ?? DBNull.Value);

                cmd.Parameters.AddWithValue("@Estado", obj.Estado);
                cmd.Parameters.AddWithValue("@ImgFactura", (object)obj.ImgFactura ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Glosa", (object)obj.Glosa ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Usuario", obj.Usuario);
                cmd.Parameters.AddWithValue("@FechaModifica", obj.FechaModifica);

                ok = cmd.ExecuteNonQuery() > 0;
            }

            return ok;
        }
          
        public bool Delete(int id)
        {
            bool ok = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = @"UPDATE TBL_NC_ND_CompraManual SET Estado = 0 WHERE Id = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                ok = cmd.ExecuteNonQuery() > 0;
            }

            return ok;
        }
    }
}
