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
    public partial class frmCotizadorCRM : XtraForm
    {
        public frmCotizadorCRM()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportarGridControlAExcel(gridControl1);

        }
        public void ExportarGridControlAExcel(GridControl gridControl)
        {
            // Preguntar al usuario la ubicación de guardado
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Reporte Cotizaciones.xlsx";
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

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            CRM_Cotizador oCotizador = new CRM_Cotizador();

            DateTime editValue = (DateTime)this.dtpFechade.EditValue;
            DateTime date1 = editValue.Date;
            editValue = (DateTime)this.dtpFechaa.EditValue;
            DateTime date2 = editValue.Date;
            gridControl1.DataSource = oCotizador.FilterCotizacionesByDateRange(date1, date2);
        }

        private void frmCotizadorCRM_Load(object sender, EventArgs e)
        {
            this.dtpFechade.EditValue = (object)DLConexion.ObtenerPrimerDiaDelMes(DateTime.Now);
            this.dtpFechaa.EditValue = (object)DLConexion.ObtenerUltimoDiaDelMes(DateTime.Now);
            this.CargarDatos();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (!(sender is GridView gridView) || gridView.FocusedRowHandle < 0 || gridView.FocusedColumn == null)
                return;
            object rowCellValue = gridView.GetRowCellValue(gridView.FocusedRowHandle, this.xID_Cotización.FieldName);
            frmAddCotizacionCRM frmcotizacion = new frmAddCotizacionCRM();
            frmcotizacion._idcotizacion = rowCellValue.ToString();
            frmcotizacion.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmAddCotizacionCRM().Show();
        }
    }
}
