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
        public void cargarEmpresa()
        {
            string name = cboempresa.Text;
            cboempresa.DataSource = CapaLogica.ListarEmpresas();
            cboempresa.ValueMember = "id_empresa";
            cboempresa.DisplayMember = "empresa";
            cboempresa.Text = name;
        }
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = 0;
            if (cboempresa.Items.Count > 0)
            {
                x = cboempresa.SelectedIndex;
                DataRow Fila = ((DataTable)cboempresa.DataSource).Rows[x];
                txtRucDeudor.Text = txtruc.Text = Fila["ruc"].ToString();
            }
            else
            {
                txtruc.CargarTextoporDefecto();
            }
        }
        private void btngenerar_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();
            FechaPeriodo = comboMesAño1.GetFechaPRimerDia();
            NombreEmpresa = cboempresa.Text;
            if (cboempresa.Items.Count == 0) { msg("No hay Empresas"); return; }
            if (cboempresa.SelectedValue == null) { msg("Seleccion una Empresa"); cboempresa.Focus(); return; }
            dtgconten.DataSource = CapaLogica.FormatodeVentas14_1((int)cboempresa.SelectedValue, comboMesAño1.getMesNumero(), comboMesAño1.GetFecha().Year);
            lblmensaje.Text = $"Total de Registros: {dtgconten.RowCount}";
            if (dtgconten.RowCount == 0) msg("No Hay Registros");
        }
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
                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                _NombreHoja = "Registro de Ventas"; _Cabecera = "FORMATO 14.1: REGISTRO DE VENTAS";
                _Columnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 }; _NColumna = "m";

                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "a1", _Cabecera.ToUpper(), 14, true, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "PERIODO:", 10, false, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", $"{FechaPeriodo.Year} {FechaPeriodo.Month.ToString("00")}", 10, false, true, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", "Ruc:", 10, false, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", "c3", $"{txtruc.Text}", 10, false, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", "a4", "APELLIDOS Y NOMBRES, DENOMINACIÓN O RAZÓN SOCIAL:", 10, false, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("h4", "h4", $"{NombreEmpresa}", 10, false, false, Back, Fore));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "b2", "Nombre Vendedor:", 11));
                ///////estilos de la celdas
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                /////fin estilo de las celdas
                DataTable TableResult = new DataTable(); DataView dt = ((DataTable)dtgconten.DataSource).AsDataView(); TableResult = dt.ToTable();
                ///Tabla
                foreach (DataColumn item in TableResult.Columns) { item.ColumnName = dtgconten.Columns["x" + item.ColumnName].HeaderText; }
                /////
                ////Anterior
                //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", _NombreHoja, Celdas, 5, _Columnas, new int[] { }, new int[] { });
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableResult, CeldaCabecera, CeldaDefault, $" { NombreEmpresa} {FechaPeriodo.ToString("MMMM yyyy").ToUpper()}", _NombreHoja, Celdas, 5, _Columnas, new int[] { }, new int[] { 2, 3, 4, 5, 6, 7, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 }, "");
                //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", "Cronograma de Pagos", Celdas, 2, new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { }, new int[] { });
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
            txtaño.Text = comboMesAño1.FechaConDiaActual.Year.ToString("0000");
            txtmes.Text = comboMesAño1.FechaConDiaActual.Month.ToString("00");
            txtinformacion.Text = (dtgconten.RowCount > 0 ? 1 : 0).ToString();
            PanelTxt.Visible = true;
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
        public DialogResult msgYesNo(string cadena) { return HPResergerFunciones.Utilitarios.msgYesNo(cadena); }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount == 0)
            {
                var Result = msgYesNo("No hay Datos en la Grilla, Igual Desea Generar?");
                if (Result != DialogResult.Yes)
                {
                    msg("Cancelado por el Usuario");
                    return;
                }
            }
            //Avanza para Generar el TXT
            string[] campo = new string[35];
            string cadenatxt = "";
            int ValorPrueba = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                ValorPrueba = 0;
                int c = 0;
                //1
                campo[c++] = $"{txtaño.Text}{txtmes.Text}00";
                campo[c++] = (int.Parse(item.Cells[xix.Name].Value.ToString())).ToString("000");
                campo[c++] = "M2";
                campo[c++] = ((DateTime)item.Cells[xFechaEmision.Name].Value).ToString("dd/MM/yyyy");
                campo[c++] = "01/01/0001";
                campo[c++] = ((int)item.Cells[xidC.Name].Value).ToString("00");
                campo[c++] = item.Cells[xSerieCom.Name].Value.ToString().Trim();
                campo[c++] = item.Cells[xNumCom.Name].Value.ToString().Trim();
                //En caso de optar por anotar el importe total de las operaciones realizadas diariamente, registrar el número final. 
                campo[c++] = "";
                //10
                campo[c++] = (int.Parse(item.Cells[xTipoIdPro.Name].Value.ToString())).ToString();
                campo[c++] = item.Cells[xNumpro.Name].ToString() == "" ? "-" : item.Cells[xNumpro.Name].Value.ToString().Trim();
                string Cadena = item.Cells[xNombrePro.Name].Value.ToString().ToUpper().Trim();
                campo[c++] = Cadena.Substring(0, Cadena.Length > 60 ? 60 : Cadena.Length);
                //Parte de los IGV
                campo[c++] = ((decimal)item.Cells[xImportacion.Name].Value).ToString("0.00");
                campo[c++] = ((decimal)item.Cells[ximporteIGV.Name].Value).ToString("0.00");
                //Descuento Base Imponible
                campo[c++] = "0";
                campo[c++] = ((decimal)item.Cells[xIGVyoIPM.Name].Value).ToString("0.00");
                //Descuento del Igv
                campo[c++] = "0";
                campo[c++] = ((decimal)item.Cells[xExonerado.Name].Value).ToString("0.00");
                //Partes de los GNG
                campo[c++] = ((decimal)item.Cells[ximporteNGR.Name].Value).ToString("0.00");
                //20
                campo[c++] = ((decimal)item.Cells[xisc.Name].Value).ToString("0.00");
                //IVAP = Arroz Pilado y su Impuesto
                campo[c++] = "0";
                campo[c++] = "0";
                //Otros Conceptos
                campo[c++] = ((decimal)item.Cells[xOtrosTributos.Name].Value).ToString("0.00");
                //Validar Moneda
                campo[c++] = ((decimal)item.Cells[xImporteTotal.Name].Value).ToString("0.00");
                if (item.Cells[xMoneda.Name].Value.ToString() == "USD")
                {
                    campo[c++] = "USD";
                    campo[c++] = ((decimal)item.Cells[xTC.Name].Value).ToString("0.000");
                }
                else
                {
                    campo[c++] = "PEN";
                    campo[c++] = ((decimal)item.Cells[xTC.Name].Value).ToString("0.000");

                }
                campo[c++] = item.Cells[xFechaDocRef.Name].Value.ToString() == "" ? "01/01/0001" : ((DateTime)item.Cells[xFechaDocRef.Name].Value).ToString("dd/MM/yyyy");
                int.TryParse(item.Cells[xTipoDocRef.Name].Value.ToString(), out ValorPrueba);
                campo[c++] = ValorPrueba > 0 ? ValorPrueba.ToString("00") : "";
                //Datos del Documento que Modifica
                campo[c++] = item.Cells[xSerieDocRef.Name].ToString() == "" ? "" : item.Cells[xSerieDocRef.Name].Value.ToString().Trim();
                //30
                campo[c++] = item.Cells[xNumDocRef.Name].ToString() == "" ? "" : item.Cells[xNumDocRef.Name].Value.ToString().Trim();
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
                DateTime FechaDeclara = comboMesAño1.GetFechaPRimerDia();
                DateTime FechaEmision = (DateTime)item.Cells[xFechaEmision.Name].Value;
                //Mismo Mes de Declaración
                if (FechaDeclara.Month == FechaEmision.Month && FechaEmision.Year == FechaDeclara.Year)
                {
                    if (((decimal)item.Cells[ximporteNGR.Name].Value) > 0)
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
            SaveFile.FileName = $"LE{txtRucDeudor.Text}{txtaño.Text}{txtmes.Text}00140100001{txtinformacion.Text}11";
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
