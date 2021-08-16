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
            btnlimpiar.Click += new EventHandler(Btnlimpiar_Click);
            _text = txtbusca.Text;
        }
        public static string _text;
        public event EventHandler BuscarClick;
        public event EventHandler ClickLimpiarboton;
        public event EventHandler BuscarTextChanged;
        public event KeyPressEventHandler PresionarEnter;
        private Image _ImgBotonCerrar;
        public Image ImgBotonCerrar { get { return _ImgBotonCerrar; } set { _ImgBotonCerrar = value; } }
        public Image FondoBoton { get { return btnbuscar.Image; } set { btnbuscar.Image = value; } }
        public override string Text { get { return txtbusca.Text; } set { txtbusca.Text = value; } }
        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            ClickLimpiarboton?.Invoke(sender, e);
        }
        private void btnbuscarClick(object sender, EventArgs e)
        {
            BuscarClick?.Invoke(this, e);
        }
        private void btnbuscarTextChanged(object sender, EventArgs e)
        {
            BuscarTextChanged?.Invoke(this, e);
        }
        private void txtBuscar_BackColorChanged(object sender, EventArgs e)
        {
            btnlimpiar.BackColor = txtbusca.BackColor = btnbuscar.BackColor = this.BackColor;
        }
        private void txtBuscar_ForeColorChanged(object sender, EventArgs e)
        {
            txtbusca.ForeColor = this.ForeColor;
        }
        public Boolean EstaLLeno()
        {
            if (txtbusca.Text == _text || txtbusca.Text.Length == 0) return false;
            else return true;
        }
        private void txtBuscar_FontChanged(object sender, EventArgs e)
        {
            txtbusca.Font = this.Font;
        }
        private void txtbusca_Click(object sender, EventArgs e)
        {
            if (txtbusca.Text == _text) txtbusca.Text = "";
        }
        private void txtbusca_DoubleClick(object sender, EventArgs e)
        {
            txtbusca.SelectAll();
        }
        private void btnlimpiar_Click_1(object sender, EventArgs e)
        {
            txtbusca.Text = "";
            txtbusca.Focus();
        }
        Font FontPrueba;
        private void txtbusca_Leave(object sender, EventArgs e)
        {
            if (txtbusca.Text == "")
            {
                txtbusca.Text = _text;
            }
        }
        public string TextoValido()
        {
            string cadena = "";
            if (EstaLLeno()) cadena = Text; else cadena = "";
            return cadena;
        }

        private void txtBuscar_Resize(object sender, EventArgs e)
        {
            txtbusca.Font = new Font(this.Font.FontFamily, this.Height / 2);
        }

        private void txtbusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            PresionarEnter?.Invoke(this, e);
        }
    }
}
