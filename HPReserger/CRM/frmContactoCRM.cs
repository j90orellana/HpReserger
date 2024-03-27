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

namespace SISGEM.CRM
{
    public partial class frmContactoCRM : Form
    {
        internal string _idcliente;

        public frmContactoCRM()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportarGridControlAExcel(gridControl2);
        }

        public void ExportarGridControlAExcel(GridControl gridControl)
        {
            // Preguntar al usuario la ubicación de guardado
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Reporte Contactos.xlsx";
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

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null && view.FocusedRowHandle >= 0 && view.FocusedColumn != null)
            {
                object cellValue = view.GetRowCellValue(view.FocusedRowHandle, xID_Contacto.FieldName);
                frmAddContacto xidcontacto = new frmAddContacto();
                xidcontacto._idcontacto = cellValue.ToString();
                xidcontacto.Show();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CargarDatos();

        }
        private void CargarDatos()
        {
            try
            {
                DateTime fechaInicio = ((DateTime)dtpFechade.EditValue).Date;
                DateTime fechaFin = ((DateTime)dtpFechaa.EditValue).Date;
                string clienteSeleccionado = cbocliente.EditValue?.ToString() ?? "0"; // Verificación de nulidad

                HpResergerNube.CRM_ContactoRepository objContacto = new HpResergerNube.CRM_ContactoRepository();
                var datosClientes = objContacto.FilterClientesByDateRange(fechaInicio, fechaFin, clienteSeleccionado);

                gridControl2.DataSource = datosClientes;
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Error al cargar los datos: " + ex.Message);
            }
        }

        private void frmContactoCRM_Load(object sender, EventArgs e)
        {
            CargarCombo();
            if (_idcliente != null)
            {
                cbocliente.EditValue = _idcliente;
            }
            dtpFechade.EditValue = HpResergerNube.DLConexion.ObtenerPrimerDiaDelMes(DateTime.Now);
            dtpFechaa.EditValue = HpResergerNube.DLConexion.ObtenerUltimoDiaDelMes(DateTime.Now);
            CargarDatos();
        }

        private void CargarCombo()
        {
            //cliejte
            HpResergerNube.CRM_ClienteRepository ocliente = new HpResergerNube.CRM_ClienteRepository();
            DataTable Tcliente = ocliente.GetAllClientesConTodos();
            cbocliente.Properties.DataSource = Tcliente;
            cbocliente.Properties.ValueMember = "id_cliente";
            cbocliente.Properties.DisplayMember = "nombre_completo";
            cbocliente.EditValue = Tcliente.Rows.Count > 0 ? Tcliente.Rows[0]["ID_Cliente"] : null;

            cbocliente.Properties.View.Columns.Clear();
            cbocliente.Properties.View.Columns.AddVisible("id_cliente", "Codigo");
            cbocliente.Properties.View.Columns.AddVisible("nombre_completo", "Nombre Completo");
            cbocliente.Properties.View.BestFitColumns();
        }
    }
}
