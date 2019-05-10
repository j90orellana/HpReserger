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
        public string _cuodasiento { get { return txtnumasiento.Text; } set { txtnumasiento.Text = value; } }
        public int _idasiento;
        public int _asiento;
        public int _proyecto;
        public int _empresa;
        public int _dinamica { get; set; }
        public string cuenta { get { return txtcuenta.Text; } set { txtcuenta.Text = value; } }
        public string descripcion { get { return txtdescripcion.Text; } set { txtdescripcion.Text = value; } }
        public decimal Total { get { return decimal.Parse(txttotal.Text); } set { txttotal.Text = value.ToString("n2"); } }
        ///Recibe la fecha del asiento
        public DateTime _fecha;
        public DateTime _fechaEmision;
        public Boolean CheckDuplicar { get { return ChkDuplicar.Checked; } set { ChkDuplicar.Checked = value; } }
        public decimal _TipoCambio { get; internal set; }
        public int _Moneda { get; set; }
        public bool _EsManual { get; internal set; }
        public int Estado { get; internal set; }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmDetalleAsientos_Load(object sender, EventArgs e)
        {
            ChkDuplicar.Enabled = true; ChkDuplicar.Checked = false;
            chkAutoConversion.Enabled = false;
            //Dtgconten.SuspendLayout();
            CargarDatos();
            //Dtgconten.ResumeLayout();
            estado = 0;
            Dtgconten.ReadOnly = true;
            //Dtgconten.Columns[fechaemisionx.Name].DefaultCellStyle.NullValue = _fechaEmision.ToShortDateString();
            //Dtgconten.Columns[FechaVencimientox.Name].DefaultCellStyle.NullValue = _fecha.ToShortDateString();
            //Dtgconten.Columns[FechaRecepcionx.Name].DefaultCellStyle.NullValue = _fecha.ToShortDateString();
            BuscarSiDuplica();
            Dtgconten.Columns[importemnx.Name].CellTemplate.ToolTipText = "Presione\nA para Cuadrar\nD para Igualar Todo";
            Dtgconten.Columns[importemex.Name].CellTemplate.ToolTipText = "Presione\nA para Cuadrar\nD para Igualar Todo";
            Dtgconten.Columns[tipocambiox.Name].CellTemplate.ToolTipText = "Presione\nD para LLenarlo\nT Para Insertar TC";
            SacarDatos();
            SacarTotales();
            ChkDuplicar.Enabled = _dinamica >= 0 ? true : false;
        }
        public void BuscarSiDuplica()
        {
            if (((CapaLogica.BuscarSiDuplica(_asiento, _idasiento, _proyecto, cuenta, _fecha)).Rows[0])["duplica"].ToString() != "0")
            {
                CheckDuplicar = true;
                ChkDuplicar.Enabled = false;
            }
        }
        DataTable Datos = new DataTable();
        public void SacarDatos()
        {
            Dtgconten.DataSource = CapaLogica.DetalleAsientos(0, _asiento, _idasiento, _proyecto, _fecha, cuenta);
            Datos = (DataTable)Dtgconten.DataSource;
            msj("");
        }
        DataTable tipoDoc;
        DataTable tipoComprobante;
        DataTable Monedas;
        DataTable Centroc, CentroCosto;
        DataTable TcuentasBancarias;
        public void CargarDatos()
        {
            CargarTipodoc();
            CargarTipodocLength();
            /////////////////
            CargarMonedas();
            CargarComprobantes();
            /////////////////
            Centroc = new DataTable();
            Centroc = CapaLogica.ListarCentroCostos();
            CentroCosto = new DataTable();
            CentroCosto.Columns.Add("codigo", typeof(int));
            CentroCosto.Columns.Add("descripcion");
            CentroCosto.Clear();
            CentroCosto.Rows.Add(0, "NINGUNO");
            foreach (DataRow item in Centroc.Rows)
            {
                //  if (item["Id_CtaCtble"].ToString() != "")
                CentroCosto.Rows.Add(item["Id_CCosto"], item["Id_CtaCtble"] + "-" + item["CentroCosto"]);
            }
            ////CargarDatosdelas Cuentas
            TcuentasBancarias = CapaLogica.CuentaBancaria(_empresa, cuenta);
        }
        public void CargarComprobantes()
        {
            DataRow rowcito;
            tipoComprobante = new DataTable();
            tipoComprobante = CapaLogica.getCargoTipoContratacion("Id_Comprobante", "Nombre", "TBL_Comprobante_Pago");
            rowcito = tipoComprobante.NewRow();
            rowcito[0] = 0;
            rowcito[1] = "Ninguno";
            tipoComprobante.Rows.InsertAt(rowcito, 0);
        }
        public void CargarMonedas()
        {
            //DataRow rowcito;
            Monedas = new DataTable();
            Monedas = CapaLogica.getCargoTipoContratacion("Id_Moneda", "NameCorto", "TBL_Moneda");
            //rowcito = Monedas.NewRow();
            //rowcito[0] = 0;
            //rowcito[1] = "Ninguno";
            //Monedas.Rows.InsertAt(rowcito, 0);
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
            {
                this.Close();
            }
            chkAutoConversion.Enabled = false;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (Estado != 3)
            {
                estado = 2;
                chkAutoConversion.Enabled = true;
                Dtgconten.ReadOnly = false;
                Dtgconten.Columns[razonsocialx.Name].ReadOnly = true;
                Dtgconten.Columns[fkAsix.Name].ReadOnly = true;
                Dtgconten.Columns[fk_asisx.Name].ReadOnly = true;
                Dtgconten.Columns[xNroOPBanco.Name].ReadOnly = !_EsManual;
                btnmodificar.Enabled = false; btnaceptar.Enabled = true;
            }
            else { msg("No se Puede Modificar el Detalle del Reflejo"); }
        }
        decimal SumatoriaMN = 0, SumatoriaME = 0;
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 2)
            {
                SumatoriaMN = SumatoriaME = 0;
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (item.Cells[importemnx.Name].Value != null)
                        if (item.Cells[importemnx.Name].Value.ToString() != "")
                            SumatoriaMN += Configuraciones.Redondear((decimal)item.Cells[importemnx.Name].Value);
                    if (item.Cells[importemex.Name].Value != null)
                        if (item.Cells[importemex.Name].Value.ToString() != "")
                            SumatoriaME += Configuraciones.Redondear((decimal)item.Cells[importemex.Name].Value);
                }
                if (_Moneda == 1)
                {
                    if (Math.Round(SumatoriaMN, 2) > Math.Round(Total, 2))
                    {
                        msg($"Revise Los Montos no pueden superar el Total Del Registro: Asiento {Total.ToString("n2")} Detalle {SumatoriaMN.ToString("n2")}");
                        return;
                    }
                }
                else
                {
                    if (Math.Round(SumatoriaME, 2) > Math.Round(Total, 2))
                    {
                        msg($"Revise Los Montos no pueden superar el Total Del Registro: Asiento {Total.ToString("n2")} Detalle {SumatoriaMN.ToString("n2")} ");
                        return;
                    }

                }
                if (_Moneda == 1)
                {
                    if (Math.Round(SumatoriaMN, 2) != Math.Round(Total, 2))
                    {
                        msg($"Revise Los Montos no pueden ser Diferentes el Total Del Registro: Asiento {Total.ToString("n2")} Detalle {SumatoriaMN.ToString("n2")}");
                        return;
                    }
                }
                else
                {
                    if (Math.Round(SumatoriaME, 2) != Math.Round(Total, 2))
                    {
                        msg($"Revise Los Montos no pueden ser diferentes el Total Del Registro: Asiento {Total.ToString("n2")} Detalle {SumatoriaMN.ToString("n2")} ");
                        return;
                    }
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
                        if (!(item.Cells[tipodocx.Name].Value.ToString() == "0" || item.Cells[tipodocx.Name].Value.ToString() == "6"))
                        {
                            int index = (int.Parse((TipoDocLength.Select($"codigo='{item.Cells[tipodocx.Name].Value.ToString()}'"))[0].ItemArray[1].ToString()));
                            if (item.Cells[numdocx.Name].Value.ToString().ToUpper().Contains("DNI") || item.Cells[numdocx.Name].Value.ToString().ToUpper().Contains("RUC"))
                            {
                                HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[numdocx.Name]);
                                if (item.Cells[numdocx.Name].Value.ToString().Length != index)
                                {
                                    result = false;
                                    cadena += $"El tamaño del Nro Documento debe ser: {index}";
                                    HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[numdocx.Name]);
                                }
                            }
                            else if (item.Cells[numdocx.Name].Value.ToString().Length > index)
                            {
                                result = false;
                                cadena += $"El Máximo tamaño del Nro Documento debe ser: {index}";
                                HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[numdocx.Name]);

                            }
                            //if (item.Cells[numdocx.Name].Value.ToString().Length == index)
                            //    HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[numdocx.Name]);
                            //else
                            //{
                            //    cadena += $"Tamaño del Documento Incorrecto debe ser={index}, en Fila {item.Index + 1}\n";
                            //    result = false;
                            //    HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[numdocx.Name]);
                            //}
                        }
                        else
                        {
                            HPResergerFunciones.Utilitarios.ColorCeldaDefecto(item.Cells[numdocx.Name]);
                        }
                        if (item.Cells[razonsocialx.Name].Value == null)
                        {
                            item.Cells[razonsocialx.Name].Value = "";
                        }
                        if (item.Cells[razonsocialx.Name].Value.ToString() == "" && !(item.Cells[tipodocx.Name].Value.ToString() == "0" || item.Cells[tipodocx.Name].Value.ToString() == "6"))
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
                        //seleccion de moneda --la de id =1 por defecto
                        if (item.Cells[fk_Monedax.Name].Value.ToString() == "")
                        {
                            item.Cells[fk_Monedax.Name].Value = 1;
                        }
                        if (item.Cells[fechaemisionx.Name].Value == null)
                        {
                            // msg($"Ingresé Fecha Emisión del Documento, Fila {item.Index + 1}");
                            item.Cells[fechaemisionx.Name].Value = _fechaEmision;
                            //return;
                        }
                        if (item.Cells[fechaemisionx.Name].Value.ToString() == "")
                        {
                            item.Cells[fechaemisionx.Name].Value = _fechaEmision;
                            // msg($"Ingresé Fecha Emisión del Documento, Fila {item.Index + 1}");
                            //return;
                        }
                        if (item.Cells[FechaRecepcionx.Name].Value == null)
                        {
                            // msg($"Ingresé Fecha Emisión del Documento, Fila {item.Index + 1}");
                            item.Cells[FechaRecepcionx.Name].Value = _fecha;
                            //return;
                        }
                        if (item.Cells[FechaRecepcionx.Name].Value.ToString() == "")
                        {
                            item.Cells[FechaRecepcionx.Name].Value = _fecha;
                            // msg($"Ingresé Fecha Emisión del Documento, Fila {item.Index + 1}");
                            //return;
                        }
                        if (item.Cells[FechaVencimientox.Name].Value == null)
                        {
                            // msg($"Ingresé Fecha Emisión del Documento, Fila {item.Index + 1}");
                            item.Cells[FechaVencimientox.Name].Value = (_fecha.AddMonths(1)).AddDays(-1);
                            //return;
                        }
                        if (item.Cells[FechaVencimientox.Name].Value.ToString() == "")
                        {
                            item.Cells[FechaVencimientox.Name].Value = (_fecha.AddMonths(1)).AddDays(-1);
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
                CapaLogica.DetalleAsientos(10, _asiento, _idasiento, _proyecto, _fecha, cuenta);
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (item.Cells[numdocx.Name].Value != null)
                    {
                        if (item.Cells[numdocx.Name].Value.ToString() == "") item.Cells[numdocx.Name].Value = "0";
                        if (item.Cells[numdocx.Name].Value.ToString() != "")
                        {
                            CapaLogica.DetalleAsientos(1, _asiento, _idasiento, cuenta, (int)item.Cells[tipodocx.Name].Value,
                                item.Cells[numdocx.Name].Value.ToString(), item.Cells[razonsocialx.Name].Value.ToString(), (int)item.Cells[idcomprobantex.Name].Value, item.Cells[codcomprobantex.Name].Value.ToString(), item.Cells[numcomprobantex.Name].Value.ToString(),
                                int.Parse(item.Cells[centrocostox.Name].Value.ToString()), item.Cells[glosax.Name].Value.ToString(), (DateTime)item.Cells[fechaemisionx.Name].Value, (DateTime)item.Cells[FechaVencimientox.Name].Value, (decimal)item.Cells[importemnx.Name].Value, (decimal)item.Cells[importemex.Name].Value,
                                 (decimal)item.Cells[tipocambiox.Name].Value, frmLogin.CodigoUsuario, _proyecto, (DateTime)item.Cells[FechaRecepcionx.Name].Value, (int)item.Cells[fk_Monedax.Name].Value, _fecha, (int)(item.Cells[xCtaBancaria.Name].Value.ToString() == "" ? 0 : item.Cells[xCtaBancaria.Name].Value), (item.Cells[fkAsix.Name].Value.ToString() == "" ? "0" : item.Cells[fkAsix.Name].Value.ToString()), item.Cells[xNroOPBanco.Name].Value.ToString());
                        }
                    }
                }
                CapaLogica.DuplicarDetalle(_asiento, _idasiento, _proyecto, ChkDuplicar.Checked ? 1 : 0, cuenta, _fecha);
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
            //if (e.ColumnIndex == Dtgconten.Columns[xCtaBancaria.Name].Index) //22
            //    Dtgconten[xCtaBancaria.Name, e.RowIndex].Value = null;
            //e.Cancel = false;
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
                        txt.KeyPress -= new KeyPressEventHandler(Txt_KeyPressSoloLetrasMayusculas);
                        txt.KeyPress += new KeyPressEventHandler(Txt_KeyPressSoloLetrasMayusculas);
                    }
                }
                if (y == Dtgconten.Columns[numdocx.Name].Index)
                {
                    //    txt = e.Control as TextBox;
                    //    if (txt != null)
                    //    {
                    //        txt.KeyDown -= new KeyEventHandler(Txt_KeyDown);
                    //        txt.KeyPress -= new KeyPressEventHandler(Txt_KeyPress);
                    //    }
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
                //if (Dtgconten.RowCount == 1)
                //{
                //    ((DataTable)Dtgconten.DataSource).Rows.Add();
                //}
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
            if (x >= 0)
            {
                //moneda nacional
                if (Dtgconten.Columns[importemnx.Name].Index == y)
                {
                    if (e.KeyChar == 'A' || e.KeyChar == 'a')
                    {
                        Dtgconten.EndEdit();
                        if (_Moneda == 1)
                            Dtgconten[importemnx.Name, x].Value = Convert.ToDecimal(txtdiferencia.Text) + Convert.ToDecimal(Dtgconten[importemnx.Name, x].Value.ToString() == "" ? "0" : Dtgconten[importemnx.Name, x].Value.ToString());
                        else
                            Dtgconten[importemex.Name, x].Value = Convert.ToDecimal(txtdiferencia.Text) + Convert.ToDecimal(Dtgconten[importemex.Name, x].Value.ToString() == "" ? "0" : Dtgconten[importemex.Name, x].Value.ToString());
                        Dtgconten.RefreshEdit();
                    }
                    else if (e.KeyChar == 'D' || e.KeyChar == 'd')
                    {
                        //if (Dtgconten[importemnx.Name, x].Value.ToString() == "") ((DataTable)Dtgconten.DataSource).Rows.Add();
                        if (_Moneda == 1)
                            Configuraciones.RellenarGrillasAutomatico(Dtgconten, importemnx, Configuraciones.Decimal(txttotal.Text));
                        else
                            Configuraciones.RellenarGrillasAutomatico(Dtgconten, importemex, Configuraciones.Decimal(txttotal.Text));
                    }
                }//moneda extranjera
                else if (Dtgconten.Columns[importemex.Name].Index == y)
                {
                    if (e.KeyChar == 'A' || e.KeyChar == 'a')
                    {
                        Dtgconten.EndEdit();
                        if (_Moneda == 1)
                            Dtgconten[importemnx.Name, x].Value = Convert.ToDecimal(txtdiferencia.Text) + Convert.ToDecimal(Dtgconten[importemnx.Name, x].Value.ToString() == "" ? "0" : Dtgconten[importemnx.Name, x].Value.ToString());
                        else
                            Dtgconten[importemex.Name, x].Value = Convert.ToDecimal(txtdiferencia.Text) + Convert.ToDecimal(Dtgconten[importemex.Name, x].Value.ToString() == "" ? "0" : Dtgconten[importemex.Name, x].Value.ToString());
                        Dtgconten.RefreshEdit();
                    }
                    else if (e.KeyChar == 'D' || e.KeyChar == 'd')
                    {
                        //if (Dtgconten[importemex.Name, x].Value.ToString() == "") ((DataTable)Dtgconten.DataSource).Rows.Add();
                        if (_Moneda == 1)
                            Configuraciones.RellenarGrillasAutomatico(Dtgconten, importemnx, Configuraciones.Decimal(txttotal.Text));
                        else
                            Configuraciones.RellenarGrillasAutomatico(Dtgconten, importemex, Configuraciones.Decimal(txttotal.Text));
                    }
                }
                else if (Dtgconten.Columns[tipocambiox.Name].Index == y)
                {
                    if (e.KeyChar == 'D' || e.KeyChar == 'd')
                    {
                        foreach (DataGridViewRow item in Dtgconten.Rows)
                        {
                            if (item.Cells[tipocambiox.Name].Value.ToString() != "")
                                if ((decimal)item.Cells[tipocambiox.Name].Value > 0)
                                {
                                    Dtgconten.EndEdit();
                                    Dtgconten[tipocambiox.Name, x].Value = item.Cells[tipocambiox.Name].Value;
                                    Dtgconten.RefreshEdit();
                                    HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txt.Text);
                                    return;
                                }
                        }
                        //Dtgconten.EndEdit();
                        //Dtgconten[tipocambiox.Name, x].Value = _TipoCambio;
                        //Dtgconten.RefreshEdit();
                    }
                    if (e.KeyChar == 'T' || e.KeyChar == 't')
                    {
                        Dtgconten.EndEdit();
                        Dtgconten[tipocambiox.Name, x].Value = _TipoCambio;
                        Dtgconten.RefreshEdit();
                    }
                }
                HPResergerFunciones.Utilitarios.SoloNumerosDecimalesConNegativo(e, txt.Text);
            }
            //Dtgconten.RefreshEdit();
            //BorrarFilasSelecionadas(e);
        }
        private void Txt_KeyPressSoloNumeros(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
            //BorrarFilasSelecionadas(e);
        }
        private void Txt_KeyPressSoloLetrasMayusculas(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar.ToString().ToUpper()[0];
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
            {
                if (y == Dtgconten.Columns[tipocambiox.Name].Index || y == Dtgconten.Columns[importemnx.Name].Index)
                {
                    if (Dtgconten[tipocambiox.Name, x].Value != null)
                        if (Dtgconten[importemnx.Name, x].Value != null)
                            if (Dtgconten[tipocambiox.Name, x].Value.ToString() != "" && Dtgconten[importemnx.Name, x].Value.ToString() != "")
                                if ((decimal.Parse(Dtgconten[tipocambiox.Name, x].Value.ToString())) > 0 && chkAutoConversion.Checked)
                                    Dtgconten[importemex.Name, x].Value = ((decimal)Dtgconten[importemnx.Name, x].Value / (decimal)Dtgconten[tipocambiox.Name, x].Value);
                }
                else if (y == Dtgconten.Columns[tipocambiox.Name].Index || y == Dtgconten.Columns[importemex.Name].Index)
                {
                    if (Dtgconten[tipocambiox.Name, x].Value != null)
                        if (Dtgconten[importemex.Name, x].Value != null)
                            if (Dtgconten[tipocambiox.Name, x].Value.ToString() != "" && Dtgconten[importemex.Name, x].Value.ToString() != "")
                                if ((decimal.Parse(Dtgconten[tipocambiox.Name, x].Value.ToString())) > 0 && chkAutoConversion.Checked)
                                    Dtgconten[importemnx.Name, x].Value = ((decimal)Dtgconten[importemex.Name, x].Value * (decimal)Dtgconten[tipocambiox.Name, x].Value);
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
                }
                //se modifica el numero del ruc
                if (y == Dtgconten.Columns[numdocx.Name].Index || y == Dtgconten.Columns[tipodocx.Name].Index)// && int.Parse(Dtgconten[tipodocx.Name, x].Value.ToString() == "" ? index.ToString() : Dtgconten[tipodocx.Name, x].Value.ToString()) == index)
                {
                    DataTable filo = CapaLogica.BusquedaProveedorClienteEmpleado((int)(Dtgconten[tipodocx.Name, x].Value ?? 0), (Dtgconten[numdocx.Name, x].Value ?? "").ToString());
                    if (filo.Rows.Count > 0)
                    {
                        DataRow filita = filo.Rows[0];
                        if (filita != null)
                        {
                            FilaPos = x;
                            //if (x == Dtgconten.RowCount - 1) { Datos.Rows.Add(); }
                            Dtgconten[razonsocialx.Name, x].ReadOnly = true;
                            Dtgconten[razonsocialx.Name, x].Value = filita["Nombre"].ToString();
                        }
                        else
                        {
                            Dtgconten[razonsocialx.Name, x].Value = "";
                            Dtgconten[razonsocialx.Name, x].ReadOnly = false;
                        }
                        Dtgconten.EndEdit();
                    }
                    else
                    {
                        Dtgconten[razonsocialx.Name, x].ReadOnly = false;
                        Dtgconten[razonsocialx.Name, x].Value = "";
                        Dtgconten.EndEdit();
                    }
                }
                if (y == Dtgconten.Columns[importemnx.Name].Index || y == Dtgconten.Columns[importemex.Name].Index)
                {
                    //sacar Totales
                    SacarTotales();
                }
            }
        }
        decimal SumMN, SumME;
        public void SacarTotales()
        {
            decimal TotalMN = 0, TotalME = 0;
            SumME = SumMN = 0;
            foreach (DataGridViewRow item in Dtgconten.Rows)
            {
                if (_Moneda == 1)
                {
                    SumME += Configuraciones.Redondear((item.Cells[importemex.Name].Value == null ? 0 : decimal.Parse(item.Cells[importemex.Name].Value.ToString() == "" ? "0" : item.Cells[importemex.Name].Value.ToString())));
                    SumMN += Configuraciones.Redondear(item.Cells[importemnx.Name].Value == null ? 0 : decimal.Parse(item.Cells[importemnx.Name].Value.ToString() == "" ? "0" : item.Cells[importemnx.Name].Value.ToString()));
                    TotalME += Configuraciones.Redondear((item.Cells[importemex.Name].Value == null ? 0 : decimal.Parse(item.Cells[importemex.Name].Value.ToString() == "" ? "0" : item.Cells[importemex.Name].Value.ToString())) *
                     (item.Cells[tipocambiox.Name].Value == null ? 1 : decimal.Parse(item.Cells[tipocambiox.Name].Value.ToString() == "" ? "1" : item.Cells[tipocambiox.Name].Value.ToString())));
                    TotalMN += Configuraciones.Redondear(item.Cells[importemnx.Name].Value == null ? 0 : decimal.Parse(item.Cells[importemnx.Name].Value.ToString() == "" ? "0" : item.Cells[importemnx.Name].Value.ToString()));
                }
                else
                {
                    TotalME += Configuraciones.Redondear(item.Cells[importemex.Name].Value == null ? 0 : decimal.Parse(item.Cells[importemex.Name].Value.ToString() == "" ? "0" : item.Cells[importemex.Name].Value.ToString()));
                    TotalMN += Configuraciones.Redondear((item.Cells[importemnx.Name].Value == null ? 0 : decimal.Parse(item.Cells[importemnx.Name].Value.ToString() == "" ? "0" : item.Cells[importemnx.Name].Value.ToString())) /
                        (item.Cells[tipocambiox.Name].Value == null ? 1 : decimal.Parse(item.Cells[tipocambiox.Name].Value.ToString() == "" ? "1" : item.Cells[tipocambiox.Name].Value.ToString())));
                    SumME += Configuraciones.Redondear((item.Cells[importemex.Name].Value == null ? 0 : decimal.Parse(item.Cells[importemex.Name].Value.ToString() == "" ? "0" : item.Cells[importemex.Name].Value.ToString())));
                    SumMN += Configuraciones.Redondear(item.Cells[importemnx.Name].Value == null ? 0 : decimal.Parse(item.Cells[importemnx.Name].Value.ToString() == "" ? "0" : item.Cells[importemnx.Name].Value.ToString()));
                }
            }
            txttotalmonextranjera.Text = Math.Abs(TotalME).ToString("n2");
            txttotalmonedaNacional.Text = Math.Abs(TotalMN).ToString("n2");
            txttotalme.Text = SumME.ToString("n2");
            txttotalmn.Text = SumMN.ToString("n2");
            txtdiferencia.Text = Math.Abs((decimal.Parse(txttotal.Text)) - (_Moneda == 1 ? Math.Abs(TotalMN) : Math.Abs(TotalME))).ToString("n2");
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
        frmComprobantePago frmcomprobante;
        int filas = 0;
        private void Dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0 && x < Dtgconten.RowCount - 1)
            {
                if (y == Dtgconten.Columns[idcomprobantex.Name].Index)
                {
                    CargarComprobantes();
                }
                if (y == Dtgconten.Columns[fk_Monedax.Name].Index)
                {
                    CargarMonedas();
                }
                if (y == Dtgconten.Columns[butoncomprobantex.Name].Index && estado == 2)
                {
                    if (frmcomprobante == null)
                    {
                        frmcomprobante = new frmComprobantePago();
                        frmcomprobante.BuscarValor = true; filas = x;
                        frmcomprobante.MdiParent = MdiParent;
                        frmcomprobante.FormClosed += Frmcomprobante_FormClosed;
                        frmcomprobante.Show();
                        frmcomprobante.txtBuscar.Text = Dtgconten[idcomprobantex.Name, x].EditedFormattedValue.ToString();
                    }
                    else frmcomprobante.Activate();
                }
                if (y == Dtgconten.Columns[buttonCentroCosto.Name].Index && estado == 2)
                {
                    frmccosto ccosto = new frmccosto();
                    ccosto.Consulta = true;
                    if (ccosto.ShowDialog() == DialogResult.OK)
                        Dtgconten[centrocostox.Name, x].Value = ccosto.ConsulCodi;
                }
                if (y == Dtgconten.Columns[btnborrar.Name].Index && estado == 2)
                {
                    if (HPResergerFunciones.Utilitarios.msgYesNo("Seguro Desea Borrar Fila") == DialogResult.Yes)
                    {
                        Dtgconten.Rows.Remove(Dtgconten.Rows[Dtgconten.CurrentRow.Index]);
                        SacarTotales();
                        msj("");
                    }
                }
            }
        }
        private void Frmcomprobante_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmcomprobante.CodigoSunat != 0) Dtgconten[idcomprobantex.Name, filas].Value = frmcomprobante.CodigoSunat;
            frmcomprobante = null;
        }
        private void Dtgconten_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            msj("");
            int x = e.RowIndex;
            if (x == 0)
            {
                //Dtgconten[fechaemisionx.Name, 0].Value = _fechaEmision;
                //Dtgconten[FechaVencimientox.Name, 0].Value = _fecha.AddMonths(1).AddDays(-1);
                //Dtgconten[FechaRecepcionx.Name, 0].Value = _fecha;

                ////Dtgconten[tipocambiox.Name, 0].Value = _TipoCambio;
                //Dtgconten[fk_Monedax.Name, 0].Value = _Moneda;

                //Dtgconten[numcomprobantex.Name, 0].Value = "0";
                //Dtgconten[codcomprobantex.Name, 0].Value = "0";
                //Dtgconten[tipodocx.Name, 0].Value = 0;
                //Dtgconten[numdocx.Name, 0].Value = "0";
            }
            else
            {
                if (Dtgconten[numcomprobantex.Name, x - 1].Value.ToString() == "")
                {
                    Dtgconten[fechaemisionx.Name, x - 1].Value = _fechaEmision;
                    Dtgconten[FechaVencimientox.Name, x - 1].Value = _fecha.AddMonths(1).AddDays(-1);
                    Dtgconten[FechaRecepcionx.Name, x - 1].Value = _fecha;

                    Dtgconten[fk_Monedax.Name, x - 1].Value = _Moneda;
                    Dtgconten[tipocambiox.Name, x - 1].Value = _TipoCambio;

                    Dtgconten[numcomprobantex.Name, x - 1].Value = "0";
                    Dtgconten[codcomprobantex.Name, x - 1].Value = "0";
                    Dtgconten[tipodocx.Name, x - 1].Value = 0;
                    Dtgconten[numdocx.Name, x - 1].Value = "0";
                }
            }

            //if (Dtgconten[tipocambiox.Name, x].Value != null)
            ////  if (Dtgconten[tipocambiox.Name, x].Value.ToString() != "")
            //{
            //    if (Dtgconten[tipocambiox.Name, x].Value.ToString() == "") Dtgconten[tipocambiox.Name, x].Value = _TipoCambio;
            //    if ((decimal)Dtgconten[tipocambiox.Name, x].Value == 0)
            //    {
            //        if (Dtgconten.RowCount == 0)
            //        {
            //            Dtgconten[tipocambiox.Name, 0].Value = _TipoCambio;
            //            Dtgconten[fk_Monedax.Name, 0].Value = _Moneda;
            //        }
            //        else
            //        {
            //            Dtgconten[tipocambiox.Name, x - 1].Value = _TipoCambio;
            //            Dtgconten[fk_Monedax.Name, x - 1].Value = _Moneda;
            //        }
            //    }
            //}
            //else
            //{
            //    if (x > 0)
            //    {
            //        Dtgconten[tipocambiox.Name, x - 1].Value = _TipoCambio;
            //        Dtgconten[fk_Monedax.Name, x - 1].Value = _Moneda;
            //    }
            //}
            if (x == 1)
            {
                if ((Dtgconten[importemnx.Name, 0].Value.ToString() == "" ? 0 : (decimal)Dtgconten[importemnx.Name, 0].Value) == 0 && (Dtgconten[importemex.Name, 0].Value.ToString() == "" ? 0 : (decimal)Dtgconten[importemex.Name, 0].Value) == 0)
                    if (_Moneda == 1)
                        Dtgconten[importemnx.Name, 0].Value = decimal.Parse(txttotal.Text);
                    else
                        Dtgconten[importemex.Name, 0].Value = decimal.Parse(txttotal.Text);
            }
            SacarTotales();
        }
        private void Dtgconten_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //SacarTotales();
            //msj("");
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
        int FilaPos = 0;
        frmproveedor frmprovee;
        private void Dtgconten_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void Frmprovee_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmprovee != null)
            {
                if (frmprovee.llamada == 1)
                {
                    if (FilaPos == Dtgconten.RowCount - 1)
                        Datos.Rows.Add();
                    if (Dtgconten[numdocx.Name, FilaPos].Value == null) Datos.Rows.Add();
                    try
                    {
                        if (Dtgconten[numdocx.Name, FilaPos].Value.ToString() == frmprovee.rucito)
                        {
                            Dtgconten_CellValueChanged(sender, new DataGridViewCellEventArgs(Dtgconten.Columns[numdocx.Name].Index, FilaPos));
                        }
                        Dtgconten[numdocx.Name, FilaPos].Value = frmprovee.rucito;
                        Dtgconten[tipodocx.Name, FilaPos].Value = frmprovee.tipoid;
                    }
                    catch (Exception) { msg("No se Pudo Agregar Porque se necesita una fila Nueva"); }
                }
            }
            frmprovee = null;
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
                            if (frmprovee == null)
                            {
                                frmprovee = new frmproveedor();
                                frmprovee.Txtbusca.Text = Dtgconten[numdocx.Name, x].Value.ToString();
                                FilaPos = x;
                                frmprovee.llamada = 1;
                                frmprovee.Icon = Icon;
                                frmprovee.MdiParent = ParentForm;
                                frmprovee.FormClosed += Frmprovee_FormClosed;
                                frmprovee.Show();
                            }
                            else frmprovee.Activate();
                        }
                    }
                    else
                    {
                        if (frmlispersonas == null)
                        {
                            Dtgconten.EndEdit();
                            frmlispersonas = new frmListarSeleccionarPersonas((int)Dtgconten[tipodocx.Name, e.RowIndex].Value, Dtgconten[numdocx.Name, e.RowIndex].Value.ToString());
                            IndexPos = e.RowIndex;
                            frmlispersonas.FormClosed += Frmlispersonas_FormClosed;
                            frmlispersonas.Show();
                        }
                        else frmlispersonas.Activate();
                    }
                }
            }
        }
        int IndexPos;
        private void Frmlispersonas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmlispersonas.Busqueda)
            {
                if (Dtgconten.CurrentCell.RowIndex == Dtgconten.RowCount - 1)
                    Datos.Rows.Add();
                else if (Dtgconten[numdocx.Name, FilaPos].Value == null) Datos.Rows.Add();
                ////
                Dtgconten[tipodocx.Name, IndexPos].Value = frmlispersonas.TipoId;
                Dtgconten[numdocx.Name, IndexPos].Value = frmlispersonas.NroDoc;
                Dtgconten.EndEdit();
                Dtgconten.RefreshEdit();
            }
            frmlispersonas = null;
        }
        frmListarSeleccionarPersonas frmlispersonas;
        private void Dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Dtgconten.RowCount > 0)
            {
                int x = e.RowIndex, y = e.ColumnIndex;
                //tipodoc
                Combo = Dtgconten.Columns[tipodocx.Name] as DataGridViewComboBoxColumn;
                //Combo.DataSource = tipoDoc;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "descripcion";
                Combo.DataSource = tipoDoc;
                //moneda
                Combo = Dtgconten.Columns[fk_Monedax.Name] as DataGridViewComboBoxColumn;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "descripcion";
                Combo.DataSource = Monedas;
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
                ///cuentas bancarias
                Combo = Dtgconten.Columns[xCtaBancaria.Name] as DataGridViewComboBoxColumn;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "descripcion";
                Combo.AutoComplete = true;
                Combo.DataSource = TcuentasBancarias;
                //if (estado == 2)
                //{
                //    if ((Dtgconten[tipodocx.Name, x].Value == null ? "" : Dtgconten[tipodocx.Name, x].Value.ToString()) == "")
                //        Dtgconten[tipodocx.Name, x].Value = 0;
                //    if ((Dtgconten[idcomprobantex.Name, x].Value == null ? "" : Dtgconten[idcomprobantex.Name, x].Value.ToString()) == "")
                //        Dtgconten[idcomprobantex.Name, x].Value = 0;
                //}
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
