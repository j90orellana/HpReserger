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
            InitializeComponent();
            ValoresInicio();
        }
        public string IndexText { get; set; }
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            if (ReadOnly)
            {
                Text = IndexText;
                DropDownStyle = ComboBoxStyle.Simple;
            }
            else
            {
                IndexText = Text;
                DropDownStyle = ComboBoxStyle.DropDownList;
            }
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
