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
    public partial class frmRetencionRenta : Form
    {
        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }

        public frmRetencionRenta()
        {
            InitializeComponent();
        }
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        private void frmRetencionRenta_Load(object sender, EventArgs e)
        {
            rptRetencionRemta Reporte = new rptRetencionRemta();
            Reporte.Refresh();
            Reporte.SetParameterValue("@Tipo_ID_Emp", TipoDocumento);
            Reporte.SetParameterValue("@Nro_ID_Emp", NumeroDocumento);
            //Reporte.SetDatabaseLogon(datos.USERID, datos.USERPASS, datos.DATASOURCE, datos.BASEDEDATOS);
            Reporte.SetDatabaseLogon("mmendoza", "123");
            crvRetencionRenta.ReportSource = Reporte;
        }
    }
}
