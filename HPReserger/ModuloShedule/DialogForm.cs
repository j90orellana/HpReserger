using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISGEM.ModuloShedule
{
    public class DialogForm : Form
    {
        private Label lblHola;
        private TextBox txtInput;
        private Button btnSaveClose;

        public DialogForm()
        {
            InitializeComponents();
        }
        public enum Tipo { objetivo, estrategia, problema, detalle }
        Tipo _Tipo;
        public int _fkid;
        string _idcliente;
        public DialogForm(string Titulo, string Texto, Tipo tipo, string idcliente, int fkid)
        {
            InitializeComponents();
            this.Text = Titulo;
            lblHola.Text = Texto;
            _Tipo = tipo;
            _fkid = fkid;
            _idcliente = idcliente;
        }
        private void InitializeComponents()
        {
            this.Text = "Dialog Form";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ClientSize = new System.Drawing.Size(800, 150);

            lblHola = new Label();
            lblHola.Text = "Hola";
            lblHola.Location = new System.Drawing.Point(20, 20);

            txtInput = new TextBox();
            txtInput.Location = new System.Drawing.Point(200, 20);
            txtInput.Width = 570;

            btnSaveClose = new Button();
            btnSaveClose.Text = "Guardar y Cerrar";
            btnSaveClose.Width = 200;
            btnSaveClose.Location = new System.Drawing.Point(300, 60);
            btnSaveClose.Click += BtnSaveClose_Click;

            this.Controls.Add(lblHola);
            this.Controls.Add(txtInput);
            this.Controls.Add(btnSaveClose);
        }

        private void BtnSaveClose_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                XtraMessageBox.Show("El campo de texto no debe estar vacío. Por favor, ingrese un valor.",
                                    "Campo de Texto Vacío",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(_idcliente))
            {
                XtraMessageBox.Show("El ID del cliente no está especificado. Asegúrese de seleccionar un cliente válido antes de proceder.",
                                    "ID Cliente No Especificado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                return;
            }

            if (_idcliente != "")
            {

                if (_fkid == 0)//no existe estrate, toca crearlo
                {
                    HpResergerNube.SCH_Estrate objEstrate = new HpResergerNube.SCH_Estrate();
                    objEstrate.FechaCreacion = DateTime.Now;
                    objEstrate.IDCliente = _idcliente;
                    _fkid = objEstrate.InsertEstrate(objEstrate);

                }

                if (_fkid != 0)
                {
                    if (_Tipo == Tipo.objetivo)
                    {

                        HpResergerNube.SCH_Estrate_Objetivos objClase = new HpResergerNube.SCH_Estrate_Objetivos();

                        objClase.Nombre = txtInput.Text;
                        objClase.Estado = 1;
                        objClase.FechaCreacion = DateTime.Now;
                        objClase.FkIdEstrate = _fkid;

                        objClase.InsertEstrateObjetivo(objClase);
                    }
                    if (_Tipo == Tipo.problema)
                    {

                        HpResergerNube.SCH_Estrate_Problemas objClase = new HpResergerNube.SCH_Estrate_Problemas();

                        objClase.Nombre = txtInput.Text;
                        objClase.Estado = 1;
                        objClase.FechaCreacion = DateTime.Now;
                        objClase.FkIdEstrate = _fkid;

                        objClase.InsertProblema(objClase);
                    }
                    if (_Tipo == Tipo.estrategia)
                    {

                        HpResergerNube.SCH_Estrate_Estrategia objClase = new HpResergerNube.SCH_Estrate_Estrategia();

                        objClase.Nombre = txtInput.Text;
                        objClase.Estado = 1;
                        objClase.FechaCreacion = DateTime.Now;
                        objClase.FkIdEstrate = _fkid;

                        objClase.InsertEstrateEstrategia(objClase);
                    }
                    if (_Tipo == Tipo.detalle)
                    {

                        HpResergerNube.SCH_Estrate_Objetivos_Operativos objClase = new HpResergerNube.SCH_Estrate_Objetivos_Operativos();

                        objClase.Nombre = txtInput.Text;
                        objClase.Estado = 1;
                        objClase.FechaCreacion = DateTime.Now;
                        objClase.FkId = _fkid;
                        objClase.Estado = 3;
                        objClase.FechaRecordatorio = DateTime.Now;
                        objClase.Comentario = "";
                        objClase.DetalleObjetivo = "";
                        objClase.ObjetivoRelacionado = 0;
                        objClase.Responsable = "";
                        objClase.Status = "";

                        objClase.InsertObjetivoOperativo(objClase);
                    }
                }

            }
            this.Close();
        }
    }
}
