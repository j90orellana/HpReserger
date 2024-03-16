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
    public partial class frmOrdenPedido : FormGradient
    {
        HPResergerCapaLogica.HPResergerCL clOrdenPedido = new HPResergerCapaLogica.HPResergerCL();
        public frmOrdenPedido()
        {
            InitializeComponent();
        }
        DataTable Activo;
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
            CargarValoresdeActivo();
            /////verificamos si es admin para que no pueda agregar ordenes de pedido
            VerificarsiesAdmin();
        }
        public void VerificarsiesAdmin()
        {
            if (frmLogin.CodigoUsuario == 0)
                btnAceptar.Enabled = btnAceptar.Enabled = false;
        }
        private void CargarValoresdeActivo()
        {
            Activo = new DataTable();
            Activo.Columns.Add("CODIGO", typeof(int));
            Activo.Columns.Add("VALOR", typeof(string));
            Activo.Rows.Add(new object[] { "0", "NO" });
            Activo.Rows.Add(new object[] { "1", "SI" });
        }
        private void gridItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Item.Index && e.RowIndex > -1)
            {
                DataGridViewComboBoxCell MarcaColumn = gridItem.Rows[e.RowIndex].Cells["Marca"] as DataGridViewComboBoxCell;
                MarcaColumn.Value = null;
                if (gridItem.CurrentRow.Cells["Item"].Value != null)
                {
                    int idItem = Convert.ToInt32(gridItem.CurrentRow.Cells["Item"].Value.ToString());
                    MarcaColumn.ValueMember = "IdMarcas";
                    MarcaColumn.DisplayMember = "Marcas";
                    MarcaColumn.DataSource = clOrdenPedido.MarcaArticulo(idItem);
                }
            }
            if (e.ColumnIndex == Marca.Index && e.RowIndex > -1)
            {
                DataGridViewComboBoxCell ModeloColumn = gridItem.Rows[e.RowIndex].Cells["Modelo"] as DataGridViewComboBoxCell;
                ModeloColumn.Value = null;

                if (gridItem.CurrentRow.Cells["Marca"].Value != null && gridItem.CurrentRow.Cells["Marca"].Value.ToString() != "")
                {
                    ModeloColumn.ValueMember = "IdModelos";
                    ModeloColumn.DisplayMember = "Modelos";
                    ModeloColumn.DataSource = clOrdenPedido.ModeloArticulo(Convert.ToInt32(gridItem.CurrentRow.Cells["Marca"].Value.ToString()), Convert.ToInt32(gridItem.CurrentRow.Cells["item"].Value.ToString()));
                }
            }
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                if (msgp("Seguro Desea Eliminar esta fila") == DialogResult.Yes)
                {
                    gridItem.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private void gridItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (msgp("¿ Seguro de Eliminar ?") == DialogResult.Yes)
                {
                    e.Handled = true;
                }
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cboproyecto.SelectedIndex < 0)
            {
                msg("Seleccioné Proyecto");
                cboproyecto.Focus();
                return;
            }
            if (cboetapa.SelectedIndex < 0)
            {
                msg("Seleccioné Etapa");
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
                        clOrdenPedido.OrdenPedidoDetalleInsertar(IdNumero, Convert.ToInt32(gridItem.Rows[FilaGrabarArticulo].Cells[Cantidad.Name].Value), Convert.ToInt32(gridItem.Rows[FilaGrabarArticulo].Cells[Item.Name].Value), Convert.ToInt32(gridItem.Rows[FilaGrabarArticulo].Cells[Marca.Name].Value), Convert.ToInt32(gridItem.Rows[FilaGrabarArticulo].Cells[Modelo.Name].Value), "ARTICULO", (int)gridItem[ActFijo.Name, FilaGrabarArticulo].Value, (int)gridItem[CCx.Name, FilaGrabarArticulo].Value);
                    }
                }
                else
                {
                    int FilaGrabarServicio = 0;
                    for (FilaGrabarServicio = 0; FilaGrabarServicio < gridItem.Rows.Count; FilaGrabarServicio++)
                    {
                        string cadenita = "";
                        foreach (char c in gridItem.Rows[FilaGrabarServicio].Cells[Cantidad.Name].Value.ToString())
                        {
                            cadenita += char.ToUpper(c);
                        }
                        clOrdenPedido.OrdenPedidoDetalleInsertar(IdNumero, 0, Convert.ToInt32(gridItem.Rows[FilaGrabarServicio].Cells[Item.Name].Value), 1, 1, cadenita, 0, (int)gridItem[CCx.Name, FilaGrabarServicio].Value);
                    }
                }
                if (IdNumero != 0)
                {
                    gridItem.Rows.Clear();
                    gridItem.Refresh();
                    cboTipoPedido.SelectedIndex = 0;
                    HPResergerFunciones.frmInformativo.MostrarDialog("El pedido Nº " + Convert.ToString(IdNumero).Trim(), "Se grabó con éxito");
                }
            }
        }

        private bool Validar(DataGridView Grid, int Tipo)
        {
            if (Grid.Rows.Count == 0)
            {
                msg("Ingrese Articulos");
                return false;
            }
            int fila = 0;
            int filaBuscar = 0;
            int CodigoArticulo = 0;
            int CodigoMarca = 0;
            int CodigoModelo = 0;
            int Activofijo = 0;
            if (Tipo == 0)
            {
                for (fila = 0; fila < Grid.Rows.Count; fila++)
                {
                    if (Grid.Rows[fila].Cells[Item.Name].Value == null)
                    {
                        msg("En la Fila " + Convert.ToString(fila + 1).Trim() + " debe seleccionar un Artículo");
                        return false;
                    }
                    if (Grid.Rows[fila].Cells[CCx.Name].Value == null)
                    {
                        msg("En la Fila " + Convert.ToString(fila + 1).Trim() + " debe seleccionar un Centro de Costo");
                        return false;
                    }
                    if (Grid.Rows[fila].Cells[Marca.Name].Value == null)
                    {
                        msg("En la Fila " + Convert.ToString(fila + 1).Trim() + " debe seleccionar una Marca");
                        return false;
                    }
                    if (Grid.Rows[fila].Cells[Modelo.Name].Value == null)
                    {
                        msg("En la Fila " + Convert.ToString(fila + 1).Trim() + " debe seleccionar un Modelo");
                        return false;
                    }
                    if (Grid.Rows[fila].Cells[Cantidad.Name].Value == null)
                    {
                        msg("En la Fila " + Convert.ToString(fila + 1).Trim() + " la Cantidad es inválida");
                        return false;
                    }
                    if (string.IsNullOrWhiteSpace(Grid.Rows[fila].Cells[Cantidad.Name].Value.ToString()))
                    {
                        msg("En la Fila " + Convert.ToString(fila + 1).Trim() + " la Cantidad es inválida");
                        return false;
                    }
                    else
                        if (Convert.ToInt32(Grid.Rows[fila].Cells[Cantidad.Name].Value.ToString()) <= 0)
                    {
                        msg("En la Fila " + Convert.ToString(fila + 1).Trim() + " la Cantidad es inválida");
                        return false;
                    }
                    else
                    {
                        string Cant1 = Grid.Rows[fila].Cells[Cantidad.Name].Value.ToString();
                        decimal Cant2 = 0;
                        bool Res = decimal.TryParse(Cant1, out Cant2);
                        if (Res == false)
                        {
                            msg("En la Fila " + Convert.ToString(fila + 1).Trim() + " la Cantidad es inválida");
                            return false;
                        }
                    }
                }
                fila = 0;
                filaBuscar = 0;
                for (fila = 0; fila < Grid.Rows.Count; fila++)
                {
                    CodigoArticulo = Convert.ToInt32(Grid.Rows[fila].Cells[Item.Name].Value.ToString());
                    CodigoMarca = Convert.ToInt32(Grid.Rows[fila].Cells[Marca.Name].Value.ToString());
                    CodigoModelo = Convert.ToInt32(Grid.Rows[fila].Cells[Modelo.Name].Value.ToString());
                    Activofijo = Convert.ToInt32(Grid.Rows[fila].Cells[ActFijo.Name].Value.ToString());
                    for (filaBuscar = 0; filaBuscar < Grid.Rows.Count; filaBuscar++)
                    {
                        if (Activofijo == (int)Grid.Rows[filaBuscar].Cells[Item.Name].Value && CodigoArticulo == Convert.ToInt32(Grid.Rows[filaBuscar].Cells[Item.Name].Value.ToString()) && CodigoMarca == Convert.ToInt32(Grid.Rows[filaBuscar].Cells[Marca.Name].Value.ToString()) && CodigoModelo == Convert.ToInt32(Grid.Rows[filaBuscar].Cells[Modelo.Name].Value.ToString()) && fila != filaBuscar)
                        {
                            HPResergerFunciones.frmInformativo.MostrarDialogError("El Artículo " + Grid.Rows[filaBuscar].Cells[Item.Name].FormattedValue.ToString() + " de Marca " + Grid.Rows[filaBuscar].Cells[Marca.Name].FormattedValue.ToString() + " de Modelo " + Grid.Rows[filaBuscar].Cells[Modelo.Name].FormattedValue.ToString(), "Se esta duplicando");
                            return false;
                        }
                    }
                }
            }
            else
            {
                for (fila = 0; fila < Grid.Rows.Count; fila++)
                {
                    if (Grid.Rows[fila].Cells[Item.Name].Value == null)
                    {
                        msg("En la Fila " + Convert.ToString(fila + 1).Trim() + " debe seleccionar un Servicio");
                        return false;
                    }
                    if (Grid.Rows[fila].Cells[Cantidad.Name].Value == null)
                    {
                        msg("En la Fila " + Convert.ToString(fila + 1).Trim() + " debe ingresar Observaciones");
                        return false;
                    }
                }
                fila = 0;
                filaBuscar = 0;
                for (fila = 0; fila < Grid.Rows.Count; fila++)
                {
                    CodigoArticulo = Convert.ToInt32(Grid.Rows[fila].Cells[Item.Name].Value.ToString());
                    for (filaBuscar = 0; filaBuscar < Grid.Rows.Count; filaBuscar++)
                    {
                        if (CodigoArticulo == Convert.ToInt32(Grid.Rows[filaBuscar].Cells[Item.Name].Value.ToString()) && fila != filaBuscar)
                        {
                            //VALIDAR QUE NO REPITA SERVICIOS
                            //   Message Box.Show("El Servicio " + Grid.Rows[filaBuscar].Cells[Item.Name].FormattedValue.ToString() + " se esta duplicando", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            //  return false;
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
            gridItem[Cantidad.Name, gridItem.RowCount - 1].Value = 0;

            gridItem[ActFijo.Name, gridItem.RowCount - 1].Value = 1;
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
            if (gridItem.CurrentCell.ColumnIndex == Cantidad.Index && cboTipoPedido.SelectedIndex == 0)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(txtNumeros_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(txtNumeros_KeyPress);
                }
            }
            if (gridItem.CurrentCell.ColumnIndex == Cantidad.Index && cboTipoPedido.SelectedIndex == 1)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(txtmayusculas_keypress);
                    txt.KeyPress += new KeyPressEventHandler(txtmayusculas_keypress);
                }
            }
            if (gridItem.CurrentCell.ColumnIndex == CCx.Index)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(txtmayusculas_keypress);
                    txt.KeyPress -= new KeyPressEventHandler(txtNumeros_KeyPress);
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

            DataGridViewComboBoxColumn ItemColumn = gridItem.Columns[Item.Name] as DataGridViewComboBoxColumn;
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
                        gridItem.Columns.Add("ActFijo", "");
                        gridItem.Columns.Add("Marca", "");
                        gridItem.Columns.Add("Modelo", "");
                        gridItem.Columns.Add("Cantidad", "");
                    }
                    gridItem.Columns[0].Visible = true;
                    gridItem.Columns[0].HeaderText = "Acción";
                    //    gridItem.Columns[0].Width = 180;
                    gridItem.Columns[1].Visible = true;
                    gridItem.Columns[1].HeaderText = "Item";

                    gridItem.Columns[2].Visible = true;
                    gridItem.Columns[2].HeaderText = "ActFijo";

                    //   gridItem.Columns[1].Width = 180;
                    gridItem.Columns[3].Visible = true;
                    gridItem.Columns[3].HeaderText = "Marca";

                    //   gridItem.Columns[2].Width = 180;
                    gridItem.Columns[4].Visible = true;
                    gridItem.Columns[4].HeaderText = "Modelo";

                    //  gridItem.Columns[3].Width = 100;
                    gridItem.Columns[5].Visible = true;
                    //gridItem.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    gridItem.Columns[5].HeaderText = "CentroCosto";

                    gridItem.Columns[6].Visible = true;
                    gridItem.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    gridItem.Columns[6].HeaderText = "Cantidad";

                }
                else
                {
                    if (gridItem.Columns.Count == 0)
                    {
                        gridItem.Columns.Add("Accion", "");
                        gridItem.Columns.Add("Item", "");
                        gridItem.Columns.Add("ActFijo", "");
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


                    gridItem.Columns[3].Visible = false;

                    //   gridItem.Columns[2].Width = 0;
                    gridItem.Columns[4].Visible = false;

                    gridItem.Columns[5].Visible = true;

                    //      gridItem.Columns[3].Width = 340;
                    gridItem.Columns[6].Visible = true;
                    gridItem.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    gridItem.Columns[6].HeaderText = "Observaciones";

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

        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboempresa.Items.Count > 0)
            {
                cboproyecto.DataSource = clOrdenPedido.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString());
                cboproyecto.DisplayMember = "proyecto";
                cboproyecto.ValueMember = "id_proyecto";
            }
            else msg("No hay empresas");
        }

        private void gridItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Item.Index && e.RowIndex >= 0)
            {
                DataGridViewComboBoxColumn ItemColumn = gridItem.Columns["Item"] as DataGridViewComboBoxColumn;
                ItemColumn.DisplayMember = "Descripcion";
                ItemColumn.ValueMember = "Id_Articulo";
                ItemColumn.DataSource = clOrdenPedido.ItemCombo(Convert.ToInt32(cboTipoPedido.SelectedValue.ToString()));
            }
            if (e.ColumnIndex == ActFijo.Index && e.RowIndex >= 0)
            {
                DataGridViewComboBoxColumn ItemColumna = gridItem.Columns[ActFijo.Name] as DataGridViewComboBoxColumn;
                ItemColumna.DisplayMember = "valor";
                ItemColumna.ValueMember = "codigo";
                ItemColumna.DataSource = Activo;
            }
            ///centro de costo
            if (e.ColumnIndex == CCx.Index && e.RowIndex >= 0)
            {
                CargarCentroCosto();
                DataGridViewComboBoxColumn ItemColumna = gridItem.Columns[CCx.Name] as DataGridViewComboBoxColumn;
                ItemColumna.DisplayMember = "descripcion";
                ItemColumna.ValueMember = "codigo";
                ItemColumna.DataSource = CentroCosto;
            }
        }
        DataTable CentroCosto, Centroc;
        public void CargarCentroCosto()
        {
            Centroc = new DataTable();
            Centroc = clOrdenPedido.ListarCentroCostos();
            CentroCosto = new DataTable();
            CentroCosto.Columns.Add("codigo", typeof(int));
            CentroCosto.Columns.Add("descripcion");
            CentroCosto.Clear();
            foreach (DataRow item in Centroc.Rows)
            {
                if (item["Id_CtaCtble"].ToString() != "")
                    CentroCosto.Rows.Add(item["Id_CCosto"], item["Id_CtaCtble"] + "-" + item["CentroCosto"]);
            }
        }
        private void btnREfres_Click(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn ItemColumn = gridItem.Columns["Item"] as DataGridViewComboBoxColumn;
            ItemColumn.DisplayMember = "Descripcion";
            ItemColumn.ValueMember = "Id_Articulo";
            ItemColumn.DataSource = clOrdenPedido.ItemCombo(Convert.ToInt32(cboTipoPedido.SelectedValue.ToString()));
        }
        private void gridItem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }
        DataGridViewComboBoxColumn Combo;
        private void gridItem_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gridItem.RowCount > 0)
            {
                int y = e.RowIndex;
                Combo = gridItem.Columns[ActFijo.Name.ToString()] as DataGridViewComboBoxColumn;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "valor";
                Combo.DataSource = Activo;
            }
        }
    }
}