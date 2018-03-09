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
    public partial class frmPLanesEPS : Form
    {
        public frmPLanesEPS()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public int CodigoEmpresa;
        int estado;
        private void frmPLanesEPS_Load(object sender, EventArgs e)
        {
            estado = 0;
            CargarDatos();
        }
        DataTable DATOSEPS;
        public void CargarDatos()
        {
            DATOSEPS = new DataTable();
            DATOSEPS = CapaLogica.InsertarActualizarEmpresaEpsPLanes(CodigoEmpresa, 0, 0, 0, txtplan.Text, frmLogin.CodigoUsuario, 0);
            dtgconten.DataSource = DATOSEPS;
            dtgconten.Focus();
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                fila = (int)dtgconten[id_eps_planes.Name, e.RowIndex].Value;
                if (estado != 2 && estado != 1)
                {
                    btnmodificar.Enabled = true;
                    //txtplan.Text = dtgconten[Plansx.Name, e.RowIndex].Value.ToString();
                }
                if (estado != 1)
                    txtplan.Text = dtgconten[Plansx.Name, e.RowIndex].Value.ToString();
                // NumAporte.Value = (decimal)dtgconten[Monto.Name, e.RowIndex].Value;
                // Numadicional1.Value = (decimal)dtgconten[Beneficiario1.Name, e.RowIndex].Value;
                // Numadicional2.Value = (decimal)dtgconten[Beneficiario2.Name, e.RowIndex].Value;
                // Numadicional3.Value = (decimal)dtgconten[Beneficiario3.Name, e.RowIndex].Value;
            }
            else
            {
                btnmodificar.Enabled = false;
            }
        }
        public void iniciar(Boolean a)
        {
            btnnuevo.Enabled = !a;
            btnmodificar.Enabled = !a;
            btnaceptar.Enabled = a;
            // dtgconten.Enabled = !a;
            txtplan.Enabled = a;
            //NumAporte.Enabled = a;
            //Numadicional1.Enabled = a;
            //Numadicional2.Enabled = a;
            //Numadicional3.Enabled = a;

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
                dtgconten.Columns[Monto.Name].ReadOnly = true;
            }
            IEpsAdicional IformAdicional = Owner as IEpsAdicional;
            if (IformAdicional != null)
            {
                IformAdicional.CargarPLanes();
            }
            CargarDatos();
        }
        private void Msg(string cadena)
        {
            MessageBox.Show(cadena, "HpReseger", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                //nuevo
                if (string.IsNullOrWhiteSpace(txtplan.Text))
                {
                    Msg("Ingresé Nombre del Plan");
                    txtplan.Focus();
                    return;
                }
                string Busqueda = "";
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (Busqueda != valor.Cells[Plansx.Name].Value.ToString())
                        if (txtplan.Text.ToString().ToUpper() == valor.Cells[Plansx.Name].Value.ToString().ToUpper())
                        {
                            Msg("El Plan ya Existe");
                            txtplan.Focus();
                            return;
                        }
                    Busqueda = valor.Cells[Plansx.Name].Value.ToString();
                }
                //Insertando;
                CapaLogica.PLanes(1, 0, CodigoEmpresa, txtplan.Text);
                // CapaLogica.InsertarActualizarEmpresaEpsPLanes(CodigoEmpresa, 0, 1, txtplan.Text, frmLogin.CodigoUsuario, NumAporte.Value, Numadicional1.Value, Numadicional2.Value, Numadicional3.Value);
                Msg("Insertado Con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 2)
            {
                //Modificar
                if (string.IsNullOrWhiteSpace(txtplan.Text))
                {
                    Msg("Ingresé Nombre del Plan");
                    txtplan.Focus();
                    return;
                }
                // int fila = 0;
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    //    //int filo = (int)valor.Cells[id_eps_planes.Name].Value;
                    //    //if (txtplan.Text.ToString().ToUpper() == valor.Cells[Plansx.Name].Value.ToString().ToUpper() &&)
                    //    //{
                    //    //    Msg("El Plan ya Existe");
                    //    //    txtplan.Focus();
                    //    //    return;
                    //    //}
                    //    //fila++;
                    CapaLogica.PLanes(2, (int)valor.Cells[id_eps_planes.Name].Value, CodigoEmpresa, valor.Cells[Plansx.Name].Value.ToString());
                    CapaLogica.InsertarActualizarEmpresaEpsPLanes(CodigoEmpresa, (int)valor.Cells[id_eps_planes.Name].Value, 1, (int)valor.Cells[ideps.Name].Value, valor.Cells[Plansx.Name].Value.ToString(), frmLogin.CodigoUsuario, (decimal)valor.Cells[Monto.Name].Value);
                }

                //modificando
                int filax = dtgconten.CurrentCell.RowIndex;
                //CapaLogica.InsertarActualizarEmpresaEpsPLanes(CodigoEmpresa, (int)dtgconten[id_eps_planes.Name, filax].Value, 2, txtplan.Text, frmLogin.CodigoUsuario, NumAporte.Value, Numadicional1.Value, Numadicional2.Value, Numadicional3.Value);
                Msg("Actualizado Con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 0)
            {

            }
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            iniciar(true);
            txtplan.Text = "";
            txtplan.Focus(); btnmodificar.Enabled = false;
            dtgconten.Columns[Monto.Name].ReadOnly = true;
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2; btnmodificar.Enabled = false;
            iniciar(true); txtplan.Focus();
            dtgconten.Columns[Monto.Name].ReadOnly = false;
        }
        TextBox txt;
        private void dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dtgconten.CurrentCell.RowIndex > 0)
            {
                if (dtgconten.CurrentCell.ColumnIndex == dtgconten.Columns[Monto.Name].Index)
                {
                    txt = e.Control as TextBox;
                    if (txt != null)
                    {
                        txt.KeyPress -= new KeyPressEventHandler(dataGridview_KeyPressCajita);
                        txt.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajita);
                    }
                }
            }
        }
        private void dataGridview_KeyPressCajita(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimales(e, txt.Text);
        }
        int fila = 0;
        private void txtplan_TextChanged(object sender, EventArgs e)
        {
            if (estado == 2)
            {
                foreach (DataGridViewRow item in dtgconten.Rows)
                {
                    if ((int)item.Cells[id_eps_planes.Name].Value == fila)
                        item.Cells[Plansx.Name].Value = txtplan.Text;
                }
            }
        }
    }
}
