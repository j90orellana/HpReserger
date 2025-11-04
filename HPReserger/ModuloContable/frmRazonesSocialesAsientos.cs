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

namespace SISGEM.ModuloContable
{
    public partial class frmRazonesSocialesAsientos : DevExpress.XtraEditors.XtraForm
    {
        public frmRazonesSocialesAsientos()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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

        private void chkAgruparRucs_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool agrupar = chkAgruparRucs.Checked;
            GridView gridView1 = gridControl1.MainView as GridView;
            string NombreColumna = xRUC.FieldName;

            if (agrupar)
            {
                // Activar agrupación por "Cuenta"
                gridView1.Columns[NombreColumna].Group();
                gridView1.OptionsView.ShowGroupedColumns = true;
                gridView1.OptionsView.ShowGroupPanel = true;

                // Habilitar la visualización de summaries en grupos
                gridView1.OptionsView.ShowGroupedColumns = true;
                //gridView1.OptionsView.ShowAutoFilterRow = true;
                gridView1.OptionsView.ShowFooter = true;
                gridView1.OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;

                // Primero limpia los summaries existentes si es necesario
                gridView1.GroupSummary.Clear();
                this.xTipo.Summary.Clear();

                // Agrega el summary al GroupSummary del GridView, no a la columna
                gridView1.GroupSummary.Add(new DevExpress.XtraGrid.GridGroupSummaryItem()
                {
                    FieldName = "Tipo",  // Columna sobre la que se calcula
                    DisplayFormat = "Registros: {0}",
                    SummaryType = DevExpress.Data.SummaryItemType.Count,
                    ShowInGroupColumnFooter = gridView1.Columns["Tipo"]  // Columna donde se muestra
                });

                gridView1.GroupSummary.Add(new DevExpress.XtraGrid.GridGroupSummaryItem()
                {
                    FieldName = "RazonSocialReal",  // Columna sobre la que se calcula
                    DisplayFormat = "{0}",
                    SummaryType = DevExpress.Data.SummaryItemType.Max,
                    ShowInGroupColumnFooter = gridView1.Columns["RazonSocialReal"]  // Columna donde se muestra
                });

                this.xTipo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
                new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Tipo", "{0}")});
            }
            else
            {
                // Desactivar agrupación
                gridView1.Columns[NombreColumna].UnGroup();
                gridView1.OptionsView.ShowGroupedColumns = false;
                gridView1.OptionsView.ShowGroupPanel = false; // Opcional: oculta el panel de arrastre
            }

            // Refrescar la vista
            gridView1.BestFitColumns();
            VisualAgrupados();
        }

        private void VisualAgrupados()
        {
            if (btnExpandir.Checked)
            {
                gridView1.ExpandAllGroups(); // Si quieres expandir los grupos automáticamente
            }
            else
                gridView1.CollapseAllGroups(); // Si quieres colapsar los grupos automáticamente
        }

        private void btnExpandir_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VisualAgrupados();
        }

        private void btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CargarDatos();
        }

        private void btnReemplazarTodo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // Validación inicial de datos
                if (datos == null || datos.Rows.Count == 0)
                {
                    XtraMessageBox.Show("No se encontraron registros para procesar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Confirmación del usuario
                var confirmacion = XtraMessageBox.Show("¿Está seguro que desea actualizar todas las razones sociales identificadas como incorrectas?\n\nEsta acción no se puede deshacer.",
                                                    "Confirmar Actualización Masiva", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (confirmacion != DialogResult.Yes)
                {
                    XtraMessageBox.Show("Operación cancelada por el usuario.", "Actualización Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Ejecución del proceso
                var claseContable = new HPResergerCapaLogica.Contable.ClaseContable();
                datos = claseContable.ReemplazarRazonesSocialesCambiadas();

                // Resultados de la operación
                if (datos != null && datos.Rows.Count > 0)
                {
                    XtraMessageBox.Show($"Se actualizaron correctamente {datos.Rows.Count} registros.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Opcional: Actualizar la interfaz de usuario
                    CargarDatos();
                }
                else
                {
                    XtraMessageBox.Show("No se realizaron cambios. Verifique que existan diferencias entre los valores actuales y los correctos.",
                                      "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error inesperado: {ex.Message}\n\nDetalles técnicos:\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Opcional: Loggear el error
                //LogError(ex);
            }
        }
        DataTable datos = new DataTable();
        private void CargarDatos()
        {
            try
            {
                var claseContable = new HPResergerCapaLogica.Contable.ClaseContable();
                //int comparar = chkComparar.Checked ? 1 : 0;

                datos = claseContable.ListarRazonesSocialesCambiadas();
                gridControl1.DataSource = datos;
                gridView1.ExpandAllGroups();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmRazonesSocialesAsientos_Load(object sender, EventArgs e)
        {

            gridView1.OptionsView.EnableAppearanceOddRow = true;
            gridView1.OptionsView.EnableAppearanceEvenRow = true;
            gridView1.Appearance.OddRow.BackColor = Color.Lavender; // Color filas impares
            gridView1.Appearance.EvenRow.BackColor = Color.White;   // Color filas pares

            gridView1.Appearance.FocusedRow.BackColor = Color.LightSkyBlue;
            gridView1.Appearance.FocusedRow.Font = new Font(gridView1.Appearance.Row.Font, FontStyle.Bold);

            xRUC.OptionsColumn.AllowEdit = true;
            xRUC.OptionsColumn.ReadOnly = true;

            CargarDatos();

        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la fila actual donde se hizo clic
                var rowHandle = gridView1.FocusedRowHandle;
                var gridView = gridView1;

                // Validar que haya una fila seleccionada
                if (rowHandle < 0)
                {
                    XtraMessageBox.Show("No hay una fila seleccionada válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener todos los valores de la fila
                var numDoc = gridView.GetRowCellValue(rowHandle, "RUC")?.ToString();
                var razonSocialActual = gridView.GetRowCellValue(rowHandle, "RazonSocialGuardada")?.ToString();
                string nuevaRazonSocial = gridView.GetRowCellValue(rowHandle, "RazonSocialReal")?.ToString();
                string Tipo = gridView.GetRowCellValue(rowHandle, "Tipo")?.ToString();

                // Validar datos básicos
                if (string.IsNullOrEmpty(numDoc))
                {
                    XtraMessageBox.Show("El documento no tiene un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mostrar confirmación
                var confirmacion = XtraMessageBox.Show(
                    $"¿Desea actualizar la razón social?\n\nActual: {razonSocialActual}\nNuevo: {nuevaRazonSocial}",
                    "Confirmar Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    bool resultado = false;
                    // Ejecutar actualización
                    var claseContable = new HPResergerCapaLogica.Contable.ClaseContable();

                    if (Tipo.Contains("PROVEEDOR"))
                    {
                        //Actualizamos al proveedor
                        resultado = claseContable.ActualizarRazonSocialIndividualProveedor(numDoc);
                    }
                    else if (Tipo.Contains("EMPLEADO"))
                    {
                        resultado = claseContable.ActualizarRazonSocialIndividualEmpleado(numDoc);
                    }
                    else if (Tipo.Contains("CLIENTE"))
                        resultado = claseContable.ActualizarRazonSocialIndividualCliente(numDoc);

                    if (resultado)
                    {
                        CargarDatos();
                    }
                    else
                    {
                        XtraMessageBox.Show("No se pudo completar la actualización.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error al procesar la solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}