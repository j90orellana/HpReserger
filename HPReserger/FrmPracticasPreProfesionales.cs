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
    public partial class FrmPracticasPreProfesionales : FormGradient
    {
        public FrmPracticasPreProfesionales()
        {
            InitializeComponent();
        }
        public string tipo = "", numero = "", contrato = "";
        public int opcion;
        public string ruc, representante, tipoidrepre, docrepre, situacion, especialidad, ocupacion, dias, horario;
        public int estado = 0;
        HPResergerCapaLogica.HPResergerCL cdatospreprofesionales = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void FrmPracticasPreProfesionales_Load(object sender, EventArgs e)
        {
            cbotipoid.DataSource = cdatospreprofesionales.getCargoTipoContratacion("Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");
            cbotipoid.DisplayMember = "descripcion";
            cbotipoid.ValueMember = "codigo";

            DataTable PracticasPreprofesionales = cdatospreprofesionales.PracticasPreProfesionales(contrato, tipo, numero, 0, null, null, null, null, null, null, null, null, null);
            if (PracticasPreprofesionales.Rows.Count > 0)
            {
                DataRow Practicas = PracticasPreprofesionales.Rows[0];
                txtrucuni.Text = Practicas["Ruc"].ToString();
                txtrepre.Text = Practicas["Representante"].ToString();
                cbotipoid.SelectedValue = Practicas["TipoIDRepresentante"].ToString();
                txtnrodocrepre.Text = Practicas["DocRepresentante"].ToString();
                txtsituacionprac.Text = Practicas["SituacionPracticante"].ToString();
                txtespecialidadprac.Text = Practicas["Especialidad"].ToString();
                txtocupacionmateriaprac.Text = Practicas["OcupacionMateriaCapacitacion"].ToString();
                txtdiasprac.Text = Practicas["DiasDePracticas"].ToString();
                txthorarioprac.Text = Practicas["HorarioPracticas"].ToString();
                busca = true;
            }
            else
            {
                txtrucuni.Text = txtrazonsocialuni.Text = txtdireccionuni.Text = txtnrodocrepre.Text = txtocupacionmateriaprac.Text = txtsituacionprac.Text = txtrepre.Text = txtespecialidadprac.Text =
                    txtdiasprac.Text = txthorarioprac.Text = "";
                busca = false;
            }
        }
        public Boolean busca, acepta;
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (txtrucuni.TextLength < 10)
            {
                msg("Ruc Demasiado pequeño");
                txtrucuni.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtrucuni.Text))
            {
                msg("Ingrese Ruc");
                txtrucuni.Focus();
                return;
            }
            if (txtrazonsocialuni.TextLength < 1 || string.IsNullOrWhiteSpace(txtrazonsocialuni.Text))
            {
                msg("Ingrese Razón Social");
                txtrazonsocialuni.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtdireccionuni.Text))
            {
                msg("Ingresé Dirección ");
                txtdireccionuni.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtrepre.Text))
            {
                msg("Ingrese Representante");
                txtrepre.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtnrodocrepre.Text))
            {
                msg("Ingresé Número de documento del representante");
                txtnrodocrepre.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtsituacionprac.Text))
            {
                msg("Ingresé Situación del Practicante");
                txtsituacionprac.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtespecialidadprac.Text))
            {
                msg("Ingresé Especialidad del Practicante");
                txtespecialidadprac.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtocupacionmateriaprac.Text))
            {
                msg("Ingresé Ocupación materia de la Capacitación");
                txtocupacionmateriaprac.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtdiasprac.Text))
            {
                msg("Ingresé los Días de las Prácticas");
                txtdiasprac.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txthorarioprac.Text))
            {
                msg("Ingresé Horario de Las Prácticas");
                txthorarioprac.Focus();
                return;
            }
            if (institucion == false)
            {
                if (MessageBox.Show("Institución Educativa no existe, Desea Guardarla ?", CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cdatospreprofesionales.InstitucionEducativa(txtrucuni.Text, txtrazonsocialuni.Text, txtdireccionuni.Text, 2, 2);
                    msgOK("Institución Educativa Guardada!");
                    BuscarInstitucion(txtrucuni.Text, null, null, 1, 5);
                }
                else
                {
                    msg("Ingresé Institución Educativa");
                    txtrucuni.Focus();
                    return;
                }
            }
            //pasos para guardar
            ruc = txtrucuni.Text;
            representante = txtrepre.Text;
            tipoidrepre = cbotipoid.SelectedValue.ToString();
            docrepre = txtnrodocrepre.Text;
            situacion = txtsituacionprac.Text;
            especialidad = txtespecialidadprac.Text;
            ocupacion = txtocupacionmateriaprac.Text;
            dias = txtdiasprac.Text;
            horario = txthorarioprac.Text;
            if (busca == true && estado == 2)
                cdatospreprofesionales.PracticasPreProfesionales(contrato, tipo, numero, 2, ruc, representante, tipoidrepre, docrepre, situacion, especialidad, ocupacion, dias, horario);
            if (busca == false && estado == 2)
                cdatospreprofesionales.PracticasPreProfesionales(contrato, tipo, numero, 1, ruc, representante, tipoidrepre, docrepre, situacion, especialidad, ocupacion, dias, horario);
            acepta = true;
            msgOK("Guardado!");
            this.Close();

        }
        private void txtrucuni_TextChanged(object sender, EventArgs e)
        {
            BuscarInstitucion(txtrucuni.Text, null, null, 1, 5);
            lsbruc.DataSource = cdatospreprofesionales.InstitucionEducativa(txtrucuni.Text, null, null, 1, 1);
            lsbruc.DisplayMember = "ruc";
            lsbruc.ValueMember = "ruc";
        }
        Boolean institucion = false;
        DataTable tablita = new DataTable();
        public void BuscarInstitucion(string ruc, string razon, string direccion, int opcion, int busca)
        {
            tablita = cdatospreprofesionales.InstitucionEducativa(ruc, razon, direccion, opcion, busca);
            if (tablita.Rows.Count > 0)
            {
                DataRow filas = tablita.Rows[0];
                txtrucuni.Text = filas["ruc"].ToString();
                txtrazonsocialuni.Text = filas["razonsocial"].ToString();
                txtdireccionuni.Text = filas["direccion"].ToString();
                institucion = true;
                txtrazonsocialuni.Enabled = false;
                txtdireccionuni.Enabled = false;
            }
            else
            {
                institucion = false;
                txtrazonsocialuni.Enabled = true;
                txtdireccionuni.Enabled = true;
                if (busca == 5)
                {
                    txtrazonsocialuni.Text = "";
                    txtdireccionuni.Text = "";
                }
            }
        }

        private void txtrucuni_Click(object sender, EventArgs e)
        {
            lsbruc.Visible = true;
            lsbruc.Height = 80;
        }
        private void txtrucuni_Enter(object sender, EventArgs e)
        {
            lsbruc.Visible = true;
            lsbruc.Height = 80;
        }
        private void lsbruc_MouseLeave(object sender, EventArgs e)
        {
            lsbruc.Visible = false;
        }
        private void lsbruc_Click(object sender, EventArgs e)
        {
            txtrucuni.Text = lsbruc.Text;
            lsbruc.Visible = false;
        }
        private void txtrazonsocialuni_Click(object sender, EventArgs e)
        {
            lsbrazon.Visible = true;
            lsbrazon.Height = 80;
        }
        private void txtrazonsocialuni_Enter(object sender, EventArgs e)
        {
            lsbrazon.Visible = true;
            lsbrazon.Height = 80;
        }
        private void lsbrazon_Click(object sender, EventArgs e)
        {
            txtrucuni.Text = lsbrazon.SelectedValue.ToString();
            lsbrazon.Visible = false;
        }
        private void lsbrazon_MouseLeave(object sender, EventArgs e)
        {
            lsbrazon.Visible = false;
        }
        private void txtrazonsocialuni_TextChanged(object sender, EventArgs e)
        {
            lsbrazon.DataSource = cdatospreprofesionales.InstitucionEducativa(null, txtrazonsocialuni.Text, null, 1, 2);
            lsbrazon.DisplayMember = "razonsocial";
            lsbrazon.ValueMember = "ruc";
        }
        private void gp1_MouseHover(object sender, EventArgs e)
        {
            lsbrazon.Visible = lsbruc.Visible = false;
        }
        private void txtrucuni_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }
        private void txtrucuni_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtrucuni, 11);
        }
        private void txtnrodocrepre_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtnrodocrepre_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtnrodocrepre, 10);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                acepta = false;
                this.Close();
            }
        }
    }
}
