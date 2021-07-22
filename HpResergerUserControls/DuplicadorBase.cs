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
    public partial class DuplicadorBase : UserControl
    {
        public DuplicadorBase()
        {
            InitializeComponent();
        }
        public DataGridView dataTable { get; set; }
        public Image img { get { return pbfoto.Image; } set { pbfoto.Image = value; } }
        public string Msg { get; private set; }
        private void pbfoto_Click(object sender, EventArgs e)
        {
            if (dataTable != null)
                if (dataTable.DataSource != null)
                {
                    string cadena = "";
                    DataTable Tabla = ((DataTable)dataTable.DataSource).Copy();
                    foreach (DataColumn item in Tabla.Columns)
                    {
                        cadena += item.ColumnName + "\t";
                    }
                    cadena += "\n";
                    foreach (DataRow fila in Tabla.Rows)
                    {
                        foreach (DataColumn col in Tabla.Columns)
                        {
                            cadena += fila[col.ColumnName].ToString() + "\t";
                        }
                        cadena += "\n";
                    }
                    Clipboard.SetText(cadena);
                    tip.Show("Copiado", pbfoto);
                }
                else
                {

                }
        }
        ToolTip tip = new ToolTip();

        private void DuplicadorBase_Load(object sender, EventArgs e)
        {
            tip.Show("Copiar Grilla", pbfoto);
        }
    }
}
