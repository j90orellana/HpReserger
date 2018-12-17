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
            Codigos = new List<int>();
            CargarEmpresa();
            cboempresa.SelectedIndex = cboproyecto.SelectedIndex = 0;
            CargarDatos("");
        }
        public void CargarEmpresa()
        {
            DataTable TEmpresa = CapaLogica.ListarEmpresas();
            DataRow fila = TEmpresa.NewRow();
            fila[0] = 0; fila[1] = "Todas";
            TEmpresa.Rows.InsertAt(fila, 0);
            cboempresa.DisplayMember = "empresa";
            cboempresa.ValueMember = "id_empresa";
            cboempresa.DataSource = TEmpresa;
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
            dtgconten1.DataSource = CapaLogica.ListarProductosVender(txtBuscar.TextoValido(), (int)cboempresa.SelectedValue, (int)cboproyecto.SelectedValue);
        }
        public void CargarDatos(string cadena)
        {
            dtgconten1.DataSource = CapaLogica.ListarProductosVender(txtBuscar.TextoValido(), 0, 0);
            lblmsg.Text = $"Total de Registros : {dtgconten1.RowCount}";
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

        private void cboempresa_Click(object sender, EventArgs e)
        {
            string cadena = cboempresa.Text;
            CargarEmpresa();
            cboempresa.Text = cadena;
        }
        private void cboproyecto_Click(object sender, EventArgs e)
        {
            string cadena = cboproyecto.Text;
            cboempresa_SelectedIndexChanged(sender, e);
            cboproyecto.Text = cadena;
        }
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable TProyecto = CapaLogica.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString());
            DataRow fila = TProyecto.NewRow();
            fila[0] = 0; fila[1] = "Todos";
            TProyecto.Rows.InsertAt(fila, 0);
            cboproyecto.DisplayMember = "proyecto";
            cboproyecto.ValueMember = "id_proyecto";
            cboproyecto.DataSource = TProyecto;
        }
        private void cboproyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
