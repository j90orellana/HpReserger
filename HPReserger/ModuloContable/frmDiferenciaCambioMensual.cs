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
    public partial class frmDiferenciaCambioMensual : FormGradient
    {
        public frmDiferenciaCambioMensual()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();

        public string NameEmpresa { get; private set; }

        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        private void frmcierremensual_Load(object sender, EventArgs e)
        {
            CargarEmpresa();
            GenerarAsientoSaldos = GenerarAsientoDocumentos = false;
        }
        public void CargarEmpresa()
        {
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
            cboempresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cboempresa_Click(object sender, EventArgs e)
        {
            string cadena = cboempresa.SelectedText;
            CargarEmpresa();
            cboempresa.Text = cadena;
        }

        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cuando selecciono algo del index
            btnAplicar.Enabled = false;
            if (cboempresa.SelectedIndex >= 0)
            {
                //proyecto         
                cboproyecto.DataSource = CapaLogica.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString());
                cboproyecto.DisplayMember = "proyecto";
                cboproyecto.ValueMember = "id_proyecto";
                //
                cboperiodo.ValueMember = "fechax";
                cboperiodo.DisplayMember = "mesaño";
                cboperiodo.DataSource = CapaLogica.Periodos(10, (int)cboempresa.SelectedValue);
                NameEmpresa = cboempresa.SelectedText;
            }
            if (cboperiodo.Items.Count == 0)
                //btnPreliminar.Enabled = true;
                btnPreliminar.Enabled = false;
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Stopwatch aloja = new System.Diagnostics.Stopwatch();
            //aloja.Start();
            this.Cursor = Cursors.WaitCursor;
            btnAplicar.Enabled = false;
            if (cboempresa.SelectedValue != null && cboperiodo.SelectedValue != null)
            {
                DateTime FEcha = (DateTime)cboperiodo.SelectedValue;
                DataTable DatosTC = CapaLogica.TipodeCambio(101, FEcha.Year, FEcha.Month, 1, 0, 0, null);
                if (DatosTC.Rows.Count > 0)
                {
                    DataRow FilaTC = DatosTC.Rows[0];
                    if (GenerarAsientoSaldos && chkSaldos.Checked)
                        btnAplicar.Enabled = true;
                    if (GenerarAsientoDocumentos && chkDocumentos.Checked)
                        btnAplicar.Enabled = true;
                    if (chkSaldos.Checked)
                    {
                        dtgconten.Columns[xProveedor.Name].Visible = dtgconten.Columns[xNumDoc.Name].Visible = dtgconten.Columns[xNameComprobante.Name].Visible = false;
                        if (GenerarAsientoSaldos)
                            dtgconten.DataSource = CapaLogica.CierreMensualSaldos((int)cboempresa.SelectedValue, (DateTime)cboperiodo.SelectedValue, ((DateTime)cboperiodo.SelectedValue).AddMonths(1).AddDays(-1), (decimal)FilaTC[1], (decimal)FilaTC[2]);
                        else
                            dtgconten.DataSource = CapaLogica.DiferenciadeCambioMensual((int)cboempresa.SelectedValue, FEcha, -30);
                    }
                    if (chkDocumentos.Checked)
                    {
                        dtgconten.Columns[xProveedor.Name].Visible = dtgconten.Columns[xNumDoc.Name].Visible = dtgconten.Columns[xNameComprobante.Name].Visible = true;
                        if (GenerarAsientoDocumentos)
                            dtgconten.DataSource = CapaLogica.CierreMensualDocumentos((int)cboempresa.SelectedValue, new DateTime(FEcha.Year, 1, 1), ((DateTime)cboperiodo.SelectedValue).AddMonths(1).AddDays(-1), (decimal)FilaTC[1], (decimal)FilaTC[2], btnAplicar.Enabled);
                        else
                            dtgconten.DataSource = CapaLogica.DiferenciadeCambioMensual((int)cboempresa.SelectedValue, FEcha, -31);

                    }
                    lblmsg.Text = $"Total de Registros: {dtgconten.RowCount}";
                    //Configuraciones.TiempoEjecucionMsg(aloja);
                }
                else msg("Ingrese el Tipo de Cambio para el Cierre de Este Periodo");
            }
            this.Cursor = Cursors.Default;
        }
        private void dtgconten1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int Dinamica = -30;
        private void btncerrar_Click(object sender, EventArgs e)
        {
            if (cboempresa.SelectedValue == null) { msg("Selecione una Empresa"); cboempresa.Focus(); return; }
            if (cboperiodo.SelectedValue == null) { msg("Selecione un Periodo"); cboperiodo.Focus(); return; }
            if (cboproyecto.SelectedValue == null) { msg("Selecciones un Proyecto"); cboproyecto.Focus(); return; }
            if (dtgconten.RowCount == 0) { msg("No Hay filas para Generar el Asiento"); return; }
            if (VerificarsiYaexisteAsiento()) { msg("Ya Existe un Asiento de Cierre en este Mes"); return; }
            //Dinamica para el Cierre Mensual
            DateTime FechaContable = Configuraciones.FinDelMes((DateTime)cboperiodo.SelectedValue);
            ///////
            int numasiento = 0;
            //int numasiento = GetNumAsiento(FechaContable);
            int PosFila = 0;
            int pkMoneda = 1;
            //string Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, FechaContable);
            //int proyecto = (int)cboproyecto.SelectedValue;
            string[] Proveedor = "0-9999".Split('-');
            int TipoIdProveedor = int.Parse(Proveedor[0]);
            string RucProveedor = Proveedor[1];
            string NameProveedor = "VARIOS";
            string glosa = "CIERRE MENSUAL SALDOS AUTOMATIC.";
            int IdUsuario = frmLogin.CodigoUsuario;
            int fkProyecto = (int)cboproyecto.SelectedValue;
            int TipoPago = 0;
            string NroPago = "";
            DateTime FechaCompensa = FechaContable;
            //Cuentas de Ganacia y perdida
            string CuentaGanacia = CapaLogica.BuscarCuentas("%ganancia%cambio%", 5).Rows[0]["idcuenta"].ToString();
            string CuentaPerdida = CapaLogica.BuscarCuentas("9%perdida%cambio%", 5).Rows[0]["idcuenta"].ToString();
            string mensaje = "Se Agrego los Asientos: ";
            bool var1, var2, var3, var4;
            var1 = var2 = var3 = var4 = false;
            //Primera Fase Activos = 'D' and Ganacias (+)
            numasiento = GetNumAsiento(FechaContable);
            string Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, FechaContable);
            decimal SumatoriaMN = 0;
            decimal TC = 0;
            decimal ValorDifCambio = 0;
            if (chkSaldos.Checked)
            {
                Dinamica = -30;
                glosa = "CIERRE MENSUAL SALDOS AUTOMATIC.";
            }
            else if (chkDocumentos.Checked)
            {
                Dinamica = -31;
                glosa = "CIERRE MENSUAL DOCUMENTOS AUTOMATIC.";
                //msg("Falta la dinamica del asiento");
                //return;
            }
            //Grabamos los Datos a la Tablas!
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                string CuentaContable = item.Cells[xcuentacontable.Name].Value.ToString();
                int idComprobante = (int)item.Cells[xIdComprobante.Name].Value;
                string NumDoc = item.Cells[xNumDoc.Name].Value.ToString();
                int TipoIdProv = (int)item.Cells[xTipoidPro.Name].Value;
                string Proveedores = item.Cells[xProveedor.Name].Value.ToString();
                string NameProveedores = item.Cells[xNameProveedor.Name].Value.ToString();

                decimal MontoDolares = (decimal)item.Cells[xMontoDolares.Name].Value;
                decimal MontoSoles = (decimal)item.Cells[xMontoSoles.Name].Value;
                decimal FinMes = (decimal)item.Cells[xFinMesSoles.Name].Value;
                decimal difcambio = (decimal)item.Cells[xDifCambio.Name].Value;
                decimal tccompra = (decimal)item.Cells[xtcvompra.Name].Value;
                decimal tcventa = (decimal)item.Cells[xtcVenta.Name].Value;

                string naturaleza = item.Cells[xfkNaturaleza.Name].Value.ToString();
                CapaLogica.DiferenciadeCambioMensual(1, (int)cboempresa.SelectedValue, FechaContable, Dinamica, CuentaContable, idComprobante, NumDoc, TipoIdProv, Proveedores, NameProveedores, MontoDolares, MontoSoles, FinMes,
                    difcambio, tccompra, tcventa, naturaleza);
            }
            //fin grabacion
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if (item.Cells[xfkNaturaleza.Name].Value.ToString() == "D" && (decimal)item.Cells[xDifCambio.Name].Value > 0)
                {
                    var1 = true;
                    TC = (decimal)item.Cells[xtcvompra.Name].Value;
                    ValorDifCambio = (decimal)item.Cells[xDifCambio.Name].Value;
                    string CuentaContable = item.Cells[xcuentacontable.Name].Value.ToString();
                    SumatoriaMN += ValorDifCambio;
                    //cabecera Debe
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaContable, ValorDifCambio, 0,
                      TC, fkProyecto, 0, Cuo, pkMoneda, glosa, FechaContable, Dinamica);
                    //Detalle del asiento del Debe
                    if (chkSaldos.Checked)
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, fkProyecto, TipoIdProveedor, RucProveedor,
                            NameProveedor, 0, "0", "0", 0, FechaContable, FechaContable, FechaContable, ValorDifCambio, 0, TC, pkMoneda, "", "", glosa, FechaContable, IdUsuario, "");
                    if (chkDocumentos.Checked)
                    {
                        TipoIdProveedor = (int)item.Cells[xTipoidPro.Name].Value;
                        RucProveedor = item.Cells[xProveedor.Name].Value.ToString().Trim();
                        NameProveedor = item.Cells[xNameProveedor.Name].Value.ToString().Trim();
                        int idcomprobante = (int)item.Cells[xIdComprobante.Name].Value;
                        string[] NumDoc = item.Cells[xNumDoc.Name].Value.ToString().Trim().Split('-');
                        string SerieDocumento = NumDoc[0];
                        string NumDocumento = NumDoc[1];
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, fkProyecto, TipoIdProveedor, RucProveedor,
                            NameProveedor, idcomprobante, SerieDocumento, NumDocumento, 0, FechaContable, FechaContable, FechaContable, ValorDifCambio, 0, TC, pkMoneda, "", "", glosa, FechaContable, IdUsuario, "");
                    }
                }
            }
            if (var1)
            {
                Proveedor = "0-9999".Split('-'); TipoIdProveedor = int.Parse(Proveedor[0]); RucProveedor = Proveedor[1]; NameProveedor = "VARIOS";
                //cabecera Haber
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaGanacia, 0, SumatoriaMN,
                    TC, fkProyecto, 0, Cuo, pkMoneda, glosa, FechaContable, Dinamica);
                //Detalle del asiento del Haber
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaGanacia, fkProyecto, TipoIdProveedor, RucProveedor,
                NameProveedor, 0, "0", "0", 0, FechaContable, FechaContable, FechaContable, SumatoriaMN, 0, TC, pkMoneda, "", "", glosa, FechaContable, IdUsuario, "");
                mensaje += $" Cuo: {Cuo}";
            }
            //Primera Fase Pasivo = 'H' and Ganacias (+)
            numasiento = GetNumAsiento(FechaContable);
            Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, FechaContable); PosFila = 0;
            SumatoriaMN = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if (item.Cells[xfkNaturaleza.Name].Value.ToString() == "H" && (decimal)item.Cells[xDifCambio.Name].Value < 0)
                {
                    var2 = true;
                    TC = (decimal)item.Cells[xtcvompra.Name].Value;
                    ValorDifCambio = Math.Abs((decimal)item.Cells[xDifCambio.Name].Value);
                    SumatoriaMN += ValorDifCambio;
                    string CuentaContable = item.Cells[xcuentacontable.Name].Value.ToString();
                    //cabecera Debe
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaContable, ValorDifCambio, 0,
                      TC, fkProyecto, 0, Cuo, pkMoneda, glosa, FechaContable, Dinamica);
                    //Detalle del asiento del Debe
                    if (chkSaldos.Checked)
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, fkProyecto, TipoIdProveedor, RucProveedor,
                            NameProveedor, 0, "0", "0", 0, FechaContable, FechaContable, FechaContable, ValorDifCambio, 0, TC, pkMoneda, "", "", glosa, FechaContable, IdUsuario, "");
                    if (chkDocumentos.Checked)
                    {
                        TipoIdProveedor = (int)item.Cells[xTipoidPro.Name].Value;
                        RucProveedor = item.Cells[xProveedor.Name].Value.ToString().Trim();
                        NameProveedor = item.Cells[xNameProveedor.Name].Value.ToString().Trim();
                        int idcomprobante = (int)item.Cells[xIdComprobante.Name].Value;
                        string[] NumDoc = item.Cells[xNumDoc.Name].Value.ToString().Trim().Split('-');
                        string SerieDocumento = NumDoc[0];
                        string NumDocumento = NumDoc[1];
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, fkProyecto, TipoIdProveedor, RucProveedor,
                            NameProveedor, idcomprobante, SerieDocumento, NumDocumento, 0, FechaContable, FechaContable, FechaContable, ValorDifCambio, 0, TC, pkMoneda, "", "", glosa, FechaContable, IdUsuario, "");
                    }
                }
            }
            if (var2)
            {
                Proveedor = "0-9999".Split('-'); TipoIdProveedor = int.Parse(Proveedor[0]); RucProveedor = Proveedor[1]; NameProveedor = "VARIOS";
                //cabecera Haber
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaGanacia, 0, SumatoriaMN,
                  TC, fkProyecto, 0, Cuo, pkMoneda, glosa, FechaContable, Dinamica);
                //Detalle del asiento del Haber
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaGanacia, fkProyecto, TipoIdProveedor, RucProveedor,
                    NameProveedor, 0, "0", "0", 0, FechaContable, FechaContable, FechaContable, SumatoriaMN, 0, TC, pkMoneda, "", "", glosa, FechaContable, IdUsuario, "");
                mensaje += $" Cuo: {Cuo}";
            }
            //Primera Fase Activos = 'D' and Perdidas (-)
            numasiento = GetNumAsiento(FechaContable);
            Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, FechaContable); PosFila = 0;
            SumatoriaMN = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if (item.Cells[xfkNaturaleza.Name].Value.ToString() == "D" && (decimal)item.Cells[xDifCambio.Name].Value < 0)
                {
                    var3 = true;
                    TC = (decimal)item.Cells[xtcvompra.Name].Value;
                    ValorDifCambio = Math.Abs((decimal)item.Cells[xDifCambio.Name].Value);
                    SumatoriaMN += ValorDifCambio;
                    string CuentaContable = item.Cells[xcuentacontable.Name].Value.ToString();
                    //cabecera Debe
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaContable, 0, ValorDifCambio,
                      TC, fkProyecto, 0, Cuo, pkMoneda, glosa, FechaContable, Dinamica);
                    //Detalle del asiento del Debe
                    if (chkSaldos.Checked)
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, fkProyecto, TipoIdProveedor, RucProveedor,
                            NameProveedor, 0, "0", "0", 0, FechaContable, FechaContable, FechaContable, ValorDifCambio, 0, TC, pkMoneda, "", "", glosa, FechaContable, IdUsuario, "");
                    if (chkDocumentos.Checked)
                    {
                        TipoIdProveedor = (int)item.Cells[xTipoidPro.Name].Value;
                        RucProveedor = item.Cells[xProveedor.Name].Value.ToString().Trim();
                        NameProveedor = item.Cells[xNameProveedor.Name].Value.ToString().Trim();
                        int idcomprobante = (int)item.Cells[xIdComprobante.Name].Value;
                        string[] NumDoc = item.Cells[xNumDoc.Name].Value.ToString().Trim().Split('-');
                        string SerieDocumento = NumDoc[0];
                        string NumDocumento = NumDoc[1];
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, fkProyecto, TipoIdProveedor, RucProveedor,
                            NameProveedor, idcomprobante, SerieDocumento, NumDocumento, 0, FechaContable, FechaContable, FechaContable, ValorDifCambio, 0, TC, pkMoneda, "", "", glosa, FechaContable, IdUsuario, "");
                    }
                }
            }
            if (var3)
            {
                Proveedor = "0-9999".Split('-'); TipoIdProveedor = int.Parse(Proveedor[0]); RucProveedor = Proveedor[1]; NameProveedor = "VARIOS";
                //cabecera Haber
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaPerdida, SumatoriaMN, 0,
                  TC, fkProyecto, 0, Cuo, pkMoneda, glosa, FechaContable, Dinamica);
                //Detalle del asiento del Haber
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaPerdida, fkProyecto, TipoIdProveedor, RucProveedor,
                    NameProveedor, 0, "0", "0", 0, FechaContable, FechaContable, FechaContable, SumatoriaMN, 0, TC, pkMoneda, "", "", glosa, FechaContable, IdUsuario, "");
                mensaje += $" Cuo: {Cuo}";
            }
            //Primera Fase Pasivo = 'H' and Perdidas (-)
            numasiento = GetNumAsiento(FechaContable);
            Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, FechaContable); PosFila = 0;
            SumatoriaMN = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if (item.Cells[xfkNaturaleza.Name].Value.ToString() == "H" && (decimal)item.Cells[xDifCambio.Name].Value > 0)
                {
                    var4 = true;
                    TC = (decimal)item.Cells[xtcvompra.Name].Value;
                    ValorDifCambio = Math.Abs((decimal)item.Cells[xDifCambio.Name].Value);
                    SumatoriaMN += ValorDifCambio;
                    string CuentaContable = item.Cells[xcuentacontable.Name].Value.ToString();
                    //cabecera Debe
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaContable, 0, ValorDifCambio,
                      TC, fkProyecto, 0, Cuo, pkMoneda, glosa, FechaContable, Dinamica);
                    //Detalle del asiento del Debe
                    if (chkSaldos.Checked)
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, fkProyecto, TipoIdProveedor, RucProveedor,
                            NameProveedor, 0, "0", "0", 0, FechaContable, FechaContable, FechaContable, ValorDifCambio, 0, TC, pkMoneda, "", "", glosa, FechaContable, IdUsuario, "");
                    if (chkDocumentos.Checked)
                    {
                        TipoIdProveedor = (int)item.Cells[xTipoidPro.Name].Value;
                        RucProveedor = item.Cells[xProveedor.Name].Value.ToString().Trim();
                        NameProveedor = item.Cells[xNameProveedor.Name].Value.ToString().Trim();
                        int idcomprobante = (int)item.Cells[xIdComprobante.Name].Value;
                        string[] NumDoc = item.Cells[xNumDoc.Name].Value.ToString().Trim().Split('-');
                        string SerieDocumento = NumDoc[0];
                        string NumDocumento = NumDoc[1];
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, fkProyecto, TipoIdProveedor, RucProveedor,
                            NameProveedor, idcomprobante, SerieDocumento, NumDocumento, 0, FechaContable, FechaContable, FechaContable, ValorDifCambio, 0, TC, pkMoneda, "", "", glosa, FechaContable, IdUsuario, "");
                    }
                }
            }
            if (var4)
            {
                Proveedor = "0-9999".Split('-'); TipoIdProveedor = int.Parse(Proveedor[0]); RucProveedor = Proveedor[1]; NameProveedor = "VARIOS";
                //cabecera Haber
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaPerdida, SumatoriaMN, 0,
                  TC, fkProyecto, 0, Cuo, pkMoneda, glosa, FechaContable, Dinamica);
                //Detalle del asiento del Haber
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaPerdida, fkProyecto, TipoIdProveedor, RucProveedor,
                    NameProveedor, 0, "0", "0", 0, FechaContable, FechaContable, FechaContable, SumatoriaMN, 0, TC, pkMoneda, "", "", glosa, FechaContable, IdUsuario, "");
                mensaje += $" Cuo: {Cuo}";
            }
            ////////
            msgOK(mensaje);
            btnAplicar.Enabled = false;
            GenerarAsientoDocumentos = GenerarAsientoSaldos = false;
            cboperiodo_SelectedIndexChanged(sender, e);
        }
        private Boolean GenerarAsientoSaldos;
        private Boolean GenerarAsientoDocumentos;
        public int GetNumAsiento(DateTime FechaContable)
        {
            int numasiento = 0;
            if (numasiento == 0)
            {
                DataTable asientito = CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue, FechaContable);
                DataRow asiento = asientito.Rows[0];
                if (asiento == null) { numasiento = 1; }
                else
                    numasiento = ((int)asiento["codigo"]);
            }
            return numasiento;
        }
        private void cboperiodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboperiodo.SelectedValue != null && cboempresa.SelectedValue != null)
            {
                btnAplicar.Enabled = false;
                btnPreliminar.Enabled = true;
                GenerarAsientoSaldos = GenerarAsientoDocumentos = false;
                lbl1.Text = "Sin Procesar;";
                lbl2.Text = "Sin Procesar;";
                //Verificamos si ya existe el Asiento;
                DataTable TDatosSaldos = CapaLogica.CierreMensualDinamicaYaExiste(-30, (DateTime)cboperiodo.SelectedValue, (int)cboempresa.SelectedValue);
                DataTable TDatosDocumentos = CapaLogica.CierreMensualDinamicaYaExiste(-31, (DateTime)cboperiodo.SelectedValue, (int)cboempresa.SelectedValue);
                if (TDatosSaldos.Rows.Count > 0)
                {
                    GenerarAsientoSaldos = false;
                    lbl1.Text = "Procesado; con Cuo:";
                    foreach (DataRow item in TDatosSaldos.Rows)
                    {
                        lbl1.Text += $"{item["cod_Asiento_Contable"].ToString()}; ";
                    }
                }
                else GenerarAsientoSaldos = true;
                if (TDatosDocumentos.Rows.Count > 0)
                {
                    GenerarAsientoDocumentos = false;
                    lbl2.Text = "Procesado; con Cuo:";
                    foreach (DataRow item in TDatosDocumentos.Rows)
                    {
                        lbl2.Text += $"{item["cod_Asiento_Contable"].ToString()}; ";
                    }
                }
                else GenerarAsientoDocumentos = true;

            }
            else
            {
                VaciarGrilla();
            }
        }
        public void VaciarGrilla()
        {
            if (dtgconten.DataSource == null)
            {
                dtgconten.DataSource = new DataTable();
            }
            else
                dtgconten.DataSource = ((DataTable)dtgconten.DataSource).Clone();
        }
        public Boolean VerificarsiYaexisteAsiento()
        {
            //Verificamos si ya existe el Asiento;
            DataTable TDatos = new DataTable();
            if (chkSaldos.Checked)
                TDatos = CapaLogica.CierreMensualDinamicaYaExiste(-30, (DateTime)cboperiodo.SelectedValue, (int)cboempresa.SelectedValue);
            else if (chkDocumentos.Checked)
                TDatos = CapaLogica.CierreMensualDinamicaYaExiste(-31, (DateTime)cboperiodo.SelectedValue, (int)cboempresa.SelectedValue);
            if (TDatos.Rows.Count > 0)
            {
                DataRow Filita = TDatos.Rows[0];
                lblmsg.Text = $"Ya Existe un Asiento, Reverselo {Filita["Cod_Asiento_Contable"]}";
                return true;
            }
            else
            {
                return false;
            }

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                int[] _ColumnasAutoajustar = new int[] { 2, 3, 4, 5 };
                if (chkSaldos.Checked)
                {
                    _NombreHoja = "Cierre Mensual Saldo";
                    _Cabecera = "Cierre Mensual por Saldos";
                    _NColumna = "H";
                    _ColumnasAutoajustar = new int[] { 2, 3, 4, 5 };
                }
                else if (chkDocumentos.Checked)
                {
                    _NombreHoja = "Cierre Mensual Documentos";
                    _Cabecera = "Cierre Mensual por Documentos";
                    _NColumna = "N";
                    _ColumnasAutoajustar = new int[] { 2, 3, 4, 5, 7, 6 };
                }
                _Columnas = new int[] { 1, 2, 3, 4, 5, 6 };
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
                if (chkSaldos.Checked)
                {
                    TableResuk.Columns.Remove(TableResuk.Columns[xIdComprobante.DataPropertyName]);
                    TableResuk.Columns.Remove(TableResuk.Columns[xNameComprobante.DataPropertyName]);
                    TableResuk.Columns.Remove(TableResuk.Columns[xNumDoc.DataPropertyName]);
                    TableResuk.Columns.Remove(TableResuk.Columns[xProveedor.DataPropertyName]);
                    TableResuk.Columns.Remove(TableResuk.Columns[xNameProveedor.DataPropertyName]);
                    TableResuk.Columns.Remove(TableResuk.Columns[xTipoidPro.DataPropertyName]);
                }
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableResuk, CeldaCabecera, CeldaDefault, "", _NombreHoja, Celdas, PosInicialGrilla, _Columnas, new int[] { }, _ColumnasAutoajustar, "");
            }
            else msg("No hay Registros en la Grilla");
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmpro.Close();
            dtgconten.ResumeLayout();
        }
        frmProcesando frmpro;
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                ///* Inicio = new TimeSpan(DateTim*/e.Now.Ticks);
                dtgconten.SuspendLayout();
                frmpro = new frmProcesando();
                frmpro.Show(); Cursor = Cursors.WaitCursor;
                NameEmpresa = $"{cboempresa.Text} {cboperiodo.Text}";
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else { msg("No hay Datos que Mostrar"); }
        }

        private void btnPreliminar_EnabledChanged(object sender, EventArgs e)
        {

        }
        private void chkSaldos_CheckedChanged(object sender, EventArgs e)
        {
            btnAplicar.Enabled = false;
        }

        private void chkDocumentos_CheckedChanged(object sender, EventArgs e)
        {
            btnAplicar.Enabled = false;
        }
    }
}
