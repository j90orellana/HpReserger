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
    public partial class frmEmpleadoPensionSeguro : Form
    {
        HPResergerCapaLogica.HPResergerCL clPensionSeguro = new HPResergerCapaLogica.HPResergerCL();

        public int CodigoDocumento { get; set; }

        public string NumeroDocumento { get; set; }
        public bool NuevoPensionSeguro { get; set; }

        public frmEmpleadoPensionSeguro()
        {
            InitializeComponent();
        }

        private void cboEPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEPS.SelectedIndex == 0)
            {
                cboEPSAdicional.Enabled = true;
            }
            else
            {
                cboEPSAdicional.Enabled = false;
            }
        }

        private void cboAFP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAFP.SelectedIndex == 0)
            {
                cboONP.Enabled = false;
                cboAFPEmpresa.Enabled = true;
                txtCUPSS.Enabled = true;
                cboONP.Items.Clear();
                cboONP.Items.Add("NO");
                cboONP.Text = "NO";
            }
            else
            {
                cboONP.Items.Clear();
                cboONP.Items.Add("SI");
                cboONP.Text = "SI";
                cboONP.Enabled = true;
                cboAFPEmpresa.Enabled = false;
                txtCUPSS.Enabled = false;
            }
        }

        private void frmEmpleadoPensionSeguro_Load(object sender, EventArgs e)
        {
            CargaCombos(cboAFPEmpresa, "Id_AFP", "AFP", "TBL_AFP");
            CargaCombos(cboEPSAdicional, "Id_EpsAdic", "Eps_Adicional", "TBL_Eps_Adicional");

            cboEPS.SelectedIndex = 0;
            cboEPSAdicional.SelectedIndex = 0;
            cboSCTR.SelectedIndex = 0;
            cboAFP.SelectedIndex = 0;
            cboONP.SelectedIndex = 0;
            cboAFPEmpresa.SelectedIndex = 0;

            DataRow ExistePension = clPensionSeguro.CargarCualquierImagenPostulanteEmpleado("*", "TBL_Empleado_SeguroPension", "Tipo_ID_Emp", CodigoDocumento, "Nro_ID_Emp", NumeroDocumento);
            if (ExistePension != null)
            {
                cboEPS.Text = ExistePension["EPS"].ToString();
                cboEPSAdicional.SelectedValue = Convert.ToInt32(ExistePension["EPS_ADICIONAL"].ToString());
                cboSCTR.Text = ExistePension["SCTR"].ToString();
                cboAFP.Text = ExistePension["AFP"].ToString();
                cboONP.Text = ExistePension["ONP"].ToString();
                cboAFPEmpresa.SelectedValue = Convert.ToInt32(ExistePension["AFP_EMPRESA"].ToString());
                txtCUPSS.Text = ExistePension["NRO_CUPSS"].ToString();
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
            cbo.DataSource = clPensionSeguro.getCargoTipoContratacion(codigo, descripcion, tabla);
        }

        private void txtCUPSS_KeyPress(object sender, KeyPressEventArgs e)
        {
            //            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
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
            if (txtCUPSS.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Número CUPSS", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCUPSS.Focus();
                return;
            }
            int EPSAdiconal = 0;
            int AFP = 0;
            string ONP;

            if (cboEPSAdicional.Enabled == false)
            {
                EPSAdiconal = 3;
            }
            else
            {
                EPSAdiconal = Convert.ToInt32(cboEPSAdicional.SelectedValue.ToString());
            }

            if (cboONP.Enabled == true)
            {
                AFP = 4;
                ONP = "SI";
            }
            else
            {
                AFP = Convert.ToInt32(cboAFPEmpresa.SelectedValue.ToString());
                ONP = "NO";
            }
            clPensionSeguro.EmpleadoSeguroPension(CodigoDocumento, NumeroDocumento, cboEPS.SelectedItem.ToString(), EPSAdiconal, cboSCTR.SelectedItem.ToString(), ONP, cboAFP.SelectedItem.ToString(), AFP, txtCUPSS.Text, frmLogin.CodigoUsuario, Opcion);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estado = 2;
            btnModificar.Enabled = false;
            btnRegistrar.Enabled = false;
            btnaceptar.Enabled = true;
            pnlconten.Enabled = true;
        }

        private void txtCUPSS_KeyDown(object sender, KeyEventArgs e)
        {
            //HPResergerFunciones.Utilitarios.Validardocumentos(e, txtCUPSS, 20);
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
        int estado = 0;
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                GrabarEditar(1);
                MessageBox.Show("Seguro Pensión generado con éxito", "HP Reserger ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estado = 0;
                btnaceptar.Enabled = false;
                pnlconten.Enabled = false;
                btnModificar.Enabled = true;
            }
            if (estado == 2)
            {
                GrabarEditar(0);
                MessageBox.Show("Seguro Pensión actualizado con éxito", "HP Reserger ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estado = 0;
                btnaceptar.Enabled = false;
                pnlconten.Enabled = false;
                btnModificar.Enabled = true;
            }
        }

        private void cboONP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
