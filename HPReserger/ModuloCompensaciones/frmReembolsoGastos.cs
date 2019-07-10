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
    public partial class frmReembolsoGastos : FormGradient
    {
        public frmReembolsoGastos()
        {
            InitializeComponent();
        }
        private string _NameEmpresa;
        public string NameEmpresa
        {
            get { return _NameEmpresa; }
            set
            {
                if (value != NameEmpresa)
                    if (NameEmpresa != null && NameEmpresa != "")
                        BuscarEmpleadoCompensaciones();
                _NameEmpresa = value;
            }
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void CargarEmpresa() { CapaLogica.TablaEmpresa(cboempresa); }
        public void CargarMoneda() { CapaLogica.TablaMoneda(cbomoneda); }
        int Estado; DataTable Table;
        private void frmReembolsoGastos_Load(object sender, EventArgs e)
        {
            txtglosa.CargarTextoporDefecto();
            txtnrocheque.CargarTextoporDefecto();
            dtpFechaContable.Value = dtpFechaCompensa.Value = DateTime.Now;
            Estado = 0;
            ModoEdicion(false);
            CargarMoneda();
            btnaceptar.Enabled = false;
            cbopago.SelectedIndex = 0;
            CargarEmpresa();
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
            DataTable TablePagar = CapaLogica.BuscarCuentas($"OTRAS CUENTAS POR PAGAR%{tipomoneda}", 5);
            return TablePagar;
        }
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        int _idempresa;
        private void cboempresa_SelectedValueChanged(object sender, EventArgs e)
        {
            //btnaceptar.Enabled = true;
            cboempleado.DisplayMember = "empleado";
            cboempleado.ValueMember = "UsuarioCompensacion";
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
                    //if (estado == 0)
                    //{
                    //    txtcodigo.Text = "0";
                    //    txttotaldebe.Text = txttotalhaber.Text = txtdiferencia.Text = "0.00";
                    //    Txtbusca_TextChanged(sender, e);
                    //}
                    //if (estado == 1)
                    //{
                    //    ultimoasiento();
                    //    txtcodigo.Text = (codigo).ToString();
                    //}
                    cbobanco_SelectedIndexChanged(sender, e);
                    BuscarEmpleadoCompensaciones();
                }
            }
        }
        public void BuscarEmpleadoCompensaciones()
        {
            if (cboempresa.SelectedValue != null)
            {
                cboempleado.DataSource = CapaLogica.ListarEmpleadosCompensaciones((int)cboempresa.SelectedValue, 2);
                if (cboempleado.Items.Count == 0)
                    if (Dtgconten.DataSource != null)
                    {
                        Dtgconten.DataSource = ((DataTable)Dtgconten.DataSource).Clone();
                        //btnaceptar.Enabled = false;
                        ContarRegistros();
                    }
            }
        }
        public void ContarRegistros()
        {
            lbltotalregistros.Text = $"Total de Registros: {Dtgconten.RowCount}";
        }
        public void ModoEdicion(Boolean a)
        {
            //btnaceptar.Enabled = a;
        }
        private void cboempleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboempleado.SelectedValue != null)
            {
                DataTable Table = CapaLogica.ListarFacturasCompensaciones(cboempleado.SelectedValue.ToString(), (int)cboempresa.SelectedValue);
                Dtgconten.DataSource = Table;
                btnaceptar.Enabled = false;
                txttotalME.Text = txttotaldifME.Text = txttotalMN.Text = txttotaldifMN.Text = "0.00";
            }
            ContarRegistros();
            PasarTipoOracion(xrazon_social);
        }
        public void PasarTipoOracion(DataGridViewColumn col)
        {
            foreach (DataGridViewRow item in Dtgconten.Rows)
                item.Cells[col.Name].Value = Configuraciones.MayusculaCadaPalabra(item.Cells[col.Name].Value.ToString());
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
        private void dtpFechaPago_ValueChanged(object sender, EventArgs e)
        {
            SacarTipoCambio();
        }
        private void cbomoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            SacarCuentasxPagar();
            CalcularTotal();
            CargarCuentasBancos();
        }
        public void SacarCuentasxPagar()
        {
            DataTable TableCuentas = CargarCuentasxPagar();
            if (TableCuentas.Rows.Count != ((DataTable)cbocuentaxpagar.DataSource ?? new DataTable()).Rows.Count)
            {
                string cadena = cbocuentaxpagar.Text;
                cbocuentaxpagar.ValueMember = "idcuenta";
                cbocuentaxpagar.DisplayMember = "Cuenta_contable";
                cbocuentaxpagar.DataSource = TableCuentas;
                cbocuentaxpagar.Text = cadena;
            }
        }
        private void Dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarFacturaDetraccion(e.RowIndex);
            //Dtgconten.EndEdit(); Dtgconten.RefreshEdit();
            CalcularTotal();
        }
        public void CalcularTotal()
        {
            int conta = 0;
            btnaceptar.Enabled = false;
            cboempleado.Enabled = cboproyecto.Enabled = cboempresa.Enabled = true;
            txttotalME.Text = txttotaldifME.Text = txttotalMN.Text = txttotaldifMN.Text = "0.00";
            if (cbomoneda.SelectedValue != null)
            {
                int mon = (int)cbomoneda.SelectedValue;
                decimal sumatoriaMN = 0, diferenciaMN = 0;
                decimal sumatoriaME = 0, diferenciaME = 0;
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    //si esta seleccionado
                    if ((int)item.Cells[xok.Name].Value == 1)
                    {
                        conta++;
                        if ((int)item.Cells[xidMoneda.Name].Value == 1)
                        {
                            //Nacional
                            sumatoriaMN += Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value);
                            //Extranjero
                            sumatoriaME += Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTCOri.Name].Value);
                            if ((int)cbomoneda.SelectedValue != 1)
                                diferenciaME += Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTcReg.Name].Value) -
                                    Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTCOri.Name].Value);

                        }
                        else if ((int)item.Cells[xidMoneda.Name].Value == 2)
                        {
                            //Nacional
                            sumatoriaMN += Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value * (decimal)item.Cells[xTCOri.Name].Value);
                            sumatoriaME += Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value);
                            if ((int)cbomoneda.SelectedValue != 2)
                                diferenciaMN += Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value * (decimal)item.Cells[xTcReg.Name].Value) -
                                Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value * (decimal)item.Cells[xTCOri.Name].Value);
                            //diferenciaMN += Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTcReg.Name].Value) -
                            //    Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTCOri.Name].Value);
                            //Extranjero
                        }
                    }
                }
                txttotalMN.Text = sumatoriaMN.ToString("n2");
                txttotaldifMN.Text = diferenciaMN.ToString("n2");
                txttotalME.Text = sumatoriaME.ToString("n2");
                txttotaldifME.Text = diferenciaME.ToString("n2");
            }
            ContarRegistros(); lbltotalregistros.Text += $" Total Selecionados {conta}";
            if (conta > 0)
            {
                btnaceptar.Enabled = true;
                cboempleado.Enabled = cboproyecto.Enabled = cboempresa.Enabled = false;
            }
        }
        public void SelecionarFacturaDetraccion(int _x)
        {
            Dtgconten.SuspendLayout();
            int x = _x;
            foreach (DataGridViewRow item in Dtgconten.Rows)
            {
                if (item.Index != _x)
                    if (item.Cells[xProveedor.Name].Value.ToString() == Dtgconten[xProveedor.Name, x].Value.ToString() && item.Cells[xNroComprobante.Name].Value.ToString() == Dtgconten[xNroComprobante.Name, x].Value.ToString())
                    {
                        item.Cells[xok.Name].Value = ((int)Dtgconten[xok.Name, x].Value) == 1 ? 1 : 0;
                    }
            }
            Dtgconten.ResumeLayout();
        }
        private void Dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //si damos click en el checkbutton
            if (e.ColumnIndex == Dtgconten.Columns[xok.Name].Index && e.RowIndex >= 0)
            {
                SelecionarFacturaDetraccion(e.RowIndex);
                Dtgconten.EndEdit(); Dtgconten.RefreshEdit();
            }
        }
        private void Dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            if (x >= 0)
            {
                Dtgconten[xok.Name, x].Value = ((int)Dtgconten[xok.Name, x].Value) == 1 ? 0 : 1;
            }
            else if (e.ColumnIndex == Dtgconten.Columns[xok.Name].Index && e.ColumnIndex == 0)
            {
                if (Dtgconten.RowCount > 0)
                {
                    int valor = (int)Dtgconten[xok.Name, 0].Value;
                    foreach (DataGridViewRow item in Dtgconten.Rows)
                    {
                        item.Cells[xok.Name].Value = valor == 1 ? 0 : 1;
                    }
                }
            }
            Dtgconten.EndEdit(); Dtgconten.RefreshEdit();
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
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
        }
        public DialogResult msgOk(string cadena)
        {
            return HPResergerFunciones.Utilitarios.msgOkCancel(cadena);
        }
        string BanCuenta;
        int idTipocuenta;
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
            if (cbopago.SelectedIndex < 0)
            {
                msg("Seleccione el Pago");
                cbopago.Focus(); return;
            }
            if (cbocuentabanco.SelectedValue == null)
            {
                msg("Seleccione la cuenta del Abono");
                cbocuentabanco.Focus(); return;
            }
            if (decimal.Parse(txttotalMN.Text) <= 0)
            {
                msg("El monto del Desembolso debe ser Mayor a Cero");
                Dtgconten.Focus(); return;
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
            if (!CapaLogica.VerificarPeriodoAbierto((int)cboempresa.SelectedValue, dtpFechaContable.Value))
            {
                msg("El Periodo Esta Cerrado, Cambie Fecha Contable"); dtpFechaContable.Focus(); return;
            }
            if (msgOk("¿Seguro Desea Hacer el Abono?") == DialogResult.OK)
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
                string mensaje = "";
                string Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, dtpFechaContable.Value);
                mensaje += $"Se ha Reembolsado Abono con cuo {Cuo}";
                int TipoPago = 0;
                if (cbopago.Text == "003 Transferencias Fondos") TipoPago = 3;
                else if (cbopago.Text == "007 Cheque.") TipoPago = 7;
                string NroPago = txtnrocheque.TextValido();
                string CuoReg = Cuo;
                int moneda = (int)cbomoneda.SelectedValue;
                int proyecto = (int)cboproyecto.SelectedValue;
                //FActuras
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if ((int)item.Cells[xok.Name].Value == 1)
                    {
                        string[] valor = item.Cells[xNroComprobante.Name].Value.ToString().Split('-');
                        DateTime fecha = dtpFechaCompensa.Value;
                        //cabeceras
                        decimal MontoSolesOri = ((int)item.Cells[xidMoneda.Name].Value) == 1 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value * (decimal)item.Cells[xTCOri.Name].Value);
                        decimal MontoDolaresOri = ((int)item.Cells[xidMoneda.Name].Value) == 2 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTCOri.Name].Value);
                        //Detalle
                        decimal MontoSolesReg = ((int)item.Cells[xidMoneda.Name].Value) == 1 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value * (decimal)item.Cells[xTcReg.Name].Value);
                        decimal MontoDolaresReg = ((int)item.Cells[xidMoneda.Name].Value) == 2 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTcReg.Name].Value);
                        //Cabecera Facturas
                        CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, dtpFechaContable.Value, item.Cells[xcuenta.Name].Value.ToString(),
                            Math.Abs(MontoSolesOri > 0 ? (moneda == 1 ? MontoSolesOri : MontoDolaresOri) : 0), Math.Abs(MontoSolesOri < 0 ? (moneda == 1 ? MontoSolesOri : MontoDolaresOri) : 0),
                            decimal.Parse(txttipocambio.Text), proyecto, 0, Cuo, moneda, txtglosa.TextValido(), dtpFechaCompensa.Value, -8);
                        //Detalle del asiento
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, dtpFechaContable.Value, item.Cells[xcuenta.Name].Value.ToString(), proyecto, 5, item.Cells[xProveedor.Name].Value.ToString(),
                            item.Cells[xrazon_social.Name].Value.ToString(), (int)item.Cells[xIdComprobante.Name].Value, valor[0], valor[1], 0, (DateTime)item.Cells[xFechaEmision.Name].Value, fecha, fecha,
                            Math.Abs(moneda == 1 ? MontoSolesOri : MontoSolesReg), Math.Abs(moneda == 2 ? MontoDolaresOri : MontoDolaresReg),
                            moneda == (int)item.Cells[xidMoneda.Name].Value ? (decimal)item.Cells[xTCOri.Name].Value : (decimal)item.Cells[xTcReg.Name].Value,
                            (int)item.Cells[xidMoneda.Name].Value, "", "", item.Cells[xGlosa.Name].Value.ToString(), dtpFechaCompensa.Value, frmLogin.CodigoUsuario, "");
                        //Actualizar su Estado y Fecha de Compensacion
                        if (item.Cells[xnameComprobante.Name].Value.ToString() != "DET")
                            CapaLogica.ActualizaEstadoFacturas((int)item.Cells[xId.Name].Value, (int)item.Cells[xIdComprobante.Name].Value, 3, dtpFechaCompensa.Value, TipoPago, NroPago);
                    }
                }
                //Diferencial
                if (Math.Abs(decimal.Parse(txttotaldifMN.Text) + decimal.Parse(txttotaldifME.Text)) > 0)
                {
                    //cabecera
                    string CtaPerdida = CapaLogica.BuscarCuentas("perdida%cambio", 5).Rows[1]["idcuenta"].ToString();
                    string CtaGanacia = CapaLogica.BuscarCuentas("ganancia%cambio", 5).Rows[0]["idcuenta"].ToString();
                    DateTime fecha = dtpFechaCompensa.Value;
                    decimal diferencial = (moneda == 1 ? decimal.Parse(txttotaldifMN.Text) : decimal.Parse(txttotaldifME.Text));
                    decimal Tc = decimal.Parse(txttipocambio.Text);
                    //Cabecera Diferencial
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, dtpFechaContable.Value, (decimal.Parse(txttotaldifME.Text) + decimal.Parse(txttotaldifMN.Text)) > 0 ? CtaPerdida : CtaGanacia,
                        Math.Abs((moneda == 1 ? decimal.Parse(txttotaldifMN.Text) > 0 ? decimal.Parse(txttotaldifMN.Text) : 0 : decimal.Parse(txttotaldifME.Text) > 0 ? decimal.Parse(txttotaldifME.Text) : 0)),
                        Math.Abs((moneda == 1 ? decimal.Parse(txttotaldifMN.Text) < 0 ? decimal.Parse(txttotaldifMN.Text) : 0 : decimal.Parse(txttotaldifME.Text) < 0 ? decimal.Parse(txttotaldifME.Text) : 0)),
                        decimal.Parse(txttipocambio.Text), proyecto, 0, Cuo, moneda, txtglosa.TextValido(), dtpFechaCompensa.Value, -8);
                    //Detalle Diferencial
                    CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, dtpFechaContable.Value, (decimal.Parse(txttotaldifME.Text) + decimal.Parse(txttotaldifMN.Text)) > 0 ? CtaPerdida : CtaGanacia, proyecto,
                        0, "0", "", 0, "0", "0", 0, fecha, fecha, fecha, ((diferencial < 0 ? -1 : 1) * decimal.Parse(txttotaldifMN.Text)),
                    ((diferencial < 0 ? -1 : 1) * decimal.Parse(txttotaldifME.Text)), Tc, moneda, "", "", txtglosa.TextValido(), dtpFechaCompensa.Value, frmLogin.CodigoUsuario, "");
                }
                //Otras Cuentas x Pagar Terceros
                //cabecera otras cuentas
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, dtpFechaContable.Value, cbocuentaxpagar.SelectedValue.ToString(),
                           0, moneda == 1 ? decimal.Parse(txttotalMN.Text) + decimal.Parse(txttotaldifMN.Text) : decimal.Parse(txttotalME.Text) + decimal.Parse(txttotaldifME.Text), decimal.Parse(txttipocambio.Text), proyecto, 0, Cuo, moneda, txtglosa.TextValido(), dtpFechaCompensa.Value, -8);
                //detalle de otras cuentas
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if ((int)item.Cells[xok.Name].Value == 1)
                    {
                        //Detalle del asiento
                        string[] valor = item.Cells[xNroComprobante.Name].Value.ToString().Split('-');
                        DateTime fecha = dtpFechaCompensa.Value;
                        //Tipo de Cambio Registro
                        decimal MontoSolesOri = ((int)item.Cells[xidMoneda.Name].Value) == 1 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value * (decimal)item.Cells[xTCOri.Name].Value);
                        decimal MontoDolaresOri = ((int)item.Cells[xidMoneda.Name].Value) == 2 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTCOri.Name].Value);
                        //Tipo de Cambio Original
                        decimal MontoSolesReg = ((int)item.Cells[xidMoneda.Name].Value) == 1 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value * (decimal)item.Cells[xTcReg.Name].Value);
                        decimal MontoDolaresReg = ((int)item.Cells[xidMoneda.Name].Value) == 2 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTcReg.Name].Value);
                        //
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, dtpFechaContable.Value, cbocuentaxpagar.SelectedValue.ToString(), proyecto, 5, item.Cells[xProveedor.Name].Value.ToString()
                            , item.Cells[xrazon_social.Name].Value.ToString(), (int)item.Cells[xIdComprobante.Name].Value, valor[0], valor[1], 0, (DateTime)item.Cells[xFechaEmision.Name].Value, fecha, fecha,
                            moneda == 1 ? MontoSolesReg : moneda == (int)item.Cells[xidMoneda.Name].Value ? MontoSolesReg : MontoSolesOri,
                            moneda == 2 ? MontoDolaresReg : moneda == (int)item.Cells[xidMoneda.Name].Value ? MontoDolaresReg : MontoDolaresOri,
                            moneda == (int)item.Cells[xidMoneda.Name].Value ? (decimal)item.Cells[xTCOri.Name].Value : (decimal)item.Cells[xTcReg.Name].Value,
                            (int)item.Cells[xidMoneda.Name].Value, "", "", cboempleado.SelectedValue.ToString() + " " + item.Cells[xGlosa.Name].Value.ToString(),
                            dtpFechaCompensa.Value, frmLogin.CodigoUsuario, "");
                    }
                }
                ///////////
                ///////Nuevo Asiento SALIDA DEL BANCO
                ///////////
                numasiento = 0;
                if (numasiento == 0)
                {
                    DataTable asientito = CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, dtpFechaContable.Value);
                    DataRow asiento = asientito.Rows[0];
                    if (asiento == null) { numasiento = 1; }
                    else
                        numasiento = ((int)asiento["codigo"]);
                }
                string CuoNext = HPResergerFunciones.Utilitarios.Cuo(numasiento, dtpFechaContable.Value);
                PosFila = 0;
                ///Otras Cuentas x Pagar Terceros
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, dtpFechaContable.Value, cbocuentaxpagar.SelectedValue.ToString(),
                                          moneda == 1 ? decimal.Parse(txttotalMN.Text) + decimal.Parse(txttotaldifMN.Text) : decimal.Parse(txttotalME.Text) + decimal.Parse(txttotaldifME.Text),
                                          0, decimal.Parse(txttipocambio.Text), proyecto, 0, CuoNext, moneda, txtglosa.TextValido(), dtpFechaCompensa.Value, -8);
                //detalle de otras cuentas x pagar a terceros
                string[] UserCompensa = cboempleado.SelectedValue.ToString().Split('-');
                DateTime fechac = dtpFechaCompensa.Value;
                ////Detalle Facturas
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, dtpFechaContable.Value, cbocuentaxpagar.SelectedValue.ToString(), proyecto, int.Parse(UserCompensa[0]), UserCompensa[1]
                   , cboempleado.Text.Substring(cboempleado.Text.IndexOf('-') + 2), 0, "0", $"{dtpFechaCompensa.Value.ToString("d")} {Configuraciones.MayusculaCadaPalabra(cboempleado.Text.Substring(cboempleado.Text.IndexOf('-') + 2))}"
                   , 0, fechac, fechac, fechac, decimal.Parse(txttotalMN.Text) + (decimal.Parse(txttotaldifMN.Text)), decimal.Parse(txttotalME.Text) + decimal.Parse(txttotaldifME.Text)
                   , decimal.Parse(txttipocambio.Text), moneda, "", "", txtglosa.TextValido(), dtpFechaCompensa.Value, frmLogin.CodigoUsuario, Cuo);
                //salida del banco 
                string nroKuenta = HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text);
                if (cbocuentabanco.SelectedValue == null)
                    BanCuenta = "";
                else
                    BanCuenta = cbocuentabanco.SelectedValue.ToString();
                idTipocuenta = (int)((DataTable)cbocuentabanco.DataSource).Rows[cbocuentabanco.SelectedIndex]["idtipocta"];
                //Cabecera del pago del banco            
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, dtpFechaContable.Value, BanCuenta,
                     0, moneda == 1 ? decimal.Parse(txttotalMN.Text) + (decimal.Parse(txttotaldifMN.Text)) : decimal.Parse(txttotalME.Text) + (decimal.Parse(txttotaldifME.Text)),
                     decimal.Parse(txttipocambio.Text), proyecto, 0, CuoNext, moneda, txtglosa.TextValido(), dtpFechaCompensa.Value, -8);
                //detalle del pago del banco
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, dtpFechaContable.Value, BanCuenta, proyecto, int.Parse(UserCompensa[0]), UserCompensa[1]
                  , cboempleado.Text.Substring(cboempleado.Text.IndexOf('-') + 2), 0, "0", $"{dtpFechaCompensa.Value.ToString("d")} {Configuraciones.MayusculaCadaPalabra(cboempleado.Text.Substring(cboempleado.Text.IndexOf('-') + 2))}"
                  , 0, fechac, fechac, fechac, decimal.Parse(txttotalMN.Text) + (decimal.Parse(txttotaldifMN.Text)), decimal.Parse(txttotalME.Text) + decimal.Parse(txttotaldifME.Text)
                  , decimal.Parse(txttipocambio.Text), moneda, nroKuenta, "", txtglosa.TextValido(), dtpFechaCompensa.Value, frmLogin.CodigoUsuario, Cuo);
                //Inserto compensaciones!
                CapaLogica.InsertarCompensaciones((int)cboempresa.SelectedValue, 2, int.Parse(UserCompensa[0]), UserCompensa[1], decimal.Parse(txttotalMN.Text), decimal.Parse(txttotalME.Text), CuoReg,
                    cbopago.SelectedIndex == 0 ? 3 : 7, nroKuenta, txtnrocheque.TextValido(), $"{dtpFechaCompensa.Value.ToString("d")} {Configuraciones.MayusculaCadaPalabra(cboempleado.Text.Substring(cboempleado.Text.IndexOf('-') + 2))}",
                    dtpFechaCompensa.Value, 1, cbocuentaxpagar.SelectedValue.ToString(), CuoNext);
                //Cuadre Asiento
                CapaLogica.CuadrarAsiento(CuoNext, proyecto, dtpFechaContable.Value, 2);
                //Fin Cuadre
                msg(mensaje + $"\nSe hizo el pago con Cuo {CuoNext}");
                cboempleado_SelectedIndexChanged(sender, e);
                CalcularTotal();
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        frmListarCompensaciones listcompensa;
        private void btnVer_Click(object sender, EventArgs e)
        {
            if (listcompensa == null)
            {
                listcompensa = new frmListarCompensaciones((int)cboempresa.SelectedValue);
                listcompensa.MdiParent = this.MdiParent;
                listcompensa.FormClosed += Listcompensa_FormClosed;
                listcompensa.Show();
            }
            else { listcompensa.Activate(); }
        }

        private void Listcompensa_FormClosed(object sender, FormClosedEventArgs e)
        {
            listcompensa = null;
        }

        private void lbltotalregistros_Click(object sender, EventArgs e)
        {

        }

        private void cbocuentaxpagar_Click(object sender, EventArgs e)
        {

        }

        private void cboempresa_Click(object sender, EventArgs e)
        {
            string cadena = cboempresa.Text;
            DataTable Table = CapaLogica.Empresa();
            if (cboempresa.Items.Count != Table.Rows.Count)
                cboempresa.DataSource = Table;
            cboempresa.Text = cadena;
        }
        private void cboempleado_Click(object sender, EventArgs e)
        {
            if (cboempresa.SelectedValue != null)
            {
                DataTable Tablita = CapaLogica.ListarEmpleadosCompensaciones((int)cboempresa.SelectedValue, 2);
                if (cboempleado.Items.Count != Tablita.Rows.Count)
                {
                    BuscarEmpleadoCompensaciones();
                }
            }
            if (cboempleado.SelectedValue != null)
            {
                DataTable Table = CapaLogica.ListarFacturasCompensaciones(cboempleado.SelectedValue.ToString(), (int)cboempresa.SelectedValue);

                if (Dtgconten.RowCount != Table.Rows.Count)
                {
                    Dtgconten.DataSource = Table;
                }
            }
        }
    }
}
