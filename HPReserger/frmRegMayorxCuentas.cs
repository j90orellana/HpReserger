﻿using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HPReserger
{
    public partial class frmRegMayorxCuentas : FormGradient
    {
        public frmRegMayorxCuentas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmRegMayorxCuentas_Load(object sender, EventArgs e)
        {
            Configuraciones.CargarTextoPorDefecto(txtbuscuenta, txtbusGlosa, txtbusnrodoc, txtbusrazon, txtbusruc);
            dtpfechaini.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfechafin.Value = new DateTime(DateTime.Now.Year, 12, 31);
            CargarEmpresas();
        }
        DataTable TablaEmpresa;
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
        public void msg(string cadena) { HPResergerFunciones.Utilitarios.msg(cadena); }
        DateTime FechaIni;
        DateTime FechaFin;
        private void btngenerar_Click(object sender, EventArgs e)
        {
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

            if (txtbuscuenta.EstaLLeno())
            {
                Buscarcuenta = "(";
                string[] Cuentas = txtbuscuenta.Text.Split(';');
                foreach (string cuentita in Cuentas)
                {
                    string[] Cuenta = cuentita.Split('-');
                    if (Cuenta.Length == 2)
                    {
                        if (string.CompareOrdinal(Cuenta[1], Cuenta[0]) > 1)
                            Buscarcuenta += $" X.Cuenta_Contable  between '{Cuenta[0]}' and '{Cuenta[1]}9' or ";

                        else Buscarcuenta += $" X.Cuenta_Contable  between '{Cuenta[1]}' and '{Cuenta[0]}9' or ";
                    }
                    if (Cuenta.Length == 1) { Buscarcuenta += $" X.Cuenta_Contable  like'{Cuenta[0]}%' or "; }
                }
                if (Buscarcuenta.Length > 3) Buscarcuenta = Buscarcuenta.Substring(0, Buscarcuenta.Length - 3);
                else Buscarcuenta = "(0=0";
                Buscarcuenta += ")";
            }
            else { Buscarcuenta = "( X.Cuenta_Contable  like '%%')"; }
            if (txtbusGlosa.EstaLLeno()) { BuscarGlosa = $" isnull(f.Glosa,'') like '%{txtbusGlosa.Text}%'"; }
            else { BuscarGlosa = " isnull(f.Glosa,'') like '%%'"; }
            if (txtbusrazon.EstaLLeno())
            {
                BuscarRazon = "(";
                string[] Razones = txtbusrazon.Text.Split(';');
                foreach (string Razoncita in Razones)
                {
                    string[] Razon = Razoncita.Split('-');
                    if (Razon.Length >= 1) { BuscarRazon += $"isnull(Razon_Social,'') like '%{Razon[0]}%' or "; }
                }
                if (BuscarRuc.Length > 3) BuscarRazon = BuscarRazon.Substring(0, BuscarRazon.Length - 3);
                else BuscarRuc = "(0=0";
                BuscarRazon += ")";
            }
            else { BuscarRazon = "isnull(Razon_Social,'') like '%%'"; }
            if (txtbusruc.EstaLLeno())
            {
                BuscarRuc = "(";
                string[] Rucs = txtbusruc.Text.Split(';');
                foreach (string Rucito in Rucs)
                {
                    string[] Ruc = Rucito.Split('-');
                    if (Ruc.Length >= 1) { BuscarRuc += $"isnull(Num_Doc,'') like  '%{Ruc[0]}%' or "; }
                }
                if (BuscarRuc.Length > 3) BuscarRuc = BuscarRuc.Substring(0, BuscarRuc.Length - 3);
                else BuscarRuc = "(0=0";
                BuscarRuc += ")";
            }
            else { BuscarRuc = "isnull(Num_Doc,'') like '%%'"; }
            if (txtbusnrodoc.EstaLLeno())
            {
                BuscarDocumento = "(";
                string[] Documentos = txtbusnrodoc.Text.Split(';');
                foreach (string Doc in Documentos)
                {
                    string[] Docito = Doc.Split('-');
                    if (Docito.Length >= 1) { BuscarDocumento += $"concat(isnull(f.Cod_Comprobante,''),'-',(isnull(f.Num_Comprobante,'')))like  '%{Docito[0]}%' or "; }
                }
                if (BuscarDocumento.Length > 3) BuscarDocumento = BuscarDocumento.Substring(0, BuscarDocumento.Length - 3);
                else BuscarDocumento = "(0=0";
                BuscarDocumento += ")";
            }
            else { BuscarDocumento = " concat(isnull(f.Cod_Comprobante,''),'-',(isnull(f.Num_Comprobante,''))) like '%%'"; }
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
            /////ASIGNACION DE LOS DATOS
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            dtgconten.DataSource = CapaLogica.MayorPorCuentas(FechaIni, FechaFin, Buscarcuenta, BuscarGlosa, BuscarDocumento, BuscarRuc, BuscarEmpresa, BuscarRazon);
            //Configuraciones.TiempoEjecucionMsg(stopwatch); stopwatch.Stop();
            //dtgconten.AutoGenerateColumns = true;            
            //dtgconten.DataMember = "cuenta_contable";
            Cursor = Cursors.Default;
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
                _NombreHoja = "Mayor x Cuentas"; _Cabecera = "MAYOR POR CUENTAS CONTABLES";
                _Columnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }; _NColumna = "m";

                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "a1", _Cabecera.ToUpper(), 16, true, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "PERIODO:", 12, false, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", $"De: {dtpfechaini.Value.ToShortDateString() } A: {dtpfechafin.Value.ToShortDateString()}", 12, false, false, Back, Fore));
                // Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", "Ruc:", 12, false, true, Back, Fore));
                // Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", "c3", $"{txtruc.Text}", 12, false, true, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a4", "a4", txtbuscuenta.EstaLLeno() ? "CUENTA CONTABLE:" : "", 12, false, false, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("d4", "d4", $"{(txtbuscuenta.EstaLLeno() ? txtbuscuenta.Text : "")}", 12, false, false, Back, Fore));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "b2", "Nombre Vendedor:", 11));
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, dtgconten.ColumnHeadersDefaultCellStyle.Font, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                /////fin estilo de las celdas
                DataTable TableResult = new DataTable();
                DataView dt = ((DataTable)dtgconten.DataSource).AsDataView();
                TableResult = dt.ToTable();
                foreach (DataColumn item in TableResult.Columns) item.ColumnName = dtgconten.Columns["x" + item.ColumnName].HeaderText;
                //MACRO
                int PosInicialGrilla = 5;
                string Macro = $"Private Sub Workbook_Open()  {Environment.NewLine} " +
                    $"Range(Cells({PosInicialGrilla}, 1), Cells({TableResult.Rows.Count + PosInicialGrilla + 1},{ TableResult.Columns.Count})).Select  {Environment.NewLine}" +
                    $"Selection.Subtotal GroupBy:= 3, Function:= xlSum, TotalList:= Array(19, 20), Replace:= True, PageBreaks:= False, SummaryBelowData:= True   {Environment.NewLine} End Sub";
                ///
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableResult, CeldaCabecera, CeldaDefault, "", _NombreHoja, Celdas, PosInicialGrilla, _Columnas, new int[] { }, new int[] { }, chksubtotales.Checked ? Macro : "");
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
            //else
            //{
            //    chklist.SetItemCheckState(0, CheckState.Indeterminate);
            //}
        }

        private void chklist_Enter(object sender, EventArgs e)
        {
            //chklist.Height = 200;
        }
        private void chklist_Leave(object sender, EventArgs e)
        {
            //chklist.Height = 18;
        }
        private void frmRegMayorxCuentas_Click(object sender, EventArgs e)
        {
            chklist_Leave(sender, e);
            btngenerar.Focus();
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
    }
}
