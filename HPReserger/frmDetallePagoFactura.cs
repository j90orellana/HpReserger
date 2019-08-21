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
        public frmDetallePagoFactura(int opcion, string numero, int tipoid, string proveedors, int idcomprobante, int empresa,string glosa)
        {
            InitializeComponent();
            numfac = numero;
            proveedor = proveedors;
            Opcion = opcion;
            Tipoid = tipoid;
            Idcomprobante = idcomprobante;
            Empresa = empresa;
            Glosa = glosa;
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private string _numfac;
        private int _tipoid;
        private int _idcomprobante;
        public int Idcomprobante { get { return _idcomprobante; } set { _idcomprobante = value; } }
        public string numfac { get { return _numfac; } set { _numfac = value; } }
        public string Glosa { get { return txtglosa.Text; } set { txtglosa.Text = value; } }
        public int Tipoid { get { return _tipoid; } set { _tipoid = value; } }
        private string _proveedor;
        public int Opcion;
        public int Empresa;
        public string proveedor { get { return _proveedor; } set { _proveedor = value; txtproveedor.Text = _proveedor; } }
        private void frmDetallePagoFactura_Load(object sender, EventArgs e)
        {
            dtgconten1.DataSource = CapaLogica.ListarAbonosFacturas(Opcion, _numfac, _tipoid, _proveedor, _idcomprobante, Empresa);
            if (Opcion != 1)
            {
                label2.Text = "Cliente";
                dtgconten1.Columns[proveedorx.Name].HeaderText = "Numdoc";
                dtgconten1.Columns[razonsocialx.Name].HeaderText = "Nombres";
                Text = "Detalle de Abono de Clientes";
                dtgconten1.Columns[subtotalx.Name].Visible = false;
                dtgconten1.Columns[igvx.Name].Visible = false;
            }
            lblmsg.Text = $"Total Registros: {dtgconten1.RowCount}";
        }
    }
}
