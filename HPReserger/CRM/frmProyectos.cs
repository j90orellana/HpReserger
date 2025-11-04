using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HpResergerNube;

namespace SISGEM.CRM
{
    public partial class frmProyectos : XtraForm
    {
        private string idProyecto = "";

        public frmProyectos()
        {
            InitializeComponent();
        }

        private void frmProyectos_Load(object sender, EventArgs e)
        {

            CargarCombos();
            dtpFechade.EditValue = HpResergerNube.DLConexion.ObtenerPrimerDiaDelMes(DateTime.Now);
            dtpFechaa.EditValue = HpResergerNube.DLConexion.ObtenerUltimoDiaDelMes(DateTime.Now);
            CargarDatos();
        }

        private void CargarCombos()
        {
            //Usuarios
            CRM_Usuario crmUsuario = new CRM_Usuario();
            DataTable usuariosConTodos = crmUsuario.GetAllUsuariosConTodos();
            this.Usuario_CreacionTextEdit.Properties.DataSource = (object)usuariosConTodos;
            this.Usuario_CreacionTextEdit.Properties.ValueMember = "id_usuario";
            this.Usuario_CreacionTextEdit.Properties.DisplayMember = "nombre_completo";
            this.Usuario_CreacionTextEdit.EditValue = usuariosConTodos.Rows.Count > 0 ? usuariosConTodos.Rows[0]["ID_Usuario"] : (object)null;
            this.Usuario_CreacionTextEdit.Properties.View.Columns.Clear();
            this.Usuario_CreacionTextEdit.Properties.View.Columns.AddVisible("id_usuario", "ID");
            this.Usuario_CreacionTextEdit.Properties.View.Columns.AddVisible("nombre_completo", "Nombre Completo");
            this.Usuario_CreacionTextEdit.Properties.View.BestFitColumns();

            //CLIENTE
            HpResergerNube.CRM_ClienteRepository ocliente = new HpResergerNube.CRM_ClienteRepository();
            DataTable Tcliente = ocliente.FilterClientesByDateRange(DateTime.MinValue, DateTime.MaxValue);
            // Crear una nueva fila con el ID_Cliente 0 y nombre "Todos"
            DataRow newRow = Tcliente.NewRow();
            newRow["ID_Cliente"] = 0;
            newRow["nombrecompleto"] = "Todos";

            // Agregar la nueva fila al DataTable
            Tcliente.Rows.InsertAt(newRow, 0);
            ID_Tipo_personaTextEdit.Properties.DataSource = Tcliente;
            ID_Tipo_personaTextEdit.Properties.ValueMember = "ID_Cliente";
            ID_Tipo_personaTextEdit.Properties.DisplayMember = "nombrecompleto";
            ID_Tipo_personaTextEdit.EditValue = Tcliente.Rows.Count > 0 ? Tcliente.Rows[0]["ID_Cliente"] : null;

            ID_Tipo_personaTextEdit.Properties.View.Columns.Clear();
            ID_Tipo_personaTextEdit.Properties.View.Columns.AddVisible("ID_Contacto", "Codigo");
            ID_Tipo_personaTextEdit.Properties.View.Columns.AddVisible("ID_Numero_Doc", "Número Documento");
            ID_Tipo_personaTextEdit.Properties.View.Columns.AddVisible("nombrecompleto", "Nombre Completo");
            ID_Tipo_personaTextEdit.Properties.View.BestFitColumns();

            //estado
            HpResergerNube.CRM_EstadoRepository objestado = new HpResergerNube.CRM_EstadoRepository();

            DataTable testado = objestado.GetAllEstados();
            // Crear una nueva fila con el ID_Cliente 0 y nombre "Todos"
            DataRow newRowe = testado.NewRow();
            newRowe["ID_Estado"] = 0;
            newRowe["Detalle_Estado"] = "Todos";
            testado.Rows.InsertAt(newRowe, 0);

            ID_EstadoTextEdit.Properties.DataSource = testado;
            ID_EstadoTextEdit.Properties.DisplayMember = "Detalle_Estado";
            ID_EstadoTextEdit.Properties.ValueMember = "ID_Estado";
            ID_EstadoTextEdit.EditValue = testado.Rows.Count > 0 ? testado.Rows[0]["ID_Estado"] : null;

            ID_EstadoTextEdit.Properties.View.Columns.Clear();
            ID_EstadoTextEdit.Properties.View.Columns.AddVisible("ID_Estado", "Codigo");
            ID_EstadoTextEdit.Properties.View.Columns.AddVisible("Detalle_Estado", "Estado");
            ID_EstadoTextEdit.Properties.View.BestFitColumns();
        }

