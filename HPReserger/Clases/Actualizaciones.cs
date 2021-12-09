using System;
using System.Threading.Tasks;
using Dropbox.Api;
//
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Dropbox.Api.Files;

namespace HPReserger
{
    public class Actualizaciones
    {
        public static string token = "tHlGXtx-5QYAAAAAAAAAAUbRpK7ycTQ2Dn3GEvHxTwSk0G6T14yLLggLN8llTXOr";
        public static string folder = "SISGEM";
        public static string file = "version.txt";
        public static string servidor = "";
        public static string cambios = "";
        public static string Empresa = "";
        public static bool check()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            {
                var task = Task.Run((Func<Task>)getVersion);
                task.Wait();
            }
            //{
            //    var task = Task.Run((Func<Task>)ListarDatosCuenta);
            //    task.Wait();
            //}
            //{
            //    var task = Task.Run((Func<Task>)ListarCarpetaRaiz);
            //    task.Wait();
            //}
            //{
            //    var task = Task.Run((Func<Task>)DescargarArchivo);
            //    task.Wait();
            //}

            if (servidor == "error") return false;
            // pasamos a números (separando los puntos)
            // EJ: "1.0.2.5" => [1, 0, 2, 5]
            List<int> v1, v2;
            v1 = version.Split('.').ToList().Select(x => int.Parse(x)).ToList();
            v2 = servidor.Split('.').ToList().Select(x => int.Parse(x)).ToList();

            for (int i = 0; i < 4; i++)
            {
                if (v2[i] > v1[i]) return true; // hay una nueva versión
                if (v2[i] < v1[i]) return false; // tenemos una versión nueva
            }
            // misma versión
            return false;
        }
        static async Task ListarDatosCuenta()
        {
            try
            {
                using (var dbx = new DropboxClient(token))
                {
                    var full = await dbx.Users.GetCurrentAccountAsync();
                    Console.WriteLine("{0} - {1} - {2}", full.Name.DisplayName, full.Email, full.Country);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Listar Nombres:" + ex.Message);
            }
        }
        static async Task DescargarArchivo()
        {
            try
            {
                using (var dbx = new DropboxClient(token))
                {
                    //string Path = $"/{folder}/{file}";
                    string Path = $"/ArchivoPlano.txt";
                    //Path = "https://www.dropbox.com/s/ycuej87sxd61ctr/ArchivoPlano.txt?dl=0";
                    Console.WriteLine(Path);
                    var response = await dbx.Files.DownloadAsync(Path);
                    Console.WriteLine("Paso2");
                    Console.WriteLine(await response.GetContentAsStringAsync());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Descargar:" + ex.Message);
            }
        }
        static async Task ListarCarpetaRaiz()
        {
            try
            {
                using (var dbx = new DropboxClient(token))
                {
                    var list = await dbx.Files.ListFolderAsync(string.Empty);
                    // show folders then files
                    foreach (var item in list.Entries.Where(i => i.IsFolder))
                    {
                        Console.WriteLine("D  {0}/", item.Name);
                    }
                    foreach (var item in list.Entries.Where(i => i.IsFile))
                    {
                        Console.WriteLine("F{0,8} {1}", item.AsFile.Size, item.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Listar Carpetas:" + ex.Message);
            }
        }
        async Task SubirArchivo(string content)
        {
            using (var dbx = new DropboxClient(token))
            {
                using (var mem = new MemoryStream(Encoding.UTF8.GetBytes(content)))
                {
                    var updated = await dbx.Files.UploadAsync(folder + "/" + file, WriteMode.Overwrite.Instance, body: mem);
                    Console.WriteLine("Saved {0}/{1} rev {2}", folder, file, updated.Rev);
                }
            }
        }
        public static async Task getVersion()
        {
            try
            {
                Empresa = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "EMPRESA.txt");
                using (var dbx = new DropboxClient(token))
                {
                    //string Path = $"/{folder}/{file}";
                    string PathVersion = $"/sisgem/{Empresa}/version.txt";
                    string PathCambios = $"/sisgem/{Empresa}/Cambios.txt";
                    var ResponseVersion = await dbx.Files.DownloadAsync(PathVersion);
                    servidor = await ResponseVersion.GetContentAsStringAsync();
                    Console.WriteLine(servidor);
                    var ResponseCambios = await dbx.Files.DownloadAsync(PathCambios);
                    cambios = await ResponseCambios.GetContentAsStringAsync();
                    Console.WriteLine(cambios);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Descargar:" + ex.Message);
            }
        }
        public static string getCambios()
        {
            try
            {
                return new WebClient().DownloadString("https://drive.google.com/file/d/1plVkRUg-E0SfbmVkSuivgBKmwiscbS4Q/view?usp=sharing");
            }
            catch (Exception) { return "error"; }
        }
    }
}