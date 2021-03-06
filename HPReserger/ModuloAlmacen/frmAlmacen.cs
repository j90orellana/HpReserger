﻿using HpResergerUserControls;
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
    public partial class frmAlmacen : FormGradient
    {
        HPResergerCapaLogica.HPResergerCL clFIG = new HPResergerCapaLogica.HPResergerCL();
        public int ItemFIC { get; set; }

        public frmAlmacen()
        {
            InitializeComponent();
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtGR_KeyPress(object sender, KeyPressEventArgs e)
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
                //TitulosGrillas();
            }
        }

        private void Actualiza(int OC)
        {
            //usp_get_Articulos_FIC
            gridDetalle.DataSource = clFIG.ListarArticulosFIC(OC, 0);
            if (gridDetalle.Rows.Count > 0 && cboOC.SelectedValue != null)
            {
                gridDetalle1.DataSource = clFIG.ListarFIC(OC, 0);
                if (gridDetalle1.Rows.Count > 0 && cboOC.SelectedValue != null)
                {
                    Actualiza2(Convert.ToInt32(cboOC.SelectedValue.ToString()), Convert.ToInt32(gridDetalle1.Rows[ItemFIC].Cells[FIC.Name].Value.ToString().Substring(3)));
                }
            }
            else
            {
                LimpiarGrillas();
                // TitulosGrillas(); 
            }
        }

        private void Actualiza2(int OC, int FIC)
        {
            if (OC != 0 && FIC != 0)
            {
                gridDetalle2.DataSource = clFIG.ListarFIC2(OC, FIC, 0);
            }
        }

        private void gridDetalle1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ItemFIC = e.RowIndex;
            if (gridDetalle1.Rows.Count > 0 && e.RowIndex > -1 && cboOC.SelectedValue != null)
            {
                Actualiza2(Convert.ToInt32(cboOC.SelectedValue.ToString()), Convert.ToInt32(gridDetalle1.Rows[e.RowIndex].Cells[FIC.Name].Value.ToString().Substring(3)));
            }
        }

        private void frmAlmacen_Load(object sender, EventArgs e)
        {
            txtRUC.Text = "";
            txtGR.Text = "";

            // LimpiarGrillas();
            //TitulosGrillas();
        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtRUC.Text.Length < 8)
            {
                msg("Ingresé Nro de Ruc");
                txtRUC.Focus();
                return;
            }
            if (cboOC.Items.Count <= 0)
            {
                msg("No hay Ordenes de compra");
                txtRUC.Focus();
                return;

            }
            if (txtGR.TextLength == 0)
            {
                msg("Ingrese Guía de Remisión");
                txtGR.Focus();
                return;
            }
            DataTable dtGuiaRemisionProveedor = clFIG.OrdenCompraProveedor(txtRUC.Text, Convert.ToInt32(txtGR.Text), Convert.ToInt32(cboOC.Text.Substring(2)), 0);
            if (dtGuiaRemisionProveedor.Rows.Count > 0)
            {
                msg("Guía de Remisión ya existe");
                txtGR.Focus();
                return;
            }
            int fila;
            int FilaContarArticulo = 0;
            for (fila = 0; fila < gridDetalle.Rows.Count; fila++)
            {
                if (gridDetalle.Rows[fila].Cells[CANT.Name].Value != null && gridDetalle.Rows[fila].Cells[CANT.Name].Value.ToString().Length > 0)
                {
                    string NumDecimal = gridDetalle.Rows[fila].Cells[CANT.Name].Value.ToString();
                    decimal Numero = 0;
                    bool Res = decimal.TryParse(NumDecimal, out Numero);
                    if (Res == false || Convert.ToDecimal(gridDetalle.Rows[fila].Cells[CANT.Name].Value.ToString()) == 0)
                    {
                        msg("En la Fila " + Convert.ToString(fila + 1).Trim() + " el Monto ingresado es inválido");
                        return;
                    }
                    if (Convert.ToInt32(gridDetalle.Rows[fila].Cells[SALDO.Name].Value.ToString()) < Convert.ToInt32(gridDetalle.Rows[fila].Cells[CANT.Name].Value.ToString()))
                    {
                        msg("En la Fila " + Convert.ToString(fila + 1).Trim() + " el Saldo NO puede ser Menor a la Cantidad Recepcionada");
                        return;
                    }
                }
                else
                {
                    FilaContarArticulo++;
                }
            }
            if (gridDetalle.Rows.Count == FilaContarArticulo)
            {
                msg("Ingrese Cantidades");
                gridDetalle.Focus();
                return;
            }
            int FIG = 0;
            clFIG.FICCabeceraInsertar(out FIG, Convert.ToInt32(txtGR.Text.ToString()), Convert.ToInt32(cboOC.SelectedValue.ToString()), 0, frmLogin.CodigoUsuario);

            int filaDetalle = 0;
            for (filaDetalle = 0; filaDetalle < gridDetalle.Rows.Count; filaDetalle++)
            {
                if (gridDetalle.Rows[filaDetalle].Cells[CANT.Name].Value.ToString().Length > 0)
                {
                    clFIG.FICDetalleInsertar(FIG, Convert.ToInt32(gridDetalle.Rows[filaDetalle].Cells[0].Value.ToString()), Convert.ToInt32(gridDetalle.Rows[filaDetalle].Cells[2].Value.ToString()), Convert.ToInt32(gridDetalle.Rows[filaDetalle].Cells[4].Value.ToString()), Convert.ToInt32(gridDetalle.Rows[filaDetalle].Cells[CANT.Name].Value.ToString()), "", 0, (int)gridDetalle[ccX.Name, filaDetalle].Value);
                }
            }
            gridDetalle1.DataSource = clFIG.ListarFIC(Convert.ToInt32(cboOC.SelectedValue.ToString()), 0);
            Actualiza(Convert.ToInt32(cboOC.SelectedValue.ToString()));

            if (txtRUC.Text.Length > 0)
            {
                CargraCombo();
            }

            if (FIG != 0)
            {
                msg("EL FIC Nº " + Convert.ToString(FIG) + " se generó con éxito");
            }
            string cadenita = txtRUC.Text;
            txtRUC.Text = "";
            txtRUC.Text = cadenita;
            txtRUC_TextChanged(sender, e);
        }

        private void txtRUC_TextChanged(object sender, EventArgs e)
        {
            CargraCombo();
        }

        private void CargraCombo()
        {
            cboOC.ValueMember = "numero";
            cboOC.DisplayMember = "ordencompra";

            DataTable ListaOCProveedor = clFIG.ListarOCProveedor(txtRUC.Text, 0, frmLogin.CodigoUsuario);
            if (ListaOCProveedor.Rows.Count > 0)
            {
                cboOC.DataSource = ListaOCProveedor;
            }
            else
            {
                LimpiarCombos();
                //LimpiarGrillas();
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
            DataTable tablitas = ((DataTable)gridDetalle.DataSource).Clone();
            gridDetalle.DataSource = tablitas;
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
            //gridDetalle.DataSource = null;
            //gridDetalle.Rows.Clear();
            //gridDetalle.Columns.Clear();
            //gridDetalle.Refresh();

            //gridDetalle1.DataSource = null;
            //gridDetalle1.Rows.Clear();
            //gridDetalle1.Columns.Clear();
            //gridDetalle1.Refresh();

            //gridDetalle2.DataSource = null;
            //gridDetalle2.Rows.Clear();
            //gridDetalle2.Columns.Clear();
            //gridDetalle2.Refresh();
        }

        private void frmAlmacen_FormClosing(object sender, FormClosingEventArgs e)
        {
            LimpiarCombos();
            // LimpiarGrillas();
        }

        private void TitulosGrillas()
        {
            if (gridDetalle.Columns.Count == 0)
            {
                gridDetalle.Columns.Add("CODIGOARTICULO", "CODIGOARTICULO");
                gridDetalle.Columns.Add("ITEM", "ITEM");
                gridDetalle.Columns.Add("CODIGOMARCA", "CODIGOMARCA");
                gridDetalle.Columns.Add("MARCA", "MARCA");
                gridDetalle.Columns.Add("CODIGOMODELO", "CODIGOMODELO");
                gridDetalle.Columns.Add("MODELO", "MODELO");
                gridDetalle.Columns.Add("SALDO", "SALDO");
                gridDetalle.Columns.Add("CANT", "CANT");
            }

            gridDetalle.Columns[0].Width = 0;
            gridDetalle.Columns[0].Visible = false;
            gridDetalle.Columns[0].DataPropertyName = "CODIGOARTICULO";

            gridDetalle.Columns[1].Width = 85;
            gridDetalle.Columns[1].Visible = true;
            gridDetalle.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridDetalle.Columns[1].HeaderText = "ITEM";
            gridDetalle.Columns[1].DataPropertyName = "ITEM";
            gridDetalle.Columns[1].ReadOnly = true;

            gridDetalle.Columns[2].Width = 0;
            gridDetalle.Columns[2].Visible = false;
            gridDetalle.Columns[2].DataPropertyName = "CODIGOMARCA";

            gridDetalle.Columns[3].Width = 85;
            gridDetalle.Columns[3].Visible = true;
            gridDetalle.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridDetalle.Columns[3].HeaderText = "MARCA";
            gridDetalle.Columns[3].DataPropertyName = "MARCA";
            gridDetalle.Columns[3].ReadOnly = true;

            gridDetalle.Columns[4].Width = 0;
            gridDetalle.Columns[4].Visible = false;
            gridDetalle.Columns[4].DataPropertyName = "CODIGOMODELO";

            gridDetalle.Columns[5].Width = 85;
            gridDetalle.Columns[5].Visible = true;
            gridDetalle.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridDetalle.Columns[5].HeaderText = "MODELO";
            gridDetalle.Columns[5].DataPropertyName = "MODELO";
            gridDetalle.Columns[5].ReadOnly = true;

            gridDetalle.Columns[6].Width = 90;
            gridDetalle.Columns[6].Visible = true;
            gridDetalle.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridDetalle.Columns[6].HeaderText = "SALDO";
            gridDetalle.Columns[6].DataPropertyName = "SALDO";
            gridDetalle.Columns[6].ReadOnly = true;

            gridDetalle.Columns[7].Width = 90;
            gridDetalle.Columns[7].Visible = true;
            gridDetalle.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridDetalle.Columns[7].HeaderText = "CANT";
            gridDetalle.Columns[7].DataPropertyName = "CANT";

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

        private void txtRUC_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtRUC, 11);
        }

        private void txtGR_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtGR, 10);
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void gridDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridDetalle.Rows.Count > 0 && gridDetalle.CurrentCell.ColumnIndex == 7)
            {
                TextBox txt = e.Control as TextBox;

                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(txtNumeros_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(txtNumeros_KeyPress);
                }
            }
        }

        private void PasarModificar()
        {
            if (gridDetalle1.Rows.Count > 0 && gridDetalle1.CurrentRow.Cells[FIC.Name].Value != null)
            {
                int x = gridDetalle2.CurrentRow.Index;
                frmFicModificar FICM = new frmFicModificar();
                FICM.FIC = Convert.ToInt32(gridDetalle1.CurrentRow.Cells[FIC.Name].Value.ToString().Substring(3));
                FICM.Fecha = Convert.ToDateTime(gridDetalle1.CurrentRow.Cells[FECHA.Name].Value.ToString());
                FICM.GuiaRemision = gridDetalle1.CurrentRow.Cells[NGR.Name].Value.ToString().Substring(2);
                FICM.Proveedor = txtRUC.Text;
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

                FICM.CentroCosto = gridDetalle2[centrocosto3.Name, x].Value.ToString();
                FICM.cc = (int)gridDetalle2[CC3.Name, x].Value;
                if (FICM.ShowDialog() == DialogResult.OK)
                {
                    Actualiza(Convert.ToInt32(cboOC.SelectedValue.ToString()));
                }

            }
        }

        private void gridDetalle1_DoubleClick(object sender, EventArgs e)
        {
            //PasarModificar();
        }

        private void gridDetalle2_DoubleClick(object sender, EventArgs e)
        {
            PasarModificar();
        }

        private int BuscarSaldo(int CodigoArticulo)
        {
            int FilaCodigo = 0;
            for (FilaCodigo = 0; FilaCodigo < gridDetalle.Rows.Count; FilaCodigo++)
            {
                if (gridDetalle[ccX.Name, FilaCodigo].Value.ToString() == gridDetalle2[CC3.Name, gridDetalle2.CurrentRow.Index].Value.ToString())
                    if (CodigoArticulo == Convert.ToInt32(gridDetalle.Rows[FilaCodigo].Cells[0].Value.ToString()))
                    {
                        return Convert.ToInt32(gridDetalle.Rows[FilaCodigo].Cells[SALDO.Name].Value.ToString());
                    }
            }
            return 0;
        }
        frmListarAlmacenArticulos frmlistar;
        private void btnlistar_Click(object sender, EventArgs e)
        {
            if (frmlistar == null)
            {
                frmlistar = new frmListarAlmacenArticulos();
                frmlistar.IdArticulo = 0;
                frmlistar.txtRUC.Text = txtRUC.Text;
                frmlistar.MdiParent = this.MdiParent;
                frmlistar.Icon = Icon;
                frmlistar.FormClosed += new FormClosedEventHandler(cerrarlistaralmacen);
                frmlistar.Show();
            }
            else
            {
                frmlistar.Activate();
                ValidarVentanas(frmlistar);
            }
        }
        void cerrarlistaralmacen(object sender, FormClosedEventArgs e)
        {
            frmlistar = null;
        }
        public void ValidarVentanas(Form formulario)
        {
            if (formulario.WindowState != FormWindowState.Normal)
                formulario.WindowState = FormWindowState.Normal;
            formulario.Left = (this.MdiParent.Width - formulario.Width) / 2;
            formulario.Top = ((this.MdiParent.Height - formulario.Height) / 2);
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