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
        private void buttonPer1_Click(object sender, EventArgs e)
        {
            Estado = 1;
            PasarAPaso1(true);
            if (File.Exists(txtRutaExcel.Text)) btnPaso2.Enabled = true;
        }
        int Cfilas = 0;
        private void btnPaso2_Click(object sender, EventArgs e)
        {
            if (CargarDatosDelExcel(txtRutaExcel.Text))
            {
                PasarAPaso2(true);
                Estado = 2;
                BuscanEnSistemMovimientos();
                if (ProcesodeAnalisis(pkBanco, NroCuenta))
                    if (FormatearlaTabla(pkBanco))
                    {
                        //Datos del Excel
                        dtgContenExcel.DataSource = Tdatos;
                        //Datos del Sistema
                        dtgContenSistema.DataSource = TdatosSist;
                        ContarRegistros();
                        OrdenarDataGridViews();
                        ActivarFunciones(true);
                        Cfilas = 0;
                        ConciliarMovimientos(Conciliaciones.FechaMonto);
                        Grilla = 0;
                    }
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
        }
        private void OrdenarDataGridViews(int x, int y)
        {
            //Ordenar TAbla del Excel
            if (Tdatos.Rows.Count != 0)
            {
                DataView dv = new DataView(Tdatos);
                dv.Sort = "index desc, monto desc";
                dtgContenExcel.DataSource = Tdatos = dv.ToTable();
            }
            //Ordenar TAbla del Sistema
            if (TdatosSist.Rows.Count != 0)
            {
                DataView dv = new DataView(TdatosSist);
                dv.Sort = "index desc, monto desc";
                dtgContenSistema.DataSource = TdatosSist = dv.ToTable();
            }
            dtgContenExcel.FirstDisplayedCell = dtgContenExcel[xGrupo.Name, x];
            dtgContenSistema.FirstDisplayedCell = dtgContenSistema[ygrupo.Name, y];
        }
        private void OrdenarDataGridViews()
        {
            //Ordenar TAbla del Excel
            if (Tdatos.Rows.Count != 0)
            {
                DataView dv = new DataView(Tdatos);
                dv.Sort = "index desc, monto desc";
                dtgContenExcel.DataSource = Tdatos = dv.ToTable();
            }
            //Ordenar TAbla del Sistema
            if (TdatosSist.Rows.Count != 0)
            {
                DataView dv = new DataView(TdatosSist);
                dv.Sort = "index desc, monto desc";
                dtgContenSistema.DataSource = TdatosSist = dv.ToTable();
            }
        }
        private void BuscanEnSistemMovimientos()
        {
            TdatosSist = CapaLogica.MovimientoBancariosxEmpresa(pkEmpresa, comboMesAño1.FechaInicioMes, comboMesAño1.FechaFinMes, NroCuenta, pkMoneda);
        }
        private Boolean FormatearlaTabla(int Banco)
        {
            if (Banco == 1) //Banco BCP
            {
                foreach (DataRow item in Tdatos.Rows)
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
                    Tdatos.Columns.RemoveAt(item);
                }
                //Damos Nombres a las Columnas
                Tdatos.Columns[0].ColumnName = "Fecha";
                Tdatos.Columns[2].ColumnName = "Monto";
                Tdatos.Columns[3].ColumnName = "Operacion";
                Tdatos.Columns[1].ColumnName = "Glosa";
                Tdatos.Columns[4].ColumnName = "Glosa2";
                Tdatos.Columns[1].SetOrdinal(3);
                //Agregamos la Columnas
                DataColumn ColOk = new DataColumn("ok", typeof(int));
                ColOk.DefaultValue = 0;
                Tdatos.Columns.Add(ColOk);
                DataColumn ColIndex = new DataColumn("Index", typeof(int));
                ColOk.DefaultValue = 0;
                Tdatos.Columns.Add(ColIndex);
                return true;
            }
            return false;
        }

        private void ContarRegistros()
        {
            lblREgistros.Text = $"Total Registros Excel: {dtgContenExcel.RowCount}; Movimiento Sistema {dtgContenSistema.RowCount}";
        }
        private Boolean ProcesodeAnalisis(int pkBanco, string nroCuenta)
        {
            if (pkBanco == 1) //Banco BCP
            {
                //validamos Que pertenezca ala misma cuenta
                if (Tdatos.Columns.Count != 11)
                {
                    msgError("El Archivo Excel No contienen todas las Columnas Necesarias");
                    return false;
                }
                string ValCuenta = Tdatos.Rows[0][1].ToString();
                if (!ValCuenta.Contains(nroCuenta))
                {
                    msgError("El Excel de Movimientos NO coincide con la cuenta Seleccionada");
                    return false;
                }
                int pos = 7; int c = 1;
                DateTime FechaMin = new DateTime(2200, 1, 1);
                DateTime FechaMax = new DateTime(1900, 1, 1);
                foreach (DataRow item in Tdatos.Rows)
                {
                    if (c++ >= pos)
                    {
                        DateTime Fecha = DateTime.Parse(item[0].ToString());
                        if (Fecha < FechaMin) FechaMin = Fecha;
                        if (Fecha > FechaMax) FechaMax = Fecha;
                    }
                }
                DateTime FechaCombo = comboMesAño1.GetFecha();
                if (!(FechaMin <= FechaCombo && FechaCombo <= FechaMax))
                {
                    msgError("El Periodo Seleccionado No Coincide con la Fecha de Los Movimientos");
                    return false;
                }
                return true;
            }
            else
            {
                msgError("Por el Momento se puede Conciliar el Banco BCP");
                return false;
            }
            return false;
        }
        DataTable Tdatos;
        DataTable TdatosSist;
        private Boolean CargarDatosDelExcel(string Ruta)
        {
            Tdatos = HPResergerFunciones.Utilitarios.CargarDatosDeExcelAGrilla(txtRutaExcel.Text, 1, 6, 11);
            if (Tdatos.Rows.Count == 0)
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
            }
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.frmInformativo.MostrarDialog(cadena);
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
        string NroCuenta = "";
        private void cboCuentasBancarias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCuentasBancarias.SelectedValue != null)
            {
                pkBanco = (int)((DataTable)cboCuentasBancarias.DataSource).Rows[cboCuentasBancarias.SelectedIndex]["banco"];
                NroCuenta = ((DataTable)cboCuentasBancarias.DataSource).Rows[cboCuentasBancarias.SelectedIndex]["Nro_Cta"].ToString();
                pkMoneda = (int)((DataTable)cboCuentasBancarias.DataSource).Rows[cboCuentasBancarias.SelectedIndex]["Moneda"];
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
                foreach (DataRow item1 in Tdatos.Rows)
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
                foreach (DataRow item1 in Tdatos.Rows)
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
                                }
                        }
                }
            }
            //Ordenamos
            OrdenarDataGridViews();
        }
        private void dtgContenExcel_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void btnFechaMonto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConciliarMovimientos(Conciliaciones.FechaMonto);
        }

        private void btnDesAgrupar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Grilla == 1)
            {
                if (dtgContenExcel.CurrentCell != null)
                {
                    if (dtgContenExcel[xGrupo.Name, dtgContenExcel.CurrentCell.RowIndex].Value.ToString() == "") return;
                    int Valor = (int)dtgContenExcel[xGrupo.Name, dtgContenExcel.CurrentCell.RowIndex].Value;
                    foreach (DataRow item in Tdatos.Rows)
                    {
                        if (item[xGrupo.DataPropertyName].ToString() != "")
                            if ((int)item[xGrupo.DataPropertyName] == Valor)
                                item[xGrupo.DataPropertyName] = DBNull.Value;
                    }
                    foreach (DataRow item in TdatosSist.Rows)
                    {
                        if (item[ygrupo.DataPropertyName].ToString() != "")
                            if ((int)item[ygrupo.DataPropertyName] == Valor)
                                item[ygrupo.DataPropertyName] = DBNull.Value;
                    }
                }
            }
            else if (Grilla == 2)
            {
                if (dtgContenSistema.CurrentCell != null)
                {
                    if (dtgContenSistema[ygrupo.Name, dtgContenSistema.CurrentCell.RowIndex].Value.ToString() == "") return;
                    int Valor = (int)dtgContenSistema[ygrupo.Name, dtgContenSistema.CurrentCell.RowIndex].Value;
                    foreach (DataRow item in Tdatos.Rows)
                    {
                        if (item[xGrupo.DataPropertyName].ToString() != "")
                            if ((int)item[xGrupo.DataPropertyName] == Valor)
                                item[xGrupo.DataPropertyName] = DBNull.Value;
                    }
                    foreach (DataRow item in TdatosSist.Rows)
                    {
                        if (item[ygrupo.DataPropertyName].ToString() != "")
                            if ((int)item[ygrupo.DataPropertyName] == Valor)
                                item[ygrupo.DataPropertyName] = DBNull.Value;
                    }
                }
            }
            else msgError("Seleccione una Celda");
            OrdenarDataGridViews(dtgContenExcel.FirstDisplayedCell.RowIndex, dtgContenSistema.FirstDisplayedCell.RowIndex);
        }
        int Grilla = 0;
        private void dtgContenExcel_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Grilla = 1;
        }
        private void dtgContenSistema_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Grilla = 2;
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
            if (e.ColumnIndex == dtgContenExcel.Columns[xok.Name].Index)
            {
                if (dtgContenExcel[xGrupo.Name, e.RowIndex].Value.ToString() != "")
                    dtgContenExcel.CancelEdit();
                dtgContenExcel.EndEdit();
            }
        }

        private void dtgContenSistema_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgContenSistema.Columns[yok.Name].Index)
            {
                if (dtgContenSistema[ygrupo.Name, e.RowIndex].Value.ToString() != "")
                    dtgContenSistema.CancelEdit();
                dtgContenSistema.EndEdit();
            }
        }
        decimal SumaExcel = 0, SumaSistema = 0;
        private void dtgContenSistema_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.ColumnIndex == dtgContenSistema.Columns[yok.Name].Index)
                {
                    if (dtgContenSistema[ygrupo.Name, e.RowIndex].Value.ToString() != "")
                    {
                        dtgContenSistema[yok.Name, e.RowIndex].Value = 0;
                    }
                    MostrarTotales();
                }
        }
        private void dtgContenExcel_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.ColumnIndex == dtgContenExcel.Columns[xok.Name].Index)
                {
                    if (dtgContenExcel[xGrupo.Name, e.RowIndex].Value.ToString() != "")
                    {
                        dtgContenExcel[xok.Name, e.RowIndex].Value = 0;
                    }
                    MostrarTotales();
                }
        }
        private void MostrarTotales()
        {
            SumaExcel = SumaSistema = 0;
            foreach (DataRow item in Tdatos.Rows)
                if ((int)item[xok.DataPropertyName] == 1)
                    SumaExcel += decimal.Parse(item[xMonto.DataPropertyName].ToString());

            foreach (DataRow item in TdatosSist.Rows)
                if ((int)item[yok.DataPropertyName] == 1)
                    SumaSistema += (decimal)item[ymonto.DataPropertyName];
            if (SumaExcel + SumaSistema == 0)
                lblTotales.Text = "Seleccione Filas en las 2 Tablas";
            else
            {
                lblTotales.Text = $"Sumas; Excel: {SumaExcel.ToString("n2")}, Sistema:{SumaSistema.ToString("n2")} ";
            }
        }
    }
}
