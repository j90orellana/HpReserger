﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HpResergerUserControls
{
    public partial class frmImagenes : FormGradient
    {
        public frmImagenes(string nombres)
        {
            InitializeComponent();
            Text = nombres.Trim();
            pbfoto.Image = fotito;
        }
        public frmImagenes(string nombres, Image fotito)
        {
            InitializeComponent();
            Text = nombres.Trim();
            pbfoto.Image = fotito;
            this.Size = pbfoto.Image.Size;
            Size = new Size(pbfoto.Image.Size.Width + 25, pbfoto.Image.Size.Height + 50);
            pbfoto.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public Image fotito;
        public string Nombre = "";
        private void FrmFoto_Load(object sender, EventArgs e)
        {
            //Text = Nombre;
            if (fotito != null)
            {
                //pbfoto.Image = fotito;
                //this.Size = pbfoto.Image.Size;
                //this.Size = new Size(pbfoto.Image.Size.Width + 25, pbfoto.Image.Size.Height + 50);
                if (Owner != null)
                {
                    this.Top = (this.Owner.Height - pbfoto.Height) / 2;
                    this.Left = (this.Owner.Width - pbfoto.Width) / 2;
                }
                else
                {
                    this.StartPosition = FormStartPosition.CenterParent;
                }
            }
            this.StartPosition = FormStartPosition.CenterParent;
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

        private void frmImagenes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void pbfoto_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (pbfoto.Image != null)
                btndescargar.Visible = true;
        }

        private void btndescargar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void btndescargar_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (pbfoto.Image != null)
                btndescargar.Visible = true;
        }
        public void GirarDerecha()
        {
            Image img = pbfoto.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pbfoto.Image = img;

        }
        public void GirarIzquierda()
        {
            Image img = pbfoto.Image;
            img.RotateFlip(RotateFlipType.Rotate270FlipXY);
            pbfoto.Image = img;
        }

        private void frmImagenes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)//derecha
            {
                GirarDerecha();
            }
            else if (e.Button == MouseButtons.Left)
            {
                GirarIzquierda();
            }
        }

        private void btnizquierda_Click(object sender, EventArgs e)
        {
            GirarIzquierda();
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            GirarDerecha();
        }
    }
}
