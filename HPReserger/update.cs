using Dropbox.Api;
using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class update : Form
    {
        public static string token;
        public static string Empresa;
        public static string RutaEjecucion;
        public update()
        {
            InitializeComponent();
            // solo se abrirá si hay una nueva versión
            lbversion.Text = Actualizaciones.servidor;
            rtbcambios.Text = Actualizaciones.cambios;
            token = Actualizaciones.token;
        }

        public async Task<byte[]> ObtenerArchivoAsync()
        {
            RutaEjecucion = Application.CommonAppDataPath.Substring(0, Application.CommonAppDataPath.IndexOf('1'));
            Empresa = File.ReadAllText(AppDomain.CurrentDomain.DynamicDirectory + "EMPRESA.txt");
            try
            {
                HPResergerCapaDatos.HPResergerCD.BASEDEDATOS = Empresa;
                string cadena = $"data source =" + HPResergerCapaDatos.HPResergerCD.DATASOURCE + "; initial catalog = " + HPResergerCapaDatos.HPResergerCD.BASEDEDATOS + "; Persist Security Info=True ; user id = " + HPResergerCapaDatos.HPResergerCD.USERID + "; password = " + HPResergerCapaDatos.HPResergerCD.USERPASS;
                SqlConnection conexion = new SqlConnection("cadena");

                // Crear un comando para seleccionar el archivo de la tabla
                //SqlCommand comando = new SqlCommand("SELECT top 1 Datos FROM tbl_sistema  order by id desc", conexion);
                // Ejecutar el comando y leer el objeto BLOB
                await conexion.OpenAsync();
                //byte[] datos = (byte[])comando.ExecuteScalar();
                //conexion.Close();

                using (SqlCommand comando = new SqlCommand("SELECT top 1 Datos FROM tbl_sistema  order by id desc", conexion))
                {
                    //comando.Parameters.AddWithValue("@Nombre", nombreArchivo);
                    
                    object resultado = await comando.ExecuteScalarAsync();
                    byte[] datosArchivo = resultado as byte[];


                    string Path = $"/SISGEM/{Empresa}/SISGEM.zip";
                    MessageBox.Show(RutaEjecucion);
                    Console.WriteLine(Path);
                    //var response = await dbx.Files.DownloadAsync(Path);
                    //await File.WriteAllBytes($"{RutaEjecucion}ACTUALIZACION.zip", datosArchivo);
                    byte[] archivoRecuperado = await ObtenerArchivoAsync();
                    string rutaArchivoRecuperado = $"/SISGEM/{Empresa}/SISGEM.zip";
                    File.WriteAllBytes($"{RutaEjecucion}ACTUALIZACION.zip", archivoRecuperado);
                    return datosArchivo;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Descargar Actualización:" + ex.Message);
            }
            return null;

        }
        int xx = 0;
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            btnactualizar.Text = "Actualizando...";
            btnactualizar.Enabled = false;
            {
                //DescargarArchivo();
                //var task = Task.Run((Func<Task>)DescargarArchivo);
                //task.Wait();
                xx = 1;

                Task.Run(async () =>
               {
                   xx = 2;
                   await ObtenerArchivoAsync();
               }).Wait();
                MessageBox.Show(xx.ToString());
            }
            ProcessStartInfo psi = new ProcessStartInfo(AppDomain.CurrentDomain.DynamicDirectory + "Updater.exe", RutaEjecucion);
            psi.UseShellExecute = true;
            var d = Process.Start(psi);

            Process.GetCurrentProcess().Kill();
            Environment.Exit(0);

        }
        void eliminarCarpeta(string ruta)
        {
            foreach (string f in Directory.GetFiles(ruta)) File.Delete(f);
            foreach (string d in Directory.GetDirectories(ruta)) eliminarCarpeta(d);

            Directory.Delete(ruta);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_Load(object sender, EventArgs e)
        {

        }
    }
}