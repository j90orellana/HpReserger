﻿using HpResergerUserControls;
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
        DataTable TDinamica;
        public void Cargarmoneda()
        {
            CapaLogica.TablaMonedas(cbomoneda);
        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void frmAsientoContable_Load(object sender, EventArgs e)
        {
            //System.Globalization.CultureInfo.CreateSpecificCulture("es-ES");
            //Configuraciones del Formulario
            labelAzul.ForeColor = Configuraciones.ColorBien;
            labelRojo.ForeColor = Configuraciones.RojoUI;
            labelAmarillo.ForeColor = Color.Chocolate;
            labelCuadre.ForeColor = Configuraciones.ColorBien;
            Cargarmoneda();
            CargarEmpresas();
            RellenarEstado(cboestado);
            //cargar TExtos por defecto
            CargarValoresDefectoBusquedas();
            //labelAmarillo.ForeColor = Color.FromArgb(247, 125, 0);
            estado = 100; fechacheck = 0;
            tipobusca = 1;
            // DateTime fechita; fechita = dtpfechavalor.Value;
            //Mensajitos
            //Dtgconten.Columns[debe.Name].CellTemplate.ToolTipText = "Presione D para Rellenar";
            //Dtgconten.Columns[haber.Name].CellTemplate.ToolTipText = "Presione D para Rellenar";
            ///      
            activar();
            DateTime FechaPrueba = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            {
                fechaini.Value = FechaPrueba;
                fechafin.Value = (FechaPrueba.AddMonths(1)).AddDays(-1);
            }
            BuscarEmpresa = true;
            //Dtgconten.DataSource = CapaLogica.BuscarAsientosContablesconTodo("0", 4, 1, fechita);
            //dtgbusca.DataSource = CapaLogica.ListarAsientosContables("", 1, DateTime.Today, DateTime.Today, 0, _idempresa);
            //Cambio de Empresa      
            this.Activated -= frmAsientoContable_Activated;

            this.Activated += frmAsientoContable_Activated;
            ListoParaBuscar = true;
            BuscarDatos();
            estado = 0;
            if (dtgbusca.RowCount == 0) desactivar();
        }
        private void CargarValoresDefectoBusquedas()
        {
            Configuraciones.CargarTextoPorDefecto(txtbuscuo, txtbusGlosa, txtbusSuboperacion, txtbuscuenta);
            dtpfechaini.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfechafin.Value = new DateTime(DateTime.Now.Year, 12, 31);
        }

        public void CargarEmpresas()
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
                    TDinamica = CapaLogica.ListarDinamicas(coddinamica + "", 10);
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
                Dtgconten[debe.Name, Dtgconten.RowCount - 1].Value = Dtgconten[haber.Name, Dtgconten.RowCount - 1].Value = 0.00;
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
                                frmdetalle.Glosa = txtglosa.TextValido();
                                frmdetalle.FormClosed += new FormClosedEventHandler(Frmdetalle_FormClosed);
                                frmdetalle.Show();
                            }
                            else frmdetalle.Activate();
                        }
                }
            }
            catch (Exception ex)
            {
                msg(ex.Message);
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
        private void txtdinamica_Leave(object sender, EventArgs e)
        {
            txtdinamica.Text = coddinamica.ToString("DC_000; DC_ - 000; DC_000");
        }
        private void txtdinamica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back) { }
            else { e.Handled = true; }
        }
        public void CargaDinamicas()
        {
            if (TDinamica.Rows.Count > 0)
            {
                DataTable aux = ((DataTable)Dtgconten.DataSource).Clone();
                Dtgconten.DataSource = aux;
                foreach (DataRow item in TDinamica.Rows)
                {
                    //6=CodigoCuenta 7=DescripcionCuenta 8=Debe/Haber //0=CodigoCuenta 1=Descripcion 2=debe 3=haber
                    DataRow filita = aux.NewRow();
                    filita["cod"] = item[6].ToString();
                    filita["cuenta"] = item[7].ToString();
                    filita["detalle"] = 0;
                    filita["solicita"] = 0;
                    filita["estado"] = 1;
                    filita["id"] = Dtgconten.RowCount + 1;
                    filita[debe.Name] = 0.00m;
                    filita[haber.Name] = 0.00m;
                    txtglosa.Text = item["glosa"].ToString();
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
                TDinamica = CapaLogica.ListarDinamicas(coddinamica + "", 10);
                CargaDinamicas();
                btndina.Focus();
            }
        }
        private void Dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    if (BusquedaCuenta)
                    {
                        if (e.RowIndex > -1 && e.ColumnIndex == Dtgconten.Columns[cuenta.Name].Index)
                        { //MODIFICAR LA COLUMNA DE CODIGOS
                          //usp_buscar_cuenta
                            DataTable TCuentas = CapaLogica.BuscarCuentas(Dtgconten[cuenta.Name, e.RowIndex].Value.ToString(), 1);
                            if (TCuentas.Rows.Count == 1)
                            {
                                Dtgconten[descripcion.Name, e.RowIndex].Value = TCuentas.Rows[0][0].ToString();
                                Dtgconten[SolicitaDetallex.Name, e.RowIndex].Value = TCuentas.Rows[0][2].ToString();
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
                    var Result = HPResergerFunciones.frmPregunta.MostrarDialogYesCancel("¿Desea Rellenar Automáticamente?", "Llenará Automáticamente los Montos del Asiento");
                    if (Result == DialogResult.Yes)
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
            string Contador = CapaLogica.ContarCantidadAsientos(_idempresa)["Total"].ToString();
            lblmsg2.Text = $"Total Registros: {conteo.RowCount}/{Contador}";
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
            BuscarDatos();
        }
        public int tipobusca = 0;
        public void BuscarDatos()
        {
            if (Configuraciones.ValidarSQLInyect(txtbuscuenta, txtbuscuo, txtbusGlosa, txtbusSuboperacion)) return;
            if (ListoParaBuscar)
            {
                Cursor = Cursors.WaitCursor;
                if (fechaini.Value < fechafin.Value)
                {
                    if (!chkPulser.Checked)
                    {
                        //Forma Normal
                        dtgbusca.DataSource = CapaLogica.ListarAsientosContables(Txtbusca.EstaLLeno() ? Txtbusca.Text : "", tipobusca, fechaini.Value, fechafin.Value, fechacheck, _idempresa);
                    }
                    else
                    {
                        dtgbusca.DataSource = CapaLogica.ListarAsientosFiltrados(_idempresa, dtpfechaini.Value > dtpfechafin.Value ? dtpfechafin.Value : dtpfechaini.Value,
                            dtpfechaini.Value < dtpfechafin.Value ? dtpfechafin.Value : dtpfechaini.Value, txtbuscuo.TextValido(), txtbuscuenta.TextValido(), txtbusGlosa.TextValido(),
                            txtbusSuboperacion.TextValido());
                    }
                }
                else
                {
                    if (!chkPulser.Checked)
                    {
                        //Forma Normal
                        dtgbusca.DataSource = CapaLogica.ListarAsientosContables(Txtbusca.EstaLLeno() ? Txtbusca.Text : "", tipobusca, fechafin.Value, fechaini.Value, fechacheck, _idempresa);
                    }
                    else
                    {
                        dtgbusca.DataSource = CapaLogica.ListarAsientosFiltrados(_idempresa, dtpfechaini.Value > dtpfechafin.Value ? dtpfechafin.Value : dtpfechaini.Value,
                            dtpfechaini.Value < dtpfechafin.Value ? dtpfechafin.Value : dtpfechaini.Value, txtbuscuo.TextValido(), txtbuscuenta.TextValido(), txtbusGlosa.TextValido(),
                            txtbusSuboperacion.TextValido());
                    }
                }
                msg2(dtgbusca);
                if (dtgbusca.RowCount < 1)
                {
                    if (Dtgconten.DataSource != null)
                        Dtgconten.DataSource = ((DataTable)Dtgconten.DataSource).Clone();
                }
                Cursor = Cursors.Default;
            }
        }
        private void Txtbusca_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Txtbusca.Text = "";
            BuscarDatos();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 1;
            BuscarDatos();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 2;
            BuscarDatos();
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tipobusca = 3;
            BuscarDatos();
        }
        private void fechaini_ValueChanged(object sender, EventArgs e)
        {
            BuscarDatos();
        }
        private void fechafin_ValueChanged(object sender, EventArgs e)
        {
            BuscarDatos();
        }
        public int dinamica { get; set; }
        public decimal activo, pasivo;
        Boolean BusquedaCuenta = true;
        DataTable TAyuda3;
        private void dtgbusca_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //System.Diagnostics.Stopwatch PruebaTime = new System.Diagnostics.Stopwatch();
            //PruebaTime.Start();
            //
            btnreversa.Enabled = false;
            _EsModificable = false;
            if (e.RowIndex >= 0)
            {
                int[] Val = new int[] { -4, -5 };
                if (!Val.Contains(int.Parse(dtgbusca[Iddinamica.Name, e.RowIndex].Value.ToString()))) btnreversa.Enabled = true;
                int y = e.RowIndex;
                TAyuda3 = CapaLogica.BuscarAsientosContables(dtgbusca[Codidasiento.Name, y].Value.ToString(), 4, _idempresa);
                if (TAyuda3.Rows.Count > 0)
                {
                    dtpfecha.Value = Convert.ToDateTime(dtgbusca[Fechax.Name, e.RowIndex].Value);
                    //dtfechavalor.Value = Convert.ToDateTime(dtgbusca[8, e.RowIndex].Value.ToString() == "" ? fecha.Value : dtgbusca[8, e.RowIndex].Value);

                    dinamica = int.Parse(dtgbusca[Iddinamica.Name, e.RowIndex].Value.ToString());
                    if (dinamica >= 0 || dinamica == -21) _EsModificable = true;
                    cboestado.Text = dtgbusca[nameestado.Name, e.RowIndex].Value.ToString();
                    txtdinamica.Text = dinamica.ToString("DC_000;DC_-000;DC_000");
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
                    txtglosa.Text = dtgbusca[xglosa.Name, e.RowIndex].Value.ToString().Trim();
                    cbomoneda.SelectedValue = (int)(dtgbusca[xmoneda.Name, e.RowIndex].Value.ToString() == "" ? 0 : dtgbusca[xmoneda.Name, e.RowIndex].Value);
                    ///fin
                    DataTable Datos = CapaLogica.BuscarAsientosContablesconTodo(dtgbusca[Codidasiento.Name, y].Value.ToString(), 4, _idempresa, fechita);
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
            //HpResergerUserControls.Configuraciones.TiempoEjecucionMsg(PruebaTime);
        }
        public void RevisarSihayDescuadre()
        {
            if (estado == -1 && !(new int[] { -50, -51 }).Contains(dinamica))
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
                                CapaLogica.CuadrarAsiento(txtcuo.Text, (int)cboproyecto.SelectedValue, Fechita, 2);
                                CuoSelec = txtcuo.Text;
                                estado = 0;
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
            else msg("Cancele la Modificación para Cuadrar Asiento");
        }
        public void PintardeCOlores()
        {
            //foreach (DataGridViewRow item in Dtgconten.Rows)
            //{
            //    if (item.Cells[EstadoCuen.Name].Value != null)
            //        if (item.Cells[EstadoCuen.Name].Value.ToString() == "3")
            //        {
            //            item.DefaultCellStyle.ForeColor = Configuraciones.RojoUI;
            //            item.DefaultCellStyle.SelectionForeColor = Configuraciones.RojoUISelect;
            //        }
            //    if (item.Cells[detallex.Name].Value != null)
            //        if (int.Parse(item.Cells[detallex.Name].Value.ToString() == "" ? "0" : item.Cells[detallex.Name].Value.ToString()) > 0 && item.Cells[EstadoCuen.Name].Value.ToString() != "3")
            //        {
            //            item.DefaultCellStyle.ForeColor = Configuraciones.ColorBien;
            //            item.DefaultCellStyle.SelectionForeColor = Configuraciones.ColorBienSeleccionadas;
            //        }
            //}
        }
        public void PintardeCOloresFila(DataGridViewRow item)
        {
            //if (item.Cells[EstadoCuen.Name].Value != null)
            //    if (item.Cells[EstadoCuen.Name].Value.ToString() == "3")
            //    {
            //        item.DefaultCellStyle.ForeColor = Configuraciones.RojoUI;
            //        item.DefaultCellStyle.SelectionForeColor = Configuraciones.RojoUISelect;
            //        item.Cells[debe.Name].Style.ForeColor = Configuraciones.RojoUI;
            //        item.Cells[haber.Name].Style.ForeColor = Configuraciones.RojoUI;
            //        item.Cells[debe.Name].Style.SelectionForeColor = Configuraciones.RojoUISelect;
            //        item.Cells[haber.Name].Style.SelectionForeColor = Configuraciones.RojoUISelect;
            //    }
            //if (item.Cells[detallex.Name].Value != null)
            //    if (int.Parse(item.Cells[detallex.Name].Value.ToString() == "" ? "0" : item.Cells[detallex.Name].Value.ToString()) > 0 && item.Cells[EstadoCuen.Name].Value.ToString() != "3")
            //    {
            //        item.DefaultCellStyle.ForeColor = Configuraciones.ColorBien;
            //        item.DefaultCellStyle.SelectionForeColor = Configuraciones.ColorBienSeleccionadas;
            //        item.Cells[debe.Name].Style.ForeColor = Configuraciones.ColorBien;
            //        item.Cells[haber.Name].Style.ForeColor = Configuraciones.ColorBien;
            //    }
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
                msg("Este Asiento no se Puede Modificar\nEs Automático");
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
                    if (Dtgconten.RowCount <= 0) { msg("No Hay Datos"); return; }
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
                            msgOK("Se ha Enviado la Solicitud a su Jefe");
                        }
                        else { msg("No se Encontró Información de su Jefe"); }
                    }
                }
            }
            else
            {
                if (Dtgconten.RowCount <= 0) { msg("No Hay Datos"); return; }
                estado = 2;
                dinamimodi = Convert.ToInt16(TAyuda3.Rows[0][7].ToString());
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
                    msg(cadena);
                if (totaldebe != totalhaber && salida)
                {
                    salida = false;
                    msg("No debe haber diferencia entre el debe y haber.");
                }
                if (totaldebe == 0 || totalhaber == 0 && salida)
                {
                    salida = false;
                    msg("El Debe y el Haber estan en cero");
                }
            }
            catch (FormatException) { msg("Hay Números Mal Ingresados"); salida = false; }
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
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (cboempresa.SelectedIndex < 0)
            {
                msg("Seleccione Empresa");
                //cboempresa.Focus(); 
                return;
            }
            if (cboproyecto.SelectedIndex < 0)
            {
                msg("Seleccione Proyecto");
                // cboproyecto.Focus();
                return;
            }
            if (cboetapa.SelectedIndex < 0)
            {
                msg("Seleccione Etapa");
                // cboetapa.Focus();
                return;
            }
            if (cbomoneda.SelectedIndex < 0)
            {
                msg("Seleccione Moneda");
                cbomoneda.Focus();
                return;
            }
            if (decimal.Parse(txttipocambio.Text) == 0)
            {
                msg("Seleccione Tipo de Cambio\nNo se Acepta Cero");
                cbocambio.Focus();
                return;
            }

            //validamos la glosa
            if (!txtglosa.EstaLLeno())
            {
                msg("Ingrese la Glosa del Asiento");
                txtglosa.Focus();
                return;
            }
            if (decimal.Parse(txttipocambio.TextValido()) == 0) { msg("El Tipo de Cambio debe ser Mayor a Cero"); txttipocambio.Focus(); return; }
            //Validacion de que el periodo NO sea muy disperso, sea un mes continuo a los trabajados
            int IdEmpresa = (int)cboempresa.SelectedValue;
            DateTime FechaCoontable = dtpfechavalor.Value;
            if (!CapaLogica.ValidarCrearPeriodo(IdEmpresa, FechaCoontable))
            {
                if (msgp("No se Puede Registrar este Asiento\nEl Periodo no puede Crearse", $"¿Desea Crear el Periodo de {FechaCoontable.ToString("MMMM")}-{FechaCoontable.Year}?") != DialogResult.Yes)
                    return;
            }
            else if (!CapaLogica.VerificarPeriodoAbierto((int)cboempresa.SelectedValue, dtpfechavalor.Value))
            {
                msg("El Periodo Esta Cerrado, Cambie Fecha Contable"); dtpfechavalor.Focus(); return;
            }
            btnmas_Click(sender, e);
            validar();
            aceptar = true;
            if (salida)
            {
                //VALIDAMOS QUE NO EXISTAN CUENTAS CONTABLES DESACTIVADAS
                List<string> ListaAuxiliar = new List<string>();
                foreach (DataGridViewRow item in Dtgconten.Rows)
                    ListaAuxiliar.Add(item.Cells[cuenta.Name].Value.ToString());
                if (CapaLogica.CuentaContableValidarActivas(string.Join(",", ListaAuxiliar.ToArray()), Mensajes.CuentasContablesDesactivadas)) return;
                //FIN DE LA VALDIACION DE LAS CUENTAS CONTABLES DESACTIVADAS                
                //Estado 1=Nuevo. Estado 2=modificar. Estado 3=eliminar. Estado 0=SinAcciones  
                if (estado == 1 && Dtgconten.RowCount > 1)
                {
                    //string cadena = "";
                    if (txtdinamica.Text.Length <= 0) txtdinamica.Text = "CD_000";
                    CArgarValoresIngreso();
                    //SACAMOS EL ULTIMO ASIENTO
                    ultimoasiento();
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
                    msgOK($"Se Insertó Asiento: {CuoSelec} con Exito");
                    //Txtbusca.Text = codigo + "";
                    //dtgbusca.DataSource = CapaLogica.BuscarAsientosContables(Txtbusca.Text, 1, _idempresa);

                    activar();
                    estado = 0;
                    Txtbusca.txtbusca.Text = "";
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
                        MismoPeriodo = false;
                        DateTime FechaAsiento;
                        //if (chkfechavalor.Checked) 
                        FechaAsiento = dtpfechavalor.Value;
                        //else FechaAsiento = dtpfecha.Value;
                        //Validamos el mismo periodo
                        if (ValidarMismoPeriodo(_FechaAModificar, FechaAsiento))
                        {
                            MismoPeriodo = true;
                        }
                        ////codigo para reversar solo estado del asiento
                        //CapaLogica.ReversarAsientosSoloEstado(int.Parse(txtcodigo.Text), (int)cboproyecto.SelectedValue, _FechaAModificar);
                        //string cadena = "";
                        codigo = Convert.ToInt32(txtcodigo.Text.ToString());
                        CArgarValoresIngreso();
                        //MostrarValores(cadena + Detalle(), codigo);
                        ////ELIMINA EL ASIENTO ANTERIOR
                        if (MismoPeriodo)
                            CapaLogica.AsientoContableEliminar(_CodigoModificar, _ProyectoModificar, _FechaAModificar);
                        else
                        {
                            CapaLogica.ReversarAsientos(_CodigoModificar, _ProyectoModificar, frmLogin.CodigoUsuario, _FechaAModificar);
                            ultimoasiento();
                        }
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
                        msgOK($"Se Modificó Asiento: {CuoSelec} con Exito");

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
                                msgOK($"Eliminado Exitosamente: {ValorCuo(Feccc, codigo)}");
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
        public void BuscarAsiento(string cadena, int empresa, DateTime Fecha)
        {
            CargarEmpresas();
            Txtbusca.Text = cadena;
            cboempresa.SelectedValue = empresa;
            chkfecha.Checked = true;
            fechaini.Value = fechafin.Value = Fecha;
            //dtgbusca.DataSource = CapaLogica.BuscarAsientosContables(cadena, 1, empresa);
            chkfecha_CheckedChanged(new object { }, new EventArgs());
        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        public DialogResult msgp(string cadena, string detalle) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena, detalle); }
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
                    if (msgp("Hay datos Ingresados, Desea Salir?") == DialogResult.Yes)
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
                        if (msgp("Hay datos Ingresados, Desea Salir?") == DialogResult.Yes)
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
                if (msgp("Desea Borrar esta fila") == DialogResult.Yes)
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
            BuscarDatos();
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
            //System.Diagnostics.Stopwatch yquedice = new System.Diagnostics.Stopwatch();
            //yquedice.Start();
            BuscarDatos();
            /////
            foreach (DataGridViewRow item in dtgbusca.Rows)
            {
                if (item.Cells[Codidasiento.Name].Value.ToString() == cuoI) { pos = item.Index; break; }
            }
            if (dtgbusca.RowCount > pos)
                dtgbusca.CurrentCell = dtgbusca[Codidasiento.Name, pos];
            //HpResergerUserControls.Configuraciones.TiempoEjecucionMsg(yquedice);

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
        private void cboproyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboproyecto.SelectedIndex >= 0)
            {
                DataRowView itemsito = (DataRowView)cboproyecto.Items[cboproyecto.SelectedIndex];
                cboetapa.DataSource = CapaLogica.ListarEtapasProyecto((itemsito["id_proyecto"].ToString()));
                cboetapa.ValueMember = "id_etapa";
                cboetapa.DisplayMember = "descripcion";
            }
            else msg("No Hay Proyectos");
        }
        private DialogResult msgP(string v)
        {
            return HPResergerFunciones.Utilitarios.msgp(v);
        }
        private void cboproyecto_Enter(object sender, EventArgs e)
        {
            string cadena = cboproyecto.Text;
            cboempresa_SelectedIndexChanged_1(sender, e);
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
            if (cboproyecto.SelectedValue == null) return;
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
                    decimal val = 0;
                    decimal.TryParse(Dtgconten[y, x].Value.ToString(), out val);
                    Dtgconten[y, x].Value = val;
                }
            }
        }
        private void Dtgconten_Sorted(object sender, EventArgs e)
        {
            PintardeCOlores();
        }
        string cuoReversa = "";
        private void button1_Click(object sender, EventArgs e)
        {
            //No se Pueden reversar Asientos Reversados
            if (dtgbusca[nameestado.Name, dtgbusca.CurrentRow.Index].Value.ToString().ToUpper() == "REVERSADO" || ((int)dtgbusca[Iddinamica.Name, dtgbusca.CurrentRow.Index].Value) == -10)
            {
                HPResergerFunciones.Utilitarios.msgCancel($"Asiento No se Puede Reversar!"); return;
            }
            //Validacion de que el periodo NO sea muy disperso, sea un mes continuo a los trabajados
            int IdEmpresa = (int)cboempresa.SelectedValue;
            DateTime FechaCoontable = dtpfechavalor.Value;
            if (!CapaLogica.ValidarCrearPeriodo(IdEmpresa, FechaCoontable))
            {
                if (HPResergerFunciones.frmPregunta.MostrarDialogYesCancel("No se Puede Registrar este Asiento\nEl Periodo no puede Crearse", $"¿Desea Crear el Periodo de {FechaCoontable.ToString("MMMM")}-{FechaCoontable.Year}?") != DialogResult.Yes)
                    return;
            }
            //Verificio si el Periodo esta Abierto para Proceder con la Anulacion - REversa
            else if (!CapaLogica.VerificarPeriodoAbierto((int)cboempresa.SelectedValue, dtpfechavalor.Value))
            {
                msg("El Periodo Esta Cerrado, Cambie Fecha Contable"); dtpfechavalor.Focus(); return;
            }
            if (1 != 1)
            {
                //Proceso de la Reversa
                if (HPResergerFunciones.Utilitarios.msgp($"Seguro Desea Reversar Este Asiento Nro {txtcuo.Text}") == DialogResult.Yes)
                {
                    //VALIDAMOS QUE NO EXISTAN CUENTAS CONTABLES DESACTIVADAS
                    List<string> ListaAuxiliar = new List<string>();
                    foreach (DataGridViewRow item in Dtgconten.Rows)
                        ListaAuxiliar.Add(item.Cells[cuenta.Name].Value.ToString());
                    if (CapaLogica.CuentaContableValidarActivas(string.Join(",", ListaAuxiliar.ToArray()), Mensajes.CuentasContablesDesactivadas)) return;
                    //FIN DE LA VALDIACION DE LAS CUENTAS CONTABLES DESACTIVADAS
                    cuoReversa = txtcuo.Text;
                    //Proceso Reversa del Asiento               
                    DataRow Filita = CapaLogica.ReversarAsientos((int.Parse(txtcodigo.Text)), (int)cboproyecto.SelectedValue, frmLogin.CodigoUsuario, dtpfechavalor.Value).Rows[0];
                    if (Filita[0].ToString() == "")
                    {
                        msgOK($"Asiento {txtcuo} Reversado!");
                        btnActualizar_Click(sender, e);
                        SeleccionarCuo();
                    }
                    else
                    {
                        msg("Mensaje de Error: \n" + Filita[0].ToString());
                        return;
                    }
                }
            }
            else
            {
                cuoReversa = txtcuo.Text;
                ModuloContable.frmRevesarAsientos frmReversita = new ModuloContable.frmRevesarAsientos();
                //Paso de Variables
                if (dinamica == -50 || dinamica == -51)
                    frmReversita.rbReversarPeriodo.Enabled = false;
                frmReversita.Glosa = txtglosa.Text;
                frmReversita.Cuo = txtcuo.Text;
                frmReversita.FechaValor = dtpfechavalor.Value;
                frmReversita.FechaEmisionDes = dtpfecha.Value;
                frmReversita.FechaContableDes = dtpfechavalor.Value;
                frmReversita.Codigo = int.Parse(txtcodigo.Text);
                frmReversita.IdEmpresa = (int)cboempresa.SelectedValue;
                frmReversita.IdProyecto = (int)(cboproyecto.SelectedValue);
                frmReversita.IdDinamica = int.Parse(txtdinamica.Text.Substring(3));
                frmReversita.MdiParents = this.MdiParent;
                //Fin de Paso de Variables
                if (frmReversita.ShowDialog() == DialogResult.OK)
                {
                    btnActualizar_Click(sender, e);
                    SeleccionarCuo();
                }
            }
        }
        public void SeleccionarCuo()
        {
            foreach (DataGridViewRow item in dtgbusca.Rows)
            {
                if (item.Cells[Codidasiento.Name].Value.ToString().Trim() == cuoReversa)
                {
                    dtgbusca.CurrentCell = dtgbusca[Codidasiento.Name, item.Index];
                    break;
                }
            }
        }
        private void cboestado_TextChanged(object sender, EventArgs e)
        {
            if (cboestado.Text == "Activo") btneliminar.Text = "Desactivar";// else btneliminar.Text = "Activar";
        }
        private void fecha_ValueChanged(object sender, EventArgs e)
        {
            if (estado == 1 || estado == 2)
                if (dtpfecha.Value <= DateTime.Now)
                    SacarTipoCambio();
                else txttipocambio.Text = "0.00";
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
        private bool MismoPeriodo;

        public void SacarTipoCambio()
        {
            DateTime FechaValidaBuscar = dtpfecha.Value;
            txttipocambio.Text = CapaLogica.TipoCambioDia(cbocambio.Text, FechaValidaBuscar).ToString("n4");
            if (decimal.Parse(txttipocambio.Text) == 0)
            {
                try
                {
                    if (frmtipo == null)
                    {
                        frmtipo = new frmTipodeCambio();
                        //frmtipo.ActualizoTipoCambio += Frmtipo_ActualizoTipoCambio;
                        frmtipo.Show();
                        frmtipo.Hide();
                        frmtipo.comboMesAño1.ActualizarMesAÑo(FechaValidaBuscar.Month.ToString(), FechaValidaBuscar.Year.ToString());
                        frmtipo.Buscar_Click(new object(), new EventArgs());
                    }
                }
                catch (Exception) { }
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
            ListoParaBuscar = false;
            string CodText = cboempresa.Text;
            CargarEmpresas();
            cboempresa.Text = CodText;
            ListoParaBuscar = true;
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
            //BuscarDatos();
        }

        private void txtbusGlosa_TextChanged(object sender, EventArgs e)
        {
            //  BuscarDatos();
        }

        private void txtbuscuo_TextChanged(object sender, EventArgs e)
        {
            //BuscarDatos();
        }

        private void dtpfechaini_ValueChanged(object sender, EventArgs e)
        {
            BuscarDatos();
        }

        private void dtpfechafin_ValueChanged(object sender, EventArgs e)
        {
            BuscarDatos();
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

        private void cuadrarAsientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                estado = -1;
                RevisarSihayDescuadre();
                //msgOK("Asiento Cuadrado");
                estado = 0;
            }
        }

        private void cboempresa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //  if (BuscarEmpresa)
            //{
            if (cboempresa.Items.Count > 0)
            {
                if (cboempresa.SelectedValue != null)
                {
                    cboproyecto.DataSource = CapaLogica.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString());
                    cboproyecto.DisplayMember = "proyecto";
                    cboproyecto.ValueMember = "id_proyecto";
                    //busqueda de Asientos
                    if (_idempresa != (int)cboempresa.SelectedValue && ListoParaBuscar)
                    {
                        _idempresa = (int)cboempresa.SelectedValue;
                        if (estado == 0)
                        {
                            txtcodigo.Text = "0";
                            txttotaldebe.Text = txttotalhaber.Text = txtdiferencia.Text = "0.00";
                            BuscarDatos();
                            if (dtgbusca.RowCount > 0) activar();
                        }
                        if (estado == 1)
                        {
                            ultimoasiento();
                            txtcodigo.Text = (codigo).ToString();
                        }
                    }
                    else _idempresa = (int)cboempresa.SelectedValue;
                }
            }
            else msg("No hay Empresas");
            // }
        }

        private void duplicadorBase1_Load(object sender, EventArgs e)
        {

        }

        private void txtbuscuo_OnPresionarEnter(object sender, KeyPressEventArgs e)
        {
            CargarDatos();
        }

        private void Txtbusca_PresionarEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CargarDatos();
            }
        }

        private void Dtgconten_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow item = Dtgconten.Rows[e.RowIndex];
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

        private void generarReflejosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnmodificar.PerformClick();
            btnProcesar.PerformClick();
            // Esperar un poco para que el diálogo se abra antes de enviar ESC
            //Task.Delay(500).ContinueWith(t => SendKeys.Send("{ESC}"));
        }

        private void Dtgconten_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //Sumatoria();
            //Dtgconten.CurrentCell = Dtgconten[cuenta.Name, e.RowIndex];
            msg(Dtgconten);
        }
    }
}
