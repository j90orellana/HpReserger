using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger.ModuloRRHH
{
    public partial class frmBonosEmpleados : FormGradient
    {
        public frmBonosEmpleados()
        {
            InitializeComponent();
        }
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        MemoryStream _memoryStream = new MemoryStream();
        private bool Cargado = false;
        private int Estado = 0;
        public byte[] FotoSustento { get; set; }
        private void btnfirma_Click(object sender, EventArgs e)
        {
            var dialogoAbrirFirmaDigital = new OpenFileDialog();
            dialogoAbrirFirmaDigital.Filter = "Archivos de Imagenes|*.jpg;*.png";
            //dialogoAbrirFirmaDigital.DefaultExt = ".jpg";
            if (dialogoAbrirFirmaDigital.ShowDialog(this) == DialogResult.OK)
            {
                txtImagen.Text = dialogoAbrirFirmaDigital.FileName.ToString();
                if (txtImagen.Text != string.Empty)
                {
                    _memoryStream.Position = 0;
                    _memoryStream.SetLength(0);
                    _memoryStream.Capacity = 0;

                    pboFoto.Image = Image.FromFile(txtImagen.Text);
                    pboFoto.Image.Save(_memoryStream, ImageFormat.Jpeg);
                    FotoSustento = File.ReadAllBytes(dialogoAbrirFirmaDigital.FileName);
                    txtImagen.Text = txtImagen.Text; lblVerImagen.Enabled = true;
                }
            }
        }
        DataTable TDatosEmpleado;
        private int pkid;

        public void CargarEmpleado()
        {
            TDatosEmpleado = CapaLogica.BuscarEmpleadoActivo();
            string cadena = ""; bool prueba = false;
            if (cboempleado.DataSource != null) { cadena = cboempleado.Text; prueba = true; }
            if (cboempleado.Items.Count != TDatosEmpleado.Rows.Count)
            {
                cboempleado.DisplayMember = "empleado";
                cboempleado.ValueMember = "tipo";
                cboempleado.DataSource = TDatosEmpleado;
                if (prueba) cboempleado.Text = cadena;
            }
        }
        private void frmBonosEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleado();
            CargarTextoDefecto();
            ModoEdicion(false);
            Cargado = true;
            FiltrarDatos();
        }
        public void FiltrarDatos()
        {
            if (Cargado)
            {
                //filtramos
                string empleado = txtbusEmpleado.TextValido();
                DateTime fechaini = cbofechaini.GetFechaPRimerDia();
                DateTime fechafin = cbofechafin.GetFechaPRimerDia();
                decimal importemin = decimal.Parse(txtbusImporteDE.TextValidoNumeros());
                decimal importemax = decimal.Parse(txtbusImporteA.TextValidoNumeros());
                //Auxiliares
                DateTime FechaAux; decimal ImporteAux;
                if (fechaini > fechafin)
                {
                    FechaAux = fechaini;
                    fechaini = fechafin;
                    fechafin = FechaAux;
                }
                if (importemin > importemax)
                {
                    ImporteAux = importemin;
                    importemin = importemax;
                    importemax = ImporteAux;
                }
                //
                TDatosEmpleado = CapaLogica.ComisionesEmpleadosBusqueda(empleado, fechaini, fechafin, importemin, importemax);
                dtgconten.DataSource = TDatosEmpleado;
                lblRegistros.Text = $"Total de Registros: {TDatosEmpleado.Rows.Count}";
            }
        }
        public void CargarTextoDefecto()
        {
            txtbusEmpleado.CargarTextoporDefecto();
            txtbusImporteA.CargarTextoporDefecto();
            txtbusImporteDE.CargarTextoporDefecto();
            cbofechaini.Fecha(new DateTime(DateTime.Now.Year, 1, 1));
            cbofechafin.Fecha(new DateTime(DateTime.Now.Year, 12, 31));
        }
        public void ModoEdicion(Boolean v)
        {
            //opciones de Ingreso
            cboempleado.ReadOnly = !v;
            lblBuscarEmpleado.Enabled = v;
            cboFecha.Enabled = v;
            txtImporte.ReadOnly = !v;
            btnCargarImagen.Enabled = v;
            //Opciones de Filtrado
            txtbusEmpleado.ReadOnly = v;
            txtbusImporteA.ReadOnly = v;
            txtbusImporteDE.ReadOnly = v;
            cbofechaini.Enabled = !v;
            cbofechafin.Enabled = !v;
            btnlimpiar.Enabled = !v;
            btnActualizar.Enabled = !v;
            //Mostrar Datos
            dtgconten.Enabled = !v;
            //Botones        
            btnNuevo.Enabled = !v;
        }
        private void txtbusImporteA_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }
        private void txtbusImporteDE_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }
        private void txtbusEmpleado_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }

        private void cbofechaini_CambioFechas(object sender, EventArgs e)
        {
            FiltrarDatos();
        }
        private void cbofechafin_CambioFechas(object sender, EventArgs e)
        {
            FiltrarDatos();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Estado = 1;
            Cargado = false;
            ModoEdicion(true);
            btnAceptar.Enabled = true;
            FotoSustento = null;
            pboFoto.Image = null;
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (Estado == 0)
            {
                this.Close();
            }
            else if (Estado == 1)
            {
                Estado = 0;
                ModoEdicion(false);
                Cargado = true;
                //Sacamos los Datos!

            }
            btnAceptar.Enabled = false;
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Cargado = false;
            CargarTextoDefecto();
            Cargado = true;
            FiltrarDatos();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FiltrarDatos();
        }
        private void cboempleado_Click(object sender, EventArgs e)
        {
            CargarEmpleado();
        }
        private void lblBuscarEmpleado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmListarEmpleados frmLE = new frmListarEmpleados();
            if (frmLE.ShowDialog() == DialogResult.OK)
            {
                //CargarDatosEmpleado(frmLE.TipoDocumento, frmLE.NumeroDocumento);
                //NewEmpleado = frmLE.UpdateEmpleado;
                cboempleado.SelectedValue = frmLE.TipoDocumento + "/" + frmLE.NumeroDocumento;
                //CodigoTipoDocumento = frmLE.TipoDocumento;
                //txtNumeroDocumento.Text = NumeroDocumento = frmLE.NumeroDocumento;
            }
        }
        public void MostrarFoto(PictureBox fotito, string nombre)
        {
            if (fotito.Image != null)
            {
                FrmFoto foto = new FrmFoto(nombre);
                foto.fotito = fotito.Image;
                foto.Owner = this.MdiParent;
                foto.Nombre = nombre;
                foto.Show();
            }
        }
        private void lblVerImagen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string CADENA = HpResergerUserControls.Configuraciones.MayusculaCadaPalabra(cboempleado.Text);
            MostrarFoto(pboFoto, $"Sustento del Bono de: {CADENA} ");
        }
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }
        public void msgE(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgE(string cadena, string Detalle) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena, Detalle); }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Estado == 1)
            {
                //Proceso de validaciones
                if (cboempleado.SelectedValue == null) { cboempleado.Focus(); msgE("Seleccione un Empleado"); return; }
                if (decimal.Parse(txtImporte.Text) <= 0) { txtImporte.Focus(); msgE("Ingrese un Importe Mayor a Cero"); return; }
                if (FotoSustento == null) { msgE("Se Necesita que Carge la Imagen Sustento"); return; }
                //fin Proceso Validaciones
                string[] Empleado = cboempleado.SelectedValue.ToString().Split('/');
                CapaLogica.ComisionesEmpleados(1, 0, int.Parse(Empleado[0]), Empleado[1], cboFecha.FechaInicioMes, decimal.Parse(txtImporte.Text), FotoSustento);
                msg("Agregada Comisión con Exito");
                Estado = 0;
                ModoEdicion(false);
                btnAceptar.Enabled = false;
                Cargado = true;
                FiltrarDatos();
            }
        }
        private void dtgconten_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int x = e.RowIndex, y = e.ColumnIndex;
                if (Cargado)
                {
                    //Botones para cuando se encuentren datos
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    //Muestra de los datos en el formulario
                    pkid = (int)dtgconten[xpkid.Name, x].Value;
                    cboempleado.SelectedValue = dtgconten[xtipodoc.Name, x].Value.ToString() + "/" + dtgconten[xnrodoc.Name, x].Value.ToString();
                    txtImporte.Text = (decimal.Parse(dtgconten[ximpornte.Name, x].Value.ToString()).ToString("n2"));
                    cboFecha.Fecha((DateTime)dtgconten[xperiodo.Name, x].Value);
                    FotoSustento = (byte[])dtgconten[ximagen.Name, x].Value;
                    MemoryStream ms = new MemoryStream(FotoSustento);
                    pboFoto.Image = Bitmap.FromStream(ms);
                    lblVerImagen.Enabled = true;
                }
            }
            else
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                lblVerImagen.Enabled = false;
                FotoSustento = null;
                pboFoto.Image = null;
            }
        }
    }
}
