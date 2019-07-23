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
    public partial class frmEntregaRendir : FormGradient
    {
        public frmEntregaRendir()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmEntregaRendir_Load(object sender, EventArgs e)
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
            DataTable TablePagar = CapaLogica.BuscarCuentas($"%14%entregas a rendir%{tipomoneda}", 5, "D");
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
            dtgconten.DataSource = CapaLogica.ListarCompensaciones(_idempresa, 3, 0, "");
            lbltotalregistros.Text = $"Total de Registros {dtgconten.RowCount}";
            if (dtgconten.RowCount > 0) btnmodificar.Enabled = true; else btnmodificar.Enabled = false;
            PasarTipoOracion(xcliente);
        }
        public void PasarTipoOracion(DataGridViewColumn col)
        {
            foreach (DataGridViewRow item in dtgconten.Rows)
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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (Estado == 2)
            {
                ModoEdicion(false);
                BloquearPago(false);
                Estado = 0;
                CargarDatos();
            }
            else if (Estado == 0)
                this.Close();
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
            cboempleado.Enabled = cboempresa.Enabled = btnbusEmpleado.Enabled = cboproyecto.Enabled = !a;
            cbomoneda.Enabled = cbocuentaxpagar.Enabled = !a;
            txtPorAbonar.Visible = a; lblabonar.Visible = a;
            dtgconten.Enabled = !a;
            //dtpFechaCompensa.Enabled = !a;
        }
        public void BloquearPago(Boolean a)
        {
            cbopago.Enabled = cbobanco.Enabled = cbocuentabanco.Enabled = txtnrocheque.Enabled = !a;
            btnaceptar.Enabled = !a;
        }
        public void ImporteTotalCambio()
        {
            if (Estado == 2)
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
            txtPorAbonar.Text = (ImporteDelFondo).ToString("n2");
        }

        private void txtImporteTotal_TextChanged(object sender, EventArgs e)
        {
            ImporteTotalCambio();
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
                msg("Seleccione la cuenta de Entregas a Rendir");
                cbocuentabanco.Focus(); return;
            }
            if (!txtnrocheque.EstaLLeno())
            {
                msg("Ingrese Nro Operacion/Cheque");
                txtnrocheque.Focus(); return;
            }
            if (decimal.Parse(txtImporteTotal.Text) <= 0)
            {
                msg("El Monto de la Entrega a Rendir debe ser mayor a Cero");
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
            if (!CapaLogica.VerificarPeriodoAbierto((int)cboempresa.SelectedValue, dtpFechaContable.Value))
            {
                msg("El Periodo Esta Cerrado, Cambie Fecha Contable"); dtpFechaContable.Focus(); return;
            }
            string NumID = "0";
            if (dtgconten.CurrentCell != null) NumID = dtgconten[xpkid.Name, dtgconten.CurrentCell.RowIndex].Value.ToString();
            string CuentaFondoFijo = cbocuentaxpagar.SelectedValue.ToString();
            if (cboempleado.SelectedValue == null) { msg("Seleccione un Empleado"); cboempleado.Focus(); return; }
            string[] empleado = cboempleado.SelectedValue.ToString().Split('-');
            //DataTable Filita = CapaLogica.FondoFijoVeriricarExistencia(_idempresa, int.Parse(empleado[0]), empleado[1], CuentaFondoFijo, int.Parse(NumID));
            //if (Filita.Rows.Count > 0)
            //{
            //    msg("Este Empleado Ya tiene un Fondo Fijo Activo");
            //    return;
            //}
            ///MODIFICAR
            if (Estado == 2)
            {
                decimal PorAbonar = decimal.Parse(txtPorAbonar.Text);
                if (PorAbonar == 0)
                {
                    txtImporteTotal.Focus();
                    msg("Debe Ingresar el Nuevo Monto de la Entrega a Rendir"); return;
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
                if (msgOk("¿Seguro Desea Actualizar la Entrega a Rendir?") == DialogResult.OK)
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
                    string nroOperacion = txtnrocheque.TextValido();
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
                    ///
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaFondoFijo, PorAbonar > 0 ? Math.Abs(moneda == 1 ? MontoSoles : MontoDolares) : 0,
                         PorAbonar < 0 ? Math.Abs(moneda == 1 ? MontoSoles : MontoDolares) : 0, tc, proyecto, 0, Cuo, moneda, glosa, FechaCompensa, -14);
                    //Detalle del asiento
                    CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, dtpFechaContable.Value, CuentaFondoFijo, proyecto, TipoId, Numdoc
                        , NameEmpleado, 0, FechaCompensa.ToString("yyyyMMdd"), NumID, 0, FechaContable, FechaVence, FechaCompensa, Math.Abs(MontoSoles), Math.Abs(MontoDolares), tc, moneda, "", "", glosa, FechaCompensa, frmLogin.CodigoUsuario, " ");
                    //Haber
                    //Asiento del salida del Banco
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, BanCuenta, PorAbonar < 0 ? Math.Abs(moneda == 1 ? MontoSoles : MontoDolares) : 0,
                         PorAbonar > 0 ? Math.Abs(moneda == 1 ? MontoSoles : MontoDolares) : 0, tc, proyecto, 0, Cuo, moneda, glosa, FechaCompensa, -14);
                    //Detalle del asiento
                    CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, dtpFechaContable.Value, BanCuenta, proyecto, TipoId, Numdoc
                        , NameEmpleado, 0, FechaCompensa.ToString("yyyyMMdd"), NumID, 0, FechaContable, FechaVence, FechaCompensa, Math.Abs(MontoSoles), Math.Abs(MontoDolares), tc, moneda, nroKuenta, nroOperacion, glosa, FechaCompensa, frmLogin.CodigoUsuario, " ");
                    //Inserto compensaciones!
                    CapaLogica.CompensacionesActualizar(int.Parse(NumID), _idempresa, 3, TipoId, Numdoc, MontoSolesNew, MontoDolaresNew, Cuo, cbopago.SelectedIndex == 0 ? 7 : 3, nroKuenta, nroOperacion,
                        $"{FechaCompensa.ToString("d")} {Configuraciones.MayusculaCadaPalabra(NameEmpleado)}", FechaCompensa, 2, CuentaFondoFijo, "");
                    //
                    //Cuadre Asiento
                    CapaLogica.CuadrarAsiento(Cuo, proyecto, FechaContable, 2);
                    //Fin Cuadre              
                    msg($"Se Actualizo la Entrega a Rendir con Cuo {Cuo}");
                    ModoEdicion(false);
                    BloquearPago(false);
                    Estado = 0;
                    CargarDatos();
                }

            }
            //Creacion de la entrega a rendir
            else if (msgOk("¿Seguro Desea Crear la Entrega a Rendir?") == DialogResult.OK)
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
                NumID = (CapaLogica.SiguienteIDCompensaciones(_idempresa, 3).Rows[0]["valor"].ToString()); //1= Fondo Fijo
                //Debe
                //Asiento del Anticipo
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaFondoFijo, moneda == 1 ? MontoSoles : MontoDolares, 0, tc,
                    proyecto, 0, Cuo, moneda, glosa, dtpFechaCompensa.Value, -14);
                //Detalle del asiento
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, dtpFechaContable.Value, CuentaFondoFijo, proyecto, TipoId, Numdoc
                    , NameEmpleado, 0, FechaCompensa.ToString("yyyyMMdd"), NumID, 0, FechaContable, FechaVence, FechaCompensa, MontoSoles, MontoDolares, tc, moneda, "", "", glosa, FechaCompensa, frmLogin.CodigoUsuario, "  ");
                //Haber
                //Asiento del salida del Banco
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, BanCuenta, 0, moneda == 1 ? MontoSoles : MontoDolares, tc,
                    proyecto, 0, Cuo, moneda, glosa, dtpFechaCompensa.Value, -14);
                //Detalle del asiento
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, dtpFechaContable.Value, BanCuenta, proyecto, TipoId, Numdoc
                    , NameEmpleado, 0, FechaCompensa.ToString("yyyyMMdd"), NumID, 0, FechaContable, FechaVence, FechaCompensa, MontoSoles, MontoDolares, tc, moneda, nroKuenta, txtnrocheque.Text, glosa, FechaCompensa, frmLogin.CodigoUsuario, " ");
                //Inserto compensaciones!
                CapaLogica.InsertarCompensaciones(_idempresa, 3, TipoId, Numdoc, MontoSoles, MontoDolares, Cuo, cbopago.SelectedIndex == 0 ? 7 : 3, nroKuenta, txtnrocheque.TextValido(),
                    $"{dtpFechaCompensa.Value.ToString("d")} {Configuraciones.MayusculaCadaPalabra(NameEmpleado)}", dtpFechaCompensa.Value, 2, CuentaFondoFijo, "");
                //
                //Cuadre Asiento
                CapaLogica.CuadrarAsiento(Cuo, proyecto, dtpFechaContable.Value, 2);
                //Fin Cuadre              
                msg($"Se Creó la Entrega a Rendir con Cuo {Cuo}");
                CargarDatos();
            }
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
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cboempresa.SelectedValue != null)
            {
                CargarDatos();
            }
        }
    }
}
