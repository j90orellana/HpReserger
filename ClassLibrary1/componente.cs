using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ClassLibrary1
{
    public partial class componente : Component
    {
        public componente()
        {
            InitializeComponent();
        }
        public componente(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        public int Cantidad { get; set; }
        public int Cantidad2 { get; set; }
        public Control Control { get; set; }
        public Button Boton { get; set; }
        public int InstanceCount { get { return Valor; } set { Valor = value; } }
        int Valor = 100;
        public int InstanceCount2 { get { return Valor; } set { Valor = value; } }
        public Color Colorea { get; set; }
        DataGridView dtgconten = new DataGridView();
        public void yqudice()
        {
            dtgconten.DataSource = new DataTable();
        }
        public void msg(string cadena)
        {
            ActivarControles(new TextBox(), new ComboBox());
            MessageBox.Show(cadena);
        }
        public void ActivarControles(params Control[] Controles)
        {
            foreach (Control x in Controles)
                x.Enabled = true;
        }
    }
}
