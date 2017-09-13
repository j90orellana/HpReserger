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
    public partial class frmEmpresas : Form
    {
        public frmEmpresas()
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
            btnborrar.Enabled = !a;
            txtbuscar.Enabled = !a;
            cbotipo.Enabled = a;
            txtnombre.Enabled = a;
            txtdireccion.Enabled = a;
            txtnroid.Enabled = a;
            cbodep.Enabled = a;
            cbodis.Enabled = a;
            cbopro.Enabled = a;
            cbosector.Enabled = a;
            cbotipo.Enabled = a;
            cboseguro.Enabled = a;
            cbonombre.Enabled = a;
        }
        public void CargarCombos(ComboBox combito)
        {
            DataTable tablita = new DataTable();
            tablita.Columns.Add("CODIGO");
            tablita.Columns.Add("VALOR");
            tablita.Rows.Add(new object[] { "1", "Activo" });
            tablita.Rows.Add(new object[] { "0", "Inactivo" });
            combito.DataSource = tablita;
            combito.DisplayMember = "VALOR";
            combito.ValueMember = "CODIGO";
        }
        private void Msg(string cadena)
        {
            MessageBox.Show(cadena, "HpReseger", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CCargos.InsertarActualizarListarEmpresas("1", 0, "", "", 0, "", 0, 0, 0, 0, "", 0, 0);
            dtgconten.Focus();
        }
        private void frmEmpresas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void CargarSectores(ComboBox combito)
        {
            combito.DisplayMember = "descripcion";
            combito.ValueMember = "codigo";
            combito.DataSource = CCargos.getCargoTipoContratacion("Codigo_Sector_Empresarial", "Desc_Sector_Empresarial", "TBL_Sector_Empresarial");
        }
        public void CargarSeguros(ComboBox combito)
        {
            combito.DisplayMember = "descripcion";
            combito.ValueMember = "codigo";
            combito.DataSource = CCargos.getCargoTipoContratacion("ID_Eps", "Empresa_Eps", "TBL_Empresa_Eps");
        }
        public void CargarTipoid(ComboBox combito)
        {
            combito.DisplayMember = "descripcion";
            combito.ValueMember = "codigo";
            combito.DataSource = CCargos.getCargoTipoContratacion("Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");
        }
        public void CargarDepartamento(ComboBox combito)
        {
            combito.DisplayMember = "descripcion";
            combito.ValueMember = "codigo";
            combito.DataSource = CCargos.getCargoTipoContratacion("Cod_Dept", "Departamento", "TBL_Departamento");
        }
        public void CargarProvincia(ComboBox combito, int valor)
        {
            combito.DisplayMember = "PROVINCIA";
            combito.ValueMember = "CODIGOPROVINCIA";
            combito.DataSource = CCargos.ListarProvincia(valor);
        }
        public void CargarDistrito(ComboBox combito, int valor, int valor2)
        {
            combito.DisplayMember = "DISTRITO";
            combito.ValueMember = "CODIGODISTRITO";
            combito.DataSource = CCargos.ListarDistrito(valor, valor2);
        }
        public void CargarEmpleado(ComboBox combito)
        {
            combito.DisplayMember = "empleado";
            combito.ValueMember = "tipo";
            combito.DataSource = CCargos.BuscarEmpleadoActivo();
        }

        private void cbodep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbodep.SelectedIndex >= 0)
                CargarProvincia(cbopro, (int)cbodep.SelectedValue);
        }

        private void cbopro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbopro.SelectedIndex >= 0)
                CargarDistrito(cbodis, (int)cbodep.SelectedValue, (int)cbopro.SelectedValue);
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                CargarSectores(cbosector);
                CargarSeguros(cboseguro);
                CargarTipoid(cbotipo);
                CargarDepartamento(cbodep);
                CargarEmpleado(cbonombre);

                btnmodificar.Enabled = true;
                txtruc.Text = dtgconten["ruc", e.RowIndex].Value.ToString();
                txtnombre.Text = dtgconten["empresa", e.RowIndex].Value.ToString();
                txtdireccion.Text = dtgconten["direccion", e.RowIndex].Value.ToString();
                cbotipo.Text = dtgconten["tipoid", e.RowIndex].Value.ToString();
                txtnroid.Text = dtgconten["nroid", e.RowIndex].Value.ToString();
                cbonombre.Text = dtgconten["representante", e.RowIndex].Value.ToString();
                cbodep.Text = dtgconten["dep", e.RowIndex].Value.ToString();
                cbopro.Text = dtgconten["pro", e.RowIndex].Value.ToString();
                cbodis.Text = dtgconten["dis", e.RowIndex].Value.ToString();
                cbosector.Text = dtgconten["sector", e.RowIndex].Value.ToString();
                cboseguro.SelectedValue = dtgconten["cia", e.RowIndex].Value.ToString();
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

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            CargarSectores(cbosector);
            CargarSeguros(cboseguro);
            CargarTipoid(cbotipo);
            CargarDepartamento(cbodep);
            CargarEmpleado(cbonombre);
            estado = 1;
            iniciar(true);
            txtnombre.Text = txtruc.Text = txtdireccion.Text = txtnroid.Text = "";
            //DataRow codigo = CCargos.VerUltimoIdentificador(tabla, id);
            //txtaporte.Text = (int.Parse(codigo["ultimo"].ToString()) + 1).ToString();
            txtnombre.Focus();
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

        private void btnexportarExcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                List<HPResergerFunciones.Utilitarios.NombreCelda> Celditas = new List<HPResergerFunciones.Utilitarios.NombreCelda>();
                HPResergerFunciones.Utilitarios.NombreCelda Celdita = new HPResergerFunciones.Utilitarios.NombreCelda();
                Celdita.fila = 1; Celdita.columna = 1; Celdita.Nombre = "Listado de Empresas";
                Celditas.Add(Celdita);
                //HPResergerFunciones.Utilitarios.ExportarAExcel(dtgconten, "", "Empresas", Celditas, 1, new int[] { 1, 4, 6, 7, 8, 9, 11, 12, 13, 20 }, new int[] { 1 }, new int[] { });
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(dtgconten, "", "Empresas", Celditas, 1, new int[] { 2, 3, 5, 19, 10, 18, 14, 15, 16, 17, 21 }, new int[] { 1 }, new int[] { });
                Msg("Exportado con Exito");
            }
            else
                Msg("No hay Filas para Exportar");

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2; btnmodificar.Enabled = false;
            iniciar(true); txtnombre.Focus();
        }

        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotipo.SelectedIndex >= 0)
            {
                cbonombre.SelectedValue = cbotipo.SelectedValue.ToString() + "/" + txtnroid.Text;
            }
        }

        private void txtnroid_TextChanged(object sender, EventArgs e)
        {
            cbotipo_SelectedIndexChanged(sender, e);
        }

        private void cbonombre_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbonombre.SelectedIndex >= 0)
            {
                string valor = cbonombre.SelectedValue.ToString();
                cbotipo.SelectedValue = valor.Substring(0, 1);
                txtnroid.Text = valor.Substring(2, valor.Length - 2);
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtruc.Text))
            {
                Msg("Ingresé Ruc");
                txtruc.Focus();
                return;
            }
            if (txtruc.Text.Length != 11)
            {
                Msg("El Ruc Debe Tener 11 Digitos");
                txtruc.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                Msg("Ingresé Nombre");
                txtnombre.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtdireccion.Text))
            {
                Msg("Ingresé Dirección");
                txtdireccion.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtnroid.Text))
            {
                Msg("Ingresé Id Del Representante");
                txtnroid.Focus();
                return;
            }
            if (cbonombre.SelectedIndex < 0)
            {
                Msg("Ingresé Id Del Representante");
                txtnroid.Focus();
                return;
            }
            if (cboseguro.SelectedIndex < 0)
            {
                Msg("Seleccione Compañia de Seguro");
                cboseguro.Focus();
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
                    if (txtruc.Text.ToString() == valor.Cells["ruc"].Value.ToString())
                    {
                        Msg("La Empresa ya Existe");
                        txtruc.Focus();
                        return;
                    }
                }
                //Insertando;
                CCargos.InsertarActualizarListarEmpresas(txtruc.Text, 1, txtnombre.Text, txtruc.Text, (int)cbosector.SelectedValue, txtdireccion.Text, (int)cbodep.SelectedValue, (int)cbopro.SelectedValue, (int)cbodis.SelectedValue, (int)cbotipo.SelectedValue, txtnroid.Text, (int)cboseguro.SelectedValue, frmLogin.CodigoUsuario);
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
                    if (txtruc.Text.ToString() == valor.Cells["ruc"].Value.ToString() && fila != dtgconten.CurrentCell.RowIndex)
                    {
                        Msg("La Empresa ya Existe");
                        txtruc.Focus();
                        return;
                    }
                    fila++;
                }
                //modificando
                CCargos.InsertarActualizarListarEmpresas(dtgconten["ruc", dtgconten.CurrentCell.RowIndex].Value.ToString(), 2, txtnombre.Text, txtruc.Text, (int)cbosector.SelectedValue, txtdireccion.Text, (int)cbodep.SelectedValue, (int)cbopro.SelectedValue, (int)cbodis.SelectedValue, (int)cbotipo.SelectedValue, txtnroid.Text, (int)cboseguro.SelectedValue, frmLogin.CodigoUsuario);
                Msg("Actualizado Con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 0)
            {

            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            dtgconten.DataSource = CCargos.InsertarActualizarListarEmpresas("1", 10, txtbuscar.Text, "", 0, "", 0, 0, 0, 0, "", 0, 0);
        }

        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Sololetras(e);
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarPegarSoloLetrasyEspacio(e, txtnombre, 100);
        }

        private void txtnroid_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void txtnroid_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtnroid, 11);
        }

        private void txtruc_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtruc, 11);
        }
    }
}
