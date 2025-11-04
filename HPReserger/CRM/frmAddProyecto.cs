using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using HpResergerNube;
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

namespace SISGEM.CRM
{
    public partial class frmAddProyecto : Form
    {
        public frmAddProyecto()
        {
            InitializeComponent();
        }
        HpResergerNube.Proyecto oProyecto = new HpResergerNube.Proyecto();
        public string _idProyecto = "";

        public byte[] Foto { get; private set; }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void RecargarContacto()
        {
            // Crear instancia del repositorio de contactos
            HpResergerNube.CRM_ContactoRepository ocontacto = new HpResergerNube.CRM_ContactoRepository();

            // Obtener los contactos del cliente
            DataTable contactos = ocontacto.GetContactosPorCliente(ItemForID_cliente.EditValue.ToString());

            // Verificar si se encontraron contactos
            if (contactos.Rows.Count > 0)
            {
                // Configurar el control de edición de ID_Contacto
                ID_ContactoTextEdit.Properties.DataSource = contactos;
                ID_ContactoTextEdit.Properties.ValueMember = "ID_Contacto";
                ID_ContactoTextEdit.Properties.DisplayMember = "NombreCompleto";
                ID_ContactoTextEdit.EditValue = contactos.Rows[0]["ID_Contacto"];

                // Configurar las columnas visibles en la vista del control de edición de ID_Contacto
                ID_ContactoTextEdit.Properties.View.Columns.Clear();
                ID_ContactoTextEdit.Properties.View.Columns.AddVisible("ID_Contacto", "Código");
                ID_ContactoTextEdit.Properties.View.Columns.AddVisible("Telefono1", "Telefono");
                ID_ContactoTextEdit.Properties.View.Columns.AddVisible("NombreCompleto", "Nombre Completo");

                ID_ContactoTextEdit.Properties.View.Columns.AddVisible("Cargo", "Cargo");
                ID_ContactoTextEdit.Properties.View.Columns.AddVisible("email1", "Email");
                ID_ContactoTextEdit.Properties.View.BestFitColumns();
            }
            else
            {
                // Limpiar el control de edición de ID_Contacto si no se encontraron contactos
                ID_ContactoTextEdit.Properties.DataSource = null;
                ID_ContactoTextEdit.EditValue = null;
            }
        }

