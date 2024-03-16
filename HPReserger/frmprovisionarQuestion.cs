using HpResergerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPReserger
{
    public partial class frmprovisionarQuestion : FormGradient
    {
        public frmprovisionarQuestion()
        {
            InitializeComponent();
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cbodetraccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbodetraccion.Text == "NO")
                numdetraccion.Enabled = false;
            else
                numdetraccion.Enabled = true;
        }

        private void frmprovisionarQuestion_Load(object sender, EventArgs e)
        {

        }
    }
}
