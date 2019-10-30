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
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private int idempresa;
        private int pkid;
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReembolsoGastosDetalleFact_Load(object sender, EventArgs e)
        {
            BtnCerrar.Focus();
            Dtgconten.DataSource = CapaLogica.ReembolsoGastos_Detalle(pkid, idempresa);
            lbltotalregistros.Text = $"Total de Registros: {Dtgconten.RowCount}";
        }
    }
}
