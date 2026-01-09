
using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica.Compras
{
    public class oFacturaManual
    {
        public int Id { get; set; }
        public int IdComprobante { get; set; }
        public string NroComprobante { get; set; }
        public string Proveedor { get; set; }
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
        public int? TipoPago { get; set; }
        public string Nro_DocPago { get; set; }
        public string Cod_Detraccion { get; set; }
        public decimal? Porcentaje { get; set; }
        public decimal Detraccion { get; set; }
        public byte[] ImgFactura { get; set; }
        public string Glosa { get; set; }
        public int Usuario { get; set; }
        public DateTime FechaModifica { get; set; }
        public int ActivoFijo { get; set; }
    }

    public class FacturaManualCompra
    {
        private readonly string _connectionString;

        public FacturaManualCompra()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }

        public DataTable GetAll()
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM TBL_FacturaManual WHERE Estado  !=0";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(table);
            }

            return table;
        }

        public DataTable GetById(int id)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM TBL_FacturaManual WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);
            }

            return table;
        }

        public int Insert(oFacturaManual o)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = @"
                    INSERT INTO TBL_FacturaManual
                    (IdComprobante, NroComprobante, Proveedor, Empresa, Proyecto, Etapa, 
                     Compensacion, UsuarioCompensacion, FechaCompensacion, Moneda, TC, 
                     Total, GravaIgv, Igv, FechaEmision, FechaRecepcion, FechaVencimiento, 
                     FechaContable, Estado, TipoPago, Nro_DocPago, Cod_Detraccion, 
                     Porcentaje, Detraccion, ImgFactura, Glosa, Usuario, FechaModifica, ActivoFijo)
                    VALUES
                    (@IdComprobante, @NroComprobante, @Proveedor, @Empresa, @Proyecto, @Etapa, 
                     @Compensacion, @UsuarioCompensacion, @FechaCompensacion, @Moneda, @TC, 
                     @Total, @GravaIgv, @Igv, @FechaEmision, @FechaRecepcion, @FechaVencimiento, 
                     @FechaContable, @Estado, @TipoPago, @Nro_DocPago, @Cod_Detraccion, 
                     @Porcentaje, @Detraccion, @ImgFactura, @Glosa, @Usuario, @FechaModifica, @ActivoFijo);
                    SELECT SCOPE_IDENTITY();
                ";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@IdComprobante", o.IdComprobante);
                cmd.Parameters.AddWithValue("@NroComprobante", o.NroComprobante);
                cmd.Parameters.AddWithValue("@Proveedor", o.Proveedor);
                cmd.Parameters.AddWithValue("@Empresa", o.Empresa);
                cmd.Parameters.AddWithValue("@Proyecto", o.Proyecto);
                cmd.Parameters.AddWithValue("@Etapa", o.Etapa);
                cmd.Parameters.AddWithValue("@Compensacion", o.Compensacion);
                cmd.Parameters.AddWithValue("@UsuarioCompensacion", (object)o.UsuarioCompensacion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaCompensacion", (object)o.FechaCompensacion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Moneda", o.Moneda);
                cmd.Parameters.AddWithValue("@TC", o.TC);
                cmd.Parameters.AddWithValue("@Total", o.Total);
                cmd.Parameters.AddWithValue("@GravaIgv", o.GravaIgv);
                cmd.Parameters.AddWithValue("@Igv", (object)o.Igv ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaEmision", o.FechaEmision);
                cmd.Parameters.AddWithValue("@FechaRecepcion", o.FechaRecepcion);
                cmd.Parameters.AddWithValue("@FechaVencimiento", o.FechaVencimiento);
                cmd.Parameters.AddWithValue("@FechaContable", (object)o.FechaContable ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Estado", o.Estado);
                cmd.Parameters.AddWithValue("@TipoPago", (object)o.TipoPago ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Nro_DocPago", (object)o.Nro_DocPago ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Cod_Detraccion", (object)o.Cod_Detraccion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Porcentaje", (object)o.Porcentaje ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Detraccion", o.Detraccion);
                cmd.Parameters.Add("@ImgFactura", SqlDbType.Image).Value = (object)o.ImgFactura ?? DBNull.Value;
                cmd.Parameters.AddWithValue("@Glosa", (object)o.Glosa ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Usuario", o.Usuario);
                cmd.Parameters.AddWithValue("@FechaModifica", o.FechaModifica);
                cmd.Parameters.AddWithValue("@ActivoFijo", o.ActivoFijo);

                object result = cmd.ExecuteScalar();

                return Convert.ToInt32(result);
            }
        }

        public bool Update(oFacturaManual o)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = @"
                    UPDATE TBL_FacturaManual SET
                        IdComprobante=@IdComprobante,
                        NroComprobante=@NroComprobante,
                        Proveedor=@Proveedor,
                        Empresa=@Empresa,
                        Proyecto=@Proyecto,
                        Etapa=@Etapa,
                        Compensacion=@Compensacion,
                        UsuarioCompensacion=@UsuarioCompensacion,
                        FechaCompensacion=@FechaCompensacion,
                        Moneda=@Moneda,
                        TC=@TC,
                        Total=@Total,
                        GravaIgv=@GravaIgv,
                        Igv=@Igv,
                        FechaEmision=@FechaEmision,
                        FechaRecepcion=@FechaRecepcion,
                        FechaVencimiento=@FechaVencimiento,
                        FechaContable=@FechaContable,
                        Estado=@Estado,
                        TipoPago=@TipoPago,
                        Nro_DocPago=@Nro_DocPago,
                        Cod_Detraccion=@Cod_Detraccion,
                        Porcentaje=@Porcentaje,
                        Detraccion=@Detraccion,
                        ImgFactura=@ImgFactura,
                        Glosa=@Glosa,
                        Usuario=@Usuario,
                        FechaModifica=@FechaModifica,
                        ActivoFijo=@ActivoFijo
                    WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", o.Id);
                cmd.Parameters.AddWithValue("@IdComprobante", o.IdComprobante);
                cmd.Parameters.AddWithValue("@NroComprobante", o.NroComprobante);
                cmd.Parameters.AddWithValue("@Proveedor", o.Proveedor);
                cmd.Parameters.AddWithValue("@Empresa", o.Empresa);
                cmd.Parameters.AddWithValue("@Proyecto", o.Proyecto);
                cmd.Parameters.AddWithValue("@Etapa", o.Etapa);
                cmd.Parameters.AddWithValue("@Compensacion", o.Compensacion);
                cmd.Parameters.AddWithValue("@UsuarioCompensacion", (object)o.UsuarioCompensacion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaCompensacion", (object)o.FechaCompensacion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Moneda", o.Moneda);
                cmd.Parameters.AddWithValue("@TC", o.TC);
                cmd.Parameters.AddWithValue("@Total", o.Total);
                cmd.Parameters.AddWithValue("@GravaIgv", o.GravaIgv);
                cmd.Parameters.AddWithValue("@Igv", (object)o.Igv ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaEmision", o.FechaEmision);
                cmd.Parameters.AddWithValue("@FechaRecepcion", o.FechaRecepcion);
                cmd.Parameters.AddWithValue("@FechaVencimiento", o.FechaVencimiento);
                cmd.Parameters.AddWithValue("@FechaContable", (object)o.FechaContable ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Estado", o.Estado);
                cmd.Parameters.AddWithValue("@TipoPago", (object)o.TipoPago ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Nro_DocPago", (object)o.Nro_DocPago ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Cod_Detraccion", (object)o.Cod_Detraccion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Porcentaje", (object)o.Porcentaje ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Detraccion", o.Detraccion);
                cmd.Parameters.AddWithValue("@ImgFactura", (object)o.ImgFactura ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Glosa", (object)o.Glosa ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Usuario", o.Usuario);
                cmd.Parameters.AddWithValue("@FechaModifica", o.FechaModifica);
                cmd.Parameters.AddWithValue("@ActivoFijo", o.ActivoFijo);

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = "UPDATE TBL_FacturaManual SET Estado = 0 WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
