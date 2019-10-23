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
    public partial class frmEliminarPeriodo : FormGradient
    {
        public frmEliminarPeriodo()
        {
            InitializeComponent();
        }
        public int Opcion = 0;
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmEliminarPeriodo_Load(object sender, EventArgs e)
        {
            Cargarempresa();
            //1 =cts 2=gratificacion
            if (Opcion == 1)
            {
                comboMesAño1.MostrarMeses(6, 11);
                this.Text = "Eliminar CTS";
            }
            if (Opcion == 2)
            {
                comboMesAño1.MostrarMeses(7, 12);
                this.Text = "Eliminar Gratificación";
            }
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
            return MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }       
        DataTable tablita;
        private void btngenerar_Click(object sender, EventArgs e)
        {
            // msg(comboMesAño1.GetFecha().ToLongDateString());
            tablita = new DataTable();
            tablita = CapaLogica.ListarJefeInmediato(frmLogin.CodigoUsuario, "", 10);
            if (msg("Desea Eliminar Periodo") == DialogResult.OK)
                if (tablita.Rows.Count != 0)
                {
                    DataRow filita = tablita.Rows[0];
                    ///opcion 0listar 1 insertar 10 aceptar
                    if (Opcion == 0)
                    {
                        string cade = "";
                        cade = cboempresa.SelectedValue.ToString() + ",'" + comboMesAño1.FechaParaSQL() + "'";
                        CapaLogica.TablaSolicitudes(1, int.Parse(filita["codigo"].ToString()), "usp_EliminarBoletas", cade, 0, frmLogin.CodigoUsuario, "Solicita Eliminar Boletas Periodo " + comboMesAño1.GetFechaPRimerDia().ToString("MMMM yyyy") + ", " + cboempresa.Text);
                    }
                    //cts
                    if (Opcion == 1)
                    {
                        string cade = "";
                        cade = cboempresa.SelectedValue.ToString() + ",'" + comboMesAño1.FechaParaSQL() + "'";
                        CapaLogica.TablaSolicitudes(1, int.Parse(filita["codigo"].ToString()), "usp_EliminarCts", cade, 0, frmLogin.CodigoUsuario, "Solicita Eliminar Cts Periodo " + comboMesAño1.GetFechaPRimerDia().ToString("MMMM yyyy") + ", " + cboempresa.Text);
                    }
                    //gratificacion
                    if (Opcion == 2)
                    {
                        string cade = "";
                        cade = cboempresa.SelectedValue.ToString() + ",'" + comboMesAño1.FechaParaSQL() + "'";
                        CapaLogica.TablaSolicitudes(1, int.Parse(filita["codigo"].ToString()), "usp_EliminarGratificacion", cade, 0, frmLogin.CodigoUsuario, "Solicita Eliminar Gratificación Periodo " + comboMesAño1.GetFechaPRimerDia().ToString("MMMM yyyy") + ", " + cboempresa.Text);
                    }
                    HPResergerFunciones.frmInformativo.MostrarDialog("Solicitud Enviada a su Jefe");
                }
                else HPResergerFunciones.frmInformativo.MostrarDialogError("No se Encuentra el Código del Jefe");
        }
    }
}
