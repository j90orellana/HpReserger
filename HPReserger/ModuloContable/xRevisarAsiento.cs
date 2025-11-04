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
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.Export;

namespace SISGEM.ModuloContable
{
    public partial class xRevisarAsiento : DevExpress.XtraEditors.XtraForm
    {
        public xRevisarAsiento()
        {
            InitializeComponent();
        }
        public int idEmpresa { get; set; } = 0;
        public string NombreEmpresa { get; set; } = "";
        public string cuo { get; set; } = "";
        public int comparar { get; set; } = 0;
        private GridControl _gridControl;
        private string _cuo;
        private string _appDataPath;

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void xRevisarAsiento_Load(object sender, EventArgs e)
        {
            // Columnas numéricas alineadas a la derecha
            this.xDebe.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Far;
            this.xHaber.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Far;
            this.xImporteMN.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Far;
            this.xImporteME.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Far;
            this.xDiferencia.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Far;

            // Columnas de texto alineadas a la izquierda
            this.xPos.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near;
            this.xCuenta.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near;

            gridView1.OptionsView.EnableAppearanceOddRow = true;
            gridView1.OptionsView.EnableAppearanceEvenRow = true;
            gridView1.Appearance.OddRow.BackColor = Color.Lavender; // Color filas impares
            gridView1.Appearance.EvenRow.BackColor = Color.White;   // Color filas pares

            gridView1.Appearance.FocusedRow.BackColor = Color.LightSkyBlue;
            gridView1.Appearance.FocusedRow.Font = new Font(gridView1.Appearance.Row.Font, FontStyle.Bold);

            this.xCuenta.Fixed = FixedStyle.Left; // Siempre visible al hacer scroll horizontal

            gridView1.OptionsView.ShowAutoFilterRow = false; // Filtros rápidos en cada columna

            // Limpia los sumarios existentes (si es necesario)
            this.xImporteME.Summary.Clear();
            this.xImporteMN.Summary.Clear();
            this.xDiferencia.Summary.Clear();  // Solo si quieres reemplazar los del diseñador
            this.xDebe.Summary.Clear();
            this.xHaber.Summary.Clear();

            // Asigna los sumarios con formato {0:N2} (muestra ceros)
            this.xImporteME.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
               new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImporteME", "{0:N2}")});

            this.xImporteMN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImporteMN", "{0:N2}")});

            this.xDiferencia.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Diferencia", "{0:N2}")});

            this.xDebe.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debe", "{0:N2}")});

            this.xHaber.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Haber", "{0:N2}")});
            lbldatos.Caption = $"CUO: {cuo}";

            this.xDebe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric; // Forzar tipo numérico
            this.xHaber.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric; // Forzar tipo numérico
            this.xImporteMN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric; // Forzar tipo numérico
            this.xImporteME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric; // Forzar tipo numérico
            this.xDiferencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric; // Forzar tipo numérico

            this.xDebe.DisplayFormat.FormatString = "N2";
            this.xHaber.DisplayFormat.FormatString = "N2";
            this.xImporteMN.DisplayFormat.FormatString = "N2";
            this.xImporteME.DisplayFormat.FormatString = "N2";
            this.xDiferencia.DisplayFormat.FormatString = "N2";

            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                var claseContable = new HPResergerCapaLogica.Contable.ClaseContable();
                int comparar = chkComparar.Checked ? 1 : 0;

                var datos = claseContable.RevisionAsientos(idEmpresa, cuo, comparar);
                gridControl1.DataSource = datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnComparar_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CargarDatos();
        }

        private void chkAgruparCuentas_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool agrupar = chkAgruparCuentas.Checked;
            GridView gridView1 = gridControl1.MainView as GridView;

            if (agrupar)
            {
                // Activar agrupación por "Cuenta"
                gridView1.Columns["Cuenta"].Group();
                gridView1.OptionsView.ShowGroupedColumns = true;
                gridView1.OptionsView.ShowGroupPanel = true;
            }
            else
            {
                // Desactivar agrupación
                gridView1.Columns["Cuenta"].UnGroup();
                gridView1.OptionsView.ShowGroupedColumns = false;
                gridView1.OptionsView.ShowGroupPanel = false; // Opcional: oculta el panel de arrastre
            }

            // Refrescar la vista
            gridView1.BestFitColumns();
            gridView1.ExpandAllGroups(); // Si quieres expandir los grupos automáticamente
        }

        private void chkFiltrarDatos_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool agrupar = chkFiltrarDatos.Checked;
            GridView gridView1 = gridControl1.MainView as GridView;

            if (agrupar)
            {
                gridView1.OptionsView.ShowAutoFilterRow = true; // Filtros rápidos en cada columna

            }
            else
            {
                gridView1.OptionsView.ShowAutoFilterRow = false; // Filtros rápidos en cada columna
            }
        }

        private void btnexportarexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Obtener el CUO (Código Único de Operación) de donde corresponda
            string cuo = ObtenerCUO(); // Implementa esta función según tu lógica

            var exporter = new GridExporter(gridControl1, gridView1, cuo, NombreEmpresa);
            exporter.ExportarAExcel();
        }

        private void btnExportarPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Obtener el CUO (Código Único de Operación) de donde corresponda
            string cuo = ObtenerCUO(); // Implementa esta función según tu lógica

            var exporter = new GridExporter(gridControl1, gridView1, cuo, NombreEmpresa);
            exporter.ExportarAPDF();
        }
        private string ObtenerCUO()
        {
            // Implementa la lógica para obtener el CUO
            return cuo;
        }
        public class GridExporter
        {
            private readonly GridControl _gridControl;
            private readonly GridView _gridview;
            private readonly string _cuo;
            private readonly string _appDataPath;
            private readonly string _nombreEmpresa;

            public GridExporter(GridControl gridControl, GridView gridview, string cuo, string nombreempresa)
            {

                _gridControl = gridControl ?? throw new ArgumentNullException(nameof(gridControl));
                _gridview = gridview ?? throw new ArgumentNullException(nameof(gridview));
                _cuo = cuo;
                _appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "");
                _nombreEmpresa = nombreempresa;

                // Crear directorio si no existe
                if (!Directory.Exists(_appDataPath))
                {
                    Directory.CreateDirectory(_appDataPath);
                }
            }
            public void ExportarAExcel()
            {
                if (!ValidarDatos())
                    return;

                string filePath = Path.Combine(_appDataPath, $"Revision de asiento {_cuo}.xls");

                try
                {
                    var options = new XlsExportOptionsEx
                    {
                        ExportType = ExportType.WYSIWYG,
                        ShowGridLines = true,
                        TextExportMode = TextExportMode.Text,
                        SheetName = "Revisión Contable",
                        FitToPrintedPageWidth = true,
                        RawDataMode = false,
                        ExportHyperlinks = false,
                        DocumentOptions = {
                                        Author = "j90orellana@hotmail.com",
                                        Title = "Reporte de Asientos",
                                        Subject = "Revisión detallada de asientos contables"
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

            public void ExportarAPDF()
            {
                if (!ValidarDatos())
                    return;

                string filePath = Path.Combine(_appDataPath, $"Revision de asiento {_cuo}.pdf");

                try
                {
                    
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
                    _gridControl.ExportToPdf(filePath);
                    AbrirArchivo(filePath);
                }
                catch (Exception ex)
                {
                    MostrarError($"Error al exportar a PDF: {ex.Message}");
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

            private void MostrarError(string mensaje)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}