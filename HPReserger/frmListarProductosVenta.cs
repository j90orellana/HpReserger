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
    public partial class frmListarProductosVenta : FormGradient
    {
        public frmListarProductosVenta()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmListarProductosVenta_Load(object sender, EventArgs e)
        {
            CargarDatos();
            Codigos = new List<int>();
        }
        private int? codProd = null;
        public int? CodigoProducto
        {
            get { return codProd; }
            set { codProd = value; }
        }
        public List<int> Codigos;
        public void CargarDatos()
        {
            dtgconten1.DataSource = CapaLogica.ListarProductosVender(txtBuscar.TextoValido());
        }
        private void txtBuscar_BuscarTextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void dtgconten1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten1.RowCount > 0)
            {
                List<int> cadena = new List<int>();
                foreach (DataGridViewRow item in dtgconten1.SelectedRows)
                {
                    cadena.Add((int)item.Cells[Id_Proy_Prod.Name].Value);
                }
                if (cadena.Count > 0)
                {
                    //HPResergerFunciones.Utilitarios.msg(string.Join(",", cadena.ToArray()));
                    Codigos = cadena;
                }
            }
            this.Close();
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            dtgconten1_CellDoubleClick(sender, new DataGridViewCellEventArgs(0, 0));
            this.Close();
        }
        private void txtBuscar_Load(object sender, EventArgs e)
        {

        }
    }
}
