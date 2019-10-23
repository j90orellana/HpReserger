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
    public partial class frmProductos : FormGradient
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public int CodigoProducto { get; set; }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (dtgconten.RowCount > 0)
            {
                btnmodificar.Enabled = true;
                btneliminar.Enabled = true;
            }
            if (y >= 0)
            {
                txtdescripcion.Text = dtgconten[Nombrex.Name, y].Value.ToString();
                CodigoProducto = (int)dtgconten[codigox.Name, y].Value;
            }
        }
        public void LimpiarProductoNuevo()
        {
            txtdescripcion.Text = "";
        }
        public void Activar(params object[] control)
        {
            foreach (object x in control)
                ((Control)x).Enabled = true;
        }
        public void Desactivar(params object[] control)
        {
            foreach (object x in control)
                ((Control)x).Enabled = false;
        }
        int estado = 0;
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            CargarDatos();
            LimpiarProductoNuevo();
            Desactivar(btnmodificar, btnnuevo, btneliminar, dtgconten, btnactualizar, btnbuscar);
            Activar(btnaceptar, txtdescripcion);
            estado = 1;
        }
        int CodProducto = 0;
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            CodProducto = (int)dtgconten.CurrentRow.Cells[codigox.Name].Value;
            estado = 2;
            Desactivar(btnmodificar, btnnuevo, btneliminar, dtgconten, btnactualizar, btnbuscar);
            Activar(btnaceptar, txtdescripcion);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado != 0)
            {
                estado = 0;
                Activar(btnmodificar, btnnuevo, btneliminar, dtgconten, btnactualizar, btnbuscar);
                Desactivar(btnaceptar, txtdescripcion);
            }
            else
                this.Close();
            CargarDatos();
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = Datos = CapaLogica.ProductosProyecto(0, 0, "", 0);
        }
        private void frmProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //ESTADO 1= NUEVO 2=MODIFICAR
            if (!txtdescripcion.EstaLLeno())
            {
                txtdescripcion.Focus();
                msg("Ingrese El Nombre del Producto");
                return;
            }
            //NUEVO
            DataRow filita;
            if (estado == 1)
            {
                //BUSCA SI YA EXISTE
                DataTable tablita = CapaLogica.ProductosProyecto(0, 5, txtdescripcion.Text, frmLogin.CodigoUsuario);
                filita = tablita.Rows[0];
                if ((int)filita["cantidad"] != 0)
                {
                    msg("El Producto Ya Existe");
                    txtdescripcion.Focus();
                    return;
                }
                CapaLogica.ProductosProyecto(0, 1, txtdescripcion.Text, frmLogin.CodigoUsuario);
                CargarDatos();
                msgOK("Producto Guardado");
                estado = 0;
            }
            //MODIFICAR
            if (estado == 2)
            {
                //BUSCA SI YA EXISTE
                DataTable tablita = CapaLogica.ProductosProyecto(CodProducto, 6, txtdescripcion.Text, frmLogin.CodigoUsuario);
                filita = tablita.Rows[0];
                if ((int)filita["cantidad"] != 0)
                {
                    msg("El Producto Ya Existe");
                    txtdescripcion.Focus();
                    return;
                }
                CapaLogica.ProductosProyecto(CodProducto, 2, txtdescripcion.Text, frmLogin.CodigoUsuario);
                CargarDatos();
                msgOK("Producto Guardado");
                estado = 0;
            }
            Activar(btnmodificar, btnnuevo, btneliminar, dtgconten, btnactualizar, btnbuscar);
            Desactivar(btnaceptar, txtdescripcion);
        }
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
        DataTable Datos = new DataTable();
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            DataTable table = Datos;
            string filtro = $"producto like '%{txtdescripcion.Text}%'";
            DataRow[] Filas = table.Select(filtro);
            if (Filas.Length != 0)
                dtgconten.DataSource = Filas.CopyToDataTable();
            else dtgconten.DataSource = Datos;
        }

        private void txtdescripcion_Enter(object sender, EventArgs e)
        {
            txtdescripcion.SelectAll();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }
        public void VerSiHayDatos()
        {
            if (dtgconten.RowCount > 0)
            {
                btnmodificar.Enabled = true;
                btneliminar.Enabled = true;
            }
            else
            {
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
            }
        }
        private void dtgconten_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            VerSiHayDatos();
        }
        private void dtgconten_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            VerSiHayDatos();
        }
    }
}
