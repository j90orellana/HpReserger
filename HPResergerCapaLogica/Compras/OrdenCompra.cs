using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica.Compras
{
    public class OrdenCompra
    {
        private readonly string _connectionString;

        public OrdenCompra()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }
        public class oOrdenCompra
        {
            public int Id { get; set; } = 0;
            public int IdEmpresa { get; set; } = 0;
            public int TipoIdProveedor { get; set; } = 0;
            public string RucProveedor { get; set; } = "";
            public string NumOrden { get; set; } = "";
            public int TipoOrden { get; set; } = 0;
            public DateTime FechaEmision { get; set; }
            public DateTime? FechaEntrega { get; set; } = null;
            public DateTime? FechaPago { get; set; } = null;
            public string Cotizacion { get; set; } = "";
            public string CentroCosto { get; set; } = "";
            public int Moneda { get; set; } = 0;
            public string Condiciones { get; set; } = "";
            public string Observaciones { get; set; } = "";
            public decimal Subtotal { get; set; } = 0;
            public int Porcentaje { get; set; } = 0;
            public decimal Impuesto { get; set; } = 0;
            public decimal Total { get; set; } = 0;
            public string ContactoSolicitante { get; set; } = "";
            public string TelefonoSolicitante { get; set; } = "";
            public string CorreoSolicitante { get; set; } = "";
            public string Terminos { get; set; } = "";
            public string Referencia { get; set; } = "";
            public int Aprobador1 { get; set; } = 0;
            public int Aprobador2 { get; set; } = 0;
            public DateTime? Aprobador1Fecha { get; set; } = null;
            public string Aprobador1Comentario { get; set; } = "";
            public DateTime? Aprobador2Fecha { get; set; } = null;
            public string Aprobador2Comentario { get; set; } = "";
            public int UsuarioCreador { get; set; } = 0;
            public int EstadoOrden { get; set; } = 0;
            public int Estado { get; set; } = 0;
            public DateTime Fecha { get; set; } = DateTime.Now;
            public int? UsuarioModifica { get; set; } = null;
            public DateTime? FechaModifica { get; set; } = null;
        }

        public object ListarOrdenesxAño(DateTime Fecha)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"

                    select 
                    e.Empresa empresa, id id,rucProveedor ruc, p.razon_social razonSocial,
                    fechaEmision fechaEmision,
                    fechaEntrega fechaEntrega,
                    fechaPago fechaPago,
                    m.Moneda,
                    total total,
                    case estadoorden
                    when 0 then 'Pendiente'
                    when 1 then 'Aprobada Parcial'
                    when 2 then 'Aprobada' 
                    when 3 then 'Rechazada' 
                    when 5 then 'Facturada' 
	                       else 'Sin Estado'
                    end nEstadoOrden
                    ,
                    case estado
                    when 1 then 'Activa'
                    when 0 then 'Anulada' 
                    end NEstado, numOrden

                    from tbl_OrdenCompra o
                    inner join tbl_empresa e on o.idEmpresa  = e.Id_Empresa
                    inner join TBL_Moneda m on o.moneda = m.Id_Moneda
                    left join TBL_Proveedor p on p.RUC = o.rucProveedor

                    where 
                    year(FechaEmision)= year(@fecha	)

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

        public class OrdenCompraDet
        {
            public int Id { get; set; } = 0;
            public int IdOrdenCompra { get; set; } = 0;
            public int Item { get; set; } = 0;
            public string Codigo { get; set; } = "";
            public string Descripcion { get; set; } = "";
            public int Unidad { get; set; } = 0;
            public decimal Cantidad { get; set; } = 0;
            public string Entrega { get; set; } = "";
            public decimal PrecioUnitario { get; set; } = 0;
            public decimal Descuento { get; set; } = 0;
            public decimal Total { get; set; } = 0;

            public int UsuarioCreador { get; set; } = 0;
            public DateTime Fecha { get; set; } = DateTime.Now;
        }

        public DataTable OrdenDelUsuarioLogeado(int idOrden, int usuario)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(_connectionString))
            {
                string query = @"select * from tbl_OrdenCompra where id =@id and (aprobador1 = @usuario or aprobador2 = @usuario)";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@id", idOrden);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cn.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;

        }

        // -------------------------
        // INSERT (retorna ID)
        // -------------------------
        public int Insertar(oOrdenCompra o)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                INSERT INTO tbl_OrdenCompra (
                    idEmpresa, tipoIdProveedor, rucProveedor, numOrden, tipoOrden,
                    fechaEmision, fechaEntrega, fechaPago, cotizacion, centroCosto,
                    moneda, condiciones, observaciones, subtotal, porcentaje,
                    impuesto, total, contactoSolicitante, telefonoSolicitante,
                    correoSolicitante, terminos, referencia, aprobador1, aprobador2,
                    usuarioCreador, estadoOrden, estado
                ) VALUES (
                    @idEmpresa, @tipoIdProveedor, @rucProveedor, @numOrden, @tipoOrden,
                    @fechaEmision, @fechaEntrega, @fechaPago, @cotizacion, @centroCosto,
                    @moneda, @condiciones, @observaciones, @subtotal, @porcentaje,
                    @impuesto, @total, @contactoSolicitante, @telefonoSolicitante,
                    @correoSolicitante, @terminos, @referencia, @aprobador1, @aprobador2,
                    @usuarioCreador, @estadoOrden, @estado
                );
                SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idEmpresa", o.IdEmpresa);
                    cmd.Parameters.AddWithValue("@tipoIdProveedor", o.TipoIdProveedor);
                    cmd.Parameters.AddWithValue("@rucProveedor", o.RucProveedor);
                    cmd.Parameters.AddWithValue("@numOrden", o.NumOrden);
                    cmd.Parameters.AddWithValue("@tipoOrden", o.TipoOrden);
                    cmd.Parameters.AddWithValue("@fechaEmision", o.FechaEmision);
                    cmd.Parameters.AddWithValue("@fechaEntrega", (object)o.FechaEntrega ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@fechaPago", (object)o.FechaPago ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@cotizacion", o.Cotizacion);
                    cmd.Parameters.AddWithValue("@centroCosto", o.CentroCosto);
                    cmd.Parameters.AddWithValue("@moneda", o.Moneda);
                    cmd.Parameters.AddWithValue("@condiciones", o.Condiciones);
                    cmd.Parameters.AddWithValue("@observaciones", o.Observaciones);
                    cmd.Parameters.AddWithValue("@subtotal", o.Subtotal);
                    cmd.Parameters.AddWithValue("@porcentaje", o.Porcentaje);
                    cmd.Parameters.AddWithValue("@impuesto", o.Impuesto);
                    cmd.Parameters.AddWithValue("@total", o.Total);
                    cmd.Parameters.AddWithValue("@contactoSolicitante", o.ContactoSolicitante);
                    cmd.Parameters.AddWithValue("@telefonoSolicitante", o.TelefonoSolicitante);
                    cmd.Parameters.AddWithValue("@correoSolicitante", o.CorreoSolicitante);
                    cmd.Parameters.AddWithValue("@terminos", o.Terminos);
                    cmd.Parameters.AddWithValue("@referencia", o.Referencia);
                    cmd.Parameters.AddWithValue("@aprobador1", o.Aprobador1);
                    cmd.Parameters.AddWithValue("@aprobador2", o.Aprobador2);
                    cmd.Parameters.AddWithValue("@usuarioCreador", o.UsuarioCreador);
                    cmd.Parameters.AddWithValue("@estadoOrden", o.EstadoOrden);
                    cmd.Parameters.AddWithValue("@estado", o.Estado);

                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // -------------------------
        // UPDATE (retorna 1 o 0)
        // -------------------------
        public int Actualizar(oOrdenCompra o)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                UPDATE tbl_OrdenCompra SET
                    idEmpresa = @idEmpresa,
                    tipoIdProveedor = @tipoIdProveedor,
                    rucProveedor = @rucProveedor,
                    numOrden = @numOrden,
                    tipoOrden = @tipoOrden,
                    fechaEmision = @fechaEmision,
                    fechaEntrega = @fechaEntrega,
                    fechaPago = @fechaPago,
                    cotizacion = @cotizacion,
                    centroCosto = @centroCosto,
                    moneda = @moneda,
                    condiciones = @condiciones,
                    observaciones = @observaciones,
                    subtotal = @subtotal,
                    porcentaje = @porcentaje,
                    impuesto = @impuesto,
                    total = @total,
                    contactoSolicitante = @contactoSolicitante,
                    telefonoSolicitante = @telefonoSolicitante,
                    correoSolicitante = @correoSolicitante,
                    terminos = @terminos,
                    referencia = @referencia,
                    aprobador1 = @aprobador1,
                    aprobador2 = @aprobador2,
                    usuarioModifica = @usuarioModifica,
                    fechaModifica = GETDATE(),
                    estadoOrden = @estadoOrden,
                    estado = @estado
                WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", o.Id);
                    cmd.Parameters.AddWithValue("@idEmpresa", o.IdEmpresa);
                    cmd.Parameters.AddWithValue("@tipoIdProveedor", o.TipoIdProveedor);
                    cmd.Parameters.AddWithValue("@rucProveedor", o.RucProveedor);
                    cmd.Parameters.AddWithValue("@numOrden", o.NumOrden);
                    cmd.Parameters.AddWithValue("@tipoOrden", o.TipoOrden);
                    cmd.Parameters.AddWithValue("@fechaEmision", o.FechaEmision);
                    cmd.Parameters.AddWithValue("@fechaEntrega", (object)o.FechaEntrega ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@fechaPago", (object)o.FechaPago ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@cotizacion", o.Cotizacion);
                    cmd.Parameters.AddWithValue("@centroCosto", o.CentroCosto);
                    cmd.Parameters.AddWithValue("@moneda", o.Moneda);
                    cmd.Parameters.AddWithValue("@condiciones", o.Condiciones);
                    cmd.Parameters.AddWithValue("@observaciones", o.Observaciones);
                    cmd.Parameters.AddWithValue("@subtotal", o.Subtotal);
                    cmd.Parameters.AddWithValue("@porcentaje", o.Porcentaje);
                    cmd.Parameters.AddWithValue("@impuesto", o.Impuesto);
                    cmd.Parameters.AddWithValue("@total", o.Total);
                    cmd.Parameters.AddWithValue("@contactoSolicitante", o.ContactoSolicitante);
                    cmd.Parameters.AddWithValue("@telefonoSolicitante", o.TelefonoSolicitante);
                    cmd.Parameters.AddWithValue("@correoSolicitante", o.CorreoSolicitante);
                    cmd.Parameters.AddWithValue("@terminos", o.Terminos);
                    cmd.Parameters.AddWithValue("@referencia", o.Referencia);
                    cmd.Parameters.AddWithValue("@aprobador1", o.Aprobador1);
                    cmd.Parameters.AddWithValue("@aprobador2", o.Aprobador2);
                    cmd.Parameters.AddWithValue("@usuarioModifica", (object)o.UsuarioModifica ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@estadoOrden", o.EstadoOrden);
                    cmd.Parameters.AddWithValue("@estado", o.Estado);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // -------------------------
        // DELETE (retorna 1 o 0)
        // -------------------------
        public int Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM tbl_OrdenCompra WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public int EliminarLogico(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                                update a set estado = 0 from tbl_OrdenCompra a where id = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public int ActualizarNumOrden(int id, string numeroOrden)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                                update a set numOrden = @numero
                                from tbl_OrdenCompra a where id = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@numero", numeroOrden);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        // -------------------------
        // GET ALL (retorna DataTable)
        // -------------------------
        public DataTable ObtenerTodo()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM tbl_OrdenCompra ORDER BY id DESC";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // -------------------------
        // GET BY ID (retorna DataTable)
        // -------------------------
        public DataTable ObtenerPorID(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM tbl_OrdenCompra WHERE id = @id";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@id", id);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }

        }
        public int RechazarOrden(int idOrden, int idUsuario, string comentario)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
        UPDATE tbl_OrdenCompra
        SET 
            EstadoOrden = 3, -- RECHAZADO
            usuarioModifica = @usuario,
            fechaModifica = GETDATE(),
            aprobador1Comentario = CASE WHEN aprobador1 = @usuario THEN @comentario END,
            aprobador2Comentario = CASE WHEN aprobador2 = @usuario THEN @comentario END
        WHERE id = @idOrden;

        SELECT @@ROWCOUNT;
        ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idOrden", idOrden);
                    cmd.Parameters.AddWithValue("@usuario", idUsuario);
                    cmd.Parameters.AddWithValue("@comentario", comentario ?? "");

                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public int AprobarOrden(int idOrden, int idUsuario, string comentario)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
      
                    --APROBADOR 1
                    UPDATE O SET aprobador1Comentario = @comentario,
                    aprobador1Fecha = GETDATE()
                     from tbl_OrdenCompra o
                    where id = @idorden
                    and aprobador1 = @usuario


                    --APROBADOR 2
                    UPDATE O SET aprobador2Comentario = @comentario,
                    aprobador2Fecha = GETDATE()
                     from tbl_OrdenCompra o
                    where id = @idorden
                    and aprobador2 = @usuario

                    update o set
                    estadoOrden = case
                    when aprobador1Fecha is not null and aprobador2Fecha is not null then 2
                    when aprobador1Fecha is null and aprobador2Fecha is null then  0
                    else 1
                    end
                    from tbl_OrdenCompra o
                    where id = @idorden


        SELECT @@ROWCOUNT;
        ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idOrden", idOrden);
                    cmd.Parameters.AddWithValue("@usuario", idUsuario);
                    cmd.Parameters.AddWithValue("@comentario", comentario ?? "");

                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }


        public DataTable GetByOrden(int idOrdenCompra)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(_connectionString))
            {
                string query = @"SELECT * 
                                 FROM tbl_OrdenCompraDet
                                 WHERE IdOrdenCompra = @IdOrdenCompra
                                 ORDER BY Item";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@IdOrdenCompra", idOrdenCompra);
                    cn.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }
        // =====================================================
        // INSERT → retorna ID generado
        // =====================================================
        public int Insert(OrdenCompraDet obj)
        {
            using (SqlConnection cn = new SqlConnection(_connectionString))
            {
                string query = @"
                    INSERT INTO tbl_OrdenCompraDet
                    (IdOrdenCompra, Item, Codigo, Descripcion, Unidad, Cantidad,
                     Entrega, PrecioUnitario, Descuento, Total, UsuarioCreador)
                    OUTPUT INSERTED.Id
                    VALUES
                    (@IdOrdenCompra, @Item, @Codigo, @Descripcion, @Unidad, @Cantidad,
                     @Entrega, @PrecioUnitario, @Descuento, @Total, @UsuarioCreador)";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@IdOrdenCompra", obj.IdOrdenCompra);
                    cmd.Parameters.AddWithValue("@Item", obj.Item);
                    cmd.Parameters.AddWithValue("@Codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("@Unidad", obj.Unidad);
                    cmd.Parameters.AddWithValue("@Cantidad", obj.Cantidad);
                    cmd.Parameters.AddWithValue("@Entrega", obj.Entrega);
                    cmd.Parameters.AddWithValue("@PrecioUnitario", obj.PrecioUnitario);
                    cmd.Parameters.AddWithValue("@Descuento", obj.Descuento);
                    cmd.Parameters.AddWithValue("@Total", obj.Total);
                    cmd.Parameters.AddWithValue("@UsuarioCreador", obj.UsuarioCreador);

                    cn.Open();

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // =====================================================
        // UPDATE → retorna número de filas afectadas
        // =====================================================
        public int Update(OrdenCompraDet obj)
        {
            using (SqlConnection cn = new SqlConnection(_connectionString))
            {
                string query = @"
                    UPDATE tbl_OrdenCompraDet
                    SET Item = @Item,
                        Codigo = @Codigo,
                        Descripcion = @Descripcion,
                        Unidad = @Unidad,
                        Cantidad = @Cantidad,
                        Entrega = @Entrega,
                        PrecioUnitario = @PrecioUnitario,
                        Descuento = @Descuento,
                        Total = @Total
                    WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Id", obj.Id);
                    cmd.Parameters.AddWithValue("@Item", obj.Item);
                    cmd.Parameters.AddWithValue("@Codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("@Unidad", obj.Unidad);
                    cmd.Parameters.AddWithValue("@Cantidad", obj.Cantidad);
                    cmd.Parameters.AddWithValue("@Entrega", obj.Entrega);
                    cmd.Parameters.AddWithValue("@PrecioUnitario", obj.PrecioUnitario);
                    cmd.Parameters.AddWithValue("@Descuento", obj.Descuento);
                    cmd.Parameters.AddWithValue("@Total", obj.Total);

                    cn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // =====================================================
        // DELETE → retorna número de filas afectadas
        // =====================================================
        public int Delete(int id)
        {
            using (SqlConnection cn = new SqlConnection(_connectionString))
            {
                string query = @"DELETE FROM tbl_OrdenCompraDet WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public int DeleteByOrden(int idOrdenCompra)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM TBL_OrdenCompraDet WHERE IdOrdenCompra = @IdOrdenCompra", conn))
                {
                    cmd.Parameters.AddWithValue("@IdOrdenCompra", idOrdenCompra);

                    conn.Open();
                    int filas = cmd.ExecuteNonQuery();
                    return filas;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el detalle de la Orden de Compra: " + ex.Message, ex);
            }
        }

    }

}
