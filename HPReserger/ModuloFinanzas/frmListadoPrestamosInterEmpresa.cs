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

namespace HPReserger.ModuloFinanzas
{
    public partial class frmListadoPrestamosInterEmpresa : FormGradient
    {
        public frmListadoPrestamosInterEmpresa()
        {
            InitializeComponent();
        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        public frmListadoPrestamosInterEmpresa(int empresa, int fkid)
        {
            _empresa = empresa;
            _fkid = fkid;
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public string Glosa
        {
            get { return txtglosa.Text; }
            set { txtglosa.Text = value; }
        }
        public string EmpresaOrigen
        {
            get { return txtempresaorigen.Text; }
            set { txtempresaorigen.Text = value; }
        }
        public string EmpresaDestino
        {
            get { return txtempresadestino.Text; }
            set { txtempresadestino.Text = value; }
        }
        public int _empresa { get; private set; }
        public int _fkid { get; private set; }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmListadoPrestamosInterEmpresa_Load(object sender, EventArgs e)
        {
            dtgconten.DataSource = CapaLogica.PrestamoInterEmpresa_Filtrar(_empresa, _fkid);
            lblmsg.Text = $"Total de Registros : {dtgconten.RowCount}";
        }
    }
}
