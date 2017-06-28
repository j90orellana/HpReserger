using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmReporteLocacionServicios : Form
    {
        public frmReporteLocacionServicios()
        {
            InitializeComponent();
        }
        public string contrato;
        public string tipo;
        public string numero;
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        private void frmReporteLocacionServicios_Load(object sender, EventArgs e)
        {
            rptLocacionServicios reporte = new rptLocacionServicios();
            reporte.Refresh();
            reporte.SetParameterValue(0, contrato);
            reporte.SetParameterValue(1, tipo);
            reporte.SetParameterValue(2, numero);
            reporte.SetDatabaseLogon(datos.USERID, datos.USERPASS);
            crvLocacionServicios.ReportSource = reporte;
        }
    }
}
