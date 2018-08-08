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
    public partial class frmListarAsientosAbiertos : FormGradient
    {
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public frmListarAsientosAbiertos()
        {
            InitializeComponent();
        }
        public frmListarAsientosAbiertos(int _empresa, DateTime _fecha)
        {
            InitializeComponent();
            idempresa = _empresa;
            fecha = _fecha;
        }
        private void frmListarAsientosAbiertos_Load(object sender, EventArgs e)
        {
            CargarDatosAsientos();
            if (dtgconten.RowCount == 0) { cerrado = 1; btncancelar_Click(sender, e); }
        }
        public int idempresa { get; set; }
        public DateTime fecha { get; set; }
        public int cerrado { get; set; }
        public void CargarDatosAsientos()
        {
            cerrado = 0;
            dtgconten.DataSource = CapaLogica.ListarAsientosAbiertos(0, idempresa, fecha);
            ///si no hay datos

        }
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            CargarDatosAsientos();
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgconten_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                frmAsientoContable asientito = new frmAsientoContable();
                asientito.FormClosed += Asientito_FormClosed;
                asientito.MdiParent = MdiParent;
                asientito.Show();
                asientito.BuscarAsiento(dtgconten[idAsientoContableDataGridViewTextBoxColumn.Name, x].Value.ToString(), (int)dtgconten[idEmpresaDataGridViewTextBoxColumn.Name, x].Value);
            }
        }

        private void Asientito_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnactualizar_Click(sender, e);
        }

        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                if (y == dtgconten.Columns[btnAbrirx.Name].Index)
                    dtgconten_CellContentDoubleClick(sender, e);
            }
        }
        frmProcesando frmproce;
        private void button1_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
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

                List<HPResergerFunciones.Utilitarios.NombreCelda> Celditas = new List<HPResergerFunciones.Utilitarios.NombreCelda>();
                HPResergerFunciones.Utilitarios.NombreCelda Celdita = new HPResergerFunciones.Utilitarios.NombreCelda();
                Celdita.fila = 1; Celdita.columna = 1; Celdita.Nombre = "ASIENTOS ABIERTOS";
                Celditas.Add(Celdita);
                //HPResergerFunciones.Utilitarios.ExportarAExcel(dtgconten, "", "Empresas", Celditas, 1, new int[] {  }, new int[] { 1 }, new int[] { });
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", "Asientos Abiertos", Celditas, 2, new int[] { 3, 6, 7, 8, 9 }, new int[] { 1 }, new int[] { });
            }
            else
            {
                msg("No hay Datos");
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
        }
    }
}
