using System;
using System.IO;
using System.Net;

namespace HpResergerNube
{
    public class FtpClient: WebClient
    {
        private readonly string ftpServer;
        private readonly string ftpUsername;
        private readonly string ftpPassword;

        public FtpClient()
        {
            ftpUsername = "Conta@conbarmal.com";
            ftpPassword = "Conta{1^}";
            ftpServer = "ftp://ftp.conbarmal.com/";
        }

        public void UploadFile(string localFilePath, string remoteFileName)
        {
            string ftpUrl = ftpServer + remoteFileName;

            try
            {
                using (var client = new WebClient())
                {
                    client.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
                    client.UploadFile(ftpUrl, WebRequestMethods.Ftp.UploadFile, localFilePath);
                    Console.WriteLine("Archivo subido con éxito.");
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine($"Error al subir archivo: {ex.Message}");
            }
        }
        public void CreateDirectory(string directoryName)
        {
            string ftpUrl = ftpServer + directoryName;

            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl);
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                request.Credentials = new NetworkCredential(ftpUsername, ftpPassword);

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    Console.WriteLine($"Directorio '{directoryName}' creado con éxito.");
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine($"Error al crear el directorio: {ex.Message}");
            }
        }
        public string ListDirectory()
        {
            string cadena = "";
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServer);
                request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                request.Credentials = new NetworkCredential(ftpUsername, ftpPassword);

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(responseStream);
                        cadena = (reader.ReadToEnd());
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine($"Error al listar directorio: {ex.Message}");
                return "";
            }
            return cadena;
        }

        public void DownloadFile(string remoteFileName, string localFilePath)
        {
            string ftpUrl = ftpServer + remoteFileName;

            try
            {
                using (var client = new WebClient())
                {
                    client.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
                    client.DownloadFile(ftpUrl, localFilePath);
                    Console.WriteLine("Archivo descargado con éxito.");
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine($"Error al descargar archivo: {ex.Message}");
            }
        }
    }
}
