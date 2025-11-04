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
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPrinting;
using DevExpress.Export;

namespace SISGEM.Flujo_de_Caja
{
    public partial class frmCuadraturaMF : DevExpress.XtraEditors.XtraForm
    {
        public frmCuadraturaMF()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        DataTable Tdatos;
        private void btnCargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPResergerCapaLogica.FlujoCaja.SaldosCuentasBancarias Cclase = new HPResergerCapaLogica.FlujoCaja.SaldosCuentasBancarias();
            Tdatos = Cclase.ObtenerCuadraturaMF();
            pivotGridControl1.DataSource = Tdatos;


            // Permitir edición en celdas de datos
            pivotGridControl1.OptionsCustomization.AllowEdit = true;

            pivotGridControl1.BestFitRowArea();
        }

        PivotGridField fsaldoInicial;
        PivotGridField fsaldoFinal;
        private void frmCuadraturaMF_Load(object sender, EventArgs e)
        {

            // 1) Habilitar edición en el control y en el campo
            pivotGridControl1.OptionsCustomization.AllowEdit = true; // habilita edición global
            pivotGridControl1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp; // editor al soltar clic

            fsaldoInicial = pivotGridControl1.Fields["SALDOINICIAL"];      // <— cámbialo a tu campo
            fsaldoInicial.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            fsaldoInicial.Options.AllowEdit = true;                      // habilita edición en este campo
            // 2) Asignar un editor para el área de datos (opcional pero recomendado)
            var spin = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            //spin.IsFloatValue = true;
            spin.Mask.EditMask = "n2";
            spin.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            spin.Mask.UseMaskAsDisplayFormat = true;
            pivotGridControl1.RepositoryItems.Add(spin);
            fsaldoInicial.FieldEdit = spin;


            fsaldoFinal = pivotGridControl1.Fields["SALDOFINAL"];      // <— cámbialo a tu campo
            fsaldoFinal.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            fsaldoFinal.Options.AllowEdit = true;                      // habilita edición en este campo
            // 2) Asignar un editor para el área de datos (opcional pero recomendado)
            var spisn = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            //spin.IsFloatValue = true;
            spisn.Mask.EditMask = "n2";
            spisn.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            spisn.Mask.UseMaskAsDisplayFormat = true;
            pivotGridControl1.RepositoryItems.Add(spisn);
            fsaldoFinal.FieldEdit = spisn;

        }

        private void pivotGridControl1_CustomCellValue(object sender, DevExpress.XtraPivotGrid.PivotCellValueEventArgs e)
        {
            //// Verifica si el área es de datos
            //if (e.DataField != null && e.DataField.Area == PivotArea.DataArea)
            //{
            //    //// Obtén la fila del DataTable vinculada
            //    //DataRowView rowView = pivotGridControl1.value.GetRecordByRowValue(e.RowValue) as DataRowView;
            //    //if (rowView != null)
            //    //{
            //    //    // Actualiza el valor en el DataTable
            //    //    rowView[e.DataField.FieldName] = e.Value;
            //    //}
            //}
        }

        private void pivotGridControl1_EditValueChanged(object sender, EditValueChangedEventArgs ex)
        {
            if (!(ex.DataField == fsaldoInicial || ex.DataField == fsaldoFinal)) return;

            var nuevoValor = ex.Editor.EditValue;
            string _nroCtaBancaria = ex.GetFieldValue(xCTABANCARIA)?.ToString();
            DateTime _fecha = (DateTime)ex.GetFieldValue(xFECHAOPERACION);

            // Obtiene las filas subyacentes de esa celda
            var dd = ex.CreateDrillDownDataSource();

            if (_nroCtaBancaria != "")
            {
                HPResergerCapaLogica.FlujoCaja.SaldosCuentasBancarias cclase = new HPResergerCapaLogica.FlujoCaja.SaldosCuentasBancarias();

                cclase.IdCtaBancaria = 0;
                cclase.NroCuentaBancaria = _nroCtaBancaria;
                cclase.IdUsuario = HPReserger.frmLogin.CodigoUsuario;
                cclase.Fecha = _fecha;
                cclase.SaldoFinal = decimal.Parse((nuevoValor ?? 0).ToString());
                cclase.SaldoInicial = decimal.Parse((nuevoValor ?? 0).ToString());

                if (ex.DataField == fsaldoInicial)
                    if (cclase.InsertarSaldoInicial(cclase) > 0)
                        btnCargar.PerformClick();

                if (ex.DataField == fsaldoFinal)
                    if (cclase.InsertarSaldoFinal(cclase) > 0)
                        btnCargar.PerformClick();

                // Refresca el pivot
                pivotGridControl1.RefreshData();
            }
        }

