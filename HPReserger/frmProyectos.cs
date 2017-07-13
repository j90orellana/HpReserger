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
            // DataRow Empresas = CLProyectos.ListarEmpresasdelUsuario(frmLogin.CodigoUsuario);
            DataRow Empresas = CLProyectos.ListarEmpresasdelUsuario(2);
            txtempresa.Text = Empresas["empresa"].ToString();
            empresa = (Empresas["id_empresa"].ToString());
            cargarproyectos();
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
            gp1.Enabled = true;
            dtgconten.Enabled = false;
            estado = 1; txtproyecto.Text = "";
            fila = dtgconten.CurrentCell.RowIndex;
            btnaceptar.Enabled = btncancelar.Enabled = true;
            btnnuevo.Enabled = btnmodificar.Enabled = false;
            txtproyecto.Focus();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            gp1.Enabled = true;
            dtgconten.Enabled = false;
            estado = 2; btnaceptar.Enabled = btncancelar.Enabled = true; txtproyecto.Focus();
            btnnuevo.Enabled = btnmodificar.Enabled = false;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado != 0)
            {
                gp1.Enabled = false;
                dtgconten.Enabled = true; cargarproyectos(); btnaceptar.Enabled = btncancelar.Enabled = false;
                btnnuevo.Enabled = btnmodificar.Enabled = true;
            }
        }
        public void MSG(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fmrProyectodatos proyec = new fmrProyectodatos();
            proyec.Proyecto = int.Parse(dtgconten["idproyecto", e.RowIndex].Value.ToString());
            proyec.txtnombre.Text = (dtgconten["proyecto", e.RowIndex].Value.ToString());
            proyec.ShowDialog();
        }
    }
}
