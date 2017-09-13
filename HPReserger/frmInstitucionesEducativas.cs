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
    public partial class frmInstitucionesEducativas : Form
    {
        public frmInstitucionesEducativas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CCargos = new HPResergerCapaLogica.HPResergerCL();
        int estado = 0;
        string tabla = "TBL_Cargo";
        string campo = "Cargo";
        string id = "Id_Cargo";
        public void iniciar(Boolean a)
        {
            btnnuevo.Enabled = !a;
            btnmodificar.Enabled = !a;
            btnaceptar.Enabled = a;
            dtgconten.Enabled = !a;
            btneliminar.Enabled = !a;
            txtruc.Enabled = a;
            txtdirecion.Enabled = a;
            txtnombre.Enabled = a;
            txtbuscar.Enabled = !a;
            btnborrar.Enabled = !a;
        }
        private void Msg(string cadena)
        {
            MessageBox.Show(cadena, "HpReseger", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CCargos.InsertarActualizarListarInstitucionEducativa("0", 0, "0", "0", 0);
            dtgconten.Focus();
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            iniciar(true);
            txtnombre.Text = txtdirecion.Text = txtruc.Text = "";
            //DataRow codigo = CCargos.VerUltimoIdentificador(tabla, id);
            //txtaporte.Text = (int.Parse(codigo["ultimo"].ToString()) + 1).ToString();
            txtruc.Focus();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2; btnmodificar.Enabled = false;
            iniciar(true); txtruc.Focus();
        }

        private void btnexportarExcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                List<HPResergerFunciones.Utilitarios.NombreCelda> Celditas = new List<HPResergerFunciones.Utilitarios.NombreCelda>();
                HPResergerFunciones.Utilitarios.NombreCelda Celdita = new HPResergerFunciones.Utilitarios.NombreCelda();
                Celdita.fila = 2; Celdita.columna = 1; Celdita.Nombre = "Listado de Instituciones Educactivas";
                Celditas.Add(Celdita);
                HPResergerFunciones.Utilitarios.ExportarAExcel(dtgconten, "", "Instituciones Educativas", Celditas, 1, new int[] {  }, new int[] { 1 }, new int[] { });
                Msg("Exportado con Exito");
            }
            else
                Msg("No hay Filas para Exportar");
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                this.Close();
            }
            else
            {
                iniciar(false);
                estado = 0;
            }
            CargarDatos();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtruc.Text))
            {
                Msg("Ingresé Ruc");
                txtruc.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtdirecion.Text))
            {
                Msg("Ingresé Dirección");
                txtdirecion.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                Msg("Ingresé Nombre");
                txtnombre.Focus();
                return;
            }
            /* decimal aportex = decimal.Parse(txtaporte.Text) / 100;
             decimal segurox = decimal.Parse(txtseguro.Text) / 100;
             decimal comisionx = decimal.Parse(txtcomision.Text) / 100;*/
            if (estado == 1)
            {
                //nuevo
                /* if (string.IsNullOrWhiteSpace(txtgerencia.Text))
                 {
                     Msg("Ingresé Nombre del Afp");
                     txtgerencia.Focus();
                     return;
                 }*/
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtruc.Text.ToString() == valor.Cells["idedu"].Value.ToString())
                    {
                        Msg("El Ruc ya Existe");
                        txtruc.Focus();
                        return;
                    }
                }
                //Insertando;
                CCargos.InsertarActualizarListarInstitucionEducativa((txtruc.Text), 1, txtnombre.Text, txtdirecion.Text, frmLogin.CodigoUsuario);
                Msg("Insertado Con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 2)
            {
                //Modificar
                /*  if (string.IsNullOrWhiteSpace(txtgerencia.Text))
                  {
                      Msg("Ingresé Nombre del Afp");
                      txtgerencia.Focus();
                      return;
                  }*/
                int fila = 0;
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtruc.Text.ToString() == valor.Cells["idedu"].Value.ToString() && fila != dtgconten.CurrentCell.RowIndex)
                    {
                        Msg("El Ruc ya Existe");
                        txtruc.Focus();
                        return;
                    }
                    fila++;
                }
                //modificando
                CCargos.InsertarActualizarListarInstitucionEducativa((dtgconten["idedu", dtgconten.CurrentCell.RowIndex].Value.ToString()), 2, txtnombre.Text, txtdirecion.Text, frmLogin.CodigoUsuario);
                Msg("Actualizado Con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 0)
            {

            }
        }

        private void frmInstitucionesEducativas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                btnmodificar.Enabled = true;
                txtruc.Text = dtgconten["idedu", e.RowIndex].Value.ToString();
                txtnombre.Text = dtgconten["razon", e.RowIndex].Value.ToString();
                txtdirecion.Text = dtgconten["direccion", e.RowIndex].Value.ToString();

                btneliminar.Enabled = true;
                btnexportarExcel.Enabled = true;
            }
            else
            {
                btnexportarExcel.Enabled = false;
                btnmodificar.Enabled = false;
                btneliminar.Enabled = false;
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Sololetras(e);
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarPegarSoloLetrasyEspacio(e, txtnombre, txtnombre.MaxLength);
        }

        private void txtruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtruc_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtruc, 11);
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            dtgconten.DataSource = CCargos.InsertarActualizarListarInstitucionEducativa("0", 10, txtbuscar.Text, "0", 0);
        }
    }
}
