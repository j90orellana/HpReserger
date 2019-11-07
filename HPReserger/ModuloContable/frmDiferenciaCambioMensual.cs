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
    public partial class frmDiferenciaCambioMensual : FormGradient
    {
        public frmDiferenciaCambioMensual()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();

        public string NameEmpresa { get; private set; }

        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        private void frmcierremensual_Load(object sender, EventArgs e)
        {
            CargarEmpresa();
        }
        public void CargarEmpresa()
        {
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
            cboempresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cboempresa_Click(object sender, EventArgs e)
        {
            string cadena = cboempresa.SelectedText;
            CargarEmpresa();
            cboempresa.Text = cadena;
        }

        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cuando selecciono algo del index
            btnAplicar.Enabled = false;
            if (cboempresa.SelectedIndex >= 0)
            {
                cboperiodo.DataSource = CapaLogica.Periodos(10, (int)cboempresa.SelectedValue);
                cboperiodo.ValueMember = "fechax";
                cboperiodo.DisplayMember = "mesaño";
                NameEmpresa = cboempresa.SelectedText;
            }
            if (cboperiodo.Items.Count > 0)
                btnaceptar.Enabled = true;
            else
            {
                btnaceptar.Enabled = false;
            }
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (cboempresa.SelectedValue != null && cboperiodo.SelectedValue != null)
            {
                DateTime FEcha = (DateTime)cboperiodo.SelectedValue;
                DataTable DatosTC = CapaLogica.TipodeCambio(101, FEcha.Year, FEcha.Month, 1, 0, 0, null);
                if (DatosTC.Rows.Count > 0)
                {
                    DataRow FilaTC = DatosTC.Rows[0];
                    dtgconten.DataSource = CapaLogica.CierreMensualSaldos((int)cboempresa.SelectedValue, (DateTime)cboperiodo.SelectedValue, ((DateTime)cboperiodo.SelectedValue).AddMonths(1).AddDays(-1), (decimal)FilaTC[1], (decimal)FilaTC[2]);
                    lblmsg.Text = $"Total de Registros: {dtgconten.RowCount}";
                }
                else msg("Ingrese el Tipo de Cambio para el Cierre de Este Periodo");
            }
            this.Cursor = Cursors.Default;
        }
        private void dtgconten1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {

        }

        private void cboperiodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                _NombreHoja = "Cierre Mensual"; _Cabecera = "Cierre Mensual por Saldos"; _Columnas = new int[] { 1, 2, 3, 4, 5, 6 }; _NColumna = "H";
                int[] _ColumnasAutoajustar = new int[] { 2, 3, 4, 5 };

                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", $"{_NColumna}1", _Cabecera.ToUpper(), 16, true, true, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", $"{_NColumna}2", NameEmpresa, 12, false, true, Back, Fore));
                //
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, dtgconten.ColumnHeadersDefaultCellStyle.Font, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                int PosInicialGrilla = 3;
                DataTable TableResuk = new DataTable();
                TableResuk = ((DataTable)dtgconten.DataSource).Copy();
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableResuk, CeldaCabecera, CeldaDefault, "", _NombreHoja, Celdas, PosInicialGrilla, _Columnas, new int[] { }, _ColumnasAutoajustar, "");
            }
            else msg("No hay Registros en la Grilla");
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmpro.Close();
            dtgconten.ResumeLayout();
        }
        frmProcesando frmpro;
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                ///* Inicio = new TimeSpan(DateTim*/e.Now.Ticks);
                dtgconten.SuspendLayout();
                frmpro = new frmProcesando();
                frmpro.Show(); Cursor = Cursors.WaitCursor;
                NameEmpresa = $"{cboempresa.Text} {cboperiodo.Text}";
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else { msg("No hay Datos que Mostrar"); }
        }
    }
}
