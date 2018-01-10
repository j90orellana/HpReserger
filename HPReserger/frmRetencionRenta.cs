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
        public int año;
        public DateTime fechainicial;
        public string numero = "";
        public frmRetencionRenta()
        {
            InitializeComponent();
        }
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        private void frmRetencionRenta_Load(object sender, EventArgs e)
        {
            RptGenerarRenta reporte = new RptGenerarRenta();
            reporte.Refresh();
            reporte.SetParameterValue(0, 0);
            reporte.SetParameterValue(1, TipoDocumento);
            reporte.SetParameterValue(2, NumeroDocumento);
            reporte.SetParameterValue(3, año);
            reporte.SetParameterValue(4, fechainicial);
            //Reporte.SetDatabaseLogon(datos.USERID, datos.USERPASS, datos.DATASOURCE, datos.BASEDEDATOS);
            reporte.SetDatabaseLogon("mmendoza", "123");
            crvRetencionRenta.ReportSource = reporte;
        }
    }
}
