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
    public partial class frmNroOpBancacia : FormGradient
    {
        public frmNroOpBancacia()
        {
            InitializeComponent();
        }
        List<int> lista;
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmNroOpBancacia_Load(object sender, EventArgs e)
        {
            CodigoBanco = 0;
            CargarBancos();
            LimpiarDatos();
            CargarGrilla();
            lista = new List<int>();
        }
        DataTable TDatos;
        public void CargarGrilla()
        {
            int c = 0;
            TDatos = CapaLogica.ListarNroOpBancaria(CodigoBanco, cbocuenta.SelectedValue.ToString(), txtruc.TextValido(), txtrazon.TextValido(), txtnrobanco.TextValido(), dtpfecha1.Value, dtpfecha2.Value);
            foreach (DataRow item in TDatos.Rows)//id   ok
            {
                int valor = (int)item["id"];
                if (lista != null)
                    if (lista.Find(cust => cust == valor) > 0)
                    {
                        c++;
                        item["ok"] = 1;
                    }
            }
            OrdernarDatos();
        }
        public void OrdernarDatos()
        {
            if (TDatos != null)
            {
                DataView dt = TDatos.DefaultView;
                dt.Sort = "ok desc";
                TDatos = dt.ToTable();
                dtgconten.DataSource = TDatos;
                int c = lista == null ? 0 : lista.Count;
                lblmsg.Text = $"Total de Registros : {dtgconten.RowCount}  Seleccionados : {c}";
            }
        }
        public void CargarBancos()
        {
            DataTable TBanco = new DataTable();
            string cadena = cbobanco.Text;
            cbobanco.ValueMember = "codigo";
            cbobanco.DisplayMember = "descripcion";
            TBanco = CapaLogica.getCargoTipoContratacion("sufijo", "Entidad_Financiera", "TBL_Entidad_Financiera");
            DataRow Rowcito = TBanco.NewRow();
            Rowcito[0] = "NADA";
            Rowcito[1] = "NINGUNO";
            TBanco.Rows.InsertAt(Rowcito, 0);
            cbobanco.DataSource = TBanco;
            cbobanco.Text = cadena;
        }
        private void btnseleccion_Click(object sender, EventArgs e)
        {
            dtgconten.EndEdit();
            if (dtgconten.RowCount > 0)
            {
                //Boolean estado = false;
                //if (dtgconten[okx.Name, 0].Value == null)
                //    estado = false;
                //else
                //    estado = dtgconten[okx.Name, 0].Value.ToString() == "1" ? true : false;
                int y = 0;
                int val = 0;
                if (btnseleccion.Text == "Seleccionar Todos") val = 1;
                foreach (DataGridViewRow xx in dtgconten.Rows)
                {
                    if (xx.Cells[NroOPBancox.Name].Value.ToString() == "")
                    {
                        if ((int)xx.Cells[okx.Name].Value == val && val == 0) lista.Remove((int)xx.Cells[idx.Name].Value);
                        else
                        {
                            xx.Cells[okx.Name].Value = val;
                            dtgconten_CellContentClick(sender, new DataGridViewCellEventArgs(0, y));
                            y++;
                        }
                    }
                }
                if (val == 1)
                {
                    btnseleccion.Text = "Deseleccionar  Todos";
                    OrdernarDatos();
                }
                else
                {
                    btnseleccion.Text = "Seleccionar Todos";
                }
            }
        }
        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgconten.EndEdit();
            int x = e.RowIndex, y = e.ColumnIndex;
            if (dtgconten.RowCount > 0)
            {
                if (dtgconten.Columns[botonx.Name].Index == y)
                {
                    if (dtgconten[y, x].Value.ToString() == "Editar")
                    {
                        frmDetalleNroOp frmnroop = new frmDetalleNroOp(dtgconten[Proveedorx.Name, x].Value.ToString(), dtgconten[Razonx.Name, x].Value.ToString(), dtgconten[NroFacturax.Name, x].Value.ToString(), dtgconten[Bancox.Name, x].Value.ToString());
                        frmnroop.Codigo = (int)dtgconten[idx.Name, x].Value;
                        frmnroop.nrooperacion = dtgconten[NroOPBancox.Name, x].Value.ToString();
                        frmnroop.ShowDialog();
                        CargarGrilla();
                    }
                }
            }
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
        }
        private void cbobanco_Click(object sender, EventArgs e)
        {
            CargarBancos();
        }
        public int CodigoBanco { get; set; }
        private void cbobanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbobanco.SelectedIndex >= 0)
            {
                cbocuenta.Text = "";
                cbocuenta.ValueMember = "Id_Cuenta_Contable";
                cbocuenta.DisplayMember = "banco";
                DataTable TCuentas = new DataTable();
                TCuentas = CapaLogica.ListarBancosTiposdePago(cbobanco.SelectedValue.ToString());
                DataRow filita = TCuentas.NewRow();
                filita[0] = "";
                filita[1] = "NINGUNA";
                TCuentas.Rows.InsertAt(filita, 0);
                cbocuenta.DataSource = TCuentas;
                //Extrae el codigo del banco
                if (CapaLogica.EntidadFinanciera(10, 0, "", cbobanco.SelectedValue.ToString()).Rows.Count == 0)
                    CodigoBanco = 0;
                else
                    CodigoBanco = int.Parse((CapaLogica.EntidadFinanciera(10, 0, "", cbobanco.SelectedValue.ToString()).Rows[0])["id_entidad"].ToString());
            }
            CargarGrilla();
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }
        public void LimpiarDatos()
        {
            dtpfecha1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfecha2.Value = new DateTime(DateTime.Now.Year, 12, 31);
            txtruc.CargarTextoporDefecto();
            txtnrobanco.CargarTextoporDefecto();
            txtrazon.CargarTextoporDefecto();
            cbobanco.SelectedIndex = 0;
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
        }
        private void txtruc_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void txtrazon_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void txtnrobanco_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void dtpfecha1_ValueChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void dtpfecha2_ValueChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void cbocuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (!txtnroid.EstaLLeno())
            {
                txtnroid.Focus();
                msg("Ingrese Número de Operación");
                return;
            }
            foreach (int item in lista)
            {
                CapaLogica.ActualizarNroOperacion(item, txtnroid.TextValido());
            }
            msg("Actualizado Número de Operación");
            txtnroid.CargarTextoporDefecto();
            lista.Clear();
            LimpiarDatos();
        }
        private void dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                if (dtgconten[NroOPBancox.Name, x].Value.ToString() != "")
                {
                    if (dtgconten[okx.Name, x].Value.ToString() != "0")
                    {
                        dtgconten[okx.Name, x].Value = 0;
                    }
                }
                //Proceso de Cambio
                if (dtgconten[okx.Name, x].Value.ToString() == "")
                {
                    lista.Remove((int)dtgconten[idx.Name, x].Value);
                }
                else if (dtgconten[okx.Name, x].Value.ToString() == "0")
                {
                    lista.Remove((int)dtgconten[idx.Name, x].Value);
                }
                else if ((int)dtgconten[okx.Name, x].Value == 1)
                {
                    lista.Add((int)dtgconten[idx.Name, x].Value);
                }
            }
            int c = lista == null ? 0 : lista.Count;
            lblmsg.Text = $"Total de Registros : {dtgconten.RowCount}  Seleccionados : {c}";
            //OrdernarDatos();
        }
        private void dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x == -1)
            {
                if (dtgconten.Columns[okx.Name].Index == y)
                {
                    //ordernar Por click
                    DataView dt = TDatos.DefaultView;
                    dt.Sort = "ok desc";
                    TDatos = dt.ToTable();
                    dtgconten.EndEdit();
                }
            }
            if (x >= 0)
            {
            }
        }
        DataGridViewButtonCell Combo;
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            //if (x >= 0)
            //{
            //    Combo = dtgconten.Rows[x].Cells[botonx.Name] as DataGridViewButtonCell;
            //    //Combo.DataSource = tipoDoc;
            //    if (Combo.Value.ToString() == "")                
            //}
        }
    }
}
