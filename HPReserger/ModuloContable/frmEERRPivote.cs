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
using DevExpress.XtraPrinting;
using DevExpress.Export;
using System.Diagnostics;

namespace SISGEM.ModuloContable
{
    public partial class frmEERRPivote : DevExpress.XtraEditors.XtraForm
    {
        public frmEERRPivote()
        {
            InitializeComponent();
        }
        public int Empresa { get; internal set; } = 0;
        private void btnBuscarFacturas_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            HPResergerCapaLogica.Contable.Contabilidad cClase = new HPResergerCapaLogica.Contable.Contabilidad();

            DataTable dt;
            dt = cClase.GenerarEERR((int)Empresa, (DateTime)dtpfecha.EditValue);

            // Asignar los datos actualizados al PivotGrid
            pivotGridControl1.DataSource = dt;

            pivotGridControl1.OptionsView.ShowColumnGrandTotals = true;
            pivotGridControl1.OptionsView.ShowRowGrandTotals = true;

            pivotGridControl1.OptionsView.ShowColumnTotals = true;
            pivotGridControl1.OptionsView.ShowRowTotals = true;

            xMonto.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            xMonto.CellFormat.FormatString = "#,##0.00;(#,##0.00)";

            xNombreBalance.BestFit();
        }
        private void frmEERRPivote_Load(object sender, EventArgs e)
        {
            CargarEmpresas();

            // Mostrar solo Mes y Año en el campo
            dtpfecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtpfecha.Properties.DisplayFormat.FormatString = "MMMM yyyy";  // Ej: "Mayo 2025"

            dtpfecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtpfecha.Properties.EditFormat.FormatString = "MMMM yyyy";

            dtpfecha.Properties.Mask.EditMask = "MMMM yyyy";
            dtpfecha.Properties.Mask.UseMaskAsDisplayFormat = true;

            dtpfecha.EditValue = DateTime.Now;


            // Cambiar el tipo de vista del calendario a Vista de Meses (evita días)
            dtpfecha.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;

            // Esto permite que el usuario solo elija el mes (de la vista anual)
            dtpfecha.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            dtpfecha.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
        }
        private void CargarEmpresas()
        {
            HPResergerCapaLogica.HPResergerCL oCL = new HPResergerCapaLogica.HPResergerCL();
            DataTable tData = oCL.Empresa();

            cboEmpresa.Properties.DataSource = tData;
            cboEmpresa.Properties.DisplayMember = "descripcion";
            cboEmpresa.Properties.ValueMember = "codigo";

            // Limpiar y configurar columnas manualmente
            cboEmpresa.Properties.Columns.Clear();

            // Agregar la columna "descripcion" y ocultar todas las demás
            foreach (DataColumn column in tData.Columns)
            {
                var lookupColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(column.ColumnName, column.ColumnName);
                lookupColumn.Visible = column.ColumnName == "descripcion"; // Solo la columna "descripcion" será visible
                cboEmpresa.Properties.Columns.Add(lookupColumn);
            }

            // Personalizar el encabezado de la columna visible
            cboEmpresa.Properties.Columns["descripcion"].Caption = "Empresa";

            // Seleccionar el primer registro si existen filas
            if (tData.Rows.Count > 0)
            {
                cboEmpresa.EditValue = tData.Rows[0]["codigo"]; // Asigna el primer valor de "codigo"
            }

            // Otras opciones de personalización
            cboEmpresa.Properties.ShowHeader = true; // Mostrar encabezado de columnas
            cboEmpresa.Properties.ShowFooter = false; // Ocultar pie de página
            cboEmpresa.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup; // Ajustar ancho automático


        }

        private void cboEmpresa_EditValueChanged(object sender, EventArgs e)
        {
            if (cboEmpresa.EditValue != null)
                Empresa = (int)cboEmpresa.EditValue;
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Ruta del archivo temporal (puedes cambiarla si deseas)
            string empresa = cboEmpresa.Text;
            string nombreFormulario = this.Text;
            DateTime Fecha = (DateTime)dtpfecha.EditValue;
            string rutaExcel = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"{nombreFormulario} {empresa} {Fecha.ToString("MMMM yyyy")}.xlsx");


            try
            {
                XlsxExportOptionsEx options = new XlsxExportOptionsEx()
                {
                    ExportType = ExportType.WYSIWYG, // Usar DataAware en lugar de WYSIWYG
                    ShowGridLines = true,
                    TextExportMode = TextExportMode.Text,
                    SheetName = nombreFormulario,
                    FitToPrintedPageWidth = true,
                    RawDataMode = false,
                    ExportHyperlinks = false
                };

                options.DocumentOptions.Author = "j90orellana@hotmail.com";
                options.DocumentOptions.Title = nombreFormulario;
                options.DocumentOptions.Subject = nombreFormulario;

                // Exportar el PivotGrid a Excel
                pivotGridControl1.ExportToXlsx(rutaExcel, options);

                // Verificar que se haya creado
                if (System.IO.File.Exists(rutaExcel))
                {
                    // Abrir el archivo Excel con la aplicación predeterminada
                    Process.Start(new ProcessStartInfo()
                    {
                        FileName = rutaExcel,
                        UseShellExecute = true
                    });
                }
                else
                {
                    MessageBox.Show("No se pudo exportar el archivo Excel.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message);
            }
        }

        private void btnBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnBuscarFacturas.PerformClick();
        }
    }
}