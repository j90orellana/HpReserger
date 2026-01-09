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
using HpResergerNube;
using DevExpress.XtraPrinting;
using DevExpress.Export;

namespace SISGEM.CRM
{
    public partial class frmSeguimientos : DevExpress.XtraEditors.XtraForm
    {
        public frmSeguimientos()
        {
            InitializeComponent();
        }

        private void frmSeguimientos_Load(object sender, EventArgs e)
        {
            dtpFechade.EditValue = new DateTime(DateTime.Now.Year, 1, 1);
            dtpFechaa.EditValue = DateTime.Now;

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            DataTable Tdatos = new CRM_SeguimientoRepository().FilterSeguimientosByDateRange(((DateTime)this.dtpFechade.EditValue).Date, ((DateTime)this.dtpFechaa.EditValue).Date, "0", "0");
            gridControl1.DataSource = Tdatos;

            XDetalle_Tipo_Seguimiento.FieldName = "Detalle_Tipo_Seguimiento";
            xSaldo_Dolares.Visible = false;
            xFecha_Seguimiento.FieldName = "Fecha_Seguimiento";
            xFecha_Prox_Seguimiento.FieldName = "Fecha_Prox_Seguimiento";
            xDescripcion.FieldName = "Descripcion";


            gridView1.BestFitColumns();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                string nombreArchivo = $"Listado de Seguimientos - {fecha}.xlsx";
                string NombreFormulario = this.Text;

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
                    XlsxExportOptionsEx options = new XlsxExportOptionsEx()
                    {
                        ExportType = ExportType.WYSIWYG, // Usar DataAware en lugar de WYSIWYG
                        ShowGridLines = true,
                        AllowGrouping = DevExpress.Utils.DefaultBoolean.True,
                        AllowFixedColumns = DevExpress.Utils.DefaultBoolean.True,
                        TextExportMode = TextExportMode.Text,
                        SheetName = NombreFormulario,
                        FitToPrintedPageWidth = true,
                        RawDataMode = false,
                        ExportHyperlinks = false

                    };

                    options.DocumentOptions.Author = "j90orellana@hotmail.com";
                    options.DocumentOptions.Title = NombreFormulario;
                    options.DocumentOptions.Subject = NombreFormulario;

                    gridControl1.ExportToXlsx(saveFileDialog.FileName, options);


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
    }
}