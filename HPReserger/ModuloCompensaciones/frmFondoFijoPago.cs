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
    public partial class frmFondoFijoPago : FormGradient
    {
        public frmFondoFijoPago()
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

        public int ContadorFacturas { get; private set; }

        string[] Empleado;
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void CargarEmpresa() { CapaLogica.TablaEmpresa(cboempresa); }
        public void CargarMoneda() { CapaLogica.TablaMoneda(cbomoneda); }
        private void frmFondoFijoPago_Load(object sender, EventArgs e)
        {
            txtglosa.CargarTextoporDefecto();
            txtnrooperacion.CargarTextoporDefecto();
            dtpFechaContable.Value = dtpFechaCompensa.Value = DateTime.Now;
            //ModoEdicion(false);
            CargarEmpresa();
            CargarMoneda();
            btnaceptar.Enabled = false;
            CargarTipoPagos();
        }
        public void CargarTipoPagos()
        {
            cbotipo.DisplayMember = "mediopago";
            cbotipo.ValueMember = "codsunat";
            cbotipo.DataSource = CapaLogica.ListadoMedioPagos();
            if (cbotipo.Items.Count > 0) cbotipo.SelectedValue = 3;
        }
        public DataTable EmpleadosCompensaciones()
        {
            return CapaLogica.ListarEmpleadosCompensaciones((int)cboempresa.SelectedValue, 1);
        }
        public void BuscarEmpleadoCompensaciones()
        {
            if (cboempresa.SelectedValue != null)
            {
                cboempleado.DataSource = EmpleadosCompensaciones();
                if (cboempleado.Items.Count == 0)
                    if (DtgcontenFacturas.DataSource != null)
                    {
                        DtgcontenFacturas.DataSource = ((DataTable)DtgcontenFacturas.DataSource).Clone();
                        //btnaceptar.Enabled = false;
                        ContarRegistros();
                    }
            }
        }
        public void ContarRegistros()
        {
            lbltotalregistros.Text = $"Total de Registros: {DtgcontenFacturas.RowCount}";
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int _idempresa;
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
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
                    cbobanco_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void cboempresa_Click(object sender, EventArgs e)
        {
            string cadena = cboempresa.Text;
            DataTable Table = CapaLogica.Empresa();
            if (cboempresa.Items.Count != Table.Rows.Count)
                cboempresa.DataSource = Table;
            cboempresa.Text = cadena;
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
            if (cboempleado.SelectedValue != null)
            {
                SacarCuentasxPagar();
                CalcularTotal();
            }
            else
            {
                if (cbocuentaxpagar.DataSource != null)
                {
                    cbocuentaxpagar.DataSource = ((DataTable)cbocuentaxpagar.DataSource).Clone();
                }
            }
            moneda = (int)cbomoneda.SelectedValue;
            CargarCuentasBancos();
        }
        private void cbocuentaxpagar_Click(object sender, EventArgs e)
        {
            if (cboempleado.SelectedValue != null)
            {
                Table = CargarCuentasxPagar();
                string cadena = cbocuentaxpagar.Text;
                if (cbocuentaxpagar.Items.Count != Table.Rows.Count)
                {
                    cbocuentaxpagar.ValueMember = "idcuenta";
                    cbocuentaxpagar.DisplayMember = "Cuenta_contable";
                    cbocuentaxpagar.DataSource = CargarCuentasxPagar();
                }
                cbocuentaxpagar.Text = cadena;
            }
        }
        public void SacarCuentasxPagar()
        {
            DataTable TableCuentas = CargarCuentasxPagar();
            string cadena = cbocuentaxpagar.Text;
            cbocuentaxpagar.ValueMember = "idcuenta";
            cbocuentaxpagar.DisplayMember = "Cuenta_contable";
            cbocuentaxpagar.DataSource = TableCuentas;
            cbocuentaxpagar.Text = cadena;
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
            DataTable TablePagar = CapaLogica.FondoFijoCuentasEmpleado((int)cboempresa.SelectedValue, 1, int.Parse(Empleado[0]), Empleado[1], tipomoneda);
            return TablePagar;
        }
        int moneda = 0;
        public void CalcularTotal()
        {
            ContadorFacturas = 0;
            btnaceptar.Enabled = false;
            cboempleado.Enabled = cboproyecto.Enabled = cboempresa.Enabled = true;
            txttotalME.Text = txttotaldifME.Text = txttotalMN.Text = txttotaldifMN.Text = "0.00";
            if (cbomoneda.SelectedValue != null)
            {
                int mon = (int)cbomoneda.SelectedValue;
                decimal sumatoriaMN = 0, diferenciaMN = 0;
                decimal sumatoriaME = 0, diferenciaME = 0;
                foreach (DataGridViewRow item in DtgcontenFacturas.Rows)
                {
                    //si esta seleccionado
                    if ((int)item.Cells[xok.Name].Value == 1)
                    {
                        ContadorFacturas++;
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
                if ((int)cbomoneda.SelectedValue == 1)
                    txtImporteTotal.Text = (sumatoriaMN + diferenciaMN).ToString("n2");
                else if ((int)cbomoneda.SelectedValue == 2)
                    txtImporteTotal.Text = (sumatoriaME + diferenciaME).ToString("n2");
            }
            ContarRegistros(); lbltotalregistros.Text += $" Total Selecionados {ContadorFacturas}";
            txtImporteTotal.ReadOnly = true;
            if (ContadorFacturas > 0)
            {
                btnaceptar.Enabled = true;
                cboempleado.Enabled = cboproyecto.Enabled = cboempresa.Enabled = false;
                txtImporteTotal.ReadOnly = false;
            }
        }
        private void dtpFechaCompensa_ValueChanged(object sender, EventArgs e)
        {
            SacarTipoCambio();
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
                    //frmtipo.ActualizoTipoCambio += Frmtipo_ActualizoTipoCambio;
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
        private void Dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarFacturaDetraccion(e.RowIndex);
            //Dtgconten.EndEdit(); Dtgconten.RefreshEdit();
            CalcularTotal();
        }
        public void SelecionarFacturaDetraccion(int _x)
        {
            DtgcontenFacturas.SuspendLayout();
            int x = _x;
            foreach (DataGridViewRow item in DtgcontenFacturas.Rows)
            {
                if (item.Index != _x)
                    if (item.Cells[xProveedor.Name].Value.ToString() == DtgcontenFacturas[xProveedor.Name, x].Value.ToString() && item.Cells[xNroComprobante.Name].Value.ToString() == DtgcontenFacturas[xNroComprobante.Name, x].Value.ToString())
                    {
                        item.Cells[xok.Name].Value = ((int)DtgcontenFacturas[xok.Name, x].Value) == 1 ? 1 : 0;
                    }
            }
            DtgcontenFacturas.ResumeLayout();
        }
        private void Dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //si damos click en el checkbutton
            if (e.ColumnIndex == DtgcontenFacturas.Columns[xok.Name].Index && e.RowIndex >= 0)
            {
                SelecionarFacturaDetraccion(e.RowIndex);
                DtgcontenFacturas.EndEdit(); DtgcontenFacturas.RefreshEdit();
            }
        }
        private void Dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            if (x >= 0)
            {
                DtgcontenFacturas[xok.Name, x].Value = ((int)DtgcontenFacturas[xok.Name, x].Value) == 1 ? 0 : 1;
            }
            else if (e.ColumnIndex == DtgcontenFacturas.Columns[xok.Name].Index && e.ColumnIndex == 0)
            {
                if (DtgcontenFacturas.RowCount > 0)
                {
                    int valor = (int)DtgcontenFacturas[xok.Name, 0].Value;
                    foreach (DataGridViewRow item in DtgcontenFacturas.Rows)
                    {
                        item.Cells[xok.Name].Value = valor == 1 ? 0 : 1;
                    }
                }
            }
            DtgcontenFacturas.EndEdit(); DtgcontenFacturas.RefreshEdit();
        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        string BanCuenta;
        int idTipocuenta;
        DataTable Table;
        private void cboempleado_Click(object sender, EventArgs e)
        {
            string cadena = cboempleado.Text;
            Table = EmpleadosCompensaciones();
            if (cboempleado.SelectedValue != null)
            {
                DataTable Table1 = FacturasxCompensa();
                if (Table1.Rows.Count != DtgcontenFacturas.RowCount)
                {
                    SacarCuentasxPagar();
                    sacarFacturasxCompensar();
                }
            }
            if (cboempleado.Items.Count != Table.Rows.Count)
            {
                cboempleado.DataSource = EmpleadosCompensaciones();
                cboempleado.Text = cadena;
            }
        }
        private void cboempleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Empleado = cboempleado.SelectedValue.ToString().Split('-');
            SacarCuentasxPagar();
            sacarFacturasxCompensar();
        }
        public DataTable FacturasxCompensa()
        {
            return CapaLogica.ListarFacturasCompensaciones(cboempleado.SelectedValue.ToString(), (int)cboempresa.SelectedValue, 1);
        }
        private void sacarFacturasxCompensar()
        {
            if (cboempleado.SelectedValue != null)
            {
                DataTable Table = FacturasxCompensa();
                DtgcontenFacturas.DataSource = Table;
                btnaceptar.Enabled = false;
                txttotalME.Text = txttotaldifME.Text = txttotalMN.Text = txttotaldifMN.Text = "0.00";
            }
            ContarRegistros();
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
            if (decimal.Parse(txtImporteTotal.Text) != 0)
            {
                if (cbobanco.SelectedValue == null)
                {
                    msg("Seleccione el Banco");
                    cbobanco.Focus(); return;
                }
                if (cbocuentabanco.SelectedValue == null)
                {
                    msg("Seleccione la cuenta del Abono");
                    cbocuentabanco.Focus(); return;
                }
            }
            if (cbotipo.Items.Count == 0) { cbotipo.Focus(); msg("Seleccione Tipo de Pago"); return; }
            int TipoPago = (int)cbotipo.SelectedValue;
            string NroOperacion = txtnrooperacion.TextValido();
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
            if ((ContadorFacturas) <= 0)
            {
                msg("No se ha Seleccionado Facturas");
                return;
            }
            //Validacion de que el periodo NO sea muy disperso, sea un mes continuo a los trabajados
            int IdEmpresa = (int)cboempresa.SelectedValue;
            DateTime FechaCoontable = dtpFechaContable.Value;
            if (!CapaLogica.ValidarCrearPeriodo(IdEmpresa, FechaCoontable))
            {
                if (HPResergerFunciones.frmPregunta.MostrarDialogYesCancel("No se Puede Registrar este Asiento\nEl Periodo no puede Crearse", $"¿Desea Crear el Periodo de {FechaCoontable.ToString("MMMM")}-{FechaCoontable.Year}?") != DialogResult.Yes)
                    return;
            }
            else if (!CapaLogica.VerificarPeriodoAbierto((int)cboempresa.SelectedValue, dtpFechaContable.Value))
            {
                msg("El Periodo Esta Cerrado, Cambie Fecha Contable"); dtpFechaContable.Focus(); return;
            }
            if (msgp("¿Seguro Desea Hacer el Abono?") == DialogResult.Yes)
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
                string[] Empleado = cboempleado.SelectedValue.ToString().Split('-');
                int TipoIdProveedor = int.Parse(Empleado[0]);
                string RucProveedor = Empleado[1];
                string NameEmpleado = cboempleado.Text.Substring(cboempleado.Text.IndexOf('-') + 2).ToUpper();
                decimal ImporteTotal = decimal.Parse(txtImporteTotal.Text);
                decimal tc = decimal.Parse(txttipocambio.Text);
                string glosa = txtglosa.TextValido();
                int IdUsuario = frmLogin.CodigoUsuario;
                string NroPago = txtnrooperacion.TextValido();
                DateTime FechaContable = dtpFechaContable.Value;
                DateTime FechaCompensa = dtpFechaCompensa.Value;
                int pkIdTipo = (int)((DataTable)cbocuentaxpagar.DataSource).Rows[cbocuentaxpagar.SelectedIndex]["pkid"];
                DateTime FechaCreacionFondoFijo = (DateTime)((DataTable)cbocuentaxpagar.DataSource).Rows[cbocuentaxpagar.SelectedIndex]["fechapago"];
                //DataRow FilaData = ((DataTable)cboempleado.DataSource).Rows[cboempleado.SelectedIndex];
                ////Datos del empleado del Reembolso
                //int TipoIdEmpleado = (int)FilaData["Tipo_ID_Emp"];
                //string NroEmpleado = FilaData["Nro_ID_Emp"].ToString();
                //string NameEmpleado = ((FilaData["Empleado"].ToString()).Split('-'))[1].Trim();
                //////
                //VALIDAMOS QUE NO EXISTAN CUENTAS CONTABLES DESACTIVADAS
                string CtaPerdida = CapaLogica.BuscarCuentas("perdida%cambio", 5).Rows[1]["idcuenta"].ToString();
                string CtaGanacia = CapaLogica.BuscarCuentas("ganancia%cambio", 5).Rows[0]["idcuenta"].ToString();
                List<string> ListaAuxiliar = new List<string>();
                foreach (DataGridViewRow item in DtgcontenFacturas.Rows)
                    if ((int)item.Cells[xok.Name].Value == 1)
                        ListaAuxiliar.Add(item.Cells[xcuenta.Name].Value.ToString());
                foreach (DataGridViewRow item in DtgcontenFacturas.Rows)
                    if ((int)item.Cells[xok.Name].Value == 1)
                        ListaAuxiliar.Add(item.Cells[xcuenta.Name].Value.ToString());
                ListaAuxiliar.Add(CtaPerdida);
                ListaAuxiliar.Add(CtaGanacia);
                ListaAuxiliar.Add(cbocuentabanco.SelectedValue.ToString());
                ListaAuxiliar.Add(cbocuentaxpagar.SelectedValue.ToString());
                if (CapaLogica.CuentaContableValidarActivas(string.Join(",", ListaAuxiliar.ToArray()), Mensajes.CuentasContablesDesactivadas)) return;
                //FIN DE LA VALDIACION DE LAS CUENTAS CONTABLES DESACTIVADAS
                string mensaje = "";
                mensaje += $"Se ha Reembolsado Fondo con Cuo {Cuo}";
                string CuoReg = Cuo;
                //FActuras
                foreach (DataGridViewRow item in DtgcontenFacturas.Rows)
                {
                    if ((int)item.Cells[xok.Name].Value == 1)
                    {
                        string[] valor = item.Cells[xNroComprobante.Name].Value.ToString().Split('-');
                        //cabeceras
                        decimal MontoSolesOri = ((int)item.Cells[xidMoneda.Name].Value) == 1 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value * (decimal)item.Cells[xTCOri.Name].Value);
                        decimal MontoDolaresOri = ((int)item.Cells[xidMoneda.Name].Value) == 2 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTCOri.Name].Value);
                        //Detalle
                        decimal MontoSolesReg = ((int)item.Cells[xidMoneda.Name].Value) == 1 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value * (decimal)item.Cells[xTcReg.Name].Value);
                        decimal MontoDolaresReg = ((int)item.Cells[xidMoneda.Name].Value) == 2 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTcReg.Name].Value);
                        //Cabecera Facturas
                        CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, item.Cells[xcuenta.Name].Value.ToString(),
                            Math.Abs(MontoSolesOri > 0 ? (moneda == 1 ? MontoSolesOri : MontoDolaresOri) : 0), Math.Abs(MontoSolesOri < 0 ? (moneda == 1 ? MontoSolesOri : MontoDolaresOri) : 0),
                            tc, proyecto, 0, Cuo, moneda, glosa, FechaCompensa, -13);
                        //Detalle del asiento
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, item.Cells[xcuenta.Name].Value.ToString(), proyecto, 5, item.Cells[xProveedor.Name].Value.ToString(),
                            item.Cells[xrazon_social.Name].Value.ToString(), (int)item.Cells[xIdComprobante.Name].Value, valor[0], valor[1], 0, (DateTime)item.Cells[xFechaEmision.Name].Value, FechaCompensa, FechaContable,
                            Math.Abs(moneda == 1 ? MontoSolesOri : MontoSolesReg), Math.Abs(moneda == 2 ? MontoDolaresOri : MontoDolaresReg),
                            moneda == (int)item.Cells[xidMoneda.Name].Value ? (decimal)item.Cells[xTCOri.Name].Value : (decimal)item.Cells[xTcReg.Name].Value,
                            (int)item.Cells[xidMoneda.Name].Value, "", "", item.Cells[xGlosa.Name].Value.ToString(), FechaCompensa, IdUsuario, "");
                        //Actualizar su Estado y Fecha de Compensacion
                        if (item.Cells[xnameComprobante.Name].Value.ToString() != "DET")
                            CapaLogica.ActualizaEstadoFacturas((int)item.Cells[xId.Name].Value, (int)item.Cells[xIdComprobante.Name].Value, 3, FechaCompensa, TipoPago, NroPago);
                    }
                }
                //Diferencial
                if (Math.Abs(decimal.Parse(txttotaldifMN.Text) + decimal.Parse(txttotaldifME.Text)) > 0)
                {
                    //cabecera                 
                    decimal diferencial = (moneda == 1 ? decimal.Parse(txttotaldifMN.Text) : decimal.Parse(txttotaldifME.Text));
                    //Cabecera Diferencial
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, (decimal.Parse(txttotaldifME.Text) + decimal.Parse(txttotaldifMN.Text)) > 0 ? CtaPerdida : CtaGanacia,
                        Math.Abs((moneda == 1 ? decimal.Parse(txttotaldifMN.Text) > 0 ? decimal.Parse(txttotaldifMN.Text) : 0 : decimal.Parse(txttotaldifME.Text) > 0 ? decimal.Parse(txttotaldifME.Text) : 0)),
                        Math.Abs((moneda == 1 ? decimal.Parse(txttotaldifMN.Text) < 0 ? decimal.Parse(txttotaldifMN.Text) : 0 : decimal.Parse(txttotaldifME.Text) < 0 ? decimal.Parse(txttotaldifME.Text) : 0)),
                        tc, proyecto, 0, Cuo, moneda, glosa, FechaCompensa, -13);
                    //Detalle Diferencial
                    CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, (decimal.Parse(txttotaldifME.Text) + decimal.Parse(txttotaldifMN.Text)) > 0 ? CtaPerdida : CtaGanacia, proyecto,
                        0, "0", "", 0, "0", "0", 0, FechaCompensa, FechaCompensa, FechaCompensa, ((diferencial < 0 ? -1 : 1) * decimal.Parse(txttotaldifMN.Text)),
                    ((diferencial < 0 ? -1 : 1) * decimal.Parse(txttotaldifME.Text)), tc, moneda, "", "", glosa, FechaCompensa, IdUsuario, "");
                }
                //Otras Cuentas x Pagar Terceros
                //cabecera otras cuentas
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, cbocuentaxpagar.SelectedValue.ToString(),
                           0, moneda == 1 ? decimal.Parse(txttotalMN.Text) + decimal.Parse(txttotaldifMN.Text) : decimal.Parse(txttotalME.Text) + decimal.Parse(txttotaldifME.Text),
                           tc, proyecto, 0, Cuo, moneda, glosa, FechaCompensa, -13);
                //detalle de otras cuentas
                foreach (DataGridViewRow item in DtgcontenFacturas.Rows)
                {
                    if ((int)item.Cells[xok.Name].Value == 1)
                    {
                        //Detalle del asiento
                        string[] valor = item.Cells[xNroComprobante.Name].Value.ToString().Split('-');
                        DateTime fecha = FechaCompensa;
                        //Tipo de Cambio Registro
                        decimal MontoSolesOri = ((int)item.Cells[xidMoneda.Name].Value) == 1 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value * (decimal)item.Cells[xTCOri.Name].Value);
                        decimal MontoDolaresOri = ((int)item.Cells[xidMoneda.Name].Value) == 2 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTCOri.Name].Value);
                        //Tipo de Cambio Original
                        decimal MontoSolesReg = ((int)item.Cells[xidMoneda.Name].Value) == 1 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value * (decimal)item.Cells[xTcReg.Name].Value);
                        decimal MontoDolaresReg = ((int)item.Cells[xidMoneda.Name].Value) == 2 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTcReg.Name].Value);
                        //
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, cbocuentaxpagar.SelectedValue.ToString(), proyecto, int.Parse(Empleado[0]), Empleado[1]
                            , NameEmpleado, (int)item.Cells[xIdComprobante.Name].Value, valor[0], valor[1], 0, (DateTime)item.Cells[xFechaEmision.Name].Value, fecha, fecha,
                            moneda == 1 ? MontoSolesReg : moneda == (int)item.Cells[xidMoneda.Name].Value ? MontoSolesReg : MontoSolesOri,
                            moneda == 2 ? MontoDolaresReg : moneda == (int)item.Cells[xidMoneda.Name].Value ? MontoDolaresReg : MontoDolaresOri,
                            moneda == (int)item.Cells[xidMoneda.Name].Value ? (decimal)item.Cells[xTCOri.Name].Value : (decimal)item.Cells[xTcReg.Name].Value,
                            (int)item.Cells[xidMoneda.Name].Value, "", "", cboempleado.SelectedValue.ToString() + " " + item.Cells[xGlosa.Name].Value.ToString(),
                            FechaCompensa, IdUsuario, "");
                    }
                }
                //Cuadre Asiento
                CapaLogica.CuadrarAsiento(CuoReg, proyecto, FechaContable, 2);
                //Fin Cuadre
                ///////////
                ///////Nuevo Asiento SALIDA DEL BANCO
                ///////////
                numasiento = 0;
                if (numasiento == 0)
                {
                    DataTable asientito = CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, FechaContable);
                    DataRow asiento = asientito.Rows[0];
                    if (asiento == null) { numasiento = 1; }
                    else
                        numasiento = ((int)asiento["codigo"]);
                }
                string CuoNext = HPResergerFunciones.Utilitarios.Cuo(numasiento, FechaContable);
                PosFila = 0;
                decimal MontoPago = decimal.Parse(txtImporteTotal.Text);
                ///Otras Cuentas x Pagar Terceros
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, cbocuentaxpagar.SelectedValue.ToString(),
                                          moneda == 1 ? decimal.Parse(txttotalMN.Text) + decimal.Parse(txttotaldifMN.Text) : decimal.Parse(txttotalME.Text) + decimal.Parse(txttotaldifME.Text),
                                          0, tc, proyecto, 0, CuoNext, moneda, glosa, FechaCompensa, -13);
                //detalle de otras cuentas x pagar a terceros                               
                ////Detalle Facturas
                string NumFac = $"FF {FechaCreacionFondoFijo.ToString(Configuraciones.ddMMyyyy)}";
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, cbocuentaxpagar.SelectedValue.ToString(), proyecto, int.Parse(Empleado[0]), Empleado[1]
                   , NameEmpleado, 0, "0", NumFac
                   // $"{FechaCompensa.ToString("d")} {Configuraciones.MayusculaCadaPalabra(NameEmpleado)}"
                   , 0, FechaCompensa, FechaCompensa, FechaCompensa, decimal.Parse(txttotalMN.Text) + (decimal.Parse(txttotaldifMN.Text)), decimal.Parse(txttotalME.Text) + decimal.Parse(txttotaldifME.Text)
                   , tc, moneda, "", "", glosa, FechaCompensa, IdUsuario, Cuo);
                //salida del banco 
                string nroKuenta = HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text);
                if (cbocuentabanco.SelectedValue == null)
                    BanCuenta = "";
                else
                    BanCuenta = cbocuentabanco.SelectedValue.ToString();
                idTipocuenta = (int)((DataTable)cbocuentabanco.DataSource).Rows[cbocuentabanco.SelectedIndex]["idtipocta"];
                //Cabecera del pago del banco
                //CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, BanCuenta,
                //     0, moneda == 1 ? decimal.Parse(txttotalMN.Text) + (decimal.Parse(txttotaldifMN.Text)) : decimal.Parse(txttotalME.Text) + (decimal.Parse(txttotaldifME.Text)),
                //     tc, proyecto, 0, CuoNext, moneda, glosa, FechaCompensa, -13);
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, BanCuenta,
                     0, MontoPago, tc, proyecto, 0, CuoNext, moneda, glosa, FechaCompensa, -13);
                //detalle del pago del banco
                //CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, BanCuenta, proyecto, int.Parse(Empleado[0]), Empleado[1]
                //  , NameEmpleado, 0, "0", $"{FechaCompensa.ToString("d")} {Configuraciones.MayusculaCadaPalabra(NameEmpleado)}"
                //  , 0, FechaCompensa, FechaCompensa, FechaCompensa, decimal.Parse(txttotalMN.Text) + (decimal.Parse(txttotaldifMN.Text)), decimal.Parse(txttotalME.Text) + decimal.Parse(txttotaldifME.Text)
                //  , tc, moneda, nroKuenta, NroPago, glosa, FechaCompensa, IdUsuario, Cuo);
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, BanCuenta, proyecto, int.Parse(Empleado[0]), Empleado[1]
                  , NameEmpleado, 0, "0", NumFac//$"{FechaCompensa.ToString("d")} {Configuraciones.MayusculaCadaPalabra(NameEmpleado)}"
                  , 0, FechaCompensa, FechaCompensa, FechaCompensa, moneda == 1 ? MontoPago : MontoPago * tc, moneda == 2 ? MontoPago : MontoPago / tc
                  , tc, moneda, nroKuenta, NroPago, glosa, FechaCompensa, IdUsuario, Cuo, TipoPago);
                //Inserto compensaciones!
                CapaLogica.InsertarCompensacionesDetalle(pkIdTipo, (int)cboempresa.SelectedValue, 1,
                        decimal.Parse(txttotalMN.Text) + (decimal.Parse(txttotaldifMN.Text)), decimal.Parse(txttotalME.Text) + decimal.Parse(txttotaldifME.Text),
                        TipoPago, TipoPago == 0 ? "" : HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text), NroPago,
                        $"{Configuraciones.MayusculaCadaPalabra(NameEmpleado)} {dtpFechaCompensa.Value.ToString("d")}", FechaCompensa, 2, Cuo);
                //
                //CapaLogica.InsertarCompensaciones((int)cboempresa.SelectedValue, 2, int.Parse(Empleado[0]), Empleado[1], decimal.Parse(txttotalMN.Text), decimal.Parse(txttotalME.Text), CuoReg,
                //    cbopago.SelectedIndex == 0 ? 3 : 7, nroKuenta, txtnrocheque.TextValido(), $"{FechaCompensa.ToString("d")} {Configuraciones.MayusculaCadaPalabra(NameEmpleado)}",
                //    FechaCompensa, 1, cbocuentaxpagar.SelectedValue.ToString(), CuoNext);

                //Cuadre Asiento
                CapaLogica.CuadrarAsiento(CuoNext, proyecto, FechaContable, 2);
                //Fin Cuadre
                msgOK(mensaje + $"\nSe hizo el pago con Cuo {CuoNext}");
                cboempleado_SelectedIndexChanged(sender, e);
                CalcularTotal();
            }
        }
        private void cbomoneda_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ContadorFacturas <= 0)
            {
                if (cboempleado.SelectedValue != null)
                {
                    cboempleado_Click(sender, e);
                }
            }
        }
    }
}
