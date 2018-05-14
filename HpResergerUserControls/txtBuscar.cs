using System;
using System.Drawing;
using System.Windows.Forms;

namespace HpResergerUserControls
{
    public partial class txtBuscar : UserControl
    {
        public txtBuscar()
        {
            InitializeComponent();
            btnbuscar.Click += new EventHandler(btnbuscarClick);           
        }
        public override string Text { get { return txtbusca.Text; } set { txtbusca.Text = value; } }
        public event EventHandler ClickBotonBuscar;
        private void btnbuscarClick(object sender, EventArgs e)
        {
            ClickBotonBuscar?.Invoke(this, e);
        }
        public Image FondoBoton { get { return btnbuscar.Image; } set { btnbuscar.Image = value; } }
        private void txtBuscar_BackColorChanged(object sender, EventArgs e)
        {
            txtbusca.BackColor = this.BackColor;
            btnbuscar.BackColor = this.BackColor;
        }
        private void txtBuscar_ForeColorChanged(object sender, EventArgs e)
        {
            txtbusca.ForeColor = this.ForeColor;
        }
        private void txtBuscar_FontChanged(object sender, EventArgs e)
        {
            txtbusca.Font = this.Font;
        }
        private void txtbusca_Click(object sender, EventArgs e)
        {
            txtbusca.SelectAll();
        }
        private void txtbusca_DoubleClick(object sender, EventArgs e)
        {
            txtbusca.SelectAll();
        }       
    }
}
