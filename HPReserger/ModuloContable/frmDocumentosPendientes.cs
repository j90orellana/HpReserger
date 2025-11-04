using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.Export;
using DevExpress.XtraEditors.Controls;

namespace SISGEM.ModuloContable
{
    public partial class frmDocumentosPendientes : DevExpress.XtraEditors.XtraForm
    {
        public frmDocumentosPendientes()
        {
            InitializeComponent();
        }
        string DataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "");
        private void frmDocumentosPendientes_Load(object sender, EventArgs e)
        {

            dtpfecha.EditValue = DateTime.Now;

            Cargar();

            this.xSaldo_Dolares.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Far;
            this.xSaldo_Soles.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Far;

            gridView1.OptionsView.EnableAppearanceOddRow = true;
            gridView1.OptionsView.EnableAppearanceEvenRow = true;
            gridView1.Appearance.OddRow.BackColor = Color.Lavender; // Color filas impares
            gridView1.Appearance.EvenRow.BackColor = Color.White;   // Color filas pares

            gridView1.Appearance.FocusedRow.BackColor = Color.LightSkyBlue;
            gridView1.Appearance.FocusedRow.Font = new Font(gridView1.Appearance.Row.Font, FontStyle.Bold);

            //this.xCuenta_Contable.Fixed = FixedStyle.Left; // Siempre visible al hacer scroll horizontal

            gridView1.OptionsView.ShowAutoFilterRow = false; // Filtros rápidos en cada columna

            // Limpia los sumarios existentes (si es necesario)
            this.xSaldo_Soles.Summary.Clear();
            this.xSaldo_Dolares.Summary.Clear();

            // Asigna los sumarios con formato {0:N2} (muestra ceros)
            this.xSaldo_Dolares.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
               new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo_Dolares", "{0:N2}")});

            this.xSaldo_Soles.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo_Soles", "{0:N2}")});

            this.xSaldo_Soles.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric; // Forzar tipo numérico
            this.xSaldo_Dolares.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric; // Forzar tipo numérico

            this.xSaldo_Dolares.DisplayFormat.FormatString = "N2";
            this.xSaldo_Soles.DisplayFormat.FormatString = "N2";

            xCuenta_Contable.MaxWidth = 0;
        }

