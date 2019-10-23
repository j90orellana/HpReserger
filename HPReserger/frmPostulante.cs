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
using System.Drawing.Imaging;
using HpResergerUserControls;

namespace HPReserger
{
    public partial class frmPostulante : FormGradient
    {
        HPResergerCapaLogica.HPResergerCL clPostulante = new HPResergerCapaLogica.HPResergerCL();
        public void msg(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialogError(cadena); }
        public void msgOK(string cadena) { HPResergerFunciones.frmInformativo.MostrarDialog(cadena); }

        public byte[] Foto { get; set; }
        MemoryStream _memoryStream = new MemoryStream();
        public string nombreArchivo { get; set; }
        public bool PostulanteExiste = false;
        public bool Jode = false;

        public frmPostulante()
        {
            InitializeComponent();
        }

        private void frmPostulante_Load(object sender, EventArgs e)
        {
            //CargarCombos(cboTipoDocumento, "Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");
            CargarTiposID("TBL_Tipo_ID");
            Grid2.DataSource = clPostulante.ListarSEPostulantes(frmLogin.CodigoUsuario);

            if (Grid2.Rows.Count > 0)
            {
                CargarGrid(Convert.ToInt32(Grid2.Rows[0].Cells[0].Value.ToString().Substring(2)));
            }
            Grid2.TabStop = grid3.TabStop = false;
            dtpFechaNacimiento.MaxDate = DateTime.Now;
        }
        DataTable TablaTipoID;
        public void CargarTiposID(string tabla)
        {
            TablaTipoID = new DataTable();
            TablaTipoID = clPostulante.CualquierTabla(tabla, "Desc_Tipo_ID", "RUC");
            cboTipoDocumento.DisplayMember = "Desc_Tipo_ID";
            cboTipoDocumento.ValueMember = "Codigo_Tipo_ID";
            cboTipoDocumento.DataSource = TablaTipoID;
        }
        public void ModificarTamañoTipo(TextBox txt, int index)
        {
            if (index >= 0 && TablaTipoID != null)
            {
                DataRow Filita = TablaTipoID.Rows[index];
                txt.MaxLength = (int)Filita["Length"];
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApellidoPaterno.Focus();
            }
            HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
        }

        private void CargarCombos(ComboBox cbo, string codigo, string descripcion, string tabla)
        {
            cbo.ValueMember = "codigo";
            cbo.DisplayMember = "descripcion";
            cbo.DataSource = clPostulante.getCargoTipoContratacion(codigo, descripcion, tabla);
        }

