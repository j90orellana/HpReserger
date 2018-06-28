namespace HPReserger
{
    partial class frmSolicitudes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitudes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Btncancelar = new System.Windows.Forms.Button();
            this.btnaprovar = new System.Windows.Forms.Button();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.btnrecargar = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solicitaemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SOLICITUDES";
            // 
            // Btncancelar
            // 
            this.Btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btncancelar.Image")));
            this.Btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btncancelar.Location = new System.Drawing.Point(350, 462);
            this.Btncancelar.Name = "Btncancelar";
            this.Btncancelar.Size = new System.Drawing.Size(114, 24);
            this.Btncancelar.TabIndex = 1;
            this.Btncancelar.Text = "Eliminar Solicitud";
            this.Btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btncancelar.UseVisualStyleBackColor = true;
            this.Btncancelar.Click += new System.EventHandler(this.Btncancelar_Click);
            // 
            // btnaprovar
            // 
            this.btnaprovar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaprovar.Image = ((System.Drawing.Image)(resources.GetObject("btnaprovar.Image")));
            this.btnaprovar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaprovar.Location = new System.Drawing.Point(231, 462);
            this.btnaprovar.Name = "btnaprovar";
            this.btnaprovar.Size = new System.Drawing.Size(113, 24);
            this.btnaprovar.TabIndex = 2;
            this.btnaprovar.Text = "Aprobar Solicitud";
            this.btnaprovar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaprovar.UseVisualStyleBackColor = true;
            this.btnaprovar.Click += new System.EventHandler(this.btnaprovar_Click);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToOrderColumns = true;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empleado,
            this.cod_empleado,
            this.Accion,
            this.Valores,
            this.estados,
            this.Solicitaemp,
            this.observacion});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 46);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(675, 410);
            this.dtgconten.TabIndex = 57;
            // 
            // btnrecargar
            // 
            this.btnrecargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrecargar.Image = ((System.Drawing.Image)(resources.GetObject("btnrecargar.Image")));
            this.btnrecargar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrecargar.Location = new System.Drawing.Point(606, 17);
            this.btnrecargar.Name = "btnrecargar";
            this.btnrecargar.Size = new System.Drawing.Size(81, 24);
            this.btnrecargar.TabIndex = 58;
            this.btnrecargar.Text = "Recargar";
            this.btnrecargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnrecargar.UseVisualStyleBackColor = true;
            this.btnrecargar.Click += new System.EventHandler(this.btnrecargar_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // empleado
            // 
            this.empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.empleado.DataPropertyName = "empleado";
            this.empleado.HeaderText = "Empleado";
            this.empleado.MinimumWidth = 250;
            this.empleado.Name = "empleado";
            this.empleado.ReadOnly = true;
            this.empleado.Width = 250;
            // 
            // cod_empleado
            // 
            this.cod_empleado.DataPropertyName = "cod_emp";
            this.cod_empleado.HeaderText = "codempleado";
            this.cod_empleado.Name = "cod_empleado";
            this.cod_empleado.ReadOnly = true;
            this.cod_empleado.Visible = false;
            // 
            // Accion
            // 
            this.Accion.DataPropertyName = "accion";
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            this.Accion.Visible = false;
            // 
            // Valores
            // 
            this.Valores.DataPropertyName = "valores";
            this.Valores.HeaderText = "Valores";
            this.Valores.Name = "Valores";
            this.Valores.ReadOnly = true;
            this.Valores.Visible = false;
            // 
            // estados
            // 
            this.estados.DataPropertyName = "estado";
            this.estados.HeaderText = "estados";
            this.estados.Name = "estados";
            this.estados.ReadOnly = true;
            this.estados.Visible = false;
            // 
            // Solicitaemp
            // 
            this.Solicitaemp.DataPropertyName = "solicitaemp";
            this.Solicitaemp.HeaderText = "solicitaemp";
            this.Solicitaemp.Name = "Solicitaemp";
            this.Solicitaemp.ReadOnly = true;
            this.Solicitaemp.Visible = false;
            // 
            // observacion
            // 
            this.observacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.observacion.DataPropertyName = "observacion";
            this.observacion.HeaderText = "Solicitud";
            this.observacion.MinimumWidth = 350;
            this.observacion.Name = "observacion";
            this.observacion.ReadOnly = true;
            // 
            // frmSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 497);
            this.Controls.Add(this.btnrecargar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.btnaprovar);
            this.Controls.Add(this.Btncancelar);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(571, 335);
            this.Name = "frmSolicitudes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitudes ";
            this.Load += new System.EventHandler(this.frmSolicitudes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btncancelar;
        private System.Windows.Forms.Button btnaprovar;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button btnrecargar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valores;
        private System.Windows.Forms.DataGridViewTextBoxColumn estados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solicitaemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
    }
}