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
    public partial class frmReporteNecesidadMercado : Form
    {
        public frmReporteNecesidadMercado()
        {
            InitializeComponent();
        }
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        public string numero, tipo;
        public int contrato;

        private void frmReporteNecesidadMercado_Load(object sender, EventArgs e)
        {
            crvnecesidadmercado.AllowedExportFormats = (int)(ViewerExportFormats.PdfFormat | ViewerExportFormats.RtfFormat | ViewerExportFormats.EditableRtfFormat);
            rptNecesidadMercado reporte = new rptNecesidadMercado();
            reporte.Refresh();
            reporte.SetParameterValue(0, contrato);
            reporte.SetParameterValue(1, tipo);
            reporte.SetParameterValue(2, numero);
            reporte.SetDatabaseLogon(datos.USERID, datos.USERPASS);
            crvnecesidadmercado.Zoom(125);
            crvnecesidadmercado.ReportSource = reporte;
        }
    }
}
