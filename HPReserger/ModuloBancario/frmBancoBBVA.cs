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
    public partial class frmBancoBBVA : FormGradient
    {
        public frmBancoBBVA()
        {
            InitializeComponent();
            CargarMoneda();
        }
        public DataTable TablaProveedorBanco;
        public List<frmPagarFactura.FACTURAS> Comprobantes = new List<frmPagarFactura.FACTURAS>();
        public DataTable TablaComprobantes { get; private set; }
        public DataTable TablaConsulta { get; private set; }
        DataTable TFormasPago;
        public string Glosa
        {
            get { return txtRefencia.Text; }
            set { txtRefencia.Text = value.Trim(); }
        }
        public int PkMoneda
        {
            get { return (int)cboMoneda.SelectedValue; }
            set { cboMoneda.SelectedValue = value; }
        }

        public void CargarMoneda()
        {
            cboMoneda.ValueMember = "codigo";
            cboMoneda.DisplayMember = "descripcion";
            cboMoneda.DataSource = CapaLogica.Moneda();
        }
        DataTable TTipoId = new DataTable();
        DataTable TTipoPago = new DataTable();
        DataTable TTipoRecibo = new DataTable();
        DataTable TAgrupado = new DataTable();
        DataTable TIndicador = new DataTable();
        public void CargarCombos()
        {
            //Tabla de Tipo de Id del Proveedor
            TTipoId.Columns.Add("codigo", typeof(int));
            TTipoId.Columns.Add("valor", typeof(string));
            TTipoId.Columns.Add("Des", typeof(string));
            //L E R M P
            //1   L.E / DNI -2   CARNET EXT.- 3   PASAPORTE -5   RUC -6   OTROS -7   P.NAC. -8   CARNET DE IDENTIDAD            
            TTipoId.Rows.Add(1, "DNI", "L");//L
            TTipoId.Rows.Add(2, "C.Ext", "E");//E
            TTipoId.Rows.Add(3, "PAS", "P");//P
            TTipoId.Rows.Add(5, "RUC", "R");//R
            TTipoId.Rows.Add(6, "RUC", "R");//R
            //Tabla Tipos de Pagos
            TTipoPago.Columns.Add("codigo", typeof(string));
            TTipoPago.Columns.Add("valor", typeof(string));
            // P =Propio, I=InterBancario
            TTipoPago.Rows.Add("I", "InterBancario");
            TTipoPago.Rows.Add("P", "BancoPropio");
            //Tabla Tipos de Recibos
            TTipoRecibo.Columns.Add("codigo", typeof(string));
            TTipoRecibo.Columns.Add("valor", typeof(string));
            //F= Factura ; B=Boleta ; N= NotaCredito
            TTipoRecibo.Rows.Add("F", "Factura");
            TTipoRecibo.Rows.Add("B", "Boleta");
            TTipoRecibo.Rows.Add("N", "N.Crédito");
            //TablaAbonos Agrupados
            TAgrupado.Columns.Add("codigo", typeof(string));
            TAgrupado.Columns.Add("valor", typeof(string));
            //N=NO; S=SI
            TAgrupado.Rows.Add("N", "Individual");
            TAgrupado.Rows.Add("S", "Agrupado");
            //Tabla Indicadores
            TIndicador.Columns.Add("codigo", typeof(string));
            TIndicador.Columns.Add("valor", typeof(string));
            //E=email; C=Celular
            TIndicador.Rows.Add(" ", "Ninguno");
            TIndicador.Rows.Add("E", "E-mail");
            TIndicador.Rows.Add("C", "Celular");
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public string NroCuenta
        {
            get { return txtcuentapago.Text; }
            set
            {
                string cadena = value;
                cadena = HPResergerFunciones.Utilitarios.QuitarCaracterCuenta(cadena, '-');
                if (cadena.Length == 18)

                    txtcuentapago.Text = cadena.Insert(7, "00");
                else
                    txtcuentapago.Text = cadena;
            }
        }
        public void CargarTotales()
        {
            decimal Sumatoria = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                Sumatoria += (decimal)item.Cells[xImporteAbonar.Name].Value;
            }
            txtTotal.Text = Sumatoria.ToString("n2");
        }
        private void frmBancoBBVA_Load(object sender, EventArgs e)
        {
            CargarCombos();
            //CargarMoneda();
            cboPertenencia.SelectedIndex = 0;
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
                             TipoId = tblproveedor["tipoid"],
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
            TablaConsulta.Columns.Add("doitipo", typeof(int));
            TablaConsulta.Columns.Add("doinumero", typeof(string));
            TablaConsulta.Columns.Add("tipoabono", typeof(string));
            TablaConsulta.Columns.Add("nroCuentaAbonar", typeof(string));
            TablaConsulta.Columns.Add("Beneficiario", typeof(string));
            TablaConsulta.Columns.Add("ImporteAbonar", typeof(decimal));
            TablaConsulta.Columns.Add("TipoRecibo", typeof(string));
            TablaConsulta.Columns.Add("NroDocumento", typeof(string));
            TablaConsulta.Columns.Add("AbonoAgrupado", typeof(string));
            TablaConsulta.Columns.Add("Referencia", typeof(string));
            TablaConsulta.Columns.Add("IndicadorAviso", typeof(string));
            TablaConsulta.Columns.Add("MedioAviso", typeof(string));
            TablaConsulta.Columns.Add("personacontacto", typeof(string));
            //paso para la configuracion de la tabla 
            foreach (var x in cargas)
            {
                //L R M E P
                //1   L.E / DNI -2   CARNET EXT.- 3   PASAPORTE -5   RUC -6   OTROS -7   P.NAC. -8   CARNET DE IDENTIDAD
                string TipoAbono = "";
                if (x.cuentaccisoles.ToString().Substring(0, x.cuentaccisoles.ToString().Length - 6) == x.ctaseleccionada.ToString())
                    TipoAbono = "I";
                else TipoAbono = "P";
                string tipo = "";
                if (x.tipo.ToString().Trim().ToUpper().Substring(0, 2) == "FT" || x.tipo.ToString().Trim().ToUpper().Substring(0, 2) == "RH")
                    tipo = "F";
                else if (x.tipo.ToString().Trim().ToUpper().Substring(0, 2) == "BT")
                    tipo = "B";
                else tipo = "N";

                TablaConsulta.Rows.Add((int)x.TipoId, x.proveedor.ToString(), TipoAbono, x.ctaseleccionada.ToString(), x.razonsocial.ToString(), x.total, tipo, x.nro, "N", "", "E", x.email, "");
            }
            dtgconten.DataSource = TablaConsulta;
            CargarTotales();
            CargasDCCuentas();
        }

        private void CargasDCCuentas()
        {
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                string cadena = item.Cells[xCuentaAbonar.Name].Value.ToString().Trim();
                if (cadena.Length == 18)
                {
                    item.Cells[xCuentaAbonar.Name].Value = cadena.Insert(7, "00");
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public Boolean ValidarDatosLlenados()
        {
            Boolean Prueba = true;
            DateTime PruebaFecha;
            decimal PRuebaDecimal;
            int PruebaInt;
            string cadena = "";
            if (cboMoneda.SelectedValue == null)
            {
                Prueba = false;
            }
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                //validamos el Nro de Cuenta
                if (item.Cells[xCuentaAbonar.Name].Value.ToString().Trim().Length != 20)
                {
                    HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[xCuentaAbonar.Name]); Prueba = false;
                }
                else
                {
                    HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[xCuentaAbonar.Name]);
                }
                //Validamos el numero del proveedor 
                if (item.Cells[xDoiNumero.Name].Value.ToString().Trim().Length > 11)
                {
                    item.Cells[xDoiNumero.Name].Value = item.Cells[xDoiNumero.Name].Value.ToString().Trim().Substring(0, 11);
                }
                if (item.Cells[xNombreBeneficiario.Name].Value.ToString().Trim().Length > 39)
                {
                    item.Cells[xNombreBeneficiario.Name].Value = item.Cells[xNombreBeneficiario.Name].Value.ToString().Trim().Substring(0, 39);
                }
                if (item.Cells[xNroDocumento.Name].Value.ToString().Trim().Length > 11)
                {
                    item.Cells[xNroDocumento.Name].Value = item.Cells[xNroDocumento.Name].Value.ToString().Trim().Substring(0, 11);
                }
                if (item.Cells[xReferencia.Name].Value.ToString().Trim().Length > 39)
                {
                    item.Cells[xReferencia.Name].Value = item.Cells[xReferencia.Name].Value.ToString().Trim().Substring(0, 39);
                }
                if (item.Cells[xMedioAviso.Name].Value.ToString().Trim().Length > 49)
                {
                    item.Cells[xMedioAviso.Name].Value = item.Cells[xMedioAviso.Name].Value.ToString().Trim().Substring(0, 49);
                }
            }
            return Prueba;
        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public DialogResult msgYesNO(string cadena) { return HPResergerFunciones.Utilitarios.msgYesNo(cadena); }
        string cadenatxt = "";
        private StreamWriter st;
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosLlenados())
            {
                combo = dtgconten.Columns[xDoi.Name] as DataGridViewComboBoxColumn;
                combo.ValueMember = "des";
                combo.DataSource = TTipoId;
                //dtgconten.RefreshEdit();
                PAgoFactura = false;
                int con = dtgconten.RowCount;
                if (con > 0)
                {
                    cadenatxt = "";
                    string[] CampoCabecera = new string[14];
                    CampoCabecera[0] = "750";
                    CampoCabecera[1] = txtcuentapago.Text.ToString().Trim();
                    CampoCabecera[2] = (int)cboMoneda.SelectedValue == 1 ? "PEN" : "USD";
                    CampoCabecera[3] = HPResergerFunciones.Utilitarios.AddCaracterMultiplicarx100(txtTotal.Text, '0', 15, HPResergerFunciones.Utilitarios.Direccion.derecha);
                    CampoCabecera[4] = "A";
                    CampoCabecera[5] = HPResergerFunciones.Utilitarios.AddCaracter("", ' ', 9, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                    CampoCabecera[6] = HPResergerFunciones.Utilitarios.AddCaracter(txtRefencia.Text, ' ', 25, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                    CampoCabecera[7] = HPResergerFunciones.Utilitarios.AddCaracter(dtgconten.RowCount.ToString(), '0', 6, HPResergerFunciones.Utilitarios.Direccion.derecha);
                    CampoCabecera[8] = cboPertenencia.Text.ToString() == "SI" ? "S" : "N";
                    CampoCabecera[9] = HPResergerFunciones.Utilitarios.AddCaracter("0", '0', 18, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                    CampoCabecera[10] = HPResergerFunciones.Utilitarios.AddCaracter(" ", ' ', 50, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                    //Sacamos la Cabecera
                    cadenatxt += string.Join("", CampoCabecera) + $"{Environment.NewLine}";
                    //Sacamos el Detalle
                    string[] campo = new string[16];
                    foreach (DataGridViewRow item in dtgconten.Rows)
                    {
                        campo[0] = "002";
                        string doi = item.Cells[xDoi.Name].Value.ToString().Trim().ToUpper();
                        doi = doi == "1" ? "L" : doi == "2" ? "E" : doi == "3" ? "P" : doi == "5" ? "R" : "R";
                        campo[1] = doi.ToUpper();
                        campo[2] = HPResergerFunciones.Utilitarios.AddCaracter(item.Cells[xDoiNumero.Name].Value.ToString().Trim().ToUpper(), ' ', 12, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                        campo[3] = item.Cells[xTipoAbono.Name].Value.ToString().Trim().ToUpper();
                        campo[4] = item.Cells[xCuentaAbonar.Name].Value.ToString().Trim().ToUpper();
                        campo[5] = HPResergerFunciones.Utilitarios.AddCaracter(item.Cells[xNombreBeneficiario.Name].Value.ToString().Trim().ToUpper(), ' ', 40, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                        campo[6] = HPResergerFunciones.Utilitarios.AddCaracterMultiplicarx100(item.Cells[xImporteAbonar.Name].Value.ToString(), '0', 15, HPResergerFunciones.Utilitarios.Direccion.derecha);
                        campo[7] = item.Cells[xTipoRecibo.Name].Value.ToString().Trim().ToUpper();
                        campo[8] = HPResergerFunciones.Utilitarios.AddCaracter(item.Cells[xNroDocumento.Name].Value.ToString().Trim().ToUpper(), ' ', 12, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                        campo[9] = item.Cells[xAbono.Name].Value.ToString().Trim().ToUpper();
                        campo[10] = HPResergerFunciones.Utilitarios.AddCaracter(item.Cells[xReferencia.Name].Value.ToString().Trim().ToUpper(), ' ', 40, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                        string indicador = item.Cells[xIndicadorAviso.Name].Value.ToString();
                        indicador = item.Cells[xMedioAviso.Name].Value.ToString().Trim().ToUpper().Length == 0 ? " " : indicador;
                        campo[11] = indicador;
                        campo[12] = HPResergerFunciones.Utilitarios.AddCaracter(indicador == " " ? " " : item.Cells[xMedioAviso.Name].Value.ToString().Trim().ToUpper(), ' ', 50, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                        campo[13] = HPResergerFunciones.Utilitarios.AddCaracter(item.Cells[xPersonaContacto.Name].Value.ToString().Trim().ToUpper(), ' ', 30, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                        campo[14] = HPResergerFunciones.Utilitarios.AddCaracter("", '0', 32, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                        campo[15] = HPResergerFunciones.Utilitarios.AddCaracter("", ' ', 18, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                        cadenatxt += string.Join("", campo) + $"{Environment.NewLine}";
                    }
                    //msg(cadenatxt);
                    SaveFile.FileName = $"Proveedores BBVA {txtTotal.Text} " + DateTime.Now.ToLongDateString();                   
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
        private void dtgconten_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        DataGridViewComboBoxColumn combo;
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.ColumnIndex;
            if (e.RowIndex >= 0)
            {
                combo = dtgconten.Columns[xDoi.Name] as DataGridViewComboBoxColumn;
                combo.ValueMember = "codigo";
                combo.DisplayMember = "valor";
                combo.DataSource = TTipoId;
                // 
                combo = dtgconten.Columns[xTipoAbono.Name] as DataGridViewComboBoxColumn;
                combo.ValueMember = "codigo";
                combo.DisplayMember = "valor";
                combo.DataSource = TTipoPago;
                // 
                combo = dtgconten.Columns[xTipoRecibo.Name] as DataGridViewComboBoxColumn;
                combo.ValueMember = "codigo";
                combo.DisplayMember = "valor";
                combo.DataSource = TTipoRecibo;
                // 
                combo = dtgconten.Columns[xAbono.Name] as DataGridViewComboBoxColumn;
                combo.ValueMember = "codigo";
                combo.DisplayMember = "valor";
                combo.DataSource = TAgrupado;
                // 
                combo = dtgconten.Columns[xIndicadorAviso.Name] as DataGridViewComboBoxColumn;
                combo.ValueMember = "codigo";
                combo.DisplayMember = "valor";
                combo.DataSource = TIndicador;
            }
        }

    }
}