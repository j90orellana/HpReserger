﻿namespace ProyectoDashboardCitas
{
    partial class DesignerForm1
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
            this.components = new System.ComponentModel.Container();
            DevExpress.DashboardWin.Native.DashboardBarAndDockingController dashboardBarAndDockingController1 = new DevExpress.DashboardWin.Native.DashboardBarAndDockingController();
            this.dashboardDesigner = new DevExpress.DashboardWin.DashboardDesigner();
            ((System.ComponentModel.ISupportInitialize)(dashboardBarAndDockingController1)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardDesigner
            // 
            this.dashboardDesigner.AllowMaximizeAnimation = true;
            this.dashboardDesigner.AllowMaximizeDashboardItems = true;
            this.dashboardDesigner.AllowPrintDashboard = true;
            this.dashboardDesigner.AllowPrintDashboardItems = true;
            this.dashboardDesigner.AsyncMode = true;
            dashboardBarAndDockingController1.PropertiesDocking.ViewStyle = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Classic;
            this.dashboardDesigner.BarAndDockingController = dashboardBarAndDockingController1;
            this.dashboardDesigner.DataSourceWizard.ShowConnectionsFromAppConfig = true;
            this.dashboardDesigner.DataSourceWizard.SqlWizardSettings.DatabaseCredentialsSavingBehavior = DevExpress.DataAccess.Wizard.SensitiveInfoSavingBehavior.Prompt;
            this.dashboardDesigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardDesigner.Location = new System.Drawing.Point(0, 0);
            this.dashboardDesigner.Name = "dashboardDesigner";
            this.dashboardDesigner.Size = new System.Drawing.Size(1190, 595);
            this.dashboardDesigner.TabIndex = 0;
            this.dashboardDesigner.UseNeutralFilterMode = true;
            // 
            // DesignerForm1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 595);
            this.Controls.Add(this.dashboardDesigner);
            this.Name = "DesignerForm1";
            this.Text = "Dashboard Designer";
            ((System.ComponentModel.ISupportInitialize)(dashboardBarAndDockingController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.DashboardWin.DashboardDesigner dashboardDesigner;
    }
}