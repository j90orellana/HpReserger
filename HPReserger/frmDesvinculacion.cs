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
    public partial class frmDesvinculacion : Form
    {
        HPResergerCapaLogica.HPResergerCL clDesvinculacion = new HPResergerCapaLogica.HPResergerCL();
        public frmDesvinculacion()
        {
            InitializeComponent();
        }

        private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {

            DataRow EmpleadoVacaciones = clDesvinculacion.ExisteBeneficioEmpleado(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, "usp_DatosEmpleado");
            if (EmpleadoVacaciones != null)
            {
                txtApellidoPaterno.Text = EmpleadoVacaciones["APELLIDOPATERNO"].ToString();
                txtApellidoMaterno.Text = EmpleadoVacaciones["APELLIDOMATERNO"].ToString();
                txtNombres.Text = EmpleadoVacaciones["NOMBRES"].ToString();
            }
            else
            {
                txtApellidoPaterno.Text = txtApellidoMaterno.Text = txtNombres.Text = "";
            }
        }

        private void frmDesvinculacion_Load(object sender, EventArgs e)
        {

            txtNumeroDocumento.Text = "";
            CargaCombos(cboTipoDocumento, "Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");

        }

        private void CargaCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clDesvinculacion.getCargoTipoContratacion(codigo, descripcion, tabla);
        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void btnGenerarLiquidacion_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }

            frmLiquidacion frmLIQ = new frmLiquidacion();
            frmLIQ.TipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
            frmLIQ.NumeroDocumento = txtNumeroDocumento.Text;

            frmLIQ.ShowDialog();
        }

        private void btnCTS_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }

            frmCTS frmCTS = new frmCTS();
            frmCTS.TipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
            frmCTS.NumeroDocumento = txtNumeroDocumento.Text;

            frmCTS.ShowDialog();
        }

        private void btnConstanciaTrabajo_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }

            frmConstanciaTrabajo frmCT = new frmConstanciaTrabajo();
            frmCT.TipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
            frmCT.NumeroDocumento = txtNumeroDocumento.Text;

            frmCT.ShowDialog();
        }

        private void btnEvaluacionPracticas_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }

            frmEvaludacionPracticas frmEP = new frmEvaludacionPracticas();
            frmEP.TipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
            frmEP.NumeroDocumento = txtNumeroDocumento.Text;

            frmEP.ShowDialog();
        }

        private void btnEntrevistaSalida_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }

            frmEntrevistaSalida frmES = new frmEntrevistaSalida();
            frmES.TipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
            frmES.NumeroDocumento = txtNumeroDocumento.Text;

            frmES.ShowDialog();
        }

        private void btnRetencionRenta_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }

            frmRetencionRenta frmRR = new frmRetencionRenta();
            frmRR.TipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
            frmRR.NumeroDocumento = txtNumeroDocumento.Text;

            frmRR.ShowDialog();
        }

        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumeroDocumento_TextChanged(sender, e);
        }

        private void txtNumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtNumeroDocumento, 15);
        }
    }
}
