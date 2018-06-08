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
    public partial class frmProyectos : Form
    {
        public frmProyectos()
        {
            InitializeComponent();
        }
        public string empresa;
        HPResergerCapaLogica.HPResergerCL CLProyectos = new HPResergerCapaLogica.HPResergerCL();
        private void frmProyectos_Load(object sender, EventArgs e)
        {
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
            cboempresa.DataSource = CLProyectos.getCargoTipoContratacion("Id_Empresa", "Empresa", "TBL_Empresa");
        }
        public void cargarproyectos()
        {
            dtgconten.DataSource = CLProyectos.ListarProyectosEmpresa(empresa);
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex;
            if (dtgconten.RowCount > 0)
            {
                txtproyecto.Text = dtgconten["Proyecto", y].Value.ToString();
            }
        }

        private void gp1_Enter(object sender, EventArgs e)
        {

        }
        int estado = 0; int fila = 0;
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            if (cboempresa.Items.Count != 0)
            {
                gp1.Enabled = true;
                dtgconten.Enabled = false;
                estado = 1; txtproyecto.Text = "";
                if (dtgconten.RowCount > 0)
                    fila = dtgconten.CurrentCell.RowIndex;
                else fila = 0;
                btnaceptar.Enabled = btncancelar.Enabled = true;
                btnnuevo.Enabled = btnmodificar.Enabled = false;
                txtproyecto.Focus();
            }
            else
                MSG("No hay Empresas");
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (cboempresa.Items.Count != 0)
            {
                gp1.Enabled = true;
                dtgconten.Enabled = false;
                estado = 2; btnaceptar.Enabled = btncancelar.Enabled = true; txtproyecto.Focus();
                btnnuevo.Enabled = btnmodificar.Enabled = false;
            }
            else
                MSG("No hay Empresas");
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado != 0)
            {
                gp1.Enabled = true;
                dtgconten.Enabled = true; cargarproyectos(); btnaceptar.Enabled = btncancelar.Enabled = false;
                btnnuevo.Enabled = btnmodificar.Enabled = true;
                btncancelar.Enabled = true;
            }
            else this.Close();
        }
        public DialogResult MSG(string cadena)
        {
            return MessageBox.Show(cadena, CompanyName ,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtproyecto.Text))
            {
                MSG("Ingresé El nombre del Proyecto");
                return;
            }
            if (estado == 1)
            {
                CLProyectos.Proyectos(txtproyecto.Text, int.Parse(empresa), 0, 1);
                MSG("Proyecto Agregado Existosamente");
            }
            if (estado == 2)
            {
                CLProyectos.Proyectos(txtproyecto.Text, int.Parse(empresa), int.Parse(dtgconten["idproyecto", dtgconten.CurrentCell.RowIndex].Value.ToString()), 2);
                MSG("Proyecto Modificado Existosamente");
            }
            gp1.Enabled = false;
            dtgconten.Enabled = true;
            cargarproyectos(); btnaceptar.Enabled = btncancelar.Enabled = false; estado = 0; btnnuevo.Enabled = btnmodificar.Enabled = true;
        }
        fmrProyectodatos proyec;
        private void dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (proyec == null)
                {
                    proyec = new fmrProyectodatos();
                    proyec.MdiParent = this.MdiParent;
                    proyec.Proyecto = int.Parse(dtgconten["idproyecto", e.RowIndex].Value.ToString());
                    proyec.txtnombre.Text = (dtgconten["proyecto", e.RowIndex].Value.ToString());
                    proyec.FormClosed += new FormClosedEventHandler(cerrarpresupuestoetapas);
                    proyec.Icon = Icon;
                    proyec.Show();
                }
                else
                {
                    proyec.Activate();
                    ValidarVentanas(proyec);
                }
            }
        }
        void cerrarpresupuestoetapas(object sender, FormClosedEventArgs e)
        {
            proyec = null;
        }
        public void ValidarVentanas(Form formulario)
        {
            if (formulario.WindowState != FormWindowState.Normal)
                formulario.WindowState = FormWindowState.Normal;
            formulario.Left = (this.MdiParent.Width - formulario.Width) / 2;
            formulario.Top = ((this.MdiParent.Height - formulario.Height) / 2);
        }
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboempresa.Items.Count > 0)
            {
                empresa = cboempresa.SelectedValue.ToString();
                cargarproyectos();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(dtgconten.CurrentCell.ColumnIndex, dtgconten.CurrentCell.RowIndex);
                dtgconten_CellDoubleClick(sender, ex);
            }
            else
                MSG("No hay proyectos");
        }
    }
}
