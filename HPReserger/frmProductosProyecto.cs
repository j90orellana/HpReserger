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
    public partial class frmProductosProyecto : FormGradient
    {
        public frmProductosProyecto()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public frmProductosProyecto(int proyecto, string nombre)
        {
            InitializeComponent();
            codProyecto = proyecto;
            Text = "Productos del Proyecto -" + nombre;
        }
        public int codProyecto;
        DataTable Datos = new DataTable();
        public void CargarDatos()
        {
            dtgconten.DataSource = Datos = CapaLogica.Proyecto_Productos(codProyecto);
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
                cboproducto.SelectedValue = (int)dtgconten[Id_Prodx.Name, y].Value;
                txtprecio.Text = dtgconten[preciobasex.Name, y].Value.ToString();
                txtmetros.Text = dtgconten[metrosx.Name, y].Value.ToString();
                txtpiso.Text = dtgconten[pisox.Name, y].Value.ToString();
                txtetapa.Text = dtgconten[etapax.Name, y].Value.ToString();
                txtobservacion.Text = dtgconten[observacionx.Name, y].Value.ToString();
                cboestado.SelectedValue = (int)dtgconten[Estadox.Name, y].Value;
            }
        }
        DataTable Estados = new DataTable();
        public void CargarEstados()
        {
            Estados.Columns.Add("codigo", typeof(int));
            Estados.Columns.Add("valor");
            //
            Estados.Rows.Add(new object[] { 1, "DISPONIBLE" });
            Estados.Rows.Add(new object[] { 0, "NO DISPONIBLE" });
            Estados.Rows.Add(new object[] { 2, "COTIZADO" });
            Estados.Rows.Add(new object[] { 3, "SEPARADO" });
            Estados.Rows.Add(new object[] { 4, "VENDIDO" });
            cboestado.DisplayMember = "valor";
            cboestado.ValueMember = "codigo";
            cboestado.DataSource = Estados;
        }
        private void frmProductosProyecto_Load(object sender, EventArgs e)
        {
            CargarEstados();
            CargarProductos();
            CargarDatos();
            dtgconten.Location = new Point(dtgconten.Location.X, 96);
            dtgconten.Height += 64;
        }
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void Limpiar()
        {
            if (cboproducto.Items.Count > 0)
            {
                cboproducto.SelectedIndex = 0;
                cboproducto.SelectedIndex = 0;
            }
            else
                cboproducto.SelectedIndex = -1;
            cboestado.SelectedIndex = 0;
            txtetapa.Text = txtobservacion.Text = "";
            txtmetros.Text = txtpiso.Text = txtprecio.Text = "0";
        }
        public void ActivarEdicion()
        {
            Activar(txtetapa, txtmetros, txtobservacion, txtpiso, txtprecio, btnaceptar);//,cboproducto,cboestado);
            Desactivar(btnnuevo, btnmodificar, btneliminar, btnbuscar, btnactualizar, dtgconten);
        }
        public void DesactivarEdicion()
        {
            Desactivar(txtetapa, txtmetros, txtobservacion, txtpiso, txtprecio, btnaceptar);//, cboproducto, cboestado);
            Activar(btnnuevo, btnmodificar, btneliminar, btnbuscar, btnactualizar, dtgconten);
        }
        int estado = 0;
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            if (cboproducto.Items.Count > 0)
            {
                Limpiar();
                BotonBuscar();
                ActivarEdicion();
                estado = 1;
            }
            else
            {
                if (msg("No Hay Productos, Desea Ingresar Nuevos") == DialogResult.Yes)
                {
                    frmProductos frmpro = new frmProductos();
                    frmpro.Show();
                }

            }
        }
        public void BotonBuscar()
        {
            if (find)
                btnbuscar_Click(new object { }, new EventArgs());
        }
        public DialogResult msg(string cadena)
        {
            return MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult msgyESnO(string cadena)
        {
            return MessageBox.Show(cadena, CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado != 0)
            {
                estado = 0;
                DesactivarEdicion();
            }
            else
                this.Close();
            CargarDatos();
        }
        DataTable Productos = new DataTable();
        public void CargarProductos()
        {
            string text = cboproducto.Text;
            Productos = CapaLogica.ProductosProyecto(0, 0, "", 0);
            cboproducto.DisplayMember = "Producto";
            cboproducto.ValueMember = "id_prod";
            cboproducto.DataSource = Productos;
            cboproducto.Text = text;
        }
        private void cboproducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        frmProductos frmproduc;
        int CodigoProducto;
        private void btnmasproduc_Click(object sender, EventArgs e)
        {
            if (frmproduc == null)
            {
                frmproduc = new frmProductos();
                frmproduc.FormClosed += Frmproduc_FormClosed;
                frmproduc.dtgconten.CellDoubleClick += Frmproduc_DoubleClick;
                frmproduc.btnaceptar.Enabled = true;
                frmproduc.btnaceptar.DialogResult = DialogResult.OK;
                frmproduc.btncancelar.DialogResult = DialogResult.Cancel;
                if (frmproduc.ShowDialog() == DialogResult.OK)
                {
                    cboproducto.SelectedValue = CodigoProducto;
                }
            }
            else frmproduc.Activate();
        }
        private void Frmproduc_DoubleClick(object sender, EventArgs e)
        {
            frmproduc.DialogResult = DialogResult.OK;
        }
        private void Frmproduc_FormClosed(object sender, FormClosedEventArgs e)
        {
            CodigoProducto = frmproduc.CodigoProducto;
            frmproduc = null;
        }
        int Codregistro = 0;
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2;
            BotonBuscar();
            ActivarEdicion();
            Codregistro = (int)dtgconten.CurrentRow.Cells[idx.Name].Value;
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //ESTADO 1= NUEVO 2=MODIFICAR
            if (cboproducto.Items.Count <= 0)
            {
                btnmasproduc.Focus();
                msg("No Hay Productos");
                return;
            }
            if (!txtetapa.EstaLLeno())
            {
                txtetapa.Focus();
                msg("Ingrese Etapa");
                return;
            }
            if (!txtmetros.EstaLLeno())
            {
                txtmetros.Focus();
                msg("Ingrese Metros");
                return;
            }
            if (!txtpiso.EstaLLeno())
            {
                txtpiso.Focus();
                msg("Ingrese Piso");
                return;
            }
            if (!txtprecio.EstaLLeno())
            {
                txtprecio.Focus();
                msg("Ingrese Precio");
                return;
            }
            //NUEVO            
            if (estado == 1)
            {
                CapaLogica.Proyecto_Productos(0, 1, codProyecto, (int)cboproducto.SelectedValue, Convert.ToDecimal(txtmetros.Text), Convert.ToDecimal(txtprecio.Text), Convert.ToInt32(txtpiso.Text), txtetapa.Text, (int)cboestado.SelectedValue, txtobservacion.Text, frmLogin.CodigoUsuario);
                CargarDatos();
                msg("Producto del Proyecto Guardado");
                estado = 0;
            }
            //MODIFICAR
            if (estado == 2)
            {
                //BUSCA SI YA EXISTE               
                CapaLogica.Proyecto_Productos(Codregistro, 2, codProyecto, (int)cboproducto.SelectedValue, Convert.ToDecimal(txtmetros.Text), Convert.ToDecimal(txtprecio.Text), Convert.ToInt32(txtpiso.Text), txtetapa.Text, (int)cboestado.SelectedValue, txtobservacion.Text, frmLogin.CodigoUsuario);

                CargarDatos();
                msg("Producto del Proyecto Guardado");
                estado = 0;
            }
            DesactivarEdicion();
        }

        private void cboproducto_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }
        Boolean find = false;
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (dtgconten.Location.Y != 96)
            {
                dtgconten.Location = new Point(dtgconten.Location.X, 96);
                dtgconten.Height += 64;
                find = false;
            }
            else
            {
                dtgconten.Location = new Point(dtgconten.Location.X, 160);
                dtgconten.Height -= 64;
                find = true;
            }
        }

        private void txtfproduc_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
        public void buscar()
        {
            DataTable filtrado = Datos;
            if (Datos.Rows.Count > 0)
            {
                string filtro = $"producto like '%{txtfproduc.Text}%' and observacion like '%{txtfobservacion.Text}%' AND ESTADOLETRAS LIKE '%{txtfestado.Text}%' and etapa like '%{txtfetapa.Text}%' ";//;and precio_Base between {txtprecimin.Text} and {txtpreciomax.Text}";
                //CONCATENACION DE DECIMALES
                if (txtmetrosmin.EstaLLeno() && txtmetrosmax.EstaLLeno())
                {
                    decimal max = Math.Max(Convert.ToDecimal(txtmetrosmin.Text), Convert.ToDecimal(txtmetrosmax.Text));
                    decimal min = Math.Min(Convert.ToDecimal(txtmetrosmin.Text), Convert.ToDecimal(txtmetrosmax.Text));
                    filtro += $" and metros >= {min} and metros <= {max} ";
                } 
                if (txtprecimin.EstaLLeno() && txtpreciomax.EstaLLeno())
                {
                    decimal max = Math.Max(Convert.ToDecimal(txtprecimin.Text), Convert.ToDecimal(txtpreciomax.Text));
                    decimal min = Math.Min(Convert.ToDecimal(txtprecimin.Text), Convert.ToDecimal(txtpreciomax.Text));
                    filtro += $" and precio_base >= {min} and precio_base <= {max} ";
                }
                if (txtpisosmin.EstaLLeno() && txtpisosmax.EstaLLeno())
                {
                    decimal max = Math.Max(Convert.ToDecimal(txtpisosmin.Text), Convert.ToDecimal(txtpisosmax.Text));
                    decimal min = Math.Min(Convert.ToDecimal(txtpisosmin.Text), Convert.ToDecimal(txtpisosmax.Text));
                    filtro += $" and piso >= {min} and piso <= {max} ";
                }
                DataRow[] filitas = filtrado.Select(filtro);
                if (filitas.Length > 0)
                {
                    dtgconten.DataSource = filitas.CopyToDataTable();
                }
                else dtgconten.DataSource = Datos.Clone();
            }
        }

        private void txtfproduc_TextChanged_1(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtfestado.Text = txtfobservacion.Text = txtfproduc.Text = txtmetrosmin.Text = txtmetrosmax.Text = txtpisosmin.Text = txtpisosmax.Text = txtprecimin.Text = txtpreciomax.Text = txtfetapa.Text = "";
        }

        private void dtgconten_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ContadorRegistros();
        }
        public void ContadorRegistros()
        {
            string cadena = "";
            //string filter = "Sum(Producto)";
            //REVISAR FILTER
            cadena = $"Total Registros: {dtgconten.RowCount} ";
            msj(cadena);
        }
        public void msj(string cadena)
        {
            txtmensaje.Text = cadena;
        }
        private void dtgconten_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ContadorRegistros();
        }
    }
}
