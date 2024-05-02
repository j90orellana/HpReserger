using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraPrinting;
using HpResergerNube;
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

namespace SISGEM.CRM
{
    public partial class frmSegumiento : Form
    {
        internal string _idproyecto;
        internal int dias;
        internal int VerTodoslosRegistros;

        public int CodigoUsuario { get; internal set; }
        public DateTime FechaHoy { get; internal set; }

        public frmSegumiento()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmSegumiento_Load(object sender, EventArgs e)
        {
            dtpFechade.EditValue = HpResergerNube.DLConexion.ObtenerPrimerDiaDelMes(DateTime.Now);
            dtpFechaa.EditValue = HpResergerNube.DLConexion.ObtenerUltimoDiaDelMes(DateTime.Now);
            CargarCombos();

            if (_idproyecto != null)
            {
                ID_ProyectoTextEdit.EditValue = _idproyecto;
            }

            if (CodigoUsuario != 0)
            {
                Usuario_CreacionTextEdit.EditValue = CodigoUsuario;
                dtpFechade.EditValue = DateTime.Now.AddDays(dias);
                dtpFechaa.EditValue = DateTime.Now.AddDays(dias);
            }
            CargarDatos();
        }
        private void CargarCombos()
        {
            CRM_ProyectoRepository proyectoRepository = new CRM_ProyectoRepository();
            CRM_Usuario crmUsuario = new CRM_Usuario();
            DataTable proyectosConTodos = proyectoRepository.GetAllProyectosConTodos();
            this.ID_ProyectoTextEdit.Properties.DataSource = (object)proyectosConTodos;
            this.ID_ProyectoTextEdit.Properties.ValueMember = "id_proyecto";
            this.ID_ProyectoTextEdit.Properties.DisplayMember = "nombre_proyecto";
            this.ID_ProyectoTextEdit.EditValue = proyectosConTodos.Rows.Count > 0 ? proyectosConTodos.Rows[0]["id_proyecto"] : (object)null;
            this.ID_ProyectoTextEdit.Properties.View.Columns.Clear();
            this.ID_ProyectoTextEdit.Properties.View.Columns.AddVisible("id_proyecto", "ID");
            this.ID_ProyectoTextEdit.Properties.View.Columns.AddVisible("nombre_proyecto", "Nombre Proyecto");
            this.ID_ProyectoTextEdit.Properties.View.BestFitColumns();
            DataTable usuariosConTodos = crmUsuario.GetAllUsuariosConTodos();
            this.Usuario_CreacionTextEdit.Properties.DataSource = (object)usuariosConTodos;
            this.Usuario_CreacionTextEdit.Properties.ValueMember = "id_usuario";
            this.Usuario_CreacionTextEdit.Properties.DisplayMember = "nombre_completo";
            this.Usuario_CreacionTextEdit.EditValue = usuariosConTodos.Rows.Count > 0 ? usuariosConTodos.Rows[0]["ID_Usuario"] : (object)null;
            this.Usuario_CreacionTextEdit.Properties.View.Columns.Clear();
            this.Usuario_CreacionTextEdit.Properties.View.Columns.AddVisible("id_usuario", "ID");
            this.Usuario_CreacionTextEdit.Properties.View.Columns.AddVisible("nombre_completo", "Nombre Completo");
            this.Usuario_CreacionTextEdit.Properties.View.BestFitColumns();
        }
        private void CargarDatos()
        {
            if (VerTodoslosRegistros == 1)
            {
                this.gridControl2.DataSource = (object)new CRM_SeguimientoRepository().FilterSeguimientosByDateRange(((DateTime)this.dtpFechade.EditValue).Date, ((DateTime)this.dtpFechaa.EditValue).Date, this.Usuario_CreacionTextEdit.EditValue != null ? this.Usuario_CreacionTextEdit.EditValue.ToString() : "0", this.ID_ProyectoTextEdit.EditValue != null ? this.ID_ProyectoTextEdit.EditValue.ToString() : "0");
            }
            else
                this.gridControl2.DataSource = (object)new CRM_SeguimientoRepository().FilterSeguimientosByDateRangeUnicos(((DateTime)this.dtpFechade.EditValue).Date, ((DateTime)this.dtpFechaa.EditValue).Date, this.Usuario_CreacionTextEdit.EditValue != null ? this.Usuario_CreacionTextEdit.EditValue.ToString() : "0", this.ID_ProyectoTextEdit.EditValue != null ? this.ID_ProyectoTextEdit.EditValue.ToString() : "0");
        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportarGridControlAExcel(gridControl2);

        }
        public void ExportarGridControlAExcel(GridControl gridControl)
        {
            // Preguntar al usuario la ubicación de guardado
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Reporte Seguimientos.xlsx";
            saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (this.layoutView1 == null)
                        return;
                    this.layoutView1.ExportToXlsx(saveFileDialog.FileName);
                    int num = (int)XtraMessageBox.Show("Los datos se han exportado exitosamente a Excel.", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Process.Start(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    int num = (int)XtraMessageBox.Show("Hubo un error al exportar los datos a Excel: " + ex.Message, "Error de Exportación", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                int num1 = (int)XtraMessageBox.Show("La exportación ha sido cancelada.", "Operación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            if (!(sender is LayoutView layoutView) || layoutView.FocusedRowHandle < 0 || layoutView.FocusedColumn == null)
                return;
            object rowCellValue = layoutView.GetRowCellValue(layoutView.FocusedRowHandle, "ID_Seguimiento");
            Decimal result;
            if (rowCellValue != null && Decimal.TryParse(rowCellValue.ToString(), out result))
            {
                frmAddSeguimiento frmAddSeguimiento = new frmAddSeguimiento();
                frmAddSeguimiento._idseguimiento = result;
                frmAddSeguimiento.Show();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CargarDatos();



        }
    }
}
