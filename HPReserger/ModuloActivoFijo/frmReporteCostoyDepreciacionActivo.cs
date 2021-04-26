using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger.ModuloActivoFijo
{
    public partial class frmReporteCostoyDepreciacionActivo : FormGradient
    {
        public frmReporteCostoyDepreciacionActivo()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private int idempresa;
        private void frmReporteCostoyDepreciacionActivo_Load(object sender, EventArgs e)
        {
            CargarEmpresa();
            cbodesde.Fecha(new DateTime(DateTime.Now.Year, 1, 1));
        }
        public void CargarEmpresa()
        {
            CapaLogica.TablaEmpresas(cboempresa);
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
