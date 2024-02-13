﻿using DevExpress.XtraEditors;
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
    public partial class frmAddProyecto : Form
    {
        public frmAddProyecto()
        {
            InitializeComponent();
        }
        HpResergerNube.Proyecto oProyecto = new HpResergerNube.Proyecto();
        public string _idProyecto = "";
        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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
            ID_ContactoTextEdit.Properties.View.Columns.AddVisible("NombreCompleto", "Nombre Completo");
            ID_ContactoTextEdit.Properties.View.BestFitColumns();

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

            RecargarContacto();

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


        }
        private void frmAddProyecto_Load(object sender, EventArgs e)
        {
            CargarCombos();
            HpResergerNube.CRM_ProyectoRepository objproyecto = new HpResergerNube.CRM_ProyectoRepository();
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
                ID_ContactoTextEdit.EditValue = oProyecto.ID_Contacto;
                ArchivoTextEdit.EditValue = oProyecto.Archivo;
                FotosTextEdit.EditValue = oProyecto.Fotos;

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
