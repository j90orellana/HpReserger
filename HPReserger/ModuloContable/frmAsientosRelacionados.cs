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

namespace HPReserger.ModuloContable
{
    public partial class frmAsientosRelacionados : FormGradient
    {
        public frmAsientosRelacionados()
        {
            InitializeComponent();
        }
        public DataTable TablaDatos;
        private void frmAsientosRelacionados_Load(object sender, EventArgs e)
        {
            dtgconten.DataSource = TablaDatos;
            lblmensaje.Text = $"Total Registros: {dtgconten.RowCount}";
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
