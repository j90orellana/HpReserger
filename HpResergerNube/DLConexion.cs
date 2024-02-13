using System;
using System.IO;
using Npgsql;

namespace HpResergerNube
{
    public class DLConexion
    {
        private string PORT = Encriptacion.Desencriptar("PqJJa+gdGq4=");
        private string DATA = Encriptacion.Desencriptar("lwoX9KPfqFhssFfUh0BsUg==");
        private string USER = Encriptacion.Desencriptar("Oy1DvyEZjMDAZeUGFSc3lg==");
        private string PASS = Encriptacion.Desencriptar("wIh5Z8uVnC6BD07xKB+BpA==");
        private string HOST = "6024ba9c-d9c4-48bf-8010-78995f9cdc2b.c9v3nfod0e3fgcbd1oug.databases.appdomain.cloud";
        //private string SSL_ROOT_CERT_FILE = "a607ea3c-cbd8-4fc4-be71-43f01948bbeb"; // Nombre del archivo del certificado raíz

        private string connectionString;
    public    static DateTime ObtenerPrimerDiaDelMes(DateTime fecha)
        {
            return new DateTime(fecha.Year, fecha.Month, 1);
        }

      public  static DateTime ObtenerUltimoDiaDelMes(DateTime fecha)
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
            connectionString = $"Host={HOST};Port={PORT};Username={USER};Password={PASS};Database={DATA};SslMode=Prefer;Trust Server Certificate=true;";
        }

        // Método para obtener la cadena de conexión
        public string GetConnectionString()
        {
            return connectionString;
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
