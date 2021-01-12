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
            txtnrooperacion.CargarTextoporDefecto();
            dtpFechaContable.Value = dtpFechaCompensa.Value = DateTime.Now;
            Estado = 0;
            ModoEdicion(false);
            CargarEmpresa();
            CargarEmpleado();
            CargarMoneda();
            CargarTipoPagos();
            //btnaceptar.Enabled = false;
        }
        public void CargarTipoPagos()
        {
            cbotipo.DisplayMember = "mediopago";
            cbotipo.ValueMember = "codsunat";
            cbotipo.DataSource = CapaLogica.ListadoMedioPagos();
            if (cbotipo.Items.Count > 0) cbotipo.SelectedValue = 3;
        }
        int Estado = 0;
        int moneda = 1;
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
            btnDarBaja.Enabled = false;
            dtgconten.DataSource = CapaLogica.ListarCompensaciones(_idempresa, 1, 0, "");
            lbltotalregistros.Text = $"Total de Registros {dtgconten.RowCount}";
            if (dtgconten.RowCount > 0)
            { btnmodificar.Enabled = true; }
            else { btnmodificar.Enabled = false; }
            PasarTipoOracion(xcliente);
        }
        public void PasarTipoOracion(DataGridViewColumn col)
        {
            foreach (DataGridViewRow item in dtgconten.Rows)
                item.Cells[col.Name].Value = Configuraciones.MayusculaCadaPalabra(item.Cells[col.Name].Value.ToString());
        }
        frmTipodeCambio frmtipo;
        public void SacarTipoCambio()
        {
            DateTime FechaValidaBuscar = dtpFechaCompensa.Value;
            txttipocambio.Text = CapaLogica.TipoCambioDia("Venta", FechaValidaBuscar).ToString("n3");
            if (decimal.Parse(txttipocambio.Text) == 0)
            {
                if (frmtipo == null)
                {
                    frmtipo = new frmTipodeCambio();
                    frmtipo.ActualizoTipoCambio += Frmtipo_ActualizoTipoCambio;
                    frmtipo.Show();
                    frmtipo.Hide();
                    frmtipo.comboMesAño1.ActualizarMesAÑo(FechaValidaBuscar.Month.ToString(), FechaValidaBuscar.Year.ToString());
                    frmtipo.Buscar_Click(new object(), new EventArgs());
                }
            }
        }
        private void Frmtipo_ActualizoTipoCambio(object sender, EventArgs e)
        {
            frmtipo.Close();
            frmtipo = null;
            SacarTipoCambio();
        }
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
            if (cboempresa.SelectedValue != null && cbobanco.SelectedValue != null)
            {
                cbocuentabanco.ValueMember = "Id_Cuenta_Contable";
                cbocuentabanco.DisplayMember = "banco";
                cbocuentabanco.DataSource = CapaLogica.ListarBancosTiposdePagoxEmpresa(cbobanco.SelectedValue.ToString(), (int)cboempresa.SelectedValue, (int)cbomoneda.SelectedValue);
            }
        }

        private void cbomoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbocuentaxpagar.ValueMember = "idcuenta";
            cbocuentaxpagar.DisplayMember = "Cuenta_contable";
            cbocuentaxpagar.DataSource = CargarCuentasxPagar();
            moneda = (int)cbomoneda.SelectedValue;
            CargarCuentasBancos();
        }
        private void cbobanco_Click(object sender, EventArgs e)
        {
            string cadenar = cbobanco.Text;
            DataTable TableBancos = CapaLogica.TablaBanco();
            if (TableBancos.Rows.Count != cbobanco.Items.Count)
            {
                cbobanco.ValueMember = "sufijo";
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
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
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
            if (!txtnrooperacion.EstaLLeno())
            {
                msg("Ingrese Nro Operacion/Cheque");
                txtnrooperacion.Focus(); return;
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
            //Validacion de que el periodo NO sea muy disperso, sea un mes continuo a los trabajados
            int IdEmpresa = (int)cboempresa.SelectedValue;
            DateTime FechaCoontable = dtpFechaContable.Value;
            if (!CapaLogica.ValidarCrearPeriodo(IdEmpresa, FechaCoontable))
            {
                if (HPResergerFunciones.frmPregunta.MostrarDialogYesCancel("No se Puede Registrar este Asiento\nEl Periodo no puede Crearse", $"¿Desea Crear el Periodo de {FechaCoontable.ToString("MMMM")}-{FechaCoontable.Year}?") != DialogResult.Yes)
                    return;
            }
            if (!CapaLogica.VerificarPeriodoAbierto((int)cboempresa.SelectedValue, dtpFechaContable.Value))
            {
                msg("El Periodo Esta Cerrado, Cambie Fecha Contable"); dtpFechaContable.Focus(); return;
            }
            if (cbotipo.Items.Count == 0) { cbotipo.Focus(); msg("Seleccione Tipo de Pago"); return; }
            int TipoPago = (int)cbotipo.SelectedValue;
            string NroOperacion = txtnrooperacion.TextValido();
            //
            string NumID = "0";
            if (dtgconten.CurrentCell != null) NumID = dtgconten[xpkid.Name, dtgconten.CurrentCell.RowIndex].Value.ToString();
            string CuentaFondoFijo = cbocuentaxpagar.SelectedValue.ToString();
            if (cboempleado.SelectedValue == null) { msg("Seleccione un Empleado"); cboempleado.Focus(); return; }
            string[] empleado = cboempleado.SelectedValue.ToString().Split('-');
            DataTable Filita = CapaLogica.FondoFijoVeriricarExistencia(_idempresa, int.Parse(empleado[0]), empleado[1], CuentaFondoFijo, int.Parse(NumID));
            if (Filita.Rows.Count > 0)
            {
                msg("Este Empleado Ya tiene un Fondo Fijo Activo");
                return;
            }
            if (Estado == 2)
            {
                decimal PorAbonar = decimal.Parse(txtPorAbonar.Text);
                if (PorAbonar == 0)
                {
                    txtImporteTotal.Focus();
                    msg("Debe Ingresar el Nuevo Monto del Fondo"); return;
                }
                //Proceso para Actualizar
                int numasiento = 0;
                if (numasiento == 0)
                {
                    DataTable asientito = CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, dtpFechaContable.Value);
                    DataRow asiento = asientito.Rows[0];
                    if (asiento == null) { numasiento = 1; }
                    else
                        numasiento = ((int)asiento["codigo"]);
                }
                if (msgp("¿Seguro Desea Actualizar el Fondo Fijo?") == DialogResult.Yes)
                {
                    int PosFila = 0;
                    string Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, dtpFechaContable.Value);
                    int moneda = (int)cbomoneda.SelectedValue;
                    int proyecto = (int)cboproyecto.SelectedValue;
                    int TipoId = int.Parse(empleado[0]);
                    string Numdoc = empleado[1];
                    string NameEmpleado = cboempleado.Text.Substring(cboempleado.Text.IndexOf('-') + 2).ToUpper();
                    decimal MontoSoles = 0, MontoDolares = 0;
                    decimal MontoSolesNew = 0, MontoDolaresNew = 0;
                    decimal ImporteTotal = decimal.Parse(txtImporteTotal.Text);
                    decimal tc = decimal.Parse(txttipocambio.Text);
                    string glosa = txtglosa.TextValido();
                    string nroOperacion = txtnrooperacion.TextValido();
                    //Saco Importe Moneda
                    if ((int)cbomoneda.SelectedValue == 1)
                    {
                        MontoSoles = (PorAbonar);
                        MontoDolares = (Configuraciones.Redondear(PorAbonar / tc));
                        MontoSolesNew = (ImporteTotal);
                        MontoDolaresNew = (Configuraciones.Redondear(ImporteTotal / tc));
                    }
                    else
                    {
                        MontoSoles = (Configuraciones.Redondear(PorAbonar * tc));
                        MontoDolares = (PorAbonar);
                        MontoSolesNew = (Configuraciones.Redondear(ImporteTotal * tc));
                        MontoDolaresNew = (ImporteTotal);
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
                    //VALIDAMOS QUE NO EXISTAN CUENTAS CONTABLES DESACTIVADAS
                    List<string> ListaAuxiliar = new List<string>();
                    ListaAuxiliar.Add(CuentaFondoFijo);
                    ListaAuxiliar.Add(BanCuenta);
                    if (CapaLogica.CuentaContableValidarActivas(string.Join(",", ListaAuxiliar.ToArray()), Mensajes.CuentasContablesDesactivadas)) return;
                    //FIN DE LA VALDIACION DE LAS CUENTAS CONTABLES DESACTIVADAS
                    ///
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaFondoFijo, PorAbonar < 0 ? Math.Abs(moneda == 1 ? MontoSoles : MontoDolares) : 0,
                         PorAbonar > 0 ? Math.Abs(moneda == 1 ? MontoSoles : MontoDolares) : 0, tc, proyecto, 0, Cuo, moneda, glosa, FechaCompensa, -17);
                    //Detalle del asiento
                    CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, dtpFechaContable.Value, CuentaFondoFijo, proyecto, TipoId, Numdoc
                        , NameEmpleado, 0, FechaCompensa.ToString("yyyyMMdd"), NumID, 0, FechaContable, FechaVence, FechaCompensa, Math.Abs(MontoSoles), Math.Abs(MontoDolares), tc, moneda, "", "", glosa, FechaCompensa, frmLogin.CodigoUsuario, "");
                    //Haber
                    //Asiento del salida del Banco
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, BanCuenta, PorAbonar > 0 ? Math.Abs(moneda == 1 ? MontoSoles : MontoDolares) : 0,
                         PorAbonar < 0 ? Math.Abs(moneda == 1 ? MontoSoles : MontoDolares) : 0, tc, proyecto, 0, Cuo, moneda, glosa, FechaCompensa, -17);
                    //Detalle del asiento
                    CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, dtpFechaContable.Value, BanCuenta, proyecto, TipoId, Numdoc
                        , NameEmpleado, 0, FechaCompensa.ToString("yyyyMMdd"), NumID, 0, FechaContable, FechaVence, FechaCompensa, Math.Abs(MontoSoles), Math.Abs(MontoDolares), tc, moneda, nroKuenta,
                        nroOperacion, glosa, FechaCompensa, frmLogin.CodigoUsuario, "", TipoPago);
                    //Inserto compensaciones!
                    CapaLogica.InsertarCompensacionesDetalle(int.Parse(NumID), _idempresa, 1, (PorAbonar > 0 ? 1 : -1) * Math.Abs(MontoSoles), (PorAbonar > 0 ? 1 : -1) * Math.Abs(MontoDolares), TipoPago, nroKuenta, nroOperacion,
                       $"{Configuraciones.MayusculaCadaPalabra(NameEmpleado)} {FechaCompensa.ToString()}", FechaCompensa, 1, Cuo);

                    //CapaLogica.CompensacionesActualizar(int.Parse(NumID), _idempresa, 1, TipoId, Numdoc, MontoSolesNew, MontoDolaresNew, Cuo, cbopago.SelectedIndex == 0 ? 7 : 3, nroKuenta, nroOperacion,
                    //    $"{FechaCompensa.ToString("d")} {Configuraciones.MayusculaCadaPalabra(NameEmpleado)}", FechaCompensa, 1, CuentaFondoFijo, "");
                    //
                    //Cuadre Asiento
                    CapaLogica.CuadrarAsiento(Cuo, proyecto, FechaContable, 2);
                    //Fin Cuadre              
                    msgOK($"Se Actualizo El Fondo Fijo con Cuo {Cuo}");
                    ModoEdicion(false);
                    BloquearPago(false);
                    Estado = 0;
                    CargarDatos();
                }
            }
            else if (Estado == 10)
            {
                //Proceso para Actualizar
                int numasiento = 0;
                if (numasiento == 0)
                {
                    DataTable asientito = CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, dtpFechaContable.Value);
                    DataRow asiento = asientito.Rows[0];
                    if (asiento == null) { numasiento = 1; }
                    else
                        numasiento = ((int)asiento["codigo"]);
                }
                if (msgp("¿Seguro Desea Dar de Baja el Fondo Fijo?") == DialogResult.Yes)
                {
                    int PosFila = 0;
                    string Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, dtpFechaContable.Value);
                    int moneda = (int)cbomoneda.SelectedValue;
                    int proyecto = (int)cboproyecto.SelectedValue;
                    int TipoId = int.Parse(empleado[0]);
                    string Numdoc = empleado[1];
                    string NameEmpleado = cboempleado.Text.Substring(cboempleado.Text.IndexOf('-') + 2).ToUpper();
                    decimal MontoSoles = 0, MontoDolares = 0;
                    decimal ImporteTotal = decimal.Parse(txtImporteTotal.Text);
                    decimal tc = decimal.Parse(txttipocambio.Text);
                    string glosa = txtglosa.TextValido();
                    string nroOperacion = txtnrooperacion.TextValido();
                    ////
                    string BanCuenta; int idTipocuenta;
                    string nroKuenta = HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text);
                    if (cbocuentabanco.SelectedValue == null) BanCuenta = "";
                    else BanCuenta = cbocuentabanco.SelectedValue.ToString();
                    idTipocuenta = (int)((DataTable)cbocuentabanco.DataSource).Rows[cbocuentabanco.SelectedIndex]["idtipocta"];
                    DateTime FechaCompensa = dtpFechaCompensa.Value;
                    DateTime FechaContable = dtpFechaContable.Value;
                    DateTime FechaVence = dtpFechaCompensa.Value.AddMonths(1);
                    //     
                    int pos = dtgconten.CurrentCell.RowIndex;
                    MontoSoles = (decimal)dtgconten[xMontoMN.Name, pos].Value;
                    MontoDolares = (decimal)dtgconten[xMontoME.Name, pos].Value;
                    //VALIDAMOS QUE NO EXISTAN CUENTAS CONTABLES DESACTIVADAS
                    List<string> ListaAuxiliar = new List<string>();
                    ListaAuxiliar.Add(CuentaFondoFijo);
                    ListaAuxiliar.Add(BanCuenta);
                    if (CapaLogica.CuentaContableValidarActivas(string.Join(",", ListaAuxiliar.ToArray()), Mensajes.CuentasContablesDesactivadas)) return;
                    //FIN DE LA VALDIACION DE LAS CUENTAS CONTABLES DESACTIVADAS
                    //debe
                    //Asiento del salida del Banco
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, BanCuenta, Math.Abs(moneda == 1 ? MontoSoles : MontoDolares),
                         0, tc, proyecto, 0, Cuo, moneda, glosa, FechaCompensa, -16);
                    //Detalle del asiento
                    CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, dtpFechaContable.Value, BanCuenta, proyecto, TipoId, Numdoc
                        , NameEmpleado, 0, FechaCompensa.ToString("yyyyMMdd"), NumID, 0, FechaContable, FechaVence, FechaCompensa, Math.Abs(MontoSoles), Math.Abs(MontoDolares), tc, moneda, nroKuenta,
                        nroOperacion, glosa, FechaCompensa, frmLogin.CodigoUsuario, "", TipoPago);
                    //haber
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaFondoFijo, 0,
                        Math.Abs(moneda == 1 ? MontoSoles : MontoDolares), tc, proyecto, 0, Cuo, moneda, glosa, FechaCompensa, -16);
                    //Detalle del asiento
                    CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, dtpFechaContable.Value, CuentaFondoFijo, proyecto, TipoId, Numdoc
                        , NameEmpleado, 0, FechaCompensa.ToString("yyyyMMdd"), NumID, 0, FechaContable, FechaVence, FechaCompensa, Math.Abs(MontoSoles), Math.Abs(MontoDolares), tc, moneda, "", "", glosa,
                        FechaCompensa, frmLogin.CodigoUsuario, "");
                    //Inserto compensaciones!
                    CapaLogica.InsertarCompensacionesDetalle(int.Parse(NumID), _idempresa, 1, MontoSoles, MontoDolares, TipoPago, nroKuenta, nroOperacion,
                        $"{Configuraciones.MayusculaCadaPalabra(NameEmpleado)} {FechaCompensa.ToString()}", FechaCompensa, 2, Cuo);
                    CapaLogica.ActualizarCompensaciones(_idempresa, 1, int.Parse(NumID), 1, TipoPago, nroKuenta, nroOperacion, Cuo);
                    //
                    //Cuadre Asiento
                    CapaLogica.CuadrarAsiento(Cuo, proyecto, FechaContable, 2);
                    //Fin Cuadre              
                    msgOK($"Se Dio de Baja El Fondo Fijo con Cuo {Cuo}");
                    lblabonar.Visible = txtPorAbonar.Visible = true;
                    txtImporteTotal.Enabled = txtPorAbonar.Enabled = true;
                    ModoEdicion(false);
                    BloquearPago(false);
                    Estado = 0;
                    CargarDatos();
                }
            }
            else if (msgp("¿Seguro Desea Crear el Fondo Fijo?") == DialogResult.Yes)
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
                string NameEmpleado = cboempleado.Text.Substring(cboempleado.Text.IndexOf('-') + 2).ToUpper();
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
                NumID = (CapaLogica.SiguienteIDCompensaciones(_idempresa, 1).Rows[0]["valor"].ToString()); //1= Fondo Fijo
                //Debe
                //VALIDAMOS QUE NO EXISTAN CUENTAS CONTABLES DESACTIVADAS
                List<string> ListaAuxiliar = new List<string>();
                ListaAuxiliar.Add(CuentaFondoFijo);
                ListaAuxiliar.Add(BanCuenta);
                if (CapaLogica.CuentaContableValidarActivas(string.Join(",", ListaAuxiliar.ToArray()), Mensajes.CuentasContablesDesactivadas)) return;
                //FIN DE LA VALDIACION DE LAS CUENTAS CONTABLES DESACTIVADAS
                //Asiento del Anticipo
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaFondoFijo, moneda == 1 ? MontoSoles : MontoDolares, 0, tc,
                    proyecto, 0, Cuo, moneda, glosa, dtpFechaCompensa.Value, -12);
                //Detalle del asiento
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, dtpFechaContable.Value, CuentaFondoFijo, proyecto, TipoId, Numdoc
                    , NameEmpleado, 0, FechaCompensa.ToString("yyyyMMdd"), NumID, 0, FechaContable, FechaVence, FechaCompensa, MontoSoles, MontoDolares, tc, moneda, "", "", glosa, FechaCompensa, frmLogin.CodigoUsuario, " ");
                //Haber
                //Asiento del salida del Banco
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, BanCuenta, 0, moneda == 1 ? MontoSoles : MontoDolares, tc,
                    proyecto, 0, Cuo, moneda, glosa, dtpFechaCompensa.Value, -12);
                //Detalle del asiento
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, dtpFechaContable.Value, BanCuenta, proyecto, TipoId, Numdoc
                    , NameEmpleado, 0, FechaCompensa.ToString("yyyyMMdd"), NumID, 0, FechaContable, FechaVence, FechaCompensa, MontoSoles, MontoDolares, tc, moneda, nroKuenta, txtnrooperacion.Text, glosa,
                    FechaCompensa, frmLogin.CodigoUsuario, " ", TipoPago);
                //Inserto compensaciones!
                CapaLogica.InsertarCompensaciones(_idempresa, 1, TipoId, Numdoc, MontoSoles, MontoDolares, Cuo, TipoPago, nroKuenta, txtnrooperacion.TextValido(),
                    $"{dtpFechaCompensa.Value.ToString("d")} {Configuraciones.MayusculaCadaPalabra(NameEmpleado)}", dtpFechaCompensa.Value, 2, CuentaFondoFijo, "");
                //
                //Cuadre Asiento
                CapaLogica.CuadrarAsiento(Cuo, proyecto, dtpFechaContable.Value, 2);
                //Fin Cuadre              
                msgOK($"Se Creó El Fondo Fijo con Cuo {Cuo}");
                CargarDatos();
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (Estado == 2)
            {
                ModoEdicion(false);
                BloquearPago(false);
                Estado = 0;
                CargarDatos();
            }
            else if (Estado == 10)
            {
                lblabonar.Visible = txtPorAbonar.Visible = true;
                txtImporteTotal.Enabled = txtPorAbonar.Enabled = true;
                ModoEdicion(false);
                BloquearPago(false);
                Estado = 0;
                CargarDatos();
            }
            else if (Estado == 0)
                this.Close();
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                DataGridViewRow R = dtgconten.Rows[x];
                cboempleado.SelectedValue = R.Cells[xTipoID.Name].Value.ToString() + "-" + R.Cells[xNumDoc.Name].Value.ToString();
                cbocuentaxpagar.SelectedValue = R.Cells[xcuentacontable.Name].Value.ToString();
                if (cbocuentaxpagar.SelectedValue == null)
                    cbomoneda.SelectedValue = moneda == 1 ? 2 : 1;
                cbocuentaxpagar.SelectedValue = R.Cells[xcuentacontable.Name].Value.ToString();
                txtImporteTotal.Text = (moneda == 1 ? (decimal)R.Cells[xMontoMN.Name].Value : (decimal)R.Cells[xMontoME.Name].Value).ToString("n2");
                dtpFechaCompensa.Value = (DateTime)R.Cells[xFechaCompensa.Name].Value;
                btnmodificar.Enabled = true;
                btnDarBaja.Enabled = false;

                if (R.Cells[xNameEstado.Name].Value.ToString() == "Por Regularizar")
                {
                    btnDarBaja.Enabled = true;
                }
                if (R.Cells[xNameEstado.Name].Value.ToString() == "Regularizado")
                {
                    btnmodificar.Enabled = false;
                }
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Estado = 2;
            btnmodificar.Enabled = false;
            ModoEdicion(true);
            ImporteTotalCambio();
        }
        decimal ImporteDelFondo = 0;
        public void ModoEdicion(Boolean a)
        {
            ImporteDelFondo = decimal.Parse(txtImporteTotal.Text);
            btnDarBaja.Enabled = cboempleado.Enabled = cboempresa.Enabled = btnbusEmpleado.Enabled = cboproyecto.Enabled = !a;
            cbomoneda.Enabled = cbocuentaxpagar.Enabled = !a;
            txtPorAbonar.Visible = a; lblabonar.Visible = a;
            dtgconten.Enabled = !a;
            //dtpFechaCompensa.Enabled = !a;
        }
        public void BloquearPago(Boolean a)
        {
            cbotipo.Enabled = cbobanco.Enabled = cbocuentabanco.Enabled = txtnrooperacion.Enabled = !a;
            btnaceptar.Enabled = !a;
        }
        public void ImporteTotalCambio()
        {
            if (new int[] { 2 }.Contains(Estado))
            {
                BloquearPago(false);
                decimal ImporteTotal = 0;
                decimal.TryParse(txtImporteTotal.Text, out ImporteTotal);
                if (ImporteDelFondo > ImporteTotal)
                    lblmsgsalida.Text = "Entrada Dinero:";
                else if (ImporteDelFondo == ImporteTotal)
                {
                    BloquearPago(true);
                }
                else
                    lblmsgsalida.Text = "Salida Dinero:";
            }
            else if (Estado == 10)
            {
                lblmsgsalida.Text = "Entrada Dinero:";
                lblabonar.Visible = txtPorAbonar.Visible = false;
                txtImporteTotal.Enabled = txtPorAbonar.Enabled = false;
            }
            decimal ImporteTotal1 = 0;
            decimal.TryParse(txtImporteTotal.Text, out ImporteTotal1);
            txtPorAbonar.Text = (ImporteDelFondo - ImporteTotal1).ToString("n2");
        }
        private void txtImporteTotal_TextChanged(object sender, EventArgs e)
        {
            ImporteTotalCambio();
        }
        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            //Dar de Abaja
            Estado = 10;
            btnmodificar.Enabled = false;
            ModoEdicion(true);
            ImporteTotalCambio();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Estado == 0)
            {
                if (cboempresa.SelectedValue != null)
                {
                    CargarDatos();
                }
            }
        }
    }
}
