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
    public partial class frmAbonosVentas : FormGradient
    {
        public frmAbonosVentas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmAbonosVentas_Load(object sender, EventArgs e)
        {
            ValoresPorDefecto();
            BusquedaDatos();
            dtpFechaContable.Value = dtpFechaPago.Value = DateTime.Now;
            cbobanco_Click(sender, e);
            cargarEmpresa();
            CargarCombos();
            txtglosa.CargarTextoporDefecto();
            txtnrooperacion.CargarTextoporDefecto();
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
            string name = cboempresa.Text;
            CapaLogica.TablaEmpresa(cboempresa);
            cboempresa.Text = name;
            FacturasSeleccionadasRecargar();
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
                decimal monto = (decimal)item.Cells[xpagar.Name].Value;
                ////si es valor es mayor o menor a cero
                if (dtgconten.Columns[xpagar.Name].Index == y)
                    if ((decimal)item.Cells[xpagar.Name].Value <= 0)//|| (decimal)item.Cells[xpagar.Name].Value > (decimal)item.Cells[xTotal.Name].Value)
                        item.Cells[xpagar.Name].Value = (decimal)item.Cells[xTotal.Name].Value;
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
            if (!señal)
            {
                if (SumaTotalPagada == 0)
                    btnaceptar.Enabled = false;
                else
                    btnaceptar.Enabled = true;
            }
            else if (SumaTotalPagada >= 0)
            {
                btnaceptar.Enabled = true;
            }
            else btnaceptar.Enabled = false;
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
            if (dtgconten.Columns[xAbonos.Name].Index == y)
            {
                if (dtgconten[xAbonos.Name, x].Value.ToString() != "")
                {
                    if (rdbporAbonar.Checked)
                    {
                        if (frmdetallepago == null)
                        {
                            frmdetallepago = new frmDetallePagoFactura(2, dtgconten[xNroComprobante.Name, e.RowIndex].Value.ToString(), (int)dtgconten[xTipoId.Name, e.RowIndex].Value, dtgconten[xCliente.Name, e.RowIndex].Value.ToString());
                            frmdetallepago.FormClosed += Frmdetallepago_FormClosed;
                            frmdetallepago.MdiParent = MdiParent;
                            frmdetallepago.Show();
                        }
                        else frmdetallepago.Activate();
                    }
                    if (rdbAbonados.Checked)
                    {
                        frmDetalleNroOp frmnroop = new frmDetalleNroOp(dtgconten[xCliente.Name, x].Value.ToString(), dtgconten[xNombres.Name, x].Value.ToString(), dtgconten[xNroComprobante.Name, x].Value.ToString(), dtgconten[xCuentaContable.Name, x].Value.ToString());
                        frmnroop.Codigo = (int)dtgconten[xId.Name, x].Value;
                        frmnroop.nrooperacion = dtgconten[xGlosa.Name, x].Value.ToString();
                        frmnroop.Empresa = (int)cboempresa.SelectedValue;
                        //tipodet ==5 factura venta manual
                        frmnroop.Tipodet = 5;
                        frmnroop.ShowDialog();
                        BusquedaDatos();
                    }
                }
            }
        }
        frmTipodeCambio frmtipo;
        private void Frmdetallepago_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmdetallepago = null;
        }
        frmDetallePagoFactura frmdetallepago;
        public string NameEmpresa { get; private set; }

        public void SacarTipoCambio()
        {
            DateTime FechaValidaBuscar = dtpFechaPago.Value;
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
        public DialogResult msgyes(string cadena) { return HPResergerFunciones.Utilitarios.msgYesNo(cadena); }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (ListaFacturas.Count > 0)
            {
                if (msgyes("Seguro Desea Salir") == DialogResult.Yes) this.Close();
            }
            else this.Close();
        }
        public class Cuentas
        {
            public string _Cuenta;
            public decimal _MOnto;
            public int _tipo;
            public Cuentas(string cuenta, decimal monto, int tipo)
            {
                _Cuenta = cuenta;
                _MOnto = monto;
                _tipo = tipo;
            }
        }
        public void msg(string cadena) { HPResergerFunciones.Utilitarios.msg(cadena); }
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
            ////validaciones 
            if (decimal.Parse(txttipocambio.Text) <= 0) { msg("Revise el Tipo de Cambio"); dtpFechaPago_ValueChanged(sender, e); txttipocambio.Focus(); return; }
            CalcularDiferencial();
            ListCuentas.Clear();
            int contador = 0;
            //if (decimal.Parse(txttotal.Text) <= 0) { msg("No se Puede Abonar Cero"); return; }
            if (decimal.Parse(txttotalAbonado.Text) != 0)
            {
                if (!txtnrooperacion.EstaLLeno()) { msg("Ingrese Número de Operación"); txtnrooperacion.Focus(); return; }
                if (rdbPagoBanco.Checked)
                {
                    if (cbocuentabanco.Items.Count == 0) { msg("El Banco Seleccionado no tiene Cuentas"); cbobanco.Focus(); return; }
                    if (cbocuentabanco.SelectedValue == null) { msg("Selecione Cuentas Bancaria"); cbocuentabanco.Focus(); return; }
                    if (cbobanco.Items.Count == 0) { msg("No hay Bancos"); cboempresa.Focus(); return; }
                    if (cbobanco.SelectedValue == null) { msg("Selecione Bancos"); cbobanco.Focus(); return; }
                }
                if (rdbDepositoPLazo.Checked)
                {
                    if (cbodepositoplazo.Items.Count == 0) { msg("No hay Cuentas de Deposito a Plazo"); cbodepositoplazo.Focus(); return; }
                    if (cbodepositoplazo.SelectedValue == null) { msg("Selecione Cuenta de Deposito a Plazo"); cbodepositoplazo.Focus(); return; }
                }
                if (rdbCertificadoBancario.Checked)
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
                    if (Cuentita == null) ListCuentas.Add(new Cuentas(item.Cells[xCuentaContable.Name].Value.ToString(), ContenedorNotasCredito.Contains(Valtipo) ? -1 * (decimal)item.Cells[xpagar.Name].Value : (decimal)item.Cells[xpagar.Name].Value, Notas));
                    else
                    {
                        if (ContenedorNotasCredito.Contains(Valtipo)) { Cuentita._MOnto -= (decimal)item.Cells[xpagar.Name].Value; }
                        else { Cuentita._MOnto += (decimal)item.Cells[xpagar.Name].Value; }
                    }
                }
            }
            if (contador == 0) { msg("Selecione Facturas"); dtgconten.Focus(); return; }
            string nroKuenta = "";
            int numasiento = 0;
            if (numasiento == 0)
            {
                DataTable asientito = CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, dtpFechaContable.Value);
                DataRow asiento = asientito.Rows[0];
                if (asiento == null) { numasiento = 1; }
                else
                    numasiento = ((int)asiento["codigo"]);
            }
            int ContadorFilaDiferencial = contador + 2;
            string cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, dtpFechaContable.Value);
            string CuentaBanco = "";
            string Banko = "";
            ////
            if (decimal.Parse(txttotalAbonado.Text) != 0)
            {
                if (rdbPagoBanco.Checked) { CuentaBanco = cbocuentabanco.SelectedValue.ToString(); nroKuenta = HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text); Banko = cbobanco.SelectedValue.ToString(); }
                if (rdbDepositoPLazo.Checked) { CuentaBanco = cbodepositoplazo.SelectedValue.ToString(); Banko = "-1"; }
                if (rdbCertificadoBancario.Checked) { CuentaBanco = cboCertificadobancario.SelectedValue.ToString(); Banko = "-2"; }
            }
            ////
            int proyecto = 0, etapa = 0, moneda = 1;
            foreach (DataGridViewRow item in dtgconten.Rows)
                if ((int)item.Cells[xopcion.Name].Value == 1) { proyecto = (int)item.Cells[xfkproyecto.Name].Value; etapa = (int)item.Cells[xfketapa.Name].Value; moneda = (int)item.Cells[xMoneda.Name].Value; break; }
            ////CABECERA DE LOS ASIENTOS
            int PosFila = 1;
            //CUENTA BANCO
            if (decimal.Parse(txttotalAbonado.Text) > 0)
                CapaLogica.InsertarAsientoFacturaCabecera(1, PosFila, numasiento, dtpFechaContable.Value, CuentaBanco, decimal.Parse(txttotalAbonado.Text), 0, decimal.Parse(txttipocambio.Text), proyecto, etapa, cuo, moneda, txtglosa.TextValido(), dtpFechaPago.Value, -7);
            foreach (Cuentas item in ListCuentas)
            {
                //CUENTAS DE LAS FACTURAS
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, dtpFechaContable.Value, item._Cuenta, item._MOnto < 0 ? Math.Abs(item._MOnto) : 0, item._MOnto < 0 ? 0 : Math.Abs(item._MOnto), decimal.Parse(txttipocambio.Text), proyecto, etapa, cuo, moneda, txtglosa.TextValido(), dtpFechaPago.Value, -7);
            }
            //CUENTA DIFERENCIA DE CAMBIO
            if (decimal.Parse(txttotaldiferencial.Text) != 0)
                CapaLogica.InsertarAsientoFacturaCabecera(2, ++PosFila, numasiento, dtpFechaContable.Value, "", decimal.Parse(txttotaldiferencial.Text), 0, decimal.Parse(txttipocambio.Text), proyecto, etapa, cuo, moneda, txtglosa.TextValido(), dtpFechaPago.Value, -7);
            ////FIN DE LAS CABECERAS
            ////DETALLE DE LOS ASIENTOS
            PosFila = 1;
            ////LOS BANCOS
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if ((int)item.Cells[xopcion.Name].Value == 1)
                {
                    string[] valor = item.Cells[xNroComprobante.Name].Value.ToString().Split('-');
                    DateTime fecha = DateTime.Now;
                    int Multiplicador = 1;
                    if (ContenedorNotasCredito.Contains(item.Cells[xIdComprobante.Name].Value.ToString())) Multiplicador = -1;
                    CapaLogica.InsertarAsientoFacturaDetalle(1, PosFila, numasiento, dtpFechaContable.Value, CuentaBanco, proyecto, (int)item.Cells[xTipoId.Name].Value, item.Cells[xCliente.Name].Value.ToString()
                        , item.Cells[xNombres.Name].Value.ToString(), (int)item.Cells[xIdComprobante.Name].Value, valor[0], valor[1], 0, fecha, fecha, fecha, Multiplicador * (decimal)item.Cells[xpagar.Name].Value,
                      Multiplicador * (decimal)item.Cells[xTotal.Name].Value, decimal.Parse(txttipocambio.Text), (int)item.Cells[xMoneda.Name].Value, nroKuenta, txtnrooperacion.TextValido(), txtglosa.TextValido(),
                      dtpFechaPago.Value, frmLogin.CodigoUsuario, "");
                }
            }
            ////LISTADO DE CUENTAS
            foreach (Cuentas items in ListCuentas)
            {
                PosFila++;
                foreach (DataGridViewRow item in dtgconten.Rows)
                    if ((int)item.Cells[xopcion.Name].Value == 1)
                    {
                        int Notas = (int)item.Cells[xIdComprobante.Name].Value; if (ContenedorIdNotas.Contains(Notas)) { } else Notas = 0;
                        if (item.Cells[xCuentaContable.Name].Value.ToString() == items._Cuenta && items._tipo == Notas)
                        {
                            string[] valor = item.Cells[xNroComprobante.Name].Value.ToString().Split('-');
                            DateTime fecha = DateTime.Now;
                            CapaLogica.InsertarAsientoFacturaDetalle(1, PosFila, numasiento, dtpFechaContable.Value, items._Cuenta, proyecto, (int)item.Cells[xTipoId.Name].Value, item.Cells[xCliente.Name].Value.ToString()
                                , item.Cells[xNombres.Name].Value.ToString(), (int)item.Cells[xIdComprobante.Name].Value, valor[0], valor[1], 0, fecha, fecha, fecha, (decimal)item.Cells[xpagar.Name].Value,
                                 (decimal)item.Cells[xTotal.Name].Value, item.Cells[xNameCorto.Name].Value.ToString() == "USD" ? (decimal)item.Cells[xTC.Name].Value : decimal.Parse(txttipocambio.Text),
                                 (int)item.Cells[xMoneda.Name].Value, nroKuenta, txtnrooperacion.TextValido(), txtglosa.TextValido(), dtpFechaPago.Value, frmLogin.CodigoUsuario, "");

                        }
                    }
            }
            PosFila++;
            /////Diferencial de Cambio
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if ((int)item.Cells[xopcion.Name].Value == 1)
                {
                    if (item.Cells[xNameCorto.Name].Value.ToString() == "USD")
                    {
                        decimal Dif = Configuraciones.Redondear((decimal)item.Cells[xpagar.Name].Value * decimal.Parse(txttipocambio.Text)) - Configuraciones.Redondear((decimal)item.Cells[xpagar.Name].Value * (decimal)item.Cells[xTC.Name].Value);
                        Dif = (ContenedorNotasCredito.Contains(item.Cells[xIdComprobante.Name].Value.ToString()) ? 1 : -1) * Dif;
                        if (Math.Abs(Dif) > 0)
                        {
                            string[] valor = item.Cells[xNroComprobante.Name].Value.ToString().Split('-');
                            DateTime fecha = DateTime.Now;
                            CapaLogica.InsertarAsientoFacturaDetalle(2, PosFila, numasiento, dtpFechaContable.Value, CuentaBanco, proyecto, (int)item.Cells[xTipoId.Name].Value, item.Cells[xCliente.Name].Value.ToString()
                                , item.Cells[xNombres.Name].Value.ToString(), (int)item.Cells[xIdComprobante.Name].Value, valor[0], valor[1], 0, fecha, fecha, fecha, Dif,
                                 decimal.Parse(txttotaldiferencial.Text), decimal.Parse(txttipocambio.Text), (int)item.Cells[xMoneda.Name].Value, nroKuenta,
                                 txtnrooperacion.TextValido(), txtglosa.TextValido(), dtpFechaPago.Value, frmLogin.CodigoUsuario, "");
                        }
                    }
                }
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
                        CapaLogica.ActualizarNotaCreditoDebito(item.Cells[xTipoId.Name].Value.ToString() + item.Cells[xCliente.Name].Value.ToString(), item.Cells[xNroComprobante.Name].Value.ToString(), 2, (int)cboempresa.SelectedValue);
                    else
                        CapaLogica.FacturaVentaManualPago(opcion, (int)item.Cells[xIdComprobante.Name].Value, item.Cells[xNroComprobante.Name].Value.ToString(), txtnrooperacion.Text, (int)item.Cells[xTipoId.Name].Value,
                            item.Cells[xCliente.Name].Value.ToString(), (int)cboempresa.SelectedValue, (decimal)item.Cells[xpagar.Name].Value, (decimal)item.Cells[xTC.Name].Value, Banko,
                            nroKuenta, dtpFechaPago.Value, cuo, frmLogin.CodigoUsuario);
                }
            }
            //#region   Cuadrar Asiento
            //CapaLogica.CuadrarAsiento(cuo, proyecto, dtpFechaPago.Value, 2);
            //#endregion Fin Cuadrar Asiento
            msg($"Facturas Abonadas\nCon Asiento {cuo}");
            txttotalAbonado.Text = txttotaldiferencial.Text = "0.00";
            ////txtnrooperacion.CargarTextoporDefecto();txtglosa.CargarTextoporDefecto();
            ListaFacturas.Clear();
            cboCuentaExceso.Enabled = false;
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
            if (y == dtgconten.Columns[xpagar.Name].Index)
            {
                if (ContenedorIdNotas.Contains((int)dtgconten[xIdComprobante.Name, x].Value))
                {
                    dtgconten[y, x].ReadOnly = true;
                    dtgconten.CancelEdit();
                }
                else
                    dtgconten[y, x].ReadOnly = false;
            }
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
                    frmDetalleNroOp frmnroop = new frmDetalleNroOp(dtgconten[xCliente.Name, x].Value.ToString(), dtgconten[xNombres.Name, x].Value.ToString(), dtgconten[xNroComprobante.Name, x].Value.ToString(), dtgconten[xAbonos.Name, x].Value.ToString());
                    frmnroop.Codigo = (int)dtgconten[xId.Name, x].Value;
                    frmnroop.nrooperacion = dtgconten[xGlosa.Name, x].Value.ToString();
                    frmnroop.Empresa = (int)cboempresa.SelectedValue;
                    //tipodet ==5 factura venta manual
                    frmnroop.Tipodet = 5;
                    frmnroop.ShowDialog();
                    BusquedaDatos();
                }
            }
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
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "b2", "Nombre Vendedor:", 11));
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", _NombreHoja, Celdas, 2, _Columnas, new int[] { }, new int[] { });
                //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", "Cronograma de Pagos", Celdas, 2, new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { }, new int[] { });
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
            cboCuentaExceso.Enabled = false;
            if (ValorPagado > ValorPagar)
            {
                cboCuentaExceso.Enabled = true;
            }

        }
    }
}
