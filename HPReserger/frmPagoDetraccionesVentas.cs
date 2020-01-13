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
    public partial class frmPagoDetraccionesVentas : FormGradient
    {
        public frmPagoDetraccionesVentas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void frmPagoDetraccionesVentas_Load(object sender, EventArgs e)
        {
            DataRow Filita = CapaLogica.VerUltimoIdentificador("TBL_Factura", "Nro_DocPago");
            if (Filita != null)
                txtnropago.Text = (decimal.Parse(Filita["ultimo"].ToString()) + 1).ToString();
            else txtnropago.Text = "1";
            // CargarTiposID("TBL_Tipo_ID");
            cargarempresas();
            //cbotipo.SelectedIndex = 0;
            Detracion = new List<Detracciones>();
            CargarDAtos();
            dtpFechaPago.Value = dtpFechaContable.Value = DateTime.Now;
            txtglosa.CargarTextoporDefecto();
            txtcuentadetracciones.CargarTextoporDefecto(); txtnrooperacion.CargarTextoporDefecto();
            CargarTipoPagos();
        }
        public void CargarTipoPagos()
        {
            cbotipo.DisplayMember = "mediopago";
            cbotipo.ValueMember = "codsunat";
            cbotipo.DataSource = CapaLogica.ListadoMedioPagos();
            if (cbotipo.Items.Count > 0) cbotipo.SelectedValue = 3;
        }
        public void cargarempresas()
        {
            CapaLogica.TablaEmpresa(cboempresa);
        }
        Boolean Cargado;
        public void CargarDAtos()
        {
            Cursor = Cursors.WaitCursor;
            Cargado = false;
            dtgconten.DataSource = CapaLogica.DetraccionesPorPAgarVentas((int)cboempresa.SelectedValue);
            NumRegistrosdtg();
            SeleccionarDetracionesSeleccionadas();
            CalcularValoresRedondeoyDiferencia();
            Cursor = Cursors.Default;
            Cargado = true;
            CalcularTotal();
        }
        public void CalcularValoresRedondeoyDiferencia()
        {
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                item.Cells[xredondeo.Name].Value = Math.Round((decimal)item.Cells[ImportePEN.Name].Value);
                if (decimal.Parse(item.Cells[xredondeo.Name].Value.ToString()) < 1)
                    item.Cells[xredondeo.Name].Value = 1;
                //  item.Cells[xDiferencia.Name].Value = (decimal)item.Cells[porpagarx.Name].Value - (decimal)item.Cells[xRedondeo.Name].Value;
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
        public void SeleccionarDetracionesSeleccionadas()
        {
            if (Detracion != null)
                foreach (DataGridViewRow item in dtgconten.Rows)
                {
                    foreach (Detracciones det in Detracion)
                    {
                        if (item.Cells[nrofacturax.Name].Value.ToString() == det._nrodetracion && item.Cells[Clientex.Name].Value.ToString() == det._proveedor && det._idComprobante == (int)item.Cells[xtipocomprobante.Name].Value)
                        {
                            item.Cells[opcionx.Name].Value = 1;
                        }
                    }
                }
        }
        public void NumRegistrosdtg()
        {
            lblmensaje.Text = $"Número de Registros={dtgconten.RowCount}";
        }
        private void btnseleccion_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Cargado = false;
            if (btnseleccion.Text == "Seleccionar Todo")
            {
                foreach (DataGridViewRow item in dtgconten.Rows)
                {
                    item.Cells[opcionx.Name].Value = 1;
                    btnseleccion.Text = "Deseleccionar Todo";
                }
            }
            else
            {
                btnseleccion.Text = "Seleccionar Todo";
                foreach (DataGridViewRow item in dtgconten.Rows)
                {
                    item.Cells[opcionx.Name].Value = 0;
                }
            }
            Cargado = true;
            CalcularTotal();
            Cursor = Cursors.Default;
        }
        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgconten.Columns[opcionx.Name].Index)
            {
                dtgconten.EndEdit();
            }
        }
        decimal sumatoria = 1000;
        public class Detracciones
        {
            public string _nrodetracion;
            public string _proveedor;
            public decimal _monto;
            public int _idComprobante;
            public Detracciones(string nrofactura, string proveedor, decimal monto, int idcomprobantes)
            {
                _nrodetracion = nrofactura;
                _proveedor = proveedor;
                _monto = monto;
                _idComprobante = idcomprobantes;
            }
        }
        List<Detracciones> Detracion; private string _NameEmpresa;
        public string NameEmpresa
        {
            get { return _NameEmpresa; }
            set
            {
                if (value != NameEmpresa)
                    Detracion.Clear();
                _NameEmpresa = value;
            }
        }
        private void cboempresa_Click(object sender, EventArgs e)
        {
            string cadena = cboempresa.Text;
            Nameproyecto = cboproyecto.Text;
            DataTable TAble = CapaLogica.TablaEmpresa();
            if (NameEmpresa != cadena)
            {
                cboempresa.DataSource = TAble;
                cboempresa.Text = cadena;
            }
            CargarProyecto();
        }
        public void CargarProyecto()
        {
            if (cboempresa.SelectedValue != null)
            {
                cboproyecto.DataSource = CapaLogica.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString());
                cboproyecto.DisplayMember = "proyecto";
                cboproyecto.ValueMember = "id_proyecto";
            }
            cboproyecto.Text = Nameproyecto;
        }
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nameproyecto = cboproyecto.Text;
            if (cbobanco.SelectedValue != null && NameEmpresa != cboempresa.Text)
            {
                Cursor = Cursors.WaitCursor;
                CargarCuentasBancos();
                NameEmpresa = cboempresa.Text;
                CargarDAtos();
            }
            CargarProyecto();
            BuscarCuentaDetracicones();
        }
        private void cbobanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbobanco.SelectedIndex >= 0)
            {
                cbocuentabanco.Text = "";
                CargarCuentasBancos();

            }
        }
        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotipo.SelectedValue != null)
            {
                string banco = cbobanco.Text;
                cbobanco.Visible = lblguia1.Visible = lblguia.Visible = cbocuentabanco.Visible = true;
                lblguia.Text = "Banco";
                cbobanco.ValueMember = "codigo";
                cbobanco.DisplayMember = "descripcion";
                cbobanco.DataSource = CapaLogica.getCargoTipoContratacion("Sufijo", "Entidad_Financiera", "TBL_Entidad_Financiera");
                cbobanco.Text = banco;
            }
            else
            {
                cbobanco.Visible = lblguia1.Visible = lblguia.Visible = cbocuentabanco.Visible = false;
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Detracion.Clear();
            foreach (DataGridViewRow item in dtgconten.Rows)
                if ((int)item.Cells[opcionx.Name].Value == 1)
                    Detracion.Add(new Detracciones(item.Cells[nrofacturax.Name].Value.ToString(), item.Cells[Clientex.Name].Value.ToString(), (decimal)item.Cells[ImportePEN.Name].Value, (int)item.Cells[xtipocomprobante.Name].Value));
            CargarDAtos();
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgconten_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //int x = e.RowIndex;
            //dtgconten.Rows[x].DefaultCellStyle.ForeColor = Configuraciones.OscuroUISelect;
            //dtgconten.Rows[x].DefaultCellStyle.SelectionBackColor = Configuraciones.AzulUI;
        }
        private void dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (dtgconten.RowCount > 0)
            {
                if (y == dtgconten.Columns[xredondeo.Name].Index)
                {
                    /////si el valor de la detracciones es menor que 1 sol
                    if (decimal.Parse(dtgconten[xredondeo.Name, x].Value.ToString()) < 1)
                        dtgconten[xredondeo.Name, x].Value = 1;
                    dtgconten[xdiferencia.Name, x].Value = Configuraciones.Redondear((decimal)dtgconten[ImportePEN.Name, x].Value) - Configuraciones.Redondear(decimal.Parse(dtgconten[xredondeo.Name, x].Value.ToString()));
                }
                //if ((decimal)dtgconten[porpagarx.Name, x].Value > (decimal)dtgconten[Detraccionx.Name, x].Value)
                //{
                //    dtgconten[porpagarx.Name, x].Value = (decimal)dtgconten[Detraccionx.Name, x].Value;
                //}
                if (Cargado)
                    CalcularTotal();
            }
        }
        decimal SumDiferencia = 0, SumRedondeo = 0;
        public void CalcularTotal()
        {
            if (Cargado)
            {
                SumDiferencia = SumRedondeo = 0;
                sumatoria = 0;
                int Seleccionados = 0;
                foreach (DataGridViewRow item in dtgconten.Rows)
                {
                    if ((int)item.Cells[opcionx.Name].Value == 1)
                    //Valores Seleccionados
                    {
                        sumatoria += Redondear((decimal)item.Cells[ImportePEN.Name].Value);
                        SumDiferencia += Redondear((decimal)item.Cells[xdiferencia.Name].Value);
                        SumRedondeo += Redondear((decimal)item.Cells[xredondeo.Name].Value);
                        Seleccionados++;
                    }
                }
                txttotal.Text = sumatoria.ToString("n2");
                txtredondeo.Text = SumRedondeo.ToString("n2");
                txtdiferencia.Text = SumDiferencia.ToString("n2");
                if (Seleccionados > 0) btnaceptar.Enabled = true;
                else btnaceptar.Enabled = false;
            }
        }
        public decimal Redondear(decimal valor) { return Configuraciones.Redondear(valor); }
        public Boolean VerificarErrorDiferencia()
        {
            Boolean Prueba = true;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if ((int)item.Cells[opcionx.Name].Value == 1)
                {
                    if (Math.Abs((decimal)item.Cells[xdiferencia.Name].Value) >= 1)
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xredondeo.Name]);
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xdiferencia.Name]);
                        Prueba = false;
                    }
                    else
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xredondeo.Name]);
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xdiferencia.Name]);
                    }
                }
                else
                {
                    HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xredondeo.Name]);
                    HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xdiferencia.Name]);
                }
            }
            if (!Prueba)
            {
                msg("El Redondeo no puede Superar a : S/ 1");
            }
            return Prueba;
        }
        public DialogResult msgP(string cadena) { return HPResergerFunciones.Utilitarios.msgync(cadena); }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Validacion de la Fecha de Recepción sea meno a la de pago
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if ((int)item.Cells[opcionx.Name].Value == 1)
                {
                    if (((DateTime)item.Cells[xFechaContable.Name].Value).Date > dtpFechaPago.Value.Date || ((DateTime)item.Cells[xFechaContable.Name].Value).Date > dtpFechaContable.Value.Date)
                    {
                        HPResergerFunciones.frmInformativo.MostrarDialogError("No se Puede Abonar Documentos con fecha de Recepción superior a la Fecha de Pago", $"No se Proceso por: La Factura: {item.Cells[nrofacturax.Name].Value.ToString()} \nRazonSocial: {item.Cells[razonx.Name].Value}");
                        return;
                    }
                }
            }
            if (dtgconten.RowCount > 0)
            {
                if (sumatoria > 0)
                {
                    if (cbobanco.Items.Count == 0)
                    {
                        msg("No hay Bancos");
                        cbobanco.Focus();
                        return;
                    }
                    if (cbocuentabanco.Items.Count == 0)
                    {
                        msg("El Banco Seleccionado No tiene Cuenta");
                        cbobanco.Focus();
                        return;
                    }
                    if (txttotal.Text.Length > 0)
                    {
                        if (decimal.Parse(txttotal.Text) == 0)
                        {
                            msg("El total a pagar no puede ser Cero");
                            dtgconten.Focus();
                            return;
                        }
                    }
                    if (cbotipo.Items.Count == 0) { cbotipo.Focus(); msg("Seleccione Tipo de Pago"); return; }
                    int TipoPago = (int)cbotipo.SelectedValue;
                    string NroOperacion = txtnrooperacion.TextValido();
                    //
                    if (cboproyecto.SelectedValue == null) { msg("Seleccione un Proyecto"); cboproyecto.Focus(); return; }
                    if (cboempresa.SelectedValue == null) { msg("Seleccione una Empresa"); cboempresa.Focus(); return; }
                    //
                    if (!txtDescCuenta.EstaLLeno()) { msg("Seleccione Cuenta Contable de Detracciones"); txtcuentadetracciones.Focus(); return; }
                    //Validacion de que el periodo NO sea muy disperso, sea un mes continuo a los trabajados
                    int IdEmpresa = (int)cboempresa.SelectedValue;
                    DateTime FechaCoontable = dtpFechaContable.Value;
                    if (!CapaLogica.ValidarCrearPeriodo(IdEmpresa, FechaCoontable))
                    {
                        if (HPResergerFunciones.frmPregunta.MostrarDialogYesCancel("No se Puede Registrar este Asiento\nEl Periodo no puede Crearse", $"¿Desea Crear el Periodo de {FechaCoontable.ToString("MMMM")}-{FechaCoontable.Year}?") != DialogResult.Yes)
                            return;
                    }
                    //Verificamos si el periodo esta Abierto
                    DataTable TPrueba2 = CapaLogica.VerPeriodoAbierto((int)cboempresa.SelectedValue, dtpFechaContable.Value);
                    if (TPrueba2.Rows.Count == 0) { msg("El Periodo está Cerrado cambie la Fecha Contable"); dtpFechaContable.Focus(); return; }
                    Boolean Verificar = false;
                    //validar que no se pague valores en cero
                    foreach (DataGridViewRow item in dtgconten.Rows)
                    {
                        if ((int)item.Cells[opcionx.Name].Value == 1)
                        {
                            if ((decimal)item.Cells[ImportePEN.Name].Value == 0)
                            {
                                Verificar = true;
                                HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[ImportePEN.Name]);
                            }
                            else
                                HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[ImportePEN.Name]);
                        }
                    }
                    if (!VerificarErrorDiferencia()) return;
                    if (Verificar) { msg("No se Puede Pagar Valores en Cero"); return; }
                    ///PROCESO DEL TXT
                    DialogResult Result = msgP("Desea Generar el TXT de Pago");
                    if (Result == DialogResult.Cancel) return;
                    if (Result == DialogResult.Yes)
                    {
                        frmDetraccionVentaPagoBancoNacion frmpagoventa = new frmDetraccionVentaPagoBancoNacion();
                        frmpagoventa.IdEmpresa = (int)cboempresa.SelectedValue;
                        ////datos de la tabla
                        //frmpagoventa.TDetracciones = new DataTable();
                        dtgconten.EndEdit();
                        dtgconten.RefreshEdit();
                        //frmpagoventa.TDetracciones = new DataTable();
                        frmpagoventa.TDetracciones = ((DataTable)dtgconten.DataSource).Clone();
                        foreach (DataRow item in ((DataTable)dtgconten.DataSource).Rows)
                            frmpagoventa.TDetracciones.Rows.Add(item.ItemArray);

                        if (frmpagoventa.ShowDialog() != DialogResult.Yes) return;
                    }
                    //PROCESO DE PAGO
                    ///DECLARACION DE VARIABLES
                    ///
                    DateTime FechaContable = dtpFechaContable.Value;
                    DateTime FechaPago = dtpFechaPago.Value;
                    int IdUsuario = frmLogin.CodigoUsuario;
                    string glosa = txtglosa.TextValido();
                    //
                    DataRow FilaDato = (CapaLogica.UltimoAsiento(IdEmpresa, FechaContable)).Rows[0];
                    int codigo = (int)FilaDato["codigo"];
                    string CuopPago = FilaDato["cuo"].ToString();
                    int idCta = (int)((DataTable)cbocuentabanco.DataSource).Rows[cbocuentabanco.SelectedIndex]["idtipocta"];
                    string CuentaContableBanco = cbocuentabanco.SelectedValue.ToString();
                    string CuentaDetracciones = txtcuentadetracciones.Text;
                    decimal TC = 0;
                    TC = CapaLogica.TipoCambioDia("Venta", FechaPago);
                    if (TC == 0) { msg("El Tipo de Cambio no puede ser Cero"); return; }
                    ///FIN DECLARACION DE VARIABLES
                    string NroBoleta = "", Idcliente = "";
                    int idcomprobante = 0;
                    int Tipoid = 0;
                    int posSelec = cbocuentabanco.SelectedIndex;
                    string NroCuenta = ((DataTable)cbocuentabanco.DataSource).Rows[posSelec]["NroCta"].ToString();
                    foreach (DataGridViewRow item in dtgconten.Rows)
                    {
                        if ((int)item.Cells[opcionx.Name].Value == 1)
                        {
                            //si el valor a pagar es superior a cero
                            if ((decimal)item.Cells[ImportePEN.Name].Value != 0)
                            {
                                NroBoleta = item.Cells[nrofacturax.Name].Value.ToString();
                                Idcliente = item.Cells[Clientex.Name].Value.ToString();
                                Tipoid = (int)item.Cells[tipoidx.Name].Value;
                                idcomprobante = (int)item.Cells[xtipocomprobante.Name].Value;
                                CapaLogica.DetraccionesVenta(1, NroBoleta, Tipoid, Idcliente, (decimal)item.Cells[ImporteMOx.Name].Value, (decimal)item.Cells[ImportePEN.Name].Value
                                    , (decimal)item.Cells[xtc.Name].Value, (decimal)item.Cells[xredondeo.Name].Value, (decimal)item.Cells[xdiferencia.Name].Value, NroOperacion,
                                    cbobanco.SelectedValue.ToString(), NroCuenta, FechaPago, IdUsuario, IdEmpresa, idcomprobante, CuopPago, TipoPago);
                            }
                        }
                    }
                    ///DINAMICA DEL PROCESO DE PAGO CABECERA                   
                    CapaLogica.PagarDetracionesVentaCabecera(codigo, CuopPago, decimal.Parse(txttotal.Text), decimal.Parse(txtredondeo.Text), decimal.Parse(txtdiferencia.Text), NroBoleta, CuentaDetracciones
                        , CuentaContableBanco, "9559501", FechaContable, glosa, IdEmpresa, FechaPago, idcomprobante, TC, (int)cboproyecto.SelectedValue);
                    ///DINAMICA DEL PROCESO DE PAGO DETALLE
                    int Detalle = 1;
                    foreach (DataGridViewRow item in dtgconten.Rows)
                        if ((int)item.Cells[opcionx.Name].Value == 1)
                            if ((decimal)item.Cells[ImportePEN.Name].Value != 0)
                            {//si el valor a pagar es superior a cero
                                NroBoleta = item.Cells[nrofacturax.Name].Value.ToString();
                                string[] fac = NroBoleta.Split('-');
                                string codfac = fac[0];
                                string numfac = fac[1];
                                Idcliente = item.Cells[Clientex.Name].Value.ToString();
                                idcomprobante = (int)item.Cells[xtipocomprobante.Name].Value;
                                CapaLogica.PagarDetracionesVentaDetalle(codigo, (int)item.Cells[tipoidx.Name].Value, item.Cells[Clientex.Name].Value.ToString(), item.Cells[razonx.Name].Value.ToString()
                                , (int)item.Cells[xtipocomprobante.Name].Value, codfac, numfac, NroBoleta, (decimal)item.Cells[xredondeo.Name].Value, decimal.Parse(txtredondeo.Text)
                                , (decimal)item.Cells[xdiferencia.Name].Value
                                //item.Cells[monedax.Name].Value.ToString() == "1" ? (decimal)item.Cells[ImportePEN.Name].Value / (decimal)item.Cells[xtc.Name].Value : (decimal)item.Cells[ImportePEN.Name].Value
                                , (decimal)item.Cells[xtc.Name].Value, CuentaDetracciones, CuentaContableBanco, idCta, FechaContable, decimal.Parse(txtdiferencia.Text) < 0 ? "9559501" : "7599103"
                                , glosa, IdUsuario, IdEmpresa, TC, (int)cboproyecto.SelectedValue, Detalle++, NroOperacion, TipoPago);
                            }
                    ////FIN DE LA DINAMICA DE LA CABECERA
                    //Cuadrar Asiento
                    CapaLogica.CuadrarAsiento(CuopPago, (int)cboproyecto.SelectedValue, FechaContable, 2);
                    //Fin Cuadrar Asiento
                    msgOK($"Detracciones Pagadas! \nCon Asiento {CuopPago}");
                    btnActualizar_Click(sender, e);
                    txttotal.Text = txtdiferencia.Text = txtredondeo.Text = "0.00";
                }
                else msg("Total de Detracciones en Cero");
            }
            else msg("No Hay Detracciones por Pagar");
        }
        public void BuscarCuentaDetracicones()
        {
            string consulta = txtcuentadetracciones.TextValido();
            DataTable Tcuenta = CapaLogica.BuscarCuentas(consulta, 3);
            string cadena = "";
            if (Tcuenta.Rows.Count > 0)
            {
                cadena = Tcuenta.Rows[0]["cuenta_contable"].ToString();
            }
            txtDescCuenta.Text = cadena;
        }
        private void txtcuentadetracciones_TextChanged(object sender, EventArgs e)
        {
            BuscarCuentaDetracicones();
        }
        TextBox txt;
        private string Nameproyecto;

        private void dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int x = dtgconten.CurrentRow.Index, y = dtgconten.CurrentCell.ColumnIndex;
            if (y == dtgconten.Columns[xredondeo.Name].Index)
            {
                txt = e.Control as TextBox;
                txt.KeyPress -= Txt_KeyPress;
                txt.KeyDown -= Txt_KeyDown;
                txt.KeyPress += Txt_KeyPress;
                txt.KeyDown += Txt_KeyDown;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CargarDAtos();
        }
        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txt, 10);
        }

        private void cbotipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }
    }
}
