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
    public partial class frmListarEmpleados : Form
    {
        HPResergerCapaLogica.HPResergerCL clListarEmpleado = new HPResergerCapaLogica.HPResergerCL();

        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public bool UpdateEmpleado = false;

        public frmListarEmpleados()
        {
            InitializeComponent();
        }

        private void frmListarEmpleados_Load(object sender, EventArgs e)
        {
            cboListar.SelectedIndex = 0;
        }

        private void cboListar_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = cboListar.SelectedItem.ToString();
            MostrarGrid();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarGrid();
        }

        private void MostrarGrid()
        {
            if (txtBuscar.Text.Length == 0)
            {
                Grid.DataSource = clListarEmpleado.ListarEmpleado(3, "", "", "");
            }
            else
            {
                Grid.DataSource = clListarEmpleado.ListarEmpleado(cboListar.SelectedIndex, txtBuscar.Text, txtBuscar.Text, txtBuscar.Text);
            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            if (Grid.Rows.Count > 0 && Grid.CurrentRow.Cells[0].Value != null)
            {
                TipoDocumento = Convert.ToInt32(Grid.CurrentRow.Cells[0].Value.ToString());
                NumeroDocumento = Grid.CurrentRow.Cells[2].Value.ToString();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
    }
}