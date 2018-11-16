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

namespace HPReserger.ModuloBancario
{
    public partial class frmTiposdeCuentasBancarias : FormGradient
    {
        public frmTiposdeCuentasBancarias()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmTiposdeCuentasBancarias_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarDatos();
            ModoEdicion(false);
        }
        public void ModoEdicion(Boolean a)
        {
            cbobanco.Enabled = a;
            cboempresa.Enabled = a;
            cbomoneda.Enabled = a;
            cbotipocuenta.Enabled = a;
            txtnrocci.ReadOnly = !a;
            txtnrocuenta.ReadOnly = !a;
            dtgconten.Enabled = !a;
        }
        public void CargarCombos()
        {
            CargarEmpresa();
            CargarMoneda();
            CargarEntidades();
            CargarTiposCuentas();
        }
        public void CargarEmpresa()
        {
            CapaLogica.Empresas(cboempresa);
        }
        public void CargarMoneda()
        {
            CapaLogica.Monedas(cbomoneda);
        }
        public void CargarTiposCuentas()
        {
            CapaLogica.TipoCuentas(cbotipocuenta);
        }
        public void CargarEntidades()
        {
            CapaLogica.EntidadesFinancieras(cbobanco);
        }
        private void cboempresa_Click(object sender, EventArgs e)
        {
            string cadena = cboempresa.Text; CargarEmpresa(); cboempresa.Text = cadena;
        }
        private void cbomoneda_Click(object sender, EventArgs e)
        {
            string cadena = cbomoneda.Text; CargarMoneda(); cbomoneda.Text = cadena;
        }
        private void cbobanco_Click(object sender, EventArgs e)
        {
            string cadena = cbobanco.Text; CargarEntidades(); cbobanco.Text = cadena;
        }
        private void cbotipocuenta_Click(object sender, EventArgs e)
        {
            string cadena = cbotipocuenta.Text; CargarTiposCuentas(); cbotipocuenta.Text = cadena;
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CapaLogica.CuentaBancaria();
            lblmsg.Text = $"Total de Registros : {dtgconten.RowCount}";
            if (dtgconten.RowCount > 0) btnmodificar.Enabled = true; else btnmodificar.Enabled = false;
        }
        int estado = 0;
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (Estado == 0)
            {
                this.Close();
            }
            else Estado = 0;
            BloquearControles(false); ModoEdicion(false);
            btnaceptar.Enabled = false;
            CargarDatos();
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                DataGridViewRow item = dtgconten.Rows[x];
                cboempresa.SelectedValue = item.Cells[xideempresa.Name].Value;
                cbomoneda.SelectedValue = item.Cells[xidmoneda.Name].Value;
                cbotipocuenta.SelectedValue = item.Cells[xtipo.Name].Value;
                cbobanco.SelectedValue = item.Cells[xidbanco.Name].Value;
                txtnrocuenta.Text = item.Cells[xNro_Cta.Name].Value.ToString();
                txtnrocci.Text = item.Cells[xNro_Cta_Cci.Name].Value.ToString();
            }
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            btnaceptar.Enabled = true;
            ModoEdicion(true);
            txtnrocci.CargarTextoporDefecto(); txtnrocuenta.CargarTextoporDefecto();
            BloquearControles(true);
        }

        int _idcuenta = 0;
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2;
            ModoEdicion(true);
            btnaceptar.Enabled = true;
            BloquearControles(true);
            _idcuenta = (int)dtgconten[xId_Tipo_Cta.Name, dtgconten.CurrentRow.Index].Value;
        }
        public void BloquearControles(Boolean a)
        {
            btnnuevo.Enabled = !a;
            btnmodificar.Enabled = !a;
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (!txtnrocuenta.EstaLLeno()) { txtnrocuenta.Focus(); msg("Ingrese Nro de Cuenta"); return; }
            if (cbobanco.SelectedIndex < 0) { cbobanco.Focus(); msg("Seleccione Banco"); return; }
            if (cboempresa.SelectedIndex < 0) { cboempresa.Focus(); msg("Seleccione Banco"); return; }
            if (cbomoneda.SelectedIndex < 0) { cbomoneda.Focus(); msg("Seleccione Moneda"); return; }
            if (cbotipocuenta.SelectedIndex < 0) { cbotipocuenta.Focus(); msg("Seleccione Tipo Cuenta"); return; }
            if (estado == 1)
            {
                /////validar si ya existe
                DataTable Tdatos = CapaLogica.CuentaBancaria(5, 0, (int)cboempresa.SelectedValue, (int)cbobanco.SelectedValue, (int)cbomoneda.SelectedValue, (int)cbotipocuenta.SelectedValue, txtnrocuenta.TextValido(), txtnrocci.TextValido(), frmLogin.CodigoUsuario);
                if (Tdatos.Rows.Count > 0)
                {
                    txtnrocuenta.Focus();
                    msg("Número de Cuenta YA Existe");
                    return;
                }
                /////insertando el registro
                CapaLogica.CuentaBancaria(1, 0, (int)cboempresa.SelectedValue, (int)cbobanco.SelectedValue, (int)cbomoneda.SelectedValue, (int)cbotipocuenta.SelectedValue, txtnrocuenta.TextValido(), txtnrocci.TextValido(), frmLogin.CodigoUsuario);
                msg("Número de Cuenta Agregado");
            }
            if (estado == 2)
            {
                ///validar si no se duplicar
                DataTable Tdatos = CapaLogica.CuentaBancaria(6, _idcuenta, (int)cboempresa.SelectedValue, (int)cbobanco.SelectedValue, (int)cbomoneda.SelectedValue, (int)cbotipocuenta.SelectedValue, txtnrocuenta.TextValido(), txtnrocci.TextValido(), frmLogin.CodigoUsuario);
                if (Tdatos.Rows.Count > 0)
                {
                    txtnrocuenta.Focus();
                    msg("Número de Cuenta YA Existe");
                    return;
                }
                CapaLogica.CuentaBancaria(2, _idcuenta, (int)cboempresa.SelectedValue, (int)cbobanco.SelectedValue, (int)cbomoneda.SelectedValue, (int)cbotipocuenta.SelectedValue, txtnrocuenta.TextValido(), txtnrocci.TextValido(), frmLogin.CodigoUsuario);
                msg("Número de Cuenta Actualizado");
            }
            estado = 0;
            ModoEdicion(false);
            BloquearControles(false);
            btnaceptar.Enabled = false;
            CargarDatos();
        }

    }
}
