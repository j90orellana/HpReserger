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

namespace HPReserger.ModuloContable
{
    public partial class frmRevesarAsientos : FormGradient
    {
        public frmRevesarAsientos()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public string Glosa { get { return txtGlosa.Text; } set { txtGlosa.Text = value.Trim(); } }

        public DateTime FechaValor { get; internal set; }
        public DateTime FechaEmisionDes { get { return dtpFechaEmisionReversa.Value; } set { dtpFechaEmisionReversa.Value = value; } }
        public DateTime FechaContableDes { get { return dtpFechaContableReversa.Value; } set { dtpFechaContableReversa.Value = value; } }
        public string Cuo { get; internal set; }
        public int Codigo { get; internal set; }
        public int IdProyecto { get; internal set; }
        public int IdEmpresa { get; internal set; }

        private void frmRevesarAsientos_Load(object sender, EventArgs e)
        {

        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void msg(string cadena) { HPResergerFunciones.Utilitarios.msg(cadena); }
        public DialogResult msgYesNo(string cadena) { return HPResergerFunciones.Utilitarios.msgYesNo(cadena); }
        private void btnTxt_Click(object sender, EventArgs e)
        {
            if (rbReversar.Checked)
            {
                //Verifico si el Periodo esta Abierto para Proceder con la Anulacion - REversa
                if (!CapaLogica.VerificarPeriodoAbierto(IdEmpresa, FechaValor))
                {
                    if (msgYesNo("El Periodo Esta Cerrado, Cambie Fecha Contable, Desea Continuar") != DialogResult.Yes)
                    {
                        DialogResult = DialogResult.Cancel;
                        this.Close();
                    }
                    else return;
                }
                //Proceso de la Reversa
                if (HPResergerFunciones.Utilitarios.msgYesNo($"Seguro Desea Reversar Este Asiento Nro {Cuo}") == DialogResult.Yes)
                {
                    //Proceso Reversa del Asiento               
                    DataRow Filita = CapaLogica.ReversarAsientos(Codigo, IdProyecto, frmLogin.CodigoUsuario, FechaValor).Rows[0];
                    if (Filita[0].ToString() == "")
                    {
                        HPResergerFunciones.Utilitarios.msg($"Asiento {Cuo} Reversado!");
                    }
                    else
                    {
                        HPResergerFunciones.Utilitarios.msg("Mensaje de Error: \n" + Filita[0].ToString());
                        return;
                    }
                }
            }
            //Reversar en Otro Periodo
            else
            {
                if (FechaValor.Month == FechaContableDes.Month && FechaValor.Year == FechaContableDes.Year)
                {
                    msg("Cambie de Periodo");
                    return;
                }
                //Verificio si el Periodo esta Abierto para Proceder con la Anulacion - REversa
                if (!CapaLogica.VerificarPeriodoAbierto(IdEmpresa, FechaValor))
                {
                    if (msgYesNo("El Periodo Esta Cerrado, Cambie Fecha Contable, Desea Continuar") != DialogResult.Yes)
                    {
                        DialogResult = DialogResult.Cancel;
                        this.Close();
                    }
                    else return;
                }
                //Verificio si el Periodo Destino Esta Abierto
                if (!CapaLogica.VerificarPeriodoAbierto(IdEmpresa, FechaContableDes))
                {
                    if (msgYesNo("El Periodo Esta Cerrado, Cambie Fecha Contable, Desea Continuar") != DialogResult.Yes)
                    {
                        DialogResult = DialogResult.Cancel;
                        this.Close();
                    }
                    else
                    {
                        dtpFechaContableReversa.Focus();
                        return;
                    }
                }
                //Proceso de Verificar sin tienes documentos Pagados o Abonos!
                DataRow Filita = CapaLogica.AnularAsientos(Codigo, IdProyecto, frmLogin.CodigoUsuario, FechaValor, FechaEmisionDes, FechaContableDes, txtGlosa.Text).Rows[0];
                if (Filita[0].ToString() == "")
                {
                    HPResergerFunciones.Utilitarios.msg($"Asiento {Cuo} Reversado!");
                }
                else
                {
                    HPResergerFunciones.Utilitarios.msg("Mensaje de Error: \n" + Filita[0].ToString());
                    return;
                }
            }
            //Resultado Afirmatido para Resultado.
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void rbReversarPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReversarPeriodo.Checked)
            {
                PanelOtraReversa.Enabled = true;
            }
            else
                PanelOtraReversa.Enabled = false;
        }
    }
}
