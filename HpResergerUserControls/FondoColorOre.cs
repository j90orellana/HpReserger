using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HpResergerUserControls
{
    public partial class FondoColorOre : Component
    {
        public FondoColorOre()
        {
            InitializeComponent();
            //Angulo = 45;
            //Color[] _colores = new Color[] { Color.FromArgb(45, 45, 48), Color.FromArgb(62, 62, 66), Color.FromArgb(37, 37, 38) };
        }
        Color[] _colores = new Color[] { Color.FromArgb(252, 253, 253), Color.FromArgb(224, 229, 237), Color.FromArgb(252, 253, 253) };
        public Color[] Colores
        {
            get { return _colores; }
            set { _colores = value; if (_Control != null) _Control.Invalidate(); }
        }
        public int _angulo = 45;
        public int Angulo
        {
            get { return _angulo; }
            set { _angulo = value; if (_Control != null) _Control.Invalidate(); }
        }
        private Control _Control;
        public Control control
        {
            get { return _Control; }
            set
            {
                if (value != null)
                {
                    _Control = value;
                    _Control.Paint += Control_Paint;                  
                    _Control.Invalidate();
                }
            }
        }
        public FondoColorOre(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            //control.Paint += Control_Paint;
        }
        private void Control_Paint(object sender, PaintEventArgs e)
        {
            if (_Control.ClientRectangle.Height > 0 && _Control.ClientRectangle.Width > 0)
                if (_colores.Length > 0)
                {
                    LinearGradientBrush BrochaGradienteLineal = new LinearGradientBrush(_Control.ClientRectangle, Color.Black, Color.Black, _angulo);
                    ColorBlend BlendColor = new ColorBlend();
                    BlendColor.Colors = _colores;
                    float[] colorea = new float[_colores.Length];
                    float Valor = 1.0f / (_colores.Length - 1);
                    for (int i = 0; i < _colores.Length; i++)
                    {
                        colorea[i] = i * Valor;
                    }
                    BlendColor.Positions = colorea;
                    BrochaGradienteLineal.InterpolationColors = BlendColor;
                    e.Graphics.FillRectangle(BrochaGradienteLineal, _Control.ClientRectangle);
                    //e.Graphics.FillRectangle(Brushes.BlanchedAlmond, this.ClientRectangle);
                }
            //_Control.ResumeLayout();
        }
    }
}
