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

namespace HPReserger.ModuloCompensaciones
{
    public partial class frmAnticipoProveedores : FormGradient
    {
        public frmAnticipoProveedores()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmAnticipoProveedores_Load(object sender, EventArgs e)
        {
            txtglosa.CargarTextoporDefecto(); txtImporteTotal.CargarTextoporDefecto();
            txtnrocheque.CargarTextoporDefecto();
            dtpFechaContable.Value = dtpFechaCompensa.Value = DateTime.Now;
            CargarMoneda();
            CargarEmpresa();
            CargarProveedores();
            cbopago.SelectedIndex = 0;
        }
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
        public void CargarEmpresa() { CapaLogica.TablaEmpresas(cboempresa); }
        public void CargarProveedores() { CapaLogica.TablaProveedores(cboproveedor, 0); }
        private void cboempresa_SelectedValueChanged(object sender, EventArgs e)
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
                }
            }
        }
        private void cboempleado_Click(object sender, EventArgs e)
        {
            string cadena = cboproveedor.Text;
            cboproveedor.SuspendLayout();
            CargarProveedores();
            cboproveedor.ResumeLayout();
            cboproveedor.Text = cadena;
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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ContarRegistros()
        {
            lbltotalregistros.Text = $"Total de Registros: {dtgconten.RowCount}";
        }
        private void cboempleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///mostramos datos
            if (cboproveedor.SelectedValue != null)
            {
                string[] valor = cboproveedor.SelectedValue.ToString().Split('-');
                DataTable Table = CapaLogica.ListarCompensaciones(_idempresa, 4, int.Parse(valor[0]), valor[1]);
                dtgconten.DataSource = Table;
            }
            ContarRegistros();
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
            if (cbocuentaxpagar.SelectedValue == null)
            {
                msg("Seleccione la Cuenta de Anticipos");
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
            if (!txtnrocheque.EstaLLeno())
            {
                msg("Ingrese Nro Operación-Cheque");
                txtnrocheque.Focus(); return;
            }
            if (cbocuentabanco.SelectedValue == null)
            {
                msg("Seleccione la cuenta del Abono");
                cbocuentabanco.Focus(); return;
            }
            if (decimal.Parse(txtImporteTotal.Text) <= 0)
            {
                msg("El monto del Desembolso debe ser Mayor a Cero");
                dtgconten.Focus(); return;
            }
            if (decimal.Parse(txttipocambio.Text) == 0)
            {
                msg("El monto del Tipo de Cambio no debe ser Cero");
                txttipocambio.Focus(); return;
            }

            if (msgOk("¿Seguro Desea Hacer el Anticipo?") == DialogResult.OK)
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
                string cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, dtpFechaContable.Value);
                int moneda = (int)cbomoneda.SelectedValue;
                int proyecto = (int)cboproyecto.SelectedValue;
                string CuentaAnticipo = cbocuentaxpagar.SelectedValue.ToString();
                string[] Proveedor = cboproveedor.SelectedValue.ToString().Split('-');
                int TipoIdProveedor = int.Parse(Proveedor[0]);
                string RucProveedor = Proveedor[1];
                string NameProveedor = cboproveedor.Text;
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
                //Debe
                //Asiento del Anticipo
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaAnticipo, moneda == 1 ? MontoSoles : MontoDolares, 0, tc,
                    proyecto, 0, cuo, moneda, glosa, dtpFechaCompensa.Value, -9);
                //Detalle del asiento
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, dtpFechaContable.Value, CuentaAnticipo, proyecto, TipoIdProveedor, RucProveedor
                    , NameProveedor, 0, "0", "0", 0, FechaContable, FechaCompensa, FechaCompensa, MontoSoles, MontoDolares, tc, moneda, "", "", glosa, FechaCompensa, frmLogin.CodigoUsuario, "");
                //Haber
                //Asiento del salida del Banco
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, BanCuenta, 0, moneda == 1 ? MontoSoles : MontoDolares, tc,
                    proyecto, 0, cuo, moneda, glosa, dtpFechaCompensa.Value, -9);
                //Detalle del asiento
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, dtpFechaContable.Value, BanCuenta, proyecto, TipoIdProveedor, RucProveedor
                    , NameProveedor, 0, "0", "0", 0, FechaContable, FechaCompensa, FechaCompensa, MontoSoles, MontoDolares, tc, moneda, nroKuenta, "", glosa, FechaCompensa, frmLogin.CodigoUsuario, "");
                //Inserto compensaciones!
                CapaLogica.InsertarCompensaciones((int)cboempresa.SelectedValue, 4, TipoIdProveedor, RucProveedor, MontoSoles, MontoDolares, cuo, cbopago.SelectedIndex == 0 ? 3 : 7, nroKuenta, txtnrocheque.TextValido(),
                    $"{Configuraciones.MayusculaCadaPalabra(cboproveedor.Text)} {dtpFechaCompensa.Value.ToString("d")}", dtpFechaCompensa.Value, 2, CuentaAnticipo, "");
                //
                //Cuadre Asiento
                CapaLogica.CuadrarAsiento(cuo, proyecto, dtpFechaContable.Value, 2);
                //Fin Cuadre
                msg($"Se Generó el Anticipo con cuo {cuo}");
                cboempleado_SelectedIndexChanged(sender, e);
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
        private void cbomoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbocuentaxpagar.ValueMember = "idcuenta";
            cbocuentaxpagar.DisplayMember = "Cuenta_contable";
            cbocuentaxpagar.DataSource = CargarCuentasxPagar();
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

        private void cbocuentaxpagar_Click(object sender, EventArgs e)
        {
            DataTable Tablecuentas = CargarCuentasxPagar();
            if (Tablecuentas.Rows.Count != ((DataTable)cbocuentaxpagar.DataSource ?? new DataTable()).Rows.Count)
            {
                string cadena = cbocuentaxpagar.Text;
                cbocuentaxpagar.DataSource = Tablecuentas;
                cbocuentaxpagar.Text = cadena;
            }
        }

        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btnaceptar.Enabled = true;
            //cboproveedor.DisplayMember = "empleado";
            //cboproveedor.ValueMember = "UsuarioCompensacion";
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
                    cboempleado_SelectedIndexChanged(sender, e);
                }
            }
        }
        frmListarCompensacionesAnticipo frmliscompensaAnticipo;
        private void btn_Click(object sender, EventArgs e)
        {
            if (frmliscompensaAnticipo == null)
            {
                frmliscompensaAnticipo = new frmListarCompensacionesAnticipo((int)cboempresa.SelectedValue, cboproveedor.Text);
                frmliscompensaAnticipo.FormClosed += FrmliscompensaAnticipo_FormClosed;
                frmliscompensaAnticipo.MdiParent = this.MdiParent;
                frmliscompensaAnticipo.Show();
            }
            else
            {
                frmliscompensaAnticipo.Activate();
            }
        }

        private void FrmliscompensaAnticipo_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmliscompensaAnticipo = null;
            cboempleado_SelectedIndexChanged(sender, e);
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

        private void cboempresa_Click(object sender, EventArgs e)
        {
            string cadena = cboempresa.Text;
            DataTable Table = CapaLogica.Empresa();
            if (cboempresa.Items.Count != Table.Rows.Count)
                cboempresa.DataSource = Table;
            cboempresa.Text = cadena;
        }
    }
}
