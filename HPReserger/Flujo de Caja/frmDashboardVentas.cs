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
using System.Data.SqlClient;

namespace SISGEM.Flujo_de_Caja
{
    public partial class frmDashboardVentas : DevExpress.XtraEditors.XtraForm
    {
        public frmDashboardVentas()
        {
            InitializeComponent();
        }

        private void dashboardViewer1_ConfigureDataConnection(object sender, DevExpress.DashboardCommon.DashboardConfigureDataConnectionEventArgs e)
        {
            // Verifica si la conexión se llama "ConexionExistente" (ajusta el nombre según tu configuración actual).
            if (e.ConnectionName == "localhost_LIBRE_Connection")
            {
                // Crea una nueva cadena de conexión con los nuevos detalles.
                // Construir la nueva cadena de conexión
                SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
                connectionStringBuilder.DataSource = HPResergerCapaDatos.HPResergerCD.DATASOURCE;
                connectionStringBuilder.InitialCatalog = HPResergerCapaDatos.HPResergerCD.BASEDEDATOS;
                connectionStringBuilder.UserID = HPResergerCapaDatos.HPResergerCD.USERID;
                connectionStringBuilder.Password = HPResergerCapaDatos.HPResergerCD.USERPASS;

                // Obtener la cadena de conexión como una cadena de texto
                string nuevaConexion = connectionStringBuilder.ToString();
                // Asigna la nueva cadena de conexión a la conexión existente.
                e.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.CustomStringConnectionParameters(nuevaConexion);
            }
        }
        string ruta = "";
        private void frmDashboardBitacora_Load(object sender, EventArgs e)
        {
            CargarEmpresas();

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
            // Abrir el dashboard
            ruta = System.IO.Path.Combine(Application.StartupPath, "DashBoardVentasCostos.xml");

            // Cambiar el parámetro directamente dentro del DataSource

            //int idEmpresa = 0;
            //int.TryParse(cboEmpresa.EditValue.ToString(),  out idEmpresa);
            //CambiarParametroFecha(DateTime.Today, idEmpresa);   // Ejemplo

        }

        private void CargarEmpresas()
        {
            HPResergerCapaLogica.HPResergerCL oCL = new HPResergerCapaLogica.HPResergerCL();
            DataTable tData = oCL.Empresa();

            cboEmpresa.Properties.DataSource = tData;
            cboEmpresa.Properties.DisplayMember = "descripcion";
            cboEmpresa.Properties.ValueMember = "codigo";

            // Limpiar y configurar columnas manualmente
            cboEmpresa.Properties.Columns.Clear();

            // Agregar la columna "descripcion" y ocultar todas las demás
            foreach (DataColumn column in tData.Columns)
            {
                var lookupColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo(column.ColumnName, column.ColumnName);
                lookupColumn.Visible = column.ColumnName == "descripcion"; // Solo la columna "descripcion" será visible
                cboEmpresa.Properties.Columns.Add(lookupColumn);
            }

            // Personalizar el encabezado de la columna visible
            cboEmpresa.Properties.Columns["descripcion"].Caption = "Empresa";

            // Seleccionar el primer registro si existen filas
            if (tData.Rows.Count > 0)
            {
                cboEmpresa.EditValue = tData.Rows[0]["codigo"]; // Asigna el primer valor de "codigo"
            }

            // Otras opciones de personalización
            cboEmpresa.Properties.ShowHeader = true; // Mostrar encabezado de columnas
            cboEmpresa.Properties.ShowFooter = false; // Ocultar pie de página
            cboEmpresa.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup; // Ajustar ancho automático
        }

        private void CambiarParametroFecha(DateTime nuevaFecha, int idEmpresa)
        {
            var dashboard = dashboardViewer1.Dashboard;

            foreach (var dataSource in dashboard.DataSources)
            {
                var sqlDataSource = dataSource as DevExpress.DashboardCommon.DashboardSqlDataSource;
                if (sqlDataSource == null)
                    continue;

                foreach (var query in sqlDataSource.Queries)
                {
                    var storedProcQuery = query as DevExpress.DataAccess.Sql.StoredProcQuery;
                    if (storedProcQuery == null)
                        continue;

                    foreach (DevExpress.DataAccess.Sql.QueryParameter param in storedProcQuery.Parameters)
                    {
                        if (param.Name == "@FechaFin")
                        {
                            param.Value = nuevaFecha;
                        }

                        if (param.Name == "@EMPRESA")
                        {
                            //param.Type = typeof( int);
                            param.Value = idEmpresa.ToString();
                        }
                    }
                }

                // Refrescar datasource
                sqlDataSource.Fill();
            }

            dashboardViewer1.ReloadData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Validar que hay una fecha correcta en el TextEdit
            if (!DateTime.TryParse(dtpfecha.Text, out DateTime fechaSeleccionada))
            {
                XtraMessageBox.Show("Ingrese una fecha válida.", "Error");
                return;
            }

            // Cargar dashboard (si no se cargó antes)
            if (dashboardViewer1.Dashboard == null)
                dashboardViewer1.LoadDashboard(ruta);

            // Cambiar parámetro
            int idEmpresa = 0;
            int.TryParse(cboEmpresa.EditValue.ToString(), out idEmpresa);
            CambiarParametroFecha(DateTime.Today, idEmpresa);   // Ejemplo

        }
    }
}