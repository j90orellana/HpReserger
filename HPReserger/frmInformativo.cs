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

namespace HPReserger
{
    public partial class frmInformativo : Form
    {
        public frmInformativo(string cadena)
        {
            InitializeComponent();
            lblmensaje.Text = cadena;
            DialogResult = DialogResult.Cancel;
        }
        private int fkEmpresa;
        public string Cuo { get; private set; }
        public DateTime FechaAsiento { get; private set; }
        public frmInformativo(string cadena, int _fkEmpresa, string _cuo, DateTime _FechaAsiento)
        {
            InitializeComponent();
            lblmensaje.Text = cadena;
            fkEmpresa = _fkEmpresa;
            Cuo = _cuo;
            FechaAsiento = _FechaAsiento;
            btnAsiento.Visible = true;
            btnAsiento.Click += BtnAsiento_Click;
            DialogResult = DialogResult.Cancel;
        }

        private void BtnAsiento_Click(object sender, EventArgs e)
        {
            ModuloContable.frmListadoAsientosContables frmReportito = new ModuloContable.frmListadoAsientosContables(fkEmpresa, Cuo, FechaAsiento);
            frmReportito.MdiParent = this.MdiParent;
            frmReportito.Show();
        }

        public frmInformativo(string cabecera, string detalle)
        {
            InitializeComponent();
            lblmensaje.Text = cabecera;
            lbldetalle.Text = detalle;
            if (Error)
            {
                //246, 50, 51
                panel1.BackColor = Color.Crimson;
                btnOK.BackColor = Color.Crimson;
                pbFoto.Image = ImgList.Images[1];
            }
            DialogResult = DialogResult.Cancel;
        }
        public static void MostrarDialog(string cadena)
        {
            frmInformativo frmInformar = new frmInformativo(cadena);
            Error = false;
            frmInformar.ShowDialog();
        }
        public static void MostrarDialog(string cadena, int fkEmpresa, string cuo, DateTime FechaAsiento)
        {
            frmInformativo frmInformar = new frmInformativo(cadena, fkEmpresa, cuo, FechaAsiento);
            Error = false;
            frmInformar.ShowDialog();
        }
        public static void MostrarDialog(string cabecera, string detalle)
        {
            frmInformativo frmInformar = new frmInformativo(cabecera, detalle);
            Error = false;
            frmInformar.ShowDialog();
        }
        public static Boolean Error;
        public static void MostrarDialogError(string cabecera)
        {
            frmInformativo frmInformar = new frmInformativo(cabecera);
            Error = true;
            frmInformar.ShowDialog();
        }
        public static void MostrarDialogError(string cabecera, string detalle)
        {
            frmInformativo frmInformar = new frmInformativo(cabecera, detalle);
            Error = true;
            frmInformar.ShowDialog();
        }
        private void frmInformativo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape) this.Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Timer Time = new Timer();
        private void frmInformativo_Load(object sender, EventArgs e)
        {
            Time.Interval = 25;
            Time.Tick += Time_Tick;
            this.Opacity = 0;
            Time.Start();
            btnOK.Focus();
            if (Error)
            {
                panel1.BackColor = Color.Crimson;//.FromArgb(246, 50, 51);
                btnOK.BackColor = Color.Crimson;//.FromArgb(246, 50, 51);
                pbFoto.Image = ImgList.Images[1];
                lbldetalle.Text = "La Operación será Cancelada";
                SystemSounds.Asterisk.Play();
            }
            else
                SystemSounds.Beep.Play();
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
            if (e.KeyData == Keys.Escape) this.Close();
        }
    }
}
