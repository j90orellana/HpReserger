﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace HPReserger
{
    public partial class frmCotizacion : Form
    {
        HPResergerCapaLogica.HPResergerCL clCotizacion = new HPResergerCapaLogica.HPResergerCL();
        public int Item { get; set; }
        public int Item2 { get; set; }

        public byte[] Foto { get; set; }
        MemoryStream _memoryStream = new MemoryStream();
        public string nombreArchivo { get; set; }
        DataTable dtCotizacionesAsociadas;

        public frmCotizacion()
        {
            InitializeComponent();
        }

        private void frmCotizacion_Load(object sender, EventArgs e)
        {
            cboArea.ValueMember = "CODIGOAREA";
            cboArea.DisplayMember = "AREA";
            cboArea.DataSource = clCotizacion.ListarAreasUsuario(frmLogin.CodigoUsuario);

            txtRUC.Text = "";
            txtProveedor.Text = "";
            txtAdjunto.Text = "";
            txtImporte.Text = "";
            dtpFecha.Value = DateTime.Now.Date;

            gridCotizacion.DataSource = null;
            gridCotizacion.Rows.Clear();
            gridCotizacion.Refresh();
            TitulosGrid(gridCotizacion, 0);

            gridCotizacionesAsociadas.DataSource = null;
            gridCotizacionesAsociadas.Rows.Clear();
            gridCotizacionesAsociadas.Refresh();
            //TitulosGrid(gridCotizacionesAsociadas, 1);

            pbFoto.Image = null;

            if (cboArea.Items.Count > 0)
            {
                gridCotizacion.DataSource = clCotizacion.ListarPedidosCotizacion(Convert.ToInt32(cboArea.SelectedValue.ToString()), frmLogin.CodigoUsuario);
            }

            System.Globalization.CultureInfo C = new System.Globalization.CultureInfo("EN-US");
            Application.CurrentCulture = C;
        }

        private void cboArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboArea.SelectedIndex > -1)
            {
                gridCotizacion.DataSource = clCotizacion.ListarPedidosCotizacion(Convert.ToInt32(cboArea.SelectedValue.ToString()), frmLogin.CodigoUsuario);
            }
            else
            {
                gridCotizacion.DataSource = null;
                gridCotizacion.Rows.Clear();
                gridCotizacion.Refresh();
                TitulosGrid(gridCotizacion, 0);

                gridCotizacionesAsociadas.DataSource = null;
                gridCotizacionesAsociadas.Rows.Clear();
                gridCotizacionesAsociadas.Refresh();
                TitulosGrid(gridCotizacionesAsociadas, 1);

                pbFoto.Image = null;
            }
        }

        private void gridCotizacion_DoubleClick(object sender, EventArgs e)
        {
            if (gridCotizacion.Rows.Count > 0 && gridCotizacion.Rows[Item].Cells[0].Value != null)
            {
                frmOrdenPedidoCotizacion frmOPC = new frmOrdenPedidoCotizacion();
                frmOPC.Numero = Convert.ToInt32(gridCotizacion.Rows[Item].Cells[0].Value.ToString().Substring(2));
                frmOPC.Tipo = gridCotizacion.Rows[Item].Cells[5].Value.ToString().Substring(0, 1);

                frmOPC.ShowDialog();
            }
        }

        private void gridCotizacion_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Item = e.RowIndex;
            MostrarPedidosAsociados(Item);
        }

        private void MostrarPedidosAsociados(int Itemsito)
        {
            dtCotizacionesAsociadas = clCotizacion.ListarCotizacionesAsociadas(Convert.ToInt32(gridCotizacion.Rows[Itemsito].Cells[0].Value.ToString().Substring(2)));
            if (dtCotizacionesAsociadas.Rows.Count > 0)
            {
                gridCotizacionesAsociadas.DataSource = dtCotizacionesAsociadas;
            }
            else
            {
                gridCotizacionesAsociadas.DataSource = null;
                gridCotizacionesAsociadas.Rows.Clear();
                gridCotizacionesAsociadas.Refresh();
                TitulosGrid(gridCotizacionesAsociadas, 1);

                pbFoto.Image = null;
            }
            txtRUC.Text = txtAdjunto.Text = txtImporte.Text = txtProveedor.Text = "";
            Foto = null; 
        }

        private void btnAsociar_Click(object sender, EventArgs e)
        {
            if (txtImporte.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Importe de la Cotización", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtImporte.Focus();
                return;
            }
            if (txtProveedor.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Proveedor", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtRUC.Focus();
                return;
            }

            DataRow FechaActual = clCotizacion.FechaActual();
            if (dtpFecha.Value < Convert.ToDateTime(FechaActual["FECHA"].ToString()))
            {
                MessageBox.Show("Fecha de Entrega NO puede ser menor a Fecha Actual", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (gridCotizacionesAsociadas.Rows.Count > 0)
            {
                int filaBuscar = 0;
                for (filaBuscar = 0; filaBuscar < gridCotizacionesAsociadas.Rows.Count; filaBuscar++)
                {
                    if (gridCotizacionesAsociadas.Rows[filaBuscar].Cells[2].Value.ToString().Trim() == txtRUC.Text.Trim().ToString())
                    {
                        MessageBox.Show("Proveedor ya fue Asociado", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    if (gridCotizacionesAsociadas.Rows[filaBuscar].Cells[6].Value.ToString().Trim() == txtAdjunto.Text.Trim().ToString())
                    {
                        MessageBox.Show("Imagen ya fue Asociada", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
            }
            if (pbFoto.Image == null || txtAdjunto.Text.Length == 0)
            {
                MessageBox.Show("Seleccione Imagen de Cotización", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnBuscarPDF.Focus();
                return;
            }
            else
            {
                int NumeroCotizacion = 0;
                int TipoCotizacion = 0;

                if (gridCotizacion.Rows[Item].Cells[5].Value.ToString().Substring(0, 1) == "S")
                {
                    TipoCotizacion = 1;
                }
                clCotizacion.CotizacionCabeceraInsertar(out NumeroCotizacion, dtpFecha.Value, TipoCotizacion, Convert.ToInt32(gridCotizacion.Rows[Item].Cells[1].Value.ToString()), Convert.ToDecimal(txtImporte.Text.ToString()), Convert.ToInt32(gridCotizacion.Rows[Item].Cells[0].Value.ToString().Substring(2)), txtRUC.Text, Foto, nombreArchivo);
                clCotizacion.CotizacionDetalleInsertar(NumeroCotizacion, Convert.ToInt32(gridCotizacion.Rows[Item].Cells[0].Value.ToString().Substring(2)));
                txtRUC.Text = "";
                txtProveedor.Text = "";
                txtImporte.Text = "";
                txtAdjunto.Text = "";
                pbFoto.Image = null;
                dtpFecha.Value = DateTime.Now;
                if (NumeroCotizacion != 0)
                {
                    MostrarPedidosAsociados(Item);
                    MessageBox.Show("Cotización Nº " + Convert.ToString(NumeroCotizacion) + " asociado al Pedido Nº " + gridCotizacion.Rows[Item].Cells[0].Value.ToString().Substring(2) + " se generó con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtImporte.Text.ToString());
        }

        private void btnBuscarPDF_Click(object sender, EventArgs e)
        {
            var dialogoAbrirArchivo = new OpenFileDialog();
            dialogoAbrirArchivo.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivo.DefaultExt = ".jpg";
            dialogoAbrirArchivo.ShowDialog(this);

            nombreArchivo = dialogoAbrirArchivo.FileName.ToString();
            if (nombreArchivo != string.Empty)
            {
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;

                pbFoto.Image = Image.FromFile(nombreArchivo);
                pbFoto.Image.Save(_memoryStream, ImageFormat.Jpeg);
                Foto = File.ReadAllBytes(dialogoAbrirArchivo.FileName);
                txtAdjunto.Text = nombreArchivo;
            }
        }

        private void CargarFoto(int Cotizacion, int Item)
        {
            if (gridCotizacionesAsociadas.Rows[Item].Cells[0].Value != null && gridCotizacionesAsociadas.Rows.Count > 0)
            {
                DataRow drFoto = clCotizacion.CargarImagenCotizacion(Cotizacion);
                if (drFoto["Foto"] != null && drFoto["Foto"].ToString().Length > 0)
                {
                    byte[] Fotito = new byte[0];
                    Fotito = (byte[])drFoto["Foto"];
                    MemoryStream ms = new MemoryStream(Fotito);
                    pbFoto.Image = Bitmap.FromStream(ms);
                }
                else
                {
                    pbFoto.Image = null;
                }
            }
            else
            {
                pbFoto.Image = null;
            }
        }

        private void gridCotizacionesAsociadas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Item2 = e.RowIndex;
            CargarFoto(Convert.ToInt32(gridCotizacionesAsociadas.Rows[e.RowIndex].Cells[0].Value.ToString().Substring(2)), e.RowIndex);
        }

        private void txtRUC_TextChanged(object sender, EventArgs e)
        {
            DataRow drProveedor = clCotizacion.RUCProveedor(txtRUC.Text.Trim());
            if (drProveedor != null)
            {
                txtProveedor.Text = drProveedor["razon_social"].ToString();
            }
            else
            {
                txtProveedor.Text = null;
            }
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void gridCotizacionesAsociadas_DoubleClick(object sender, EventArgs e)
        {
            if (gridCotizacionesAsociadas.Rows.Count > 0 && gridCotizacionesAsociadas.CurrentRow.Cells[0].Value != null)
            {
                frmCotizacionModificar frmCot = new frmCotizacionModificar();
                frmCot.Cotizacion = gridCotizacionesAsociadas.CurrentRow.Cells[0].Value.ToString();
                frmCot.Pedido = gridCotizacionesAsociadas.CurrentRow.Cells[1].Value.ToString();
                frmCot.RUC = gridCotizacionesAsociadas.CurrentRow.Cells[2].Value.ToString();
                frmCot.Proveedor = gridCotizacionesAsociadas.CurrentRow.Cells[3].Value.ToString();
                frmCot.Importe = gridCotizacionesAsociadas.CurrentRow.Cells[4].Value.ToString();
                frmCot.Itemsito = Item;
                frmCot.Itemsito2 = Item2;

                DateTime Fecha = DateTime.ParseExact(gridCotizacionesAsociadas.CurrentRow.Cells[5].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                frmCot.FechaEntrega = Fecha;

                frmCot.Adjunto = gridCotizacionesAsociadas.CurrentRow.Cells[6].Value.ToString();

                if (frmCot.ShowDialog() == DialogResult.OK)
                {
                    MostrarPedidosAsociados(frmCot.Itemsito);
                    if (gridCotizacionesAsociadas.Rows[Item2].Cells[0].Value != null && gridCotizacionesAsociadas.Rows.Count > 0)
                    {
                        if (Convert.ToInt32(gridCotizacionesAsociadas.CurrentRow.Cells[0].Value.ToString().Substring(2)) == Convert.ToInt32(frmCot.Cotizacion))
                        {
                            CargarFoto(Convert.ToInt32(gridCotizacionesAsociadas.Rows[frmCot.Itemsito2].Cells[0].Value.ToString().Substring(2)), frmCot.Itemsito2);
                        }
                        else
                        {
                            CargarFoto(Convert.ToInt32(gridCotizacionesAsociadas.CurrentRow.Cells[0].Value.ToString().Substring(2)), Item2);
                        }
                    }
                }
            }
        }

        private void gridCotizacionesAsociadas_KeyDown(object sender, KeyEventArgs e)
        {
            if (gridCotizacionesAsociadas.Rows.Count > 0 && gridCotizacionesAsociadas.CurrentRow.Cells[0].Value != null)
            {
                if (e.KeyValue == (char)(Keys.Delete))
                {
                    DataRow TieneOC = clCotizacion.CotTieneOC(Convert.ToInt32(gridCotizacionesAsociadas.CurrentRow.Cells[0].Value.ToString().Substring(2)));
                    if (TieneOC != null)
                    {
                        MessageBox.Show("NO se puede eliminar Cotización, está anexada a una OC", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("¿ Seguro de eliminar la Cotización Nº " + gridCotizacionesAsociadas.CurrentRow.Cells[0].Value.ToString().Substring(2) + " ?", "HP Reserger", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            clCotizacion.AnularCotizacion(Convert.ToInt32(gridCotizacionesAsociadas.CurrentRow.Cells[0].Value.ToString().Substring(2)));
                            MostrarPedidosAsociados(Item);
                        }
                    }
                }
            }
        }

        private void TitulosGrid(DataGridView Grid, int Tipo)
        {
            if (Tipo == 0)
            {
                if (Grid.Columns.Count == 0)
                {
                    Grid.Columns.Add("OP", "");
                    Grid.Columns.Add("C", "");
                    Grid.Columns.Add("USUARIO", "");
                    Grid.Columns.Add("AREA", "");
                    Grid.Columns.Add("GERENCIA", "");
                    Grid.Columns.Add("TIPO_PEDIDO", "");
                }

                Grid.Columns[0].Width = 70;
                Grid.Columns[0].Visible = true;
                Grid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns[0].HeaderText = "Nº OP";
                Grid.Columns[0].DataPropertyName = "OP";

                Grid.Columns[1].Width = 0;
                Grid.Columns[1].Visible = false;
                Grid.Columns[1].DataPropertyName = "CODIGOUSUARIO";

                Grid.Columns[2].Width = 80;
                Grid.Columns[2].Visible = true;
                Grid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid.Columns[2].HeaderText = "USUARIO";
                Grid.Columns[2].DataPropertyName = "USUARIO";

                Grid.Columns[3].Width = 200;
                Grid.Columns[3].Visible = true;
                Grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid.Columns[3].HeaderText = "AREA";
                Grid.Columns[3].DataPropertyName = "AREA";

                Grid.Columns[4].Width = 100;
                Grid.Columns[4].Visible = true;
                Grid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid.Columns[4].HeaderText = "GERENCIA";
                Grid.Columns[4].DataPropertyName = "GERENCIA";

                Grid.Columns[5].Width = 90;
                Grid.Columns[5].Visible = true;
                Grid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns[5].HeaderText = "TIPO PEDIDO";
                Grid.Columns[5].DataPropertyName = "TIPO_PEDIDO";
            }

            if (Tipo == 1)
            {
                if (Grid.Columns.Count == 0)
                {
                    Grid.Columns.Add("COT", "");
                    Grid.Columns.Add("NOP", "");
                    Grid.Columns.Add("CODIGOPROVEEDOR", "");
                    Grid.Columns.Add("PROVEEDOR", "");
                    Grid.Columns.Add("IMPORTE", "");
                    Grid.Columns.Add("FECHAENTREGA", "");
                    Grid.Columns.Add("ADJUNTO", "");
                }

                Grid.Columns[0].Width = 50;
                Grid.Columns[0].Visible = true;
                Grid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid.Columns[0].HeaderText = "Nº COT";
                Grid.Columns[0].DataPropertyName = "COTIZACION";

                Grid.Columns[1].Width = 50;
                Grid.Columns[1].Visible = true;
                Grid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid.Columns[1].HeaderText = "Nº OP";
                Grid.Columns[1].DataPropertyName = "PEDIDO";

                Grid.Columns[2].Width = 0;
                Grid.Columns[2].Visible = false;
                Grid.Columns[2].DataPropertyName = "CODIGOPROVEEDOR";

                Grid.Columns[3].Width = 200;
                Grid.Columns[3].Visible = true;
                Grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid.Columns[3].HeaderText = "PROVEEDOR";
                Grid.Columns[3].DataPropertyName = "PROVEEDOR";

                Grid.Columns[4].Width = 70;
                Grid.Columns[4].Visible = true;
                Grid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid.Columns[4].HeaderText = "IMPORTE";
                Grid.Columns[4].DataPropertyName = "IMPORTE";

                Grid.Columns[5].Width = 70;
                Grid.Columns[5].Visible = true;
                Grid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns[5].HeaderText = "FECHA ENTREGA";
                Grid.Columns[5].DataPropertyName = "FECHAENTREGA";

                Grid.Columns[6].Width = 100;
                Grid.Columns[6].Visible = true;
                Grid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns[6].HeaderText = "ADJUNTO";
                Grid.Columns[6].DataPropertyName = "ADJUNTO";
            }
        }

        private void txtRUC_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtRUC, 15);
        }

        private void txtImporte_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txtImporte);
        }
    }
}