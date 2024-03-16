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
    public partial class TextBoxSoloLetrasMayusculas : UserControl
    {
        public TextBoxSoloLetrasMayusculas()
        {
            InitializeComponent();
        }
        int tamaño = 10;
        public void Tamaño(int valor)
        {
            tamaño = valor;

        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Sololetras(e);
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarPegarSoloLetrasyEspacio(e, txt, tamaño);
        }
    }
}
