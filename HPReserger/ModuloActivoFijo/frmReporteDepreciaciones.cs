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

namespace HPReserger.ModuloActivoFijo
{
    public partial class frmReporteDepreciaciones : FormGradient
    {
        public frmReporteDepreciaciones()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void msgError(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        frmProcesando frmproce;

        DataTable TDatosR;
        DataTable TDatosD;

        public DateTime FechaInicial { get; private set; }
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            FechaInicial = cbodesde.FechaFinMes;
            TDatosD = CapaLogica.ActivoFijos_Saldos(FechaInicial);
            TDatosR = CapaLogica.ActivoFijos_SaldosResumen(FechaInicial);
            if (TDatosD.Rows.Count == 0)
            {
                msgError("No hay Registros para Mostrar");
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                backgroundWorker1.WorkerSupportsCancellation = true;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.Default;
                    frmproce = new HPReserger.frmProcesando();
                    frmproce.Show();
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
                else
                {
                    Cursor = Cursors.Default;
                    return;
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (TDatosD.Rows.Count > 0)
            {
                ////DESARROLLO PARA MOSTRAR EL ESQUEMA DEL REPORTE DEL EXCEL
                //DateTime FechaTemp = FechaInicial;
                //List<string> ListCuentas = new List<string>();
                ////AGREGAMOS LAS CUENTAS CONTABLES A UNA LISTA PARA FILTRAR
                //foreach (DataRow item in TDatos.Rows)
                //{
                //    if (!ListCuentas.Contains(item["cuentaactivo"].ToString()))
                //        ListCuentas.Add(item["cuentaactivo"].ToString());
                //}
                DataView dv = TDatosD.AsDataView();
                string Carpeta = folderBrowserDialog1.SelectedPath;
                //
                string EmpresaValor = "";
                //string Ruc = CapaLogica.BuscarRucEmpresa(EmpresaValor)[0].ToString();
                string valor = Carpeta + @"\";
                //if (chkCarpetas.Checked)
                //{
                valor = Carpeta + @"\" + EmpresaValor + @"\";
                if (!Directory.Exists(Carpeta + @"\" + EmpresaValor))
                    Directory.CreateDirectory(Carpeta + @"\" + Configuraciones.ValidarRutaValida(EmpresaValor));
                //}
                string NameFile = "";
                NameFile = valor + $"RP-AF-Con  {EmpresaValor} {FechaInicial.ToString("MMM-yyyy").ToUpper()}.xlsx";
                //ELiminamos el Excel Antiguo
                File.Delete(NameFile);
                File.Exists(NameFile);
                //DEFINICIONES
                int i = 0; //posicion de la hoja no  es index
                int Hoja = 0;
                Color BackAlterno = Color.FromArgb(220, 230, 241);
                Color ForeAlterno = Color.Black;
                Color BackColumna = Color.FromArgb(78, 129, 189);
                Color ForeColumna = Color.White;
                //
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(BackAlterno, Configuraciones.FuenteReportesTahoma8, ForeAlterno);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(BackColumna, Configuraciones.FuenteReportesTahoma8, ForeColumna);
                //PRIMERA HOJA RESUMEN
                Hoja++;
                String _NombreHoja = $"Resumen";
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{2 + i}", $"j{2 + i}", $"Saldo al {FechaInicial.ToShortDateString()}", 9, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{3 + i}", $"j{3 + i}", "Activos e Intangibles", 9, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));


                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(TDatosR, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, Hoja, Celdas, 5, new int[] { }, new int[] { },
                  new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "", true);

                Hoja++;
                _NombreHoja = "Detalle";
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(TDatosD, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, Hoja, null, 5, new int[] { }, new int[] { },
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41 }, "", true);

                msgOK($"Archivo Grabados en \n{folderBrowserDialog1.SelectedPath}");
                if (backgroundWorker1.IsBusy) backgroundWorker1.CancelAsync();
            }
            else msgError("No hay Registros en la Grilla");
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
        }
    }
}
