﻿using System;
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
        }
        Color[] _colores = new Color[] { Color.FromArgb(252, 253, 253), Color.FromArgb(224, 229, 237), Color.FromArgb(252, 253, 253) };
        int _angulo = 45;
        public Color[] Colores { get { return _colores; } set { _colores = value; } }
        public int Angulo { get { return _angulo; } set { _angulo = value; } }
        public string Nombre
        {
            get { return Text; }
            set { Text = value; }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
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
                }
        }
        private void FormGradient_Load(object sender, EventArgs e)
        {

        }
    }
}