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
    public partial class frmFicModificar : FormGradient
    {
        public int ItemDetalle { get; set; }
        public int FIC { get; set; }
        public DateTime Fecha { get; set; }
        public string GuiaRemision { get; set; }
        public int ordencompra { get; set; }
        public string Proveedor { get; set; }
        public int CodigoArticulo { get; set; }
        public string Articulo { get; set; }
        public int CodigoMarca { get; set; }
        public string Marca { get; set; }
        public int CodigoModelo { get; set; }
        public string Modelo { get; set; }
        public string CantOC { get; set; }
        public string CantFIC { get; set; }
        public string CentroCosto { get { return txtcentrocosto.Text; } set { txtcentrocosto.Text = value; } }
        int ccc;
        public int cc { get { return ccc; } set { ccc = value; } }
        HPResergerCapaLogica.HPResergerCL clModificarFIC = new HPResergerCapaLogica.HPResergerCL();

        public frmFicModificar()
        {
            InitializeComponent();
        }
        public int tipo = 0;
        private void txtGuia_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void frmFicModificar_Load(object sender, EventArgs e)
        {
            txtFIC.Text = Convert.ToString(FIC);
            dtpFecha.Value = Fecha.Date;
            txtGuia.Text = GuiaRemision;

            txtArticulo.Text = Articulo;
            txtMarca.Text = Marca;
            txtModelo.Text = Modelo;
            txtCantOC.Text = Convert.ToString(Convert.ToInt32(CantOC) + Convert.ToInt32(CantFIC));
            txtCantFIC.Text = CantFIC;
            txtCantFIC.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtGuia.Text.Length == 0)
            {
                msg("Ingrese Guía de Remisión");
                txtGuia.Focus();
                return;
            }

            if (txtCantFIC.Text.Length == 0 || Convert.ToInt32(txtCantFIC.Text) == 0)
            {
                msg("Cantidad FIC inválida");
                txtCantFIC.Focus();
                return;
            }
            if (Convert.ToInt32(txtGuia.Text) != Convert.ToInt32(GuiaRemision))
            {
                DataTable dtGuiaRemisionProveedorM = clModificarFIC.OrdenCompraProveedor(Proveedor, Convert.ToInt32(txtGuia.Text), ordencompra, tipo);
                if (dtGuiaRemisionProveedorM.Rows.Count > 0)
                {
                    msg(lblguia.Text + " ya existe");
                    txtGuia.Focus();
                    return;
                }
            }

            if (Convert.ToInt32(txtCantOC.Text) < Convert.ToInt32(txtCantFIC.Text))
            {
                msg("Cantidad FIC NO puede ser mayor a Cantidad OC");
                txtCantFIC.Focus();
                return;
            }

            clModificarFIC.FICModificarCabecera(Convert.ToInt32(txtFIC.Text), dtpFecha.Value, Convert.ToInt32(txtGuia.Text));
            clModificarFIC.FICEliminarItemDetalle(ItemDetalle, FIC, CodigoArticulo, CodigoMarca, CodigoModelo);
            clModificarFIC.FICDetalleInsertar(FIC, CodigoArticulo, CodigoMarca, CodigoModelo, Convert.ToInt32(txtCantFIC.Text), "", tipo, ccc);

            HPResergerFunciones.frmInformativo.MostrarDialog("FIC modificado con éxito");
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        private void txtCantFIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtcentrocosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArticulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
