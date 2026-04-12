using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class TextboxSoloNumeros : UserControl
    {
        public TextboxSoloNumeros()
        {
            InitializeComponent();

            txt.TextChanged += Txt_TextChanged;
            txt.KeyPress += Txt_KeyPress;
            txt.KeyDown += Txt_KeyDown;
            txt.Leave += Txt_Leave;
        }

        // =========================
        // 🔹 EVENTOS EXPUESTOS
        // =========================
        public new event EventHandler TextChanged;

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            TextChanged?.Invoke(this, e);
        }

        // =========================
        // 🔹 PROPIEDADES BÁSICAS
        // =========================
        [Category("HP")]
        public override string Text
        {
            get { return txt.Text; }
            set { txt.Text = value; }
        }

        [Category("HP")]
        public int MaxLengthTxt
        {
            get { return txt.MaxLength; }
            set { txt.MaxLength = value; }
        }

        [Category("HP")]
        public Font FuenteDelTxt
        {
            get { return txt.Font; }
            set { txt.Font = value; }
        }

        // =========================
        // 🔹 PROPIEDADES PRO
        // =========================
        [Category("HP")]
        public bool PermitirDecimales { get; set; } = true;

        [Category("HP")]
        public int Decimales { get; set; } = 2;

        [Category("HP")]
        public bool FormatoMoneda { get; set; } = false;

        [Category("HP")]
        public decimal Value
        {
            get
            {
                if (decimal.TryParse(txt.Text, out decimal val))
                    return val;
                return 0;
            }
            set
            {
                txt.Text = value.ToString($"N{Decimales}");
            }
        }

        // =========================
        // 🔹 VALIDACIONES
        // =========================
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir control (backspace)
            if (char.IsControl(e.KeyChar))
                return;

            // Permitir números
            if (char.IsDigit(e.KeyChar))
                return;

            // Permitir decimal
            if (PermitirDecimales && e.KeyChar == '.')
            {
                if (txt.Text.Contains("."))
                    e.Handled = true;

                return;
            }

            // Bloquear todo lo demás
            e.Handled = true;
        }

        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            // Ejemplo: Enter pasa al siguiente control
            if (e.KeyCode == Keys.Enter)
            {
                this.Parent.SelectNextControl(this, true, true, true, true);
            }
        }

        private void Txt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
                return;

            if (decimal.TryParse(txt.Text, out decimal val))
            {
                if (FormatoMoneda)
                {
                    txt.Text = val.ToString($"N{Decimales}", CultureInfo.CurrentCulture);
                }
            }
        }

        // =========================
        // 🔹 MÉTODOS EXTRA
        // =========================
        public void Limpiar()
        {
            txt.Text = "0";
        }

        public void SeleccionarTodo()
        {
            txt.SelectAll();
        }
    }
}