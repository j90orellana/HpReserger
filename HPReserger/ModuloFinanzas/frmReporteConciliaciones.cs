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

namespace HPReserger.ModuloFinanzas
{
    public partial class frmReporteConciliaciones : FormGradient
    {
        public frmReporteConciliaciones()
        {
            InitializeComponent();
        }
        Boolean Cargado = false;
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmReporteConciliaciones_Load(object sender, EventArgs e)
        {
            LimpiarBotones();
            Cargado = true;
            FiltrarDatosConciliaciones();
        }
        private void LimpiarBotones()
        {
            txtbusbanco.CargarTextoporDefecto();
            txtbusEmpresa.CargarTextoporDefecto();
            txtbusnrocuenta.CargarTextoporDefecto();
            cbofechaini.Fecha(new DateTime(DateTime.Now.Year, 1, 1));
            cbofechafin.Fecha(new DateTime(DateTime.Now.Year, 12, 31));
        }
        private void txtbusempresa_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatosConciliaciones();
        }
        DateTime FechaInicial;
        DateTime FechaFinal;
        private void FiltrarDatosConciliaciones()
        {
            if (Cargado)
            {
                FechaInicial = cbofechaini.FechaFinMes;
                FechaFinal = cbofechafin.FechaFinMes;
                DateTime Fechaaux;
                if (FechaInicial > FechaFinal)
                {
                    Fechaaux = FechaFinal;
                    FechaFinal = FechaInicial;
                    FechaInicial = Fechaaux;
                }
                dtgconten.DataSource = CapaLogica.Conciliacion_Busqueda(txtbusEmpresa.TextValido(), txtbusbanco.TextValido(), txtbusnrocuenta.TextValido(),
                    FechaInicial, FechaFinal);
                lblRegistros.Text = $"Total Registros: {dtgconten.RowCount}";
            }
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Cargado = false;
            LimpiarBotones();
            Cargado = true;
            FiltrarDatosConciliaciones();
        }
        private void cbofechaini_CambioFechas(object sender, EventArgs e)
        {
            FiltrarDatosConciliaciones();
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.frmInformativo.MostrarDialog(cadena);
        }
        public DialogResult msgYesCancel(string cadena)
        {
            return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena);
        }
        public void msgError(string cadena)
        {
            HPResergerFunciones.frmInformativo.MostrarDialogError(cadena);
        }
        private void btnexportarpdf_Click(object sender, EventArgs e)
        {
            if (dtgconten.Rows.Count == 0)
            {
                msgError("No hay Datos para Generar"); return;
            }
            //Mostrar Formulario del Reporte PDF
        }
    }
}