        private void CargarDatos()
        {

            HpResergerNube.CRM_ProyectoRepository objproyecto = new HpResergerNube.CRM_ProyectoRepository();
            DateTime fechaInicio = ((DateTime?)dtpFechade.EditValue)?.Date ?? DateTime.Now.Date;
            DateTime fechaFin = ((DateTime?)dtpFechaa.EditValue)?.Date ?? DateTime.Now.Date;
            string tipoPersona = ID_Tipo_personaTextEdit.EditValue?.ToString() ?? "0";
            string usuarioCreacion = Usuario_CreacionTextEdit.EditValue?.ToString() ?? "0";
            string estadoproyecto = ID_EstadoTextEdit.EditValue?.ToString() ?? "0";

            xNombre_Proyecto.MaxWidth = 250;
            xDireccion.MaxWidth = 250;
            xNombre_Cliente.MaxWidth = 250;


            gridControl3.DataSource = objproyecto.FilterProyectosByDateRange(fechaInicio, fechaFin, tipoPersona, usuarioCreacion, estadoproyecto);

            gridView3.BestFitColumns();
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        public void ExportarGridControlAExcel(GridControl gridControl)
        {
            // Preguntar al usuario la ubicación de guardado
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Reporte Proyectos.xlsx";
            saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Exportar los datos del GridControl a un archivo de Excel
                    GridView gridView = (GridView)gridControl.MainView;
                    gridView.ExportToXlsx(saveFileDialog.FileName, new XlsxExportOptions() { ExportMode = XlsxExportMode.SingleFile });

                    // Mostrar un mensaje de éxito
                    XtraMessageBox.Show("Los datos se han exportado exitosamente a Excel.", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir el archivo de Excel guardado
                    Process.Start(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje en caso de error
                    XtraMessageBox.Show("Hubo un error al exportar los datos a Excel: " + ex.Message, "Error de Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar mensaje si el usuario cancela
                XtraMessageBox.Show("La exportación ha sido cancelada.", "Operación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportarGridControlAExcel(gridControl3);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            CargarDatos();
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null && view.FocusedRowHandle >= 0 && view.FocusedColumn != null)
            {
                object cellValue = view.GetRowCellValue(view.FocusedRowHandle, xID_Proyecto.FieldName);
                frmAddProyecto xproyecto = new frmAddProyecto();
                xproyecto._idProyecto = cellValue.ToString();
                xproyecto.Show();
            }
        }

        private void gridView3_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            GridView view = sender as GridView;

            // Verificar si se ha hecho clic en una fila válida
            if (e.RowHandle >= 0)

            {
                // Obtener el valor de la celda en la columna 1 de la fila seleccionada
                object cellValue = view.GetRowCellValue(e.RowHandle, view.Columns[xID_Proyecto.FieldName]); // Cambia 1 por el índice de la columna deseada
                if (cellValue != null)
                {
                    // Hacer algo con el valor de la celda
                    idProyecto = cellValue.ToString();

                }
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idProyecto != "")
            {
                // Crear una instancia del formulario de seguimiento
                CRM.frmSegumiento formularioSeguimiento = new frmSegumiento();

                // Configurar propiedades del formulario de seguimiento
                formularioSeguimiento._idproyecto = idProyecto;
                formularioSeguimiento.MdiParent = this.MdiParent;
                formularioSeguimiento.Text = "Viendo Todos los Seguimientos de los Proyectos";
                formularioSeguimiento.VerTodoslosRegistros = 1;

                // Mostrar el formulario de seguimiento
                formularioSeguimiento.Show();

            }
            else
            {
                XtraMessageBox.Show("Por favor, selecciona un proyecto antes de continuar.", "Proyecto no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
