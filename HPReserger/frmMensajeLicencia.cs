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
    public partial class frmMensajeLicencia : FormGradient
    {
        public frmMensajeLicencia()
        {
            InitializeComponent();
        }
        public string NombreTitulo { get { return label1.Text; } set { label1.Text = value; } }
        public string Mensaje { get; set; }
        private void frmMensajeLicencia_Load(object sender, EventArgs e)
        {
            txtmensaje.AppendText($"Solo se Puede Usar {frmMenu.Users} USUARIOS");
            txtmensaje.AppendText("\n Actualiza tu Licencia para Poder usar mas Usuarios");
            //moveControl1.cargar();   
            VerificarCarga();
        }
        public void VerificarCarga()
        {
            if (Mensaje != null)
            {
                txtmensaje.Text = Mensaje;
            }
        }
        public void Caducado()
        {
            pictureBox1.Image = ListaImagenes.Images[1];
        }
        public void Actualiza()
        {
            pictureBox1.Image = ListaImagenes.Images[0];
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOre1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOre1_MouseDown(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
