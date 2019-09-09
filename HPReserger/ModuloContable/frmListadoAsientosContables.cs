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
        private Boolean Busqueda = false;
        public frmListadoAsientosContables(int _fkEmpresa, string _cuo, DateTime _FechaIni)
        {
            InitializeComponent();
            fkempresa = _fkEmpresa;
            cuo = _cuo;
            FechaIni = _FechaIni;
            Busqueda = true;
        }
        private int fkempresa;
        private string cuo;
        private DateTime FechaIni;
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmListadoAsientosContables_Load(object sender, EventArgs e)
        {
            //Cargar Texto por Defecto
            txtbuscuo.CargarTextoporDefecto(); txtbusGlosa.CargarTextoporDefecto(); txtbusSuboperacion.CargarTextoporDefecto(); txtbuscuenta.CargarTextoporDefecto();
            dtpfechaini.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfechafin.Value = new DateTime(DateTime.Now.Year, 12, 31);
            //Cargar las Empresas
            CargarEmpresas();
            if (Busqueda)
            {
                cboempresa.SelectedValue = fkempresa;
                txtbuscuo.Text = cuo;
                dtpfechaini.Value = FechaIni;
                dtpfechafin.Value = FechaIni;
                btnActualizar_Click(sender, e);
            }
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
            rbActivo.Checked = true;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataTable TablaResul = CapaLogica.ListarAsientosFiltradosAvanzado((int)cboempresa.SelectedValue, dtpfechaini.Value > dtpfechafin.Value ? dtpfechafin.Value : dtpfechaini.Value, dtpfechaini.Value < dtpfechafin.Value ? dtpfechafin.Value : dtpfechaini.Value,
                 txtbuscuo.TextValido(), txtbuscuenta.TextValido(), txtbusGlosa.TextValido(), txtbusSuboperacion.TextValido(), rbReversado.Checked ? 4 : rbActivo.Checked ? 1 : -1);
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
            if (rbReversado.Checked) Valor = 4;
            else if (rbActivo.Checked) Valor = 1;
            else Valor = -1;
            //
            ModuloCrystalReport.frmReporteListadoAsientos frmReportito = new ModuloCrystalReport.frmReporteListadoAsientos((int)cboempresa.SelectedValue, dtpfechaini.Value, dtpfechafin.Value, txtbuscuo.TextValido(), txtbuscuenta.TextValido(),
                txtbusGlosa.TextValido(), txtbusSuboperacion.TextValido(), Valor);
            frmReportito.MdiParent = this.MdiParent;
            frmReportito.Show();
        }
    }
}

