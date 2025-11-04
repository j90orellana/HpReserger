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
using DevExpress.XtraPrinting;
using DevExpress.Export;

namespace SISGEM.ModuloContable
{
    public partial class xfrmCuentasSinUsar : DevExpress.XtraEditors.XtraForm
    {
        public xfrmCuentasSinUsar()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPResergerCapaLogica.Contable.Contabilidad cclase = new HPResergerCapaLogica.Contable.Contabilidad();
            gridControl1.DataSource = cclase.ListarCuentasSinUsarEnEFyER();
        }

        private void btnexportarexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportarGridAExcel();
        }

        private void ExportarGridAExcel()
        {
            try
            {
                // Obtener la fecha actual en formato yyyyMMdd
                string fecha = DateTime.Now.ToString("yyyyMMdd");
                string NombreFormulario = this.Text;
                // Definir el nombre del archivo con la fecha
                string nombreArchivo = $"{NombreFormulario}- {fecha}.xlsx";

                // Mostrar diálogo para seleccionar la ubicación del archivo
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Title = "Guardar archivo Excel",
                    FileName = nombreArchivo,
                    Filter = "Archivos Excel (*.xlsx)|*.xlsx"
                };

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



                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Exportar el GridControl a Excel
                    gridControl1.ExportToXlsx(saveFileDialog.FileName, options);

                    //HPResergerFunciones.Exportador.RecorrerExcel(saveFileDialog.FileName, options.SheetName);

                    // Abrir el archivo después de la exportación (Opcional)
                    if (XtraMessageBox.Show("Exportación exitosa. ¿Desea abrir el archivo?", "Exportar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                XtraMessageBox.Show($"Error al exportar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}