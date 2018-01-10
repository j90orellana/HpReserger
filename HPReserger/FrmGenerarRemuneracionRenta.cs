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
    public partial class FrmGenerarRemuneracionRenta : Form
    {
        public FrmGenerarRemuneracionRenta()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CReporteboleta = new HPResergerCapaLogica.HPResergerCL();
        private void frmGenerarBoletas_Load(object sender, EventArgs e)
        {
            empresa = 1;
            tipo = 0; numero = "0";
            cargarempresas();
            cargartipoid();
        }
        public void cargarempresas()
        {
            cboempresa.DataSource = CReporteboleta.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
        }
        public void cargartipoid()
        {
            cbotipoid.DataSource = CReporteboleta.getCargoTipoContratacion("Codigo_Tipo_ID", "desc_tipo_id", "tbl_tipo_id");
            cbotipoid.ValueMember = "codigo";
            cbotipoid.DisplayMember = "descripcion";
        }
        int empresa = 0, tipo = 0;

        string numero = "0";


        private void btnrecempresa_Click_1(object sender, EventArgs e)
        {
            cargarempresas();
        }

        private void btnrectipo_Click_1(object sender, EventArgs e)
        {
            cargartipoid();
        }

        private void btnlimpiar_Click_1(object sender, EventArgs e)
        {
            txtnumero.Text = "";
        }
        private void FrmGenerarRemuneracionRenta_Load(object sender, EventArgs e)
        {
            cargarempresas();
            cargartipoid();
            empresa = 1;
        }
       
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                tipo = int.Parse(cbotipoid.SelectedValue.ToString());
                numero = txtnumero.Text;
                cboempresa.Enabled = false;
                btnrecempresa.Enabled = false;
                cbotipoid.Enabled = true;
                txtnumero.Enabled = true;
                btnrectipo.Enabled = true;
                btnlimpiar.Enabled = true;
            }
            else
            {
                tipo = 0; numero = "0";
            }
        }

        private void btnrecempresa_Click(object sender, EventArgs e)
        {
            cargarempresas();
        }

        private void btnrectipo_Click(object sender, EventArgs e)
        {
            cargartipoid();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnumero.Text = "";
        }

        private void btngenerar_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked) empresa = int.Parse(cboempresa.SelectedValue.ToString());
            if (radioButton2.Checked) tipo = int.Parse(cbotipoid.SelectedValue.ToString());
            if (radioButton2.Checked) numero = txtnumero.Text;
            fmReporteRemuneracionRenta boletas = new fmReporteRemuneracionRenta();
            boletas.empresa = empresa;
            boletas.tipo = tipo;
            boletas.numero = numero;
            boletas.año = (int)comboMesAño1.GetFechaPRimerDia().Year;
            boletas.fechainicial = comboMesAño1.GetFechaPRimerDia();
            boletas.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                empresa = int.Parse(cboempresa.SelectedValue.ToString());
                cbotipoid.Enabled = false;
                txtnumero.Enabled = false;
                btnrectipo.Enabled = false;
                btnlimpiar.Enabled = false;
                cboempresa.Enabled = true;
                btnrecempresa.Enabled = true;
            }
            else empresa = 0;
        }


    }
}
