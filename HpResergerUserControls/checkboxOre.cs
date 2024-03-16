using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Net.Mail;

namespace HpResergerUserControls
{
    public partial class checkboxOre : CheckBox
    {
        public checkboxOre()
        {         
            InitializeComponent();
            BackColor = Color.Transparent;
        }
        private Color _ColorChecked = Color.FromArgb(92, 184, 92);
        private Color _ColorUnChecked = Color.FromArgb(217, 83, 79);
        public Color ColorChecked { get; set; }
        public Color ColorUnChecked { get; set; }
        protected override void OnPaint(PaintEventArgs pevent)
        {           
            Graphics g = pevent.Graphics;
            base.OnPaint(pevent);
            if (this.Checked)
            {
                pevent.Graphics.FillRectangle(new SolidBrush(ColorChecked), new Rectangle(0, 0, 16, 16));
            }
            else
            {
                pevent.Graphics.FillRectangle(new SolidBrush(ColorUnChecked), new Rectangle(0, 0, 16, 16));
            }
        }       
    }
}
