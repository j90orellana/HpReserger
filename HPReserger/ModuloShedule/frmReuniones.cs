using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
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
    public partial class frmReuniones : XtraForm
    {
        public frmReuniones()
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
        {   // Preguntar al usuario la ubicación de guardado
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Reporte Reuniones.xlsx";
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            HpResergerNube.SCH_Reuniones obclase = new HpResergerNube.SCH_Reuniones();

            DateTime FechaDe = (DateTime)dtpfechade.EditValue < (DateTime)dtpfechaa.EditValue ? (DateTime)dtpfechade.EditValue : (DateTime)dtpfechaa.EditValue;
            DateTime Fechaa = (DateTime)dtpfechade.EditValue > (DateTime)dtpfechaa.EditValue ? (DateTime)dtpfechade.EditValue : (DateTime)dtpfechaa.EditValue;
            gridControl1.DataSource = obclase.GetReunionesByClienteYFecha(FechaDe, Fechaa);
        }

        private void frmReuniones_Load(object sender, EventArgs e)
        {
            // Obtener el año actual
            int currentYear = DateTime.Today.Year;
            dtpfechade.EditValue = new DateTime(currentYear, 1, 1);
            dtpfechaa.EditValue = new DateTime(currentYear, 12, 31);


            //CLIENTE
            HpResergerNube.CRM_ClienteRepository ocliente = new HpResergerNube.CRM_ClienteRepository();
            DataTable tcliente = ocliente.FilterClientesByDateRange(DateTime.MinValue, DateTime.MaxValue);
            repositoryItemSearchCliente.DataSource = tcliente;
            repositoryItemSearchCliente.DisplayMember = "nombrecompleto";
            repositoryItemSearchCliente.ValueMember = "ID_Cliente";

            //CONTACTO
            HpResergerNube.CRM_ContactoRepository ocontacto = new HpResergerNube.CRM_ContactoRepository();
            DataTable Tcontacto = ocontacto.GetAllContactos();
            repositoryItemCheckedComboBoxParticipantes.DataSource = Tcontacto;
            repositoryItemCheckedComboBoxParticipantes.DisplayMember = "NombreCompleto";
            repositoryItemCheckedComboBoxParticipantes.ValueMember = "ID_Contacto";

            simpleButton1.PerformClick();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null && view.FocusedRowHandle >= 0 && view.FocusedColumn != null)
            {
                object cellValue = view.GetRowCellValue(view.FocusedRowHandle, xid.FieldName);
                frmAgendarCita xAgenda = new frmAgendarCita();
                xAgenda.idAgenda = (int)cellValue;
          xAgenda.MdiParent  = this.MdiParent;
                xAgenda.Show();
            }
        }

        private void btnAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAgendarCita xAgenda = new frmAgendarCita();
            xAgenda.idAgenda = 0;
            xAgenda.MdiParent = this.MdiParent;
            xAgenda.Show();
        }
    }
}
