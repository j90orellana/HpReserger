using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.OleDb;

namespace HPReserger
{
    public partial class frmConstanciaTrabajo : Form
    {
        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }

        public frmConstanciaTrabajo()
        {
            InitializeComponent();
        }
        HPResergerCapaDatos.HPResergerCD repor = new HPResergerCapaDatos.HPResergerCD();
        private void frmConstanciaTrabajo_Load(object sender, EventArgs e)
        {
            rptConstanciaTrabajo Reporte = new rptConstanciaTrabajo();
            Reporte.Refresh();
            Reporte.SetParameterValue("@Tipo_ID_Emp", TipoDocumento);
            Reporte.SetParameterValue("@Nro_ID_Emp", NumeroDocumento);         
            Reporte.SetDatabaseLogon(repor.USERID,repor.USERPASS);
            Reporte.SetDatabaseLogon(repor.USERID, repor.USERPASS, repor.DATASOURCE,repor.BASEDEDATOS, false);
            crvConstanciaTrabajo.ReportSource = Reporte;

        }
        public void MSG(string cadena)
        {
            MessageBox.Show(cadena, "HPRESERGER");
        }
        private void crvConstanciaTrabajo_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmConstanciaTrabajo_Load(crvConstanciaTrabajo, e);
        }

        private void crvConstanciaTrabajo_Load(object sender, EventArgs e)
        {

        }
    }
}
