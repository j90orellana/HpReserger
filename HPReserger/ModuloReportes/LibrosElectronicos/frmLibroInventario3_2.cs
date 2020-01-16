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
    public partial class frmLibroInventario3_2 : FormGradient
    {
        public frmLibroInventario3_2()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private string NombreEmpresa;
        private DateTime FechaInicial;
        private DateTime FechaFinal;
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        DataTable TablaEmpresa;
        private bool Ordenado = false;
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
        private void frmLibroInventario3_2_Load(object sender, EventArgs e)
        {
            cargarEmpresa();
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();
            Cursor = Cursors.WaitCursor;
            if (chklist.CheckedItems.Count == 0) msg("Seleccione una Empresa");
            DateTime FechaAuxiliar;
            string ListadoEmpresas = "";
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
            //
            TDatos = CapaLogica.FormatoLibroInventario3_2(ListadoEmpresas, FechaInicial, FechaFinal);
            dtgconten.DataSource = TDatos;
            //
            lblmensaje.Text = $"Total de Registros: {dtgconten.RowCount}";
            if (dtgconten.RowCount == 0) msg("No Hay Registros");
            Cursor = Cursors.Default;
            Ordenado = false;
        }
        frmProcesando frmproce;
        DataTable TDatos;
        private string nameEmpresa;

        public void CerrarPanelTxt()
        {
            PanelTxt.Visible = false;
        }

        private void dtgconten_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgconten.Columns[xNroCuenta.Name].Index)
                {
                    if (dtgconten[xNroCuenta.Name, e.RowIndex].Value.ToString() == "Sin Nro Cuenta")
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaError(dtgconten[e.ColumnIndex, e.RowIndex]);
                    }
                    else
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(dtgconten[e.ColumnIndex, e.RowIndex]);
                }
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();
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
                msg("No hay Datos que Exportar");
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
                    ListadoFecha.Add(FechaInicial.ToString("yyyyMM01"));
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
                        string NameFile = valor + $"3.2 LIBRO DE INVENTARIOS Y BALANCES {EmpresaValor}.xlsx";
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
                                if (dtgconten.RowCount > 0)
                                {
                                    string _NombreHoja = ""; string _Cabecera = ""; int[] _OrdenarColumnas; string _NColumna = "";
                                    _NombreHoja = $"{fechas}"; _Cabecera = "3.2 LIBRO DE INVENTARIOS Y BALANCES - DETALLE DEL SALDO DE LA CUENTA 10 EFECTIVO Y EQUIVALENTES DE EFECTIVO (PCGE)";
                                    _OrdenarColumnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
                                    _NColumna = "m";
                                    List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                                    //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                                    Color Back = Color.FromArgb(78, 129, 189);
                                    Color Fore = Color.FromArgb(255, 255, 255);
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "i1", _Cabecera.ToUpper(), 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "PERIODO:", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", $"{fechas}", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", "Ruc:", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", "c3", $"{Ruc}", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", "f4", "APELLIDOS Y NOMBRES, DENOMINACIÓN O RAZÓN SOCIAL:", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("g4", "i4", $"{EmpresaValor}", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                    ///////estilos de la celdas
                                    HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, Configuraciones.FuenteReportesTahoma8, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                                    HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, Configuraciones.FuenteReportesTahoma8, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                                    /////fin estilo de las celdas
                                    //Tabla Datos
                                    DataTable TablaExportar = new DataTable();
                                    TablaExportar = ((DataTable)dtgconten.DataSource).Copy();
                                    /////
                                    ////Anterior               
                                    //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", _NombreHoja, Celdas, 5, _Columnas, new int[] { }, new int[] { });
                                    HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(TablaResult, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, contador++, Celdas, 5, _OrdenarColumnas, new int[] { }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "");
                                    // HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(TablaResult, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, contador++, Celdas, 5, _OrdenarColumnas, new int[] { }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "");
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
                    msg("Cancelado por el Usuario");
                    return;
                }
            }
            FechaInicial = cboperiodode.FechaInicioMes;
            List<string> ListadoFecha = new List<string>();
            while (FechaInicial < FechaFinal)
            {
                ListadoFecha.Add(FechaInicial.ToString("yyyyMM01"));
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
                                dvf.RowFilter = $"periodo like '{fechas}'";
                                DataTable TablaResult = dvf.ToTable();
                                string añio = fechas.Substring(0, 4);
                                string mes = fechas.Substring(4, 2);
                                //Sí no hay datos 8.1 Vacio
                                if (TablaResult.Rows.Count == 0)
                                {
                                    SaveFile.FileName = $"{valor}LE{Ruc}{añio}{mes}0103020071{0}11.txt";
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
                                    string[] campo = new string[9];
                                    string cadenatxt = "";            //int ValorPrueba = 0;
                                    foreach (DataRow item in TablaResult.Rows)
                                    {
                                        //ValorPrueba = 0;
                                        int c = 0;
                                        //1
                                        campo[c++] = item[xperiodo.DataPropertyName].ToString().Trim();
                                        campo[c++] = Configuraciones.CadenaDelimitada(item[xCuentaContable.DataPropertyName].ToString().Trim(), 24);
                                        int Valor; int.TryParse(item[xCodigoEntidad.DataPropertyName].ToString(), out Valor);
                                        campo[c++] = Valor.ToString("00");
                                        campo[c++] = Valor == 99 ? "-" : Configuraciones.CadenaDelimitada(item[xNroCuenta.DataPropertyName].ToString().Trim(), 30);
                                        campo[c++] = item[xMoneda.DataPropertyName].ToString().Trim();
                                        //debe y haber
                                        campo[c++] = ((decimal)item[xParteDeudora.DataPropertyName]).ToString("0.00");
                                        campo[c++] = ((decimal)item[xParteAcreedora.DataPropertyName]).ToString("0.00");
                                        //
                                        campo[c++] = ((int)item[xEstado.DataPropertyName]).ToString();
                                        //
                                        //Uniendo por pipes
                                        cadenatxt += string.Join("|", campo) + $"{Environment.NewLine }";
                                        //Limpiamos el Campo
                                        //campo = null;
                                    }
                                    //Formato 1.1
                                    SaveFile.FileName = $"{valor}LE{Ruc}{añio}{mes}01030200071{1}11.txt";
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
        int[] Valores = { 1, 8, 9 };
        private void dtgconten_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int x = e.RowIndex;
            int y = e.ColumnIndex;
            if (x >= 0 && y == dtgconten.Columns[xEstado.Name].Index)
            {
                int Valor = 0;
                int.TryParse(e.FormattedValue.ToString(), out Valor);
                if (!Valores.Contains(Valor))
                {
                    e.Cancel = true;
                    msg("Ingresó un valor Invalido, Solo Ingrese: 1, 8, 9");
                }
            }
        }
    }
}
