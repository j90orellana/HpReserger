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
    public partial class frmTipodeCambioSBS : FormGradient
    {
        public frmTipodeCambioSBS()
        {
            InitializeComponent();
            CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica;
        byte[] ImgVenta;
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public bool BusquedaExterna { get; internal set; }
        private void TipodeCambio_Load(object sender, EventArgs e)
        {
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            ImgVenta = new byte[0];
            ImageConverter _imageConverter = new ImageConverter();
            ImgVenta = (byte[])_imageConverter.ConvertTo(pbigual.Image, typeof(byte[]));
            SacarDAtos();
        }
        public void SacarDAtos()
        {
            tablita = CapaLogica.TipodeCambio(100, comboMesAño.GetFecha().Year, comboMesAño.GetFecha().Month, 1, 0, 0, ImgVenta);
            dtgconten.DataSource = tablita;
            CargarImagenes();
            lblmsg.Text = $"Total de Registros: {dtgconten.RowCount}";
        }
        public Boolean Carga = false;
        DataTable tablita = new DataTable();
        public void ColumnasTAblas()
        {
            tablita.Columns.Add("Dia", typeof(int));
            tablita.Columns.Add("Compra", typeof(decimal));
            tablita.Columns.Add("Venta", typeof(decimal));
            tablita.Columns.Add("Mes", typeof(int));
            tablita.Columns.Add("Año", typeof(int));
            tablita.Columns.Add("CompraImg", typeof(byte[]));
            tablita.Columns.Add("VentaImg", typeof(byte[]));
        }
        string[] Tcambio = new string[3];
        public event EventHandler ActualizoTipoCambio;
        protected virtual void OnActualizoTipoCambio(EventArgs e)
        {
            ActualizoTipoCambio?.Invoke(this, e);
        }
        private void Btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Buscar_Click(object sender, EventArgs e)
        {
            SacarDAtos();
        }
        private void dtgconten_MouseDown(object sender, MouseEventArgs e)
        {
            dtgconten.EndEdit();
            if (e.Button == MouseButtons.Left)
            {
                if (dtgconten.CurrentCell.Value != null)
                    DoDragDrop(dtgconten.CurrentCell.Value.ToString(), DragDropEffects.Copy);
            }
        }
        public void CargarImagenes()
        {
            int i = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if (i != 0)
                {
                    //compras
                    if ((decimal)item.Cells[Compra.Name].Value > (decimal)dtgconten[Compra.Name, i - 1].Value)
                        dtgconten[cp.Name, i].Value = pbup.Image;
                    if ((decimal)item.Cells[Compra.Name].Value < (decimal)dtgconten[Compra.Name, i - 1].Value)
                        dtgconten[cp.Name, i].Value = pbdown.Image;
                    if ((decimal)item.Cells[Compra.Name].Value == (decimal)dtgconten[Compra.Name, i - 1].Value)
                        dtgconten[cp.Name, i].Value = pbigual.Image;
                    //ventas
                    if ((decimal)item.Cells[Venta.Name].Value > (decimal)dtgconten[Venta.Name, i - 1].Value)
                        dtgconten[vv.Name, i].Value = pbup.Image;
                    if ((decimal)item.Cells[Venta.Name].Value < (decimal)dtgconten[Venta.Name, i - 1].Value)
                        dtgconten[vv.Name, i].Value = pbdown.Image;
                    if ((decimal)item.Cells[Venta.Name].Value == (decimal)dtgconten[Venta.Name, i - 1].Value)
                        dtgconten[vv.Name, i].Value = pbigual.Image;
                }
                i++;
            }
        }
        frmProcesando frmpro;
        DateTime Fechas;
        //TimeSpan Stop;
        //TimeSpan Inicio;
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                ///* Inicio = new TimeSpan(DateTim*/e.Now.Ticks);
                dtgconten.SuspendLayout();
                frmpro = new frmProcesando();
                frmpro.Show(); Cursor = Cursors.WaitCursor;
                Fechas = comboMesAño.GetFecha();
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                msg("No hay Datos que Mostrar");
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                string _NombreHoja = ""; string _Cabecera = ""; int[] _Columnas; string _NColumna = "";
                _NombreHoja = "Tipo de Cambio"; _Cabecera = "Tipo de Cambio"; _Columnas = new int[] { 1, 4, 2, 3 }; _NColumna = "d";
                string Detalle = $"Correspondiente a {Fechas.Year}";
                List<HPResergerFunciones.Utilitarios.RangoCelda> RangosCeldas = new List<HPResergerFunciones.Utilitarios.RangoCelda>();
                Color Back = Color.FromArgb(78, 129, 189);
                Color Fore = Color.FromArgb(255, 255, 255);
                RangosCeldas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a1", $"{_NColumna}1", _Cabecera.ToUpper(), 16, true, true, Back, Fore));
                RangosCeldas.Add(new HPResergerFunciones.Utilitarios.RangoCelda("a2", $"{_NColumna}2", Detalle, 12, false, true, Back, Fore));
                //
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaDefault = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.AlternatingRowsDefaultCellStyle.BackColor, dtgconten.AlternatingRowsDefaultCellStyle.Font, dtgconten.AlternatingRowsDefaultCellStyle.ForeColor);
                HPResergerFunciones.Utilitarios.EstiloCelda CeldaCabecera = new HPResergerFunciones.Utilitarios.EstiloCelda(dtgconten.ColumnHeadersDefaultCellStyle.BackColor, dtgconten.ColumnHeadersDefaultCellStyle.Font, dtgconten.ColumnHeadersDefaultCellStyle.ForeColor);
                int PosInicialGrilla = 3;
                DataTable TableResuk = new DataTable();
                TableResuk = ((DataTable)dtgconten.DataSource).Copy();
                TableResuk.Columns.RemoveAt(6);
                TableResuk.Columns.RemoveAt(5);
                TableResuk.Columns.RemoveAt(4);
                TableResuk.Columns[3].SetOrdinal(1);
                TableResuk.Columns["mes"].ColumnName = "Periodo";
                HPResergerFunciones.Utilitarios.ExportarAExcelOrdenandoColumnas(TableResuk, CeldaCabecera, CeldaDefault, "", _NombreHoja, RangosCeldas, PosInicialGrilla, _Columnas, new int[] { }, new int[] { 1, 4, 2, 3 }, "");
            }
            else msg("No hay Registros en la Grilla");
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            frmpro.Close();
            //Stop = new TimeSpan(DateTime.Now.Ticks);
            // msg($"tiempos: {Stop.Subtract(Inicio).TotalMilliseconds}");
            dtgconten.ResumeLayout();
        }
        frmaddtipoCambio frmaddtipo;
        private void btnaddtipo_Click(object sender, EventArgs e)
        {
            if (frmaddtipo == null)
            {
                frmaddtipo = new frmaddtipoCambio();
                frmaddtipo.MdiParent = this.MdiParent;
                frmaddtipo.fechatipo = comboMesAño.GetFecha();
                frmaddtipo.FormClosed += Frmaddtipo_FormClosed;
                frmaddtipo.TipoCambioSBS = true;
                frmaddtipo.Show();
            }
            else { frmaddtipo.Activate(); }
        }
        private void Frmaddtipo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Buscar_Click(sender, e);
            frmaddtipo = null;
        }
    }
}
