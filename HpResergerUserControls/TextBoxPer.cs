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
        public object Objeto = null;
        public string TextoDefecto
        {
            get { return TextoPorDefecto; }
            set { this.TextoPorDefecto = value; }
        }
        public enum ListaTipos
        {
            SoloLetras, SoloNumeros, SoloDinero
        }
        public ListaTipos ListadeTipos;
        DataTable Controlss = new DataTable();
        ComboBox Combito = new ComboBox();
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
        protected override void OnCreateControl()
        {
            ColorLetras = ForeColor;
            ColorFondo = BackColor;
            this.Text = TextoPorDefecto;
            this.ForeColor = ColorTextoDefecto;
            Invalidate();
        }
        protected override void OnLeave(EventArgs e)
        {
            if (this.Text.Length <= 0)
            {
                this.Text = TextoPorDefecto;
                this.ForeColor = ColorTextoDefecto;
            }
        }
        protected override void OnClick(EventArgs e)
        {
            if (this.Text.ToUpper() == this.TextoPorDefecto.ToUpper())
            {
                this.Text = "";
                this.ForeColor = ColorLetras;
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (!ColorFondoMouseEncima.IsEmpty)
                this.BackColor = ColorFondoMouseEncima;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (!ColorFondoMousePresionado.IsEmpty)
                this.BackColor = ColorFondoMousePresionado;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            if (!ColorFondo.IsEmpty)
                this.BackColor = ColorFondo;
        }
        public Boolean EstaLLeno()
        {
            if (this.Text.ToUpper() == TextoPorDefecto.ToUpper()) return false;
            if (this.Text.Length <= 0) return false;
            return true;
        }
        protected override void OnTextChanged(EventArgs e)
        {
            if (Text != TextoPorDefecto)
                ForeColor = ColorLetras;
        }
        private Control _NextControlOnEnter;
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
            if (e.KeyChar == (char)Keys.Enter)
            {
                _NextControlOnEnter.Focus();
                //// ControlesList _list = new ControlesList();
                //// _list = (ControlesList)Combito.SelectedItem;
                //// if (_list != null)
                ////  {
                //if (_SiguienteControl != null)
                //{
                //    Control[] x = this.Parent.Controls.Find(_SiguienteControl, false);
                //    if (x.Length > 0)
                //    {
                //        Objeto = x[0];
                //        ((Control)Objeto).Focus();
                //    }
                //}
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
        }
    }
}
