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
    public partial class frmRegistroVentas : FormGradient
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
                        //ELiminamos el Excel Antiguo
                        string NameFile = valor + $"REGISTRO DE VENTAS {EmpresaValor}.xlsx";
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
                                    string[] campo = new string[35];
                                    string cadenatxt = "";
                                    int ValorPrueba = 0;
                                    foreach (DataRow fila in TablaResult.Rows)
                                    {
                                        ValorPrueba = 0;
                                        int c = 0;
                                        //1
                                        campo[c++] = $"{añio}{mes}00";
                                        campo[c++] = (int.Parse(fila[xix.DataPropertyName].ToString())).ToString("000");
                                        campo[c++] = $"M{int.Parse(fila[xix.DataPropertyName].ToString())}";
                                        campo[c++] = ((DateTime)fila[xFechaEmision.DataPropertyName]).ToString("dd/MM/yyyy");
                                        campo[c++] = "01/01/0001";
                                        campo[c++] = ((int)fila[xidC.DataPropertyName]).ToString("00");
                                        campo[c++] = fila[xSerieCom.DataPropertyName].ToString().Trim();
                                        campo[c++] = fila[xNumCom.DataPropertyName].ToString().Trim();
                                        //En caso de optar por anotar el importe total de las operaciones realizadas diariamente, registrar el número final. 
                                        campo[c++] = "";
                                        //10
                                        campo[c++] = (int.Parse(fila[xTipoIdPro.DataPropertyName].ToString())).ToString();
                                        campo[c++] = fila[xNumpro.DataPropertyName].ToString() == "" ? "-" : fila[xNumpro.DataPropertyName].ToString().Trim();
                                        string Cadena = fila[xNombrePro.DataPropertyName].ToString().ToUpper().Trim();
                                        campo[c++] = Cadena.Substring(0, Cadena.Length > 60 ? 60 : Cadena.Length);
                                        //Parte de los IGV
                                        campo[c++] = ((decimal)fila[xImportacion.DataPropertyName]).ToString("0.00");
                                        campo[c++] = ((decimal)fila[ximporteIGV.DataPropertyName]).ToString("0.00");
                                        //Descuento Base Imponible
                                        campo[c++] = "0";
                                        campo[c++] = ((decimal)fila[xIGVyoIPM.DataPropertyName]).ToString("0.00");
                                        //Descuento del Igv
                                        campo[c++] = "0";
                                        campo[c++] = ((decimal)fila[xExonerado.DataPropertyName]).ToString("0.00");
                                        //Partes de los GNG
                                        campo[c++] = ((decimal)fila[ximporteNGR.DataPropertyName]).ToString("0.00");
                                        //20
                                        campo[c++] = ((decimal)fila[xisc.DataPropertyName]).ToString("0.00");
                                        //IVAP = Arroz Pilado y su Impuesto
                                        campo[c++] = "0";
                                        campo[c++] = "0";
                                        //Otros Conceptos
                                        campo[c++] = ((decimal)fila[xOtrosTributos.DataPropertyName]).ToString("0.00");
                                        //Validar Moneda
                                        campo[c++] = ((decimal)fila[xImporteTotal.DataPropertyName]).ToString("0.00");
                                        if (fila[xMoneda.DataPropertyName].ToString() == "USD")
                                        {
                                            campo[c++] = "USD";
                                            campo[c++] = ((decimal)fila[xTC.DataPropertyName]).ToString("0.000");
                                        }
                                        else
                                        {
                                            campo[c++] = "PEN";
                                            campo[c++] = ((decimal)fila[xTC.DataPropertyName]).ToString("0.000");
                                        }
                                        campo[c++] = fila[xFechaDocRef.DataPropertyName].ToString() == "" ? "01/01/0001" : ((DateTime)fila[xFechaDocRef.DataPropertyName]).ToString("dd/MM/yyyy");
                                        int.TryParse(fila[xTipoDocRef.DataPropertyName].ToString(), out ValorPrueba);
                                        campo[c++] = ValorPrueba > 0 ? ValorPrueba.ToString("00") : "";
                                        //Datos del Documento que Modifica
                                        campo[c++] = fila[xSerieDocRef.DataPropertyName].ToString() == "" ? "" : fila[xSerieDocRef.DataPropertyName].ToString().Trim();
                                        //30
                                        campo[c++] = fila[xNumDocRef.DataPropertyName].ToString() == "" ? "" : fila[xNumDocRef.DataPropertyName].ToString().Trim();
                                        //Indica el estado del comprobante de pago y a la incidencia en la base imponible  en relación al periodo tributario correspondiente
                                        //1. Obligatorio
                                        //2.Registrar '1' cuando la operación(ventas gravadas, exoneradas, inafectas y / o exportaciones) corresponde al periodo, así como a las Notas de Crédito y Débito emitidas en el periodo.
                                        //3.Registrar '2' cuando el documento ha sido inutilizado durante el periodo previamente a ser entregado, emitido o durante su emisión.
                                        //4.Registrar '8' cuando la operación(ventas gravadas, exoneradas, inafectas y / o exportaciones) corresponde a un periodo anterior y NO ha sido anotada en dicho periodo.
                                        //5.Registrar '9' cuando la operación(ventas gravadas, exoneradas, inafectas y / o exportaciones) corresponde a un periodo anterior y SI ha sido anotada en dicho periodo.
                                        campo[c++] = "";
                                        campo[c++] = "";
                                        campo[c++] = "";
                                        //CampoFinal
                                        //Validacion del Identificador de Estado!
                                        int Estado = 0;
                                        DateTime FechaDeclara = new DateTime(int.Parse(añio), int.Parse(mes), 1);
                                        DateTime FechaEmision = (DateTime)fila[xFechaEmision.DataPropertyName];
                                        //Mismo Mes de Declaración
                                        if (FechaDeclara.Month == FechaEmision.Month && FechaEmision.Year == FechaDeclara.Year)
                                        {
                                            if (((decimal)fila[ximporteNGR.DataPropertyName]) > 0)
                                                Estado = 1;
                                            else
                                                Estado = 1;
                                        }
                                        else
                                        {
                                            //Calculamos la diferencia para ver cuantos meses pasaron
                                            int anio = FechaDeclara.Year - FechaEmision.Year;
                                            int meses = (FechaDeclara.Month + (anio * 12)) - FechaEmision.Month;
                                            if (meses < 120)
                                                Estado = 8;
                                            else Estado = 7;
                                        }
                                        //Columna Final
                                        campo[c++] = Estado.ToString();
                                        //Uniendo por pipes
                                        cadenatxt += string.Join("|", campo) + $"{Environment.NewLine }";
                                        //Limpiamos el Campo
                                        //campo = null;
                                    }
                                    //Formato 14.1
                                    SaveFile.FileName = $"{valor}LE{Ruc}{añio}{mes}00140100001{1}11.txt";
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
    }
}
