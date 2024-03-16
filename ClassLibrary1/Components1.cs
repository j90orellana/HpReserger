using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public partial class Components1 : componente
    {
        public Components1()
        {
            InitializeComponent();
        }
        public Components1(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        public static void yquedice()
        {

        }
    }
}
