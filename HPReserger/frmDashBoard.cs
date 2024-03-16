using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISGEM
{
    public partial class frmDashBoard : XtraForm
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            //string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //string dashboardFilePath = System.IO.Path.Combine(appPath, "Dashboard.xml");
            //((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).EndInit();
            //this.dashboardViewer1.DashboardSource = new System.Uri(dashboardFilePath);

            //dashboardViewer1.LoadDashboard(dashboardFilePath);
            //dashboardViewer1.ReloadData();

        }
        private void dashboardViewer1_ConfigureDataConnection(object sender, DevExpress.DashboardCommon.DashboardConfigureDataConnectionEventArgs e)
        {
            // Verifica si la conexión se llama "ConexionExistente" (ajusta el nombre según tu configuración actual).
            if (e.ConnectionName == "192.168.1.6_actual_Connection")
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
    }
}
