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

namespace HPReserger.ModuloRRHH
{
    public partial class frmVacacionesResumen : FormGradient
    {
        public frmVacacionesResumen()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private bool Cargado;
        private DataTable TDatos;

        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void frmVacacionesResumen_Load(object sender, EventArgs e)
        {
            CargarTextosPorDefecto();
            Cargado = true;
            MostrarDatosFiltrados();
        }
        private void CargarTextosPorDefecto()
        {
            txtbusEmpleado.CargarTextoporDefecto();
            cboFecha.Fecha(DateTime.Now);
        }
        private void MostrarDatosFiltrados()
        {
            if (Cargado)
            {
                TDatos = CapaLogica.DiasGeneradoResumen(0, txtbusEmpleado.TextValido(), cboFecha.FechaFinMes);
                dtgconten.DataSource = TDatos;
                lblRegistros.Text = $"Total Registros: {dtgconten.RowCount}";
            }
        }
        private void buttonPer1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Cargado = false;
            CargarTextosPorDefecto();
            Cargado = true;
            MostrarDatosFiltrados();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarDatosFiltrados();
        }

        private void txtbusEmpleado_TextChanged(object sender, EventArgs e)
        {
            MostrarDatosFiltrados();
        }

        private void cboFecha_CambioFechas(object sender, EventArgs e)
        {
            MostrarDatosFiltrados();
        }
    }
}
