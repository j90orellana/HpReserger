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
    public partial class frmReportePresupuestoCuenta : Form
    {
        public frmReportePresupuestoCuenta()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CLPresuOpera = new HPResergerCapaLogica.HPResergerCL();
        public int cabecera; public int empresa;
        public void MSG(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void frmReportePresupuestoCuenta_Load(object sender, EventArgs e)
        {
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
            cboempresa.DataSource = CLPresuOpera.getCargoTipoContratacion("Id_Empresa", "Empresa", "TBL_Empresa");
            if (cboempresa.Items.Count < 1)
                MSG("No hay Empresas");
        }
        private void cboproyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboproyecto.SelectedIndex > -1)
            {
                cbocuenta.ValueMember = "Id_CtaCtble";
                cbocuenta.DisplayMember = "Id_CtaCtble";
                cbocuenta.DataSource = CLPresuOpera.ListarPresupuestoCentrodeCostoReporteVerCuentas(int.Parse(cboproyecto.SelectedValue.ToString()));
                if (cbocuenta.Items.Count < 1)
                    MSG("No hay Cuentas");
            }

            /* if (cboproyecto.Items.Count > 0)
                 btnGenerar.Enabled = true;
             else btnGenerar.Enabled = false;*/
        }
        public void contando(DataGridView grilla)
        {
            lblmsg.Text = "Total de Registros " + grilla.RowCount;
        }
        decimal IMPORTES, OPERACION, DIFERENCIAS;
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.RowCount > 0)
                btnexportarexcel.Enabled = true;
            else
                btnexportarexcel.Enabled = false;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dtgconten.DataSource = CLPresuOpera.ListarPresupuestoCentrodeCostoReporteCuentas(int.Parse(cboproyecto.SelectedValue.ToString()), cbocuenta.SelectedValue.ToString());
            contando(dtgconten);
            Sumatoria();
        }

        private void cbocuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbocuenta.Items.Count > 0)
                btnGenerar.Enabled = true;
            else btnGenerar.Enabled = false;
        }

        private void btnexportarexcel_Click(object sender, EventArgs e)
        {

        }

        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLPresuOpera.ListarPresupuestosCabecera();
            if (cboempresa.SelectedIndex > -1)
            {
                cboproyecto.ValueMember = "id_proyecto";
                cboproyecto.DisplayMember = "proyecto";
                cboproyecto.DataSource = CLPresuOpera.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString());
                if (cboproyecto.Items.Count < 1)
                    MSG("No hay Proyectos");
            }
        }        
        public void Sumatoria()
        {
            IMPORTES = OPERACION = DIFERENCIAS = 0;
            if (dtgconten.RowCount > 0)
            {
                for (int i = 0; i < dtgconten.RowCount; i++)
                {
                    IMPORTES += decimal.Parse(dtgconten["importe", i].Value.ToString());
                    OPERACION += decimal.Parse(dtgconten["Operaciones", i].Value.ToString());
                    DIFERENCIAS += decimal.Parse(dtgconten["diferencia", i].Value.ToString());
                }
            }
            txtimporte.Text = IMPORTES.ToString("n2");
            txtoperaciones.Text = OPERACION.ToString("n2");
            txtdiferencia.Text = DIFERENCIAS.ToString("n2");

            if (IMPORTES > OPERACION)
            {
                txtimporte.ForeColor = Color.Blue;
                txtoperaciones.ForeColor = Color.Blue;
                txtdiferencia.ForeColor = Color.Blue;
            }
            else if (IMPORTES < OPERACION)
            {
                txtimporte.ForeColor = Color.Red;
                txtoperaciones.ForeColor = Color.Blue;
                txtdiferencia.ForeColor = Color.Blue;
            }
            else
            {
                txtimporte.ForeColor = Color.Black;
                txtoperaciones.ForeColor = Color.Black;
                txtdiferencia.ForeColor = Color.Black;
            }

        }
    }
}
