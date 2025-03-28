using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace SISGEM.ModuloXtraReports
{
    public partial class frmReportesExternos : DevExpress.XtraEditors.XtraForm
    {
        public frmReportesExternos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEstadoSituacionFinanciera_Click(object sender, EventArgs e)
        {
            HpResergerNube.Contabilidad ccontabilidad = new HpResergerNube.Contabilidad();

            string nombremepresa = cboempresa.Text;
            int año1 = ((DateTime)dtpañode.EditValue).Year;
            int año2 = chkaños.Checked ? ((DateTime)dtpañoa.EditValue).Year : año1;

            // Corrige automáticamente el orden de los años
            int añode = Math.Min(año1, año2);
            int añoa = Math.Max(año1, año2);

            var dataActivos = ccontabilidad.GenerarEstadoSituacionFinancieraActivos(nombremepresa, añode, añoa);
            var dataPasivos = ccontabilidad.GenerarEstadoSituacionFinancieraPasivosPatrimonio(nombremepresa, añode, añoa);

            var reporte = new SISGEM.ModuloXtraReports.Contable.XtraReportEstadoResultadoFinanciera();
            reporte.DataSource = dataActivos;


            //reporte.DataSource = sqlDataSource;
            reporte.crossTab1.DataSource = dataActivos;
            reporte.xrCrossTab1.DataSource = dataPasivos;
            ReportPrintTool printTool = new ReportPrintTool(reporte);
            printTool.ShowPreviewDialog();
        }

        private void btnEstadoResultado_Click(object sender, EventArgs e)
        {
            HpResergerNube.Contabilidad ccontabilidad = new HpResergerNube.Contabilidad();

            string nombremepresa = cboempresa.Text;
            int año1 = ((DateTime)dtpañode.EditValue).Year;
            int año2 = chkaños.Checked ? ((DateTime)dtpañoa.EditValue).Year : año1;

            // Corrige automáticamente el orden de los años
            int añode = Math.Min(año1, año2);
            int añoa = Math.Max(año1, año2);

            var data = ccontabilidad.GenerarEstadoResultadoIntegral(nombremepresa, añode, añoa);

            var reporte = new SISGEM.ModuloXtraReports.Contable.XtraReportEstadoResultadoIntegral();
            reporte.DataSource = data;
            
            reporte.xrCrossTab1.DataSource = data;
            ReportPrintTool printTool = new ReportPrintTool(reporte);
            printTool.ShowPreviewDialog();
        }

        private void frmReportesExternos_Load(object sender, EventArgs e)
        {
            dtpañoa.EditValue = new DateTime(2022, 1, 1);
            dtpañode.EditValue = new DateTime(2022, 1, 1);

            HPResergerCapaLogica.Mantenimiento.Empresa CEmpresa = new HPResergerCapaLogica.Mantenimiento.Empresa();
            DataTable TEmpresa = CEmpresa.GetAll();
            cboempresa.Properties.DataSource = TEmpresa;
            cboempresa.Properties.DisplayMember = "Empresa";
            cboempresa.Properties.ValueMember = "Id_Empresa";
            cboempresa.EditValue = TEmpresa.Rows.Count > 0 ? TEmpresa.Rows[0]["Id_Empresa"] : null;

            cboempresa.Properties.View.Columns.Clear();
            cboempresa.Properties.View.Columns.AddVisible("RUC", "RUC");
            cboempresa.Properties.View.Columns.AddVisible("Empresa", "Empresa");
            var colRuc = cboempresa.Properties.View.Columns["RUC"];
            if (colRuc != null)
            {
                colRuc.Width = 80;
                colRuc.MinWidth = 80;
                colRuc.MaxWidth = 80;
            }

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkaños.Checked)
            {
                lblfechade.Text = "Año de:";
                lblfechaa.Text = "Año a:";
                lblfechaa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                lblfechade.Text = "Año:";
                lblfechaa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }
    }
}