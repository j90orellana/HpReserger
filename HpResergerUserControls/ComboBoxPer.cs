using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HpResergerUserControls
{
    public partial class ComboBoxPer : ComboBox
    {
        public ComboBoxPer()
        {
            InitializeComponent();
            ValoresInicio();
        }
        public void ValoresInicio()
        {
            BackColor = System.Drawing.Color.FromArgb(204, 218, 231);
            DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public ComboBoxPer(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            ValoresInicio();
        }        
    }
}
