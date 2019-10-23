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
    public partial class frmBancoInterbank : Form
    {
        public frmBancoInterbank()
        {
            InitializeComponent();
        }
        DataTable tablastipoop;
        DataTable tablasmoneda;
        DataTable tablabanco;
        DataTable tablaabono;
        DataTable tablacuenta;
        DataTable tablapersona;
        DataTable tablasdocumento;
        public DataTable TablaProveedorBanco;
        public DataTable TablaComprobantes;
        public DataTable TablaComprobanteS;
        public DataTable TablaBancos;
        public Boolean PAgoFactura = false;
        public List<frmPagarBoletas.FACTURAS> ComprobanteS = new List<frmPagarBoletas.FACTURAS>();
        public List<frmPagarFactura.FACTURAS> Comprobantes = new List<frmPagarFactura.FACTURAS>();
        public void valoresdecarga()
        {
            tablastipoop = new DataTable();
            tablastipoop.Columns.Add("codigo");
            tablastipoop.Columns.Add("valor");
            tablastipoop.Rows.Add(new object[] { "C", "C:Nota de Crédito" });
            tablastipoop.Rows.Add(new object[] { "D", "D:Nota de Débito" });
            tablastipoop.Rows.Add(new object[] { "F", "F:Factura" });

            tablasmoneda = new DataTable();
            tablasmoneda.Columns.Add("codigo");
            tablasmoneda.Columns.Add("valor");
            tablasmoneda.Rows.Add(new object[] { "01", "01:Soles" });
            tablasmoneda.Rows.Add(new object[] { "10", "10:Dolares" });

            tablabanco = new DataTable();
            tablabanco.Columns.Add("codigo");
            tablabanco.Columns.Add("valor");
            tablabanco.Rows.Add(new object[] { "xx", "NO CCI" });
            tablabanco.Rows.Add(new object[] { "x", "SI CCI" });

            tablaabono = new DataTable();
            tablaabono.Columns.Add("codigo");
            tablaabono.Columns.Add("valor");
            tablaabono.Rows.Add(new object[] { "09", "09:Abono en cuenta" });
            tablaabono.Rows.Add(new object[] { "11", "11:Cheque de Gerencia" });
            tablaabono.Rows.Add(new object[] { "99", "99:Intercambio" });

            tablacuenta = new DataTable();
            tablacuenta.Columns.Add("codigo");
            tablacuenta.Columns.Add("valor");
            tablacuenta.Rows.Add(new object[] { "001", "001: Cta.Corriente" });
            tablacuenta.Rows.Add(new object[] { "002", "002: Cta.Ahorros" });

            tablapersona = new DataTable();
            tablapersona.Columns.Add("codigo");
            tablapersona.Columns.Add("valor");
            tablapersona.Rows.Add(new object[] { "P", "P:Persona natural" });
            tablapersona.Rows.Add(new object[] { "C", "C:Persona jurídica" });

            tablasdocumento = new DataTable();
            tablasdocumento.Columns.Add("codigo");
            tablasdocumento.Columns.Add("valor");
            tablasdocumento.Rows.Add(new object[] { "01", "01:DNI o LE" });
            tablasdocumento.Rows.Add(new object[] { "02", "02:RUC" });
            tablasdocumento.Rows.Add(new object[] { "03", "03:Carne Extranjería" });
            tablasdocumento.Rows.Add(new object[] { "04", "04:Cédula Identidad" });
            tablasdocumento.Rows.Add(new object[] { "05", "05:Pasaporte" });
        }
        public DataTable TablaConsulta;
        private void frmBancoInterbank_Load(object sender, EventArgs e)
        {
            valoresdecarga();
            ///cargar los valores de comprobantes
            ///
            if (!PAgoFactura)
            {
                TablaComprobantes = new DataTable();
                TablaComprobantes.Columns.Add("index", typeof(int));
                TablaComprobantes.Columns.Add("tipo", typeof(string));
                TablaComprobantes.Columns.Add("numero", typeof(string));
                TablaComprobantes.Columns.Add("proveedor", typeof(string));
                TablaComprobantes.Columns.Add("subtotal", typeof(decimal));
                TablaComprobantes.Columns.Add("igv", typeof(decimal));
                TablaComprobantes.Columns.Add("total", typeof(decimal));
                TablaComprobantes.Columns.Add("detraccion", typeof(decimal));
                TablaComprobantes.Columns.Add("fechacancelado", typeof(DateTime));
                int i = 1;
                foreach (frmPagarFactura.FACTURAS fac in Comprobantes)
                {
                    TablaComprobantes.Rows.Add(new object[] { i, fac.tipo, fac.numero, fac.proveedor, fac.subtotal, fac.igv, fac.aPagar, fac.detraccion, fac.fechacancelado });
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
            if (!PAgoFactura)
            {
                ////cargar valores de los proveedores
                TablaConsulta = new DataTable();
                var cargas = from tblcomprobante in TablaComprobantes.AsEnumerable()
                             join tblproveedor in TablaProveedorBanco.AsEnumerable() on tblcomprobante["proveedor"].ToString().Trim() equals (string)tblproveedor["ruc"].ToString().Trim()
                             select new
                             {
                                 index = tblcomprobante["index"],
                                 proveedor = tblcomprobante["proveedor"],
                                 razonsocial = tblproveedor["razon_social"],
                                 personatipo = tblproveedor["PERSONA_TIPO"],
                                 ctaseleccionada = tblproveedor["ctaseleccionada"],
                                 cuentasoles = tblproveedor["nro_cta_soles"],
                                 cuentaccisoles = tblproveedor["nro_cta_cci_soles"],
                                 tipo = tblcomprobante["tipo"],
                                 nro = tblcomprobante["numero"],
                                 subtotal = tblcomprobante["subtotal"],
                                 igv = tblcomprobante["igv"],
                                 total = tblcomprobante["total"],
                                 detraccion = tblcomprobante["detraccion"],
                                 fechacancelado = tblcomprobante["fechacancelado"],
                                 tipocuenta = tblproveedor["tipocuenta"]
                             };
                TablaConsulta.Columns.Add("codigo", typeof(int));
                TablaConsulta.Columns.Add("tipoop", typeof(string));
                TablaConsulta.Columns.Add("nrofac", typeof(string));
                TablaConsulta.Columns.Add("fecha", typeof(DateTime));
                TablaConsulta.Columns.Add("monedaabono", typeof(string));
                TablaConsulta.Columns.Add("importe", typeof(decimal));
                TablaConsulta.Columns.Add("neto", typeof(decimal));
                TablaConsulta.Columns.Add("banco", typeof(string));
                TablaConsulta.Columns.Add("tipoabono", typeof(string));
                TablaConsulta.Columns.Add("tipocuenta", typeof(string));
                TablaConsulta.Columns.Add("monedacuenta", typeof(string));
                TablaConsulta.Columns.Add("tienda", typeof(string));
                TablaConsulta.Columns.Add("nrocuenta", typeof(string));
                TablaConsulta.Columns.Add("tipopersona", typeof(string));
                TablaConsulta.Columns.Add("tipodoc", typeof(string));
                TablaConsulta.Columns.Add("nrodoc", typeof(string));
                TablaConsulta.Columns.Add("razon", typeof(string));

                string tipo = "", soles = "01", banco = "xx", abono = "09", tipocuenta = "", tipopersona = "", tipodoc = "02";
                decimal total = 0;
                foreach (var x in cargas)
                {
                    if (x.tipo.ToString().Trim().ToUpper() == "RH" || x.tipo.ToString().Trim().ToUpper() == "FT")
                        tipo = "F";
                    if (x.cuentaccisoles.ToString().Substring(0, x.cuentaccisoles.ToString().Length - 6) == x.ctaseleccionada.ToString())
                        banco = "xx";
                    else banco = "x";
                    if (x.tipocuenta.ToString().Trim().ToUpper() == "CORRIENTE")
                        tipocuenta = "001";
                    else tipocuenta = "002";
                    if (x.personatipo.ToString().Trim().ToUpper() == "NATURAL")
                        tipopersona = "P";
                    else tipopersona = "C";
                    total = decimal.Parse(x.total.ToString()) - decimal.Parse(x.detraccion.ToString());
                    TablaConsulta.Rows.Add(x.index, tipo, x.nro, x.fechacancelado, soles, total, total, banco, abono, tipocuenta, soles, "", x.ctaseleccionada, tipopersona, tipodoc, x.proveedor, x.razonsocial);
                }
                Dtguias.DataSource = TablaConsulta;
                Dtguias_RowEnter(sender, new DataGridViewCellEventArgs(0, 0));
            }
            else
            {
                ////cargar valores de los planillas
                TablaConsulta = new DataTable();
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
                TablaConsulta.Columns.Add("codigo", typeof(int));
                TablaConsulta.Columns.Add("tipoop", typeof(string));
                TablaConsulta.Columns.Add("nrofac", typeof(string));
                TablaConsulta.Columns.Add("fecha", typeof(DateTime));
                TablaConsulta.Columns.Add("monedaabono", typeof(string));
                TablaConsulta.Columns.Add("importe", typeof(decimal));
                TablaConsulta.Columns.Add("neto", typeof(decimal));
                TablaConsulta.Columns.Add("banco", typeof(string));
                TablaConsulta.Columns.Add("tipoabono", typeof(string));
                TablaConsulta.Columns.Add("tipocuenta", typeof(string));
                TablaConsulta.Columns.Add("monedacuenta", typeof(string));
                TablaConsulta.Columns.Add("tienda", typeof(string));
                TablaConsulta.Columns.Add("nrocuenta", typeof(string));
                TablaConsulta.Columns.Add("tipopersona", typeof(string));
                TablaConsulta.Columns.Add("tipodoc", typeof(string));
                TablaConsulta.Columns.Add("nrodoc", typeof(string));
                TablaConsulta.Columns.Add("razon", typeof(string));

                string tipo = "", soles = "01", banco = "xx", abono = "09", tipocuenta = "", tipopersona = "", tipodoc = "01";
                decimal total = 0;
                foreach (var x in cargas)
                {
                    if (x.tipo.ToString().Trim().ToUpper() == "RH" || x.tipo.ToString().Trim().ToUpper() == "FT")
                        tipo = "F";
                    if (x.ctaseleccionada.ToString().Trim() == x.cuentaccisoles.ToString().Trim())
                        banco = "xx";
                    else banco = "x";
                    if (x.tipocuenta.ToString().Trim().ToUpper() == "CORRIENTE")
                        tipocuenta = "001";
                    else tipocuenta = "002";
                    //if (x.personatipo.ToString().Trim().ToUpper() == "NATURAL")
                        tipopersona = "P";
                    // else tipopersona = "C";
                    total = x.total;
                    TablaConsulta.Rows.Add(x.index, tipo, x.nro, x.fechacancelado, soles, total, total, banco, abono, tipocuenta, soles, "", x.ctaseleccionada, tipopersona, tipodoc, x.proveedor, x.razonsocial);
                }
                Dtguias.DataSource = TablaConsulta;
                Dtguias_RowEnter(sender, new DataGridViewCellEventArgs(0, 0));
            }
        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
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

                combo = Dtguias.Columns["TIPOCUENTA"] as DataGridViewComboBoxColumn;
                combo.ValueMember = "codigo";
                combo.DisplayMember = "valor";
                combo.DataSource = tablacuenta;

                combo = Dtguias.Columns["MONEDACUENTA"] as DataGridViewComboBoxColumn;
                combo.ValueMember = "codigo";
                combo.DisplayMember = "valor";
                combo.DataSource = tablasmoneda;

                combo = Dtguias.Columns["TIPOPERSONA"] as DataGridViewComboBoxColumn;
                combo.ValueMember = "codigo";
                combo.DisplayMember = "valor";
                combo.DataSource = tablapersona;

                combo = Dtguias.Columns["TIPODOC"] as DataGridViewComboBoxColumn;
                combo.ValueMember = "codigo";
                combo.DisplayMember = "valor";
                combo.DataSource = tablasdocumento;

                //if (Dtguias.Columns["tipoop"].Index == y)
                //{
                //    combo = Dtguias.Columns["tipoop"] as DataGridViewComboBoxColumn;
                //    combo.ValueMember = "codigo";
                //    combo.DisplayMember = "valor";
                //    combo.DataSource = tablastipoop;
                //}
                //if (Dtguias.Columns["moneda"].Index == y)
                //{
                //    combo = Dtguias.Columns["moneda"] as DataGridViewComboBoxColumn;
                //    combo.ValueMember = "codigo";
                //    combo.DisplayMember = "valor";
                //    combo.DataSource = tablasmoneda;
                //}
                //if (Dtguias.Columns["BANCO"].Index == y)
                //{
                //    combo = Dtguias.Columns["BANCO"] as DataGridViewComboBoxColumn;
                //    combo.ValueMember = "codigo";
                //    combo.DisplayMember = "valor";
                //    combo.DataSource = tablabanco;
                //}
                //if (Dtguias.Columns["TIPOABONO"].Index == y)
                //{
                //    combo = Dtguias.Columns["TIPOABONO"] as DataGridViewComboBoxColumn;
                //    combo.ValueMember = "codigo";
                //    combo.DisplayMember = "valor";
                //    combo.DataSource = tablaabono;
                //}
                //if (Dtguias.Columns["TIPOCUENTA"].Index == y)
                //{
                //    combo = Dtguias.Columns["TIPOCUENTA"] as DataGridViewComboBoxColumn;
                //    combo.ValueMember = "codigo";
                //    combo.DisplayMember = "valor";
                //    combo.DataSource = tablacuenta;
                //}
                //if (Dtguias.Columns["MONEDACUENTA"].Index == y)
                //{
                //    combo = Dtguias.Columns["MONEDACUENTA"] as DataGridViewComboBoxColumn;
                //    combo.ValueMember = "codigo";
                //    combo.DisplayMember = "valor";
                //    combo.DataSource = tablasmoneda;
                //}
                //if (Dtguias.Columns["TIPOPERSONA"].Index == y)
                //{
                //    combo = Dtguias.Columns["TIPOPERSONA"] as DataGridViewComboBoxColumn;
                //    combo.ValueMember = "codigo";
                //    combo.DisplayMember = "valor";
                //    combo.DataSource = tablapersona;
                //}
                //if (Dtguias.Columns["TIPODOC"].Index == y)
                //{
                //    combo = Dtguias.Columns["TIPODOC"] as DataGridViewComboBoxColumn;
                //    combo.ValueMember = "codigo";
                //    combo.DisplayMember = "valor";
                //    combo.DataSource = tablasdocumento;
                //}
            }
            CalcularTotales();
        }
        public void CalcularTotales()
        {
            decimal total = 0;
            int con = Dtguias.RowCount;
            for (int i = 0; i < con; i++)
                if (Dtguias["neto", i].Value != null)
                    total += (decimal)Dtguias["neto", i].Value;

            txtnropagos.Text = Dtguias.RowCount.ToString();
            txttotalpagos.Text = total.ToString("n2");
        }

        private void Dtguias_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
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
                string[] campo = new string[19];
                for (int i = 0; i < con; i++)
                {
                    campo[0] = "02";
                    campo[1] = HPResergerFunciones.Utilitarios.AddCaracter(Dtguias["codigopropio", i].Value.ToString().Trim(), ' ', 20, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                    campo[2] = Dtguias["tipoop", i].Value.ToString().Trim();
                    campo[3] = HPResergerFunciones.Utilitarios.AddCaracter(Dtguias["NRODOC", i].Value.ToString().Trim(), ' ', 20, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                    DateTime FechaAux = (DateTime)Dtguias["FECVENDOC", i].Value;
                    campo[4] = FechaAux.Year + FechaAux.Month.ToString("00") + FechaAux.Day.ToString("00");
                    campo[5] = Dtguias["MONEDA", i].Value.ToString();
                    campo[6] = HPResergerFunciones.Utilitarios.AddCaracterMultiplicarx100(Dtguias["IMPORTE", i].Value.ToString(), '0', 15, HPResergerFunciones.Utilitarios.Direccion.derecha);
                    string TextAux = "";
                    if (Dtguias["BANCO", i].Value.ToString() == "xx")
                        TextAux = "0";
                    else TextAux = "1";
                    campo[7] = TextAux;
                    campo[8] = Dtguias["TIPOABONO", i].Value.ToString();
                    campo[9] = Dtguias["TIPOCUENTA", i].Value.ToString();
                    campo[10] = Dtguias["MONEDACUENTA", i].Value.ToString();
                    campo[11] = HPResergerFunciones.Utilitarios.AddCaracter(Dtguias["TIENDA", i].Value.ToString(), ' ', 3, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                    campo[12] = HPResergerFunciones.Utilitarios.AddCaracter(Dtguias["NUMEROCTA", i].Value.ToString(), ' ', 20, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                    campo[13] = Dtguias["TIPOPERSONA", i].Value.ToString();
                    campo[14] = Dtguias["TIPODOC", i].Value.ToString();
                    campo[15] = HPResergerFunciones.Utilitarios.AddCaracter(Dtguias["NRODOCUMENTO", i].Value.ToString(), ' ', 15, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                    campo[16] = HPResergerFunciones.Utilitarios.AddCaracter(Dtguias["NOMBRECLIENTE", i].Value.ToString(), ' ', 60, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                    campo[17] = HPResergerFunciones.Utilitarios.AddCaracter("0", '0', 15, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                    //campo[18] = HPResergerFunciones.Utilitarios.AddCaracter("", ' ', 8, HPResergerFunciones.Utilitarios.Direccion.izquierda); --nose si vale
                    cadenatxt += string.Join("", campo) + $"{Environment.NewLine}";
                }
                //msg(cadenatxt);
                SaveFile.FileName = "BancoInterbank " + DateTime.Now.ToLongDateString();
                if (SaveFile.FileName != string.Empty && SaveFile.ShowDialog() == DialogResult.OK)
                {
                    string path = SaveFile.FileName;
                    st = File.CreateText(path);
                    st.Write(cadenatxt);
                    st.Close();
                    HPResergerFunciones.frmInformativo.MostrarDialog("Generado TXT con Éxito");
                    PAgoFactura = true;
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else msg("Cancelado por el Usuario");
            }
            else
                msg("No hay Filas en la Grilla");
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Dtguias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }

}
