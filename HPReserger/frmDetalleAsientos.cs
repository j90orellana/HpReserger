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
using System.Xml;

namespace HPReserger
{
    public partial class frmDetalleAsientos : FormGradient
    {
        public frmDetalleAsientos()
        {
            InitializeComponent();
        }
        int estado = 0;
        public int idasiento { get { return int.Parse(txtnumasiento.Text); } set { txtnumasiento.Text = value.ToString(); } }
        public int asiento;
        public int proyecto;
        public string cuenta { get { return txtcuenta.Text; } set { txtcuenta.Text = value; } }
        public string descripcion { get { return txtdescripcion.Text; } set { txtdescripcion.Text = value; } }
        public decimal Total { get { return decimal.Parse(txttotal.Text); } set { txttotal.Text = value.ToString("n2"); } }
        public DateTime fecha;
        public Boolean CheckDuplicar { get { return ChkDuplicar.Checked; } set { ChkDuplicar.Checked = value; } }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmDetalleAsientos_Load(object sender, EventArgs e)
        {
            ChkDuplicar.Enabled = true; ChkDuplicar.Checked = false;
            CargarDatos();
            SacarDatos();
            estado = 0;
            Dtgconten.ReadOnly = true;
            Dtgconten.Columns[fechaemisionx.Name].DefaultCellStyle.NullValue = fecha.ToShortDateString();
            Dtgconten.Columns[FechaVencimientox.Name].DefaultCellStyle.NullValue = fecha.ToShortDateString();
            Dtgconten.Columns[FechaRecepcionx.Name].DefaultCellStyle.NullValue = fecha.ToShortDateString();
            BuscarSiDuplica();
            SacarTotales();
            Dtgconten.Columns[importemnx.Name].CellTemplate.ToolTipText = "Presione A para Igualar";
        }
        public void BuscarSiDuplica()
        {
            if (((CapaLogica.BuscarSiDuplica(asiento, idasiento, proyecto, cuenta)).Rows[0])["duplica"].ToString() != "0")
            {
                CheckDuplicar = true;
                ChkDuplicar.Enabled = false;
            }
        }
        DataTable Datos = new DataTable();
        public void SacarDatos()
        {
            Dtgconten.DataSource = Datos = CapaLogica.DetalleAsientos(0, asiento, idasiento, proyecto);
            msj("");
        }
        DataTable tipoDoc;
        DataTable tipoComprobante;
        DataTable Centroc, CentroCosto;
        public void CargarDatos()
        {
            DataRow rowcito;

            CargarTipodoc();
            CargarTipodocLength();

            tipoComprobante = new DataTable();
            tipoComprobante = CapaLogica.getCargoTipoContratacion("Id_Comprobante", "Nombre", "TBL_Comprobante_Pago");
            rowcito = tipoComprobante.NewRow();
            rowcito[0] = 0;
            rowcito[1] = "Ninguno";
            tipoComprobante.Rows.InsertAt(rowcito, 0);

            Centroc = new DataTable();
            Centroc = CapaLogica.ListarCentroCostos();
            CentroCosto = new DataTable();
            CentroCosto.Columns.Add("codigo", typeof(int));
            CentroCosto.Columns.Add("descripcion");
            CentroCosto.Clear();
            CentroCosto.Rows.Add(0, "NINGUNO");
            foreach (DataRow item in Centroc.Rows)
            {
                if (item["Id_CtaCtble"].ToString() != "")
                    CentroCosto.Rows.Add(item["Id_CCosto"], item["Id_CtaCtble"] + "-" + item["CentroCosto"]);
            }
        }
        public void CargarTipodoc()
        {
            tipoDoc = new DataTable();
            tipoDoc = CapaLogica.getCargoTipoContratacion("Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");
            DataRow rowcito = tipoDoc.NewRow();
            rowcito[0] = 0;
            rowcito[1] = "NINGUNO";
            tipoDoc.Rows.InsertAt(rowcito, 0);
        }
        DataTable TipoDocLength;
        public void CargarTipodocLength()
        {
            TipoDocLength = new DataTable();
            TipoDocLength = CapaLogica.getCargoTipoContratacion("Codigo_Tipo_ID", "Length", "TBL_Tipo_ID");
            DataRow rowcito = TipoDocLength.NewRow();
            rowcito[0] = 0;
            rowcito[1] = 14;
            TipoDocLength.Rows.InsertAt(rowcito, 0);
        }
        DataGridViewComboBoxColumn Combo;
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado != 0)
            {
                estado = 0;
                Dtgconten.ReadOnly = true;
                btnaceptar.Enabled = false;
                btnmodificar.Enabled = true;
                SacarDatos();
            }
            else
                this.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2;
            Dtgconten.ReadOnly = false;
            Dtgconten.Columns[razonsocialx.Name].ReadOnly = true;
            btnmodificar.Enabled = false; btnaceptar.Enabled = true;
        }
        decimal Sumatoria = 0;
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 2)
            {
                Sumatoria = 0;
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (item.Cells[importemnx.Name].Value != null)
                        if (item.Cells[importemnx.Name].Value.ToString() != "")
                            Sumatoria += (decimal)item.Cells[importemnx.Name].Value;
                }
                if (Sumatoria > Total)
                {
                    msg($"Revise Los Montos no pueden superar el Total Del Registro: Asiento {Total.ToString("n2")} Detalle {Sumatoria.ToString("n2")} ");
                    return;
                }
                Boolean result = true;
                string cadena = "";
                CargarTipodocLength();
                BuscarSiDuplica();
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (item.Cells[razonsocialx.Name].Value != null)
                    //if (item.Cells[razonsocialx.Name].Value.ToString() != "")
                    {
                        if (item.Cells[tipodocx.Name].Value.ToString() == "")
                            item.Cells[tipodocx.Name].Value = 0;
                        if (item.Cells[idcomprobantex.Name].Value.ToString() == "")
                            item.Cells[idcomprobantex.Name].Value = 0;

                        if (item.Cells[centrocostox.Name].Value == null)
                        {
                            //msg($"Seleccioné Centro de Costo, Fila {item.Index + 1}");
                            item.Cells[centrocostox.Name].Value = 0;
                            //return;
                        }
                        if (item.Cells[centrocostox.Name].Value.ToString() == "")
                        {
                            // msg($"Seleccioné Centro de Costo, Fila {item.Index + 1}");
                            //return;
                            item.Cells[centrocostox.Name].Value = 0;
                        }
                        if (item.Cells[tipodocx.Name].Value.ToString() == "")
                        {
                            cadena += $"Seleccioné Tipo Documento, Fila {item.Index + 1}\n";
                            result = false;
                            HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[tipodocx.Name]);
                        }
                        else
                        {
                            HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[tipodocx.Name]);
                        }
                        if (item.Cells[tipodocx.Name].Value.ToString() != "0")
                        {
                            int index = (int.Parse((TipoDocLength.Select($"codigo='{item.Cells[tipodocx.Name].Value.ToString()}'"))[0].ItemArray[1].ToString()));
                            if (item.Cells[numdocx.Name].Value.ToString().Length == index)
                                HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[numdocx.Name]);
                            else
                            {
                                cadena += $"Tamaño del Documento Incorrecto debe ser={index}, en Fila {item.Index + 1}\n";
                                result = false;
                                HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[numdocx.Name]);
                            }
                        }
                        if (item.Cells[razonsocialx.Name].Value == null)
                        {
                            item.Cells[razonsocialx.Name].Value = "";
                        }
                        if (item.Cells[razonsocialx.Name].Value.ToString() == "" && item.Cells[tipodocx.Name].Value.ToString() != "0")
                        {
                            cadena += $"Proveedor no Existe: Registrelo , Fila {item.Index + 1}\n";
                            result = false;
                            HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[razonsocialx.Name]);
                        }
                        else
                        {
                            HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[razonsocialx.Name]);
                        }
                        if (item.Cells[idcomprobantex.Name].Value.ToString() == "")
                        {
                            msg($"Seleccioné Tipo Comprobante, Fila {item.Index + 1}");
                            return;
                        }
                        if (item.Cells[importemex.Name].Value.ToString() == "")
                        {
                            item.Cells[importemex.Name].Value = 0;
                        }
                        if (item.Cells[importemnx.Name].Value.ToString() == "")
                        {
                            item.Cells[importemnx.Name].Value = 0;
                        }
                        if (item.Cells[tipocambiox.Name].Value.ToString() == "")
                        {
                            item.Cells[tipocambiox.Name].Value = 0;
                        }
                        if (item.Cells[fechaemisionx.Name].Value == null)
                        {
                            // msg($"Ingresé Fecha Emisión del Documento, Fila {item.Index + 1}");
                            item.Cells[fechaemisionx.Name].Value = fecha;
                            //return;
                        }
                        if (item.Cells[fechaemisionx.Name].Value.ToString() == "")
                        {
                            item.Cells[fechaemisionx.Name].Value = fecha;
                            // msg($"Ingresé Fecha Emisión del Documento, Fila {item.Index + 1}");
                            //return;
                        }
                        if (item.Cells[FechaRecepcionx.Name].Value == null)
                        {
                            // msg($"Ingresé Fecha Emisión del Documento, Fila {item.Index + 1}");
                            item.Cells[FechaRecepcionx.Name].Value = fecha;
                            //return;
                        }
                        if (item.Cells[FechaRecepcionx.Name].Value.ToString() == "")
                        {
                            item.Cells[FechaRecepcionx.Name].Value = fecha;
                            // msg($"Ingresé Fecha Emisión del Documento, Fila {item.Index + 1}");
                            //return;
                        }
                        if (item.Cells[FechaVencimientox.Name].Value == null)
                        {
                            // msg($"Ingresé Fecha Emisión del Documento, Fila {item.Index + 1}");
                            item.Cells[FechaVencimientox.Name].Value = (fecha.AddMonths(1)).AddDays(-1);
                            //return;
                        }
                        if (item.Cells[FechaVencimientox.Name].Value.ToString() == "")
                        {
                            item.Cells[FechaVencimientox.Name].Value = (fecha.AddMonths(1)).AddDays(-1);
                            // msg($"Ingresé Fecha Emisión del Documento, Fila {item.Index + 1}");
                            //return;
                        }
                    }
                }
                if (!result)
                {
                    msg(cadena);
                    return;
                }
                CapaLogica.DetalleAsientos(10, asiento, idasiento, proyecto);
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (item.Cells[numdocx.Name].Value != null)
                        if (item.Cells[numdocx.Name].Value.ToString() != "")
                        {
                            CapaLogica.DetalleAsientos(1, asiento, idasiento, cuenta, (int)item.Cells[tipodocx.Name].Value,
                                item.Cells[numdocx.Name].Value.ToString(), item.Cells[razonsocialx.Name].Value.ToString(), (int)item.Cells[idcomprobantex.Name].Value, item.Cells[codcomprobantex.Name].Value.ToString(), item.Cells[numcomprobantex.Name].Value.ToString(),
                                int.Parse(item.Cells[centrocostox.Name].Value.ToString()), item.Cells[glosax.Name].Value.ToString(), (DateTime)item.Cells[fechaemisionx.Name].Value, (DateTime)item.Cells[FechaVencimientox.Name].Value, (decimal)item.Cells[importemnx.Name].Value, (decimal)item.Cells[importemex.Name].Value,
                                 (decimal)item.Cells[tipocambiox.Name].Value, frmLogin.CodigoUsuario, proyecto, (DateTime)item.Cells[FechaRecepcionx.Name].Value);
                        }
                }
                CapaLogica.DuplicarDetalle(asiento, idasiento, proyecto, ChkDuplicar.Checked ? 1 : 0, cuenta);
                estado = 0;
                btnmodificar.Enabled = true;
                btnaceptar.Enabled = false;
                Dtgconten.ReadOnly = true;
                msj("Guardado..");
                msg("Guardado con Exito");
            }
        }
        private void Dtgconten_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //if (Dtgconten.Columns[tipodocx.Name].Index == e.ColumnIndex)
            //{
            //    Dtgconten[tipodocx.Name, e.RowIndex].Value = 0;
            //    e.Cancel = false;
            //}            
        }
        public void msj(string cadena)
        {
            lblmsg.Text = $"Total de Registros :{Dtgconten.RowCount} " + cadena;
        }
        public DialogResult MSG(string cadena)
        {
            return MessageBox.Show(cadena, CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Dtgconten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (Dtgconten.SelectedRows.Count > 0)
                {
                    if (MSG("Desea Eliminar Fila") == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow item in Dtgconten.SelectedRows)
                        {
                            Dtgconten.Rows.Remove(item);
                        }
                        msj("Items Eliminados");
                    }
                    msj("Cancelado Por el Usuario");
                }
            }
        }
        TextBox txt;
        int LengthTipDoc = 0;
        private void Dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int y = Dtgconten.CurrentCell.ColumnIndex, x = Dtgconten.CurrentCell.RowIndex;
            string cadena = Dtgconten[tipodocx.Name, x].Value.ToString() == "" ? "0" : Dtgconten[tipodocx.Name, x].Value.ToString();
            LengthTipDoc = (int.Parse((TipoDocLength.Select($"codigo='{cadena}'"))[0].ItemArray[1].ToString()));
            if (x >= 0)
            {
                if (y == Dtgconten.Columns[importemnx.Name].Index || y == Dtgconten.Columns[importemex.Name].Index || y == Dtgconten.Columns[tipocambiox.Name].Index)
                {
                    txt = e.Control as TextBox;
                    if (txt != null)
                    {
                        txt.KeyPress -= new KeyPressEventHandler(Txt_KeyPress);
                        txt.KeyPress += new KeyPressEventHandler(Txt_KeyPress);
                    }
                }
                if (y == Dtgconten.Columns[numdocx.Name].Index)
                {
                    txt = e.Control as TextBox;
                    if (txt != null)
                    {
                        txt.KeyPress -= new KeyPressEventHandler(Txt_KeyPressSoloNumeros);
                        txt.KeyPress += new KeyPressEventHandler(Txt_KeyPressSoloNumeros);
                    }
                }
                if (y == Dtgconten.Columns[numdocx.Name].Index)
                {
                    txt = e.Control as TextBox;
                    if (txt != null)
                    {
                        txt.KeyDown -= new KeyEventHandler(Txt_KeyDown);
                        txt.KeyDown += new KeyEventHandler(Txt_KeyDown);

                    }
                }
                if (y == Dtgconten.Columns[codcomprobantex.Name].Index || y == Dtgconten.Columns[glosax.Name].Index || y == Dtgconten.Columns[numcomprobantex.Name].Index || y == Dtgconten.Columns[fechaemisionx.Name].Index || y == Dtgconten.Columns[FechaVencimientox.Name].Index || y == Dtgconten.Columns[razonsocialx.Name].Index)
                {
                    txt = e.Control as TextBox;
                    if (txt != null)
                    {
                        txt.KeyPress -= new KeyPressEventHandler(Txt_KeyPress);
                        txt.KeyPress -= new KeyPressEventHandler(Txt_KeyPressSoloNumeros);
                        txt.KeyDown -= new KeyEventHandler(Txt_KeyDown);

                    }
                }
            }
        }
        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            txt.MaxLength = LengthTipDoc;
            HPResergerFunciones.Utilitarios.ValidarCuentaBancos(e, txt, LengthTipDoc);
        }
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            int x = Dtgconten.CurrentCell.RowIndex, y = Dtgconten.CurrentCell.ColumnIndex;
            if (x > 0)
            {
                //moneda nacional
                if (Dtgconten.Columns[importemnx.Name].Index == y)
                {
                    if (e.KeyChar == 'A' || e.KeyChar == 'a')
                    {
                        Dtgconten.EndEdit();
                        Dtgconten[y, x].Value = Convert.ToDecimal(txtdiferencia.Text) + Convert.ToDecimal(Dtgconten[y, x].Value.ToString());
                        Dtgconten.RefreshEdit();
                    }
                }//moneda extranjera
                if (Dtgconten.Columns[importemex.Name].Index == y)
                {
                    if (e.KeyChar == 'A' || e.KeyChar == 'a')
                    {
                        Dtgconten.EndEdit();
                        Dtgconten[y, x].Value = Convert.ToDecimal(txtdiferencia.Text) + Convert.ToDecimal(Dtgconten[y, x].Value.ToString());
                        Dtgconten.RefreshEdit();
                    }
                }
                HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txt.Text);
            }
            //BorrarFilasSelecionadas(e);
        }
        private void Txt_KeyPressSoloNumeros(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
            //BorrarFilasSelecionadas(e);
        }
        public void BorrarFilasSelecionadas(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete)
            {
                if (Dtgconten.SelectedRows.Count > 0)
                {
                    if (MSG("Desea Eliminar Fila") == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow item in Dtgconten.SelectedRows)
                        {
                            Dtgconten.Rows.Remove(item);
                        }
                        msj("Items Eliminados");
                    }
                    msj("Cancelado Por el Usuario");
                }
            }
        }
        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtcuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnumasiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Dtgconten.Rows.Add();
        }

        private void Dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0 && x < Dtgconten.RowCount)
                if (y == Dtgconten.Columns[tipocambiox.Name].Index || y == Dtgconten.Columns[importemex.Name].Index)
                {
                    if (Dtgconten[tipocambiox.Name, x].Value != null)
                        if (Dtgconten[importemex.Name, x].Value != null)
                            if (Dtgconten[tipocambiox.Name, x].Value.ToString() != "" && Dtgconten[importemex.Name, x].Value.ToString() != "")
                                if ((decimal.Parse(Dtgconten[tipocambiox.Name, x].Value.ToString())) > 0)
                                {
                                    Dtgconten[importemnx.Name, x].Value = (decimal)Dtgconten[importemex.Name, x].Value * (decimal)Dtgconten[tipocambiox.Name, x].Value;
                                }
                }
            //si se edita la columna ruc
            if (x >= 0)
            {
                //cambia el index del ruc
                int index = int.Parse((tipoDoc.Select("descripcion='ruc'"))[0].ItemArray[0].ToString());
                if (y == Dtgconten.Columns[tipodocx.Name].Index)
                {
                    if (Dtgconten[tipodocx.Name, x].Value != null)
                        if ((int)Dtgconten[tipodocx.Name, x].Value == 0 || (int)Dtgconten[tipodocx.Name, x].Value == index)
                        {
                            Dtgconten[razonsocialx.Name, x].ReadOnly = true;
                        }
                        else
                            Dtgconten[razonsocialx.Name, x].ReadOnly = false;
                }
                //se modifica el numero del ruc
                if (y == Dtgconten.Columns[numdocx.Name].Index && int.Parse(Dtgconten[tipodocx.Name, x].Value.ToString() == "" ? index.ToString() : Dtgconten[tipodocx.Name, x].Value.ToString()) == index)
                {
                    DataRow filita = CapaLogica.RUCProveedor((Dtgconten[y, x].Value == null) ? "0" : Dtgconten[y, x].Value.ToString());
                    if (filita != null)
                    {
                        fila = x;
                        //if (x == Dtgconten.RowCount - 1) { Datos.Rows.Add(); }
                        Dtgconten[razonsocialx.Name, fila].Value = filita["razon_social"].ToString();
                    }
                    else Dtgconten[razonsocialx.Name, fila].Value = "";
                    Dtgconten.EndEdit();
                }
                if (y == Dtgconten.Columns[importemnx.Name].Index || y == Dtgconten.Columns[importemex.Name].Index)
                {
                    //sacar Totales
                    SacarTotales();
                }
            }
        }
        public void SacarTotales()
        {
            decimal TotalMN = 0, TotalME = 0;
            foreach (DataGridViewRow item in Dtgconten.Rows)
            {
                TotalME += item.Cells[importemex.Name].Value == null ? 0 : decimal.Parse(item.Cells[importemex.Name].Value.ToString());
                TotalMN += item.Cells[importemnx.Name].Value == null ? 0 : decimal.Parse(item.Cells[importemnx.Name].Value.ToString());
            }
            txttotalmonextranjera.Text = TotalME.ToString("n2");
            txttotalmonedaNacional.Text = TotalMN.ToString("n2");

            txtdiferencia.Text = ((Convert.ToDecimal(txttotal.Text)) - (TotalMN)).ToString("n2");
            VerificarDiferencia();
        }
        public void VerificarDiferencia()
        {
            if (Convert.ToDecimal(txtdiferencia.Text) != 0)
            {
                txtdiferencia.ForeColor = Color.Red;
                txtdiferencia.BackColor = Color.Yellow;
            }
            else
            {
                txtdiferencia.ForeColor = Color.Black;
                txtdiferencia.BackColor = Color.White;
                txttotalmonedaNacional.BackColor = Color.White;
                txttotalmonextranjera.BackColor = Color.White;
                txttotalmonedaNacional.ForeColor = Color.Black;
                txttotalmonextranjera.ForeColor = Color.Black;
            }
            if (Convert.ToDecimal(txttotal.Text) > Convert.ToDecimal(txttotalmonedaNacional.Text))
            {
                txttotalmonedaNacional.ForeColor = Color.Green;
                txttotalmonextranjera.ForeColor = Color.Green;
            }
        }
        private void Dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0 && x < Dtgconten.RowCount - 1)
            {
                if (y == Dtgconten.Columns[buttonCentroCosto.Name].Index && estado == 2)
                {
                    frmccosto ccosto = new frmccosto();
                    ccosto.Consulta = true;
                    if (ccosto.ShowDialog() == DialogResult.OK)
                        Dtgconten[centrocostox.Name, x].Value = ccosto.ConsulCodi;
                }
                if (y == Dtgconten.Columns[btnborrar.Name].Index && estado == 2)
                {
                    Dtgconten.Rows.Remove(Dtgconten.Rows[Dtgconten.CurrentRow.Index]);
                }
            }
        }
        private void Dtgconten_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            msj("");
            int y = e.RowIndex;
            //Dtgconten[numdocx.Name, y].Value = 0;
            //Dtgconten[razonsocialx.Name, y].Value = "0";
            //Dtgconten[numcomprobantex.Name, y].Value = 0;
            //Dtgconten[codcomprobantex.Name, y].Value = 0;
            //Dtgconten[importemex.Name, y].Value = 0.00m;
            //Dtgconten[importemnx.Name, y].Value = 0.00m;
            //Dtgconten[tipocambiox.Name, y].Value = 0.00m;
            Dtgconten[fechaemisionx.Name, y].Value = fecha;
            Dtgconten[FechaVencimientox.Name, y].Value = fecha;
            Dtgconten[FechaRecepcionx.Name, y].Value = fecha;
            //    Dtgconten[idcomprobantex.Name, y].Value = 0;
            //   Dtgconten[tipodocx.Name, y].Value = 0;
        }

        private void Dtgconten_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            msj("");
        }
        private void Dtgconten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Delete)
            {
                if (Dtgconten.SelectedRows.Count > 0)
                {
                    if (MSG("Desea Eliminar Fila") == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow item in Dtgconten.SelectedRows)
                        {
                            Dtgconten.Rows.Remove(item);
                        }
                        msj("Items Eliminados");
                    }
                    msj("Cancelado Por el Usuario");
                }
            }
        }
        int fila = 0;
        frmproveedor frmprovee;
        private void Dtgconten_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void Frmprovee_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmprovee.llamada == 1)
            {
                if (fila == Dtgconten.RowCount - 1)
                    Datos.Rows.Add();
                if (Dtgconten[numdocx.Name, fila].Value.ToString() == frmprovee.rucito)
                {
                    Dtgconten_CellValueChanged(sender, new DataGridViewCellEventArgs(Dtgconten.Columns[numdocx.Name].Index, fila));
                }
                Dtgconten[numdocx.Name, fila].Value = frmprovee.rucito;
                Dtgconten[tipodocx.Name, fila].Value = 5;
            }
        }
        private void Dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                if (estado == 2)
                {
                    CargarTipodoc();
                    DataRow[] filita = tipoDoc.Select("descripcion like 'ruc'");
                    DataRow fili = filita[0];
                    if (Dtgconten[tipodocx.Name, x].Value.ToString() == "" || int.Parse(Dtgconten[tipodocx.Name, x].Value.ToString()) == 0 || int.Parse(Dtgconten[tipodocx.Name, x].Value.ToString()) == int.Parse(fili[0].ToString() ?? "5"))
                    {
                        if (y == Dtgconten.Columns[razonsocialx.Name].Index || y == Dtgconten.Columns[numdocx.Name].Index)
                        {
                            frmprovee = new frmproveedor();
                            frmprovee.Txtbusca.Text = Dtgconten[numdocx.Name, x].Value.ToString();
                            fila = x;
                            frmprovee.llamada = 1;
                            frmprovee.Icon = Icon;
                            frmprovee.MdiParent = ParentForm;
                            frmprovee.FormClosed += Frmprovee_FormClosed;
                            frmprovee.Show();
                        }
                    }
                }
            }
        }

        private void Dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Dtgconten.RowCount > 0)
            {
                int x = e.RowIndex, y = e.ColumnIndex;
                //tipodoc
                Combo = Dtgconten.Columns[tipodocx.Name] as DataGridViewComboBoxColumn;
                Combo.DataSource = tipoDoc;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "descripcion";
                Combo.DataSource = tipoDoc;
                //tipocomprobante
                Combo = Dtgconten.Columns[idcomprobantex.Name] as DataGridViewComboBoxColumn;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "descripcion";
                Combo.DataSource = tipoComprobante;
                //centrocosto
                Combo = Dtgconten.Columns[centrocostox.Name] as DataGridViewComboBoxColumn;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "descripcion";
                Combo.AutoComplete = true;
                Combo.DataSource = CentroCosto;

                if (estado == 2)
                {
                    if ((Dtgconten[tipodocx.Name, x].Value == null ? "" : Dtgconten[tipodocx.Name, x].Value.ToString()) == "")
                        Dtgconten[tipodocx.Name, x].Value = 0;
                    if ((Dtgconten[idcomprobantex.Name, x].Value == null ? "" : Dtgconten[idcomprobantex.Name, x].Value.ToString()) == "")
                        Dtgconten[idcomprobantex.Name, x].Value = 0;
                }

                int index = int.Parse((tipoDoc.Select("descripcion='ruc'"))[0].ItemArray[0].ToString());
                if (Dtgconten[tipodocx.Name, x].Value != null)
                    if ((Dtgconten[tipodocx.Name, x].Value.ToString() == "" ? "0" : Dtgconten[tipodocx.Name, x].Value.ToString()) == "0" || int.Parse((Dtgconten[tipodocx.Name, x].Value.ToString() == "" ? "0" : Dtgconten[tipodocx.Name, x].Value.ToString())) == index)
                    {
                        Dtgconten[razonsocialx.Name, x].ReadOnly = true;
                    }
                    else
                        Dtgconten[razonsocialx.Name, x].ReadOnly = false;
            }
        }
    }
}
