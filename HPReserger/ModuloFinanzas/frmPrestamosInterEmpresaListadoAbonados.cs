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

namespace HPReserger.ModuloFinanzas
{
    public partial class frmPrestamosInterEmpresaListadoAbonados : FormGradient
    {
        public frmPrestamosInterEmpresaListadoAbonados()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        private void frmPrestamosInterEmpresaListadoAbonados_Load(object sender, EventArgs e)
        {
            //Carga Datos Principales 
            Busqueda = false;
            //Periodo Anual para la Busqueda
            dtpfechabus1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfechabus2.Value = new DateTime(DateTime.Now.Year, 12, 31);
            txtbusMoneda.CargarTextoporDefecto(); txtbusempresaorigen.CargarTextoporDefecto(); txtbusempresadestino.CargarTextoporDefecto();
            Busqueda = true;
            SacarDatos();
        }
        public void SacarDatos()
        {
            if (Busqueda)
            {
                DateTime fechaaux = dtpfechabus1.Value;
                DateTime fecha1 = dtpfechabus1.Value;
                DateTime fecha2 = dtpfechabus2.Value;
                if (fecha1 > fecha2)
                {
                    fecha1 = fecha2;
                    fecha2 = fechaaux;
                }
                dtgconten.DataSource = CapaLogica.PrestamoInterEmpresa_Listado(txtbusempresaorigen.TextValido(), txtbusempresadestino.TextValido(), txtbusMoneda.TextValido(), fecha1, fecha2);
                lblmsg.Text = $"Total de Registros : {dtgconten.RowCount}";
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SacarDatos();
        }
        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {

                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                _NombreHoja = "Listado de Abonos de Prestamos"; _Cabecera = "LISTADO DE ABONOS DE PRESTAMOS INTEREMPRESA";
                _Columnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }; _NColumna = "m";

                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("c1", "c1", _Cabecera.ToUpper(), 16, true, false, Back, Fore));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "PERIODO:", 12, false, false, Back, Fore));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", $"De: {dtpfechaini.Value.ToShortDateString() } A: {dtpfechafin.Value.ToShortDateString()}", 12, false, false, Back, Fore));
                // Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", "Ruc:", 12, false, true, Back, Fore));
                // Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", "c3", $"{txtruc.Text}", 12, false, true, Back, Fore));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", txtbuscuenta.Text.Length > 0 ? "CUENTA CONTABLE:" : "", 12, false, false, Back, Fore));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("d3", "d3", $"{(txtbuscuenta.Text.Length > 0 ? txtbuscuenta.Text : "")}", 12, false, false, Back, Fore));
                ////Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "b2", "Nombre Vendedor:", 11));
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, dtgconten.ColumnHeadersDefaultCellStyle.Font, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                /////fin estilo de las celdas
                DataTable TableResult = new DataTable();
                DataView dt = ((DataTable)dtgconten.DataSource).AsDataView();
                TableResult = dt.ToTable();
                //foreach (DataColumn item in TableResult.Columns) item.ColumnName = dtgconten.Columns["x" + item.ColumnName].HeaderText;
                //MACRO
                int PosInicialGrilla = 3;
                string Macro = "";
                ///
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableResult, CeldaCabecera, CeldaDefault, "", _NombreHoja, Celdas, PosInicialGrilla, _Columnas, new int[] { }, new int[] { 1, 2, 4, 5, 6, 8, 9, 10, 11, 12, 13 }, Macro);
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
        frmProcesando frmproce;
        private bool Busqueda;
        
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

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            Busqueda = false;
            string cadena = txtbusempresadestino.TextValido();
            txtbusempresadestino.Text = txtbusempresaorigen.TextValido() == "" ? txtbusempresadestino.TextoPorDefecto : txtbusempresaorigen.TextValido();
            txtbusempresaorigen.Text = cadena == "" ? txtbusempresaorigen.TextoPorDefecto : cadena;
            Busqueda = true;
            SacarDatos();
        }
        private void btncleanfind_Click(object sender, EventArgs e)
        {
            Busqueda = false;
            txtbusempresadestino.CargarTextoporDefecto();
            txtbusMoneda.CargarTextoporDefecto();
            txtbusempresaorigen.CargarTextoporDefecto();
            dtpfechabus1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfechabus2.Value = new DateTime(DateTime.Now.Year, 12, 31);
            Busqueda = true;
            SacarDatos();
            //dtpfechabus1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            //dtpfechabus2.Value = new DateTime(DateTime.Now.Year, 12, 31);
            //chkAnulado.Checked = false; chkCancelado.Checked = false;
        }
        private void txtbusMoneda_TextChanged(object sender, EventArgs e)
        {
            SacarDatos();
        }
        private void txtbusempresadestino_TextChanged(object sender, EventArgs e)
        {
            SacarDatos();
        }
        private void txtbusempresaorigen_TextChanged(object sender, EventArgs e)
        {
            SacarDatos();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpfechabus1_ValueChanged(object sender, EventArgs e)
        {
            SacarDatos();
        }

        private void dtpfechabus2_ValueChanged(object sender, EventArgs e)
        {
            SacarDatos();
        }
    }
}
