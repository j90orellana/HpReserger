using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HpResergerUserControls
{
    public partial class ControlDeslizamiento : Component
    {
        public ControlDeslizamiento()
        {
            InitializeComponent();
        }
        [Description("Valor que quedará el control oculto en Alto")]
        public int MinimoAlto { get; set; }
        [Description("Valor que quedará el control oculto en Ancho")]
        public int MinimoAncho { get; set; }
        [Description("Intervalo de Tiempo en milisegundos para ocultar o mostrar el control")]
        public int Delay { get; set; }
        // public int Ancho { get; set; }
        // public int Alto { get; set; }
        public Control Controls { get; set; }
        public ControlDeslizamiento(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        int lengthAncho;
        int maximoAncho;
        int lengthAlto;
        int maximoAlto;
        public void OcultarMostrarAncho()
        {
            if (MinimoAncho != 0)
                if (MinimoAncho < Controls.Width)
                {
                    //ocultando
                    lengthAncho = Controls.Width - MinimoAncho;
                    maximoAncho = Controls.Width;
                    for (int i = 0; i < lengthAncho; i++)
                    {
                        Controls.Width = maximoAncho - (i + 1);
                        //Thread.Sleep(Delay);
                    }
                }
                else
                {
                    //mostrando  
                    int minimo = Controls.Width;
                    for (int i = 0; i < lengthAncho; i++)
                    {
                        Controls.Width = minimo + (i + 1);
                        //Thread.Sleep(Delay);
                    }
                }
        }
        public void OcultarMostrarAlto()
        {
            if (MinimoAlto != 0)
                if (MinimoAlto < Controls.Height)
                {
                    //ocultando
                    lengthAlto = Controls.Height - MinimoAlto;
                    maximoAlto = Controls.Height;
                    for (int i = 0; i < lengthAlto; i++)
                    {
                        Controls.Height = maximoAlto - (i + 1);
                        //Thread.Sleep(Delay);
                    }
                }
                else
                {
                    //mostrando  
                    int minimo = Controls.Height;
                    for (int i = 0; i < lengthAlto; i++)
                    {
                        Controls.Height = minimo + (i + 1);
                        //Thread.Sleep(Delay);
                    }
                }
        }
    }
}
