namespace HPReserger
{
    partial class frmVerPdf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerPdf));
            this.AdbVer = new AxAcroPDFLib.AxAcroPDF();
            this.dtgconten = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdbVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // AdbVer
            // 
            this.AdbVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdbVer.Enabled = true;
            this.AdbVer.Location = new System.Drawing.Point(0, 0);
            this.AdbVer.Name = "AdbVer";
            this.AdbVer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AdbVer.OcxState")));
            this.AdbVer.Size = new System.Drawing.Size(897, 670);
            this.AdbVer.TabIndex = 0;
            this.AdbVer.Enter += new System.EventHandler(this.AdbVer_Enter);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.Location = new System.Drawing.Point(91, 60);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.Size = new System.Drawing.Size(464, 226);
            this.dtgconten.TabIndex = 1;
            this.dtgconten.Visible = false;
            this.dtgconten.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellDoubleClick);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(571, 60);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Visible = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // frmVerPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 670);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.AdbVer);
            this.Name = "frmVerPdf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVerPdf";
            this.Load += new System.EventHandler(this.frmVerPdf_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVerPdf_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.AdbVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF AdbVer;
        private System.Windows.Forms.DataGridView dtgconten;
        private System.Windows.Forms.Button btnadd;
    }
}