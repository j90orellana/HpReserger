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
    public partial class frmMemoPremio : Form
    {

        public int Registro { get; set; }
        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public int TabIndex { get; set; }


        public frmMemoPremio()
        {
            InitializeComponent();
        }

        private void frmMemoPremio_Load(object sender, EventArgs e)
        {
            rptMemoPremio Reporte = new rptMemoPremio();
            Reporte.Refresh();
            Reporte.SetParameterValue("@Registro", Registro);
            Reporte.SetParameterValue("@Tipo_ID_Emp", TipoDocumento);
            Reporte.SetParameterValue("@Nro_ID_Emp", NumeroDocumento);
            Reporte.SetParameterValue("@Tipo", TabIndex);

            Reporte.SetDatabaseLogon("mmendoza", "123");
            crvMemoPremio.ReportSource = Reporte;
        }
    }
}
