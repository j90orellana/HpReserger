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
    public partial class frmCTS : Form
    {

        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }

        public frmCTS()
        {
            InitializeComponent();
        }

        private void frmCTS_Load(object sender, EventArgs e)
        {
            rptCTS Reporte = new rptCTS();
            Reporte.Refresh();
            Reporte.SetParameterValue("@Tipo_ID_Emp", TipoDocumento);
            Reporte.SetParameterValue("@Nro_ID_Emp", NumeroDocumento);

            Reporte.SetDatabaseLogon("mmendoza", "123");
            crvCTS.ReportSource = Reporte;
        }
    }
}