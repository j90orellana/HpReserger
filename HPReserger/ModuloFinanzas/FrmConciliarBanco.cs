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
            }
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.frmInformativo.MostrarDialog(cadena);
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
                    txtRutaExcel.Text = openFileDialog1.FileName;
                }
            }
        }
        private void buttonPer1_Click_1(object sender, EventArgs e)
        {
            SeleccionarArchivoExcel();
        }
    }
}
