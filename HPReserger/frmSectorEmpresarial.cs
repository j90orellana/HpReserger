using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmSectorEmpresarial : Form
    {
        HPResergerCapaLogica.HPResergerCL clSectorEmpresarial = new HPResergerCapaLogica.HPResergerCL();
        public frmSectorEmpresarial()
        {
            InitializeComponent();
        }

        private void frmSectorEmpresarial_Load(object sender, EventArgs e)
        {

        }
    }
}
