using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmEmpleadosFamiliaresModificar : FormGradient
    {
        HPResergerCapaLogica.HPResergerCL clEmpleadoFamiliaModificar = new HPResergerCapaLogica.HPResergerCL();
        private string nombreconviviente;
        private byte[] conviviente;
        MemoryStream _memoryStream = new MemoryStream();
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
        public int sexo;
        public Boolean estudia;
        public frmEmpleadosFamiliaresModificar()
        {
            InitializeComponent();
        }
        DataTable TablaTipoID;
        public void CargarTiposID(string tabla)
        {
            TablaTipoID = new DataTable();
            TablaTipoID = clEmpleadoFamiliaModificar.CualquierTabla(tabla, "Desc_Tipo_ID", "RUC");
            cboTipoDocumentoIdentidad.DisplayMember = "Desc_Tipo_ID";
            cboTipoDocumentoIdentidad.ValueMember = "Codigo_Tipo_ID";
            cboTipoDocumentoIdentidad.DataSource = TablaTipoID;
        }
        public void ModificarTamañoTipo(TextBox txt, int index)
        {
            if (index >= 0 && TablaTipoID != null)
            {
                DataRow Filita = TablaTipoID.Rows[index];
                txt.MaxLength = (int)Filita["Length"];
            }
        }
        private void frmEmpleadosFamiliaresModificar_Load(object sender, EventArgs e)
        {
            CargarTiposID("TBL_Tipo_ID");
            CargaCombos(cboVinculoFamiliar, "Id_VinculoFamiliar", "VinculoFamiliar", "TBL_VinculoFamiliar");
            CargaCombos(cbosexo, "Id_Sexo", "Sexo", "TBL_Sexo");
            cboTipoDocumentoIdentidad.SelectedValue = CodigoDocumentoFamiliar;
            txtNumeroDocumento.Text = NumeroDocumentoFamiliar;
            cboVinculoFamiliar.SelectedValue = VinculoFamiliar;
            txtApellidoPaterno.Text = ApellidoPaterno;
            txtApellidoMaterno.Text = ApellidoMaterno;
            txtNombres.Text = Nombres;
            dtpFecha.Value = FechaNacimiento;
            txtOcupacion.Text = Ocupacion;
            check18.Checked = estudia;
            cbosexo.SelectedValue = sexo;
        }

        private void CargaCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clEmpleadoFamiliaModificar.getCargoTipoContratacion(codigo, descripcion, tabla);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length != txtNumeroDocumento.MaxLength && cboTipoDocumentoIdentidad.Text != "CARNE EXTRANJERIA")
            {
                msg("No Coincide el Tamaño con el tipo de Documento");
                txtNumeroDocumento.Focus();
                return;
            }
            if (txtNumeroDocumento.Text.Length == 0)
            {
                msg("Ingrese Nº Documento");
                txtNumeroDocumento.Focus();
                return;
            }
            if (txtApellidoPaterno.Text.Length == 0)
            {
                msg("Ingrese Apellido Paterno");
                txtApellidoPaterno.Focus();
                return;
            }
            if (txtApellidoMaterno.Text.Length == 0)
            {
                msg("Ingrese Apellido Materno");
                txtApellidoMaterno.Focus();
                return;
            }
            if (txtNombres.Text.Length == 0)
            {
                msg("Ingrese Nombres");
                txtNombres.Focus();
                return;
            }
            if (txtOcupacion.Text.Length == 0)
            {
                msg("Ingrese Ocupación");
                txtOcupacion.Focus();
                return;
            }
            if (cbosexo.SelectedIndex < 0)
            {
                msg("Seleccion el Sexo");
                cbosexo.Focus();
                return;
            }
            if (cboTipoDocumentoIdentidad.SelectedIndex < 0)
            {
                msg("Seleccion el Tipo de Documento");
                cboTipoDocumentoIdentidad.Focus();
                return;
            }
            if (cboVinculoFamiliar.SelectedIndex < 0)
            {
                msg("Seleccion el Vinculo Familiar");
                cboVinculoFamiliar.Focus();
                return;
            }
            if (NumeroDocumentoFamiliar != txtNumeroDocumento.Text || (int)cboTipoDocumentoIdentidad.SelectedValue != CodigoDocumentoFamiliar)
            {
                DataRow filita = clEmpleadoFamiliaModificar.EmpleadoFamiliaExiste(CodigoDocumentoEmpleado, NumeroDocumentoEmpleado, CodigoDocumentoFamiliar, NumeroDocumentoFamiliar);
                if (filita != null)
                {
                    msg("Documento Familiar Ya Existe");
                    return;
                }
            }
            int x = 0;
            if (check18.Checked) x = 1;
            else x = 0;
            clEmpleadoFamiliaModificar.EmpleadoFamilia(CodigoDocumentoEmpleado, NumeroDocumentoEmpleado, Convert.ToInt32(cboVinculoFamiliar.SelectedValue.ToString()), CodigoDocumentoFamiliar, NumeroDocumentoFamiliar, Convert.ToInt32(cboTipoDocumentoIdentidad.SelectedValue.ToString()), txtNumeroDocumento.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtNombres.Text, dtpFecha.Value, txtOcupacion.Text, frmLogin.CodigoUsuario, 0, conviviente, nombreconviviente, (int)cbosexo.SelectedValue, x);
            HPResergerFunciones.frmInformativo.MostrarDialog("Vínculo Familiar modificado con éxito");
            IFormEmpleado FormEmpleado = MdiParent as IFormEmpleado;
            if (FormEmpleado != null)
                FormEmpleado.CargarNroHijos(CodigoDocumentoEmpleado, NumeroDocumentoEmpleado);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.frmInformativo.MostrarDialogError(cadena);
        }
        private void txtApellidoMaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnconviviente_Click(object sender, EventArgs e)
        {
            var dialogoAbriArchivoConviviente = new OpenFileDialog();
            dialogoAbriArchivoConviviente.Filter = "Jpg Files|*.jpg";
            dialogoAbriArchivoConviviente.DefaultExt = ".jpg";
            if (dialogoAbriArchivoConviviente.ShowDialog(this) != DialogResult.Cancel)
            {
                txtconviviente.Text = nombreconviviente = dialogoAbriArchivoConviviente.FileName;
                conviviente = File.ReadAllBytes(dialogoAbriArchivoConviviente.FileName);
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;
                pbconviviente.Image = Image.FromFile(dialogoAbriArchivoConviviente.FileName);
                pbconviviente.Image.Save(_memoryStream, ImageFormat.Jpeg);
                lklconviviente.Enabled = true;
            }
            else lklconviviente.Enabled = false;
        }
        public void MostrarFoto(PictureBox fotito)
        {
            if (fotito.Image != null)
            {
                FrmFoto foto = new FrmFoto($"Foto de Familiar");
                foto.fotito = fotito.Image;
                foto.Owner = this.MdiParent;
                foto.ShowDialog();
            }
        }
        private void pbconviviente_Click(object sender, EventArgs e)
        {
            MostrarFoto(pbconviviente);
        }

        private void lklconviviente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            MostrarFoto(pbconviviente);
        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtNumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtNumeroDocumento, txtNumeroDocumento.MaxLength);
        }

        private void cboTipoDocumentoIdentidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModificarTamañoTipo(txtNumeroDocumento, cboTipoDocumentoIdentidad.SelectedIndex);
        }
    }
}