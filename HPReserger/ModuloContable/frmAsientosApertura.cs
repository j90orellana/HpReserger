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
    public partial class frmAsientosApertura : FormGradient
    {
        public frmAsientosApertura()
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
            //GenerarAsientoSaldos = GenerarAsientoDocumentos = false;
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
                NameEmpresa = cboempresa.SelectedText;
            }
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Stopwatch aloja = new System.Diagnostics.Stopwatch();
            //aloja.Start();
            this.Cursor = Cursors.WaitCursor;
            btnAplicar.Enabled = false;
            if (cboempresa.SelectedValue != null)
            {
                DateTime FechaAñoPasado = new DateTime(comboMesAño.FechaFinMes.Year - 1, 12, 31);
                DateTime FechaAñoActual = new DateTime(comboMesAño.FechaFinMes.Year, 12, 31);
                DataTable DatosTC = CapaLogica.TipodeCambio(101, FechaAñoPasado.Year, FechaAñoPasado.Month, 31, 0, 0, null);
                if (DatosTC.Rows.Count > 0)
                {
                    DataRow FilaTC = DatosTC.Rows[0];
                    //if (chkSaldos.Checked)
                    {
                        //dtgconten.Columns[xProveedor.Name].Visible = dtgconten.Columns[xNumDoc.Name].Visible = dtgconten.Columns[xNameComprobante.Name].Visible = false;
                        DataTable Tdatos = CapaLogica.AperturaEjercicio((int)cboempresa.SelectedValue, FechaAñoActual);
                        btnAplicar.Enabled = false;
                        lbl1.Text = "";
                        if (Tdatos.Rows.Count == 0)
                        {
                            dtgconten.DataSource = CapaLogica.AsientoApertura_CierrePeriodo((int)cboempresa.SelectedValue, FechaAñoPasado);
                            btnAplicar.Enabled = true;
                        }
                        else
                        {
                            dtgconten.DataSource = Tdatos;
                            VerificarsiYaexisteAsiento();
                        }
                    }
                    lblmsg.Text = $"Total de Registros: {dtgconten.RowCount}";
                    if (dtgconten.RowCount == 0)
                    {
                        msg("No Se Encontraron Datos");
                    }
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
            if (cboproyecto.SelectedValue == null) { msg("Selecciones un Proyecto"); cboproyecto.Focus(); return; }
            if (dtgconten.RowCount == 0) { msg("No Hay filas para Generar el Asiento"); return; }
            if (VerificarsiYaexisteAsiento()) { msg("Ya Existe un Asiento de Apertura para este Año"); return; }
            //Dinamica para el Cierre Mensual
            DateTime FechaContable = new DateTime(comboMesAño.FechaFinMes.Year, 1, 1);
            ///////
            int numasiento = 0;
            int PosFila = 0;
            int pkMoneda = 1;
            int pkMOnedaDetalle = 1;
            //string Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, FechaContable);
            //int proyecto = (int)cboproyecto.SelectedValue;
            string[] Proveedor = "0-9999".Split('-');
            int TipoIdProveedor = int.Parse(Proveedor[0]);
            string RucProveedor = Proveedor[1];
            string NameProveedor = "VARIOS";
            string glosa = $"APERTURA {comboMesAño.FechaFinMes.Year}";
            Glosa = glosa;
            int IdUsuario = frmLogin.CodigoUsuario;
            int fkProyecto = (int)cboproyecto.SelectedValue;
            int TipoPago = 0;
            string NroPago = "";
            DateTime FechaCompensa = FechaContable;
            //Cuentas de Ganacia y perdida
            ////string CuentaGanacia = CapaLogica.BuscarCuentas("%ganancia%cambio%", 5).Rows[0]["idcuenta"].ToString();
            ////string CuentaPerdida = CapaLogica.BuscarCuentas("9%perdida%cambio%", 5).Rows[0]["idcuenta"].ToString();
            string mensaje = "Se Agrego los Asientos: ";
            bool var1, var2, var3, var4;
            var1 = var2 = var3 = var4 = false;
            //Primera Fase Activos = 'D' and Ganacias (+)
            numasiento = GetNumAsiento(FechaContable);
            string Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, FechaContable);
            decimal SumatoriaMN = 0;
            decimal SumatoriaME = 0;
            decimal TC = 0;
            decimal ValorSolesMN = 0;
            decimal ValorDolaresME = 0;
            Dinamica = -50;
            //msg("Falta la dinamica del asiento");
            //return;
            //Grabamos los Datos a la Tablas!
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                string CuentaContable = item.Cells[xcuentacontable.Name].Value.ToString();
                int idComprobante = (int)item.Cells[xIdComprobante.Name].Value;
                string NumDoc = item.Cells[xNumDoc.Name].Value.ToString();
                int TipoIdProv = (int)item.Cells[xTipoidPro.Name].Value;
                string Proveedores = item.Cells[xProveedor.Name].Value.ToString();
                string NameProveedores = item.Cells[xNameProveedor.Name].Value.ToString();

                decimal SumaDebe = (decimal)item.Cells[xSumaDebe.Name].Value;
                decimal SumaHaber = (decimal)item.Cells[xSumaHaber.Name].Value;
                decimal SaldoDeudor = (decimal)item.Cells[xSaldoDeudor.Name].Value;
                decimal SaldoAcreedor = (decimal)item.Cells[xSaldoAcreedor.Name].Value;
                decimal tccompra = (decimal)item.Cells[xtcvompra.Name].Value;
                decimal tcventa = (decimal)item.Cells[xtcVenta.Name].Value;
                int idMoneda = (int)item.Cells[xMon.Name].Value;
                string naturaleza = item.Cells[xfkNaturaleza.Name].Value.ToString();
                //Inserto en la Tabla Los valores delos SAldos Contables para la apertura del año siguiente
                CapaLogica.AperturaEjercicio(1, (int)cboempresa.SelectedValue, FechaContable, CuentaContable, idComprobante, NumDoc, TipoIdProv, Proveedores, NameProveedores, SumaDebe, SumaHaber, SaldoDeudor,
                    SaldoAcreedor, tccompra, tcventa, idMoneda, naturaleza);
            }
            //Listado de DataViews
            DataView DataDebeSoles = ((DataTable)dtgconten.DataSource).Copy().AsDataView();
            DataDebeSoles.RowFilter = "moneda = 1 and naturaleza  = 'D'";
            DataView DataDebeDolares = ((DataTable)dtgconten.DataSource).Copy().AsDataView();
            DataDebeDolares.RowFilter = "moneda = 2 and naturaleza  = 'D'";
            DataView DataHaberSoles = ((DataTable)dtgconten.DataSource).Copy().AsDataView();
            DataHaberSoles.RowFilter = "moneda = 1 and naturaleza  = 'H'";
            DataView DataHaberDolares = ((DataTable)dtgconten.DataSource).Copy().AsDataView();
            DataHaberDolares.RowFilter = "moneda = 2 and naturaleza  = 'H'";
            //fin de los filtros para avanzar a los asientos
            //fin grabacion
            //return;
            //definiciones
            //debe = Tipo Cambio Compra
            //Haber = TIpo de Cambio Venta
            string CuentaGenerica = "4971101";// costo diferido
            //DEBE SOLES
            DataTable TTable = DataDebeSoles.ToTable();
            foreach (DataRow item in TTable.Rows)
            {
                //if (item.Cells[xfkNaturaleza.DataPropertyName].Value.ToString() == "D" && (decimal)item.Cells[xSaldoDeudor.DataPropertyName].Value > 0)
                {
                    var1 = true;
                    TC = (decimal)item[xtcvompra.DataPropertyName];
                    ValorSolesMN = (decimal)item[xSaldoDeudor.DataPropertyName];
                    ValorDolaresME = (decimal)item[xSaldoDeudor.DataPropertyName] / TC;
                    string CuentaContable = item[xcuentacontable.DataPropertyName].ToString();
                    SumatoriaMN += ValorSolesMN;
                    SumatoriaME += ValorDolaresME;
                    //cabecera Debe
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaContable, ValorSolesMN, 0,
                      TC, fkProyecto, 0, Cuo, pkMoneda, Glosa, FechaContable, Dinamica);
                    //Detalle del asiento del Debe
                    //if (chkSaldos.Checked)
                    //CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, fkProyecto, TipoIdProveedor, RucProveedor,
                    //    NameProveedor, 0, "0", "0", 0, FechaContable, FechaContable, FechaContable, ValorSolesMN, 0, TC, pkMOnedaDetalle, "", "", $"{CuentaContable}-{glosa}", FechaContable, IdUsuario, "");
                    //if (chkDocumentos.Checked)
                    {
                        TipoIdProveedor = (int)item[xTipoidPro.DataPropertyName];
                        RucProveedor = item[xProveedor.DataPropertyName].ToString().Trim();
                        NameProveedor = item[xNameProveedor.DataPropertyName].ToString().Trim();
                        int idcomprobante = (int)item[xIdComprobante.DataPropertyName];
                        string[] NumDoc = item[xNumDoc.DataPropertyName].ToString().Trim().Split('-');
                        string SerieDocumento = NumDoc[0];
                        string NumDocumento = NumDoc[1];
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, fkProyecto, TipoIdProveedor, RucProveedor,
                            NameProveedor, idcomprobante, SerieDocumento, NumDocumento, 0, FechaContable, FechaContable, FechaContable, ValorSolesMN, ValorDolaresME, TC, pkMOnedaDetalle,
                            "", "", $"{CuentaContable}-{glosa}", FechaContable, IdUsuario, "");
                    }
                }
            }
            if (var1)
            {
                Proveedor = "0-9999".Split('-'); TipoIdProveedor = int.Parse(Proveedor[0]); RucProveedor = Proveedor[1]; NameProveedor = "VARIOS";
                //cabecera Haber
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaGenerica, 0, SumatoriaMN,
                    TC, fkProyecto, 0, Cuo, pkMoneda, $"{Glosa}", FechaContable, Dinamica);
                //Detalle del asiento del Haber
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaGenerica, fkProyecto, TipoIdProveedor, RucProveedor,
                NameProveedor, 0, "0", "0", 0, FechaContable, FechaContable, FechaContable, SumatoriaMN, SumatoriaME, TC, pkMOnedaDetalle, "", "", $"{CuentaGenerica}-{glosa}",
                FechaContable, IdUsuario, "");
                mensaje += $" Cuo: {Cuo}";
            }
            //Primera Fase Pasivo = 'H' and Ganacias (+)
            numasiento = GetNumAsiento(FechaContable);
            Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, FechaContable); PosFila = 0;
            SumatoriaME = SumatoriaMN = 0;
            //HABER SOLES
            TTable = DataHaberSoles.ToTable();
            foreach (DataRow item in TTable.Rows)
            {
                //if (item[xfkNaturaleza.DataPropertyName].ToString() == "H" && (decimal)item[xSumaDebe.DataPropertyName].Value < 0)
                {
                    var2 = true;
                    TC = (decimal)item[xtcVenta.DataPropertyName];
                    ValorSolesMN = Math.Abs((decimal)item[xSaldoAcreedor.DataPropertyName]);
                    ValorDolaresME = Math.Abs((decimal)item[xSaldoAcreedor.DataPropertyName]) / TC;
                    SumatoriaMN += ValorSolesMN;
                    SumatoriaME += ValorDolaresME;
                    string CuentaContable = item[xcuentacontable.DataPropertyName].ToString();
                    //cabecera Debe
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaContable, 0, ValorSolesMN,
                      TC, fkProyecto, 0, Cuo, pkMoneda, Glosa, FechaContable, Dinamica);
                    //Detalle del asiento del Debe
                    //if (chkSaldos.Checked)
                    //CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, fkProyecto, TipoIdProveedor, RucProveedor,
                    //    NameProveedor, 0, "0", "0", 0, FechaContable, FechaContable, FechaContable, ValorSolesMN, 0, TC, pkMOnedaDetalle, "", "", $"{CuentaContable}-{glosa}", FechaContable, IdUsuario, "");
                    //if (chkDocumentos.Checked)
                    {
                        TipoIdProveedor = (int)item[xTipoidPro.DataPropertyName];
                        RucProveedor = item[xProveedor.DataPropertyName].ToString().Trim();
                        NameProveedor = item[xNameProveedor.DataPropertyName].ToString().Trim();
                        int idcomprobante = (int)item[xIdComprobante.DataPropertyName];
                        string[] NumDoc = item[xNumDoc.DataPropertyName].ToString().Trim().Split('-');
                        string SerieDocumento = NumDoc[0];
                        string NumDocumento = NumDoc[1];
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, fkProyecto, TipoIdProveedor, RucProveedor,
                            NameProveedor, idcomprobante, SerieDocumento, NumDocumento, 0, FechaContable, FechaContable, FechaContable, ValorSolesMN, ValorDolaresME, TC, pkMOnedaDetalle,
                            "", "", $"{CuentaContable}-{glosa}", FechaContable, IdUsuario, "");
                    }
                }
            }
            if (var2)
            {
                Proveedor = "0-9999".Split('-'); TipoIdProveedor = int.Parse(Proveedor[0]); RucProveedor = Proveedor[1]; NameProveedor = "VARIOS";
                //cabecera Haber
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaGenerica, SumatoriaMN, 0,
                  TC, fkProyecto, 0, Cuo, pkMoneda, Glosa, FechaContable, Dinamica);
                //Detalle del asiento del Haber
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaGenerica, fkProyecto, TipoIdProveedor, RucProveedor,
                    NameProveedor, 0, "0", "0", 0, FechaContable, FechaContable, FechaContable, SumatoriaMN, SumatoriaME, TC, pkMOnedaDetalle, "", "", $"{CuentaGenerica}-{glosa}", FechaContable, IdUsuario, "");
                mensaje += $" Cuo: {Cuo}";
            }
            //Primera Fase Activos = 'D' and Perdidas (-)
            numasiento = GetNumAsiento(FechaContable);
            Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, FechaContable); PosFila = 0;
            SumatoriaME = SumatoriaMN = 0;
            //DEBE DOLARES
            TTable = DataDebeDolares.ToTable();
            pkMOnedaDetalle = 2;
            pkMoneda = 2;
            foreach (DataRow item in TTable.Rows)
            {
                ////if (item[xfkNaturaleza.DataPropertyName].Value.ToString() == "D" && (decimal)item.Cells[xSumaDebe.DataPropertyName].Value < 0)
                {
                    var3 = true;
                    TC = (decimal)item[xtcvompra.DataPropertyName];
                    ValorSolesMN = Math.Abs((decimal)item[xSaldoDeudor.DataPropertyName]) * TC;
                    ValorDolaresME = Math.Abs((decimal)item[xSaldoDeudor.DataPropertyName]);
                    SumatoriaMN += ValorSolesMN;
                    SumatoriaME += ValorDolaresME;
                    string CuentaContable = item[xcuentacontable.DataPropertyName].ToString();
                    //cabecera Debe
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaContable, 0, ValorDolaresME,
                      TC, fkProyecto, 0, Cuo, pkMoneda, Glosa, FechaContable, Dinamica);
                    //Detalle del asiento del Debe
                    //if (chkSaldos.Checked)
                    //CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, fkProyecto, TipoIdProveedor, RucProveedor,
                    //    NameProveedor, 0, "0", "0", 0, FechaContable, FechaContable, FechaContable, ValorSolesMN, ValorDolaresME, TC, pkMOnedaDetalle, "", "", $"{CuentaContable}-{glosa}", FechaContable, IdUsuario, "");
                    //if (chkDocumentos.Checked)
                    {
                        TipoIdProveedor = (int)item[xTipoidPro.DataPropertyName];
                        RucProveedor = item[xProveedor.DataPropertyName].ToString().Trim();
                        NameProveedor = item[xNameProveedor.DataPropertyName].ToString().Trim();
                        int idcomprobante = (int)item[xIdComprobante.DataPropertyName];
                        string[] NumDoc = item[xNumDoc.DataPropertyName].ToString().Trim().Split('-');
                        string SerieDocumento = NumDoc[0];
                        string NumDocumento = NumDoc[1];
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, fkProyecto, TipoIdProveedor, RucProveedor,
                            NameProveedor, idcomprobante, SerieDocumento, NumDocumento, 0, FechaContable, FechaContable, FechaContable, ValorSolesMN, ValorDolaresME, TC,
                            pkMOnedaDetalle, "", "", $"{CuentaContable}-{glosa}", FechaContable, IdUsuario, "");
                    }
                }
            }
            if (var3)
            {
                Proveedor = "0-9999".Split('-'); TipoIdProveedor = int.Parse(Proveedor[0]); RucProveedor = Proveedor[1]; NameProveedor = "VARIOS";
                //cabecera Haber
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaGenerica, SumatoriaME, 0,
                  TC, fkProyecto, 0, Cuo, pkMoneda, Glosa, FechaContable, Dinamica);
                //Detalle del asiento del Haber
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaGenerica, fkProyecto, TipoIdProveedor, RucProveedor,
                    NameProveedor, 0, "0", "0", 0, FechaContable, FechaContable, FechaContable, SumatoriaMN, SumatoriaME, TC, pkMOnedaDetalle, "", "", $"{CuentaGenerica}-{glosa}",
                    FechaContable, IdUsuario, "");
                mensaje += $" Cuo: {Cuo}";
            }
            //Primera Fase Pasivo = 'H' and Perdidas (-)
            numasiento = GetNumAsiento(FechaContable);
            Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, FechaContable); PosFila = 0;
            SumatoriaME = SumatoriaMN = 0;
            //HABER DOLARES
            TTable = DataHaberDolares.ToTable();
            foreach (DataRow item in TTable.Rows)
            {
                //if (item.Cells[xfkNaturaleza.DataPropertyName].Value.ToString() == "H" && (decimal)item.Cells[xSumaDebe.DataPropertyName].Value > 0)
                {
                    var4 = true;
                    TC = (decimal)item[xtcVenta.DataPropertyName];
                    ValorSolesMN = Math.Abs((decimal)item[xSaldoAcreedor.DataPropertyName]) * TC;
                    ValorDolaresME = Math.Abs((decimal)item[xSaldoAcreedor.DataPropertyName]);
                    SumatoriaMN += ValorSolesMN;
                    SumatoriaME += ValorDolaresME;
                    string CuentaContable = item[xcuentacontable.DataPropertyName].ToString();
                    //cabecera Debe
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaContable, ValorDolaresME, 0,
                      TC, fkProyecto, 0, Cuo, pkMoneda, Glosa, FechaContable, Dinamica);
                    //Detalle del asiento del Debe
                    //if (chkSaldos.Checked)
                    //CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, fkProyecto, TipoIdProveedor, RucProveedor,
                    //    NameProveedor, 0, "0", "0", 0, FechaContable, FechaContable, FechaContable, ValorSolesMN, 0, TC, pkMOnedaDetalle, "", "", Glosa, FechaContable, IdUsuario, "");
                    //if (chkDocumentos.Checked)
                    {
                        TipoIdProveedor = (int)item[xTipoidPro.DataPropertyName];
                        RucProveedor = item[xProveedor.DataPropertyName].ToString().Trim();
                        NameProveedor = item[xNameProveedor.DataPropertyName].ToString().Trim();
                        int idcomprobante = (int)item[xIdComprobante.DataPropertyName];
                        string[] NumDoc = item[xNumDoc.DataPropertyName].ToString().Trim().Split('-');
                        string SerieDocumento = NumDoc[0];
                        string NumDocumento = NumDoc[1];
                        CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaContable, fkProyecto, TipoIdProveedor, RucProveedor,
                            NameProveedor, idcomprobante, SerieDocumento, NumDocumento, 0, FechaContable, FechaContable, FechaContable, ValorSolesMN, ValorDolaresME, TC, pkMOnedaDetalle,
                            "", "", $"{CuentaContable}-{glosa}", FechaContable, IdUsuario, "");
                    }
                }
            }
            if (var4)
            {
                Proveedor = "0-9999".Split('-'); TipoIdProveedor = int.Parse(Proveedor[0]); RucProveedor = Proveedor[1]; NameProveedor = "VARIOS";
                //cabecera Haber
                CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, CuentaGenerica, 0, SumatoriaME,
                  TC, fkProyecto, 0, Cuo, pkMoneda, Glosa, FechaContable, Dinamica);
                //Detalle del asiento del Haber
                CapaLogica.InsertarAsientoFacturaDetalle(10, PosFila, numasiento, FechaContable, CuentaGenerica, fkProyecto, TipoIdProveedor, RucProveedor,
                    NameProveedor, 0, "0", "0", 0, FechaContable, FechaContable, FechaContable, SumatoriaMN, SumatoriaME, TC, pkMOnedaDetalle, "", "", $"{CuentaGenerica}-{glosa}", FechaContable, IdUsuario, "");
                mensaje += $" Cuo: {Cuo}";
            }
            ////////
            msgOK(mensaje);
            btnAplicar.Enabled = false;
            GenerarAsientoAPertura = false;
            cboperiodo_SelectedIndexChanged(sender, e);
        }
        private Boolean GenerarAsientoAPertura;
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
            if (cboempresa.SelectedValue != null)
            {
                btnAplicar.Enabled = false;
                DateTime Fecha = new DateTime(comboMesAño.FechaFinMes.Year, 1, 31);
                btnPreliminar.Enabled = true;
                GenerarAsientoAPertura = false;
                //lbl1.Text = "Sin Procesar;";
                //lbl2.Text = "Sin Procesar;";
                //Verificamos si ya existe el Asiento;
                DataTable TDatos = CapaLogica.CierreMensualDinamicaYaExiste(-50, Fecha, (int)cboempresa.SelectedValue);
                // -50 ASient0 de APertura
                if (TDatos.Rows.Count > 0)
                {
                    GenerarAsientoAPertura = false;
                    lbl1.Text = "Procesado; con Cuo:";
                    foreach (DataRow item in TDatos.Rows)
                    {
                        lbl1.Text += $"{item["cod_Asiento_Contable"].ToString()}; ";
                    }
                }
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
            DateTime Fecha = new DateTime(comboMesAño.FechaFinMes.Year, 12, 31);
            DataTable TDatos = new DataTable();
            //if (chkSaldos.Checked)
            TDatos = CapaLogica.CierreMensualDinamicaYaExiste(-50, new DateTime(Fecha.Year, 1, 1), (int)cboempresa.SelectedValue);
            if (TDatos.Rows.Count > 0)
            {
                lbl1.Text = $"Ya Existe un Asiento, Reverselo ";
                foreach (DataRow item in TDatos.Rows)
                {
                    lbl1.Text += $" {item["Cod_Asiento_Contable"]}";
                }
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
                //if (chkSaldos.Checked)
                {
                    _NombreHoja = $"Asiento  Apertura {NameEmpresa}".ToUpper();
                    _Cabecera = "Asiento Apertura";
                    _NColumna = "H";
                    _ColumnasAutoajustar = new int[] { 2, 3, 4, 5 };
                }
                //else if (chkDocumentos.Checked)
                //{
                //    _NombreHoja = $"Cierre Mensual Documentos {NameEmpresa}".ToUpper();
                //    _Cabecera = "Cierre Mensual por Documentos";
                //    _NColumna = "N";
                //    _ColumnasAutoajustar = new int[] { 2, 3, 4, 5, 7, 6 };
                //}
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
                //if (chkSaldos.Checked)
                //{
                //    TableResuk.Columns.Remove(TableResuk.Columns[xIdComprobante.DataPropertyName]);
                //    TableResuk.Columns.Remove(TableResuk.Columns[xNameComprobante.DataPropertyName]);
                //    TableResuk.Columns.Remove(TableResuk.Columns[xNumDoc.DataPropertyName]);
                //    TableResuk.Columns.Remove(TableResuk.Columns[xProveedor.DataPropertyName]);
                //    TableResuk.Columns.Remove(TableResuk.Columns[xNameProveedor.DataPropertyName]);
                //    TableResuk.Columns.Remove(TableResuk.Columns[xTipoidPro.DataPropertyName]);
                //}
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
        private string Glosa;

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                ///* Inicio = new TimeSpan(DateTim*/e.Now.Ticks);
                dtgconten.SuspendLayout();
                frmpro = new frmProcesando();
                frmpro.Show(); Cursor = Cursors.WaitCursor;
                NameEmpresa = $"{cboempresa.Text} {comboMesAño.FechaInicioMes.Year}";
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

        private void comboMesAño_CambioFechas(object sender, EventArgs e)
        {
            btnPreliminar.Enabled = true;
        }
    }
}
