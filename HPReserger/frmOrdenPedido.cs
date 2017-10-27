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
        DataRow DatosU;
        private void frmOrdenPedido_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = frmLogin.Usuario;
            txtArea.Text = frmLogin.Area;
            txtGerencia.Text = frmLogin.Gerencia;
            DatosU = clOrdenPedido.ListarAreaGerenciaDeUsuario(txtUsuario.Text);
            if (DatosU != null)
            {
                txtArea.Text = DatosU["area"].ToString();
                txtGerencia.Text = DatosU["gerencia"].ToString();
            }
            string Repeticion = new string('0', 4 - frmLogin.CodigoCentroCosto.ToString().Length);
            txtCentroCosto.Text = "CC_" + Repeticion + Convert.ToString(frmLogin.CodigoCentroCosto);

            cboTipoPedido.DisplayMember = "Desc_Tipo_compra";
            cboTipoPedido.ValueMember = "Codigo_Tipo_Compra";
            cboTipoPedido.DataSource = clOrdenPedido.ListarTipoPedido();
            cboTipoPedido.SelectedIndex = 0;

            cboempresa.DisplayMember = "descripcion";
            cboempresa.ValueMember = "codigo";
            cboempresa.DataSource = clOrdenPedido.getCargoTipoContratacion("Id_Empresa", "Empresa", "TBL_Empresa");
        }
        private void gridItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex > -1)
            {
                DataGridViewComboBoxCell MarcaColumn = gridItem.Rows[e.RowIndex].Cells["Marca"] as DataGridViewComboBoxCell;
                MarcaColumn.Value = null;

                int idItem = Convert.ToInt32(gridItem.CurrentRow.Cells["Item"].Value.ToString());
                MarcaColumn.ValueMember = "IdMarcas";
                MarcaColumn.DisplayMember = "Marcas";
                MarcaColumn.DataSource = clOrdenPedido.MarcaArticulo(idItem);
            }
            if (e.ColumnIndex == 2 && e.RowIndex > -1)
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
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Seguro Desea Eliminar esta fila", "HpReserger", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    gridItem.Rows.RemoveAt(e.RowIndex);
                }
            }

        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                clOrdenPedido.OrdenPedidoCabeceraInsertar(out IdNumero, frmLogin.CodigoUsuario, cboTipoPedido.SelectedIndex, cboproyecto.SelectedValue.ToString(), cboetapa.SelectedValue.ToString());

                if (cboTipoPedido.SelectedIndex == 0)
                {
                    int FilaGrabarArticulo = 0;
                    for (FilaGrabarArticulo = 0; FilaGrabarArticulo < gridItem.Rows.Count; FilaGrabarArticulo++)
                    {
                        clOrdenPedido.OrdenPedidoDetalleInsertar(IdNumero, Convert.ToInt32(gridItem.Rows[FilaGrabarArticulo].Cells[4].Value), Convert.ToInt32(gridItem.Rows[FilaGrabarArticulo].Cells[1].Value), Convert.ToInt32(gridItem.Rows[FilaGrabarArticulo].Cells[2].Value), Convert.ToInt32(gridItem.Rows[FilaGrabarArticulo].Cells[3].Value), "ARTICULO");
                    }
                }
                else
                {
                    int FilaGrabarServicio = 0;
                    for (FilaGrabarServicio = 0; FilaGrabarServicio < gridItem.Rows.Count; FilaGrabarServicio++)
                    {
                        string cadenita = "";
                        foreach (char c in gridItem.Rows[FilaGrabarServicio].Cells[4].Value.ToString())
                        {
                            cadenita += char.ToUpper(c);
                        }
                        clOrdenPedido.OrdenPedidoDetalleInsertar(IdNumero, 0, Convert.ToInt32(gridItem.Rows[FilaGrabarServicio].Cells[1].Value), 1, 1, cadenita);
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
                    if (Grid.Rows[fila].Cells[1].Value == null)
                    {
                        MessageBox.Show("En la Fila " + Convert.ToString(fila + 1).Trim() + " debe seleccionar un Artículo", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                    if (Grid.Rows[fila].Cells[2].Value == null)
                    {
                        MessageBox.Show("En la Fila " + Convert.ToString(fila + 1).Trim() + " debe seleccionar una Marca", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                    if (Grid.Rows[fila].Cells[3].Value == null)
                    {
                        MessageBox.Show("En la Fila " + Convert.ToString(fila + 1).Trim() + " debe seleccionar un Modelo", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                    if (string.IsNullOrWhiteSpace(Grid.Rows[fila].Cells[4].Value.ToString()))
                    {
                        MessageBox.Show("En la Fila " + Convert.ToString(fila + 1).Trim() + " la Cantidad es inválida", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                    else
                        if (Convert.ToInt32(Grid.Rows[fila].Cells[4].Value.ToString()) <= 0)
                    {
                        MessageBox.Show("En la Fila " + Convert.ToString(fila + 1).Trim() + " la Cantidad es inválida", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                    else
                    {
                        string Cant1 = Grid.Rows[fila].Cells[4].Value.ToString();
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
                    CodigoArticulo = Convert.ToInt32(Grid.Rows[fila].Cells[1].Value.ToString());
                    CodigoMarca = Convert.ToInt32(Grid.Rows[fila].Cells[2].Value.ToString());
                    CodigoModelo = Convert.ToInt32(Grid.Rows[fila].Cells[3].Value.ToString());
                    for (filaBuscar = 0; filaBuscar < Grid.Rows.Count; filaBuscar++)
                    {
                        if (CodigoArticulo == Convert.ToInt32(Grid.Rows[filaBuscar].Cells[1].Value.ToString()) && CodigoMarca == Convert.ToInt32(Grid.Rows[filaBuscar].Cells[2].Value.ToString()) && CodigoModelo == Convert.ToInt32(Grid.Rows[filaBuscar].Cells[3].Value.ToString()) && fila != filaBuscar)
                        {
                            MessageBox.Show("El Artículo " + Grid.Rows[filaBuscar].Cells[1].FormattedValue.ToString() + " de Marca " + Grid.Rows[filaBuscar].Cells[2].FormattedValue.ToString() + " de Modelo " + Grid.Rows[filaBuscar].Cells[3].FormattedValue.ToString() + " se esta duplicando", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return false;
                        }
                    }
                }
            }
            else
            {
                for (fila = 0; fila < Grid.Rows.Count; fila++)
                {
                    if (Grid.Rows[fila].Cells[1].Value == null)
                    {
                        MessageBox.Show("En la Fila " + Convert.ToString(fila + 1).Trim() + " debe seleccionar un Servicio", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                    if (Grid.Rows[fila].Cells[4].Value == null)
                    {
                        MessageBox.Show("En la Fila " + Convert.ToString(fila + 1).Trim() + " debe ingresar Observaciones", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                }

                fila = 0;
                filaBuscar = 0;
                for (fila = 0; fila < Grid.Rows.Count; fila++)
                {
                    CodigoArticulo = Convert.ToInt32(Grid.Rows[fila].Cells[1].Value.ToString());
                    for (filaBuscar = 0; filaBuscar < Grid.Rows.Count; filaBuscar++)
                    {
                        if (CodigoArticulo == Convert.ToInt32(Grid.Rows[filaBuscar].Cells[1].Value.ToString()) && fila != filaBuscar)
                        {
                            MessageBox.Show("El Servicio " + Grid.Rows[filaBuscar].Cells[1].FormattedValue.ToString() + " se esta duplicando", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
        frmListarOrdenesPedido frmLOP;
        private void btnListar_Click(object sender, EventArgs e)
        {
            if (frmLOP == null)
            {
                frmLOP = new frmListarOrdenesPedido();
                frmLOP.MdiParent = this.MdiParent;
                frmLOP.FormClosed += new FormClosedEventHandler(cerrarordenpedido);
                frmLOP.Show();
            }
            else
            {
                frmLOP.Activate();
                ValidarVentanas(frmLOP);
            }
        }
        void cerrarordenpedido(object sender, FormClosedEventArgs e)
        {
            frmLOP = null;
        }
        public void ValidarVentanas(Form formulario)
        {
            if (formulario.WindowState != FormWindowState.Normal)
                formulario.WindowState = FormWindowState.Normal;
            formulario.Left = (this.MdiParent.Width - formulario.Width) / 2;
            formulario.Top = ((this.MdiParent.Height - formulario.Height) / 2);
        }
        private void frmOrdenPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            gridItem.DataSource = null;
            gridItem.Rows.Clear();
            gridItem.Refresh();
        }
        private void gridItem_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridItem.CurrentCell.ColumnIndex == 4 && cboTipoPedido.SelectedIndex == 0)
            {
                TextBox txt = e.Control as TextBox;

                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(txtNumeros_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(txtNumeros_KeyPress);
                }
            }
            if (gridItem.CurrentCell.ColumnIndex == 4 && cboTipoPedido.SelectedIndex == 1)
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
                        gridItem.Columns.Add("accion", "");
                        gridItem.Columns.Add("Item", "");
                        gridItem.Columns.Add("Marca", "");
                        gridItem.Columns.Add("Modelo", "");
                        gridItem.Columns.Add("Cantidad", "");
                    }
                    gridItem.Columns[0].Visible = true;
                    gridItem.Columns[0].HeaderText = "Acción";
                    //    gridItem.Columns[0].Width = 180;
                    gridItem.Columns[1].Visible = true;
                    gridItem.Columns[1].HeaderText = "Item";

                    //   gridItem.Columns[1].Width = 180;
                    gridItem.Columns[2].Visible = true;
                    gridItem.Columns[2].HeaderText = "Marca";

                    //   gridItem.Columns[2].Width = 180;
                    gridItem.Columns[3].Visible = true;
                    gridItem.Columns[3].HeaderText = "Modelo";

                    //  gridItem.Columns[3].Width = 100;
                    gridItem.Columns[4].Visible = true;
                    gridItem.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    gridItem.Columns[4].HeaderText = "Cantidad";

                }
                else
                {
                    if (gridItem.Columns.Count == 0)
                    {
                        gridItem.Columns.Add("Accion", "");
                        gridItem.Columns.Add("Item", "");
                        gridItem.Columns.Add("Marca", "");
                        gridItem.Columns.Add("Modelo", "");
                        gridItem.Columns.Add("Cantidad", "");
                    }

                    //     gridItem.Columns[0].Width = 340;

                    gridItem.Columns[0].Visible = true;
                    gridItem.Columns[0].HeaderText = "Acción";

                    gridItem.Columns[1].Visible = true;
                    gridItem.Columns[1].HeaderText = "Item";

                    //   gridItem.Columns[1].Width = 0;
                    gridItem.Columns[2].Visible = false;

                    //   gridItem.Columns[2].Width = 0;
                    gridItem.Columns[3].Visible = false;

                    //      gridItem.Columns[3].Width = 340;
                    gridItem.Columns[4].Visible = true;
                    gridItem.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    gridItem.Columns[4].HeaderText = "Observaciones";

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

        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboempresa.Items.Count > 0)
            {
                cboproyecto.DataSource = clOrdenPedido.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString());
                cboproyecto.DisplayMember = "proyecto";
                cboproyecto.ValueMember = "id_proyecto";
            }
            else MSG("No hay empresas");
        }

        private void gridItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                DataGridViewComboBoxColumn ItemColumn = gridItem.Columns["Item"] as DataGridViewComboBoxColumn;
                ItemColumn.DisplayMember = "Descripcion";
                ItemColumn.ValueMember = "Id_Articulo";
                ItemColumn.DataSource = clOrdenPedido.ItemCombo(Convert.ToInt32(cboTipoPedido.SelectedValue.ToString()));

            }
        }

        private void btnREfres_Click(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn ItemColumn = gridItem.Columns["Item"] as DataGridViewComboBoxColumn;
            ItemColumn.DisplayMember = "Descripcion";
            ItemColumn.ValueMember = "Id_Articulo";
            ItemColumn.DataSource = clOrdenPedido.ItemCombo(Convert.ToInt32(cboTipoPedido.SelectedValue.ToString()));

        }
    }
}