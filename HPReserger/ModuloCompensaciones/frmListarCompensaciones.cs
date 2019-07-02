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

namespace HPReserger.ModuloCompensaciones
{
    public partial class frmListarCompensaciones : FormGradient
    {
        public frmListarCompensaciones()
        {
            InitializeComponent();
            CargarEmpresa();
            CargarTipoid();
            cbotipoid.SelectedIndex = 0;
            CargarCompensaciones();
        }
        public frmListarCompensaciones(int idempresa)
        {
            InitializeComponent();
            CargarCompensaciones();
            CargarEmpresa();
            CargarTipoid();
            cbotipoid.SelectedIndex = 0;
            IdEmpresa = idempresa;
            SacarDatos();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmListarCompensaciones_Load(object sender, EventArgs e)
        {

        }
        public void CargarEmpresa() { CapaLogica.TablaEmpresa(cboempresa); }
        public void CargarTipoid()
        {
            CapaLogica.TablaTipoID(cbotipoid);
            DataTable TableTipos = ((DataTable)cbotipoid.DataSource);
            DataRow fila = TableTipos.NewRow();
            fila["valor"] = "TODOS";
            fila["Codigo"] = 0;
            TableTipos.Rows.InsertAt(fila, 0);
        }
        public int IdEmpresa { get { return (int)cboempresa.SelectedValue; } set { cboempresa.SelectedValue = value; } }
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboempresa.SelectedValue != null)
                SacarDatos();
        }
        public void CargarCompensaciones()
        {
            DataTable ListCompensaciones = new DataTable();
            ListCompensaciones.Columns.Add("codigo", typeof(int));
            ListCompensaciones.Columns.Add("descripcion");
            ListCompensaciones.Rows.Add(0, "Todos");
            ListCompensaciones.Rows.Add(1, "Fondo Fijo");
            ListCompensaciones.Rows.Add(2, "Reembolso Gasto");
            ListCompensaciones.Rows.Add(3, "Entregas a Rendir");
            ListCompensaciones.Rows.Add(4, "Anticipo Proveedor");
            cbocompensa.ValueMember = "codigo";
            cbocompensa.DisplayMember = "descripcion";
            cbocompensa.DataSource = ListCompensaciones;
            cbocompensa.SelectedIndex = 0;
        }
        public void SacarDatos()
        {
            if (cbocompensa.SelectedValue == null) return;
            if (cbotipoid.SelectedValue == null) return;
            if (cbocompensa.SelectedValue == null) return;
            dtgconten.DataSource = CapaLogica.ListarCompensaciones(IdEmpresa, (int)cbocompensa.SelectedValue, (int)cbotipoid.SelectedValue, txtbuscarnombre.TextValido());
            lbltotalregistros.Text = $"Total de Registros {dtgconten.RowCount}";
            decimal Soles = 0, Dolares = 0;
            decimal RegSoles = 0, RegDolares = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if ((int)item.Cells[xEstado.Name].Value == 2)
                {
                    Soles += (decimal)item.Cells[xMontoMN.Name].Value;
                    Dolares += (decimal)item.Cells[xMontoME.Name].Value;
                }
                if (item.Cells[xNameEstado.Name].Value.ToString() == "Regularizado")
                {
                    RegSoles += (decimal)item.Cells[xMontoMN.Name].Value;
                    RegDolares += (decimal)item.Cells[xMontoME.Name].Value;
                }
            }
            txtMontoMN.Text = Soles.ToString("n2"); txtMontoME.Text = Dolares.ToString("n2");
            txtRegularMN.Text = RegSoles.ToString("n2"); txtRegularME.Text = RegDolares.ToString("n2");
        }
        private void txtbuscarnombre_TextChanged(object sender, EventArgs e)
        {
            SacarDatos();
        }
        private void cbotipoid_SelectedIndexChanged(object sender, EventArgs e)
        {
            SacarDatos();
        }
        private void cbocompensa_SelectedIndexChanged(object sender, EventArgs e)
        {
            SacarDatos();
        }
        private void cboempresa_Click(object sender, EventArgs e)
        {
            string cadena = cboempresa.Text;
            DataTable Table = CapaLogica.Empresa();
            if (cboempresa.Items.Count != Table.Rows.Count)
            {
                cboempresa.DataSource = Table;
                cboempresa.Text = cadena;
            }
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                _NombreHoja = "Listado Compensaciones"; _Cabecera = "Compensaciones";
                _Columnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }; _NColumna = "m";
                //
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", _Cabecera.ToUpper(), 16, true, false, Back, Fore));
                //
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, dtgconten.ColumnHeadersDefaultCellStyle.Font, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                int PosInicialGrilla = 3;
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas((DataTable)dtgconten.DataSource, CeldaCabecera, CeldaDefault, "", _NombreHoja, Celdas, PosInicialGrilla, _Columnas, new int[] { }, new int[] { }, "");
            }
            else msg("No hay datos que Exportar");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
            dtgconten.ResumeLayout();
        }
        HPReserger.frmProcesando frmproce;
        private void btnExportarPlan_Click(object sender, EventArgs e)
        {
            if (dtgconten.Rows.Count > 0)
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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
