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
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using HpResergerUserControls;

namespace HPReserger
{
    public partial class frmreporteempleado : HpResergerUserControls.FormGradient
    {
        public frmreporteempleado()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        DateTime fechainicio, fechafin;
        private void frmreporteempleado_Load(object sender, EventArgs e)
        {
            CargarTipoDocumento();
            CargarTipoContratacion();
            LimpiarControles();
            Cargado = true;
            FiltrarDatos();
        }
        public void msgE(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        private void CargarTipoContratacion()
        {
            TContratacion = CapaLogica.getCargoTipoContratacion("Id_TipoContratacion", "TipoContratacion", "TBL_TipoContratacion");//codigo -valor
            DataRow fila = TContratacion.NewRow();
            fila["codigo"] = 0; fila["descripcion"] = "TODOS";
            TContratacion.Rows.InsertAt(fila, 0);
            //
            string cadena = cboTipoContrato.Text;
            if (TContratacion.Rows.Count != cboTipoContrato.Items.Count)
            {
                cboTipoContrato.ValueMember = "codigo";
                cboTipoContrato.DisplayMember = "descripcion";
                cboTipoContrato.DataSource = TContratacion;
                if (cboTipoContrato.DataSource != null) cboTipoContrato.Text = cadena;
            }
        }
        System.Data.DataTable TTipos;
        System.Data.DataTable TContratacion;
        private void CargarTipoDocumento()
        {
            TTipos = CapaLogica.TiposID();//codigo -valor
            DataRow fila = TTipos.NewRow();
            fila["codigo"] = 0; fila["Valor"] = "TODOS";
            TTipos.Rows.InsertAt(fila, 0);
            //
            string cadena = cboTipodoc.Text;
            if (TTipos.Rows.Count != cboTipodoc.Items.Count)
            {
                cboTipodoc.ValueMember = "codigo";
                cboTipodoc.DisplayMember = "valor";
                cboTipodoc.DataSource = TTipos;
                if (cboTipodoc.DataSource != null) cboTipodoc.Text = cadena;
            }
        }
        int banco = 0;
        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int sueldo = 0;
        decimal minimo = 0.00m;
        decimal maximo = 1000.00m;

        decimal aux;
        int dni, carnet, pasa, cedula, ruc = 0;
        int practicas, planillaempleado, planillaobrero, recibohono = 0;
        int opciones = 0;
        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonPer1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnexportarplano_Click(object sender, EventArgs e)
        {
            StreamWriter sTwR;
            if (dtgconten.RowCount > 0)
            {
                SaveFileCts.FileName = "Cts " + DateTime.Now.ToLongDateString();

                if (SaveFileCts.FileName != string.Empty && SaveFileCts.ShowDialog() == DialogResult.OK)
                {
                    string path = SaveFileCts.FileName;
                    ///if (File.Exists(path)) st = File.AppendText(path);
                    //else
                    //string patchxls;
                    // patchxls = path.Substring(0, path.Length - 3) + "xls";
                    //MSG(path + (char)13+ patchxls);
                    sTwR = File.CreateText(path);
                    // stx = File.CreateText(patchxls);
                    string cadenita = "";
                    //     string cadenaxls = "";
                    for (int i = 0; i < dtgconten.RowCount; i++)
                    {
                        for (int j = 0; j < dtgconten.ColumnCount - 1; j++)
                        {
                            cadenita = cadenita + dtgconten[j, i].Value.ToString() + "|";
                            //          cadenaxls += dtgconten[j, i].Value.ToString() + (char)9;
                        }
                        cadenita = cadenita + dtgconten[dtgconten.ColumnCount - 1, i].Value.ToString() + (char)(13);
                        //     cadenaxls += dtgconten[dtgconten.ColumnCount - 1, i].Value.ToString() + (char)(13);
                    }
                    sTwR.Write(cadenita);
                    sTwR.Close();
                    //  stx.Write(cadenaxls);
                    //   stx.Close();
                    //ExportarExcel(dtgconten, patchxls);

                    msgOK("Guardando");
                }
                else
                {
                    //  MSG("Ingrese nombre del archivo");
                }
            }
            else
            {
                msg("Reporte esta vacio");
            }
        }

        private void cboTipodoc_Click(object sender, EventArgs e)
        {
            CargarTipoDocumento();
        }

        private void cboTipoContrato_Click(object sender, EventArgs e)
        {
            CargarTipoContratacion();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Cargado = false;
            LimpiarControles();
            Cargado = true;
            FiltrarDatos();
        }
        private void LimpiarControles()
        {
            txtbusAreaGerencia.CargarTextoporDefecto();
            txtbusCargo.CargarTextoporDefecto();
            txtbusEmpleado.CargarTextoporDefecto();
            txtbusEmpresa.CargarTextoporDefecto();
            cboTipodoc.SelectedIndex = 0;
            cboTipoContrato.SelectedIndex = 0;
        }
        System.Data.DataTable Tdatos;
        private void FiltrarDatos()
        {
            if (!Cargado) return;
            //if (minimo > maximo)
            //{
            //    aux = minimo;
            //    minimo = maximo;
            //    maximo = aux;
            //}
            //if (maximo < minimo)
            //{
            //    aux = maximo;
            //    maximo = minimo;
            //    minimo = aux;
            //}
            //if (fechainicio > fechafin)
            //{
            //       dtgconten.DataSource = Creporempleado.Reporteempleados(0, opciones, "", dni, carnet, pasa, cedula, ruc, practicas, planillaempleado, planillaobrero, recibohono, sueldo, minimo, maximo, fecha, fechafin, fechainicio, banco, codbanco.ToString());
            //}
            //else
            //{
            Tdatos = CapaLogica.ReporteempleadosFiltrados(0, txtbusEmpleado.TextValido(), txtbusEmpresa.TextValido(), txtbusCargo.TextValido(),
                txtbusAreaGerencia.TextValido(), (int)cboTipodoc.SelectedValue, (int)cboTipoContrato.SelectedValue);
            dtgconten.DataSource = Tdatos;
            //}
            //////SUMATORIA
            if (dtgconten.RowCount > 0)
            {
                decimal sumatoria = 0.00M;
                for (int i = 0; i < dtgconten.RowCount; i++)
                {
                    sumatoria += decimal.Parse(dtgconten["Sueldo", i].Value.ToString());
                }
                txtsumatoria.Text = sumatoria.ToString();
            }
            else
                txtsumatoria.Text = "0.00";
            ContarRegistros(dtgconten);
        }

        private void txtbusEmpleado_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }

