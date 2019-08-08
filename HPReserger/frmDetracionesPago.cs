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
    public partial class frmDetracionesPago : FormGradient
    {
        public frmDetracionesPago()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmDetracionesPago_Load(object sender, EventArgs e)
        {
            DataRow Filita = CapaLogica.VerUltimoIdentificador("TBL_Factura", "Nro_DocPago");
            if (Filita != null)
                txtnropago.Text = (decimal.Parse(Filita["ultimo"].ToString()) + 1).ToString();
            else txtnropago.Text = "1";
            CargarTiposID("TBL_Tipo_ID");
            cargarempresas();
            cbotipo.SelectedIndex = 0;
            Detracion = new List<Detracciones>();
            CargarDAtos();
            dtpFechaPago.Value = dtpFechaContable.Value = DateTime.Now;
            txtcuentadetracciones_TextChanged(sender, e);
            txtglosa.CargarTextoporDefecto();
            txtcuentaredondeo.CargarTextoporDefecto();
        }
        public void cargarempresas()
        {
            CapaLogica.TablaEmpresas(cboempresa);
        }
        //DataTable TablaTipoID;
        public void CargarTiposID(string tabla)
        {
            //TablaTipoID = new DataTable();
            //TablaTipoID = CapaLogica.CualquierTabla(tabla, "Desc_Tipo_ID", "RUC");
            //cbotipoid.DisplayMember = "Desc_Tipo_ID";
            //cbotipoid.ValueMember = "Codigo_Tipo_ID";
            //cbotipoid.DataSource = TablaTipoID;
        }
        public void CalcularValoresRedondeoyDiferencia()
        {
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                item.Cells[xRedondeo.Name].Value = Math.Round((decimal)item.Cells[porpagarx.Name].Value);
                //  item.Cells[xDiferencia.Name].Value = (decimal)item.Cells[porpagarx.Name].Value - (decimal)item.Cells[xRedondeo.Name].Value;
            }
        }
        public void CargarDAtos()
        {
            dtgconten.DataSource = CapaLogica.DetraccionesPorPAgar((int)cboempresa.SelectedValue);
            NumRegistrosdtg();
            SeleccionarDetracionesSeleccionadas();
            CalcularValoresRedondeoyDiferencia();
        }
        public void SeleccionarDetracionesSeleccionadas()
        {
            if (Detracion != null)
                foreach (DataGridViewRow item in dtgconten.Rows)
                {
                    foreach (Detracciones det in Detracion)
                    {
                        if (item.Cells[nrofacturax.Name].Value.ToString() == det._nrodetracion && item.Cells[Proveedorx.Name].Value.ToString() == det._proveedor && det._idcomprobante == (int)item.Cells[xidcomprobante.Name].Value)
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
        decimal sumatoria = 1000, sumadif = 0, sumaTotal = 0;
        public class Detracciones
        {
            public string _nrodetracion;
            public string _proveedor;
            public decimal _monto;
            public int _idcomprobante;
            public Detracciones(string nrofactura, string proveedor, decimal monto, int idcomprobantes)
            {
                _nrodetracion = nrofactura;
                _proveedor = proveedor;
                _monto = monto;
                _idcomprobante = idcomprobantes;
            }
        }
        List<Detracciones> Detracion;
        public void CalcularTotal()
        {
            sumatoria = 0; sumadif = 0; sumaTotal = 0;
            int Seleccionados = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if ((int)item.Cells[opcionx.Name].Value == 1)
                //Valores Seleccionados
                {
                    sumatoria += decimal.Parse(item.Cells[xRedondeo.Name].Value.ToString());
                    sumaTotal += decimal.Parse(item.Cells[porpagarx.Name].Value.ToString());
                    sumadif += decimal.Parse(item.Cells[xDiferencia.Name].Value.ToString());
                    Seleccionados++;
                }
            }
            txttotal.Text = sumatoria.ToString("n2");
            txtdiferencia.Text = sumadif.ToString("n2");
            txtredondeo.Text = sumaTotal.ToString("n2");
            if (Seleccionados > 0) btnaceptar.Enabled = true;
            else btnaceptar.Enabled = false;
        }
        public Boolean VerificarErrorDiferencia()
        {
            Boolean Prueba = true;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if ((int)item.Cells[opcionx.Name].Value == 1)
                {
                    if (Math.Abs((decimal)item.Cells[xDiferencia.Name].Value) >= 1)
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xRedondeo.Name]);
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xDiferencia.Name]);
                        Prueba = false;
                    }
                    else
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xRedondeo.Name]);
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xDiferencia.Name]);
                    }
                }
                else
                {
                    HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xRedondeo.Name]);
                    HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xDiferencia.Name]);
                }
            }
            if (!Prueba)
            {
                msg("El Redondeo no puede Superar a : S/ 1");
            }
            return Prueba;
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
        }
        private void dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (dtgconten.RowCount > 0)
            {
                if (y == dtgconten.Columns[xRedondeo.Name].Index)
                {
                    /////si el valor de la detracciones es menor que 1 sol
                    if ((decimal)dtgconten[xRedondeo.Name, x].Value < 1)
                        dtgconten[xRedondeo.Name, x].Value = 1;
                    dtgconten[xDiferencia.Name, x].Value = (decimal)dtgconten[porpagarx.Name, x].Value - (decimal)dtgconten[xRedondeo.Name, x].Value;
                }
                //if ((decimal)dtgconten[porpagarx.Name, x].Value > (decimal)dtgconten[Detraccionx.Name, x].Value)
                //{
                //    dtgconten[porpagarx.Name, x].Value = (decimal)dtgconten[Detraccionx.Name, x].Value;
                //}
                CalcularTotal();
            }
        }
        TextBox txt;
        private void dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int x = dtgconten.CurrentRow.Index, y = dtgconten.CurrentCell.ColumnIndex;
            if (y == dtgconten.Columns[xRedondeo.Name].Index)
            {
                txt = e.Control as TextBox;
                txt.KeyPress -= Txt_KeyPress;
                txt.KeyDown -= Txt_KeyDown;
                txt.KeyPress += Txt_KeyPress;
                txt.KeyDown += Txt_KeyDown;
            }
        }
        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txt, 10);
        }
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
                    if (decimal.Parse(txtdiferencia.Text) > 0)
                        if (!txtDescCuenta.EstaLLeno()) { txtcuentaredondeo.Focus(); msg("Ingresé Cuenta de Redondeo"); return; }
                    Boolean Verificar = false;
                    //validar que no se pague valores en cero
                    foreach (DataGridViewRow item in dtgconten.Rows)
                    {
                        if ((int)item.Cells[opcionx.Name].Value == 1)
                        {
                            if ((decimal)item.Cells[xRedondeo.Name].Value == 0)
                            {
                                Verificar = true;
                                HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[porpagarx.Name]);
                            }
                            else
                                HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[porpagarx.Name]);
                        }
                    }
                    if (!VerificarErrorDiferencia()) return;
                    if (Verificar) { HPResergerFunciones.Utilitarios.msg("No se Puede Pagar Valores en Cero"); return; }
                    ///DECLARACION DE LAS VARIABLES
                    DateTime FechaPago = dtpFechaPago.Value;
                    DateTime FechaContable = dtpFechaContable.Value;
                    int IdEmpresa = (int)cboempresa.SelectedValue;
                    DataRow FilaDato = (CapaLogica.UltimoAsiento(IdEmpresa, FechaContable)).Rows[0];
                    int codigo = (int)FilaDato["codigo"];
                    string CuoPago = FilaDato["cuo"].ToString();
                    int idCta = (int)((DataTable)cbocuentabanco.DataSource).Rows[cbocuentabanco.SelectedIndex]["idtipocta"];
                    int IdUsuario = frmLogin.CodigoUsuario;
                    string glosa = txtglosa.TextValido();
                    ///FIN DECLARACION DE VARIABLES
                    //PROCESO DE PAGO
                    string nrofac = "", ruc = "";
                    int idcomprobante = 0;
                    int posSelec = cbocuentabanco.SelectedIndex;
                    string NroCuenta = ((DataTable)cbocuentabanco.DataSource).Rows[posSelec]["NroCta"].ToString();
                    foreach (DataGridViewRow item in dtgconten.Rows)
                    {
                        if ((int)item.Cells[opcionx.Name].Value == 1)
                        {
                            //si el valor a pagar es superior a cero
                            if ((decimal)item.Cells[xRedondeo.Name].Value != 0)
                            {
                                nrofac = item.Cells[nrofacturax.Name].Value.ToString();
                                ruc = item.Cells[Proveedorx.Name].Value.ToString();
                                idcomprobante = (int)item.Cells[xidcomprobante.Name].Value;
                                CapaLogica.Detracciones(1, item.Cells[nrofacturax.Name].Value.ToString(), item.Cells[Proveedorx.Name].Value.ToString(), (decimal)item.Cells[Detraccionx.Name].Value
                                    , (decimal)item.Cells[porpagarx.Name].Value, (decimal)item.Cells[xtc.Name].Value, (decimal)item.Cells[xRedondeo.Name].Value, (decimal)item.Cells[xDiferencia.Name].Value, ""
                                    , cbobanco.SelectedValue.ToString(), NroCuenta, FechaPago, IdUsuario, (int)item.Cells[xidcomprobante.Name].Value, IdEmpresa, CuoPago);
                            }
                        }
                    }
                    ///DINAMICA DEL PROCESO DE PAGO CABECERA                   
                    CapaLogica.PagarDetracionesCabecera(codigo, CuoPago, IdEmpresa, decimal.Parse(txttotal.Text), decimal.Parse(txtredondeo.Text), decimal.Parse(txtdiferencia.Text), ruc, nrofac
                        , cbocuentabanco.SelectedValue.ToString(), txtcuentaredondeo.Text, FechaPago, FechaContable, glosa, idcomprobante);
                    ///DINAMICA DEL PROCESO DE PAGO DETALLE
                    foreach (DataGridViewRow item in dtgconten.Rows)
                        if ((int)item.Cells[opcionx.Name].Value == 1)
                            if ((decimal)item.Cells[xRedondeo.Name].Value != 0)
                            {//si el valor a pagar es superior a cero
                                nrofac = item.Cells[nrofacturax.Name].Value.ToString();
                                string[] fac = nrofac.Split('-');
                                string codfac = fac[0]; string numfac = fac[1];
                                ruc = item.Cells[Proveedorx.Name].Value.ToString();
                                idcomprobante = (int)item.Cells[xidcomprobante.Name].Value;
                                CapaLogica.PagarDetracionesDetalle(codigo, CuoPago, IdEmpresa, (decimal)item.Cells[porpagarx.Name].Value, (decimal)item.Cells[xRedondeo.Name].Value, (decimal)item.Cells[xDiferencia.Name].Value
                                    , ruc, codfac, numfac, (decimal)item.Cells[xtotal.Name].Value, (decimal)item.Cells[xtc.Name].Value, idCta, cbocuentabanco.SelectedValue.ToString(),
                                   decimal.Parse(txtdiferencia.Text) < 0 ? "9559501" : "7599103", FechaContable, glosa, IdUsuario, idcomprobante);
                            }
                    ////FIN DE LA DINAMICA DE LA CABECERA                
                    HPResergerFunciones.Utilitarios.msg($"Detracciones Pagadas! con Asiento {CuoPago}");
                    btnActualizar_Click(sender, e);
                }
                else HPResergerFunciones.Utilitarios.msg("Total de Detracciones en Cero");
            }
            else HPResergerFunciones.Utilitarios.msg("No Hay Detracciones por Pagar");
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Detracion.Clear();
            foreach (DataGridViewRow item in dtgconten.Rows)
                if ((int)item.Cells[opcionx.Name].Value == 1)
                    Detracion.Add(new Detracciones(item.Cells[nrofacturax.Name].Value.ToString(), item.Cells[Proveedorx.Name].Value.ToString(), (decimal)item.Cells[porpagarx.Name].Value, (int)item.Cells[xidcomprobante.Name].Value));
            CargarDAtos();
        }
        private void dtgconten_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (dtgconten[nrodetraccionesx.Name, x].Value.ToString() == "" || dtgconten[nrodetraccionesx.Name, x].Value.ToString() == "0")
            {
                dtgconten.Rows[x].DefaultCellStyle.ForeColor = Configuraciones.RojoUI;
                dtgconten.Rows[x].DefaultCellStyle.SelectionBackColor = Configuraciones.RojoUISelect;
            }
            else
            {
                dtgconten.Rows[x].DefaultCellStyle.ForeColor = Configuraciones.OscuroUISelect;
                dtgconten.Rows[x].DefaultCellStyle.SelectionBackColor = Configuraciones.AzulUISelect;
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
        public void CargarCuentasBancos()
        {
            if (cboempresa.SelectedValue != null && cbobanco.SelectedValue != null)
            {
                cbocuentabanco.ValueMember = "Id_Cuenta_Contable";
                cbocuentabanco.DisplayMember = "banco";
                cbocuentabanco.DataSource = CapaLogica.ListarBancosTiposdePagoxEmpresa(cbobanco.SelectedValue.ToString(), (int)cboempresa.SelectedValue, 0);
            }
        }
        private void cbobanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbobanco.SelectedIndex >= 0)
            {
                cbocuentabanco.Text = "";
                CargarCuentasBancos();
            }
        }
        private string _NameEmpresa;
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
            if (cboempresa.Items.Count != CapaLogica.TablaEmpresa().Rows.Count)
            {
                CapaLogica.TablaEmpresa(cboempresa);
                cboempresa.Text = cadena;
            }
        }
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbobanco.SelectedValue != null)
            {
                CargarCuentasBancos();
                NameEmpresa = cboempresa.Text;
                CargarDAtos();
            }
        }
        public void BuscarCuentaDetracicones()
        {
            string consulta = txtcuentaredondeo.TextValido();
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

        private void dtgconten_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
