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
        public void CargarDAtos()
        {
            dtgconten.DataSource = CapaLogica.DetraccionesPorPAgar((int)cboempresa.SelectedValue);
            NumRegistrosdtg();
            SeleccionarDetracionesSeleccionadas();
        }
        public void SeleccionarDetracionesSeleccionadas()
        {
            if (Detracion != null)
                foreach (DataGridViewRow item in dtgconten.Rows)
                {
                    foreach (Detracciones det in Detracion)
                    {
                        if (item.Cells[nrofacturax.Name].Value.ToString() == det._nrodetracion && item.Cells[Proveedorx.Name].Value.ToString() == det._proveedor)
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
            public Detracciones(string nrofactura, string proveedor, decimal monto)
            {
                _nrodetracion = nrofactura;
                _proveedor = proveedor;
                _monto = monto;
            }
        }
        List<Detracciones> Detracion;
        public void CalcularTotal()
        {
            sumatoria = 0;
            int Seleccionados = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if ((int)item.Cells[opcionx.Name].Value == 1)
                //Valores Seleccionados
                {
                    sumatoria += (decimal)item.Cells[porpagarx.Name].Value;
                    Seleccionados++;
                }
            }
            txttotal.Text = sumatoria.ToString("n2");
            if (Seleccionados > 0) btnaceptar.Enabled = true;
            else btnaceptar.Enabled = false;
        }
        private void dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (dtgconten.RowCount > 0)
            {
                if ((decimal)dtgconten[porpagarx.Name, x].Value > (decimal)dtgconten[Detraccionx.Name, x].Value)
                {
                    dtgconten[porpagarx.Name, x].Value = (decimal)dtgconten[Detraccionx.Name, x].Value;
                }
                CalcularTotal();
            }
        }
        TextBox txt;
        private void dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int x = dtgconten.CurrentRow.Index, y = dtgconten.CurrentCell.ColumnIndex;
            if (y == dtgconten.Columns[porpagarx.Name].Index)
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
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txt);
        }
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimalesX(e, txt.Text);
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
                    Boolean Verificar = false;
                    //validar que no se pague valores en cero
                    foreach (DataGridViewRow item in dtgconten.Rows)
                    {
                        if ((int)item.Cells[opcionx.Name].Value == 1)
                        {
                            if ((decimal)item.Cells[porpagarx.Name].Value == 0)
                            {
                                Verificar = true;
                                HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[porpagarx.Name]);
                            }
                            else
                                HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[porpagarx.Name]);
                        }
                    }
                    if (Verificar) { HPResergerFunciones.Utilitarios.msg("No se Puede Pagar Valores en Cero"); return; }
                    //PROCESO DE PAGO
                    string nrofac = "", ruc = "";
                    foreach (DataGridViewRow item in dtgconten.Rows)
                    {
                        if ((int)item.Cells[opcionx.Name].Value == 1)
                        {
                            //si el valor a pagar es superior a cero
                            if ((decimal)item.Cells[porpagarx.Name].Value != 0)
                            {
                                nrofac = item.Cells[nrofacturax.Name].Value.ToString();
                                ruc = item.Cells[Proveedorx.Name].Value.ToString();
                                CapaLogica.Detracciones(1, item.Cells[nrofacturax.Name].Value.ToString(), item.Cells[Proveedorx.Name].Value.ToString(), (decimal)item.Cells[porpagarx.Name].Value, frmLogin.CodigoUsuario);
                            }
                        }
                    }
                    DataRow FilaDato = (CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, DateTime.Now)).Rows[0];
                    int codigo = (int)FilaDato["codigo"];
                    string cuo = FilaDato["cuo"].ToString();
                    int idCta = (int)((DataTable)cbocuentabanco.DataSource).Rows[cbocuentabanco.SelectedIndex]["idtipocta"];
                    ///DINAMICA DEL PROCESO DE PAGO CABECERA                   
                    CapaLogica.PagarDetracionesCabecera(codigo, cuo, (int)cboempresa.SelectedValue, decimal.Parse(txttotal.Text), ruc, nrofac, cbocuentabanco.SelectedValue.ToString());
                    ///DINAMICA DEL PROCESO DE PAGO DETALLE
                    foreach (DataGridViewRow item in dtgconten.Rows)
                        if ((int)item.Cells[opcionx.Name].Value == 1)
                            if ((decimal)item.Cells[porpagarx.Name].Value != 0)
                            {//si el valor a pagar es superior a cero
                                nrofac = item.Cells[nrofacturax.Name].Value.ToString();
                                string[] fac = nrofac.Split('-');
                                string codfac = fac[0];
                                string numfac = fac[1];
                                ruc = item.Cells[Proveedorx.Name].Value.ToString();
                                CapaLogica.PagarDetracionesDetalle(codigo, cuo, (int)cboempresa.SelectedValue, (decimal)item.Cells[porpagarx.Name].Value, ruc, codfac, numfac, (decimal)item.Cells[xtotal.Name].Value
                                    , idCta, cbocuentabanco.SelectedValue.ToString(), frmLogin.CodigoUsuario);
                            }
                    ////FIN DE LA DINAMICA DE LA CABECERA
                    HPResergerFunciones.Utilitarios.msg($"Detracciones Pagadas! con Asiento {cuo}");
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
                    Detracion.Add(new Detracciones(item.Cells[nrofacturax.Name].Value.ToString(), item.Cells[Proveedorx.Name].Value.ToString(), (decimal)item.Cells[porpagarx.Name].Value));
            CargarDAtos();
        }
        private void dtgconten_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (dtgconten[nrodetraccionesx.Name, x].Value.ToString() == "" || dtgconten[nrodetraccionesx.Name, x].Value.ToString() == "0")
                dtgconten.Rows[x].DefaultCellStyle.ForeColor = Color.FromArgb(192, 80, 77);
            else dtgconten.Rows[x].DefaultCellStyle.ForeColor = Color.Black;
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
            if (cboempresa.SelectedValue != null)
            {
                cbocuentabanco.ValueMember = "Id_Cuenta_Contable";
                cbocuentabanco.DisplayMember = "banco";
                cbocuentabanco.DataSource = CapaLogica.ListarBancosTiposdePagoxEmpresa(cbobanco.SelectedValue.ToString(), (int)cboempresa.SelectedValue);
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
            CapaLogica.TablaEmpresas(cboempresa);
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
        }
    }
}
