using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger.ModuloReportes
{
    public partial class frmFlujodeGastosDoc : FormGradient
    {
        public frmFlujodeGastosDoc()
        {
            InitializeComponent();
        }
        DataTable TablaEmpresa;
        private DateTime FechaInicio;
        private DateTime FechaFin;
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private bool Cargado = false;
        private DataTable TDatos;

        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public void cargarEmpresa()
        {
            chklist.Items.Clear();
            TablaEmpresa = CapaLogica.Empresa();
            chklist.Items.Add("TODAS", true);
            foreach (DataRow item in TablaEmpresa.Rows)
            {
                chklist.Items.Add(item["descripcion"].ToString(), true);
            }
        }

        private void frmFlujodeGastosDoc_Load(object sender, EventArgs e)
        {
            Generado = false;
            cargarEmpresa();
            cboperiodode.CambioFechas += cboperiodode_CambioFechas;
            cboperiodohasta.CambioFechas += cboperiodohasta_CambioFechas;
            Cargado = true;
        }
        private void chklist_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
            {
                if (chklist.GetItemChecked(0))
                {
                    for (int i = 1; i < chklist.Items.Count; i++)
                        chklist.SetItemChecked(i, false);
                }
                else
                {
                    for (int i = 1; i < chklist.Items.Count; i++)
                        chklist.SetItemChecked(i, true);
                }
            }
            Generado = false;
        }
        private void cboperiodohasta_CambioFechas(object sender, EventArgs e)
        {
            if (cboperiodode.GetFecha().Year != cboperiodohasta.GetFecha().Year && Cargado)
            {
                DateTime FechaAux = cboperiodode.GetFecha();
                DateTime FechaAux1 = cboperiodohasta.GetFecha();
                cboperiodode.Fecha(new DateTime(FechaAux1.Year, FechaAux.Month, FechaAux.Day));
            }
        }
        private void cboperiodode_CambioFechas(object sender, EventArgs e)
        {
            if (cboperiodode.GetFecha().Year != cboperiodohasta.GetFecha().Year && Cargado)
            {
                DateTime FechaAux = cboperiodohasta.GetFecha();
                DateTime FechaAux1 = cboperiodode.GetFecha();
                cboperiodohasta.Fecha(new DateTime(FechaAux1.Year, FechaAux.Month, FechaAux.Day));
            }
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (chklist.CheckedItems.Count == 0) msg("Seleccione una Empresa");
            DateTime FechaAuxiliar;
            string ListadoEmpresas = "";
            if (cboperiodode.FechaInicioMes > cboperiodohasta.FechaInicioMes)
            {
                FechaAuxiliar = cboperiodode.FechaInicioMes;
                cboperiodode.Fecha(cboperiodohasta.FechaInicioMes);
                cboperiodohasta.Fecha(FechaAuxiliar);
            }
            FechaInicio = cboperiodode.GetFechaPRimerDia();
            FechaFin = cboperiodohasta.FechaFinMes;
            foreach (string item in chklist.CheckedItems)
            {
                if (item.ToString() != "TODAS")
                    ListadoEmpresas += CapaLogica.BuscarRucEmpresa(item)[1].ToString() + ",";
            }
            ListadoEmpresas = ListadoEmpresas.Substring(0, ListadoEmpresas.Length - 1);
            if (!Generado)
            {
                if (rbPagos.Checked)
                    TDatos = CapaLogica.GenerarFlujodeCajaGastos(ListadoEmpresas, FechaInicio, FechaFin);
                if (rbRegistro.Checked)
                    TDatos = CapaLogica.GenerarFlujodeCajaRegistro(ListadoEmpresas, FechaInicio, FechaFin);
            }
            //dtgconten.DataSource = TDatos;
            ////lblmensaje.Text = $"Total de Registros: {dtgconten.RowCount}";
            if (TDatos.Rows.Count == 0) { msg("No Hay Registros"); }
            else
            {
                backgroundWorker1.WorkerSupportsCancellation = true;
                if (TDatos.Rows.Count > 0)
                {
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    {
                        Cursor = Cursors.WaitCursor;
                        frmproce = new HPReserger.frmProcesando();
                        frmproce.Show();
                        if (!backgroundWorker1.IsBusy)
                        {
                            backgroundWorker1.RunWorkerAsync();
                        }
                    }
                }
                else
                {
                    msg("No hay Datos que Exportar");
                }
                Generado = true;
            }
            //Ordenado = false;
            Cursor = Cursors.Default;
        }
        frmProcesando frmproce;
        private bool Generado;

        private void btnexcel_Click(object sender, EventArgs e)
        {

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (TDatos.Rows.Count > 0)
            {
                foreach (var item in chklist.CheckedItems)
                {
                    //EMPRESAS
                    if (item.ToString() != "TODAS")
                    {
                        string Carpeta = folderBrowserDialog1.SelectedPath;
                        string EmpresaValor = item.ToString().ToUpper();
                        string Ruc = CapaLogica.BuscarRucEmpresa(EmpresaValor)[0].ToString();
                        string valor = Carpeta + @"\";
                        //ELiminamos el Excel Antiguo
                        string NameFile = "";
                        if (rbPagos.Checked)
                            NameFile = valor + $"FLUJO DE CAJA -PAGOS {EmpresaValor} - PERIODO {cboperiodode.FechaInicioMes.ToString("yyyyMM")}-{cboperiodohasta.FechaFinMes.ToString("yyyyMM")} .xlsm";
                        if (rbRegistro.Checked)
                            NameFile = valor + $"FLUJO DE CAJA - REGISTRO {EmpresaValor} - PERIODO {cboperiodode.FechaInicioMes.ToString("yyyyMM")}-{cboperiodohasta.FechaFinMes.ToString("yyyyMM")} .xlsm";
                        //
                        File.Delete(NameFile);
                        File.Exists(NameFile);
                        if (item.ToString() != "TODAS")
                        {
                            DataView dv = TDatos.Copy().AsDataView();
                            dv.RowFilter = $"empresa like '{EmpresaValor}'";
                            DataTable TablaResult = dv.ToTable();
                            string _NombreHoja = ""; string _Cabecera = ""; int[] _OrdenarColumnas; string _NColumna = "";
                            _NombreHoja = $"Hoja1"; _Cabecera = "Flujo de Caja -Pagos";
                            _OrdenarColumnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
                            _NColumna = "m";
                            List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                            //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                            Color Back = Color.FromArgb(78, 129, 189);
                            Color Fore = Color.FromArgb(255, 255, 255);
                            string cadena = $"PERIODO {cboperiodode.FechaInicioMes.ToString("yyyyMM")} - {cboperiodohasta.FechaFinMes.ToString("yyyyMM")}";
                            //MACRO
                            string Macro = $"Private Sub Workbook_Open() { Environment.NewLine}" +
                            //
                            $"{ Environment.NewLine}" +
                            $"Range(\"A1\").Select{ Environment.NewLine}" +
                            $"on error goto Oops { Environment.NewLine}" +
                            $"Sheets(\"Hoja1\").Select{ Environment.NewLine}" +
                            $" Sheets(\"Hoja1\").Name = \"Datos\"{ Environment.NewLine}" +
                            $" Range(\"A1\").Select{ Environment.NewLine}" +
                            $"Sheets.Add{ Environment.NewLine}" +
                            $" ActiveWorkbook.PivotCaches.Create(SourceType:= xlDatabase, SourceData:=\"Datos!R1C1:R{TablaResult.Rows.Count}C5\", Version:= 6).CreatePivotTable TableDestination:= \"Hoja1!R3C1\", TableName:= \"TablaDinámica1\", DefaultVersion:= 6{ Environment.NewLine}" +
                            $"Sheets(\"Hoja1\").Select{ Environment.NewLine}" +
                            $" Cells(3, 1).Select{ Environment.NewLine}" +
                            $"With ActiveSheet.PivotTables(\"TablaDinámica1\").PivotFields(\"CuentaContable\"){ Environment.NewLine}" +
                            $".Orientation = xlRowField{ Environment.NewLine}" +
                            $".Position = 1{ Environment.NewLine}" +
                            $"End With{ Environment.NewLine}" +
                            $"With ActiveSheet.PivotTables(\"TablaDinámica1\").PivotFields(\"NumFactura\"){ Environment.NewLine}" +
                            $".Orientation = xlRowField{ Environment.NewLine}" +
                            $".Position = 2{ Environment.NewLine}" +
                            $"End With{ Environment.NewLine}" +
                            $"ActiveSheet.PivotTables(\"TablaDinámica1\").AddDataField ActiveSheet.PivotTables(\"TablaDinámica1\").PivotFields(\"Movimiento\"), \"Suma de Movimiento\", xlSum{ Environment.NewLine}" +
                            $"ActiveSheet.PivotTables(\"TablaDinámica1\").PivotSelect \"\", xlDataAndLabel, True{ Environment.NewLine}" +
                            $" With ActiveSheet.PivotTables(\"TablaDinámica1\").PivotFields(\"FechaContable\"){ Environment.NewLine}" +
                            $".Orientation = xlColumnField{ Environment.NewLine}" +
                            $".Position = 1{ Environment.NewLine}" +
                            $"End With{ Environment.NewLine}" +
                            $"ActiveSheet.PivotTables(\"TablaDinámica1\").PivotFields(\"FechaContable\").AutoGroup{ Environment.NewLine}" +
                            //$"ActiveSheet.PivotTables(\"TablaDinámica3\").PivotFields(\"FechaContable\").AutoGroup{ Environment.NewLine}" +
                            $"Range(\"B4\").Select{ Environment.NewLine}" +
                            $"Selection.Group Start:= True, End:= True, Periods:= Array(False, False, False,False, True, False, True){ Environment.NewLine}" +
                            //$"ActiveSheet.PivotTables(\"TablaDinámica1\").PivotFields(\"Trimestres\").Orientation = xlHidden{ Environment.NewLine}" +
                            $"ActiveSheet.PivotTables(\"TablaDinámica1\").DisplayFieldCaptions = False{ Environment.NewLine}" +
                            $"Range(\"A3\").Select{ Environment.NewLine}" +
                            $"With ActiveSheet.PivotTables(\"TablaDinámica1\").PivotFields(\"Suma de Movimiento\"){ Environment.NewLine}" +
                            $"      .Caption = \"Listado de Cuentas Gastos\"{ Environment.NewLine}" +
                            $"     .NumberFormat = \"#,##0.00\"{ Environment.NewLine}" +
                            $"End With{ Environment.NewLine}" +
                            $"Range(\"A9\").Select{ Environment.NewLine}" +
                            $"ActiveSheet.PivotTables(\"TablaDinámica1\").PivotFields(\"CuentaContable\").ShowDetail = False{ Environment.NewLine}" +
                            $"ActiveWorkbook.ShowPivotTableFieldList = False{ Environment.NewLine}" +
                            $"ActiveSheet.PivotTables(\"TablaDinámica1\").TableStyle2 = \"PivotStyleMedium9\"{ Environment.NewLine}" +
                            $"Range(\"A6\").Select{ Environment.NewLine}" +
                            $"ActiveWindow.FreezePanes = True{ Environment.NewLine}" +
                            $" Range(\"A1\").Select{ Environment.NewLine}" +
                            $"ActiveCell.FormulaR1C1 =\"{EmpresaValor} \" { Environment.NewLine}" +
                            $"Range(\"A2\").Select{ Environment.NewLine}" +
                            $"ActiveCell.FormulaR1C1 = \"{cadena} \"{ Environment.NewLine}" +
                            $"Sheets(\"Hoja1\").Select{ Environment.NewLine}" +
                            $"Sheets(\"Hoja1\").Name = \"Tabla\"{ Environment.NewLine}" +
                            $" Range(\"A3\").Select{ Environment.NewLine}" +
                            $" ActiveWorkbook.Save { Environment.NewLine}" +
                            $" Oops:{ Environment.NewLine}" +
                            $" 'handle error here { Environment.NewLine} End Sub";
                            ///
                            //FIN MACRO
                            //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "i1", _Cabecera.ToUpper(), 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                            //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "PERIODO:", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                            //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", $"periodo del periood", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                            //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", "Ruc:", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                            //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", "c3", $"{Ruc}", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                            //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", "f4", "APELLIDOS Y NOMBRES, DENOMINACIÓN O RAZÓN SOCIAL:", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                            //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("g4", "i4", $"{EmpresaValor}", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                            ///////estilos de la celdas
                            HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(Color.FromArgb(220, 230, 241), Configuraciones.FuenteReportesTahoma8, Color.Black);
                            HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(Color.FromArgb(78, 129, 189), Configuraciones.FuenteReportesTahoma8, Color.White);
                            /////fin estilo de las celdas
                            //Tabla Datos

                            /////
                            ////Anterior               
                            //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", _NombreHoja, Celdas, 5, _Columnas, new int[] { }, new int[] { });
                            HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(TablaResult, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, 1, Celdas, 1, _OrdenarColumnas, new int[] { }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, Macro);
                            // HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(TablaResult, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, contador++, Celdas, 5, _OrdenarColumnas, new int[] { }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "");
                        }
                    }
                }
                msgOK($"Archivo Grabados en \n{folderBrowserDialog1.SelectedPath}");
                if (backgroundWorker1.IsBusy) backgroundWorker1.CancelAsync();
            }
            else msg("No hay Registros en la Grilla");
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
        }
        private void cboperiodode_CambioFechas_1(object sender, EventArgs e)
        {
            Generado = false;
        }
        private void cboperiodohasta_CambioFechas_1(object sender, EventArgs e)
        {
            Generado = false;
        }

        private void rbPagos_CheckedChanged(object sender, EventArgs e)
        {
            Generado = false;
        }

        private void rbRegistro_CheckedChanged(object sender, EventArgs e)
        {
            Generado = false;
        }
    }
}
