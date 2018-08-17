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
    public partial class frmComprobantePago : FormGradient
    {
        public frmComprobantePago()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        int estado = 0;
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado != 0)
            {
                estado = 0;
                HPResergerFunciones.Utilitarios.Activar(btnmodificar, btnnuevo, dtgconten, btnactualizar);
                HPResergerFunciones.Utilitarios.Desactivar(btnaceptar, txtdescripcion);
            }
            else
                this.Close();
            CargarComprobantes();
        }
        private void frmComprobantePago_Load(object sender, EventArgs e)
        {
            CargarComprobantes();
        }
        private int _Codigo;
        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }
        public void CargarComprobantes()
        {
            string cadena = txtdescripcion.Text;
            dtgconten.DataSource = CapaLogica.ComprobanteDePago();
            foreach (DataGridViewRow item in dtgconten.Rows)
                if (item.Cells[nombrex.Name].Value.ToString() == cadena)
                {
                    dtgconten.ClearSelection();
                    item.Selected = true;
                    dtgconten_RowEnter(dtgconten, new DataGridViewCellEventArgs(item.Cells[nombrex.Name].ColumnIndex,item.Index));
                    break;
                }
        }
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            CargarComprobantes();
        }        
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            ValidarSiHayDatos();
            if (y >= 0)
            {
                txtdescripcion.Text = dtgconten[nombrex.Name, y].Value.ToString();
                Codigo = (int)dtgconten[id_comprobantex.Name, y].Value;
                txtcodigo.Text = Codigo.ToString();
            }
        }
        public void ValidarSiHayDatos()
        {
            if (dtgconten.RowCount > 0)
            {
                btnmodificar.Enabled = true;
                //btneliminar.Enabled = true;               
            }
            else btnmodificar.Enabled = false;
        }
        private void dtgconten_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ValidarSiHayDatos();
        }
        private void dtgconten_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ValidarSiHayDatos();
        }
        public void LimpiarText()
        {
            txtdescripcion.Text = "";
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            CargarComprobantes();
            LimpiarText();
            HPResergerFunciones.Utilitarios.Desactivar(btnmodificar, btnnuevo, dtgconten, btnactualizar);
            HPResergerFunciones.Utilitarios.Activar(btnaceptar, txtdescripcion);
            txtdescripcion.Focus();
            estado = 1;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Codigo = (int)dtgconten.CurrentRow.Cells[id_comprobantex.Name].Value;
            estado = 2;
            HPResergerFunciones.Utilitarios.Desactivar(btnmodificar, btnnuevo, dtgconten, btnactualizar);
            HPResergerFunciones.Utilitarios.Activar(btnaceptar, txtdescripcion);
            txtdescripcion.Focus();
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //ESTADO 1= NUEVO 2=MODIFICAR
            if (!txtdescripcion.EstaLLeno())
            {
                txtdescripcion.Focus();
                HPResergerFunciones.Utilitarios.msg("Ingrese El Nombre del Comprobante");
                return;
            }
            //NUEVO
            DataRow filita;
            if (estado == 1)
            {
                //BUSCA SI YA EXISTE
                DataTable tablita = CapaLogica.ComprobanteDePago(5, 0, txtdescripcion.Text, frmLogin.CodigoUsuario, DateTime.Now);
                filita = tablita.Rows[0];
                if ((int)filita["cantidad"] != 0)
                {
                    HPResergerFunciones.Utilitarios.msg("Comprobante de Pago Ya Existe");
                    txtdescripcion.Focus();
                    return;
                }
                CapaLogica.ComprobanteDePago(1, Codigo, txtdescripcion.Text, frmLogin.CodigoUsuario, DateTime.Now);
                CargarComprobantes();
                HPResergerFunciones.Utilitarios.msg("Comprobante de Pago Guardado");
                estado = 0;
            }
            //MODIFICAR
            if (estado == 2)
            {
                //BUSCA SI YA EXISTE
                DataTable tablita = CapaLogica.ComprobanteDePago(6, Codigo, txtdescripcion.Text, frmLogin.CodigoUsuario, DateTime.Now);
                filita = tablita.Rows[0];
                if ((int)filita["cantidad"] != 0)
                {
                    HPResergerFunciones.Utilitarios.msg("Comprobante de Pago Ya Existe");
                    txtdescripcion.Focus();
                    return;
                }
                CapaLogica.ComprobanteDePago(2, Codigo, txtdescripcion.Text, frmLogin.CodigoUsuario, DateTime.Now);
                CargarComprobantes();
                HPResergerFunciones.Utilitarios.msg("Comprobante de Pago Guardado");
                estado = 0;
            }
            HPResergerFunciones.Utilitarios.Activar(btnmodificar, btnnuevo, dtgconten, btnactualizar);
            HPResergerFunciones.Utilitarios.Desactivar(btnaceptar, txtdescripcion);
        }
    }
}
