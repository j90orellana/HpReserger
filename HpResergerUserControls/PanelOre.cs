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
    public partial class PanelOre : Panel
    {
        public PanelOre()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(50, 41, 56, 71);
        }
        public Boolean _Movible;
        public Boolean Movible
        {
            get { return _Movible; }
            set { _Movible = value; }
        }
        Boolean mover = false;
        int x, y;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (_Movible)
            {
                if (e.Button == MouseButtons.Left)
                {
                    x = e.X; y = e.Y; mover = true;
                }
            }
            base.OnMouseUp(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (_Movible)
            {
                if (mover)
                {                    
                    FindForm().Location = new Point(FindForm().Left + e.X - x, FindForm().Top + e.Y - y);
                    mover = false;
                }
            }
            base.OnMouseUp(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (_Movible)
            {
                if (mover)
                {
                    FindForm().Location = new Point(FindForm().Left + e.X - x, FindForm().Top + e.Y - y);
                }
            }
            base.OnMouseMove(e);
        }
    }
}
