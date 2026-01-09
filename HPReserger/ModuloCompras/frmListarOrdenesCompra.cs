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
using DevExpress.XtraPrinting;
using DevExpress.Export;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.XtraReports.UI;

namespace SISGEM.ModuloCompras
{
    public partial class frmListarOrdenesCompra : DevExpress.XtraEditors.XtraForm
    {
        public frmListarOrdenesCompra()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            HPResergerCapaLogica.Compras.OrdenCompra Cclase = new HPResergerCapaLogica.Compras.OrdenCompra();
            DateTime fechaSeleccionada = dtpfecha.EditValue as DateTime? ?? DateTime.Now;
            gridControl1.DataSource = Cclase.ListarOrdenesxAño(fechaSeleccionada);
            gridView1.BestFitColumns();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAgruparEmpresa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Primero limpiamos agrupaciones anteriores
            gridView1.ClearGrouping();

            gridView1.Columns["empresa"].GroupIndex = 0;
        }

        private void btnAgruparProveedor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Ejemplo: agrupar por Proveedor
            gridView1.ClearGrouping(); // Limpia agrupaciones previas

            gridView1.Columns["empresa"].GroupIndex = 0;
            gridView1.Columns["razonSocial"].GroupIndex = 1;
        }

        private void btnAgruparEstado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Primero limpiamos agrupaciones anteriores
            gridView1.ClearGrouping();

            gridView1.Columns["empresa"].GroupIndex = 0;
            gridView1.Columns["nEstadoOrden"].GroupIndex = 1;
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

        private void btnBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnFiltrar.PerformClick();
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

                string nombre = "Listado de Ordenes de Compra";
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null && view.FocusedRowHandle >= 0 && view.FocusedColumn != null)
            {
                object cellValue = view.GetRowCellValue(view.FocusedRowHandle, xid.FieldName);
                frmAddOrdenCompra xOrdenCompra = new frmAddOrdenCompra();
                xOrdenCompra._idOrden = (int)cellValue;

                //xOrdenCompra.MdiParent = this.MdiParent;
                xOrdenCompra.Show();
            }
        }

        private void frmListarOrdenesCompra_Load(object sender, EventArgs e)
        {
            dtpfecha.EditValue = DateTime.Now;

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

        private void btnExportarPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Obtener el GridView asociado
            GridView gv = gridControl1.FocusedView as GridView;

            // Obtener el índice de la fila seleccionada
            int rowHandle = gv.FocusedRowHandle;

            // Validar si la fila seleccionada es válida
            if (rowHandle < 0 || gv.IsGroupRow(rowHandle))
            {
                XtraMessageBox.Show("Debe seleccionar una orden válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID desde la columna "Id"
            object idValue = gv.GetRowCellValue(rowHandle, xid.FieldName);

            if (idValue == null || idValue == DBNull.Value)
            {
                XtraMessageBox.Show("La fila seleccionada no tiene un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idOrden = Convert.ToInt32(idValue);

            // Crear instancia del reporte
            ModuloContable.Reportes.xtraReportOrdenCompra reporte = new ModuloContable.Reportes.xtraReportOrdenCompra();

            // Obtener el SqlDataSource del reporte
            SqlDataSource dataSource = reporte.DataSource as SqlDataSource;

            if (dataSource != null)
            {
                // Crear una nueva conexión
                HPResergerCapaDatos.HPResergerCD capad = new HPResergerCapaDatos.HPResergerCD();
                string nuevaConexion = capad.ObtenerConexion();

                // Modificar la conexión
                dataSource.ConnectionParameters = new CustomStringConnectionParameters(nuevaConexion);

                var query = dataSource.Queries[0] as SqlQuery;
                var query2 = dataSource.Queries[1] as SqlQuery;
                if (query != null)
                {
                    query.Parameters.Clear(); // Limpia los parámetros previos
                    query2.Parameters.Clear(); // Limpia los parámetros previos

                    query.Parameters.Add(new QueryParameter("@idOrden", typeof(int), idOrden));
                    query2.Parameters.Add(new QueryParameter("@idOrden", typeof(int), idOrden));

                }

                // ** 3.3 REFRESCAR Y LLENAR EL DATA SOURCE **
                dataSource.RebuildResultSchema();
                dataSource.Fill();
            }

            // ** 4. EVITAR QUE SE MUESTRE LA VENTANA DE PARÁMETROS**
            foreach (var param in reporte.Parameters)
            {
                param.Visible = false; // Ocultar los parámetros en el visor
            }
            // ** 5. CONFIGURAR EL NOMBRE DEL ARCHIVO AL EXPORTAR A PDF**
            reporte.ExportOptions.PrintPreview.DefaultFileName = "Reporte Orden de Compra";

            // Mostrar el reporte en un visor
            ReportPrintTool printTool = new ReportPrintTool(reporte);
            printTool.ShowPreviewDialog();
        }

        private void bntEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //Obtener el GridView asociado
                GridView gv = gridControl1.FocusedView as GridView;

                // Obtener el índice de la fila seleccionada
                int rowHandle = gv.FocusedRowHandle;

                // Validar si la fila seleccionada es válida
                if (rowHandle < 0 || gv.IsGroupRow(rowHandle))
                {
                    XtraMessageBox.Show("Debe seleccionar una orden válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el ID desde la columna "Id"
                object idValue = gv.GetRowCellValue(rowHandle, xid.FieldName);
                object numOrdenValue = gv.GetRowCellValue(rowHandle, xnumOrden.FieldName).ToString();

                if (idValue == null || idValue == DBNull.Value)
                {
                    XtraMessageBox.Show("La fila seleccionada no tiene un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idOrden = Convert.ToInt32(idValue);

                // Confirmación del usuario
                DialogResult dr = XtraMessageBox.Show(
                    $"¿Está seguro que desea ANULAR esta Orden de Compra: {numOrdenValue}?\n\nEsta acción no se puede deshacer.",
                    "Confirmar Anulación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dr == DialogResult.No)
                {
                    XtraMessageBox.Show("La anulación fue cancelada por el usuario.", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Llamar a la capa lógica
                var oClase = new HPResergerCapaLogica.Compras.OrdenCompra();
                int filas = oClase.EliminarLogico(idOrden);

                if (filas > 0)
                {
                    XtraMessageBox.Show("La Orden de Compra fue anulada correctamente.", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Opcional: refrescar listado
                    gv.DeleteRow(rowHandle);   // Quita la fila del grid
                                               // O puedes volver a cargar la data:
                                               // CargarListado();
                }
                else
                {
                    XtraMessageBox.Show(
                        "No se pudo anular la Orden de Compra.\n" +
                        "La orden podría estar ya anulada o no existe.",
                        "Sin cambios",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(
                    "Ocurrió un error al intentar anular la Orden.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnVer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1_DoubleClick(gridView1, new EventArgs());
        }
    }
}