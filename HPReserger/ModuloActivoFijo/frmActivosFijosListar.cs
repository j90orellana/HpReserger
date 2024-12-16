using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISGEM.ModuloActivoFijo
{
    public partial class frmActivosFijosListar : XtraForm
    {
        public frmActivosFijosListar()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SISGEM.ModuloActivoFijo.frmActivosFijosC frm = new ModuloActivoFijo.frmActivosFijosC();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnRecargaCombos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            HPResergerCapaLogica.Contable.ActivosFijos cClase = new HPResergerCapaLogica.Contable.ActivosFijos();
            var tActivo = cClase.GetAll();

            gridControl1.DataSource = tActivo;
        }

        private void frmActivosFijosListar_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null && view.FocusedRowHandle >= 0 && view.FocusedColumn != null)
            {
                object cellValue = view.GetRowCellValue(view.FocusedRowHandle, xId.FieldName);
                frmActivosFijosC xVentanaHijo = new frmActivosFijosC();
                int.TryParse(cellValue?.ToString() ?? string.Empty, out int id);
                if (id != 0)
                {
                    xVentanaHijo.Id = id;
                    xVentanaHijo.Show();
                }
                else
                {
                    XtraMessageBox.Show("No se encontró el Activo Fijo correspondiente. Se abrirá un nuevo registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}
