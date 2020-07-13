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
    public partial class frmConfigurarAsientosBoletas : FormGradient
    {
        public frmConfigurarAsientosBoletas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private bool Cargado;

        private void frmConfigurarAsientosBoletas_Load(object sender, EventArgs e)
        {
            Estado = 0;
            CargarValorexDefecto();
            ModoEdicion(false);
            Cargado = true;
            CargarDAtos();
        }

        private void ModoEdicion(bool v)
        {
            txtcuenta.ReadOnly = txtglosa.ReadOnly = !v;
            dtgconten.Enabled = !v;
            btnbuscar.Enabled = chkFecha.Enabled = v;
            cbodebe.ReadOnly = !v;
            btnmodificar.Enabled = !v;
        }

        private void CargarValorexDefecto()
        {
            txtcuenta.CargarTextoporDefecto();
            txtdescripcion.CargarTextoporDefecto();
            txtglosa.CargarTextoporDefecto();
        }

        DataTable Tdatos;
        private int Estado;
        private int pkid;

        public void CargarDAtos()
        {
            if (Cargado)
            {
                Tdatos = CapaLogica.ConfigurarAsientoBoletas();
                dtgconten.DataSource = Tdatos;
                lblmsg.Text = $"Total de Registros: {dtgconten.RowCount}";
                if (dtgconten.RowCount > 0) btnmodificar.Enabled = false;
                if (dtgconten.RowCount > 0) btnmodificar.Enabled = true;
            }
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Cargado)
                {
                    int x = e.RowIndex;
                    DataGridViewRow Fila = dtgconten.Rows[x];
                    txtcuenta.Text = Fila.Cells[xcuenta.Name].Value.ToString();
                    txtglosa.Text = Fila.Cells[xGlosa.Name].Value.ToString();
                    cbodebe.Text = Fila.Cells[xDebeHaber.Name].Value.ToString();
                    txtdescripcion.Text = Fila.Cells[xDescripcion.Name].Value.ToString();
                    chkFecha.Checked = (Boolean)Fila.Cells[xIncluirFechas.Name].Value;
                }
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Estado = 2;
            ModoEdicion(true);
            pkid = (int)dtgconten[xpkid.Index, dtgconten.CurrentCell.RowIndex].Value;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (Estado != 0)
            {
                Estado = 0;
                ModoEdicion(false);
                CargarDAtos();
            }
            else this.Close();
        }
        public void msgOk(string cadena) { HPResergerFunciones.Utilitarios.msg(cadena); }
        public void msgError(string cadena) { HPResergerFunciones.Utilitarios.msgCancel(cadena); }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (Configuraciones.ValidarSQLInyect(txtglosa, txtcuenta)) { msgError("Codigo Malicioso Detectado"); return; }
            if (!(cbodebe.Text == "D" || cbodebe.Text == "H")) { msgError("Valor Admitido solo: D o H"); return; }
            if (!txtdescripcion.EstaLLeno()) { msgError("Debe Ingresar una Cuenta contable Valida"); return; }
            if (!txtcuenta.EstaLLeno()) { msgError("Ingrese una Cuenta Contable"); return; }
            //Proceso de modificacion
            if (Estado == 2)
            {
                CapaLogica.ConfigurarAsientoBoletas(2, pkid, txtcuenta.TextValido(), cbodebe.Text, chkFecha.Checked, txtglosa.TextValido());
                msgOk("Modificado con Exito");
                ModoEdicion(false);
                Estado = 0;
                Cargado = true;
                CargarDAtos();
            }
        }

        private void txtcuenta_TextChanged(object sender, EventArgs e)
        {
            if (txtcuenta.EstaLLeno() && Estado != 0)
            {
                DataTable TablaAux = CapaLogica.BuscarCuentas(txtcuenta.Text, 1);
                if (TablaAux.Rows.Count > 0)
                {
                    txtdescripcion.Text = TablaAux.Rows[0]["Cuenta_Contable"].ToString();
                }
                else txtdescripcion.Text = "";
            }
            else txtdescripcion.Text = "";
        }

        private void txtcuenta_DoubleClick(object sender, EventArgs e)
        {
            BuscarCuenta();
        }

        private void BuscarCuenta()
        {
            if (Estado != 0)
            {
                frmlistarcuentas cuentitas = new frmlistarcuentas();
                cuentitas.Icon = Icon;
                cuentitas.Txtbusca.Text = txtcuenta.TextValido();
                cuentitas.radioButton1.Checked = true;
                cuentitas.ShowDialog();
                if (cuentitas.aceptar) txtcuenta.Text = cuentitas.codigo;
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarCuenta();
        }
    }
}
