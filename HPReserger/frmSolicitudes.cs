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
    public partial class frmSolicitudes : Form
    {
        public frmSolicitudes()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmSolicitudes_Load(object sender, EventArgs e)
        {
            REcargardatos();
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

    }
}
