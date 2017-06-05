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
    public partial class frmCotizacionModificar : Form
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

        public frmCotizacionModificar()
        {
            InitializeComponent();
        }

        private void frmCotizacionModificar_Load(object sender, EventArgs e)
        {
            txtCotizacion.Text = Cotizacion;
            txtPedido.Text = Pedido;
            txtRUC.Text = RUC;
            txtProveedor.Text = Proveedor;
            txtImporte.Text = Importe;
            dtpFecha.Value = new DateTime(FechaEntrega.Year, FechaEntrega.Month, FechaEntrega.Day);
            txtAdjunto.Text = Adjunto;

            if (txtCotizacion.Text.Length >0)
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
                    MessageBox.Show("Imagen ya asociada a la Cotizaion Nº " + ExisteFoto["Numero"].ToString().Trim() + " y al Pedido Nº " + ExisteFoto["Pedido"].ToString().Trim() + "", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
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
            if (pbFoto.Image == null)
            {
                MessageBox.Show("Seleccione Imagen de Cotización", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnBuscarPDF.Focus();
                return;
            }
            else
            {
                if (nombreArchivo == string.Empty || nombreArchivo == null)
                {
                    nombreArchivo = txtAdjunto.Text.Trim();
                }
                clModificarCotizacion.CotizacionModificar(Convert.ToInt32(txtCotizacion.Text.Substring(2)), dtpFecha.Value, Convert.ToDecimal(txtImporte.Text), txtRUC.Text, Foto, nombreArchivo);

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

                MessageBox.Show("Cotización Nº " + Convert.ToString(txtCotizacion.Text) + " se actualizó con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
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
    }
}
