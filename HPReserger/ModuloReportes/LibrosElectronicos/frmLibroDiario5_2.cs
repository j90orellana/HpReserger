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
    public partial class frmLibroDiario5_2 : FormGradient
    {
        public frmLibroDiario5_2()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable TablaEmpresa;
        private DateTime FechaInicio;
        private DateTime FechaFin;
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
        private void frmLibroDiario_Load(object sender, EventArgs e)
        {
            cargarEmpresa();
        }
        public void CerrarPanelTxt()
        {
            PanelTxt.Visible = false;
        }
        private bool Ordenado = true;
        DataTable TDatos;

        public string nameEmpresa { get; private set; }

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
            //ACTIVAR PARA PODER GENERAR!           
            //CargarEmpresas();
            string BuscarEmpresa = "(";
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
            TDatos = CapaLogica.LibroDiario5_1(FechaInicio, FechaFin, "0=0", "0=0", "0=0", "0=0", ListadoEmpresas, "0=0");
            dtgconten.DataSource = TDatos;
            //Configuraciones.TiempoEjecucionMsg(stopwatch); stopwatch.Stop();
            //dtgconten.AutoGenerateColumns = true;            
            //dtgconten.DataMember = "cuenta_contable";
            Cursor = Cursors.Default;
            lblmensaje.Text = $"Total de Registros: {dtgconten.RowCount}";
            if (dtgconten.RowCount == 0) msg("No Hay Registros");
            Ordenado = false;
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
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private StreamWriter st;
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
            DateTime FechaInicial = FechaInicio;
            List<string> ListadoFecha = new List<string>();
            while (FechaInicial < FechaFin)
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
                                    SaveFile.FileName = $"{valor}LE{Ruc}{añio}{mes}00050200001{0}11.txt";
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
                                        campo[c++] = ((decimal)fila["debe"]).ToString("0.00"); //((decimal)fila["Pen"]) >= 0 ? (Math.Abs((decimal)fila["pen"])).ToString("0.00") : "0.00";
                                        campo[c++] = ((decimal)fila["haber"]).ToString("0.00");  //((decimal)fila["Pen"]) <= 0 ? (Math.Abs((decimal)fila["pen"])).ToString("0.00") : "0.00";
                                        //20
                                        campo[c++] = "";
                                        campo[c++] = "1";
                                        //Uniendo por pipes
                                        cadenatxt += string.Join("|", campo) + $"{Environment.NewLine}";
                                        //Limpiamos el Campo
                                        //campo = null;
                                    }
                                    //Formato 6.1
                                    SaveFile.FileName = $"{valor}LE{Ruc}{añio}{mes}00050200001{1}11.txt";
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
        frmProcesando frmproce;
        private bool Auditoria;

        private void btnexcel_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();
            if (dtgconten.RowCount > 0)
            {
                Auditoria = false;
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
                        string NameFile = valor + $"{Cadenax} 5.2 LIBRO DIARIO {EmpresaValor}.xlsx";
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
                                DataTable TablaResult = dvf.ToTable();
                                string añio = fechas.Substring(0, 4);
                                string mes = fechas.Substring(4, 2);
                                //Sí no hay datos
                                if (TablaResult.Rows.Count > 0)
                                {
                                    //Modificamos el Excel
                                    string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                                    _NombreHoja = $"{fechas}"; _Cabecera = "5.2 LIBRO DIARIO DE FORMATO SIMPLIFICADO";
                                    _Columnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 }; _NColumna = "m";

                                    List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                                    //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                                    Color Back = Color.FromArgb(78, 129, 189);
                                    Color Fore = Color.FromArgb(255, 255, 255);
                                    if (Auditoria)
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "a1", "LIBRO DIARIO", 14, true, false, Back, Fore));
                                    else
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "a1", _Cabecera.ToUpper(), 14, true, false, Back, Fore));
                                    //
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "PERIODO:", 10, false, false, Back, Fore));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", $"{fechas}", 10, false, false, Back, Fore));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", "Ruc:", 10, false, false, Back, Fore));
                                    ////ACTIVAR CODIGO RUC
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", "c3", $"{Ruc}", 10, false, false, Back, Fore));
                                    if (Auditoria)
                                    {
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", "a4", "RAZÓN SOCIAL:", 10, false, false, Back, Fore));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("c4", "c4", $"{EmpresaValor}", 10, false, false, Back, Fore));

                                    }
                                    else
                                    {
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", "a4", "APELLIDOS Y NOMBRES, DENOMINACIÓN O RAZÓN SOCIAL:", 10, false, false, Back, Fore));
                                        Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("g4", "i4", $"{EmpresaValor}", 10, false, false, Back, Fore));
                                    }
                                    ///////estilos de la celdas
                                    HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                                    HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                                    /////fin estilo de las celdas
                                    //DataTable TableResult = new DataTable(); DataView dt = ((DataTable)dtgconten.DataSource).AsDataView(); TableResult = dt.ToTable();
                                    ///Tabla
                                    decimal SumDebe = 0, SumHaber = 0;
                                    if (Auditoria)
                                    {
                                        TablaResult.Columns["Cod_Asiento_Contable"].ColumnName = "Nº CORRELATIVO";
                                        TablaResult.Columns["FechaContable"].ColumnName = "FECHA DE OPERACIÓN";
                                        TablaResult.Columns["Glosa"].ColumnName = "DESCRIPCIÓN O GLOSA DE LA OPERACIÓN";
                                        TablaResult.Columns["Id_Comprobante"].ColumnName = "COD.DOC.";
                                        TablaResult.Columns["Num_Comprobante"].ColumnName = "NUMERO DE DOCUMENTO";
                                        TablaResult.Columns["Cuenta_Contable"].ColumnName = "CUENTA CONTABLE";
                                        TablaResult.Columns["DESCRIPCION"].ColumnName = "DENOMINACIÓN CUENTA CONTABLE";
                                        TablaResult.Columns["DEBE"].ColumnName = "MOV. DEBE";
                                        TablaResult.Columns["HABER"].ColumnName = "MOV. HABER";
                                        TablaResult.Columns.RemoveAt(22);
                                        TablaResult.Columns.RemoveAt(21);
                                        TablaResult.Columns.RemoveAt(20);
                                        TablaResult.Columns.RemoveAt(17);
                                        TablaResult.Columns.RemoveAt(16);
                                        TablaResult.Columns.RemoveAt(13);
                                        TablaResult.Columns.RemoveAt(12);
                                        TablaResult.Columns.RemoveAt(9);
                                        TablaResult.Columns.RemoveAt(6);
                                        TablaResult.Columns.RemoveAt(5);
                                        TablaResult.Columns.RemoveAt(3);
                                        TablaResult.Columns.RemoveAt(1);
                                        TablaResult.Columns.RemoveAt(0);
                                        //
                                        string cuo = "";
                                        SumDebe = 0; SumHaber = 0;
                                        for (int i = 0; i < TablaResult.Rows.Count; i++)
                                        {
                                            DataRow fila = TablaResult.Rows[i];
                                            SumDebe += (decimal)fila["MOV. DEBE"];
                                            SumHaber += (decimal)fila["MOV. HABER"];
                                            fila["NUMERO DE DOCUMENTO"] = $"{fila["Cod_Comprobante"]}-{fila["NUMERO DE DOCUMENTO"]}";
                                            //
                                            if (fila["Nº CORRELATIVO"].ToString() != cuo)
                                            {
                                                DataRow nueva = TablaResult.NewRow();
                                                TablaResult.Rows.InsertAt(nueva, i);
                                                i++;
                                            }
                                            cuo = fila["Nº CORRELATIVO"].ToString();
                                        }
                                        TablaResult.Columns.RemoveAt(4);
                                    }
                                    else
                                        foreach (DataColumn items in TablaResult.Columns) { items.ColumnName = dtgconten.Columns["x" + items.ColumnName].HeaderText; }

                                    if (Auditoria)
                                    {
                                        DataRow nueva = TablaResult.NewRow();
                                        TablaResult.Rows.Add(nueva);
                                        DataRow nueva1 = TablaResult.NewRow();
                                        nueva1["DENOMINACIÓN CUENTA CONTABLE"] = "Total General";
                                        nueva1["MOV. DEBE"] = SumDebe;
                                        nueva1["MOV. HABER"] = SumHaber;
                                        TablaResult.Rows.Add(nueva1);
                                    }
                                    /////
                                    ////Anterior               
                                    //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", _NombreHoja, Celdas, 5, _Columnas, new int[] { }, new int[] { });
                                    HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(TablaResult, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, contador++, Celdas, 5, _Columnas, new int[] { }, new int[] { 2, 5, 3, 6, 7, 8, 9 }, "");
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
