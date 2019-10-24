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
using HpResergerUserControls;

namespace HPReserger
{
    public partial class frmCotizacionModificar : FormGradient
    {
        HPResergerCapaLogica.HPResergerCL clModificarCotizacion = new HPResergerCapaLogica.HPResergerCL();
        public string Cotizacion { get; set; }
        public string Pedido { get; set; }
        public string RUC { get; set; }
        public string Proveedor { get; set; }
        public string Importe { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Adjunto { get; set; }
        public byte[] Foto { get; set; }
        MemoryStream _memoryStream = new MemoryStream();
        public string nombreArchivo { get; set; }
        public int Itemsito { get; set; }
        public int Itemsito2 { get; set; }
        public int tipomoneda { get; set; }

        public frmCotizacionModificar()
        {
            InitializeComponent();
        }
        public void CargarMoneda()
        {
            cbomoneda.DataSource = clModificarCotizacion.getCargoTipoContratacion("id_moneda", "moneda", "tbl_moneda");
            cbomoneda.DisplayMember = "descripcion";
            cbomoneda.ValueMember = "codigo";
        }
        private void cbomoneda_Click(object sender, EventArgs e)
        {
            string txt = cbomoneda.Text;
            CargarMoneda();
            cbomoneda.Text = txt;
        }
        // HPResergerCapaLogica.HPResergerCL ClModificarCotizacion = new HPResergerCapaLogica.HPResergerCL();
        int TipoArticulo = 0;
        private void frmCotizacionModificar_Load(object sender, EventArgs e)
        {
            CargarMoneda();
            cbomoneda.SelectedValue = tipomoneda;
            txtCotizacion.Text = Cotizacion;
            txtPedido.Text = Pedido;
            txtRUC.Text = RUC;
            txtProveedor.Text = Proveedor;
            txtImporte.Text = Importe;
            dtpFecha.Value = new DateTime(FechaEntrega.Year, FechaEntrega.Month, FechaEntrega.Day);
            txtAdjunto.Text = Adjunto;

            if (txtCotizacion.Text.Length > 0)
            {
                DataRow drFoto = clModificarCotizacion.CargarImagenCotizacion(Convert.ToInt32(txtCotizacion.Text.Substring(2)));
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
            dtgpedidoX.DataSource = clModificarCotizacion.listar_Detalle_Cotizacion(int.Parse(txtPedido.Text.Substring(2)), txtRUC.Text);
            dtgpedidoY.DataSource = clModificarCotizacion.listar_Detalle_Cotizacion(int.Parse(txtPedido.Text.Substring(2)), txtRUC.Text);
            if (dtgpedidoX.RowCount > 0)
            {
                if (dtgpedidoX["tipox", 0].Value.ToString() == "ARTICULO")
                {
                    dtgpedidoX.Visible = false;
                    dtgpedidoY.Visible = true;
                    TipoArticulo = 0;
                }
                else
                {
                    TipoArticulo = 1;
                    dtgpedidoX.Visible = true;
                    dtgpedidoY.Visible = false;
                }
            }
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtImporte.Text.ToString());
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
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
                DataRow ExisteFoto = clModificarCotizacion.ExisteFoto(nombreArchivo);
                if (ExisteFoto == null)
                {
                    _memoryStream.Position = 0;
                    _memoryStream.SetLength(0);
                    _memoryStream.Capacity = 0;

                    pbFoto.Image = Image.FromFile(nombreArchivo);
                    pbFoto.Image.Save(_memoryStream, ImageFormat.Jpeg);
                    Foto = File.ReadAllBytes(dialogoAbrirArchivo.FileName);
                    txtAdjunto.Text = nombreArchivo;
                }
                else
                {
                    msg("Imagen ya asociada a la Cotizaion Nº " + ExisteFoto["Numero"].ToString().Trim() + " y al Pedido Nº " + ExisteFoto["Pedido"].ToString().Trim());
                    return;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtImporte.Text.Length == 0)
            {
                return;
            }
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
            if (decimal.Parse(txtImporte.Text) <= 0)
            {
                msg("El Importe de la Cotización No puede ser Cero");
                return;
            }
            if (txtProveedor.Text.Length == 0)
            {
                msg("Ingrese Proveedor");
                txtRUC.Focus();
                return;
            }
            if (pbFoto.Image == null)
            {
                msg("Seleccione Imagen de Cotización");
                btnBuscarPDF.Focus();
                return;
            }
            if (dtgpedidoX.RowCount > 0)
            {
                for (int i = 0; i < dtgpedidoX.RowCount; i++)
                {
                    if (TipoArticulo == 0)
                    {
                        if (decimal.Parse(dtgpedidoY["preciounity", i].Value.ToString()) <= 0)
                        {
                            msg($"El Precio Unitario no Puede Ser Cero en Linea { i + 1}");
                            dtgpedidoY.CurrentCell = dtgpedidoY["Preciounity", i];
                            break;
                        }
                    }
                    else
                    {
                        if (decimal.Parse(dtgpedidoX["preciounitx", i].Value.ToString()) <= 0)
                        {
                            msg($"El Precio Unitario no Puede Ser Cero en Linea { i + 1}");
                            dtgpedidoX.CurrentCell = dtgpedidoX["Preciounitx", i];
                            break;
                        }
                    }
                }
            }
            if (nombreArchivo == string.Empty || nombreArchivo == null)
            {
                nombreArchivo = txtAdjunto.Text.Trim();
            }
            clModificarCotizacion.CotizacionModificar(Convert.ToInt32(txtCotizacion.Text.Substring(2)), dtpFecha.Value, Convert.ToDecimal(txtImporte.Text), txtRUC.Text, Foto, nombreArchivo, (int)cbomoneda.SelectedValue);
            for (int i = 0; i < dtgpedidoX.RowCount; i++)
            {
                if (TipoArticulo == 0)
                {
                    clModificarCotizacion.ActualizarCotizacionDetalle(int.Parse(dtgpedidoY["cody", i].Value.ToString()), decimal.Parse(dtgpedidoY["preciounity", i].Value.ToString()), decimal.Parse(dtgpedidoY["totaly", i].Value.ToString()));
                }
                else
                {
                    clModificarCotizacion.ActualizarCotizacionDetalle(int.Parse(dtgpedidoX["codx", i].Value.ToString()), decimal.Parse(dtgpedidoX["preciounitx", i].Value.ToString()), decimal.Parse(dtgpedidoX["totalx", i].Value.ToString()));
                }
            }
            this.Cotizacion = txtCotizacion.Text.Substring(2);
            this.RUC = txtRUC.Text.Trim();
            this.Proveedor = txtProveedor.Text.Trim();
            this.Importe = txtImporte.Text.Trim();
            this.FechaEntrega = dtpFecha.Value;
            this.Adjunto = txtAdjunto.Text.Trim();

            txtRUC.Text = "";
            txtProveedor.Text = "";
            txtImporte.Text = "";
            pbFoto.Image = null;

            HPResergerFunciones.frmInformativo.MostrarDialog("Cotización Nº " + Convert.ToString(txtCotizacion.Text), "Se actualizó con éxito");
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        public void msg(string cadena)
        {
            HPResergerFunciones.frmInformativo.MostrarDialogError(cadena);
        }
        private void txtRUC_TextChanged(object sender, EventArgs e)
        {
            DataRow drProveedor = clModificarCotizacion.RUCProveedor(txtRUC.Text.Trim());
            if (drProveedor != null)
            {
                txtProveedor.Text = drProveedor["razon_social"].ToString();
            }
            else
            {
                txtProveedor.Text = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Modifica == 0)
                this.Close();
            if (msgp("Seguro desea Salir") == DialogResult.Yes)
                this.Close();
        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        TextBox txt;
        private void dtgpedidoY_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dtgpedidoY.Columns["PrecioUnitY"].Index == dtgpedidoY.CurrentCell.ColumnIndex)
            {
                txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(dataGridview_KeyPressCajita);
                    txt.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajita);
                }
            }
        }

