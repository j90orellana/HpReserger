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

namespace HPReserger
{
    public partial class frmGenerarCTS : Form
    {
        public frmGenerarCTS()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void cargarempresas()
        {
            cboempresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
        }
        public void cargartipoid()
        {
            cbotipoid.DataSource = CapaLogica.getCargoTipoContratacion("Codigo_Tipo_ID", "desc_tipo_id", "tbl_tipo_id");
            cbotipoid.ValueMember = "codigo";
            cbotipoid.DisplayMember = "descripcion";
        }
        int empresa = 0, tipo = 0;
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
        string numero = "0";
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
        public DialogResult msg(string cadena)
        {
            return MessageBox.Show(cadena, CompanyName ,MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
        private void btngenerar_Click(object sender, EventArgs e)
        {
            empresa = 0; tipo = 0;
            DataTable DBoleta = new DataTable();
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
            DateTime inicial;
            ///Ver si hay datos
            inicial = comboMesAño1.GetFechaPRimerDia();
            CapaLogica.Generarcts(empresa, tipo, numero, 1, comboMesAño1.GetFechaPRimerDia(), comboMesAño1.GetFechaPRimerDia(), frmLogin.CodigoUsuario);
            DBoleta = CapaLogica.SeleccionarPagoCts(empresa, tipo, numero, 1, inicial, inicial);
            if (DBoleta.Rows.Count == 0)
            {
                msg($"No hay CTS que Mostrar del :{inicial.ToLongDateString()}");
                return;
            }
            frmReportects frmcts = new frmReportects();
            frmcts.empresa = empresa;
            frmcts.tipo = tipo;
            frmcts.numero = numero;
            frmcts.fecha = 1;
            frmcts.fechainicial = inicial;
            msg("Cts Generadas con Éxito");
            frmcts.Fechafin = inicial;
            frmcts.Icon = Icon;
            frmcts.Show();
            //// Carta a los bancos
            frmGenerarCartaBancosCTs frmCartaBancos = new frmGenerarCartaBancosCTs();
            frmCartaBancos.empresa = empresa;
            frmCartaBancos.tipo = tipo;
            frmCartaBancos.numero = numero;
            frmCartaBancos.fecha = 1;
            frmCartaBancos.fechainicial = inicial;
            frmCartaBancos.Fechafin = inicial;
            frmCartaBancos.Icon = Icon;
            frmCartaBancos.Show();
            ///Generar el TXT
            MSG("Generando TXT del pago de la CTS");
            SaveFileDialog SAvesito = new SaveFileDialog();
            if ( SAvesito.ShowDialog() == DialogResult.OK)
            {
                cadenatxt = "";
                string[] Aux = new string[6];
                //Columnas a Mostrar de dBoleta-->CTS { 10  4   15  14  16  5 }
                foreach (DataRow row in DBoleta.Rows)
                {
                    Aux[0] = row[9].ToString();
                    Aux[1] = row[3].ToString();
                    Aux[2] = row[14].ToString();
                    Aux[3] = row[13].ToString();
                    Aux[4] = row[15].ToString();
                    Aux[5] = row[4].ToString();
                    cadenatxt += string.Join("|", Aux) + "\n";
                }
                string path = SAvesito.FileName;
                st = File.CreateText(path);
                st.Write(cadenatxt);
                st.Close();
            }
        }
        public void MSG(string cadena)
        {
            MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        string cadenatxt = "";
        private StreamWriter st;
        private void frmGenerarCTS_Load(object sender, EventArgs e)
        {
            comboMesAño1.MostrarMeses(5, 11);
            cargarempresas();
            cargartipoid();
            empresa = 1;
        }
    }
}
