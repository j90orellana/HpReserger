using HpResergerUserControls;
using System;
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
    public partial class frmInformativo : FormGradient
    {
        public frmInformativo(string cadena)
        {
            InitializeComponent();
            lblmensaje.Text = cadena;
            DialogResult = DialogResult.Cancel;
        }
        public static void MostrarDialog(string cadena)
        {
            frmInformativo frmInformar = new frmInformativo(cadena);
             frmInformar.ShowDialog();          
        }
        private void frmInformativo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }
    }
}
