namespace HPReserger.ModuloCompensaciones
{
    partial class frmCompensacionCuentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboempresa = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboempresa
            // 
            this.cboempresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboempresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.DropDownWidth = 250;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.Location = new System.Drawing.Point(68, 12);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.Size = new System.Drawing.Size(344, 21);
            this.cboempresa.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(15, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Empresa:";
            // 
            // frmCompensacionCuentas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(750, 587);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.label18);
            this.Name = "frmCompensacionCuentas";
            this.Nombre = "Compensación de Cuentas";
            this.Text = "Compensación de Cuentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboempresa;
        private System.Windows.Forms.Label label18;
    }
}