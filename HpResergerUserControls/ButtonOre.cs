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
    public partial class ButtonOre : UserControl
    {
        public ButtonOre()
        {
            InitializeComponent();
            _ImagenDefault = pbfoto.Image;
            ImagenSobre = pbfoto.ErrorImage;
        }
        public Image _ImagenSobre;
        public Image _ImagenDefault;
        public Boolean Cerrar = false;
        public Image ImageActiva { get { return pbfoto.Image; } set { pbfoto.Image = value; } }
        public Image ImagenSobre { get { return _ImagenSobre; } set { _ImagenSobre = value; } }
        private void pbfoto_MouseUp(object sender, MouseEventArgs e)
        {
            this.pbfoto.Image = ImagenSobre;
        }
        private void pbfoto_MouseLeave(object sender, EventArgs e)
        {
            this.pbfoto.Image = _ImagenDefault;
        }
        private void pbfoto_MouseMove(object sender, MouseEventArgs e)
        {
            this.pbfoto.Image = ImagenSobre;
        }
        private void pbfoto_MouseDown(object sender, MouseEventArgs e)
        {
            Cerrar = true;
        }
    }
}
