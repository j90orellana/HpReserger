using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Layout;
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

namespace SISGEM.ModuloShedule
{
    public partial class frmPendienteReuniones : XtraForm
    {
        public frmPendienteReuniones()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportarGridControlAExcel(gridControl2);

        }
        public void ExportarGridControlAExcel(GridControl gridControl)
        {
            // Preguntar al usuario la ubicación de guardado
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Reporte Seguimientos.xlsx";
            saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (this.layoutView1 == null)
                        return;
                    this.layoutView1.ExportToXlsx(saveFileDialog.FileName);
                    int num = (int)XtraMessageBox.Show("Los datos se han exportado exitosamente a Excel.", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Process.Start(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    int num = (int)XtraMessageBox.Show("Hubo un error al exportar los datos a Excel: " + ex.Message, "Error de Exportación", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                int num1 = (int)XtraMessageBox.Show("La exportación ha sido cancelada.", "Operación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void frmPendienteReuniones_Load(object sender, EventArgs e)
        {
            dtpFechade.EditValue = HpResergerNube.DLConexion.ObtenerPrimerDiaDelMes(DateTime.Now);
            dtpFechaa.EditValue = DateTime.Now.AddDays(15);

            CargarDatos();
        }
        private void CargarDatos()
        {
            //if (VerTodoslosRegistros == 1)
            //{
            HpResergerNube.SCH_Reuniones objclase = new HpResergerNube.SCH_Reuniones();
            this.gridControl2.DataSource = objclase.FilterReunionesBySeguimiento(((DateTime)this.dtpFechade.EditValue).Date, ((DateTime)this.dtpFechaa.EditValue).Date);

            //(object)new CRM_SeguimientoRepository().FilterSeguimientosByDateRange(((DateTime)this.dtpFechade.EditValue).Date, ((DateTime)this.dtpFechaa.EditValue).Date, this.Usuario_CreacionTextEdit.EditValue != null ? this.Usuario_CreacionTextEdit.EditValue.ToString() : "0", this.ID_ProyectoTextEdit.EditValue != null ? this.ID_ProyectoTextEdit.EditValue.ToString() : "0");
            //}
            //else
            //    this.gridControl2.DataSource = (object)new CRM_SeguimientoRepository().FilterSeguimientosByDateRangeUnicos(((DateTime)this.dtpFechade.EditValue).Date, ((DateTime)this.dtpFechaa.EditValue).Date, this.Usuario_CreacionTextEdit.EditValue != null ? this.Usuario_CreacionTextEdit.EditValue.ToString() : "0", this.ID_ProyectoTextEdit.EditValue != null ? this.ID_ProyectoTextEdit.EditValue.ToString() : "0");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void layoutView1_DoubleClick(object sender, EventArgs e)
        {
            if (!(sender is LayoutView layoutView) || layoutView.FocusedRowHandle < 0 || layoutView.FocusedColumn == null)
                return;
            object rowCellValue = layoutView.GetRowCellValue(layoutView.FocusedRowHandle, "fkid");
            int result = 0;
            if (rowCellValue != null && int.TryParse(rowCellValue.ToString(), out result))
            {
                frmAgendarCita xAgenda = new frmAgendarCita();
                xAgenda.idAgenda = (int)result;
                xAgenda.MdiParent = this.MdiParent;
                xAgenda.Show();
            }
        }
    }
}
