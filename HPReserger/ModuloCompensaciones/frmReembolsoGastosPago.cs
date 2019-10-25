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

namespace HPReserger.ModuloCompensaciones
{
    public partial class frmReembolsoGastosPago : FormGradient
    {
        public frmReembolsoGastosPago()
        {
            InitializeComponent();
        }
        public void CargarMoneda() { CapaLogica.TablaMoneda(cbomoneda); }
        public void CargarEmpresa() { CapaLogica.TablaEmpresa(cboempresa); }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private int _idempresa;

        public int Estado { get; private set; }
        public string NameEmpresa { get; private set; }
        public bool Cargado { get; private set; }

        private void frmReembolsoGastosPago_Load(object sender, EventArgs e)
        {
            Cargado = false;
            txtglosa.CargarTextoporDefecto();
            txtnrocheque.CargarTextoporDefecto();
            dtpFechaContable.Value = dtpFechaCompensa.Value = DateTime.Now;
            Estado = 0;
            //ModoEdicion(false);
            CargarMoneda();
            btnaceptar.Enabled = false;
            //cbopago.SelectedIndex = 0;
            CargarEmpresa();
            Cargado = true;
        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void cbobanco_Click(object sender, EventArgs e)
        {
            string cadenar = cbobanco.Text;
            DataTable TableBancos = CapaLogica.TablaBanco();
            if (TableBancos.Rows.Count != cbobanco.Items.Count)
            {
                cbobanco.ValueMember = "sufijo";
                cbobanco.DisplayMember = "descripcion";
                cbobanco.DataSource = TableBancos;
                cbobanco.Text = cadenar;
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
        public void CargarCuentasBancos()
        {
            if (cboempresa.SelectedValue != null && cbobanco.SelectedValue != null)
            {
                cbocuentabanco.ValueMember = "Id_Cuenta_Contable";
                cbocuentabanco.DisplayMember = "banco";
                cbocuentabanco.DataSource = CapaLogica.ListarBancosTiposdePagoxEmpresa(cbobanco.SelectedValue.ToString(), (int)cboempresa.SelectedValue, (int)cbomoneda.SelectedValue);
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (cbobanco.SelectedValue == null)
            {
                msg("Seleccione el Banco");
                cbobanco.Focus(); return;
            }
            if (cbopago.SelectedIndex < 0)
            {
                msg("Seleccione el Pago");
                cbopago.Focus(); return;
            }
            if (cbocuentabanco.SelectedValue == null)
            {
                msg("Seleccione la cuenta del Abono");
                cbocuentabanco.Focus(); return;
            }
        }
        private void cboempresa_SelectedValueChanged(object sender, EventArgs e)
        {
            cboempleado.DisplayMember = "empleado";
            cboempleado.ValueMember = "UsuarioCompensacion";
            NameEmpresa = cboempresa.Text;
            if (cboempresa.Items.Count > 0)
            {
                if (cboempresa.SelectedValue != null)
                {
                    cboproyecto.DataSource = CapaLogica.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString());
                    cboproyecto.DisplayMember = "proyecto";
                    cboproyecto.ValueMember = "id_proyecto";
                    //busqueda de Asientos
                    _idempresa = (int)cboempresa.SelectedValue;
                    BuscarEmpleadoCompensaciones();
                }
            }
        }

        private void BuscarEmpleadoCompensaciones()
        {
            if (cboempresa.SelectedValue != null)
            {
                cboempleado.DataSource = CapaLogica.ReembolsoGastos_Detalle((int)cboempresa.SelectedValue);
                if (cboempleado.Items.Count == 0)
                    if (Dtgconten.DataSource != null)
                    {
                        Dtgconten.DataSource = ((DataTable)Dtgconten.DataSource).Clone();
                        //btnaceptar.Enabled = false;
                        ContarRegistros();
                    }
            }
        }
        public void ContarRegistros()
        {
            lbltotalregistros.Text = $"Total de Registros: {Dtgconten.RowCount}";
        }
        private void cbobanco_Click_1(object sender, EventArgs e)
        {
            string cadenar = cbobanco.Text;
            DataTable TableBancos = CapaLogica.TablaBanco();
            if (TableBancos.Rows.Count != cbobanco.Items.Count)
            {
                cbobanco.ValueMember = "sufijo";
                cbobanco.DisplayMember = "descripcion";
                cbobanco.DataSource = TableBancos;
                cbobanco.Text = cadenar;
            }
        }

        private void cboempleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboempleado.SelectedValue != null)
            {
                DataTable Table = CapaLogica.ReembolsoGastos_Detalle(cboempleado.SelectedValue.ToString(), (int)cboempresa.SelectedValue);
                Dtgconten.DataSource = Table;
                btnaceptar.Enabled = false;
                txttotalME.Text = txttotaldifME.Text = txttotalMN.Text = txttotaldifMN.Text = "0.00";
            }
            ContarRegistros();
            //PasarTipoOracion(xrazon_social);
        }
        public void CalcularTotal()
        {
            int conta = 0;
            btnaceptar.Enabled = false;
            cboempleado.Enabled = cboproyecto.Enabled = cboempresa.Enabled = true;
            txttotalME.Text = txttotaldifME.Text = txttotalMN.Text = txttotaldifMN.Text = "0.00";
            txtTotalPagar.Text = "0.00";
            if (Cargado)
            {
                if (cbomoneda.SelectedValue != null)
                {
                    int mon = (int)cbomoneda.SelectedValue;
                    decimal sumatoriaMN = 0, diferenciaMN = 0;
                    decimal sumatoriaME = 0, diferenciaME = 0;
                    foreach (DataGridViewRow item in Dtgconten.Rows)
                    {
                        //si esta seleccionado
                        if ((int)item.Cells[xok.Name].Value == 1)
                        {
                            conta++;
                            sumatoriaMN += (decimal)item.Cells[xmontomn.Name].Value;
                            sumatoriaME += (decimal)item.Cells[xmontome.Name].Value;
                        }
                    }
                    txttotalMN.Text = sumatoriaMN.ToString("n2");
                    txttotaldifMN.Text = diferenciaMN.ToString("n2");
                    txttotalME.Text = sumatoriaME.ToString("n2");
                    txttotaldifME.Text = diferenciaME.ToString("n2");
                }
                ContarRegistros(); lbltotalregistros.Text += $" Total Selecionados {conta}";
                if (conta > 0)
                {
                    btnaceptar.Enabled = true;
                    cboempleado.Enabled = cboproyecto.Enabled = cboempresa.Enabled = false;
                }
            }
        }
        private void Dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalcularTotal();
        }

        private void Dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cargado = false;
            int x = e.RowIndex;
            if (x >= 0 && Dtgconten.Columns[xVer.Name].Index != e.ColumnIndex)
            {
                Dtgconten[xok.Name, x].Value = ((int)Dtgconten[xok.Name, x].Value) == 1 ? 0 : 1;
            }
            else if (e.ColumnIndex == Dtgconten.Columns[xok.Name].Index && e.ColumnIndex == 0)
            {
                if (Dtgconten.RowCount > 0)
                {
                    int valor = (int)Dtgconten[xok.Name, 0].Value;
                    foreach (DataGridViewRow item in Dtgconten.Rows)
                    {
                        item.Cells[xok.Name].Value = valor == 1 ? 0 : 1;
                    }
                }
            }
            Dtgconten.EndEdit(); Dtgconten.RefreshEdit();
            Cargado = true;
            CalcularTotal();
        }
    }
}
