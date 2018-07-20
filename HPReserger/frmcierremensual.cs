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
            cboempresa.SelectedIndex = 0;
        }
        public void CargarEmpresa()
        {
            cboempresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboempresa_Click(object sender, EventArgs e)
        {
            string cadena = cboempresa.SelectedText;
            CargarEmpresa();
            cboempresa.Text = cadena;
        }
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cuando selecciono algo del index
            if (cboempresa.Items.Count > 0)
            {                
                cboperiodo.DataSource = CapaLogica.Periodos(10, (int)cboempresa.SelectedValue);
                cboperiodo.ValueMember = "mesaño";
                cboperiodo.DisplayMember = "mesaño";
            }
        }
        private void cboperiodo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboperiodo.SelectedIndex < 0)
            {
                btnaceptar.Enabled = true;
            }
            else { btnaceptar.Enabled = false; }
        }
    }
}
