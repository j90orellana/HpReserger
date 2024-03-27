using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using System.Diagnostics;

namespace SISGEM.CRM
{
    public partial class frmClienteCRM : XtraForm
    {
        private string idcliente;

        public frmClienteCRM()
        {
            InitializeComponent();
        }

        private void frmClienteCRM_Load(object sender, EventArgs e)
        {
            dtpFechade.EditValue = HpResergerNube.DLConexion.ObtenerPrimerDiaDelMes(DateTime.Now);
            dtpFechaa.EditValue = HpResergerNube.DLConexion.ObtenerUltimoDiaDelMes(DateTime.Now);
            CargarDatos();
        }

        private void CargarDatos()
        {

            HpResergerNube.CRM_ClienteRepository objcliente = new HpResergerNube.CRM_ClienteRepository();

            gridControl1.DataSource = objcliente.FilterClientesByDateRange(((DateTime)dtpFechade.EditValue).Date, ((DateTime)dtpFechaa.EditValue).Date);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportarGridControlAExcel(gridControl1);
        }


        public void ExportarGridControlAExcel(GridControl gridControl)
        {
            // Preguntar al usuario la ubicación de guardado
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Reporte Clientes.xlsx";
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null && view.FocusedRowHandle >= 0 && view.FocusedColumn != null)
            {
                object cellValue = view.GetRowCellValue(view.FocusedRowHandle, xID_Cliente.FieldName);
                FrmAddCliente xcliente = new FrmAddCliente();
                xcliente._idCliente = cellValue.ToString();
                xcliente.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idcliente != "")
            {
                CRM.frmContactoCRM frmsegui = new frmContactoCRM();

                frmsegui._idcliente = idcliente;
                frmsegui.MdiParent = this.MdiParent;
                frmsegui.Show();
            }
            else
            {
                XtraMessageBox.Show("Por favor, selecciona un Cliente antes de continuar.", "Proyecto no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            GridView view = sender as GridView;

            // Verificar si se ha hecho clic en una fila válida
            if (e.RowHandle >= 0)

            {
                // Obtener el valor de la celda en la columna 1 de la fila seleccionada
                object cellValue = view.GetRowCellValue(e.RowHandle, view.Columns[xID_Cliente.FieldName]); // Cambia 1 por el índice de la columna deseada
                if (cellValue != null)
                {
                    // Hacer algo con el valor de la celda
                    idcliente = cellValue.ToString();

                }
            }
        }
    }
}
