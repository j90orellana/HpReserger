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
    public partial class frmlistarcuentas : Form
    {
        public frmlistarcuentas()
        {
            InitializeComponent();
        }
        public int tipobusca { get; set; }
        public Boolean aceptar { get; set; }
        public string codigo { get; set; }
        HPResergerCapaLogica.HPResergerCL CcuentaContable = new HPResergerCapaLogica.HPResergerCL();
        private void frmlistarcuentas_Load(object sender, EventArgs e)
        {
            tipobusca = 4;
            aceptar = false;
            if (radioButton1.Checked)
            {
                tipobusca = 4;
                ListarCuentasContables(Txtbusca.Text, tipobusca);
            }
            if (radioButton2.Checked)
            {
                tipobusca = 2;
                ListarCuentasContables(Txtbusca.Text, tipobusca);
            }
            if (radioButton4.Checked)
            {
                tipobusca = 3;
                ListarCuentasContables(Txtbusca.Text, tipobusca);
            }
            msg(dtgconten);
        }
        public void msg(DataGridView conteo)
        {
            lblmsg.Text = "Total Registros: " + conteo.RowCount;
        }
        public void Txtbusca_TextChanged(object sender, EventArgs e)
        {
            if (Txtbusca.EstaLLeno())
                dtgconten.DataSource = CcuentaContable.ListarCuentasContables(Txtbusca.Text, tipobusca);
            msg(dtgconten);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Txtbusca.Text = "";
        }
        public void ListarCuentasContables(string busca, int opcion)
        {
            dtgconten.DataSource = CcuentaContable.ListarCuentasContables(busca, opcion);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            aceptar = false;
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 4;
            Txtbusca_TextChanged(sender, e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 2;
            Txtbusca_TextChanged(sender, e);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 3;
            Txtbusca_TextChanged(sender, e);
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            codigo = dtgconten[0, dtgconten.CurrentRow.Index].Value.ToString();
            if (codigo.Substring(codigo.Length - 1, 1) == "0")
            {
                MSG("No se Puede Seleccionar una cuenta de Cabecera");
            }
            else
            {
                aceptar = true;
                this.Close();
            }
        }
        private void MSG(string v)
        {
            MessageBox.Show(v, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        frmcuentacontable cuentas;
        private void button1_Click(object sender, EventArgs e)
        {
            if (cuentas == null)
            {
                cuentas = new frmcuentacontable();
                cuentas.Consulta = true;
                cuentas.CodigoCuenta = Txtbusca.Text;
                cuentas.FormClosed += Cuentas_FormClosed;
                cuentas.Txtbusca.Text = Txtbusca.Text;
                cuentas.Show();
            }
            else cuentas.Activate();
        }
        private void Cuentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cuentas.Encontrado) { Txtbusca.Text = cuentas.CodigoCuenta; }
            cuentas = null;
        }
        private void dtgconten_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                codigo = dtgconten[0, dtgconten.CurrentCell.RowIndex].Value.ToString();
                if (codigo.Substring(codigo.Length - 1, 1) == "0")
                {
                    MSG("No se Puede Seleccionar una cuenta de Cabecera");
                }
                else
                {
                    aceptar = true;
                    this.Close();
                }
            }
            catch { }
        }

        private void Txtbusca_Load(object sender, EventArgs e)
        {

        }
    }
}
