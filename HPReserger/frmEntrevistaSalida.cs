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
    public partial class frmEntrevistaSalida : Form
    {
        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }

        public frmEntrevistaSalida()
        {
            InitializeComponent();
        }
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        private void frmEntrevistaSalida_Load(object sender, EventArgs e)
        {
            rptEntrevistaSalida Reporte = new rptEntrevistaSalida();
            Reporte.Refresh();
            Reporte.SetParameterValue("@Tipo_ID_Emp", TipoDocumento);
            Reporte.SetParameterValue("@Nro_ID_Emp", NumeroDocumento);
            //  Reporte.SetDatabaseLogon(datos.USERID, datos.USERPASS, datos.DATASOURCE, datos.BASEDEDATOS);
            Reporte.SetDatabaseLogon("mmendoza", "123");
            crvEntrevistaSalida.ReportSource = Reporte;
        }

        private void crvEntrevistaSalida_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmEntrevistaSalida_Load(crvEntrevistaSalida, e);
        }
    }
}
