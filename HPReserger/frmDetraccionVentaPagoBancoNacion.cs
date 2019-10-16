using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmDetraccionVentaPagoBancoNacion : FormGradient
    {
        public frmDetraccionVentaPagoBancoNacion()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        DataTable TTipoid;
        DataTable TTipoDoc;
        DataTable TEmpresa;
        public void CargarDatosCombos()
        {
            /////tipo id
            TTipoid = new DataTable();
            TTipoid.Columns.Add("Codigo", typeof(int));
            TTipoid.Columns.Add("valor");
            TTipoid.Rows.Add(1, "DNI");
            TTipoid.Rows.Add(5, "RUC");
            ////tipo doc
            TTipoDoc = new DataTable();
            TTipoDoc.Columns.Add("Codigo", typeof(int));
            TTipoDoc.Columns.Add("valor");
            TTipoDoc.Rows.Add("3", "Boleta");
            TTipoDoc.Rows.Add("1", "Factura");
        }
        private void frmDetraccionVentaPagoBancoNacion_Load(object sender, EventArgs e)
        {
            DateTime Hoy = DateTime.Now;
            txtaño.Text = Hoy.Year.ToString("0000");
            txtmes.Text = Hoy.Month.ToString("00");
            CargarDatosCombos();
            TEmpresa = CapaLogica.ListarEmpresas();
            DataView dv = TEmpresa.DefaultView;
            dv.RowFilter = $"Id_empresa = {IdEmpresa}";
            DataTable TDAtos = dv.ToTable();
            txtRuc.Text = TDAtos.Rows[0]["ruc"].ToString();
            txtnombreempresa.Text = TDAtos.Rows[0]["empresa"].ToString();
            ///datatable Acciones
            TDetracciones.Columns.Remove("nro_cta_detracciones");
            TDetracciones.Columns.Remove("BasePEN");
            TDetracciones.Columns.Remove("Moneda");
            TDetracciones.Columns.Remove("diferencia");
            TDetracciones.Columns.Remove("FechaRecepcion");
            TDetracciones.Columns.Remove("FechaCancelado");
            TDetracciones.Columns.Remove("BaseMO");
            TDetracciones.Columns.Remove("tipocomprobante");
            TDetracciones.Columns.Remove("tipo");
            for (int i = 0; i < TDetracciones.Rows.Count; i++)
            {
                if ((int)TDetracciones.Rows[i]["opcion"] != 1) { TDetracciones.Rows.RemoveAt(i); i--; }
            }
            TDetracciones.Columns.Remove("opcion");
            TDetracciones.Columns.Add("empresa");
            TDetracciones.Columns["empresa"].SetOrdinal(0);
            TDetracciones.Columns.Add("numero");
            TDetracciones.Columns["numero"].SetOrdinal(2);
            //
            TDetracciones.Columns["fechaemision"].SetOrdinal(3);
            TDetracciones.Columns["redondeo"].SetOrdinal(12);
            foreach (DataRow item in TDetracciones.Rows)
            {
                item["empresa"] = txtnombreempresa.Text;
                string[] Cadena = item["NroFactura"].ToString().Split('-');
                item["NroFactura"] = Cadena[0];
                item["numero"] = Cadena[1];
            }
            dtgconten.DataSource = TDetracciones;
            lblmensaje.Text = $"Número de Registros = {dtgconten.RowCount}";
            if (TDetracciones.Rows.Count > 0)
            {
                txtcodbienserv.Text = TDetracciones.Rows[0][xCod_Detraccion.DataPropertyName].ToString();
                txttasaDetraccion.Text = decimal.Parse(TDetracciones.Rows[0][xPorcentaje.DataPropertyName].ToString()).ToString("n2");
            }
            CalcularTotales();
        }
        DataGridViewComboBoxColumn Combo;
        public int IdEmpresa { get; internal set; }
        public DataTable TDetracciones { get; set; }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                int y = e.RowIndex;
                Combo = dtgconten.Columns[xtipoid.Name.ToString()] as DataGridViewComboBoxColumn;
                Combo.DataSource = TTipoid;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "valor";
                //
                Combo = dtgconten.Columns[xtipodoc.Name.ToString()] as DataGridViewComboBoxColumn;
                Combo.DataSource = TTipoDoc;
                Combo.ValueMember = "codigo";
                Combo.DisplayMember = "valor";
            }
            //CalcularTotales();
        }
        private void CalcularTotales()
        {
            decimal totaldet = 0;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                totaldet += (decimal)item.Cells[xdetraccion.Name].Value;
            }
            txttotalpago.Text = totaldet.ToString("n2");
        }

        private void dtgconten_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // int x= e.RowIndex;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void msg(string cadena) { HPResergerFunciones.Utilitarios.msg(cadena); }
        private StreamWriter st;
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount == 0) { msg("La Grilla esta Vacia"); this.Close(); }
            if (decimal.Parse(txttotalpago.Text) == 0) { msg("No se Puede Pagar Cero"); this.Close(); }
            if (!txtcodctacte.EstaLLeno())
            {
                txtcodctacte.Focus();
                msg("Ingrese Número de Cuenta "); return;
            }
            if (!txtlote.EstaLLeno())
            {
                txtlote.Focus();
                msg("Ingrese Número de Lote"); return;
            }
            string cabecera = "";
            string cadenatxt = "";
            string[] campo = new string[19];
            string[] Cabecera = new string[19];
            //cCABECERA DEL TXT
            Cabecera[0] = $"P";
            Cabecera[1] = txtRuc.Text;
            Cabecera[2] = HPResergerFunciones.Utilitarios.AddCaracter(txtnombreempresa.Text, ' ', 35, HPResergerFunciones.Utilitarios.Direccion.izquierda);
            Cabecera[3] = txtaño.Text.Substring(2);
            Cabecera[4] = txtlote.Text;
            Cabecera[5] = HPResergerFunciones.Utilitarios.AddCaracterMultiplicarx100(txttotalpago.Text, '0', 15, HPResergerFunciones.Utilitarios.Direccion.derecha);
            cabecera = string.Join("", Cabecera) + "\n";
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                campo[0] = item.Cells[xtipoid.Name].Value.ToString();
                campo[1] = HPResergerFunciones.Utilitarios.AddCaracter(item.Cells[xruc.Name].Value.ToString(), ' ', 11, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                if ((int)item.Cells[xtipoid.Name].Value == 1)
                    campo[2] = (HPResergerFunciones.Utilitarios.AddCaracter(item.Cells[xrazon.Name].Value.ToString(), ' ', 35, HPResergerFunciones.Utilitarios.Direccion.izquierda)).ToUpper();
                else
                    campo[2] = HPResergerFunciones.Utilitarios.AddCaracter("", ' ', 35, HPResergerFunciones.Utilitarios.Direccion.izquierda);
                campo[3] = "000000000";
                campo[4] = txtcodbienserv.Text;
                campo[5] = txtcodctacte.Text;
                campo[6] = HPResergerFunciones.Utilitarios.AddCaracterMultiplicarx100((decimal.Parse(item.Cells[xdetraccion.Name].Value.ToString()) / 100).ToString(), '0', 13, HPResergerFunciones.Utilitarios.Direccion.derecha);
                campo[7] = "0001";
                campo[8] = txtaño.Text;
                campo[9] = txtmes.Text;
                campo[10] = ((int)item.Cells[xtipodoc.Name].Value).ToString("00");
                campo[11] = HPResergerFunciones.Utilitarios.AddCaracter(item.Cells[xserie.Name].Value.ToString(), '0', 4, HPResergerFunciones.Utilitarios.Direccion.derecha);
                campo[12] = HPResergerFunciones.Utilitarios.AddCaracter(item.Cells[xnumero.Name].Value.ToString(), '0', 8, HPResergerFunciones.Utilitarios.Direccion.derecha);

                cadenatxt += string.Join("", campo) + $"{Environment.NewLine}";
            }
            cadenatxt = cabecera + cadenatxt;
            string NameFile = $"D{txtRuc.Text}{txtaño.Text.Substring(2)}{txtlote.Text}";
            SaveFile.FileName = NameFile;
            if (SaveFile.FileName != string.Empty && SaveFile.ShowDialog() == DialogResult.OK)
            {
                string path = SaveFile.FileName;
                st = File.CreateText(path);
                st.Write(cadenatxt);
                st.Close();
                msg("Generado TXT con Éxito");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else msg("Cancelado por el Usuario");
        }
    }
}
