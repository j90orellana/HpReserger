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
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.Export;

namespace SISGEM.ModuloContable
{
    public partial class frmSaldoCuentasContables : DevExpress.XtraEditors.XtraForm
    {
        public frmSaldoCuentasContables()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportarExcel();
        }

        private void frmSaldoCuentasContables_Load(object sender, EventArgs e)
        {
            // Mostrar solo Mes y Año en el campo
            dtpfecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtpfecha.Properties.DisplayFormat.FormatString = "MMMM yyyy";  // Ej: "Mayo 2025"

            dtpfecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtpfecha.Properties.EditFormat.FormatString = "MMMM yyyy";

            dtpfecha.Properties.Mask.EditMask = "MMMM yyyy";
            dtpfecha.Properties.Mask.UseMaskAsDisplayFormat = true;

            // Cambiar el tipo de vista del calendario a Vista de Meses (evita días)
            dtpfecha.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;

            // Esto permite que el usuario solo elija el mes (de la vista anual)
            dtpfecha.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            dtpfecha.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;


            CargarEmpresas();
        }

        private void cboEmpresa_EditValueChanged(object sender, EventArgs e)
        {
            CargarCuentas();
            Cargarfechas();

            dtpfecha.EditValue = DateTime.Now;
        }


        private void CargarEmpresas()
        {
            HPResergerCapaLogica.HPResergerCL oCL = new HPResergerCapaLogica.HPResergerCL();
            DataTable tData = oCL.Empresa();

            cboEmpresa.Properties.DataSource = tData;
            cboEmpresa.Properties.DisplayMember = "descripcion";
            cboEmpresa.Properties.ValueMember = "codigo";

            // Limpiar y configurar columnas manualmente
            cboEmpresa.Properties.Columns.Clear();

            // Agregar la columna "descripcion" y ocultar todas las demás
            foreach (DataColumn column in tData.Columns)
            {
                var lookupColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(column.ColumnName, column.ColumnName);
                lookupColumn.Visible = column.ColumnName == "descripcion"; // Solo la columna "descripcion" será visible
                cboEmpresa.Properties.Columns.Add(lookupColumn);
            }

            // Personalizar el encabezado de la columna visible
            cboEmpresa.Properties.Columns["descripcion"].Caption = "Empresa";

            // Seleccionar el primer registro si existen filas
            if (tData.Rows.Count > 0)
            {
                cboEmpresa.EditValue = tData.Rows[0]["codigo"]; // Asigna el primer valor de "codigo"
            }

            // Otras opciones de personalización
            cboEmpresa.Properties.ShowHeader = true; // Mostrar encabezado de columnas
            cboEmpresa.Properties.ShowFooter = false; // Ocultar pie de página
            cboEmpresa.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup; // Ajustar ancho automático
        }

        private void CargarCuentas()
        {
            if (cboEmpresa.Text != "")
            {
                int idEmpresa = (int)cboEmpresa.EditValue;
                HPResergerCapaLogica.Contable.ClaseContable cclase = new HPResergerCapaLogica.Contable.ClaseContable();
                DataTable tData = cclase.ListarCuentasUsadas2Digitos(idEmpresa);

                cbocuentas.Properties.DataSource = tData;
                cbocuentas.Properties.ValueMember = "CUENTA";
                cbocuentas.Properties.DisplayMember = "CUENTA";

                if (tData.Rows.Count != 0)
                    cbocuentas.EditValue = tData.Rows[0]["CUENTA"];
            }
        }


