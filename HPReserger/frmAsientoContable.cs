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
    public partial class frmAsientoContable : Form
    {
        public frmAsientoContable()
        {
            InitializeComponent();
        }
        public decimal totaldebe { get; set; }
        public decimal totalhaber { get; set; }
        int fechacheck = 0;
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmAsientoContable_Load(object sender, EventArgs e)
        {
            estado = 0; fechacheck = 0;
            tipobusca = 1;
            RellenarEstado(cboestado);
            System.Globalization.CultureInfo.CreateSpecificCulture("es-ES");
            cARgarEmpresas();
            DateTime fechita;
            if (chkfechavalor.Checked) fechita = dtfechavalor.Value; else fechita = fecha.Value;
            Dtgconten.DataSource = CapaLogica.BuscarAsientosContablesconTodo("0", 4, 1, fechita);
            dtgbusca.DataSource = CapaLogica.ListarAsientosContables("", 1, DateTime.Today, DateTime.Today, 0, _idempresa);
            if (dtgbusca.RowCount > 0)
            {
                activar();
                // dtgbusca.CurrentCell = dtgbusca[0, 0];
                dtgbusca_RowEnter(sender, new DataGridViewCellEventArgs(0, 0));
            }
            if (fecha.Value == null)
            {
                fechaini.Value = fecha.Value = DateTime.Today;
                fechafin.Value = DateTime.Today.AddDays(1);
            }
        }
        public void cARgarEmpresas()
        {
            cboempresa.DisplayMember = "descripcion";
            cboempresa.ValueMember = "codigo";
            cboempresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_Empresa", "Empresa", "TBL_Empresa");
        }
        public void activar()
        {
            btnnuevo.Enabled = btnmodificar.Enabled = btneliminar.Enabled = dtgbusca.Enabled =
                Txtbusca.Enabled = groupBox1.Enabled = btnreversa.Enabled = true;
            btnmas.Enabled = cboestado.Enabled = btndina.Enabled = dtfechavalor.Enabled = chkfechavalor.Enabled = cboproyecto.Enabled = cboetapa.Enabled =
                txtdinamica.Enabled = false;
            foreach (DataGridViewColumn col in Dtgconten.Columns)
                col.ReadOnly = true;
        }
        public void desactivar()
        {
            btnnuevo.Enabled = btnmodificar.Enabled = btneliminar.Enabled = dtgbusca.Enabled = chkfechavalor.Enabled = btnreversa.Enabled =
                Txtbusca.Enabled = groupBox1.Enabled = false;
            btnmas.Enabled = cboestado.Enabled = btndina.Enabled = dtfechavalor.Enabled = chkfechavalor.Enabled = cboproyecto.Enabled = cboetapa.Enabled =
                txtdinamica.Enabled = true;
            foreach (DataGridViewColumn col in Dtgconten.Columns)
                if (col.Name != descripcion.Name)
                    col.ReadOnly = false;
        }
        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            modifico = true;
            try
            {
                if (!llamado)
                {
                    dtgayuda.DataSource = CapaLogica.ListarDinamicas(coddinamica + "", 10);
                }
            }
            catch { }
        }
        int Con = 0;
        private void btnmas_Click(object sender, EventArgs e)
        {
            txttotalhaber.Text = txttotaldebe.Text = "0.00";
            if (Dtgconten.RowCount > 0)
            {
                Dtgconten.CurrentCell = Dtgconten[cuenta.Name, Dtgconten.RowCount - 1];
                if (Dtgconten[cuenta.Name, Dtgconten.CurrentCell.RowIndex].Value.ToString() != "" && Dtgconten[descripcion.Name, Dtgconten.CurrentCell.RowIndex].Value.ToString() != "")
                {
                    //Con = Dtgconten.RowCount + 1;
                    int f = 1;
                    foreach (DataGridViewRow item in Dtgconten.Rows)
                    {
                        if (item.Cells[EstadoCuen.Name].Value != null)
                        {
                            if (item.Cells[EstadoCuen.Name].Value.ToString() != "3") f++;
                        }
                        else f++;
                    }
                    ((DataTable)Dtgconten.DataSource).Rows.InsertAt(((DataTable)Dtgconten.DataSource).NewRow(), f - 1);
                    //Dtgconten.Rows.Insert(f - 1, 1);
                    Dtgconten[IDASIENTOX.Name, f - 1].Value = f;
                    Dtgconten[cuenta.Name, f - 1].Value = Dtgconten[cuenta.Name, f - 1].Value = "";
                    Dtgconten[debe.Name, f - 1].Value = Dtgconten[haber.Name, f - 1].Value = "0.00";
                    Dtgconten[EstadoCuen.Name, f - 1].Value = 1;
                    Dtgconten.CurrentCell = Dtgconten[cuenta.Name, f - 1];
                }
            }
            else
            {
                Con = Dtgconten.RowCount + 1;
                ((DataTable)Dtgconten.DataSource).Rows.Add();
                //          Dtgconten.Rows.Add();
                Dtgconten[IDASIENTOX.Name, 0].Value = Con;
                Dtgconten[cuenta.Name, 0].Value = Dtgconten[descripcion.Name, 0].Value = "";
                Dtgconten[EstadoCuen.Name, Dtgconten.RowCount - 1].Value = 1;
                Dtgconten[debe.Name, Dtgconten.RowCount - 1].Value = Dtgconten[haber.Name, Dtgconten.RowCount - 1].Value = "0.00";
                Dtgconten.CurrentCell = Dtgconten[cuenta.Name, Dtgconten.RowCount - 1];
            }
            //Sumatoria();
            Dtgconten.Focus();
        }
        private void Dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // string cadenita = Dtgconten[0, e.RowIndex].Value.ToString();
                btnmas.Focus();
                if (e.RowIndex >= 0)
                {
                    if (e.RowIndex > -1 && e.ColumnIndex == Dtgconten.Columns[cuenta.Name].Index && (estado == 1 || estado == 2))
                    {
                        frmlistarcuentas cuentitas = new frmlistarcuentas();
                        cuentitas.Icon = Icon;
                        if (Dtgconten[cuenta.Name, e.RowIndex].Value != null)
                        {
                            cuentitas.Txtbusca.Text = Dtgconten[cuenta.Name, e.RowIndex].Value.ToString();
                        }
                        else
                        { cuentitas.Txtbusca.Text = ""; }
                        cuentitas.radioButton1.Checked = true;
                        cuentitas.ShowDialog();
                        if (cuentitas.aceptar)
                        {
                            if (cuentitas.codigo.Substring(cuentitas.codigo.Length - 1, 1) == "0")
                            {
                                MSG("No se Puede Seleccionar una cuenta de Cabecera");
                            }
                            else
                            {
                                Dtgconten[cuenta.Name, e.RowIndex].Value = cuentitas.codigo;
                                btnmas.Focus();
                            }
                        }
                    }
                    if (Dtgconten[EstadoCuen.Name, e.RowIndex].Value == null) Dtgconten[EstadoCuen.Name, e.RowIndex].Value = cboestado.SelectedValue;
                    if (e.RowIndex >= 0 && e.ColumnIndex == Dtgconten.Columns[descripcion.Name].Index && Dtgconten[descripcion.Name, e.RowIndex].Value.ToString() != "" && Dtgconten[EstadoCuen.Name, e.RowIndex].Value.ToString() != "3")
                    {
                        //cuando doy click en el detalle
                        int y = e.RowIndex;
                        if (frmdetalle == null)
                        {
                            frmdetalle = new frmDetalleAsientos();
                            frmdetalle.MdiParent = this.MdiParent;
                            frmdetalle.Icon = this.Icon;
                            frmdetalle.idasiento = int.Parse(txtcodigo.Text);
                            frmdetalle.proyecto = (int)cboproyecto.SelectedValue;
                            if (chkfechavalor.Checked) frmdetalle.fecha = dtfechavalor.Value;
                            else frmdetalle.fecha = fecha.Value;
                            frmdetalle.asiento = int.Parse(Dtgconten[IDASIENTOX.Name, e.RowIndex].Value.ToString());
                            frmdetalle.cuenta = Dtgconten[cuenta.Name, e.RowIndex].Value.ToString();
                            frmdetalle.descripcion = Dtgconten[descripcion.Name, e.RowIndex].Value.ToString();
                            frmdetalle.Total = (decimal)Dtgconten[debe.Name, y].Value + (decimal)Dtgconten[haber.Name, y].Value;
                            frmdetalle.FormClosed += new FormClosedEventHandler(Frmdetalle_FormClosed);
                            frmdetalle.Show();
                        }
                        else frmdetalle.Activate();
                    }
                }
            }
            catch (Exception ex)
            {
                MSG(ex.Message);
            }
        }
        frmDetalleAsientos frmdetalle;
        private void Frmdetalle_FormClosed(object sender, FormClosedEventArgs e)
        {
            //cambia de estado a lo que se ingresa el detalle y cierra la ventana
            int? fit = dtgbusca.CurrentCell.RowIndex;
            if (Dtgconten.CurrentRow != null)
                if (frmdetalle.Dtgconten.RowCount > 1)
                {
                    frmdetalle.Dtgconten.AllowUserToAddRows = false;
                    frmdetalle.SacarDatos();
                    if (frmdetalle.ChkDuplicar.Checked)
                        btnActualizar_Click(sender, new EventArgs());
                    else
                        Dtgconten[detallex.Name, Dtgconten.CurrentRow.Index].Value = frmdetalle.Dtgconten.RowCount;
                }
                else
                    Dtgconten[detallex.Name, Dtgconten.CurrentRow.Index].Value = 0;
            PintardeCOlores();
            dtgbusca.CurrentCell = dtgbusca[0, fit == null ? (int)fit : 0];
            frmdetalle = null;
        }
        private void frmAsientoContable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmdetalle != null) { e.Cancel = true; HPResergerFunciones.Utilitarios.msg("Primero, Cierre la Ventana de Detalle"); }
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
                dinamica.Icon = Icon;
                dinamica.ValorBusqueda = 1;
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
            MessageBox.Show(text, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        private void txtdinamica_Leave(object sender, EventArgs e)
        {
            txtdinamica.Text = coddinamica.ToString("CD_0000");
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
                DataTable aux = ((DataTable)Dtgconten.DataSource).Clone();
                Dtgconten.DataSource = aux;
                for (int i = 0; i < dtgayuda.RowCount; i++)
                {//6=CodigoCuenta 7=DescripcionCuenta 8=Debe/Haber //0=CodigoCuenta 1=Descripcion 2=debe 3=haber
                    DataRow filita = aux.NewRow();
                    filita["cod"] = dtgayuda[6, i].Value;
                    filita["cuenta"] = dtgayuda[7, i].Value;
                    filita["detalle"] = 0;
                    filita["solicita"] = 0;
                    filita["id"] = Dtgconten.RowCount + 1;
                    filita[debe.Name] = 0.00m;
                    filita[haber.Name] = 0.00m;
                    aux.Rows.Add(filita);
                }
                txttotaldebe.Text = txttotalhaber.Text = txtdiferencia.Text = "0.00";
                totaldebe = totalhaber = 0;
            }
        }
        private void txtdinamica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                coddinamica = HPResergerFunciones.Utilitarios.ExtraeEnterodeCadena(txtdinamica.Text);
                dtgayuda.DataSource = CapaLogica.ListarDinamicas(coddinamica + "", 1);
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
                if (BusquedaCuenta)
                {
                    if (e.RowIndex > -1 && e.ColumnIndex == Dtgconten.Columns[cuenta.Name].Index)
                    { //MODIFICAR LA COLUMNA DE CODIGOS
                      //usp_buscar_cuenta
                        dtgayuda2.DataSource = CapaLogica.BuscarCuentas(Dtgconten[cuenta.Name, e.RowIndex].Value.ToString(), 1);
                        if (dtgayuda2.RowCount == 1)
                        {
                            Dtgconten[descripcion.Name, e.RowIndex].Value = dtgayuda2[0, 0].Value.ToString();
                            Dtgconten[SolicitaDetallex.Name, e.RowIndex].Value = dtgayuda2[2, 0].Value.ToString();
                            //Dtgconten[2, e.RowIndex].Value = dtgayuda2[1, 0].Value.ToString();
                            //aux = true;
                        }
                        else
                        {
                            Dtgconten[descripcion.Name, e.RowIndex].Value = "";
                            //aux = false;
                        }
                    }
                    if (e.RowIndex >= 0)
                    {
                        if (Dtgconten.Columns[descripcion.Name].Index == e.ColumnIndex)
                        {
                            if (Dtgconten[IDASIENTOX.Name, e.RowIndex].Value == null)
                            {
                                //if (Dtgconten[IDASIENTOX.Name, e.RowIndex].Value.ToString() == "")
                                //{
                                //    Dtgconten[IDASIENTOX.Name, e.RowIndex].Value = e.RowIndex + 1;
                                //}
                                Dtgconten[IDASIENTOX.Name, e.RowIndex].Value = e.RowIndex + 1;
                            }
                        }
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

        int punto = 0;//, deci = 0;
        private void dataGridview_KeyPressCajita(object sender, KeyPressEventArgs e)
        {
            //if (Char.IsDigit(e.KeyChar) || e.KeyChar == (Char)Keys.Back || e.KeyChar == '.' || e.KeyChar == ',')
            //{
            //    //e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
            HPResergerFunciones.Utilitarios.SoloNumerosDecimalesX(e, txt.Text);
        }
        private void dataGridview_KeyDownCajita(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txt);
        }
        TextBox txt;
        private void Dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            punto = 0;
            if (Dtgconten.CurrentCell.ColumnIndex == Dtgconten.Columns[debe.Name].Index || Dtgconten.CurrentCell.ColumnIndex == Dtgconten.Columns[haber.Name].Index)
            {
                txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(dataGridview_KeyPressCajita);
                    txt.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajita);
                    txt.KeyDown -= new KeyEventHandler(dataGridview_KeyDownCajita);
                    txt.KeyDown += new KeyEventHandler(dataGridview_KeyDownCajita);
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
            //try
            //{            
            if (e.ColumnIndex > 1)
            {
                if (Dtgconten[e.ColumnIndex, e.RowIndex].Value == null)
                    Dtgconten[e.ColumnIndex, e.RowIndex].Value = "0.00";
                if (Dtgconten[e.ColumnIndex, e.RowIndex].Value.ToString() == "")
                    Dtgconten[e.ColumnIndex, e.RowIndex].Value = "0.00";
                double aux = Convert.ToDouble(Dtgconten[e.ColumnIndex, e.RowIndex].Value.ToString());
                Dtgconten[e.ColumnIndex, e.RowIndex].Value = aux;
            }
            totaldebe = 0;
            totalhaber = 0;
            if (Dtgconten.RowCount > 0)
            {
                if (Dtgconten.RowCount == 1)
                {
                    if (Dtgconten[debe.Name, 0].Value.ToString() == "")
                    {
                        totaldebe = 0; Dtgconten[debe.Name, 0].Value = "0.00";
                    }
                    else { totaldebe = Convert.ToDecimal(Dtgconten[debe.Name, 0].Value.ToString()); }
                    if (Dtgconten[haber.Name, 0].Value.ToString() == "")
                    {
                        totalhaber = 0; Dtgconten[haber.Name, 0].Value = "0.00";
                    }
                    else
                    {
                        totaldebe = Convert.ToDecimal(Dtgconten[debe.Name, 0].Value.ToString());
                    }
                    txttotaldebe.Text = string.Format("{0:N2}", totaldebe);
                    txttotalhaber.Text = string.Format("{0:N2}", totalhaber);
                }
                if (Dtgconten.RowCount > 1)
                {
                    decimal aux1, aux2 = 0;
                    totaldebe = totalhaber = 0;
                    foreach (DataGridViewRow item in Dtgconten.Rows)
                    {
                        //for (int i = 0; i < Dtgconten.RowCount; i++)
                        //{
                        aux1 = 0; aux2 = 0;
                        if (item.Cells[debe.Name].Value == null) item.Cells[debe.Name].Value = "0.00";
                        if (item.Cells[debe.Name].Value.ToString() == "" || item.Cells[debe.Name].Value.ToString() == null)
                        {
                            item.Cells[debe.Name].Value = "0.00";
                        }
                        else
                        {
                            aux1 = Convert.ToDecimal(item.Cells[debe.Name].Value.ToString());
                        }
                        if (item.Cells[haber.Name].Value == null) item.Cells[haber.Name].Value = "0.00";
                        if (item.Cells[haber.Name].Value.ToString() == "" || item.Cells[haber.Name].Value.ToString() == null)
                        {
                            item.Cells[haber.Name].Value = "0.00";
                        }
                        else
                        {
                            aux2 = Convert.ToDecimal(item.Cells[haber.Name].Value.ToString());
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
            //}
            //catch
            //{
            //}
            // BusquedaReflejoPRevio();
        }
        public void BusquedaReflejoPRevio()
        {
            int fx = Dtgconten.RowCount;
            for (int i = 0; i < fx; i++)
            {
                if (Dtgconten[EstadoCuen.Name, i].Value != null)
                    if (Dtgconten[EstadoCuen.Name, i].Value.ToString() == "3")
                    {
                        //Dtgconten.CurrentCell = Dtgconten[cuenta.Name, 0];
                        Dtgconten.Rows.RemoveAt(i);
                        fx--;
                        i--;
                    }
            }
            int con = Dtgconten.RowCount;
            for (int i = 0; i < con; i++)
            {
                //busco si tienen refleejo y tiene valores
                if (decimal.Parse(Dtgconten[debe.Name, i].Value.ToString()) > 0 || decimal.Parse(Dtgconten[haber.Name, i].Value.ToString()) > 0)
                {
                    //busco los reflejos
                    DataTable tablita = new DataTable();
                    tablita = CapaLogica.BuscarCuentasReflejo(Dtgconten[cuenta.Name, i].Value.ToString(), decimal.Parse(Dtgconten[debe.Name, i].Value.ToString()), decimal.Parse(Dtgconten[haber.Name, i].Value.ToString()));
                    if (tablita.Rows.Count > 0)
                    {
                        foreach (DataRow filita in tablita.Rows)
                        {
                            Dtgconten.Rows.Add();
                            int f = Dtgconten.RowCount - 1;
                            Dtgconten[cuenta.Name, f].Value = filita["cuenta"].ToString();
                            Dtgconten[debe.Name, f].Value = filita["debe"].ToString();
                            Dtgconten[haber.Name, f].Value = filita["haber"].ToString();
                            Dtgconten[EstadoCuen.Name, f].Value = filita["estado"].ToString();
                            Dtgconten[detallex.Name, f].Value = 0;
                            Dtgconten.Rows[f].ReadOnly = true;
                        }
                    }
                }
            }
            // Sumatoria();
            PintardeCOlores();
        }
        public void Sumatoria()
        {

            //try
            //{
            if (Dtgconten.CurrentCell != null)
            {
                int e = Dtgconten.CurrentCell.RowIndex;
                int f = Dtgconten.CurrentCell.ColumnIndex;
                if (e >= 0 && f > 2)
                {
                    double aux = Convert.ToDouble(Dtgconten[f, e].Value.ToString());
                    Dtgconten[f, e].Value = string.Format("{0:N2}", aux);
                }
                if (Dtgconten.RowCount > 0)
                {
                    if (Dtgconten.RowCount == 1)
                    {
                        if (Dtgconten[debe.Name, 0].Value.ToString() == "")
                        {
                            totaldebe = 0; Dtgconten[debe.Name, 0].Value = "0.00";
                        }
                        else { totaldebe = Convert.ToDecimal(Dtgconten[debe.Name, 0].Value.ToString()); }
                        if (Dtgconten[haber.Name, 0].Value.ToString() == "")
                        {
                            totalhaber = 0; Dtgconten[haber.Name, 0].Value = "0.00";
                        }
                        else
                        {
                            totaldebe = Convert.ToDecimal(Dtgconten[debe.Name, 0].Value.ToString());
                        }

                        txttotaldebe.Text = string.Format("{0:N2}", totaldebe);
                        txttotalhaber.Text = string.Format("{0:N2}", totalhaber);
                    }
                    if (Dtgconten.RowCount > 1)
                    {
                        decimal aux1, aux2 = 0;
                        totaldebe = totalhaber = 0;
                        for (int i = 0; i < Dtgconten.RowCount; i++)
                        {
                            aux1 = 0;
                            aux2 = 0;
                            if (Dtgconten[debe.Name, i].Value == null) Dtgconten[debe.Name, i].Value = "0.00";
                            if (Dtgconten[debe.Name, i].Value.ToString() == "" || Dtgconten[debe.Name, i].Value.ToString() == null)
                            {
                                Dtgconten[debe.Name, i].Value = "0.00";
                            }
                            else { aux1 = Convert.ToDecimal(Dtgconten[debe.Name, i].Value.ToString()); }
                            if (Dtgconten[haber.Name, i].Value == null) Dtgconten[haber.Name, i].Value = "0.00";
                            if (Dtgconten[haber.Name, i].Value.ToString() == "" || Dtgconten[haber.Name, i].Value.ToString() == null)
                            {
                                Dtgconten[haber.Name, i].Value = "0.00";
                            }
                            else
                            {
                                aux2 = Convert.ToDecimal(Dtgconten[haber.Name, i].Value.ToString());
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
            //}
            //catch
            //{
            //}
        }
        private void lblmsg2_Click(object sender, EventArgs e)
        {

        }
        public int tipobusca = 0;
        private void Txtbusca_TextChanged(object sender, EventArgs e)
        {
            if (fechaini.Value < fechafin.Value)
            {
                dtgbusca.DataSource = CapaLogica.ListarAsientosContables(Txtbusca.EstaLLeno() ? Txtbusca.Text : "", tipobusca, fechaini.Value, fechafin.Value.AddDays(1), fechacheck, _idempresa);
            }
            else { dtgbusca.DataSource = CapaLogica.ListarAsientosContables(Txtbusca.EstaLLeno() ? Txtbusca.Text : "", tipobusca, fechafin.Value, fechaini.Value.AddDays(1), fechacheck, _idempresa); }
            msg2(dtgbusca);
            if (dtgbusca.RowCount < 1)
            {
                Dtgconten.DataSource = ((DataTable)Dtgconten.DataSource).Clone();
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
        public decimal activo, pasivo;
        Boolean BusquedaCuenta = true;
        private void dtgbusca_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int y = e.RowIndex;
                dtgayuda3.DataSource = CapaLogica.BuscarAsientosContables(dtgbusca[idx.Name, y].Value.ToString(), 4, _idempresa);
                if (dtgayuda3.RowCount > 0)
                {

                    fecha.Value = Convert.ToDateTime(dtgbusca[1, e.RowIndex].Value);
                    dtfechavalor.Value = Convert.ToDateTime(dtgbusca[8, e.RowIndex].Value);
                    txtcodigo.Text = dtgayuda3[0, 0].Value.ToString();
                    dinamica = Convert.ToInt32(dtgayuda3[7, 0].Value.ToString());
                    cboestado.SelectedValue = dtgayuda3[8, 0].Value;
                    txtdinamica.Text = "DC_00" + dinamica;

                    if (dtgbusca[empresax.Name, y].Value.ToString() != "")
                        cboempresa.SelectedValue = (int)dtgbusca[empresax.Name, y].Value;
                    else cboempresa.SelectedIndex = -1;

                    if (dtgbusca[proyectox.Name, y].Value.ToString() != "")
                        cboproyecto.SelectedValue = (int)dtgbusca[proyectox.Name, y].Value;
                    else cboproyecto.SelectedItem = -1;
                    cboetapa.SelectedValue = (int)dtgbusca[etapax.Name, y].Value;

                    if (dtgbusca[fechavalorx.Name, y].Value.ToString() == "")
                    {
                        chkfechavalor.Checked = false;
                        dtfechavalor.Value = (DateTime)dtgbusca[Fechax.Name, y].Value;
                    }
                    else { chkfechavalor.Checked = true; dtfechavalor.Value = (DateTime)dtgbusca[fechavalorx.Name, y].Value; }

                    //Dtgconten.Rows.Clear();
                    activo = pasivo = 0;
                    //int i = 0;
                    DateTime fechita;
                    if (chkfechavalor.Checked) fechita = dtfechavalor.Value; else fechita = fecha.Value;
                    DataTable Datos = CapaLogica.BuscarAsientosContablesconTodo(dtgbusca[idx.Name, y].Value.ToString(), 4, _idempresa, fechita);
                    Dtgconten.DataSource = Datos;
                    foreach (DataGridViewRow item in Dtgconten.Rows)
                    {
                        //Dtgconten.Rows.Add();
                        BusquedaCuenta = false;
                        //Dtgconten[IDASIENTOX.Name, i].Value = item.Cells["idAsiento"].Value.ToString();
                        //Dtgconten[cuenta.Name, i].Value = item.Cells["cod"].Value.ToString();
                        //Dtgconten[descripcion.Name, i].Value = item.Cells["cuenta"].Value.ToString();
                        //Dtgconten[debe.Name, i].Value = item.Cells["debe"].Value;
                        //Dtgconten[haber.Name, i].Value = item.Cells["haber"].Value;
                        //Dtgconten[EstadoCuen.Name, i].Value = item.Cells["estado"].Value;
                        //Dtgconten[detallex.Name, i].Value = item.Cells["detalle"].Value;
                        //sumas
                        activo += Convert.ToDecimal(item.Cells[debe.Name].Value);
                        pasivo += Convert.ToDecimal((item.Cells[haber.Name].Value));
                        //i++;
                    }
                    PintardeCOlores();
                    txtdiferencia.Text = string.Format("{0:N2}", activo - pasivo);
                    txttotaldebe.Text = string.Format("{0:N2}", activo);
                    txttotalhaber.Text = string.Format("{0:N2}", pasivo);
                    BusquedaCuenta = true;
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
        }
        public void PintardeCOlores()
        {
            foreach (DataGridViewRow item in Dtgconten.Rows)
            {
                if (item.Cells[EstadoCuen.Name].Value != null)
                    if (item.Cells[EstadoCuen.Name].Value.ToString() == "3")
                    {
                        item.DefaultCellStyle.ForeColor = Color.Red;
                    }
                if (item.Cells[detallex.Name].Value != null)
                    if (int.Parse(item.Cells[detallex.Name].Value.ToString()) > 0)
                    {
                        item.DefaultCellStyle.ForeColor = Color.Blue;
                    }
            }
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
            tablita.Rows.Add(new object[] { "2", "Por Modificar" });
            tablita.Rows.Add(new object[] { "3", "Reflejo" });
            tablita.Rows.Add(new object[] { "4", "Reversado" });
            combito.DataSource = tablita;
            combito.DisplayMember = "VALOR";
            combito.ValueMember = "CODIGO";
        }
        private void cboestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if ((cboestado.SelectedValue==null?"0":cboestado.SelectedValue.ToString()) == "3") cboestado.SelectedIndex = -1;
        }
        public int estado { get; set; }
        public int codigo;
        public void ultimoasiento()
        {
            DataTable tablita = new DataTable();      
            tablita = CapaLogica.UltimoAsiento((int)cboempresa.SelectedValue);
            DataRow filas = tablita.Rows[0];
            if (filas.ItemArray[0] != DBNull.Value)
            {
                codigo = Convert.ToInt32(filas.ItemArray[0]);
                codigo++;
            }
            else { codigo = 1; }
            txtcodigo.Text = codigo + "";
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            desactivar();
            Dtgconten.DataSource = ((DataTable)Dtgconten.DataSource).Clone();
            ultimoasiento();
            txtdinamica.Text = "";
            txtcodigo.Text = codigo + "";
            txttotaldebe.Text = txttotalhaber.Text = txtdiferencia.Text = "0.00";
            fecha.Value = DateTime.Now;
            btnActualizar.Enabled = false; chkfechavalor.Enabled = true;
            cboestado.SelectedIndex = 0;
        }
        public Boolean modifico;
        public int dinamimodi;
        DataTable TableAux;
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (cboestado.SelectedValue.ToString() == "1")
            {
                if (frmLogin.Usuario == "ADMIN")
                {
                    if (Dtgconten.RowCount <= 0) { MSG("No Hay Datos"); return; }
                    estado = 2;
                    dinamimodi = Convert.ToInt16(dtgayuda3[7, 0].Value.ToString());
                    modifico = false;
                    desactivar();
                    btnmas.Focus(); chkfechavalor.Enabled = true; btnActualizar.Enabled = false;
                }
                else
                {
                    if (msgP("Este Asiento NO se puede Modificar, Solicite a su jefe que habilite la Edición del Asiento.\n¿Desea Solicitar Modificación?") == DialogResult.Yes)
                    {
                        TableAux = CapaLogica.ListarJefeInmediato(frmLogin.CodigoUsuario, "", 10);
                        if (TableAux.Rows.Count > 0)
                        {
                            DataRow filita = TableAux.Rows[0];
                            filita[codigo].ToString();
                            //Enviando al Jefe la Acción
                            string cade = "";
                            string sql = $"update TBL_Asiento_Contable set Estado=2 where Id_Asiento_Contable={txtcodigo.Text} and id_proyecto={cboproyecto.SelectedValue}   UPDATE x SET  x.Saldo_Debe = x.Saldo_Debe - v.debe, x.Saldo_Haber = x.Saldo_Haber - v.haber, x.Saldo_Fin = x.Saldo_Inicio + x.Saldo_Debe - v.debe - (x.Saldo_Haber - v.haber) FROM TBL_Saldos_Contable x " +
                                " INNER JOIN  ( SELECT SUM(i.Saldo_Debe) AS debe, SUM(i.Saldo_Haber) AS haber, i.Fecha_Asiento_Valor, i.Fecha_Asiento, i.Cuenta_Contable, i.id_proyecto, p.Id_Empresa FROM TBL_Asiento_Contable AS i  INNER JOIN TBL_Proyecto AS p ON i.id_proyecto = p.Id_Proyecto " +
                                " WHERE i.Id_Asiento_Contable = @Codigo AND i.id_proyecto = @Proyecto GROUP BY Cuenta_Contable, Fecha_Asiento_Valor, Fecha_Asiento, i.id_proyecto, p.Id_Empresa) v ON x.Anio = YEAR(isnull(v.Fecha_Asiento_Valor, v.Fecha_Asiento)) " +
                                " AND x.Mes = MONTH(isnull(v.Fecha_Asiento_Valor, v.Fecha_Asiento)) AND x.Cuenta_Contable = v.Cuenta_Contable AND x.EMPRESA = v.Id_Empresa ";
                            CapaLogica.TablaSolicitudes(1, int.Parse(filita["codigo"].ToString()), sql, cade, 0, frmLogin.CodigoUsuario, $"Solicita Modificar el Asiento: {txtcodigo.Text} de Empresa: {cboempresa.Text} ");
                            MSG("Se ha Enviado la Solicitud a su Jefe");
                        }
                        else { MSG("No se Encontró Información de su Jefe"); }
                    }
                }
            }
            else
            {
                if (Dtgconten.RowCount <= 0) { MSG("No Hay Datos"); return; }
                estado = 2;
                dinamimodi = Convert.ToInt16(dtgayuda3[7, 0].Value.ToString());
                modifico = false;
                desactivar();
                btnmas.Focus(); chkfechavalor.Enabled = true; btnActualizar.Enabled = false;
            }
        }
        public void validar()
        {
            salida = true;
            try
            {
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (item.Cells[cuenta.Name].Value.ToString() == "")
                    {
                        Dtgconten.Rows.Remove(item);
                    }
                }
                string cadena = "";
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (item.Cells[descripcion.Name].Value.ToString() == "")
                    {
                        cadena += $"El Nombre de la Cuenta de la linea: { item.Index + 1}  Es Incorrecto\n";
                        salida = false;
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[descripcion.Name]);
                    }
                    else
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[descripcion.Name]);

                    if (item.Cells[cuenta.Name].Value.ToString() == "")
                    {
                        cadena += $"La Cuenta de la linea: { item.Index + 1}  Es Incorrecto\n";
                        salida = false;
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[cuenta.Name]);
                    }
                    else
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[cuenta.Name]);

                    if (Convert.ToDouble(item.Cells[debe.Name].Value.ToString()) >= 0)
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[debe.Name]);
                    else
                    {
                        cadena += $"El valor Del Debe:{ item.Index + 1} Es Incorrecto\n";
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[debe.Name]);
                        salida = false;
                    }

                    if (Convert.ToDouble(item.Cells[haber.Name].Value.ToString()) >= 0)
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[haber.Name]);
                    else
                    {
                        cadena += $"El valor del Haber: {item.Index + 1} Es Incorrecto\n";
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[haber.Name]);
                        salida = false;
                    }
                    if (Convert.ToDouble(item.Cells[debe.Name].Value.ToString()) == Convert.ToDouble(item.Cells[haber.Name].Value.ToString()) && 0 != (Convert.ToDouble(item.Cells[debe.Name].Value.ToString()) + Convert.ToDouble(item.Cells[haber.Name].Value.ToString())))
                    {
                        cadena += $"El DEBE y HABER son iguales en la Linea: {item.Index + 1}\n";
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[haber.Name]);
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[debe.Name]);
                        salida = false;
                    }
                    else
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[debe.Name]);
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[haber.Name]);
                    }
                    //validar
                    if ((Convert.ToDecimal(item.Cells[debe.Name].Value.ToString()) > 0 && Convert.ToDecimal(item.Cells[haber.Name].Value.ToString()) != 0) || ((Convert.ToDecimal(item.Cells[haber.Name].Value.ToString()) > 0 && Convert.ToDecimal(item.Cells[debe.Name].Value.ToString()) != 0)))
                    {
                        cadena += $"El DEBE y HABER no deben tener Valores en Fila: {item.Index + 1}\n";
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[haber.Name]);
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[debe.Name]);
                        salida = false;
                    }
                    else
                    {
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[debe.Name]);
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[haber.Name]);
                    }
                    if (item.Cells[detallex.Name].Value == null) item.Cells[detallex.Name].Value = 0;
                    if (int.Parse(item.Cells[SolicitaDetallex.Name].Value.ToString()) > int.Parse(item.Cells[detallex.Name].Value.ToString()))
                    {
                        cadena += $"La Cuenta de La fila: {item.Index + 1} Necesita un detalle\n";
                        HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[SolicitaDetallex.Name]);
                        salida = false;
                    }
                    else
                        HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[SolicitaDetallex.Name]);

                }
                if (!salida)
                    Mensajes(cadena);
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
            catch (FormatException) { Mensajes("Hay Números Mal Ingresados"); salida = false; }
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
                , CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (cboempresa.SelectedIndex < 0)
            {
                MSG("Seleccione Empresa");
                //cboempresa.Focus(); 
                return;
            }
            if (cboproyecto.SelectedIndex < 0)
            {
                MSG("Seleccione Proyecto");
                // cboproyecto.Focus();
                return;
            }
            if (cboetapa.SelectedIndex < 0)
            {
                MSG("Seleccione Etapa");
                // cboetapa.Focus();
                return;
            }
            btnmas_Click(sender, e);
            validar();
            aceptar = true;
            if (salida)
            {
                //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones  
                if (estado == 1 && Dtgconten.RowCount > 1)
                {
                    //string cadena = "";
                    if (txtdinamica.Text.Length <= 0) txtdinamica.Text = "CD_000";
                    CArgarValoresIngreso();
                    // MostrarValores(cadena + Detalle(), codigo);
                    for (int i = 0; i < Dtgconten.RowCount; i++)
                    {
                        DateTime? fechita;
                        if (chkfechavalor.Checked) fechita = dtfechavalor.Value;
                        else fechita = null;
                        CapaLogica.InsertarAsiento((int)Dtgconten[IDASIENTOX.Name, i].Value, codigo, FECHA, Dtgconten[cuenta.Name, i].Value.ToString(), Convert.ToDouble(Dtgconten[debe.Name, i].Value.ToString()), Convert.ToDouble(Dtgconten[haber.Name, i].Value.ToString()), DINAMICA, ESTADO, fechita, (int)cboproyecto.SelectedValue, (int)cboetapa.SelectedValue);
                    }
                    MSG($"Se Insertó Asiento: {txtcodigo.Text} con Exito");
                    Txtbusca.Text = codigo + "";
                    //dtgbusca.DataSource = CapaLogica.BuscarAsientosContables(Txtbusca.Text, 1, _idempresa);
                    btnActualizar_Click(new object { }, new EventArgs());
                    activar(); estado = 0;
                }
                else
                {
                    if (estado == 2 && Dtgconten.RowCount > 1)
                    {
                        //string cadena = "";
                        codigo = Convert.ToInt32(txtcodigo.Text.ToString());
                        CArgarValoresIngreso();
                        //MostrarValores(cadena + Detalle(), codigo);
                        CapaLogica.Modificar2asiento(codigo, (int)cboproyecto.SelectedValue);
                        //Mensajes("Codigo:" + codigo + " Filas;" + Dtgconten.RowCount);
                        foreach (DataGridViewRow item in Dtgconten.Rows)
                        {
                            if (item.Cells[EstadoCuen.Name].Value.ToString() != "3")
                                item.Cells[EstadoCuen.Name].Value = cboestado.SelectedValue.ToString();
                        }
                        for (int i = 0; i < Dtgconten.RowCount; i++)
                        {
                            if (int.Parse(cboestado.SelectedValue.ToString()) == 0)
                                ESTADO = 0;
                            else
                                if (Dtgconten[EstadoCuen.Name, i].Value == null)
                                ESTADO = 1;
                            else
                                ESTADO = int.Parse(Dtgconten[EstadoCuen.Name, i].Value.ToString());
                            DateTime? fechitas;
                            if (chkfechavalor.Checked) fechitas = dtfechavalor.Value;
                            else fechitas = null;
                            if (modifico)
                                CapaLogica.InsertarAsiento(int.Parse(Dtgconten[IDASIENTOX.Name, i].Value.ToString()), codigo, FECHA, Dtgconten[cuenta.Name, i].Value.ToString(), Convert.ToDouble(Dtgconten[debe.Name, i].Value.ToString()), Convert.ToDouble(Dtgconten[haber.Name, i].Value.ToString()), DINAMICA, ESTADO, fechitas, (int)cboproyecto.SelectedValue, (int)cboetapa.SelectedValue);
                            else
                                CapaLogica.InsertarAsiento(int.Parse(Dtgconten[IDASIENTOX.Name, i].Value.ToString()), codigo, FECHA, Dtgconten[cuenta.Name, i].Value.ToString(), Convert.ToDouble(Dtgconten[debe.Name, i].Value.ToString()), Convert.ToDouble(Dtgconten[haber.Name, i].Value.ToString()), dinamimodi, ESTADO, fechitas, (int)cboproyecto.SelectedValue, (int)cboetapa.SelectedValue);
                        }
                        MSG($"Se Modificó Asiento: {txtcodigo.Text} con Exito");
                        estado = 0;
                        Txtbusca.Text = codigo + "";
                        //dtgbusca.DataSource = CapaLogica.BuscarAsientosContables(Txtbusca.Text, 1, _idempresa);
                        btnActualizar_Click(new object { }, new EventArgs());
                        activar();
                    }
                    else
                    {
                        if (estado == 3)
                        {
                            codigo = Convert.ToInt32(txtcodigo.Text.ToString());
                            if (MessageBox.Show("Seguró Desea Eliminar; Asiento Contable" + codigo, CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                CapaLogica.EliminarAsiento(codigo, (int)cboproyecto.SelectedValue);
                                MessageBox.Show("Eliminado Exitosamente ", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Txtbusca.Text = "";
                                //dtgbusca.DataSource = CapaLogica.BuscarAsientosContables(Txtbusca.Text, 1, _idempresa);
                                btnActualizar_Click(new object { }, new EventArgs());
                            }
                            estado = 0;
                        }
                    }
                }
            }
            else { }
            btnActualizar.Enabled = true;
        }
        public void BuscarAsiento(string cadena, int empresa)
        {
            Txtbusca.Text = cadena;
            cboempresa.SelectedValue = empresa;
            dtgbusca.DataSource = CapaLogica.BuscarAsientosContables(cadena, 1, empresa);
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
                    if (MessageBox.Show("Hay datos Ingresados, Desea Salir?", CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        estado = 0;
                        activar();
                        //dtgbusca.DataSource = CapaLogica.BuscarAsientosContables(Txtbusca.Text, 1);
                        dtgbusca.DataSource = CapaLogica.ListarAsientosContables("", 1, DateTime.Today, DateTime.Today, 0, _idempresa);
                        Txtbusca.Enabled = false;
                        dtgbusca.Focus(); btnActualizar.Enabled = true;
                    }
                    else { }
                }
                else
                {
                    if (estado == 2 && Dtgconten.RowCount > 0)
                    {
                        if (MessageBox.Show("Hay datos Ingresados, Desea Salir?", CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            estado = 0;
                            activar();
                            //dtgbusca.DataSource = CapaLogica.BuscarAsientosContables(Txtbusca.Text, 1);
                            dtgbusca.DataSource = CapaLogica.ListarAsientosContables("", 1, DateTime.Today, DateTime.Today, 0, _idempresa);
                            Txtbusca.Enabled = true;
                            dtgbusca.Focus();
                        }
                        else { Dtgconten.BeginEdit(true); }
                    }
                    else
                    {
                        estado = 0;
                        activar();
                        //dtgbusca.DataSource = CapaLogica.BuscarAsientosContables(Txtbusca.Text, 1);
                        dtgbusca.DataSource = CapaLogica.ListarAsientosContables("", 1, DateTime.Today, DateTime.Today, 0, _idempresa);
                        Txtbusca.Enabled = true;
                        dtgbusca.Focus(); btnActualizar.Enabled = true;
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
                if (MessageBox.Show("Desea Borrar esta fila", CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
        private void chkfecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkfecha.Checked) fechacheck = 1;
            else fechacheck = 0;
            Txtbusca_TextChanged(sender, e);
        }
        private void dtgbusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (dtgbusca.Rows.Count > 0)
            {
                if (dtgbusca.CurrentCell.RowIndex >= 0)
                {
                    if (e.KeyCode == Keys.Down)
                    {
                        //Tecla para Abajo
                        int x = dtgbusca.CurrentCell.RowIndex;
                        int cox = 0;
                        cox = (int)dtgbusca[0, x].Value;
                        for (int i = x; i < dtgbusca.RowCount; i++)
                        {
                            //Buscar Siguiente Codigo de Asiento;
                            if (cox != (int)dtgbusca[0, i].Value)
                            {
                                dtgbusca.CurrentCell = dtgbusca[0, i - 1];
                                break;
                            }
                        }
                    }
                    if (e.KeyCode == Keys.Up)
                    {
                        int x = dtgbusca.CurrentCell.RowIndex;
                        int cox = 0;
                        cox = (int)dtgbusca[0, x].Value;
                        for (int i = x; i > 0; i--)
                        {
                            //Buscar Siguiente Codigo de Asiento; 
                            {
                                dtgbusca.CurrentCell = dtgbusca[0, i];
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Txtbusca.Text = "";
            Txtbusca_TextChanged(sender, e);
        }
        private void dtgayuda3_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Dtgconten_CellEndEdit(sender, e);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (estado != 0)
                if (chkfechavalor.Checked)
                    dtfechavalor.Enabled = true;
                else
                    dtfechavalor.Enabled = false;
            ultimoasiento();
        }
        private void cboempresa_Enter(object sender, EventArgs e)
        {
            string CodText = cboempresa.Text;
            cARgarEmpresas();
            cboempresa.Text = CodText;
        }
        public int _idempresa = 0;
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboempresa.Items.Count > 0)
            {
                if (cboempresa.SelectedValue != null)
                {
                    cboproyecto.DataSource = CapaLogica.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString());
                    cboproyecto.DisplayMember = "proyecto";
                    cboproyecto.ValueMember = "id_proyecto";
                    //busqueda de Asientos
                    _idempresa = (int)cboempresa.SelectedValue;
                    if (estado == 0)
                    {
                        txtcodigo.Text = "0";
                        txttotaldebe.Text = txttotalhaber.Text = txtdiferencia.Text = "0.00";
                        Txtbusca_TextChanged(sender, e);
                    }
                    if (estado == 1)
                    {
                        ultimoasiento();
                        txtcodigo.Text = (codigo).ToString();
                    }
                }
            }
            else MSG("No hay Empresas");
        }
        private void cboproyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboproyecto.SelectedIndex >= 0)
            {
                DataRowView itemsito = (DataRowView)cboproyecto.Items[cboproyecto.SelectedIndex];
                cboetapa.DataSource = CapaLogica.ListarEtapasProyecto((itemsito["id_proyecto"].ToString()));
                cboetapa.ValueMember = "id_etapa";
                cboetapa.DisplayMember = "descripcion";
            }
            else MSG("No Hay Proyectos");
        }
        private void MSG(string v)
        {
            MessageBox.Show(v, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private DialogResult msgP(string v)
        {
            return MessageBox.Show(v, CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        private void cboproyecto_Enter(object sender, EventArgs e)
        {
            string cadena = cboproyecto.Text;
            cboempresa_SelectedIndexChanged(sender, e);
            cboproyecto.Text = cadena;
        }
        private void cboetapa_Enter(object sender, EventArgs e)
        {
            string cadena = cboetapa.Text;
            cboproyecto_SelectedIndexChanged(sender, e);
            cboproyecto.Text = cadena;
        }
        private void Dtgconten_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Sumatoria();
        }
        private void Dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (Dtgconten[detallex.Name, e.RowIndex].Value != null)
                    lbldetalle.Text = "Detalle: " + Dtgconten[detallex.Name, e.RowIndex].Value.ToString();
        }
        private void Dtgconten_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                if (y == Dtgconten.Columns[debe.Name].Index || y == Dtgconten.Columns[haber.Name].Index)
                {
                    Dtgconten[y, x].Value = decimal.Parse(Dtgconten[y, x].Value.ToString());
                }
            }
        }
        private void Dtgconten_Sorted(object sender, EventArgs e)
        {
            PintardeCOlores();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (HPResergerFunciones.Utilitarios.msgp($"Seguro Desea Reversar Este Asiento Nro {txtcodigo.Text}") == DialogResult.Yes)
            {
                //PROCESO DE REVERSA DEL ASIENTO
                CapaLogica.ReversarAsientos(int.Parse(txtcodigo.Text), (int)cboproyecto.SelectedValue, frmLogin.CodigoUsuario);
                HPResergerFunciones.Utilitarios.msg("Asiento Reversado!");
            }
            btnActualizar_Click(sender, e);
            //else
            //HPResergerFunciones.Utilitarios.msg("Ahorita no joven");
        }
        private void cboestado_TextChanged(object sender, EventArgs e)
        {
            if (cboestado.Text == "Activo") btneliminar.Text = "Desactivar"; else btneliminar.Text = "Activar";
        }
        private void fecha_ValueChanged(object sender, EventArgs e)
        {         
        }
        private void dtfechavalor_ValueChanged(object sender, EventArgs e)
        {        
        }
        private void Dtgconten_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //Sumatoria();
            msg(Dtgconten);
        }
    }
}
