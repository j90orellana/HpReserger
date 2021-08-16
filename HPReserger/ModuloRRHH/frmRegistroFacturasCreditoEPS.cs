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

namespace HPReserger.ModuloRRHH
{
    public partial class frmRegistroFacturasCreditoEPS : FormGradient
    {
        public frmRegistroFacturasCreditoEPS()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public int Estado
        {
            get { return estado; }
            set
            {
                estado = value;
                //
                cboperiodo.Enabled = false;

                cboFacturas.ReadOnly = cboEmpresa.ReadOnly = true;
                //dtgconten.ReadOnly = true;
                btnNuevo.Enabled = true; btnProcesar.Enabled = btnModificar.Enabled = false;
                dtgconten.Enabled = true;
                btnBusFac.Enabled = false;

                if (estado == 1) //Nuevo
                {
                    btnModificar.Enabled = btnNuevo.Enabled = false;
                    btnBusFac.Enabled = btnProcesar.Enabled = true;
                    dtgconten.Enabled = false;
                    //
                    cboperiodo.Enabled = true;
                    cboFacturas.ReadOnly = cboEmpresa.ReadOnly = false;
                }
                else if (estado == 2) // Modificar
                {
                    btnModificar.Enabled = btnNuevo.Enabled = false;
                    btnBusFac.Enabled = btnProcesar.Enabled = true;
                    dtgconten.Enabled = false;
                    //
                    cboperiodo.Enabled = true;
                    cboFacturas.ReadOnly = false;// cboEmpresa.ReadOnly = false;
                }
            }
        }
        private int estado;
        private void frmRegistroFacturasCreditoEPS_Load(object sender, EventArgs e)
        {
            Estado = 0;
            CargarEmpresa();

        }
        public void CargarEmpresa()
        {
            cboEmpresa.ValueMember = "codigo";
            cboEmpresa.DisplayMember = "descripcion";
            cboEmpresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Estado = 1;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Estado = 2;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (Estado == 0) this.Close();
            Estado--;
        }
        private decimal _Sumatoria;
        public decimal Sumatoria
        {
            get { return _Sumatoria; }
            set
            {
                _Sumatoria = value;
                txttotal.Text = _Sumatoria.ToString("n2");
            }
        }
        private void btnBusFac_Click(object sender, EventArgs e)
        {
            ModuloFacturacion.frmListarFacturas frmListaFacturas = new ModuloFacturacion.frmListarFacturas(true, true, true, cboFacturas.ValueMember, Sumatoria);
            frmListaFacturas.ValEmpresa = cboEmpresa.Text;

            if (frmListaFacturas.ShowDialog() == DialogResult.OK)
            {
                cboFacturas.ValueMember = string.Join(",", frmListaFacturas.ListadoFactura.ToArray());
                Sumatoria = frmListaFacturas.Sumatoria;
            }
        }
    }
}
