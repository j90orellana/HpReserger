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
    public partial class frmAfpEmpresas : FormGradient
    {
        public frmAfpEmpresas()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        string tabla = "TBL_afp";
        string campo = "afp";
        string id = "id_AFP";
        private void frmAfpEmpresas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CapaLogica.getCargoTipoContratacion(id, campo, tabla);
            dtgconten.Focus();
            lbltotalRegistros.Text = $"Total Registros: {dtgconten.RowCount}";
        }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                btnmodificar.Enabled = true;
                txtcodigo.Text = (string)dtgconten[0, e.RowIndex].Value.ToString();
                txtgerencia.Text = (string)dtgconten[1, e.RowIndex].Value.ToString();
            }
            else
            {
                btnmodificar.Enabled = false;
            }
        }
        int estado = 0;
        public void iniciar(Boolean a)
        {
            btnnuevo.Enabled = !a;
            btnmodificar.Enabled = !a;
            btnaceptar.Enabled = a;
            dtgconten.Enabled = !a;
            txtgerencia.Enabled = a;
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
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = 1;
            iniciar(true);
            txtgerencia.Text = "";
            DataRow codigo = CapaLogica.VerUltimoIdentificador(tabla, id);
            txtcodigo.Text = (int.Parse(codigo["ultimo"].ToString()) + 1).ToString();
            txtgerencia.Focus();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2; btnmodificar.Enabled = false;
            iniciar(true); txtgerencia.Focus();
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                //nuevo
                if (string.IsNullOrWhiteSpace(txtgerencia.Text))
                {
                    HPResergerFunciones.frmInformativo.MostrarDialogError("Ingresé Nombre de la AFP");
                    txtgerencia.Focus();
                    return;
                }
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtgerencia.Text.ToString() == valor.Cells["descripcion"].Value.ToString())
                    {
                        HPResergerFunciones.frmInformativo.MostrarDialogError("La AFP ya Existe");
                        txtgerencia.Focus();
                        return;
                    }
                }
                //Insertando;
                CapaLogica.InsertarActualizarAFP(0, 1, txtgerencia.Text);
                HPResergerFunciones.frmInformativo.MostrarDialog("Insertado Con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 2)
            {
                //Modificar
                if (string.IsNullOrWhiteSpace(txtgerencia.Text))
                {
                    HPResergerFunciones.frmInformativo.MostrarDialogError("Ingresé Nombre de la AFP");
                    txtgerencia.Focus();
                    return;
                }
                int fila = 0;
                foreach (DataGridViewRow valor in dtgconten.Rows)
                {
                    if (txtgerencia.Text.ToString() == valor.Cells["descripcion"].Value.ToString() && fila != dtgconten.CurrentCell.RowIndex)
                    {
                        HPResergerFunciones.frmInformativo.MostrarDialogError("La AFP ya Existe");
                        txtgerencia.Focus();
                        return;
                    }
                    fila++;
                }
                //modificando
                CapaLogica.InsertarActualizarAFP(int.Parse(txtcodigo.Text), 2, txtgerencia.Text);
                HPResergerFunciones.frmInformativo.MostrarDialog("Actualizado Con Exito");
                btncancelar_Click(sender, e);
            }
            if (estado == 0)
            {

            }
        }
    }
}
