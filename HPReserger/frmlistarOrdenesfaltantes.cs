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
    public partial class frmlistarOrdenesfaltantes : Form
    {
        public frmlistarOrdenesfaltantes()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CLlistarordenes = new HPResergerCapaLogica.HPResergerCL();
        private void frmlistarOrdenesfaltantes_Load(object sender, EventArgs e)
        {
            dtgconten.DataSource = CLlistarordenes.ListarFaltantesCotizacion(int.Parse(txtcotizacion.Text));
        }

        private void frmlistarOrdenesfaltantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                this.Close();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string cadena;
        private void btncopiar_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                cadena = "";
                for (int i = 0; i < dtgconten.RowCount; i++)
                {
                    cadena += "\n\n" + dtgconten[0, i].Value.ToString() + " " + dtgconten[1, i].Value.ToString() + " " + dtgconten[2, i].Value.ToString() + " " + dtgconten[3, i].Value.ToString();
                }
                Clipboard.SetText(cadena);
                msg("Copiado");
            }
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, CompanyName ,MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
