using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmproveedor : FormGradient
    {
        public frmproveedor()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CProveedor = new HPResergerCapaLogica.HPResergerCL();
        public int estado { get; set; }
        public int cambios { get; set; }
        public int tipoid { get; set; }
        public int sector { get; set; }
        public int bancosoles { get; set; }
        public int bancodolares { get; set; }
        public int regimen { get; set; }
        public string numeroidentidad { get; set; }
        public string razonsocial { get; set; }
        public string diroficina { get; set; }
        public string diralmacen { get; set; }
        public string dirsucursal { get; set; }
        public string teloficina { get; set; }
        public string telalmancen { get; set; }
        public string telsucursal { get; set; }
        public string persocontacto { get; set; }
        public string telefonocontacto { get; set; }
        public string emailcontacto { get; set; }
        public string nrocuentasoles { get; set; }
        public string nroccisoles { get; set; }
        public string nrocuentadolares { get; set; }
        public string nroccidolares { get; set; }
        public string nroctadetracciones { get; set; }
        public int tipobusca { get; set; }

        public void CargarDocumentoIdentidad()
        {
            cbodocumento.DataSource = CProveedor.getCargoTipoContratacion("Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");
            cbodocumento.DisplayMember = "DESCRIPCION";
            cbodocumento.ValueMember = "CODIGO";
            cbodocumento.Text = "RUC";
        }
        public void CargarSEctorComercial()
        {
            cbosectorcomercial.DataSource = CProveedor.getCargoTipoContratacion("Codigo_Sector_Empresarial", "Desc_Sector_Empresarial", "TBL_Sector_Empresarial");
            cbosectorcomercial.DisplayMember = "DESCRIPCION";
            cbosectorcomercial.ValueMember = "CODIGO";
        }
        public void CargarBanco()
        {
            cbobancosoles.DataSource = CProveedor.getCargoTipoContratacion("ID_Entidad", "Entidad_Financiera", "TBL_Entidad_Financiera");
            cbobancosoles.DisplayMember = "DESCRIPCION";
            cbobancosoles.ValueMember = "CODIGO";

            cbobancodolares.DataSource = CProveedor.getCargoTipoContratacion("ID_Entidad", "Entidad_Financiera", "TBL_Entidad_Financiera");
            cbobancodolares.DisplayMember = "DESCRIPCION";
            cbobancodolares.ValueMember = "CODIGO";
        }
        public void CargarRegimen()
        {
            DataTable tablita = new DataTable();
            tablita.Columns.Add("CODIGO");
            tablita.Columns.Add("DESCRIPCION");
            tablita.Rows.Add(new object[] { "2", "AGENTE RETENCION" });
            tablita.Rows.Add(new object[] { "1", "BUEN CONTRIBUYENTE" });
            cboregimen.DataSource = tablita;
            cboregimen.DisplayMember = "DESCRIPCION";
            cboregimen.ValueMember = "CODIGO";
            cboregimen.SelectedIndex = 1;
        }
        public string rucito;
        public int llamada = 0;
        private void frmproveedor_Load(object sender, EventArgs e)
        {
            estado = 0;
            tipobusca = 2;
            CargarDocumentoIdentidad();
            CargarSEctorComercial();
            CargarBanco();
            CargarRegimen();
            Iniciar(false);
            radioButton2.Checked = true;
            Txtbusca_TextChanged(sender, e);
            msg(dtgconten);        
        }        
        public void ListarProveedores(string busca, int opcion)
        {
            dtgconten.DataSource = CProveedor.ListarProveedores(busca, opcion);
        }
        private void frmproveedor_Activated(object sender, EventArgs e)
        {
            string valor = "", valor2 = "";
            //TIPO ID =1 sector empresarial=2 bancos=3
            if (cambios == 1)
            {
                valor = cbodocumento.Text;
                CargarDocumentoIdentidad();
                cbodocumento.Text = valor;
            }
            else
            {
                if (cambios == 3)
                {
                    valor = cbobancosoles.Text;
                    valor2 = cbobancodolares.Text;
                    CargarBanco();
                    cbobancosoles.Text = valor;
                    cbobancodolares.Text = valor2;
                }
            }
            cambios = 0;
        }
        private void cboregimen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //txtcuentadetracciones.Text = cboregimen.SelectedValue.ToString();
            }
            catch { }

        }
        private void btntipoidmas_Click(object sender, EventArgs e)
        {
            cambios = 1;
            frmTipoId tipoid = new frmTipoId();
            tipoid.Show();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Txtbusca.Text = "";
        }

        private void btnbancosmas_Click(object sender, EventArgs e)
        {
            cambios = 3;
            frmEntiFinanciera bancos = new frmEntiFinanciera();
            bancos.Show();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 2; Txtbusca_TextChanged(sender, e);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 1; Txtbusca_TextChanged(sender, e);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 3; Txtbusca_TextChanged(sender, e);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 4; Txtbusca_TextChanged(sender, e);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 5; Txtbusca_TextChanged(sender, e);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 6; Txtbusca_TextChanged(sender, e);
        }
        public void Txtbusca_TextChanged(object sender, EventArgs e)
        {
            // usp_listar_proveedores
            dtgconten.DataSource = CProveedor.ListarProveedores(Txtbusca.EstaLLeno() ? Txtbusca.Text : "", tipobusca);
            msg(dtgconten);
        }
        public void msg(DataGridView conteo)
        {
            lblmsg.Text = "Total Registros: " + conteo.RowCount;
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex;
            if (y >= 0)
            {
                txtnumeroidentidad.Text = dtgconten["RUC", y].Value.ToString();
                txtnombrerazonsocial.Text = dtgconten["RAZONSOCIAL", y].Value.ToString();
                txtnombrecomercial.Text = dtgconten["nombrecomercial", y].Value.ToString();
                cbosectorcomercial.Text = dtgconten["SECTOREMPRESACIAL", y].Value.ToString();
                txtdireccionoficina.Text = dtgconten["DIROFICINA", y].Value.ToString();
                txttelefonooficina.Text = dtgconten["TELOFICINA", y].Value.ToString();
                txtdireccionalmacen.Text = dtgconten["DIRALMACEN", y].Value.ToString();
                txttelefonoalmacen.Text = dtgconten["TELALMACEN", y].Value.ToString();
                txtdireccionsucursal.Text = dtgconten["DIRSUCURSAL", y].Value.ToString();
                txttelefonosucursal.Text = dtgconten["TELSUCURSAL", y].Value.ToString();
                txtpersonacontacto.Text = dtgconten["NOMCONTACTO", y].Value.ToString();
                txttelefonocontacto.Text = dtgconten["TELCONTACTO", y].Value.ToString();
                txtemailcontacto.Text = dtgconten["EMAILCONTACTO", y].Value.ToString();
                txtcuentasoles.Text = dtgconten["CTASOLES", y].Value.ToString();
                txtccisoles.Text = dtgconten["CCISOLES", y].Value.ToString();
                cbobancosoles.Text = dtgconten["BANCOSOLES", y].Value.ToString();
                txtcuentadolares.Text = dtgconten["CTADOLARES", y].Value.ToString();
                txtccidolares.Text = dtgconten["CCIDOLARES", y].Value.ToString();
                cbobancodolares.Text = dtgconten["BANCODOLARES", y].Value.ToString();
                txtcuentadetracciones.Text = dtgconten["CTADETRACCIONES", y].Value.ToString();
                cboregimen.SelectedValue = dtgconten["REGIMEN", y].Value.ToString();
                cbotipopersona.SelectedIndex = int.Parse(dtgconten["TIPOPER", y].Value.ToString()) - 1;
                cboctasoles.SelectedIndex = int.Parse(dtgconten["TIPOCTASOLES", y].Value.ToString() == "" ? "0" : dtgconten["TIPOCTASOLES", y].Value.ToString()) - 1;
                cboctadolares.SelectedIndex = int.Parse(dtgconten["TIPOCTADOLARES", y].Value.ToString() == "" ? "0" : dtgconten["TIPOCTADOLARES", y].Value.ToString()) - 1;
                txtplazofijo.Text = dtgconten[PLAZOPAGOX.Name, y].Value.ToString();
            }
        }
        public void Iniciar(Boolean a)
        {
            txtnombrecomercial.Enabled = a;
            cbotipopersona.Enabled = a;
            btnsectormas.Enabled = a; cboctasoles.Enabled = cboctadolares.Enabled = a;
            //cbodocumento.Enabled = a;
            txtnumeroidentidad.ReadOnly = !a;
            txtnombrerazonsocial.Enabled = a;
            cbosectorcomercial.Enabled = a;
            btnbancosmas.Enabled = a;
            btntipoidmas.Enabled = a;
            txtdireccionalmacen.Enabled = a;
            txtdireccionoficina.Enabled = a;
            txtdireccionsucursal.Enabled = a;
            txttelefonoalmacen.Enabled = a;
            txttelefonocontacto.Enabled = a;
            txttelefonooficina.Enabled = a;
            txttelefonosucursal.Enabled = a;
            txtpersonacontacto.Enabled = a;
            txtemailcontacto.Enabled = a;
            txtccidolares.Enabled = a;
            txtccisoles.Enabled = a;
            txtcuentadolares.Enabled = a;
            txtcuentasoles.Enabled = a;
            txtcuentadetracciones.Enabled = a;
            cbobancodolares.Enabled = a;
            cbobancosoles.Enabled = a;
            cboregimen.Enabled = a;
            dtgconten.Enabled = !a;
            Txtbusca.Enabled = !a;
            btnnuevo.Enabled = !a;
            btnmodificar.Enabled = !a;
            btneliminar.Enabled = !a;
            txtplazofijo.Enabled = a;
        }
        public void Activar()
        {
            Txtbusca.Enabled = btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = true;
        }
        public void Desactivar()
        {
            Txtbusca.Enabled = btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = false;
        }
        public void btnnuevo_Click(object sender, EventArgs e)
        {
            CargarDocumentoIdentidad(); CargarBanco();
            CargarRegimen(); CargarSEctorComercial();
            estado = 1; Desactivar();
            //LLamadaDeEntradaDeDatos
            txtnumeroidentidad.Text = "";
            tipmsg.Show("Ingrese Número de Identidad", txtnumeroidentidad, 700);
            txtnumeroidentidad.Focus();
            //VaciarDatosDeCajas
            txtnombrerazonsocial.Text =
            txtdireccionoficina.Text =
            txtdireccionalmacen.Text =
            txtdireccionsucursal.Text =
            txttelefonooficina.Text =
            txttelefonoalmacen.Text =
            txttelefonosucursal.Text =
            txtpersonacontacto.Text =
            txttelefonocontacto.Text =
            txtemailcontacto.Text =
            txtcuentasoles.Text =
            txtcuentadolares.Text =
            txtccisoles.Text =
            txtccidolares.Text =
         txtnombrecomercial.Text = txtcuentadetracciones.Text = "";
            cboctasoles.SelectedIndex = cboctadolares.SelectedIndex = -1;
            Iniciar(true);
            llamada = 0;
            txtplazofijo.Text = "30";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Iniciar(false); llamada = 100;
            if (estado == 0)
            {

                this.Close();
            }
            else
            {
                if (estado == 1)
                {
                    if (MessageBox.Show("Hay datos Ingresados, Desea Salir?", CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        estado = 0;
                        Activar();
                        //ActivarModi();
                        PresentarValor("");
                        Txtbusca.Enabled = true;
                    }
                }
                else
                {
                    estado = 0;
                    Activar();
                    //ActivarModi();
                    PresentarValor("");
                    Txtbusca.Enabled = true;
                }
            }
        }
        public void DesactivarModi() { cbodocumento.Enabled = txtnombrerazonsocial.Enabled = btntipoidmas.Enabled = false; txtnumeroidentidad.ReadOnly = true; }
        public void ActivarModi() { txtnumeroidentidad.ReadOnly = false; txtnombrerazonsocial.Enabled = btntipoidmas.Enabled = true; }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2; anterior = txtnumeroidentidad.Text.Trim();
            tipmsg.Show("Ingrese Dirección de Oficina", txtdireccionoficina, 700);
            Desactivar(); DesactivarModi();
            txtdireccionoficina.Focus(); Iniciar(true);
            llamada = 0;
            //cbotipo.Enabled = false; modmarca = Convert.ToInt32(cbomarca.SelectedValue.ToString());

        }
        string anterior = "";
        public Boolean VerificarDatos(string DocumentoId, string RazonSocial)
        {
            Boolean aux = true;
            if (!string.IsNullOrWhiteSpace(DocumentoId) && !string.IsNullOrWhiteSpace(RazonSocial))
            {
                if (CProveedor.VerificarProveedores(DocumentoId, RazonSocial).Rows.Count > 0)
                {
                    MessageBox.Show("Ya Existe este Proveedor: " + RazonSocial + "; Identificación:" + DocumentoId, CompanyName, MessageBoxButtons.OK);
                    aux = false;
                }
            }
            else
            {
                aux = false;
                MessageBox.Show("Número de Identidad y Razón Social No pueden estar Vacios", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return aux;
        }
        int ctasoles = 0, ctadolares = 0, tipoper = 0;
        public void CargarValoresDeIngreso()
        {
            numeroidentidad = txtnumeroidentidad.Text;
            razonsocial = txtnombrerazonsocial.Text;
            sector = Convert.ToInt32(cbosectorcomercial.SelectedValue);
            diroficina = txtdireccionoficina.Text;
            teloficina = txttelefonooficina.Text;
            diralmacen = txtdireccionalmacen.Text;
            telalmancen = txttelefonoalmacen.Text;
            dirsucursal = txtdireccionsucursal.Text;
            telsucursal = txttelefonosucursal.Text;
            persocontacto = txtpersonacontacto.Text;
            telefonocontacto = txttelefonocontacto.Text;
            emailcontacto = txtemailcontacto.Text;
            nrocuentasoles = txtcuentasoles.Text;
            nroccisoles = txtccisoles.Text;
            bancosoles = Convert.ToInt32(cbobancosoles.SelectedValue);
            nrocuentadolares = txtcuentadolares.Text;
            nroccidolares = txtccidolares.Text;
            bancodolares = Convert.ToInt32(cbobancodolares.SelectedValue);
            nroctadetracciones = txtcuentadetracciones.Text;
            regimen = Convert.ToInt32(cboregimen.SelectedValue);
            tipoper = cbotipopersona.SelectedIndex + 1;
            ctasoles = cboctasoles.SelectedIndex + 1;
            ctadolares = cboctadolares.SelectedIndex + 1;
        }

        public void MensajedeDatos()
        {
            MessageBox.Show("ACCIÓN EXITOSA \n Documento Identidad=" + numeroidentidad + "\n" + "Documento Identidad = " + razonsocial + "\n" +
                 "Sector Empresarial = " + cbosectorcomercial.Text + "\n" + "Dirección Oficina = " + diroficina + "\n" +
                 "Teléfono Oficina = " + teloficina + "\n" + "Dirección Almacén = " + diralmacen + "\n" + "Teléfono Almacén = " + telalmancen + "\n" + "Dirección Sucursal = " + dirsucursal + "\n" +
                 "Teléfono Sucursal = " + telsucursal + "\n" + "Persona Contacto = " + persocontacto + "\n" + "Teléfono Contacto = " + telefonocontacto + "\n" +
                 "Email Contacto = " + emailcontacto + "\n" + "Nro Cuenta Soles = " + nrocuentasoles + "\n" + "Nro Cci Soles = " + nroccisoles + "\n" +
                 "Banco Soles  = " + cbobancosoles.Text + "\n" + "Nro Cuenta Dólares = " + nrocuentadolares + "\n" + "Nro Cci Dólares= " + nroccidolares + "\n" +
                 "Banco Dolares = " + cbobancodolares.Text + "\n" + "Nro CTa Detracciones = " + nroctadetracciones + "\n" + "Régimen = " + cboregimen.Text + "\n", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        Boolean salida = false;

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (llamada != 0)
            {
                salida = true;
                rucito = txtnumeroidentidad.Text;
                this.Close();
            }
            //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones    
            string Documentoid, nombrerazon;
            Documentoid = txtnumeroidentidad.Text;
            nombrerazon = txtnombrerazonsocial.Text;
            int plzfijo = int.Parse(txtplazofijo.Text == "" ? "0" : txtplazofijo.Text);
            if (estado == 1 && VerificarDatos(Documentoid, nombrerazon))
            {
                CargarValoresDeIngreso();
                //MensajedeDatos();               
                //usp_insertar_proveedor
                CProveedor.InsertarProveedor(anterior, numeroidentidad, razonsocial, razonsocial, sector, diroficina, teloficina, diralmacen, telalmancen, dirsucursal, telsucursal, telefonocontacto,
                persocontacto, emailcontacto, nrocuentasoles, nroccisoles, bancosoles, nrocuentadolares, nroccidolares, bancodolares, nroctadetracciones, regimen, tipoper, ctasoles, ctadolares, plzfijo);
                PresentarValor("");
                Iniciar(false);
                MessageBox.Show("Se Insertó con Exito", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (estado == 2)
                {
                    CargarValoresDeIngreso();
                    //MensajedeDatos();                    
                    //usp_actualizar_proveedor
                    CProveedor.ActualizarProveedor(anterior, numeroidentidad, sector, diroficina, teloficina, diralmacen, telalmancen, dirsucursal, telsucursal, telefonocontacto,
                    persocontacto, emailcontacto, nrocuentasoles, nroccisoles, bancosoles, nrocuentadolares, nroccidolares, bancodolares, nroctadetracciones, regimen, tipoper, ctasoles, ctadolares, plzfijo);
                    PresentarValor("");
                    Iniciar(false);
                    MessageBox.Show("Se Modificó con Exito", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (estado == 3)
                    {
                        if (MessageBox.Show("Seguró Desea Eliminar; " + txtnombrerazonsocial.Text + " Nro Documento: " + txtnumeroidentidad.Text, CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                        {
                            //CProveedor.EliminarProveedor(marcas, Convert.ToInt32(txtcodigo.Text.ToString()));                            
                            MessageBox.Show("Eliminado Exitosamente ", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PresentarValor("");

                        }
                    }
                }
            }
        }
        public void PresentarValor(string final)
        {
            estado = 0;
            dtgconten.DataSource = CProveedor.ListarProveedores(final, 1);
            Activar(); //ActivarModi();
        }
        private void txtnumeroidentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txttelefonooficina_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtpersonacontacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Sololetras(e);
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            btnaceptar_Click(sender, e);
        }

        private void txtnumeroidentidad_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtnumeroidentidad, 10);
        }

        private void txttelefonooficina_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txttelefonooficina, 15);
        }

        private void txttelefonoalmacen_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txttelefonoalmacen, 15);
        }

        private void txttelefonosucursal_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txttelefonosucursal, 15);
        }

        private void txttelefonocontacto_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txttelefonocontacto, 15);
        }

        private void txtcuentasoles_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtcuentasoles, 16);
        }

        private void txtcuentadolares_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtcuentadolares, 16);
        }

        private void txtccisoles_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtccisoles, 20);
        }

        private void txtccidolares_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtccidolares, 20);
        }

        private void txtcuentadetracciones_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtcuentadetracciones, 20);
        }
        private void frmproveedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!salida)
                llamada = 100;
            if (string.IsNullOrWhiteSpace(rucito))
            {
                rucito = txtnumeroidentidad.Text;
            }
        }
        private void txtplazofijo_Leave(object sender, EventArgs e)
        {
            if (int.Parse(txtplazofijo.Text) == 0)
                txtplazofijo.Text = "30";
        }
        private void txtpersonacontacto_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarPegarSoloLetras(e, txtpersonacontacto, 40);
        }
        private void btnsectormas_Click(object sender, EventArgs e)
        {
            string sector = cbosectorcomercial.Text;
            frmSectorEmpresarial frmsector = new frmSectorEmpresarial();
            frmsector.ShowDialog();
            CargarSEctorComercial();
            cbosectorcomercial.Text = sector;

        }
    }
}
