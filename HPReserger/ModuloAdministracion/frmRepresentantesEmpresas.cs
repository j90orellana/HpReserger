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

namespace SISGEM.ModuloAdministracion
{
    public partial class frmRepresentantesEmpresas : DevExpress.XtraEditors.XtraForm
    {
        public string ruc { get; set; } = "";
        public frmRepresentantesEmpresas()
        {
            InitializeComponent();
        }
        //public class Representante
        //{
        //    public string TipoDeDocumento { get; set; }
        //    public string NumeroDeDocumento { get; set; }
        //    public string Nombre { get; set; }
        //    public string Cargo { get; set; }
        //    public string FechaDesde { get; set; }
        //}

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Consultar();
        }
        private BindingList<FactilizaApiClient.RepresentanteData> _listaRepresentantes = new BindingList<FactilizaApiClient.RepresentanteData>();

        private async void Consultar()
        {
            if (ruc.Length != 11)
            {
                XtraMessageBox.Show("El RUC debe tener exactamente 11 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                var representantes = await FactilizaApiClient.GetRepresentantesAsync(ruc);

                _listaRepresentantes.Clear(); // Limpiamos los datos anteriores

                foreach (var rep in representantes)
                {
                    _listaRepresentantes.Add(rep);
                }
                gridControl1.DataSource = _listaRepresentantes;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        private void ExportarRepresentantesAExcel(string ruc)
        {
            if (string.IsNullOrWhiteSpace(ruc) || ruc.Length != 11)
            {
                XtraMessageBox.Show("El RUC debe tener exactamente 11 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Guardar archivo de Excel";
            saveDialog.Filter = "Archivos Excel (*.xls)|*.xls";
            saveDialog.FileName = $"Representantes de {ruc}.xls";

            var options = new XlsExportOptionsEx
            {
                ExportType = ExportType.WYSIWYG,
                ShowGridLines = true,
                TextExportMode = TextExportMode.Text,
                SheetName = "Representantes",
                FitToPrintedPageWidth = true,
                RawDataMode = false,
                ExportHyperlinks = false,
                DocumentOptions = {
                                        Author = "j90orellana@hotmail.com",
                                        Title = $"Representantes de {ruc}",
                                        Subject = $"Listado de Representantes de {ruc}"
                        }

            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    gridControl1.ExportToXls(saveDialog.FileName, options);
                    //XtraMessageBox.Show("Exportación completada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Abrir automáticamente el archivo
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = saveDialog.FileName,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error al exportar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportarRepresentantesAExcel(ruc);
        }

        private void frmRepresentantesEmpresas_Load(object sender, EventArgs e)
        {
            labelruc.Caption = $"Ruc: {ruc}";
        }
    }
}