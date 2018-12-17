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
    public partial class frmAbonoExternoEmpleado : FormGradient
    {
        public frmAbonoExternoEmpleado()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();

        private void btnrecempresa_Click(object sender, EventArgs e)
        {
            cargarempresas();
        }
        public void cargarempresas()
        {
            cboempresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
        }
        Boolean Modificado = false;
        private void frmAbonoExternoEmpleado_Load(object sender, EventArgs e)
        {
            cargarempresas();
            Modificado = false;
            btngrabar.Enabled = false;
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            dtgconten.DataSource = CapaLogica.AbonosExternos(0, comboMesAño1.GetFecha(), (int)cboempresa.SelectedValue, 0, "", 0, 0);
            btngrabar.Enabled = true;
        }
        TextBox txt;
        private void dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dtgconten.CurrentCell.ColumnIndex == dtgconten.Columns["importeabono"].Index)
            {
                txt = (TextBox)e.Control;
                txt.KeyPress -= new KeyPressEventHandler(txtkeypress);
                txt.KeyPress += new KeyPressEventHandler(txtkeypress);
            }
        }

        private void txtkeypress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimalesX(e, txt.Text);
            Modificado = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (Modificado)
            {
                if (MessageBox.Show("Seguro Desea Salir", CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else { this.Close(); }
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            int fila = dtgconten.RowCount;
            if (fila > 0)
            {
                for (int i = 0; i < fila; i++)
                {
                    if (comboMesAño1.GetFecha().Month != ((DateTime)dtgconten["fecha", i].Value).Month || comboMesAño1.GetFecha().Year != ((DateTime)dtgconten["fecha", i].Value).Year)
                    {
                        msg("No Ha Recargado los datos de la grilla");
                        btncargar.Focus();
                        return;
                    }
                    CapaLogica.AbonosExternos(10, comboMesAño1.GetFecha(), (int)cboempresa.SelectedValue, (int)dtgconten["codempleado", i].Value, dtgconten["Ruc_Empresa", i].Value.ToString(), (decimal)dtgconten["importeabono", i].Value, frmLogin.CodigoUsuario);
                    CapaLogica.AbonosExternos(1, comboMesAño1.GetFecha(), (int)cboempresa.SelectedValue, (int)dtgconten["codempleado", i].Value, dtgconten["Ruc_Empresa", i].Value.ToString(), (decimal)dtgconten["importeabono", i].Value, frmLogin.CodigoUsuario);
                }
                msg("Datos Guardados Exitosamente");
                btngrabar.Enabled = false;
            }
            else
            {
                msg("No Hay Datos para Guardar");
            }
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboMesAño1_Click(object sender, EventArgs e)
        {
            btngrabar.Enabled = false;
        }

        private void comboMesAño1_MouseClick(object sender, MouseEventArgs e)
        {
            btngrabar.Enabled = false;
        }
    }
}
