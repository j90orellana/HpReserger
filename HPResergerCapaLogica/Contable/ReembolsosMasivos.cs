using System;
using System.Data;
using System.Data.SqlClient;
using static HPResergerCapaLogica.Contable.ReembolsoMasivoDetalle;

namespace HPResergerCapaLogica.Contable
{
    public class ReembolsoMasivoDetalle
    {
        public class oReembolsoMasivoDetalle
        {
            public int Id { get; set; } = 0;
            public int Item { get; set; } = 0;
            public int IdReembolso { get; set; } = 0;
            public int TipoFactura { get; set; } = 0;
            public int IdFactura { get; set; } = 0;
            public int Usuario { get; set; } = 0;
        }
    }

    public class ReembolsosMasivos
    {
        private readonly string _connectionString;

        public ReembolsosMasivos()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }
        public object ListarRendicionesporAÑo(DateTime Fecha)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"

                    select 
                    e.Empresa empresa, id id,p.Nro_ID_Emp numeroDni, dbo.NombreEmpleado(p.Tipo_ID_Emp,p.Nro_ID_Emp) nombreEmpleado,
                    FechaCreacion fechaEmision,
                    m.Moneda moneda,
                    total total,
                    case o.Estado
                    when 1 then 'Activa'
                    when 0 then 'Anulada' 
                    end estado, concat(FORMAT(o.FechaCreacion,'yyyy-MM-'),FORMAT(o.id,'00')) correlativo,glosa

                    from TBL_ReembolsosMasivos o
                    inner join tbl_empresa e on o.idEmpresa  = e.Id_Empresa
                    inner join TBL_Moneda m on o.IdMoneda = m.Id_Moneda
                    left join TBL_Empleado p on p.Cod_Emp = o.IdEmpleado

                    where 
                    year(o.FechaCreacion)= year(@fecha	)

