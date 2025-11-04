using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HpResergerNube
{
    public class FactilizaApiClient
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private const string BaseUrlCEE = "https://api.factiliza.com/v1/cee/info/";
        private const string BaseUrlDNI = "https://api.factiliza.com/v1/dni/info/";
        private const string BaseUrlRepresentantes = "https://api.factiliza.com/v1/ruc/representante/";
        private const string BearerToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIzNTUiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJjb25zdWx0b3IifQ.aI5AV78SvDW_MSM9H6cS0Lf_QrxCVYUh0N6dkVZDcXI";

        static FactilizaApiClient()
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", BearerToken);
        }

        public class ApiResponseResultCEE
        {
            public ApiResponseCEE Response { get; set; }
            public string NombreCompleto { get; set; }
        }
        public class ApiResponseCEE
        {
            public int Status { get; set; }
            public string Message { get; set; }
            public ApiDataCEE Data { get; set; }
        }
        public class ApiDataCEE
        {
            public string Numero { get; set; }
            public string Nombres { get; set; }
            public string Apellido_Paterno { get; set; }
            public string Apellido_Materno { get; set; }
        }
        public class ApiResponseResultDNI
        {
            public ApiResponseDNI Response { get; set; }
            public string NombreCompleto { get; set; }
        }
        public class ApiResponseDNI
        {
            public int Status { get; set; }
            public bool Success { get; set; }
            public string Message { get; set; }
            public ApiDataDNI Data { get; set; }
        }

        public class ApiDataDNI
        {
            public string Numero { get; set; }
            public string Nombres { get; set; }
            public string Apellido_Paterno { get; set; }
            public string Apellido_Materno { get; set; }
            public string Nombre_Completo { get; set; }
            public string Departamento { get; set; }
            public string Provincia { get; set; }
            public string Distrito { get; set; }
            public string Direccion { get; set; }
            public string Direccion_Completa { get; set; }
            public string Ubigeo_Reniec { get; set; }
            public string Ubigeo_Sunat { get; set; }
            public List<string> Ubigeo { get; set; }
            public string Fecha_Nacimiento { get; set; }
            public string Sexo { get; set; }
        }

        public class ApiResponseRepresentante
        {
            public int Status { get; set; }
            public string Message { get; set; }
            public List<RepresentanteData> Data { get; set; }
        }
        public class RepresentanteData
        {
            [JsonProperty("tipo_de_documento")]
            public string TipoDeDocumento { get; set; }

            [JsonProperty("numero_de_documento")]
            public string NumeroDeDocumento { get; set; }

            [JsonProperty("nombre")]
            public string Nombre { get; set; }

            [JsonProperty("cargo")]
            public string Cargo { get; set; }

            [JsonProperty("fecha_desde")]
            public string FechaDesde { get; set; }
        }
        public static async Task<ApiResponseResultCEE> GetInfoAsyncCEE(string id)
        {
            var response = await _httpClient.GetAsync(BaseUrlCEE + id);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var apiResponse = JsonConvert.DeserializeObject<ApiResponseCEE>(responseContent);
                string nombreCompleto = $"{apiResponse.Data.Apellido_Paterno} {apiResponse.Data.Apellido_Materno} {apiResponse.Data.Nombres}".Trim();
                return new ApiResponseResultCEE { Response = apiResponse, NombreCompleto = nombreCompleto };
            }
            else
            {
                throw new Exception($"Error {response.StatusCode}: {responseContent}");
            }
        }
        public static async Task<ApiResponseResultDNI> GetInfoAsyncDNI(string id)
        {
            var response = await _httpClient.GetAsync(BaseUrlDNI + id);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var apiResponse = JsonConvert.DeserializeObject<ApiResponseDNI>(responseContent);
                string nombreCompleto = $"{apiResponse.Data.Apellido_Paterno} {apiResponse.Data.Apellido_Materno} {apiResponse.Data.Nombres}".Trim();
                return new ApiResponseResultDNI { Response = apiResponse, NombreCompleto = nombreCompleto };
            }
            else
            {
                throw new Exception($"Error {response.StatusCode}: {responseContent}");
            }
        }
        public static async Task<List<RepresentanteData>> GetRepresentantesAsync(string ruc)
        {
            var response = await _httpClient.GetAsync(BaseUrlRepresentantes + ruc);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var apiResponse = JsonConvert.DeserializeObject<ApiResponseRepresentante>(responseContent);
                return apiResponse.Data ?? new List<RepresentanteData>();
            }
            else
            {
                throw new Exception($"Error {response.StatusCode}: {responseContent}");
            }
        }
     
     
      
    }
}