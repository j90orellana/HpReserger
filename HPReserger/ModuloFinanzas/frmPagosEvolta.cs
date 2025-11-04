using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Export;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace SISGEM.ModuloFinanzas
{
    public partial class frmPagosEvolta : DevExpress.XtraEditors.XtraForm
    {
        public frmPagosEvolta()
        {
            InitializeComponent();
        }
        DateTime fechaMenor;
        DateTime fechaMayor;
        string fechaDesdeStr;
        string fechaHastaStr;
        private async void btnDescargarEvolta_Click(object sender, EventArgs e)
        {
            btnDescargarEvolta.Enabled = false;
            try
            {
                CalcularFechas();

                // Extraer la configuración (usuario, contraseña, grant_type)
                var configuracion = new HPResergerCapaLogica.Finanzas.EvotaConfiguracion().GetFirst();

                if (configuracion == null)
                {
                    XtraMessageBox.Show("No se encontró configuración de CRM Externo.");
                    return;
                }

                // Instanciar clase Evolta
                var apiService = new HPResergerCapaLogica.Finanzas.EvoltaApiService();
                await apiService.GetTokenAsync(configuracion.Username, configuracion.Password, configuracion.GrantType);

                // Usar fechas ordenadas en la llamada
                var listaAprobados = await apiService.GetPagosAprobadosAsync(0, fechaDesdeStr, fechaHastaStr);

                //guardamos los registros
                HPResergerCapaLogica.Finanzas.EvoltaApiService cClase = new HPResergerCapaLogica.Finanzas.EvoltaApiService(true);

                foreach (var item in listaAprobados)
                {
                    item.IdUsuarioCreador = HPReserger.frmLogin.CodigoUsuario;
                    item.Numero_Pago = "";
                    item.Numero_Operacion = item.Numero_Operacion ?? "";
                    cClase.Insert(item);
                }

                CargarPagos();
            }
            catch (Exception ex)
            {
                if (ex.InnerException == null)
                {
                    XtraMessageBox.Show("No se encontraron datos", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show($"Error al descargar desde CRM Externo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnDescargarEvolta.Enabled = true;

        }

        private void CalcularFechas()
        {
            // Obtener fechas desde controles
            DateTime fecha1 = (DateTime)dtpfechadesde.EditValue;
            DateTime fecha2 = (DateTime)dtpfechahasta.EditValue;

            // Ordenar fechas (fechaMenor siempre primero)
            fechaMenor = fecha1 < fecha2 ? fecha1 : fecha2;
            fechaMayor = fecha1 > fecha2 ? fecha1 : fecha2;

            // Convertir a formato "dd-MM-yyyy"
            fechaDesdeStr = fechaMenor.ToString("dd-MM-yyyy");
            fechaHastaStr = fechaMayor.ToString("dd-MM-yyyy");
        }

        private void frmPagosEvolta_Load(object sender, EventArgs e)
        {
            var _Hoy = DateTime.Now;
            dtpfechadesde.EditValue = new DateTime(_Hoy.Year, _Hoy.Month, 1);
            dtpfechahasta.EditValue = new DateTime(_Hoy.Year, _Hoy.Month, DateTime.DaysInMonth(_Hoy.Year, _Hoy.Month));

            AgregarFormato(gridView1, "Estado", 0, ColorTranslator.FromHtml("#F8D7DA")); // Anulado - rojo suave
            AgregarFormato(gridView1, "Estado", 1, ColorTranslator.FromHtml("#FFF3CD")); // Activo - amarillo suave
            AgregarFormato(gridView1, "Estado", 2, ColorTranslator.FromHtml("#D4EDDA")); // Facturado - verde suave
            AgregarFormato(gridView1, "Estado", 3, ColorTranslator.FromHtml("#E2E3E5")); // Vacío - gris claro



        }
        private void AgregarFormato(GridView gridView, string columna, int valor, Color color)
        {
            var rule = new GridFormatRule();
            var formatCondition = new FormatConditionRuleExpression
            {
                Expression = $"[{columna}] = {valor}",
                Appearance = { BackColor = color, Options = { UseBackColor = true } }
            };
            rule.Column = gridView.Columns[columna];
            rule.Rule = formatCondition;
            rule.ApplyToRow = true;
            gridView.FormatRules.Add(rule);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarPagos();
        }

        private void CargarPagos()
        {
            CalcularFechas();

            HPResergerCapaLogica.Finanzas.EvoltaApiService cclase = new HPResergerCapaLogica.Finanzas.EvoltaApiService(true);
            gridControl1.DataSource = cclase.GetAllByFechasDataTable(fechaMenor, fechaMayor);

            gridView1.BestFitColumns(true);
        }

        private void btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CargarPagos();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la fila actual donde se hizo clic
                var rowHandle = gridView1.FocusedRowHandle;
                var gridView = gridView1;

                // Validar que haya una fila seleccionada
                if (rowHandle < 0)
                {
                    XtraMessageBox.Show("No hay una fila seleccionada válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener todos los valores de la fila
                var _id = gridView.GetRowCellValue(rowHandle, "Id")?.ToString();
                var _estado = gridView.GetRowCellValue(rowHandle, "Estado")?.ToString();

                // Validar datos básicos
                if (_estado != "1")
                {
                    XtraMessageBox.Show("El documento no esta pendiente para Facturar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mostrar confirmación
                var confirmacion = XtraMessageBox.Show($"¿Desea cambiar el Estado a Facturado", "Confirmar Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    bool resultado = false;
                    // Ejecutar actualización
                    var cClase = new HPResergerCapaLogica.Finanzas.EvoltaApiService(true);
                    var cObjeto = new HPResergerCapaLogica.Finanzas.EvoltaApiService.PagoAprobado();

                    cObjeto.Id = int.Parse(_id);
                    cObjeto.IdUsuarioPagador = HPReserger.frmLogin.CodigoUsuario;
                    cObjeto.FechaRegistro = DateTime.Now;
                    cObjeto.Estado = 2;

                    resultado = cClase.UpdatePagado(cObjeto);

                    if (resultado)
                    {
                        CargarPagos();
                    }
                    else
                    {
                        XtraMessageBox.Show("No se pudo completar la actualización.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error al procesar la solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportarExcels_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var exporter = new GridExporter(gridControl1, gridView1, fechaMenor, fechaMayor);
            exporter.ExportarAExcel();
        }
        public class GridExporter
        {
            private readonly GridControl _gridControl;
            private readonly GridView _gridview;
            private readonly string _cuo;
            private readonly string _appDataPath;
            private readonly DateTime _fechadesde;
            private readonly DateTime _fechahasta;

            public GridExporter(GridControl gridControl, GridView gridview, DateTime FechaDesde, DateTime FechaHasta)
            {

                _gridControl = gridControl ?? throw new ArgumentNullException(nameof(gridControl));
                _gridview = gridview ?? throw new ArgumentNullException(nameof(gridview));
                _appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "");

                _fechadesde = FechaDesde;
                _fechahasta = FechaHasta;

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

                string filePath = Path.Combine(_appDataPath, $"Listado de Pagos Registrados en CRM Externo de {_fechadesde.ToString("ddMMyyyy")} al {_fechahasta.ToString("ddMMyyyy")}.xls");

                try
                {
                    var options = new XlsExportOptionsEx
                    {
                        ExportType = ExportType.WYSIWYG,
                        ShowGridLines = true,
                        TextExportMode = TextExportMode.Text,
                        SheetName = $"Listado de Pagos Registrados en CRM Externo",
                        FitToPrintedPageWidth = true,
                        RawDataMode = false,
                        ExportHyperlinks = false,
                        DocumentOptions = {
                                        Author = "j90orellana@hotmail.com",
                                        Title = $"Listado de Pagos Registrados en CRM Externo de {_fechadesde.ToString("ddMMyyyy")} al {_fechahasta.ToString("ddMMyyyy")}",
                                        Subject = $"Listado de Pagos Registrados en CRM Externo de {_fechadesde.ToString("ddMMyyyy")} al {_fechahasta.ToString("ddMMyyyy")}"
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
    }

}