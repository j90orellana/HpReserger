using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger.ModuloCompensaciones
{
    public partial class frmCompensacionCuentas : FormGradient
    {
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private int pkEmpresa;
        private int _Estado = 0;
        public int Estado
        {
            get { return _Estado; }
            set
            {
                _Estado = value;
                //Control del Formulario
                Boolean a = true;
                btnPaso1.Enabled = !a;
                if (value == 0)
                {
                    cboempresa.Enabled = a;
                    txtcuos.Enabled = a;
                    txtCuentas.Enabled = txtRucs.Enabled = chkFecha.Enabled = dtpfechade.Enabled = dtpFechaHasta.Enabled = a;
                    dtgconten.Enabled = !a;
                    btnPaso1.Enabled = a;
                    if (dtgconten.DataSource != null)
                    {
                        dtgconten.DataSource = ((DataTable)dtgconten.DataSource).Clone();
                    }
                    else dtgconten.DataSource = null;
                    lbltotalRegistros.Text = $"Total de Registros:{dtgconten.RowCount}";
                    contador = 0;
                    MostrarParteFinal();
                }
                else if (value == 1)
                {
                    cboempresa.Enabled = !a;
                    txtcuos.Enabled = !a;
                    txtCuentas.Enabled = txtRucs.Enabled = chkFecha.Enabled = dtpfechade.Enabled = dtpFechaHasta.Enabled = !a;
                    dtgconten.Enabled = a;
                }
            }
        }

        public string NameEmpresa { get; private set; }
        public void msgError(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        public frmCompensacionCuentas()
        {
            InitializeComponent();
        }
        private void frmCompensacionCuentas_Load(object sender, EventArgs e)
        {
            DateTime Fecha = DateTime.Now;
            dtpFechaHasta.Value = dtpFechaContable.Value = dtpFechaEmision.Value = Fecha;
            dtpfechade.Value = new DateTime(Fecha.Year, Fecha.Month, 1);
            CargarTextxDefecto();
            Estado = 0;
            CargarEmpresa();
            CargarMonedas();
        }
        public void CargarMonedas()
        {
            CapaLogica.TablaMonedas(cbomoneda);
        }
        private void CargarTextxDefecto()
        {
            txtcuos.CargarTextoporDefecto();
            txtCuenta.CargarTextoporDefecto();
            txtGlosa.CargarTextoporDefecto();
            txtRucs.CargarTextoporDefecto();
            txtCuentas.CargarTextoporDefecto();
        }
        public void CargarEmpresa()
        {
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
            cboempresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
        }

        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pkEmpresa != (int)(cboempresa.SelectedValue))
            {
                pkEmpresa = (int)cboempresa.SelectedValue;
                cboproyecto.DataSource = CapaLogica.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString());
                cboproyecto.DisplayMember = "proyecto";
                cboproyecto.ValueMember = "id_proyecto";
                NameEmpresa = cboempresa.Text;
            }
        }
        private void cboempresa_Click(object sender, EventArgs e)
        {
            string cadena = cboempresa.Text;
            DataTable Table = CapaLogica.Empresa();
            if (cboempresa.Items.Count != Table.Rows.Count)
                cboempresa.DataSource = Table;
            cboempresa.Text = cadena;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (Estado == 0)
            {
                this.Close();
            }
            else Estado--;
        }
        DataTable Tdatos = new DataTable();
        private int contador;

        private void btnPaso1_Click(object sender, EventArgs e)
        {
            if (cboempresa.SelectedValue == null) { msgError("Seleccione una Empresa"); cboempresa.Focus(); return; }
            if (Configuraciones.ValidarSQLInyect(txtcuos)) { msgError("Codigo Malicioso Detectado"); txtcuos.Focus(); return; }
            //if (!txtcuos.EstaLLeno()) { msgError("Ingrese 2 CUOS minimos"); txtcuos.Focus(); return; }
            //if ((txtcuos.TextValido().Split(',')).Count() < 2) { msgError("Ingrese 2 CUOS minimos"); txtcuos.Focus(); return; }
            List<string> Listado = new List<string>();
            DateTime Fechade;
            DateTime FechaHasta;
            FechaHasta = dtpFechaHasta.Value; Fechade = dtpfechade.Value;
            if (dtpfechade.Value > dtpFechaHasta.Value) { Fechade = dtpFechaHasta.Value; FechaHasta = dtpfechade.Value; }
            //
            Cursor = Cursors.WaitCursor;
            Tdatos = CapaLogica.CompensacionDeCuentas(pkEmpresa, txtcuos.TextValido(), txtCuentas.TextValido(), txtRucs.TextValido(), chkFecha.Checked ? 1 : 0, Fechade, FechaHasta);
            Cursor = Cursors.Default;
            if (Tdatos == null) { msgError("No Hay Asientos que mostrar"); return; }
            foreach (DataRow item in Tdatos.Rows)
            {
                if (!Listado.Contains(item["cuo"].ToString())) Listado.Add(item["cuo"].ToString());
            }
            if (Listado.Count < 2) { msgError("No hay Datos para mostrar"); return; }

            Estado++;
            dtgconten.DataSource = Tdatos;
            lbltotalRegistros.Text = $"Total de Registros:{dtgconten.RowCount}";
            //Cambio de color de fondo por cuos
            int pos = 0;
            string cuo = "";
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if (item.Cells[xCUO.Name].Value.ToString() != cuo)
                {
                    pos = pos == 0 ? 1 : 0;
                }
                cuo = item.Cells[xCUO.Name].Value.ToString();
                if (pos == 0)
                    item.DefaultCellStyle.BackColor = Color.White;
                else
                    item.DefaultCellStyle.BackColor = Color.FromArgb(220, 230, 241);
            }
        }
        decimal SumaSoles = 0, SumaDolares = 0;
        private int idDinamica = -23;
        private void dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.ColumnIndex == dtgconten.Columns[xok.Name].Index)
                {
                    CalcularTotales();
                }
        }
        private void txtCuenta_DoubleClick(object sender, EventArgs e)
        {
            frmlistarcuentas cuentitas = new frmlistarcuentas();
            cuentitas.Icon = Icon;

            cuentitas.Txtbusca.Text = txtCuenta.Text;
            cuentitas.radioButton1.Checked = true;
            cuentitas.ShowDialog();
            if (cuentitas.aceptar)
                txtCuenta.Text = cuentitas.codigo;
        }
        private void txtCuenta_TextChanged(object sender, EventArgs e)
        {
            if (txtCuenta.EstaLLeno())
            {
                DataTable TAble = CapaLogica.BuscarCuentas(txtCuenta.Text, 1);
                if (TAble.Rows.Count > 0)
                    txtdescripcion.Text = TAble.Rows[0][0].ToString();
                else txtdescripcion.Text = "";
            }
            else txtdescripcion.CargarTextoporDefecto();

        }

        private void dtgconten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.ColumnIndex == dtgconten.Columns[xok.Name].Index)
                {
                    dtgconten.EndEdit(); dtgconten.RefreshEdit();
                    // CalcularTotales();
                }
        }

        private void CalcularTotales()
        {
            SumaSoles = 0; SumaDolares = 0;
            contador = 0;
            if (Estado == 1)
            {
                foreach (DataRow item in Tdatos.Rows)
                {
                    if ((int)item[xok.DataPropertyName] == 1)
                    {
                        contador++;
                        SumaSoles += (decimal)item[xPEN.DataPropertyName];
                        SumaDolares += (decimal)item[xUSD.DataPropertyName];
                    }

                }
            }
            MostrarParteFinal();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (cboproyecto.SelectedValue == null) { msgError("Seleccione un Proyecto"); cboproyecto.Focus(); return; }
            if (cbomoneda.SelectedValue == null) { msgError("Seleccione una Moneda"); cbomoneda.Focus(); return; }
            if (!txtGlosa.EstaLLeno()) { msgError("Ingrese una Glosa"); txtGlosa.Focus(); return; }
            if (cboempresa.SelectedValue == null) { msgError("Seleccione una Empresa"); cboempresa.Focus(); return; }
            if (SumaDolares + SumaSoles != 0)
                if (!txtdescripcion.EstaLLeno()) { msgError("Ingrese una Cuenta Contable para mandar la Diferencia"); txtCuenta.Focus(); return; }

            //msgError("No se ha Generado Diferencia"); return; }
            //
            //Validacion de que el periodo NO sea muy disperso, sea un mes continuo a los trabajados        
            DateTime FechaContable = dtpFechaContable.Value;
            if (!CapaLogica.ValidarCrearPeriodo(pkEmpresa, FechaContable))
            {
                if (HPResergerFunciones.frmPregunta.MostrarDialogYesCancel("No se Puede Registrar este Asiento\nEl Periodo no puede Crearse", $"¿Desea Crear el Periodo de {FechaContable.ToString("MMMM")}-{FechaContable.Year}?") != DialogResult.Yes)
                    return;
            }
            if (!CapaLogica.VerificarPeriodoAbierto(pkEmpresa, FechaContable))
            {
                msgError("El Periodo Esta Cerrado, Cambie Fecha Contable"); dtpFechaContable.Focus(); return;
            }
            if (msgp("¿Seguro Desea Grabar la Compensacion?") == DialogResult.Yes)
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
                string Cuo = HPResergerFunciones.Utilitarios.Cuo(numasiento, dtpFechaContable.Value);
                int moneda = (int)cbomoneda.SelectedValue;
                int proyecto = (int)cboproyecto.SelectedValue;
                string GlosaCab = txtGlosa.TextValido();
                DateTime FechaEmision = dtpFechaEmision.Value;
                //
                int idUsuario = frmLogin.CodigoUsuario;
                //
                List<string> LCuentas = new List<string>();
                //Add Listado de Cuentas
                foreach (DataRow item in Tdatos.Rows)
                    if ((int)item[xok.DataPropertyName] == 1)
                        if (!LCuentas.Contains(item[xCuenta.DataPropertyName].ToString()))
                            LCuentas.Add(item[xCuenta.DataPropertyName].ToString());
                //Grabamos Cabecera y Detalle de los Datos de la Grilla
                DataView dv = new DataView(Tdatos);
                decimal Soles = 0, Dolares = 0;
                //VALIDAMOS QUE NO EXISTAN CUENTAS CONTABLES DESACTIVADAS
                List<string> ListaAuxiliar = new List<string>();
                foreach (string Cuenta in LCuentas)
                    ListaAuxiliar.Add(Cuenta);
                ListaAuxiliar.Add(txtCuenta.Text);
                if (CapaLogica.CuentaContableValidarActivas(string.Join(",", ListaAuxiliar.ToArray()), "Cuentas Contables Desactivadas")) return;
                //FIN DE LA VALDIACION DE LAS CUENTAS CONTABLES DESACTIVADAS
                //foreach (var item in collection)                
                //{
                //    Soles = Dolares = 0;
                //dv.RowFilter = $"ok=1";
                //    foreach (DataRow itemx in dv.ToTable().Rows)
                //    {
                //        Soles += (decimal)itemx[xPEN.DataPropertyName];
                //        Dolares += (decimal)itemx[xUSD.DataPropertyName];
                //    }
                //    int FactorSOles = Soles > 0 ? 1 : -1;
                //    int FactorDolares = Dolares > 0 ? 1 : -1;
                //GRABADO DE LOS REGISTROS LINEA A LINEA
                dv.RowFilter = $"ok=1";
                foreach (DataRow itemx in dv.ToTable().Rows)
                {
                    //Grabamos la Cabeceras
                    string Cuenta = itemx[xCuenta.DataPropertyName].ToString();
                    decimal DebePen = (decimal)itemx[xPEN.DataPropertyName];
                    decimal HaberPen = (decimal)itemx[xPEN.DataPropertyName];
                    decimal DebeUsd = (decimal)itemx[xUSD.DataPropertyName];
                    decimal HaberUsd = (decimal)itemx[xUSD.DataPropertyName];
                    //
                    DebePen = DebePen < 0 ? DebePen : 0;
                    HaberPen = HaberPen > 0 ? HaberPen : 0;
                    DebeUsd = DebeUsd < 0 ? DebeUsd : 0;
                    HaberUsd = HaberUsd > 0 ? HaberUsd : 0;
                    //
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, Cuenta,
                       Math.Abs(moneda == 1 ? DebePen : DebeUsd),
                       Math.Abs(moneda == 1 ? HaberPen : HaberUsd),
                        //(moneda == 1 ? Soles : Dolares) > 0 ? Math.Abs((moneda == 1 ? Soles : Dolares)) : 0,
                        //(moneda == 1 ? Soles : Dolares) < 0 ? Math.Abs((moneda == 1 ? Soles : Dolares)) : 0,
                        3.3000m, proyecto, 0, Cuo, moneda, GlosaCab, FechaEmision, idDinamica);
                    //Grabamos el Detalle 
                    CapaLogica.InsertarDetalleAsiento(11, PosFila, numasiento, FechaContable, Cuenta, proyecto, (int)itemx[xtipodoc.DataPropertyName], itemx[xNumDoc.DataPropertyName].ToString(),
                        itemx[xRazonSocial.DataPropertyName].ToString(), (int)itemx[xidComprobante.DataPropertyName], itemx[xCodComprobante.DataPropertyName].ToString(),
                        itemx[xNumComprobante.DataPropertyName].ToString(), (int)itemx[xCC.DataPropertyName], (DateTime)itemx[xFechaEmision.DataPropertyName],
                        (DateTime)itemx[xFechaVence.DataPropertyName], (DateTime)itemx[xFechaREcepcion.DataPropertyName],
                       Math.Abs(DebePen + HaberPen), Math.Abs(DebeUsd + HaberUsd),
                        (decimal)itemx[xTC.DataPropertyName], (int)itemx[xfkmoneda.DataPropertyName],
                        (int)itemx[xctabanco.DataPropertyName], "", itemx[xGlosa.DataPropertyName].ToString(), FechaContable, idUsuario, itemx[xCUO.DataPropertyName].ToString(), 0);
                    //}
                }
                //Grabamos lo que se envia a la cuenta de diferencia           
                if (SumaSoles + SumaDolares != 0)
                {
                    CapaLogica.InsertarAsientoFacturaCabecera(1, ++PosFila, numasiento, FechaContable, txtCuenta.Text,
                        (moneda == 1 ? SumaSoles : SumaDolares) > 0 ? Math.Abs((moneda == 1 ? SumaSoles : SumaDolares)) : 0,
                        (moneda == 1 ? SumaSoles : SumaDolares) < 0 ? Math.Abs((moneda == 1 ? SumaSoles : SumaDolares)) : 0,
                        3.3000m, proyecto, 0, Cuo, moneda, GlosaCab, FechaEmision, idDinamica);
                    //Grabamos el Detalle 
                    CapaLogica.InsertarDetalleAsiento(11, PosFila, numasiento, FechaContable, txtCuenta.Text, proyecto, 0, "99999999", "", 0, "", "9999", 0, FechaEmision, FechaContable, FechaContable,
                        -1 * Math.Abs(SumaSoles), -1 * Math.Abs(SumaDolares), 3.3000m, moneda, 0, "", GlosaCab, FechaContable, idUsuario, "", 0);
                }//Fin de la Grabacion
                msgOK($"Compensación Grabada con Exito con Cuo: {Cuo}");
                Estado = 0;
            }
        }

        private void checkboxOre1_CheckedChanged(object sender, EventArgs e)
        {
            dtpfechade.Enabled = dtpFechaHasta.Enabled = false;
            if (chkFecha.Checked) dtpfechade.Enabled = dtpFechaHasta.Enabled = true;
        }
        private void SerializarTexto(TextBox textbox)
        {
            string txt = textbox.Text;
            string cadena = $"{txt},";// {Clipboard.GetText()},";
            cadena = cadena.Replace("\n", ",");
            cadena = cadena.Replace("\r", ",");
            cadena = cadena.Replace(" ", ",");
            string[] Array = cadena.Split(',');
            string[] Array2 = Array.OrderBy(x => x).GroupBy(x => x).Select(x => x.Key).ToArray();
            textbox.Text = $"{string.Join(",", Array2)},";
        }
        private void txtcuos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)//control v         
            {
                SerializarTexto((TextBox)sender);
                e.Handled = false;
            }
        }
        private void dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
            {
                if (dtgconten.Rows.Count > 0)
                {
                    int val = (int)Tdatos.Rows[0][xok.DataPropertyName];
                    foreach (DataRow item in Tdatos.Rows)
                    {
                        item[xok.DataPropertyName] = val == 1 ? 0 : 1;
                    }
                }
                CalcularTotales();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                dtgconten[xok.Name, e.RowIndex].Value = (int)dtgconten[xok.Name, e.RowIndex].Value == 1 ? 0 : 1;
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            //VALIDACIONES
            if (cboempresa.SelectedValue == null) { cboempresa.Focus(); msgError("Seleccione una Empresa"); return; }
            if (Tdatos.Rows.Count == 0)
            {
                msgError("No hay Registros para Mostrar");
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                backgroundWorker1.WorkerSupportsCancellation = true;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.Default;
                    frmproce = new HPReserger.frmProcesando();
                    frmproce.Show();
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
                else
                {
                    Cursor = Cursors.Default;
                    return;
                }
            }
        }
        frmProcesando frmproce;
        private void btnexcel_Click_1(object sender, EventArgs e)
        {
            if (Tdatos.Rows.Count == 0)
            {
                msgError("No hay Registros para Mostrar");
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                backgroundWorker1.WorkerSupportsCancellation = true;
                //   if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                Cursor = Cursors.Default;
                frmproce = new HPReserger.frmProcesando();
                frmproce.Show();
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }

                else
                {
                    Cursor = Cursors.Default;
                    return;
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Tdatos.Rows.Count > 0)
            {
                //DESARROLLO PARA MOSTRAR EL ESQUEMA DEL REPORTE DEL EXCEL                
                List<string> ListCuentas = new List<string>();
                //AGREGAMOS LAS CUENTAS CONTABLES A UNA LISTA PARA FILTRAR
                DataView dv = Tdatos.AsDataView();
                string Carpeta = Application.CommonAppDataPath;
                //
                string EmpresaValor = Configuraciones.ValidarRutaValida(NameEmpresa);
                //string Ruc = CapaLogica.BuscarRucEmpresa(EmpresaValor)[0].ToString();
                string valor = Carpeta + @"\";
                //if (chkCarpetas.Checked)
                //{
                valor = Carpeta + @"\" + EmpresaValor + @"\";
                string directorio = (Carpeta + @"\" + EmpresaValor).Replace(" ", "_");
                if (!Directory.Exists(directorio))
                    Directory.CreateDirectory(directorio);
                //}
                string NameFile = "";
                NameFile = valor + $"C.Cta {EmpresaValor}.xlsx";
                NameFile = NameFile.Replace(" ", "_");
                //ELiminamos el Excel Antiguo
                try
                {
                    if (File.Exists(NameFile)) File.Delete(NameFile);
                }
                catch { msgError("El Archivo Esta Abierto"); }
                //DEFINICIONES
                int i = 0; //posicion de la hoja no  es index
                int Hoja = 0;
                //
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(Configuraciones.BackAlterno, Configuraciones.FuenteReportesTahoma10, Configuraciones.ForeAlterno);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(Configuraciones.BackColumna, Configuraciones.FuenteReportesTahoma10, Configuraciones.ForeColumna);
                //RECORREMOS EL RANGO DE PERIODOS QUE SE INGRESO               
                i = 0;
                Hoja++;
                String _NombreHoja = $"Compensar Cuentas";
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{1 + i}", $"R{1 + i}", EmpresaValor, 12, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{2 + i}", $"R{2 + i}", "CUENTAS A COMPENSAR", 9, false, true, HPResergerFunciones.Utilitarios.Alineado.izquierda, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                //Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"A{4 + i}", $"R{4 + i}", ($"COSTO Y DEPRECIACIÓN ACUMULADA AL {FechaTempFinMes.ToString("dd 'DE' MMMM yyyy")}").ToUpper(), 9, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));
                DataTable TResult = dv.ToTable();
                Configuraciones.CambiarNombreColumnsTablaGrilla(TResult, dtgconten.Columns);
                Configuraciones.QuitarColumnas(TResult, new int[] { 0, 18, 14, 19, 20, 21, 22 });
                int FilCabecera = 5;
                foreach (DataColumn item in TResult.Columns)
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"{char.ConvertFromUtf32(65 + i)}{FilCabecera}", $"{char.ConvertFromUtf32(65 + i++)}{FilCabecera}", item.ColumnName, 9, true, true, HPResergerFunciones.Utilitarios.Alineado.centro, Color.White, Color.Black, Configuraciones.FuenteReportesTahoma10, true));

                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnasCreado(TResult, CeldaCabecera, CeldaDefault, NameFile, _NombreHoja, Hoja, Celdas, FilCabecera, new int[] { }, new int[] { },
                  new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 }, "", true);
                //Agregamos un MES  

                // msgOK($"Archivo Grabados en \n{folderBrowserDialog1.SelectedPath}");
                //ProcessStartInfo startInfo = new ProcessStartInfo();
                //startInfo.FileName = "EXCEL.EXE";
                //startInfo.Arguments = NameFile;
                //Process.Start(startInfo);
                Process.Start(NameFile);
                if (backgroundWorker1.IsBusy) backgroundWorker1.CancelAsync();
            }
            else msgError("No hay Registros en la Grilla");
        }

        private void txtcuos_DoubleClick(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = MostrarTextoenVentana(((TextBox)sender).Text, "Ver");
            SerializarTexto((TextBox)sender);
        }

        private string MostrarTextoenVentana(string text, string v)
        {
            frmMemoPremioObservaciones frmver = new frmMemoPremioObservaciones();
            frmver.Text = v;
            frmver.Observaciones = text;
            frmver.MostrarDatos();
            if (frmver.ShowDialog() != DialogResult.OK)
                return frmver.Observaciones;
            return "";
        }

        private void txtSoles_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgconten_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if ((int)dtgconten[xok.Name, e.RowIndex].Value == 1)
                    HPResergerFunciones.Utilitarios.ColorFilaSeleccionada(dtgconten.Rows[e.RowIndex], Configuraciones.ColorFilaSeleccionada);// Color.FromArgb(137, 171, 211));
                else
                    HPResergerFunciones.Utilitarios.ColorFilaDefecto(dtgconten.Rows[e.RowIndex]);
            }
        }

        private void MostrarParteFinal()
        {
            //Bloquear Controles
            Boolean a = true;
            txtCuenta.Enabled = !a;
            txtdescripcion.Enabled = !a;
            txtGlosa.Enabled = !a;
            btnProcesar.Visible = !a;
            txtSoles.Text = SumaSoles.ToString("n2");
            txtDolares.Text = SumaDolares.ToString("n2");
            //
            cboproyecto.Enabled = !a;
            cbomoneda.Enabled = !a;
            dtpFechaContable.Enabled = !a;
            dtpFechaEmision.Enabled = !a;
            if (contador > 1)
            {
                //Desbloquearlos
                txtCuenta.Enabled = a;
                txtdescripcion.Enabled = a;
                txtGlosa.Enabled = a;
                btnProcesar.Visible = a;
                cboproyecto.Enabled = dtpFechaContable.Enabled = dtpFechaEmision.Enabled = a;
                cbomoneda.Enabled = a;
                if (SumaSoles + SumaDolares == 0)
                {
                    txtCuenta.Enabled = a;
                }
            }
        }
    }
}
