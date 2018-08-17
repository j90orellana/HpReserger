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
    public partial class frmDetallePagoFactura : FormGradient
    {
        public frmDetallePagoFactura()
        {
            InitializeComponent();
        }
        public frmDetallePagoFactura(string numero,string proveedors)
        {
            InitializeComponent();
            numfac = numero;
            proveedor = proveedors;           
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private string _numfac;

        public string numfac
        {
            get { return _numfac; }
            set { _numfac = value;  }
        }
        private string _proveedor;

        public string proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; txtproveedor.Text = _proveedor; }
        }
        private void frmDetallePagoFactura_Load(object sender, EventArgs e)
        {
            dtgconten1.DataSource = CapaLogica.ListarAbonosFacturas(_numfac, _proveedor);
        }
    }
}
