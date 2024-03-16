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

namespace HPReserger
{
    public partial class frmbonos : FormGradient
    {
        public frmbonos()
        {
            InitializeComponent();
        }
        public string numerodo { get; set; }
        public int CodigoEmpleado { get; set; }
        public int Contrato { get; set; }
        public int tipodoc { get; set; }
        public DateTime fechainicio;
        public DateTime fechafin;
        DataTable comisiones;
        DataTable destaques;
        DataTable produccion;
        HPResergerCapaLogica.HPResergerCL CapaLogica = new HPResergerCapaLogica.HPResergerCL();
        public void Comisiones()
        {
            //Comisiones
            comisiones = new DataTable();
            comisiones.Columns.Add("Codigo");
            comisiones.Columns.Add("Valor");
            comisiones.Rows.Add(new object[] { "0", "No" });
            comisiones.Rows.Add(new object[] { "1", "Sueldo" });
            comisiones.Rows.Add(new object[] { "2", "Sueldo Básico" });
            comisiones.Rows.Add(new object[] { "3", "Ventas" });
            cbocomision.DisplayMember = "Valor";
            cbocomision.ValueMember = "Codigo";
            cbocomision.DataSource = comisiones;
            //Destaques
            destaques = new DataTable();
            destaques.Columns.Add("Codigo");
            destaques.Columns.Add("Valor");
            destaques.Rows.Add(new object[] { "0", "No" });
            destaques.Rows.Add(new object[] { "1", "Sueldo" });
            destaques.Rows.Add(new object[] { "2", "Monto Fijo" });
            cbodestaque.DisplayMember = "Valor";
            cbodestaque.ValueMember = "Codigo";
            cbodestaque.DataSource = destaques;
            //produccion
            destaques = new DataTable();
            destaques.Columns.Add("Codigo");
            destaques.Columns.Add("Valor");
            destaques.Rows.Add(new object[] { "0", "No" });
            destaques.Rows.Add(new object[] { "1", "Sueldo" });
            destaques.Rows.Add(new object[] { "2", "Monto Fijo" });
            cboproduccion.DisplayMember = "Valor";
            cboproduccion.ValueMember = "Codigo";
            cboproduccion.DataSource = destaques;
            //regular
            produccion = new DataTable();
            produccion.Columns.Add("Codigo");
            produccion.Columns.Add("Valor");
            produccion.Rows.Add(new object[] { "0", "No" });
            produccion.Rows.Add(new object[] { "1", "Si" });
            cboregular.DisplayMember = "Valor";
            cboregular.ValueMember = "Codigo";
            cboregular.DataSource = produccion;
            //movilidad
            produccion = new DataTable();
            produccion.Columns.Add("Codigo");
            produccion.Columns.Add("Valor");
            produccion.Rows.Add(new object[] { "0", "No" });
            produccion.Rows.Add(new object[] { "1", "Si" });
            cbomovilidad.DisplayMember = "Valor";
            cbomovilidad.ValueMember = "Codigo";
            cbomovilidad.DataSource = produccion;
        }
        int mes, años;
        public void Calcularmeses()
        {
            DateTime fechaux;
            if (fechafin < fechainicio)
            {
                fechaux = fechainicio;
                fechainicio = fechafin;
                fechafin = fechaux;
            }
            años = fechafin.Year - fechainicio.Year;
            mes = fechafin.Month + años * 12 - fechainicio.Month + 1;
        }
        public void Meses()
        {
            meses = new DataTable();
            meses.Columns.Add("codigo", typeof(int));
            meses.Columns.Add("valor", typeof(string));
            meses.Rows.Add(new object[] { 1, "Ene" });
            meses.Rows.Add(new object[] { 2, "Feb" });
            meses.Rows.Add(new object[] { 3, "Mar" });
            meses.Rows.Add(new object[] { 4, "Abr" });
            meses.Rows.Add(new object[] { 5, "May" });
            meses.Rows.Add(new object[] { 6, "Jun" });
            meses.Rows.Add(new object[] { 7, "Jul" });
            meses.Rows.Add(new object[] { 8, "Ago" });
            meses.Rows.Add(new object[] { 9, "Sep" });
            meses.Rows.Add(new object[] { 10, "Oct" });
            meses.Rows.Add(new object[] { 11, "Nov" });
            meses.Rows.Add(new object[] { 12, "Dic" });
        }
        public string Getmes(int mes)
        {
            string caden = "";
            foreach (DataRow x in meses.Rows)
            {
                if ((int)x["codigo"] == mes)
                    caden = x["valor"].ToString();
            }
            return caden;
        }
        DataTable Comision = new DataTable();
        DataRow Tcomision;
        private void frmbonos_Load(object sender, EventArgs e)
        {
            lklProduccion.Parent = this;
            lklProduccion.Top += groupBox3.Top;
            lklProduccion.Left += groupBox3.Left;
            lklProduccion.BringToFront();
            Comisiones();
            Calcularmeses();
            Meses();
            ColumnasGrillasMeses();
            Comision = CapaLogica.ListarComisionesEmpleado(CodigoEmpleado, Contrato);
            if (Comision.Rows.Count == 1)
            {
                Tcomision = Comision.Rows[0];
                cbocomision.SelectedValue = Tcomision["Comisiones"].ToString();
                numcomision.Value = decimal.Parse(Tcomision["Porcentaje_Comis"].ToString());
                //Periodo_Comis
                CheckMes(Tcomision["Periodo_Comis"].ToString(), dtgcomision);
                cbodestaque.SelectedValue = Tcomision["Bonif_Destaque"].ToString();
                txtdestaque.Num.Text = Tcomision["Valor_Dest"].ToString();
                numdestaque.Value = decimal.Parse(Tcomision["Porcentaje_Dest"].ToString());
                //Periodo_Dest
                CheckMes(Tcomision["Periodo_Dest"].ToString(), dtgdestaque);
                cboproduccion.SelectedValue = Tcomision["Bonif_Produccion"].ToString();
                txtproduccion.Num.Text = Tcomision["Importe_Prod"].ToString();
                numproduccion.Value = decimal.Parse(Tcomision["Porcentaje_Prod"].ToString());
                //Periodo_Prod
                CheckMes(Tcomision["Periodo_Prod"].ToString(), dtgproduccion);
                if (Tcomision["Imagen_Prod"].ToString().Length > 0)
                    lklProduccion.Enabled = true;
                else
                    lklProduccion.Enabled = false;
                //Nombre_Imagen_Prod
                if (Tcomision["Imagen_Prod"].ToString().Length > 0)
                {
                    byte[] Fotito = new byte[0];
                    FotoProduccion = Fotito = (byte[])Tcomision["Imagen_Prod"];
                    MemoryStream ms = new MemoryStream(Fotito);
                    pbfotoproduccion.Image = Bitmap.FromStream(ms);
                    lklProduccion.Enabled = true;
                    //NombreFoto = DatosE["nombrefotoempleado"].ToString();
                }
                else
                {
                    pbfotoproduccion.Image = null;
                    lklProduccion.Enabled = false;
                    FotoProduccion = null;
                }
                //Bonif_Regular  //Importe_Reg
                cboregular.SelectedValue = Tcomision["Bonif_Regular"].ToString();
                txtregular.Num.Text = Tcomision["Importe_Reg"].ToString();
                cbomovilidad.SelectedValue = Tcomision["Bonif_Movilidad"].ToString();
                txtmovilidad.Num.Text = Tcomision["Importe_Mov"].ToString();
                //Periodo_Mov
                CheckMes(Tcomision["Periodo_Mov"].ToString(), dtgmovilidad);
                //Usuario
                //Fecha
            }
        }
        public void MostrarFoto(PictureBox fotito,string namex)
        {
            if (fotito.Image != null)
            {
                FrmFoto foto = new FrmFoto(namex);
                foto.fotito = fotito.Image;
                foto.Owner = this.MdiParent;
                foto.ShowDialog();
            }
        }
        public void CheckMes(string cadena, DataGridView grilla)
        {
            string[] cadeaux = cadena.Split('|');
            foreach (string xx in cadeaux)
            {
                if (!string.IsNullOrWhiteSpace(xx))
                    grilla[grilla.Columns[xx].Index, 0].Value = true;
            }
        }
        //public DialogResult msg(string cadena)
        //{
        //    return MessageBox.Showa(cadena, CompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //}
        private void cbodestaque_SelectedIndexChanged(object sender, EventArgs e)
        {
            //montofijo
            if (cbodestaque.SelectedValue.ToString() == "2")
            {
                txtdestaque.Visible = true;
                dtgdestaque.Visible = true;
            }
            else { txtdestaque.Visible = false; dtgdestaque.Visible = false; numdestaque.Visible = false; lbldestaque.Visible = false; }
            //sueldo
            if (cbodestaque.SelectedValue.ToString() == "1")
            {
                dtgdestaque.Visible = true; numdestaque.Visible = true; lbldestaque.Visible = true; txtdestaque.Visible = false;
            }
        }

