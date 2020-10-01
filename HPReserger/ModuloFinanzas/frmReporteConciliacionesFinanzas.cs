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

namespace HPReserger.ModuloFinanzas
{
    public partial class frmReporteConciliacionesFinanzas : FormGradient
    {
        public frmReporteConciliacionesFinanzas()
        {
            InitializeComponent();
        }
        Boolean Cargado = false;
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmReporteConciliacionesFinanzas_Load(object sender, EventArgs e)
        {
            LimpiarBotones();
            Cargado = true;
            FiltrarDatosConciliaciones();
        }
        private void LimpiarBotones()
        {
            txtbusbanco.CargarTextoporDefecto();
            txtbusEmpresa.CargarTextoporDefecto();
            txtbusnrocuenta.CargarTextoporDefecto();
            cbofechaini.Fecha(new DateTime(DateTime.Now.Year, 1, 1));
            cbofechafin.Fecha(new DateTime(DateTime.Now.Year, 12, 31));
        }
        private void txtbusempresa_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatosConciliaciones();
        }
        DateTime FechaInicial;
        DateTime FechaFinal;
        private void FiltrarDatosConciliaciones()
        {
            if (!txtbusbanco.EstaLLeno() && !txtbusEmpresa.EstaLLeno() && !txtbusnrocuenta.EstaLLeno() && !chkFecha.Checked)
            {
                if (dtgconten.DataSource != null) dtgconten.DataSource = ((DataTable)dtgconten.DataSource).Clone();
                lblRegistros.Text = $"Total Registros: {dtgconten.RowCount}";
                return;
            }
            if (Cargado)
            {
                FechaInicial = cbofechaini.FechaFinMes;
                FechaFinal = cbofechafin.FechaFinMes;
                DateTime Fechaaux;
                if (FechaInicial > FechaFinal)
                {
                    Fechaaux = FechaFinal;
                    FechaFinal = FechaInicial;
                    FechaInicial = Fechaaux;
                }
                dtgconten.DataSource = CapaLogica.Conciliacion_Busqueda(txtbusEmpresa.TextValido(), txtbusbanco.TextValido(), txtbusnrocuenta.TextValido(),
                    FechaInicial, FechaFinal, chkFecha.Checked ? 1 : 0);
                lblRegistros.Text = $"Total Registros: {dtgconten.RowCount}";
            }
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Cargado = false;
            LimpiarBotones();
            Cargado = true;
            FiltrarDatosConciliaciones();
        }
        private void cbofechaini_CambioFechas(object sender, EventArgs e)
        {
            FiltrarDatosConciliaciones();
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.frmInformativo.MostrarDialog(cadena);
        }
        public DialogResult msgYesCancel(string cadena)
        {
            return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena);
        }
        public void msgError(string cadena)
        {
            HPResergerFunciones.frmInformativo.MostrarDialogError(cadena);
        }
        frmConciliacionReportepdf Frmreporte;
        private void btnexportarpdf_Click(object sender, EventArgs e)
        {
            if (dtgconten.Rows.Count == 0)
            {
                msgError("No hay Datos para Generar"); return;
            }
            //Mostrar Formulario del Reporte PDF
            if (Frmreporte == null)
            {
                Frmreporte = new frmConciliacionReportepdf();
                Frmreporte.empresa = txtbusEmpresa.TextValido();
                Frmreporte.nrocuenta = txtbusnrocuenta.TextValido();
                Frmreporte.banco = txtbusbanco.TextValido();
                Frmreporte.fechaini = FechaInicial;
                Frmreporte.fechafin = FechaFinal;
                Frmreporte.Fecha = chkFecha.Checked ? 1 : 0;
                Frmreporte.MdiParent = this.MdiParent;
                Frmreporte.FormClosed += Frmreporte_FormClosed;
                Frmreporte.Show();
            }
            else
            {
                Frmreporte.Activate();
            }
        }
        private void Frmreporte_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frmreporte = null;
        }
        frmProcesando frmproce;
        DataTable DataExcel;
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount >= 0)
            {
                DataExcel = CapaLogica.Conciliacion_Busqueda_ConDetalle(txtbusEmpresa.TextValido(), txtbusbanco.TextValido(), txtbusnrocuenta.TextValido(), FechaInicial, FechaFinal, chkFecha.Checked ? 1 : 0);
                if (DataExcel.Rows.Count == 0) msgError("No hay Datos para Exportar");
                ////
                backgroundWorker1.WorkerSupportsCancellation = true;
                if (dtgconten.RowCount > 0)
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
            }
            else msgError("No hay datos para Exportar");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
        }
        public class EmpresaFecha
        {
            public string Empresa;
            public string NroCuenta;
            public DateTime Fecha;
            public EmpresaFecha(string _Empresa, string _NroCuenta, DateTime _Fecha)
            {
                Empresa = _Empresa;
                NroCuenta = _NroCuenta;
                Fecha = _Fecha;
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0 && DataExcel.Rows.Count > 0)
            {
                List<EmpresaFecha> ListadoEmpresaFechas = new List<EmpresaFecha>();
                List<String> ListadoEmpresas = new List<string>();
                //Sacamos el Listado de Empresas y Fechas
                foreach (DataRow item in DataExcel.Rows)
                {
                    EmpresaFecha xEmpresaFechita = new EmpresaFecha(item["empresa"].ToString(), item["Nro_cta"].ToString(), (DateTime)item["FechaCierre"]);
                    EmpresaFecha xEmpresaFecha = ListadoEmpresaFechas.Find(cust => cust.Empresa == xEmpresaFechita.Empresa && cust.Fecha == xEmpresaFechita.Fecha && cust.NroCuenta == xEmpresaFechita.NroCuenta);
                    if (xEmpresaFecha == null)
                        ListadoEmpresaFechas.Add(xEmpresaFechita);
                    if (!ListadoEmpresas.Contains(xEmpresaFechita.Empresa))
                        ListadoEmpresas.Add(xEmpresaFechita.Empresa);
                }
                foreach (string NameEmpresa in ListadoEmpresas)
                {
                    //ListadoEmpresas = > contiene el listado de las empresas
                    //ListadoFecha =>contiene el listaod de las fechas de reporte de la empresa seleccionda
                    List<DateTime> ListadoFecha = new List<DateTime>();
                    List<string> ListadoNroCuenta = new List<string>();

                    List<EmpresaFecha> ParaSAcarFecha = ListadoEmpresaFechas.FindAll(cust => cust.Empresa == NameEmpresa);
                    //
                    foreach (var list in ParaSAcarFecha)
                    {
                        if (!ListadoFecha.Contains(list.Fecha))
                            ListadoFecha.Add(list.Fecha);
                        if (!ListadoNroCuenta.Contains(list.NroCuenta))
                            ListadoNroCuenta.Add(list.NroCuenta);
                    }
                    //

                    string Carpeta = folderBrowserDialog1.SelectedPath;
                    string EmpresaValor = NameEmpresa.ToString().ToUpper();
                    //string Ruc = CapaLogica.BuscarRucEmpresa(EmpresaValor)[0].ToString();
                    string valor = Carpeta + @"\";
                    //if (chkCarpetas.Checked)
                    //{
                    valor = Carpeta + @"\" + Configuraciones.ValidarRutaValida(EmpresaValor) + @"\";
                    if (!Directory.Exists(Carpeta + @"\" + EmpresaValor))
                        Directory.CreateDirectory(Carpeta + @"\" + Configuraciones.ValidarRutaValida(EmpresaValor));
                    //}
                    //ELiminamos el Excel Antiguo
                    string NameFile = valor + $"CB - {EmpresaValor}.xlsx";
                    File.Delete(NameFile);
                    File.Exists(NameFile);
                    //POR PERIODOS
                    int i = 0; //posicion de la hoja no  es index
                    HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, Configuraciones.FuenteReportesTahoma10, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                    HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, Configuraciones.FuenteReportesTahoma10, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);

                    int Hoja = 0;
                    foreach (string NroCuentas in ListadoNroCuenta)
                    {
                        List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                        Hoja++;
                        i = 0;
                        string _NombreHoja = $"Conciliación {NroCuentas}";
                        foreach (DateTime FechaCierre in ListadoFecha)
                        {
                            DataView dvf = new DataView(DataExcel);
                            string cadena = $"empresa = '{NameEmpresa}' and fechacierre = '{FechaCierre}' and Nro_Cta= '{NroCuentas}'";
                            dvf.RowFilter = cadena;
                            DataTable TablaResult = dvf.ToTable();
                            //Sí No hay datos Buscamos otra fila
                            if (TablaResult.Rows.Count == 0) break;
                            //string añio = fechas.Substring(0, 4);
                            //string mes = fechas.Substring(4, 2);
                            //Sí no hay datos
                            if (TablaResult.Rows.Count > 0)
                            {
                                DataRow Fila = TablaResult.Rows[0];
                                string _Cabecera = "";
                                string _NColumna = "";
                                //Estilos
                                Color Back = Color.FromArgb(78, 129, 189);
                                Color BackGrilla = Color.FromArgb(204, 218, 231);
                                Color Fore = Color.Black;
                                Color ForeAmarillo = Color.FromArgb(228, 255, 0);
                                Color ForeBlanco = Color.White;
                                //
                                decimal SaldoContable = 0, EstadoCuenta = 0;
                                SaldoContable = ((Decimal)Fila["SALDOCONTABLE"]);
                                EstadoCuenta = ((Decimal)Fila["ESTADOCUENTA"]);
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{1 + i}", $"a{1 + i}", "EMPRESA", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"b{1 + i}", $"e{1 + i}", NameEmpresa, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{2 + i}", $"a{2 + i}", "RUC", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"b{2 + i}", $"e{2 + i}", Fila["ruc"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{3 + i}", $"e{3 + i}", "CONCILIACION BANCARIA", 12, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{4 + i}", $"e{4 + i}", $"al {FechaCierre.ToString("dd")} de {FechaCierre.ToString("MMMM")} del {FechaCierre.ToString("yyyy")}", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{5 + i}", $"A{5 + i}", "CUENTA CONTABLE", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{5 + i}", $"B{5 + i}", Fila["cuentacontable"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{5 + i}", $"E{5 + i}", Fila["cuenta_contable"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{6 + i}", $"A{6 + i}", "BANCO", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{6 + i}", $"E{6 + i}", Fila["Banco"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{7 + i}", $"A{7 + i}", "MONEDA", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{7 + i}", $"E{7 + i}", Fila["Namecorto"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                                //
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{8 + i}", $"A{8 + i}", "CUENTA CTE.", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{8 + i}", $"E{8 + i}", Fila["nro_cta"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{9 + i}", $"D{9 + i}", Fila["SIGLA"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.centro, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{9 + i}", $"E{9 + i}", Fila["SIGLA"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.centro, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{10 + i}", $"C{10 + i}", "SALDO SEGÚN LIBRO", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{10 + i}", $"E{10 + i}", SaldoContable, 10, true, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, ForeAmarillo, Configuraciones.FuenteReportesTahoma10, true));
                                //
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{11 + i}", $"A{11 + i}", "Fecha", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{11 + i}", $"B{11 + i}", "Num.Operación", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{11 + i}", $"C{11 + i}", "Glosa", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{11 + i}", $"D{11 + i}", "Montos", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{12 + i}", $"C{12 + i}", "CHEQUES GIRADOS Y NO COBRADOS", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));

                                //Detalle de los Movimientos de sistemas = tipò = 2
                                decimal SumatoriaT1 = 0, SumatoriaT2 = 0;
                                int pos = 0;
                                foreach (DataRow item in TablaResult.Rows)
                                {
                                    if ((int)item["tipo"] == 2)
                                    {
                                        pos++;
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{13 + i}", $"A{13 + i}", ((DateTime)item["fecha"]).ToString("dd/MM/yyyy"), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{13 + i}", $"B{13 + i}", item["operacion"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{13 + i}", $"C{13 + i}", item["glosa"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        decimal Valor = (decimal)item["monto"];
                                        Valor = Valor * -1;
                                        SumatoriaT2 += Valor;
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{13 + i}", $"D{13 + i}", Valor, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        i++;
                                    }
                                }
                                if (SumatoriaT2 != 0)
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{12 + i - pos }", $"E{12 + i - pos }", SumatoriaT2, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));
                                ////////////
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{14 + i}", $"C{14 + i }", "OPERACIONES PENDIENTES", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));
                                //Detalle de los Movimientos Bancarios no Registrados
                                pos = 0;
                                foreach (DataRow item in TablaResult.Rows)
                                {
                                    if ((int)item["tipo"] == 1)
                                    {
                                        pos++;
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{15 + i}", $"A{15 + i}", ((DateTime)item["fecha"]).ToString("dd/MM/yyyy"), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{15 + i}", $"B{15 + i}", item["operacion"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{15 + i}", $"C{15 + i}", item["glosa"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        decimal Valor = (decimal)item["monto"];
                                        SumatoriaT1 += Valor;
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{15 + i}", $"D{15 + i}", Valor, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        i++;
                                    }
                                }
                                if (SumatoriaT1 != 0)
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{14 + i - pos}", $"E{14 + i - pos }", SumatoriaT1, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));
                                //Fila de los Totales
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{15 + i }", $"E{15 + i}", (SaldoContable + SumatoriaT1 + SumatoriaT2), 10, true, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, ForeAmarillo, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{16 + i}", $"C{16 + i}", "SALDO SEGÚN BANCO", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{16 + i}", $"E{16 + i}", EstadoCuenta, 10, true, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, ForeAmarillo, Configuraciones.FuenteReportesTahoma10, true));

                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{17 + i}", $"C{17 + i}", "CONCILIADO", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{17 + i}", $"E{17 + i}", (SaldoContable + SumatoriaT1 + SumatoriaT2 - EstadoCuenta), 10, true, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));

                                i += 18;
                                //

                                /////
                                ////Anterior               
                                //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", _NombreHoja, Celdas, 5, _Columnas, new int[] { }, new int[] { });
                            }
                        }
                        HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(null, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, Hoja, Celdas, i, new int[] { }, new int[] { }, new int[] { 1, 2, 3, 4, 5 }, "");
                    }
                }
                msg($"Archivo Grabados en \n{folderBrowserDialog1.SelectedPath}");
                if (backgroundWorker1.IsBusy) backgroundWorker1.CancelAsync();
            }
            else msg("No hay Registros en la Grilla");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FiltrarDatosConciliaciones();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFecha.Checked)
            {
                cbofechaini.Enabled = cbofechafin.Enabled = true;
            }
            else
            {
                cbofechaini.Enabled = cbofechafin.Enabled = false;
            }
            FiltrarDatosConciliaciones();

        }

    }
}
