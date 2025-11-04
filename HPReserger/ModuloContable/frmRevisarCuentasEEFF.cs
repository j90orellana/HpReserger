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
using DevExpress.XtraGrid;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.Export;

namespace SISGEM.ModuloContable
{
    public partial class frmRevisarCuentasEEFF : DevExpress.XtraEditors.XtraForm
    {
        public frmRevisarCuentasEEFF()
        {
            InitializeComponent();
        }

        public string NombreEmpresa { get; internal set; } = "SIN NOMBRE";
        public int idEmpresa { get; internal set; } = 0;
        public DateTime Fecha { get; internal set; } = DateTime.Now;
        public int Tipo { get; set; } = 0;
        private void btnRevisar_Click(object sender, EventArgs e)
        {
            Generar();
            CalcularDuplicados();
        }
        HashSet<string> duplicados;
        private void CalcularDuplicados()
        {
            duplicados = new HashSet<string>(
               tdata.AsEnumerable()
               .Where(r => !string.IsNullOrWhiteSpace(r["Cuenta_Contable"].ToString()))
               .GroupBy(r => r["Cuenta_Contable"].ToString())
               .Where(g => g.Count() > 1)
               .Select(g => g.Key)
           );
        }
        DataTable tdata;
        private void Generar()
        {
            if (!(idEmpresa > 0))
            {
                MessageBox.Show("Por favor, seleccione una empresa válida antes de continuar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HPResergerCapaLogica.Contable.Contabilidad cclase = new HPResergerCapaLogica.Contable.Contabilidad();

            if (Tipo == 1) // estado de resultados
            {
                tdata = cclase.RevisarCuentasEERR(idEmpresa, Fecha);
                gridControl1.DataSource = tdata;
            }
            else  //estados financieros
            {
                tdata = cclase.RevisarCuentasEEFF(idEmpresa, Fecha);
                gridControl1.DataSource = tdata;
            }
        }

        private void frmRevisarCuentasEEFF_Load(object sender, EventArgs e)
        {
            dtpfechaa.EditValue = Fecha;
            textEdit1.EditValue = NombreEmpresa;

            this.Text = "Revisar Cuentas de los Estados Financieros";

            if (Tipo == 1)
            {
                this.Text = "Revisar Cuentas de los Estados de Resultados";
            }
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void chkFiltrarDatos_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnexportarexcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var exporter = new GridExporter(gridControl1, gridView1, NombreEmpresa, Tipo);
            exporter.ExportarAExcel();
        }
        public class GridExporter
        {
            private readonly GridControl _gridControl;
            private readonly GridView _gridview;
            private readonly string _cuo;
            private readonly string _appDataPath;
            private readonly string _nombreEmpresa;

            private readonly int _tipo;
            public GridExporter(GridControl gridControl, GridView gridview, string nombreempresa, int tipo)
            {

                _gridControl = gridControl ?? throw new ArgumentNullException(nameof(gridControl));
                _gridview = gridview ?? throw new ArgumentNullException(nameof(gridview));
                _appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "");
                _nombreEmpresa = nombreempresa;

                _tipo = tipo;

                // Crear directorio si no existe
                if (!Directory.Exists(_appDataPath))
                {
                    Directory.CreateDirectory(_appDataPath);
                }
            }
            private bool ValidarDatos()
            {
                if (_gridControl.DataSource == null || _gridControl.MainView.RowCount == 0)
                {
                    MessageBox.Show("No se puede exportar porque la grilla no contiene datos.",
                                  "Exportación cancelada",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            private void MostrarError(string mensaje)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            private void AbrirArchivo(string filePath)
            {
                try
                {
                    if (File.Exists(filePath))
                    {
                        System.Diagnostics.Process.Start(filePath);
                        //MessageBox.Show($"Archivo exportado correctamente:\n{filePath}",
                        //"Éxito",
                        //                MessageBoxButtons.OK,
                        //                MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MostrarError($"Error al abrir el archivo: {ex.Message}");
                }
            }

            public void ExportarAExcel()
            {
                if (!ValidarDatos())
                    return;

                string filePath = Path.Combine(_appDataPath, $"Revision de cuentas de EE{(_tipo == 1 ? "RR" : "FF")} {_cuo}.xls");

                try
                {
                    var options = new XlsExportOptionsEx
                    {
                        ExportType = ExportType.WYSIWYG,
                        ShowGridLines = true,
                        TextExportMode = TextExportMode.Text,
                        SheetName = $"Revisión de Cuentas de EE{(_tipo == 1 ? "RR" : "FF")}",
                        FitToPrintedPageWidth = true,
                        RawDataMode = false,
                        ExportHyperlinks = false,
                        DocumentOptions = {
                                        Author = "j90orellana@hotmail.com",
                                        Title = $"Reporte de cuentas de EE{(_tipo == 1 ? "RR" : "FF")}",
                                        Subject = $"Revisión detallada de cuentas de EE{(_tipo == 1 ? "RR" : "FF")}"
                        }

                    };

                    // Validar si el archivo existe y está abierto
                    if (File.Exists(filePath))
                    {
                        try
                        {
                            // Intenta abrir el archivo en modo exclusivo
                            using (var file = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                            {
                                // Si no hay excepción, el archivo no está bloqueado
                            }
                        }
                        catch (IOException)
                        {
                            // El archivo está abierto/bloqueado
                            XtraMessageBox.Show("El archivo está abierto en otro programa. Ciérrelo antes de continuar.", "Archivo en Uso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Salir sin exportar
                        }
                    }
                    _gridControl.ExportToXls(filePath, options);

                    AbrirArchivo(filePath);
                }
                catch (Exception ex)
                {
                    MostrarError($"Error al exportar a Excel: {ex.Message}");
                }
            }
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "Cuenta_Contable")
            {
                string valor = gridView1.GetRowCellDisplayText(e.RowHandle, e.Column);
                if (duplicados.Contains(valor))
                {
                    e.Appearance.BackColor = Color.Yellow;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }
            }
        }
    }
}