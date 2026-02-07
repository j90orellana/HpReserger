using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace SISGEM.ModuloFinanzas
{
    public partial class frmListadoMutuos : DevExpress.XtraEditors.XtraForm
    {
        public frmListadoMutuos()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmListadoMutuos_Load(object sender, EventArgs e)
        {
            dtpfecha.EditValue = DateTime.Now;

            // Mostrar solo Mes y Año en el campo
            dtpfecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtpfecha.Properties.DisplayFormat.FormatString = "yyyy";  // Ej: "Mayo 2025"

            dtpfecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtpfecha.Properties.EditFormat.FormatString = "yyyy";

            dtpfecha.Properties.Mask.EditMask = "yyyy";
            dtpfecha.Properties.Mask.UseMaskAsDisplayFormat = true;

            // Cambiar el tipo de vista del calendario a Vista de Meses (evita días)
            dtpfecha.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView;

            // Esto permite que el usuario solo elija el mes (de la vista anual)
            dtpfecha.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            dtpfecha.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;

            //gridView1.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", gridView1.Columns["Total"], "Suma: {0:n2}");
         

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var Cclase = new HPResergerCapaLogica.Finanzas.Mutuos();
            DateTime fechaSeleccionada = dtpfecha.EditValue as DateTime? ?? DateTime.Now;
            gridControl1.DataSource = Cclase.ListarMutuosxAño(fechaSeleccionada);
            gridView1.BestFitColumns();
                      

        }

        private void btnBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            simpleButton1.PerformClick();
        }

        private void btnDesAgrupar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.DataRowCount != 0)
            {
                gridView1.CollapseAllGroups();
            }
        }

        private void btnAgrupar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.DataRowCount != 0)
            {
                gridView1.ExpandAllGroups();
            }
        }

        private void btnAgruparEmpresa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Primero limpiamos agrupaciones anteriores
            gridView1.ClearGrouping();

            gridView1.Columns["empresa"].GroupIndex = 0;
        }

        private void btnAgruparEstado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Primero limpiamos agrupaciones anteriores
            gridView1.ClearGrouping();

            gridView1.Columns["empresa"].GroupIndex = 0;
            gridView1.Columns["estado"].GroupIndex = 1;
        }

        private void btnAgruparProveedor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Ejemplo: agrupar por Proveedor
            gridView1.ClearGrouping(); // Limpia agrupaciones previas

            gridView1.Columns["empresa"].GroupIndex = 0;
            gridView1.Columns["cliente"].GroupIndex = 1;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null && view.FocusedRowHandle >= 0 && view.FocusedColumn != null)
            {
                object cellValue = view.GetRowCellValue(view.FocusedRowHandle, xid.FieldName);
                var xformulariomutuos = new ModuloFinanzas.frmAddMutuos();
                xformulariomutuos.idMutuo = (int)cellValue;
                xformulariomutuos.MdiParent = this.MdiParent;
                xformulariomutuos.Show();
            }
        }
    }
}