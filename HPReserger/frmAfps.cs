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
    public partial class frmAfpsComisiones : FormGradient
    {
        public frmAfpsComisiones()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public int Estado
        {
            get { return estado; }
            set
            {
                estado = value;
                btnaceptar.Enabled = false;
                dtgconten.ReadOnly = true;
                btnmodificar.Enabled = true;
                cboperiodo.Enabled = false;
                btnPaso1.Enabled = false;
                dtgconten.Columns[xPeriodo.Name].ReadOnly = true;
                dtgconten.Columns[xAfp.Name].ReadOnly = true;
                if (estado == 1)
                {
                    cboperiodo.Enabled = true;
                    btnPaso1.Enabled = true;
                    btnmodificar.Enabled = false;
                }
                if (estado == 2)
                {
                    btnaceptar.Enabled = true;
                    dtgconten.ReadOnly = false;
                    btnmodificar.Enabled = false;
                    Configuraciones.CambiarReadOnlyGrilla(dtgconten, true, xAfp, xPeriodo);
                }
                //if (estado == 0)
                //    if (TDatos != null)
                //        dtgconten.DataSource = TDatos.Clone();
            }
        }
        private int estado = 0;
        public void iniciar(Boolean a)
        {
            btnmodificar.Enabled = !a;
            btnaceptar.Enabled = a;
            dtgconten.Enabled = !a;
            btneliminar.Enabled = !a;
        }
        DataTable TDatos;
        public void CargarDatos()
        {
            TDatos = CapaLogica.InsertarActualizarListarAfp(0, 0, "0", 0, 0, 0, DateTime.Now, 0, 0);
            dtgconten.DataSource = TDatos;
            dtgconten.Focus();
            lbltotalRegistros.Text = $"Total Registos: {dtgconten.RowCount}";
            PintarDeColoresValoresUnicos(dtgconten, xPeriodo);

        }
        private void PintarDeColoresValoresUnicos(Dtgconten dtgconten, DataGridViewTextBoxColumn xid)
        {
            Configuraciones.PintarDeColoresValoresUnicos(dtgconten, xid);
        }
        private void CargarDatosFiltrados()
        {
            TDatos = CapaLogica.InsertarActualizarListarAfp(0, 10, "0", 0, 0, 0, cboperiodo.FechaInicioMes, 0, 0);
            dtgconten.DataSource = TDatos;
            dtgconten.Focus();
            lbltotalRegistros.Text = $"Total Registos: {dtgconten.RowCount}";
        }
        private void frmAfps_Load(object sender, EventArgs e)
        {
            CargarDatos();
            Estado = 0;
            PintarDeColoresValoresUnicos(dtgconten, xPeriodo);
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Estado = 1;
            //btnmodificar.Enabled = false;
            //iniciar(true);

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (Estado == 0)
            {
                this.Close();
            }
            else
            {
                //iniciar(false);
                Estado--;
            }
            CargarDatos();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (msgYesCancel("Desea Grabar Cambios") == DialogResult.Yes)
            {
                DateTime periodo = cboperiodo.FechaInicioMes;
                CapaLogica.DetalleAFPCambiarEstado(periodo);
                foreach (DataRow item in TDatos.Rows)
                {
                    int idusuario = frmLogin.CodigoUsuario;
                    int cod = (int)item[xid.DataPropertyName];
                    decimal aporte = (decimal)item[xAporte.DataPropertyName];
                    string descripcion = "";
                    decimal seguro = (decimal)item[xSeguro.DataPropertyName];
                    decimal rma = (decimal)item[xRMA.DataPropertyName];
                    decimal comision = (decimal)item[xComision.DataPropertyName];
                    //
                    CapaLogica.InsertarActualizarListarAfp(cod, Configuraciones.InsertarValor, descripcion, aporte, seguro, comision, periodo, rma, idusuario);
                }
                CapaLogica.DetalleAFPEliminar(periodo);
                msgOK("Detalle de las AFPS Grabadas con Exito");
            }
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (dtgconten.RowCount > 0)
            //{
            //    btnmodificar.Enabled = true;
            //    btneliminar.Enabled = true;
            //    btnexportarExcel.Enabled = true;
            //}
            //else
            //{
            //    btnexportarExcel.Enabled = false;
            //    btnmodificar.Enabled = false;
            //    btneliminar.Enabled = false;
            //}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                List<HPResergerFunciones.Utilitarios.NombreCelda> Celditas = new List<HPResergerFunciones.Utilitarios.NombreCelda>();
                HPResergerFunciones.Utilitarios.NombreCelda Celdita = new HPResergerFunciones.Utilitarios.NombreCelda();
                Celdita.fila = 1;
                Celdita.columna = 1;
                Celdita.Nombre = "Listado de Afps";
                Celditas.Add(Celdita);
                HPResergerFunciones.Utilitarios.ExportarAExcel(dtgconten, "", "Afps", Celditas, 1, new int[] { 1 }, new int[] { 1 }, new int[] { });
                HPResergerFunciones.frmInformativo.MostrarDialog("Exportado con Exito");
            }
            else
                HPResergerFunciones.frmInformativo.MostrarDialogError("No hay Filas para Exportar");
        }

        private void btnPaso1_Click(object sender, EventArgs e)
        {
            Estado = 2;
            CargarDatosFiltrados();
        }
        public void msgError(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public DialogResult msgYesCancel(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        Boolean ControlarCelda = true;
        private void dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgconten.Columns[xRMA.Name].Index && ControlarCelda)
                {
                    //Duplicamos el Valor llenado en todas las Celdas de la columna
                    RellenarValorenCeldas((decimal)dtgconten[e.ColumnIndex, e.RowIndex].Value);
                }
                if (ControlarCelda && (e.ColumnIndex == dtgconten.Columns[xSeguro.Name].Index || e.ColumnIndex == dtgconten.Columns[xComision.Name].Index || e.ColumnIndex == dtgconten.Columns[xAporte.Name].Index))
                {
                    ControlarCelda = false;
                    dtgconten[e.ColumnIndex, e.RowIndex].Value = ((decimal)dtgconten[e.ColumnIndex, e.RowIndex].Value) / 100;
                    ControlarCelda = true;
                }
            }
        }

        private void RellenarValorenCeldas(decimal Valor)
        {
            ControlarCelda = false;
            foreach (DataGridViewRow item in dtgconten.Rows)
                item.Cells[xRMA.Name].Value = Valor;
            ControlarCelda = true;
        }

        private void dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int x = dtgconten.CurrentCell.RowIndex, y = dtgconten.CurrentCell.ColumnIndex;
            txt = e.Control as TextBox;
            txt.KeyDown -= Txt_KeyDown;
            txt.KeyPress -= Txt_KeyPress;
            if (y == dtgconten.Columns[xSeguro.Name].Index || y == dtgconten.Columns[xComision.Name].Index || y == dtgconten.Columns[xAporte.Name].Index ||
                y == dtgconten.Columns[xRMA.Name].Index)
            {
                txt.KeyDown += Txt_KeyDown;
                txt.KeyPress += Txt_KeyPress;
            }
        }
        TextBox txt;
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimalesX(e, txt.Text);
        }
        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txt);
        }
    }
}
