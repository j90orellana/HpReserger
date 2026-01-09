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

namespace SISGEM.ModuloContable
{
    public partial class frmDashboardBitacora : DevExpress.XtraEditors.XtraForm
    {
        public frmDashboardBitacora()
        {
            InitializeComponent();
        }

        private void dashboardViewer1_ConfigureDataConnection(object sender, DevExpress.DashboardCommon.DashboardConfigureDataConnectionEventArgs e)
        {
            // Verifica si la conexión se llama "ConexionExistente" (ajusta el nombre según tu configuración actual).
            if (e.ConnectionName == "192.168.10.10_LIBRE_Connection")
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
            ruta = System.IO.Path.Combine(Application.StartupPath, "Bitacora de Usuarios en Barras partidas.xml");

            dashboardViewer1.LoadDashboard(ruta);
            // Cambiar el parámetro directamente dentro del DataSource
            CambiarParametroFecha(DateTime.Today);   // Ejemplo

        }
        private void CambiarParametroFecha(DateTime nuevaFecha)
        {
            var dashboard = dashboardViewer1.Dashboard;

            foreach (var dataSource in dashboard.DataSources)
            {
                var sqlDataSource = dataSource as DevExpress.DashboardCommon.DashboardSqlDataSource;
                if (sqlDataSource == null)
                    continue;

                foreach (var query in sqlDataSource.Queries)
                {
                    var customQuery = query as DevExpress.DataAccess.Sql.CustomSqlQuery;
                    if (customQuery == null)
                        continue;

                    // Buscar el parámetro
                    foreach (var param in customQuery.Parameters)
                    {
                        if (param.Name == "@fecha")
                        {
                            param.Value = nuevaFecha;
                            sqlDataSource.RebuildResultSchema(); // actualizar
                            break;
                        }
                    }
                }
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
            CambiarParametroFecha(fechaSeleccionada);

        }
    }
}