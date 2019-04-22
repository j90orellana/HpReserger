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
        private void btnProveedor_Click(object sender, EventArgs e)
        {
            if (frmprovee == null)
            {
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
            frmClientes frmclien = new frmClientes();
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
            frmListarEmpleados frmLE = new frmListarEmpleados();
            this.Hide();
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
