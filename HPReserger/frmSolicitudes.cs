using HpResergerUserControls;
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
    public partial class frmSolicitudes : FormGradient
    {
        public frmSolicitudes()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmSolicitudes_Load(object sender, EventArgs e)
        {
            REcargardatos();
            dtgconten.LostFocus += Dtgconten_LostFocus;
            dtgconten.GotFocus += Dtgconten_GotFocus;
        }

        private void Dtgconten_GotFocus(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void Dtgconten_LostFocus(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        public void REcargardatos()
        {
            dtgconten.DataSource = CapaLogica.TablaSolicitudes(0, frmLogin.CodigoUsuario, "", "", 0, 1, "");
        }
        private void btnrecargar_Click(object sender, EventArgs e)
        {
            REcargardatos();
        }
        private void Btncancelar_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount >= 0)
            {
                int x = dtgconten.CurrentCell.RowIndex;
                CapaLogica.TablaSolicitudes(8, frmLogin.CodigoUsuario, dtgconten["accion", x].Value.ToString(), dtgconten["valores", x].Value.ToString(), 0, 1, "");
                msg("Solicitud Eliminada");
            }
            else msg("No Hay Solicitudes");
            REcargardatos();
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnaprovar_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount >= 0)
            {
                int x = dtgconten.CurrentCell.RowIndex;
                CapaLogica.TablaSolicitudes(10, frmLogin.CodigoUsuario, dtgconten["accion", x].Value.ToString(), dtgconten["valores", x].Value.ToString(), 0, 1, "");
                msg("Solicitud Aprobada");
            }
            else msg("No Hay Solicitudes");
            REcargardatos();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            btnrecargar_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
