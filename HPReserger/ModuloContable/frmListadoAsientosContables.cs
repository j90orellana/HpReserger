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

namespace HPReserger.ModuloContable
{
    public partial class frmListadoAsientosContables : FormGradient
    {
        public frmListadoAsientosContables()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmListadoAsientosContables_Load(object sender, EventArgs e)
        {
            //Cargar Texto por Defecto
            txtbuscuo.CargarTextoporDefecto(); txtbusGlosa.CargarTextoporDefecto(); txtbusSuboperacion.CargarTextoporDefecto(); txtbuscuenta.CargarTextoporDefecto();
            dtpfechaini.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfechafin.Value = new DateTime(DateTime.Now.Year, 12, 31);
            //Cargar las Empresas
            CargarEmpresas();
        }
        public void CargarEmpresas()
        {
            cboempresa.DisplayMember = "descripcion";
            cboempresa.ValueMember = "codigo";
            cboempresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_Empresa", "Empresa", "TBL_Empresa");
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btncleanfind_Click(object sender, EventArgs e)
        {
            txtbuscuo.CargarTextoporDefecto(); txtbusGlosa.CargarTextoporDefecto(); txtbusSuboperacion.CargarTextoporDefecto(); txtbuscuenta.CargarTextoporDefecto();
            dtpfechaini.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfechafin.Value = new DateTime(DateTime.Now.Year, 12, 31);
            chkAvanzado.Checked = false;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataTable TablaResul = CapaLogica.ListarAsientosFiltradosAvanzado((int)cboempresa.SelectedValue, dtpfechaini.Value > dtpfechafin.Value ? dtpfechafin.Value : dtpfechaini.Value, dtpfechaini.Value < dtpfechafin.Value ? dtpfechafin.Value : dtpfechaini.Value,
                 txtbuscuo.TextValido(), txtbuscuenta.TextValido(), txtbusGlosa.TextValido(), txtbusSuboperacion.TextValido(), chkAvanzado.CheckState == CheckState.Checked ? 4 : chkAvanzado.CheckState == CheckState.Unchecked ? 1 : -1);
            //Resultados;
            dtgconten.DataSource = TablaResul;
            lblmsg.Text = $"Total Registros: {dtgconten.RowCount}";
        }
        private void cboempresa_Click(object sender, EventArgs e)
        {
            DataTable Tablita = CapaLogica.getCargoTipoContratacion("Id_Empresa", "Empresa", "TBL_Empresa");
            if (cboempresa.Items.Count != Tablita.Rows.Count)
            {
                string cadena = cboempresa.Text;
                cboempresa.DataSource = Tablita;
                cboempresa.Text = cadena;
            }
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            int Valor = 1;
            if (chkAvanzado.CheckState == CheckState.Checked) Valor = 4;
            else if (chkAvanzado.CheckState == CheckState.Unchecked) Valor = 1;
            else Valor = -1;
            //
            ModuloCrystalReport.frmReporteListadoAsientos frmReportito = new ModuloCrystalReport.frmReporteListadoAsientos((int)cboempresa.SelectedValue, dtpfechaini.Value, dtpfechafin.Value, txtbuscuo.TextValido(), txtbuscuenta.TextValido(),
                txtbusGlosa.TextValido(), txtbusSuboperacion.TextValido(), Valor);
            frmReportito.MdiParent = this.MdiParent;
            frmReportito.Show();
        }
    }
}

