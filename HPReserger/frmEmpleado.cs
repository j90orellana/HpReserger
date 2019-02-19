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
using HpResergerUserControls;

namespace HPReserger
{
    public partial class frmEmpleado : FormGradient, IProfesion, IFormEmpleado
    {
        HPResergerCapaLogica.HPResergerCL clEmpleado = new HPResergerCapaLogica.HPResergerCL();
        public byte[] FotoAntecedentesPoliciales { get; set; }
        public byte[] Foto { get; set; }
        public string NombreFoto { get; set; }
        public byte[] FotoAntecedentesPenales { get; set; }
        public byte[] FotoReciboServicios { get; set; }
        public byte[] FotoFirma { get; set; }
        MemoryStream _memoryStream = new MemoryStream();
        public string nombreArchivoAntecedentesPoliciales { get; set; }
        public string nombrefirma { get; set; }
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
        string cadena = "";
        public void CargarContratos()
        {
            //CargarDatosEmpleado((int)cboTipoDocumento.SelectedValue, txtNumeroDocumento.Text);
            txtNumeroDocumento_TextChanged(this, new EventArgs());
        }
        public void CargarEpsAdicional()
        {
            if (frmPS != null)
                frmPS.CargarEpsAdicional();
        }
        public void CargarPLanes()
        {
            if (frmPS != null)
                frmPS.CargarPLanes();
        }
        public void CargarProfesion()
        {
            cadena = cboProfesion.Text;
            CargaCombos2(cboProfesion, "Id_Profesion", "Profesion", "TBL_Profesion");
            cboProfesion.Text = cadena;
        }
        public void CargarGrado()
        {
            cadena = cboGradoInstruccion.Text;
            CargaCombos(cboGradoInstruccion, "Id_GrdInstruccion", "GradoInstruccion", "TBL_GradoInstruccion");
            cboGradoInstruccion.Text = cadena;
        }
        public void CargarNroHijos(int tipo, string doc)
        {
            DataRow DatosE = clEmpleado.DatosEmpleado(tipo, doc);
            if (DatosE != null)
                txtNHijos.Text = DatosE["NROHIJOS"].ToString();
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
            cbopais.SelectedItem = -1;
            cboGradoInstruccion.SelectedIndex = -1;
            txtNumeroDocumento.Text = string.Empty;
            txtApellidoPaterno.Text = string.Empty;
            txtApellidoMaterno.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtNHijos.Text = "0";
            txtDireccion.Text = string.Empty;
            txtTelefonoFijo.Text = string.Empty;
            txtTelefonoCelular.Text = string.Empty;
            txtAntecedentesPoliciales.Text = string.Empty;
            txtAntecedentesPenales.Text = string.Empty;
            txtReciboServicio.Text = string.Empty;
            pbFotoAntecedentesPoliciales.Image = null;
            pbFotoAntecedentesPenales.Image = null;
            pbFotoReciboServicios.Image = null;
            pbfirma.Image = null;
            txtfirma.Text = "";
        }
        DataTable TablaTipoID;
        public void CargarTiposID(string tabla)
        {
            TablaTipoID = new DataTable();
            TablaTipoID = clEmpleado.CualquierTabla(tabla);
            cboTipoDocumento.DisplayMember = "Desc_Tipo_ID";
            cboTipoDocumento.ValueMember = "Codigo_Tipo_ID";
            cboTipoDocumento.DataSource = TablaTipoID;
        }
        public void ModificarTamañoTipo(TextBox txt, int index)
        {
            if (index >= 0 && TablaTipoID != null)
            {
                DataRow Filita = TablaTipoID.Rows[index];
                txt.MaxLength = (int)Filita["Length"];
            }
        }
        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            CargarTiposID("TBL_Tipo_ID");
            CargaCombos(cboSexo, "Id_Sexo", "Sexo", "TBL_Sexo");
            CargaCombos(cboEstadoCivil, "Id_EstCivil", "EstadoCivil", "TBL_EstadoCivil");
            CargaCombos2(cboProfesion, "Id_Profesion", "Profesion", "TBL_Profesion");
            CargaCombos(cboGradoInstruccion, "Id_GrdInstruccion", "GradoInstruccion", "TBL_GradoInstruccion");
            CargaCombos(cboDepartamento, "Cod_Dept", "Departamento", "TBL_Departamento");
            CargaCombos(cboLugarNacimiento, "Cod_Dept", "Departamento", "TBL_Departamento");
            cbopais.DataSource = clEmpleado.ListarPaises();
            cbopais.DisplayMember = "pais";
            cbopais.ValueMember = "id_pais";
            NewEmpleado = true;
            Limpiar();
            cbopais.SelectedIndex = -1;
            btnfoto.Visible = false;
            cboTipoDocumento.SelectedIndex = 0;
            txtNumeroDocumento_TextChanged(sender, e);
            BloquearControles(true);
        }
        private void CargaCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clEmpleado.getCargoTipoContratacion(codigo, descripcion, tabla);
        }
        private void CargaCombos2(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clEmpleado.getCargoTipoContratacion2(codigo, descripcion, tabla);
        }
        frmContrato frmContrato;
        private void btnContrato_Click(object sender, EventArgs e)
        {
            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Tipo de Documento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboTipoDocumento.Focus();
                return;
            }
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº de Documento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }
            else
            {
                ExisteEmpleado = clEmpleado.CargarCualquierImagenPostulanteEmpleado("*", "TBL_Empleado", "Tipo_ID_Emp", Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), "Nro_ID_Emp", txtNumeroDocumento.Text);
                if (ExisteEmpleado != null)
                {
                    if (frmContrato == null)
                    {
                        frmContrato = new frmContrato();
                        frmContrato.CodigoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
                        frmContrato.NumeroDocumento = txtNumeroDocumento.Text;
                        frmContrato.CodigoEmpleado = int.Parse(txtcodigo.Text);
                        frmContrato.MdiParent = this.MdiParent;
                        frmContrato.Icon = this.Icon;
                        frmContrato.FormClosed += new FormClosedEventHandler(cerrarcontrato);
                        frmContrato.Show();
                    }
                    else
                    {
                        frmContrato.Activate();
                        ValidarVentanas(frmContrato);
                    }
                }
                else
                {
                    MessageBox.Show("Primero Registre al Postulante como Empleado", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnGuardar.Focus();
                    return;
                }
            }
        }
        void cerrarcontrato(object sender, FormClosedEventArgs e)
        {
            frmContrato = null;
        }
        public void ValidarVentanas(Form formulario)
        {
            if (formulario.WindowState != FormWindowState.Normal)
                formulario.WindowState = FormWindowState.Normal;
            formulario.Left = (this.MdiParent.Width - formulario.Width) / 2;
            formulario.Top = ((this.MdiParent.Height - formulario.Height) / 2) - 54;
        }
        frmEmpleadoPagoHaberes frmHab;
        private void btnHaberes_Click(object sender, EventArgs e)
        {
            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Tipo de Documento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboTipoDocumento.Focus();
                return;
            }

            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº de Documento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }
            else
            {
                ExisteEmpleado = clEmpleado.CargarCualquierImagenPostulanteEmpleado("*", "TBL_Empleado", "Tipo_ID_Emp", Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), "Nro_ID_Emp", txtNumeroDocumento.Text);
                if (ExisteEmpleado != null)
                {
                    if (frmHab == null)
                    {
                        frmHab = new frmEmpleadoPagoHaberes();
                        frmHab.CodigoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
                        frmHab.NumeroDocumento = txtNumeroDocumento.Text;
                        frmHab.MdiParent = this.MdiParent;
                        frmHab.Icon = this.Icon;
                        frmHab.FormClosed += new FormClosedEventHandler(cerrarpagohaberes);
                        frmHab.Show();
                    }
                    else
                    {
                        frmHab.Activate();
                        ValidarVentanas(frmHab);
                    }

                }
                else
                {
                    MessageBox.Show("Primero Registre al Postulante como Empleado", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnGuardar.Focus();
                    return;
                }
            }
        }
        void cerrarpagohaberes(object sender, FormClosedEventArgs e)
        {
            frmHab = null;
        }
        frmEmpleadoCTS frmCTS;
        private void btnCTS_Click(object sender, EventArgs e)
        {
            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Tipo de Documento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboTipoDocumento.Focus();
                return;
            }
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº de Documento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }
            else
            {
                ExisteEmpleado = clEmpleado.CargarCualquierImagenPostulanteEmpleado("*", "TBL_Empleado", "Tipo_ID_Emp", Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), "Nro_ID_Emp", txtNumeroDocumento.Text);
                if (ExisteEmpleado != null)
                {
                    if (frmCTS == null)
                    {
                        frmCTS = new frmEmpleadoCTS();
                        frmCTS.CodigoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
                        frmCTS.NumeroDocumento = txtNumeroDocumento.Text;
                        frmCTS.MdiParent = this.MdiParent;
                        frmCTS.Icon = this.Icon;
                        frmCTS.FormClosed += new FormClosedEventHandler(cerrarcts);
                        frmCTS.Show();
                    }
                    else
                    {
                        frmCTS.Activate();
                        ValidarVentanas(frmCTS);
                    }
                }
                else
                {
                    MessageBox.Show("Primero Registre al Postulante como Empleado", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnGuardar.Focus();
                    return;
                }
            }
        }
        void cerrarcts(object sender, FormClosedEventArgs e)
        {
            frmCTS = null;
        }
        frmEmpleadoRequerimiento frmReq;
        private void btnRequerimiento_Click(object sender, EventArgs e)
        {
            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Tipo de Documento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboTipoDocumento.Focus();
                return;
            }
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº de Documento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }
            else
            {
                ExisteEmpleado = clEmpleado.CargarCualquierImagenPostulanteEmpleado("*", "TBL_Empleado", "Tipo_ID_Emp", Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), "Nro_ID_Emp", txtNumeroDocumento.Text);
                if (ExisteEmpleado != null)
                {
                    if (frmReq == null)
                    {
                        frmReq = new frmEmpleadoRequerimiento();
                        frmReq.CodigoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
                        frmReq.NumeroDocumento = txtNumeroDocumento.Text;
                        frmReq.MdiParent = this.MdiParent;
                        frmReq.Icon = this.Icon;
                        frmReq.FormClosed += new FormClosedEventHandler(cerrarrequerimientos);
                        frmReq.Show();
                    }
                    else
                    {
                        frmReq.Activate();
                        ValidarVentanas(frmReq);
                    }

                }
                else
                {
                    MessageBox.Show("Primero Registre al Postulante como Empleado", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnGuardar.Focus();
                    return;
                }
            }
        }
        void cerrarrequerimientos(object sender, FormClosedEventArgs e)
        {
            frmReq = null;
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
            if (cboEstadoCivil.Text == "CONVIVIENTE")
            {
                if (string.IsNullOrWhiteSpace(txtconviviente.Text))
                {
                    MessageBox.Show("Falta La foto del Certificado de Convivencia", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnconviviente.Focus();
                    return;
                }
            }
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº Documento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }
            if (txtNHijos.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº de hijos", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNHijos.Focus();
                return;
            }
            if (txtDireccion.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Dirección", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtDireccion.Focus();
                return;
            }
            /*if (txtTelefonoFijo.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Teléfono Fijo", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTelefonoFijo.Focus();
                return;
            }*/
            if (txtTelefonoCelular.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Teléfono Celular", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTelefonoCelular.Focus();
                return;
            }
            if (txtAntecedentesPoliciales.Text.Length == 0)
            {
                MessageBox.Show("Seleccione Imagen Antecedentes Policiales", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnAntecedentesPoliciales.Focus();
                return;
            }
            if (txtAntecedentesPenales.Text.Length == 0)
            {
                MessageBox.Show("Seleccione Imagen Antecedentes Penales", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnAntecedentesPenales.Focus();
                return;
            }
            if (txtReciboServicio.Text.Length == 0)
            {
                MessageBox.Show("Seleccione Imagen de Recibo Servicios", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnReciboServicios.Focus();
                return;
            }

            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Tipo de Documento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboTipoDocumento.Focus();
                return;
            }

            if (cboDepartamento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Departamento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboDepartamento.Focus();
                return;
            }

            if (cboProvincia.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Provincia", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboProvincia.Focus();
                return;
            }

            if (cboDistrito.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Distrito", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboDistrito.Focus();
                return;
            }

            if (cboSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Sexo", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboSexo.Focus();
                return;
            }

            if (cboEstadoCivil.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Estado Civil", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboEstadoCivil.Focus();
                return;
            }

            if (cboLugarNacimiento.SelectedIndex == -1 && cbopais.Text.Trim() == "PERÚ")
            {
                MessageBox.Show("Seleccione Lugar de Nacimiento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboLugarNacimiento.Focus();
                return;
            }
            if (cbopais.Text.Trim() != "PERÚ" && string.IsNullOrWhiteSpace(txtlugarnacimiento.Text))
            {
                MessageBox.Show("Ingresé El lugar de Nacimiento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtlugarnacimiento.Focus();
                return;
            }

            if (cboProfesion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Profesión", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboProfesion.Focus();
                return;
            }

            if (cboGradoInstruccion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Grado de Instrucción", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboGradoInstruccion.Focus();
                return;
            }
            if (estadito != 2)
            {
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
            }

            if (NewEmpleado == true)
            {
                clEmpleado.EmpleadoInsertar(int.Parse(cbopais.SelectedValue.ToString()), txtlugarnacimiento.Text, Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtNombres.Text, Convert.ToInt32(cboSexo.SelectedValue.ToString()), dtpFecha.Value, Convert.ToInt32(cboLugarNacimiento.SelectedValue.ToString()), Convert.ToInt32(cboEstadoCivil.SelectedValue.ToString()), Convert.ToInt32(txtNHijos.Text), txtDireccion.Text, Convert.ToInt32(cboDistrito.SelectedValue.ToString()), Convert.ToInt32(cboProvincia.SelectedValue.ToString()), Convert.ToInt32(cboDepartamento.SelectedValue.ToString()), txtTelefonoFijo.Text, txtTelefonoCelular.Text, Convert.ToInt32(cboProfesion.SelectedValue.ToString()), Convert.ToInt32(cboGradoInstruccion.SelectedValue.ToString()), FotoAntecedentesPoliciales, txtAntecedentesPoliciales.Text, FotoAntecedentesPenales, txtAntecedentesPenales.Text, FotoReciboServicios, txtReciboServicio.Text, frmLogin.CodigoUsuario, Foto, NombreFoto, FotoFirma, txtfirma.Text);
                MessageBox.Show("El Empleado con " + cboTipoDocumento.SelectedText.ToString() + " Nº " + txtNumeroDocumento.Text + " se registró con éxito", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataRow convivi = clEmpleado.EmpleadoConviviente(txtNumeroDocumento.Text, int.Parse(cboTipoDocumento.SelectedValue.ToString()), conviviente, nombreconviviente, encontrado);
            }
            else
            {
                clEmpleado.EmpleadoModificar(int.Parse(cbopais.SelectedValue.ToString()), txtlugarnacimiento.Text, Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, CodigoTipoDocumento, NumeroDocumento, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtNombres.Text, Convert.ToInt32(cboSexo.SelectedValue.ToString()), dtpFecha.Value, Convert.ToInt32(cboLugarNacimiento.SelectedValue.ToString()), Convert.ToInt32(cboEstadoCivil.SelectedValue.ToString()), Convert.ToInt32(txtNHijos.Text), txtDireccion.Text, Convert.ToInt32(cboDistrito.SelectedValue.ToString()), Convert.ToInt32(cboProvincia.SelectedValue.ToString()), Convert.ToInt32(cboDepartamento.SelectedValue.ToString()), txtTelefonoFijo.Text, txtTelefonoCelular.Text, Convert.ToInt32(cboProfesion.SelectedValue.ToString()), Convert.ToInt32(cboGradoInstruccion.SelectedValue.ToString()), FotoAntecedentesPoliciales, txtAntecedentesPoliciales.Text, FotoAntecedentesPenales, txtAntecedentesPenales.Text, FotoReciboServicios, txtReciboServicio.Text, Foto, NombreFoto, FotoFirma, txtfirma.Text);
                MessageBox.Show("Los datos para el Empleado con " + cboTipoDocumento.SelectedText.ToString() + " Nº " + txtNumeroDocumento.Text + " se modificaron con éxito", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewEmpleado = true;
                DataRow convivi = clEmpleado.EmpleadoConviviente(txtNumeroDocumento.Text, int.Parse(cboTipoDocumento.SelectedValue.ToString()), conviviente, nombreconviviente, encontrado);
                //Actualizar la foto del empleado
                DataTable DatosFoto = clEmpleado.usuarios(txtNumeroDocumento.Text, (int)cboTipoDocumento.SelectedValue, 1);
                if (DatosFoto != null)
                {
                    datitofoto = DatosFoto.Rows[0];
                    if (datitofoto["loginuser"].ToString() == frmLogin.LoginUser)
                    {
                        IForm formInterface = this.MdiParent as IForm;
                        if (formInterface != null)
                            formInterface.CambiarImagen(pbfotoempleado);
                    }
                }
            }
        }
        DataRow datitofoto;
        private void btnAntecedentesPoliciales_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogoAbrirArchivoAntecedentesPoliciales = new OpenFileDialog();
            dialogoAbrirArchivoAntecedentesPoliciales.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoAntecedentesPoliciales.DefaultExt = ".jpg";
            if (dialogoAbrirArchivoAntecedentesPoliciales.ShowDialog(this) != DialogResult.Cancel)
            {

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
        }

        private void btnAntecedentesPenales_Click(object sender, EventArgs e)
        {
            var dialogoAbrirArchivoAntecedentesPenales = new OpenFileDialog();
            dialogoAbrirArchivoAntecedentesPenales.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoAntecedentesPenales.DefaultExt = ".jpg";
            if (dialogoAbrirArchivoAntecedentesPenales.ShowDialog(this) != DialogResult.Cancel)
            {

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
        }

        private void btnReciboServicios_Click(object sender, EventArgs e)
        {
            var dialogoAbrirArchivoReciboServicios = new OpenFileDialog();
            dialogoAbrirArchivoReciboServicios.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoReciboServicios.DefaultExt = ".jpg";
            if (dialogoAbrirArchivoReciboServicios.ShowDialog(this) != DialogResult.Cancel)
            {

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
        }
        DateTime FEchaActual;
        private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {
            if (estadito != 2)
            {
                NewEmpleado = true;
                if (NewEmpleado == true)
                {
                    if (cboTipoDocumento.SelectedIndex > -1)
                    {
                        FEchaActual = DateTime.Now;
                        DataRow DatosP = clEmpleado.DatosPostulante(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text);
                        if (DatosP != null)
                        {
                            if (estadito == 1)
                                BloquearControles(false);
                            //MessageBox.Show(DatosP["CONTRATACION"].ToString()+" "+ DatosP["TIPO"].ToString());
                            txtApellidoPaterno.Text = DatosP["APELLIDOPATERNO"].ToString();
                            txtApellidoMaterno.Text = DatosP["APELLIDOMATERNO"].ToString();
                            txtNombres.Text = DatosP["NOMBRES"].ToString();
                            txttipo.Text = DatosP["CONTRATACION"].ToString();
                            FEchaActual = dtpFecha.Value = (DateTime)DatosP["FechaNacimiento"];
                            if (estadito == 1)
                            {
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
                        }
                        else
                        {
                            txtApellidoPaterno.Text = "";
                            txtApellidoMaterno.Text = ""; txtcodigo.Text = "00000";
                            txttipo.Text = "";
                            txtNombres.Text = ""; btnFamilia.Enabled = btnCTS.Enabled = btnPensionSeguro.Enabled = false;
                            btnContrato.Enabled = btnHaberes.Enabled = btnRequerimiento.Enabled = false;
                            if (estadito == 0)
                                BloquearControles(true);
                        }
                        CargarDatosEmpleado(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text);
                    }
                }
            }
        }
        DataRow PaisFila;
        private void CargarDatosEmpleado(int TipoDocumento, string NumeroDocumento)
        {
            DataTable PaisOrigen = clEmpleado.BuscarPaisActual("PERÚ");
            PaisFila = PaisOrigen.Rows[0];
            DataRow DatosE = clEmpleado.DatosEmpleado(TipoDocumento, NumeroDocumento);
            if (DatosE != null)
            {
                if (estadito != 1)
                    btnModificar.Enabled = true;
                lklpenales.Enabled = lklpoliciales.Enabled = lklservicios.Enabled = true;
                txtApellidoPaterno.Text = DatosE["APELLIDOPATERNO"].ToString();
                txtApellidoMaterno.Text = DatosE["APELLIDOMATERNO"].ToString();
                txtcodigo.Text = ((int)DatosE["CODIGO"]).ToString("00000");
                txtNombres.Text = DatosE["NOMBRES"].ToString();
                cboSexo.Text = DatosE["SEXO"].ToString();
                cboEstadoCivil.Text = DatosE["ESTADOCIVIL"].ToString();
                txtNHijos.Text = DatosE["NROHIJOS"].ToString();
                FEchaActual = dtpFecha.Value = Convert.ToDateTime(DatosE["FECHANACIMIENTO"].ToString());
                cboLugarNacimiento.Text = DatosE["LUGARNACIMIENTO"].ToString();
                txtDireccion.Text = DatosE["DIRECCION"].ToString();
                cboDepartamento.Text = DatosE["DEPARTAMENTO"].ToString();
                cboProvincia.Text = DatosE["PROVINCIA"].ToString();
                cboDistrito.Text = DatosE["DISTRITO"].ToString();
                txtTelefonoFijo.Text = DatosE["TELEFONOFIJO"].ToString();
                txtTelefonoCelular.Text = DatosE["TELEFONOCELULAR"].ToString();
                cboProfesion.Text = DatosE["PROFESION"].ToString();
                cbopais.Text = DatosE["PAIS"].ToString();
                ///validar pais
                if (DatosE["id_pais"].ToString() != PaisFila["id_pais"].ToString())
                    txtlugarnacimiento.Text = DatosE["LUGAR"].ToString();
                cboGradoInstruccion.Text = DatosE["GRADOINSTRUCCION"].ToString();
                cboTipoDocumento.Text = DatosE["TIPODOCUMENTO"].ToString();
                txtNumeroDocumento.Text = DatosE["NUMERODOCUMENTO"].ToString();
                txttipo.Text = DatosE["CONTRATACION"].ToString();
                if (estadito == 1)
                {
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
                }
                if (DatosE["FOTOEMPLEADO"] != null && DatosE["FOTOEMPLEADO"].ToString().Length > 0)
                {
                    byte[] Fotito = new byte[0];
                    Foto = Fotito = (byte[])DatosE["FOTOEMPLEADO"];
                    MemoryStream ms = new MemoryStream(Fotito);
                    pbfotoempleado.Image = Bitmap.FromStream(ms);
                    NombreFoto = DatosE["nombrefotoempleado"].ToString();
                }
                else
                {
                    pbfotoempleado.Image = HPReserger.Properties.Resources.sshot_2017_07_04__18_02s_16_;
                    Foto = null; NombreFoto = "";
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
                    pbFotoAntecedentesPoliciales.Image = null; lklpoliciales.Enabled = false;
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
                    pbFotoAntecedentesPenales.Image = null; lklpenales.Enabled = false;
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
                    pbFotoReciboServicios.Image = null; lklservicios.Enabled = false;
                }
                if (DatosE["firma"] != null && DatosE["firma"].ToString().Length > 0)
                {
                    byte[] Fotito = new byte[0];
                    FotoFirma = Fotito = (byte[])DatosE["firma"];
                    MemoryStream ms = new MemoryStream(Fotito);
                    pbfirma.Image = Bitmap.FromStream(ms);
                    txtfirma.Text = DatosE["nombrefirma"].ToString();
                    lklfirma.Enabled = true;
                }
                else
                {
                    txtfirma.Text = "";
                    pbfirma.Image = null;
                    lklfirma.Enabled = false;
                }
                btnfoto.Visible = true;
                EmpleadoExiste = true;
            }
            else
            {
                btnfoto.Visible = false;
                cboSexo.Text = txtDireccion.Text = txtTelefonoFijo.Text = txtTelefonoCelular.Text =
                  txtAntecedentesPoliciales.Text = txtAntecedentesPenales.Text = txtReciboServicio.Text = "";// txttipo.Text = "";
                dtpFecha.Value = FEchaActual; txtcodigo.Text = "00000";
                EmpleadoExiste = false;
                cboDepartamento.SelectedIndex = cboProvincia.SelectedIndex = -1; cbopais.SelectedIndex = -1;
                cboDistrito.SelectedIndex = cboSexo.SelectedIndex = -1;
                cboEstadoCivil.SelectedIndex = cboLugarNacimiento.SelectedIndex = -1;
                cboProfesion.SelectedIndex = cboGradoInstruccion.SelectedIndex = -1;
                pbFotoAntecedentesPenales.Image = pbFotoAntecedentesPoliciales.Image = pbFotoReciboServicios.Image = null;
                FotoAntecedentesPenales = FotoAntecedentesPoliciales = FotoReciboServicios = null;
                lklpenales.Enabled = lklpoliciales.Enabled = lklservicios.Enabled = lklfirma.Enabled = false;
                pbfotoempleado.Image = HPReserger.Properties.Resources.sshot_2017_07_04__18_02s_16_; Foto = null; cbopais.SelectedItem = -1; txtlugarnacimiento.Text = "";
                pbfirma.Image = null; txtfirma.Text = ""; FotoFirma = null;
                txtNHijos.Text = "0"; btnModificar.Enabled = false;
                if (estadito == 0)
                    BloquearControles(true);
            }
            if (EmpleadoExiste == true)
            {
                Contratoactivo = clEmpleado.ContratoActivo(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, DateTime.Now);
                if (Contratoactivo != null)
                {
                    txttipo.Text = Contratoactivo["tipo"].ToString();

                    if (Contratoactivo["tipocontratacion"].ToString() == "1" || Contratoactivo["tipocontratacion"].ToString() == "4")
                    {
                        btnFamilia.Enabled = btnCTS.Enabled = btnPensionSeguro.Enabled = false;
                        btnContrato.Enabled = btnHaberes.Enabled = btnRequerimiento.Enabled = true;
                    }
                    else
                    {
                        btnFamilia.Enabled = btnCTS.Enabled = btnPensionSeguro.Enabled = true;
                        btnContrato.Enabled = btnHaberes.Enabled = btnRequerimiento.Enabled = true;
                    }
                }
                else
                {
                    DataRow ContratoactivoTiene = clEmpleado.ContratoActivo_oTiene(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, DateTime.Now);
                    if (ContratoactivoTiene != null)
                    {
                        txttipo.Text = ContratoactivoTiene["tipo"].ToString() + " NO INICIA CONTRATO";//" Inicia:" + ContratoactivoTiene["fechainicio"].ToString();
                        txttipo.Text = ContratoactivoTiene["tipo"].ToString() + " INICIA EL: " + ((DateTime)ContratoactivoTiene["fechainicio"]).ToShortDateString();
                        if (ContratoactivoTiene["tipocontratacion"].ToString() == "1" || ContratoactivoTiene["tipocontratacion"].ToString() == "4")
                        {
                            btnFamilia.Enabled = btnCTS.Enabled = btnPensionSeguro.Enabled = false;
                            btnContrato.Enabled = btnHaberes.Enabled = btnRequerimiento.Enabled = true;
                        }
                        else
                        {
                            btnFamilia.Enabled = btnCTS.Enabled = btnPensionSeguro.Enabled = true;
                            btnContrato.Enabled = btnHaberes.Enabled = btnRequerimiento.Enabled = true;
                        }
                    }
                    BloquearControles(true);
                    btnContrato.Enabled = true;
                }
            }
            else
            {
                btnFamilia.Enabled = btnCTS.Enabled = btnPensionSeguro.Enabled = false;
                btnContrato.Enabled = false;
                btnHaberes.Enabled = btnRequerimiento.Enabled = false;
            }
        }
        DataRow Contratoactivo;
        public void BloquearControles(Boolean a)
        {
            a = !a;
            txttipo.Enabled = a;
            txtTelefonoFijo.Enabled = a;
            txtTelefonoCelular.Enabled = a;
            txtNombres.Enabled = a;
            txtDireccion.Enabled = a;
            txtconviviente.Enabled = a;
            txtApellidoMaterno.Enabled = a;
            txtApellidoPaterno.Enabled = a;
            //txtNHijos.Enabled = a;
            txtlugarnacimiento.Enabled = a;
            cboDepartamento.Enabled = a;
            cboDistrito.Enabled = a;
            cboEstadoCivil.Enabled = a;
            cboGradoInstruccion.Enabled = a;
            cboLugarNacimiento.Enabled = a;
            cbopais.Enabled = a;
            cboProfesion.Enabled = a;
            cboProvincia.Enabled = a;
            cboSexo.Enabled = a;
            btnAntecedentesPenales.Enabled = a;
            btnAntecedentesPoliciales.Enabled = a;
            btnconviviente.Enabled = a;
            //btnCTS.Enabled = a;
            //btnFamilia.Enabled = a;
            btnfirma.Enabled = a;
            btnfoto.Enabled = a;
            // btnHaberes.Enabled = a;
            // btnPensionSeguro.Enabled = a;
            btnReciboServicios.Enabled = a;
            //btnRequerimiento.Enabled = a;
            dtpFecha.Enabled = a;
        }
        frmEmpleadoPensionSeguro frmPS;
        private void btnPensionSeguro_Click(object sender, EventArgs e)
        {
            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Tipo de Documento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboTipoDocumento.Focus();
                return;
            }

            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº de Documento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }
            else
            {
                ExisteEmpleado = clEmpleado.CargarCualquierImagenPostulanteEmpleado("*", "TBL_Empleado", "Tipo_ID_Emp", Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), "Nro_ID_Emp", txtNumeroDocumento.Text);
                if (ExisteEmpleado != null)
                {
                    if (frmPS == null)
                    {
                        frmPS = new frmEmpleadoPensionSeguro();
                        frmPS.CodigoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
                        frmPS.NumeroDocumento = txtNumeroDocumento.Text;
                        frmPS.NuevoPensionSeguro = NewEmpleado;
                        frmPS.MdiParent = this.MdiParent;
                        frmPS.Icon = this.Icon;
                        frmPS.FormClosed += new FormClosedEventHandler(cerrarpensionseguro);
                        frmPS.Show();
                    }
                    else
                    {
                        frmPS.Activate();
                        ValidarVentanas(frmPS);
                    }
                }
                else
                {
                    MessageBox.Show("Primero Registre al Postulante como Empleado", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnGuardar.Focus();
                    return;
                }
            }
        }
        void cerrarpensionseguro(object sender, FormClosedEventArgs e)
        {
            frmPS = null;
        }
        frmFamiliares frmF;
        private void btnFamilia_Click(object sender, EventArgs e)
        {
            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Tipo de Documento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboTipoDocumento.Focus();
                return;
            }

            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº de Documento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }
            else
            {
                ExisteEmpleado = clEmpleado.CargarCualquierImagenPostulanteEmpleado("*", "TBL_Empleado", "Tipo_ID_Emp", Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), "Nro_ID_Emp", txtNumeroDocumento.Text);
                if (ExisteEmpleado != null)
                {
                    if (frmF == null)
                    {
                        frmF = new frmFamiliares();
                        frmF.CodigoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
                        frmF.NumeroDocumento = txtNumeroDocumento.Text;
                        frmF.Icon = this.Icon;
                        frmF.MdiParent = this.MdiParent;
                        frmF.FormClosed += new FormClosedEventHandler(cerrarventanafamiliares);
                        frmF.Show();
                    }
                    else
                    {
                        frmF.Activate();
                        ValidarVentanas(frmF);
                    }
                }
                else
                {
                    MessageBox.Show("Primero Registre al Postulante como Empleado", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnGuardar.Focus();
                    return;
                }
            }
        }
        void cerrarventanafamiliares(object sender, FormClosedEventArgs e)
        {
            frmF = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmListarEmpleados frmLE = new frmListarEmpleados();
            if (frmLE.ShowDialog() == DialogResult.OK)
            {
                CargarDatosEmpleado(frmLE.TipoDocumento, frmLE.NumeroDocumento);
                NewEmpleado = frmLE.UpdateEmpleado;
                CodigoTipoDocumento = frmLE.TipoDocumento;
                txtNumeroDocumento.Text = NumeroDocumento = frmLE.NumeroDocumento;
            }
            txtNumeroDocumento_TextChanged(sender, e);
        }

        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModificarTamañoTipo(txtNumeroDocumento, cboTipoDocumento.SelectedIndex);
            txtNumeroDocumento_TextChanged(sender, e);
        }

        private void txtNumeroDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtNumeroDocumento, txtNumeroDocumento.MaxLength);
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
            MostrarFoto(pbFotoAntecedentesPoliciales, $"Antecedentes de {txtNombres.Text} {txtApellidoPaterno.Text} {txtApellidoMaterno.Text}");
        }

        private void pbFotoAntecedentesPenales_DoubleClick(object sender, EventArgs e)
        {
            MostrarFoto(pbFotoAntecedentesPenales, $"Antecedentes de {txtNombres.Text} {txtApellidoPaterno.Text} {txtApellidoMaterno.Text}");
        }

        private void pbFotoReciboServicios_DoubleClick(object sender, EventArgs e)
        {
            MostrarFoto(pbFotoReciboServicios, $"Recibo de Servicios de {txtNombres.Text} {txtApellidoPaterno.Text} {txtApellidoMaterno.Text}");
        }

        private void pbFotoAntecedentesPoliciales_Click(object sender, EventArgs e)
        {

        }
        public void MostrarFoto(PictureBox fotito, string nombre)
        {
            if (fotito.Image != null)
            {
                FrmFoto foto = new FrmFoto(nombre);
                foto.fotito = fotito.Image;
                foto.Owner = this.MdiParent;
                foto.Nombre = nombre;
                foto.ShowDialog();
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFoto(pbFotoAntecedentesPoliciales, $"Antecedentes de {txtNombres.Text} {txtApellidoPaterno.Text} {txtApellidoMaterno.Text}");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFoto(pbFotoAntecedentesPenales, $"Antecedentes de {txtNombres.Text} {txtApellidoPaterno.Text} {txtApellidoMaterno.Text}");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFoto(pbFotoReciboServicios, $"Recibo de Servicios de {txtNombres.Text} {txtApellidoPaterno.Text} {txtApellidoMaterno.Text}");
        }

        private void cbopais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbopais.SelectedValue != null)
            {
                if (cbopais.SelectedValue.ToString() == PaisFila["id_pais"].ToString())
                {
                    cboLugarNacimiento.Visible = true;
                    txtlugarnacimiento.Visible = false;
                }
                else
                {
                    txtlugarnacimiento.Visible = true;
                    cboLugarNacimiento.Visible = false;
                }
            }
        }
        public void MSG(string cadena)
        {
            MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void pbfotoempleado_Click(object sender, EventArgs e)
        {


        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            var dialogoAbrirArchivoFoto = new OpenFileDialog();
            dialogoAbrirArchivoFoto.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoFoto.DefaultExt = ".jpg";
            dialogoAbrirArchivoFoto.ShowDialog(this);

            NombreFoto = dialogoAbrirArchivoFoto.FileName.ToString();
            if (NombreFoto != string.Empty)
            {
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;
                pbfotoempleado.Image = Image.FromFile(NombreFoto);
                pbfotoempleado.Image.Save(_memoryStream, ImageFormat.Jpeg);
                Foto = File.ReadAllBytes(dialogoAbrirArchivoFoto.FileName);
            }
        }
        byte[] conviviente; string nombreconviviente;
        int encontrado = 0;
        private void cboEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEstadoCivil.Text == "CONVIVIENTE")
            {
                lblconviviente.Visible = true;
                txtconviviente.Visible = true;
                btnconviviente.Visible = true;
                // pbconviviente.Visible = true;
                lklconviviente.Visible = true;
                DataRow convivientes = clEmpleado.EmpleadoConviviente(txtNumeroDocumento.Text, int.Parse(cboTipoDocumento.SelectedValue.ToString()), null, null, 0);
                if (convivientes != null && convivientes["nombreconviviente"].ToString().Length > 0)
                {
                    txtconviviente.Text = nombreconviviente = convivientes["nombreconviviente"].ToString();
                    byte[] Fotito = new byte[0];
                    conviviente = Fotito = (byte[])convivientes["conviviente"];
                    MemoryStream ms = new MemoryStream(Fotito);
                    pbconviviente.Image = Bitmap.FromStream(ms);
                    encontrado = 1;
                }
                else encontrado = 2;

            }
            else
            {
                lblconviviente.Visible = false;
                txtconviviente.Visible = false;
                btnconviviente.Visible = false;
                pbconviviente.Visible = false;
                lklconviviente.Visible = false;
            }
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

            }
        }

        private void lklconviviente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFoto(pbconviviente, $"Conviviente de {txtNombres.Text} {txtApellidoPaterno.Text} {txtApellidoMaterno.Text}");
        }

        private void txtAntecedentesPoliciales_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnfirma_Click(object sender, EventArgs e)
        {
            var dialogoAbrirFirmaDigital = new OpenFileDialog();
            dialogoAbrirFirmaDigital.Filter = "Jpg Files|*.jpg";
            dialogoAbrirFirmaDigital.DefaultExt = ".jpg";
            if (dialogoAbrirFirmaDigital.ShowDialog(this) != DialogResult.Cancel)
            {

                nombrefirma = dialogoAbrirFirmaDigital.FileName.ToString();
                if (nombrefirma != string.Empty)
                {
                    _memoryStream.Position = 0;
                    _memoryStream.SetLength(0);
                    _memoryStream.Capacity = 0;

                    pbfirma.Image = Image.FromFile(nombrefirma);
                    pbfirma.Image.Save(_memoryStream, ImageFormat.Jpeg);
                    FotoFirma = File.ReadAllBytes(dialogoAbrirFirmaDigital.FileName);
                    txtfirma.Text = nombrefirma; lklfirma.Enabled = true;
                }
            }
        }
        private void lklfirma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFoto(pbfirma, $"Firma Digital de {txtNombres.Text} {txtApellidoPaterno.Text} {txtApellidoMaterno.Text}");
        }
        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNumeroDocumento.Text.Length != txtNumeroDocumento.MaxLength && txtNumeroDocumento.Text != "0701046971")
            {
                MessageBox.Show("No Coincide el Tamaño con el tipo de Documento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }
            DataRow DatosE = clEmpleado.DatosEmpleado((int)cboTipoDocumento.SelectedValue, txtNumeroDocumento.Text);
            if (DatosE != null)
                txtNHijos.Text = DatosE["NROHIJOS"].ToString();
            if (cboEstadoCivil.Text == "CONVIVIENTE")
            {
                if (string.IsNullOrWhiteSpace(txtconviviente.Text))
                {
                    MessageBox.Show("Falta La foto del Certificado de Convivencia", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnconviviente.Focus();
                    return;
                }
            }
            if (txtNumeroDocumento.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº Documento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNumeroDocumento.Focus();
                return;
            }
            if (txtNHijos.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Nº de hijos", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNHijos.Focus();
                return;
            }
            //if (txtDireccion.Text.Length == 0)
            //{
            //    MessageBox.Show("Ingrese Dirección", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    txtDireccion.Focus();
            //    return;
            //}
            DataRow Filita = clEmpleado.CalcularEdad(dtpFecha.Value, DateTime.Now, 1);
            if (Filita != null)
            {
                if ((int)Filita["edad"] < 18)
                {
                    MessageBox.Show("El Empleado Debe ser Mayor de Edad", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    dtpFecha.Focus();
                    return;
                }
            }
            else { return; }

            /*if (txtTelefonoFijo.Text.Length == 0)
            {
                MessageBox.Show("Ingrese Teléfono Fijo", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTelefonoFijo.Focus();
                return;
            }*/
            //if (txtTelefonoCelular.Text.Length == 0)
            //{
            //    MessageBox.Show("Ingrese Teléfono Celular", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    txtTelefonoCelular.Focus();
            //    return;
            //}
            //if (txttipo.Text != "RECIBO POR HONORARIOS")
            //{
            //    if (txtAntecedentesPoliciales.Text.Length == 0)
            //    {
            //        MessageBox.Show("Seleccione Imagen Antecedentes Policiales", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        btnAntecedentesPoliciales.Focus();
            //        return;
            //    }
            //    if (txtAntecedentesPenales.Text.Length == 0)
            //    {
            //        MessageBox.Show("Seleccione Imagen Antecedentes Penales", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        btnAntecedentesPenales.Focus();
            //        return;
            //    }
            //    if (txtReciboServicio.Text.Length == 0)
            //    {
            //        MessageBox.Show("Seleccione Imagen de Recibo Servicios", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        btnReciboServicios.Focus();
            //        return;
            //    }
            //}
            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Tipo de Documento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cboTipoDocumento.Focus();
                return;
            }

            //if (cboDepartamento.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Seleccione Departamento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    cboDepartamento.Focus();
            //    return;
            //}

            //if (cboProvincia.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Seleccione Provincia", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    cboProvincia.Focus();
            //    return;
            //}

            //if (cboDistrito.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Seleccione Distrito", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    cboDistrito.Focus();
            //    return;
            //}

            //if (cboSexo.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Seleccione Sexo", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    cboSexo.Focus();
            //    return;
            //}

            //if (cboEstadoCivil.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Seleccione Estado Civil", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    cboEstadoCivil.Focus();
            //    return;
            //}

            //if (cboLugarNacimiento.SelectedIndex == -1 && cbopais.Text.Trim() == "PERÚ")
            //{
            //    MessageBox.Show("Seleccione Lugar de Nacimiento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    cboLugarNacimiento.Focus();
            //    return;
            //}
            //if (cbopais.Text.Trim() != "PERÚ" && string.IsNullOrWhiteSpace(txtlugarnacimiento.Text))
            //{
            //    MessageBox.Show("Ingresé El lugar de Nacimiento", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    txtlugarnacimiento.Focus();
            //    return;
            //}
            //if (cbopais.Text.Trim() != "PERÚ")
            //{
            //    txtlugarnacimiento.Focus(); cboLugarNacimiento.SelectedIndex = 0;
            //}
            //if (cboProfesion.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Seleccione Profesión", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    cboProfesion.Focus();
            //    return;
            //}

            //if (cboGradoInstruccion.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Seleccione Grado de Instrucción", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    cboGradoInstruccion.Focus();
            //    return;
            //}

            ExisteEmpleado = clEmpleado.CargarCualquierImagenPostulanteEmpleado("*", "TBL_Empleado", "Tipo_ID_Emp", Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), "Nro_ID_Emp", txtNumeroDocumento.Text);
            if (ExisteEmpleado != null)
            {
                NewEmpleado = false;
                CodigoTipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
                NumeroDocumento = txtNumeroDocumento.Text;
                if (int.Parse(txtcodigo.Text) != (int)ExisteEmpleado["cod_emp"])
                {
                    MSG("Este Número Documento ya existe");
                    return;
                }
            }
            else
            {
                NewEmpleado = true;
            }
            if (estadito == 2) NewEmpleado = false;
            if (NewEmpleado == true)
            {
                clEmpleado.EmpleadoInsertar(int.Parse((cbopais.SelectedValue ?? 0).ToString()), txtlugarnacimiento.Text, Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, txtApellidoPaterno.Text,
                    txtApellidoMaterno.Text, txtNombres.Text, Convert.ToInt32((cboSexo.SelectedValue ?? 0).ToString()), dtpFecha.Value, Convert.ToInt32((cboLugarNacimiento.SelectedValue ?? 0).ToString()), Convert.ToInt32((cboEstadoCivil.SelectedValue ?? 0).ToString()),
                    Convert.ToInt32(txtNHijos.Text), txtDireccion.Text, Convert.ToInt32((cboDistrito.SelectedValue ?? 0).ToString()), Convert.ToInt32((cboProvincia.SelectedValue ?? 0).ToString()),
                    Convert.ToInt32((cboDepartamento.SelectedValue ?? 0).ToString()), txtTelefonoFijo.Text, txtTelefonoCelular.Text, Convert.ToInt32((cboProfesion.SelectedValue ?? 0).ToString()),
                    Convert.ToInt32((cboGradoInstruccion.SelectedValue ?? 0).ToString()), FotoAntecedentesPoliciales, txtAntecedentesPoliciales.Text, FotoAntecedentesPenales, txtAntecedentesPenales.Text, FotoReciboServicios, txtReciboServicio.Text, frmLogin.CodigoUsuario, Foto, NombreFoto, FotoFirma, txtfirma.Text);
                MessageBox.Show("El Empleado con " + cboTipoDocumento.SelectedText.ToString() + " Nº " + txtNumeroDocumento.Text + " se registró con éxito", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataRow convivi = clEmpleado.EmpleadoConviviente(txtNumeroDocumento.Text, int.Parse(cboTipoDocumento.SelectedValue.ToString()), conviviente, nombreconviviente, encontrado);
            }
            else
            {

                clEmpleado.EmpleadoModificar(int.Parse((cbopais.SelectedValue ?? 0).ToString()), txtlugarnacimiento.Text, Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, CodigoTipoDocumento, NumeroDocumento,
                    txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtNombres.Text, Convert.ToInt32((cboSexo.SelectedValue ?? 0).ToString()), dtpFecha.Value, Convert.ToInt32((cboLugarNacimiento.SelectedValue ?? 0).ToString()),
                    Convert.ToInt32((cboEstadoCivil.SelectedValue ?? 0).ToString()), Convert.ToInt32(txtNHijos.Text), txtDireccion.Text, Convert.ToInt32((cboDistrito.SelectedValue ?? 0).ToString()),
                    Convert.ToInt32((cboProvincia.SelectedValue ?? 0).ToString()), Convert.ToInt32((cboDepartamento.SelectedValue ?? 0).ToString()), txtTelefonoFijo.Text, txtTelefonoCelular.Text,
                    Convert.ToInt32((cboProfesion.SelectedValue ?? 0).ToString()), Convert.ToInt32((cboGradoInstruccion.SelectedValue ?? 0).ToString()), FotoAntecedentesPoliciales, txtAntecedentesPoliciales.Text, FotoAntecedentesPenales, txtAntecedentesPenales.Text, FotoReciboServicios, txtReciboServicio.Text, Foto, NombreFoto, FotoFirma, txtfirma.Text);
                MessageBox.Show("Los datos para el Empleado con " + cboTipoDocumento.SelectedText.ToString() + " Nº " + txtNumeroDocumento.Text + " se modificaron con éxito", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewEmpleado = true;

                DataRow convivi = clEmpleado.EmpleadoConviviente(txtNumeroDocumento.Text, int.Parse(cboTipoDocumento.SelectedValue.ToString()), conviviente, nombreconviviente, encontrado);
            }
            DataTable DatosEmpleados = clEmpleado.usuarios(txtNumeroDocumento.Text, (int)cboTipoDocumento.SelectedValue, 1);
            if (DatosEmpleados != null)
            {
                if (DatosEmpleados.Rows.Count > 0)
                {
                    filitas = DatosEmpleados.Rows[0];
                    if (filitas["loginuser"].ToString() == frmLogin.LoginUser)
                    {
                        IForm Iforma = this.MdiParent as IForm;
                        if (Iforma != null)
                        {
                            Iforma.CambiarImagen(pbfotoempleado);
                        }
                    }
                }
            }
            Iniciar(false);
            BloquearControles(true);
            if (NewEmpleado)
                txtNumeroDocumento_TextChanged(sender, e);
            //base.loa
            ///mostrar imagen;

        }
        DataRow filitas;
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estadito != 0 && !string.IsNullOrWhiteSpace(txtNumeroDocumento.Text))
            {
                Iniciar(false); BloquearControles(true);
                estadito = 0;
                pbfotoempleado.Image = FotoEmp;
                txtNumeroDocumento_TextChanged(sender, e);
            }
            else
                this.Close();
        }
        int estadito = 0;
        private void btnModificar_Click(object sender, EventArgs e)
        {
            FotoEmp = pbfotoempleado.Image;
            Iniciar(true);
            BloquearControles(false);
            txttipo.Enabled = false;
            VerificarContrato();
            txtNumeroDocumento.Enabled = cboTipoDocumento.Enabled = true;
            CodigoTipoDocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString());
            NumeroDocumento = txtNumeroDocumento.Text;
            estadito = 2;
        }
        public void Iniciar(Boolean a)
        {
            txtNumeroDocumento.Enabled = !a;
            cboTipoDocumento.Enabled = !a;
            //btnContrato.Enabled = a;
            btnGuardar.Enabled = a;
            btnfoto.Enabled = a;
            btnModificar.Enabled = !a;
            button1.Enabled = !a;
            btnnuevo.Enabled = !a;

        }
        public void VerificarContrato()
        {
            Contratoactivo = clEmpleado.ContratoActivo(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtNumeroDocumento.Text, DateTime.Now);
            if (Contratoactivo != null)
            {
                txttipo.Text = Contratoactivo["tipo"].ToString();
                if (Contratoactivo["tipocontratacion"].ToString() == "1" || Contratoactivo["tipocontratacion"].ToString() == "4")
                {
                    btnFamilia.Enabled = btnCTS.Enabled = btnPensionSeguro.Enabled = false;
                    btnContrato.Enabled = btnHaberes.Enabled = btnRequerimiento.Enabled = true;
                }
                else
                {
                    btnFamilia.Enabled = btnCTS.Enabled = btnPensionSeguro.Enabled = true;
                    btnContrato.Enabled = btnHaberes.Enabled = btnRequerimiento.Enabled = true;
                }
            }
            else
            {
                txttipo.Text = "EMPLEADO SIN CONTRATO ACTIVO";
                btnFamilia.Enabled = btnCTS.Enabled = btnPensionSeguro.Enabled = btnHaberes.Enabled = btnRequerimiento.Enabled = false;
                btnContrato.Enabled = true;
            }
        }
        Image FotoEmp;
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            //            txtNumeroDocumento.Text = "";
            estadito = 1;
            BloquearControles(false);
            Iniciar(true);
            txtNumeroDocumento.Enabled = true;
            cboTipoDocumento.Enabled = true;
            button1.Enabled = true;
            txttipo.Enabled = false;
            Contratoactivo = null;
            btnFamilia.Enabled = btnCTS.Enabled = btnPensionSeguro.Enabled = btnContrato.Enabled = btnHaberes.Enabled = btnRequerimiento.Enabled = false;
            btnfoto.Visible = true;
            FotoEmp = pbfotoempleado.Image;
            cbopais.SelectedIndex = cbopais.FindString("PERÚ");
        }
        private void pbfotoempleado_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pbfotoempleado_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbfotoempleado.Image != null)
                btndescargar.Visible = true;
        }

        private void btndescargar_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbfotoempleado.Image != null)
                btndescargar.Visible = true;
        }

        private void frmEmpleado_MouseMove(object sender, MouseEventArgs e)
        {
            btndescargar.Visible = false;
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            HPResergerFunciones.Utilitarios.DescargarImagen(pbfotoempleado);
        }

        private void pbfotoempleado_DoubleClick(object sender, EventArgs e)
        {
            MostrarFoto(pbfotoempleado, $"Foto de {txtNombres.Text} {txtApellidoPaterno.Text} {txtApellidoMaterno.Text}");
        }

        private void txttipo_TextChanged(object sender, EventArgs e)
        {
            tip.SetToolTip(txttipo, txttipo.Text);
        }
    }
}
