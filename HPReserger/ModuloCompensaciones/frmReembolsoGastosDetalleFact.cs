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

namespace HPReserger.ModuloCompensaciones
{
    public partial class frmReembolsoGastosDetalleFact : FormGradient
    {
        public frmReembolsoGastosDetalleFact()
        {
            InitializeComponent();
        }
        public frmReembolsoGastosDetalleFact(int _idempresa, int _pkid)
        {
            InitializeComponent();
            idempresa = _idempresa;
            pkid = _pkid;
        }
        public frmReembolsoGastosDetalleFact(int _idempresa, int _pkid, Boolean Entregas)
        {
            InitializeComponent();
            idempresa = _idempresa;
            pkid = _pkid;
            lblcabecera.Text = this.Text = "Detalle de las Facturas Relacionadas a la Entrega a Rendir:";
            //quitamos las Columnas que no ocupamos
            Dtgconten.Columns[xTCReg.Name].Visible = false;
            Dtgconten.Columns[xTotal.Name].Visible = false;
            Dtgconten.Columns[xMontoME.Name].Visible = false;
            _Entregas = Entregas;
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private int idempresa;
        private int pkid;
        private bool _Entregas;
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReembolsoGastosDetalleFact_Load(object sender, EventArgs e)
        {
            this.CerrarAlPresionarESC = true;
            if (_Entregas)
                Dtgconten.DataSource = CapaLogica.EntregasRendir_Detalle(pkid, idempresa);
            else
                Dtgconten.DataSource = CapaLogica.ReembolsoGastos_Detalle(pkid, idempresa);
            lbltotalregistros.Text = $"Total de Registros: {Dtgconten.RowCount}";
            BtnCerrar.Focus();
        }
    }
}
