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
using DevExpress.Utils;

namespace SISGEM.ModuloCompras
{
    public partial class frmReportexProyectos : DevExpress.XtraEditors.XtraForm
    {
        public frmReportexProyectos()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmReportexProyectos_Load(object sender, EventArgs e)
        {
            CargarDatos();

            ToolTipTitleItem title = new ToolTipTitleItem();
            title.Text = "Filtro de Cuentas";

            ToolTipItem item = new ToolTipItem();
            item.LeftIndent = 6;
            item.Text =
            "• Cuentas: 1041110;1041202\n" +
            "• Rangos: 104-422\n" +
            "• Puede combinar ambos";

            SuperToolTip superTip = new SuperToolTip();
            superTip.Items.Add(title);
            superTip.Items.Add(item);

            txtcuentas.SuperTip = superTip;
        }

        private void CargarDatos()
        {

            // Obtener el año actual
            int currentYear = DateTime.Today.Year;
            dtpfechade.EditValue = new DateTime(currentYear, 1, 1);
            dtpfechaa.EditValue = new DateTime(currentYear, 12, 31);


            HPResergerCapaLogica.HPResergerCL oCL = new HPResergerCapaLogica.HPResergerCL();
            DataTable tData = oCL.Empresa();

            cboempresa.Properties.DataSource = tData;
            cboempresa.Properties.DisplayMember = "descripcion";
            cboempresa.Properties.ValueMember = "codigo";
        }

        private void btnBuscarA_Click(object sender, EventArgs e)
        {

            HPResergerCapaLogica.Compras.FacturaManual CFactura = new HPResergerCapaLogica.Compras.FacturaManual();

            // Obtener fechas
            DateTime fecha1 = Convert.ToDateTime(dtpfechade.EditValue);
            DateTime fecha2 = Convert.ToDateTime(dtpfechaa.EditValue);

            // Asegurar que fechaDesde sea la menor y fechaHasta la mayor
            DateTime fechaDesde = fecha1 < fecha2 ? fecha1 : fecha2;
            DateTime fechaHasta = fecha1 > fecha2 ? fecha1 : fecha2;

            // Obtener valores de los filtros, asegurando que no sean nulos
            string cuentas = txtcuentas.EditValue?.ToString() ?? string.Empty;
            string empresa = cboempresa.EditValue?.ToString() ?? string.Empty;
            string glosa = txtglosa.EditValue?.ToString() ?? string.Empty;
            string nrocomprobante = txtNumeroComprobante.EditValue?.ToString() ?? string.Empty;
            string razonsocial = txtRazonSocial.EditValue?.ToString() ?? string.Empty;



            // Llamar a la consulta con las fechas ordenadas
            DataTable tdata = CFactura.BuscarLibroMayorxProyecto(fechaDesde, fechaHasta, empresa, cuentas, glosa, razonsocial, nrocomprobante);
            gridControl1.DataSource = tdata;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                string nombreArchivo = $"Reporte por Proyecto - {fecha}.xlsx";

                // Mostrar diálogo para seleccionar la ubicación del archivo
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Title = "Guardar archivo Excel",
                    FileName = nombreArchivo,
                    Filter = "Archivos Excel (*.xlsx)|*.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string NombreFormulario = this.Text;

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

        private void btnBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnBuscarA.PerformClick();
        }
    }
}