                    order by id desc

";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fecha", Fecha);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        public class oReembolsoMasivo
        {
            public int Id { get; set; } = 0;
            public int IdEmpresa { get; set; } = 0;
            public int IdEmpleado { get; set; } = 0;
            public string Glosa { get; set; } = "";
            public DateTime FechaCreacion { get; set; } = DateTime.Now;
            public int IdMoneda { get; set; } = 0;
            public decimal Total { get; set; } = 0;
            public int EstadoReembolso { get; set; } = 0; // 0 Pendiente | 1 Aprobado | 2 Rechazado
            public int Estado { get; set; } = 1;
            public int IdUsuario { get; set; } = 0;
            public DateTime Fecha { get; set; } = DateTime.Now;
        }
        public int Insertar(oReembolsoMasivo o)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                INSERT INTO TBL_ReembolsosMasivos
                (IdEmpresa, IdEmpleado, Glosa, FechaCreacion, IdMoneda,
                 Total, EstadoReembolso, Estado, IdUsuario, Fecha)
                VALUES
                (@IdEmpresa, @IdEmpleado, @Glosa, GETDATE(), @IdMoneda,
                 @Total, @EstadoReembolso, @Estado, @IdUsuario, GETDATE());

                SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdEmpresa", o.IdEmpresa);
                    cmd.Parameters.AddWithValue("@IdEmpleado", o.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Glosa", o.Glosa);
                    cmd.Parameters.AddWithValue("@IdMoneda", o.IdMoneda);
                    cmd.Parameters.AddWithValue("@Total", o.Total);
                    cmd.Parameters.AddWithValue("@EstadoReembolso", o.EstadoReembolso);
                    cmd.Parameters.AddWithValue("@Estado", o.Estado);
                    cmd.Parameters.AddWithValue("@IdUsuario", o.IdUsuario);

                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public int Insert(oReembolsoMasivoDetalle obj)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
            INSERT INTO TBL_ReembolsosMasivosDetalle
            (IdReembolso, TipoFactura, IdFactura, Usuario,Item)
            OUTPUT INSERTED.Id
            VALUES (@IdReembolso, @TipoFactura, @IdFactura, @Usuario,@Item)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@IdReembolso", obj.IdReembolso);
                cmd.Parameters.AddWithValue("@TipoFactura", obj.TipoFactura);
                cmd.Parameters.AddWithValue("@IdFactura", obj.IdFactura);
                cmd.Parameters.AddWithValue("@Usuario", obj.Usuario);
                cmd.Parameters.AddWithValue("@Item", obj.Item);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        public bool DeleteDetalle(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"DELETE FROM TBL_ReembolsosMasivosDetalle WHERE IdReembolso = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }


        // =====================================================
        // UPDATE → retorna filas afectadas
        // =====================================================
        public int Actualizar(oReembolsoMasivo o)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                UPDATE TBL_ReembolsosMasivos SET
                    IdEmpresa = @IdEmpresa,
                    IdEmpleado = @IdEmpleado,
                    Glosa = @Glosa,
                    IdMoneda = @IdMoneda,
                    Total = @Total,
                    EstadoReembolso = @EstadoReembolso,
                    Estado = @Estado
                WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", o.Id);
                    cmd.Parameters.AddWithValue("@IdEmpresa", o.IdEmpresa);
                    cmd.Parameters.AddWithValue("@IdEmpleado", o.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Glosa", o.Glosa);
                    cmd.Parameters.AddWithValue("@IdMoneda", o.IdMoneda);
                    cmd.Parameters.AddWithValue("@Total", o.Total);
                    cmd.Parameters.AddWithValue("@EstadoReembolso", o.EstadoReembolso);
                    cmd.Parameters.AddWithValue("@Estado", o.Estado);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // =====================================================
        // DELETE FÍSICO → retorna filas afectadas
        // =====================================================
        public int Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM TBL_ReembolsosMasivos WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // =====================================================
        // DELETE LÓGICO → retorna filas afectadas
        // =====================================================
        public int EliminarLogico(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                UPDATE TBL_ReembolsosMasivos
                SET Estado = 0
                WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // =====================================================
        // GET ALL → DataTable
        // =====================================================
        public DataTable ObtenerTodo()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                SELECT *
                FROM TBL_ReembolsosMasivos
                WHERE Estado = 1
                ORDER BY Id DESC";

                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // =====================================================
        // GET BY ID → DataTable
        // =====================================================
        public DataTable ObtenerPorID(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM TBL_ReembolsosMasivos WHERE Id = @Id";

                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@Id", id);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable GetReembolsoDetalle(int IdReembolso)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                                 
                  
                    select 
                    d.id Id,item,IdReembolso,d.TipoFactura TipoFactura,d.IdFactura,idComprobante IdComprobante,ruc Proveedor,
                    fechaEmision FechaEmision,Glosa,NroComprobante,Serie,Numero,idPartida IdPartida,TipoPartida,Total,
                    ar.Archivo DocArchivoAdjunto, ar.NombreArchivo DocNombreArchivo, ar.Extension DocExtension,
                    ar2.Archivo SusArchivoAdjunto, ar2.NombreArchivo SusNombreArchivo, ar2.Extension SusExtension

                    from TBL_ReembolsosMasivosDetalle d
                    inner join (select 1 tipoFactura,Id idFactura,IdComprobante idComprobante,Proveedor ruc,FechaEmision fechaEmision,Glosa,
                    Total, f.Estado,
                    NroComprobante,
                        Serie  = LEFT(NroComprobante, CHARINDEX('-', NroComprobante) - 1),
                        Numero = SUBSTRING(
                            NroComprobante,
                            CHARINDEX('-', NroComprobante) + 1,
                            LEN(NroComprobante)
                        ) from TBL_FacturaManual f
	                    union all

	                    select 2 tipoFactura,Id idFactura,IdComprobante idComprobante,Proveedor ruc,FechaEmision fechaEmision,Glosa,
                    Total,f.Estado,
                    NroComprobante,
                        Serie  = LEFT(NroComprobante, CHARINDEX('-', NroComprobante) - 1),
                        Numero = SUBSTRING(
                            NroComprobante,
                            CHARINDEX('-', NroComprobante) + 1,
                            LEN(NroComprobante)
                        ) from TBL_NC_ND_CompraManual f
	
	
	                    ) f on f.idFactura = d.IdFactura and f.tipoFactura = d.TipoFactura

	                    left join TBL_FacturasPresupuestos fp on fp.TipoFactura = d.TipoFactura and fp.idFactura = d.IdFactura
	                    left join TBL_FacturaArchivos ar on ar.TipoFactura = d.TipoFactura and ar.IdFactura =d.IdFactura and ar.Tipo=1
	                    left join TBL_FacturaArchivos ar2 on ar2.TipoFactura = d.TipoFactura and ar2.IdFactura =d.IdFactura and ar2.Tipo=2
                    where IdReembolso =@IdReembolso
";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdReembolso", IdReembolso);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // =====================================================
        // LISTAR POR EMPRESA Y FECHA
        // =====================================================
        public DataTable ListarPorEmpresaFecha(int idEmpresa, DateTime fecha)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                SELECT *
                FROM TBL_ReembolsosMasivos
                WHERE IdEmpresa = @IdEmpresa
                  AND YEAR(FechaCreacion) = YEAR(@Fecha)
                  AND Estado = 1
                ORDER BY FechaCreacion DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdEmpresa", idEmpresa);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}