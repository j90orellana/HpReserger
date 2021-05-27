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
    public partial class frmReporteCostoyDepreciacionActivo : FormGradient
    {
        public frmReporteCostoyDepreciacionActivo()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private int idempresa;
        private void frmReporteCostoyDepreciacionActivo_Load(object sender, EventArgs e)
        {
            CargarEmpresa();
            cbodesde.Fecha(new DateTime(DateTime.Now.Year, 1, 1));
        }
        public void CargarEmpresa()
        {
            CapaLogica.TablaEmpresas(cboempresa);
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void msgError(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        frmProcesando frmproce;
        DataTable TDatos;
        DateTime FechaInicial, FechaFin;
        private string NameEmpresa;
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //VALIDACIONES
            if (cboempresa.SelectedValue == null) { cboempresa.Focus(); msgError("Seleccione una Empresa"); return; }
            //
            if (cbodesde.FechaFinMes > cboA.FechaFinMes)
            {
                FechaFin = cbodesde.FechaFinMes;
                FechaInicial = cboA.FechaInicioMes;
            }
            else
            {
                FechaInicial = cbodesde.FechaInicioMes;
                FechaFin = cboA.FechaFinMes;
            }
            TDatos = CapaLogica.ReporteDepreciacionActivoFijo(idempresa, FechaInicial, FechaFin);
            if (TDatos.Rows.Count == 0)
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
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboempresa.Items.Count > 0)
            {
                if (cboempresa.SelectedValue != null)
                {
                    idempresa = (int)cboempresa.SelectedValue;
                    NameEmpresa = cboempresa.Text;
                }
            }
            else msgError("No hay Empresas");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (TDatos.Rows.Count > 0)
            {
                //DESARROLLO PARA MOSTRAR EL ESQUEMA DEL REPORTE DEL EXCEL
                DateTime FechaTemp = FechaInicial;
                List<string> ListCuentas = new List<string>();
                //AGREGAMOS LAS CUENTAS CONTABLES A UNA LISTA PARA FILTRAR
                foreach (DataRow item in TDatos.Rows)
                {
                    if (!ListCuentas.Contains(item["cuentaactivo"].ToString()))
                        ListCuentas.Add(item["cuentaactivo"].ToString());
                }
                DataView dv = TDatos.AsDataView();
                string Carpeta = folderBrowserDialog1.SelectedPath;
                //
                string EmpresaValor = Configuraciones.ValidarRutaValida(NameEmpresa);
                //string Ruc = CapaLogica.BuscarRucEmpresa(EmpresaValor)[0].ToString();
                string valor = Carpeta + @"\";
                //if (chkCarpetas.Checked)
                //{
                valor = Carpeta + @"\" + EmpresaValor + @"\";
                if (!Directory.Exists(Carpeta + @"\" + EmpresaValor))
                    Directory.CreateDirectory(Carpeta + @"\" + Configuraciones.ValidarRutaValida(EmpresaValor));
                //}
                string NameFile = "";
                if (FechaInicial.Month == FechaFin.Month && FechaInicial.Year == FechaFin.Year)
                    NameFile = valor + $"RP-AF {EmpresaValor} {FechaInicial.ToString("MMM-yyyy").ToUpper()}.xlsx";
                else
                    NameFile = valor + $"RP-AF {EmpresaValor} {FechaInicial.ToString("MMM-yyyy").ToUpper()}-{FechaFin.ToString("MMM-yyyy").ToUpper()}.xlsx";
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
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(BackAlterno, Configuraciones.FuenteReportesTahoma10, ForeAlterno);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(BackColumna, Configuraciones.FuenteReportesTahoma10, ForeColumna);
                //RECORREMOS EL RANGO DE PERIODOS QUE SE INGRESO
                while (FechaTemp < FechaFin)
                {
                    i = 0;
                    DateTime FechaTempFinMes = Configuraciones.FinDelMes(FechaTemp);
                    Hoja++;
                    String _NombreHoja = $"{FechaTemp.ToString("MMMM yy")}";
                    List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{1 + i}", $"R{1 + i}", EmpresaValor, 12, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{3 + i}", $"R{3 + i}", "DETALLE DE ACTIVO FIJO", 9, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{4 + i}", $"R{4 + i}", ($"COSTO Y DEPRECIACIÓN ACUMULADA AL {FechaTempFinMes.ToString("dd 'DE' MMMM yyyy")}").ToUpper(), 9, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));

                    foreach (string NroCuentas in ListCuentas)
                    {
                        //i = 0;
                        //CABECERA DEL EXCEL
                        string cadena = $" cuentaactivo= '{NroCuentas}' and fechacontable ='{FechaTempFinMes}'";
                        dv.RowFilter = cadena;
                        DataTable TablaResult = dv.ToTable();
                        if (TablaResult.Rows.Count > 0)
                        {
                            DataRow Fila = TablaResult.Rows[0];
                            //CABECERAS
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{7 + i}", $"A{7 + i}", "Fecha Activ.", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{7 + i}", $"B{7 + i}", "Fecha Doc.", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{7 + i}", $"C{7 + i}", "Código Act.", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{7 + i}", $"D{7 + i}", "Asiento", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{7 + i}", $"E{7 + i}", "Descripción", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"F{7 + i}", $"F{7 + i}", "Activo Histórico", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"G{7 + i}", $"G{7 + i}", $"Total Depre. Acum.{FechaTemp.Year - 1}", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"H{7 + i}", $"H{7 + i}", $"Neto {FechaTemp.Year - 1} Ségun Balance", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"I{7 + i}", $"I{7 + i}", "% Tasa", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"J{7 + i}", $"J{7 + i}", "Meses", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"K{7 + i}", $"K{7 + i}", "Alta Activo", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"L{7 + i}", $"L{7 + i}", $"Total Activo {FechaTemp.ToString("MMM yy")}", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"M{7 + i}", $"M{7 + i}", $"Gasto Deprec. {FechaTemp.Year}", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"N{7 + i}", $"N{7 + i}", $"Deprec. Acumul.", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"O{7 + i}", $"O{7 + i}", $"Activo Fijo Neto {FechaTemp.ToString("MMM yy")}", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"P{7 + i}", $"P{7 + i}", $"Deprec. Acumul PER Anteri.", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"Q{7 + i}", $"Q{7 + i}", $"Deprec. Periodo Mes", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"R{7 + i}", $"R{7 + i}", $"Asiento Deprec.", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            //
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{8 + i}", $"E{8 + i}", $"{Fila["cuenta_contable"].ToString()}", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Red, Configuraciones.FuenteReportesTahoma10, true));
                            Boolean Mostrar = false;
                            decimal Svaloractivo = 0;
                            decimal SDeprecAcumuladaAnioPas = 0;
                            decimal SActivoNetoPas = 0;
                            decimal Saltaactivo = 0;
                            decimal Stotalactivo = 0;
                            decimal SGastoDepreciacion = 0;
                            decimal SDepreciacionAcumulada = 0;
                            decimal STotalActivoNeto = 0;
                            decimal SDeprecAcumuladaAnteriorPER = 0;
                            decimal Svcontable = 0;
                            foreach (DataRow item in TablaResult.Rows)
                            {
                                Mostrar = true;
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{9 + i}", $"A{9 + i}", $"{((DateTime)item["fechaactivacion"]).ToString("d")}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{9 + i}", $"B{9 + i}", $"{((DateTime)item["fechadoc"]).ToString("d")}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{9 + i}", $"C{9 + i}", $"{item["cod"].ToString()}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{9 + i}", $"D{9 + i}", $"{item["cuoactivo"].ToString()}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{9 + i}", $"E{9 + i}", $"{item["Descripcion"].ToString()}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"F{9 + i}", $"F{9 + i}", (decimal)item["valoractivo"], 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"G{9 + i}", $"G{9 + i}", -(decimal)item["DeprecAcumuladaAnioPas"], 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Red, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"H{9 + i}", $"H{9 + i}", (decimal)item["ActivoNetoPas"], 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"I{9 + i}", $"I{9 + i}", $"{item["tasa"]}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"J{9 + i}", $"J{9 + i}", (int)item["mes"], 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"K{9 + i}", $"K{9 + i}", (decimal)item["altaactivo"], 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"L{9 + i}", $"L{9 + i}", (decimal)item["totalactivo"], 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"M{9 + i}", $"M{9 + i}", -(decimal)item["GastoDepreciacion"], 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Red, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"N{9 + i}", $"N{9 + i}", -(decimal)item["DepreciacionAcumulada"], 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Red, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"O{9 + i}", $"O{9 + i}", (decimal)item["TotalActivoNeto"], 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"P{9 + i}", $"P{9 + i}", -(decimal)item["DeprecAcumuladaAnteriorPER"], 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Red, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"Q{9 + i}", $"Q{9 + i}", -(decimal)item["vcontable"], 8, false, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Red, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"R{9 + i}", $"R{9 + i}", $"{item["CuoDeprec"].ToString()}", 8, false, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));

                                //
                                Svaloractivo += (decimal)item["valoractivo"];
                                SDeprecAcumuladaAnioPas += -(decimal)item["DeprecAcumuladaAnioPas"];
                                SActivoNetoPas += (decimal)item["ActivoNetoPas"];
                                Saltaactivo += (decimal)item["altaactivo"];
                                Stotalactivo += (decimal)item["totalactivo"];
                                SGastoDepreciacion += -(decimal)item["GastoDepreciacion"];
                                SDepreciacionAcumulada += -(decimal)item["DepreciacionAcumulada"];
                                STotalActivoNeto += (decimal)item["TotalActivoNeto"];
                                SDeprecAcumuladaAnteriorPER += -(decimal)item["DeprecAcumuladaAnteriorPER"];
                                Svcontable += -(decimal)item["vcontable"];

                                i++;
                            }
                            if (Mostrar)//MOSTRAMOS SUBTOTALES
                            {
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"F{10 + i}", $"F{10 + i}", Svaloractivo, 8, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"G{10 + i}", $"G{10 + i}", SDeprecAcumuladaAnioPas, 8, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Red, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"H{10 + i}", $"H{10 + i}", SActivoNetoPas, 8, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"K{10 + i}", $"K{10 + i}", Saltaactivo, 8, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"L{10 + i}", $"L{10 + i}", Stotalactivo, 8, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"M{10 + i}", $"M{10 + i}", SGastoDepreciacion, 8, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Red, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"N{10 + i}", $"N{10 + i}", SDepreciacionAcumulada, 8, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Red, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"O{10 + i}", $"O{10 + i}", STotalActivoNeto, 8, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"P{10 + i}", $"P{10 + i}", SDeprecAcumuladaAnteriorPER, 8, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Red, Configuraciones.FuenteReportesTahoma10, true));
                                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"Q{10 + i}", $"Q{10 + i}", Svcontable, 8, true, false, HPResergerFunciones.Utilitarios.Alineado.derecha, Color.White, Color.Red, Configuraciones.FuenteReportesTahoma10, true));

                            }

                            i += 6;
                        }
                        else //EL CASO DE QUE NO HAY DATA
                        {
                            i = 0;
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{7 + i}", $"A{7 + i}", "Fecha Activ.", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"B{7 + i}", $"B{7 + i}", "Fecha Doc.", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"C{7 + i}", $"C{7 + i}", "Código Act.", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"D{7 + i}", $"D{7 + i}", "Asiento", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"E{7 + i}", $"E{7 + i}", "Descripción", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"F{7 + i}", $"F{7 + i}", "Activo Histórico", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"G{7 + i}", $"G{7 + i}", $"Total Depre. Acum.{FechaTemp.Year - 1}", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"H{7 + i}", $"H{7 + i}", $"Neto {FechaTemp.Year - 1} Ségun Balance", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"I{7 + i}", $"I{7 + i}", "% Tasa", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"J{7 + i}", $"J{7 + i}", "Meses", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"K{7 + i}", $"K{7 + i}", "Alta Activo", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"L{7 + i}", $"L{7 + i}", $"Total Activo {FechaTemp.ToString("MMM yy")}", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"M{7 + i}", $"M{7 + i}", $"Gasto Deprec. {FechaTemp.Year}", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"N{7 + i}", $"N{7 + i}", $"Deprec. Acumul.", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"O{7 + i}", $"O{7 + i}", $"Activo Fijo Neto {FechaTemp.ToString("MMM yy")}", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"P{7 + i}", $"P{7 + i}", $"Deprec. Acumul PER Anteri.", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"Q{7 + i}", $"Q{7 + i}", $"Deprec. Periodo Mes", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));
                            Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"R{7 + i}", $"R{7 + i}", $"Asiento Deprec.", 8, true, false, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true, true));

                        }


                    }
                    HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(null, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, Hoja, Celdas, 7, new int[] { }, new int[] { },
                      new int[] { 1, 2, 3, 4, 5 }, "", false);
                    //Agregamos un MES  
                    FechaTemp = FechaTemp.AddMonths(1);
                }
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

