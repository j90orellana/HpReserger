using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HpResergerUserControls
{
    public partial class FotoCheck : UserControl
    {
        public FotoCheck()
        {
            InitializeComponent();
            _ImagenDefault = btnclose.Image;
           _ImagenEncima= btnprueba.Image;
            Invalidate();
        }
        public string Nombre { get { return lblnombre.Text; } set { lblnombre.Text = value; } }
        public string Cargo { get { return lblcargo.Text; } set { lblcargo.Text = value; } }
        public string Observacion { get { return lblObservacion.Text; } set { lblObservacion.Text = value; } }
        public Image FotoPerfil { get { return pbFoto.Image; } set { pbFoto.Image = value; } }
        public Image ImagenCloseEncima { get { return _ImagenEncima; } set { _ImagenEncima = value; } }
        public Image _ImagenDefault;
        public Image _ImagenEncima;
        public void CambiarImagen(Image Foto)
        {
            pbFoto.Image = Foto;
        }
        private void buttonOre1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void FotoCheck_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnclose_MouseMove(object sender, MouseEventArgs e)
        {
            btnclose.Image = _ImagenEncima;
        }
        private void btnclose_MouseLeave(object sender, EventArgs e)
        {
            btnclose.Image = _ImagenDefault;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
