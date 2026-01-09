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

namespace SISGEM.Configuracion
{
    public partial class frmConfiguracionEmpresa : DevExpress.XtraEditors.XtraForm
    {
        public frmConfiguracionEmpresa()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.Configuracion.ConfiguracionEmpresa cclase = new HPResergerCapaLogica.Configuracion.ConfiguracionEmpresa();

        private void frmConfiguracionEmpresa_Load(object sender, EventArgs e)
        {
            HPResergerCapaLogica.Contable.ClaseContable ccuentas = new HPResergerCapaLogica.Contable.ClaseContable();
            DataTable TCuentas = ccuentas.GetAllCuentasValidasDetalleRango(0, "90", "99");
            cboCuentaComision.Properties.DataSource = TCuentas;
            cboCuentaComision.Properties.DisplayMember = "cuentacontable";
            cboCuentaComision.Properties.ValueMember = "id";
            searchLookUpEdit1View.Columns[0].BestFit();
            //CONFIGURACIONES

            cclase.VerificarCrearTabla();

            DataTable tconfig = cclase.GetAll();
            var configuraciones = tconfig.AsEnumerable();

            var detalleConfig = ObtenerConfiguracion(tconfig, 1);
            chkDetallePagoBancos.Checked = detalleConfig.Item1 != 0;

            var comisionConfig = ObtenerConfiguracion(tconfig, 2);
            cboCuentaComision.EditValue = comisionConfig.Item2;

            var trabajarConPartidasConfiguracion = ObtenerConfiguracion(tconfig, 3);
            chkfacturasConPartida.EditValue = trabajarConPartidasConfiguracion.Item1 != 0;
        }
        public Tuple<int, string> ObtenerConfiguracion(DataTable configTable, int tipo, int valorDefecto = 0, string textoDefecto = "")
        {
            var config = configTable.AsEnumerable()
                          .FirstOrDefault(row => row.Field<int>("Tipo") == tipo);

            return Tuple.Create(
                config != null ? config.Field<int>("Valor") : valorDefecto,
                config != null ? config.Field<string>("Dato") : textoDefecto
            );
        }
        private void ActualizarConfiguracion(int tipo, string descripcion, string texto, int valor)
        {
            cclase.InsertOrUpdate(new HPResergerCapaLogica.Configuracion.ConfiguracionEmpresa
            {
                Id = tipo, // Asumiendo que Id y Tipo coinciden en tu lógica
                Tipo = tipo,
                Descripcion = descripcion,
                Texto = texto,
                Valor = valor
            });
        }

        // Uso en los eventos
        private void chkDetallePagoBancos_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarConfiguracion(
                tipo: 1,
                descripcion: "Mostrar detalle de comprobantes de pago en los pagos de cuenta bancaria",
                texto: "",
                valor: chkDetallePagoBancos.Checked ? 1 : 0
            );
        }

        private void cboCuentaComision_EditValueChanged(object sender, EventArgs e)
        {
            ActualizarConfiguracion(
                tipo: 2,
                descripcion: "Código de cuenta contable para registrar comisiones bancarias",
                texto: cboCuentaComision.EditValue?.ToString(),
                valor: 0
            );
        }

        private void chkfacturasConPartida_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarConfiguracion(
               tipo: 3,
               descripcion: "Trabajar Facturas con Partidas Presupuestarias",
               texto: "",
               valor: chkfacturasConPartida.Checked ? 1 : 0
           );
        }
    }
}