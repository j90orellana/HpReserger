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

namespace HPReserger.ModuloActivoFijo
{
    public partial class frmReporteCostoyDepreciacionActivo : FormGradient
    {
        public frmReporteCostoyDepreciacionActivo()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private int idempresa;
        private void frmReporteCostoyDepreciacionActivo_Load(object sender, EventArgs e)
        {
            CargarEmpresa();
            cbodesde.Fecha(new DateTime(DateTime.Now.Year, 1, 1));
        }
        public void CargarEmpresa()
        {
            CapaLogica.TablaEmpresas(cboempresa);
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void msgError(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        frmProcesando frmproce;
        DataTable TDatos;
        DateTime FechaInicial, FechaFin;
        private string NameEmpresa;

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //VALIDACIONES
            if (cboempresa.SelectedValue == null) { cboempresa.Focus(); msgError("Seleccione una Empresa"); return; }
            //
            if (cbodesde.FechaFinMes > cboA.FechaFinMes)
            {
                FechaFin = cbodesde.FechaFinMes;
                FechaInicial = cboA.FechaInicioMes;
            }
            else
            {
                FechaInicial = cbodesde.FechaInicioMes;
                FechaFin = cboA.FechaFinMes;
            }
            TDatos = CapaLogica.ReporteDepreciacionActivoFijo(idempresa, FechaInicial, FechaFin);
            if (TDatos.Rows.Count == 0)
            {
                msgError("No hay Registros para Mostrar");
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                backgroundWorker1.WorkerSupportsCancellation = true;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.Default;
                    frmproce = new HPReserger.frmProcesando();
                    frmproce.Show();
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
                else
                {
                    Cursor = Cursors.Default;
                    return;
                }
            }
        }
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboempresa.Items.Count > 0)
            {
                if (cboempresa.SelectedValue != null)
                {
                    idempresa = (int)cboempresa.SelectedValue;
                    NameEmpresa = cboempresa.Text;
                }
            }
            else msgError("No hay Empresas");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (TDatos.Rows.Count > 0)
            {
                //DESARROLLO PARA MOSTRAR EL ESQUEMA DEL REPORTE DEL EXCEL
                DateTime FechaTemp = FechaInicial;
                List<string> ListCuentas = new List<string>();
                //AGREGAMOS LAS CUENTAS CONTABLES A UNA LISTA PARA FILTRAR
                foreach (DataRow item in TDatos.Rows)
                {
                    if (!ListCuentas.Contains(item["cuentaactivo"].ToString()))
                        ListCuentas.Add(item["cuentaactivo"].ToString());
                }
                DataView dv = TDatos.AsDataView();
                string Carpeta = folderBrowserDialog1.SelectedPath;
                //
                string EmpresaValor = Configuraciones.ValidarRutaValida(NameEmpresa);
                //string Ruc = CapaLogica.BuscarRucEmpresa(EmpresaValor)[0].ToString();
                string valor = Carpeta + @"\";
                //if (chkCarpetas.Checked)
                //{
                valor = Carpeta + @"\" + EmpresaValor + @"\";
                if (!Directory.Exists(Carpeta + @"\" + EmpresaValor))
                    Directory.CreateDirectory(Carpeta + @"\" + Configuraciones.ValidarRutaValida(EmpresaValor));
                //}
                string NameFile = "";
                if (FechaInicial.Month == FechaFin.Month && FechaInicial.Year == FechaFin.Year)
                    NameFile = valor + $"RP-AF {EmpresaValor} {FechaInicial.ToString("MMM-yyyy").ToUpper()}.xlsx";
                else
                    NameFile = valor + $"RP-AF {EmpresaValor} {FechaInicial.ToString("MMM-yyyy").ToUpper()}-{FechaFin.ToString("MMM-yyyy").ToUpper()}.xlsx";
                //ELiminamos el Excel Antiguo
                File.Delete(NameFile);
                File.Exists(NameFile);
                //DEFINICIONES
                int i = 0; //posicion de la hoja no  es index
                int Hoja = 0;
                Color BackAlterno = Color.FromArgb(220, 230, 241);
                Color ForeAlterno = Color.Black;
                Color BackColumna = Color.FromArgb(78, 129, 189);
                Color ForeColumna = Color.White;
                //
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(BackAlterno, Configuraciones.FuenteReportesTahoma10, ForeAlterno);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(BackColumna, Configuraciones.FuenteReportesTahoma10, ForeColumna);
                //RECORREMOS EL RANGO DE PERIODOS QUE SE INGRESO
                while (FechaTemp < FechaFin)
                {
                    DateTime FechaTempFinMes = Configuraciones.FinDelMes(FechaTemp);
                    Hoja++;
                    String _NombreHoja = $"{FechaTemp.ToString("MMMM yy")}";
                    List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{1 + i}", $"Q{1 + i}", EmpresaValor, 12, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{3 + i}", $"Q{3 + i}", "DETALLE DE ACTIVO FIJO", 9, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{4 + i}", $"Q{4 + i}", ($"COSTO Y DEPRECIACIÓN ACUMULADA AL {FechaTemp.ToString("30 'DE' MMMM yyyy")}").ToUpper(), 9, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));

                    foreach (string NroCuentas in ListCuentas)
                    {
                        i = 0;
                        //CABECERA DEL EXCEL
                        string cadena = $" cuentaactivo= '{NroCuentas}' and fechacontable ='{FechaTempFinMes}'";
                        dv.RowFilter = cadena;
                        DataTable TablaResult = dv.ToTable();
                        if (TablaResult.Rows.Count > 0)
                        {
                            DataRow Fila = TablaResult.Rows[0];
                            //CABECERAS
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{7 + i}", $"A{7 + i}", "Fecha Activ.", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{7 + i}", $"B{7 + i}", "Fecha Doc.", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{7 + i}", $"C{7 + i}", "Código Act.", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{7 + i}", $"D{7 + i}", "Asiento", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{7 + i}", $"E{7 + i}", "Descripción", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"F{7 + i}", $"F{7 + i}", "Activo Histórico", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"G{7 + i}", $"G{7 + i}", $"Total Depre. Acum.{FechaTemp.Year - 1}", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"H{7 + i}", $"H{7 + i}", $"Neto {FechaTemp.Year - 1} Ségun Balance", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"I{7 + i}", $"I{7 + i}", "% Tasa", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"J{7 + i}", $"J{7 + i}", "Meses", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"K{7 + i}", $"K{7 + i}", "Alta Activo", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"L{7 + i}", $"L{7 + i}", $"Total Activo {FechaTemp.ToString("MMM yy")}", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"M{7 + i}", $"M{7 + i}", $"Gasto Deprec. {FechaTemp.Year}", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"N{7 + i}", $"N{7 + i}", $"Deprec. Acumul.", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"O{7 + i}", $"O{7 + i}", $"Activo Fijo Neto {FechaTemp.ToString("MMM yy")}", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"P{7 + i}", $"P{7 + i}", $"Deprec. Acumul PER Anteri.", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"Q{7 + i}", $"Q{7 + i}", $"Deprec. Periodo Mes", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            //
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{8 + i}", $"E{8 + i}", $"{Fila["cuenta_contable"].ToString()}", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Red, Configuraciones.FuenteReportesTahoma10, true));
                            foreach (DataRow item in TablaResult.Rows)
                            {
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{9 + i}", $"A{9 + i}", $"{((DateTime)item["fechaactivacion"]).ToString("d")}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));

                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{9 + i}", $"C{9 + i}", $"{item["cod"].ToString()}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{9 + i}", $"D{9 + i}", $"{item["cuoactivo"].ToString()}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{9 + i}", $"E{9 + i}", $"{item["Descripcion"].ToString()}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"F{9 + i}", $"F{9 + i}", $"{(decimal)item["valoractivo"]}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"G{9 + i}", $"G{9 + i}", $"{-(decimal)item["DeprecAcumuladaAnioPas"]}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Red, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"H{9 + i}", $"H{9 + i}", $"{(decimal)item["ActivoNetoPas"]}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"I{9 + i}", $"I{9 + i}", $"{item["tasa"]}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"J{9 + i}", $"J{9 + i}", $"{(int)item["mes"]}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"K{9 + i}", $"K{9 + i}", $"0.00", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"L{9 + i}", $"L{9 + i}", $"{(decimal)item["totalactivo"]}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"M{9 + i}", $"M{9 + i}", $"{-(decimal)item["GastoDepreciacion"]}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Red, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"N{9 + i}", $"N{9 + i}", $"{-(decimal)item["DepreciacionAcumulada"]}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Red, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"O{9 + i}", $"O{9 + i}", $"{(decimal)item["TotalActivoNeto"]}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"P{9 + i}", $"P{9 + i}", $"{-(decimal)item["DeprecAcumuladaAnteriorPER"]}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Red, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"Q{9 + i}", $"Q{9 + i}", $"{-(decimal)item["vcontable"]}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Red, Configuraciones.FuenteReportesTahoma10, true));
                                i++;
                            }
                            i += 3;
                        }

                        HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(null, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, Hoja, Celdas, 7, new int[] { }, new int[] { },
                            new int[] { 1, 2, 3, 4, 5 }, "", false);
                        //Agregamos un MES  
                        FechaTemp = FechaTemp.AddMonths(1);
                    }




                    //
                    //foreach (DateTime FechaCierre in ListadoFecha)
                    //{
                    //    cadena = $"empresa = '{NameEmpresa}' and fecha = '{FechaCierre}' and Nro_Cta= '{NroCuentas}'";
                    //    //    cadena = "";
                    //    dvf.RowFilter = cadena;
                    //    TablaResult = dvf.ToTable();
                    //    //Sí No hay datos Buscamos otra fila
                    //    if (TablaResult.Rows.Count != 0)
                    //    {
                    //        //string añio = fechas.Substring(0, 4);
                    //        //string mes = fechas.Substring(4, 2);
                    //        //Sí no hay datos
                    //        if (TablaResult.Rows.Count > 0)
                    //        {
                    //            DataRow FilaX = TablaResult.Rows[0];
                    //            string _Cabecera = "";
                    //            string _NColumna = "";
                    //            string CUOArrastre = "";

                    //            decimal SaldoContable = 0, EstadoCuenta = 0, SaldoContableAux = 0, EstadoCuentaAux = 0;
                    //            SaldoContable = ((Decimal)FilaX["saldocontableinicial"]);
                    //            EstadoCuenta = ((Decimal)FilaX["ESTADOCUENTAinicial"]);
                    //            SaldoContableAux = ((Decimal)FilaX["saldocontableinicial"]);
                    //            EstadoCuentaAux = ((Decimal)FilaX["ESTADOCUENTAinicial"]);
                    //            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{8 + i}", $"G{8 + i}", $"MES DE {((DateTime)FilaX["fecha"]).ToString("MMMM").ToUpper()} - {((DateTime)FilaX["Fecha"]).Year.ToString()} ", 8, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Red, Configuraciones.FuenteReportesTahoma10, true));
                    //            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"G{9 + i}", $"G{9 + i}", "Saldo Anterior", 8, true, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                    //            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"K{9 + i}", $"K{9 + i}", SaldoContable, 8, true, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                    //            //Detalle de los Movimientos de sistemas = tipò = 2
                    //            decimal SumatoriaT1Abonos = 0, SumatoriaT1Cargos = 0, SumatoriaT2Abonos = 0, SumatoriaT2Cargos = 0;
                    //            //Variables
                    //            DateTime FechaPago = DateTime.Now;
                    //            string NroCheque = "", ProveedorCLiente = "", DetFac = "", RUC = "", NroOpBanco = "";
                    //            decimal Total = 0;
                    //            int contador = 0;
                    //            //
                    //            int pos = 0;
                    //            foreach (DataRow item in TablaResult.Rows)
                    //            {
                    //                if ((((int)item["grupo"] != 0) && FechaCierre.Month == ((DateTime)item["Fechapago"]).Month && FechaCierre.Year == ((DateTime)item["Fechapago"]).Year)
                    //                    ||
                    //                    (((int)item["pkid"] == 0) && ((int)item["grupo"] == 0)))
                    //                {
                    //                    if (CUOArrastre == item["cuo"].ToString() && item["cuo"].ToString() != "" && item["total"].ToString() != "")//QUIERE DECIR QUE ES EL MISMO ASIENTO - MOSTRAREMOS DETALLE
                    //                    {
                    //                        pos = 0;
                    //                        if (contador == 0)
                    //                        {
                    //                            contador++;
                    //                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{10 + i - 1}", $"B{10 + i - 1}", "TLC", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{10 + i - 1}", $"C{10 + i - 1}", "", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{10 + i - 1}", $"D{10 + i - 1}", "", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{10 + i - 1}", $"E{10 + i - 1}", "", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"F{10 + i - 1}", $"F{10 + i - 1}", "".ToString(), 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));

                    //                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{10 + i}", $"A{10 + i}", CUOArrastre, 8, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{10 + i}", $"B{10 + i}", FechaPago.ToString("dd/MM/yyyy"), 8, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{10 + i}", $"C{10 + i}", NroCheque, 8, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                            //nROOPERACION
                    //                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{10 + i}", $"D{10 + i}", NroOpBanco, 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                            //ruc
                    //                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{10 + i}", $"E{10 + i}", RUC, 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                            //RAZONSOCIAL
                    //                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"F{10 + i}", $"F{10 + i}", ProveedorCLiente, 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"G{10 + i}", $"G{10 + i}", DetFac, 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"H{10 + i}", $"H{10 + i}", Total, 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"K{10 + i}", $"K{10 + i}", SaldoContableAux, 8, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                            i++;
                    //                        }
                    //                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{10 + i}", $"A{10 + i}", item["cuo"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{10 + i}", $"B{10 + i}", ((DateTime)item["FECHAPAGO"]).ToString("dd/MM/yyyy"), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{10 + i}", $"C{10 + i}", item["NROCHEQUE"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                        //NRO OPERACION
                    //                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{10 + i}", $"D{10 + i}", item["NroOpBanco"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                        //RUC
                    //                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{10 + i}", $"E{10 + i}", item["RUC"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                        //RAZONSOCIAL
                    //                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"F{10 + i}", $"F{10 + i}", item["PROVEEDORCLIENTE"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"G{10 + i}", $"G{10 + i}", item["DETFAC"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                        Total = item["total"].ToString() == "" ? (decimal)item["abono"] + (decimal)item["cargos"] : (decimal)item["total"];
                    //                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"H{10 + i}", $"H{10 + i}", Total, 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"K{10 + i}", $"K{10 + i}", SaldoContableAux, 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                    }
                    //                    else
                    //                    {
                    //                        pos = 1;
                    //                        contador = 0;
                    //                        SaldoContableAux += (decimal)item["abono"] - Math.Abs((decimal)item["cargos"]);
                    //                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{10 + i}", $"A{10 + i}", item["cuo"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{10 + i}", $"B{10 + i}", ((DateTime)item["FECHAPAGO"]).ToString("dd/MM/yyyy"), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{10 + i}", $"C{10 + i}", item["NROCHEQUE"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{10 + i}", $"D{10 + i}", item["NroOpBanco"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{10 + i}", $"E{10 + i}", item["RUC"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"F{10 + i}", $"F{10 + i}", item["PROVEEDORCLIENTE"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"G{10 + i}", $"G{10 + i}", item["CONCEPTO"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"I{10 + i}", $"I{10 + i}", (decimal)item["ABONO"], 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"J{10 + i}", $"J{10 + i}", Math.Abs((decimal)item["CARGOS"]), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"K{10 + i}", $"K{10 + i}", SaldoContableAux, 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                        //CARGA VARIABLES MOMENTANIAS
                    //                        FechaPago = ((DateTime)item["FECHAPAGO"]);
                    //                        NroCheque = item["NROCHEQUE"].ToString();
                    //                        RUC = item["RUC"].ToString();
                    //                        ProveedorCLiente = item["PROVEEDORCLIENTE"].ToString();
                    //                        NroOpBanco = item["NroOpBanco"].ToString();
                    //                        DetFac = item["DETFAC"].ToString();
                    //                        if (item["total"].ToString() != "")
                    //                            Total = ((decimal)(item["TOTAL"] ?? 0.00));
                    //                        //
                    //                        SumatoriaT2Abonos += (decimal)item["abono"];
                    //                        SumatoriaT2Cargos += (decimal)item["cargos"];
                    //                        //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{11 + i}", $"D{11 + i}", Valor, 8, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                    }
                    //                    i++;
                    //                    CUOArrastre = item["cuo"].ToString();
                    //                }
                    //            }
                    //            if (SumatoriaT2Abonos + SumatoriaT2Cargos != 0)
                    //            {
                    //                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"G{11 + i}", $"G{11 + i}", "Saldo Según Libro:", 8, true, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));
                    //                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"I{11 + i}", $"I{11 + i}", SumatoriaT2Abonos, 8, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));
                    //                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"J{11 + i}", $"J{11 + i}", Math.Abs(SumatoriaT2Cargos), 8, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));
                    //                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"K{11 + i}", $"K{11 + i}", SaldoContableAux, 8, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));
                    //            }
                    //            ////////////
                    //            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{13 + i}", $"C{13 + i }", "(+)", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma10, true));
                    //            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"F{12 + i}", $"F{12 + i }", "Conciliación Bancaria", 8, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma10, true));
                    //            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"F{13 + i}", $"F{13 + i }", "Mas Cheques No Cobrados :", 8, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma10, true));
                    //            //Detalle de los Movimientos Bancarios no Registrados
                    //            pos = 0;
                    //            foreach (DataRow item in TablaResult.Rows)
                    //            {
                    //                //CHEQUES NO COBRADOS
                    //                if ((int)item["tipo"] == 2 && (int)item["grupo"] == 0 && (int)item["pkid"] != 0)
                    //                {
                    //                    pos++;
                    //                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{15 + i}", $"B{15 + i}", ((DateTime)item["FECHAPAGO"]).ToString("dd/MM/yyyy"), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{15 + i}", $"C{15 + i}", item["NROCHEQUE"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{15 + i}", $"E{15 + i}", item["RUC"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"F{15 + i}", $"F{15 + i}", item["DETFAC"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"G{15 + i}", $"G{15 + i}", item["CONCEPTO"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"I{15 + i}", $"I{15 + i}", (decimal)item["ABONO"], 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"J{15 + i}", $"J{15 + i}", Math.Abs((decimal)item["CARGOS"]), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                    //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"I{15 + i}", $"I{15 + i}", SaldoContableAux, 8, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));

                    //                    decimal Valor = (-1 * (decimal)item["abono"]) + (-1 * (decimal)item["cargos"]);
                    //                    SumatoriaT1Abonos += Valor;
                    //                    //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{13 + i}", $"D{13 + i}", Valor, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                    i++;
                    //                }
                    //            }
                    //            //if (SumatoriaT1Abonos + SumatoriaT1Cargos != 0)
                    //            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"K{14 + i - pos}", $"K{14 + i - pos }", SumatoriaT1Abonos, 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));
                    //            //Detalle de OPERACIONES PENDIENTES
                    //            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"F{16 + i}", $"F{16 + i }", "Operaciones Pendientes :", 8, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma10, true));
                    //            //Detalle de los Movimientos Bancarios no Registrados
                    //            pos = 0;
                    //            foreach (DataRow item in TablaResult.Rows)
                    //            {
                    //                //DETALLE DE OPERACIONES PENDIENTES
                    //                if ((int)item["tipo"] == 1 && (int)item["grupo"] == 0 && (int)item["pkid"] != 0)
                    //                {
                    //                    pos++;
                    //                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{17 + i}", $"B{17 + i}", ((DateTime)item["FECHAPAGO"]).ToString("dd/MM/yyyy"), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{17 + i}", $"C{17 + i}", item["NROCHEQUE"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{17 + i}", $"D{17 + i}", item["NroOpBanco"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{17 + i}", $"E{17 + i}", item["RUC"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"F{17 + i}", $"F{17 + i}", item["DETFAC"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"G{17 + i}", $"G{17 + i}", item["CONCEPTO"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"I{17 + i}", $"I{17 + i}", (decimal)item["ABONO"], 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"J{17 + i}", $"J{17 + i}", Math.Abs((decimal)item["CARGOS"]), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                    //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"I{17 + i}", $"I{17 + i}", SaldoContableAux, 8, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));

                    //                    decimal Valor = (-1 * (decimal)item["abono"]) + (-1 * (decimal)item["cargos"]);
                    //                    SumatoriaT1Cargos += Valor;
                    //                    //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{13 + i}", $"D{13 + i}", Valor, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                    //                    i++;
                    //                }
                    //            }
                    //            //if (SumatoriaT1Abonos + SumatoriaT1Cargos != 0)
                    //            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"K{16 + i - pos}", $"K{16 + i - pos }", -SumatoriaT1Cargos, 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));
                    //            //Fila de los Totales
                    //            //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{15 + i }", $"E{15 + i}", (SaldoContable + SumatoriaT1 + SumatoriaT2Abonos), 8, true, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, ForeAmarillo, Configuraciones.FuenteReportesTahoma10, true));
                    //            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"G{18 + i}", $"G{18 + i}", "Saldo Según Banco: ", 8, true, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));
                    //            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"K{18 + i}", $"K{18 + i}", SaldoContableAux + SumatoriaT1Abonos - SumatoriaT1Cargos, 8, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));
                    //            //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{17 + i}", $"C{17 + i}", "CONCILIADO", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));
                    //            //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{17 + i}", $"E{17 + i}", (SaldoContable + SumatoriaT1 + SumatoriaT2Abonos - EstadoCuenta), 8, true, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));
                    //            i += 13;
                    //            //
                    //            /////
                    //            ////Anterior               
                    //            //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", _NombreHoja, Celdas, 5, _Columnas, new int[] { }, new int[] { });
                    //        }
                    //    }

                    //    List<HPResergerFunciones.Utilitarios.Columnas> ListadoColumnas = new List<HPResergerFunciones.Utilitarios.Columnas>();
                    //    ListadoColumnas.Add(new HPResergerFunciones.Utilitarios.Columnas(6, 50));
                    //    ListadoColumnas.Add(new HPResergerFunciones.Utilitarios.Columnas(7, 50));
                    //    HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(null, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, Hoja, Celdas, 6, new int[] { }, new int[] { },
                    //        new int[] { 1, 2, 3, 4, 5 }, "", $"{6}:{6}", ListadoColumnas);
                    //}
                }
                msgOK($"Archivo Grabados en \n{folderBrowserDialog1.SelectedPath}");
                if (backgroundWorker1.IsBusy) backgroundWorker1.CancelAsync();
            }
            else msgError("No hay Registros en la Grilla");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
        }
    }
}

