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

namespace HPReserger.ModuloReportes
{
    public partial class frmReporteSaldosContables : FormGradient
    {
        public frmReporteSaldosContables()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        public void CargarEmpresas()
        {
            cboEmpresas.DisplayMember = "descripcion";
            cboEmpresas.ValueMember = "codigo";
            cboEmpresas.DataSource = CapaLogica.getCargoTipoContratacion("Id_Empresa", "Empresa", "TBL_Empresa");
        }
        private void frmReporteSaldosContables_Load(object sender, EventArgs e)
        {
            CargarEmpresas();
        }
        private void cboEmpresas_Click(object sender, EventArgs e)
        {
            DataTable Tablita = CapaLogica.getCargoTipoContratacion("Id_Empresa", "Empresa", "TBL_Empresa");
            if (cboEmpresas.Items.Count != Tablita.Rows.Count)
            {
                string cadena = cboEmpresas.Text;
                cboEmpresas.DataSource = Tablita;
                cboEmpresas.Text = cadena;
            }
        }
        public DateTime FechaFinMes;
        DateTime FechaInicioAnio;
        string NameEmpresa = "";
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FechaInicioAnio = new DateTime(comboMesAño.FechaFinMes.Year, 1, 1);
            NameEmpresa = cboEmpresas.Text;
            FechaFinMes = comboMesAño.FechaFinMes;
            if (chk2col.Checked)
            {
                DataTable Table = CapaLogica.ReporteSaldosContables2((int)cboEmpresas.SelectedValue, FechaInicioAnio, FechaFinMes);
                DataView dv = Table.AsDataView();
                dtgconten.DataSource = dv.ToTable();
            }
            else
            {
                DataTable Table = CapaLogica.ReporteSaldosContables((int)cboEmpresas.SelectedValue, FechaInicioAnio, FechaFinMes);
                DataView dv = Table.AsDataView();
                dv.RowFilter = "montosoles <>0 and montodolares <>0";
                dv.Sort = "CuentaContable asc";
                dtgconten.DataSource = dv.ToTable();
            }
            lblconteo.Text = $"Total Registros: {dtgconten.RowCount}";
            this.Cursor = Cursors.Default;
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        frmProcesando frmproce;
        private void btnexportarexcel_Click(object sender, EventArgs e)
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
                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                _NombreHoja = "Reporte Saldos Contables"; _Cabecera = "Reporte Saldos Contables";
                _Columnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }; _NColumna = "m";
                //Columnas AutoAjustar
                int[] _AutoAjustarColumnas = new int[] { 2, 3, 4 };
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "a4", _Cabecera.ToUpper(), 16, true, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "Empresa:", 12, false, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", NameEmpresa, 12, false, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", $"De: {FechaInicioAnio.ToShortDateString()} Al: {FechaFinMes.ToShortDateString()} ", 12, false, false, Back, Fore));
                // Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", "Ruc:", 12, false, true, Back, Fore));
                //// Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", "c3", $"{txtruc.Text}", 12, false, true, Back, Fore));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", txtbuscuenta.Text.Length > 0 ? "CUENTA CONTABLE:" : "", 12, false, false, Back, Fore));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("d3", "d3", $"{(txtbuscuenta.Text.Length > 0 ? txtbuscuenta.Text : "")}", 12, false, false, Back, Fore));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "b2", "Nombre Vendedor:", 11));
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, dtgconten.ColumnHeadersDefaultCellStyle.Font, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                /////fin estilo de las celdas
                DataTable TableResult = new DataTable();
                DataView dt = ((DataTable)dtgconten.DataSource).AsDataView();
                TableResult = dt.ToTable();
                //MACRO
                int PosInicialGrilla = 4;
                string Macro = "";
                //por la segunda columna
                if (chk2col.Checked)
                {
                    TableResult.Columns[2].ColumnName = "Moneda";
                    TableResult.Columns[3].ColumnName = "Monto";
                }
                ///
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableResult, CeldaCabecera, CeldaDefault, "", _NombreHoja, Celdas, PosInicialGrilla, _Columnas, new int[] { }, _AutoAjustarColumnas, Macro);
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

        private void chk2col_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2col.Checked)
            {
                dtgconten.Columns[xMontoSoles.Name].HeaderText = "Moneda";
                dtgconten.Columns[xMontoDolares.Name].HeaderText = "Monto";
            }
            else
            {
                dtgconten.Columns[xMontoSoles.Name].HeaderText = "Monto Soles";
                dtgconten.Columns[xMontoDolares.Name].HeaderText = "Monto Dolares";
            }
            dtgconten.DataSource = ((DataTable)dtgconten.DataSource).Clone() ?? new DataTable();
        }
    }
}
