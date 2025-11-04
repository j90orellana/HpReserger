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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.Export;
using DevExpress.XtraEditors.Repository;

namespace SISGEM.Flujo_de_Caja
{
    public partial class frmListadoMovimientosFinanciero : DevExpress.XtraEditors.XtraForm
    {
        public frmListadoMovimientosFinanciero()
        {
            InitializeComponent();
        }

        public int SoloMovimientos = 0;
        DataTable dtPresupuestos;
        DataTable dtPresupuestosUnicos;
        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportarGridAExcel();

        }

        private void btnBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnBuscarFacturasf.PerformClick();

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
        private void frmListadoMovimientosFinanciero_Load(object sender, EventArgs e)
        {
            Refrescar();

            if (SoloMovimientos == 1)
            {
                layoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

                //layoutControlItem17.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                //layoutControlItem18.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                gridColumn17.Visible = false;

                xxTipo.Visible = true;
                xCtaBancaria.Visible = true;
                xFechaPago.Visible = true;

                xGlosa.MaxWidth = 100;

            }

            HPResergerCapaLogica.FlujoCaja.Partidas_Control cClase = new HPResergerCapaLogica.FlujoCaja.Partidas_Control();
            cClase.VerificarCrearTablaMovimientosPartida();

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

        private void btnBuscarFacturasf_Click(object sender, EventArgs e)
        {
            FiltrarFacturasDeCompra();
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

            string tipo = txttipomovimiento.EditValue?.ToString() ?? string.Empty;
            string cuentabancaria = txtCuentaBancaria.EditValue?.ToString() ?? string.Empty;

            int OcultarPP = chkPPf.Checked ? 0 : 1;
            DataTable tdata;
            // Llamar a la consulta con las fechas ordenadas
            if (SoloMovimientos == 1)
            {
                tdata = CFactura.BuscarFiltradoMovimientosFinancierosMov(fechaDesde, fechaHasta, empresa, proveedor, glosa, OcultarPP, nrocomprobante, cuentabancaria, tipo);
            }
            else  //entra directo aca para debug
                tdata = CFactura.BuscarFiltradoMovimientosFinancieros(fechaDesde, fechaHasta, empresa, proveedor, glosa, OcultarPP, nrocomprobante, cuentabancaria, tipo);
            gridControl1.DataSource = tdata;

            gridView1.BestFitColumns();
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
                        int fkid = int.Parse(view.GetRowCellValue(i, "fkid")?.ToString());
                        int fkiddet = int.Parse(view.GetRowCellValue(i, "fkiddet")?.ToString());
                        int fkproyecto = int.Parse(view.GetRowCellValue(i, "fkproyecto")?.ToString());
                        string cuenta = (view.GetRowCellValue(i, "cuenta")?.ToString());
                        DateTime fecha = DateTime.Parse(view.GetRowCellValue(i, "fecha")?.ToString());


                        HPResergerCapaLogica.FlujoCaja.FacturaPresupuesto Cclase = new HPResergerCapaLogica.FlujoCaja.FacturaPresupuesto();
                        Cclase.InsertarUpdateBuscarMovimientoFinancieros(fkid, fkiddet, fkproyecto, fecha, cuenta, idSeleccionado);

                    }
                }
                btnBuscar.PerformClick();
            }
        }

        private void ExportarGridAExcel()
        {
            try
            {
                // Obtener la fecha actual en formato yyyyMMdd
                string fecha = DateTime.Now.ToString("yyyyMMdd");

                // Definir el nombre del archivo con la fecha
                string nombreArchivo = $"Listado de Movimientos Financieros - {fecha}.xlsx";

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
        private object ObtenerDisplayMember(object id)
        {
            if (id == null) return null;

            DataRow[] resultado = dtPresupuestos.Select("id = " + id);
            return resultado.Length > 0 ? resultado[0]["Nombre"] : null;
        }

        private void btnAplicarParcialf_Click(object sender, EventArgs e)
        {
            AsignarValoresIdPP();
        }
        private void btnAplicarTodof_Click(object sender, EventArgs e)
        {
            AsignarValoresIdPP(true);
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
                // Mejor manejo de la conversión con TryParse y validación
                string idStr = view.GetRowCellValue(e.RowHandle, "fkid")?.ToString();
                if (!int.TryParse(idStr, out int fkid))
                {
                    // Manejar el error - asignar un valor por defecto o mostrar mensaje
                    fkid = 0; // o lanzar una excepción más descriptiva
                }

                string idfkiddet = view.GetRowCellValue(e.RowHandle, "fkiddet")?.ToString();
                if (!int.TryParse(idfkiddet, out int fkiddet))
                {
                    fkiddet = 0;
                }
                string fkproyectoStr = view.GetRowCellValue(e.RowHandle, "fkproyecto")?.ToString();
                if (!int.TryParse(fkproyectoStr, out int fkproyecto))
                {
                    fkproyecto = 0;
                }
                string pkidppStr = view.GetRowCellValue(e.RowHandle, "IdPP")?.ToString();
                if (!int.TryParse(pkidppStr, out int IdPP))
                {
                    IdPP = 0;
                }

                string cuenta = view.GetRowCellValue(e.RowHandle, "cuenta")?.ToString();
                DateTime fecha = (view.GetRowCellValue(e.RowHandle, "fecha") as DateTime?) ?? DateTime.MinValue;

                HPResergerCapaLogica.FlujoCaja.FacturaPresupuesto Cclase = new HPResergerCapaLogica.FlujoCaja.FacturaPresupuesto();
                Cclase.InsertarUpdateBuscarMovimientoFinancieros(fkid, fkiddet, fkproyecto, fecha, cuenta, IdPP);

            }
        }
    }
}