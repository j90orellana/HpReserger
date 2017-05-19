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
    public partial class frmcuentacontable : Form
    {
        public frmcuentacontable()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CcuentaContable = new HPResergerCapaLogica.HPResergerCL();
        public int tipobusca { get; set; }
        public int estado { get; set; }
        public string CuentaN1 { get; set; }
        public int CodCuenta { get; set; }
        public string DesCuentea { get; set; }
        public int TipoCuenta { get; set; }
        public string NatuCuenta { get; set; }
        public int CuentaGene { get; set; }
        public int GrupoCuenta { get; set; }
        public string Refleja { get; set; }
        public string Reflejacc { get; set; }
        public int ReflejaD { get; set; }
        public int ReflejaH { get; set; }
        public int CuentaCierre { get; set; }
        public string Analitica { get; set; }
        public int AjusteCambioMensual { get; set; }
        public int Cierre { get; set; }
        public int AjusteTraslacion { get; set; }
        public string CuentaBC { get; set; }
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
            dtgconten.DataSource = CcuentaContable.ListarCuentasContables(busca, opcion);
        }
        public void Cargartipocuenta()
        {
            cbotipo.DataSource = CcuentaContable.getCargoTipoContratacion("Id_CtaCtble_Tipo", "CtaCtble_Tipo", "TBL_Cuenta_Contable_Tipo");
            cbotipo.DisplayMember = "DESCRIPCION";
            cbotipo.ValueMember = "CODIGO";
        }
        public void CargartipoGenerica()
        {
            cbogenerica.DataSource = CcuentaContable.getCargoTipoContratacion("Id_CtaCtble_Generica", "CtaCtble_Generica", "TBL_Cuenta_Contable_Generica");
            cbogenerica.DisplayMember = "DESCRIPCION";
            cbogenerica.ValueMember = "CODIGO";
        }
        public void CargartipoGrupo()
        {
            cbogrupo.DataSource = CcuentaContable.getCargoTipoContratacion("Id_CtaCtble_Grupo", "CtaCtble_Grupo", "TBL_Cuenta_Contable_Grupo");
            cbogrupo.DisplayMember = "DESCRIPCION";
            cbogrupo.ValueMember = "CODIGO";
        }
        public void CargarPorPalabra(ComboBox combito, string palabra)
        {

            combito.DataSource = CcuentaContable.getCargoTipoContratacion3("Id_CtaCtble_Ajuste", "CtaCtble_Tipo_Ajuste", "CtaCtble_Ajuste", "TBL_Cuenta_Contable_Ajuste", palabra);
            combito.DisplayMember = "DESCRIPCION";
            combito.ValueMember = "CODIGO";
        }
        public void CargarPorDebeHaber(ComboBox combito, string palabra)
        {

            combito.DataSource = CcuentaContable.getCargoTipoContratacion3("Nro_CtaCtble_ReflejaDH", "CtaCtble_Naturaleza", "CtaCtble_ReflejaDH", "TBL_Cuenta_Contable_ReflejaDH", palabra);
            combito.DisplayMember = "DESCRIPCION";
            combito.ValueMember = "CODIGO";
        }
        private void frmcuentacontable_Load(object sender, EventArgs e)
        {
            estado = 0;
            tipobusca = 1;
            RellenarCombosSiNo(cborefleja);
            RellenarCombosSiNo(cboreflejacc);
            RellenarCombosSiNo(cboanalitica);
            RellenarCombosSiNo(cbocuentabc);
            RellenarCombosNaturaleza(cbonaturaleza);
            Cargartipocuenta();
            CargartipoGenerica();
            CargartipoGrupo();
            CargarPorPalabra(cbocierre, "Cierre");
            CargarPorPalabra(cboajustetraslacion, "Traslacion");
            CargarPorPalabra(cboajustemensual, "Cambio Mensual");
            CargarPorDebeHaber(cboreflejadebe, "D");
            CargarPorDebeHaber(cboreflejahaber, "H");            Txtbusca_TextChanged(sender,e);
            ListarCuentasContables(Txtbusca.Text, tipobusca);
            msg(dtgconten);
        }
        public void msg(DataGridView conteo)
        {
            lblmsg.Text = "Total Registros: " + conteo.RowCount;
        }
        public void Txtbusca_TextChanged(object sender, EventArgs e)
        {
            dtgconten.DataSource = CcuentaContable.ListarCuentasContables(Txtbusca.Text, tipobusca);
            msg(dtgconten);
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Txtbusca.Text = "";
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 1;
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
            try
            {
                int y = e.RowIndex;
                txtcuentan1.Text = dtgconten[1, y].Value.ToString();
                txtcodcuenta.Text = dtgconten[0, y].Value.ToString();
                txtnombrecuenta.Text = dtgconten[2, y].Value.ToString();
                cbotipo.Text = dtgconten[3, y].Value.ToString();
                cbonaturaleza.SelectedValue = dtgconten[4, y].Value.ToString();
                cbogenerica.Text = dtgconten[5, y].Value.ToString();
                cbogrupo.Text = dtgconten[6, y].Value.ToString();
                cborefleja.SelectedValue = dtgconten[7, y].Value.ToString();
                cboreflejacc.SelectedValue = dtgconten[8, y].Value.ToString();
                cboreflejadebe.Text = dtgconten[9, y].Value.ToString();
                cboreflejahaber.Text = dtgconten[10, y].Value.ToString();
                txtcuentacierre.Text = dtgconten[11, y].Value.ToString();
                cbocierre.Text = dtgconten[12, y].Value.ToString();
                cboanalitica.SelectedValue = dtgconten[13, y].Value.ToString();
                cboajustetraslacion.Text = dtgconten[14, y].Value.ToString();
                cboajustemensual.Text = dtgconten[15, y].Value.ToString();
                cbocuentabc.SelectedValue = dtgconten[16, y].Value.ToString();
            }
            catch { }
        }
        public void Activar()
        {
            btnlimpiar.Enabled = Txtbusca.Enabled = btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = true;
        }
        public void Desactivar()
        {
            btnlimpiar.Enabled = Txtbusca.Enabled = btnnuevo.Enabled = btneliminar.Enabled = btnmodificar.Enabled = dtgconten.Enabled = false;
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1; Desactivar();
            //LLamadaDeEntradaDeDatos
            tipmsg.Show("Ingrese Código de Cuenta", txtcodcuenta, 700);
            txtcodcuenta.Focus();
            //VaciarDatosDeCajas
            txtcuentan1.Text = "";
            txtcodcuenta.Text = "";
            txtnombrecuenta.Text = "";
            txtcuentacierre.Text = "";
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                this.Visible = false;
            }
            else
            {
                if (estado == 1)
                {
                    if (MessageBox.Show("Hay datos Ingresados, Desea Salir?", "HpReserger", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
                    ListarCuentasContables("", 1);
                    Txtbusca.Enabled = true;
                }
            }
        }
        public void DesactivarModi() { txtcuentan1.Enabled = txtcodcuenta.Enabled = txtcodcuenta.Enabled = txtnombrecuenta.Enabled = cbotipo.Enabled = cbonaturaleza.Enabled = false; }
        public void ActivarModi() { txtcuentan1.Enabled = txtcodcuenta.Enabled = txtcodcuenta.Enabled = txtnombrecuenta.Enabled = cbotipo.Enabled = cbonaturaleza.Enabled = true; }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2;
            tipmsg.Show("Seleccione Cuenta Genérica", cbogenerica, 700);
            Desactivar(); DesactivarModi();
            cbogenerica.Focus();
        }
        public Boolean VerificarDatos(int codigo, string nombre)
        {
            Boolean aux = true;
            if (!string.IsNullOrWhiteSpace(codigo.ToString()) && !string.IsNullOrWhiteSpace(nombre))
            {
                if (CcuentaContable.VerificarCuentas(codigo, nombre).Rows.Count > 0)
                {
                    MessageBox.Show("Ya Existe esta Cuenta: " + nombre + "; Código:" + codigo, "Hp Reserger", MessageBoxButtons.OK);
                    aux = false;
                }
            }
            else
            {
                aux = false;
                MessageBox.Show("Código de Cuenta y Descripción de la Cuenta, No pueden estar Vacios", "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
            CuentaN1 = txtcuentan1.Text;
            CodCuenta = Convert.ToInt32(txtcodcuenta.Text);
            DesCuentea = txtnombrecuenta.Text;
            TipoCuenta = Convert.ToInt32(cbotipo.SelectedValue);
            NatuCuenta = cbonaturaleza.SelectedValue.ToString();
            CuentaGene = Convert.ToInt32(cbogenerica.SelectedValue);
            GrupoCuenta = Convert.ToInt32(cbogrupo.SelectedValue);
            Refleja = cborefleja.SelectedValue.ToString();
            Reflejacc = cboreflejacc.SelectedValue.ToString();
            ReflejaD = Convert.ToInt32(Convert.ToInt32(cboreflejadebe.SelectedValue));
            ReflejaH = Convert.ToInt32(cboreflejahaber.SelectedValue);
            try
            {
                CuentaCierre = Convert.ToInt32(txtcuentacierre.Text);
            }
            catch { }
            Analitica = cboanalitica.SelectedValue.ToString();
            AjusteCambioMensual = Convert.ToInt32(cboajustemensual.SelectedValue);
            Cierre = Convert.ToInt32(Convert.ToInt32(cbocierre.SelectedValue));
            AjusteTraslacion = Convert.ToInt32(cboajustetraslacion.SelectedValue);
            CuentaBC = cbocuentabc.SelectedValue.ToString();
        }
        public void MensajedeDatos()
        {
            MessageBox.Show("ACCIÓN EXITOSA \n Cuenta N1= " + CuentaN1 + "\n Código Cuenta= " + CodCuenta + "\n Descripción Cuenta= " +
            DesCuentea + "\n Tipo de Cuenta= " + cbotipo.Text + "\n Naturaleza Cuenta=" + cbonaturaleza.Text + "\n Cuenta Genérica= " +
            cbogenerica.Text + "\n Grupo Cuenta= " + cbogrupo.Text + "\n Refleja= " + cborefleja.Text + "\n Refleja Depende CC " +
            cboreflejacc.Text + "\n Refleja Debe= " + cboreflejadebe.Text + "\n Refleja Haber= " + cboreflejahaber.Text + "\n Cuenta Cierra= " +
            CuentaCierre + "\n Analitica= " + cboanalitica.Text + "\n Ajuste CAmbio Mensual=" + cboajustemensual.Text + "\n Cierre= " +
            cbocierre.Text + "\n Ajuste Por Traslación= " + cboajustetraslacion.Text + "\n Cuenta Declarante BC= " + cbocuentabc.Text
            , "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones   
            int codigo;
            string nombrecuenta;
            nombrecuenta = txtnombrecuenta.Text;
            codigo = Convert.ToInt32(txtcodcuenta.Text);
            if (estado == 1 && VerificarDatos(codigo, nombrecuenta))
            {
                CargarValoresDeIngreso();
                //MensajedeDatos();
                MessageBox.Show("Se Insertó con Exito", "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CcuentaContable.InsertarCuentasContables(CuentaN1, CodCuenta, DesCuentea, TipoCuenta, NatuCuenta, CuentaGene, GrupoCuenta,
                Refleja, Reflejacc, ReflejaD, ReflejaH, CuentaCierre, Analitica, AjusteCambioMensual, Cierre, AjusteTraslacion, CuentaBC);
                PresentarValor(codigo.ToString());
            }
            else
            {
                if (estado == 2)
                {
                    CargarValoresDeIngreso();
                    //MensajedeDatos();
                    MessageBox.Show("Se Modificó con Exito", "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CcuentaContable.ActualizarCuentasContables(CodCuenta, CuentaGene, GrupoCuenta, Refleja, Reflejacc, ReflejaD, ReflejaH, CuentaCierre,
                        Analitica, AjusteCambioMensual, Cierre, AjusteTraslacion, CuentaBC);
                    PresentarValor(codigo.ToString());
                }
                else
                {
                    if (estado == 3)
                    {
                        if (MessageBox.Show("Seguró Desea Eliminar; " + txtnombrecuenta.Text + " Código Cuenta: " + txtcodcuenta.Text, "Hp Reserger", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes") ;
                        {
                            //CProveedor.EliminarProveedor(marcas, Convert.ToInt32(txtcodigo.Text.ToString()));                            
                            MessageBox.Show("Eliminado Exitosamente ", "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //                            PresentarValor("");

                        }
                    }
                }
            }
        }
        public void PresentarValor(string final)
        {
            estado = 0;
            dtgconten.DataSource = CcuentaContable.ListarCuentasContables(final, 1);
            Txtbusca.Text = final;
            Activar(); ActivarModi();
        }

        private void cbotipo_TextChanged(object sender, EventArgs e)
        {
            //cbotipo.SelectedIndex = index;
        }
    }

}
