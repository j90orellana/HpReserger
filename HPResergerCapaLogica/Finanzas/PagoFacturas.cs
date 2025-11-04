using System;
using System.Data;
using System.Data.SqlClient;

namespace HPResergerCapaLogica.Finanzas
{
    public class PagoFacturas
    {
        public int Id { get; set; }
        private readonly string _connectionString;

        public PagoFacturas()
        {
            _connectionString = HPResergerCapaDatos.HPResergerCD.StringObtenerConexion();
        }
        public DataTable ListarFacturasConMonedaNoCoincidente(string moneda, int idcta)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    WITH MonedasSeparadas AS (
                    SELECT TRY_CAST(value AS INT) AS DATO
                    FROM STRING_SPLIT(@MONEDAS, ',')
                    WHERE TRY_CAST(value AS INT) IS NOT NULL
                )
                SELECT*
                FROM MonedasSeparadas M
                LEFT JOIN TBL_CtaBancaria C ON M.DATO != C.Moneda
                WHERE Id_Tipo_Cta = @IDCTA
                  ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MONEDAS", moneda);
                cmd.Parameters.AddWithValue("@IDCTA", idcta);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        public DataTable ListarCuentasBancarias(int idOrigen, int idDestino)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                
SELECT 
    5 TipoId,
    e.ruc ruc,
    e.Empresa razon_social,
    '' nombre_comercial,
    1 tipo_persona,
    'NATURAL' persona_tipo,
   replace(   IIF(cb.Banco = cbb.Banco, cbb.nro_cta, cbb.nro_cta_cci),'-','') ctaSeleccionada,
    TPP.Descripcion TIPOCUENTA,
    
    -- nro_cta_soles con validación
    CONCAT(
        CASE 
            WHEN cbb.nro_cta IS NULL OR LTRIM(RTRIM(cbb.nro_cta)) = '' 
                 THEN '[SIN CUENTA]' 
            ELSE cbb.nro_cta 
        END,
        ' - ', m.NameCorto
    ) nro_cta_soles,

    -- nro_cta_cci_soles con validación
    CONCAT(
        CASE 
            WHEN cbb.nro_cta_cci IS NULL OR LTRIM(RTRIM(cbb.nro_cta_cci)) = '' 
                 THEN '[SIN CUENTA]' 
            ELSE cbb.nro_cta_cci 
        END,
        ' - ', m.NameCorto
    ) nro_cta_cci_soles,

    cbb.Banco banco_cta_soles,
    efp.Entidad_Financiera Entidad_Financiera,
    '' Email,
    m.Id_Moneda Moneda

FROM TBL_CtaBancaria cb
LEFT JOIN TBL_CtaBancaria cbb 
    ON cbb.Id_Tipo_Cta = @idCtaDestino
	INNER JOIN TBL_Empresa e 
    ON cbb.Empresa = e.Id_Empresa
INNER JOIN TBL_Moneda m 
    ON m.Id_Moneda = cbb.Moneda
LEFT JOIN TBL_Tipo_CtaBancaria TPP 
    ON TPP.Id_Tipo_Cta = cbb.Tipo_Cta
LEFT JOIN TBL_Entidad_Financiera efp 
    ON efp.ID_Entidad = cbb.Banco
WHERE cb.Id_Tipo_Cta = @idCtaOrigen

                  ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idCtaOrigen", idOrigen);
                cmd.Parameters.AddWithValue("@idCtaDestino", idDestino);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        public DataTable ListarFacturasPendientesdePago()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                     select 
  empresa,		tipo,	nrofactura,	ruc,	razonsocial
 ,moneda,		total,	detraccion,iif(idmoneda=1,saldo,0)	saldopen,iif(idmoneda=2,saldo,0) saldousd	,	fechaemision,	fecharecepcion,	fechacancelado,	fechacontable,	centrocosto,		glosa
 
