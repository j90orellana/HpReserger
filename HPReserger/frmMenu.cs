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
        frmOrdenPedido frmOP = new frmOrdenPedido();
        frmListarOrdenesPedido frmLOP = new frmListarOrdenesPedido();
        frmCotizacion frmCOT = new frmCotizacion();
        frmAprobarCotizacion frmACOT = new frmAprobarCotizacion();
        frmOrdenCompra frmOC = new frmOrdenCompra();
        frmAlmacen frmArti = new frmAlmacen();
        frmAlmacenServicio frmAS = new frmAlmacenServicio();
        frmSolicitudEmpleado frmSE = new frmSolicitudEmpleado();
        frmPostulante frmP = new frmPostulante();
        frmEmpleado frmE = new frmEmpleado();
        frmVacaciones frmVaca = new frmVacaciones();
        frmDesvinculacion frmDesv = new frmDesvinculacion();
        frmFaltas frmF = new frmFaltas();
        frmAmonestacionesPremio frmAP = new frmAmonestacionesPremio();

        public frmMenu()
        {
            InitializeComponent();
        }

        private void editarAnularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLOP.ShowDialog();
        }

        private void generaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCOT.ShowDialog();
        }

        private void aprobaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmACOT.ShowDialog();
        }

        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOC.ShowDialog();
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArti.ShowDialog();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAS.ShowDialog();
        }

        private void solicitudEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSE.ShowDialog();
        }

        private void postulanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmP.ShowDialog();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmE.ShowDialog();
        }

        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOP.ShowDialog();
        }

        private void vacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVaca.ShowDialog();
        }

        private void desvinculaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDesv.ShowDialog();
        }

        private void faltasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmF.ShowDialog();
        }

        private void amonestacionesPremiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAP.ShowDialog();
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArea area = new frmArea();
            area.ShowDialog();
        }

        private void gerenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgerencia gere = new frmgerencia();
            gere.ShowDialog();
        }

        private void centroDeCostosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmccosto costo = new frmccosto();
            costo.ShowDialog();
        }

        private void articuloServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticuloServicio artiser = new frmArticuloServicio();
            artiser.ShowDialog();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmarca marca = new frmmarca();
            marca.ShowDialog();
        }

        private void marcamodeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmarcamodelo marcamodelo = new frmmarcamodelo();
            marcamodelo.ShowDialog();
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmodelo modelo = new frmmodelo();
            modelo.ShowDialog();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdepartamento dep = new frmdepartamento();
            dep.ShowDialog();
        }

        private void provinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmprovincias provin = new frmprovincias();
            provin.ShowDialog();
        }

        private void distritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDistritos distritos = new frmDistritos();
            distritos.ShowDialog();
        }

        private void entidadesFinancierasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEntiFinanciera entidad = new frmEntiFinanciera();
            entidad.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmproveedor provee = new frmproveedor();
            provee.ShowDialog();

        }

        private void tipoIdentidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoId tipoid = new frmTipoId();
            tipoid.ShowDialog();
        }

        private void dinamicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdinamicaContable dinamica = new frmdinamicaContable();
            dinamica.ShowDialog();
        }

        private void cuentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcuentacontable cuenta = new frmcuentacontable();
            cuenta.ShowDialog();
        }

        private void asientoContableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsientoContable asiento = new frmAsientoContable();
            asiento.ShowDialog();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPerfil perfil = new FrmPerfil();
            perfil.ShowDialog();
        }
        public int usuario;
        public string nick;
        public string Nombres;
        private void frmMenu_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("usuario:"+usuario+"nick:"+nick);
            lblwelcome.Text = "Bienvenido " + Nombres;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios usua = new FrmUsuarios();
            usua.ShowDialog();
        }

        private void cambioDeClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCambioContra contra = new FrmCambioContra();
            contra.idusuario = usuario;
            contra.password = nick;
            contra.ShowDialog();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void listarOCFaltantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarOCFaltantes frmlisoc = new frmListarOCFaltantes();
            frmlisoc.ShowDialog();

        }

        private void facturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmFactura frmfac = new FrmFactura();
            frmfac.ShowDialog();
        }
    }
}