using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger.ModuloBancario
{
    public partial class frmBancoScotiaBank : FormGradient
    {
        public frmBancoScotiaBank()
        {
            InitializeComponent();
        }
        public DataTable TablaProveedorBanco;
        public List<frmPagarFactura.FACTURAS> Comprobantes = new List<frmPagarFactura.FACTURAS>();
        public DataTable TablaComprobantes { get; private set; }
        public DataTable TablaConsulta { get; private set; }
        DataTable TFormasPago;
        public void CargarDatosTablas()
        {
            TFormasPago = new DataTable();
            TFormasPago.Columns.Add("codigo", typeof(int));
            TFormasPago.Columns.Add("descripcion", typeof(string));
            TFormasPago.Rows.Add(1, "Cheque Gerencia");
            TFormasPago.Rows.Add(2, "Ab. Cuenta Corriente");
            TFormasPago.Rows.Add(3, "Ab. Cuenta Ahorros");
            TFormasPago.Rows.Add(4, "Ab. Otros Bancos");
        }
        private void frmBancoScotiaBank_Load(object sender, EventArgs e)
        {
            CargarDatosTablas();
            //Pasamos los datos de las Facturas a una Tabla
            TablaComprobantes = new DataTable();
            TablaComprobantes.Columns.Add("index", typeof(int));
            TablaComprobantes.Columns.Add("tipo", typeof(string));
            TablaComprobantes.Columns.Add("numero", typeof(string));
            TablaComprobantes.Columns.Add("proveedor", typeof(string));
            TablaComprobantes.Columns.Add("detraccion", typeof(decimal));
            TablaComprobantes.Columns.Add("total", typeof(decimal));
            TablaComprobantes.Columns.Add("fechacancelado", typeof(DateTime));
            TablaComprobantes.Columns.Add("FechaFactura", typeof(DateTime));
            int i = 1;
            foreach (frmPagarFactura.FACTURAS fac in Comprobantes)
            {
                //TablaComprobantes.Rows.Add(new object[] { 1, fac.tipo, fac.numero, fac.proveedor, fac.detraccion, fac.total, fac.fechacancelado });
                TablaComprobantes.Rows.Add(new object[] { 1, fac.tipo, fac.numero, fac.proveedor, fac.detraccion, fac.aPagar, fac.fechacancelado, fac.FechaEmision });
                i++;
            }
            //Hacemos el Union entre Facturas y Proveedores
            var cargas = from tblcomprobante in TablaComprobantes.AsEnumerable()
                         join tblproveedor in TablaProveedorBanco.AsEnumerable() on tblcomprobante["proveedor"].ToString().Trim() equals (string)tblproveedor["ruc"].ToString().Trim()
                         select new
                         {
                             index = tblcomprobante["index"],
                             proveedor = tblcomprobante["proveedor"],
                             razonsocial = tblproveedor["razon_social"],
                             ctaseleccionada = tblproveedor["ctaseleccionada"],
                             cuentasoles = tblproveedor["nro_cta_soles"],
                             cuentaccisoles = tblproveedor["nro_cta_cci_soles"],
                             tipo = tblcomprobante["tipo"],
                             nro = tblcomprobante["numero"],
                             total = decimal.Parse(tblcomprobante["total"].ToString()),
                             fechacancelado = tblcomprobante["fechacancelado"],
                             fechaFactura = tblcomprobante["FechaFactura"],
                             banco = tblproveedor["Entidad_Financiera"],
                             tipocuenta = tblproveedor["tipocuenta"],
                             email = tblproveedor["email"]
                         };
            ////cargar valores de los proveedores     
            TablaConsulta = new DataTable();
            TablaConsulta.Columns.Add("ruc", typeof(string));
            TablaConsulta.Columns.Add("razonsocial", typeof(string));
            TablaConsulta.Columns.Add("nrofactura", typeof(string));
            TablaConsulta.Columns.Add("fechafactura", typeof(DateTime));
            TablaConsulta.Columns.Add("montoPagar", typeof(decimal));
            TablaConsulta.Columns.Add("formapago", typeof(int));
            TablaConsulta.Columns.Add("codigooficina", typeof(string));
            TablaConsulta.Columns.Add("codigocuenta", typeof(string));
            TablaConsulta.Columns.Add("simplepay", typeof(string));
            TablaConsulta.Columns.Add("email", typeof(string));
            TablaConsulta.Columns.Add("cci", typeof(string));
            TablaConsulta.Columns.Add("factoring", typeof(string));
            TablaConsulta.Columns.Add("fechavencimiento", typeof(DateTime));
            TablaConsulta.Columns.Add("trans", typeof(string));
            //paso para la configuracion de la tabla 
            foreach (var x in cargas)
            {
                int FormadePago = 0;
                string CodigoOficinas = "000";
                string CodigoCuentaCCI = "";
                string CodigoCuenta = "";
                //FormaPago
                //1: para Cheque de Gerencia
                //2: para Abono en Cuenta Corriente Scotiabank
                //3: para Abono en Cuenta Ahorros Scotiabank
                //4: para Abono en Cuenta en Otro Banco
                if (x.cuentaccisoles.ToString().Substring(0, x.cuentaccisoles.ToString().Length - 6) == x.ctaseleccionada.ToString())
                {
                    FormadePago = 4;
                    CodigoCuentaCCI = x.ctaseleccionada.ToString();
                    CodigoOficinas = "";
                }
                else if (x.tipocuenta.ToString().ToUpper() == "AHORROS")
                {
                    FormadePago = 3;
                    CodigoCuenta = x.ctaseleccionada.ToString();
                }
                else
                {
                    FormadePago = 2;
                    CodigoCuenta = x.ctaseleccionada.ToString();
                }
                TablaConsulta.Rows.Add(x.proveedor, x.razonsocial.ToString().Substring(0, x.razonsocial.ToString().Length > 60 ? 60 : x.razonsocial.ToString().Length), x.nro, x.fechaFactura, x.total, FormadePago, CodigoOficinas, CodigoCuenta, "", x.email, CodigoCuentaCCI, "", null, "");
            }
            dtgconten.DataSource = TablaConsulta;

        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        DataGridViewComboBoxColumn combo;
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.ColumnIndex;
            if (e.RowIndex >= 0)
            {
                combo = dtgconten.Columns[xFormaPago.Name] as DataGridViewComboBoxColumn;
                combo.ValueMember = "codigo";
                combo.DisplayMember = "descripcion";
                combo.DataSource = TFormasPago;
            }
        }

        private void dtgconten_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                if (dtgconten.Columns[xFactoring.Name].Index == y)
                {
                    string cadena = dtgconten[y, x].Value.ToString();
                    if (cadena.Length > 0 && cadena != "F")
                        dtgconten[y, x].Value = "F";
                }
                if (dtgconten.Columns[xTransExterior.Name].Index == y)
                {
                    string cadena = dtgconten[y, x].Value.ToString();
                    if (cadena.Length > 0 && cadena != "*")
                        dtgconten[y, x].Value = "*";
                }
                if (dtgconten.Columns[xSimplePay.Name].Index == y)
                {
                    string cadena = dtgconten[y, x].Value.ToString();
                    if (cadena.Length > 0 && cadena != "*")
                        dtgconten[y, x].Value = "*";
                }
            }
        }
        public Boolean ValidarDatosLlenados()
        {
            Boolean Prueba = true;
            DateTime PruebaFecha;
            decimal PRuebaDecimal;
            int PruebaInt;
            string cadena = "";
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                //validamos el Ruc
                if (item.Cells[xRuc.Name].Value.ToString().Length > 11)
                {
                    HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xRuc.Name]); Prueba = false;
                }
                else
                {
                    HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xRuc.Name]);
                }
                if (item.Cells[xRazonSocial.Name].Value.ToString().Length > 60)
                {
                    item.Cells[xRazonSocial.Name].Value = item.Cells[xRazonSocial.Name].Value.ToString().Trim().Substring(0, 60);
                }
                if (item.Cells[xNroFactura.Name].Value.ToString().Length > 14)
                {
                    item.Cells[xNroFactura.Name].Value = item.Cells[xNroFactura.Name].Value.ToString().Trim().Substring(0, 14);
                }
                if (!DateTime.TryParse(item.Cells[xFechaFactura.Name].Value.ToString(), out PruebaFecha))
                {
                    HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xFechaFactura.Name]); Prueba = false;
                }
                else
                {
                    HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xFechaFactura.Name]);
                }
                if (!decimal.TryParse(item.Cells[xMontoPagar.Name].Value.ToString(), out PRuebaDecimal) && PRuebaDecimal <= 0)
                {
                    HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xMontoPagar.Name]); Prueba = false;
                }
                else
                {
                    HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xMontoPagar.Name]);
                }
                PruebaInt = (int)item.Cells[xFormaPago.Name].Value;
                if (PruebaInt == 1 || PruebaInt == 4)//1:ChequeGerencia 4:AbonoOtroBanco
                {
                    item.Cells[xCodigoOficina.Name].Value = "";
                    item.Cells[xCodigoCuenta.Name].Value = "";
                    item.Cells[xTransExterior.Name].Value = "";
                    if (PruebaInt == 4)
                    {
                        item.Cells[xSimplePay.Name].Value = "";
                        item.Cells[xFactoring.Name].Value = "";
                        cadena = item.Cells[xcci.Name].Value.ToString();
                        if (cadena.Length != 20)
                        {
                            HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xcci.Name]); Prueba = false;
                        }
                        else
                        {
                            HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xcci.Name]);
                        }
                    }
                    if (PruebaInt == 1)
                    {
                        item.Cells[xcci.Name].Value = "";
                    }
                }
                if (PruebaInt == 2 || PruebaInt == 3)
                {
                    //COdigo Oficina
                    item.Cells[xcci.Name].Value = "";
                    item.Cells[xFactoring.Name].Value = "";
                    cadena = item.Cells[xCodigoOficina.Name].Value.ToString();
                    if (cadena.Length != 3)
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xCodigoOficina.Name]); Prueba = false;
                    }
                    else
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xCodigoOficina.Name]);
                    }
                    cadena = item.Cells[xCodigoCuenta.Name].Value.ToString();
                    //Codigo Cuenta
                    if (cadena.Length != 7)
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xCodigoCuenta.Name]); Prueba = false;
                    }
                    else
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xCodigoCuenta.Name]);
                    }
                    if (PruebaInt == 3)
                    {
                        item.Cells[xTransExterior.Name].Value = "";
                    }
                }
                if (item.Cells[xEmail.Name].Value.ToString().Length > 30)
                {
                    HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xEmail.Name]); Prueba = false;
                }
                else
                {
                    HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xEmail.Name]);
                }
                if (item.Cells[xFactoring.Name].Value.ToString() == "F")
                {
                    if (!DateTime.TryParse(item.Cells[xFechaVencimiento.Name].Value.ToString(), out PruebaFecha))
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xFechaVencimiento.Name]); Prueba = false;

                    }
                    else
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xFechaVencimiento.Name]);
                }
                else
                {
                    item.Cells[xFechaVencimiento.Name].Value = null;
                }

            }
            return Prueba;
        }
        public void msg(string cadena) { HPResergerFunciones.Utilitarios.msg(cadena); }
        public DialogResult msgYesNO(string cadena) { return HPResergerFunciones.Utilitarios.msgYesNo(cadena); }

        string cadenatxt = "";
        private StreamWriter st;
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosLlenados())
            {
                PAgoFactura = false;
                int con = dtgconten.RowCount;
                if (con > 0)
                {
                    cadenatxt = "";
                    string[] campo = new string[14];
                    foreach (DataGridViewRow item in dtgconten.Rows)
                    {
                        campo[0] = item.Cells[xRuc.Name].Value.ToString().Trim();
                        campo[1] = HPResergerFunciones.Utilitarios.AddCaracter(item.Cells[xRazonSocial.Name].Value.ToString().Trim(), ' ', 60, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                        campo[2] = HPResergerFunciones.Utilitarios.AddCaracter(item.Cells[xNroFactura.Name].Value.ToString().Trim(), ' ', 14, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                        campo[3] = ((DateTime)item.Cells[xFechaFactura.Name].Value).ToString("yyyyMMdd");
                        campo[4] = HPResergerFunciones.Utilitarios.AddCaracterMultiplicarx100(item.Cells[xMontoPagar.Name].Value.ToString(), '0', 11, HPResergerFunciones.Utilitarios.Direccion.derecha);
                        campo[5] = item.Cells[xFormaPago.Name].Value.ToString();
                        campo[6] = HPResergerFunciones.Utilitarios.AddCaracter(item.Cells[xCodigoOficina.Name].Value.ToString().Trim(), ' ', 3, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                        campo[7] = HPResergerFunciones.Utilitarios.AddCaracter(item.Cells[xCodigoCuenta.Name].Value.ToString().Trim(), ' ', 7, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                        //SimplePay
                        campo[8] = HPResergerFunciones.Utilitarios.AddCaracter(item.Cells[xSimplePay.Name].Value.ToString().Trim(), ' ', 1, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                        campo[9] = HPResergerFunciones.Utilitarios.AddCaracter(item.Cells[xEmail.Name].Value.ToString().Trim(), ' ', 30, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                        campo[10] = item.Cells[xcci.Name].Value.ToString();
                        campo[11] = item.Cells[xFactoring.Name].Value.ToString();
                        campo[12] = item.Cells[xFechaVencimiento.Name].Value.ToString() == "" ? "        " : ((DateTime)item.Cells[xFechaVencimiento.Name].Value).ToString("yyyyMMdd");
                        campo[13] = item.Cells[xTransExterior.Name].Value.ToString();
                        cadenatxt += string.Join("", campo) + $"{Environment.NewLine}";
                    }
                    //msg(cadenatxt);
                    SaveFile.FileName = "Proveedores ScotiaBank " + DateTime.Now.ToLongDateString();
                    if (SaveFile.FileName != string.Empty && SaveFile.ShowDialog() == DialogResult.OK)
                    {
                        string path = SaveFile.FileName;
                        st = File.CreateText(path);
                        st.Write(cadenatxt);
                        st.Close();
                        if (msgYesNO("Generado TXT con Éxito, Desea Continuar.") == DialogResult.Yes)//Cambiamos a Yes Cuando ya este!
                        {
                            PAgoFactura = true;
                            DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else msg("Cancelado por el Usuario");
                }
                else
                    msg("No hay Filas en la Grilla");
            }
            else
            {
                msg("Revise Los Errores en la Grilla");
            }
            //DialogResult = DialogResult.Cancel;
        }
        public Boolean PAgoFactura = false;

    }
}