        private void Cargar()
        {
            HPResergerCapaLogica.Mantenimiento.Empresa cEmpresa = new HPResergerCapaLogica.Mantenimiento.Empresa();
            chkEmpresa.Properties.DataSource = cEmpresa.GetAll();
            chkEmpresa.Properties.ValueMember = "Id_Empresa";
            chkEmpresa.Properties.DisplayMember = "Empresa";

            // En el evento Load del formulario o constructor:
            //chkEmpresa.Properties.EditValueType = EditValueType.String; // <- Clave
            chkEmpresa.Properties.SeparatorChar = ','; // Separador (por defecto ya es coma)

            // 2. Seleccionar todos los ítems por defecto
            foreach (CheckedListBoxItem item in chkEmpresa.Properties.Items)
            {
                item.CheckState = CheckState.Checked;
            }

            // Opcional: Actualizar el texto mostrado en el control
            chkEmpresa.RefreshEditValue();
        }
        private void Reportar()
        {
            // Validación de cuentas contables con mensaje más descriptivo
            if (string.IsNullOrWhiteSpace(txtCuentas.EditValue?.ToString()))
            {
                XtraMessageBox.Show("Por favor, ingrese las cuentas contables separadas por coma.\nEjemplo: 12,14,16,42", "Datos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtCuentas.Focus();
                return;
            }

            // Validación de empresa seleccionada con mejor mensaje
            if (string.IsNullOrWhiteSpace(chkEmpresa.EditValue?.ToString()))
            {
                XtraMessageBox.Show("Debe seleccionar al menos una empresa de la lista.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning); chkEmpresa.Focus();
                return;
            }

            try
            {
                // Mostrar indicador de carga
                Cursor.Current = Cursors.WaitCursor;

                HPResergerCapaLogica.Contable.ClaseContable cClase = new HPResergerCapaLogica.Contable.ClaseContable();

                var datos = cClase.getDocumentosPendientes(
                    chkEmpresa.EditValue.ToString().Trim(),
                    txtCuentas.EditValue.ToString().Trim(),
                    (DateTime)(dtpfecha.EditValue ?? DateTime.Now)
                );

                // Verificar si se obtuvieron resultados
                if (datos == null || datos.Rows.Count == 0)
                {
                    XtraMessageBox.Show("No se encontraron documentos pendientes con los criterios especificados.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = datos.Clone();
                    return;
                }

                gridControl1.DataSource = datos;
                // Mensaje opcional de éxito
                //XtraMessageBox.Show($"Se cargaron {datos.Rows.Count} registros correctamente.", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Mensaje de error mejorado con detalles técnicos en el título
                XtraMessageBox.Show($"Ocurrió un error al intentar generar el reporte:\n\n{ex.Message}", $"Error Técnico: {ex.GetType().Name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cargar();
        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
            Reportar();
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

        private void btnExportarPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportarAPDF();
        }

        private void btnExportarExcels_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportarAExcel();
        }
        private bool ValidarDatos()
        {
            if (gridControl1.DataSource == null || gridControl1.MainView.RowCount == 0)
            {
                MessageBox.Show("No se puede exportar porque la grilla no contiene datos.", "Exportación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void ExportarAExcel()
        {
            if (!ValidarDatos())
                return;

            string filePath = Path.Combine(DataPath, $"Revision de Cuentas { txtCuentas.EditValue.ToString()}.xls");

            try
            {
                var options = new XlsExportOptionsEx
                {
                    ExportType = ExportType.WYSIWYG,
                    ShowGridLines = true,
                    TextExportMode = TextExportMode.Text,
                    SheetName = "Revisión Cuentas",
                    FitToPrintedPageWidth = true,
                    RawDataMode = false,
                    ExportHyperlinks = false,
                    DocumentOptions = {
                                        Author = "j90orellana@hotmail.com",
                                        Title = "Reporte de Pendientes",
                                        Subject = "Revisión detallada de documentos pendientes"
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
                gridControl1.ExportToXls(filePath, options);
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

            string filePath = System.IO.Path.Combine(DataPath, $"Revision de Cuentas {txtCuentas.EditValue.ToString()}.pdf");

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
                gridControl1.ExportToPdf(filePath);
                AbrirArchivo(filePath);
            }
            catch (Exception ex)
            {
                MostrarError($"Error al exportar a PDF: {ex.Message}");
            }
        }
        private void AbrirArchivo(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    System.Diagnostics.Process.Start(filePath);
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
        private void AgruparDatos()
        {
            bool agruparCuentas = chkAgruparCuentas.Checked;
            bool agruparRazones = btnAgrupaRazones.Checked;
            GridView gridView1 = gridControl1.MainView as GridView;

            if (agruparCuentas || agruparRazones)
            {
                // Activar agrupación por "Cuenta"
                int pos = 0;
                if (agruparCuentas)
                    gridView1.Columns["Cuenta_Contable"].GroupIndex = pos++;
                if (agruparRazones)
                    gridView1.Columns["RazonSocial"].GroupIndex = pos++;
                gridView1.OptionsView.ShowGroupedColumns = true;
                gridView1.OptionsView.ShowGroupPanel = true;

                // Habilitar la visualización de summaries en grupos
                gridView1.OptionsView.ShowGroupedColumns = true;
                //gridView1.OptionsView.ShowAutoFilterRow = true;
                gridView1.OptionsView.ShowFooter = true;
                gridView1.OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;

                // Primero limpia los summaries existentes si es necesario
                gridView1.GroupSummary.Clear();
                this.xEmpresa.Summary.Clear();

                // Agrega el summary al GroupSummary del GridView, no a la columna
                gridView1.GroupSummary.Add(new DevExpress.XtraGrid.GridGroupSummaryItem()
                {
                    FieldName = "Cuenta_Contable",  // Columna sobre la que se calcula
                    DisplayFormat = "Registros: {0}",
                    SummaryType = DevExpress.Data.SummaryItemType.Count,
                    ShowInGroupColumnFooter = gridView1.Columns["Cuenta_Contable"]  // Columna donde se muestra
                });

                gridView1.GroupSummary.Add(new DevExpress.XtraGrid.GridGroupSummaryItem()
                {
                    FieldName = "RazonSocial",  // Columna sobre la que se calcula
                    DisplayFormat = "{0}",
                    SummaryType = DevExpress.Data.SummaryItemType.Max,
                    ShowInGroupColumnFooter = gridView1.Columns["RazonSocial"]  // Columna donde se muestra
                });

                gridView1.GroupSummary.Add(new DevExpress.XtraGrid.GridGroupSummaryItem()
                {
                    FieldName = "Saldo_Dolares",  // Columna sobre la que se calcula
                    DisplayFormat = "{0:N2}",
                    SummaryType = DevExpress.Data.SummaryItemType.Sum,
                    ShowInGroupColumnFooter = gridView1.Columns["Saldo_Dolares"]  // Columna donde se muestra
                });

                gridView1.GroupSummary.Add(new DevExpress.XtraGrid.GridGroupSummaryItem()
                {
                    FieldName = "Saldo_Soles",  // Columna sobre la que se calcula
                    DisplayFormat = "{0:N2}",
                    SummaryType = DevExpress.Data.SummaryItemType.Sum,
                    ShowInGroupColumnFooter = gridView1.Columns["Saldo_Soles"]  // Columna donde se muestra
                });


                this.xEmpresa.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Empresa", "{0}")});
            }
            else
            {
                // Desactivar agrupación
                gridView1.Columns["Cuenta_Contable"].UnGroup();
                gridView1.Columns["RazonSocial"].UnGroup();
                gridView1.OptionsView.ShowGroupedColumns = false;
                gridView1.OptionsView.ShowGroupPanel = false; // Opcional: oculta el panel de arrastre
            }

            // Refrescar la vista
            gridView1.BestFitColumns();
            gridView1.ExpandAllGroups(); // Si quieres expandir los grupos automáticamente
        }
        private void chkAgruparRucs_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AgruparDatos();
        }

        private void btnAgrupaRazones_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AgruparDatos();

        }
    }
}