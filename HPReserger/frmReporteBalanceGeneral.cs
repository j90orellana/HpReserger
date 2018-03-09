using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace HPReserger
{
    public partial class frmReporteBalanceGeneral : Form
    {
        public frmReporteBalanceGeneral()
        {
            InitializeComponent();
        }
        public DateTime año = DateTime.Now.AddMonths(-1);
        public int empresa = 2;
        public string NombreEmpresa = "CONSTRUCTORA PRUEBA S.A.C.";
        HPResergerCapaDatos.HPResergerCD CapaLogica = new HPResergerCapaDatos.HPResergerCD();
        private void frmReporteBalanceGeneral_Load(object sender, EventArgs e)
        {
            rptBalanceGeneral Reporte = new rptBalanceGeneral();

            Reporte.SetDatabaseLogon(CapaLogica.USERID, CapaLogica.USERPASS);
            Reporte.SetParameterValue(0, año);
            Reporte.SetParameterValue(1, empresa);
            Reporte.SetParameterValue(2, NombreEmpresa);
            crvreporte.ReportSource = Reporte;
            crvreporte.AllowedExportFormats = (int)(ExportFormatType.PortableDocFormat | ExportFormatType.Excel | ExportFormatType.RichText);
        }

        private void crvreporte_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmReporteBalanceGeneral_Load(crvreporte, e);
        }
    }
}