        private void CargarCombos()
        {
            Fecha_CreacionDateEdit.EditValue = DateTime.Now;
            Fecha_RecordatorioDateEdit.EditValue = HpResergerNube.DLConexion.ObtenerUltimoDiaDelMes(DateTime.Now);
            Fecha_CotizacionDateEdit.EditValue = DateTime.Now;
            Fecha_CierreDateEdit.EditValue = HpResergerNube.DLConexion.ObtenerUltimoDiaDelMes(DateTime.Now);

            HpResergerNube.CRM_Tipo_SeguimientoRepository objtiposeguimiento = new HpResergerNube.CRM_Tipo_SeguimientoRepository();
            HpResergerNube.CRM_CodigoPostalRepository objpostal = new HpResergerNube.CRM_CodigoPostalRepository();
            HpResergerNube.CRM_Tipo_ProyectoRepository objtipoproyecto = new HpResergerNube.CRM_Tipo_ProyectoRepository();
            HpResergerNube.CRM_PrioridadRepository objprioridad = new HpResergerNube.CRM_PrioridadRepository();
            HpResergerNube.CRM_EstadoRepository objestado = new HpResergerNube.CRM_EstadoRepository();
            HpResergerNube.CRM_Situacion objsituacion = new HpResergerNube.CRM_Situacion();
            HpResergerNube.CRM_Usuario ousuario = new HpResergerNube.CRM_Usuario();

            //TIPO SITUACION
            DataTable tSituacion = objsituacion.GetAllSituaciones();
            ID_SituacionTextEdit.Properties.DataSource = tSituacion;
            ID_SituacionTextEdit.Properties.ValueMember = "ID_Situacion";
            ID_SituacionTextEdit.Properties.DisplayMember = "Detalle_Situacion";
            ID_SituacionTextEdit.EditValue = tSituacion.Rows.Count > 0 ? tSituacion.Rows[0]["ID_Situacion"] : null;

            ID_SituacionTextEdit.Properties.View.Columns.Clear();
            ID_SituacionTextEdit.Properties.View.Columns.AddVisible("ID_Situacion", "Codigo");
            ID_SituacionTextEdit.Properties.View.Columns.AddVisible("Detalle_Situacion", "Situacion");
            ID_SituacionTextEdit.Properties.View.BestFitColumns();

            //TIPO DOCUMENTO
            DataTable ttipoproyecto = objtipoproyecto.GetAllTipoProyectos();
            ID_Tipo_proyectoTextEdit.Properties.DataSource = ttipoproyecto;
            ID_Tipo_proyectoTextEdit.Properties.ValueMember = "ID_Tipo_proyecto";
            ID_Tipo_proyectoTextEdit.Properties.DisplayMember = "Detalle_Tipo_proyecto";
            ID_Tipo_proyectoTextEdit.EditValue = ttipoproyecto.Rows.Count > 0 ? ttipoproyecto.Rows[0]["ID_Tipo_proyecto"] : null;

            ID_Tipo_proyectoTextEdit.Properties.View.Columns.Clear();
            ID_Tipo_proyectoTextEdit.Properties.View.Columns.AddVisible("ID_Tipo_proyecto", "Codigo");
            ID_Tipo_proyectoTextEdit.Properties.View.Columns.AddVisible("Detalle_Tipo_proyecto", "Tipo Proyecto");
            ID_Tipo_proyectoTextEdit.Properties.View.BestFitColumns();

            //TIPO SEGUIMIENTO
            DataTable ttiposeguimiento = objtiposeguimiento.GetAllTipoSeguimientos();
            ID_Tipo_SeguimientoTextEdit.Properties.DataSource = ttiposeguimiento;
            ID_Tipo_SeguimientoTextEdit.Properties.ValueMember = "ID_Tipo_seguimiento";
            ID_Tipo_SeguimientoTextEdit.Properties.DisplayMember = "Detalle_Tipo_seguimiento";
            ID_Tipo_SeguimientoTextEdit.EditValue = ttiposeguimiento.Rows.Count > 0 ? ttiposeguimiento.Rows[0]["ID_Tipo_seguimiento"] : null;

            ID_Tipo_SeguimientoTextEdit.Properties.View.Columns.Clear();
            ID_Tipo_SeguimientoTextEdit.Properties.View.Columns.AddVisible("ID_Tipo_seguimiento", "Codigo");
            ID_Tipo_SeguimientoTextEdit.Properties.View.Columns.AddVisible("Detalle_Tipo_seguimiento", "Tipo Seguimiento");
            ID_Tipo_SeguimientoTextEdit.Properties.View.BestFitColumns();


            //usuario   
            DataTable tusuario = ousuario.GetAllUsuarios();
            Usuario_CreacionTextEdit.Properties.DataSource = tusuario;
            Usuario_CreacionTextEdit.Properties.ValueMember = "ID_Usuario";
            Usuario_CreacionTextEdit.Properties.DisplayMember = "Nombre_Completo";
            Usuario_CreacionTextEdit.EditValue = tusuario.Rows.Count > 0 ? tusuario.Rows[0]["ID_Usuario"] : null;

            Usuario_CreacionTextEdit.Properties.View.Columns.Clear();
            Usuario_CreacionTextEdit.Properties.View.Columns.AddVisible("ID_Numero_Doc", "DNI");
            Usuario_CreacionTextEdit.Properties.View.Columns.AddVisible("Nombre_Completo", "Nombre Completo");
            Usuario_CreacionTextEdit.Properties.View.BestFitColumns();

            //CODIGO POSTAL
            DataTable codigosPostales = objpostal.GetAllCodigosPostales();
            ID_Codigo_postalTextEdit.Properties.DataSource = codigosPostales;
            ID_Codigo_postalTextEdit.Properties.DisplayMember = "Ubicacion";
            ID_Codigo_postalTextEdit.Properties.ValueMember = "ID_Codigo_postal";
            ID_Codigo_postalTextEdit.EditValue = codigosPostales.Rows.Count > 0 ? codigosPostales.Rows[0]["ID_Codigo_postal"] : null;

            ID_Codigo_postalTextEdit.Properties.View.Columns.Clear();
            ID_Codigo_postalTextEdit.Properties.View.Columns.AddVisible("ID_Codigo_postal", "Ubigeo");
            ID_Codigo_postalTextEdit.Properties.View.Columns.AddVisible("Departamento", "Departamento");
            ID_Codigo_postalTextEdit.Properties.View.Columns.AddVisible("Provincia", "Provincia");
            ID_Codigo_postalTextEdit.Properties.View.Columns.AddVisible("Distrito", "Distrito");
            ID_Codigo_postalTextEdit.Properties.View.BestFitColumns();

            //PRIORIDAD
            DataTable TPrioridad = objprioridad.GetAllPrioridades();
            ID_PrioridadTextEdit.Properties.DataSource = TPrioridad;
            ID_PrioridadTextEdit.Properties.DisplayMember = "Detalle_Prioridad";
            ID_PrioridadTextEdit.Properties.ValueMember = "ID_Prioridad";
            ID_PrioridadTextEdit.EditValue = TPrioridad.Rows.Count > 0 ? TPrioridad.Rows[0]["ID_Prioridad"] : null;

            ID_PrioridadTextEdit.Properties.View.Columns.Clear();
            ID_PrioridadTextEdit.Properties.View.Columns.AddVisible("ID_Prioridad", "Codigo");
            ID_PrioridadTextEdit.Properties.View.Columns.AddVisible("Detalle_Prioridad", "Prioridad");
            ID_PrioridadTextEdit.Properties.View.BestFitColumns();

            //estado
            DataTable testado = objestado.GetAllEstados();
            ID_EstadoTextEdit.Properties.DataSource = testado;
            ID_EstadoTextEdit.Properties.DisplayMember = "Detalle_Estado";
            ID_EstadoTextEdit.Properties.ValueMember = "ID_Estado";
            ID_EstadoTextEdit.EditValue = testado.Rows.Count > 0 ? testado.Rows[0]["ID_Estado"] : null;

            ID_EstadoTextEdit.Properties.View.Columns.Clear();
            ID_EstadoTextEdit.Properties.View.Columns.AddVisible("ID_Estado", "Codigo");
            ID_EstadoTextEdit.Properties.View.Columns.AddVisible("Detalle_Estado", "Estado");
            ID_EstadoTextEdit.Properties.View.BestFitColumns();

            RecargarCliente();

            RecargarContacto();

        }
        private void RecargarCliente()
        {
            HpResergerNube.CRM_ClienteRepository ocliente = new HpResergerNube.CRM_ClienteRepository();
            //cliente
            DataTable tcliente = ocliente.FilterClientesByDateRange(DateTime.MinValue, DateTime.MaxValue);
            ItemForID_cliente.Properties.DataSource = tcliente;
            ItemForID_cliente.Properties.DisplayMember = "nombrecompleto";
            ItemForID_cliente.Properties.ValueMember = "ID_Cliente";
            ItemForID_cliente.EditValue = tcliente.Rows.Count > 0 ? tcliente.Rows[0]["ID_Cliente"] : null;

            ItemForID_cliente.Properties.View.Columns.Clear();
            ItemForID_cliente.Properties.View.Columns.AddVisible("ID_Cliente", "ID");
            ItemForID_cliente.Properties.View.Columns.AddVisible("ID_Numero_Doc", "Numero Doc");
            ItemForID_cliente.Properties.View.Columns.AddVisible("nombrecompleto", "Nombre Completo");
            ItemForID_cliente.Properties.View.BestFitColumns();

        }

