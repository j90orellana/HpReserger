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
    public partial class frmEliminarPeriodo : Form
    {
        public frmEliminarPeriodo()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmEliminarPeriodo_Load(object sender, EventArgs e)
        {
            Cargarempresa();
        }
        public void Cargarempresa()
        {
            cboempresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_empresa", "empresa", "tbl_empresa");
            cboempresa.ValueMember = "codigo";
            cboempresa.DisplayMember = "descripcion";
        }

        private void btnrecempresa_Click(object sender, EventArgs e)
        {
            Cargarempresa();
        }
        private void cboempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboempresa.SelectedIndex >= 0)
                btngenerar.Enabled = true;
            else btngenerar.Enabled = false;
        }
        public DialogResult msg(string cadena)
        {
            return MessageBox.Show(cadena, "Hp Reserger", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        DataTable tablita;
        private void btngenerar_Click(object sender, EventArgs e)
        {
            // msg(comboMesAño1.GetFecha().ToLongDateString());
            tablita = new DataTable();
            tablita = CapaLogica.ListarJefeInmediato(frmLogin.CodigoUsuario, "", 10);
            if (tablita.Rows.Count != 0)
            {
                DataRow filita = tablita.Rows[0];
                ///opcion 0listar 1 insertar 10 aceptar
                string cade = "";
                cade = cboempresa.SelectedValue.ToString() + ",'" + comboMesAño1.FechaParaSQL() + "'";
                CapaLogica.TablaSolicitudes(1, int.Parse(filita["codigo"].ToString()), "usp_EliminarBoletas", cade, 0, frmLogin.CodigoUsuario, "Solicita Eliminar Periodo " + comboMesAño1.GetFechaPRimerDia().ToShortDateString());
                msg("Solicitud Enviada a su Jefe");
            }
            else msg("No se Encuentra el Código del Jefe");
        }
    }
}
