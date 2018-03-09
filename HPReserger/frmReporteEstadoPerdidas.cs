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
    public partial class frmReporteEstadoPerdidas : Form
    {
        public frmReporteEstadoPerdidas()
        {
            InitializeComponent();
        }
        HPResergerCapaDatos.HPResergerCD CapaLogica = new HPResergerCapaDatos.HPResergerCD();
        public int empresa;
        public DateTime año;
        private void frmReporteEstadoPerdidas_Load(object sender, EventArgs e)
        {
            rtpGanaciasPerdidas Reporte = new rtpGanaciasPerdidas();
            Reporte.SetDatabaseLogon(CapaLogica.USERID, CapaLogica.USERPASS);
            Reporte.SetParameterValue(0, año);
            Reporte.SetParameterValue(1, empresa);
            crvreporte.ReportSource = Reporte;
            crvreporte.AllowedExportFormats = (int)(ExportFormatType.PortableDocFormat | ExportFormatType.Excel | ExportFormatType.ExcelWorkbook);
        }
    }
}
