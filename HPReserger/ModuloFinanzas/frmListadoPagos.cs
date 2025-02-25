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

namespace SISGEM.ModuloFinanzas
{
    public partial class frmListadoPagos : XtraForm
    {
        public frmListadoPagos()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnBuscarFacturas.PerformClick();
        }

        private void btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Refrescar();
        }
        DataTable dtPresupuestos;
        DataTable dtPresupuestosUnicos;
        public void Refrescar()
        {
            HPResergerCapaLogica.FlujoCaja.Partidas_Control cClase = new HPResergerCapaLogica.FlujoCaja.Partidas_Control();
            dtPresupuestos = cClase.GetAll();
            dtPresupuestosUnicos = cClase.GetAllUnicos();
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportarGridAExcel();
        }
        private void ExportarGridAExcel()
        {
            try
            {
                // Obtener la fecha actual en formato yyyyMMdd
                string fecha = DateTime.Now.ToString("yyyyMMdd");

                // Definir el nombre del archivo con la fecha
                string nombreArchivo = $"Listado de Pagos - {fecha}.xlsx";

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

        private void btnBuscarFacturas_Click(object sender, EventArgs e)
        {
            FiltrarFacturasDeVentas();
        }
        private void FiltrarFacturasDeVentas()
        {
            HPResergerCapaLogica.Compras.FacturaManual CFactura = new HPResergerCapaLogica.Compras.FacturaManual();
    

            // Obtener fechas
            DateTime fecha1 = Convert.ToDateTime(dtpfechade.EditValue);
            DateTime fecha2 = Convert.ToDateTime(dtpfechaa.EditValue);

            // Asegurar que fechaDesde sea la menor y fechaHasta la mayor
            DateTime fechaDesde = fecha1 < fecha2 ? fecha1 : fecha2;
            DateTime fechaHasta = fecha1 > fecha2 ? fecha1 : fecha2;

            // Obtener valores de los filtros, asegurando que no sean nulos
            string nrocta = txtnrocta.EditValue?.ToString() ?? string.Empty;
            string empresa = txtempresa.EditValue?.ToString() ?? string.Empty;
            string proveedor = txtproveedor.EditValue?.ToString() ?? string.Empty;
            string nrocomprobante = txtnrocomprobante.EditValue?.ToString() ?? string.Empty;

            int OcultarPP = chkPP.Checked ? 0 : 1;

            // Llamar a la consulta con las fechas ordenadas
            DataTable tdata = CFactura.BuscarFiltradoPagoCompras(fechaDesde, fechaHasta, empresa, proveedor, nrocta, OcultarPP, nrocomprobante);
            gridControl1.DataSource = tdata;
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

        private void btnAplicarTodo_Click(object sender, EventArgs e)
        {
            AsignarValoresIdPP(true);

        }

        private void btnAplicarParcial_Click(object sender, EventArgs e)
        {
            AsignarValoresIdPP();

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
                        //string tipo = view.GetRowCellValue(i, "Tipo")?.ToString();

                        int ValorTipoFactura = 5;
                        //// Asignar valor basado en la celda "Tipo"
                        //if (!string.IsNullOrEmpty(tipo))
                        //{
                        //    if (tipo.Equals("Facturas Ventas", StringComparison.OrdinalIgnoreCase))
                        //        ValorTipoFactura = 5;
                        //    else if (tipo.Equals("Notas Ventas", StringComparison.OrdinalIgnoreCase))
                        //        ValorTipoFactura = 5;
                        //}

                        HPResergerCapaLogica.FlujoCaja.FacturaPresupuesto Cclase = new HPResergerCapaLogica.FlujoCaja.FacturaPresupuesto();
                        Cclase.InsertarUpdateBuscarPagos(idFactura, ValorTipoFactura, idSeleccionado);

                    }
                }
                btnBuscar.PerformClick();
            }
        }

        private void gridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
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
                // Obtener los valores de las columnas necesarias
                int.TryParse(view.GetRowCellValue(e.RowHandle, "id")?.ToString(), out int idFactura);
                int.TryParse(view.GetRowCellValue(e.RowHandle, "IdPP")?.ToString(), out int idPartida);
                int.TryParse(view.GetRowCellValue(e.RowHandle, "pkidpp")?.ToString(), out int pkidpp);
                //string tipo = view.GetRowCellValue(e.RowHandle, "Tipo")?.ToString() ?? string.Empty;


                int ValorTipoFactura = 5;

                //// Asignar valor basado en la celda "Tipo"
                //if (!string.IsNullOrEmpty(tipo))
                //{
                //    if (tipo.Equals("Facturas Ventas", StringComparison.OrdinalIgnoreCase))
                //        ValorTipoFactura = 2;
                //    else if (tipo.Equals("Notas Ventas", StringComparison.OrdinalIgnoreCase))
                //        ValorTipoFactura = 200;
                //}

                HPResergerCapaLogica.FlujoCaja.FacturaPresupuesto Cclase = new HPResergerCapaLogica.FlujoCaja.FacturaPresupuesto();
                Cclase.InsertarUpdate(idFactura, ValorTipoFactura, idPartida);

            }
        }

        private void frmListadoPagos_Load(object sender, EventArgs e)
        {
            Refrescar();
            xRuc.MaxWidth = 75;
            xBanco.MaxWidth = 0;
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
    }
}

