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
    public partial class frmMenu : Form, IForm, IFormEmpleado, IRentas, IProfesion
    {
        public frmMenu()
        {
            InitializeComponent();
            
        }
        public void CargarNroHijos(int tipo, string doc)
        {
            frmE.CargarNroHijos(tipo, doc);
        }
        public void CargarContratos()
        {
            frmE.VerificarContrato();
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
            frmLOP.Show();
        }
        frmCotizacion frmCOT;
        private void generaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCOT == null)
            {
                frmCOT = new frmCotizacion();
                frmCOT.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
        private void frmMenu_Load(object sender, EventArgs e)
        {
            MdiClient mdi;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    mdi = (MdiClient)ctl;
                    mdi.BackColor = Color.FromArgb(240, 240, 240);
                }
                catch (InvalidCastException )
                {
                }
            }
            cerrado = 0;
            lblwelcome.Text = "Bienvenido: " + Nombres;
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
        }
        void cerrar_cotizacion(object sender, FormClosedEventArgs e)
        {
            frmCOT = null;
            pbfotoempleado.Visible = true;
        }
        frmAprobarCotizacion frmACOT;
        private void aprobaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmACOT == null)
            {
                frmACOT = new frmAprobarCotizacion();
                frmACOT.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmOrdenCompra frmOC;
        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmOC == null)
            {
                frmOC = new frmOrdenCompra();
                frmOC.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmAlmacen frmArti;
        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmArti == null)
            {
                frmArti = new frmAlmacen();
                frmArti.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmAlmacenServicio frmAS;
        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAS == null)
            {
                frmAS = new frmAlmacenServicio();
                frmAS.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmSolicitudEmpleado frmSE;
        private void solicitudEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmSE == null)
            {
                frmSE = new frmSolicitudEmpleado();
                frmSE.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmPostulante frmP;
        private void postulanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmP == null)
            {
                frmP = new frmPostulante();
                frmP.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmEmpleado frmE;

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmE == null)
            {
                frmE = new frmEmpleado();
                frmE.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmOrdenPedido frmOP;
        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmOP == null)
            {
                frmOP = new frmOrdenPedido();
                frmOP.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmVacaciones frmVaca;
        private void vacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmVaca == null)
            {
                frmVaca = new frmVacaciones();
                frmVaca.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmDesvinculacion frmDesv;
        private void desvinculaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDesv == null)
            {
                frmDesv = new frmDesvinculacion();
                frmDesv.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmFaltas frmF;
        private void faltasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmF == null)
            {
                frmF = new frmFaltas();
                frmF.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmAmonestacionesPremio frmAP;
        private void amonestacionesPremiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAP == null)
            {
                frmAP = new frmAmonestacionesPremio();
                frmAP.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmArea area;
        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (area == null)
            {
                area = new frmArea();
                area.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmgerencia gere;
        private void gerenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (gere == null)
            {
                gere = new frmgerencia();
                gere.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmccosto costo;
        private void centroDeCostosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (costo == null)
            {
                costo = new frmccosto();
                costo.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmArticuloServicio artiser;
        private void articuloServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (artiser == null)
            {
                artiser = new frmArticuloServicio();
                artiser.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmmarca marca;
        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (marca == null)
            {
                marca = new frmmarca();
                marca.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmmarcamodelo marcamodelo;
        private void marcamodeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (marcamodelo == null)
            {
                marcamodelo = new frmmarcamodelo();
                marcamodelo.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmmodelo modelo;
        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modelo == null)
            {
                modelo = new frmmodelo();
                modelo.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmdepartamento dep;
        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dep == null)
            {
                dep = new frmdepartamento();
                dep.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmprovincias provin;
        private void provinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (provin == null)
            {
                provin = new frmprovincias();
                provin.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmDistritos distritos;
        private void distritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (distritos == null)
            {
                distritos = new frmDistritos();
                distritos.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmEntiFinanciera entidad;
        private void entidadesFinancierasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (entidad == null)
            {
                entidad = new frmEntiFinanciera();
                entidad.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmproveedor provee;
        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (provee == null)
            {
                provee = new frmproveedor();
                provee.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmTipoId tipoid;
        private void tipoIdentidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tipoid == null)
            {
                tipoid = new frmTipoId();
                tipoid.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmdinamicaContable dinamica;
        private void dinamicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dinamica == null)
            {
                dinamica = new frmdinamicaContable();
                dinamica.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmcuentacontable cuenta;
        private void cuentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cuenta == null)
            {
                cuenta = new frmcuentacontable();
                cuenta.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmAsientoContable asiento;
        private void asientoContableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (asiento == null)
            {
                asiento = new frmAsientoContable();
                asiento.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        FrmPerfil perfil;
        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (perfil == null)
            {
                perfil = new FrmPerfil();
                perfil.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
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
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
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
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        int cerrar = 0;
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cerrado == 0 && cerrar == 10)
            {
                Application.Exit();
            }
            if (cerrar == 0)
            {
                if (MessageBox.Show("Seguro Desea Salir del Sistema", "HpReserger", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    cerrado = 0; cerrar = 10;
                    Application.Exit();

                }
                else
                    e.Cancel = true;

            }
            if (cerrar == 5)
            {
                cerrar = 10;
            }
        }
        frmListarOCFaltantes frmlisoc;

        private void listarOCFaltantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmlisoc == null)
            {
                frmlisoc = new frmListarOCFaltantes();
                frmlisoc.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        FrmFactura frmfac;
        private void facturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmfac == null)
            {
                frmfac = new FrmFactura();
                frmfac.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        Frmreporteop orde;
        private void ordenesPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (orde == null)
            {
                orde = new Frmreporteop();
                orde.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
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
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmreporteempleado reporemple;
        private void empleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (reporemple == null)
            {
                reporemple = new frmreporteempleado();
                reporemple.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        int cerrado = 0;
        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro Desea Cerrar Sesión", "HpReserger", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                cerrado = 1; cerrar = 5;
                this.Close();
                frmLogin logeo = new frmLogin();
                logeo.Show();
            }
        }
        frmGenerarBoletas genbole;
        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (genbole == null)
            {
                genbole = new frmGenerarBoletas();
                genbole.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        FrmGenerarRemuneracionRenta remunrenta;
        private void generarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (remunrenta == null)
            {
                remunrenta = new FrmGenerarRemuneracionRenta();
                remunrenta.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmProyectos proyectos;
        private void proyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proyectos == null)
            {
                proyectos = new frmProyectos();
                proyectos.MdiParent = this;
                // proyectos.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
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
                //presus.StartPosition = FormStartPosition.CenterParent;
                presus.FormClosed += new FormClosedEventHandler(presus_cerrarpresus);
                presus.Show();
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
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
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmReportePresupuestoCuenta presuscuenta;
        private void presupuestoOperacionesCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (presuscuenta == null)
            {
                presuscuenta = new frmReportePresupuestoCuenta();
                presuscuenta.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmPagarFactura pagarfac;
        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pagarfac == null)
            {
                pagarfac = new frmPagarFactura();
                pagarfac.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmREciboPorHonorario recibohonorario;
        private void reciboPorHonorariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (recibohonorario == null)
            {
                recibohonorario = new frmREciboPorHonorario();
                recibohonorario.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmFacturasPorPagar facturaporpagar;
        private void facturasSinPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (facturaporpagar == null)
            {
                facturaporpagar = new HPReserger.frmFacturasPorPagar();
                facturaporpagar.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmFicSinFaactura ficsinfactura;
        private void ficSinComprobantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ficsinfactura == null)
            {
                ficsinfactura = new frmFicSinFaactura();
                ficsinfactura.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmListarOCFaltantes ocfaltantes;
        private void listarOCFaltantesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (ocfaltantes == null)
            {
                ocfaltantes = new frmListarOCFaltantes();
                ocfaltantes.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
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

        private void arToolStripMenuItem_Click(object sender, EventArgs e)
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
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmEmpresaEps frmEps;
        private void empresasEPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEps == null)
            {
                frmEps = new frmEmpresaEps();
                frmEps.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmadicionaleps frmepsadicional;
        private void epsAdicionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmepsadicional == null)
            {
                frmepsadicional = new frmadicionaleps();
                frmepsadicional.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmEstadoCivil EstadoCivil;
        private void estadoCivilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EstadoCivil == null)
            {
                EstadoCivil = new frmEstadoCivil();
                EstadoCivil.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmGradoInstitucional frmGRado;
        private void gradoInstitucionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmGRado == null)
            {
                frmGRado = new frmGradoInstitucional();
                frmGRado.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmmoneda frmmoneda;
        private void monedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmmoneda == null)
            {
                frmmoneda = new frmmoneda();
                frmmoneda.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmperiodicidad periocidad;
        private void periocidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (periocidad == null)
            {
                periocidad = new frmperiodicidad();
                periocidad.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmprofesion frmProfe;
        private void profesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmProfe == null)
            {
                frmProfe = new frmprofesion();
                frmProfe.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmSectorEmpresarial Sector;
        private void sectorEmpresarialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Sector == null)
            {
                Sector = new frmSectorEmpresarial();
                Sector.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmcede frmcede;
        private void sedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmcede == null)
            {
                frmcede = new frmcede();
                frmcede.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmSexo frmsexo;
        private void sexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmsexo == null)
            {
                frmsexo = new frmSexo();
                frmsexo.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmtipocontratacion_ contrata;
        private void tipoContrataciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contrata == null)
            {
                contrata = new frmtipocontratacion_();
                contrata.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmtipocontrato frmcontrato;
        private void tipoDeContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmcontrato == null)
            {
                frmcontrato = new frmtipocontrato();
                frmcontrato.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmvinculacionfamiliar frmVinculo;
        private void vinculoFamiliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmVinculo == null)
            {
                frmVinculo = new frmvinculacionfamiliar();
                frmVinculo.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmAfps frmafp;
        private void afpsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmafp == null)
            {
                frmafp = new frmAfps();
                frmafp.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmInstitucionesEducativas frmedu;
        private void institucionesEducativasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmedu == null)
            {
                frmedu = new frmInstitucionesEducativas();
                frmedu.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmPais pais;
        private void paísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pais == null)
            {
                pais = new frmPais();
                pais.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmOperacion frmope;
        private void operaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmope == null)
            {
                frmope = new frmOperacion();
                frmope.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmSubOperacion frmsub;
        private void subOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmsub == null)
            {
                frmsub = new frmSubOperacion();
                frmsub.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmEmpresas frmempre;
        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmempre == null)
            {
                frmempre = new frmEmpresas();
                frmempre.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        frmParametros frmparam;
        private void parametrosGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmparam == null)
            {
                frmparam = new frmParametros();
                frmparam.MdiParent = this;
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu_FormClosing(sender, new FormClosingEventArgs(CloseReason.UserClosing, false));
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
            if (MessageBox.Show("Desea Cerrar Todas las Ventanas", "HpReserger", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
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
                //presus.StartPosition = FormStartPosition.CenterParent;
                // pbfotoempleado.Visible = false;
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
            pbfotoempleado.Visible = true;
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
            ((IProfesion)frmE).CargarProfesion();
        }
        public void CargarGrado()
        {
            ((IProfesion)frmE).CargarGrado();
        }
        private void frmMenu_Scroll(object sender, ScrollEventArgs e)
        {
            MessageBox.Show("value:" + e.NewValue);
        }
        private void frmMenu_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("button:" + e.Button.ToString());
        }
        private void eliminarPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarPeriodo frmelimin = new frmEliminarPeriodo();
            frmelimin.ShowDialog();
        }
        frmSolicitudes frmsolis;
        private void solicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmsolis == null)
            {
                frmsolis = new frmSolicitudes();
                frmsolis.MdiParent = this;
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
        private void eliminarGratificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarPeriodo frmelimin = new frmEliminarPeriodo();
            frmelimin.Opcion = 2;
            frmelimin.ShowDialog();
        }
        private void eliminarCTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarPeriodo frmelimin = new frmEliminarPeriodo();
            frmelimin.Opcion = 1;
            frmelimin.ShowDialog();
        }       
    }
}