        private void dtgpedidoX_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dtgpedidoX.Columns["PrecioUnitX"].Index == dtgpedidoX.CurrentCell.ColumnIndex)
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

        private void dtgpedidoY_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgpedidoX_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dtgpedidoX.Columns["PrecioUnitx"].DefaultCellStyle.Format = "N2";
            dtgpedidoX.Columns["Totalx"].DefaultCellStyle.Format = "N2";
        }

        private void dtgpedidoY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dtgpedidoX.EndEdit();
                dtgpedidoY.EndEdit();
                // btnmas_Click(sender, e);
            }
            else { e.Handled = true; }
        }
        int Modifica = 0;
        private void dtgpedidoY_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            Modifica = 1;
            if (string.IsNullOrWhiteSpace(dtgpedidoY[e.ColumnIndex, e.RowIndex].Value.ToString()))
                dtgpedidoY[e.ColumnIndex, e.RowIndex].Value = "0.00";
            if (string.IsNullOrWhiteSpace(dtgpedidoX[e.ColumnIndex, e.RowIndex].Value.ToString()))
                dtgpedidoX[e.ColumnIndex, e.RowIndex].Value = "0.00";
            dtgpedidoY.Columns["PrecioUnity"].DefaultCellStyle.Format = "N2";
            dtgpedidoY.Columns["Totaly"].DefaultCellStyle.Format = "N2";
            dtgpedidoX.Columns["PrecioUnitx"].DefaultCellStyle.Format = "N2";
            dtgpedidoX.Columns["Totalx"].DefaultCellStyle.Format = "N2";
            if (dtgpedidoX.RowCount > 0)
            {
                decimal sumatorias = 0;
                for (int i = 0; i < dtgpedidoX.RowCount; i++)
                {
                    if (TipoArticulo == 0)
                    {
                        dtgpedidoY["totaly", i].Value = decimal.Parse(dtgpedidoY["canty", i].Value.ToString()) * decimal.Parse(dtgpedidoY["preciounity", i].Value.ToString());
                        sumatorias += (decimal)dtgpedidoY["totaly", i].Value;
                    }
                    else
                    {
                        dtgpedidoX["totalx", i].Value = decimal.Parse(dtgpedidoX["preciounitX", i].Value.ToString());
                        sumatorias += decimal.Parse(dtgpedidoX["totalx", i].Value.ToString());
                    }
                }
                txtImporte.Text = sumatorias.ToString("n2");
            }
        }
        private void dtgpedidoY_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgpedidoY_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dtgpedidoY[e.ColumnIndex, e.RowIndex].Value = "0.00";
            e.Cancel = true;
        }

        private void dtgpedidoX_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dtgpedidoX[e.ColumnIndex, e.RowIndex].Value = "0.00";
            e.Cancel = true;
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

        private void frmCotizacionModificar_MouseMove(object sender, MouseEventArgs e)
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
    }
}
