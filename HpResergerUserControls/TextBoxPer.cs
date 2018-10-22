using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace HpResergerUserControls
{
    public partial class TextBoxPer : TextBox
    {
        public TextBoxPer()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(136, 178, 178);
            BorderStyle = BorderStyle.FixedSingle;
            TextoDefectoColor = Color.White;
            MaxLength = 100;
            Font x = new Font(Font.FontFamily, 10, FontStyle.Bold);
            Font = x;
            Invalidate();
        }
        public Color ColorTextoDefecto = Color.Black;
        public Color ColorLetras = Color.Black;
        public Color ColorFondo = Color.White;
        public Color ColorMouseSobre;
        public Color ColorMousePresionado;
        public string TextoPorDefecto = "Ingrese Cadena";
        private Control _NextControlOnEnter;
        public ListaTipos ListadeTipos;
        DataTable Controlss = new DataTable();
        ComboBox Combito = new ComboBox();
        public enum ListaTipos
        {
            Todo, SoloLetras, SoloNumeros, SoloNumerosConCero, SoloDinero, MayusculaCadaPalabra
        }
        public string TextoDefecto
        {
            get { return TextoPorDefecto; }
            set { this.TextoPorDefecto = value; }
        }
        public ListaTipos TiposDatos
        {
            get { return ListadeTipos; }
            set { this.ListadeTipos = value; }
        }
        public Color TextoDefectoColor
        {
            get { return ColorTextoDefecto; }
            set { this.ColorTextoDefecto = value; }
        }
        public Color ColorFondoMouseEncima
        {
            get { return ColorMouseSobre; }
            set { this.ColorMouseSobre = value; }
        }
        public Color ColorFondoMousePresionado
        {
            get { return ColorMousePresionado; }
            set { this.ColorMousePresionado = value; }
        }
        [Description("El Siguiente Control al Presionar Enter")]
        public Control NextControlOnEnter
        {
            get { return _NextControlOnEnter; }
            set { _NextControlOnEnter = value; }
        }
        public override void ResetText()
        {
            base.ResetText();
            this.Text = TextoDefecto;
        }
        protected override void OnReadOnlyChanged(EventArgs e)
        {
            if (this.ReadOnly)
                BackColor = Configuraciones.ColordeEnabledReadOnly;
            else
                BackColor = Color.White;
            base.OnReadOnlyChanged(e);
        }
        protected override void OnCreateControl()
        {
            ColorLetras = ForeColor;
            ColorFondo = BackColor;
            if (!EstaLLeno())
                this.Text = TextoPorDefecto;
            //this.ForeColor = ColorTextoDefecto;
            Invalidate();
        }
        protected override void OnLeave(EventArgs e)
        {
            if (this.Text.Length <= 0 || Text == "" || Text == TextoPorDefecto)
            {
                this.Text = TextoPorDefecto;
                this.ForeColor = ColorTextoDefecto;
            }
            else
            {
                if (TiposDatos == ListaTipos.SoloDinero) Text = decimal.Parse(Text).ToString("n2");
                if (TiposDatos == ListaTipos.SoloNumeros) Text = decimal.Parse(Text).ToString(TextoDefecto);
            }
            base.OnLeave(e);
        }
        public string TextValido()
        {
            string cadena = "";
            if (this.Text.Length <= 0 || Text == "" || Text == TextoPorDefecto)
            {
                if (TiposDatos == ListaTipos.MayusculaCadaPalabra || TiposDatos == ListaTipos.SoloLetras || TiposDatos == ListaTipos.Todo)
                    cadena = "";
                if (TiposDatos == ListaTipos.SoloDinero) cadena = TextoDefecto;
                if (TiposDatos == ListaTipos.SoloNumeros) cadena = TextoDefecto;
            }
            else cadena = Text;
            return cadena;
        }
        public string TextValidoNumeros()
        {
            string cadena = "";
            if (this.Text.Length <= 0 || Text == "" || Text == TextoPorDefecto)
            {
                if (TiposDatos == ListaTipos.MayusculaCadaPalabra || TiposDatos == ListaTipos.SoloLetras || TiposDatos == ListaTipos.Todo)
                    cadena = "";
                if (TiposDatos == ListaTipos.SoloDinero) cadena = TextoDefecto;
                if (TiposDatos == ListaTipos.SoloNumeros) cadena = TextoDefecto;
            }
            else cadena = Text;
            return cadena;
        }
        public void CargarTextoporDefecto()
        {
            //if (TiposDatos == ListaTipos.MayusculaCadaPalabra || TiposDatos == ListaTipos.SoloLetras || TiposDatos == ListaTipos.Todo)
            Text = TextoDefecto;
            //if (TiposDatos == ListaTipos.SoloDinero) Text = TextoDefecto;
            //if (TiposDatos == ListaTipos.SoloNumeros) Text = TextoDefecto;
            OnLeave(new EventArgs());
        }
        protected override void OnClick(EventArgs e)
        {
            if (!ReadOnly)
                if (this.Text.ToUpper() == this.TextoPorDefecto.ToUpper())
                {
                    this.Text = "";
                    this.ForeColor = ColorLetras;
                }
            base.OnClick(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (!ColorFondoMouseEncima.IsEmpty)
                this.BackColor = ColorFondoMouseEncima;
            base.OnMouseMove(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (!ColorFondoMousePresionado.IsEmpty)
                this.BackColor = ColorFondoMousePresionado;
            base.OnMouseDown(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            if (!ColorFondoMouseEncima.IsEmpty)
                this.BackColor = ColorFondo;
            base.OnMouseLeave(e);
        }
        public Boolean EstaLLeno()
        {
            if (this.Text.ToUpper() == TextoPorDefecto.ToUpper()) return false;
            if (this.Text.Length <= 0) return false;
            if (TiposDatos == ListaTipos.SoloNumeros && Text == "0.00") return false;
            if (TiposDatos == ListaTipos.SoloNumerosConCero && Text == "0.00") return false;
            return true;
        }
        protected override void OnTextChanged(EventArgs e)
        {
            if (TiposDatos == ListaTipos.MayusculaCadaPalabra)
            {
                this.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.Text);
                SelectionStart = TextLength;
            }
            if (Text != TextoPorDefecto)
                ForeColor = ColorLetras;
            base.OnTextChanged(e);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (TiposDatos == ListaTipos.SoloLetras)
            {
                HPResergerFunciones.Utilitarios.Sololetras(e);
            }
            if (TiposDatos == ListaTipos.SoloDinero)
            {
                HPResergerFunciones.Utilitarios.SoloNumerosDecimalesX(e, this.Text);
            }
            if (TiposDatos == ListaTipos.SoloNumeros)
            {
                HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
            }
            if (TiposDatos == ListaTipos.SoloNumerosConCero)
            {
                HPResergerFunciones.Utilitarios.SoloNumerosEnteros(e);
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (_NextControlOnEnter != null)
                    _NextControlOnEnter.Focus();
            }
            base.OnKeyPress(e);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (TiposDatos == ListaTipos.SoloLetras)
            {
                HPResergerFunciones.Utilitarios.ValidarPegarSoloLetrasyEspacio(e, this, this.MaxLength);
            }
            if (TiposDatos == ListaTipos.SoloDinero)
            {
                HPResergerFunciones.Utilitarios.ValidarDinero(e, this);
            }
            if (TiposDatos == ListaTipos.SoloNumeros)
            {
                HPResergerFunciones.Utilitarios.ValidarCuentaBancos(e, this, this.MaxLength);
            }
            if (TiposDatos == ListaTipos.SoloNumerosConCero)
            {
                HPResergerFunciones.Utilitarios.ValidarCuentaBancos(e, this, this.MaxLength);
            }
            base.OnKeyDown(e);
        }
    }
}
