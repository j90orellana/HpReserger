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
    public partial class frmAddTipoCliente : XtraForm
    {
        public frmAddTipoCliente()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(Detalle_Tipo_ClienteTextEdit.EditValue?.ToString()))
            {
                XtraMessageBox.Show("Por favor, ingrese el detalle del tipo de cliente.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string user = "1001";
            if (HPReserger.frmLogin.CodigoUsuario > 100)
                user = HPReserger.frmLogin.CodigoUsuario.ToString();

            if (string.IsNullOrEmpty(_tipoCliente))
            {
                // NUEVO TIPO
                oTipoCliente.ID_Tipo_Cliente = "";
                oTipoCliente.Detalle_Tipo_Cliente = Detalle_Tipo_ClienteTextEdit.EditValue.ToString();

                string result = oTipoCliente.Insert(Detalle_Tipo_ClienteTextEdit.EditValue.ToString(), user);
                if (!string.IsNullOrEmpty(result))
                {
                    XtraMessageBox.Show($"El tipo se ha agregado con éxito con ID: {result}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Hubo un error al agregar el tipo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // UPDATE TIPO
                oTipoCliente.ID_Tipo_Cliente = _tipoCliente;
                oTipoCliente.Detalle_Tipo_Cliente = Detalle_Tipo_ClienteTextEdit.EditValue.ToString();

                bool result = oTipoCliente.Update(_tipoCliente, Detalle_Tipo_ClienteTextEdit.EditValue.ToString(), user);
                if (result)
                {
                    XtraMessageBox.Show($"El tipo se ha actualizado con éxito con ID: {_tipoCliente}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Hubo un error al actualizar el tipo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        public string _tipoCliente = "";
        HpResergerNube.CRM_Tipo_Cliente oTipoCliente = new HpResergerNube.CRM_Tipo_Cliente();

        private void frmAddTipoCliente_Load(object sender, EventArgs e)
        {
            if (_tipoCliente != "")
            {
                oTipoCliente = oTipoCliente.GetById(_tipoCliente);
                ID_Tipo_ClienteTextEdit.EditValue = oTipoCliente.ID_Tipo_Cliente;
                Detalle_Tipo_ClienteTextEdit.EditValue = oTipoCliente.Detalle_Tipo_Cliente;
            }
        }

        private void frmAddTipoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner is CRM.frmTipoCliente padre)
            {
                padre.CargarDatos(); // Llama al método para actualizar los datos en el formulario padre
            }
        }
    }
}
