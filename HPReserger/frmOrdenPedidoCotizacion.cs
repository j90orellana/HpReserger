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
    public partial class frmOrdenPedidoCotizacion : Form
    {
        HPResergerCapaLogica.HPResergerCL clPedidoCotizacion = new HPResergerCapaLogica.HPResergerCL();
        public int Numero { get; set; }
        public string Tipo { get; set; }

        public frmOrdenPedidoCotizacion()
        {
            InitializeComponent();
        }

        private void frmOrdenPedidoCotizacion_Load(object sender, EventArgs e)
        {
            DataRow drCotizacionPedido = clPedidoCotizacion.CotizacionPedidoCabecera(Numero);
            txtPedido.Text = drCotizacionPedido["OP"].ToString();
            txtFecha.Text = drCotizacionPedido["FECHA"].ToString();
            txtUsuario.Text = drCotizacionPedido["USUARIO"].ToString();
            txtArea.Text = drCotizacionPedido["AREA"].ToString();
            txtGerencia.Text = drCotizacionPedido["GERENCIA"].ToString();

            gridCotizacionPedido.DataSource = clPedidoCotizacion.CotizacionPedidoDetalle(Numero);
            if (Tipo == "A")
            {

                gridCotizacionPedido.Columns[0].Width = 0;
                gridCotizacionPedido.Columns[0].Visible = false;

                gridCotizacionPedido.Columns[1].Width = 198;
                gridCotizacionPedido.Columns[1].Visible = true;
                gridCotizacionPedido.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                gridCotizacionPedido.Columns[2].Width = 0;
                gridCotizacionPedido.Columns[2].Visible = false;

                gridCotizacionPedido.Columns[3].Width = 198;
                gridCotizacionPedido.Columns[3].Visible = true;
                gridCotizacionPedido.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                gridCotizacionPedido.Columns[4].Width = 0;
                gridCotizacionPedido.Columns[4].Visible = false;

                gridCotizacionPedido.Columns[5].Width = 198;
                gridCotizacionPedido.Columns[5].Visible = true;
                gridCotizacionPedido.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                gridCotizacionPedido.Columns[6].Width = 80;
                gridCotizacionPedido.Columns[6].Visible = true;
                gridCotizacionPedido.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                gridCotizacionPedido.Columns[6].HeaderText = "CANTIDAD";
            }
            else
            {
                gridCotizacionPedido.Columns[0].Width = 0;
                gridCotizacionPedido.Columns[0].Visible = false;

                gridCotizacionPedido.Columns[1].Width = 340;
                gridCotizacionPedido.Columns[1].Visible = true;
                gridCotizacionPedido.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                gridCotizacionPedido.Columns[2].Width = 0;
                gridCotizacionPedido.Columns[2].Visible = false;

                gridCotizacionPedido.Columns[3].Width = 0;
                gridCotizacionPedido.Columns[3].Visible = false;

                gridCotizacionPedido.Columns[4].Width = 0;
                gridCotizacionPedido.Columns[4].Visible = false;

                gridCotizacionPedido.Columns[5].Width = 0;
                gridCotizacionPedido.Columns[5].Visible = false;

                gridCotizacionPedido.Columns[6].Width = 340;
                gridCotizacionPedido.Columns[6].Visible = true;
                gridCotizacionPedido.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                gridCotizacionPedido.Columns[6].HeaderText = "OBSERVACIONES";
            }


        }
    }
}
