using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Security.AccessControl;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPResergerUpdate
{
    class HPResergerUpdate
    {
        public static string CarpetaAPPData = "";
        public static string RutaEjecucion = "";
        public static string ArchivoZIP = "";
        static void Main(string[] arg)
        {
            CarpetaAPPData = arg[0];
            CarpetaAPPData = @"C:\ProgramData\SISGEM\HPReserger";
            RutaEjecucion = AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 1);
            ArchivoZIP = Path.Combine(CarpetaAPPData, "ACTUALIZACION.zip");
            ZIP.ExtractToDirectory(new ZipArchive(new FileStream(ArchivoZIP, FileMode.Open)), CarpetaAPPData, true);
            //UpdateApplication();
            ActualizarAplicacion();
            string Fase = "";
            try
            {
                Fase = "Fase Eliminar ACTUALIZACION.Zip";
                File.Delete(ArchivoZIP);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, $"Error Encontrado: {Fase}");
            }
            Process.Start("SISGEM.exe");
            Environment.Exit(0);
        }
        private static void ActualizarAplicacion()
        {
            string CarpetaExtraida = Path.Combine(CarpetaAPPData, @"Extraido\\SISGEM");
            string Fase = "Fase Copiado";
            DirectoryInfo DirectoryExtraido = new DirectoryInfo(CarpetaExtraida);

            try
            {
                DirectoryInfo DirExtraido = new DirectoryInfo(CarpetaExtraida);
                DirectoryInfo DirEjecucion = new DirectoryInfo(RutaEjecucion);
                CopyAll(DirectoryExtraido, DirEjecucion);
                //ELiminar la Carpeta descomprimida
                Fase = "Fase Eliminacion";
                Directory.Delete(CarpetaExtraida, true);
                //ELiminar el ZIP de actualiazacion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Error Encontrado: {Fase}");
            }
        }
        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            if (source.FullName.ToLower() == target.FullName.ToLower())
            {
                return;
            }
            // Check if the target directory exists, if not, create it.
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }

            // Copy each file into it's new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                //Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }
        private static void UpdateApplication()
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentUICulture;
            //string argument = "" +
            //    " choice /C Y /N /D Y /T 1 " +
            //    " & Ren \"{2}\" \"temp1\" " +
            //    " & Ren \"{7}\" \"temp2\" " +
            //    " & Ren \"{9}\" \"temp3\" " +
            //    " & Ren \"{11}\" \"temp4\" " +
            //    " & Ren \"{13}\" \"temp5\" " +
            //    " & choice /C Y /N /D Y /T 2 & Move /Y \"{1}\" \"{2}\" " +
            //    " & choice /C Y /N /D Y /T 2 & Move /Y \"{6}\" \"{7}\" " +
            //    " & choice /C Y /N /D Y /T 2 & Move /Y \"{8}\" \"{9}\" " +
            //    " & choice /C Y /N /D Y /T 2 & Move /Y \"{10}\" \"{11}\" " +
            //    " & choice /C Y /N /D Y /T 2 & Move /Y \"{12}\" \"{13}\" " +
            //    " & Start \"\" /D \"{3}\" \"{4}\" {5} " +
            //    " & choice /C Y /N /D Y /T 4 " +
            //    " & Del /F /Q \"{3}\\temp*\"  ";


            string argument = "" +
                "mkdir {0}";
            //$"COPY {carpeta}*.* /Y  {RutaEjecucion} /Y" +
            //$" & Start \"\" /D \"{RutaEjecucion}\" " +
            //$"DEL /F /Q {carpeta}Extraido\\" +            
            //$"DEL /F /Q {ArchivoZIP} " +
            //" & Del /F /Q \"{3}\\temp*\"  ";

            //MessageBox.Show("FIN DEL CMD");
            string comandoCmd = String.Format(argument, "hola2");
            ProcessStartInfo Info = new ProcessStartInfo();
            Info.Arguments = comandoCmd;
            Info.WindowStyle = ProcessWindowStyle.Normal;
            Info.Verb = "runas";
            Info.CreateNoWindow = true;
            Info.FileName = "cmd.exe";
            Process.Start(Info);
        }
    }
    static class ZIP
    {
        // extraer reemplazando archivos
        public static void ExtractToDirectory(this ZipArchive archive, string destinationDirectoryName, bool overwrite)
        {
            if (!overwrite)
            {
                archive.ExtractToDirectory(destinationDirectoryName);
                return;
            }
            foreach (ZipArchiveEntry file in archive.Entries)
            {
                string completeFileName = Path.Combine(destinationDirectoryName + @"\\Extraido\", file.FullName);
                string directory = Path.GetDirectoryName(completeFileName);

                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                if (file.Name != "" && file.Name != "Updater.exe" && file.Name != "Datos.xml" && file.Name != "empresa.txt")
                    file.ExtractToFile(completeFileName, true);
            }
        }
    }
}