 from (
 
 SELECT e.empresa empresa, idcomprobante idcomprobante,dbo.NameComprobante(fm.IdComprobante) + 'm' tipo,fm.NroComprobante nrofactura,fm.Proveedor ruc,pm.razon_social razonsocial,fm.
        Moneda idmoneda,mm.NameCorto moneda,IIF(IdComprobante != 3,
        --IIF(n.total IS NULL,fm.Total,n.total) 
        fm.Total - --IIF(n.igv IS NULL,fm.igv,n.igv),IIF(n.total IS NULL,fm.Total,n.total) + IIF(n.igv IS NULL,fm.igv,n.igv)) subtotal,
        fm.igv,fm.Total - fm.igv) subtotal,
        --IIF(n.igv IS NULL,fm.igv,n.igv) igv,IIF(n.total IS NULL,fm.Total,n.total) total,
        fm.igv igv,fm.Total total,Detraccion detraccion,Detraccion + --IIF(n.total IS NULL,
                                             ISNULL(
                                                    (
                                                     (
               SELECT TOP 1 IIF(fm.moneda = 1,fd.importemn,fd.importeme)
               FROM TBL_FacturaManual_Detalle fd
               WHERE fd.NroComprobante = fm.NroComprobante
                     AND fd.Proveedor = fm.Proveedor
                     AND fd.Usuario < 998
                     AND fd.DebeHaber = 'H'
                     AND (CuentaContable LIKE '42%'
                          OR CuentaContable LIKE '43%')
                     AND CuentaContable NOT LIKE '422%'
                     AND fd.idcomprobante = fm.IdComprobante
               ORDER BY fd.ImporteME DESC
                                                     --),n.total)-isnull(
                                                     )
                                                    ),fm.Total) - ISNULL(
                                                                         (
               SELECT SUM(d.total)
               FROM TBL_Factura_Det AS d
               WHERE fm.NroComprobante = d.NroFactura
                     AND fm.Proveedor = d.Proveedor
                     AND fm.IdComprobante = d.Id_Comprobante
                     AND Estado = 1
                                                                         ),0) - Detraccion saldo
        ----
        ,
        --IIF(n.total IS NULL,Detraccion+
        ISNULL((Detraccion +
                             (
               SELECT TOP 1 IIF(fm.moneda = 1,fd.importemn,fd.importeme)
               FROM TBL_FacturaManual_Detalle fd
               WHERE fd.NroComprobante = fm.NroComprobante
                     AND fd.Proveedor = fm.Proveedor
                     AND fd.Usuario < 998
                     AND fd.DebeHaber = 'H'
                     AND (CuentaContable LIKE '42%'
                          OR CuentaContable LIKE '43%')
                     AND CuentaContable NOT LIKE '422%'
                     AND fd.idcomprobante = fm.IdComprobante
               ORDER BY fd.ImporteME DESC
                             --),n.total)-isnull(
                             )),fm.Total) - ISNULL(
                                                   (
               SELECT SUM(d.total)
               FROM TBL_Factura_Det AS d
               WHERE fm.NroComprobante = d.NroFactura
                     AND fm.Proveedor = d.Proveedor
                     AND fm.IdComprobante = d.Id_Comprobante
                     AND Estado = 1
                                                   ),0) - Detraccion pago
        --
        ,fm.FechaEmision fechaemision,fm.FechaRecepcion fecharecepcion,fm.FechaVencimiento fechacancelado,FechaContable fechacontable,0 centrocosto,--
        (
               SELECT IIF(COUNT(*) > 0,'Abonos','')
               FROM TBL_Factura_Det AS fd
               WHERE fd.NroFactura = fm.NroComprobante
                     AND fd.Proveedor = fm.Proveedor
                     AND fm.IdComprobante = fd.Id_Comprobante
                     AND Estado = 1
        ) AS ver,'' fkasiento,
                              (
               SELECT TOP 1 CuentaContable
               FROM TBL_FacturaManual_Detalle fd
               WHERE fd.NroComprobante = fm.NroComprobante
                     AND fd.Proveedor = fm.Proveedor
                     AND fd.Usuario < 998
                     AND fd.DebeHaber = 'H'
                     AND (CuentaContable LIKE '42%'
                          OR CuentaContable LIKE '43%')
                     AND CuentaContable NOT LIKE '422%'
                     AND fd.idcomprobante = fm.IdComprobante
               ORDER BY fd.ImporteME DESC
                              )cuentacontable,fm.TC tc,fm.Glosa glosa
        FROM TBL_FacturaManual fm
             LEFT JOIN TBL_Proveedor pm ON pm.RUC = fm.Proveedor
             LEFT JOIN TBL_Moneda mm ON mm.Id_Moneda = fm.Moneda
			 left join tbl_empresa e on e.id_empresa = fm.empresa
        --LEFT JOIN TBL_NotaCredito AS n ON n.nroFac = fm.NroComprobante
        --                                  AND n.proveedor = fm.Proveedor
        --                                  AND n.fecha =
        --(
        --SELECT MAX(fecha)
        --FROM TBL_NotaCredito AS x
        --WHERE x.nroFac = fm.NroComprobante
        --      AND x.proveedor = fm.Proveedor
        --)
        WHERE Compensacion = 0 AND Estado = 1            
            
