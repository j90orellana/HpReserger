using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports;
using System.Collections.Generic;
using HpResergerNube;
using System.Linq;

namespace SISGEM.ModuloXtraReports.Contable
{
    public partial class XtraReportEstadoResultadoFinanciera : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportEstadoResultadoFinanciera()
        {
            InitializeComponent();
        }

        private void xrTableCell_TotalPasivoPatrimonio_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {

            IReport report = this;

            // Filtra los datos del DataSource del CrossTab
            var datos = this.DataSource as IEnumerable<Contabilidad>;

            if (datos != null)
            {
                var total = datos
                    .Where(d => d.LUGAR == "PASIVO" || d.LUGAR == "PATRIMONIO")
                    .Sum(d => d.CONTABLE);

                ((XRControl)sender).Text = Math.Abs(total).ToString("0:#,##0;(#,##0);-");
            }
        }
    }
}
