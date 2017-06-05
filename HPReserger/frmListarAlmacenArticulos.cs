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
    public partial class frmListarAlmacenArticulos : Form
    {
        public frmListarAlmacenArticulos()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL clFIG = new HPResergerCapaLogica.HPResergerCL();
        public int ItemFIC { get; set; }

        private void txtRUC_TextChanged(object sender, EventArgs e)
        {
            CargraCombo();
            cboOC_SelectedIndexChanged(sender, e);
        }
        private void CargraCombo()
        {
            cboOC.ValueMember = "numero";
            cboOC.DisplayMember = "ordencompra";

            DataTable ListaOCProveedor = clFIG.ListarOCProveedorAprobadas(txtRUC.Text, 0, frmLogin.CodigoUsuario);
            if (ListaOCProveedor.Rows.Count > 0)
            {
                cboOC.DataSource = ListaOCProveedor;
                //TitulosGrillas();
            }
            else
            {
                LimpiarCombos();
                LimpiarGrillas();
                //TitulosGrillas();
            }
        }
        private void LimpiarCombos()
        {
            cboOC.DataSource = null;
            cboOC.Items.Clear();
            cboOC.Refresh();
        }
        private void LimpiarGrillas()
        {
            if (gridDetalle1.RowCount > 0)
            {
                //gridDetalle1.DataSource = null;
                //gridDetalle1.Rows.Clear();
                //.Columns.Clear();
               //   gridDetalle1.Refresh();
            }
            if (gridDetalle2.RowCount > 0)
            {
                //gridDetalle2.DataSource = null;
                //gridDetalle2.Rows.Clear();
                // gridDetalle2.Columns.Clear();
                  //gridDetalle2.Refresh();
            }
        }
        private void TitulosGrillas()
        {

            if (gridDetalle1.Columns.Count == 0)
            {
                gridDetalle1.Columns.Add("FIC", "");
                gridDetalle1.Columns.Add("FECHA", "");
                gridDetalle1.Columns.Add("GUIA", "");
                gridDetalle1.Columns.Add("ARTOC", "");
                gridDetalle1.Columns.Add("ARTFIC", "");
            }

            gridDetalle1.Columns[0].Width = 80;
            gridDetalle1.Columns[0].Visible = true;
            gridDetalle1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridDetalle1.Columns[0].HeaderText = "Nº FIC";
            gridDetalle1.Columns[0].DataPropertyName = "FIC";

            gridDetalle1.Columns[1].Width = 70;
            gridDetalle1.Columns[1].Visible = true;
            gridDetalle1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridDetalle1.Columns[1].HeaderText = "FECHA";
            gridDetalle1.Columns[1].DataPropertyName = "FECHA";

            gridDetalle1.Columns[2].Width = 125;
            gridDetalle1.Columns[2].Visible = true;
            gridDetalle1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridDetalle1.Columns[2].HeaderText = "GUIA REMISION";
            gridDetalle1.Columns[2].DataPropertyName = "GUIA";

            gridDetalle1.Columns[3].Width = 80;
            gridDetalle1.Columns[3].Visible = true;
            gridDetalle1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridDetalle1.Columns[3].HeaderText = "ART OC";
            gridDetalle1.Columns[3].DataPropertyName = "ARTOC";

            gridDetalle1.Columns[4].Width = 80;
            gridDetalle1.Columns[4].Visible = true;
            gridDetalle1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridDetalle1.Columns[4].HeaderText = "ART FIC";
            gridDetalle1.Columns[4].DataPropertyName = "ARTFIC";


            if (gridDetalle2.Columns.Count == 0)
            {
                gridDetalle2.Columns.Add("ItemDetalle", "");
                gridDetalle2.Columns.Add("G2CODIGOARTICULO", "");
                gridDetalle2.Columns.Add("G2ITEM", "ITEM");
                gridDetalle2.Columns.Add("G2CODIGOMARCA", "");
                gridDetalle2.Columns.Add("G2MARCA", "MARCA");
                gridDetalle2.Columns.Add("G2CODIGOMODELO", "");
                gridDetalle2.Columns.Add("G2MODELO", "MODELO");
                gridDetalle2.Columns.Add("G2CANTOC", "CANT OC");
                gridDetalle2.Columns.Add("G2CANTING", "CANT ING");
            }

            gridDetalle2.Columns[0].Width = 0;
            gridDetalle2.Columns[0].Visible = false;
            gridDetalle2.Columns[0].DataPropertyName = "ItemDetalle";

            gridDetalle2.Columns[1].Width = 0;
            gridDetalle2.Columns[1].Visible = false;
            gridDetalle2.Columns[1].DataPropertyName = "CODIGOARTICULO";

            gridDetalle2.Columns[2].Width = 85;
            gridDetalle2.Columns[2].Visible = true;
            gridDetalle2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridDetalle2.Columns[2].HeaderText = "ITEM";
            gridDetalle2.Columns[2].DataPropertyName = "ITEM";

            gridDetalle2.Columns[3].Width = 0;
            gridDetalle2.Columns[3].Visible = false;
            gridDetalle2.Columns[3].DataPropertyName = "CODIGOMARCA";

            gridDetalle2.Columns[4].Width = 85;
            gridDetalle2.Columns[4].Visible = true;
            gridDetalle2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridDetalle2.Columns[4].HeaderText = "MARCA";
            gridDetalle2.Columns[4].DataPropertyName = "MARCA";

            gridDetalle2.Columns[5].Width = 0;
            gridDetalle2.Columns[5].Visible = false;
            gridDetalle2.Columns[5].DataPropertyName = "CODIGOMODELO";

            gridDetalle2.Columns[6].Width = 85;
            gridDetalle2.Columns[6].Visible = true;
            gridDetalle2.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridDetalle2.Columns[6].HeaderText = "MODELO";
            gridDetalle2.Columns[6].DataPropertyName = "MODELO";

            gridDetalle2.Columns[7].Width = 90;
            gridDetalle2.Columns[7].Visible = true;
            gridDetalle2.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridDetalle2.Columns[7].HeaderText = "CANT OC";
            gridDetalle2.Columns[7].DataPropertyName = "CANTIDAD";

            gridDetalle2.Columns[8].Width = 90;
            gridDetalle2.Columns[8].Visible = true;
            gridDetalle2.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridDetalle2.Columns[8].HeaderText = "CANT ING";
            gridDetalle2.Columns[8].DataPropertyName = "CANTIDADFIC";

        }

        private void cboOC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOC.SelectedValue != null)
            {
                Actualiza(Convert.ToInt32(cboOC.SelectedValue.ToString()));
            }
            
        }
        private void Actualiza(int OC)
        {
            if (cboOC.SelectedValue != null)
            {
                gridDetalle1.DataSource = clFIG.ListarFIClistar(OC, 0);
                if (gridDetalle1.Rows.Count > 0 && cboOC.SelectedValue != null)
                {
                    Actualiza2(Convert.ToInt32(cboOC.SelectedValue.ToString()), Convert.ToInt32(gridDetalle1.Rows[ItemFIC].Cells[0].Value.ToString().Substring(3)));
                }
                else
                {
                   // gridDetalle1.DataSource = null;
                }
            }
            else
            {
                //gridDetalle1.DataSource = null;
                LimpiarGrillas();
                //TitulosGrillas();
            }
        }
        private void Actualiza2(int OC, int FIC)
        {
            if (OC != 0 && FIC != 0)
            {
                gridDetalle2.DataSource = clFIG.ListarFIC2listar(OC, FIC, 0);
            }
            else
            {
               // gridDetalle2.DataSource = null;
            }
        }

        private void frmListarAlmacenArticulos_Load(object sender, EventArgs e)
        {

           // LimpiarGrillas();
            //TitulosGrillas();
        }

        private void gridDetalle1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ItemFIC = e.RowIndex;
            if (gridDetalle1.Rows.Count > 0 && e.RowIndex > -1 && cboOC.SelectedValue != null)
            {
                Actualiza2(Convert.ToInt32(cboOC.SelectedValue.ToString()), Convert.ToInt32(gridDetalle1.Rows[e.RowIndex].Cells[0].Value.ToString().Substring(3)));
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
