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
    public partial class frmBalanceComprobacion : FormGradient
    {
        public frmBalanceComprobacion()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void CargarEmpresas()
        {
            cboEmpresas.DisplayMember = "descripcion";
            cboEmpresas.ValueMember = "codigo";
            cboEmpresas.DataSource = CapaLogica.getCargoTipoContratacion("Id_Empresa", "Empresa", "TBL_Empresa");
        }
        private void frmBalanceComprobacion_Load(object sender, EventArgs e)
        {
            CargarEmpresas();
            //HPResergerFunciones.frmInformativo.RedondearEsquinas(5, btnProcesar, BtnCerrar, btnExportarExcel);
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.frmInformativo.MostrarDialogError(cadena);
        }
        private void btnTxt_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int Largo = 2;
            Largo = rb2digitos.Checked ? 2 : 7;
            if (cboEmpresas.SelectedValue != null)
            {

                dtgconten.DataSource = CapaLogica.BalanceComprobacion((int)cboEmpresas.SelectedValue, Largo, comboMesAño.FechaFinMes);
                lblmsg.Text = $"Total de Registros: {dtgconten.RowCount}";
            }
            else
            {
                msg("Seleccione un Empresa");
            }
            Cursor = Cursors.Default;
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.Rows.Count > 0)
            {
                Cursor = Cursors.WaitCursor;
                frmproce = new HPReserger.frmProcesando();
                frmproce.Show();
                NameFecha = $"MES DE {comboMesAño.FechaFinMes.ToString("MMMM")} DE {comboMesAño.FechaFinMes.ToString("yyyy")}";
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
        frmProcesando frmproce;
        private string NameFecha;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                _NombreHoja = "Balance de Comprobación"; _Cabecera = "Balance de Comprobación";
                _Columnas = new int[] { }; _NColumna = "f";
                //
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "d1", _Cabecera.ToUpper(), 14, true, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", $"{_NColumna}1", "BALANCE DE COMPROBACIÓN POR MAYOR CONSOLIDADO".ToUpper(), 10, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", $"{_NColumna}2", "(MENSUAL)".ToUpper(), 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", $"{_NColumna}3", NameFecha.ToUpper(), 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", $"{_NColumna}4", "(EXPRESADO EN NUEVO SOLES)".ToUpper(), 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8));

                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, Configuraciones.FuenteReportesTahoma8, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, Configuraciones.FuenteReportesTahoma8, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                int PosInicialGrilla = 5;
                DataTable TablaExportar = new DataTable();
                TablaExportar = ((DataTable)dtgconten.DataSource).Copy();
                //Remuevo Columnas inservibles               
                //TablaExportar.Columns.RemoveAt(0);
                //
                //
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TablaExportar, CeldaCabecera, CeldaDefault, _NombreHoja, _NombreHoja, Celdas, PosInicialGrilla, _Columnas, new int[] { }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10, 11, 12, 13, 14, 15, 16, 18 }, "");
            }
            else msg("No hay datos que Exportar");
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
            dtgconten.ResumeLayout();
        }
    }
}
