﻿namespace HPReserger
{
    partial class frmdetracciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdetracciones));
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.id_detraccionx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnaceptar = new HpResergerUserControls.ButtonPer();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtdescripcion = new HpResergerUserControls.TextBoxPer();
            this.txtporcentaje = new HpResergerUserControls.TextBoxPer();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtBuscar1 = new HpResergerUserControls.txtBuscar();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_detraccionx,
            this.descripcionx,
            this.porcentajex,
            this.usuariox,
            this.fechax});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 94);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(507, 298);
            this.dtgconten.TabIndex = 0;
            this.dtgconten.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellContentDoubleClick);
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            this.dtgconten.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgconten_RowsAdded);
            this.dtgconten.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgconten_RowsRemoved);
            // 
            // id_detraccionx
            // 
            this.id_detraccionx.DataPropertyName = "id_detraccion";
            this.id_detraccionx.HeaderText = "id_detraccion";
            this.id_detraccionx.Name = "id_detraccionx";
            this.id_detraccionx.ReadOnly = true;
            this.id_detraccionx.Visible = false;
            // 
            // descripcionx
            // 
            this.descripcionx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionx.DataPropertyName = "Desc_Detraccion";
            this.descripcionx.HeaderText = "Descripción";
            this.descripcionx.MinimumWidth = 300;
            this.descripcionx.Name = "descripcionx";
            this.descripcionx.ReadOnly = true;
            // 
            // porcentajex
            // 
            this.porcentajex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.porcentajex.DataPropertyName = "porcentaje";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "0.##\"%\"";
            dataGridViewCellStyle3.NullValue = null;
            this.porcentajex.DefaultCellStyle = dataGridViewCellStyle3;
            this.porcentajex.HeaderText = "Porcentaje";
            this.porcentajex.MinimumWidth = 100;
            this.porcentajex.Name = "porcentajex";
            this.porcentajex.ReadOnly = true;
            // 
            // usuariox
            // 
            this.usuariox.DataPropertyName = "usuario";
            this.usuariox.HeaderText = "usuario";
            this.usuariox.Name = "usuariox";
            this.usuariox.ReadOnly = true;
            this.usuariox.Visible = false;
            // 
            // fechax
            // 
            this.fechax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechax.DataPropertyName = "fecha";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.fechax.DefaultCellStyle = dataGridViewCellStyle4;
            this.fechax.HeaderText = "Fecha";
            this.fechax.MinimumWidth = 100;
            this.fechax.Name = "fechax";
            this.fechax.ReadOnly = true;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnaceptar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.ForeColor = System.Drawing.Color.White;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(525, 340);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(87, 23);
            this.btnaceptar.TabIndex = 2;
            this.btnaceptar.Text = "&Aceptar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(525, 369);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(87, 23);
            this.btncancelar.TabIndex = 35;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescripcion.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtdescripcion.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtdescripcion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(154)))));
            this.txtdescripcion.Location = new System.Drawing.Point(95, 14);
            this.txtdescripcion.MaxLength = 100;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.NextControlOnEnter = this.txtporcentaje;
            this.txtdescripcion.Size = new System.Drawing.Size(310, 22);
            this.txtdescripcion.TabIndex = 70;
            this.txtdescripcion.Text = "INGRESE DESCRIPCIÓN";
            this.txtdescripcion.TextoDefecto = "Ingrese Descripción";
            this.txtdescripcion.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(154)))));
            this.txtdescripcion.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // txtporcentaje
            // 
            this.txtporcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtporcentaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtporcentaje.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtporcentaje.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtporcentaje.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtporcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(154)))));
            this.txtporcentaje.Location = new System.Drawing.Point(95, 40);
            this.txtporcentaje.MaxLength = 100;
            this.txtporcentaje.Name = "txtporcentaje";
            this.txtporcentaje.NextControlOnEnter = this.dtpfecha;
            this.txtporcentaje.Size = new System.Drawing.Size(135, 22);
            this.txtporcentaje.TabIndex = 73;
            this.txtporcentaje.Text = "0.00";
            this.txtporcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtporcentaje.TextoDefecto = "0.00";
            this.txtporcentaje.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(154)))));
            this.txtporcentaje.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // dtpfecha
            // 
            this.dtpfecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha.Location = new System.Drawing.Point(282, 40);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(123, 22);
            this.dtpfecha.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Porcentaje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(236, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Fecha:";
            // 
            // btnmodificar
            // 
            this.btnmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmodificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnmodificar.Enabled = false;
            this.btnmodificar.ForeColor = System.Drawing.Color.Black;
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodificar.Location = new System.Drawing.Point(525, 34);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(87, 24);
            this.btnmodificar.TabIndex = 77;
            this.btnmodificar.Text = "&Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnnuevo.ForeColor = System.Drawing.Color.Black;
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.Location = new System.Drawing.Point(525, 8);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(87, 24);
            this.btnnuevo.TabIndex = 76;
            this.btnnuevo.Text = "&Nuevo";
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(525, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 78;
            this.button1.Text = "&Excel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnactualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnactualizar.ForeColor = System.Drawing.Color.Black;
            this.btnactualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.Image")));
            this.btnactualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnactualizar.Location = new System.Drawing.Point(525, 89);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(87, 24);
            this.btnactualizar.TabIndex = 80;
            this.btnactualizar.Text = "Ac&tualizar";
            this.btnactualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btneliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btneliminar.Enabled = false;
            this.btneliminar.ForeColor = System.Drawing.Color.Black;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.Location = new System.Drawing.Point(525, 62);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(87, 24);
            this.btneliminar.TabIndex = 79;
            this.btneliminar.Text = "&Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtBuscar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtBuscar1.FondoBoton = ((System.Drawing.Image)(resources.GetObject("txtBuscar1.FondoBoton")));
            this.txtBuscar1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar1.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar1.Location = new System.Drawing.Point(15, 66);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(390, 22);
            this.txtBuscar1.TabIndex = 81;
            this.txtBuscar1.BuscarClick += new System.EventHandler(this.txtBuscar1_ClickBotonBuscar);
            this.txtBuscar1.BuscarTextChanged += new System.EventHandler(this.txtBuscar1_ClickBotonBuscar);
            // 
            // frmdetracciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 400);
            this.Controls.Add(this.txtBuscar1);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtporcentaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.dtgconten);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(637, 439);
            this.Name = "frmdetracciones";
            this.Nombre = "Configuración de las Detracciones";
            this.Text = "Configuración de las Detracciones";
            this.Load += new System.EventHandler(this.frmdetracciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private HpResergerUserControls.TextBoxPer txtporcentaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_detraccionx;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionx;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajex;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuariox;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechax;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private HpResergerUserControls.txtBuscar txtBuscar1;
        public HpResergerUserControls.TextBoxPer txtdescripcion;
        public HpResergerUserControls.ButtonPer btnaceptar;
    }
}