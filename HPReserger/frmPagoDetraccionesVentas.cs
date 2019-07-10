using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmPagoDetraccionesVentas : FormGradient
    {
        public frmPagoDetraccionesVentas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmPagoDetraccionesVentas_Load(object sender, EventArgs e)
        {
            DataRow Filita = CapaLogica.VerUltimoIdentificador("TBL_Factura", "Nro_DocPago");
            if (Filita != null)
                txtnropago.Text = (decimal.Parse(Filita["ultimo"].ToString()) + 1).ToString();
            else txtnropago.Text = "1";
            // CargarTiposID("TBL_Tipo_ID");
            cargarempresas();
            cbotipo.SelectedIndex = 0;
            Detracion = new List<Detracciones>();
            CargarDAtos();
            dtpFechaPago.Value = dtpFechaContable.Value = DateTime.Now;
        }
        public void cargarempresas()
        {
            CapaLogica.TablaEmpresa(cboempresa);
        }
        public void CargarDAtos()
        {
            dtgconten.DataSource = CapaLogica.DetraccionesPorPAgarVentas((int)cboempresa.SelectedValue);
            NumRegistrosdtg();
            SeleccionarDetracionesSeleccionadas();
            CalcularValoresRedondeoyDiferencia();
        }
        public void CalcularValoresRedondeoyDiferencia()
        {
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                item.Cells[xredondeo.Name].Value = Math.Round((decimal)item.Cells[ImportePEN.Name].Value);
                //  item.Cells[xDiferencia.Name].Value = (decimal)item.Cells[porpagarx.Name].Value - (decimal)item.Cells[xRedondeo.Name].Value;
            }
        }
        public void CargarCuentasBancos()
        {
            if (cboempresa.SelectedValue != null && cbobanco.SelectedValue != null)
            {
                cbocuentabanco.ValueMember = "Id_Cuenta_Contable";
                cbocuentabanco.DisplayMember = "banco";
                cbocuentabanco.DataSource = CapaLogica.ListarBancosTiposdePagoxEmpresa(cbobanco.SelectedValue.ToString(), (int)cboempresa.SelectedValue, 0);
            }
        }
        public void SeleccionarDetracionesSeleccionadas()
        {
            if (Detracion != null)
                foreach (DataGridViewRow item in dtgconten.Rows)
                {
                    foreach (Detracciones det in Detracion)
                    {
                        if (item.Cells[nrofacturax.Name].Value.ToString() == det._nrodetracion && item.Cells[Clientex.Name].Value.ToString() == det._proveedor && det._idComprobante == (int)item.Cells[xtipocomprobante.Name].Value)
                        {
                            item.Cells[opcionx.Name].Value = 1;
                        }
                    }
                }
        }
        public void NumRegistrosdtg()
        {
            lblmensaje.Text = $"Número de Registros={dtgconten.RowCount}";
        }
        private void btnseleccion_Click(object sender, EventArgs e)
        {
            if (btnseleccion.Text == "Seleccionar Todo")
            {
                foreach (DataGridViewRow item in dtgconten.Rows)
                {
                    item.Cells[opcionx.Name].Value = 1;
                    btnseleccion.Text = "Deseleccionar Todo";
                }
            }
            else
            {
                btnseleccion.Text = "Seleccionar Todo";
                foreach (DataGridViewRow item in dtgconten.Rows)
                {
                    item.Cells[opcionx.Name].Value = 0;
                }
            }
        }
        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgconten.Columns[opcionx.Name].Index)
            {
                dtgconten.EndEdit();
            }
        }
        decimal sumatoria = 1000;
        public class Detracciones
        {
            public string _nrodetracion;
            public string _proveedor;
            public decimal _monto;
            public int _idComprobante;
            public Detracciones(string nrofactura, string proveedor, decimal monto, int idcomprobantes)
            {
                _nrodetracion = nrofactura;
                _proveedor = proveedor;
                _monto = monto;
                _idComprobante = idcomprobantes;
            }
        }
        List<Detracciones> Detracion; private string _NameEmpresa;
        public string NameEmpresa
        {
            get { return _NameEmpresa; }
            set
            {
                if (value != NameEmpresa)
                    Detracion.Clear();
                _NameEmpresa = value;
            }
        }
        private void cboempresa_Click(object sender, EventArgs e)
        {
            string cadena = cboempresa.Text;
            CapaLogica.TablaEmpresa(cboempresa);
            cboempresa.Text = cadena;
        }
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbobanco.SelectedValue != null)
            {
                CargarCuentasBancos();
                NameEmpresa = cboempresa.Text;
                CargarDAtos();
            }
            BuscarCuentaDetracicones();
        }
        private void cbobanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbobanco.SelectedIndex >= 0)
            {
                cbocuentabanco.Text = "";
                CargarCuentasBancos();

            }
        }
        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotipo.SelectedIndex == 0 || cbotipo.SelectedIndex == 1)
            {
                cbobanco.Visible = lblguia1.Visible = lblguia.Visible = cbocuentabanco.Visible = true;
                lblguia.Text = "Banco";
                cbobanco.ValueMember = "codigo";
                cbobanco.DisplayMember = "descripcion";
                cbobanco.DataSource = CapaLogica.getCargoTipoContratacion("Sufijo", "Entidad_Financiera", "TBL_Entidad_Financiera");
            }
            else
            {
                cbobanco.Visible = lblguia1.Visible = lblguia.Visible = cbocuentabanco.Visible = false;
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Detracion.Clear();
            foreach (DataGridViewRow item in dtgconten.Rows)
                if ((int)item.Cells[opcionx.Name].Value == 1)
                    Detracion.Add(new Detracciones(item.Cells[nrofacturax.Name].Value.ToString(), item.Cells[Clientex.Name].Value.ToString(), (decimal)item.Cells[ImportePEN.Name].Value, (int)item.Cells[xtipocomprobante.Name].Value));
            CargarDAtos();
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgconten_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int x = e.RowIndex;
            dtgconten.Rows[x].DefaultCellStyle.ForeColor = Configuraciones.OscuroUISelect;
            dtgconten.Rows[x].DefaultCellStyle.SelectionBackColor = Configuraciones.AzulUI;
        }
        private void dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (dtgconten.RowCount > 0)
            {
                if (y == dtgconten.Columns[xredondeo.Name].Index)
                {
                    /////si el valor de la detracciones es menor que 1 sol
                    if (decimal.Parse(dtgconten[xredondeo.Name, x].Value.ToString()) < 1)
                        dtgconten[xredondeo.Name, x].Value = 1;
                    dtgconten[xdiferencia.Name, x].Value = Configuraciones.Redondear((decimal)dtgconten[ImportePEN.Name, x].Value) - Configuraciones.Redondear(decimal.Parse(dtgconten[xredondeo.Name, x].Value.ToString()));
                }
                //if ((decimal)dtgconten[porpagarx.Name, x].Value > (decimal)dtgconten[Detraccionx.Name, x].Value)
                //{
                //    dtgconten[porpagarx.Name, x].Value = (decimal)dtgconten[Detraccionx.Name, x].Value;
                //}
                CalcularTotal();
            }
        }
        decimal SumDiferencia = 0, SumRedondeo = 0;
        public void CalcularTotal()
        {
            SumDiferencia = SumRedondeo = 0;
            sumatoria = 0;
            int Seleccionados = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if ((int)item.Cells[opcionx.Name].Value == 1)
                //Valores Seleccionados
                {
                    sumatoria += Redondear((decimal)item.Cells[ImportePEN.Name].Value);
                    SumDiferencia += Redondear((decimal)item.Cells[xdiferencia.Name].Value);
                    SumRedondeo += Redondear((decimal)item.Cells[xredondeo.Name].Value);
                    Seleccionados++;
                }
            }
            txttotal.Text = sumatoria.ToString("n2");
            txtredondeo.Text = SumRedondeo.ToString("n2");
            txtdiferencia.Text = SumDiferencia.ToString("n2");
            if (Seleccionados > 0) btnaceptar.Enabled = true;
            else btnaceptar.Enabled = false;
        }
        public decimal Redondear(decimal valor) { return Configuraciones.Redondear(valor); }
        public Boolean VerificarErrorDiferencia()
        {
            Boolean Prueba = true;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if ((int)item.Cells[opcionx.Name].Value == 1)
                {
                    if (Math.Abs((decimal)item.Cells[xdiferencia.Name].Value) >= 1)
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xredondeo.Name]);
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xdiferencia.Name]);
                        Prueba = false;
                    }
                    else
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xredondeo.Name]);
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xdiferencia.Name]);
                    }
                }
                else
                {
                    HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xredondeo.Name]);
                    HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xdiferencia.Name]);
                }
            }
            if (!Prueba)
            {
                msg("El Redondeo no puede Superar a : S/ 1");
            }
            return Prueba;
        }
        public DialogResult msgP(string cadena) { return HPResergerFunciones.Utilitarios.msgYesNoCancel(cadena); }
        public void msg(string cadena) { HPResergerFunciones.Utilitarios.msg(cadena); }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                if (sumatoria > 0)
                {
                    if (cbobanco.Items.Count == 0)
                    {
                        HPResergerFunciones.Utilitarios.msg("No hay Bancos");
                        cbobanco.Focus();
                        return;
                    }
                    if (cbocuentabanco.Items.Count == 0)
                    {
                        HPResergerFunciones.Utilitarios.msg("El Banco Seleccionado No tiene Cuenta");
                        cbobanco.Focus();
                        return;
                    }
                    if (txttotal.Text.Length > 0)
                    {
                        if (decimal.Parse(txttotal.Text) == 0)
                        {
                            HPResergerFunciones.Utilitarios.msg("El total a pagar no puede ser Cero");
                            dtgconten.Focus();
                            return;
                        }
                    }
                    if (!txtDescCuenta.EstaLLeno()) { msg("Seleccione Cuenta Contable de Detracciones"); txtcuentadetracciones.Focus(); return; }
                    DataTable TPrueba2 = CapaLogica.VerPeriodoAbierto((int)cboempresa.SelectedValue, dtpFechaContable.Value);
                    if (TPrueba2.Rows.Count == 0) { msg("El Periodo está Cerrado cambie la Fecha Contable"); dtpFechaContable.Focus(); return; }
                    Boolean Verificar = false;
                    //validar que no se pague valores en cero
                    foreach (DataGridViewRow item in dtgconten.Rows)
                    {
                        if ((int)item.Cells[opcionx.Name].Value == 1)
                        {
                            if ((decimal)item.Cells[ImportePEN.Name].Value == 0)
                            {
                                Verificar = true;
                                HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[ImportePEN.Name]);
                            }
                            else
                                HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[ImportePEN.Name]);
                        }
                    }
                    if (!VerificarErrorDiferencia()) return;
                    if (Verificar) { HPResergerFunciones.Utilitarios.msg("No se Puede Pagar Valores en Cero"); return; }
                    ///PROCESO DEL TXT
                    DialogResult Result = msgP("Desea Generar el TXT de Pago");
                    if (Result == DialogResult.Cancel) return;
                    if (Result == DialogResult.Yes)
                    {
                        frmDetraccionVentaPagoBancoNacion frmpagoventa = new frmDetraccionVentaPagoBancoNacion();
                        frmpagoventa.IdEmpresa = (int)cboempresa.SelectedValue;
                        ////datos de la tabla
                        //frmpagoventa.TDetracciones = new DataTable();
                        dtgconten.EndEdit();
                        dtgconten.RefreshEdit();
                        //frmpagoventa.TDetracciones = new DataTable();
                        frmpagoventa.TDetracciones = ((DataTable)dtgconten.DataSource).Clone();
                        foreach (DataRow item in ((DataTable)dtgconten.DataSource).Rows)
                            frmpagoventa.TDetracciones.Rows.Add(item.ItemArray);

                        if (frmpagoventa.ShowDialog() != DialogResult.Yes) return;
                    }
                    //PROCESO DE PAGO
                    string NroBoleta = "", Idcliente = "";
                    int idcomprobante = 0;
                    int Tipoid = 0;
                    int posSelec = cbocuentabanco.SelectedIndex;
                    string NroCuenta = ((DataTable)cbocuentabanco.DataSource).Rows[posSelec]["NroCta"].ToString();
                    foreach (DataGridViewRow item in dtgconten.Rows)
                    {
                        if ((int)item.Cells[opcionx.Name].Value == 1)
                        {
                            //si el valor a pagar es superior a cero
                            if ((decimal)item.Cells[ImportePEN.Name].Value != 0)
                            {
                                NroBoleta = item.Cells[nrofacturax.Name].Value.ToString();
                                Idcliente = item.Cells[Clientex.Name].Value.ToString();
                                Tipoid = (int)item.Cells[tipoidx.Name].Value;
                                idcomprobante = (int)item.Cells[xtipocomprobante.Name].Value;
                                CapaLogica.DetraccionesVenta(1, NroBoleta, Tipoid, Idcliente, (decimal)item.Cells[ImporteMOx.Name].Value, (decimal)item.Cells[ImportePEN.Name].Value
                                    , (decimal)item.Cells[xtc.Name].Value, (decimal)item.Cells[xredondeo.Name].Value, (decimal)item.Cells[xdiferencia.Name].Value, "", cbobanco.SelectedValue.ToString(), NroCuenta, dtpFechaPago.Value, frmLogin.CodigoUsuario, (int)cboempresa.SelectedValue, idcomprobante);
                            }
                        }
                    }
                    DataRow FilaDato = (CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, dtpFechaContable.Value)).Rows[0];
                    int codigo = (int)FilaDato["codigo"];
                    string cuo = FilaDato["cuo"].ToString();
                    int idCta = (int)((DataTable)cbocuentabanco.DataSource).Rows[cbocuentabanco.SelectedIndex]["idtipocta"];
                    string CuentaContableBanco = cbocuentabanco.SelectedValue.ToString();
                    string CuentaDetracciones = txtcuentadetracciones.Text;
                    ///DINAMICA DEL PROCESO DE PAGO CABECERA                   
                    CapaLogica.PagarDetracionesVentaCabecera(codigo, cuo, decimal.Parse(txttotal.Text), decimal.Parse(txtredondeo.Text), decimal.Parse(txtdiferencia.Text), NroBoleta, CuentaDetracciones, CuentaContableBanco, "9559501", dtpFechaContable.Value, txtglosa.Text, (int)cboempresa.SelectedValue, dtpFechaPago.Value, idcomprobante);
                    ///DINAMICA DEL PROCESO DE PAGO DETALLE
                    foreach (DataGridViewRow item in dtgconten.Rows)
                        if ((int)item.Cells[opcionx.Name].Value == 1)
                            if ((decimal)item.Cells[ImportePEN.Name].Value != 0)
                            {//si el valor a pagar es superior a cero
                                NroBoleta = item.Cells[nrofacturax.Name].Value.ToString();
                                string[] fac = NroBoleta.Split('-');
                                string codfac = fac[0];
                                string numfac = fac[1];
                                Idcliente = item.Cells[Clientex.Name].Value.ToString();
                                idcomprobante = (int)item.Cells[xtipocomprobante.Name].Value;
                                CapaLogica.PagarDetracionesVentaDetalle(codigo, (int)item.Cells[tipoidx.Name].Value, item.Cells[Clientex.Name].Value.ToString(), item.Cells[razonx.Name].Value.ToString()
                                , (int)item.Cells[xtipocomprobante.Name].Value, codfac, numfac, NroBoleta, (decimal)item.Cells[xredondeo.Name].Value, (decimal)item.Cells[ImportePEN.Name].Value, (decimal)item.Cells[xdiferencia.Name].Value
                                //item.Cells[monedax.Name].Value.ToString() == "1" ? (decimal)item.Cells[ImportePEN.Name].Value / (decimal)item.Cells[xtc.Name].Value : (decimal)item.Cells[ImportePEN.Name].Value
                                , (decimal)item.Cells[xtc.Name].Value, CuentaDetracciones, CuentaContableBanco, idCta, dtpFechaContable.Value, decimal.Parse(txtdiferencia.Text) < 0 ? "9559501" : "7599103", txtglosa.Text, frmLogin.CodigoUsuario, (int)cboempresa.SelectedValue);

                            }
                    ////FIN DE LA DINAMICA DE LA CABECERA
                    HPResergerFunciones.Utilitarios.msg($"Detracciones Pagadas! \nCon Asiento {cuo}");
                    btnActualizar_Click(sender, e);
                    txttotal.Text = txtdiferencia.Text = txtredondeo.Text = "0.00";

                }
                else HPResergerFunciones.Utilitarios.msg("Total de Detracciones en Cero");
            }
            else HPResergerFunciones.Utilitarios.msg("No Hay Detracciones por Pagar");
        }
        public void BuscarCuentaDetracicones()
        {
            string consulta = txtcuentadetracciones.TextValido();
            DataTable Tcuenta = CapaLogica.BuscarCuentas(consulta, 3);
            string cadena = "";
            if (Tcuenta.Rows.Count > 0)
            {
                cadena = Tcuenta.Rows[0]["cuenta_contable"].ToString();
            }
            txtDescCuenta.Text = cadena;
        }
        private void txtcuentadetracciones_TextChanged(object sender, EventArgs e)
        {
            BuscarCuentaDetracicones();
        }
        TextBox txt;
        private void dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int x = dtgconten.CurrentRow.Index, y = dtgconten.CurrentCell.ColumnIndex;
            if (y == dtgconten.Columns[xredondeo.Name].Index)
            {
                txt = e.Control as TextBox;
                txt.KeyPress -= Txt_KeyPress;
                txt.KeyDown -= Txt_KeyDown;
                txt.KeyPress += Txt_KeyPress;
                txt.KeyDown += Txt_KeyDown;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CargarDAtos();
        }
        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txt, 10);
        }
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }
    }
}
