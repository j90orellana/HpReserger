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
    public partial class frmimpuestoRenta : Form
    {
        public frmimpuestoRenta()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void ImpuestoRenta_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        DataRow BuscarIgv;
        public void CargarDatos()
        {
            BuscarIgv = CapaLogica.BuscarParametros("uit", DateTime.Now);
            if (BuscarIgv != null)
            {
                txtuit.Text = (decimal.Parse(BuscarIgv["valor"].ToString())).ToString("S/ 0.00");
            }
            dtgconten.DataSource = CapaLogica.InsertarActualizarImpuestoRenta(10, 0, "", 0, 0, 0, "", 0);
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                btnexportarExcel.Enabled = true;
                //btnmodificar.Enabled = true;
            }
            else
            {
                btnexportarExcel.Enabled = false;
                //btnmodificar.Enabled = false;
            }
        }
        int estado = 0;
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 1;
            Iniciar(true);

        }
        public void Iniciar(Boolean a)
        {
            dtgconten.ReadOnly = !a;
            btnaceptar.Enabled = a;
            btnmodificar.Enabled = !a;
            dtgconten.AllowUserToAddRows = a;
            btnexportarExcel.Enabled = !a;
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, "HpReserger", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //msg(dtgconten.RowCount.ToString());
            for (int i = 0; i < dtgconten.RowCount - 1; i++)
            {
                if (string.IsNullOrWhiteSpace(dtgconten["descripcion", i].Value.ToString()))
                {
                    msg($"Ingresé Descripción de la fila: {i + 1 }");
                    dtgconten.CurrentCell = dtgconten["descripcion", i];
                    return;
                }
                if (string.IsNullOrWhiteSpace(dtgconten["minimo", i].Value.ToString()))
                {
                    msg($"Ingresé el valor Minimo de la fila: {i + 1 }");
                    dtgconten.CurrentCell = dtgconten["minimo", i];
                    return;
                }
                if (string.IsNullOrWhiteSpace(dtgconten["maximo", i].Value.ToString()))
                {
                    msg($"Ingresé el valor Maximo de la fila: {i + 1 }");
                    dtgconten.CurrentCell = dtgconten["maximo", i];
                    return;
                }
                if (string.IsNullOrWhiteSpace(dtgconten["valor", i].Value.ToString()))
                {
                    msg($"Ingresé el Porcentaje de la fila: {i + 1 }");
                    dtgconten.CurrentCell = dtgconten["valor", i];
                    return;
                }
                if (string.IsNullOrWhiteSpace(dtgconten["minimo", i].Value.ToString()) && i > 0)
                {
                    msg($"El valor Minimo de la fila: {i + 1 }, No puede ser Cero");
                    dtgconten.CurrentCell = dtgconten["minimo", i];
                    return;
                }
                if ((decimal)dtgconten["maximo", i].Value == 0)
                {
                    msg($"El valor Maximo de la fila: {i + 1 },No puede ser Cero");
                    dtgconten.CurrentCell = dtgconten["maximo", i];
                    return;
                }
                if (((decimal)dtgconten["valor", i].Value) == 0)
                {
                    msg($"El Porcentaje de la fila: {i + 1 }, No puede ser Cero");
                    dtgconten.CurrentCell = dtgconten["valor", i];
                    return;
                }
            }///fin del for
            dtgconten.AllowUserToAddRows = false;
            for (int i = 0; i < dtgconten.RowCount; i++)
            {
                //1=insertar 2=actualizar
                if (dtgconten["id", i].Value != null)
                    CapaLogica.InsertarActualizarImpuestoRenta(2, (int)dtgconten["id", i].Value, dtgconten["descripcion", i].Value.ToString(), (decimal)dtgconten["minimo", i].Value, (decimal)dtgconten["maximo", i].Value, ((decimal)dtgconten["valor", i].Value), dtgconten["observacion", i].Value.ToString(), frmLogin.CodigoUsuario);
                else
                    CapaLogica.InsertarActualizarImpuestoRenta(1, (int)dtgconten["id", i].Value, dtgconten["descripcion", i].Value.ToString(), (decimal)dtgconten["minimo", i].Value, (decimal)dtgconten["maximo", i].Value, ((decimal)dtgconten["valor", i].Value), dtgconten["observacion", i].Value.ToString(), frmLogin.CodigoUsuario);
            }
            msg("Guardado Con Exito");
            btncancelar_Click(sender, e);
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado != 0)
                Iniciar(false);
            else
                this.Close();
            estado = 0;
            CargarDatos();
        }
        TextBox txt, txt1;
        private void dtgconten_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            txt = e.Control as TextBox;
            txt.KeyPress -= new KeyPressEventHandler(dataGridview_KeyPressCajita);
            txt.KeyDown -= new KeyEventHandler(datagridview_pegarletras);
            txt1 = e.Control as TextBox;
            txt1.KeyPress -= new KeyPressEventHandler(dataGridview_KeyPressCajitanumeros);
            txt1.KeyDown -= new KeyEventHandler(datagridview_pegarnumeros);
            if (dtgconten.Columns["descripcion"].Index == dtgconten.CurrentCell.ColumnIndex || dtgconten.Columns["observacion"].Index == dtgconten.CurrentCell.ColumnIndex)
            {
                txt = e.Control as TextBox;
                txt.CharacterCasing = CharacterCasing.Upper;
                if (txt != null)
                {
                    txt.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajita);
                    txt.KeyDown += new KeyEventHandler(datagridview_pegarletras);
                }
            }
            if (dtgconten.Columns["minimo"].Index == dtgconten.CurrentCell.ColumnIndex || dtgconten.Columns["maximo"].Index == dtgconten.CurrentCell.ColumnIndex || dtgconten.Columns["valor"].Index == dtgconten.CurrentCell.ColumnIndex)
            {
                txt1 = e.Control as TextBox;
                if (txt1 != null)
                {
                    txt1.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajitanumeros);
                    txt1.KeyDown += new KeyEventHandler(datagridview_pegarnumeros);
                }
            }
        }
        private void datagridview_pegarletras(object sender, KeyEventArgs e)
        {
            // HPResergerFunciones.Utilitarios.ValidarPegarSoloLetrasyEspacio(e, txt, 70);
        }
        private void dataGridview_KeyPressCajita(object sender, KeyPressEventArgs e)
        {
            //HPResergerFunciones.Utilitarios.Sololetras(e);
        }
        private void datagridview_pegarnumeros(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txt1);
        }
        private void dataGridview_KeyPressCajitanumeros(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimalesX(e, txt1.Text);
        }

        private void dtgconten_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4)
                {
                    if (string.IsNullOrWhiteSpace(dtgconten[e.ColumnIndex, e.RowIndex].Value.ToString()))
                    {
                        dtgconten[e.ColumnIndex, e.RowIndex].Value = 0;
                    }
                }
            }
        }
        private void dtgconten_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        public void ModificarPorcentaje(decimal numero)
        {
            foreach (DataGridViewRow filita in dtgconten.Rows)
            {
                filita.Cells["valor"].Value = (decimal)filita.Cells["valor"].Value * numero;
            }
        }
        private void btnexportarExcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                List<HPResergerFunciones.Utilitarios.NombreCelda> Celditas = new List<HPResergerFunciones.Utilitarios.NombreCelda>();
                HPResergerFunciones.Utilitarios.NombreCelda Celdita = new HPResergerFunciones.Utilitarios.NombreCelda();
                Celdita.fila = 1; Celdita.columna = 1; Celdita.Nombre = "Tabla de Impuesto a la Renta";
                Celditas.Add(Celdita);
                HPResergerFunciones.Utilitarios.NombreCelda Celdita1 = new HPResergerFunciones.Utilitarios.NombreCelda();
                Celdita1.fila = 1; Celdita1.columna = 2; Celdita1.Nombre = "Valor de la UIT";
                Celditas.Add(Celdita1);
                HPResergerFunciones.Utilitarios.NombreCelda Celdita2 = new HPResergerFunciones.Utilitarios.NombreCelda();
                Celdita2.fila = 2; Celdita2.columna = 2; Celdita2.Nombre = decimal.Parse(BuscarIgv["valor"].ToString()).ToString("n2");
                Celditas.Add(Celdita2);
                //CONVIERTO A PORCENTAJE;
                ModificarPorcentaje(0.01m);
                HPResergerFunciones.Utilitarios.ExportarAExcel(dtgconten, "", "Imp. Renta", Celditas, 2, new int[] { 1 }, new int[] { 1 }, new int[] { });
                ModificarPorcentaje(100);
                msg("Exportado con Exito");
            }
            else
                msg("No hay Filas para Exportar");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y = dtgconten.RowCount - 2;
            //dtgconten.DataBindings.Clear();
            if (dtgconten["descripcion", y].Value != null || dtgconten["observacion", y].Value != null)
            {
                //epError.SetError(dtgconten, null);
                epError.Clear();
            }
            else
                epError.SetError(dtgconten, "Ultima Fila esta Vacia");
        }
    }
}
