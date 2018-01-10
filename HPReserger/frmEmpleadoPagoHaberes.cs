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
        int estado = 0;
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
            if (txtCuenta.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº de Cuenta", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCuenta.Focus();
                return;
            }
            if (txtCuentaCCI.Text.Length < 20)
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
            btnaceptar.Enabled = false;
            pnlconten.Enabled = false;
        }

        private void CargaCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clPagoHaberes.getCargoTipoContratacion(codigo, descripcion, tabla);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estado = 2;
            btnModificar.Enabled = false;
            btnRegistrar.Enabled = false;
            btnaceptar.Enabled = true;
            pnlconten.Enabled = true;
        }

        private void txtCuenta_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtCuenta, 20);
        }

        private void txtCuentaCCI_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtCuentaCCI, 20);
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                GrabarEditar(1);
                MessageBox.Show("Pago de Haberes registrado con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);

                estado = 0;
                btnaceptar.Enabled = false;
                pnlconten.Enabled = false;
                btnModificar.Enabled = true;
            }
            if (estado == 2)
            {
                GrabarEditar(0);
                MessageBox.Show("Pago de Haberes actualizo con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);

                estado = 0;
                btnaceptar.Enabled = false;
                pnlconten.Enabled = false; btnModificar.Enabled = true;
            }
        }

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
    }
}
