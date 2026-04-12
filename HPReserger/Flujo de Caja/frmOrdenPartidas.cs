using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SISGEM.Flujo_de_Caja
{
    public partial class frmOrdenPartidas : DevExpress.XtraEditors.XtraForm
    {
        public frmOrdenPartidas()
        {
            InitializeComponent();
        }

        private void frmOrdenPartidas_Load(object sender, EventArgs e)
        {

            DataTable Tdata = ObtenerTiposPartida();
            cboPartidas.Properties.DataSource = Tdata;
            cboPartidas.Properties.ValueMember = "Tipo";
            cboPartidas.Properties.DisplayMember = "Descripcion";

            if (Tdata.Rows.Count > 0)
            {
                cboPartidas.EditValue = Tdata.Rows[0][0];

            }
        }


        public DataTable ObtenerTiposPartida()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tipo", typeof(int));
            dt.Columns.Add("Descripcion", typeof(string));

            dt.Rows.Add(1, "Partida de Control - SPV");
            dt.Rows.Add(2, "Partida de Control - Servicio");
            dt.Rows.Add(3, "Partida de Control - Holding");
            dt.Rows.Add(4, "Partida de Control - Constructora");

            return dt;
        }

        private void cboPartidas_EditValueChanged(object sender, EventArgs e)
        {
            BuscarDatosdelaBase((int)cboPartidas.EditValue);
        }

        private void BuscarDatosdelaBase(int TipoPartida)
        {
            HPResergerCapaLogica.FlujoCaja.Partidas_Control Clase = new HPResergerCapaLogica.FlujoCaja.Partidas_Control();

            DataTable tdata = Clase.ListarOrdendelasPArtidas(TipoPartida);

            int maxPosicion = 0;
            bool existeCero = false;

            if (tdata.Rows.Count > 0)
            {

                maxPosicion = tdata.AsEnumerable()
                 .Where(x => x["posicion"] != DBNull.Value && x.Field<int>("posicion") != 0)
                 .Select(x => x.Field<int>("posicion"))
                 .DefaultIfEmpty(0)
                 .Max();


                existeCero = tdata.AsEnumerable()
                       .Any(x => x.Field<int>("posicion") == 0);

            }
            maxPosicion = maxPosicion + 1;

            if (existeCero)
            {
                foreach (DataRow item in tdata.Rows)
                {
                    HPResergerCapaLogica.FlujoCaja.Partidas_Control cclase = new HPResergerCapaLogica.FlujoCaja.Partidas_Control();
                    HPResergerCapaLogica.FlujoCaja.TBL_PartidasOrden obj = new HPResergerCapaLogica.FlujoCaja.TBL_PartidasOrden();

                    if ((int)item[xposicion.FieldName] == 0)
                    {

                        //int posicion = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, xposicion.FieldName));
                        string codigo = item[xcodigo.FieldName].ToString();
                        string partida = item[xpartida.FieldName].ToString();

                        obj.Codigo = codigo;
                        obj.Estado = 1;
                        obj.Partida = partida;
                        obj.Posicion = maxPosicion;
                        obj.Tipo = (int)cboPartidas.EditValue;

                        cclase.InsertarActualizarOrdenPartidas(obj);

                        maxPosicion = maxPosicion + 1;
                    }
                }
                tdata = Clase.ListarOrdendelasPArtidas(TipoPartida);
            }

            gridControl1.DataSource = tdata;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == xposicion.FieldName)
            {
                HPResergerCapaLogica.FlujoCaja.Partidas_Control cclase = new HPResergerCapaLogica.FlujoCaja.Partidas_Control();
                HPResergerCapaLogica.FlujoCaja.TBL_PartidasOrden obj = new HPResergerCapaLogica.FlujoCaja.TBL_PartidasOrden();

                var rowHandle = e.RowHandle;

                int posicion = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, xposicion.FieldName));
                string codigo = gridView1.GetRowCellValue(rowHandle, xcodigo.FieldName).ToString();
                string partida = gridView1.GetRowCellValue(rowHandle, xpartida.FieldName).ToString();

                obj.Codigo = codigo;
                obj.Estado = 1;
                obj.Partida = partida;
                obj.Posicion = posicion;
                obj.Tipo = (int)cboPartidas.EditValue;

                cclase.InsertarActualizarOrdenPartidasCambiadas(obj);
                gridControl1.DataSource = cclase.ListarOrdendelasPArtidas(obj.Tipo);


            }
        }
    }
}