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
    public partial class frmAddSeguimiento : XtraForm
    {
        public frmAddSeguimiento()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        public decimal _idseguimiento = 0;
        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ValidarCamposNoNulos()) return;
            oSeguimiento.ID_Contacto = Convert.ToString(ID_ContactoTextEdit.EditValue);
            oSeguimiento.Contacto = ID_ContactoTextEdit.Text;
            oSeguimiento.Descripcion = Convert.ToString(DescripciónTextEdit.EditValue);
            oSeguimiento.ID_Proyecto = Convert.ToDecimal(ID_ProyectoTextEdit.EditValue);
            oSeguimiento.Nombre_Proyecto = ID_ProyectoTextEdit.Text;
            oSeguimiento.ID_Tipo_Seguimiento = Convert.ToString(ID_Tipo_SeguimientoTextEdit.EditValue);
            oSeguimiento.Detalle_Tipo_Seguimiento = ID_Tipo_SeguimientoTextEdit.Text;
            oSeguimiento.Usuario_Creacion = Convert.ToString(Usuario_CreacionTextEdit.EditValue);
            oSeguimiento.Fecha_Seguimiento = Convert.ToDateTime(Fecha_SeguimientoDateEdit.EditValue);
            oSeguimiento.Fecha_Prox_Seguimiento = Convert.ToDateTime(Fecha_Prox_SeguimientoDateEdit.EditValue);
            oSeguimiento.ID_Cliente = cbocliente.EditValue.ToString();

            HpResergerNube.CRM_SeguimientoRepository objseguimiento = new HpResergerNube.CRM_SeguimientoRepository();

            if (_idseguimiento == 0)
            {
                //Insertar
                oSeguimiento.Fecha_Registro = DateTime.Now;


                int insertedId = objseguimiento.InsertSeguimiento(oSeguimiento);
                if (insertedId != -1)
                {
                    XtraMessageBox.Show("El seguimiento se ha registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _idseguimiento = insertedId;
                    ID_SeguimientoTextEdit.EditValue = insertedId;
                }
                else
                {
                    XtraMessageBox.Show("Ocurrió un error al intentar registrar el seguimiento. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _idseguimiento = 0;
                }
            }
            else
            {
                //Update
                oSeguimiento.ID_Seguimiento = _idseguimiento;
                if (objseguimiento.UpdateSeguimiento(oSeguimiento))
                {
                    XtraMessageBox.Show("La actualización se realizó con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Hubo un error al intentar actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool ValidarCamposNoNulos()
        {
            if (ID_ContactoTextEdit.EditValue == null || string.IsNullOrWhiteSpace(ID_ContactoTextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el ID de Contacto.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbocliente.EditValue == null || string.IsNullOrWhiteSpace(cbocliente.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el ID de Cliente.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (DescripciónTextEdit.EditValue == null || string.IsNullOrWhiteSpace(DescripciónTextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese la Descripción.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ID_ProyectoTextEdit.EditValue == null || string.IsNullOrWhiteSpace(ID_ProyectoTextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el ID de Proyecto.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ID_Tipo_SeguimientoTextEdit.EditValue == null || string.IsNullOrWhiteSpace(ID_Tipo_SeguimientoTextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el ID del Tipo de Seguimiento.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Usuario_CreacionTextEdit.EditValue == null || string.IsNullOrWhiteSpace(Usuario_CreacionTextEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese el Usuario de Creación.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Fecha_SeguimientoDateEdit.EditValue == null || string.IsNullOrWhiteSpace(Fecha_SeguimientoDateEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese la Fecha de Seguimiento.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Fecha_Prox_SeguimientoDateEdit.EditValue == null || string.IsNullOrWhiteSpace(Fecha_Prox_SeguimientoDateEdit.EditValue.ToString()))
            {
                MessageBox.Show("Por favor, ingrese la Fecha de Próximo Seguimiento.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // Todos los campos requeridos tienen valores
        }


        HpResergerNube.CRM_SeguimientoRepository.CRM_Seguimiento oSeguimiento = new HpResergerNube.CRM_SeguimientoRepository.CRM_Seguimiento();

        private void frmAddSeguimiento_Load(object sender, EventArgs e)
        {
            CargarCombos();
            Fecha_SeguimientoDateEdit.EditValue = DateTime.Now;
            Fecha_Prox_SeguimientoDateEdit.EditValue = HpResergerNube.DLConexion.ObtenerUltimoDiaDelMes(DateTime.Now);
            HpResergerNube.CRM_SeguimientoRepository objseguimiento = new HpResergerNube.CRM_SeguimientoRepository();
            if (_idseguimiento != 0)
            {
                ID_SeguimientoTextEdit.EditValue = _idseguimiento;
                oSeguimiento = objseguimiento.SelectSeguimiento(_idseguimiento);
                ID_ContactoTextEdit.EditValue = oSeguimiento.ID_Contacto;
                DescripciónTextEdit.EditValue = oSeguimiento.Descripcion;
                ID_ProyectoTextEdit.EditValue = oSeguimiento.ID_Proyecto;
                ID_Tipo_SeguimientoTextEdit.EditValue = oSeguimiento.ID_Tipo_Seguimiento;
                Usuario_CreacionTextEdit.EditValue = oSeguimiento.Usuario_Creacion;
                Fecha_SeguimientoDateEdit.EditValue = oSeguimiento.Fecha_Seguimiento;
                Fecha_Prox_SeguimientoDateEdit.EditValue = oSeguimiento.Fecha_Prox_Seguimiento;
                cbocliente.EditValue = oSeguimiento.ID_Cliente;
            }
        }

        private void CargarCombos()
        {
            HpResergerNube.CRM_ProyectoRepository oproyecto = new HpResergerNube.CRM_ProyectoRepository();
            HpResergerNube.CRM_Usuario ousuario = new HpResergerNube.CRM_Usuario();
            HpResergerNube.CRM_Tipo_SeguimientoRepository OSeguimiento = new HpResergerNube.CRM_Tipo_SeguimientoRepository();
            HpResergerNube.CRM_ContactoRepository objcontacto = new HpResergerNube.CRM_ContactoRepository();
            HpResergerNube.CRM_CodigoPostalRepository objpostal = new HpResergerNube.CRM_CodigoPostalRepository();

            //proyectos
            DataTable tproyecto = oproyecto.GetAllProyectos();
            ID_ProyectoTextEdit.Properties.DataSource = tproyecto;
            ID_ProyectoTextEdit.Properties.ValueMember = "ID_Proyecto";
            ID_ProyectoTextEdit.Properties.DisplayMember = "Nombre_Proyecto";
            ID_ProyectoTextEdit.EditValue = tproyecto.Rows.Count > 0 ? tproyecto.Rows[0]["ID_Proyecto"] : null;

            ID_ProyectoTextEdit.Properties.View.Columns.Clear();
            ID_ProyectoTextEdit.Properties.View.Columns.AddVisible("Nombre_Proyecto", "Nombre Proyecto");
            ID_ProyectoTextEdit.Properties.View.Columns.AddVisible("Requerimiento", "Requerimiento");
            ID_ProyectoTextEdit.Properties.View.BestFitColumns();

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

            //TIPO SEGUIMIENTO
            DataTable ttiposeguimiento = OSeguimiento.GetAllTipoSeguimientos();
            ID_Tipo_SeguimientoTextEdit.Properties.DataSource = ttiposeguimiento;
            ID_Tipo_SeguimientoTextEdit.Properties.ValueMember = "ID_Tipo_seguimiento";
            ID_Tipo_SeguimientoTextEdit.Properties.DisplayMember = "Detalle_Tipo_seguimiento";
            ID_Tipo_SeguimientoTextEdit.EditValue = ttiposeguimiento.Rows.Count > 0 ? ttiposeguimiento.Rows[0]["ID_Tipo_seguimiento"] : null;

            ID_Tipo_SeguimientoTextEdit.Properties.View.Columns.Clear();
            ID_Tipo_SeguimientoTextEdit.Properties.View.Columns.AddVisible("ID_Tipo_seguimiento", "Codigo");
            ID_Tipo_SeguimientoTextEdit.Properties.View.Columns.AddVisible("Detalle_Tipo_seguimiento", "Tipo Seguimiento");
            ID_Tipo_SeguimientoTextEdit.Properties.View.BestFitColumns();

            //contacto
            DataTable contactos = objcontacto.GetAllContactos();
            ID_ContactoTextEdit.Properties.DataSource = contactos;
            ID_ContactoTextEdit.Properties.ValueMember = "ID_Contacto";
            ID_ContactoTextEdit.Properties.DisplayMember = "NombreCompleto";
            ID_ContactoTextEdit.EditValue = contactos.Rows.Count > 0 ? contactos.Rows[0]["ID_Contacto"] : null;

            ID_ContactoTextEdit.Properties.View.Columns.Clear();
            ID_ContactoTextEdit.Properties.View.Columns.AddVisible("ID_Contacto", "Codigo");
            ID_ContactoTextEdit.Properties.View.Columns.AddVisible("NombreCompleto", "Nombre Completo");
            ID_ContactoTextEdit.Properties.View.BestFitColumns();

            //cliejte
            HpResergerNube.CRM_ClienteRepository ocliente = new HpResergerNube.CRM_ClienteRepository();
            DataTable Tcliente = ocliente.FilterClientesByDateRange(DateTime.MinValue,DateTime.MaxValue);
            cbocliente.Properties.DataSource = Tcliente;
            cbocliente.Properties.ValueMember = "ID_Cliente";
            cbocliente.Properties.DisplayMember = "nombrecompleto";
            cbocliente.EditValue = Tcliente.Rows.Count > 0 ? Tcliente.Rows[0]["ID_Cliente"] : null;

            cbocliente.Properties.View.Columns.Clear();
            cbocliente.Properties.View.Columns.AddVisible("ID_Contacto", "Codigo");
            cbocliente.Properties.View.Columns.AddVisible("nombrecompleto", "Nombre Completo");
            cbocliente.Properties.View.BestFitColumns();

        }
    }
}
