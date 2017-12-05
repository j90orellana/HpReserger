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
    public partial class frmTipodeCambio : Form
    {
        public frmTipodeCambio()
        {
            InitializeComponent();
        }

        private void TipodeCambio_Load(object sender, EventArgs e)
        {
            ColumnasTAblas();
            try
            {
                webBrowser1.Navigate("www.sunat.gob.pe/cl-at-ittipcam/tcS01Alias");
            }
            catch { msg("No Se pudo Conectar con la Sunat"); }

        }
        public Boolean Carga = false;
        DataTable tablita = new DataTable();
        public void ColumnasTAblas()
        {
            tablita.Columns.Add("Dia", typeof(int));
            tablita.Columns.Add("Compra", typeof(decimal));
            tablita.Columns.Add("Venta", typeof(decimal));
            tablita.Columns.Add("Mes", typeof(int));
            tablita.Columns.Add("Año", typeof(int));
        }
        string[] Tcambio = new string[3];
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (Carga == false)
            {
                webBrowser1.Document.GetElementById("mes").SetAttribute("value", comboMesAño1.getMesNumero().ToString("00"));
                webBrowser1.Document.GetElementById("anho").SetAttribute("value", comboMesAño1.GetAño().ToString());
                webBrowser1.Document.GetElementById("B1").InvokeMember("click");
                Carga = true;
                return;
            }
            if (Carga == true)
            {
                tablita.Clear();
                HtmlElementCollection datos = webBrowser1.Document.GetElementsByTagName("td");
                int con = 0; string cadena = "";
                foreach (HtmlElement dato in datos)
                {
                    if (dato.InnerText.Trim() != "Tipo de cambio publicado al :")
                    {
                        if (char.IsDigit(char.Parse((dato.InnerText.Substring(0, 1)))))
                        {
                            con++;
                            cadena += dato.InnerText;
                            if (con == 3)
                            {
                                Tcambio = cadena.Split(' ');
                                tablita.Rows.Add(int.Parse(Tcambio[0]), decimal.Parse(Tcambio[1]), decimal.Parse(Tcambio[2]), comboMesAño1.getMesNumero(), comboMesAño1.GetAño());
                                con = 0;
                                cadena = "";
                            }
                        }
                    }
                }
            }
            if (tablita.Rows.Count > 0)
            {
                DataRow filita = tablita.Rows[0];
                DataRow filiaux;
                int min = int.Parse(filita["dia"].ToString());
                filita = tablita.Rows[tablita.Rows.Count - 1];
                int max = int.Parse(filita["dia"].ToString());
                int aux = 0;
                for (int i = min; i <= max; i++)
                {
                    filita = tablita.Rows[aux];
                    if (int.Parse(filita["dia"].ToString()) != i)
                    {
                        filiaux = tablita.NewRow();
                        filita = tablita.Rows[aux - 1];
                        filiaux["dia"] = i;
                        filiaux["mes"] = filita["mes"];
                        filiaux["año"] = filita["año"];
                        filiaux["compra"] = filita["compra"];
                        filiaux["venta"] = filita["venta"];
                        tablita.Rows.InsertAt(filiaux, aux);
                        aux++;
                    }
                    else { aux++; }
                }
                dtgconten.DataSource = tablita;
            }
            else { msg("No Hay Datos para este Mes"); }
        }
        private void Btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Document.GetElementById("mes").SetAttribute("value", comboMesAño1.getMesNumero().ToString("00"));
                webBrowser1.Document.GetElementById("anho").SetAttribute("value", comboMesAño1.GetAño().ToString());
                webBrowser1.Document.GetElementById("B1").InvokeMember("click");
            }
            catch
            {
                msg("No Se pudo Conectar con la Sunat");
            }
        }
        public DialogResult msg(string cadena)
        {
            return MessageBox.Show(cadena, "Hp Reserger", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void dtgconten_MouseDown(object sender, MouseEventArgs e)
        {
            dtgconten.EndEdit();
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(dtgconten.CurrentCell.Value.ToString(), DragDropEffects.Copy);

            }
        }
    }
}
