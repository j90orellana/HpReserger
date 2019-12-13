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
                DataTable Tabla = (DataTable)dtgconten.DataSource;
                FilaTotal = Tabla.Rows.Count;
                Tabla.Rows.Add(Tabla.NewRow());
                Tabla.Rows.Add(Tabla.NewRow());
                Tabla.Rows.Add(Tabla.NewRow());
                Tabla.Rows.Add(Tabla.NewRow());
                SacarTotales();
            }
            else
            {
                msg("Seleccione un Empresa");
            }
            Cursor = Cursors.Default;
        }
        public void SacarTotales()
        {
            if (FilaTotal > 0)
            {
                dtgconten[xDescripcion.Name, FilaTotal + 1].Value = "Saldo".ToUpper();
                Font Fuente = dtgconten.DefaultCellStyle.Font;
                dtgconten[xDescripcion.Name, FilaTotal + 1].Style.Font = new Font(Fuente, FontStyle.Bold);
                //dtgconten.Rows[FilaTotal + 1].DefaultCellStyle.Font = new Font(Fuente, FontStyle.Bold);
                dtgconten[xDescripcion.Name, FilaTotal + 2].Value = "Resultado".ToUpper();
                dtgconten[xDescripcion.Name, FilaTotal + 2].Style.Font = new Font(Fuente, FontStyle.Bold);
                //dtgconten.Rows[FilaTotal + 2].DefaultCellStyle.Font = new Font(Fuente, FontStyle.Bold);
                dtgconten[xDescripcion.Name, FilaTotal + 3].Value = "Comprobación".ToUpper();
                dtgconten[xDescripcion.Name, FilaTotal + 3].Style.Font = new Font(Fuente, FontStyle.Bold);
                //dtgconten.Rows[FilaTotal + 3].DefaultCellStyle.Font = new Font(Fuente, FontStyle.Bold);
                foreach (DataGridViewColumn item in dtgconten.Columns)
                {
                    if (item.Index > 1)
                    {
                        decimal Valor = 0;
                        decimal valor1 = 0, valor2 = 0;
                        foreach (DataGridViewRow items in dtgconten.Rows)
                        {
                            if (items.Index < FilaTotal)
                            {
                                decimal val = 0;
                                decimal.TryParse(items.Cells[item.Name].Value.ToString(), out val);
                                Valor += val;
                                if (item.Index % 2 == 0 && item.Index > 1)
                                {
                                    decimal vale = 0;
                                    decimal.TryParse(items.Cells[item.Index].Value.ToString(), out vale);
                                    valor1 += vale;
                                    decimal.TryParse(items.Cells[item.Index + 1].Value.ToString(), out vale);
                                    valor2 += vale;
                                }
                            }
                        }
                        dtgconten[item.Name, FilaTotal + 1].Value = Valor;
                        if (item.Index % 2 == 0 && item.Index > 1)
                        {
                            dtgconten[item.Index, FilaTotal + 2].Value = valor1 < valor2 ? Math.Abs(valor2 - valor1) : 0;
                            dtgconten[item.Index + 1, FilaTotal + 2].Value = valor1 > valor2 ? Math.Abs(valor2 - valor1) : 0;
                        }
                        if (item.Index > 1)
                        {
                            dtgconten[item.Index, FilaTotal + 3].Value = (decimal)dtgconten[item.Index, FilaTotal + 1].Value + (decimal)dtgconten[item.Index, FilaTotal + 2].Value;
                        }
                    }
                }
            }
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
                NameFecha = $"MES DE {comboMesAño.FechaFinMes.ToString("MMMM")} DE {comboMesAño.FechaFinMes.ToString("yyyy")}".ToUpper();
                NameEmpresa = cboEmpresas.Text.ToUpper();
                FechaGenerado = comboMesAño.FechaFinMes.ToString("dd-MMM-yyyy");
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
        private int FilaTotal;
        private string NameEmpresa;
        private string FechaGenerado;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                _NombreHoja = $"-{NameEmpresa}-{FechaGenerado}".ToUpper(); _Cabecera = "Balance de Comprobación";
                _Columnas = new int[] { }; _NColumna = "l";
                //
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "d1", _Cabecera.ToUpper(), 14, true, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", $"{_NColumna}1", NameEmpresa.ToUpper(), 10, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", $"{_NColumna}2", "BALANCE DE COMPROBACIÓN POR MAYOR CONSOLIDADO".ToUpper(), 10, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", $"{_NColumna}3", "(MENSUAL)".ToUpper(), 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", $"{_NColumna}4", NameFecha.ToUpper(), 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a5", $"{_NColumna}5", "(EXPRESADO EN NUEVO SOLES)".ToUpper(), 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8));

                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, Configuraciones.FuenteReportesTahoma8, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, Configuraciones.FuenteReportesTahoma8, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                int PosInicialGrilla = 6;
                DataTable TablaExportar = new DataTable();
                TablaExportar = ((DataTable)dtgconten.DataSource).Copy();
                //Remuevo Columnas inservibles               
                //TablaExportar.Columns.RemoveAt(0);
                //
                //
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TablaExportar, CeldaCabecera, CeldaDefault, _NombreHoja, _Cabecera, Celdas, PosInicialGrilla, _Columnas, new int[] { }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "");
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
