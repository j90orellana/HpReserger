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
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using System.IO;
using System.Diagnostics;

namespace SISGEM.ModuloFinanzas
{
    public partial class FrmCondicionesPrestamo : DevExpress.XtraEditors.XtraForm
    {
        public FrmCondicionesPrestamo()
        {
            InitializeComponent();
        }
        string nombreMutuante = "";
        private void InsertarTablaCronograma(DataTable dt)
        {
            var doc = richEditControl1.Document;

            var encontrados = doc.FindAll("{{cronograma}}", SearchOptions.None);
            if (encontrados.Length == 0) return;

            DocumentRange rango = encontrados[0];

            doc.BeginUpdate();
            doc.Delete(rango);

            Table tabla = doc.Tables.Create(rango.Start, dt.Rows.Count + 1, dt.Columns.Count);

            // Encabezados
            for (int c = 0; c < dt.Columns.Count; c++)
                doc.InsertText(tabla.Rows[0].Cells[c].Range.Start, dt.Columns[c].ColumnName);

            // Filas con formato
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    object valor = dt.Rows[r][c];
                    string texto;

                    Type tipo = dt.Columns[c].DataType;

                    if (tipo == typeof(DateTime))
                    {
                        texto = Convert.ToDateTime(valor).ToString("dd/MM/yyyy");
                    }
                    else if (tipo == typeof(decimal) || tipo == typeof(double) || tipo == typeof(float))
                    {
                        texto = Convert.ToDecimal(valor).ToString("N2");
                    }
                    else if (tipo == typeof(int) || tipo == typeof(long))
                    {
                        texto = Convert.ToInt64(valor).ToString();
                    }
                    else
                    {
                        texto = valor?.ToString() ?? "";
                    }

                    doc.InsertText(tabla.Rows[r + 1].Cells[c].Range.Start, texto);
                }
            }

            doc.EndUpdate();
        }

        private void CargarPlantilla()
        {
            using (var ms = new MemoryStream(SISGEM.Resource1.CONTRATO_MUTUO))
            {
                richEditControl1.LoadDocument(ms, DocumentFormat.OpenXml);
            }
        }

        private void FrmCondicionesPrestamo_Load(object sender, EventArgs e)
        {


        }
        private void ReemplazarContrato(HPResergerCapaLogica.Finanzas.Mutuos.ContratoMutuoEntidad c)
        {
            var doc = richEditControl1.Document;

            nombreMutuante = c.NombreMutuante;
            richEditControl1.Options.DocumentSaveOptions.CurrentFileName =  $"Contrato_Mutuo_{nombreMutuante}";


            doc.ReplaceAll("{{nombreMutuante}}", c.NombreMutuante, SearchOptions.None);
            doc.ReplaceAll("{{documentoMutuante}}", c.DocumentoMutuante, SearchOptions.None);
            doc.ReplaceAll("{{direccionMutuante}}", c.DireccionMutuante, SearchOptions.None);
            doc.ReplaceAll("{{nroCuentaMutuante}}", c.NroCuentaMutuante, SearchOptions.None);
            doc.ReplaceAll("{{nroCuentaCCIMutuante}}", c.NroCuentaCCIMutuante, SearchOptions.None);

            doc.ReplaceAll("{{nombreEmpresa}}", c.NombreEmpresa, SearchOptions.None);
            doc.ReplaceAll("{{rucEmpresa}}", c.RucEmpresa, SearchOptions.None);
            doc.ReplaceAll("{{distrito}}", c.Distrito, SearchOptions.None);
            doc.ReplaceAll("{{cuenbaBancariaEmpresa}}", c.CuentaBancariaEmpresa, SearchOptions.None);
            doc.ReplaceAll("{{direccionEmpresa}}", c.DireccionEmpresa, SearchOptions.None);
            doc.ReplaceAll("{{representanteLegal}}", c.RepresentanteLegal, SearchOptions.None);
            doc.ReplaceAll("{{dniRepresentante}}", c.DniRepresentante, SearchOptions.None);
            doc.ReplaceAll("{{partidaRegistral}}", c.PartidaRegistral, SearchOptions.None);

            doc.ReplaceAll("{{moneda}}", c.Moneda, SearchOptions.None);
            doc.ReplaceAll("{{montoMutuo}}", c.MontoMutuo.ToString("N2"), SearchOptions.None);
            doc.ReplaceAll("{{importeLetras}}", c.ImporteLetras, SearchOptions.None);

            doc.ReplaceAll("{{interes}}", c.Interes.ToString(), SearchOptions.None);
            doc.ReplaceAll("{{meses}}", c.Meses.ToString(), SearchOptions.None);
            doc.ReplaceAll("{{interesLetras}}", c.InteresLetras, SearchOptions.None);

            doc.ReplaceAll("{{impuestoAnual}}", c.ImpuestoAnual, SearchOptions.None);
            doc.ReplaceAll("{{FechaEmision}}", c.FechaEmision, SearchOptions.None);
            doc.ReplaceAll("{{fechaVencimiento}}", c.FechaVencimiento, SearchOptions.None);
            doc.ReplaceAll("{{diaPago}}", c.DiaPago.ToString(), SearchOptions.None);

            doc.ReplaceAll("{{tipoDocumento}}", c.tipoDocumento.ToString(), SearchOptions.None);
            doc.ReplaceAll("{{estadoCivil}}", c.estadoCivil.ToString(), SearchOptions.None);


        }

        public void CargarCondicionesEnRichText(HPResergerCapaLogica.Finanzas.Mutuos.ContratoMutuoEntidad contrato)
        {
            CargarPlantilla();
            ReemplazarContrato(contrato);
            InsertarTablaCronograma(contrato.Cronograma);

        }


        private void ExportarContratoPDF()
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "Archivo PDF (*.pdf)|*.pdf";
                dlg.Title = "Guardar contrato en PDF";
                dlg.FileName = $"Contrato_Mutuo_{nombreMutuante}.pdf";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string ruta = dlg.FileName;

                    // Exporta a PDF
                    richEditControl1.ExportToPdf(ruta);

                    // Verifica si se creó el archivo
                    if (File.Exists(ruta))
                    {

                        // Abre el PDF con el visor por defecto
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = ruta,
                            UseShellExecute = true
                        });
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear el archivo PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportarContratoPDF();
        }
    }
}