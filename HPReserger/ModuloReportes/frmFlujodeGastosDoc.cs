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
    public partial class frmFlujodeGastosDoc : FormGradient
    {
        public frmFlujodeGastosDoc()
        {
            InitializeComponent();
        }
        DataTable TablaEmpresa;
        private DateTime FechaInicio;
        private DateTime FechaFin;
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private bool Cargado = false;
        private DataTable TDatos;

        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public void cargarEmpresa()
        {
            chklist.Items.Clear();
            TablaEmpresa = CapaLogica.Empresa();
            chklist.Items.Add("TODAS", true);
            foreach (DataRow item in TablaEmpresa.Rows)
            {
                chklist.Items.Add(item["descripcion"].ToString(), true);
            }
        }

        private void frmFlujodeGastosDoc_Load(object sender, EventArgs e)
        {
            cargarEmpresa();
            cboperiodode.CambioFechas += cboperiodode_CambioFechas;
            cboperiodohasta.CambioFechas += cboperiodohasta_CambioFechas;
            Cargado = true;
        }
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
        }
        private void cboperiodohasta_CambioFechas(object sender, EventArgs e)
        {
            if (cboperiodode.GetFecha().Year != cboperiodohasta.GetFecha().Year && Cargado)
            {
                DateTime FechaAux = cboperiodode.GetFecha();
                DateTime FechaAux1 = cboperiodohasta.GetFecha();
                cboperiodode.Fecha(new DateTime(FechaAux1.Year, FechaAux.Month, FechaAux.Day));
            }
        }
        private void cboperiodode_CambioFechas(object sender, EventArgs e)
        {
            if (cboperiodode.GetFecha().Year != cboperiodohasta.GetFecha().Year && Cargado)
            {
                DateTime FechaAux = cboperiodohasta.GetFecha();
                DateTime FechaAux1 = cboperiodode.GetFecha();
                cboperiodohasta.Fecha(new DateTime(FechaAux1.Year, FechaAux.Month, FechaAux.Day));
            }
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (chklist.CheckedItems.Count == 0) msg("Seleccione una Empresa");
            DateTime FechaAuxiliar;
            string ListadoEmpresas = "";
            if (cboperiodode.FechaInicioMes > cboperiodohasta.FechaInicioMes)
            {
                FechaAuxiliar = cboperiodode.FechaInicioMes;
                cboperiodode.Fecha(cboperiodohasta.FechaInicioMes);
                cboperiodohasta.Fecha(FechaAuxiliar);
            }
            FechaInicio = cboperiodode.GetFechaPRimerDia();
            FechaFin = cboperiodohasta.FechaFinMes;
            foreach (string item in chklist.CheckedItems)
            {
                if (item.ToString() != "TODAS")
                    ListadoEmpresas += CapaLogica.BuscarRucEmpresa(item)[1].ToString() + ",";
            }
            ListadoEmpresas = ListadoEmpresas.Substring(0, ListadoEmpresas.Length - 1);
            TDatos = new DataTable();// CapaLogica.FormatodeVentas14_1(ListadoEmpresas, FechaInicio, FechaFin);
            //dtgconten.DataSource = TDatos;
            ////lblmensaje.Text = $"Total de Registros: {dtgconten.RowCount}";
            if (TDatos.Rows.Count == 0) msg("No Hay Registros");
            //Ordenado = false;
            Cursor = Cursors.Default;
        }
    }
}
