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
using SISGEM.ModuloContable;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.XtraReports.UI;

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
            FechaFin = _FechaIni;
            Busqueda = true;
        }
        public frmListadoAsientosContables(int _fkEmpresa, string _cuo)
        {
            InitializeComponent();
            fkempresa = _fkEmpresa;
            cuo = _cuo;
            FechaIni = new DateTime(DateTime.Now.Year, 1, 1);
            FechaFin = new DateTime(DateTime.Now.Year, 12, 31);
            Busqueda = true;
        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        private int fkempresa;
        private string cuo;
        private DateTime FechaIni;
        public DateTime FechaFin;
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
                dtpfechafin.Value = FechaFin;
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
            frmReportito.StateInicialForm = this.WindowState;
            frmReportito.MdiParent = this.MdiParent;
            frmReportito.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int Valor = 1;
            if (rbReversado.Checked) Valor = 4;
            else if (rbActivo.Checked) Valor = 1;
            else Valor = -1;
            // ** 1. SOLICITAR LOS PARÁMETROS AL USUARIO **
            int empresa = (int)cboempresa.SelectedValue;
            DateTime fechaInicio = dtpfechaini.Value;
            DateTime fechaFin = dtpfechafin.Value;
            string cuo = txtbuscuo.TextValido();
            string cuenta = txtbuscuenta.TextValido();
            string glosa = txtbusGlosa.TextValido();
            string subOperacion = txtbusSuboperacion.TextValido();
            int estado = Valor;

            // Crear instancia del reporte
            XtraReportAsientoContable reporte = new XtraReportAsientoContable();

            // Obtener el SqlDataSource del reporte
            SqlDataSource dataSource = reporte.DataSource as SqlDataSource;

            if (dataSource != null)
            {
                // Crear una nueva conexión
                HPResergerCapaDatos.HPResergerCD capad = new HPResergerCapaDatos.HPResergerCD();
                string nuevaConexion = capad.ObtenerConexion();

                // Modificar la conexión
                dataSource.ConnectionParameters = new CustomStringConnectionParameters(nuevaConexion);

                var query = dataSource.Queries[0] as StoredProcQuery;
                if (query != null)
                {
                    query.Parameters.Clear(); // Limpia los parámetros previos

                    query.Parameters.Add(new QueryParameter("@empresa", typeof(int), empresa));
                    query.Parameters.Add(new QueryParameter("@fechaini", typeof(DateTime), fechaInicio));
                    query.Parameters.Add(new QueryParameter("@fechafin", typeof(DateTime), fechaFin));
                    query.Parameters.Add(new QueryParameter("@cuo", typeof(string), cuo));
                    query.Parameters.Add(new QueryParameter("@cuenta", typeof(string), cuenta));
                    query.Parameters.Add(new QueryParameter("@glosa", typeof(string), glosa));
                    query.Parameters.Add(new QueryParameter("@SubOperacion", typeof(string), subOperacion));
                    query.Parameters.Add(new QueryParameter("@Estado", typeof(int), estado));
                }

                // ** 3.3 REFRESCAR Y LLENAR EL DATA SOURCE **
                dataSource.RebuildResultSchema();
                dataSource.Fill();
            }

            // ** 4. EVITAR QUE SE MUESTRE LA VENTANA DE PARÁMETROS**
            foreach (var param in reporte.Parameters)
            {
                param.Visible = false; // Ocultar los parámetros en el visor
            }
            // ** 5. CONFIGURAR EL NOMBRE DEL ARCHIVO AL EXPORTAR A PDF**
            reporte.ExportOptions.PrintPreview.DefaultFileName = "Reporte Asiento Contable";

            // Mostrar el reporte en un visor
            ReportPrintTool printTool = new ReportPrintTool(reporte);
            printTool.ShowPreviewDialog();
        }
    }
}

