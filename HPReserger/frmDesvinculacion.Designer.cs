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
            this.groupBox2.SuspendLayout();
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
            this.btnGenerarLiquidacion.Location = new System.Drawing.Point(35, 196);
            this.btnGenerarLiquidacion.Name = "btnGenerarLiquidacion";
            this.btnGenerarLiquidacion.Size = new System.Drawing.Size(150, 23);
            this.btnGenerarLiquidacion.TabIndex = 72;
            this.btnGenerarLiquidacion.Text = "Generar Liquidación";
            this.btnGenerarLiquidacion.UseVisualStyleBackColor = true;
            this.btnGenerarLiquidacion.Click += new System.EventHandler(this.btnGenerarLiquidacion_Click);
            // 
            // btnCTS
            // 
            this.btnCTS.Location = new System.Drawing.Point(35, 234);
            this.btnCTS.Name = "btnCTS";
            this.btnCTS.Size = new System.Drawing.Size(150, 23);
            this.btnCTS.TabIndex = 73;
            this.btnCTS.Text = "Constancia CTS";
            this.btnCTS.UseVisualStyleBackColor = true;
            this.btnCTS.Click += new System.EventHandler(this.btnCTS_Click);
            // 
            // btnConstanciaTrabajo
            // 
            this.btnConstanciaTrabajo.Location = new System.Drawing.Point(35, 273);
            this.btnConstanciaTrabajo.Name = "btnConstanciaTrabajo";
            this.btnConstanciaTrabajo.Size = new System.Drawing.Size(150, 23);
            this.btnConstanciaTrabajo.TabIndex = 74;
            this.btnConstanciaTrabajo.Text = "Constancia de trabajo";
            this.btnConstanciaTrabajo.UseVisualStyleBackColor = true;
            this.btnConstanciaTrabajo.Click += new System.EventHandler(this.btnConstanciaTrabajo_Click);
            // 
            // btnRetencionRenta
            // 
            this.btnRetencionRenta.Location = new System.Drawing.Point(207, 196);
            this.btnRetencionRenta.Name = "btnRetencionRenta";
            this.btnRetencionRenta.Size = new System.Drawing.Size(150, 23);
            this.btnRetencionRenta.TabIndex = 75;
            this.btnRetencionRenta.Text = "Retención Renta";
            this.btnRetencionRenta.UseVisualStyleBackColor = true;
            this.btnRetencionRenta.Click += new System.EventHandler(this.btnRetencionRenta_Click);
            // 
            // btnEvaluacionPracticas
            // 
            this.btnEvaluacionPracticas.Location = new System.Drawing.Point(207, 234);
            this.btnEvaluacionPracticas.Name = "btnEvaluacionPracticas";
            this.btnEvaluacionPracticas.Size = new System.Drawing.Size(150, 23);
            this.btnEvaluacionPracticas.TabIndex = 76;
            this.btnEvaluacionPracticas.Text = "Evaluación de Practicas";
            this.btnEvaluacionPracticas.UseVisualStyleBackColor = true;
            this.btnEvaluacionPracticas.Click += new System.EventHandler(this.btnEvaluacionPracticas_Click);
            // 
            // btnEntrevistaSalida
            // 
            this.btnEntrevistaSalida.Location = new System.Drawing.Point(207, 273);
            this.btnEntrevistaSalida.Name = "btnEntrevistaSalida";
            this.btnEntrevistaSalida.Size = new System.Drawing.Size(150, 23);
            this.btnEntrevistaSalida.TabIndex = 77;
            this.btnEntrevistaSalida.Text = "Entrevista de Salida";
            this.btnEntrevistaSalida.UseVisualStyleBackColor = true;
            this.btnEntrevistaSalida.Click += new System.EventHandler(this.btnEntrevistaSalida_Click);
            // 
            // frmDesvinculacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(398, 311);
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
            this.ResumeLayout(false);

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
    }
}