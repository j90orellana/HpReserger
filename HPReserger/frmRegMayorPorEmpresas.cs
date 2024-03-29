﻿using HpResergerUserControls;
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
    public partial class frmRegMayorPorEmpresas : FormGradient
    {
        public frmRegMayorPorEmpresas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void frmRegMayorPorEmpresas_Load(object sender, EventArgs e)
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
                txtruc.Text = Fila["ruc"].ToString();
            }
            else
            {
                txtruc.CargarTextoporDefecto();
            }
        }
        private void btngenerar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FechaPeriodo = comboMesAño1.GetFechaPRimerDia();
            NombreEmpresa = cboempresa.Text;
            if (cboempresa.Items.Count == 0) { msg("No hay Empresas"); return; }
            if (cboempresa.SelectedValue == null) { msg("Seleccion una Empresa"); cboempresa.Focus(); return; }
            dtgconten.DataSource = CapaLogica.MayorCuentasxEmpresas((int)cboempresa.SelectedValue, comboMesAño1.getMesNumero(), comboMesAño1.GetFecha().Year);
            lblmensaje.Text = $"Total de Registros: {dtgconten.RowCount}";
            Cursor = Cursors.Default;
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
                _NombreHoja = "Mayor de Cuentas"; _Cabecera = "MAYOR DE CUENTAS CONTABLES";
                _Columnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 }; _NColumna = "m";

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
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("d4", "d4", $"{NombreEmpresa}", 12, false, false, Back, Fore));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "b2", "Nombre Vendedor:", 11));
                ///////estilos de la celdas
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, dtgconten.ColumnHeadersDefaultCellStyle.Font, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                /////fin estilo de las celdas
                DataTable TableResult = new DataTable(); DataView dt = ((DataTable)dtgconten.DataSource).AsDataView(); TableResult = dt.ToTable();
                ///Tabla
                foreach (DataColumn item in TableResult.Columns) { item.ColumnName = dtgconten.Columns[item.ColumnName].HeaderText; }
                /////
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableResult, CeldaCabecera, CeldaDefault, "", _NombreHoja, Celdas, 5, _Columnas, new int[] { }, new int[] { }, "");
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
    }
}
