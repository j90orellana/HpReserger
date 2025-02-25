using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica.Compras
{
    public class FacturaManual
    {
        private readonly string _connectionString;

        public FacturaManual()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }

        // Create
        public DataTable BuscarFiltradoCompras(DateTime fechade, DateTime fechaa, string empresa,string proveedor, string glosa, int ocultarpp,string nrocomprobante)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT
                      e.empresa AS Empresa, x.Id id,
                        cp.nombre AS Comprobante, 
                        p.razon_social AS RazonSocial, 
                        m.NameCorto AS Moneda, 
                        X.NroComprobante AS NumeroComprobante,
	                    X.Proveedor,
                        FORMAT(X.FechaEmision, 'yyyy-MM-dd') AS FechaEmision,
                        FORMAT(X.FechaContable, 'yyyy-MM-dd') AS FechaContable,
                        CASE X.estado
                            WHEN 1 THEN 'COMPLETA'
                            WHEN 2 THEN 'PAGADA'

                            WHEN 3 THEN 'COMPENSADA'
                        END AS EstadoFactura,
                        X.Tipo, 
                        X.Total, 
                        X.IGV,
                        X.TC AS TipoCambio,
                        X.Detraccion, 
                        X.Glosa, 
	                    pc.id IdPP,--,pc.Codigo CodigoPP, pc.Tipo tipopartida,
                         ISNULL(U.Login_User, 'ADMIN') AS Usuario , isnull(pp.id,0) pkidpp
                    FROM(
                        SELECT
                            'Facturas Compras' AS Tipo,
                            Id,
                            IdComprobante,
                            NroComprobante,
                            Proveedor,
                            Empresa,
                            Moneda,
                            TC,
                            Total,
                            IGV,
                            FechaEmision,
                            FechaContable,
                            Estado,
                            Detraccion,
                            Glosa,
                            Usuario, 1 tipofactura
                        FROM TBL_FacturaManual


                        UNION ALL


                        SELECT
                            'Notas Compras' AS Tipo,
                            Id,
                            IdComprobante,
                            NroComprobante,
                            Proveedor,
                            Empresa,
                            Moneda,
                            TC,
                            Total,
                            IGV,
                            FechaEmision,
                            FechaContable,
                            Estado,
                            0 AS Detraccion,
                            Glosa,
                            Usuario, 100
                        FROM TBL_NC_ND_CompraManual
                    ) X

                    INNER JOIN TBL_Empresa e ON e.Id_Empresa = X.Empresa
                    LEFT JOIN TBL_Comprobante_Pago cp ON cp.Id_Comprobante = X.IdComprobante
                    LEFT JOIN TBL_Proveedor p ON p.ruc = X.Proveedor
                    LEFT JOIN TBL_Moneda m ON m.Id_Moneda = X.Moneda
                    LEFT JOIN TBL_Usuario U ON U.Codigo_User = X.Usuario
                    left join TBL_FacturasPresupuestos pp on pp.idFactura = x.Id and pp.tipofactura = x.tipofactura
                    left join TBL_Partidas_Control pc on pc.id = pp.idPartida and pc.Tipo = pp.TipoPartida and e.Id_Empresa =pc.pkempresa

                    WHERE X.FechaEmision BETWEEN @fechade AND @fechaa
                    AND(E.Empresa LIKE '%' + @EMPRESA + '%')
                    AND(P.razon_social LIKE '%' + @PROVEEDOR + '%' OR P.RUC LIKE '%' + @PROVEEDOR + '%')
                    AND X.Glosa LIKE '%' + @GLOSA + '%'  AND X.NroComprobante LIKE '%' + @nrocompro + '%'
                    and (isnull(pc.id,0)= @ocultar or @ocultar=1)
                    ORDER BY Empresa ASC, FechaContable ASC; ";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fechade", fechade);
                cmd.Parameters.AddWithValue("@fechaa", fechaa);
                cmd.Parameters.AddWithValue("@EMPRESA", empresa);
                cmd.Parameters.AddWithValue("@PROVEEDOR", proveedor);
                cmd.Parameters.AddWithValue("@GLOSA", glosa);
                cmd.Parameters.AddWithValue("@nrocompro", nrocomprobante);
                cmd.Parameters.AddWithValue("@ocultar", ocultarpp);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable BuscarFiltradoVentas(DateTime fechade, DateTime fechaa, string empresa, string proveedor, string glosa, int ocultarpp, string nrocomprobante)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                SELECT
                      e.empresa AS Empresa, x.Id id,
                        cp.nombre AS Comprobante, 
                    trim(    CONCAT(Apepat_RazSoc_Cli, ' ', Apemat_Cli, ' ', Nombres_Cli)) AS Nombre_Completo , 
                        m.NameCorto AS Moneda, 
                        X.NroComprobante AS NumeroComprobante,
	                    X.Proveedor,
                        FORMAT(X.FechaEmision, 'yyyy-MM-dd') AS FechaEmision,
                        FORMAT(X.FechaContable, 'yyyy-MM-dd') AS FechaContable,
                        CASE X.estado
                            WHEN 1 THEN 'COMPLETA'
                            WHEN 2 THEN 'PAGADA'

                            WHEN 3 THEN 'COMPENSADA'
                        END AS EstadoFactura,
                        X.Tipo, 
                        X.Total, 
                        X.IGV,
                        X.TC AS TipoCambio,
                        X.Detraccion, 
                        X.Glosa, 
	                    pc.id IdPP,--,pc.Codigo CodigoPP, pc.Tipo tipopartida,
                         ISNULL(U.Login_User, 'ADMIN') AS Usuario , isnull(pp.id,0) pkidpp
                    FROM(
                        SELECT
                            'Facturas Ventas' AS Tipo,
                            Id,
                            IdComprobante,
                            NroComprobante,
                           Cliente Proveedor,
                            Empresa,
                            Moneda,
                            TC,
                            Total,
                            IGV,
                            FechaEmision,
                            FechaContable,
                            Estado,
                            Detraccion,
                            Glosa,
                            Usuario, 2 tipofactura
                        FROM TBL_VentaManual


                        UNION ALL


                        SELECT
                            'Notas Ventas' AS Tipo,
                            Id,
                            IdComprobante,
                            NroComprobante,
                        Cliente    Proveedor,
                            Empresa,
                            Moneda,
                            TC,
                            Total,
                            IGV,
                            FechaEmision,
                            FechaContable,
                            Estado,
                            0 AS Detraccion,
                            Glosa,
                            Usuario, 200
                        FROM TBL_NC_ND_VentaManual
                    ) X

                    INNER JOIN TBL_Empresa e ON e.Id_Empresa = X.Empresa
                    LEFT JOIN TBL_Comprobante_Pago cp ON cp.Id_Comprobante = X.IdComprobante
                    LEFT JOIN TBL_Cliente p On p.Nro_Id_Cli = X.Proveedor
                    LEFT JOIN TBL_Moneda m ON m.Id_Moneda = X.Moneda
                    LEFT JOIN TBL_Usuario U ON U.Codigo_User = X.Usuario
                    left join TBL_FacturasPresupuestos pp on pp.idFactura = x.Id and pp.tipofactura = x.tipofactura
                    left join TBL_Partidas_Control pc on pc.id = pp.idPartida and pc.Tipo = pp.TipoPartida and e.Id_Empresa =pc.pkempresa

                    WHERE X.FechaEmision BETWEEN @fechade AND @fechaa
                    AND(E.Empresa LIKE '%' + @EMPRESA + '%')
                    AND(CONCAT(Apepat_RazSoc_Cli, ' ', Apemat_Cli, ' ', Nombres_Cli)  LIKE '%' + @PROVEEDOR + '%' OR P.Nro_Id_Cli LIKE '%' + @PROVEEDOR + '%')
                    AND X.Glosa LIKE '%' + @GLOSA + '%'  AND X.NroComprobante LIKE '%' + @nrocompro + '%'
                    and (isnull(pc.id,0)= @ocultar or @ocultar=1)
                    ORDER BY Empresa ASC, FechaContable ASC; ";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fechade", fechade);
                cmd.Parameters.AddWithValue("@fechaa", fechaa);
                cmd.Parameters.AddWithValue("@EMPRESA", empresa);
                cmd.Parameters.AddWithValue("@PROVEEDOR", proveedor);
                cmd.Parameters.AddWithValue("@GLOSA", glosa);
                cmd.Parameters.AddWithValue("@nrocompro", nrocomprobante);
                cmd.Parameters.AddWithValue("@ocultar", ocultarpp);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        public DataTable BuscarFiltradoPagoCompras(DateTime fechade, DateTime fechaa, string empresa, string proveedor, string nrocta, int ocultarpp, string nrocomprobante)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                select Empresa, Ruc,Razon,TipoDocumento,NroComprobante,FechaPago,Banco,Cuenta
                ,NameCorto Moneda,
                IIF(moneda=2, total,total/tcv)
                PagoDolares , 
                IIF(moneda=1, total,total*tcv)
                PagoSoles
                ,TCV TC
                , pc.id IdPP, isnull(pp.id,0) pkidpp ,x.id,x.Id_Empresa pkempresa
                from (
                select 
                e.Empresa Empresa,
                Proveedor Ruc,
                p.razon_social Razon,
                cp.Nombre TipoDocumento,
                f.NroFactura NroComprobante
                ,f.FechaPago FechaPago
                ,eb.Entidad_Financiera Banco
                ,CtaBanco Cuenta
                ,Total 
                ,tc.Compra TCC,
                tc.Venta TCV, cb.Moneda
                ,m.NameCorto
                ,f.NroFacturaDet id, e. Id_Empresa
                 from tbl_factura_Det f
                inner join TBL_Empresa e on e.Id_Empresa  = f.fkempresa
                inner join TBL_Proveedor p on f.Proveedor = p.RUC
                Inner join TBL_Comprobante_Pago cp on cp.Id_Comprobante  = f.Id_Comprobante
                left join TBL_CtaBancaria cb on cb.Nro_Cta  = CtaBanco
                inner join TBL_Moneda m on m.Id_Moneda = cb.moneda
                left join TBL_Entidad_Financiera eb on eb.ID_Entidad = cb.Banco
                left join TBL_Tipo_Cambio tc on tc.Anio = year(FechaPago) and tc.Mes = MONTH(fechapago) and tc.Dia = DAY(FechaPago)

 

                WHERE f.Estado =1
                ) as x
                 left join TBL_FacturasPresupuestos pp on pp.idFactura = x.Id and pp.tipofactura = 5
                                    left join TBL_Partidas_Control pc on pc.id = pp.idPartida and pc.Tipo = pp.TipoPartida and x.Id_Empresa =pc.pkempresa

                  WHERE X.FechaPago BETWEEN @fechade AND @fechaa
                                    AND(x.Empresa LIKE '%' + @EMPRESA + '%')
                                    AND(Ruc  LIKE '%' + @PROVEEDOR + '%' OR Razon LIKE '%' + @PROVEEDOR + '%')
                                    AND X.Cuenta LIKE '%' + @GLOSA + '%'  AND X.NroComprobante LIKE '%' + @nrocompro + '%'
                                    and (isnull(pc.id,0)= @ocultar or @ocultar=1)
                                    ORDER BY Empresa ASC, FechaPago ASC; 
 ";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fechade", fechade);
                cmd.Parameters.AddWithValue("@fechaa", fechaa);
                cmd.Parameters.AddWithValue("@EMPRESA", empresa);
                cmd.Parameters.AddWithValue("@PROVEEDOR", proveedor);
                cmd.Parameters.AddWithValue("@GLOSA", nrocta);
                cmd.Parameters.AddWithValue("@nrocompro", nrocomprobante);
                cmd.Parameters.AddWithValue("@ocultar", ocultarpp);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}