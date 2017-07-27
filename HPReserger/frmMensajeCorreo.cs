using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmMensajeCorreo : Form
    {
        public frmMensajeCorreo()
        {
            InitializeComponent();
        }
        public string cadena; public Boolean ok;
        private void frmMensajeCorreo_Load(object sender, EventArgs e)
        {
             ok = false;
        }
        private void btnenviar_Click(object sender, EventArgs e)
        {
            cadena = "\n\n";
            foreach (char c in txtmsg.Text)
            {
                if (c == (char)13)
                    cadena += "\n";
                else
                    cadena += c.ToString();
            }
            ok = true;
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            ok = false;
            this.Close();
        }
    }
}
