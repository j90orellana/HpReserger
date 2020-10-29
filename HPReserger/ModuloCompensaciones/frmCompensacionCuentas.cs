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

namespace HPReserger.ModuloCompensaciones
{
    public partial class frmCompensacionCuentas : FormGradient
    {
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private int pkEmpresa;
        private int _Estado = 0;
        public int Estado
        {
            get { return _Estado; }
            set
            {
                _Estado = value;
                //Control del Formulario
                Boolean a = true;
                btnPaso1.Enabled = !a;
                if (value == 0)
                {
                    cboempresa.Enabled = a;
                    txtcuos.Enabled = a;
                    dtgconten.Enabled = !a;
                    btnPaso1.Enabled = a;
                    if (dtgconten.DataSource != null)
                    {
                        dtgconten.DataSource = ((DataTable)dtgconten.DataSource).Clone();
                    }
                    else dtgconten.DataSource = null;
                    lbltotalRegistros.Text = $"Total de Registros:{dtgconten.RowCount}";
                    contador = 0;
                    MostrarParteFinal();
                }
                else if (value == 1)
                {
                    cboempresa.Enabled = !a;
                    txtcuos.Enabled = !a;
                    dtgconten.Enabled = a;
                }
            }
        }
        public void msgError(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }
        public frmCompensacionCuentas()
        {
            InitializeComponent();
        }
        private void frmCompensacionCuentas_Load(object sender, EventArgs e)
        {
            dtpFechaContable.Value = dtpFechaEmision.Value = DateTime.Now;
            CargarTextxDefecto();
            Estado = 0;
            CargarEmpresa();
            CargarMonedas();
        }
        public void CargarMonedas()
        {
            CapaLogica.TablaMonedas(cbomoneda);
        }
        private void CargarTextxDefecto()
        {
            txtcuos.CargarTextoporDefecto();
            txtCuenta.CargarTextoporDefecto();
            txtGlosa.CargarTextoporDefecto();
        }
        public void CargarEmpresa()
        {
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
            cboempresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
        }

        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pkEmpresa != (int)(cboempresa.SelectedValue))
            {
                pkEmpresa = (int)cboempresa.SelectedValue;
                cboproyecto.DataSource = CapaLogica.ListarProyectosEmpresa(cboempresa.SelectedValue.ToString());
                cboproyecto.DisplayMember = "proyecto";
                cboproyecto.ValueMember = "id_proyecto";
            }
        }
        private void cboempresa_Click(object sender, EventArgs e)
        {
            string cadena = cboempresa.Text;
            DataTable Table = CapaLogica.Empresa();
            if (cboempresa.Items.Count != Table.Rows.Count)
                cboempresa.DataSource = Table;
            cboempresa.Text = cadena;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (Estado == 0)
            {
                this.Close();
            }
            else Estado--;
        }
        DataTable Tdatos = new DataTable();
        private int contador;

        private void btnPaso1_Click(object sender, EventArgs e)
        {
            if (cboempresa.SelectedValue == null) { msgError("Seleccione una Empresa"); cboempresa.Focus(); return; }
            if (Configuraciones.ValidarSQLInyect(txtcuos)) { msgError("Codigo Malicioso Detectado"); txtcuos.Focus(); return; }
            if (!txtcuos.EstaLLeno()) { msgError("Ingrese 2 CUOS minimos"); txtcuos.Focus(); return; }
            if ((txtcuos.TextValido().Split(',')).Count() < 2) { msgError("Ingrese 2 CUOS minimos"); txtcuos.Focus(); return; }
            List<string> Listado = new List<string>();
            Tdatos = CapaLogica.CompensacionDeCuentas(pkEmpresa, txtcuos.TextValido());
            foreach (DataRow item in Tdatos.Rows)
            {
                if (!Listado.Contains(item["cuo"].ToString())) Listado.Add(item["cuo"].ToString());
            }
            if (Listado.Count < 2) { msgError("CUOS invalidos, verifique que los CUOS Existan"); return; }
            Estado++;
            dtgconten.DataSource = Tdatos;
            lbltotalRegistros.Text = $"Total de Registros:{dtgconten.RowCount}";
            //Cambio de color de fondo por cuos
            int pos = 0;
            string cuo = "";
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if (item.Cells[xCUO.Name].Value.ToString() != cuo)
                {
                    pos = pos == 0 ? 1 : 0;
                }
                cuo = item.Cells[xCUO.Name].Value.ToString();
                if (pos == 0)
                    item.DefaultCellStyle.BackColor = Color.White;
                else
                    item.DefaultCellStyle.BackColor = Color.FromArgb(220, 230, 241);
            }
        }
        decimal SumaSoles = 0, SumaDolares = 0;
        private void dtgconten_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.ColumnIndex == dtgconten.Columns[xok.Name].Index)
                {
                    CalcularTotales();
                }
        }
        private void txtCuenta_DoubleClick(object sender, EventArgs e)
        {
            frmlistarcuentas cuentitas = new frmlistarcuentas();
            cuentitas.Icon = Icon;

            cuentitas.Txtbusca.Text = txtCuenta.Text;
            cuentitas.radioButton1.Checked = true;
            cuentitas.ShowDialog();
            if (cuentitas.aceptar)
                txtCuenta.Text = cuentitas.codigo;
        }
        private void txtCuenta_TextChanged(object sender, EventArgs e)
        {
            if (txtCuenta.EstaLLeno())
            {
                DataTable TAble = CapaLogica.BuscarCuentas(txtCuenta.Text, 1);
                if (TAble.Rows.Count > 0)
                    txtdescripcion.Text = TAble.Rows[0][0].ToString();
                else txtdescripcion.Text = "";
            }
            else txtdescripcion.CargarTextoporDefecto();

        }

        private void dtgconten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.ColumnIndex == dtgconten.Columns[xok.Name].Index)
                {
                    dtgconten.EndEdit(); dtgconten.RefreshEdit();
                    // CalcularTotales();
                }
        }

        private void CalcularTotales()
        {
            SumaSoles = 0; SumaDolares = 0;
            contador = 0;
            if (Estado == 1)
            {
                foreach (DataRow item in Tdatos.Rows)
                {
                    if ((int)item[xok.DataPropertyName] == 1)
                    {
                        contador++;
                        SumaSoles += (decimal)item[xDebeSoles.DataPropertyName] - (decimal)item[xHaberSoles.DataPropertyName];
                        SumaDolares += (decimal)item[xDebeDolares.DataPropertyName] - (decimal)item[xHaberDOlares.DataPropertyName];
                    }

                }
            }
            MostrarParteFinal();
        }

        private void MostrarParteFinal()
        {
            //Bloquear Controles
            Boolean a = true;
            txtCuenta.Enabled = !a;
            txtdescripcion.Enabled = !a;
            txtGlosa.Enabled = !a;
            btnProcesar.Visible = !a;
            txtSoles.Text = txtDolares.Text = "0.00";
            //
            cboproyecto.Enabled = !a;
            cbomoneda.Enabled = !a;
            dtpFechaContable.Enabled = !a;
            dtpFechaEmision.Enabled = !a;
            if (contador > 1)
            {
                //Desbloquearlos
                txtCuenta.Enabled = a;
                txtdescripcion.Enabled = a;
                txtGlosa.Enabled = a;
                btnProcesar.Visible = a;
                txtSoles.Text = txtDolares.Text = SumaSoles.ToString("n2");
                txtDolares.Text = SumaDolares.ToString("n2");
                cboproyecto.Enabled = cbomoneda.Enabled = dtpFechaContable.Enabled = dtpFechaEmision.Enabled = a;

            }
        }
    }
}
