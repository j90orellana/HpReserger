using CrystalDecisions.Shared;
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
    public partial class frmRPTExportarRequerimiento : Form
    {
        public frmRPTExportarRequerimiento()
        {
            InitializeComponent();
        }
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        public string numerodocumento;
        public string codigodocumento;
        private void frmRPTExportarRequerimiento_Load(object sender, EventArgs e)
        {
            rptReporteRequerimientos requeri = new rptReporteRequerimientos();
            requeri.Refresh();
            requeri.SetDatabaseLogon(datos.USERID, datos.USERPASS);
            requeri.SetParameterValue(0, numerodocumento);
            requeri.SetParameterValue(1, codigodocumento);
            rptreporterequerimientos.AllowedExportFormats = (int)(ViewerExportFormats.PdfFormat | ViewerExportFormats.RtfFormat | ViewerExportFormats.EditableRtfFormat);
            rptreporterequerimientos.ReportSource = requeri;
            rptreporterequerimientos.Zoom(150);
        }
    }
}
