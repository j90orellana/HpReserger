using DevExpress.Export;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISGEM.ModuloContable
{
    public partial class frmListadoFacturas : XtraForm
    {
        public frmListadoFacturas()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FiltrarFacturasDeCompra();
        }

        private void btnBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnBuscarFacturas.PerformClick();
        }
        private void FiltrarFacturasDeCompra()
        {
            HPResergerCapaLogica.Compras.FacturaManual CFactura = new HPResergerCapaLogica.Compras.FacturaManual();

            // Obtener fechas
            DateTime fecha1 = Convert.ToDateTime(dtpfechade.EditValue);
            DateTime fecha2 = Convert.ToDateTime(dtpfechaa.EditValue);

            // Asegurar que fechaDesde sea la menor y fechaHasta la mayor
            DateTime fechaDesde = fecha1 < fecha2 ? fecha1 : fecha2;
            DateTime fechaHasta = fecha1 > fecha2 ? fecha1 : fecha2;

            // Obtener valores de los filtros, asegurando que no sean nulos
            string glosa = txtglosa.EditValue?.ToString() ?? string.Empty;
            string empresa = cboempresa.EditValue?.ToString() ?? string.Empty;
            string proveedor = txtproveedor.EditValue?.ToString() ?? string.Empty;
            string nrocomprobante = txtnrocomprobante.EditValue?.ToString() ?? string.Empty;

            int OcultarPP = chkPP.Checked ? 0 : 1;

            // Llamar a la consulta con las fechas ordenadas
            DataTable tdata = CFactura.BuscarFiltradoCompras(fechaDesde, fechaHasta, empresa, proveedor, glosa, OcultarPP, nrocomprobante);
            gridControl1.DataSource = tdata;
        }

        DataTable dtPresupuestos;
        DataTable dtPresupuestosUnicos;
        private void frmListadoFacturas_Load(object sender, EventArgs e)
        {
            Refrescar();

            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            gridView1.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.False;

            // Obtener el año actual
            int currentYear = DateTime.Today.Year;
            dtpfechade.EditValue = new DateTime(currentYear, 1, 1);
            dtpfechaa.EditValue = new DateTime(currentYear, 12, 31);

            repositoryItemSearchLookUpEdit4.DisplayMember = "Nombre";
            repositoryItemSearchLookUpEdit4.ValueMember = "id";
            repositoryItemSearchLookUpEdit4.NullText = "[Seleccione]";
            repositoryItemSearchLookUpEdit4.DataSource = dtPresupuestos; // Fuente de datos general

            cboPresupuestos.Properties.DisplayMember = "Nombre";
            cboPresupuestos.Properties.ValueMember = "id";
            cboPresupuestos.Properties.DataSource = dtPresupuestosUnicos; // Fuente de datos general

            cboPresupuestos.Properties.View.Columns.Clear();
            cboPresupuestos.Properties.View.Columns.AddVisible("Nombre", "Nombre del Presupuesto");
            cboPresupuestos.Properties.View.OptionsView.ShowColumnHeaders = false; // Opcional: Ocultar encabezado de columna
            cboPresupuestos.Properties.View.OptionsSelection.EnableAppearanceFocusedCell = false; // Evitar resaltado de celda seleccionada
            cboPresupuestos.Properties.View.FocusRectStyle = DrawFocusRectStyle.RowFocus; // Resaltar toda la fila

            // Configurar las columnas visibles
            GridView gridView = repositoryItemSearchLookUpEdit4.View as GridView;
            if (gridView != null)
            {
                gridView.Columns.Clear(); // Limpiar columnas anteriores
                gridView.Columns.AddVisible("Nombre", "Nombre del Presupuesto"); // Mostrar solo la columna "Nombre"
                gridView.OptionsView.ShowColumnHeaders = false; // Opcional: Ocultar encabezado de columna
                gridView.OptionsSelection.EnableAppearanceFocusedCell = false; // Evitar resaltado de celda seleccionada
                gridView.FocusRectStyle = DrawFocusRectStyle.RowFocus; // Resaltar toda la fila
            }
        }

        private void btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Refrescar();

        }
        public void Refrescar()
        {
            HPResergerCapaLogica.FlujoCaja.Partidas_Control cClase = new HPResergerCapaLogica.FlujoCaja.Partidas_Control();
            dtPresupuestos = cClase.GetAll();
            dtPresupuestosUnicos = cClase.GetAllUnicos();

            HPResergerCapaLogica.HPResergerCL oCL = new HPResergerCapaLogica.HPResergerCL();
            DataTable tData = oCL.Empresa();

            cboempresa.Properties.DataSource = tData;
            cboempresa.Properties.DisplayMember = "descripcion";
            cboempresa.Properties.ValueMember = "codigo";
        }

        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "IdPP")
            {
                GridView view = sender as GridView;
                string NEmpresa = view.GetRowCellValue(e.RowHandle, "Empresa")?.ToString().Trim() ?? string.Empty;

                RepositoryItemSearchLookUpEdit repositoryFiltered = new RepositoryItemSearchLookUpEdit
                {
                    DisplayMember = "Nombre",
                    ValueMember = "id",
                    NullText = "[Seleccione]"
                };

                // Filtrar presupuestos según la empresa
                var filteredRows = dtPresupuestos.AsEnumerable()
                    .Where(row => row["Empresa"].ToString().Trim() == NEmpresa);

                // Asignar el DataSource, validando si hay resultados
                repositoryFiltered.DataSource = filteredRows.Any() ? filteredRows.CopyToDataTable() : dtPresupuestos.Clone();

                // Configurar las columnas visibles
                GridView gridView = repositoryFiltered.View as GridView;
                if (gridView != null)
                {
                    gridView.Columns.Clear(); // Limpiar columnas anteriores
                    gridView.Columns.AddVisible("Nombre", "Nombre del Presupuesto"); // Mostrar solo la columna "Nombre"
                    gridView.OptionsView.ShowColumnHeaders = false; // Opcional: Ocultar encabezado de columna
                    gridView.OptionsSelection.EnableAppearanceFocusedCell = false; // Evitar resaltado de celda seleccionada
                    gridView.FocusRectStyle = DrawFocusRectStyle.RowFocus; // Resaltar toda la fila
                }

                e.RepositoryItem = repositoryFiltered;
            }
        }


        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.Column.FieldName == "Empresa")
            {
                gridView1.RefreshRow(e.RowHandle);
            }
            if (e.Column.FieldName == "IdPP") // Detecta el cambio en la columna "IdPP"
            {
                // Mejor manejo de la conversión con TryParse y validación
                string idStr = view.GetRowCellValue(e.RowHandle, "id")?.ToString();
                if (!int.TryParse(idStr, out int idFactura))
                {
                    // Manejar el error - asignar un valor por defecto o mostrar mensaje
                    idFactura = 0; // o lanzar una excepción más descriptiva
                }

                string idPartidaStr = view.GetRowCellValue(e.RowHandle, "IdPP")?.ToString();
                if (!int.TryParse(idPartidaStr, out int idPartida))
                {
                    idPartida = 0;
                }

                string pkidppStr = view.GetRowCellValue(e.RowHandle, "pkidpp")?.ToString();
                if (!int.TryParse(pkidppStr, out int pkidpp))
                {
                    pkidpp = 0;
                }
                string tipo = view.GetRowCellValue(e.RowHandle, "Tipo")?.ToString();

                int ValorTipoFactura = 0;

                //// Asignar valor basado en la celda "Tipo"
                if (tipo.Contains("NOTA"))
                    ValorTipoFactura = 2;
                else ValorTipoFactura = 1;


                HPResergerCapaLogica.FlujoCaja.FacturaPresupuesto Cclase = new HPResergerCapaLogica.FlujoCaja.FacturaPresupuesto();
                Cclase.InsertarUpdate(idFactura, ValorTipoFactura, idPartida);

            }
        }
        private void ExportarGridAExcel()
        {
            try
            {
                // Obtener la fecha actual en formato yyyyMMdd
                string fecha = DateTime.Now.ToString("yyyyMMdd");

                // Definir el nombre del archivo con la fecha
                string nombreArchivo = $"Listado de Comprobantes de Compra - {fecha}.xlsx";

                // Mostrar diálogo para seleccionar la ubicación del archivo
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Title = "Guardar archivo Excel",
                    FileName = nombreArchivo,
                    Filter = "Archivos Excel (*.xlsx)|*.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Exportar el GridControl a Excel
                    gridControl1.ExportToXlsx(saveFileDialog.FileName, new XlsxExportOptionsEx
                    {
                        ExportType = ExportType.WYSIWYG, // Exporta como se muestra en pantalla
                        ShowGridLines = true // Mantiene las líneas de la cuadrícula
                    });

                    // Abrir el archivo después de la exportación (Opcional)
                    if (MessageBox.Show("Exportación exitosa. ¿Desea abrir el archivo?", "Exportar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = saveFileDialog.FileName,
                            UseShellExecute = true
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportarGridAExcel();
        }

        private void txtempresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar.PerformClick();
                e.SuppressKeyPress = true; // Evita que se agregue una nueva línea si es un TextEdit multilínea
            }
        }

        private void txtempresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar); // Convierte cada carácter a mayúscula
        }
        private void AsignarValoresIdPP(Boolean SaltarLlenos = false)
        {
            if (cboPresupuestos.EditValue != null)
            {
                int.TryParse(cboPresupuestos.EditValue.ToString(), out int idSeleccionado); // Obtener el Id seleccionado
                GridView view = gridView1; // Obtiene la vista del GridControl
                for (int i = 0; i < view.RowCount; i++)
                {
                    int.TryParse(view.GetRowCellValue(i, "IdPP").ToString(), out int valorIdPP);

                    // Validar si el IdPP es nulo o cero antes de asignar un nuevo valor
                    if (Convert.ToInt32(valorIdPP) == 0 || SaltarLlenos)
                    {

                        // Obtener los valores de las columnas necesarias
                        int idFactura = int.Parse(view.GetRowCellValue(i, "id")?.ToString());
                        //int idPartida = 0;// int.Parse(view.GetRowCellValue(i, "IdPP")?.ToString());
                        string tipo = view.GetRowCellValue(i, "Tipo")?.ToString();

                        int ValorTipoFactura = 0;
                        // Asignar valor basado en la celda "Tipo"
                        if (!string.IsNullOrEmpty(tipo))
                        {
                            if (tipo.Equals("Facturas Compras", StringComparison.OrdinalIgnoreCase))
                                ValorTipoFactura = 1;
                            else if (tipo.Equals("Notas Compras", StringComparison.OrdinalIgnoreCase))
                                ValorTipoFactura = 100;
                        }

                        HPResergerCapaLogica.FlujoCaja.FacturaPresupuesto Cclase = new HPResergerCapaLogica.FlujoCaja.FacturaPresupuesto();
                        Cclase.InsertarUpdateBuscarCompras(idFactura, ValorTipoFactura, idSeleccionado);

                    }
                }
                btnBuscar.PerformClick();
            }
        }
        private object ObtenerDisplayMember(object id)
        {
            if (id == null) return null;

            DataRow[] resultado = dtPresupuestos.Select("id = " + id);
            return resultado.Length > 0 ? resultado[0]["Nombre"] : null;
        }

        private void btnAplicarParcial_Click(object sender, EventArgs e)
        {
            AsignarValoresIdPP();
        }

        private void btnAplicarTodo_Click(object sender, EventArgs e)
        {
            AsignarValoresIdPP(true);
        }
        int idFactura;
        int tipoFactura;
        int tipoSustento;
        int tipoDocumento;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // Restablece valores predeterminados
            idFactura = 0;
            tipoFactura = 0;
            tipoSustento = 0;
            tipoDocumento = 0;

            // Obtén el índice de la fila seleccionada
            int focusedRowHandle = e.FocusedRowHandle;

            // Verifica si la fila es válida y contiene datos
            if (focusedRowHandle >= 0 && gridView1.IsDataRow(focusedRowHandle))
            {
                // Obtén el valor de "id" de manera segura
                object ididFacturaValue = gridView1.GetRowCellValue(focusedRowHandle, xid.FieldName);
                idFactura = ididFacturaValue is int ? (int)ididFacturaValue : 0;

                object tipoFacturaValue = gridView1.GetRowCellValue(focusedRowHandle, xTipo.FieldName);
                tipoFactura = tipoFacturaValue.ToString().Trim() == "Facturas Compras" ? 1 : 2;

                object tipoSustentoValue = gridView1.GetRowCellValue(focusedRowHandle, xtipoSustento.FieldName);
                tipoSustento = tipoSustentoValue is int ? (int)tipoSustentoValue : 0;

                object tipoDocumentoValue = gridView1.GetRowCellValue(focusedRowHandle, xtipoDocumento.FieldName);
                tipoDocumento = tipoDocumentoValue is int ? (int)tipoDocumentoValue : 0;

                if (tipoDocumento == 0)
                {
                    btnCargaDocumento.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnDescargarDocumento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnEliminarDocumento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                else
                {
                    btnCargaDocumento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnDescargarDocumento.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnEliminarDocumento.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
                if (tipoSustento == 0)
                {
                    btnCargaSustento.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnDescargarSustento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnEliminarSustento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                else
                {
                    btnCargaSustento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnDescargarSustento.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnEliminarSustento.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                }
            }
        }

        string _nombreFile = "";
        string _extensionFile = "";
        byte[] _dataFile = null;

        private void btnCargaDocumento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccionar archivo adjunto";
            ofd.Filter = "Todos los archivos|*.*";

            _dataFile = null;
            _nombreFile = "";
            _extensionFile = "";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Leer archivo en bytes
                _dataFile = System.IO.File.ReadAllBytes(ofd.FileName);
                _nombreFile = System.IO.Path.GetFileName(ofd.FileName);
                _extensionFile = System.IO.Path.GetExtension(ofd.FileName);

                if (_nombreFile != "") // 1 documento 2 sustento
                {
                    HPResergerCapaLogica.Compras.FacturaManual ccalse = new HPResergerCapaLogica.Compras.FacturaManual();
                    if (ccalse.GuardarAdjuntoSQL(idFactura, tipoFactura, 1, _nombreFile, _extensionFile, _dataFile))
                    {
                        XtraMessageBox.Show("Adjunto guardado correctamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, xtipoDocumento.FieldName, 1);
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrió un problema y no se pudo guardar. Por favor, intente nuevamente ", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void btnCargaSustento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccionar archivo adjunto";
            ofd.Filter = "Todos los archivos|*.*";

            _dataFile = null;
            _nombreFile = "";
            _extensionFile = "";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Leer archivo en bytes
                _dataFile = System.IO.File.ReadAllBytes(ofd.FileName);
                _nombreFile = System.IO.Path.GetFileName(ofd.FileName);
                _extensionFile = System.IO.Path.GetExtension(ofd.FileName);

                if (_nombreFile != "") // 1 documento 2 sustento
                {
                    HPResergerCapaLogica.Compras.FacturaManual ccalse = new HPResergerCapaLogica.Compras.FacturaManual();
                    if (ccalse.GuardarAdjuntoSQL(idFactura, tipoFactura, 2, _nombreFile, _extensionFile, _dataFile))
                    {
                        XtraMessageBox.Show("Adjunto guardado correctamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, xtipoSustento.FieldName, 1);
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrió un problema y no se pudo guardar. Por favor, intente nuevamente ", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void btnDescargarDocumento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SISGEM.ModuloCompras.frmComprobantesComprasDirectas cclase = new SISGEM.ModuloCompras.frmComprobantesComprasDirectas();
            cclase.DescargarTodosArchivos(tipoFactura, idFactura, 1);
        }

        private void btnDescargarSustento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SISGEM.ModuloCompras.frmComprobantesComprasDirectas cclase = new SISGEM.ModuloCompras.frmComprobantesComprasDirectas();
            cclase.DescargarTodosArchivos(tipoFactura, idFactura, 2);
        }

        private void btnEliminarDocumento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPResergerCapaLogica.Compras.FacturaManual clase = new HPResergerCapaLogica.Compras.FacturaManual();

            // Pregunta de confirmación
            DialogResult respuesta = XtraMessageBox.Show("¿Está seguro de que desea eliminar este adjunto?\n\n" +
                "Esta acción no se puede deshacer.", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario cancela
            if (respuesta != DialogResult.Yes)
            {
                XtraMessageBox.Show("La eliminación del adjunto fue cancelada por el usuario.",
                    "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }

            // Ejecutar eliminación
            if (clase.DeleteArchivoFactura(tipoFactura, idFactura, 1))
            {
                XtraMessageBox.Show("El adjunto se eliminó correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Actualizar valor en el grid
                if (gridView1.FocusedRowHandle >= 0)
                {
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, xtipoDocumento.FieldName, 0);
                }
            }
            else
            {
                XtraMessageBox.Show("No fue posible eliminar el adjunto.\n\n" +
                    "Es posible que el registro ya no exista o esté siendo utilizado.",
                    "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminarSustento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPResergerCapaLogica.Compras.FacturaManual clase = new HPResergerCapaLogica.Compras.FacturaManual();

            // Pregunta de confirmación
            DialogResult respuesta = XtraMessageBox.Show("¿Está seguro de que desea eliminar este adjunto?\n\n" +
                "Esta acción no se puede deshacer.", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario cancela
            if (respuesta != DialogResult.Yes)
            {
                XtraMessageBox.Show("La eliminación del adjunto fue cancelada por el usuario.",
                    "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }

            // Ejecutar eliminación
            if (clase.DeleteArchivoFactura(tipoFactura, idFactura, 2))
            {
                XtraMessageBox.Show("El adjunto se eliminó correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Actualizar valor en el grid
                if (gridView1.FocusedRowHandle >= 0)
                {
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, xtipoSustento.FieldName, 0);
                }
            }
            else
            {
                XtraMessageBox.Show("No fue posible eliminar el adjunto.\n\n" +
                    "Es posible que el registro ya no exista o esté siendo utilizado.",
                    "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
