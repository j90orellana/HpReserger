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
    public partial class frmNotaCreditoDetalle : FormGradient
    {
        public frmNotaCreditoDetalle()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        int final = 0, fin = 0;
        public DataTable DatosDetalle { get; set; }
        DataTable Datos;
        private void frmNotaCreditoDetalle_Load(object sender, EventArgs e)
        {
            dtgconten.DataSource = DatosDetalle;

            //Fila de Totales   
            Boolean tota = false;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if (item.Cells[descripcionx.Name].Value.ToString() == "Totales")
                {
                    tota = true;
                    break;
                }
            }
            if (!tota)
            {
                DatosDetalle.Rows.Add(1);
                final = dtgconten.RowCount - 1;
                dtgconten[descripcionx.Name, final].Value = "Totales";

            }
            dtgconten.Rows[dtgconten.Rows.Count - 1].DefaultCellStyle.BackColor = Color.FromArgb(149, 179, 215);
            dtgconten.Rows[dtgconten.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            dtgconten.Rows[dtgconten.Rows.Count - 1].DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fin = dtgconten.Rows[final].Index;
            CalcularTotales();
        }
        public void FilaDeTotales()
        {
            dtgconten.Rows.Add(1);
            final = dtgconten.RowCount - 1;
            dtgconten[descripcionx.Name, final].Value = "Totales";
            dtgconten.Rows[final].DefaultCellStyle.BackColor = Color.FromArgb(149, 179, 215);
            dtgconten.Rows[final].DefaultCellStyle.ForeColor = Color.White;
            dtgconten.Rows[final].DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        public void CalcularTotales()
        {
            decimal sub1 = 0, sub2 = 0, tot = 0, can = 0;

            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if (item.Cells[descripcionx.Name].Value.ToString() == "Totales") fin = item.Index;
            }
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                Boolean servicio = false;
                if ((int)dtgconten[codcomprax.Name, 0].Value == 2) //servicio
                    servicio = true;
                else servicio = false;

                if (item.Index != fin)
                {
                    if (servicio)
                        item.Cells[totalx.Name].Value = (decimal.Parse(item.Cells[cantidadx.Name].Value == null ? "0" : item.Cells[cantidadx.Name].Value.ToString())) / 100 * decimal.Parse(item.Cells[Preciounitariomodificado.Name].Value == null ? "0" : item.Cells[Preciounitariomodificado.Name].Value.ToString());
                    else
                        item.Cells[totalx.Name].Value = decimal.Parse(item.Cells[cantidadx.Name].Value == null ? "0" : item.Cells[cantidadx.Name].Value.ToString()) * decimal.Parse(item.Cells[Preciounitariomodificado.Name].Value == null ? "0" : item.Cells[Preciounitariomodificado.Name].Value.ToString());
                    if ((int)item.Cells[eliminarx.Name].Value == 0)
                    {
                        can += decimal.Parse(item.Cells[cantidadx.Name].Value == null ? "0" : item.Cells[cantidadx.Name].Value.ToString());
                        sub2 += decimal.Parse(item.Cells[Preciounitariomodificado.Name].Value == null ? "0" : item.Cells[Preciounitariomodificado.Name].Value.ToString());
                        sub1 += decimal.Parse(item.Cells[PrecioUnitarioRegistradox.Name].Value == null ? "0" : item.Cells[PrecioUnitarioRegistradox.Name].Value.ToString());

                        tot += decimal.Parse(item.Cells[totalx.Name].Value == null ? "0" : item.Cells[totalx.Name].Value.ToString());
                    }
                }

            }
            dtgconten[cantidadx.Name, fin].Value = can;
            dtgconten[Preciounitariomodificado.Name, fin].Value = sub2;
            dtgconten[PrecioUnitarioRegistradox.Name, fin].Value = sub1;
            dtgconten[totalx.Name, fin].Value = tot;
        }
        private void dtgconten_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (y == dtgconten.Columns[Preciounitariomodificado.Name].Index)
                if (e.Value != null)
                    e.Value = Convert.ToDecimal(e.Value.ToString() == "" ? "0" : e.Value.ToString()).ToString("n2");
        }
        Boolean prueba1 = false;
        Boolean prueba2 = false;
        private void btncancelar_Click(object sender, EventArgs e)
        {
            prueba1 = false;
            prueba2 = false;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if (item.Cells[descripcionx.Name].Value.ToString() != "Totales")
                    if (item.Cells[eliminarx.Name].Value.ToString() != "1")
                    {
                        if (item.Cells[cantidadx.Name].Value.ToString() == "")
                        {
                            prueba1 = true;
                            HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[cantidadx.Name]);
                        }
                        else
                        {
                            HPResergerFunciones.Utilitarios.ColorCeldaNormal(item.Cells[cantidadx.Name]);
                        }
                        if (item.Cells[cantidadx.Name].Value.ToString() == "0")
                        {
                            HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[cantidadx.Name]);
                            prueba2 = true;
                        }
                        else
                        {
                            HPResergerFunciones.Utilitarios.ColorCeldaNormal(item.Cells[cantidadx.Name]);
                        }
                    }
            }
            if (prueba1)
            {
                msg("Las Celdas No pueden estar Vacias"); return;
            }
            if (prueba2)
            {
                msg("La Cantidad no puede ser cero, Seleccione Eliminar"); return;
            }
            this.Close();
        }
        TextBox txt;
        private void dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int y = dtgconten.CurrentCell.ColumnIndex, x = dtgconten.CurrentCell.RowIndex;
            if (y == dtgconten.Columns[Preciounitariomodificado.Name].Index)
            {
                txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= Txt_KeyPress1;
                    txt.KeyPress -= Txt_KeyPress;
                    txt.KeyPress += Txt_KeyPress;
                }
            }
            if (y == dtgconten.Columns[cantidadx.Name].Index)
            {
                txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= Txt_KeyPress;
                    txt.KeyPress -= Txt_KeyPress1;
                    txt.KeyPress += Txt_KeyPress1;
                }
            }
        }
        private void Txt_KeyPress1(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimalesX(e, txt.Text);
        }
        private void dtgconten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex, y = e.ColumnIndex;
            if (y == eliminarx.Index && x != dtgconten.RowCount - 1)
            {
                dtgconten[eliminarx.Name, x].Value = (int)dtgconten[eliminarx.Name, x].Value == 0 ? 1 : 0;
            }
            if (y == eliminarx.Index && x == dtgconten.RowCount - 1)
            {
                dtgconten[eliminarx.Name, x].Value = (int)dtgconten[eliminarx.Name, x].Value == 0 ? 1 : 0;
            }
            if (y == eliminarx.Index && x == dtgconten.RowCount - 1)
            {
                foreach (DataGridViewRow item in dtgconten.Rows)
                {
                    if (item.Index != dtgconten.RowCount - 1)
                        dtgconten[eliminarx.Name, item.Index].Value = (int)dtgconten[eliminarx.Name, dtgconten.RowCount - 1].Value;
                }
            }
            CalcularTotales();
        }
        private void frmNotaCreditoDetalle_FormClosing(object sender, FormClosingEventArgs e)
        {
            prueba1 = false;
            prueba2 = false;
            foreach (DataGridViewRow item in dtgconten.Rows)
            {
                if (item.Cells[descripcionx.Name].Value.ToString() != "Totales")
                    if (item.Cells[eliminarx.Name].Value.ToString() != "1")
                    {
                        if (item.Cells[cantidadx.Name].Value.ToString() == "")
                        {
                            prueba1 = true;
                            HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[cantidadx.Name]);
                        }
                        else
                        {
                            HPResergerFunciones.Utilitarios.ColorCeldaNormal(item.Cells[cantidadx.Name]);
                        }
                        if (item.Cells[cantidadx.Name].Value.ToString() == "0")
                        {
                            HPResergerFunciones.Utilitarios.ColorCeldaError(item.Cells[cantidadx.Name]);
                            prueba2 = true;
                        }
                        else
                        {
                            HPResergerFunciones.Utilitarios.ColorCeldaNormal(item.Cells[cantidadx.Name]);
                        }
                    }
            }
            if (prueba1 || prueba2)
            {
                e.Cancel = true; msg("No Se puede Cerrar Hay Errores");
            }
            if (prueba1)
            {
                msg("Las Celdas No pueden estar Vacias"); return;
            }
            if (prueba2)
            {
                msg("La Cantidad no puede ser cero, Seleccione Eliminar"); return;
            }
        }
        private void dtgconten_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalcularTotales();
        }
    }
}
