using System;
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
            txtRUC.Text = "";
            txtProveedor.Text = "";
            txtAdjunto.Text = "";
            txtImporte.Text = "";
            dtpFecha.Value = DateTime.Now.Date;

            pbFoto.Image = null;

            cboArea.ValueMember = "CODIGOAREA";
            cboArea.DisplayMember = "AREA";
            cboArea.DataSource = clCotizacion.ListarAreasUsuario(frmLogin.CodigoUsuario);

            if (cboArea.Items.Count > 0)
            {
                gridCotizacion.DataSource = clCotizacion.ListarPedidosCotizacion(Convert.ToInt32(cboArea.SelectedValue.ToString()), frmLogin.CodigoUsuario);
            }

            CargarMoneda();
            //gridCotizacion.DataSource = null;
            //gridCotizacion.Rows.Clear();
            //gridCotizacion.Refresh();
            //TitulosGrid(gridCotizacion, 0);

            //gridCotizacionesAsociadas.DataSource = null;
            // gridCotizacionesAsociadas.Rows.Clear();
            //gridCotizacionesAsociadas.Refresh();
            //TitulosGrid(gridCotizacionesAsociadas, 1);

            //System.Globalization.CultureInfo C = new System.Globalization.CultureInfo("EN-US");
            //Application.CurrentCulture = C;
        }

        private void cboArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboArea.SelectedIndex > -1)
            {
                gridCotizacion.DataSource = clCotizacion.ListarPedidosCotizacion(Convert.ToInt32(cboArea.SelectedValue.ToString()), frmLogin.CodigoUsuario);
            }
            else
            {
                //gridCotizacion.DataSource = null;
                gridCotizacion.Rows.Clear();
                gridCotizacion.Refresh();
                //TitulosGrid(gridCotizacion, 0);

                //gridCotizacionesAsociadas.DataSource = null;
                gridCotizacionesAsociadas.Rows.Clear();
                gridCotizacionesAsociadas.Refresh();
                //TitulosGrid(gridCotizacionesAsociadas, 1);

                pbFoto.Image = null;
            }
        }

        private void gridCotizacion_DoubleClick(object sender, EventArgs e)
        {
            //if (gridCotizacion.Rows.Count > 0 && gridCotizacion.Rows[Item].Cells[0].Value != null)
            //{
            //    frmOrdenPedidoCotizacion frmOPC = new frmOrdenPedidoCotizacion();
            //    frmOPC.Numero = Convert.ToInt32(gridCotizacion.Rows[Item].Cells[OP.Name].Value.ToString().Substring(2));
            //    frmOPC.Tipo = gridCotizacion.Rows[Item].Cells[TIPO_PEDIDO.Name].Value.ToString().Substring(0, 1);
            //    frmOPC.ShowDialog();
            //}
        }
        int filas = 0;
        private void gridCotizacion_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            filas = Item = e.RowIndex;
            MostrarPedidosAsociados(Item);
            if (gridCotizacionesAsociadas.RowCount > 0)
            {

                //gridCotizacionesAsociadas_RowEnter(sender, new DataGridViewCellEventArgs(0,0));     

            }
            else
            {
                txtRUC.Text = txtProveedor.Text = "";
                if (dtgpedido.DataSource != null)
                    dtgpedido.DataSource = ((DataTable)(dtgpedido.DataSource)).Clone();
            }
            //txtRUC_TextChanged(sender, e);
            //txtRUC_TextChanged(sender, e);
        }

        private void MostrarPedidosAsociados(int Itemsito)
        {
            dtCotizacionesAsociadas = clCotizacion.ListarCotizacionesAsociadas(Convert.ToInt32(gridCotizacion.Rows[Itemsito].Cells[OP.Name].Value.ToString().Substring(2)));
            if (dtCotizacionesAsociadas.Rows.Count > 0)
            {
                gridCotizacionesAsociadas.DataSource = dtCotizacionesAsociadas;
                //gridCotizacionesAsociadas.Select();
            }
            else
            {
                if (dtgpedido.DataSource != null)
                    dtgpedido.DataSource = ((DataTable)(dtgpedido.DataSource)).Clone();
                gridCotizacionesAsociadas.DataSource = ((DataTable)(gridCotizacionesAsociadas.DataSource)).Clone();
                //gridCotizacionesAsociadas.Rows.Clear();
                //gridCotizacionesAsociadas.Refresh();
                //TitulosGrid(gridCotizacionesAsociadas, 1);

                pbFoto.Image = null;
            }
            //txtRUC.Text = txtAdjunto.Text = txtImporte.Text = txtProveedor.Text = "";
            //Foto = null;
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        int articulo = 0; int señal = 0;
        private void btnAsociar_Click(object sender, EventArgs e)
        {
            señal = 0;
            if (cbomoneda.Items.Count <= 0)
            {
                msg("No hay tipos de monedas");
                cbomoneda.Focus();
                return;
            }
            if (cbomoneda.SelectedIndex < 0)
            {
                msg("Seleccione un tipo de Moneda");
                cbomoneda.Focus();
                return;
            }
            if (txtImporte.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Importe de la Cotización", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtImporte.Focus();
                return;
            }
            if (decimal.Parse(txtImporte.Text) == 0)
            {
                MSG("El importe esta en cero");
                return;
            }
            for (int i = 0; i < dtgpedido.RowCount; i++)
            {
                if (decimal.Parse(dtgpedido["totalx", i].Value.ToString()) == 0)
                {
                    MSG("El total del la línea " + (i + 1) + " esta en cero");
                    señal = 1;
                    break;
                }
            }
            if (señal == 1)
            {
                return;
            }
            if (txtProveedor.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Proveedor", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtRUC.Focus();
                return;
            }

            DataRow FechaActual = clCotizacion.FechaActual();
            if (dtpFecha.Value < Convert.ToDateTime(FechaActual["FECHA"].ToString()))
            {
                MessageBox.Show("Fecha de Entrega NO puede ser menor a Fecha Actual", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (gridCotizacionesAsociadas.Rows.Count > 0)
            {
                int filaBuscar = 0;
                for (filaBuscar = 0; filaBuscar < gridCotizacionesAsociadas.Rows.Count; filaBuscar++)
                {
                    if (gridCotizacionesAsociadas.Rows[filaBuscar].Cells[CODIGOPROVEEDOR.Name].Value.ToString().Trim() == txtRUC.Text.Trim().ToString())
                    {
                        MessageBox.Show("Proveedor ya fue Asociado", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    if (gridCotizacionesAsociadas.Rows[filaBuscar].Cells[ADJUNTO.Name].Value.ToString().Trim() == txtAdjunto.Text.Trim().ToString())
                    {
                        MessageBox.Show("Imagen ya fue Asociada", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
            }
            if (pbFoto.Image == null || txtAdjunto.Text.Length == 0)
            {
                MessageBox.Show("Seleccione Imagen de Cotización", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnBuscarPDF.Focus();
                return;
            }
            else
            {
                int NumeroCotizacion = 0;
                int TipoCotizacion = 0;

                if (gridCotizacion.Rows[Item].Cells[TIPO_PEDIDO.Name].Value.ToString().Substring(0, 1) == "S")
                {
                    TipoCotizacion = 1;
                }
                //insertar la cabeza
                clCotizacion.CotizacionCabeceraInsertar(out NumeroCotizacion, dtpFecha.Value, TipoCotizacion, Convert.ToInt32(gridCotizacion.Rows[Item].Cells[c.Name].Value.ToString()), Convert.ToDecimal(txtImporte.Text.ToString()), Convert.ToInt32(gridCotizacion.Rows[Item].Cells[OP.Name].Value.ToString().Substring(2)), txtRUC.Text, Foto, nombreArchivo, (int)cbomoneda.SelectedValue);
                //insertar el detalle
                if (dtgpedido[0, 0].Value.ToString() == "ARTICULO")
                    articulo = 1;
                else articulo = 0;
                if (articulo == 1)
                {//articulos
                    for (int i = 0; i < dtgpedido.RowCount; i++)
                    {
                        clCotizacion.CotizacionDetalleInsertar(NumeroCotizacion, Convert.ToInt32(gridCotizacion.Rows[Item].Cells[OP.Name].Value.ToString().Substring(2)), 1, int.Parse(dtgpedido["detallex", i].Value.ToString()), decimal.Parse(dtgpedido["preciounit", i].Value.ToString()), decimal.Parse(dtgpedido["totalx", i].Value.ToString()), dtgpedido["articulox", i].Value.ToString(), dtgpedido["marcax", i].Value.ToString(), dtgpedido["modelox", i].Value.ToString(), "ARTICULO");
                    }
                }
                else
                {//servicios
                    for (int i = 0; i < dtgpedido.RowCount; i++)
                    {
                        clCotizacion.CotizacionDetalleInsertar(NumeroCotizacion, Convert.ToInt32(gridCotizacion.Rows[Item].Cells[OP.Name].Value.ToString().Substring(2)), 0, 1, decimal.Parse(dtgpedido["preciounit", i].Value.ToString()), decimal.Parse(dtgpedido["totalx", i].Value.ToString()), dtgpedido["articulox", i].Value.ToString(), 1.ToString(), 1.ToString(), dtgpedido["detallex", i].Value.ToString());
                    }

                }
                //clCotizacion.CotizacionDetalleInsertar(NumeroCotizacion, Convert.ToInt32(gridCotizacion.Rows[Item].Cells[0].Value.ToString().Substring(2)));

                txtRUC.Text = "";
                txtProveedor.Text = "";
                txtImporte.Text = "";
                txtAdjunto.Text = "";
                pbFoto.Image = null;
                dtpFecha.Value = DateTime.Now;
                if (NumeroCotizacion != 0)
                {
                    MostrarPedidosAsociados(Item);
                    MessageBox.Show("Cotización Nº " + Convert.ToString(NumeroCotizacion) + " asociado al Pedido Nº " + gridCotizacion.Rows[Item].Cells[OP.Name].Value.ToString().Substring(2) + " se generó con éxito", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (gridCotizacionesAsociadas.Rows[Item].Cells[COT.Name].Value != null && gridCotizacionesAsociadas.Rows.Count > 0)
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
        int fila; int tipo;
        private void gridCotizacionesAsociadas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            CargarFoto(Convert.ToInt32(gridCotizacionesAsociadas.Rows[fila].Cells[COT.Name].Value.ToString().Substring(2)), fila);

            //dtgpedido.DataSource = clCotizacion.ListarPedidoProveedor(Int32.Parse(gridCotizacionesAsociadas["NOP", fila].Value.ToString().Substring(2)), gridCotizacionesAsociadas["CODIGOPROVEEDOR", fila].Value.ToString().TrimEnd());
            if (gridCotizacionesAsociadas.RowCount > 0)
            {
                dtpFecha.Value = DateTime.ParseExact(gridCotizacionesAsociadas["FECHAENTREGA", fila].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                cbomoneda.SelectedValue = (int)gridCotizacionesAsociadas[idmonedax.Name, fila].Value;
                txtRUC.Text = gridCotizacionesAsociadas["CODIGOPROVEEDOR", e.RowIndex].Value.ToString().TrimEnd();

                txtRUC_TextChanged(sender, e);
                //CalcularImporte();
            }
            else
            {
                txtRUC.Text = txtProveedor.Text = "";
            }
            //ValidarCargaDetalle();
        }
        public void ValidarCargaDetalle()
        {
            /// msg("y que dice");
            int f = filas;
            if (gridCotizacionesAsociadas.RowCount > 0)
            {
                if (gridCotizacion[TIPO_PEDIDO.Name, f].Value.ToString() == "ARTICULO")
                {
                    dtgpedido.Columns[detallex.Name].HeaderText = "Cant";
                    dtgpedido.Columns[Marcax.Name].Visible = true;
                    dtgpedido.Columns[modelox.Name].Visible = true;
                }
                else
                {
                    dtgpedido.Columns[detallex.Name].HeaderText = "Detalle";
                    dtgpedido.Columns[Marcax.Name].Visible = false;
                    dtgpedido.Columns[modelox.Name].Visible = false;
                }
                foreach (DataGridViewRow item in dtgpedido.Rows)
                {
                    //si no tiene numero de cotizacion
                    if ((int)item.Cells[numcotx.Name].Value == 0)
                    {
                        dtgpedido.Columns[numcotx.Name].Visible = false;
                        dtpFecha.Value = DateTime.Now.AddDays(1);
                    }
                    else
                        dtgpedido.Columns[numcotx.Name].Visible = true;
                }
            }
            else
            {
                //no tiene cotizaciones              
                if (gridCotizacion[TIPO_PEDIDO.Name, f].Value.ToString() == "ARTICULO")
                {
                    dtgpedido.Columns[detallex.Name].HeaderText = "Cant";
                    dtgpedido.Columns[Marcax.Name].Visible = true;
                    dtgpedido.Columns[numcotx.Name].Visible = false;
                    dtgpedido.Columns[modelox.Name].Visible = true;
                }
                else
                {
                    dtgpedido.Columns[detallex.Name].HeaderText = "Detalle";
                    dtgpedido.Columns[Marcax.Name].Visible = false;
                    dtgpedido.Columns[modelox.Name].Visible = false;
                    dtgpedido.Columns[numcotx.Name].Visible = false;
                }

            }
        }
        private void txtRUC_TextChanged(object sender, EventArgs e)
        {
            lsbproveedor.DataSource = clCotizacion.ListarProveedores(txtRUC.Text, 2);
            lsbproveedor.ValueMember = "ruc";
            lsbproveedor.DisplayMember = "ruc";
            DataRow drProveedor = clCotizacion.RUCProveedor(txtRUC.Text.TrimEnd());
            if (drProveedor != null)
            {
                dtgpedido.ReadOnly = false;

                txtProveedor.Text = drProveedor["razon_social"].ToString();
                lsbproveedor.Visible = false;
                //tiene cotizaciones
                if (gridCotizacionesAsociadas.RowCount > 0)
                {
                    //sitiene cotizaciones
                    if (gridCotizacionesAsociadas.CurrentCell != null)
                        dtgpedido.DataSource = clCotizacion.ListarPedidoProveedor(int.Parse(gridCotizacionesAsociadas["NOP", gridCotizacionesAsociadas.CurrentRow.Index].Value.ToString().Substring(2)), txtRUC.Text);
                    else
                        dtgpedido.DataSource = clCotizacion.ListarPedidoProveedor(int.Parse(gridCotizacionesAsociadas["NOP", 0].Value.ToString().Substring(2)), txtRUC.Text);

                }
                //no tiene cotizaciones
                else
                {
                    //no tiene cotizaciones
                    dtgpedido.DataSource = clCotizacion.ListarPedidoProveedor(int.Parse(gridCotizacion["op", gridCotizacion.CurrentCell.RowIndex].Value.ToString().Substring(2)), txtRUC.Text);                   
                }
                // ValidarCargaDetalle();
                //hay valores en el pedido
                if (dtgpedido.RowCount > 0)
                {
                    CalcularImporte();
                }
                //bloqueamos los que no vamos a usar
                //foreach (DataGridViewColumn item in dtgpedido.Columns)
                //{
                //    if (item.Name != Preciounit.Name)
                //    {
                //        item.ReadOnly = true;
                //    }
                //}
            }
            else
            {
                txtProveedor.Text = "";
                if (dtgpedido.DataSource != null)
                    dtgpedido.DataSource = ((DataTable)(dtgpedido.DataSource)).Clone();
                dtgpedido.ReadOnly = true;
            }
            ValidarCargaDetalle();
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void gridCotizacionesAsociadas_DoubleClick(object sender, EventArgs e)
        {
            //if (gridCotizacionesAsociadas.Rows.Count > 0 && gridCotizacionesAsociadas.CurrentRow.Cells[COT.Name].Value != null)
            //{
            //    frmCotizacionModificar frmCot = new frmCotizacionModificar();
            //    frmCot.Cotizacion = gridCotizacionesAsociadas.CurrentRow.Cells[COT.Name].Value.ToString();
            //    frmCot.Pedido = gridCotizacionesAsociadas.CurrentRow.Cells[NOP.Name].Value.ToString();
            //    frmCot.RUC = gridCotizacionesAsociadas.CurrentRow.Cells[CODIGOPROVEEDOR.Name].Value.ToString();
            //    frmCot.Proveedor = gridCotizacionesAsociadas.CurrentRow.Cells[PROVEEDOR.Name].Value.ToString();
            //    frmCot.Importe = gridCotizacionesAsociadas.CurrentRow.Cells[IMPORTE.Name].Value.ToString();
            //    frmCot.tipomoneda = (int)gridCotizacionesAsociadas.CurrentRow.Cells[idmonedax.Name].Value;
            //    frmCot.Itemsito = Item;
            //    frmCot.Itemsito2 = Item2;
            //    frmCot.Icon = Icon;

            //    DateTime Fecha = DateTime.ParseExact(gridCotizacionesAsociadas.CurrentRow.Cells[FECHAENTREGA.Name].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //    frmCot.FechaEntrega = Fecha;
            //    frmCot.Adjunto = gridCotizacionesAsociadas.CurrentRow.Cells[ADJUNTO.Name].Value.ToString();
            //    if (frmCot.ShowDialog() == DialogResult.OK)
            //    {
            //        MostrarPedidosAsociados(frmCot.Itemsito);
            //        if (gridCotizacionesAsociadas.Rows[Item2].Cells[COT.Name].Value != null && gridCotizacionesAsociadas.Rows.Count > 0)
            //        {
            //            if (Convert.ToInt32(gridCotizacionesAsociadas.CurrentRow.Cells[COT.Name].Value.ToString().Substring(2)) == Convert.ToInt32(frmCot.Cotizacion))
            //            {
            //                CargarFoto(Convert.ToInt32(gridCotizacionesAsociadas.Rows[frmCot.Itemsito2].Cells[COT.Name].Value.ToString().Substring(2)), frmCot.Itemsito2);
            //            }
            //            else
            //            {
            //                CargarFoto(Convert.ToInt32(gridCotizacionesAsociadas.CurrentRow.Cells[COT.Name].Value.ToString().Substring(2)), Item2);
            //            }
            //        }
            //    }
            //}
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
                Grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                Grid.Columns[1].Width = 50;
                Grid.Columns[1].Visible = true;
                Grid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid.Columns[1].HeaderText = "Nº OP";
                Grid.Columns[1].DataPropertyName = "PEDIDO";
                Grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                Grid.Columns[2].Width = 0;
                Grid.Columns[2].Visible = false;
                Grid.Columns[2].DataPropertyName = "CODIGOPROVEEDOR";

                Grid.Columns[3].Width = 200;
                Grid.Columns[3].Visible = true;
                Grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid.Columns[3].HeaderText = "PROVEEDOR";
                Grid.Columns[3].DataPropertyName = "PROVEEDOR";
                Grid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                Grid.Columns[4].Width = 70;
                Grid.Columns[4].Visible = true;
                Grid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid.Columns[4].HeaderText = "IMPORTE";
                Grid.Columns[4].DataPropertyName = "IMPORTE";
                Grid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                Grid.Columns[5].Width = 70;
                Grid.Columns[5].Visible = true;
                Grid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns[5].HeaderText = "FECHA ENTREGA";
                Grid.Columns[5].DataPropertyName = "FECHAENTREGA";
                Grid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                Grid.Columns[6].Width = 100;
                Grid.Columns[6].Visible = false;
                Grid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns[6].HeaderText = "ADJUNTO";
                Grid.Columns[6].DataPropertyName = "ADJUNTO";
            }
        }

        private void txtRUC_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtRUC, 11);
        }

        private void txtImporte_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txtImporte);
        }

        private void lsbproveedor_Click(object sender, EventArgs e)
        {
            txtRUC.Text = lsbproveedor.Text.TrimEnd((char)32);
            lsbproveedor.Visible = false;
        }
        private void lsbproveedor_MouseLeave(object sender, EventArgs e)
        {
            lsbproveedor.Visible = false;
        }
        private void gridCotizacionesAsociadas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                gridCotizacion.ClearSelection();
                dtgpedido.ClearSelection();
                if (DialogResult.Yes == msgP("Desea Eliminar COTIZACIONES Asociadas"))
                {
                    foreach (DataGridViewRow item in gridCotizacionesAsociadas.SelectedRows)
                    {
                        clCotizacion.ELiminarCotizacionTotal(int.Parse(item.Cells[COT.Name].Value.ToString().Substring(2)));
                    }
                }
                btnactualizar_Click(sender, new EventArgs());
            }
        }
        private void gridCotizacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                dtgpedido.ClearSelection();
                gridCotizacionesAsociadas.ClearSelection();
                if (DialogResult.Yes == msgP("Desea dar de Bajas a las ORDENES DE PEDIDO Seleccionadas"))
                {
                    foreach (DataGridViewRow item in gridCotizacion.SelectedRows)
                    {
                        clCotizacion.AnularOrdenPedido(int.Parse(item.Cells[OP.Name].Value.ToString().Substring(2)));
                    }
                    btnactualizar_Click(sender, new EventArgs());
                }
            }
        }
        private void txtRUC_Click(object sender, EventArgs e)
        {
            lsbproveedor.Visible = true;
        }

        private void dtgpedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dtgpedido.EndEdit();
                // btnmas_Click(sender, e);
            }
            else { e.Handled = true; }
        }
        TextBox txt;
        private void dtgpedido_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // punto = deci = 0;
            if (dtgpedido.Columns["PrecioUnit"].Index == dtgpedido.CurrentCell.ColumnIndex)
            {
                txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(dataGridview_KeyPressCajita);
                    txt.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajita);
                }
            }
        }
        private void dataGridview_KeyPressCajita(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txt.Text);
        }
        public void MSG(string cadena)
        {
            MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        decimal sumatoria = 0, valor = 0, total = 0;

        private void dtgpedido_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dtgpedido_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalcularImporte();
        }

        private void btndescargar_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbFoto.Image != null)
                btndescargar.Visible = true;
        }

        private void pbFoto_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbFoto.Image != null)
                btndescargar.Visible = true;
        }

        private void frmCotizacion_MouseMove(object sender, MouseEventArgs e)
        {
            btndescargar.Visible = false;
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            HPResergerFunciones.Utilitarios.DescargarImagen(pbFoto);
        }

        private void pbFoto_DoubleClick(object sender, EventArgs e)
        {
            MostrarFoto(pbFoto);
        }
        public void MostrarFoto(PictureBox fotito)
        {
            if (fotito.Image != null)
            {
                FrmFoto foto = new FrmFoto($"Cotización de {txtProveedor.Text}");
                foto.fotito = fotito.Image;
                foto.Owner = this.MdiParent;
                foto.ShowDialog();
            }
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {

        }
        public void CargarMoneda()
        {
            cbomoneda.DataSource = clCotizacion.getCargoTipoContratacion("id_moneda", "moneda", "tbl_moneda");
            cbomoneda.DisplayMember = "descripcion";
            cbomoneda.ValueMember = "codigo";
        }
        private void cbomoneda_Click(object sender, EventArgs e)
        {
            string txt = cbomoneda.Text;
            CargarMoneda();
            cbomoneda.Text = txt;
        }

        private void cboArea_Click(object sender, EventArgs e)
        {
            cboArea_SelectedIndexChanged(sender, e);
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            cboArea_SelectedIndexChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gridCotizacionesAsociadas.CurrentRow != null)
            {
                int y = gridCotizacionesAsociadas.CurrentRow.Index, x = 0;
                gridCotizacionesAsociadas_CellContentDoubleClick(sender, new DataGridViewCellEventArgs(x, y));
            }
        }
        public DialogResult msgP(string cadena)
        {
            return MessageBox.Show(cadena, CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        private void gridCotizacion_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (gridCotizacion.IsCurrentCellDirty)
            {
                gridCotizacion.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        public Boolean ValidarSiCheck(DataGridView dtg, DataGridViewColumn columna)
        {
            Boolean resul = false;
            foreach (DataGridViewRow item in dtg.Rows)
            {
                if (item.Cells[columna.Name].Value != null)
                    if (Boolean.Parse(item.Cells[columna.Name].Value.ToString()) == true)
                        return true;
            }
            return resul;
        }
        private void btnborrarordenes_Click(object sender, EventArgs e)
        {
            if (ValidarSiCheck(gridCotizacion, BorrarOrdenx))
            {
                if (msgP("Desea Dar de Baja a las Ordenes de Pedido Seleccionadas") == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in gridCotizacion.Rows)
                    {
                        if (Boolean.Parse((item.Cells[BorrarOrdenx.Name].Value ?? "false").ToString()))
                            clCotizacion.AnularOrdenPedido(int.Parse(item.Cells[OP.Name].Value.ToString().Substring(2)));
                    }
                    btnactualizar_Click(sender, new EventArgs());
                    MSG("Ordenes de Pedido dadas de Baja con Exito");
                }
            }
            else { MSG("No hay Ordenes de Pedido Selecionadas"); }
        }
        private void gridCotizacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                if (gridCotizacion.RowCount > 0)
                {
                    Boolean valor = Boolean.Parse((gridCotizacion[BorrarOrdenx.Name, 0].Value ?? "false").ToString());
                    foreach (DataGridViewRow item in gridCotizacion.Rows)
                    {
                        item.Cells[BorrarOrdenx.Name].Value = !valor;
                    }
                    gridCotizacion.RefreshEdit();
                }
            }
            else
            {
                if (gridCotizacion.Rows.Count > 0 && gridCotizacion.Rows[Item].Cells[OP.Name].Value != null)
                {
                    frmOrdenPedidoCotizacion frmOPC = new frmOrdenPedidoCotizacion();
                    frmOPC.Numero = Convert.ToInt32(gridCotizacion.Rows[Item].Cells[OP.Name].Value.ToString().Substring(2));
                    frmOPC.Tipo = gridCotizacion.Rows[Item].Cells[TIPO_PEDIDO.Name].Value.ToString().Substring(0, 1);
                    frmOPC.ShowDialog();
                }
            }
        }
        private void gridCotizacionesAsociadas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                if (gridCotizacionesAsociadas.RowCount > 0)
                {
                    Boolean valor = Boolean.Parse((gridCotizacionesAsociadas[borrarcotizacionesx.Name, 0].Value ?? "false").ToString());
                    foreach (DataGridViewRow item in gridCotizacionesAsociadas.Rows)
                    {
                        item.Cells[borrarcotizacionesx.Name].Value = !valor;
                    }
                    gridCotizacionesAsociadas.RefreshEdit();
                }
            }
            else
            {
                if (gridCotizacionesAsociadas.Rows.Count > 0 && gridCotizacionesAsociadas.CurrentRow.Cells[COT.Name].Value != null)
                {
                    frmCotizacionModificar frmCot = new frmCotizacionModificar();
                    frmCot.Cotizacion = gridCotizacionesAsociadas.CurrentRow.Cells[COT.Name].Value.ToString();
                    frmCot.Pedido = gridCotizacionesAsociadas.CurrentRow.Cells[NOP.Name].Value.ToString();
                    frmCot.RUC = gridCotizacionesAsociadas.CurrentRow.Cells[CODIGOPROVEEDOR.Name].Value.ToString();
                    frmCot.Proveedor = gridCotizacionesAsociadas.CurrentRow.Cells[PROVEEDOR.Name].Value.ToString();
                    frmCot.Importe = gridCotizacionesAsociadas.CurrentRow.Cells[IMPORTE.Name].Value.ToString();
                    frmCot.tipomoneda = (int)gridCotizacionesAsociadas.CurrentRow.Cells[idmonedax.Name].Value;
                    frmCot.Itemsito = Item;
                    frmCot.Itemsito2 = Item2;
                    frmCot.Icon = Icon;
                    DateTime Fecha = DateTime.ParseExact(gridCotizacionesAsociadas.CurrentRow.Cells[FECHAENTREGA.Name].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    frmCot.FechaEntrega = Fecha;
                    frmCot.Adjunto = gridCotizacionesAsociadas.CurrentRow.Cells[ADJUNTO.Name].Value.ToString();
                    if (frmCot.ShowDialog() == DialogResult.OK)
                    {
                        MostrarPedidosAsociados(frmCot.Itemsito);
                        if (gridCotizacionesAsociadas.Rows[Item2].Cells[COT.Name].Value != null && gridCotizacionesAsociadas.Rows.Count > 0)
                        {
                            if (Convert.ToInt32(gridCotizacionesAsociadas.CurrentRow.Cells[COT.Name].Value.ToString().Substring(2)) == Convert.ToInt32(frmCot.Cotizacion))
                            {
                                CargarFoto(Convert.ToInt32(gridCotizacionesAsociadas.Rows[frmCot.Itemsito2].Cells[COT.Name].Value.ToString().Substring(2)), frmCot.Itemsito2);
                            }
                            else
                            {
                                CargarFoto(Convert.ToInt32(gridCotizacionesAsociadas.CurrentRow.Cells[COT.Name].Value.ToString().Substring(2)), Item2);
                            }
                        }
                    }
                }
            }
        }
        private void btnborrarcotizaciones_Click(object sender, EventArgs e)
        {
            if (ValidarSiCheck(gridCotizacionesAsociadas, borrarcotizacionesx))
            {
                if (msgP("Desea Eliminar Cotizaciones Seleccionadas") == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in gridCotizacionesAsociadas.Rows)
                    {
                        if (Boolean.Parse((item.Cells[borrarcotizacionesx.Name].Value ?? "false").ToString()))
                            clCotizacion.ELiminarCotizacionTotal(int.Parse(item.Cells[COT.Name].Value.ToString().Substring(2)));
                    }
                    btnactualizar_Click(sender, new EventArgs());
                    MSG("Cotizaciones Eliminadas con Exito");
                }
            }
            else { MSG("No hay Cotizaciones Seleccionadas"); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (gridCotizacion.CurrentRow != null)
            {
                int x = 0, y = gridCotizacion.CurrentRow.Index;
                gridCotizacion_CellDoubleClick(sender, new DataGridViewCellEventArgs(x, y));
            }
        }

        private void dtgpedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgpedido.Columns["PrecioUnit"].Index != e.ColumnIndex && e.RowIndex > -1)
            {
                dtgpedido[e.ColumnIndex, e.RowIndex].ReadOnly = true;
            }
        }

        private void CalcularImporte()
        {
            dtgpedido.Columns[Preciounit.Name].DefaultCellStyle.Format = "N2";
            dtgpedido.Columns[totalx.Name].DefaultCellStyle.Format = "N2";
            sumatoria = valor = total = 0;
            if (dtgpedido["tipox", 0].Value.ToString() == "ARTICULO")
            {
                for (int i = 0; i < dtgpedido.RowCount; i++)
                {
                    valor = Convert.ToDecimal(dtgpedido["PrecioUnit", i].Value.ToString());
                    total = valor * Convert.ToDecimal(dtgpedido[detallex.Name, i].Value.ToString());
                    dtgpedido["PrecioUnit", i].Value = valor;// decimal.Round(valor, 2);
                    dtgpedido["Totalx", i].Value = total;//decimal.Round(total, 2);
                    sumatoria += total;
                }
                txtImporte.Text = string.Format("{0:N2}", sumatoria);
            }
            else
            {
                for (int i = 0; i < dtgpedido.RowCount; i++)
                {
                    valor = Convert.ToDecimal(dtgpedido["PrecioUnit", i].Value.ToString());
                    dtgpedido["PrecioUnit", i].Value = valor;// decimal.Round(valor, 2);
                    dtgpedido["Totalx", i].Value = valor;// decimal.Round(valor, 2);
                    sumatoria += valor;
                }
                txtImporte.Text = string.Format("{0:N2}", sumatoria);
            }
        }
    }
}