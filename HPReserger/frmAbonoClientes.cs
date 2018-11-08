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

namespace HPReserger
{
    public partial class frmAbonoClientes : FormGradient
    {
        public frmAbonoClientes()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmAbonoClientes_Load(object sender, EventArgs e)
        {
            CargarMoneda();
        }
        public void CargarMoneda()
        {
            DataTable TMoneda = CapaLogica.InsertarActualizarMoneda();
            cbomoneda.DisplayMember = "descripcion";
            cbomoneda.ValueMember = "codigo";
            cbomoneda.DataSource = TMoneda;
        }
    }
}
