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

namespace HPReserger.ModuloCompensaciones
{
    public partial class frmListarCompensaciones : FormGradient
    {
        public frmListarCompensaciones()
        {
            InitializeComponent();
            CargarEmpresa();
            CargarTipoid();
            cbotipoid.SelectedIndex = 0;
            CargarCompensaciones();
        }
        public frmListarCompensaciones(int idempresa)
        {
            InitializeComponent();
            CargarCompensaciones();
            CargarEmpresa();
            CargarTipoid();
            cbotipoid.SelectedIndex = 0;
            IdEmpresa = idempresa;
            SacarDatos();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmListarCompensaciones_Load(object sender, EventArgs e)
        {

        }
        public void CargarEmpresa() { CapaLogica.TablaEmpresas(cboempresa); }
        public void CargarTipoid()
        {
            CapaLogica.TablaTipoID(cbotipoid);
            DataTable TableTipos = ((DataTable)cbotipoid.DataSource);
            DataRow fila = TableTipos.NewRow();
            fila["valor"] = "TODOS";
            fila["Codigo"] = 0;
            TableTipos.Rows.InsertAt(fila, 0);
        }
        public int IdEmpresa { get { return (int)cboempresa.SelectedValue; } set { cboempresa.SelectedValue = value; } }
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboempresa.SelectedValue != null)
                SacarDatos();
        }
        public void CargarCompensaciones()
        {
            DataTable ListCompensaciones = new DataTable();
            ListCompensaciones.Columns.Add("codigo", typeof(int));
            ListCompensaciones.Columns.Add("descripcion");
            ListCompensaciones.Rows.Add(0, "Todos");
            ListCompensaciones.Rows.Add(1, "Fondo Fijo");
            ListCompensaciones.Rows.Add(2, "Reembolso Gasto");
            ListCompensaciones.Rows.Add(3, "Entregas a Rendir");
            ListCompensaciones.Rows.Add(4, "Anticipo Proveedor");
            cbocompensa.ValueMember = "codigo";
            cbocompensa.DisplayMember = "descripcion";
            cbocompensa.DataSource = ListCompensaciones;
            cbocompensa.SelectedIndex = 0;
        }
        public void SacarDatos()
        {
            if (cbocompensa.SelectedValue == null) return;
            if (cbotipoid.SelectedValue == null) return;
            if (cbocompensa.SelectedValue == null) return;
            dtgconten.DataSource = CapaLogica.ListarCompensaciones(IdEmpresa, (int)cbocompensa.SelectedValue, (int)cbotipoid.SelectedValue, txtbuscarnombre.TextValido());
            lbltotalregistros.Text = $"Total de Registros {dtgconten.RowCount}";
            decimal Soles = 0, Dolares = 0;
            decimal RegSoles = 0, RegDolares = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if ((int)item.Cells[xEstado.Name].Value == 2)
                {
                    Soles += (decimal)item.Cells[xMontoMN.Name].Value;
                    Dolares += (decimal)item.Cells[xMontoME.Name].Value;
                }
                if ((int)item.Cells[xEstado.Name].Value == 1)
                {
                    RegSoles += (decimal)item.Cells[xMontoMN.Name].Value;
                    RegDolares += (decimal)item.Cells[xMontoME.Name].Value;
                }
            }
            txtMontoMN.Text = Soles.ToString("n2"); txtMontoME.Text = Dolares.ToString("n2");
            txtRegularMN.Text = RegSoles.ToString("n2"); txtRegularME.Text = RegDolares.ToString("n2");
        }
        private void txtbuscarnombre_TextChanged(object sender, EventArgs e)
        {
            SacarDatos();
        }
        private void cbotipoid_SelectedIndexChanged(object sender, EventArgs e)
        {
            SacarDatos();
        }
        private void cbocompensa_SelectedIndexChanged(object sender, EventArgs e)
        {
            SacarDatos();
        }
    }
}
