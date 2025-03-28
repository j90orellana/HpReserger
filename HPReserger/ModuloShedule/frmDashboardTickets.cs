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

namespace SISGEM.ModuloShedule
{
    public partial class frmDashboardTickets : Form
    {
        public frmDashboardTickets()
        {
            InitializeComponent();
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
