using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmBancoInterAmericano : Form
    {
        public frmBancoInterAmericano()
        {
            InitializeComponent();
        }
        public DataTable TablaConsulta;
        DataTable tablastipoop;
        DataTable tablasmoneda;
        DataTable tablabanco;
        DataTable tablaabono;
        DataTable tablasdocumento;
        DataTable tablasformapago;
        public DataTable TablaProveedorBanco;
        public DataTable TablaComprobanteS;
        public DataTable TablaComprobantes;
        public Boolean PAgoFactura = false;
        public List<frmPagarBoletas.FACTURAS> ComprobanteS = new List<frmPagarBoletas.FACTURAS>();
        public List<frmPagarFactura.FACTURAS> Comprobantes = new List<frmPagarFactura.FACTURAS>();
        private void frmBancoInterAmericano_Load(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.Cancel;
            valoresdecarga();
            if (!PAgoFactura)
            {
                TablaComprobantes = new DataTable();
                TablaComprobantes.Columns.Add("index", typeof(int));
                TablaComprobantes.Columns.Add("tipo", typeof(string));
                TablaComprobantes.Columns.Add("numero", typeof(string));
                TablaComprobantes.Columns.Add("proveedor", typeof(string));
                TablaComprobantes.Columns.Add("detraccion", typeof(decimal));
                TablaComprobantes.Columns.Add("total", typeof(decimal));
                TablaComprobantes.Columns.Add("fechacancelado", typeof(DateTime));
                int i = 1;
                foreach (frmPagarFactura.FACTURAS fac in Comprobantes)
                {
                    TablaComprobantes.Rows.Add(new object[] { 1, fac.tipo, fac.numero, fac.proveedor, fac.detraccion, fac.aPagar, fac.fechacancelado });
                    i++;
                }
            }
            else
            {
                //tabla comprobates de boleta
                TablaComprobanteS = new DataTable();
                TablaComprobanteS.Columns.Add("index", typeof(int));
                TablaComprobanteS.Columns.Add("año", typeof(int));
                TablaComprobanteS.Columns.Add("mes", typeof(string));
                TablaComprobanteS.Columns.Add("tipo", typeof(string));
                TablaComprobanteS.Columns.Add("numero", typeof(string));
                TablaComprobanteS.Columns.Add("neto", typeof(decimal));
                TablaComprobanteS.Columns.Add("fechacancelado", typeof(DateTime));
                int i = 1;
                foreach (frmPagarBoletas.FACTURAS fac in ComprobanteS)
                {
                    TablaComprobanteS.Rows.Add(new object[] { 1, fac.año, fac.mes, fac.tipo, fac.nro, fac.neto, fac.fecha });
                    i++;
                }
            }
            ////cargar valores de los proveedores
            DataTable TablaConsulta = new DataTable();
            if (!PAgoFactura)
            {
                var cargas = from tblcomprobante in TablaComprobantes.AsEnumerable()
                             join tblproveedor in TablaProveedorBanco.AsEnumerable() on tblcomprobante["proveedor"].ToString().Trim() equals (string)tblproveedor["ruc"].ToString().Trim()
                             select new
                             {
                                 index = tblcomprobante["index"],
                                 proveedor = tblcomprobante["proveedor"],
                                 razonsocial = tblproveedor["razon_social"],
                                 ctaseleccionada = tblproveedor["ctaseleccionada"],
                                 cuentasoles = tblproveedor["nro_cta_soles"],
                                 cuentaccisoles = tblproveedor["nro_cta_cci_soles"],
                                 tipo = tblcomprobante["tipo"],
                                 nro = tblcomprobante["numero"],
                                 //total = decimal.Parse(tblcomprobante["total"].ToString()) - decimal.Parse(tblcomprobante["detraccion"].ToString()),
                                 total = decimal.Parse(tblcomprobante["total"].ToString()),

                                 fechacancelado = tblcomprobante["fechacancelado"],
                                 banco = tblproveedor["Entidad_Financiera"]
                             };
                TablaConsulta.Columns.Add("codigo", typeof(string));
                TablaConsulta.Columns.Add("tipoop", typeof(string));
                TablaConsulta.Columns.Add("nrofac", typeof(string));
                TablaConsulta.Columns.Add("fechaven", typeof(DateTime));
                TablaConsulta.Columns.Add("monedaabono", typeof(string));
                TablaConsulta.Columns.Add("neto", typeof(decimal));
                TablaConsulta.Columns.Add("banco", typeof(string));
                TablaConsulta.Columns.Add("tipoabono", typeof(string));
                TablaConsulta.Columns.Add("monedacuenta", typeof(string));
                TablaConsulta.Columns.Add("nrocuenta", typeof(string));
                TablaConsulta.Columns.Add("tipodoc", typeof(string));
                TablaConsulta.Columns.Add("nrodoc", typeof(string));
                TablaConsulta.Columns.Add("razon", typeof(string));
                TablaConsulta.Columns.Add("credito", typeof(string));
                TablaConsulta.Columns.Add("fechaade", typeof(DateTime));
                TablaConsulta.Columns.Add("tipopago", typeof(string));

                string tipo = "1", soles = "SOL", banco = "2", tipodoc = "8";
                decimal total = 0;
                foreach (var x in cargas)
                {
                    if (x.tipo.ToString().Trim().ToUpper() == "FT")
                        tipo = "1";
                    if (x.tipo.ToString().Trim().ToUpper() == "RH")
                        tipo = "3";
                    if (x.cuentaccisoles.ToString().Substring(0, x.cuentaccisoles.ToString().Length - 6) == x.ctaseleccionada.ToString())
                        banco = "4";
                    else banco = "2";
                    int xd = 0; DataRow Val = null;
                    foreach (DataRow xx in tablabanco.Rows)
                    {
                        if (xx["valor"].ToString().Substring(4).ToUpper().Trim() == x.banco.ToString().ToUpper().Trim())
                        {
                            Val = xx;
                            break;
                        }
                        xd++;
                    }
                    string entidad = "Nada";
                    if (Val != null)
                        entidad = Val["codigo"].ToString();
                    total = decimal.Parse(x.total.ToString());
                    TablaConsulta.Rows.Add("", tipo, x.nro, x.fechacancelado, soles, total, entidad, banco, soles, x.ctaseleccionada, tipodoc, x.proveedor, x.razonsocial, "", x.fechacancelado, "01");
                }
                Dtguias.DataSource = TablaConsulta;
                Dtguias_RowEnter(sender, new DataGridViewCellEventArgs(0, 0));
            }
            else
            {
                var cargas = from tblcomprobante in TablaComprobanteS.AsEnumerable()
                             join tblproveedor in TablaProveedorBanco.AsEnumerable() on tblcomprobante["tipo"].ToString().Trim() + tblcomprobante["numero"].ToString().Trim() equals (string)tblproveedor["tipo_id_emp"].ToString().Trim() + tblproveedor["nro_id_emp"].ToString().Trim()
                             select new
                             {
                                 index = tblcomprobante["index"],
                                 proveedor = tblcomprobante["numero"],
                                 razonsocial = tblproveedor["nombres"],
                                 ctaseleccionada = tblproveedor["ctaseleccionada"],
                                 cuentasoles = tblproveedor["nro_cta_soles"],
                                 cuentaccisoles = tblproveedor["nro_cta_cci_soles"],
                                 tipo = tblcomprobante["tipo"],
                                 nro = tblcomprobante["numero"],
                                 total = decimal.Parse(tblcomprobante["neto"].ToString()),
                                 fechacancelado = (DateTime)tblcomprobante["fechacancelado"],
                                 banco = tblproveedor["Entidad_Financiera"],
                                 tipocuenta = tblproveedor["tipocuenta"]
                             };
                TablaConsulta.Columns.Add("codigo", typeof(string));
                TablaConsulta.Columns.Add("tipoop", typeof(string));
                TablaConsulta.Columns.Add("nrofac", typeof(string));
                TablaConsulta.Columns.Add("fechaven", typeof(DateTime));
                TablaConsulta.Columns.Add("monedaabono", typeof(string));
                TablaConsulta.Columns.Add("neto", typeof(decimal));
                TablaConsulta.Columns.Add("banco", typeof(string));
                TablaConsulta.Columns.Add("tipoabono", typeof(string));
                TablaConsulta.Columns.Add("monedacuenta", typeof(string));
                TablaConsulta.Columns.Add("nrocuenta", typeof(string));
                TablaConsulta.Columns.Add("tipodoc", typeof(string));
                TablaConsulta.Columns.Add("nrodoc", typeof(string));
                TablaConsulta.Columns.Add("razon", typeof(string));
                TablaConsulta.Columns.Add("credito", typeof(string));
                TablaConsulta.Columns.Add("fechaade", typeof(DateTime));
                TablaConsulta.Columns.Add("tipopago", typeof(string));

                string tipo = "1", soles = "SOL", banco = "2", tipodoc = "1";
                decimal total = 0;
                foreach (var x in cargas)
                {
                    if (x.tipo.ToString().Trim().ToUpper() == "FT")
                        tipo = "1";
                    if (x.tipo.ToString().Trim().ToUpper() == "RH")
                        tipo = "3";
                    if (x.ctaseleccionada.ToString().Trim() == x.cuentaccisoles.ToString().Trim())
                        banco = "4";
                    else banco = "2";
                    int xd = 0; DataRow Val = null;
                    foreach (DataRow xx in tablabanco.Rows)
                    {
                        if (xx["valor"].ToString().Substring(4).ToUpper().Trim() == x.banco.ToString().ToUpper().Trim())
                        {
                            Val = xx;
                            break;
                        }
                        xd++;
                    }
                    string entidad = "Nada";
                    if (Val != null)
                        entidad = Val["codigo"].ToString();
                    total = decimal.Parse(x.total.ToString());
                    TablaConsulta.Rows.Add("", tipo, x.nro, x.fechacancelado, soles, total, entidad, banco, soles, x.ctaseleccionada, tipodoc, x.proveedor, x.razonsocial, "", x.fechacancelado, "01");
                }
                Dtguias.DataSource = TablaConsulta;
                Dtguias_RowEnter(sender, new DataGridViewCellEventArgs(0, 0));
            }
        }
        public DialogResult msg(string cadena)
        {
            return MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        public void valoresdecarga()
        {
            tablastipoop = new DataTable();
            tablastipoop.Columns.Add("codigo");
            tablastipoop.Columns.Add("valor");
            tablastipoop.Rows.Add(new object[] { "1", "1-Factura" });
            tablastipoop.Rows.Add(new object[] { "2", "2-Nota de Crédito" });
            tablastipoop.Rows.Add(new object[] { "3", "3-Recibo Honorarios" });
            tablastipoop.Rows.Add(new object[] { "4", "4-Orden de Pago" });
            tablastipoop.Rows.Add(new object[] { "5", "5-Nota Débito" });

            tablasmoneda = new DataTable();
            tablasmoneda.Columns.Add("codigo");
            tablasmoneda.Columns.Add("valor");
            tablasmoneda.Rows.Add(new object[] { "SOL", "Soles" });
            tablasmoneda.Rows.Add(new object[] { "USD", "Dolares" });

            tablaabono = new DataTable();
            tablaabono.Columns.Add("codigo");
            tablaabono.Columns.Add("valor");
            tablaabono.Rows.Add(new object[] { "2", "2-Abono en Cuenta BanBif" });
            tablaabono.Rows.Add(new object[] { "3", "3-Cheque de Gerencia BanBif" });
            tablaabono.Rows.Add(new object[] { "4", "4-Transferencia CCI" });

            tablasdocumento = new DataTable();
            tablasdocumento.Columns.Add("codigo");
            tablasdocumento.Columns.Add("valor");
            tablasdocumento.Rows.Add(new object[] { "1", "1-LE / DNI" });
            tablasdocumento.Rows.Add(new object[] { "3", "3-Carnet Extranjería" });
            tablasdocumento.Rows.Add(new object[] { "8", "8-RUC" });

            tablasformapago = new DataTable();
            tablasformapago.Columns.Add("codigo");
            tablasformapago.Columns.Add("valor");
            tablasformapago.Rows.Add(new object[] { "00", "00-Vencimiento" });
            tablasformapago.Rows.Add(new object[] { "01", "01-Adelanto Total" });
            tablasformapago.Rows.Add(new object[] { "04", "04-Factoring Total" });

            tablabanco = new DataTable();
            tablabanco.Columns.Add("codigo");
            tablabanco.Columns.Add("valor");
            tablabanco.Rows.Add(new object[] { "2", "002-Banco de Crédito" });
            tablabanco.Rows.Add(new object[] { "3", "003-Banco Interbank" });
            tablabanco.Rows.Add(new object[] { "7", "007-Banco Citibank" });
            tablabanco.Rows.Add(new object[] { "9", "009-Banco Scotiabank" });
            tablabanco.Rows.Add(new object[] { "11", "011-Banco Continental" });
            tablabanco.Rows.Add(new object[] { "18", "018-Banco de la Nación" });
            tablabanco.Rows.Add(new object[] { "23", "023-Banco de Comercio" });
            tablabanco.Rows.Add(new object[] { "35", "035-Banco Financiero" });
            tablabanco.Rows.Add(new object[] { "38", "038-BanBif" });
            tablabanco.Rows.Add(new object[] { "41", "041-Banco Sudamericano" });
            tablabanco.Rows.Add(new object[] { "43", "043-Banco del Trabajo" });
            tablabanco.Rows.Add(new object[] { "49", "049-Mi Banco" });
            tablabanco.Rows.Add(new object[] { "50", "050-BNP Paribas" });
            tablabanco.Rows.Add(new object[] { "53", "053-HSBC" });
            tablabanco.Rows.Add(new object[] { "54", "054-Banco Falabella" });
            tablabanco.Rows.Add(new object[] { "56", "056-Banco Santander" });
            tablabanco.Rows.Add(new object[] { "800", "800-Caja Metropolitana" });
            tablabanco.Rows.Add(new object[] { "801", "801-CMAC Piura" });
            tablabanco.Rows.Add(new object[] { "803", "803-CMAC Arequipa" });
            tablabanco.Rows.Add(new object[] { "805", "805-CMAC Sullana" });
            tablabanco.Rows.Add(new object[] { "808", "808-Caja Huancayo" });
        }
        DataGridViewComboBoxColumn combo;
        private void Dtguias_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.ColumnIndex;
            int x = e.RowIndex;
            if (Dtguias.RowCount > 0 && x >= 0)
            {
                combo = Dtguias.Columns["tipoop"] as DataGridViewComboBoxColumn;
                combo.ValueMember = "codigo";
                combo.DisplayMember = "valor";
                combo.DataSource = tablastipoop;

                combo = Dtguias.Columns["moneda"] as DataGridViewComboBoxColumn;
                combo.ValueMember = "codigo";
                combo.DisplayMember = "valor";
                combo.DataSource = tablasmoneda;

                combo = Dtguias.Columns["BANCO"] as DataGridViewComboBoxColumn;
                combo.ValueMember = "codigo";
                combo.DisplayMember = "valor";
                combo.DataSource = tablabanco;

                combo = Dtguias.Columns["TIPOABONO"] as DataGridViewComboBoxColumn;
                combo.ValueMember = "codigo";
                combo.DisplayMember = "valor";
                combo.DataSource = tablaabono;

                combo = Dtguias.Columns["FORMADEPAGOPROVEEDOR"] as DataGridViewComboBoxColumn;
                combo.ValueMember = "codigo";
                combo.DisplayMember = "valor";
                combo.DataSource = tablasformapago;

                combo = Dtguias.Columns["MONEDACUENTA"] as DataGridViewComboBoxColumn;
                combo.ValueMember = "codigo";
                combo.DisplayMember = "valor";
                combo.DataSource = tablasmoneda;

                combo = Dtguias.Columns["TIPODOC"] as DataGridViewComboBoxColumn;
                combo.ValueMember = "codigo";
                combo.DisplayMember = "valor";
                combo.DataSource = tablasdocumento;
            }
            CalcularTotales();
        }
        public void CalcularTotales()
        {
            decimal total = 0, factura = 0, credito = 0, debito = 0, recibo = 0, orden = 0;
            int con = Dtguias.RowCount;
            for (int i = 0; i < con; i++)
                if (Dtguias["neto", i].Value != null && Dtguias["tipoop", i].Value != null)
                {
                    total = decimal.Parse(Dtguias["neto", i].Value.ToString());
                    if (Dtguias["TIPOOP", i].Value.ToString().Trim() == "1")
                        factura += total;
                    if (Dtguias["TIPOOP", i].Value.ToString().Trim() == "2")
                        credito += total;
                    if (Dtguias["TIPOOP", i].Value.ToString().Trim() == "3")
                        recibo += total;
                    if (Dtguias["TIPOOP", i].Value.ToString().Trim() == "4")
                        orden += total;
                    if (Dtguias["TIPOOP", i].Value.ToString().Trim() == "5")
                        debito += total;
                }
            txtfacturas.Text = factura.ToString("n2");
            txtnotacredito.Text = credito.ToString("n2");
            txtrecibo.Text = recibo.ToString("n2");
            txtordenpago.Text = orden.ToString("n2");
            txtnotadebito.Text = debito.ToString("n2");

            txttotalpagos.Text = (factura + credito + recibo + orden + debito).ToString("n2");
        }
        string cadenatxt = "";
        private StreamWriter st;
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            PAgoFactura = false;
            int con = Dtguias.RowCount;
            if (con > 0)
            {
                cadenatxt = "";
                string[] campo = new string[16];
                for (int i = 0; i < con; i++)
                {
                    campo[0] = Dtguias["TIPODOC", i].Value.ToString();
                    campo[1] = HPResergerFunciones.Utilitarios.AddCaracter(Dtguias["NRODOCUMENTO", i].Value.ToString().Trim(), ' ', 15, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                    campo[2] = HPResergerFunciones.Utilitarios.AddCaracter(Dtguias["NOMBRECLIENTE", i].Value.ToString().Trim(), ' ', 60, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                    campo[3] = Dtguias["TIPOOP", i].Value.ToString();
                    campo[4] = HPResergerFunciones.Utilitarios.AddCaracter(Dtguias["NRODOC", i].Value.ToString().Trim(), ' ', 14, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                    campo[5] = Dtguias["MONEDA", i].Value.ToString();
                    campo[6] = HPResergerFunciones.Utilitarios.AddCaracterMultiplicarx100(Dtguias["NETO", i].Value.ToString(), ' ', 10, HPResergerFunciones.Utilitarios.Direccion.derecha);
                    DateTime FechaAux = (DateTime)Dtguias["FECVENDOC", i].Value;
                    campo[7] = FechaAux.Year + FechaAux.Month.ToString("00") + FechaAux.Day.ToString("00");
                    campo[8] = HPResergerFunciones.Utilitarios.AddCaracter(Dtguias["CODIGOPROPIO", i].Value.ToString().Trim(), ' ', 15, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                    campo[9] = Dtguias["TIPOABONO", i].Value.ToString();
                    int aux = int.Parse(Dtguias["BANCO", i].Value.ToString());
                    campo[10] = aux.ToString("000");
                    campo[11] = Dtguias["MONEDACUENTA", i].Value.ToString();
                    campo[12] = HPResergerFunciones.Utilitarios.AddCaracter(Dtguias["NUMEROCTA", i].Value.ToString(), ' ', 20, HPResergerFunciones.Utilitarios.Direccion.derecha);
                    campo[13] = HPResergerFunciones.Utilitarios.AddCaracter(Dtguias["NumNotaDebito", i].Value.ToString(), ' ', 14, HPResergerFunciones.Utilitarios.Direccion.derecha);
                    FechaAux = (DateTime)Dtguias["FECHAADELANTO", i].Value;
                    campo[14] = FechaAux.Year + FechaAux.Month.ToString("00") + FechaAux.Day.ToString("00");
                    campo[15] = Dtguias["FORMADEPAGOPROVEEDOR", i].Value.ToString();

                    //campo[18] = HPResergerFunciones.Utilitarios.AddCaracter("", ' ', 8, HPResergerFunciones.Utilitarios.Direccion.izquierda); --nose si vale
                    cadenatxt += string.Join("", campo) + $"{Environment.NewLine}";
                }
                //msg(cadenatxt);
                SaveFile.FileName = "BanBif " + DateTime.Now.ToLongDateString();
                if (SaveFile.FileName != string.Empty && SaveFile.ShowDialog() == DialogResult.OK)
                {
                    string path = SaveFile.FileName;
                    st = File.CreateText(path);
                    st.Write(cadenatxt);
                    st.Close();
                    msg("Generado TXT con Éxito");
                    PAgoFactura = true;
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else msg("Cancelado por el Usuario");
            }
            else
                msg("No hay Filas en la Grilla");
        }

        private void Dtguias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Dtguias_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
