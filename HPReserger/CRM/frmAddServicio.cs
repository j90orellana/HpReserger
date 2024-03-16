
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using HpResergerNube;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SISGEM.CRM
{
    public partial class frmAddServicio : XtraForm
    {
        internal string _idServicio;
        private byte[] pbc;

        public frmAddServicio()
        {
            InitializeComponent();
        }
        private void btnCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            CRM_Servicio.Servicio servicio = new CRM_Servicio.Servicio();
            servicio.ID_Servicio = this.ID_ServicioTextEdit.EditValue?.ToString() ?? string.Empty;
            servicio.Detalle_Servicio = this.Detalle_ServicioTextEdit.EditValue?.ToString() ?? string.Empty;
            servicio.Detalle_1 = this.Detalle_1TextEdit.EditValue?.ToString() ?? string.Empty;
            servicio.Detalle_2 = this.Detalle_2TextEdit.EditValue?.ToString() ?? string.Empty;
            servicio.Detalle_3 = this.Detalle_3TextEdit.EditValue?.ToString() ?? string.Empty;
            servicio.Detalle_4 = this.Detalle_4TextEdit.EditValue?.ToString() ?? string.Empty;
            servicio.Detalle_5 = this.Detalle_5TextEdit.EditValue?.ToString() ?? string.Empty;
            servicio.Detalle_6 = this.Detalle_6TextEdit.EditValue?.ToString() ?? string.Empty;
            servicio.Detalle_7 = this.Detalle_7TextEdit.EditValue?.ToString() ?? string.Empty;
            servicio.Detalle_8 = this.Detalle_8TextEdit.EditValue?.ToString() ?? string.Empty;
            servicio.Precio_1 = this.Precio_1TextEdit.EditValue?.ToString() ?? string.Empty;
            servicio.Precio_2 = this.Precio_2TextEdit.EditValue?.ToString() ?? string.Empty;
            servicio.Precio_3 = this.Precio_3TextEdit.EditValue?.ToString() ?? string.Empty;
            servicio.Usuario = this.UsuarioTextEdit.EditValue?.ToString() ?? string.Empty;
            servicio.Fecha_creacion = new DateTime?(Convert.ToDateTime(this.Fecha_creacionDateEdit.EditValue ?? (object)DateTime.MinValue));
            servicio.Imagen = this.ImageToByteArray(this.ImagenPictureEdit.Image);
            CRM_Servicio crmServicio = new CRM_Servicio();
            if (string.IsNullOrEmpty(this._idServicio))
            {
                this._idServicio = crmServicio.InsertServicio(servicio);
                this.ID_ServicioTextEdit.EditValue = (object)this._idServicio;
                int num = (int)XtraMessageBox.Show("El servicio se ha registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                servicio.ID_Servicio = this._idServicio;
                crmServicio.UpdateServicio(servicio);
                int num = (int)XtraMessageBox.Show("La actualización se realizó con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void frmAddServicio_Load(object sender, EventArgs e)
        {
            CRM_Servicio crmServicio = new CRM_Servicio();
            if (!(this._idServicio != ""))
                return;
            this.ID_ServicioTextEdit.EditValue = (object)this._idServicio;
            CRM_Servicio.Servicio servicio = crmServicio.ReadServicioById(this._idServicio);
            if (servicio != null)
            {
                this.ID_ServicioTextEdit.EditValue = (object)servicio.ID_Servicio;
                this.Detalle_ServicioTextEdit.EditValue = (object)servicio.Detalle_Servicio;
                this.Detalle_1TextEdit.EditValue = (object)servicio.Detalle_1;
                this.Detalle_2TextEdit.EditValue = (object)servicio.Detalle_2;
                this.Detalle_3TextEdit.EditValue = (object)servicio.Detalle_3;
                this.Detalle_4TextEdit.EditValue = (object)servicio.Detalle_4;
                this.Detalle_5TextEdit.EditValue = (object)servicio.Detalle_5;
                this.Detalle_6TextEdit.EditValue = (object)servicio.Detalle_6;
                this.Detalle_7TextEdit.EditValue = (object)servicio.Detalle_7;
                this.Detalle_8TextEdit.EditValue = (object)servicio.Detalle_8;
                this.Precio_1TextEdit.EditValue = (object)servicio.Precio_1;
                this.Precio_2TextEdit.EditValue = (object)servicio.Precio_2;
                this.Precio_3TextEdit.EditValue = (object)servicio.Precio_3;
                this.UsuarioTextEdit.EditValue = (object)servicio.Usuario;
                this.Fecha_creacionDateEdit.EditValue = (object)servicio.Fecha_creacion;
                this.ImagenPictureEdit.Image = this.ByteArrayToImage(servicio.Imagen);
                this.pbc = servicio.Imagen;
            }
        }

        public byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                return (byte[])null;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                ImageFormat imageFormat = frmAddServicio.GetImageFormat(Path.GetExtension(image.Tag?.ToString() ?? ""));
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

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null)
                return (Image)null;
            using (MemoryStream memoryStream = new MemoryStream(byteArrayIn))
                return Image.FromStream((Stream)memoryStream);
        }

        private void ImagenPictureEdit_Click(object sender, EventArgs e)
        {
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
    }
}
