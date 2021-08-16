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

namespace HPReserger.ModuloFacturacion
{
    public partial class frmListarFacturas : FormGradient
    {
        public frmListarFacturas()
        {
            InitializeComponent();
        }
        public frmListarFacturas(Boolean buscar, bool multiseleccion, bool presionaEnter, string listadoFacturas, decimal total)
        {
            InitializeComponent();
            Buscar = buscar;
            MultiSeleccion = multiseleccion;
            BuscarPresionandoEnter = presionaEnter;
            ListadoFacturas = listadoFacturas;
            Sumatoria = total;
        }
        public Boolean Buscar = false;
        public Boolean MultiSeleccion = false;
        public Boolean BuscarPresionandoEnter = true;
        public string ListadoFacturas = "";
        //
        private Boolean FormCargado = false;
        //
        public string ValEmpresa
        {
            get { return txtbusEmpresa.Text; }
            set { txtbusEmpresa.Text = value; }
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public List<int> ListadoFactura { get; set; }
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            SacarFacturasSeleccionadas();
            DialogResult = DialogResult.OK;
        }
        private void frmListarFacturas_Load(object sender, EventArgs e)
        {
            if (!Buscar)
                CargarValoresxDefecto();
            else
                CargarValoresxDefectoVacios();
            if (!MultiSeleccion)
                dtgconten.Columns[xok.Name].Visible = false;
            //
            FormCargado = true;
            CargarDatos();
        }
        private void CargarValoresxDefectoVacios()
        {
            Configuraciones.CargarTextoPorDefectoDeVacios(txtbusEmpresa, txtbusglosa, txtbusNumFac, txtbusproveedor);
            dtpfechade.Value = Configuraciones.InicioDelMes(DateTime.Now);
            dtpFechaHasta.Value = Configuraciones.FinDelMes(DateTime.Now);
        }

        DataTable Tdatos;
        private void CargarDatos()
        {
            if (FormCargado)
            {
                DateTime Fechade = dtpfechade.Value;
                DateTime Fechaa = dtpFechaHasta.Value;
                Configuraciones.FechaMenorMayor(Fechade, Fechaa);
                Tdatos = CapaLogica.FacturasManualesBusqueda(txtbusEmpresa.TextValido(), txtbusNumFac.TextValido(), txtbusproveedor.TextValido(), txtbusglosa.TextValido(),
                    chkFecha.Checked ? 1 : 0, Fechade, Fechaa, ListadoFacturas);
                dtgconten.DataSource = Tdatos;
                lbltotalRegistros.Text = $"Total Registros: {dtgconten.RowCount}";
            }
        }

        private void CargarValoresxDefecto()
        {
            Configuraciones.CargarTextoPorDefecto(txtbusEmpresa, txtbusglosa, txtbusNumFac, txtbusproveedor);
            dtpfechade.Value = Configuraciones.InicioDelMes(DateTime.Now);
            dtpFechaHasta.Value = Configuraciones.FinDelMes(DateTime.Now);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            ListadoFactura = null;
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void BusquedaCargarDatos()
        {
            if (FormCargado && !BuscarPresionandoEnter)
            {
                if (Configuraciones.ValidarSQLInyect(txtbusEmpresa, txtbusglosa, txtbusNumFac, txtbusproveedor)) return;//si encontramos codigo dañido de la base, rechazamos lo escrito;
                DateTime Fechade = dtpfechade.Value;
                DateTime Fechaa = dtpFechaHasta.Value;
                Configuraciones.FechaMenorMayor(Fechade, Fechaa);
                Tdatos = CapaLogica.FacturasManualesBusqueda(txtbusEmpresa.TextValido(), txtbusNumFac.TextValido(), txtbusproveedor.TextValido(), txtbusglosa.TextValido(),
                    chkFecha.Checked ? 1 : 0, Fechade, Fechaa, ListadoFacturas);
                dtgconten.DataSource = Tdatos;
                lbltotalRegistros.Text = $"Total Registros: {dtgconten.RowCount}";
            }
        }
        private void txtbusglosa_TextChanged(object sender, EventArgs e)
        {
            BusquedaCargarDatos();
        }
        private void txtbusNumFac_TextChanged(object sender, EventArgs e)
        {
            BusquedaCargarDatos();
        }
        private void txtbusproveedor_TextChanged(object sender, EventArgs e)
        {
            BusquedaCargarDatos();
        }
        private void txtbusEmpresa_TextChanged(object sender, EventArgs e)
        {
            BusquedaCargarDatos();
        }
        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFecha.Checked)
                dtpfechade.Enabled = dtpFechaHasta.Enabled = true;
            else
                dtpfechade.Enabled = dtpFechaHasta.Enabled = false;
            CargarDatos();
        }
        private void dtpfechade_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void txtbusEmpresa_OnPresionarEnter_1(object sender, KeyPressEventArgs e)
        {
            CargarDatos();
        }

        private void dtgconten_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SacarFacturasSeleccionadas();
            }
            if (!MultiSeleccion) DialogResult = DialogResult.OK;
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
                dtgconten[xok.Name, e.RowIndex].Value = (int)dtgconten[xok.Name, e.RowIndex].Value == 1 ? 0 : 1;
        }
        private void SacarFacturasSeleccionadas()
        {
            ListadoFactura = new List<int>();
            if (MultiSeleccion) //Retornaremos Varias Facturas
            {
                foreach (DataGridViewRow item in dtgconten.Rows)
                {
                    if ((int)item.Cells[xok.Name].Value == 1)
                        ListadoFactura.Add((int)item.Cells[xpkfac.Name].Value);
                }
            }
            else //Retornameros solo la con dobleclick
            {
                ListadoFactura.Add((int)dtgconten.CurrentRow.Cells[xpkfac.Name].Value);
            }
        }

        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.ColumnIndex == dtgconten.Columns[xok.Name].Index)
                {
                    dtgconten.EndEdit(); dtgconten.RefreshEdit();
                }
        }

        private void dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                CalcularSumatoria();
        }
        private decimal sumatoria;
        public decimal Sumatoria
        {
            get { return sumatoria; }
            set
            {
                sumatoria = value;
                txtTotal.Text = sumatoria.ToString("n2");
            }
        }
        private void CalcularSumatoria()
        {
            sumatoria = 0;
            foreach (DataRow item in Tdatos.Rows)
            {
                if ((int)item[xok.DataPropertyName] == 1)
                {
                    sumatoria += (decimal)item[xTotal.DataPropertyName];
                }
            }
            txtTotal.Text = sumatoria.ToString("n2");
        }
    }
}
