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
    public partial class frmGenerarGratificacion : FormGradient
    {
        public frmGenerarGratificacion()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

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
            CapaLogica.GenerarGratificaciones(empresa, tipo, numero, 1, comboMesAño1.GetFechaPRimerDia(), comboMesAño1.GetFechaPRimerDia(), frmLogin.CodigoUsuario);
            DBoleta = CapaLogica.SeleccionarGratificacion(empresa, tipo, numero, 1, inicial, inicial);
            if (DBoleta.Rows.Count == 0)
            {
                msg($"No hay Gratificaciones que Mostrar del :{inicial.ToLongDateString()}");
                return;
            }
            frmReporteGratificacion frmgratis = new frmReporteGratificacion();            
            frmgratis.empresa = empresa;
            frmgratis.tipo = tipo;
            frmgratis.numero = numero;
            frmgratis.fecha = 1;
            frmgratis.fechainicial = inicial;
            msgOK("Gratificaciones Generadas con Éxito");
            frmgratis.Fechafin = inicial;
            frmgratis.Show();
        }

        private void frmGenerarGratificacion_Load(object sender, EventArgs e)
        {
            // Gratificaciones 7=julio 12=diciembre
            //if (DateTime.Now.Month == 7 || DateTime.Now.Month == 11 || DateTime.Now.Month == 12)
            //{
            //    cargarempresas();
            //    cargartipoid();
            //    empresa = 1;
            //    if (DateTime.Now.Month == 7)
            //        comboMesAño1.MostrarMeses(7);
            //    if (DateTime.Now.Month == 11)
            //        comboMesAño1.MostrarMeses(12);
            //}
            //else
            //{
            //    msg($"Las Gratificaciones se Pagan solo en Julio y Diciembre ");
            //    this.Close();
            //}
            comboMesAño1.MostrarMeses(7, 12);
            cargarempresas();
            cargartipoid();
            empresa = 1;

        }
    }
}