        private void pivotGridControl1_CustomUnboundFieldData(object sender, CustomFieldDataEventArgs e)
        {
            //if (e.Field.FieldName == "MOVIMIENTO")
            //{
            //    decimal saldoInicial = Convert.ToDecimal(e.GetListSourceColumnValue("SALDOINICIAL") ?? 0);
            //    decimal saldoFinal = Convert.ToDecimal(e.GetListSourceColumnValue("SALDOFINAL") ?? 0);

            //    e.Value = saldoFinal - saldoInicial; // fórmula de cálculo
            //}

            //if (e.Field.FieldName == "DIFERENCIA")
            //{
            //    decimal saldoInicial = Convert.ToDecimal(e.GetListSourceColumnValue("SALDOINICIAL") ?? 0);
            //    decimal saldoFinal = Convert.ToDecimal(e.GetListSourceColumnValue("SALDOFINAL") ?? 0);
            //    decimal MONTO = Convert.ToDecimal(e.GetListSourceColumnValue("MONTO") ?? 0);

            //    e.Value = (saldoFinal - saldoInicial) + MONTO; // fórmula de cálculo
            //}
        }

        private void bntMovimiento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Buscar formulario abierto manualmente
            Form formularioExistente = null;
            foreach (Form f in System.Windows.Forms.Application.OpenForms)
            {
                if (f is SISGEM.Flujo_de_Caja.frmMovimientosSueltos)
                {
                    formularioExistente = f;
                    break;
                }
            }

            // Cerrar si existe
            formularioExistente?.Close();

            // Crear y mostrar nuevo
            var nuevoForm = new SISGEM.Flujo_de_Caja.frmMovimientosSueltos();
            nuevoForm.Show();
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
                string nombreArchivo = $"Reporte de Cuadratura MF - {fecha}.xlsx";

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
                    SheetName = "Reporte de Cuadratura MF",
                    FitToPrintedPageWidth = true,
                    RawDataMode = false,
                    ExportHyperlinks = false

                };

                options.DocumentOptions.Author = "j90orellana@hotmail.com";
                options.DocumentOptions.Title = "Reporte de Cuadratura MF";
                options.DocumentOptions.Subject = "Reporte de Cuadratura MF";



                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Exportar el GridControl a Excel
                    pivotGridControl1.ExportToXlsx(saveFileDialog.FileName, options);

                    HPResergerFunciones.Exportador.RecorrerExcel(saveFileDialog.FileName, options.SheetName);

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

        private void pivotGridControl1_FieldValueDisplayText(object sender, PivotFieldDisplayTextEventArgs e)
        {
            // Validamos que sea la columna FechaEmision
            if (e.Field != null && e.Field.FieldName == "FECHAOPERACION"
                && e.IsColumn) // 👈 nos aseguramos de que es un valor en ColumnArea
            { }
            else { return; }
            if (e.Field.Caption != "FECHA") return;

            switch (e.Field.GroupInterval)
            {
                case PivotGroupInterval.DateYear:
                    e.DisplayText = string.Format("{0:0}", e.Value);
                    break;

                case PivotGroupInterval.DateQuarter:
                    // Opción 1: mostrar solo T1, T2...
                    e.DisplayText = "T" + e.Value.ToString();

                    // Opción 2 (con año incluido):
                    // var year = ((DateTime)e.Value).Year;
                    // e.DisplayText = $"Trimestre {e.Value} - {year}";
                    break;

                case PivotGroupInterval.DateMonth:
                    e.DisplayText = string.Format("{0:0}", e.Value);
                    break;

                case PivotGroupInterval.DateMonthYear:
                    e.DisplayText = string.Format("{0:MMMM yyyy}", e.Value);
                    break;

                case PivotGroupInterval.DateDay:
                    e.DisplayText = string.Format("{0:0}", e.Value);
                    break;
                case PivotGroupInterval.Date:
                    e.DisplayText = string.Format("{0:dd/MM/yyyy}", e.Value);
                    break;
                case PivotGroupInterval.Default:
                    e.DisplayText = string.Format("{0:dd/MM/yyyy}", e.Value);
                    break;
                case PivotGroupInterval.DateQuarterYear:
                    DateTime fecha = (DateTime)e.Value;
                    int trimestre = (fecha.Month - 1) / 3 + 1;
                    e.DisplayText = $"T{trimestre} - {fecha.Year}";
                    break;
            }

        }
             
    }
}