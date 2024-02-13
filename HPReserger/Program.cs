using DevExpress.XtraEditors;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Windows.Forms;
using Octokit; // Para acceder a las funcionalidades de Octokit
using System.Linq; // Para utilizar el método ElementAt de LINQ
using System.Threading.Tasks;
using System.Threading;

namespace HPReserger
{
    public static class Program
    {
        private const string ReleasesApiUrl = "https://api.github.com/repos/j90orellana/HpReserger/releases/latest";
        private static string TempFolderPath = "";
        private static string filePath = "";        
        [STAThread]
        static void Main()
        {
            filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "cambios.txt");
            TempFolderPath = System.Windows.Forms.Application.CommonAppDataPath;
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            VerificarActualizacion();

            //Application.Run(new ModuloFinanzas.FrmConciliarBanco());
            System.Windows.Forms.Application.Run(new frmLogin());
        }

        //private static async void VerificarActualizacion()
        //{
        //    Version latestVersion = await ObtenerUltimaVersionDesdeGitHubAsync();

        //    if (latestVersion != null && latestVersion > ObtenerVersionActual())
        //    {
        //        XtraMessageBox.Show($"Se encontró una actualización disponible. Descargando versión {latestVersion}...", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        string installerPath = await DescargarInstaladorDesdeGitHub();

        //        if (!string.IsNullOrEmpty(installerPath))
        //        {
        //            XtraMessageBox.Show("Descarga completada. Iniciando actualización...", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            EjecutarInstalador(installerPath);

