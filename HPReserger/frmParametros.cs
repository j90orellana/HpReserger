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
    public partial class frmParametros : FormGradient
    {
        public frmParametros()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void CargarDatos()
        {
            dtgconten.DataSource = CapaLogica.ActualizarParametros(0, "", 3, "", 1,dtpfecha.Value);
        }
        private void frmParametros_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        /*
        public void BuscarValores()
        {
            foreach (DataGridViewRow fila in dtgconten.Rows)
            {
                if (fila.Cells["descripcion"].Value.ToString() == "UIT")
                {
                    txtuit.Value = 0;
                    txtuit.Value = decimal.Parse(fila.Cells["valor"].Value.ToString());
                    txtuitobs.Text = fila.Cells["observacion"].Value.ToString();
                }
                if (fila.Cells["descripcion"].Value.ToString() == "IGV")
                {
                    txtigv.Value = 0;
                    txtigv.Value = decimal.Parse(fila.Cells["valor"].Value.ToString()) * 100;
                    txtigvobs.Text = fila.Cells["observacion"].Value.ToString();
                }
                if (fila.Cells["descripcion"].Value.ToString() == "ITF")
                {
                    txtitf.Value = 0;
                    txtitf.Value = decimal.Parse(fila.Cells["valor"].Value.ToString()) * 100;
                    txtitfobs.Text = fila.Cells["observacion"].Value.ToString();
                }
                if (fila.Cells["descripcion"].Value.ToString() == "APORTE ESSALUD")
                {
                    txtaporteessalud.Value = 0;
                    txtaporteessalud.Value = decimal.Parse(fila.Cells["valor"].Value.ToString()) * 100;
                    txtessobs.Text = fila.Cells["observacion"].Value.ToString();
                }
                if (fila.Cells["descripcion"].Value.ToString() == "APORTE ESSALUD_EPS")
                {
                    txteps.Value = 0;
                    txteps.Value = decimal.Parse(fila.Cells["valor"].Value.ToString()) * 100;
                    txtepsobs.Text = fila.Cells["observacion"].Value.ToString();
                }
                if (fila.Cells["descripcion"].Value.ToString() == "APORTE EPS_ESSALUD")
                {
                    txtaporteeps.Value = 0;
                    txtaporteeps.Value = decimal.Parse(fila.Cells["valor"].Value.ToString()) * 100;
                    txtepsessobs.Text = fila.Cells["observacion"].Value.ToString();
                }
                if (fila.Cells["descripcion"].Value.ToString() == "ONP PORCENTAJE")
                {
                    txtonp.Value = 0;
                    txtonp.Value = decimal.Parse(fila.Cells["valor"].Value.ToString()) * 100;
                    txtonpobs.Text = fila.Cells["observacion"].Value.ToString();
                }
                if (fila.Cells["descripcion"].Value.ToString() == "ONP VALOR MINIMO")
                {
                    txtonpminimo.Value = 0;
                    txtonpminimo.Value = decimal.Parse(fila.Cells["valor"].Value.ToString());
                    txtonpminimoobs.Text = fila.Cells["observacion"].Value.ToString();
                }
                if (fila.Cells["descripcion"].Value.ToString() == "REMUNERACION MINIMA VITAL")
                {
                    txtbasica.Value = 0;
                    txtbasica.Value = decimal.Parse(fila.Cells["valor"].Value.ToString());
                    txtbasicaobs.Text = fila.Cells["observacion"].Value.ToString();
                }
                if (fila.Cells["descripcion"].Value.ToString() == "ASIGNACION FAMILIAR")
                {
                    txtfamiliar.Value = 0;
                    txtfamiliar.Value = decimal.Parse(fila.Cells["valor"].Value.ToString()) * 100;
                    txtfamiliarobs.Text = fila.Cells["observacion"].Value.ToString();
                }

            }
        }
        */
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }
        int estado = 0;
        public void iniciar(Boolean a)
        {
            btnmodificar.Enabled = !a;
            btnaceptar.Enabled = a;
            dtgconten.Enabled = !a;
            btnexportarExcel.Enabled = !a;
            btneliminar.Enabled = !a;
            txtobservacion.Enabled = txtdescripcion.Enabled = txtvalor.Enabled = a;
            dtpfecha.Enabled = a;btnnuevo.Enabled = !a;
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            iniciar(true);
            estado = 1;
            txtdescripcion.Text = txtobservacion.Text = "";
            txtvalor.txt.Text = "0";dtpfecha.Value = DateTime.Now;
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            estado = 2;
            iniciar(true);
            txtdescripcion.Enabled = false;
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                this.Close();
            }
            else
            {
                iniciar(false);
                estado = 0;
            }
            CargarDatos();
        }
        private void Msg(string cadena)
        {
            MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        public void msg(string cadena)
        {
            MessageBox.Show(cadena, CompanyName ,MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdescripcion.Text))
            {
                msg("Ingresé la Descripción");
                txtdescripcion.Focus();
                return;
            }
            //if (string.IsNullOrWhiteSpace(txtobservacion.Text))
            // {
            //     msg("Ingresé la Observación");
            //     txtobservacion.Focus();
            //     return;
            //  }
            if (string.IsNullOrWhiteSpace(txtvalor.txt.Text))
            {
                msg("Ingresé el Valor");
                txtvalor.txt.Focus();
                return;
            }
            if (decimal.Parse(txtvalor.txt.Text) <= 0)
            {
                msg("El Valor No puede ser de Cero");
                txtvalor.txt.Focus();
                return;
            }
            //dtgconten.AllowUserToAddRows = false;
            /*  for (int i = 0; i < dtgconten.RowCount; i++)
              {
                  if (string.IsNullOrWhiteSpace(dtgconten["descripcion", i].Value.ToString()))
                  {
                      msg($"Ingresé Descripción de la fila: {i + 1 }");
                      dtgconten.CurrentCell = dtgconten["descripcion", i];
                      return;
                  }
                  if (string.IsNullOrWhiteSpace(dtgconten["valor", i].Value.ToString()))
                  {
                      msg($"Ingresé el valor de la fila: {i + 1 }");
                      dtgconten.CurrentCell = dtgconten["valor", i];
                      return;
                  }
                  if (string.IsNullOrWhiteSpace(dtgconten["valor", i].Value.ToString()))
                  {
                      msg($"El valor de la fila: {i + 1 }, No puede ser Cero");
                      dtgconten.CurrentCell = dtgconten["valor", i];
                      return;
                  }
                  if ((decimal)dtgconten["valor", i].Value == 0)
                  {
                      msg($"El valor  de la fila: {i + 1 }, No puede ser Cero");
                      dtgconten.CurrentCell = dtgconten["valor", i];
                      return;
                  }
                  i
              }///fin del for
              for (int i = 0; i < dtgconten.RowCount; i++)
              {*/
            //1=insertar 2=actualizar
            //  if (dtgconten["id", i].Value != null)
            //     CapaLogica.ActualizarParametros(2, (int)dtgconten["id", i].Value, dtgconten["descripcion", i].Value.ToString(), (decimal)dtgconten["minimo", i].Value, (decimal)dtgconten["maximo", i].Value, ((decimal)dtgconten["valor", i].Value), dtgconten["observacion", i].Value.ToString(), frmLogin.CodigoUsuario);
            //  else
            CapaLogica.ActualizarParametros(1, txtdescripcion.Text, decimal.Parse(txtvalor.txt.Text), txtobservacion.Text, frmLogin.CodigoUsuario, dtpfecha.Value);
            // }
            IRentas Rentas = this.MdiParent as IRentas;
            if (Rentas != null)
                Rentas.BuscarRenta(1, 2);
            Msg("Guardado con Exito");
            btncancelar_Click(sender, e);
        }
        private void txtuit_ValueChanged(object sender, EventArgs e)
        {
        }
        private void txtuit_Leave(object sender, EventArgs e)
        {
            if (((Control)sender).Text == string.Empty)
            {
                ((Control)sender).Text = ((NumericUpDown)sender).Value.ToString();
            }
        }

        private void dtgconten_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            if (dtgconten.RowCount > 0)
                btnexportarExcel.Enabled = true;
            else
                btnexportarExcel.Enabled = false;
            if (fila >= 0)
            {
                txtvalor.txt.Text = dtgconten["valor", fila].Value.ToString();
                txtobservacion.Text = dtgconten["observacion", fila].Value.ToString();
                txtdescripcion.Text = dtgconten["descripcion", fila].Value.ToString();
                dtpfecha.Value = (DateTime)dtgconten["fecha", fila].Value;
            }
        }
        private void dtgconten_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgconten.Columns["valor"].Index)
                {
                    if (string.IsNullOrWhiteSpace(dtgconten[e.ColumnIndex, e.RowIndex].Value.ToString()))
                    {
                        dtgconten[e.ColumnIndex, e.RowIndex].Value = 0;
                    }
                }
            }
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
            if (dtgconten.Columns["valor"].Index == dtgconten.CurrentCell.ColumnIndex)
            {
                txt1 = e.Control as TextBox;
                if (txt1 != null)
                {
                    txt1.KeyPress += new KeyPressEventHandler(dataGridview_KeyPressCajitanumeros);
                    txt1.KeyDown += new KeyEventHandler(datagridview_pegarnumeros);
                }
            }
        }
        private void datagridview_pegarnumeros(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.ValidarDinero(e, txt1);
        }
        private void dataGridview_KeyPressCajitanumeros(object sender, KeyPressEventArgs e)
        {
            HPResergerFunciones.Utilitarios.SoloNumerosDecimalesX(e, txt1.Text);
        }
        private void datagridview_pegarletras(object sender, KeyEventArgs e)
        {
            // HPResergerFunciones.Utilitarios.ValidarPegarSoloLetrasyEspacio(e, txt, 70);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro Quiere Eliminar", CompanyName ,MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                CapaLogica.ActualizarParametros(10, dtgconten["descripcion", dtgconten.CurrentCell.RowIndex].Value.ToString(), 0, "", (int)dtgconten["id", dtgconten.CurrentCell.RowIndex].Value, dtpfecha.Value);
                CargarDatos();
            }
            IRentas Rentas = this.MdiParent as IRentas;
            if (Rentas != null)
                Rentas.BuscarRenta(1, 2);
        }
        private void btnexportarExcel_Click(object sender, EventArgs e)
        {
            if (dtgconten.RowCount > 0)
            {
                List<HPResergerFunciones.Utilitarios.NombreCelda> Celditas = new List<HPResergerFunciones.Utilitarios.NombreCelda>();
                HPResergerFunciones.Utilitarios.NombreCelda Celdita = new HPResergerFunciones.Utilitarios.NombreCelda();
                Celdita.fila = 1; Celdita.columna = 1; Celdita.Nombre = "Tabla de Parametros";
                Celditas.Add(Celdita);
                HPResergerFunciones.Utilitarios.ExportarAExcel(dtgconten, "", "Parametros", Celditas, 2, new int[] { 1, 5 }, new int[] { 1 }, new int[] { });
                msg("Exportado con Exito");
            }
            else
                msg("No hay Filas para Exportar");
        }

        private void dtgconten_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                frmParametrosDetalle Detallito = new frmParametrosDetalle();
                Detallito.Icon = Icon;
                Detallito.dtgconten.DataSource = CapaLogica.ActualizarParametros(9, dtgconten["descripcion", e.RowIndex].Value.ToString(), 0, "", (int)dtgconten["id", e.RowIndex].Value, dtpfecha.Value);
                Detallito.ShowDialog();
                //int Ocultar = 0;
                //if (dtgconten["id", e.RowIndex].Value.ToString() == "99")
                //{
                //    dtgconten["id", e.RowIndex].Value = "0";
                //    Ocultar = 1;
                //}
                //else
                //{
                //    Ocultar = 0;
                //    dtgconten["id", e.RowIndex].Value = "99";
                //}
                //if (!string.IsNullOrWhiteSpace(dtgconten["id", e.RowIndex].Value.ToString()))
                //{
                //    DataTable tablon = ((DataTable)dtgconten.DataSource).Clone();
                //    tablon = (System.Data.DataTable)dtgconten.DataSource;                    
                //    List<DataRow> datos = new List<DataRow>();
                //    foreach (DataRow datito in tablon.Rows)
                //    {
                //        datos.Add(datito);
                //    }
                //    DataTable tablita = CapaLogica.ActualizarParametros(9, dtgconten["descripcion", e.RowIndex].Value.ToString(), 0, "", (int)dtgconten["id", e.RowIndex].Value);
                //    //System.Data.DataTable tablita = CLPresuOpera.ListarDetalleDelReporteDeCentrodeCosto((int)dtgconten["id_etapas", e.RowIndex].Value, dtgconten["codcentroc", e.RowIndex].Value.ToString(), dtgconten["Cta_Contable", e.RowIndex].Value.ToString());
                //    int i = 1;
                //    //dtgconten.DataSource = null;
                //    foreach (DataRow dato in tablita.Rows)
                //    {
                //        if (Ocultar == 0)
                //            datos.Insert(e.RowIndex + i, dato);
                //        i++;
                //    }
                //    if (Ocultar == 1)
                //        datos.RemoveRange(e.RowIndex + 1, tablita.Rows.Count);
                //    tablon = datos.CopyToDataTable();
                //    dtgconten.DataSource = tablon;
                /////////////////////////////////////////////////////////////////////////////*
                /*    int esto=10;        
                    List<numeros> numero = new List<numeros>();
                    numeros valor = new numeros();
                    valor.numero = 10;
                    valor.nombre = "Jefferson Orellana";
                    valor.valor = 10.01m;
                    numero.Add(valor);
                    List<numeros> aloja = numero.FindAll(holi => holi.numero > esto);
                    IEnumerable<numeros> lista = from valores in numero where valores.valor > esto select valor;
                  */
                /////////////////////////////////////////////////////////////////////////////
                // List<int> Scores = new List<int>() { 97, 92, 81, 60 };
                //   IEnumerable<int> lista = from score in Scores where score > 80 select score;
            }
            // dtgconten.CurrentCell = dtgconten[e.ColumnIndex, e.RowIndex];
            //if (dtgconten["id", e.RowIndex].Value.ToString() != "0")
            //{
            //    int fila = e.RowIndex;
            //    DataTable tablita = ((DataTable)dtgconten.DataSource).Clone();
            //    tablita = CapaLogica.ActualizarParametros(9, dtgconten["descripcion", e.RowIndex].Value.ToString(), 0, "", (int)dtgconten["id", e.RowIndex].Value);
            //    DataTable conten = (DataTable)dtgconten.DataSource;
            //    int con = 1;
            //    foreach (DataRow filita in tablita.Rows)
            //    {
            //        // conten.Rows.InsertAt(filita, con);
            //        //conten.AcceptChanges();
            //        //conten.NewRow();
            //        //conten.Rows.Add(filita);


            //        conten.Rows.InsertAt(filita, conten.Rows.Count + 1);


            //        con++;
            //    }
            //    dtgconten.DataSource = conten;
            //    dtgconten.CurrentCell = dtgconten[e.ColumnIndex, fila];
            //}
        }


        private void dataGridview_KeyPressCajita(object sender, KeyPressEventArgs e)
        {
            //HPResergerFunciones.Utilitarios.Sololetras(e);
        }
    }
}
