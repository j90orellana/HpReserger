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

namespace HPReserger
{
    public partial class FrmReporteBoletas : FormGradient
    {
        public FrmReporteBoletas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void FrmReporteBoletas_Load(object sender, EventArgs e)
        {
            CargarTextosPorDefecto();
            Cargado = true;
            MostrarDatosFiltrados();
        }
        private void CargarTextosPorDefecto()
        {
            txtbusEmpleado.CargarTextoporDefecto();
            txtbusEmpresa.CargarTextoporDefecto();
            cbofechaini.Fecha(new DateTime(DateTime.Now.Year, 1, 1));
            cbofechafin.Fecha(new DateTime(DateTime.Now.Year, 12, 31));
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        frmProcesando frmproce;
        private bool Cargado = false;
        private DateTime FechaInicial;
        private DateTime FechaFinal;
        string CadenaFecha;
        private void btnexportar_Click(object sender, EventArgs e)
        {
            dtgconten.Refresh();
            if (dtgconten.RowCount > 0)
            {
                if (chkFechaxHoja.Checked)
                    if (folderBrowserDialog1.ShowDialog() != DialogResult.OK) { return; }
                frmproce = new frmProcesando();
                Cursor = Cursors.WaitCursor;
                frmproce.Show();
                CadenaFecha = "Del " + FechaInicial.ToShortDateString() + " Al " + FechaFinal.ToShortDateString();
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
                msg("No hay Filas para Exportar");
        }
        List<string> ListadoEmpresas;
        List<DateTime> ListadoFechas;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                ListadoEmpresas = new List<string>();
                ListadoFechas = new List<DateTime>();
                foreach (DataRow item in TDatos.Rows)
                {
                    if (!ListadoEmpresas.Contains(item["empresa"].ToString())) ListadoEmpresas.Add(item["empresa"].ToString());
                    if (!ListadoFechas.Contains((DateTime)item["periodo"])) ListadoFechas.Add((DateTime)item["periodo"]);
                }
                //Cambiamos el Valor de Periodo
                if (chkFechaxHoja.Checked)
                {
                    TDatos.Columns.Add("Fecha");
                    foreach (DataRow item in TDatos.Rows)
                        item["Fecha"] = ((DateTime)item["periodo"]).ToString("yyyyMM00");
                }
                foreach (string item in ListadoEmpresas)
                {
                    int ContadorHojas = 0;
                    DataView dve = TDatos.Copy().AsDataView();
                    dve.RowFilter = $"empresa like '{item}'";
                    //si hay datos de esta empresa
                    DataTable TablaAuxiliar = dve.ToTable();
                    if (TablaAuxiliar.Rows.Count > 0)
                    {
                        string Carpeta = folderBrowserDialog1.SelectedPath;
                        string EmpresaValor = item.ToString().ToUpper();
                        //string Ruc = CapaLogica.BuscarRucEmpresa(EmpresaValor)[0].ToString();
                        string valor = Carpeta + @"\";
                        //if (chkCarpetas.Checked)
                        //{
                        string CarpetaContenedora = $"ReporteBoletas {FechaInicial.Year}-{FechaFinal.Year} ";
                        valor = Carpeta + @"\" + Configuraciones.ValidarRutaValida(CarpetaContenedora) + @"\";
                        if (!Directory.Exists(Carpeta + @"\" + CarpetaContenedora))
                            Directory.CreateDirectory(Carpeta + @"\" + Configuraciones.ValidarRutaValida(CarpetaContenedora));
                        //}
                        ////ELiminamos el Excel Antiguo
                        string NameFile = valor + $"RB - {EmpresaValor}.xlsx";
                        File.Delete(NameFile);
                        File.Exists(NameFile);
                        int i = 0; //posicion de la hoja no  es index
                        HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, Configuraciones.FuenteReportesTahoma8, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                        HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, Configuraciones.FuenteReportesTahoma10, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);

                        int Hoja = 1;
                        //Toda en una Hoja   
                        if (!chkFechaxHoja.Checked)
                        {
                            string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                            int[] _ColumnasAutoajustar = new int[] { };
                            //
                            _NombreHoja = $"RB - {item}".ToUpper();
                            _Cabecera = "Reporte de Boletas de Pagos";
                            _NColumna = "d";
                            _ColumnasAutoajustar = new int[] { };
                            _Columnas = new int[] { 1, 2, 3, 4, 5, 6 };
                            //
                            List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                            //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                            Color Back = Color.FromArgb(78, 129, 189);
                            Color Fore = Color.FromArgb(255, 255, 255);
                            int PosInicialGrilla = 5;
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", $"{_NColumna}1", _Cabecera.ToUpper(), 10, true, true, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", $"a2", "Empresa", 8, true, false, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", $"{_NColumna}2", item, 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", $"a3", "RUC", 8, true, false, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", $"{_NColumna}3", TablaAuxiliar.Rows[0]["ruc"].ToString(), 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                            //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a5", $"a5", "Periodo", 8, true, true, Back, Fore, Configuraciones.FuenteReportesTahoma10));                            
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", $"{_NColumna}4", CadenaFecha, 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                            if (txtbusEmpleado.EstaLLeno()) { Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{PosInicialGrilla}", $"{_NColumna}{PosInicialGrilla}", $"Filtro: Empleado; {txtbusEmpleado.Text}", 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8)); PosInicialGrilla++; }
                            //                            
                            DataTable TableResuk = new DataTable();
                            TableResuk = (TablaAuxiliar).Copy();
                            TableResuk.Columns.RemoveAt(0);
                            TableResuk.Columns.RemoveAt(0);
                            foreach (DataGridViewColumn ColumnasVisibles in dtgconten.Columns)
                                if (!ColumnasVisibles.Visible && ColumnasVisibles.Index > 1)
                                    TableResuk.Columns.Remove(ColumnasVisibles.DataPropertyName);
                            //else                            

                            PosInicialGrilla++;
                            HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableResuk, CeldaCabecera, CeldaDefault, "", _NombreHoja, Celdas, PosInicialGrilla, _Columnas, new int[] { }, _ColumnasAutoajustar, "");


                        }//Toda en una Hoja
                        else //FechaxHoja
                        {
                            foreach (DateTime Fecha in ListadoFechas)
                            {
                                DataView dvf = TablaAuxiliar.Copy().AsDataView();
                                dvf.RowFilter = $"fecha  = {Fecha.ToString("yyyyMM00")}";

                                DataTable TablaAuxFechas = dvf.ToTable();
                                if (TablaAuxFechas.Rows.Count > 0)
                                {
                                    ContadorHojas++;
                                    string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                                    int[] _ColumnasAutoajustar = new int[] { 2, 3, 4, 5 };
                                    //
                                    _NombreHoja = $"{Fecha.ToString("MMMM/yyyy")}".ToUpper();
                                    _Cabecera = "Reporte de Boletas de Pagos";
                                    _NColumna = "d";
                                    _ColumnasAutoajustar = new int[] { 2, 3, 4, 5, 7, 6 };
                                    _Columnas = new int[] { 1, 2, 3, 4, 5, 6 };
                                    //
                                    List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                                    //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                                    Color Back = Color.FromArgb(78, 129, 189);
                                    Color Fore = Color.FromArgb(255, 255, 255);
                                    int PosInicialGrilla = 4;
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", $"{_NColumna}1", _Cabecera.ToUpper(), 10, true, true, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", $"a2", "Empresa", 8, true, false, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", $"{_NColumna}2", item, 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", $"a3", "RUC", 8, true, false, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", $"{_NColumna}3", TablaAuxiliar.Rows[0]["ruc"].ToString(), 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                                    //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a5", $"a5", "Periodo", 8, true, true, Back, Fore, Configuraciones.FuenteReportesTahoma10));                            
                                    //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", $"{_NColumna}4", CadenaFecha, 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                    if (txtbusEmpleado.EstaLLeno()) { Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{PosInicialGrilla}", $"{_NColumna}{PosInicialGrilla}", $"Filtro: Empleado; {txtbusEmpleado.Text}", 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8)); PosInicialGrilla++; }
                                    //                            
                                    DataTable TableResuk = new DataTable();
                                    TableResuk = (TablaAuxFechas).Copy();
                                    TableResuk.Columns.RemoveAt(0);
                                    TableResuk.Columns.RemoveAt(0);
                                    TableResuk.Columns.RemoveAt(0);
                                    TableResuk.Columns.Remove("Fecha");
                                    foreach (DataGridViewColumn ColumnasVisibles in dtgconten.Columns)
                                        if (!ColumnasVisibles.Visible && ColumnasVisibles.Index > 2)
                                            TableResuk.Columns.Remove(ColumnasVisibles.DataPropertyName);
                                    PosInicialGrilla++;
                                    //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableResuk, CeldaCabecera, CeldaDefault, "", _NombreHoja, Celdas, PosInicialGrilla, _Columnas, new int[] { }, _ColumnasAutoajustar, "");
                                    HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(TableResuk, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, ContadorHojas, Celdas, PosInicialGrilla++, new int[] { }, new int[] { },
                                        new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 }, "");
                                }
                            }

                        } //FechaxHoja
                    } //si hay datos de esta empresa
                }              
                msgOK("Exportado con Exito");
            }
            else msg("No hay Registros en la Grilla");
            //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(null, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, Hoja, Celdas, ContadorHojas, new int[] { }, new int[] { }, new int[] { 1, 2, 3, 4, 5 }, "");


        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (chkFechaxHoja.Checked)
            {
                TDatos.Columns.Remove("fecha");
                dtgconten.DataSource = TDatos.Clone();
                dtgconten.DataSource = TDatos;
            }
            dtgconten.Refresh();
            Cursor = Cursors.Default;
            frmproce.Close();
            //msgOK("Exportado con Exito");

        }
        private void btnlimpiar_Click21(object sender, EventArgs e)
        {
            PanelMostrar.Visible = true;
            PanelMostrar.BringToFront();
            PanelMostrar.Focus();
            CargardatosLista();
        }
        public void CargardatosLista()
        {
            chkListaColumnas.Items.Clear();
            foreach (DataGridViewColumn item in dtgconten.Columns)
            {
                if (item.Name != empres.Name && item.Name != periodo.Name && item.Name != ruc.Name)
                    chkListaColumnas.Items.Add(item.HeaderText, item.Visible);
            }
        }
        private void PanelMostrar_LostFocus(object sender, EventArgs e)
        {
            PanelMostrar.Visible = false;
        }

        private void txtbusEmpresa_TextChanged(object sender, EventArgs e)
        {
            MostrarDatosFiltrados();
        }

        private void txtbusEmpleado_TextChanged(object sender, EventArgs e)
        {
            MostrarDatosFiltrados();
        }

        private void cbofechaini_CambioFechas(object sender, EventArgs e)
        {
            MostrarDatosFiltrados();
        }
        DataTable TDatos;
        private void MostrarDatosFiltrados()
        {
            if (Cargado)
            {
                FechaInicial = cbofechaini.FechaInicioMes;
                FechaFinal = cbofechafin.FechaFinMes;
                if (FechaInicial > FechaFinal)
                {
                    FechaFinal = cbofechaini.FechaInicioMes;
                    FechaInicial = cbofechafin.FechaInicioMes;
                }
                TDatos = CapaLogica.ReporteBoletas(txtbusEmpresa.TextValido(), txtbusEmpleado.TextValido(), FechaInicial, FechaFinal);
                dtgconten.DataSource = TDatos;
                lblRegistros.Text = $"Total Registros: {dtgconten.RowCount}";
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarDatosFiltrados();
        }
        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            PanelMostrar.Visible = false;
        }
        private void btnok_Click(object sender, EventArgs e)
        {
            dtgconten.SuspendLayout();
            foreach (DataGridViewColumn item in dtgconten.Columns)
            {
                if (item.Name != empres.Name && item.Name != periodo.Name && item.Name != ruc.Name)
                    item.Visible = false;
            }
            foreach (string item in chkListaColumnas.CheckedItems)
            {
                foreach (DataGridViewColumn itemc in dtgconten.Columns)
                {
                    if (itemc.HeaderText == item) itemc.Visible = true;
                }
            }
            PanelMostrar.Visible = false;
            //
            dtgconten.ResumeLayout();
            dtgconten.PerformLayout();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Cargado = false;
            CargarTextosPorDefecto();
            Cargado = true;
            MostrarDatosFiltrados();
        }

        private void dtgconten_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }
    }
}
