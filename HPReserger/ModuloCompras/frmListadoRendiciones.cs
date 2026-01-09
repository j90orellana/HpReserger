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
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.XtraReports.UI;

namespace SISGEM.ModuloCompras
{
    public partial class frmListadoRendiciones : DevExpress.XtraEditors.XtraForm
    {
        public frmListadoRendiciones()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null && view.FocusedRowHandle >= 0 && view.FocusedColumn != null)
            {
                object cellValue = view.GetRowCellValue(view.FocusedRowHandle, xid.FieldName);
                ModuloCompras.frmRendicionesReembolso xFormularioReembolso = new frmRendicionesReembolso();
                xFormularioReembolso.idReembolso = (int)cellValue;
                //xOrdenCompra.MdiParent = this.MdiParent;
                xFormularioReembolso.Show();
            }
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
                XtraMessageBox.Show("Debe seleccionar una Rendicion válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID desde la columna "Id"
            object idValue = gv.GetRowCellValue(rowHandle, xid.FieldName);

            if (idValue == null || idValue == DBNull.Value)
            {
                XtraMessageBox.Show("La fila seleccionada no tiene un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idReembolso = Convert.ToInt32(idValue);

            // Crear instancia del reporte
            ModuloXtraReports.Compras.xReportReembolsos reporte = new ModuloXtraReports.Compras.xReportReembolsos();

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
                if (query != null)
                {
                    query.Parameters.Clear(); // Limpia los parámetros previos
                    query.Parameters.Add(new QueryParameter("@idreembolso", typeof(int), idReembolso));

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
            reporte.ExportOptions.PrintPreview.DefaultFileName = "Reporte de Rendiciones";

            // Mostrar el reporte en un visor
            ReportPrintTool printTool = new ReportPrintTool(reporte);
            printTool.ShowPreviewDialog();

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
            gridView1.Columns["nombreEmpleado"].GroupIndex = 1;
        }

        private void btnAgruparEstado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Primero limpiamos agrupaciones anteriores
            gridView1.ClearGrouping();

            gridView1.Columns["empresa"].GroupIndex = 0;
            gridView1.Columns["estado"].GroupIndex = 1;
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

        private void frmListadoRendiciones_Load(object sender, EventArgs e)
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            HPResergerCapaLogica.Contable.ReembolsosMasivos Cclase = new HPResergerCapaLogica.Contable.ReembolsosMasivos();
            DateTime fechaSeleccionada = dtpfecha.EditValue as DateTime? ?? DateTime.Now;
            gridControl1.DataSource = Cclase.ListarRendicionesporAÑo(fechaSeleccionada);
            gridView1.BestFitColumns();
        }

        private void btnVer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1_DoubleClick(gridView1, new EventArgs());

        }
    }

}