﻿namespace HPReserger
{
    partial class fmReporteRemuneracionRenta
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
            this.crvboletas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvboletas
            // 
            this.crvboletas.ActiveViewIndex = -1;
            this.crvboletas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvboletas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvboletas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvboletas.Location = new System.Drawing.Point(0, 0);
            this.crvboletas.Name = "crvboletas";
            this.crvboletas.ShowCloseButton = false;
            this.crvboletas.ShowGroupTreeButton = false;
            this.crvboletas.ShowLogo = false;
            this.crvboletas.ShowParameterPanelButton = false;
            this.crvboletas.Size = new System.Drawing.Size(810, 565);
            this.crvboletas.TabIndex = 1;
            // 
            // fmReporteRemuneracionRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 565);
            this.Controls.Add(this.crvboletas);
            this.Name = "fmReporteRemuneracionRenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Certificado de Remuneracion y Renta de Quinta Categoria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmReporteRemuneracionRenta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvboletas;
    }
}