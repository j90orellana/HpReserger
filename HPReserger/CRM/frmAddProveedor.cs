using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using HpResergerNube;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace SISGEM.CRM
{
    public partial class frmAddProveedor : XtraForm
    {
        internal string _idproveedor;
        private CRM_ProveedorRepository.CRM_Proveedor oObjetoClase;

        public frmAddProveedor()
        {
            this._idproveedor = "";
            this.oObjetoClase = new CRM_ProveedorRepository.CRM_Proveedor();
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string data = ID_ContactoTextEdit.EditValue?.ToString() ?? "";

            CRM.frmAddContacto frm = new CRM.frmAddContacto();
            frm.ShowDialog();
            RecargarContacto();
            ID_ContactoTextEdit.EditValue = data;
        }

        private void frmAddProveedor_Load(object sender, EventArgs e)
        {
            this.CargarCombos();
            CRM_ProveedorRepository proveedorRepository = new CRM_ProveedorRepository();
            if (!(this._idproveedor != ""))
                return;
            this.oObjetoClase = proveedorRepository.GetById(this._idproveedor.ToString());
            this.ID_ProveedorTextEdit.EditValue = (object)this.oObjetoClase.ID_Proveedor;
            this.ID_Tipo_personaTextEdit.EditValue = (object)this.oObjetoClase.ID_Tipo_persona;
            this.Razon_SocialTextEdit.EditValue = (object)this.oObjetoClase.Razon_Social;
            this.NombreTextEdit.EditValue = (object)this.oObjetoClase.Nombre;
            this.Apellido1TextEdit.EditValue = (object)this.oObjetoClase.Apellido1;
            this.Apellido2TextEdit.EditValue = (object)this.oObjetoClase.Apellido2;
            this.ID_Tipo_DocumentoTextEdit.EditValue = (object)this.oObjetoClase.ID_Tipo_Documento;
            this.ID_Numero_DocTextEdit.EditValue = (object)this.oObjetoClase.ID_Numero_Doc;
            this.DireccionTextEdit.EditValue = (object)this.oObjetoClase.Direccion;
            this.InteriorTextEdit.EditValue = (object)this.oObjetoClase.Interior;
            this.PisoTextEdit.EditValue = (object)this.oObjetoClase.Piso;
            this.ID_Codigo_postalTextEdit.EditValue = (object)this.oObjetoClase.ID_Codigo_postal;
            this.Telefono1TextEdit.EditValue = (object)this.oObjetoClase.Telefono1;
            this.Telefono2TextEdit.EditValue = (object)this.oObjetoClase.Telefono2;
            this.email1TextEdit.EditValue = (object)this.oObjetoClase.email1;
            this.email2TextEdit.EditValue = (object)this.oObjetoClase.email2;
            this.webTextEdit.EditValue = (object)this.oObjetoClase.web;
            this.ID_ContactoTextEdit.EditValue = (object)this.oObjetoClase.ID_Contacto;
            this.Usuario_CreacionTextEdit.EditValue = (object)this.oObjetoClase.Usuario_Creacion;
            this.Fecha_CreacionDateEdit.EditValue = (object)this.oObjetoClase.Fecha_Creacion;
            this.Usuario_ModificacionTextEdit.EditValue = (object)this.oObjetoClase.Usuario_Modificacion;
            this.Fecha_ModificacionDateEdit.EditValue = (object)this.oObjetoClase.Fecha_Modificacion;
            this.Usuario_EliminacionTextEdit.EditValue = (object)this.oObjetoClase.Usuario_Eliminacion;
            this.Fecha_EliminacionDateEdit.EditValue = (object)this.oObjetoClase.Fecha_Eliminacion;
        }
        private void CargarCombos()
        {
            CRM_Tipo_PersonaRepository personaRepository = new CRM_Tipo_PersonaRepository();
            CRM_Tipo_RelacionRepository relacionRepository = new CRM_Tipo_RelacionRepository();
            CRM_Tipo_DocumentoRepository documentoRepository = new CRM_Tipo_DocumentoRepository();
            CRM_ContactoRepository contactoRepository = new CRM_ContactoRepository();
            CRM_CodigoPostalRepository postalRepository = new CRM_CodigoPostalRepository();
            CRM_Usuario crmUsuario = new CRM_Usuario();
            DataTable allTipoPersonas = personaRepository.GetAllTipoPersonas();
            this.ID_Tipo_personaTextEdit.Properties.DataSource = (object)allTipoPersonas;
            this.ID_Tipo_personaTextEdit.Properties.ValueMember = "ID_Tipo_persona";
            this.ID_Tipo_personaTextEdit.Properties.DisplayMember = "Detalle_Tipo_Persona";
            this.ID_Tipo_personaTextEdit.EditValue = allTipoPersonas.Rows.Count > 0 ? allTipoPersonas.Rows[0]["ID_Tipo_persona"] : (object)null;
            this.ID_Tipo_personaTextEdit.Properties.View.Columns.Clear();
            this.ID_Tipo_personaTextEdit.Properties.View.Columns.AddVisible("ID_Tipo_persona", "Codigo");
            this.ID_Tipo_personaTextEdit.Properties.View.Columns.AddVisible("Detalle_Tipo_Persona", "Tipo Persona");
            this.ID_Tipo_personaTextEdit.Properties.View.BestFitColumns();
            DataTable allTipoDocumentos = documentoRepository.GetAllTipoDocumentos();
            this.ID_Tipo_DocumentoTextEdit.Properties.DataSource = (object)allTipoDocumentos;
            this.ID_Tipo_DocumentoTextEdit.Properties.ValueMember = "ID_Tipo_documento";
            this.ID_Tipo_DocumentoTextEdit.Properties.DisplayMember = "Detalle_Tipo_documento";
            this.ID_Tipo_DocumentoTextEdit.EditValue = allTipoDocumentos.Rows.Count > 0 ? allTipoDocumentos.Rows[0]["ID_Tipo_documento"] : (object)null;
            this.ID_Tipo_DocumentoTextEdit.Properties.View.Columns.Clear();
            this.ID_Tipo_DocumentoTextEdit.Properties.View.Columns.AddVisible("ID_Tipo_documento", "Codigo");
            this.ID_Tipo_DocumentoTextEdit.Properties.View.Columns.AddVisible("Detalle_Tipo_documento", "Tipo Documento");
            this.ID_Tipo_DocumentoTextEdit.Properties.View.BestFitColumns();
            DataTable allContactos = contactoRepository.GetAllContactos();
            this.ID_ContactoTextEdit.Properties.DataSource = (object)allContactos;
            this.ID_ContactoTextEdit.Properties.ValueMember = "ID_Contacto";
            this.ID_ContactoTextEdit.Properties.DisplayMember = "NombreCompleto";
            this.ID_ContactoTextEdit.EditValue = allContactos.Rows.Count > 0 ? allContactos.Rows[0]["ID_Contacto"] : (object)null;
            this.ID_ContactoTextEdit.Properties.View.Columns.Clear();
            this.ID_ContactoTextEdit.Properties.View.Columns.AddVisible("ID_Contacto", "Codigo");
            this.ID_ContactoTextEdit.Properties.View.Columns.AddVisible("NombreCompleto", "Nombre Completo");
            this.ID_ContactoTextEdit.Properties.View.BestFitColumns();
            DataTable allCodigosPostales = postalRepository.GetAllCodigosPostales();
            this.ID_Codigo_postalTextEdit.Properties.DataSource = (object)allCodigosPostales;
            this.ID_Codigo_postalTextEdit.Properties.DisplayMember = "Ubicacion";
            this.ID_Codigo_postalTextEdit.Properties.ValueMember = "ID_Codigo_postal";
            this.ID_Codigo_postalTextEdit.EditValue = allCodigosPostales.Rows.Count > 0 ? allCodigosPostales.Rows[0]["ID_Codigo_postal"] : (object)null;
            this.ID_Codigo_postalTextEdit.Properties.View.Columns.Clear();
            this.ID_Codigo_postalTextEdit.Properties.View.Columns.AddVisible("Departamento", "Departamento");
            this.ID_Codigo_postalTextEdit.Properties.View.Columns.AddVisible("Provincia", "Provincia");
            this.ID_Codigo_postalTextEdit.Properties.View.Columns.AddVisible("Distrito", "Distrito");
            this.ID_Codigo_postalTextEdit.Properties.View.BestFitColumns();
            DataTable allUsuarios = crmUsuario.GetAllUsuarios();
            this.Usuario_CreacionTextEdit.Properties.DataSource = (object)allUsuarios;
            this.Usuario_CreacionTextEdit.Properties.ValueMember = "ID_Usuario";
            this.Usuario_CreacionTextEdit.Properties.DisplayMember = "Nombre_Completo";
            this.Usuario_CreacionTextEdit.EditValue = allUsuarios.Rows.Count > 0 ? allUsuarios.Rows[0]["ID_Usuario"] : (object)null;
            this.Usuario_CreacionTextEdit.Properties.View.Columns.Clear();
            this.Usuario_CreacionTextEdit.Properties.View.Columns.AddVisible("ID_Numero_Doc", "DNI");
            this.Usuario_CreacionTextEdit.Properties.View.Columns.AddVisible("Nombre_Completo", "Nombre Completo");
            this.Usuario_CreacionTextEdit.Properties.View.BestFitColumns();
        }

        private void ID_Tipo_personaTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.ID_Tipo_personaTextEdit.EditValue == null)
                return;
            this.ItemForRazon_Social.Visibility = LayoutVisibility.Always;
            this.ItemForNombre.Visibility = LayoutVisibility.Always;
            this.ItemForApellido1.Visibility = LayoutVisibility.Always;
            this.ItemForApellido2.Visibility = LayoutVisibility.Always;
            if (this.ID_Tipo_personaTextEdit.EditValue.ToString() == "N")
                this.ItemForRazon_Social.Visibility = LayoutVisibility.Never;
            else if (this.ID_Tipo_personaTextEdit.EditValue.ToString() == "J")
            {
                this.ItemForNombre.Visibility = LayoutVisibility.Never;
                this.ItemForApellido1.Visibility = LayoutVisibility.Never;
                this.ItemForApellido2.Visibility = LayoutVisibility.Never;
            }
        }
        private void LimpiarControles()
        {
            foreach (Control control in (ArrangedElementCollection)this.Controls)
            {
                if (control is TextEdit)
                    ((BaseEdit)control).EditValue = (object)"";
                else if (control is DateEdit)
                    ((BaseEdit)control).EditValue = (object)DateTime.Now;
            }
        }

        private void RecargarContacto()
        {
            DataTable allContactos = new CRM_ContactoRepository().GetAllContactos();
            this.ID_ContactoTextEdit.Properties.DataSource = (object)allContactos;
            this.ID_ContactoTextEdit.Properties.ValueMember = "ID_Contacto";
            this.ID_ContactoTextEdit.Properties.DisplayMember = "NombreCompleto";
            this.ID_ContactoTextEdit.EditValue = allContactos.Rows.Count > 0 ? allContactos.Rows[0]["ID_Contacto"] : (object)null;
            this.ID_ContactoTextEdit.Properties.View.Columns.Clear();
            this.ID_ContactoTextEdit.Properties.View.Columns.AddVisible("ID_Contacto", "Codigo");
            this.ID_ContactoTextEdit.Properties.View.Columns.AddVisible("NombreCompleto", "Nombre Completo");
            this.ID_ContactoTextEdit.Properties.View.BestFitColumns();
        }
        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.oObjetoClase.Usuario_Eliminacion == null)
                this.oObjetoClase.Usuario_Eliminacion = "";
            if (!this.oObjetoClase.Fecha_Eliminacion.HasValue)
                this.oObjetoClase.Fecha_Eliminacion = new DateTime?(DateTime.MinValue);
            CRM_ProveedorRepository proveedorRepository = new CRM_ProveedorRepository();
            if (this._idproveedor == "")
            {
                this.oObjetoClase.ID_Proveedor = "P24-" + this.ID_Numero_DocTextEdit.EditValue.ToString().PadLeft(11, '0');
                this.oObjetoClase.Apellido1 = this.Apellido1TextEdit.EditValue?.ToString() ?? "";
                this.oObjetoClase.Apellido2 = this.Apellido2TextEdit.EditValue?.ToString() ?? "";
                this.oObjetoClase.Nombre = this.NombreTextEdit.EditValue?.ToString() ?? "";
                this.oObjetoClase.ID_Tipo_persona = this.ID_Tipo_personaTextEdit.EditValue?.ToString() ?? "";
                this.oObjetoClase.Razon_Social = this.Razon_SocialTextEdit.EditValue?.ToString() ?? "";
                this.oObjetoClase.ID_Tipo_Documento = this.ID_Tipo_DocumentoTextEdit.EditValue.ToString();
                this.oObjetoClase.ID_Numero_Doc = Convert.ToDecimal(this.ID_Numero_DocTextEdit.EditValue);
                this.oObjetoClase.Direccion = this.DireccionTextEdit.EditValue.ToString();
                this.oObjetoClase.Interior = this.InteriorTextEdit.EditValue.ToString();
                this.oObjetoClase.Piso = this.PisoTextEdit.EditValue.ToString();
                this.oObjetoClase.ID_Codigo_postal = string.IsNullOrEmpty(this.ID_Codigo_postalTextEdit.EditValue?.ToString()) ? 0M : Convert.ToDecimal(this.ID_Codigo_postalTextEdit.EditValue);
                this.oObjetoClase.Telefono1 = string.IsNullOrEmpty(this.Telefono1TextEdit.EditValue?.ToString()) ? 0M : Convert.ToDecimal(this.Telefono1TextEdit.EditValue);
                this.oObjetoClase.Telefono2 = new Decimal?(string.IsNullOrEmpty(this.Telefono2TextEdit.EditValue?.ToString()) ? 0M : Convert.ToDecimal(this.Telefono2TextEdit.EditValue));
                this.oObjetoClase.email1 = string.IsNullOrEmpty(this.email1TextEdit.EditValue?.ToString()) ? "" : this.email1TextEdit.EditValue.ToString();
                this.oObjetoClase.email2 = string.IsNullOrEmpty(this.email2TextEdit.EditValue?.ToString()) ? "" : this.email2TextEdit.EditValue.ToString();
                this.oObjetoClase.web = string.IsNullOrEmpty(this.webTextEdit.EditValue?.ToString()) ? "" : this.webTextEdit.EditValue.ToString();
                this.oObjetoClase.ID_Contacto = string.IsNullOrEmpty(this.ID_ContactoTextEdit.EditValue?.ToString()) ? "" : this.ID_ContactoTextEdit.EditValue.ToString();
                this.oObjetoClase.Fecha_Modificacion = new DateTime?(DateTime.Now);
                this.oObjetoClase.Usuario_Modificacion = "1001";
                this.oObjetoClase.Fecha_Creacion = DateTime.Now;
                this.oObjetoClase.Usuario_Creacion = "1001";
                CRM_ClienteRepository clienteRepository = new CRM_ClienteRepository();
                string str = proveedorRepository.Insert(this.oObjetoClase);
                if (!string.IsNullOrEmpty(str))
                {
                    int num = (int)XtraMessageBox.Show("El registro del proveedor se ha completado exitosamente. ID insertado: " + str, "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this._idproveedor = "";
                    this.ID_ProveedorTextEdit.EditValue = (object)"";
                    this.LimpiarControles();
                }
                else
                {
                    int num = (int)XtraMessageBox.Show("Ocurrió un error al intentar registrar el proveedor. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    this.ID_ProveedorTextEdit.EditValue = (object)"";
                }
            }
            else
            {
                this.oObjetoClase.ID_Proveedor = this._idproveedor;
                this.oObjetoClase.Apellido1 = this.Apellido1TextEdit.EditValue?.ToString() ?? "";
                this.oObjetoClase.Apellido2 = this.Apellido2TextEdit.EditValue?.ToString() ?? "";
                this.oObjetoClase.Nombre = this.NombreTextEdit.EditValue?.ToString() ?? "";
                this.oObjetoClase.ID_Tipo_persona = this.ID_Tipo_personaTextEdit.EditValue?.ToString() ?? "";
                this.oObjetoClase.Razon_Social = this.Razon_SocialTextEdit.EditValue?.ToString() ?? "";
                this.oObjetoClase.ID_Tipo_Documento = this.ID_Tipo_DocumentoTextEdit.EditValue.ToString();
                this.oObjetoClase.ID_Numero_Doc = Convert.ToDecimal(this.ID_Numero_DocTextEdit.EditValue);
                this.oObjetoClase.Direccion = this.DireccionTextEdit.EditValue.ToString();
                this.oObjetoClase.Interior = this.InteriorTextEdit.EditValue.ToString();
                this.oObjetoClase.Piso = this.PisoTextEdit.EditValue.ToString();
                this.oObjetoClase.ID_Codigo_postal = string.IsNullOrEmpty(this.ID_Codigo_postalTextEdit.EditValue?.ToString()) ? 0M : Convert.ToDecimal(this.ID_Codigo_postalTextEdit.EditValue);
                this.oObjetoClase.Telefono1 = string.IsNullOrEmpty(this.Telefono1TextEdit.EditValue?.ToString()) ? 0M : Convert.ToDecimal(this.Telefono1TextEdit.EditValue);
                this.oObjetoClase.Telefono2 = new Decimal?(string.IsNullOrEmpty(this.Telefono2TextEdit.EditValue?.ToString()) ? 0M : Convert.ToDecimal(this.Telefono2TextEdit.EditValue));
                this.oObjetoClase.email1 = string.IsNullOrEmpty(this.email1TextEdit.EditValue?.ToString()) ? "" : this.email1TextEdit.EditValue.ToString();
                this.oObjetoClase.email2 = string.IsNullOrEmpty(this.email2TextEdit.EditValue?.ToString()) ? "" : this.email2TextEdit.EditValue.ToString();
                this.oObjetoClase.web = string.IsNullOrEmpty(this.webTextEdit.EditValue?.ToString()) ? "" : this.webTextEdit.EditValue.ToString();
                this.oObjetoClase.ID_Contacto = string.IsNullOrEmpty(this.ID_ContactoTextEdit.EditValue?.ToString()) ? "" : this.ID_ContactoTextEdit.EditValue.ToString();
                this.oObjetoClase.Fecha_Modificacion = new DateTime?(DateTime.Now);
                this.oObjetoClase.Usuario_Modificacion = "1001";
                this.oObjetoClase.Fecha_Creacion = Convert.ToDateTime(this.Fecha_CreacionDateEdit.EditValue);
                this.oObjetoClase.Usuario_Creacion = this.Usuario_CreacionTextEdit.EditValue.ToString();
                if (proveedorRepository.Update(this.oObjetoClase))
                {
                    int num1 = (int)XtraMessageBox.Show("La actualización se realizó con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    int num2 = (int)XtraMessageBox.Show("Hubo un error al intentar actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
    }
}
