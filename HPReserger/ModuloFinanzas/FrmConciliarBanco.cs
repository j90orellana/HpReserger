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
        private void btnPaso2_Click(object sender, EventArgs e)
        {
            if (CargarDatosDelExcel(txtRutaExcel.Text))
            {
                PasarAPaso2(true);
                Estado = 2;
                if (ProcesodeAnalisis(pkBanco, NroCuenta))
                    if (FormatearlaTabla(pkBanco))
                    {
                        dtgconten.DataSource = Tdatos;
                        ContarRegistros();
                    }
            }
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
                int[] IndexColumnasEliminar = new int[] { 10, 9, 8, 7, 5, 4, 1 };

                foreach (int item in IndexColumnasEliminar)
                {
                    Tdatos.Columns.RemoveAt(item);
                }
                //Damos Nombres a las Columnas
                Tdatos.Columns[0].ColumnName = "Fecha";
                Tdatos.Columns[2].ColumnName = "Monto";
                Tdatos.Columns[3].ColumnName = "Operacion";
                Tdatos.Columns[1].ColumnName = "Glosa";
                return true;
            }
            return false;
        }

        private void ContarRegistros()
        {
            lblREgistros.Text = $"Total Registros: {dtgconten.RowCount}";
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
                int pos = 6; int c = 1;
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
            return false;
        }
        DataTable Tdatos;
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
            dtgconten.Enabled = !v;
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
                if (dtgconten.DataSource != null)
                {
                    dtgconten.DataSource = ((DataTable)dtgconten.DataSource).Clone();
                }
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
        private void textBoxPer1_TextChanged(object sender, EventArgs e)
        {

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
        string NroCuenta = "";
        private void cboCuentasBancarias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCuentasBancarias.SelectedValue != null)
            {
                pkBanco = (int)((DataTable)cboCuentasBancarias.DataSource).Rows[cboCuentasBancarias.SelectedIndex]["banco"];
                NroCuenta = ((DataTable)cboCuentasBancarias.DataSource).Rows[cboCuentasBancarias.SelectedIndex]["Nro_Cta"].ToString();
            }
        }
    }
}
