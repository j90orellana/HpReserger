using HpResergerUserControls;

namespace HPReserger
{
    partial class FrmConfiguracionBalanceSituacionFinanciera
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracionBalanceSituacionFinanciera));
            this.Dtgconten = new HpResergerUserControls.Dtgconten();
            this.codRealx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuentasx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.lblmsg2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtcuentas = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btndetalle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numPos = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Dtgconten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPos)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtgconten
            // 
            this.Dtgconten.AllowUserToAddRows = false;
            this.Dtgconten.AllowUserToDeleteRows = false;
            this.Dtgconten.AllowUserToOrderColumns = true;
            this.Dtgconten.AllowUserToResizeColumns = false;
            this.Dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.Dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.Dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codRealx,
            this.posix,
            this.Codigox,
            this.descripcionx,
            this.Cuentasx,
            this.usuariox,
            this.fechax});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dtgconten.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dtgconten.EnableHeadersVisualStyles = false;
            this.Dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.Dtgconten.Location = new System.Drawing.Point(12, 88);
            this.Dtgconten.MultiSelect = false;
            this.Dtgconten.Name = "Dtgconten";
            this.Dtgconten.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dtgconten.RowHeadersVisible = false;
            this.Dtgconten.RowTemplate.Height = 16;
            this.Dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dtgconten.Size = new System.Drawing.Size(561, 407);
            this.Dtgconten.TabIndex = 158;
            this.Dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_CellContentClick);
            this.Dtgconten.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_CellDoubleClick);
            this.Dtgconten.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Dtgconten_DataError);
            this.Dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_RowEnter);
            // 
            // codRealx
            // 
            this.codRealx.DataPropertyName = "codreal";
            this.codRealx.HeaderText = "codigoreal";
            this.codRealx.Name = "codRealx";
            this.codRealx.Visible = false;
            // 
            // posix
            // 
            this.posix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.posix.DataPropertyName = "posicion";
            this.posix.HeaderText = "Pos";
            this.posix.MinimumWidth = 40;
            this.posix.Name = "posix";
            this.posix.ReadOnly = true;
            this.posix.Width = 40;
            // 
            // Codigox
            // 
            this.Codigox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Codigox.DataPropertyName = "cod_balance";
            this.Codigox.HeaderText = "Código";
            this.Codigox.MinimumWidth = 50;
            this.Codigox.Name = "Codigox";
            this.Codigox.ReadOnly = true;
            this.Codigox.Width = 70;
            // 
            // descripcionx
            // 
            this.descripcionx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionx.DataPropertyName = "Nombre_balance";
            this.descripcionx.HeaderText = "Descripción";
            this.descripcionx.MinimumWidth = 250;
            this.descripcionx.Name = "descripcionx";
            this.descripcionx.ReadOnly = true;
            // 
            // Cuentasx
            // 
            this.Cuentasx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cuentasx.DataPropertyName = "cuenta_contable";
            this.Cuentasx.HeaderText = "Cuentas";
            this.Cuentasx.MinimumWidth = 100;
            this.Cuentasx.Name = "Cuentasx";
            this.Cuentasx.ReadOnly = true;
            // 
            // usuariox
            // 
            this.usuariox.DataPropertyName = "usuario";
            this.usuariox.HeaderText = "Usuario";
            this.usuariox.Name = "usuariox";
            this.usuariox.Visible = false;
            // 
            // fechax
            // 
            this.fechax.DataPropertyName = "fecha";
            this.fechax.HeaderText = "Fecha";
            this.fechax.Name = "fechax";
            this.fechax.Visible = false;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.Location = new System.Drawing.Point(491, 35);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 23);
            this.btnmodificar.TabIndex = 5;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.Location = new System.Drawing.Point(491, 11);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 23);
            this.btnnuevo.TabIndex = 4;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(491, 501);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 23);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(403, 501);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 23);
            this.btnaceptar.TabIndex = 6;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // lblmsg2
            // 
            this.lblmsg2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg2.AutoSize = true;
            this.lblmsg2.Location = new System.Drawing.Point(9, 505);
            this.lblmsg2.Name = "lblmsg2";
            this.lblmsg2.Size = new System.Drawing.Size(96, 13);
            this.lblmsg2.TabIndex = 161;
            this.lblmsg2.Text = "Total de Registros:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 162;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 162;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 162;
            this.label3.Text = "Cuentas";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtdescripcion.Location = new System.Drawing.Point(81, 36);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.ReadOnly = true;
            this.txtdescripcion.Size = new System.Drawing.Size(404, 20);
            this.txtdescripcion.TabIndex = 2;
            // 
            // txtcuentas
            // 
            this.txtcuentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtcuentas.Location = new System.Drawing.Point(81, 62);
            this.txtcuentas.Name = "txtcuentas";
            this.txtcuentas.ReadOnly = true;
            this.txtcuentas.Size = new System.Drawing.Size(492, 20);
            this.txtcuentas.TabIndex = 3;
            this.txtcuentas.DoubleClick += new System.EventHandler(this.txtcuentas_DoubleClick);
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtcodigo.Location = new System.Drawing.Point(81, 12);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.ReadOnly = true;
            this.txtcodigo.Size = new System.Drawing.Size(116, 20);
            this.txtcodigo.TabIndex = 1;
            // 
            // btndetalle
            // 
            this.btndetalle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btndetalle.Image = ((System.Drawing.Image)(resources.GetObject("btndetalle.Image")));
            this.btndetalle.Location = new System.Drawing.Point(251, 501);
            this.btndetalle.Name = "btndetalle";
            this.btndetalle.Size = new System.Drawing.Size(82, 23);
            this.btndetalle.TabIndex = 163;
            this.btndetalle.Text = "Detalle";
            this.btndetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndetalle.UseVisualStyleBackColor = true;
            this.btndetalle.Click += new System.EventHandler(this.btndetalle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 164;
            this.label4.Text = "Posición";
            // 
            // numPos
            // 
            this.numPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.numPos.Location = new System.Drawing.Point(268, 12);
            this.numPos.Name = "numPos";
            this.numPos.ReadOnly = true;
            this.numPos.Size = new System.Drawing.Size(52, 20);
            this.numPos.TabIndex = 165;
            // 
            // FrmConfiguracionBalanceSituacionFinanciera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 530);
            this.Colores = new System.Drawing.Color[0];
            this.Controls.Add(this.numPos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btndetalle);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtcuentas);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmsg2);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.Dtgconten);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.MinimumSize = new System.Drawing.Size(601, 569);
            this.Name = "FrmConfiguracionBalanceSituacionFinanciera";
            this.Nombre = "Configurar Estado de Situación Financiera";
            this.Text = "Configurar Estado de Situación Financiera";
            this.Load += new System.EventHandler(this.FrmConfiguracionBalanceSituacionFinanciera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtgconten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dtgconten Dtgconten;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label lblmsg2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtcuentas;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btndetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codRealx;
        private System.Windows.Forms.DataGridViewTextBoxColumn posix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigox;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuentasx;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuariox;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechax;
    }
}