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

namespace HPReserger.ModuloRRHH
{
    public partial class frmComisionesBonos : FormGradient
    {
        public frmComisionesBonos()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public int Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
                btnProcesar.Enabled = false;
                dtgconten.ReadOnly = true;
                btnPaso1.Enabled = true;
                comboMesAño1.Enabled = true;
                dtgconten.Columns[xEmpresaOrigen.Name].ReadOnly = true;
                dtgconten.Columns[xEmpresaFin.Name].ReadOnly = true;
                dtgconten.Columns[xNombre.Name].ReadOnly = true;
                dtgconten.Columns[xSueldo.Name].ReadOnly = true;
                if (estado == 1)
                {
                    btnProcesar.Enabled = true;
                    dtgconten.ReadOnly = false;
                    btnPaso1.Enabled = false;
                    comboMesAño1.Enabled = false;
                    Configuraciones.CambiarReadOnlyGrilla(dtgconten, true, xEmpresaOrigen, xEmpresaFin, xNombre, xSueldo);
                }
                if (estado == 0)
                    if (TDatos != null)
                        dtgconten.DataSource = TDatos.Clone();
            }

        }
        private int estado;
        DateTime Periodo;
        public void msgError(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public DialogResult msgYesCancel(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private void btnPaso1_Click(object sender, EventArgs e)
        {
            Periodo = comboMesAño1.GetFechaPRimerDia();
            CargarDatos();
            PintarDeColoresValoresUnicos(dtgconten, xnumdoc);
            if (TDatos.Rows.Count == 0) { msgError("No hay Datos para Mostrar:\nActive en las Empresas el Stock\nActive Contrato en los Empleados"); return; }
            Estado++;
        }
        private void PintarDeColoresValoresUnicos(Dtgconten dtgconten, DataGridViewColumn xid)
        {
            Configuraciones.PintarDeColoresValoresUnicos(dtgconten, xnumdoc);
        }
        DataTable TDatos;
        private void CargarDatos()
        {
            TDatos = CapaLogica.ComisionesBonosPeriodo(Periodo);
            dtgconten.DataSource = TDatos;
            lbltotalRegistros.Text = $"Total de Registros: {dtgconten.RowCount}";
        }    
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (Estado == 0) this.Close();
            else
                Estado = 0;

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
        private void dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int x = dtgconten.CurrentCell.RowIndex, y = dtgconten.CurrentCell.ColumnIndex;
            txt = e.Control as TextBox;
            txt.KeyDown -= Txt_KeyDown;
            txt.KeyPress -= Txt_KeyPress;
            if (y == dtgconten.Columns[xComision.Name].Index || y == dtgconten.Columns[xBono.Name].Index)
            {
                //si edito el pago
                txt.KeyDown += Txt_KeyDown;
                txt.KeyPress += Txt_KeyPress;
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (msgYesCancel("Desea Grabar Cambios") == DialogResult.Yes)
            {
                CapaLogica.ComisionesBonosCambiarEstado(Periodo);
                foreach (DataRow item in TDatos.Rows)
                {
                    int pkid = (int)item[xpkid.DataPropertyName];
                    int tipoid = (int)item[xtipoid.DataPropertyName];
                    string numdoc = item[xnumdoc.DataPropertyName].ToString();
                    int pkEmpresa = (int)item[xpkEmpresa.DataPropertyName];
                    int fkempresa = (int)item[xfkempresa.DataPropertyName];
                    decimal sueldo = (decimal)item[xSueldo.DataPropertyName];
                    decimal comision = (decimal)item[xComision.DataPropertyName];
                    decimal bono = (decimal)item[xBono.DataPropertyName];
                    int idusuario = frmLogin.CodigoUsuario;
                    DateTime FechaHoy = DateTime.Now;
                    CapaLogica.ComisionesBonos(Configuraciones.InsertarValor, pkid, tipoid, numdoc, pkEmpresa, fkempresa, Periodo, sueldo, comision, bono, idusuario, FechaHoy, Configuraciones.EstadoActivo);
                }
                CapaLogica.ComisionesBonosEliminar(Periodo);
                msgOK("Comisiones Grabadas con Exito");
            }
        }

        private void frmComisionesBonos_Load(object sender, EventArgs e)
        {

        }
    }
}
