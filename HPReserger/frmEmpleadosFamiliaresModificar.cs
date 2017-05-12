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
    public partial class frmEmpleadosFamiliaresModificar : Form
    {
        HPResergerCapaLogica.HPResergerCL clEmpleadoFamiliaModificar = new HPResergerCapaLogica.HPResergerCL();

        public int CodigoDocumentoEmpleado { get; set; }
        public string NumeroDocumentoEmpleado { get; set; }
        public int CodigoDocumentoFamiliar { get; set; }
        public string NumeroDocumentoFamiliar { get; set; }
        public int VinculoFamiliar { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Nombres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ocupacion { get; set; }

        public frmEmpleadosFamiliaresModificar()
        {
            InitializeComponent();
        }

        private void frmEmpleadosFamiliaresModificar_Load(object sender, EventArgs e)
        {
            CargaCombos(cboTipoDocumentoIdentidad, "Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");
            CargaCombos(cboVinculoFamiliar, "Id_VinculoFamiliar", "VinculoFamiliar", "TBL_VinculoFamiliar");

            cboTipoDocumentoIdentidad.SelectedValue = CodigoDocumentoFamiliar;
            txtNumeroDocumento.Text = NumeroDocumentoFamiliar;
            cboVinculoFamiliar.SelectedValue = VinculoFamiliar;
            txtApellidoPaterno.Text = ApellidoPaterno;
            txtApellidoMaterno.Text = ApellidoMaterno;
            txtNombres.Text = Nombres;
            dtpFecha.Value = FechaNacimiento;
            txtOcupacion.Text = Ocupacion;
        }

        private void CargaCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clEmpleadoFamiliaModificar.getCargoTipoContratacion(codigo, descripcion, tabla);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }
            if (txtApellidoPaterno.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Apellido Paterno", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtApellidoPaterno.Focus();
                return;
            }
            if (txtApellidoMaterno.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Apellido Materno", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtApellidoMaterno.Focus();
                return;
            }
            if (txtNombres.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nombres", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNombres.Focus();
                return;
            }
            if (txtOcupacion.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Ocupación", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtOcupacion.Focus();
                return;
            }

            clEmpleadoFamiliaModificar.EmpleadoFamilia(CodigoDocumentoEmpleado, NumeroDocumentoEmpleado, Convert.ToInt32(cboVinculoFamiliar.SelectedValue.ToString()), CodigoDocumentoFamiliar, NumeroDocumentoFamiliar, Convert.ToInt32(cboTipoDocumentoIdentidad.SelectedValue.ToString()), txtNumeroDocumento.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtNombres.Text, dtpFecha.Value, txtOcupacion.Text, frmLogin.CodigoUsuario, 0);
            MessageBox.Show("Vínculo Familiar modificado con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}