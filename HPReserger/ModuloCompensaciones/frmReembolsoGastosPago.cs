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
    public partial class frmReembolsoGastosPago : FormGradient
    {
        public frmReembolsoGastosPago()
        {
            InitializeComponent();
        }
        public void CargarMoneda() { CapaLogica.TablaMoneda(cbomoneda); }
        public void CargarEmpresa() { CapaLogica.TablaEmpresa(cboempresa); }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private int _idempresa;
        public int Estado { get; private set; }
        public string NameEmpresa { get; private set; }
        public bool Cargado { get; private set; }
        private void frmReembolsoGastosPago_Load(object sender, EventArgs e)
        {
            Cargado = false;
            txtglosa.CargarTextoporDefecto();
            txtnrooperacion.CargarTextoporDefecto();
            dtpFechaContable.Value = dtpFechaCompensa.Value = DateTime.Now;
            Estado = 0;
            CargarTipoPagos();
            //ModoEdicion(false);
            CargarMoneda();
            btnaceptar.Enabled = false;
            //cbopago.SelectedIndex = 0;
            CargarEmpresa();
            Cargado = true;
        }
        public void CargarTipoPagos()
        {
            cbotipo.DisplayMember = "mediopago";
            cbotipo.ValueMember = "codsunat";
            cbotipo.DataSource = CapaLogica.ListadoMedioPagos();
            if (cbotipo.Items.Count > 0) cbotipo.SelectedValue = 3;
        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
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
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        string BanCuenta;
        int idTipocuenta;
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (cbobanco.SelectedValue == null)
            {
                msg("Seleccione el Banco");
                cbobanco.Focus(); return;
            }
            if (cbotipo.Items.Count == 0) { cbotipo.Focus(); msg("Seleccione Tipo de Pago"); return; }
            int TipoPago = (int)cbotipo.SelectedValue;
            string NroOperacion = txtnrooperacion.TextValido();
            if (cbocuentabanco.SelectedValue == null)
            {
                msg("Seleccione la cuenta del Abono");
                cbocuentabanco.Focus(); return;
            }
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
            if (decimal.Parse(txtTotalPagar.Text) <= 0)
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
                //string mensaje = "";
                DateTime FechaPago = dtpFechaCompensa.Value;
                DateTime FechaContable = dtpFechaContable.Value;
                string Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, FechaContable);
                //mensaje += $"Se ha Aplicado Reembolsado con cuo {Cuo}";
                //int TipoPago = 0;
                string[] Empleado = cboempleado.SelectedValue.ToString().Split('-');
                string NameEmpleado = cboempleado.Text.Substring(cboempleado.Text.IndexOf('-') + 2).ToUpper();
                //if (cbotipo.Text == "003 Transferencias Fondos") TipoPago = 3;
                //else if (cbotipo.Text == "007 Cheque.") TipoPago = 7;
                //TipoPago = 1;
                string NroPago = txtnrooperacion.TextValido();
                decimal TCPago = decimal.Parse(txttipocambio.Text);
                //string NroPago = "";
                //string CuoReg = Cuo;
                int moneda = (int)cbomoneda.SelectedValue;
                int proyecto = (int)cboproyecto.SelectedValue;
                //DataRow Fila = CapaLogica.VerUltimoIdentificador("tbl_reembolsogastos_Det", "pkid");
                //int SiguientePkId = 0;
                //int.TryParse(Fila["ultimo"].ToString(), out SiguientePkId);
                //SiguientePkId++;
                string[] UserCompensa = cboempleado.SelectedValue.ToString().Split('-');
                int IdLogin = frmLogin.CodigoUsuario;
                //int IdEmpresa = (int)cboempresa.SelectedValue;
                decimal TotalPagar = decimal.Parse(txtTotalPagar.Text);
                string Glosa = txtglosa.TextValido();
                ///////Asiento de la SAlida de la plata del banco
                ///////////
                //numasiento = 0;
                //if (numasiento == 0)
                //{
                //    DataTable asientito = CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, dtpFechaContable.Value);
                //    DataRow asiento = asientito.Rows[0];
                //    if (asiento == null) { numasiento = 1; }
                //    else
                //        numasiento = ((int)asiento["codigo"]);
                //}
                //string CuoNext = HPResergerFunciones.Utilitarios.Cuo(numasiento, dtpFechaContable.Value);
                PosFila = 0;
                //CUENTAS DEL BANCO
                //salida del banco 
                string nroKuenta = HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text);
                if (cbocuentabanco.SelectedValue == null)
                    BanCuenta = "";
                else
                    BanCuenta = cbocuentabanco.SelectedValue.ToString();
                idTipocuenta = (int)((DataTable)cbocuentabanco.DataSource).Rows[cbocuentabanco.SelectedIndex]["idtipocta"];
                //Cabecera del pago del banco            
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, BanCuenta, 0, TotalPagar, TCPago, proyecto, 0, Cuo, moneda, Glosa, FechaPago, -18);
                //detalle del pago del banco
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, BanCuenta, proyecto, int.Parse(UserCompensa[0]), UserCompensa[1]
                  , cboempleado.Text.Substring(cboempleado.Text.IndexOf('-') + 2).ToUpper(), 0, "0", $"{FechaPago.ToString("d")} {Configuraciones.MayusculaCadaPalabra(cboempleado.Text.Substring(cboempleado.Text.IndexOf('-') + 2))}"
                  , 0, FechaPago, FechaPago, FechaPago, moneda == 1 ? TotalPagar : TotalPagar * TCPago, moneda == 2 ? TotalPagar : TotalPagar / TCPago, TCPago, moneda, nroKuenta, "", Glosa, FechaPago,
                  IdLogin, Cuo, TipoPago);
                //OTRASCUENTAS POR PAGAR
                ///Otras Cuentas x Pagar Terceros
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    //si las Cuentas son seleccionadas
                    string CuentaContable = item.Cells[xCuentaContable.Name].Value.ToString();
                    decimal MontoMN = decimal.Parse(item.Cells[xmontomn.Name].Value.ToString());
                    decimal MontoME = decimal.Parse(item.Cells[xmontome.Name].Value.ToString());
                    DateTime FechaPagoFac = FechaPago;
                    int pkId = (int)item.Cells[xpkid.Name].Value;
                    string CuoReg = item.Cells[xCuoReg.Name].Value.ToString();
                    /////////////////////
                    if ((int)item.Cells[xok.Name].Value == 1)
                    {
                        CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaContable, moneda == 1 ? MontoMN : MontoME, 0, TCPago, proyecto, 0, Cuo, moneda, Glosa, FechaPago, -18);
                        //detalle de otras cuentas x pagar a terceros
                        ////Detalle Facturas
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, proyecto, int.Parse(UserCompensa[0]), UserCompensa[1],
                            cboempleado.Text.Substring(cboempleado.Text.IndexOf('-') + 2).ToUpper(), 0, "0", $"{FechaPago.ToString("d")} {Configuraciones.MayusculaCadaPalabra(cboempleado.Text.Substring(cboempleado.Text.IndexOf('-') + 2))}"
                           , 0, FechaPagoFac, FechaPago, FechaPago, MontoMN, MontoME, TCPago, moneda, "", "", Glosa, FechaPago, IdLogin, Cuo);
                        //fin de pago de otras cuentas
                        //Inserto compensaciones!
                        CapaLogica.InsertarCompensaciones(IdEmpresa, 2, int.Parse(UserCompensa[0]), UserCompensa[1], MontoMN, MontoME, CuoReg, TipoPago, nroKuenta, NroPago,
                            $"{FechaPago.ToString("d")} {Configuraciones.MayusculaCadaPalabra(cboempleado.Text.Substring(cboempleado.Text.IndexOf('-') + 2))}",
                           FechaPago, 1, CuentaContable, Cuo);
                        //Pago del Reembolso
                        CapaLogica.ReembolsoGastos_Detalle(pkId, IdEmpresa, Cuo, nroKuenta, NroPago, NroPago, TipoPago, FechaPago, IdLogin);
                    }
                }
                //Cuadre Asiento
                CapaLogica.CuadrarAsiento(Cuo, proyecto, FechaContable, 2);
                //Fin Cuadre
                msgOK($"\nSe hizo el pago con Cuo {Cuo}");
                cboempleado_SelectedIndexChanged(sender, e);
                CalcularTotal();
            }
        }
        private void cboempresa_SelectedValueChanged(object sender, EventArgs e)
        {
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
                    BuscarEmpleadoCompensaciones();
                }
            }
        }

        private void BuscarEmpleadoCompensaciones()
        {
            if (cboempresa.SelectedValue != null)
            {
                cboempleado.DataSource = CapaLogica.ReembolsoGastos_Detalle((int)cboempresa.SelectedValue);
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
        private void cbobanco_Click_1(object sender, EventArgs e)
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

        private void cboempleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboempleado.SelectedValue != null)
            {
                DataTable Table = CapaLogica.ReembolsoGastos_Detalle(cboempleado.SelectedValue.ToString(), (int)cboempresa.SelectedValue);
                Dtgconten.DataSource = Table;
                btnaceptar.Enabled = false;
                txttotalME.Text = txttotaldifME.Text = txttotalMN.Text = txttotaldifMN.Text = "0.00";
            }
            ContarRegistros();
            //PasarTipoOracion(xrazon_social);
        }
        public void CalcularTotal()
        {
            int conta = 0;
            btnaceptar.Enabled = false;
            cboempleado.Enabled = cboproyecto.Enabled = cboempresa.Enabled = true;
            txttotalME.Text = txttotaldifME.Text = txttotalMN.Text = txttotaldifMN.Text = "0.00";
            txtTotalPagar.Text = "0.00";
            if (Cargado)
            {
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
                            sumatoriaMN += (decimal)item.Cells[xmontomn.Name].Value;
                            sumatoriaME += (decimal)item.Cells[xmontome.Name].Value;
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
            SacarMontoPagar();
        }
        private void Dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalcularTotal();
        }

        private void Dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cargado = false;
            int x = e.RowIndex;
            if (x >= 0 && Dtgconten.Columns[xVer.Name].Index != e.ColumnIndex)
            {
                Dtgconten[xok.Name, x].Value = ((int)Dtgconten[xok.Name, x].Value) == 1 ? 0 : 1;
            }
            else if (e.ColumnIndex == Dtgconten.Columns[xok.Name].Index && e.RowIndex == -1)
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
            Cargado = true;
            CalcularTotal();
        }

        private void Dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Dtgconten.Columns[xok.Name].Index && e.RowIndex >= 0)
            {
                Dtgconten.EndEdit(); Dtgconten.RefreshEdit();
            }
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == Dtgconten.Columns[xVer.Name].Index && Dtgconten[e.ColumnIndex, e.RowIndex].Value.ToString().ToUpper() == "VER")
                {
                    frmReembolsoGastosDetalleFact frmdetallegastosfac = new frmReembolsoGastosDetalleFact((int)cboempresa.SelectedValue, (int)Dtgconten[xpkid.Name, e.RowIndex].Value);
                    //frmdetallegastosfac.FormBorderStyle = FormBorderStyle.None;
                    frmdetallegastosfac.ShowDialog();
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SacarMontoPagar()
        {
            if (cbomoneda.SelectedValue != null)
                if ((int)cbomoneda.SelectedValue == 1) //Soles
                {
                    txtTotalPagar.Text = txttotalMN.Text;
                }
                else if ((int)cbomoneda.SelectedValue == 2) //Dolares
                {
                    txtTotalPagar.Text = txttotalME.Text;
                }
        }
        private void cbomoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            SacarMontoPagar();
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

        private void cboempleado_Click(object sender, EventArgs e)
        {
            if (cboempresa.SelectedValue != null)
            {
                DataTable Tablita = CapaLogica.ReembolsoGastos_Detalle((int)cboempresa.SelectedValue);
                if (cboempleado.Items.Count != Tablita.Rows.Count)
                {
                    BuscarEmpleadoCompensaciones();
                }
            }
            if (cboempleado.SelectedValue != null)
            {
                DataTable Table = CapaLogica.ReembolsoGastos_Detalle(cboempleado.SelectedValue.ToString(), (int)cboempresa.SelectedValue);
                if (Dtgconten.RowCount != Table.Rows.Count)
                {
                    Dtgconten.DataSource = Table;
                }
            }
        }
    }
}
