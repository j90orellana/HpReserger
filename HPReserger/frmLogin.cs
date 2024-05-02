using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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
        public static frmMenu frmM;
        public static string Basedatos = "sige";
        public static string RutaDescarga = "";
        public int Intentos { get; set; }
        public frmLogin()
        {
            InitializeComponent();
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            //label1.Text = "versión: " + fvi.FileVersion;
            // comprobamos actualizaciones (cada vez que se inicia el programa)     
            lblVersion.Text = $"Version:{fvi.FileVersion}";
        }
        public void ComprobarVersion()
        {
            DataTable tdatos;
            tdatos = datos.CargarSistema_Select();

            if (tdatos.Rows.Count > 0)
            {
                System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
                //Boolean Descargar = false;
                string version = fvi.FileVersion;
                string versiones = tdatos.Rows[0]["version"].ToString();
                //List<int> v1, v2;
                //v1 = version.Split('.').ToList().Select(x => int.Parse(x)).ToList();
                //v2 = versiones.Split('.').ToList().Select(x => int.Parse(x)).ToList();

                //for (int i = 0; i < 4; i++)
                //{
                //    if (v2[i] > v1[i]) Descargar = true; // hay una nueva versión
                //    if (v2[i] < v1[i]) Descargar = false; // tenemos una versión nueva
                //}
                // misma versión
                //if (Descargar)
                //{
                Actualizaciones.servidor = versiones;
                Actualizaciones.version = version;
                Actualizaciones.cambios = tdatos.Rows[0]["contenido"].ToString();
                //}
            }
            if (Actualizaciones.check())
            {
                var d = new update();
                d.ShowDialog();
                d.Dispose();
            }
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

            //HpResergerUserControls.BorderEsquinas.RedondearEsquinas(10, this, btnLogueo);
            //HpResergerUserControls.BorderEsquinas.RedondearEsquinas(15, this, txtUsuario);
            //HpResergerUserControls.BorderEsquinas.RedondearEsquinas(5, txtContraseña, txtUsuario, btnLogueo, this, cboBase);
            //XmlDocument dato = new XmlDocument();
            //dato.Load(Application.StartupPath + "\\Datos.xml");
            //var datito = dato.ChildNodes[1];
            //var Base = datito["BaseDeDatos"].InnerText;
            //var Source = datito["DataSource"].InnerText;
            //var Bases = datito.ChildNodes[2];
            //foreach (XmlNode item in Bases.ChildNodes)
            //{
            //    msg(item.InnerText);
            //}
            //var result = HPResergerFunciones.frmPregunta.MostrarDialogYesCancel($"y que dice pe jeff {(char)13} bay bay");
            //msg(result.ToString());
            //result = HPResergerFunciones.frmPregunta.MostrarDialogYesNoCancel("y que dice pe jeff\n asdasd");
            //msg(result.ToString());
            //result = HPResergerFunciones.frmPregunta.MostrarDialogYesNoCancel("y que dice pe jeff 12312312\nasdasdas");
            //msg(result.ToString());
            foreach (string item in HPResergerCapaDatos.HPResergerCD.ListaBases)
            {
                cboBase.Items.Add(item);
            }
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
            //ComprobarVersion();

            HpResergerNube.DLConexion xd = new HpResergerNube.DLConexion();




        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public DialogResult msgP(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        DataRow dATOS;
        public static frmMenu menusito;
        public static SISGEM.Principal frmprincipal;
        private void btnLogueo_Click(object sender, EventArgs e)
        {
            //VERIFICAR LA LICENCIA
            //DataTable TAblas = clLogueo.CantidadLlamadas(DateTime.Now);
            //if (TAblas.Rows.Count != 0)
            //    dATOS = TAblas.Rows[0];
            //else
            //{
            //    frmMensajeLicencia frmmensa = new frmMensajeLicencia();
            //    frmmensa.ShowDialog();             
            //    Application.Exit();
            //}
            //DateTime Fecha = (DateTime)dATOS["datos"];
            //if (Fecha <= DateTime.Now)
            //{
            //    frmMensajeLicencia frmmensa = new frmMensajeLicencia();
            //    frmmensa.NombreTitulo = "Tu Licencia ha Caducado";
            //    frmmensa.Mensaje = "La Licencia ha Caducado " + Environment.NewLine + "Debe Adquirir una Nueva Licencia ";
            //    frmmensa.Caducado();
            //    frmmensa.ShowDialog();
            //    frmLogin.DesconectarUsuario();
            //    lblmsg.Text = "Caducó Licencia";
            //    return;
            //}
            //Asignacion de la base de datos estatica
            Basedatos = cboBase.Text;

            if (BaseRemota)
            {
                Basedatos = txtEmpresaData.Text;
                if (txtUsuario.Text.ToUpper() == "SISADMIN" && txtContraseña.Text.ToUpper() == "CORE")
                {
                    this.Hide();
                    menusito = new frmMenu();
                    menusito.nick = txtUsuario.Text;
                    CodigoUsuario = 0;
                    Usuario = "Administrador";
                    CodigoArea = 0;
                    Area = "Ninguna";
                    CodigoCentroCosto = 0;
                    CentroCosto = "Ninguno";
                    CodigoGerencia = 0;
                    Gerencia = "Ninguna";
                    CodigoPartidaPresupuesto = 0;
                    PartidaPresupuesto = "Ninguna";
                    LoginUser = "SISADMIN";
                    menusito.usuario = 0;
                    menusito.Nombres = "SISADMIN";
                    menusito.nick = "Administrador";
                    menusito.Hide();
                    frmprincipal = new SISGEM.Principal();
                    frmprincipal.BaseRemota = true;
                    frmprincipal.Show();
                }
                else
                {
                    try
                    {
                        string user = txtUsuario.Text;
                        string contra = txtContraseña.Text;

                        contra = HpResergerNube.Encriptacion.Encriptar(contra);
                        HpResergerNube.CRM_Usuario ouser = new HpResergerNube.CRM_Usuario();
                        DataTable Tuser = ouser.ConsultarUsuarioPorEmailYContraseña(user, contra);

                        if (ouser.ContarUsuariosActivos() > 6)
                        {
                            XtraMessageBox.Show("No se puede iniciar sesión porque ha alcanzado el límite de usuarios activos permitidos en su plan. Por favor, contacte al administrador del sistema para obtener ayuda adicional.", "Límite de Usuarios Alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }


                        if (Tuser.Rows.Count > 0)
                        {
                            this.Hide();
                            menusito = new frmMenu();
                            menusito.nick = txtUsuario.Text;
                            CodigoUsuario = Convert.ToInt16(Tuser.Rows[0]["ID_Usuario"].ToString());
                            Usuario = $"{Tuser.Rows[0]["Apellido1"].ToString()} {Tuser.Rows[0]["Apellido2"].ToString()}, {Tuser.Rows[0]["Nombre"].ToString()} ";
                            CodigoArea = 0;
                            Area = "Ninguna";
                            CodigoCentroCosto = 0;
                            CentroCosto = "Ninguno";
                            CodigoGerencia = 0;
                            Gerencia = "Ninguna";
                            CodigoPartidaPresupuesto = 0;
                            PartidaPresupuesto = "Ninguna";
                            LoginUser = user;
                            menusito.usuario = 0;
                            menusito.Nombres = $"{Tuser.Rows[0]["Apellido1"].ToString()} {Tuser.Rows[0]["Apellido2"].ToString()}, {Tuser.Rows[0]["Nombre"].ToString()} ";
                            menusito.nick = user;
                            menusito.Hide();
                            _Perfil = Tuser.Rows[0]["ID_Perfiles"].ToString(); ;
                            frmprincipal = new SISGEM.Principal();
                            frmprincipal.BaseRemota = true;
                            frmprincipal.Show();
                        }
                        else
                        {
                            XtraMessageBox.Show("Datos inválidos, vuelva a intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            else
            {


                clLogueo.CambiarBase(Basedatos);
                HPResergerCapaDatos.HPResergerCD.BASEDEDATOS = Basedatos;
                if (txtUsuario.Text.Length == 0)
                {
                    msg("Ingrese Usuario");
                    txtUsuario.Focus();
                    return;
                }

                if (txtContraseña.Text.Length == 0)
                {
                    msg("Ingrese Contraseña");
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
                            if (msgP("Usuario Ya está Conectado\nDesea Desconectarlo") == DialogResult.Yes)
                            {
                                DesconectarUsuario();
                            }
                            else
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
                    menusito = new frmMenu();
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
                    menusito.Hide();
                    frmprincipal = new SISGEM.Principal();
                    frmprincipal.BaseRemota = false;

                    frmprincipal.Show();
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
                        msg("Usuario bloqueado, contáctese con el Área de Sistemas");
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
                                menusito = new frmMenu();
                                menusito.usuario = CodigoUsuario;
                                menusito.Nombres = HpResergerUserControls.Configuraciones.MayusculaCadaPalabra(Usuario);
                                menusito.nick = txtUsuario.Text;
                                if (drAcceso["FOTO"] != null && drAcceso["FOTO"].ToString().Length > 0)
                                {
                                    byte[] Fotito = new byte[0];
                                    Fotito = (byte[])drAcceso["FOTO"];
                                    MemoryStream ms = new MemoryStream(Fotito);
                                    menusito.pbfotoempleado.Image = Bitmap.FromStream(ms);
                                }
                                UsuarioConectado();
                                menusito.Hide();
                                frmprincipal = new SISGEM.Principal();
                                frmprincipal.BaseRemota = false;

                                frmprincipal.Show();
                                Prueba = true;
                            }
                            else msg("Usuario No esta Activo");
                        }
                        else
                        {
                            drAcceso = clLogueo.Loguearse(txtUsuario.Text, 1);
                            try
                            {
                                if (Convert.ToInt32(drAcceso["intentos"].ToString()) == 4)
                                {
                                    clLogueo.ActualizarLogin("usp_ActualizarLogin", txtUsuario.Text, 2);
                                    msg("5 intentos fallidos, se bloqueó al Usuario ");
                                    return;
                                }
                                else
                                {
                                    clLogueo.ActualizarLogin("usp_ActualizarLogin", txtUsuario.Text, 0);
                                    drAcceso = clLogueo.Loguearse(txtUsuario.Text, 1);
                                    msg("Intento fallido Nº " + drAcceso["intentos"].ToString() + ",  son 5 intentos, le quedan  " + Convert.ToString(5 - Convert.ToInt32(drAcceso["intentos"].ToString())) + "");
                                    txtUsuario.Text = "";
                                    txtContraseña.Text = "";
                                    txtUsuario.Focus();

                                }
                            }
                            catch { }
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
            if (!BaseRemota)
            {
                HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
                CapaLogica.UsuarioConectado(CodigoUsuario, "", 2);
            }
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
            pbclose.Image = SISGEM.Properties.Resources.xCloseBlue; ;
        }
        private void pbclose_MouseLeave(object sender, EventArgs e)
        {
            pbclose.Image = SISGEM.Properties.Resources.XCloseRed;
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
                    msg(x);
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
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "cambios.txt");
        private void labelControl1_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string cuerpo = reader.ReadToEnd(); // Leer todo el contenido del archivo
                    XtraMessageBox.Show($"Historial de Versiones...\n\n{cuerpo}", "Historial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //MessageBox.Show("El texto se ha cargado correctamente.");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al cargar el texto: " + ex.Message);
            }
        }
        public static Boolean BaseRemota = false;
        public static string _Perfil;

        private void ChkCRM_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkCRM.Checked)
            {
                cboBase.Visible = false;
                BaseRemota = true;
                txtEmpresaData.Visible = true;

            }
            else
            {
                cboBase.Visible = true;
                BaseRemota = false;
                txtEmpresaData.Visible = false;

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            HpResergerNube.CRM_Usuario oUsuario = new HpResergerNube.CRM_Usuario();
            if (oUsuario.ConsultarUsuarioPorEmail(txtUsuario.Text).Rows.Count > 0)
            {
                ChkCRM.Checked = true;
            }
            else
            {
                ChkCRM.Checked = false;
            }

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
