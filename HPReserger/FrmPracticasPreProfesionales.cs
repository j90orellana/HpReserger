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
    public partial class FrmPracticasPreProfesionales : Form
    {
        public FrmPracticasPreProfesionales()
        {
            InitializeComponent();
        }
        public string tipo = "", numero = "", contrato = "";
        HPResergerCapaLogica.HPResergerCL cdatospreprofesionales = new HPResergerCapaLogica.HPResergerCL();
        private void FrmPracticasPreProfesionales_Load(object sender, EventArgs e)
        {
            cbotipoid.DataSource = cdatospreprofesionales.getCargoTipoContratacion("Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");
            cbotipoid.DisplayMember = "descripcion";
            cbotipoid.ValueMember = "codigo";
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (txtrucuni.TextLength < 10)
            {
                MSGITO("Ruc Demasiado pequeño ");
                txtrucuni.Focus();
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtrucuni.Text))
            {
                MSGITO("Ingrese Ruc");
                txtrucuni.Focus();
                return;
            }
            if (txtrazonsocialuni.TextLength < 1 || !string.IsNullOrWhiteSpace(txtrazonsocialuni.Text))
            {
                MSGITO("Ingrese Razón Social");
                txtrazonsocialuni.Focus();
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtdireccionuni.Text))
            {
                MSGITO("Ingresé Dirección ");
                txtdireccionuni.Focus();
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtrepre.Text))
            {
                MSGITO("Ingrese Representante");
                txtrepre.Focus();
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtnrodocrepre.Text))
            {
                MSGITO("Ingresé Número de documento del representante");
                txtnrodocrepre.Focus();
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtsituacionprac.Text))
            {
                MSGITO("Ingresé Situación del Practicante");
                txtsituacionprac.Focus();
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtespecialidadprac.Text))
            {
                MSGITO("Ingresé Especialidad del Practicante");
                txtespecialidadprac.Focus();
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtocupacionmateriaprac.Text))
            {
                MSGITO("Ingresé Ocupación materia de la Capacitación");
                txtocupacionmateriaprac.Focus();
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtdiasprac.Text))
            {
                MSGITO("Ingresé los Días de las Prácticas");
                txtdiasprac.Focus();
                return;
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void MSGITO(string cadena)
        {
            MessageBox.Show(cadena, "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
