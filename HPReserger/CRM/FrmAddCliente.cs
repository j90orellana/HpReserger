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
    public partial class FrmAddCliente : XtraForm
    {
        public FrmAddCliente()
        {
            InitializeComponent();
        }
        public string _idCliente = "";
        HpResergerNube.CRM_Cliente oCliente = new HpResergerNube.CRM_Cliente();

        private void FrmAddCliente_Load(object sender, EventArgs e)
        {
            CargarCombos();
            HpResergerNube.CRM_ClienteRepository obkjcliente = new HpResergerNube.CRM_ClienteRepository();
            if (_idCliente != "")
            {
                oCliente = obkjcliente.SelectCliente(_idCliente.ToString());
                ID_ClienteTextEdit.EditValue = _idCliente;
                Apellido1TextEdit.EditValue = oCliente.Apellido1;
                Apellido2TextEdit.EditValue = oCliente.Apellido2;
                NombreTextEdit.EditValue = oCliente.Nombre;
                ID_Tipo_personaTextEdit.EditValue = oCliente.ID_Tipo_persona;
                Razon_SocialTextEdit.EditValue = oCliente.Razon_Social;
                ID_TIpo_DocumentoTextEdit.EditValue = oCliente.ID_TIpo_Documento;
                ID_Numero_DocTextEdit.EditValue = oCliente.ID_Numero_Doc;
                DireccionTextEdit.EditValue = oCliente.Direccion;
                InteriorTextEdit.EditValue = oCliente.Interior;
                PisoTextEdit.EditValue = oCliente.Piso;
                ID_Codigo_postalTextEdit.EditValue = oCliente.ID_Codigo_postal;
                Telefono1TextEdit.EditValue = oCliente.Telefono1;
                Telefono2TextEdit.EditValue = oCliente.Telefono2;
                email1TextEdit.EditValue = oCliente.email1;
                email2TextEdit.EditValue = oCliente.email2;
                webTextEdit.EditValue = oCliente.web;
                ID_ContactoTextEdit.EditValue = oCliente.ID_Contacto;
                cboTipoCliente.EditValue = oCliente.TipodeCliente;

            }
        }

        private void CargarCombos()
        {
            HpResergerNube.CRM_Tipo_PersonaRepository objtipopersona = new HpResergerNube.CRM_Tipo_PersonaRepository();
            HpResergerNube.CRM_Tipo_RelacionRepository objtiporelacion = new HpResergerNube.CRM_Tipo_RelacionRepository();
            HpResergerNube.CRM_Tipo_DocumentoRepository objtipodocumento = new HpResergerNube.CRM_Tipo_DocumentoRepository();
            HpResergerNube.CRM_ContactoRepository objcontacto = new HpResergerNube.CRM_ContactoRepository();
            HpResergerNube.CRM_CodigoPostalRepository objpostal = new HpResergerNube.CRM_CodigoPostalRepository();
            HpResergerNube.CRM_Tipo_Cliente objTipoCLiente = new HpResergerNube.CRM_Tipo_Cliente();

            //TIPOS DE PERSONAS
            DataTable tipoPersonas = objtipopersona.GetAllTipoPersonas();
            ID_Tipo_personaTextEdit.Properties.DataSource = tipoPersonas;
            ID_Tipo_personaTextEdit.Properties.ValueMember = "ID_Tipo_persona";
            ID_Tipo_personaTextEdit.Properties.DisplayMember = "Detalle_Tipo_Persona";
            ID_Tipo_personaTextEdit.EditValue = tipoPersonas.Rows.Count > 0 ? tipoPersonas.Rows[0]["ID_Tipo_persona"] : null;

            ID_Tipo_personaTextEdit.Properties.View.Columns.Clear();
            ID_Tipo_personaTextEdit.Properties.View.Columns.AddVisible("ID_Tipo_persona", "Codigo");
            ID_Tipo_personaTextEdit.Properties.View.Columns.AddVisible("Detalle_Tipo_Persona", "Tipo Persona");
            ID_Tipo_personaTextEdit.Properties.View.BestFitColumns();

            //TIPO CLIENTE
            DataTable TTipoCliente = objTipoCLiente.GetAll();
            cboTipoCliente.Properties.DataSource = TTipoCliente;
            cboTipoCliente.Properties.ValueMember = "ID_Tipo_Cliente";
            cboTipoCliente.Properties.DisplayMember = "Detalle_Tipo_Cliente";
            cboTipoCliente.EditValue = TTipoCliente.Rows.Count > 0 ? TTipoCliente.Rows[0]["ID_Tipo_Cliente"] : null;

            cboTipoCliente.Properties.View.Columns.Clear();
            cboTipoCliente.Properties.View.Columns.AddVisible("ID_Tipo_Cliente", "Codigo");
            cboTipoCliente.Properties.View.Columns.AddVisible("Detalle_Tipo_Cliente", "Tipo Cliente");
            cboTipoCliente.Properties.View.BestFitColumns();
            ////TIPO RELACION
            //DataTable tipoRelacion = objtiporelacion.GetAllTipoRelacion();
            //ID_RelacionTextEdit.Properties.DataSource = tipoRelacion;
            //ID_RelacionTextEdit.Properties.ValueMember = "ID_Relacion";
            //ID_RelacionTextEdit.Properties.DisplayMember = "Detalle_Relacion";
            //ID_RelacionTextEdit.EditValue = tipoRelacion.Rows.Count > 0 ? tipoRelacion.Rows[0]["ID_Relacion"] : null;

            //gridView1.Columns.AddVisible("ID_Relacion", "Codigo");
            //gridView1.Columns.AddVisible("Detalle_Relacion", "Tipo Relación");

            // TIPO DOCUMENTO
            DataTable tipoDocumentos = objtipodocumento.GetAllTipoDocumentos();
            ID_TIpo_DocumentoTextEdit.Properties.DataSource = tipoDocumentos;
            ID_TIpo_DocumentoTextEdit.Properties.ValueMember = "ID_Tipo_documento";
            ID_TIpo_DocumentoTextEdit.Properties.DisplayMember = "Detalle_Tipo_documento";
            ID_TIpo_DocumentoTextEdit.EditValue = tipoDocumentos.Rows.Count > 0 ? tipoDocumentos.Rows[0]["ID_Tipo_documento"] : null;

            ID_TIpo_DocumentoTextEdit.Properties.View.Columns.Clear();
            ID_TIpo_DocumentoTextEdit.Properties.View.Columns.AddVisible("ID_Tipo_documento", "Codigo");
            ID_TIpo_DocumentoTextEdit.Properties.View.Columns.AddVisible("Detalle_Tipo_documento", "Tipo Documento");
            ID_TIpo_DocumentoTextEdit.Properties.View.BestFitColumns();

            RecargarContacto();

            // CODIGO POSTAL
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


        }
        public bool ValidarCamposNoNulos()
        {
            if (string.IsNullOrEmpty(ID_Tipo_personaTextEdit.EditValue?.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el Tipo de Persona.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //if (string.IsNullOrEmpty(ID_RelacionTextEdit.EditValue?.ToString()))
            //{
            //    MessageBox.Show("Por favor, ingrese la Relación.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}
            if (string.IsNullOrEmpty(ID_TIpo_DocumentoTextEdit.EditValue?.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el Tipo de Documento.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(DireccionTextEdit.EditValue?.ToString()))
            {
                MessageBox.Show("Por favor, ingrese la Dirección.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(ID_Codigo_postalTextEdit.EditValue?.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el Código Postal.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(Telefono1TextEdit.EditValue?.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el Teléfono.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(ID_ContactoTextEdit.EditValue?.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el ID del Contacto.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            // Puedes agregar más validaciones según sea necesario

            return true; // Todos los campos requeridos tienen valores
        }
        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (!ValidarCamposNoNulos()) return;
            if (oCliente.Usuario_Eliminacion == null)
                oCliente.Usuario_Eliminacion = "";
            if (oCliente.Fecha_Eliminacion == null)
                oCliente.Fecha_Eliminacion = DateTime.MinValue;

            if (_idCliente == "")
            {
                //Insertamos
                // Asignar los valores de los controles al objeto cliente
                oCliente.ID_Cliente = "C24-" + ID_Numero_DocTextEdit.EditValue.ToString().PadLeft(11, '0');

                oCliente.Apellido1 = Apellido1TextEdit.EditValue?.ToString() ?? ""; // Valor por defecto del tipo de datos string es cadena vacía
                oCliente.Apellido2 = Apellido2TextEdit.EditValue?.ToString() ?? ""; // Valor por defecto del tipo de datos string es cadena vacía
                oCliente.Nombre = NombreTextEdit.EditValue?.ToString() ?? ""; // Valor por defecto del tipo de datos string es cadena vacía
                oCliente.ID_Tipo_persona = ID_Tipo_personaTextEdit.EditValue?.ToString() ?? ""; // Valor por defecto del tipo de datos string es cadena vacía
                //oCliente.ID_Relacion = ID_RelacionTextEdit.EditValue?.ToString() ?? ""; // Valor por defecto del tipo de datos string es cadena vacía
                oCliente.Razon_Social = Razon_SocialTextEdit.EditValue?.ToString() ?? ""; // Valor por defecto del tipo de datos string es cadena vacía

                oCliente.ID_TIpo_Documento = ID_TIpo_DocumentoTextEdit.EditValue.ToString();
                oCliente.ID_Numero_Doc = Convert.ToDecimal(ID_Numero_DocTextEdit.EditValue);
                oCliente.Direccion = DireccionTextEdit.EditValue.ToString();
                oCliente.Interior = InteriorTextEdit.EditValue.ToString();
                oCliente.Piso = PisoTextEdit.EditValue.ToString();
                oCliente.ID_Codigo_postal = string.IsNullOrEmpty(ID_Codigo_postalTextEdit.EditValue?.ToString()) ? 0 : Convert.ToDecimal(ID_Codigo_postalTextEdit.EditValue);
                oCliente.Telefono1 = string.IsNullOrEmpty(Telefono1TextEdit.EditValue?.ToString()) ? 0 : Convert.ToDecimal(Telefono1TextEdit.EditValue);
                oCliente.Telefono2 = string.IsNullOrEmpty(Telefono2TextEdit.EditValue?.ToString()) ? 0 : Convert.ToDecimal(Telefono2TextEdit.EditValue);
                oCliente.email1 = string.IsNullOrEmpty(email1TextEdit.EditValue?.ToString()) ? "" : email1TextEdit.EditValue.ToString();
                oCliente.email2 = string.IsNullOrEmpty(email2TextEdit.EditValue?.ToString()) ? "" : email2TextEdit.EditValue.ToString();
                oCliente.web = string.IsNullOrEmpty(webTextEdit.EditValue?.ToString()) ? "" : webTextEdit.EditValue.ToString();
                oCliente.ID_Contacto = string.IsNullOrEmpty(ID_ContactoTextEdit.EditValue?.ToString()) ? "" : ID_ContactoTextEdit.EditValue.ToString();

                oCliente.TipodeCliente = cboTipoCliente.EditValue.ToString();

                oCliente.Fecha_Modificacion = DateTime.Now;
                oCliente.Usuario_Modificacion = "1001";
                oCliente.Fecha_Creacion = DateTime.Now;
                oCliente.Usuario_Creacion = "1001";

                HpResergerNube.CRM_ClienteRepository Rcliente = new HpResergerNube.CRM_ClienteRepository();
                if (Rcliente.InsertCliente(oCliente))
                {
                    XtraMessageBox.Show("El registro del cliente se ha completado exitosamente.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _idCliente = oCliente.ID_Cliente;
                    ID_ClienteTextEdit.EditValue = oCliente.ID_Cliente;
                }
                else
                {
                    XtraMessageBox.Show("Ocurrió un error al intentar registrar el cliente. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _idCliente = "";

                }
            }
            else
            {
                //Actualizamos

                // Asignar los valores de los controles al objeto cliente
                oCliente.ID_Cliente = _idCliente;
                oCliente.Apellido1 = Apellido1TextEdit.EditValue.ToString();
                oCliente.Apellido2 = Apellido2TextEdit.EditValue.ToString();
                oCliente.Nombre = NombreTextEdit.EditValue.ToString();
                oCliente.ID_Tipo_persona = ID_Tipo_personaTextEdit.EditValue.ToString();
                //oCliente.ID_Relacion = ID_RelacionTextEdit.EditValue.ToString();
                oCliente.Razon_Social = Razon_SocialTextEdit.EditValue.ToString();
                oCliente.ID_TIpo_Documento = ID_TIpo_DocumentoTextEdit.EditValue.ToString();
                oCliente.ID_Numero_Doc = Convert.ToDecimal(ID_Numero_DocTextEdit.EditValue);
                oCliente.Direccion = DireccionTextEdit.EditValue.ToString();
                oCliente.Interior = InteriorTextEdit.EditValue.ToString();
                oCliente.Piso = PisoTextEdit.EditValue.ToString();
                oCliente.ID_Codigo_postal = string.IsNullOrEmpty(ID_Codigo_postalTextEdit.EditValue?.ToString()) ? 0 : Convert.ToDecimal(ID_Codigo_postalTextEdit.EditValue);
                oCliente.Telefono1 = string.IsNullOrEmpty(Telefono1TextEdit.EditValue?.ToString()) ? 0 : Convert.ToDecimal(Telefono1TextEdit.EditValue);
                oCliente.Telefono2 = string.IsNullOrEmpty(Telefono2TextEdit.EditValue?.ToString()) ? 0 : Convert.ToDecimal(Telefono2TextEdit.EditValue);
                oCliente.email1 = string.IsNullOrEmpty(email1TextEdit.EditValue?.ToString()) ? "" : email1TextEdit.EditValue.ToString();
                oCliente.email2 = string.IsNullOrEmpty(email2TextEdit.EditValue?.ToString()) ? "" : email2TextEdit.EditValue.ToString();
                oCliente.web = string.IsNullOrEmpty(webTextEdit.EditValue?.ToString()) ? "" : webTextEdit.EditValue.ToString();
                oCliente.ID_Contacto = string.IsNullOrEmpty(ID_ContactoTextEdit.EditValue?.ToString()) ? "" : ID_ContactoTextEdit.EditValue.ToString();
                oCliente.Fecha_Modificacion = DateTime.Now;
                oCliente.Usuario_Modificacion = "1001";

                HpResergerNube.CRM_ClienteRepository Rcliente = new HpResergerNube.CRM_ClienteRepository();
                if (Rcliente.UpdateCliente(oCliente))
                {
                    XtraMessageBox.Show("La actualización se realizó con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Hubo un error al intentar actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ID_Tipo_personaTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (ID_Tipo_personaTextEdit.EditValue != null)
            {
                ItemForRazon_Social.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                ItemForNombre.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                ItemForApellido1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                ItemForApellido2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                if (ID_Tipo_personaTextEdit.EditValue.ToString() == "N")
                {
                    ItemForRazon_Social.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                }
                else if (ID_Tipo_personaTextEdit.EditValue.ToString() == "J")
                {
                    ItemForNombre.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    ItemForApellido1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    ItemForApellido2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

                }
            }
        }
        private void RecargarContacto()
        {
            HpResergerNube.CRM_ContactoRepository objcontacto = new HpResergerNube.CRM_ContactoRepository();
            //contacto
            DataTable contactos = objcontacto.GetAllContactos();
            ID_ContactoTextEdit.Properties.DataSource = contactos;
            ID_ContactoTextEdit.Properties.ValueMember = "ID_Contacto";
            ID_ContactoTextEdit.Properties.DisplayMember = "NombreCompleto";
            ID_ContactoTextEdit.EditValue = contactos.Rows.Count > 0 ? contactos.Rows[0]["ID_Contacto"] : null;

            ID_ContactoTextEdit.Properties.View.Columns.Clear();
            ID_ContactoTextEdit.Properties.View.Columns.AddVisible("ID_Contacto", "Codigo");
                ID_ContactoTextEdit.Properties.View.Columns.AddVisible("Telefono1", "Telefono");
            ID_ContactoTextEdit.Properties.View.Columns.AddVisible("NombreCompleto", "Nombre Completo");
            ID_ContactoTextEdit.Properties.View.BestFitColumns();

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string data = ID_ContactoTextEdit.EditValue?.ToString() ?? "";

            CRM.frmAddContacto frm = new CRM.frmAddContacto();
            frm.ShowDialog();
            RecargarContacto();
            ID_ContactoTextEdit.EditValue = data;
        }
    }
}
