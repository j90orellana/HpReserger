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
    public partial class frmPeriodos : FormGradient
    {
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public frmPeriodos()
        {
            InitializeComponent();
        }
        DataTable Estado;
        DataTable meses;
        private void frmPeriodos_Load(object sender, EventArgs e)
        {
            CargarEstado(cboestado);
            CargarMeses(cbomes);
            limpiarIngresos();
            CargarDatos();

        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CapaLogica.Periodos(0);
        }
        public void CargarMeses(ComboBox combito)
        {
            meses = HPResergerFunciones.Utilitarios.TablaMeses();
            combito.DisplayMember = "valor";
            combito.ValueMember = "codigo";
            combito.DataSource = meses;
        }
        public void CargarEstado(ComboBox combito)
        {
            Estado = new DataTable();
            Estado.Columns.Add("codigo", typeof(int));
            Estado.Columns.Add("valor");
            Estado.Rows.Add(1, "ABIERTO");
            Estado.Rows.Add(2, "CERRADO");
            Estado.Rows.Add(3, "PRELIMINAR");
            /////////////////////
            combito.DisplayMember = "valor";
            combito.ValueMember = "codigo";
            combito.DataSource = Estado;
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                txtanio.Text = dtgconten[añox.Name, x].Value.ToString();
                cboestado.SelectedValue = dtgconten[estadox.Name, x].Value;
                cbomes.SelectedValue = dtgconten[mesx.Name, x].Value;
            }
            else
            {
                limpiarIngresos();
            }
        }
        public void limpiarIngresos()
        {
            txtanio.Text = "";
            cboestado.SelectedIndex = -1;
            cbomes.SelectedIndex = -1;
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            CargarDatos();
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            if (dtgconten.RowCount > 0)
            {
                List<HPResergerFunciones.Utilitarios.NombreCelda> Celditas = new List<HPResergerFunciones.Utilitarios.NombreCelda>();
                HPResergerFunciones.Utilitarios.NombreCelda Celdita = new HPResergerFunciones.Utilitarios.NombreCelda();
                Celdita.fila = 1; Celdita.columna = 1; Celdita.Nombre = "Periodos";
                Celditas.Add(Celdita);
                //HPResergerFunciones.Utilitarios.ExportarAExcel(dtgconten, "", "Empresas", Celditas, 1, new int[] {  }, new int[] { 1 }, new int[] { });
                //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", "Periodos", Celditas, 2, new int[] { }, new int[] { 1 }, new int[] { });
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", "Periodos", Celditas, 2, new int[] { 1, 2, 8, 9, 7 }, new int[] { 1 }, new int[] { });
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

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dtgconten_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
                if (y == dtgconten.Columns[Estadosx.Name].Index)
                {
                    if (e.Value.ToString() == "CERRADO") { e.CellStyle.BackColor = Color.FromArgb(255, 199, 206); e.CellStyle.SelectionBackColor = Color.FromArgb(165, 171, 209); }
                    if (e.Value.ToString() == "ABIERTO") { e.CellStyle.BackColor = Color.FromArgb(198, 239, 206); e.CellStyle.SelectionBackColor = Color.FromArgb(128, 197, 209); }
                }
            
        }
    }
}
