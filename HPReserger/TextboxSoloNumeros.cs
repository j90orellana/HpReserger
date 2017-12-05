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
    public partial class TextboxSoloNumeros : UserControl
    {
        public TextboxSoloNumeros()
        {
            InitializeComponent();
        }
        public int MaxLengthTxt
        {
            get { return txt.MaxLength; }
            set { txt.MaxLength = value; }
        }
        public Font FuenteDelTxt
        {
            get { return txt.Font; }
            set { txt.Font = value; }
        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimalesX(e, txt.Text);

        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txt);
        }
    }
}
