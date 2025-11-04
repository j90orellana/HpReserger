using CrystalDecisions.Shared;
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
    public partial class frmRegistroCompras : FormGradient
    {
        public frmRegistroCompras()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void frmRegistroCompras_Load(object sender, EventArgs e)
        {
            chksubtotales.Visible = true;
            cargarEmpresa();
        }
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
        public void CerrarPanelTxt()
        {
            PanelTxt.Visible = false;
        }
        private void btngenerar_Click(object sender, EventArgs e)
        {
            //dtgconten.Columns[xNumero_TablaSunat.Name].Visible = true;
            CerrarPanelTxt();
            Cursor = Cursors.WaitCursor;
            if (chklist.CheckedItems.Count == 0) { msg("Seleccione una Empresa"); return; }
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
            //ACTIVAR PARA PODER GENERAR!           
            //if (cboempresa.Items.Count == 0) { msg("No hay Empresas"); return; }
            //if (cboempresa.SelectedValue == null) { msg("Seleccion una Empresa"); cboempresa.Focus(); return; }
            TDatos = CapaLogica.FormatodeCompras8_1_Masivo(ListadoEmpresas, FechaInicio, FechaFin);
            dtgconten.DataSource = TDatos;
            lblmensaje.Text = $"Total de Registros: {dtgconten.RowCount}";
            if (dtgconten.RowCount == 0) msg("No Hay Registros");
            Ordenado = false;
            Cursor = Cursors.Default;
            //                        
        }
        DataTable TDatos;
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        frmProcesando frmproce;
        private void btnexcel_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();
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
                else msg("Cancelado por el Usuario");
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
                        string NameFile;
                        //Asignacion de Nombre y Eliminacion del Excel Antiguo 
                        string Cadenax = "";
                        if (cboperiodode.FechaInicioMes.Month == FechaFin.Month && cboperiodode.FechaInicioMes.Year == FechaFin.Year)
                            Cadenax = cboperiodode.FechaInicioMes.ToString("MMMyyyy");
                        else
                            Cadenax = cboperiodode.FechaInicioMes.ToString("MMMyyyy") + "-" + FechaFin.ToString("MMMyyyy");
                        Cadenax = Cadenax.ToUpper();

                        if (!chksubtotales.Checked)
                            NameFile = valor + $"{ Cadenax} REGISTRO DE COMPRAS {EmpresaValor}.xlsx";
                        else
                            NameFile = valor + $"{Cadenax} REGISTRO DE COMPRAS {EmpresaValor} - Totales.xlsx";

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
                                dvf.RowFilter = $"fechacontable like '{fechas}'";
                                DataTable TablaResult = dvf.ToTable();
                                string añio = fechas.Substring(0, 4);
                                string mes = fechas.Substring(4, 2);
                                //Sí no hay datos
                                if (TablaResult.Rows.Count > 0)
                                {
                                    //Modificamos el Excel
                                    string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                                    _NombreHoja = $"{fechas}"; _Cabecera = "FORMATO 8.1: REGISTRO DE COMPRAS";
                                    _Columnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 }; _NColumna = "m";

                                    List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                                    //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                                    Color Back = Color.FromArgb(78, 129, 189);
                                    Color Fore = Color.FromArgb(255, 255, 255);
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "a1", _Cabecera.ToUpper(), 14, true, false, Back, Fore));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "PERIODO:", 10, false, false, Back, Fore));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", $"{fechas}", 10, false, false, Back, Fore));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", "Ruc:", 10, false, false, Back, Fore));
                                    ////ACTIVAR CODIGO RUC
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", "c3", $"{Ruc}", 10, false, false, Back, Fore));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", "a4", "APELLIDOS Y NOMBRES, DENOMINACIÓN O RAZÓN SOCIAL:", 10, false, false, Back, Fore));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("h4", "h4", $"{EmpresaValor}", 10, false, false, Back, Fore));
                                    ///////estilos de la celdas
                                    HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                                    HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                                    /////fin estilo de las celdas
                                    //DataTable TableResult = new DataTable(); DataView dt = ((DataTable)dtgconten.DataSource).AsDataView(); TableResult = dt.ToTable();
                                    ///Tabla
                                    /////Proceso de ordenamiento y agrupacion                                    
                                    int PosInicialGrilla = 6;
                                    int[] ColumnasSubtotal = { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
                                    if (chksubtotales.Checked)
                                    {
                                        //Ordenamos los datos
                                        DataView dvo = new DataView(TablaResult);
                                        dvo.Sort = "idc asc ";
                                        TablaResult = dvo.ToTable();
                                        string val1 = TablaResult.Rows[0]["idc"].ToString();
                                        decimal SumatoriaTotal = 0;
                                        decimal SumaParcial = 0;
                                        //
                                        int fila = 6;
                                        int filaT = 12;
                                        Boolean PrimeraCarga = false;
                                        // Crear una nueva fila de totales
                                        DataRow totalRow = TablaResult.NewRow();

                                        // Colocar "TOTALES" en la columna 12
                                        totalRow[12] = "TOTALES";
                                        // Calcular la suma de cada columna en ColumnasSubtotal
                                        foreach (int col in ColumnasSubtotal)
                                        {
                                            totalRow[col] = TablaResult.AsEnumerable()
                                                              .Where(row => row[col] != DBNull.Value) // Evita valores nulos
                                                              .Sum(row => Convert.ToDecimal(row[col]));
                                        }

                                        // Agregar la fila de totales al DataTable
                                        TablaResult.Rows.Add(totalRow);

                                    }
                                    foreach (DataColumn items in TablaResult.Columns) { items.ColumnName = dtgconten.Columns["x" + items.ColumnName].HeaderText; }
                                    HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(TablaResult, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, contador++, Celdas, 6, _Columnas, new int[] { }, new int[] { }, "");
                                }
                            }
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
            dtgconten.ResumeLayout();
        }
        DateTime FechaFin;
        DateTime FechaInicio; string NombreEmpresa = "";
        public DateTime año = DateTime.Now.AddMonths(-1);
        public int empresa = 2;
        frmReporteCompras81Report frmreport;
        private void button1_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();

            if (frmreport == null)
            {
                Cursor = Cursors.WaitCursor;
                ////ACTIVAR PARA GENERAR REPORTES!
                //empresa = (int)cboempresa.SelectedValue;
                //frmreport = new frmReporteCompras81Report(empresa, txtruc.Text, cboempresa.Text, comboMesAño1.GetFechaPRimerDia());
                frmreport.FormClosed += Frmreport_FormClosed;
                frmreport.MdiParent = this.MdiParent;
                frmreport.Show();
                Cursor = Cursors.Default;
            }
            else
            {
                frmreport.StartPosition = FormStartPosition.CenterParent;
                frmreport.Activate();
            }
        }
        private void Frmreport_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmreport = null;
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();
        }

        private void comboMesAño1_Enter(object sender, EventArgs e)
        {
            CerrarPanelTxt();

        }

        private void cboempresa_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();

        }

        private void dtgconten_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();

        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private void btnTxt_Click(object sender, EventArgs e)
        {
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
            DateTime FechaInicial = FechaInicio;
            List<string> ListadoFecha = new List<string>();
            while (FechaInicial < FechaFin)
            {
                ListadoFecha.Add(FechaInicial.ToString("yyyyMM"));
                FechaInicial = FechaInicial.AddMonths(1);
            }

            // Dividir la cadena de cabeceras por '|'
            string cabeceras = "RUC|Apellidos y Nombres o Razón social|Periodo|CAR SUNAT|Fecha de emisión|Fecha Vcto/Pago|Tipo CP/Doc.|Serie del CDP|Año|Nro CP o Doc. Nro Inicial (Rango)|Nro Final (Rango)|Tipo Doc Identidad|Nro Doc Identidad|Apellidos Nombres/ Razón  Social|BI Gravado DG|IGV / IPM DG|BI Gravado DGNG|IGV / IPM DGNG|BI Gravado DNG|IGV / IPM DNG|Valor Adq. NG|ISC|ICBPER|Otros Trib/ Cargos|Total CP|Moneda|Tipo de Cambio|Fecha Emisión Doc Modificado|Tipo CP Modificado|Serie CP Modificado|COD. DAM O DSI|Nro CP Modificado|Clasif de Bss y Sss|ID Proyecto Operadores|PorcPart|IMB|CAR Orig/ Ind E o I|Detracción|Tipo de Nota|Est. Comp.|Incal|CLU1|CLU2|CLU3|CLU4|CLU5|CLU6|CLU7|CLU8|CLU9|CLU10|CLU11|CLU12|CLU13|CLU14|CLU15|CLU16|CLU17|CLU18|CLU19|CLU20|CLU21|CLU22|CLU23|CLU24|CLU25|CLU26|CLU27|CLU28|CLU29|CLU30|CLU31|CLU32|CLU33|CLU34|CLU35|CLU36|CLU37|CLU38|CLU39";
            string[] cabeceraArray = cabeceras.Split('|');


            //Avanza para Generar el TXT           
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
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
                                dvf.RowFilter = $"fechacontable like '{fechas}'";
                                DataTable TablaResult = dvf.ToTable();
                                string añio = fechas.Substring(0, 4);
                                string mes = fechas.Substring(4, 2);
                                //Sí no hay datos 8.1 Vacio
                                if (TablaResult.Rows.Count == 0)
                                {
                                    SaveFile.FileName = $"{valor}LE{Ruc}{añio}{mes}00080400021{0}12.txt";
                                    //grabamos
                                    string path = SaveFile.FileName;
                                    st = File.CreateText(path);
                                    st.Write("");
                                    st.Close();

                                    string txtFilePath = path;
                                    string zipFilePath = txtFilePath.Replace(".txt", ".zip");
                                    string directoryPath = Path.GetDirectoryName(txtFilePath);
                                    string fileName = Path.GetFileName(txtFilePath); // Solo el nombre del archivo

                                    // Comando para comprimir usando tar (desde el directorio del archivo)
                                    string command = $"cd /d \"{directoryPath}\" && tar -a -c -f \"{zipFilePath}\" \"{fileName}\"";

                                    ProcessStartInfo psi = new ProcessStartInfo()
                                    {
                                        FileName = "cmd.exe",
                                        Arguments = $"/C {command}",
                                        RedirectStandardOutput = true,
                                        UseShellExecute = false,
                                        CreateNoWindow = true
                                    };

                                    using (Process process = Process.Start(psi))
                                    {
                                        process.WaitForExit();
                                    }

                                }
                                //Sí no hay datos 8.2 Vacio
                                //if (TablaResult.Rows.Count == 0)
                                //{
                                //    SaveFile.FileName = $"{valor}LE{Ruc}{añio}{mes}00080200001{0}11.txt";
                                //    //grabamos
                                //    string path = SaveFile.FileName;
                                //    st = File.CreateText(path);
                                //    st.Write("");
                                //    st.Close();
                                //}
                                //si hay datos
                                else
                                {
                                    string[] campo = new string[80];
                                    string cadenatxt = "";
                                    int ValorPrueba = 0;

                                    int c = 0;

                                    //// Asignar cada parte de la cabecera a las columnas correspondientes
                                    //foreach (string cabecera in cabeceraArray)
                                    //{
                                    //    campo[c++] = cabecera;
                                    //}
                                    //cadenatxt += string.Join("|", campo) + $"{Environment.NewLine }";
                                    //// Asignar cada parte de la cabecera a las columnas correspondientes
                                    //c = 0;
                                    //foreach (string cabecera in cabeceraArray)
                                    //{
                                    //    campo[c++] = "";
                                    //}


                                    foreach (DataRow fila in TablaResult.Rows)
                                    {
                                        ValorPrueba = 0;
                                        c = 0;
                                        int idcomprobante = int.Parse(fila[xidC.DataPropertyName].ToString());

                                        campo[c++] = Ruc;
                                        campo[c++] = fila[xEmpresa.DataPropertyName].ToString();
                                        campo[c++] = $"{añio}{mes}";

                                        string[] Tfilas = new string[2];
                                        Tfilas[0] = "";
                                        Tfilas[1] = "";
                                        Tfilas = fila[xNumCom.DataPropertyName].ToString().Trim().Split('/');
                                        string numdoc = Int64.Parse(Tfilas[0].ToString()).ToString().PadLeft(10, '0');
                                        campo[c++] = "";// $"{fila[xNumpro.DataPropertyName].ToString().Trim()}{(int.Parse(fila[xidC.DataPropertyName].ToString())).ToString("00")}{fila[xSerieCom.DataPropertyName].ToString().Trim().Substring(0, Math.Min(4, fila[xSerieCom.DataPropertyName].ToString().Trim().Length))}{numdoc}";
                                        campo[c++] = ((DateTime)fila[xFechaEmision.DataPropertyName]).ToString("dd/MM/yyyy");
                                        campo[c++] = int.Parse(fila[xidC.DataPropertyName].ToString()) != 14 ? "" : ((DateTime)fila[xFechaVencimiento.DataPropertyName]).ToString("dd/MM/yyyy");
                                        campo[c++] = (int.Parse(fila[xidC.DataPropertyName].ToString())).ToString("00");
                                        campo[c++] = fila[xSerieCom.DataPropertyName].ToString();
                                        //Año
                                        int.TryParse(fila[xAñoDua.DataPropertyName].ToString(), out ValorPrueba);
                                        campo[c++] = ValorPrueba == 0 ? "" : ValorPrueba.ToString();
                                        //Nro CP o Doc. Nro Inicial (Rango)
                                        if ((new int[] { 1, 3, 4, 6, 7, 8, 36 }).Contains(idcomprobante))
                                            campo[c++] = Configuraciones.SubstringRight(fila[xNumCom.DataPropertyName].ToString().Trim(), 8);
                                        else
                                            campo[c++] = fila[xNumCom.DataPropertyName].ToString().Trim();
                                        //Nro Final (Rango)
                                        campo[c++] = "";

                                        //PROVEEDOR
                                        campo[c++] = (int.Parse(fila[xTipoIdPro.DataPropertyName].ToString())).ToString();
                                        campo[c++] = fila[xNumpro.DataPropertyName].ToString().Trim();
                                        string Cadena = fila[xNombrePro.DataPropertyName].ToString().ToUpper().Trim();
                                        campo[c++] = Cadena.Substring(0, Cadena.Length > 60 ? 60 : Cadena.Length);
                                        //Parte de los IGV
                                        campo[c++] = (decimal.Parse(fila[ximporteIGV.DataPropertyName].ToString())).ToString("0.00");
                                        campo[c++] = (decimal.Parse(fila[xigvIGV.DataPropertyName].ToString())).ToString("0.00");
                                        //Partes de los GNG
                                        campo[c++] = (decimal.Parse(fila[ximporteGNG.DataPropertyName].ToString())).ToString("0.00");
                                        campo[c++] = (decimal.Parse(fila[xigvGNG.DataPropertyName].ToString())).ToString("0.00");
                                        //Partes de los ONG
                                        campo[c++] = (decimal.Parse(fila[ximporteONG.DataPropertyName].ToString())).ToString("0.00");
                                        campo[c++] = (decimal.Parse(fila[xigvONG.DataPropertyName].ToString())).ToString("0.00");
                                        //Valor Adq. NG
                                        campo[c++] = (Math.Abs(decimal.Parse(fila[ximporteNGR.DataPropertyName].ToString()))).ToString("0.00");
                                        campo[c++] = (decimal.Parse(fila[xisc.DataPropertyName].ToString())).ToString("0.00");
                                        campo[c++] = (decimal.Parse(fila[xICBP.DataPropertyName].ToString())).ToString("0.00");
                                        campo[c++] = (decimal.Parse(fila[xOtrosTributos.DataPropertyName].ToString())).ToString("0.00");

                                        //Total CP
                                        campo[c++] = (decimal.Parse(fila[xImporteTotal.DataPropertyName].ToString())).ToString("0.00");
                                        //Validar Moneda
                                        if (fila[xMoneda.DataPropertyName].ToString() == "USD")
                                        {
                                            campo[c++] = "USD";
                                            campo[c++] = (decimal.Parse(fila[xTC.DataPropertyName].ToString())).ToString("0.000");
                                        }
                                        else
                                        {
                                            campo[c++] = "PEN";
                                            campo[c++] = "";
                                        }
                                        //Tipo de Cambio
                                        campo[c++] = fila[xFechaDocRef.DataPropertyName].ToString() == "" ? "" : ((DateTime)fila[xFechaDocRef.DataPropertyName]).ToString("dd/MM/yyyy");
                                        int.TryParse(fila[xTipoDocRef.DataPropertyName].ToString(), out ValorPrueba);
                                        //Tipo CP Modificado
                                        campo[c++] = fila[xFechaDocRef.DataPropertyName].ToString() == "" ? "" : ValorPrueba.ToString("00");
                                        //Serie CP Modificado
                                        campo[c++] = fila[xSerieDocRef.DataPropertyName].ToString() == "" ? "" : fila[xSerieDocRef.DataPropertyName].ToString().Trim();
                                        //COD. DAM O DSI
                                        campo[c++] = "";
                                        //
                                        campo[c++] = fila[xNumDocRef.DataPropertyName].ToString() == "" ? "" : fila[xNumDocRef.DataPropertyName].ToString().Trim();
                                        //Clasif de Bss y Sss	
                                        campo[c++] = fila[xNumero_TablaSunat.DataPropertyName].ToString();
                                        //ID Proyecto Operadores
                                        campo[c++] = "";
                                        //PorcPart	
                                        campo[c++] = "";
                                        //IMB
                                        campo[c++] = "0";
                                        //CAR Orig/ Ind E o I
                                        campo[c++] = "";
                                        c += 4;
                                        //Detracción	
                                        campo[c++] = fila[xDetraccion.DataPropertyName].ToString();
                                        //Tipo de Nota	
                                        campo[c++] = ValorPrueba != 0 ? (Convert.ToDecimal(fila[xigvIGV.DataPropertyName].ToString()) == 0 ? "6" : "1") : "";
                                        //Est. Comp.	
                                        //Validacion del Identificador de Estado!
                                        int Estado = 0;
                                        DateTime FechaDeclara = cboperiodode.GetFechaPRimerDia();
                                        DateTime FechaEmision = (DateTime)fila[xFechaEmision.DataPropertyName];
                                        //Mismo Mes de Declaración
                                        if (FechaDeclara.Month == FechaEmision.Month && FechaEmision.Year == FechaDeclara.Year)
                                        {
                                            if (decimal.Parse(fila[ximporteNGR.DataPropertyName].ToString()) > 0)
                                                Estado = 0;
                                            else
                                                Estado = 1;
                                        }
                                        else
                                        {
                                            //Calculamos la diferencia para ver cuantos meses pasaron
                                            int anio = FechaDeclara.Year - FechaEmision.Year;
                                            int meses = (FechaDeclara.Month + (anio * 12)) - FechaEmision.Month;
                                            if (meses < 12)
                                                Estado = 6;
                                            else Estado = 0;
                                        }
                                        ////Columna Final
                                        campo[c++] = Estado.ToString();
                                        //campo[c++] = "1";
                                        //Incal
                                        campo[c++] = "0";






                                        //1
                                        //campo[c++] = $"{añio}{mes}00";
                                        //campo[c++] = ((fila[xcuo.DataPropertyName].ToString())).ToString();
                                        //campo[c++] = "M2";
                                        //campo[c++] = ((DateTime)fila[xFechaEmision.DataPropertyName]).ToString("dd/MM/yyyy");
                                        ////5
                                        //campo[c++] = int.Parse(fila[xidC.DataPropertyName].ToString()) != 14 ? "" : ((DateTime)fila[xFechaVencimiento.DataPropertyName]).ToString("dd/MM/yyyy");
                                        //campo[c++] = (int.Parse(fila[xidC.DataPropertyName].ToString())).ToString("00");
                                        //campo[c++] = fila[xSerieCom.DataPropertyName].ToString();
                                        //int.TryParse(fila[xAñoDua.DataPropertyName].ToString(), out ValorPrueba);
                                        //campo[c++] = ValorPrueba.ToString();
                                        //if ((new int[] { 1, 3, 4, 6, 7, 8, 36 }).Contains(idcomprobante))
                                        //    campo[c++] = Configuraciones.SubstringRight(fila[xNumCom.DataPropertyName].ToString().Trim(), 8);
                                        //else
                                        //    campo[c++] = fila[xNumCom.DataPropertyName].ToString().Trim();
                                        ////En caso de optar por anotar el importe total de las operaciones diarias que no otorguen derecho a crédito fiscal en forma consolidada, registrar el número inicial
                                        ////1
                                        //campo[c++] = "";
                                        //campo[c++] = (int.Parse(fila[xTipoIdPro.DataPropertyName].ToString())).ToString();
                                        //campo[c++] = fila[xNumpro.DataPropertyName].ToString().Trim();
                                        //  Cadena = fila[xNombrePro.DataPropertyName].ToString().ToUpper().Trim();
                                        //campo[c++] = Cadena.Substring(0, Cadena.Length > 60 ? 60 : Cadena.Length);
                                        ////Parte de los IGV
                                        //campo[c++] = (decimal.Parse(fila[ximporteIGV.DataPropertyName].ToString())).ToString("0.00");
                                        //campo[c++] = (decimal.Parse(fila[xigvIGV.DataPropertyName].ToString())).ToString("0.00");
                                        ////Partes de los GNG
                                        //campo[c++] = (decimal.Parse(fila[ximporteGNG.DataPropertyName].ToString())).ToString("0.00");
                                        //campo[c++] = (decimal.Parse(fila[xigvGNG.DataPropertyName].ToString())).ToString("0.00");
                                        ////Partes de los ONG
                                        //campo[c++] = (decimal.Parse(fila[ximporteONG.DataPropertyName].ToString())).ToString("0.00");
                                        //campo[c++] = (decimal.Parse(fila[xigvONG.DataPropertyName].ToString())).ToString("0.00");
                                        ////Partes de NGR
                                        ////20
                                        //campo[c++] = (decimal.Parse(fila[ximporteNGR.DataPropertyName].ToString())).ToString("0.00");
                                        //campo[c++] = (decimal.Parse(fila[xisc.DataPropertyName].ToString())).ToString("0.00");
                                        //campo[c++] = (decimal.Parse(fila[xICBP.DataPropertyName].ToString())).ToString("0.00");
                                        //campo[c++] = (decimal.Parse(fila[xOtrosTributos.DataPropertyName].ToString())).ToString("0.00");
                                        ////Validar Moneda
                                        //campo[c++] = (decimal.Parse(fila[xImporteTotal.DataPropertyName].ToString())).ToString("0.00");
                                        //if (fila[xMoneda.DataPropertyName].ToString() == "USD")
                                        //{
                                        //    campo[c++] = "USD";
                                        //    campo[c++] = (decimal.Parse(fila[xTC.DataPropertyName].ToString())).ToString("0.000");
                                        //}
                                        //else
                                        //{
                                        //    campo[c++] = "PEN";
                                        //    campo[c++] = "0.000";
                                        //}
                                        //campo[c++] = fila[xFechaDocRef.DataPropertyName].ToString() == "" ? "01/01/0001" : ((DateTime)fila[xFechaDocRef.DataPropertyName]).ToString("dd/MM/yyyy");
                                        //int.TryParse(fila[xTipoDocRef.DataPropertyName].ToString(), out ValorPrueba);
                                        //campo[c++] = ValorPrueba.ToString("00");
                                        ////Datos del Documento que Modifica
                                        //campo[c++] = fila[xSerieDocRef.DataPropertyName].ToString() == "" ? "-" : fila[xSerieDocRef.DataPropertyName].ToString().Trim();
                                        //campo[c++] = "";
                                        ////Número del comprobante de pago emitido por sujeto no domiciliado
                                        ////30
                                        //campo[c++] = fila[xNumDocRef.DataPropertyName].ToString() == "" ? "" : fila[xNumDocRef.DataPropertyName].ToString().Trim();
                                        ////Fecha de emisión de la Constancia de Depósito de Detracción 
                                        //campo[c++] = fila[xFechaDet.DataPropertyName].ToString() == "" ? "01/01/0001" : ((DateTime)fila[xFechaDet.DataPropertyName]).ToString("dd/MM/yyyy");
                                        ////Número de la Constancia de Depósito de Detracción               
                                        //campo[c++] = fila[xNumDet.DataPropertyName].ToString() == "" ? "0" : fila[xNumDet.DataPropertyName].ToString().Trim();
                                        ////Marca del comprobante de pago sujeto a retención
                                        ////1. Obligatorio 
                                        ////2.Si identifica el comprobante sujeto a retención consignar '1', caso contrario '0'
                                        //campo[c++] = "";
                                        ////Indica el estado del comprobante de pago y a la incidencia en la base imponible  en relación al periodo tributario correspondiente
                                        ////1. Obligatorio
                                        ////2.Registrar '1' cuando se anota el Comprobante de Pago o documento en el periodo que se emitió o que se pagó el impuesto, según corresponda.
                                        ////3.Registrar '6' cuando la fecha de emisión del Comprobante de Pago o de pago del impuesto es anterior al periodo de anotación y esta se produce dentro de los doce meses siguientes a la emisión o pago del impuesto, según corresponda.
                                        ////4.Registrar '7' cuando la fecha de emisión del Comprobante de Pago o pago del impuesto es anterior al periodo de anotación y esta se produce luego de los doce meses siguientes a la emisión o pago del impuesto, según corresponda.
                                        ////5.Registrar '9' cuando se realice un ajuste en la anotación de la información de una operación registrada en un periodo anterior.
                                        //campo[c++] = "1";
                                        ////7 Extras
                                        //campo[c++] = "";
                                        //campo[c++] = "";
                                        //campo[c++] = "";
                                        //campo[c++] = "";
                                        //campo[c++] = "";
                                        //campo[c++] = "";
                                        ////CampoFinal
                                        ////Validacion del Identificador de Estado!
                                        //int Estado = 0;
                                        //DateTime FechaDeclara = cboperiodode.GetFechaPRimerDia();
                                        //DateTime FechaEmision = (DateTime)fila[xFechaEmision.DataPropertyName];
                                        ////Mismo Mes de Declaración
                                        //if (FechaDeclara.Month == FechaEmision.Month && FechaEmision.Year == FechaDeclara.Year)
                                        //{
                                        //    //if (decimal.Parse(fila[ximporteNGR.DataPropertyName].ToString()) > 0)
                                        //    //Estado = 0;
                                        //    //else
                                        //    Estado = 1;
                                        //}
                                        //else
                                        //{
                                        //    //Calculamos la diferencia para ver cuantos meses pasaron
                                        //    int anio = FechaDeclara.Year - FechaEmision.Year;
                                        //    int meses = (FechaDeclara.Month + (anio * 12)) - FechaEmision.Month;
                                        //    if (meses < 12)
                                        //        Estado = 6;
                                        //    else Estado = 0;
                                        //}
                                        ////Columna Final
                                        //campo[c++] = Estado.ToString();
                                        //Uniendo por pipes
                                        cadenatxt += string.Join("|", campo) + $"{Environment.NewLine}";
                                        //Limpiamos el Campo
                                        //campo = null;
                                    }
                                    //Formato 8.1
                                    SaveFile.FileName = $"{valor}LE{Ruc}{añio}{mes}000804001{1}11.txt";
                                    SaveFile.FileName = $"{valor}LE{Ruc}{añio}{mes}00080400021112.txt";

                                    string path = SaveFile.FileName;
                                    st = File.CreateText(path);
                                    st.Write(cadenatxt);
                                    st.Close();

                                    string txtFilePath = path;
                                    string zipFilePath = txtFilePath.Replace(".txt", ".zip");
                                    string directoryPath = Path.GetDirectoryName(txtFilePath);
                                    string fileName = Path.GetFileName(txtFilePath); // Solo el nombre del archivo

                                    // Comando para comprimir usando tar (desde el directorio del archivo)
                                    string command = $"cd /d \"{directoryPath}\" && tar -a -c -f \"{zipFilePath}\" \"{fileName}\"";

                                    ProcessStartInfo psi = new ProcessStartInfo()
                                    {
                                        FileName = "cmd.exe",
                                        Arguments = $"/C {command}",
                                        RedirectStandardOutput = true,
                                        UseShellExecute = false,
                                        CreateNoWindow = true
                                    };

                                    using (Process process = Process.Start(psi))
                                    {
                                        process.WaitForExit();
                                    }

                                    //Formato 8.2
                                    //SaveFile.FileName = $"{valor}LE{Ruc}{añio}{mes}00080200001{0}11.txt";
                                    //path = SaveFile.FileName;
                                    //st = File.CreateText(path);
                                    //cadenatxt = "";
                                    //st.Write(cadenatxt);
                                    //st.Close();
                                    //Formato 8.1
                                    //SaveFile.FileName = $"LE{txtRucDeudor.Text}{txtaño.Text}{txtmes.Text}00080100001{txtinformacion.Text}11";
                                    //if (SaveFile.FileName != string.Empty && SaveFile.ShowDialog() == DialogResult.OK)
                                    //{
                                    //    string path = SaveFile.FileName;
                                    //    st = File.CreateText(path);
                                    //    st.Write(cadenatxt);
                                    //    st.Close();
                                    //    //msg("Generado TXT con Éxito");
                                    //    PanelTxt.Visible = false;
                                    //}
                                    //Formato 8.2 - Esta Vacio aun
                                    //SaveFile.FileName = $"LE{txtRucDeudor.Text}{txtaño.Text}{txtmes.Text}00080200001011";
                                    //if (SaveFile.FileName != string.Empty && SaveFile.ShowDialog() == DialogResult.OK)
                                    //{
                                    //    string path = SaveFile.FileName;
                                    //    st = File.CreateText(path);
                                    //    st.Write("");
                                    //    st.Close();
                                    //    msgOK("Generado TXT con Éxito");
                                    //    PanelTxt.Visible = false;
                                    //}
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
        private StreamWriter st;
        private string nameEmpresa;
        private bool Ordenado = true;
        private void comboMesAño1_Load(object sender, EventArgs e)
        {

        }

        private void comboMesAño1_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();
        }

        private void PanelTxt_Leave(object sender, EventArgs e)
        {
            CerrarPanelTxt();
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
            //else
            //{
            //    chklist.SetItemCheckState(0, CheckState.Indeterminate);
            //}
        }

        private void dtgconten_Sorted(object sender, EventArgs e)
        {
            Ordenado = true;
        }

        private void buttonPer1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            CargarDatosDelExcel(openFileDialog1.FileName);
        }
        private Boolean CargarDatosDelExcel(string Ruta)
        {
            TDatos = HPResergerFunciones.Utilitarios.CargarDatosDeExcelAGrilla(Ruta, 1, 7, 11);
            for (int i = 0; i < 6; i++)
            {
                TDatos.Rows.RemoveAt(0);
            }
            TDatos.Rows.RemoveAt(TDatos.Rows.Count - 1);
            int x = 0;
            foreach (DataGridViewColumn item in dtgconten.Columns)
            {
                TDatos.Columns[x].ColumnName = item.DataPropertyName;
                x++;
            }


            dtgconten.DataSource = TDatos;
            if (TDatos.Rows.Count == 0)
            {
                return false;
            }
            return true;
            //List<string> Listado = new List<string>();
            //foreach (string item in HPResergerFunciones.Utilitarios.ListarHojasDeunExcel(Ruta))
            //{
            //    Listado.Add(item);
            //}
            //dtgconten.DataSource = HPResergerFunciones.Utilitarios.CargarDatosDeExcelAGrilla(Ruta, Listado[0].ToString());
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
