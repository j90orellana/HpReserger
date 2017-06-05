﻿using System;
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
    public partial class frmListarOrdenesPedido : Form
    {
        HPResergerCapaLogica.HPResergerCL clListarPedido = new HPResergerCapaLogica.HPResergerCL();
        public int ItemListar { get; set; }

        public frmListarOrdenesPedido()
        {
            InitializeComponent();
        }

        private void rbtArticulo_Click(object sender, EventArgs e)
        {
            if(rbtArticulo.Checked == true)
            {
                txtArticulos.Text = "";
                txtServicios.Text = "";
                txtArticulos.Enabled = true;
                rbtServicios.Checked = false;
                txtServicios.Enabled = false;

                rbtFechas.Checked = false;
                dtpDesde.Enabled = false;
                dtpHasta.Enabled = false;
                dtpDesde.Value = DateTime.Today.Date;
                dtpHasta.Value = DateTime.Today.Date;

                txtArticulos.Focus();
                Limpiar();
                TitulosGrid(gridListar, "L");
                TitulosGrid(gridDetalle, "A");
            }
        }

        private void rbtServicios_Click(object sender, EventArgs e)
        {
            if (rbtServicios.Checked == true)
            {
                txtServicios.Text = "";
                txtArticulos.Text = "";
                rbtArticulo.Checked = false;
                txtServicios.Enabled = true;
                txtArticulos.Enabled = false;

                rbtFechas.Checked = false;
                dtpDesde.Enabled = false;
                dtpHasta.Enabled = false;
                dtpDesde.Value = DateTime.Today.Date;
                dtpHasta.Value = DateTime.Today.Date;

                txtServicios.Focus();
                Limpiar();
                TitulosGrid(gridListar, "L");
                TitulosGrid(gridDetalle, "S");
            }
        }

        private void rbtFechas_Click(object sender, EventArgs e)
        {
            if (rbtFechas.Checked == true)
            {
                txtServicios.Text = "";
                rbtServicios.Checked = false;
                txtServicios.Enabled = false;

                txtArticulos.Text = "";
                rbtArticulo.Checked = false;
                txtArticulos.Enabled = false;

                rbtFechas.Checked = true;
                dtpDesde.Enabled = true;
                dtpHasta.Enabled = true;
                dtpDesde.Value = DateTime.Today.Date;
                dtpHasta.Value = DateTime.Today.Date;

                dtpDesde.Focus();
                Limpiar();
                TitulosGrid(gridListar, "L");
                TitulosGrid(gridDetalle, "A");
            }
        }

        private void txtArticulos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnMostrar.Focus();
            }
        }

        private void txtServicios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnMostrar.Focus();
            }
        }

        private void MostrarPedidos(int Usuario)
        {
            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La Fecha Desde NO puede ser mayor a la Fecha Hasta", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dtpDesde.Focus();
                return;
            }

            DataTable ListarPedidos = new DataTable();
            if (rbtArticulo.Checked == true && rbtServicios.Checked == false && rbtFechas.Checked == false)
            {
                ListarPedidos = clListarPedido.ListarPedidos(0, txtArticulos.Text.Trim(), dtpDesde.Value, dtpHasta.Value.AddDays(1), Usuario);
                if (ListarPedidos != null && ListarPedidos.Rows.Count > 0)
                {
                    TitulosGrid(gridListar, "L");
                    gridListar.DataSource = ListarPedidos;
                }
                else
                {
                    Limpiar();
                    TitulosGrid(gridDetalle, "A");
                }
            }

            if (rbtArticulo.Checked == false && rbtServicios.Checked == true && rbtFechas.Checked == false)
            {
                ListarPedidos = clListarPedido.ListarPedidos(1, txtArticulos.Text.Trim(), dtpDesde.Value, dtpHasta.Value, Usuario);
                if (ListarPedidos != null && ListarPedidos.Rows.Count > 0)
                {
                    TitulosGrid(gridListar, "L");
                    gridListar.DataSource = ListarPedidos;
                }
                else
                {
                    Limpiar();
                    TitulosGrid(gridDetalle, "S");
                }
            }

            if (rbtArticulo.Checked == false && rbtServicios.Checked == false && rbtFechas.Checked == true)
            {
                ListarPedidos = clListarPedido.ListarPedidos(3, txtArticulos.Text.Trim(), dtpDesde.Value, dtpHasta.Value, Usuario);
                if (ListarPedidos != null && ListarPedidos.Rows.Count > 0)
                {
                    TitulosGrid(gridListar, "L");
                    gridListar.DataSource = ListarPedidos;
                }
                else
                {
                    Limpiar();
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarPedidos(frmLogin.CodigoUsuario);
        }

        private void Limpiar()
        {
            gridListar.DataSource = null;
            gridListar.Rows.Clear();
            gridListar.Refresh();

            gridDetalle.DataSource = null;
            gridDetalle.Rows.Clear();
            gridDetalle.Refresh();

            txtArticulos.Text = "";
            txtServicios.Text = "";
        }

        private void TitulosGrid(DataGridView Grid, string Tipo)
        {
            if (Tipo == "A")
            {
                if (Grid.Columns.Count == 0)
                {
                    Grid.Columns.Add("CODIGOARTICULO", "");
                    Grid.Columns.Add("ITEM", "");
                    Grid.Columns.Add("CODIGOMARCA", "");
                    Grid.Columns.Add("MARCA", "");
                    Grid.Columns.Add("CODIGOMODELO", "");
                    Grid.Columns.Add("MODELO", "");
                    Grid.Columns.Add("CANTIDAD", "");
                }

                Grid.Columns[0].Width = 0;
                Grid.Columns[0].Visible = false;
                Grid.Columns[0].DataPropertyName = "CODIGOARTICULO";

                Grid.Columns[1].Width = 180;
                Grid.Columns[1].Visible = true;
                Grid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid.Columns[1].HeaderText = "ITEM";
                Grid.Columns[1].DataPropertyName = "ITEM";

                Grid.Columns[2].Width = 0;
                Grid.Columns[2].Visible = false;
                Grid.Columns[2].DataPropertyName = "CODIGOMARCA";

                Grid.Columns[3].Width = 180;
                Grid.Columns[3].Visible = true;
                Grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid.Columns[3].HeaderText = "MARCA";
                Grid.Columns[3].DataPropertyName = "MARCA";

                Grid.Columns[4].Width = 0;
                Grid.Columns[4].Visible = false;
                Grid.Columns[4].DataPropertyName = "CODIGOMODELO";

                Grid.Columns[5].Width = 180;
                Grid.Columns[5].Visible = true;
                Grid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid.Columns[5].HeaderText = "MODELO";
                Grid.Columns[5].DataPropertyName = "MODELO";

                Grid.Columns[6].Width = 100;
                Grid.Columns[6].Visible = true;
                Grid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid.Columns[6].HeaderText = "CANTIDAD";
                Grid.Columns[6].DataPropertyName = "CANTIDAD";
            }

            if (Tipo == "S")
            {
                if (Grid.Columns.Count == 0)
                {
                    Grid.Columns.Add("CODIGOARTICULO", "");
                    Grid.Columns.Add("ITEM", "");
                    Grid.Columns.Add("CODIGOMARCA", "");
                    Grid.Columns.Add("MARCA", "");
                    Grid.Columns.Add("CODIGOMODELO", "");
                    Grid.Columns.Add("MODELO", "");
                    Grid.Columns.Add("CANTIDAD", "");
                }

                Grid.Columns[0].Width = 0;
                Grid.Columns[0].Visible = false;
                Grid.Columns[0].DataPropertyName = "CODIGOARTICULO";

                Grid.Columns[1].Width = 340;
                Grid.Columns[1].Visible = true;
                Grid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid.Columns[1].HeaderText = "ITEM";
                Grid.Columns[1].DataPropertyName = "ITEM";

                Grid.Columns[2].Width = 0;
                Grid.Columns[2].Visible = false;
                Grid.Columns[2].DataPropertyName = "CODIGOMARCA";

                Grid.Columns[3].Width = 0;
                Grid.Columns[3].Visible = false;
                Grid.Columns[3].DataPropertyName = "MARCA";

                Grid.Columns[4].Width = 0;
                Grid.Columns[4].Visible = false;
                Grid.Columns[4].DataPropertyName = "CODIGOMODELO";

                Grid.Columns[5].Width = 0;
                Grid.Columns[5].Visible = false;
                Grid.Columns[5].DataPropertyName = "MODELO";

                Grid.Columns[6].Width = 340;
                Grid.Columns[6].Visible = true;
                Grid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid.Columns[6].HeaderText = "OBSERVACIONES";
                Grid.Columns[6].DataPropertyName = "CANTIDAD";
                
            }

            if (Tipo == "L")
            {
                if (Grid.Columns.Count == 0)
                {
                    Grid.Columns.Add("TIPO", "");
                    Grid.Columns.Add("NUMERO", "");
                    Grid.Columns.Add("FECHA", "");
                    Grid.Columns.Add("ESTADO", "");
                }

                Grid.Columns[0].Width = 40;
                Grid.Columns[0].Visible = true;
                Grid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns[0].HeaderText = "TIPO";
                Grid.Columns[0].DataPropertyName = "TIPO";

                Grid.Columns[1].Width = 120;
                Grid.Columns[1].Visible = true;
                Grid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns[1].HeaderText = "NRO_OrdenPedido";
                Grid.Columns[1].DataPropertyName = "NUMERO";

                Grid.Columns[2].Width = 90;
                Grid.Columns[2].Visible = true;
                Grid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns[2].HeaderText = "FECHA";
                Grid.Columns[2].DataPropertyName = "FECHA";

                Grid.Columns[3].Width = 110;
                Grid.Columns[3].Visible = true;
                Grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns[3].HeaderText = "ESTADO";
                Grid.Columns[3].DataPropertyName = "ESTADO";

            }
        }

        private void gridListar_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gridListar.Rows[e.RowIndex].Cells[0].Value != null)
            {
                if (gridListar.Rows[e.RowIndex].Cells[0].Value.ToString() == "A")
                {
                    TitulosGrid(gridDetalle, "A");
                    gridDetalle.DataSource = clListarPedido.ListarOrdenPedido(Convert.ToInt32(gridListar.Rows[e.RowIndex].Cells[1].Value), "A");
                }
                else
                {
                    TitulosGrid(gridDetalle, "S");
                    gridDetalle.DataSource = clListarPedido.ListarOrdenPedido(Convert.ToInt32(gridListar.Rows[e.RowIndex].Cells[1].Value), "S");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (gridListar.Rows.Count > 0)
            {

                if (gridListar.CurrentRow.Cells[3].Value.ToString().Trim() == "COTIZADO" || gridListar.CurrentRow.Cells[3].Value.ToString().Trim() == "ANULADO" || gridListar.CurrentRow.Cells[3].Value.ToString().Trim() == "OC")
                {
                    MessageBox.Show("NO se puede Editar o Anular el Pedido", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (gridDetalle.Rows.Count > 0 && gridDetalle.Rows[0].Cells[1].Value.ToString() != null)
                {
                    frmArticuloModificar frmAM = new frmArticuloModificar();
                    frmAM.numero = Convert.ToInt32(gridListar.CurrentRow.Cells[1].Value.ToString());
                    frmAM.CodigoArticuloModificar = Convert.ToInt32(gridDetalle.CurrentRow.Cells[0].Value.ToString());
                    frmAM.ArticuloModificar = gridDetalle.CurrentRow.Cells[1].Value.ToString().Trim();
                    frmAM.CodigoMarcaModificar = Convert.ToInt32(gridDetalle.CurrentRow.Cells[2].Value.ToString());
                    frmAM.MarcaModificar = gridDetalle.CurrentRow.Cells[3].Value.ToString().Trim();
                    frmAM.CodigoModeloModificar = Convert.ToInt32(gridDetalle.CurrentRow.Cells[4].Value.ToString());
                    frmAM.ModeloModificar = gridDetalle.CurrentRow.Cells[5].Value.ToString().Trim();

                    if (gridListar.CurrentRow.Cells[0].Value.ToString() == "A")
                    {
                        frmAM.TipoArticuloModificar = 0;
                        frmAM.CantidadModificar = gridDetalle.CurrentRow.Cells[6].Value.ToString();
                    }
                    else
                    {
                        frmAM.TipoArticuloModificar = 1;
                        frmAM.ObservacionesModificar = gridDetalle.CurrentRow.Cells[6].Value.ToString();
                    }

                    if (frmAM.ShowDialog() == DialogResult.OK)
                    {
                        if (frmAM.Modo == 1)
                        {
                            gridDetalle.Rows[ItemListar].Cells[0].Value = frmAM.CodigoArticuloModificar;
                            gridDetalle.Rows[ItemListar].Cells[1].Value = frmAM.ArticuloModificar;

                            gridDetalle.Rows[ItemListar].Cells[2].Value = frmAM.CodigoMarcaModificar;
                            gridDetalle.Rows[ItemListar].Cells[3].Value = frmAM.MarcaModificar;

                            gridDetalle.Rows[ItemListar].Cells[4].Value = frmAM.CodigoModeloModificar;
                            gridDetalle.Rows[ItemListar].Cells[5].Value = frmAM.ModeloModificar;

                            if (gridListar.CurrentRow.Cells[0].Value.ToString() == "A")
                            {
                                gridDetalle.Rows[ItemListar].Cells[6].Value = frmAM.CantidadModificar;
                            }
                            else
                            {
                                gridDetalle.Rows[ItemListar].Cells[6].Value = frmAM.ObservacionesModificar;
                            }
                        }
                    }
                }
            }
        }

        private void gridDetalle_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ItemListar = e.RowIndex;
        }

        private void dtpDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dtpDesde.Focus();
            }
        }

        private void dtpHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnMostrar.Focus();
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (gridListar.Rows.Count > 0 && gridListar.CurrentRow.Cells[3].Value != null)
            {
                if (gridListar.CurrentRow.Cells[3].Value.ToString() == "COTIZADO" || gridListar.CurrentRow.Cells[3].Value.ToString() == "ANULADO" || gridListar.CurrentRow.Cells[3].Value.ToString().Trim() == "OC")
                {
                    MessageBox.Show("NO se puede Editar o Anular el Pedido", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (MessageBox.Show("¿ Seguro de anular Pedido Nº " + gridListar.CurrentRow.Cells[1].Value.ToString().Trim() + " ?","HP Reserger",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    clListarPedido.AnularOrdenPedido(Convert.ToInt32(gridListar.CurrentRow.Cells[1].Value.ToString()));
                    MostrarPedidos(frmLogin.CodigoUsuario);
                    MessageBox.Show("Pedido anulado","HP Reserger",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }
    }
}