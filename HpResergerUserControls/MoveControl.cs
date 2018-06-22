using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HpResergerUserControls
{
    public partial class MoveControl : Component
    {
        public MoveControl()
        {
            InitializeComponent();
        }
        public MoveControl(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        Boolean mover = false; int x, y;
        public void cargar()
        {
            if (_Control != null)
            {
                _Control.MouseDown += new MouseEventHandler(MouseDownx);
                _Control.MouseUp += new MouseEventHandler(MouseUPe);
                _Control.MouseMove += new MouseEventHandler(MouseMover);
            }
        }
        private void MouseUPe(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                _Control.FindForm().Location = new Point(_Control.FindForm().Left + e.X - x, _Control.FindForm().Top + e.Y - y);
                mover = false;
            }            
        }
        private void MouseDownx(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X; y = e.Y; mover = true;
            }
        }
        private void MouseMover(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                _Control.FindForm().Location = new Point(_Control.FindForm().Left + e.X - x, _Control.FindForm().Top + e.Y - y);
            }
        }
        public Panel _Control;
        [Description("Control a Mover")]
        public Panel Control
        {
            get { return _Control; }
            set
            {
                _Control = value;
                _Control.MouseDown += new MouseEventHandler(MouseDownx);
                _Control.MouseUp += new MouseEventHandler(MouseUPe);
                _Control.MouseMove += new MouseEventHandler(MouseMover);
            }
        }

    }
}
