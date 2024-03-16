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

namespace HPReserger
{
    public partial class frmProcesando : FormGradient
    {
        public frmProcesando()
        {
            InitializeComponent();
        }
        public frmProcesando(string cadena)
        {
            InitializeComponent();
            lblProceso.Text = cadena;
        }
        private void frmProcesando_Load(object sender, EventArgs e)
        {

        }
    }
}
