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
    public partial class frmFicModificar : Form
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
                MessageBox.Show("Ingrese Guía de Remisión", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtGuia.Focus();
                return;
            }

            if (txtCantFIC.Text.Length == 0 || Convert.ToInt32(txtCantFIC.Text) == 0)
            {
                MessageBox.Show("Cantidad FIC inválida", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCantFIC.Focus();
                return;
            }

            if (Convert.ToInt32(txtGuia.Text) != Convert.ToInt32(GuiaRemision))
            {
                DataTable dtGuiaRemisionProveedorM = clModificarFIC.OrdenCompraProveedor(Proveedor, Convert.ToInt32(txtGuia.Text), ordencompra,tipo);
                if (dtGuiaRemisionProveedorM.Rows.Count > 0)
                {
                    MessageBox.Show(lblguia.Text + " ya existe", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtGuia.Focus();
                    return;
                }
            }

            if (Convert.ToInt32(txtCantOC.Text) < Convert.ToInt32(txtCantFIC.Text))
            {
                MessageBox.Show("Cantidad FIC NO puede ser mayor a Cantidad OC", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCantFIC.Focus();
                return;
            }

            clModificarFIC.FICModificarCabecera(Convert.ToInt32(txtFIC.Text), dtpFecha.Value, Convert.ToInt32(txtGuia.Text));
            clModificarFIC.FICEliminarItemDetalle(ItemDetalle, FIC, CodigoArticulo, CodigoMarca, CodigoModelo);
            clModificarFIC.FICDetalleInsertar(FIC, CodigoArticulo, CodigoMarca, CodigoModelo, Convert.ToInt32(txtCantFIC.Text), "", tipo);

            MessageBox.Show("FIC modificado con éxito", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void txtCantFIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
