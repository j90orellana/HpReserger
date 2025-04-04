﻿using HpResergerUserControls;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using Npgsql;
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
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace HPReserger
{
    public partial class frmproveedor : FormGradient
    {
        public frmproveedor()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CProveedor = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
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
            CProveedor.TablaTipoID(cbodocumento);
            cbodocumento.Text = "RUC";
            /////VALORES POR DEFECTO
            System.Data.DataTable TDoc = (System.Data.DataTable)cbodocumento.DataSource;
            int length = TDoc.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (TDoc.Rows[i]["valor"].ToString().ToUpper() == "RUC" || TDoc.Rows[i]["valor"].ToString().ToUpper() == "OTROS" || TDoc.Rows[i]["codigo"].ToString().ToUpper() == "1") { }
                else { TDoc.Rows.RemoveAt(i); i--; length--; }
            }
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
        public void CargarCondicioncontribuyente()
        {
          System.Data.  DataTable tablita = new System.Data.DataTable();
            tablita.Columns.Add("CODIGO");
            tablita.Columns.Add("DESCRIPCION");
            tablita.Rows.Add(new object[] { "1", "1. HABIDO" });
            tablita.Rows.Add(new object[] { "2", "2. NO HABIDO" });
            cbocondicion.DataSource = tablita;
            cbocondicion.DisplayMember = "DESCRIPCION";
            cbocondicion.ValueMember = "CODIGO";
            cbocondicion.SelectedIndex = 1;
            //////estado de lcontrubibuente
            System.Data.DataTable tabla2 = new System.Data.DataTable();
            tabla2.Columns.Add("CODIGO");
            tabla2.Columns.Add("DESCRIPCION");
            tabla2.Rows.Add(new object[] { "1", "1. ACTIVO" });
            tabla2.Rows.Add(new object[] { "2", "2. SUSPENSION TEMPORAL" });
            tabla2.Rows.Add(new object[] { "3", "3. BAJA DE ACTIVIDADES" });
            cboestado.DataSource = tabla2;
            cboestado.DisplayMember = "DESCRIPCION";
            cboestado.ValueMember = "CODIGO";
            cboestado.SelectedIndex = 1;
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
            CargarCondicioncontribuyente();
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
                cbodocumento.SelectedValue = (int)dtgconten[xtipoid.Name, y].Value;
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
                txtcuentasoles.Text = dtgconten[xctasoles.Name, y].Value.ToString();
                txtccisoles.Text = dtgconten["CCISOLES", y].Value.ToString();
                cbobancosoles.Text = dtgconten["BANCOSOLES", y].Value.ToString();
                txtcuentadolares.Text = dtgconten[xctadolares.Name, y].Value.ToString();
                txtccidolares.Text = dtgconten["CCIDOLARES", y].Value.ToString();
                cbobancodolares.Text = dtgconten["BANCODOLARES", y].Value.ToString();
                txtcuentadetracciones.Text = dtgconten["CTADETRACCIONES", y].Value.ToString();
                cbocondicion.SelectedValue = dtgconten[CONDICION.Name, y].Value.ToString();
                cbotipopersona.SelectedIndex = int.Parse(dtgconten[xTipoper.Name, y].Value.ToString()) - 1;
                cboctasoles.SelectedIndex = int.Parse(dtgconten["TIPOCTASOLES", y].Value.ToString() == "" ? "0" : dtgconten["TIPOCTASOLES", y].Value.ToString()) - 1;
                cboctadolares.SelectedIndex = int.Parse(dtgconten["TIPOCTADOLARES", y].Value.ToString() == "" ? "0" : dtgconten["TIPOCTADOLARES", y].Value.ToString()) - 1;
                txtplazofijo.Text = dtgconten[PLAZOPAGOX.Name, y].Value.ToString();
                cboestado.SelectedValue = (int)dtgconten[xEstado.Name, y].Value;
                cbocondicion.SelectedValue = dtgconten[CONDICION.Name, y].Value.ToString() == "" ? 0 : (int)dtgconten[CONDICION.Name, y].Value;
                chknuevorus.Checked = dtgconten[xAFECTONVORUS.Name, y].Value.ToString() == "" ? false : (Boolean)(dtgconten[xAFECTONVORUS.Name, y].Value);
                chkAgentePercepcion.Checked = dtgconten[xAGENTEPERCEPVTAINT.Name, y].Value.ToString() == "" ? false : (Boolean)(dtgconten[xAGENTEPERCEPVTAINT.Name, y].Value);
                chkbuenContribuyente.Checked = dtgconten[xBUENCONTRIB.Name, y].Value.ToString() == "" ? false : (Boolean)(dtgconten[xBUENCONTRIB.Name, y].Value);
                chkretencion.Checked = dtgconten[xAGENTERETENCION.Name, y].Value.ToString() == "" ? false : (Boolean)(dtgconten[xAGENTERETENCION.Name, y].Value);
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
            cbocondicion.Enabled = a;
            dtgconten.Enabled = !a;
            Txtbusca.Enabled = !a;
            btnnuevo.Enabled = !a;
            btnmodificar.Enabled = !a;
            btneliminar.Enabled = !a;
            txtplazofijo.Enabled = a;
            cbodocumento.Enabled = a;
            ////ultimos agregados
            cbocondicion.Enabled = cboestado.Enabled = chkAgentePercepcion.Enabled = chkbuenContribuyente.Enabled = chknuevorus.Enabled = chkretencion.Enabled = a;
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
            CargarCondicioncontribuyente(); CargarSEctorComercial();
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
            txtccidolares.Text = txtnombrecomercial.Text = txtcuentadetracciones.Text = "";
            cboctasoles.SelectedIndex = cboctadolares.SelectedIndex = -1;
            Iniciar(true);
            llamada = 0;
            txtplazofijo.Text = "30";
            cboestado.SelectedIndex = 0; cbocondicion.SelectedIndex = 0;
            chknuevorus.Checked = chkAgentePercepcion.Checked = chkbuenContribuyente.Checked = chkretencion.Checked = false;
            cbodocumento_SelectedIndexChanged(sender, e);
        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
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
                    if (msgp("Hay datos Ingresados, Desea Salir?") == DialogResult.Yes)
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
            estado = 2; AnteriorRuc = txtnumeroidentidad.Text;
            AnteriorTipoId = (int)cbodocumento.SelectedValue;
            tipmsg.Show("Ingrese Dirección de Oficina", txtdireccionoficina, 700);
            Desactivar(); DesactivarModi();
            txtdireccionoficina.Focus(); Iniciar(true);
            llamada = 0;
            //cbotipo.Enabled = false; modmarca = Convert.ToInt32(cbomarca.SelectedValue.ToString());
        }
        int AnteriorTipoId = 0;
        string AnteriorRuc = "";
        public Boolean VerificarDatos(string DocumentoId, string RazonSocial)
        {
            Boolean aux = true;
            if (!string.IsNullOrWhiteSpace(DocumentoId) && !string.IsNullOrWhiteSpace(RazonSocial))
            {
                if (CProveedor.VerificarProveedores(DocumentoId, RazonSocial).Rows.Count > 0)
                {
                    msg("Ya Existe este Proveedor: " + RazonSocial + "; Identificación:" + DocumentoId);
                    aux = false;
                }
            }
            else
            {
                aux = false;
                msg("Número de Identidad y Razón Social No pueden estar Vacios");
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
            regimen = Convert.ToInt32(cbocondicion.SelectedValue);
            tipoper = cbotipopersona.SelectedIndex + 1;
            ctasoles = cboctasoles.SelectedIndex + 1;
            ctadolares = cboctadolares.SelectedIndex + 1;
        }
        Boolean salida = false;
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (llamada != 0)
            {
                salida = true;
                rucito = txtnumeroidentidad.Text;
                tipoid = (int)(cbodocumento.SelectedValue);
                this.Close();
            }
            //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones    
            string Documentoid, nombrerazon;
            Documentoid = txtnumeroidentidad.Text;
            nombrerazon = txtnombrerazonsocial.Text;
            int plzfijo = int.Parse(txtplazofijo.Text == "" ? "0" : txtplazofijo.Text);
            if (cboestado.SelectedValue == null) { msg("Seleccione Estado Proveedor"); cboestado.Focus(); return; }
            if (cbocondicion.SelectedValue == null) { msg("Seleccione Condición Proveedor"); cbocondicion.Focus(); return; }
            if (estado == 1 && VerificarDatos(Documentoid, nombrerazon))
            {
                CargarValoresDeIngreso();
                cbodocumento_SelectedIndexChanged(sender, e);
                if (cbodocumento.Text.ToUpper() != "OTROS")
                {
                    if (txtnumeroidentidad.MaxLength != txtnumeroidentidad.TextLength) { txtnumeroidentidad.Focus(); msg($"El Tamaño del Numero de Documento debe ser de {txtnumeroidentidad.MaxLength}"); return; }
                }
                else
                    if (txtnumeroidentidad.MaxLength < txtnumeroidentidad.TextLength) { txtnumeroidentidad.Focus(); msg($"El Tamaño del Numero de Documento debe ser de {txtnumeroidentidad.MaxLength}"); return; }

                //MensajedeDatos();               
                //usp_insertar_proveedor
                CProveedor.InsertarProveedor((int)cbodocumento.SelectedValue, AnteriorRuc, numeroidentidad, razonsocial, razonsocial, sector, diroficina, teloficina, diralmacen, telalmancen, dirsucursal, telsucursal, telefonocontacto,
                persocontacto, emailcontacto, nrocuentasoles, nroccisoles, bancosoles, nrocuentadolares, nroccidolares, bancodolares, nroctadetracciones, tipoper, ctasoles, ctadolares, plzfijo
                , int.Parse(cbocondicion.SelectedValue.ToString()), int.Parse(cboestado.SelectedValue.ToString()), chknuevorus.Checked, chkretencion.Checked, chkbuenContribuyente.Checked, chkAgentePercepcion.Checked);
                PresentarValor("");
                Iniciar(false);
                msgOK("Se Insertó con Exito");
            }
            else
            {
                if (estado == 2)
                {
                    CargarValoresDeIngreso();
                    cbodocumento_SelectedIndexChanged(sender, e);
                    if (cbodocumento.Text.ToUpper() != "OTROS")
                    {
                        if (txtnumeroidentidad.MaxLength != txtnumeroidentidad.TextLength) { txtnumeroidentidad.Focus(); msg($"El Tamaño del Numero de Documento debe ser de {txtnumeroidentidad.MaxLength}"); return; }
                    }
                    else
                        if (txtnumeroidentidad.MaxLength < txtnumeroidentidad.TextLength) { txtnumeroidentidad.Focus(); msg($"El Tamaño del Numero de Documento debe ser de {txtnumeroidentidad.MaxLength}"); return; }

                    //MensajedeDatos();                    
                    //usp_actualizar_proveedor
                    int[] xy = HPResergerFunciones.Utilitarios.SacarPosicionActualFilaColumna(dtgconten);
                    DataRow Filita = CProveedor.ActualizarProveedor((int)cbodocumento.SelectedValue, AnteriorTipoId, AnteriorRuc, numeroidentidad, txtnombrerazonsocial.Text, txtnombrecomercial.Text, sector, diroficina, teloficina, diralmacen, telalmancen, dirsucursal, telsucursal, telefonocontacto,
                     persocontacto, emailcontacto, nrocuentasoles, nroccisoles, bancosoles, nrocuentadolares, nroccidolares, bancodolares, nroctadetracciones, tipoper, ctasoles, ctadolares, plzfijo
                       , int.Parse(cbocondicion.SelectedValue.ToString()), int.Parse(cboestado.SelectedValue.ToString()), chknuevorus.Checked, chkretencion.Checked, chkbuenContribuyente.Checked, chkAgentePercepcion.Checked);
                    if ((int)Filita["Resultado"] == 0)
                        msgOK("Actualizado Exitosamente");
                    else
                    {
                        msg("No se pudo Modificar, Proveedor ya tiene Movimientos");
                        return;
                    }
                    PresentarValor("");
                    Iniciar(false);
                    dtgconten.CurrentCell = dtgconten[xy[0], xy[1]];
                    // Message Box.Show("Se Modificó con Exito", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (estado == 3)
                    {
                        if (msgp("Seguró Desea Eliminar; " + txtnombrerazonsocial.Text + " Nro Documento: " + txtnumeroidentidad.Text) == DialogResult.Yes)
                        {
                            DataRow Filita = CProveedor.EliminarProveedor((int)cbodocumento.SelectedValue, txtnumeroidentidad.Text);
                            if ((int)Filita["Resultado"] == 0)
                                msgOK("Eliminado Exitosamente");
                            else
                                msg("No se pudo eliminar, Proveedor ya tiene Movimientos");
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
            if (cbodocumento.Text.ToUpper() != "OTROS")
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
            if (cbodocumento.Text.ToUpper() != "OTROS")
                HPResergerFunciones.Utilitarios.Validardocumentos(e, txtnumeroidentidad, 11);
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
        public void Mensaje(string cadena) { HPResergerFunciones.Utilitarios.msg(cadena); }
        private void dtgconten_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (llamada == 10)
            {
                salida = true;
                rucito = dtgconten[RUC.Name, e.RowIndex].Value.ToString();
                tipoid = (int)dtgconten[xtipoid.Name, e.RowIndex].Value;
                this.Close();
            }
        }
        private void txtnumeroidentidad_TextChanged(object sender, EventArgs e)
        {
            if (estado == 1)//cuando vamos a ingresar uno nuevo
                if (txtnumeroidentidad.Text.Length == 11)
                {
                    //BuscarProveedorAPiToken(txtnumeroidentidad.Text);
                    BuscarProveedorAPi(txtnumeroidentidad.Text);
                }
        }
        public async Task<string> GetHTTPsToken(string ruc)
        {
            string url = Configuraciones.ApiRUCToken + ruc + Configuraciones.Token;
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }
        private async void BuscarProveedorAPiToken(string ruc)
        {
            try
            {
                string respuesta = await GetHTTPsToken(ruc);
                respuesta = "[\n " + respuesta + " \n]";
                List<ProveedorToken> LstData = JsonConvert.DeserializeObject<List<ProveedorToken>>(respuesta);
                //SAcamos la Data             
                if (LstData.Count > 0)
                {
                    ProveedorToken Pro = LstData[0];
                    txtnombrerazonsocial.Text = txtnombrecomercial.Text = LstData[0].razonSocial;
                    //cbodocumento.SelectedValue = LstData[0].tipoDocumento - 1;
                    txtdireccionoficina.Text = LstData[0].direccion;
                    //if (txtdireccionoficina.Text == "- -  - ") txtdireccionoficina.Text = "-";
                    if (LstData[0].condicion == "HABIDO") cbocondicion.SelectedValue = 1; else cbocondicion.SelectedIndex = 2;
                    if (LstData[0].estado == "ACTIVO") cboestado.SelectedValue = 1;
                    if (LstData[0].estado == "SUSPENSION TEMPORAL") cboestado.SelectedValue = 2;
                    if (LstData[0].estado == "BAJA DEFINITIVA") cboestado.SelectedValue = 3;
                    if (LstData[0].estado == "BAJA DE OFICIO") cboestado.SelectedValue = 3;
                }
            }
            catch (Exception) { }

        }

        public async Task<string> GetHTTPs(string ruc)
        {
            string url = Configuraciones.ApiRuc + ruc;// + año + "-" + mes.ToString("00");
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebRequest oRequest = WebRequest.Create(url);
            oRequest.Headers.Clear();
            oRequest.Headers.Add(HttpRequestHeader.Authorization, "Bearer $apis-token-1887.qDw9MbrxloHL-d0c8MlKO44xEQ3S-STB");
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }
        public async void BuscarProveedorAPi(string ruc)
        {
            try
            {
                string respuesta = await GetHTTPs(ruc);
                respuesta = "[\n " + respuesta + " \n]";
                List<Proveedor> LstData = JsonConvert.DeserializeObject<List<Proveedor>>(respuesta);
                //SAcamos la Data             
                if (LstData.Count > 0)
                {
                    txtnombrerazonsocial.Text = txtnombrecomercial.Text = LstData[0].nombre;
                    cbodocumento.SelectedValue = LstData[0].tipoDocumento - 1;
                    txtdireccionoficina.Text = LstData[0].direccion + " - " + LstData[0].distrito + " - " + LstData[0].departamento;
                    if (txtdireccionoficina.Text == "- -  - ") txtdireccionoficina.Text = "-";
                    if (LstData[0].condicion == "HABIDO") cbocondicion.SelectedIndex = 0; else cbocondicion.SelectedIndex = 1;
                    if (LstData[0].estado == "ACTIVO") cboestado.SelectedValue = 1;
                    if (LstData[0].estado == "SUSPENSION TEMPORAL") cboestado.SelectedValue = 2;
                    if (LstData[0].estado == "BAJA DEFINITIVA") cboestado.SelectedValue = 3;
                    if (LstData[0].estado == "BAJA DE OFICIO") cboestado.SelectedValue = 3;
                }
            }
            catch (Exception e) { }
        }
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class ProveedorToken
        {
            public string ruc { get; set; }
            public string razonSocial { get; set; }
            public object nombreComercial { get; set; }
            public List<object> telefonos { get; set; }
            public object tipo { get; set; }
            public string estado { get; set; }
            public string condicion { get; set; }
            public string direccion { get; set; }
            public string departamento { get; set; }
            public string provincia { get; set; }
            public string distrito { get; set; }
            public object fechaInscripcion { get; set; }
            public object sistEmsion { get; set; }
            public object sistContabilidad { get; set; }
            public object actExterior { get; set; }
            public List<object> actEconomicas { get; set; }
            public List<object> cpPago { get; set; }
            public List<object> sistElectronica { get; set; }
            public object fechaEmisorFe { get; set; }
            public List<object> cpeElectronico { get; set; }
            public object fechaPle { get; set; }
            public List<object> padrones { get; set; }
            public object fechaBaja { get; set; }
            public object profesion { get; set; }
            public string ubigeo { get; set; }
            public string capital { get; set; }
        }

        public class Proveedor
        {
            public string nombre { get; set; }
            public int tipoDocumento { get; set; }
            public string numeroDocumento { get; set; }
            public string estado { get; set; }
            public string condicion { get; set; }
            public string direccion { get; set; }
            public string ubigeo { get; set; }
            public string viaTipo { get; set; }
            public string viaNombre { get; set; }
            public string zonaCodigo { get; set; }
            public string zonaTipo { get; set; }
            public string numero { get; set; }
            public string interior { get; set; }
            public string lote { get; set; }
            public string dpto { get; set; }
            public string manzana { get; set; }
            public string kilometro { get; set; }
            public string distrito { get; set; }
            public string provincia { get; set; }
            public string departamento { get; set; }
        }
        private void cbodocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = cbodocumento.SelectedIndex;
            try
            {
                if (cbodocumento.DataSource != null)
                    txtnumeroidentidad.MaxLength = (int)((System.Data.DataTable)cbodocumento.DataSource).Rows[x]["Leng"];
            }
            catch (Exception) { }
        }
        class Proveedorx
        {
            public string RUC { get; set; }
            public string RazonSocial { get; set; }
            public string NombreComercial { get; set; }
            public int SectorComercial { get; set; }
            public string NroCtaDetracciones { get; set; }
        }
        static List<Proveedorx> LeerExcel(string excelPath)
        {
            List<Proveedorx> lista = new List<Proveedorx>();

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = excelApp.Workbooks.Open(excelPath);
            Worksheet worksheet = workbook.Sheets[1];
            Range range = worksheet.UsedRange;

            for (int row = 2; row <= range.Rows.Count; row++) // Desde la fila 2 (omitiendo encabezados)
            {
                string ruc = (range.Cells[row, 1] as Range).Text;
                string razonSocial = (range.Cells[row, 2] as Range).Text;
                string nombreComercial = (range.Cells[row, 3] as Range).Text;
                int sectorComercial = int.Parse((range.Cells[row, 4] as Range).Text);
                string nroCtaDetracciones = (range.Cells[row, 5] as Range).Text;

                lista.Add(new Proveedorx
                {
                    RUC = ruc,
                    RazonSocial = razonSocial,
                    NombreComercial = nombreComercial,
                    SectorComercial = sectorComercial,
                    NroCtaDetracciones = string.IsNullOrEmpty(nroCtaDetracciones) ? null : nroCtaDetracciones
                });
            }

            workbook.Close(false);
            excelApp.Quit();

            return lista;
        }
        static void InsertarOActualizarProveedores(List<Proveedorx> proveedores, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (var proveedor in proveedores)
                {
                    string checkQuery = "SELECT COUNT(*) FROM TBL_Proveedor WHERE RUC = @RUC";
                    using (SqlCommand cmdCheck = new SqlCommand(checkQuery, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@RUC", proveedor.RUC);
                        int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        if (count > 0) // Si el proveedor ya existe, actualizar nro_cta_detracciones
                        {
                            string updateQuery = @"
                        UPDATE TBL_Proveedor 
                        SET nro_cta_detracciones = @NroCtaDetracciones
                        WHERE RUC = @RUC";

                            using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                            {
                                cmdUpdate.Parameters.AddWithValue("@RUC", proveedor.RUC);
                                cmdUpdate.Parameters.AddWithValue("@NroCtaDetracciones",
                                    (object)proveedor.NroCtaDetracciones ?? DBNull.Value);
                                cmdUpdate.ExecuteNonQuery();
                            }
                        }
                        else // Si el proveedor no existe, insertar un nuevo registro
                        {
                            string insertQuery = @"
                        INSERT INTO TBL_Proveedor 
                        (EstadoContrib,tipo_id,RUC, razon_social, nombre_comercial, sector_comercial, PlazoDias, EstadoContrib, nro_cta_detracciones) 
                        VALUES 
                        (1,5,@RUC, @RazonSocial, @NombreComercial, @SectorComercial, DEFAULT, DEFAULT, @NroCtaDetracciones)";

                            using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                            {
                                cmdInsert.Parameters.AddWithValue("@RUC", proveedor.RUC);
                                cmdInsert.Parameters.AddWithValue("@RazonSocial", proveedor.RazonSocial);
                                cmdInsert.Parameters.AddWithValue("@NombreComercial", proveedor.NombreComercial);
                                cmdInsert.Parameters.AddWithValue("@SectorComercial", proveedor.SectorComercial);
                                cmdInsert.Parameters.AddWithValue("@NroCtaDetracciones",
                                    (object)proveedor.NroCtaDetracciones ?? DBNull.Value);

                                cmdInsert.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }
        private void btnCargaMasiva_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos Excel (*.xlsx;*.xls)|*.xlsx;*.xls";
                openFileDialog.Title = "Seleccionar archivo de Excel";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string excelPath = openFileDialog.FileName;
                    HPResergerCapaDatos.HPResergerCD cddata = new HPResergerCapaDatos.HPResergerCD();
                    string connectionString = cddata.ObtenerConexion();

                    List<Proveedorx> proveedores = LeerExcel(excelPath);
                    InsertarOActualizarProveedores(proveedores, connectionString);

                    XtraMessageBox.Show("Datos importados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog SF = new SaveFileDialog();
            SF.Filter = "Archivos de Excel *.xlsx|*.xlsx";
            SF.FileName = "Formato de Carga de Ventas";
            var result = SF.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.WriteAllBytes(SF.FileName, SISGEM.Resource1.CARGA_MASIVA_PROVEEDORES);
                System.Diagnostics.Process.Start(SF.FileName);
            }
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