              AND (Detraccion +
                                (
              SELECT TOP 1 IIF(fm.moneda = 1,fd.importemn,fd.importeme)
              FROM TBL_FacturaManual_Detalle fd
              WHERE fd.NroComprobante = fm.NroComprobante
                    AND fd.Proveedor = fm.Proveedor
                    AND fd.Usuario < 998
                    AND fd.DebeHaber = 'H'
                    AND (CuentaContable LIKE '42%'
                         OR CuentaContable LIKE '43%')
                    AND fd.idcomprobante = fm.IdComprobante
              ORDER BY fd.ImporteME DESC
                                --),n.total)-isnull(
                                )) - ISNULL(
                                            (
              SELECT SUM(d.total)
              FROM TBL_Factura_Det AS d
              WHERE fm.NroComprobante = d.NroFactura
                    AND fm.Proveedor = d.Proveedor
                    AND fm.IdComprobante = d.Id_Comprobante
                    AND Estado = 1
                                            ),0) - Detraccion > 0
        ----NOTAS DE CREDITO
        UNION
        SELECT e.empresa, fm.IdComprobante,dbo.NameComprobante(fm.IdComprobante),fm.NroComprobante,fm.Proveedor,razon_social,Id_Moneda,NameCorto,fm.Total - fm.
        igv,fm.Igv,fm.Total,0,--
        fm.total - ISNULL((fd.Total),0),--
        fm.Total - ISNULL((fd.Total),0),--
        FechaEmision,FechaRecepcion,FechaVencimiento,FechaContable,0,--
        (
               SELECT IIF(COUNT(*) > 0,'Abonos','')
               FROM TBL_NC_ND_Compra_Det AS fd
               WHERE fd.NroComprobante = fM.NroComprobante
                     AND fd.Proveedor = fM.Proveedor
                     AND fd.Id_Comprobante = fm.IdComprobante
                     AND fd.Estado = 1
        ) AS ver,'',
                    (
               SELECT TOP 1 CuentaContable
               FROM TBL_FacturaManual_Detalle fd
               WHERE fd.NroComprobante = fm.NroComprobante
                     AND fd.Proveedor = fm.Proveedor
                     AND fd.Usuario < 998
                     --AND fd.DebeHaber = 'H'
                     AND (CuentaContable LIKE '42%'
                          OR CuentaContable LIKE '43%')
                     AND fd.idcomprobante = fm.IdComprobante
               ORDER BY fd.ImporteME DESC
                    ),TC,Glosa
        FROM TBL_NC_ND_CompraManual fm
             LEFT JOIN TBL_Proveedor pm ON pm.RUC = fm.Proveedor
             LEFT JOIN TBL_Moneda mm ON mm.Id_Moneda = fm.Moneda
			 left join tbl_empresa e on e.id_empresa = fm.empresa

             LEFT JOIN
                      (
             SELECT SUM(Total) total,Id_Comprobante,NroComprobante,Proveedor,estado,fkempresa
             FROM TBL_NC_ND_Compra_Det
             GROUP BY Id_Comprobante,NroComprobante,Proveedor,Estado,fkempresa
                      ) fd ON fm.IdComprobante = fd.Id_Comprobante
                              AND fm.NroComprobante = fd.NroComprobante
                              AND fm.Proveedor = fd.Proveedor
                              AND fd.Estado = 1
                              AND fm.Empresa = fd.fkempresa
        WHERE 
               fm.Estado = 1
              

        ----Facturas Carga Externa
        UNION
        SELECT e.empresa, IdComprobante,dbo.NameComprobante(IdComprobante) + 'e' tipo,fm.NroComprobante nrofactura,fm.Proveedor,pm.razon_social razon,fm.Moneda
        idmoneda,mm.NameCorto MON,IIF(IdComprobante != 3,fm.Total - fm.igv,fm.Total + fm.igv) subtotal,fm.Igv igv,fm.Total total,Detraccion,
        Detraccion + total - ISNULL(
                                    (
               SELECT SUM(d.total)
               FROM TBL_Factura_Det AS d
               WHERE fm.NroComprobante = d.NroFactura
                     AND fm.Proveedor = d.Proveedor
                     AND fm.IdComprobante = d.Id_Comprobante
                     AND Estado = 1
                                    ),0) saldo,total - ISNULL(
                                                              (
               SELECT SUM(d.total)
               FROM TBL_Factura_Det AS d
               WHERE fm.NroComprobante = d.NroFactura
                     AND fm.Proveedor = d.Proveedor
                     AND fm.IdComprobante = d.Id_Comprobante
                     AND Estado = 1
                                                              ),0) saldo,fm.FechaEmision,fm.FechaRecepcion,fm.FechaVencimiento fechacancelado,
                                                              FechaContable,0 centrocosto,--
        (
               SELECT IIF(COUNT(*) > 0,'Abonos','')
               FROM TBL_Factura_Det AS fd
               WHERE fd.NroFactura = fm.NroComprobante
                     AND fd.Proveedor = fm.Proveedor
                     AND Estado = 1
        ) AS ver,'' fkasiento,fm.cuentacontable,fm.TC,Glosa
        FROM TBL_FacturaManualTmp fm
             LEFT JOIN TBL_Proveedor pm ON pm.RUC = fm.Proveedor
             LEFT JOIN TBL_Moneda mm ON mm.Id_Moneda = fm.Moneda
			 left join tbl_empresa e on e.id_empresa = fm.empresa

        WHERE 
                Estado = 1
             
              AND fm.total - ISNULL(
                                    (
              SELECT SUM(d.total)
              FROM TBL_Factura_Det AS d
              WHERE fm.NroComprobante = d.NroFactura
                    AND fm.Proveedor = d.Proveedor
                    AND fm.IdComprobante = d.Id_Comprobante
                    AND Estado = 1
                                    ),0) > 0 ) as x
        ORDER BY empresa asc, x.fechacancelado asc
    
                  ";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}
