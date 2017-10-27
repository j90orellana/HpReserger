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
    public partial class frmGenerarBoletas : Form
    {
        public frmGenerarBoletas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CReporteboleta = new HPResergerCapaLogica.HPResergerCL();
        private void frmGenerarBoletas_Load(object sender, EventArgs e)
        {
            cargarempresas();
            cargartipoid();
            empresa = 1;
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


        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnumero.Text = "";
        }
        string numero = "0";


        private void btnrecempresa_Click(object sender, EventArgs e)
        {
            cargarempresas();
        }

        private void btnrectipo_Click(object sender, EventArgs e)
        {
            cargartipoid();
        }
        public DialogResult msg(string cadena)
        {
            return MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
        DataTable DBoleta;
        private void btngenerar_Click(object sender, EventArgs e)
        {
            empresa = 0; tipo = 0;
            if (radioButton1.Checked)
                if (cboempresa.Items.Count > 0)
                    empresa = int.Parse(cboempresa.SelectedValue.ToString());
                else
                {
                    msg("No hay Empresas");
                    return;
                }
            if (radioButton2.Checked)
            {
                if (cbotipoid.Items.Count > 0)
                {
                    tipo = int.Parse(cbotipoid.SelectedValue.ToString());
                    numero = txtnumero.Text;
                }
                else
                {
                    msg("No Hay Tipos de ID"); return;
                }
            }
            DBoleta = new DataTable();
            DateTime inicial, final;
            ///Ver si hay datos
            inicial = comboMesAño1.GetFechaPRimerDia();
            final = comboMesAño2.GetFecha();
            if (inicial > final)
            {
                inicial = comboMesAño2.GetFechaPRimerDia();
                final = comboMesAño1.GetFecha();
            }
            DBoleta = CReporteboleta.SeleccionarBoletas(empresa, tipo, numero, 1, inicial, final);
            int aux = (12 * (final.Year - inicial.Year) + final.Month) - inicial.Month + 1;
            // msg("meses " + aux + "inicial " + inicial + "final " + final);
            List<string> listita = new List<string>();
            foreach (DataRow x in DBoleta.Rows)
                listita.Add(x["mes"].ToString());
            listita = listita.Distinct().ToList<string>();
            //if (listita.Count != aux)
            if (DBoleta.Rows.Count == 0)
                CReporteboleta.GenerarBoletasMensuales(empresa, tipo, numero, 1, inicial, final, frmLogin.CodigoUsuario);
            DBoleta = CReporteboleta.SeleccionarBoletas(empresa, tipo, numero, 1, inicial, final);
            if (DBoleta.Rows.Count == 0)
            {
                msg($"No hay Boletas que Mostrar del :{inicial.ToLongDateString()} \nHasta: {final.ToLongDateString()}");
                return;
            }
            frmreporteboletasfin boletas = new frmreporteboletasfin();
            boletas.empresa = empresa;
            boletas.tipo = tipo;
            boletas.numero = numero;
            boletas.fecha = 1;
            boletas.fechainicial = inicial;
            boletas.Fechafin = final;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}