        private void txtbusEmpresa_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }

        private void txtbusAreaGerencia_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cargado = true;
            FiltrarDatos();
        }

        private void cboTipodoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }

        private void cboTipoContrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }

        private void btnexportaexcel_Click(object sender, EventArgs e)
        {
            ExportarExcel(dtgconten, "");
        }
        frmProcesando frmpro;
        public void ExportarExcel(DataGridView grilla, string path)
        {
            if (dtgconten.RowCount > 0)
            {
                frmpro = new frmProcesando();
                frmpro.Show(); Cursor = Cursors.WaitCursor;
                Empresa = txtbusEmpresa.TextValido();
                NombreEmpleado = txtbusEmpleado.TextValido();
                Area = txtbusAreaGerencia.TextValido();
                Cargo = txtbusCargo.TextValido();
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else { msgE("No hay Datos que Mostrar"); }
            //Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            //if (xlApp == null)
            //{
            //    //Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.");
            //    return;
            //}
            //xlApp.Visible = true;
            //Workbook wb = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            //Worksheet ws = (Worksheet)wb.Worksheets[1];
            //if (ws == null)
            //{
            //    msg("Hoja de Trabajo no se pudo Crear. Verifique si tiene instalado Office Excel.");
            //    return;
            //}
            //// Select the Excel cells, in the range c1 to c7 in the worksheet. 
            //Range arangito;
            //for (int contador = 0; contador < grilla.ColumnCount; contador++)
            //{
            //    arangito = ws.get_Range(((char)(65 + contador) + "" + (1)).ToString());
            //    arangito.Value2 = grilla.Columns[contador].HeaderText.ToString();
            //}
            //for (int i = 0; i < grilla.RowCount; i++)
            //{
            //    for (int j = 0; j < grilla.ColumnCount - 1; j++)
            //    {
            //        arangito = ws.get_Range(((char)(65 + j) + "" + (i + 2)).ToString());//, (char)(65 + j) +""+ (i + 1));

            //        if (arangito == null)
            //        {
            //            // MSG("Could not get a range. Check to be sure you have the correct versions of the office DLLs.");
            //            return;
            //        }
            //        arangito.Value2 = grilla[j, i].Value.ToString();
            //    }
            //    arangito = ws.get_Range((char)(65 + grilla.ColumnCount - 1) + "" + (i + 2));//, (char)(65 + grilla.ColumnCount - 1) +""+ (i + 1));
            //    arangito.Value2 = grilla[grilla.ColumnCount - 1, i].Value.ToString();
            //}
            //try
            //{
            //    xlApp.SaveWorkspace(path);
            //}
            //catch { }
        }
        private void cbobanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbusca_TextChanged(sender, e);
        }
        private void dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetText(dtgconten[e.ColumnIndex, e.RowIndex].Value.ToString());
            msgOK("Celda Copiada");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                int[] _ColumnasAutoajustar = new int[] { 2, 3, 4, 5 };
                //
                _NombreHoja = $"Resumen de Empleados";
                _Cabecera = "Resumen de Empleados";
                _NColumna = "m";
                _ColumnasAutoajustar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
                _Columnas = new int[] { 1, 2, 3, 4, 5, 6 };
                //
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                int PosInicialGrilla = 2;
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", $"{_NColumna}1", _Cabecera.ToUpper(), 10, true, true, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                if (txtbusEmpresa.EstaLLeno())
                {
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{PosInicialGrilla}", $"{_NColumna}{PosInicialGrilla}", "Filtro: Empresa; " + Empresa, 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                    PosInicialGrilla++;
                }
                if (txtbusEmpleado.EstaLLeno())
                {
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{PosInicialGrilla}", $"{_NColumna}{PosInicialGrilla}", $"Filtro: Empleado; {NombreEmpleado}", 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                    PosInicialGrilla++;
                }
                if (txtbusAreaGerencia.EstaLLeno())
                {
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{PosInicialGrilla}", $"{_NColumna}{PosInicialGrilla}", $"Filtro: Area/Gerencia; {NombreEmpleado}", 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                    PosInicialGrilla++;
                }
                if (txtbusCargo.EstaLLeno())
                {
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{PosInicialGrilla}", $"{_NColumna}{PosInicialGrilla}", $"Filtro: Cargos; {NombreEmpleado}", 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                    PosInicialGrilla++;
                }
                //
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, Configuraciones.FuenteReportesTahoma8, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                System.Data.DataTable TableResuk = new System.Data.DataTable();
                TableResuk = (Tdatos).Copy();
                //Cambiamos las Cabeceras de las Columnas  
                foreach (DataGridViewColumn item in dtgconten.Columns)
                {
                    TableResuk.Columns[item.DataPropertyName].ColumnName = item.HeaderText;
                }
                //Removemos las Columnas que no Necesitamos        
                //TableResuk.Columns.RemoveAt(7);
                //TableResuk.Columns.RemoveAt(6);
                //TableResuk.Columns.RemoveAt(5);

                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableResuk, CeldaCabecera, CeldaDefault, "", _NombreHoja, Celdas, PosInicialGrilla, _Columnas, new int[] { }, _ColumnasAutoajustar, "");
                PosInicialGrilla++;
            }
            else msg("No hay Registros en la Grilla");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmpro.Close();
        }
        int codbanco = 0;
        private bool Cargado;
        private string Empresa;

        public string NombreEmpleado { get; private set; }
        public string Area { get; private set; }
        public string Cargo { get; private set; }

        private void txtbusca_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }
        public void ContarRegistros(DataGridView tablita)
        {
            lblmsg.Text = "Total Registros: " + tablita.RowCount;
        }
    }
}
