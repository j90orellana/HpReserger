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

namespace SISGEM.ModuloShedule
{
    public partial class frmAddObjetivosProyectos : XtraForm
    {
        private string _idcliente;
        public int _idestrate;

        public frmAddObjetivosProyectos()
        {
            InitializeComponent();
        }
        public frmAddObjetivosProyectos(string idcliente, int idestrate)
        {
            InitializeComponent();
            _idcliente = idcliente;
            _idestrate = idestrate;
        }
        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Validaciones
         

            if (string.IsNullOrWhiteSpace(DetalleObjetivoTextEdit.EditValue?.ToString()))
            {
                XtraMessageBox.Show("El campo Detalle del Objetivo no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(ResponsableTextEdit.EditValue?.ToString()))
            {
                XtraMessageBox.Show("El campo Responsable no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(StatusTextEdit.EditValue?.ToString()))
            {
                XtraMessageBox.Show("El campo Status no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(NombreTextEdit.EditValue?.ToString()))
            {
                XtraMessageBox.Show("El campo Nombre no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (FechaRecordatorioDateEdit.EditValue == null || !(FechaRecordatorioDateEdit.EditValue is DateTime))
            {
                XtraMessageBox.Show("El campo Fecha de Recordatorio no puede estar vacío y debe ser una fecha válida.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ObjetivoRelacionadoTextEdit.EditValue == null || !int.TryParse(ObjetivoRelacionadoTextEdit.EditValue.ToString(), out int objetivoRelacionado))
            {
                XtraMessageBox.Show("El campo Objetivo Relacionado no puede estar vacío y debe ser un número entero.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            HpResergerNube.SCH_Estrate_Objetivos_Operativos objclase = new HpResergerNube.SCH_Estrate_Objetivos_Operativos();

            objclase.Comentario = ComentarioTextEdit.EditValue?.ToString() ?? string.Empty;
            objclase.DetalleObjetivo = DetalleObjetivoTextEdit.EditValue.ToString();
            objclase.Responsable = ResponsableTextEdit.EditValue.ToString();
            objclase.Status = StatusTextEdit.EditValue.ToString();
            objclase.Estado = 1;
            objclase.FechaCreacion = DateTime.Now;
            objclase.FechaRecordatorio = (DateTime)FechaRecordatorioDateEdit.EditValue;
            objclase.FkId = _idestrate;
            objclase.ObjetivoRelacionado = (int)ObjetivoRelacionadoTextEdit.EditValue;
            objclase.Nombre = NombreTextEdit.Text.ToString();


            objclase.InsertObjetivoOperativo(objclase);

            XtraMessageBox.Show("Datos guardados con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            HpResergerNube.SCH_Estrate_Objetivos_Operativos objDetalles = new HpResergerNube.SCH_Estrate_Objetivos_Operativos();
            DialogForm form = new DialogForm("Agregar Proyecto", "Nombre Proyecto", DialogForm.Tipo.detalle, _idcliente, _idestrate);
            form.ShowDialog();
            CargarProyectos();
        }

        private void frmAddObjetivosProyectos_Load(object sender, EventArgs e)
        {
            CargarProyectos();
            CargarStatus();
            CargarObjetivosRelacionados();
            CargarUsuarios();

            FechaRecordatorioDateEdit.EditValue = DateTime.Now.AddDays(1);
        }

        private void CargarUsuarios()
        {
            HpResergerNube.CRM_Usuario objclase = new HpResergerNube.CRM_Usuario();

            DataTable tusuario = objclase.GetAllUsuarios();
            ResponsableTextEdit.Properties.DataSource = tusuario;
            ResponsableTextEdit.Properties.ValueMember = "ID_Usuario";
            ResponsableTextEdit.Properties.DisplayMember = "Nombre_Completo";
            ResponsableTextEdit.EditValue = tusuario.Rows.Count > 0 ? tusuario.Rows[0]["ID_Usuario"] : null;

            //ResponsableTextEdit.Properties.View.Columns.Clear();
            //ResponsableTextEdit.Properties.View.Columns.AddVisible("ID_Numero_Doc", "DNI");
            //ResponsableTextEdit.Properties.View.Columns.AddVisible("Nombre_Completo", "Nombre Completo");
            //ResponsableTextEdit.Properties.View.BestFitColumns();
        }

        private void CargarObjetivosRelacionados()
        {
            HpResergerNube.SCH_Estrate_Objetivos objclase = new HpResergerNube.SCH_Estrate_Objetivos();
            DataTable tobjetivos = objclase.GetEstrateObjetivosByFkIdEstrate(_idestrate);

            ObjetivoRelacionadoTextEdit.Properties.DataSource = tobjetivos;
            ObjetivoRelacionadoTextEdit.Properties.ValueMember = "id";
            ObjetivoRelacionadoTextEdit.Properties.DisplayMember = "nombre";
            ObjetivoRelacionadoTextEdit.EditValue = tobjetivos.Rows.Count > 0 ? tobjetivos.Rows[0]["id"] : null;

            ObjetivoRelacionadoTextEdit.Properties.View.Columns.Clear();
            //NombreTextEdit.Properties.View.Columns.AddVisible("ID_Tipo_Cliente", "Codigo");
            ObjetivoRelacionadoTextEdit.Properties.View.Columns.AddVisible("nombre", "Objetivo Relacionado");
            ObjetivoRelacionadoTextEdit.Properties.View.BestFitColumns();
        }


        private void CargarStatus()
        {
            HpResergerNube.SCH_Status objclase = new HpResergerNube.SCH_Status();
            DataTable tstatus = objclase.GetAllStatus();

            StatusTextEdit.Properties.DataSource = tstatus;
            StatusTextEdit.Properties.ValueMember = "ID_Status";
            StatusTextEdit.Properties.DisplayMember = "Detalle_Status";
            StatusTextEdit.EditValue = tstatus.Rows.Count > 0 ? tstatus.Rows[0]["ID_Status"] : null;

            StatusTextEdit.Properties.View.Columns.Clear();
            //NombreTextEdit.Properties.View.Columns.AddVisible("ID_Tipo_Cliente", "Codigo");
            StatusTextEdit.Properties.View.Columns.AddVisible("Detalle_Status", " Status Proyecto");
            StatusTextEdit.Properties.View.BestFitColumns();
        }

        private void CargarProyectos()
        {
            HpResergerNube.SCH_Estrate_Objetivos_Operativos objclase = new HpResergerNube.SCH_Estrate_Objetivos_Operativos();
            DataTable Tdetalle = objclase.GetObjetivosOperativosByFkIdNombre(_idestrate);

            NombreTextEdit.Properties.DataSource = Tdetalle;
            NombreTextEdit.Properties.ValueMember = "id";
            NombreTextEdit.Properties.DisplayMember = "Nombre";
            NombreTextEdit.EditValue = Tdetalle.Rows.Count > 0 ? Tdetalle.Rows[0]["id"] : null;

            NombreTextEdit.Properties.View.Columns.Clear();
            //NombreTextEdit.Properties.View.Columns.AddVisible("ID_Tipo_Cliente", "Codigo");
            NombreTextEdit.Properties.View.Columns.AddVisible("Nombre", "Nombre Proyecto");
            NombreTextEdit.Properties.View.BestFitColumns();
        }
    }
}
