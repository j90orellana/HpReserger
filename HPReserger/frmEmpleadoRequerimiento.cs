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
    public partial class frmEmpleadoRequerimiento : Form
    {
        HPResergerCapaLogica.HPResergerCL clEmpleadoRequerimiento = new HPResergerCapaLogica.HPResergerCL();
        public int CodigoDocumento { get; set; }
        public string NumeroDocumento { get; set; }

        public frmEmpleadoRequerimiento()
        {
            InitializeComponent();
        }

        private void frmEmpleadoRequerimiento_Load(object sender, EventArgs e)
        {
            cboCelular.SelectedIndex = 0;
            cboCorreo.SelectedIndex = 0;
            cboMaquina.SelectedIndex = 0;
            cboOtros.SelectedIndex = 0;

            DataRow ExisteRequerimiento = clEmpleadoRequerimiento.CargarCualquierImagenPostulanteEmpleado("*", "TBL_Empleado_Requerimiento", "Tipo_ID_Emp", CodigoDocumento, "Nro_ID_Emp", NumeroDocumento);
            if (ExisteRequerimiento != null)
            {
                cboCelular.Text = ExisteRequerimiento["CELULAR"].ToString();
                txtObservacionesCelular.Text = ExisteRequerimiento["CELULAR_OBS"].ToString();
                cboMaquina.Text = ExisteRequerimiento["PC"].ToString();
                txtObservacionesMaquina.Text = ExisteRequerimiento["PC_OBS"].ToString();
                cboCorreo.Text = ExisteRequerimiento["CORREO"].ToString();
                txtObservacionesCorreo.Text = ExisteRequerimiento["CORREO_OBS"].ToString();
                cboOtros.Text = ExisteRequerimiento["OTROS"].ToString();
                txtObservacionesOtros.Text = ExisteRequerimiento["OTROS_OBS"].ToString();
                btnModificar.Enabled = true;
                btnRegistrar.Enabled = false;
            }
            else
            {
                btnModificar.Enabled = false;
                btnRegistrar.Enabled = true;
            }
            btnaceptar.Enabled = false;
            pnlconten.Enabled = false;
        }

        private void cboCelular_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCelular.SelectedIndex == 0)
            {
                txtObservacionesCelular.Text = "";
                txtObservacionesCelular.ReadOnly = false;
                txtObservacionesCelular.Focus();
            }
            else
            {
                txtObservacionesCelular.Text = "";
                txtObservacionesCelular.ReadOnly = true;
            }
        }

        private void cboMaquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaquina.SelectedIndex == 0)
            {
                txtObservacionesMaquina.Text = "";
                txtObservacionesMaquina.ReadOnly = false;
                txtObservacionesMaquina.Focus();
            }
            else
            {
                txtObservacionesMaquina.Text = "";
                txtObservacionesMaquina.ReadOnly = true;
            }
        }

        private void cboCorreo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCorreo.SelectedIndex == 0)
            {
                txtObservacionesCorreo.Text = "";
                txtObservacionesCorreo.ReadOnly = false;
                txtObservacionesCorreo.Focus();
            }
            else
            {
                txtObservacionesCorreo.Text = "";
                txtObservacionesCorreo.ReadOnly = true;
            }
        }

        private void cboOtros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOtros.SelectedIndex == 0)
            {
                txtObservacionesOtros.Text = "";
                txtObservacionesOtros.ReadOnly = false;
                txtObservacionesOtros.Focus();
            }
            else
            {
                txtObservacionesOtros.Text = "";
                txtObservacionesOtros.ReadOnly = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            estado = 1;
            btnModificar.Enabled = false;
            btnRegistrar.Enabled = false;
            btnaceptar.Enabled = true;
            pnlconten.Enabled = true;
        }

        private void GrabarEditar(int Opcion)
        {
            clEmpleadoRequerimiento.EmpleadoRequerimiento(CodigoDocumento, NumeroDocumento, cboCorreo.SelectedItem.ToString(), txtObservacionesCorreo.Text, cboCelular.SelectedItem.ToString(), txtObservacionesCelular.Text, cboMaquina.SelectedItem.ToString(), txtObservacionesMaquina.Text, cboOtros.SelectedItem.ToString(), txtObservacionesOtros.Text, frmLogin.CodigoUsuario, Opcion);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estado = 2;
            btnModificar.Enabled = false;
            btnRegistrar.Enabled = false;
            btnaceptar.Enabled = true;
            pnlconten.Enabled = true;
        }
        int estado = 0;
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado != 0)
            {

                btnaceptar.Enabled = false;
                pnlconten.Enabled = false;
                if (estado == 1)
                {
                    btnRegistrar.Enabled = true;
                    btnModificar.Enabled = false;
                }
                if (estado == 2)
                {
                    btnRegistrar.Enabled = false;
                    btnModificar.Enabled = true;
                }
            }
            if (estado == 0)
            {
                this.Close();
            }
            estado = 0;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                DataRow Existe = clEmpleadoRequerimiento.ExisteBeneficioEmpleado(CodigoDocumento, NumeroDocumento, "usp_ExisteRequerimientoEmpleado");
                if (Existe != null)
                {
                    MessageBox.Show("Empleado ya cuenta el presente Benefico, NO se puede registrar", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                GrabarEditar(1);
                MessageBox.Show("Requerimiento ingresado con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                btnaceptar.Enabled = false;
                pnlconten.Enabled = false;
            }
            if (estado == 2)
            {
                GrabarEditar(0);
                MessageBox.Show("Requerimiento actualizado con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                btnaceptar.Enabled = false;
                pnlconten.Enabled = false;
            }
        }
    }
}
