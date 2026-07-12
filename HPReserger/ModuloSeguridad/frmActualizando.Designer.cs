
using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SISGEM.ModuloSeguridad
{
    partial class frmActualizando
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
            this.lblTitulo = new LabelControl();
            this.lblMensaje = new LabelControl();
            this.progressBar = new MarqueeProgressBarControl();

            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).BeginInit();
            this.SuspendLayout();

            // Formulario
            this.Text = "Actualizando";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMost = true;
            this.ClientSize = new Size(500, 180);

            // Título
            this.lblTitulo.Appearance.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitulo.AutoSizeMode = LabelAutoSizeMode.None;
            this.lblTitulo.Location = new Point(20, 20);
            this.lblTitulo.Size = new Size(460, 35);
            this.lblTitulo.Text = "ACTUALIZANDO SISTEMA";

            // Mensaje
            this.lblMensaje.Appearance.Font = new Font("Segoe UI", 10F);
            this.lblMensaje.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblMensaje.AutoSizeMode = LabelAutoSizeMode.None;
            this.lblMensaje.Location = new Point(20, 65);
            this.lblMensaje.Size = new Size(460, 50);
            this.lblMensaje.Text =
                "Se está descargando e instalando la nueva versión.\r\n" +
                "Por favor espere y no cierre la aplicación.";

            // Barra progreso
            this.progressBar.Location = new Point(30, 125);
            this.progressBar.Size = new Size(440, 25);

            // Agregar controles
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.progressBar);

            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).EndInit();
            this.ResumeLayout(false);
        }



        #endregion
    }
}