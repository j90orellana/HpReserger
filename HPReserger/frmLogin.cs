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
        HPResergerCapaDatos.HPResergerCD datos = new HPResergerCapaDatos.HPResergerCD();

        public static int CodigoUsuario;
        public static string Usuario;
        public static string LoginUser;
        public static int CodigoArea;
        public static string Area;
        public static int CodigoCentroCosto;
        public static string CentroCosto;
        public static int CodigoGerencia;
        public static string Gerencia;
        public static int CodigoPartidaPresupuesto;
        public static string PartidaPresupuesto;
        public frmMenu frmM;
        public static string Basedatos = "sige";
        public int Intentos { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                txtContraseña.Focus();
            }
        }
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                cboBase.Focus();
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            HpResergerUserControls.frmInformativo.MostrarDialog("Cargando el sistema");
            cboBase.Items.Add("Actual");
            cboBase.Items.Add("SiGE");
            cboBase.Items.Add("Actual_Beta");      
            cboBase.SelectedIndex = 0;
            clLogueo.CambiarBase(Basedatos);
            HPResergerCapaDatos.HPResergerCD.BASEDEDATOS = Basedatos;
            Intentos = 0;
            //int con = 0, stoc = 0;
            //clLogueo.delproducto(2, out con, out stoc);
            //msg($"con {con} stock {stoc}");

            //moveControl1.cargar();
            // OpenFileDialog dias = new OpenFileDialog();
            // dias.ShowDialog();
            //SaveFileDialog save = new SaveFileDialog();
            //save.ShowDialog();
            //string asa = File.ReadAllText(dias.FileName);
            //File.WriteAllText(save.FileName, asa);
            //File.Decrypt(dias.FileName);

            //System.Drawing.Drawing2D.GraphicsPath GRafico = new System.Drawing.Drawing2D.GraphicsPath();
            //GRafico.AddEllipse(0.12f, 0.12f,this.Width, this.Width );
            //this.Region = new Region(GRafico);
        }
        public DialogResult msg(string cadena)
        {
            return MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnLogueo_Click(object sender, EventArgs e)
        {
            //VERIFICAR LA LICENCIA
            if (frmMenu.DateLicense.AddYears(1) < DateTime.Now)
            {
                frmMensajeLicencia frmmensa = new frmMensajeLicencia();
                frmmensa.NombreTitulo = "Tu Licencia ha Caducado";
                frmmensa.Mensaje = "La Licencia ha Caducado " + Environment.NewLine + "Debe Adquirir una Nueva Licencia ";
                frmmensa.Caducado();
                frmmensa.ShowDialog();
                frmLogin.DesconectarUsuario();
                lblmsg.Text = "Caducó Licencia";
                return;
            }
            //Asignacion de la base de datos estatica
            Basedatos = cboBase.Text;
            clLogueo.CambiarBase(Basedatos);
            HPResergerCapaDatos.HPResergerCD.BASEDEDATOS = Basedatos;
            if (txtUsuario.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Usuario", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
                return;
            }

            if (txtContraseña.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Contraseña", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContraseña.Focus();
                return;
            }
            //VALIDAR SI YA ESTA LOGEADO EL USARIO
            //frmProcesando frmproce = new frmProcesando("Conectado a la Base");            
            //frmproce.Show();
            lblmsg.Text = "Conectando a la Base de Datos";
            DataTable TablaAcceso = clLogueo.UsuarioConectado(frmLogin.CodigoUsuario, txtUsuario.Text, 0);
            //Regresa si no hay conexion a la Base de Datos;
            if (TablaAcceso == null) { lblmsg.Text = "No se Encontró la Base de Datos"; return; }
            //frmproce.Close();
            lblmsg.Text = "";
            if (TablaAcceso.Rows.Count > 0)
            {
                DataRow filitaAcceso = TablaAcceso.Rows[0];
                if (filitaAcceso != null)
                {
                    if (filitaAcceso["conectado"].ToString() != "0")
                    {
                        msg("Usuario YA está Conectado");
                        return;
                    }
                }
                else
                {
                    msg("No Se Pudo Conectar con la Base de datos");
                    return;
                }
            }
            Boolean Prueba = false;
            //verificacion si hay usuarios por defecto
            DataTable datito = new DataTable();
            datito = clLogueo.usuarios("0", 0, 0);
            Boolean Admin;
            if (datito.Rows.Count > 0)
                Admin = false;
            else Admin = true;
            //entra por modo admin si no hay usuarios en el sistema
            if (txtUsuario.Text == txtContraseña.Text.ToUpper() && txtContraseña.Text.ToUpper() == "ADMIN" && Admin)
            {
                this.Hide();
                frmMenu menusito = new frmMenu();
                menusito.nick = txtUsuario.Text;
                CodigoUsuario = 0;
                Usuario = "0";
                CodigoArea = 0;
                Area = "Ninguna";
                CodigoCentroCosto = 0;
                CentroCosto = "Ninguno";
                CodigoGerencia = 0;
                Gerencia = "Ninguna";
                CodigoPartidaPresupuesto = 0;
                PartidaPresupuesto = "Ninguna";
                LoginUser = "Usuario Prueba";
                menusito.usuario = 0;
                menusito.Nombres = "Usuario Prueba";
                menusito.nick = "Usuario Prueba";
                menusito.Show();
                Prueba = true;
            }
            if (Prueba)
                return;
            DataRow drAcceso;
            drAcceso = clLogueo.Loguearse(txtUsuario.Text, 0);
            if (drAcceso == null)
            {
                txtUsuario.Focus();
                return;
            }
            else
            {
                drAcceso = clLogueo.Loguearse(txtUsuario.Text, 2);
                if (Convert.ToInt32(drAcceso["Estado"].ToString()) == 0)
                {
                    MessageBox.Show("Usuario bloqueado, contáctese con el Área de Sistemas", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                            LoginUser = drAcceso["LOGINUSER"].ToString();
                            this.Hide();
                            frmM = new frmMenu();
                            frmM.usuario = CodigoUsuario;
                            frmM.Nombres = Usuario;
                            frmM.nick = txtUsuario.Text;
                            if (drAcceso["FOTO"] != null && drAcceso["FOTO"].ToString().Length > 0)
                            {
                                byte[] Fotito = new byte[0];
                                Fotito = (byte[])drAcceso["FOTO"];
                                MemoryStream ms = new MemoryStream(Fotito);
                                frmM.pbfotoempleado.Image = Bitmap.FromStream(ms);
                            }
                            UsuarioConectado();
                            frmM.Show();
                        }
                        else msg("Usuario No esta Activo");
                    }
                    else
                    {
                        drAcceso = clLogueo.Loguearse(txtUsuario.Text, 1);
                        if (Convert.ToInt32(drAcceso["intentos"].ToString()) == 4)
                        {
                            clLogueo.ActualizarLogin("usp_ActualizarLogin", txtUsuario.Text, 2);
                            MessageBox.Show("5 intentos fallidos, se bloqueó al Usuario " + txtUsuario.Text + "", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                        else
                        {
                            clLogueo.ActualizarLogin("usp_ActualizarLogin", txtUsuario.Text, 0);
                            drAcceso = clLogueo.Loguearse(txtUsuario.Text, 1);
                            MessageBox.Show("Intento fallido Nº " + drAcceso["intentos"].ToString() + ",  son 5 intentos, le quedan  " + Convert.ToString(5 - Convert.ToInt32(drAcceso["intentos"].ToString())) + "", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txtUsuario.Text = "";
                            txtContraseña.Text = "";
                            txtUsuario.Focus();
                        }
                    }
                }
            }
        }
        public static void UsuarioConectado()
        {
            HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
            CapaLogica.UsuarioConectado(CodigoUsuario, "", 1);
        }
        public static void DesconectarUsuario()
        {
            HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
            CapaLogica.UsuarioConectado(CodigoUsuario, "", 2);
        }
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        int x, y;
        Boolean mover = false;

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                this.Location = new Point(Left + e.X - x, Top + e.Y - y);
            }
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                this.Location = new Point(Left + e.X - x, Top + e.Y - y);
                mover = false;
            }
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void pbclose_MouseMove(object sender, MouseEventArgs e)
        {
            pbclose.Image = HPReserger.Properties.Resources.xCloseBlue; ;
        }
        private void pbclose_MouseLeave(object sender, EventArgs e)
        {
            pbclose.Image = HPReserger.Properties.Resources.XCloseRed;
        }
        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLogueo_MouseMove(object sender, MouseEventArgs e)
        {
        }
        private void btnLogueo_MouseLeave(object sender, EventArgs e)
        {
        }

        private void txtUsuario_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        string[] cadena;
        private void txtUsuario_DragDrop(object sender, DragEventArgs e)
        {
            cadena = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (cadena != null)
                foreach (string x in cadena)
                    MessageBox.Show(x);
        }

        private void textBoxPer1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                txtContraseña.Focus();

        }
        private void moveControl1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogueo.Focus();
            }
        }

        private void frmLogin_Paint(object sender, PaintEventArgs e)
        {

            //RectangleF myRectangleF = this.DisplayRectangle;

            //// Call the Round method.
            //Rectangle roundedRectangle = Rectangle.Round(myRectangleF);

            //// Draw the rounded rectangle in red.
            //Pen redPen = new Pen(Color.Red, 4);
            //e.Graphics.DrawRectangle(redPen, roundedRectangle);
            //// Call the Truncate method.
            //Rectangle truncatedRectangle = Rectangle.Truncate(myRectangleF);

            //// Draw the truncated rectangle in white.
            //Pen whitePen = new Pen(Color.White, 4);
            //e.Graphics.DrawRectangle(whitePen, truncatedRectangle);

            //// Dispose of the custom pens.
            //redPen.Dispose();
            //whitePen.Dispose();
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X; y = e.Y; mover = true;
            }
        }
    }
}
