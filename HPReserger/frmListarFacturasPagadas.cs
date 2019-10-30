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
    public partial class frmListarFacturasPagadas : FormGradient
    {
        public frmListarFacturasPagadas()
        {
            //CartelDeEspera("Cargando...");
            //Application.DoEvents();
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void frmListarFacturasPagadas_Load(object sender, EventArgs e)
        {
            cboempresa_Click(sender, e);
            dtpini.Value = dtinicio.Value = DateTime.Now.AddMonths(-1);
        }
        public void ListarPagados()
        {
            //if (true)
            //{
            Dtguias.Columns[FechaCancelado.Name].HeaderText = "Fecha Pagado";
            Dtguias.Columns[Pagox.Name].HeaderText = "Pagado";
            Dtguias.Columns[OK.Name].Visible = false;
            Dtguias.Columns[btnVer.Name].Visible = false;
            Dtguias.Columns[Saldox.Name].Visible = false;
            Dtguias.Columns[xtc.Name].Visible = false;
            Dtguias.Columns[Pagox.Name].ReadOnly = true;
            //btnseleccion.Visible = false;
            //btnaceptar.Enabled = false;
            //txtbuscar_TextChanged(new object { }, new EventArgs());
            //}
            //else
            //{
            //    Dtguias.Columns[FechaCancelado.Name].HeaderText = "Fecha Cancelado";
            //    Dtguias.Columns[Pagox.Name].HeaderText = "Pago";
            //    Dtguias.Columns[btnVer.Name].Visible = true;
            //    Dtguias.Columns[Saldox.Name].Visible = true;
            //    Dtguias.Columns[xtc.Name].Visible = true;
            //    Dtguias.Columns[OK.Name].Visible = true;
            //btnseleccion.Visible = true;
            //Dtguias.Columns[Pagox.Name].ReadOnly = false;
            //txtbuscar_TextChanged(new object { }, new EventArgs());
            //}
        }
        private void cboempresa_Click(object sender, EventArgs e)
        {
            string cadena = cboempresa.Text;
            DataTable Table = CapaLogica.TablaEmpresa();
            if (Table.Rows.Count != cboempresa.Items.Count)
            {
                CapaLogica.TablaEmpresa(cboempresa);
                cboempresa.Text = cadena;
            }
        }
        frmProcesando frmproce;
        public void CartelDeEspera(string Texto)
        {
            frmproce = new frmProcesando(Texto);
            frmproce.Show();
        }
        public void CartelDeEspera()
        {
            frmproce = new frmProcesando("Cargando...");
            frmproce.Show();
        }
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboempresa.SelectedValue != null)
            {
                CartelDeEspera("Cargando...");
                NameEmpresa = cboempresa.Text;
                Application.DoEvents();
                ActualizarTablas();
            }
        }
        int prove = 0;
        private void chkprove_CheckedChanged(object sender, EventArgs e)
        {
            txtbuscar.ReadOnly = true;
            prove = 0;
            if (chkprove.Checked)
            {
                prove = 1;
                txtbuscar.ReadOnly = false;
            }
            CargarDatos();
        }
        int fecha = 0;
        private void chkfecha_CheckedChanged(object sender, EventArgs e)
        {
            dtinicio.Enabled = dtfin.Enabled = false;
            fecha = 0;
            if (chkfecha.Checked)
            {
                fecha = 1;
                dtinicio.Enabled = dtfin.Enabled = true;
            }
            CargarDatos();
        }
        int recepcion = 0;
        private void chkrecepcion_CheckedChanged(object sender, EventArgs e)
        {
            dtpini.Enabled = dtpfin.Enabled = false;
            recepcion = 0;
            if (chkrecepcion.Checked)
            {
                recepcion = 1;
                dtpini.Enabled = dtpfin.Enabled = true;
            }
            CargarDatos();
        }
        DateTime auxtmp;
        public void CargarDatos()
        {
            if (dtfin.Value < dtinicio.Value)
            {
                auxtmp = dtfin.Value;
                dtfin.Value = dtinicio.Value;
                dtinicio.Value = auxtmp;
            }
            if (dtpfin.Value < dtpini.Value)
            {
                auxtmp = dtpfin.Value;
                dtpfin.Value = dtpini.Value;
                dtpini.Value = auxtmp;
            }
            if (cboempresa.SelectedValue != null)
            {
                SacarDatosFiltrados();
                //Dtguias.DataSource = CapaLogica.ListarFacturasPagadosxEmpresa(prove, txtbuscar.Text, fecha, dtinicio.Value, dtfin.Value, recepcion, dtpini.Value, dtpfin.Value, 0, (int)cboempresa.SelectedValue);
            }
            ContarRegistros();
        }
        public void SacarDatosFiltrados()
        {
            string filter = "";
            if (prove == 1)
            {
                filter = $"(proveedor like '%{txtbuscar.TextValido() }%' or razon like '%{txtbuscar.TextValido()}%')";
            }
            if (fecha == 1)
            {
                filter += $" {(prove == 1 ? "and" : "")} fechacancelado  >= '{Configuraciones.ToFechaSql(dtinicio.Value)}' and fechacancelado  <= '{Configuraciones.ToFechaSql(dtfin.Value)}'";
            }
            if (recepcion == 1)
            {
                filter += $" {(prove == 1 || fecha == 1 ? "and" : "")} fecharecepcion >= '{Configuraciones.ToFechaSql(dtpini.Value)}' and fecharecepcion <= '{Configuraciones.ToFechaSql(dtpfin.Value)}'";
            }
            DataTable TableFiltrada;
            DataView dv = TablaPagados.DefaultView;
            dv.RowFilter = filter;
            //Datos Filtrados
            TableFiltrada = dv.ToTable();
            Dtguias.DataSource = TableFiltrada;
            //}
        }
        public void ContarRegistros()
        {
            lblmensaje.Text = $"Número de Registros: {Dtguias.RowCount} ";
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cboempresa_SelectedIndexChanged(sender, e);
            //ActualizarTablas();
        }

        DataTable TablaPagados;
        DataTable TablaPorPagar;

        public string NameEmpresa { get; private set; }

        public void ActualizarTablas()
        {
            //TablaPorPagar = CapaLogica.ListarFacturasPorPagarxEmpresa(0, txtbuscar.Text, 0, dtinicio.Value, dtfin.Value, 0, dtpini.Value, dtpfin.Value, 0, (int)cboempresa.SelectedValue);
            TablaPagados = CapaLogica.ListarFacturasPagadosxEmpresa(0, txtbuscar.Text, 0, dtinicio.Value, dtfin.Value, 0, dtpini.Value, dtpfin.Value, 0, (int)cboempresa.SelectedValue);
            Dtguias.DataSource = TablaPagados;
            ContarRegistros();
            frmproce.Close();
            //Filtros
            SacarDatosFiltrados();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Dtguias.RowCount > 0)
            {
                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";

                _NombreHoja = "Documentos Pagados"; _Cabecera = "Comprobantes Pagados"; _Columnas = new int[] { 3, 4, 5, 6, 8, 9, 10, 11, 12, 14, 15, 16, 17 }; _NColumna = "m";

                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", $"{_NColumna}1", _Cabecera.ToUpper(), 16, true, true, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", $"{_NColumna}2", NameEmpresa, 12, false, true, Back, Fore));
                //
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(Dtguias.AlternatingRowsDefaultCellStyle.BackColor, Dtguias.AlternatingRowsDefaultCellStyle.Font, Dtguias.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(Dtguias.ColumnHeadersDefaultCellStyle.BackColor, Dtguias.ColumnHeadersDefaultCellStyle.Font, Dtguias.ColumnHeadersDefaultCellStyle.ForeColor);
                int PosInicialGrilla = 3;
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "b2", "Nombre Vendedor:", 11));
                //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(Dtguias, "", _NombreHoja, Celdas, 2, _Columnas, new int[] { }, new int[] { });

                DataTable TableResuk = new DataTable();
                TableResuk = ((DataTable)Dtguias.DataSource).Copy();

                TableResuk.Columns[FechaCancelado.Name].ColumnName = "Fecha Cancelado";
                TableResuk.Columns["Pago"].ColumnName = "Pago";

                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableResuk, CeldaCabecera, CeldaDefault, "", _NombreHoja, Celdas, PosInicialGrilla, _Columnas, new int[] { }, new int[] { }, "");

                //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", "Cronograma de Pagos", Celdas, 2, new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { }, new int[] { });
            }
            else msg("No hay Registros en la Grilla");
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
            Dtguias.ResumeLayout();
        }
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtbuscar_TextChanged_1(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dtinicio_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dtfin_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dtpini_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dtpfin_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            if (Dtguias.RowCount > 0)
            {
                Dtguias.SuspendLayout();
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

        private void Dtguias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow R = Dtguias.Rows[e.RowIndex];
                if (e.ColumnIndex == Dtguias.Columns[btnVer.Name].Index)
                {
                    if (R.Cells[fkasientox.Name].Value.ToString() != "")
                    {
                        ModuloContable.frmListadoAsientosContables frmReportito = new ModuloContable.frmListadoAsientosContables((int)cboempresa.SelectedValue, R.Cells[fkasientox.Name].Value.ToString(), (DateTime)R.Cells[FechaCancelado.Name].Value);
                        frmReportito.MdiParent = this.MdiParent;
                        frmReportito.Show();
                    }
                }
            }
        }
    }
}
