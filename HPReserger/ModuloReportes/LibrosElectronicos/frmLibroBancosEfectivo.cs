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

        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
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
            if (Configuraciones.ValidarSQLInyect(txtbuscuentas)) { msg("Codigo Malicioso Detectado"); return; }
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
            if (dtgconten.RowCount == 0) msg("No Hay Registros");
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
                        string NameFile = valor + $"{Cadenax.ToUpper()} 1.1 LIBRO CAJA Y BANCOS {EmpresaValor}.xlsx";
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
                                dvf.RowFilter = $"periodo like '{fechas}00'";
                                DataTable TablaResult = dvf.ToTable();
                                string añio = fechas.Substring(0, 4);
                                string mes = fechas.Substring(4, 2);
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
                                    Color Back = Color.FromArgb(78, 129, 189);
                                    Color Fore = Color.FromArgb(255, 255, 255);
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "n1", _Cabecera.ToUpper(), 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "PERIODO:", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", $"{fechas} {FechaInicial.Month.ToString("00")}", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", "Ruc:", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", "c3", $"{Ruc}", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", "g4", "APELLIDOS Y NOMBRES, DENOMINACIÓN O RAZÓN SOCIAL:", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("h4", "n4", $"{EmpresaValor}", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
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
                    msg("Cancelado por el Usuario");
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
    }
}
