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
            txtnrocheque.CargarTextoporDefecto();
            dtpFechaContable.Value = dtpFechaCompensa.Value = DateTime.Now;
            Estado = 0;
            ModoEdicion(false);
            CargarEmpresa();
            CargarEmpleado();
            CargarMoneda();
            cbopago.SelectedIndex = 0;
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
            DataTable TableBancos = CapaLogica.TablaBanco();
            if (TableBancos.Rows.Count != cbobanco.Items.Count)
            {
                cbobanco.ValueMember = "codigo";
                cbobanco.DisplayMember = "descripcion";
                cbobanco.DataSource = TableBancos;
                cbobanco.Text = cadenar;
            }
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
            if (!txtnrocheque.EstaLLeno())
            {
                msg("Ingrese Nro Operacion/Cheque");
                txtnrocheque.Focus(); return;
            }
            if (decimal.Parse(txtImporteTotal.Text) <= 0)
            {
                msg("El Monto del Fondo Fijo debe ser mayor a Cero");
                txtImporteTotal.Focus(); return;
            }
            if (decimal.Parse(txttipocambio.Text) == 0)
            {
                msg("El Monto del Tipo de Cambio no debe ser Cero");
                txttipocambio.Focus(); return;
            }
            if (!txtglosa.EstaLLeno())
            {
                msg("Ingrese Glosa");
                txtglosa.Focus(); return;
            }
            string CuentaFondoFijo = cbocuentaxpagar.SelectedValue.ToString();
            if (cboempleado.SelectedValue == null) { msg("Seleccione un Empleado"); cboempleado.Focus(); return; }
            string[] empleado = cboempleado.SelectedValue.ToString().Split('-');
            DataTable Filita = CapaLogica.FondoFijoVeriricarExistencia(_idempresa, int.Parse(empleado[0]), empleado[1], CuentaFondoFijo);
            if (Filita.Rows.Count > 0)
            {
                msg("Este Empleado Ya tiene un Fondo Fijo Activo");
                return;
            }
            if (msgOk("¿Seguro Desea Crear el Fondo Fijo?") == DialogResult.OK)
            {
                int numasiento = 0;
                if (numasiento == 0)
                {
                    DataTable asientito = CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, dtpFechaContable.Value);
                    DataRow asiento = asientito.Rows[0];
                    if (asiento == null) { numasiento = 1; }
                    else
                        numasiento = ((int)asiento["codigo"]);
                }
                int PosFila = 0;
                string Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, dtpFechaContable.Value);
                int moneda = (int)cbomoneda.SelectedValue;
                int proyecto = (int)cboproyecto.SelectedValue;
                int TipoId = int.Parse(empleado[0]);
                string Numdoc = empleado[1];
                string NameEmpleado = cboempleado.Text.Substring(cboempleado.Text.IndexOf('-') + 2);
                decimal MontoSoles = 0, MontoDolares = 0;
                decimal ImporteTotal = decimal.Parse(txtImporteTotal.Text);
                decimal tc = decimal.Parse(txttipocambio.Text);
                string glosa = txtglosa.TextValido();
                //Saco Importe Moneda
                if ((int)cbomoneda.SelectedValue == 1)
                {
                    MontoSoles = ImporteTotal;
                    MontoDolares = Configuraciones.Redondear(ImporteTotal / tc);
                }
                else
                {
                    MontoSoles = Configuraciones.Redondear(ImporteTotal * tc);
                    MontoDolares = ImporteTotal;
                }
                //Fin Saco Importe Moneda
                string BanCuenta; int idTipocuenta;
                string nroKuenta = HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text);
                if (cbocuentabanco.SelectedValue == null) BanCuenta = "";
                else BanCuenta = cbocuentabanco.SelectedValue.ToString();
                idTipocuenta = (int)((DataTable)cbocuentabanco.DataSource).Rows[cbocuentabanco.SelectedIndex]["idtipocta"];
                DateTime FechaCompensa = dtpFechaCompensa.Value;
                DateTime FechaContable = dtpFechaContable.Value;
                DateTime FechaVence = dtpFechaCompensa.Value.AddMonths(1);
                string NumID = (CapaLogica.SiguienteIDCompensaciones(_idempresa, 1).Rows[0]["valor"].ToString()); //1= Fondo Fijo
                //Debe
                //Asiento del Anticipo
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaFondoFijo, moneda == 1 ? MontoSoles : MontoDolares, 0, tc,
                    proyecto, 0, Cuo, moneda, glosa, dtpFechaCompensa.Value, -12);
                //Detalle del asiento
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, dtpFechaContable.Value, CuentaFondoFijo, proyecto, TipoId, Numdoc
                    , NameEmpleado, 0, FechaCompensa.ToString("yyyyMMdd"), NumID, 0, FechaContable, FechaVence, FechaCompensa, MontoSoles, MontoDolares, tc, moneda, "", "", glosa, FechaCompensa, frmLogin.CodigoUsuario, "");
                //Haber
                //Asiento del salida del Banco
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, BanCuenta, 0, moneda == 1 ? MontoSoles : MontoDolares, tc,
                    proyecto, 0, Cuo, moneda, glosa, dtpFechaCompensa.Value, -12);
                //Detalle del asiento
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, dtpFechaContable.Value, BanCuenta, proyecto, TipoId, Numdoc
                    , NameEmpleado, 0, FechaCompensa.ToString("yyyyMMdd"), NumID, 0, FechaContable, FechaVence, FechaCompensa, MontoSoles, MontoDolares, tc, moneda, nroKuenta, txtnrocheque.Text, glosa, FechaCompensa, frmLogin.CodigoUsuario, "");
                //Inserto compensaciones!
                CapaLogica.InsertarCompensaciones(_idempresa, 1, TipoId, Numdoc, MontoSoles, MontoDolares, Cuo, cbopago.SelectedIndex == 0 ? 7 : 3, nroKuenta, txtnrocheque.TextValido(),
                    $"{dtpFechaCompensa.Value.ToString("d")} {Configuraciones.MayusculaCadaPalabra(NameEmpleado)}", dtpFechaCompensa.Value, 2, CuentaFondoFijo, "");
                //
                //Cuadre Asiento
                CapaLogica.CuadrarAsiento(Cuo, proyecto, dtpFechaContable.Value, 2);
                //Fin Cuadre              
                msg($"Se Creó El Fondo Fijo con Cuo {Cuo}");
                CargarDatos();
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
