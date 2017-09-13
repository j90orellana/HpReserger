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
    public partial class FrmFoto : Form
    {
        public FrmFoto()
        {
            InitializeComponent();
        }
        public Image fotito;
        private void FrmFoto_Load(object sender, EventArgs e)
        {
            if (fotito != null)
            {
                pbfoto.Image = fotito;
                this.Size = pbfoto.Image.Size;
                this.Size = new Size(pbfoto.Image.Size.Width + 25, pbfoto.Image.Size.Height + 50);
            }
        }
        private void FrmFoto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void pbfoto_Click(object sender, EventArgs e)
        {

        }

        private void pbfoto_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

            //this.WindowState = FormWindowState.Normal;
            //this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btndescargar_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbfoto.Image != null)
                btndescargar.Visible = true;
        }

        private void pbfoto_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbfoto.Image != null)
                btndescargar.Visible = true;
        }

        private void FrmFoto_Leave(object sender, EventArgs e)
        {
            btndescargar.Visible = false;
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            HPResergerFunciones.Utilitarios.DescargarImagen(pbfoto);
        }


        //MessageBox.Show("keyvalue:" + e.KeyValue + " keycode:" + e.KeyCode + " keydata:" + e.KeyData + " keymodificador:" + e.Modifiers);
    }
}
