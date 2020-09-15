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

namespace HPReserger.ModuloRRHH
{
    public partial class frmReporteRenta : FormGradient
    {
        public frmReporteRenta()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private bool Cargado;
        private DataTable TDatos;
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgE(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void CargarTextosPorDefecto()
        {
            txtbusEmpleado.CargarTextoporDefecto();
            txtbusEmpresa.CargarTextoporDefecto();
            cbofechade.Fecha(new DateTime(DateTime.Now.Year, 1, 1));
            cbofechahasta.Fecha(new DateTime(DateTime.Now.Year, 12, 31));
        }
        DateTime FechaInicial, FechaFinal;
        private void MostrarDatosFiltrados()
        {
            if (Cargado)
            {
                FechaInicial = cbofechade.FechaInicioMes;
                FechaFinal = cbofechahasta.FechaFinMes;
                if (cbofechade.GetFechaPRimerDia() > cbofechahasta.GetFechaPRimerDia())
                {
                    FechaInicial = cbofechahasta.FechaInicioMes;
                    FechaFinal = cbofechade.FechaFinMes;
                }
                TDatos = CapaLogica.AfpReporte(2, txtbusEmpresa.TextValido(), txtbusEmpleado.TextValido(), "", FechaInicial, FechaFinal);
                dtgconten.DataSource = TDatos;
                lblRegistros.Text = $"Total Registros: {dtgconten.RowCount}";
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Cargado = false;
            CargarTextosPorDefecto();
            Cargado = true;
            MostrarDatosFiltrados();
        }

        private void buttonPer1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void txtbusEmpleado_TextChanged(object sender, EventArgs e)
        {
            MostrarDatosFiltrados();
        }
        private void cbofechade_CambioFechas(object sender, EventArgs e)
        {
            MostrarDatosFiltrados();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarDatosFiltrados();
        }
        private void frmReporteAFP_Load(object sender, EventArgs e)
        {
            CargarTextosPorDefecto();
            Cargado = true;
            MostrarDatosFiltrados();
        }
        frmProcesando frmpro;
        private string Empresa;
        private string cadenaFecha;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                int[] _ColumnasAutoajustar = new int[] { 2, 3, 4, 5 };
                //
                _NombreHoja = $"Resumen de Renta {FechaInicial.ToString("dd-MM-yyyy")} Al {FechaFinal.ToString("dd-MM-yyyy")}".ToUpper();
                _Cabecera = "Resumen de las Renta";
                _NColumna = "H";
                _ColumnasAutoajustar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
                _Columnas = new int[] { 1, 2, 3, 4, 5, 6 };
                //
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                //HPResergerFunciones.Utilitarios.RangoCelda Celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", "Cronograma de Pagos", 14);
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                int PosInicialGrilla = 3;
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", $"{_NColumna}1", _Cabecera.ToUpper(), 10, true, true, Back, Fore, Configuraciones.FuenteReportesTahoma10));
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", $"{_NColumna}2", cadenaFecha, 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                if (txtbusEmpresa.EstaLLeno())
                {
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{PosInicialGrilla}", $"{_NColumna}{PosInicialGrilla}", "Filtro: Empresa; " + Empresa, 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                    PosInicialGrilla++;
                }
                if (txtbusEmpleado.EstaLLeno())
                {
                    Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda($"a{PosInicialGrilla}", $"{_NColumna}{PosInicialGrilla}", $"Filtro: Empleado; {NombreEmpleado}", 8, false, true, Back, Fore, Configuraciones.FuenteReportesTahoma8));
                    PosInicialGrilla++;
                }
                //
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, Configuraciones.FuenteReportesTahoma8, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                DataTable TableResuk = new DataTable();
                TableResuk = (TDatos).Copy();
                //Cambiamos las Cabeceras de las Columnas  
                foreach (DataGridViewColumn item in dtgconten.Columns)
                {
                    TableResuk.Columns[item.DataPropertyName].ColumnName = item.HeaderText;
                }
                //Removemos las Columnas que no Necesitamos        
                //TableResuk.Columns.RemoveAt(9);
                //TableResuk.Columns.RemoveAt(6);
                //TableResuk.Columns.RemoveAt(5);

                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableResuk, CeldaCabecera, CeldaDefault, "", _NombreHoja, Celdas, PosInicialGrilla, _Columnas, new int[] { }, _ColumnasAutoajustar, "");
                PosInicialGrilla++;
            }
            else msg("No hay Registros en la Grilla");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmpro.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                frmpro = new frmProcesando();
                frmpro.Show(); Cursor = Cursors.WaitCursor;
                cadenaFecha = $"Fecha de : {FechaInicial.ToShortDateString() } Hasta: {FechaFinal.ToShortDateString()}";
                Empresa = txtbusEmpresa.TextValido();
                NombreEmpleado = txtbusEmpleado.TextValido();
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else { msgE("No hay Datos que Mostrar"); }
        }

        public string NombreEmpleado;
        private void dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.Rows.Count > 0)
            {
                pkempresa = (int)dtgconten[xpkempresa.Index, 0].Value;
            }
        }        
        private int _pkEmpresa;
        public int pkempresa
        {

            get { return _pkEmpresa; }
            set
            {
                var Buscar = false;
                if (value != _pkEmpresa)
                {
                    Buscar = true;
                }
                _pkEmpresa = value;
                if (Buscar) ConsultarcuentaBancaria();
            }
        }

        public int CtaBancaria { get; private set; }
        private void btnTXT_Click(object sender, EventArgs e)
        {
            if (dtgconten.Rows.Count == 0) { msgE("No hay Datos en la Grilla"); return; }
            if (cboCuentaBancaria.SelectedValue == null) { msgE("Seleccione una Cuenta Bancaria"); return; }
            if (cboCuentaBancaria.DataSource == null) { msgE("No hay cuentas Bancarias para seleccionar"); return; }
            foreach (DataRow item in ((DataTable)dtgconten.DataSource).Rows)
            {
                if ((int)item[xpkempresa.DataPropertyName] != pkempresa)
                {
                    msgE("Hay mas de una empresa en la grilla"); return;
                }
            }

            if (msgYesCancel("Seguro Desea Generar el TXT", "Generando el TXT y Pago") == DialogResult.Yes)
            {
                CtaBancaria = (int)cboCuentaBancaria.SelectedValue;
                if (SaveFile.FileName == "") SaveFile.FileName = $"Pago Renta -{cboCuentaBancaria.Text}.txt";
                DialogResult Dial = SaveFile.ShowDialog();
                if (Dial != DialogResult.OK) { msgE("Cancelado por el Usuario"); return; }
                ProcesodeGrabadoenBase();
                ProcesodeGenerarTXT();
                msgOK("Generado con Exito");
                MostrarDatosFiltrados();
            }
        }
        private StreamWriter st;
        public DialogResult msgYesCancel(string cadena, string detalle) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena, detalle); }

        private void ProcesodeGenerarTXT()
        {
            //Avanza para Generar el TXT
            string[] campo = new string[dtgconten.Columns.Count];
            string cadenatxt = "";            //int ValorPrueba = 0;
            DataTable TablaPrueba = ((DataTable)dtgconten.DataSource);
            foreach (DataRow Filas in TablaPrueba.Rows)
            {
                int c = 0;
                foreach (DataColumn Col in TablaPrueba.Columns)
                {
                    campo[c++] = Filas[Col.ColumnName].ToString();
                }
                //Uniendo por pipes
                cadenatxt += string.Join("|", campo) + $"{Environment.NewLine }";
                //Limpiamos el Campo
                //campo = null;
            }
            //Formato 1.1
            //SaveFile.FileName = $"PAgoAFP.txt";
            string path = SaveFile.FileName;
            st = File.CreateText(path);
            st.Write(cadenatxt);
            st.Close();
        }
        private void ProcesodeGrabadoenBase()
        {
            foreach (DataRow item in ((DataTable)dtgconten.DataSource).Rows)
            {
                int tipoid = (int)item[xtipoid.DataPropertyName];
                string doc = item[NroDoc.DataPropertyName].ToString();
                DateTime fecha = (DateTime)item[xFechaIngreso.DataPropertyName];
                int Empresa = (int)item[xpkempresa.DataPropertyName];
                decimal monto = (decimal)item[xRenta.DataPropertyName];
                CapaLogica.ActualizarReporteAfpRentaSeguros(2, tipoid, doc, fecha, Empresa, CtaBancaria, monto);
            }
        }
        ModuloRRHH.frmReporteRentaPagados frmReporteRentaPagados1;
        private void btnVerPagados_Click(object sender, EventArgs e)
        {
            if (frmReporteRentaPagados1 == null)
            {
                frmReporteRentaPagados1 = new frmReporteRentaPagados();
                frmReporteRentaPagados1.FormClosed += frmReporteRentaPagados_FormClosed;
                frmReporteRentaPagados1.MdiParent = MdiParent;
                frmReporteRentaPagados1.Show();
            }
            else frmReporteRentaPagados1.Activate();
        }

        private void frmReporteRentaPagados_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmReporteRentaPagados1 = null;
        }
        private void ConsultarcuentaBancaria()
        {
            string cadena = cboCuentaBancaria.Text;
            DataTable TCuentas = CapaLogica.BuscarCuentasBancariasxEmpresas(pkempresa);
            //if (cboCuentaBancaria.Items.Count != TCuentas.Rows.Count)
            //if (Cargar)
            {
                cboCuentaBancaria.DisplayMember = "cuentabancaria";
                cboCuentaBancaria.ValueMember = "id_tipo_cta";
                cboCuentaBancaria.DataSource = TCuentas;
                if (cboCuentaBancaria.DataSource != null) cboCuentaBancaria.Text = cadena;
            }
        }
    }
}
