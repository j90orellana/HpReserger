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
    public partial class frmListarCompensacionesAnticipo : FormGradient
    {
        public frmListarCompensacionesAnticipo()
        {
            InitializeComponent();
            txtglosa.CargarTextoporDefecto(); txtnrocheque.CargarTextoporDefecto();
            dtpFechaContable.Value = dtpFechaCompensa.Value = DateTime.Now;
            CargarMoneda();
            CargarEmpresa();
            CargarProveedores();
        }
        public frmListarCompensacionesAnticipo(int _fkEmpresa, string _Proveedor)
        {
            InitializeComponent();
            txtglosa.CargarTextoporDefecto(); txtnrocheque.CargarTextoporDefecto();
            dtpFechaContable.Value = dtpFechaCompensa.Value = DateTime.Now;
            CargarMoneda();
            CargarEmpresa();
            CargarProveedores();
            cboempresa.SelectedValue = _fkEmpresa;
            cboproveedor.Text = _Proveedor;
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        int _idempresa;
        private string _NameEmpresa;
        public string NameEmpresa
        {
            get { return _NameEmpresa; }
            set
            {
                if (value != NameEmpresa)
                    //if (NameEmpresa != null && NameEmpresa != "")
                    //    cboempleado_SelectedIndexChanged(new object(), new EventArgs());
                    _NameEmpresa = value;
            }
        }
        public void CargarMoneda() { CapaLogica.TablaMoneda(cbomoneda); }
        public void CargarEmpresa() { CapaLogica.TablaEmpresa(cboempresa); }
        public void CargarProveedores()
        {
            CapaLogica.TablaProveedores(cboproveedor, fkEmpresa);
            if (cboproveedor.Items.Count == 0)
            {
                ///
                DtgcontenAnticipos.DataSource = ((DataTable)DtgcontenAnticipos.DataSource ?? new DataTable()).Clone();
                ///
                DtgcontenFacturas.DataSource = ((DataTable)DtgcontenFacturas.DataSource ?? new DataTable()).Clone();
            }
        }
        private void frmListarCompensacionesReembolso_Load(object sender, EventArgs e)
        {

        }
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
                    fkEmpresa = _idempresa = (int)cboempresa.SelectedValue;
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
                    CargarProveedores();
                    //cboproveedor_SelectedIndexChanged(sender, e);
                }
            }
        }
        int fkEmpresa = 99;
        public DataTable TablaProveedores()
        {
            fkEmpresa = 99;
            //combo.DisplayMember = "proveedor";
            //combo.ValueMember = "TipoidNumDoc";
            if (cboempresa.SelectedValue != null) fkEmpresa = (int)cboempresa.SelectedValue;
            return CapaLogica.ListarProveedoresCompensaciones(fkEmpresa);
        }
        //public DataTable TablaEmpresa()
        //{
        //    //combo.DisplayMember = "proveedor";
        //    //combo.ValueMember = "TipoidNumDoc";
        //    //return CapaLogica.ListarProveedoresCompensaciones();
        //}
        private void cboempresa_Click(object sender, EventArgs e)
        {
            string cadena = cboempresa.Text;
            DataTable Table = CapaLogica.Empresa();
            if (cboempresa.Items.Count != Table.Rows.Count)
                cboempresa.DataSource = Table;
            cboempresa.Text = cadena;
        }
        private void cboproveedor_Click(object sender, EventArgs e)
        {
            string cadena = cboproveedor.Text;
            DataTable Table = TablaProveedores();
            if (cboproveedor.Items.Count != Table.Rows.Count)
                cboproveedor.DataSource = Table;
            cboproveedor.Text = cadena;
            if (cboproveedor.SelectedValue != null)
            {
                string[] valor = cboproveedor.SelectedValue.ToString().Split('-');
                DataTable Table1 = CapaLogica.ListarCompensacionesxPagar(_idempresa, 4, int.Parse(valor[0]), valor[1], 2);
                if (DtgcontenAnticipos.RowCount != Table1.Rows.Count)
                {
                    cboproveedor_SelectedIndexChanged(sender, e); return;
                }
                Table1 = CapaLogica.ListarFacturasAnticipos(valor[1], (int)cboempresa.SelectedValue);
                if (DtgcontenFacturas.RowCount != Table1.Rows.Count)
                {
                    cboproveedor_SelectedIndexChanged(sender, e);
                    return;
                }
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
            DataTable TablePagar = CapaLogica.BuscarCuentas($"4%ANTICIPOS%{tipomoneda}", 55, "D");
            return TablePagar;
        }
        private void cbomoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbocuentaxpagar.ValueMember = "idcuenta";
            //cbocuentaxpagar.DisplayMember = "Cuenta_contable";
            //cbocuentaxpagar.DataSource = CargarCuentasxPagar();
            CalcularTotales();
            CargarCuentasBancos();
        }
        public void ContarRegistros()
        {
            CalcularTotales();
            //lbltotalregistros.Text = $"Total de Registros: {DtgcontenFacturas.RowCount}";
        }
        private void cboproveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContaFacturas = ContaAnticipos = 0;
            ImporteTotal = 0;
            if (cboproveedor.SelectedValue != null)
            {
                //Compensaciones
                string[] valor = cboproveedor.SelectedValue.ToString().Split('-');
                DataTable Table = CapaLogica.ListarCompensacionesxPagar(_idempresa, 4, int.Parse(valor[0]), valor[1], 2);
                DataColumn ColumnaOk = new DataColumn("ok", typeof(int));
                ColumnaOk.DefaultValue = 0;
                Table.Columns.Add(ColumnaOk);
                DtgcontenAnticipos.DataSource = Table;
                //Facturas               
                DataTable Tablex = CapaLogica.ListarFacturasAnticipos(valor[1], (int)cboempresa.SelectedValue);
                DtgcontenFacturas.DataSource = Tablex;
                FacturasDolares = FacturasSoles = 0;
                AnticipoDolares = AnticipoSoles = 0;
            }
            CalcularTotales();
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
        public void CargarCuentasBancos()
        {
            if (cboempresa.SelectedValue != null && cbobanco.SelectedValue != null)
            {
                cbocuentabanco.ValueMember = "Id_Cuenta_Contable";
                cbocuentabanco.DisplayMember = "banco";
                cbocuentabanco.DataSource = CapaLogica.ListarBancosTiposdePagoxEmpresa(cbobanco.SelectedValue.ToString(), (int)cboempresa.SelectedValue, (int)cbomoneda.SelectedValue);
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
        private void DtgcontenAnticipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //si damos click en el checkbutton
            if (e.ColumnIndex == DtgcontenAnticipos.Columns[yOk.Name].Index)
            {
                DtgcontenAnticipos.EndEdit(); DtgcontenAnticipos.RefreshEdit();
            }
        }
        private void DtgcontenAnticipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            if (x >= 0)
            {
                DtgcontenAnticipos[yOk.Name, x].Value = ((int)DtgcontenAnticipos[yOk.Name, x].Value) == 1 ? 0 : 1;
            }
            else if (e.ColumnIndex == DtgcontenAnticipos.Columns[yOk.Name].Index)
            {
                if (DtgcontenAnticipos.RowCount > 0)
                {
                    int valor = (int)DtgcontenAnticipos[yOk.Name, 0].Value;
                    foreach (DataGridViewRow item in DtgcontenAnticipos.Rows)
                    {
                        item.Cells[yOk.Name].Value = valor == 1 ? 0 : 1;
                    }
                }
            }
            DtgcontenAnticipos.EndEdit(); DtgcontenAnticipos.RefreshEdit();
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

        private void DtgcontenFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //si damos click en el checkbutton
            if (e.ColumnIndex == DtgcontenFacturas.Columns[xok.Name].Index && e.RowIndex >= 0)
            {
                SelecionarFacturaDetraccion(e.RowIndex);
                DtgcontenFacturas.EndEdit(); DtgcontenFacturas.RefreshEdit();
            }
        }

        private void DtgcontenFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            if (x >= 0)
            {
                DtgcontenFacturas[xok.Name, x].Value = ((int)DtgcontenFacturas[xok.Name, x].Value) == 1 ? 0 : 1;
            }
            else if (e.ColumnIndex == DtgcontenFacturas.Columns[xok.Name].Index)
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
        //ANTICIPOS
        int ContaAnticipos, ContaFacturas;
        decimal AnticipoSoles, AnticipoDolares;
        decimal FacturasSoles, FacturasDolares;
        private void DtgcontenAnticipos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ContaAnticipos = 0;
            AnticipoSoles = 0;
            AnticipoDolares = 0;
            foreach (DataGridViewRow item in DtgcontenAnticipos.Rows)
            {
                if ((int)item.Cells[yOk.Name].Value == 1)
                {
                    ContaAnticipos++;
                    AnticipoSoles += (decimal)item.Cells[xMontoMN.Name].Value;
                    AnticipoDolares += (decimal)item.Cells[xMontoME.Name].Value;
                }
            }
            CalcularTotales();
        }
        public void OcultarOpcionesPago(Boolean a)
        {
            lblbanco.Visible = lblmsgsalida.Visible = cbobanco.Visible = cbocuentabanco.Visible = txtnrocheque.Visible = !a;
        }
        private void cbopago_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbobanco.Enabled = cbocuentabanco.Enabled = txtnrocheque.Enabled = true;
            txtPorAbonar.Enabled = true;
            OcultarOpcionesPago(false);
            //Transferencia de Fondos
            if (cbopago.Text == "003 Transferencias Fondos")
            {
                if (!txtnrocheque.EstaLLeno())
                    txtnrocheque.Text = txtnrocheque.TextoDefecto = "Ingrese Nro Operación";
            }
            //Cheques
            else if (cbopago.Text == "007 Cheque.")
            {
                if (!txtnrocheque.EstaLLeno())
                    txtnrocheque.Text = txtnrocheque.TextoDefecto = "Ingrese Nro Cheque";
            }
            else if (cbopago.Text == "000 Ninguno.")
            {
                cbobanco.Enabled = cbocuentabanco.Enabled = txtnrocheque.Enabled = false;
                txtPorAbonar.Enabled = false;
                OcultarOpcionesPago(true);
            }
        }
        private void txtImporteTotal_TextChanged(object sender, EventArgs e)
        {
            cbobanco.Enabled = cbocuentabanco.Enabled = cbopago.Enabled = txtnrocheque.Enabled = true;
            string cadena = cbopago.Text;
            string valorCompensa = "000 Ninguno.";
            if (ImporteTotal == 0)
            {
                cbobanco.Enabled = cbocuentabanco.Enabled = cbopago.Enabled = txtnrocheque.Enabled = false;
            }
            else if (ImporteTotal > 0)
            {
                lblmsgsalida.Text = "Salida Dinero:";
                cbopago.Items.Remove(valorCompensa);
            }
            else
            {
                lblmsgsalida.Text = "Entrada Dinero:";
                if (ContaFacturas > 0)
                {
                    cbopago.Items.Remove(valorCompensa);
                    cbopago.Items.Insert(0, valorCompensa);
                }
                else
                    cbopago.Items.Remove(valorCompensa);
            }
            cbopago.Text = cadena;
        }
        public DialogResult msgOk(string cadena)
        {
            return HPResergerFunciones.Utilitarios.msgOkCancel(cadena);
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (ContaAnticipos + ContaFacturas > 0)
            {
                if (msgOk("¿Seguro Desea Salir?") == DialogResult.OK) this.Close();
            }
            else
                this.Close();
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
            if (cboproveedor.SelectedValue == null)
            {
                msg("Seleccione el Proveedor");
                cboproveedor.Focus(); return;
            }
            if (cbomoneda.SelectedValue == null)
            {
                msg("Seleccione la Moneda");
                cbomoneda.Focus(); return;
            }
            if (decimal.Parse(txtImporteTotal.Text) != 0)
            {
                if (cbopago.Text != "000 Ninguno.")
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
                    if (!txtnrocheque.EstaLLeno())
                    {
                        msg("Ingrese Valor De Nro Operacion - Cheque");
                        txtnrocheque.Focus(); return;
                    }
                    if (cbopago.Text == "")
                    {
                        msg("Seleccione Tipo de Pago");
                        cbopago.Focus(); return;
                    }
                    //msg("No se pudo Avanzar - msg 1039");
                    //return;
                }
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
            if ((ContaAnticipos + ContaFacturas) <= 0)
            {
                msg("No se ha Seleccionado Facturas ni Anticipos");
                return;
            }
            if (!CapaLogica.VerificarPeriodoAbierto((int)cboempresa.SelectedValue, dtpFechaContable.Value))
            {
                msg("El Periodo Esta Cerrado, Cambie Fecha Contable"); dtpFechaContable.Focus(); return;
            }
            if (msgOk("¿Seguro Desea Aplicar el Anticipo?") == DialogResult.OK)
            {
                //Asientos
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
                string[] Proveedor = cboproveedor.SelectedValue.ToString().Split('-');
                int TipoIdProveedor = int.Parse(Proveedor[0]);
                string RucProveedor = Proveedor[1];
                string NameProveedor = cboproveedor.Text;
                decimal ImporteTotal = decimal.Parse(txtImporteTotal.Text);
                decimal tc = decimal.Parse(txttipocambio.Text);
                string glosa = txtglosa.TextValido();
                int TipoPago = 0;
                if (cbopago.Text == "003 Transferencias Fondos") TipoPago = 3;
                else if (cbopago.Text == "007 Cheque.") TipoPago = 7;
                string NroPago = txtnrocheque.TextValido();
                DateTime FechaContable = dtpFechaContable.Value;
                DateTime FechaCompensa = dtpFechaCompensa.Value;
                ///
                string IdBanco = cbobanco.SelectedValue.ToString();
                string nroKuenta = "";
                if (cbocuentabanco.SelectedValue != null)
                    nroKuenta = HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text);
                //Facturas al Debe      -- xok
                foreach (DataGridViewRow item in DtgcontenFacturas.Rows)
                {
                    if ((int)item.Cells[xok.Name].Value == 1)
                    {
                        //Asiento de las facturas al debe
                        string CuentaContable = item.Cells[xcuenta.Name].Value.ToString();
                        decimal TC = (decimal)item.Cells[xTcReg.Name].Value;
                        int IdComprobante = (int)item.Cells[xIdComprobante.Name].Value;
                        string[] NumFac = item.Cells[xNroComprobante.Name].Value.ToString().Split('-');
                        int idUsuario = frmLogin.CodigoUsuario;
                        DateTime fecha = dtpFechaCompensa.Value;
                        //cabeceras
                        decimal MontoSolesOri = ((int)item.Cells[xidMoneda.Name].Value) == 1 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value * (decimal)item.Cells[xTCOri.Name].Value);
                        decimal MontoDolaresOri = ((int)item.Cells[xidMoneda.Name].Value) == 2 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTCOri.Name].Value);
                        //Detalle
                        decimal MontoSolesReg = ((int)item.Cells[xidMoneda.Name].Value) == 1 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value * (decimal)item.Cells[xTcReg.Name].Value);
                        decimal MontoDolaresReg = ((int)item.Cells[xidMoneda.Name].Value) == 2 ? (decimal)item.Cells[xTotal.Name].Value : Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTcReg.Name].Value);
                        //Cabecera Facturas
                        CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaContable,
                            Math.Abs(MontoSolesOri > 0 ? (moneda == 1 ? MontoSolesOri : MontoDolaresOri) : 0), Math.Abs(MontoSolesOri < 0 ? (moneda == 1 ? MontoSolesOri : MontoDolaresOri) : 0),
                            tc, proyecto, 0, Cuo, moneda, glosa, FechaCompensa, -11);
                        //Detalle del asiento
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, proyecto, TipoIdProveedor, RucProveedor,
                            NameProveedor, IdComprobante, NumFac[0], NumFac[1], 0, (DateTime)item.Cells[xFechaEmision.Name].Value, fecha, fecha,
                            Math.Abs(moneda == 1 ? MontoSolesOri : MontoSolesReg), Math.Abs(moneda == 2 ? MontoDolaresOri : MontoDolaresReg),
                            moneda == (int)item.Cells[xidMoneda.Name].Value ? (decimal)item.Cells[xTCOri.Name].Value : (decimal)item.Cells[xTcReg.Name].Value,
                            (int)item.Cells[xidMoneda.Name].Value, "", "", glosa, FechaContable, idUsuario, "");
                        ///Actualizo las Facturas a Pagadas
                        if (item.Cells[xnameComprobante.Name].Value.ToString() != "DET")
                            CapaLogica.ActualizaEstadoFacturas((int)item.Cells[xId.Name].Value, (int)item.Cells[xIdComprobante.Name].Value, 3, dtpFechaCompensa.Value, TipoPago, NroPago);
                        else
                        {
                            decimal TotalDetracion = (decimal)item.Cells[xTotal.Name].Value;
                            CapaLogica.Detracciones(1, string.Join("-", NumFac), RucProveedor, TotalDetracion, MontoSolesOri, tc, TotalDetracion, 0, NroPago, IdBanco, nroKuenta, FechaCompensa, idUsuario
                                , IdComprobante, _idempresa, Cuo);
                        }
                    }
                }
                //Entrada Salida de Dinero(Bancos)
                if (ImporteTotal != 0 && cbopago.Text != "000 Ninguno.")
                {
                    string CuentaContable = "";
                    if (cbocuentabanco.SelectedValue == null) CuentaContable = ""; else CuentaContable = cbocuentabanco.SelectedValue.ToString();
                    decimal MontoSoles = Configuraciones.Redondear(moneda == 1 ? ImporteTotal : ImporteTotal * tc);
                    decimal MontoDolares = Configuraciones.Redondear(moneda == 2 ? ImporteTotal : ImporteTotal / tc);
                    decimal TC = tc;
                    string[] NumFac = $"0-Ant.{ dtpFechaCompensa.Value.ToString("d")}".Split('-');
                    int idfac = 0;
                    //si se Abono el Total de la Factura
                    if (Math.Abs(ImporteTotal) - decimal.Parse(txtPorAbonar.Text) == 0)
                    {
                        //Asiento Cabecera
                        CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaContable
                               , Math.Abs(ImporteTotal < 0 ? moneda == 1 ? MontoSoles : MontoDolares : 0)
                               , Math.Abs(ImporteTotal > 0 ? moneda == 1 ? MontoSoles : MontoDolares : 0)
                               , decimal.Parse(txttipocambio.Text), proyecto, 0, Cuo, moneda, glosa, dtpFechaCompensa.Value, -11);
                        //Detalle del asiento
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, proyecto, TipoIdProveedor, RucProveedor
                            , NameProveedor, idfac, NumFac[0], NumFac[1], 0, FechaContable, FechaCompensa, FechaCompensa, Math.Abs(MontoSoles), Math.Abs(MontoDolares), TC, moneda, nroKuenta
                            , NroPago, glosa, FechaContable, frmLogin.CodigoUsuario, "");
                    }
                    //si se Abona una Parte del Anticipo               
                    else
                    {
                        decimal ImporteAbonar = decimal.Parse(txtPorAbonar.Text);
                        decimal Factor = MontoSoles / MontoDolares;
                        decimal AbonarSoles = Configuraciones.Redondear(moneda == 1 ? ImporteAbonar : ImporteAbonar * Factor);
                        decimal AbonarDolares = Configuraciones.Redondear(moneda == 2 ? ImporteAbonar : ImporteAbonar / Factor);
                        //Asiento Cabecera
                        CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaContable
                               , Math.Abs(ImporteTotal < 0 ? moneda == 1 ? AbonarSoles : AbonarDolares : 0)
                               , Math.Abs(ImporteTotal > 0 ? moneda == 1 ? AbonarSoles : AbonarDolares : 0)
                               , decimal.Parse(txttipocambio.Text), proyecto, 0, Cuo, moneda, glosa, dtpFechaCompensa.Value, -11);
                        //Detalle del asiento
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, proyecto, TipoIdProveedor, RucProveedor
                            , NameProveedor, idfac, NumFac[0], NumFac[1], 0, FechaContable, FechaCompensa, FechaCompensa, Math.Abs(AbonarSoles), Math.Abs(AbonarDolares), TC, moneda, nroKuenta
                            , NroPago, glosa, FechaContable, frmLogin.CodigoUsuario, "");
                        ////anticipos por partes
                        //decimal ImporteAbonar = decimal.Parse(txtPorAbonar.Text);
                        //decimal SumatoriaFacturas = (moneda == 1 ? FacturasSoles : FacturasDolares) + Math.Abs(ImporteTotal) + ImporteAbonar;
                        //foreach (DataGridViewRow item in DtgcontenAnticipos.Rows)
                        //{
                        //    if ((int)item.Cells[yOk.Name].Value == 1)
                        //    {
                        //        if ((int)item.Cells[yOk.Name].Value == 1)
                        //        {
                        //            //SAco El Acumalado.
                        //            SumatoriaFacturas = SumatoriaFacturas - (moneda == 1 ? (decimal)item.Cells[xMontoMN.Name].Value : (decimal)item.Cells[xMontoME.Name].Value);
                        //            //Asiento de los Anticipos al Haber.
                        //            //CuentaContable = item.Cells[xcuentacontable.Name].Value.ToString();
                        //            MontoSoles = (decimal)item.Cells[xMontoMN.Name].Value;
                        //            MontoDolares = (decimal)item.Cells[xMontoME.Name].Value;
                        //            TC = decimal.Parse(txttipocambio.Text);
                        //            ////Parciales
                        //            decimal ParcialSoles = 0, ParcialDolares = 0;
                        //            decimal Factor = 0;
                        //            if (SumatoriaFacturas < 0)
                        //            {
                        //                if (moneda == 1)
                        //                {
                        //                    Factor = (MontoSoles + SumatoriaFacturas) / MontoSoles;
                        //                    ParcialSoles = Math.Abs(Configuraciones.Redondear(MontoSoles * Factor));
                        //                    ParcialDolares = Math.Abs(Configuraciones.Redondear(MontoDolares * Factor));
                        //                }
                        //                else if (moneda == 2)
                        //                {
                        //                    Factor = (MontoDolares + SumatoriaFacturas) / MontoDolares;
                        //                    ParcialSoles = Math.Abs(Configuraciones.Redondear(MontoSoles * Factor));
                        //                    ParcialDolares = Math.Abs(Configuraciones.Redondear(MontoDolares * Factor));
                        //                }
                        //            }
                        //            ///
                        //            CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaContable
                        //                , ImporteTotal < 0 ? SumatoriaFacturas < 0 ? moneda == 1 ? ParcialSoles : ParcialDolares : moneda == 1 ? MontoSoles : MontoDolares : 0
                        //                , ImporteTotal > 0 ? SumatoriaFacturas < 0 ? moneda == 1 ? ParcialSoles : ParcialDolares : moneda == 1 ? MontoSoles : MontoDolares : 0
                        //                , TC, proyecto, 0, Cuo, moneda, glosa, dtpFechaCompensa.Value, -11);
                        //            //Detalle del asiento
                        //            CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, dtpFechaContable.Value, CuentaContable, proyecto, TipoIdProveedor, RucProveedor
                        //               , NameProveedor, idfac, NumFac[0], NumFac[1], 0, FechaContable, FechaCompensa, FechaCompensa
                        //                , SumatoriaFacturas < 0 ? ParcialSoles : MontoSoles, SumatoriaFacturas < 0 ? ParcialDolares : MontoDolares
                        //               , TC, moneda, nroKuenta, NroPago, glosa, FechaCompensa, frmLogin.CodigoUsuario, "");
                        //            ///Actualizo el Estado del Anticipo(Compensacion)
                        //            //CapaLogica.ActualizarCompensaciones((int)cboempresa.SelectedValue, (int)item.Cells[xTipo.Name].Value, (int)item.Cells[xpkid.Name].Value, 1, Cuo);
                        //            if (SumatoriaFacturas == 0)
                        //            {
                        //                //CapaLogica.ActualizarCompensaciones((int)cboempresa.SelectedValue, (int)item.Cells[xTipo.Name].Value, (int)item.Cells[xpkid.Name].Value, 1, Cuo);
                        //                break;
                        //            }
                        //            else if (SumatoriaFacturas < 0)
                        //            {
                        //                //Parcial
                        //                //CapaLogica.InsertarCompensacionesDetalle((int)item.Cells[xpkid.Name].Value, (int)cboempresa.SelectedValue, (int)item.Cells[xTipo.Name].Value,
                        //                //ParcialSoles, ParcialDolares, NroPago, FechaCompensa, 1, Cuo);
                        //                break;
                        //            }
                        //            else if (SumatoriaFacturas > 0)
                        //            {
                        //                //CapaLogica.ActualizarCompensaciones((int)cboempresa.SelectedValue, (int)item.Cells[xTipo.Name].Value, (int)item.Cells[xpkid.Name].Value, 1, Cuo);
                        //                //Continua..
                        //            }
                        //        }
                        //    }
                        //}
                    }
                }
                //decimal ImporteAbonarAnticipos = decimal.Parse(txtPorAbonar.Text);               
                decimal AcumuladoFacturas = (moneda == 1 ? FacturasSoles : FacturasDolares) + (cbopago.Text != "000 Ninguno." ? decimal.Parse(txtPorAbonar.Text) : 0);

                if (cbopago.Text == "000 Ninguno." || (Math.Abs(ImporteTotal) - decimal.Parse(txtPorAbonar.Text) != 0))
                {
                    ////por Compensacion de las Facturas contra Anticipos
                    foreach (DataGridViewRow item in DtgcontenAnticipos.Rows)
                    {
                        if ((int)item.Cells[yOk.Name].Value == 1)
                        {
                            if ((int)item.Cells[yOk.Name].Value == 1)
                            {
                                //SAco El Acumalado.
                                AcumuladoFacturas = AcumuladoFacturas - (moneda == 1 ? (decimal)item.Cells[xMontoMN.Name].Value : (decimal)item.Cells[xMontoME.Name].Value);
                                string[] NumFac = $"0-Ant.N°{(int)item.Cells[xpkid.Name].Value} {((DateTime)item.Cells[xFechaCompensa.Name].Value).ToString("d")}".Split('-');
                                //Asiento de los Anticipos al Haber.
                                string CuentaContable = item.Cells[xcuentacontable.Name].Value.ToString();
                                decimal MontoSoles = (decimal)item.Cells[xMontoMN.Name].Value;
                                decimal MontoDolares = (decimal)item.Cells[xMontoME.Name].Value;
                                decimal TC = decimal.Parse(txttipocambio.Text);
                                ////Parciales
                                decimal ParcialSoles = 0, ParcialDolares = 0;
                                decimal Factor = 0;
                                if (AcumuladoFacturas < 0)
                                {
                                    if (moneda == 1)
                                    {
                                        Factor = (MontoSoles + AcumuladoFacturas) / MontoSoles;
                                        ParcialSoles = Math.Abs(Configuraciones.Redondear(MontoSoles * Factor));
                                        ParcialDolares = Math.Abs(Configuraciones.Redondear(MontoDolares * Factor));
                                    }
                                    else if (moneda == 2)
                                    {
                                        Factor = (MontoDolares + AcumuladoFacturas) / MontoDolares;
                                        ParcialSoles = Math.Abs(Configuraciones.Redondear(MontoSoles * Factor));
                                        ParcialDolares = Math.Abs(Configuraciones.Redondear(MontoDolares * Factor));
                                    }
                                }
                                ///
                                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaContable
                                    , 0, AcumuladoFacturas < 0 ? moneda == 1 ? ParcialSoles : ParcialDolares : moneda == 1 ? MontoSoles : MontoDolares, TC, proyecto, 0, Cuo, moneda, glosa, dtpFechaCompensa.Value, -11);
                                //Detalle del asiento
                                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, item.Cells[xcuentacontable.Name].Value.ToString(), proyecto, TipoIdProveedor, RucProveedor
                                    , NameProveedor, 0, NumFac[0], NumFac[1], 0, FechaContable, FechaCompensa, FechaCompensa, AcumuladoFacturas < 0 ? ParcialSoles : MontoSoles, AcumuladoFacturas < 0 ? ParcialDolares : MontoDolares,
                                    TC, moneda, "", "", glosa, FechaContable, frmLogin.CodigoUsuario, "");
                                ///Actualizo el Estado del Anticipo(Compensacion)
                                //CapaLogica.ActualizarCompensaciones((int)cboempresa.SelectedValue, (int)item.Cells[xTipo.Name].Value, (int)item.Cells[xpkid.Name].Value, 1, Cuo);
                                if (AcumuladoFacturas == 0)
                                {
                                    CapaLogica.ActualizarCompensaciones((int)cboempresa.SelectedValue, (int)item.Cells[xTipo.Name].Value, (int)item.Cells[xpkid.Name].Value, 1,
                                         TipoPago, cbopago.Text == "000 Ninguno." ? "" : HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text), txtnrocheque.TextValido(), Cuo);
                                    break;
                                }
                                else if (AcumuladoFacturas < 0)
                                {
                                    //Parcial
                                    CapaLogica.InsertarCompensacionesDetalle((int)item.Cells[xpkid.Name].Value, (int)cboempresa.SelectedValue, (int)item.Cells[xTipo.Name].Value,
                                        ParcialSoles, ParcialDolares, TipoPago, cbopago.Text == "000 Ninguno." ? "" : HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text), txtnrocheque.TextValido(),
                                        $"{Configuraciones.MayusculaCadaPalabra(cboproveedor.Text)} {dtpFechaCompensa.Value.ToString("d")}", FechaCompensa, 1, Cuo);
                                    break;
                                }
                                else if (AcumuladoFacturas > 0)
                                {
                                    CapaLogica.ActualizarCompensaciones((int)cboempresa.SelectedValue, (int)item.Cells[xTipo.Name].Value, (int)item.Cells[xpkid.Name].Value, 1,
                                         TipoPago, cbopago.Text == "000 Ninguno." ? "" : HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text), txtnrocheque.TextValido(), Cuo);
                                    //Continua..
                                }
                            }
                        }
                    }
                }
                else
                {
                    ///Si son pagos Totales
                    //Anticipos al Haber     --yOk
                    foreach (DataGridViewRow item in DtgcontenAnticipos.Rows)
                    {
                        if ((int)item.Cells[yOk.Name].Value == 1)
                        {
                            if ((int)item.Cells[yOk.Name].Value == 1)
                            {
                                string[] NumFac = $"0-Ant.N°{(int)item.Cells[xpkid.Name].Value} {((DateTime)item.Cells[xFechaCompensa.Name].Value).ToString("d")}".Split('-');
                                //Asiento de las facturas al debe
                                string CuentaContable = item.Cells[xcuentacontable.Name].Value.ToString();
                                decimal MontoSoles = (decimal)item.Cells[xMontoMN.Name].Value;
                                decimal MontoDolares = (decimal)item.Cells[xMontoME.Name].Value;
                                decimal TC = decimal.Parse(txttipocambio.Text);
                                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaContable
                                    , 0, moneda == 1 ? MontoSoles : MontoDolares, TC, proyecto, 0, Cuo, moneda, glosa, dtpFechaCompensa.Value, -11);
                                //Detalle del asiento
                                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, item.Cells[xcuentacontable.Name].Value.ToString(), proyecto, TipoIdProveedor, RucProveedor
                                    , NameProveedor, 0, NumFac[0], NumFac[1], 0, FechaContable, FechaCompensa, FechaCompensa, MontoSoles, MontoDolares, TC, moneda, "", "", glosa, FechaContable, frmLogin.CodigoUsuario, "");
                                ///Actualizo el Estado del Anticipo(Compensacion)
                                CapaLogica.ActualizarCompensaciones((int)cboempresa.SelectedValue, (int)item.Cells[xTipo.Name].Value, (int)item.Cells[xpkid.Name].Value, 1,
                                     TipoPago, decimal.Parse(txtPorAbonar.Text) == 0 ? "" : HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text), txtnrocheque.TextValido(), Cuo);
                            }
                        }
                    }
                }
                //Cuadre Asiento
                CapaLogica.CuadrarAsiento(Cuo, proyecto, FechaContable, 2);
                //Fin Cuadre
                msg($"Se Aplicó el Anticipo con Cuo {Cuo}");
                cbopago.Text = "003 Transferencias Fondos";
                cboproveedor_SelectedIndexChanged(sender, e);
            }
        }
        private void txtPorAbonar_TextChanged(object sender, EventArgs e)
        {
            CalcularxAbonar();
        }
        public void CalcularxAbonar()
        {
            decimal ImporteAbonar = 0;
            decimal.TryParse(txtPorAbonar.Text, out ImporteAbonar);
            if (decimal.Parse(txtPorAbonar.Text == "" ? "0" : ImporteAbonar.ToString()) > Math.Abs(ImporteTotal))
            {
                txtPorAbonar.Text = Math.Abs(ImporteTotal).ToString("n2");
            }
        }
        private void btnbusproveedor_Click(object sender, EventArgs e)
        {
            frmproveedor provee = new frmproveedor();
            string[] proveedor = "0-0".Split();
            if (cboproveedor.SelectedValue != null)
                proveedor = cboproveedor.SelectedValue.ToString().Split('-');
            provee.txtnumeroidentidad.Text = proveedor[0];
            provee.Txtbusca.Text = proveedor[1];
            provee.radioButton2.Checked = true;
            provee.Txtbusca_TextChanged(sender, e);
            provee.llamada = 10;
            provee.ShowDialog();
            if (provee.llamada != 100)
                cboproveedor.SelectedValue = provee.tipoid + "-" + provee.rucito;
        }
        //FACTURAS
        public void SelecionarFacturaDetraccion(int _x)
        {
            //DtgcontenFacturas.SuspendLayout();
            //int x = _x;
            //foreach (DataGridViewRow item in DtgcontenFacturas.Rows)
            //{
            //    if (item.Index != _x)
            //        if (item.Cells[xProveedor.Name].Value.ToString() == DtgcontenFacturas[xProveedor.Name, x].Value.ToString() && item.Cells[xNroComprobante.Name].Value.ToString() == DtgcontenFacturas[xNroComprobante.Name, x].Value.ToString())
            //        {
            //            item.Cells[xok.Name].Value = ((int)DtgcontenFacturas[xok.Name, x].Value) == 1 ? 1 : 0;
            //        }
            //}
            //DtgcontenFacturas.ResumeLayout();
        }
        private void DtgcontenFacturas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarFacturaDetraccion(e.RowIndex);
            ContaFacturas = 0;
            FacturasSoles = 0;
            FacturasDolares = 0;
            foreach (DataGridViewRow item in DtgcontenFacturas.Rows)
            {
                if ((int)item.Cells[xok.Name].Value == 1)
                {
                    ContaFacturas++;
                    if ((int)item.Cells[xidMoneda.Name].Value == 1)
                    {
                        FacturasSoles += (decimal)item.Cells[xTotal.Name].Value;
                        //se soles a dolares Divido
                        FacturasDolares += Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value / (decimal)item.Cells[xTcReg.Name].Value);
                    }
                    else
                    {
                        //se soles a dolares Multiplico
                        FacturasSoles += Configuraciones.Redondear((decimal)item.Cells[xTotal.Name].Value * (decimal)item.Cells[xTcReg.Name].Value);
                        FacturasDolares += (decimal)item.Cells[xTotal.Name].Value;
                    }
                }
            }
            //DtgcontenFacturas.EndEdit(); DtgcontenFacturas.RefreshEdit();
            CalcularTotales();
        }
        decimal ImporteTotal
        {
            get { return decimal.Parse(txtImporteTotal.Text); }
            set
            {
                txtImporteTotal.Text = value.ToString("n2");
                txtPorAbonar.Text = Math.Abs(value).ToString("n2");
                if (ImporteTotal > 0)
                    if (cbopago.Text == "000 Ninguno.")
                        txtPorAbonar.Enabled = false;
                    else txtPorAbonar.Enabled = true;
            }
        }
        public void CalcularTotales()
        {
            ImporteTotal = 0;
            if (cbomoneda.SelectedValue != null)
                //soles
                if ((int)cbomoneda.SelectedValue == 1)
                {
                    ImporteTotal = FacturasSoles - AnticipoSoles;
                }
                //dolares
                else
                {
                    ImporteTotal = FacturasDolares - AnticipoDolares;
                }
            lbltotalregistros.Text = $"Total Anticipos: {ContaAnticipos}/{DtgcontenAnticipos.RowCount} - Total Facturas: {ContaFacturas}/{DtgcontenFacturas.RowCount}";// - Seleccionado: {ContaAnticipos + ContaFacturas}";
        }


    }
}