        private void frmAddProyecto_Load(object sender, EventArgs e)
        {
            CargarCombos();
            ImagenPictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            HpResergerNube.CRM_ProyectoRepository objproyecto = new HpResergerNube.CRM_ProyectoRepository();

            Usuario_CreacionTextEdit.EditValue = HPReserger.frmLogin.CodigoUsuario;

            if (_idProyecto != "")
            {
                ID_ProyectoTextEdit.EditValue = _idProyecto;
                oProyecto = objproyecto.ReadProyecto(Convert.ToInt32(_idProyecto));

                // Asigna los valores del proyecto a los controles en tu formulario
                ID_ProyectoTextEdit.EditValue = oProyecto.ID_Proyecto;
                Nombre_ProyectoTextEdit.EditValue = oProyecto.Nombre_Proyecto;
                ReferenciaTextEdit.EditValue = oProyecto.Referencia;
                ID_Codigo_postalTextEdit.EditValue = oProyecto.ID_Codigo_postal;
                DireccionTextEdit.EditValue = oProyecto.Direccion;
                ID_Tipo_proyectoTextEdit.EditValue = oProyecto.ID_Tipo_proyecto;
                ID_PrioridadTextEdit.EditValue = oProyecto.ID_Prioridad;
                ID_EstadoTextEdit.EditValue = oProyecto.ID_Estado;
                ID_SituacionTextEdit.EditValue = oProyecto.ID_Situacion;
                RequerimientoTextEdit.EditValue = oProyecto.Requerimiento;
                Usuario_CreacionTextEdit.EditValue = oProyecto.ID_Usuario;
                Fecha_CreacionDateEdit.EditValue = oProyecto.Fecha_Creacion;
                Fecha_RecordatorioDateEdit.EditValue = oProyecto.Fecha_Recordatorio;
                Fecha_CotizacionDateEdit.EditValue = oProyecto.Fecha_Cotizacion;
                Fecha_CierreDateEdit.EditValue = oProyecto.Fecha_Cierre;
                ObservacionesTextEdit.EditValue = oProyecto.Observaciones;
                ID_Tipo_SeguimientoTextEdit.EditValue = oProyecto.ID_Tipo_Seguimiento;
                ID_UsuarioTextEdit.EditValue = oProyecto.ID_Usuario;
                ArchivoTextEdit.EditValue = oProyecto.Archivo;
                FotosTextEdit.EditValue = oProyecto.Fotos;
                ImagenPictureBox.Image = ByteArrayToImage(oProyecto.Imagen);
                Foto = oProyecto.Imagen;
                ItemForID_cliente.EditValue = oProyecto.idcliente;
                ID_ContactoTextEdit.EditValue = oProyecto.ID_Contacto;

                ValorSolesTextEdit.EditValue = oProyecto.ValorSoles;
                ValorDolaresTextEdit.EditValue = oProyecto.ValorDolares;

                ListarArchivos();

            }
        }
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            try
            {

                if (byteArrayIn == null || byteArrayIn.Length == 0)
                {
                    return null;
                }

                using (MemoryStream ms = new MemoryStream(byteArrayIn))
                {
                    return Image.FromStream(ms);
                }
            }
            catch
            {
                return null;
            }
        }

