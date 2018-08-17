using System;
using System.Drawing;
using System.Windows.Forms;

namespace HpResergerUserControls
{
    public partial class txtBuscar : UserControl
    {
        public txtBuscar()
        {
            InitializeComponent();
            btnbuscar.Click += new EventHandler(btnbuscarClick);
            txtbusca.TextChanged += new EventHandler(btnbuscarTextChanged);
            _text = Text;
        }
        public static string _text;
        public event EventHandler BuscarClick;
        public event EventHandler BuscarTextChanged;
        private void btnbuscarTextChanged(object sender, EventArgs e)
        {
            BuscarTextChanged?.Invoke(this, e);
        }
        private string Text;
        public string _Text
        {
            get { return txtbusca.Text; }
            set { txtbusca.Text = value; }
        }        
        private void btnbuscarClick(object sender, EventArgs e)
        {
            BuscarClick?.Invoke(this, e);
        }
        public Image FondoBoton { get { return btnbuscar.Image; } set { btnbuscar.Image = value; } }
        private void txtBuscar_BackColorChanged(object sender, EventArgs e)
        {
            txtbusca.BackColor = this.BackColor;
            btnbuscar.BackColor = this.BackColor;
        }
        private void txtBuscar_ForeColorChanged(object sender, EventArgs e)
        {
            txtbusca.ForeColor = this.ForeColor;
        }
        public Boolean EstaLLeno()
        {
            if (txtbusca.Text == _text || txtbusca.Text.Length == 0)
                return false;
            else return true;
        }
        private void txtBuscar_FontChanged(object sender, EventArgs e)
        {
            txtbusca.Font = this.Font;
        }
        private void txtbusca_Click(object sender, EventArgs e)
        {
            txtbusca.SelectAll();
        }
        private void txtbusca_DoubleClick(object sender, EventArgs e)
        {
            txtbusca.SelectAll();
        }
    }
}
