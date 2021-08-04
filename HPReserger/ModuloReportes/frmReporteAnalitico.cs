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
    public partial class frmReporteAnalitico : FormGradient
    {
        public frmReporteAnalitico()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        DataTable TablaEmpresa;
        private void frmReporteAnalitico_Load(object sender, EventArgs e)
        {
            Configuraciones.CargarTextoPorDefecto(txtbusGlosa, txtbusnrodoc, txtbusrazon, txtbusruc);
            dtpfechaini.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfechafin.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpfechafin.Value = dtpfechafin.Value.AddMonths(1).AddDays(-1);
            CargarEmpresas();
        }
        public void CargarEmpresas()
        {
            chklist.Items.Clear();
            TablaEmpresa = CapaLogica.Empresa();
            chklist.Items.Add("TODAS", true);
            foreach (DataRow item in TablaEmpresa.Rows)
            {
                chklist.Items.Add(item["descripcion"].ToString(), true);
            }
        }

        private void chklist_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
            {
                if (chklist.GetItemChecked(0))
                {
                    for (int i = 1; i < chklist.Items.Count; i++)
                        chklist.SetItemChecked(i, false);
                }
                else
                {
                    for (int i = 1; i < chklist.Items.Count; i++)
                        chklist.SetItemChecked(i, true);
                }
            }
        }
        frmlistarcuentas frmlistacuenta;
        int opcionCuentas = 0;
        private void btnbusCuenta_Click(object sender, EventArgs e)
        {
            if (frmlistacuenta == null)
            {
                frmlistacuenta = new frmlistarcuentas();
                frmlistacuenta.FormClosed += Frmlistacuenta_FormClosed;
                frmlistacuenta.tipobusca = opcionCuentas;
                frmlistacuenta.Show();
            }
            else
            {
                frmlistacuenta.Activate();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Frmlistacuenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmlistacuenta.aceptar)
            {
                if (!txtbuscuenta.EstaLLeno()) txtbuscuenta.Text = "";
                if (txtbuscuenta.TextLength > 0 && txtbuscuenta.Text.Substring(txtbuscuenta.TextLength - 1, 1) != ";")
                    txtbuscuenta.Text += ";";
                txtbuscuenta.Text += frmlistacuenta.codigo;
                txtbuscuenta.SelectionStart = txtbuscuenta.TextLength;
                opcionCuentas = frmlistacuenta.tipobusca;
            }
            frmlistacuenta = null;
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

                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                _NombreHoja = $"Reporte Analítico Contable {FechaIni.ToString(Configuraciones.dd_MM_yy)}{(FechaIni == FechaFin ? "" : $" al {FechaFin.ToString(Configuraciones.dd_MM_yy)}")}";
                    
                _Cabecera = "REPORTE ANALITICO DE CUENTAS";
                _Columnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }; _NColumna = "m";

                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "a1", _Cabecera.ToUpper(), 14, true, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "PERIODO:", 10, false, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", $"De: {dtpfechaini.Value.ToShortDateString() } A: {dtpfechafin.Value.ToShortDateString()}", 10, false, false, Back, Fore));
                // Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", "Ruc:", 12, false, true, Back, Fore));
                // Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", "c3", $"{txtruc.Text}", 12, false, true, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", txtbuscuenta.Text.Length > 0 ? "CUENTA CONTABLE:" : "", 10, false, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("d3", "d3", $"{(txtbuscuenta.Text.Length > 0 ? txtbuscuenta.Text : "")}", 10, false, false, Back, Fore));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "b2", "Nombre Vendedor:", 11));
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                /////fin estilo de las celdas
                DataTable TableResult = new DataTable();
                DataView dt = ((DataTable)dtgconten.DataSource).AsDataView();
                TableResult = dt.ToTable();
                foreach (DataColumn item in TableResult.Columns) item.ColumnName = dtgconten.Columns["x" + item.ColumnName].HeaderText;
                //MACRO
                int PosInicialGrilla = 5;
                string Macro = "";
                if (chksubtotales.Checked)
                {
                    Macro = $"Private Sub Workbook_Open()  {Environment.NewLine} " +
                        $"Range(Cells({PosInicialGrilla},1),Cells({PosInicialGrilla},1)).Select {Environment.NewLine} " +
                        $"Range(Selection, Selection.End(xlToRight)).Select {Environment.NewLine} " +
                        $"Range(Selection, Selection.End(xlDown)).Select {Environment.NewLine} " +
                        $"ActiveWindow.SmallScroll Down:= -36 {Environment.NewLine} " +
                        $"ActiveWorkbook.Worksheets(\"{_NombreHoja}\").Sort.SortFields.Clear {Environment.NewLine} " +
                        $"ActiveWorkbook.Worksheets(\"{_NombreHoja}\").Sort.SortFields.Add Key:= Range(Cells({PosInicialGrilla},2), Cells({TableResult.Rows.Count + PosInicialGrilla + 1},2)), SortOn:= xlSortOnValues, Order:= xlAscending, DataOption:= xlSortNormal {Environment.NewLine} " +
                        $"ActiveWorkbook.Worksheets(\"{_NombreHoja}\").Sort.SortFields.Add Key:= Range(Cells({PosInicialGrilla},13), Cells({TableResult.Rows.Count + PosInicialGrilla + 1},13)), SortOn:= xlSortOnValues, Order:= xlAscending, DataOption:= xlSortNormal {Environment.NewLine} " +
                        $"ActiveWorkbook.Worksheets(\"{_NombreHoja}\").Sort.SortFields.Add Key:= Range(Cells({PosInicialGrilla},11), Cells({TableResult.Rows.Count + PosInicialGrilla + 1},11)), SortOn:= xlSortOnValues, Order:= xlAscending, DataOption:= xlSortNormal {Environment.NewLine} " +
                        $"ActiveWorkbook.Worksheets(\"{_NombreHoja}\").Sort.SortFields.Add Key:= Range(Cells({PosInicialGrilla},10), Cells({TableResult.Rows.Count + PosInicialGrilla + 1},10)), SortOn:= xlSortOnValues, Order:= xlAscending, DataOption:= xlSortNormal {Environment.NewLine} " +
                        $"ActiveWorkbook.Worksheets(\"{_NombreHoja}\").Sort.SortFields.Add Key:= Range(Cells({PosInicialGrilla},8), Cells({TableResult.Rows.Count + PosInicialGrilla + 1},8)), SortOn:= xlSortOnValues, Order:= xlAscending, DataOption:= xlSortNormal {Environment.NewLine} " +
                        //$"ActiveWorkbook.Worksheets(\"Reporte Analítico\").Sort.SortFields.Add Key:= Range(Cells({PosInicialGrilla},1), Cells({TableResult.Rows.Count + PosInicialGrilla + 1},1)), SortOn:= xlSortOnValues, Order:= xlAscending, DataOption:= xlSortTextAsNumbers {Environment.NewLine} " +
                        $"With ActiveWorkbook.Worksheets(\"{_NombreHoja}\").Sort {Environment.NewLine} " +
                        $".SetRange Range(Cells({PosInicialGrilla},1), Cells({TableResult.Rows.Count + PosInicialGrilla + 1},{ TableResult.Columns.Count})) {Environment.NewLine} " +
                        $".Header = xlYes {Environment.NewLine} " +
                        $".MatchCase = False {Environment.NewLine} " +
                        $".Orientation = xlTopToBottom {Environment.NewLine} " +
                        $".SortMethod = xlPinYin {Environment.NewLine} " +
                        $".Apply {Environment.NewLine} " +
                        $"End With {Environment.NewLine} " +
                        $"Selection.Subtotal GroupBy:= 14, Function:= xlSum, TotalList:= Array( 18,19), Replace:= True, PageBreaks:= False, SummaryBelowData:= True   {Environment.NewLine} " +
                        $"End Sub";
                }
                if (chkAgruparCuentas.Checked)
                {
                    Macro = $"Private Sub Workbook_Open()  {Environment.NewLine} " +
                        $"Range(Cells({PosInicialGrilla},1),Cells({PosInicialGrilla},1)).Select {Environment.NewLine} " +
                        $"Range(Selection, Selection.End(xlToRight)).Select {Environment.NewLine} " +
                        $"Range(Selection, Selection.End(xlDown)).Select {Environment.NewLine} " +
                        $"ActiveWindow.SmallScroll Down:= -36 {Environment.NewLine} " +
                        $"ActiveWorkbook.Worksheets(\"{_NombreHoja}\").Sort.SortFields.Clear {Environment.NewLine} " +
                        $"ActiveWorkbook.Worksheets(\"{_NombreHoja}\").Sort.SortFields.Add Key:= Range(Cells({PosInicialGrilla},2), Cells({TableResult.Rows.Count + PosInicialGrilla + 1},2)), SortOn:= xlSortOnValues, Order:= xlAscending, DataOption:= xlSortNormal {Environment.NewLine} " +
                        $"ActiveWorkbook.Worksheets(\"{_NombreHoja}\").Sort.SortFields.Add Key:= Range(Cells({PosInicialGrilla},3), Cells({TableResult.Rows.Count + PosInicialGrilla + 1},3)), SortOn:= xlSortOnValues, Order:= xlAscending, DataOption:= xlSortTextAsNumbers {Environment.NewLine} " +
                        $"ActiveWorkbook.Worksheets(\"{_NombreHoja}\").Sort.SortFields.Add Key:= Range(Cells({PosInicialGrilla},13), Cells({TableResult.Rows.Count + PosInicialGrilla + 1},13)), SortOn:= xlSortOnValues, Order:= xlAscending, DataOption:= xlSortNormal {Environment.NewLine} " +
                        $"ActiveWorkbook.Worksheets(\"{_NombreHoja}\").Sort.SortFields.Add Key:= Range(Cells({PosInicialGrilla},10), Cells({TableResult.Rows.Count + PosInicialGrilla + 1},10)), SortOn:= xlSortOnValues, Order:= xlAscending, DataOption:= xlSortNormal {Environment.NewLine} " +
                        $"ActiveWorkbook.Worksheets(\"{_NombreHoja}\").Sort.SortFields.Add Key:= Range(Cells({PosInicialGrilla},11), Cells({TableResult.Rows.Count + PosInicialGrilla + 1},11)), SortOn:= xlSortOnValues, Order:= xlAscending, DataOption:= xlSortNormal {Environment.NewLine} " +
                        $"ActiveWorkbook.Worksheets(\"{_NombreHoja}\").Sort.SortFields.Add Key:= Range(Cells({PosInicialGrilla},8), Cells({TableResult.Rows.Count + PosInicialGrilla + 1},8)), SortOn:= xlSortOnValues, Order:= xlAscending, DataOption:= xlSortNormal {Environment.NewLine} " +
                        $"With ActiveWorkbook.Worksheets(\"{_NombreHoja}\").Sort {Environment.NewLine} " +
                        $".SetRange Range(Cells({PosInicialGrilla},1), Cells({TableResult.Rows.Count + PosInicialGrilla + 1},{ TableResult.Columns.Count})) {Environment.NewLine} " +
                        $".Header = xlYes {Environment.NewLine} " +
                        $".MatchCase = False {Environment.NewLine} " +
                        $".Orientation = xlTopToBottom {Environment.NewLine} " +
                        $".SortMethod = xlPinYin {Environment.NewLine} " +
                        $".Apply {Environment.NewLine} " +
                        $"End With {Environment.NewLine} " +
                        $"Selection.Subtotal GroupBy:= 4, Function:= xlSum, TotalList:= Array( 18,19), Replace:= True, PageBreaks:= False, SummaryBelowData:= True   {Environment.NewLine} " +
                        $"End Sub";
                }
                ///
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableResult, CeldaCabecera, CeldaDefault, "", _NombreHoja, Celdas, PosInicialGrilla, _Columnas, new int[] { }, new int[] { 2, 3, 5, 6, 7, 8, 10, 11, 12, 13, 16, 17, 18, 19, 20, }, Macro);
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
        DateTime FechaIni, FechaFin;

        private void chksubtotales_CheckedChanged(object sender, EventArgs e)
        {
            if (chksubtotales.Checked) chkAgruparCuentas.Checked = false;
        }
        private void chkAgruparCuentas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAgruparCuentas.Checked) chksubtotales.Checked = false;
        }
        private void btngenerar_Click(object sender, EventArgs e)
        {
            if (chklist.CheckedItems.Count == 0) { msg("Seleccione una Empresa"); return; }
            if (Configuraciones.ValidarSQLInyect(txtbuscuenta, txtbusGlosa, txtbusnrodoc, txtbusrazon, txtbusruc)) { msg("Se Encontro Codigo Malisioso en las Cajas de Textos"); return; }
            Cursor = Cursors.WaitCursor;
            FechaIni = dtpfechaini.Value;
            FechaFin = dtpfechafin.Value;
            DateTime FechaAux;
            if (FechaIni > FechaFin)
            {
                FechaAux = FechaFin;
                FechaFin = FechaIni;
                FechaIni = FechaAux;
            }
            string Buscarcuenta = "";
            string BuscarEmpresa = "";
            string BuscarRuc = "";
            string BuscarRazon = "";
            string BuscarGlosa = "";
            string BuscarDocumento = "";

            if (txtbuscuenta.Text.Length > 0)
            {
                Buscarcuenta = "(";
                string[] Cuentas = txtbuscuenta.Text.Trim().Split(';');
                foreach (string cuentita in Cuentas)
                {
                    string[] Cuenta = cuentita.Split('-');
                    if (Cuenta.Length == 2)
                    {
                        if (string.CompareOrdinal(Cuenta[1], Cuenta[0]) > 1)
                            Buscarcuenta += $" a.Cuenta_Contable  between '{Cuenta[0].Trim()}' and '{Cuenta[1].Trim()}9' or ";

                        else Buscarcuenta += $" a.Cuenta_Contable  between '{Cuenta[1].Trim()}' and '{Cuenta[0].Trim()}9' or ";
                    }
                    if (Cuenta.Length == 1) { Buscarcuenta += $" a.Cuenta_Contable  like '{Cuenta[0].Trim()}%' or "; }
                }
                if (Buscarcuenta.Length > 3) Buscarcuenta = Buscarcuenta.Substring(0, Buscarcuenta.Length - 3);
                else Buscarcuenta = "(0=0";
                Buscarcuenta += ")";
            }
            else { Buscarcuenta = "( a.Cuenta_Contable  like '%%')"; }
            if (txtbusGlosa.EstaLLeno()) { BuscarGlosa = $" isnull(a.Glosa,'') like '%{txtbusGlosa.Text}%'"; }
            else { BuscarGlosa = " isnull(a.Glosa,'') like '%%'"; }
            if (txtbusrazon.EstaLLeno())
            {
                BuscarRazon = "(";
                string[] Razones = txtbusrazon.Text.Split(';');
                foreach (string Razoncita in Razones)
                {
                    string[] Razon = Razoncita.Split('-');
                    if (Razon.Length >= 1) { BuscarRazon += $" isnull(Razon_Social,'') like '%{Razon[0].Trim()}%' or "; }
                }
                if (BuscarRuc.Length > 3) BuscarRazon = BuscarRazon.Substring(0, BuscarRazon.Length - 3);
                else BuscarRuc = "(0=0";
                BuscarRazon += ")";
            }
            else { BuscarRazon = " isnull(Razon_Social,'') like '%%'"; }
            if (txtbusruc.EstaLLeno())
            {
                BuscarRuc = "(";
                string[] Rucs = txtbusruc.Text.Split(';');
                foreach (string Rucito in Rucs)
                {
                    string[] Ruc = Rucito.Split('-');
                    if (Ruc.Length >= 1) { BuscarRuc += $"isnull(Num_Doc,'') like  '%{Ruc[0].Trim()}%' or "; }
                }
                if (BuscarRuc.Length > 3) BuscarRuc = BuscarRuc.Substring(0, BuscarRuc.Length - 3);
                else BuscarRuc = "(0=0";
                BuscarRuc += ")";
            }
            else { BuscarRuc = " isnull(Num_Doc,'') like '%%'"; }
            if (txtbusnrodoc.EstaLLeno())
            {
                BuscarDocumento = "(";
                string[] Documentos = txtbusnrodoc.Text.Split(';');
                foreach (string Doc in Documentos)
                {
                    string[] Docito = Doc.Split('-');
                    if (Docito.Length >= 1) { BuscarDocumento += $"concat(isnull(ax.Cod_Comprobante,''),'-',(isnull(ax.Num_Comprobante,'')))like  '%{Docito[0].Trim()}%' or "; }
                }
                if (BuscarDocumento.Length > 3) BuscarDocumento = BuscarDocumento.Substring(0, BuscarDocumento.Length - 3);
                else BuscarDocumento = "(0=0";
                BuscarDocumento += ")";
            }
            else { BuscarDocumento = " concat(isnull(ax.Cod_Comprobante,''),'-',(isnull(ax.Num_Comprobante,''))) like '%%'"; }
            //CargarEmpresas();
            BuscarEmpresa = "(";
            foreach (object item in chklist.CheckedItems)
            {

                if (item.ToString() != "TODAS")
                {
                    DataView dv = TablaEmpresa.DefaultView;
                    dv.RowFilter = $"descripcion = '" + item.ToString() + "'";
                    DataTable TDAtos = dv.ToTable();
                    if (TDAtos.Rows.Count > 0)
                    {
                        BuscarEmpresa += $"e.Id_Empresa like  '{  TDAtos.Rows[0]["codigo"].ToString()}' or ";
                    }
                }
            }
            if (BuscarEmpresa.Length > 10)
            {
                BuscarEmpresa = BuscarEmpresa.Substring(0, BuscarEmpresa.Length - 3);
                BuscarEmpresa += ")";
            }
            else BuscarEmpresa = "e.Id_Empresa like '%%'";
            //Reporte Analítico
            dtgconten.DataSource = CapaLogica.ReporteAnalitico(FechaIni, FechaFin, Buscarcuenta, BuscarGlosa, BuscarDocumento, BuscarRuc, BuscarEmpresa, BuscarRazon);
            //
            Cursor = Cursors.Default;
            lblmensaje.Text = $"Total de Registros: {dtgconten.RowCount}";
            if (dtgconten.RowCount == 0) msg("No Hay Registros");
        }
    }
}

