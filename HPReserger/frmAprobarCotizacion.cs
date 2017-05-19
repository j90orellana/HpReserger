using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HPReserger
{
    public partial class frmAprobarCotizacion : Form
    {
        HPResergerCapaLogica.HPResergerCL clAprobarCotizacion = new HPResergerCapaLogica.HPResergerCL();
        public int Item { get; set; }
        public int ItemAprob { get; set; }
        public byte[] Foto { get; set; }
        MemoryStream _memoryStream = new MemoryStream();

        DataTable dtCotizaciones;
        DataTable dtCotizacionesAsociadas;

        public frmAprobarCotizacion()
        {
            InitializeComponent();
        }

        private void gridCotizacion_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Item = e.RowIndex;
            dtCotizacionesAsociadas = clAprobarCotizacion.ListarCotizacionesAsociadas(Convert.ToInt32(gridCotizacion.Rows[Item].Cells[0].Value.ToString().Substring(2, 4)));

            if (dtCotizacionesAsociadas.Rows.Count > 0)
            {
                gridCotizacionesAsociadas.DataSource = dtCotizacionesAsociadas;
            }
            else
            {
                gridCotizacionesAsociadas.DataSource = null;
                gridCotizacionesAsociadas.Rows.Clear();
                gridCotizacionesAsociadas.Refresh();

                TitulosGrid(gridCotizacionesAsociadas, 1);
            }
        }

        private void frmAprobarCotizacion_Load(object sender, EventArgs e)
        {
            Mostrar(frmLogin.CodigoUsuario);
            System.Globalization.CultureInfo CT = new System.Globalization.CultureInfo("EN-US");
            Application.CurrentCulture = CT;
        }

        private void Mostrar(int Usuario)
        {
            dtCotizaciones = clAprobarCotizacion.ListarCotizacionesAsociadasParaAprobar(Usuario);

            if (dtCotizaciones.Rows.Count > 0)
            {
                gridCotizacion.DataSource = dtCotizaciones;
            }
            else
            {
                gridCotizacion.DataSource = null;
                gridCotizacion.Rows.Clear();
                gridCotizacion.Refresh();
                TitulosGrid(gridCotizacion, 0);

                gridCotizacionesAsociadas.DataSource = null;
                gridCotizacionesAsociadas.Rows.Clear();
                gridCotizacionesAsociadas.Refresh();
                TitulosGrid(gridCotizacionesAsociadas, 1);
            }
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            if (ItemAprob < 0)
            {
                MessageBox.Show("Seleccione Cotización a Aprobar", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (pbFoto.Image == null)
            {
                MessageBox.Show("NO existe imagen de Cotización", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (gridCotizacionesAsociadas.Rows.Count < 3)
            {
                MessageBox.Show("Mínimo son 3 cotizaciones", "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            
            if (MessageBox.Show("¿ Desea Aprobar Cotización Nº " + gridCotizacionesAsociadas.Rows[ItemAprob].Cells[0].Value.ToString() + " ?", "HP Reserger", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                clAprobarCotizacion.AprobacionNOCotizacion(Convert.ToInt32(gridCotizacionesAsociadas.Rows[ItemAprob].Cells[0].Value.ToString().Substring(2, 4)), "usp_Set_Aprobacion_Cotizacion");

                int fila = 0;
                for (fila = 0; fila < gridCotizacionesAsociadas.Rows.Count; fila++)
                {
                    if(fila != ItemAprob)
                    {
                        clAprobarCotizacion.AprobacionNOCotizacion(Convert.ToInt32(gridCotizacionesAsociadas.Rows[fila].Cells[0].Value.ToString().Substring(2, 4)), "usp_Set_NOAprobacion_Cotizacion");
                    }
                }
                int NumeroCotizacion = 0;
                int TipoArticulo = 0;
                if (gridCotizacion.Rows[Item].Cells[7].Value.ToString().Substring(0, 1) == "S")
                {
                    TipoArticulo = 1;
                }
                clAprobarCotizacion.OrdenCompraInsertar(out NumeroCotizacion, Convert.ToInt32(gridCotizacionesAsociadas.Rows[ItemAprob].Cells[0].Value.ToString().Substring(2, 4)),  Convert.ToInt32(gridCotizacion.Rows[Item].Cells[0].Value.ToString().Substring(2, 4)), Convert.ToInt32(gridCotizacion.Rows[Item].Cells[8].Value.ToString()), Convert.ToInt32(gridCotizacion.Rows[Item].Cells[10].Value.ToString()), Convert.ToInt32(gridCotizacion.Rows[Item].Cells[1].Value.ToString()), Convert.ToInt32(gridCotizacion.Rows[Item].Cells[3].Value.ToString()), Convert.ToInt32(gridCotizacion.Rows[Item].Cells[5].Value.ToString()), gridCotizacionesAsociadas.Rows[ItemAprob].Cells[2].Value.ToString(), Convert.ToDecimal(gridCotizacionesAsociadas.Rows[ItemAprob].Cells[4].Value.ToString()), TipoArticulo);

                string Cot = gridCotizacionesAsociadas.Rows[ItemAprob].Cells[0].Value.ToString().Substring(2,4);
                Mostrar(frmLogin.CodigoUsuario);
                MessageBox.Show("Se aprobó la Cotización Nº " + Cot + " y se generó la OC Nº " + Convert.ToString(NumeroCotizacion) + "" , "HP Reserger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridCotizacionesAsociadas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ItemAprob = e.RowIndex;
            CargarFoto(Convert.ToInt32(gridCotizacionesAsociadas.Rows[e.RowIndex].Cells[0].Value.ToString().Substring(2, 4)), e.RowIndex);
        }
        private void CargarFoto(int Cotizacion, int Item)
        {
            if (gridCotizacionesAsociadas.Rows[Item].Cells[0].Value != null && gridCotizacionesAsociadas.Rows.Count > 0)
            {
                DataRow drFoto = clAprobarCotizacion.CargarImagenCotizacion(Cotizacion);
                if (drFoto["Foto"] != null && drFoto["Foto"].ToString().Length > 0)
                {
                    byte[] Fotito = new byte[0];
                    Fotito = (byte[])drFoto["Foto"];
                    MemoryStream ms = new MemoryStream(Fotito);
                    pbFoto.Image = Bitmap.FromStream(ms);
                }
                else
                {
                    pbFoto.Image = null;
                }
            }
            else
            {
                pbFoto.Image = null;
            }
        }

        private void TitulosGrid(DataGridView Grid, int Tipo)
        {

            if (Tipo == 0)
            {
                if (Grid.Columns.Count == 0)
                {
                    Grid.Columns.Add("OP", "");
                    Grid.Columns.Add("C", "");
                    Grid.Columns.Add("USUARIO", "");
                    Grid.Columns.Add("CODIGOAREA", "");
                    Grid.Columns.Add("AREA", "");
                    Grid.Columns.Add("CODIGOGERENCIA", "");
                    Grid.Columns.Add("GERENCIA", "");
                    Grid.Columns.Add("TIPO_PEDIDO", "");
                    Grid.Columns.Add("CODIGOCC", "");
                    Grid.Columns.Add("CENTROCOSTO", "");
                    Grid.Columns.Add("CODIGOPP", "");
                    Grid.Columns.Add("PARTIDAPRESUPUESTO", "");
                }

                Grid.Columns[0].Width = 70;
                Grid.Columns[0].Visible = true;
                Grid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns[0].HeaderText = "Nº OP";
                Grid.Columns[0].DataPropertyName = "OP";

                Grid.Columns[1].Width = 0;
                Grid.Columns[1].Visible = false;
                Grid.Columns[1].DataPropertyName = "CODIGOUSUARIO";

                Grid.Columns[2].Width = 80;
                Grid.Columns[2].Visible = true;
                Grid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid.Columns[2].HeaderText = "USUARIO";
                Grid.Columns[2].DataPropertyName = "USUARIO";

                Grid.Columns[3].Width = 0;
                Grid.Columns[3].Visible = false;
                Grid.Columns[3].DataPropertyName = "CODIGOAREA";

                Grid.Columns[4].Width = 80;
                Grid.Columns[4].Visible = true;
                Grid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid.Columns[4].HeaderText = "AREA";
                Grid.Columns[4].DataPropertyName = "AREA";

                Grid.Columns[5].Width = 0;
                Grid.Columns[5].Visible = false;
                Grid.Columns[5].DataPropertyName = "CODIGOGERENCIA";

                Grid.Columns[6].Width = 100;
                Grid.Columns[6].Visible = true;
                Grid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid.Columns[6].HeaderText = "GERENCIA";
                Grid.Columns[6].DataPropertyName = "GERENCIA";

                Grid.Columns[7].Width = 90;
                Grid.Columns[7].Visible = true;
                Grid.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns[7].HeaderText = "TIPO PEDIDO";
                Grid.Columns[7].DataPropertyName = "TIPO_PEDIDO";

                Grid.Columns[8].Width = 0;
                Grid.Columns[8].Visible = false;
                Grid.Columns[8].DataPropertyName = "CODIGOCC";

                Grid.Columns[9].Width = 0;
                Grid.Columns[9].Visible = false;
                Grid.Columns[9].DataPropertyName = "CENTROCOSTO";

                Grid.Columns[10].Width = 0;
                Grid.Columns[10].Visible = false;
                Grid.Columns[10].DataPropertyName = "CODIGOPP";

                Grid.Columns[11].Width = 0;
                Grid.Columns[11].Visible = false;
                Grid.Columns[11].DataPropertyName = "PARTIDAPRESUPUESTO";
            }

            if (Tipo == 1)
            {
                if (Grid.Columns.Count == 0)
                {
                    Grid.Columns.Add("COTIZACION", "");
                    Grid.Columns.Add("PEDIDO", "");
                    Grid.Columns.Add("CODIGOPROVEEDOR", "");
                    Grid.Columns.Add("PROVEEDOR", "");
                    Grid.Columns.Add("IMPORTE", "");
                    Grid.Columns.Add("FECHAENTREGA", "");
                    Grid.Columns.Add("ADJUNTO", "");
                }

                Grid.Columns[0].Width = 60;
                Grid.Columns[0].Visible = true;
                Grid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns[0].HeaderText = "Nº COT";
                Grid.Columns[0].DataPropertyName = "COTIZACION";

                Grid.Columns[1].Width = 60;
                Grid.Columns[1].Visible = true;
                Grid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns[1].HeaderText = "Nº OP";
                Grid.Columns[1].DataPropertyName = "PEDIDO";

                Grid.Columns[2].Width = 0;
                Grid.Columns[2].Visible = false;
                Grid.Columns[2].DataPropertyName = "CODIGOPROVEEDOR";

                Grid.Columns[3].Width = 280;
                Grid.Columns[3].Visible = true;
                Grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                Grid.Columns[3].HeaderText = "PROVEEDOR";
                Grid.Columns[3].DataPropertyName = "PROVEEDOR";

                Grid.Columns[4].Width = 65;
                Grid.Columns[4].Visible = true;
                Grid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid.Columns[4].HeaderText = "IMPORTE";
                Grid.Columns[4].DataPropertyName = "IMPORTE";

                Grid.Columns[5].Width = 80;
                Grid.Columns[5].Visible = true;
                Grid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                Grid.Columns[5].HeaderText = "FECHA ENTREGA";
                Grid.Columns[5].DataPropertyName = "FECHAENTREGA";

                Grid.Columns[6].Width = 0;
                Grid.Columns[6].Visible = false;
                Grid.Columns[6].DataPropertyName = "ADJUNTO";
            }
        }
    }
}