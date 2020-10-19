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
            CargarEmpresa();
            Cargado = true;
            FiltrarDatosConciliaciones();
        }
        public void CargarEmpresa()
        {
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
            cboempresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
        }
        private void LimpiarBotones()
        {
            txtbusbanco.CargarTextoporDefecto();
            //txtbusEmpresa.CargarTextoporDefecto();
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
            if (Configuraciones.ValidarSQLInyect(txtbusbanco, txtbusnrocuenta)) { msgError("Se Encontro un ingreso de dato Malicioso"); return; };
            if (!txtbusbanco.EstaLLeno() && !txtbusnrocuenta.EstaLLeno() && !chkFecha.Checked)
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
                dtgconten.DataSource = CapaLogica.Conciliacion_Busqueda(cboempresa.Text, txtbusbanco.TextValido(), txtbusnrocuenta.TextValido(),
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
                //Frmreporte.empresa = txtbusEmpresa.TextValido();
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
           if( cboempresa.SelectedValue ==null ) { msgError("Selecione una Empresa"); return; }
            if (dtgconten.RowCount >= 0)
            {
                DataExcel = CapaLogica.ReporteConciliacionFinanzas((int)cboempresa.SelectedValue, txtbusbanco.TextValido(), txtbusnrocuenta.TextValido(), FechaInicial, FechaFinal, chkFecha.Checked ? 1 : 0);
              //  if (DataExcel.Rows.Count == 0) msgError("No hay Datos para Exportar");
                ////
                backgroundWorker1.WorkerSupportsCancellation = true;
                if (DataExcel.Rows.Count > 0)
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
                    msgError("No hay Datos que Exportar");
                }
            }
            //else msgError("No hay datos para Exportar");
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
        //Estilos
        Color Back = Color.FromArgb(78, 129, 189);
        Color BackGrilla = Color.FromArgb(204, 218, 231);
        Color Fore = Color.Black;
        Color ForeAmarillo = Color.FromArgb(228, 255, 0);
        Color ForeBlanco = Color.White;
        private int idEmpresa;

        //
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if ( DataExcel.Rows.Count > 0)
            {
                List<EmpresaFecha> ListadoEmpresaFechas = new List<EmpresaFecha>();
                List<String> ListadoEmpresas = new List<string>();
                //Sacamos el Listado de Empresas y Fechas
                foreach (DataRow item in DataExcel.Rows)
                {
                    EmpresaFecha xEmpresaFechita = new EmpresaFecha(item["empresa"].ToString(), item["Nro_cta"].ToString(), (DateTime)item["Fecha"]);
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
                    string NameFile = valor + $"CB-Fi - {EmpresaValor}.xlsx";
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

                        //CABECERA DEL EXCEL
                        DataView dvf = new DataView(DataExcel);
                        string cadena = $" Nro_Cta= '{NroCuentas}'";
                        dvf.RowFilter = cadena;
                        DataTable TablaResult = dvf.ToTable();
                        DataRow Fila = TablaResult.Rows[0];
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{1 + i}", $"i{1 + i}", NameEmpresa, 14, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{2 + i}", $"i{2 + i}", (Fila["entidad_financiera"].ToString() + " :Cuenta " + Fila["moneda"].ToString() + " " + Fila["nro_cta"].ToString()), 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{3 + i}", $"i{3 + i}", ("CCI:" + Fila["nro_cta_cci"].ToString()), 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));
                        //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{3 + i}", $"i{3 + i}", ("CCI:" + Fila["nro_cta_cci"].ToString()), 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{4 + i}", $"i{4 + i}", $"Libro Banco al : {DateTime.Now.Date.ToLongDateString()}", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));
                        //INDICADORES DE LAS COLUMNAS
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"b{6 + i}", $"b{6 + i}", "Fecha de Giro", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"c{6 + i}", $"c{6 + i}", "Nro de Cheque", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"d{6 + i}", $"d{6 + i}", "ORDEN", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"e{6 + i}", $"e{6 + i}", "Concepto", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"f{6 + i}", $"f{6 + i}", "SubTotal", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"g{6 + i}", $"g{6 + i}", "Abonos", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"h{6 + i}", $"h{6 + i}", "Cargos", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"i{6 + i}", $"i{6 + i}", "Saldos", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));

                        //FIN DE LA CABECERA
                        string _NombreHoja = $"{Fila["sufijo"].ToString() } {Fila["moneda"].ToString()}-{Fila["nro_Cta"].ToString()}";
                        //
                        foreach (DateTime FechaCierre in ListadoFecha)
                        {
                            cadena = $"empresa = '{NameEmpresa}' and fecha = '{FechaCierre}' and Nro_Cta= '{NroCuentas}'";
                            dvf.RowFilter = cadena;
                            TablaResult = dvf.ToTable();
                            //Sí No hay datos Buscamos otra fila
                            if (TablaResult.Rows.Count == 0) break;
                            //string añio = fechas.Substring(0, 4);
                            //string mes = fechas.Substring(4, 2);
                            //Sí no hay datos
                            if (TablaResult.Rows.Count > 0)
                            {
                                DataRow FilaX = TablaResult.Rows[0];
                                string _Cabecera = "";
                                string _NColumna = "";
                                string CUOArrastre = "";
                                decimal SaldoContable = 0, EstadoCuenta = 0, SaldoContableAux = 0, EstadoCuentaAux = 0;
                                SaldoContable = ((Decimal)FilaX["saldocontableinicial"]);
                                EstadoCuenta = ((Decimal)FilaX["ESTADOCUENTAinicial"]);
                                SaldoContableAux = ((Decimal)FilaX["saldocontableinicial"]);
                                EstadoCuentaAux = ((Decimal)FilaX["ESTADOCUENTAinicial"]);
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{8 + i}", $"i{8 + i}", $"MES DE {((DateTime)FilaX["fecha"]).ToString("MMMM").ToUpper()} - {((DateTime)FilaX["Fecha"]).Year.ToString()} ", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Red, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"d{9 + i}", $"d{9 + i}", "Saldo Anterior", 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"i{9 + i}", $"i{9 + i}", SaldoContable, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                //Detalle de los Movimientos de sistemas = tipò = 2
                                decimal SumatoriaT1Abonos = 0, SumatoriaT1Cargos = 0, SumatoriaT2Abonos = 0, SumatoriaT2Cargos = 0;
                                //Variables
                                DateTime FechaPago = DateTime.Now;
                                string NroCheque = "", ProveedorCLiente = "", DetFac = "";
                                decimal Total = 0;
                                int contador = 0;
                                //
                                int pos = 0;
                                foreach (DataRow item in TablaResult.Rows)
                                {
                                    if ((int)item["tipo"] == 2 && (int)item["grupo"] != 0)
                                    {
                                        if (CUOArrastre == item["cuo"].ToString() && item["cuo"].ToString() != "" && item["total"].ToString() != "")//QUIERE DECIR QUE ES EL MISMO ASIENTO - MOSTRAREMOS DETALLE
                                        {
                                            pos = 0;
                                            if (contador == 0)
                                            {
                                                contador++;
                                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{10 + i - 1}", $"C{10 + i - 1}", "TLC", 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));

                                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{10 + i}", $"B{10 + i}", FechaPago.ToString("dd/MM/yyyy"), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{10 + i}", $"C{10 + i}", NroCheque, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{10 + i}", $"D{10 + i}", ProveedorCLiente, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{10 + i}", $"E{10 + i}", DetFac, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"F{10 + i}", $"F{10 + i}", Total, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                                i++;
                                            }
                                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{10 + i}", $"B{10 + i}", ((DateTime)item["FECHAPAGO"]).ToString("dd/MM/yyyy"), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{10 + i}", $"C{10 + i}", item["NROCHEQUE"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{10 + i}", $"D{10 + i}", item["PROVEEDORCLIENTE"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{10 + i}", $"E{10 + i}", item["DETFAC"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                            Total = item["total"].ToString() == "" ? (decimal)item["abono"] + (decimal)item["cargos"] : (decimal)item["total"];
                                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"F{10 + i}", $"F{10 + i}", Total, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        }
                                        else
                                        {
                                            pos = 1;
                                            contador = 0;
                                            SaldoContableAux += (decimal)item["abono"] + (decimal)item["cargos"];
                                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{10 + i}", $"B{10 + i}", ((DateTime)item["FECHAPAGO"]).ToString("dd/MM/yyyy"), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{10 + i}", $"C{10 + i}", item["NROCHEQUE"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{10 + i}", $"D{10 + i}", item["PROVEEDORCLIENTE"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{10 + i}", $"E{10 + i}", item["CONCEPTO"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"G{10 + i}", $"G{10 + i}", (decimal)item["ABONO"], 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"H{10 + i}", $"H{10 + i}", Math.Abs((decimal)item["CARGOS"]), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"I{10 + i}", $"I{10 + i}", SaldoContableAux, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                            //CARGA VARIABLES MOMENTANIAS
                                            FechaPago = ((DateTime)item["FECHAPAGO"]);
                                            NroCheque = item["NROCHEQUE"].ToString();
                                            ProveedorCLiente = item["PROVEEDORCLIENTE"].ToString();
                                            DetFac = item["DETFAC"].ToString();
                                            if (item["total"].ToString() != "")
                                                Total = ((decimal)(item["TOTAL"] ?? 0.00));
                                            //
                                            SumatoriaT2Abonos += (decimal)item["abono"];
                                            SumatoriaT2Cargos += (decimal)item["cargos"];
                                            //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{11 + i}", $"D{11 + i}", Valor, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        }
                                        i++;
                                        CUOArrastre = item["cuo"].ToString();
                                    }
                                }
                                if (SumatoriaT2Abonos + SumatoriaT2Cargos != 0)
                                {
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{11 + i   }", $"E{11 + i   }", "Saldo Según Libro:", 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"G{11 + i   }", $"G{11 + i   }", SumatoriaT2Abonos, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"H{11 + i   }", $"H{11 + i   }", Math.Abs(SumatoriaT2Cargos), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"I{11 + i   }", $"I{11 + i   }", SaldoContableAux, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));
                                }
                                ////////////
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{13 + i}", $"C{13 + i }", "(+)", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{12 + i}", $"D{12 + i }", "Conciliación Bancaria", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{13 + i}", $"D{13 + i }", "Mas Cheques No Cobrados :", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));
                                //Detalle de los Movimientos Bancarios no Registrados
                                pos = 0;
                                foreach (DataRow item in TablaResult.Rows)
                                {
                                    if ((int)item["tipo"] == 2 && (int)item["grupo"] == 0)

                                    {
                                        pos++;
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{15 + i}", $"B{15 + i}", ((DateTime)item["FECHAPAGO"]).ToString("dd/MM/yyyy"), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{15 + i}", $"C{15 + i}", item["NROCHEQUE"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{15 + i}", $"D{15 + i}", item["PROVEEDORCLIENTE"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{15 + i}", $"E{15 + i}", item["CONCEPTO"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"G{15 + i}", $"G{15 + i}", (decimal)item["ABONO"], 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"H{15 + i}", $"H{15 + i}", Math.Abs((decimal)item["CARGOS"]), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"I{15 + i}", $"I{15 + i}", SaldoContableAux, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));

                                        decimal Valor = (-1 * (decimal)item["abono"]) + (-1 * (decimal)item["cargos"]);
                                        SumatoriaT1Abonos += Valor;
                                        //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{13 + i}", $"D{13 + i}", Valor, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        i++;
                                    }
                                }
                                //if (SumatoriaT1Abonos + SumatoriaT1Cargos != 0)
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"I{14 + i - pos}", $"I{14 + i - pos }", SumatoriaT1Abonos, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));
                                //Detalle de OPERACIONES PENDIENTES
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{16 + i}", $"D{16 + i }", "Operaciones Pendientes :", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));
                                //Detalle de los Movimientos Bancarios no Registrados
                                pos = 0;
                                foreach (DataRow item in TablaResult.Rows)
                                {
                                    if ((int)item["tipo"] == 1)
                                    {
                                        pos++;
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{17 + i}", $"B{17 + i}", ((DateTime)item["FECHAPAGO"]).ToString("dd/MM/yyyy"), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{17 + i}", $"C{17 + i}", item["NROCHEQUE"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{17 + i}", $"D{17 + i}", item["PROVEEDORCLIENTE"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{17 + i}", $"E{17 + i}", item["CONCEPTO"].ToString(), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"G{17 + i}", $"G{17 + i}", (decimal)item["ABONO"], 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"H{17 + i}", $"H{17 + i}", Math.Abs((decimal)item["CARGOS"]), 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, 1 % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"I{17 + i}", $"I{17 + i}", SaldoContableAux, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));

                                        decimal Valor = (-1 * (decimal)item["abono"]) + (-1 * (decimal)item["cargos"]);
                                        SumatoriaT1Cargos += Valor;
                                        //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{13 + i}", $"D{13 + i}", Valor, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, pos % 2 == 1 ? ForeBlanco : BackGrilla, Fore, Configuraciones.FuenteReportesTahoma10, pos % 2 == 1 ? false : true));
                                        i++;
                                    }
                                }
                                //if (SumatoriaT1Abonos + SumatoriaT1Cargos != 0)
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"I{16 + i - pos}", $"I{16 + i - pos }", SumatoriaT1Cargos, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));

                                //Fila de los Totales
                                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{15 + i }", $"E{15 + i}", (SaldoContable + SumatoriaT1 + SumatoriaT2Abonos), 10, true, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, ForeAmarillo, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{18 + i}", $"E{18 + i}", "Saldo Según Banco: ", 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"I{18 + i}", $"I{18 + i}", SaldoContableAux, 10, false, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));

                                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{17 + i}", $"C{17 + i}", "CONCILIADO", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, ForeBlanco, Configuraciones.FuenteReportesTahoma10, true));
                                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{17 + i}", $"E{17 + i}", (SaldoContable + SumatoriaT1 + SumatoriaT2Abonos - EstadoCuenta), 10, true, true, HPResergerFunciones.Utilitarios.Alineado.derecha, Back, Fore, Configuraciones.FuenteReportesTahoma10, false));

                                i += 13;
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
        private void cboempresa_Click(object sender, EventArgs e)
        {
            DataTable Tablita = CapaLogica.getCargoTipoContratacion("Id_Empresa", "Empresa", "TBL_Empresa");
            if (cboempresa.Items.Count != Tablita.Rows.Count)
            {
                string cadena = cboempresa.Text;
                cboempresa.DataSource = Tablita;
                cboempresa.Text = cadena;
            }
        }

        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarDatosConciliaciones();
        }
    }
}
