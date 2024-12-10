using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using HPResergerCapaLogica.Contable;
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

namespace SISGEM.ModuloAlmacen
{
    public partial class frmEmpresaAbreviada : XtraForm
    {
        public frmEmpresaAbreviada()
        {
            InitializeComponent();
        }

        private void frmEmpresaAbreviada_Load(object sender, EventArgs e)
        {
            CargaDatos();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            // Obtener los valores de la fila actual
            var rowHandle = e.RowHandle;
            int id = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "id"));
            string abreviatura = gridView1.GetRowCellValue(rowHandle, "abreviatura").ToString();
            int fk_empresa = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "Id_Empresa"));
            int usuario = HPReserger.frmLogin.CodigoUsuario;
            DateTime fecha = DateTime.Now;

            // Actualizar en la base de datos
            EmpresaAbreviatura.OEmpresaAbreviatura empresaAbreviatura = new EmpresaAbreviatura.OEmpresaAbreviatura
            {
                Id = id,
                FkEmpresa = fk_empresa,
                Abreviatura = abreviatura,
                Usuario = usuario,
                Fecha = fecha
            };
            // Instanciar el CRUD y actualizar la base de datos
            EmpresaAbreviatura crud = new EmpresaAbreviatura();
            if (id == 0)
            {
                crud.Insert(empresaAbreviatura);
                CargaDatos();
            }
            else
            {
                crud.Update(empresaAbreviatura);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CargaDatos();
        }

        private void CargaDatos()
        {
            HPResergerCapaLogica.Contable.EmpresaAbreviatura obclase = new HPResergerCapaLogica.Contable.EmpresaAbreviatura();
            gridControl1.DataSource = obclase.GetAllEmpresas();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportarGridControlAExcel(gridControl1);
        }
        public void ExportarGridControlAExcel(GridControl gridControl)
        {
            // Preguntar al usuario la ubicación de guardado
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Reporte Empresa ABC.xlsx";
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
    }
}
