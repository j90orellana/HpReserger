using DevExpress.XtraEditors;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SISGEM.ModuloContable
{
    public partial class frmCargaAsientosMasivos : XtraForm
    {
        public frmCargaAsientosMasivos()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmCargaAsientosMasivos_Load(object sender, EventArgs e)
        {
            // Suponiendo que estás usando gridView1 como tu vista principal
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView1.Columns)
            {
                column.OptionsColumn.AllowEdit = false;
                //column.OptionsColumn.ReadOnly = true;
            }

            CargarCombos();
        }
        public void CargarCombos()
        {
            HPResergerCapaLogica.Mantenimiento.Empresa CEmpresa = new HPResergerCapaLogica.Mantenimiento.Empresa();
            DataTable TEmpresa = CEmpresa.GetAll();
            cboempresa.Properties.DataSource = TEmpresa;
            cboempresa.Properties.DisplayMember = "nombrecompleto";
            cboempresa.Properties.ValueMember = "Id_Empresa";
            cboempresa.EditValue = TEmpresa.Rows.Count > 0 ? TEmpresa.Rows[0]["Id_Empresa"] : null;

            cboempresa.Properties.View.Columns.Clear();
            cboempresa.Properties.View.Columns.AddVisible("RUC", "RUC");
            cboempresa.Properties.View.Columns.AddVisible("Empresa", "Empresa");
            var colRuc = cboempresa.Properties.View.Columns["RUC"];
            if (colRuc != null)
            {
                colRuc.Width = 80;
                colRuc.MinWidth = 80;
                colRuc.MaxWidth = 80;
            }

            cboempresa.Properties.View.BestFitColumns();
        }
        private void btnRecargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CargarCombos();
        }
        private DataTable LeerExcelEPPlus(string rutaArchivo)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            // Define tus columnas por tipo
            int[] columnasEnteras = { 0 };
            int[] columnasDecimales = { 5, 6, 14 };
            int[] columnasFechas = { 11, 12 };

            DataTable dt = new DataTable();

            using (var package = new ExcelPackage(new FileInfo(rutaArchivo)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                int colCount = worksheet.Dimension.End.Column;
                int rowCount = worksheet.Dimension.End.Row;

                // Leer encabezados
                for (int col = 1; col <= colCount; col++)
                {
                    string columnName = worksheet.Cells[1, col].Text.Trim();
                    if (string.IsNullOrEmpty(columnName))
                        columnName = "Columna" + col;
                    dt.Columns.Add(columnName, typeof(object)); // usaremos object para flexibilidad
                }

                // Leer datos
                for (int row = 2; row <= rowCount; row++)
                {
                    DataRow newRow = dt.NewRow();
                    for (int col = 1; col <= colCount; col++)
                    {

                        object valor = worksheet.Cells[row, col].Value;
                        string valorStr = valor?.ToString()?.Trim() ?? "";

                        // Verificar tipo según el índice
                        int colIndex = col - 1;

                        if (columnasEnteras.Contains(colIndex))
                        {
                            if (long.TryParse(valorStr, out long resultado))
                                newRow[colIndex] = resultado;
                            else
                                newRow[colIndex] = resultado;
                        }
                        else if (columnasDecimales.Contains(colIndex))
                        {
                            if (decimal.TryParse(valorStr, out decimal resultado))
                                newRow[colIndex] = resultado;
                            else
                                newRow[colIndex] = resultado;
                        }
                        else if (columnasFechas.Contains(colIndex))
                        {
                            if (DateTime.TryParse(valorStr, out DateTime fecha))
                                newRow[colIndex] = fecha;
                            else
                                newRow[colIndex] = fecha;
                        }
                        else
                        {
                            newRow[colIndex] = valorStr;
                        }
                    }


                    dt.Rows.Add(newRow);
                }
            }

            return dt;
        }
        HashSet<string> cuentasUnicas = new HashSet<string>();
        HashSet<string> rucsUnicos = new HashSet<string>();
        private bool ValidarExcel(DataTable dt)
        {
            StringBuilder resultado = new StringBuilder();
            cuentasUnicas = new HashSet<string>();
            rucsUnicos = new HashSet<string>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                int filaExcel = i + 2; // Por encabezado

                // Validar columna 0 (cuenta)
                string cuenta = row[0]?.ToString().Trim();
                if (string.IsNullOrEmpty(cuenta))
                {
                    resultado.AppendLine($"Falta la cuenta en la fila: {filaExcel}");
                }
                else
                {
                    cuentasUnicas.Add(cuenta);
                }

                // Validar columnas 2, 8, 13, 16 -> que no estén vacías y contengan '-'
                int[] columnasConGuion = { 2, 8, 13, 16 };
                foreach (int col in columnasConGuion)
                {
                    string valor = row[col]?.ToString().Trim();
                    if (string.IsNullOrEmpty(valor) || !valor.Contains("-"))
                    {
                        resultado.AppendLine($"Columna {col} en fila {filaExcel} está incompleta o no contiene '-'");
                    }
                }

                // Validar columna 14 (TC)
                string tcStr = row[14]?.ToString().Trim();
                if (string.IsNullOrEmpty(tcStr) || !decimal.TryParse(tcStr, out decimal tc) || tc == 0 || tc == 1)
                {
                    resultado.AppendLine($"TC inválido en la fila {filaExcel}. No debe estar vacío, ser 0 ni 1.");
                }

                // Validar columna 3 (RUC)
                string ruc = row[3]?.ToString().Trim();
                if (string.IsNullOrEmpty(ruc))
                {
                    resultado.AppendLine($"RUC vacío en la fila {filaExcel}");
                }
                else
                {
                    rucsUnicos.Add(ruc);
                }
            }

            HPResergerCapaDatos.HPResergerCD CapaDatos = new HPResergerCapaDatos.HPResergerCD();

            // 🔍 Validar existencia en base de datos
            foreach (string cuenta in cuentasUnicas)
            {
                if (CapaDatos.BuscarCuentasActivasDetalleQuery(cuenta).Rows.Count == 0)
                {
                    resultado.AppendLine($"La cuenta no es de tipo detalle: {cuenta}");
                }
                else if (CapaDatos.BuscarCuentasActivasQuery(cuenta).Rows.Count == 0)
                {
                    resultado.AppendLine($"La cuenta no está activa: {cuenta}");
                }
                else if (CapaDatos.BuscarCuentasQuery(cuenta).Rows.Count == 0)
                {
                    resultado.AppendLine($"La cuenta no existe: {cuenta}");

                }
            }

            foreach (string ruc in rucsUnicos)
            {
                bool esProveedor = CapaDatos.BuscarProveedorQuery(ruc).Rows.Count > 0;
                bool esCliente = CapaDatos.BuscarClienteQuery(ruc).Rows.Count > 0;
                bool esEmpleado = CapaDatos.BuscarEmpleadoQuery(ruc).Rows.Count > 0;

                if (!esProveedor && !esCliente && !esEmpleado)
                {
                    resultado.AppendLine($"No existe el proveedor, cliente o empleado: {ruc}");
                }
            }


            // Recorremos todas las filas del DataTable
            decimal totalDebe = 0.00m;
            decimal totalHaber = 0.00m;
            foreach (DataRow row in dt.Rows)
            {
                if (decimal.TryParse(row[5]?.ToString(), out decimal debe))
                    totalDebe += debe;

                if (decimal.TryParse(row[6]?.ToString(), out decimal haber))
                    totalHaber += haber;
            }

            // Validar que la diferencia sea cero
            if (Math.Round(totalDebe - totalHaber, 2) != 0)
            {
                resultado.AppendLine($"⚠️ La suma del Debe ({totalDebe:N2}) y del Haber ({totalHaber:N2}) no cuadran. Diferencia: {(totalDebe - totalHaber):N2}");
            }

            // Si hay errores
            if (resultado.Length > 0)
            {
                string mensaje = "Debe revisar el archivo que se cargó. Hay datos pendientes por corregir.";
                XtraMessageBox.Show(mensaje, "Validación de Excel", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                string path = Application.CommonAppDataPath;
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                path = Path.Combine(path, "ResultadoValidacion.txt");
                File.WriteAllText(path, resultado.ToString());

                Process.Start(path); // Esto abre el archivo con el programa predeterminado del sistema
                return false;
            }
            else
            {
                return true;
                // XtraMessageBox.Show("Archivo validado correctamente.", "Validación de Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        bool ArchivoCargado = false;
        DataTable dt;
        private void btnCargarArchivoExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos Excel|*.xls;*.xlsx",
                Title = "Seleccionar archivo Excel"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ArchivoCargado = false;
                string rutaArchivo = openFileDialog.FileName;
                dt = LeerExcelEPPlus(rutaArchivo);
                gridControl1.DataSource = dt;
                gridView1.BestFitColumns();

                ArchivoCargado = ValidarExcel(dt);
            }
        }

        private void btnGrabarAsiento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ArchivoCargado)
            {
                XtraMessageBox.Show("Primero debe cargar un archivo que haya sido validado correctamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dtpfechacontable.EditValue == null)
            {
                XtraMessageBox.Show("Debes seleccionar una fecha contable correctamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validar que se haya seleccionado una empresa
            if (string.IsNullOrWhiteSpace(cboempresa.Text))
            {
                XtraMessageBox.Show("Debe seleccionar una empresa antes de proceder con la carga masiva.", "Empresa no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que se haya seleccionado una empresa
            if (string.IsNullOrWhiteSpace(cboproyecto.Text))
            {
                XtraMessageBox.Show("Debe seleccionar un proyecto antes de proceder con la carga masiva.", "Proyecto no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación para la carga masiva
            DialogResult respuesta = XtraMessageBox.Show($"¿Está seguro de que desea proceder con la carga masiva de asientos para la empresa \"{cboempresa.Text}\"?",
                "Confirmar carga masiva", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                // Aquí llamas a tu método de carga masiva
                CargarAsientos();
            }
            else
            {
                XtraMessageBox.Show("La operación ha sido cancelada por el usuario.", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public int GetNumAsiento(DateTime FechaContable)
        {
            HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();

            int numasiento = 0;
            if (numasiento == 0)
            {
                DataTable asientito = CapaLogica.UltimoAsiento((int)cboempresa.EditValue, FechaContable);
                DataRow asiento = asientito.Rows[0];
                if (asiento == null) { numasiento = 1; }
                else
                    numasiento = ((int)asiento["codigo"]);
            }
            return numasiento;
        }
        private void CargarAsientos()
        {
            HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
            int PosFila = 0;
            int numasiento = 0;
            DateTime FechaContable = (DateTime)dtpfechacontable.EditValue;

            numasiento = GetNumAsiento(FechaContable);
            string Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, FechaContable);
            int IdUsuario = HPReserger.frmLogin.CodigoUsuario;
            decimal TC = CapaLogica.TipoCambioDia("Venta", (DateTime)dtpfechacontable.EditValue);

            foreach (var cuentas in cuentasUnicas)
            {
                var filasCoinciden = dt.AsEnumerable()
                           .Where(row => row[0]?.ToString() == cuentas)
                           .ToList();

                decimal totalDebe = dt.AsEnumerable()
                    .Where(row => cuentas.Contains(row[0]?.ToString()))
                    .Sum(row => decimal.TryParse(row[5]?.ToString(), out decimal val) ? val : 0);

                decimal totalHaber = dt.AsEnumerable()
                    .Where(row => cuentas.Contains(row[0]?.ToString()))
                    .Sum(row => decimal.TryParse(row[6]?.ToString(), out decimal val) ? val : 0);


                decimal diferenciaDebe = Math.Max(totalDebe - totalHaber, 0);
                decimal diferenciaHaber = Math.Max(totalHaber - totalDebe, 0);

                DataRow FilaFiltrada = filasCoinciden[0];

                int.TryParse((FilaFiltrada[16].ToString().Split('-'))[0], out int Dinamica);
                string GlosaDetalle = FilaFiltrada[15].ToString() ?? string.Empty;
                int.TryParse((FilaFiltrada[13].ToString().Split('-'))[0], out int pkMoneda);
                //decimal.TryParse(FilaFiltrada[14].ToString(), out decimal TC);
                int fkProyecto = (int)cboproyecto.EditValue;
                string GlosaCabecera = txtglosa.EditValue?.ToString() ?? "Asiento Masivo";

                //CABECERA
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, cuentas, diferenciaDebe, diferenciaHaber,
                  TC, fkProyecto, 0, Cuo, pkMoneda, GlosaCabecera, FechaContable, Dinamica);

                // Aquí puedes procesar cada fila si deseas
                foreach (DataRow fila in filasCoinciden)
                {
                    // Acceder a otras columnas, por ejemplo fila[5] para el Debe
                    string[] tipoid = fila[2].ToString().Split('-');
                    int.TryParse(tipoid[0].ToString(), out int TipoIdProveedor);
                    string RucProveedor = fila[3].ToString().Trim();
                    string NameProveedor = fila[4].ToString().Trim();
                    int.TryParse(fila[8].ToString(), out int idcomprobante);
                    string codcomprobante = fila[9].ToString().Trim();
                    string numcomprobante = fila[10].ToString().Trim();

                    DateTime.TryParse((fila[11].ToString().Split('-'))[0], out DateTime fechaemision); // 1: MN, 2: ME
                    DateTime.TryParse((fila[12].ToString().Split('-'))[0], out DateTime fechavencimiento); // 1: MN, 2: ME

                    int.TryParse((fila[13].ToString().Split('-'))[0], out int moneda); // 1: MN, 2: ME
                    decimal.TryParse(fila[14].ToString(), out decimal tc); // Tipo de cambio
                    decimal.TryParse(fila[5].ToString(), out decimal debe);
                    decimal.TryParse(fila[6].ToString(), out decimal haber);
                    decimal mov = debe + haber;

                    decimal importemn = moneda == 1 ? mov : Math.Round(mov * tc, 2);
                    decimal importeme = moneda == 2 ? mov : (tc != 0 ? Math.Round(mov / tc, 2) : 0);

                    //CAMPOS ABANDONADOS
                    int cc = 0;
                    int CtaBancaria = 0;
                    String nroopbanco = "";

                    CapaLogica.InsertarAsientoDetalle(10, PosFila, numasiento, FechaContable, cuentas, fkProyecto, TipoIdProveedor, RucProveedor, NameProveedor, idcomprobante,
                        codcomprobante, numcomprobante, cc, fechaemision, fechavencimiento, fechaemision, importemn, importeme, tc, moneda, CtaBancaria, nroopbanco, GlosaDetalle,
                        DateTime.Now, IdUsuario, "");

                }

            }
            XtraMessageBox.Show($"✅ El asiento contable masivo se ha cargado correctamente.\nCUO generado: {Cuo}",
                                "Carga finalizada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

            ArchivoCargado = false;

        }

        private void cboempresa_EditValueChanged(object sender, EventArgs e)
        {
            HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();

            if (cboempresa.EditValue != null)
            {
                string empresaId = cboempresa.EditValue.ToString();

                DataTable Tproyecto = CapaLogica.ListarProyectosEmpresa(empresaId);
                cboproyecto.Properties.DataSource = Tproyecto;
                cboproyecto.Properties.DisplayMember = "Proyecto";
                cboproyecto.Properties.ValueMember = "Id_Proyecto";
                cboproyecto.EditValue = null; // opcional, limpia la selección previa
                cboproyecto.EditValue = Tproyecto.Rows.Count > 0 ? Tproyecto.Rows[0]["id_proyecto"] : null;

                cboproyecto.Properties.View.Columns.Clear();
                cboproyecto.Properties.View.Columns.AddVisible("Proyecto", "Proyecto");
                cboproyecto.Properties.View.BestFitColumns();
            }

        }

        private void btnFormato_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog SF = new SaveFileDialog();
            SF.Filter = "Archivos de Excel *.xlsx|*.xlsx";
            SF.FileName = "FORMATO CARGA MASIVA ASIENTO";
            var result = SF.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.WriteAllBytes(SF.FileName, SISGEM.Resource1.FORMATO_CARGA_MASIVA_ASIENTO);
                System.Diagnostics.Process.Start(SF.FileName);
            }
        }
    }
}
