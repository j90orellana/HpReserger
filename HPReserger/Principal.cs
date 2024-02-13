using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SISGEM
{
    public partial class Principal : RibbonForm
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {
                string carpetaDeAplicacion = Application.CommonAppDataPath;
                // Combinar la ruta de la carpeta de la aplicación con el nombre del archivo
                string rutaArchivo = Path.Combine(carpetaDeAplicacion, "skin.txt");
                // Leer el contenido del archivo
                string contenido = File.ReadAllText(rutaArchivo);
                defaultLookAndFeel1.LookAndFeel.SkinName = contenido;
            }
            catch
            { }
            navBarControl2.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed;

            //HPResergerCapaDatos.Tabla30SunatRepository xas = new HPResergerCapaDatos.Tabla30SunatRepository();
            //DataTable x = xas.GetAll();

            barVersion.Caption = $"Version:{Application.ProductVersion}";
            barBasedatos.Caption = HPResergerCapaDatos.HPResergerCD.BASEDEDATOS;
            barUser.Caption = $"{HPReserger.frmLogin.Usuario}";

            MdiClient mdi;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    mdi = (MdiClient)ctl;
                    mdi.BackColor = Color.Silver;
                }
                catch (InvalidCastException)
                {
                }
            }

            if (!BaseRemota)
            {

                frmDashBoard frmfrmDashBoard = new frmDashBoard();
                frmfrmDashBoard.MdiParent = this;
                frmfrmDashBoard.Show();

                ControlPerfilPrioritario();
            }
            else
            {
                barStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            }
        }
        public void ControlPerfilPrioritario()
        {
            btnPeriodos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            if ((new int[] { 0, 1, 2 }).Contains(HPReserger.frmLogin.CodigoUsuario))//Luego se lo cambia por el perfil
            {
                btnPeriodos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

            }
        }
        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmcuentacontable frm = new HPReserger.frmcuentacontable();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPagarComprobantes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmPagarFactura frm = new HPReserger.frmPagarFactura();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDetraccionCompra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmDetracionesPago frm = new HPReserger.frmDetracionesPago();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmDetraccionVentas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmPagoDetraccionesVentas frm = new HPReserger.frmPagoDetraccionesVentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnOperacionesBancarias_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmNroOpBancacia frm = new HPReserger.frmNroOpBancacia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCobroClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmAbonosVentas frm = new HPReserger.frmAbonosVentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barStaticItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            HPReserger.frmLogin.menusito.Show();
        }

        private void btnPrestamoInterEmpresa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmPrestamoInterEmpresas frm = new HPReserger.frmPrestamoInterEmpresas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCobroInterempresa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloFinanzas.frmCobroPrestamosInterEmpresa frm = new HPReserger.ModuloFinanzas.frmCobroPrestamosInterEmpresa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnConciliarbanco_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloFinanzas.FrmConciliarBanco frm = new HPReserger.ModuloFinanzas.FrmConciliarBanco();
            frm.MdiParent = this;
            frm.Show();
        }

        private void b_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloFinanzas.frmReporteConciliaciones frm = new HPReserger.ModuloFinanzas.frmReporteConciliaciones();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnreportefinanzas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloFinanzas.frmReporteConciliacionesFinanzas frm = new HPReserger.ModuloFinanzas.frmReporteConciliacionesFinanzas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnclientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmClientes frm = new HPReserger.frmClientes();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnvendedores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmVendedores frm = new HPReserger.frmVendedores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnFacturaManual_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmFacturaManualVentas frm = new HPReserger.frmFacturaManualVentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCrearActivo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloActivoFijo.frmActivoFijo frm = new HPReserger.ModuloActivoFijo.frmActivoFijo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDepreciaciones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloActivoFijo.frmProcesoDepreciacion frm = new HPReserger.ModuloActivoFijo.frmProcesoDepreciacion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCuentaActivos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloActivoFijo.frmActivoFijoCuentasContable frm = new HPReserger.ModuloActivoFijo.frmActivoFijoCuentasContable();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnReporteDepreciacion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloActivoFijo.frmReporteCostoyDepreciacionActivo frm = new HPReserger.ModuloActivoFijo.frmReporteCostoyDepreciacionActivo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnReporteActivofijo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloActivoFijo.frmReporteDepreciaciones frm = new HPReserger.ModuloActivoFijo.frmReporteDepreciaciones();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDinamicaContable_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmcuentacontable frm = new HPReserger.frmcuentacontable();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnAsientoContable_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmAsientoContable frm = new HPReserger.frmAsientoContable();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPeriodos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmPeriodos frm = new HPReserger.frmPeriodos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTipoCambio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmTipodeCambio frm = new HPReserger.frmTipodeCambio();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTipoCambioSBS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmTipodeCambioSBS frm = new HPReserger.frmTipodeCambioSBS();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDifCambioMensual_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmDiferenciaCambioMensual frm = new HPReserger.frmDiferenciaCambioMensual();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCierreMensual_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmcierremensual frm = new HPReserger.frmcierremensual();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCierreAnual_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmAsientosApertura frm = new HPReserger.frmAsientosApertura();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnFacturaCompra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.FrmFacturaManual frm = new HPReserger.FrmFacturaManual();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnFonfijoApertura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloCompensaciones.frmFondoFijo frm = new HPReserger.ModuloCompensaciones.frmFondoFijo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnFondoCompensar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloCompensaciones.frmFondoFijoPago frm = new HPReserger.ModuloCompensaciones.frmFondoFijoPago();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnFondoPago_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloCompensaciones.frmFondoFijoPagoFinanzas frm = new HPReserger.ModuloCompensaciones.frmFondoFijoPagoFinanzas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnEntregaApertura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloCompensaciones.frmEntregaRendir frm = new HPReserger.ModuloCompensaciones.frmEntregaRendir();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnEntregaCompensar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloCompensaciones.frmEntregaRendirPago frm = new HPReserger.ModuloCompensaciones.frmEntregaRendirPago();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnEntregaDevolucion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloCompensaciones.frmEntregaRendirDinero frm = new HPReserger.ModuloCompensaciones.frmEntregaRendirDinero();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnReembolsoAplicacion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloCompensaciones.frmReembolsoGastos frm = new HPReserger.ModuloCompensaciones.frmReembolsoGastos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnReembolsoPago_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloCompensaciones.frmReembolsoGastosPago frm = new HPReserger.ModuloCompensaciones.frmReembolsoGastosPago();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnAnticipoRegistro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloCompensaciones.frmAnticipoProveedores frm = new HPReserger.ModuloCompensaciones.frmAnticipoProveedores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnAnticipoAplicacion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloCompensaciones.frmListarCompensacionesAnticipo frm = new HPReserger.ModuloCompensaciones.frmListarCompensacionesAnticipo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnListaCompensaciones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloCompensaciones.frmListarCompensaciones frm = new HPReserger.ModuloCompensaciones.frmListarCompensaciones();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCompensarCuenta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloCompensaciones.frmCompensacionCuentas frm = new HPReserger.ModuloCompensaciones.frmCompensacionCuentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnReporteAnalitico_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmReporteAnalitico frm = new HPReserger.frmReporteAnalitico();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnReporteAnalitico2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmReporteAnalitico2 frm = new HPReserger.frmReporteAnalitico2();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnBalanceComprobacion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloReportes.frmBalanceComprobacion frm = new HPReserger.ModuloReportes.frmBalanceComprobacion();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnEstadoSituacion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmReporteGeneral frm = new HPReserger.frmReporteGeneral();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnEstadoResultado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.EstadoGananciaPerdidas frm = new HPReserger.EstadoGananciaPerdidas();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnlibro11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloReportes.LibrosElectronicos.frmLibroBancosEfectivo frm = new HPReserger.ModuloReportes.LibrosElectronicos.frmLibroBancosEfectivo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnlibro12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            HPReserger.ModuloReportes.LibrosElectronicos.frmLibroBancosCorriente frm = new HPReserger.ModuloReportes.LibrosElectronicos.frmLibroBancosCorriente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnlibro32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloReportes.LibrosElectronicos.frmLibroInventario3_2 frm = new HPReserger.ModuloReportes.LibrosElectronicos.frmLibroInventario3_2();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnlibro33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            HPReserger.ModuloReportes.LibrosElectronicos.frmLibroInventarios3_3 frm = new HPReserger.ModuloReportes.LibrosElectronicos.frmLibroInventarios3_3();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnlibro34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloReportes.LibrosElectronicos.frmLibroInventarios3_4 frm = new HPReserger.ModuloReportes.LibrosElectronicos.frmLibroInventarios3_4();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnlibro35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloReportes.LibrosElectronicos.frmLibroInventarios3_5 frm = new HPReserger.ModuloReportes.LibrosElectronicos.frmLibroInventarios3_5();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnlibro36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            HPReserger.ModuloReportes.LibrosElectronicos.frmLibroInventarios3_6 frm = new HPReserger.ModuloReportes.LibrosElectronicos.frmLibroInventarios3_6();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnlibro311_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloReportes.LibrosElectronicos.frmLibroInventarios3_11 frm = new HPReserger.ModuloReportes.LibrosElectronicos.frmLibroInventarios3_11();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnlibro312_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloReportes.LibrosElectronicos.frmLibroInventarios3_12 frm = new HPReserger.ModuloReportes.LibrosElectronicos.frmLibroInventarios3_12();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnlibro313_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloReportes.LibrosElectronicos.frmLibroInventarios3_13 frm = new HPReserger.ModuloReportes.LibrosElectronicos.frmLibroInventarios3_13();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnlibro51_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloReportes.LibrosElectronicos.frmLibroDiario frm = new HPReserger.ModuloReportes.LibrosElectronicos.frmLibroDiario();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnlibro52_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloReportes.LibrosElectronicos.frmLibroDiario5_2 frm = new HPReserger.ModuloReportes.LibrosElectronicos.frmLibroDiario5_2();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnlibro53_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloReportes.LibrosElectronicos.frmLibroDiario5_3 frm = new HPReserger.ModuloReportes.LibrosElectronicos.frmLibroDiario5_3();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnlibro54_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloReportes.LibrosElectronicos.frmLibroDiario5_4 frm = new HPReserger.ModuloReportes.LibrosElectronicos.frmLibroDiario5_4();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnlibro61_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            HPReserger.frmRegMayorxCuentas frm = new HPReserger.frmRegMayorxCuentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnlibro81_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmRegistroCompras frm = new HPReserger.frmRegistroCompras();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnlibro82_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmRegistroCompras8_2 frm = new HPReserger.frmRegistroCompras8_2();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnlibro83_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmRegistroCompras8_3 frm = new HPReserger.frmRegistroCompras8_3();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnlibro141_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmRegistroVentas frm = new HPReserger.frmRegistroVentas();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnlibro142_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmRegistroVentas14_2 frm = new HPReserger.frmRegistroVentas14_2();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnEmpleado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmEmpleado frm = new HPReserger.frmEmpleado();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnParametros_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmParametros frm = new HPReserger.frmParametros();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnDetracciones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmdetracciones frm = new HPReserger.frmdetracciones();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPeriocidad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmperiodicidad frm = new HPReserger.frmperiodicidad();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnMedioPagos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloFinanzas.frmMediosPagos frm = new HPReserger.ModuloFinanzas.frmMediosPagos();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnTIpoFaltas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmTipoFaltas frm = new HPReserger.frmTipoFaltas();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnPais_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmPais frm = new HPReserger.frmPais();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnDepartamento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmdepartamento frm = new HPReserger.frmdepartamento();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnprovincia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmprovincias frm = new HPReserger.frmprovincias();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btndistrito_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmDistritos frm = new HPReserger.frmDistritos();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnempresa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmEmpresas frm = new HPReserger.frmEmpresas();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnarea_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmArea frm = new HPReserger.frmArea();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnCargo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmCargos frm = new HPReserger.frmCargos();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnAreaCargo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            HPReserger.frmAreaCargo frm = new HPReserger.frmAreaCargo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnProveedor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmproveedor frm = new HPReserger.frmproveedor();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnEntidad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.frmEntiFinanciera frm = new HPReserger.frmEntiFinanciera();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnTipoCuentas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPReserger.ModuloBancario.frmTiposdeCuentasBancarias frm = new HPReserger.ModuloBancario.frmTiposdeCuentasBancarias();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnCuentasBancarias_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            HPReserger.ModuloBancario.frmCuentasBancarias frm = new HPReserger.ModuloBancario.frmCuentasBancarias();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCambiarClave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            HPReserger.FrmCambioContra frm = new HPReserger.FrmCambioContra();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            HPReserger.FrmUsuarios frm = new HPReserger.FrmUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }
        public Boolean ValidacionesParaCerrar()
        {
            if (AbortarCerrarPrograma) { msg("Cierre la Ventana del Detalle del Asiento"); return true; }
            return false;
        }
        public static Boolean AbortarCerrarPrograma = false;
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        int cerrado = 0;
        int cerrar = 0;

        public bool BaseRemota { get; internal set; }

        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void btnCerrarSesion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ValidacionesParaCerrar())
            {
                if (msgp("Seguro Desea Cerrar Sesión") == DialogResult.Yes)

                {
                    cerrado = 1; cerrar = 5;
                    this.Close();
                    HPReserger.frmLogin logeo = new HPReserger.frmLogin();
                    HPReserger.frmLogin.DesconectarUsuario();
                    logeo.Show();
                }
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ValidacionesParaCerrar()) e.Cancel = true;
            else
            {
                if (cerrado == 0 && cerrar == 10)
                {
                    HPReserger.frmLogin.DesconectarUsuario();
                    Application.Exit();
                }
                if (cerrar == 0)
                {
                    if (msgp("Seguro Desea Salir del Sistema") == DialogResult.Yes)
                    {
                        cerrado = 0; cerrar = 10;
                        HPReserger.frmLogin.DesconectarUsuario();
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
        }

        private void btnSkines_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string skins = defaultLookAndFeel1.LookAndFeel.SkinName;
            SkinPickerForm xskin = new SkinPickerForm(defaultLookAndFeel1);
            xskin.Icon = this.Icon;
            if (DialogResult.OK == xskin.ShowDialog())
            {
                defaultLookAndFeel1.LookAndFeel.SkinName = xskin.SelectedSkinName;
                string contenido = xskin.SelectedSkinName;
                // Obtener la ruta de la carpeta de la aplicación
                string carpetaDeAplicacion = Application.CommonAppDataPath;
                // Combinar la ruta de la carpeta de la aplicación con el nombre del archivo
                string rutaArchivo = Path.Combine(carpetaDeAplicacion, "skin.txt");
                // Escribir en el archivo
                File.WriteAllText(rutaArchivo, contenido);
            }
            else
                defaultLookAndFeel1.LookAndFeel.SkinName = skins;
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barStaticItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDashBoard frmfrmDashBoard = new frmDashBoard();
            frmfrmDashBoard.MdiParent = this;
            frmfrmDashBoard.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CRM.frmClienteCRM frm = new CRM.frmClienteCRM();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CRM.FrmAddCliente frm = new CRM.FrmAddCliente();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CRM.frmSegumiento frm = new CRM.frmSegumiento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CRM.frmAddSeguimiento frm = new CRM.frmAddSeguimiento();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CRM.frmProyectos frm = new CRM.frmProyectos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CRM.frmAddProyecto frm = new CRM.frmAddProyecto();
            frm.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CRM.frmContactoCRM frm = new CRM.frmContactoCRM();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barCheckItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CRM.frmAddContacto frm = new CRM.frmAddContacto();
            frm.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CRM.frmSedeCRM frm = new CRM.frmSedeCRM();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CRM.frmAddSedesCRM frm = new CRM.frmAddSedesCRM();
            frm.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CRM.frmUsuariosCRM frm = new CRM.frmUsuariosCRM();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CRM.frmProductosCRM frm = new CRM.frmProductosCRM();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CRM.frmServicioCRM frm = new CRM.frmServicioCRM();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CRM.frmAddUsuario frm = new CRM.frmAddUsuario();
            frm.Show();
        }
    }
}

