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
    public partial class frmOrdenPedido : Form
    {
        HPResergerCapaLogica.HPResergerCL clOrdenPedido = new HPResergerCapaLogica.HPResergerCL();

        public frmOrdenPedido()
        {
            InitializeComponent();
        }

        private void frmOrdenPedido_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = frmLogin.Usuario;
            txtArea.Text = frmLogin.Area;
            txtGerencia.Text = frmLogin.Gerencia;

            string Repeticion = new string('0', 4 - frmLogin.CodigoCentroCosto.ToString().Length);
            txtCentroCosto.Text = "CC_" + Repeticion + Convert.ToString(frmLogin.CodigoCentroCosto);

            cboTipoPedido.DisplayMember = "Desc_Tipo_compra";
            cboTipoPedido.ValueMember = "Codigo_Tipo_Compra";
            cboTipoPedido.DataSource = clOrdenPedido.ListarTipoPedido();
            cboTipoPedido.SelectedIndex = 0;
            cboproyecto.DataSource = clOrdenPedido.ListarProyectosUsuario(frmLogin.CodigoUsuario);
            cboproyecto.DisplayMember = "proyecto";
            cboproyecto.ValueMember = "id_proyecto";
        }

        private void gridItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                DataGridViewComboBoxCell MarcaColumn = gridItem.Rows[e.RowIndex].Cells["Marca"] as DataGridViewComboBoxCell;
                MarcaColumn.Value = null;

                int idItem = Convert.ToInt32(gridItem.CurrentRow.Cells["Item"].Value.ToString());
                MarcaColumn.ValueMember = "IdMarcas";
                MarcaColumn.DisplayMember = "Marcas";
                MarcaColumn.DataSource = clOrdenPedido.MarcaArticulo(idItem);
            }

            if (e.ColumnIndex == 1 && e.RowIndex > -1)
            {
                DataGridViewComboBoxCell ModeloColumn = gridItem.Rows[e.RowIndex].Cells["Modelo"] as DataGridViewComboBoxCell;
                ModeloColumn.Value = null;

                if (gridItem.CurrentRow.Cells["Marca"].Value != null)
                {
                    ModeloColumn.ValueMember = "IdModelos";
                    ModeloColumn.DisplayMember = "Modelos";
                    ModeloColumn.DataSource = clOrdenPedido.ModeloArticulo(Convert.ToInt32(gridItem.CurrentRow.Cells["Marca"].Value.ToString()), Convert.ToInt32(gridItem.CurrentRow.Cells["item"].Value.ToString()));
                }
            }
        }

        private void gridItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("¿ Seguro de Eliminar ?", "HP Reserger", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    e.Handled = true;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cboproyecto.SelectedIndex < 0)
            {
                MSG("Seleccioné Proyecto");
                cboproyecto.Focus();
                return;
            }
            if (cboetapa.SelectedIndex < 0)
            {
                MSG("Seleccioné Etapa");
                cboetapa.Focus();
                return;
            }

            if (Validar(gridItem, cboTipoPedido.SelectedIndex))
            {
                int IdNumero = 0;
                clOrdenPedido.OrdenPedidoCabeceraInsertar(out IdNumero, frmLogin.CodigoUsuario, cboTipoPedido.SelectedIndex,cboproyecto.SelectedValue.ToString(),cboetapa.SelectedValue.ToString());

                if (cboTipoPedido.SelectedIndex == 0)
                {
                    int FilaGrabarArticulo = 0;
                    for (FilaGrabarArticulo = 0; FilaGrabarArticulo < gridItem.Rows.Count; FilaGrabarArticulo++)
                    {
                        clOrdenPedido.OrdenPedidoDetalleInsertar(IdNumero, Convert.ToInt32(gridItem.Rows[FilaGrabarArticulo].Cells[3].Value), Convert.ToInt32(gridItem.Rows[FilaGrabarArticulo].Cells[0].Value), Convert.ToInt32(gridItem.Rows[FilaGrabarArticulo].Cells[1].Value), Convert.ToInt32(gridItem.Rows[FilaGrabarArticulo].Cells[2].Value), "ARTICULO");
                    }
                }
                else
                {
                    int FilaGrabarServicio = 0;
                    for (FilaGrabarServicio = 0; FilaGrabarServicio < gridItem.Rows.Count; FilaGrabarServicio++)
                    {
                        string cadenita = "";
                        foreach (char c in gridItem.Rows[FilaGrabarServicio].Cells[3].Value.ToString())
                        {
                            cadenita += char.ToUpper(c);
                        }
                        clOrdenPedido.OrdenPedidoDetalleInsertar(IdNumero, 0, Convert.ToInt32(gridItem.Rows[FilaGrabarServicio].Cells[0].Value), 1, 1, cadenita);
                    }
                }
                if (IdNumero != 0)
                {
                    gridItem.Rows.Clear();
                    gridItem.Refresh();
                    cboTipoPedido.SelectedIndex = 0;
                    MessageBox.Show("El pedido Nº " + Convert.ToString(IdNumero).Trim() + " se grabó con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool Validar(DataGridView Grid, int Tipo)
        {
            if (Grid.Rows.Count == 0)
            {
                MessageBox.Show("Ingrese Articulos", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            int fila = 0;
            int filaBuscar = 0;
            int CodigoArticulo = 0;
            int CodigoMarca = 0;
            int CodigoModelo = 0;
            if (Tipo == 0)
            {
                for (fila = 0; fila < Grid.Rows.Count; fila++)
                {
                    if (Grid.Rows[fila].Cells[0].Value == null)
                    {
                        MessageBox.Show("En la Fila " + Convert.ToString(fila + 1).Trim() + " debe seleccionar un Artículo", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                    if (Grid.Rows[fila].Cells[1].Value == null)
                    {
                        MessageBox.Show("En la Fila " + Convert.ToString(fila + 1).Trim() + " debe seleccionar una Marca", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                    if (Grid.Rows[fila].Cells[2].Value == null)
                    {
                        MessageBox.Show("En la Fila " + Convert.ToString(fila + 1).Trim() + " debe seleccionar un Modelo", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                    if (string.IsNullOrWhiteSpace(Grid.Rows[fila].Cells[3].Value.ToString()))
                    {
                        MessageBox.Show("En la Fila " + Convert.ToString(fila + 1).Trim() + " la Cantidad es inválida", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                    else
                        if (Convert.ToInt32(Grid.Rows[fila].Cells[3].Value.ToString()) <= 0)
                    {
                        MessageBox.Show("En la Fila " + Convert.ToString(fila + 1).Trim() + " la Cantidad es inválida", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                    else
                    {

                        string Cant1 = Grid.Rows[fila].Cells[3].Value.ToString();
                        decimal Cant2 = 0;
                        bool Res = decimal.TryParse(Cant1, out Cant2);
                        if (Res == false)
                        {
                            MessageBox.Show("En la Fila " + Convert.ToString(fila + 1).Trim() + " la Cantidad es inválida", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return false;
                        }
                    }
                }

                fila = 0;
                filaBuscar = 0;
                for (fila = 0; fila < Grid.Rows.Count; fila++)
                {
                    CodigoArticulo = Convert.ToInt32(Grid.Rows[fila].Cells[0].Value.ToString());
                    CodigoMarca = Convert.ToInt32(Grid.Rows[fila].Cells[1].Value.ToString());
                    CodigoModelo = Convert.ToInt32(Grid.Rows[fila].Cells[2].Value.ToString());
                    for (filaBuscar = 0; filaBuscar < Grid.Rows.Count; filaBuscar++)
                    {
                        if (CodigoArticulo == Convert.ToInt32(Grid.Rows[filaBuscar].Cells[0].Value.ToString()) && CodigoMarca == Convert.ToInt32(Grid.Rows[filaBuscar].Cells[1].Value.ToString()) && CodigoModelo == Convert.ToInt32(Grid.Rows[filaBuscar].Cells[2].Value.ToString()) && fila != filaBuscar)
                        {
                            MessageBox.Show("El Artículo " + Grid.Rows[filaBuscar].Cells[0].FormattedValue.ToString() + " de Marca " + Grid.Rows[filaBuscar].Cells[1].FormattedValue.ToString() + " de Modelo " + Grid.Rows[filaBuscar].Cells[2].FormattedValue.ToString() + " se esta duplicando", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return false;
                        }
                    }
                }
            }
            else
            {
                for (fila = 0; fila < Grid.Rows.Count; fila++)
                {
                    if (Grid.Rows[fila].Cells[0].Value == null)
                    {
                        MessageBox.Show("En la Fila " + Convert.ToString(fila + 1).Trim() + " debe seleccionar un Servicio", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                    if (Grid.Rows[fila].Cells[3].Value == null)
                    {
                        MessageBox.Show("En la Fila " + Convert.ToString(fila + 1).Trim() + " debe ingresar Observaciones", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                }

                fila = 0;
                filaBuscar = 0;
                for (fila = 0; fila < Grid.Rows.Count; fila++)
                {
                    CodigoArticulo = Convert.ToInt32(Grid.Rows[fila].Cells[0].Value.ToString());
                    for (filaBuscar = 0; filaBuscar < Grid.Rows.Count; filaBuscar++)
                    {
                        if (CodigoArticulo == Convert.ToInt32(Grid.Rows[filaBuscar].Cells[0].Value.ToString()) && fila != filaBuscar)
                        {
                            MessageBox.Show("El Servicio " + Grid.Rows[filaBuscar].Cells[0].FormattedValue.ToString() + " se esta duplicando", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            /*    int fila; int tipos;
                if (gridItem.RowCount > 0)
                {
                    fila = gridItem.RowCount - 1;
                    tipos = Int32.Parse(cboTipoPedido.SelectedValue.ToString());
                    if (tipos == 1)
                    {
                        if (!string.IsNullOrWhiteSpace(gridItem["Item", fila].Value.ToString()))
                        {
                            gridItem.Rows.Add();
                            gridItem[3, gridItem.RowCount - 1].Value = "";
                        }
                    }
                    else
                    {
                        if (gridItem[0, fila].Value.ToString() != "" && gridItem[3, fila].Value.ToString() != "")
                        {
                            gridItem.Rows.Add();
                            gridItem[3, gridItem.RowCount - 1].Value = "";
                        }
                    }

                }
                else
                {*/
            gridItem.Rows.Add();
            gridItem[3, gridItem.RowCount - 1].Value = "";
            /*   }
            */



        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListarOrdenesPedido frmLOP = new frmListarOrdenesPedido();
            frmLOP.ShowDialog();
        }

        private void frmOrdenPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            gridItem.DataSource = null;
            gridItem.Rows.Clear();
            gridItem.Refresh();
        }

        private void gridItem_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridItem.CurrentCell.ColumnIndex == 3 && cboTipoPedido.SelectedIndex == 0)
            {
                TextBox txt = e.Control as TextBox;

                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(txtNumeros_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(txtNumeros_KeyPress);
                }
            }
            if (gridItem.CurrentCell.ColumnIndex == 3 && cboTipoPedido.SelectedIndex == 1)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(txtmayusculas_keypress);
                    txt.KeyPress += new KeyPressEventHandler(txtmayusculas_keypress);
                }
            }
        }
        private void txtmayusculas_keypress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void cboTipoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gridItem.Rows.Count > 0)
            {
                gridItem.DataSource = null;
                gridItem.Rows.Clear();
                gridItem.Refresh();
            }

            DataGridViewComboBoxColumn ItemColumn = gridItem.Columns["Item"] as DataGridViewComboBoxColumn;
            ItemColumn.DisplayMember = "Descripcion";
            ItemColumn.ValueMember = "Id_Articulo";

            if (cboTipoPedido.SelectedIndex > -1)
            {
                ItemColumn.DataSource = clOrdenPedido.ItemCombo(Convert.ToInt32(cboTipoPedido.SelectedValue.ToString()));

                if (cboTipoPedido.SelectedIndex == 0)
                {
                    if (gridItem.Columns.Count == 0)
                    {
                        gridItem.Columns.Add("Item", "");
                        gridItem.Columns.Add("Marca", "");
                        gridItem.Columns.Add("Modelo", "");
                        gridItem.Columns.Add("Cantidad", "");
                    }

                    //    gridItem.Columns[0].Width = 180;
                    gridItem.Columns[0].Visible = true;
                    gridItem.Columns[0].HeaderText = "Item";

                    //   gridItem.Columns[1].Width = 180;
                    gridItem.Columns[1].Visible = true;
                    gridItem.Columns[1].HeaderText = "Marca";

                    //   gridItem.Columns[2].Width = 180;
                    gridItem.Columns[2].Visible = true;
                    gridItem.Columns[2].HeaderText = "Modelo";

                    //  gridItem.Columns[3].Width = 100;
                    gridItem.Columns[3].Visible = true;
                    gridItem.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    gridItem.Columns[3].HeaderText = "Cantidad";

                }
                else
                {
                    if (gridItem.Columns.Count == 0)
                    {
                        gridItem.Columns.Add("Item", "");
                        gridItem.Columns.Add("Marca", "");
                        gridItem.Columns.Add("Modelo", "");
                        gridItem.Columns.Add("Cantidad", "");
                    }

                    //     gridItem.Columns[0].Width = 340;
                    gridItem.Columns[0].Visible = true;
                    gridItem.Columns[0].HeaderText = "Item";

                    //   gridItem.Columns[1].Width = 0;
                    gridItem.Columns[1].Visible = false;

                    //   gridItem.Columns[2].Width = 0;
                    gridItem.Columns[2].Visible = false;

                    //      gridItem.Columns[3].Width = 340;
                    gridItem.Columns[3].Visible = true;
                    gridItem.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    gridItem.Columns[3].HeaderText = "Observaciones";

                }

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cboproyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboproyecto.SelectedIndex >= 0)
            {
                DataRowView itemsito = (DataRowView)cboproyecto.Items[cboproyecto.SelectedIndex];      
                cboetapa.DataSource = clOrdenPedido.ListarEtapasProyecto((itemsito["id_proyecto"].ToString()));
                cboetapa.ValueMember = "id_etapa";
                cboetapa.DisplayMember = "descripcion";
            }
        }
        public void MSG(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}