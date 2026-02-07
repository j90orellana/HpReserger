using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SISGEM.ModuloFinanzas
{
    public partial class frmAbonarMutuos : DevExpress.XtraEditors.XtraForm
    {
        public frmAbonarMutuos()
        {
            InitializeComponent();
        }

        private void btnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmAbonarMutuos_Load(object sender, EventArgs e)
        {
            CargarEmpresas();
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();

            // Mostrar solo Mes y Año en el campo
            dtpfecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtpfecha.Properties.DisplayFormat.FormatString = "MMMM yyyy";  // Ej: "Mayo 2025"

            dtpfecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtpfecha.Properties.EditFormat.FormatString = "MMMM yyyy";

            dtpfecha.Properties.Mask.EditMask = "MMMM yyyy";
            dtpfecha.Properties.Mask.UseMaskAsDisplayFormat = true;

            // Cambiar el tipo de vista del calendario a Vista de Meses (evita días)
            dtpfecha.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;

            // Esto permite que el usuario solo elija el mes (de la vista anual)
            dtpfecha.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            dtpfecha.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;

            dtpfecha.EditValue = DateTime.Now;
        }
        private void CargarEmpresas()
        {
            HPResergerCapaLogica.HPResergerCL oCL = new HPResergerCapaLogica.HPResergerCL();
            DataTable tData = oCL.Empresa();

            cboEmpresa.Properties.DataSource = tData;
            cboEmpresa.Properties.DisplayMember = "descripcion";
            cboEmpresa.Properties.ValueMember = "codigo";

            cboEmpresa.EditValue = tData.Rows.Count > 0 ? tData.Rows[0]["codigo"] : null;

            // Limpiar columnas
            var view = cboEmpresa.Properties.View;
            view.Columns.Clear();

            view.Columns.AddVisible("descripcion", "Empresa");//.SetFixed(150);          

            // Ajustar solo las demás columnas
            view.BestFitColumns();

        }

        private void cboEmpresa_EditValueChanged(object sender, EventArgs e)
        {
            if (cboEmpresa.EditValue != null)
            {
                cargarProyectos((int)cboEmpresa.EditValue);
                cargarBancos((int)cboEmpresa.EditValue);
            }
        }
        private void cargarBancos(int idEmpresa)
        {
            HPResergerCapaLogica.Mantenimiento.Empresa cClase = new HPResergerCapaLogica.Mantenimiento.Empresa();
            DataTable Tdata = cClase.GetCuentasBancarias(idEmpresa);
            IdCtaBanco.Properties.DataSource = Tdata;
            IdCtaBanco.Properties.DisplayMember = "nombre";
            IdCtaBanco.Properties.ValueMember = "id";

            IdCtaBanco.EditValue = Tdata.Rows.Count > 0 ? Tdata.Rows[0]["Id"] : null;

            // Limpiar columnas
            var view = IdCtaBanco.Properties.View;
            view.Columns.Clear();

            var col = view.Columns.AddVisible("banco", "Entidad Bancaria");
            col.Width = 150;
            col.MinWidth = 150;
            col.MaxWidth = 150;
            col.OptionsColumn.FixedWidth = true;
            var col1 = view.Columns.AddVisible("nroCta", "Nro Cuenta Bancaria");
            col1.Width = 150;
            col1.MinWidth = 150;
            col1.MaxWidth = 150;
            col1.OptionsColumn.FixedWidth = true;
            view.Columns.AddVisible("cci", "Nro Cta CCI");

            // Ajustar solo las demás columnas
            view.BestFitColumns();
        }
        private void cargarProyectos(int idEmpresa)
        {
            DataTable tData = CapaLogica.ListarProyectosEmpresa(idEmpresa.ToString());
            cboProyecto.Properties.DataSource = tData;
            cboProyecto.Properties.DisplayMember = "Proyecto";
            cboProyecto.Properties.ValueMember = "Id_Proyecto";

            // Limpiar y configurar columnas manualmente
            cboProyecto.Properties.Columns.Clear();

            // Agregar la columna "descripcion" y ocultar todas las demás
            foreach (DataColumn column in tData.Columns)
            {
                var lookupColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(column.ColumnName, column.ColumnName);
                lookupColumn.Visible = column.ColumnName == "Proyecto"; // Solo la columna "descripcion" será visible
                cboProyecto.Properties.Columns.Add(lookupColumn);
            }

            // Personalizar el encabezado de la columna visible
            //cboProyecto.Properties.Columns["descripcion"].Caption = "Proyecto";

            // Seleccionar el primer registro si existen filas
            if (tData.Rows.Count > 0)
            {
                cboProyecto.EditValue = tData.Rows[0]["Id_Proyecto"]; // Asigna el primer valor de "codigo"
            }
            else
            {
                cboProyecto.Properties.DataSource = null;
                cboEtapa.Properties.DataSource = null;
            }

            // Otras opciones de personalización
            cboProyecto.Properties.ShowHeader = true; // Mostrar encabezado de columnas
            cboProyecto.Properties.ShowFooter = false; // Ocultar pie de página
            cboProyecto.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup; // Ajustar ancho automático
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void cargarEtapas(int idProyecto)
        {
            DataTable tData = CapaLogica.ListarEtapasProyecto(idProyecto.ToString());
            cboEtapa.Properties.DataSource = tData;
            cboEtapa.Properties.DisplayMember = "descripcion";
            cboEtapa.Properties.ValueMember = "Id_etapa";

            // Limpiar y configurar columnas manualmente
            cboEtapa.Properties.Columns.Clear();

            // Agregar la columna "descripcion" y ocultar todas las demás
            foreach (DataColumn column in tData.Columns)
            {
                var lookupColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(column.ColumnName, column.ColumnName);
                lookupColumn.Visible = column.ColumnName == "descripcion"; // Solo la columna "descripcion" será visible
                cboEtapa.Properties.Columns.Add(lookupColumn);
            }

            // Personalizar el encabezado de la columna visible
            cboEtapa.Properties.Columns["descripcion"].Caption = "Etapa";

            // Seleccionar el primer registro si existen filas
            if (tData.Rows.Count > 0)
            {
                cboEtapa.EditValue = tData.Rows[0]["Id_etapa"]; // Asigna el primer valor de "codigo"
            }
            else
                cboEtapa.Properties.DataSource = null;


            // Otras opciones de personalización
            cboEtapa.Properties.ShowHeader = true; // Mostrar encabezado de columnas
            cboEtapa.Properties.ShowFooter = false; // Ocultar pie de página
            cboEtapa.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup; // Ajustar ancho automático
        }

        private void cboProyecto_EditValueChanged(object sender, EventArgs e)
        {
            if (cboProyecto.EditValue != null)
                cargarEtapas((int)cboProyecto.EditValue);
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            CalcularTotalesSeleccionados();
        }

        private void CalcularTotalesSeleccionados()
        {
            decimal totalPrincipal = 0;
            decimal totalAmortizacion = 0;
            decimal totalInteres = 0;
            decimal totalCuota = 0;
            decimal totalImpuesto = 0;
            decimal totalTransferencia = 0;

            foreach (int rowHandle in gridView1.GetSelectedRows())
            {
                if (rowHandle >= 0)
                {
                    totalPrincipal += Convert.ToDecimal(gridView1.GetRowCellValue(rowHandle, "Principal"));
                    totalAmortizacion += Convert.ToDecimal(gridView1.GetRowCellValue(rowHandle, "Amortizacion"));
                    totalInteres += Convert.ToDecimal(gridView1.GetRowCellValue(rowHandle, "Interes"));
                    totalCuota += Convert.ToDecimal(gridView1.GetRowCellValue(rowHandle, "Cuota"));
                    totalImpuesto += Convert.ToDecimal(gridView1.GetRowCellValue(rowHandle, "Impuesto"));
                    totalTransferencia += Convert.ToDecimal(gridView1.GetRowCellValue(rowHandle, "Transferencia"));
                }
            }

            txtPrincipal.EditValue = totalPrincipal;
            txtAmortizacion.EditValue = totalAmortizacion;
            txtInteres.EditValue = totalInteres;
            txtCuota.EditValue = totalCuota;
            txtImpuesto.EditValue = totalImpuesto;
            txtTransferencia.EditValue = totalTransferencia;
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            HPResergerCapaLogica.Finanzas.Mutuos oclase = new HPResergerCapaLogica.Finanzas.Mutuos();
            if (cboEmpresa.EditValue == null)
            {
                XtraMessageBox.Show("Seleccione una Empresa", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IdCtaBanco.EditValue == null)
            {
                XtraMessageBox.Show("Seleccione una Cuenta Bancaria", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int idempresa = (int)cboEmpresa.EditValue;
            gridControl1.DataSource = oclase.GetMutuosxPagar(idempresa, (DateTime)dtpfecha.EditValue, (int)IdCtaBanco.EditValue);
            gridView1.BestFitColumns();
        }
    }
}