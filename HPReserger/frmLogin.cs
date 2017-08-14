using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmLogin : Form
    {
        HPResergerCapaLogica.HPResergerCL clLogueo = new HPResergerCapaLogica.HPResergerCL();
        public static int CodigoUsuario;
        public static string Usuario;
        public static int CodigoArea;
        public static string Area;
        public static int CodigoCentroCosto;
        public static string CentroCosto;
        public static int CodigoGerencia;
        public static string Gerencia;
        public static int CodigoPartidaPresupuesto;
        public static string PartidaPresupuesto;
        public frmMenu frmM;
        public int Intentos { get; set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtContraseña.Focus();
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnLogueo.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            Intentos = 0;
        }

        private void btnLogueo_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Usuario", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
                return;
            }

            if (txtContraseña.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Contraseña", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContraseña.Focus();
                return;
            }

            DataRow drAcceso;
            drAcceso = clLogueo.Loguearse(txtUsuario.Text, 0);
            if (drAcceso == null)
            {
                MessageBox.Show("Usuario NO existe", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtUsuario.Focus();
                return;
            }
            else
            {
                drAcceso = clLogueo.Loguearse(txtUsuario.Text, 2);
                if (Convert.ToInt32(drAcceso["Estado"].ToString()) == 0)
                {
                    MessageBox.Show("Usuario bloqueado, contactese con el Area de Sistemas", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtUsuario.Focus();
                    return;
                }
                else
                {
                    drAcceso = clLogueo.Logueo(txtUsuario.Text, txtContraseña.Text);
                    if (drAcceso != null)
                    {
                        clLogueo.ActualizarLogin("usp_ActualizarLogin", txtUsuario.Text, 1);
                        drAcceso = clLogueo.Loguearse(txtUsuario.Text, 3);
                        if (drAcceso != null)
                        {
                            CodigoUsuario = Convert.ToInt32(drAcceso["CODIGOUSUARIO"].ToString());
                            Usuario = drAcceso["USUARIO"].ToString();
                            CodigoArea = Convert.ToInt32(drAcceso["CODIGOAREA"].ToString());
                            Area = drAcceso["AREA"].ToString();
                            CodigoCentroCosto = Convert.ToInt32(drAcceso["CODIGOCENTROCOSTO"].ToString());
                            CentroCosto = drAcceso["CENTROCOSTO"].ToString();
                            CodigoGerencia = Convert.ToInt32(drAcceso["CODIGOGERENCIA"].ToString());
                            Gerencia = drAcceso["GERENCIA"].ToString();
                            CodigoPartidaPresupuesto = Convert.ToInt32(drAcceso["CODIGOPARTIDAPRESUPUESTO"].ToString());
                            PartidaPresupuesto = drAcceso["PARTIDAPRESUPUESTO"].ToString();
                        }
                        this.Hide();
                        frmM = new frmMenu();
                        frmM.usuario = CodigoUsuario;
                        frmM.Nombres = Usuario;
                        frmM.nick = txtUsuario.Text;
                        if (drAcceso["FOTO"] != null && drAcceso["foto"].ToString().Length > 0)
                        {
                            byte[] Fotito = new byte[0];
                            Fotito = (byte[])drAcceso["FOTO"];
                            MemoryStream ms = new MemoryStream(Fotito);
                            frmM.pbfotoempleado.Image = Bitmap.FromStream(ms);
                        }
                        frmM.ShowDialog();
                    }
                    else
                    {
                        drAcceso = clLogueo.Loguearse(txtUsuario.Text, 1);
                        if (Convert.ToInt32(drAcceso["intentos"].ToString()) == 4)
                        {
                            clLogueo.ActualizarLogin("usp_ActualizarLogin", txtUsuario.Text, 2);
                            MessageBox.Show("5 intentos fallidos, se bloqueó al Usuario " + txtUsuario.Text + "", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                        else
                        {
                            clLogueo.ActualizarLogin("usp_ActualizarLogin", txtUsuario.Text, 0);
                            drAcceso = clLogueo.Loguearse(txtUsuario.Text, 1);
                            MessageBox.Show("Intento fallido Nº " + drAcceso["intentos"].ToString() + ",  son 5 intentos, le quedan  " + Convert.ToString(5 - Convert.ToInt32(drAcceso["intentos"].ToString())) + "", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txtUsuario.Text = "";
                            txtContraseña.Text = "";
                        }
                    }
                }
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
