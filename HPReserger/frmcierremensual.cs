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
            dtgconten1.DataSource = Datos;
            Datos.Rows.Add("Verificando Asientos Abiertos", "Buscando Asientos Abiertos");
            Datos.Rows.Add("Verificando Saldos Pendientes", "Buscando Saldos Pendientes");
            ///verifico si hay asientos abiertos           
            DataTable asientos = CapaLogica.ListarAsientosAbiertos(0, (int)cboempresa.SelectedValue, (DateTime)cboperiodo.SelectedValue);
            btncerrar.Enabled = true;
            if (asientos.Rows.Count != 0)
            {
                Datos.Rows[0][1] = "Se Encontraron Asientos Abiertos";
                frmlis = new frmListarAsientosAbiertos((int)cboempresa.SelectedValue, (DateTime)cboperiodo.SelectedValue);
                frmlis.MdiParent = MdiParent;
                btncerrar.Enabled = false;
                frmlis.FormClosed += Frmlis_FormClosed;
                frmlis.Show();
            }
            else
                Datos.Rows[0][1] = "No hay Asientos Abiertos";
            //verificando los saldos pendientes
            Datos.Rows[1][1] = "No hay Saldos Pendientes";
        }
        private void Frmlis_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
