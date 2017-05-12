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
    public partial class frmEmpleadoPagoHaberes : Form
    {
        HPResergerCapaLogica.HPResergerCL clPagoHaberes = new HPResergerCapaLogica.HPResergerCL();

        public int CodigoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public frmEmpleadoPagoHaberes()
        {
            InitializeComponent();
        }

        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtCuentaCCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            GrabarEditar(1);
            MessageBox.Show("Paho de Haberes registrado con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCuenta.Text = "";
            txtCuentaCCI.Text = "";
            this.Close();
        }

        private void GrabarEditar(int Opcion)
        {
            if (txtCuenta.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº de Cuenta", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCuenta.Focus();
                return;
            }
            if (txtCuentaCCI.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº de Cuenta CCI", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCuentaCCI.Focus();
                return;
            }
            clPagoHaberes.EmpleadoPagoHaberes(CodigoDocumento, NumeroDocumento, Convert.ToInt32(cboBanco.SelectedValue.ToString()), Convert.ToInt32(cboMoneda.SelectedValue.ToString()), txtCuenta.Text, txtCuentaCCI.Text, frmLogin.CodigoUsuario, Opcion);
        }

        private void frmEmpleadoPagoHaberes_Load(object sender, EventArgs e)
        {
            CargaCombos(cboBanco, "Id_Entidad", "Entidad_Financiera", "TBL_Entidad_Financiera");
            CargaCombos(cboMoneda, "Id_Moneda", "Moneda", "TBL_Moneda");

            DataRow ExistePagoHaberes = clPagoHaberes.CargarCualquierImagenPostulanteEmpleado("*", "TBL_Empleado_PagoHaberes", "Tipo_ID_Emp", CodigoDocumento, "Nro_ID_Emp", NumeroDocumento);
            if (ExistePagoHaberes != null)
            {
                cboBanco.SelectedValue = Convert.ToInt32(ExistePagoHaberes["BANCO"].ToString());
                cboMoneda.SelectedValue = Convert.ToInt32(ExistePagoHaberes["MONEDA"].ToString());
                txtCuenta.Text = ExistePagoHaberes["Nro_Cta"].ToString();
                txtCuentaCCI.Text = ExistePagoHaberes["Nro_Cci"].ToString();
                btnModificar.Enabled = true;
                btnRegistrar.Enabled = false;
            }
            else
            {
                btnModificar.Enabled = false;
                btnRegistrar.Enabled = true;
            }
        }

        private void CargaCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clPagoHaberes.getCargoTipoContratacion(codigo, descripcion, tabla);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            GrabarEditar(0);
            MessageBox.Show("Pago de Haberes actualizo con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCuenta.Text = "";
            txtCuentaCCI.Text = "";
            this.Close();
        }

        private void txtCuenta_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtCuenta, 20);
        }

        private void txtCuentaCCI_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtCuentaCCI, 20);
        }
    }
}