        private void btnBuscarJPG_Click(object sender, EventArgs e)
        {
            var dialogoAbrirArchivo = new OpenFileDialog();
            dialogoAbrirArchivo.Filter = "Jpg Files|*.jpg";
            dialogoAbrirArchivo.DefaultExt = ".jpg";
            dialogoAbrirArchivo.ShowDialog(this);

            nombreArchivo = dialogoAbrirArchivo.FileName.ToString();
            if (nombreArchivo != string.Empty)
            {
                _memoryStream.Position = 0;
                _memoryStream.SetLength(0);
                _memoryStream.Capacity = 0;

                pbFoto.Image = Image.FromFile(nombreArchivo);
                pbFoto.Image.Save(_memoryStream, ImageFormat.Jpeg);
                Foto = File.ReadAllBytes(dialogoAbrirArchivo.FileName);
                txtAdjuntarCV.Text = nombreArchivo;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtDocumento.Text.Length == 0)
            {
                msg("Ingrese Nº Documento");
                txtDocumento.Focus();
                return;
            }
            if (txtDocumento.Text.Length != txtDocumento.MaxLength && cboTipoDocumento.Text != "CARNE EXTRANJERIA")
            {
                msg("No Coincide el Tamaño con el tipo de Documento");
                txtDocumento.Focus();
                return;
            }
            if (txtApellidoPaterno.Text.Length == 0)
            {
                msg("Ingrese Apellido Paterno");
                txtApellidoPaterno.Focus();
                return;
            }
            if (txtApellidoMaterno.Text.Length == 0)
            {
                msg("Ingrese Apellido Materno");
                txtApellidoMaterno.Focus();
                return;
            }
            if (txtNombres.Text.Length == 0)
            {
                msg("Ingrese Nombres");
                txtNombres.Focus();
                return;
            }
            DataRow Filita = clPostulante.CalcularEdad(dtpFechaNacimiento.Value, DateTime.Now, 1);
            if (Filita != null)
            {
                if ((int)Filita["edad"] < 18)
                {
                    msg("El Postulante Debe ser Mayor de Edad");
                    dtpFechaNacimiento.Focus();
                    return;
                }
            }
            else { return; }

            Filita = clPostulante.ContratoActivo((int)cboTipoDocumento.SelectedValue, txtDocumento.Text, DateTime.Now);
            if (Filita != null)
                if (Filita["Nro_Contrato"] != null)
                {
                    msg("El Empleado Tiene un Contrato Activo");
                    return;
                }

            if (txtAdjuntarCV.Text.Length == 0)
            {
                msg("Seleccione Imagen CV");
                txtAdjuntarCV.Focus();
                return;
            }
            if (Convert.ToInt32(Grid2.CurrentRow.Cells[10].Value.ToString()) == 0)
            {
                msg("Cantidad de Puestos en Cero");
                return;
            }

            DataRow ExisteCV = clPostulante.ExisteImagen("NombreFoto", txtAdjuntarCV.Text, "TBL_Postulante");
            if (ExisteCV != null)
            {
                msg("Imagen de CV ya esta asociado a otro Postulante");
                return;
            }

            // if (PostulanteExiste == true)
            //{
            //msg("Postulante ya registrado en la base de datos", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //return;
            //  }

            int OC = 0;
            if (Grid2.CurrentRow.Cells[2].Value.ToString() != string.Empty)
            {
                OC = Convert.ToInt32(Grid2.CurrentRow.Cells[2].Value.ToString());
            }
            int fila = 0;
            fila = Grid2.CurrentCell.RowIndex;

            clPostulante.PostulanteInsertar(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtDocumento.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtNombres.Text, Convert.ToInt32(Grid2.CurrentRow.Cells[3].Value.ToString()), Foto, txtAdjuntarCV.Text, OC, Convert.ToInt32(Grid2.CurrentRow.Cells[0].Value.ToString().Substring(2)), frmLogin.CodigoUsuario, dtpFechaNacimiento.Value);
            msg("El postulante con DNI Nº " + txtDocumento.Text + " se registró con éxito");

            if (Grid2["Terna", Grid2.CurrentCell.RowIndex].Value.ToString() == "NO")
            {
                clPostulante.AprobarPostulante(Convert.ToInt32(cboTipoDocumento.SelectedValue), txtDocumento.Text, Convert.ToInt32(Grid2["SOLICITUD", Grid2.CurrentCell.RowIndex].Value.ToString().Substring(2)));
                msg("El postulante con DNI Nº " + txtDocumento.Text + " se Aprobó con éxito, No Aplicó Terna");
                Limpiar(); Grid2.DataSource = clPostulante.ListarSEPostulantes(frmLogin.CodigoUsuario);
            }
            else
            {
                Limpiar();
                Grid2.DataSource = clPostulante.ListarSEPostulantes(frmLogin.CodigoUsuario);
                Grid2.CurrentCell = Grid2[0, fila];
                if (Grid2.Rows.Count > 0)
                {
                    CargarGrid(Convert.ToInt32(Grid2.Rows[fila].Cells[0].Value.ToString().Substring(2)));
                }
                else
                {
                    LimpiarGrid();
                    Titulos();
                }
            }
        }

        private void Limpiar()
        {
            txtDocumento.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtNombres.Text = "";
            txtAdjuntarCV.Text = "";
            pbFoto.Image = null;
        }

        private void CargarGrid(int SE)
        {
            grid3.DataSource = clPostulante.ListarPostulanteSE(SE);
            if (grid3.Rows.Count > 0)
            {
                ColorearGrid(grid3);
            }
            else
            {
                LimpiarGrid();
                Titulos();
            }
        }

