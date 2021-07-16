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
        public string NroCuentaBanco
        {
            get { return txtcodctacte.Text; }
            set { txtcodctacte.Text = value; }
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        DataTable TTipoid;
        DataTable TTipoDoc;
        DataTable TEmpresa;
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        public void CargarDatosCombos()
        {
            /////tipo id
            TTipoid = new DataTable();
            TTipoid.Columns.Add("Codigo", typeof(int));
            TTipoid.Columns.Add("valor");
            TTipoid.Rows.Add(1, "DNI");
            TTipoid.Rows.Add(4, "Carnet Ext.");
            TTipoid.Rows.Add(6, "RUC");
            TTipoid.Rows.Add(7, "Pasaporte");
            ////tipo doc
            TTipoDoc = new DataTable();
            TTipoDoc.Columns.Add("Codigo", typeof(int));
            TTipoDoc.Columns.Add("valor");
            TTipoDoc.Rows.Add(3, "Boleta");
            TTipoDoc.Rows.Add(1, "Factura");
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
            if (Compra)
            {
                //por defecto colocamos la el año 2dig y semada del año en 4dig
                txtlote.Text = $"{DateTime.Now.ToString("yy")}{ System.Globalization.CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday).ToString("0000")}";
                TDetracciones.Columns["proveedor"].ColumnName = "nroid";
                TDetracciones.Columns["razon"].ColumnName = "nombre";
                TDetracciones.Columns["id_comprobante"].ColumnName = "idComprobanteSunat";
                dtgconten.Columns[xigv.Name].Visible = false;
                dtgconten.Columns[xmoneda.Name].HeaderText = "Nro Cta Detrac.";
                TDetracciones.Columns.Remove("namecorto");
                TDetracciones.Columns["nro_cta_detracciones"].ColumnName = "namecorto";
                TDetracciones.Columns["tipo"].ColumnName = "tipoid";
                foreach (DataRow item in TDetracciones.Rows)
                {
                    if ((int)item["idcomprobantesunat"] == 2) item[xtipodoc.DataPropertyName] = 1;
                    if ((int)item["idcomprobantesunat"] == 4) item[xtipodoc.DataPropertyName] = 3;
                    item[xtipoid.DataPropertyName] = "Ruc";
                }
            }
            TDetracciones.Columns.Remove("BasePEN");
            TDetracciones.Columns.Remove("Moneda");
            TDetracciones.Columns.Remove("diferencia");
            TDetracciones.Columns.Remove("FechaRecepcion");
            TDetracciones.Columns.Remove("FechaCancelado");
            TDetracciones.Columns.Remove("BaseMO");
            if (!Compra)
            {
                TDetracciones.Columns.Remove("nro_cta_detracciones");
                TDetracciones.Columns.Remove("tipocomprobante");
                TDetracciones.Columns.Remove("tipo");
            }
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
            TDetracciones.Columns["redondeo"].SetOrdinal(!Compra ? 12 : 11);
            foreach (DataRow item in TDetracciones.Rows)
            {
                item["empresa"] = txtnombreempresa.Text;
                string[] Cadena = item["NroFactura"].ToString().Split('-');
                item["NroFactura"] = Cadena[0];
                item["numero"] = Cadena[1];
            }
            //Setteando las Columas de los Combos
            //1
            DataGridViewComboBoxColumn comboboxColumn = dtgconten.Columns[xtipoid.Name.ToString()] as DataGridViewComboBoxColumn;
            comboboxColumn.DataSource = TTipoid;
            comboboxColumn.ValueMember = "codigo";
            comboboxColumn.DisplayMember = "valor";
            //2
            DataGridViewComboBoxColumn comboboxColumn2 = dtgconten.Columns[xtipodoc.Name.ToString()] as DataGridViewComboBoxColumn;
            comboboxColumn2.DataSource = TTipoDoc;
            comboboxColumn2.ValueMember = "codigo";
            comboboxColumn2.DisplayMember = "valor";
            //Fin de Setteo de las Columnas
            dtgconten.DataSource = TDetracciones;
            lblmensaje.Text = $"Número de Registros = {dtgconten.RowCount}";
            if (!Compra)
            {
                if (TDetracciones.Rows.Count > 0)
                {
                    txtcodbienserv.Text = TDetracciones.Rows[0][xCod_Detraccion.DataPropertyName].ToString();
                    txttasaDetraccion.Text = decimal.Parse(TDetracciones.Rows[0][xPorcentaje.DataPropertyName].ToString()).ToString("n2");
                }
            }
            else
            {
                txtcodbienserv.Text = "037";
                dtgconten.Columns[xtipoid.Name].DisplayIndex = 6;
            }
            CalcularTotales();
        }
        DataGridViewComboBoxColumn Combo;
        DataGridViewComboBoxColumn Combo2;
        public int IdEmpresa { get; internal set; }
        public DataTable TDetracciones { get; set; }
        public bool Compra { get; set; }

        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewComboBoxColumn comboboxColumn = dtgconten.Columns[xtipoid.Name.ToString()] as DataGridViewComboBoxColumn;
            //comboboxColumn.DataSource = TTipoid;
            //comboboxColumn.ValueMember = "codigo";
            //comboboxColumn.DisplayMember = "valor";

            //DataGridViewComboBoxColumn comboboxColumn2 = dtgconten.Columns[xtipodoc.Name.ToString()] as DataGridViewComboBoxColumn;
            //comboboxColumn2.DataSource = TTipoDoc;
            //comboboxColumn2.ValueMember = "codigo";
            //comboboxColumn2.DisplayMember = "valor";
            //if (dtgconten.RowCount > 0)
            //{
            //    int y = e.RowIndex;
            //    Combo = dtgconten.Columns[xtipoid.Name.ToString()] as DataGridViewComboBoxColumn;
            //    Combo.DataSource = TTipoid;
            //    Combo.ValueMember = "codigo";
            //    Combo.DisplayMember = "valor";
            //    //
            //    Combo2 = dtgconten.Columns[xtipodoc.Name.ToString()] as DataGridViewComboBoxColumn;
            //    Combo2.DataSource = TTipoDoc;
            //    Combo2.ValueMember = "codigo";
            //    Combo2.DisplayMember = "valor";
            //}
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
            //msg($"{ e.ColumnIndex} - {e.RowIndex} ");
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private StreamWriter st;
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (!txtcodctacte.EstaLLeno()) { msg("Ingrese Cuenta del Banco de la Nación"); return; }
            if (!txtlote.EstaLLeno()) { msg("Ingrese el LOTE, AANNNN = año y secuencia"); return; }
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
            Cabecera[0] = Compra ? $"*" : $"P";
            Cabecera[1] = txtRuc.Text;//11
            Cabecera[2] = HPResergerFunciones.Utilitarios.AddCaracter(txtnombreempresa.Text, ' ', 35, HPResergerFunciones.Utilitarios.Direccion.izquierda);//35
            Cabecera[3] = txtlote.Text;//6
            Cabecera[4] = HPResergerFunciones.Utilitarios.AddCaracterMultiplicarx100(txttotalpago.Text, '0', 15, HPResergerFunciones.Utilitarios.Direccion.derecha);//15
            cabecera = string.Join("", Cabecera) + $"{Environment.NewLine}";//aGREGAMOS EL SALTO DE LINEA QUE VARIA EL SISTEMA OPERATIVO
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                campo[0] = Compra ? "6" : item.Cells[xtipoid.Name].Value.ToString();//1
                campo[1] = HPResergerFunciones.Utilitarios.AddCaracter(item.Cells[xruc.Name].Value.ToString(), ' ', 11, HPResergerFunciones.Utilitarios.Direccion.izquierda);//11
                                                                                                                                                                             //if ((int)item.Cells[xtipoid.Name].Value == 1)
                                                                                                                                                                             //AGREGAMOS LA VALIDACION QUITANDO LA Ñ QUE DABA PROBEMAS AL SUBIR EL TXT PARA VALIDAR
                //campo[2] = (HPResergerFunciones.Utilitarios.AddCaracter(Configuraciones.RemoverAcentosÑApostrofe(item.Cells[xrazon.Name].Value.ToString()), ' ', 35, HPResergerFunciones.Utilitarios.Direccion.izquierda)).ToUpper();//35
                                                                                                                                                                                                                                     //else
                campo[2] = HPResergerFunciones.Utilitarios.AddCaracter("", ' ', 35, HPResergerFunciones.Utilitarios.Direccion.izquierda);//35
                campo[3] = "000000000";//9
                campo[4] = txtcodbienserv.Text;
                campo[5] = Compra ? HPResergerFunciones.Utilitarios.AddCaracter(item.Cells[xmoneda.Name].Value.ToString(), '0', 11, HPResergerFunciones.Utilitarios.Direccion.derecha) : txtcodctacte.Text;
                campo[6] = HPResergerFunciones.Utilitarios.AddCaracterMultiplicarx100((decimal.Parse(item.Cells[xdetraccion.Name].Value.ToString())).ToString(), '0', 15, HPResergerFunciones.Utilitarios.Direccion.derecha);
                campo[7] = "01";
                campo[8] = ((DateTime)item.Cells[xFechaEmision.Name].Value).Year.ToString();
                campo[9] = ((DateTime)item.Cells[xFechaEmision.Name].Value).Month.ToString("00");
                campo[10] = ((int)item.Cells[xtipodoc.Name].Value).ToString("00");
                campo[11] = HPResergerFunciones.Utilitarios.AddCaracter(item.Cells[xserie.Name].Value.ToString(), '0', 4, HPResergerFunciones.Utilitarios.Direccion.derecha);
                campo[12] = HPResergerFunciones.Utilitarios.AddCaracter(item.Cells[xnumero.Name].Value.ToString(), '0', 8, HPResergerFunciones.Utilitarios.Direccion.derecha);

                cadenatxt += string.Join("", campo) + $"{Environment.NewLine}";
            }
            cadenatxt = cabecera + cadenatxt;
            string NameFile = $"D{txtRuc.Text}{txtlote.Text}";
            SaveFile.FileName = NameFile;
            if (SaveFile.FileName != string.Empty && SaveFile.ShowDialog() == DialogResult.OK)
            {
                string path = SaveFile.FileName;
                st = File.CreateText(path);
                st.Write(cadenatxt);
                st.Close();
                if (msgp("Generado TXT con Éxito, Desea Continuar") == DialogResult.Yes)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else return;
            }
            else msg("Cancelado por el Usuario");
        }
        public DialogResult msgp(string cadena) { return HPResergerFunciones.frmPregunta.MostrarDialogYesCancel(cadena); }

    }
}
