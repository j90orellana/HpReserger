using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISGEM.CRM
{
    public partial class frmAddUsuario : XtraForm
    {
        internal string _idUsuario = "";

        public frmAddUsuario()
        {
            InitializeComponent();
        }
        HpResergerNube.CRM_Usuario oUsuario = new HpResergerNube.CRM_Usuario();

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmAddUsuario_Load(object sender, EventArgs e)
        {
            CargarCombos();
            HpResergerNube.CRM_Usuario objClase = new HpResergerNube.CRM_Usuario();
            if (_idUsuario != "")
            {
                oUsuario = objClase.ReadUsuario(_idUsuario);

                // Asignar los valores del usuario a los controles
                ID_UsuarioTextEdit.EditValue = oUsuario.ID_Usuario;
                ID_Tipo_DocumentoTextEdit.EditValue = oUsuario.ID_Tipo_Documento;
                ID_Numero_DocTextEdit.EditValue = oUsuario.ID_Numero_Doc;
                ID_SexoTextEdit.EditValue = oUsuario.ID_Sexo;
                NombreTextEdit.EditValue = oUsuario.Nombre;
                Apellido1TextEdit.EditValue = oUsuario.Apellido1;
                Apellido2TextEdit.EditValue = oUsuario.Apellido2;
                Telefono1TextEdit.EditValue = oUsuario.Telefono1;
                Telefono2TextEdit.EditValue = oUsuario.Telefono2;
                email1TextEdit.EditValue = oUsuario.email1;
                email2TextEdit.EditValue = oUsuario.email2;
                DireccionTextEdit.EditValue = oUsuario.Direccion;
                InteriorTextEdit.EditValue = oUsuario.Interior;
                PisoTextEdit.EditValue = oUsuario.Piso;
                ID_Codigo_postalTextEdit.EditValue = oUsuario.ID_Codigo_postal;
                ID_TratamientoTextEdit.EditValue = oUsuario.ID_Tratamiento;
                OtrosTextEdit.EditValue = oUsuario.Otros;
                Usuario_CreacionTextEdit.EditValue = oUsuario.Usuario_Creacion;
                Fecha_CreacionDateEdit.EditValue = oUsuario.Fecha_Creacion;
                Usuario_ModificacionTextEdit.EditValue = oUsuario.Usuario_Modificacion;
                Fecha_ModificacionDateEdit.EditValue = oUsuario.Fecha_Modificacion;
                Usuario_EliminacionTextEdit.EditValue = oUsuario.Usuario_Eliminacion;
                Fecha_EliminacionDateEdit.EditValue = oUsuario.Fecha_Eliminacion;
                ID_PerfilesTextEdit.EditValue = oUsuario.ID_Perfiles;


            }
        }

        private void CargarCombos()
        {
            HpResergerNube.CRM_Tipo_DocumentoRepository objtipodocumento = new HpResergerNube.CRM_Tipo_DocumentoRepository();
            HpResergerNube.CRM_CodigoPostalRepository objpostal = new HpResergerNube.CRM_CodigoPostalRepository();
            HpResergerNube.CRM_Tratamiento oTratamiento = new HpResergerNube.CRM_Tratamiento();
            HpResergerNube.CRM_Usuario ousuario = new HpResergerNube.CRM_Usuario();
            HpResergerNube.CRM_Sexo oSexo = new HpResergerNube.CRM_Sexo();

            //TIPO DOCUMENTO
            DataTable tipoDocumentos = objtipodocumento.GetAllTipoDocumentos();
            ID_Tipo_DocumentoTextEdit.Properties.DataSource = tipoDocumentos;
            ID_Tipo_DocumentoTextEdit.Properties.ValueMember = "ID_Tipo_documento";
            ID_Tipo_DocumentoTextEdit.Properties.DisplayMember = "Detalle_Tipo_documento";
            ID_Tipo_DocumentoTextEdit.EditValue = tipoDocumentos.Rows.Count > 0 ? tipoDocumentos.Rows[0]["ID_Tipo_documento"] : null;

            ID_Tipo_DocumentoTextEdit.Properties.View.Columns.Clear();
            ID_Tipo_DocumentoTextEdit.Properties.View.Columns.AddVisible("ID_Tipo_documento", "Codigo");
            ID_Tipo_DocumentoTextEdit.Properties.View.Columns.AddVisible("Detalle_Tipo_documento", "Tipo Documento");
            ID_Tipo_DocumentoTextEdit.Properties.View.BestFitColumns();

            //TRatamiento
            DataTable ttratamiento = oTratamiento.GetAllTratamientos();
            ID_TratamientoTextEdit.Properties.DataSource = ttratamiento;
            ID_TratamientoTextEdit.Properties.ValueMember = "ID_Tratamiento";
            ID_TratamientoTextEdit.Properties.DisplayMember = "Detalle_tratamiento";
            ID_TratamientoTextEdit.EditValue = ttratamiento.Rows.Count > 0 ? ttratamiento.Rows[0]["ID_Tratamiento"] : null;

            ID_TratamientoTextEdit.Properties.View.Columns.Clear();
            ID_TratamientoTextEdit.Properties.View.Columns.AddVisible("ID_Tratamiento", "Codigo");
            ID_TratamientoTextEdit.Properties.View.Columns.AddVisible("Detalle_tratamiento", "Tratamiento");
            ID_TratamientoTextEdit.Properties.View.BestFitColumns();

            //SEXO
            DataTable Tsexo = oSexo.GetAllSexos();
            ID_SexoTextEdit.Properties.DataSource = Tsexo;
            ID_SexoTextEdit.Properties.ValueMember = "ID_Sexo";
            ID_SexoTextEdit.Properties.DisplayMember = "Detalle_FM";
            ID_SexoTextEdit.EditValue = Tsexo.Rows.Count > 0 ? Tsexo.Rows[0]["ID_Sexo"] : null;

            ID_SexoTextEdit.Properties.View.Columns.Clear();
            ID_SexoTextEdit.Properties.View.Columns.AddVisible("ID_Sexo", "Codigo");
            ID_SexoTextEdit.Properties.View.Columns.AddVisible("Detalle_FM", "Sexo");
            ID_SexoTextEdit.Properties.View.BestFitColumns();

            //CODIGO POSTAL
            DataTable codigosPostales = objpostal.GetAllCodigosPostales();
            ID_Codigo_postalTextEdit.Properties.DataSource = codigosPostales;
            ID_Codigo_postalTextEdit.Properties.DisplayMember = "Ubicacion";
            ID_Codigo_postalTextEdit.Properties.ValueMember = "ID_Codigo_postal";
            ID_Codigo_postalTextEdit.EditValue = codigosPostales.Rows.Count > 0 ? codigosPostales.Rows[0]["ID_Codigo_postal"] : null;

            ID_Codigo_postalTextEdit.Properties.View.Columns.Clear();
            ID_Codigo_postalTextEdit.Properties.View.Columns.AddVisible("Departamento", "Departamento");
            ID_Codigo_postalTextEdit.Properties.View.Columns.AddVisible("Provincia", "Provincia");
            ID_Codigo_postalTextEdit.Properties.View.Columns.AddVisible("Distrito", "Distrito");
            ID_Codigo_postalTextEdit.Properties.View.BestFitColumns();

            //Usuario
            DataTable tusuario = ousuario.GetAllUsuarios();
            Usuario_CreacionTextEdit.Properties.DataSource = tusuario;
            Usuario_CreacionTextEdit.Properties.ValueMember = "ID_Usuario";
            Usuario_CreacionTextEdit.Properties.DisplayMember = "Nombre_Completo";
            Usuario_CreacionTextEdit.EditValue = tusuario.Rows.Count > 0 ? tusuario.Rows[0]["ID_Usuario"] : null;

            Usuario_CreacionTextEdit.Properties.View.Columns.Clear();
            Usuario_CreacionTextEdit.Properties.View.Columns.AddVisible("ID_Numero_Doc", "DNI");
            Usuario_CreacionTextEdit.Properties.View.Columns.AddVisible("Nombre_Completo", "Nombre Completo");
            Usuario_CreacionTextEdit.Properties.View.BestFitColumns();

        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            oUsuario.ID_Usuario = ID_UsuarioTextEdit.EditValue?.ToString() ?? "";
            oUsuario.ID_Tipo_Documento = ID_Tipo_DocumentoTextEdit.EditValue?.ToString() ?? "";
            oUsuario.ID_Numero_Doc = Convert.ToDecimal(ID_Numero_DocTextEdit.EditValue ?? 0);
            oUsuario.ID_Sexo = ID_SexoTextEdit.EditValue?.ToString() ?? "";
            oUsuario.Nombre = NombreTextEdit.EditValue?.ToString() ?? "";
            oUsuario.Apellido1 = Apellido1TextEdit.EditValue?.ToString() ?? "";
            oUsuario.Apellido2 = Apellido2TextEdit.EditValue?.ToString() ?? "";
            oUsuario.Telefono1 = Convert.ToDecimal(Telefono1TextEdit.EditValue ?? 0);
            oUsuario.Telefono2 = Convert.ToDecimal(Telefono2TextEdit.EditValue ?? 0);
            oUsuario.email1 = email1TextEdit.EditValue?.ToString() ?? "";
            oUsuario.email2 = email2TextEdit.EditValue?.ToString() ?? "";
            oUsuario.Direccion = DireccionTextEdit.EditValue?.ToString() ?? "";
            oUsuario.Interior = InteriorTextEdit.EditValue?.ToString() ?? "";
            oUsuario.Piso = PisoTextEdit.EditValue?.ToString() ?? "";
            oUsuario.ID_Codigo_postal = Convert.ToDecimal(ID_Codigo_postalTextEdit.EditValue ?? 0);
            oUsuario.ID_Tratamiento = ID_TratamientoTextEdit.EditValue?.ToString() ?? "";
            oUsuario.Otros = OtrosTextEdit.EditValue?.ToString() ?? "";
            oUsuario.Usuario_Creacion = Usuario_CreacionTextEdit.EditValue?.ToString() ?? "";
            oUsuario.Fecha_Creacion = (DateTime)Fecha_CreacionDateEdit.EditValue;
            oUsuario.Usuario_Modificacion = Usuario_ModificacionTextEdit.EditValue?.ToString() ?? "";
            oUsuario.Fecha_Modificacion = Fecha_ModificacionDateEdit.EditValue as DateTime? ?? DateTime.MinValue;
            oUsuario.Usuario_Eliminacion = Usuario_EliminacionTextEdit.EditValue?.ToString() ?? "";
            oUsuario.Fecha_Eliminacion = Fecha_EliminacionDateEdit.EditValue as DateTime? ?? DateTime.MinValue;
            oUsuario.ID_Perfiles = ID_PerfilesTextEdit.EditValue?.ToString() ?? "";

            HpResergerNube.CRM_Usuario objClase = new HpResergerNube.CRM_Usuario();

            if (string.IsNullOrEmpty(_idUsuario))
            {
                oUsuario.Usuario_Creacion = "1001";
                oUsuario.Fecha_Creacion = DateTime.Now;
                oUsuario.Usuario_Modificacion = "1001";
                oUsuario.Fecha_Modificacion = DateTime.Now;

                int insertedId = objClase.InsertUsuario(oUsuario);
                if (insertedId != 0)
                {
                    XtraMessageBox.Show("El usuario se ha registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _idUsuario = insertedId.ToString();
                    ID_UsuarioTextEdit.EditValue = _idUsuario;
                }
                else
                {
                    XtraMessageBox.Show("Ocurrió un error al intentar registrar el usuario. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ID_UsuarioTextEdit.EditValue = "";
                    _idUsuario = "";
                }
            }
            else
            {
                oUsuario.Usuario_Modificacion = "1001";
                oUsuario.Fecha_Modificacion = DateTime.Now;
                //Update
                oUsuario.ID_Usuario = _idUsuario;
                if (objClase.UpdateUsuario(oUsuario))
                {
                    XtraMessageBox.Show("La actualización se realizó con éxito.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Hubo un error al intentar actualizar el contacto. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
