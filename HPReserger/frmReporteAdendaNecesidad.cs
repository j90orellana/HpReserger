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
    public partial class frmReporteAdendaNecesidad : Form
    {
        public frmReporteAdendaNecesidad()
        {
            InitializeComponent();
        }
        public string tipo, numero, contrato;
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        private void frmReporteAdendaNecesidad_Load(object sender, EventArgs e)
        {
            rptAdendaNecesidad reporte = new rptAdendaNecesidad();
            crvadendaNecesidad.Refresh();
            reporte.SetParameterValue(0, contrato);
            reporte.SetParameterValue(1, tipo);
            reporte.SetParameterValue(2, numero);
            reporte.SetDatabaseLogon(datos.USERID, datos.USERPASS);
            crvadendaNecesidad.AllowedExportFormats = (int)(ExportFormatType.PortableDocFormat | ExportFormatType.RichText | ExportFormatType.EditableRTF);
            crvadendaNecesidad.ReportSource = reporte;
        }
    }
}
