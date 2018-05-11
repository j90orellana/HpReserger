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
    public partial class frmDetalleAsientos : FormGradient
    {
        public frmDetalleAsientos()
        {
            InitializeComponent();
        }
        int estado = 0;
        public int idasiento { get { return int.Parse(txtnumasiento.Text); } set { txtnumasiento.Text = value.ToString(); } }
        public int asiento;
        public string cuenta { get { return txtcuenta.Text; } set { txtcuenta.Text = value; } }
        public string descripcion { get { return txtdescripcion.Text; } set { txtdescripcion.Text = value; } }
        public decimal Total { get { return decimal.Parse(txttotal.Text); } set { txttotal.Text = value.ToString("n2"); } }
        public DateTime fecha;

        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmDetalleAsientos_Load(object sender, EventArgs e)
        {
            SacarDatos();
            CargarDatos();
            estado = 0;
            Dtgconten.ReadOnly = true;
        }
        public void SacarDatos()
        {
            Dtgconten.DataSource = CapaLogica.DetalleAsientos(0, asiento, idasiento);
            msj("");
        }
        DataTable tipoDoc;
        DataTable tipoComprobante;
        DataTable Centroc, CentroCosto;
        public void CargarDatos()
        {
            tipoDoc = new DataTable();
            tipoDoc = CapaLogica.getCargoTipoContratacion("Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");
            tipoComprobante = new DataTable();
            tipoComprobante = CapaLogica.getCargoTipoContratacion("Id_Comprobante", "Nombre", "TBL_Comprobante_Pago");
            Centroc = new DataTable();
            Centroc = CapaLogica.ListarCentroCostos();
            CentroCosto = new DataTable();
            CentroCosto.Columns.Add("codigo", typeof(int));
            CentroCosto.Columns.Add("descripcion");
            CentroCosto.Clear();
            foreach (DataRow item in Centroc.Rows)
            {
                if (item["Id_CtaCtble"].ToString() != "")
                    CentroCosto.Rows.Add(item["Id_CCosto"], item["Id_CtaCtble"] + "-" + item["CentroCosto"]);
            }
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
                    msg($"Revise Los Montos no pueden superar el Total Del Registro: Asiento {Total.ToString("n2")} DEtalle {Sumatoria.ToString("n2")} ");
                    return;
                }
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (item.Cells[razonsocialx.Name].Value != null)
                    //if (item.Cells[razonsocialx.Name].Value.ToString() != "")
                    {
                        if (item.Cells[tipodocx.Name].Value.ToString() == "")
                            item.Cells[tipodocx.Name].Value = 1;
                        if (item.Cells[idcomprobantex.Name].Value.ToString() == "")
                            item.Cells[idcomprobantex.Name].Value = 1;

                        if (item.Cells[centrocostox.Name].Value == null)
                        {
                            msg($"Seleccioné Centro de Costo, Fila {item.Index + 1}");
                            return;
                        }
                        if (item.Cells[centrocostox.Name].Value.ToString() == "")
                        {
                            msg($"Seleccioné Centro de Costo, Fila {item.Index + 1}");
                            return;
                        }
                        if (item.Cells[tipodocx.Name].Value.ToString() == "")
                        {
                            msg($"Seleccioné Tipo Documento, Fila {item.Index + 1}");
                            return;
                        }
                        if (item.Cells[numdocx.Name].Value.ToString() == "")
                        {
                            // msg($"Seleccioné Número Documento, Fila {item.Index + 1}");
                            item.Cells[numdocx.Name].Value = 0;
                            // return;
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
                    }
                }
                CapaLogica.DetalleAsientos(10, asiento, idasiento);
                foreach (DataGridViewRow item in Dtgconten.Rows)
                {
                    if (item.Cells[numdocx.Name].Value != null)
                        if (item.Cells[numdocx.Name].Value.ToString() != "")
                        {
                            CapaLogica.DetalleAsientos(1, asiento, idasiento, cuenta, (int)item.Cells[tipodocx.Name].Value,
                                item.Cells[numdocx.Name].Value.ToString(), item.Cells[razonsocialx.Name].Value.ToString(), (int)item.Cells[idcomprobantex.Name].Value, item.Cells[codcomprobantex.Name].Value.ToString(), item.Cells[numcomprobantex.Name].Value.ToString(),
                                int.Parse(item.Cells[centrocostox.Name].Value.ToString()), item.Cells[glosax.Name].Value.ToString(), (DateTime)item.Cells[fechaemisionx.Name].Value, (decimal)item.Cells[importemnx.Name].Value, (decimal)item.Cells[importemex.Name].Value,
                                 (decimal)item.Cells[tipocambiox.Name].Value, frmLogin.CodigoUsuario);
                        }
                }
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

        }
        public void msj(string cadena)
        {
            lblmsg.Text = $"Total de Registros :{Dtgconten.RowCount} " + cadena;
        }
        public DialogResult MSG(string cadena)
        {
            return MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void Dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int y = Dtgconten.CurrentCell.ColumnIndex, x = Dtgconten.CurrentCell.RowIndex;
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
                if (y == Dtgconten.Columns[codcomprobantex.Name].Index || y == Dtgconten.Columns[numcomprobantex.Name].Index || y == Dtgconten.Columns[numdocx.Name].Index)
                {
                    txt = e.Control as TextBox;
                    if (txt != null)
                    {
                        txt.KeyPress -= new KeyPressEventHandler(Txt_KeyPressSoloNumeros);
                        txt.KeyPress += new KeyPressEventHandler(Txt_KeyPressSoloNumeros);
                    }
                }
                if (y == Dtgconten.Columns[glosax.Name].Index || y == Dtgconten.Columns[fechaemisionx.Name].Index || y == Dtgconten.Columns[razonsocialx.Name].Index)
                {
                    txt = e.Control as TextBox;
                    if (txt != null)
                    {
                        txt.KeyPress -= new KeyPressEventHandler(Txt_KeyPress);
                        txt.KeyPress -= new KeyPressEventHandler(Txt_KeyPressSoloNumeros);
                    }
                }
            }
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txt.Text);
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
            if (x >= 0)
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
        }

        private void Dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
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
            //Dtgconten[fechaemisionx.Name, y].Value = new DateTime(1990, 1, 1);
            //Dtgconten[idcomprobantex.Name,y].Value = 1;
            //Dtgconten[tipodocx.Name, y].Value = 1;
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

        private void Dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Dtgconten.RowCount > 0)
            {
                int y = e.RowIndex;
                //tipodoc
                Combo = Dtgconten.Columns[tipodocx.Name] as DataGridViewComboBoxColumn;
                Combo.DataSource = tipoDoc;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "descripcion";
                //tipocomprobante
                Combo = Dtgconten.Columns[idcomprobantex.Name] as DataGridViewComboBoxColumn;
                Combo.DataSource = tipoComprobante;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "descripcion";
                //centrocosto
                Combo = Dtgconten.Columns[centrocostox.Name] as DataGridViewComboBoxColumn;
                Combo.DataSource = CentroCosto;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "descripcion";
                Combo.AutoComplete = true;
            }
        }
    }
}
