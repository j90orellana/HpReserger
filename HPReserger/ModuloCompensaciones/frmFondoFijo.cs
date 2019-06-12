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
    public partial class frmFondoFijo : FormGradient
    {
        public frmFondoFijo()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmFondoFijo_Load(object sender, EventArgs e)
        {
            txtglosa.CargarTextoporDefecto();
            txtImporteTotal.CargarTextoporDefecto();
            dtpFechaContable.Value = dtpFechaCompensa.Value = DateTime.Now;
            Estado = 0;
            ModoEdicion(false);
            CargarEmpresa();
            CargarEmpleado();
            CargarMoneda();
            //btnaceptar.Enabled = false;
        }
        int Estado = 0;
        public void ModoEdicion(Boolean a)
        {
            //btnaceptar.Enabled = a;
        }
        public void CargarMoneda() { CapaLogica.TablaMoneda(cbomoneda); }
        public void CargarEmpleado()
        {
            cboempleado.ValueMember = "UsuarioCompensacion";
            cboempleado.DisplayMember = "Empleado";
            cboempleado.DataSource = TablaEmpleados();
        }
        public DataTable TablaEmpleados()
        {
            return CapaLogica.ListarEmpleadosCompensacionesTodos();
        }
        private string _NameEmpresa;
        public string NameEmpresa
        {
            get { return _NameEmpresa; }
            set
            {
                if (value != NameEmpresa)
                    //if (NameEmpresa != null && NameEmpresa != "")
                    //BuscarEmpleadoCompensaciones();
                    _NameEmpresa = value;
            }
        }
        public DataTable CargarCuentasxPagar()
        {
            string tipomoneda = "MN";
            if (cbomoneda.Items.Count > 0)
            {
                if ((int)cbomoneda.SelectedValue == 1)
                {
                    tipomoneda = "mn";
                }
                else if ((int)cbomoneda.SelectedValue == 2)
                {
                    tipomoneda = "me";
                }
            }
            DataTable TablePagar = CapaLogica.BuscarCuentas($"%FONDOS FIJOS%{tipomoneda}", 5, "D");
            return TablePagar;
        }
        int _idempresa;
        public void CargarEmpresa() { CapaLogica.TablaEmpresas(cboempresa); }
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btnaceptar.Enabled = true;

            //cboempleado.DisplayMember = "empleado";
            //cboempleado.ValueMember = "UsuarioCompensacion";

            NameEmpresa = cboempresa.Text;
            if (cboempresa.Items.Count > 0)
            {
                if (cboempresa.SelectedValue != null)
                {
                    cboproyecto.DataSource = CapaLogica.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString());
                    cboproyecto.DisplayMember = "proyecto";
                    cboproyecto.ValueMember = "id_proyecto";
                    //busqueda de Asientos
                    _idempresa = (int)cboempresa.SelectedValue;

                    cbobanco_SelectedIndexChanged(sender, e);
                    CargarDatos();
                }
            }
        }
        private void CargarDatos()
        {
            dtgconten.DataSource = CapaLogica.ListarCompensaciones(_idempresa, 1, 0, "");
            lbltotalregistros.Text = $"Total de Registros {dtgconten.RowCount}";
        }

        public void SacarTipoCambio()
        {
            DateTime FechaValidaBuscar = dtpFechaCompensa.Value;
            txttipocambio.Text = CapaLogica.TipoCambioDia("Venta", FechaValidaBuscar).ToString("n3");
            if (txttipocambio.Text == "0.000")
            {
                if (frmtipo == null)
                {
                    frmtipo = new frmTipodeCambio();
                    frmtipo.Show();
                    frmtipo.comboMesAño1.ActualizarMesAÑo(FechaValidaBuscar.Month.ToString(), FechaValidaBuscar.Year.ToString());
                    frmtipo.Buscar_Click(new object(), new EventArgs());
                    frmtipo.BusquedaExterna = false;
                    frmtipo.Hide();
                    if (frmtipo.BusquedaExterna)
                    {
                        frmtipo.Close();
                        frmtipo = null;
                        SacarTipoCambio();
                    }
                }
            }
        }
        frmTipodeCambio frmtipo;
        private void dtpFechaCompensa_ValueChanged(object sender, EventArgs e)
        {
            SacarTipoCambio();
        }
        private void cbobanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbobanco.SelectedIndex >= 0)
            {
                cbocuentabanco.Text = "";
                CargarCuentasBancos();
            }
        }
        public void CargarCuentasBancos()
        {
            if (cboempresa.SelectedValue != null)
            {
                cbocuentabanco.ValueMember = "Id_Cuenta_Contable";
                cbocuentabanco.DisplayMember = "banco";
                cbocuentabanco.DataSource = CapaLogica.ListarBancosTiposdePagoxEmpresa(cbobanco.SelectedValue.ToString(), (int)cboempresa.SelectedValue);
            }
        }

        private void cbomoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbocuentaxpagar.ValueMember = "idcuenta";
            cbocuentaxpagar.DisplayMember = "Cuenta_contable";
            cbocuentaxpagar.DataSource = CargarCuentasxPagar();
        }
        private void cbobanco_Click(object sender, EventArgs e)
        {
            string cadenar = cbobanco.Text;
            cbobanco.ValueMember = "codigo";
            cbobanco.DisplayMember = "descripcion";
            cbobanco.DataSource = CapaLogica.getCargoTipoContratacion("Sufijo", "Entidad_Financiera", "TBL_Entidad_Financiera");
            cbobanco.Text = cadenar;
        }

        private void cboempleado_Click(object sender, EventArgs e)
        {
            string cadena = cboempleado.Text;
            DataTable TableAux = TablaEmpleados();
            if (cboempleado.Items.Count != TableAux.Rows.Count)
            {
                cboempleado.DataSource = TableAux;
            }
            cboempleado.Text = cadena;
        }

        private void btnbusEmpleado_Click(object sender, EventArgs e)
        {
            frmListarEmpleados frmlisempleado = new frmListarEmpleados();
            string[] empleado = "0-0".Split('-');
            if (cboempleado.SelectedValue != null)
            {
                empleado = cboempleado.SelectedValue.ToString().Split('-');
                frmlisempleado.TipoDocumento = int.Parse(empleado[0]);
                frmlisempleado.NumeroDocumento = empleado[1];
            }
            frmlisempleado.Text = "Seleccione Empleado para El Fondo Fijo";
            if (frmlisempleado.ShowDialog() == DialogResult.OK)
            {
                cboempleado.SelectedValue = frmlisempleado.TipoDocumento + "-" + frmlisempleado.NumeroDocumento;
            }
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
        }
        public DialogResult msgOk(string cadena)
        {
            return HPResergerFunciones.Utilitarios.msgOkCancel(cadena);
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (cboempresa.SelectedValue == null)
            {
                msg("Seleccione la Empresa");
                cboempresa.Focus(); return;
            }
            if (cboproyecto.SelectedValue == null)
            {
                msg("Seleccione el Proyecto");
                cboproyecto.Focus(); return;
            }
            if (cboempleado.SelectedValue == null)
            {
                msg("Seleccione el Empleado");
                cboempleado.Focus(); return;
            }
            if (cbomoneda.SelectedValue == null)
            {
                msg("Seleccione la Moneda");
                cbomoneda.Focus(); return;
            }
            if (cbocuentaxpagar.SelectedValue == null)
            {
                msg("Seleccione la Cuenta por Pagar");
                cbocuentaxpagar.Focus(); return;
            }
            if (cbobanco.SelectedValue == null)
            {
                msg("Seleccione el Banco");
                cbobanco.Focus(); return;
            }
            if (cbocuentabanco.SelectedValue == null)
            {
                msg("Seleccione la cuenta el Fondo Fijo");
                cbocuentabanco.Focus(); return;
            }
            if (decimal.Parse(txtImporteTotal.Text) < 0)
            {
                msg("El monto del Fondo Fijo debe ser mayor a Cero");
                txtImporteTotal.Focus(); return;
            }
            if (decimal.Parse(txttipocambio.Text) == 0)
            {
                msg("El monto del Tipo de Cambio no debe ser Cero");
                txttipocambio.Focus(); return;
            }
            if (!txtglosa.EstaLLeno())
            {
                msg("Ingrese Glosa");
                txtglosa.Focus(); return;
            }
            if (msgOk("¿Seguro Desea Crear el Fondo Fijo?") == DialogResult.OK)
            {
                string Cuo = "";

                //Cuadre Asiento
                //CapaLogica.CuadrarAsiento(CuoNext, proyecto, dtpFechaContable.Value, 2);
                //Fin Cuadre
                msg($"Se Creo El Fondo Fijo con Cuo {Cuo}");
            }
        }
    }
}
