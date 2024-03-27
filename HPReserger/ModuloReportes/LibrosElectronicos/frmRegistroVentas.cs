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
    public partial class frmRegistroVentas : Form
    {
        public frmRegistroVentas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void frmRegistroVentas_Load(object sender, EventArgs e)
        {
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
        //private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int x = 0;
        //    if (cboempresa.Items.Count > 0)
        //    {
        //        x = cboempresa.SelectedIndex;
        //        DataRow Fila = ((DataTable)cboempresa.DataSource).Rows[x];
        //        txtRucDeudor.Text = txtruc.Text = Fila["ruc"].ToString();
        //    }
        //    else
        //    {
        //        txtruc.CargarTextoporDefecto();
        //    }
        //}
        private void btngenerar_Click(object sender, EventArgs e)
        {
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
            TDatos = CapaLogica.FormatodeVentas14_1(ListadoEmpresas, FechaInicio, FechaFin);
            dtgconten.DataSource = TDatos;
            lblmensaje.Text = $"Total de Registros: {dtgconten.RowCount}";
            if (dtgconten.RowCount == 0) msg("No Hay Registros");
            Ordenado = false;
            Cursor = Cursors.Default;
        }
        private bool Ordenado = true;
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
                        //Asignacion de Nombre y Eliminacion del Excel Antiguo 
                        string Cadenax = "";
                        if (cboperiodode.FechaInicioMes.Month == FechaFin.Month && cboperiodode.FechaInicioMes.Year == FechaFin.Year)
                            Cadenax = cboperiodode.FechaInicioMes.ToString("MMMyyyy");
                        else
                            Cadenax = cboperiodode.FechaInicioMes.ToString("MMMyyyy") + "-" + FechaFin.ToString("MMMyyyy");
                        Cadenax = Cadenax.ToUpper();

                        string NameFile;
                        if (chksubtotales.Checked)
                        {
                            NameFile = valor + $"{Cadenax} REGISTRO DE VENTAS {EmpresaValor} - Totales.xlsx";
                            File.Delete(NameFile);
                            File.Exists(NameFile);
                        }
                        else
                        {
                            NameFile = valor + $"{Cadenax}REGISTRO DE VENTAS {EmpresaValor}.xlsx";
                            File.Delete(NameFile);
                            File.Exists(NameFile);
                        }
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
                                    string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                                    _NombreHoja = $"{fechas}"; _Cabecera = "FORMATO 14.1: REGISTRO DE VENTAS";
                                    _Columnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 }; _NColumna = "m";

                                    List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                                    //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                                    Color Back = Color.FromArgb(78, 129, 189);
                                    Color Fore = Color.FromArgb(255, 255, 255);
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "a1", _Cabecera.ToUpper(), 14, true, false, Back, Fore));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "PERIODO:", 10, false, false, Back, Fore));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", $"{fechas}", 10, false, true, Back, Fore));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", "Ruc:", 10, false, false, Back, Fore));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", "c3", $"{Ruc}", 10, false, false, Back, Fore));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", "a4", "APELLIDOS Y NOMBRES, DENOMINACIÓN O RAZÓN SOCIAL:", 10, false, false, Back, Fore));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("h4", "h4", $"{EmpresaValor}", 10, false, false, Back, Fore));
                                    //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "b2", "Nombre Vendedor:", 11));
                                    ///////estilos de la celdas
                                    HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                                    HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                                    /////fin estilo de las celdas
                                    DataTable TableResult = new DataTable(); DataView dt = ((DataTable)dtgconten.DataSource).AsDataView(); TableResult = dt.ToTable();
                                    //
                                    int PosInicialGrilla = 6;
                                    int[] ColumnasSubtotal = { 12, 13, 14, 15, 16, 17, 18, 19 };
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
                                        int filaT = 7;
                                        Boolean PrimeraCarga = false;
                                        foreach (int Columna in ColumnasSubtotal)
                                        {
                                            SumaParcial = SumatoriaTotal = 0;
                                            for (int i = 0; i < TablaResult.Rows.Count; i++)
                                            {
                                                DataRow Fila = TablaResult.Rows[i];
                                                if (!PrimeraCarga)
                                                {
                                                    if (Fila[fila].ToString() != val1)
                                                    {
                                                        DataRow Nueva = TablaResult.NewRow();
                                                        Nueva[filaT] = $"Total {val1}";
                                                        Nueva[Columna] = SumaParcial;
                                                        TablaResult.Rows.InsertAt(Nueva, i);
                                                        //
                                                        val1 = Fila[fila].ToString();
                                                        SumaParcial = (decimal)Fila[Columna];
                                                        SumatoriaTotal += SumaParcial;
                                                        i++;

                                                    }
                                                    else
                                                    {
                                                        SumatoriaTotal += (decimal)Fila[Columna];
                                                        SumaParcial += (decimal)Fila[Columna];
                                                    }
                                                }
                                                else
                                                {
                                                    if (i < TablaResult.Rows.Count - 2)
                                                        if (Fila[Columna].ToString() == "")
                                                        {
                                                            Fila[Columna] = SumaParcial;
                                                            SumaParcial = 0;
                                                        }
                                                        else
                                                        {
                                                            SumaParcial += (decimal)Fila[Columna];
                                                            SumatoriaTotal += (decimal)Fila[Columna];
                                                        }
                                                }
                                            }
                                            //UltimaFila
                                            if (!PrimeraCarga)
                                            {
                                                DataRow Nuevaf = TablaResult.NewRow();
                                                Nuevaf[filaT] = $"TOTAL {val1}";
                                                Nuevaf[Columna] = SumaParcial;
                                                TablaResult.Rows.InsertAt(Nuevaf, TablaResult.Rows.Count);
                                                //TotalGeneral
                                                DataRow Nuevax = TablaResult.NewRow();
                                                Nuevax[filaT] = $"TOTAL GENERAL";
                                                Nuevax[Columna] = SumatoriaTotal;
                                                TablaResult.Rows.InsertAt(Nuevax, TablaResult.Rows.Count);
                                                PrimeraCarga = true;
                                            }
                                            else
                                            {
                                                TablaResult.Rows[TablaResult.Rows.Count - 2][Columna] = SumaParcial;
                                                TablaResult.Rows[TablaResult.Rows.Count - 1][Columna] = SumatoriaTotal;
                                            }
                                        }
                                    }
                                    ///Tabla
                                    foreach (DataColumn items in TableResult.Columns) { items.ColumnName = dtgconten.Columns["x" + items.ColumnName].HeaderText; }
                                    /////
                                    ////Anterior
                                    //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", _NombreHoja, Celdas, 5, _Columnas, new int[] { }, new int[] { });
                                    HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(TablaResult, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, contador++, Celdas, 5, _Columnas, new int[] { }, new int[] { 2, 3, 4, 5, 6, 7, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 }, "");
                                    //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", "Cronograma de Pagos", Celdas, 2, new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { }, new int[] { });
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
        DateTime FechaPeriodo; string NombreEmpresa = "";
        public DateTime año = DateTime.Now.AddMonths(-1);
        public int empresa = 2;

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
        public void CerrarPanelTxt()
        {
            PanelTxt.Visible = false;
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();
        }

        private void comboMesAño1_Click(object sender, EventArgs e)
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
        private StreamWriter st;
        private DateTime FechaInicio;
        private DateTime FechaFin;
        private string nameEmpresa;

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
            string cabeceras = "Ruc|Razon Social|Periodo|CAR SUNAT|Fecha de emisión|Fecha Vcto/Pago|Tipo CP/Doc.|Serie del CDP|Nro CP o Doc. Nro Inicial (Rango)|Nro Final (Rango)|Tipo Doc Identidad|Nro Doc Identidad|Apellidos Nombres/ Razón Social|Valor Facturado Exportación|BI Gravada|Dscto BI|IGV / IPM|Dscto IGV / IPM|Mto Exonerado|Mto Inafecto|ISC|BI Grav IVAP|IVAP|ICBPER|Otros Tributos|Total CP|Moneda|Tipo Cambio|Fecha Emisión Doc Modificado|Tipo CP Modificado|Serie CP Modificado|Nro CP Modificado|ID Proyecto Operadores Atribución|Tipo de Nota|Est. Comp|Valor FOB Embarcado|Valor OP Gratuitas|Tipo Operación|DAM / CP|CLU";
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
                                //Sí no hay datos 14.1 Vacio
                                if (TablaResult.Rows.Count == 0)
                                {
                                    SaveFile.FileName = $"{valor}LE{Ruc}{añio}{mes}00140100001{0}11.txt";
                                    //grabamos
                                    string path = SaveFile.FileName;
                                    st = File.CreateText(path);
                                    st.Write("");
                                    st.Close();
                                }
                                //si hay datos
                                else
                                {
                                    string[] campo = new string[40];
                                    string cadenatxt = "";
                                    int ValorPrueba = 0;
                                    int c = 0;

                                    // Asignar cada parte de la cabecera a las columnas correspondientes
                                    foreach (string cabecera in cabeceraArray)
                                    {
                                        campo[c++] = cabecera;
                                    }
                                    cadenatxt += string.Join("|", campo) + $"{Environment.NewLine }";

                                    // Asignar los valores restantes
                                    foreach (DataRow fila in TablaResult.Rows)
                                    {
                                        ValorPrueba = 0;
                                        c = 0;
                                        campo[c++] = Ruc;
                                        //campo[c++] = empresa.ToString();
                                        campo[c++] = fila[xEmpresa.DataPropertyName].ToString();
                                        campo[c++] = $"{añio}{mes}";

                                        string[] Tfilas = new string[2];
                                        Tfilas[0] = "";
                                        Tfilas[1] = "";
                                        Tfilas = fila[xNumCom.DataPropertyName].ToString().Trim().Split('/');
                                        string numdoc = int.Parse(Tfilas[0].ToString()).ToString().PadLeft(10, '0');

                                        campo[c++] = $"{Ruc}{(int.Parse(fila[xidC.DataPropertyName].ToString())).ToString("00")}{fila[xSerieCom.DataPropertyName].ToString().Trim().Substring(0, Math.Min(4, fila[xSerieCom.DataPropertyName].ToString().Trim().Length))}{numdoc}";
                                        campo[c++] = ((DateTime)fila[xFechaEmision.DataPropertyName]).ToString("dd/MM/yyyy");
                                        campo[c++] = "";
                                        campo[c++] = (int.Parse(fila[xidC.DataPropertyName].ToString())).ToString("00");
                                        campo[c++] = fila[xSerieCom.DataPropertyName].ToString().Trim();
                                        campo[c++] = int.Parse(Tfilas[0].ToString()).ToString();
                                        campo[c++] = "";

                                        campo[c++] = (int.Parse(fila[xTipoIdPro.DataPropertyName].ToString())).ToString();
                                        campo[c++] = fila[xNumpro.DataPropertyName].ToString() == "" ? "-" : fila[xNumpro.DataPropertyName].ToString().Trim();
                                        string Cadena = fila[xNombrePro.DataPropertyName].ToString().ToUpper().Trim();
                                        campo[c++] = Cadena.Substring(0, Cadena.Length > 60 ? 60 : Cadena.Length);
                                        
                                        //Valor Facturado Exportación
                                        campo[c++] = (decimal.Parse(fila[xImportacion.DataPropertyName].ToString())).ToString("0.00");
                                        //BI Gravada
                                        campo[c++] = (decimal.Parse(fila[ximporteIGV.DataPropertyName].ToString())).ToString("0.00");
                                        //Dscto BI
                                        campo[c++] = "0.00";
                                        //IGV / IPM
                                        campo[c++] = (decimal.Parse(fila[xIGVyoIPM.DataPropertyName].ToString())).ToString("0.00");
                                        //Dscto IGV / IPM
                                        campo[c++] = "0.00";
                                        //Mto Exonerado
                                        campo[c++] = (decimal.Parse(fila[xExonerado.DataPropertyName].ToString())).ToString("0.00");
                                        //Mto Inafecto
                                        campo[c++] = (decimal.Parse(fila[ximporteNGR.DataPropertyName].ToString())).ToString("0.00");
                                        //ISC	
                                        campo[c++] = (decimal.Parse(fila[xisc.DataPropertyName].ToString())).ToString("0.00");
                                        //BI Grav IVAP	
                                        campo[c++] = "0";
                                        // IVAP	
                                        campo[c++] = "0";
                                        //ICBPER	
                                        campo[c++] = (decimal.Parse(fila[xICBP.DataPropertyName].ToString())).ToString("0.00");
                                        //Otros Tributos
                                        campo[c++] = (decimal.Parse(fila[xOtrosTributos.DataPropertyName].ToString())).ToString("0.00");
                                        //Total CP
                                        campo[c++] = (decimal.Parse(fila[xImporteTotal.DataPropertyName].ToString())).ToString("0.00");

                                        //Moneda
                                        //Tipo Cambio
                                        if (fila[xMoneda.DataPropertyName].ToString() == "USD")
                                        {
                                            campo[c++] = "USD";
                                            campo[c++] = (decimal.Parse(fila[xTC.DataPropertyName].ToString())).ToString("0.000");
                                        }
                                        else
                                        {
                                            campo[c++] = "PEN";
                                            campo[c++] = "1.000";// (decimal.Parse(fila[xTC.DataPropertyName].ToString())).ToString("0.000");
                                        }
                                        //Fecha Emisión Doc Modificado
                                        campo[c++] = fila[xFechaDocRef.DataPropertyName].ToString() == "" ? "" : ((DateTime)fila[xFechaDocRef.DataPropertyName]).ToString("dd/MM/yyyy");
                                        //Tipo CP Modificado
                                        int.TryParse(fila[xTipoDocRef.DataPropertyName].ToString(), out ValorPrueba);
                                        campo[c++] = ValorPrueba > 0 ? ValorPrueba.ToString("00") : "";
                                        //Serie CP Modificado
                                        campo[c++] = fila[xSerieDocRef.DataPropertyName].ToString() == "" ? "" : fila[xSerieDocRef.DataPropertyName].ToString().Trim();
                                        //Nro CP Modificado
                                        campo[c++] = fila[xNumDocRef.DataPropertyName].ToString() == "" ? "" : fila[xNumDocRef.DataPropertyName].ToString().Trim();
                                        //ID Proyecto Operadores Atribución
                                        campo[c++] = "";
                                        //Tipo de Nota
                                        campo[c++] = "";
                                        //Est. Comp
                                        campo[c++] = "1";
                                        //Valor FOB Embarcado
                                        campo[c++] = "0";
                                        //Valor OP Gratuitas
                                        campo[c++] = "0";
                                        //Tipo Operación
                                        campo[c++] = fila[xTipoOperacion.DataPropertyName].ToString();
                                        //DAM / CP
                                        campo[c++] = "";
                                        //CLU
                                        campo[c++] = "";





                                        //1
                                        //campo[c++] = $"{añio}{mes}00";
                                        //campo[c++] = (int.Parse(fila[xix.DataPropertyName].ToString())).ToString("000");
                                        //campo[c++] = $"M{int.Parse(fila[xix.DataPropertyName].ToString())}";
                                        //campo[c++] = ((DateTime)fila[xFechaEmision.DataPropertyName]).ToString("dd/MM/yyyy");
                                        //campo[c++] = "01/01/0001";
                                        //campo[c++] = (int.Parse(fila[xidC.DataPropertyName].ToString())).ToString("00");
                                        //campo[c++] = fila[xSerieCom.DataPropertyName].ToString().Trim();
                                        //string[] Tfilas = new string[2];
                                        //Tfilas[0] = "";
                                        //Tfilas[1] = "";
                                        //Tfilas = fila[xNumCom.DataPropertyName].ToString().Trim().Split('/');
                                        //campo[c++] = int.Parse(Tfilas[0].ToString()).ToString();
                                        ////En caso de optar por anotar el importe total de las operaciones realizadas diariamente, registrar el número final. 
                                        //campo[c++] = Tfilas.Length > 1 ? int.Parse(Tfilas[1].ToString()).ToString() : "";//0-20
                                        ////10
                                        //campo[c++] = (int.Parse(fila[xTipoIdPro.DataPropertyName].ToString())).ToString();
                                        //campo[c++] = fila[xNumpro.DataPropertyName].ToString() == "" ? "-" : fila[xNumpro.DataPropertyName].ToString().Trim();
                                        //string Cadena = fila[xNombrePro.DataPropertyName].ToString().ToUpper().Trim();
                                        //campo[c++] = Cadena.Substring(0, Cadena.Length > 60 ? 60 : Cadena.Length);
                                        ////Parte de los IGV
                                        //campo[c++] = (decimal.Parse(fila[xImportacion.DataPropertyName].ToString())).ToString("0.00");
                                        //campo[c++] = (decimal.Parse(fila[ximporteIGV.DataPropertyName].ToString())).ToString("0.00");
                                        ////Descuento Base Imponible
                                        //campo[c++] = "0";
                                        //campo[c++] = (decimal.Parse(fila[xIGVyoIPM.DataPropertyName].ToString())).ToString("0.00");
                                        ////Descuento del Igv
                                        //campo[c++] = "0";
                                        //campo[c++] = (decimal.Parse(fila[xExonerado.DataPropertyName].ToString())).ToString("0.00");
                                        ////Partes de los GNG
                                        //campo[c++] = (decimal.Parse(fila[ximporteNGR.DataPropertyName].ToString())).ToString("0.00");
                                        ////20
                                        //campo[c++] = (decimal.Parse(fila[xisc.DataPropertyName].ToString())).ToString("0.00");
                                        ////IVAP = Arroz Pilado y su Impuesto
                                        //campo[c++] = "0";
                                        //campo[c++] = "0";
                                        ////Otros Conceptos
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
                                        //    campo[c++] = (decimal.Parse(fila[xTC.DataPropertyName].ToString())).ToString("0.000");
                                        //}
                                        //campo[c++] = fila[xFechaDocRef.DataPropertyName].ToString() == "" ? "01/01/0001" : ((DateTime)fila[xFechaDocRef.DataPropertyName]).ToString("dd/MM/yyyy");
                                        //int.TryParse(fila[xTipoDocRef.DataPropertyName].ToString(), out ValorPrueba);
                                        //campo[c++] = ValorPrueba > 0 ? ValorPrueba.ToString("00") : "";
                                        ////Datos del Documento que Modifica
                                        //campo[c++] = fila[xSerieDocRef.DataPropertyName].ToString() == "" ? "" : fila[xSerieDocRef.DataPropertyName].ToString().Trim();
                                        ////30
                                        //campo[c++] = fila[xNumDocRef.DataPropertyName].ToString() == "" ? "" : fila[xNumDocRef.DataPropertyName].ToString().Trim();
                                        ////Indica el estado del comprobante de pago y a la incidencia en la base imponible  en relación al periodo tributario correspondiente
                                        ////1. Obligatorio
                                        ////2.Registrar '1' cuando la operación(ventas gravadas, exoneradas, inafectas y / o exportaciones) corresponde al periodo, así como a las Notas de Crédito y Débito emitidas en el periodo.
                                        ////3.Registrar '2' cuando el documento ha sido inutilizado durante el periodo previamente a ser entregado, emitido o durante su emisión.
                                        ////4.Registrar '8' cuando la operación(ventas gravadas, exoneradas, inafectas y / o exportaciones) corresponde a un periodo anterior y NO ha sido anotada en dicho periodo.
                                        ////5.Registrar '9' cuando la operación(ventas gravadas, exoneradas, inafectas y / o exportaciones) corresponde a un periodo anterior y SI ha sido anotada en dicho periodo.
                                        //campo[c++] = "";
                                        //campo[c++] = "";
                                        //campo[c++] = "";
                                        ////CampoFinal
                                        ////Validacion del Identificador de Estado!
                                        //int Estado = 0;
                                        //DateTime FechaDeclara = new DateTime(int.Parse(añio), int.Parse(mes), 1);
                                        //DateTime FechaEmision = (DateTime)fila[xFechaEmision.DataPropertyName];
                                        ////Mismo Mes de Declaración
                                        //if (FechaDeclara.Month == FechaEmision.Month && FechaEmision.Year == FechaDeclara.Year)
                                        //{
                                        //    //if ((decimal.Parse(fila[ximporteNGR.DataPropertyName].ToString())) > 0)
                                        //    //Estado = 1;
                                        //    //else
                                        //    Estado = 1;
                                        //}
                                        //else
                                        //{
                                        //    //Calculamos la diferencia para ver cuantos meses pasaron
                                        //    int anio = FechaDeclara.Year - FechaEmision.Year;
                                        //    int meses = (FechaDeclara.Month + (anio * 12)) - FechaEmision.Month;
                                        //    if (meses < 12)
                                        //        Estado = 8;
                                        //    else Estado = 7;
                                        //}
                                        ////Columna Final
                                        //campo[c++] = Estado.ToString();
                                        //Uniendo por pipes
                                        cadenatxt += string.Join("|", campo) + $"{Environment.NewLine }";
                                        //Limpiamos el Campo
                                        //campo = null;
                                    }
                                    //Formato 14.1
                                    SaveFile.FileName = $"{valor}LE{Ruc}{añio}{mes}0014040001.txt";
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
            //SaveFile.FileName = $"LE{txtRucDeudor.Text}{txtaño.Text}{txtmes.Text}00140100001{txtinformacion.Text}11";
            //if (SaveFile.FileName != string.Empty && SaveFile.ShowDialog() == DialogResult.OK)
            //{
            //    string path = SaveFile.FileName;
            //    st = File.CreateText(path);
            //    st.Write(cadenatxt);
            //    st.Close();
            //    msgOK("Generado TXT con Éxito");
            //    PanelTxt.Visible = false;
            //}
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

        private void buttonPer1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            CargarDatosDelExcel(openFileDialog1.FileName);
        }
        private Boolean CargarDatosDelExcel(string Ruta)
        {
            TDatos = HPResergerFunciones.Utilitarios.CargarDatosDeExcelAGrilla(Ruta, 1, 7, 11);
            for (int i = 0; i < 5; i++)
            {
                if (i > 0)
                {
                    TDatos.Rows.RemoveAt(0);
                }
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
    }
}
