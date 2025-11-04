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
using DevExpress.XtraPivotGrid;
using System.Diagnostics;
using DevExpress.XtraPrinting;
using DevExpress.Export;

namespace SISGEM.Flujo_de_Caja
{
    public partial class frmFlujoCaja : DevExpress.XtraEditors.XtraForm
    {
        public frmFlujoCaja()
        {
            InitializeComponent();
        }
        public int Empresa { get; internal set; } = 0;
        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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
        private void btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CargarEmpresas();
        }

        private void frmFlujoCaja_Load(object sender, EventArgs e)
        {
            CargarEmpresas();
        }

        private void cboEmpresa_EditValueChanged(object sender, EventArgs e)
        {
            if (cboEmpresa.EditValue != null)
                Empresa = (int)cboEmpresa.EditValue;

            CargarDatos();
        }

        private void CargarDatos()
        {
            int compras, ventas, pagos, movimientos = 0;
            compras = chkCompras.Checked ? 1 : 0;
            ventas = chkVentas.Checked ? 1 : 0;
            pagos = chkPagos.Checked ? 1 : 0;
            movimientos = chkMovimientos.Checked ? 1 : 0;

            HPResergerCapaLogica.FlujoCaja.FacturaPresupuesto cClase = new HPResergerCapaLogica.FlujoCaja.FacturaPresupuesto();

            DataTable dt;
            if (movimientos == 1)
            {
                dt = cClase.FlujodeCajaMovimientos(Empresa, pagos);
            }
            else
            {
                dt = cClase.FlujodeCaja(Empresa, compras, ventas, 1);
            }
            if (dt.Rows.Count != 0)
            {

                // Crear una lista con todos los meses del rango necesario
                DateTime fechaMin = dt.AsEnumerable().Where(r => !r.IsNull("FechaEmision")).Min(r => r.Field<DateTime>("FechaEmision"));
                DateTime fechaMax = dt.AsEnumerable().Where(r => !r.IsNull("FechaEmision")).Max(r => r.Field<DateTime>("FechaEmision"));

                // Generar todos los meses en el rango
                for (DateTime fecha = fechaMin; fecha <= fechaMax; fecha = fecha.AddMonths(1))
                {
                    DateTime primerDiaDelMes = new DateTime(fecha.Year, fecha.Month, 1);

                    // Verificar si ya existe al menos un registro en este mes
                    bool existeMes = dt.AsEnumerable()
                        .Where(r => !r.IsNull("FechaEmision"))
                        .Any(r => r.Field<DateTime>("FechaEmision").Year == primerDiaDelMes.Year
                               && r.Field<DateTime>("FechaEmision").Month == primerDiaDelMes.Month);

                    // Si no existe, agregar una fila con valor 0
                    if (!existeMes)
                    {
                        DataRow nuevaFila = dt.NewRow();
                        nuevaFila["FechaEmision"] = primerDiaDelMes;
                        nuevaFila["PEN"] = 0; // Otras columnas pueden dejarse como DBNull.Value
                        dt.Rows.Add(nuevaFila);
                    }
                }
            }
            // Asignar los datos actualizados al PivotGrid
            pivotGridControl1.DataSource = dt;

            pivotGridFieldAnio.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            pivotGridFieldAnio.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            pivotGridFieldAnio.ValueFormat.FormatString = "####"; // solo muestra el año

            //pivotGridFieldMes.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonthYear;
            //pivotGridFieldMes.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            //pivotGridFieldMes.ValueFormat.FormatString = "MMM-yy"; // ejemplo: 05-2025

            xPresupuesto.BestFit();
        }

