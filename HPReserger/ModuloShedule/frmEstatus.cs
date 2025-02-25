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
    public partial class frmEstatus : XtraForm
    {
        public frmEstatus()
        {
            InitializeComponent();
        }
        public static DataTable GetTablaEstado()
        {
            DataTable table = new DataTable("Tdata");
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Heredar", typeof(string));

            table.Rows.Add(0, "No Arrastrar Tarea");
            table.Rows.Add(1, "Arrastrar Tarea");

            return table;
        }
        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmEstatus_Load(object sender, EventArgs e)
        {
            DataTable tstatus = GetTablaEstado();
            repositoryItemSearchLookUpEdit4.DataSource = tstatus;
            repositoryItemSearchLookUpEdit4.ValueMember = "Id";
            repositoryItemSearchLookUpEdit4.DisplayMember = "Heredar";
            repositoryItemSearchLookUpEdit4.NullText = tstatus.Rows.Count > 0 ? tstatus.Rows[0]["Heredar"].ToString() : null;

            Cargardatos();
           
        }

        private void Cargardatos()
        {
            HpResergerNube.SCH_Status oClase = new HpResergerNube.SCH_Status();
            gridControl1.DataSource = oClase.GetAllStatus();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HpResergerNube.SCH_Status oclase = new HpResergerNube.SCH_Status();
            if (oclase.InsertStatus(oclase))
            {
                Cargardatos();
                XtraMessageBox.Show("Registro insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("No se pudo insertar el registro. Verifique los datos e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle < 0) return; // Verifica que la fila es válida

            try
            {
                int fila = e.RowHandle;
                int id = Convert.ToInt32(gridView1.GetRowCellValue(fila, "ID_Status"));
                string detalleStatus = gridView1.GetRowCellValue(fila, "Detalle_Status")?.ToString().Trim() ?? string.Empty;
                int importar = Convert.ToInt32(gridView1.GetRowCellValue(fila, "importar"));

                HpResergerNube.SCH_Status oclase = new HpResergerNube.SCH_Status
                {
                    ID_Status = id,
                    Detalle_Status = detalleStatus,
                    Importar = importar
                };

                if (!oclase.UpdateStatus(oclase))
                {
                    XtraMessageBox.Show("No se pudo actualizar el registro. Verifique los datos e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cargardatos();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Ocurrió un error al actualizar el registro:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            var Fila = gridView1.GetFocusedDataRow();
            if (Fila == null)
            {
                XtraMessageBox.Show("No se ha seleccionado ningún registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = XtraMessageBox.Show($"¿Está seguro de que desea eliminar este registro: {Fila[1]}?", "Confirmar eliminación",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                HpResergerNube.SCH_Status crud = new HpResergerNube.SCH_Status();
                bool eliminado = crud.DeleteStatus((int)Fila[0]);

                if (eliminado)
                {
                    //XtraMessageBox.Show("La operación se realizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargardatos();
                }
                else
                {
                    XtraMessageBox.Show("Hubo un error al intentar el proceso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
