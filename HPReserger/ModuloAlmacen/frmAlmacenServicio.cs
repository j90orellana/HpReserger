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
    public partial class frmAlmacenServicio : FormGradient
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
                NextValorizacion(Convert.ToInt32(cboOC.SelectedValue.ToString()));
            }
            else
            {

                DataTable tablitas;
                if (gridDetalle.DataSource != null)
                {
                    tablitas = ((DataTable)gridDetalle.DataSource).Clone();
                    gridDetalle.DataSource = tablitas;
                }
                //TitulosGrillas();
            }
            if (gridDetalle1.RowCount == 0)
            {
                LimpiarGrillas();

                //limpiarGRilladetallefin();

            }
        }
        private void LimpiarGrillas()
        {
            DataTable tablitas;
            if (gridDetalle1.DataSource != null)
            {
                tablitas = ((DataTable)gridDetalle1.DataSource).Clone();
                gridDetalle1.DataSource = tablitas;
            }
            if (gridDetalle2.DataSource != null)
            {
                tablitas = ((DataTable)gridDetalle2.DataSource).Clone();
                gridDetalle2.DataSource = tablitas;
            }
        }
        public void limpiarGRilladetallefin()
        {
            gridDetalle2.DataSource = null;
            gridDetalle2.Rows.Clear();
            gridDetalle2.Columns.Clear();
            gridDetalle2.Refresh();

            gridDetalle1.DataSource = null;
            gridDetalle1.Rows.Clear();
            gridDetalle1.Columns.Clear();
            gridDetalle1.Refresh();

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
            gridDetalle1.Columns[3].Visible = false;
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
                gridDetalle2.Columns.Add("CANTING", "AVANCE");
                gridDetalle2.Columns.Add("ItemDetalle", "detalle");
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
            gridDetalle2.Columns[7].HeaderText = "AVANCE";
            gridDetalle2.Columns[7].DataPropertyName = "CANTIDADFIC";
            gridDetalle2.Columns[7].Resizable = DataGridViewTriState.True;

            gridDetalle2.Columns[8].Width = 0;
            gridDetalle2.Columns[8].Visible = false;
            gridDetalle2.Columns[8].DataPropertyName = "ItemDetalle";
        }
        private void Actualiza(int OC)
        {
            gridDetalle.DataSource = clFIGS.ListarArticulosFIC(OC, 1);
            gridDetalle1.DataSource = clFIGS.ListarFIC(OC, 1);
        }

        private void btnAcepatr_Click(object sender, EventArgs e)
        {
            if (txtValor.TextLength == 0)
            {
                MessageBox.Show("Ingrese Nº Valorización", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtValor.Focus();
                return;
            }

            int fila;
            int FilaContarServicio = 0;
            for (fila = 0; fila < gridDetalle.Rows.Count; fila++)
            {
                if (gridDetalle.Rows[fila].Cells[CANT.Name].Value != null && gridDetalle.Rows[fila].Cells[CANT.Name].Value.ToString().Length > 0)
                {
                    string NumDecimal = gridDetalle.Rows[fila].Cells[CANT.Name].Value.ToString();
                    decimal Numero = 0;
                    bool Res = decimal.TryParse(NumDecimal, out Numero);
                    if (Res == false || Convert.ToDecimal(gridDetalle.Rows[fila].Cells[CANT.Name].Value.ToString()) == 0)
                    {
                        MessageBox.Show("En la Fila " + Convert.ToString(fila + 1).Trim() + " el Monto ingresado es inválido", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    if (Convert.ToInt32(gridDetalle.Rows[fila].Cells[SALDO.Name].Value.ToString()) < Convert.ToInt32(gridDetalle.Rows[fila].Cells[CANT.Name].Value.ToString()))
                    {
                        MessageBox.Show("En la Fila " + Convert.ToString(fila + 1).Trim() + " el Saldo NO puede ser Menor a la Cantidad Recepcionada", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                MessageBox.Show("Ingrese Cantidades", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                gridDetalle.Focus();
                return;
            }

            int FIG = 0;
            clFIGS.FICCabeceraInsertar(out FIG, Convert.ToInt32(txtValor.Text.ToString()), Convert.ToInt32(cboOC.SelectedValue.ToString()), 1, frmLogin.CodigoUsuario);

            int filaDetalle = 0;
            for (filaDetalle = 0; filaDetalle < gridDetalle.Rows.Count; filaDetalle++)
            {
                if (gridDetalle.Rows[filaDetalle].Cells[CANT.Name].Value.ToString().Length > 0)
                {
                    clFIGS.FICDetalleInsertar(FIG, Convert.ToInt32(gridDetalle.Rows[filaDetalle].Cells[0].Value.ToString()), Convert.ToInt32(gridDetalle.Rows[filaDetalle].Cells[2].Value.ToString()), Convert.ToInt32(gridDetalle.Rows[filaDetalle].Cells[4].Value.ToString()), Convert.ToInt32(gridDetalle.Rows[filaDetalle].Cells[CANT.Name].Value.ToString()), gridDetalle.Rows[filaDetalle].Cells[5].Value.ToString(), 1, (int)gridDetalle[cc1.Name, filaDetalle].Value);
                }
            }
            ordenCompra = Convert.ToInt32(cboOC.SelectedValue.ToString());
            //gridDetalle1.DataSource = clFIGS.ListarFIC(Convert.ToInt32(cboOC.SelectedValue.ToString()), 1);
            //Actualiza(Convert.ToInt32(cboOC.SelectedValue.ToString()));
            //NextValorizacion(Convert.ToInt32(cboOC.SelectedValue.ToString()));

            if (txtRUC.Text.Length > 0)
            {
                CargaCombo();
            }

            if (FIG != 0)
            {
                MessageBox.Show("EL FIC Nº " + Convert.ToString(FIG) + " se generó con éxito", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string cadenita = txtRUC.Text;
            txtRUC.Text = "";
            txtRUC.Text = cadenita;
            txtRUC_TextChanged(sender, e);
        }
        int ordenCompra = 0;
        private void gridDetalle1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ItemFICS = e.RowIndex;
            if (gridDetalle1.Rows.Count > 0 && e.RowIndex > -1 && cboOC.SelectedValue != null)
            {
                Actualiza2(Convert.ToInt32(cboOC.SelectedValue.ToString()), Convert.ToInt32(gridDetalle1.Rows[e.RowIndex].Cells[0].Value.ToString().Substring(3)));
            }
            else
            {
                LimpiarGrillas();
                //TitulosGrillas();
            }
        }

        private void Actualiza2(int OC, int FIC)
        {
            if (OC != 0 && FIC != 0)
            {
                gridDetalle2.DataSource = clFIGS.ListarFIC2(OC, FIC, 1);
            }
            else
            {
                gridDetalle2.DataSource = null;
            }
        }

        private void frmAlmacenServicio_Load(object sender, EventArgs e)
        {
            //System.Globalization.CultureInfo C = new System.Globalization.CultureInfo("EN-US");
            //Application.CurrentCulture = C;

            txtRUC.Text = "";
            txtValor.Text = "";
            LimpiarGrillas();
            //TitulosGrillas();
        }


        private void NextValorizacion(int nrorden)
        {
            DataRow NextValor = clFIGS.NextValorizacion(nrorden);
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

        private void LimpiarGrillasx()
        {
            gridDetalle.DataSource = null;
            if (gridDetalle.RowCount > 0)
            {

                gridDetalle.Rows.Clear();
                gridDetalle.Columns.Clear();
                gridDetalle.Refresh();
            }
            gridDetalle1.DataSource = null;
            if (gridDetalle1.RowCount > 0)
            {

                gridDetalle1.Rows.Clear();
                gridDetalle1.Columns.Clear();
                gridDetalle1.Refresh();
            }
            gridDetalle2.DataSource = null;
            if (gridDetalle2.RowCount > 0)
            {

                gridDetalle2.Rows.Clear();
                gridDetalle2.Columns.Clear();
                gridDetalle2.Refresh();
            }

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
            gridDetalle.Columns[6].HeaderText = "SALDO (%)";
            gridDetalle.Columns[6].DataPropertyName = "SALDO";

            gridDetalle.Columns[7].Width = 53;
            gridDetalle.Columns[7].Visible = true;
            gridDetalle.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridDetalle.Columns[7].HeaderText = "CANT (%)";
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
            gridDetalle1.Columns[3].Visible = false;
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
                gridDetalle2.Columns.Add("CANTING", "AVANCE");
                gridDetalle2.Columns.Add("ItemDetalle", "detalle");
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
            gridDetalle2.Columns[7].HeaderText = "AVANCE";
            gridDetalle2.Columns[7].DataPropertyName = "CANTIDADFIC";
            gridDetalle2.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            gridDetalle2.Columns[8].Width = 0;
            gridDetalle2.Columns[8].Visible = false;
            gridDetalle2.Columns[8].DataPropertyName = "ItemDetalle";

        }

        private void frmAlmacenServicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            // LimpiarCombos();
            //LimpiarGrillas();
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
                //ordenCompra = 7036;
                cboOC.DataSource = ListaOCProveedor;
                if (ordenCompra != 0)
                {
                    for (int i = 0; i < cboOC.Items.Count; i++)
                    {
                        cboOC.SelectedIndex = i;
                        if (ordenCompra.ToString() == cboOC.SelectedValue.ToString())
                        {
                            break;
                        }
                    }
                }
                //TitulosGrillas();
            }
            else
            {
                LimpiarCombos();
                LimpiarGrillas();
                //TitulosGrillas();
            }
        }

        private void txtRUC_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtRUC, 11);
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            frmListarAlmacenServicios frmservis = new frmListarAlmacenServicios();
            frmservis.txtRUC.Text = txtRUC.Text;
            frmservis.ShowDialog();
        }

        private void gridDetalle2_DoubleClick(object sender, EventArgs e)
        {
            if (gridDetalle1.Rows.Count > 0 && gridDetalle1.CurrentRow.Cells[0].Value != null)
            {
                frmFicModificar FICM = new frmFicModificar();
                FICM.FIC = Convert.ToInt32(gridDetalle1.CurrentRow.Cells[0].Value.ToString().Substring(3));
                FICM.Fecha = Convert.ToDateTime(gridDetalle1.CurrentRow.Cells[1].Value.ToString());
                FICM.GuiaRemision = gridDetalle1.CurrentRow.Cells[2].Value.ToString().Substring(2);
                FICM.Proveedor = txtRUC.Text;
                FICM.tipo = 1;
                FICM.lblguia.Text = "Valorizacion";
                FICM.lblmodelo.Text = "Observacion";
                FICM.txtGuia.ReadOnly = true;
                FICM.ordencompra = Convert.ToInt32(cboOC.Text.Substring(2));
                FICM.ItemDetalle = Convert.ToInt32(gridDetalle2.CurrentRow.Cells[0].Value.ToString());
                FICM.CodigoArticulo = Convert.ToInt32(gridDetalle2.CurrentRow.Cells[1].Value.ToString());
                FICM.Articulo = gridDetalle2.CurrentRow.Cells[2].Value.ToString();
                FICM.CodigoMarca = Convert.ToInt32(gridDetalle2.CurrentRow.Cells[3].Value.ToString());
                FICM.Marca = gridDetalle2.CurrentRow.Cells[4].Value.ToString();
                FICM.CodigoModelo = Convert.ToInt32(gridDetalle2.CurrentRow.Cells[5].Value.ToString());
                FICM.Modelo = gridDetalle2.CurrentRow.Cells[6].Value.ToString();
                FICM.CantOC = Convert.ToString(BuscarSaldo(Convert.ToInt32(gridDetalle2.CurrentRow.Cells[1].Value.ToString())));
                FICM.CantFIC = gridDetalle2.CurrentRow.Cells[CANTING.Name].Value.ToString();

                FICM.cc = (int)gridDetalle2[CC3.Name, gridDetalle2.CurrentRow.Index].Value;
                FICM.CentroCosto = gridDetalle2[CENTROCOSTO3.Name, gridDetalle2.CurrentRow.Index].Value.ToString();
                if (FICM.ShowDialog() == DialogResult.OK)
                {
                    Actualiza(Convert.ToInt32(cboOC.SelectedValue.ToString()));
                }

            }
        }
        private int BuscarSaldo(int CodigoArticulo)
        {
            int FilaCodigo = 0;
            for (FilaCodigo = 0; FilaCodigo < gridDetalle.Rows.Count; FilaCodigo++)
            {
                if (gridDetalle[centrocosto1.Name, FilaCodigo].Value.ToString() == gridDetalle2[CENTROCOSTO3.Name, gridDetalle2.CurrentRow.Index].Value.ToString())
                    if (CodigoArticulo == Convert.ToInt32(gridDetalle.Rows[FilaCodigo].Cells[0].Value.ToString()))
                    {
                        return Convert.ToInt32(gridDetalle.Rows[FilaCodigo].Cells[SALDO.Name].Value.ToString());
                    }
            }
            return 0;
        }

        private void txtRUC_DoubleClick(object sender, EventArgs e)
        {
            frmproveedor frmprovee = new frmproveedor();
            frmprovee.llamada = 1;
            frmprovee.Txtbusca.Text = txtRUC.Text;
            frmprovee.Txtbusca_TextChanged(sender, e);
            frmprovee.ShowDialog();
            txtRUC.Text = frmprovee.rucito;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridDetalle2_DoubleClick(sender, e);
        }
    }
}
