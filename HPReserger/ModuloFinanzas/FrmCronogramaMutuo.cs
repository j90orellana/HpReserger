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

namespace SISGEM.ModuloFinanzas
{
    public partial class FrmCronogramaMutuo : DevExpress.XtraEditors.XtraForm
    {
        public bool MostrarEstado;

        public FrmCronogramaMutuo()
        {
            InitializeComponent();
        }
        public void CargarCronograma(DataTable tabla)
        {
            gridControl1.DataSource = tabla;
            gridView1.BestFitColumns();
        }
        public void CargarCronograma(List<HPResergerCapaLogica.Finanzas.Mutuos.MutuoCronogramaEntidad> tabla)
        {
            gridControl1.DataSource = tabla;
            gridView1.BestFitColumns();
        }

        private void FrmCronogramaMutuo_Load(object sender, EventArgs e)
        {

            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ColumnAutoWidth = false;

            gridView1.OptionsView.ShowFooter = true;

            gridView1.Columns["Amortizacion"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["Interes"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["Cuota"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["Impuesto"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["Transferencia"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;

            gridView1.Columns["Amortizacion"].SummaryItem.DisplayFormat = "{0:N2}";
            gridView1.Columns["Interes"].SummaryItem.DisplayFormat = "{0:N2}";
            gridView1.Columns["Cuota"].SummaryItem.DisplayFormat = "{0:N2}";
            gridView1.Columns["Impuesto"].SummaryItem.DisplayFormat = "{0:N2}";
            gridView1.Columns["Transferencia"].SummaryItem.DisplayFormat = "{0:N2}";

            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();

            xEstado.Visible = false;
            if (MostrarEstado) xEstado.Visible = true;
        }
    }
}