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
            lbl1.Text = "No Existe Asiento.";
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
                //proyecto Cierre
                cboproyectoCierre.DataSource = CapaLogica.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString());
                cboproyectoCierre.DisplayMember = "proyecto";
                cboproyectoCierre.ValueMember = "id_proyecto";
                //
                NameEmpresa = cboempresa.SelectedText;
                VerificarsiYaexisteAsiento(true);
            }
        }
        DataTable Tdatos;
        DataTable TDBalance;
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
                VerificarsiYaexisteAsiento(true);
                if (DatosTC.Rows.Count > 0)
                {
                    DataRow FilaTC = DatosTC.Rows[0];
                    //if (chkSaldos.Checked)
                    {
                        //dtgconten.Columns[xProveedor.Name].Visible = dtgconten.Columns[xNumDoc.Name].Visible = dtgconten.Columns[xNameComprobante.Name].Visible = false;
                        Tdatos = CapaLogica.AperturaEjercicio((int)cboempresa.SelectedValue, FechaAñoActual.AddYears(-1));
                        TDBalance = CapaLogica.AperturaEjercicioBalance((int)cboempresa.SelectedValue, FechaAñoActual.AddYears(-1));
                        btnAplicar.Enabled = true;
                        //lbl1.Text = "";
                        if (Tdatos.Rows.Count == 0)
                        {
                            Tdatos = CapaLogica.ResultadoCierre((int)cboempresa.SelectedValue, FechaAñoPasado);
                            TDBalance = CapaLogica.ResultadoCierreBalance((int)cboempresa.SelectedValue, new DateTime(FechaAñoPasado.Year, 1, 1), new DateTime(FechaAñoPasado.Year, 12, 31));
                            dtgcontenBalance.DataSource = TDBalance;
                            GenerarVistaPreliminar(Tdatos, dtgconten);
                            lbl1.Text = "No Existe Asiento.";
                            GenerarLineaBalance(TDBalance);
                        }
                        else
                        {

                            //dtgconten.DataSource = Tdatos;
                            GenerarVistaPreliminar(Tdatos, dtgconten);
                            dtgcontenBalance.DataSource = TDBalance;
                            GenerarLineaBalance(TDBalance);
                        }
                    }
                    lblmsg.Text = $"Total de Registros: Cierre: {dtgconten.RowCount}, Balance: {dtgcontenBalance.RowCount}";
                    if (dtgconten.RowCount == 0)
                    {
                        msg("No Se Encontraron Datos");
                    }
                    //Configuraciones.TiempoEjecucionMsg(aloja);
                }
                else msg("Ingrese el Tipo de Cambio para el Cierre de Este Periodo");
            }
            this.Cursor = Cursors.Default;
            btnExcel.Enabled = true;
        }
        private void GenerarLineaBalance(DataTable TDatosAux)
        {
            Decimal SumaPen = 0, SumaUsd = 0;
            if (TDatosAux.Rows.Count > 0)
            {
                foreach (DataRow item in TDatosAux.Rows)
                {
                    SumaPen += decimal.Parse(item["pen"].ToString());
                    SumaUsd += decimal.Parse(item["usd"].ToString());
                }
            }
            //sumapen <0 = perdida
            //sumapen >=0 Utilidad
            string CuentaResultado = "";
            DataTable Tprueba;
            if (SumaPen < 0)
            {
                Tprueba = CapaLogica.BuscarCuentas("%perdida%acumulada%", 5);
            }
            else
            {
                Tprueba = CapaLogica.BuscarCuentas("%utilidad%acumulada%", 5);
            }
            if (Tprueba.Rows.Count == 0)
            {
                msg("No se Encontro Cuenta de Utilidad y Perdida");
                return;
            }
            DateTime FechaContable = new DateTime(comboMesAño.GetFecha().AddYears(-1).Year, 12, 31);
            TDatosAux.ImportRow(TDatosAux.Rows[0]);
            DataRow Fila = TDatosAux.Rows[TDatosAux.Rows.Count - 1];
            Fila[xCuenta_Contable.DataPropertyName] = Tprueba.Rows[0]["idcuenta"].ToString();
            Fila[xdescripcion.DataPropertyName] = Tprueba.Rows[0]["cuenta_contable"].ToString();
            Fila[xId_Comprobante.DataPropertyName] = 0;
            Fila[xGlosa.DataPropertyName] = $"RESULTADO DEL EJERCICIO {FechaContable.Year}";
            Fila[xpen.DataPropertyName] = SumaPen * -1;
            Fila[xusd.DataPropertyName] = SumaUsd * -1;
            Fila[xcuo.DataPropertyName] = $"{FechaContable.Year.ToString().Substring(2)}13-00001";
            Fila[xFechaContable.DataPropertyName] = FechaContable;
            Fila[xFechaEmision.DataPropertyName] = FechaContable;//  Tprueba.Rows[0]["fechaemision"].ToString();
            Fila[xFechaRegistro.DataPropertyName] = FechaContable;
            Fila[xtipoComprobante.DataPropertyName] = "OTROS";
            Fila[xCod_Comprobante.DataPropertyName] = 0;
            Fila[xNum_Comprobante.DataPropertyName] = $"{FechaContable.ToString("ddMMyy")}";
            Fila[xNum_Doc.DataPropertyName] = "9999";
            Fila[xRazon_Social.DataPropertyName] = "VARIOS";
            DataView dv = new DataView(TDatosAux);
            dv.Sort = "cuenta_contable asc, Cod_Asiento_Contable asc";
            dtgcontenBalance.DataSource = TDBalance = dv.ToTable();
        }
        static decimal SumaSoles = 0, SumaDolares = 0;
        private void GenerarVistaPreliminar(DataTable tdatos, Dtgconten dtgconten)
        {

            if (tdatos.Rows.Count > 0)
            {
                //Tablas
                DataTable TResult = new DataTable();
                DataTable TTemporal = tdatos.Clone();
                DataView dv = new DataView(tdatos);
                DataView dvt = new DataView(TTemporal);
                //
                TResult.Columns.Add("CuentaContable");
                TResult.Columns.Add("SolesDebe", typeof(decimal));
                TResult.Columns.Add("SolesHaber", typeof(decimal));
                TResult.Columns.Add("DolaresDebe", typeof(decimal));
                TResult.Columns.Add("DolaresHaber", typeof(decimal));
                //DataTemporal
                //Asiento 1
                int c = 1;
                dv.RowFilter = "cuenta_contable like '79*'";
                if (dv.ToTable().Rows.Count > 0)
                {
                    DataRow Filax = dv.ToTable().Rows[0];
                    if ((decimal)Filax["pen"] + (decimal)Filax["usd"] != 0)
                    {
                        TResult.Rows.Add($"ASIENTO {c++}");
                        InsertarFilasFiltradas(TResult, dv.ToTable());
                        //dv.Table = tdatos;
                        dv.RowFilter = "cuenta_contable like '95*'";
                        InsertarFilasFiltradas(TResult, dv.ToTable());
                        //dv.Table = tdatos;
                        dv.RowFilter = "cuenta_contable like '96*'";
                        InsertarFilasFiltradas(TResult, dv.ToTable());
                        //dv.Table = tdatos;
                        dv.RowFilter = "cuenta_contable like '97*'";
                        InsertarFilasFiltradas(TResult, dv.ToTable());
                        TResult.Rows.Add("Glosa : Por la cancelacion de cuentas de destino al cierre del ejercicio");
                    }
                }
                //
                //Asiento 2
                dv.RowFilter = "cuenta_contable like '71*'";
                if (dv.ToTable().Rows.Count > 0)
                {
                    DataRow Filax = dv.ToTable().Rows[0];
                    if ((decimal)Filax["pen"] + (decimal)Filax["usd"] != 0)
                    {
                        TResult.Rows.Add();
                        TResult.Rows.Add($"ASIENTO {c++}");
                        InsertarFilasFiltradas(TResult, dv.ToTable());
                        //dv.Table = tdatos;
                        dv.RowFilter = "cuenta_contable like '90*'";
                        InsertarFilasFiltradas(TResult, dv.ToTable());
                        dtgconten.DataSource = TResult;
                        TResult.Rows.Add("Glosa : Por la cancelacion del Costo de producción de inmuebles en Proceso");
                    }
                }
                //
                //Asiento 3 --BIENES
                SumaSoles = SumaDolares = 0;
                dv.RowFilter = "cuenta_contable like '70*' and cuenta_contable not like '704*'";
                if (dv.ToTable().Rows.Count > 0)
                {
                    DataRow Filax = dv.ToTable().Rows[0];
                    if ((decimal)Filax["pen"] + (decimal)Filax["usd"] != 0)
                    {
                        TResult.Rows.Add();
                        TResult.Rows.Add($"ASIENTO {c++}");
                        InsertarFilasFiltradasADD(TResult, dv.ToTable());
                        //dv.Table = tdatos;
                        dv.RowFilter = "cuenta_contable like '69*'";
                        InsertarFilasFiltradasADD(TResult, dv.ToTable());
                        TTemporal.Rows.Add("", "", "8111101", "8111101 - PRODUCCIÓN DE BIENES", SumaSoles, SumaDolares);
                        dvt.RowFilter = "cuenta_contable like '811*'";
                        InsertarFilasFiltradas(TResult, dvt.ToTable());
                        dtgconten.DataSource = TResult;
                        TResult.Rows.Add("Glosa : Por la cancelacion del Costo de producción de inmuebles en Proceso");
                    }
                }
                //Asiento 3.1 --SERVICIOS
                SumaSoles = SumaDolares = 0;
                dv.RowFilter = "cuenta_contable like '704*' ";
                if (dv.ToTable().Rows.Count > 0)
                {
                    DataRow Filax = dv.ToTable().Rows[0];
                    if ((decimal)Filax["pen"] + (decimal)Filax["usd"] != 0)
                    {
                        TResult.Rows.Add();
                        TResult.Rows.Add($"ASIENTO {c++}");
                        InsertarFilasFiltradasADD(TResult, dv.ToTable());
                        //dv.Table = tdatos;
                        //dv.RowFilter = "cuenta_contable like '69*'";
                        //InsertarFilasFiltradasADD(TResult, dv.ToTable());
                        TTemporal.Rows.Add("", "", "8121101", "8121101 - PRODUCCIÓN DE SERVICIOS", SumaSoles, SumaDolares);
                        dvt.RowFilter = "cuenta_contable like '812*'";
                        InsertarFilasFiltradas(TResult, dvt.ToTable());
                        dtgconten.DataSource = TResult;
                        TResult.Rows.Add("Glosa : Por el cierre del saldo de la cuenta de Servicios");
                    }
                }
                //Asiento 4.1 --SERVICIOS
                SumaDolares = SumaSoles = 0;
                dvt.RowFilter = "cuenta_contable like '812*'";
                if (dvt.ToTable().Rows.Count > 0)
                {
                    DataRow Filax = dvt.ToTable().Rows[0];
                    if ((decimal)Filax["pen"] + (decimal)Filax["usd"] != 0)
                    {
                        VoltearValores(TTemporal, "812");
                        dvt.RowFilter = "cuenta_contable like '812*'";
                        TResult.Rows.Add();
                        TResult.Rows.Add($"ASIENTO {c++}");
                        InsertarFilasFiltradasADD(TResult, dvt.ToTable());
                        TrasladarSaldo("812", "8211101", "8211101 - VALOR AGREGADO", TTemporal);
                        //
                        dvt.RowFilter = "cuenta_contable like '82*'";
                        InsertarFilasFiltradas(TResult, dvt.ToTable());
                        dtgconten.DataSource = TResult;
                        TResult.Rows.Add("Glosa : Por el cierre del saldo acreedor de la cuenta de Producción al cierre del ejercicio");
                    }
                }
                //Asiento 4
                SumaDolares = SumaSoles = 0;
                dvt.RowFilter = "cuenta_contable like '811*'";
                if (dvt.ToTable().Rows.Count > 0)
                {
                    DataRow Filax = dvt.ToTable().Rows[0];
                    if ((decimal)Filax["pen"] + (decimal)Filax["usd"] != 0)
                    {
                        VoltearValores(TTemporal, "81");
                        dvt.RowFilter = "cuenta_contable like '811*'";
                        TResult.Rows.Add();
                        TResult.Rows.Add($"ASIENTO {c++}");
                        InsertarFilasFiltradasADD(TResult, dvt.ToTable());
                        TrasladarSaldo("811", "8211101", "8211101 - VALOR AGREGADO", TTemporal);
                        //
                        dvt.RowFilter = "cuenta_contable like '82*'";
                        InsertarFilasFiltradas(TResult, dvt.ToTable());
                        dtgconten.DataSource = TResult;
                        TResult.Rows.Add("Glosa : Por el cierre del saldo acreedor de la cuenta de Producción al cierre del ejercicio");
                    }
                }
                //Asiento 5
                SumaDolares = SumaSoles = 0;
                dv.RowFilter = "cuenta_contable like '63*'";
                if (dv.ToTable().Rows.Count > 0)
                {
                    DataRow Filax = dv.ToTable().Rows[0];
                    if ((decimal)Filax["pen"] + (decimal)Filax["usd"] != 0)
                    {
                        TResult.Rows.Add();
                        TResult.Rows.Add($"ASIENTO {c++}");
                        //InsertarFilasFiltradasContra(TResult, dv.ToTable(), "8211101", "8211101 - VALOR AGREGADO", TTemporal);
                        InsertarFilasFiltradasADD(TResult, dv.ToTable());
                        TrasladarSaldo("8211101", "8211101 - VALOR AGREGADO", TTemporal);
                        InsertarFilasFiltradasMonto("8211101 - VALOR AGREGADO", TResult, TTemporal);
                        dtgconten.DataSource = TResult;
                        TResult.Rows.Add("Glosa : Por el cierre de la cuenta de gastos de servicios prestados por terceros al cierre de ejercicio");
                    }
                }
                //Asiento 6
                SumaDolares = SumaSoles = 0;
                dvt.RowFilter = "cuenta_contable like '82*'";
                if (dvt.ToTable().Rows.Count > 0)
                {
                    DataRow Filax = dvt.ToTable().Rows[0];
                    if ((decimal)Filax["pen"] + (decimal)Filax["usd"] != 0)
                    {
                        VoltearValores(TTemporal, "82");
                        dvt.RowFilter = "cuenta_contable like '82*'";
                        TResult.Rows.Add();
                        TResult.Rows.Add($"ASIENTO {c++}");
                        InsertarFilasFiltradasADD(TResult, dvt.ToTable());
                        //InsertarFilasFiltradasContra(TResult, dvt.ToTable(), "8311101", "8311101 - EXCEDENTE BRUTO (INSUFICIENCIA BRUTA) DE EXPLOTACIÓN", TTemporal);
                        TrasladarSaldo("82", "8311101", "8311101 - EXCEDENTE BRUTO (INSUFICIENCIA BRUTA) DE EXPLOTACIÓN", TTemporal);
                        dvt.RowFilter = "cuenta_contable like '83*'";
                        InsertarFilasFiltradas(TResult, dvt.ToTable());
                        dtgconten.DataSource = TResult;
                        TResult.Rows.Add("Glosa : Por la cancelación del valor agregado");
                    }
                }
                //Asiento 7
                SumaDolares = SumaSoles = 0;
                int contador = 0;
                dv.RowFilter = "cuenta_contable like '64*'";
                contador += dv.ToTable().Rows.Count;
                dv.RowFilter = "cuenta_contable like '62*'";
                contador += dv.ToTable().Rows.Count;
                if (contador > 0)
                {
                    TResult.Rows.Add();
                    TResult.Rows.Add($"ASIENTO {c++}");
                    InsertarFilasFiltradasADD(TResult, dv.ToTable());
                    dv.RowFilter = "cuenta_contable like '64*'";
                    InsertarFilasFiltradasADD(TResult, dv.ToTable());
                    //InsertarFilasFiltradasContra(TResult, dvt.ToTable(), "8311101", "8311101 - EXCEDENTE BRUTO (INSUFICIENCIA BRUTA) DE EXPLOTACIÓN", TTemporal);
                    TrasladarSaldo("8311101", "8311101 - EXCEDENTE BRUTO (INSUFICIENCIA BRUTA) DE EXPLOTACIÓN", TTemporal);
                    InsertarFilasFiltradasMonto("8311101 - EXCEDENTE BRUTO (INSUFICIENCIA BRUTA) DE EXPLOTACIÓN", TResult, TTemporal);
                    dtgconten.DataSource = TResult;
                    TResult.Rows.Add("Glosa : Por el cierre de las cuentas de gasto del personal al cierre del ejercicio");
                }
                //Asiento 8
                SumaDolares = SumaSoles = 0;
                dvt.RowFilter = "cuenta_contable like '83*'";
                if (dvt.ToTable().Rows.Count > 0)
                {
                    VoltearValores(TTemporal, "83");
                    dvt.RowFilter = "cuenta_contable like '83*'";
                    TResult.Rows.Add();
                    TResult.Rows.Add($"ASIENTO {c++}");
                    InsertarFilasFiltradasADD(TResult, dvt.ToTable());
                    TrasladarSaldo("83", "8411101", "8411101 - RESULTADO DE EXPLOTACION", TTemporal);
                    dvt.RowFilter = "cuenta_contable like '84*'";
                    InsertarFilasFiltradas(TResult, dvt.ToTable());
                    dtgconten.DataSource = TResult;
                    TResult.Rows.Add("Glosa : Por la cancelación del excedente de Revaluación");
                }
                //Asiento 9
                SumaDolares = SumaSoles = 0;
                contador = 0;
                dv.RowFilter = "cuenta_contable like '68*'";
                contador += dv.ToTable().Rows.Count;
                dv.RowFilter = "cuenta_contable like '65*'";
                contador += dv.ToTable().Rows.Count;
                if (contador > 0)
                {
                    TResult.Rows.Add();
                    TResult.Rows.Add($"ASIENTO {c++}");
                    InsertarFilasFiltradasADD(TResult, dv.ToTable());
                    dv.RowFilter = "cuenta_contable like '68*'";
                    InsertarFilasFiltradasADD(TResult, dv.ToTable());
                    //InsertarFilasFiltradasContra(TResult, dvt.ToTable(), "8311101", "8311101 - EXCEDENTE BRUTO (INSUFICIENCIA BRUTA) DE EXPLOTACIÓN", TTemporal);
                    TrasladarSaldo("8411101", "8411101 - RESULTADO DE EXPLOTACION", TTemporal);
                    InsertarFilasFiltradasMonto("8411101 - RESULTADO DE EXPLOTACION", TResult, TTemporal);
                    dtgconten.DataSource = TResult;
                    TResult.Rows.Add("Glosa : Por el cierre de las cargas diversas y provisiones del ejercicio");
                }
                //Asiento 10
                SumaDolares = SumaSoles = 0;
                dv.RowFilter = "cuenta_contable like '75*'";
                if (dv.ToTable().Rows.Count > 0)
                {
                    DataRow Filax = dv.ToTable().Rows[0];
                    if ((decimal)Filax["pen"] + (decimal)Filax["usd"] != 0)
                    {
                        TResult.Rows.Add();
                        TResult.Rows.Add($"ASIENTO {c++}");
                        InsertarFilasFiltradasADD(TResult, dv.ToTable());
                        TrasladarSaldo("8411101", "8411101 - RESULTADO DE EXPLOTACION", TTemporal);
                        InsertarFilasFiltradasMonto("8411101 - RESULTADO DE EXPLOTACION", TResult, TTemporal);
                        dtgconten.DataSource = TResult;
                        TResult.Rows.Add("Glosa : Por el cierre de la cuenta de otros ingresos");
                    }
                }
                //Asiento 11
                SumaDolares = SumaSoles = 0;
                dvt.RowFilter = "cuenta_contable like '84*'";
                if (dvt.ToTable().Rows.Count > 0)
                {
                    VoltearValores(TTemporal, "84");
                    dvt.RowFilter = "cuenta_contable like '84*'";
                    TResult.Rows.Add();
                    TResult.Rows.Add($"ASIENTO {c++}");
                    InsertarFilasFiltradasADD(TResult, dvt.ToTable());
                    //InsertarFilasFiltradasContra(TResult, dvt.ToTable(), "8311101", "8311101 - EXCEDENTE BRUTO (INSUFICIENCIA BRUTA) DE EXPLOTACIÓN", TTemporal);
                    TrasladarSaldo("84", "8511101", "8511101 - RESULTADO ANTES DE PARTICIPACIONES E IMPUESTOS", TTemporal);
                    dvt.RowFilter = "cuenta_contable like '85*'";
                    InsertarFilasFiltradas(TResult, dvt.ToTable());
                    dtgconten.DataSource = TResult;
                    TResult.Rows.Add("Glosa : Por el cierre de la cuenta resultados de explotación");
                }
                //Asiento 12
                SumaDolares = SumaSoles = 0;
                dv.RowFilter = "cuenta_contable like '67*'";
                if (dv.ToTable().Rows.Count > 0)
                {
                    DataRow Filax = dv.ToTable().Rows[0];
                    if ((decimal)Filax["pen"] + (decimal)Filax["usd"] != 0)
                    {
                        TResult.Rows.Add();
                        TResult.Rows.Add($"ASIENTO {c++}");
                        InsertarFilasFiltradasADD(TResult, dv.ToTable());
                        //InsertarFilasFiltradasContra(TResult, dvt.ToTable(), "8311101", "8311101 - EXCEDENTE BRUTO (INSUFICIENCIA BRUTA) DE EXPLOTACIÓN", TTemporal);
                        TrasladarSaldo("8511101", "8511101 - RESULTADO ANTES DE PARTICIPACIONES E IMPUESTOS", TTemporal);
                        InsertarFilasFiltradasMonto("8511101 - RESULTADO ANTES DE PARTICIPACIONES E IMPUESTOS", TResult, TTemporal);
                        dtgconten.DataSource = TResult;
                        TResult.Rows.Add("Glosa : Por el cierre de la cuenta de gastos financieros");
                    }
                }
                //Asiento 13
                SumaDolares = SumaSoles = 0;
                dv.RowFilter = "cuenta_contable like '77*'";
                if (dv.ToTable().Rows.Count > 0)
                {
                    DataRow Filax = dv.ToTable().Rows[0];
                    if ((decimal)Filax["pen"] + (decimal)Filax["usd"] != 0)
                    {
                        TResult.Rows.Add();
                        TResult.Rows.Add($"ASIENTO {c++}");
                        InsertarFilasFiltradasADD(TResult, dv.ToTable());
                        //InsertarFilasFiltradasContra(TResult, dvt.ToTable(), "8311101", "8311101 - EXCEDENTE BRUTO (INSUFICIENCIA BRUTA) DE EXPLOTACIÓN", TTemporal);
                        TrasladarSaldo("8511101", "8511101 - RESULTADO ANTES DE PARTICIPACIONES E IMPUESTOS", TTemporal);
                        InsertarFilasFiltradasMonto("8511101 - RESULTADO ANTES DE PARTICIPACIONES E IMPUESTOS", TResult, TTemporal);
                        dtgconten.DataSource = TResult;
                        TResult.Rows.Add("Glosa : Por el cierre de la cuenta de gastos financieros");
                    }
                }
                //8921101 - PÉRDIDA
                //8911101 - UTILIDAD
                //Asiento 14
                TResult.Rows.Add();
                SumaDolares = SumaSoles = 0;
                TResult.Rows.Add($"ASIENTO {c++}");
                string CuentaResultado = "";
                string CuentaResul = "";
                dvt.RowFilter = "cuenta_contable like '85*'";
                if ((decimal)dvt[0]["pen"] < 0)
                {
                    CuentaResultado = "8911101 - UTILIDAD";
                    CuentaResul = "8911101";
                }
                else
                {
                    CuentaResultado = "8921101 - PÉRDIDA";
                    CuentaResul = "8921101";
                }
                VoltearValores(TTemporal, "85");
                dvt.RowFilter = "cuenta_contable like '85*'";
                InsertarFilasFiltradasADD(TResult, dvt.ToTable());
                //InsertarFilasFiltradasContra(TResult, dvt.ToTable(), "8311101", "8311101 - EXCEDENTE BRUTO (INSUFICIENCIA BRUTA) DE EXPLOTACIÓN", TTemporal);
                TrasladarSaldo("85", CuentaResul, CuentaResultado, TTemporal);
                dvt.RowFilter = "cuenta_contable like '89*'";
                InsertarFilasFiltradas(TResult, dvt.ToTable());
                dtgconten.DataSource = TResult;
                TResult.Rows.Add("Glosa : Por la cancelación del resultado antes de participación e impuestos");
                //Asiento 15
                SumaDolares = SumaSoles = 0;
                dv.RowFilter = "cuenta_contable like '882*'";
                if (dv.ToTable().Rows.Count > 0)
                {
                    TResult.Rows.Add();
                    TResult.Rows.Add($"ASIENTO {c++}");
                    InsertarFilasFiltradasADD(TResult, dv.ToTable());
                    //InsertarFilasFiltradasContra(TResult, dvt.ToTable(), "8311101", "8311101 - EXCEDENTE BRUTO (INSUFICIENCIA BRUTA) DE EXPLOTACIÓN", TTemporal);
                    TrasladarSaldo(CuentaResul, CuentaResultado, TTemporal);
                    InsertarFilasFiltradasMonto(CuentaResultado, TResult, TTemporal);
                    dtgconten.DataSource = TResult;
                    TResult.Rows.Add("Glosa : Por el cierre de la cuenta Impuesto a la renta Diferido");
                }
                //Asiento 16
                SumaDolares = SumaSoles = 0;
                dv.RowFilter = "cuenta_contable like '881*'";
                if (dv.ToTable().Rows.Count > 0)
                {
                    TResult.Rows.Add();
                    TResult.Rows.Add($"ASIENTO {c++}");
                    InsertarFilasFiltradasADD(TResult, dv.ToTable());
                    //InsertarFilasFiltradasContra(TResult, dvt.ToTable(), "8311101", "8311101 - EXCEDENTE BRUTO (INSUFICIENCIA BRUTA) DE EXPLOTACIÓN", TTemporal);
                    TrasladarSaldo(CuentaResul, CuentaResultado, TTemporal);
                    InsertarFilasFiltradasMonto(CuentaResultado, TResult, TTemporal);
                    dtgconten.DataSource = TResult;
                    TResult.Rows.Add("Glosa : Por el cierre de la cuenta Impuesto a la renta Corriente");
                }
                //Asiento 17
                TResult.Rows.Add();
                SumaDolares = SumaSoles = 0;
                TResult.Rows.Add($"ASIENTO {c++}");
                VoltearValores(TTemporal, CuentaResul.Substring(0, 2));
                dvt.RowFilter = $"cuenta_contable like '{CuentaResul.Substring(0, 2)}*'";
                string CuentaResultadoX = "";
                string CuentaResulX = "";
                if ((decimal)dvt[0]["pen"] < 0)
                {
                    CuentaResultadoX = "5911101 - UTILIDADES ACUMULADAS";
                    CuentaResulX = "5911101";
                }
                else
                {
                    CuentaResultadoX = "5921101 - PERDIDAS ACUMULADAS";
                    CuentaResulX = "5921101";
                }
                InsertarFilasFiltradasADD(TResult, dvt.ToTable());
                //InsertarFilasFiltradasContra(TResult, dvt.ToTable(), "8311101", "8311101 - EXCEDENTE BRUTO (INSUFICIENCIA BRUTA) DE EXPLOTACIÓN", TTemporal);
                TrasladarSaldo(CuentaResul.Substring(0, 2), CuentaResulX, CuentaResultadoX, TTemporal);
                dvt.RowFilter = $"cuenta_contable like '{CuentaResultadoX.Substring(0, 2)}*'";
                InsertarFilasFiltradas(TResult, dvt.ToTable());
                dtgconten.DataSource = TResult;
                TResult.Rows.Add($"Glosa : Resultado del ejercicio {comboMesAño.GetFecha().Year - 1}");
            }
            else { msg("No Hay Datos"); }
        }
        private void InsertarFilasFiltradasMonto(string NameCuentaCompleto, DataTable tResultado, DataTable tTemporal)
        {
            DataRow dt = tResultado.NewRow();
            dt[0] = NameCuentaCompleto;
            //dt[1] = (decimal)item["pen"] > 0 ? item["DESCRIPCION"] : "";
            dt[1] = SumaSoles < 0 ? Math.Abs(SumaSoles) : 0;
            dt[2] = SumaSoles > 0 ? SumaSoles : 0;
            dt[3] = SumaDolares < 0 ? Math.Abs(SumaDolares) : 0;
            dt[4] = SumaDolares > 0 ? SumaDolares : 0;
            //
            tResultado.Rows.Add(dt);
        }
        private void TrasladarSaldo(string v1, string v2, string v3, DataTable temporal)
        {
            Boolean Encontrado = false;
            foreach (DataRow item in temporal.Rows)
            {
                if (item["Cuenta_contable"].ToString().Substring(0, v1.Length) == v1)
                {
                    SumaSoles = (decimal)item["pen"];
                    SumaDolares = (decimal)item["usd"];
                    item["pen"] = 0;
                    item["usd"] = 0;
                }
                if (item["cuenta_contable"].ToString() == v2)
                {
                    Encontrado = true;
                    item["pen"] = -(decimal)item["pen"] + SumaSoles;
                    item["usd"] = -(decimal)item["usd"] + SumaDolares;
                }
            }
            if (!Encontrado)
            {
                temporal.Rows.Add("", "", v2, v3, -SumaSoles, -SumaDolares);
            }
        }
        private void TrasladarSaldo(string v2, string v3, DataTable temporal)
        {
            Boolean Encontrado = false;
            foreach (DataRow item in temporal.Rows)
            {
                if (item["cuenta_contable"].ToString() == v2)
                {
                    Encontrado = true;
                    item["pen"] = (decimal)item["pen"] + SumaSoles;
                    item["usd"] = (decimal)item["usd"] + SumaDolares;
                }
            }
            if (!Encontrado)
            {
                temporal.Rows.Add("", "", v2, v3, SumaSoles, SumaDolares);
            }
        }
        private void InsertarFilasFiltradasContra(DataTable tResultado, DataTable dView, string v1, string v2, DataTable tTemporal)
        {
            foreach (DataRow item in dView.Rows)
            {
                if ((decimal)item["pen"] + (decimal)item["usd"] != 0)
                {
                    //Sumatorias
                    SumaSoles -= (decimal)item["pen"];
                    SumaDolares -= (decimal)item["usd"];
                    //FinSumas
                    DataRow dt = tResultado.NewRow();
                    dt[0] = (decimal)item["pen"] < 0 ? item["DESCRIPCION"] : item["DESCRIPCION"];
                    //dt[1] = (decimal)item["pen"] > 0 ? item["DESCRIPCION"] : "";
                    dt[1] = (decimal)item["pen"] < 0 ? Math.Abs((decimal)item["pen"]) : 0;
                    dt[2] = (decimal)item["pen"] > 0 ? (decimal)item["pen"] : 0;
                    dt[3] = (decimal)item["usd"] < 0 ? Math.Abs((decimal)item["usd"]) : 0;
                    dt[4] = (decimal)item["usd"] > 0 ? (decimal)item["usd"] : 0;
                    //
                    tResultado.Rows.Add(dt);
                }
            }
            //Agregamos la Contra
            DataRow dt1 = tResultado.NewRow();
            dt1[0] = v2;
            //dt[1] = (decimal)item["pen"] > 0 ? item["DESCRIPCION"] : "";
            dt1[1] = SumaSoles < 0 ? Math.Abs(SumaSoles) : 0;
            dt1[2] = SumaSoles > 0 ? SumaSoles : 0;
            dt1[3] = SumaDolares < 0 ? Math.Abs(SumaDolares) : 0;
            dt1[4] = SumaDolares > 0 ? SumaDolares : 0;
            //
            tResultado.Rows.Add(dt1);
            //Agregamos al Temporal        
            Boolean Encontrado = false;
            foreach (DataRow item in tTemporal.Rows)
            {
                if (item["cuenta_contable"].ToString() == v1)
                {
                    item["pen"] = (decimal)item["pen"] + SumaSoles;
                    item["usd"] = (decimal)item["usd"] + SumaDolares;
                    Encontrado = true;
                    break;
                }
            }
            if (!Encontrado)
            {
                tTemporal.Rows.Add("", "", v1, v2, -SumaSoles, -SumaDolares);
            }

        }

        private void VoltearValores(DataTable temporal, string v)
        {
            foreach (DataRow item in temporal.Rows)
            {
                if (item["cuenta_contable"].ToString().Substring(0, v.Length) == v)
                {
                    item["pen"] = (decimal)item["pen"] * -1;
                    item["usd"] = (decimal)item["usd"] * -1;
                }
            }
        }

        private void InsertarFilasFiltradasADD(DataTable tResultado, DataTable dView)
        {
            foreach (DataRow item in dView.Rows)
            {
                if ((decimal)item["pen"] + (decimal)item["usd"] != 0)
                {
                    //Sumatorias
                    SumaSoles -= (decimal)item["pen"];
                    SumaDolares -= (decimal)item["usd"];
                    //FinSumas
                    DataRow dt = tResultado.NewRow();
                    dt[0] = (decimal)item["pen"] < 0 ? item["DESCRIPCION"] : item["DESCRIPCION"];
                    //dt[1] = (decimal)item["pen"] > 0 ? item["DESCRIPCION"] : "";
                    dt[1] = (decimal)item["pen"] < 0 ? Math.Abs((decimal)item["pen"]) : 0;
                    dt[2] = (decimal)item["pen"] > 0 ? (decimal)item["pen"] : 0;
                    dt[3] = (decimal)item["usd"] < 0 ? Math.Abs((decimal)item["usd"]) : 0;
                    dt[4] = (decimal)item["usd"] > 0 ? (decimal)item["usd"] : 0;
                    //
                    tResultado.Rows.Add(dt);
                }
            }
        }

        private void InsertarFilasFiltradas(DataTable tResultado, DataTable dView)
        {
            foreach (DataRow item in dView.Rows)
            {
                if ((decimal)item["pen"] + (decimal)item["usd"] != 0)
                {
                    DataRow dt = tResultado.NewRow();
                    dt[0] = (decimal)item["pen"] < 0 ? item["DESCRIPCION"] : item["DESCRIPCION"];
                    //dt[1] = (decimal)item["pen"] > 0 ? item["DESCRIPCION"] : "";
                    dt[1] = (decimal)item["pen"] < 0 ? Math.Abs((decimal)item["pen"]) : 0;
                    dt[2] = (decimal)item["pen"] > 0 ? (decimal)item["pen"] : 0;
                    dt[3] = (decimal)item["usd"] < 0 ? Math.Abs((decimal)item["usd"]) : 0;
                    dt[4] = (decimal)item["usd"] > 0 ? (decimal)item["usd"] : 0;
                    //
                    tResultado.Rows.Add(dt);
                }
            }
        }

        private void dtgconten1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private int DinamicaCierre = -30;
        private int DinamicaApertura = -30;
        frmProcesando frmprocesando;
        private void btncerrar_Click(object sender, EventArgs e)
        {
            if (cboempresa.SelectedValue == null) { msg("Selecione una Empresa"); cboempresa.Focus(); return; }
            if (cboproyectoCierre.SelectedValue == null) { msg("Selecciones un Proyecto"); cboproyectoCierre.Focus(); return; }
            if (dtgconten.RowCount == 0) { msg("No Hay filas para Generar el Asiento"); return; }
            if (rbCierre.Checked && !rbCierre.Enabled) { msg("No se Puede Aplicar Asiento de Cierre"); return; }
            if (rbApertura.Checked && !rbApertura.Enabled) { msg("No se Puede Aplicar Asiento de Apertura"); return; }
            //validamos que este todos los periodos Cerrados
            Boolean Validar = false;
            for (int i = 1; i < 12; i++)
            {
                DateTime FechaPrueba = new DateTime(comboMesAño.GetFecha().Year - 1, i, 1);
                if (CapaLogica.VerificarPeriodoAbierto((int)cboempresa.SelectedValue, FechaPrueba))
                {
                    Validar = true;
                }
            }
            if (Validar)
            {
                msg("Cierre Todos los Periodos de la Empresa Seleccionada."); return;
            }
            //if (VerificarsiYaexisteAsiento()) { msg("Ya Existe un Asiento de Apertura para este Año"); return; }
            //Dinamica para el Cierre Mensual
            DateTime FechaContable = new DateTime(comboMesAño.FechaFinMes.Year, 1, 1);
            ///////                   
            Cursor = Cursors.WaitCursor;
            decimal TC = CapaLogica.TipoCambioDia("venta", new DateTime(comboMesAño.GetFecha().Year - 1, 12, 31));
            //Grabamos los Datos a la Tablas!
            if (rbCierre.Checked && rbCierre.Enabled)
            {
                foreach (DataRow item in Tdatos.Rows)
                {
                    //Inserto en la Tabla Los valores delos SAldos Contables para la apertura del año siguiente
                    CapaLogica.AperturaEjercicio(1, item["ruc"].ToString(), (int)cboempresa.SelectedValue, FechaContable.AddYears(-1),
                        item["cuenta_contable"].ToString(), item["descripcion"].ToString(), (decimal)item["pen"], (decimal)item["usd"]);
                }
                int x = 0;
                foreach (DataRow item in TDBalance.Rows)
                {
                    //Inserto en la Tabla Los valores del del cierre balance
                    if (x != TDBalance.Rows.Count - 1)
                    {
                        CapaLogica.AperturaEjercicioBalance(1, (int)cboempresa.SelectedValue, item[xcuo.DataPropertyName].ToString(), (DateTime)item[xFechaContable.DataPropertyName],
                          (DateTime)item[xFechaRegistro.DataPropertyName],
                          (DateTime?)(item[xFechaEmision.DataPropertyName].ToString() == "" ? null : (DateTime?)item[xFechaEmision.DataPropertyName]), (int)item[xId_Comprobante.DataPropertyName],
                          item[xCod_Comprobante.DataPropertyName].ToString(), item[xNum_Comprobante.DataPropertyName].ToString(), item[xNum_Doc.DataPropertyName].ToString(),
                          item[xRazon_Social.DataPropertyName].ToString(), item[xGlosa.DataPropertyName].ToString(), item[xCuenta_Contable.DataPropertyName].ToString(),
                          item[xdescripcion.DataPropertyName].ToString(), (int)(item[xCtaBancaria.DataPropertyName].ToString() == "" ? 0 : item[xCtaBancaria.DataPropertyName]),
                          item[xCuentaBanco.DataPropertyName].ToString(), item[xmoneda.DataPropertyName].ToString(),
                          (decimal)item[xpen.DataPropertyName], (decimal)item[xusd.DataPropertyName], (decimal)item[xtipocambio.DataPropertyName]);
                        x++;
                    }
                }
            }
            if (rbCierre.Checked && rbCierre.Enabled)
            {
                FechaContable = new DateTime(comboMesAño.FechaFinMes.Year - 1, 12, 31);
                string mensaje = "Se Agregaron los Asientos de Cierre";
                DinamicaApertura = -51;
                DinamicaCierre = -50;
                int PosI = 0, PosF = 0;
                DataTable TDatos = ((DataTable)dtgconten.DataSource).Copy();
                int Largo = TDatos.Rows.Count;
                int c = 0;
                int contador = 0;
                do
                {
                    for (int i = contador; i < Largo; i++)
                    {
                        //Buscamos el Valor Inicial
                        if (TDatos.Rows[i]["cuentacontable"].ToString().Contains("ASIENTO"))
                        {
                            PosI = i;
                            c++;
                        }
                        if (TDatos.Rows[i]["cuentacontable"].ToString().Contains("Glosa"))
                        {
                            PosF = i - 1;
                            contador = i + 1;
                            break;
                        }
                    }
                    //Cierre
                    Boolean Debe = true;
                    GrabarAsientos(TDatos, c, FechaContable, PosI, PosF, DinamicaCierre, (int)cboproyectoCierre.SelectedValue, Debe, TC);
                } while (Largo - 1 > PosF + 1);
                //Grabar el Detalle y Cabecera de la dinamica de Cierre Balances; Sentido = los pasa del debe al haber
                GrabarAsientosApertura(TDBalance, ++c, FechaContable, TC, -50, true);
                //Fin del Grabado.
                //Eliminamos los REflejos
                CapaLogica.ELiminarReflejosdeCierreApertura(comboMesAño.GetFecha(), (int)(cboempresa.SelectedValue));
                msgOK(mensaje);
                //btnAplicar.Enabled = false;
                GenerarAsientoAPertura = false;
                lbl1.Text = "Asientos Generados.";
                rbCierre.Enabled = false;
            }
            else if (rbApertura.Checked && rbApertura.Enabled)
            {
                DateTime FechitaContable = new DateTime(comboMesAño.GetFecha().Year, 1, 1);
                //DataTable TablaReflejo = TDBalance.Copy();
                //TablaReflejo.Rows.RemoveAt(TablaReflejo.Rows.Count - 1);
                GrabarAsientosApertura(TDBalance, 1, FechaContable, TC, -51, false);
                btnAplicar.Enabled = false;
                GenerarAsientoAPertura = false;
                msgOK("Se Agregaron los Asientos de Apertura");
                lbl1.Text = "Asientos Generados.";
                rbApertura.Enabled = false;
            }
            Cursor = Cursors.Default;
            VerificarsiYaexisteAsiento(false);
        }
        private void GrabarAsientosApertura(DataTable TablaDatos, int NumAsiento, DateTime FechaContable, decimal TC, int iddinamica, Boolean Sentido)
        {
            DataView DViewAux = TablaDatos.AsDataView();
            string CuentaContable = "";
            string CuentaAux = "";
            int PosFila = 1;
            foreach (DataRow item in TablaDatos.Rows)
            {
                CuentaAux = item[xCuenta_Contable.DataPropertyName].ToString();
                if (CuentaContable != CuentaAux)
                {
                    CuentaContable = CuentaAux;
                    DViewAux.RowFilter = $"cuenta_contable like '{CuentaContable}'";
                    //en el DataView Esta el Filtro de todo los datos ue se deben grabar
                    //Sacamos el Total que va a ir a la cabecera;
                    decimal SumatoriaPEN = 0, SumatoriaUSD = 0;
                    foreach (DataRow DVFila in DViewAux.ToTable().Rows)
                    {
                        SumatoriaPEN += (decimal)DVFila[xpen.DataPropertyName];
                        SumatoriaUSD += (decimal)DVFila[xusd.DataPropertyName];
                    }
                    SumatoriaPEN = SumatoriaPEN * (Sentido ? 1 : -1);
                    SumatoriaUSD = SumatoriaUSD * (Sentido ? 1 : -1);
                    //Ya tenemos el Total de la Cabecera,
                    //Sì es Diferente de Cero es que si tiene Saldo
                    if (SumatoriaPEN != 0 && SumatoriaUSD != 0)
                    {
                        //Declaraciones y definiciones
                        int fkProyecto = (int)cboproyectoCierre.SelectedValue;
                        int IdSoles = 1;
                        string CaracterFueraMes = Sentido ? "13" : "00";
                        string cuo = $"{FechaContable.Year.ToString().Substring(2, 2) }{CaracterFueraMes}-{NumAsiento.ToString("00000")}";
                        //fin dec y def
                        decimal ValorDebeMN = 0;
                        decimal ValorHaberMN = 0;
                        //Calculos
                        //positivo = haber ; negativo = debe
                        if (SumatoriaPEN < 0)
                        {
                            ValorDebeMN = Math.Abs(SumatoriaPEN); ValorHaberMN = 0;
                        }
                        else
                        {
                            ValorDebeMN = 0; ValorHaberMN = Math.Abs(SumatoriaPEN);
                        }
                        //fin Calculos
                        //string GLOSA = $"RESULTADO DEL EJERCICIO {comboMesAño.GetFecha().Year - 1}";
                        string GLOSA = $"CANCELACION DE CUENTAS DE BALANCE";
                        if (!Sentido) GLOSA = $"ASIENTOS DE APERTURA {FechaContable.Year}";
                        CapaLogica.InsertarAsientoFacturaCabecera(1, PosFila++, NumAsiento, FechaContable, CuentaContable, ValorDebeMN, ValorHaberMN, TC,
                            fkProyecto, 0, cuo, IdSoles, GLOSA, FechaContable, iddinamica);
                        //Detalle del asiento del Debe      
                        foreach (DataRow DVFila in DViewAux.ToTable().Rows)
                        {
                            int TipoIdProveedor = (int)DVFila[xTipo_Doc.DataPropertyName];
                            string RucProveedor = DVFila[xNum_Doc.DataPropertyName].ToString();
                            string NameProveedor = DVFila[xRazon_Social.DataPropertyName].ToString();
                            int IdUsuario = frmLogin.CodigoUsuario;
                            int idcomprobante = (int)DVFila[xId_Comprobante.DataPropertyName];
                            string SerieDocumento = DVFila[xCod_Comprobante.DataPropertyName].ToString();
                            string NumDocumento = DVFila[xNum_Comprobante.DataPropertyName].ToString();
                            decimal ValorDolares = (decimal)DVFila[xusd.DataPropertyName] * (Sentido ? 1 : -1) * (ValorDebeMN < ValorHaberMN ? 1 : -1);
                            decimal ValorSoles = (decimal)DVFila[xpen.DataPropertyName] * (Sentido ? 1 : -1) * (ValorDebeMN < ValorHaberMN ? 1 : -1);
                            GLOSA = DVFila[xGlosa.DataPropertyName].ToString();
                            string NroCuentaBancaria = DVFila[xCuentaBanco.DataPropertyName].ToString();
                            IdSoles = DVFila[xmoneda.DataPropertyName].ToString() == "PEN" ? 1 : 2;
                            DateTime FechaEmision = DVFila[xFechaEmision.DataPropertyName].ToString() == "" ? FechaContable : (DateTime)DVFila[xFechaEmision.DataPropertyName];
                            //
                            CapaLogica.InsertarAsientoFacturaDetalle(99, PosFila - 1, NumAsiento, FechaContable, CuentaContable, fkProyecto, TipoIdProveedor, RucProveedor,
                            NameProveedor, idcomprobante, SerieDocumento, NumDocumento, iddinamica, FechaEmision, FechaContable, FechaContable,
                            ValorSoles, ValorDolares, TC, IdSoles, NroCuentaBancaria, "", GLOSA, FechaContable, IdUsuario, "");
                        }
                    }
                }
            }
        }
        private void GrabarAsientos(DataTable datos, int NumAsiento, DateTime fechaContable, int posI, int posF, int dinamica, int pkproyecto, bool debe, decimal TC)
        {
            int pase = 0;
            for (int i = posI + 1; i <= posF; i++)
            {
                pase++;
                DataRow DFila = datos.Rows[i];
                string[] Proveedor = "0-9999".Split('-');
                int TipoIdProveedor = int.Parse(Proveedor[0]);
                string RucProveedor = Proveedor[1];
                string NameProveedor = "VARIOS";
                int idcomprobante = 0;
                string[] NumDoc = "0-0".Split('-');
                string SerieDocumento = NumDoc[0];
                string NumDocumento = NumDoc[1];
                string Glosa = datos.Rows[posF + 1]["cuentacontable"].ToString().Substring(8).Trim().ToUpper();
                int IdUsuario = frmLogin.CodigoUsuario;
                int fkProyecto = pkproyecto;
                int TipoPago = 0;
                string NroPago = "";
                int IdSoles = 1, IdDolares = 2;
                string CuentaContable = DFila["Cuentacontable"].ToString().Substring(0, DFila["Cuentacontable"].ToString().IndexOf(' '));
                string CaracterFueraMes = debe ? "13" : "00";
                string cuo = $"{fechaContable.Year.ToString().Substring(2, 2) }{CaracterFueraMes}-{NumAsiento.ToString("00000")}";
                string NroCuentaBancaria = "";
                ////Sacando los Valores
                decimal ValorDebeMN = 0, ValorHaberMN = 0, ValorDebeME = 0, ValorHaberME = 0, ValorDolares = 0;
                //solesdebe soleshaber dolaresdebe dolareshaber
                ValorDebeMN = debe ? (decimal)DFila["solesdebe"] : (decimal)DFila["Soleshaber"];
                ValorHaberMN = debe ? (decimal)DFila["soleshaber"] : (decimal)DFila["solesdebe"];
                ValorDebeME = debe ? (decimal)DFila["dolaresdebe"] : (decimal)DFila["dolareshaber"];
                ValorHaberME = debe ? (decimal)DFila["dolareshaber"] : (decimal)DFila["dolaresdebe"];
                ValorDolares = ((ValorDebeMN > 0 && ValorDebeME > 0) || (ValorHaberMN > 0 && ValorHaberME > 0) ? 1 : -1) * (ValorDebeME + ValorHaberME);
                if (ValorDebeMN + ValorHaberMN == 0)
                {
                    ValorDolares = (debe ? 1 : -1) * (ValorDebeME + ValorHaberME * -1);
                }
                //cabecera Debe                  
                //CapaLogica.ActivarDesactivarReflejos(0);//Desactivamos
                CapaLogica.InsertarAsientoFacturaCabecera(1, pase, NumAsiento, fechaContable, CuentaContable, ValorDebeMN, ValorHaberMN, TC, fkProyecto, 0, cuo, IdSoles, Glosa, fechaContable, dinamica);
                //Detalle del asiento del Debe             
                CapaLogica.InsertarAsientoFacturaDetalle(99, pase, NumAsiento, fechaContable, CuentaContable, fkProyecto, TipoIdProveedor, RucProveedor,
                    NameProveedor, idcomprobante, SerieDocumento, NumDocumento, dinamica, fechaContable, fechaContable, fechaContable, ValorDebeMN + ValorHaberMN,
                    ValorDolares, TC, IdSoles, NroCuentaBancaria, "", $"{CuentaContable}-{Glosa}", fechaContable, IdUsuario, "");
                //CapaLogica.ActivarDesactivarReflejos(1);//Activamos
                //Eliminamos los Reflejos
            }
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
        public Boolean VerificarsiYaexisteAsiento(Boolean Limpiar)
        {
            Boolean Resultado = true;
            //Verificamos si ya existe el Asiento;
            DateTime Fecha = new DateTime(comboMesAño.FechaFinMes.Year, 12, 31);
            DataTable TdatosC = new DataTable();
            DataTable TdatosA = new DataTable();
            btnExcel.Enabled = false;
            rbCierre.Enabled = true;
            rbApertura.Enabled = false;
            if (Limpiar)
            {
                if (dtgconten.DataSource != null)
                    dtgconten.DataSource = ((DataTable)dtgconten.DataSource).Clone();
                if (dtgcontenBalance.DataSource != null)
                    dtgcontenBalance.DataSource = ((DataTable)dtgcontenBalance.DataSource).Clone();
            }
            //if (chkSaldos.Checked)
            TdatosC = CapaLogica.CierreAnualDinamicaYaExiste(-50, new DateTime(Fecha.Year - 1, 1, 1), (int)cboempresa.SelectedValue);
            TdatosA = CapaLogica.CierreAnualDinamicaYaExiste(-51, new DateTime(Fecha.Year, 1, 1), (int)cboempresa.SelectedValue);
            //rbApertura.Enabled = false;
            if (TdatosC.Rows.Count > 0)
            {
                rbCierre.Enabled = false;
                rbApertura.Enabled = true;
                rbApertura.Checked = true;
                lbl1.Text = $"Ya Existe un Asiento, Reverselo ";
                foreach (DataRow item in TdatosC.Rows)
                {
                    lbl1.Text += $" {item["Cod_Asiento_Contable"]}";
                }
                Resultado = true;
            }
            if (TdatosA.Rows.Count > 0)
            {
                rbApertura.Enabled = false;
                rbCierre.Enabled = false;
            }

            return Resultado;
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                int[] _ColumnasAutoajustar = new int[] { 2, 3, 4, 5 };
                //Seleccionado el Asiento de Cierre Normal
                if (PaginaSeleccionada == 1)
                {
                    _NombreHoja = $"Asiento Cierre {NameEmpresa}".ToUpper();
                    _Cabecera = "Asiento Cierre";
                    _NColumna = "E";
                    _ColumnasAutoajustar = new int[] { 1, 2, 3, 4, 5 };
                }
                else
                {
                    _NombreHoja = $"Dinámica Asiento Cierre {NameEmpresa}".ToUpper();
                    _Cabecera = "Dinámica Asiento Cierre";
                    _NColumna = "R";
                    _ColumnasAutoajustar = new int[] { 1, 2, 3, 4, 5, 7, 8, 9, 12, 13, 14, 15, 16, 17, 18 };
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
                if (PaginaSeleccionada == 1)
                    TableResuk = ((DataTable)dtgconten.DataSource).Copy();
                else
                    TableResuk = ((DataTable)dtgcontenBalance.DataSource).Copy();
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
            btnExcel.Enabled = true;
        }
        frmProcesando frmpro;
        private string Glosa;

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                ///* Inicio = new TimeSpan(DateTim*/e.Now.Ticks);
                dtgconten.SuspendLayout();
                btnExcel.Enabled = false;
                frmpro = new frmProcesando();
                frmpro.Show(); Cursor = Cursors.WaitCursor;
                NameEmpresa = $"{cboempresa.Text} {comboMesAño.FechaInicioMes.Year - 1}";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cboproyecto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public int PaginaSeleccionada = 1;
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2) PaginaSeleccionada = 1;
            else if (tabControl1.SelectedTab == tabPage1) PaginaSeleccionada = 2;
        }
        private void comboMesAño_CambioFechas(object sender, EventArgs e)
        {
            btnPreliminar.Enabled = true;
            if (cboempresa.SelectedValue != null)
                VerificarsiYaexisteAsiento(true);
        }
    }
}
