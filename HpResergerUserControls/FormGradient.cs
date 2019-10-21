using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HpResergerUserControls
{
    public partial class FormGradient : Form
    {
        public FormGradient()
        {
            Invalidate();
            InitializeComponent();
            DoubleBuffered = true;
        }
        public DateTime Hoy = DateTime.Now;
        Color[] _colores = new Color[] { Color.FromArgb(252, 253, 253), Color.FromArgb(224, 229, 237), Color.FromArgb(252, 253, 253) };
        int _angulo = 45;
        int _Seguntos = 0;
        public Color[] Colores { get { return _colores; } set { _colores = value; Invalidate(); } }
        public int Angulo { get { return _angulo; } set { _angulo = value; Invalidate(); } }
        public string Nombre { get { return Text; } set { Text = value; } }
        public int SegundosAparecer { get { return _Seguntos; } set { _Seguntos = value; } }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.ClientRectangle.Height > 0 && this.ClientRectangle.Width > 0)
                if (_colores.Length > 0)
                {
                    LinearGradientBrush BrochaGradienteLineal = new LinearGradientBrush(this.ClientRectangle, Color.Black, Color.Black, Angulo);
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
                    e.Graphics.FillRectangle(BrochaGradienteLineal, this.ClientRectangle);
                    //e.Graphics.FillRectangle(Brushes.BlanchedAlmond, this.ClientRectangle);
                }
            base.OnPaint(e);
            this.ResumeLayout();
        }
        public Boolean CerrarAlPresionarESC { get; set; }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (CerrarAlPresionarESC)
            {
                if (e.KeyCode == Keys.Escape) this.Close();
            }
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (CerrarAlPresionarESC)
            {
                if (e.KeyChar == (char)Keys.Escape) this.Close();
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            ///Recarga el Fondo del control!.
            Invalidate();
            base.OnSizeChanged(e);
        }
        //Para Quitar Parpadeo en los Formularios
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        //cp.ExStyle = cp.ExStyle | 0x2000000;
        //        cp.ExStyle |= 0x02000000;
        //        return cp;
        //    }
        //}
        Timer time = new Timer();
        private void FormGradient_Load(object sender, EventArgs e)
        {
            //if (_Seguntos > 0 && Opacity == 1)
            //{
            //    time.Interval = (1000 / (100 * _Seguntos));
            //    time.Tick += Time_Tick;
            //    Opacity = 0;
            //    time.Start();
            //}
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
            {
                Opacity += 0.1;
            }
            else time.Stop();
        }
    }
}
