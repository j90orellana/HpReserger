using Dropbox.Api;
using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        static async Task DescargarArchivo()
        {
            RutaEjecucion = Application.CommonAppDataPath.Substring(0, Application.CommonAppDataPath.IndexOf('1'));
            Empresa = File.ReadAllText(AppDomain.CurrentDomain.DynamicDirectory + "EMPRESA.txt");
            try
            {
                using (var dbx = new DropboxClient(token))
                {
                    string Path = $"/SISGEM/{Empresa}/SISGEM.zip";
                    Console.WriteLine(Path);
                    var response = await dbx.Files.DownloadAsync(Path);
                    File.WriteAllBytes($"{RutaEjecucion}ACTUALIZACION.zip", await response.GetContentAsByteArrayAsync());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Descargar Actualización:" + ex.Message);
            }
        }
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            btnactualizar.Text = "Actualizando...";
            btnactualizar.Enabled = false;
            {
                var task = Task.Run((Func<Task>)DescargarArchivo);
                task.Wait();
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