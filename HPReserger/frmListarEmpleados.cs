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
    public partial class frmListarEmpleados : FormGradient
    {
        HPResergerCapaLogica.HPResergerCL clListarEmpleado = new HPResergerCapaLogica.HPResergerCL();

        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public bool UpdateEmpleado = false;

        public frmListarEmpleados()
        {
            InitializeComponent();
        }
        DataTable TablaTipoID;
        private void frmListarEmpleados_Load(object sender, EventArgs e)
        {
            cboListar.SelectedIndex = 0;
            CargarTiposID("TBL_Tipo_ID");
            checkemp.Checked = checkpos.Checked = true;
        }
        public void CargarTiposID(string tabla)
        {
            TablaTipoID = new DataTable();
            TablaTipoID = clListarEmpleado.CualquierTabla(tabla, "Desc_Tipo_ID", "RUC");
            cboTipoDocumento.DisplayMember = "Desc_Tipo_ID";
            cboTipoDocumento.ValueMember = "Codigo_Tipo_ID";
            cboTipoDocumento.DataSource = TablaTipoID;
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
            if (txtBuscar.Text.Length == 0 && txtDocumento.Text.Length == 0)
            {
                Grid.DataSource = clListarEmpleado.ListarEmpleado(3, "", "", "", 0, "", Posemp);
            }
            else
            {
                Grid.DataSource = clListarEmpleado.ListarEmpleado(cboListar.SelectedIndex, txtBuscar.Text, txtBuscar.Text, txtBuscar.Text, (int)cboTipoDocumento.SelectedValue, txtDocumento.Text, Posemp);
            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            if (Grid.Rows.Count > 0 && Grid.CurrentRow.Cells[CODIGOTIPO.Name].Value != null)
            {
                TipoDocumento = Convert.ToInt32(Grid.CurrentRow.Cells[CODIGOTIPO.Name].Value.ToString());
                NumeroDocumento = Grid.CurrentRow.Cells[NDI.Name].Value.ToString();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscar_TextChanged(sender, e);
        }
        int Posemp = 12;
        private void checkemp_CheckedChanged(object sender, EventArgs e)
        {
            Posemp = 0;
            if (checkpos.Checked)
                Posemp += 2;
            if (checkemp.Checked)
                Posemp += 10;
            txtBuscar_TextChanged(sender, e);
        }

        private void Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                if (Grid[areax.Name, x].Value.ToString() == "NO TIENE" || Grid[gerenciax.Name, x].Value.ToString() == "NO TIENE")
                {
                    Grid.Rows[x].DefaultCellStyle.ForeColor = Color.FromArgb(217, 83, 79);
                    Grid.Rows[x].DefaultCellStyle.SelectionForeColor = Color.FromArgb(217, 83, 79);
                }
                else
                {
                    Grid.Rows[x].DefaultCellStyle.SelectionForeColor = Color.Black;
                    Grid.Rows[x].DefaultCellStyle.ForeColor = Color.Black;
                }
                // Grid.Rows[x].DefaultCellStyle.SelectionBackColor = Color.FromArgb(66, 139, 202);
            }
        }
    }
}