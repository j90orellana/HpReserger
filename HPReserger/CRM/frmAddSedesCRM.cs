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
    public partial class frmAddSedesCRM : XtraForm
    {
        internal string _idSede = "";

        public frmAddSedesCRM()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HpResergerNube.CRM_Sedes objSede = new HpResergerNube.CRM_Sedes();

            oSede.ID_Sedes = "";           
            oSede.Nombre = NombreTextEdit.EditValue?.ToString() ?? "";
            oSede.Dirección = DirecciónTextEdit.EditValue?.ToString() ?? "";
            oSede.Interior = InteriorTextEdit.EditValue?.ToString() ?? "";
            oSede.Piso = PisoTextEdit.EditValue?.ToString() ?? "";
            oSede.ID_Codigo_postal = Convert.ToDecimal(ID_Codigo_postalTextEdit.EditValue ?? 0);
            oSede.Telefono = Convert.ToDecimal(TelefonoTextEdit.EditValue ?? 0);
            oSede.Fecha_Creacion = Convert.ToDateTime(Fecha_CreacionDateEdit.EditValue ?? DateTime.MinValue);
            oSede.Usuario_Creacion = Convert.ToDecimal(Usuario_CreacionTextEdit.EditValue ?? 1003);
            oSede.Observaciones = ObservacionesTextEdit.EditValue?.ToString() ?? "";

            if (_idSede == "")
            {


                //Insertar
                oSede.Fecha_Creacion = DateTime.Now;
                string insertedId = objSede.InsertSede(oSede);
                if (insertedId != "")
                {
                    XtraMessageBox.Show("La sede se ha registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _idSede = insertedId;
                    ID_SedesTextEdit.EditValue = insertedId;
                }
                else
                {
                    XtraMessageBox.Show("Ocurrió un error al intentar registrar la sede. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _idSede = "";
                }

            }
            else
            {
                // Update 
                oSede.ID_Sedes = ID_SedesTextEdit.EditValue?.ToString() ?? "";

                if (objSede.UpdateSede(oSede))
                {
                    XtraMessageBox.Show("La actualización se realizó con éxito.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Hubo un error al intentar actualizar la sede. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        HpResergerNube.CRM_Sedes oSede = new HpResergerNube.CRM_Sedes();
        private void frmAddSedesCRM_Load(object sender, EventArgs e)
        {
            CargarCombos();
            HpResergerNube.CRM_Sedes objSede = new HpResergerNube.CRM_Sedes();
            if (_idSede != "")
            {
                oSede = objSede.ReadSede(_idSede.ToString());
                ID_SedesTextEdit.EditValue = oSede.ID_Sedes;
                NombreTextEdit.EditValue = oSede.Nombre;
                DirecciónTextEdit.EditValue = oSede.Dirección;
                InteriorTextEdit.EditValue = oSede.Interior;
                PisoTextEdit.EditValue = oSede.Piso;
                ID_Codigo_postalTextEdit.EditValue = oSede.ID_Codigo_postal;
                TelefonoTextEdit.EditValue = oSede.Telefono;
                Fecha_CreacionDateEdit.EditValue = oSede.Fecha_Creacion;
                Usuario_CreacionTextEdit.EditValue = oSede.Usuario_Creacion;
                ObservacionesTextEdit.EditValue = oSede.Observaciones;
            }
        }
        private void CargarCombos()
        {
            HpResergerNube.CRM_CodigoPostalRepository objpostal = new HpResergerNube.CRM_CodigoPostalRepository();
            HpResergerNube.CRM_Usuario ousuario = new HpResergerNube.CRM_Usuario();

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

        }
    }
}
