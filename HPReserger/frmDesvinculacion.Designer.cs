namespace HPReserger
{
    partial class frmDesvinculacion
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarLiquidacion = new System.Windows.Forms.Button();
            this.btnCTS = new System.Windows.Forms.Button();
            this.btnConstanciaTrabajo = new System.Windows.Forms.Button();
            this.btnRetencionRenta = new System.Windows.Forms.Button();
            this.btnEvaluacionPracticas = new System.Windows.Forms.Button();
            this.btnEntrevistaSalida = new System.Windows.Forms.Button();
            this.btnAdjuntarLiq = new System.Windows.Forms.Button();
            this.btnAdjuntarCTS = new System.Windows.Forms.Button();
            this.btnAdjuntarEntrevistaSalida = new System.Windows.Forms.Button();
            this.btnAdjuntarEvaluacionPracticas = new System.Windows.Forms.Button();
            this.btnAdjuntarRetencionRenta = new System.Windows.Forms.Button();
            this.btnAdjuntarConstanciaTrabajo = new System.Windows.Forms.Button();
            this.txtLiq = new System.Windows.Forms.TextBox();
            this.txtRetencionRenta = new System.Windows.Forms.TextBox();
            this.txtConstanciaTrabajo = new System.Windows.Forms.TextBox();
            this.txtCTS = new System.Windows.Forms.TextBox();
            this.txtEntrevistaSalida = new System.Windows.Forms.TextBox();
            this.txtEvaluacionPracticas = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNumeroDocumento);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtApellidoPaterno);
            this.groupBox2.Controls.Add(this.txtApellidoMaterno);
            this.groupBox2.Controls.Add(this.txtNombres);
            this.groupBox2.Controls.Add(this.cboTipoDocumento);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 175);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(195, 51);
            this.txtNumeroDocumento.MaxLength = 14;
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(118, 20);
            this.txtNumeroDocumento.TabIndex = 78;
            this.txtNumeroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroDocumento.TextChanged += new System.EventHandler(this.txtNumeroDocumento_TextChanged);
            this.txtNumeroDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroDocumento_KeyDown);
            this.txtNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDocumento_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Número de Documento de Identidad";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(195, 82);
            this.txtApellidoPaterno.MaxLength = 30;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.ReadOnly = true;
            this.txtApellidoPaterno.Size = new System.Drawing.Size(161, 20);
            this.txtApellidoPaterno.TabIndex = 76;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(195, 113);
            this.txtApellidoMaterno.MaxLength = 30;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.ReadOnly = true;
            this.txtApellidoMaterno.Size = new System.Drawing.Size(161, 20);
            this.txtApellidoMaterno.TabIndex = 75;
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Location = new System.Drawing.Point(195, 144);
            this.txtNombres.MaxLength = 30;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.ShortcutsEnabled = false;
            this.txtNombres.Size = new System.Drawing.Size(161, 20);
            this.txtNombres.TabIndex = 74;
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(195, 19);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(161, 21);
            this.cboTipoDocumento.TabIndex = 73;
            this.cboTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cboTipoDocumento_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Apellido Paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Tipo de Documento de Identidad";
            // 
            // btnGenerarLiquidacion
            // 
            this.btnGenerarLiquidacion.Location = new System.Drawing.Point(12, 194);
            this.btnGenerarLiquidacion.Name = "btnGenerarLiquidacion";
            this.btnGenerarLiquidacion.Size = new System.Drawing.Size(150, 23);
            this.btnGenerarLiquidacion.TabIndex = 72;
            this.btnGenerarLiquidacion.Text = "Generar Liquidación";
            this.btnGenerarLiquidacion.UseVisualStyleBackColor = true;
            this.btnGenerarLiquidacion.Click += new System.EventHandler(this.btnGenerarLiquidacion_Click);
            // 
            // btnCTS
            // 
            this.btnCTS.Location = new System.Drawing.Point(12, 232);
            this.btnCTS.Name = "btnCTS";
            this.btnCTS.Size = new System.Drawing.Size(150, 23);
            this.btnCTS.TabIndex = 73;
            this.btnCTS.Text = "Constancia CTS";
            this.btnCTS.UseVisualStyleBackColor = true;
            this.btnCTS.Click += new System.EventHandler(this.btnCTS_Click);
            // 
            // btnConstanciaTrabajo
            // 
            this.btnConstanciaTrabajo.Location = new System.Drawing.Point(12, 271);
            this.btnConstanciaTrabajo.Name = "btnConstanciaTrabajo";
            this.btnConstanciaTrabajo.Size = new System.Drawing.Size(150, 23);
            this.btnConstanciaTrabajo.TabIndex = 74;
            this.btnConstanciaTrabajo.Text = "Constancia de trabajo";
            this.btnConstanciaTrabajo.UseVisualStyleBackColor = true;
            this.btnConstanciaTrabajo.Click += new System.EventHandler(this.btnConstanciaTrabajo_Click);
            // 
            // btnRetencionRenta
            // 
            this.btnRetencionRenta.Location = new System.Drawing.Point(12, 310);
            this.btnRetencionRenta.Name = "btnRetencionRenta";
            this.btnRetencionRenta.Size = new System.Drawing.Size(150, 23);
            this.btnRetencionRenta.TabIndex = 75;
            this.btnRetencionRenta.Text = "Retención Renta";
            this.btnRetencionRenta.UseVisualStyleBackColor = true;
            this.btnRetencionRenta.Click += new System.EventHandler(this.btnRetencionRenta_Click);
            // 
            // btnEvaluacionPracticas
            // 
            this.btnEvaluacionPracticas.Location = new System.Drawing.Point(12, 348);
            this.btnEvaluacionPracticas.Name = "btnEvaluacionPracticas";
            this.btnEvaluacionPracticas.Size = new System.Drawing.Size(150, 23);
            this.btnEvaluacionPracticas.TabIndex = 76;
            this.btnEvaluacionPracticas.Text = "Evaluación de Practicas";
            this.btnEvaluacionPracticas.UseVisualStyleBackColor = true;
            this.btnEvaluacionPracticas.Click += new System.EventHandler(this.btnEvaluacionPracticas_Click);
            // 
            // btnEntrevistaSalida
            // 
            this.btnEntrevistaSalida.Location = new System.Drawing.Point(12, 387);
            this.btnEntrevistaSalida.Name = "btnEntrevistaSalida";
            this.btnEntrevistaSalida.Size = new System.Drawing.Size(150, 23);
            this.btnEntrevistaSalida.TabIndex = 77;
            this.btnEntrevistaSalida.Text = "Entrevista de Salida";
            this.btnEntrevistaSalida.UseVisualStyleBackColor = true;
            this.btnEntrevistaSalida.Click += new System.EventHandler(this.btnEntrevistaSalida_Click);
            // 
            // btnAdjuntarLiq
            // 
            this.btnAdjuntarLiq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjuntarLiq.Location = new System.Drawing.Point(168, 194);
            this.btnAdjuntarLiq.Name = "btnAdjuntarLiq";
            this.btnAdjuntarLiq.Size = new System.Drawing.Size(25, 23);
            this.btnAdjuntarLiq.TabIndex = 78;
            this.btnAdjuntarLiq.Text = "...";
            this.btnAdjuntarLiq.UseVisualStyleBackColor = true;
            this.btnAdjuntarLiq.Click += new System.EventHandler(this.btnAdjuntarLiq_Click);
            // 
            // btnAdjuntarCTS
            // 
            this.btnAdjuntarCTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjuntarCTS.Location = new System.Drawing.Point(168, 232);
            this.btnAdjuntarCTS.Name = "btnAdjuntarCTS";
            this.btnAdjuntarCTS.Size = new System.Drawing.Size(25, 23);
            this.btnAdjuntarCTS.TabIndex = 79;
            this.btnAdjuntarCTS.Text = "...";
            this.btnAdjuntarCTS.UseVisualStyleBackColor = true;
            this.btnAdjuntarCTS.Click += new System.EventHandler(this.btnAdjuntarCTS_Click);
            // 
            // btnAdjuntarEntrevistaSalida
            // 
            this.btnAdjuntarEntrevistaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjuntarEntrevistaSalida.Location = new System.Drawing.Point(168, 387);
            this.btnAdjuntarEntrevistaSalida.Name = "btnAdjuntarEntrevistaSalida";
            this.btnAdjuntarEntrevistaSalida.Size = new System.Drawing.Size(25, 23);
            this.btnAdjuntarEntrevistaSalida.TabIndex = 81;
            this.btnAdjuntarEntrevistaSalida.Text = "...";
            this.btnAdjuntarEntrevistaSalida.UseVisualStyleBackColor = true;
            this.btnAdjuntarEntrevistaSalida.Click += new System.EventHandler(this.btnAdjuntarEntrevistaSalida_Click);
            // 
            // btnAdjuntarEvaluacionPracticas
            // 
            this.btnAdjuntarEvaluacionPracticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjuntarEvaluacionPracticas.Location = new System.Drawing.Point(168, 348);
            this.btnAdjuntarEvaluacionPracticas.Name = "btnAdjuntarEvaluacionPracticas";
            this.btnAdjuntarEvaluacionPracticas.Size = new System.Drawing.Size(25, 23);
            this.btnAdjuntarEvaluacionPracticas.TabIndex = 82;
            this.btnAdjuntarEvaluacionPracticas.Text = "...";
            this.btnAdjuntarEvaluacionPracticas.UseVisualStyleBackColor = true;
            this.btnAdjuntarEvaluacionPracticas.Click += new System.EventHandler(this.btnAdjuntarEvaluacionPracticas_Click);
            // 
            // btnAdjuntarRetencionRenta
            // 
            this.btnAdjuntarRetencionRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjuntarRetencionRenta.Location = new System.Drawing.Point(168, 310);
            this.btnAdjuntarRetencionRenta.Name = "btnAdjuntarRetencionRenta";
            this.btnAdjuntarRetencionRenta.Size = new System.Drawing.Size(25, 23);
            this.btnAdjuntarRetencionRenta.TabIndex = 83;
            this.btnAdjuntarRetencionRenta.Text = "...";
            this.btnAdjuntarRetencionRenta.UseVisualStyleBackColor = true;
            this.btnAdjuntarRetencionRenta.Click += new System.EventHandler(this.btnAdjuntarRetencionRenta_Click);
            // 
            // btnAdjuntarConstanciaTrabajo
            // 
            this.btnAdjuntarConstanciaTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjuntarConstanciaTrabajo.Location = new System.Drawing.Point(168, 271);
            this.btnAdjuntarConstanciaTrabajo.Name = "btnAdjuntarConstanciaTrabajo";
            this.btnAdjuntarConstanciaTrabajo.Size = new System.Drawing.Size(25, 23);
            this.btnAdjuntarConstanciaTrabajo.TabIndex = 84;
            this.btnAdjuntarConstanciaTrabajo.Text = "...";
            this.btnAdjuntarConstanciaTrabajo.UseVisualStyleBackColor = true;
            this.btnAdjuntarConstanciaTrabajo.Click += new System.EventHandler(this.btnAdjuntarConstanciaTrabajo_Click);
            // 
            // txtLiq
            // 
            this.txtLiq.Location = new System.Drawing.Point(207, 194);
            this.txtLiq.MaxLength = 14;
            this.txtLiq.Name = "txtLiq";
            this.txtLiq.ReadOnly = true;
            this.txtLiq.Size = new System.Drawing.Size(178, 20);
            this.txtLiq.TabIndex = 85;
            this.txtLiq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRetencionRenta
            // 
            this.txtRetencionRenta.Location = new System.Drawing.Point(207, 310);
            this.txtRetencionRenta.MaxLength = 14;
            this.txtRetencionRenta.Name = "txtRetencionRenta";
            this.txtRetencionRenta.ReadOnly = true;
            this.txtRetencionRenta.Size = new System.Drawing.Size(178, 20);
            this.txtRetencionRenta.TabIndex = 86;
            this.txtRetencionRenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtConstanciaTrabajo
            // 
            this.txtConstanciaTrabajo.Location = new System.Drawing.Point(207, 271);
            this.txtConstanciaTrabajo.MaxLength = 14;
            this.txtConstanciaTrabajo.Name = "txtConstanciaTrabajo";
            this.txtConstanciaTrabajo.ReadOnly = true;
            this.txtConstanciaTrabajo.Size = new System.Drawing.Size(178, 20);
            this.txtConstanciaTrabajo.TabIndex = 87;
            this.txtConstanciaTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCTS
            // 
            this.txtCTS.Location = new System.Drawing.Point(207, 232);
            this.txtCTS.MaxLength = 14;
            this.txtCTS.Name = "txtCTS";
            this.txtCTS.ReadOnly = true;
            this.txtCTS.Size = new System.Drawing.Size(178, 20);
            this.txtCTS.TabIndex = 88;
            this.txtCTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEntrevistaSalida
            // 
            this.txtEntrevistaSalida.Location = new System.Drawing.Point(207, 387);
            this.txtEntrevistaSalida.MaxLength = 14;
            this.txtEntrevistaSalida.Name = "txtEntrevistaSalida";
            this.txtEntrevistaSalida.ReadOnly = true;
            this.txtEntrevistaSalida.Size = new System.Drawing.Size(178, 20);
            this.txtEntrevistaSalida.TabIndex = 89;
            this.txtEntrevistaSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEvaluacionPracticas
            // 
            this.txtEvaluacionPracticas.Location = new System.Drawing.Point(207, 348);
            this.txtEvaluacionPracticas.MaxLength = 14;
            this.txtEvaluacionPracticas.Name = "txtEvaluacionPracticas";
            this.txtEvaluacionPracticas.ReadOnly = true;
            this.txtEvaluacionPracticas.Size = new System.Drawing.Size(178, 20);
            this.txtEvaluacionPracticas.TabIndex = 90;
            this.txtEvaluacionPracticas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(402, 10);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(322, 400);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 105;
            this.pbFoto.TabStop = false;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(402, 416);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(123, 23);
            this.btnGrabar.TabIndex = 107;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // frmDesvinculacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(735, 447);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.txtEvaluacionPracticas);
            this.Controls.Add(this.txtEntrevistaSalida);
            this.Controls.Add(this.txtCTS);
            this.Controls.Add(this.txtConstanciaTrabajo);
            this.Controls.Add(this.txtRetencionRenta);
            this.Controls.Add(this.txtLiq);
            this.Controls.Add(this.btnAdjuntarConstanciaTrabajo);
            this.Controls.Add(this.btnAdjuntarRetencionRenta);
            this.Controls.Add(this.btnAdjuntarEvaluacionPracticas);
            this.Controls.Add(this.btnAdjuntarEntrevistaSalida);
            this.Controls.Add(this.btnAdjuntarCTS);
            this.Controls.Add(this.btnAdjuntarLiq);
            this.Controls.Add(this.btnEntrevistaSalida);
            this.Controls.Add(this.btnEvaluacionPracticas);
            this.Controls.Add(this.btnRetencionRenta);
            this.Controls.Add(this.btnConstanciaTrabajo);
            this.Controls.Add(this.btnCTS);
            this.Controls.Add(this.btnGenerarLiquidacion);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "frmDesvinculacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Desvinculación";
            this.Load += new System.EventHandler(this.frmDesvinculacion_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarLiquidacion;
        private System.Windows.Forms.Button btnCTS;
        private System.Windows.Forms.Button btnConstanciaTrabajo;
        private System.Windows.Forms.Button btnRetencionRenta;
        private System.Windows.Forms.Button btnEvaluacionPracticas;
        private System.Windows.Forms.Button btnEntrevistaSalida;
        private System.Windows.Forms.Button btnAdjuntarLiq;
        private System.Windows.Forms.Button btnAdjuntarCTS;
        private System.Windows.Forms.Button btnAdjuntarEntrevistaSalida;
        private System.Windows.Forms.Button btnAdjuntarEvaluacionPracticas;
        private System.Windows.Forms.Button btnAdjuntarRetencionRenta;
        private System.Windows.Forms.Button btnAdjuntarConstanciaTrabajo;
        private System.Windows.Forms.TextBox txtLiq;
        private System.Windows.Forms.TextBox txtRetencionRenta;
        private System.Windows.Forms.TextBox txtConstanciaTrabajo;
        private System.Windows.Forms.TextBox txtCTS;
        private System.Windows.Forms.TextBox txtEntrevistaSalida;
        private System.Windows.Forms.TextBox txtEvaluacionPracticas;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnGrabar;
    }
}