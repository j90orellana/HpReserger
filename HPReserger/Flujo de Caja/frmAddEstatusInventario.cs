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

namespace SISGEM.Flujo_de_Caja
{
    public partial class frmAddEstatusInventario : Form
    {
        public frmAddEstatusInventario()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPResergerCapaLogica.FlujoCaja.EstatusInventario cPartidas = new HPResergerCapaLogica.FlujoCaja.EstatusInventario();

            cPartidas.Descripcion = "Estatus para artículos nuevos";
            cPartidas.Estatus = "Nuevo";
            cPartidas.UsuarioCreacion = HPReserger.frmLogin.CodigoUsuario;
            if (cPartidas.Insertar(cPartidas) == 0)
            {
                XtraMessageBox.Show($"Error al Crear el Registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            CargarDatos();
        }

        private void btnRecargaCombos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CargarDatos();
        }
        int idFocus = 0;
        string nombreFocus = string.Empty;
        private void btnEliminarFila_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Obtén el índice de la fila seleccionada
            int focusedRowHandle = gridView1.FocusedRowHandle;

            // Verifica si la fila es válida y contiene datos
            if (focusedRowHandle >= 0 && gridView1.IsDataRow(focusedRowHandle))
            {
                // Obtén el valor de "id" de manera segura
                object idValue = gridView1.GetRowCellValue(focusedRowHandle, "IdEstatusInventario");
                idFocus = idValue is int ? (int)idValue : 0;
                object descripcionValue = gridView1.GetRowCellValue(focusedRowHandle, "Descripcion");
                nombreFocus = descripcionValue as string ?? string.Empty;

            }
            if (idFocus != 0)
            {
                var result = XtraMessageBox.Show($"¿Está seguro de eliminar esta fila ({nombreFocus})?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var cEstatus = new HPResergerCapaLogica.FlujoCaja.EstatusInventario();
                    if (cEstatus.EliminarLogico(idFocus))
                    {
                        XtraMessageBox.Show("Eliminación lógica completada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    else
                    {
                        XtraMessageBox.Show("Error al eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Operación cancelada por el usuario.", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void frmAddEstatusInventario_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            HPResergerCapaLogica.FlujoCaja.EstatusInventario cestatus = new HPResergerCapaLogica.FlujoCaja.EstatusInventario();
            gridControl1.DataSource = cestatus.ObtenerTodos();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            // Obtener los valores de la fila actual
            var rowHandle = e.RowHandle;
            int id = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "IdEstatusInventario"));
            string estatus = gridView1.GetRowCellValue(rowHandle, "Estatus").ToString();
            string descripcion = (gridView1.GetRowCellValue(rowHandle, "Descripcion").ToString());
            int usuario = HPReserger.frmLogin.CodigoUsuario;
            DateTime fecha = DateTime.Now;

            HPResergerCapaLogica.FlujoCaja.EstatusInventario cEstatus = new HPResergerCapaLogica.FlujoCaja.EstatusInventario();

            cEstatus.IdEstatusInventario = id;
            cEstatus.Estatus = estatus;
            cEstatus.Descripcion = descripcion;
            cEstatus.UsuarioCreacion = usuario;
            cEstatus.FechaCreacion = fecha;

            if (!cEstatus.Actualizar(cEstatus))
            {
                XtraMessageBox.Show($"Error al Actualizar el Registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
