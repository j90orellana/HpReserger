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
    public partial class frmMostrarCotizacionDetalle : Form
    {
        public frmMostrarCotizacionDetalle()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL ClCapa = new HPResergerCapaLogica.HPResergerCL();
        public int numero = 0;
        private void frmMostrarCotizacionDetalle_Load(object sender, EventArgs e)
        {
            dtgconten.DataSource = ClCapa.ListarCotizacionesPorNumero(numero); 
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