        public bool ValidarCamposNoNulos()
        {

            if (Nombre_ProyectoTextEdit.EditValue == null || string.IsNullOrWhiteSpace(Nombre_ProyectoTextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el Nombre del Proyecto.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ReferenciaTextEdit.EditValue == null || string.IsNullOrWhiteSpace(ReferenciaTextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese la Referencia.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ID_Codigo_postalTextEdit.EditValue == null || string.IsNullOrWhiteSpace(ID_Codigo_postalTextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el ID del Código Postal.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (DireccionTextEdit.EditValue == null || string.IsNullOrWhiteSpace(DireccionTextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese la Dirección.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ID_Tipo_proyectoTextEdit.EditValue == null || string.IsNullOrWhiteSpace(ID_Tipo_proyectoTextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el ID del Tipo de Proyecto.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ID_PrioridadTextEdit.EditValue == null || string.IsNullOrWhiteSpace(ID_PrioridadTextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el ID de la Prioridad.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ID_EstadoTextEdit.EditValue == null || string.IsNullOrWhiteSpace(ID_EstadoTextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el ID del Estado.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ID_SituacionTextEdit.EditValue == null || string.IsNullOrWhiteSpace(ID_SituacionTextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el ID de la Situación.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (RequerimientoTextEdit.EditValue == null || string.IsNullOrWhiteSpace(RequerimientoTextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el Requerimiento.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Usuario_CreacionTextEdit.EditValue == null || string.IsNullOrWhiteSpace(Usuario_CreacionTextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el Usuario de Creación.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Fecha_CreacionDateEdit.EditValue == null || string.IsNullOrWhiteSpace(Fecha_CreacionDateEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese la Fecha de Creación.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Fecha_RecordatorioDateEdit.EditValue == null || string.IsNullOrWhiteSpace(Fecha_RecordatorioDateEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese la Fecha de Recordatorio.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Fecha_CotizacionDateEdit.EditValue == null || string.IsNullOrWhiteSpace(Fecha_CotizacionDateEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese la Fecha de Cotización.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Fecha_CierreDateEdit.EditValue == null || string.IsNullOrWhiteSpace(Fecha_CierreDateEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese la Fecha de Cierre.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ID_Tipo_SeguimientoTextEdit.EditValue == null || string.IsNullOrWhiteSpace(ID_Tipo_SeguimientoTextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el ID del Tipo de Seguimiento.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (ID_ContactoTextEdit.EditValue == null || string.IsNullOrWhiteSpace(ID_ContactoTextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el ID del Contacto.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ItemForID_cliente.EditValue == null || string.IsNullOrWhiteSpace(ItemForID_cliente.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el ID del cliente.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // Todos los campos requeridos tienen valores
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ValidarCamposNoNulos()) return;

            HpResergerNube.Proyecto oProyecto = new HpResergerNube.Proyecto();

            oProyecto.ID_Proyecto = Convert.ToInt32(ID_ProyectoTextEdit.EditValue ?? 0);
            oProyecto.Nombre_Proyecto = Nombre_ProyectoTextEdit.EditValue?.ToString() ?? string.Empty;
            oProyecto.Referencia = ReferenciaTextEdit.EditValue?.ToString() ?? string.Empty;
            oProyecto.ID_Codigo_postal = Convert.ToInt32(ID_Codigo_postalTextEdit.EditValue ?? 0);
            oProyecto.Direccion = DireccionTextEdit.EditValue?.ToString() ?? string.Empty;
            oProyecto.ID_Tipo_proyecto = ID_Tipo_proyectoTextEdit.EditValue?.ToString() ?? string.Empty;
            oProyecto.ID_Prioridad = ID_PrioridadTextEdit.EditValue?.ToString() ?? string.Empty;
            oProyecto.ID_Estado = ID_EstadoTextEdit.EditValue?.ToString() ?? string.Empty;
            oProyecto.ID_Situacion = ID_SituacionTextEdit.EditValue?.ToString() ?? string.Empty;
            oProyecto.Requerimiento = RequerimientoTextEdit.EditValue?.ToString() ?? string.Empty;
            oProyecto.Usuario_Creacion = Usuario_CreacionTextEdit.EditValue?.ToString() ?? string.Empty;
            oProyecto.Fecha_Creacion = Convert.ToDateTime(Fecha_CreacionDateEdit.EditValue ?? DateTime.MinValue);
            oProyecto.Fecha_Recordatorio = Convert.ToDateTime(Fecha_RecordatorioDateEdit.EditValue ?? DateTime.MinValue);
            oProyecto.Fecha_Cotizacion = Convert.ToDateTime(Fecha_CotizacionDateEdit.EditValue ?? DateTime.MinValue);
            oProyecto.Fecha_Cierre = Convert.ToDateTime(Fecha_CierreDateEdit.EditValue ?? DateTime.MinValue);
            oProyecto.Observaciones = ObservacionesTextEdit.EditValue?.ToString() ?? string.Empty;
            oProyecto.ID_Tipo_Seguimiento = ID_Tipo_SeguimientoTextEdit.EditValue?.ToString() ?? string.Empty;
            oProyecto.ID_Usuario = Usuario_CreacionTextEdit.EditValue?.ToString() ?? string.Empty;
            oProyecto.ID_Contacto = ID_ContactoTextEdit.EditValue?.ToString() ?? string.Empty;
            oProyecto.Archivo = ArchivoTextEdit.EditValue?.ToString() ?? string.Empty;
            oProyecto.Fotos = FotosTextEdit.EditValue?.ToString() ?? string.Empty;
            oProyecto.Imagen = ImageToByteArray(ImagenPictureBox.Image);
            oProyecto.idcliente = ItemForID_cliente.EditValue.ToString();

            oProyecto.ValorSoles = Convert.ToDecimal(ValorSolesTextEdit.EditValue ?? 0);
            oProyecto.ValorDolares = Convert.ToDecimal(ValorDolaresTextEdit.EditValue ?? 0);

            HpResergerNube.CRM_ProyectoRepository objproyecto = new HpResergerNube.CRM_ProyectoRepository();

            if (string.IsNullOrEmpty(_idProyecto))
            {
                //Insertar
                int insertedId = objproyecto.InsertProyecto(oProyecto);
                if (insertedId != 0)
                {
                    XtraMessageBox.Show("El proyecto se ha registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _idProyecto = insertedId.ToString();
                    ID_ProyectoTextEdit.EditValue = insertedId;
                }
                else
                {
                    XtraMessageBox.Show("Ocurrió un error al intentar registrar el proyecto. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _idProyecto = "";
                }
            }
            else
            {
                //Update
                oProyecto.ID_Proyecto = Convert.ToInt32(_idProyecto);
                if (objproyecto.UpdateProyecto(oProyecto))
                {
                    XtraMessageBox.Show("La actualización se realizó con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Hubo un error al intentar actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        public byte[] ImageToByteArray(Image image)
        {
            try
            {
                if (image == null)
                {
                    return null;
                }

                using (MemoryStream ms = new MemoryStream())
                {
                    // Guardar la imagen en formato JPEG para evitar excepciones al guardar en otros formatos
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
            catch
            {
                return Foto;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string data = ID_ContactoTextEdit.EditValue?.ToString() ?? "";

            CRM.frmAddContacto frm = new CRM.frmAddContacto();
            frm.ShowDialog();
            RecargarContacto();
            ID_ContactoTextEdit.EditValue = data;

        }

        private void ImagenPictureBox_DoubleClick(object sender, EventArgs e)
        {
            // Crear un nuevo formulario para mostrar la foto en un tamaño más grande
            Form verFotoForm = new Form();
            verFotoForm.Text = "Ver Foto";
            verFotoForm.Size = new Size(400, 400);
            verFotoForm.Icon = this.Icon;
            verFotoForm.BackColor = Color.White;
            verFotoForm.StartPosition = FormStartPosition.CenterScreen;

            // Crear un control PictureBox en el nuevo formulario para mostrar la foto
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = ImagenPictureBox.Image;

            // Agregar el PictureBox al formulario
            verFotoForm.Controls.Add(pictureBox);

            // Crear un botón para cargar una nueva foto
            Button cargarFotoButton = new Button();
            cargarFotoButton.Text = "Cargar Foto";
            cargarFotoButton.Location = new Point(10, 10);
            cargarFotoButton.Click += (s, args) =>
            {
                // Aquí puedes agregar la lógica para cargar una nueva foto
                // Puedes utilizar un cuadro de diálogo para seleccionar la nueva foto
                // Por ejemplo:
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Asignar la nueva imagen al PictureBox
                    pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                }
            };

            // Agregar el botón al formulario
            verFotoForm.Controls.Add(cargarFotoButton);

            // Mostrar el formulario para ver la foto
            verFotoForm.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string data = ItemForID_cliente.EditValue?.ToString() ?? "";

            CRM.FrmAddCliente frm = new CRM.FrmAddCliente();
            frm.ShowDialog();
            RecargarCliente();
            ItemForID_cliente.EditValue = data;
        }

        private void ItemForID_cliente_EditValueChanged(object sender, EventArgs e)
        {
            RecargarContacto();
        }

        private void ID_ContactoTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
        string remoteFileName = "tucson.pdf";
        //string localFilePath = "";
        string directoryName = HPReserger.frmLogin.Basedatos;

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (_idProyecto != "")
            {
                Cursor = Cursors.WaitCursor;
                var ftpcliente1 = new FtpClient();
                ftpcliente1.CreateDirectory(directoryName);

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Todos los archivos|*.*"; // Permitir todos los tipos de archivos
                openFileDialog.Title = "Selecciona un archivo para subir";
                var ftpClient = new FtpClient();
                if (openFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    string localFilePath = openFileDialog.FileName;
                    remoteFileName = directoryName + "/" + Convert.ToInt32(_idProyecto) + "." + openFileDialog.SafeFileName;

                    ftpClient.UploadFile(localFilePath, remoteFileName);

                    HpResergerNube.CRM_Documentos oDocumentos = new CRM_Documentos();
                    oDocumentos.Insert(Convert.ToInt32(_idProyecto), this.Text, remoteFileName, openFileDialog.SafeFileName, DateTime.Now);

                    XtraMessageBox.Show("El archivo se ha subido correctamente.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("No se seleccionó ningún archivo o la operación fue cancelada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                XtraMessageBox.Show("Primero debe guardar el proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ListarArchivos();
        }

        private void ListarArchivos()
        {
            txtRuta.EditValue = HPReserger.frmLogin.RutaDescarga;
            if (_idProyecto != "")
            {
                HpResergerNube.CRM_Documentos odocumentos = new CRM_Documentos();
                DataTable Tdata = odocumentos.ListByFkIdAndVentana(Convert.ToInt32(_idProyecto), this.Text);
                gridControl1.DataSource = Tdata;
            }
        }
        string Nombre_Archivo = "";
        string Nombre_Completo_ftp = "";

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nombre_Completo_ftp))
            {
                XtraMessageBox.Show("El nombre del archivo remoto está vacío. Por favor, seleccione un archivo antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtRuta.EditValue?.ToString()))
            {
                XtraMessageBox.Show("Debe seleccionar la carpeta de descarga.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedFolderPath = txtRuta.EditValue.ToString();

            var ftpClient = new FtpClient();
            try
            {
                ftpClient.DownloadFile(Nombre_Completo_ftp, Path.Combine(selectedFolderPath, Nombre_Archivo));
                XtraMessageBox.Show("Archivo descargado exitosamente en la carpeta seleccionada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ocurrió un error al descargar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnfolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtRuta.EditValue = folderBrowserDialog.SelectedPath;
                HPReserger.frmLogin.RutaDescarga = txtRuta.EditValue.ToString();
            }
            else if (result == DialogResult.Cancel)
            {
                XtraMessageBox.Show("Operación cancelada por el usuario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridView16_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView16_Click(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null && view.FocusedRowHandle >= 0 && view.FocusedColumn != null)
            {
                object xNombre_Archivox = view.GetRowCellValue(view.FocusedRowHandle, xNombre_Archivo.FieldName);
                object xNombre_Completo_ftpx = view.GetRowCellValue(view.FocusedRowHandle, xNombre_Completo_ftp.FieldName);

                Nombre_Archivo = xNombre_Archivox.ToString();
                Nombre_Completo_ftp = xNombre_Completo_ftpx.ToString();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(_idProyecto))
            {
                DialogResult result = XtraMessageBox.Show("¿Seguro desea eliminar el proyecto de forma permanente?", "Confirmación de Eliminación", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    HpResergerNube.CRM_ProyectoRepository oproyect = new CRM_ProyectoRepository();
                    oproyect.DeleteProyecto(Convert.ToInt32(_idProyecto));
                    XtraMessageBox.Show("El proyecto se eliminó correctamente. Se cerrará la ventana de proyecto.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Se canceló la operación de eliminación.", "Operación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                XtraMessageBox.Show("Debe seleccionar un proyecto.", "Seleccione un proyecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que tenemos una fila seleccionada válida
                if (gridView16.FocusedRowHandle < 0 || !gridView16.IsDataRow(gridView16.FocusedRowHandle))
                {
                    XtraMessageBox.Show("Por favor, seleccione un archivo válido para eliminar.",
                                      "Selección Inválida",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    return;
                }

                // Obtener valores de la fila
                string nombreArchivo = gridView16.GetRowCellValue(gridView16.FocusedRowHandle, "Nombre_Archivo")?.ToString();
                string idDocumento = gridView16.GetRowCellValue(gridView16.FocusedRowHandle, "ID_Documento")?.ToString();

                // Validar datos obtenidos
                if (string.IsNullOrEmpty(nombreArchivo) || string.IsNullOrEmpty(idDocumento))
                {
                    XtraMessageBox.Show("No se pudieron obtener los datos del archivo seleccionado.",
                                      "Error de Datos",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                    return;
                }

                // Confirmación de eliminación con mensaje más descriptivo
                var confirmacion = XtraMessageBox.Show(
                    $"¿Está seguro que desea eliminar el archivo:\n\n" +
                    $"• Nombre: {nombreArchivo}\n" +
                    $"Esta acción no se puede deshacer.",
                    "Confirmar Eliminación de Archivo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2); // Por defecto selecciona "No" para prevenir eliminaciones accidentales

                if (confirmacion == DialogResult.Yes)
                {
                    // Mostrar indicador de progreso
                    Cursor.Current = Cursors.WaitCursor;

                    // Realizar eliminación lógica
                    HpResergerNube.CRM_Documentos odocumentos = new CRM_Documentos();
                    bool eliminado = odocumentos.EliminarLogica(int.Parse(idDocumento), $"{this.Text}-Eliminado");

                    // Restaurar cursor
                    Cursor.Current = Cursors.Default;

                    if (eliminado)
                    {
                        //XtraMessageBox.Show($"El archivo '{nombreArchivo}' ha sido eliminado correctamente.",
                        //                  "Eliminación Exitosa",
                        //                  MessageBoxButtons.OK,
                        //                  MessageBoxIcon.Information);

                        // Refrescar la lista de archivos
                        ListarArchivos();
                    }
                    else
                    {
                        XtraMessageBox.Show("No se pudo eliminar el archivo. Por favor, intente nuevamente.",
                                          "Error al Eliminar",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException)
            {
                XtraMessageBox.Show("El ID del documento no tiene un formato válido.",
                                  "Error de Formato",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Ocurrió un error inesperado:\n\n{ex.Message}",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
            }
        }
    }
}
