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
    public partial class frmCuadreAsientos : FormGradient
    {
        public frmCuadreAsientos()
        {
            InitializeComponent();
        }
        public frmCuadreAsientos(string mensaje)
        {
            InitializeComponent();
            this.mensaje = mensaje;
        }
        public string mensaje { get { return lblmensaje.Text; } set { lblmensaje.Text = value; } }
        public int Resultado = 0;
        private void frmCuadreAsientos_Load(object sender, EventArgs e)
        {

        }
        private void buttonPer1_Click(object sender, EventArgs e)
        {
            ///Ajuste por redondeo
            Resultado = 1;
        }
        private void buttonPer2_Click(object sender, EventArgs e)
        {
            ////ajuste por tipo de cambio
            Resultado = 2;
        }
        private void buttonPer3_Click(object sender, EventArgs e)
        {
            //// no hacemos nada
            Resultado = 0;
        }
    }
}
