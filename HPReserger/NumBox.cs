using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class NumBox : UserControl
    {
        public NumBox()
        {
            InitializeComponent();
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, Num.Text);
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
