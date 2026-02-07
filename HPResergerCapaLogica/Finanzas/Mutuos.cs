using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica.Finanzas
{
    public class Mutuos
    {
        private readonly string _cadenaConexion;

        public Mutuos()
        {
            _cadenaConexion = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }

        public class ContratoMutuoEntidad
        {
            public string NombreMutuante { get; set; }
            public string DocumentoMutuante { get; set; }
            public string DireccionMutuante { get; set; }
            public string NroCuentaMutuante { get; set; }
            public string NroCuentaCCIMutuante { get; set; }

            public string NombreEmpresa { get; set; }
            public string RucEmpresa { get; set; }
            public string Distrito { get; set; }
            public string CuentaBancariaEmpresa { get; set; }
            public string DireccionEmpresa { get; set; }
            public string RepresentanteLegal { get; set; }
            public string DniRepresentante { get; set; }
            public string PartidaRegistral { get; set; }

            public string Moneda { get; set; }
            public decimal MontoMutuo { get; set; }
            public string ImporteLetras { get; set; }

            public decimal Interes { get; set; }
            public string Meses { get; set; }
            public string InteresLetras { get; set; }

            public string ImpuestoAnual { get; set; }
            public string FechaEmision { get; set; }
            public string FechaVencimiento { get; set; }
            public int DiaPago { get; set; }

            public DataTable Cronograma { get; set; }

            public string tipoDocumento { get; set; }
            public string estadoCivil { get; set; }
        }

        public class MutuoCronogramaEntidad
        {
            public int Id { get; set; }
            public int IdMutuo { get; set; }

            public int Nro { get; set; }
            public DateTime Fecha { get; set; }

            public decimal Principal { get; set; }
            public decimal Amortizacion { get; set; }
            public decimal Interes { get; set; }
            public decimal Cuota { get; set; }
            public decimal Impuesto { get; set; }
            public decimal Transferencia { get; set; }
        }
        public class MutuoPagoEntidad
        {
            public int Id { get; set; }
            public int IdMutuo { get; set; }
            public int IdCronograma { get; set; }

            public DateTime FechaProgramada { get; set; }
            public DateTime? FechaPago { get; set; }

            public decimal MontoPrincipal { get; set; }
            public decimal MontoInteres { get; set; }
            public decimal MontoImpuesto { get; set; }
            public decimal MontoPagado { get; set; }

            public string CuentaContable { get; set; }
            public string CUO { get; set; }

            public int EstadoPago { get; set; }   // 0=Pendiente,1=Pagado,2=Parcial
            public int? UsuarioPago { get; set; }
            public DateTime FechaRegistro { get; set; }
            public string CuentaContableDebe { get; set; } = "";
            public string CuentaContableHaber { get; set; } = "";

        }
        public int InsertarPago(MutuoPagoEntidad o)
        {
            using (SqlConnection conn = new SqlConnection(_cadenaConexion))
            {
                string sql = @"
        INSERT INTO tbl_mutuo_pagos
        (
            idMutuo, idCronograma, FechaProgramada, FechaPago,
            MontoPrincipal, MontoInteres, MontoImpuesto, MontoPagado,
            CuentaContable, CUO, EstadoPago, UsuarioPago,CuentaContableDebe,CuentaContableHaber
        )
        VALUES
        (
            @idMutuo, @idCronograma, @FechaProgramada, @FechaPago,
            @MontoPrincipal, @MontoInteres, @MontoImpuesto, @MontoPagado,
            @CuentaContable, @CUO, @EstadoPago, @UsuarioPago,@CuentaContableDebe ,@CuentaContableHaber
        )";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idMutuo", o.IdMutuo);
                    cmd.Parameters.AddWithValue("@idCronograma", o.IdCronograma);
                    cmd.Parameters.AddWithValue("@FechaProgramada", o.FechaProgramada);
                    cmd.Parameters.AddWithValue("@FechaPago", (object)o.FechaPago ?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@MontoPrincipal", o.MontoPrincipal);
                    cmd.Parameters.AddWithValue("@MontoInteres", o.MontoInteres);
                    cmd.Parameters.AddWithValue("@MontoImpuesto", o.MontoImpuesto);
                    cmd.Parameters.AddWithValue("@MontoPagado", o.MontoPagado);

                    cmd.Parameters.AddWithValue("@CuentaContable", o.CuentaContable);
                    cmd.Parameters.AddWithValue("@CUO", (object)o.CUO ?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@EstadoPago", o.EstadoPago);
                    cmd.Parameters.AddWithValue("@UsuarioPago", (object)o.UsuarioPago ?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@CuentaContableDebe", o.CuentaContableDebe);
                    cmd.Parameters.AddWithValue("@CuentaContableHaber", o.CuentaContableHaber);


                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public int ActualizarPago(MutuoPagoEntidad o)
        {
            using (SqlConnection conn = new SqlConnection(_cadenaConexion))
            {
                string sql = @"
        UPDATE tbl_mutuo_pagos SET
            FechaProgramada=@FechaProgramada,
            MontoPrincipal=@MontoPrincipal,
            MontoInteres=@MontoInteres,
            MontoImpuesto=@MontoImpuesto,
            MontoPagado=@MontoPagado,
            CuentaContable=@CuentaContable,
            CUO=@CUO,
            EstadoPago=@EstadoPago,
            CuentaContableDebe=@CuentaContableDebe,
            CuentaContableHaber=@CuentaContableHaber

        WHERE id=@id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", o.Id);
                    cmd.Parameters.AddWithValue("@FechaProgramada", o.FechaProgramada);

                    cmd.Parameters.AddWithValue("@MontoPrincipal", o.MontoPrincipal);
                    cmd.Parameters.AddWithValue("@MontoInteres", o.MontoInteres);
                    cmd.Parameters.AddWithValue("@MontoImpuesto", o.MontoImpuesto);
                    cmd.Parameters.AddWithValue("@MontoPagado", o.MontoPagado);

                    cmd.Parameters.AddWithValue("@CuentaContable", o.CuentaContable);
                    cmd.Parameters.AddWithValue("@CUO", (object)o.CUO ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@EstadoPago", o.EstadoPago);

                    cmd.Parameters.AddWithValue("@CuentaContableDebe", o.CuentaContableDebe);
                    cmd.Parameters.AddWithValue("@CuentaContableHaber", o.CuentaContableHaber);


                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public int MarcarComoPagado(int idPago, DateTime fechaPago, string cuentaContable, string cuo, int usuarioPago)
        {
            using (SqlConnection conn = new SqlConnection(_cadenaConexion))
            {
                string sql = @"
        UPDATE tbl_mutuo_pagos SET
            FechaPago = @FechaPago,
            CuentaContable = @CuentaContable,
            CUO = @CUO,
            EstadoPago = 1,       -- Pagado
            UsuarioPago = @UsuarioPago
        WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idPago);
                    cmd.Parameters.AddWithValue("@FechaPago", fechaPago);
                    cmd.Parameters.AddWithValue("@CuentaContable", cuentaContable);
                    cmd.Parameters.AddWithValue("@CUO", cuo);
                    cmd.Parameters.AddWithValue("@UsuarioPago", usuarioPago);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public int Insertar(MutuoCronogramaEntidad o)
        {
            using (SqlConnection conn = new SqlConnection(_cadenaConexion))
            {
                string sql = @"
        INSERT INTO tbl_mutuo_cronograma
        (idMutuo, Nro, Fecha, Principal, Amortizacion, Interes, Cuota, Impuesto, Transferencia)
        VALUES
        (@idMutuo, @Nro, @Fecha, @Principal, @Amortizacion, @Interes, @Cuota, @Impuesto, @Transferencia);
        SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idMutuo", o.IdMutuo);
                    cmd.Parameters.AddWithValue("@Nro", o.Nro);
                    cmd.Parameters.AddWithValue("@Fecha", o.Fecha);
                    cmd.Parameters.AddWithValue("@Principal", o.Principal);
                    cmd.Parameters.AddWithValue("@Amortizacion", o.Amortizacion);
                    cmd.Parameters.AddWithValue("@Interes", o.Interes);
                    cmd.Parameters.AddWithValue("@Cuota", o.Cuota);
                    cmd.Parameters.AddWithValue("@Impuesto", o.Impuesto);
                    cmd.Parameters.AddWithValue("@Transferencia", o.Transferencia);

                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        public DataTable GetCronogramaxIdMutuo(int idMutuo)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_cadenaConexion))
            {
                string sql = @"
           SELECT c.id, c.idMutuo, Nro, Fecha, Principal, Amortizacion, Interes, Cuota, Impuesto, Transferencia
		,case p.EstadoPago
		when 0 then 'Pendiente'
		when 1 then 'Pagado'
		else 'Parcial'
		end Estado
        FROM tbl_mutuo_cronograma c
		left join tbl_mutuo_pagos p on c.id = p.idCronograma
        WHERE c.idMutuo = @idMutuo
		and Nro!=0
        ORDER BY Nro;
";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idMutuo", idMutuo);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);   // 👈 llena el DataTable
                    }
                }
            }

            return dt;
        }

        public class MutuoEntidad
        {
            public int Id { get; set; }
            public int IdEmpresa { get; set; }
            public int IdProyecto { get; set; }
            public int IdEtapa { get; set; }
            public int IdCtaBanco { get; set; }
            public int IdMutuante { get; set; }
            public int IdBancoMutuante { get; set; }
            public string NroCuentaMutuante { get; set; }
            public string NroCciMutuante { get; set; }
            public int Periodo { get; set; }
            public int TipoPeriodo { get; set; }
            public DateTime FechaEmision { get; set; }
            public DateTime FechaIngreso { get; set; }
            public DateTime FechaVencimiento { get; set; }
            public int TipoContrato { get; set; }
            public string Serie { get; set; }
            public int Numero { get; set; }
            public int Moneda { get; set; }
            public decimal Monto { get; set; }
            public int TipoInteres { get; set; }
            public decimal Interes { get; set; }
            public int TipoComprobante { get; set; }
            public int Impuesto { get; set; }
            public int UsuarioCreador { get; set; } = 0;
            public DateTime FechaCreador { get; set; } = DateTime.Now;
            public int UsuarioModifica { get; set; } = 0;
            public DateTime? FechaModifica { get; set; } = DateTime.Now;
            public int Estado { get; set; } = 1;
            public string CuentaContable { get; set; } = "";
            public string Cuo { get; set; } = "";
        }

        public object GetMutuosxPagar(int idEmpresa, DateTime fecha, int idctabanco)
        {
            DataTable dt = new DataTable();
            string sql = @"

      set @fechas = EOMONTH(@fechas)

       SELECT c.id idCronograma, c.idMutuo,m.idMutuante,cli.Tipo_Id_Cli tipoid,Nro_Id_Cli nrocli,dbo.NameCliente(cli.Tipo_Id_Cli,cli.Nro_Id_Cli)mutuante,
		c.Nro,m.fechaEmision fechaEmision, c.Principal, c.Interes, c.Cuota, c.Impuesto, c.Transferencia
		,case p.EstadoPago
		when 0 then 'Pendiente'
		when 1 then 'Pagado'
		else 'Parcial'
		end Estado, p.fechaProgramada Fecha, m.periodo,m.cuentaContable,m.moneda
		,p.id idPago,CuentaContableHaber,CuentaContableDebe, mo.NameCorto Nmoneda
        FROM tbl_mutuo_cronograma c
		inner join tbl_mutuos m on m.id = c.idMutuo
		inner join TBL_Cliente cli on cli.Cod_Cli = m.idMutuante
		inner join TBL_Moneda mo on mo.Id_Moneda = m.moneda
		inner join TBL_CtaBancaria ct on ct.Id_Tipo_Cta = @idcuentabancaria and ct.Moneda= mo.Id_Moneda

		left join tbl_mutuo_pagos p on c.id = p.idCronograma
        WHERE 		 Nro!=0
		and p.EstadoPago = 0   -- Pendiente
		and p.FechaProgramada <= isnull(@fechas,'30000101')
		and m.idEmpresa = @idempresa

        ORDER BY Nro,mutuante;
                
                ";

            using (SqlConnection cn = new SqlConnection(_cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                cmd.Parameters.AddWithValue("@fechas", fecha);
                cmd.Parameters.AddWithValue("@idcuentabancaria", idctabanco);
                cn.Open();
                dt.Load(cmd.ExecuteReader());
            }

            return dt;
        }

        // 🔹 INSERTAR
        public int Insertar(MutuoEntidad o)
        {
            using (SqlConnection conn = new SqlConnection(_cadenaConexion))
            {
                string sql = @"
declare @correlativo as int =0

select @correlativo= count(*)+1 from tbl_mutuos
where idEmpresa =@idempresa
and year(fechaIngreso) = year(@fechaemision)



INSERT INTO tbl_mutuos
            (idEmpresa,idProyecto, idEtapa,idCtaBanco,idMutuante,idBancoMutuante,nroCuentaMutuante,nroCciMutuante,
             periodo,tipoPeriodo,fechaEmision,fechaIngreso,fechaVencimiento,tipoContrato,serie,numero,
             moneda,monto,tipoInteres,interes,tipoComprobante,impuesto,
             usuarioCreador,fechaCreador,estado,cuentacontable,cuo)
            VALUES
            (@idEmpresa,@idProyecto,@idEtapa,@idCtaBanco,@idMutuante,@idBancoMutuante,@nroCuentaMutuante,@nroCciMutuante,
             @periodo,@tipoPeriodo,@fechaEmision,@fechaIngreso,@fechaVencimiento,@tipoContrato,@serie,@correlativo,
             @moneda,@monto,@tipoInteres,@interes,@tipoComprobante,@impuesto,
             @usuarioCreador,@fechaCreador,@estado,@cuentacontable,@cuo);
            SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idEmpresa", o.IdEmpresa);
                    cmd.Parameters.AddWithValue("@idProyecto", o.IdProyecto);
                    cmd.Parameters.AddWithValue("@idEtapa", o.IdEtapa);
                    cmd.Parameters.AddWithValue("@idCtaBanco", o.IdCtaBanco);
                    cmd.Parameters.AddWithValue("@idMutuante", o.IdMutuante);
                    cmd.Parameters.AddWithValue("@idBancoMutuante", o.IdBancoMutuante);
                    cmd.Parameters.AddWithValue("@nroCuentaMutuante", o.NroCuentaMutuante);
                    cmd.Parameters.AddWithValue("@nroCciMutuante", o.NroCciMutuante);
                    cmd.Parameters.AddWithValue("@periodo", o.Periodo);
                    cmd.Parameters.AddWithValue("@tipoPeriodo", o.TipoPeriodo);
                    cmd.Parameters.AddWithValue("@fechaEmision", o.FechaEmision);
                    cmd.Parameters.AddWithValue("@fechaIngreso", o.FechaIngreso);
                    cmd.Parameters.AddWithValue("@fechaVencimiento", o.FechaVencimiento);
                    cmd.Parameters.AddWithValue("@tipoContrato", o.TipoContrato);
                    cmd.Parameters.AddWithValue("@serie", o.Serie);
                    cmd.Parameters.AddWithValue("@numero", o.Numero);
                    cmd.Parameters.AddWithValue("@moneda", o.Moneda);
                    cmd.Parameters.AddWithValue("@monto", o.Monto);
                    cmd.Parameters.AddWithValue("@tipoInteres", o.TipoInteres);
                    cmd.Parameters.AddWithValue("@interes", o.Interes);
                    cmd.Parameters.AddWithValue("@tipoComprobante", o.TipoComprobante);
                    cmd.Parameters.AddWithValue("@impuesto", o.Impuesto);
                    cmd.Parameters.AddWithValue("@usuarioCreador", o.UsuarioCreador);
                    cmd.Parameters.AddWithValue("@fechaCreador", o.FechaCreador);
                    cmd.Parameters.AddWithValue("@estado", o.Estado);
                    cmd.Parameters.AddWithValue("@cuentacontable", o.CuentaContable);
                    cmd.Parameters.AddWithValue("@cuo", o.Cuo);

                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public object ListarMutuosxAño(DateTime fechaSeleccionada)
        {
            {
                DataTable dataTable = new DataTable();

                using (SqlConnection conn = new SqlConnection(_cadenaConexion))
                {
                    string query = @"

                        select 
                        a.id id,e.Empresa empresa,c.Nro_Id_Cli numDoc,concat(a.serie,'-',format(a.numero,'000000'))numero, dbo.NameCliente(c.Tipo_Id_Cli,c.Nro_Id_Cli) cliente
                        ,a.fechaEmision fechaEmision,m.Moneda moneda,monto total,

                        case a.estado
                        when 0 then 'Anulado'
                        when 1 then 'Nuevo'
                        when 3 then 'Generado'
                        when 5 then 'Cancelado'

                        end estado

                        from tbl_mutuos a
                        inner join TBL_Empresa e on e.Id_Empresa = a.idEmpresa
                        inner join TBL_Cliente c on c.Cod_Cli =a.idMutuante
                        inner join TBL_Moneda m on m.Id_Moneda = a.moneda

                        where year(a.fechaIngreso) = year(@fecha)
                        order by e.empresa, 1 desc

";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fecha", fechaSeleccionada);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    conn.Open();
                    adapter.Fill(dataTable);
                }

                return dataTable;
            }
        }

        // 🔹 OBTENER POR ID
        public MutuoEntidad ObtenerPorId(int id)
        {
            using (SqlConnection conn = new SqlConnection(_cadenaConexion))
            {
                string sql = @"SELECT *
                       FROM tbl_mutuos
                       WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new MutuoEntidad
                            {
                                Id = Convert.ToInt32(dr["id"]),
                                IdEmpresa = Convert.ToInt32(dr["idEmpresa"]),
                                IdProyecto = Convert.ToInt32(dr["idProyecto"]),
                                IdEtapa = Convert.ToInt32(dr["idEtapa"]),
                                IdCtaBanco = Convert.ToInt32(dr["idCtaBanco"]),
                                IdMutuante = Convert.ToInt32(dr["idMutuante"]),
                                IdBancoMutuante = Convert.ToInt32(dr["idBancoMutuante"]),
                                NroCuentaMutuante = dr["nroCuentaMutuante"].ToString(),
                                NroCciMutuante = dr["nroCciMutuante"].ToString(),
                                Periodo = Convert.ToInt32(dr["periodo"]),
                                TipoPeriodo = Convert.ToInt32(dr["tipoPeriodo"]),
                                FechaEmision = Convert.ToDateTime(dr["fechaEmision"]),
                                FechaIngreso = Convert.ToDateTime(dr["fechaIngreso"]),
                                FechaVencimiento = Convert.ToDateTime(dr["fechaVencimiento"]),
                                TipoContrato = Convert.ToInt32(dr["tipoContrato"]),
                                Serie = dr["serie"].ToString(),
                                Numero = Convert.ToInt32(dr["numero"]),
                                Moneda = Convert.ToInt32(dr["moneda"]),
                                Monto = Convert.ToDecimal(dr["monto"]),
                                TipoInteres = Convert.ToInt32(dr["tipoInteres"]),
                                Interes = Convert.ToDecimal(dr["interes"]),
                                TipoComprobante = Convert.ToInt32(dr["tipoComprobante"]),
                                Impuesto = Convert.ToInt32(dr["impuesto"]),
                                UsuarioCreador = Convert.ToInt32(dr["usuarioCreador"]),
                                FechaCreador = Convert.ToDateTime(dr["fechaCreador"]),
                                UsuarioModifica = dr["usuarioModifica"] == DBNull.Value ? 0 : Convert.ToInt32(dr["usuarioModifica"]),
                                FechaModifica = dr["fechaModifica"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["fechaModifica"]),
                                Estado = Convert.ToInt32(dr["estado"]),
                                CuentaContable = dr["cuentaContable"].ToString(),
                                Cuo = dr["cuo"].ToString()
                            };
                        }
                    }
                }
            }

            return null; // No encontrado
        }

        // 🔹 ACTUALIZAR
        public int Actualizar(MutuoEntidad o)
        {
            using (SqlConnection conn = new SqlConnection(_cadenaConexion))
            {
                string sql = @"UPDATE tbl_mutuos SET
                idEmpresa=@idEmpresa,
                idProyecto=@idProyecto,
                idEtapa=@idEtapa,
                idCtaBanco=@idCtaBanco,
                idMutuante=@idMutuante,
                idBancoMutuante=@idBancoMutuante,
                nroCuentaMutuante=@nroCuentaMutuante,
                nroCciMutuante=@nroCciMutuante,
                periodo=@periodo,
                tipoPeriodo=@tipoPeriodo,
                fechaEmision=@fechaEmision,
                fechaIngreso=@fechaIngreso,
                fechaVencimiento=@fechaVencimiento,
                tipoContrato=@tipoContrato,
                serie=@serie,
                numero=@numero,
                moneda=@moneda,
                monto=@monto,
                tipoInteres=@tipoInteres,
                interes=@interes,
                tipoComprobante=@tipoComprobante,
                impuesto=@impuesto,
                usuarioModifica=@usuarioModifica,
                fechaModifica=@fechaModifica,
                estado=@estado,
                cuentacontable=@cuentacontable,
                cuo = @cuo
            WHERE id=@id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", o.Id);
                    cmd.Parameters.AddWithValue("@idEmpresa", o.IdEmpresa);
                    cmd.Parameters.AddWithValue("@idProyecto", o.IdProyecto);
                    cmd.Parameters.AddWithValue("@idEtapa", o.IdEtapa);
                    cmd.Parameters.AddWithValue("@idCtaBanco", o.IdCtaBanco);
                    cmd.Parameters.AddWithValue("@idMutuante", o.IdMutuante);
                    cmd.Parameters.AddWithValue("@idBancoMutuante", o.IdBancoMutuante);
                    cmd.Parameters.AddWithValue("@nroCuentaMutuante", o.NroCuentaMutuante);
                    cmd.Parameters.AddWithValue("@nroCciMutuante", o.NroCciMutuante);
                    cmd.Parameters.AddWithValue("@periodo", o.Periodo);
                    cmd.Parameters.AddWithValue("@tipoPeriodo", o.TipoPeriodo);
                    cmd.Parameters.AddWithValue("@fechaEmision", o.FechaEmision);
                    cmd.Parameters.AddWithValue("@fechaIngreso", o.FechaIngreso);
                    cmd.Parameters.AddWithValue("@fechaVencimiento", o.FechaVencimiento);
                    cmd.Parameters.AddWithValue("@tipoContrato", o.TipoContrato);
                    cmd.Parameters.AddWithValue("@serie", o.Serie);
                    cmd.Parameters.AddWithValue("@numero", o.Numero);
                    cmd.Parameters.AddWithValue("@moneda", o.Moneda);
                    cmd.Parameters.AddWithValue("@monto", o.Monto);
                    cmd.Parameters.AddWithValue("@tipoInteres", o.TipoInteres);
                    cmd.Parameters.AddWithValue("@interes", o.Interes);
                    cmd.Parameters.AddWithValue("@tipoComprobante", o.TipoComprobante);
                    cmd.Parameters.AddWithValue("@impuesto", o.Impuesto);
                    cmd.Parameters.AddWithValue("@usuarioModifica", o.UsuarioModifica);
                    cmd.Parameters.AddWithValue("@fechaModifica", o.FechaModifica);
                    cmd.Parameters.AddWithValue("@estado", o.Estado);
                    cmd.Parameters.AddWithValue("@cuentacontable", o.CuentaContable);
                    cmd.Parameters.AddWithValue("@cuo", o.Cuo);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // 🔹 LISTAR
        public DataTable ListarPorEmpresa(int idEmpresa)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM tbl_mutuos WHERE idEmpresa=@idEmpresa AND estado!=0";

            using (SqlConnection cn = new SqlConnection(_cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                cn.Open();
                dt.Load(cmd.ExecuteReader());
            }

            return dt;
        }
        public DataTable ListarClientes()
        {
            DataTable dt = new DataTable();
            string sql = @"select Cod_Cli id,Nro_Id_Cli nroid,dbo.NameCliente(Tipo_Id_Cli,Nro_Id_Cli) nombre,Direccion direccion
                            from TBL_Cliente
                            order by 1 desc";

            using (SqlConnection cn = new SqlConnection(_cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                //cmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                cn.Open();
                dt.Load(cmd.ExecuteReader());
            }

            return dt;
        }
        public DataTable ListadoEntidadesFinacieras()
        {
            DataTable dt = new DataTable();
            string sql = @"select ID_Entidad id, Entidad_Financiera entidad, Sufijo sufijo, Cod_Sunat codSunat from TBL_Entidad_Financiera";

            using (SqlConnection cn = new SqlConnection(_cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                //cmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                cn.Open();
                dt.Load(cmd.ExecuteReader());
            }

            return dt;
        }
        public DataTable GetTablaPeriodos()
        {
            DataTable dt = new DataTable();
            string sql = @"select * from tbl_mutuo_periodo";

            using (SqlConnection cn = new SqlConnection(_cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                //cmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                cn.Open();
                dt.Load(cmd.ExecuteReader());
            }

            return dt;
        }
        public DataTable GetTablaImpuestos()
        {
            DataTable dt = new DataTable();
            string sql = @"select * from tbl_mutuos_impuestos";

            using (SqlConnection cn = new SqlConnection(_cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                //cmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                cn.Open();
                dt.Load(cmd.ExecuteReader());
            }

            return dt;
        }
        public DataTable GetImpuestoFiltrado(decimal id)
        {
            DataTable dt = new DataTable();
            string sql = @"select * from tbl_mutuos_impuestos where id = @id";

            using (SqlConnection cn = new SqlConnection(_cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                dt.Load(cmd.ExecuteReader());
            }

            return dt;
        }
        public DataTable GetCuentaContableMutuo46InteresMutuo(int moneda)
        {
            DataTable dt = new DataTable();
            string sql = @"
                       

DECLARE @mon as nvarchar(10)=''
set @mon = iif(@moneda=1,'MN','ME')
select Id_Cuenta_Contable id, Cuenta_Contable cuentaContable 
from TBL_Cuenta_Contable c
where c.Cuenta_Contable like '%mutuo%' + @mon + '%'
AND C.Id_Cuenta_Contable like '46%'
and c.CtaDetalle =1
AND EstadoCta =1
and c.Cuenta_Contable  like '%INTERES%'

";

            using (SqlConnection cn = new SqlConnection(_cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@moneda", moneda);
                cn.Open();
                dt.Load(cmd.ExecuteReader());
            }

            return dt;
        }
        public DataTable GetCuentaContableMutuo37InteresMutuo(int moneda)
        {
            DataTable dt = new DataTable();
            string sql = @"
                       
DECLARE @mon as nvarchar(10)=''
set @mon = iif(@moneda=1,'MN','ME')
select Id_Cuenta_Contable id, Cuenta_Contable cuentaContable from TBL_Cuenta_Contable c
where c.Cuenta_Contable like '%mutuo%' + @mon + '%'
AND C.Id_Cuenta_Contable like '37%'
and c.CtaDetalle =1
AND EstadoCta =1
and c.Cuenta_Contable  like '%INTERES%'

";

            using (SqlConnection cn = new SqlConnection(_cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@moneda", moneda);
                cn.Open();
                dt.Load(cmd.ExecuteReader());
            }

            return dt;
        }
        public DataTable GetCuentaContableMutuo(int moneda)
        {
            DataTable dt = new DataTable();
            string sql = @"
                            DECLARE @mon as nvarchar(10)=''
                            set @mon = iif(@moneda=1,'MN','ME')
                     select Id_Cuenta_Contable id, Cuenta_Contable cuentaContable from TBL_Cuenta_Contable c
where c.Cuenta_Contable like '%mutuo%' + @mon + '%'
AND C.Id_Cuenta_Contable > '46'
and c.CtaDetalle =1
AND EstadoCta =1
and c.Cuenta_Contable not like '%INTERES%'";

            using (SqlConnection cn = new SqlConnection(_cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@moneda", moneda);
                cn.Open();
                dt.Load(cmd.ExecuteReader());
            }

            return dt;
        }
        // 🔹 ELIMINAR LÓGICO
        public void Anular(int id, int usuario)
        {
            string sql = @"UPDATE tbl_mutuos 
                           SET estado=0, usuarioModifica=@usuario, fechaModifica=GETDATE()
                           WHERE id=@id";

            using (SqlConnection cn = new SqlConnection(_cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void CambiarEstadoAsiento(int id)
        {
            string sql = @"UPDATE tbl_mutuos 
                           SET estado=3
                           WHERE id=@id";

            using (SqlConnection cn = new SqlConnection(_cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void ActualizarCuoMutuo(int id, string cuo, string cuentacontable)
        {
            string sql = @"UPDATE tbl_mutuos 
                           SET cuo =@cuo,cuentaContable= @cuenta
                           WHERE id=@id";

            using (SqlConnection cn = new SqlConnection(_cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@cuo", cuo);
                cmd.Parameters.AddWithValue("@cuenta", cuentacontable);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
