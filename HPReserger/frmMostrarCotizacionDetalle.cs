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
        public int tipo = 0;
        private void frmMostrarCotizacionDetalle_Load(object sender, EventArgs e)
        {
            dtgconten.DataSource = ClCapa.ListarCotizacionesPorNumero(numero);
            ConfigurarGrid();
        }
        public void ConfigurarGrid()
        {
            if (tipo == 0)
            {
                foreach (DataGridViewColumn item in dtgconten.Columns)
                {
                    item.Visible = true;
                    if (item.Index == dtgconten.Columns[idx.Name].Index || item.Index == dtgconten.Columns[numerox.Name].Index)
                    {
                        item.Visible = false;
                    }
                }
            }
            else
            {
                foreach (DataGridViewColumn item in dtgconten.Columns)
                {
                    if (item.Index == dtgconten.Columns[marcax.Name].Index || item.Index == dtgconten.Columns[modelox.Name].Index || item.Index == dtgconten.Columns[cantidadx.Name].Index)
                        item.Visible = false;
                }
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
