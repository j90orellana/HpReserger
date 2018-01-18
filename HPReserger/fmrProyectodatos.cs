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
    public partial class fmrProyectodatos : Form
    {
        public fmrProyectodatos()
        {
            InitializeComponent();
        }
        public int Proyecto;
        private void button1_Click(object sender, EventArgs e)
        {
            frmetapas etapas = new frmetapas();
            etapas.proyecto = Proyecto;
            etapas.Icon = Icon;
            etapas.ShowDialog();
            Dtgconten.DataSource = CLProyectos.ListarEtapasProyecto(Proyecto.ToString());
        }
        HPResergerCapaLogica.HPResergerCL CLProyectos = new HPResergerCapaLogica.HPResergerCL();
        private void fmrProyectodatos_Load(object sender, EventArgs e)
        {
            cbomoneda.DataSource = CLProyectos.getCargoTipoContratacion("Id_Moneda", "Moneda", "TBL_Moneda");
            cbomoneda.ValueMember = "codigo";
            cbomoneda.DisplayMember = "descripcion";
            Dtgconten.DataSource = CLProyectos.ListarEtapasProyecto(Proyecto.ToString());
            DataRow DatosProyecto = CLProyectos.ProyectodatosListar(Proyecto);
            if (DatosProyecto != null)
            {
                CalcularDatos();
                txtubicacion.Text = DatosProyecto["Ubicacion"].ToString();
                cbomoneda.SelectedValue = DatosProyecto["moneda"].ToString();
                txtareabruta.Text = DatosProyecto["AreaBruta"].ToString();
                validar(txtareabruta);
                txtpreciom2.Text = DatosProyecto["PrecioxMetro"].ToString();
                validar(txtpreciom2);
                txttotaldolar.Text = DatosProyecto["PrecioTotal"].ToString();
                validar(txttotaldolar);
                txttotalavaluo.Text = DatosProyecto["Autoavaluo"].ToString();
                validar(txttotalavaluo);
                txtrevaluacion.Text = DatosProyecto["RevaluacionTerrero"].ToString();
                validar(txtrevaluacion);
                txtvigilancia.Text = DatosProyecto["Vigilancia"].ToString();
                validar(txtvigilancia);
                txtmarketing.Text = DatosProyecto["Marketing"].ToString();
                validar(txtmarketing);
                txtventas.Text = DatosProyecto["Ventas"].ToString();
                validar(txtventas);
                txtadminobra.Text = DatosProyecto["AdministracionObra"].ToString();
                validar(txtadminobra);
                txtgerencia.Text = DatosProyecto["Gerenciamiento"].ToString();
                validar(txtgerencia);
                txtcdaf.Text = DatosProyecto["CDAP"].ToString();
                validar(txtcdaf);
                txtfindefee.Text = DatosProyecto["FinderFee"].ToString();
                validar(txtfindefee);
                txtcostosuper.Text = DatosProyecto["CostoSupervision"].ToString();
                validar(txtcostosuper);
                txtcomision.Text = DatosProyecto["Comision"].ToString();
                validar(txtcomision);
                txtcomisionsuper.Text = (DatosProyecto["ComisionExt"]).ToString();
                validar(txtcomisionsuper);
                txtceremonia.Text = DatosProyecto["Ceremonia"].ToString();
                validar(txtceremonia);
                txtregalos.Text = DatosProyecto["RegalosxDepartamento"].ToString();
                validar(txtregalos);
                txtmantenimiento.Text = DatosProyecto["MantenimientoMensual"].ToString();
                validar(txtmantenimiento);
                txtatencion.Text = DatosProyecto["Atencion"].ToString();
                validar(txtatencion);
                txtcostoprevio.Text = DatosProyecto["CostoPrevio"].ToString();
                validar(txtcostoprevio);
                txtgestioncomuni.Text = DatosProyecto["GestionComunitaria"].ToString();
                validar(txtgestioncomuni);
                txtporcentacredito.Text = DatosProyecto["PorcentajeCredito"].ToString();
                validar(txtporcentacredito);
                txtconfianzaanual.Text = DatosProyecto["CostoFianzas"].ToString();
                validar(txtconfianzaanual);
                txtimprevistos.Text = DatosProyecto["Imprevistos"].ToString();
                validar(txtimprevistos);
            }
            else
            {
                txtubicacion.Text =
                cbomoneda.Text =
                txtareabruta.Text =
                txtpreciom2.Text =
                txttotalavaluo.Text =
                txtrevaluacion.Text =
                txtvigilancia.Text =
                txtmarketing.Text =
                txtventas.Text =
                txtadminobra.Text =
                txtgerencia.Text =
                txtcdaf.Text =
                txtfindefee.Text =
                txtcostosuper.Text =
                txtcomision.Text =
                txtcomisionsuper.Text =
                txtceremonia.Text =
                txtregalos.Text =
                txtmantenimiento.Text =
                txtatencion.Text =
                txtcostoprevio.Text =
                txtgestioncomuni.Text =
                txtporcentacredito.Text =
                txtconfianzaanual.Text =
                txtimprevistos.Text = "0.00";
            }

        }
        public void validar(TextBox cajita)
        {
            if (string.IsNullOrWhiteSpace(cajita.Text))
                cajita.Text = "0.00";
        }
        private void txtareabruta_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtareabruta_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtareabruta.Text);
        }

        private void txtpreciom2_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtpreciom2.Text);
        }

        private void txttotaldolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txttotaldolar.Text);
        }

        private void txttoralsoles_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txttoralsoles.Text);
        }

        private void txttotalavaluo_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txttotalavaluo.Text);
        }

        private void txtrevaluacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtrevaluacion.Text);
        }

        private void txtvigilancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtvigilancia.Text);
        }

        private void txtmarketing_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtmarketing.Text);
        }

        private void txtventas_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtventas.Text);
        }

        private void txtcostosuper_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtcostosuper.Text);
        }

        private void txtcomision_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtcomision.Text);
        }

        private void txtcomisionsuper_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtcomisionsuper.Text);
        }

        private void txtgestioncomuni_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtgestioncomuni.Text);
        }

        private void txtporcentacredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtporcentacredito.Text);
        }

        private void txtconfianzaanual_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconfianzaanual_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtconfianzaanual.Text);
        }

        private void txtconfianzamensual_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtconfianzamensual.Text);
        }

        private void txtadminobra_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtadminobra.Text);
        }

        private void txtgerencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgerencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtgerencia.Text);
        }

        private void txtcdaf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcdaf_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtcdaf.Text);
        }

        private void txtfindefee_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtfindefee.Text);
        }

        private void txtceremonia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtceremonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtceremonia.Text);
        }

        private void txtregalos_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtregalos.Text);
        }

        private void txtmantenimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtmantenimiento.Text);
        }

        private void txtatencion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtatencion_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtatencion.Text);
        }

        private void txtcostoprevio_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtcostoprevio.Text);
        }

        private void txtimprevistos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtimprevistos_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtimprevistos.Text);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            validar(txtareabruta);
            validar(txttotaldolar);
            validar(txttotalavaluo);
            validar(txtrevaluacion);
            validar(txtvigilancia);
            validar(txtmarketing);
            validar(txtventas);
            validar(txtadminobra);
            validar(txtgerencia);
            validar(txtcdaf);
            validar(txtfindefee);
            validar(txtcostosuper);
            validar(txtcomision);
            validar(txtcomisionsuper);
            validar(txtceremonia);
            validar(txtregalos);
            validar(txtmantenimiento);
            validar(txtatencion);
            validar(txtcostoprevio);
            validar(txtgestioncomuni);
            validar(txtporcentacredito);
            validar(txtconfianzaanual);
            validar(txtimprevistos);
            CLProyectos.Proyectodatos(Proyecto, txtubicacion.Text, int.Parse(cbomoneda.SelectedValue.ToString()), (txtareabruta.Text), (txtpreciom2.Text), (txttotaldolar.Text), (txttotalavaluo.Text), (txtrevaluacion.Text), (txtvigilancia.Text), (txtmarketing.Text), (txtventas.Text), (txtadminobra.Text), (txtgerencia.Text), (txtcdaf.Text), (txtfindefee.Text), (txtcostosuper.Text), (txtcomision.Text), (txtcomisionsuper.Text), (txtceremonia.Text), (txtregalos.Text), (txtmantenimiento.Text), (txtatencion.Text), (txtcostoprevio.Text), (txtgestioncomuni.Text), (txtporcentacredito.Text), (txtconfianzaanual.Text), (txtimprevistos.Text));
            MessageBox.Show("Datos del Proyecto Actualizado", "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtareabruta_TextChanged(object sender, EventArgs e)
        {
            calculartotal();
        }
        public void calculartotal()
        {
            if (!string.IsNullOrWhiteSpace(txtareabruta.Text) && !string.IsNullOrWhiteSpace(txtpreciom2.Text))
                txttotaldolar.Text = (decimal.Parse(txtareabruta.Text) * decimal.Parse(txtpreciom2.Text)).ToString();
            else txttotaldolar.Text = "0.00";
        }

        private void txtpreciom2_TextChanged(object sender, EventArgs e)
        {
            calculartotal();
        }

        private void Dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void CalcularDatos()
        {
            if (Dtgconten.RowCount > 0)
            {
                int contador = 0, c = 0;
                foreach (DataGridViewRow filita in Dtgconten.Rows)
                {
                    contador += int.Parse(filita.Cells["mesesconstruccion"].Value.ToString());
                    c++;
                }
                if (contador == 1) txtplazo.Text = contador + " Mes";
                else
                    txtplazo.Text = contador + " Meses";

                if (c == 1)
                    txtetapas.Text = c + " Etapa";
                else
                    txtetapas.Text = c + " Etapas";
            }
        }

        private void Dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
