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
    public partial class frmEmpleado : Form
    {
        HPResergerCapaLogica.HPResergerCL clEmpleado = new HPResergerCapaLogica.HPResergerCL();
        public byte[] FotoAntecedentesPoliciales { get; set; }
        public byte[] FotoAntecedentesPenales { get; set; }
        public byte[] FotoReciboServicios { get; set; }
        MemoryStream _memoryStream = new MemoryStream();
        public string nombreArchivoAntecedentesPoliciales { get; set; }
        public string nombreArchivoAntecedentesPenales { get; set; }
        public string nombreArchivoReciboServicios { get; set; }
        public bool EmpleadoExiste = false;
        public bool NewEmpleado = true;
        public int CodigoTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        DataRow ExisteEmpleado;

        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            cboTipoDocumento.SelectedIndex = -1;
            cboDepartamento.SelectedIndex = -1;
            cboProvincia.SelectedIndex = -1;
            cboDistrito.SelectedIndex = -1;
            cboSexo.SelectedIndex = -1;
            cboEstadoCivil.SelectedIndex = -1;
            cboLugarNacimiento.SelectedIndex = -1;
            cboProfesion.SelectedIndex = -1;
            cboGradoInstruccion.SelectedIndex = -1;
            txtNumeroDocumento.Text = string.Empty;
            txtApellidoPaterno.Text = string.Empty;
            txtApellidoMaterno.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtNHijos.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefonoFijo.Text = string.Empty;
            txtTelefonoCelular.Text = string.Empty;
            txtAntecedentesPoliciales.Text = string.Empty;
            txtAntecedentesPenales.Text = string.Empty;
            txtReciboServicio.Text = string.Empty;
            pbFotoAntecedentesPoliciales.Image = null;
            pbFotoAntecedentesPenales.Image = null;
            pbFotoReciboServicios.Image = null;
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            CargaCombos(cboTipoDocumento, "Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");
            CargaCombos(cboSexo, "Id_Sexo", "Sexo", "TBL_Sexo");
            CargaCombos(cboEstadoCivil, "Id_EstCivil", "EstadoCivil", "TBL_EstadoCivil");
            CargaCombos(cboProfesion, "Id_Profesion", "Profesion", "TBL_Profesion");
            CargaCombos(cboGradoInstruccion, "Id_GrdInstruccion", "GradoInstruccion", "TBL_GradoInstruccion");
            CargaCombos(cboDepartamento, "Cod_Dept", "Departamento", "TBL_Departamento");
            CargaCombos(cboLugarNacimiento, "Cod_Dept", "Departamento", "TBL_Departamento");
            NewEmpleado = true;
            Limpiar();
            cboTipoDocumento.SelectedIndex = 0;
            txtNumeroDocumento_TextChanged(sender, e);
        }

        private void CargaCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clEmpleado.getCargoTipoContratacion(codigo, descripcion, tabla);
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Tipo de Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboTipoDocumento.Focus();
                return;
            }

            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº de Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }
            else
            {
                ExisteEmpleado = clEmpleado.CargarCualquierImagenPostulanteEmpleado("*", "TBL_Empleado", "Tipo_ID_Emp", Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), "Nro_ID_Emp", txtNumeroDocumento.Text);
                if (ExisteEmpleado != null)
                {
                    frmContrato frmContrato = new frmContrato();
                    frmContrato.CodigoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
                    frmContrato.NumeroDocumento = txtNumeroDocumento.Text;
                    frmContrato.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Primero Registre al Postulante como Empleado", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnRegistrar.Focus();
                    return;
                }
            }
        }

        private void btnHaberes_Click(object sender, EventArgs e)
        {
            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Tipo de Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboTipoDocumento.Focus();
                return;
            }

            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº de Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }
            else
            {
                ExisteEmpleado = clEmpleado.CargarCualquierImagenPostulanteEmpleado("*", "TBL_Empleado", "Tipo_ID_Emp", Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), "Nro_ID_Emp", txtNumeroDocumento.Text);
                if (ExisteEmpleado != null)
                {
                    frmEmpleadoPagoHaberes frmHab = new frmEmpleadoPagoHaberes();
                    frmHab.CodigoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
                    frmHab.NumeroDocumento = txtNumeroDocumento.Text;
                    frmHab.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Primero Registre al Postulante como Empleado", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnRegistrar.Focus();
                    return;
                }
            }
        }

        private void btnCTS_Click(object sender, EventArgs e)
        {
            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Tipo de Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboTipoDocumento.Focus();
                return;
            }

            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº de Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }
            else
            {
                ExisteEmpleado = clEmpleado.CargarCualquierImagenPostulanteEmpleado("*", "TBL_Empleado", "Tipo_ID_Emp", Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), "Nro_ID_Emp", txtNumeroDocumento.Text);
                if (ExisteEmpleado != null)
                {
                    frmEmpleadoCTS frmCTS = new frmEmpleadoCTS();
                    frmCTS.CodigoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
                    frmCTS.NumeroDocumento = txtNumeroDocumento.Text;
                    frmCTS.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Primero Registre al Postulante como Empleado", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnRegistrar.Focus();
                    return;
                }
            }
        }

        private void btnRequerimiento_Click(object sender, EventArgs e)
        {
            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Tipo de Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboTipoDocumento.Focus();
                return;
            }

            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº de Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }
            else
            {
                ExisteEmpleado = clEmpleado.CargarCualquierImagenPostulanteEmpleado("*", "TBL_Empleado", "Tipo_ID_Emp", Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), "Nro_ID_Emp", txtNumeroDocumento.Text);
                if (ExisteEmpleado != null)
                {
                    frmEmpleadoRequerimiento frmReq = new frmEmpleadoRequerimiento();
                    frmReq.CodigoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
                    frmReq.NumeroDocumento = txtNumeroDocumento.Text;
                    frmReq.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Primero Registre al Postulante como Empleado", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnRegistrar.Focus();
                    return;
                }
            }
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartamento.SelectedValue != null)
            {
                cboProvincia.ValueMember = "codigoprovincia";
                cboProvincia.DisplayMember = "provincia";
                cboProvincia.DataSource = clEmpleado.ListarProvincia(Convert.ToInt32(cboDepartamento.SelectedValue.ToString()));
            }
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvincia.SelectedValue != null && cboDepartamento.SelectedValue != null)
            {
                cboDistrito.ValueMember = "CODIGODISTRITO";
                cboDistrito.DisplayMember = "DISTRITO";
                cboDistrito.DataSource = clEmpleado.ListarDistrito(Convert.ToInt32(cboDepartamento.SelectedValue.ToString()), Convert.ToInt32(cboProvincia.SelectedValue.ToString()));
            }
        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtNHijos_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtTelefonoFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtTelefonoCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }
            if (txtNHijos.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº de hijos", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNHijos.Focus();
                return;
            }
            if (txtDireccion.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Dirección", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtDireccion.Focus();
                return;
            }
            /*if (txtTelefonoFijo.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Teléfono Fijo", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTelefonoFijo.Focus();
                return;
            }*/
            if (txtTelefonoCelular.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Teléfono Celular", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTelefonoCelular.Focus();
                return;
            }
            if (txtAntecedentesPoliciales.Text.Length == 0)
            {
                MessageBox.Show("Seleccione Imagen Antecedentes Policiales", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnAntecedentesPoliciales.Focus();
                return;
            }
            if (txtAntecedentesPenales.Text.Length == 0)
            {
                MessageBox.Show("Seleccione Imagen Antecedentes ^Penales", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnAntecedentesPenales.Focus();
                return;
            }
            if (txtReciboServicio.Text.Length == 0)
            {
                MessageBox.Show("Seleccione Imagen de Recibo Servicios", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnReciboServicios.Focus();
                return;
            }

            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Tipo de Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboTipoDocumento.Focus();
                return;
            }

            if (cboDepartamento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Departamento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboDepartamento.Focus();
                return;
            }

            if (cboProvincia.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Provincia", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboProvincia.Focus();
                return;
            }

            if (cboDistrito.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Distrito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboDistrito.Focus();
                return;
            }

            if (cboSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Sexo", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboSexo.Focus();
                return;
            }

            if (cboEstadoCivil.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Estado Civil", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboEstadoCivil.Focus();
                return;
            }

            if (cboLugarNacimiento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Lugar de Nacimiento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboLugarNacimiento.Focus();
                return;
            }

            if (cboProfesion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Profesión", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboProfesion.Focus();
                return;
            }

            if (cboGradoInstruccion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Grado de Instrucción", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboGradoInstruccion.Focus();
                return;
            }

            ExisteEmpleado = clEmpleado.CargarCualquierImagenPostulanteEmpleado("*", "TBL_Empleado", "Tipo_ID_Emp", Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), "Nro_ID_Emp", txtNumeroDocumento.Text);
            if (ExisteEmpleado != null)
            {
                NewEmpleado = false;
                CodigoTipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
                NumeroDocumento = txtNumeroDocumento.Text;
            }
            else
            {
                NewEmpleado = true;
            }


            if (NewEmpleado == true)
            {
                clEmpleado.EmpleadoInsertar(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtNombres.Text, Convert.ToInt32(cboSexo.SelectedValue.ToString()), dtpFecha.Value, Convert.ToInt32(cboLugarNacimiento.SelectedValue.ToString()), Convert.ToInt32(cboEstadoCivil.SelectedValue.ToString()), Convert.ToInt32(txtNHijos.Text), txtDireccion.Text, Convert.ToInt32(cboDistrito.SelectedValue.ToString()), Convert.ToInt32(cboProvincia.SelectedValue.ToString()), Convert.ToInt32(cboDepartamento.SelectedValue.ToString()), txtTelefonoFijo.Text, txtTelefonoCelular.Text, Convert.ToInt32(cboProfesion.SelectedValue.ToString()), Convert.ToInt32(cboGradoInstruccion.SelectedValue.ToString()), FotoAntecedentesPoliciales, txtAntecedentesPoliciales.Text, FotoAntecedentesPenales, txtAntecedentesPenales.Text, FotoReciboServicios, txtReciboServicio.Text, frmLogin.CodigoUsuario);
                MessageBox.Show("El Empleado con " + cboTipoDocumento.SelectedText.ToString() + " Nº " + txtNumeroDocumento.Text + " se registró con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                clEmpleado.EmpleadoModificar(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, CodigoTipoDocumento, NumeroDocumento, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtNombres.Text, Convert.ToInt32(cboSexo.SelectedValue.ToString()), dtpFecha.Value, Convert.ToInt32(cboLugarNacimiento.SelectedValue.ToString()), Convert.ToInt32(cboEstadoCivil.SelectedValue.ToString()), Convert.ToInt32(txtNHijos.Text), txtDireccion.Text, Convert.ToInt32(cboDistrito.SelectedValue.ToString()), Convert.ToInt32(cboProvincia.SelectedValue.ToString()), Convert.ToInt32(cboDepartamento.SelectedValue.ToString()), txtTelefonoFijo.Text, txtTelefonoCelular.Text, Convert.ToInt32(cboProfesion.SelectedValue.ToString()), Convert.ToInt32(cboGradoInstruccion.SelectedValue.ToString()), FotoAntecedentesPoliciales, txtAntecedentesPoliciales.Text, FotoAntecedentesPenales, txtAntecedentesPenales.Text, FotoReciboServicios, txtReciboServicio.Text);
                MessageBox.Show("Los datos para el Empleado con " + cboTipoDocumento.SelectedText.ToString() + " Nº " + txtNumeroDocumento.Text + " se modificaron con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewEmpleado = true;
            }
        }

        private void btnAntecedentesPoliciales_Click(object sender, EventArgs e)
        {
            var dialogoAbrirArchivoAntecedentesPoliciales = new OpenFileDialog();
            dialogoAbrirArchivoAntecedentesPoliciales.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoAntecedentesPoliciales.DefaultExt = ".jpg";
            dialogoAbrirArchivoAntecedentesPoliciales.ShowDialog(this);

            nombreArchivoAntecedentesPoliciales = dialogoAbrirArchivoAntecedentesPoliciales.FileName.ToString();
            if (nombreArchivoAntecedentesPoliciales != string.Empty)
            {
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;

                pbFotoAntecedentesPoliciales.Image = Image.FromFile(nombreArchivoAntecedentesPoliciales);
                pbFotoAntecedentesPoliciales.Image.Save(_memoryStream, ImageFormat.Jpeg);
                FotoAntecedentesPoliciales = File.ReadAllBytes(dialogoAbrirArchivoAntecedentesPoliciales.FileName);
                txtAntecedentesPoliciales.Text = nombreArchivoAntecedentesPoliciales;
            }
        }

        private void btnAntecedentesPenales_Click(object sender, EventArgs e)
        {
            var dialogoAbrirArchivoAntecedentesPenales = new OpenFileDialog();
            dialogoAbrirArchivoAntecedentesPenales.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoAntecedentesPenales.DefaultExt = ".jpg";
            dialogoAbrirArchivoAntecedentesPenales.ShowDialog(this);

            nombreArchivoAntecedentesPenales = dialogoAbrirArchivoAntecedentesPenales.FileName.ToString();
            if (nombreArchivoAntecedentesPenales != string.Empty)
            {
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;

                pbFotoAntecedentesPenales.Image = Image.FromFile(nombreArchivoAntecedentesPenales);
                pbFotoAntecedentesPenales.Image.Save(_memoryStream, ImageFormat.Jpeg);
                FotoAntecedentesPenales = File.ReadAllBytes(dialogoAbrirArchivoAntecedentesPenales.FileName);
                txtAntecedentesPenales.Text = nombreArchivoAntecedentesPenales;
            }
        }

        private void btnReciboServicios_Click(object sender, EventArgs e)
        {
            var dialogoAbrirArchivoReciboServicios = new OpenFileDialog();
            dialogoAbrirArchivoReciboServicios.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoReciboServicios.DefaultExt = ".jpg";
            dialogoAbrirArchivoReciboServicios.ShowDialog(this);

            nombreArchivoReciboServicios = dialogoAbrirArchivoReciboServicios.FileName.ToString();
            if (nombreArchivoAntecedentesPenales != string.Empty)
            {
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;

                pbFotoReciboServicios.Image = Image.FromFile(nombreArchivoReciboServicios);
                pbFotoReciboServicios.Image.Save(_memoryStream, ImageFormat.Jpeg);
                FotoReciboServicios = File.ReadAllBytes(dialogoAbrirArchivoReciboServicios.FileName);
                txtReciboServicio.Text = nombreArchivoReciboServicios;
            }
        }

        private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {
            if (NewEmpleado == true)
            {
                if (cboTipoDocumento.SelectedIndex > -1)
                {
                    DataRow DatosP = clEmpleado.DatosPostulante(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text);
                    if (DatosP != null)
                    {
                        MessageBox.Show(DatosP["CONTRATACION"].ToString()+" "+ DatosP["TIPO"].ToString());
                        txtApellidoPaterno.Text = DatosP["APELLIDOPATERNO"].ToString();
                        txtApellidoMaterno.Text = DatosP["APELLIDOMATERNO"].ToString();
                        txtNombres.Text = DatosP["NOMBRES"].ToString();
                        txttipo.Text = DatosP["CONTRATACION"].ToString();
                        if (DatosP["TIPO"].ToString() == "2" || DatosP["TIPO"].ToString() == "3")
                        {
                            btnFamilia.Enabled = btnCTS.Enabled = btnPensionSeguro.Enabled = true;
                            btnContrato.Enabled = btnHaberes.Enabled = btnRequerimiento.Enabled = true;
                        }
                        else if (DatosP["TIPO"].ToString() == "1" || DatosP["TIPO"].ToString() == "4")

                        {
                            btnFamilia.Enabled = btnCTS.Enabled = btnPensionSeguro.Enabled = false;
                            btnContrato.Enabled = btnHaberes.Enabled = btnRequerimiento.Enabled = true;
                        }
                        else
                        {
                            btnContrato.Enabled = btnHaberes.Enabled = btnRequerimiento.Enabled = false;
                            btnFamilia.Enabled = btnCTS.Enabled = btnPensionSeguro.Enabled = false;
                        }
                    }
                    else
                    {
                        txtApellidoPaterno.Text = "";
                        txtApellidoMaterno.Text = "";
                        txttipo.Text = "";
                        txtNombres.Text = ""; btnFamilia.Enabled = btnCTS.Enabled = btnPensionSeguro.Enabled = false;
                        btnContrato.Enabled = btnHaberes.Enabled = btnRequerimiento.Enabled = false;
                    }
                    CargarDatosEmpleado(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text);
                }
            }
        }

        private void CargarDatosEmpleado(int TipoDocumento, string NumeroDocumento)
        {
            DataRow DatosE = clEmpleado.DatosEmpleado(TipoDocumento, NumeroDocumento);
            if (DatosE != null)
            {
                txtApellidoPaterno.Text = DatosE["APELLIDOPATERNO"].ToString();
                txtApellidoMaterno.Text = DatosE["APELLIDOMATERNO"].ToString();
                txtNombres.Text = DatosE["NOMBRES"].ToString();
                cboSexo.Text = DatosE["SEXO"].ToString();
                cboEstadoCivil.Text = DatosE["ESTADOCIVIL"].ToString();
                txtNHijos.Text = DatosE["NROHIJOS"].ToString();
                dtpFecha.Value = Convert.ToDateTime(DatosE["FECHANACIMIENTO"].ToString());
                cboLugarNacimiento.Text = DatosE["LUGARNACIMIENTO"].ToString();
                txtDireccion.Text = DatosE["DIRECCION"].ToString();
                cboDepartamento.Text = DatosE["DEPARTAMENTO"].ToString();
                cboProvincia.Text = DatosE["PROVINCIA"].ToString();
                cboDistrito.Text = DatosE["DISTRITO"].ToString();
                txtTelefonoFijo.Text = DatosE["TELEFONOFIJO"].ToString();
                txtTelefonoCelular.Text = DatosE["TELEFONOCELULAR"].ToString();
                cboProfesion.Text = DatosE["PROFESION"].ToString();
                cboGradoInstruccion.Text = DatosE["GRADOINSTRUCCION"].ToString();
                cboTipoDocumento.Text = DatosE["TIPODOCUMENTO"].ToString();
                txtNumeroDocumento.Text = DatosE["NUMERODOCUMENTO"].ToString();
                txttipo.Text = DatosE["CONTRATACION"].ToString();
                if (DatosE["TIPO"].ToString() == "1" || DatosE["TIPO"].ToString() == "4")
                {
                    btnFamilia.Enabled = btnCTS.Enabled = btnPensionSeguro.Enabled = false;
                    btnContrato.Enabled = btnHaberes.Enabled = btnRequerimiento.Enabled = true;
                }
                else
                {
                    btnFamilia.Enabled = btnCTS.Enabled = btnPensionSeguro.Enabled = true;
                    btnContrato.Enabled = btnHaberes.Enabled = btnRequerimiento.Enabled = true;

                }

                if (DatosE["FOTOPOLICIALES"] != null && DatosE["FOTOPOLICIALES"].ToString().Length > 0)
                {
                    byte[] Fotito = new byte[0];
                    FotoAntecedentesPoliciales = Fotito = (byte[])DatosE["FOTOPOLICIALES"];
                    MemoryStream ms = new MemoryStream(Fotito);
                    pbFotoAntecedentesPoliciales.Image = Bitmap.FromStream(ms);
                    txtAntecedentesPoliciales.Text = DatosE["ANTECEDENTESPOLICIALES"].ToString();
                }
                else
                {
                    txtAntecedentesPoliciales.Text = "";
                    pbFotoAntecedentesPoliciales.Image = null;
                }
                if (DatosE["FOTOPENALES"] != null && DatosE["FOTOPENALES"].ToString().Length > 0)
                {
                    byte[] Fotito = new byte[0];
                    FotoAntecedentesPenales = Fotito = (byte[])DatosE["FOTOPENALES"];
                    MemoryStream ms = new MemoryStream(Fotito);
                    pbFotoAntecedentesPenales.Image = Bitmap.FromStream(ms);
                    txtAntecedentesPenales.Text = DatosE["ANTECEDENTESPENALES"].ToString();
                }
                else
                {
                    txtAntecedentesPenales.Text = "";
                    pbFotoAntecedentesPenales.Image = null;
                }
                if (DatosE["FOTORECIBO"] != null && DatosE["FOTORECIBO"].ToString().Length > 0)
                {
                    byte[] Fotito = new byte[0];
                    FotoReciboServicios = Fotito = (byte[])DatosE["FOTORECIBO"];
                    MemoryStream ms = new MemoryStream(Fotito);
                    pbFotoReciboServicios.Image = Bitmap.FromStream(ms);
                    txtReciboServicio.Text = DatosE["RECIBOSERVICIOS"].ToString();
                }
                else
                {
                    txtReciboServicio.Text = "";
                    pbFotoReciboServicios.Image = null;
                }

                EmpleadoExiste = true;
            }
            else
            {
                cboSexo.Text = txtNHijos.Text =
                  txtDireccion.Text = txtTelefonoFijo.Text = txtTelefonoCelular.Text =
                  txtAntecedentesPoliciales.Text = txtAntecedentesPenales.Text = txtReciboServicio.Text = "";// txttipo.Text = "";
                dtpFecha.Value = DateTime.Now;
                EmpleadoExiste = false;
                cboDepartamento.SelectedIndex = cboProvincia.SelectedIndex = -1;
                cboDistrito.SelectedIndex = cboSexo.SelectedIndex = -1;
                cboEstadoCivil.SelectedIndex = cboLugarNacimiento.SelectedIndex = -1;
                cboProfesion.SelectedIndex = cboGradoInstruccion.SelectedIndex = -1;
            }
        }

        private void btnPensionSeguro_Click(object sender, EventArgs e)
        {
            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Tipo de Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboTipoDocumento.Focus();
                return;
            }

            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº de Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }
            else
            {
                ExisteEmpleado = clEmpleado.CargarCualquierImagenPostulanteEmpleado("*", "TBL_Empleado", "Tipo_ID_Emp", Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), "Nro_ID_Emp", txtNumeroDocumento.Text);
                if (ExisteEmpleado != null)
                {
                    frmEmpleadoPensionSeguro frmPS = new frmEmpleadoPensionSeguro();
                    frmPS.CodigoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
                    frmPS.NumeroDocumento = txtNumeroDocumento.Text;
                    frmPS.NuevoPensionSeguro = NewEmpleado;
                    frmPS.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Primero Registre al Postulante como Empleado", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnRegistrar.Focus();
                    return;
                }
            }
        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Tipo de Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboTipoDocumento.Focus();
                return;
            }

            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº de Documento", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }
            else
            {
                ExisteEmpleado = clEmpleado.CargarCualquierImagenPostulanteEmpleado("*", "TBL_Empleado", "Tipo_ID_Emp", Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), "Nro_ID_Emp", txtNumeroDocumento.Text);
                if (ExisteEmpleado != null)
                {
                    frmFamiliares frmF = new frmFamiliares();
                    frmF.CodigoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
                    frmF.NumeroDocumento = txtNumeroDocumento.Text;
                    frmF.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Primero Registre al Postulante como Empleado", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnRegistrar.Focus();
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListarEmpleados frmLE = new frmListarEmpleados();
            if (frmLE.ShowDialog() == DialogResult.OK)
            {
                CargarDatosEmpleado(frmLE.TipoDocumento, frmLE.NumeroDocumento);
                NewEmpleado = frmLE.UpdateEmpleado;
                CodigoTipoDocumento = frmLE.TipoDocumento;
                NumeroDocumento = frmLE.NumeroDocumento;
            }
            txtNumeroDocumento_TextChanged(sender, e);
        }

        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumeroDocumento_TextChanged(sender, e);
        }

        private void txtNumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtNumeroDocumento, 15);
        }

        private void txtTelefonoFijo_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtTelefonoFijo, 15);
        }

        private void txtTelefonoCelular_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtTelefonoCelular, 15);
        }

        private void pbFotoAntecedentesPoliciales_DoubleClick(object sender, EventArgs e)
        {
            MostrarFoto(pbFotoAntecedentesPoliciales);
        }

        private void pbFotoAntecedentesPenales_DoubleClick(object sender, EventArgs e)
        {
            MostrarFoto(pbFotoAntecedentesPenales);
        }

        private void pbFotoReciboServicios_DoubleClick(object sender, EventArgs e)
        {
            MostrarFoto(pbFotoReciboServicios);
        }

        private void pbFotoAntecedentesPoliciales_Click(object sender, EventArgs e)
        {

        }
        public void MostrarFoto(PictureBox fotito)
        {
            if (fotito.Image != null)
            {
                FrmFoto foto = new FrmFoto();
                foto.fotito = fotito.Image;
                foto.ShowDialog();
            }
        }
    }
}