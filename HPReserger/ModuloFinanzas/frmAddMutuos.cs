using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;

namespace SISGEM.ModuloFinanzas
{

    public partial class frmAddMutuos : DevExpress.XtraEditors.XtraForm
    {

        public frmAddMutuos()
        {
            InitializeComponent();
        }

        private int _EstadoMutuo = 0;
        public int EstadoMutuo
        {
            get { return _EstadoMutuo; }
            private set
            {
                _EstadoMutuo = value;

                if (value == 1)
                {
                    lblEstado.Caption = "Mutuo Nuevo";
                }
                else if (value == 2)
                {
                    lblEstado.Caption = "Mutuo Guardado";
                }
                else if (value == 3)
                {
                    lblEstado.Caption = "Mutuo Generado Asiento";
                }
                else if (value == 5)
                {
                    lblEstado.Caption = "Mutuo Cancelado";
                }
                else if (value == 0)
                {
                    lblEstado.Caption = "Mutuo Anulado";
                }
            }
        }
        string cuo = "";
        string cuentaContable = "";
        public int idMutuo = 0;
        public int Estado { get; private set; } = 1;
        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Estado = 1;
            EstadoMutuo = 1;
            idMutuo = 0;
            txtcuo.EditValue = "";
            cuo = "";

            MontoTextEdit.EditValue = 0m;
            NumeroTextEdit.EditValue = 0;
            UsuarioCreadorTextEdit.EditValue = HPReserger.frmLogin.CodigoUsuario;
        }

