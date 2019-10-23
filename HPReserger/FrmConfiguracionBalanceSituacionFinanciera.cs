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
    public partial class FrmConfiguracionBalanceSituacionFinanciera : FormGradient
    {
        public FrmConfiguracionBalanceSituacionFinanciera()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void FrmConfiguracionBalanceSituacionFinanciera_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void CargarDatos()
        {
            Dtgconten.DataSource = CapaLogica.BalanceParametros(0, 0, "", "", "", "", frmLogin.CodigoUsuario);
            Dtgconten.Columns[posix.Name].ReadOnly = Dtgconten.Columns[Codigox.Name].ReadOnly = Dtgconten.Columns[Cuentasx.Name].ReadOnly = Dtgconten.Columns[descripcionx.Name].ReadOnly = true;
            lblmsg2.Text = $"Total de Registros: {Dtgconten.RowCount}";
        }
        private void Dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int y = e.RowIndex;
                txtcodigo.Text = Dtgconten[Codigox.Name, y].Value.ToString();
                txtcuentas.Text = Dtgconten[Cuentasx.Name, y].Value.ToString();
                txtdescripcion.Text = Dtgconten[descripcionx.Name, y].Value.ToString();
                numPos.Value = (int)Dtgconten[posix.Name, y].Value;
                if (estado == 0)
                    btnmodificar.Enabled = true;
                else btnmodificar.Enabled = false;
                string cade = Dtgconten[Codigox.Name, e.RowIndex].Value.ToString();
                if (estado == 2)
                {
                    if (cade.Substring(cade.Length - 2, 2) == "00" || cade.Substring(cade.Length - 2, 2) == "99")
                        Dtgconten[Cuentasx.Name, e.RowIndex].ReadOnly = true;
                    // else
                    // Dtgconten[Cuentasx.Name, e.RowIndex].ReadOnly = false;
                }
            }
        }
        int estado = 0;
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            Activar(btnaceptar);
            Desactivar(Dtgconten, btnnuevo, btnmodificar);
            Desbloquear();
            txtcodigo.Text = txtdescripcion.Text = txtcuentas.Text = "";
        }
        public void Bloquear()
        {
            numPos.ReadOnly = txtcodigo.ReadOnly = txtcuentas.ReadOnly = txtdescripcion.ReadOnly = true;
        }
        public void Desbloquear()
        {
            numPos.ReadOnly = txtcodigo.ReadOnly = txtdescripcion.ReadOnly = false;
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2;
            Activar(btnaceptar, Dtgconten);
            Desactivar(btnnuevo, btnmodificar);
            Bloquear();
            Dtgconten.Columns[posix.Name].ReadOnly = Dtgconten.Columns[Codigox.Name].ReadOnly = Dtgconten.Columns[descripcionx.Name].ReadOnly = false;
            Dtgconten.Columns[Cuentasx.Name].ReadOnly = true;
        }
        public void Activar(params object[] control)
        {
            foreach (object x in control)
            {
                ((Control)x).Enabled = true;
            }
        }
        public void Desactivar(params object[] control)
        {
            foreach (object x in control)
                ((Control)x).Enabled = false;
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado != 0)
            {
                estado = 0;
                CargarDatos();
                Activar(btnnuevo, btnmodificar, Dtgconten);
                Desactivar(btnaceptar);
                Bloquear();
                Dtgconten.Columns[Codigox.Name].ReadOnly = Dtgconten.Columns[Cuentasx.Name].ReadOnly = Dtgconten.Columns[descripcionx.Name].ReadOnly = true;
            }
            else this.Close();
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                CapaLogica.BalanceParametros(1, int.Parse(numPos.Value.ToString()), txtcodigo.Text, txtcodigo.Text, txtdescripcion.Text, txtcuentas.Text, frmLogin.CodigoUsuario);
                HPResergerFunciones.frmInformativo.MostrarDialog("Agregado con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 2)
            {
                Boolean prueba = false;
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    int val = 0;
                    if (!int.TryParse(item.Cells[posix.Name].Value.ToString(), out val))
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[posix.Name]);
                        prueba = true;
                    }
                    else
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[posix.Name]);
                }
                if (prueba) { HPResergerFunciones.frmInformativo.MostrarDialogError("Revise las Celdas"); return; }
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    CapaLogica.BalanceParametros(2, (int)item.Cells[posix.Name].Value, item.Cells[codRealx.Name].Value.ToString(), item.Cells[Codigox.Name].Value.ToString(), item.Cells[descripcionx.Name].Value.ToString(), item.Cells[Cuentasx.Name].Value.ToString(), frmLogin.CodigoUsuario);
                }
                HPResergerFunciones.frmInformativo.MostrarDialog("Modificado con Exito");
                btncancelar_Click(sender, e);
            }
        }       
        private void Dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (estado == 2 && x == Dtgconten.Columns[Cuentasx.Name].Index)
            {
                //mostrar el formulario
                Dtgconten.EndEdit();
                string cadena = Dtgconten[x, y].Value.ToString().Trim();
                FrmListarCuentasParaConfigurar frmliscuentas = new FrmListarCuentasParaConfigurar();
                frmliscuentas.Icon = this.Icon;
                frmliscuentas.Cuentas = cadena;
                if (frmliscuentas.ShowDialog() == DialogResult.OK)
                {
                    Dtgconten[Cuentasx.Name, y].Value = frmliscuentas.Cuentas.Trim();
                    Dtgconten.RefreshEdit();
                }
            }
        }
        private void txtcuentas_DoubleClick(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                FrmListarCuentasParaConfigurar frmliscuentas = new FrmListarCuentasParaConfigurar();
                frmliscuentas.Icon = this.Icon;
                frmliscuentas.Cuentas = "";
                if (frmliscuentas.ShowDialog() == DialogResult.OK)
                {
                    txtcuentas.Text = frmliscuentas.Cuentas;
                }
            }
        }
        private void btndetalle_Click(object sender, EventArgs e)
        {
            if (Dtgconten.RowCount > 0)
            {
                int x = Dtgconten.CurrentCell.RowIndex;
                int y = Dtgconten.CurrentCell.ColumnIndex;
                Dtgconten_CellDoubleClick(sender, new DataGridViewCellEventArgs(y, x));
            }
        }

        private void Dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dtgconten_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            HPResergerFunciones.frmInformativo.MostrarDialogError(e.Exception.Message);
        }
    }
}
