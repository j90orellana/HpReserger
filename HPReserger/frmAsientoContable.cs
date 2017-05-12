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
    public partial class frmAsientoContable : Form
    {
        public frmAsientoContable()
        {
            InitializeComponent();

        }
        public double totaldebe { get; set; }
        public double totalhaber { get; set; }
        HPResergerCapaLogica.HPResergerCL Casiento = new HPResergerCapaLogica.HPResergerCL();

        private void frmAsientoContable_Load(object sender, EventArgs e)
        {
            estado = 0;
            tipobusca = 1;
            RellenarEstado(cboestado);
            System.Globalization.CultureInfo.CreateSpecificCulture("es-ES");
            fechaini.Value = fecha.Value = DateTime.Today;
            fechafin.Value = DateTime.Today.AddDays(1);
            dtgbusca.DataSource = Casiento.ListarAsientosContables("", 1, DateTime.Today, DateTime.Today);
            if (dtgbusca.RowCount > 0) { activar(); }

            fecha.Value = DateTime.Now;
        }
        public void activar()
        {
            btnnuevo.Enabled = btnmodificar.Enabled = btneliminar.Enabled = dtgbusca.Enabled =
                Txtbusca.Enabled = groupBox1.Enabled = btnlimpiar.Enabled = true;
            btnmas.Enabled = cboestado.Enabled = btndina.Enabled = Dtgconten.Enabled = fecha.Enabled =
                txtdinamica.Enabled = false;

        }
        public void desactivar()
        {
            btnnuevo.Enabled = btnmodificar.Enabled = btneliminar.Enabled = dtgbusca.Enabled =
                Txtbusca.Enabled = groupBox1.Enabled = btnlimpiar.Enabled = false;
            btnmas.Enabled = cboestado.Enabled = btndina.Enabled = Dtgconten.Enabled = fecha.Enabled =
                txtdinamica.Enabled = true;

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            modifico = false;
            try
            {
                if (!llamado)
                {
                    dtgayuda.DataSource = Casiento.ListarDinamicas(coddinamica + "", 10);

                }
            }
            catch { }
        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            Sumatoria();
            if (Dtgconten.RowCount > 0)
            {
                Dtgconten.CurrentCell = Dtgconten[0, Dtgconten.RowCount - 1];
                if (Dtgconten[0, Dtgconten.CurrentCell.RowIndex].Value.ToString() != "" && Dtgconten[1, Dtgconten.CurrentCell.RowIndex].Value.ToString() != "")
                {
                    Dtgconten.Rows.Add();
                    Dtgconten[0, Dtgconten.RowCount - 1].Value = Dtgconten[1, Dtgconten.RowCount - 1].Value = "";
                    Dtgconten[2, Dtgconten.RowCount - 1].Value = Dtgconten[3, Dtgconten.RowCount - 1].Value = "0.00";
                    Dtgconten.CurrentCell = Dtgconten[0, Dtgconten.RowCount - 1];
                }
            }
            else
            {
                Dtgconten.Rows.Add();
                Dtgconten[0, 0].Value = Dtgconten[1, 0].Value = "";
                Dtgconten[2, Dtgconten.RowCount - 1].Value = Dtgconten[3, Dtgconten.RowCount - 1].Value = "0.00";
                Dtgconten.CurrentCell = Dtgconten[0, Dtgconten.RowCount - 1];
            }
            Dtgconten.Focus();
        }

        private void Dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // string cadenita = Dtgconten[0, e.RowIndex].Value.ToString();
                btnmas.Focus();
                if (e.RowIndex > -1 && e.ColumnIndex == 0)
                {
                    frmlistarcuentas cuentitas = new frmlistarcuentas();
                    if (Dtgconten[0, e.RowIndex].Value != null)
                    {
                        cuentitas.Txtbusca.Text = Dtgconten[0, e.RowIndex].Value.ToString();
                    }
                    else
                    { cuentitas.Txtbusca.Text = ""; }
                    cuentitas.radioButton1.Checked = true;
                    cuentitas.ShowDialog();
                    if (cuentitas.aceptar)
                    {
                        Dtgconten[0, e.RowIndex].Value = cuentitas.codigo;
                        btnmas.Focus();
                    }
                }
            }
            catch { }
        }
        public Boolean llamado = true;
        public int coddinamica { get; set; }
        private void txtdinamica_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                llamado = false;
                // string cadenita = Dtgconten[0, e.RowIndex].Value.ToString();
                btnmas.Focus();
                frmdinamicaContable dinamica = new frmdinamicaContable();
                dinamica.salida = false;
                dinamica.Txtbusca.Text = "";
                dinamica.ShowDialog();
                if (dinamica.aceptar)
                {
                    coddinamica = dinamica.codigo;
                    txtdinamica.Text = dinamica.txtcodigo.Text;
                    CargaDinamicas();
                    btnmas.Focus();
                }

            }
            catch { }
        }

        private void btndina_Click(object sender, EventArgs e)
        {
            try
            {
                llamado = false;
                // string cadenita = Dtgconten[0, e.RowIndex].Value.ToString();
                btnmas.Focus();
                frmdinamicaContable dinamica = new frmdinamicaContable();
                dinamica.salida = false;
                dinamica.Txtbusca.Text = "";
                dinamica.ShowDialog();
                if (dinamica.aceptar)
                {
                    coddinamica = dinamica.codigo;
                    txtdinamica.Text = dinamica.txtcodigo.Text;
                    CargaDinamicas();
                    btnmas.Focus();
                }
                else { coddinamica = 0; txtdinamica.Text = ""; }

            }
            catch { }

            if (coddinamica != 0)
            {

            }

        }
        public void Mensajes(string text)
        {
            MessageBox.Show(text, "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        private void txtdinamica_Leave(object sender, EventArgs e)
        {
            txtdinamica.Text = "CD_00" + coddinamica;
        }

        private void txtdinamica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back) { }
            else { e.Handled = true; }
        }
        public void CargaDinamicas()
        {
            if (dtgayuda.RowCount > 0)
            {
                Dtgconten.Rows.Clear();
                for (int i = 0; i < dtgayuda.RowCount; i++)
                {//6=CodigoCuenta 7=DescripcionCuenta 8=Debe/Haber //0=CodigoCuenta 1=Descripcion 2=debe 3=haber
                    Dtgconten.Rows.Add();
                    Dtgconten[0, i].Value = dtgayuda[6, i].Value;
                    Dtgconten[1, i].Value = dtgayuda[7, i].Value;
                    Dtgconten[2, i].Value = "0.00";
                    Dtgconten[3, i].Value = "0.00";
                }
                txttotaldebe.Text = txttotalhaber.Text = txtdiferencia.Text = "0.00";
                totaldebe = totalhaber = 0;
            }
        }
        private void txtdinamica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                coddinamica = Convert.ToInt32(txtdinamica.Text);
                dtgayuda.DataSource = Casiento.ListarDinamicas(coddinamica + "", 1);
                CargaDinamicas();
                btndina.Focus();
            }
        }

        private void dtgayuda_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgayuda_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgayuda_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void Dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex == 0)
                { //MODIFICAR LA COLUMNA DE CODIGOS
                    dtgayuda2.DataSource = Casiento.BuscarCuentas(Dtgconten[0, e.RowIndex].Value.ToString(), 1);
                    if (dtgayuda2.RowCount == 1)
                    {
                        Dtgconten[1, e.RowIndex].Value = dtgayuda2[0, 0].Value.ToString();
                        //Dtgconten[2, e.RowIndex].Value = dtgayuda2[1, 0].Value.ToString();
                        //aux = true;
                    }
                    else
                    {
                        Dtgconten[1, e.RowIndex].Value = "";
                        //aux = false;
                    }
                }

            }
            catch { }

        }

        private void Dtgconten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnmas_Click(sender, e);
            }
            else { e.Handled = true; }

        }
        private void Dtgconten_CellValidated(object sender, DataGridViewCellEventArgs e)
        {


        }
        int punto = 0, deci = 0;
        private void dataGridview_KeyPressCajita(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (Char)Keys.Back || e.KeyChar == '.' || e.KeyChar == ',')
            {
                //e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }

        }
        private void Dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            punto = deci = 0;

            if (Dtgconten.CurrentCell.ColumnIndex == 2 || Dtgconten.CurrentCell.ColumnIndex == 3)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(dataGridview_KeyPressCajita);
                    txt.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajita);
                }
            }
        }
        public void msg(DataGridView conteo)
        {
            lblmsg.Text = "Total Registros: " + conteo.RowCount;
        }
        public void msg2(DataGridView conteo)
        {
            lblmsg2.Text = "Total Registros: " + conteo.RowCount;
        }
        private void Dtgconten_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.ColumnIndex > 1)
                {
                    double aux = Convert.ToDouble(Dtgconten[e.ColumnIndex, e.RowIndex].Value.ToString());
                    Dtgconten[e.ColumnIndex, e.RowIndex].Value = string.Format("{0:N2}", aux);
                }
                if (Dtgconten.RowCount > 0)
                {
                    if (Dtgconten.RowCount == 1)
                    {
                        if (Dtgconten[2, 0].Value.ToString() == "")
                        {
                            totaldebe = 0.00; Dtgconten[2, 0].Value = "0.00";
                        }
                        else { totaldebe = Convert.ToDouble(Dtgconten[2, 0].Value.ToString()); }
                        if (Dtgconten[3, 0].Value.ToString() == "")
                        {
                            totalhaber = 0.00; Dtgconten[3, 0].Value = "0.00";
                        }
                        else
                        {
                            totaldebe = Convert.ToDouble(Dtgconten[2, 0].Value.ToString());
                        }

                        txttotaldebe.Text = string.Format("{0:N2}", totaldebe);
                        txttotalhaber.Text = string.Format("{0:N2}", totalhaber);
                    }
                    if (Dtgconten.RowCount > 1)
                    {
                        double aux1, aux2 = 0;
                        totaldebe = totalhaber = 0;
                        for (int i = 0; i < Dtgconten.RowCount; i++)
                        {
                            if (Dtgconten[2, i].Value.ToString() == "" || Dtgconten[2, i].Value.ToString() == null)
                            {
                                aux1 = 0.00; Dtgconten[2, i].Value = "0.00";
                            }
                            else { aux1 = Convert.ToDouble(Dtgconten[2, i].Value.ToString()); }
                            if (Dtgconten[3, i].Value.ToString() == "" || Dtgconten[3, i].Value.ToString() == null)
                            {
                                aux2 = 0.00; Dtgconten[3, i].Value = "0.00";
                            }
                            else
                            {
                                aux2 = Convert.ToDouble(Dtgconten[3, i].Value.ToString());
                            }
                            totaldebe += aux1;
                            totalhaber += aux2;
                            txtdiferencia.Text = string.Format("{0:N2}", totaldebe - totalhaber);
                            txttotaldebe.Text = string.Format("{0:N2}", totaldebe);
                            txttotalhaber.Text = string.Format("{0:N2}", totalhaber);
                        }
                    }
                    if (totaldebe > totalhaber)
                    {
                        txttotalhaber.ForeColor = Color.Red;
                    }
                    else txttotalhaber.ForeColor = Color.Green;
                    if (totalhaber > totaldebe)
                    {
                        txttotaldebe.ForeColor = Color.Red;
                    }
                    else txttotaldebe.ForeColor = Color.Green;
                    if (totalhaber == totaldebe)
                    {
                        txttotaldebe.ForeColor = Color.Black;
                        txttotalhaber.ForeColor = Color.Black;
                    }
                }
                else
                {
                    totaldebe = 0;
                    totalhaber = 0;
                    txttotaldebe.Text = totaldebe.ToString();
                    txttotalhaber.Text = totalhaber.ToString();
                }
            }
            catch
            {
            }

        }
        public void Sumatoria()
        {

            try
            {
                int e = Dtgconten.CurrentCell.RowIndex;
                int f = Dtgconten.CurrentCell.ColumnIndex;
                if (e > 1 && f > 1)
                {
                    double aux = Convert.ToDouble(Dtgconten[f, e].Value.ToString());
                    Dtgconten[f, e].Value = string.Format("{0:N2}", aux);
                }
                if (Dtgconten.RowCount > 0)
                {
                    if (Dtgconten.RowCount == 1)
                    {
                        if (Dtgconten[2, 0].Value.ToString() == "")
                        {
                            totaldebe = 0.00; Dtgconten[2, 0].Value = "0.00";
                        }
                        else { totaldebe = Convert.ToDouble(Dtgconten[2, 0].Value.ToString()); }
                        if (Dtgconten[3, 0].Value.ToString() == "")
                        {
                            totalhaber = 0.00; Dtgconten[3, 0].Value = "0.00";
                        }
                        else
                        {
                            totaldebe = Convert.ToDouble(Dtgconten[2, 0].Value.ToString());
                        }

                        txttotaldebe.Text = string.Format("{0:N2}", totaldebe);
                        txttotalhaber.Text = string.Format("{0:N2}", totalhaber);
                    }
                    if (Dtgconten.RowCount > 1)
                    {
                        double aux1, aux2 = 0;
                        totaldebe = totalhaber = 0;
                        for (int i = 0; i < Dtgconten.RowCount; i++)
                        {
                            if (Dtgconten[2, i].Value.ToString() == "" || Dtgconten[2, i].Value.ToString() == null)
                            {
                                aux1 = 0.00; Dtgconten[2, i].Value = "0.00";
                            }
                            else { aux1 = Convert.ToDouble(Dtgconten[2, i].Value.ToString()); }
                            if (Dtgconten[3, i].Value.ToString() == "" || Dtgconten[3, i].Value.ToString() == null)
                            {
                                aux2 = 0.00; Dtgconten[3, i].Value = "0.00";
                            }
                            else
                            {
                                aux2 = Convert.ToDouble(Dtgconten[3, i].Value.ToString());
                            }
                            totaldebe += aux1;
                            totalhaber += aux2;
                            txtdiferencia.Text = string.Format("{0:N2}", totaldebe - totalhaber);
                            txttotaldebe.Text = string.Format("{0:N2}", totaldebe);
                            txttotalhaber.Text = string.Format("{0:N2}", totalhaber);
                        }
                    }
                    if (totaldebe > totalhaber)
                    {
                        txttotalhaber.ForeColor = Color.Red;
                    }
                    else txttotalhaber.ForeColor = Color.Green;
                    if (totalhaber > totaldebe)
                    {
                        txttotaldebe.ForeColor = Color.Red;
                    }
                    else txttotaldebe.ForeColor = Color.Green;
                    if (totalhaber == totaldebe)
                    {
                        txttotaldebe.ForeColor = Color.Black;
                        txttotalhaber.ForeColor = Color.Black;
                    }
                }
                else
                {
                    totaldebe = 0;
                    totalhaber = 0;
                    txttotaldebe.Text = totaldebe.ToString();
                    txttotalhaber.Text = totalhaber.ToString();
                }
            }
            catch
            {
            }
        }
        private void lblmsg2_Click(object sender, EventArgs e)
        {

        }
        public int tipobusca = 0;
        private void Txtbusca_TextChanged(object sender, EventArgs e)
        {
            if (fechaini.Value < fechafin.Value)
            {
                dtgbusca.DataSource = Casiento.ListarAsientosContables(Txtbusca.Text, tipobusca, fechaini.Value, fechafin.Value.AddDays(1));
            }
            else { dtgbusca.DataSource = Casiento.ListarAsientosContables(Txtbusca.Text, tipobusca, fechafin.Value, fechaini.Value.AddDays(1)); }
            msg2(dtgbusca);

            if (dtgbusca.RowCount < 1)
            {
                Dtgconten.Rows.Clear();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Txtbusca.Text = "";
            Txtbusca_TextChanged(sender, e);
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
        private void fechaini_ValueChanged(object sender, EventArgs e)
        {

            Txtbusca_TextChanged(sender, e);
        }

        private void fechafin_ValueChanged(object sender, EventArgs e)
        {

            Txtbusca_TextChanged(sender, e);
        }
        public int dinamica { get; set; }
        public double activo, pasivo;
        private void dtgbusca_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dtgayuda3.DataSource = Casiento.BuscarAsientosContables(dtgbusca[0, e.RowIndex].Value.ToString(), 4);

                if (dtgayuda3.RowCount > 0)
                {
                    fecha.Value = Convert.ToDateTime(dtgayuda3[1, 0].Value);
                    txtcodigo.Text = dtgayuda3[0, 0].Value.ToString();
                    dinamica = Convert.ToInt32(dtgayuda3[7, 0].Value.ToString());
                    cboestado.SelectedValue = dtgayuda3[8, 0].Value;
                    txtdinamica.Text = "DC_00" + dinamica;
                    Dtgconten.Rows.Clear(); activo = pasivo = 0;
                    for (int i = 0; i < dtgayuda3.RowCount; i++)
                    {
                        Dtgconten.Rows.Add();
                        Dtgconten[0, i].Value = dtgayuda3[2, i].Value;
                        Dtgconten[2, i].Value = dtgayuda3[5, i].Value;
                        Dtgconten[3, i].Value = dtgayuda3[6, i].Value;
                        //sumas
                        activo += Convert.ToDouble(Dtgconten[2, i].Value);
                        pasivo += Convert.ToDouble(Dtgconten[3, i].Value);
                    }
                    txtdiferencia.Text = string.Format("{0:N2}", activo - pasivo);
                    txttotaldebe.Text = string.Format("{0:N2}", activo);
                    txttotalhaber.Text = string.Format("{0:N2}", pasivo);
                    if (activo > pasivo)
                    {
                        txttotalhaber.ForeColor = Color.Red;
                    }
                    else txttotalhaber.ForeColor = Color.Black;
                    if (pasivo > activo)
                    {
                        txttotaldebe.ForeColor = Color.Red;
                    }
                    else txttotaldebe.ForeColor = Color.Black;
                    if (pasivo == activo)
                    {
                        txttotaldebe.ForeColor = Color.Black;
                        txttotalhaber.ForeColor = Color.Black;
                    }
                }
            }
            catch { }
        }
        private void dtgbusca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtgbusca_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtgbusca_CellValidated(object sender, DataGridViewCellEventArgs e)
        {


        }

        public void RellenarEstado(ComboBox combito)
        {
            DataTable tablita = new DataTable();
            tablita.Columns.Add("CODIGO");
            tablita.Columns.Add("VALOR");
            tablita.Rows.Add(new object[] { "1", "Activo" });
            tablita.Rows.Add(new object[] { "0", "Inactivo" });
            combito.DataSource = tablita;
            combito.DisplayMember = "VALOR";
            combito.ValueMember = "CODIGO";

        }
        private void cboestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public int estado { get; set; }
        public int codigo;
        public void ultimoasiento()
        {
            DataTable tablita = new DataTable();
            tablita = Casiento.UltimoAsiento();
            DataRow filas = tablita.Rows[0];
            if (filas.ItemArray[0] != DBNull.Value)
            {
                codigo = Convert.ToInt32(filas.ItemArray[0]);
                codigo++;
            }
            else { codigo = 0; }
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            desactivar();
            Dtgconten.Rows.Clear();
            ultimoasiento();
            txtdinamica.Text = "";
            txtcodigo.Text = codigo + "";
            txttotaldebe.Text = txttotalhaber.Text = txtdiferencia.Text = "";
            fecha.Value = DateTime.Now;
        }
        public Boolean modifico;
        public int dinamimodi;
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2;
            dinamimodi = Convert.ToInt16(dtgayuda3[8, 0].Value.ToString());
            modifico = true;
            desactivar();
            btnmas.Focus();
        }
        public int pos;
        public void validar()
        {
            salida = true;
            try
            {
                if (Dtgconten[1, Dtgconten.RowCount - 1].Value.ToString() == "")
                {
                    Dtgconten.Rows.RemoveAt(Dtgconten.RowCount - 1);
                }
                for (pos = 0; pos < Dtgconten.RowCount; pos++)
                {
                    if (Dtgconten[1, pos].Value.ToString() == "")
                    {
                        Mensajes("La Cuenta de la linea:" + (pos + 1) + " Es Incorrecto");
                        salida = false;
                        break;
                    }
                    if (Convert.ToDouble(Dtgconten[2, pos].Value.ToString()) >= 0)
                    { }
                    else
                    {
                        Mensajes("El valor Del Debe:" + (pos + 1) + " Es Incorrecto");
                        salida = false;
                        break;
                    }
                    if (Convert.ToDouble(Dtgconten[3, pos].Value.ToString()) >= 0)
                    { }
                    else
                    {
                        Mensajes("El valor del Haber:" + (pos + 1) + " Es Incorrecto");
                        salida = false;
                        break;
                    }
                    if (Convert.ToDouble(Dtgconten[2, pos].Value.ToString()) == Convert.ToDouble(Dtgconten[3, pos].Value.ToString()))
                    {
                        Mensajes("El DEBE y HABER son iguales en la Linea: " + (pos + 1));
                        salida = false;
                        break;
                    }
                }

                if (totaldebe != totalhaber && salida)
                {
                    salida = false;
                    Mensajes("No debe haber diferencia entre el debe y haber.");
                }
                if (totaldebe == 0 || totalhaber == 0 && salida)
                {
                    salida = false;
                    Mensajes("El Debe y el Haber estan en cero");
                }
            }
            catch (FormatException) { Mensajes("Hay Números Mal Ingresados, en la fila:" + (pos + 1)); salida = false; }
            catch
            {
                salida = false;
            }

        }
        public Boolean salida { get; set; }
        public Boolean aceptar { get; set; }
        public int ESTADO { get; set; }
        public DateTime FECHA { get; set; }
        public int DINAMICA { get; set; }

        public void CArgarValoresIngreso()
        {
            ESTADO = Convert.ToInt32(cboestado.SelectedValue.ToString());
            FECHA = fecha.Value;
            DINAMICA = coddinamica;
        }
        public void MostrarValores(string cadena, int codigo)
        {
            MessageBox.Show("DATOS:\nEstado: " + cboestado.Text + "\tCodigo: " + codigo
                + "\nFecha: " + FECHA + "\nDinamica: " + coddinamica + "\nASIENTO CONTABLE\n" + cadena +
                "Total Debe: " + totaldebe + "\tTotal Haber: " + totalhaber
                , "Hp Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public string Detalle()
        {
            string cadena = "";
            for (int i = 0; i < Dtgconten.RowCount; i++)
            {
                cadena += "Codigo:" + Dtgconten[0, i].Value + " Cuenta:" + Dtgconten[1, i].Value + " Debe:" + Dtgconten[2, i].Value +
                    " Haber:" + Dtgconten[3, i].Value + "\n";
            }
            return cadena;
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            btnmas_Click(sender, e);
            validar();
            aceptar = true;
            if (salida)
            {
                //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones  
                if (estado == 1 && Dtgconten.RowCount > 1)
                {
                    string cadena = "";
                    CArgarValoresIngreso();
                    MostrarValores(cadena + Detalle(), codigo);
                    for (int i = 0; i < Dtgconten.RowCount; i++)
                    {
                        Casiento.InsertarAsiento(codigo, FECHA, Convert.ToInt32(Dtgconten[0, i].Value.ToString()), Convert.ToDouble(Dtgconten[2, i].Value.ToString()), Convert.ToDouble(Dtgconten[3, i].Value.ToString()), DINAMICA, ESTADO);

                    }

                    Txtbusca.Text = codigo + "";
                    dtgbusca.DataSource = Casiento.BuscarAsientosContables(Txtbusca.Text, 1);
                    activar(); estado = 0;
                }
                else
                {
                    if (estado == 2 && Dtgconten.RowCount > 1)
                    {
                        string cadena = "";
                        codigo = Convert.ToInt32(txtcodigo.Text.ToString());
                        CArgarValoresIngreso();
                        MostrarValores(cadena + Detalle(), codigo);
                        Casiento.Modificar2asiento(codigo);
                        //Mensajes("Codigo:" + codigo + " Filas;" + Dtgconten.RowCount);
                        for (int i = 0; i < Dtgconten.RowCount; i++)
                        {
                            if (modifico) { 
                            Casiento.InsertarAsiento(codigo, FECHA, Convert.ToInt32(Dtgconten[0, i].Value.ToString()), Convert.ToDouble(Dtgconten[2, i].Value.ToString()), Convert.ToDouble(Dtgconten[3, i].Value.ToString()), DINAMICA, ESTADO);
                            }else {
                                Casiento.InsertarAsiento(codigo, FECHA, Convert.ToInt32(Dtgconten[0, i].Value.ToString()), Convert.ToDouble(Dtgconten[2, i].Value.ToString()), Convert.ToDouble(Dtgconten[3, i].Value.ToString()), dinamimodi, ESTADO);
                            }
                        }

                        estado = 0;
                        Txtbusca.Text = codigo + "";
                        dtgbusca.DataSource = Casiento.BuscarAsientosContables(Txtbusca.Text, 1);
                        activar();
                    }
                    else
                    {
                        if (estado == 3)
                        {
                            codigo = Convert.ToInt32(txtcodigo.Text.ToString());
                            if (MessageBox.Show("Seguró Desea Eliminar; Asiento Contable" + codigo, "Hp Reserger", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                Casiento.EliminarAsiento(codigo);
                                MessageBox.Show("Eliminado Exitosamente ", "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Txtbusca.Text = "";
                                dtgbusca.DataSource = Casiento.BuscarAsientosContables(Txtbusca.Text, 1);

                            }
                        }
                    }
                }
            }
            else { }

        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            aceptar = false;
            if (estado == 0)
            {
                this.Close();
            }
            else
            {
                if (estado == 1 && Dtgconten.RowCount > 0)
                {
                    if (MessageBox.Show("Hay datos Ingresados, Desea Salir?", "HpReserger", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        estado = 0;
                        activar();
                        dtgbusca.DataSource = Casiento.BuscarAsientosContables(Txtbusca.Text, 1);
                        Txtbusca.Enabled = false;
                        dtgbusca.Focus();
                    }
                    else { }
                }
                else
                {
                    if (estado == 2 && Dtgconten.RowCount > 0)
                    {
                        if (MessageBox.Show("Hay datos Ingresados, Desea Salir?", "HpReserger", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            estado = 0;
                            activar();
                            dtgbusca.DataSource = Casiento.BuscarAsientosContables(Txtbusca.Text, 1);
                            Txtbusca.Enabled = true;
                            dtgbusca.Focus();
                        }
                        else { Dtgconten.BeginEdit(true); }
                    }
                    else
                    {
                        estado = 0;
                        activar();
                        dtgbusca.DataSource = Casiento.BuscarAsientosContables(Txtbusca.Text, 1);
                        Txtbusca.Enabled = true;
                        dtgbusca.Focus();
                    }
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            btnaceptar_Click(sender, e);
        }

        private void Dtgconten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Desea Borrar esta fila", "Hp Reserger", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Dtgconten.Rows.RemoveAt(Dtgconten.CurrentCell.RowIndex);
                    Sumatoria();
                }
                else { e.Handled = true; msg(Dtgconten); }
            }
        }

        private void txtdinamica_Click(object sender, EventArgs e)
        {
            txtdinamica.SelectAll();
        }

        private void dtgayuda3_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            Dtgconten_CellEndEdit(sender, e);
        }

        private void Dtgconten_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            msg(Dtgconten);
        }
    }
}
