namespace HPReserger
{
    partial class frmMemoPremio
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
            this.crvMemoPremio = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvMemoPremio
            // 
            this.crvMemoPremio.ActiveViewIndex = -1;
            this.crvMemoPremio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvMemoPremio.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvMemoPremio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvMemoPremio.Location = new System.Drawing.Point(0, 0);
            this.crvMemoPremio.Name = "crvMemoPremio";
            this.crvMemoPremio.ShowCloseButton = false;
            this.crvMemoPremio.ShowGroupTreeButton = false;
            this.crvMemoPremio.ShowLogo = false;
            this.crvMemoPremio.ShowParameterPanelButton = false;
            this.crvMemoPremio.Size = new System.Drawing.Size(798, 612);
            this.crvMemoPremio.TabIndex = 0;
            this.crvMemoPremio.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvMemoPremio.ReportRefresh += new CrystalDecisions.Windows.Forms.RefreshEventHandler(this.crvMemoPremio_ReportRefresh);
            // 
            // frmMemoPremio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 612);
            this.Controls.Add(this.crvMemoPremio);
            this.Name = "frmMemoPremio";
            this.Text = "  Memorandum y/o Cartas de Felicitación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMemoPremio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvMemoPremio;
    }
}