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
            _ReadOnly = false;
            //DropDownStyleDefecto = DropDownStyle;
            InitializeComponent();
            ValoresInicio();
        }
        //static ComboBoxStyle DropDownStyleDefecto;
        public string IndexText { get; set; }
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            //IndexText = Text;
            if (ReadOnly)
            {
                //Text = IndexText;
                DropDownStyle = ComboBoxStyle.Simple;
            }
            else
            {
                //IndexText = Text;
                DropDownStyle = ComboBoxStyle.DropDownList;
            }
            base.OnSelectedIndexChanged(e);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            // if (e.KeyData == Keys.Down || e.KeyData == Keys.Up)
            if (this.ReadOnly) e.Handled = true;
            base.OnKeyDown(e);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (this.ReadOnly) e.Handled = true;
            base.OnKeyPress(e);
        }
        protected override void OnClick(EventArgs e)
        {
            if (ReadOnly) { DropDownStyle = ComboBoxStyle.Simple; DroppedDown = false; }
            else { DropDownStyle = ComboBoxStyle.DropDownList; }
            base.OnClick(e);
        }
        private Boolean _ReadOnly;
        public Boolean ReadOnly
        {
            get { return _ReadOnly; }
            set
            {
                _ReadOnly = value;
                CambiaReadOnly();
            }
        }
        public void CambiaReadOnly()
        {
            try
            {
                if (ReadOnly)
                {
                    DropDownStyle = ComboBoxStyle.Simple;
                    DroppedDown = false;
                }
                else
                {
                    DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
            catch (Exception) { }
        }
        public void ValoresInicio()
        {
            BackColor = System.Drawing.Color.FromArgb(204, 218, 231);
            //DropDownStyleDefecto = this.DropDownStyle;
        }
        public ComboBoxPer(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            ValoresInicio();
        }
    }
}
