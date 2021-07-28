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

namespace HPReserger.ModuloRRHH
{
    public partial class frmReporteComisiones : FormGradient
    {
        public frmReporteComisiones()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmReporteComisiones_Load(object sender, EventArgs e)
        {
            CargarValoresxDefecto();
        }
        private void CargarValoresxDefecto()
        {
            cbode.Fecha(new DateTime(DateTime.Now.Year, 1, 1));
            cbohasta.Fecha(DateTime.Now);
        }
        DataTable TDatos;
        private void CargarDatos(DateTime fechade, DateTime fechaa)
        {
            TDatos = CapaLogica.ComisionesBonos_Reporte(fechade, fechaa);
            dtgconten.DataSource = TDatos;
            lbltotalRegistros.Text = $"Total de Registros: {dtgconten.RowCount}";
            Configuraciones.PintarDeColoresValoresUnicos(dtgconten, xnumdoc);
        }
        DateTime fechade, fechaa;
        private void btnPaso1_Click(object sender, EventArgs e)
        {
            fechade = cbode.FechaInicioMes;
            fechaa = cbohasta.FechaInicioMes;
            if (fechade > fechaa)
            {
                fechaa = cbode.FechaInicioMes; fechade = cbohasta.FechaInicioMes;
            }
            CargarDatos(fechade, fechaa);
            if (TDatos.Rows.Count != 0)
                dtgconten.DataSource = TDatos;
            else
            {
                if (TDatos != null)
                    dtgconten.DataSource = TDatos.Clone();
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void msgError(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        frmProcesando frmproce;
        private void btnexcel_Click(object sender, EventArgs e)
        {
            if (TDatos.Rows.Count == 0)
            {
                msgError("No hay Registros para Mostrar");
                Cursor = Cursors.Default;
            }
            else
            {
                backgroundWorker1.WorkerSupportsCancellation = true;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    frmproce = new HPReserger.frmProcesando();
                    frmproce.Show();
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }

                    else
                    {
                        Cursor = Cursors.Default;
                        return;
                    }
                }
                Cursor = Cursors.Default;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (TDatos.Rows.Count > 0)
            {
                //DESARROLLO PARA MOSTRAR EL ESQUEMA DEL REPORTE DEL EXCEL                
                List<string> ListCuentas = new List<string>();
                //AGREGAMOS LAS CUENTAS CONTABLES A UNA LISTA PARA FILTRAR
                DataView dv = TDatos.AsDataView();
                string Carpeta = folderBrowserDialog1.SelectedPath;
                //
                string EmpresaValor = Configuraciones.ValidarRutaValida("");
                //string Ruc = CapaLogica.BuscarRucEmpresa(EmpresaValor)[0].ToString();
                string valor = Carpeta + @"\";
                //if (chkCarpetas.Checked)
                //{
                valor = Carpeta + @"\" + EmpresaValor + @"\";
                string directorio = (Carpeta + @"\" + EmpresaValor).Replace(" ", "_");
                if (!Directory.Exists(directorio))
                    Directory.CreateDirectory(directorio);
                //}
                string NameFile = "";
                NameFile = valor + $"Reporte Comisiones_Bonos {fechade.ToString(Configuraciones.MM_yyyy)}{(fechaa == fechade ? "" : $" a {fechaa.ToString(Configuraciones.MM_yyyy)}")}.xlsx";
                //ELiminamos el Excel Antiguo
                try
                {
                    if (File.Exists(NameFile)) File.Delete(NameFile);
                }
                catch { msgError("El Archivo Esta Abierto"); }
                //DEFINICIONES
                List<string> LPeriodos = Configuraciones.ExtraerListaSinDuplicados(TDatos, xperiodo.DataPropertyName);
                //
                int i = 0; //posicion de la hoja no  es index
                int j = 0;
                int Hoja = 0;
                foreach (string Periodo in LPeriodos)
                {
                    //Filtramos por periodo
                    dv.RowFilter = $"periodo like '{Periodo}'";
                    HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(Configuraciones.BackAlterno, Configuraciones.FuenteReportesTahoma10, Configuraciones.ForeAlterno);
                    HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(Configuraciones.BackColumna, Configuraciones.FuenteReportesTahoma10, Configuraciones.ForeColumna);
                    //RECORREMOS EL RANGO DE PERIODOS QUE SE INGRESO               
                    i = 0; j = 0;
                    Hoja++;
                    String _NombreHoja = $"{Periodo}";
                    List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{1 + i}", $"i{1 + i}", "Listado de Comisiones y Bonos", 12, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{2 + i}", $"i{2 + i}", "Listado de las Comisiones de los Empleados", 9, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                    //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{4 + i}", $"R{4 + i}", ($"COSTO Y DEPRECIACIÓN ACUMULADA AL {FechaTempFinMes.ToString("dd 'DE' MMMM yyyy")}").ToUpper(), 9, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                    DataTable TResult = dv.ToTable();
                    Configuraciones.QuitarColumnas(TResult, new int[] { 0, 1, 5, 7, 9 });
                    Configuraciones.CambiarNombreColumnsTablaGrilla(TResult, dtgconten.Columns);
                    Color Calterno = Configuraciones.BackAlterno;
                    int FilCabecera = 4;
                    string Nombre = "";
                    int pos = 0;
                    int c = 0;
                    decimal SComision = 0, SBono = 0, SSueldo = 0, SRefacturar = 0;
                    decimal TComision = 0, TBono = 0, TSueldo = 0, TRefacturar = 0;
                    //Etiquetas de las Columnas
                    foreach (DataColumn item in TResult.Columns)
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"{char.ConvertFromUtf32(65 + i)}{FilCabecera}", $"{char.ConvertFromUtf32(65 + i++)}{FilCabecera}", item.ColumnName, 9, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Configuraciones.BackColumna, Color.White, Configuraciones.FuenteReportesTahoma10, true));
                    //Agregamos un separador
                    for (int x = 0; x < TResult.Rows.Count; x++)
                    {
                        if (TResult.Rows[x]["nombres"].ToString() != Nombre && Nombre != "")
                        {
                            TResult.Rows.InsertAt(TResult.NewRow(), x); x++;
                        }
                        Nombre = TResult.Rows[x]["nombres"].ToString();
                    }
                    TResult.Rows.InsertAt(TResult.NewRow(), TResult.Rows.Count);
                    //
                    foreach (DataRow item in TResult.Rows)
                    {
                        if (item["nombres"].ToString() != "")
                        {
                            SSueldo += (decimal)item["Sueldo"];
                            SComision += (decimal)item["Comisión"];
                            SBono += (decimal)item["bono"];
                            TSueldo += (decimal)item["Sueldo"];
                            TComision += (decimal)item["Comisión"];
                            TBono += (decimal)item["bono"];
                            SRefacturar += (decimal)item["Re-fact"];
                            TRefacturar += (decimal)item["Re-fact"];
                            //              
                            Boolean val = item["empresa planilla"].ToString() == item["empresa comisiones"].ToString() ? true : false;
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{5 + j}", $"A{5 + j}", item[xtipoid.DataPropertyName].ToString(), 10, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, val ? Configuraciones.ColorFilaSeleccionada : val ? Configuraciones.ColorFilaSeleccionada : pos % 2 == 0 ? Color.White : Calterno, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{5 + j}", $"b{5 + j}", item["dcmnto"].ToString(), 10, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, val ? Configuraciones.ColorFilaSeleccionada : pos % 2 == 0 ? Color.White : Calterno, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"c{5 + j}", $"c{5 + j}", item["nombres"].ToString(), 10, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, val ? Configuraciones.ColorFilaSeleccionada : pos % 2 == 0 ? Color.White : Calterno, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"d{5 + j}", $"d{5 + j}", item["Empresa Planilla"].ToString(), 10, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, val ? Configuraciones.ColorFilaSeleccionada : pos % 2 == 0 ? Color.White : Calterno, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"e{5 + j}", $"e{5 + j}", item["Empresa Comisiones"].ToString(), 10, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, val ? Configuraciones.ColorFilaSeleccionada : pos % 2 == 0 ? Color.White : Calterno, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"f{5 + j}", $"f{5 + j}", (decimal)item["Sueldo"], 10, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, val ? Configuraciones.ColorFilaSeleccionada : pos % 2 == 0 ? Color.White : Calterno, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"g{5 + j}", $"g{5 + j}", (decimal)item["Comisión"], 10, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, val ? Configuraciones.ColorFilaSeleccionada : pos % 2 == 0 ? Color.White : Calterno, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"h{5 + j}", $"h{5 + j}", (decimal)item["bono"], 10, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, val ? Configuraciones.ColorFilaSeleccionada : pos % 2 == 0 ? Color.White : Calterno, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"i{5 + j}", $"i{5 + j}", (decimal)item["Re-fact"], 10, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, val ? Configuraciones.ColorFilaSeleccionada : pos % 2 == 0 ? Color.White : Calterno, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                            //
                            Nombre = item["nombres"].ToString();
                            j++;
                            c++;
                        }
                        else
                        {
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{5 + j}", $"A{5 + j}", "", 10, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 0 ? Color.White : Calterno, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"b{5 + j}", $"b{5 + j}", "", 10, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 0 ? Color.White : Calterno, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"c{5 + j}", $"c{5 + j}", $"TOTAL DE {Nombre}", 10, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 0 ? Color.White : Calterno, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"d{5 + j}", $"d{5 + j}", "", 10, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 0 ? Color.White : Calterno, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"e{5 + j}", $"e{5 + j}", "", 10, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 0 ? Color.White : Calterno, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"f{5 + j}", $"f{5 + j}", SSueldo, 10, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 0 ? Color.White : Calterno, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"g{5 + j}", $"g{5 + j}", SComision, 10, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 0 ? Color.White : Calterno, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"h{5 + j}", $"h{5 + j}", SBono, 10, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 0 ? Color.White : Calterno, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"i{5 + j}", $"i{5 + j}", SRefacturar, 10, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 0 ? Color.White : Calterno, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                            SComision = SBono = SSueldo = SRefacturar = 0;
                            j += 2;
                            pos++;

                        }
                    }
                    //TOTAL GENERAL
                    j--;
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"c{5 + j}", $"c{5 + j}", $"TOTAL DE GENERAL", 10, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"f{5 + j}", $"f{5 + j}", TSueldo, 10, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"g{5 + j}", $"g{5 + j}", TComision, 10, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"h{5 + j}", $"h{5 + j}", TBono, 10, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"i{5 + j}", $"i{5 + j}", TRefacturar, 10, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                    //
                    HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(null, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, Hoja, Celdas, FilCabecera, new int[] { },
                        new int[] { }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, }, "", true);
                    //Agregamos un MES  

                }
                msgOK($"Archivo Grabados en \n{folderBrowserDialog1.SelectedPath}");
                if (backgroundWorker1.IsBusy) backgroundWorker1.CancelAsync();
            }
            else msgError("No hay Registros en la Grilla");
        }
    }
}
