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
    public partial class frmAddContacto : Form
    {
        internal string _idcontacto = "";

        public frmAddContacto()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        HpResergerNube.CRM_ContactoRepository.Contacto oContacto = new HpResergerNube.CRM_ContactoRepository.Contacto();

        private void frmAddContacto_Load(object sender, EventArgs e)
        {
            CargarCombos();
            Fecha_CreacionDateEdit.EditValue = DateTime.Now;
            Fecha_ModificacionDateEdit.EditValue = DateTime.Now;


            HpResergerNube.CRM_ContactoRepository objContacto = new HpResergerNube.CRM_ContactoRepository();
            if (_idcontacto != "")
            {
                oContacto = objContacto.ReadContacto(_idcontacto);

                // Asignar los valores del contacto a los controles
                ID_ContactoTextEdit.EditValue = oContacto.ID_Contacto;
                ID_TratamientoComboBoxEdit.EditValue = oContacto.ID_Tratamiento;
                NombreTextEdit.EditValue = oContacto.Nombre;
                Apellido1TextEdit.EditValue = oContacto.Apellido1;
                Apellido2TextEdit.EditValue = oContacto.Apellido2;
                CargoTextEdit.EditValue = oContacto.Cargo;
                Telefono1TextEdit.EditValue = oContacto.Telefono1;
                Telefono2TextEdit.EditValue = oContacto.Telefono2;
                Email1TextEdit.EditValue = oContacto.Email1;
                Email2TextEdit.EditValue = oContacto.Email2;
                OtrosTextEdit.EditValue = oContacto.Otros;
                ID_SexoTextEdit.EditValue = oContacto.ID_Sexo;
                ID_UsuarioTextEdit.EditValue = oContacto.ID_Usuario;
                Usuario_CreacionTextEdit.EditValue = oContacto.Usuario_Creacion;
                Fecha_CreacionDateEdit.EditValue = oContacto.Fecha_Creacion;
                Usuario_ModificacionTextEdit.EditValue = oContacto.Usuario_Modificacion;
                Fecha_ModificacionDateEdit.EditValue = oContacto.Fecha_Modificacion;

            }
        }
        private void CargarCombos()
        {
            HpResergerNube.CRM_Tratamiento oTratamiento = new HpResergerNube.CRM_Tratamiento();
            HpResergerNube.CRM_Usuario ousuario = new HpResergerNube.CRM_Usuario();
            HpResergerNube.CRM_Sexo oSexo = new HpResergerNube.CRM_Sexo();
            HpResergerNube.CRM_ContactoRepository objcontacto = new HpResergerNube.CRM_ContactoRepository();
            HpResergerNube.CRM_CodigoPostalRepository objpostal = new HpResergerNube.CRM_CodigoPostalRepository();

            // TRatamiento
            DataTable ttratamiento = oTratamiento.GetAllTratamientos();
            ID_TratamientoComboBoxEdit.Properties.DataSource = ttratamiento;
            ID_TratamientoComboBoxEdit.Properties.ValueMember = "ID_Tratamiento";
            ID_TratamientoComboBoxEdit.Properties.DisplayMember = "Detalle_tratamiento";
            ID_TratamientoComboBoxEdit.EditValue = ttratamiento.Rows.Count > 0 ? ttratamiento.Rows[0]["ID_Tratamiento"] : null;

            ID_TratamientoComboBoxEdit.Properties.View.Columns.Clear();
            ID_TratamientoComboBoxEdit.Properties.View.Columns.AddVisible("ID_Tratamiento", "Codigo");
            ID_TratamientoComboBoxEdit.Properties.View.Columns.AddVisible("Detalle_tratamiento", "Tratamiento");
            ID_TratamientoComboBoxEdit.Properties.View.BestFitColumns();

            // SEXO
            DataTable Tsexo = oSexo.GetAllSexos();
            ID_SexoTextEdit.Properties.DataSource = Tsexo;
            ID_SexoTextEdit.Properties.ValueMember = "ID_Sexo";
            ID_SexoTextEdit.Properties.DisplayMember = "Detalle_FM";
            ID_SexoTextEdit.EditValue = Tsexo.Rows.Count > 0 ? Tsexo.Rows[0]["ID_Sexo"] : null;

            ID_SexoTextEdit.Properties.View.Columns.Clear();
            ID_SexoTextEdit.Properties.View.Columns.AddVisible("ID_Sexo", "Codigo");
            ID_SexoTextEdit.Properties.View.Columns.AddVisible("Detalle_FM", "Sexo");
            ID_SexoTextEdit.Properties.View.BestFitColumns();

            // Usuario
            DataTable tusuario = ousuario.GetAllUsuarios();
            ID_UsuarioTextEdit.Properties.DataSource = tusuario;
            ID_UsuarioTextEdit.Properties.ValueMember = "ID_Usuario";
            ID_UsuarioTextEdit.Properties.DisplayMember = "Nombre_Completo";
            ID_UsuarioTextEdit.EditValue = tusuario.Rows.Count > 0 ? tusuario.Rows[0]["ID_Usuario"] : null;

            ID_UsuarioTextEdit.Properties.View.Columns.Clear();
            ID_UsuarioTextEdit.Properties.View.Columns.AddVisible("ID_Numero_Doc", "DNI");
            ID_UsuarioTextEdit.Properties.View.Columns.AddVisible("Nombre_Completo", "Nombre Completo");
            ID_UsuarioTextEdit.Properties.View.BestFitColumns();

            // Ajustar automáticamente el ancho de las columnas después de cargar los datos
            searchLookUpEdit1View.BestFitColumns();
            gridView1.BestFitColumns();
            gridView2.BestFitColumns();

        }
        public bool ValidarCamposNoNulos()
        {

            //if (ID_TratamientoComboBoxEdit.EditValue == null || string.IsNullOrWhiteSpace(ID_TratamientoComboBoxEdit.EditValue.ToString()))
            //{
            //    MessageBox.Show("Por favor, ingrese el ID de Tratamiento.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            if (NombreTextEdit.EditValue == null || string.IsNullOrWhiteSpace(NombreTextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el Nombre.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Apellido1TextEdit.EditValue == null || string.IsNullOrWhiteSpace(Apellido1TextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el Primer Apellido.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Apellido2TextEdit.EditValue == null || string.IsNullOrWhiteSpace(Apellido2TextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el Segundo Apellido.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (Telefono1TextEdit.EditValue == null || string.IsNullOrWhiteSpace(Telefono1TextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el Teléfono 1.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }



            if (Email1TextEdit.EditValue == null || string.IsNullOrWhiteSpace(Email1TextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el Email 1.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }



            //if (ID_SexoTextEdit.EditValue == null || string.IsNullOrWhiteSpace(ID_SexoTextEdit.EditValue.ToString()))
            //{
            //    MessageBox.Show("Por favor, ingrese el ID de Sexo.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            return true; // Todos los campos requeridos tienen valores
        }


        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ValidarCamposNoNulos()) return;

            // Asignar los valores de los controles al objeto de contacto
            oContacto.ID_Contacto = ID_ContactoTextEdit.EditValue?.ToString() ?? "";
            oContacto.ID_Tratamiento = ID_TratamientoComboBoxEdit.EditValue?.ToString() ?? "";
            oContacto.Nombre = NombreTextEdit.EditValue?.ToString() ?? "";
            oContacto.Apellido1 = Apellido1TextEdit.EditValue?.ToString() ?? "";
            oContacto.Apellido2 = Apellido2TextEdit.EditValue?.ToString() ?? "";
            oContacto.Cargo = CargoTextEdit.EditValue?.ToString() ?? "";
            oContacto.Telefono1 = Convert.ToDecimal(Telefono1TextEdit.EditValue ?? 0);
            oContacto.Telefono2 = Convert.ToDecimal(Telefono2TextEdit.EditValue ?? 0);
            oContacto.Email1 = Email1TextEdit.EditValue?.ToString() ?? "";
            oContacto.Email2 = Email2TextEdit.EditValue?.ToString() ?? "";
            oContacto.Otros = OtrosTextEdit.EditValue?.ToString() ?? "";
            oContacto.ID_Sexo = ID_SexoTextEdit.EditValue?.ToString() ?? "";
            oContacto.ID_Usuario = ID_UsuarioTextEdit.EditValue?.ToString() ?? "";
            oContacto.Usuario_Creacion = Usuario_CreacionTextEdit.EditValue?.ToString() ?? "";
            oContacto.Fecha_Creacion = Convert.ToDateTime(Fecha_CreacionDateEdit.EditValue ?? DateTime.MinValue);
            oContacto.Usuario_Modificacion = Usuario_ModificacionTextEdit.EditValue?.ToString() ?? "";
            oContacto.Fecha_Modificacion = Convert.ToDateTime(Fecha_ModificacionDateEdit.EditValue ?? DateTime.MinValue);
            
            HpResergerNube.CRM_ContactoRepository objContacto = new HpResergerNube.CRM_ContactoRepository();

            if (_idcontacto == "")
            {
                //Insertar
                oContacto.Usuario_Modificacion = "1001";
                oContacto.Usuario_Creacion = "1001";
                oContacto.Fecha_Creacion = DateTime.Now;
                oContacto.Fecha_Modificacion = DateTime.Now;
                string insertedId = objContacto.InsertContacto(oContacto);
                if (insertedId != "")
                {
                    XtraMessageBox.Show("El contacto se ha registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _idcontacto = insertedId;
                    ID_ContactoTextEdit.EditValue = insertedId;
                }
                else
                {
                    XtraMessageBox.Show("Ocurrió un error al intentar registrar el contacto. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _idcontacto = "";
                }
            }
            else
            {
                //Update
                oContacto.ID_Contacto = _idcontacto;
                oContacto.Fecha_Modificacion = DateTime.Now;
                if (objContacto.UpdateContacto(oContacto))
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
