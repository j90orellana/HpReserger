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

namespace HPReserger.ModuloReportes
{
    public partial class frmReporteCentrodeCosto : FormGradient
    {
        public frmReporteCentrodeCosto()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        private void frmReporteCentrodeCosto_Load(object sender, EventArgs e)
        {
            Configuraciones.CargarTextoPorDefecto(txtbuscuenta);
            dtpfechaini.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpfechafin.Value = new DateTime(DateTime.Now.Year, 12, 31);
            CargarEmpresas();
        }
        DataTable TablaEmpresa;
        public void CargarEmpresas()
        {
            chklist.Items.Clear();
            TablaEmpresa = CapaLogica.Empresa();
            chklist.Items.Add("TODAS", true);
            foreach (DataRow item in TablaEmpresa.Rows)
            {
                chklist.Items.Add(item["descripcion"].ToString(), true);
            }
        }
        DateTime FechaIni;
        DateTime FechaFin;
        private void chklist_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
            {
                if (chklist.GetItemChecked(0))
                {
                    for (int i = 1; i < chklist.Items.Count; i++)
                        chklist.SetItemChecked(i, false);
                }
                else
                {
                    for (int i = 1; i < chklist.Items.Count; i++)
                        chklist.SetItemChecked(i, true);
                }
            }
            //else
            //{
            //    chklist.SetItemCheckState(0, CheckState.Indeterminate);
            //}
        }
         //frmlistarcentrosdecostos;
        int opcionCuentas = 0;
        private void btnbusCuenta_Click(object sender, EventArgs e)
        {
            //if (frmlistarcentrosdecostos == null)
            //{
            //    frmlistarcentrosdecostos = new frmlistarcuentas();
            //    frmlistarcentrosdecostos.FormClosed += Frmlistacuenta_FormClosed;
            //    frmlistarcentrosdecostos.tipobusca = opcionCuentas;
            //    frmlistarcentrosdecostos.Show();
            //}
            //else
            //{
            //    frmlistarcentrosdecostos.Activate();
            //}
        }
        private void Frmlistacuenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (frmlistarcentrosdecostos.aceptar)
            //{
            //    if (!txtbuscuenta.EstaLLeno()) txtbuscuenta.Text = "";
            //    if (txtbuscuenta.TextLength > 0 && txtbuscuenta.Text.Substring(txtbuscuenta.TextLength - 1, 1) != ";")
            //        txtbuscuenta.Text += ";";
            //    txtbuscuenta.Text += frmlistarcentrosdecostos.codigo;
            //    txtbuscuenta.SelectionStart = txtbuscuenta.TextLength;
            //    opcionCuentas = frmlistarcentrosdecostos.tipobusca;
            //}
            //frmlistarcentrosdecostos = null;
        }
    }
}