        private void Grid2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CargarGrid(Convert.ToInt32(Grid2.Rows[e.RowIndex].Cells[0].Value.ToString().Substring(2)));
            txtDocumento.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtNombres.Text = "";
            txtAdjuntarCV.Text = "";

            if (grid3.Rows.Count == 0)
            {
                pbFoto.Image = null;
            }
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtApellidoMaterno.Focus();
            }
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNombres.Focus();
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnBuscarJPG.Focus();
            }
        }
        DataTable tablita;
        private void btnAprobar_Click(object sender, EventArgs e)
        {
            if (Grid2.Rows.Count > 0 && grid3.Rows.Count > 0)
            {
                int fila = 0, filitax = 0;
                fila = Grid2.CurrentCell.RowIndex;
                filitax = grid3.CurrentCell.RowIndex;
                tablita = new DataTable();
                tablita = clPostulante.ListarJefeInmediato(frmLogin.CodigoUsuario, "", 10);
                if (tablita.Rows.Count != 0)
                {
                    DataRow filita = tablita.Rows[0];
                    if (Convert.ToInt32(grid3.CurrentRow.Cells[7].Value.ToString()) == 2)
                    {
                        msg("Postulante ya se encuentra Aprobado");
                        return;
                    }
                    /*if (Convert.ToInt32(grid3.CurrentRow.Cells[7].Value.ToString()) == 10)
                    {
                        msg("Postulante Esperando Aprobación del Jefe", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }*/
                    if (Grid2[terna.Name, fila].Value.ToString() == "SI")
                    {
                        if (grid3.RowCount < 3)
                        {
                            if (MessageBox.Show("Necesita 3 Postulantes para Aprobar Terna¿ Desea Continuar ?", CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                                return;
                        }
                    }
                    if (MessageBox.Show("¿ Seguro desea Aprobar ?", CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clPostulante.AprobarPostulantePrevia(Convert.ToInt32(grid3.CurrentRow.Cells[0].Value.ToString()), grid3.CurrentRow.Cells[2].Value.ToString(), Convert.ToInt32(Grid2.CurrentRow.Cells[0].Value.ToString().Substring(2)), 10);
                        //Solicitar AProbacion
                        string cade = grid3[CODIGOTIPO.Name, filitax].Value.ToString() + ",'" + grid3[NDI.Name, filitax].Value + "'," + Grid2[SOLICITUD.Name, fila].Value.ToString().Substring(2);
                        clPostulante.TablaSolicitudes(1, int.Parse(filita["codigo"].ToString()), "usp_AprobarPostulante", cade, 0, frmLogin.CodigoUsuario, "Solicita Aprobar Postulante " + grid3[NOMBRES.Name, filitax].Value.ToString() + " " + grid3[APELLIDOPATERNO.Name, filitax].Value.ToString() + " " + grid3[APELLIDOMATERNO.Name, filitax].Value.ToString());

                        txtDocumento.Text = "";
                        txtApellidoPaterno.Text = "";
                        txtApellidoMaterno.Text = "";
                        txtNombres.Text = "";
                        txtAdjuntarCV.Text = "";
                        pbFoto.Image = null;
                        Grid2.DataSource = clPostulante.ListarSEPostulantes(frmLogin.CodigoUsuario);
                        if (Grid2.Rows.Count > 0)
                        {
                            Grid2.CurrentCell = Grid2[0, fila];
                            ColorearGrid(grid3);
                        }
                        else
                        {
                            LimpiarGrid();
                            Titulos();
                        }
                    }
                    msgOK("Solicitud Enviada a su Jefe");
                }
                else msg("No se Encuentra el Código del Jefe, Posiblemente Problema con el Contrato");
            }

        }

        private void ColorearGrid(DataGridView G)
        {
            int FilaColor = 0;
            for (FilaColor = 0; FilaColor < G.Rows.Count; FilaColor++)
            {
                if (Convert.ToInt32(G.Rows[FilaColor].Cells[7].Value.ToString()) == 2)
                {
                    G.Rows[FilaColor].DefaultCellStyle.ForeColor = Color.Red;
                    G.Rows[FilaColor].DefaultCellStyle.SelectionForeColor = Color.Red;
                }
                else if ((int)G[Estado.Name, FilaColor].Value == 10)
                {
                    G.Rows[FilaColor].DefaultCellStyle.ForeColor = Color.Blue;
                    G.Rows[FilaColor].DefaultCellStyle.SelectionForeColor = Color.Blue;
                }
                else
                {
                    G.Rows[FilaColor].DefaultCellStyle.ForeColor = Color.Black;
                    G.Rows[FilaColor].DefaultCellStyle.SelectionForeColor = Color.White;
                }
            }
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            DataRow ExistePostulante = clPostulante.ExistePostulante(Convert.ToInt32(cboTipoDocumento.SelectedValue.ToString()), txtDocumento.Text);
            if (ExistePostulante != null)
            {
                txtApellidoPaterno.Text = ExistePostulante["APELLIDOPATERNO"].ToString();
                txtApellidoMaterno.Text = ExistePostulante["APELLIDOMATERNO"].ToString();
                txtNombres.Text = ExistePostulante["NOMBRES"].ToString();
                txtAdjuntarCV.Text = ExistePostulante["NOMBREFOTO"].ToString();
                PostulanteExiste = true;
                //btnRegistrar.Enabled = false;
                msg("Postulante ya fué registrado");
            }
            else
            {
                txtApellidoPaterno.Text = "";
                txtApellidoMaterno.Text = "";
                txtNombres.Text = "";
                txtAdjuntarCV.Text = "";
                pbFoto.Image = null;
                PostulanteExiste = false;
                btnRegistrar.Enabled = true;
            }
            if (string.IsNullOrWhiteSpace(txtAdjuntarCV.Text))
            {
                pbFoto.Image = null;
            }
        }

        private void grid3_DoubleClick(object sender, EventArgs e)
        {
            if (grid3.Rows.Count > 0 && grid3.CurrentRow.Cells[0].Value != null)
            {
                if (Convert.ToInt32(grid3.CurrentRow.Cells[7].Value.ToString()) == 2)
                {
                    msg("Postulante NO se puede modificar, ya se encuentra Aprobado");
                    return;
                }

                frmPostulanteModificar frmPM = new frmPostulanteModificar();
                frmPM.Solicitud = Convert.ToInt32(Grid2.CurrentRow.Cells[0].Value.ToString().Substring(2));
                frmPM.CodigoTipoDocumento = Convert.ToInt32(grid3.CurrentRow.Cells[0].Value.ToString());
                frmPM.TipoDocumento = grid3.CurrentRow.Cells[1].Value.ToString();
                frmPM.NumeroDocumento = grid3.CurrentRow.Cells[2].Value.ToString();
                frmPM.ApellidoPaterno = grid3.CurrentRow.Cells[3].Value.ToString();
                frmPM.ApellidoMaterno = grid3.CurrentRow.Cells[4].Value.ToString();
                frmPM.Nombres = grid3.CurrentRow.Cells[5].Value.ToString();
                frmPM.FechaNac = (DateTime)grid3[FecNacimiento.Name, grid3.CurrentCell.RowIndex].Value;
                frmPM.AdjuntarCV = grid3.CurrentRow.Cells[6].Value.ToString();

                if (frmPM.ShowDialog() == DialogResult.OK)
                {
                    // CargarCombos(cboTipoDocumento, "Codigo_Tipo_ID", "Desc_Tipo_ID", "TBL_Tipo_ID");
                    Grid2.DataSource = clPostulante.ListarSEPostulantes(frmLogin.CodigoUsuario);
                    if (Grid2.Rows.Count > 0)
                    {
                        ColorearGrid(grid3);
                    }
                    else
                    {
                        LimpiarGrid();
                        Titulos();
                    }
                }
            }
        }

        private void CargarFoto(int Tipo, string Numero)
        {
            DataRow drFoto = clPostulante.CargarCualquierImagenPostulanteEmpleado("Foto", "TBL_Postulante", "Tipo_ID_Postulante", Tipo, "Nro_ID_Postulante", Numero);
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
        private void grid3_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CargarFoto(Convert.ToInt32(grid3.Rows[e.RowIndex].Cells[0].Value.ToString()), grid3.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

        private void Titulos()
        {
            if (grid3.Columns.Count == 0)
            {
                grid3.Columns.Add("CODIGOTIPO", "");
                grid3.Columns.Add("TIPOID", "");
                grid3.Columns.Add("NIDI", "");
                grid3.Columns.Add("APELLIDOPATERNO", "");
                grid3.Columns.Add("APELLIDOMATERNO", "");
                grid3.Columns.Add("NOMBRES", "");
                grid3.Columns.Add("ARCHIVOCV", "");
                grid3.Columns.Add("ESTADO", "");
            }

            grid3.Columns[0].Width = 0;
            grid3.Columns[0].Visible = false;
            grid3.Columns[0].DataPropertyName = "CODIGOTIPO";

            grid3.Columns[1].Width = 160;
            grid3.Columns[1].Visible = true;
            grid3.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid3.Columns[1].HeaderText = "TIPO ID";
            grid3.Columns[1].DataPropertyName = "TIPOID";
            grid3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            grid3.Columns[2].Width = 80;
            grid3.Columns[2].Visible = true;
            grid3.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid3.Columns[2].HeaderText = "Nº ID";
            grid3.Columns[2].DataPropertyName = "NID";
            grid3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            grid3.Columns[3].Width = 170;
            grid3.Columns[3].Visible = true;
            grid3.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid3.Columns[3].HeaderText = "APELLIDO PATERNO";
            grid3.Columns[3].DataPropertyName = "APELLIDOPATERNO";
            grid3.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            grid3.Columns[4].Width = 170;
            grid3.Columns[4].Visible = true;
            grid3.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid3.Columns[4].HeaderText = "APELLIDO MATERNO";
            grid3.Columns[4].DataPropertyName = "APELLIDOMATERNO";
            grid3.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            grid3.Columns[5].Width = 170;
            grid3.Columns[5].Visible = true;
            grid3.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid3.Columns[5].HeaderText = "NOMBRES";
            grid3.Columns[5].DataPropertyName = "NOMBRES";
            grid3.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            grid3.Columns[6].Width = 203;
            grid3.Columns[6].Visible = true;
            grid3.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid3.Columns[6].HeaderText = "ARCHIVO CV";
            grid3.Columns[6].DataPropertyName = "ARCHIVOCV";

            grid3.Columns[7].Width = 0;
            grid3.Columns[7].Visible = false;
            grid3.Columns[7].DataPropertyName = "ESTADO";
        }

        private void LimpiarGrid()
        {
            grid3.DataSource = null;
            grid3.Rows.Clear();
            grid3.Refresh();
        }

        private void txtDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            HPResergerFunciones.Utilitarios.Validardocumentos(e, txtDocumento, txtDocumento.MaxLength);
        }
        private void pbFoto_DoubleClick(object sender, EventArgs e)
        {
            if (pbFoto.Image != null)
            {
                FrmFoto foto = new FrmFoto($"Foto Postulante {txtNombres.Text} {txtApellidoPaterno.Text} {txtApellidoMaterno.Text}");
                foto.fotito = pbFoto.Image;
                foto.Owner = this.MdiParent;
                foto.ShowDialog();
            }
        }

        private void btndescargar_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbFoto.Image != null)
                btndescargar.Visible = true;
        }

        private void pbFoto_MouseMove(object sender, MouseEventArgs e)
        {
            if (pbFoto.Image != null)
                btndescargar.Visible = true;
        }

        private void frmPostulante_MouseMove(object sender, MouseEventArgs e)
        {
            btndescargar.Visible = false;
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            HPResergerFunciones.Utilitarios.DescargarImagen(pbFoto);
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {

        }

        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModificarTamañoTipo(txtDocumento, cboTipoDocumento.SelectedIndex);
        }

        private void dtpFechaNacimiento_CloseUp(object sender, EventArgs e)
        {

        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DataRow Filita = clPostulante.CalcularEdad(dtpFechaNacimiento.Value, DateTime.Now, 1);
            if (Filita != null)
            {
                txtedad.Text = Filita["edad"].ToString();
            }
            else { return; }
        }

        private void grid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}