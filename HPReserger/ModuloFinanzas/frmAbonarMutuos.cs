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

namespace SISGEM.ModuloFinanzas
{
    public partial class frmAbonarMutuos : DevExpress.XtraEditors.XtraForm
    {
        public frmAbonarMutuos()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmAbonarMutuos_Load(object sender, EventArgs e)
        {
            dtpFechaContable.EditValue = DateTime.Now;

            CargarEmpresas();
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();

            // Mostrar solo Mes y Año en el campo
            dtpfecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtpfecha.Properties.DisplayFormat.FormatString = "MMMM yyyy";  // Ej: "Mayo 2025"

            dtpfecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtpfecha.Properties.EditFormat.FormatString = "MMMM yyyy";

            dtpfecha.Properties.Mask.EditMask = "MMMM yyyy";
            dtpfecha.Properties.Mask.UseMaskAsDisplayFormat = true;

            // Cambiar el tipo de vista del calendario a Vista de Meses (evita días)
            dtpfecha.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;

            // Esto permite que el usuario solo elija el mes (de la vista anual)
            dtpfecha.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            dtpfecha.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;

            dtpfecha.EditValue = DateTime.Now;
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
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
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

        private void cboProyecto_EditValueChanged(object sender, EventArgs e)
        {
            if (cboProyecto.EditValue != null)
                cargarEtapas((int)cboProyecto.EditValue);
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            CalcularTotalesSeleccionados();
        }

        private void CalcularTotalesSeleccionados()
        {
            decimal totalPrincipal = 0;
            decimal totalAmortizacion = 0;
            decimal totalInteres = 0;
            decimal totalCuota = 0;
            decimal totalImpuesto = 0;
            decimal totalTransferencia = 0;

            foreach (int rowHandle in gridView1.GetSelectedRows())
            {
                if (rowHandle >= 0)
                {
                    totalPrincipal += Convert.ToDecimal(gridView1.GetRowCellValue(rowHandle, "Principal"));
                    totalAmortizacion += Convert.ToDecimal(gridView1.GetRowCellValue(rowHandle, "Amortizacion"));
                    totalInteres += Convert.ToDecimal(gridView1.GetRowCellValue(rowHandle, "Interes"));
                    totalCuota += Convert.ToDecimal(gridView1.GetRowCellValue(rowHandle, "Cuota"));
                    totalImpuesto += Convert.ToDecimal(gridView1.GetRowCellValue(rowHandle, "Impuesto"));
                    totalTransferencia += Convert.ToDecimal(gridView1.GetRowCellValue(rowHandle, "Transferencia"));
                }
            }

            txtPrincipal.EditValue = totalPrincipal;
            txtAmortizacion.EditValue = totalAmortizacion;
            txtInteres.EditValue = totalInteres;
            txtCuota.EditValue = totalCuota;
            txtImpuesto.EditValue = totalImpuesto;
            txtTransferencia.EditValue = totalTransferencia;
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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

            var cClaseContable = new HPResergerCapaLogica.Contable.ClaseContable();
            var TdataBancaria = cClaseContable.GetCuentaContabledelaCuentaBancaria((int)IdCtaBanco.EditValue);
            if (TdataBancaria.Rows.Count == 0)
            {
                errores.Add("• la cuenta bancaria no tiene una cuenta contable asignada");
            }

            if (gridView1.SelectedRowsCount == 0)
                errores.Add("• Debe Seleccionar una Cuota. ");

            int idEmpresa = (int)cboEmpresa.EditValue;
            DateTime fechaContable = (DateTime)dtpFechaContable.EditValue;
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

            var dialogResult = XtraMessageBox.Show("Esta seguro Generar Asiento Contable", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                HPResergerCapaLogica.Finanzas.Mutuos CMutuo = new HPResergerCapaLogica.Finanzas.Mutuos();
                int idUsuario = HPReserger.frmLogin.CodigoUsuario;

                int[] selectedRowHandles = gridView1.GetSelectedRows();
                string cuoPago = "";

                HashSet<string> cuentasContables = new HashSet<string>();
                HashSet<string> cuentasHaber = new HashSet<string>();
                HashSet<string> cuentasDebe = new HashSet<string>();
                HashSet<string> cuentasImpuesto = new HashSet<string>();

                foreach (int rowHandle in selectedRowHandles)
                {
                    if (rowHandle < 0) continue;
                    DataRowView row = gridView1.GetRow(rowHandle) as DataRowView;
                    if (row == null) continue;

                    try
                    {
                        string cuentaContable = row["cuentaContable"]?.ToString();
                        string cuentaHaber = row["CuentaContableHaber"]?.ToString();
                        string cuentaDebe = row["CuentaContableDebe"]?.ToString();
                        string cuentaImpuesto = row["cuentaImpuesto"]?.ToString();

                        if (!string.IsNullOrWhiteSpace(cuentaContable))
                            cuentasContables.Add(cuentaContable);

                        if (!string.IsNullOrWhiteSpace(cuentaHaber))
                            cuentasHaber.Add(cuentaHaber);

                        if (!string.IsNullOrWhiteSpace(cuentaDebe))
                            cuentasDebe.Add(cuentaDebe);

                        if (!string.IsNullOrWhiteSpace(cuentaImpuesto))
                            cuentasImpuesto.Add(cuentaImpuesto);
                    }
                    catch { }
                }

                //ASIENTO DE PAGO
                //CARGO VARIABLES         
                int numasiento = 0;
                if (numasiento == 0)
                {
                    DataTable asientito = CapaLogica.UltimoAsiento(idEmpresa, fechaContable);
                    DataRow asiento = asientito.Rows[0];
                    if (asiento == null) { numasiento = 1; }
                    else
                        numasiento = (int)asiento["codigo"];
                }

                string glosaCabecera = $"Pago de Mutuos {fechaContable.ToString("dd-MM-yyyy")}";
                int contadorFilas = 0;
                foreach (int rowHandle in selectedRowHandles)
                {
                    if (rowHandle < 0)
                        continue;
                    DataRowView selectedDataRow = gridView1.GetRow(rowHandle) as DataRowView;
                    if (selectedDataRow == null)
                        continue;
                    try
                    {
                        // Datos originales de la fila seleccionada
                        int idPago = Convert.ToInt32(selectedDataRow["IdPago"]);
                        int idMutuo = Convert.ToInt32(selectedDataRow["idMutuo"]);
                        int idMutuante = Convert.ToInt32(selectedDataRow["idMutuante"]);
                        int idMoneda = Convert.ToInt32(selectedDataRow["moneda"]);
                        int Nro = Convert.ToInt32(selectedDataRow["Nro"]);
                        int periodos = Convert.ToInt32(selectedDataRow["periodo"]);
                        DateTime FechaEmision = Convert.ToDateTime(selectedDataRow["fechaEmision"]);
                        DateTime FechaVencimiento = Convert.ToDateTime(selectedDataRow["Fecha"]);

                        string cuentaContable = selectedDataRow["cuentaContable"].ToString();
                        decimal Transferencia = Convert.ToDecimal(selectedDataRow["Transferencia"].ToString());
                        string Nmoneda = selectedDataRow["Nmoneda"].ToString();

                        //ARMANDO CABECERA
                        cuoPago = HPResergerFunciones.Utilitarios.Cuo(numasiento, fechaContable);

                        HPResergerCapaLogica.Contable.ClaseContable cClase = new HPResergerCapaLogica.Contable.ClaseContable();
                        var Tdata = cClase.GetTipoCambioDia(fechaContable);
                        var tComprobante = cClase.GetNumeroDocumentoMutuo(idMutuo);
                        var tcliente = cClase.GetCliente(idMutuante);
                        string serieComprobante = tComprobante.Rows[0]["serie"].ToString();
                        int NumComprobante = (int)tComprobante.Rows[0]["numero"];
                        string cuentaContableBancaria = TdataBancaria.Rows[0]["cuenta"].ToString();
                        string cuentaContableMutuo = cuentaContable;
                        decimal totalmutuo = Transferencia;
                        int idEtapa = (int)cboEtapa.EditValue;
                        int idProyecto = (int)cboProyecto.EditValue;
                        string glosa = $"Cod.Mutuo Cuota {Nro}/{periodos}";
                        decimal tc = Tdata.Rows.Count > 0 ? (decimal)Tdata.Rows[0]["Venta"] : 3;

                        HPResergerCapaLogica.Contable.ClaseContable.AsientoContableEntidad oEntidad = new HPResergerCapaLogica.Contable.ClaseContable.AsientoContableEntidad();
                        HPResergerCapaLogica.Contable.ClaseContable.AsientoContableAuxEntidad oEntidadDetalle = new HPResergerCapaLogica.Contable.ClaseContable.AsientoContableAuxEntidad();
                        //CABECERA
                        oEntidad.CodAsientoContable = cuoPago;
                        oEntidad.Estado = 1;
                        oEntidad.FechaAsiento = fechaContable;
                        oEntidad.FechaAsientoValor = fechaContable;
                        oEntidad.FkIdEtapa = idEtapa;
                        oEntidad.Glosa = glosaCabecera;
                        oEntidad.IdAsientoContable = numasiento;
                        oEntidad.IdDinamicaContable = -37;
                        oEntidad.IdProyecto = idProyecto;
                        oEntidad.Moneda = idMoneda;
                        oEntidad.NroDocumento = "";
                        oEntidad.SaldoHaber = 0;
                        oEntidad.TC = tc;

                        oEntidad.IdAsiento = ++contadorFilas;
                        oEntidad.SaldoDebe = totalmutuo;
                        oEntidad.CuentaContable = cuentaContableMutuo;

                        decimal montosoles = idMoneda == 1 ? totalmutuo : totalmutuo * tc;
                        decimal montodolares = idMoneda == 2 ? totalmutuo : totalmutuo / tc;

                        //DETALLE
                        oEntidadDetalle.CentroCosto = 0;
                        oEntidadDetalle.CtaBanco = (int)IdCtaBanco.EditValue;
                        oEntidadDetalle.CuentaContable = cuentaContableMutuo;
                        oEntidadDetalle.Fecha = DateTime.Now;
                        oEntidadDetalle.FechaAsiento = fechaContable;
                        oEntidadDetalle.FechaEmision = FechaEmision;
                        oEntidadDetalle.FechaRecepcion = fechaContable;
                        oEntidadDetalle.FechaVencimiento = FechaVencimiento;
                        oEntidadDetalle.FkAsi = "";
                        oEntidadDetalle.FkMoneda = idMoneda;
                        oEntidadDetalle.FkProyecto = idProyecto;
                        oEntidadDetalle.Glosa = glosa;
                        oEntidadDetalle.IdAsientoContable = numasiento;
                        oEntidadDetalle.IdAux = contadorFilas;
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

                        //INSERTAMOS LA CABECERA Y DETALLE DEL DEBE
                        //Debe
                        cClase.InsertarAsiento(oEntidad);
                        //detalle debe
                        cClase.InsertarAux(oEntidadDetalle);

                        //INSERTAMOS LA CABECERA Y DETALLE DEL HABER
                        //haber
                        oEntidad.SaldoDebe = 0;
                        oEntidad.SaldoHaber = totalmutuo;
                        oEntidad.IdAsiento = ++contadorFilas;
                        oEntidad.CuentaContable = cuentaContableBancaria;
                        cClase.InsertarAsiento(oEntidad);

                        oEntidadDetalle.IdAux = contadorFilas;
                        oEntidadDetalle.CuentaContable = cuentaContableBancaria;
                        cClase.InsertarAux(oEntidadDetalle);

                        CMutuo.MarcarComoPagado(idPago, fechaContable, cuentaContable, cuoPago, idUsuario);

                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show($"Error al procesar la fila {rowHandle}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }

                //PROVISION DE FACTURA
                  glosaCabecera = $"Provision de Mutuos {fechaContable.ToString("dd-MM-yyyy")}";

                numasiento = 0;
                if (numasiento == 0)
                {
                    DataTable asientito = CapaLogica.UltimoAsiento(idEmpresa, fechaContable);
                    DataRow asiento = asientito.Rows[0];
                    if (asiento == null) { numasiento = 1; }
                    else
                        numasiento = (int)asiento["codigo"];
                }
                contadorFilas = 0;
                string cuoProvision = "";

                foreach (int rowHandle in selectedRowHandles)
                {
                    if (rowHandle < 0)
                        continue;
                    DataRowView selectedDataRow = gridView1.GetRow(rowHandle) as DataRowView;
                    if (selectedDataRow == null)
                        continue;
                    try
                    {
                        // Datos originales de la fila seleccionada
                        int idPago = Convert.ToInt32(selectedDataRow["IdPago"]);
                        int idMutuo = Convert.ToInt32(selectedDataRow["idMutuo"]);
                        int idMutuante = Convert.ToInt32(selectedDataRow["idMutuante"]);
                        int idMoneda = Convert.ToInt32(selectedDataRow["moneda"]);
                        int Nro = Convert.ToInt32(selectedDataRow["Nro"]);
                        int periodos = Convert.ToInt32(selectedDataRow["periodo"]);
                        DateTime FechaEmision = Convert.ToDateTime(selectedDataRow["fechaEmision"]);
                        DateTime FechaVencimiento = Convert.ToDateTime(selectedDataRow["Fecha"]);

                        string cuentaContable = selectedDataRow["cuentaContable"].ToString();
                        string cuentaImpuestos = selectedDataRow["cuentaImpuesto"].ToString();
                        string cuentaGastos = selectedDataRow["cuentaGasto"].ToString();
                        decimal Transferencia = Convert.ToDecimal(selectedDataRow["Transferencia"].ToString());
                        decimal totalImpuestos = Convert.ToDecimal(selectedDataRow["Impuesto"].ToString());
                        decimal totalGasto = Convert.ToDecimal(selectedDataRow["Cuota"].ToString());
                        string Nmoneda = selectedDataRow["Nmoneda"].ToString();

                        //ARMANDO CABECERA
                        cuoProvision = HPResergerFunciones.Utilitarios.Cuo(numasiento, fechaContable);

                        HPResergerCapaLogica.Contable.ClaseContable cClase = new HPResergerCapaLogica.Contable.ClaseContable();
                        var Tdata = cClase.GetTipoCambioDia(fechaContable);
                        var tComprobante = cClase.GetNumeroDocumentoMutuo(idMutuo);
                        var tcliente = cClase.GetCliente(idMutuante);
                        string serieComprobante = tComprobante.Rows[0]["serie"].ToString();
                        int NumComprobante = (int)tComprobante.Rows[0]["numero"];
                        //string cuentaContableBancaria = TdataBancaria.Rows[0]["cuenta"].ToString();
                        string cuentaContableMutuo = cuentaContable;
                        decimal totalmutuo = Transferencia;
                        int idEtapa = (int)cboEtapa.EditValue;
                        int idProyecto = (int)cboProyecto.EditValue;

                        string glosaDetatalle = $"Cod.Mutuo Cuota {Nro}/{periodos}";
                        decimal tc = Tdata.Rows.Count > 0 ? (decimal)Tdata.Rows[0]["Venta"] : 3;

                        HPResergerCapaLogica.Contable.ClaseContable.AsientoContableEntidad oEntidad = new HPResergerCapaLogica.Contable.ClaseContable.AsientoContableEntidad();
                        HPResergerCapaLogica.Contable.ClaseContable.AsientoContableAuxEntidad oEntidadDetalle = new HPResergerCapaLogica.Contable.ClaseContable.AsientoContableAuxEntidad();
                        //CABECERA
                        oEntidad.CodAsientoContable = cuoProvision;
                        oEntidad.Estado = 1;
                        oEntidad.FechaAsiento = fechaContable;
                        oEntidad.FechaAsientoValor = fechaContable;
                        oEntidad.FkIdEtapa = idEtapa;
                        oEntidad.Glosa = glosaCabecera;
                        oEntidad.IdAsientoContable = numasiento;
                        oEntidad.IdDinamicaContable = -38;
                        oEntidad.IdProyecto = idProyecto;
                        oEntidad.Moneda = idMoneda;
                        oEntidad.NroDocumento = "";
                        oEntidad.SaldoHaber = totalmutuo;
                        oEntidad.TC = tc;

                        oEntidad.IdAsiento = ++contadorFilas;
                        oEntidad.SaldoDebe = 0;
                        oEntidad.CuentaContable = cuentaContableMutuo;

                        decimal montosoles = idMoneda == 1 ? totalmutuo : totalmutuo * tc;
                        decimal montodolares = idMoneda == 2 ? totalmutuo : totalmutuo / tc;

                        decimal montosolesImpuestos = idMoneda == 1 ? totalImpuestos : totalImpuestos * tc;
                        decimal montodolaresImpuestos = idMoneda == 2 ? totalImpuestos : totalImpuestos / tc;

                        decimal montosolesGastos = idMoneda == 1 ? totalGasto : totalGasto * tc;
                        decimal montodolaresGastos = idMoneda == 2 ? totalGasto : totalGasto / tc;

                        //DETALLE
                        oEntidadDetalle.CentroCosto = 0;
                        oEntidadDetalle.CtaBanco = (int)IdCtaBanco.EditValue;
                        oEntidadDetalle.CuentaContable = cuentaContableMutuo;
                        oEntidadDetalle.Fecha = DateTime.Now;
                        oEntidadDetalle.FechaAsiento = fechaContable;
                        oEntidadDetalle.FechaEmision = FechaEmision;
                        oEntidadDetalle.FechaRecepcion = fechaContable;
                        oEntidadDetalle.FechaVencimiento = FechaVencimiento;
                        oEntidadDetalle.FkAsi = cuoPago;
                        oEntidadDetalle.FkMoneda = idMoneda;
                        oEntidadDetalle.FkProyecto = idProyecto;
                        oEntidadDetalle.Glosa = glosaDetatalle;
                        oEntidadDetalle.IdAsientoContable = numasiento;
                        oEntidadDetalle.IdAux = contadorFilas;
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

                        //INSERTAMOS LA CABECERA Y DETALLE DEL haber
                        //haber
                        cClase.InsertarAsiento(oEntidad);
                        //detalle haber
                        cClase.InsertarAux(oEntidadDetalle);

                        //INSERTAMOS LA CABECERA Y DETALLE DEL HABER
                        //haber
                        oEntidad.SaldoDebe = 0;
                        oEntidad.SaldoHaber = totalImpuestos;
                        oEntidad.IdAsiento = ++contadorFilas;
                        oEntidad.CuentaContable = cuentaImpuestos;
                        cClase.InsertarAsiento(oEntidad);

                        oEntidadDetalle.IdAux = contadorFilas;
                        oEntidadDetalle.ImporteMN = montosolesImpuestos;
                        oEntidadDetalle.ImporteME = montodolaresImpuestos;
                        oEntidadDetalle.CuentaContable = cuentaImpuestos;
                        cClase.InsertarAux(oEntidadDetalle);

                        //INSERTAMOS LA CABECERA Y DETALLE DEL DEBE
                        //DEBE
                        oEntidad.SaldoDebe = totalGasto;
                        oEntidad.SaldoHaber = 0;
                        oEntidad.IdAsiento = ++contadorFilas;
                        oEntidad.CuentaContable = cuentaGastos;
                        cClase.InsertarAsiento(oEntidad);

                        oEntidadDetalle.IdAux = contadorFilas;
                        oEntidadDetalle.ImporteMN = montosolesGastos;
                        oEntidadDetalle.ImporteME = montodolaresGastos;
                        oEntidadDetalle.CuentaContable = cuentaGastos;
                        cClase.InsertarAux(oEntidadDetalle);

                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show($"Error al procesar la fila {rowHandle}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }

                //REVERSION DE LA PROVISION DE FACTURA
                glosaCabecera = $"Reversion de la Provision de Mutuos {fechaContable.ToString("dd-MM-yyyy")}";

                numasiento = 0;
                if (numasiento == 0)
                {
                    DataTable asientito = CapaLogica.UltimoAsiento(idEmpresa, fechaContable);
                    DataRow asiento = asientito.Rows[0];
                    if (asiento == null) { numasiento = 1; }
                    else
                        numasiento = (int)asiento["codigo"];
                }
                contadorFilas =0;
                string cuoReversion = "";

                foreach (int rowHandle in selectedRowHandles)
                {
                    if (rowHandle < 0)
                        continue;
                    DataRowView selectedDataRow = gridView1.GetRow(rowHandle) as DataRowView;
                    if (selectedDataRow == null)
                        continue;
                    try
                    {
                        // Datos originales de la fila seleccionada
                        int idPago = Convert.ToInt32(selectedDataRow["IdPago"]);
                        int idMutuo = Convert.ToInt32(selectedDataRow["idMutuo"]);
                        int idMutuante = Convert.ToInt32(selectedDataRow["idMutuante"]);
                        int idMoneda = Convert.ToInt32(selectedDataRow["moneda"]);
                        int Nro = Convert.ToInt32(selectedDataRow["Nro"]);
                        int periodos = Convert.ToInt32(selectedDataRow["periodo"]);
                        DateTime FechaEmision = Convert.ToDateTime(selectedDataRow["fechaEmision"]);
                        DateTime FechaVencimiento = Convert.ToDateTime(selectedDataRow["Fecha"]);

                        string CuentaContableDebe = selectedDataRow["CuentaContableHaber"].ToString();
                        string CuentaContableHaber = selectedDataRow["CuentaContableDebe"].ToString();
                        string Nmoneda = selectedDataRow["Nmoneda"].ToString();
                        decimal montoCuota = Convert.ToDecimal(selectedDataRow["Cuota"]);

                        //ARMANDO CABECERA
                        cuoReversion = HPResergerFunciones.Utilitarios.Cuo(numasiento, fechaContable);
                        HPResergerCapaLogica.Contable.ClaseContable cClase = new HPResergerCapaLogica.Contable.ClaseContable();
                        var Tdata = cClase.GetTipoCambioDia(fechaContable);
                        var tComprobante = cClase.GetNumeroDocumentoMutuo(idMutuo);
                        var tcliente = cClase.GetCliente(idMutuante);
                        string serieComprobante = tComprobante.Rows[0]["serie"].ToString();
                        int NumComprobante = (int)tComprobante.Rows[0]["numero"];
                        int idEtapa = (int)cboEtapa.EditValue;
                        int idProyecto = (int)cboProyecto.EditValue;
                        string glosa = $"Cod.Mutuo Cuota {Nro}/{periodos}";
                        decimal tc = Tdata.Rows.Count > 0 ? (decimal)Tdata.Rows[0]["Venta"] : 3;

                        HPResergerCapaLogica.Contable.ClaseContable.AsientoContableEntidad oEntidad = new HPResergerCapaLogica.Contable.ClaseContable.AsientoContableEntidad();
                        HPResergerCapaLogica.Contable.ClaseContable.AsientoContableAuxEntidad oEntidadDetalle = new HPResergerCapaLogica.Contable.ClaseContable.AsientoContableAuxEntidad();
                        //CABECERA
                        oEntidad.CodAsientoContable = cuoReversion;
                        oEntidad.Estado = 1;
                        oEntidad.FechaAsiento = fechaContable;
                        oEntidad.FechaAsientoValor = fechaContable;
                        oEntidad.FkIdEtapa = idEtapa;
                        oEntidad.Glosa = glosaCabecera;
                        oEntidad.IdAsientoContable = numasiento;
                        oEntidad.IdDinamicaContable = -39;
                        oEntidad.IdProyecto = idProyecto;
                        oEntidad.Moneda = idMoneda;
                        oEntidad.NroDocumento = "";
                        oEntidad.SaldoHaber = 0;
                        oEntidad.TC = tc;

                        oEntidad.IdAsiento = ++contadorFilas;
                        oEntidad.SaldoDebe = montoCuota;
                        oEntidad.CuentaContable = CuentaContableDebe;

                        decimal montosoles = idMoneda == 1 ? montoCuota : montoCuota * tc;
                        decimal montodolares = idMoneda == 2 ? montoCuota : montoCuota / tc;

                        //DETALLE
                        oEntidadDetalle.CentroCosto = 0;
                        oEntidadDetalle.CtaBanco = 0;
                        oEntidadDetalle.CuentaContable = CuentaContableDebe;
                        oEntidadDetalle.Fecha = DateTime.Now;
                        oEntidadDetalle.FechaAsiento = fechaContable;
                        oEntidadDetalle.FechaEmision = FechaEmision;
                        oEntidadDetalle.FechaRecepcion = fechaContable;
                        oEntidadDetalle.FechaVencimiento = FechaVencimiento;
                        oEntidadDetalle.FkAsi = cuoPago;
                        oEntidadDetalle.FkMoneda = idMoneda;
                        oEntidadDetalle.FkProyecto = idProyecto;
                        oEntidadDetalle.Glosa = glosa;
                        oEntidadDetalle.IdAsientoContable = numasiento;
                        oEntidadDetalle.IdAux = contadorFilas;
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

                        //INSERTAMOS LA CABECERA Y DETALLE DEL DEBE
                        //DEBE
                        cClase.InsertarAsiento(oEntidad);
                        //detalle DEBE
                        cClase.InsertarAux(oEntidadDetalle);

                        //INSERTAMOS LA CABECERA Y DETALLE DEL HABER
                        //haber
                        oEntidad.SaldoDebe = 0;
                        oEntidad.SaldoHaber = montoCuota;
                        oEntidad.IdAsiento = ++contadorFilas;
                        oEntidad.CuentaContable = CuentaContableHaber;
                        cClase.InsertarAsiento(oEntidad);

                        oEntidadDetalle.IdAux = contadorFilas;
                        oEntidadDetalle.ImporteMN = montosoles;
                        oEntidadDetalle.ImporteME = montodolares;
                        oEntidadDetalle.CuentaContable = CuentaContableHaber;
                        cClase.InsertarAux(oEntidadDetalle);
                        
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show($"Error al procesar la fila {rowHandle}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }


                XtraMessageBox.Show($"Abonado con Exito con cuo: {cuoPago}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnListar.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Cancelado por el usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnListar_Click(object sender, EventArgs e)
        {
            HPResergerCapaLogica.Finanzas.Mutuos oclase = new HPResergerCapaLogica.Finanzas.Mutuos();
            if (cboEmpresa.EditValue == null)
            {
                XtraMessageBox.Show("Seleccione una Empresa", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IdCtaBanco.EditValue == null)
            {
                XtraMessageBox.Show("Seleccione una Cuenta Bancaria", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int idempresa = (int)cboEmpresa.EditValue;
            DataTable Tdata = oclase.GetMutuosxPagar(idempresa, (DateTime)dtpfecha.EditValue, (int)IdCtaBanco.EditValue);
            gridControl1.DataSource = Tdata;
            gridView1.BestFitColumns();

            if (Tdata.Rows.Count == 0)
                XtraMessageBox.Show("No se encontraron registros, pruebe con otra empresa o moneda", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CalcularTotalesSeleccionados();

        }
    }
}