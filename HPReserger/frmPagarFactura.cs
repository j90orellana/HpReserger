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

namespace HPReserger
{
    public partial class frmPagarFactura : Form
    {
        public frmPagarFactura()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL cPagarfactura = new HPResergerCapaLogica.HPResergerCL();

        private void txtruc_TextChanged(object sender, EventArgs e)
        {
            if (txtruc.Text.Length > 9)
            {
                cbotipo.Enabled = true; cbobanco.Enabled = true; cbocuentabanco.Enabled = true;
                cbotipo.SelectedIndex = 0; txtnropago.Enabled = true;
            }
            else
            {
                cbotipo.Enabled = false; cbobanco.Enabled = false; cbocuentabanco.Enabled = false; txtnropago.Enabled = false; txtnropago.Text = "";
            }
            DataRow razonsocial = cPagarfactura.RUCProveedor(txtruc.Text);
            if (razonsocial != null)
            {
                txtRazonSocial.Text = razonsocial["razon_social"].ToString();
                txtdireccion.Text = razonsocial["direccion_oficina"].ToString();
                txtTelefono.Text = razonsocial["telefono_oficina"].ToString();
                //cargarguias(txtguia);//txtguia_TextChanged(sender, e);
                Dtguias.DataSource = cPagarfactura.ListarFacturasPorPagar(0, "", 0, DateTime.Now, DateTime.Now, 0, DateTime.Now, DateTime.Now);
            }
            else
            {
                txtRazonSocial.Text = txtdireccion.Text = txtTelefono.Text = "";
                // chlbx.Items.Clear();
                //Dtguias.Refresh();
                // DtgConten.Refresh();
            }
        }
        private void frmPagarFactura_Load(object sender, EventArgs e)
        {
            txtruc_TextChanged(sender, e);
            //ESTO DAÑADA LA PRESENTACION DE LA FECHA MODIFICA DE 21/07/2017 A 07/21/2017 POR EL CAMBIO DE CULTURA
            //Application.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("EN-US");
            // txtruc.Text = "0701046971";
            //    radioButton1.Checked = true;
            txtbuscar_TextChanged(sender, e);

            DataRow Filita = cPagarfactura.VerUltimoIdentificador("TBL_Factura", "Nro_DocPago");
            if (Filita != null)
                txtnropago.Text = (decimal.Parse(Filita["ultimo"].ToString()) + 1).ToString();
            else txtnropago.Text = "1";
            //List<Persona> personas = new List<Persona>();
            //Persona person1 = new Persona(1, "jefferson", 27);
            //personas.Add(person1);
            //Persona person3 = new Persona(2, "cristina", 28);
            //personas.Add(person3);
            //Persona person2 = new Persona(1, "jefferson", 27);

            //string cadena = "";
            //foreach (Persona per in personas)
            //{
            //    cadena += $"codigo= {per.codigo} nombre={per.nombre} Edad={per.edad}\n";
            //}
            //MessageBox.Show($"{cadena} Prueba de contain={personas.Contains(person2)} Prueba de exists= {personas.Exists(cust => cust.codigo == 1 && cust.edad == 27 && cust.nombre == "jefferson")}");
            //Persona p = personas.Find(cust => cust.codigo == 1 && cust.edad == 27 && cust.nombre == "jefferson");
            //if (p != null)
            //    MessageBox.Show($"{p.codigo} {p.nombre} {p.edad}");
            //msg("Prueba de Any= " + personas.Any(cust => cust.edad >= 27));
            //Horas Horita = new Horas() { minutos = 10, segundos = 59 };
            //List<Horas> horas = new List<Horas>();
            //horas.Add(new Horas() { minutos = 19, segundos = 20 });
            //personas.RemoveAll(delegate (Persona pers) { return pers.codigo == 10; });
            //personas.RemoveAll(cust => cust.codigo == 10);
            //personas = (from Persona in personas where Persona.codigo != 10 select Persona).ToList<Persona>();

            //personas.RemoveAll(delegate (Persona persis) { return persis.codigo == 10; });
            //personas.RemoveAll(x => x.codigo == 10);
            //personas = (from x in personas where x.codigo != 10 select x).ToList<Persona>();

            //personas.RemoveAll(delegate (Persona peropero) { return peropero.codigo == 10; });

            //Point[] points = { new Point(100, 200),
            //             new Point(150, 250), new Point(250, 375),
            //             new Point(275, 395), new Point(295, 450) };

            //// Define the Predicate<T> delegate.
            //Predicate<Persona> predicate = BuscarPErsona;

            //// Find the first Point structure for which X times Y  
            //// is greater than 100000. 
            //Persona first = Array.Find(personas.ToArray(), predicate);

            //// Display the first structure found.
            //Console.WriteLine("Found: X = {0}, Y = {1}", first.codigo, first.nombre);

            //decimal persin = personas.Max(x => x.edad);
            ////List<Persona> PEr = (personas.FindAll(x => x.edad == persin));
            //List<Persona> PEr = (personas.FindAll(predicate));
            //string xcadena = "";
            //foreach (Persona px in PEr)
            //{
            //    xcadena += px.codigo + " " + px.nombre + px.edad + "\t";
            //}
            //msg("maxima edad" + persin + " " + xcadena);
        }
        private static Boolean BuscarPErsona(Persona obj)
        {
            return obj.edad > 10;
        }
        private static bool FindPoints(Point obj)
        {
            return obj.X * obj.Y > 100000;
        }
        public class Persona
        {
            public int codigo;
            public string nombre;
            public decimal edad;
            public Persona(int cod, string nom, decimal eda)
            {
                codigo = cod;
                nombre = nom;
                edad = eda;
            }
        }
        public class Horas
        {
            public int minutos;
            public int segundos;
        }
        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotipo.SelectedIndex == 0 || cbotipo.SelectedIndex == 1)
            {
                cbobanco.Visible = lblguia1.Visible = lblguia.Visible = cbocuentabanco.Visible = true;
                lblguia.Text = "Banco";
                cbobanco.ValueMember = "codigo";
                cbobanco.DisplayMember = "descripcion";
                cbobanco.DataSource = cPagarfactura.getCargoTipoContratacion("Sufijo", "Entidad_Financiera", "TBL_Entidad_Financiera");
            }
            else
            {
                cbobanco.Visible = lblguia1.Visible = lblguia.Visible = cbocuentabanco.Visible = false;
            }
        }
        private void cbobanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbobanco.SelectedIndex >= 0)
            {
                cbocuentabanco.Text = "";
                cbocuentabanco.ValueMember = "Id_Cuenta_Contable";
                cbocuentabanco.DisplayMember = "banco";
                cbocuentabanco.DataSource = cPagarfactura.ListarBancosTiposdePago(cbobanco.SelectedValue.ToString());
            }
        }
        private void txtruc_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void txtruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }
        private void txtruc_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtruc, 11);
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        DialogResult PAsoBanco = DialogResult.Cancel;
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (cbotipo.SelectedIndex != 2)
            {
                // // if (string.IsNullOrWhiteSpace(txtnropago.Text))
                //  {
                //      msg("Ingrese Nro de pago");
                //      txtnropago.Focus();
                //      return;
                //  }
            }
            if (cbobanco.Items.Count == 0)
            {
                msg("No hay Bancos");
                cbobanco.Focus();
                return;
            }
            if (cbocuentabanco.Items.Count == 0)
            {
                msg("El Banco Seleccionado No tiene Cuenta");
                cbobanco.Focus();
                if (MSG("Desea Continuar el Proceso de pago") != DialogResult.OK)
                {
                    return;
                }
            }
            if (txttotal.Text.Length > 0)
            {
                if (decimal.Parse(txttotal.Text) == 0)
                {
                    msg("El total a pagar no puede ser Cero");
                    Dtguias.Focus();
                    return;
                }
            }
            else
            {
                msg("El Monto esta Vacío, Seleccioné una Fila de la grilla");
                Dtguias.Focus();
                return;
            }
            Boolean GenerarTxt = false;
            DialogResult ResultadoDialogo = MessageBox.Show("Desea Generar TXT del pago?", CompanyName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (ResultadoDialogo == DialogResult.Yes)
            {
                GenerarTxt = false;
                ///Verificar si el esta el Generador de txt de ese banco 
                string bancox = cbobanco.SelectedValue.ToString().Trim();
                if (bancox == "BCP" || bancox == "IBK" || bancox == "BIF")
                {
                    //bancos que generan el txt bcp ibk bif
                    GenerarTxt = true;
                }
                else
                {
                    if (MessageBox.Show("El Banco Seleccionado no tiene para exportar a TXT, Desea Continuar?", CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        GenerarTxt = false;
                    }
                    else
                        return;
                }
            }
            if (ResultadoDialogo == DialogResult.No)
            {
                PAsoBanco = DialogResult.OK;
                GenerarTxt = false;
                //msg("selecciones no en generar txt");
            }
            if (ResultadoDialogo == DialogResult.Cancel)
                return;
            if (GenerarTxt)
            {
                Dtguias.EndEdit();
                Proveedores.Clear();
                foreach (FACTURAS cadena in Comprobantes)
                    Proveedores.Add(cadena.proveedor);
                //ventanas de seleccion para generar txt
                frmCargaDatosProveedor frmcargardatosproveedor = new frmCargaDatosProveedor();
                frmcargardatosproveedor.Proveedores = Proveedores.Distinct().ToList<string>();
                frmcargardatosproveedor.banco = cbobanco.SelectedValue.ToString();
                frmcargardatosproveedor.txtbanco.Text = cbobanco.Text;
                frmcargardatosproveedor.cuenta = cbocuentabanco.Text;
                if (frmcargardatosproveedor.ShowDialog() == DialogResult.Cancel || frmcargardatosproveedor.Resultado == DialogResult.Cancel)
                    return;
                //msg("vamos a pagar la factura");
                PasoFactura = false;
                if (cbobanco.SelectedValue.ToString().ToUpper().Trim() == "BCP")
                {
                    //Abrimos eL formulario del banco de credito
                    //msg("FORMULARIO DEL BCP");
                    frmBancoBcp bancobcp = new frmBancoBcp();
                    bancobcp.TablaProveedorBanco = frmcargardatosproveedor.TablaProvedoresBancos;
                    //bancointerbank.TablaComprobantes = ((DataTable)Dtguias.DataSource).Clone();
                    //msg("Cuenta Filas " + bancointerbank.TablaComprobantes.Rows.Count);
                    bancobcp.txtcuentapago.Text = frmcargardatosproveedor.txtcuenta.Text;
                    bancobcp.Icon = Icon;
                    bancobcp.Comprobantes = Comprobantes;
                    bancobcp.ShowDialog();
                    PAsoBanco = bancobcp.DialogResult;
                }
                if (cbobanco.SelectedValue.ToString().ToUpper().Trim() == "IBK")
                {
                    //abrimos el formulario del banco interbank
                    // msg("FORMULARIO DEL IBK");
                    frmBancoInterbank bancointerbank = new frmBancoInterbank();
                    bancointerbank.TablaProveedorBanco = frmcargardatosproveedor.TablaProvedoresBancos;
                    //bancointerbank.TablaComprobantes = ((DataTable)Dtguias.DataSource).Clone();
                    //msg("Cuenta Filas " + bancointerbank.TablaComprobantes.Rows.Count);
                    bancointerbank.txtcuenta.Text = frmcargardatosproveedor.txtcuenta.Text;
                    bancointerbank.Comprobantes = Comprobantes;
                    bancointerbank.Icon = Icon;
                    bancointerbank.ShowDialog();
                    PAsoBanco = bancointerbank.DialogResult;
                }
                if (cbobanco.SelectedValue.ToString().ToUpper().Trim() == "BIF")
                {
                    //abrimso el formulario del banco interarmericano de finanzas
                    //  msg("FORMULARIO DEL BIF");
                    frmBancoInterAmericano bancointeramericano = new frmBancoInterAmericano();
                    bancointeramericano.TablaProveedorBanco = frmcargardatosproveedor.TablaProvedoresBancos;
                    //bancointerbank.TablaComprobantes = ((DataTable)Dtguias.DataSource).Clone();
                    //msg("Cuenta Filas " + bancointerbank.TablaComprobantes.Rows.Count);
                    bancointeramericano.txtcuenta.Text = frmcargardatosproveedor.txtcuenta.Text;
                    bancointeramericano.Comprobantes = Comprobantes;
                    bancointeramericano.Icon = Icon;
                    bancointeramericano.ShowDialog();
                    PAsoBanco = bancointeramericano.DialogResult;
                }
            }
            //proceso para pagar facturas!!!
            //Movimiento de las cuentas 
            ///////////////////////
            ///Dinamica Contable///
            /////////////////////// 
            if (PAsoBanco == DialogResult.OK)
            {
                int numasiento = 0; string facturar = "";
                foreach (FACTURAS fac in Comprobantes)
                {
                    DataTable asientito = cPagarfactura.UltimoAsientoFactura(fac.numero, fac.proveedor);
                    DataRow asiento = asientito.Rows[0];
                    if (asiento == null) { numasiento = 0; }
                    else
                    {
                        numasiento = (int)asiento["codigo"];
                    }
                    //Recorremos los comprobantes seleccionados RH / FT
                    //Public FACTURAS(string Numero, string Proveedor, string Tipo, decimal Subtotal, decimal Igv, decimal Total, decimal Detraccion, DateTime FechaCancelado)
                    if (fac.tipo.Substring(0, 2) == "RH")
                    {
                        //actualizo que el recibo este pagado
                        cPagarfactura.insertarPagarfactura(fac.numero, int.Parse(cbotipo.Text.Substring(0, 3)), txtnropago.Text);
                        //cuenta de recibo por honorarios 4241101
                        cPagarfactura.guardarfactura(1, numasiento + 1, fac.numero, "4241101", fac.subtotal, 0, 1, fac.FechaEmision, fac.fechacancelado, fac.FechaRecepcion, frmLogin.CodigoUsuario, fac.centrocosto, fac.tipo, fac.proveedor);
                        facturar = fac.numero;
                    }
                    else
                    {
                        if (fac.detraccion > 0)
                        {
                            //actualizo que la factura esta pagada
                            cPagarfactura.insertarPagarfactura(fac.numero, int.Parse(cbotipo.Text.Substring(0, 3)), txtnropago.Text);
                            ///facturas por pagar 4212101
                            cPagarfactura.guardarfactura(1, numasiento + 1, fac.numero, "4011110", 0, fac.detraccion, 3, fac.FechaEmision, fac.fechacancelado, fac.FechaRecepcion, frmLogin.CodigoUsuario, fac.centrocosto, fac.tipo, fac.proveedor);
                            cPagarfactura.guardarfactura(1, numasiento + 1, fac.numero, "4212101", fac.total - fac.detraccion, 0, 2, fac.FechaEmision, fac.fechacancelado, fac.FechaRecepcion, frmLogin.CodigoUsuario, fac.centrocosto, fac.tipo, fac.proveedor);
                            facturar = fac.numero;
                        }
                        else
                        {
                            //actualizo que la factura esta pagada
                            cPagarfactura.insertarPagarfactura(fac.numero, int.Parse(cbotipo.Text.Substring(0, 3)), txtnropago.Text);
                            ///facturas por pagar 4212101
                            cPagarfactura.guardarfactura(1, numasiento + 1, fac.numero, "4212101", fac.total, 0, 2, fac.FechaEmision, fac.fechacancelado, fac.FechaRecepcion, frmLogin.CodigoUsuario, fac.centrocosto, fac.tipo, fac.proveedor);
                            facturar = fac.numero;
                        }
                    }
                }
                string BanCuenta;
                if (cbocuentabanco.SelectedValue == null)
                    BanCuenta = "";
                else
                    BanCuenta = cbocuentabanco.SelectedValue.ToString();
                cPagarfactura.guardarfactura(0, numasiento + 1, facturar, BanCuenta, 0, decimal.Parse(txttotal.Text) - decimal.Parse(txttotaldetrac.Text), 5, DateTime.Now, DateTime.Now, DateTime.Now, frmLogin.CodigoUsuario, 1, "", "");
                msg("Documento Pagado y se ha Generado su Asiento");
                btnActualizar_Click(sender, e);
                txttotaldetrac.Text = txttotal.Text = "0.00";
                Comprobantes.Clear();
            }
        }
        public Boolean PasoFactura = false;
        List<string> Proveedores = new List<string>();
        /*
        SaveFile.FileName = cbobanco.Text + " " + DateTime.Now.ToLongDateString();
        if (SaveFile.FileName != string.Empty && SaveFile.ShowDialog() == DialogResult.OK)
        {
            string path = SaveFile.FileName;
            st = File.CreateText(path);
            string cadenita = "";
            for (int i = 0; i < Dtguias.RowCount; i++)
            {
                DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
                ch1 = (DataGridViewCheckBoxCell)Dtguias["ok", i];
                if (ch1.Value == null)
                    ch1.Value = false;
                if (Dtguias["ok", i].Value == null)
                    Dtguias["ok", i].Value = false;
                if (Dtguias["ok", i].Value.ToString() == "True")
                {
                    for (int j = 0; j < Dtguias.ColumnCount - 1; j++)
                    {
                        if (!columnas.Contains(j))
                            cadenita = cadenita + Dtguias[j, i].Value.ToString() + "|";
                    }
                    cadenita = cadenita + Dtguias[Dtguias.ColumnCount - 1, i].Value.ToString() + (char)(13);
                }
            }
            st.Write(cadenita);
            st.Close();

            int numasiento; string facturar = "";
            DataTable asientito = cPagarfactura.UltimoAsiento();
            DataRow asiento = asientito.Rows[0];
            numasiento = (int)asiento["codigo"];
            foreach (DataGridViewRow lista in Dtguias.Rows)
            {
                DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
                ch1 = (DataGridViewCheckBoxCell)lista.Cells["ok"];
                if (ch1.Value == null)
                    ch1.Value = false;
                if (lista.Cells["OK"].Value == null)
                    lista.Cells["OK"].Value = false;
                switch (lista.Cells["OK"].Value.ToString())
                {
                    case "True":
                        if (lista.Cells["tipodoc"].Value.ToString().Substring(0, 2) == "RH")
                        {
                            //actualizo que el recibo este pagado
                            cPagarfactura.insertarPagarfactura(lista.Cells["nrofactura"].Value.ToString(), int.Parse(cbotipo.Text.Substring(0, 3)), txtnropago.Text);
                            //cuenta de recibo por honorarios 4241101
                            cPagarfactura.guardarfactura(1, numasiento + 1, lista.Cells["nrofactura"].Value.ToString(), "4241101", (decimal)lista.Cells["subtotal"].Value, 0);
                            facturar = lista.Cells["nrofactura"].Value.ToString();
                        }
                        else
                        {
                            if ((decimal)lista.Cells["detraccion"].Value > 0)
                            {
                                //actualizo que la factura esta pagada
                                cPagarfactura.insertarPagarfactura(lista.Cells["nrofactura"].Value.ToString(), int.Parse(cbotipo.Text.Substring(0, 3)), txtnropago.Text);
                                ///facturas por pagar 4212101
                                cPagarfactura.guardarfactura(1, numasiento + 1, lista.Cells["nrofactura"].Value.ToString(), "4011110", (decimal)lista.Cells["detraccion"].Value, 0);
                                cPagarfactura.guardarfactura(1, numasiento + 1, lista.Cells["nrofactura"].Value.ToString(), "4212101", (decimal)lista.Cells["total"].Value - (decimal)lista.Cells["detraccion"].Value, 0);
                                facturar = lista.Cells["nrofactura"].Value.ToString();
                            }
                            else
                            {
                                //actualizo que la factura esta pagada
                                cPagarfactura.insertarPagarfactura(lista.Cells["nrofactura"].Value.ToString(), int.Parse(cbotipo.Text.Substring(0, 3)), txtnropago.Text);
                                ///facturas por pagar 4212101
                                cPagarfactura.guardarfactura(1, numasiento + 1, lista.Cells["nrofactura"].Value.ToString(), "4212101", (decimal)lista.Cells["total"].Value, 0);
                                facturar = lista.Cells["nrofactura"].Value.ToString();
                            }
                        }
                        break;
                    case "False":
                        break;
                }
            }
            cPagarfactura.guardarfactura(0, numasiento + 1, facturar, cbocuentabanco.SelectedValue.ToString(), 0, decimal.Parse(txttotal.Text));
            msg("Documento Pagado y se ha Generado su Asiento");
            txtruc_TextChanged(sender, e);
            txttotaldetrac.Text = txttotal.Text = "0.00";

        }
        else
        {
            msg("Cancelado Por el Usuario");
        }*/
        decimal sumatoria;
        decimal detrac;
        public class FACTURAS
        {
            public string numero { get; set; }
            public string proveedor { get; set; }
            public string tipo { get; set; }
            public decimal subtotal { get; set; }
            public decimal igv { get; set; }
            public decimal total { get; set; }
            public decimal detraccion { get; set; }
            public DateTime? fechacancelado { get; set; }
            public int centrocosto { get; set; }
            public DateTime FechaEmision { get; set; }
            public DateTime FechaRecepcion { get; set; }
            public FACTURAS(string Numero, string Proveedor, string Tipo, decimal Subtotal, decimal Igv, decimal Total, decimal Detraccion, DateTime? FechaCancelado, int CentroCosto, DateTime fechaemision, DateTime fecharecepcion)
            {
                numero = Numero;
                proveedor = Proveedor;
                tipo = Tipo;
                subtotal = Subtotal;
                igv = Igv;
                total = Total;
                detraccion = Detraccion;
                fechacancelado = FechaCancelado;
                centrocosto = CentroCosto;
                FechaEmision = fechaemision;
                FechaRecepcion = fecharecepcion;
            }
        }
        List<FACTURAS> Comprobantes = new List<FACTURAS>();
        private void Dtguias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Dtguias.EndEdit();
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 0)
                {
                    if (Dtguias["ok", e.RowIndex].Value.ToString() == "True")
                    {
                        //msg("Contains= " + Comprobantes.Contains(new FACTURAS(Dtguias["nrofactura", e.RowIndex].Value.ToString().TrimStart().TrimEnd(), Dtguias["proveedor", e.RowIndex].Value.ToString().TrimStart().TrimEnd())));
                        Boolean Busqueda = false;
                        foreach (FACTURAS xfac in Comprobantes)
                        {
                            if (xfac.numero == Dtguias["nrofactura", e.RowIndex].Value.ToString().TrimStart().TrimEnd() && xfac.proveedor == Dtguias["proveedor", e.RowIndex].Value.ToString().TrimStart().TrimEnd())
                                Busqueda = true;
                        }
                        if (!Busqueda)
                            Comprobantes.Add(new FACTURAS(Dtguias["nrofactura", e.RowIndex].Value.ToString().TrimStart().TrimEnd(), Dtguias["proveedor", e.RowIndex].Value.ToString().TrimStart().TrimEnd(), Dtguias["tipodoc", e.RowIndex].Value.ToString().TrimStart().TrimEnd(), (decimal)Dtguias["subtotal", e.RowIndex].Value, (decimal)Dtguias["igv", e.RowIndex].Value, (decimal)Dtguias["total", e.RowIndex].Value, (decimal)Dtguias["detraccion", e.RowIndex].Value, (DateTime)Dtguias["fechacancelado", e.RowIndex].Value, (int)Dtguias[centrocostox.Name, e.RowIndex].Value, (DateTime)Dtguias[FechaEmision.Name, e.RowIndex].Value, (DateTime)Dtguias[fechaRecepcion.Name, e.RowIndex].Value));
                    }
                    else
                    {
                        Boolean Busqueda = false; int X = 0, Y = 0;
                        foreach (FACTURAS xfac in Comprobantes)
                        {
                            if (xfac.numero == Dtguias["nrofactura", e.RowIndex].Value.ToString().TrimStart().TrimEnd() && xfac.proveedor == Dtguias["proveedor", e.RowIndex].Value.ToString().TrimStart().TrimEnd())
                            {
                                Busqueda = true; Y = X;
                            }
                            X++;
                        }
                        //FACTURAS cola = new FACTURAS(Dtguias["nrofactura", e.RowIndex].Value.ToString().TrimStart().TrimEnd(), Dtguias["proveedor", e.RowIndex].Value.ToString().TrimStart().TrimEnd());
                        //msg("" + Comprobantes.Exists(cust=>cust.numero==cola.numero&&cust.proveedor==cola.proveedor) + " Y=" + Y + " Contador=" + Comprobantes.Count);
                        if (Busqueda)
                            Comprobantes.RemoveAt(Y);
                    }
                    CalcularTotal();
                }
                //else
            }
            catch (Exception ex) { msg(ex.Message); }
            FacturasSeleccionas();
        }
        int NumRegistros;
        public void CalcularTotal()
        {
            sumatoria = 0;
            detrac = 0; NumRegistros = 0;
            if (Dtguias.RowCount > 0)
            {
                // btnaceptar.Enabled = true;                
                foreach (DataGridViewRow lista in Dtguias.Rows)
                {
                    DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
                    ch1 = (DataGridViewCheckBoxCell)lista.Cells["ok"];
                    if (ch1.Value == null)
                        ch1.Value = false;
                    if (lista.Cells["OK"].Value == null)
                        lista.Cells["OK"].Value = false;
                    switch (lista.Cells["OK"].Value.ToString())
                    {
                        case "True":
                            NumRegistros++;
                            if (lista.Cells["tipodoc"].Value.ToString().Substring(0, 2) == "RH")
                                sumatoria += (decimal)lista.Cells["subtotal"].Value;
                            else
                                sumatoria += (decimal)lista.Cells["total"].Value;
                            detrac += (decimal)lista.Cells["detraccion"].Value;
                            break;
                        case "False":
                            break;
                    }
                }
                txttotaldetrac.Text = detrac.ToString("n2");
                txttotal.Text = (sumatoria - detrac).ToString("n2");
            }
            if (sumatoria == 0)
                btnaceptar.Enabled = false;
            else
                btnaceptar.Enabled = true;
            lblmensaje.Text = "Número de Registros: " + NumRegistros;
        }
        private void Dtguias_RowErrorTextChanged(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void Dtguias_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Dtguias.RowCount < 0)
            {
                cbotipo.Enabled = cbobanco.Enabled = cbocuentabanco.Enabled = btnaceptar.Enabled = false;
                cbotipo.SelectedIndex = 0;// txtnropago.Enabled = false;

            }
            else
            {
                cbotipo.Enabled = true; cbobanco.Enabled = true; cbocuentabanco.Enabled = true;
                cbotipo.SelectedIndex = 0;// txtnropago.Enabled = true;
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (txtruc.Text.Length > 8)
            {
                if (MessageBox.Show("¿Desea Salir?", CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
                this.Close();
        }
        int[] columnas = { 0 };
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtbuscar_TextChanged(sender, e);
        }
        int prove = 0;
        private void chkprove_CheckedChanged(object sender, EventArgs e)
        {
            if (chkprove.Checked)
                prove = 1;
            else
                prove = 0;
            txtbuscar_TextChanged(sender, e);

        }
        int fecha = 0;
        private void chkfecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkfecha.Checked)
                fecha = 1;
            else fecha = 0;
            txtbuscar_TextChanged(sender, e);
        }
        DateTime auxtmp;
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (dtfin.Value < dtinicio.Value)
            {
                auxtmp = dtfin.Value;
                dtfin.Value = dtinicio.Value;
                dtinicio.Value = auxtmp;
            }
            if (dtpfin.Value < dtpini.Value)
            {
                auxtmp = dtpfin.Value;
                dtpfin.Value = dtpini.Value;
                dtpini.Value = auxtmp;
            }
            Dtguias.DataSource = cPagarfactura.ListarFacturasPorPagar(prove, txtbuscar.Text, fecha, dtinicio.Value, dtfin.Value, recepcion, dtpini.Value, dtpfin.Value);
            cbotipo.SelectedIndex = 0;
            txttotaldetrac.Text = txttotal.Text = "0.00";
            btnaceptar.Enabled = false;
            FacturasSeleccionas();
            CalcularTotal();
        }
        public void FacturasSeleccionas()
        {
            int conta = Dtguias.RowCount;
            foreach (FACTURAS fac in Comprobantes)
            {
                for (int i = 0; i < conta; i++)
                {
                    if (Dtguias["nrofactura", i].Value.ToString().TrimStart().TrimEnd() == fac.numero && Dtguias["proveedor", i].Value.ToString().TrimStart().TrimEnd() == fac.proveedor)
                    {
                        Dtguias["ok", i].Value = true;
                    }
                }
            }
        }
        private void dtinicio_ValueChanged(object sender, EventArgs e)
        {
            txtbuscar_TextChanged(sender, e);
        }
        private void dtfin_ValueChanged(object sender, EventArgs e)
        {
            txtbuscar_TextChanged(sender, e);
        }
        int recepcion = 0;
        private void chkrecepcion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkrecepcion.Checked)
                recepcion = 1;
            else recepcion = 0;
            txtbuscar_TextChanged(sender, e);
        }

        private void dtpini_ValueChanged(object sender, EventArgs e)
        {
            txtbuscar_TextChanged(sender, e);
        }
        private void dtpfin_ValueChanged(object sender, EventArgs e)
        {
            txtbuscar_TextChanged(sender, e);
        }
        private void Dtguias_Sorted(object sender, EventArgs e)
        {
            Dtguias.EndEdit();
            FacturasSeleccionas();
        }
        private void btnExportarTxt_Click(object sender, EventArgs e)
        {

        }

        private void Dtguias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Dtguias.EndEdit();
            if (Dtguias.RowCount > 0)
            {
                if (Dtguias.Columns["ok"].Index == e.ColumnIndex)
                {
                    Boolean estado = false;
                    if (Dtguias["ok", 0].Value == null)
                        estado = false;
                    else
                        estado = Boolean.Parse(Dtguias["ok", 0].Value.ToString());
                    int y = 0;
                    foreach (DataGridViewRow xx in Dtguias.Rows)
                    {
                        xx.Cells["ok"].Value = !estado;
                        Dtguias_CellContentClick(sender, new DataGridViewCellEventArgs(0, y));
                        y++;
                    }
                }
            }
        }
        private void btnseleccion_Click(object sender, EventArgs e)
        {
            Dtguias.EndEdit();
            if (Dtguias.RowCount > 0)
            {
                Boolean estado = false;
                if (Dtguias["ok", 0].Value == null)
                    estado = false;
                else
                    estado = Boolean.Parse(Dtguias["ok", 0].Value.ToString());
                int y = 0;
                foreach (DataGridViewRow xx in Dtguias.Rows)
                {
                    xx.Cells["ok"].Value = !estado;
                    Dtguias_CellContentClick(sender, new DataGridViewCellEventArgs(0, y));
                    y++;
                }
                if (!estado)
                    btnseleccion.Text = "Deseleccionar  Todos";
                else
                    btnseleccion.Text = "Seleccionar Todos";

            }

        }
        public DialogResult MSG(string cadena)
        {
            return MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
        private void btnReversar_Click(object sender, EventArgs e)
        {
            if (Comprobantes.Count > 0)
            {
                if (MSG("Seguro Desea Reversar") == DialogResult.OK)
                {
                    foreach (FACTURAS xx in Comprobantes)
                    {
                        cPagarfactura.ReversaDeFacturas(xx.numero, xx.proveedor);
                    }
                }
            }
            else
            {
                msg("No hay Facturas Seleccionadas ");
                btnseleccion.Focus();
                return;
            }
            txtbuscar_TextChanged(sender, e);
        }
    }
}
