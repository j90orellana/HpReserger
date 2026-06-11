using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HpResergerNube
{
    public class Configuracion_PeruDev
    {
        public class DniRespuesta
        {
            public bool estado { get; set; }
            public string mensaje { get; set; }
            public DniResultado resultado { get; set; }
        }

        public class DniResultado
        {
            public string id { get; set; }
            public string nombres { get; set; }
            public string apellido_paterno { get; set; }
            public string apellido_materno { get; set; }
            public string nombre_completo { get; set; }
            public string genero { get; set; }
            public string fecha_nacimiento { get; set; }
            public string codigo_verificacion { get; set; }
        }
        public async Task<DniResultado> ConsultarDNI(string dni, string token)
        {
            Configuracion_PeruDev config = new Configuracion_PeruDev();


            string url = $"https://api.perudevs.com/api/v1/dni/complete?document={dni}&key={token}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();

                    DniRespuesta datos =
                        JsonConvert.DeserializeObject<DniRespuesta>(json);

                    if (datos.estado)
                    {
                        return datos.resultado;
                    }
                    else
                    {
                        throw new Exception(datos.mensaje);
                    }
                }
                else
                {
                    throw new Exception("Error consultando API");
                }
            }
        }
    }
}
