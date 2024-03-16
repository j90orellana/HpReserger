using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
namespace SISGEM
{
    public class SkinPickerForm : XtraForm
    {
        private DefaultLookAndFeel _lookAndFeel;
        private ComboBoxEdit _skinComboBox;
        private SimpleButton _okButton;

        public string SelectedSkinName { get; private set; }

        public event EventHandler<SkinSelectedEventArgs> SkinSelected;

        public SkinPickerForm(DefaultLookAndFeel lookAndFeel)
        {
            _lookAndFeel = lookAndFeel;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            _skinComboBox = new ComboBoxEdit();
            this.StartPosition = FormStartPosition.CenterParent;
            _skinComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            foreach (DevExpress.Skins.SkinContainer item in SkinManager.Default.Skins)
            {
                _skinComboBox.Properties.Items.Add(item.SkinName);

            }
            _skinComboBox.SelectedIndexChanged += SkinComboBox_SelectedIndexChanged;

            _okButton = new SimpleButton();
            _okButton.Text = "OK";
            _okButton.DialogResult = DialogResult.OK;
            _okButton.Click += OkButton_Click;

            LayoutControl layoutControl = new LayoutControl();
            layoutControl.Dock = DockStyle.Fill;
            layoutControl.AddItem("Select Skin", _skinComboBox);
            layoutControl.AddItem("", _okButton);

            Controls.Add(layoutControl);

            _skinComboBox.Text = _lookAndFeel.LookAndFeel.SkinName;
        }

        private void SkinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSkinName = _skinComboBox.SelectedItem.ToString();
            _lookAndFeel.LookAndFeel.SkinName = SelectedSkinName;

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            SkinSelected?.Invoke(this, new SkinSelectedEventArgs(SelectedSkinName));
            DialogResult = DialogResult.OK;
        }
    }

    public class SkinSelectedEventArgs : EventArgs
    {
        public string SelectedSkinName { get; private set; }

        public SkinSelectedEventArgs(string selectedSkinName)
        {
            SelectedSkinName = selectedSkinName;

        }
    }
}