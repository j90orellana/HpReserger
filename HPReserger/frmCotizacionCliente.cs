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
    public partial class frmCotizacionCliente : FormGradient
    {
        public frmCotizacionCliente()
        {
            InitializeComponent();
        }
        public int LengthTipoId
        {
            get { return txtnroid.MaxLength; }
            set { txtnroid.MaxLength = value; }
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        int estado = 0;
        private void frmCotizacionCliente_Load(object sender, EventArgs e)
        {
            LimpiarTextBoxs();
            CargarCombitoTipoid();
            ModoMuestra();
            cbotipoid.Enabled = true;
            txtnroid.ReadOnly = false;
        }
        public void LimpiarTextBoxs()
        {
            LimpiarControlesEdicion(txtdireccion, txtemail, txtnombre, txtnroid, txtocupacion, txttelcelular, txttelfijo, txtapemat, txtapetpat);
        }
        public void ModoMuestra()
        {
            Configuraciones.Activar(dtgconten);
            Configuraciones.Desactivar(txtdireccion, txtemail, txtnombre, txtnroid, txtocupacion, txttelcelular, txttelfijo, txtapemat, txtapetpat, txtubicacion);
        }
        public void ModoEdicion()
        {
            //proceso de edicion------
            Configuraciones.Activar(txtdireccion, txtemail, txtnombre, txtnroid, txtocupacion, txttelcelular, txttelfijo, txtapemat, txtapetpat);
            Configuraciones.Desactivar(dtgconten);
        }
        public void CargarCombitoTipoid()
        {
            cbotipoid.ValueMember = "codigo";
            cbotipoid.DisplayMember = "valor";
            cbotipoid.DataSource = CapaLogica.TiposID(0, 0, "", 0);
        }
        private void LimpiarControlesEdicion(params object[] control)
        {
            foreach (object item in control)
            {
                if (!((TextBoxPer)item).EstaLLeno())
                {
                    //((TextBoxPer)item).Clear();
                    ((TextBoxPer)item).CargarTextoporDefecto();
                }
            }
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
        DataRow TiposId;
        private void cbotipoid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotipoid.SelectedIndex >= 0)
            {
                TiposId = (CapaLogica.TiposID((int)cbotipoid.SelectedValue)).Rows[0]; ////Length
                LengthTipoId = (int)TiposId["Length"];
            }
            txtnroid_TextChanged(sender, e);
        }
        DataTable TablaCLiente;
        private void txtnroid_TextChanged(object sender, EventArgs e)
        {
            ///PROCESO DE BUSQUEDA DE CLIENTE
            if (cbotipoid.SelectedIndex >= 0)
            {
                btncotizar.Enabled = false;
                TablaCLiente = CapaLogica.BuscarCliente((int)cbotipoid.SelectedValue, txtnroid.TextValido());
                if (TablaCLiente.Rows.Count != 0)
                {
                    DataRow filita = TablaCLiente.Rows[0];
                    txtapemat.Text = filita["Apemat_Cli"].ToString();
                    txtapetpat.Text = filita["Apepat_RazSoc_Cli"].ToString();
                    txtdireccion.Text = filita["Direccion"].ToString();
                    txtemail.Text = filita["E_mail"].ToString();
                    txtnombre.Text = filita["apellidos"].ToString();
                    txtocupacion.Text = filita["Ocupacion"].ToString();
                    txttelcelular.Text = filita["Telf_Celular"].ToString();
                    txttelfijo.Text = filita["Telf_Fijo"].ToString();
                    txtubicacion.Text = $"{Configuraciones.MayusculaCadaPalabra(filita["Ddepartamento"].ToString())} - {Configuraciones.MayusculaCadaPalabra(filita["dprovincia"].ToString())} - {Configuraciones.MayusculaCadaPalabra(filita["ddistrito"].ToString())} ";
                    btncotizar.Enabled = true;
                }
                else LimpiarControles(txtdireccion, txtemail, txtnombre, txtocupacion, txttelcelular, txttelfijo, txtapemat, txtapetpat, txtubicacion);
            }
        }
        private void LimpiarControles(params object[] control)
        {
            foreach (object item in control)
            {
                if (((Control)item).AccessibilityObject.Role == AccessibleRole.ComboBox)
                    ((ComboBoxPer)item).SelectedIndex = -1;
                else
                {
                    ((TextBoxPer)item).Clear();
                    ((TextBoxPer)item).CargarTextoporDefecto();
                }
            }
        }
        public void msg(string cadena)
        {
            HPResergerFunciones.Utilitarios.msg(cadena);
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            frmClientes frmclien = new frmClientes();
            frmclien.rdnrodoc.Checked = true;
            frmclien.codigoid = (int)cbotipoid.SelectedValue;
            frmclien.CodigoDocBuscar = txtnroid.TextValido();
            frmclien.Buscando = true;
            if (frmclien.ShowDialog() == DialogResult.OK)
            {
                cbotipoid.SelectedValue = frmclien.codigoid;
                txtnroid.Text = frmclien.codigodoc;
                txtnroid_TextChanged(sender, e);
            }
            frmclien = null;
        }
        public void ProcesoDeCotizar(Boolean Cotizar)
        {
            cbotipoid.Enabled = !Cotizar;
            txtnroid.ReadOnly = Cotizar;
            btncotizar.Enabled = !Cotizar;
            btnaceptar.Enabled = Cotizar;
            btnbuscar.Enabled = !Cotizar;
            dtgconten.ReadOnly = !Cotizar;
        }
        private void btncotizar_Click(object sender, EventArgs e)
        {
            estado = 1;
            ProcesoDeCotizar(true);
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                this.Close();
            }
            else if (estado == 1)
            {
                ProcesoDeCotizar(false);
            }
            estado = 0;
        }
    }
}
