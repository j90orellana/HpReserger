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
    public partial class frmAlmacenServicio : Form
    {
        HPResergerCapaLogica.HPResergerCL clFIGS = new HPResergerCapaLogica.HPResergerCL();
        public int ItemFICS { get; set; }

        public frmAlmacenServicio()
        {
            InitializeComponent();
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void cboOC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOC.SelectedValue != null)
            {
                Actualiza(Convert.ToInt32(cboOC.SelectedValue.ToString()));
            }
            else
            {
                LimpiarGrillas();
                TitulosGrillas();
            }
        }

        private void Actualiza(int OC)
        {
            gridDetalle.DataSource = clFIGS.ListarArticulosFIC(OC, 1);
            gridDetalle1.DataSource = clFIGS.ListarFIC(OC,1);
        }

        private void btnAcepatr_Click(object sender, EventArgs e)
        {
            if (txtValor.TextLength == 0)
            {
                MessageBox.Show("Ingrese Nº Validación", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtValor.Focus();
                return;
            }

            int fila;
            int FilaContarServicio = 0;
            for (fila = 0; fila < gridDetalle.Rows.Count; fila++)
            {
                if (gridDetalle.Rows[fila].Cells[7].Value != null && gridDetalle.Rows[fila].Cells[7].Value.ToString().Length > 0)
                {
                    string NumDecimal = gridDetalle.Rows[fila].Cells[7].Value.ToString();
                    decimal Numero = 0;
                    bool Res = decimal.TryParse(NumDecimal, out Numero);
                    if (Res == false || Convert.ToDecimal(gridDetalle.Rows[fila].Cells[7].Value.ToString()) == 0)
                    {
                        MessageBox.Show("En la Fila " + Convert.ToString(fila + 1).Trim() + " el Monto ingresado es inválido", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    if (Convert.ToInt32(gridDetalle.Rows[fila].Cells[6].Value.ToString()) < Convert.ToInt32(gridDetalle.Rows[fila].Cells[7].Value.ToString()))
                    {
                        MessageBox.Show("En la Fila " + Convert.ToString(fila + 1).Trim() + " el Saldo NO puede ser Menor a la Cantidad Recepcionada", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
                else
                {
                    FilaContarServicio++;
                }
            }

            if (gridDetalle.Rows.Count == FilaContarServicio)
            {
                MessageBox.Show("Ingrese Cantidades", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                gridDetalle.Focus();
                return;
            }

            int FIG = 0;
            clFIGS.FICCabeceraInsertar(out FIG, Convert.ToInt32(txtValor.Text.ToString()), Convert.ToInt32(cboOC.SelectedValue.ToString()), 1, frmLogin.CodigoUsuario);

            int filaDetalle = 0;
            for (filaDetalle = 0; filaDetalle < gridDetalle.Rows.Count; filaDetalle++)
            {
                if (gridDetalle.Rows[filaDetalle].Cells[7].Value.ToString().Length > 0)
                {
                    clFIGS.FICDetalleInsertar(FIG, Convert.ToInt32(gridDetalle.Rows[filaDetalle].Cells[0].Value.ToString()), Convert.ToInt32(gridDetalle.Rows[filaDetalle].Cells[2].Value.ToString()), Convert.ToInt32(gridDetalle.Rows[filaDetalle].Cells[4].Value.ToString()), Convert.ToInt32(gridDetalle.Rows[filaDetalle].Cells[7].Value.ToString()), gridDetalle.Rows[filaDetalle].Cells[5].Value.ToString(), 1);
                }
            }
            gridDetalle1.DataSource = clFIGS.ListarFIC(Convert.ToInt32(cboOC.SelectedValue.ToString()),1);
            Actualiza(Convert.ToInt32(cboOC.SelectedValue.ToString()));
            NextValorizacion();

            if (txtRUC.Text.Length > 0)
            {
                CargaCombo();
            }

            if (FIG != 0)
            {
                MessageBox.Show("EL FIG Nº " + Convert.ToString(FIG) + " se generó con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridDetalle1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ItemFICS = e.RowIndex;
            if (gridDetalle1.Rows.Count > 0 && e.RowIndex > -1 && cboOC.SelectedValue != null)
            {
                Actualiza2(Convert.ToInt32(cboOC.SelectedValue.ToString()), Convert.ToInt32(gridDetalle1.Rows[e.RowIndex].Cells[0].Value.ToString().Substring(3, 4)));
            }
            else
            {
                LimpiarGrillas();
                TitulosGrillas();
            }
        }

        private void Actualiza2(int OC, int FIC)
        {
            if (OC != 0 && FIC != 0)
            {
                gridDetalle2.DataSource = clFIGS.ListarFIC2(OC, FIC, 1);
            }
        }

        private void frmAlmacenServicio_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo C = new System.Globalization.CultureInfo("EN-US");
            Application.CurrentCulture = C;

            txtRUC.Text = "";
            NextValorizacion();

            LimpiarGrillas();
            TitulosGrillas();
        }


        private void NextValorizacion()
        {   
            DataRow NextValor = clFIGS.NextValorizacion();
            if (NextValor["VALOR"] != null)
            {
                txtValor.Text = NextValor["VALOR"].ToString();
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
            gridDetalle.DataSource = null;
            gridDetalle.Rows.Clear();
            gridDetalle.Columns.Clear();
            gridDetalle.Refresh();

            gridDetalle1.DataSource = null;
            gridDetalle1.Rows.Clear();
            gridDetalle1.Columns.Clear();
            gridDetalle1.Refresh();

            gridDetalle2.DataSource = null;
            gridDetalle2.Rows.Clear();
            gridDetalle2.Columns.Clear();
            gridDetalle2.Refresh();
        }

        private void TitulosGrillas()
        {
            if (gridDetalle.Columns.Count == 0)
            {
                gridDetalle.Columns.Add("CODIGOARTICULO", "");
                gridDetalle.Columns.Add("ITEM", "ITEM");
                gridDetalle.Columns.Add("CODIGOMARCA", "");
                gridDetalle.Columns.Add("MARCA", "MARCA");
                gridDetalle.Columns.Add("CODIGOMODELO", "");
                gridDetalle.Columns.Add("MODELO", "OBSERVACIONES");
                gridDetalle.Columns.Add("SALDO", "SALDO");
                gridDetalle.Columns.Add("CANT", "CANT");
            }

            gridDetalle.Columns[0].Width = 0;
            gridDetalle.Columns[0].Visible = false;
            gridDetalle.Columns[0].DataPropertyName = "CODIGOARTICULO";

            gridDetalle.Columns[1].Width = 200;
            gridDetalle.Columns[1].Visible = true;
            gridDetalle.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridDetalle.Columns[1].HeaderText = "ITEM";
            gridDetalle.Columns[1].DataPropertyName = "ITEM";

            gridDetalle.Columns[2].Width = 0;
            gridDetalle.Columns[2].Visible = false;
            gridDetalle.Columns[2].DataPropertyName = "CODIGOMARCA";

            gridDetalle.Columns[3].Width = 0;
            gridDetalle.Columns[3].Visible = false;
            gridDetalle.Columns[3].DataPropertyName = "MARCA";

            gridDetalle.Columns[4].Width = 0;
            gridDetalle.Columns[4].Visible = false;
            gridDetalle.Columns[4].DataPropertyName = "CODIGOMODELO";

            gridDetalle.Columns[5].Width = 200;
            gridDetalle.Columns[5].Visible = true;
            gridDetalle.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridDetalle.Columns[5].HeaderText = "OBSERVACIONES";
            gridDetalle.Columns[5].DataPropertyName = "OBSERVACIONES";

            gridDetalle.Columns[6].Width = 53;
            gridDetalle.Columns[6].Visible = true;
            gridDetalle.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridDetalle.Columns[6].HeaderText = "SALDO";
            gridDetalle.Columns[6].DataPropertyName = "SALDO";

            gridDetalle.Columns[7].Width = 53;
            gridDetalle.Columns[7].Visible = true;
            gridDetalle.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridDetalle.Columns[7].HeaderText = "CANT";
            gridDetalle.Columns[7].DataPropertyName = "CANT";

            if (gridDetalle1.Columns.Count == 0)
            {
                gridDetalle1.Columns.Add("FIC", "Nº FIC");
                gridDetalle1.Columns.Add("VALORIZACION", "VALORIZACION");
                gridDetalle1.Columns.Add("ARTOC", "ARTOC");
                gridDetalle1.Columns.Add("SSS", "ARTFIC");
            }

            gridDetalle1.Columns[0].Width = 130;
            gridDetalle1.Columns[0].Visible = true;
            gridDetalle1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridDetalle1.Columns[0].HeaderText = "Nº FIC";
            gridDetalle1.Columns[0].DataPropertyName = "FIC";

            gridDetalle1.Columns[1].Width = 130;
            gridDetalle1.Columns[1].Visible = true;
            gridDetalle1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridDetalle1.Columns[1].HeaderText = "VALORIZACION";
            gridDetalle1.Columns[1].DataPropertyName = "GUIA";

            gridDetalle1.Columns[2].Width = 0;
            gridDetalle1.Columns[2].Visible = false;
            gridDetalle1.Columns[2].DataPropertyName = "ARTOC";

            gridDetalle1.Columns[3].Width = 110;
            gridDetalle1.Columns[3].Visible = true;
            gridDetalle1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridDetalle1.Columns[3].HeaderText = "ART FIC";
            gridDetalle1.Columns[3].DataPropertyName = "ARTFIC";


            if (gridDetalle2.Columns.Count == 0)
            {
                gridDetalle2.Columns.Add("G2CODIGOARTICULO", "");
                gridDetalle2.Columns.Add("G2ITEM", "SERVICIOS");
                gridDetalle2.Columns.Add("G2CODIGOMARCA", "");
                gridDetalle2.Columns.Add("G2MARCA", "MARCA");
                gridDetalle2.Columns.Add("G2CODIGOMODELO", "");
                gridDetalle2.Columns.Add("G2MODELO", "OBSERVACIONES");
                gridDetalle2.Columns.Add("CANTOC", "CANT OC");
                gridDetalle2.Columns.Add("CANTING", "AVANCE (%)");
            }

            gridDetalle2.Columns[0].Width = 0;
            gridDetalle2.Columns[0].Visible = false;
            gridDetalle2.Columns[0].DataPropertyName = "CODIGOARTICULO";

            gridDetalle2.Columns[1].Width = 110;
            gridDetalle2.Columns[1].Visible = true;
            gridDetalle2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridDetalle2.Columns[1].HeaderText = "SERVICIOS";
            gridDetalle2.Columns[1].DataPropertyName = "ITEM";

            gridDetalle2.Columns[2].Width = 0;
            gridDetalle2.Columns[2].Visible = false;
            gridDetalle2.Columns[2].DataPropertyName = "CODIGOMARCA";

            gridDetalle2.Columns[3].Width = 0;
            gridDetalle2.Columns[3].Visible = false;
            gridDetalle2.Columns[3].DataPropertyName = "MARCA";

            gridDetalle2.Columns[4].Width = 0;
            gridDetalle2.Columns[4].Visible = false;
            gridDetalle2.Columns[4].DataPropertyName = "CODIGOMODELO";

            gridDetalle2.Columns[5].Width = 0;
            gridDetalle2.Columns[5].Visible = false;
            gridDetalle2.Columns[5].DataPropertyName = "MODELO";

            gridDetalle2.Columns[6].Width = 0;
            gridDetalle2.Columns[6].Visible = false;
            gridDetalle2.Columns[6].DataPropertyName = "CANTIDAD";

            gridDetalle2.Columns[7].Width = 120;
            gridDetalle2.Columns[7].Visible = true;
            gridDetalle2.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridDetalle2.Columns[7].HeaderText = "AVANCE (%)";
            gridDetalle2.Columns[7].DataPropertyName = "CANTIDADFIC";

        }

        private void frmAlmacenServicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            LimpiarCombos();
            LimpiarGrillas();
        }

        private void txtRUC_TextChanged(object sender, EventArgs e)
        {
            CargaCombo();
        }

        private void CargaCombo()
        {
            cboOC.ValueMember = "numero";
            cboOC.DisplayMember = "ordencompra";

            DataTable ListaOCProveedor = clFIGS.ListarOCProveedor(txtRUC.Text, 1, frmLogin.CodigoUsuario);
            if (ListaOCProveedor.Rows.Count > 0)
            {
                cboOC.DataSource = ListaOCProveedor;
                TitulosGrillas();
            }
            else
            {
                LimpiarCombos();
                LimpiarGrillas();
                TitulosGrillas();
            }
        }

        private void txtRUC_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtRUC, 15);
        }
    }
}
