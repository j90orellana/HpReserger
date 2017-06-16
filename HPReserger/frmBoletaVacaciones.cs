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
    public partial class frmBoletaVacaciones : Form
    {
        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public int Registro { get; set; }


        public frmBoletaVacaciones()
        {
            InitializeComponent();
        }
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        private void frmBoletaVacaciones_Load(object sender, EventArgs e)
        {
            rptVacaciones Reporte = new rptVacaciones();
            Reporte.Refresh();
            Reporte.SetParameterValue("@Tipo_ID_Emp", TipoDocumento);
            Reporte.SetParameterValue("@Nro_ID_Emp", NumeroDocumento);
            Reporte.SetParameterValue("@Registro", Registro);
           // Reporte.SetDatabaseLogon(datos.USERID, datos.USERPASS, datos.DATASOURCE, datos.BASEDEDATOS);
            Reporte.SetDatabaseLogon("mmendoza", "123");
            crvBoletaVacaciones.ReportSource = Reporte;
        }

        private void crvBoletaVacaciones_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmBoletaVacaciones_Load(crvBoletaVacaciones, e);
        }
    }
}