        private void cboproduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboproduccion.SelectedValue.ToString() == "1")
            {
                dtgproduccion.Visible = true;
                numproduccion.Visible = true;
                lbl.Visible = true;
                lklProduccion.Visible = true;
                btnimagenproduccion.Visible = true;
                txtproduccion.Visible = false;
            }
            else
            {
                txtproduccion.Visible = false; dtgproduccion.Visible = false; numproduccion.Visible = false; lbl.Visible = false;
                lklProduccion.Visible = false; btnimagenproduccion.Visible = false;
            }
            if (cboproduccion.SelectedValue.ToString() == "2")
            {
                txtproduccion.Visible = true;
                dtgproduccion.Visible = true;
                numproduccion.Visible = false;
                lbl.Visible = false;
                lklProduccion.Visible = true;
                btnimagenproduccion.Visible = true;
            }
        }
        private void cbomovilidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbomovilidad.SelectedValue.ToString() == "1")
            {
                txtmovilidad.Visible = true;
                dtgmovilidad.Visible = true;
            }
            else { txtmovilidad.Visible = false; dtgmovilidad.Visible = false; }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            iniciar(false);
            if (estado != 0)
                estado = 0;
            else
                this.Close();
        }
        DataTable meses;
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //proceso para guardar
            int col = dtgcomision.Columns.Count;
            int con = 0;
            dtgcomision.EndEdit(); dtgdestaque.EndEdit(); dtgmovilidad.EndEdit(); dtgproduccion.EndEdit();
            if (col > 0)
            {
                //COMISIÓN
                if (cbocomision.Text.Trim().ToUpper() != "NO")
                {
                    if (numcomision.Value == 0)
                    {
                        numcomision.Focus();
                        HPResergerFunciones.frmInformativo.MostrarDialogError("Ingresé un Porcentaje mayor a cero en la Comisión");
                        return;
                    }
                    con = 0;
                    for (int i = 0; i < col; i++)
                    {
                        if (dtgcomision[i, 0].Value != null)
                            if (dtgcomision[i, 0].Value.ToString().ToUpper() == "TRUE")
                                con++;
                    }
                    if (con == 0)
                    {
                        HPResergerFunciones.frmInformativo.MostrarDialogError("Seleccioné un mes minimo en la Grilla de Comisión");
                        return;
                    }
                }
                //DESTAQUE
                if (cbodestaque.Text.Trim().ToUpper() != "NO")
                {
                    if (cbodestaque.Text.Trim().ToUpper() == "MONTO FIJO")
                        if (decimal.Parse(txtdestaque.Num.Text) == 0)
                        {
                            txtdestaque.Num.Focus();
                            HPResergerFunciones.frmInformativo.MostrarDialogError("Ingresé un Monto mayor a cero en destaque");
                            return;
                        }
                    if (cbodestaque.Text.Trim().ToUpper() == "SUELDO")
                        if (numdestaque.Value == 0)
                        {
                            numdestaque.Focus();
                            HPResergerFunciones.frmInformativo.MostrarDialogError("Ingresé un Porcentaje mayor a cero en la Destaque");
                            return;
                        }
                    con = 0;
                    for (int i = 0; i < col; i++)
                    {
                        if (dtgdestaque[i, 0].Value != null)
                            if (dtgdestaque[i, 0].Value.ToString().ToUpper() == "TRUE")
                                con++;
                    }
                    if (con == 0)
                    {
                        HPResergerFunciones.frmInformativo.MostrarDialogError("Seleccioné un mes minimo en la Grilla de Destaque");
                        return;
                    }
                }
                //PRODUCCIÓN
                if (cboproduccion.Text.Trim().ToUpper() != "NO")
                {
                    if (cboproduccion.Text.Trim().ToUpper() == "SUELDO")
                        if (numproduccion.Value == 0)
                        {
                            numproduccion.Focus();
                            HPResergerFunciones.frmInformativo.MostrarDialogError("Ingresé un Porcentaje mayor a cero de producción");
                            return;
                        }
                    if (cboproduccion.Text.Trim().ToUpper() == "MONTO FIJO")
                        if (decimal.Parse(txtproduccion.Num.Text) == 0)
                        {
                            txtproduccion.Num.Focus();
                            HPResergerFunciones.frmInformativo.MostrarDialogError("Ingresé un Monto mayor a cero de producción");
                            return;
                        }
                    con = 0;
                    for (int i = 0; i < col; i++)
                    {
                        if (dtgproduccion[i, 0].Value != null)
                            if (dtgproduccion[i, 0].Value.ToString().ToUpper() == "TRUE")
                                con++;
                    }
                    if (con == 0)
                    {
                        HPResergerFunciones.frmInformativo.MostrarDialogError("Seleccioné un mes minimo en la Grilla de Producción");
                        return;
                    }
                }
                //MOVILIDAD
                if (cbomovilidad.Text.Trim().ToUpper() != "NO")
                {
                    if (decimal.Parse(txtmovilidad.Num.Text) == 0)
                    {
                        txtmovilidad.Num.Focus();
                        HPResergerFunciones.frmInformativo.MostrarDialogError("Ingresé un Monto mayor a cero de Movilidad");
                        return;
                    }
                    con = 0;
                    for (int i = 0; i < col; i++)
                    {
                        if (dtgmovilidad[i, 0].Value != null)
                            if (dtgmovilidad[i, 0].Value.ToString().ToUpper() == "TRUE")
                                con++;
                    }
                    if (con == 0)
                    {
                        HPResergerFunciones.frmInformativo.MostrarDialogError("Seleccioné un mes minimo en la Grilla de Movilidad");
                        return;
                    }
                }
                if (cboregular.Text.Trim().ToUpper() != "NO")
                    if (decimal.Parse(txtregular.Num.Text) == 0)
                    {
                        HPResergerFunciones.frmInformativo.MostrarDialogError("Ingresé un Monto mayor a cero de Bono Regular");
                        txtregular.Num.Focus();
                        return;
                    }
            }
            else
            {
                HPResergerFunciones.frmInformativo.MostrarDialogError("Debe Seleccionar en el periodo del contrato un mes minimo");
                return;
            }
            //eliminar los datos
            CapaLogica.EmpleadoComision(10, CodigoEmpleado, Contrato, 0, 0, "", 0, 0, "", 0, 0, 0, "", null, "", 0, 0, 0, 0, "", 0, 0);
            CapaLogica.EmpleadoComision(1, CodigoEmpleado, Contrato, DelCombo(cbocomision), numcomision.Value, Sacarmeses(dtgcomision), DelCombo(cbodestaque), DelTxt(txtdestaque), Sacarmeses(dtgdestaque),
                DelCombo(cboproduccion), DelTxt(txtproduccion), numproduccion.Value, Sacarmeses(dtgproduccion), FotoProduccion, NombreImagenProduccion, DelCombo(cboregular), decimal.Parse(txtregular.Num.Text),
                DelCombo(cbomovilidad), DelTxt(txtmovilidad), Sacarmeses(dtgmovilidad), frmLogin.CodigoUsuario, numdestaque.Value);
            //insertar los datos
            HPResergerFunciones.frmInformativo.MostrarDialog("Guardado con Exito");
            iniciar(false);
        }
        public int DelCombo(ComboBox combito)
        {
            return int.Parse(combito.SelectedValue.ToString());
        }
        public decimal DelTxt(HpResergerUserControls.NumBox cajita)
        {
            return decimal.Parse(cajita.Num.Text.ToString());
        }
        public string Sacarmeses(DataGridView grilla)
        {
            string cadena = "";
            List<string> cade = new List<string>();
            for (int i = 0; i < grilla.Columns.Count; i++)
            {
                if (grilla[i, 0].Value != null)
                    if (grilla[i, 0].Value.ToString().ToUpper() == "TRUE")
                    {
                        cade.Add(grilla.Columns[i].Name);
                    }
            }
            cadena = string.Join("|", cade.ToArray());
            return cadena;
        }
        private void cbocomision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbocomision.SelectedValue.ToString() != "0")
            {
                numcomision.Visible = true; lblc.Visible = true;
                dtgcomision.Visible = true;
            }
            else { numcomision.Visible = false; dtgcomision.Visible = false; lblc.Visible = false; }
        }
        public void iniciar(Boolean a)
        {
            btnmodificar.Enabled = !a;
            btnaceptar.Enabled = a;
            groupBox1.Enabled = groupBox2.Enabled = groupBox3.Enabled = groupBox4.Enabled = groupBox5.Enabled = a;
        }
        int estado = 0;
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            iniciar(true);
            estado = 1;
        }
        string NombreImagenProduccion = "";
        MemoryStream _memoryStream = new MemoryStream();
        byte[] FotoProduccion;
        private void btnimagenproduccion_Click(object sender, EventArgs e)
        {
            dialogoAbrirArchivoAnexoFunciones.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivoAnexoFunciones.DefaultExt = ".jpg";
            dialogoAbrirArchivoAnexoFunciones.ShowDialog(this);
            lklProduccion.Enabled = false;
            NombreImagenProduccion = dialogoAbrirArchivoAnexoFunciones.FileName.ToString();
            if (NombreImagenProduccion != string.Empty)
            {
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;
                pbfotoproduccion.Image = Image.FromFile(NombreImagenProduccion);
                pbfotoproduccion.Image.Save(_memoryStream, ImageFormat.Jpeg);
                FotoProduccion = File.ReadAllBytes(dialogoAbrirArchivoAnexoFunciones.FileName);
                lklProduccion.Enabled = true;
            }
        }

        private void lklProduccion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostrarFoto(pbfotoproduccion, $"Foto de Producción / Doc={numerodo}");
        }

        private void cboregular_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboregular.Text.ToUpper() == "SI")
                txtregular.Visible = true;
            else txtregular.Visible = false;
        }

        public void ColumnasGrillasMeses()
        {
            DataGridViewCheckBoxColumn col1;
            DataGridViewCheckBoxColumn col2;
            DataGridViewCheckBoxColumn col3;
            DataGridViewCheckBoxColumn col4;
            int con = fechainicio.Month;
            int anhio = fechainicio.Year;
            for (int i = 0; i < mes; i++)
            {
                if (con == 13)
                {
                    con = 1; anhio++;
                }
                col1 = new DataGridViewCheckBoxColumn();
                col1.Name = Getmes(con) + "/" + anhio;
                col1.TrueValue = true;
                col1.FalseValue = false;
                col2 = new DataGridViewCheckBoxColumn();
                col2.Name = Getmes(con) + "/" + anhio;
                col2.TrueValue = true;
                col2.FalseValue = false;
                col3 = new DataGridViewCheckBoxColumn();
                col3.Name = Getmes(con) + "/" + anhio;
                col3.TrueValue = true;
                col3.FalseValue = false;
                col4 = new DataGridViewCheckBoxColumn();
                col4.Name = Getmes(con) + "/" + anhio;
                col4.TrueValue = true;
                col4.FalseValue = false;
                dtgdestaque.Columns.Add(col1);
                dtgmovilidad.Columns.Add(col2);
                dtgproduccion.Columns.Add(col3);
                dtgcomision.Columns.Add(col4);
                con++;
            }
            dtgdestaque.Rows.Add();
            dtgmovilidad.Rows.Add();
            dtgproduccion.Rows.Add();
            dtgcomision.Rows.Add();
        }
    }
}
