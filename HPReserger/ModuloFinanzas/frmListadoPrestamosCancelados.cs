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
    public partial class frmListadoPrestamosCancelados : FormGradient
    {
        public frmListadoPrestamosCancelados()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private bool Busqueda;

        private void frmListadoPrestamosCancelados_Load(object sender, EventArgs e)
        {
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
                dtgconten.DataSource = CapaLogica.PrestamosInterEmpresa(0, txtbusempresaorigen.TextValido(), txtbusempresadestino.TextValido(), txtbusMoneda.TextValido(), fecha1, fecha2, -1, 3, -1);
                lblmensaje.Text = $"Total Registros: {dtgconten.RowCount}";
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SacarDatos();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncleanfind_Click(object sender, EventArgs e)
        {
            Busqueda = false;
            dtpfechabus1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfechabus2.Value = new DateTime(DateTime.Now.Year, 12, 31);
            txtbusempresadestino.CargarTextoporDefecto();
            txtbusMoneda.CargarTextoporDefecto();
            txtbusempresaorigen.CargarTextoporDefecto();
            Busqueda = true;
            SacarDatos();
        }

        private void txtbusempresadestino_TextChanged(object sender, EventArgs e)
        {
            SacarDatos();
        }
        private void txtbusMoneda_TextChanged(object sender, EventArgs e)
        {
            SacarDatos();
        }
        private void txtbusempresaorigen_TextChanged(object sender, EventArgs e)
        {
            SacarDatos();
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
        private void msg(string v)
        {
            HPResergerFunciones.Utilitarios.msg(v);
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                _NombreHoja = "Prestamos InterEmpresa Cancelados"; _Cabecera = "Listado de Prestamos InterEmpresa Cancelados";
                _Columnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }; _NColumna = "m";
                //
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("d1", "d1", _Cabecera.ToUpper(), 16, true, false, Back, Fore));
                //
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, dtgconten.ColumnHeadersDefaultCellStyle.Font, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                int PosInicialGrilla = 2;
                DataTable TablaExportar = new DataTable();
                TablaExportar = ((DataTable)dtgconten.DataSource).Copy();
                ///Remuevo Columnas inservibles
                TablaExportar.Columns.RemoveAt(30);
                TablaExportar.Columns.RemoveAt(23);
                TablaExportar.Columns.RemoveAt(19);
                TablaExportar.Columns.RemoveAt(18);
                TablaExportar.Columns.RemoveAt(16);
                TablaExportar.Columns.RemoveAt(15);
                TablaExportar.Columns.RemoveAt(14);
                TablaExportar.Columns.RemoveAt(12);
                TablaExportar.Columns.RemoveAt(8);
                TablaExportar.Columns.RemoveAt(7);
                TablaExportar.Columns.RemoveAt(5);
                TablaExportar.Columns.RemoveAt(4);
                TablaExportar.Columns.RemoveAt(3);
                TablaExportar.Columns.RemoveAt(1);
                //TablaExportar.Columns.RemoveAt(0);
                ///
                ///
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TablaExportar, CeldaCabecera, CeldaDefault, _NombreHoja, _NombreHoja, Celdas, PosInicialGrilla, _Columnas, new int[] { }, new int[] { 1, 2, 3, 5, 6, 7, 8, 10, 11, 12, 13, 14, 15, 16, 18 }, "");
            }
            else msg("No hay datos que Exportar");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
            dtgconten.ResumeLayout();
        }

        private void dtpfechabus2_ValueChanged(object sender, EventArgs e)
        {
            SacarDatos();
        }

        private void dtpfechabus1_ValueChanged(object sender, EventArgs e)
        {
            SacarDatos();
        }
    }
}
