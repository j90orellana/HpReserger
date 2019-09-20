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

namespace HPReserger.ModuloFinanzas
{
    public partial class frmListadoPrestamosCancelados : FormGradient
    {
        public frmListadoPrestamosCancelados()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();

        private void frmListadoPrestamosCancelados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CapaLogica.PrestamosInterEmpresa(0, "", "", "", new DateTime(1990, 1, 1), new DateTime(DateTime.Now.Year, 12, 1), -1, 3, -1);
            lblmensaje.Text = $"Total Registros: {dtgconten.RowCount}";
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
