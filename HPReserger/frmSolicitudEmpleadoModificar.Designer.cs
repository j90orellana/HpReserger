﻿namespace HPReserger
{
    partial class frmSolicitudEmpleadoModificar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCambiar = new System.Windows.Forms.CheckBox();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboOS = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscarJPG = new System.Windows.Forms.Button();
            this.txtPuestos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdjunto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTipoContratacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTerna = new System.Windows.Forms.ComboBox();
            this.cboCargoPuesto = new System.Windows.Forms.ComboBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.txtSolicitud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkCambiar);
            this.groupBox1.Controls.Add(this.txtOS);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboOS);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnBuscarJPG);
            this.groupBox1.Controls.Add(this.txtPuestos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAdjunto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboTipoContratacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboTerna);
            this.groupBox1.Controls.Add(this.cboCargoPuesto);
            this.groupBox1.Controls.Add(this.cboBusqueda);
            this.groupBox1.Controls.Add(this.txtSolicitud);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 243);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkCambiar
            // 
            this.chkCambiar.AutoSize = true;
            this.chkCambiar.Checked = true;
            this.chkCambiar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCambiar.Location = new System.Drawing.Point(237, 51);
            this.chkCambiar.Name = "chkCambiar";
            this.chkCambiar.Size = new System.Drawing.Size(82, 17);
            this.chkCambiar.TabIndex = 34;
            this.chkCambiar.Text = "Cambiar por";
            this.chkCambiar.UseVisualStyleBackColor = true;
            this.chkCambiar.CheckedChanged += new System.EventHandler(this.chkCambiar_CheckedChanged);
            // 
            // txtOS
            // 
            this.txtOS.Location = new System.Drawing.Point(135, 51);
            this.txtOS.Name = "txtOS";
            this.txtOS.ReadOnly = true;
            this.txtOS.Size = new System.Drawing.Size(77, 20);
            this.txtOS.TabIndex = 30;
            this.txtOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Nº Orden de Servicio";
            // 
            // cboOS
            // 
            this.cboOS.BackColor = System.Drawing.Color.White;
            this.cboOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOS.FormattingEnabled = true;
            this.cboOS.Items.AddRange(new object[] {
            "EXTERNA",
            "INTERNA"});
            this.cboOS.Location = new System.Drawing.Point(325, 51);
            this.cboOS.Name = "cboOS";
            this.cboOS.Size = new System.Drawing.Size(75, 21);
            this.cboOS.TabIndex = 28;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(325, 14);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 27;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscarJPG
            // 
            this.btnBuscarJPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarJPG.Location = new System.Drawing.Point(375, 209);
            this.btnBuscarJPG.Name = "btnBuscarJPG";
            this.btnBuscarJPG.Size = new System.Drawing.Size(25, 23);
            this.btnBuscarJPG.TabIndex = 26;
            this.btnBuscarJPG.Text = "...";
            this.btnBuscarJPG.UseVisualStyleBackColor = true;
            this.btnBuscarJPG.Click += new System.EventHandler(this.btnBuscarJPG_Click);
            // 
            // txtPuestos
            // 
            this.txtPuestos.Location = new System.Drawing.Point(355, 113);
            this.txtPuestos.MaxLength = 2;
            this.txtPuestos.Name = "txtPuestos";
            this.txtPuestos.Size = new System.Drawing.Size(45, 20);
            this.txtPuestos.TabIndex = 25;
            this.txtPuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPuestos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuestos_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Cantidad de Puestos";
            // 
            // txtAdjunto
            // 
            this.txtAdjunto.Location = new System.Drawing.Point(135, 209);
            this.txtAdjunto.Name = "txtAdjunto";
            this.txtAdjunto.ReadOnly = true;
            this.txtAdjunto.Size = new System.Drawing.Size(234, 20);
            this.txtAdjunto.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Adjuntar Requerimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tipo de Contratación";
            // 
            // cboTipoContratacion
            // 
            this.cboTipoContratacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoContratacion.FormattingEnabled = true;
            this.cboTipoContratacion.Location = new System.Drawing.Point(135, 178);
            this.cboTipoContratacion.Name = "cboTipoContratacion";
            this.cboTipoContratacion.Size = new System.Drawing.Size(265, 21);
            this.cboTipoContratacion.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cargo del Puesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "¿ Aplica Terna ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Búsqueda";
            // 
            // cboTerna
            // 
            this.cboTerna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTerna.FormattingEnabled = true;
            this.cboTerna.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cboTerna.Location = new System.Drawing.Point(135, 113);
            this.cboTerna.Name = "cboTerna";
            this.cboTerna.Size = new System.Drawing.Size(77, 21);
            this.cboTerna.TabIndex = 16;
            // 
            // cboCargoPuesto
            // 
            this.cboCargoPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCargoPuesto.FormattingEnabled = true;
            this.cboCargoPuesto.Location = new System.Drawing.Point(135, 146);
            this.cboCargoPuesto.Name = "cboCargoPuesto";
            this.cboCargoPuesto.Size = new System.Drawing.Size(265, 21);
            this.cboCargoPuesto.TabIndex = 15;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.BackColor = System.Drawing.Color.White;
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Items.AddRange(new object[] {
            "EXTERNA",
            "INTERNA"});
            this.cboBusqueda.Location = new System.Drawing.Point(135, 81);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(100, 21);
            this.cboBusqueda.TabIndex = 14;
            this.cboBusqueda.SelectedIndexChanged += new System.EventHandler(this.cboBusqueda_SelectedIndexChanged);
            // 
            // txtSolicitud
            // 
            this.txtSolicitud.Location = new System.Drawing.Point(135, 19);
            this.txtSolicitud.Name = "txtSolicitud";
            this.txtSolicitud.ReadOnly = true;
            this.txtSolicitud.Size = new System.Drawing.Size(77, 20);
            this.txtSolicitud.TabIndex = 13;
            this.txtSolicitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nro. de Solicitud";
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(435, 8);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(247, 237);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 14;
            this.pbFoto.TabStop = false;
            this.pbFoto.DoubleClick += new System.EventHandler(this.pbFoto_DoubleClick);
            // 
            // frmSolicitudEmpleadoModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(693, 255);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmSolicitudEmpleadoModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Modificar Solicitud de Empleado";
            this.Load += new System.EventHandler(this.frmSolicitudEmpleadoModificar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscarJPG;
        private System.Windows.Forms.TextBox txtPuestos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdjunto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTipoContratacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTerna;
        private System.Windows.Forms.ComboBox cboCargoPuesto;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.TextBox txtSolicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboOS;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.CheckBox chkCambiar;
    }
}