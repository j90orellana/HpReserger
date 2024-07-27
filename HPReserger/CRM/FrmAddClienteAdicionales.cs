using DevExpress.XtraEditors;
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

namespace SISGEM.CRM
{
    public partial class FrmAddClienteAdicionales : XtraForm
    {
        public int pkid { get; internal set; }
        public string fkid { get; internal set; }

        public FrmAddClienteAdicionales()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int clienteId = (int)pk_idTextEdit.EditValue;

            // Mostrar mensaje de confirmación
            DialogResult result = XtraMessageBox.Show(
                "¿Está seguro de que desea eliminar este dato adicional?",
                "Confirmación de eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si el usuario confirma la eliminación
            if (result == DialogResult.Yes)
            {
                SCH_ClienteAdicionales objClientesAdicionales = new SCH_ClienteAdicionales();

                // Llamar al método de eliminación
                objClientesAdicionales.DeleteClienteAdicional(clienteId);

                // Mostrar mensaje de que se eliminó
                XtraMessageBox.Show(
                    "El dato adicional ha sido eliminado correctamente.",
                    "Eliminación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SCH_ClienteAdicionales objClientesAdicionales = new SCH_ClienteAdicionales();
            if (pk_idTextEdit.EditValue == null)
            {
                objClientesAdicionales.fk_ID_Cliente = fk_ID_ClienteTextEdit.EditValue?.ToString() ?? "";
                objClientesAdicionales.ContactoCierre = ContactoCierreTextEdit.EditValue?.ToString() ?? "";
                objClientesAdicionales.COORDINACION_CLIENTE1 = COORDINACION_CLIENTE1TextEdit.EditValue?.ToString() ?? "";
                objClientesAdicionales.COORDINACION_CLIENTE2 = COORDINACION_CLIENTE2TextEdit.EditValue?.ToString() ?? "";
                objClientesAdicionales.COORDINACION_CLIENTE3 = COORDINACION_CLIENTE3TextEdit.EditValue?.ToString() ?? "";
                objClientesAdicionales.COORDINACION_CLIENTE4 = COORDINACION_CLIENTE4TextEdit.EditValue?.ToString() ?? "";
                objClientesAdicionales.EspacioEnNube = EspacioEnNubeTextEdit.EditValue?.ToString() ?? "";
                objClientesAdicionales.NombreComercial = NombreComercialTextEdit.EditValue?.ToString() ?? "";
                objClientesAdicionales.OficinaReunion = OficinaReunionTextEdit.EditValue?.ToString() ?? "";

                objClientesAdicionales.pk_id = objClientesAdicionales.InsertClienteAdicional(objClientesAdicionales);

                if (objClientesAdicionales.pk_id != 0)
                {
                    XtraMessageBox.Show(
                        "Datos guardados con éxito.",
                        "Guardado exitoso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    XtraMessageBox.Show(
                        "Hubo un error al guardar los datos.",
                        "Error al guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            else
            {
                objClientesAdicionales.pk_id = pkid;
                objClientesAdicionales.fk_ID_Cliente = fk_ID_ClienteTextEdit.EditValue?.ToString() ?? "";
                objClientesAdicionales.ContactoCierre = ContactoCierreTextEdit.EditValue?.ToString() ?? "";
                objClientesAdicionales.COORDINACION_CLIENTE1 = COORDINACION_CLIENTE1TextEdit.EditValue?.ToString() ?? "";
                objClientesAdicionales.COORDINACION_CLIENTE2 = COORDINACION_CLIENTE2TextEdit.EditValue?.ToString() ?? "";
                objClientesAdicionales.COORDINACION_CLIENTE3 = COORDINACION_CLIENTE3TextEdit.EditValue?.ToString() ?? "";
                objClientesAdicionales.COORDINACION_CLIENTE4 = COORDINACION_CLIENTE4TextEdit.EditValue?.ToString() ?? "";
                objClientesAdicionales.EspacioEnNube = EspacioEnNubeTextEdit.EditValue?.ToString() ?? "";
                objClientesAdicionales.NombreComercial = NombreComercialTextEdit.EditValue?.ToString() ?? "";
                objClientesAdicionales.OficinaReunion = OficinaReunionTextEdit.EditValue?.ToString() ?? "";

                if (objClientesAdicionales.UpdateClienteAdicional(objClientesAdicionales))
                {
                    XtraMessageBox.Show(
                        "Datos guardados con éxito.",
                        "Guardado exitoso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    XtraMessageBox.Show(
                        "Hubo un error al guardar los datos.",
                        "Error al guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void FrmAddClienteAdicionales_Load(object sender, EventArgs e)
        {
            fk_ID_ClienteTextEdit.EditValue = fkid;
            pk_idTextEdit.EditValue = pkid;
            if (pkid != 0)
            {
                HpResergerNube.SCH_ClienteAdicionales objClientesAdicionales = new SCH_ClienteAdicionales();
                objClientesAdicionales = objClientesAdicionales.ReadClienteAdicional(pkid);

                //fk_ID_ClienteTextEdit.EditValue = objClientesAdicionales.fk_ID_Cliente ?? "";
                ContactoCierreTextEdit.EditValue = objClientesAdicionales.ContactoCierre ?? "";
                COORDINACION_CLIENTE1TextEdit.EditValue = objClientesAdicionales.COORDINACION_CLIENTE1 ?? "";
                COORDINACION_CLIENTE2TextEdit.EditValue = objClientesAdicionales.COORDINACION_CLIENTE2 ?? "";
                COORDINACION_CLIENTE3TextEdit.EditValue = objClientesAdicionales.COORDINACION_CLIENTE3 ?? "";
                COORDINACION_CLIENTE4TextEdit.EditValue = objClientesAdicionales.COORDINACION_CLIENTE4 ?? "";
                EspacioEnNubeTextEdit.EditValue = objClientesAdicionales.EspacioEnNube ?? "";
                NombreComercialTextEdit.EditValue = objClientesAdicionales.NombreComercial ?? "";
                OficinaReunionTextEdit.EditValue = objClientesAdicionales.OficinaReunion ?? "";
            }
            // Crear instancia del repositorio de contactos
            HpResergerNube.CRM_ContactoRepository ocontacto = new HpResergerNube.CRM_ContactoRepository();

            // Obtener los contactos del cliente
            DataTable contactos = ocontacto.GetContactosPorCliente(fk_ID_ClienteTextEdit.EditValue.ToString());

            // Verificar si se encontraron contactos
            if (contactos.Rows.Count > 0)
            {
                // Configurar el control de edición de ID_Contacto
                ContactoCierreTextEdit.Properties.DataSource = contactos;
                ContactoCierreTextEdit.Properties.ValueMember = "ID_Contacto";
                ContactoCierreTextEdit.Properties.DisplayMember = "NombreCompleto";
                ContactoCierreTextEdit.EditValue = contactos.Rows[0]["ID_Contacto"];

                // Configurar las columnas visibles en la vista del control de edición de ID_Contacto
                ContactoCierreTextEdit.Properties.View.Columns.Clear();
                ContactoCierreTextEdit.Properties.View.Columns.AddVisible("ID_Contacto", "Código");
                ContactoCierreTextEdit.Properties.View.Columns.AddVisible("Telefono1", "Telefono");
                ContactoCierreTextEdit.Properties.View.Columns.AddVisible("NombreCompleto", "Nombre Completo");

                ContactoCierreTextEdit.Properties.View.Columns.AddVisible("Cargo", "Cargo");
                ContactoCierreTextEdit.Properties.View.Columns.AddVisible("email1", "Email");
                ContactoCierreTextEdit.Properties.View.BestFitColumns();
            }
            else
            {
                // Limpiar el control de edición de ID_Contacto si no se encontraron contactos
                ContactoCierreTextEdit.Properties.DataSource = null;
                ContactoCierreTextEdit.EditValue = null;
            }



        }
    }
}
