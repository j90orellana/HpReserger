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

namespace HPReserger
{
    public partial class frmEvaludacionPracticas : Form
    {
        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }

        public frmEvaludacionPracticas()
        {
            InitializeComponent();
        }

        private void frmEvaluacionPracticas_Load(object sender, EventArgs e)
        {
            rptEvaluacionPracticas Reporte = new rptEvaluacionPracticas();
            Reporte.Refresh();
            Reporte.SetParameterValue("@Tipo_ID_Emp", TipoDocumento);
            Reporte.SetParameterValue("@Nro_ID_Emp", NumeroDocumento);

            Reporte.SetDatabaseLogon("mmendoza", "123");
            crvEvaluacionPracticas.ReportSource = Reporte;
        }
    }
}
