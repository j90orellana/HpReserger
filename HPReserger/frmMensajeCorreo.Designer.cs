﻿namespace HPReserger
{
    partial class frmMensajeCorreo
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
            this.btnenviar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtasunto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboprioridad = new System.Windows.Forms.ComboBox();
            this.btnadjuntar = new System.Windows.Forms.Button();
            this.Openfiledatos = new System.Windows.Forms.OpenFileDialog();
            this.lbldatos = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtmsg = new System.Windows.Forms.RichTextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnenviar
            // 
            this.btnenviar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnenviar.Location = new System.Drawing.Point(155, 326);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(101, 27);
            this.btnenviar.TabIndex = 2;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncancelar.Location = new System.Drawing.Point(262, 326);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(101, 27);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Asunto:";
            // 
            // txtasunto
            // 
            this.txtasunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtasunto.Location = new System.Drawing.Point(69, 29);
            this.txtasunto.Name = "txtasunto";
            this.txtasunto.Size = new System.Drawing.Size(418, 20);
            this.txtasunto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prioridad:";
            // 
            // cboprioridad
            // 
            this.cboprioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboprioridad.FormattingEnabled = true;
            this.cboprioridad.Location = new System.Drawing.Point(69, 52);
            this.cboprioridad.Name = "cboprioridad";
            this.cboprioridad.Size = new System.Drawing.Size(129, 21);
            this.cboprioridad.TabIndex = 5;
            // 
            // btnadjuntar
            // 
            this.btnadjuntar.Location = new System.Drawing.Point(204, 52);
            this.btnadjuntar.Name = "btnadjuntar";
            this.btnadjuntar.Size = new System.Drawing.Size(54, 21);
            this.btnadjuntar.TabIndex = 8;
            this.btnadjuntar.Text = "Adjuntar";
            this.btnadjuntar.UseVisualStyleBackColor = true;
            this.btnadjuntar.Click += new System.EventHandler(this.btnadjuntar_Click);
            // 
            // lbldatos
            // 
            this.lbldatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldatos.Location = new System.Drawing.Point(264, 54);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(223, 21);
            this.lbldatos.TabIndex = 9;
            this.lbldatos.Click += new System.EventHandler(this.lbldatos_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontDialog1.ShowColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuenteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 26);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // txtmsg
            // 
            this.txtmsg.AcceptsTab = true;
            this.txtmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmsg.AutoWordSelection = true;
            this.txtmsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmsg.EnableAutoDragDrop = true;
            this.txtmsg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmsg.Location = new System.Drawing.Point(12, 78);
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.ShowSelectionMargin = true;
            this.txtmsg.Size = new System.Drawing.Size(472, 242);
            this.txtmsg.TabIndex = 59;
            this.txtmsg.Text = "";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcorreo.Location = new System.Drawing.Point(69, 6);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(418, 20);
            this.txtcorreo.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Correo:";
            // 
            // frmMensajeCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 364);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmsg);
            this.Controls.Add(this.lbldatos);
            this.Controls.Add(this.btnadjuntar);
            this.Controls.Add(this.cboprioridad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtasunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnenviar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(515, 403);
            this.Name = "frmMensajeCorreo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envío de e-mail";
            this.Load += new System.EventHandler(this.frmMensajeCorreo_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtasunto;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cboprioridad;
        private System.Windows.Forms.Button btnadjuntar;
        private System.Windows.Forms.OpenFileDialog Openfiledatos;
        private System.Windows.Forms.Label lbldatos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        public System.Windows.Forms.FontDialog fontDialog1;
        public System.Windows.Forms.RichTextBox txtmsg;
        public System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label1;
    }
}