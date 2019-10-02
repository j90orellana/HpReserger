using CrystalDecisions.Shared;
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
    public partial class frmRegistroCompras : FormGradient
    {
        public frmRegistroCompras()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmRegistroCompras_Load(object sender, EventArgs e)
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
        public void CerrarPanelTxt()
        {
            PanelTxt.Visible = false;
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
        public void msg(string cadena) { HPResergerFunciones.Utilitarios.msg(cadena); }
        private void btngenerar_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();

            FechaPeriodo = comboMesAño1.GetFechaPRimerDia();
            NombreEmpresa = cboempresa.Text;
            if (cboempresa.Items.Count == 0) { msg("No hay Empresas"); return; }
            if (cboempresa.SelectedValue == null) { msg("Seleccion una Empresa"); cboempresa.Focus(); return; }
            dtgconten.DataSource = CapaLogica.FormatodeCompras8_1((int)cboempresa.SelectedValue, comboMesAño1.getMesNumero(), comboMesAño1.GetFecha().Year);
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
                _NombreHoja = "Registro de Compras"; _Cabecera = "FORMATO 8.1: REGISTRO DE COMPRAS";
                _Columnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 }; _NColumna = "m";

                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "a1", _Cabecera.ToUpper(), 16, true, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "PERIODO:", 12, false, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", $"{FechaPeriodo.Year} {FechaPeriodo.Month.ToString("00")}", 12, false, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", "Ruc:", 12, false, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", "c3", $"{txtruc.Text}", 12, false, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", "a4", "APELLIDOS Y NOMBRES, DENOMINACIÓN O RAZÓN SOCIAL:", 12, false, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("h4", "h4", $"{NombreEmpresa}", 12, false, false, Back, Fore));
                ///////estilos de la celdas
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, dtgconten.ColumnHeadersDefaultCellStyle.Font, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                /////fin estilo de las celdas
                DataTable TableResult = new DataTable(); DataView dt = ((DataTable)dtgconten.DataSource).AsDataView(); TableResult = dt.ToTable();
                ///Tabla
                foreach (DataColumn item in TableResult.Columns) { item.ColumnName = dtgconten.Columns["x" + item.ColumnName].HeaderText; }
                /////
                ////Anterior               
                //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", _NombreHoja, Celdas, 5, _Columnas, new int[] { }, new int[] { });
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableResult, CeldaCabecera, CeldaDefault, $" { NombreEmpresa} {FechaPeriodo.ToString("MMMM yyyy").ToUpper()}", _NombreHoja, Celdas, 5, _Columnas, new int[] { }, new int[] { }, "");
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
        frmReporteCompras81Report frmreport;
        private void button1_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();

            if (frmreport == null)
            {
                Cursor = Cursors.WaitCursor;
                empresa = (int)cboempresa.SelectedValue;
                frmreport = new frmReporteCompras81Report(empresa, txtruc.Text, cboempresa.Text, comboMesAño1.GetFechaPRimerDia());
                frmreport.FormClosed += Frmreport_FormClosed;
                frmreport.MdiParent = this.MdiParent;
                frmreport.Show();
                Cursor = Cursors.Default;
            }
            else
            {
                frmreport.StartPosition = FormStartPosition.CenterParent;
                frmreport.Activate();
            }
        }
        private void Frmreport_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmreport = null;
        }

        private void btnGenerarTXT_Click(object sender, EventArgs e)
        {
            PanelTxt.BringToFront();
            txtaño.Text = comboMesAño1.FechaConDiaActual.Year.ToString("0000");
            txtmes.Text = comboMesAño1.FechaConDiaActual.Month.ToString("00");
            txtinformacion.Text = (dtgconten.RowCount > 0 ? 1 : 0).ToString();
            PanelTxt.Visible = true;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();
        }

        private void comboMesAño1_Enter(object sender, EventArgs e)
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
            string[] campo = new string[42];
            string cadenatxt = "";
            int ValorPrueba = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                ValorPrueba = 0;
                int c = 0;
                campo[c++] = $"{txtaño.Text}{txtmes.Text}00";
                campo[c++] = ((item.Cells[xcuo.Name].Value.ToString())).ToString();
                campo[c++] = "M2";
                campo[c++] = ((DateTime)item.Cells[xFechaEmision.Name].Value).ToString("dd/MM/yyyy");
                campo[c++] = "";
                campo[c++] = ((int)item.Cells[xidC.Name].Value).ToString();
                campo[c++] = item.Cells[xSerieCom.Name].Value.ToString().Trim();
                int.TryParse(item.Cells[xAñoDua.Name].Value.ToString(), out ValorPrueba);
                campo[c++] = ValorPrueba.ToString();
                campo[c++] = item.Cells[xNumCom.Name].Value.ToString().Trim();
                //En caso de optar por anotar el importe total de las operaciones diarias que no otorguen derecho a crédito fiscal en forma consolidada, registrar el número inicial
                campo[c++] = "";
                campo[c++] = (int.Parse(item.Cells[xTipoIdPro.Name].Value.ToString())).ToString();
                campo[c++] = item.Cells[xNumpro.Name].Value.ToString().Trim();
                string Cadena = item.Cells[xNombrePro.Name].Value.ToString().ToUpper().Trim();
                campo[c++] = Cadena.Substring(0, Cadena.Length > 60 ? 60 : Cadena.Length);
                //Parte de los IGV
                campo[c++] = ((decimal)item.Cells[ximporteIGV.Name].Value).ToString("0.00");
                campo[c++] = ((decimal)item.Cells[xigvIGV.Name].Value).ToString("0.00");
                //Partes de los GNG
                campo[c++] = ((decimal)item.Cells[ximporteGNG.Name].Value).ToString("0.00");
                campo[c++] = ((decimal)item.Cells[xigvGNG.Name].Value).ToString("0.00");
                //Partes de los ONG
                campo[c++] = ((decimal)item.Cells[ximporteONG.Name].Value).ToString("0.00");
                campo[c++] = ((decimal)item.Cells[xigvONG.Name].Value).ToString("0.00");
                //Partes de NGR
                campo[c++] = ((decimal)item.Cells[ximporteNGR.Name].Value).ToString("0.00");
                campo[c++] = ((decimal)item.Cells[xisc.Name].Value).ToString("0.00");
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
                    campo[c++] = "0.000";
                }
                campo[c++] = item.Cells[xFechaDocRef.Name].Value.ToString() == "" ? "01/01/0001" : ((DateTime)item.Cells[xFechaDocRef.Name].Value).ToString("dd/MM/yyyy");
                int.TryParse(item.Cells[xTipoDocRef.Name].Value.ToString(), out ValorPrueba);
                campo[c++] = ValorPrueba.ToString();
                //Datos del Documento que Modifica
                campo[c++] = item.Cells[xSerieDocRef.Name].ToString() == "" ? "-" : item.Cells[xSerieDocRef.Name].Value.ToString().Trim();
                campo[c++] = item.Cells[xNumDocRef.Name].ToString() == "" ? "-" : item.Cells[xNumDocRef.Name].Value.ToString().Trim();
                //Número del comprobante de pago emitido por sujeto no domiciliado
                campo[c++] = "-";
                //Fecha de emisión de la Constancia de Depósito de Detracción 
                campo[c++] = item.Cells[xFechaDet.Name].Value.ToString() == "" ? "01/01/0001" : ((DateTime)item.Cells[xFechaDet.Name].Value).ToString("dd/MM/yyyy");
                //Número de la Constancia de Depósito de Detracción
                campo[c++] = item.Cells[xNumDet.Name].Value.ToString() == "" ? "0" : item.Cells[xNumDet.Name].Value.ToString().Trim();
                //Marca del comprobante de pago sujeto a retención
                //1. Obligatorio 
                //2.Si identifica el comprobante sujeto a retención consignar '1', caso contrario '0'
                campo[c++] = "0";
                //Indica el estado del comprobante de pago y a la incidencia en la base imponible  en relación al periodo tributario correspondiente
                //1. Obligatorio
                //2.Registrar '1' cuando se anota el Comprobante de Pago o documento en el periodo que se emitió o que se pagó el impuesto, según corresponda.
                //3.Registrar '6' cuando la fecha de emisión del Comprobante de Pago o de pago del impuesto es anterior al periodo de anotación y esta se produce dentro de los doce meses siguientes a la emisión o pago del impuesto, según corresponda.
                //4.Registrar '7' cuando la fecha de emisión del Comprobante de Pago o pago del impuesto es anterior al periodo de anotación y esta se produce luego de los doce meses siguientes a la emisión o pago del impuesto, según corresponda.
                //5.Registrar '9' cuando se realice un ajuste en la anotación de la información de una operación registrada en un periodo anterior.
                campo[c++] = "1";
                //7 Extras
                campo[c++] = "";
                campo[c++] = "";
                campo[c++] = "";
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
                        Estado = 0;
                    else
                        Estado = 1;
                }
                else
                {
                    //Calculamos la diferencia para ver cuantos meses pasaron
                    int anio = FechaDeclara.Year - FechaEmision.Year;
                    int meses = (FechaDeclara.Month + (anio * 12)) - FechaEmision.Month;
                    if (meses < 12)
                        Estado = 6;
                    else Estado = 7;
                }
                //Columna Final
                campo[c++] = Estado.ToString();
                //Uniendo por pipes
                cadenatxt += string.Join("|", campo) + $"{Environment.NewLine}";
                //Limpiamos el Campo
                //campo = null;
            }
            //Formato 8.1
            SaveFile.FileName = $"LE{txtRucDeudor.Text}{txtaño.Text}{txtmes.Text}00080100001{txtinformacion.Text}11";
            if (SaveFile.FileName != string.Empty && SaveFile.ShowDialog() == DialogResult.OK)
            {
                string path = SaveFile.FileName;
                st = File.CreateText(path);
                st.Write(cadenatxt);
                st.Close();
                //msg("Generado TXT con Éxito");
                PanelTxt.Visible = false;
            }
            //Formato 8.2 - Esta Vacio aun
            SaveFile.FileName = $"LE{txtRucDeudor.Text}{txtaño.Text}{txtmes.Text}00080200001011";
            if (SaveFile.FileName != string.Empty && SaveFile.ShowDialog() == DialogResult.OK)
            {
                string path = SaveFile.FileName;
                st = File.CreateText(path);
                st.Write("");
                st.Close();
                msg("Generado TXT con Éxito");
                PanelTxt.Visible = false;
            }
        }
        private StreamWriter st;
        private void comboMesAño1_Load(object sender, EventArgs e)
        {

        }

        private void comboMesAño1_Click(object sender, EventArgs e)
        {
            CerrarPanelTxt();
        }
    }
}
