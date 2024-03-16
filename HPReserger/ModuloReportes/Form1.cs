using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISGEM.ModuloReportes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
            pivotGridControl1.DataSource = CapaLogica.Empresa();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            const string path = @"D:\empresas.xlsx";
            pivotGridControl1.ExportToXlsx(path, new XlsxExportOptionsEx
            {
                AllowGrouping = DevExpress.Utils.DefaultBoolean.False,
                AllowFixedColumnHeaderPanel = DevExpress.Utils.DefaultBoolean.True
            });
            System.Diagnostics.Process.Start(path);
        }
    }
}