        private void btnBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CargarDatos();
        }

        private void btnBuscarFacturas_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void pivotGridControl1_CustomFieldValueCells(object sender, DevExpress.XtraPivotGrid.PivotCustomFieldValueCellsEventArgs e)
        {
            // Recorre únicamente las columnas, sin totales
            for (int i = e.GetCellCount(false) - 1; i >= 0; i--)
            {
                var cell = e.GetCell(false, i);
                if (cell == null) continue;

                var field = cell.DataField;
                if (field == pivotGridFieldAnio || field == pivotGridFieldMes)
                {
                    // Validar si toda la columna está vacía (es decir, no hay datos para ese año o mes)
                    bool columnaTieneDatos = false;

                    foreach (var row in pivotGridControl1.GetFieldsByArea(PivotArea.RowArea))
                    {
                        var value = pivotGridControl1.GetCellValue(pivotGridFieldAnio.Index, row.Index);
                        if (value != null && value != DBNull.Value && Convert.ToDecimal(value) != 0)
                        {
                            columnaTieneDatos = true;
                            break;
                        }
                    }

                    if (!columnaTieneDatos)
                    {
                        e.Remove(cell); // Elimina columna sin datos
                    }
                }
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Ruta del archivo temporal (puedes cambiarla si deseas)
            string empresa = cboEmpresa.Text;
            string rutaExcel = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"Flujo de Caja de {empresa}.xlsx");


            try
            {
                XlsxExportOptionsEx options = new XlsxExportOptionsEx()
                {
                    ExportType = ExportType.DataAware, // Usar DataAware en lugar de WYSIWYG
                    ShowGridLines = true,
                    TextExportMode = TextExportMode.Text,
                    SheetName = "Flujo de Caja",
                    FitToPrintedPageWidth = true,
                    RawDataMode = false,
                    ExportHyperlinks = false
                };

                options.DocumentOptions.Author = "j90orellana@hotmail.com";
                options.DocumentOptions.Title = "Flujo de Caja";
                options.DocumentOptions.Subject = "Flujo de Caja";

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

        private void chkMovimientos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkCompras_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pivotGridControl1_CustomCellDisplayText(object sender, PivotCellDisplayTextEventArgs e)
        {
            if (e.DataField == null) return;

            // Verifica si el valor es nulo o vacío
            if (e.Value == null || e.Value == DBNull.Value)
            {
                e.DisplayText = string.Empty; // Opcional: Puedes poner "0.00", "N/A", etc.
                return;
            }

            // Verifica si la celda pertenece a la columna "PEN" o "USD"
            if (e.DataField.FieldName == "PEN")
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal valor))
                {
                    e.DisplayText = valor.ToString("C2", new System.Globalization.CultureInfo("es-PE")); // S/ 1,234.50
                }
                else
                {
                    e.DisplayText = "N/A"; // Si no es un número válido
                }
            }
            else if (e.DataField.FieldName == "USD")
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal valor))
                {
                    e.DisplayText = valor.ToString("C2", new System.Globalization.CultureInfo("en-US")); // $1,234.50
                }
                else
                {
                    e.DisplayText = "N/A"; // Si no es un número válido
                }
            }
        }

        private void pivotGridControl1_FieldValueDisplayText(object sender, PivotFieldDisplayTextEventArgs e)
        {

            // Validamos que sea la columna FechaEmision
            if (e.Field != null && e.Field.FieldName == "FechaEmision"
                && e.IsColumn) // 👈 nos aseguramos de que es un valor en ColumnArea
            { }
            else { return; }
            if (e.Field.Caption != "Mes") return;

            switch (e.Field.GroupInterval)
            {
                case PivotGroupInterval.DateYear:
                    e.DisplayText = string.Format("{0:0}", e.Value);
                    break;

                case PivotGroupInterval.DateQuarter:
                    // Opción 1: mostrar solo T1, T2...
                    e.DisplayText = "T" + e.Value.ToString();

                    // Opción 2 (con año incluido):
                    // var year = ((DateTime)e.Value).Year;
                    // e.DisplayText = $"Trimestre {e.Value} - {year}";
                    break;

                case PivotGroupInterval.DateMonth:
                    e.DisplayText = string.Format("{0:0}", e.Value);
                    break;

                case PivotGroupInterval.DateMonthYear:
                    e.DisplayText = string.Format("{0:MMMM yyyy}", e.Value);
                    break;

                case PivotGroupInterval.DateDay:
                    e.DisplayText = string.Format("{0:0}", e.Value);
                    break;
                case PivotGroupInterval.Date:
                    e.DisplayText = string.Format("{0:dd/MM/yyyy}", e.Value);
                    break;
                case PivotGroupInterval.Default:
                    e.DisplayText = string.Format("{0:dd/MM/yyyy}", e.Value);
                    break;
                case PivotGroupInterval.DateQuarterYear:
                    DateTime fecha = (DateTime)e.Value;
                    int trimestre = (fecha.Month - 1) / 3 + 1;
                    e.DisplayText = $"T{trimestre} - {fecha.Year}";
                    break;
            }

        }

        private void pivotGridControl1_CustomGroupInterval(object sender, PivotCustomGroupIntervalEventArgs e)
        {

        }
    }
}