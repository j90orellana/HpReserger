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

namespace HPReserger.ModuloReportes
{
    public partial class frmReporteDocumentosImpagos : FormGradient
    {
        public frmReporteDocumentosImpagos()
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
        private void frmReporteDocumentosImpagos_Load(object sender, EventArgs e)
        {
            dtpfechaini.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfechafin.Value = new DateTime(DateTime.Now.Year, 12, 31);
            cargarEmpresa();
            dtgPorPagar.BringToFront();
        }
        private void rbPorPagar_CheckedChanged(object sender, EventArgs e)
        {
            dtgPorPagar.BringToFront();
            lblmensaje.Text = $"Total Registros: {dtgPorPagar.RowCount}";
            TDatos = (DataTable)dtgPorPagar.DataSource ?? new DataTable();            
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
        DataTable TDatos;
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (chklist.CheckedItems.Count == 0) msg("Seleccione una Empresa");
            DateTime FechaAuxiliar;
            string ListadoEmpresas = "";
            if (dtpfechaini.Value > dtpfechafin.Value)
            {
                FechaAuxiliar = dtpfechaini.Value;
                dtpfechaini.Value = dtpfechafin.Value;
                dtpfechafin.Value = FechaAuxiliar;
            }
            FechaInicial = dtpfechaini.Value;
            FechaFinal = dtpfechafin.Value;
            foreach (string item in chklist.CheckedItems)
            {
                if (item.ToString() != "TODAS")
                    ListadoEmpresas += CapaLogica.BuscarRucEmpresa(item)[1].ToString() + ",";
            }
            ListadoEmpresas = ListadoEmpresas.Substring(0, ListadoEmpresas.Length - 1);
            //
            if (rbPorPagar.Checked)
            {
                rbPorPagar.BringToFront();
                TDatos = CapaLogica.ReporteDocumentosRegistradoSinPago(ListadoEmpresas, FechaInicial, FechaFinal);
                dtgPorPagar.DataSource = TDatos;
                lblmensaje.Text = $"Total de Registros: {dtgPorPagar.RowCount}";
                if (dtgPorPagar.RowCount == 0) msg("No Hay Registros");
            }
            else if (rbPagados.Checked)
            {
                rbPorPagar.BringToFront();
                TDatos = CapaLogica.ReporteDocumentosPagadosEXcluidosRegistrados(ListadoEmpresas, FechaInicial, FechaFinal);
                dtgPagados.DataSource = TDatos;
                lblmensaje.Text = $"Total de Registros: {dtgPagados.RowCount}";
                if (dtgPagados.RowCount == 0) msg("No Hay Registros");
            }
            Cursor = Cursors.Default;
        }
        frmProcesando frmproce;
        private void btnexcel_Click(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerSupportsCancellation = true;
            if (rbPorPagar.Checked)
            {
                if (dtgPorPagar.RowCount > 0)
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
            else if (rbPagados.Checked)
            {
                if (dtgPagados.RowCount > 0)
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
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if ((rbPorPagar.Checked && dtgPorPagar.RowCount > 0) || (rbPagados.Checked && dtgPagados.RowCount > 0))

            {
                //DateTime FechaInicial = dtpfechaini.Value;
                //List<string> ListadoFecha = new List<string>();
                //while (FechaInicial < FechaFinal)
                //{
                //    ListadoFecha.Add(FechaInicial.ToString("yyyyMM01"));
                //    FechaInicial = FechaInicial.AddMonths(1);
                //}
                foreach (var item in chklist.CheckedItems)
                {
                    //EMPRESAS
                    if (item.ToString() != "TODAS")
                    {
                        string Carpeta = folderBrowserDialog1.SelectedPath;
                        string EmpresaValor = item.ToString().ToUpper();
                        string Ruc = CapaLogica.BuscarRucEmpresa(EmpresaValor)[0].ToString();
                        string valor = Carpeta + @"\";
                        //if (chkCarpetas.Checked)
                        //{
                        valor = Carpeta + @"\" + Configuraciones.ValidarRutaValida(EmpresaValor) + @"\";
                        if (!Directory.Exists(Carpeta + @"\" + EmpresaValor))
                            Directory.CreateDirectory(Carpeta + @"\" + Configuraciones.ValidarRutaValida(EmpresaValor));
                        //}
                        string NameFile = "";
                        if (rbPorPagar.Checked)
                            NameFile = valor + $"DOCUMENTOS IMPAGOS - {EmpresaValor}.xlsx";
                        else
                            NameFile = valor + $"DOCUMENTOS PAGADOS-ABONADOS - {EmpresaValor}.xlsx";
                        //ELiminamos el Excel Antiguo

                        File.Delete(NameFile);
                        File.Exists(NameFile);
                        if (item.ToString() != "TODAS")
                        {
                            DataView dv = TDatos.Copy().AsDataView();
                            dv.RowFilter = $"empresa like '{EmpresaValor}'";
                            //POR PERIODOS
                            int contador = 1;
                            //posicion de la hoja no  es index
                            //foreach (string fechas in ListadoFecha)
                            //{
                            DataView dvf = new DataView(dv.ToTable());
                            DataTable TablaResult = dvf.ToTable();
                            //string añio = fechas.Substring(0, 4);
                            //string mes = fechas.Substring(4, 2);
                            //Sí no hay datos
                            if ((rbPorPagar.Checked && dtgPorPagar.RowCount > 0) || (rbPagados.Checked && dtgPagados.RowCount > 0))
                            {
                                string _NombreHoja = ""; string _Cabecera = ""; string _NColumna = "";
                                _NombreHoja = $"LISTADO DOCUMENTOS";
                                if (rbPorPagar.Checked)
                                {
                                    _Cabecera = "DOCUMENTOS IMPAGOS";
                                }
                                else
                                {
                                    _Cabecera = "DOCUMENTOS PAGADOS-ABONADOS";
                                }
                                //  
                                _NColumna = "m";
                                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                                //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                                Color Back = Color.FromArgb(78, 129, 189);
                                Color Fore = Color.FromArgb(255, 255, 255);
                                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "i1", _Cabecera.ToUpper(), 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "Periodo:", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", $"{FechaInicial.ToShortDateString()} - {FechaFinal.ToShortDateString()}", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", "Ruc:", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", "c3", $"{Ruc}", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", "f4", "Razon Social:", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("g4", "i4", $"{EmpresaValor}", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));

                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "m1", _Cabecera.ToUpper(), 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "PERIODO", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", $"{FechaInicial.ToShortDateString()} - {FechaFinal.ToShortDateString()}", 8, true, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", $"RUC:", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                ////ACTIVAR CODIGO RUC
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", "g3", $"{Ruc}", 8, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", "b4", $"RAZON SOCIAL DE LA EMPRESA:", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("c4", "m4", $"{EmpresaValor}", 8, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));



                                ///////estilos de la celdas
                                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgPorPagar.AlternatingRowsDefaultCellStyle.BackColor, Configuraciones.FuenteReportesTahoma8, dtgPorPagar.AlternatingRowsDefaultCellStyle.ForeColor);
                                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgPorPagar.ColumnHeadersDefaultCellStyle.BackColor, Configuraciones.FuenteReportesTahoma8, dtgPorPagar.ColumnHeadersDefaultCellStyle.ForeColor);
                                /////fin estilo de las celdas
                                //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", _NombreHoja, Celdas, 5, _Columnas, new int[] { }, new int[] { });
                                if (rbPorPagar.Checked)
                                    HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(TablaResult, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, contador++, Celdas, 5, new int[] { }, new int[] { }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, "");
                                else HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(TablaResult, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, contador++, Celdas, 5, new int[] { }, new int[] { }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, "");
                                // HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(TablaResult, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, contador++, Celdas, 5, _OrdenarColumnas, new int[] { }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "");
                            }
                            //}
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
        }

        private void rbPagados_CheckedChanged(object sender, EventArgs e)
        {
            dtgPagados.BringToFront();
            lblmensaje.Text = $"Total Registros: {dtgPagados.RowCount}";
            TDatos = (DataTable)dtgPagados.DataSource ?? new DataTable();
        }
    }
}
