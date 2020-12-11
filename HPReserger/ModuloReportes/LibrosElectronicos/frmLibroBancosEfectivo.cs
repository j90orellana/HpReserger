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

namespace HPReserger.ModuloReportes.LibrosElectronicos
{
    public partial class frmLibroBancosEfectivo : FormGradient
    {
        public frmLibroBancosEfectivo()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private string NombreEmpresa;
        private DateTime FechaInicial;
        private DateTime FechaFinal;

        public void msgError(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        DataTable TablaEmpresa;
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
        private void LibroBancosEfectivo_Load(object sender, EventArgs e)
        {
            txtbuscuentas.CargarTextoporDefecto();
            cargarEmpresa();
        }
        DataTable TDatos;
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();
            if (Configuraciones.ValidarSQLInyect(txtbuscuentas)) { msgError("Codigo Malicioso Detectado"); return; }
            Cursor = Cursors.WaitCursor;
            if (chklist.CheckedItems.Count == 0) { msgError("Seleccione una Empresa"); return; }
            DateTime FechaAuxiliar;
            ListadoEmpresas = "";
            if (cboperiodode.FechaInicioMes > cboperiodohasta.FechaInicioMes)
            {
                FechaAuxiliar = cboperiodode.FechaInicioMes;
                cboperiodode.Fecha(cboperiodohasta.FechaInicioMes);
                cboperiodohasta.Fecha(FechaAuxiliar);
            }
            FechaInicial = cboperiodode.GetFechaPRimerDia();
            FechaFinal = cboperiodohasta.FechaFinMes;
            foreach (string item in chklist.CheckedItems)
            {
                if (item.ToString() != "TODAS")
                    ListadoEmpresas += CapaLogica.BuscarRucEmpresa(item)[1].ToString() + ",";
            }
            ListadoEmpresas = ListadoEmpresas.Substring(0, ListadoEmpresas.Length - 1);
            if (txtbuscuentas.TextValido() == "")
            {
                TDatos = CapaLogica.FormatoCajaBanco1_1(ListadoEmpresas, FechaInicial, FechaFinal);
                dtgconten.DataSource = TDatos;
            }
            else
            {
                TDatos = CapaLogica.FormatodeCompras8_1_Masivo(ListadoEmpresas, FechaInicial, FechaFinal);
                dtgconten.DataSource = TDatos;
            }
            lblmensaje.Text = $"Total de Registros: {dtgconten.RowCount}";
            if (dtgconten.RowCount == 0) msgError("No Hay Registros");
            //Cambiamos los valores de la columna M
            int c = 1; string cuo = "";
            //foreach (DataRow item in TDatos.Rows)
            //{
            //    if (cuo == item[xcuo.DataPropertyName].ToString())
            //    {
            //        item[xCorrelativo.DataPropertyName] = $"M{++c}";
            //        cuo = item[xcuo.DataPropertyName].ToString();
            //    }
            //    else
            //    {
            //        c = 1;
            //        item[xCorrelativo.DataPropertyName] = $"M{1}";
            //        cuo = item[xcuo.DataPropertyName].ToString();
            //    }
            //}
            Cursor = Cursors.Default;
            Ordenado = false;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int x = 0;
        //    if (cboempresa.Items.Count > 0)
        //    {
        //        x = cboempresa.SelectedIndex;
        //        DataRow Fila = ((DataTable)cboempresa.DataSource).Rows[x];
        //        txtruc.Text = Fila["ruc"].ToString();
        //        txtRucDeudor.Text = txtruc.Text;
        //    }
        //    else
        //    {
        //        txtruc.CargarTextoporDefecto();
        //    }
        //}
        frmProcesando frmproce;
        public void CerrarPanelTxt()
        {
            //PanelTxt.Visible = false;
        }
        private void btnexcel_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();
            Auditoria = false;
            backgroundWorker1.WorkerSupportsCancellation = true;
            if (dtgconten.RowCount > 0)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    dtgconten.SuspendLayout();
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
                msgError("No hay Datos que Exportar");
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                DateTime FechaInicial = cboperiodode.FechaInicioMes;
                List<string> ListadoFecha = new List<string>();
                while (FechaInicial < FechaFinal)
                {
                    ListadoFecha.Add(FechaInicial.ToString("yyyyMM"));
                    FechaInicial = FechaInicial.AddMonths(1);
                }
                foreach (var item in chklist.CheckedItems)
                {
                    //EMPRESAS
                    if (item.ToString() != "TODAS")
                    {
                        string Carpeta = folderBrowserDialog1.SelectedPath;
                        string EmpresaValor = item.ToString().ToUpper();
                        string Ruc = CapaLogica.BuscarRucEmpresa(EmpresaValor)[0].ToString();
                        string valor = Carpeta + @"\";
                        if (chkCarpetas.Checked)
                        {
                            valor = Carpeta + @"\" + Configuraciones.ValidarRutaValida(EmpresaValor) + @"\";
                            if (!Directory.Exists(Carpeta + @"\" + EmpresaValor))
                                Directory.CreateDirectory(Carpeta + @"\" + Configuraciones.ValidarRutaValida(EmpresaValor));
                        }
                        //Asignacion de Nombre y Eliminacion del Excel Antiguo 
                        string Cadenax = "";
                        if (cboperiodode.FechaInicioMes.Month == FechaFinal.Month && cboperiodode.FechaInicioMes.Year == FechaFinal.Year)
                            Cadenax = cboperiodode.FechaInicioMes.ToString("MMMyyyy");
                        else
                            Cadenax = cboperiodode.FechaInicioMes.ToString("MMMyyyy") + "-" + FechaFinal.ToString("MMMyyyy");
                        string NameFile = valor + $"{Cadenax.ToUpper()} 1.1 LIBRO CAJA Y BANCOS {EmpresaValor}{(Auditoria ? "-AUD" : "")}.xlsx";
                        File.Delete(NameFile);
                        File.Exists(NameFile);
                        if (item.ToString() != "TODAS")
                        {
                            DataView dv = Auditoria ? TAuditoria.Copy().AsDataView() : TDatos.Copy().AsDataView();
                            dv.RowFilter = $"empresa like '{EmpresaValor}'";
                            //POR PERIODOS
                            int contador = 1; //posicion de la hoja no  es index
                            foreach (string fechas in ListadoFecha)
                            {
                                DataView dvf = new DataView(dv.ToTable());
                                dvf.RowFilter = $"periodo like '{fechas}00'";
                                DataTable TablaResult = dvf.ToTable();
                                string añio = fechas.Substring(0, 4);
                                string mes = fechas.Substring(4, 2);
                                DateTime Periodo = new DateTime(int.Parse(añio), int.Parse(mes), 1);
                                //Sí no hay datos
                                if (TablaResult.Rows.Count > 0)
                                {
                                    //Modificamos el Excel
                                    string _NombreHoja = ""; string _Cabecera = ""; int[] _OrdenarColumnas; string _NColumna = "";
                                    _NombreHoja = $"{fechas}"; _Cabecera = "1.1 LIBRO CAJA Y BANCOS - DETALLE DE LOS MOVIMIENTOS DEL EFECTIVO";
                                    _OrdenarColumnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
                                    _NColumna = "m";
                                    List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                                    //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                                    Color BackGrilla = Color.White;// Color.FromArgb(204, 218, 231);
                                    Color ForeAmarillo = Color.FromArgb(228, 255, 0);
                                    Color ForeBlanco = Color.White;
                                    Color Back = Color.White;// Color.FromArgb(78, 129, 189);
                                    Color Fore = Color.Black;// Color.FromArgb(255, 255, 255);
                                    Color ForeBlack = Color.Black;
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", "B3", $"{Ruc}", 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                    if (!Auditoria)
                                    {
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "n1", _Cabecera.ToUpper(), 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "PERIODO:", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", $"{Periodo.ToString("yyyy MM")}", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", "RUC:", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", "g4", "APELLIDOS Y NOMBRES, DENOMINACIÓN O RAZÓN SOCIAL:", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("h4", "n4", $"{EmpresaValor}", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                    }
                                    else
                                    {
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "g1", _Cabecera.ToUpper(), 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "PERIODO:", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", $"{Periodo.ToString("yyyy MM")}", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", "RUC:", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", "c4", "APELLIDOS Y NOMBRES, DENOMINACIÓN O RAZÓN SOCIAL:", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("d4", "g4", $"{EmpresaValor}", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                    }
                                    //Caso de Auditoria
                                    if (Auditoria)
                                    {
                                        List<string> ListadoCuentas = new List<string>();
                                        foreach (DataRow filas in TablaResult.Rows)
                                        {
                                            if (!ListadoCuentas.Contains(filas["codigo"].ToString()))
                                                ListadoCuentas.Add(filas["codigo"].ToString());
                                        }
                                        int pos = 0;
                                        DataView dx = TablaResult.AsDataView();
                                        //cabeceras
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{6 + pos}", $"A{6 + pos}", "Nº CORRELATIVO DEL REGISTRO", 10, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8, true));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{6 + pos}", $"B{6 + pos}", "FECHA DE OPERACIÓN", 10, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8, true));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{6 + pos}", $"C{6 + pos}", "DESCRIPCIÓN DE LA OPERACIÓN", 10, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8, true));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{6 + pos}", $"D{6 + pos}", "CÓDIGO CUENTA", 10, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8, true));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{6 + pos}", $"E{6 + pos}", "CUENTA DENOMINACIÓN", 10, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8, true));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"F{6 + pos}", $"F{6 + pos}", "SALDO DEUDOR", 10, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8, true));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"G{6 + pos}", $"G{6 + pos}", "SALDO ACREEDOR", 10, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8, true));
                                        //fin caceberas
                                        foreach (string CUENTAS in ListadoCuentas)
                                        {
                                            decimal SumaDeudor = 0, SumaAcreedor = 0, Sumatoria = 0;
                                            dx.RowFilter = $"codigo ='{CUENTAS}'";
                                            DataTable TablaAux = dx.ToTable();
                                            if (TablaAux.Rows.Count > 0)
                                            {
                                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{8 + pos}", $"g{8 + pos}", $"CUENTA: {TablaAux.Rows[0]["codigo"].ToString()} - {TablaAux.Rows[0]["cuentacontable"].ToString()}", 8, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                                //Colocamos los Nombres de las Columnas en Base al Excel                                     
                                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{9 + pos}", $"C{9 + pos}", $"SALDO INICIAL", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                                decimal Monto = (decimal)TablaAux.Rows[0]["Saldosoles"];
                                                if (Monto >= 0)
                                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"f{9 + pos}", $"f{9 + pos}", Math.Abs(Monto), 8, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma8, true));
                                                else
                                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"g{9 + pos}", $"g{9 + pos}", Math.Abs(Monto), 8, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma8, true));
                                                Sumatoria += Monto;
                                                SumaDeudor += Monto > 0 ? Math.Abs(Monto) : 0;
                                                SumaAcreedor += Monto < 0 ? Math.Abs(Monto) : 0;
                                                int i = 0;
                                                foreach (DataRow Filas in TablaAux.Rows)
                                                {
                                                    i++;
                                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{10 + pos}", $"a{10 + pos}", Filas["cuo"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, i % 2 == 1 ? ForeBlanco : BackGrilla, ForeBlack, Configuraciones.FuenteReportesTahoma8, (i % 2 == 0 ? true : false)));
                                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{10 + pos}", $"b{10 + pos}", ((DateTime)Filas["fechaoperacion"]).ToString("dd/MM/yyyy"), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, i % 2 == 1 ? ForeBlanco : BackGrilla, ForeBlack, Configuraciones.FuenteReportesTahoma8, (i % 2 == 0 ? true : false)));
                                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"c{10 + pos}", $"c{10 + pos}", Filas["glosa"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, i % 2 == 1 ? ForeBlanco : BackGrilla, ForeBlack, Configuraciones.FuenteReportesTahoma8, (i % 2 == 0 ? true : false)));
                                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"d{10 + pos}", $"d{10 + pos}", Filas["codigo"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, i % 2 == 1 ? ForeBlanco : BackGrilla, ForeBlack, Configuraciones.FuenteReportesTahoma8, (i % 2 == 0 ? true : false)));
                                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"e{10 + pos}", $"e{10 + pos}", Filas["cuentacontable"].ToString(), 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, i % 2 == 1 ? ForeBlanco : BackGrilla, ForeBlack, Configuraciones.FuenteReportesTahoma8, (i % 2 == 0 ? true : false)));
                                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"f{10 + pos}", $"f{10 + pos}", (decimal)Filas["deudor"], 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, i % 2 == 1 ? ForeBlanco : BackGrilla, ForeBlack, Configuraciones.FuenteReportesTahoma8, (i % 2 == 0 ? true : false)));
                                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"g{10 + pos}", $"g{10 + pos}", (decimal)Filas["acreedor"], 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, i % 2 == 1 ? ForeBlanco : BackGrilla, ForeBlack, Configuraciones.FuenteReportesTahoma8, (i % 2 == 0 ? true : false)));
                                                    //Sumatoria
                                                    SumaDeudor += (decimal)Filas["deudor"];
                                                    SumaAcreedor += (decimal)Filas["acreedor"];
                                                    Sumatoria += ((decimal)Filas["deudor"] - (decimal)Filas["acreedor"]);
                                                    pos++;
                                                }
                                                //Totalizando
                                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"c{ 10 + pos}", $"c{10 + pos}", $"SALDO FINAL PARA EL SIGUIENTE MES", 8, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"{(Sumatoria < 0 ? "F" : "G")}{ 10 + pos}", $"{(Sumatoria < 0 ? "F" : "G")}{10 + pos}", Math.Abs(Sumatoria), 8, true, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma8, false));

                                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"c{ 11 + pos}", $"c{11 + pos}", $"TOTAL DE LA CUENTA {CUENTAS}", 8, true, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"f{ 11 + pos}", $"f{11 + pos}", SumaDeudor + (Sumatoria < 0 ? Math.Abs(Sumatoria) : 0), 8, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma8, false));
                                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"g{ 11 + pos}", $"g{11 + pos}", SumaAcreedor + (Sumatoria > 0 ? Math.Abs(Sumatoria) : 0), 8, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma8, false));
                                                //
                                                pos += 5;
                                            }
                                        }
                                    }
                                    ///////estilos de la celdas
                                    HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, Configuraciones.FuenteReportesTahoma8, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                                    HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, Configuraciones.FuenteReportesTahoma8, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                                    /////fin estilo de las celdas                                 
                                    /////
                                    ////Anterior               
                                    //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", _NombreHoja, Celdas, 5, _Columnas, new int[] { }, new int[] { });
                                    HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(Auditoria ? null : TablaResult, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja,
                                        contador++, Celdas, 6, _OrdenarColumnas, new int[] { }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16
                                        }, "", $"$1:${6}"//!Auditoria
                                        );
                                }
                            }
                        }
                    }
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
            dtgconten.ResumeLayout();
        }
        private void btnGenerarTXT_Click(object sender, EventArgs e)
        {
            PanelTxt.BringToFront();
            if (cboperiodode.FechaInicioMes.Year == cboperiodohasta.FechaInicioMes.Year)
            {
                txtaño.Text = cboperiodode.FechaInicioMes.Year.ToString("0000");
            }
            else txtaño.Text = "AÑO";
            if (cboperiodode.FechaInicioMes.Month == cboperiodohasta.FechaInicioMes.Month)
            {
                txtmes.Text = cboperiodode.FechaInicioMes.Month.ToString("00");
            }
            else
                txtmes.Text = "MES";
            int ContadorEmpresas = 0;
            foreach (object item in chklist.CheckedItems)
            {
                if (item.ToString() != "TODAS")
                {
                    ContadorEmpresas++;
                    nameEmpresa = item.ToString();
                    if (ContadorEmpresas > 1) { nameEmpresa = ""; break; }
                }
            }
            if (ContadorEmpresas == 1)
            {
                txtRucDeudor.Text = CapaLogica.BuscarRucEmpresa(nameEmpresa)[0].ToString();
            }
            else txtRucDeudor.Text = "RUC EMPRESAS";
            txtinformacion.Text = (dtgconten.RowCount > 0 ? 1 : 0).ToString();
            PanelTxt.Visible = true;
            PanelTxt.Focus();
        }
        private void buttonPer1_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();
        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private StreamWriter st;
        private string nameEmpresa;
        private bool Ordenado = false;

        private void btnTxt_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (Ordenado)
                btnProcesar_Click(sender, e);
            if (dtgconten.RowCount == 0)
            {
                var Result = msgp("No hay Datos en la Grilla, Igual Desea Generar?");
                if (Result != DialogResult.Yes)
                {
                    msgError("Cancelado por el Usuario");
                    return;
                }
            }
            FechaInicial = cboperiodode.FechaInicioMes;
            List<string> ListadoFecha = new List<string>();
            while (FechaInicial < FechaFinal)
            {
                ListadoFecha.Add(FechaInicial.ToString("yyyyMM"));
                FechaInicial = FechaInicial.AddMonths(1);
            }
            //Avanza para Generar el TXT           
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (var items in chklist.CheckedItems)
                {
                    //EMPRESAS
                    if (items.ToString() != "TODAS")
                    {
                        string Carpeta = folderBrowserDialog1.SelectedPath;
                        string EmpresaValor = items.ToString().ToUpper();
                        string Ruc = CapaLogica.BuscarRucEmpresa(EmpresaValor)[0].ToString();
                        string valor = Carpeta + @"\";
                        if (chkCarpetas.Checked)
                        {
                            valor = Carpeta + @"\" + Configuraciones.ValidarRutaValida(EmpresaValor) + @"\";
                            if (!Directory.Exists(Carpeta + @"\" + EmpresaValor))
                                Directory.CreateDirectory(Carpeta + @"\" + Configuraciones.ValidarRutaValida(EmpresaValor));
                        }
                        if (items.ToString() != "TODAS")
                        {
                            DataView dv = TDatos.Copy().AsDataView();
                            dv.RowFilter = $"empresa like '{EmpresaValor}'";
                            //POR PERIODOS
                            foreach (string fechas in ListadoFecha)
                            {
                                DataView dvf = new DataView(dv.ToTable());
                                dvf.RowFilter = $"periodo like '{fechas}00'";
                                DataTable TablaResult = dvf.ToTable();
                                string añio = fechas.Substring(0, 4);
                                string mes = fechas.Substring(4, 2);
                                //Sí no hay datos 8.1 Vacio
                                if (TablaResult.Rows.Count == 0)
                                {
                                    SaveFile.FileName = $"{valor}LE{Ruc}{añio}{mes}00010100001{0}11.txt";
                                    //grabamos
                                    string path = SaveFile.FileName;
                                    st = File.CreateText(path);
                                    st.Write("");
                                    st.Close();
                                }
                                //si hay datos
                                else
                                {
                                    //Avanza para Generar el TXT
                                    string[] campo = new string[20];
                                    string cadenatxt = "";            //int ValorPrueba = 0;
                                    foreach (DataRow item in TablaResult.Rows)
                                    {
                                        //ValorPrueba = 0;
                                        int c = 0;
                                        //1
                                        campo[c++] = item[xperiodo.DataPropertyName].ToString().Trim();
                                        campo[c++] = item[xcuo.DataPropertyName].ToString().Trim();
                                        campo[c++] = item[xCorrelativo.DataPropertyName].ToString().Trim();
                                        campo[c++] = item[xCodigoCuenta.DataPropertyName].ToString().Trim();
                                        campo[c++] = item[xCodigoOperacion.DataPropertyName].ToString().Trim();
                                        campo[c++] = item[xCentroCosto.DataPropertyName].ToString().Trim();
                                        campo[c++] = item[xMoneda.DataPropertyName].ToString().Trim();
                                        campo[c++] = ((int)item[xTipoComprobante.DataPropertyName]).ToString("00");
                                        campo[c++] = item[xSerieComprobante.DataPropertyName].ToString().Trim();
                                        //10
                                        campo[c++] = Configuraciones.CadenaDelimitada(Configuraciones.AlfaNumericoSunat(item[xNumComprobante.DataPropertyName].ToString().Trim()), 20);
                                        campo[c++] = item[xFechaContable.DataPropertyName].ToString();
                                        campo[c++] = item[xFechaVence.DataPropertyName].ToString();
                                        campo[c++] = item[xFechaEmision.DataPropertyName].ToString();
                                        campo[c++] = item[xGlosa.DataPropertyName].ToString().Length > 200 ? item[xGlosa.DataPropertyName].ToString().Substring(0, 200) : item[xGlosa.DataPropertyName].ToString();
                                        campo[c++] = item[xGlosa.DataPropertyName].ToString().Length > 200 ? item[xGlosa.DataPropertyName].ToString().Substring(0, 200) : item[xGlosa.DataPropertyName].ToString();
                                        //debe y haber
                                        campo[c++] = ((decimal)item[xDebe.DataPropertyName]).ToString("0.00");
                                        campo[c++] = ((decimal)item[xHaber.DataPropertyName]).ToString("0.00");
                                        //
                                        campo[c++] = item[xDatoEstructurado.DataPropertyName].ToString().Trim();
                                        campo[c++] = ((int)item[xEstado.DataPropertyName]).ToString();
                                        //
                                        //Uniendo por pipes
                                        cadenatxt += string.Join("|", campo) + $"{Environment.NewLine }";
                                        //Limpiamos el Campo
                                        //campo = null;
                                    }
                                    //Formato 1.1
                                    SaveFile.FileName = $"{valor}LE{Ruc}{añio}{mes}00010100001{1}11.txt";
                                    string path = SaveFile.FileName;
                                    st = File.CreateText(path);
                                    st.Write(cadenatxt);
                                    st.Close();
                                }
                            }
                        }
                    }
                }
                SaveFile.FileName = "";
                PanelTxt.Visible = false;
                msgOK("Generado TXT con Éxito");
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.Default;
                msgOK("Cancelado por el Usuario");
            }
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
        }

        private void dtgconten_Sorted(object sender, EventArgs e)
        {
            Ordenado = true;
        }
        DataTable TAuditoria = new DataTable();

        public bool Auditoria { get; private set; }
        string ListadoEmpresas = "";
        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                Auditoria = true;
                DateTime FechaAuxiliar;
                ListadoEmpresas = "";
                if (cboperiodode.FechaInicioMes > cboperiodohasta.FechaInicioMes)
                {
                    FechaAuxiliar = cboperiodode.FechaInicioMes;
                    cboperiodode.Fecha(cboperiodohasta.FechaInicioMes);
                    cboperiodohasta.Fecha(FechaAuxiliar);
                }
                FechaInicial = cboperiodode.GetFechaPRimerDia();
                FechaFinal = cboperiodohasta.FechaFinMes;
                foreach (string item in chklist.CheckedItems)
                {
                    if (item.ToString() != "TODAS")
                        ListadoEmpresas += CapaLogica.BuscarRucEmpresa(item)[1].ToString() + ",";
                }
                ListadoEmpresas = ListadoEmpresas.Substring(0, ListadoEmpresas.Length - 1);
                //if (txtbuscuentas.TextValido() == "")
                //{
                //    TDatos = CapaLogica.FormatoCajaBanco1_1(ListadoEmpresas, FechaInicial, FechaFinal);
                //    dtgconten.DataSource = TDatos;
                //}
                TAuditoria = CapaLogica.FormatoCajaBancos1_1Auditoria(ListadoEmpresas, FechaInicial, FechaFinal);
                //
                CerrarPanelTxt();
                backgroundWorker1.WorkerSupportsCancellation = true;
                if (TAuditoria.Rows.Count > 0)
                {
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    {
                        dtgconten.SuspendLayout();
                        Cursor = Cursors.WaitCursor;
                        frmproce = new HPReserger.frmProcesando();
                        frmproce.Show();
                        if (!backgroundWorker1.IsBusy)
                        {
                            backgroundWorker1.RunWorkerAsync();
                        }
                    }
                }
                else msgError("No hay Datos que Exportar");
            }
        }
        ModuloCrystalReport.frmReporteLibro1_1 frmReportelibro1_1;
        private void button2_Click(object sender, EventArgs e)
        {
            if (dtgconten.Rows.Count == 0) { msgError("No hay datos que Exportar"); return; }
            if (frmReportelibro1_1 == null)
            {
                frmReportelibro1_1 = new ModuloCrystalReport.frmReporteLibro1_1();
                frmReportelibro1_1.ListadoEmpresas = ListadoEmpresas;
                frmReportelibro1_1.FechaIni = FechaInicial;
                frmReportelibro1_1.FechaFin = FechaFinal;
                frmReportelibro1_1.FormClosed += FrmReportelibro1_1_FormClosed;
                frmReportelibro1_1.Show();
            }
            else
            {
                frmReportelibro1_1.Activate();
            }
        }
        private void FrmReportelibro1_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmReportelibro1_1 = null;
        }
    }
}
