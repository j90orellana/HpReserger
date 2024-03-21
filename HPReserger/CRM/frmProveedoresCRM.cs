using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using HpResergerNube;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISGEM.CRM
{
    public partial class frmProveedoresCRM : XtraForm
    {
        public frmProveedoresCRM()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportarGridControlAExcel(gridControl1);

        }
        public void ExportarGridControlAExcel(GridControl gridControl)
        {
            // Preguntar al usuario la ubicación de guardado
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Reporte Proveedores.xlsx";
            saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Exportar los datos del GridControl a un archivo de Excel
                    GridView gridView = (GridView)gridControl.MainView;
                    gridView.ExportToXlsx(saveFileDialog.FileName, new XlsxExportOptions() { ExportMode = XlsxExportMode.SingleFile });

                    // Mostrar un mensaje de éxito
                    XtraMessageBox.Show("Los datos se han exportado exitosamente a Excel.", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir el archivo de Excel guardado
                    Process.Start(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje en caso de error
                    XtraMessageBox.Show("Hubo un error al exportar los datos a Excel: " + ex.Message, "Error de Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar mensaje si el usuario cancela
                XtraMessageBox.Show("La exportación ha sido cancelada.", "Operación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CargarDatos()
        {
            CRM_ProveedorRepository proveedorRepository1 = new CRM_ProveedorRepository();
            GridControl gridControl2 = this.gridControl1;
            CRM_ProveedorRepository proveedorRepository2 = proveedorRepository1;
            DateTime editValue = (DateTime)this.dtpFechade.EditValue;
            DateTime date1 = editValue.Date;
            editValue = (DateTime)this.dtpFechaa.EditValue;
            DateTime date2 = editValue.Date;
            DataTable dataTable = proveedorRepository2.FilterProveedoresByDateRange(date1, date2);
            gridControl2.DataSource = (object)dataTable;
        }

        private void frmProveedoresCRM_Load(object sender, EventArgs e)
        {
            this.dtpFechade.EditValue = (object)DLConexion.ObtenerPrimerDiaDelMes(DateTime.Now);
            this.dtpFechaa.EditValue = (object)DLConexion.ObtenerUltimoDiaDelMes(DateTime.Now);
            this.CargarDatos();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.CargarDatos();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (!(sender is GridView gridView) || gridView.FocusedRowHandle < 0 || gridView.FocusedColumn == null)
                return;
            object rowCellValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, this.xID_Proveedor.FieldName);
            frmAddProveedor frmAddProveedor = new frmAddProveedor();
            frmAddProveedor._idproveedor = rowCellValue.ToString();
            frmAddProveedor.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmAddProveedor().Show();

        }
    }
}
