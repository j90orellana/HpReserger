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
    public partial class frmcierremensual : FormGradient
    {
        public frmcierremensual()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmcierremensual_Load(object sender, EventArgs e)
        {
            CargarEmpresa();
        }
        public void CargarEmpresa()
        {
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
            cboempresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        frmListarAsientosAbiertos frmlis;
        DataTable Datos;
        private void cboempresa_Click(object sender, EventArgs e)
        {
            string cadena = cboempresa.SelectedText;
            CargarEmpresa();
            cboempresa.Text = cadena;
        }
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cuando selecciono algo del index
            btncerrar.Enabled = false;
            if (cboempresa.SelectedIndex >= 0)
            {
                cboperiodo.DataSource = CapaLogica.Periodos(10, (int)cboempresa.SelectedValue);
                cboperiodo.ValueMember = "fechax";
                cboperiodo.DisplayMember = "mesaño";
            }
            if (cboperiodo.Items.Count > 0)
                btnaceptar.Enabled = true;
            else
            {
                btnaceptar.Enabled = false;
            }
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Datos = new DataTable();
            Datos.Columns.Add("Proceso");
            Datos.Columns.Add("Resultado");
            Datos.Columns.Add("ver");
            dtgconten1.DataSource = Datos;
            Datos.Rows.Add("Verificando Asientos Abiertos", "Buscando Asientos Abiertos");
            Datos.Rows.Add("Verificando Saldos Pendientes", "Buscando Saldos Pendientes");
            ///verifico si hay asientos abiertos           
            DataTable asientos = CapaLogica.ListarAsientosAbiertos(0, (int)cboempresa.SelectedValue, (DateTime)cboperiodo.SelectedValue);
            btncerrar.Enabled = true;
            if (asientos.Rows.Count != 0)
            {
                dtgconten1[resultadox.Name, 0].Value = "Se Encontraron Asientos Abiertos";
                dtgconten1[Verx.Name, 0].Value = "Ver";
                //frmlis = new frmListarAsientosAbiertos((int)cboempresa.SelectedValue, (DateTime)cboperiodo.SelectedValue);
                //frmlis.MdiParent = MdiParent;
                //btncerrar.Enabled = false;
                //frmlis.FormClosed += Frmlis_FormClosed;
                //frmlis.Show();
            }
            else
            {
                dtgconten1[resultadox.Name, 0].Value = "No hay Asientos Abiertos";
                dtgconten1[Verx.Name, 0].Value = "";
            }
            //verificando los saldos pendientes
            dtgconten1[Verx.Name, 1].Value = "";
            dtgconten1[resultadox.Name, 1].Value = "No hay Saldos Pendientes";
        }
        private void Frmlis_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmlis = null;
        }
        private void dtgconten1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (y == dtgconten1.Columns[Verx.Name].Index && dtgconten1[y, x].Value.ToString() == "Ver")
            {
                if (frmlis == null)
                {
                    frmlis = new frmListarAsientosAbiertos((int)cboempresa.SelectedValue, (DateTime)cboperiodo.SelectedValue);
                    frmlis.MdiParent = MdiParent;
                    btncerrar.Enabled = false;
                    frmlis.FormClosed += Frmlis_FormClosed;
                    frmlis.Show();
                }
                else { frmlis.Focus(); }
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {

        }
    }
}
