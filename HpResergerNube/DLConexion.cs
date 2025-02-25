using System;
using System.IO;
using Npgsql;

namespace HpResergerNube
{
    public class DLConexion
    {
        //private string PORT = Encriptacion.Desencriptar("PqJJa+gdGq4=");

        //private string USER = Encriptacion.Desencriptar("Oy1DvyEZjMDAZeUGFSc3lg==");
        ////TEST
        ////private string DATA = Encriptacion.Desencriptar("lwoX9KPfqFhssFfUh0BsUg==");
        ////PROD
        //public string DATA { get; set; } = Encriptacion.Desencriptar("WXtU+M1PmvZNiUvHK9JjtQ==");
        //public static string Basesita { get; set; }

        //public static string Sdata = "WXtU+M1PmvZNiUvHK9JjtQ==";

        //private string PASS = Encriptacion.Desencriptar("5501nxT1FgZwKapqpXqOrQ==");
        //private string HOST = "6024ba9c-d9c4-48bf-8010-78995f9cdc2b.c9v3nfod0e3fgcbd1oug.databases.appdomain.cloud";
        //private string SSL_ROOT_CERT_FILE = "a607ea3c-cbd8-4fc4-be71-43f01948bbeb"; // Nombre del archivo del certificado raíz

        private string PORT = Encriptacion.Desencriptar("QyKhZduHTbI=");

        private string USER = Encriptacion.Desencriptar("JDllz3MAFTv379yNUcVIoG/Su26Ikr+SDsSXqtSP0p6ul2KunH8nySu2vLEc5njg");
        //TEST
        //private string DATA = Encriptacion.Desencriptar("lwoX9KPfqFhssFfUh0BsUg==");
        //PROD
        public string DATA { get; set; } = Encriptacion.Desencriptar("WXtU+M1PmvZNiUvHK9JjtQ==");
        public string DATA_ADMIN { get; set; } = Encriptacion.Desencriptar("sShOmKrkmfi7OBh3hzZ+vw==");
        public static string Basesita { get; set; }

        public static string Sdata = "WXtU+M1PmvZNiUvHK9JjtQ==";

        private string PASS = Encriptacion.Desencriptar("vDETmLFU66tL7+rAqiTPbP6xEGsF9z6m3/siujiKY00Aa/bwxPSznS5P1pKmEBIS81AjgynPpy129zYPDuLoWXKCVfcNX54Q");
        private string HOST = "49f221b0-218d-43b3-a0f4-ef2ed0f8818f.br37s45d0p54n73ffbr0.databases.appdomain.cloud";

        private string connectionString;
        private string connectionStringAdmin;
        public static DateTime ObtenerPrimerDiaDelMes(DateTime fecha)
        {
            return new DateTime(fecha.Year, fecha.Month, 1);
        }

        public static DateTime ObtenerUltimoDiaDelMes(DateTime fecha)
        {
            int ultimoDiaDelMes = DateTime.DaysInMonth(fecha.Year, fecha.Month);
            return new DateTime(fecha.Year, fecha.Month, ultimoDiaDelMes);
        }
        public DLConexion()
        {
            // Ruta completa al certificado raíz
            //string sslRootCertPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, SSL_ROOT_CERT_FILE);

            // Verificar si el archivo del certificado existe
            //if (!File.Exists(sslRootCertPath))
            //{
            //    throw new FileNotFoundException($"No se encontró el archivo del certificado raíz: {SSL_ROOT_CERT_FILE}");
            ////}

            // Configurar la cadena de conexión

            DATA = Encriptacion.Desencriptar(Sdata);

            connectionString = $"Host={HOST};Port={PORT};Username={USER};Password={PASS};Database={DATA};SslMode=Prefer;Trust Server Certificate=true;";
            connectionStringAdmin = $"Host={HOST};Port={PORT};Username={USER};Password={PASS};Database={DATA_ADMIN};SslMode=Prefer;Trust Server Certificate=true;";
        }

        // Método para obtener la cadena de conexión
        public string GetConnectionString()
        {
            return connectionString;
        }
        public string GetConnectionStringAdmin()
        {
            return connectionStringAdmin;
        }
        // Opcional: Método para abrir la conexión (para ser usado fuera de la clase)
        public void OpenConnection()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();
                    Console.WriteLine("Conexión exitosa.");

                    // Realizar operaciones en la base de datos aquí
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al conectar a la base de datos: {ex.Message}");
                }
            }
        }
    }
}
