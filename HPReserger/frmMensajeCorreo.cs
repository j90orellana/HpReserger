using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmMensajeCorreo : FormGradient
    {
        public frmMensajeCorreo()
        {
            InitializeComponent();
        }
        public string cadena; public Boolean ok;
        private void frmMensajeCorreo_Load(object sender, EventArgs e)
        {
            ok = false;
            DataTable tablita = new DataTable();
            tablita.Columns.Add("Codigo");
            tablita.Columns.Add("Valor");
            tablita.Rows.Add(new object[] { 2, "ALTA" });
            tablita.Rows.Add(new object[] { 0, "NORMAL" });
            tablita.Rows.Add(new object[] { 1, "BAJA" });
            cboprioridad.DataSource = tablita;
            cboprioridad.ValueMember = "codigo";
            cboprioridad.DisplayMember = "valor";
            cboprioridad.SelectedIndex = 0;
            VerificarAdjuntos();
        }
        public void VerificarAdjuntos()
        {
            if (Openfiledatos.FileNames.ToString().Length > 0)
            {
                string cadena = "";
                foreach (string ruta in Openfiledatos.FileNames)
                {
                    cadena += ruta + " ";
                }
                lbldatos.Text = cadena;
                adjunto = true;
            }
            else
            {
                lbldatos.Text = "";
                adjunto = false;
            }
        }
        public void msg(string cadena) { HPResergerFunciones.Utilitarios.msg(cadena); }
        private void btnenviar_Click(object sender, EventArgs e)
        {
            cadena = "\n\n";
            foreach (char c in txtmsg.Text)
            {
                if (c == (char)13)
                    cadena += "\n";
                else
                    cadena += c.ToString();
            }
            string[] CorreoSeparados = txtcorreo.Text.Split(';');
            foreach (string item in CorreoSeparados)
            {
                if (item.Length < 5)
                {
                    ok = false;
                    msg("Error en el Tamaño de los Correos\nLos Correos deben ir separados por: ;");
                    return;
                }
            }
            ok = true;
            this.Close();
        }
        public MailPriority PrioridadCorreo()
        {
            if (int.Parse(cboprioridad.SelectedValue.ToString()) == 2)
                return MailPriority.High;
            if (int.Parse(cboprioridad.SelectedValue.ToString()) == 1)
                return MailPriority.Low;
            if (int.Parse(cboprioridad.SelectedValue.ToString()) == 0)
                return MailPriority.Normal;
            return MailPriority.High;
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            ok = false;
            this.Close();
        }
        public Boolean adjunto = false;
        private void btnadjuntar_Click(object sender, EventArgs e)
        {
            Openfiledatos.Multiselect = true;
            if (Openfiledatos.ShowDialog() == DialogResult.OK)
            {
                if (Openfiledatos.FileNames.ToString().Length > 0)
                {
                    string cadena = "";
                    foreach (string ruta in Openfiledatos.FileNames)
                    {
                        cadena += ruta + " ";
                    }
                    lbldatos.Text = cadena;
                    adjunto = true;
                }
                else
                {
                    lbldatos.Text = "";
                    adjunto = false;
                }
            }
        }
        public string[] ArchivosAdjuntos()
        {
            return Openfiledatos.FileNames;
        }
        public Boolean Adjunto()
        {
            return adjunto;
        }
        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = txtmsg.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtmsg.Font = fontDialog1.Font;
            }
        }
        private void lbldatos_Click(object sender, EventArgs e)
        {

        }
    }
}