        private void Cargarfechas()
        {
            if (cboEmpresa.Text != "")
            {
                int idEmpresa = (int)cboEmpresa.EditValue;
                HPResergerCapaLogica.Contable.ClaseContable cclase = new HPResergerCapaLogica.Contable.ClaseContable();
                DataTable tData = cclase.ListarFechasDisponibles(idEmpresa);

                //cbocuentas.Properties.DataSource = tData;
                //cbocuentas.Properties.ValueMember = "FECHA";
                //cbocuentas.Properties.DisplayMember = "FECHA";

                dtpfecha.Properties.MaxValue = (DateTime)tData.Rows[0]["FECHA"];
                dtpfecha.Properties.MinValue = (DateTime)tData.Rows[tData.Rows.Count - 1]["FECHA"];

                if (fechasPermitidas != null)
                {
                    fechasPermitidas.Clear();
                }
                fechasPermitidas = tData.AsEnumerable()
                              .Select(r => r.Field<DateTime>("FECHA"))
                              .ToList();

                dtpfecha.DisableCalendarDate += Calendar_DisableCalendarDate;


            }
        }
        List<DateTime> fechasPermitidas;
        private void Calendar_DisableCalendarDate(object sender, DevExpress.XtraEditors.Calendar.DisableCalendarDateEventArgs e)
        {
            // Solo permitir las fechas exactas de la lista
            if (!fechasPermitidas.Contains(e.Date.Date))
            {
                e.IsDisabled = true;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Generar();
        }
        private bool ValidarDatos()
        {
            if (gridControl1.DataSource == null || gridControl1.MainView.RowCount == 0)
            {
                MessageBox.Show("No se puede exportar porque la grilla no contiene datos.", "Exportación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        string DataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "");

        private void ExportarExcel()
        {
            if (!ValidarDatos())
                return;

            string filePath = Path.Combine(DataPath, $"Saldo de Cuentas { cboEmpresa.Text.ToString()}-{cbocuentas.Text.ToString()}-{((DateTime)dtpfecha.EditValue).ToString("MMM yyyy")}.xls");

            try
            {
                var options = new XlsExportOptionsEx
                {
                    ExportType = ExportType.WYSIWYG,
                    ShowGridLines = true,
                    TextExportMode = TextExportMode.Text,
                    SheetName = "Saldo de Cuentas",
                    FitToPrintedPageWidth = true,
                    RawDataMode = false,
                    ExportHyperlinks = false,
                    DocumentOptions = {
                                        Author = "j90orellana@hotmail.com",
                                        Title = "Saldo de Cuentas",
                                        Subject = "Saldo de Cuentas"
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
                gridControl1.ExportToXls(filePath, options);
                AbrirArchivo(filePath);
            }
            catch (Exception ex)
            {
                MostrarError($"Error al exportar a Excel: {ex.Message}");
            }
        }
        private void AbrirArchivo(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    System.Diagnostics.Process.Start(filePath);
                }
            }
            catch (Exception ex)
            {
                MostrarError($"Error al abrir el archivo: {ex.Message}");
            }
        }
        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Generar()
        {
            if (string.IsNullOrWhiteSpace(cboEmpresa.Text))
            {
                XtraMessageBox.Show("Por favor, seleccione una empresa.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cbocuentas.Text))
            {
                XtraMessageBox.Show("Por favor, seleccione una cuenta contable.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpfecha.EditValue == null)
            {
                XtraMessageBox.Show("Por favor, seleccione una fecha válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            HPResergerCapaLogica.Contable.ClaseContable cclase = new HPResergerCapaLogica.Contable.ClaseContable();
            int idEmpresa = (int)cboEmpresa.EditValue;
            string cuentas = cbocuentas.Text;
            DateTime date = (DateTime)dtpfecha.EditValue;

            DataTable tData = cclase.ListarSaldodelasCuentas(idEmpresa, cuentas, date, out string Result);
            if (Result != string.Empty)
            {
                XtraMessageBox.Show($"{Result}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                gridControl1.DataSource = tData;

                gridView1.BestFitColumns();
                gridView1.ExpandAllGroups();
            }
        }

        private void btnAgrupar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.DataRowCount != 0)
            {
                gridView1.ExpandAllGroups();
            }
        }

        private void btnDesAgrupar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.DataRowCount != 0)
            {
                gridView1.CollapseAllGroups();
            }
        }

        private void btnBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Generar();
        }
      
         
        private void btnConsolidar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Obtener los índices de las filas seleccionadas con checkbox
            int[] selectedRowHandles = gridView1.GetSelectedRows();

            // Validar si hay filas seleccionadas
            if (selectedRowHandles == null || selectedRowHandles.Length == 0)
            {
                XtraMessageBox.Show("Debe seleccionar al menos una fila para consolidar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener la fila con foco
            int focusedRowHandle = gridView1.FocusedRowHandle;
            if (focusedRowHandle < 0)
            {
                XtraMessageBox.Show("No hay una fila enfocada válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRowView focusDataRow = gridView1.GetRow(focusedRowHandle) as DataRowView;
            if (focusDataRow == null)
            {
                XtraMessageBox.Show("No se pudo obtener la fila enfocada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Datos de la fila con foco
            string FComprobante = $"{focusDataRow["Cod_Comprobante"]} - {focusDataRow["Num_Comprobante"]}";
            string FRazon = focusDataRow["Razon_Social"].ToString();
            int FTipo = Convert.ToInt32(focusDataRow["Tipo"]);
            string FNumero = focusDataRow["Numero"].ToString();
            int FIdComprobante = Convert.ToInt32(focusDataRow["IdComprobante"]);
            string FCod_Comprobante = focusDataRow["Cod_Comprobante"].ToString();
            string FNum_Comprobante = focusDataRow["Num_Comprobante"].ToString();

            DialogResult DResult = XtraMessageBox.Show($"¿Está seguro de consolidar en un solo documento?\n\nRazón Social: {FRazon}\nComprobante: {FComprobante}\nTotal Comprobantes Afectados:({selectedRowHandles.Count(n => n >= 0)})", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DResult == DialogResult.Yes)
            {
                int actualizados = 0;
                foreach (int rowHandle in selectedRowHandles)
                {
                    if (rowHandle < 0)
                        continue;

                    DataRowView selectedDataRow = gridView1.GetRow(rowHandle) as DataRowView;
                    if (selectedDataRow == null)
                        continue;

                    try
                    {
                        // Datos originales de la fila seleccionada
                        int idProyecto = Convert.ToInt32(selectedDataRow["idProyecto"]);
                        string cuenta = selectedDataRow["IdCuentaContable"].ToString();
                        DateTime fechaAsiento = Convert.ToDateTime(selectedDataRow["FechaAsiento"]);

                        int ATipo = Convert.ToInt32(selectedDataRow["Tipo"]);
                        int AIdComprobante = Convert.ToInt32(selectedDataRow["IdComprobante"]);
                        string ACod_Comprobante = selectedDataRow["Cod_Comprobante"].ToString();
                        string ANum_Comprobante = selectedDataRow["Num_Comprobante"].ToString();
                        string ANumero = selectedDataRow["Numero"].ToString();
                        string ARazon_Social = selectedDataRow["Razon_Social"].ToString();
                        // Lógica de actualización
                        HPResergerCapaLogica.Contable.ClaseContable cclase = new HPResergerCapaLogica.Contable.ClaseContable();
                        bool exito = cclase.UpdateAsientoContableAux(idProyecto, fechaAsiento, cuenta, FTipo, FNumero, FRazon, FIdComprobante, FCod_Comprobante, FNum_Comprobante, ATipo,
                            ANumero, ARazon_Social, AIdComprobante, ACod_Comprobante, ANum_Comprobante);

                        if (exito)
                        {
                            // Reflejar los cambios en la vista si la actualización fue exitosa
                            selectedDataRow["Tipo"] = FTipo;
                            selectedDataRow["Numero"] = FNumero;
                            selectedDataRow["Razon_Social"] = FRazon;
                            selectedDataRow["IdComprobante"] = FIdComprobante;
                            selectedDataRow["Cod_Comprobante"] = FCod_Comprobante;
                            selectedDataRow["Num_Comprobante"] = FNum_Comprobante;
                            actualizados++;
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show($"Error al procesar la fila {rowHandle}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                XtraMessageBox.Show($"{actualizados} fila(s) actualizada(s) correctamente.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}