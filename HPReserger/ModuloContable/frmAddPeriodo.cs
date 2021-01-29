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
    public partial class frmAddPeriodo : FormGradient
    {
        public frmAddPeriodo()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void frmaddtipoCambio_Load(object sender, EventArgs e)
        {
            CargarEmpresa();
        }
        private void CargarEmpresa()
        {
            cboempresa.DisplayMember = "descripcion";
            cboempresa.ValueMember = "codigo";
            cboempresa.DataSource = CapaLogica.getCargoTipoContratacion("Id_Empresa", "Empresa", "TBL_Empresa");
        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msg(string cadena, string detalle) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena, detalle); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (cboempresa.SelectedValue == null) { msg("Selecciones una Empresa"); return; }
            if (comboMesAño1.GetFechaPRimerDia() == null) { msg("Selecicone una Fecha Valida"); return; }
            //Declaraciones
            int pkEmpresa = (int)cboempresa.SelectedValue;
            DateTime Fecha = comboMesAño1.GetFechaPRimerDia();
            //Proceso
            if (CapaLogica.ValidarCrearPeriodo(pkEmpresa, Fecha)) { msg("Este Periodo Ya Existe"); return; }
            //99 es la opcion para insertar un periodo continuo de 1 mes y lo crea cerrado
            if (CapaLogica.Periodos(99, pkEmpresa, Fecha).Rows.Count > 0)
            {
                msgOK("Periodo Creado Cerrado");
            }
            else msg("No se pudo Crear el Periodo","El periodo debe ser continuo");
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboempresa_Click(object sender, EventArgs e)
        {
            DataTable Tablita = CapaLogica.getCargoTipoContratacion("Id_Empresa", "Empresa", "TBL_Empresa");
            if (cboempresa.Items.Count != Tablita.Rows.Count)
            {
                string cadena = cboempresa.Text;
                cboempresa.DataSource = Tablita;
                cboempresa.Text = cadena;
            }
        }
    }
}
