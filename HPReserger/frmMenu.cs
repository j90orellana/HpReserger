﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Net;
using HpResergerUserControls;
using Newtonsoft.Json;

namespace HPReserger
{
    public partial class frmMenu : Form, IForm, IFormEmpleado, IRentas, IProfesion, IEpsAdicional
    {
        public frmMenu()
        {
            InitializeComponent();
            ICono = this.Icon;
        }
        public static int Users = 0;
        //public static DateTime DateLicense = new DateTime(2018, 11, 16);//2 Noviembre del 2019
        public static int DaysCaducatesLicence = 30;
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public static Icon ICono;
        public void CargarEpsAdicional()
        {
            if (frmE != null)
                frmE.CargarEpsAdicional();
        }
        public void CargarPLanes()
        {
            if (frmE != null)
                frmE.CargarPLanes();
        }
        public void CargarNroHijos(int tipo, string doc)
        {
            if (frmE != null)
                frmE.CargarNroHijos(tipo, doc);
        }
        public void CargarContratos()
        {
            //frmE.VerificarContrato();
            if (frmE != null)
                frmE.CargarContratos();
        }
        public void BuscarRenta(params int[] opcion)
        {
            if (opcion.Contains(1))
                if (recibohonorario != null)
                    recibohonorario.BuscarRenta();
            if (opcion.Contains(2))
                if (frmfac != null)
                    frmfac.BuscarIgv();
        }
        private void editarAnularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarOrdenesPedido frmLOP = new frmListarOrdenesPedido();
            frmLOP.Icon = ICono;
            frmLOP.Show();
        }
        frmCotizacion frmCOT;
        private void generaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCOT == null)
            {
                frmCOT = new frmCotizacion();
                frmCOT.Icon = ICono;
                frmCOT.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmCOT.FormClosed += new FormClosedEventHandler(cerrar_cotizacion);
                frmCOT.Show();
            }
            else
            {
                frmCOT.Activate();
                ValidarVentanas(frmCOT);
            }
        }
        public void CambiarImagen(PictureBox fotito)
        {
            pbfotoempleado.Image = fotito.Image;
        }
        public void RecargarMenu()
        {
            menuStrip2.SuspendLayout();
            DataTable datos = new DataTable();
            CapaLogica = new HPResergerCapaLogica.HPResergerCL();
            DataRow filita;
            datos = CapaLogica.usuarios(frmLogin.LoginUser, 1, 10);
            if (datos.Rows.Count > 0)
            {
                filita = datos.Rows[0];
                //Saco los menus de los perfiles
                datos = CapaLogica.ListarPerfiles((int)filita["CODIGOPERFIL"], 99, 0, 1, DateTime.Now);
                //Paso todo a Invisibles!              
                foreach (ToolStripMenuItem x in menuStrip2.Items)
                {
                    OcultarMenus(x);
                    //foreach (ToolStripMenuItem xx in x.DropDownItems)
                    //{
                    //    if (xx.Tag != null && xx.Tag.ToString() != "8")
                    //    {
                    //        xx.Visible = false;
                    //    }
                    //    foreach (ToolStripMenuItem xxx in xx.DropDownItems)
                    //    {
                    //        if (xxx.Tag != null && xxx.Tag.ToString() != "8")
                    //        {
                    //            xxx.Visible = false;
                    //        }
                    //    }
                    //    if (xx.Tag != null && xx.Tag.ToString() != "8")
                    //    {
                    //        xx.Visible = false;
                    //    }
                    //}
                    //if (x.Tag != null && x.Tag.ToString() != "8")
                    //{
                    //    x.Visible = false;
                    //}
                }
                //Creo una lista con los Menus que voy a Mostrar
                List<string> Lista = new List<string>();
                foreach (DataRow a in datos.Rows)
                {
                    Lista.Add(a["titulo"].ToString());
                }
                //Muestro los Menus de la lista que le Pertecen al perfil!
                foreach (ToolStripMenuItem x in menuStrip2.Items)
                {
                    if (RecorrerMenus(Lista, x))
                        x.Visible = true;
                }
                menuStrip2.ResumeLayout();
                //menuStrip2.PerformLayout();
                //Prioridad por Usuario!
                ControlPerfilPrioritario();
            }
        }
        private void OcultarMenus(ToolStripMenuItem x)
        {
            for (int i = 0; i < x.DropDownItems.Count; i++)
            {
                if (x.DropDownItems[i].GetType() == typeof(ToolStripMenuItem))
                {
                    var xx = (ToolStripMenuItem)x.DropDownItems[i];
                    if (xx.Tag != null && xx.Tag.ToString() != "8")
                    {
                        xx.Visible = false;
                    }
                    OcultarMenus(xx);
                }
                if (x.DropDownItems[i].GetType() == typeof(ToolStripSeparator))
                {
                    x.DropDownItems[i].Visible = false;
                }
            }
            if (x.Tag != null && x.Tag.ToString() != "8")
                x.Visible = false;
        }
        private Boolean RecorrerMenus(List<string> lista, ToolStripMenuItem x)
        {
            Boolean prueba = false;
            for (int i = 0; i < x.DropDownItems.Count; i++)
            {
                if (x.DropDownItems[i].GetType() == typeof(ToolStripMenuItem))
                {
                    var xx = (ToolStripMenuItem)x.DropDownItems[i];
                    if (RecorrerMenus(lista, xx))
                        x.Visible = true;
                    if (lista.Contains(xx.Tag))
                    {
                        xx.Visible = true; prueba = true;
                    }
                }
                if (x.DropDownItems[i].GetType() == typeof(ToolStripSeparator))
                {
                    if (lista.Contains(x.DropDownItems[i].Tag))
                        x.DropDownItems[i].Visible = true;
                }
                if (prueba)
                {
                    x.Visible = true;
                }
            }
            return prueba;
            //Sí se Muestra un SubMenu, se Muestra El Menu!

        }
        DataRow dATOS;
        private void frmMenu_Load(object sender, EventArgs e)
        {
            //SISGEM.ModuloReportes.Form1 frmx = new SISGEM.ModuloReportes.Form1();
            //frmx.Show();

            Application.ApplicationExit += new EventHandler(ExitApplication);
            CapaLogica.CambiarBase(frmLogin.Basedatos);
            RecargarMenu();
            DataTable TAblas = CapaLogica.CantidadLlamadas(DateTime.Now);
            if (TAblas.Rows.Count != 0)
                dATOS = TAblas.Rows[0];
            else
            {
                frmMensajeLicencia frmmensa = new frmMensajeLicencia();
                frmmensa.ShowDialog();
                ExitApplication(sender, e);
                cerrar = 10;
                Application.Exit();
            }
            DataTable table = CapaLogica.UsuarioConectado(frmLogin.CodigoUsuario, "", 10);
            DataRow file = table.Rows[0];
            int ConUsuarios = (int)file["usuarios"];
            Users = ((int)dATOS["usuario"]);// * (int)dATOS["duracion"]) - (int)dATOS["nrollamadas"];
            DateTime Fecha = (DateTime)dATOS["datos"];
            if (Nombres != "Administrador")
                if (ConUsuarios > frmMenu.Users)
                {
                    //mensaje de Cancelación
                    frmMensajeLicencia frmmensa = new frmMensajeLicencia();
                    frmmensa.ShowDialog();
                    ExitApplication(sender, e);
                    cerrar = 10;
                    Application.Exit();
                }
                else if (DateTime.Now > Fecha)
                {
                    //mensaje de Cancelación
                    frmMensajeLicencia frmmensa = new frmMensajeLicencia();
                    frmmensa.Mensaje = "Su Licencia a Caducado";
                    frmmensa.ShowDialog();
                    ExitApplication(sender, e);
                    cerrar = 10;
                    Application.Exit();
                }
            MdiClient mdi;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    mdi = (MdiClient)ctl;
                    mdi.BackColor = Color.FromArgb(240, 240, 240);
                    //fondoColorOre1.control = mdi;
                }
                catch (InvalidCastException)
                {
                }
            }
            cerrado = 0;
            bienvenido = lblwelcome.Text = "Bienvenido: " + Nombres;
            ConsultarCaducarLicencia();
            ConsultarCumpleaños();
            length = FlowPanel.Width;
            ImagenDefault = pbesquina.Image;
            FlowPanel_ControlRemoved_1(sender, new ControlEventArgs(FlowPanel));
            if (FlowPanel.Controls.Count > 0)
                Mostrado = true;
            else
                Mostrado = false;
            pbesquina_Click(sender, e);
            VerFotoAdmin();
            Text = Text + $" [{frmLogin.Basedatos}]";
            //FlowPanel.Paint += new PaintEventHandler(FrmMenu_Paint); ---Gradiente Lineal de varios colores de fondo de control   +            
            //PRUEBA DE CARGAS DE FORMULARIOS

            if (frmLogin.CodigoUsuario != 0)
            {
                btnCargarSistema.Visible = false;
            }
        }
        public void ControlPerfilPrioritario()
        {
            periodosToolStripMenuItem.Visible = false;
            if ((new int[] { 0, 1, 2 }).Contains(frmLogin.CodigoUsuario))//Luego se lo cambia por el perfil
            {
                periodosToolStripMenuItem.Visible = true;
            }
        }
        public void VerFotoAdmin()
        {
            if (frmLogin.Usuario == "ADMIN")
                pbfotoempleado.Image = imglist.Images[0];
        }
        private void ExitApplication(object sender, EventArgs e)
        {
            frmLogin.DesconectarUsuario();
        }
        private void ConsultarCaducarLicencia()
        {

            var resul = (int)dATOS["FECHAS"];
            //(HPResergerCapaDatos.HPResergerCD.FechaCaduca - DateTime.Now);
            if (resul <= DaysCaducatesLicence)
            {
                HpResergerUserControls.FotoCheck fotito = new HpResergerUserControls.FotoCheck();
                //fotito.BackColor = Color.Transparent;
                fotito.Nombre = "Mensaje de Licencia";
                fotito.Cargo = $"Su Licencia Caduca en";
                fotito.Observacion = $"{resul} Dias";
                fotito.ImagenLicencia();
                FlowPanel.Controls.Add(fotito);
                fotito.Width = FlowPanel.Width;
            }
        }
        private void FrmMenu_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(FlowPanel.ClientRectangle, Color.Black, Color.Black, 180);
            ColorBlend cblend = new ColorBlend(3);
            cblend.Colors = new Color[3] { Color.White, Color.Red, Color.White };
            cblend.Positions = new float[3] { 0f, 0.5f, 1f };
            linearGradientBrush.InterpolationColors = cblend;
            e.Graphics.FillRectangle(linearGradientBrush, FlowPanel.ClientRectangle);
        }
        public void ConsultarCumpleaños()
        {
            DataTable Table = new DataTable();
            Table = CapaLogica.ConsultarCumpleano();
            if (Table.Rows.Count > 0)
            {
                foreach (DataRow item in Table.Rows)
                {
                    HpResergerUserControls.FotoCheck fotito = new HpResergerUserControls.FotoCheck();
                    //fotito.BackColor = Color.Transparent;
                    fotito.Nombre = item["empleado"].ToString();
                    fotito.Cargo = item["cargo"].ToString();
                    string Extra = "";
                    DateTime Fech = (DateTime)item["fila"];
                    if (Fech.Date == DateTime.Now.Date) Extra = " (HOY) ";
                    else
                    if (Fech.Date == DateTime.Now.Date.AddDays(1)) Extra = " (MAÑANA) ";
                    else
                        Extra = " (" + ((Fech.Date.Subtract(DateTime.Now.Date)).Days) + " Dias) ";
                    ///fin de Muestra de Fechas
                    fotito.Observacion = $"Cumpleaño{Extra}el {((DateTime)item["fila"]).ToString("dd")} de {((DateTime)item["fila"]).ToString("MMMM")} ";
                    if (item["foto"] != null && item["foto"].ToString().Length > 0)
                    {
                        byte[] Fotito = new byte[0];
                        Fotito = (byte[])((byte[])item["foto"]);
                        MemoryStream ms = new MemoryStream(Fotito);
                        fotito.FotoPerfil = Bitmap.FromStream(ms);
                    }
                    else
                    {
                        //hombre
                        if (item["sexo"].ToString() == "1") fotito.FotodeHombre();
                        //mujer
                        if (item["sexo"].ToString() == "2") fotito.FotodeMujer();
                    }
                    FlowPanel.Controls.Add(fotito);
                    fotito.Width = FlowPanel.Width;
                }
            }

        }
        public void ValidarVentanas(Form formulario)
        {
            if (formulario.WindowState != FormWindowState.Normal)
                formulario.WindowState = FormWindowState.Normal;
            // if (formulario.StartPosition != FormStartPosition.CenterParent)
            //   formulario.StartPosition = FormStartPosition.CenterParent;
            //this.LayoutMdi(MdiLayout.);
            formulario.Left = (Width - formulario.Width) / 2;
            formulario.Top = ((Height - formulario.Height) / 2) - lblwelcome.Height;
            OnMdiChildActivate(null);
            ValidarFormularios();
        }
        void cerrar_cotizacion(object sender, FormClosedEventArgs e)
        {
            frmCOT = null;
            //pbfotoempleado.Visible = false;
        }
        frmAprobarCotizacion frmACOT;
        private void aprobaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmACOT == null)
            {
                frmACOT = new frmAprobarCotizacion();
                frmACOT.MdiParent = this;
                frmACOT.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmACOT.FormClosed += new FormClosedEventHandler(cerrara_aprobacion);
                frmACOT.Show();
            }
            else
            {
                frmACOT.Activate();
                ValidarVentanas(frmACOT);
            }
        }
        void cerrara_aprobacion(object sender, FormClosedEventArgs e)
        {
            frmACOT = null;
            //pbfotoempleado.Visible = false;
        }
        frmOrdenCompra frmOC;
        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmOC == null)
            {
                frmOC = new frmOrdenCompra();
                frmOC.MdiParent = this;
                frmOC.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmOC.FormClosed += new FormClosedEventHandler(cerrar_ordencompra);
                frmOC.Show();
            }
            else
            {
                frmOC.Activate();
                ValidarVentanas(frmOC);
            }
        }
        void cerrar_ordencompra(object sender, FormClosedEventArgs e)
        {
            frmOC = null;
            //pbfotoempleado.Visible = false;
        }
        frmAlmacen frmArti;
        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmArti == null)
            {
                frmArti = new frmAlmacen();
                frmArti.MdiParent = this;
                frmArti.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmArti.FormClosed += new FormClosedEventHandler(cerrar_articulos_fics);
                frmArti.Show();
            }
            else
            {
                frmArti.Activate();
                ValidarVentanas(frmArti);
            }
        }
        void cerrar_articulos_fics(object sender, FormClosedEventArgs e)
        {
            frmArti = null;
            //pbfotoempleado.Visible = false;
        }
        frmAlmacenServicio frmAS;
        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAS == null)
            {
                frmAS = new frmAlmacenServicio();
                frmAS.MdiParent = this;
                frmAS.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmAS.FormClosed += new FormClosedEventHandler(cerraralamacenservicio);
                frmAS.Show();
            }
            else
            {
                frmAS.Activate();
                ValidarVentanas(frmAS);
            }
        }
        void cerraralamacenservicio(object sender, FormClosedEventArgs e)
        {
            frmAS = null;
            //pbfotoempleado.Visible = false;
        }
        frmSolicitudEmpleado frmSE;
        private void solicitudEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmSE == null)
            {
                frmSE = new frmSolicitudEmpleado();
                frmSE.MdiParent = this;
                frmSE.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmSE.FormClosed += new FormClosedEventHandler(cerrar_alamacenmservicio);
                frmSE.Show();
            }
            else
            {
                frmSE.Activate();
                ValidarVentanas(frmSE);
            }
        }
        void cerrar_alamacenmservicio(object sender, FormClosedEventArgs e)
        {
            frmSE = null;
            //pbfotoempleado.Visible = false;
        }
        frmPostulante frmP;
        private void postulanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmP == null)
            {
                frmP = new frmPostulante();
                frmP.MdiParent = this;
                frmP.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmP.FormClosed += new FormClosedEventHandler(cerrarpostulante);
                frmP.Show();
            }
            else
            {
                frmP.Activate();
                ValidarVentanas(frmP);
            }
        }
        void cerrarpostulante(object sender, FormClosedEventArgs e)
        {
            frmP = null;
            //pbfotoempleado.Visible = false;
        }
        frmEmpleado frmE;
        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmE == null)
            {
                frmE = new frmEmpleado();
                frmE.MdiParent = this;
                frmE.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmE.FormClosed += new FormClosedEventHandler(cerrarempleado);
                frmE.Show();
            }
            else
            {
                frmE.Activate();
                ValidarVentanas(frmE);
            }
        }
        void cerrarempleado(object sender, FormClosedEventArgs e)
        {
            frmE = null;
            //pbfotoempleado.Visible = false;
        }
        frmOrdenPedido frmOP;
        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmOP == null)
            {
                frmOP = new frmOrdenPedido();
                frmOP.MdiParent = this;
                frmOP.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmOP.FormClosed += new FormClosedEventHandler(cerrar_orden_pedido);
                frmOP.Show();
            }
            else
            {
                frmOP.Activate();
                ValidarVentanas(frmOP);
            }
        }
        void cerrar_orden_pedido(object sender, FormClosedEventArgs e)
        {
            frmOP = null;
            //pbfotoempleado.Visible = false;
        }
        frmVacaciones frmVaca;
        private void vacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmVaca == null)
            {
                frmVaca = new frmVacaciones();
                frmVaca.MdiParent = this;
                frmVaca.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmVaca.FormClosed += new FormClosedEventHandler(cerrarvacaciones);
                frmVaca.Show();
            }
            else
            {
                frmVaca.Activate();
                ValidarVentanas(frmVaca);
            }
        }
        void cerrarvacaciones(object sender, FormClosedEventArgs e)
        {
            frmVaca = null;
            //pbfotoempleado.Visible = false;
        }
        frmDesvinculacion frmDesv;
        private void desvinculaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDesv == null)
            {
                frmDesv = new frmDesvinculacion();
                frmDesv.MdiParent = this;
                frmDesv.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmDesv.FormClosed += new FormClosedEventHandler(cerrardesvinculacion);
                frmDesv.Show();
            }
            else
            {
                frmDesv.Activate();
                ValidarVentanas(frmDesv);
            }
        }
        void cerrardesvinculacion(object sender, FormClosedEventArgs e)
        {
            frmDesv = null;
            //pbfotoempleado.Visible = false;
        }
        frmFaltas frmF;
        private void faltasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmF == null)
            {
                frmF = new frmFaltas();
                frmF.MdiParent = this;
                frmF.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmF.FormClosed += new FormClosedEventHandler(cerrarfaltas);
                frmF.Show();
            }
            else
            {
                frmF.Activate();
                ValidarVentanas(frmF);
            }
        }
        void cerrarfaltas(object sender, FormClosedEventArgs e)
        {
            frmF = null;
            //pbfotoempleado.Visible = false;
        }
        frmAmonestacionesPremio frmAP;
        private void amonestacionesPremiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAP == null)
            {
                frmAP = new frmAmonestacionesPremio();
                frmAP.MdiParent = this;
                frmAP.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmAP.FormClosed += new FormClosedEventHandler(cerraramonestaciones);
                frmAP.Show();
            }
            else
            {
                frmAP.Activate();
                ValidarVentanas(frmAP);
            }
        }
        void cerraramonestaciones(object sender, FormClosedEventArgs e)
        {
            frmAP = null;
            //pbfotoempleado.Visible = false;
        }
        frmArea area;
        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (area == null)
            {
                area = new frmArea();
                area.MdiParent = this;
                area.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                area.FormClosed += new FormClosedEventHandler(cerrarareas);
                area.Show();
            }
            else
            {
                area.Activate();
                ValidarVentanas(area);
            }
        }
        void cerrarareas(object sender, FormClosedEventArgs e)
        {
            area = null;
            //pbfotoempleado.Visible = false;
        }
        frmgerencia gere;
        private void gerenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (gere == null)
            {
                gere = new frmgerencia();
                gere.MdiParent = this;
                gere.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                gere.FormClosed += new FormClosedEventHandler(cerrargerencia);
                gere.Show();
            }
            else
            {
                gere.Activate();
                ValidarVentanas(gere);
            }
        }
        void cerrargerencia(object sender, FormClosedEventArgs e)
        {
            gere = null;
            //pbfotoempleado.Visible = false;
        }
        frmccosto costo;
        private void centroDeCostosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (costo == null)
            {
                costo = new frmccosto();
                costo.MdiParent = this;
                costo.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                costo.FormClosed += new FormClosedEventHandler(cerrarcentrocc);
                costo.Show();
            }
            else
            {
                costo.Activate();
                ValidarVentanas(costo);
            }
        }
        void cerrarcentrocc(object sender, FormClosedEventArgs e)
        {
            costo = null;
            //pbfotoempleado.Visible = false;
        }
        frmArticuloServicio artiser;
        private void articuloServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (artiser == null)
            {
                artiser = new frmArticuloServicio();
                artiser.MdiParent = this;
                artiser.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                artiser.FormClosed += new FormClosedEventHandler(cerrararticuloservicio);
                artiser.Show();
            }
            else
            {
                artiser.Activate();
                ValidarVentanas(artiser);
            }
        }
        void cerrararticuloservicio(object sender, FormClosedEventArgs e)
        {
            artiser = null;
            //pbfotoempleado.Visible = false;
        }
        frmmarca marca;
        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (marca == null)
            {
                marca = new frmmarca();
                marca.MdiParent = this;
                marca.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                marca.FormClosed += new FormClosedEventHandler(cerrarmarcas);
                marca.Show();
            }
            else
            {
                marca.Activate();
                ValidarVentanas(marca);
            }
        }
        void cerrarmarcas(object sender, FormClosedEventArgs e)
        {
            marca = null;
            //pbfotoempleado.Visible = false;
        }
        frmmarcamodelo marcamodelo;
        private void marcamodeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (marcamodelo == null)
            {
                marcamodelo = new frmmarcamodelo();
                marcamodelo.MdiParent = this;
                marcamodelo.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                marcamodelo.FormClosed += new FormClosedEventHandler(cerrarmarcamodelo);
                marcamodelo.Show();
            }
            else
            {
                marcamodelo.Activate();
                ValidarVentanas(marcamodelo);
            }
        }
        void cerrarmarcamodelo(object sender, FormClosedEventArgs e)
        {
            marcamodelo = null;
            //pbfotoempleado.Visible = false;
        }
        frmmodelo modelo;
        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modelo == null)
            {
                modelo = new frmmodelo();
                modelo.MdiParent = this;
                modelo.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                modelo.FormClosed += new FormClosedEventHandler(cerrarmodelo);
                modelo.Show();
            }
            else
            {
                modelo.Activate();
                ValidarVentanas(modelo);
            }
        }
        void cerrarmodelo(object sender, FormClosedEventArgs e)
        {
            modelo = null;
            //pbfotoempleado.Visible = false;
        }
        frmdepartamento dep;
        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dep == null)
            {
                dep = new frmdepartamento();
                dep.MdiParent = this;
                dep.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                dep.FormClosed += new FormClosedEventHandler(cerrardepartamento);
                dep.Show();
            }
            else
            {
                dep.Activate();
                ValidarVentanas(dep);
            }
        }
        void cerrardepartamento(object sender, FormClosedEventArgs e)
        {
            dep = null;
            //pbfotoempleado.Visible = false;
        }
        frmprovincias provin;
        private void provinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (provin == null)
            {
                provin = new frmprovincias();
                provin.MdiParent = this;
                provin.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                provin.FormClosed += new FormClosedEventHandler(cerrarprovincia);
                provin.Show();
            }
            else
            {
                provin.Activate();
                ValidarVentanas(provin);
            }
        }
        void cerrarprovincia(object sender, FormClosedEventArgs e)
        {
            provin = null;
            //pbfotoempleado.Visible = false;
        }
        frmDistritos distritos;
        private void distritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (distritos == null)
            {
                distritos = new frmDistritos();
                distritos.MdiParent = this;
                distritos.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                distritos.FormClosed += new FormClosedEventHandler(cerrardistrito);
                distritos.Show();
            }
            else
            {
                distritos.Activate();
                ValidarVentanas(distritos);
            }
        }
        void cerrardistrito(object sender, FormClosedEventArgs e)
        {
            distritos = null;
            //pbfotoempleado.Visible = false;
        }
        frmEntiFinanciera entidad;
        private void entidadesFinancierasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (entidad == null)
            {
                entidad = new frmEntiFinanciera();
                entidad.MdiParent = this;
                entidad.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                entidad.FormClosed += new FormClosedEventHandler(cerrarentidad);
                entidad.Show();
            }
            else
            {
                entidad.Activate();
                ValidarVentanas(entidad);
            }
        }
        void cerrarentidad(object sender, FormClosedEventArgs e)
        {
            entidad = null;
            //pbfotoempleado.Visible = false;
        }
        frmproveedor provee;
        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (provee == null)
            {
                provee = new frmproveedor();
                provee.MdiParent = this;
                provee.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                provee.FormClosed += new FormClosedEventHandler(cerrarproveedor);
                provee.Show();
            }
            else
            {
                provee.Activate();
                ValidarVentanas(provee);
            }
        }
        void cerrarproveedor(object sender, FormClosedEventArgs e)
        {
            provee = null;
            //pbfotoempleado.Visible = false;
        }
        frmTipoId tipoid;
        private void tipoIdentidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tipoid == null)
            {
                tipoid = new frmTipoId();
                tipoid.MdiParent = this;
                tipoid.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                tipoid.FormClosed += new FormClosedEventHandler(cerrartipoid);
                tipoid.Show();
            }
            else
            {
                tipoid.Activate();
                ValidarVentanas(tipoid);
            }
        }
        void cerrartipoid(object sender, FormClosedEventArgs e)
        {
            tipoid = null;
            //pbfotoempleado.Visible = false;
        }
        frmdinamicaContable dinamica;
        private void dinamicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dinamica == null)
            {
                dinamica = new frmdinamicaContable();
                dinamica.MdiParent = this;
                dinamica.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                dinamica.FormClosed += new FormClosedEventHandler(cerrardinamicacontable);
                dinamica.Show();
            }
            else
            {
                dinamica.Activate();
                ValidarVentanas(dinamica);
            }
        }
        void cerrardinamicacontable(object sender, FormClosedEventArgs e)
        {
            dinamica = null;
            //pbfotoempleado.Visible = false;
        }
        frmcuentacontable cuenta;
        private void cuentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cuenta == null)
            {
                cuenta = new frmcuentacontable();
                cuenta.MdiParent = this;
                cuenta.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                cuenta.FormClosed += new FormClosedEventHandler(cerrarcuentascontanles);
                cuenta.Show();
            }
            else
            {
                cuenta.Activate();
                ValidarVentanas(cuenta);
            }
        }
        void cerrarcuentascontanles(object sender, FormClosedEventArgs e)
        {
            cuenta = null;
            //pbfotoempleado.Visible = false;
        }
        frmAsientoContable asiento;
        private void asientoContableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (asiento == null)
            {
                asiento = new frmAsientoContable();
                asiento.MdiParent = this;
                asiento.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                asiento.FormClosed += new FormClosedEventHandler(cerrarasientocontable);
                asiento.Show();
            }
            else
            {
                asiento.Activate();
                ValidarVentanas(asiento);
            }
        }
        void cerrarasientocontable(object sender, FormClosedEventArgs e)
        {
            asiento = null;
            //pbfotoempleado.Visible = false;
        }
        FrmPerfil perfil;
        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (perfil == null)
            {
                perfil = new FrmPerfil();
                perfil.MdiParent = this;
                perfil.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                perfil.FormClosed += new FormClosedEventHandler(cerrarperfil);
                perfil.Show();
            }
            else
            {
                perfil.Activate();
                ValidarVentanas(perfil);
            }
        }
        void cerrarperfil(object sender, FormClosedEventArgs e)
        {
            perfil = null;
            //pbfotoempleado.Visible = false;
        }
        public int usuario;
        public string nick;
        public string Nombres;

        FrmUsuarios usua;
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usua == null)
            {
                usua = new FrmUsuarios();
                usua.MdiParent = this;
                usua.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                usua.FormClosed += new FormClosedEventHandler(cerrarususaruio);
                usua.Show();
            }
            else
            {
                usua.Activate();
                ValidarVentanas(usua);
            }
        }
        void cerrarususaruio(object sender, FormClosedEventArgs e)
        {
            usua = null;
            //pbfotoempleado.Visible = false;
        }
        FrmCambioContra contra;
        private void cambioDeClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contra == null)
            {
                contra = new FrmCambioContra();
                contra.idusuario = usuario;
                contra.password = nick;
                contra.MdiParent = this;
                contra.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                contra.FormClosed += new FormClosedEventHandler(cerrarusuuario);
                contra.Show();
            }
            else
            {
                contra.Activate();
                ValidarVentanas(contra);
            }
        }
        void cerrarusuuario(object sender, FormClosedEventArgs e)
        {
            contra = null;
            //pbfotoempleado.Visible = false;
        }
        int cerrar = 0;
        public static Boolean AbortarCerrarPrograma = false;
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ValidacionesParaCerrar()) e.Cancel = true;
            else
            {
                if (cerrado == 0 && cerrar == 10)
                {
                    frmLogin.DesconectarUsuario();
                    Application.Exit();
                }
                if (cerrar == 0)
                {
                    if (msgp("Seguro Desea Salir del Sistema") == DialogResult.Yes)
                    {
                        try
                        {
                            cerrado = 0; cerrar = 10;
                            frmLogin.DesconectarUsuario();
                            Application.Exit();
                        }
                        catch { }
                    }
                    else
                        e.Cancel = true;

                }
                if (cerrar == 5)
                {
                    cerrar = 10;
                }
            }
        }
        frmListarOCFaltantes frmlisoc;
        private void listarOCFaltantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmlisoc == null)
            {
                frmlisoc = new frmListarOCFaltantes();
                frmlisoc.MdiParent = this;
                frmlisoc.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmlisoc.FormClosed += new FormClosedEventHandler(cerrarlistasoc);
                frmlisoc.Show();
            }
            else
            {
                frmlisoc.Activate();
                ValidarVentanas(frmlisoc);
            }

        }
        void cerrarlistasoc(object sender, FormClosedEventArgs e)
        {
            frmlisoc = null;
            //pbfotoempleado.Visible = false;
        }
        FrmFactura frmfac;
        private void facturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmfac == null)
            {
                frmfac = new FrmFactura();
                frmfac.MdiParent = this;
                frmfac.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmfac.FormClosed += new FormClosedEventHandler(cerrarfactura);
                frmfac.Show();
            }
            else
            {
                frmfac.Activate();
                ValidarVentanas(frmfac);
            }
        }
        void cerrarfactura(object sender, FormClosedEventArgs e)
        {
            frmfac = null;
            //pbfotoempleado.Visible = false;
        }
        Frmreporteop orde;
        private void ordenesPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (orde == null)
            {
                orde = new Frmreporteop();
                orde.MdiParent = this;
                orde.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                orde.FormClosed += new FormClosedEventHandler(cerrarordernesdepedido);
                orde.Show();
            }
            else
            {
                orde.Activate();
                ValidarVentanas(orde);
            }
        }
        void cerrarordernesdepedido(object sender, FormClosedEventArgs e)
        {
            orde = null;
            //pbfotoempleado.Visible = false;
        }
        private void seguimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        frmreporteordencompra frmreporteoc;
        private void ordenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmreporteoc == null)
            {
                frmreporteoc = new frmreporteordencompra();
                frmreporteoc.MdiParent = this;
                frmreporteoc.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmreporteoc.FormClosed += new FormClosedEventHandler(cerrarodernesdecomprareporte);
                frmreporteoc.Show();
            }
            else
            {
                frmreporteoc.Activate();
                ValidarVentanas(frmreporteoc);
            }
        }
        void cerrarodernesdecomprareporte(object sender, FormClosedEventArgs e)
        {
            frmreporteoc = null;
            //pbfotoempleado.Visible = false;
        }
        frmreporteempleado reporemple;
        private void empleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (reporemple == null)
            {
                reporemple = new frmreporteempleado();
                reporemple.MdiParent = this;
                reporemple.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                reporemple.FormClosed += new FormClosedEventHandler(cerrarempleadoreporte);
                reporemple.Show();
            }
            else
            {
                reporemple.Activate();
                ValidarVentanas(reporemple);
            }
        }
        void cerrarempleadoreporte(object sender, FormClosedEventArgs e)
        {
            reporemple = null;
            //pbfotoempleado.Visible = false;
        }
        int cerrado = 0;
        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!ValidacionesParaCerrar())
            {
                if (msgp("Seguro Desea Cerrar Sesión") == DialogResult.Yes)

                {
                    cerrado = 1; cerrar = 5;
                    this.Close();
                    frmLogin logeo = new frmLogin();
                    frmLogin.DesconectarUsuario();
                    logeo.Show();
                }
            }
        }
        frmGenerarBoletas genbole;
        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (genbole == null)
            {
                genbole = new frmGenerarBoletas();
                genbole.MdiParent = this;
                genbole.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                genbole.FormClosed += new FormClosedEventHandler(cerrargeneeraboletas);
                genbole.Show();
            }
            else
            {
                genbole.Activate();
                ValidarVentanas(genbole);
            }
        }
        void cerrargeneeraboletas(object sender, FormClosedEventArgs e)
        {
            genbole = null;
            //pbfotoempleado.Visible = false;
        }
        FrmGenerarRemuneracionRenta remunrenta;
        private void generarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (remunrenta == null)
            {
                remunrenta = new FrmGenerarRemuneracionRenta();
                remunrenta.MdiParent = this;
                remunrenta.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                remunrenta.FormClosed += new FormClosedEventHandler(cerrargenerarrenta);
                remunrenta.Show();
            }
            else
            {
                remunrenta.Activate();
                ValidarVentanas(remunrenta);
            }
        }
        void cerrargenerarrenta(object sender, FormClosedEventArgs e)
        {
            remunrenta = null;
            //pbfotoempleado.Visible = false;
        }
        frmProyectos proyectos;
        private void proyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proyectos == null)
            {
                proyectos = new frmProyectos();
                proyectos.MdiParent = this;
                proyectos.Icon = ICono;
                // proyectos.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                proyectos.FormClosed += new FormClosedEventHandler(presus_cerrarproyec);
                proyectos.Show();
            }
            else
            {
                proyectos.Activate();
                ValidarVentanas(proyectos);
            }
        }

        void presus_cerrarproyec(object sender, FormClosedEventArgs e)
        {
            proyectos = null;
            //pbfotoempleado.Visible = false;
        }
        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {
        }
        frmpresupuesto presus;
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (presus == null)
            {
                presus = new frmpresupuesto();
                presus.MdiParent = this;
                presus.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                presus.FormClosed += new FormClosedEventHandler(presus_cerrarpresus);
                presus.Show();
                ////pbfotoempleado.Visible = false;
            }
            else
            {
                presus.Activate();
                ValidarVentanas(presus);
            }
        }
        void presus_cerrarpresus(object sender, FormClosedEventArgs e)
        {
            presus = null;
            //pbfotoempleado.Visible = false;
        }
        private void seguimientoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }
        frmReportePresupuestoOperaciones presuope;
        private void presupuestoOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (presuope == null)
            {
                presuope = new frmReportePresupuestoOperaciones();
                presuope.MdiParent = this;
                presuope.Icon = ICono;
                ////pbfotoempleado.Visible = false;
                //  presuope.StartPosition = FormStartPosition.CenterParent;
                presuope.FormClosed += new FormClosedEventHandler(presus_cerrarpresusope);
                presuope.Show();
            }
            else
            {
                presuope.Activate();
                ValidarVentanas(presuope);
            }
        }
        void presus_cerrarpresusope(object sender, FormClosedEventArgs e)
        {
            presuope = null;
            //pbfotoempleado.Visible = false;
        }
        frmReportePresupuestoCuenta presuscuenta;
        private void presupuestoOperacionesCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (presuscuenta == null)
            {
                presuscuenta = new frmReportePresupuestoCuenta();
                presuscuenta.MdiParent = this;
                presuscuenta.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                presuscuenta.FormClosed += new FormClosedEventHandler(presus_cerrarpresusoperaciones);
                presuscuenta.Show();
            }
            else
            {
                presuscuenta.Activate();
                ValidarVentanas(presuscuenta);
            }
        }
        void presus_cerrarpresusoperaciones(object sender, FormClosedEventArgs e)
        {
            presuscuenta = null;
            //pbfotoempleado.Visible = false;
        }
        frmPagarFactura pagarfac;
        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pagarfac == null)
            {
                pagarfac = new frmPagarFactura();
                pagarfac.MdiParent = this;
                pagarfac.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                pagarfac.FormClosed += new FormClosedEventHandler(presus_cerrarpagarfactura);
                pagarfac.Show();
            }
            else
            {
                pagarfac.Activate();
                ValidarVentanas(pagarfac);
            }
        }
        void presus_cerrarpagarfactura(object sender, FormClosedEventArgs e)
        {
            pagarfac = null;
            //pbfotoempleado.Visible = false;
        }
        frmREciboPorHonorario recibohonorario;
        private void reciboPorHonorariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (recibohonorario == null)
            {
                recibohonorario = new frmREciboPorHonorario();
                recibohonorario.MdiParent = this;
                recibohonorario.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                recibohonorario.FormClosed += new FormClosedEventHandler(cerrarreciboporhonorario);
                recibohonorario.Show();
            }
            else
            {
                recibohonorario.Activate();
                ValidarVentanas(recibohonorario);
            }
        }
        void cerrarreciboporhonorario(object sender, FormClosedEventArgs e)
        {
            recibohonorario = null;
            //pbfotoempleado.Visible = false;
        }
        frmFacturasPorPagar facturaporpagar;
        private void facturasSinPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (facturaporpagar == null)
            {
                facturaporpagar = new HPReserger.frmFacturasPorPagar();
                facturaporpagar.MdiParent = this;
                facturaporpagar.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                facturaporpagar.FormClosed += new FormClosedEventHandler(cerrarfacturasinpagar);
                facturaporpagar.Show();
            }
            else
            {
                facturaporpagar.Activate();
                ValidarVentanas(facturaporpagar);
            }
        }
        void cerrarfacturasinpagar(object sender, FormClosedEventArgs e)
        {
            facturaporpagar = null;
            //pbfotoempleado.Visible = false;
        }
        frmFicSinFaactura ficsinfactura;
        private void ficSinComprobantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ficsinfactura == null)
            {
                ficsinfactura = new frmFicSinFaactura();
                ficsinfactura.MdiParent = this;
                ficsinfactura.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                ficsinfactura.FormClosed += new FormClosedEventHandler(cerrarfcisincomprobante);
                ficsinfactura.Show();
            }
            else
            {
                ficsinfactura.Activate();
                ValidarVentanas(ficsinfactura);
            }
        }
        void cerrarfcisincomprobante(object sender, FormClosedEventArgs e)
        {
            ficsinfactura = null;
            //pbfotoempleado.Visible = false;
        }
        frmListarOCFaltantes ocfaltantes;
        private void listarOCFaltantesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (ocfaltantes == null)
            {
                ocfaltantes = new frmListarOCFaltantes();
                ocfaltantes.MdiParent = this;
                ocfaltantes.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                ocfaltantes.FormClosed += new FormClosedEventHandler(cerrarlistaroc);
                ocfaltantes.Show();
            }
            else
            {
                ocfaltantes.Activate();
                ValidarVentanas(ocfaltantes);
            }
        }
        void cerrarlistaroc(object sender, FormClosedEventArgs e)
        {
            ocfaltantes = null;
            //pbfotoempleado.Visible = false;
        }
        private void lblwelcome_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cuentasContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void valorizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void seguimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestiónDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consolidaciónDeEEFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbfotoempleado.Image.Save("holi", pbfotoempleado.Image.RawFormat);


        }

        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
            }
        }
        private void cargarPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog var = new OpenFileDialog();
            var.Filter = "Pdf|*.pdf";
            var.Multiselect = false;
            if (var.ShowDialog() != DialogResult.Cancel)
            {
                frmVerPdf ver = new frmVerPdf();
                ver.nombreformulario = var.FileName;
                ver.ruta = var.FileName;
                ver.Icon = ICono;
                //8ver.EstadoVentana = FormWindowState.Maximized;
                ver.ShowDialog();
            }
        }
        frmCargos Cargos;
        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Cargos == null)
            {
                Cargos = new frmCargos();
                Cargos.MdiParent = this;
                Cargos.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                Cargos.FormClosed += new FormClosedEventHandler(cerrarcargos);
                Cargos.Show();
            }
            else
            {
                Cargos.Activate();
                ValidarVentanas(Cargos);
            }
        }
        void cerrarcargos(object sender, FormClosedEventArgs e)
        {
            Cargos = null;
            //pbfotoempleado.Visible = false;
        }
        frmEmpresaEps frmEps;
        private void empresasEPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEps == null)
            {
                frmEps = new frmEmpresaEps();
                frmEps.MdiParent = this;
                frmEps.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmEps.FormClosed += new FormClosedEventHandler(cerrarempresapes);
                frmEps.Show();
            }
            else
            {
                frmEps.Activate();
                ValidarVentanas(frmEps);
            }
        }
        void cerrarempresapes(object sender, FormClosedEventArgs e)
        {
            frmEps = null;
            //pbfotoempleado.Visible = false;
        }
        frmadicionaleps frmepsadicional;
        private void epsAdicionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmepsadicional == null)
            {
                frmepsadicional = new frmadicionaleps();
                frmepsadicional.MdiParent = this;
                frmepsadicional.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmepsadicional.FormClosed += new FormClosedEventHandler(cerrarepsadicional);
                frmepsadicional.Show();
            }
            else
            {
                frmepsadicional.Activate();
                ValidarVentanas(frmepsadicional);
            }
        }
        void cerrarepsadicional(object sender, FormClosedEventArgs e)
        {
            frmepsadicional = null;
            //pbfotoempleado.Visible = false;
        }
        frmEstadoCivil EstadoCivil;
        private void estadoCivilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EstadoCivil == null)
            {
                EstadoCivil = new frmEstadoCivil();
                EstadoCivil.MdiParent = this;
                EstadoCivil.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                EstadoCivil.FormClosed += new FormClosedEventHandler(cerrarestadocivil);
                EstadoCivil.Show();
            }
            else
            {
                EstadoCivil.Activate();
                ValidarVentanas(EstadoCivil);
            }
        }
        void cerrarestadocivil(object sender, FormClosedEventArgs e)
        {
            EstadoCivil = null;
            //pbfotoempleado.Visible = false;
        }
        frmGradoInstitucional frmGRado;
        private void gradoInstitucionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmGRado == null)
            {
                frmGRado = new frmGradoInstitucional();
                frmGRado.MdiParent = this;
                frmGRado.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmGRado.FormClosed += new FormClosedEventHandler(cerrargrado);
                frmGRado.Show();
            }
            else
            {
                frmGRado.Activate();
                ValidarVentanas(frmGRado);
            }
        }
        void cerrargrado(object sender, FormClosedEventArgs e)
        {
            frmGRado = null;
            //pbfotoempleado.Visible = false;
        }
        frmmoneda frmmoneda;
        private void monedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmmoneda == null)
            {
                frmmoneda = new frmmoneda();
                frmmoneda.MdiParent = this;
                frmmoneda.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmmoneda.FormClosed += new FormClosedEventHandler(cerrarmonedas);
                frmmoneda.Show();
            }
            else
            {
                frmmoneda.Activate();
                ValidarVentanas(frmmoneda);
            }
        }
        void cerrarmonedas(object sender, FormClosedEventArgs e)
        {
            frmmoneda = null;
            //pbfotoempleado.Visible = false;
        }
        frmperiodicidad periocidad;
        private void periocidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (periocidad == null)
            {
                periocidad = new frmperiodicidad();
                periocidad.MdiParent = this;
                periocidad.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                periocidad.FormClosed += new FormClosedEventHandler(cerrarperiocidad);
                periocidad.Show();
            }
            else
            {
                periocidad.Activate();
                ValidarVentanas(periocidad);
            }
        }
        void cerrarperiocidad(object sender, FormClosedEventArgs e)
        {
            periocidad = null;
            //pbfotoempleado.Visible = false;
        }
        frmprofesion frmProfe;
        private void profesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmProfe == null)
            {
                frmProfe = new frmprofesion();
                frmProfe.MdiParent = this;
                frmProfe.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmProfe.FormClosed += new FormClosedEventHandler(cerrarprofesion);
                frmProfe.Show();
            }
            else
            {
                frmProfe.Activate();
                ValidarVentanas(frmProfe);
            }
        }
        void cerrarprofesion(object sender, FormClosedEventArgs e)
        {
            frmProfe = null;
            //pbfotoempleado.Visible = false;
        }
        frmSectorEmpresarial Sector;
        private void sectorEmpresarialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Sector == null)
            {
                Sector = new frmSectorEmpresarial();
                Sector.MdiParent = this;
                Sector.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                Sector.FormClosed += new FormClosedEventHandler(cerrarsector);
                Sector.Show();
            }
            else
            {
                Sector.Activate();
                ValidarVentanas(Sector);
            }
        }
        void cerrarsector(object sender, FormClosedEventArgs e)
        {
            Sector = null;
            //pbfotoempleado.Visible = false;
        }
        frmcede frmcede;
        private void sedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmcede == null)
            {
                frmcede = new frmcede();
                frmcede.MdiParent = this;
                frmcede.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmcede.FormClosed += new FormClosedEventHandler(cerrarsedes);
                frmcede.Show();
            }
            else
            {
                frmcede.Activate();
                ValidarVentanas(frmcede);
            }
        }
        void cerrarsedes(object sender, FormClosedEventArgs e)
        {
            frmcede = null;
            //pbfotoempleado.Visible = false;
        }
        frmSexo frmsexo;
        private void sexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmsexo == null)
            {
                frmsexo = new frmSexo();
                frmsexo.MdiParent = this;
                frmsexo.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmsexo.FormClosed += new FormClosedEventHandler(cerrarsexos);
                frmsexo.Show();
            }
            else
            {
                frmsexo.Activate();
                ValidarVentanas(frmsexo);
            }
        }
        void cerrarsexos(object sender, FormClosedEventArgs e)
        {
            frmsexo = null;
            //pbfotoempleado.Visible = false;
        }
        frmtipocontratacion_ contrata;
        private void tipoContrataciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contrata == null)
            {
                contrata = new frmtipocontratacion_();
                contrata.MdiParent = this;
                contrata.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                contrata.FormClosed += new FormClosedEventHandler(cerrartipocontratacion);
                contrata.Show();
            }
            else
            {
                contrata.Activate();
                ValidarVentanas(contrata);
            }
        }
        void cerrartipocontratacion(object sender, FormClosedEventArgs e)
        {
            contrata = null;
            //pbfotoempleado.Visible = false;
        }
        frmtipocontrato frmcontrato;
        private void tipoDeContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmcontrato == null)
            {
                frmcontrato = new frmtipocontrato();
                frmcontrato.MdiParent = this;
                frmcontrato.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmcontrato.FormClosed += new FormClosedEventHandler(cerrartipocontrato);
                frmcontrato.Show();
            }
            else
            {
                frmcontrato.Activate();
                ValidarVentanas(frmcontrato);
            }
        }
        void cerrartipocontrato(object sender, FormClosedEventArgs e)
        {
            frmcontrato = null;
            //pbfotoempleado.Visible = false;
        }
        frmvinculacionfamiliar frmVinculo;
        private void vinculoFamiliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmVinculo == null)
            {
                frmVinculo = new frmvinculacionfamiliar();
                frmVinculo.MdiParent = this;
                frmVinculo.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmVinculo.FormClosed += new FormClosedEventHandler(cerrarvinculofamiliar);
                frmVinculo.Show();
            }
            else
            {
                frmVinculo.Activate();
                ValidarVentanas(frmVinculo);
            }
        }
        void cerrarvinculofamiliar(object sender, FormClosedEventArgs e)
        {
            frmVinculo = null;
            //pbfotoempleado.Visible = false;
        }
        frmAfpEmpresas frmEmpresaafp;
        private void afpsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEmpresaafp == null)
            {
                frmEmpresaafp = new frmAfpEmpresas();
                frmEmpresaafp.MdiParent = this;
                frmEmpresaafp.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmEmpresaafp.FormClosed += new FormClosedEventHandler(cerrarafpsEmpresas);
                frmEmpresaafp.Show();
            }
            else
            {
                frmEmpresaafp.Activate();
                ValidarVentanas(frmEmpresaafp);
            }
        }
        private void cerrarafpsEmpresas(object sender, FormClosedEventArgs e)
        {
            frmEmpresaafp = null;
        }
        frmInstitucionesEducativas frmedu;
        private void institucionesEducativasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmedu == null)
            {
                frmedu = new frmInstitucionesEducativas();
                frmedu.MdiParent = this;
                frmedu.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmedu.FormClosed += new FormClosedEventHandler(cerrareducativas);
                frmedu.Show();
            }
            else
            {
                frmedu.Activate();
                ValidarVentanas(frmedu);
            }
        }
        void cerrareducativas(object sender, FormClosedEventArgs e)
        {
            frmedu = null;
            //pbfotoempleado.Visible = false;
        }
        frmPais pais;
        private void paísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pais == null)
            {
                pais = new frmPais();
                pais.MdiParent = this;
                pais.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                pais.FormClosed += new FormClosedEventHandler(cerrarpais);
                pais.Show();
            }
            else
            {
                pais.Activate();
                ValidarVentanas(pais);
            }
        }
        void cerrarpais(object sender, FormClosedEventArgs e)
        {
            pais = null;
            //pbfotoempleado.Visible = false;
        }
        frmOperacion frmope;
        private void operaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmope == null)
            {
                frmope = new frmOperacion();
                frmope.MdiParent = this;
                frmope.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmope.FormClosed += new FormClosedEventHandler(cerraroperaciones);
                frmope.Show();
            }
            else
            {
                frmope.Activate();
                ValidarVentanas(frmope);
            }
        }
        void cerraroperaciones(object sender, FormClosedEventArgs e)
        {
            frmope = null;
            //pbfotoempleado.Visible = false;
        }
        frmSubOperacion frmsub;
        private void subOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmsub == null)
            {
                frmsub = new frmSubOperacion();
                frmsub.MdiParent = this;
                frmsub.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmsub.FormClosed += new FormClosedEventHandler(cerrarsuboperacion);
                frmsub.Show();
            }
            else
            {
                frmsub.Activate();
                ValidarVentanas(frmsub);
            }
        }
        void cerrarsuboperacion(object sender, FormClosedEventArgs e)
        {
            frmsub = null;
            //pbfotoempleado.Visible = false;
        }
        frmEmpresas frmempre;
        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmempre == null)
            {
                frmempre = new frmEmpresas();
                frmempre.MdiParent = this;
                frmempre.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmempre.FormClosed += new FormClosedEventHandler(cerrarempresa);
                frmempre.Show();
            }
            else
            {
                frmempre.Activate();
                ValidarVentanas(frmempre);
            }
        }
        void cerrarempresa(object sender, FormClosedEventArgs e)
        {
            frmempre = null;
            //pbfotoempleado.Visible = false;
        }
        frmParametros frmparam;
        private void parametrosGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmparam == null)
            {
                frmparam = new frmParametros();
                frmparam.MdiParent = this;
                frmparam.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmparam.FormClosed += new FormClosedEventHandler(cerrarparametros);
                frmparam.Show();
            }
            else
            {
                frmparam.Activate();
                ValidarVentanas(frmparam);
            }
        }
        void cerrarparametros(object sender, FormClosedEventArgs e)
        {
            frmparam = null;
            //pbfotoempleado.Visible = false;
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu_FormClosing(sender, new FormClosingEventArgs(CloseReason.UserClosing, false));
        }
        public Boolean ValidacionesParaCerrar()
        {
            if (AbortarCerrarPrograma) { msg("Cierre la Ventana del Detalle del Asiento"); return true; }
            return false;
        }
        private void iconosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        private void frmMenu_Click(object sender, EventArgs e)
        {
        }
        private void frmMenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                cmenuclick.Show(e.X, e.Y);
        }
        private void cerrarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (msgp("Desea Cerrar Todas las Ventanas") == DialogResult.Yes)
            {
                foreach (Form ventanitas in this.MdiChildren)
                {
                    ventanitas.Close();
                }
            }
        }
        private void minimizarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form ventanitas in this.MdiChildren)
            {
                ventanitas.WindowState = FormWindowState.Minimized;
            }
        }

        private void maximizarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form ventanitas in this.MdiChildren)
            {
                ventanitas.WindowState = FormWindowState.Normal;
            }
        }
        frmimpuestoRenta frmrenta;
        private void impuestoALaRentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmrenta == null)
            {
                frmrenta = new frmimpuestoRenta();
                frmrenta.MdiParent = this;
                frmrenta.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmrenta.FormClosed += new FormClosedEventHandler(cerrarrenta);
                frmrenta.Show();
            }
            else
            {
                frmrenta.Activate();
                ValidarVentanas(frmrenta);
            }
        }
        void cerrarrenta(object sender, FormClosedEventArgs e)
        {
            frmrenta = null;
            //pbfotoempleado.Visible = false;
        }

        private void generalesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        frmReportedeFlujoOperaciones frmFlujos;
        private void flujoDeOperacionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmFlujos == null)
            {
                frmFlujos = new frmReportedeFlujoOperaciones();
                frmFlujos.MdiParent = this;
                frmFlujos.Icon = ICono;
                frmFlujos.FormClosed += new FormClosedEventHandler(cerrarformflujos);
                frmFlujos.Show();
            }
            else
            {
                frmFlujos.Activate();
                ValidarVentanas(frmFlujos);
            }
        }
        void cerrarformflujos(object sender, FormClosedEventArgs e)
        {
            frmFlujos = null;
        }
        public void CargarProfesion()
        {
            if (frmE != null)
                ((IProfesion)frmE).CargarProfesion();
        }
        public void CargarGrado()
        {
            if (frmE != null)
                ((IProfesion)frmE).CargarGrado();
        }
        private void frmMenu_Scroll(object sender, ScrollEventArgs e)
        {
            msg("value:" + e.NewValue);
        }
        private void frmMenu_MouseDown(object sender, MouseEventArgs e)
        {
            msg("button:" + e.Button.ToString());
        }
        frmEliminarPeriodo frmelimin;
        private void eliminarPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmelimin == null)
            {
                frmelimin = new frmEliminarPeriodo();
                frmelimin.MdiParent = this;
                frmelimin.Icon = ICono;
                frmelimin.FormClosed += new FormClosedEventHandler(CerrarELiminarPeriodo);
                frmelimin.Show();
            }
            else
            {
                frmelimin.Activate();
                ValidarVentanas(frmelimin);
            }
        }
        private void CerrarELiminarPeriodo(object sender, FormClosedEventArgs e)
        {
            frmelimin = null;
        }
        frmSolicitudes frmsolis;
        private void solicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmsolis == null)
            {
                frmsolis = new frmSolicitudes();
                frmsolis.MdiParent = this;
                frmsolis.Icon = ICono;
                frmsolis.FormClosed += new FormClosedEventHandler(Cerrarsolicitudes);
                frmsolis.Show();
            }
            else
            {
                frmsolis.Activate();
                ValidarVentanas(frmsolis);
            }
        }
        private void Cerrarsolicitudes(object sender, FormClosedEventArgs e)
        {
            frmsolis = null;
        }
        private void frmMenu_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }
        frmTipodeCambio tipocam;
        private void tipoDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tipocam == null)
            {
                tipocam = new frmTipodeCambio();
                tipocam.MdiParent = this;
                tipocam.Icon = ICono;
                tipocam.FormClosed += new FormClosedEventHandler(Cerrartipocam);
                frmMenu_SizeChanged(sender, new EventArgs());
                tipocam.Show();
            }
            else
            {
                tipocam.Activate();
                ValidarVentanas(tipocam);
            }
        }
        private void Cerrartipocam(object sender, FormClosedEventArgs e)
        {
            tipocam = null;
        }
        frmGenerarGratificacion frmgrati;
        private void generarGratificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmgrati == null)
            {
                frmgrati = new frmGenerarGratificacion();
                frmgrati.MdiParent = this;
                frmgrati.Icon = ICono;
                frmgrati.FormClosed += new FormClosedEventHandler(Cerrargrati);
                frmMenu_SizeChanged(sender, new EventArgs());
                frmgrati.Show();
            }
            else
            {
                frmgrati.Activate();
                ValidarVentanas(frmgrati);
            }
        }
        private void Cerrargrati(object sender, FormClosedEventArgs e)
        {
            frmgrati = null;
        }
        frmGenerarCTS frmcts;
        private void generarCTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmcts == null)
            {
                frmcts = new frmGenerarCTS();
                frmcts.MdiParent = this;
                frmcts.Icon = ICono;
                frmcts.FormClosed += new FormClosedEventHandler(cerrarcts);
                frmMenu_SizeChanged(sender, new EventArgs());
                frmcts.Show();
            }
            else
            {
                frmcts.Activate();
                ValidarVentanas(frmcts);
            }
        }
        private void cerrarcts(object sender, FormClosedEventArgs e)
        {
            frmcts = null;
        }
        frmEliminarPeriodo frmeliminGrati;
        private void eliminarGratificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmeliminGrati == null)
            {
                frmeliminGrati = new frmEliminarPeriodo();
                frmeliminGrati.MdiParent = this;
                frmeliminGrati.Opcion = 2;
                frmeliminGrati.Icon = ICono;
                frmeliminGrati.FormClosed += new FormClosedEventHandler(CerrarEliminarGrati);
                frmMenu_SizeChanged(sender, new EventArgs());
                frmeliminGrati.Show();
            }
            else
            {
                frmeliminGrati.Activate();
                ValidarVentanas(frmeliminGrati);
            }
        }
        private void CerrarEliminarGrati(object sender, FormClosedEventArgs e)
        {
            frmeliminGrati = null;
        }
        frmEliminarPeriodo frmeliminCts;
        private void eliminarCTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmeliminCts == null)
            {
                frmeliminCts = new frmEliminarPeriodo();
                frmeliminCts.MdiParent = this;
                frmeliminCts.Opcion = 1;
                frmeliminCts.Icon = ICono;
                frmeliminCts.FormClosed += new FormClosedEventHandler(CerrarELiminarCts);
                frmMenu_SizeChanged(sender, new EventArgs());
                frmeliminCts.Show();
            }
            else
            {
                frmeliminCts.Activate();
                ValidarVentanas(frmeliminCts);
            }
        }
        private void CerrarELiminarCts(object sender, FormClosedEventArgs e)
        {
            frmeliminCts = null;
        }
        frmAbonoExternoEmpleado frmaboext;
        private void abonosExternosEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmaboext == null)
            {
                frmaboext = new frmAbonoExternoEmpleado();
                frmaboext.MdiParent = this;
                frmaboext.Icon = ICono;
                frmaboext.FormClosed += new FormClosedEventHandler(cerrarabonito);
                frmMenu_SizeChanged(sender, new EventArgs());
                frmaboext.Show();
            }
            else
            {
                frmaboext.Activate();
                ValidarVentanas(frmaboext);
            }
        }
        private void cerrarabonito(object sender, FormClosedEventArgs e)
        {
            frmaboext = null;
        }
        FrmReporteBoletas frmreporbole;
        private void boletasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmreporbole == null)
            {
                frmreporbole = new FrmReporteBoletas();
                frmreporbole.MdiParent = this;
                frmreporbole.Icon = ICono;
                frmreporbole.FormClosed += new FormClosedEventHandler(cerrrarboletasreport);
                frmreporbole.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmreporbole.Activate();
                ValidarVentanas(frmreporbole);
            }
        }
        private void cerrrarboletasreport(object sender, FormClosedEventArgs e)
        {
            frmreporbole = null;
        }
        frmAreaCargo frmareacargo;
        private void áreaCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmareacargo == null)
            {
                frmareacargo = new frmAreaCargo();
                frmareacargo.MdiParent = this;
                frmareacargo.Icon = ICono;
                frmareacargo.FormClosed += new FormClosedEventHandler(cerrarareacargos);
                frmareacargo.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmareacargo.Activate();
                ValidarVentanas(frmareacargo);
            }
        }
        private void cerrarareacargos(object sender, FormClosedEventArgs e)
        {
            frmareacargo = null;
        }
        public void ValidarFormularios()
        {
            //  ventanasToolStripMenuItem.DropDownItems.Clear();
            //   foreach (Form frm in MdiChildren)
            //   {
            //       ventanasToolStripMenuItem.DropDownItems.Add(frm.Text.Trim().ToUpper(), null, ckick);
            //   }
        }
        private void ckick(object sender, EventArgs e)
        {
            Boolean Buscar = false;
            foreach (Form frm in MdiChildren)
            {
                if (frm.Text.Trim().ToUpper() == ((ToolStripItem)(sender)).Text.Trim().ToUpper())
                {
                    frm.BringToFront(); Buscar = true;
                }
            }
            if (!Buscar)
            {
                ventanasToolStripMenuItem.DropDownItems.Remove(((ToolStripItem)(sender)));
            }
        }
        private void frmMenu_MdiChildActivate(object sender, EventArgs e)
        {
            //    ValidarFormularios();
        }

        private void sadasdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  ValidarFormularios();
        }

        private void frmMenu_Activated(object sender, EventArgs e)
        {

            // ValidarFormularios();
        }
        private void ventanasToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            //  OnMdiChildActivate(e);
            // ValidarFormularios();
        }
        private void ventanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecargarMenu();
        }

        private void frmMenu_Validated(object sender, EventArgs e)
        {
            //Message Box.Show("y que dice Validado");
        }
        frmPagarBoletas pagarBoletas;
        private void pagarBoletasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pagarBoletas == null)
            {
                pagarBoletas = new frmPagarBoletas();
                pagarBoletas.MdiParent = this;
                pagarBoletas.Icon = ICono;
                pagarBoletas.FormClosed += new FormClosedEventHandler(cerrarPAgarBoletas);
                pagarBoletas.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                pagarBoletas.Activate();
                ValidarVentanas(pagarBoletas);
            }
        }

        private void cerrarPAgarBoletas(object sender, FormClosedEventArgs e)
        {
            pagarBoletas = null;
        }
        frmConfigurarDinamicas frmcofig;
        private void configurarDinamicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmcofig == null)
            {
                frmcofig = new frmConfigurarDinamicas();
                frmcofig.MdiParent = this;
                frmcofig.Icon = ICono;
                frmcofig.FormClosed += new FormClosedEventHandler(cerrarConfigurardinamicas);
                frmcofig.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmcofig.Activate();
                ValidarVentanas(frmcofig);
            }
        }
        private void cerrarConfigurardinamicas(object sender, FormClosedEventArgs e)
        {
            frmcofig = null;
        }

        private void grid1_Load(object sender, EventArgs e)
        {

        }
        private void cascadaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void horizontalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void verticalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void minimizarTodasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
                f.WindowState = FormWindowState.Minimized;
        }
        private void maximizarTodasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
                f.WindowState = FormWindowState.Maximized;
        }
        private void normalTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
                f.WindowState = FormWindowState.Normal;
        }
        private void cerrarTodasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (msgp("Desea Cerrar Todas las Ventanas") == DialogResult.Yes)
                foreach (Form ventanitas in this.MdiChildren)
                    ventanitas.Close();
        }
        EstadoGananciaPerdidas frmEstadogan;
        private void estadoDeGanaciasYPerdidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEstadogan == null)
            {
                frmEstadogan = new EstadoGananciaPerdidas();
                frmEstadogan.MdiParent = this;
                frmEstadogan.Icon = ICono;
                frmEstadogan.FormClosed += new FormClosedEventHandler(cerrarestadodeganacias);
                frmEstadogan.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmEstadogan.Activate();
                ValidarVentanas(frmEstadogan);
            }
        }
        private void cerrarestadodeganacias(object sender, FormClosedEventArgs e)
        {
            frmEstadogan = null;
        }
        frmReporteGeneral FrmReporteGene;
        private void balanceGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmReporteGene == null)
            {
                FrmReporteGene = new frmReporteGeneral();
                FrmReporteGene.MdiParent = this;
                FrmReporteGene.Icon = ICono;
                FrmReporteGene.FormClosed += new FormClosedEventHandler(cerarrbalancegeneral);
                FrmReporteGene.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                FrmReporteGene.Activate();
                ValidarVentanas(FrmReporteGene);
            }
        }
        private void cerarrbalancegeneral(object sender, FormClosedEventArgs e)
        {
            FrmReporteGene = null;
        }
        private void FlowPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            //if (FlowPanel.Controls.Count <= 0)
            //{
            //    FlowPanel.Visible = false;
            //}
            //else
            //{
            //    FlowPanel.Visible = true;
            //}
        }

        private void FlowPanel_ControlRemoved_1(object sender, ControlEventArgs e)
        {
            FlowPanel.SuspendLayout();
            if (FlowPanel.Controls.Count <= 0)
            {
                Mostrado = true;
                pbesquina_Click(sender, e);
                // FlowPanel.Visible = false;               
                //  pbesquina.Visible = false;
            }
            else
            {
                Mostrado = false;
                //pbesquina_Click(sender, e);
                //  FlowPanel.Visible = true;

                // pbesquina.Visible = true;
            }
            FlowPanel.ResumeLayout();
        }
        public Boolean Mostrado = true;
        int length;
        Image ImagenDefault;
        private void pbesquina_Click(object sender, EventArgs e)
        {
            if (Mostrado)
            {
                pbesquina.SuspendLayout();
                //this.SuspendLayout();
                foreach (var formularios in MdiChildren)
                {
                    formularios.SuspendLayout();
                }
                FlowPanel.SuspendLayout();
                //Oculto
                for (int i = length; i > 20; i -= 10)
                {
                    FlowPanel.Width = i;
                    pbesquina.Left = FlowPanel.Left;
                }
                FlowPanel.Width -= 10;
                pbesquina.Left += 10;
                pbesquina.Image = pbesquina.ErrorImage;
                Mostrado = false;
                FlowPanel.ResumeLayout();
                foreach (var formularios in MdiChildren)
                {
                    formularios.ResumeLayout();
                }
                pbesquina.ResumeLayout();
            }
            else
            {
                pbesquina.SuspendLayout();

                foreach (var formularios in MdiChildren)
                {
                    formularios.SuspendLayout();
                }

                FlowPanel.SuspendLayout();
                //Muestra
                for (int i = 20; i < length; i += 10)
                {
                    FlowPanel.Width = i;
                    pbesquina.Left = FlowPanel.Left;
                }
                FlowPanel.Width += 10;
                pbesquina.Left -= 10;
                pbesquina.Image = ImagenDefault;
                Mostrado = true;
                FlowPanel.ResumeLayout();
                foreach (var formularios in MdiChildren)
                {
                    formularios.ResumeLayout();
                }
                pbesquina.ResumeLayout();
            }
        }
        frmPLanesEPS frplaneseps;
        private void planesEPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frplaneseps == null)
            {
                frplaneseps = new frmPLanesEPS();
                frplaneseps.MdiParent = this;
                frplaneseps.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frplaneseps.FormClosed += new FormClosedEventHandler(cerrarplaneseps);
                frplaneseps.Show();
            }
            else
            {
                frplaneseps.Activate();
                ValidarVentanas(frplaneseps);
            }
        }
        private void cerrarplaneseps(object sender, FormClosedEventArgs e)
        {
            frplaneseps = null;
        }
        private void frmMenu_Resize(object sender, EventArgs e)
        {
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, Color.Black, Color.Black, 180);
            ColorBlend cblend = new ColorBlend(3);
            cblend.Colors = new Color[3] { Color.White, Color.Red, Color.White };
            cblend.Positions = new float[3] { 0f, 0.5f, 1f };
            linearGradientBrush.InterpolationColors = cblend;
            this.CreateGraphics().FillRectangle(linearGradientBrush, this.ClientRectangle);
        }
        FrmConfiguracionBalanceSituacionFinanciera frmconfigsitua;
        private void balanceDeSituaciónFinancieraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmconfigsitua == null)
            {
                frmconfigsitua = new FrmConfiguracionBalanceSituacionFinanciera();
                frmconfigsitua.MdiParent = this;
                frmconfigsitua.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmconfigsitua.FormClosed += new FormClosedEventHandler(cerrarConfigFinanciera);
                frmconfigsitua.Show();
            }
            else
            {
                frmconfigsitua.Activate();
                ValidarVentanas(frmconfigsitua);
            }
        }
        private void cerrarConfigFinanciera(object sender, FormClosedEventArgs e)
        {
            frmconfigsitua = null;
        }
        frmConfiguracionBalanceGanacias frmconfigbalanganancias;
        private void estadoDeGananciasYPerdidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmconfigbalanganancias == null)
            {
                frmconfigbalanganancias = new frmConfiguracionBalanceGanacias();
                frmconfigbalanganancias.MdiParent = this;
                frmconfigbalanganancias.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmconfigbalanganancias.FormClosed += new FormClosedEventHandler(cerrarconfigudebalanceganancias);
                frmconfigbalanganancias.Show();
            }
            else
            {
                frmconfigbalanganancias.Activate();
                ValidarVentanas(frmconfigbalanganancias);
            }
        }

        private void cerrarconfigudebalanceganancias(object sender, FormClosedEventArgs e)
        {
            frmconfigbalanganancias = null;
        }

        private void FlowPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            if (FlowPanel.Controls.Count <= 0)
            {
                Mostrado = true;
                pbesquina_Click(sender, e);
                // FlowPanel.Visible = false;
                //  pbesquina.Visible = false;
            }
            else
            {
                Mostrado = false;
                //pbesquina_Click(sender, e);
                //  FlowPanel.Visible = true;
                // pbesquina.Visible = true;
            }
        }
        frmFlujodeCaja frmFLujo;
        private void flujoDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmFLujo == null)
            {
                //cargar lo de flujo
                frmFLujo = new frmFlujodeCaja();
                frmFLujo.MdiParent = this;
                frmFLujo.Icon = ICono;
                frmFLujo.FormClosed += new FormClosedEventHandler(cerrarflujodecaja);
                frmFLujo.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmFLujo.Activate();
                ValidarVentanas(frmFLujo);
            }
        }
        private void cerrarflujodecaja(object sender, FormClosedEventArgs e)
        {
            frmFLujo = null;
        }
        frmProductos frmproducs;
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmproducs == null)
            {
                //cargar lo de flujo
                frmproducs = new frmProductos();
                frmproducs.MdiParent = this;
                frmproducs.Icon = ICono;
                frmproducs.FormClosed += new FormClosedEventHandler(cerrarproductos);
                frmproducs.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmproducs.Activate();
                ValidarVentanas(frmproducs);
            }
        }
        private void cerrarproductos(object sender, FormClosedEventArgs e)
        {
            frmproducs = null;
        }
        frmCargasRegVentas frmregVentas;
        private void cargaRegistroVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmregVentas == null)
            {
                frmregVentas = new frmCargasRegVentas();
                frmregVentas.MdiParent = this;
                frmregVentas.Icon = ICono;
                frmregVentas.FormClosed += new FormClosedEventHandler(cerrarregventas);
                frmregVentas.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmregVentas.Activate();
                ValidarVentanas(frmregVentas);
            }
        }
        private void cerrarregventas(object sender, FormClosedEventArgs e)
        {
            frmregVentas = null;
        }

        private void ganaciasYPerdidasPorFunciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        frmNotaCredito frmnotita;
        private void notaCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmnotita == null)
            {
                frmnotita = new frmNotaCredito(1);
                frmnotita.MdiParent = this;
                frmnotita.Icon = ICono;
                frmnotita.FormClosed += new FormClosedEventHandler(Cerrarnotita);
                frmnotita.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmnotita.Activate();
                ValidarVentanas(frmnotita);
            }
        }
        private void Cerrarnotita(object sender, FormClosedEventArgs e)
        {
            frmnotita = null;
        }
        frmNotaCredito frmnotita2;
        private void notaDébitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmnotita2 == null)
            {
                frmnotita2 = new frmNotaCredito(2);
                frmnotita2.MdiParent = this;
                frmnotita2.Icon = ICono;
                frmnotita2.FormClosed += new FormClosedEventHandler(Cerrarnotita2);
                frmnotita2.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmnotita.Activate();
                ValidarVentanas(frmnotita2);
            }
        }
        private void Cerrarnotita2(object sender, FormClosedEventArgs e)
        {
            frmnotita2 = null;
        }
        frmPeriodos frmperiodos;
        private void periodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmperiodos == null)
            {
                frmperiodos = new frmPeriodos();
                frmperiodos.MdiParent = this;
                frmperiodos.Icon = ICono;
                frmperiodos.FormClosed += new FormClosedEventHandler(cerraperriodos);
                frmperiodos.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmperiodos.Activate();
                ValidarVentanas(frmperiodos);
            }
        }
        private void cerraperriodos(object sender, FormClosedEventArgs e)
        {
            frmperiodos = null;
        }
        frmcierremensual frmcierre;
        private void asientosAbiertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmcierre == null)
            {
                frmcierre = new frmcierremensual();
                frmcierre.MdiParent = this;
                frmcierre.Icon = ICono;
                frmcierre.FormClosed += new FormClosedEventHandler(cerrarcierremensusal);
                frmcierre.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmcierre.Activate();
                ValidarVentanas(frmcierre);
            }
        }
        private void cerrarcierremensusal(object sender, FormClosedEventArgs e)
        {
            frmcierre = null;
        }
        frmdetracciones frmdetraccion;
        private void detraccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmdetraccion == null)
            {
                frmdetraccion = new frmdetracciones();
                frmdetraccion.MdiParent = this;
                frmdetraccion.Icon = ICono;
                frmdetraccion.FormClosed += new FormClosedEventHandler(cerrardetracioneos);
                frmdetraccion.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmdetraccion.Activate();
                ValidarVentanas(frmdetraccion);
            }
        }
        private void cerrardetracioneos(object sender, FormClosedEventArgs e)
        {
            frmdetraccion = null;
        }
        frmComprobantePago frmcomprobantepagito;
        private void comprobantesPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmcomprobantepagito == null)
            {
                frmcomprobantepagito = new frmComprobantePago();
                frmcomprobantepagito.MdiParent = this;
                frmcomprobantepagito.Icon = ICono;
                frmcomprobantepagito.FormClosed += new FormClosedEventHandler(cerrarcomprobatepagiot);
                frmcomprobantepagito.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmcomprobantepagito.Activate();
                ValidarVentanas(frmcomprobantepagito);
            }
        }
        private void cerrarcomprobatepagiot(object sender, FormClosedEventArgs e)
        {
            frmcomprobantepagito = null;
        }
        frmDetracionesPago frmdetracionpago;
        private void pagoDetraccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmdetracionpago == null)
            {
                frmdetracionpago = new frmDetracionesPago();
                frmdetracionpago.MdiParent = this;
                frmdetracionpago.Icon = ICono;
                frmdetracionpago.FormClosed += new FormClosedEventHandler(cerrardetraccionpago);
                frmdetracionpago.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmdetracionpago.Activate();
                ValidarVentanas(frmdetracionpago);
            }
        }
        private void cerrardetraccionpago(object sender, FormClosedEventArgs e)
        {
            frmdetracionpago = null;
        }
        frmClientes frmclien;
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmclien == null)
            {
                frmclien = new frmClientes();
                frmclien.MdiParent = this;
                frmclien.Icon = ICono;
                frmclien.FormClosed += new FormClosedEventHandler(cerrafrmcliente);
                frmclien.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmclien.Activate();
                ValidarVentanas(frmclien);
            }
        }
        private void cerrafrmcliente(object sender, FormClosedEventArgs e)
        {
            frmclien = null;
        }
        frmCotizacionCliente frmcotizacioncliente;
        private void cotizacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmcotizacioncliente == null)
            {
                frmcotizacioncliente = new frmCotizacionCliente();
                frmcotizacioncliente.MdiParent = this;
                frmcotizacioncliente.Icon = ICono;
                frmcotizacioncliente.FormClosed += new FormClosedEventHandler(cerrarCotizacionCLiente);
                frmcotizacioncliente.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmcotizacioncliente.Activate();
                ValidarVentanas(frmcotizacioncliente);
            }
        }
        private void cerrarCotizacionCLiente(object sender, FormClosedEventArgs e)
        {
            frmcotizacioncliente = null;
        }
        frmUnidadMedida frmunit;
        private void unidadDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmunit == null)
            {
                frmunit = new frmUnidadMedida();
                frmunit.MdiParent = this;
                frmunit.Icon = ICono;
                frmunit.FormClosed += new FormClosedEventHandler(cerrarunidadmedida);
                frmunit.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmunit.Activate();
                ValidarVentanas(frmunit);
            }
        }
        private void cerrarunidadmedida(object sender, FormClosedEventArgs e)
        {
            frmunit = null;
        }
        frmCargosVentas frmcarventa;
        private void cargosVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmcarventa == null)
            {
                frmcarventa = new frmCargosVentas();
                frmcarventa.MdiParent = this;
                frmcarventa.Icon = ICono;
                frmcarventa.FormClosed += new FormClosedEventHandler(cerrarcargoventas);
                frmcarventa.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmcarventa.Activate();
                ValidarVentanas(frmcarventa);
            }
        }
        private void cerrarcargoventas(object sender, FormClosedEventArgs e)
        {
            frmcarventa = null;
        }
        frmNroOpBancacia frmrnoopera;
        private void operacionesBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmrnoopera == null)
            {
                frmrnoopera = new frmNroOpBancacia();
                frmrnoopera.MdiParent = this;
                frmrnoopera.Icon = ICono;
                frmrnoopera.FormClosed += new FormClosedEventHandler(cerrarnropera);
                frmrnoopera.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmrnoopera.Activate();
                ValidarVentanas(frmrnoopera);
            }
        }
        private void cerrarnropera(object sender, FormClosedEventArgs e)
        {
            frmrnoopera = null;
        }
        frmVendedores frmven;
        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmven == null)
            {
                frmven = new frmVendedores();
                frmven.MdiParent = this;
                frmven.Icon = ICono;
                frmven.FormClosed += new FormClosedEventHandler(cerrarvendedor);
                frmven.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmven.Activate();
                ValidarVentanas(frmven);
            }
        }
        private void cerrarvendedor(object sender, FormClosedEventArgs e)
        {
            frmven = null;
        }
        frmCronogramaPagos frmcronopa;
        private void cronogramaDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmcronopa == null)
            {
                frmcronopa = new frmCronogramaPagos();
                frmcronopa.MdiParent = this;
                frmcronopa.Icon = ICono;
                frmcronopa.FormClosed += new FormClosedEventHandler(cerrarcronopago);
                frmcronopa.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmcronopa.Activate();
                ValidarVentanas(frmcronopa);
            }
        }
        private void cerrarcronopago(object sender, FormClosedEventArgs e)
        {
            frmcronopa = null;
        }
        frmSeparacionVta frmseparacion;
        private void separaciónVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmseparacion == null)
            {
                frmseparacion = new frmSeparacionVta();
                frmseparacion.MdiParent = this;
                frmseparacion.Icon = ICono;
                frmseparacion.FormClosed += new FormClosedEventHandler(cerrarseparacionvta);
                frmseparacion.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmseparacion.Activate();
                ValidarVentanas(frmseparacion);
            }
        }
        private void cerrarseparacionvta(object sender, FormClosedEventArgs e)
        {
            frmseparacion = null;
        }
        frmAbonoClientes frmabonocliente;
        private void abonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmabonocliente == null)
            {
                frmabonocliente = new frmAbonoClientes();
                frmabonocliente.MdiParent = this;
                frmabonocliente.Icon = ICono;
                frmabonocliente.FormClosed += new FormClosedEventHandler(cerrarabonocliente);
                frmabonocliente.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmabonocliente.Activate();
                ValidarVentanas(frmabonocliente);
            }
        }
        private void cerrarabonocliente(object sender, FormClosedEventArgs e)
        {
            frmabonocliente = null;
        }
        ModuloBancario.frmCuentasBancarias frmcuentasbancarias;
        private void tipoDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmcuentasbancarias == null)
            {
                frmcuentasbancarias = new ModuloBancario.frmCuentasBancarias();
                frmcuentasbancarias.MdiParent = this;
                frmcuentasbancarias.Icon = ICono;
                frmcuentasbancarias.FormClosed += new FormClosedEventHandler(cerrarcuentasbancarias);
                frmcuentasbancarias.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmcuentasbancarias.Activate();
                ValidarVentanas(frmcuentasbancarias);
            }
        }
        private void cerrarcuentasbancarias(object sender, FormClosedEventArgs e)
        {
            frmcuentasbancarias = null;
        }
        ModuloBancario.frmTiposdeCuentasBancarias frmallcuentasbancarias;
        private void cuentasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmallcuentasbancarias == null)
            {
                frmallcuentasbancarias = new ModuloBancario.frmTiposdeCuentasBancarias();
                frmallcuentasbancarias.MdiParent = this;
                frmallcuentasbancarias.Icon = ICono;
                frmallcuentasbancarias.FormClosed += new FormClosedEventHandler(cerrartiposcuentasbancarias);
                frmallcuentasbancarias.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmallcuentasbancarias.Activate();
                ValidarVentanas(frmallcuentasbancarias);
            }
        }
        private void cerrartiposcuentasbancarias(object sender, FormClosedEventArgs e)
        {
            frmallcuentasbancarias = null;
        }

        private void pbfotoempleado_Click(object sender, EventArgs e)
        {
            //menuStrip2.SuspendLayout();
            //menuStrip2.Visible = false;
            //menuStrip2.Visible = true;
            //menuStrip2.ResumeLayout();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        FrmFacturaManual frmfactumanual;
        private void facturaManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmfactumanual == null)
            {
                frmfactumanual = new FrmFacturaManual();
                frmfactumanual.MdiParent = this;
                frmfactumanual.Icon = ICono;
                frmfactumanual.FormClosed += new FormClosedEventHandler(cerrarfacturamanual);
                frmfactumanual.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmfactumanual.Activate();
                ValidarVentanas(frmfactumanual);
            }
        }
        private void cerrarfacturamanual(object sender, FormClosedEventArgs e)
        {
            frmfactumanual = null;
        }
        frmFacturaManualVentas frmfacventamanual;
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (frmfacventamanual == null)
            {
                frmfacventamanual = new frmFacturaManualVentas();
                frmfacventamanual.MdiParent = this;
                frmfacventamanual.Icon = ICono;
                frmfacventamanual.FormClosed += new FormClosedEventHandler(cerrarfacventamanual);
                frmfacventamanual.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmfacventamanual.Activate();
                ValidarVentanas(frmfacventamanual);
            }
        }

        private void cerrarfacventamanual(object sender, FormClosedEventArgs e)
        {
            frmfacventamanual = null;
        }
        frmPagoDetraccionesVentas frmdetventa;
        private void detraccionesVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmdetventa == null)
            {
                frmdetventa = new frmPagoDetraccionesVentas();
                frmdetventa.MdiParent = this;
                frmdetventa.Icon = ICono;
                frmdetventa.FormClosed += new FormClosedEventHandler(cerrardetracventa);
                frmdetventa.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmdetventa.Activate();
                ValidarVentanas(frmdetventa);
            }
        }

        private void cerrardetracventa(object sender, FormClosedEventArgs e)
        {
            frmdetventa = null;
        }
        frmAbonosVentas frmabonoventa;
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (frmabonoventa == null)
            {
                frmabonoventa = new frmAbonosVentas();
                frmabonoventa.MdiParent = this;
                frmabonoventa.Icon = ICono;
                frmabonoventa.FormClosed += new FormClosedEventHandler(cerrarabonoventa);
                frmabonoventa.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmabonoventa.Activate();
                ValidarVentanas(frmabonoventa);
            }
        }

        private void cerrarabonoventa(object sender, FormClosedEventArgs e)
        {
            frmabonoventa = null;
        }
        frmRegistroCompras frmregistrocompra;
        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmregistrocompra == null)
            {
                frmregistrocompra = new frmRegistroCompras();
                frmregistrocompra.MdiParent = this;
                frmregistrocompra.Icon = ICono;
                frmregistrocompra.FormClosed += new FormClosedEventHandler(cerrrregistrodecompras);
                frmregistrocompra.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmregistrocompra.Activate();
                ValidarVentanas(frmregistrocompra);
            }
        }
        private void cerrrregistrodecompras(object sender, FormClosedEventArgs e)
        {
            frmregistrocompra = null;
        }
        frmRegistroVentas frmregistroventas;
        private void formato141RegistroDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmregistroventas == null)
            {
                frmregistroventas = new frmRegistroVentas();
                frmregistroventas.MdiParent = this;
                frmregistroventas.Icon = ICono;
                frmregistroventas.FormClosed += new FormClosedEventHandler(cerrrregistrodeventas);
                frmregistroventas.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmregistroventas.Activate();
                ValidarVentanas(frmregistroventas);
            }
        }

        private void cerrrregistrodeventas(object sender, FormClosedEventArgs e)
        {
            frmregistroventas = null;
        }
        frmRegMayorPorEmpresas frmremayorempresas;
        private void mayorPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmremayorempresas == null)
            {
                frmremayorempresas = new frmRegMayorPorEmpresas();
                frmremayorempresas.MdiParent = this;
                frmremayorempresas.Icon = ICono;
                frmremayorempresas.FormClosed += new FormClosedEventHandler(cerrrremayorventas);
                frmremayorempresas.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmremayorempresas.Activate();
                ValidarVentanas(frmremayorempresas);
            }
        }
        private void cerrrremayorventas(object sender, FormClosedEventArgs e)
        {
            frmremayorempresas = null;
        }
        frmRegMayorxCuentas frmregxcuentas;
        private void mayorPorCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmregxcuentas == null)
            {
                frmregxcuentas = new frmRegMayorxCuentas();
                frmregxcuentas.MdiParent = this;
                frmregxcuentas.Icon = ICono;
                frmregxcuentas.FormClosed += new FormClosedEventHandler(cerrrremayorporcuentas);
                frmregxcuentas.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmregxcuentas.Activate();
                ValidarVentanas(frmregxcuentas);
            }
        }
        private void cerrrremayorporcuentas(object sender, FormClosedEventArgs e)
        {
            frmregxcuentas = null;
        }

        frmReportedeFacturas frmreporfactu;
        private void reporteFacturasIncompletasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmreporfactu == null)
            {
                frmreporfactu = new frmReportedeFacturas();
                frmreporfactu.MdiParent = this;
                frmreporfactu.Icon = ICono;
                frmreporfactu.FormClosed += new FormClosedEventHandler(cerrarfacturasincompletas);
                frmreporfactu.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmreporfactu.Activate();
                ValidarVentanas(frmreporfactu);
            }
        }

        private void cerrarfacturasincompletas(object sender, FormClosedEventArgs e)
        {
            frmreporfactu = null;
        }
        string bienvenido = "";
        private void lblwelcome_DoubleClick(object sender, EventArgs e)
        {
            if (lblwelcome.Height == 12)
            {
                lblpuntero.Visible = false;
                lblwelcome.Height = 40;
                pbfotoempleado.Visible = true;
                lblwelcome.Text = bienvenido;
            }
            else
            {
                lblwelcome.Height = 12;
                lblpuntero.Visible = true;
                pbfotoempleado.Visible = false;
                lblwelcome.Text = "";
            }
        }

        private void fondoFijoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void reembolsoGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void compensacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        ModuloCompensaciones.frmAnticipoProveedores frmanticipo;
        private void anticipoProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerraranticipoproveedores(object sender, FormClosedEventArgs e)
        {
            frmanticipo = null;
        }
        ModuloCompensaciones.frmListarCompensaciones listcompensa;
        private void Listcompensa_FormClosed(object sender, FormClosedEventArgs e)
        {
            listcompensa = null;
        }
        private void listadoCompensacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listcompensa == null)
            {
                listcompensa = new ModuloCompensaciones.frmListarCompensaciones();
                listcompensa.MdiParent = this;
                listcompensa.FormClosed += Listcompensa_FormClosed;
                listcompensa.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                listcompensa.Activate();
                ValidarVentanas(listcompensa);
            }
        }
        ModuloCompensaciones.frmFondoFijo frmfondoFijoCrear;
        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmfondoFijoCrear == null)
            {
                frmfondoFijoCrear = new ModuloCompensaciones.frmFondoFijo();
                frmfondoFijoCrear.MdiParent = this;
                frmfondoFijoCrear.FormClosed += FrmfondoFijoCrear_FormClosed;
                frmfondoFijoCrear.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmfondoFijoCrear.Activate();
                ValidarVentanas(frmfondoFijoCrear);
            }
        }
        private void FrmfondoFijoCrear_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmfondoFijoCrear = null;
        }
        ModuloCompensaciones.frmFondoFijoPago frmfondofijoCompensar;
        private void compensarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmfondofijoCompensar == null)
            {
                frmfondofijoCompensar = new ModuloCompensaciones.frmFondoFijoPago();
                frmfondofijoCompensar.MdiParent = this;
                frmfondofijoCompensar.FormClosed += FrmfondofijoCompensar_FormClosed;
                frmfondofijoCompensar.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmfondofijoCompensar.Activate();
                ValidarVentanas(frmfondofijoCompensar);
            }
        }
        private void FrmfondofijoCompensar_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmfondofijoCompensar = null;
        }
        ModuloCompensaciones.frmEntregaRendir frmEntregasRendirCrear;
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (frmEntregasRendirCrear == null)
            {
                frmEntregasRendirCrear = new ModuloCompensaciones.frmEntregaRendir();
                frmEntregasRendirCrear.MdiParent = this;
                frmEntregasRendirCrear.FormClosed += FrmEntregasRendirCrear_FormClosed;
                frmEntregasRendirCrear.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmEntregasRendirCrear.Activate();
                ValidarVentanas(frmEntregasRendirCrear);
            }
        }
        private void FrmEntregasRendirCrear_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmEntregasRendirCrear = null;
        }
        ModuloCompensaciones.frmEntregaRendirPago frmEntregasRendirPago;
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (frmEntregasRendirPago == null)
            {
                frmEntregasRendirPago = new ModuloCompensaciones.frmEntregaRendirPago();
                frmEntregasRendirPago.MdiParent = this;
                frmEntregasRendirPago.FormClosed += FrmEntregasRendirPago_FormClosed; ;
                frmEntregasRendirPago.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmEntregasRendirPago.Activate();
                ValidarVentanas(frmEntregasRendirPago);
            }
        }
        private void FrmEntregasRendirPago_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmEntregasRendirPago = null;
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmanticipo == null)
            {
                frmanticipo = new ModuloCompensaciones.frmAnticipoProveedores();
                frmanticipo.MdiParent = this;
                frmanticipo.Icon = ICono;
                frmanticipo.FormClosed += new FormClosedEventHandler(cerraranticipoproveedores);
                frmanticipo.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmanticipo.Activate();
                ValidarVentanas(frmanticipo);
            }
        }
        private void FrmliscompensaAnticipo_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmliscompensaAnticipo = null;
        }
        ModuloCompensaciones.frmListarCompensacionesAnticipo frmliscompensaAnticipo;
        private void aplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmliscompensaAnticipo == null)
            {
                frmliscompensaAnticipo = new ModuloCompensaciones.frmListarCompensacionesAnticipo();
                frmliscompensaAnticipo.FormClosed += FrmliscompensaAnticipo_FormClosed;
                frmliscompensaAnticipo.MdiParent = this;
                frmliscompensaAnticipo.Show();
            }
            else
            {
                frmliscompensaAnticipo.Activate();
            }
        }
        frmPrestamoInterEmpresas frmprestamointer;
        private void prestamoInterEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmprestamointer == null)
            {
                frmprestamointer = new frmPrestamoInterEmpresas();
                frmprestamointer.FormClosed += Frmprestamointer_FormClosed;
                frmprestamointer.MdiParent = this;
                frmprestamointer.Show();
            }
            else
            {
                frmprestamointer.Activate();
            }
        }
        private void Frmprestamointer_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmprestamointer = null;
        }
        private void arToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //RecargarMenu();
        }
        private void proyectosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //RecargarMenu();
        }
        private void ventasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //RecargarMenu();
        }
        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //RecargarMenu();
        }
        private void contabilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //RecargarMenu();
        }
        private void planillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //RecargarMenu();
        }
        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //RecargarMenu();
        }
        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //RecargarMenu();
        }
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecargarMenu();
        }
        frmReporteAnalitico frmReporteAnalitico;
        private void reporteAnalíticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmReporteAnalitico == null)
            {
                frmReporteAnalitico = new frmReporteAnalitico();
                frmReporteAnalitico.MdiParent = this;
                frmReporteAnalitico.Icon = ICono;
                frmReporteAnalitico.FormClosed += FrmReporteAnalitico_FormClosed;
                frmReporteAnalitico.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmReporteAnalitico.Activate();
                ValidarVentanas(frmReporteAnalitico);
            }
        }
        private void FrmReporteAnalitico_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmReporteAnalitico = null;
        }
        ModuloContable.frmListadoAsientosContables frmreporteasiento;
        private void vouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmreporteasiento == null)
            {
                frmreporteasiento = new ModuloContable.frmListadoAsientosContables();
                frmreporteasiento.MdiParent = this;
                frmreporteasiento.Icon = ICono;
                frmreporteasiento.FormClosed += Frmreporteasiento_FormClosed;
                frmreporteasiento.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmreporteasiento.Activate();
                ValidarVentanas(frmreporteasiento);
            }
        }
        private void Frmreporteasiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmreporteasiento = null;
        }
        frmReporteAnalitico2 frmReporteAnalitico2;
        private void reporteAnalíticoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (frmreporteasiento == null)
            {
                frmReporteAnalitico2 = new frmReporteAnalitico2();
                frmReporteAnalitico2.MdiParent = this;
                frmReporteAnalitico2.Icon = ICono;
                frmReporteAnalitico2.FormClosed += FrmReporteAnalitico2_FormClosed;
                frmReporteAnalitico2.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmReporteAnalitico.Activate();
                ValidarVentanas(frmReporteAnalitico2);
            }
        }
        private void FrmReporteAnalitico2_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmReporteAnalitico2 = null;
        }
        ModuloReportes.frmReporteSaldosContables FrmReporteSaldos;
        private void reporteSaldosContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmReporteSaldos == null)
            {
                FrmReporteSaldos = new ModuloReportes.frmReporteSaldosContables();
                FrmReporteSaldos.MdiParent = this;
                FrmReporteSaldos.Icon = ICono;
                FrmReporteSaldos.FormClosed += FrmReporteSaldos_FormClosed;
                FrmReporteSaldos.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                FrmReporteSaldos.Activate();
                ValidarVentanas(FrmReporteSaldos);
            }
        }
        private void FrmReporteSaldos_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmReporteSaldos = null;
        }
        ModuloFinanzas.frmCobroPrestamosInterEmpresa frmcobrointerempresas;
        private void cobroInterEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmcobrointerempresas == null)
            {
                frmcobrointerempresas = new ModuloFinanzas.frmCobroPrestamosInterEmpresa();
                frmcobrointerempresas.MdiParent = this;
                frmcobrointerempresas.Icon = ICono;
                frmcobrointerempresas.FormClosed += Frmcobrointerempresas_FormClosed;
                frmcobrointerempresas.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmcobrointerempresas.Activate();
                ValidarVentanas(frmcobrointerempresas);
            }
        }
        private void Frmcobrointerempresas_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmcobrointerempresas = null;
        }
        ModuloCompensaciones.frmReembolsoGastos frmreembolso;
        private void aplicaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmreembolso == null)
            {
                frmreembolso = new ModuloCompensaciones.frmReembolsoGastos();
                frmreembolso.MdiParent = this;
                frmreembolso.Icon = ICono;
                frmreembolso.FormClosed += new FormClosedEventHandler(cerrarreembolsobancario);
                frmreembolso.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmreembolso.Activate();
                ValidarVentanas(frmreembolso);
            }
        }
        private void cerrarreembolsobancario(object sender, FormClosedEventArgs e)
        {
            frmreembolso = null;
        }
        ModuloCompensaciones.frmReembolsoGastosPago frmpagoreembolso;
        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmpagoreembolso == null)
            {
                frmpagoreembolso = new ModuloCompensaciones.frmReembolsoGastosPago();
                frmpagoreembolso.MdiParent = this;
                frmpagoreembolso.Icon = ICono;
                frmpagoreembolso.FormClosed += new FormClosedEventHandler(cerrarpagoreembolso);
                frmpagoreembolso.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmpagoreembolso.Activate();
                ValidarVentanas(frmpagoreembolso);
            }
        }

        private void cerrarpagoreembolso(object sender, FormClosedEventArgs e)
        {
            frmpagoreembolso = null;
        }
        frmTipodeCambioSBS frmtipocambiosbs;
        private void tipoDeCambioCierreSBSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmtipocambiosbs == null)
            {
                frmtipocambiosbs = new frmTipodeCambioSBS();
                frmtipocambiosbs.MdiParent = this;
                frmtipocambiosbs.Icon = ICono;
                frmtipocambiosbs.FormClosed += new FormClosedEventHandler(cerrartipocambiosbs);
                frmtipocambiosbs.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmtipocambiosbs.Activate();
                ValidarVentanas(frmtipocambiosbs);
            }
        }

        private void cerrartipocambiosbs(object sender, FormClosedEventArgs e)
        {
            frmtipocambiosbs = null;
        }
        frmDiferenciaCambioMensual frmcierremensual;
        private void diferenciaDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmcierremensual == null)
            {
                frmcierremensual = new frmDiferenciaCambioMensual();
                frmcierremensual.MdiParent = this;
                frmcierremensual.Icon = ICono;
                frmcierremensual.FormClosed += new FormClosedEventHandler(Diferenciacerrarcierremensusal);
                frmcierremensual.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmcierremensual.Activate();
                ValidarVentanas(frmcierremensual);
            }
        }
        private void Diferenciacerrarcierremensusal(object sender, FormClosedEventArgs e)
        {
            frmcierremensual = null;
        }
        ModuloReportes.frmBalanceComprobacion frmComprobacion;
        private void balanceDeComprobaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmComprobacion == null)
            {
                frmComprobacion = new ModuloReportes.frmBalanceComprobacion();
                frmComprobacion.MdiParent = this;
                frmComprobacion.Icon = ICono;
                frmComprobacion.FormClosed += new FormClosedEventHandler(cerrarbalancecomprobacion);
                frmComprobacion.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmComprobacion.Activate();
                ValidarVentanas(frmComprobacion);
            }
        }

        private void cerrarbalancecomprobacion(object sender, FormClosedEventArgs e)
        {
            frmComprobacion = null;
        }
        ModuloReportes.LibrosElectronicos.frmLibroBancosEfectivo frmbancosEfectivo;
        private void lIBROCAJAYBANCOSDETALLEDELOSMOVIMIENTOSDELEFECTIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmbancosEfectivo == null)
            {
                frmbancosEfectivo = new ModuloReportes.LibrosElectronicos.frmLibroBancosEfectivo();
                frmbancosEfectivo.MdiParent = this;
                frmbancosEfectivo.Icon = ICono;
                frmbancosEfectivo.FormClosed += new FormClosedEventHandler(cerrarfrmbancosEfectivo);
                frmbancosEfectivo.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmbancosEfectivo.Activate();
                ValidarVentanas(frmbancosEfectivo);
            }
        }
        private void cerrarfrmbancosEfectivo(object sender, FormClosedEventArgs e)
        {
            frmbancosEfectivo = null;
        }
        ModuloReportes.LibrosElectronicos.frmLibroBancosCorriente frmBancosCorriente;
        private void libroCajaYBancosDetalleDeLosMovimientosDeLaCuentaCorrienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmBancosCorriente == null)
            {
                frmBancosCorriente = new ModuloReportes.LibrosElectronicos.frmLibroBancosCorriente();
                frmBancosCorriente.MdiParent = this;
                frmBancosCorriente.Icon = ICono;
                frmBancosCorriente.FormClosed += new FormClosedEventHandler(cerrarfrmBancosCorriente);
                frmBancosCorriente.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmBancosCorriente.Activate();
                ValidarVentanas(frmBancosCorriente);
            }
        }
        private void cerrarfrmBancosCorriente(object sender, FormClosedEventArgs e)
        {
            frmBancosCorriente = null;
        }
        ModuloFinanzas.frmMediosPagos frmMedioPagos;
        private void mediosPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmMedioPagos == null)
            {
                frmMedioPagos = new ModuloFinanzas.frmMediosPagos();
                frmMedioPagos.MdiParent = this;
                frmMedioPagos.Icon = ICono;
                frmMedioPagos.FormClosed += new FormClosedEventHandler(cerrarfrmMedioPagos);
                frmMedioPagos.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmMedioPagos.Activate();
                ValidarVentanas(frmMedioPagos);
            }
        }
        private void cerrarfrmMedioPagos(object sender, FormClosedEventArgs e)
        {
            frmMedioPagos = null;
        }
        ModuloReportes.LibrosElectronicos.frmLibroDiario frmLibrosdiarios;
        private void libroDiarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmLibrosdiarios == null)
            {
                frmLibrosdiarios = new ModuloReportes.LibrosElectronicos.frmLibroDiario();
                frmLibrosdiarios.MdiParent = this;
                frmLibrosdiarios.Icon = ICono;
                frmLibrosdiarios.FormClosed += new FormClosedEventHandler(cerrarlibrodiario);
                frmLibrosdiarios.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmLibrosdiarios.Activate();
                ValidarVentanas(frmLibrosdiarios);
            }
        }
        private void cerrarlibrodiario(object sender, FormClosedEventArgs e)
        {
            frmLibrosdiarios = null;
        }
        ModuloContable.frmTipoPlanCuenta frmtipoplancuenta;
        private void tiposPlanContableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmtipoplancuenta == null)
            {
                frmtipoplancuenta = new ModuloContable.frmTipoPlanCuenta();
                frmtipoplancuenta.MdiParent = this;
                frmtipoplancuenta.Icon = ICono;
                frmtipoplancuenta.FormClosed += new FormClosedEventHandler(cerrartipoplancontable);
                frmtipoplancuenta.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmtipoplancuenta.Activate();
                ValidarVentanas(frmtipoplancuenta);
            }
        }

        private void cerrartipoplancontable(object sender, FormClosedEventArgs e)
        {
            frmtipoplancuenta = null;
        }
        ModuloReportes.LibrosElectronicos.frmLibroDiario5_3 frmreportelibro5_3;
        private void libroDiarioDetalleDelPlanContableUtilizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmreportelibro5_3 == null)
            {
                frmreportelibro5_3 = new ModuloReportes.LibrosElectronicos.frmLibroDiario5_3();
                frmreportelibro5_3.MdiParent = this;
                frmreportelibro5_3.Icon = ICono;
                frmreportelibro5_3.FormClosed += new FormClosedEventHandler(cerrarformato5_3);
                frmreportelibro5_3.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmreportelibro5_3.Activate();
                ValidarVentanas(frmreportelibro5_3);
            }
        }
        private void cerrarformato5_3(object sender, FormClosedEventArgs e)
        {
            frmreportelibro5_3 = null;
        }
        ModuloReportes.LibrosElectronicos.frmLibroInventario3_2 frmLibroInventario5_3;
        private void libroDeInventariosYBalancesDetalleDelSaldoDeLaCuenta10EfectivoYEquivalentesDeEfectivoPCGEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarformato3_2(object sender, FormClosedEventArgs e)
        {
            frmLibroInventario5_3 = null;
        }
        ModuloCompensaciones.frmEntregaRendirDinero frmentregarendirdinero;
        private void devoluciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmentregarendirdinero == null)
            {
                frmentregarendirdinero = new ModuloCompensaciones.frmEntregaRendirDinero();
                frmentregarendirdinero.MdiParent = this;
                frmentregarendirdinero.Icon = ICono;
                frmentregarendirdinero.FormClosed += new FormClosedEventHandler(cerrarentregadinero);
                frmentregarendirdinero.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmentregarendirdinero.Activate();
                ValidarVentanas(frmentregarendirdinero);
            }
        }

        private void cerrarentregadinero(object sender, FormClosedEventArgs e)
        {
            frmentregarendirdinero = null;
        }
        ModuloReportes.LibrosElectronicos.frmLibroInventarios3_3 frmLibroInventario3_3;
        private void cerrarformulario3_3(object sender, FormClosedEventArgs e)
        {
            frmLibroInventario3_3 = null;
        }
        ModuloReportes.LibrosElectronicos.frmLibroInventario3_2 LibroInventario3_2;
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (LibroInventario3_2 == null)
            {
                LibroInventario3_2 = new ModuloReportes.LibrosElectronicos.frmLibroInventario3_2();
                LibroInventario3_2.MdiParent = this;
                LibroInventario3_2.Icon = ICono;
                LibroInventario3_2.FormClosed += new FormClosedEventHandler(cerrarInventario3_2);
                LibroInventario3_2.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                LibroInventario3_2.Activate();
                ValidarVentanas(LibroInventario3_2);
            }
        }
        private void cerrarInventario3_2(object sender, FormClosedEventArgs e)
        {
            LibroInventario3_2 = null;
        }
        ModuloReportes.LibrosElectronicos.frmLibroInventarios3_3 LibroInventario3_3;
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            if (LibroInventario3_3 == null)
            {
                LibroInventario3_3 = new ModuloReportes.LibrosElectronicos.frmLibroInventarios3_3();
                LibroInventario3_3.MdiParent = this;
                LibroInventario3_3.Icon = ICono;
                LibroInventario3_3.FormClosed += new FormClosedEventHandler(cerrarInventario3_3);
                LibroInventario3_3.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                LibroInventario3_3.Activate();
                ValidarVentanas(LibroInventario3_3);
            }
        }

        private void cerrarInventario3_3(object sender, FormClosedEventArgs e)
        {
            LibroInventario3_3 = null;
        }
        ModuloReportes.LibrosElectronicos.frmLibroInventarios3_4 LibroInventario3_4;
        private void libroDeInventariosYBalancesDetalleDelSaldoDeLaCuenta10EfectivoYEquivalentesDeEfectivoPCGEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (LibroInventario3_4 == null)
            {
                LibroInventario3_4 = new ModuloReportes.LibrosElectronicos.frmLibroInventarios3_4();
                LibroInventario3_4.MdiParent = this;
                LibroInventario3_4.Icon = ICono;
                LibroInventario3_4.FormClosed += new FormClosedEventHandler(cerrarInventario3_4);
                LibroInventario3_4.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                LibroInventario3_4.Activate();
                ValidarVentanas(LibroInventario3_4);
            }
        }
        private void cerrarInventario3_4(object sender, FormClosedEventArgs e)
        {
            LibroInventario3_4 = null;
        }
        ModuloReportes.LibrosElectronicos.frmLibroInventarios3_5 LibroInventarios3_5;
        private void LibroInventario3_5_Click(object sender, EventArgs e)
        {
            if (LibroInventarios3_5 == null)
            {
                LibroInventarios3_5 = new ModuloReportes.LibrosElectronicos.frmLibroInventarios3_5();
                LibroInventarios3_5.MdiParent = this;
                LibroInventarios3_5.Icon = ICono;
                LibroInventarios3_5.FormClosed += new FormClosedEventHandler(CerrarLibroInventarios3_5);
                LibroInventarios3_5.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                LibroInventarios3_5.Activate();
                ValidarVentanas(LibroInventarios3_5);
            }
        }

        private void CerrarLibroInventarios3_5(object sender, FormClosedEventArgs e)
        {
            LibroInventarios3_5 = null;
        }
        ModuloReportes.LibrosElectronicos.frmLibroInventarios3_6 LibroInventarios3_6;
        private void tpLibroInventario3_6_Click(object sender, EventArgs e)
        {
            if (LibroInventarios3_6 == null)
            {
                LibroInventarios3_6 = new ModuloReportes.LibrosElectronicos.frmLibroInventarios3_6();
                LibroInventarios3_6.MdiParent = this;
                LibroInventarios3_6.Icon = ICono;
                LibroInventarios3_6.FormClosed += new FormClosedEventHandler(CerrarLibroInventarios3_6);
                LibroInventarios3_6.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                LibroInventarios3_6.Activate();
                ValidarVentanas(LibroInventarios3_6);
            }
        }

        private void CerrarLibroInventarios3_6(object sender, FormClosedEventArgs e)
        {
            LibroInventarios3_6 = null;
        }
        ModuloReportes.LibrosElectronicos.frmLibroInventarios3_11 LibroInventarios3_11;
        private void tpLibroInventario311_Click(object sender, EventArgs e)
        {
            if (LibroInventarios3_11 == null)
            {
                LibroInventarios3_11 = new ModuloReportes.LibrosElectronicos.frmLibroInventarios3_11();
                LibroInventarios3_11.MdiParent = this;
                LibroInventarios3_11.Icon = ICono;
                LibroInventarios3_11.FormClosed += new FormClosedEventHandler(CerrarLibroInventarios3_11);
                LibroInventarios3_11.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                LibroInventarios3_11.Activate();
                ValidarVentanas(LibroInventarios3_11);
            }
        }
        private void CerrarLibroInventarios3_11(object sender, FormClosedEventArgs e)
        {
            LibroInventarios3_11 = null;
        }
        ModuloReportes.LibrosElectronicos.frmLibroInventarios3_12 LibroInventarios3_12;
        private void tpLibroInventario3_12_Click(object sender, EventArgs e)
        {
            if (LibroInventarios3_12 == null)
            {
                LibroInventarios3_12 = new ModuloReportes.LibrosElectronicos.frmLibroInventarios3_12();
                LibroInventarios3_12.MdiParent = this;
                LibroInventarios3_12.Icon = ICono;
                LibroInventarios3_12.FormClosed += new FormClosedEventHandler(CerrarLibroInventarios3_12);
                LibroInventarios3_12.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                LibroInventarios3_12.Activate();
                ValidarVentanas(LibroInventarios3_12);
            }
        }

        private void CerrarLibroInventarios3_12(object sender, FormClosedEventArgs e)
        {
            LibroInventarios3_12 = null;
        }
        ModuloReportes.LibrosElectronicos.frmLibroInventarios3_13 LibroInventarios3_13;

        private void tpLibroInventario3_13_Click(object sender, EventArgs e)
        {
            if (LibroInventarios3_13 == null)
            {
                LibroInventarios3_13 = new ModuloReportes.LibrosElectronicos.frmLibroInventarios3_13();
                LibroInventarios3_13.MdiParent = this;
                LibroInventarios3_13.Icon = ICono;
                LibroInventarios3_13.FormClosed += new FormClosedEventHandler(CerrarLibroInventarios3_13);
                LibroInventarios3_13.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                LibroInventarios3_13.Activate();
                ValidarVentanas(LibroInventarios3_13);
            }
        }

        private void CerrarLibroInventarios3_13(object sender, FormClosedEventArgs e)
        {
            LibroInventarios3_13 = null;
        }
        ModuloReportes.frmFlujodeGastosDoc frmFlujodeCajaGastos;
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            if (frmFlujodeCajaGastos == null)
            {
                frmFlujodeCajaGastos = new ModuloReportes.frmFlujodeGastosDoc();
                frmFlujodeCajaGastos.MdiParent = this;
                frmFlujodeCajaGastos.Icon = ICono;
                frmFlujodeCajaGastos.FormClosed += new FormClosedEventHandler(CerrarfrmFlujodeCajaGastos);
                frmFlujodeCajaGastos.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmFlujodeCajaGastos.Activate();
                ValidarVentanas(frmFlujodeCajaGastos);
            }
        }

        private void CerrarfrmFlujodeCajaGastos(object sender, FormClosedEventArgs e)
        {
            frmFlujodeCajaGastos = null;
        }
        ModuloReportes.frmFlujodeGastosRegistro frmFlujodeCajaRegistro;
        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            if (frmFlujodeCajaRegistro == null)
            {
                frmFlujodeCajaRegistro = new ModuloReportes.frmFlujodeGastosRegistro();
                frmFlujodeCajaRegistro.MdiParent = this;
                frmFlujodeCajaRegistro.Icon = ICono;
                frmFlujodeCajaRegistro.FormClosed += new FormClosedEventHandler(CerrarfrmFlujodeCajaRegistro);
                frmFlujodeCajaRegistro.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmFlujodeCajaRegistro.Activate();
                ValidarVentanas(frmFlujodeCajaRegistro);
            }
        }

        private void CerrarfrmFlujodeCajaRegistro(object sender, FormClosedEventArgs e)
        {
            frmFlujodeCajaRegistro = null;
        }
        ModuloReportes.LibrosElectronicos.frmLibroDiario5_2 frmLibroDiario5_2;
        private void libroDiarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (frmLibroDiario5_2 == null)
            {
                frmLibroDiario5_2 = new ModuloReportes.LibrosElectronicos.frmLibroDiario5_2();
                frmLibroDiario5_2.MdiParent = this;
                frmLibroDiario5_2.Icon = ICono;
                frmLibroDiario5_2.FormClosed += new FormClosedEventHandler(CerrarfrmLibroDiario5_2);
                frmLibroDiario5_2.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmLibroDiario5_2.Activate();
                ValidarVentanas(frmLibroDiario5_2);
            }
        }
        private void CerrarfrmLibroDiario5_2(object sender, FormClosedEventArgs e)
        {
            frmLibroDiario5_2 = null;
        }
        ModuloReportes.LibrosElectronicos.frmLibroDiario5_4 frmLibroDiario5_4;
        private void libroDiarioDeFormatoSimplificadoDetalleDelPlanContableUtilizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmLibroDiario5_4 == null)
            {
                frmLibroDiario5_4 = new ModuloReportes.LibrosElectronicos.frmLibroDiario5_4();
                frmLibroDiario5_4.MdiParent = this;
                frmLibroDiario5_4.Icon = ICono;
                frmLibroDiario5_4.FormClosed += new FormClosedEventHandler(CerrarfrmLibroDiario5_4);
                frmLibroDiario5_4.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmLibroDiario5_4.Activate();
                ValidarVentanas(frmLibroDiario5_4);
            }
        }
        private void CerrarfrmLibroDiario5_4(object sender, FormClosedEventArgs e)
        {
            frmLibroDiario5_4 = null;
        }
        frmRegistroCompras8_3 frmRegistroCompra8_3;
        private void toolStripMenuItem11_Click_1(object sender, EventArgs e)
        {
            if (frmRegistroCompra8_3 == null)
            {
                frmRegistroCompra8_3 = new frmRegistroCompras8_3();
                frmRegistroCompra8_3.MdiParent = this;
                frmRegistroCompra8_3.Icon = ICono;
                frmRegistroCompra8_3.FormClosed += new FormClosedEventHandler(CerrarfrmRegistroCompra8_3);
                frmRegistroCompra8_3.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmRegistroCompra8_3.Activate();
                ValidarVentanas(frmRegistroCompra8_3);
            }
        }
        private void CerrarfrmRegistroCompra8_3(object sender, FormClosedEventArgs e)
        {
            frmRegistroCompra8_3 = null;
        }
        ModuloReportes.frmReporteDocumentosImpagos frmDcoumentosImpagos;
        private void consultaDeDocumentosDeProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDcoumentosImpagos == null)
            {
                frmDcoumentosImpagos = new ModuloReportes.frmReporteDocumentosImpagos();
                frmDcoumentosImpagos.MdiParent = this;
                frmDcoumentosImpagos.Icon = ICono;
                frmDcoumentosImpagos.FormClosed += new FormClosedEventHandler(CerrarfrmDcoumentosImpagos);
                frmDcoumentosImpagos.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmDcoumentosImpagos.Activate();
                ValidarVentanas(frmDcoumentosImpagos);
            }
        }
        private void CerrarfrmDcoumentosImpagos(object sender, FormClosedEventArgs e)
        {
            frmDcoumentosImpagos = null;
        }
        frmRegistroVentas14_2 frmRegistroVentasSimplificado;
        private void formato142REgistroVentasSimplificado_Click(object sender, EventArgs e)
        {
            if (frmRegistroVentasSimplificado == null)
            {
                frmRegistroVentasSimplificado = new frmRegistroVentas14_2();
                frmRegistroVentasSimplificado.MdiParent = this;
                frmRegistroVentasSimplificado.Icon = ICono;
                frmRegistroVentasSimplificado.FormClosed += new FormClosedEventHandler(CerrarfrmRegistroVentasSimplificado);
                frmRegistroVentasSimplificado.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmRegistroVentasSimplificado.Activate();
                ValidarVentanas(frmRegistroVentasSimplificado);
            }
        }

        private void CerrarfrmRegistroVentasSimplificado(object sender, FormClosedEventArgs e)
        {
            frmRegistroVentasSimplificado = null;
        }
        frmAsientosApertura frmASientosAperura;
        private void asientosAperturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmASientosAperura == null)
            {
                frmASientosAperura = new frmAsientosApertura();
                frmASientosAperura.MdiParent = this;
                frmASientosAperura.Icon = ICono;
                frmASientosAperura.FormClosed += new FormClosedEventHandler(CerrarfrmASientosAperura);
                frmASientosAperura.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmASientosAperura.Activate();
                ValidarVentanas(frmASientosAperura);
            }
        }

        private void CerrarfrmASientosAperura(object sender, FormClosedEventArgs e)
        {
            frmASientosAperura = null;
        }
        ModuloFinanzas.FrmConciliarBanco frmConciliacion;
        private void conciliaciónBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CerrarfrmConciliacion(object sender, FormClosedEventArgs e)
        {
            frmConciliacion = null;
        }

        private void conciliarBancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmConciliacion == null)
            {
                frmConciliacion = new ModuloFinanzas.FrmConciliarBanco();
                frmConciliacion.MdiParent = this;
                frmConciliacion.Icon = ICono;
                frmConciliacion.FormClosed += new FormClosedEventHandler(CerrarfrmConciliacion);
                frmConciliacion.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmConciliacion.Activate();
                ValidarVentanas(frmConciliacion);
            }
        }
        ModuloFinanzas.frmReporteConciliaciones frmReporteConciliaones;
        private void reporteConciliacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmReporteConciliaones == null)
            {
                frmReporteConciliaones = new ModuloFinanzas.frmReporteConciliaciones();
                frmReporteConciliaones.MdiParent = this;
                frmReporteConciliaones.Icon = ICono;
                frmReporteConciliaones.FormClosed += new FormClosedEventHandler(CerrarfrmReporteConciliaones);
                frmReporteConciliaones.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmReporteConciliaones.Activate();
                ValidarVentanas(frmReporteConciliaones);
            }
        }
        private void CerrarfrmReporteConciliaones(object sender, FormClosedEventArgs e)
        {
            frmReporteConciliaones = null;
        }
        frmRegMayorxCuentasPerfil frmMayorcuentasPerfil;
        private void libroMayorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmMayorcuentasPerfil == null)
            {
                frmMayorcuentasPerfil = new frmRegMayorxCuentasPerfil();
                frmMayorcuentasPerfil.MdiParent = this;
                frmMayorcuentasPerfil.Icon = ICono;
                frmMayorcuentasPerfil.FormClosed += new FormClosedEventHandler(CerrarfrmMayorcuentasPerfil);
                frmMayorcuentasPerfil.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmMayorcuentasPerfil.Activate();
                ValidarVentanas(frmMayorcuentasPerfil);
            }
        }
        private void CerrarfrmMayorcuentasPerfil(object sender, FormClosedEventArgs e)
        {
            frmMayorcuentasPerfil = null;
        }
        //ModuloRRHH.frmBonosEmpleados frmbonoempleados;
        ModuloRRHH.frmComisionesBonos frmbonoempleados;
        private void bonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmbonoempleados == null)
            {
                frmbonoempleados = new ModuloRRHH.frmComisionesBonos();
                frmbonoempleados.MdiParent = this;
                frmbonoempleados.Icon = ICono;
                frmbonoempleados.FormClosed += new FormClosedEventHandler(Cerrarfrmbonoempleados);
                frmbonoempleados.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmbonoempleados.Activate();
                ValidarVentanas(frmbonoempleados);
            }
        }
        private void Cerrarfrmbonoempleados(object sender, FormClosedEventArgs e)
        {
            frmbonoempleados = null;
        }
        frmRegistroCompras8_2 fmrRegistroCompra82;
        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            if (fmrRegistroCompra82 == null)
            {
                fmrRegistroCompra82 = new frmRegistroCompras8_2();
                fmrRegistroCompra82.MdiParent = this;
                fmrRegistroCompra82.Icon = ICono;
                fmrRegistroCompra82.FormClosed += new FormClosedEventHandler(CerrarfmrRegistroCompra82);
                fmrRegistroCompra82.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                fmrRegistroCompra82.Activate();
                ValidarVentanas(fmrRegistroCompra82);
            }
        }

        private void CerrarfmrRegistroCompra82(object sender, FormClosedEventArgs e)
        {
            fmrRegistroCompra82 = null;
        }
        frmTipoFaltas frmtipofaltitas;
        private void tiposFaltasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmtipofaltitas == null)
            {
                frmtipofaltitas = new frmTipoFaltas();
                frmtipofaltitas.MdiParent = this;
                frmtipofaltitas.Icon = ICono;
                frmtipofaltitas.FormClosed += new FormClosedEventHandler(Cerrarfrmtipofaltitas);
                frmtipofaltitas.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmtipofaltitas.Activate();
                ValidarVentanas(frmtipofaltitas);
            }
        }

        private void Cerrarfrmtipofaltitas(object sender, FormClosedEventArgs e)
        {
            frmtipofaltitas = null;
        }
        frmConfigurarAsientosBoletas frmConfigurarasientoBoletas;
        private void asientosBoletasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmConfigurarasientoBoletas == null)
            {
                frmConfigurarasientoBoletas = new frmConfigurarAsientosBoletas();
                frmConfigurarasientoBoletas.MdiParent = this;
                frmConfigurarasientoBoletas.Icon = ICono;
                frmConfigurarasientoBoletas.FormClosed += new FormClosedEventHandler(CerrarfrmConfigurarasientoBoletas);
                frmConfigurarasientoBoletas.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmConfigurarasientoBoletas.Activate();
                ValidarVentanas(frmConfigurarasientoBoletas);
            }
        }

        private void CerrarfrmConfigurarasientoBoletas(object sender, FormClosedEventArgs e)
        {
            frmConfigurarasientoBoletas = null;
        }
        ModuloRRHH.frmVacacionesResumen frmVacacionesREsumen;
        private void vacacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmVacacionesREsumen == null)
            {
                frmVacacionesREsumen = new ModuloRRHH.frmVacacionesResumen();
                frmVacacionesREsumen.MdiParent = this;
                frmVacacionesREsumen.Icon = ICono;
                frmVacacionesREsumen.FormClosed += new FormClosedEventHandler(CerrarfrmVacacionesREsumen);
                frmVacacionesREsumen.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmVacacionesREsumen.Activate();
                ValidarVentanas(frmVacacionesREsumen);
            }
        }

        private void CerrarfrmVacacionesREsumen(object sender, FormClosedEventArgs e)
        {
            frmVacacionesREsumen = null;
        }
        ModuloRRHH.frmReporteGratificaciones frmReporteGRatis;
        private void gratificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmReporteGRatis == null)
            {
                frmReporteGRatis = new ModuloRRHH.frmReporteGratificaciones();
                frmReporteGRatis.MdiParent = this;
                frmReporteGRatis.Icon = ICono;
                frmReporteGRatis.FormClosed += new FormClosedEventHandler(CerrarfrmReporteGRatis);
                frmReporteGRatis.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmReporteGRatis.Activate();
                ValidarVentanas(frmReporteGRatis);
            }
        }

        private void CerrarfrmReporteGRatis(object sender, FormClosedEventArgs e)
        {
            frmReporteGRatis = null;
        }
        ModuloRRHH.frmReporteCTS frmreporteCTS;
        private void cTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmreporteCTS == null)
            {
                frmreporteCTS = new ModuloRRHH.frmReporteCTS();
                frmreporteCTS.MdiParent = this;
                frmreporteCTS.Icon = ICono;
                frmreporteCTS.FormClosed += new FormClosedEventHandler(CerrarfrmreporteCTS);
                frmreporteCTS.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmreporteCTS.Activate();
                ValidarVentanas(frmreporteCTS);
            }
        }

        private void CerrarfrmreporteCTS(object sender, FormClosedEventArgs e)
        {
            frmreporteCTS = null;
        }
        ModuloRRHH.frmReporteAFP frmreporteafps;
        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {

        }

        private void Cerrarfrmreporteafps(object sender, FormClosedEventArgs e)
        {
            frmreporteafps = null;
        }
        ModuloRRHH.frmReporteRenta frmreporteaRentas;
        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            if (frmreporteaRentas == null)
            {
                frmreporteaRentas = new ModuloRRHH.frmReporteRenta();
                frmreporteaRentas.MdiParent = this;
                frmreporteaRentas.Icon = ICono;
                frmreporteaRentas.FormClosed += new FormClosedEventHandler(CerrarfrmreporteaRentas);
                frmreporteaRentas.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmreporteaRentas.Activate();
                ValidarVentanas(frmreporteaRentas);
            }
        }

        private void CerrarfrmreporteaRentas(object sender, FormClosedEventArgs e)
        {
            frmreporteaRentas = null;
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            if (frmreporteafps == null)
            {
                frmreporteafps = new ModuloRRHH.frmReporteAFP();
                frmreporteafps.MdiParent = this;
                frmreporteafps.Icon = ICono;
                frmreporteafps.FormClosed += new FormClosedEventHandler(Cerrarfrmreporteafps);
                frmreporteafps.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmreporteafps.Activate();
                ValidarVentanas(frmreporteafps);
            }

        }
        ModuloRRHH.frmReporteSeguroSocial frmreporteaSeguros;

        private void toolStripMenuItem14_Click_1(object sender, EventArgs e)
        {
            if (frmreporteaSeguros == null)
            {
                frmreporteaSeguros = new ModuloRRHH.frmReporteSeguroSocial();
                frmreporteaSeguros.MdiParent = this;
                frmreporteaSeguros.Icon = ICono;
                frmreporteaSeguros.FormClosed += new FormClosedEventHandler(CerrarfrmreporteaSeguros);
                frmreporteaSeguros.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmreporteaSeguros.Activate();
                ValidarVentanas(frmreporteaSeguros);
            }
        }

        private void CerrarfrmreporteaSeguros(object sender, FormClosedEventArgs e)
        {
            frmreporteaSeguros = null;
        }
        ModuloFinanzas.frmReporteConciliacionesFinanzas frmReporteFinanzas;
        private void reporteConcliliaciónFinanzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmReporteFinanzas == null)
            {
                frmReporteFinanzas = new ModuloFinanzas.frmReporteConciliacionesFinanzas();
                frmReporteFinanzas.MdiParent = this;
                frmReporteFinanzas.Icon = ICono;
                frmReporteFinanzas.FormClosed += new FormClosedEventHandler(CerrarfrmReporteFinanzas);
                frmReporteFinanzas.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmReporteFinanzas.Activate();
                ValidarVentanas(frmReporteFinanzas);
            }
        }
        private void CerrarfrmReporteFinanzas(object sender, FormClosedEventArgs e)
        {
            frmReporteFinanzas = null;
        }
        ModuloCompensaciones.frmCompensacionCuentas frmCompensarCuentas;
        private void compensarCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCompensarCuentas == null)
            {
                frmCompensarCuentas = new ModuloCompensaciones.frmCompensacionCuentas();
                frmCompensarCuentas.MdiParent = this;
                frmCompensarCuentas.Icon = ICono;
                frmCompensarCuentas.FormClosed += new FormClosedEventHandler(CerrarfrmCompensarCuentas);
                frmCompensarCuentas.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmCompensarCuentas.Activate();
                ValidarVentanas(frmCompensarCuentas);
            }
        }

        private void CerrarfrmCompensarCuentas(object sender, FormClosedEventArgs e)
        {
            frmCompensarCuentas = null;
        }
        ModuloReportes.LibrosElectronicos.frmLibroDiario5_3 FrmLibros5_3;
        private void libroDiarioDetalleDelPlanContableUtilizadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (FrmLibros5_3 == null)
            {
                FrmLibros5_3 = new ModuloReportes.LibrosElectronicos.frmLibroDiario5_3();
                FrmLibros5_3.MdiParent = this;
                FrmLibros5_3.Icon = ICono;
                FrmLibros5_3.FormClosed += new FormClosedEventHandler(CerrarFrmLibros5_3);
                FrmLibros5_3.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                FrmLibros5_3.Activate();
                ValidarVentanas(FrmLibros5_3);
            }
        }

        private void CerrarFrmLibros5_3(object sender, FormClosedEventArgs e)
        {
            FrmLibros5_3 = null;
        }
        ModuloReportes.LibrosElectronicos.frmLibroDiario5_4 FrmLibros5_4;
        private void libroDiarioDeFormatoSimplificadoDetalleDelPlanContableUtilizadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (FrmLibros5_4 == null)
            {
                FrmLibros5_4 = new ModuloReportes.LibrosElectronicos.frmLibroDiario5_4();
                FrmLibros5_4.MdiParent = this;
                FrmLibros5_4.Icon = ICono;
                FrmLibros5_4.FormClosed += new FormClosedEventHandler(CerrarFrmLibros5_4);
                FrmLibros5_4.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                FrmLibros5_4.Activate();
                ValidarVentanas(FrmLibros5_4);
            }
        }

        private void CerrarFrmLibros5_4(object sender, FormClosedEventArgs e)
        {
            frmLibroDiario5_4 = null;
        }
        ModuloReportes.frmReporteCentrodeCosto frmreporteCentrodeCostos;
        private void reporteCentroDeCostosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmreporteCentrodeCostos == null)
            {
                frmreporteCentrodeCostos = new ModuloReportes.frmReporteCentrodeCosto();
                frmreporteCentrodeCostos.MdiParent = this;
                frmreporteCentrodeCostos.Icon = ICono;
                frmreporteCentrodeCostos.FormClosed += new FormClosedEventHandler(CerrarfrmreporteCentrodeCostos);
                frmreporteCentrodeCostos.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmreporteCentrodeCostos.Activate();
                ValidarVentanas(frmreporteCentrodeCostos);
            }
        }

        private void CerrarfrmreporteCentrodeCostos(object sender, FormClosedEventArgs e)
        {
            frmreporteCentrodeCostos = null;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!frmLogin.BaseRemota)
            {
                //Validamos que el tipo de cambio exista y no este registrado
                DateTime FechaConsulta = DateTime.Now;
                DataTable TablaTC = CapaLogica.TipodeCambioxDia(FechaConsulta);
                if (TablaTC.Rows.Count == 0) // no existe registrado el tipo de cambio
                {
                    DescargarTipoCambioDia(FechaConsulta);
                }
                TimerTC.Interval = 3600000;//pasamos a que valide cada hora
            }
            else
            {
                TimerTC.Enabled = false;


            }
        }
        public class TIPOCAMBIO
        {
            public decimal compra { get; set; }
            public decimal venta { get; set; }
            public string origen { get; set; }
            public string moneda { get; set; }
            public DateTime fecha { get; set; }
        }
        public async Task<string> GetHTTPs(DateTime Fecha)
        {
            string url = Configuraciones.APITcDiario + Configuraciones.ToFechaSql(Fecha);// + año + "-" + mes.ToString("00");
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }
        public async void DescargarTipoCambioDia(DateTime Fecha)
        {
            try
            {
                string respuesta = await GetHTTPs(Fecha);
                respuesta = "[\n " + respuesta + " \n]";
                List<TIPOCAMBIO> lstTC = JsonConvert.DeserializeObject<List<TIPOCAMBIO>>(respuesta);
                //SAcamos la Data             
                if (lstTC.Count > 0)
                {
                    CapaLogica.TipodeCambio(15, lstTC[0].fecha.Year, lstTC[0].fecha.Month, lstTC[0].fecha.Day, lstTC[0].compra, lstTC[0].venta, null);
                }
            }
            catch (Exception) { }
        }
        ModuloActivoFijo.frmActivoFijo frmActivoFijo;
        private void activoFijoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmActivoFijo == null)
            {
                frmActivoFijo = new ModuloActivoFijo.frmActivoFijo();
                frmActivoFijo.MdiParent = this;
                frmActivoFijo.Icon = ICono;
                frmActivoFijo.FormClosed += new FormClosedEventHandler(CerrarfrmActivoFijo);
                frmActivoFijo.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmActivoFijo.Activate();
                ValidarVentanas(frmActivoFijo);
            }
        }
        private void CerrarfrmActivoFijo(object sender, FormClosedEventArgs e)
        {
            frmActivoFijo = null;
        }
        ModuloActivoFijo.frmActivoFijoCuentasContable frmcuentascontablesactivofijo;
        private void cuentasContablesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (frmcuentascontablesactivofijo == null)
            {
                frmcuentascontablesactivofijo = new ModuloActivoFijo.frmActivoFijoCuentasContable();
                frmcuentascontablesactivofijo.MdiParent = this;
                frmcuentascontablesactivofijo.Icon = ICono;
                frmcuentascontablesactivofijo.FormClosed += new FormClosedEventHandler(Cerrarfrmcuentascontablesactivofijo);
                frmcuentascontablesactivofijo.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmcuentascontablesactivofijo.Activate();
                ValidarVentanas(frmcuentascontablesactivofijo);
            }
        }

        private void Cerrarfrmcuentascontablesactivofijo(object sender, FormClosedEventArgs e)
        {
            frmcuentascontablesactivofijo = null;
        }
        ModuloActivoFijo.frmProcesoDepreciacion frmprocesodepreciacion;
        private void depreciacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmprocesodepreciacion == null)
            {
                frmprocesodepreciacion = new ModuloActivoFijo.frmProcesoDepreciacion();
                frmprocesodepreciacion.MdiParent = this;
                frmprocesodepreciacion.Icon = ICono;
                frmprocesodepreciacion.FormClosed += new FormClosedEventHandler(Cerrarfrmprocesodepreciacion);
                frmprocesodepreciacion.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmprocesodepreciacion.Activate();
                ValidarVentanas(frmprocesodepreciacion);
            }
        }

        private void Cerrarfrmprocesodepreciacion(object sender, FormClosedEventArgs e)
        {
            frmprocesodepreciacion = null;
        }
        ModuloActivoFijo.frmReporteCostoyDepreciacionActivo frmreporteCostoyDepreciacion;

        private void reporteDepreciaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (frmreporteCostoyDepreciacion == null)
            {
                frmreporteCostoyDepreciacion = new ModuloActivoFijo.frmReporteCostoyDepreciacionActivo();
                frmreporteCostoyDepreciacion.MdiParent = this;
                frmreporteCostoyDepreciacion.Icon = ICono;
                frmreporteCostoyDepreciacion.FormClosed += new FormClosedEventHandler(CerrarfrmreporteCostoyDepreciacion);
                frmreporteCostoyDepreciacion.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmreporteCostoyDepreciacion.Activate();
                ValidarVentanas(frmreporteCostoyDepreciacion);
            }
        }

        private void CerrarfrmreporteCostoyDepreciacion(object sender, FormClosedEventArgs e)
        {
            frmreporteCostoyDepreciacion = null;
        }
        ModuloActivoFijo.frmReporteDepreciaciones frmReporteDepreciaciones;
        private void reporteActivosFijosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmReporteDepreciaciones == null)
            {
                frmReporteDepreciaciones = new ModuloActivoFijo.frmReporteDepreciaciones();
                frmReporteDepreciaciones.MdiParent = this;
                frmReporteDepreciaciones.Icon = ICono;
                frmReporteDepreciaciones.FormClosed += new FormClosedEventHandler(CerrarfrmReporteDepreciaciones);
                frmReporteDepreciaciones.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmReporteDepreciaciones.Activate();
                ValidarVentanas(frmReporteDepreciaciones);
            }
        }

        private void CerrarfrmReporteDepreciaciones(object sender, FormClosedEventArgs e)
        {
            frmReporteDepreciaciones = null;
        }
        ModuloRRHH.frmReporteComisiones frmreportecomisiones;
        private void comisionesYBonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmreportecomisiones == null)
            {
                frmreportecomisiones = new ModuloRRHH.frmReporteComisiones();
                frmreportecomisiones.MdiParent = this;
                frmreportecomisiones.Icon = ICono;
                frmreportecomisiones.FormClosed += new FormClosedEventHandler(Cerrarfrmreportecomisiones);
                frmreportecomisiones.Show();
                frmMenu_SizeChanged(sender, new EventArgs());
            }
            else
            {
                frmreportecomisiones.Activate();
                ValidarVentanas(frmreportecomisiones);
            }
        }
        private void Cerrarfrmreportecomisiones(object sender, FormClosedEventArgs e)
        {
            frmreportecomisiones = null;
        }
        frmAfpsComisiones frmafp;
        private void aFPComisionesYPrimasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmafp == null)
            {
                frmafp = new frmAfpsComisiones();
                frmafp.MdiParent = this;
                frmafp.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmafp.FormClosed += new FormClosedEventHandler(cerrarafps);
                frmafp.Show();
            }
            else
            {
                frmafp.Activate();
                ValidarVentanas(frmafp);
            }
        }
        void cerrarafps(object sender, FormClosedEventArgs e)

        {
            frmafp = null;
            //pbfotoempleado.Visible = false;
        }
        ModuloRRHH.frmRegistroFacturasCreditoEPS frmRegistroFacEPS;
        private void facturasParaElCreditoEPSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (frmRegistroFacEPS == null)
            {
                frmRegistroFacEPS = new ModuloRRHH.frmRegistroFacturasCreditoEPS();
                frmRegistroFacEPS.MdiParent = this;
                frmRegistroFacEPS.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmRegistroFacEPS.FormClosed += new FormClosedEventHandler(cerrarfrmRegistroFacEPS);
                frmRegistroFacEPS.Show();
            }
            else
            {
                frmRegistroFacEPS.Activate();
                ValidarVentanas(frmRegistroFacEPS);
            }
        }

        private void cerrarfrmRegistroFacEPS(object sender, FormClosedEventArgs e)
        {
            frmRegistroFacEPS = null;
        }
        ModuloCompensaciones.frmFondoFijoPagoFinanzas frmfondopagofinanzas;
        private void pagoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmfondopagofinanzas == null)
            {
                frmfondopagofinanzas = new ModuloCompensaciones.frmFondoFijoPagoFinanzas();
                frmfondopagofinanzas.MdiParent = this;
                frmfondopagofinanzas.Icon = ICono;
                //presus.StartPosition = FormStartPosition.CenterParent;
                ////pbfotoempleado.Visible = false;
                frmfondopagofinanzas.FormClosed += new FormClosedEventHandler(cerrarfrmfondopagofinanzas);
                frmfondopagofinanzas.Show();
            }
            else
            {
                frmfondopagofinanzas.Activate();
                ValidarVentanas(frmfondopagofinanzas);
            }
        }

        private void cerrarfrmfondopagofinanzas(object sender, FormClosedEventArgs e)
        {
            frmfondopagofinanzas = null;
        }

        private void btnCargarSistema_Click(object sender, EventArgs e)
        {
            SISGEM.frmCargarSistema frm = new SISGEM.frmCargarSistema();
            frm.Show();

            SISGEM.Principal pinci = new SISGEM.Principal();
            pinci.Show();

        }

        private void versionActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.frmprincipal.Show();
        }
    }
}
