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
    public partial class frmVendedores : FormGradient
    {
        public frmVendedores()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmVendedores_Load(object sender, EventArgs e)
        {
            estado = 0;
            CargarTipoId();
            CargarEstados();
            LimpiarTextos();
            CargarDatos();
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CapaLogica.Vendedor();
            lblmsg.Text = $"Total de Registros : {dtgconten.RowCount}";
            if (dtgconten.RowCount > 0) btnmodificar.Enabled = true; else btnmodificar.Enabled = false;
        }
        public int LengthTipoId
        {
            get { return txtnroid.MaxLength; }
            set { txtnroid.MaxLength = value; }
        }
        private void CargarTipoId()
        {
            cbotipoid.ValueMember = "codigo";
            cbotipoid.DisplayMember = "valor";
            cbotipoid.DataSource = CapaLogica.TiposID(0, 0, "", 0);
        }
        public void LimpiarTextos()
        {
            txtnombre.CargarTextoporDefecto();
            txtnumven.CargarTextoporDefecto();
            txtgerencia.CargarTextoporDefecto();
            txtcargo.CargarTextoporDefecto();
            txtarea.CargarTextoporDefecto();
            txtapellido.CargarTextoporDefecto();
        }
        public void CargarEstados()
        {
            DataTable TEstados = new DataTable();
            TEstados.Columns.Add("Valor", typeof(int));
            TEstados.Columns.Add("Codigo");
            TEstados.Rows.Add(0, "Activo");
            TEstados.Rows.Add(1, "Inactivo");
            cboestado.DisplayMember = "codigo";
            cboestado.ValueMember = "valor";
            cboestado.DataSource = TEstados;
        }
        public int estado { get; set; }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                this.Close();
            }
            estado = 0;
            ModoEdicion(false);
            LimpiarTextos();
            CargarDatos();
        }
        public void CargarGrilla()
        {
            dtgconten.DataSource = new DataTable();
            lblmsg.Text = $"Total de Registros : {dtgconten.RowCount}";
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            btnaceptar.Enabled = true;
            ModoEdicion(true);
            txtnroid.CargarTextoporDefecto();
            txtnroid.Focus();
        }
        public void ModoEdicion(Boolean a)
        {
            btnaceptar.Enabled = a;
            btnnuevo.Enabled = btnmodificar.Enabled = !a;
            dtgconten.Enabled = !a;
            cbotipoid.Enabled = btnbuscar.Enabled = cboestado.Enabled = a;
            txtnroid.ReadOnly = !a;
            txtnroid.Focus();
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2;
            ModoEdicion(true);
            cbotipoid.Enabled = false;
            txtnroid.ReadOnly = true;
            btnbuscar.Enabled = false;
        }
        private void cbotipoid_Click(object sender, EventArgs e)
        {
            if (cbotipoid.Items.Count > 0)
            {
                string cadena = cbotipoid.Text;
                cbotipoid.ValueMember = "codigo";
                cbotipoid.DisplayMember = "valor";
                cbotipoid.DataSource = CapaLogica.TiposID(0, 0, "", 0);
                cbotipoid.Text = cadena;
            }
        }
        private void cbotipoid_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow TiposId;
            if (cbotipoid.SelectedIndex >= 0)
            {
                TiposId = (CapaLogica.TiposID((int)cbotipoid.SelectedValue)).Rows[0]; ////Length
                LengthTipoId = (int)TiposId["Length"];
            }
            txtnroid_TextChanged(sender, e);
        }
        //codigo de busqueda!!!!
        private void txtnroid_TextChanged(object sender, EventArgs e)
        {
            if (txtnroid.EstaLLeno())
            {
                DataTable TDatos = new DataTable();
                TDatos = CapaLogica.Vendedor(10, (int)cbotipoid.SelectedValue, txtnroid.Text, 0, 0);
                if (TDatos.Rows.Count > 0)
                {
                    DataRow filita = TDatos.Rows[0];
                    txtapellido.Text = filita["apellido"].ToString();
                    txtarea.Text = filita["area"].ToString();
                    txtcargo.Text = filita["cargo"].ToString();
                    txtgerencia.Text = filita["gerencia"].ToString();
                    txtnombre.Text = filita["nombres"].ToString();
                }
                else LimpiarTextos();
            }
            else
            {
                LimpiarTextos();
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            frmListarEmpleados frmlisemp = new frmListarEmpleados();
            if (frmlisemp.ShowDialog() == DialogResult.OK)
            {
                cbotipoid.SelectedValue = frmlisemp.TipoDocumento;
                txtnroid.Text = frmlisemp.NumeroDocumento;
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (!txtnroid.EstaLLeno())
            {
                txtnroid.Focus();
                msg("Ingrese Número Documento");
                return;
            }
            if (txtnroid.Text.Length != LengthTipoId)
            {
                txtnroid.Focus();
                msg("El Tamaño del Número de Documento no coincide con el Tipo");
                return;
            }
            if (cbotipoid.SelectedIndex < 0)
            {
                cbotipoid.Focus();
                msg("Seleccione un Tipo de Documento");
                return;
            }
            if (cbotipoid.Items.Count == 0)
            {
                cbotipoid.Focus();
                msg("No hay Tipos de Documentos");
                return;
            }
            //estadod  de insercion
            if (estado == 1)
            {
                if ((CapaLogica.Vendedor(5, (int)cbotipoid.SelectedValue, txtnroid.Text, 0, 0)).Rows.Count > 0)
                {
                    msg("El Vendedor Ya Existe");
                    return;
                }
                CapaLogica.Vendedor(1, (int)cbotipoid.SelectedValue, txtnroid.Text, (int)cboestado.SelectedValue, frmLogin.CodigoUsuario);
                msg("Agregado Exitosamente");
            }
            //estado de modificacion
            else if (estado == 2)
            {
                int codvend = (int)dtgconten[idvend.Name, dtgconten.CurrentRow.Index].Value;
                CapaLogica.Vendedor(codvend, 2, (int)cbotipoid.SelectedValue, txtnroid.Text, (int)cboestado.SelectedValue, frmLogin.CodigoUsuario);
                cbotipoid.Enabled = true;
                txtnroid.ReadOnly = false;
                btnbuscar.Enabled = true;
                msg("Modificado Exitosamente");
            }
            ModoEdicion(false);
            LimpiarTextos();
            txtnroid.CargarTextoporDefecto();
            estado = 0;
            CargarDatos();
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (x >= 0)
            {
                DataGridViewRow fila = dtgconten.Rows[x];
                cbotipoid.SelectedValue = (int)fila.Cells[tipoid.Name].Value;
                txtnroid.Text = fila.Cells[nroid.Name].Value.ToString();
                txtapellido.Text = fila.Cells[apellidos.Name].Value.ToString();
                txtarea.Text = fila.Cells[area.Name].Value.ToString();
                txtcargo.Text = fila.Cells[cargo.Name].Value.ToString();
                txtgerencia.Text = fila.Cells[gerencia.Name].Value.ToString();
                txtnombre.Text = fila.Cells[nombres.Name].Value.ToString();
                txtnumven.Text = fila.Cells[idvend.Name].Value.ToString();
                cboestado.SelectedValue = fila.Cells[estadox.Name].Value;
            }
        }
    }
}
