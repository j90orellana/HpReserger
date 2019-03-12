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
    public partial class SeparadorOre : UserControl
    {
        public SeparadorOre()
        {
            InitializeComponent();

            this.Paint += new PaintEventHandler(LineSeparator_Paint);
            this.MaximumSize = new Size(2000, 2);
            this.MinimumSize = new Size(0, 2);
            this.Width = 350;
            this.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Left );
        }
        //private Pen _primario = Pens.Black;
        //public Pen ColorPrimario { get { return _primario; } set { _primario = value; } }
        //private Pen _secuandario= Pens.Gray;
        //public Pen ColorSecundario { get { return _secuandario; } set { _secuandario = value; } }
        private void LineSeparator_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(Pens.Black, new Point(0, 1), new Point(this.Width, 1));
            g.DrawLine(Pens.Gray, new Point(0, 2), new Point(this.Width, 2));
            //g.DrawLine(Pens.Red, new Point(0, 3), new Point(this.Width, 3));
            //g.DrawLine(Pens.Blue, new Point(0, 4), new Point(this.Width, 4));
        }
    }
}
