using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HpResergerUserControls
{
    public partial class ComboMesAño : UserControl
    {
        public ComboMesAño()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        DataTable meses = null;
        DataTable años = null;
        public void Cargarmeses()
        {
            meses = new DataTable();
            meses.Columns.Add("codigo", typeof(int));
            meses.Columns.Add("valor");
            meses.Rows.Add(new object[] { 1, "Enero" });
            meses.Rows.Add(new object[] { 2, "Febrero" });
            meses.Rows.Add(new object[] { 3, "Marzo" });
            meses.Rows.Add(new object[] { 4, "Abril" });
            meses.Rows.Add(new object[] { 5, "Mayo" });
            meses.Rows.Add(new object[] { 6, "Junio" });
            meses.Rows.Add(new object[] { 7, "Julio" });
            meses.Rows.Add(new object[] { 8, "Agosto" });
            meses.Rows.Add(new object[] { 9, "Septiembre" });
            meses.Rows.Add(new object[] { 10, "Octubre" });
            meses.Rows.Add(new object[] { 11, "Noviembre" });
            meses.Rows.Add(new object[] { 12, "Diciembre" });
            combomes.ValueMember = "codigo";
            combomes.DisplayMember = "valor";
            combomes.DataSource = meses;
        }
        /// <summary>
        /// Actualiza el comboboxMesño
        /// </summary>
        /// <param name="mes">mes en numero</param>
        /// <param name="año">año en numero</param>
        public void ActualizarMesAÑo(string mes, string año)
        {
            combomes.SelectedValue = mes;
            comboaño.SelectedValue = año;
        }
        public void cargarAños()
        {
            años = new DataTable();
            años.Columns.Add("codigo");
            años.Columns.Add("valor", typeof(int));
            int año = DateTime.Now.Year;
            DataRow datito = CapaLogica.getMinMaxContrato();
            int x = DateTime.Now.Year + 1 - DateTime.Parse(datito["minimo"].ToString()).Year;
            for (int i = 0; i < x; i++)
            {
                años.Rows.Add(año - i, año - i);
            }
            comboaño.ValueMember = "valor";
            comboaño.DisplayMember = "codigo";
            comboaño.DataSource = años;
        }
        public void MostrarMeses(params int[] Cantmes)
        {
            int x = meses.Rows.Count;
            for (int i = 0; i < meses.Rows.Count; i++)
            {
                DataRow fila = meses.Rows[i];
                if (!Cantmes.Contains(int.Parse(fila["codigo"].ToString())))
                {
                    meses.Rows.RemoveAt(i);
                    i--;
                }
            }
        }
        private void ComboMesAño_Load(object sender, EventArgs e)
        {
            Cargarmeses();
            cargarAños();
            ActualizarMesAÑo(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());
        }
        public DateTime GetFecha()
        {
            DateTime timeaux;
            try
            {
                timeaux = new DateTime((int)comboaño.SelectedValue, (int)combomes.SelectedValue, DateTime.Now.Day);
            }
            catch (ArgumentOutOfRangeException )
            {
                timeaux = new DateTime((int)comboaño.SelectedValue, (int)combomes.SelectedValue, 1);
                timeaux = timeaux.AddMonths(1).AddDays(-1);
            }
            return timeaux;
        }
        public DateTime GetFechaPRimerDia()
        {
            DateTime timeaux;
            timeaux = new DateTime((int)comboaño.SelectedValue, (int)combomes.SelectedValue, 1);
            return timeaux;
        }
        public string FechaParaSQL()
        {
            return comboaño.SelectedValue.ToString() + int.Parse(combomes.SelectedValue.ToString()).ToString("00") + "01";
        }
        public int getMesNumero()
        {
            return (int)combomes.SelectedValue;
        }
        public int GetAño()
        {
            return (int)comboaño.SelectedValue;
        }
    }
}
