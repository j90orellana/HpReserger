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
    public partial class frmreporteboletasfin : Form
    {
        public frmreporteboletasfin()
        {
            InitializeComponent();
        }
        public int empresa;
        public int tipo;
        public string numero = "";
        public int fecha = 0;
        public DateTime fechainicial;
        public DateTime Fechafin;
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();
        private void frmreporteboletasfin_Load(object sender, EventArgs e)
        {
            rptboletas reporte = new rptboletas();
            reporte.Refresh();
            reporte.SetParameterValue(0, empresa);
            reporte.SetParameterValue(1, tipo);
            reporte.SetParameterValue(2, numero);
            reporte.SetParameterValue(3, fecha);
            reporte.SetParameterValue(4, fechainicial);
            reporte.SetParameterValue(5, Fechafin);
            //reporte.SetParameterValue(6, frmLogin.CodigoUsuario);
            reporte.SetDatabaseLogon(datos.USERID, datos.USERPASS);
            crvboletas.ReportSource = reporte;

        }

        private void crvboletas_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            e.Handled = true;
            frmreporteboletasfin_Load(crvboletas, e);
        }

        private void crvboletas_Click(object sender, EventArgs e)
        {
        }
    }
}
