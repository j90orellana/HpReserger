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
        public void cargarEmpresa()
        {
            string name = cboempresa.Text;
            cboempresa.DataSource = CapaLogica.ListarEmpresas();
            cboempresa.ValueMember = "id_empresa";
            cboempresa.DisplayMember = "empresa";
            cboempresa.Text = name;
        }
        private void LibroBancosEfectivo_Load(object sender, EventArgs e)
        {
            cargarEmpresa();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FechaInicial = comboMesAño1.GetFechaPRimerDia();
            FechaFinal = comboMesAño1.FechaFinMes;
            NombreEmpresa = cboempresa.Text;
            if (cboempresa.Items.Count == 0) { msg("No hay Empresas"); return; }
            if (cboempresa.SelectedValue == null) { msg("Seleccion una Empresa"); cboempresa.Focus(); return; }
            dtgconten.DataSource = CapaLogica.FormatoCajaBanco1_1((int)cboempresa.SelectedValue, FechaInicial, FechaFinal);
            lblmensaje.Text = $"Total de Registros: {dtgconten.RowCount}";
            if (dtgconten.RowCount == 0) msg("No Hay Registros");
            //Cambiamos los valores de la columna M
            int c = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                item.Cells[xCorrelativo.Name].Value = $"M{++c}";
            }
            Cursor = Cursors.Default;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = 0;
            if (cboempresa.Items.Count > 0)
            {
                x = cboempresa.SelectedIndex;
                DataRow Fila = ((DataTable)cboempresa.DataSource).Rows[x];
                txtruc.Text = Fila["ruc"].ToString();
                txtRucDeudor.Text = txtruc.Text;
            }
            else
            {
                txtruc.CargarTextoporDefecto();
            }
        }
        frmProcesando frmproce;
        public void CerrarPanelTxt()
        {
            //PanelTxt.Visible = false;
        }
        private void btnexcel_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();
            if (dtgconten.RowCount > 0)
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
            else
            {
                msg("No hay Datos que Exportar");
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                string _NombreHoja = ""; string _Cabecera = ""; int[] _OrdenarColumnas; string _NColumna = "";
                _NombreHoja = "Libro Caja Banco - Efectivo"; _Cabecera = "1.1 LIBRO CAJA Y BANCOS - DETALLE DE LOS MOVIMIENTOS DEL EFECTIVO";
                _OrdenarColumnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
                _NColumna = "m";
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "n1", _Cabecera.ToUpper(), 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "PERIODO:", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", $"{FechaInicial.Year} {FechaInicial.Month.ToString("00")}", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", "Ruc:", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", "c3", $"{txtruc.Text}", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", "g4", "APELLIDOS Y NOMBRES, DENOMINACIÓN O RAZÓN SOCIAL:", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("h4", "n4", $"{NombreEmpresa}", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
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
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TablaExportar, CeldaCabecera, CeldaDefault, $" { NombreEmpresa} {FechaInicial.ToString("MMMMyyyy00").ToUpper()}", _NombreHoja, Celdas, 5, _OrdenarColumnas, new int[] { }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "");
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
            txtaño.Text = comboMesAño1.FechaConDiaActual.Year.ToString("0000");
            txtmes.Text = comboMesAño1.FechaConDiaActual.Month.ToString("00");
            txtinformacion.Text = (dtgconten.RowCount > 0 ? 1 : 0).ToString();
            PanelTxt.Visible = true;
        }
        private void buttonPer1_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();
        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private StreamWriter st;
        private void btnTxt_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount == 0)
            {
                var Result = msgp("No hay Datos en la Grilla, Igual Desea Generar?");
                if (Result != DialogResult.Yes)
                {
                    msg("Cancelado por el Usuario");
                    return;
                }
            }
            //Avanza para Generar el TXT
            string[] campo = new string[20];
            string cadenatxt = "";            //int ValorPrueba = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                //ValorPrueba = 0;
                int c = 0;
                //1
                campo[c++] = item.Cells[xperiodo.Name].Value.ToString().Trim();
                campo[c++] = item.Cells[xcuo.Name].Value.ToString().Trim();
                campo[c++] = item.Cells[xCorrelativo.Name].Value.ToString().Trim();
                campo[c++] = item.Cells[xCodigoCuenta.Name].Value.ToString().Trim();
                campo[c++] = item.Cells[xCodigoOperacion.Name].Value.ToString().Trim();
                campo[c++] = item.Cells[xCentroCosto.Name].Value.ToString().Trim();
                campo[c++] = item.Cells[xMoneda.Name].Value.ToString().Trim();
                campo[c++] = ((int)item.Cells[xTipoComprobante.Name].Value).ToString("00");
                campo[c++] = item.Cells[xSerieComprobante.Name].Value.ToString().Trim();
                //10
                campo[c++] = item.Cells[xNumComprobante.Name].Value.ToString().Trim();
                campo[c++] = item.Cells[xFechaContable.Name].Value.ToString();
                campo[c++] = item.Cells[xFechaVence.Name].Value.ToString();
                campo[c++] = item.Cells[xFechaEmision.Name].Value.ToString();
                campo[c++] = item.Cells[xGlosa.Name].Value.ToString().Length > 200 ? item.Cells[xGlosa.Name].Value.ToString().Substring(0, 200) : item.Cells[xGlosa.Name].Value.ToString();
                campo[c++] = item.Cells[xGlosa.Name].Value.ToString().Length > 200 ? item.Cells[xGlosa.Name].Value.ToString().Substring(0, 200) : item.Cells[xGlosa.Name].Value.ToString();
                //debe y haber
                campo[c++] = ((decimal)item.Cells[xDebe.Name].Value).ToString("0.00");
                campo[c++] = ((decimal)item.Cells[xHaber.Name].Value).ToString("0.00");
                //
                campo[c++] = item.Cells[xDatoEstructurado.Name].Value.ToString().Trim();
                campo[c++] = ((int)item.Cells[xEstado.Name].Value).ToString();
                //
                //Uniendo por pipes
                cadenatxt += string.Join("|", campo) + $"{Environment.NewLine }";
                //Limpiamos el Campo
                //campo = null;
            }
            SaveFile.FileName = $"LE{txtRucDeudor.Text}{txtaño.Text}{txtmes.Text}00010100001{txtinformacion.Text}11";
            if (SaveFile.FileName != string.Empty && SaveFile.ShowDialog() == DialogResult.OK)
            {
                string path = SaveFile.FileName;
                st = File.CreateText(path);
                st.Write(cadenatxt);
                st.Close();
                msgOK("Generado TXT con Éxito");
                PanelTxt.Visible = false;
            }
        }
    }
}
