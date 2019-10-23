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
    public partial class frmArticuloModificar : FormGradient
    {
        HPResergerCapaLogica.HPResergerCL clModificarArticuloServicio = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        public int numero { get; set; }
        public int TipoArticuloModificar { get; set; }
        public int CodigoArticuloModificar { get; set; }
        public string ArticuloModificar { get; set; }
        public int CodigoMarcaModificar { get; set; }
        public string MarcaModificar { get; set; }
        public int CodigoModeloModificar { get; set; }
        public string ModeloModificar { get; set; }
        public string CantidadModificar { get; set; }
        public string ObservacionesModificar { get; set; }
        public int ItemModificar { get; set; }
        public int Modo { get; set; }

        public frmArticuloModificar()
        {
            InitializeComponent();
        }

        private void frmArticuloModificar_Load(object sender, EventArgs e)
        {
            cboArticuloServicio.ValueMember = "Id_Articulo";
            cboArticuloServicio.DisplayMember = "Descripcion";
            cboArticuloServicio.DataSource = clModificarArticuloServicio.ItemCombo(TipoArticuloModificar + 1);
            cboArticuloServicio.Text = ArticuloModificar;

            cboMarca.ValueMember = "IdMarcas";
            cboMarca.DisplayMember = "Marcas";
            cboMarca.DataSource = clModificarArticuloServicio.MarcaArticulo(CodigoArticuloModificar);
            cboMarca.Text = MarcaModificar;

            cboModelo.ValueMember = "IdModelos";
            cboModelo.DisplayMember = "Modelos";
            cboModelo.DataSource = clModificarArticuloServicio.ModeloArticulo(CodigoMarcaModificar, CodigoArticuloModificar);
            cboModelo.Text = ModeloModificar;

            if (TipoArticuloModificar == 0)
            {
                cboMarca.Enabled = true;
                cboModelo.Enabled = true;
                txtCantidad.Text = CantidadModificar;
                txtCantidad.Enabled = true;
                txtObservaciones.Enabled = false;
            }
            else
            {
                cboMarca.Enabled = false;
                cboModelo.Enabled = false;
                txtCantidad.Enabled = false;
                txtObservaciones.Text = ObservacionesModificar;
                txtObservaciones.Enabled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (TipoArticuloModificar == 0)
            {
                clModificarArticuloServicio.OrdenPedidoDetalleModificar(0, this.numero, Convert.ToInt32(txtCantidad.Text), this.CodigoArticuloModificar, Convert.ToInt32(cboArticuloServicio.SelectedValue.ToString()), this.CodigoMarcaModificar, Convert.ToInt32(cboMarca.SelectedValue.ToString()), this.CodigoModeloModificar, Convert.ToInt32(cboModelo.SelectedValue.ToString()), "");
            }
            else
            {
                clModificarArticuloServicio.OrdenPedidoDetalleModificar(1, this.numero, 0, this.CodigoArticuloModificar, Convert.ToInt32(cboArticuloServicio.SelectedValue.ToString()), 1, 1, 1, 1, txtObservaciones.Text.ToString().Trim());
            }

            this.CodigoArticuloModificar = Convert.ToInt32(cboArticuloServicio.SelectedValue.ToString());
            this.ArticuloModificar = cboArticuloServicio.Text.ToString().Trim();
            this.CodigoMarcaModificar = Convert.ToInt32(cboMarca.SelectedValue.ToString());
            this.MarcaModificar = cboMarca.Text.ToString().Trim();
            this.CodigoModeloModificar = Convert.ToInt32(cboModelo.SelectedValue.ToString());
            this.ModeloModificar = cboModelo.Text.ToString().Trim();
            this.Modo = 1;

            if (TipoArticuloModificar == 0)
            {
                this.CantidadModificar = txtCantidad.Text.ToString().Trim();
            }
            else
            {
                this.ObservacionesModificar = txtObservaciones.Text.ToString().Trim();
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void cboArticuloServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboArticuloServicio.SelectedIndex > -1 && cboArticuloServicio.Items.Count > 0)
            {
                cboMarca.ValueMember = "IdMarcas";
                cboMarca.DisplayMember = "Marcas";
                cboMarca.DataSource = clModificarArticuloServicio.MarcaArticulo(Convert.ToInt32(cboArticuloServicio.SelectedValue.ToString()));
            }
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboArticuloServicio.SelectedIndex > -1 && cboArticuloServicio.Items.Count > 0)
            {
                cboModelo.ValueMember = "IdModelos";
                cboModelo.DisplayMember = "Modelos";
                cboModelo.DataSource = clModificarArticuloServicio.ModeloArticulo(Convert.ToInt32(cboMarca.SelectedValue.ToString()), Convert.ToInt32(cboArticuloServicio.SelectedValue.ToString()));
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAceptar.Focus();
            }
        }

        private void txtObservaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAceptar.Focus();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //this.CodigoArticuloModificar = Convert.ToInt32(cboArticuloServicio.SelectedValue.ToString());
            //this.ArticuloModificar = cboArticuloServicio.Text.ToString().Trim();
            //this.CodigoMarcaModificar = Convert.ToInt32(cboMarca.SelectedValue.ToString());
            //this.MarcaModificar = cboMarca.Text.ToString().Trim();
            //this.CodigoModeloModificar = Convert.ToInt32(cboModelo.SelectedValue.ToString());
            //this.ModeloModificar = cboModelo.Text.ToString().Trim();
            //this.Modo = 0;

            //if (TipoArticuloModificar == 0)
            //{
            //    this.CantidadModificar = txtCantidad.Text.ToString().Trim();
            //}
            //else
            //{
            //    this.ObservacionesModificar = txtObservaciones.Text.ToString().Trim();
            //}

            //this.DialogResult = System.Windows.Forms.DialogResult.OK;
            //this.Close();
        }
    }
}
