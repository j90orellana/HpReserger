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
    public partial class frmReporteconvenioPracticas : Form
    {
        public frmReporteconvenioPracticas()
        {
            InitializeComponent();
        }
        public int contrato, tipo;
        public string numero;
        HPResergerCapaDatos.HPResergerCD Datos = new HPResergerCapaDatos.HPResergerCD();
        private void frmReporteconvenioPracticas_Load(object sender, EventArgs e)
        {
            rptConvenioPracticasPreprofesional reporte = new rptConvenioPracticasPreprofesional();
            reporte.SetParameterValue(0, contrato);
            reporte.SetParameterValue(1, tipo);
            reporte.SetParameterValue(2, numero);
            reporte.SetDatabaseLogon(Datos.USERID, Datos.USERPASS);
            crvreportepracticas.ReportSource = reporte;
        }
    }
}