        private void frmAddMutuos_Load(object sender, EventArgs e)
        {
            EstadoMutuo = 1;
            Estado = 1;
            CargarEmpresas();
            CargarUsuariosActivos();
            CargasClientes();
            CargarEntidadFinanciera();
            CargarTipoComprobantesMutuos();
            CargarTipoContratos();
            CargarTipodeInteres();
            CargarImpuesto();
            CargarPeriodos();
            CargarMoneda();

            MontoTextEdit.EditValue = 0m;
            IdTextEdit.ReadOnly = true;

            FechaEmisionDateEdit.EditValue = DateTime.Now;
            FechaIngresoDateEdit.EditValue = DateTime.Now;

            txtcuo.EditValue = "";


            if (idMutuo != 0)
            {
                var clase = new HPResergerCapaLogica.Finanzas.Mutuos();
                var mutuo = clase.ObtenerPorId(idMutuo);


                if (mutuo == null)
                {
                    Estado = 1;
                    EstadoMutuo = 1;

                    XtraMessageBox.Show("No se encontró el Mutuo seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 📌 Datos principales
                cboEmpresa.EditValue = mutuo.IdEmpresa;
                cboProyecto.EditValue = mutuo.IdProyecto;
                cboEtapa.EditValue = mutuo.IdEtapa;
                IdCtaBanco.EditValue = mutuo.IdCtaBanco;

                // 📌 Mutuante
                IdMutuanteSearchLookUpEdit.EditValue = mutuo.IdMutuante;
                IdBancoMutuanteSearchLookUpEdit.EditValue = mutuo.IdBancoMutuante;
                NroCuentaMutuanteTextEdit.EditValue = mutuo.NroCuentaMutuante;
                NroCciMutuanteTextEdit.EditValue = mutuo.NroCciMutuante;

                // 📌 Periodo
                PeriodoTextEdit.EditValue = mutuo.Periodo;
                TipoPeriodoLookUpEdit.EditValue = mutuo.TipoPeriodo;

                // 📌 Fechas
                FechaEmisionDateEdit.EditValue = mutuo.FechaEmision;
                FechaIngresoDateEdit.EditValue = mutuo.FechaIngreso;
                FechaVencimientoDateEdit.EditValue = mutuo.FechaVencimiento;

                // 📌 Comprobante
                TipoContratoSearchLookUpEdit.EditValue = mutuo.TipoContrato;
                SerieTextEdit.EditValue = mutuo.Serie;
                NumeroTextEdit.EditValue = mutuo.Numero;

                // 📌 Moneda / Monto
                MonedaTextEdit.EditValue = mutuo.Moneda;
                MontoTextEdit.EditValue = mutuo.Monto;

                // 📌 Interés / Impuesto
                TipoInteresLookUpEdit.EditValue = mutuo.TipoInteres;
                InteresTextEdit.EditValue = mutuo.Interes;
                TipoComprobanteSearchLookUpEdit.EditValue = mutuo.TipoComprobante;
                ImpuestoSearchLookUpEdit.EditValue = mutuo.Impuesto;

                //// 📌 Contables
                cuentaContable = mutuo.CuentaContable;
                CuentaContableSearchLookUpEdit.EditValue = mutuo.CuentaContable;
                cuo = mutuo.Cuo;
                txtcuo.EditValue = mutuo.Cuo;

                Estado = 2;
                EstadoMutuo = mutuo.Estado;
                lblEstado.Caption = "Mutuo Guardado";

                btnGenerarAsiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                lblcuo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }


        public DataTable GenerarCronograma(decimal monto, decimal tasaInteresPorPeriodo, int numeroPeriodos, int tipoPeriodo, decimal tasaImpuesto, DateTime fechaIngreso, int tipoInteres)
        {
            DataTable dt = new DataTable("Cronograma");
            dt.Columns.Add("Nro", typeof(int));
            dt.Columns.Add("Fecha", typeof(DateTime));
            dt.Columns.Add("Principal", typeof(decimal));
            dt.Columns.Add("Amortizacion", typeof(decimal));
            dt.Columns.Add("Interes", typeof(decimal));
            dt.Columns.Add("Cuota", typeof(decimal));
            dt.Columns.Add("Impuesto", typeof(decimal));
            dt.Columns.Add("Transferencia", typeof(decimal));

            DateTime fecha = fechaIngreso;

            HPResergerCapaLogica.Finanzas.Mutuos oClase = new HPResergerCapaLogica.Finanzas.Mutuos();
            DataTable tImpuesto = oClase.GetImpuestoFiltrado(tasaImpuesto);// id de busqueda para saber el Porcentaje

            if (tImpuesto.Rows.Count > 0) tasaImpuesto = (decimal)tImpuesto.Rows[0]["Porcentaje"] / 100;

            // Fila 0 → Solo muestra el principal inicial
            dt.Rows.Add(0, fecha, monto, 0m, 0m, 0m, 0m, 0m);

            for (int i = 1; i <= numeroPeriodos; i++)
            {
                fecha = SumarPeriodo(fecha, tipoPeriodo);

                decimal tasaReal = ObtenerTasaPorPeriodo(tasaInteresPorPeriodo, tipoInteres, tipoPeriodo);

                decimal montoPorPeriodo = Math.Round(monto * tasaReal, 2);
                decimal amortizacion = (i == numeroPeriodos) ? monto : 0m;
                decimal interes = Math.Round(montoPorPeriodo, 2);
                decimal cuota = interes + amortizacion;
                decimal impuesto = Math.Round(montoPorPeriodo * tasaImpuesto, 2);
                decimal transferencia = cuota - impuesto;
                monto = i == numeroPeriodos ? 0m : monto;

                //decimal montoPorPeriodo = Math.Round(monto * tasaReal, 2);
                //decimal interes = Math.Round(montoPorPeriodo * (1 + tasaImpuesto), 2);
                //decimal impuesto = Math.Round(montoPorPeriodo * tasaImpuesto, 2);
                //decimal amortizacion = (i == numeroPeriodos) ? monto : 0m;
                //decimal cuota = interes + amortizacion;
                //decimal transferencia = cuota - impuesto;
                //monto = i == numeroPeriodos ? 0m : monto;

                monto = i == numeroPeriodos ? 0m : monto;

                dt.Rows.Add(i, fecha, monto, amortizacion, interes, cuota, impuesto, transferencia);
            }

            return dt;
        }
        private decimal ObtenerTasaPorPeriodo(decimal tasa, int tipoInteres, int tipoPeriodo)
        {
            // tasa viene como porcentaje (ej: 12 = 12%)
            decimal tasaDecimal = tasa;

            int periodosPorAnioInteres;
            switch (tipoInteres)
            {
                case 1: periodosPorAnioInteres = 1; break;     // Anual
                case 2: periodosPorAnioInteres = 2; break;     // Semestral
                case 3: periodosPorAnioInteres = 4; break;     // Trimestral
                case 4: periodosPorAnioInteres = 6; break;     // Bimestral
                case 5: periodosPorAnioInteres = 12; break;    // Mensual
                case 6: periodosPorAnioInteres = 360; break;   // Diario
                default: periodosPorAnioInteres = 12; break;
            }

            int periodosPorAnioCronograma;
            switch (tipoPeriodo)
            {
                case 1: periodosPorAnioCronograma = 360; break; // Diario
                case 2: periodosPorAnioCronograma = 12; break;  // Mensual
                case 3: periodosPorAnioCronograma = 1; break;   // Anual
                case 4: periodosPorAnioCronograma = 2; break;   // Semestral
                default: periodosPorAnioCronograma = 12; break;
            }

            // Convertimos la tasa al período real del cronograma
            decimal tasaPorPeriodo = tasaDecimal / periodosPorAnioCronograma * periodosPorAnioInteres;

            return tasaPorPeriodo;
        }


        private DateTime SumarPeriodo(DateTime fecha, int tipoPeriodo)
        {
            switch (tipoPeriodo)
            {
                case 1: return fecha.AddDays(1);       // diario
                case 2: return fecha.AddMonths(1);     // mensual
                case 3: return fecha.AddYears(1);      // anual
                case 4: return fecha.AddMonths(6);     // semestre
                default: return fecha;
            }
        }

        private void CargarPeriodos()
        {
            DataTable Tdata = GetTablaPeriodos();
            TipoPeriodoLookUpEdit.Properties.DataSource = Tdata;
            TipoPeriodoLookUpEdit.Properties.DisplayMember = "Descripcion";
            TipoPeriodoLookUpEdit.Properties.ValueMember = "Id";

            TipoPeriodoLookUpEdit.EditValue = Tdata.Rows.Count > 1 ? Tdata.Rows[1]["Id"] : null;

        }
        private void CargarImpuesto()
        {
            DataTable Tdata = GetTablaImpuestos();
            TipoPeriodoLookUpEdit.Properties.DataSource = Tdata;

            ImpuestoSearchLookUpEdit.Properties.DataSource = Tdata;
            ImpuestoSearchLookUpEdit.Properties.DisplayMember = "Descripcion";
            ImpuestoSearchLookUpEdit.Properties.ValueMember = "Id";

            ImpuestoSearchLookUpEdit.EditValue = Tdata.Rows.Count > 0 ? Tdata.Rows[0]["Id"] : null;

        }
        private void CargasClientes()
        {
            HPResergerCapaLogica.Finanzas.Mutuos oCL = new HPResergerCapaLogica.Finanzas.Mutuos();
            DataTable tData = oCL.ListarClientes();

            IdMutuanteSearchLookUpEdit.Properties.DataSource = tData;
            IdMutuanteSearchLookUpEdit.Properties.DisplayMember = "nombre";
            IdMutuanteSearchLookUpEdit.Properties.ValueMember = "id";

            IdMutuanteSearchLookUpEdit.EditValue = tData.Rows.Count > 0 ? tData.Rows[0]["id"] : null;

            // Limpiar columnas
            var view = IdMutuanteSearchLookUpEdit.Properties.View;
            view.Columns.Clear();

            var col1 = view.Columns.AddVisible("nroid", "Nro Documento");
            var col2 = view.Columns.AddVisible("nombre", "Nombre Mutuante - Cliente");
            view.Columns.AddVisible("direccion", "Dirección Mutuante");

            col1.MinWidth = col1.MaxWidth = 90;
            col1.OptionsColumn.FixedWidth = true;

            col2.MinWidth = col2.MaxWidth = 250;
            col2.OptionsColumn.FixedWidth = true;

            // Ajustar solo las demás columnas
            view.BestFitColumns();
        }
        private void CargarEmpresas()
        {
            HPResergerCapaLogica.HPResergerCL oCL = new HPResergerCapaLogica.HPResergerCL();
            DataTable tData = oCL.Empresa();

            cboEmpresa.Properties.DataSource = tData;
            cboEmpresa.Properties.DisplayMember = "descripcion";
            cboEmpresa.Properties.ValueMember = "codigo";

            cboEmpresa.EditValue = tData.Rows.Count > 0 ? tData.Rows[0]["codigo"] : null;

            // Limpiar columnas
            var view = cboEmpresa.Properties.View;
            view.Columns.Clear();

            view.Columns.AddVisible("descripcion", "Empresa");//.SetFixed(150);          

            // Ajustar solo las demás columnas
            view.BestFitColumns();

        }
        private DataTable GetTablaPeriodos()
        {
            HPResergerCapaLogica.Finanzas.Mutuos oCL = new HPResergerCapaLogica.Finanzas.Mutuos();
            DataTable dt = oCL.GetTablaPeriodos();
            return dt;
        }
        private DataTable GetTablaImpuestos()
        {
            HPResergerCapaLogica.Finanzas.Mutuos oCL = new HPResergerCapaLogica.Finanzas.Mutuos();
            DataTable dt = oCL.GetTablaImpuestos();
            return dt;
        }
        private DateTime CalcularFechaVencimiento(DateTime fechaIngreso, int periodo, int tipoPeriodo)
        {
            switch (tipoPeriodo)
            {
                case 1: // día(s)
                    return fechaIngreso.AddDays(periodo);

                case 2: // mes(es)
                    return fechaIngreso.AddMonths(periodo);

                case 3: // año(s)
                    return fechaIngreso.AddYears(periodo);

                case 4: // semestre(s) => 6 meses
                    return fechaIngreso.AddMonths(periodo * 6);

                default:
                    return DateTime.Now;
            }
        }

        private void CargarTipoContratos()
        {
            HPResergerCapaLogica.Compras.FacturaManual cClase = new HPResergerCapaLogica.Compras.FacturaManual();
            DataTable Tdata = cClase.GetCargarTipoContratos();
            TipoContratoSearchLookUpEdit.Properties.DataSource = Tdata;
            TipoContratoSearchLookUpEdit.Properties.DisplayMember = "nombre";
            TipoContratoSearchLookUpEdit.Properties.ValueMember = "idComprobante";

            TipoContratoSearchLookUpEdit.EditValue = Tdata.Rows.Count > 0 ? Tdata.Rows[0]["idComprobante"] : null;

            // Limpiar columnas
            var view = TipoContratoSearchLookUpEdit.Properties.View;
            view.Columns.Clear();

            var colNombre = view.Columns.AddVisible("nombre", "Nombre del Comprobante de Pago");

            // Ajustar solo las demás columnas
            view.BestFitColumns();
        }
        private void CargarEntidadFinanciera()
        {
            HPResergerCapaLogica.Finanzas.Mutuos oCL = new HPResergerCapaLogica.Finanzas.Mutuos();
            DataTable tData = oCL.ListadoEntidadesFinacieras();

            IdBancoMutuanteSearchLookUpEdit.Properties.DataSource = tData;
            IdBancoMutuanteSearchLookUpEdit.Properties.DisplayMember = "entidad";
            IdBancoMutuanteSearchLookUpEdit.Properties.ValueMember = "id";

            IdBancoMutuanteSearchLookUpEdit.EditValue = tData.Rows.Count > 0 ? tData.Rows[0]["id"] : null;

            // Limpiar columnas
            var view = IdBancoMutuanteSearchLookUpEdit.Properties.View;
            view.Columns.Clear();

            var col1 = view.Columns.AddVisible("sufijo", "Siglas");
            col1.MinWidth = 100; col1.MaxWidth = 80;

            view.Columns.AddVisible("entidad", "Entidad Financiera");

            // Ajustar solo las demás columnas
            view.BestFitColumns();

        }
        private void CargarTipodeInteres()
        {
            HPResergerCapaLogica.Compras.FacturaManual cClase = new HPResergerCapaLogica.Compras.FacturaManual();
            DataTable Tdata = cClase.GetTablaTipoInteres();

            TipoInteresLookUpEdit.Properties.DataSource = Tdata;
            TipoInteresLookUpEdit.Properties.DisplayMember = "Descripcion";
            TipoInteresLookUpEdit.Properties.ValueMember = "Id";

            TipoInteresLookUpEdit.EditValue = Tdata.Rows.Count > 0 ? Tdata.Rows[0]["Id"] : null;

        }
        private void CargarTipoComprobantesMutuos()
        {
            HPResergerCapaLogica.Compras.FacturaManual cClase = new HPResergerCapaLogica.Compras.FacturaManual();
            DataTable Tdata = cClase.GetTipoComprobantesMutuos();
            TipoComprobanteSearchLookUpEdit.Properties.DataSource = Tdata;
            TipoComprobanteSearchLookUpEdit.Properties.DisplayMember = "nombre";
            TipoComprobanteSearchLookUpEdit.Properties.ValueMember = "idComprobante";

            TipoComprobanteSearchLookUpEdit.EditValue = Tdata.Rows.Count > 0 ? Tdata.Rows[0]["idComprobante"] : null;

            //// Limpiar columnas
            //var view = TipoComprobanteSearchLookUpEdit.Properties.View;
            ////view.Columns.Clear();

            //var colNombre = view.Columns.AddVisible("nombre", "Nombre del Comprobante de Pago");

            //// Ajustar solo las demás columnas
            //view.BestFitColumns();
        }
        private void CargarMoneda()
        {
            HPResergerCapaLogica.Compras.FacturaManual cClase = new HPResergerCapaLogica.Compras.FacturaManual();

            DataTable tData = cClase.GetMoneda();
            MonedaTextEdit.Properties.DataSource = tData;
            MonedaTextEdit.Properties.DisplayMember = "moneda";
            MonedaTextEdit.Properties.ValueMember = "idMoneda";

            // Limpiar y configurar columnas manualmente
            MonedaTextEdit.Properties.Columns.Clear();

            // Agregar la columna "descripcion" y ocultar todas las demás
            foreach (DataColumn column in tData.Columns)
            {
                var lookupColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(column.ColumnName, column.ColumnName);
                lookupColumn.Visible = column.ColumnName == "moneda"; // Solo la columna "descripcion" será visible
                MonedaTextEdit.Properties.Columns.Add(lookupColumn);
            }

            // Personalizar el encabezado de la columna visible
            MonedaTextEdit.Properties.Columns["moneda"].Caption = "Moneda";

            // Seleccionar el primer registro si existen filas
            if (tData.Rows.Count > 0)
            {
                MonedaTextEdit.EditValue = tData.Rows[0]["idMoneda"]; // Asigna el primer valor de "codigo"
            }
            else
                MonedaTextEdit.Properties.DataSource = null;


            // Otras opciones de personalización
            MonedaTextEdit.Properties.ShowHeader = true; // Mostrar encabezado de columnas
            MonedaTextEdit.Properties.ShowFooter = false; // Ocultar pie de página
            MonedaTextEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup; // Ajustar ancho automático
        }
        private void CargarUsuariosActivos()
        {
            HPResergerCapaLogica.Mantenimiento.Empresa cClase = new HPResergerCapaLogica.Mantenimiento.Empresa();

            DataTable tData = cClase.GetUsuariosActivos();
            UsuarioCreadorTextEdit.Properties.DataSource = tData;
            UsuarioCreadorTextEdit.Properties.DisplayMember = "Usuario";
            UsuarioCreadorTextEdit.Properties.ValueMember = "Id";

            // Limpiar y configurar columnas manualmente
            UsuarioCreadorTextEdit.Properties.Columns.Clear();

            // Agregar la columna "descripcion" y ocultar todas las demás
            foreach (DataColumn column in tData.Columns)
            {
                var lookupColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(column.ColumnName, column.ColumnName);
                lookupColumn.Visible = column.ColumnName == "Usuario"; // Solo la columna "descripcion" será visible
                UsuarioCreadorTextEdit.Properties.Columns.Add(lookupColumn);
            }

            // Seleccionar el primer registro si existen filas
            if (tData.Rows.Count > 0)
            {
                UsuarioCreadorTextEdit.EditValue = HPReserger.frmLogin.CodigoUsuario;
            }
            else
                UsuarioCreadorTextEdit.Properties.DataSource = null;

            // Otras opciones de personalización
            UsuarioCreadorTextEdit.Properties.ShowHeader = true; // Mostrar encabezado de columnas
            UsuarioCreadorTextEdit.Properties.ShowFooter = false; // Ocultar pie de página
            UsuarioCreadorTextEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup; // Ajustar ancho automático
        }

        private void cboEmpresa_EditValueChanged(object sender, EventArgs e)
        {
            if (cboEmpresa.EditValue != null)
            {
                cargarProyectos((int)cboEmpresa.EditValue);
                cargarBancos((int)cboEmpresa.EditValue);
            }
        }

        private void cargarBancos(int idEmpresa)
        {
            HPResergerCapaLogica.Mantenimiento.Empresa cClase = new HPResergerCapaLogica.Mantenimiento.Empresa();
            DataTable Tdata = cClase.GetCuentasBancarias(idEmpresa);
            IdCtaBanco.Properties.DataSource = Tdata;
            IdCtaBanco.Properties.DisplayMember = "nombre";
            IdCtaBanco.Properties.ValueMember = "id";

            IdCtaBanco.EditValue = Tdata.Rows.Count > 0 ? Tdata.Rows[0]["Id"] : null;

            // Limpiar columnas
            var view = IdCtaBanco.Properties.View;
            view.Columns.Clear();

            var col = view.Columns.AddVisible("banco", "Entidad Bancaria");
            col.Width = 150;
            col.MinWidth = 150;
            col.MaxWidth = 150;
            col.OptionsColumn.FixedWidth = true;
            var col1 = view.Columns.AddVisible("nroCta", "Nro Cuenta Bancaria");
            col1.Width = 150;
            col1.MinWidth = 150;
            col1.MaxWidth = 150;
            col1.OptionsColumn.FixedWidth = true;
            view.Columns.AddVisible("cci", "Nro Cta CCI");

            // Ajustar solo las demás columnas
            view.BestFitColumns();
        }
        private void cargarProyectos(int idEmpresa)
        {
            DataTable tData = CapaLogica.ListarProyectosEmpresa(idEmpresa.ToString());
            cboProyecto.Properties.DataSource = tData;
            cboProyecto.Properties.DisplayMember = "Proyecto";
            cboProyecto.Properties.ValueMember = "Id_Proyecto";

            // Limpiar y configurar columnas manualmente
            cboProyecto.Properties.Columns.Clear();

            // Agregar la columna "descripcion" y ocultar todas las demás
            foreach (DataColumn column in tData.Columns)
            {
                var lookupColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(column.ColumnName, column.ColumnName);
                lookupColumn.Visible = column.ColumnName == "Proyecto"; // Solo la columna "descripcion" será visible
                cboProyecto.Properties.Columns.Add(lookupColumn);
            }

            // Personalizar el encabezado de la columna visible
            //cboProyecto.Properties.Columns["descripcion"].Caption = "Proyecto";

            // Seleccionar el primer registro si existen filas
            if (tData.Rows.Count > 0)
            {
                cboProyecto.EditValue = tData.Rows[0]["Id_Proyecto"]; // Asigna el primer valor de "codigo"
            }
            else
            {
                cboProyecto.Properties.DataSource = null;
                cboEtapa.Properties.DataSource = null;
            }

            // Otras opciones de personalización
            cboProyecto.Properties.ShowHeader = true; // Mostrar encabezado de columnas
            cboProyecto.Properties.ShowFooter = false; // Ocultar pie de página
            cboProyecto.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup; // Ajustar ancho automático
        }
        private void cargarEtapas(int idProyecto)
        {
            DataTable tData = CapaLogica.ListarEtapasProyecto(idProyecto.ToString());
            cboEtapa.Properties.DataSource = tData;
            cboEtapa.Properties.DisplayMember = "descripcion";
            cboEtapa.Properties.ValueMember = "Id_etapa";

            // Limpiar y configurar columnas manualmente
            cboEtapa.Properties.Columns.Clear();

            // Agregar la columna "descripcion" y ocultar todas las demás
            foreach (DataColumn column in tData.Columns)
            {
                var lookupColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(column.ColumnName, column.ColumnName);
                lookupColumn.Visible = column.ColumnName == "descripcion"; // Solo la columna "descripcion" será visible
                cboEtapa.Properties.Columns.Add(lookupColumn);
            }

            // Personalizar el encabezado de la columna visible
            cboEtapa.Properties.Columns["descripcion"].Caption = "Etapa";

            // Seleccionar el primer registro si existen filas
            if (tData.Rows.Count > 0)
            {
                cboEtapa.EditValue = tData.Rows[0]["Id_etapa"]; // Asigna el primer valor de "codigo"
            }
            else
                cboEtapa.Properties.DataSource = null;


            // Otras opciones de personalización
            cboEtapa.Properties.ShowHeader = true; // Mostrar encabezado de columnas
            cboEtapa.Properties.ShowFooter = false; // Ocultar pie de página
            cboEtapa.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup; // Ajustar ancho automático
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();

        private void cboProyecto_EditValueChanged(object sender, EventArgs e)
        {
            if (cboProyecto.EditValue != null)
                cargarEtapas((int)cboProyecto.EditValue);
        }

        private void CalcularFechaVencimiento()
        {
            DateTime fechaIngreso = (DateTime)(FechaIngresoDateEdit.EditValue ?? DateTime.Now);
            int periodo = Convert.ToInt32(PeriodoTextEdit.Text);
            int tipoPeriodo = Convert.ToInt32(TipoPeriodoLookUpEdit.EditValue);

            DateTime fechaVenc = CalcularFechaVencimiento(fechaIngreso, periodo, tipoPeriodo);

            FechaVencimientoDateEdit.EditValue = fechaVenc;
        }
        private void FechaIngresoDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            CalcularFechaVencimiento();

            if (FechaIngresoDateEdit.EditValue != null)
                SerieTextEdit.EditValue = ((DateTime)FechaIngresoDateEdit.EditValue).ToString("'M'yyyy");
        }

        private void TipoPeriodoLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            CalcularFechaVencimiento();
        }

        private void PeriodoTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            CalcularFechaVencimiento();

        }
        bool Guardado = false;
        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //when 0 then 'Anulado'
            //when 1 then 'Nuevo'
            //when 2 then 'Aprobado con asiento'
            //when 5 then 'Cancelado'
            Guardado = false;
            if (EstadoMutuo == 0)
            {
                XtraMessageBox.Show("Mutuo Anulado, no se puede Actualizar.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EstadoMutuo == 2)
            {
                XtraMessageBox.Show("Mutuo Generado Asiento, no se puede Actualizar.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EstadoMutuo == 5)
            {
                XtraMessageBox.Show("Mutuo Cancelado, no se puede Actualizar.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Avanza estado mutuo 1 que es un mutuo nuevo

            List<string> errores = new List<string>();

            // =====================
            // DATOS DE LA EMPRESA
            // =====================
            if (cboEmpresa.EditValue == null)
                errores.Add("• Debe seleccionar la Empresa.");

            if (cboProyecto.EditValue == null)
                errores.Add("• Debe seleccionar el Proyecto.");

            if (cboEtapa.EditValue == null)
                errores.Add("• Debe seleccionar la Etapa.");

            if (IdCtaBanco.EditValue == null)
                errores.Add("• Debe seleccionar la Cuenta Bancaria de la empresa.");

            // =====================
            // DATOS DEL MUTUANTE
            // =====================
            if (IdMutuanteSearchLookUpEdit.EditValue == null)
                errores.Add("• Debe seleccionar el Mutuante.");

            if (IdBancoMutuanteSearchLookUpEdit.EditValue == null)
                errores.Add("• Debe seleccionar el Banco del Mutuante.");

            if (NroCuentaMutuanteTextEdit.EditValue == null || string.IsNullOrWhiteSpace(NroCuentaMutuanteTextEdit.Text))
                errores.Add("• Debe ingresar el número de cuenta bancaria del Mutuante.");

            if (PeriodoTextEdit.EditValue == null)
            {
                errores.Add("• Debe ingresar el período del mutuo.");
            }
            else if (Convert.ToInt32(PeriodoTextEdit.EditValue) <= 0)
            {
                errores.Add("• El período del mutuo debe ser mayor que cero.");
            }

            if (TipoPeriodoLookUpEdit.EditValue == null)
                errores.Add("• Debe seleccionar el tipo de período.");

            // =====================
            // DATOS DEL COMPROBANTE
            // =====================
            if (FechaEmisionDateEdit.EditValue == null)
                errores.Add("• Debe ingresar la Fecha de Emisión.");

            if (FechaIngresoDateEdit.EditValue == null)
                errores.Add("• Debe ingresar la Fecha de Ingreso Contable.");

            if (TipoContratoSearchLookUpEdit.EditValue == null)
                errores.Add("• Debe seleccionar el tipo de contrato.");

            if (MonedaTextEdit.EditValue == null)
                errores.Add("• Debe seleccionar la moneda.");

            if (TipoInteresLookUpEdit.EditValue == null)
                errores.Add("• Debe seleccionar el tipo de interés.");

            if (MontoTextEdit.EditValue == null)
            {
                errores.Add("• Debe ingresar el monto del mutuo.");
            }
            else if (Convert.ToDecimal(MontoTextEdit.EditValue) <= 0)
            {
                errores.Add("• El monto del mutuo debe ser mayor que cero.");
            }

            //if (InteresTextEdit.EditValue == null)
            //    errores.Add("• Debe ingresar el interés.");

            if (TipoComprobanteSearchLookUpEdit.EditValue == null)
                errores.Add("• Debe seleccionar el tipo de comprobante.");

            if (ImpuestoSearchLookUpEdit.EditValue == null)
                errores.Add("• Debe seleccionar el tipo de impuesto.");

            // -----------------------------
            // MOSTRAR ERRORES
            // -----------------------------
            if (errores.Count > 0)
            {
                string mensaje = "Se encontraron los siguientes errores:\n\n" + string.Join("\n", errores);
                XtraMessageBox.Show(mensaje, "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // no guardar
            }

            int idUsuario = HPReserger.frmLogin.CodigoUsuario;

            HPResergerCapaLogica.Finanzas.Mutuos oclase = new HPResergerCapaLogica.Finanzas.Mutuos();
            HPResergerCapaLogica.Finanzas.Mutuos.MutuoEntidad oentidad = new HPResergerCapaLogica.Finanzas.Mutuos.MutuoEntidad();

            oentidad.CuentaContable = "";
            oentidad.Cuo = "";
            oentidad.Estado = 1;
            oentidad.FechaCreador = DateTime.Now;
            oentidad.FechaEmision = (DateTime)FechaEmisionDateEdit.EditValue;
            oentidad.FechaIngreso = (DateTime)FechaIngresoDateEdit.EditValue;
            oentidad.FechaModifica = DateTime.Now;
            oentidad.FechaVencimiento = (DateTime)FechaVencimientoDateEdit.EditValue;
            oentidad.Id = 0;
            oentidad.IdBancoMutuante = (int)IdBancoMutuanteSearchLookUpEdit.EditValue;
            oentidad.IdCtaBanco = (int)IdCtaBanco.EditValue;
            oentidad.IdEmpresa = (int)cboEmpresa.EditValue;
            oentidad.IdEtapa = (int)cboEtapa.EditValue;
            oentidad.IdMutuante = (int)IdMutuanteSearchLookUpEdit.EditValue;
            oentidad.IdProyecto = (int)cboProyecto.EditValue;
            oentidad.Impuesto = (int)ImpuestoSearchLookUpEdit.EditValue;
            oentidad.Interes = (decimal)InteresTextEdit.EditValue;
            oentidad.Moneda = (int)MonedaTextEdit.EditValue;
            oentidad.Monto = (decimal)MontoTextEdit.EditValue;
            oentidad.NroCciMutuante = NroCciMutuanteTextEdit.EditValue.ToString();
            oentidad.NroCuentaMutuante = NroCuentaMutuanteTextEdit.EditValue.ToString();
            oentidad.Numero = (int)(NumeroTextEdit.EditValue ?? 0);
            oentidad.Periodo = (int)PeriodoTextEdit.EditValue;
            oentidad.Serie = (SerieTextEdit.EditValue ?? "").ToString();
            oentidad.TipoComprobante = (int)TipoComprobanteSearchLookUpEdit.EditValue;
            oentidad.TipoContrato = (int)TipoContratoSearchLookUpEdit.EditValue;
            oentidad.TipoInteres = (int)TipoInteresLookUpEdit.EditValue;
            oentidad.TipoPeriodo = (int)TipoPeriodoLookUpEdit.EditValue;
            oentidad.UsuarioCreador = idUsuario;
            oentidad.UsuarioModifica = idUsuario;

            if (Estado == 1)
            {
                //CUANDO EL MUTUO ES NUEVO
                idMutuo = oclase.Insertar(oentidad);
                if (idMutuo == 0)
                {
                    XtraMessageBox.Show("Ocurrió un problema y el Mutuo no se pudo guardar.\n" +
                             "Por favor, intente nuevamente o verifique los datos ingresados.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    HPResergerCapaLogica.Contable.ClaseContable cClase = new HPResergerCapaLogica.Contable.ClaseContable();
                    var tComprobante = cClase.GetNumeroDocumentoMutuo(idMutuo);
                    NumeroTextEdit.EditValue = tComprobante.Rows[0]["numero"];
                    Guardado = true;
                    EstadoMutuo = 1;
                    Estado = 2;
                    XtraMessageBox.Show($"El Mutuo fue guardada correctamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGenerarAsiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    lblcuo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                }
            }
            else if (Estado == 2)
            {
                oentidad.Id = idMutuo;
                oentidad.CuentaContable = (CuentaContableSearchLookUpEdit.EditValue).ToString();
                oentidad.Cuo = cuo;
                oentidad.UsuarioModifica = idUsuario;
                oentidad.FechaModifica = DateTime.Now;

                //ACTUALIZAR
                int FilasAfectadas = oclase.Actualizar(oentidad);
                if (FilasAfectadas == 0)
                {
                    XtraMessageBox.Show("Ocurrió un problema y el Mutuo no se pudo guardar.\n" +
                             "Por favor, intente nuevamente o verifique los datos ingresados.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    EstadoMutuo = 1;
                    Estado = 2;
                    lblEstado.Caption = "Mutuo Guardado";
                    Guardado = true;
                    btnGenerarAsiento.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    lblcuo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    XtraMessageBox.Show($"El Mutuo fue Actualizado correctamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public DataTable GenerarCronograma()
        {
            decimal.TryParse(MontoTextEdit.EditValue?.ToString(), out decimal monto);
            decimal.TryParse(InteresTextEdit.EditValue?.ToString(), out decimal tasaInteresPorPeriodo);
            int.TryParse(PeriodoTextEdit.EditValue?.ToString(), out int numeroPeriodos);
            int.TryParse(TipoPeriodoLookUpEdit.EditValue?.ToString(), out int tipoPeriodo);
            int.TryParse(TipoInteresLookUpEdit.EditValue?.ToString(), out int tipoInteres);
            decimal.TryParse(ImpuestoSearchLookUpEdit.EditValue?.ToString(), out decimal tasaImpuesto);
            DateTime.TryParse(FechaIngresoDateEdit.EditValue?.ToString(), out DateTime fechaIngreso);

            return GenerarCronograma(monto, tasaInteresPorPeriodo, numeroPeriodos, tipoPeriodo, tasaImpuesto, fechaIngreso, tipoInteres);
        }

        private void btnCronograma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (EstadoMutuo == 1 || EstadoMutuo == 2)
            {
                //lo generamos
                //cagamos variables
                DataTable tCronogama = GenerarCronograma();

                // 👉 Mostrar en Form Dialog
                using (var frm = new FrmCronogramaMutuo())
                {
                    frm.CargarCronograma(tCronogama);
                    frm.ShowDialog(this);
                }
            }
            else
            {
                //traemos de la base de datos
                HPResergerCapaLogica.Finanzas.Mutuos oClase = new HPResergerCapaLogica.Finanzas.Mutuos();
                var tCronogama = oClase.GetCronogramaxIdMutuo(idMutuo);

                // 👉 Mostrar en Form Dialog
                using (var frm = new FrmCronogramaMutuo())
                {
                    frm.CargarCronograma(tCronogama);
                    frm.MostrarEstado = true;
                    frm.ShowDialog(this);
                }
            }
        }

        private void btnCondiciones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {



            //            string montoLetras = HPResergerFunciones.Utilitarios.NumeroALetras(monto);

            //            string tipoPeriodoTexto = tipoPeriodo;
            //            string texto = $@"
            //CONDICIONES DEL PRÉSTAMO

            //I.- MONTO DEL CRÉDITO:
            // {monto:N2} ({montoLetras} {moneda})

            //II.- DEL DESEMBOLSO:
            //El importe del préstamo se desembolsará mediante transferencia bancaria o depósito en cuenta a la cuenta de EL DEUDOR, descrita en el Anexo 2.

            //III.- PLAZO:
            //El plazo del Contrato es de {numeroPeriodos} {tipoPeriodoTexto}, y vence el {fechaVencimiento:dd/MM/yyyy}.
            //A su vencimiento, EL DEUDOR deberá haber cumplido con devolver a EL ACREEDOR el capital e intereses del Mutuo.

            //El plazo podrá ser prorrogado de común acuerdo por las Partes, para lo cual será necesario suscribir una adenda al presente contrato.

            //La devolución del Capital y los intereses del Mutuo se realizará a la cuenta de EL ACREEDOR descrita en el Anexo 2.
            //";

            //            richEditControl1.Text = texto;
            //            CargarAnexo2(nombreAcreedor, bancoAcreedor, cuentaAcreedor, monedaAcreedor, nombreDeudor, bancoDeudor, cuentaDeudor, monedaDeudor);
            //        }

            HPResergerCapaLogica.Finanzas.Mutuos oClase = new HPResergerCapaLogica.Finanzas.Mutuos();
            HPResergerCapaLogica.Contable.ClaseContable cClase = new HPResergerCapaLogica.Contable.ClaseContable();
            var tcliente = cClase.GetCliente((int)IdMutuanteSearchLookUpEdit.EditValue);
            var tEmpresa = cClase.GetEmpresa((int)cboEmpresa.EditValue);
            var tMoneda = cClase.GetMoneda((int)MonedaTextEdit.EditValue);
            string montoLetras = HPResergerFunciones.Utilitarios.NumeroALetras((decimal)MontoTextEdit.EditValue);
            string InteresLetras = HPResergerFunciones.Utilitarios.NumeroALetras(100 * (decimal)(InteresTextEdit.EditValue ?? 0m));

            string cuentabanco = IdCtaBanco.Text ?? " 0 - 0 - 0 ";
            var dato = cuentabanco.Split(new[] { '-' }, 3);
            string bancoDeudor = dato[0].Trim();
            string cuentaDeudor = dato[2].Trim();

            var contrato = new HPResergerCapaLogica.Finanzas.Mutuos.ContratoMutuoEntidad()
            {
                NombreMutuante = IdMutuanteSearchLookUpEdit.Text ?? "",
                DocumentoMutuante = tcliente.Rows[0]["numdoc"].ToString(),
                DireccionMutuante = tcliente.Rows[0]["Direccion"].ToString(),
                NroCuentaMutuante = NroCuentaMutuanteTextEdit.Text ?? "",
                NroCuentaCCIMutuante = NroCciMutuanteTextEdit.Text ?? "",

                NombreEmpresa = cboEmpresa.Text.ToString(),
                RucEmpresa = tEmpresa.Rows[0]["RUC"].ToString(),
                Distrito = tEmpresa.Rows[0]["Departamento"].ToString(),
                CuentaBancariaEmpresa = cuentaDeudor,
                DireccionEmpresa = tEmpresa.Rows[0]["Direccion"].ToString(),
                RepresentanteLegal = tEmpresa.Rows[0]["nombreEmpleado"].ToString(),
                DniRepresentante = tEmpresa.Rows[0]["NroID_Representado"].ToString(),
                PartidaRegistral = tEmpresa.Rows[0]["partidaRegistral"].ToString(),

                Moneda = tMoneda.Rows[0]["NameCorto"].ToString(),
                MontoMutuo = (decimal)MontoTextEdit.EditValue,
                ImporteLetras = montoLetras,

                Interes = 100 * ((decimal)(InteresTextEdit.EditValue ?? 0m)),
                Meses = TipoPeriodoLookUpEdit.Text ?? "",
                InteresLetras = InteresLetras,

                ImpuestoAnual = $"{100 * (decimal)InteresTextEdit.EditValue}% {TipoInteresLookUpEdit.Text ?? ""}",
                FechaEmision = ((DateTime)FechaEmisionDateEdit.EditValue).ToString("D"),
                FechaVencimiento = ((DateTime)FechaVencimientoDateEdit.EditValue).ToString("D"),
                DiaPago = ((DateTime)FechaVencimientoDateEdit.EditValue).Day,

                Cronograma = GenerarCronograma(),

                estadoCivil = tcliente.Rows[0]["estadoCivil"].ToString(),
                tipoDocumento = tcliente.Rows[0]["tipoDocumento"].ToString()
            };

            using (var frm = new FrmCondicionesPrestamo())
            {
                frm.CargarCondicionesEnRichText(contrato);
                frm.ShowDialog(this);
            }
        }


        private void MonedaTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (MonedaTextEdit.EditValue != null)
                CargarCuentaContable((int)MonedaTextEdit.EditValue);

        }

        private void CargarCuentaContable(int idmoneda)
        {
            var cClase = new HPResergerCapaLogica.Finanzas.Mutuos();
            DataTable Tdata = cClase.GetCuentaContableMutuo(idmoneda);
            CuentaContableSearchLookUpEdit.Properties.DataSource = Tdata;
            CuentaContableSearchLookUpEdit.Properties.DisplayMember = "cuentaContable";
            CuentaContableSearchLookUpEdit.Properties.ValueMember = "id";

            CuentaContableSearchLookUpEdit.EditValue = Tdata.Rows.Count > 0 ? Tdata.Rows[0]["id"] : null;

            //// Limpiar columnas
            ////var view = CuentaContableSearchLookUpEdit.Properties.View;
            //view.Columns.Clear();

            //var colNombre = view.Columns.AddVisible("nombre", "Nombre del Comprobante de Pago");

            //// Ajustar solo las demás columnas
            //view.BestFitColumns();
        }

        private void btnGenerarAsiento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnGuardar.PerformClick();
            if (EstadoMutuo != 3)
                if (!Guardado) return;
            //when 0 then 'Anulado'
            //when 1 then 'Nuevo'
            //when 2 then 'Aprobado con asiento'
            //when 5 then 'Cancelado'


            if (Estado == 1)
            {
                XtraMessageBox.Show("primero debe guardar el mutuo", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (EstadoMutuo == 5)
            {
                XtraMessageBox.Show("Mutuo Cancelado, no se puede generar asiento.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Avanza estado mutuo 1 que es un mutuo nuevo

            //Validacion de que el periodo NO sea muy disperso, sea un mes continuo a los trabajados
            int idEmpresa = (int)cboEmpresa.EditValue;
            DateTime fechaContable = (DateTime)FechaIngresoDateEdit.EditValue;

            List<string> errores = new List<string>();

            if (CuentaContableSearchLookUpEdit.EditValue == null)
                errores.Add("• Debe seleccionar una cuenta contable.");
            else if (CuentaContableSearchLookUpEdit.EditValue.ToString() == "")
                errores.Add("• Debe seleccionar una cuenta contable.");

            var cClaseContable = new HPResergerCapaLogica.Contable.ClaseContable();
            var TdataBancaria = cClaseContable.GetCuentaContabledelaCuentaBancaria((int)IdCtaBanco.EditValue);
            if (TdataBancaria.Rows.Count == 0)
            {
                errores.Add("• la cuenta bancaria no tiene una cuenta contable asignada");
            }


            if (!cClaseContable.PeriodoAbierto(idEmpresa, fechaContable))
            {
                errores.Add("• El Periodo Esta Cerrado, Cambie Fecha Contable");
            }

            // -----------------------------
            // MOSTRAR ERRORES
            // -----------------------------
            if (errores.Count > 0)
            {
                string mensaje = "Se encontraron los siguientes errores:\n\n" + string.Join("\n", errores);
                XtraMessageBox.Show(mensaje, "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // no guardar
            }

            int idUsuario = HPReserger.frmLogin.CodigoUsuario;
            int numasiento = 0;

            if (numasiento == 0)
            {
                DataTable asientito = CapaLogica.UltimoAsiento(idEmpresa, fechaContable);

                DataRow asiento = asientito.Rows[0];
                if (asiento == null) { numasiento = 1; }
                else
                    numasiento = (int)asiento["codigo"];
            }

            HPResergerCapaLogica.Contable.ClaseContable cClase = new HPResergerCapaLogica.Contable.ClaseContable();
            var Tdata = cClase.GetTipoCambioDia(fechaContable);
            var tComprobante = cClase.GetNumeroDocumentoMutuo(idMutuo);
            var tcliente = cClase.GetCliente((int)IdMutuanteSearchLookUpEdit.EditValue);
            string serieComprobante = tComprobante.Rows[0]["serie"].ToString();
            int NumComprobante = (int)tComprobante.Rows[0]["numero"];
            string cuentaContableBancaria = TdataBancaria.Rows[0]["cuenta"].ToString();
            string cuentaContableMutuo = CuentaContableSearchLookUpEdit.EditValue.ToString();
            decimal totalmutuo = (decimal)MontoTextEdit.EditValue;
            cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, fechaContable);
            int idEtapa = (int)cboEtapa.EditValue;
            int idProyecto = (int)cboProyecto.EditValue;
            int idMoneda = (int)MonedaTextEdit.EditValue;
            string glosa = $"Mutuo {MonedaTextEdit.Text} {MontoTextEdit.Text} {IdMutuanteSearchLookUpEdit.Text}";
            decimal tc = Tdata.Rows.Count > 0 ? (decimal)Tdata.Rows[0]["Venta"] : 3;

            HPResergerCapaLogica.Contable.ClaseContable.AsientoContableEntidad oEntidad = new HPResergerCapaLogica.Contable.ClaseContable.AsientoContableEntidad();
            HPResergerCapaLogica.Contable.ClaseContable.AsientoContableAuxEntidad oEntidadDetalle = new HPResergerCapaLogica.Contable.ClaseContable.AsientoContableAuxEntidad();
            //CABECERA
            oEntidad.CodAsientoContable = cuo;
            oEntidad.Estado = 1;
            oEntidad.FechaAsiento = fechaContable;
            oEntidad.FechaAsientoValor = fechaContable;
            oEntidad.FkIdEtapa = idEtapa;
            oEntidad.Glosa = glosa;
            oEntidad.IdAsientoContable = numasiento;
            oEntidad.IdDinamicaContable = -26;
            oEntidad.IdProyecto = idProyecto;
            oEntidad.Moneda = idMoneda;
            oEntidad.NroDocumento = "";
            oEntidad.SaldoHaber = totalmutuo;
            oEntidad.TC = tc;

            oEntidad.IdAsiento = 1;
            oEntidad.SaldoDebe = 0;
            oEntidad.CuentaContable = cuentaContableMutuo;

            decimal montosoles = idMoneda == 1 ? totalmutuo : totalmutuo * tc;
            decimal montodolares = idMoneda == 2 ? totalmutuo : totalmutuo / tc;

            //DETALLE
            oEntidadDetalle.CentroCosto = 0;
            oEntidadDetalle.CtaBanco = (int)IdCtaBanco.EditValue;
            oEntidadDetalle.CuentaContable = cuentaContableMutuo;
            oEntidadDetalle.Fecha = DateTime.Now;
            oEntidadDetalle.FechaAsiento = fechaContable;
            oEntidadDetalle.FechaEmision = (DateTime)FechaEmisionDateEdit.EditValue;
            oEntidadDetalle.FechaRecepcion = (DateTime)FechaIngresoDateEdit.EditValue;
            oEntidadDetalle.FechaVencimiento = (DateTime)FechaVencimientoDateEdit.EditValue;
            oEntidadDetalle.FkAsi = "";
            oEntidadDetalle.FkMoneda = idMoneda;
            oEntidadDetalle.FkProyecto = idProyecto;
            oEntidadDetalle.Glosa = glosa;
            oEntidadDetalle.IdAsientoContable = numasiento;
            oEntidadDetalle.IdAux = 1;
            oEntidadDetalle.IdComprobante = 0;
            oEntidadDetalle.ImporteME = montodolares;
            oEntidadDetalle.ImporteMN = montosoles;
            oEntidadDetalle.NroOPBanco = "";
            oEntidadDetalle.CodComprobante = serieComprobante;
            oEntidadDetalle.NumComprobante = NumComprobante.ToString();
            oEntidadDetalle.NumDoc = tcliente.Rows[0]["numdoc"].ToString();
            oEntidadDetalle.RazonSocial = tcliente.Rows[0]["nombre"].ToString();
            oEntidadDetalle.TipoCambio = tc;
            oEntidadDetalle.TipoDoc = (int)tcliente.Rows[0]["tipoid"];
            oEntidadDetalle.TipoPago = 1;
            oEntidadDetalle.Usuario = idUsuario;

            HPResergerCapaLogica.Finanzas.Mutuos oMutuo = new HPResergerCapaLogica.Finanzas.Mutuos();
            DataTable tCuentaDebe = oMutuo.GetCuentaContableMutuo37InteresMutuo(idMoneda);
            DataTable tcuentaHaber = oMutuo.GetCuentaContableMutuo46InteresMutuo(idMoneda);

            //ASIENTO DE PROVISION
            string Cuenta37MutuoInteresDebe = tCuentaDebe.Rows.Count == 0 ? "3734101" : tCuentaDebe.Rows[0]["id"].ToString();
            string Cuenta46MutuoInteresHaber = tcuentaHaber.Rows.Count == 0 ? "4699119" : tcuentaHaber.Rows[0]["id"].ToString();

            var dialog = XtraMessageBox.Show("Esta seguro que desea generar el asiento", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                if (txtcuo.EditValue.ToString() == "")// UN ASIENTO NUEVO
                {
                    DataTable TCronograma = GenerarCronograma();
                    HPResergerCapaLogica.Finanzas.Mutuos.MutuoCronogramaEntidad oCronograma = new HPResergerCapaLogica.Finanzas.Mutuos.MutuoCronogramaEntidad();
                    HPResergerCapaLogica.Finanzas.Mutuos.MutuoPagoEntidad oCronoPagos = new HPResergerCapaLogica.Finanzas.Mutuos.MutuoPagoEntidad();
                    //PRIMERA GRABACION DEL CRONOGRAMA
                    foreach (DataRow item in TCronograma.Rows)
                    {
                        oCronograma.IdMutuo = idMutuo;
                        oCronograma.Amortizacion = (decimal)item["Amortizacion"];
                        oCronograma.Cuota = (decimal)item["Cuota"];
                        oCronograma.Fecha = (DateTime)item["Fecha"];
                        oCronograma.Impuesto = (decimal)item["Impuesto"];
                        oCronograma.Interes = (decimal)item["Interes"];
                        oCronograma.Nro = (int)item["Nro"];
                        oCronograma.Principal = (decimal)item["Principal"];
                        oCronograma.Transferencia = (decimal)item["Transferencia"];
                        var id = oMutuo.Insertar(oCronograma);

                        oCronoPagos.CuentaContable = "";
                        oCronoPagos.CUO = "";
                        oCronoPagos.EstadoPago = 0;
                        //oCronoPagos.FechaPago = DateTime.nu
                        oCronoPagos.FechaProgramada = oCronograma.Fecha;
                        oCronoPagos.FechaRegistro = DateTime.Now;
                        oCronoPagos.Id = 0;
                        oCronoPagos.IdCronograma = id;
                        oCronoPagos.IdMutuo = idMutuo;
                        oCronoPagos.MontoImpuesto = oCronograma.Impuesto;
                        oCronoPagos.MontoInteres = oCronograma.Interes;
                        oCronoPagos.MontoPagado = oCronograma.Transferencia;
                        oCronoPagos.MontoPrincipal = oCronograma.Cuota;

                        oCronoPagos.CuentaContableDebe = Cuenta37MutuoInteresDebe;
                        oCronoPagos.CuentaContableHaber = Cuenta46MutuoInteresHaber;

                        oMutuo.InsertarPago(oCronoPagos);
                    }
                    oMutuo.CambiarEstadoAsiento(idMutuo);
                    EstadoMutuo = 3;
                    Estado = 3;

                    //INSERTAMOS LA NUEVA CABECERA DEL DEBE
                    //Debe
                    cClase.InsertarAsiento(oEntidad);
                    //detalle debe
                    cClase.InsertarAux(oEntidadDetalle);

                    //haber
                    oEntidad.SaldoDebe = totalmutuo;
                    oEntidad.SaldoHaber = 0;
                    oEntidad.IdAsiento = 2;
                    oEntidad.CuentaContable = cuentaContableBancaria;
                    cClase.InsertarAsiento(oEntidad);

                    oEntidadDetalle.IdAux = 2;
                    oEntidadDetalle.CuentaContable = cuentaContableBancaria;
                    cClase.InsertarAux(oEntidadDetalle);

                    //ACTUALIZAMOS EL CUO DEL MUTUO
                    txtcuo.EditValue = cuo;
                    oMutuo.ActualizarCuoMutuo(idMutuo, cuo, cuentaContableMutuo);


                    //CARGO VARIABLES
                    numasiento = 0;
                    if (numasiento == 0)
                    {
                        DataTable asientito = CapaLogica.UltimoAsiento(idEmpresa, fechaContable);
                        DataRow asiento = asientito.Rows[0];
                        if (asiento == null) { numasiento = 1; }
                        else
                            numasiento = (int)asiento["codigo"];
                    }

                    //ARMANDO CABECERA
                    string cuoDetalle = HPResergerFunciones.Utilitarios.Cuo(numasiento, fechaContable);
                    int periodos = (int)PeriodoTextEdit.EditValue;
                    Decimal totalInteres = periodos * (decimal)TCronograma.Rows[1]["Interes"];

                    oEntidad.CodAsientoContable = cuoDetalle;
                    oEntidad.Estado = 1;
                    oEntidad.FechaAsiento = fechaContable;
                    oEntidad.FechaAsientoValor = fechaContable;
                    oEntidad.FkIdEtapa = idEtapa;
                    oEntidad.Glosa = glosa;
                    oEntidad.IdAsientoContable = numasiento;
                    oEntidad.IdDinamicaContable = -28;
                    oEntidad.IdProyecto = idProyecto;
                    oEntidad.Moneda = idMoneda;
                    oEntidad.NroDocumento = "";
                    oEntidad.SaldoHaber = 0;
                    oEntidad.TC = tc;

                    oEntidad.IdAsiento = 1;
                    oEntidad.SaldoDebe = totalInteres;
                    oEntidad.CuentaContable = Cuenta37MutuoInteresDebe;

                    //DEBE
                    cClase.InsertarAsiento(oEntidad);
                    //HABER 
                    oEntidad.SaldoDebe = 0;
                    oEntidad.SaldoHaber = totalInteres;
                    oEntidad.IdAsiento = 2;
                    oEntidad.CuentaContable = Cuenta46MutuoInteresHaber;
                    cClase.InsertarAsiento(oEntidad);

                    foreach (DataRow item in TCronograma.Rows)
                    {
                        if ((int)item["Nro"] != 0)
                        {
                            decimal valor = (decimal)item["Interes"];
                            montosoles = idMoneda == 1 ? valor : valor * tc;
                            montodolares = idMoneda == 2 ? valor : valor / tc;
                            glosa = $"Cod.Mutuo Cuota {(int)item["Nro"]}/{periodos}";
                            //DETALLE
                            oEntidadDetalle.CentroCosto = 0;
                            oEntidadDetalle.CtaBanco = 0;// (int)IdCtaBanco.EditValue;
                            oEntidadDetalle.CuentaContable = Cuenta37MutuoInteresDebe;
                            oEntidadDetalle.Fecha = DateTime.Now;
                            oEntidadDetalle.FechaAsiento = fechaContable;
                            oEntidadDetalle.FechaEmision = (DateTime)FechaEmisionDateEdit.EditValue;
                            oEntidadDetalle.FechaRecepcion = (DateTime)FechaIngresoDateEdit.EditValue;
                            oEntidadDetalle.FechaVencimiento = (DateTime)item["Fecha"];
                            oEntidadDetalle.FkAsi = cuo;
                            oEntidadDetalle.FkMoneda = idMoneda;
                            oEntidadDetalle.FkProyecto = idProyecto;
                            oEntidadDetalle.Glosa = glosa;
                            oEntidadDetalle.IdAsientoContable = numasiento;
                            oEntidadDetalle.IdAux = 1;
                            oEntidadDetalle.IdComprobante = 0;
                            oEntidadDetalle.ImporteME = montodolares;
                            oEntidadDetalle.ImporteMN = montosoles;
                            oEntidadDetalle.NroOPBanco = "";
                            oEntidadDetalle.CodComprobante = serieComprobante;
                            oEntidadDetalle.NumComprobante = NumComprobante.ToString();
                            oEntidadDetalle.NumDoc = tcliente.Rows[0]["numdoc"].ToString();
                            oEntidadDetalle.RazonSocial = tcliente.Rows[0]["nombre"].ToString();
                            oEntidadDetalle.TipoCambio = tc;
                            oEntidadDetalle.TipoDoc = (int)tcliente.Rows[0]["tipoid"];
                            oEntidadDetalle.TipoPago = 1;
                            oEntidadDetalle.Usuario = idUsuario;
                            cClase.InsertarAux(oEntidadDetalle);

                            oEntidadDetalle.IdAux = 2;
                            oEntidadDetalle.CuentaContable = Cuenta46MutuoInteresHaber;
                            cClase.InsertarAux(oEntidadDetalle);
                        }
                    }

                    XtraMessageBox.Show($"El Mutuo fue generado su asiento {cuo}.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else // asiento actualizando
                {
                    //ELIMINAMOS CABECERA Y DETALLE
                    cuo = txtcuo.EditValue.ToString();
                    CapaLogica.EliminarAsiento(cuo, idEmpresa, fechaContable, 0);
                    //HPResergerCapaLogica.Finanzas.Mutuos oMutuo = new HPResergerCapaLogica.Finanzas.Mutuos();
                    var datoCuo = cuo.Split('-');
                    var numAsiento = int.Parse(datoCuo[1].ToString());

                    oEntidad.CodAsientoContable = cuo;
                    oEntidad.IdAsientoContable = numAsiento;
                    oEntidadDetalle.IdAsientoContable = numAsiento;

                    //INSERTAMOS LA NUEVA CABECERA DEL DEBE
                    //Debe
                    oEntidad.SaldoDebe = 0;
                    oEntidad.SaldoHaber = totalmutuo;
                    oEntidad.IdAsiento = 1;
                    oEntidad.CuentaContable = cuentaContableMutuo;
                    cClase.InsertarAsiento(oEntidad);
                    //detalle debe
                    oEntidadDetalle.IdAux = 1;
                    oEntidadDetalle.CuentaContable = cuentaContableMutuo;
                    cClase.InsertarAux(oEntidadDetalle);

                    //haber
                    oEntidad.SaldoDebe = totalmutuo;
                    oEntidad.SaldoHaber = 0;
                    oEntidad.IdAsiento = 2;
                    oEntidad.CuentaContable = cuentaContableBancaria;
                    cClase.InsertarAsiento(oEntidad);

                    oEntidadDetalle.IdAux = 2;
                    oEntidadDetalle.CuentaContable = cuentaContableBancaria;
                    cClase.InsertarAux(oEntidadDetalle);

                    //ACTUALIZAMOS EL CUO DEL MUTUO
                    txtcuo.EditValue = cuo;
                    oMutuo.ActualizarCuoMutuo(idMutuo, cuo, cuentaContableMutuo);
                    XtraMessageBox.Show($"El Mutuo fue Actualizado con asiento {cuo}.", "Actualización Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                XtraMessageBox.Show("Cancelado por el usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}