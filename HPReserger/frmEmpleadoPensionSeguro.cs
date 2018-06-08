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
            CargarDescuentos();
        }
        DataTable Descuentos;
        public void CargarDescuentos()
        {
            Descuentos = new DataTable();
            Descuentos.Columns.Add("codigo", typeof(int));
            Descuentos.Columns.Add("valor", typeof(string));
            //filas
            Descuentos.Rows.Add(0, "General");
            Descuentos.Rows.Add(1, "Monto Fijo");
            Descuentos.Rows.Add(2, "Porcentaje");

            cbodescuento.ValueMember = "codigo";
            cbodescuento.DisplayMember = "valor";
            cbodescuento.DataSource = Descuentos;
        }
        private void cboEPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEPS.SelectedIndex == 0)
            {
                cboEPSAdicional.Enabled = true;
                cboplan.Enabled = true;
            }
            else
            {
                cboEPSAdicional.Enabled = false;
                cboaplica.Enabled = false;
                cbodescuento.Enabled = false;
                numdesc.Enabled = false;
                cboplan.Enabled = false;
            }
            cboplan_SelectedIndexChanged(sender, e);

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
        public void CargarValores()
        {
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
                cboaplica.SelectedIndex = (int)ExistePension["aplica"];
                cbodescuento.SelectedValue = ExistePension["descuento"];
                if ((int)ExistePension["planes"] == 0)
                {
                    cboplan.SelectedIndex = -1;
                }
                else cboplan.SelectedValue = ExistePension["planes"];
                if ((decimal)ExistePension["descvalor"] > numdesc.Maximum)
                {
                    numdesc.Value = numdesc.Maximum;
                }
                else
                    numdesc.Value = (decimal)ExistePension["descvalor"];
                btnModificar.Enabled = true;
                btnRegistrar.Enabled = false;
            }
            else
            {
                btnModificar.Enabled = false;
                btnRegistrar.Enabled = true;
            }
        }
        decimal MontoMAximo = 0;
        public void CargarMontoMaximoEmpresaEPS(int index, int codigo)
        {
            DataRow Filita = clPensionSeguro.EmpresaEPsMOntosMaximos(index, codigo);
            MontoMAximo = (decimal)Filita[0];
        }
        public void CargarPLanes()
        {
            int pla = 0;
            if (cboplan.SelectedValue != null)
                pla = (int)cboplan.SelectedValue;
            cboplan.DataSource = clPensionSeguro.PLanesdelaEmpresa(); ;
            cboplan.DisplayMember = "planes";
            cboplan.ValueMember = "ID_Eps_Planes";
            cboplan.SelectedValue = pla;
        }
        public void CargarEpsAdicional()
        {
            int txt = 0;
            if (cboEPSAdicional.SelectedValue != null)
                txt = (int)cboEPSAdicional.SelectedValue;
            CargaCombos(cboEPSAdicional, "Id_EpsAdic", "Eps_Adicional", "TBL_Eps_Adicional");
            cboEPSAdicional.SelectedValue = txt;
        }
        private void frmEmpleadoPensionSeguro_Load(object sender, EventArgs e)
        {
            CargaCombos(cboAFPEmpresa, "Id_AFP", "AFP", "TBL_AFP");
            CargarEpsAdicional();
            CargarPLanes();
            cboEPS.SelectedIndex = 0;
            cboEPSAdicional.SelectedIndex = 0;
            cboSCTR.SelectedIndex = 0;
            cboAFP.SelectedIndex = 0;
            cboONP.SelectedIndex = 0;
            cboAFPEmpresa.SelectedIndex = 0;

            CargarValores();
            if (cboEPSAdicional.SelectedIndex >= 0 && cboplan.SelectedIndex >= 0)
                CargarMontoMaximoEmpresaEPS((int)cboEPSAdicional.SelectedValue, (int)cboplan.SelectedValue);
            btnaceptar.Enabled = false;
            pnlconten.Enabled = false;
        }

        private void CargaCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clPensionSeguro.getCargoTipoContratacion2(codigo, descripcion, tabla);
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

        private Boolean GrabarEditar(int Opcion)
        {
            if (cboAFP.Text == "SI")
                if (txtCUPSS.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese Número CUPSS", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCUPSS.Focus();
                    return false;
                }
            if (cboplan.Items.Count <= 0 && cboEPS.SelectedIndex == 0)
            {
                msg("No Hay Planes de la empresa EPS Activa");
                cboEPS.Focus();
                return false; ;
            }
            int PLann = 0;
            if (cboEPS.SelectedIndex == 0)
            {
                PLann = 0;
                if (cboplan.SelectedIndex < 0)
                {
                    msg("Seleccione Plan");
                    cboplan.Focus();
                    return false;
                }
                else PLann = (int)cboplan.SelectedValue;
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
            clPensionSeguro.EmpleadoSeguroPension(CodigoDocumento, NumeroDocumento, cboEPS.SelectedItem.ToString(), EPSAdiconal, cboSCTR.SelectedItem.ToString(), ONP, cboAFP.SelectedItem.ToString(), AFP, txtCUPSS.Text, frmLogin.CodigoUsuario, Opcion, (int)cbodescuento.SelectedValue, numdesc.Value, cboaplica.SelectedIndex, PLann);
            return true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estado = 2;
            btnModificar.Enabled = false;
            btnRegistrar.Enabled = false;
            btnaceptar.Enabled = true;
            pnlconten.Enabled = true;
            cboEPS_SelectedIndexChanged(sender, e);
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
                CargarValores();
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
                if (GrabarEditar(1))
                {
                    MessageBox.Show("Seguro Pensión generado con éxito", "HP Reserger ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = 0;
                    btnaceptar.Enabled = false;
                    pnlconten.Enabled = false;
                    btnModificar.Enabled = true;
                }
                else return;
            }
            if (estado == 2)
            {
                if (GrabarEditar(0))
                {
                    MessageBox.Show("Seguro Pensión actualizado con éxito", "HP Reserger ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = 0;
                    btnaceptar.Enabled = false;
                    pnlconten.Enabled = false;
                    btnModificar.Enabled = true;
                }
                else return;
            }
            CargarValores();
        }

        private void cboONP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbodescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ninguno
            numdesc.Maximum = 100000; numdesc.Minimum = 0;
            if (cbodescuento.SelectedIndex == 0)
            {
                numdesc.Enabled = false;
                numdesc.Value = 0;
            }
            //montofijo
            if (cbodescuento.SelectedIndex == 1)
            {
                if (cboaplica.SelectedIndex == 1) numdesc.Enabled = true;
                if (cboplan.SelectedValue != null)
                    CargarMontoMaximoEmpresaEPS((int)cboEPSAdicional.SelectedValue, (int)cboplan.SelectedValue);
                numdesc.Maximum = MontoMAximo; numdesc.Minimum = 0;
            }
            //porcentaje
            if (cbodescuento.SelectedIndex == 2)
            {
                if (cboaplica.SelectedIndex == 1) numdesc.Enabled = true;
                numdesc.Maximum = 100; numdesc.Minimum = 0;
            }
        }

        private void cboEPSAdicional_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEPSAdicional.SelectedIndex >= 0 && cboplan.SelectedIndex >= 0)
                CargarMontoMaximoEmpresaEPS((int)cboEPSAdicional.SelectedValue, (int)cboplan.SelectedValue);
            cbodescuento_SelectedIndexChanged(sender, e);
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void numdesc_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

        }

        private void numdesc_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void numdesc_Leave(object sender, EventArgs e)
        {

        }

        private void numdesc_Validated(object sender, EventArgs e)
        {

        }

        private void numdesc_Validating(object sender, CancelEventArgs e)
        {

        }

        private void numdesc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboaplica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboaplica.SelectedIndex == 1)
            {
                cbodescuento.Enabled = true;
                numdesc.Enabled = true;
            }
            else
            {
                cbodescuento.Enabled = false;
                numdesc.Enabled = false;
            }
            cbodescuento_SelectedIndexChanged(sender, e);
        }

        private void cboplan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboplan.Items.Count > 0 && cboEPS.SelectedIndex == 0)
            {
                cboEPSAdicional.Enabled = true;
                cboaplica.Enabled = true;
            }
            else
            {
                cboEPSAdicional.Enabled = false;
            }
            if (cboaplica.SelectedIndex < 0) cboaplica.SelectedIndex = 0;
            else
            {
                cboaplica_SelectedIndexChanged(sender, e);
                cbodescuento_SelectedIndexChanged(sender, e);
            }
        }
    }
}
