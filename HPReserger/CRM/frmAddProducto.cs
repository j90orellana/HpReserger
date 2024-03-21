using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HpResergerNube;
using DevExpress.XtraBars;

namespace SISGEM.CRM
{
    public partial class frmAddProducto : XtraForm
    {
        internal string _idProducto = "";
        private HpResergerNube.CRM_ProductoRepository.Producto oProducto = new HpResergerNube.CRM_ProductoRepository.Producto();
        private byte[] pbc;

        public frmAddProducto()
        {
            InitializeComponent();
        }
        private void btnCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        private void frmAddProducto_Load(object sender, EventArgs e)
        {
            CRM_ProductoRepository productoRepository = new CRM_ProductoRepository();
            if (!(this._idProducto != ""))
                return;
            this.ID_ProductoTextEdit.EditValue = (object)this._idProducto;
            CRM_ProductoRepository.Producto producto = productoRepository.ReadProducto(this._idProducto);
            if (producto != null)
            {
                this.ID_ProductoTextEdit.EditValue = (object)producto.ID_Producto;
                this.Detalle_ProductoTextEdit.EditValue = (object)producto.Detalle_Producto;
                this.MarcaTextEdit.EditValue = (object)producto.Marca;
                this.ModeloTextEdit.EditValue = (object)producto.Modelo;
                this.TipoTextEdit.EditValue = (object)producto.Tipo;
                this.UsoTextEdit.EditValue = (object)producto.Uso;
                this.Detalle_1TextEdit.EditValue = (object)producto.Detalle_1;
                this.Detalle_2TextEdit.EditValue = (object)producto.Detalle_2;
                this.Detalle_3TextEdit.EditValue = (object)producto.Detalle_3;
                this.Detalle_4TextEdit.EditValue = (object)producto.Detalle_4;
                this.Detalle_5TextEdit.EditValue = (object)producto.Detalle_5;
                this.Detalle_6TextEdit.EditValue = (object)producto.Detalle_6;
                this.Detalle_7TextEdit.EditValue = (object)producto.Detalle_7;
                this.Detalle_8TextEdit.EditValue = (object)producto.Detalle_8;
                this.FotosTextEdit.EditValue = (object)producto.Fotos;
                this.ArchivoTextEdit.EditValue = (object)producto.Archivo;
                this.Precio_1TextEdit.EditValue = (object)producto.Precio_1;
                this.Precio_2TextEdit.EditValue = (object)producto.Precio_2;
                this.Precio_3TextEdit.EditValue = (object)producto.Precio_3;
                this.ID_MonedaTextEdit.EditValue = (object)producto.ID_Moneda;
                this.UsuarioTextEdit.EditValue = (object)producto.Usuario;
                this.FechaDateEdit.EditValue = (object)producto.Fecha;
                this.ImagenPictureEdit.Image = this.ByteArrayToImage(producto.Imagen);
                this.pbc = producto.Imagen;
            }
        }
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            try
            {

                if (byteArrayIn == null || byteArrayIn.Length == 0)
                {
                    return null;
                }

                using (MemoryStream ms = new MemoryStream(byteArrayIn))
                {
                    return Image.FromStream(ms);
                }
            }
            catch
            {
                return null;
            }
        }
        private void btnGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            CRM_ProductoRepository.Producto producto = new CRM_ProductoRepository.Producto();
            producto.ID_Producto = this.ID_ProductoTextEdit.EditValue?.ToString() ?? string.Empty;
            producto.Detalle_Producto = this.Detalle_ProductoTextEdit.EditValue?.ToString() ?? string.Empty;
            producto.Marca = this.MarcaTextEdit.EditValue?.ToString() ?? string.Empty;
            producto.Modelo = this.ModeloTextEdit.EditValue?.ToString() ?? string.Empty;
            producto.Tipo = this.TipoTextEdit.EditValue?.ToString() ?? string.Empty;
            producto.Uso = this.UsoTextEdit.EditValue?.ToString() ?? string.Empty;
            producto.Detalle_1 = this.Detalle_1TextEdit.EditValue?.ToString() ?? string.Empty;
            producto.Detalle_2 = this.Detalle_2TextEdit.EditValue?.ToString() ?? string.Empty;
            producto.Detalle_3 = this.Detalle_3TextEdit.EditValue?.ToString() ?? string.Empty;
            producto.Detalle_4 = this.Detalle_4TextEdit.EditValue?.ToString() ?? string.Empty;
            producto.Detalle_5 = this.Detalle_5TextEdit.EditValue?.ToString() ?? string.Empty;
            producto.Detalle_6 = this.Detalle_6TextEdit.EditValue?.ToString() ?? string.Empty;
            producto.Detalle_7 = this.Detalle_7TextEdit.EditValue?.ToString() ?? string.Empty;
            producto.Detalle_8 = this.Detalle_8TextEdit.EditValue?.ToString() ?? string.Empty;
            producto.Fotos = this.FotosTextEdit.EditValue?.ToString() ?? string.Empty;
            producto.Archivo = this.ArchivoTextEdit.EditValue?.ToString() ?? string.Empty;
            producto.Precio_1 = this.Precio_1TextEdit.EditValue?.ToString() ?? string.Empty;
            producto.Precio_2 = this.Precio_2TextEdit.EditValue?.ToString() ?? string.Empty;
            producto.Precio_3 = this.Precio_3TextEdit.EditValue?.ToString() ?? string.Empty;
            producto.ID_Moneda = this.ID_MonedaTextEdit.EditValue?.ToString() ?? string.Empty;
            producto.Usuario = this.UsuarioTextEdit.EditValue?.ToString() ?? string.Empty;
            producto.Fecha = new DateTime?(Convert.ToDateTime(this.FechaDateEdit.EditValue ?? (object)DateTime.MinValue));
            producto.Imagen = this.ImageToByteArray(this.ImagenPictureEdit.Image);
            CRM_ProductoRepository productoRepository = new CRM_ProductoRepository();
            if (string.IsNullOrEmpty(this._idProducto))
            {
                this._idProducto = productoRepository.InsertProducto(producto);
                this.ID_ProductoTextEdit.EditValue = (object)this._idProducto;
                int num = (int)XtraMessageBox.Show("El producto se ha registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                producto.ID_Producto = this._idProducto;
                productoRepository.UpdateProducto(producto);
                int num = (int)XtraMessageBox.Show("La actualización se realizó con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                return (byte[])null;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                ImageFormat imageFormat = frmAddProducto.GetImageFormat(Path.GetExtension(image.Tag?.ToString() ?? ""));
                if (this.ImagenPictureEdit.Image.PropertyIdList.Length != 0)
                    this.ImagenPictureEdit.Image.Save((Stream)memoryStream, imageFormat);
                else
                    memoryStream.Write(this.pbc, 0, this.pbc.Length);
                return memoryStream.GetBuffer();
            }
        }

        private static ImageFormat GetImageFormat(string extension)
        {
            switch (extension.ToLower())
            {
                case ".bmp":
                    return ImageFormat.Bmp;
                case ".jpg":
                case ".jpeg":
                    return ImageFormat.Jpeg;
                case ".gif":
                    return ImageFormat.Gif;
                case ".png":
                    return ImageFormat.Png;
                default:
                    return ImageFormat.Jpeg;
            }
        }

        private void ImagenPictureEdit_DoubleClick(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Ver Foto";
            form.Size = new Size(400, 400);
            form.StartPosition = FormStartPosition.CenterParent;
            
           

            form.Icon = this.Icon;
            form.BackColor = Color.White;
            form.StartPosition = FormStartPosition.CenterScreen;


            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = this.ImagenPictureEdit.Image;
            form.Controls.Add((Control)pictureBox);
            Button button = new Button();
            button.Text = "Cargar Foto";
            button.Location = new Point(10, 10);
            button.Click += (EventHandler)((s, args) =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*";
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            });
            form.Controls.Add((Control)button);
            int num = (int)form.ShowDialog();
        }

        private void btnCerrar_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
