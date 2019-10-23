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
    public partial class frmBancoBcp : Form
    {
        public frmBancoBcp()
        {
            InitializeComponent();
        }
        DataTable TipoRegistro;
        DataTable TipoCuenta;
        DataTable TipoDocumento;
        DataTable TipoMonedas;
        DataTable TipoMonedaEsp;
        DataTable TipoValidacion;
        DataTable TipoComprobante;
        DataTable TipoCuentas;
        public DataTable TablaProveedorBanco;
        public DataTable TablaComprobantes;
        public DataTable TablaComprobanteS;
        public Boolean PAgoFactura = false;
        public List<frmPagarFactura.FACTURAS> Comprobantes = new List<frmPagarFactura.FACTURAS>();
        public List<frmPagarBoletas.FACTURAS> ComprobanteS = new List<frmPagarBoletas.FACTURAS>();
        public void CargarDatos()
        {
            TipoCuentas = new DataTable();
            TipoCuentas.Columns.Add("codigo");
            TipoCuentas.Columns.Add("valor");
            TipoCuentas.Rows.Add(new object[] { "C", "Corriente" });
            TipoCuentas.Rows.Add(new object[] { "M", "Maestra" });

            TipoValidacion = new DataTable();
            TipoValidacion.Columns.Add("codigo");
            TipoValidacion.Columns.Add("valor");
            TipoValidacion.Rows.Add(new object[] { "S", "SI" });
            TipoValidacion.Rows.Add(new object[] { "N", "NO" });

            TipoRegistro = new DataTable();
            TipoRegistro.Columns.Add("codigo");
            TipoRegistro.Columns.Add("valor");
            TipoRegistro.Rows.Add(new object[] { "", "" });
            TipoRegistro.Rows.Add(new object[] { "A", "ABONO" });
            TipoRegistro.Rows.Add(new object[] { "D", "DOCUMENTO" });

            TipoMonedas = new DataTable();
            TipoMonedas.Columns.Add("codigo");
            TipoMonedas.Columns.Add("valor");
            TipoMonedas.Rows.Add(new object[] { "0001", "Soles" });
            TipoMonedas.Rows.Add(new object[] { "1001", "Dolares" });

            TipoMonedaEsp = new DataTable();
            TipoMonedaEsp.Columns.Add("codigo");
            TipoMonedaEsp.Columns.Add("valor");
            TipoMonedaEsp.Rows.Add(new object[] { "", "" });
            TipoMonedaEsp.Rows.Add(new object[] { "0001", "Soles" });
            TipoMonedaEsp.Rows.Add(new object[] { "1001", "Dolares" });

            TipoCuenta = new DataTable();
            TipoCuenta.Columns.Add("codigo");
            TipoCuenta.Columns.Add("valor");
            TipoCuenta.Rows.Add(new object[] { "C", "Corriente" });
            TipoCuenta.Rows.Add(new object[] { "B", "Interbancaria" });
            TipoCuenta.Rows.Add(new object[] { "M", "Maestra" });
            TipoCuenta.Rows.Add(new object[] { "A", "Ahorros" });

            TipoDocumento = new DataTable();
            TipoDocumento.Columns.Add("codigo");
            TipoDocumento.Columns.Add("valor");
            TipoDocumento.Rows.Add(new object[] { "1", "DNI/Libreta Electoral" });
            TipoDocumento.Rows.Add(new object[] { "3", "Carnet de Extranjería" });
            TipoDocumento.Rows.Add(new object[] { "4", "Pasaporte" });
            TipoDocumento.Rows.Add(new object[] { "6", "RUC" });
            TipoDocumento.Rows.Add(new object[] { "7", "Documento Ficticio" });

            TipoComprobante = new DataTable();
            TipoComprobante.Columns.Add("codigo");
            TipoComprobante.Columns.Add("valor");
            TipoComprobante.Rows.Add(new object[] { "", "" });
            TipoComprobante.Rows.Add(new object[] { "F", "Factura" });
            // TipoComprobante.Rows.Add(new object[] { "N", "Nota Crédito" });///
            TipoComprobante.Rows.Add(new object[] { "C", "Nota Débito" });
            //TipoComprobante.Rows.Add(new object[] { "E", "Factura de la Empresa" });///
            TipoComprobante.Rows.Add(new object[] { "M", "Nota Crédito Empresa" });
            //  TipoComprobante.Rows.Add(new object[] { "B", "Nota Débito Empresa" });///
            TipoComprobante.Rows.Add(new object[] { "Z", "Cobranza" });
            TipoComprobante.Rows.Add(new object[] { "D", "Otros" });
        }
        public DataTable TablaConsulta;
        public Color Naranja, Azul;
        public void CargarColores()
        {
            Naranja = Color.FromArgb(244, 124, 46);
            Azul = Color.FromArgb(0, 75, 140);
        }
        private void frmBancoBcp_Load(object sender, EventArgs e)
        {
            txtcuentapago.Text = HPResergerFunciones.Utilitarios.QuitarCaracterCuenta(txtcuentapago.Text, '-');
            CargarColores();
            //ABONOS EN CUENTAS
            Dtguias.Columns[TIPODOC.Name.ToString()].HeaderCell.Style.BackColor = Naranja;
            Dtguias.Columns[NRODOCUMENTO.Name.ToString()].HeaderCell.Style.BackColor = Naranja;
            Dtguias.Columns[MONEDAPAGO.Name.ToString()].HeaderCell.Style.BackColor = Naranja;
            Dtguias.Columns[MONTODOC.Name.ToString()].HeaderCell.Style.BackColor = Naranja;
            //ABONO EN CHEQUE
            dtgcheques.Columns[TIPODOC2.Name.ToString()].HeaderCell.Style.BackColor = Naranja;
            dtgcheques.Columns[NRODOC2.Name.ToString()].HeaderCell.Style.BackColor = Naranja;
            dtgcheques.Columns[MONEDADOC2.Name.ToString()].HeaderCell.Style.BackColor = Naranja;
            dtgcheques.Columns[MONTODOC2.Name.ToString()].HeaderCell.Style.BackColor = Naranja;
            //// CARGAR VALORES
            CargarDatos();
            //TIPO DE CUENTA
            cbotipocuenta.DataSource = TipoCuentas;
            cbotipocuenta.DisplayMember = "valor";
            cbotipocuenta.ValueMember = "codigo";
            ///tipo ift
            cboitf.DataSource = TipoValidacion;
            cboitf.DisplayMember = "valor";
            cboitf.ValueMember = "codigo";
            cboitf.SelectedIndex = 1;
            ///CARGA DE DATOS DEL OTRO FORMULARIO
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
                    //TablaComprobantes.Rows.Add(new object[] { 1, fac.tipo, fac.numero, fac.proveedor, fac.detraccion, fac.total, fac.fechacancelado });
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
            TablaConsulta = new DataTable();
            if (!PAgoFactura)
            {
                ////cargar valores de los proveedores               
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
                                 banco = tblproveedor["Entidad_Financiera"],
                                 tipocuenta = tblproveedor["tipocuenta"],
                                 moneda = tblproveedor["moneda"]
                             };
                TablaConsulta.Columns.Add("codigo", typeof(string));
                TablaConsulta.Columns.Add("tipocuenta", typeof(string));
                TablaConsulta.Columns.Add("monedaabono", typeof(string));
                TablaConsulta.Columns.Add("neto", typeof(decimal));
                //TablaConsulta.Columns.Add("banco", typeof(string));
                //TablaConsulta.Columns.Add("tipoabono", typeof(string));
                TablaConsulta.Columns.Add("nrocuenta", typeof(string));
                TablaConsulta.Columns.Add("tipodoc", typeof(string));
                TablaConsulta.Columns.Add("nrodoc", typeof(string));
                TablaConsulta.Columns.Add("razon", typeof(string));
                TablaConsulta.Columns.Add("correlativo", typeof(string));
                TablaConsulta.Columns.Add("cantidad", typeof(int));
                TablaConsulta.Columns.Add("tipoop", typeof(string));
                TablaConsulta.Columns.Add("nrofac", typeof(string));
                TablaConsulta.Columns.Add("monedacuenta", typeof(string));
                TablaConsulta.Columns.Add("validacion", typeof(string));
                //paso para la configuracion de la tabla
                string tipo = "F", SolesFacturas = "0001", SolesAbono = "0001", tipodoc = "6", tipocuenta = "";
                string M = "";
                decimal total = 0;
                foreach (var x in cargas)
                {
                    if (x.moneda.ToString().Trim() == "1") { SolesAbono = "0001"; M = "S"; } else SolesAbono = "1001"; M = "D";
                    if (x.tipo.ToString().Trim().ToUpper() == "FT" || x.tipo.ToString().Trim().ToUpper() == "RH")
                        tipo = "F";
                    if (x.ctaseleccionada.ToString().Length >= 20)
                    {
                        if (x.cuentaccisoles.ToString().Substring(0, x.cuentaccisoles.ToString().Length - 6) == x.ctaseleccionada.ToString())
                            tipocuenta = "B";
                    }
                    else if (x.tipocuenta.ToString().Trim().ToUpper() == "CORRIENTE")
                        tipocuenta = "C";
                    else tipocuenta = "A";

                    total = decimal.Parse(x.total.ToString());
                    TablaConsulta.Rows.Add("A", tipocuenta, SolesAbono, total, x.ctaseleccionada, tipodoc, x.proveedor, x.razonsocial, "", 1, tipo, x.nro, SolesAbono, "S");
                }
                Dtguias.DataSource = TablaConsulta;
                Dtguias_RowEnter(sender, new DataGridViewCellEventArgs(0, 0));
            }
            else
            {
                ///datos de empleado
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
                                 tipocuenta = tblproveedor["tipocuenta"],
                                 moneda = tblproveedor["moneda"]
                             };
                //creacion de la tabla de consulta
                TablaConsulta.Columns.Add("codigo", typeof(string));
                TablaConsulta.Columns.Add("tipocuenta", typeof(string));
                TablaConsulta.Columns.Add("monedaabono", typeof(string));
                TablaConsulta.Columns.Add("neto", typeof(decimal));
                //TablaConsulta.Columns.Add("banco", typeof(string));
                //TablaConsulta.Columns.Add("tipoabono", typeof(string));
                TablaConsulta.Columns.Add("nrocuenta", typeof(string));
                TablaConsulta.Columns.Add("tipodoc", typeof(string));
                TablaConsulta.Columns.Add("nrodoc", typeof(string));
                TablaConsulta.Columns.Add("razon", typeof(string));
                TablaConsulta.Columns.Add("correlativo", typeof(string));
                TablaConsulta.Columns.Add("cantidad", typeof(int));
                TablaConsulta.Columns.Add("tipoop", typeof(string));
                TablaConsulta.Columns.Add("nrofac", typeof(string));
                TablaConsulta.Columns.Add("monedacuenta", typeof(string));
                TablaConsulta.Columns.Add("validacion", typeof(string));
                TablaConsulta.Columns.Add("fecha", typeof(DateTime));
                ///paso de configuracion para guardar
                string tipo = "F", SolesFacturas = "0001", SolesAbono = "0001", tipodoc = "1", tipocuenta = "";
                string M = "";
                decimal total = 0;
                foreach (var x in cargas)
                {
                    if (x.moneda.ToString().Trim() == "1") { SolesAbono = "0001"; M = "S"; } else SolesAbono = "1001"; M = "D";
                    if (x.tipo.ToString().Trim().ToUpper() == "FT" || x.tipo.ToString().Trim().ToUpper() == "RH")
                        tipo = "F";
                    if (x.ctaseleccionada.ToString().Length >= 20)
                    {
                        if (x.cuentaccisoles.ToString().Substring(0, x.cuentaccisoles.ToString().Length - 6) == x.ctaseleccionada.ToString())
                            tipocuenta = "B";
                    }
                    else if (x.tipocuenta.ToString().Trim().ToUpper() == "CORRIENTE")
                        tipocuenta = "C";
                    else tipocuenta = "A";

                    total = decimal.Parse(x.total.ToString());
                    TablaConsulta.Rows.Add("A", tipocuenta, SolesAbono, total, x.ctaseleccionada, tipodoc, x.nro, x.razonsocial, "", 1, tipo, x.nro, SolesAbono, "S", x.fechacancelado);
                }
                Dtguias.DataSource = TablaConsulta;
                Dtguias_RowEnter(sender, new DataGridViewCellEventArgs(0, 0));
            }
        }
        DataGridViewComboBoxColumn Combo;
        private void Dtguias_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Dtguias.RowCount > 0)
            {
                int y = e.RowIndex;
                Combo = Dtguias.Columns[TIPOREGISTRO1.Name.ToString()] as DataGridViewComboBoxColumn;
                Combo.DataSource = TipoRegistro;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "valor";
                //
                Combo = Dtguias.Columns[TIPOABONO.Name.ToString()] as DataGridViewComboBoxColumn;
                Combo.DataSource = TipoCuenta;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "valor";
                //
                Combo = Dtguias.Columns[TIPODOCUMENTO1.Name.ToString()] as DataGridViewComboBoxColumn;
                Combo.DataSource = TipoDocumento;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "valor";
                //
                Combo = Dtguias.Columns[MONEDAABONO.Name.ToString()] as DataGridViewComboBoxColumn;
                Combo.DataSource = TipoMonedas;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "valor";
                //
                Combo = Dtguias.Columns[VALIDACIONIDC.Name.ToString()] as DataGridViewComboBoxColumn;
                Combo.DataSource = TipoValidacion;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "valor";
                //
                Combo = Dtguias.Columns[MONEDAPAGO.Name.ToString()] as DataGridViewComboBoxColumn;
                Combo.DataSource = TipoMonedaEsp;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "valor";
                //
                Combo = Dtguias.Columns[TIPODOC.Name.ToString()] as DataGridViewComboBoxColumn;
                Combo.DataSource = TipoComprobante;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "valor";
            }
            CalcularTotales();
        }
        private void Dtguias_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
        private void dtgcheques_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Dtguias.RowCount > 0)
            {
                int y = e.RowIndex;
                Combo = dtgcheques.Columns[TIPOREGISTRO2.Name.ToString()] as DataGridViewComboBoxColumn;
                Combo.DataSource = TipoRegistro;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "valor";

                Combo = dtgcheques.Columns[TIPODOCUMENTO2.Name.ToString()] as DataGridViewComboBoxColumn;
                Combo.DataSource = TipoDocumento;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "valor";

                Combo = dtgcheques.Columns[MONEDAABONO2.Name.ToString()] as DataGridViewComboBoxColumn;
                Combo.DataSource = TipoMonedas;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "valor";

                Combo = dtgcheques.Columns[MONEDADOC2.Name.ToString()] as DataGridViewComboBoxColumn;
                Combo.DataSource = TipoMonedaEsp;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "valor";

                Combo = dtgcheques.Columns[VALIDACION2.Name.ToString()] as DataGridViewComboBoxColumn;
                Combo.DataSource = TipoValidacion;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "valor";

                Combo = dtgcheques.Columns[TIPODOC2.Name.ToString()] as DataGridViewComboBoxColumn;
                Combo.DataSource = TipoComprobante;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "valor";
            }
            CalcularTotales();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TablaConsulta.Rows.Add();
        }
        TextBox txt;
        private void Dtguias_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int x = Dtguias.CurrentCell.RowIndex;
            int y = Dtguias.CurrentCell.ColumnIndex;
            if (x >= 0)
            {
                if (Dtguias.Columns[NOMBREPROVEEDOR.Name.ToString()].Index == y)
                {
                    txt = e.Control as TextBox;
                    txt.KeyPress -= new KeyPressEventHandler(LetrasMayuscula);
                    txt.KeyPress += new KeyPressEventHandler(LetrasMayuscula);
                }
            }
        }
        private void LetrasMayuscula(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
        private void Dtguias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            if (x >= 0)
            {
                Dtguias[TIPOREGISTRO1.Name.ToString(), 0].Value = "A";
                if (Dtguias[TIPOREGISTRO1.Name.ToString(), x].Value.ToString().ToUpper().Trim() == "A")
                    Dtguias["TIPOABONO", x].ReadOnly = Dtguias["CUENTAABONO", x].ReadOnly = Dtguias["TIPODOCUMENTO1", x].ReadOnly = Dtguias["NUMDOCIDE", x].ReadOnly = Dtguias["NOMBREPROVEEDOR", x].ReadOnly = Dtguias["MONEDAABONO", x].ReadOnly
                            = Dtguias["MONTOABONO", x].ReadOnly = Dtguias["VALIDACIONIDC", x].ReadOnly = Dtguias["CANTIDADDOCUMENTOS", x].ReadOnly = false;
                else
                    Dtguias["TIPOABONO", x].ReadOnly = Dtguias["CUENTAABONO", x].ReadOnly = Dtguias["TIPODOCUMENTO1", x].ReadOnly = Dtguias["NUMDOCIDE", x].ReadOnly = Dtguias["NOMBREPROVEEDOR", x].ReadOnly = Dtguias["MONEDAABONO", x].ReadOnly
                            = Dtguias["MONTOABONO", x].ReadOnly = Dtguias["VALIDACIONIDC", x].ReadOnly = Dtguias["CANTIDADDOCUMENTOS", x].ReadOnly = true;
            }
        }
        private void Dtguias_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            int y = e.ColumnIndex;
            if (x >= 0)
            {
                if (Dtguias.Columns[CANTIDADDOCUMENTOS.Name.ToString()].Index == y)
                {
                    int val = 0;
                    if (!string.IsNullOrWhiteSpace(Dtguias[y, x].Value.ToString()))
                    {
                        Dtguias["TIPODOC", x].ReadOnly = Dtguias["NRODOCUMENTO", x].ReadOnly = Dtguias["MONEDAPAGO", x].ReadOnly = Dtguias["MONTODOC", x].ReadOnly = true;
                        val = (int)Dtguias[y, x].Value;
                        if (val == 0)
                            Dtguias["TIPODOC", x].ReadOnly = Dtguias["NRODOCUMENTO", x].ReadOnly = Dtguias["MONEDAPAGO", x].ReadOnly = Dtguias["MONTODOC", x].ReadOnly = true;
                        else
                            Dtguias["TIPODOC", x].ReadOnly = Dtguias["NRODOCUMENTO", x].ReadOnly = Dtguias["MONEDAPAGO", x].ReadOnly = Dtguias["MONTODOC", x].ReadOnly = false;
                        if (val == 1)
                            Dtguias["TIPODOC", x].ReadOnly = Dtguias["NRODOCUMENTO", x].ReadOnly = Dtguias["MONEDAPAGO", x].ReadOnly = Dtguias["MONTODOC", x].ReadOnly = false;
                        if (val >= 2)
                        {
                            for (int i = 1; i < val; i++)
                            {
                                TablaConsulta.Rows.InsertAt(TablaConsulta.NewRow(), x + 1);
                            }
                        }
                    }
                }
            }
        }
        private void Dtguias_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                int x = Dtguias.CurrentCell.RowIndex;
                int y = Dtguias.CurrentCell.ColumnIndex;
                if (x >= 0)
                {
                    if (e.KeyCode == Keys.Delete)
                    {
                        if (MessageBox.Show("Desea Eliminar la Fila", CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            TablaConsulta.Rows.RemoveAt(x);
                        }
                    }
                }
            }
            catch (Exception) { }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        string cadenatxt = "";
        private StreamWriter st;
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Validaciones
            foreach (DataGridViewRow item in Dtguias.Rows)
            {
                string Valor = ""; string valor2 = item.Cells[CUENTAABONO.Name].Value.ToString();
                Valor = item.Cells[TIPOABONO.Name].Value.ToString().Trim();
                if ((Valor == "M" || Valor == "C") && valor2.Length == 13)
                    HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[CUENTAABONO.Name]);
                else if (Valor == "B" && valor2.Length == 20)
                    HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[CUENTAABONO.Name]);
                else if (Valor == "A" && valor2.Length == 14)
                    HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[CUENTAABONO.Name]);
                else
                {
                    HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[CUENTAABONO.Name]);
                    return;
                }
            }
            //Fin Validaciones
            PAgoFactura = false;
            int con = Dtguias.RowCount;
            if (con > 0)
            {
                cadenatxt = "";
                ///encabezado
                string cuent = HPResergerFunciones.Utilitarios.QuitarCaracterCuenta(txtcuentapago.Text, '-');
                string mone = cuent.Substring(10, 1);
                if (mone == "0")
                    mone = "0001";
                else mone = "1001";
                DateTime FechaAux = dtpFechaProceso.Value;

                cadenatxt = $"1" + txtcantidaabono.Text + FechaAux.Year + FechaAux.Month.ToString("00") + FechaAux.Day.ToString("00") + cbotipocuenta.SelectedValue.ToString() + mone + HPResergerFunciones.Utilitarios.AddCaracter(cuent, ' ', 20, HPResergerFunciones.Utilitarios.Direccion.izquierda)
                    + HPResergerFunciones.Utilitarios.AddCaracter(decimal.Parse(txtmontototal.Text).ToString("000000.00"), '0', 17, HPResergerFunciones.Utilitarios.Direccion.derecha) + HPResergerFunciones.Utilitarios.AddCaracter(txtreferenciaplanilla.Text, ' ', 40, HPResergerFunciones.Utilitarios.Direccion.izquierda)
                    + cboitf.SelectedValue.ToString() + HPResergerFunciones.Utilitarios.AddCaracter(ObtenerControlTotal(cuent).ToString(), '0', 15, HPResergerFunciones.Utilitarios.Direccion.derecha) + $"{Environment.NewLine}";
                //detalles
                string[] campo = new string[16];
                for (int i = 0; i < con; i++)
                {
                    if (!string.IsNullOrWhiteSpace(Dtguias[TIPOREGISTRO1.Name.ToString(), i].Value.ToString()))
                        if (Dtguias[TIPOREGISTRO1.Name.ToString(), i].Value.ToString().Trim().ToUpper() == "A")
                        {
                            campo[0] = "2";
                            campo[1] = Dtguias[TIPOABONO.Name.ToString(), i].Value.ToString().ToUpper();
                            campo[2] = HPResergerFunciones.Utilitarios.AddCaracter(Dtguias[CUENTAABONO.Name.ToUpper(), i].Value.ToString(), ' ', 20, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                            campo[3] = "1";
                            campo[4] = Dtguias[TIPODOCUMENTO1.Name.ToString(), i].Value.ToString();
                            campo[5] = HPResergerFunciones.Utilitarios.AddCaracter(Dtguias[NUMDOCIDE.Name.ToString(), i].Value.ToString(), ' ', 12, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                            campo[6] = "   ";
                            campo[7] = HPResergerFunciones.Utilitarios.AddCaracter(Dtguias[NOMBREPROVEEDOR.Name.ToString(), i].Value.ToString(), ' ', 75, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                            campo[8] = HPResergerFunciones.Utilitarios.AddCaracter("Referencia Beneficiario " + Dtguias[NUMDOCIDE.Name.ToString(), i].Value.ToString(), ' ', 40, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                            campo[9] = HPResergerFunciones.Utilitarios.AddCaracter("Ref Emp " + Dtguias[NUMDOCIDE.Name.ToString(), i].Value.ToString(), ' ', 20, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                            //if (Dtguias[MONEDAABONO.Name.ToString(), i].Value.ToString().Trim().ToUpper() == "S")
                            //    mone = "0001";
                            //else mone = "1001";
                            //campo[10] = mone;
                            campo[10] = Dtguias[MONEDAABONO.Name.ToString(), i].Value.ToString().Trim().ToUpper();
                            campo[11] = HPResergerFunciones.Utilitarios.AddCaracter(Dtguias[MONTOABONO.Name.ToString(), i].Value.ToString(), '0', 17, HPResergerFunciones.Utilitarios.Direccion.derecha);
                            campo[12] = Dtguias[VALIDACIONIDC.Name.ToString(), i].Value.ToString();
                            cadenatxt += string.Join("", campo) + $"{Environment.NewLine}";
                            ////limpiamos el campo
                            campo = null;
                            if (int.Parse(Dtguias[CANTIDADDOCUMENTOS.Name.ToString(), i].Value.ToString()) != 0)
                            {
                                campo = new string[16];
                                campo[0] = "3";
                                campo[1] = Dtguias[TIPODOC.Name.ToString(), i].Value.ToString();
                                string cadena = Dtguias[NRODOCUMENTO.Name.ToString(), i].Value.ToString().Trim();
                                string resul = "";
                                foreach (char c in cadena)
                                {
                                    if (c == '-')
                                    {
                                        resul += " ";
                                    }
                                    else resul += c;
                                }
                                campo[2] = HPResergerFunciones.Utilitarios.AddCaracter(resul, '0', 15, HPResergerFunciones.Utilitarios.Direccion.derecha);
                                campo[3] = HPResergerFunciones.Utilitarios.AddCaracter(Dtguias[MONTODOC.Name.ToString(), i].Value.ToString(), '0', 17, HPResergerFunciones.Utilitarios.Direccion.derecha);
                                cadenatxt += string.Join("", campo) + $"{Environment.NewLine}";
                            }
                        }
                        else
                        {
                            campo = null; campo = new string[16];
                            campo[0] = "3";
                            campo[1] = Dtguias[TIPODOC.Name.ToString(), i].Value.ToString();
                            string cadena = Dtguias[NRODOCUMENTO.Name.ToString(), i].Value.ToString().Trim();
                            string resul = "";
                            foreach (char c in cadena)
                            {
                                if (c == '-')
                                {
                                    resul += " ";
                                }
                                else resul += c;
                            }
                            campo[2] = HPResergerFunciones.Utilitarios.AddCaracter(resul, '0', 15, HPResergerFunciones.Utilitarios.Direccion.derecha);
                            campo[3] = HPResergerFunciones.Utilitarios.AddCaracter(Dtguias[MONTODOC.Name.ToString(), i].Value.ToString(), '0', 17, HPResergerFunciones.Utilitarios.Direccion.derecha);
                            cadenatxt += string.Join("", campo) + $"{Environment.NewLine}";
                        }
                }
                //msg(cadenatxt);
                SaveFile.FileName = $"BCP - {txtreferenciaplanilla.Text} - {txtmontototal.Text} - {DateTime.Now.ToLongDateString()}";
                if (SaveFile.FileName != string.Empty && SaveFile.ShowDialog() == DialogResult.OK)
                {
                    string path = SaveFile.FileName;
                    st = File.CreateText(path);
                    st.Write(cadenatxt);
                    st.Close();
                    if (msgYesNO("Generado TXT con Éxito, Desea Continuar.") == DialogResult.Yes)//Cambiamos a Yes Cuando ya este!
                    {
                        PAgoFactura = true;
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    msg("Cancelado por el Usuario"); DialogResult = DialogResult.Cancel;
                }
            }
            else
                msg("No hay Filas en la Grilla");
        }
        public decimal ObtenerControlTotal(string cuenta)
        {
            decimal Control = 0;
            Control += decimal.Parse(cuenta.Substring(3, cuenta.Length - 3));
            int pos = 0;
            foreach (DataGridViewRow fila in Dtguias.Rows)
            {
                string cadenita = fila.Cells[CUENTAABONO.Name.ToString()].Value.ToString();
                if (fila.Cells[TIPOREGISTRO1.Name.ToString()].Value.ToString().Trim().ToUpper() == "A")
                    if (fila.Cells[TIPOABONO.Name.ToString()].Value.ToString().Trim().ToUpper() == "B")
                        Control += decimal.Parse(cadenita.Substring(10, cadenita.Length - 10));
                    else Control += decimal.Parse(cadenita.Substring(3, cadenita.Length - 3));
                pos++;
            }
            return Control;
        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public DialogResult msgYesNO(string cadena) { return HPResergerFunciones.Utilitarios.msgYesNo(cadena); }

        public void CalcularTotales()
        {
            int cont1 = 0, cont2 = 0, registros = 0;
            decimal montos = 0;
            cont1 = Dtguias.RowCount;
            cont2 = dtgcheques.RowCount;
            try
            {
                if (cont1 > 0)
                    for (int i = 0; i < cont1; i++)
                    {
                        if (!string.IsNullOrWhiteSpace(Dtguias[MONTOABONO.Name.ToString(), i].Value.ToString()))
                            montos += (decimal)Dtguias[MONTOABONO.Name.ToString(), i].Value;
                        if (!string.IsNullOrWhiteSpace(Dtguias[TIPOREGISTRO1.Name.ToString(), i].Value.ToString()))
                            if (Dtguias[TIPOREGISTRO1.Name.ToString(), i].Value.ToString().ToUpper().Trim() == "A")
                                registros += 1;
                    }
                if (cont2 > 0)
                    for (int i = 0; i < cont2; i++)
                    {
                        if (!string.IsNullOrWhiteSpace(dtgcheques[MONTOABONO2.Name.ToString(), i].Value.ToString()))
                            montos += (decimal)dtgcheques[MONTOABONO2.Name.ToString(), i].Value;
                        if (!string.IsNullOrWhiteSpace(dtgcheques[TIPOREGISTRO2.Name.ToString(), i].Value.ToString()))
                            if (dtgcheques[TIPOREGISTRO2.Name.ToString(), i].Value.ToString().ToUpper().Trim() == "A")
                                registros += 1;
                    }
            }
            catch (Exception) { }
            txtcantidaabono.Text = registros.ToString("000000");
            txtmontototal.Text = montos.ToString("n2");
        }
    }
}
