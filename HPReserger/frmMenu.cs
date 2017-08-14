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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
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
                frmCOT.Activate();
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
                frmACOT.Activate();
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
                frmOC.Activate();
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
                frmArti.Activate();
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
                frmAS.Activate();
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
                frmSE.Activate();
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
                frmP.Activate();
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
                frmE.Activate();
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
                frmOP.Activate();
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
                frmVaca.Activate();
        }
        void cerrarvacaciones(object sender, FormClosedEventArgs e)
        {
            presus = null;
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
                frmDesv.Activate();
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
                frmF.Activate();
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
                frmAP.Activate();
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
                area.Activate();
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
                gere.Activate();
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
                costo.Activate();
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
                artiser.Activate();
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
                marca.Activate();
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
                marcamodelo.Activate();
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
                presus.Activate();
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
                dep.Activate();
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
                provin.Activate();
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
                distritos.Activate();
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
                entidad.Activate();
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
                provee.Activate();
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
                tipoid.Activate();
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
                dinamica.Activate();
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
                cuenta.Activate();
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
                asiento.Activate();
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
                perfil.Activate();
        }
        void cerrarperfil(object sender, FormClosedEventArgs e)
        {
            perfil = null;
            pbfotoempleado.Visible = true;
        }
        public int usuario;
        public string nick;
        public string Nombres;
        private void frmMenu_Load(object sender, EventArgs e)
        {
            MdiClient mdi;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    mdi = (MdiClient)ctl;
                    mdi.BackColor = this.BackColor;
                }
                catch (InvalidCastException ex)
                {
                }
            }
            cerrado = 0;
            //MessageBox.Show("usuario:"+usuario+"nick:"+nick);
            lblwelcome.Text = "Bienvenido: " + Nombres;

        }
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
                usua.Activate();
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
                contra.Activate();
        }
        void cerrarusuuario(object sender, FormClosedEventArgs e)
        {
            presus = null;
            pbfotoempleado.Visible = true;
        }
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cerrado == 0)
            {
                Application.Exit();
            }
        }

        private void listarOCFaltantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarOCFaltantes frmlisoc = new frmListarOCFaltantes();
            frmlisoc.Show();

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
                frmfac.Activate();
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
                orde.Activate();
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
                frmreporteoc.Activate();
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
                reporemple.Activate();
        }
        void cerrarempleadoreporte(object sender, FormClosedEventArgs e)
        {
            reporemple = null;
            pbfotoempleado.Visible = true;
        }
        int cerrado = 0;
        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrado = 1;
            this.Close();
            frmLogin logeo = new frmLogin();
            logeo.Show();
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
                genbole.Activate();
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
                remunrenta.Activate();
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
                proyectos.Activate();
        }

        void presus_cerrarproyec(object sender, FormClosedEventArgs e)
        {
            proyectos = null; pbfotoempleado.Visible = true;
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
                presus.Activate();
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
                presuope.Activate();
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
                presuscuenta.Activate();
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
                pagarfac.Activate();
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
                recibohonorario.Activate();
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
                facturaporpagar.Activate();
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
                ficsinfactura.Activate();
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
                ocfaltantes.Activate();
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
                Cargos.Activate();
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
                frmEps.Activate();
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
                frmepsadicional.Activate();
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
                EstadoCivil.Activate();
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
                frmGRado.Activate();
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
                frmmoneda.Activate();
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
                periocidad.Activate();
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
                frmProfe.Activate();
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
                Sector.Activate();
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
                frmcede.Activate();
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
                frmsexo.Activate();
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
                contrata.Activate();
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
                frmcontrato.Activate();
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
                frmVinculo.Activate();
        }
        void cerrarvinculofamiliar(object sender, FormClosedEventArgs e)
        {
            frmVinculo = null;
            pbfotoempleado.Visible = true;
        }
    }
}