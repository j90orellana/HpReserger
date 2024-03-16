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
            BackColor = Color.FromArgb(78, 129, 189);
            ForeColor = Color.White;
            FlatAppearance.BorderColor = Color.DodgerBlue;
            TextImageRelation = TextImageRelation.ImageBeforeText;
            Font = new Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
    }
}
