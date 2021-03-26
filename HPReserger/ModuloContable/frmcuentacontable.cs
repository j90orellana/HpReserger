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
    public partial class frmcuentacontable : FormGradient
    {
        public frmcuentacontable()
        {
            InitializeComponent();
        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        //////////////////////
        private string _CodidoCuenta;
        public string CodigoCuenta
        {
            get { return _CodidoCuenta; }
            set { _CodidoCuenta = value; }
        }
        private Boolean _Consulta = false;
        public Boolean Consulta
        {
            get { return _Consulta; }
            set { _Consulta = value; }
        }
        private Boolean _Encontrado = false;
        public Boolean Encontrado
        {
            get { return _Encontrado; }
            set { _Encontrado = value; }
        }
        public int tipobusca { get; set; }
        public int estado { get; set; }
        public string CuentaN1 { get; set; }
        public string CodCuenta { get; set; }
        public string DesCuentea { get; set; }
        public string TipoCuenta { get; set; }
        public string NatuCuenta { get; set; }
        public string CuentaGene { get; set; }
        public string GrupoCuenta { get; set; }
        public string Refleja { get; set; }
        public string Reflejacc { get; set; }
        public string ReflejaD { get; set; }
        public string ReflejaH { get; set; }
        public string CuentaCierre { get; set; }
        public string Analitica { get; set; }
        public string AjusteCambioMensual { get; set; }
        public string Cierre { get; set; }
        public string AjusteTraslacion { get; set; }
        public string CuentaBC { get; set; }
        public string OldCodCuenta { get; private set; }

        public void RellenarCombosSiNo(ComboBox combito)
        {
            DataTable tablita = new DataTable();
            tablita.Columns.Add("CODIGO");
            tablita.Columns.Add("VALOR");
            tablita.Rows.Add(new object[] { "S", "SI" });
            tablita.Rows.Add(new object[] { "N", "NO" });
            combito.DataSource = tablita;
            combito.DisplayMember = "VALOR";
            combito.ValueMember = "CODIGO";
            combito.SelectedIndex = 1;
        }
        public void RellenarConActivo(ComboBox combito)
        {
            DataTable tablita = new DataTable();
            tablita.Columns.Add("CODIGO", typeof(int));
            tablita.Columns.Add("VALOR");
            tablita.Rows.Add(new object[] { 1, "Activa" });
            tablita.Rows.Add(new object[] { 0, "Inactiva" });
            combito.DataSource = tablita;
            combito.DisplayMember = "VALOR";
            combito.ValueMember = "CODIGO";
            combito.SelectedIndex = 1;
        }
        public void RellenarCombosSiNo10(ComboBox combito)
        {
            DataTable tablita = new DataTable();
            tablita.Columns.Add("CODIGO");
            tablita.Columns.Add("VALOR");
            tablita.Rows.Add(new object[] { "1", "SI" });
            tablita.Rows.Add(new object[] { "0", "NO" });
            combito.DataSource = tablita;
            combito.DisplayMember = "VALOR";
            combito.ValueMember = "CODIGO";
            combito.SelectedIndex = 0;
        }
        public void RellenarCombosNaturaleza(ComboBox combito)
        {
            DataTable tablita = new DataTable();
            tablita.Columns.Add("CODIGO");
            tablita.Columns.Add("VALOR");
            tablita.Rows.Add(new object[] { "D", "Debe" });
            tablita.Rows.Add(new object[] { "H", "Haber" });
            combito.DataSource = tablita;
            combito.DisplayMember = "VALOR";
            combito.ValueMember = "CODIGO";
            combito.SelectedIndex = 1;
        }
        public void ListarCuentasContables(string busca, int opcion)
        {
            dtgconten.DataSource = CapaLogica.ListarCuentasContables(busca, opcion);
        }
        public void Cargartipocuenta()
        {
            cbotipo.DataSource = CapaLogica.getCargoTipoContratacion("Id_CtaCtble_Tipo", "CtaCtble_Tipo", "TBL_Cuenta_Contable_Tipo");
            cbotipo.DisplayMember = "DESCRIPCION";
            cbotipo.ValueMember = "CODIGO";
        }
        public void CargartipoGenerica()
        {
            cbogenerica.DataSource = CapaLogica.getCargoTipoContratacion("Id_CtaCtble_Generica", "CtaCtble_Generica", "TBL_Cuenta_Contable_Generica");
            cbogenerica.DisplayMember = "DESCRIPCION";
            cbogenerica.ValueMember = "CODIGO";
        }
        public void CargartipoGrupo()
        {
            cbogrupo.DataSource = CapaLogica.getCargoTipoContratacion("Id_CtaCtble_Grupo", "CtaCtble_Grupo", "TBL_Cuenta_Contable_Grupo");
            cbogrupo.DisplayMember = "DESCRIPCION";
            cbogrupo.ValueMember = "CODIGO";
        }
        public void CargarPorPalabra(ComboBox combito, string palabra)
        {
            combito.DataSource = CapaLogica.getCargoTipoContratacion3("Id_CtaCtble_Ajuste", "CtaCtble_Tipo_Ajuste", "CtaCtble_Ajuste", "TBL_Cuenta_Contable_Ajuste", palabra);
            combito.DisplayMember = "DESCRIPCION";
            combito.ValueMember = "CODIGO";
        }
        public void CargarPorDebeHaber(ComboBox combito, string palabra)
        {
            combito.DataSource = CapaLogica.getCargoTipoContratacion3("Nro_CtaCtble_ReflejaDH", "CtaCtble_Naturaleza", "CtaCtble_ReflejaDH", "TBL_Cuenta_Contable_ReflejaDH", palabra);
            combito.DisplayMember = "DESCRIPCION";
            combito.ValueMember = "CODIGO";
        }
        public void ModoEdicion(Boolean a)
        {
            cbotipo.Enabled = cbonaturaleza.Enabled = chkInterEmpresa.Enabled
               = cbogenerica.Enabled = cbogrupo.Enabled = cboreflejacc.Enabled = cborefleja.Enabled = cbosolicitar.Enabled = chkcabecera.Enabled = cbocuentabc.Enabled =
          cboestado.Enabled = cboreflejadebe.Enabled = cboreflejahaber.Enabled = cboanalitica.Enabled = cboajustemensual.Enabled = cboajustetraslacion.Enabled = cbocierre.Enabled = a;
            txtcuentacierre.ReadOnly = txtcuentan1.ReadOnly = txtnombrecuenta.ReadOnly = txtcodcuenta.ReadOnly = !a;
        }
        private void frmcuentacontable_Load(object sender, EventArgs e)
        {
            estado = 0;
            tipobusca = 4;
            RellenarCombosSiNo(cborefleja);
            RellenarConActivo(cboestado);
            RellenarCombosSiNo(cboreflejacc);
            RellenarCombosSiNo(cboanalitica);
            RellenarCombosSiNo(cbocuentabc);
            RellenarCombosSiNo10(cbosolicitar);
            RellenarCombosNaturaleza(cbonaturaleza);
            Cargartipocuenta();
            CargartipoGenerica();
            CargartipoGrupo();
            CargarPorPalabra(cbocierre, "Cierre");
            CargarPorPalabra(cboajustetraslacion, "Traslacion");
            CargarPorPalabra(cboajustemensual, "Cambio Mensual");
            CargarPorDebeHaber(cboreflejadebe, "D");
            CargarPorDebeHaber(cboreflejahaber, "H");
            Txtbusca_TextChanged(sender, e);
            ListarCuentasContables(Txtbusca.EstaLLeno() ? Txtbusca.Text : "", tipobusca);
            msg(dtgconten);
            ModoEdicion(false);
        }
        public void msg(DataGridView conteo)
        {
            lblmsg.Text = "Total Registros: " + conteo.RowCount;
        }
        public void Txtbusca_TextChanged(object sender, EventArgs e)
        {
            if (Configuraciones.ValidarSQLInyect(Txtbusca.txtbusca)) { msg("Codigo Malicioso Detectado"); return; }
            dtgconten.DataSource = CapaLogica.ListarCuentasContables(Txtbusca.TextoValido(), tipobusca);
            msg(dtgconten);
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Txtbusca.Text = "";
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 4;
            Txtbusca_TextChanged(sender, e);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 2;
            Txtbusca_TextChanged(sender, e);
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 3;
            Txtbusca_TextChanged(sender, e);
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex;
            if (y >= 0)
            {
                txtcuentan1.Text = dtgconten[1, y].Value.ToString();
                txtcodcuenta.Text = dtgconten[0, y].Value.ToString();
                txtnombrecuenta.Text = dtgconten[2, y].Value.ToString();
                if (dtgconten[3, y].Value.ToString() == "")
                    cbotipo.SelectedIndex = -1;
                else
                    cbotipo.Text = dtgconten[3, y].Value.ToString();
                cbonaturaleza.SelectedValue = dtgconten[4, y].Value.ToString();
                if (dtgconten[5, y].Value.ToString() == "")
                    cbogenerica.SelectedValue = 0;
                else
                    cbogenerica.Text = dtgconten[5, y].Value.ToString();
                if (dtgconten[6, y].Value.ToString() == "")
                    cbogrupo.SelectedValue = 0;
                else
                    cbogrupo.Text = dtgconten[6, y].Value.ToString();
                cborefleja.SelectedValue = dtgconten[7, y].Value.ToString();
                cboreflejacc.SelectedValue = dtgconten[8, y].Value.ToString();
                cboreflejadebe.Text = dtgconten[9, y].Value.ToString();
                cboreflejahaber.Text = dtgconten[10, y].Value.ToString();
                txtcuentacierre.Text = dtgconten[11, y].Value.ToString();
                cboanalitica.SelectedValue = dtgconten[13, y].Value.ToString();
                if (dtgconten[12, y].Value.ToString() == "")
                    cbocierre.SelectedIndex = -1;
                else
                    cbocierre.Text = dtgconten[12, y].Value.ToString();
                if (dtgconten[14, y].Value.ToString() == "")
                    cboajustetraslacion.SelectedIndex = -1;
                else
                    cboajustetraslacion.Text = dtgconten[14, y].Value.ToString();
                if (dtgconten[15, y].Value.ToString() == "")
                    cboajustemensual.SelectedIndex = -1;
                else
                    cboajustemensual.Text = dtgconten[15, y].Value.ToString();
                cboestado.SelectedValue = dtgconten["Estadocta", y].Value;

                cbocuentabc.SelectedValue = dtgconten[16, y].Value.ToString();
                cbosolicitar.SelectedValue = dtgconten[17, y].Value.ToString();
                chkcabecera.Checked = dtgconten["CtaDetalle", y].Value.ToString() == "1" ? false : true;
                chkInterEmpresa.Checked = dtgconten["interempresa", y].Value.ToString() == "0" ? false : true;
            }
        }
        public void Activar()
        {
            groupBox1.Enabled = true;
            Txtbusca.Enabled = btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = true;
        }
        public void Desactivar()
        {
            Txtbusca.Enabled = btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = false;
            groupBox1.Enabled = false;
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1; Desactivar();
            ModoEdicion(true);
            //LLamadaDeEntradaDeDatos
            tipmsg.Show("Ingrese Código de Cuenta", txtcodcuenta, 700);
            txtcodcuenta.Focus();
            //VaciarDatosDeCajas           
            txtcodcuenta.CargarTextoporDefecto();
            //txtnombrecuenta.Text = "";
            //txtcuentacierre.Text = "";
            //cborefleja_SelectedIndexChanged(sender, e);
        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        private void btncancelar_Click(object sender, EventArgs e)
        {
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
                        ListarCuentasContables("", 1);
                        Txtbusca.Enabled = true;
                    }
                }
                else
                {
                    estado = 0;
                    Activar(); ActivarModi();
                    CodCuenta = txtcodcuenta.Text;
                    ListarCuentasContables("", 1);
                    Txtbusca.Enabled = true;
                    PosicionandoseEnElModificado();
                }
            }
            ModoEdicion(false);
        }
        public void DesactivarModi()
        {
            //txtcuentan1.Enabled = txtcodcuenta.Enabled = false; //txtnombrecuenta.Enabled = cbotipo.Enabled = cbonaturaleza.Enabled =
            txtcuentan1.ReadOnly = txtcodcuenta.ReadOnly = true;
        }
        public void ActivarModi()
        {
            txtcuentan1.Enabled = txtcodcuenta.Enabled = true; //txtnombrecuenta.Enabled = cbotipo.Enabled = cbonaturaleza.Enabled = true;
            txtcuentan1.ReadOnly = txtcodcuenta.ReadOnly = false;
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            OldCodCuenta = null;
            estado = 2;
            ModoEdicion(true);
            tipmsg.Show("Seleccione Cuenta Genérica", cbogenerica, 700);
            Desactivar(); DesactivarModi();
            cbogenerica.Focus();
            cbonaturaleza.Enabled = true;
            cborefleja_SelectedIndexChanged(sender, e);
            ////Busco si la Cuenta Tiene Asientos;
            DataRow Fila = CapaLogica.CuentaContable_EnUso(1, txtcodcuenta.Text);
            if (Fila == null)
            {
                txtcodcuenta.ReadOnly = false;
                txtcuentan1.ReadOnly = false;
            }
            else { msg("La Cuenta ya Tiene Asientos \nNo se Puede Modificar el Código"); }
            OldCodCuenta = txtcodcuenta.Text;
        }
        public Boolean VerificarDatos(string codigo, string nombre)
        {
            Boolean aux = true;
            if (!string.IsNullOrWhiteSpace(codigo.ToString()) && !string.IsNullOrWhiteSpace(nombre))
            {
                if (CapaLogica.VerificarCuentas(codigo, nombre).Rows.Count > 0)
                {
                    msg("Ya Existe esta Cuenta:\n" + nombre + "; Código:" + codigo);
                    aux = false;
                }
            }
            else
            {
                aux = false;
                msg("Código de Cuenta y Descripción de la Cuenta \nNo pueden estar Vacios");
            }
            return aux;
        }
        private void txtcodcuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {

            }
            else { e.Handled = true; }
        }
        public void CargarValoresDeIngreso()
        {
            CuentaN1 = txtcuentan1.TextValido();
            CodCuenta = (txtcodcuenta.TextValido()).Trim();
            DesCuentea = txtnombrecuenta.TextValido();
            if (cbotipo.Text != "")
                TipoCuenta = cbotipo.SelectedValue.ToString();
            else TipoCuenta = null;
            if (cbonaturaleza.Text != "")
                NatuCuenta = (cbonaturaleza.SelectedValue).ToString();
            else
                NatuCuenta = null;
            if (cbogenerica.Text != "")
                CuentaGene = cbogenerica.SelectedValue.ToString();
            else CuentaGene = "";
            if (cbogrupo.Text != "")
                GrupoCuenta = cbogrupo.SelectedValue.ToString();
            else GrupoCuenta = "";
            if (cborefleja.Text != "")
                Refleja = cborefleja.SelectedValue.ToString();
            else Refleja = ""; ;
            if (cboreflejacc.Text != "")
                Reflejacc = cboreflejacc.SelectedValue.ToString();
            else Reflejacc = "";
            if (cboreflejadebe.Text != "")
                ReflejaD = cboreflejadebe.SelectedValue.ToString();
            else ReflejaD = "";
            if (cboreflejahaber.Text != "")
                ReflejaH = cboreflejahaber.SelectedValue.ToString();
            else ReflejaH = "";

            if (string.IsNullOrWhiteSpace(txtcuentacierre.Text))
                CuentaCierre = "";
            else CuentaCierre = txtcuentacierre.Text;

            if (cboanalitica.Text != "")
                Analitica = cboanalitica.SelectedValue.ToString();
            else Analitica = "";
            if (cboajustemensual.Text != "")
                AjusteCambioMensual = cboajustemensual.SelectedValue.ToString();
            else AjusteCambioMensual = "";
            if (cbocierre.Text != "")
                Cierre = cbocierre.SelectedValue.ToString();
            else Cierre = "";
            if (cboajustetraslacion.Text != "")
                AjusteTraslacion = cboajustetraslacion.SelectedValue.ToString();
            else AjusteTraslacion = "";
            if (cbocuentabc.Text != "")
                CuentaBC = cbocuentabc.SelectedValue.ToString();
            else CuentaBC = "";
        }
        public void ActualizarReflejo()
        {
            CapaLogica.CreaciondeCuentasReflejo(txtcodcuenta.Text);
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones   0.1423
            string codigo;
            string nombrecuenta;
            nombrecuenta = txtnombrecuenta.TextValido();
            codigo = txtcodcuenta.TextValido();
            /////validamos datos Vacios
            if (!txtcodcuenta.EstaLLeno()) { msg("Ingrese Número de la Cuenta "); txtcodcuenta.Focus(); return; }
            if (!txtcodcuenta.EstaLLeno()) { msg("Ingrese Número de Cuenta "); txtcodcuenta.Focus(); return; }
            if (!txtcuentan1.EstaLLeno()) { msg("Ingrese Nombre de la Cuenta N1 "); txtcuentan1.Focus(); return; }
            ///fin de la validacion
            if (estado == 1 && VerificarDatos(codigo, nombrecuenta))
            {
                CargarValoresDeIngreso();
                //MensajedeDatos();
                msgOK("Se Insertó con Exito");
                //usp_insertar_cuentas_contables
                CapaLogica.InsertarCuentasContables(CuentaN1, CodCuenta, DesCuentea, TipoCuenta, NatuCuenta, CuentaGene, GrupoCuenta,
                Refleja, Reflejacc, ReflejaD, ReflejaH, CuentaCierre, Analitica, AjusteCambioMensual, Cierre, AjusteTraslacion, CuentaBC, int.Parse(cbosolicitar.SelectedValue.ToString()), chkcabecera.Checked ? 0 : 1
                , (int)cboestado.SelectedValue, chkInterEmpresa.Checked ? 1 : 0);
                ActualizarReflejo();
                PresentarValor(codigo.ToString());
            }
            else
            {
                if (estado == 2)
                {
                    CargarValoresDeIngreso();
                    if (OldCodCuenta != OldCodCuenta) { if (VerificarDatos(codigo, nombrecuenta)) return; }
                    //MensajedeDatos();
                    msgOK("Se Modificó con Exito");
                    //usp_actualizar_cuentas_contables
                    CapaLogica.ActualizarCuentasContables(OldCodCuenta, CodCuenta, CuentaN1, DesCuentea, TipoCuenta, CuentaGene, GrupoCuenta, Refleja, Reflejacc, ReflejaD, ReflejaH, CuentaCierre,
                        Analitica, AjusteCambioMensual, Cierre, AjusteTraslacion, CuentaBC, NatuCuenta, int.Parse(cbosolicitar.SelectedValue.ToString()), chkcabecera.Checked ? 0 : 1, (int)cboestado.SelectedValue, chkInterEmpresa.Checked ? 1 : 0);
                    ActualizarReflejo();
                    PresentarValor(codigo.ToString());
                }
                else
                {
                    if (estado == 3)
                    {
                        if (msgp("Seguró Desea Eliminar; " + txtnombrecuenta.Text + " Código Cuenta: " + txtcodcuenta.Text) == DialogResult.Yes)
                        {
                            //CProveedor.EliminarProveedor(marcas, Convert.ToInt32(txtcodigo.Text.ToString()));                            
                            msgOK("Eliminado Exitosamente");
                            //                            PresentarValor("");

                        }
                    }
                }
            }
            ////proceso para posicionarme en el ingresado-actualizado
            PosicionandoseEnElModificado();
            ////fin de la busqueda:
            ModoEdicion(false);
            if (Consulta) { Encontrado = true; this.Close(); }
        }
        public void PosicionandoseEnElModificado()
        {
            int Posfila = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if (item.Cells["CodCuenta"].Value.ToString() == CodCuenta)
                {
                    Posfila = item.Index;
                    break;
                }
            }
            if (Posfila != 0)
                dtgconten.CurrentCell = dtgconten["codcuenta", Posfila];
        }
        public void PresentarValor(string final)
        {
            estado = 0;
            dtgconten.DataSource = CapaLogica.ListarCuentasContables("", 0);
            //Txtbusca.Text = final;
            Activar(); ActivarModi();
        }
        private void cbotipo_TextChanged(object sender, EventArgs e)
        {
            //cbotipo.SelectedIndex = index;
        }
        private void btncargarcuentas_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "Archivo de Excel|*.xls;*.xlsx";
            if (DialogResult.OK == OpenFileDialog.ShowDialog())
            {
                if (OpenFileDialog.FileName != null)
                {
                    frmCargadeDatosExcel frmcargaexcel = new frmCargadeDatosExcel();
                    frmcargaexcel.ruta = OpenFileDialog.FileName;
                    frmcargaexcel.txtRuta.Text = frmcargaexcel.ruta;
                    frmcargaexcel.Show();
                }
                else
                {
                    msg("No ha Seleccionado un Archivo");
                }
            }
            else msg("No ha Seleccionado un Archivo");
        }
        private void dtgconten_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Consulta) { Encontrado = true; this.Close(); }
        }
        private void txtcodcuenta_TextChanged(object sender, EventArgs e)
        {
            CodigoCuenta = txtcodcuenta.Text;
        }
        private void Txtbusca_Load(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void cborefleja_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (estado == 1 || estado == 2)
                if (cborefleja.Text == "SI")
                {
                    cboreflejadebe.Enabled = cboreflejahaber.Enabled = txtcuentacierre.Enabled = false;
                    cboreflejadebe.Text = cboreflejahaber.Text = txtcuentacierre.Text = "";
                }
                else
                {
                    cboreflejadebe.Enabled = cboreflejahaber.Enabled = txtcuentacierre.Enabled = true;
                }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            //DialogResult Result;
            DataRow Fila = CapaLogica.CuentaContable_EnUso(1, txtcodcuenta.Text);
            int PosFila = dtgconten.CurrentRow.Index;
            if (Fila != null)
            {
                if (msgp("La Cuenta Ya tiene Asientos, ¿Desea Bloquear la Cuenta?") == DialogResult.Yes)
                {
                    CapaLogica.CuentaContable_EnUso(3, txtcodcuenta.Text);
                    msgOK("Cuenta contable Bloqueada");
                }
            }
            else
            {
                if (msgp("¿Seguro Desea Eliminar la Cuenta?") == DialogResult.Yes)
                {
                    CapaLogica.CuentaContable_EnUso(33, txtcodcuenta.Text);
                    msgOK("Cuenta contable Eliminada");
                }
            }
            ///listado de Resultados
            ListarCuentasContables("", 0);
            if (dtgconten.Rows.Count > PosFila)
                dtgconten.CurrentCell = dtgconten["codcuenta", PosFila];

        }
        private void txtcuentacierre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void cbocierre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboreflejadebe_Click(object sender, EventArgs e)
        {
            string cadena = cboreflejadebe.Text;
            CargarPorDebeHaber(cboreflejadebe, "D");
            cboreflejadebe.Text = cadena;
        }

        private void cboreflejahaber_Click(object sender, EventArgs e)
        {
            string cadena = cboreflejahaber.Text;
            CargarPorDebeHaber(cboreflejahaber, "H");
            cboreflejahaber.Text = cadena;
        }
        frmProcesando frmproce;
        DataTable TableCuentas;
        string NombreArchivo = "";
        private void btnExportarPlan_Click(object sender, EventArgs e)
        {
            TableCuentas = CapaLogica.PlanContable();
            NombreArchivo = "";
            if (TableCuentas.Rows.Count > 0)
            {
                Cursor = Cursors.WaitCursor;
                frmproce = new HPReserger.frmProcesando();
                frmproce.Show();
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                msg("No hay Datos que Exportar");
            }
        }
        private void btnExportarPLan2Col_Click(object sender, EventArgs e)
        {
            TableCuentas = CapaLogica.PlanContable2Col();
            NombreArchivo = " a 2 Columnas";
            if (TableCuentas.Rows.Count > 0)
            {
                Cursor = Cursors.WaitCursor;
                frmproce = new HPReserger.frmProcesando();
                frmproce.Show();
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                msg("No hay Datos que Exportar");
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                _NombreHoja = "PLAN CONTABLE"; _Cabecera = "Plan Contable";
                _Columnas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }; _NColumna = "m";
                //
                List<HPResergerFunciones.Utilitarios.RangoCelda> Celdas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                Celdas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", "b1", _Cabecera.ToUpper(), 16, true, false, Back, Fore));
                //
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, dtgconten.ColumnHeadersDefaultCellStyle.Font, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                int PosInicialGrilla = 3;
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableCuentas, CeldaCabecera, CeldaDefault, NombreArchivo, _NombreHoja, Celdas, PosInicialGrilla, _Columnas, new int[] { }, new int[] { }, "");
            }
            else msg("No hay datos que Exportar");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmproce.Close();
            dtgconten.ResumeLayout();
        }

    }

}
