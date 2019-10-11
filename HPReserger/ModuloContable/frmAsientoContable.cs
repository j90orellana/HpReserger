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
    public partial class frmAsientoContable : FormGradient
    {
        public frmAsientoContable()
        {
            InitializeComponent();
        }
        public decimal totaldebe { get; set; }
        public decimal totalhaber { get; set; }
        int fechacheck = 0;
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void Cargarmoneda()
        {
            CapaLogica.TablaMonedas(cbomoneda);
        }
        private void frmAsientoContable_Load(object sender, EventArgs e)
        {
            //cargar TExtos por defecto
            txtbuscuo.CargarTextoporDefecto(); txtbusGlosa.CargarTextoporDefecto(); txtbusSuboperacion.CargarTextoporDefecto(); txtbuscuenta.CargarTextoporDefecto();
            dtpfechaini.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfechafin.Value = new DateTime(DateTime.Now.Year, 12, 31);
            //
            labelAzul.ForeColor = Configuraciones.ColorBien;
            labelRojo.ForeColor = Configuraciones.RojoUI;
            labelAmarillo.ForeColor = Color.Chocolate;
            //labelAmarillo.ForeColor = Color.FromArgb(247, 125, 0);
            labelCuadre.ForeColor = Configuraciones.ColorBien;
            Cargarmoneda();
            estado = 100; fechacheck = 0;
            tipobusca = 1;
            RellenarEstado(cboestado);
            System.Globalization.CultureInfo.CreateSpecificCulture("es-ES");
            cARgarEmpresas();
            DateTime fechita;
            //if (chkfechavalor.Checked) 
            fechita = dtpfechavalor.Value;
            //else fechita = dtpfecha.Value;
            ///Mensajitos
            //Dtgconten.Columns[debe.Name].CellTemplate.ToolTipText = "Presione D para Rellenar";
            //Dtgconten.Columns[haber.Name].CellTemplate.ToolTipText = "Presione D para Rellenar";
            ///           
            DateTime FechaPrueba = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            {
                fechaini.Value = FechaPrueba;
                fechafin.Value = (FechaPrueba.AddMonths(1)).AddDays(-1);
            }
            ListoParaBuscar = BuscarEmpresa = true;
            //Dtgconten.DataSource = CapaLogica.BuscarAsientosContablesconTodo("0", 4, 1, fechita);
            //dtgbusca.DataSource = CapaLogica.ListarAsientosContables("", 1, DateTime.Today, DateTime.Today, 0, _idempresa);

            //Cambio de Empresa      
            this.Activated -= frmAsientoContable_Activated;
            estado = 0; cboempresa_SelectedIndexChanged(sender, e);
            if (dtgbusca.RowCount > 0)
            {
                activar();
                //dtgbusca_RowEnter(sender, new DataGridViewCellEventArgs(0, 0));
            }
            this.Activated += frmAsientoContable_Activated;
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
                Txtbusca.Enabled = btnreversa.Enabled = true;
            radioButton1.Enabled = radioButton2.Enabled = chkfecha.Enabled = fechaini.Enabled = fechafin.Enabled = true;
            btncleanfind.Enabled = txtbuscuenta.Enabled = txtbuscuo.Enabled = txtbusGlosa.Enabled = txtbusSuboperacion.Enabled = dtpfechaini.Enabled = dtpfechafin.Enabled = true;
            //chkfechavalor.Enabled = 
            btnmas.Enabled = cboestado.Enabled = btndina.Enabled = dtpfechavalor.Enabled = cboproyecto.Enabled = cboetapa.Enabled =
                txtdinamica.Enabled = false;
            foreach (DataGridViewColumn col in Dtgconten.Columns)
                col.ReadOnly = true;
            txtglosa.ReadOnly = txttipocambio.ReadOnly = true; cbomoneda.Enabled = cbocambio.Enabled = false;
        }
        public void desactivar()
        {
            btnnuevo.Enabled = btnmodificar.Enabled = btneliminar.Enabled = dtgbusca.Enabled = btnreversa.Enabled =
                Txtbusca.Enabled = false;
            btncleanfind.Enabled = radioButton1.Enabled = radioButton2.Enabled = chkfecha.Enabled = fechaini.Enabled = fechafin.Enabled = false;
            txtbuscuo.Enabled = txtbuscuenta.Enabled = txtbusGlosa.Enabled = txtbusSuboperacion.Enabled = dtpfechaini.Enabled = dtpfechafin.Enabled = false;

            //chkfechavalor.Enabled = 
            btnmas.Enabled = cboestado.Enabled = btndina.Enabled = dtpfechavalor.Enabled = cboproyecto.Enabled = cboetapa.Enabled =
                txtdinamica.Enabled = true;
            foreach (DataGridViewColumn col in Dtgconten.Columns)
                if (col.Name == descripcion.Name || col.Name == IDASIENTOX.Name)
                    col.ReadOnly = true;
                else col.ReadOnly = false;
            txtglosa.ReadOnly = txttipocambio.ReadOnly = false; cbomoneda.Enabled = cbocambio.Enabled = true;
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
                //Dtgconten.CurrentCell = Dtgconten[cuenta.Name, Dtgconten.RowCount - 1];
                if (Dtgconten[cuenta.Name, Dtgconten.CurrentCell.RowIndex].Value.ToString() != "" && Dtgconten[descripcion.Name, Dtgconten.CurrentCell.RowIndex].Value.ToString() != "")
                {
                    //Ultima Secuencia
                    int f = 1;
                    //Posición Antes de los Reflejos 
                    int Fila = 1; ;
                    foreach (DataGridViewRow item in Dtgconten.Rows)
                    {
                        if (item.Cells[EstadoCuen.Name].Value != null)
                        {
                            if (item.Cells[EstadoCuen.Name].Value.ToString() != "3")
                            {
                                if ((int)item.Cells[IDASIENTOX.Name].Value > f)
                                {
                                    f = (int)item.Cells[IDASIENTOX.Name].Value;
                                }
                                Fila++;
                            }
                        }
                        else Fila++;
                    }
                    DataRow filax = ((DataTable)Dtgconten.DataSource).NewRow();
                    filax[IDASIENTOX.DataPropertyName] = ++f;
                    filax[cuenta.DataPropertyName] = "";
                    filax[debe.DataPropertyName] = 0.00;
                    filax["haber"] = 0.00;
                    filax["estado"] = 1;
                    ((DataTable)Dtgconten.DataSource).Rows.InsertAt(filax, Fila - 1);
                    Dtgconten.CurrentCell = Dtgconten[cuenta.Name, Fila - 1];
                }
            }
            else
            {
                Con = Dtgconten.RowCount + 1;
                ((DataTable)Dtgconten.DataSource).Rows.Add();
                Dtgconten[IDASIENTOX.Name, 0].Value = Con;
                Dtgconten[cuenta.Name, 0].Value = Dtgconten[descripcion.Name, 0].Value = "";
                Dtgconten[EstadoCuen.Name, Dtgconten.RowCount - 1].Value = 1;
                Dtgconten[debe.Name, Dtgconten.RowCount - 1].Value = Dtgconten[haber.Name, Dtgconten.RowCount - 1].Value = "0.00";
                Dtgconten.CurrentCell = Dtgconten[cuenta.Name, Dtgconten.RowCount - 1];
            }
            Sumatoria();
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
                            //if (cuentitas.codigo.Substring(cuentitas.codigo.Length - 1, 1) == "0")
                            //{
                            //    MSG("No se Puede Seleccionar una cuenta de Cabeceras");
                            //}
                            //else
                            //{
                            Dtgconten[cuenta.Name, e.RowIndex].Value = cuentitas.codigo;
                            btnmas.Focus();
                            //}
                        }
                    }
                    if (Dtgconten[EstadoCuen.Name, e.RowIndex].Value == null) Dtgconten[EstadoCuen.Name, e.RowIndex].Value = cboestado.SelectedValue;
                    if (estado == 0)
                        if (e.RowIndex >= 0 && e.ColumnIndex == Dtgconten.Columns[descripcion.Name].Index && Dtgconten[descripcion.Name, e.RowIndex].Value.ToString() != "")// && Dtgconten[EstadoCuen.Name, e.RowIndex].Value.ToString() != "3" && estado == 0)
                        {
                            //cuando doy click en el detalle
                            int y = e.RowIndex;
                            if (frmdetalle == null)
                            {
                                frmdetalle = new frmDetalleAsientos();
                                frmMenu.AbortarCerrarPrograma = true;
                                frmdetalle.MdiParent = this.MdiParent;
                                frmdetalle.Icon = this.Icon;
                                frmdetalle._idasiento = int.Parse(txtcodigo.Text);
                                frmdetalle._cuodasiento = txtcuo.Text;
                                frmdetalle._proyecto = (int)cboproyecto.SelectedValue;
                                frmdetalle._empresa = (int)cboempresa.SelectedValue;
                                frmdetalle._TipoCambio = decimal.Parse(txttipocambio.Text == "" ? txttipocambio.TextoDefecto : txttipocambio.Text);
                                frmdetalle._Moneda = (int)cbomoneda.SelectedValue;
                                frmdetalle._EsManual = _EsModificable;
                                //if (chkfechavalor.Checked) frmdetalle._fecha = dtfechavalor.Value; else
                                frmdetalle._fecha = dtpfechavalor.Value;
                                frmdetalle._fechaEmision = dtpfecha.Value;
                                frmdetalle._asiento = int.Parse(Dtgconten[IDASIENTOX.Name, e.RowIndex].Value.ToString());
                                frmdetalle.cuenta = Dtgconten[cuenta.Name, e.RowIndex].Value.ToString();
                                frmdetalle.descripcion = Dtgconten[descripcion.Name, e.RowIndex].Value.ToString();
                                frmdetalle.Total = (decimal)Dtgconten[debe.Name, y].Value + (decimal)Dtgconten[haber.Name, y].Value;
                                frmdetalle.Estado = (int)Dtgconten[EstadoCuen.Name, e.RowIndex].Value;
                                frmdetalle._dinamica = (int)dtgbusca[Iddinamica.Name, dtgbusca.CurrentCell.RowIndex].Value;
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
                frmdetalle = null;
                frmMenu.AbortarCerrarPrograma = false;
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
            dtgbusca.CurrentCell = dtgbusca[0, fit != null ? (int)fit : 0];
            frmdetalle = null;
            estado = -1;
            RevisarSihayDescuadre();
            frmMenu.AbortarCerrarPrograma = false;
        }
        public void RefrescarAsientoSeleccionado()
        {
            if (dtgbusca.CurrentCell != null)
            {
                Busqueda = !Busqueda;
                dtgbusca_RowEnter(new object { }, new DataGridViewCellEventArgs(dtgbusca.CurrentCell.ColumnIndex, dtgbusca.CurrentCell.RowIndex));
            }
        }
        private void frmAsientoContable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmdetalle != null)
            {
                e.Cancel = true; //HPResergerFunciones.Utilitarios.msg("Primero, Cierre la Ventana de Detalle");
                frmdetalle.WindowState = FormWindowState.Normal;
                frmdetalle.Activate();
                frmMenu.AbortarCerrarPrograma = true;
            }
            else frmMenu.AbortarCerrarPrograma = false;
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
                    filita["estado"] = 1;
                    filita["id"] = Dtgconten.RowCount + 1;
                    filita[debe.Name] = 0.00m;
                    filita[haber.Name] = 0.00m;
                    txtglosa.Text = dtgayuda["glosa", i].Value.ToString();

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
                dtgayuda.DataSource = CapaLogica.ListarDinamicas(coddinamica + "", 10);
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
                RevisarDetalleCuadrado(Dtgconten.Rows[e.RowIndex]);
            }
            catch { }
        }
        private void Dtgconten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && (estado == 1 || estado == 2))
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
            if ((Dtgconten.CurrentCell.ColumnIndex == Dtgconten.Columns[debe.Name].Index) || (Dtgconten.CurrentCell.ColumnIndex == Dtgconten.Columns[haber.Name].Index))
                if (e.KeyChar == 'D' || e.KeyChar == 'd')
                {
                    if (HPResergerFunciones.Utilitarios.msgYesNo("Desea Rellenar Automáticamente") == DialogResult.Yes)
                    {
                        if (Dtgconten.CurrentCell.ColumnIndex == Dtgconten.Columns[debe.Name].Index)
                            Configuraciones.RellenarGrillasAutomatico(Dtgconten, haber, debe);
                        if (Dtgconten.CurrentCell.ColumnIndex == Dtgconten.Columns[haber.Name].Index)
                            Configuraciones.RellenarGrillasAutomatico(Dtgconten, debe, haber);

                    }
                }
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
                int FilaIndex = Dtgconten.CurrentCell.RowIndex;
                int ColumnaIndex = Dtgconten.CurrentCell.ColumnIndex;
                //para Sumatoria del Debe y Haber
                if (FilaIndex >= 0 && ColumnaIndex > 2)
                {
                    double aux = Convert.ToDouble(Dtgconten[ColumnaIndex, FilaIndex].Value.ToString());
                    Dtgconten[ColumnaIndex, FilaIndex].Value = string.Format("{0:N2}", aux);
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
        public void CargarDatos()
        {
            Txtbusca_TextChanged(new object { }, new EventArgs());
        }
        public int tipobusca = 0;
        private void Txtbusca_TextChanged(object sender, EventArgs e)
        {
            if (ListoParaBuscar)
            {
                if (fechaini.Value < fechafin.Value)
                {
                    if (!chkPulser.Checked)
                    {
                        //Forma Normal
                        dtgbusca.DataSource = CapaLogica.ListarAsientosContables(Txtbusca.EstaLLeno() ? Txtbusca.Text : "", tipobusca, fechaini.Value, fechafin.Value, fechacheck, _idempresa);
                    }
                    else dtgbusca.DataSource = CapaLogica.ListarAsientosFiltrados(_idempresa, dtpfechaini.Value > dtpfechafin.Value ? dtpfechafin.Value : dtpfechaini.Value, dtpfechaini.Value < dtpfechafin.Value ? dtpfechafin.Value : dtpfechaini.Value,
                       txtbuscuo.TextValido(), txtbuscuenta.TextValido(), txtbusGlosa.TextValido(), txtbusSuboperacion.TextValido());
                }
                else
                {
                    if (!chkPulser.Checked)
                    {
                        //Forma Normal
                        dtgbusca.DataSource = CapaLogica.ListarAsientosContables(Txtbusca.EstaLLeno() ? Txtbusca.Text : "", tipobusca, fechafin.Value, fechaini.Value, fechacheck, _idempresa);
                    }
                    else dtgbusca.DataSource = CapaLogica.ListarAsientosFiltrados(_idempresa, dtpfechaini.Value > dtpfechafin.Value ? dtpfechafin.Value : dtpfechaini.Value, dtpfechaini.Value < dtpfechafin.Value ? dtpfechafin.Value : dtpfechaini.Value,
                        txtbuscuo.TextValido(), txtbuscuenta.TextValido(), txtbusGlosa.TextValido(), txtbusSuboperacion.TextValido());
                }
                msg2(dtgbusca);
                if (dtgbusca.RowCount < 1)
                {
                    if (Dtgconten.DataSource != null)
                        Dtgconten.DataSource = ((DataTable)Dtgconten.DataSource).Clone();
                }
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
            btnreversa.Enabled = false;
            _EsModificable = false;
            if (e.RowIndex >= 0)
            {
                int[] Val = new int[] { -4, -5 };
                if (!Val.Contains(int.Parse(dtgbusca[Iddinamica.Name, e.RowIndex].Value.ToString()))) btnreversa.Enabled = true;
                int y = e.RowIndex;
                dtgayuda3.DataSource = CapaLogica.BuscarAsientosContables(dtgbusca[idx.Name, y].Value.ToString(), 4, _idempresa);
                if (dtgayuda3.RowCount > 0)
                {
                    dtpfecha.Value = Convert.ToDateTime(dtgbusca[Fechax.Name, e.RowIndex].Value);
                    //dtfechavalor.Value = Convert.ToDateTime(dtgbusca[8, e.RowIndex].Value.ToString() == "" ? fecha.Value : dtgbusca[8, e.RowIndex].Value);

                    dinamica = int.Parse(dtgbusca[Iddinamica.Name, e.RowIndex].Value.ToString());
                    if (dinamica >= 0 || dinamica == -21) _EsModificable = true;
                    cboestado.Text = dtgbusca[nameestado.Name, e.RowIndex].Value.ToString();
                    txtdinamica.Text = "DC_00" + dinamica;
                    ////selecciono la empresa
                    //if (dtgbusca[empresax.Name, y].Value.ToString() != "")
                    //    cboempresa.SelectedValue = (int)dtgbusca[empresax.Name, y].Value;
                    //else cboempresa.SelectedIndex = -1;

                    ////selecciono el proyecto al que apunta el asiento
                    if (dtgbusca[proyectox.Name, y].Value.ToString() != "")
                        cboproyecto.SelectedValue = (int)dtgbusca[proyectox.Name, y].Value;
                    else cboproyecto.SelectedItem = -1;
                    ////selecciono la etapa a la que apunta el asiento 
                    cboetapa.SelectedValue = (int)dtgbusca[etapax.Name, y].Value;

                    if (dtgbusca[fechavalorx.Name, y].Value.ToString() == "")
                    {
                        //chkfechavalor.Checked = false;
                        dtpfechavalor.Value = (DateTime)dtgbusca[Fechax.Name, y].Value;
                    }
                    else
                    { //chkfechavalor.Checked = true; 
                        dtpfechavalor.Value = (DateTime)dtgbusca[fechavalorx.Name, y].Value;
                    }
                    activo = pasivo = 0;
                    //int i = 0;
                    ///sacamos la fecha valor y emision del asiento
                    DateTime fechita;
                    //if (chkfechavalor.Checked)
                    fechita = dtpfechavalor.Value;
                    //else fechita = dtpfecha.Value;
                    txtcuo.Text = dtgbusca[Codidasiento.Name, y].Value.ToString();
                    txtcodigo.Text = decimal.Parse(txtcuo.Text.Substring(5)).ToString();
                    ////valores del asiento
                    txtglosa.Text = dtgbusca[xglosa.Name, e.RowIndex].Value.ToString();
                    cbomoneda.SelectedValue = (int)(dtgbusca[xmoneda.Name, e.RowIndex].Value.ToString() == "" ? 0 : dtgbusca[xmoneda.Name, e.RowIndex].Value);
                    ///fin
                    DataTable Datos = CapaLogica.BuscarAsientosContablesconTodo(dtgbusca[idx.Name, y].Value.ToString(), 4, _idempresa, fechita);
                    Dtgconten.DataSource = Datos;
                    ///Reviso si el Asiento esta Cuadrado
                    string[] ListaEstados = { "4", "0" };
                    if (estado == -1) { if (!ListaEstados.Contains(cboestado.SelectedValue.ToString())) RevisarSihayDescuadre(); }
                    else labelCuadre.Text = "";
                    txttipocambio.Text = (dtgbusca[xtc.Name, e.RowIndex].Value.ToString() == "" ? 0.0m : (decimal)dtgbusca[xtc.Name, e.RowIndex].Value).ToString("n4");
                    foreach (DataGridViewRow item in Dtgconten.Rows)
                    {
                        BusquedaCuenta = false;
                        //sumas
                        activo += Convert.ToDecimal(item.Cells[debe.Name].Value);
                        pasivo += Convert.ToDecimal((item.Cells[haber.Name].Value));
                        PintardeCOloresFila(item);
                    }

                    txtdiferencia.Text = (activo - pasivo).ToString("n2");
                    txttotaldebe.Text = activo.ToString("n2");
                    txttotalhaber.Text = pasivo.ToString("n2");
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
        public void RevisarSihayDescuadre()
        {
            DataTable Tdatos = CapaLogica.VerificarCuadredeAsiento(txtcuo.Text, (int)cboproyecto.SelectedValue);
            labelCuadre.Click -= LabelCuadre_Click;
            labelCuadre.Text = "";
            decimal pen = Math.Abs(((decimal)Tdatos.Rows[0]["pen"]));
            decimal usd = Math.Abs(((decimal)Tdatos.Rows[0]["usd"]));
            if (estado == -1 && (pen + usd) != 0)
                if (Tdatos.Rows.Count > 0)
                {
                    if ((usd < 1 & pen < 1) && (usd >= 0 && pen >= 0) && (usd + pen != 0))
                    {
                        if (estado == -1)
                        {
                            DateTime Fechita = dtpfechavalor.Value;
                            CapaLogica.CuadrarAsiento(txtcuo.Text, (int)cboproyecto.SelectedValue, Fechita, 1);
                            CuoSelec = txtcuo.Text;
                            //btnActualizar_Click(new object { }, new EventArgs());
                            RefrescarAsientoSeleccionado();
                        }
                    }
                    else if (((decimal)Tdatos.Rows[0]["pen"] + (decimal)Tdatos.Rows[0]["usd"]) != 0)
                    {
                        decimal mPen = (decimal)Tdatos.Rows[0]["pen"];
                        decimal mUsd = (decimal)Tdatos.Rows[0]["usd"];
                        labelCuadre.Text = $"Descuadre: Soles:{mPen}, Dolares:{mUsd}, Click para Revisar!";
                        //MSG($"Se Encontro un Descuadre\nDescuadre: Soles:{ mPen}, Dolares: { mUsd}");
                        frmCuadreAsientos frmcuadre = new frmCuadreAsientos($"Descuadre: Soles:{ mPen}, Dolares: { mUsd}");
                        if (frmcuadre.ShowDialog() == DialogResult.OK)
                        {
                            DateTime Fechita = dtpfechavalor.Value;
                            ///ajuste por redondeo
                            if (frmcuadre.Resultado == 1)
                            {
                                CapaLogica.CuadrarAsiento(txtcuo.Text, (int)cboproyecto.SelectedValue, Fechita, 1);
                                RefrescarAsientoSeleccionado();
                                labelCuadre.Text = "";
                            }
                            ///ajuste por tipo de cambio
                            if (frmcuadre.Resultado == 2)
                            {
                                CapaLogica.CuadrarAsiento(txtcuo.Text, (int)cboproyecto.SelectedValue, Fechita, 2);
                                RefrescarAsientoSeleccionado();
                                labelCuadre.Text = "";
                            }
                        }
                        labelCuadre.Click += LabelCuadre_Click;
                    }
                }
            estado = 0;
        }
        private void LabelCuadre_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                RevisarSihayDescuadre();
                //if (msgP("¿Desea Cuadrar El Asiento?") == DialogResult.Yes)
                //{
                //    //DateTime Fechita = chkfechavalor.Checked ? dtfechavalor.Value : dtpfecha.Value;
                //    DateTime Fechita = dtpfechavalor.Value;
                //    CapaLogica.CuadrarAsiento(txtcuo.Text, (int)cboproyecto.SelectedValue, Fechita, 1);
                //    MSG("El Asiento se Cuadró!");
                //    cuo = txtcuo.Text;
                //    btnActualizar_Click(sender, e);
                //}
            }
            else MSG("Cancele la Modificación para Cuadrar Asiento");
        }
        public void PintardeCOlores()
        {
            foreach (DataGridViewRow item in Dtgconten.Rows)
            {
                if (item.Cells[EstadoCuen.Name].Value != null)
                    if (item.Cells[EstadoCuen.Name].Value.ToString() == "3")
                    {
                        item.DefaultCellStyle.ForeColor = Configuraciones.RojoUI;
                        item.DefaultCellStyle.SelectionForeColor = Configuraciones.RojoUISelect;
                    }
                if (item.Cells[detallex.Name].Value != null)
                    if (int.Parse(item.Cells[detallex.Name].Value.ToString() == "" ? "0" : item.Cells[detallex.Name].Value.ToString()) > 0 && item.Cells[EstadoCuen.Name].Value.ToString() != "3")
                    {
                        item.DefaultCellStyle.ForeColor = Configuraciones.ColorBien;
                        item.DefaultCellStyle.SelectionForeColor = Configuraciones.ColorBienSeleccionadas;
                    }
            }
        }
        public void PintardeCOloresFila(DataGridViewRow item)
        {
            if (item.Cells[EstadoCuen.Name].Value != null)
                if (item.Cells[EstadoCuen.Name].Value.ToString() == "3")
                {
                    item.DefaultCellStyle.ForeColor = Configuraciones.RojoUI;
                    item.DefaultCellStyle.SelectionForeColor = Configuraciones.RojoUISelect;
                    item.Cells[debe.Name].Style.ForeColor = Configuraciones.RojoUI;
                    item.Cells[haber.Name].Style.ForeColor = Configuraciones.RojoUI;
                    item.Cells[debe.Name].Style.SelectionForeColor = Configuraciones.RojoUISelect;
                    item.Cells[haber.Name].Style.SelectionForeColor = Configuraciones.RojoUISelect;
                }
            if (item.Cells[detallex.Name].Value != null)
                if (int.Parse(item.Cells[detallex.Name].Value.ToString() == "" ? "0" : item.Cells[detallex.Name].Value.ToString()) > 0 && item.Cells[EstadoCuen.Name].Value.ToString() != "3")
                {
                    item.DefaultCellStyle.ForeColor = Configuraciones.ColorBien;
                    item.DefaultCellStyle.SelectionForeColor = Configuraciones.ColorBienSeleccionadas;
                    item.Cells[debe.Name].Style.ForeColor = Configuraciones.ColorBien;
                    item.Cells[haber.Name].Style.ForeColor = Configuraciones.ColorBien;
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
            tablita.Rows.Add(new object[] { "4", "Reversado" });
            combito.DataSource = tablita;
            combito.DisplayMember = "VALOR";
            combito.ValueMember = "CODIGO";
        }
        private void cboestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if ((cboestado.SelectedValue==null?"0":cboestado.SelectedValue.ToString()) == "3") cboestado.SelectedIndex = -1;
        }
        private int _estado = 0;
        public int estado
        {
            get { return _estado; }
            set
            {
                _estado = value;
                if (value != 0)
                {
                    labelCuadre.Text = "";
                }
            }
        }
        public int codigo;
        public void ultimoasiento()
        {
            DataTable tablita = new DataTable();
            DateTime _FechaValida;
            //if (chkfechavalor.Checked)
            _FechaValida = dtpfechavalor.Value;
            //else _FechaValida = dtpfecha.Value;
            tablita = CapaLogica.UltimoAsiento((int)(cboempresa.SelectedValue ?? _idempresa), _FechaValida);
            DataRow filas = tablita.Rows[0];
            if (filas.ItemArray[0] != DBNull.Value)
            {
                codigo = Convert.ToInt32(filas["codigo"]);
            }
            else { codigo = 1; }
            ////Asignacion de codigos
            txtcodigo.Text = codigo.ToString("000");
            txtcuo.Text = ValorCuo(_FechaValida, codigo);
        }
        public string ValorCuo(DateTime _Fecha, int _codigo)
        {
            string valor = "";
            valor = HPResergerFunciones.Utilitarios.Cuo(_codigo, _Fecha);
            return valor;
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            desactivar();
            Dtgconten.DataSource = ((DataTable)Dtgconten.DataSource).Clone();
            txtdinamica.Text = "";
            txtcodigo.Text = codigo + "";
            txttotaldebe.Text = txttotalhaber.Text = txtdiferencia.Text = "0.00";
            dtpfechavalor.Enabled = dtpfecha.Enabled = true;
            dtpfechavalor.Value = dtpfecha.Value = DateTime.Now;
            btnActualizar.Enabled = false;
            //chkfechavalor.Enabled = true;
            cboestado.SelectedIndex = 0;
            ultimoasiento();
            ///limpieza de valores
            txtglosa.CargarTextoporDefecto(); cbomoneda.SelectedIndex = 0; txttipocambio.CargarTextoporDefecto();
            cbocambio.SelectedIndex = -1;
            cbocambio.SelectedIndex = 1;
            cboempresa.Enabled = true;
            SacarTipoCambio();
            // cboproyecto.SelectedIndex = cboproyecto.Items.Count - 1;
        }
        public Boolean modifico;
        public int dinamimodi;
        DataTable TableAux;
        DateTime _FechaAModificar;
        int _CodigoModificar;
        int _ProyectoModificar;
        Boolean _EsModificable;
        public void LimpiarParaEditar(Boolean a)
        {
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            int IdentificadorDinamica = int.Parse(dtgbusca[Iddinamica.Name, dtgbusca.CurrentCell.RowIndex].Value.ToString());
            if (IdentificadorDinamica == -20)
            {
                //MSG("Este Asiento no se Puede Modificar\nEs Asiento de Carga");
                //return;
            }
            else if (IdentificadorDinamica < 0)
            {
                MSG("Este Asiento no se Puede Modificar\nEs Automático");
                return;
            }
            /////PROCESO DE EDICION SI NO ES AUTOMATICO
            //if (chkfechavalor.Checked)
            _FechaAModificar = dtpfechavalor.Value;
            //else _FechaAModificar = dtpfecha.Value;
            _CodigoModificar = int.Parse(txtcodigo.Text);
            _ProyectoModificar = (int)cboproyecto.SelectedValue;

            if (cboestado.SelectedValue.ToString() == "1")
            {
                /////CAMBIAR POR ADMIN
                if (frmLogin.Usuario != "AGUA")
                {
                    if (Dtgconten.RowCount <= 0) { MSG("No Hay Datos"); return; }
                    estado = 2;
                    dinamimodi = int.Parse(dtgbusca[Iddinamica.Name, dtgbusca.CurrentRow.Index].Value.ToString());
                    modifico = false;
                    desactivar();
                    //Dtgconten.ReadOnly = true;
                    btnmas.Focus();
                    //chkfechavalor.Enabled = true;
                    btnActualizar.Enabled = false;
                    dtpfecha.Enabled = true;
                    cboempresa.Enabled = false;
                }
                else
                {
                    if (msgP("Este Asiento NO se puede Modificar, Solicite a su jefe que habilite la Edición del Asiento.\n¿Desea Solicitar Modificación?") == DialogResult.Yes)
                    {
                        TableAux = CapaLogica.ListarJefeInmediato(frmLogin.CodigoUsuario, "", 10);
                        if (TableAux.Rows.Count > 0)
                        {
                            DataRow filita = TableAux.Rows[0];
                            //filita[codigo].ToString();
                            //Enviando al Jefe la Acción
                            string cade = "";
                            string fechamodi = $"{Configuraciones.ToFechaSql(_FechaAModificar)}";
                            string sql = $"update TBL_Asiento_Contable set Estado=2 where Id_Asiento_Contable={txtcodigo.Text} and id_proyecto={cboproyecto.SelectedValue} and cast(ISNULL(Fecha_Asiento_Valor,Fecha_Asiento) as date)='{fechamodi}' and estado!=3";
                            //"UPDATE x SET  x.Saldo_Debe = x.Saldo_Debe - v.debe, x.Saldo_Haber = x.Saldo_Haber - v.haber, x.Saldo_Fin = x.Saldo_Inicio + x.Saldo_Debe - v.debe - (x.Saldo_Haber - v.haber) FROM TBL_Saldos_Contable x " +
                            //" INNER JOIN  ( SELECT SUM(i.Saldo_Debe) AS debe, SUM(i.Saldo_Haber) AS haber, i.Fecha_Asiento_Valor, i.Fecha_Asiento, i.Cuenta_Contable, i.id_proyecto, p.Id_Empresa FROM TBL_Asiento_Contable AS i  INNER JOIN TBL_Proyecto AS p ON i.id_proyecto = p.Id_Proyecto " +
                            //" WHERE i.Id_Asiento_Contable = @Codigo AND i.id_proyecto = @Proyecto GROUP BY Cuenta_Contable, Fecha_Asiento_Valor, Fecha_Asiento, i.id_proyecto, p.Id_Empresa) v ON x.Anio = YEAR(isnull(v.Fecha_Asiento_Valor, v.Fecha_Asiento)) " +
                            //" AND x.Mes = MONTH(isnull(v.Fecha_Asiento_Valor, v.Fecha_Asiento)) AND x.Cuenta_Contable = v.Cuenta_Contable AND x.EMPRESA = v.Id_Empresa ";
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
                Dtgconten.ReadOnly = true;
                btnmas.Focus();
                //chkfechavalor.Enabled = true;
                btnActualizar.Enabled = false;
                cbocambio.SelectedIndex = 0;
                ////si esta en modificar
                if (cboestado.SelectedValue.ToString() == "2") dtpfecha.Enabled = true;
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
                    if (int.Parse(item.Cells[SolicitaDetallex.Name].Value.ToString()) > int.Parse(item.Cells[detallex.Name].Value.ToString() == "" ? "0" : item.Cells[detallex.Name].Value.ToString()))
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
            catch { salida = false; }
        }
        public Boolean salida { get; set; }
        public Boolean aceptar { get; set; }
        public int ESTADO { get; set; }
        public DateTime FECHA { get; set; }
        public int DINAMICA { get; set; }
        public bool ListoParaBuscar { get; private set; }
        public bool BuscarEmpresa { get; private set; }

        public void CArgarValoresIngreso()
        {
            ESTADO = Convert.ToInt32(cboestado.SelectedValue.ToString());
            FECHA = dtpfecha.Value;
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
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
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
            if (cbomoneda.SelectedIndex < 0)
            {
                MSG("Seleccione Moneda");
                cbomoneda.Focus();
                return;
            }
            if (decimal.Parse(txttipocambio.Text) == 0)
            {
                MSG("Seleccione Tipo de Cambio\nNo se Acepta Cero");
                cbocambio.Focus();
                return;
            }
            //validamos la glosa
            if (!txtglosa.EstaLLeno())
            {
                MSG("Ingrese la Glosa del Asiento");
                txtglosa.Focus();
                return;
            }
            if (decimal.Parse(txttipocambio.TextValido()) == 0) { msg("El Tipo de Cambio debe ser Mayor a Cero"); txttipocambio.Focus(); return; }
            if (!CapaLogica.VerificarPeriodoAbierto((int)cboempresa.SelectedValue, dtpfechavalor.Value))
            {
                msg("El Periodo Esta Cerrado, Cambie Fecha Contable"); dtpfechavalor.Focus(); return;
            }
            btnmas_Click(sender, e);
            validar();
            aceptar = true;
            if (salida)
            {
                //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones  
                if (estado == 1 && Dtgconten.RowCount > 1)
                {
                    ultimoasiento();
                    //string cadena = "";
                    if (txtdinamica.Text.Length <= 0) txtdinamica.Text = "CD_000";
                    CArgarValoresIngreso();
                    // MostrarValores(cadena + Detalle(), codigo);
                    for (int i = 0; i < Dtgconten.RowCount; i++)
                    {
                        DateTime? fechita;
                        //if (chkfechavalor.Checked)
                        fechita = dtpfechavalor.Value;
                        //else fechita = null;
                        CapaLogica.InsertarAsiento((int)Dtgconten[IDASIENTOX.Name, i].Value, codigo, FECHA, Dtgconten[cuenta.Name, i].Value.ToString(), Convert.ToDouble(Dtgconten[debe.Name, i].Value.ToString()), Convert.ToDouble(Dtgconten[haber.Name, i].Value.ToString()), DINAMICA, ESTADO, fechita, (int)cboproyecto.SelectedValue, (int)cboetapa.SelectedValue, txtglosa.TextValido(), (int)cbomoneda.SelectedValue, decimal.Parse(txttipocambio.Text == "" ? txttipocambio.TextoDefecto : txttipocambio.Text));
                    }
                    DateTime Feccc;
                    //if (chkfechavalor.Checked)
                    Feccc = dtpfechavalor.Value;
                    //else Feccc = dtpfecha.Value;
                    //Limpieza de Detalle de Asientos Basura
                    CapaLogica.LimpiezaDetalleAsientos(ValorCuo(Feccc, codigo), (int)(cboproyecto.SelectedValue));
                    CuoSelec = ValorCuo(Feccc, codigo);
                    MSG($"Se Insertó Asiento: {CuoSelec} con Exito");
                    //Txtbusca.Text = codigo + "";
                    //dtgbusca.DataSource = CapaLogica.BuscarAsientosContables(Txtbusca.Text, 1, _idempresa);

                    activar();
                    estado = 0;
                    btnActualizar_Click(new object { }, new EventArgs());
                    Boolean busca = false;
                    foreach (DataGridViewRow item in dtgbusca.Rows)
                        if (item.Cells[Codidasiento.Name].Value.ToString() == CuoSelec)
                        {
                            dtgbusca.CurrentCell = dtgbusca[Codidasiento.Name, item.Index]; busca = true; break;
                        }
                    if (busca)
                        RefrescarAsientoSeleccionado();
                }
                else
                {
                    ///PROCESO DE MODIFICACION!
                    if (estado == 2 && Dtgconten.RowCount > 1)
                    {
                        DateTime FechaAsiento;
                        //if (chkfechavalor.Checked) 
                        FechaAsiento = dtpfechavalor.Value;
                        //else FechaAsiento = dtpfecha.Value;
                        if (!ValidarMismoPeriodo(_FechaAModificar, FechaAsiento)) { MSG("No se Puede Mover a Otro Periodo"); return; }
                        ////codigo para reversar solo estado del asiento
                        //CapaLogica.ReversarAsientosSoloEstado(int.Parse(txtcodigo.Text), (int)cboproyecto.SelectedValue, _FechaAModificar);
                        //string cadena = "";
                        codigo = Convert.ToInt32(txtcodigo.Text.ToString());
                        CArgarValoresIngreso();
                        //MostrarValores(cadena + Detalle(), codigo);
                        ////ELIMINA EL ASIENTO ANTERIOR
                        CapaLogica.AsientoContableEliminar(_CodigoModificar, _ProyectoModificar, _FechaAModificar);
                        //Mensajes("Codigo:" + codigo + " Filas;" + Dtgconten.RowCount);
                        foreach (DataGridViewRow item in Dtgconten.Rows)
                        {
                            if (item.Cells[EstadoCuen.Name].Value.ToString() != "3")
                                item.Cells[EstadoCuen.Name].Value = cboestado.SelectedValue.ToString();
                        }
                        ////Actualizar el cambio de id -proyecto - fechas                       
                        CapaLogica.ActualizarDetalleAsiento(_CodigoModificar, _ProyectoModificar, _FechaAModificar, codigo, (int)cboproyecto.SelectedValue, FechaAsiento);
                        ////CapaLogica.ActualizarDetalleAsientoCambioPeriodo(_CodigoModificar, _ProyectoModificar, _FechaAModificar, codigo, (int)cboproyecto.SelectedValue, FechaAsiento);
                        ////PROCESO DE GUARDADO 
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
                            //if (chkfechavalor.Checked)
                            fechitas = dtpfechavalor.Value;
                            //else fechitas = null;
                            if (modifico)
                                CapaLogica.InsertarAsiento(int.Parse(Dtgconten[IDASIENTOX.Name, i].Value.ToString()), codigo, FECHA, Dtgconten[cuenta.Name, i].Value.ToString(), Convert.ToDouble(Dtgconten[debe.Name, i].Value.ToString()), Convert.ToDouble(Dtgconten[haber.Name, i].Value.ToString()), DINAMICA, ESTADO, fechitas, (int)cboproyecto.SelectedValue, (int)cboetapa.SelectedValue, txtglosa.TextValido(), (int)cbomoneda.SelectedValue, decimal.Parse(txttipocambio.Text == "" ? txttipocambio.TextoDefecto : txttipocambio.Text));
                            else
                                CapaLogica.InsertarAsiento(int.Parse(Dtgconten[IDASIENTOX.Name, i].Value.ToString()), codigo, FECHA, Dtgconten[cuenta.Name, i].Value.ToString(), Convert.ToDouble(Dtgconten[debe.Name, i].Value.ToString()), Convert.ToDouble(Dtgconten[haber.Name, i].Value.ToString()), dinamimodi, ESTADO, fechitas, (int)cboproyecto.SelectedValue, (int)cboetapa.SelectedValue, txtglosa.TextValido(), (int)cbomoneda.SelectedValue, decimal.Parse(txttipocambio.Text == "" ? txttipocambio.TextoDefecto : txttipocambio.Text));
                        }
                        DateTime Feccc;
                        //if (chkfechavalor.Checked) 
                        Feccc = dtpfechavalor.Value;
                        //else Feccc = dtpfecha.Value;
                        //Limpieza de Detalle de Asientos Basura
                        CapaLogica.LimpiezaDetalleAsientos(ValorCuo(Feccc, codigo), (int)(cboproyecto.SelectedValue));
                        CuoSelec = ValorCuo(Feccc, codigo);
                        MSG($"Se Modificó Asiento: {CuoSelec} con Exito");

                        //Txtbusca.Text = codigo + "";
                        //dtgbusca.DataSource = CapaLogica.BuscarAsientosContables(Txtbusca.Text, 1, _idempresa);

                        activar();
                        estado = 0;
                        dtpfecha.Enabled = false;
                        RefrescarAsientoSeleccionado();
                        btnActualizar_Click(new object { }, new EventArgs());
                    }
                    else
                    {
                        if (estado == 3)
                        {
                            codigo = Convert.ToInt32(txtcodigo.Text.ToString());
                            DateTime Feccc;
                            //if (chkfechavalor.Checked)
                            Feccc = dtpfechavalor.Value;
                            //else Feccc = dtpfecha.Value;
                            if (msgp($"Seguró Desea Eliminar; Asiento Contable: {ValorCuo(Feccc, codigo)}") == DialogResult.Yes)
                            {
                                DateTime FechaAsiento;
                                //if (chkfechavalor.Checked) 
                                FechaAsiento = dtpfechavalor.Value;
                                //else FechaAsiento = dtpfecha.Value;
                                CapaLogica.EliminarAsiento(int.Parse(txtcodigo.Text), (int)cboproyecto.SelectedValue, FechaAsiento);
                                MSG($"Eliminado Exitosamente: {ValorCuo(Feccc, codigo)}");
                                //Txtbusca.Text = "";
                                //dtgbusca.DataSource = CapaLogica.BuscarAsientosContables(Txtbusca.Text, 1, _idempresa);
                                //btnActualizar_Click(new object { }, new EventArgs());
                                RefrescarAsientoSeleccionado();
                            }
                            estado = 0;
                        }
                    }
                }
            }
            else { }
            cboempresa.Enabled = true;
            btnActualizar.Enabled = true;
        }

        public Boolean ValidarMismoPeriodo(DateTime FechaOriginal, DateTime FechaFinal)
        {
            if (FechaOriginal.Month == FechaFinal.Month && FechaOriginal.Year == FechaOriginal.Year)
                return true;
            else return false;
        }
        public DialogResult msgp(string cadena)
        {
            return HPResergerFunciones.Utilitarios.msgYesNo(cadena);
        }
        public void BuscarAsiento(string cadena, int empresa, DateTime Fecha)
        {
            cARgarEmpresas();
            Txtbusca.Text = cadena;
            cboempresa.SelectedValue = empresa;
            chkfecha.Checked = true;
            fechaini.Value = fechafin.Value = Fecha;
            //dtgbusca.DataSource = CapaLogica.BuscarAsientosContables(cadena, 1, empresa);
            chkfecha_CheckedChanged(new object { }, new EventArgs());
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
                        //dtgbusca.DataSource = CapaLogica.ListarAsientosContables("", 1, DateTime.Today, DateTime.Today, 0, _idempresa);
                        CargarDatos();
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
                            //dtgbusca.DataSource = CapaLogica.ListarAsientosContables("", 1, DateTime.Today, DateTime.Today, 0, _idempresa);
                            CargarDatos();
                            Txtbusca.Enabled = true;
                            dtgbusca.Focus();
                            dtpfecha.Enabled = false;
                            btnActualizar.Enabled = true;
                        }
                        else { Dtgconten.BeginEdit(true); }
                    }
                    else
                    {
                        estado = 0;
                        activar();
                        //dtgbusca.DataSource = CapaLogica.BuscarAsientosContables(Txtbusca.Text, 1);
                        //dtgbusca.DataSource = CapaLogica.ListarAsientosContables("", 1, DateTime.Today, DateTime.Today, 0, _idempresa);
                        CargarDatos();
                        Txtbusca.Enabled = true;
                        dtgbusca.Focus(); btnActualizar.Enabled = true;
                    }
                }
            }
            cboempresa.Enabled = true;
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = 3;
            btnaceptar_Click(sender, e);
        }
        private void Dtgconten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && (estado == 1 || estado == 2))
            {
                if (MessageBox.Show("Desea Borrar esta fila", CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Dtgconten.CurrentCell != null)
                    {
                        Dtgconten.Rows.RemoveAt(Dtgconten.CurrentCell.RowIndex);
                        Sumatoria();
                    }
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
            //if (dtgbusca.Rows.Count > 0)
            //{
            //    if (dtgbusca.CurrentCell.RowIndex >= 0)
            //    {
            //        if (e.KeyCode == Keys.Down)
            //        {
            //            //Tecla para Abajo
            //            int x = dtgbusca.CurrentCell.RowIndex;
            //            int cox = 0;
            //            cox = (int)dtgbusca[0, x].Value;
            //            for (int i = x; i < dtgbusca.RowCount; i++)
            //            {
            //                //Buscar Siguiente Codigo de Asiento;
            //                if (cox != (int)dtgbusca[0, i].Value)
            //                {
            //                    dtgbusca.CurrentCell = dtgbusca[0, i - 1];
            //                    break;
            //                }
            //            }
            //        }
            //        if (e.KeyCode == Keys.Up)
            //        {
            //            int x = dtgbusca.CurrentCell.RowIndex;
            //            int cox = 0;
            //            cox = (int)dtgbusca[0, x].Value;
            //            for (int i = x; i > 0; i--)
            //            {
            //                //Buscar Siguiente Codigo de Asiento; 
            //                {
            //                    dtgbusca.CurrentCell = dtgbusca[0, i];
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //}
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string cuoI = CuoSelec;
            int pos = 0;
            //if (dtgbusca.RowCount > 0) pos = dtgbusca.CurrentRow.Index;
            //Txtbusca.Text = "";
            Txtbusca_TextChanged(sender, e);
            /////
            foreach (DataGridViewRow item in dtgbusca.Rows)
            {
                if (item.Cells[Codidasiento.Name].Value.ToString() == cuoI) { pos = item.Index; break; }
            }
            if (dtgbusca.RowCount > pos)
                dtgbusca.CurrentCell = dtgbusca[Codidasiento.Name, pos];
        }
        private void dtgayuda3_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Dtgconten_CellEndEdit(sender, e);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (estado == 1)
            //{
            //    if (chkfechavalor.Checked)
            //    {
            //        dtfechavalor.Enabled = true;
            //        dtpfecha.Enabled = false;
            //    }
            //    else
            //    {
            //        dtfechavalor.Enabled = false;
            //        dtpfecha.Enabled = true;
            //    }
            //    ultimoasiento();
            //    SacarTipoCambio();
            //}
        }
        private void cboempresa_Enter(object sender, EventArgs e)
        {

        }
        public int _idempresa = 0;
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BuscarEmpresa)
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
            HPResergerFunciones.Utilitarios.msg(v);
        }
        private DialogResult msgP(string v)
        {
            return HPResergerFunciones.Utilitarios.msgYesNo(v);
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
            //Sumatoria();+
        }
        private void Dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (Dtgconten[detallex.Name, e.RowIndex].Value != null)
                {
                    lbldetalle.Text = "Detalle: " + Dtgconten[detallex.Name, e.RowIndex].Value.ToString();
                    RevisarDetalleCuadrado(Dtgconten.Rows[e.RowIndex]);
                }
        }
        public void RevisarDetalleCuadrado(DataGridViewRow item)
        {
            DataTable Tdatos = new DataTable();
            DateTime fechita;
            //if (chkfechavalor.Checked) 
            fechita = dtpfechavalor.Value;
            //else fechita = dtpfecha.Value;
            if (item.Cells[IDASIENTOX.Name].Value.ToString() != "")
            {
                Tdatos = CapaLogica.DetalleAsientos(9, (int)item.Cells[IDASIENTOX.Name].Value, int.Parse(txtcodigo.Text), (int)cboproyecto.SelectedValue, fechita, "");
                if (cbomoneda.SelectedValue != null && Tdatos.Rows.Count > 0)
                    if ((decimal)item.Cells[debe.Name].Value + (decimal)item.Cells[haber.Name].Value != ((int)cbomoneda.SelectedValue == 1 ? (decimal)Tdatos.Rows[0]["pen"] : (decimal)Tdatos.Rows[0]["usd"]))
                    {
                        if ((int)item.Cells[IDASIENTOX.Name].Value < 1000)
                        {
                            if ((decimal)Tdatos.Rows[0]["pen"] + (decimal)Tdatos.Rows[0]["usd"] != 0)
                            {
                                item.Cells[debe.Name].Style.ForeColor = labelAmarillo.ForeColor;
                                item.Cells[haber.Name].Style.ForeColor = labelAmarillo.ForeColor;
                            }
                            else
                            {
                                item.DefaultCellStyle.ForeColor = Color.Black;
                                item.Cells[haber.Name].Style.ForeColor = Color.Black;
                                item.Cells[debe.Name].Style.ForeColor = Color.Black;
                            }
                        }
                        else
                        {
                            PintardeCOloresFila(item);
                        }
                    }
                    else
                        PintardeCOloresFila(item);
            }
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
        private void btnTxt_Click(object sender, EventArgs e)
        {
            MSG("Se va a Reversar");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //No se Pueden reversar Asientos Reversados
            if (dtgbusca[nameestado.Name, dtgbusca.CurrentRow.Index].Value.ToString().ToUpper() == "REVERSADO" || ((int)dtgbusca[Iddinamica.Name, dtgbusca.CurrentRow.Index].Value) == -10)
            {
                HPResergerFunciones.Utilitarios.msg($"Asiento No se Puede Reversar!"); return;
            }
            //Verificio si el Periodo esta Abierto para Proceder con la Anulacion - REversa
            if (!CapaLogica.VerificarPeriodoAbierto((int)cboempresa.SelectedValue, dtpfechavalor.Value))
            {
                msg("El Periodo Esta Cerrado, Cambie Fecha Contable"); dtpfechavalor.Focus(); return;
            }
            if (1 != 1)
            {
                //Proceso de la Reversa
                if (HPResergerFunciones.Utilitarios.msgYesNo($"Seguro Desea Reversar Este Asiento Nro {txtcuo.Text}") == DialogResult.Yes)
                {
                    //Proceso Reversa del Asiento               
                    DataRow Filita = CapaLogica.ReversarAsientos((int.Parse(txtcodigo.Text)), (int)cboproyecto.SelectedValue, frmLogin.CodigoUsuario, dtpfechavalor.Value).Rows[0];
                    if (Filita[0].ToString() == "")
                    {
                        HPResergerFunciones.Utilitarios.msg($"Asiento {txtcuo} Reversado!");
                    }
                    else
                    {
                        HPResergerFunciones.Utilitarios.msg("Mensaje de Error: \n" + Filita[0].ToString());
                        return;
                    }
                }
                btnActualizar_Click(sender, e);
            }
            else
            {
                ModuloContable.frmRevesarAsientos frmReversita = new ModuloContable.frmRevesarAsientos();
                //Paso de Variables
                frmReversita.Glosa = txtglosa.Text;
                frmReversita.Cuo = txtcuo.Text;
                frmReversita.FechaValor = dtpfechavalor.Value;
                frmReversita.FechaEmisionDes = dtpfecha.Value;
                frmReversita.FechaContableDes = dtpfechavalor.Value;
                frmReversita.Codigo = int.Parse(txtcodigo.Text);
                frmReversita.IdEmpresa = (int)cboempresa.SelectedValue;
                frmReversita.IdProyecto = (int)(cboproyecto.SelectedValue);
                //Fin de Paso de Variables
                if (frmReversita.ShowDialog() == DialogResult.OK)
                    btnActualizar_Click(sender, e);
            }
        }
        private void cboestado_TextChanged(object sender, EventArgs e)
        {
            if (cboestado.Text == "Activo") btneliminar.Text = "Desactivar";// else btneliminar.Text = "Activar";
        }
        private void fecha_ValueChanged(object sender, EventArgs e)
        {
            if (estado == 1 || estado == 2)
                SacarTipoCambio();
        }
        private void dtfechavalor_ValueChanged(object sender, EventArgs e)
        {
            if (estado == 1)
                ultimoasiento();
        }
        private void cbomoneda_Click(object sender, EventArgs e)
        {
            string cade = cbomoneda.Text;
            Cargarmoneda();
            cbomoneda.Text = cade;
        }
        private string CuoSelec;
        frmTipodeCambio frmtipo;
        private bool Busqueda;

        public void SacarTipoCambio()
        {
            DateTime FechaValidaBuscar = dtpfecha.Value;
            txttipocambio.Text = CapaLogica.TipoCambioDia("Venta", FechaValidaBuscar).ToString("n4");
            if (decimal.Parse(txttipocambio.Text) == 0)
            {
                if (frmtipo == null)
                {
                    frmtipo = new frmTipodeCambio();
                    frmtipo.ActualizoTipoCambio += Frmtipo_ActualizoTipoCambio;
                    frmtipo.Show();
                    frmtipo.Hide();
                    frmtipo.comboMesAño1.ActualizarMesAÑo(FechaValidaBuscar.Month.ToString(), FechaValidaBuscar.Year.ToString());
                    frmtipo.Buscar_Click(new object(), new EventArgs());
                }
            }
        }
        private void Frmtipo_ActualizoTipoCambio(object sender, EventArgs e)
        {
            frmtipo.Close();
            frmtipo = null;
            SacarTipoCambio();
        }
        private void cbocambio_SelectedIndexChanged(object sender, EventArgs e)
        {
            SacarTipoCambio();
        }
        private void cboempresa_Click_1(object sender, EventArgs e)
        {
            BuscarEmpresa = false;
            string CodText = cboempresa.Text;
            cARgarEmpresas();
            cboempresa.Text = CodText;
            BuscarEmpresa = true;
        }
        private void labelAmarillo_Click(object sender, EventArgs e)
        {

        }

        private void labelRojo_Click(object sender, EventArgs e)
        {

        }

        private void frmAsientoContable_Activated(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                RevisarSihayDescuadre();
            }
        }

        private void Txtbusca_Load(object sender, EventArgs e)
        {

        }

        private void chkPulser_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPulser.Checked)
            {
                Txtbusca.Visible = false;
                radioButton1.Visible = radioButton2.Visible = chkfecha.Visible = fechaini.Visible = fechafin.Visible = false;
                txtbuscuenta.Visible = txtbuscuo.Visible = txtbusGlosa.Visible = txtbusSuboperacion.Visible = dtpfechaini.Visible = dtpfechafin.Visible = true;
                btncleanfind.Visible = lbl1.Visible = lbl2.Visible = true;
            }
            else
            {
                Txtbusca.Visible = true;
                radioButton1.Visible = radioButton2.Visible = chkfecha.Visible = fechaini.Visible = fechafin.Visible = true;
                txtbuscuenta.Visible = txtbuscuo.Visible = txtbusGlosa.Visible = txtbusSuboperacion.Visible = dtpfechaini.Visible = dtpfechafin.Visible = false;
                btncleanfind.Visible = lbl1.Visible = lbl2.Visible = false;

            }
        }

        private void btncleanfind_Click(object sender, EventArgs e)
        {
            txtbuscuo.CargarTextoporDefecto(); txtbusGlosa.CargarTextoporDefecto(); txtbusSuboperacion.CargarTextoporDefecto(); txtbuscuenta.CargarTextoporDefecto();
            dtpfechaini.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfechafin.Value = new DateTime(DateTime.Now.Year, 12, 31);
        }

        private void txtbusSuboperacion_TextChanged(object sender, EventArgs e)
        {
            Txtbusca_TextChanged(sender, e);
        }

        private void txtbusGlosa_TextChanged(object sender, EventArgs e)
        {
            Txtbusca_TextChanged(sender, e);
        }

        private void txtbuscuo_TextChanged(object sender, EventArgs e)
        {
            Txtbusca_TextChanged(sender, e);
        }

        private void dtpfechaini_ValueChanged(object sender, EventArgs e)
        {
            Txtbusca_TextChanged(sender, e);
        }

        private void dtpfechafin_ValueChanged(object sender, EventArgs e)
        {
            Txtbusca_TextChanged(sender, e);
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            if (dtgbusca.RowCount > 0)
            {
                // ModuloCrystalReport.frmReporteListadoAsientos frmReportito = new ModuloCrystalReport.frmReporteListadoAsientos((int)cboempresa.SelectedValue, dtpfechaini.Value, dtpfechafin.Value, txtcuo.Text, txtbuscuenta.TextValido(),
                //txtbusGlosa.TextValido(), txtbusSuboperacion.TextValido(), -1);
                ModuloContable.frmListadoAsientosContables frmReportito = new ModuloContable.frmListadoAsientosContables((int)cboempresa.SelectedValue, txtcuo.Text, dtpfechavalor.Value);
                frmReportito.MdiParent = this.MdiParent;
                frmReportito.Show();
            }
        }

        private void Dtgconten_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //Sumatoria();
            //Dtgconten.CurrentCell = Dtgconten[cuenta.Name, e.RowIndex];
            msg(Dtgconten);
        }
    }
}
