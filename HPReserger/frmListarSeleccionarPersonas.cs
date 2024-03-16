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
    public partial class frmListarSeleccionarPersonas : FormGradient
    {
        public frmListarSeleccionarPersonas(int _Tipo, string _nrodoc)
        {
            TipoId = _Tipo;
            NroDoc = _nrodoc;
            InitializeComponent();
        }
        public frmListarSeleccionarPersonas(int[] tipos)
        {
            Cerrar = true;
            InitializeComponent();
            btnCliente.Visible = btnEmpleado.Visible = btnProveedor.Visible = false;
            foreach (int item in tipos)
            {
                if (item == 1) btnProveedor.Visible = true;
                if (item == 2) btnCliente.Visible = true;
                if (item == 3) btnEmpleado.Visible = true;
            }
        }
        public int Menu = 0;
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public frmListarSeleccionarPersonas()
        {
            InitializeComponent();
        }
        public int TipoId = 0;
        public String NroDoc = "";
        public Boolean Busqueda = false;
        private void ListarSeleccionarPersonas_Load(object sender, EventArgs e)
        {

        }
        frmproveedor frmprovee;

        public bool Cerrar { get; private set; }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            if (Cerrar) { DialogResult = DialogResult.Yes; return; }
            if (frmprovee == null)
            {
                Menu = 1;
                frmprovee = new frmproveedor();
                frmprovee.Txtbusca.Text = NroDoc;
                frmprovee.llamada = 1;
                frmprovee.Icon = Icon;
                frmprovee.MdiParent = ParentForm;
                frmprovee.FormClosed += Frmprovee_FormClosed;
                this.Hide();
                frmprovee.Show();
            }
            else frmprovee.Activate();
        }
        private void Frmprovee_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmprovee != null)
            {
                if (frmprovee.llamada == 1)
                {
                    NroDoc = frmprovee.rucito;
                    TipoId = frmprovee.tipoid;
                    Busqueda = true;
                }
            }
            frmprovee = null;
            this.Close();
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (Cerrar) { DialogResult = DialogResult.No; return; }

            frmClientes frmclien = new frmClientes();
            Menu = 2;
            //frmclien.rdnrodoc.Checked = true;
            frmclien.codigoid = TipoId;
            frmclien.CodigoDocBuscar = NroDoc;
            frmclien.Buscando = true;
            this.Hide();
            if (frmclien.ShowDialog() == DialogResult.OK)
            {
                NroDoc = frmclien.codigodoc;
                TipoId = frmclien.codigoid;
                Busqueda = true;
                this.Close();
            }
            else this.Close();
        }
        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            if (Cerrar) { DialogResult = DialogResult.Retry; return; }

            frmListarEmpleados frmLE = new frmListarEmpleados();
            this.Hide();
            Menu = 3;
            if (frmLE.ShowDialog() == DialogResult.OK)
            {
                TipoId = frmLE.TipoDocumento;
                NroDoc = frmLE.NumeroDocumento;
                Busqueda = true;
                this.Close();
            }
            else this.Close();
        }
    }
}
