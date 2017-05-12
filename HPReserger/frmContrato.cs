using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace HPReserger
{
    public partial class frmContrato : Form
    {
        HPResergerCapaLogica.HPResergerCL clContrato = new HPResergerCapaLogica.HPResergerCL();
        public int CodigoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        
        MemoryStream _memoryStream = new MemoryStream();
        public byte[] FotoContrato { get; set; }
        public string nombreArchivoContrato { get; set; }
        public byte[] FotoAnexoFunciones { get; set; }
        public string nombreArchivoAnexoFunciones { get; set; }
        public byte[] FotoSolicitudPracticas { get; set; }
        public string nombreArchivoSolicitudPracticas { get; set; }
        public byte[] FotoOtros { get; set; }
        public string nombreArchivoOtros { get; set; }

        public frmContrato()
        {
            InitializeComponent();
        }

        private void frmContrato_Load(object sender, EventArgs e)
        {
            CargaCombos(cboTipoContrato, "Id_TipoContrato", "TipoContrato", "TBL_TipoContrato");
            CargaCombos(cboCargo, "Id_Cargo", "Cargo", "TBL_Cargo");
            CargaCombos(cboEmpresa, "Id_Empresa", "Empresa", "TBL_Empresa");
            CargaCombos(cboGerencia, "Id_Gerencia", "Gerencia", "TBL_Gerencia");
            CargaCombos(cboProyecto, "Id_Proyecto", "Proyecto", "TBL_Proyecto");
            CargaCombos(cboSede, "Id_Sede", "Sede", "TBL_Sede");

            cboJefeInmediato.ValueMember = "codigo";
            cboJefeInmediato.DisplayMember = "jefe";
            cboJefeInmediato.DataSource = clContrato.ListarJefeInmediato();

            cboBono.SelectedIndex = 0;

            DataRow ExisteContrato = clContrato.CargarCualquierImagenPostulanteEmpleado("*", "TBL_Empleado_Contrato", "Tipo_ID_Emp", CodigoDocumento, "Nro_ID_Emp", NumeroDocumento);
            if (ExisteContrato != null)
            {
                cboTipoContrato.SelectedValue = Convert.ToInt32(ExisteContrato["Tipo_Contrato"].ToString());
                cboCargo.SelectedValue = Convert.ToInt32(ExisteContrato["Cargo"].ToString());
                cboGerencia.SelectedValue = Convert.ToInt32(ExisteContrato["Gerencia"].ToString());
                cboArea.SelectedValue = Convert.ToInt32(ExisteContrato["Area"].ToString());
                cboJefeInmediato.SelectedValue = ExisteContrato["Jefe_Inmediato"].ToString();
                cboProyecto.SelectedValue = Convert.ToInt32(ExisteContrato["Proyecto"].ToString());
                cboEmpresa.SelectedValue = Convert.ToInt32(ExisteContrato["Empresa"].ToString());
                cboSede.SelectedValue = Convert.ToInt32(ExisteContrato["Sede"].ToString());
                dtpFechaInicio.Value = Convert.ToDateTime(ExisteContrato["Fec_Inicio"].ToString());
                txtPeriodoLaboral.Text = ExisteContrato["Periodo_Laboral"].ToString();
                dtpFechaFin.Value = Convert.ToDateTime(ExisteContrato["Fec_Fin"].ToString());
                txtSalario.Text = ExisteContrato["Sueldo"].ToString();
                cboBono.Text = ExisteContrato["Bono"].ToString();
                txtImporteBono.Text = ExisteContrato["Bono_Importe"].ToString();
                txtPeriodicidad.Text = ExisteContrato["Bono_Periodicidad"].ToString();
                txtContrato.Text = ExisteContrato["NombreFotoContrato_Img"].ToString();
                txtAnexoFunciones.Text = ExisteContrato["NombreFotoAnxFunc_Img"].ToString();
                txtSolicitudPracticas.Text = ExisteContrato["NombreFotoSolPrac_Img"].ToString();
                txtOtros.Text = ExisteContrato["NombreFotoOtros_Img"].ToString();

                btnModificar.Enabled = true;
                btnRegistrar.Enabled = false;
            }
            else
            {
                btnModificar.Enabled = false;
                btnRegistrar.Enabled = true;
            }

            txtPeriodoLaboral_TextChanged(sender, e);
        }

        private void CargaCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clContrato.getCargoTipoContratacion(codigo, descripcion, tabla);
        }

        private void txtPeriodoLaboral_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtSalario.Text);
        }

        private void txtPeriodicidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void btnBuscarImagenContrato_Click(object sender, EventArgs e)
        {
            var dialogoAbrirArchivoContrato = new OpenFileDialog();
            dialogoAbrirArchivoContrato.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoContrato.DefaultExt = ".jpg";
            dialogoAbrirArchivoContrato.ShowDialog(this);

            nombreArchivoContrato = dialogoAbrirArchivoContrato.FileName.ToString();
            if (nombreArchivoContrato != string.Empty)
            {
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;

                pbFotoContrato.Image = Image.FromFile(nombreArchivoContrato);
                pbFotoContrato.Image.Save(_memoryStream, ImageFormat.Jpeg);
                FotoContrato = File.ReadAllBytes(dialogoAbrirArchivoContrato.FileName);
                txtContrato.Text = nombreArchivoContrato;
            }
        }

        private void btnBuscarImagenAnexoFunciones_Click(object sender, EventArgs e)
        {
            var dialogoAbrirArchivoAnexoFunciones = new OpenFileDialog();
            dialogoAbrirArchivoAnexoFunciones.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoAnexoFunciones.DefaultExt = ".jpg";
            dialogoAbrirArchivoAnexoFunciones.ShowDialog(this);

            nombreArchivoAnexoFunciones = dialogoAbrirArchivoAnexoFunciones.FileName.ToString();
            if (nombreArchivoAnexoFunciones != string.Empty)
            {
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;

                pbFotoAnexoFunciones.Image = Image.FromFile(nombreArchivoAnexoFunciones);
                pbFotoAnexoFunciones.Image.Save(_memoryStream, ImageFormat.Jpeg);
                FotoAnexoFunciones = File.ReadAllBytes(dialogoAbrirArchivoAnexoFunciones.FileName);
                txtAnexoFunciones.Text = nombreArchivoAnexoFunciones;
            }
        }

        private void btnBuscarImagenSolicitudPracticas_Click(object sender, EventArgs e)
        {
            var dialogoAbrirArchivoSolicitudPracticas = new OpenFileDialog();
            dialogoAbrirArchivoSolicitudPracticas.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoSolicitudPracticas.DefaultExt = ".jpg";
            dialogoAbrirArchivoSolicitudPracticas.ShowDialog(this);

            nombreArchivoSolicitudPracticas = dialogoAbrirArchivoSolicitudPracticas.FileName.ToString();
            if (nombreArchivoSolicitudPracticas != string.Empty)
            {
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;

                pbFotoSolicitudPracticas.Image = Image.FromFile(nombreArchivoSolicitudPracticas);
                pbFotoSolicitudPracticas.Image.Save(_memoryStream, ImageFormat.Jpeg);
                FotoSolicitudPracticas = File.ReadAllBytes(dialogoAbrirArchivoSolicitudPracticas.FileName);
                txtSolicitudPracticas.Text = nombreArchivoSolicitudPracticas;
            }
        }

        private void btnBuscarImagenOtros_Click(object sender, EventArgs e)
        {
            var dialogoAbrirArchivoOtros = new OpenFileDialog();
            dialogoAbrirArchivoOtros.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoOtros.DefaultExt = ".jpg";
            dialogoAbrirArchivoOtros.ShowDialog(this);

            nombreArchivoOtros = dialogoAbrirArchivoOtros.FileName.ToString();
            if (nombreArchivoOtros != string.Empty)
            {
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;

                pbFotoOtros.Image = Image.FromFile(nombreArchivoOtros);
                pbFotoOtros.Image.Save(_memoryStream, ImageFormat.Jpeg);
                FotoOtros = File.ReadAllBytes(dialogoAbrirArchivoOtros.FileName);
                txtOtros.Text = nombreArchivoOtros;
            }
        }

        private void txtImporteBono_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txtSalario.Text);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GrabarEditar(1);
                MessageBox.Show("Contrato generado con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Limpiar();
            }
        }


        private bool Validar()
        {
            if (txtPeriodoLaboral.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Período Laboral", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPeriodoLaboral.Focus();
                return false;
            }
            if (txtSalario.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Salario", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSalario.Focus();
                return false;
            }
            if (cboBono.SelectedIndex == 0 && txtImporteBono.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Importe Bono", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtImporteBono.Focus();
                return false;
            }
            if (txtPeriodicidad.Text.Length == 0 && cboBono.SelectedIndex == 0)
            {
                MessageBox.Show("Ingrese Periodicidad", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPeriodicidad.Focus();
                return false;
            }
            if (txtContrato.Text.Length == 0)
            {
                MessageBox.Show("Selecione Imagen de Contrato", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnBuscarImagenContrato.Focus();
                return false;
            }
            /*
            if (txtAnexoFunciones.Text.Length == 0)
            {
                MessageBox.Show("Selecione Imagen de Anexo de Funciones", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnBuscarImagenAnexoFunciones.Focus();
                return false;
            }
            if (txtSolicitudPracticas.Text.Length == 0)
            {
                MessageBox.Show("Selecione Imagen de Solicitud de Practicas", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnBuscarImagenSolicitudPracticas.Focus();
                return false;
            }
            if (txtOtros.Text.Length == 0)
            {
                MessageBox.Show("Selecione Imagen de Otros", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnBuscarImagenOtros.Focus();
                return false;
            }*/
            return true;
        }

        private void Limpiar()
        {
            txtPeriodoLaboral.Text = "";
            txtSalario.Text = "";
            txtImporteBono.Text = "";
            txtPeriodicidad.Text = "";
            txtContrato.Text = "";
            txtAnexoFunciones.Text = "";
            txtSolicitudPracticas.Text = "";
            txtOtros.Text = "";
        }

        private void GrabarEditar(int Opcion)
        {
            decimal ImporteBono = 0;
            int PeriodicidadBono = 0;
            if (cboBono.SelectedIndex == 0)
            {
                ImporteBono = Convert.ToDecimal(txtImporteBono.Text);
                PeriodicidadBono = Convert.ToInt32(txtPeriodicidad.Text);
            }

            clContrato.EmpleadoContrato(CodigoDocumento, NumeroDocumento, Convert.ToInt32(cboTipoContrato.SelectedValue.ToString()), Convert.ToInt32(cboCargo.SelectedValue.ToString()), Convert.ToInt32(cboGerencia.SelectedValue.ToString()), Convert.ToInt32(cboArea.SelectedValue.ToString()), cboJefeInmediato.SelectedValue.ToString(), Convert.ToInt32(cboEmpresa.SelectedValue.ToString()), Convert.ToInt32(cboProyecto.SelectedValue.ToString()), Convert.ToInt32(cboSede.SelectedValue.ToString()), dtpFechaInicio.Value, Convert.ToInt32(txtPeriodoLaboral.Text), dtpFechaFin.Value, Convert.ToDecimal(txtSalario.Text), cboBono.SelectedItem.ToString(), ImporteBono, PeriodicidadBono, FotoContrato, txtContrato.Text, FotoAnexoFunciones, txtAnexoFunciones.Text, FotoSolicitudPracticas, txtSolicitudPracticas.Text, FotoOtros, txtOtros.Text, frmLogin.CodigoUsuario, Opcion);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GrabarEditar(0);
                MessageBox.Show("Contrato modificado con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Limpiar();
            }
        }

        private void cboBono_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBono.SelectedIndex == 0)
            {
                txtImporteBono.Text = string.Empty;
                txtImporteBono.Visible = true;
                label17.Visible = true;
                txtPeriodicidad.Text = string.Empty;
                txtPeriodicidad.Visible = true;
                label19.Visible = true;
            }
            else
            {
                txtImporteBono.Text = string.Empty;
                txtImporteBono.Visible = false;
                label17.Visible = false;
                txtPeriodicidad.Text = string.Empty;
                txtPeriodicidad.Visible = false;
                label19.Visible = false;
            }
        }

        private void cboGerencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGerencia.SelectedIndex > -1)
            {
                cboArea.ValueMember = "CODIGOAREA";
                cboArea.DisplayMember = "AREA";
                cboArea.DataSource = clContrato.AreaGerencia(Convert.ToInt32(cboGerencia.SelectedValue));
            }
        }

        private void txtPeriodoLaboral_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPeriodoLaboral.Text))
            {
                dtpFechaFin.Value = dtpFechaInicio.Value.AddMonths(Convert.ToInt32(txtPeriodoLaboral.Text));
            }
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            txtPeriodoLaboral_TextChanged(sender, e);
        }

        private void txtSalario_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txtSalario);
        }
    }
}