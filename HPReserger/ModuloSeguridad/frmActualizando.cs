using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SISGEM.ModuloSeguridad
{
    public partial class frmActualizando : XtraForm
    {
        private LabelControl lblTitulo;
        private LabelControl lblMensaje;
        private MarqueeProgressBarControl progressBar;

        public frmActualizando()
        {
            InitializeComponent();
        }


        public void ActualizarMensaje(string mensaje)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => lblMensaje.Text = mensaje));
            }
            else
            {
                lblMensaje.Text = mensaje;
            }
        }
    }
}
