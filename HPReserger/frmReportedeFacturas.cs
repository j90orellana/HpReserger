using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmReportedeFacturas : FormGradient
    {
        public frmReportedeFacturas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void frmReportedeFacturas_Load(object sender, EventArgs e)
        {
            dtpfechaini.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfechafin.Value = new DateTime(DateTime.Now.Year, 12, 31);
        }
        frmProcesando frmproce;
        private void btnexcel_Click(object sender, EventArgs e)
        {
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
                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas;
                _NombreHoja = "Comprobantes Incompletos"; _Cabecera = "LISTADO DE COMPROBANTES INCOMPLETOS DE COMPRAS";
                _Columnas = new int[] { };//1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "a1", _Cabecera.ToUpper(), 16, true, false, Back, Fore));
                int CON = 0;
                if (chkfecha.Checked)
                {
                    CON++;
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "PERIODO:", 12, false, false, Back, Fore));
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", $"De: {dtpfechaini.Value.ToShortDateString() } A: {dtpfechafin.Value.ToShortDateString()}", 12, false, false, Back, Fore));
                }
                ////
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, dtgconten.ColumnHeadersDefaultCellStyle.Font, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                ////fin estilo de las celdas
                DataTable TableResult = new DataTable();
                DataView dt = ((DataTable)dtgconten.DataSource).AsDataView();
                TableResult = dt.ToTable();
                foreach (DataColumn item in TableResult.Columns) item.ColumnName = dtgconten.Columns["x" + item.ColumnName].HeaderText;
                ////
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableResult, CeldaCabecera, CeldaDefault, "", _NombreHoja, Celdas, 2 + CON, _Columnas, new int[] { }, new int[] { }, "");
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
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        DateTime FechaIni;
        DateTime FechaFin;
        private void btngenerar_Click(object sender, EventArgs e)
        {
            FechaIni = dtpfechaini.Value;
            FechaFin = dtpfechafin.Value;
            DateTime FechaAux;
            if (FechaIni > FechaFin)
            {
                FechaAux = FechaFin;
                FechaFin = FechaIni;
                FechaIni = FechaAux;
            }
            dtgconten.DataSource = CapaLogica.ReporteFacturasComprasIncompletas(FechaIni, FechaFin, chkfecha.Checked ? 1 : 0);
            //dtgconten.AutoGenerateColumns = true;            
            //dtgconten.DataMember = "cuenta_contable";
            lblmensaje.Text = $"Total de Registros: {dtgconten.RowCount}";
            if (dtgconten.RowCount == 0) msg("No Hay Registros");
        }
    }
}
