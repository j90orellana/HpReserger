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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMensajeCorreo));
            this.btnenviar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboprioridad = new System.Windows.Forms.ComboBox();
            this.btnadjuntar = new System.Windows.Forms.Button();
            this.Openfiledatos = new System.Windows.Forms.OpenFileDialog();
            this.lbldatos = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtmsg = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtcorreo = new HpResergerUserControls.TextBoxPer();
            this.txtasunto = new HpResergerUserControls.TextBoxPer();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnenviar
            // 
            this.btnenviar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnenviar.Image = ((System.Drawing.Image)(resources.GetObject("btnenviar.Image")));
            this.btnenviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnenviar.Location = new System.Drawing.Point(165, 332);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(82, 24);
            this.btnenviar.TabIndex = 2;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.Location = new System.Drawing.Point(251, 332);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 24);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(20, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Asunto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prioridad:";
            // 
            // cboprioridad
            // 
            this.cboprioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboprioridad.FormattingEnabled = true;
            this.cboprioridad.Location = new System.Drawing.Point(66, 53);
            this.cboprioridad.Name = "cboprioridad";
            this.cboprioridad.Size = new System.Drawing.Size(128, 21);
            this.cboprioridad.TabIndex = 5;
            // 
            // btnadjuntar
            // 
            this.btnadjuntar.Image = ((System.Drawing.Image)(resources.GetObject("btnadjuntar.Image")));
            this.btnadjuntar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadjuntar.Location = new System.Drawing.Point(199, 51);
            this.btnadjuntar.Name = "btnadjuntar";
            this.btnadjuntar.Size = new System.Drawing.Size(82, 24);
            this.btnadjuntar.TabIndex = 8;
            this.btnadjuntar.Text = "Adjuntar";
            this.btnadjuntar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadjuntar.UseVisualStyleBackColor = true;
            this.btnadjuntar.Click += new System.EventHandler(this.btnadjuntar_Click);
            // 
            // lbldatos
            // 
            this.lbldatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldatos.BackColor = System.Drawing.Color.Transparent;
            this.lbldatos.Location = new System.Drawing.Point(292, 53);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(195, 21);
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
            this.txtmsg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmsg.Location = new System.Drawing.Point(12, 77);
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.ShowSelectionMargin = true;
            this.txtmsg.Size = new System.Drawing.Size(475, 249);
            this.txtmsg.TabIndex = 59;
            this.txtmsg.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Correo:";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcorreo.BackColor = System.Drawing.Color.White;
            this.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcorreo.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtcorreo.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.ForeColor = System.Drawing.Color.Black;
            this.txtcorreo.Format = null;
            this.txtcorreo.Location = new System.Drawing.Point(66, 6);
            this.txtcorreo.MaxLength = 5000;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.NextControlOnEnter = null;
            this.txtcorreo.Size = new System.Drawing.Size(421, 21);
            this.txtcorreo.TabIndex = 247;
            this.txtcorreo.Text = "Ingrese Correo";
            this.txtcorreo.TextoDefecto = "Ingrese Correo";
            this.txtcorreo.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtcorreo.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.toolTip1.SetToolTip(this.txtcorreo, "Ingrese Correos Separados de: ;");
            // 
            // txtasunto
            // 
            this.txtasunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtasunto.BackColor = System.Drawing.Color.White;
            this.txtasunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtasunto.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtasunto.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtasunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtasunto.ForeColor = System.Drawing.Color.Black;
            this.txtasunto.Format = null;
            this.txtasunto.Location = new System.Drawing.Point(66, 29);
            this.txtasunto.MaxLength = 5000;
            this.txtasunto.Name = "txtasunto";
            this.txtasunto.NextControlOnEnter = null;
            this.txtasunto.Size = new System.Drawing.Size(421, 21);
            this.txtasunto.TabIndex = 247;
            this.txtasunto.Text = "Ingrese Asunto Del Correo";
            this.txtasunto.TextoDefecto = "Ingrese Asunto del Correo";
            this.txtasunto.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtasunto.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // frmMensajeCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 364);
            this.Controls.Add(this.txtasunto);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmsg);
            this.Controls.Add(this.lbldatos);
            this.Controls.Add(this.btnadjuntar);
            this.Controls.Add(this.cboprioridad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnenviar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(515, 403);
            this.Name = "frmMensajeCorreo";
            this.Nombre = "Envío de Correo Electrónico";
            this.Text = "Envío de Correo Electrónico";
            this.Load += new System.EventHandler(this.frmMensajeCorreo_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cboprioridad;
        private System.Windows.Forms.Button btnadjuntar;
        private System.Windows.Forms.Label lbldatos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        public System.Windows.Forms.FontDialog fontDialog1;
        public System.Windows.Forms.RichTextBox txtmsg;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.OpenFileDialog Openfiledatos;
        private System.Windows.Forms.ToolTip toolTip1;
        public HpResergerUserControls.TextBoxPer txtcorreo;
        public HpResergerUserControls.TextBoxPer txtasunto;
    }
}