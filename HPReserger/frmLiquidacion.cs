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
    public partial class frmLiquidacion : Form
    {
        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime _FechaInicio;
        public decimal _Monto;
        public string _MotivoCese;
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        public frmLiquidacion()
        {
            InitializeComponent();
        }

        private void frmLiquidacion_Load(object sender, EventArgs e)
        {
            rptLiquidacion Reporte = new rptLiquidacion();
            Reporte.Refresh();
            Reporte.SetParameterValue("@Tipo_ID_Emp", TipoDocumento);
            Reporte.SetParameterValue("@Nro_ID_Emp", NumeroDocumento);
            Reporte.SetParameterValue("@fecha", _FechaInicio);
            Reporte.SetParameterValue("@motivo", _MotivoCese);
            Reporte.SetParameterValue("@monto", _Monto);
            // Reporte.SetDatabaseLogon(datos.USERID, datos.USERPASS,datos.DATASOURCE,datos.BASEDEDATOS);
            Reporte.SetDatabaseLogon("mmendoza", "123");
            cvrLiquidacion.ReportSource = Reporte;

            //cvrLiquidacion.ExportReport();
        }

        private void cvrLiquidacion_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmLiquidacion_Load(cvrLiquidacion, e);
        }
    }
}
