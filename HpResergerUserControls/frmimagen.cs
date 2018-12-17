using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HpResergerUserControls
{
    public partial class frmimagen : UserControl
    {
        public frmimagen()
        {
            InitializeComponent();
        }
        public Image Imagen { get { return pbfoto.Image; } set { pbfoto.Image = value; } }
        public void AsignarPadre(Form father) { Padre = father; }
        string nombre;
        public PictureBoxSizeMode SizeMode { get { return pbfoto.SizeMode; } set { pbfoto.SizeMode = value; } }
        public Form Padre { get; set; }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        private void btndescargar_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbfoto.Image != null)
            {
                btnDescargar1.Visible = true;
                btnVer1.Visible = true;
            }
            else
            {
                btnDescargar1.Visible = false;
                btnVer1.Visible = false;
            }
        }
        private void btndescargar_Click(object sender, EventArgs e)
        {
            HPResergerFunciones.Utilitarios.DescargarImagen(pbfoto);
        }
        private void pbfoto_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbfoto.Image != null)
            {
                btnDescargar1.Visible = true;
                btnVer1.Visible = true;
            }
            else
            {
                btnDescargar1.Visible = false;
                btnVer1.Visible = false;
            }
        }
        private void pbfoto_DoubleClick(object sender, EventArgs e)
        {
            MostrarFoto(pbfoto);
        }
        public void MostrarFoto(PictureBox fotito)
        {
            if (fotito.Image != null)
            {
                frmImagenes foto = new frmImagenes($"Imagen de {nombre}");
                foto.fotito = fotito.Image;
                foto.Owner = Padre;
                foto.ShowDialog();
            }
        }
        private void btnVer_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbfoto.Image != null)
                btnVer1.Visible = true;
        }
        private void btnVer_Click(object sender, EventArgs e)
        {
            pbfoto_DoubleClick(sender, e);
        }
        private void pbfoto_MouseLeave(object sender, EventArgs e)
        {
            //if (pbfoto.Bounds.Contains(Location.X - MousePosition.X, Location.Y - MousePosition.Y))
            //{
            //    btndescargar.Visible = false;
            //    btnVer.Visible = false;
            //}
        }
        private void frmimagen_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbfoto.Image != null)
            {
                btnDescargar1.Visible = false;
                btnVer1.Visible = false;
            }
            else
            {
                btnDescargar1.Visible = false;
                btnVer1.Visible = false;
            }
        }
        private void frmimagen_MouseLeave(object sender, EventArgs e)
        {
            if (pbfoto.Image != null)
            {
                btnDescargar1.Visible = false;
                btnVer1.Visible = false;
            }
            else
            {
                btnDescargar1.Visible = false;
                btnVer1.Visible = false;
            }
        }

        private void pbfoto_Paint(object sender, PaintEventArgs e)
        {
            //pbfoto.BorderStyle = BorderStyle.None;
            //Pen p = new Pen(Color.Red);
            //Graphics g = e.Graphics;
            //int variance = 11;
            //g.DrawRectangle(p, new Rectangle(pbfoto.Location.X - variance, pbfoto.Location.Y - variance, pbfoto.Width + variance, pbfoto.Height + variance));
        }

        private void pbfoto_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void frmimagen_DragDrop(object sender, DragEventArgs e)
        {

        }
    }
}