        //            XtraMessageBox.Show("La actualización se completó exitosamente.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            XtraMessageBox.Show("Error al descargar el instalador. No se pudo realizar la actualización.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        XtraMessageBox.Show("No se encontró ninguna actualización disponible.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
        private static async void VerificarActualizacion()
        {
            Version latestVersion = await ObtenerUltimaVersionDesdeGitHubAsync();

            if (latestVersion != null && latestVersion > ObtenerVersionActual())
            {
                // Obtener información adicional de la última versión

                XtraMessageBox.Show($"Se encontró una actualización disponible. Descargando versión {latestVersion}...\n\n{cuerpo}", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string installerPath = await DescargarInstaladorDesdeGitHub();
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.Write(cuerpo); // Escribir el texto en el archivo
                    }
                    //MessageBox.Show("El texto se ha guardado correctamente.");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error al guardar el texto: " + ex.Message);
                }
                if (!string.IsNullOrEmpty(installerPath))
                {
                    XtraMessageBox.Show("Descarga completada. Iniciando actualización...", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EjecutarInstalador(installerPath);

                    XtraMessageBox.Show("La actualización se completó exitosamente.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Error al descargar el instalador. No se pudo realizar la actualización.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //XtraMessageBox.Show("No se encontró ninguna actualización disponible.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static Version ObtenerVersionActual()
        {
            // Obtiene la versión actual de tu programa.
            // Puedes hacerlo leyendo el número de versión desde los atributos del ensamblado.
            return Assembly.GetExecutingAssembly().GetName().Version;
        }
        private const string AcceptHeader = "application/vnd.github.v3+json";
        private const string AuthorizationHeader = "Bearer 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";
        private const string GitHubApiVersionHeader = "application/vnd.github.v3+json";
        public static string cuerpo = "";
        public static string urlhtml = "";
        private static async Task<Version> ObtenerUltimaVersionDesdeGitHubAsync()
        {
            try
            {
                var repositoryOwner = "j90orellana"; // Reemplaza con el nombre del propietario del repositorio
                var repositoryName = "HpReserger"; // Reemplaza con el nombre del repositorio

                var token = "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"; // Reemplaza con tu token de acceso personal


                //AppContext.SetSwitch("System.Net.Http.UseSocketsHttpHandler", false);
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                var githubClient = new GitHubClient(new Octokit.ProductHeaderValue("SISGEM"));


                githubClient.Credentials = new Credentials(token); // Asigna las credenciales con tu token de acceso personal
                var releases = await githubClient.Repository.Release.GetLatest(repositoryOwner, repositoryName);
                var latestRelease = releases;// releases.OrderByDescending(r => r.CreatedAt).FirstOrDefault();
                if (latestRelease != null)
                {
                    var versionTag = latestRelease.TagName;
                    var body = latestRelease.Body;
                    var html = latestRelease.Assets[0].BrowserDownloadUrl;
                    urlhtml = html;
                    cuerpo = body;

                    var latestVersion = new Version(versionTag);

                    // Comparar latestVersion con tu versión actual y realizar las acciones necesarias

                    // Ejemplo de comparación:
                    //var currentVersion = new Version("1.0.3.5");
                    //if (latestVersion > currentVersion)
                    //{
                    //    // Realizar acciones para actualizar a la última versión
                    //}
                    //else
                    //{
                    //    // No hay actualizaciones disponibles
                    //}
                    return Version.Parse(versionTag);
                }
                return null;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error al obtener la última versión desde GitHub: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private static async Task<string> DescargarInstaladorDesdeGitHub()
        {
            try
            {
                string installerUrl = ObtenerUrlInstaladorDesdeGitHub();
                string installerPath = Path.Combine(TempFolderPath, "INSTALLER_SISGEM.exe");
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Authorization", $"Bearer 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");
                    await webClient.DownloadFileTaskAsync(new Uri(installerUrl), installerPath);

                }
                return installerPath;
                //using (HttpClient client = new HttpClient())
                //{

                //    using (HttpResponseMessage response = await client.GetAsync(installerUrl))
                //    {
                //        using (HttpContent content = response.Content)
                //        {
                //            if (response.IsSuccessStatusCode)
                //            {
                //                using (Stream stream = await content.ReadAsStreamAsync())
                //                {
                //                    using (FileStream fileStream = File.Create(installerPath))
                //                    {
                //                        await stream.CopyToAsync(fileStream);
                //                        return installerPath;
                //                    }
                //                }
                //            }
                //            else
                //            {
                //                XtraMessageBox.Show($"Error al descargar el instalador desde GitHub: {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //                return null;
                //            }
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error al descargar el instalador desde GitHub: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //private static string DescargarInstaladorDesdeGitHusb()
        //{
        //    try
        //    {
        //        string installerUrl = ObtenerUrlInstaladorDesdeGitHub();
        //        string installerPath = Path.Combine(TempFolderPath, "INSTALLER_SISGEM.exe");

        //        using (HttpClient client = new HttpClient())
        //        {
        //            // Establecer el encabezado User-Agent para simular un navegador
        //            client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.150 Safari/537.36");

        //            // Realizar la solicitud GET y guardar el contenido en un archivo
        //            HttpResponseMessage response = client.GetAsync(installerUrl).Result;
        //            if (response.IsSuccessStatusCode)
        //            {
        //                using (FileStream fileStream = new FileStream(installerPath, System.IO.FileMode.Create))
        //                {
        //                    response.Content.CopyToAsync(fileStream).Wait();
        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine($"Error al descargar el archivo: {response.ReasonPhrase}");
        //            }
        //            return installerPath;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        XtraMessageBox.Show($"Error al descargar el instalador desde GitHub: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return null;
        //    }
        //}

        private static string ObtenerUrlInstaladorDesdeGitHub()
        {
            try
            {
                //using (WebClient webClient = new WebClient())
                //{
                //    webClient.Headers.Add("User-Agent", "Mozilla/5.0"); // Se requiere para la API de GitHub
                //    webClient.Headers.Add("bearer", "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");

                //    string response = webClient.DownloadString(ReleasesApiUrl);
                //    dynamic release = Newtonsoft.Json.JsonConvert.DeserializeObject(response);
                //    string installerUrl = release.assets[0].browser_download_url;

                return urlhtml;
                //}
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error al obtener la URL del instalador desde GitHub: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return urlhtml;
            }
        }

        private static void EjecutarInstalador(string installerPath)
        {
            try
            {
                // Cerrar la instancia actual de "SISGEM" si está en ejecución
                Process[] processes = Process.GetProcessesByName("SISGEM");
                foreach (Process process in processes)
                {
                    process.CloseMainWindow();
                    //process.WaitForExit();
                }

                // Crear un nuevo proceso para ejecutar el instalador
                ProcessStartInfo startInfo = new ProcessStartInfo(installerPath, "/SILENT /NORESTART");
                startInfo.UseShellExecute = true;
                Process installerProcess = Process.Start(startInfo);

                // Esperar a que el proceso de instalación haya iniciado
                installerProcess.WaitForInputIdle();

                // Esperar a que el proceso de instalación se complete
                installerProcess.WaitForExit();

                // Iniciar la nueva versión de "SISGEM"
                Process.Start("SISGEM");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error al ejecutar el instalador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
