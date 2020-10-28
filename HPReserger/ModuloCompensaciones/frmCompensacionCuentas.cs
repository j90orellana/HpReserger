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
        private int Estado = 0;
        public int _Estado
        {
            get { return Estado; }
            set { Estado = value; }
        }

        public frmCompensacionCuentas()
        {
            InitializeComponent();
        }
        private void frmCompensacionCuentas_Load(object sender, EventArgs e)
        {
            Estado = 0;
            CargarEmpresa();
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

        private void btnPaso1_Click(object sender, EventArgs e)
        {
            Estado++;
        }
    }
}
