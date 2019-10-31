using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HpResergerUserControls
{
    public partial class BorderEsquinas : Component
    {
        public BorderEsquinas()
        {
            InitializeComponent();
        }

        public BorderEsquinas(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        private int Radio = 10;
        public int radio
        {
            get { return Radio; }
            set
            {
                Radio = value;
            }
        }
        public void RedondearEsquinas(Button boton)
        {
            Rectangle r = new Rectangle(0, 0, boton.Width, boton.Height);
            System.Drawing.Drawing2D.GraphicsPath Buton = new System.Drawing.Drawing2D.GraphicsPath();
            Buton.AddArc(r.X, r.Y, radio, radio, 180, 90);
            Buton.AddArc(r.X + r.Width - radio, r.Y, radio, radio, 270, 90);
            Buton.AddArc(r.X + r.Width - radio, r.Y + r.Height - radio, radio, radio, 0, 90);
            Buton.AddArc(r.X, r.Y + r.Height - radio, radio, radio, 90, 90);
            boton.Region = new Region(Buton);
        }
        public static void RedondearEsquinas(int radio, Button boton)
        {
            Rectangle r = new Rectangle(0, 0, boton.Width, boton.Height);
            System.Drawing.Drawing2D.GraphicsPath Buton = new System.Drawing.Drawing2D.GraphicsPath();
            Buton.AddArc(r.X, r.Y, radio, radio, 180, 90);
            Buton.AddArc(r.X + r.Width - radio, r.Y, radio, radio, 270, 90);
            Buton.AddArc(r.X + r.Width - radio, r.Y + r.Height - radio, radio, radio, 0, 90);
            Buton.AddArc(r.X, r.Y + r.Height - radio, radio, radio, 90, 90);
            boton.Region = new Region(Buton);
        }
        public static void RedondearEsquinas(int radio, params Control[] botones)
        {
            foreach (Control boton in botones)
            {
                Rectangle r = new Rectangle(0, 0, boton.Width, boton.Height);
                System.Drawing.Drawing2D.GraphicsPath Buton = new System.Drawing.Drawing2D.GraphicsPath();
                Buton.AddArc(r.X, r.Y, radio, radio, 180, 90);
                Buton.AddArc(r.X + r.Width - radio, r.Y, radio, radio, 270, 90);
                Buton.AddArc(r.X + r.Width - radio, r.Y + r.Height - radio, radio, radio, 0, 90);
                Buton.AddArc(r.X, r.Y + r.Height - radio, radio, radio, 90, 90);
                boton.Region = new Region(Buton);
            }
        }
        public static void RedondearEsquinas(int radio, Form Formulario)
        {
            Rectangle r = new Rectangle(0, 0, Formulario.Width, Formulario.Height);
            System.Drawing.Drawing2D.GraphicsPath Buton = new System.Drawing.Drawing2D.GraphicsPath();
            Buton.AddArc(r.X, r.Y, radio, radio, 180, 90);
            Buton.AddArc(r.X + r.Width - radio, r.Y, radio, radio, 270, 90);
            Buton.AddArc(r.X + r.Width - radio, r.Y + r.Height - radio, radio, radio, 0, 90);
            Buton.AddArc(r.X, r.Y + r.Height - radio, radio, radio, 90, 90);
            Formulario.Region = new Region(Buton);
        }
        public Control _Control;
        public Control Control
        {
            get { return _Control; }
            set
            {
                _Control = value;
                _Control.Paint += _Control_Paint;
            }
        }

        private void _Control_Paint(object sender, PaintEventArgs e)
        {
            RedondearEsquinas((Button)sender);
        }
    }
}
