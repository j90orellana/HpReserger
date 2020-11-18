using HpResergerUserControls;
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
namespace HPReserger
{
    public partial class frmRegMayorxCuentas : FormGradient
    {
        public frmRegMayorxCuentas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        private void frmRegMayorxCuentas_Load(object sender, EventArgs e)
        {
            Configuraciones.CargarTextoPorDefecto(txtbuscuenta, txtbusGlosa, txtbusnrodoc, txtbusrazon, txtbusruc);
            dtpfechaini.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfechafin.Value = new DateTime(DateTime.Now.Year, 12, 31);
            CargarEmpresas();
        }
        DataTable TablaEmpresa;
        public void CargarEmpresas()
        {
            chklist.Items.Clear();
            TablaEmpresa = CapaLogica.Empresa();
            chklist.Items.Add("TODAS", true);
            foreach (DataRow item in TablaEmpresa.Rows)
            {
                chklist.Items.Add(item["descripcion"].ToString(), true);
            }
        }
        DateTime FechaIni;
        DateTime FechaFin;
        private void btngenerar_Click(object sender, EventArgs e)
        {
            if (chklist.CheckedItems.Count == 0) { msg("Seleccione una Empresa"); return; }
            Cursor = Cursors.WaitCursor; if (Configuraciones.ValidarSQLInyect(txtbuscuenta, txtbusGlosa, txtbusnrodoc, txtbusrazon, txtbusruc)) { msg("Se Encontro Codigo Malisioso en las Cajas de Textos"); return; }
            FechaIni = dtpfechaini.Value;
            FechaFin = dtpfechafin.Value;
            DateTime FechaAux;
            if (FechaIni > FechaFin)
            {
                FechaAux = FechaFin;
                FechaFin = FechaIni;
                FechaIni = FechaAux;
            }
            string Buscarcuenta = "";
            string BuscarEmpresa = "";
            string BuscarRuc = "";
            string BuscarRazon = "";
            string BuscarGlosa = "";
            string BuscarDocumento = "";
            FechaInicio = FechaIni;
            if (txtbuscuenta.EstaLLeno())
            {
                Buscarcuenta = "(";
                string[] Cuentas = txtbuscuenta.Text.Split(';');
                foreach (string cuentita in Cuentas)
                {
                    string[] Cuenta = cuentita.Split('-');
                    if (Cuenta.Length == 2)
                    {
                        if (string.CompareOrdinal(Cuenta[1], Cuenta[0]) > 1)
                            Buscarcuenta += $" X.Cuenta_Contable  between '{Cuenta[0].Trim()}' and '{Cuenta[1].Trim()}9' or ";

                        else Buscarcuenta += $" X.Cuenta_Contable  between '{Cuenta[1].Trim()}' and '{Cuenta[0].Trim()}9' or ";
                    }
                    if (Cuenta.Length == 1) { Buscarcuenta += $" X.Cuenta_Contable  like '{Cuenta[0].Trim()}%' or "; }
                }
                if (Buscarcuenta.Length > 3) Buscarcuenta = Buscarcuenta.Substring(0, Buscarcuenta.Length - 3);
                else Buscarcuenta = "(0=0";
                Buscarcuenta += ")";
            }
            else { Buscarcuenta = "( X.Cuenta_Contable  like '%%')"; }
            if (txtbusGlosa.EstaLLeno()) { BuscarGlosa = $" isnull(f.Glosa,'') like '%{txtbusGlosa.Text}%'"; }
            else { BuscarGlosa = " isnull(f.Glosa,'') like '%%'"; }
            if (txtbusrazon.EstaLLeno())
            {
                BuscarRazon = "(";
                string[] Razones = txtbusrazon.Text.Split(';');
                foreach (string Razoncita in Razones)
                {
                    string[] Razon = Razoncita.Split('-');
                    if (Razon.Length >= 1) { BuscarRazon += $" isnull(Razon_Social,'') like '%{Razon[0].Trim()}%' or "; }
                }
                if (BuscarRuc.Length > 3) BuscarRazon = BuscarRazon.Substring(0, BuscarRazon.Length - 3);
                else BuscarRuc = "(0=0";
                BuscarRazon += ")";
            }
            else { BuscarRazon = " isnull(Razon_Social,'') like '%%'"; }
            if (txtbusruc.EstaLLeno())
            {
                BuscarRuc = "(";
                string[] Rucs = txtbusruc.Text.Split(';');
                foreach (string Rucito in Rucs)
                {
                    string[] Ruc = Rucito.Split('-');
                    if (Ruc.Length >= 1) { BuscarRuc += $" isnull(Num_Doc,'') like  '%{Ruc[0].Trim()}%' or "; }
                }
                if (BuscarRuc.Length > 3) BuscarRuc = BuscarRuc.Substring(0, BuscarRuc.Length - 3);
                else BuscarRuc = "(0=0";
                BuscarRuc += ")";
            }
            else { BuscarRuc = " isnull(Num_Doc,'') like '%%'"; }
            if (txtbusnrodoc.EstaLLeno())
            {
                BuscarDocumento = "(";
                string[] Documentos = txtbusnrodoc.Text.Split(';');
                foreach (string Doc in Documentos)
                {
                    string[] Docito = Doc.Split('-');
                    if (Docito.Length >= 1) { BuscarDocumento += $" concat(isnull(f.Cod_Comprobante,''),'-',(isnull(f.Num_Comprobante,'')))like  '%{Docito[0].Trim()}%' or "; }
                }
                if (BuscarDocumento.Length > 3) BuscarDocumento = BuscarDocumento.Substring(0, BuscarDocumento.Length - 3);
                else BuscarDocumento = "(0=0";
                BuscarDocumento += ")";
            }
            else { BuscarDocumento = " concat(isnull(f.Cod_Comprobante,''),'-',(isnull(f.Num_Comprobante,''))) like '%%'"; }
            //CargarEmpresas();
            BuscarEmpresa = "(";
            foreach (object item in chklist.CheckedItems)
            {
                if (item.ToString() != "TODAS")
                {
                    DataView dv = TablaEmpresa.DefaultView;
                    dv.RowFilter = $" descripcion = '" + item.ToString() + "'";
                    DataTable TDAtos = dv.ToTable();
                    if (TDAtos.Rows.Count > 0)
                    {
                        BuscarEmpresa += $" e.Id_Empresa like  '{  TDAtos.Rows[0]["codigo"].ToString()}' or ";
                    }
                }
            }
            if (BuscarEmpresa.Length > 10)
            {
                BuscarEmpresa = BuscarEmpresa.Substring(0, BuscarEmpresa.Length - 3);
                BuscarEmpresa += ")";
            }
            else BuscarEmpresa = " e.Id_Empresa like '%%'";
            /////ASIGNACION DE LOS DATOS
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            TDatos = CapaLogica.MayorPorCuentas(FechaIni, FechaFin, Buscarcuenta, BuscarGlosa, BuscarDocumento, BuscarRuc, BuscarEmpresa, BuscarRazon);
            dtgconten.DataSource = TDatos;
            //Configuraciones.TiempoEjecucionMsg(stopwatch); stopwatch.Stop();
            //dtgconten.AutoGenerateColumns = true;            
            //dtgconten.DataMember = "cuenta_contable";
            Cursor = Cursors.Default;
            lblmensaje.Text = $"Total de Registros: {dtgconten.RowCount}";
            if (dtgconten.RowCount == 0) msg("No Hay Registros");
            Ordenado = false;
        }
        DataTable TDatos;
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        frmProcesando frmproce;
        public void CerrarPanelTxt()
        {
            PanelTxt.Visible = false;
        }
        private void btnexcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                if (chkCarpeta.Checked)
                {
                    if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                }
                Auditoria = false;
                dtgconten.SuspendLayout();
                Cursor = Cursors.WaitCursor;
                frmproce = new HPReserger.frmProcesando();
                frmproce.Show();
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                msg("No hay Datos que Exportar");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                if (Auditoria)
                {
                    //PROCESO DE AUDITORIA
                    DateTime FechaInicial = FechaInicio;
                    List<string> ListadoFecha = new List<string>();
                    while (FechaInicial < FechaFin)
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
                            //ELiminamos el Excel Antiguo
                            string NameFile = valor + $"LIBRO MAYOR {FechaInicio.ToString("MMMyyyy").ToUpper()}-{FechaFin.ToString("MMMyyyy").ToUpper()} {EmpresaValor} {(Auditoria ? "-AUD" : "")}.xlsx";
                            File.Delete(NameFile);
                            File.Exists(NameFile);
                            if (item.ToString() != "TODAS")
                            {
                                DataView dv = TDatos.Copy().AsDataView();
                                dv.RowFilter = $"empresa like '{EmpresaValor}'";
                                //POR PERIODOS
                                int contador = 1; //posicion de la hoja no  es index
                                foreach (string fechas in ListadoFecha)
                                {
                                    DataView dvf = new DataView(dv.ToTable());
                                    dvf.RowFilter = $"periodo like '{fechas}'";
                                    dvf.Sort = "cuenta_contable asc, cod_asiento_Contable asc";
                                    DataTable TablaResult = dvf.ToTable();
                                    string añio = fechas.Substring(0, 4);
                                    string mes = fechas.Substring(4, 2);
                                    //Sí no hay datos
                                    if (TablaResult.Rows.Count > 0)
                                    {
                                        //Modificamos el Excel
                                        string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                                        _NombreHoja = $"{fechas}"; _Cabecera = "LIBRO MAYOR";
                                        _Columnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 }; _NColumna = "m";

                                        List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                                        //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                                        Color Back = Color.FromArgb(78, 129, 189);
                                        Color Fore = Color.FromArgb(255, 255, 255);
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "g1", "LIBRO MAYOR", 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "PERIODO:", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", $"{fechas}", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", "RUC:", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", "c3", $"{Ruc}", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", "b4", "RAZÓN SOCIAL:", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("c4", "g4", $"{EmpresaValor}", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                        ///////estilos de la celdas
                                        HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(Color.White, Configuraciones.FuenteReportesTahoma8, Color.White);
                                        HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(Color.White, new Font("tahoma", 8, FontStyle.Bold), Color.Black);
                                        /////fin estilo de las celdas
                                        //DataTable TableResult = new DataTable(); DataView dt = ((DataTable)dtgconten.DataSource).AsDataView(); TableResult = dt.ToTable();
                                        ///Tabla 
                                        TablaResult.Columns.RemoveAt(22);
                                        TablaResult.Columns.RemoveAt(21);
                                        TablaResult.Columns.RemoveAt(20);
                                        TablaResult.Columns.RemoveAt(17);
                                        TablaResult.Columns.RemoveAt(16);
                                        //TablaResult.Columns.RemoveAt(14);
                                        TablaResult.Columns.RemoveAt(11);
                                        TablaResult.Columns.RemoveAt(10);
                                        TablaResult.Columns.RemoveAt(9);
                                        TablaResult.Columns.RemoveAt(7);
                                        TablaResult.Columns.RemoveAt(6);
                                        TablaResult.Columns.RemoveAt(5);
                                        TablaResult.Columns.RemoveAt(3);
                                        TablaResult.Columns.RemoveAt(1);
                                        TablaResult.Columns.RemoveAt(0);
                                        //muevo la Columna 1 a 0
                                        TablaResult.Columns[1].SetOrdinal(0);
                                        //decimal SumDebe = 0, SumHaber = 0;
                                        TablaResult.Columns["Cod_Asiento_Contable"].ColumnName = "Nº CORRELATIVO";
                                        TablaResult.Columns["FechaContable"].ColumnName = "FECHA DE OPERACIÓN";
                                        TablaResult.Columns["Glosa"].ColumnName = "DESCRIPCIÓN O GLOSA DE LA OPERACIÓN";
                                        TablaResult.Columns["TipoComprobante"].ColumnName = "MEDIO PAGO";
                                        TablaResult.Columns["Razon_Social"].ColumnName = "NOMBRE O RAZON SOCIAL";
                                        TablaResult.Columns["PEN"].ColumnName = "MOV. DEUDOR";
                                        TablaResult.Columns["USD"].ColumnName = "MOV. ACREEDOR";
                                        //
                                        string cuo = "", Cuenta = "", CuentaFila = "";
                                        SumDebe = 0; SumHaber = 0;
                                        decimal valdebe = 0, valhaber = 0;
                                        decimal Sumvaldebe = 0, Sumvalhaber = 0;
                                        for (int i = 0; i < TablaResult.Rows.Count; i++)
                                        {
                                            DataRow fila = TablaResult.Rows[i];
                                            valdebe = (decimal)fila["mov. deudor"] > 0 ? (decimal)fila["mov. deudor"] : 0;
                                            valhaber = (decimal)fila["mov. deudor"] < 0 ? Math.Abs((decimal)fila["mov. deudor"]) : 0;
                                            fila["mov. deudor"] = valdebe;
                                            fila["mov. acreedor"] = valhaber;
                                            SumDebe += valdebe;
                                            SumHaber += valhaber;
                                            //fila["NUMERO DE DOCUMENTO"] = $"{fila["Cod_Comprobante"]}-{fila["NUMERO DE DOCUMENTO"]}";
                                            //Para Todas la filas
                                            if (fila["descripcion"].ToString() != Cuenta && i > 0)
                                            {
                                                DataRow nueva11 = TablaResult.NewRow();
                                                nueva11["DESCRIPCIÓN O GLOSA DE LA OPERACIÓN"] = $"TOTAL CUENTA: {Cuenta}";
                                                nueva11["mov. deudor"] = Sumvaldebe;
                                                nueva11["mov. acreedor"] = Sumvalhaber;
                                                DataRow nueva12 = TablaResult.NewRow();
                                                nueva12["DESCRIPCIÓN O GLOSA DE LA OPERACIÓN"] = $"SALDO CUENTA: {Cuenta}";
                                                nueva12["mov. deudor"] = Sumvaldebe - Sumvalhaber > 0 ? Sumvaldebe - Sumvalhaber : 0;
                                                nueva12["mov. acreedor"] = Sumvaldebe - Sumvalhaber < 0 ? -Sumvaldebe + Sumvalhaber : 0;
                                                TablaResult.Rows.InsertAt(nueva12, i);
                                                TablaResult.Rows.InsertAt(nueva11, i);
                                                i++;
                                                i++;
                                                Sumvaldebe = Sumvalhaber = 0;
                                            }
                                            //Cabecera de las Cuentas
                                            if (fila["descripcion"].ToString() != Cuenta)
                                            {
                                                DataRow FiladeCuentas = TablaResult.NewRow();
                                                FiladeCuentas["NOMBRE O RAZON SOCIAL"] = fila["descripcion"].ToString();
                                                DataRow FilaSaldoInicial = TablaResult.NewRow();
                                                FilaSaldoInicial["DESCRIPCIÓN O GLOSA DE LA OPERACIÓN"] = "SALDO INICIAL";
                                                //
                                                decimal MontoInicial = 0;
                                                MontoInicial = (decimal)fila["saldoinicial"];
                                                FilaSaldoInicial["DESCRIPCIÓN O GLOSA DE LA OPERACIÓN"] = "SALDO INICIAL";
                                                FilaSaldoInicial["MOV. DEUDOR"] = MontoInicial > 0 ? Math.Abs(MontoInicial) : 0;
                                                FilaSaldoInicial["MOV. ACREEDOR"] = MontoInicial < 0 ? Math.Abs(MontoInicial) : 0;
                                                //
                                                TablaResult.Rows.InsertAt(FilaSaldoInicial, i);
                                                TablaResult.Rows.InsertAt(FiladeCuentas, i);
                                                i++;
                                                i++;
                                                Sumvaldebe = MontoInicial > 0 ? Math.Abs(MontoInicial) : 0;
                                                Sumvalhaber = MontoInicial < 0 ? Math.Abs(MontoInicial) : 0;
                                                SumDebe += Sumvaldebe;
                                                SumHaber += Sumvalhaber;
                                                Cuenta = fila["descripcion"].ToString();
                                            }
                                            //para la fila final
                                            if (i == TablaResult.Rows.Count - 1)
                                            {
                                                Sumvaldebe += valdebe;
                                                Sumvalhaber += valhaber;
                                                DataRow nueva11 = TablaResult.NewRow();
                                                nueva11["DESCRIPCIÓN O GLOSA DE LA OPERACIÓN"] = $"TOTAL CUENTA: {Cuenta}";
                                                nueva11["mov. deudor"] = Sumvaldebe;
                                                nueva11["mov. acreedor"] = Sumvalhaber;
                                                DataRow nueva12 = TablaResult.NewRow();
                                                nueva12["DESCRIPCIÓN O GLOSA DE LA OPERACIÓN"] = $"SALDO CUENTA: {Cuenta}";
                                                nueva12["mov. deudor"] = Sumvaldebe - Sumvalhaber > 0 ? Sumvaldebe - Sumvalhaber : 0;
                                                nueva12["mov. acreedor"] = Sumvaldebe - Sumvalhaber < 0 ? -Sumvaldebe + Sumvalhaber : 0;
                                                TablaResult.Rows.InsertAt(nueva12, i + 1);
                                                TablaResult.Rows.InsertAt(nueva11, i + 1);
                                                i++;
                                                i++;
                                                Sumvaldebe = Sumvalhaber = 0;
                                            }
                                            Sumvaldebe += valdebe;
                                            Sumvalhaber += valhaber;
                                            Cuenta = fila["descripcion"].ToString();
                                        }
                                        //Muestra del Total General!
                                        TablaResult.Columns.RemoveAt(6);
                                        TablaResult.Columns.RemoveAt(5);
                                        DataRow nueva1 = TablaResult.NewRow();
                                        TablaResult.Rows.Add(nueva1);
                                        DataRow nueva2 = TablaResult.NewRow();
                                        nueva1["DESCRIPCIÓN O GLOSA DE LA OPERACIÓN"] = "TOTAL GENERAL";
                                        nueva1["MOV. DEUDOR"] = SumDebe;
                                        nueva1["MOV. acreedor"] = SumHaber;
                                        TablaResult.Rows.Add(nueva2);

                                        //removemos la columna de saldos iniciales
                                        TablaResult.Columns.RemoveAt(TablaResult.Columns.Count - 1);
                                        ///
                                        ////Anterior               
                                        //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", _NombreHoja, Celdas, 5, _Columnas, new int[] { }, new int[] { });
                                        HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(TablaResult, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, contador++, Celdas, 6, _Columnas, new int[] { }, new int[] { 1, 4, 5, 6, 7 }, "");
                                    }
                                }
                            }
                        }
                    }
                    msgOK($"Archivo Grabados en \n{folderBrowserDialog1.SelectedPath}");
                    if (backgroundWorker1.IsBusy) backgroundWorker1.CancelAsync();
                }
                else
                {
                    string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                    _NombreHoja = "Mayor_x_Cuentas"; _Cabecera = "MAYOR POR CUENTAS CONTABLES";
                    _Columnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }; _NColumna = "m";

                    List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                    //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                    Color Back = Color.FromArgb(78, 129, 189);
                    Color Fore = Color.FromArgb(255, 255, 255);
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "a1", _Cabecera.ToUpper(), 14, true, false, Back, Fore));
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "PERIODO:", 10, false, false, Back, Fore));
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", $"De: {dtpfechaini.Value.ToShortDateString() } A: {dtpfechafin.Value.ToShortDateString()}", 10, false, false, Back, Fore));
                    // Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", "Ruc:", 12, false, true, Back, Fore));
                    // Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", "c3", $"{txtruc.Text}", 12, false, true, Back, Fore));
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", "a4", txtbuscuenta.EstaLLeno() ? "CUENTA CONTABLE:" : "", 10, false, false, Back, Fore));
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("d4", "d4", $"{(txtbuscuenta.EstaLLeno() ? txtbuscuenta.Text : "")}", 10, false, false, Back, Fore));
                    //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "b2", "Nombre Vendedor:", 11));
                    HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                    HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                    /////fin estilo de las celdas
                    DataTable TableResult = new DataTable();
                    DataView dt = ((DataTable)dtgconten.DataSource).AsDataView();
                    TableResult = dt.ToTable();
                    TableResult.Columns.RemoveAt(TableResult.Columns.Count - 1);
                    foreach (DataColumn item in TableResult.Columns) item.ColumnName = dtgconten.Columns["x" + item.ColumnName].HeaderText;
                    //MACRO
                    int PosInicialGrilla = 4;
                    string Macro = $"Private Sub Workbook_Open()  {Environment.NewLine} " +
                        $"Range(Cells({PosInicialGrilla}, 1), Cells({TableResult.Rows.Count + PosInicialGrilla + 1},{ TableResult.Columns.Count})).Select  {Environment.NewLine}" +
                        $"Selection.Subtotal GroupBy:= 3, Function:= xlSum, TotalList:= Array(19, 20), Replace:= True, PageBreaks:= False, SummaryBelowData:= True   {Environment.NewLine} End Sub";
                    ///
                    if (chkCarpeta.Checked)
                    {
                        string Carpeta = folderBrowserDialog1.SelectedPath;
                        string valor = Carpeta + @"\";
                        //ELiminamos el Excel Antiguo
                        string NameFile = valor + $"6.2 {FechaInicio.ToString("MMMyyyy").ToUpper()}-{FechaFin.ToString("MMMyyyy").ToUpper()} LIBRO MAYOR.xlsx";
                        File.Delete(NameFile);
                        File.Exists(NameFile);
                        HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(TableResult, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, 1, Celdas, PosInicialGrilla, _Columnas, new int[] { }, new int[] { 3, 5, 6, 7, 8, 10, 11, 12, 18, 19, 20, 21, 22, 23 }, chksubtotales.Checked ? Macro : "");
                        msgOK($"Archivo Grabado en \n{folderBrowserDialog1.SelectedPath}");
                    }
                    else
                        HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableResult, CeldaCabecera, CeldaDefault, "", _NombreHoja, Celdas, PosInicialGrilla, _Columnas, new int[] { }, new int[] { 3, 5, 6, 7, 8, 10, 11, 12, 18, 19, 20, 21, 22, 23 }, chksubtotales.Checked ? Macro : "");
                    if (backgroundWorker1.IsBusy) backgroundWorker1.CancelAsync();
                    //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", "Cronograma de Pagos", Celdas, 2, new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { }, new int[] { });
                }
            }
            else msg("No hay Registros en la Grilla");
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
            dtgconten.ResumeLayout();
        }
        DateTime FechaPeriodo; string NombreEmpresa = "";
        public DateTime año = DateTime.Now.AddMonths(-1);
        public int empresa = 2;
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
            //else
            //{
            //    chklist.SetItemCheckState(0, CheckState.Indeterminate);
            //}
        }

        private void chklist_Enter(object sender, EventArgs e)
        {
            //chklist.Height = 200;
        }
        private void chklist_Leave(object sender, EventArgs e)
        {
            //chklist.Height = 18;
        }
        private void frmRegMayorxCuentas_Click(object sender, EventArgs e)
        {
            chklist_Leave(sender, e);
            btngenerar.Focus();
        }
        frmlistarcuentas frmlistacuenta;
        int opcionCuentas = 0;
        public bool IgualAÑo { get; private set; }
        public bool IgualMes { get; private set; }
        public bool IgualEmpresa { get; private set; }
        public string nameEmpresa { get; private set; }
        public bool Ordenado = true;
        private void btnbusCuenta_Click(object sender, EventArgs e)
        {
            if (frmlistacuenta == null)
            {
                frmlistacuenta = new frmlistarcuentas();
                frmlistacuenta.FormClosed += Frmlistacuenta_FormClosed;
                frmlistacuenta.tipobusca = opcionCuentas;
                frmlistacuenta.Show();
            }
            else
            {
                frmlistacuenta.Activate();
            }
        }
        private void Frmlistacuenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmlistacuenta.aceptar)
            {
                if (!txtbuscuenta.EstaLLeno()) txtbuscuenta.Text = "";
                if (txtbuscuenta.TextLength > 0 && txtbuscuenta.Text.Substring(txtbuscuenta.TextLength - 1, 1) != ";")
                    txtbuscuenta.Text += ";";
                txtbuscuenta.Text += frmlistacuenta.codigo;
                txtbuscuenta.SelectionStart = txtbuscuenta.TextLength;
                opcionCuentas = frmlistacuenta.tipobusca;
            }
            frmlistacuenta = null;
        }
        private void btnGenerarTXT_Click(object sender, EventArgs e)
        {
            PanelTxt.BringToFront();
            IgualAÑo = false;
            IgualMes = false;
            IgualEmpresa = false;
            txtRucDeudor.Text = "RUC EMPRESA";
            if (dtpfechaini.Value.Year == dtpfechafin.Value.Year)
            {
                txtaño.Text = dtpfechaini.Value.Year.ToString("0000");
                IgualAÑo = true;
            }
            else txtaño.Text = "AÑO";
            if (dtpfechaini.Value.Month == dtpfechafin.Value.Month)
            {
                txtmes.Text = dtpfechafin.Value.Month.ToString("00");
                IgualMes = true;
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
                IgualEmpresa = true;
                txtRucDeudor.Text = CapaLogica.BuscarRucEmpresa(nameEmpresa)[0].ToString();
            }
            txtinformacion.Text = (dtgconten.RowCount > 0 ? 1 : 0).ToString();
            PanelTxt.Visible = true;
            PanelTxt.Focus();
        }
        private void PanelTxt_Leave(object sender, EventArgs e)
        {
            CerrarPanelTxt();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();
        }
        private StreamWriter st;
        private bool Auditoria;
        private DateTime FechaInicio;
        private decimal SumDebe;
        private decimal SumHaber;
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private void btnTxt_Click(object sender, EventArgs e)
        {
            //Generamos el TXT
            Cursor = Cursors.WaitCursor;
            if (Ordenado)
                btngenerar_Click(sender, e);
            if (dtgconten.RowCount == 0)
            {
                var Result = msgp("No hay Datos en la Grilla, Igual Desea Generar?");
                if (Result != DialogResult.Yes)
                {
                    msg("Cancelado por el Usuario");
                    return;
                }
            }
            DateTime FechaInicial = dtpfechaini.Value;
            List<string> ListadoFecha = new List<string>();
            while (FechaInicial < dtpfechafin.Value)
            {
                ListadoFecha.Add(FechaInicial.ToString("yyyyMM"));
                FechaInicial = FechaInicial.AddMonths(1);
            }
            //Recorremos las empresas
            //Avanza para Generar el TXT           
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
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
                        if (item.ToString() != "TODAS")
                        {
                            DataView dv = TDatos.Copy().AsDataView();
                            dv.RowFilter = $"empresa like '{EmpresaValor}'";
                            //POR PERIODOS
                            foreach (string fechas in ListadoFecha)
                            {
                                DataView dvf = new DataView(dv.ToTable());
                                dvf.RowFilter = $"periodo like '{fechas}'";
                                DataTable TablaResult = dvf.ToTable();
                                string añio = fechas.Substring(0, 4);
                                string mes = fechas.Substring(4, 2);
                                //Sí no hay datos
                                if (TablaResult.Rows.Count == 0)
                                {
                                    SaveFile.FileName = $"{valor}LE{Ruc}{añio}{mes}00060100001{0}11.txt";
                                    //grabamos
                                    string path = SaveFile.FileName;
                                    st = File.CreateText(path);
                                    st.Write("");
                                    st.Close();
                                }
                                //si hay datos
                                else
                                {
                                    string[] campo = new string[22];
                                    string cadenatxt = "";
                                    //int ValorPrueba = 0;
                                    int contador = 1;
                                    foreach (DataRow fila in TablaResult.Rows)
                                    {
                                        int index = TablaResult.Rows.IndexOf(fila);
                                        string cuentaAux = fila["Cuenta_Contable"].ToString();
                                        string CuoAux = fila["Cod_Asiento_Contable"].ToString();
                                        if (index > 0)
                                        {
                                            if (TablaResult.Rows[index - 1]["Cod_Asiento_Contable"].ToString() != CuoAux)
                                            {
                                                contador = 1;
                                            }
                                            else contador++;
                                        }
                                        //ValorPrueba = 0;
                                        int c = 0;
                                        //1
                                        campo[c++] = $"{añio}{mes}00";
                                        campo[c++] = fila["Cod_Asiento_Contable"].ToString();
                                        campo[c++] = $"M{contador}";
                                        campo[c++] = fila["Cuenta_Contable"].ToString();
                                        //5          
                                        campo[c++] = fila["Cod_Asiento_Contable"].ToString();//cod operacion istitucional
                                        campo[c++] = "";//centro costo
                                                        // campo[c++] = fila["moneda"].ToString() == "SOL" ? "PEN" : fila["moneda"].ToString();
                                        campo[c++] = "PEN";
                                        campo[c++] = "";//tipo de documento de identidad del emisor
                                        campo[c++] = fila["Num_Doc"].ToString();
                                        //10
                                        campo[c++] = ((int)fila["Id_Comprobante"]).ToString("00");
                                        int[] tipos = { 1, 2, 3, 4, 6, 7, 8, 10, 22, 34, 35, 36, 46, 48, 56, 89 };
                                        string SerieDoc = fila["Cod_Comprobante"].ToString();
                                        if (tipos.Contains((int)fila["Id_Comprobante"]) && SerieDoc.Length != 4)
                                        {
                                            if (SerieDoc.Length > 4)
                                                SerieDoc = SerieDoc.Substring(0, 4);
                                            SerieDoc = "0000".Substring(SerieDoc.Length) + SerieDoc;
                                        }
                                        campo[c++] = Configuraciones.DefectoSunatString(SerieDoc);
                                        campo[c++] = Configuraciones.DefectoSunatString(Configuraciones.AlfaNumericoSunat(fila["Num_Comprobante"].ToString()));
                                        campo[c++] = ((DateTime)fila["FechaContable"]).ToString("dd/MM/yyyy");
                                        campo[c++] = "";// ((DateTime)fila["FechaRegistro"]).ToString("dd/MM/yyyy");
                                                        //15
                                        campo[c++] = ((DateTime)(fila["FechaEmision"].ToString() == "" ? fila["fechacontable"] : fila["fechaemision"])).ToString("dd/MM/yyyy");
                                        campo[c++] = Configuraciones.DefectoSunatString(fila["glosa"].ToString());
                                        campo[c++] = Configuraciones.DefectoSunatString(fila["glosa"].ToString());
                                        campo[c++] = ((decimal)fila["Pen"]) >= 0 ? (Math.Abs((decimal)fila["pen"])).ToString("0.00") : "0.00";
                                        campo[c++] = ((decimal)fila["Pen"]) <= 0 ? (Math.Abs((decimal)fila["pen"])).ToString("0.00") : "0.00";
                                        //20
                                        campo[c++] = "";
                                        campo[c++] = "1";
                                        //Uniendo por pipes
                                        cadenatxt += string.Join("|", campo) + $"{Environment.NewLine}";
                                        //Limpiamos el Campo
                                        //campo = null;
                                    }
                                    //Formato 6.1
                                    SaveFile.FileName = $"{valor}LE{Ruc}{añio}{mes}00060100001{1}11.txt";
                                    string path = SaveFile.FileName;
                                    st = File.CreateText(path);
                                    st.Write(cadenatxt);
                                    st.Close();
                                }
                            }
                        }
                    }
                }
            //dtgconten.DataSource = TDatos;
            SaveFile.FileName = "";
            PanelTxt.Visible = false;
            msgOK("Generado TXT con Éxito");
            Cursor = Cursors.Default;
        }
        private void dtgconten_Sorted(object sender, EventArgs e)
        {
            Ordenado = true;
        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();
            if (dtgconten.RowCount > 0)
            {
                Auditoria = true;
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
                else msg("Cancelado por el Usuario");
            }
            else
            {
                msg("No hay Datos que Exportar");
            }
        }
    }
}
