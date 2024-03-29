﻿using HpResergerUserControls;
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
    public partial class frmAbonosVentas : FormGradient
    {
        public frmAbonosVentas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void frmAbonosVentas_Load(object sender, EventArgs e)
        {
            ValoresPorDefecto();
            BusquedaDatos();
            dtpFechaContable.Value = dtpFechaPago.Value = DateTime.Now;
            cbobanco_Click(sender, e);
            cargarEmpresa();
            CargarCombos();
            txtglosa.CargarTextoporDefecto();
            txtCuentaExceso.Text = "";
            txtCuentaExceso.CargarTextoporDefecto();
            txtnrooperacion.CargarTextoporDefecto();
            chkPenalidad.Checked = false;
            CargarTipoPagos();
        }
        public void CargarTipoPagos()
        {
            cbotipo.DisplayMember = "mediopago";
            cbotipo.ValueMember = "codsunat";
            cbotipo.DataSource = CapaLogica.ListadoMedioPagos();
            if (cbotipo.Items.Count > 0) cbotipo.SelectedValue = 3;
        }
        private int IdEmpresa;
        public int _IdEmpresa
        {
            get { return (int)cboempresa.SelectedValue; }
            set { IdEmpresa = value; }
        }
        public void CargarCombos()
        {
            CargarDepositoAPlazo();
            CargarCertificadoBancario();
        }
        public void CargarDepositoAPlazo()
        {
            cbodepositoplazo.DataSource = CapaLogica.DepositoaPlazo();
            cbodepositoplazo.ValueMember = "Id_Cuenta_Contable";
            cbodepositoplazo.DisplayMember = "Cuenta_Contable";
        }
        public void CargarCertificadoBancario()
        {
            cboCertificadobancario.DataSource = CapaLogica.CertificadosBancarios();
            cboCertificadobancario.ValueMember = "Id_Cuenta_Contable";
            cboCertificadobancario.DisplayMember = "Cuenta_Contable";
        }
        private void BusquedaDatos()
        {
            if (rdbporAbonar.Checked)
            {
                if (cboempresa.SelectedValue != null)
                {
                    if (dtpfecha1.Value > dtpfecha2.Value)
                        dtgconten.DataSource = CapaLogica.BusquedaVentasManuales((int)cboempresa.SelectedValue, dtpfecha2.Value, dtpfecha1.Value, txtrazon.TextValido(), txtnumdoc.TextValido());
                    else
                        dtgconten.DataSource = CapaLogica.BusquedaVentasManuales((int)cboempresa.SelectedValue, dtpfecha1.Value, dtpfecha2.Value, txtrazon.TextValido(), txtnumdoc.TextValido());
                    FacturasSeleccionadasRecargar();
                }
            }
            else
            {
                if (cboempresa.SelectedValue != null)
                {
                    if (dtpfecha1.Value > dtpfecha2.Value)
                        dtgconten.DataSource = CapaLogica.BusquedaVentasManualesAbonados((int)cboempresa.SelectedValue, dtpfecha2.Value, dtpfecha1.Value, txtrazon.TextValido(), txtnumdoc.TextValido());
                    else
                        dtgconten.DataSource = CapaLogica.BusquedaVentasManualesAbonados((int)cboempresa.SelectedValue, dtpfecha1.Value, dtpfecha2.Value, txtrazon.TextValido(), txtnumdoc.TextValido());
                    FacturasSeleccionadasRecargar();
                    btnaceptar.Enabled = false;
                }
            }
            ContarRegistros();
            BuscarElSelecionado();
        }
        public void BuscarElSelecionado()
        {
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if (item.Cells[xNroComprobante.Name].Value.ToString() == FacturaSelecionada && ClienteSelecionado == item.Cells[xTipoId.Name].Value.ToString() + "-" + item.Cells[xCliente.Name].Value.ToString())
                {
                    dtgconten.CurrentCell = dtgconten[xCliente.Name, item.Index];
                    break;
                }
            }
        }
        public void FacturasSeleccionadasRecargar()
        {
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                //if (ListaFacturas.Contains((int)item.Cells[xId.Name].Value))
                //    item.Cells[xopcion.Name].Value = 1;
                //Opcion de Lista
                int valor = (int)item.Cells[xId.Name].Value; decimal monto = (decimal)item.Cells[xpagar.Name].Value;
                int tipodoc = (int)item.Cells[xTipoId.Name].Value; int tipocomprobante = (int)item.Cells[xIdComprobante.Name].Value;
                string nrodoc = item.Cells[xCliente.Name].Value.ToString(); string nrocomprobante = item.Cells[xNroComprobante.Name].Value.ToString();
                Facturas FacturaF = ListaFacturax.Find(find => find.Tipodoc == tipodoc && find.NroDoc == nrodoc && find.TipoComprobante == tipocomprobante && find.NroComprobante == nrocomprobante);
                if (FacturaF != null)
                {
                    item.Cells[xpagar.Name].Value = FacturaF.Monto;
                    item.Cells[xopcion.Name].Value = 1;
                }
            }
        }
        public void cargarEmpresa()
        {
            FacturasRows();
            string name = cboempresa.Text;
            CapaLogica.TablaEmpresa(cboempresa);
            cboempresa.Text = name;
            FacturasSeleccionadasRecargar();
            BuscarElSelecionado();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarEmpresa();
        }
        public void ValoresPorDefecto()
        {
            txtrazon.CargarTextoporDefecto();
            txtnumdoc.CargarTextoporDefecto();
            dtpfecha1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfecha2.Value = new DateTime(DateTime.Now.Year, 12, 31);
            //cargarEmpresa();
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            ValoresPorDefecto();
            FacturasSeleccionadasRecargar();
        }
        public void CargarProyecto()
        {
            if (cboempresa.SelectedValue != null)
            {
                cboproyecto.DisplayMember = "proyecto";
                cboproyecto.ValueMember = "id_proyecto";
                cboproyecto.DataSource = CapaLogica.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString());
            }
        }
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_IdEmpresa != (int)cboempresa.SelectedValue)
                ListaFacturas.Clear();
            ContarRegistros();
            BusquedaDatos();
            if (cbobanco.SelectedValue != null)
            {
                CargarCuentasBancos();
                NameEmpresa = cboempresa.Text;
            }
            CargarProyecto();
        }
        public void CargarCuentasBancos()
        {
            if (cboempresa.SelectedValue != null && cbobanco.SelectedValue != null)
            {
                cbocuentabanco.ValueMember = "Id_Cuenta_Contable";
                cbocuentabanco.DisplayMember = "banco";
                cbocuentabanco.DataSource = CapaLogica.ListarBancosTiposdePagoxEmpresa(cbobanco.SelectedValue.ToString(), (int)cboempresa.SelectedValue, 0);
            }
        }
        private void txtrazon_TextChanged(object sender, EventArgs e)
        {
            BusquedaDatos();
        }
        private void txtnumdoc_TextChanged(object sender, EventArgs e)
        {
            BusquedaDatos();
        }
        private void dtpfecha2_ValueChanged(object sender, EventArgs e)
        {
            BusquedaDatos();
        }
        private void dtpfecha1_ValueChanged(object sender, EventArgs e)
        {
            BusquedaDatos();
        }
        List<Facturas> ListaFacturax = new List<Facturas>();
        List<int> ListaFacturas = new List<int>();
        public class Facturas
        {
            public int Id;
            public string NroComprobante;
            public int TipoComprobante;
            public int Tipodoc;
            public string NroDoc;
            public decimal Monto;
            public Facturas(int _tipodoc, string _nrodoc, int _tipocomprobante, string _nrocomprobante)
            {
                Tipodoc = _tipodoc;
                NroDoc = _nrodoc;
                TipoComprobante = _tipocomprobante;
                NroComprobante = _nrocomprobante;
            }
            public Facturas(int _id, int _tipodoc, string _nrodoc, int _tipocomprobante, string _nrocomprobante, decimal _monto)
            {
                Id = _id;
                Tipodoc = _tipodoc;
                NroDoc = _nrodoc;
                TipoComprobante = _tipocomprobante;
                NroComprobante = _nrocomprobante;
                Monto = _monto;
            }
        }
        private void dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            int y = e.ColumnIndex;
            if (x >= 0)
            {
                DataGridViewRow item = dtgconten.Rows[x];
                int valor = (int)item.Cells[xId.Name].Value;
                decimal monto = 0;
                decimal.TryParse(item.Cells[xpagar.Name].Value.ToString(), out monto);
                item.Cells[xpagar.Name].Value = monto;
                ////si es valor es mayor o menor a cero
                if (dtgconten.Columns[xpagar.Name].Index == y)
                    if ((decimal)item.Cells[xpagar.Name].Value <= 0)//|| (decimal)item.Cells[xpagar.Name].Value > (decimal)item.Cells[xTotal.Name].Value)
                        item.Cells[xpagar.Name].Value = (decimal)item.Cells[xTotal.Name].Value;
                ////////
                if (dtgconten.Columns[xpagar.Name].Index == y)
                {
                    if (ContenedorIdNotas.Contains((int)dtgconten[xIdComprobante.Name, x].Value))
                    {
                        if ((decimal)item.Cells[xpagar.Name].Value > (decimal)item.Cells[xTotal.Name].Value)
                            item.Cells[xpagar.Name].Value = (decimal)item.Cells[xTotal.Name].Value;
                    }
                }
                ////cada que cambia el valor de la opcion
                if (item.Cells[xopcion.Name].Value.ToString() == "") item.Cells[xopcion.Name].Value = 0;
                //Proceso para El Listado de Las Facturas
                int tipodoc = (int)item.Cells[xTipoId.Name].Value; int tipocomprobante = (int)item.Cells[xIdComprobante.Name].Value;
                string nrodoc = item.Cells[xCliente.Name].Value.ToString(); string nrocomprobante = item.Cells[xNroComprobante.Name].Value.ToString();
                Facturas FacturaF = ListaFacturax.Find(find => find.Tipodoc == tipodoc && find.NroDoc == nrodoc && find.TipoComprobante == tipocomprobante && find.NroComprobante == nrocomprobante);
                if ((int)item.Cells[xopcion.Name].Value == 1)
                {
                    //Agregamos la Factura a la Lista!
                    if (FacturaF == null)
                    {
                        ListaFacturax.Add(new Facturas(valor, tipodoc, nrodoc, tipocomprobante, nrocomprobante, monto));
                    }
                    else FacturaF.Monto = monto;
                    if (!ListaFacturas.Contains(valor))
                    {
                        ListaFacturas.Add(valor);
                    }
                }
                else
                {
                    ListaFacturas.Remove(valor);
                    ListaFacturax.Remove(FacturaF);
                }
            }
            if (ListaFacturas.Count > 0) btnaceptar.Enabled = true; else btnaceptar.Enabled = false;
            ContarRegistros();
            CalcularDiferencial();
            CalcularTotal();
        }
        public void CalcularTotal()
        {
            decimal SumaTotalPagada = 0;
            decimal SumaTotalPagar = 0;
            Boolean señal = false;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if ((int)item.Cells[xopcion.Name].Value == 1)
                {
                    decimal Valor = (decimal)item.Cells[xpagar.Name].Value;
                    if ((decimal)item.Cells[xpagar.Name].Value > (decimal)item.Cells[xTotal.Name].Value)
                    {
                        Valor = (decimal)item.Cells[xTotal.Name].Value;
                    }
                    if (ContenedorNotasCredito.Contains(item.Cells[xIdComprobante.Name].Value.ToString()))
                    {
                        SumaTotalPagada -= (decimal)item.Cells[xpagar.Name].Value; señal = true;
                        SumaTotalPagar -= Valor;
                    }
                    else if (ContenedorNotasDebito.Contains(item.Cells[xIdComprobante.Name].Value.ToString()))
                    {
                        SumaTotalPagada += (decimal)item.Cells[xpagar.Name].Value; señal = true;
                        SumaTotalPagar += Valor;
                    }
                    else
                    {
                        SumaTotalPagada += (decimal)item.Cells[xpagar.Name].Value;
                        SumaTotalPagar += Valor;
                    }
                }
            }
            txttotalAbonado.Text = SumaTotalPagada.ToString("n2");
            txtTotalPagar.Text = SumaTotalPagar.ToString("n2");
            CalcularMontoPenalidad();
            if (!señal)
            {
                if (SumaTotalPagada == 0)
                    btnaceptar.Enabled = false;
                else
                    btnaceptar.Enabled = true;
            }
            else if (ListaFacturax.Count > 0)
            {
                btnaceptar.Enabled = true;
            }
            else btnaceptar.Enabled = false;
        }
        public void CalcularMontoPenalidad()
        {
            if (ListaFacturas.Count >= 2 && chkPenalidad.Checked)
            {
                txtMontoPenalidad.Text = Math.Abs(decimal.Parse(txttotalAbonado.Text)).ToString("n2");
            }
            else if (chkPenalidad.Checked)
            {
                if (Math.Abs(decimal.Parse(txtMontoPenalidad.Text)) > Math.Abs(decimal.Parse(txttotalAbonado.Text)))
                {
                    txtMontoPenalidad.Text = Math.Abs(decimal.Parse(txttotalAbonado.Text)).ToString("n2");
                }
            }
        }
        public void ContarRegistros()
        {
            lblmsg.Text = $"Total de Registros : {dtgconten.RowCount} Registros Seleccionados: {ListaFacturas.Count}";
        }
        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (dtgconten.Columns[xopcion.Name].Index == y)
            {
                dtgconten.EndEdit(); dtgconten.RefreshEdit();
            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow R = dtgconten.Rows[e.RowIndex];
                if (e.ColumnIndex == dtgconten.Columns[xcuo.Name].Index)
                {
                    if (R.Cells[xcuo.Name].Value.ToString() != "")
                    {
                        ModuloContable.frmListadoAsientosContables frmReportito = new ModuloContable.frmListadoAsientosContables((int)cboempresa.SelectedValue, R.Cells[xcuo.Name].Value.ToString());
                        frmReportito.MdiParent = this.MdiParent;
                        frmReportito.Show();
                    }
                }
            }
            if (dtgconten.Columns[xAbonos.Name].Index == y && x >= 0)
            {
                if (dtgconten[xAbonos.Name, x].Value.ToString() != "")
                {
                    if (rdbporAbonar.Checked)
                    {
                        if (frmdetallepago == null)
                        {
                            frmdetallepago = new frmDetallePagoFactura(2, dtgconten[xNroComprobante.Name, e.RowIndex].Value.ToString(), (int)dtgconten[xTipoId.Name, e.RowIndex].Value, dtgconten[xCliente.Name, e.RowIndex].Value.ToString(), (int)dtgconten[xIdComprobante.Name, e.RowIndex].Value, (int)cboempresa.SelectedValue
                                , dtgconten[xGlosa.Name, e.RowIndex].Value.ToString());
                            frmdetallepago.FormClosed += Frmdetallepago_FormClosed;
                            frmdetallepago.MdiParent = MdiParent;
                            frmdetallepago.Show();
                        }
                        else frmdetallepago.Activate();
                    }
                    if (rdbAbonados.Checked)
                    {
                        FacturasRows();
                        frmDetalleNroOp frmnroop = new frmDetalleNroOp(dtgconten[xCliente.Name, x].Value.ToString(), dtgconten[xNombres.Name, x].Value.ToString(), dtgconten[xNroComprobante.Name, x].Value.ToString(), dtgconten[xCuentaContable.Name, x].Value.ToString(),
                             dtgconten[xcuo.Name, x].Value.ToString());
                        frmnroop.Codigo = (int)dtgconten[xId.Name, x].Value;
                        frmnroop.nrooperacion = dtgconten[xGlosa.Name, x].Value.ToString();
                        frmnroop.Fechapago = (DateTime)dtgconten[xFechaVencimiento.Name, x].Value;

                        frmnroop.Empresa = (int)cboempresa.SelectedValue;
                        //tipodet ==5 factura venta manual
                        frmnroop.Tipodet = (int)dtgconten[xdet.Name, x].Value;
                        frmnroop.IdComprobante = (int)dtgconten[xIdComprobante.Name, x].Value;
                        frmnroop.ShowDialog();
                        BusquedaDatos();
                    }
                }
            }
        }
        private void Frmdetallepago_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmdetallepago = null;
        }
        frmDetallePagoFactura frmdetallepago;
        public string NameEmpresa { get; private set; }
        frmTipodeCambio frmtipo;
        public void SacarTipoCambio()
        {
            DateTime FechaValidaBuscar = dtpFechaPago.Value;
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
        private void dtpFechaPago_ValueChanged(object sender, EventArgs e)
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

        private void cbobanco_Click(object sender, EventArgs e)
        {
            string cadenar = cbobanco.Text;
            cbobanco.ValueMember = "codigo";
            cbobanco.DisplayMember = "descripcion";
            cbobanco.DataSource = CapaLogica.getCargoTipoContratacion("Sufijo", "Entidad_Financiera", "TBL_Entidad_Financiera");
            cbobanco.Text = cadenar;
        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (ListaFacturas.Count > 0)
            {
                if (msgp("Seguro Desea Salir") == DialogResult.Yes) this.Close();
            }
            else this.Close();
        }
        public class Cuentas
        {
            public string _Cuenta;
            public decimal _Abonado;
            public decimal _Total;
            public int _tipo;
            public decimal _Exceso;
            public Cuentas(string cuenta, decimal abonado, decimal exceso, decimal total, int tipo)
            {
                _Cuenta = cuenta;
                _Abonado = abonado;
                _Exceso = exceso;
                _tipo = tipo;
                _Total = total;
            }
        }
        List<Cuentas> ListCuentas = new List<Cuentas>();
        public class NotaCreditoDebito
        {
            public Decimal Monto;
            public Decimal MontoNotas;
            public int Tipoid;
            public string NroCLiente;
            public string Nombres;
            public Boolean Tomado;
            public int Moneda;
            public int Nota;
            public NotaCreditoDebito(int _tipoid, string _nrocliente, Decimal _monto, decimal _montonotas, string _nombres, int _moneda, int _notas)
            {
                MontoNotas = _montonotas;
                Monto = _monto;
                NroCLiente = _nrocliente;
                Tipoid = _tipoid;
                Nombres = _nombres;
                Tomado = false;
                Moneda = _moneda;
                Nota = _notas;
            }
        }
        int[] ContenedorIdNotas = { 8, 54, 58, 9, 55, 59 };
        string[] ContenedorNotasCredito = { "8", "54", "58" };
        string[] ContenedorNotasDebito = { "9", "55", "59" };

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            CalcularTotal();
            //Validacion de la Fecha de Recepción sea meno a la de pago
            //foreach (DataGridViewRow item in dtgconten.Rows)
            //{
            //    if ((int)item.Cells[xopcion.Name].Value == 1)
            //    {
            //        if (((DateTime)item.Cells[xFechaContable.Name].Value).Date > dtpFechaPago.Value.Date || ((DateTime)item.Cells[xFechaContable.Name].Value).Date > dtpFechaContable.Value.Date)
            //        {
            //            HPResergerFunciones.frmInformativo.MostrarDialogError("No se Puede Abonar Documentos con fecha de Recepción superior a la Fecha de Pago", $"No se Proceso por: La Factura: {item.Cells[xNroComprobante.Name].Value.ToString()} \nRazonSocial: {item.Cells[xNombres.Name].Value}");
            //            return;
            //        }
            //    }
            //}
            //Validacion de que el periodo NO sea muy disperso, sea un mes continuo a los trabajados
            int IdEmpresa = (int)cboempresa.SelectedValue;
            DateTime FechaCoontable = dtpFechaContable.Value;
            if (!CapaLogica.ValidarCrearPeriodo(IdEmpresa, FechaCoontable))
            {
                if (HPResergerFunciones.frmPregunta.MostrarDialogYesCancel("No se Puede Registrar este Asiento\nEl Periodo no puede Crearse", $"¿Desea Crear el Periodo de {FechaCoontable.ToString("MMMM")}-{FechaCoontable.Year}?") != DialogResult.Yes)
                    return;
            }
            //FIN Validacion de la Fecha de Recepción sea meno a la de pago
            else if (!CapaLogica.VerificarPeriodoAbierto((int)cboempresa.SelectedValue, dtpFechaContable.Value))
            {
                msg("El Periodo Esta Cerrado, Cambie Fecha Contable"); dtpFechaContable.Focus(); return;
            }
            //Valido Cuenta en Exceso
            if (!txtCuentaExceso.ReadOnly && !chkPenalidad.Checked && !chkPenalidadTodo.Checked)
                if (!txtDescripcionCuentaExceso.EstaLLeno())
                {
                    msg("Ingrese La Cuenta Contable para El Exceso");
                    txtCuentaExceso.Focus(); return;
                }
            if (chkPenalidad.Checked || chkPenalidadTodo.Checked)
            {
                decimal Penalidad = 0; decimal.TryParse(txtMontoPenalidad.Text, out Penalidad);
                decimal Abonado = 0; decimal.TryParse(txttotalAbonado.Text, out Abonado);
                decimal Pagar = 0; decimal.TryParse(txtTotalPagar.Text, out Pagar);
                if (Penalidad <= 0)
                {
                    msg("El monto de la penalidad debe ser mayor a cero."); txtMontoPenalidad.Focus(); return;
                }
                if (Pagar - Abonado < 0)
                {
                    msg("No se puede abonar más de lo que hay que pagar."); return;
                }
                if (Math.Abs(Abonado) - Penalidad < 0)
                {
                    msg("El monto de la penalidad no puede ser mayor a la factura."); txtMontoPenalidad.Focus(); return;
                }
                if (!chkPenalidad.Checked)
                {
                    if (ListaFacturas.Count != 1)
                    {
                        msg("Solo debe haber una factura seleccionada."); return;
                    }
                }
                else
                {
                    //validamos que solo sean notas!
                    int ContaNotas = 0, ContaFacs = 0;
                    foreach (DataGridViewRow item in dtgconten.Rows)
                    {
                        if ((int)item.Cells[xopcion.Name].Value == 1)
                        {
                            if (item.Cells[xTipo.Name].Value.ToString().ToUpper() != "NC")
                                ContaFacs++;
                            if (item.Cells[xTipo.Name].Value.ToString().ToUpper() == "NC")
                                ContaNotas++;
                        }
                    }
                    if (ContaFacs > 0) { msg("Solo Seleccione Notas"); return; }
                    if (ContaNotas <= 0) { msg("Seleccione Notas"); return; }
                }
                ////validacion para proceder;
                if (msgp("¿Seguro desea aplicar la penalidad?") != DialogResult.Yes)
                {
                    return;
                }
            }
            if (cbotipo.Items.Count == 0) { cbotipo.Focus(); msg("Seleccione Tipo de Pago"); return; }
            if (cboproyecto.SelectedValue == null)
            {
                msg("Seleccione un Proyecto"); cboproyecto.Focus(); return;
            }
            ////LISTADO DE NOTAS
            List<NotaCreditoDebito> ListadoNotas = new List<NotaCreditoDebito>();
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                string Tipos = item.Cells[xIdComprobante.Name].Value.ToString();
                int Notas = (int)item.Cells[xIdComprobante.Name].Value;
                if (ContenedorIdNotas.Contains(Notas)) { } else { Notas = 0; }
                int tipoid = (int)item.Cells[xTipoId.Name].Value;
                string Nrodoccliente = item.Cells[xTipoId.Name].Value.ToString();
                string Nombrecliente = item.Cells[xNombres.Name].Value.ToString();
                decimal Monto = (decimal)item.Cells[xpagar.Name].Value;
                int Moneda = (int)item.Cells[xMoneda.Name].Value;
                if (item.Cells[xopcion.Name].Value.ToString() == "1")
                {
                    NotaCreditoDebito Notita = ListadoNotas.Find(cust => cust.Tipoid == tipoid && cust.NroCLiente == Nrodoccliente && Notas == cust.Nota);
                    if (Notita == null)
                    {
                        if (ContenedorNotasDebito.Contains(Tipos))// == "9")
                            ListadoNotas.Add(new NotaCreditoDebito(tipoid, Nrodoccliente, 0, Monto, Nombrecliente, Moneda, Notas));
                        else if (ContenedorNotasCredito.Contains(Tipos))// == "8")
                            ListadoNotas.Add(new NotaCreditoDebito(tipoid, Nrodoccliente, 0, -1 * Monto, Nombrecliente, Moneda, Notas));
                        else
                            ListadoNotas.Add(new NotaCreditoDebito(tipoid, Nrodoccliente, Monto, 0, Nombrecliente, Moneda, Notas));
                    }
                    else
                    {
                        if (ContenedorNotasDebito.Contains(Tipos)) { Notita.MontoNotas += Monto; }
                        else if (ContenedorNotasCredito.Contains(Tipos)) { Notita.MontoNotas -= Monto; }
                        else { Notita.Monto += Monto; }
                    }
                }
            }
            if (ListadoNotas.Count == 0)
                if (txttotalAbonado.Text.Length > 0)
                {
                    if (decimal.Parse(txttotalAbonado.Text) == 0)
                    {
                        msg("El total a pagar no puede ser Cero");
                        dtgconten.Focus();
                        return;
                    }
                }
                else
                {
                    msg("El Monto esta Vacío, Seleccioné una Fila de la grilla");
                    dtgconten.Focus();
                    return;
                }
            //Sí el monto abonado es menor que la penalidad
            if (chkPenalidadTodo.Checked)
            {
                if (Math.Abs(decimal.Parse(txttotalAbonado.Text)) <= decimal.Parse(txtMontoPenalidad.Text))
                {
                    msg("El Monto Abonado debe ser Mayor de la penalidad");
                    return;
                }
            }
            ////validaciones 
            if (decimal.Parse(txttipocambio.Text) <= 0) { msg("Revise el Tipo de Cambio"); dtpFechaPago_ValueChanged(sender, e); txttipocambio.Focus(); return; }
            CalcularDiferencial();
            ListCuentas.Clear();
            int contador = 0;
            //if (decimal.Parse(txttotal.Text) <= 0) { msg("No se Puede Abonar Cero"); return; }
            if (decimal.Parse(txttotalAbonado.Text) != 0)
            {
                if (!txtnrooperacion.EstaLLeno() && !chkPenalidad.Checked) { msg("Ingrese Número de Operación"); txtnrooperacion.Focus(); return; }
                if (rdbPagoBanco.Checked && !chkPenalidad.Checked)
                {
                    if (cbocuentabanco.Items.Count == 0) { msg("El Banco Seleccionado no tiene Cuentas"); cbobanco.Focus(); return; }
                    if (cbocuentabanco.SelectedValue == null) { msg("Selecione Cuentas Bancaria"); cbocuentabanco.Focus(); return; }
                    if (cbobanco.Items.Count == 0) { msg("No hay Bancos"); cboempresa.Focus(); return; }
                    if (cbobanco.SelectedValue == null) { msg("Selecione Bancos"); cbobanco.Focus(); return; }
                }
                if (rdbDepositoPLazo.Checked && !chkPenalidad.Checked)
                {
                    if (cbodepositoplazo.Items.Count == 0) { msg("No hay Cuentas de Deposito a Plazo"); cbodepositoplazo.Focus(); return; }
                    if (cbodepositoplazo.SelectedValue == null) { msg("Selecione Cuenta de Deposito a Plazo"); cbodepositoplazo.Focus(); return; }
                }
                if (rdbCertificadoBancario.Checked && !chkPenalidad.Checked)
                {
                    if (cboCertificadobancario.Items.Count == 0) { msg("No hay Cuentas de Certificado Bancario"); cboCertificadobancario.Focus(); return; }
                    if (cboCertificadobancario.SelectedValue == null) { msg("Selecione Cuenta de Certificado Bancario"); cboCertificadobancario.Focus(); return; }
                }
            }
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if ((int)item.Cells[xopcion.Name].Value == 1)
                {
                    contador++;
                    int Notas = (int)item.Cells[xIdComprobante.Name].Value; if (ContenedorIdNotas.Contains(Notas)) { } else Notas = 0;
                    Cuentas Cuentita = ListCuentas.Find(cust => cust._Cuenta == item.Cells[xCuentaContable.Name].Value.ToString() && cust._tipo == Notas);
                    string Valtipo = item.Cells[xIdComprobante.Name].Value.ToString();
                    int Signo = ContenedorNotasCredito.Contains(Valtipo) ? -1 : 1;
                    decimal Abonado = (decimal)item.Cells[xpagar.Name].Value > (decimal)item.Cells[xTotal.Name].Value ? (decimal)item.Cells[xTotal.Name].Value : (decimal)item.Cells[xpagar.Name].Value;
                    if (Cuentita == null) ListCuentas.Add(new Cuentas(item.Cells[xCuentaContable.Name].Value.ToString(), Signo * Abonado, Signo * ((decimal)item.Cells[xpagar.Name].Value > (decimal)item.Cells[xTotal.Name].Value ? ((decimal)item.Cells[xpagar.Name].Value) - (decimal)item.Cells[xTotal.Name].Value : 0), Signo * (decimal)item.Cells[xTotal.Name].Value, Notas));
                    else
                    {
                        if (ContenedorNotasCredito.Contains(Valtipo))
                        {
                            Cuentita._Abonado -= Abonado; //(decimal)item.Cells[xpagar.Name].Value; 
                            Cuentita._Exceso -= ((decimal)item.Cells[xpagar.Name].Value > (decimal)item.Cells[xTotal.Name].Value ? ((decimal)item.Cells[xpagar.Name].Value) - (decimal)item.Cells[xTotal.Name].Value : 0);
                        }
                        else
                        {
                            Cuentita._Abonado += Abonado;// (decimal)item.Cells[xpagar.Name].Value; 
                            Cuentita._Exceso += ((decimal)item.Cells[xpagar.Name].Value > (decimal)item.Cells[xTotal.Name].Value ? ((decimal)item.Cells[xpagar.Name].Value) - (decimal)item.Cells[xTotal.Name].Value : 0);
                        }
                    }
                }
            }
            if (contador == 0) { msg("Selecione Facturas"); dtgconten.Focus(); return; }
            //Declaracion de Variables;
            int ContadorFilaDiferencial = contador + 2;
            DateTime FechaContable = dtpFechaContable.Value;
            DateTime FechaPago = dtpFechaPago.Value;
            IdEmpresa = (int)cboempresa.SelectedValue;
            string CuentaBanco = "";
            string Banko = "";
            string Glosa = txtglosa.TextValido();
            string NroOperacion = txtnrooperacion.TextValido();
            decimal tc = decimal.Parse(txttipocambio.Text);
            decimal TotalAbonado = decimal.Parse(txttotalAbonado.Text);
            string nroKuenta = "";
            string CuentaExceso = txtCuentaExceso.Text;
            int IdUsuario = frmLogin.CodigoUsuario;
            int numasiento = 0;
            if (numasiento == 0)
            {
                DataTable asientito = CapaLogica.UltimoAsiento(IdEmpresa, FechaContable);
                DataRow asiento = asientito.Rows[0];
                if (asiento == null) { numasiento = 1; }
                else
                    numasiento = ((int)asiento["codigo"]);
            }
            string Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, FechaContable);
            string CuoReg = Cuo;
            string Mensaje = "";
            int proyecto = 0, etapa = 0, moneda = 1;
            foreach (DataGridViewRow item in dtgconten.Rows)
                if ((int)item.Cells[xopcion.Name].Value == 1) { proyecto = (int)cboproyecto.SelectedValue; etapa = (int)item.Cells[xfketapa.Name].Value; moneda = (int)item.Cells[xMoneda.Name].Value; break; }
            ///Fin de Declaracion;
            if (TotalAbonado != 0)
            {
                if (rdbPagoBanco.Checked && !chkPenalidad.Checked) { CuentaBanco = cbocuentabanco.SelectedValue.ToString(); nroKuenta = HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text); Banko = cbobanco.SelectedValue.ToString(); }
                if (rdbDepositoPLazo.Checked && !chkPenalidad.Checked) { CuentaBanco = cbodepositoplazo.SelectedValue.ToString(); Banko = "-1"; }
                if (rdbCertificadoBancario.Checked && !chkPenalidad.Checked) { CuentaBanco = cboCertificadobancario.SelectedValue.ToString(); Banko = "-2"; }
            }
            ////Aplicacion de la Penalidad//
            int PosFila = 0;
            decimal MontoPenalidad = 0;
            decimal MontoAbonado = 0;
            decimal.TryParse(txttotalAbonado.Text, out MontoAbonado);
            if (chkPenalidad.Checked || chkPenalidadTodo.Checked)
            {
                //VALIDAMOS QUE NO EXISTAN CUENTAS CONTABLES DESACTIVADAS
                string valex = "";
                foreach (Cuentas item in ListCuentas) valex += item._Cuenta + ",";
                valex += txtCuentaExceso.Text;
                if (CapaLogica.CuentaContableValidarActivas(valex, "Cuentas Contables Desactivadas")) return;
                //FIN DE LA VALDIACION DE LAS CUENTAS CONTABLES DESACTIVADAS
                decimal.TryParse(txtMontoPenalidad.Text, out MontoPenalidad);
                //Cabecera de Penalidad
                //Cuenta de Facturas 
                //if (ListaFacturas.Count == 1)
                foreach (Cuentas item in ListCuentas)
                {
                    //Declaracion de VAriables para el Proceso
                    decimal Abonado = item._Exceso > item._Total ? item._Total : item._Exceso;
                    decimal Exceso = item._Exceso;
                    //CUENTAS DE LAS FACTURAS
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, item._Cuenta, (item._Abonado < 0 ? (ListaFacturas.Count == 1 ? Math.Abs(MontoPenalidad) :
                       Math.Abs(item._Abonado)) : 0), item._Abonado < 0 ? 0 : (ListaFacturas.Count == 1 ? Math.Abs(MontoPenalidad) : Math.Abs(item._Abonado)), tc
                        , proyecto, etapa, Cuo, moneda, Glosa, FechaPago, -7);
                }
                //else if (ListaFacturas.Count > 1)
                //{
                //    foreach (DataGridViewRow item in dtgconten.Rows)
                //    {
                //        if ((int)item.Cells[xopcion.Name].Value == 1)
                //            CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, item.Cells[xCuentaContable.Name].Value.ToString(),
                //                (TotalAbonado < 0 ? Math.Abs((decimal)item.Cells[xTotal.Name].Value) : 0), TotalAbonado < 0 ? 0 : Math.Abs((decimal)item.Cells[xTotal.Name].Value), tc
                //                , proyecto, etapa, Cuo, moneda, Glosa, FechaPago, -7);
                //    }
                //}
                //Cuenta de Penalidad
                int Posfinal = ++PosFila;
                CapaLogica.InsertarAsientoFacturaCabecera(1, Posfinal, numasiento, FechaContable, txtCuentaExceso.Text, TotalAbonado > 0 ? MontoPenalidad : 0, TotalAbonado < 0 ? MontoPenalidad : 0, tc, proyecto, etapa, Cuo, moneda, Glosa, FechaPago, -7);
                //Fin de Cabecera de Penalidad
                //Detalle de la Penalidad
                //Detalle Cuentas
                PosFila = 0;
                foreach (Cuentas items in ListCuentas)
                {
                    PosFila++;
                    foreach (DataGridViewRow item in dtgconten.Rows)
                        if ((int)item.Cells[xopcion.Name].Value == 1)
                        {
                            int Notas = (int)item.Cells[xIdComprobante.Name].Value; if (ContenedorIdNotas.Contains(Notas)) { } else Notas = 0;
                            if (item.Cells[xCuentaContable.Name].Value.ToString() == items._Cuenta && items._tipo == Notas)
                            {
                                //Declaracion de VAriables para el Proceso
                                string[] valor = item.Cells[xNroComprobante.Name].Value.ToString().Split('-');
                                decimal TCREg = (decimal)item.Cells[xTC.Name].Value;
                                DateTime fecha = DateTime.Now;
                                //Detalle de las Facturas
                                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, items._Cuenta, proyecto, (int)item.Cells[xTipoId.Name].Value, item.Cells[xCliente.Name].Value.ToString()
                                    , item.Cells[xNombres.Name].Value.ToString(), (int)item.Cells[xIdComprobante.Name].Value, valor[0], valor[1], 0, FechaPago, fecha, fecha,
                                    ListaFacturas.Count == 1 ? MontoPenalidad : (decimal)item.Cells[xTotal.Name].Value,
                                    ListaFacturas.Count == 1 ? MontoPenalidad / tc : (decimal)item.Cells[xTotal.Name].Value / tc,
                                    //MontoPenalidad,// (decimal)item.Cells[xpagar.Name].Value,
                                    //MontoPenalidad, 
                                    item.Cells[xNameCorto.Name].Value.ToString() == "USD" ? (decimal)item.Cells[xTC.Name].Value : tc,
                                    (int)item.Cells[xMoneda.Name].Value, nroKuenta, NroOperacion, Glosa, FechaPago, IdUsuario, "");
                                //Detalle Cuenta Penalidad
                                DateTime fechaa = DateTime.Now;
                                CapaLogica.InsertarAsientoFacturaDetalle(10, Posfinal, numasiento, FechaContable, txtCuentaExceso.Text, proyecto, (int)item.Cells[xTipoId.Name].Value, item.Cells[xCliente.Name].Value.ToString()
                                    , item.Cells[xNombres.Name].Value.ToString(), (int)item.Cells[xIdComprobante.Name].Value, valor[0], valor[1], 0, FechaPago, fechaa, fechaa,
                                    ListaFacturas.Count == 1 ? MontoPenalidad : (decimal)item.Cells[xTotal.Name].Value,
                                    ListaFacturas.Count == 1 ? MontoPenalidad / tc : (decimal)item.Cells[xTotal.Name].Value / tc,
                                    //moneda == 1 ? MontoPenalidad : MontoPenalidad * tc
                                    //, moneda == 2 ? MontoPenalidad : MontoPenalidad / tc                                    , 
                                    tc, moneda, nroKuenta, NroOperacion, Glosa, FechaPago, IdUsuario, "");
                                //Fin Detalle de la Penalidad                            
                            }
                        }
                }
                CuoReg = Cuo;
                Mensaje += $"Penalidad Abonada en cuo: {CuoReg} \n";
                ///Sacamos el Nuevo Cuo
                DataTable asientito = CapaLogica.UltimoAsiento(IdEmpresa, FechaContable);
                DataRow asiento = asientito.Rows[0];
                if (asiento == null) { numasiento = 1; }
                else numasiento = ((int)asiento["codigo"]);
                Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, FechaContable);
                //Fin de Busqueda del Nuevo Cuo
            }
            //Fin de la Penalidad
            ////////CABECERA DE LOS ASIENTOS
            //Penalidad + Abono 
            if (!chkPenalidad.Checked)
            {
                //VALIDAMOS QUE NO EXISTAN CUENTAS CONTABLES DESACTIVADAS
                List<string> ListaAuxiliar = new List<string>();
                foreach (DataGridViewRow item in dtgconten.Rows)
                    if ((int)item.Cells[xopcion.Name].Value == 1)
                        ListaAuxiliar.Add(item.Cells[xCuentaContable.Name].Value.ToString());
                ListaAuxiliar.Add(CuentaBanco);
                ListaAuxiliar.Add(CuentaExceso);
                ///fin de la cabecera del exceso             
                if (CapaLogica.CuentaContableValidarActivas(string.Join(",", ListaAuxiliar.ToArray()), "Cuentas Contables Desactivadas")) return;
                //FIN DE LA VALDIACION DE LAS CUENTAS CONTABLES DESACTIVADAS
                PosFila = 1;
                //CUENTA BANCO
                if (TotalAbonado != 0)
                    CapaLogica.InsertarAsientoFacturaCabecera(1, PosFila, numasiento, FechaContable, CuentaBanco, TotalAbonado > 0 ? Math.Abs(TotalAbonado) - MontoPenalidad : 0, TotalAbonado < 0 ? Math.Abs(TotalAbonado) - MontoPenalidad : 0, tc, proyecto
                        , etapa, Cuo, moneda, Glosa, FechaPago, -7);
                //CUENTAS DE LAS FACTURAS Y EL EXCESO EN ABONO
                decimal TotalExcesos = 0;
                int ContadorFacturas = 0;
                foreach (DataGridViewRow item in dtgconten.Rows)
                    if ((int)item.Cells[xopcion.Name].Value == 1)
                    {
                        //Declaracion de VAriables para el Proceso
                        int Multiplicador = 1;
                        decimal Abonado = (decimal)(item.Cells[xpagar.Name].Value) > (decimal)(item.Cells[xTotal.Name].Value) ? (decimal)(item.Cells[xTotal.Name].Value) : (decimal)(item.Cells[xpagar.Name].Value);
                        decimal Excesos = (decimal)(item.Cells[xpagar.Name].Value) - (decimal)(item.Cells[xTotal.Name].Value);
                        string CuentaFacturas = item.Cells[xCuentaContable.Name].Value.ToString();
                        if (ContenedorNotasCredito.Contains(item.Cells[xIdComprobante.Name].Value.ToString())) Multiplicador = -1;
                        //decimal Abonado = item._Exceso > item._Total ? item._Total : item._Exceso;
                        //decimal Exceso = item._Exceso;
                        //CUENTAS DE LAS FACTURAS
                        CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaFacturas, Abonado * Multiplicador < 0 ? Math.Abs(Abonado) - MontoPenalidad : 0
                            , Abonado * Multiplicador < 0 ? 0 : Math.Abs(Abonado) - MontoPenalidad, tc, proyecto, etapa, Cuo, moneda, Glosa, FechaPago, -7);
                        //CABECERA DE EXCESO EN ABONO
                        if (Excesos > 0)
                            TotalExcesos += Excesos;
                        ContadorFacturas++;
                    }
                ///cabecera del exceso
                if (TotalExcesos > 0)
                {
                    CapaLogica.InsertarAsientoFacturaCabecera(1, 2 + ContadorFacturas, numasiento, FechaContable, CuentaExceso, TotalExcesos < 0 ? Math.Abs(TotalExcesos) : 0, TotalExcesos < 0 ? 0 : Math.Abs(TotalExcesos)
                        , tc, proyecto, etapa, Cuo, moneda, Glosa, FechaPago, -7);
                }
                ///fin de la cabecera del exceso
                //CUENTA DIFERENCIA DE CAMBIO
                if (decimal.Parse(txttotaldiferencial.Text) != 0)
                    CapaLogica.InsertarAsientoFacturaCabecera(2, ++PosFila, numasiento, FechaContable, "", decimal.Parse(txttotaldiferencial.Text), 0, tc, proyecto, etapa, Cuo, moneda, Glosa, FechaPago, -7);
                ////FIN DE LAS CABECERAS
                ////DETALLE DE LOS ASIENTOS
                PosFila = 1;
                ////LOS BANCOS
                if (TotalAbonado != 0)
                {
                    DateTime fecha = DateTime.Now;
                    decimal AbonadoSoles = 0, AbonadoDolares = 0;
                    if (moneda == 1)
                    {
                        AbonadoSoles = Math.Abs((TotalAbonado) + MontoPenalidad);
                        AbonadoDolares = (Math.Abs((TotalAbonado) + MontoPenalidad) / tc);
                    }
                    if (moneda == 2)
                    {
                        AbonadoSoles = (Math.Abs((TotalAbonado) + MontoPenalidad)) * tc;
                        AbonadoDolares = Math.Abs((TotalAbonado) + MontoPenalidad);
                    }
                    CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaBanco, proyecto, 0, "99999", "VARIOS", 0, "0", "0", 0,
                                           FechaPago, FechaContable, FechaContable, AbonadoSoles, AbonadoDolares, tc, moneda, nroKuenta, NroOperacion, Glosa, FechaPago, IdUsuario, CuoReg, (int)cbotipo.SelectedValue);
                }
                //foreach (DataGridViewRow item in dtgconten.Rows)
                //{
                //    if ((int)item.Cells[xopcion.Name].Value == 1)
                //    {
                //        string[] valor = item.Cells[xNroComprobante.Name].Value.ToString().Split('-');
                //        int Multiplicador = 1;
                //        DateTime fecha = DateTime.Now;
                //        if (ContenedorNotasCredito.Contains(item.Cells[xIdComprobante.Name].Value.ToString())) Multiplicador = -1;
                //        CapaLogica.InsertarAsientoFacturaDetalle(1, PosFila, numasiento, FechaContable, CuentaBanco, proyecto, (int)item.Cells[xTipoId.Name].Value, item.Cells[xCliente.Name].Value.ToString()
                //            , item.Cells[xNombres.Name].Value.ToString(), (int)item.Cells[xIdComprobante.Name].Value, valor[0], valor[1], 0, FechaPago, fecha, fecha
                //            , ((TotalAbonado < 0 ? -1 : 1) * (Multiplicador * (decimal)item.Cells[xpagar.Name].Value)) - MontoPenalidad
                //            , ((TotalAbonado < 0 ? -1 : 1) * (Multiplicador * (decimal)item.Cells[xTotal.Name].Value)) - MontoPenalidad
                //          , tc, (int)item.Cells[xMoneda.Name].Value, nroKuenta, NroOperacion, Glosa,
                //          FechaPago, IdUsuario, CuoReg);
                //    }
                //}
                ////LISTADO DE CUENTAS
                //foreach (Cuentas items in ListCuentas)
                //{
                //    PosFila++;
                foreach (DataGridViewRow item in dtgconten.Rows)
                    if ((int)item.Cells[xopcion.Name].Value == 1)
                    {
                        int Notas = (int)item.Cells[xIdComprobante.Name].Value; if (ContenedorIdNotas.Contains(Notas)) { } else Notas = 0;
                        //if (item.Cells[xCuentaContable.Name].Value.ToString() == items._Cuenta && items._tipo == Notas)
                        //{
                        //Declaracion de VAriables para el Proceso
                        decimal Abonado = (decimal)item.Cells[xpagar.Name].Value > (decimal)item.Cells[xTotal.Name].Value ? (decimal)item.Cells[xTotal.Name].Value : (decimal)item.Cells[xpagar.Name].Value;
                        string CuentaFactuaras = item.Cells[xCuentaContable.Name].Value.ToString();
                        //Resto de la Penalidad
                        Abonado -= MontoPenalidad;
                        decimal Exceso = (decimal)item.Cells[xpagar.Name].Value > (decimal)item.Cells[xTotal.Name].Value ? (decimal)item.Cells[xpagar.Name].Value - (decimal)item.Cells[xTotal.Name].Value : 0;
                        string[] valor = item.Cells[xNroComprobante.Name].Value.ToString().Split('-');
                        DateTime fecha = DateTime.Now;
                        //Detalle de las Facturas
                        CapaLogica.InsertarAsientoFacturaDetalle(1, ++PosFila, numasiento, FechaContable, CuentaFactuaras, proyecto, (int)item.Cells[xTipoId.Name].Value, item.Cells[xCliente.Name].Value.ToString()
                                                    , item.Cells[xNombres.Name].Value.ToString(), (int)item.Cells[xIdComprobante.Name].Value, valor[0], valor[1], 0, FechaPago, fecha, fecha, Abonado,// (decimal)item.Cells[xpagar.Name].Value,
                                                    (decimal)item.Cells[xTotal.Name].Value,
                                                   /* item.Cells[xNameCorto.Name].Value.ToString() == "USD" ? */(decimal)item.Cells[xTC.Name].Value //: tc
                                                    , (int)item.Cells[xMoneda.Name].Value, nroKuenta, NroOperacion, Glosa, FechaPago, IdUsuario, CuoReg);
                        //Detalle del Exceso
                        if (Exceso > 0)
                        {
                            CapaLogica.InsertarAsientoFacturaDetalle(1, 2 + ContadorFacturas, numasiento, FechaContable, CuentaExceso, proyecto, (int)item.Cells[xTipoId.Name].Value, item.Cells[xCliente.Name].Value.ToString()
                                , item.Cells[xNombres.Name].Value.ToString(), (int)item.Cells[xIdComprobante.Name].Value, valor[0], valor[1], 0, FechaPago, fecha, fecha, Exceso,// (decimal)item.Cells[xpagar.Name].Value,
                                (decimal)item.Cells[xTotal.Name].Value,
                                /*item.Cells[xNameCorto.Name].Value.ToString() == "USD" ?*/ (decimal)item.Cells[xTC.Name].Value// : tc
                                , (int)item.Cells[xMoneda.Name].Value, nroKuenta, NroOperacion, Glosa, FechaPago, IdUsuario, CuoReg);
                        }
                        //}
                    }
                //}
                PosFila++;
                /////Diferencial de Cambio
                foreach (DataGridViewRow item in dtgconten.Rows)
                {
                    if ((int)item.Cells[xopcion.Name].Value == 1)
                    {
                        if (item.Cells[xNameCorto.Name].Value.ToString() == "USD")
                        {
                            decimal Dif = Configuraciones.Redondear((decimal)item.Cells[xpagar.Name].Value * tc) - Configuraciones.Redondear((decimal)item.Cells[xpagar.Name].Value * (decimal)item.Cells[xTC.Name].Value);
                            Dif = (ContenedorNotasCredito.Contains(item.Cells[xIdComprobante.Name].Value.ToString()) ? 1 : -1) * Dif;
                            if (Math.Abs(Dif) > 0)
                            {
                                string[] valor = item.Cells[xNroComprobante.Name].Value.ToString().Split('-');
                                DateTime fecha = DateTime.Now;
                                CapaLogica.InsertarAsientoFacturaDetalle(2, PosFila, numasiento, FechaContable, CuentaBanco, proyecto, (int)item.Cells[xTipoId.Name].Value, item.Cells[xCliente.Name].Value.ToString()
                                                                    , item.Cells[xNombres.Name].Value.ToString(), (int)item.Cells[xIdComprobante.Name].Value, valor[0], valor[1], 0, FechaPago, fecha, fecha, Dif,
                                                                     decimal.Parse(txttotaldiferencial.Text), tc, (int)item.Cells[xMoneda.Name].Value, nroKuenta,
                                                                     NroOperacion, Glosa, FechaPago, IdUsuario, CuoReg, (int)cbotipo.SelectedValue);
                            }
                        }
                    }
                }
                Mensaje += $"Facturas  Abonadas en cuo: {Cuo}";
                //#region   Cuadrar Asiento
                CapaLogica.CuadrarAsiento(Cuo, proyecto, FechaPago, 2);
                //#endregion Fin Cuadrar Asiento
            }
            ////FIN DETALE DE LOS ASIENTOS
            ////ACTUALIZADO LOS ABONOS  
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if ((int)item.Cells[xopcion.Name].Value == 1)
                {
                    string Tipox = item.Cells[xIdComprobante.Name].Value.ToString();
                    int opcion = 1;
                    if (ContenedorIdNotas.Contains(int.Parse(Tipox))) { opcion = 2; }
                    if (opcion == 2)
                    {
                        //Agrego el Pago
                        CapaLogica.FacturaVentaManualPago(opcion, (int)item.Cells[xIdComprobante.Name].Value, item.Cells[xNroComprobante.Name].Value.ToString(), txtnrooperacion.TextValido(), (int)item.Cells[xTipoId.Name].Value
                         , item.Cells[xCliente.Name].Value.ToString(), (int)cboempresa.SelectedValue
                         , chkPenalidad.Checked && ListaFacturas.Count == 1 ? MontoPenalidad : (decimal)item.Cells[xpagar.Name].Value, (decimal)item.Cells[xTC.Name].Value, Banko, nroKuenta, FechaPago, CuoReg, IdUsuario, (int)cbotipo.SelectedValue);
                        //Actualizar notas de credito- Cambia a pagada!
                        if (chkPenalidad.Checked)
                        {
                            if (ListaFacturas.Count == 1 && MontoPenalidad >= (decimal)item.Cells[xTotal.Name].Value)
                                CapaLogica.ActualizarNotaCreditoDebito((int)item.Cells[xIdComprobante.Name].Value, item.Cells[xTipoId.Name].Value.ToString() + item.Cells[xCliente.Name].Value.ToString(), item.Cells[xNroComprobante.Name].Value.ToString(), 2, (int)cboempresa.SelectedValue);
                            else if (ListaFacturas.Count > 1)//&& MontoPenalidad >= (decimal)item.Cells[xTotal.Name].Value)
                                CapaLogica.ActualizarNotaCreditoDebito((int)item.Cells[xIdComprobante.Name].Value, item.Cells[xTipoId.Name].Value.ToString() + item.Cells[xCliente.Name].Value.ToString(), item.Cells[xNroComprobante.Name].Value.ToString(), 2, (int)cboempresa.SelectedValue);
                        }
                        else
                        {
                            if ((decimal)item.Cells[xpagar.Name].Value >= (decimal)item.Cells[xTotal.Name].Value)
                                CapaLogica.ActualizarNotaCreditoDebito((int)item.Cells[xIdComprobante.Name].Value, item.Cells[xTipoId.Name].Value.ToString() + item.Cells[xCliente.Name].Value.ToString(), item.Cells[xNroComprobante.Name].Value.ToString(), 2, (int)cboempresa.SelectedValue);
                        }
                    }
                    else
                        CapaLogica.FacturaVentaManualPago(opcion, (int)item.Cells[xIdComprobante.Name].Value, item.Cells[xNroComprobante.Name].Value.ToString(), txtnrooperacion.TextValido(), (int)item.Cells[xTipoId.Name].Value
                            , item.Cells[xCliente.Name].Value.ToString(), (int)cboempresa.SelectedValue,// chkPenalidad.Checked ? MontoPenalidad :
                            (decimal)item.Cells[xpagar.Name].Value, (decimal)item.Cells[xTC.Name].Value, Banko, nroKuenta, FechaPago, CuoReg, IdUsuario, (int)cbotipo.SelectedValue);
                }
            }
            msgOK($"{Mensaje}");
            txtTotalPagar.Text = txttotalAbonado.Text = txttotaldiferencial.Text = "0.00";
            ////txtnrooperacion.CargarTextoporDefecto();txtglosa.CargarTextoporDefecto();
            ListaFacturax.Clear();
            ListadoNotas.Clear();
            ListaFacturas.Clear();
            txtCuentaExceso.ReadOnly = true;
            BusquedaDatos();
        }
        public void CalcularDiferencial()
        {
            decimal Diferencial = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if (item.Cells[xopcion.Name].Value.ToString() == "") item.Cells[xopcion.Name].Value = 0;
                if ((int)item.Cells[xopcion.Name].Value == 1)
                {
                    if (item.Cells[xNameCorto.Name].Value.ToString() == "USD")
                    {
                        if (ContenedorNotasCredito.Contains(item.Cells[xIdComprobante.Name].Value.ToString()))
                            Diferencial -= Configuraciones.Redondear((decimal)item.Cells[xpagar.Name].Value * decimal.Parse(txttipocambio.Text)) - Configuraciones.Redondear((decimal)item.Cells[xpagar.Name].Value * (decimal)item.Cells[xTC.Name].Value);
                        else
                            Diferencial += Configuraciones.Redondear((decimal)item.Cells[xpagar.Name].Value * decimal.Parse(txttipocambio.Text)) - Configuraciones.Redondear((decimal)item.Cells[xpagar.Name].Value * (decimal)item.Cells[xTC.Name].Value);
                    }
                }
            }
            txttotaldiferencial.Text = Diferencial.ToString("n2");
        }
        TextBox txt;
        private void dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int x = dtgconten.CurrentCell.RowIndex, y = dtgconten.CurrentCell.ColumnIndex;
            txt = e.Control as TextBox;
            txt.KeyDown -= Txt_KeyDown;
            txt.KeyPress -= Txt_KeyPress;
            if (y == dtgconten.Columns[xpagar.Name].Index)
            {
                //si edito el pago
                txt.KeyDown += Txt_KeyDown;
                txt.KeyPress += Txt_KeyPress;
            }
            //if (y == dtgconten.Columns[xpagar.Name].Index)
            //{
            //    if (ContenedorIdNotas.Contains((int)dtgconten[xIdComprobante.Name, x].Value))
            //    {
            //        dtgconten[y, x].ReadOnly = true;
            //        dtgconten.CancelEdit();
            //    }
            //    else
            //        dtgconten[y, x].ReadOnly = false;
            //}
        }
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimalesX(e, txt.Text);
        }
        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txt);
        }

        private void txttipocambio_TextChanged(object sender, EventArgs e)
        {
            CalcularDiferencial();
        }

        private void rdbporAbonar_CheckedChanged(object sender, EventArgs e)
        {
            Boolean a = true;
            if (rdbporAbonar.Checked)
            {
                a = true;
                dtgconten.Columns[xFechaVencimiento.Name].HeaderText = "Fecha Venc.";
                dtgconten.Columns[xGlosa.Name].HeaderText = "Glosa";
                dtgconten.Columns[xAbonos.Name].HeaderText = "Abonos";
                dtgconten.Columns[xCuentaContable.Name].HeaderText = "Banco";
            }
            else
            {
                a = false;
                dtgconten.Columns[xFechaVencimiento.Name].HeaderText = "Fecha Abono";
                dtgconten.Columns[xGlosa.Name].HeaderText = "Nro OP Banc.";
                dtgconten.Columns[xAbonos.Name].HeaderText = "Editar";
                dtgconten.Columns[xAbonos.Name].HeaderText = "Abonos";
                dtgconten.Columns[xCuentaContable.Name].HeaderText = "Banco";

            }
            dtgconten.Columns[xopcion.Name].Visible = a;
            dtgconten.Columns[xpagar.Name].Visible = a;
            dtgconten.Columns[xCuentaContable.Name].Visible = !a;
            dtgconten.Columns[xcuo.Name].Visible = !a;
            BusquedaDatos();
            if (!a) txttotalAbonado.Text = txttotaldiferencial.Text = "0.00";
        }

        private void dtgconten_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                if (rdbAbonados.Checked && dtgconten[xAbonos.Name, x].Value.ToString() != "")
                {
                    frmDetalleNroOp frmnroop = new frmDetalleNroOp(dtgconten[xCliente.Name, x].Value.ToString(), dtgconten[xNombres.Name, x].Value.ToString(), dtgconten[xNroComprobante.Name, x].Value.ToString(), dtgconten[xAbonos.Name, x].Value.ToString()
                        , dtgconten[xcuo.Name, x].Value.ToString());
                    frmnroop.Codigo = (int)dtgconten[xId.Name, x].Value;
                    frmnroop.nrooperacion = dtgconten[xGlosa.Name, x].Value.ToString();
                    frmnroop.Fechapago = (DateTime)dtgconten[xFechaVencimiento.Name, x].Value;
                    frmnroop.Empresa = (int)cboempresa.SelectedValue;
                    //tipodet ==5 factura venta manual
                    frmnroop.Tipodet = 5;
                    frmnroop.IdComprobante = (int)dtgconten[xIdComprobante.Name, x].Value;
                    frmnroop.ShowDialog();
                    BusquedaDatos();
                }
            }
            //else if (x == -1)
            //{
            //    if (y == dtgconten.Columns[xopcion.Name].Index)
            //    {
            //        //dtgconten.Sort(xopcion, ListSortDirection.Descending);
            //        int val = (int)dtgconten[xopcion.Name, 0].Value;
            //        foreach (DataGridViewRow item in dtgconten.Rows)
            //        {
            //            item.Cells[xopcion.Name].Value = val == 1 ? 0 : 1;
            //        }
            //    }
            //}
        }
        frmProcesando frmproce;
        private void btnpdf_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                dtgconten.SuspendLayout();
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                if (rdbAbonados.Checked)
                {
                    _NombreHoja = "Documentos Abonados"; _Cabecera = "Comprobantes Abonados"; _Columnas = new int[] { 3, 4, 5, 8, 11, 14, 15, 17, 19, 20, 24, 25 }; _NColumna = "l";
                }
                else
                {
                    _NombreHoja = "Documentos por Abonar"; _Cabecera = "Comprobantes por Abonar"; _Columnas = new int[] { 3, 4, 5, 8, 11, 14, 15, 17, 18, 19, 20, 23, 24 }; _NColumna = "m";
                }
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", $"{_NColumna}1", _Cabecera.ToUpper(), 16, true, true, Back, Fore));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", $"{_NColumna}2", NameEmpresa, 12, false, true, Back, Fore));
                //
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, dtgconten.ColumnHeadersDefaultCellStyle.Font, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                int PosInicialGrilla = 3;
                DataTable TableResuk = new DataTable();
                TableResuk = ((DataTable)dtgconten.DataSource).Copy();
                ///
                if (rdbAbonados.Checked)
                {
                    string[] Columnitas = { "opcion", "Abonos", "det" };
                    foreach (string item in Columnitas)
                    {
                        TableResuk.Columns.Remove(item);
                    }
                    //Cambio de Etiquetas de las Columnas
                    TableResuk.Columns["glosa"].ColumnName = "Nro Operación";
                    TableResuk.Columns["CuentaContable"].ColumnName = "Banco";
                    TableResuk.Columns["pagar"].ColumnName = "Pagado";
                }
                else
                {
                    string[] Columnitas = { "opcion", "Abonos", "cuo", "det" };
                    foreach (string item in Columnitas)
                    {
                        TableResuk.Columns.Remove(item);
                    }
                }
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableResuk, CeldaCabecera, CeldaDefault, "", _NombreHoja, Celdas, PosInicialGrilla, _Columnas, new int[] { }, new int[] { }, "");
            }
            else msg("No hay Registros en la Grilla");
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
            dtgconten.ResumeLayout();
        }
        int _TipoPago;
        private void rdbCertificadoBancario_CheckedChanged(object sender, EventArgs e)
        {
            PanelDepositoBanco.Visible = false;
            PanelCertificadoBancario.Visible = false;
            PanelDepositoPlazo.Visible = false;
            _TipoPago = 0;
            ////TipoPago = 0 Deposito Banco, 1 Certificado Bancario, 2 Deposito Plazo
            if (rdbPagoBanco.Checked)
            {
                PanelDepositoBanco.Visible = true;
                _TipoPago = 0;
            }
            if (rdbCertificadoBancario.Checked)
            {
                PanelCertificadoBancario.Visible = true;
                _TipoPago = 1;
            }
            if (rdbDepositoPLazo.Checked)
            {
                PanelDepositoPlazo.Visible = true;
                _TipoPago = 2;
            }
        }
        private void cbodepositoplazo_Click(object sender, EventArgs e)
        {
            string cade = cbodepositoplazo.Text;
            CargarDepositoAPlazo();
            cbodepositoplazo.Text = cade;
        }
        private void cboCertificadobancario_Click(object sender, EventArgs e)
        {
            string cade = cboCertificadobancario.Text;
            CargarDepositoAPlazo();
            cboCertificadobancario.Text = cade;
        }

        private void txtTotalPagar_TextChanged(object sender, EventArgs e)
        {
            decimal ValorPagar = 0, ValorPagado = 0;
            decimal.TryParse(txtTotalPagar.Text, out ValorPagar);
            decimal.TryParse(txttotalAbonado.Text, out ValorPagado);
            //
            txtCuentaExceso.ReadOnly = true;
            if (ValorPagado > ValorPagar || chkPenalidad.Checked)
            {
                txtCuentaExceso.ReadOnly = false;
            }
        }
        private void btnbuscarCuentas_Click(object sender, EventArgs e)
        {
            BuscarCuentas();
        }
        public void BuscarCuentas()
        {
            frmlistarcuentas cuentitas = new frmlistarcuentas();
            cuentitas.Txtbusca.Text = txtCuentaExceso.Text;
            cuentitas.radioButton1.Checked = true;
            cuentitas.ShowDialog();
            if (cuentitas.aceptar)
            {
                txtCuentaExceso.Text = cuentitas.codigo;
            }
        }
        private void txtCuentaExceso_DoubleClick(object sender, EventArgs e)
        {
            BuscarCuentas();
        }

        private void txtCuentaExceso_TextChanged(object sender, EventArgs e)
        {
            DataTable Table = CapaLogica.BuscarCuentas(txtCuentaExceso.Text, 1);
            if (Table.Rows.Count > 0)
            {
                txtDescripcionCuentaExceso.Text = (Table.Rows[0][0].ToString());
            }
            else
            {
                txtDescripcionCuentaExceso.CargarTextoporDefecto();
            }
        }
        private void txtCuentaExceso_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnbuscarCuentas.Enabled = !txtCuentaExceso.ReadOnly;
        }
        string _CuentaExceso = "4699111"; string _CuentaPenalidad = "7599101";
        private void chkPenalidad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPenalidad.Checked)
            {
                chkPenalidadTodo.Checked = false;
                lblCuentaExceso.Text = "Cuenta Penalidad:";
                if (!txtCuentaExceso.EstaLLeno()) txtCuentaExceso.Text = _CuentaPenalidad;
                txtCuentaExceso.TextoDefecto = _CuentaPenalidad;
                txtCuentaExceso.ReadOnly = false;
                lblmontoPenalidad.Visible = txtMontoPenalidad.Visible = true;
                cbobanco.Enabled = cbocuentabanco.Enabled = false;
                rdbPagoBanco.Enabled = rdbCertificadoBancario.Enabled = rdbDepositoPLazo.Enabled = false;
                CalcularMontoPenalidad();
            }
            else
            {
                lblCuentaExceso.Text = "Cuenta de Exceso:";
                if (!txtCuentaExceso.EstaLLeno()) txtCuentaExceso.Text = _CuentaExceso;
                txtCuentaExceso.TextoDefecto = _CuentaExceso;
                txtCuentaExceso.ReadOnly = decimal.Parse(txttotalAbonado.Text) > decimal.Parse(txtTotalPagar.Text) ? false : true;
                lblmontoPenalidad.Visible = txtMontoPenalidad.Visible = false;
                cbobanco.Enabled = cbocuentabanco.Enabled = true;
                rdbPagoBanco.Enabled = rdbCertificadoBancario.Enabled = rdbDepositoPLazo.Enabled = true;
            }
        }
        private void chkPenalidadTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPenalidadTodo.Checked)
            {
                chkPenalidad.Checked = false;
                lblCuentaExceso.Text = "Cuenta Penalidad:";
                if (!txtCuentaExceso.EstaLLeno()) txtCuentaExceso.Text = _CuentaPenalidad;
                txtCuentaExceso.TextoDefecto = _CuentaPenalidad;
                txtCuentaExceso.ReadOnly = false;
                lblmontoPenalidad.Visible = txtMontoPenalidad.Visible = true;
                cbobanco.Enabled = cbocuentabanco.Enabled = true;
                rdbPagoBanco.Enabled = rdbCertificadoBancario.Enabled = rdbDepositoPLazo.Enabled = true;
            }
            else
            {
                lblCuentaExceso.Text = "Cuenta de Exceso:";
                if (!txtCuentaExceso.EstaLLeno()) txtCuentaExceso.Text = _CuentaExceso;
                txtCuentaExceso.TextoDefecto = _CuentaExceso;
                txtCuentaExceso.ReadOnly = decimal.Parse(txttotalAbonado.Text) > decimal.Parse(txtTotalPagar.Text) ? false : true;
                lblmontoPenalidad.Visible = txtMontoPenalidad.Visible = false;
                rdbPagoBanco.Enabled = rdbCertificadoBancario.Enabled = rdbDepositoPLazo.Enabled = true;
                cbobanco.Enabled = cbocuentabanco.Enabled = true;
            }
        }
        private void txtMontoPenalidad_TextChanged(object sender, EventArgs e)
        {
            decimal pruebaAbonado = 0;
            decimal pruebaPenalidad = 0;
            decimal.TryParse(txttotalAbonado.Text, out pruebaAbonado);
            decimal.TryParse(txtMontoPenalidad.Text, out pruebaPenalidad);
            //txtMontoPenalidad.Text = pruebaPenalidad.ToString("n2");
            if (Math.Abs(pruebaPenalidad) > Math.Abs(pruebaAbonado))
            {
                txtMontoPenalidad.Text = Math.Abs(pruebaAbonado).ToString("n2");
            }
        }

        private void txtMontoPenalidad_Leave(object sender, EventArgs e)
        {
            //decimal pruebaAbonado = 0;
            //decimal pruebaPenalidad = 0;
            //decimal.TryParse(txttotalAbonado.Text, out pruebaAbonado);
            //decimal.TryParse(txtMontoPenalidad.Text, out pruebaPenalidad);
            ////txtMontoPenalidad.Text = pruebaPenalidad.ToString("n2");
            //if (Math.Abs(pruebaPenalidad) > Math.Abs(pruebaAbonado))
            //{
            //    txtMontoPenalidad.Text = Math.Abs(pruebaAbonado).ToString("n2");
            //}

        }
        string FacturaSelecionada = ""; string ClienteSelecionado = "";
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }
        public void FacturasRows()
        {
            if (dtgconten.CurrentCell != null)
            {
                FacturaSelecionada = dtgconten[xNroComprobante.Name, dtgconten.CurrentCell.RowIndex].Value.ToString();
                ClienteSelecionado = dtgconten[xTipoId.Name, dtgconten.CurrentCell.RowIndex].Value.ToString() + "-" + dtgconten[xCliente.Name, dtgconten.CurrentCell.RowIndex].Value.ToString();
            }
        }

        private void txtDescripcionCuentaExceso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
