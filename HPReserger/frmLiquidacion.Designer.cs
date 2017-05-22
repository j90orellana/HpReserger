namespace HPReserger
{
    partial class frmLiquidacion
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
            this.cvrLiquidacion = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptLiquidacion1 = new HPReserger.rptLiquidacion();
            this.SuspendLayout();
            // 
            // cvrLiquidacion
            // 
            this.cvrLiquidacion.ActiveViewIndex = -1;
            this.cvrLiquidacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cvrLiquidacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.cvrLiquidacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cvrLiquidacion.Location = new System.Drawing.Point(0, 0);
            this.cvrLiquidacion.Name = "cvrLiquidacion";
            this.cvrLiquidacion.ShowCloseButton = false;
            this.cvrLiquidacion.ShowGroupTreeButton = false;
            this.cvrLiquidacion.ShowLogo = false;
            this.cvrLiquidacion.ShowParameterPanelButton = false;
            this.cvrLiquidacion.Size = new System.Drawing.Size(930, 665);
            this.cvrLiquidacion.TabIndex = 0;
            this.cvrLiquidacion.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(930, 665);
            this.Controls.Add(this.cvrLiquidacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLiquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "  Liquidación de Beneficios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLiquidacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cvrLiquidacion;
        private rptLiquidacion rptLiquidacion1;
    }
}