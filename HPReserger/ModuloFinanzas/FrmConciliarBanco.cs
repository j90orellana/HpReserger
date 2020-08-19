using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger.ModuloFinanzas
{
    public partial class FrmConciliarBanco : FormGradient
    {
        public FrmConciliarBanco()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public int PkId = 0;
        public void CargarEmpresa()
        {
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
            cboempresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
        }
        private void FrmConciliarBanco_Load(object sender, EventArgs e)
        {
            ActivarFunciones(false);
            Estado = 0;
            CargarEmpresa();
        }
        int pkEmpresa = 0;
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pkEmpresa != (int)(cboempresa.SelectedValue))
            {
                pkEmpresa = (int)cboempresa.SelectedValue;
                BuscarCuentasBancarias(true);
            }
        }

        private Boolean BuscarCuentasBancarias(Boolean BuscarDatos)
        {
            Boolean prueba = false;
            int Contador = cboCuentasBancarias.Items.Count;
            DataTable Tdatos = CapaLogica.BuscarCuentasBancariasxEmpresas(pkEmpresa);
            if (Contador != Tdatos.Rows.Count || BuscarDatos)
            {
                cboCuentasBancarias.DisplayMember = "CuentaBancaria";
                cboCuentasBancarias.ValueMember = "Id_Tipo_Cta";
                cboCuentasBancarias.DataSource = Tdatos;
                prueba = true;
            }
            return prueba;
        }
        private void cboCuentasBancarias_Click(object sender, EventArgs e)
        {
            string Cuenta = cboCuentasBancarias.Text;
            if (BuscarCuentasBancarias(false))
                cboCuentasBancarias.Text = Cuenta;
        }
        private int _estado;
        public int Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        Boolean Continuar = false;
        private void buttonPer1_Click(object sender, EventArgs e)
        {
            Continuar = false;
            PkId = 0;
            DataTable TDatosAux = CapaLogica.ConciliacionCabeceraExiste(pkEmpresa, comboMesAño1.FechaFinMes, pkidCtaBanco);
            if (TDatosAux.Rows.Count > 0)
            {
                Continuar = true;
                PkId = (int)TDatosAux.Rows[0]["pkid"];
                EstadoCuenta = (decimal)TDatosAux.Rows[0]["estadocuenta"];
                EstadoCuentaInicial = (decimal)TDatosAux.Rows[0]["estadocuentaInicial"];
                btnReversar.Visible = true;
                CargamosDatosParaContinuar();
                PasarAPaso1(true);
                PasarAPaso2(true);
                Estado = 2;
                MostrarDatosdeEtiquetasGrillas(true);
                ActivarFunciones(true);
                MostrarTotales();
                OrdenarDataGridViews();
                if (e != null) msg("Continuando con la Conciliación");
                return;
                //if (msgYesCancel("Este Periodo Ya esta Conciliado, Desea Volver a Cargarlo? Esto Reversará la Conciliacion Anterior") == DialogResult.Yes)
                //{
                //    CapaLogica.ConciliacionCabeceraEliminar(pkEmpresa, comboMesAño1.FechaFinMes);
                //    msg("Se Elimino la Conciliación Anterior");
                //}
                //else return;
            }
            Estado = 1;
            PasarAPaso1(true);
            if (File.Exists(txtRutaExcel.Text)) btnPaso2.Enabled = true;
        }
        private void CargamosDatosParaContinuar()
        {
            BuscanEnSistemMovimientos();
            dtgContenExcel.DataSource = TdatosExcel = CapaLogica.ConciliacionCabeceraExcel(pkEmpresa, comboMesAño1.FechaFinMes, pkidCtaBanco);
            dtgContenSistema.DataSource = TdatosSist = CapaLogica.ConciliacionCabeceraSistema(pkEmpresa, comboMesAño1.FechaFinMes, pkidCtaBanco);
            Cfilas = 0;
            foreach (DataRow item in TdatosExcel.Rows)
            {
                if (item[xGrupo.DataPropertyName].ToString() != "")
                    if ((int)item[xGrupo.DataPropertyName] > Cfilas)
                        Cfilas = (int)item[xGrupo.DataPropertyName];
            }
        }
        int Cfilas = 0;
        private void btnPaso2_Click(object sender, EventArgs e)
        {
            if (CargarDatosDelExcel(txtRutaExcel.Text))
            {
                PasarAPaso2(true);
                Estado = 2;
                BuscanEnSistemMovimientos();
                chkOperacion.Checked = false;
                if (ProcesodeAnalisis(pkBanco, NroCuenta))
                {
                    if (FormatearlaTabla(pkBanco))
                    {
                        //Datos del Excel
                        BuscanEnSistemMovimientosExcel();
                        dtgContenExcel.DataSource = TdatosExcel;
                        //Datos del Sistema
                        dtgContenSistema.DataSource = TdatosSist;
                        ContarRegistros();
                        OrdenarDataGridViews();
                        ActivarFunciones(true);
                        Cfilas = 0;
                        ConciliarMovimientos(Conciliaciones.FechaMonto);
                        MostrarDatosdeEtiquetasGrillas(true);
                        MostrarTotales();
                    }
                }
                else
                {
                    Estado = 1;
                    PasarAPaso2(false);
                }
            }
        }

        private void MostrarDatosdeEtiquetasGrillas(bool v)
        {
            if (v)
            {
                lblexcel.Text = $"Datos de Movimiento Bancario del Excel Cargado.  EstadoCuenta Inicial: { EstadoCuentaInicial.ToString("n2")}"; /////////////////////////////////////////
                lblSistema.Text = $"Datos de Movimiento Bancario en el Sistema.  SaldoContable Inicial: {SaldoContableInicial.ToString("n2")}";
                lblsaldoFinal.Text = $"SaldoContable Final: {SaldoContable.ToString("n2")}";
                lblEstadoCuenta.Text = $"EstadoCuenta Final: {EstadoCuenta.ToString("n2")}";
            }
            else
            {
                lblexcel.Text = $"Datos de Movimiento Bancario del Excel Cargado.";
                lblSistema.Text = $"Datos de Movimiento Bancario en el Sistema.";
                lblsaldoFinal.Text = "";
                lblEstadoCuenta.Text = "";
            }
        }
        private void ActivarFunciones(bool v)
        {
            //Activo los Botones para las Operaciones
            lblTotales.Text = v ? "Seleccione Filas en las 2 Tablas" : "";
            //lblFunciones.Visible = v;
            //btnOperacion.Visible = v;
            //btnOperacionMonto.Visible = v;
            //btnFechaMonto.Visible = v;
            //
            lblmanual.Visible = v;
            btnAgrupar.Visible = v;
            btnDesAgrupar.Visible = v;
            //
            chkOperacion.Visible = v;
            btnTxt.Visible = v;
            //
            lblRegistroExcel.Visible = v;
            lblRegistroExcel2.Visible = v;
            lblRegistroSistema.Visible = v;
            lblRegistroSistema2.Visible = v;

            dtgContenExcel.Columns[xComentario.Name].ReadOnly = !v;
            dtgContenSistema.Columns[yComentario.Name].ReadOnly = !v;
        }
        private void OrdenarDataGridViews(int x, int y)
        {
            //Ordenar TAbla del Excel
            if (TdatosExcel.Rows.Count != 0)
            {
                DataView dv = new DataView(TdatosExcel);
                dv.Sort = "index desc, monto asc";
                dtgContenExcel.DataSource = TdatosExcel = dv.ToTable();
            }
            //Ordenar TAbla del Sistema
            if (TdatosSist.Rows.Count != 0)
            {
                DataView dv = new DataView(TdatosSist);
                dv.Sort = "index desc, monto asc";
                dtgContenSistema.DataSource = TdatosSist = dv.ToTable();
            }
            dtgContenExcel.FirstDisplayedCell = dtgContenExcel[xok.Name, x];
            dtgContenSistema.FirstDisplayedCell = dtgContenSistema[yok.Name, y];
        }
        private void OrdenarDataGridViews()
        {
            //Ordenar TAbla del Excel
            if (TdatosExcel.Rows.Count != 0)
            {
                DataView dv = new DataView(TdatosExcel);
                dv.Sort = "index desc, monto asc";
                dtgContenExcel.DataSource = TdatosExcel = dv.ToTable();
            }
            //Ordenar TAbla del Sistema
            if (TdatosSist.Rows.Count != 0)
            {
                DataView dv = new DataView(TdatosSist);
                dv.Sort = "index desc, monto asc";
                dtgContenSistema.DataSource = TdatosSist = dv.ToTable();
            }
        }
        decimal SaldoContable = 0;
        private void BuscanEnSistemMovimientos()
        {
            DateTime FechaAux;
            FechaAux = (comboMesAño1.FechaInicioMes).AddDays(-1);
            SaldoContable = (decimal)CapaLogica.SaldoContableCuentaBancariaxEmpresa(pkEmpresa, new DateTime(comboMesAño1.FechaInicioMes.Year, 1, 1), comboMesAño1.FechaFinMes, NroCuenta, pkMoneda).Rows[0]["monto"];
            SaldoContableInicial = (decimal)CapaLogica.SaldoContableCuentaBancariaxEmpresa(pkEmpresa, new DateTime(FechaAux.Year, 1, 1), FechaAux, NroCuenta, pkMoneda).Rows[0]["monto"];

            if (SaldoContable == 0) msgError("No hay Movimientos Contables");
            TdatosSist = CapaLogica.MovimientoBancariosxEmpresa(pkEmpresa, comboMesAño1.FechaInicioMes, comboMesAño1.FechaFinMes, NroCuenta, pkMoneda, pkidCtaBanco);
        }
        private void BuscanEnSistemMovimientosExcel()
        {
            DataTable TablaAux = CapaLogica.MovimientoBancariosxEmpresaExcel(pkEmpresa, comboMesAño1.FechaInicioMes, comboMesAño1.FechaFinMes, NroCuenta, pkMoneda, pkidCtaBanco);
            foreach (DataRow item in TablaAux.Rows)
            {
                DataRow Filax = TdatosExcel.NewRow();
                Filax[xok.DataPropertyName] = item[xok.DataPropertyName];
                Filax[xGrupo.DataPropertyName] = item[xGrupo.DataPropertyName];
                Filax[xFecha.DataPropertyName] = ((DateTime)item[xFecha.DataPropertyName]).ToShortDateString();
                Filax[xMonto.DataPropertyName] = item[xMonto.DataPropertyName];
                Filax[xNroOperacion.DataPropertyName] = item[xNroOperacion.DataPropertyName];
                Filax[xGlosa.DataPropertyName] = item[xGlosa.DataPropertyName];
                Filax[xGlosa2.DataPropertyName] = item[xGlosa2.DataPropertyName];
                Filax[xComentario.DataPropertyName] = item[xComentario.DataPropertyName];
                Filax[xpkid.DataPropertyName] = item[xpkid.DataPropertyName];
                TdatosExcel.Rows.Add(Filax);
            }
        }
        private Boolean FormatearlaTabla(int Banco)
        {
            if (Banco == 1) //Banco BCP
            {
                foreach (DataRow item in TdatosExcel.Rows)
                {
                    DateTime Fecha;
                    if (!DateTime.TryParse(item[0].ToString(), out Fecha))
                    {
                        item.Delete();
                    }
                }
                int[] IndexColumnasEliminar = new int[] { 9, 8, 7, 5, 4, 1 };
                foreach (int item in IndexColumnasEliminar)
                {
                    TdatosExcel.Columns.RemoveAt(item);
                }
                //Damos Nombres a las Columnas
                TdatosExcel.Columns[0].ColumnName = "Fecha";
                TdatosExcel.Columns[2].ColumnName = "Monto";
                TdatosExcel.Columns[3].ColumnName = "Operacion";
                TdatosExcel.Columns[1].ColumnName = "Glosa";
                TdatosExcel.Columns[4].ColumnName = "Glosa2";
                TdatosExcel.Columns[1].SetOrdinal(3);
                //Agregamos la Columnas
                DataColumn ColOk = new DataColumn("ok", typeof(int));
                ColOk.DefaultValue = 0;
                TdatosExcel.Columns.Add(ColOk);
                DataColumn ColIndex = new DataColumn("Index", typeof(int));
                ColOk.DefaultValue = 0;
                TdatosExcel.Columns.Add(ColIndex);
                DataColumn ColPkid = new DataColumn("pkid", typeof(int));
                ColPkid.DefaultValue = 0;
                TdatosExcel.Columns.Add(ColPkid);
                TdatosExcel.Columns.Add("Comentario");

                TdatosExcel.AcceptChanges();
                return true;
            }
            else if (Banco == 10) //Banco Pichincha{
            {
                foreach (DataRow item in TdatosExcel.Rows)
                {
                    DateTime Fecha;
                    if (!DateTime.TryParse(item[1].ToString(), out Fecha))
                    {
                        item.Delete();
                    }
                }
                int[] IndexColumnasEliminar = new int[] { 17, 16, 15, 14, 13, 9, 8, 7, 6, 4, 3, 2, 0 };
                foreach (int item in IndexColumnasEliminar)
                {
                    TdatosExcel.Columns.RemoveAt(item);
                }
                TdatosExcel.Columns[0].ColumnName = "Fecha";
                TdatosExcel.Columns[2].ColumnName = "Monto";
                TdatosExcel.Columns[3].ColumnName = "Operacion";
                TdatosExcel.Columns[1].ColumnName = "Glosa";
                TdatosExcel.Columns[4].ColumnName = "Glosa2";
                TdatosExcel.Columns[1].SetOrdinal(3);
                //Agregamos la Columnas
                DataColumn ColOk = new DataColumn("ok", typeof(int));
                ColOk.DefaultValue = 0;
                TdatosExcel.Columns.Add(ColOk);
                DataColumn ColIndex = new DataColumn("Index", typeof(int));
                ColOk.DefaultValue = 0;
                TdatosExcel.Columns.Add(ColIndex);
                DataColumn ColPkid = new DataColumn("pkid", typeof(int));
                ColPkid.DefaultValue = 0;
                TdatosExcel.Columns.Add(ColPkid);
                TdatosExcel.Columns.Add("Comentario");

                TdatosExcel.AcceptChanges();
                //Corregimos la columna de monto, ya que viene con un espacio adelante de signo
                foreach (DataRow item in TdatosExcel.Rows)
                    item["monto"] = HPResergerFunciones.Utilitarios.QuitarCaracterCuenta(item["monto"].ToString(), ' ');
                return true;
            }
            else if (pkBanco == 3) // para el banco continental
            {
                foreach (DataRow item in TdatosExcel.Rows)
                {
                    DateTime Fecha;
                    if (!DateTime.TryParse(item[0].ToString(), out Fecha))
                    {
                        item.Delete();
                    }
                }
                //TdatosExcel.AcceptChanges();
                int[] IndexColumnasEliminar = new int[] { 6, 2, 1 };
                foreach (int item in IndexColumnasEliminar)
                {
                    TdatosExcel.Columns.RemoveAt(item);
                }
                TdatosExcel.Columns[0].ColumnName = "Fecha";
                TdatosExcel.Columns[3].ColumnName = "Monto";
                TdatosExcel.Columns[1].ColumnName = "Operacion";
                TdatosExcel.Columns[2].ColumnName = "Glosa";
                //TdatosExcel.Columns[4].ColumnName = "Glosa2";
                TdatosExcel.Columns[2].SetOrdinal(3);
                //Agregamos la Columnas
                DataColumn ColOk = new DataColumn("ok", typeof(int));
                ColOk.DefaultValue = 0;
                TdatosExcel.Columns.Add(ColOk);
                DataColumn ColIndex = new DataColumn("Index", typeof(int));
                ColOk.DefaultValue = 0;
                TdatosExcel.Columns.Add(ColIndex);
                DataColumn ColPkid = new DataColumn("pkid", typeof(int));
                ColPkid.DefaultValue = 0;
                TdatosExcel.Columns.Add(ColPkid);
                TdatosExcel.Columns.Add("Glosa2");
                TdatosExcel.Columns.Add("Comentario");
                TdatosExcel.AcceptChanges();
                //Corregimos la columna de monto, ya que viene con un espacio adelante de signo
                //foreach (DataRow item in TdatosExcel.Rows)
                //    item["monto"] = HPResergerFunciones.Utilitarios.QuitarCaracterCuenta(item["monto"].ToString(), ' ');
                return true;
            }
            else if (pkBanco == 2) // Banco ScotiaBank
            {
                try
                {
                    foreach (DataRow item in TdatosExcel.Rows)
                    {
                        DateTime Fecha;
                        if (!DateTime.TryParse(item[7].ToString(), out Fecha))
                        {
                            item.Delete();
                        }
                    }
                }
                catch (Exception) { }
                TdatosExcel.AcceptChanges();
                int[] IndexColumnasEliminar = new int[] { 16, 15, 14, 12, 11, 10, 9, 8, 6, 4, 3, 1, 0 };

                foreach (int item in IndexColumnasEliminar)
                {
                    TdatosExcel.Columns.RemoveAt(item);
                }
                TdatosExcel.Columns[2].ColumnName = "Fecha";
                TdatosExcel.Columns[1].ColumnName = "Monto";
                TdatosExcel.Columns[3].ColumnName = "Operacion";
                TdatosExcel.Columns[0].ColumnName = "Glosa";
                //TdatosExcel.Columns[4].ColumnName = "Glosa2";
                TdatosExcel.Columns[0].SetOrdinal(3);
                TdatosExcel.Columns[1].SetOrdinal(0);
                TdatosExcel.Columns[1].SetOrdinal(2);
                //Agregamos la Columnas
                DataColumn ColOk = new DataColumn("ok", typeof(int));
                ColOk.DefaultValue = 0;
                TdatosExcel.Columns.Add(ColOk);
                DataColumn ColIndex = new DataColumn("Index", typeof(int));
                ColOk.DefaultValue = 0;
                TdatosExcel.Columns.Add(ColIndex);
                DataColumn ColPkid = new DataColumn("pkid", typeof(int));
                ColPkid.DefaultValue = 0;
                TdatosExcel.Columns.Add(ColPkid);
                TdatosExcel.Columns.Add("Glosa2");
                TdatosExcel.Columns.Add("Comentario");
                TdatosExcel.AcceptChanges();
                //Corregimos la columna de monto, ya que viene con un espacio adelante de signo
                //foreach (DataRow item in TdatosExcel.Rows)
                //    item["monto"] = HPResergerFunciones.Utilitarios.QuitarCaracterCuenta(item["monto"].ToString(), ' ');
                return true;
            }
            return false;
        }

        private void ContarRegistros()
        {
            lblRegistroExcel.Text = $"Total Registros del Excel: {dtgContenExcel.RowCount}";
            lblRegistroExcel2.Text = $"Total Consolidado: 0 Pendientes: 0";
            lblRegistroSistema.Text = $"Total Registros del Sistema: {dtgContenSistema.RowCount}";
            lblRegistroSistema2.Text = $"Total Consolidado: 0 Pendientes: 0";
        }
        private void ContarRegistros(int x1, int x2, int y1, int y2)
        {
            lblRegistroExcel.Text = $"Total Registros del Excel: {dtgContenExcel.RowCount}";
            lblRegistroExcel2.Text = $"Total Consolidado: {x1} Pendientes: {x2}";
            lblRegistroSistema.Text = $"Total Registros del Sistema: {dtgContenSistema.RowCount}";
            lblRegistroSistema2.Text = $"Total Consolidado: {y1} Pendientes: {y2}";
        }
        decimal EstadoCuenta = 0;
        private Boolean ProcesodeAnalisis(int pkBanco, string nroCuenta)
        {
            if (pkBanco == 1) //Banco BCP
            {
                //validamos Que pertenezca ala misma cuenta
                if (TdatosExcel.Columns.Count != 11)
                {
                    msgError("El Archivo Excel No contienen todas las Columnas Necesarias");
                    return false;
                }
                EstadoCuenta = decimal.Parse(TdatosExcel.Rows[5][4].ToString());
                EstadoCuentaInicial = decimal.Parse(TdatosExcel.Rows[TdatosExcel.Rows.Count - 1][4].ToString()); ///////////////////////////////////////
                string ValCuenta = TdatosExcel.Rows[0][1].ToString();
                if (!ValCuenta.Contains(nroCuenta))
                {
                    msgError("El Excel de Movimientos NO coincide con la cuenta Seleccionada");
                    return false;
                }
                int pos = 6; int c = 1;
                DateTime FechaMin = new DateTime(2200, 1, 1);
                DateTime FechaMax = new DateTime(1900, 1, 1);
                foreach (DataRow item in TdatosExcel.Rows)
                {
                    if (c++ >= pos)
                    {
                        DateTime Fecha = DateTime.Parse(item[0].ToString());
                        if (Fecha < FechaMin) FechaMin = Fecha;
                        if (Fecha > FechaMax) FechaMax = Fecha;
                    }
                }
                DateTime FechaCombo = comboMesAño1.GetFecha();
                if (!(FechaMin.Month == FechaCombo.Month && FechaCombo.Year == FechaMax.Year))
                {
                    msgError("El Periodo Seleccionado No Coincide con la Fecha de Los Movimientos");
                    return false;
                }
                return true;
            }
            else if (pkBanco == 10) //Pichincha
            {
                if (TdatosExcel.Columns.Count != 18)
                {
                    msgError("El Archivo Excel No contienen todas las Columnas Necesarias");
                    return false;
                }
                EstadoCuenta = decimal.Parse(TdatosExcel.Rows[13][14].ToString());
                EstadoCuenta = EstadoCuenta * (TdatosExcel.Rows[13][13].ToString() == "(-)" ? -1 : 1);
                EstadoCuentaInicial = decimal.Parse(TdatosExcel.Rows[TdatosExcel.Rows.Count - 1][14].ToString());////////////////////////////////////////////
                EstadoCuentaInicial = EstadoCuentaInicial * (TdatosExcel.Rows[TdatosExcel.Rows.Count - 1][13].ToString() == "(-)" ? -1 : 1);////////////////////////////
                string ValCuenta = TdatosExcel.Rows[7][4].ToString();
                if (!ValCuenta.Contains(HPResergerFunciones.Utilitarios.QuitarCaracterCuenta(nroCuenta.Substring(3), '-', ' ')))
                {
                    msgError("El Excel de Movimientos NO coincide con la cuenta Seleccionada");
                    return false;
                }
                int pos = 14; int c = 1;
                DateTime FechaMin = new DateTime(2200, 1, 1);
                DateTime FechaMax = new DateTime(1900, 1, 1);
                foreach (DataRow item in TdatosExcel.Rows)
                {
                    if (c++ >= pos)
                    {
                        DateTime Fecha = DateTime.Parse(item[1].ToString());
                        if (Fecha < FechaMin) FechaMin = Fecha;
                        if (Fecha > FechaMax) FechaMax = Fecha;
                    }
                }
                DateTime FechaCombo = comboMesAño1.GetFecha();
                if (!(FechaMin.Month == FechaCombo.Month && FechaCombo.Year == FechaMax.Year))
                {
                    msgError("El Periodo Seleccionado No Coincide con la Fecha de Los Movimientos");
                    return false;
                }
                return true;
            }
            else if (pkBanco == 3) //BBVA continental
            {
                if (TdatosExcel.Columns.Count != 7)
                {
                    msgError("El Archivo Excel No contienen todas las Columnas Necesarias");
                    return false;
                }
                EstadoCuenta = decimal.Parse(TdatosExcel.Rows[TdatosExcel.Rows.Count - 1][5].ToString());
                EstadoCuentaInicial = decimal.Parse(TdatosExcel.Rows[11][5].ToString());/////////////////////
                //EstadoCuenta = EstadoCuenta * (TdatosExcel.Rows[13][13].ToString() == "(-)" ? -1 : 1);
                string ValCuenta = TdatosExcel.Rows[6][0].ToString();
                ValCuenta = HPResergerFunciones.Utilitarios.ExtraerCuentaSoloEnteros(ValCuenta);
                ValCuenta = ValCuenta.Substring(0, 8) + ValCuenta.Substring(10);
                if (!ValCuenta.Contains(HPResergerFunciones.Utilitarios.ExtraerCuentaSoloEnteros(nroCuenta)))
                {
                    msgError("El Excel de Movimientos NO coincide con la cuenta Seleccionada");
                    return false;
                }
                int pos = 10; int i = 0;
                foreach (DataRow item in TdatosExcel.Rows)
                {
                    if (i++ > pos)
                    {
                        if (item[4].ToString().Contains("Saldo Inicial: ") || item[4].ToString().Contains("Saldo Final: "))
                        {
                            item.Delete();
                        }
                    }
                }
                TdatosExcel.AcceptChanges();
                //
                pos = 11; int c = 0;
                DateTime FechaMin = new DateTime(2200, 1, 1);
                DateTime FechaMax = new DateTime(1900, 1, 1);
                foreach (DataRow item in TdatosExcel.Rows)
                {
                    if (c++ >= pos)
                    {
                        DateTime Fecha = DateTime.Parse(item[0].ToString());
                        if (Fecha < FechaMin) FechaMin = Fecha;
                        if (Fecha > FechaMax) FechaMax = Fecha;
                    }
                }
                DateTime FechaCombo = comboMesAño1.GetFecha();
                if (!(FechaMin.Month == FechaCombo.Month && FechaCombo.Year == FechaMax.Year))
                {
                    msgError("El Periodo Seleccionado No Coincide con la Fecha de Los Movimientos");
                    return false;
                }
                return true;
            }
            else if (pkBanco == 2)//ScotiaBank
            {
                if (TdatosExcel.Columns.Count != 17)
                {
                    msgError("El Archivo Excel No contienen todas las Columnas Necesarias");
                    return false;
                }
                EstadoCuenta = decimal.Parse(TdatosExcel.Rows[7][2].ToString());
                EstadoCuentaInicial = decimal.Parse(TdatosExcel.Rows[TdatosExcel.Rows.Count - 1][2].ToString());///////////////////////
                //EstadoCuenta = EstadoCuenta * (TdatosExcel.Rows[13][13].ToString() == "(-)" ? -1 : 1);
                string ValCuenta = TdatosExcel.Rows[4][2].ToString();
                if (!ValCuenta.Contains(nroCuenta))
                {
                    msgError("El Excel de Movimientos NO coincide con la cuenta Seleccionada");
                    return false;
                }
                int pos = 12; int i = 0;
                foreach (DataRow item in TdatosExcel.Rows)
                {
                    if (i++ > pos)
                    {
                        decimal ValPrueba = 0;
                        if (decimal.TryParse(item[5].ToString(), out ValPrueba))
                            item[5] = (decimal.Parse(item[5].ToString()) + decimal.Parse(item[6].ToString())) * (ValPrueba == 0 ? 1 : -1);
                    }
                }
                TdatosExcel.AcceptChanges();
                //
                pos = 13; int c = 0;
                DateTime FechaMin = new DateTime(2200, 1, 1);
                DateTime FechaMax = new DateTime(1900, 1, 1);
                foreach (DataRow item in TdatosExcel.Rows)
                {
                    if (c++ >= pos)
                    {
                        DateTime Fecha;
                        if (DateTime.TryParse(item[7].ToString(), out Fecha))
                        {
                            Fecha = DateTime.Parse(item[7].ToString());
                            if (Fecha < FechaMin) FechaMin = Fecha;
                            if (Fecha > FechaMax) FechaMax = Fecha;
                        }
                        else item.Delete();
                    }
                }
                DateTime FechaCombo = comboMesAño1.GetFecha();
                if (!(FechaMin.Month == FechaCombo.Month && FechaCombo.Year == FechaMax.Year))
                {
                    msgError("El Periodo Seleccionado No Coincide con la Fecha de Los Movimientos");
                    return false;
                }
                return true;
            }
            else
            {
                msgError("Por el Momento se puede Conciliar el Banco BCP - Pichincha - BBVA - ScotiaBank");
                return false;
            }
            return false;
        }
        DataTable TdatosExcel;
        DataTable TdatosSist;
        private Boolean CargarDatosDelExcel(string Ruta)
        {
            TdatosExcel = HPResergerFunciones.Utilitarios.CargarDatosDeExcelAGrilla(txtRutaExcel.Text, 1, 6, 11);
            if (TdatosExcel.Rows.Count == 0)
            {
                return false;
            }
            return true;
            //List<string> Listado = new List<string>();
            //foreach (string item in HPResergerFunciones.Utilitarios.ListarHojasDeunExcel(Ruta))
            //{
            //    Listado.Add(item);
            //}
            //dtgconten.DataSource = HPResergerFunciones.Utilitarios.CargarDatosDeExcelAGrilla(Ruta, Listado[0].ToString());
        }
        private void PasarAPaso2(bool v)
        {
            v = !v;
            btnCargar.Enabled = v;
            dtgContenExcel.Enabled = !v;
            dtgContenSistema.Enabled = !v;
            btnPaso2.Enabled = v;
        }
        private void PasarAPaso1(bool v)
        {
            v = !v;
            cboempresa.Enabled = v;
            cboCuentasBancarias.Enabled = v;
            comboMesAño1.Enabled = v;
            btnPaso1.Enabled = v;
            btnCargar.Enabled = !v;
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (Estado == 0)
            {
                this.Close();
            }
            else if (Estado == 1)
            {
                PasarAPaso1(false);
                Estado--;
                btnPaso2.Enabled = false;
            }
            else if (Estado == 2)
            {
                PasarAPaso1(false);
                Estado--;
                if (dtgContenExcel.DataSource != null)
                {
                    dtgContenExcel.DataSource = ((DataTable)dtgContenExcel.DataSource).Clone();
                }
                if (dtgContenSistema.DataSource != null)
                {
                    dtgContenSistema.DataSource = ((DataTable)dtgContenSistema.DataSource).Clone();
                }
                ActivarFunciones(false);
                MostrarDatosdeEtiquetasGrillas(false);
                ContarRegistros();
                btnReversar.Visible = false;
            }
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.frmInformativo.MostrarDialog(cadena);
        }
        public DialogResult msgYesCancel(string cadena)
        {
            return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena);
        }
        public void msgError(string cadena)
        {
            HPResergerFunciones.frmInformativo.MostrarDialogError(cadena);
        }
        private void textBoxPer1_DoubleClick(object sender, EventArgs e)
        {
            btnCargar.Enabled = true;
            SeleccionarArchivoExcel();
        }
        private void SeleccionarArchivoExcel()
        {
            openFileDialog1.FileName = txtRutaExcel.Text;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog1.FileName))
                {
                    btnPaso2.Enabled = true;
                    txtRutaExcel.Text = openFileDialog1.FileName;
                }
            }
        }
        private void buttonPer1_Click_1(object sender, EventArgs e)
        {
            SeleccionarArchivoExcel();
        }
        int pkBanco = 0;
        int pkMoneda = 0;
        int pkidCtaBanco = 0;
        string NroCuenta = "";
        string CuentaContable = "";
        private void cboCuentasBancarias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCuentasBancarias.SelectedValue != null)
            {
                pkBanco = (int)((DataTable)cboCuentasBancarias.DataSource).Rows[cboCuentasBancarias.SelectedIndex]["banco"];
                NroCuenta = ((DataTable)cboCuentasBancarias.DataSource).Rows[cboCuentasBancarias.SelectedIndex]["Nro_Cta"].ToString();
                pkMoneda = (int)((DataTable)cboCuentasBancarias.DataSource).Rows[cboCuentasBancarias.SelectedIndex]["Moneda"];
                pkidCtaBanco = (int)((DataTable)cboCuentasBancarias.DataSource).Rows[cboCuentasBancarias.SelectedIndex]["Id_Tipo_Cta"];
                CuentaContable = ((DataTable)cboCuentasBancarias.DataSource).Rows[cboCuentasBancarias.SelectedIndex]["idCuentacontable"].ToString();
            }
        }
        private void btnOperacionMonto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConciliarMovimientos(Conciliaciones.OperacionMonto);
        }
        enum Conciliaciones
        {
            OperacionMonto = 0, FechaMonto, Operacion
        }
        private void ConciliarMovimientos(Conciliaciones opcion)
        {
            if (opcion == Conciliaciones.OperacionMonto)
            {
                foreach (DataRow item1 in TdatosExcel.Rows)
                {
                    if ((int)(item1[xGrupo.DataPropertyName].ToString() == "" ? 0 : item1[xGrupo.DataPropertyName]) == 0)
                        foreach (DataRow item2 in TdatosSist.Rows)
                        {
                            if ((int)(item2[ygrupo.DataPropertyName].ToString() == "" ? 0 : item2[ygrupo.DataPropertyName]) == 0)
                                if (decimal.Parse(item1[xMonto.DataPropertyName].ToString()) == decimal.Parse(item2[ymonto.DataPropertyName].ToString())
                                    && item1[xNroOperacion.DataPropertyName].ToString() == item2[yoperacion.DataPropertyName].ToString())
                                {
                                    Cfilas++;
                                    item1[xGrupo.DataPropertyName] = Cfilas;
                                    item2[ygrupo.DataPropertyName] = Cfilas;
                                }

                        }
                }
            }
            else if (opcion == Conciliaciones.FechaMonto)
            {
                foreach (DataRow item1 in TdatosExcel.Rows)
                {
                    if ((int)(item1[xGrupo.DataPropertyName].ToString() == "" ? 0 : item1[xGrupo.DataPropertyName]) == 0)
                        foreach (DataRow item2 in TdatosSist.Rows)
                        {
                            if ((int)(item2[ygrupo.DataPropertyName].ToString() == "" ? 0 : item2[ygrupo.DataPropertyName]) == 0)
                                if (decimal.Parse(item1[xMonto.DataPropertyName].ToString()) == decimal.Parse(item2[ymonto.DataPropertyName].ToString())
                                        && DateTime.Parse(item1[xFecha.DataPropertyName].ToString()) == DateTime.Parse(item2[xFecha.DataPropertyName].ToString()))
                                {
                                    Cfilas++;
                                    item1[xGrupo.DataPropertyName] = Cfilas;
                                    item2[ygrupo.DataPropertyName] = Cfilas;
                                    break;
                                }
                        }
                }
            }
            //Ordenamos
            OrdenarDataGridViews();
        }
        private void dtgContenExcel_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int val = 0;
                int.TryParse(dtgContenExcel[xGrupo.Name, e.RowIndex].Value.ToString(), out val);
                if (val > 0)
                {
                    HPResergerFunciones.Utilitarios.ColorCeldaNormal(dtgContenExcel[e.ColumnIndex, e.RowIndex]);
                }
                else
                {
                    HPResergerFunciones.Utilitarios.ColorCeldaErrorLetras(dtgContenExcel[e.ColumnIndex, e.RowIndex]);
                }
            }
        }
        private void btnFechaMonto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConciliarMovimientos(Conciliaciones.FechaMonto);
        }
        private void btnDesAgrupar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //validaciones para DesAgrupar
            //Recorremos el Grid del EXcel para ver que no este seleccionada un fila sin grupo
            string cadena = "";
            foreach (DataRow item in TdatosExcel.Rows)
            {
                if ((int)item[xok.DataPropertyName] == 1)
                    if (item[xGrupo.DataPropertyName].ToString() == "")
                    {
                        cadena += "Fila no Agrupada en la grilla de Excel\n";
                        break;
                    }
            }
            foreach (DataRow item in TdatosSist.Rows)
            {
                if ((int)item[yok.DataPropertyName] == 1)
                    if (item[xGrupo.DataPropertyName].ToString() == "")
                    {
                        cadena += "Fila no Agrupada en la grilla de Sistema";
                        break;
                    }
            }
            //Mensaje de ERror
            if (cadena != "") { msgError(cadena); return; }
            //Codigo de DEsagrupacion
            int Valor = 0;
            dtgContenExcel.SuspendLayout();
            dtgContenSistema.SuspendLayout();
            foreach (DataRow item in TdatosExcel.Rows)
                if ((int)item[xok.DataPropertyName] == 1)
                    if (item[xGrupo.DataPropertyName].ToString() != "")
                    {
                        Valor = (int)item[xGrupo.DataPropertyName];
                        foreach (DataRow Fila in TdatosExcel.Rows)
                            if (Fila[xGrupo.DataPropertyName].ToString() != "")
                                if ((int)Fila[xGrupo.DataPropertyName] == Valor)
                                    Fila[xGrupo.DataPropertyName] = DBNull.Value;
                        foreach (DataRow Fila in TdatosSist.Rows)
                            if (Fila[ygrupo.DataPropertyName].ToString() != "")
                                if ((int)Fila[ygrupo.DataPropertyName] == Valor)
                                    Fila[ygrupo.DataPropertyName] = DBNull.Value;
                    }

            foreach (DataRow item in TdatosSist.Rows)
                if ((int)item[yok.DataPropertyName] == 1)
                    if (item[ygrupo.DataPropertyName].ToString() != "")
                    {
                        Valor = (int)item[ygrupo.DataPropertyName];
                        foreach (DataRow Fila in TdatosExcel.Rows)
                            if (Fila[xGrupo.DataPropertyName].ToString() != "")
                                if ((int)Fila[xGrupo.DataPropertyName] == Valor)
                                    Fila[xGrupo.DataPropertyName] = DBNull.Value;
                        foreach (DataRow Fila in TdatosSist.Rows)
                            if (Fila[ygrupo.DataPropertyName].ToString() != "")
                                if ((int)Fila[ygrupo.DataPropertyName] == Valor)
                                    Fila[ygrupo.DataPropertyName] = DBNull.Value;
                    }
            //Quitamos los check
            foreach (DataRow item in TdatosExcel.Rows)
                item[xok.DataPropertyName] = 0;
            foreach (DataRow item in TdatosSist.Rows)
                item[yok.DataPropertyName] = 0;
            //
            dtgContenExcel.ResumeLayout();
            dtgContenSistema.ResumeLayout();
            OrdenarDataGridViews(dtgContenExcel.FirstDisplayedCell.RowIndex, dtgContenSistema.FirstDisplayedCell.RowIndex);
        }
        private void dtgContenExcel_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dtgContenSistema_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dtgContenSistema_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int val = 0;
            int.TryParse(dtgContenSistema[ygrupo.Name, e.RowIndex].Value.ToString(), out val);
            if (val > 0)
            {
                HPResergerFunciones.Utilitarios.ColorCeldaNormal(dtgContenSistema[e.ColumnIndex, e.RowIndex]);
            }
            else
            {
                HPResergerFunciones.Utilitarios.ColorCeldaErrorLetras(dtgContenSistema[e.ColumnIndex, e.RowIndex]);
            }
        }
        private void dtgContenExcel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.ColumnIndex == dtgContenExcel.Columns[xok.Name].Index)
                {
                    //if (dtgContenExcel[xGrupo.Name, e.RowIndex].Value.ToString() != "")
                    //dtgContenExcel.CancelEdit();
                    dtgContenExcel.EndEdit(); dtgContenExcel.RefreshEdit();
                }
        }
        private void dtgContenSistema_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.ColumnIndex == dtgContenSistema.Columns[yok.Name].Index)
                {
                    //if (dtgContenSistema[ygrupo.Name, e.RowIndex].Value.ToString() != "")
                    //    dtgContenSistema.CancelEdit();
                    dtgContenSistema.EndEdit(); dtgContenSistema.RefreshEdit();
                }
        }
        decimal SumaExcel = 0, SumaSistema = 0;
        private decimal EstadoCuentaInicial;
        private decimal SaldoContableInicial;
        private void dtgContenSistema_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.ColumnIndex == dtgContenSistema.Columns[yok.Name].Index)
                {
                    //if (dtgContenSistema[ygrupo.Name, e.RowIndex].Value.ToString() != "")
                    //{
                    //    dtgContenSistema[yok.Name, e.RowIndex].Value = 0;
                    //}
                    MostrarTotales();
                }
        }
        private void dtgContenExcel_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.ColumnIndex == dtgContenExcel.Columns[xok.Name].Index)
                {
                    //if (dtgContenExcel[xGrupo.Name, e.RowIndex].Value.ToString() != "")
                    //{
                    //    dtgContenExcel[xok.Name, e.RowIndex].Value = 0;
                    //}
                    MostrarTotales();
                }
        }

        private void btnAgrupar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (SumaExcel == SumaSistema)
            {  //Validamos que no este Seleccionado uno ya Agrupado
                string cadena = "";
                foreach (DataRow item in TdatosExcel.Rows)
                    if ((int)item[xok.DataPropertyName] == 1)
                        if (item[xGrupo.DataPropertyName].ToString() != "")
                        {
                            cadena += "Fila Agrupada en el Excel\n";
                            break;
                        }
                foreach (DataRow item in TdatosSist.Rows)
                    if ((int)item[yok.DataPropertyName] == 1)
                        if (item[ygrupo.DataPropertyName].ToString() != "")
                        {
                            cadena += "Fila Agrupada en el Sistema\n";
                            break;
                        }
                if (cadena != "") { msgError("No se Puede Agrupar una Fila Ya Agrupada"); return; }
                //Codigo de Agrupacion

                Cfilas++;
                //Asignamos los Montos de Sumatoria
                foreach (DataRow item in TdatosExcel.Rows)
                    if ((int)item[xok.DataPropertyName] == 1)
                        item[xGrupo.DataPropertyName] = Cfilas;
                foreach (DataRow item in TdatosSist.Rows)
                    if ((int)item[yok.DataPropertyName] == 1)
                        item[ygrupo.DataPropertyName] = Cfilas;
                //Regresamos los Ok a Deseleccionados
                foreach (DataRow item in TdatosExcel.Rows)
                    item[xok.DataPropertyName] = 0;
                foreach (DataRow item in TdatosSist.Rows)
                    item[yok.DataPropertyName] = 0;
                //Ordenamos
                OrdenarDataGridViews(dtgContenExcel.FirstDisplayedCell.RowIndex, dtgContenSistema.FirstDisplayedCell.RowIndex);
                //Sacamos los Totales
                MostrarTotales();
            }
            else { msgError("Hay Diferencias en los Montos"); }
        }
        private void dtgContenExcel_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cuando Doy Doble Click en la Cabecera
            if (e.RowIndex == -1)
            {
                if (e.ColumnIndex == dtgContenExcel.Columns[xok.Name].Index)
                    foreach (DataRow item in TdatosExcel.Rows)
                        item[xok.DataPropertyName] = 0;
            }
            dtgContenExcel.EndEdit(); dtgContenExcel.RefreshEdit();
            MostrarTotales();
        }
        private void dtgContenSistema_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cuando Doy Doble Click en la Cabecera
            if (e.RowIndex == -1)
            {
                if (e.ColumnIndex == dtgContenSistema.Columns[yok.Name].Index)
                    foreach (DataRow item in TdatosSist.Rows)
                        item[yok.DataPropertyName] = 0;
            }
            dtgContenSistema.EndEdit(); dtgContenSistema.RefreshEdit();
            MostrarTotales();
        }
        public class GrupoVarios
        {
            public int Grupo;
            public int Contador;
            public GrupoVarios(int _grupo, int _contador)
            {
                Grupo = _grupo;
                Contador = _contador;
            }
        }
        public class GrupoNroOp
        {
            public int Grupo;
            public string Nroop;
            public GrupoNroOp(int _grupo, string _nroop)
            {
                Grupo = _grupo;
                Nroop = _nroop;
            }
            public Boolean CompararGrupo(int _grupo)
            {
                return Grupo == _grupo;
            }
        }
        private void btnTxt_Click(object sender, EventArgs e)
        {
            string Result = "";
            DialogResult Pregunta = DialogResult.No;
            if (CuentaContable == "") { msg("El Banco No tiene Cuenta Contable"); return; }
            if (msgYesCancel("Desea Grabar la Conciliación en el Sistema?") == DialogResult.Yes)
            {
                int cuentaCheck = 0;
                foreach (DataRow item in TdatosSist.Rows)
                {
                    if ((int)item[xUpdate.DataPropertyName] == 1) cuentaCheck++;
                }
                if (chkOperacion.Checked || cuentaCheck > 0)
                {
                    if (chkOperacion.Checked)
                    {
                        Pregunta = msgYesCancel("Se van a Actualizar los Nro. de Operaciones del Sistema con los datos del Excel");
                        if (Pregunta == DialogResult.Cancel)
                        {
                            msgError("Cancelado por el Usuario");
                            return;
                        }
                    }
                    List<GrupoNroOp> ListadoGrupos = new List<GrupoNroOp>();
                    List<GrupoVarios> ListadoVarios = new List<GrupoVarios>();
                    int last = 0;
                    foreach (DataRow item in TdatosExcel.Rows)
                    {
                        if (item[xGrupo.DataPropertyName].ToString() != "")
                        {
                            int value = (int)item[xGrupo.DataPropertyName];
                            string nroop = item[xNroOperacion.DataPropertyName].ToString();
                            if (value == last)
                            {
                                ListadoGrupos.Remove(ListadoGrupos.Find(cust => cust.Grupo == value));
                                last = value;
                                GrupoVarios GPV = ListadoVarios.Find(cust => cust.Grupo == value);
                                GPV.Contador += 1;
                            }
                            else
                            {
                                last = value;
                                ListadoGrupos.Add(new GrupoNroOp(last, nroop));
                                ListadoVarios.Add(new GrupoVarios(last, 1));
                            }
                        }
                    }
                    for (int i = 0; i < ListadoVarios.Count; i++)
                    {
                        if (ListadoVarios[i].Contador == 1)
                        {
                            ListadoVarios.RemoveAt(i);
                            i--;
                        }
                    }
                    Result = @" Y Se Han Actualizado Nro de Operaciones.";
                    //Una vez indentificados los grupos de uno a mucho y sacados los numero de operaciones vamos actualizar  1aM
                    foreach (GrupoNroOp lGrupo in ListadoGrupos)
                    {
                        foreach (DataRow tFila in TdatosSist.Rows)
                        {
                            if (tFila[xGrupo.DataPropertyName].ToString() != "")
                            {
                                //if (lGrupo.Grupo == 92) msg("ey");
                                if (lGrupo.Grupo == (int)tFila[xGrupo.DataPropertyName])

                                    if (lGrupo.Nroop != tFila[yoperacion.DataPropertyName].ToString())
                                    {
                                        if ((int)tFila[xUpdate.DataPropertyName] == 1 || chkOperacion.Checked)
                                        {
                                            tFila[yoperacion.DataPropertyName] = lGrupo.Nroop;
                                            CapaLogica.ActualizarNumeroOperacion(pkEmpresa, tFila[ycuo.DataPropertyName].ToString(), lGrupo.Nroop, pkidCtaBanco);
                                        }
                                        //Una vez encontrada la concidencia vamos Actualizar
                                    }
                            }
                        }
                    }
                    //Actualizamos los Nro de Operacion de Varios a VARIOS
                    foreach (var item in ListadoVarios)
                    {
                        foreach (DataRow tFila in TdatosSist.Rows)
                        {
                            if (tFila[xGrupo.DataPropertyName].ToString() != "")
                                if (item.Grupo == (int)tFila[xGrupo.DataPropertyName])
                                    if ("VARIOS" != tFila[yoperacion.DataPropertyName].ToString())
                                        if ((int)tFila[xUpdate.DataPropertyName] == 1 || chkOperacion.Checked)
                                        {
                                            tFila[yoperacion.DataPropertyName] = "VARIOS";
                                            CapaLogica.ActualizarNumeroOperacion(pkEmpresa, tFila[ycuo.DataPropertyName].ToString(), "VARIOS", pkidCtaBanco);
                                        }
                        }
                    }
                }
                //Proceso de Grabado en la Base de Datos
                //Grabamos la Cabecera de la Conciliacion
                DateTime FechaEjecucion = comboMesAño1.FechaFinMes;
                //Reversamos lo Anterior para Cargar la continuación.
                if (Continuar)
                    CapaLogica.ConciliacionCabeceraEliminar(pkEmpresa, comboMesAño1.FechaFinMes, pkidCtaBanco);
                else
                    PkId = (int)CapaLogica.ConciliacionCabeceraSiguienteNumero().Rows[0]["ultimo"];
                int pkUsuario = frmLogin.CodigoUsuario;
                CapaLogica.ConciliacionCabecera(1, PkId, pkEmpresa, pkidCtaBanco, CuentaContable, FechaEjecucion, SaldoContable, EstadoCuenta, pkUsuario, SaldoContableInicial, EstadoCuentaInicial);
                //GRabamos el Detalle de la Cabecera
                foreach (DataRow item in TdatosExcel.Rows)
                {
                    //Las Filas que no tiene grupo
                    if (item[xGrupo.DataPropertyName].ToString() == "")
                    {
                        //Tipo  1 para los Cargados por Excel
                        CapaLogica.ConciliacionDetalle(1, PkId, (int)item[xpkid.DataPropertyName], 1, null, "", DateTime.Parse(item[xFecha.DataPropertyName].ToString()), FechaEjecucion,
                         decimal.Parse(item[xMonto.DataPropertyName].ToString()), item[xNroOperacion.DataPropertyName].ToString(),
                            item[xGlosa.DataPropertyName].ToString(), item[xGlosa2.DataPropertyName].ToString(), 0, 1, item[xComentario.DataPropertyName].ToString());

                    }
                    else
                        CapaLogica.ConciliacionDetalle(1, PkId, (int)item[xpkid.DataPropertyName], 1, (int)item[xGrupo.DataPropertyName], "", DateTime.Parse(item[xFecha.DataPropertyName].ToString()),
                            FechaEjecucion, decimal.Parse(item[xMonto.DataPropertyName].ToString()), item[xNroOperacion.DataPropertyName].ToString(),
                            item[xGlosa.DataPropertyName].ToString(), item[xGlosa2.DataPropertyName].ToString(), 0, 0, item[xComentario.DataPropertyName].ToString());
                }
                foreach (DataRow item in TdatosSist.Rows)
                {
                    //Las Filas que no tiene grupo y no Estan en el Sistema Grabado
                    if (item[xGrupo.DataPropertyName].ToString() == "")
                    {
                        if ((int)item[xEstado.DataPropertyName] == -1)
                        {
                            //va 1 en el estado para insertar la primera vez en la base
                            //Tipo 2 para los Cargados del Sistema
                            CapaLogica.ConciliacionDetalle(1, PkId, (int)item[ypkid.DataPropertyName], 2, null,
                                item[ycuo.DataPropertyName].ToString(), DateTime.Parse(item[yFecha.DataPropertyName].ToString()), FechaEjecucion,
                                decimal.Parse(item[ymonto.DataPropertyName].ToString()), item[yoperacion.DataPropertyName].ToString(),
                                item[yglosa.DataPropertyName].ToString(), item[yglosa2.DataPropertyName].ToString(), (int)item[yidasiento.DataPropertyName], 0
                                , item[yComentario.DataPropertyName].ToString());
                        }
                        //Esto es cuando ya existe en la base le pasamos cero en el estado para que no altere el contador
                        if ((int)item[xEstado.DataPropertyName] == 0 || (int)item[xEstado.DataPropertyName] == 1)
                        {
                            int tipo = (int)item[xtipo.DataPropertyName];
                            CapaLogica.ConciliacionDetalle(1, PkId, (int)item[ypkid.DataPropertyName], tipo, null,
                                item[ycuo.DataPropertyName].ToString(), DateTime.Parse(item[yFecha.DataPropertyName].ToString()), FechaEjecucion,
                                //(tipo == 1 ? -1 : 1) *
                                decimal.Parse(item[ymonto.DataPropertyName].ToString()), item[yoperacion.DataPropertyName].ToString(),
                               item[yglosa.DataPropertyName].ToString(), item[yglosa2.DataPropertyName].ToString(), (int)item[yidasiento.DataPropertyName], 1
                               , item[yComentario.DataPropertyName].ToString());
                        }
                    }
                    else
                    {
                        if ((int)item[xEstado.DataPropertyName] == 1)
                        {
                            int tipo = (int)item[xtipo.DataPropertyName];
                            CapaLogica.ConciliacionDetalle(1, PkId, (int)item[ypkid.DataPropertyName], tipo, (int)item[ygrupo.DataPropertyName],
                               item[ycuo.DataPropertyName].ToString(), DateTime.Parse(item[yFecha.DataPropertyName].ToString()), FechaEjecucion,
                                //(tipo == 1 ? 1 : -1) *
                                decimal.Parse(item[ymonto.DataPropertyName].ToString()), item[yoperacion.DataPropertyName].ToString(),
                              item[yglosa.DataPropertyName].ToString(), item[yglosa2.DataPropertyName].ToString(), (int)item[yidasiento.DataPropertyName], 0
                              , item[yComentario.DataPropertyName].ToString());
                        }
                        if ((int)item[xEstado.DataPropertyName] == -1)
                        {
                            int tipo = (int)item[xtipo.DataPropertyName];
                            CapaLogica.ConciliacionDetalle(1, PkId, (int)item[ypkid.DataPropertyName], tipo, (int)item[ygrupo.DataPropertyName],
                               item[ycuo.DataPropertyName].ToString(), DateTime.Parse(item[yFecha.DataPropertyName].ToString()), FechaEjecucion,
                                //(tipo == 1 ? 1 : -1) * 
                                decimal.Parse(item[ymonto.DataPropertyName].ToString()), item[yoperacion.DataPropertyName].ToString(),
                              item[yglosa.DataPropertyName].ToString(), item[yglosa2.DataPropertyName].ToString(), (int)item[yidasiento.DataPropertyName], -1
                              , item[yComentario.DataPropertyName].ToString());
                        }
                        if ((int)item[xEstado.DataPropertyName] == 0)
                        {
                            int tipo = (int)item[xtipo.DataPropertyName];
                            CapaLogica.ConciliacionDetalle(1, PkId, (int)item[ypkid.DataPropertyName], tipo, (int)item[ygrupo.DataPropertyName],
                               item[ycuo.DataPropertyName].ToString(), DateTime.Parse(item[yFecha.DataPropertyName].ToString()), FechaEjecucion,
                                decimal.Parse(item[ymonto.DataPropertyName].ToString()), item[yoperacion.DataPropertyName].ToString(),
                              item[yglosa.DataPropertyName].ToString(), item[yglosa2.DataPropertyName].ToString(), (int)item[yidasiento.DataPropertyName], -1
                              , item[yComentario.DataPropertyName].ToString());
                        }
                    }
                }
                //fin Cabecera
                //Fin del Detalle
                //Fin de Grabados en la Base de Datos

                //Finalizamos
                msg("La Conciliación se Grabo con Exito." + Result);
                BtnCerrar_Click(sender, e);
                buttonPer1_Click(sender, null);
            }
            else msgError("Cancelado por el Usuario");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblRegistroExcel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblFunciones_Click(object sender, EventArgs e)
        {

        }

        private void lblmanual_Click(object sender, EventArgs e)
        {

        }

        private void btnReversar_Click(object sender, EventArgs e)
        {
            if (msgYesCancel("Este Periodo Ya esta Conciliado, Seguro Desea Reversarlo?") == DialogResult.Yes)
            {
                CapaLogica.ConciliacionCabeceraEliminar(pkEmpresa, comboMesAño1.FechaFinMes, pkidCtaBanco);
                msg("Se Elimino la Conciliación Anterior");
                BtnCerrar_Click(sender, e);
            }
        }
        private void chkOperacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOperacion.Checked)
                foreach (DataRow item in TdatosSist.Rows)
                    if (item[xGrupo.DataPropertyName].ToString() != "")
                        item[xUpdate.DataPropertyName] = 1;
        }
        private void lblTotales_Click(object sender, EventArgs e)
        {

        }

        private void MostrarTotales()
        {
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            SumaExcel = SumaSistema = 0;
            foreach (DataRow item in TdatosExcel.Rows)
            {
                if ((int)item[xok.DataPropertyName] == 1)
                {
                    SumaExcel += decimal.Parse(item[xMonto.DataPropertyName].ToString());
                }
                if (item[xGrupo.DataPropertyName].ToString() == "")
                    x2++;
                else x1++;
            }
            foreach (DataRow item in TdatosSist.Rows)
            {
                if ((int)item[yok.DataPropertyName] == 1)
                    SumaSistema += (decimal)item[ymonto.DataPropertyName];
                if (item[ygrupo.DataPropertyName].ToString() == "")
                    y2++;
                else y1++;
            }
            if (SumaExcel + SumaSistema == 0)
                lblTotales.Text = "Seleccione Filas en las 2 Tablas";
            else
            {
                lblTotales.Text = $"Excel: {SumaExcel.ToString("n2")}, Sistema:{SumaSistema.ToString("n2")}, Dif:{(SumaExcel - SumaSistema).ToString("n2")}";
            }
            ContarRegistros(x1, x2, y1, y2);
        }
    }
}
