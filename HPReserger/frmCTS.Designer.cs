namespace HPReserger
{
    partial class frmCTS
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
            this.crvCTS = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvCTS
            // 
            this.crvCTS.ActiveViewIndex = -1;
            this.crvCTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCTS.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCTS.Location = new System.Drawing.Point(0, 0);
            this.crvCTS.Name = "crvCTS";
            this.crvCTS.ShowCloseButton = false;
            this.crvCTS.ShowLogo = false;
            this.crvCTS.Size = new System.Drawing.Size(767, 561);
            this.crvCTS.TabIndex = 0;
            this.crvCTS.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 561);
            this.Controls.Add(this.crvCTS);
            this.Name = "frmCTS";
            this.Text = "  Carta CTS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCTS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCTS;
    }
}