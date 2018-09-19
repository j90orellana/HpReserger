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
            //cboempresa.ValueMember = "codigo";
            //cboempresa.DisplayMember = "descripcion";
            //cboempresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
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
            dtgconten.DataSource = CapaLogica.DetraccionesPorPAgar();
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
                    foreach (DataGridViewRow item in dtgconten.Rows)
                    {
                        if ((int)item.Cells[opcionx.Name].Value == 1)
                        {
                            //si el valor a pagar es superior a cero
                            if ((decimal)item.Cells[porpagarx.Name].Value != 0)
                                CapaLogica.Detracciones(1, item.Cells[nrofacturax.Name].Value.ToString(), item.Cells[Proveedorx.Name].Value.ToString(), (decimal)item.Cells[porpagarx.Name].Value, frmLogin.CodigoUsuario);
                        }
                    }
                    ///ESPERANDO LA DINAMICA DEL PROCESO DE PAGO
                    ///
                    HPResergerFunciones.Utilitarios.msg("Detracciones Pagadas!");
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
        private void cbobanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbobanco.SelectedIndex >= 0)
            {
                cbocuentabanco.Text = "";
                cbocuentabanco.ValueMember = "Id_Cuenta_Contable";
                cbocuentabanco.DisplayMember = "banco";
                cbocuentabanco.DataSource = CapaLogica.ListarBancosTiposdePago(cbobanco.SelectedValue.ToString());
            }
        }
    }
}
