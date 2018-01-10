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
    public partial class NumBox : UserControl
    {
        public NumBox()
        {
            InitializeComponent();
        }
        
        private Control _NextControlOnEnter;
        public Control NextControlOnEnter
        {
            get { return _NextControlOnEnter; }
            set { _NextControlOnEnter = value; }
        }
        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, Num.Text);
            if (e.KeyChar == (char)Keys.Enter)
            {
                _NextControlOnEnter.Focus();
            }
            base.OnKeyPress(e);
        }

        private void Num_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, Num);
        }

        private void Num_TextChanged(object sender, EventArgs e)
        {

        }

        private void Num_Leave(object sender, EventArgs e)
        {
            Num.Text = decimal.Parse(Num.Text).ToString("00.00");
        }
    }
}
