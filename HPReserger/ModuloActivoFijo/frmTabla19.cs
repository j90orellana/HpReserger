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

namespace SISGEM.ModuloAlmacen
{
    public partial class frmTabla19 : XtraForm
    {
        public frmTabla19()
        {
            InitializeComponent();
        }
        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmTabla18_Load(object sender, EventArgs e)
        {
            CargaDatos();

        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HPResergerCapaLogica.oEstadoActivoFijo oclase = new HPResergerCapaLogica.oEstadoActivoFijo
            {
                Pkid = 0,
                Nombre = "Nuevo",
                IdS = 0,
                Estado = 1
            };

            // Instanciar el CRUD y actualizar la base de datos
            HPResergerCapaLogica.T19EstadoActivoFijo crud = new HPResergerCapaLogica.T19EstadoActivoFijo();

            if (crud.Insert(oclase))
            {
                //XtraMessageBox.Show("La Operación se realizó con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargaDatos();
            }
            else
            {
                XtraMessageBox.Show("Hubo un error al intentar el Proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargaDatos()
        {
            HPResergerCapaLogica.T19EstadoActivoFijo oclasebaja = new HPResergerCapaLogica.T19EstadoActivoFijo();

            gridControl1.DataSource = oclasebaja.GetAll();
            gridView1.BestFitColumns();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            // Obtener los valores de la fila actual
            var rowHandle = e.RowHandle;
            int id = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "pkid"));
            string nombre = gridView1.GetRowCellValue(rowHandle, "Nombre").ToString();
            int idS = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "idS"));
            int estado = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "Estado"));
            int usuario = HPReserger.frmLogin.CodigoUsuario;
            DateTime fecha = DateTime.Now;

            // Actualizar en la base de datos
            HPResergerCapaLogica.oEstadoActivoFijo oclase = new HPResergerCapaLogica.oEstadoActivoFijo
            {
                Pkid = id,
                Nombre = nombre,
                IdS = idS,
                Estado = 1
            };
            // Instanciar el CRUD y actualizar la base de datos
            HPResergerCapaLogica.T19EstadoActivoFijo crud = new HPResergerCapaLogica.T19EstadoActivoFijo();
            if (id == 0)
            {
                crud.Insert(oclase);
                CargaDatos();
            }
            else
            {
                crud.Update(oclase);
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

            DialogResult result = XtraMessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar eliminación",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                HPResergerCapaLogica.T19EstadoActivoFijo crud = new HPResergerCapaLogica.T19EstadoActivoFijo();
                bool eliminado = crud.EliminarxEstado((int)Fila[0]);

                if (eliminado)
                {
                    //XtraMessageBox.Show("La operación se realizó con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargaDatos();
                }
                else
                {
                    XtraMessageBox.Show("Hubo un error al intentar el proceso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
