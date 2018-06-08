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
    public partial class frmCargaDatosProveedor : Form
    {
        public frmCargaDatosProveedor()
        {
            InitializeComponent();
        }
        public List<string> Proveedores = new List<string>();
        public string banco;
        public string cuenta;
        public Boolean Boletas = false;
        public DialogResult Resultado = DialogResult.Cancel;
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCargaDatosProveedor_Load(object sender, EventArgs e)
        {
            string cadenas = ""; string consulta = "";
            foreach (string dato in Proveedores)
            {
                cadenas += dato + "\n";
            }
            //if (Proveedores.Count >= 1)
            consulta = string.Join(",", Proveedores);
            cuenta = txtcuenta.Text = HPResergerFunciones.Utilitarios.ExtraerCuenta(cuenta);
           // msg(cadenas + "\nConsulta=" + consulta + "\nBanco=" + banco);
            Dtguias.DataSource = CapaLogica.BuscarCuentasBancoPagar(banco, consulta);
        }
        public DialogResult msg(string cadena)
        {
            return MessageBox.Show(cadena, CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
        public DataTable TablaProvedoresBancos;
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (Dtguias.RowCount > 0)
            {
                Resultado = DialogResult.OK;
                foreach (DataGridViewRow caja in Dtguias.Rows)
                {
                    if (string.IsNullOrWhiteSpace(caja.Cells["cuentaseleccionada"].Value.ToString()))
                    {
                        msg($"El Proveedor {caja.Cells["RAZONSOCIAL"].Value}, No se le ha Registrado El Nro. de Cuenta");
                        Resultado = DialogResult.Cancel;
                        return;
                    }
                }
            }
            else
            {
                msg("No hay Filas para Avanzar");
            }
            TablaProvedoresBancos = (DataTable)Dtguias.DataSource;
        }
    }
}
