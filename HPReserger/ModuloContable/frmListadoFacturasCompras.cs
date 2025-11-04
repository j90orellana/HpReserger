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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using DevExpress.Export;
using DevExpress.XtraPrinting;

namespace SISGEM.ModuloContable
{
    public partial class frmListadoFacturasCompras : DevExpress.XtraEditors.XtraForm
    {
        public frmListadoFacturasCompras()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            HPResergerCapaLogica.Compras.FacturaManual Cclase = new HPResergerCapaLogica.Compras.FacturaManual();
            DateTime fechaSeleccionada = dtpfecha.EditValue as DateTime? ?? DateTime.Now;
            gridControl1.DataSource = Cclase.ListarFacturasxAño(fechaSeleccionada);
            gridView1.BestFitColumns();
        }

        private void btnAgrupar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.DataRowCount != 0)
            {
                gridView1.ExpandAllGroups();
            }
        }

        private void btnDesAgrupar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.DataRowCount != 0)
            {
                gridView1.CollapseAllGroups();
            }
        }

        private void frmListadoFacturasCompras_Load(object sender, EventArgs e)
        {
            // Mostrar solo Mes y Año en el campo
            dtpfecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtpfecha.Properties.DisplayFormat.FormatString = "yyyy";  // Ej: "Mayo 2025"

            dtpfecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtpfecha.Properties.EditFormat.FormatString = "yyyy";

            dtpfecha.Properties.Mask.EditMask = "yyyy";
            dtpfecha.Properties.Mask.UseMaskAsDisplayFormat = true;

            // Cambiar el tipo de vista del calendario a Vista de Meses (evita días)
            dtpfecha.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView;

            // Esto permite que el usuario solo elija el mes (de la vista anual)
            dtpfecha.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            dtpfecha.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;

            //gridView1.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", gridView1.Columns["Total"], "Suma: {0:n2}");

        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var exporter = new GridExporter(gridControl1, gridView1, (DateTime)dtpfecha.EditValue);
            exporter.ExportarAExcel();
        }
        public class GridExporter
        {
            private readonly GridControl _gridControl;
            private readonly GridView _gridview;
            private readonly string _cuo;
            private readonly string _appDataPath;
            private readonly DateTime _fecha;

            public GridExporter(GridControl gridControl, GridView gridview, DateTime Fecha)
            {

                _gridControl = gridControl ?? throw new ArgumentNullException(nameof(gridControl));
                _gridview = gridview ?? throw new ArgumentNullException(nameof(gridview));
                _appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "");

                _fecha = Fecha;

                // Crear directorio si no existe
                if (!Directory.Exists(_appDataPath))
                {
                    Directory.CreateDirectory(_appDataPath);
                }
            }
            private bool ValidarDatos()
            {
                if (_gridControl.DataSource == null || _gridControl.MainView.RowCount == 0)
                {
                    MessageBox.Show("No se puede exportar porque la grilla no contiene datos.",
                                  "Exportación cancelada",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            private void MostrarError(string mensaje)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            private void AbrirArchivo(string filePath)
            {
                try
                {
                    if (File.Exists(filePath))
                    {
                        System.Diagnostics.Process.Start(filePath);
                        //MessageBox.Show($"Archivo exportado correctamente:\n{filePath}",
                        //"Éxito",
                        //                MessageBoxButtons.OK,
                        //                MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MostrarError($"Error al abrir el archivo: {ex.Message}");
                }
            }

            public void ExportarAExcel()
            {
                if (!ValidarDatos())
                    return;

                string nombre = "Listado de Facturas de Compra";
                string filePath = Path.Combine(_appDataPath, $"{nombre} {_fecha.ToString("yyyy")}.xls");

                try
                {
                    var options = new XlsExportOptionsEx
                    {
                        ExportType = ExportType.WYSIWYG,
                        ShowGridLines = true,
                        TextExportMode = TextExportMode.Text,
                        SheetName = nombre,
                        FitToPrintedPageWidth = true,
                        RawDataMode = false,
                        ExportHyperlinks = false,
                        DocumentOptions = {
                                        Author = "j90orellana@hotmail.com",
                                        Title = $"{nombre} {_fecha.ToString("yyyy")}",
                                        Subject = $"{nombre} {_fecha.ToString("yyyy")}"
                        }

                    };

                    // Validar si el archivo existe y está abierto
                    if (File.Exists(filePath))
                    {
                        try
                        {
                            // Intenta abrir el archivo en modo exclusivo
                            using (var file = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                            {
                                // Si no hay excepción, el archivo no está bloqueado
                            }
                        }
                        catch (IOException)
                        {
                            // El archivo está abierto/bloqueado
                            XtraMessageBox.Show("El archivo está abierto en otro programa. Ciérrelo antes de continuar.", "Archivo en Uso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Salir sin exportar
                        }
                    }
                    _gridControl.ExportToXls(filePath, options);

                    AbrirArchivo(filePath);
                }
                catch (Exception ex)
                {
                    MostrarError($"Error al exportar a Excel: {ex.Message}");
                }
            }
        }

        private void btnAgruparProveedor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Ejemplo: agrupar por Proveedor
            gridView1.ClearGrouping(); // Limpia agrupaciones previas

            gridView1.Columns["Empresa"].GroupIndex = 0;
            gridView1.Columns["RazonSocial"].GroupIndex = 1;
        }

        private void btnAgruparxMes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Primero limpiamos agrupaciones anteriores
            gridView1.ClearGrouping();

            // Decimos que la columna "FechaEmision" se agrupe por MES
            gridView1.Columns["FechaEmision"].GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateMonth;
            gridView1.Columns["Empresa"].GroupIndex = 0;
            gridView1.Columns["FechaEmision"].GroupIndex = 1;

            // Opcional: mostrar el formato "MMMM yyyy" (Ej. Enero 2025)
            gridView1.Columns["FechaEmision"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView1.Columns["FechaEmision"].DisplayFormat.FormatString = "MMMM yyyy";

        }

        private void btnAgruparEstado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Primero limpiamos agrupaciones anteriores
            gridView1.ClearGrouping();

            gridView1.Columns["Empresa"].GroupIndex = 0;
            gridView1.Columns["EstadoCP"].GroupIndex = 1;
        }

        private void btnBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnFiltrar.PerformClick();
        }

        private void btnAgruparEmpresa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Primero limpiamos agrupaciones anteriores
            gridView1.ClearGrouping();

            gridView1.Columns["Empresa"].GroupIndex = 0;

        }

        private void btnDesagruparGrupos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Primero limpiamos agrupaciones anteriores
            gridView1.ClearGrouping();
        }
    }
}