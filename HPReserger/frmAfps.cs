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
    public partial class frmAfps : Form
    {
        public frmAfps()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CCargos = new HPResergerCapaLogica.HPResergerCL();
        int estado = 0;
        //string tabla = "TBL_Cargo";
        //string campo = "Cargo";
        //string id = "Id_Cargo";
        public void iniciar(Boolean a)
        {
            btnnuevo.Enabled = !a;
            btnmodificar.Enabled = !a;
            btnaceptar.Enabled = a;
            dtgconten.Enabled = !a;
            btneliminar.Enabled = !a;
            txtgerencia.Enabled = a;
            txtaporte.Enabled = a;
            txtseguro.Enabled = a;
            txtcomision.Enabled = a;
        }
        private void Msg(string cadena)
        {
            MessageBox.Show(cadena, "HpReseger", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CCargos.InsertarActualizarListarAfp(0, 0, "0", 0, 0, 0, 0);
            dtgconten.Focus();
        }
        private void frmAfps_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            iniciar(true);
            txtgerencia.Text = txtaporte.Text = txtseguro.Text = txtcomision.Text = "";
            //DataRow codigo = CCargos.VerUltimoIdentificador(tabla, id);
            //txtaporte.Text = (int.Parse(codigo["ultimo"].ToString()) + 1).ToString();
            txtgerencia.Focus();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2; btnmodificar.Enabled = false;
            iniciar(true); txtgerencia.Focus();
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
            if (string.IsNullOrWhiteSpace(txtaporte.Text))
            {
                Msg("Ingresé Aporte");
                txtaporte.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtcomision.Text))
            {
                Msg("Ingresé Comisión");
                txtcomision.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtseguro.Text))
            {
                Msg("Ingresé Seguro");
                txtseguro.Focus();
                return;
            }
            decimal aportex = decimal.Parse(txtaporte.Text) / 100;
            decimal segurox = decimal.Parse(txtseguro.Text) / 100;
            decimal comisionx = decimal.Parse(txtcomision.Text) / 100;
            if (estado == 1)
            {
                //nuevo
                if (string.IsNullOrWhiteSpace(txtgerencia.Text))
                {
                    Msg("Ingresé Nombre del Afp");
                    txtgerencia.Focus();
                    return;
                }
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtgerencia.Text.ToString() == valor.Cells["afp"].Value.ToString())
                    {
                        Msg("El Afp ya Existe");
                        txtgerencia.Focus();
                        return;
                    }
                }
                //Insertando;
                CCargos.InsertarActualizarListarAfp(0, 1, txtgerencia.Text, aportex, segurox, comisionx, frmLogin.CodigoUsuario);
                Msg("Insertado Con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 2)
            {
                //Modificar
                if (string.IsNullOrWhiteSpace(txtgerencia.Text))
                {
                    Msg("Ingresé Nombre del Afp");
                    txtgerencia.Focus();
                    return;
                }
                int fila = 0;
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtgerencia.Text.ToString() == valor.Cells["afp"].Value.ToString() && fila != dtgconten.CurrentCell.RowIndex)
                    {
                        Msg("El Afp ya Existe");
                        txtgerencia.Focus();
                        return;
                    }
                    fila++;
                }
                //modificando
                CCargos.InsertarActualizarListarAfp(int.Parse(dtgconten["idafp", dtgconten.CurrentCell.RowIndex].Value.ToString()), 2, txtgerencia.Text, aportex, segurox, comisionx, frmLogin.CodigoUsuario);
                Msg("Actualizado Con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 0)
            {

            }
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                btnmodificar.Enabled = true;
                txtaporte.Text = ((decimal)dtgconten["aporte", e.RowIndex].Value * 100).ToString("n2");
                txtseguro.Text = ((decimal)dtgconten["seguro", e.RowIndex].Value * 100).ToString("n2");
                txtcomision.Text = ((decimal)dtgconten["comision", e.RowIndex].Value * 100).ToString("n2");
                txtgerencia.Text = (string)dtgconten[1, e.RowIndex].Value.ToString();
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                List<HPResergerFunciones.Utilitarios.NombreCelda> Celditas = new List<HPResergerFunciones.Utilitarios.NombreCelda>();
                HPResergerFunciones.Utilitarios.NombreCelda Celdita = new HPResergerFunciones.Utilitarios.NombreCelda();
                Celdita.fila = 1;
                Celdita.columna = 1;
                Celdita.Nombre = "Listado de Afps";
                Celditas.Add(Celdita);
                HPResergerFunciones.Utilitarios.ExportarAExcel(dtgconten, "", "Afps", Celditas, 1, new int[] { 1 }, new int[] { 1 }, new int[] { });
                Msg("Exportado con Exito");
            }
            else
                Msg("No hay Filas para Exportar");
        }

        private void txtaporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimalesX(e, txtaporte.Text);
        }

        private void txtseguro_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimalesX(e, txtseguro.Text);
        }

        private void txtcomision_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimalesX(e, txtcomision.Text);
        }
    }
}
