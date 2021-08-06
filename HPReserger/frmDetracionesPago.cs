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
    public partial class frmDetracionesPago : FormGradient
    {
        public frmDetracionesPago()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void frmDetracionesPago_Load(object sender, EventArgs e)
        {
            DataRow Filita = CapaLogica.VerUltimoIdentificador("TBL_Factura", "Nro_DocPago");
            if (Filita != null)
                txtnropago.Text = (decimal.Parse(Filita["ultimo"].ToString()) + 1).ToString();
            else txtnropago.Text = "1";
            CargarTiposID("TBL_Tipo_ID");
            cargarempresas();
            //cbotipo.SelectedIndex = 0;
            Detracion = new List<Detracciones>();
            CargarDAtos();
            dtpFechaPago.Value = dtpFechaContable.Value = DateTime.Now;
            txtcuentadetracciones_TextChanged(sender, e);
            txtglosa.CargarTextoporDefecto();
            txtcuentaredondeo.CargarTextoporDefecto();
            txtnrooperacion.CargarTextoporDefecto();
            CargarTipoPagos();
            GenerarGlosaxDefectoxFechaPago();
        }
        private void GenerarGlosaxDefectoxFechaPago()
        {
            if (!txtglosa.EstaLLeno())
            {
                txtglosa.TextoDefecto = $"PAGO MASIVO DETRACCIONES {dtpFechaPago.Value.ToString("dd-MM-yyyy")}";
                txtglosa.Text = $"PAGO MASIVO DETRACCIONES {dtpFechaPago.Value.ToString("dd-MM-yyyy")}";
            }
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
            CapaLogica.TablaEmpresas(cboempresa);
        }
        //DataTable TablaTipoID;
        public void CargarTiposID(string tabla)
        {
            //TablaTipoID = new DataTable();
            //TablaTipoID = CapaLogica.CualquierTabla(tabla, "Desc_Tipo_ID", "RUC");
            //cbotipoid.DisplayMember = "Desc_Tipo_ID";
            //cbotipoid.ValueMember = "Codigo_Tipo_ID";
            //cbotipoid.DataSource = TablaTipoID;
        }
        public void CalcularValoresRedondeoyDiferencia()
        {
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                item.Cells[xRedondeo.Name].Value = Math.Round((decimal)item.Cells[porpagarx.Name].Value);
                //  item.Cells[xDiferencia.Name].Value = (decimal)item.Cells[porpagarx.Name].Value - (decimal)item.Cells[xRedondeo.Name].Value;
            }
        }
        public void CargarDAtos()
        {
            dtgconten.DataSource = CapaLogica.DetraccionesPorPAgar((int)cboempresa.SelectedValue);
            NumRegistrosdtg();
            SeleccionarDetracionesSeleccionadas();
            CalcularValoresRedondeoyDiferencia();
        }
        public void SeleccionarDetracionesSeleccionadas()
        {
            if (Detracion != null)
                foreach (DataGridViewRow item in dtgconten.Rows)
                {
                    foreach (Detracciones det in Detracion)
                    {
                        if (item.Cells[nrofacturax.Name].Value.ToString() == det._nrodetracion && item.Cells[Proveedorx.Name].Value.ToString() == det._proveedor && det._idcomprobante == (int)item.Cells[xidcomprobante.Name].Value)
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
        }
        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgconten.Columns[opcionx.Name].Index)
            {
                dtgconten.EndEdit(); dtgconten.RefreshEdit();
            }
        }
        decimal sumatoria = 1000, sumadif = 0, sumaTotal = 0;
        public class Detracciones
        {
            public string _nrodetracion;
            public string _proveedor;
            public decimal _monto;
            public int _idcomprobante;
            public Detracciones(string nrofactura, string proveedor, decimal monto, int idcomprobantes)
            {
                _nrodetracion = nrofactura;
                _proveedor = proveedor;
                _monto = monto;
                _idcomprobante = idcomprobantes;
            }
        }
        List<Detracciones> Detracion;
        public void CalcularTotal()
        {
            sumatoria = 0; sumadif = 0; sumaTotal = 0;
            int Seleccionados = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if ((int)item.Cells[opcionx.Name].Value == 1)
                //Valores Seleccionados
                {
                    sumatoria += decimal.Parse(item.Cells[xRedondeo.Name].Value.ToString());
                    sumaTotal += decimal.Parse(item.Cells[porpagarx.Name].Value.ToString());
                    sumadif += decimal.Parse(item.Cells[xDiferencia.Name].Value.ToString());
                    Seleccionados++;
                }
            }
            txttotal.Text = sumatoria.ToString("n2");
            txtdiferencia.Text = sumadif.ToString("n2");
            txtredondeo.Text = sumaTotal.ToString("n2");
            if (Seleccionados > 0) btnaceptar.Enabled = true;
            else btnaceptar.Enabled = false;
        }
        public Boolean VerificarErrorDiferencia()
        {
            Boolean Prueba = true;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if ((int)item.Cells[opcionx.Name].Value == 1)
                {
                    if (Math.Abs((decimal)item.Cells[xDiferencia.Name].Value) >= 1)
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xRedondeo.Name]);
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xDiferencia.Name]);
                        Prueba = false;
                    }
                    else
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xRedondeo.Name]);
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xDiferencia.Name]);
                    }
                }
                else
                {
                    HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xRedondeo.Name]);
                    HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xDiferencia.Name]);
                }
            }
            if (!Prueba)
            {
                msg("El Redondeo no puede Superar a : S/ 1");
            }
            return Prueba;
        }
        private void dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (dtgconten.RowCount > 0)
            {
                if (y == dtgconten.Columns[xRedondeo.Name].Index)
                {
                    /////si el valor de la detracciones es menor que 1 sol
                    if ((decimal)dtgconten[xRedondeo.Name, x].Value < 1)
                        dtgconten[xRedondeo.Name, x].Value = 1;
                    dtgconten[xDiferencia.Name, x].Value = (decimal)dtgconten[porpagarx.Name, x].Value - (decimal)dtgconten[xRedondeo.Name, x].Value;
                }
                //if ((decimal)dtgconten[porpagarx.Name, x].Value > (decimal)dtgconten[Detraccionx.Name, x].Value)
                //{
                //    dtgconten[porpagarx.Name, x].Value = (decimal)dtgconten[Detraccionx.Name, x].Value;
                //}
                CalcularTotal();
            }
        }
        TextBox txt;
        private void dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int x = dtgconten.CurrentRow.Index, y = dtgconten.CurrentCell.ColumnIndex;
            if (y == dtgconten.Columns[xRedondeo.Name].Index)
            {
                txt = e.Control as TextBox;
                txt.KeyPress -= Txt_KeyPress;
                txt.KeyDown -= Txt_KeyDown;
                txt.KeyPress += Txt_KeyPress;
                txt.KeyDown += Txt_KeyDown;
            }
        }
        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txt, 10);
        }
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public DialogResult msgp(string cadena, string detalle) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena, detalle); }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            decimal TC = 0;
            DateTime FechaPago = dtpFechaPago.Value;
            DateTime FechaContable = dtpFechaContable.Value;
            TC = CapaLogica.TipoCambioDia("Venta", FechaPago);
            //validacion de datos
            if (cboproyecto.SelectedValue == null) { msg("Seleccione un Proyecto"); cboproyecto.Focus(); return; }
            if (cboempresa.SelectedValue == null) { msg("Seleccione una Empresa"); cboempresa.Focus(); return; }
            if (TC == 0) { msg("No se Encontro un Tipo de Cambio Registrado para Hoy, Revise el Formulario  de Tipo de Cambio"); return; }
            //Validacion de que el periodo NO sea muy disperso, sea un mes continuo a los trabajados
            int IdEmpresa = (int)cboempresa.SelectedValue;
            DateTime FechaCoontable = dtpFechaContable.Value;
            if (!CapaLogica.ValidarCrearPeriodo(IdEmpresa, FechaCoontable))
            {
                if (msgp("No se Puede Registrar este Asiento\nEl Periodo no puede Crearse", $"¿Desea Crear el Periodo de {FechaCoontable.ToString("MMMM")}-{FechaCoontable.Year}?") != DialogResult.Yes)
                    return;
            }
            else
            //if (!CapaLogica.ValidarCrearPeriodo(IdEmpresa, FechaCoontable))
            //{
            //    if (HPResergerFunciones.frmPregunta.MostrarDialogYesCancel("No se Puede Registrar este Asiento\nEl Periodo no puede Crearse", $"¿Desea Crear el Periodo de {FechaCoontable.ToString("MMMM")}-{FechaCoontable.Year}?") != DialogResult.Yes)
            //        return;
            //}
            //Verificamos si el periodo esta Abierto
            if (!CapaLogica.VerificarPeriodoAbierto(IdEmpresa, FechaCoontable))
            {
                msg("El Periodo Esta Cerrado, Cambie Fecha Contable"); dtpFechaContable.Focus(); return;
            }
            //Validacion de la Fecha de Recepción sea meno a la de pago
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if ((int)item.Cells[opcionx.Name].Value == 1)
                {
                    if (((DateTime)item.Cells[FechaRecepcionx.Name].Value).Date > dtpFechaPago.Value.Date || ((DateTime)item.Cells[FechaRecepcionx.Name].Value).Date > dtpFechaContable.Value.Date)
                    {
                        HPResergerFunciones.frmInformativo.MostrarDialogError("No se Puede Pagar Documentos con fecha de Recepción superior a la Fecha de Pago", $"No se Proceso por: La Factura: {item.Cells[nrofacturax.Name].Value.ToString()} \nRazonSocial: {item.Cells[razonx.Name].Value}");
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

                    if (decimal.Parse(txtdiferencia.Text) > 0)
                        if (!txtDescCuenta.EstaLLeno()) { txtcuentaredondeo.Focus(); msg("Ingresé Cuenta de Redondeo"); return; }
                    Boolean Verificar = false;
                    //validar que no se pague valores en cero
                    foreach (DataGridViewRow item in dtgconten.Rows)
                    {
                        if ((int)item.Cells[opcionx.Name].Value == 1)
                        {
                            if ((decimal)item.Cells[xRedondeo.Name].Value == 0)
                            {
                                Verificar = true;
                                HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[porpagarx.Name]);
                            }
                            else
                                HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[porpagarx.Name]);
                        }
                    }
                    if (!VerificarErrorDiferencia()) return;
                    if (Verificar) { msg("No se Puede Pagar Valores en Cero"); return; }
                    ///DECLARACION DE LAS VARIABLES                 
                    int IdProyecto = (int)cboproyecto.SelectedValue;
                    DataRow FilaDato = (CapaLogica.UltimoAsiento(IdEmpresa, FechaContable)).Rows[0];
                    int codigo = (int)FilaDato["codigo"];
                    string CuoPago = FilaDato["cuo"].ToString();
                    int idCta = (int)((DataTable)cbocuentabanco.DataSource).Rows[cbocuentabanco.SelectedIndex]["idtipocta"];
                    int IdUsuario = frmLogin.CodigoUsuario;
                    string glosa = txtglosa.Text;
                    ///FIN DECLARACION DE VARIABLES
                    //PROCESO DE PAGO
                    string nrofac = "", ruc = "";
                    int idcomprobante = 0;
                    int posSelec = cbocuentabanco.SelectedIndex;
                    string NroCuenta = ((DataTable)cbocuentabanco.DataSource).Rows[posSelec]["NroCta"].ToString();
                    //VALIDAMOS QUE NO EXISTAN CUENTAS CONTABLES DESACTIVADAS
                    List<string> ListaAuxiliar = new List<string>();
                    ListaAuxiliar.Add("9559501,7599103");
                    ListaAuxiliar.Add(cbocuentabanco.SelectedValue.ToString());
                    ListaAuxiliar.Add(((DataTable)cbocuentabanco.DataSource).Rows[cbocuentabanco.SelectedIndex]["idtipocta"].ToString());
                    ListaAuxiliar.Add(txtcuentaredondeo.Text);
                    ///fin de la cabecera del exceso             
                    if (CapaLogica.CuentaContableValidarActivas(string.Join(",", ListaAuxiliar.ToArray()), "Cuentas Contables Desactivadas")) return;
                    //FIN DE LA VALDIACION DE LAS CUENTAS CONTABLES DESACTIVADAS
                    ///PROCESO DEL TXT
                    DialogResult Result = msgP("Desea Generar el TXT de Pago");
                    if (Result == DialogResult.Cancel) return;
                    if (Result == DialogResult.Yes)
                    {
                        frmDetraccionVentaPagoBancoNacion frmpagoventa = new frmDetraccionVentaPagoBancoNacion();
                        frmpagoventa.Text = "Generación del TXT de Pago de Detracciones de Compras";
                        frmpagoventa.IdEmpresa = (int)cboempresa.SelectedValue;
                        frmpagoventa.Compra = true;
                        frmpagoventa.NroCuentaBanco = HPResergerFunciones.Utilitarios.QuitarCaracterCuenta(HPResergerFunciones.Utilitarios.ExtraerCuenta(cbocuentabanco.Text), '-');
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
                    foreach (DataGridViewRow item in dtgconten.Rows)
                    {
                        if ((int)item.Cells[opcionx.Name].Value == 1)
                        {
                            //si el valor a pagar es superior a cero
                            if ((decimal)item.Cells[xRedondeo.Name].Value != 0)
                            {
                                nrofac = item.Cells[nrofacturax.Name].Value.ToString();
                                ruc = item.Cells[Proveedorx.Name].Value.ToString();
                                idcomprobante = (int)item.Cells[xidcomprobante.Name].Value;
                                CapaLogica.Detracciones(1, item.Cells[nrofacturax.Name].Value.ToString(), item.Cells[Proveedorx.Name].Value.ToString(), (decimal)item.Cells[Detraccionx.Name].Value
                                    , (decimal)item.Cells[porpagarx.Name].Value, (decimal)item.Cells[xtc.Name].Value, (decimal)item.Cells[xRedondeo.Name].Value, (decimal)item.Cells[xDiferencia.Name].Value
                                    , NroOperacion, cbobanco.SelectedValue.ToString(), NroCuenta, FechaPago, IdUsuario, (int)item.Cells[xidcomprobante.Name].Value, IdEmpresa, CuoPago, TipoPago);
                            }
                        }
                    }
                    //CABECERA Y DETALLE DETRACCIONES
                    int c = 1;
                    foreach (DataGridViewRow item in dtgconten.Rows)
                    {
                        if ((int)item.Cells[opcionx.Name].Value == 1)
                            if ((decimal)item.Cells[xRedondeo.Name].Value != 0)
                                CapaLogica.PagarDetracionesCabecera(c++, codigo, CuoPago, IdEmpresa, IdProyecto, decimal.Parse(txtredondeo.Text), (decimal)item.Cells[porpagarx.Name].Value,
                                    decimal.Parse(txtdiferencia.Text), ruc, nrofac, cbocuentabanco.SelectedValue.ToString(), txtcuentaredondeo.Text, FechaPago, FechaContable, glosa, idcomprobante, TC, 0);
                    }
                    //CABECERA Y DETALLE BANCOS
                    ///DINAMICA DEL PROCESO DE PAGO CABECERA                   
                    CapaLogica.PagarDetracionesCabecera(c++, codigo, CuoPago, IdEmpresa, IdProyecto, decimal.Parse(txttotal.Text), decimal.Parse(txtredondeo.Text), decimal.Parse(txtdiferencia.Text), ruc, nrofac
                        , cbocuentabanco.SelectedValue.ToString(), txtcuentaredondeo.Text, FechaPago, FechaContable, glosa, idcomprobante, TC, 1);
                    ///DINAMICA DEL PROCESO DE PAGO DETALLE
                    c = 1;
                    decimal SumaSoles = 0, SumaDolares = 0;
                    foreach (DataGridViewRow item in dtgconten.Rows)
                        if ((int)item.Cells[opcionx.Name].Value == 1)
                            if ((decimal)item.Cells[xRedondeo.Name].Value != 0)
                            {//si el valor a pagar es superior a cero
                                nrofac = item.Cells[nrofacturax.Name].Value.ToString();
                                string[] fac = nrofac.Split('-');
                                string codfac = fac[0]; string numfac = fac[1];
                                ruc = item.Cells[Proveedorx.Name].Value.ToString();
                                idcomprobante = (int)item.Cells[xidcomprobante.Name].Value;
                                SumaSoles += (decimal)item.Cells[xRedondeo.Name].Value;
                                SumaDolares += decimal.Round((decimal)item.Cells[xRedondeo.Name].Value / (decimal)item.Cells[xtc.Name].Value, 2);
                                CapaLogica.PagarDetracionesDetalle(c++, codigo, CuoPago, IdEmpresa, IdProyecto, (decimal)item.Cells[porpagarx.Name].Value, (decimal)item.Cells[xRedondeo.Name].Value,
                                    (decimal)item.Cells[xDiferencia.Name].Value, ruc, codfac, numfac, (decimal)item.Cells[xtotal.Name].Value, (decimal)item.Cells[xtc.Name].Value, idCta,
                                    cbocuentabanco.SelectedValue.ToString(), decimal.Parse(txtdiferencia.Text) < 0 ? "9559501" : "7599103", FechaContable, glosa, IdUsuario, idcomprobante,
                                    NroOperacion, TipoPago, 0);
                            }
                    //detalle de los bancos
                    string CuentaBanco = cbocuentabanco.SelectedValue.ToString();
                    CapaLogica.InsertarAsientoDetalle(10, c++, codigo, FechaContable, CuentaBanco, IdProyecto, Configuraciones.DefIdRuc, Configuraciones.DefRuc, Configuraciones.DefRazonSocial,
                        Configuraciones.DefIdComprobante, Configuraciones.DefSerieFac, Configuraciones.DefNumFac, Configuraciones.DefCentroCosto, FechaPago, FechaPago, FechaPago, SumaSoles,
                        SumaDolares, TC, 1, idCta, NroOperacion, glosa, FechaContable, IdUsuario, "");

                    c--;
                    foreach (DataGridViewRow item in dtgconten.Rows)
                        if ((int)item.Cells[opcionx.Name].Value == 1)
                            if ((decimal)item.Cells[xRedondeo.Name].Value != 0)
                            {//si el valor a pagar es superior a cero
                                nrofac = item.Cells[nrofacturax.Name].Value.ToString();
                                string[] fac = nrofac.Split('-');
                                string codfac = fac[0]; string numfac = fac[1];
                                ruc = item.Cells[Proveedorx.Name].Value.ToString();
                                idcomprobante = (int)item.Cells[xidcomprobante.Name].Value;
                                CapaLogica.PagarDetracionesDetalle(c, codigo, CuoPago, IdEmpresa, IdProyecto, (decimal)item.Cells[xRedondeo.Name].Value, (decimal)item.Cells[porpagarx.Name].Value, (decimal)item.Cells[xDiferencia.Name].Value
                                    , ruc, codfac, numfac, (decimal)item.Cells[xtotal.Name].Value, (decimal)item.Cells[xtc.Name].Value, idCta, cbocuentabanco.SelectedValue.ToString(),
                                   decimal.Parse(txtdiferencia.Text) < 0 ? "9559501" : "7599103", FechaContable, glosa, IdUsuario, idcomprobante, NroOperacion, TipoPago, 1);
                            }
                    ////FIN DE LA DINAMICA DE LA CABECERA
                    //Cuadramos El Asiento
                    //CapaLogica.CuadrarAsiento(CuoPago, IdProyecto, FechaContable, 1);
                    //Fin Cuadre del Asiento
                    msgOK($"Detracciones Pagadas! con Asiento {CuoPago}");
                    btnActualizar_Click(sender, e);
                }
                else msg("Total de Detracciones en Cero");
            }
            else msg("No Hay Detracciones por Pagar");
        }
        public DialogResult msgP(string cadena) { return HPResergerFunciones.Utilitarios.msgync(cadena); }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Detracion.Clear();
            foreach (DataGridViewRow item in dtgconten.Rows)
                if ((int)item.Cells[opcionx.Name].Value == 1)
                    Detracion.Add(new Detracciones(item.Cells[nrofacturax.Name].Value.ToString(), item.Cells[Proveedorx.Name].Value.ToString(), (decimal)item.Cells[porpagarx.Name].Value, (int)item.Cells[xidcomprobante.Name].Value));
            CargarDAtos();
        }
        private void dtgconten_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (e.RowIndex >= 0)
            {
                if ((dtgconten[nrodetraccionesx.Name, x].Value.ToString() == "" || dtgconten[nrodetraccionesx.Name, x].Value.ToString() == "0" || dtgconten[nrodetraccionesx.Name, x].Value.ToString() == "-"))
                {
                    dtgconten.Rows[x].DefaultCellStyle.ForeColor = Configuraciones.RojoUISelect;
                    dtgconten.Rows[x].DefaultCellStyle.SelectionBackColor = Configuraciones.RojoUI;
                }
                else
                {
                    //dtgconten.Rows[x].DefaultCellStyle.ForeColor = Configuraciones.OscuroUISelect;
                    //dtgconten.Rows[x].DefaultCellStyle.SelectionBackColor = Configuraciones.AzulUISelect;
                }
                //if (dtgconten[opcionx.Name, x].Value.ToString() == "1")
                //{
                //    dtgconten.Rows[x].DefaultCellStyle.ForeColor = Color.Empty;
                //    dtgconten.Rows[x].DefaultCellStyle.BackColor = Configuraciones.ColorFilaSeleccionada;
                //    dtgconten.Rows[x].DefaultCellStyle.SelectionBackColor = Configuraciones.ColorFilaSeleccionada;
                //}
                //else
                //{
                //    dtgconten.Rows[x].DefaultCellStyle.ForeColor = Color.Empty;
                //    dtgconten.Rows[x].DefaultCellStyle.BackColor = Color.Empty;
                //    dtgconten.Rows[x].DefaultCellStyle.SelectionBackColor = Color.Empty;
                //}
                //dtgconten.SendToBack();
            }
        }
        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotipo.SelectedValue != null)
            {
                string cadena = cbobanco.Text;
                cbobanco.Visible = lblguia1.Visible = lblguia.Visible = cbocuentabanco.Visible = true;
                lblguia.Text = "Banco";
                cbobanco.ValueMember = "codigo";
                cbobanco.DisplayMember = "descripcion";
                cbobanco.DataSource = CapaLogica.getCargoTipoContratacion("Sufijo", "Entidad_Financiera", "TBL_Entidad_Financiera");
                cbobanco.Text = cadena;
            }
            else
            {
                cbobanco.Visible = lblguia1.Visible = lblguia.Visible = cbocuentabanco.Visible = false;
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
        private void cbobanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbobanco.SelectedIndex >= 0)
            {
                cbocuentabanco.Text = "";
                CargarCuentasBancos();
            }
        }
        private string _NameEmpresa;
        private string NameProyecto;

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
            NameProyecto = cboproyecto.Text;
            if (cboempresa.Items.Count != CapaLogica.TablaEmpresa().Rows.Count)
            {
                CapaLogica.TablaEmpresa(cboempresa);
                cboempresa.Text = cadena;
            }
        }
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameProyecto = cboproyecto.Text;
            if (cbobanco.SelectedValue != null)
            {
                CargarCuentasBancos();
                NameEmpresa = cboempresa.Text;
                CargarDAtos();
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
            cboproyecto.Text = NameProyecto;
        }
        public void BuscarCuentaDetracicones()
        {
            string consulta = txtcuentaredondeo.TextValido();
            DataTable Tcuenta = CapaLogica.BuscarCuentas(consulta, 3);
            string cadena = "";
            if (Tcuenta.Rows.Count > 0)
            {
                cadena = Tcuenta.Rows[0]["cuenta_contable"].ToString();
            }
            txtDescCuenta.Text = cadena;
        }
        frmProcesando frmproce;
        private string NombreEmpresa;
        private void btnexcel_Click(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerSupportsCancellation = true;
            if (dtgconten.RowCount > 0)
            {
                dtgconten.SuspendLayout();
                Cursor = Cursors.WaitCursor;
                frmproce = new HPReserger.frmProcesando();
                frmproce.Show();
                NombreEmpresa = cboempresa.Text;
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
            //Sí no hay datos
            if (dtgconten.RowCount > 0)
            {
                string _NombreHoja = ""; string _Cabecera = ""; int[] _OrdenarColumnas; string _NColumna = "";
                _NombreHoja = $"Detracciones Compras"; _Cabecera = "PAGO DETRACCIONES - COMPRAS";
                _OrdenarColumnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
                _NColumna = "q";
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "q1", _Cabecera.ToUpper(), 10, true, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "a2", "PERIODO:", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b2", "b2", $"{FechaInicial.Year} {FechaInicial.Month.ToString("00")}", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a3", "a3", "Ruc:", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("b3", "c3", $"{Ruc}", 8, false, false, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", "B2", "NOMBRE EMPRESA:", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("C2", "E2", $"{NombreEmpresa}", 8, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                ///////estilos de la celdas
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, Configuraciones.FuenteReportesTahoma8, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, Configuraciones.FuenteReportesTahoma8, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                /////fin estilo de las celdas
                //Tabla Datos
                DataTable TablaExportar = new DataTable();
                TablaExportar = ((DataTable)dtgconten.DataSource).Copy();
                TablaExportar.Columns.RemoveAt(18);
                TablaExportar.Columns.RemoveAt(17);
                TablaExportar.Columns.RemoveAt(0);
                /////
                ////Anterior               
                //HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", _NombreHoja, Celdas, 5, _Columnas, new int[] { }, new int[] { });
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TablaExportar, CeldaCabecera, CeldaDefault, "", _NombreHoja, Celdas, 4, _OrdenarColumnas, new int[] { }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "");
                // HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(TablaResult, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, contador++, Celdas, 5, _OrdenarColumnas, new int[] { }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "");

                if (backgroundWorker1.IsBusy) backgroundWorker1.CancelAsync();
            }
            else msg("No hay Registros en la Grilla");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
            dtgconten.ResumeLayout();
        }

        private void dtpFechaPago_ValueChanged(object sender, EventArgs e)
        {
            GenerarGlosaxDefectoxFechaPago();
        }

        private void dtgconten_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtcuentadetracciones_TextChanged(object sender, EventArgs e)
        {
            BuscarCuentaDetracicones();
        }

        private void dtgconten_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
