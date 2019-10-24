using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPResergerFunciones
{
    public partial class frmPregunta : Form
    {
        public frmPregunta(string cadena)
        {
            InitializeComponent();
            lblmensaje.Text = cadena;
        }
        public frmPregunta(string cadena, int Valor)
        {
            InitializeComponent();
            btnNo.Visible = true;
            btnYes.Location = new Point(61, 231);
            btnCancelar.Location = new Point(302, 231);
            btnYes.Text = "Si";
            lblmensaje.Text = cadena;
        }
        public frmPregunta(string cabecera, string detalle)
        {
            InitializeComponent();
            lblmensaje.Text = cabecera;
            lbldetalle.Text = detalle;
        }
        public static DialogResult MostrarDialogYesCancel(string cadena)
        {
            frmPregunta frmInformar = new frmPregunta(cadena);
            return frmInformar.ShowDialog();
        }
        public static DialogResult MostrarDialogYesNoCancel(string cadena)
        {
            frmPregunta frmInformar = new frmPregunta(cadena, 1);
            return frmInformar.ShowDialog();
        }
        public static DialogResult MostrarDialogYesCancel(string cabecera, string detalle)
        {
            frmPregunta frmInformar = new frmPregunta(cabecera, detalle);
            return frmInformar.ShowDialog();
        }
        private void frmInformativo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape) DialogResult = DialogResult.Cancel;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }
        Timer Time = new Timer();
        private void frmInformativo_Load(object sender, EventArgs e)
        {
            Time.Interval = 25;
            Time.Tick += Time_Tick;
            this.Opacity = 0;
            Time.Start();
            btnYes.Focus();
            SystemSounds.Asterisk.Play();
        }
        private void Time_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.1;
            }
            else Time.Stop();
        }
        private void frmInformativo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape) DialogResult = DialogResult.Cancel;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnCancelar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape) DialogResult = DialogResult.Cancel;
        }

        private void btnCancelar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape) DialogResult = DialogResult.Cancel;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
