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
    public partial class ButtonPer : Button
    {
        public ButtonPer()
        {
            InitializeComponent();
            FlatStyle = FlatStyle.Flat;
            BackColor= Color.FromArgb(78, 129, 189);
            ForeColor = Color.White;
            FlatAppearance.BorderColor = Color.DodgerBlue;
            TextImageRelation = TextImageRelation.ImageBeforeText;
        }
    }
}
