using HpResergerUserControls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmTipodeCambio : FormGradient
    {
        public frmTipodeCambio()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        DataTable TablaConsultadias;
        byte[] ImgVenta;
        DateTime fechaactual;
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msglbl(string cadena) { lblmsg.Text = cadena; }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        public bool BusquedaExterna { get; internal set; }
        public DateTime FechaActual
        {
            get { return fechaactual; }
            set
            {
                fechaactual = value;
                CargarTipoCambio();
            }
        }
        //public class Detalle
        //{
        //    public string venta { get; set; }
        //    public string compra { get; set; }
        //}
        //public class TC
        //{
        //    public string fecha { get; set; }
        //    public Detalle Detalles { get; set; }
        //    public string venta { get; set; }
        //    public string compra { get; set; }
        //}
        public async Task<string> GetHTTPs(int año, int mes)
        {
            string url = Configuraciones.ApiTCSunat;// + año + "-" + mes.ToString("00");
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }
        public async Task<string> GetEstructura()
        {
            string url = Configuraciones.PaginaTCSunat;
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }
        private void TipodeCambio_Load(object sender, EventArgs e)
        {
            //  CargarTipoCambio();
            BuscarTipoCambio(DateTime.Now.Year, DateTime.Now.Month);
            //BuscarEstructura();
            ImgVenta = new byte[0];
            ImageConverter _imageConverter = new ImageConverter();
            ImgVenta = (byte[])_imageConverter.ConvertTo(pbigual.Image, typeof(byte[]));

            ColumnasTAblas();
            //busqueda de tipo de cambio
            TablaConsultadias = ConsultaDia();
            DataRow filitas = TablaConsultadias.Rows[0];
            //pregunta si ya esta guardado de la base de datos
            if ((int)filitas["contador"] != 0)
            {
                tablita = CapaLogica.TipodeCambio(0, comboMesAño1.GetFecha().Year, comboMesAño1.GetFecha().Month, 1, 0, 0, ImgVenta);
                dtgconten.DataSource = tablita;
                CargarImagenes();
            }
            else { CargarTipoCambio(); }
        }

        private async void BuscarEstructura()
        {
            string respuesta = await GetEstructura();
        }
        public class Anio
        {
            public string mes_nombre { get; set; }
            public int mes_valor { get; set; }
            public int anio { get; set; }
        }
        public class CambioActual
        {
            public string dia { get; set; }
            public string compra { get; set; }
            public string venta { get; set; }
        }
        public class Dias
        {
            public string dia { get; set; }
            public decimal compra { get; set; }
            public decimal venta { get; set; }
        }
        public class Ruta
        {
            public Anio anio { get; set; }
            public CambioActual cambio_actual { get; set; }
            public List<Dias> dias { get; set; }
        }
        public async void BuscarTipoCambio(int año, int mes)
        {
            try
            {
                string respuesta = await GetHTTPs(año, mes);
                respuesta = "[\n " + respuesta + " \n]";
                List<Ruta> lstTC = JsonConvert.DeserializeObject<List<Ruta>>(respuesta);
                //SAcamos la Data
                int CantDecimales = 5;
                int ela = respuesta.IndexOf(año + "-");
                if (lstTC.Count > 0)
                {
                    if (año == lstTC[0].anio.anio && mes == lstTC[0].anio.mes_valor)
                    {
                        foreach (Dias item in lstTC[0].dias)
                        {
                            CapaLogica.TipodeCambio(15, lstTC[0].anio.anio, lstTC[0].anio.mes_valor, int.Parse(item.dia), (item.compra), (item.venta), null);
                        }
                        Carga = true;
                        tablita = CapaLogica.TipodeCambio(0, comboMesAño1.GetFecha().Year, comboMesAño1.GetFecha().Month, 1, 0, 0, ImgVenta);
                        CompletarEstructura();
                        //webBrowser1_DocumentCompleted(new object(), new WebBrowserDocumentCompletedEventArgs(null));
                        Buscar_Click(new object(), new EventArgs());
                    }
                }
                //if (ela != -1)
                //{
                //    while (ela != 0)
                //    {
                //        DateTime TFecha = DateTime.Parse(respuesta.Substring(ela, 10));
                //        decimal Tcompra = decimal.Parse(respuesta.Substring(ela + 34, CantDecimales));
                //        decimal Tventa = decimal.Parse(respuesta.Substring(ela + 60, CantDecimales));
                //        //Proceso  de Insert en la base de Datos
                //        CapaLogica.TipodeCambio(15, TFecha.Year, TFecha.Month, TFecha.Day, Tcompra, Tventa, null);
                //        //Fin Insert
                //        ela = respuesta.IndexOf(año + "-", ela + 50);
                //        if (ela == -1) break;
                //    }
                //    Carga = true;
                //    webBrowser1_DocumentCompleted(new object(), new WebBrowserDocumentCompletedEventArgs(null));
                //    Buscar_Click(new object(), new EventArgs());
                //}


            }
            catch (Exception) { BuscarTipoCambio(año, mes); }
        }
        public DataTable ConsultaDia()
        {
            return CapaLogica.TipodeCambio(10, comboMesAño1.GetFecha().Year, comboMesAño1.GetFecha().Month, 1, 0, 0, ImgVenta);
        }
        public void CargarTipoCambio()
        {
            try
            {
                //webBrowser1.Navigate("http://www.sunat.gob.pe/cl-at-ittipcam/tcS01Alias");
                //webBrowser1.Navigate(Configuraciones.PaginaTCSunat);

            }
            catch { msg("No Se pudo Conectar con la Sunat"); }
        }
        public Boolean Carga = false;
        DataTable tablita = new DataTable();
        public void ColumnasTAblas()
        {
            try
            {
                tablita.Columns.Add("Dia", typeof(int));
                tablita.Columns.Add("Compra", typeof(decimal));
                tablita.Columns.Add("Venta", typeof(decimal));
                tablita.Columns.Add("Mes", typeof(int));
                tablita.Columns.Add("Año", typeof(int));
                tablita.Columns.Add("CompraImg", typeof(byte[]));
                tablita.Columns.Add("VentaImg", typeof(byte[]));
            }
            catch (Exception) { }
        }
        string[] Tcambio = new string[3];
        public void CompletarEstructura()
        {
            if (tablita.Rows.Count > 0)
            {
                DataRow filita = tablita.Rows[0];
                DataRow filiaux;
                int min = int.Parse(filita["dia"].ToString());
                filita = tablita.Rows[tablita.Rows.Count - 1];
                int max;
                max = int.Parse(filita["dia"].ToString());
                int aux = 0;
                for (int i = min; i <= max; i++)
                {
                    //completa los dias Saltados
                    filita = tablita.Rows[aux];
                    if (int.Parse(filita["dia"].ToString()) != i)
                    {
                        filiaux = tablita.NewRow();
                        filita = tablita.Rows[aux - 1];
                        filiaux["dia"] = i;
                        filiaux["mes"] = filita["mes"];
                        filiaux["año"] = filita["año"];
                        filiaux["compra"] = filita["compra"];
                        filiaux["venta"] = filita["venta"];
                        tablita.Rows.InsertAt(filiaux, aux);
                        aux++;
                    }
                    else { aux++; }
                }
                //Completa al Dia Actual
                if (comboMesAño1.GetFecha().Month == DateTime.Now.Month && comboMesAño1.GetFecha().Year == DateTime.Now.Year)
                {
                    int dif = 0; int inicial;
                    filita = tablita.Rows[tablita.Rows.Count - 1];
                    dif = DateTime.Now.Day - (int)filita["dia"];
                    inicial = (int)filita["dia"];
                    for (int i = 0; i < dif; i++)
                    {
                        filiaux = tablita.NewRow();
                        filiaux["dia"] = inicial + i + 1;
                        filiaux["mes"] = filita["mes"];
                        filiaux["año"] = filita["año"];
                        filiaux["compra"] = filita["compra"];
                        filiaux["venta"] = filita["venta"];
                        tablita.Rows.Add(filiaux);
                    }
                }
                ///completar el ultimo dia del mes 
                //if ((int)filita["mes"] != DateTime.Now.Month && (int)filita["año"] != DateTime.Now.Year)
                DateTime fechax = new DateTime((int)filita["año"], (int)filita["mes"], 1);
                DateTime fechita = DateTime.Now;
                if (new DateTime(fechita.Year, fechita.Month, 1) > new DateTime(fechax.Year, fechax.Month, 1))
                {
                    int mesio = comboMesAño1.GetFecha().Month;
                    int añio = comboMesAño1.GetFecha().Year;
                    int length = (int)(tablita.Rows[tablita.Rows.Count - 1])["dia"];
                    if (comboMesAño1.UltimoDiaDelMes().Day != length)
                    {
                        for (int i = length; i < comboMesAño1.UltimoDiaDelMes().Day; i++)
                        {
                            filiaux = tablita.NewRow();
                            filiaux["dia"] = i + 1;
                            filiaux["mes"] = comboMesAño1.GetFecha().Month;
                            filiaux["año"] = comboMesAño1.GetFecha().Year;
                            filiaux["compra"] = (tablita.Rows[tablita.Rows.Count - 1])["compra"];
                            filiaux["venta"] = (tablita.Rows[tablita.Rows.Count - 1])["venta"];
                            tablita.Rows.Add(filiaux);
                        }
                        foreach (DataRow filitas in tablita.Rows)
                        {
                            //inserto a la base de datos el tipo de cambio
                            CapaLogica.TipodeCambio(1, (int)filitas["año"], (int)filitas["mes"], (int)filitas["dia"], (decimal)filitas["compra"], (decimal)filitas["venta"], ImgVenta);
                        }
                    }
                }
                foreach (DataRow filitas in tablita.Rows)
                {
                    //inserto a la base de datos el tipo de cambio
                    CapaLogica.TipodeCambio(1, (int)filitas["año"], (int)filitas["mes"], (int)filitas["dia"], (decimal)filitas["compra"], (decimal)filitas["venta"], ImgVenta);
                }
                tablita = CapaLogica.TipodeCambio(0, comboMesAño1.GetFecha().Year, comboMesAño1.GetFecha().Month, 1, 0, 0, ImgVenta);
                dtgconten.DataSource = tablita;
                CargarImagenes();
                OnActualizoTipoCambio(new EventArgs());
            }
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                if (Carga == false)
                {
                    webBrowser1.Document.GetElementById("mes").SetAttribute("value", comboMesAño1.getMesNumero().ToString("00"));
                    webBrowser1.Document.GetElementById("anho").SetAttribute("value", comboMesAño1.GetAño().ToString());
                    webBrowser1.Document.GetElementById("B1").InvokeMember("click");
                    Carga = true;
                    return;
                }
            }
            catch (Exception ex) { msglbl("No hay Conexion a Sunat"); return; }
            //if (Carga == true)
            //{
            //    tablita.Clear();
            //    HtmlElementCollection datos = webBrowser1.Document.GetElementsByTagName("td");
            //    int con = 0; string cadena = "";
            //    foreach (HtmlElement dato in datos)
            //    {
            //        if (dato.InnerText.Trim() != "Tipo de cambio publicado al :")
            //        {
            //            if (char.IsDigit(char.Parse((dato.InnerText.Substring(0, 1)))))
            //            {
            //                con++;
            //                cadena += dato.InnerText;
            //                if (con == 3)
            //                {
            //                    Tcambio = cadena.Split(' ');
            //                    tablita.Rows.Add(int.Parse(Tcambio[0]), decimal.Parse(Tcambio[1]), decimal.Parse(Tcambio[2]), comboMesAño1.getMesNumero(), comboMesAño1.GetAño(), ImgVenta, ImgVenta);
            //                    con = 0;
            //                    cadena = "";
            //                }
            //            }
            //        }
            //    }
            //}
            if (tablita.Rows.Count > 0)
            {
                DataRow filita = tablita.Rows[0];
                DataRow filiaux;
                int min = int.Parse(filita["dia"].ToString());
                filita = tablita.Rows[tablita.Rows.Count - 1];
                int max;
                max = int.Parse(filita["dia"].ToString());
                int aux = 0;
                for (int i = min; i <= max; i++)
                {
                    //completa los dias Saltados
                    filita = tablita.Rows[aux];
                    if (int.Parse(filita["dia"].ToString()) != i)
                    {
                        filiaux = tablita.NewRow();
                        filita = tablita.Rows[aux - 1];
                        filiaux["dia"] = i;
                        filiaux["mes"] = filita["mes"];
                        filiaux["año"] = filita["año"];
                        filiaux["compra"] = filita["compra"];
                        filiaux["venta"] = filita["venta"];
                        tablita.Rows.InsertAt(filiaux, aux);
                        aux++;
                    }
                    else { aux++; }
                }
                //Completa al Dia Actual
                if (comboMesAño1.GetFecha().Month == DateTime.Now.Month && comboMesAño1.GetFecha().Year == DateTime.Now.Year)
                {
                    int dif = 0; int inicial;
                    filita = tablita.Rows[tablita.Rows.Count - 1];
                    dif = DateTime.Now.Day - (int)filita["dia"];
                    inicial = (int)filita["dia"];
                    for (int i = 0; i < dif; i++)
                    {
                        filiaux = tablita.NewRow();
                        filiaux["dia"] = inicial + i + 1;
                        filiaux["mes"] = filita["mes"];
                        filiaux["año"] = filita["año"];
                        filiaux["compra"] = filita["compra"];
                        filiaux["venta"] = filita["venta"];
                        tablita.Rows.Add(filiaux);
                    }
                }
                ///completar el ultimo dia del mes 
                //if ((int)filita["mes"] != DateTime.Now.Month && (int)filita["año"] != DateTime.Now.Year)
                DateTime fechax = new DateTime((int)filita["año"], (int)filita["mes"], 1);
                DateTime fechita = DateTime.Now;
                if (new DateTime(fechita.Year, fechita.Month, 1) > new DateTime(fechax.Year, fechax.Month, 1))
                {
                    int mesio = comboMesAño1.GetFecha().Month;
                    int añio = comboMesAño1.GetFecha().Year;
                    int length = (int)(tablita.Rows[tablita.Rows.Count - 1])["dia"];
                    if (comboMesAño1.UltimoDiaDelMes().Day != length)
                    {
                        for (int i = length; i < comboMesAño1.UltimoDiaDelMes().Day; i++)
                        {
                            filiaux = tablita.NewRow();
                            filiaux["dia"] = i + 1;
                            filiaux["mes"] = comboMesAño1.GetFecha().Month;
                            filiaux["año"] = comboMesAño1.GetFecha().Year;
                            filiaux["compra"] = (tablita.Rows[tablita.Rows.Count - 1])["compra"];
                            filiaux["venta"] = (tablita.Rows[tablita.Rows.Count - 1])["venta"];
                            tablita.Rows.Add(filiaux);
                        }
                        foreach (DataRow filitas in tablita.Rows)
                        {
                            //inserto a la base de datos el tipo de cambio
                            CapaLogica.TipodeCambio(1, (int)filitas["año"], (int)filitas["mes"], (int)filitas["dia"], (decimal)filitas["compra"], (decimal)filitas["venta"], ImgVenta);
                        }
                    }
                }
                //Buscar el Ultimo Valor del mes anterior
                //filita = tablita.Rows[0];
                //int UltDia = (int)filita["dia"];
                ////Sí es Diferente a uno, es quue el mes ta incompleto
                ////toca buscar al mes anterior el ultimo tipo de cambio
                //if (UltDia != 1 && tablita.Rows.Count > 0)
                //{
                //    DataTable TablaTemporal = new DataTable();
                //    int anio, mesio;
                //    anio = comboMesAño1.GetFechaPRimerDia().AddDays(-1).Year;
                //    mesio = comboMesAño1.GetFechaPRimerDia().AddDays(-1).Month;
                //    TablaTemporal = CapaLogica.TipodeCambio(0, anio, mesio, 1, 0, 0, null);
                //    if (TablaTemporal.Rows.Count > 0)
                //    {
                //        DataRow FilaTemporal = TablaTemporal.Rows[TablaTemporal.Rows.Count - 1];
                //        for (int i = 1; i < UltDia; i++)
                //        {
                //            //completo el mes desde el inicio
                //            filiaux = tablita.NewRow();
                //            filiaux["dia"] = i;
                //            filiaux["mes"] = comboMesAño1.GetFecha().Month;
                //            filiaux["año"] = comboMesAño1.GetFecha().Year;
                //            filiaux["compra"] = FilaTemporal["compra"];
                //            filiaux["venta"] = FilaTemporal["venta"];
                //            tablita.Rows.InsertAt(filiaux, i - 1);
                //        }                        
                //    }
                //}
                foreach (DataRow filitas in tablita.Rows)
                {
                    //inserto a la base de datos el tipo de cambio
                    CapaLogica.TipodeCambio(1, (int)filitas["año"], (int)filitas["mes"], (int)filitas["dia"], (decimal)filitas["compra"], (decimal)filitas["venta"], ImgVenta);
                }
                tablita = CapaLogica.TipodeCambio(0, comboMesAño1.GetFecha().Year, comboMesAño1.GetFecha().Month, 1, 0, 0, ImgVenta);
                dtgconten.DataSource = tablita;
                CargarImagenes();
                OnActualizoTipoCambio(new EventArgs());
            }
            else
            {
                //msg("No Hay Datos de Tipo de Cambio para este Mes");
            }
            //tablita = CapaLogica.TipodeCambio(0, comboMesAño1.GetFecha().Year, comboMesAño1.GetFecha().Month, 1, 0, 0, ImgVenta);
            //dtgconten.DataSource = tablita;
            //CargarImagenes();
            BusquedaExterna = true;
        }
        public event EventHandler ActualizoTipoCambio;
        protected virtual void OnActualizoTipoCambio(EventArgs e)
        {
            ActualizoTipoCambio?.Invoke(this, e);
        }
        private void Btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Buscar_Click(object sender, EventArgs e)
        {
            msglbl("");
            if (dtgconten.DataSource != null) dtgconten.DataSource = ((DataTable)dtgconten.DataSource).Clone();
            else dtgconten.DataSource = null;
            BusquedaExterna = false;
            //busqueda de tipo de cambio
            TablaConsultadias = ConsultaDia();
            DataRow filitas = TablaConsultadias.Rows[0];
            //pregunta si ya esta guardado de la base de datos
            if ((int)filitas["contador"] != 0)
            {
                tablita = CapaLogica.TipodeCambio(0, comboMesAño1.GetFecha().Year, comboMesAño1.GetFecha().Month, 1, 0, 0, ImgVenta);
                //verificamos si el primer dia es 1
                DataRow filita = tablita.Rows[0];
                int UltDia = (int)filita["dia"];
                ///completar el ultimo dia del mes 
                if ((int)filita["mes"] != DateTime.Now.Month && (int)filita["año"] != DateTime.Now.Year)
                {
                    int mesio = comboMesAño1.GetFecha().Month;
                    int añio = comboMesAño1.GetFecha().Year;
                    int length = (int)(tablita.Rows[tablita.Rows.Count - 1])["dia"];
                    if (comboMesAño1.UltimoDiaDelMes().Day != length)
                    {
                        for (int i = length; i < comboMesAño1.UltimoDiaDelMes().Day; i++)
                        {
                            DataRow filiaux;
                            filiaux = tablita.NewRow();
                            filiaux["dia"] = i + 1;
                            filiaux["mes"] = comboMesAño1.GetFecha().Month;
                            filiaux["año"] = comboMesAño1.GetFecha().Year;
                            filiaux["compra"] = (tablita.Rows[tablita.Rows.Count - 1])["compra"];
                            filiaux["venta"] = (tablita.Rows[tablita.Rows.Count - 1])["venta"];
                            tablita.Rows.Add(filiaux);
                        }
                        foreach (DataRow filitass in tablita.Rows)
                        {
                            //inserto a la base de datos el tipo de cambio
                            CapaLogica.TipodeCambio(1, (int)filitass["año"], (int)filitass["mes"], (int)filitass["dia"], (decimal)filitass["compra"], (decimal)filitass["venta"], ImgVenta);
                        }
                        tablita = CapaLogica.TipodeCambio(0, comboMesAño1.GetFecha().Year, comboMesAño1.GetFecha().Month, 1, 0, 0, ImgVenta);
                    }
                }
                //Sí es Diferente a uno, es quue el mes ta incompleto
                //toca buscar al mes anterior el ultimo tipo de cambio                
                if (UltDia != 1 && tablita.Rows.Count > 0)
                {
                    DataTable TablaTemporal = new DataTable();
                    int anio, mesio;
                    anio = comboMesAño1.GetFechaPRimerDia().AddDays(-1).Year;
                    mesio = comboMesAño1.GetFechaPRimerDia().AddDays(-1).Month;
                    TablaTemporal = CapaLogica.TipodeCambio(0, anio, mesio, 1, 0, 0, null);
                    if (TablaTemporal.Rows.Count > 0)
                    {
                        DataRow FilaTemporal = TablaTemporal.Rows[TablaTemporal.Rows.Count - 1];
                        for (int i = 1; i < UltDia; i++)
                        {
                            //completo el mes desde el inicio
                            DataRow filiaux;
                            filiaux = tablita.NewRow();
                            filiaux["dia"] = i;
                            filiaux["mes"] = comboMesAño1.GetFecha().Month;
                            filiaux["año"] = comboMesAño1.GetFecha().Year;
                            filiaux["compra"] = FilaTemporal["compra"];
                            filiaux["venta"] = FilaTemporal["venta"];
                            tablita.Rows.InsertAt(filiaux, i - 1);
                        }
                    }
                    foreach (DataRow filitass in tablita.Rows)
                    {
                        //inserto a la base de datos el tipo de cambio
                        CapaLogica.TipodeCambio(1, (int)filitass["año"], (int)filitass["mes"], (int)filitass["dia"], (decimal)filitass["compra"], (decimal)filitass["venta"], ImgVenta);
                    }
                    tablita = CapaLogica.TipodeCambio(0, comboMesAño1.GetFecha().Year, comboMesAño1.GetFecha().Month, 1, 0, 0, ImgVenta);
                }
                dtgconten.DataSource = tablita;
                CargarImagenes();
            }
            else
            {
                tablita = CapaLogica.TipodeCambio(0, comboMesAño1.GetFecha().Year, comboMesAño1.GetFecha().Month, 1, 0, 0, ImgVenta);
                dtgconten.DataSource = tablita;
                CargarImagenes();
                //DataTable tables= CapaLogica.TipodeCambio(10, comboMesAño1.GetFecha().AddMonths(1).Year, comboMesAño1.GetFecha().AddMonths(1).Month, 1, 0, 0, ImgVenta);
                //DataRow filita = tables.Rows[0];
                ////pregunta si ya esta guardado de la base de datos
                //if ((int)filita["contador"] != 0)
                //CargarTipoCambio();
                try
                {
                    Carga = false;
                    //webBrowser1.Navigate(Configuraciones.PaginaTCSunat);
                    //BuscarTipoCambio(comboMesAño1.GetFecha().Year, comboMesAño1.GetFecha().Month);

                    //webBrowser1.Document.GetElementById("mes").SetAttribute("value", comboMesAño1.getMesNumero().ToString("00"));
                    //webBrowser1.Document.GetElementById("anho").SetAttribute("value", comboMesAño1.GetAño().ToString());
                    //webBrowser1.Document.GetElementById("B1").InvokeMember("click");
                }
                catch (Exception ex)
                {
                    //MSG("No Hay Información para este Mes");
                    //tablita = CapaLogica.TipodeCambio(0, comboMesAño1.GetFecha().Year, comboMesAño1.GetFecha().Month, 1, 0, 0, ImgVenta);
                    //dtgconten.DataSource = tablita;
                    //CargarImagenes();
                }
            }
            BusquedaExterna = true;
        }
        private void dtgconten_MouseDown(object sender, MouseEventArgs e)
        {
            dtgconten.EndEdit();
            if (e.Button == MouseButtons.Left)
            {
                if (dtgconten.CurrentCell.Value != null)
                    DoDragDrop(dtgconten.CurrentCell.Value.ToString(), DragDropEffects.Copy);

            }
        }
        public void CargarImagenes()
        {
            int i = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if (i != 0)
                {
                    //compras
                    if ((decimal)item.Cells[Compra.Name].Value > (decimal)dtgconten[Compra.Name, i - 1].Value)
                        dtgconten[cp.Name, i].Value = pbup.Image;
                    if ((decimal)item.Cells[Compra.Name].Value < (decimal)dtgconten[Compra.Name, i - 1].Value)
                        dtgconten[cp.Name, i].Value = pbdown.Image;
                    if ((decimal)item.Cells[Compra.Name].Value == (decimal)dtgconten[Compra.Name, i - 1].Value)
                        dtgconten[cp.Name, i].Value = pbigual.Image;
                    //ventas
                    if ((decimal)item.Cells[Venta.Name].Value > (decimal)dtgconten[Venta.Name, i - 1].Value)
                        dtgconten[vv.Name, i].Value = pbup.Image;
                    if ((decimal)item.Cells[Venta.Name].Value < (decimal)dtgconten[Venta.Name, i - 1].Value)
                        dtgconten[vv.Name, i].Value = pbdown.Image;
                    if ((decimal)item.Cells[Venta.Name].Value == (decimal)dtgconten[Venta.Name, i - 1].Value)
                        dtgconten[vv.Name, i].Value = pbigual.Image;
                }
                i++;
            }
        }
        frmProcesando frmpro;
        DateTime Fechas;
        //TimeSpan Stop;
        //TimeSpan Inicio;
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                ///* Inicio = new TimeSpan(DateTim*/e.Now.Ticks);
                dtgconten.SuspendLayout();
                frmpro = new frmProcesando();
                frmpro.Show(); Cursor = Cursors.WaitCursor;
                Fechas = comboMesAño1.GetFecha();
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                msg("No hay Datos que Mostrar");
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            List<HPResergerFunciones.Utilitarios.RangoCelda> RangosCeldas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
            HPResergerFunciones.Utilitarios.RangoCelda celda1 = new HPResergerFunciones.Utilitarios.RangoCelda("a1", "c1", "TIPO DE CAMBIO", 14);
            RangosCeldas.Add(celda1);
            HPResergerFunciones.Utilitarios.RangoCelda celda2 = new HPResergerFunciones.Utilitarios.RangoCelda("a2", "c2", $"Correspondiente a {Fechas.ToString("MMMM") } del {Fechas.Year}", 12);
            RangosCeldas.Add(celda2);

            HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", "TIPO_DE_CAMBIO", RangosCeldas, 3, new int[] { 1, 2, 3 }, new int[] { }, new int[] { });
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmpro.Close();
            //Stop = new TimeSpan(DateTime.Now.Ticks);
            // msg($"tiempos: {Stop.Subtract(Inicio).TotalMilliseconds}");
            dtgconten.ResumeLayout();
        }
        frmaddtipoCambio frmaddtipo;
        private void btnaddtipo_Click(object sender, EventArgs e)
        {
            if (frmaddtipo == null)
            {
                frmaddtipo = new frmaddtipoCambio();
                frmaddtipo.MdiParent = this.MdiParent;
                frmaddtipo.fechatipo = comboMesAño1.GetFecha();
                frmaddtipo.FormClosed += Frmaddtipo_FormClosed;
                frmaddtipo.Show();
            }
            else { frmaddtipo.Activate(); }
            //webBrowser1.BringToFront();
            //webBrowser1.Visible = true;
        }
        private void Frmaddtipo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Buscar_Click(sender, e);
            frmaddtipo = null;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour > 7 && DateTime.Now.Hour < 17)//coontrol de que hora se procede con la actualizacion
            {                
                if (FechaActual != DateTime.Now.Date)
                {                
                    //  BuscarTipoCambio(DateTime.Now.Year, DateTime.Now.Month);
                    BuscarTipodeCambiodelDia();
                }

                FechaActual = DateTime.Now;
                comboMesAño1.ActualizarMesAÑo(FechaActual.Month, FechaActual.Year);
                //MSG("REfrescado");
            }
        }
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class TIPOCAMBIO
        {
            public decimal compra { get; set; }
            public decimal venta { get; set; }
            public string origen { get; set; }
            public string moneda { get; set; }
            public DateTime fecha { get; set; }
        }
        public async Task<string> GetHTTPs()
        {
            string url = Configuraciones.APITcDiario + Configuraciones.ToFechaSql(DateTime.Now);// + año + "-" + mes.ToString("00");
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }
        public async void BuscarTipodeCambiodelDia()
        {
            try
            {
                string respuesta = await GetHTTPs();
                respuesta = "[\n " + respuesta + " \n]";
                List<TIPOCAMBIO> lstTC = JsonConvert.DeserializeObject<List<TIPOCAMBIO>>(respuesta);
                //SAcamos la Data             
                if (lstTC.Count > 0)
                {
                    CapaLogica.TipodeCambio(15, lstTC[0].fecha.Year, lstTC[0].fecha.Month, lstTC[0].fecha.Day, lstTC[0].compra, lstTC[0].venta, null);
                }
            }
            catch (Exception) { }
        }
    }
}
