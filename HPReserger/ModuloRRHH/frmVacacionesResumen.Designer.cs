﻿namespace HPReserger.ModuloRRHH
{
    partial class frmVacacionesResumen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVacacionesResumen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.buttonPer1 = new HpResergerUserControls.ButtonPer();
            this.txtbusEmpleado = new HpResergerUserControls.TextBoxPer();
            this.cboFecha = new HpResergerUserControls.ComboMesAño();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.xtipoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDiasGanados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDiasTomados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDiasPendientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
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
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xtipoid,
            this.NroDoc,
            this.xNombres,
            this.xFechaIngreso,
            this.xaño,
            this.xmes,
            this.xdias,
            this.xDiasGanados,
            this.xDiasTomados,
            this.xDiasPendientes});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 74);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(692, 400);
            this.dtgconten.TabIndex = 9;
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Location = new System.Drawing.Point(12, 480);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(95, 13);
            this.lblRegistros.TabIndex = 209;
            this.lblRegistros.Text = "Total Registros: 0";
            // 
            // buttonPer1
            // 
            this.buttonPer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPer1.BackColor = System.Drawing.Color.Crimson;
            this.buttonPer1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonPer1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonPer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPer1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPer1.ForeColor = System.Drawing.Color.White;
            this.buttonPer1.Location = new System.Drawing.Point(621, 480);
            this.buttonPer1.Name = "buttonPer1";
            this.buttonPer1.Size = new System.Drawing.Size(83, 24);
            this.buttonPer1.TabIndex = 208;
            this.buttonPer1.Text = "Cancelar";
            this.buttonPer1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPer1.UseVisualStyleBackColor = false;
            this.buttonPer1.Click += new System.EventHandler(this.buttonPer1_Click);
            // 
            // txtbusEmpleado
            // 
            this.txtbusEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbusEmpleado.BackColor = System.Drawing.Color.White;
            this.txtbusEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusEmpleado.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusEmpleado.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusEmpleado.ForeColor = System.Drawing.Color.Black;
            this.txtbusEmpleado.Format = null;
            this.txtbusEmpleado.Location = new System.Drawing.Point(277, 26);
            this.txtbusEmpleado.MaxLength = 600;
            this.txtbusEmpleado.Name = "txtbusEmpleado";
            this.txtbusEmpleado.NextControlOnEnter = null;
            this.txtbusEmpleado.Size = new System.Drawing.Size(286, 21);
            this.txtbusEmpleado.TabIndex = 210;
            this.txtbusEmpleado.Text = "Documento O Nombre Empleado";
            this.txtbusEmpleado.TextoDefecto = "Documento O Nombre Empleado";
            this.txtbusEmpleado.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusEmpleado.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusEmpleado.TextChanged += new System.EventHandler(this.txtbusEmpleado_TextChanged);
            // 
            // cboFecha
            // 
            this.cboFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFecha.BackColor = System.Drawing.Color.Transparent;
            this.cboFecha.FechaConDiaActual = new System.DateTime(2020, 8, 10, 0, 0, 0, 0);
            this.cboFecha.FechaFinMes = new System.DateTime(2020, 8, 31, 0, 0, 0, 0);
            this.cboFecha.FechaInicioMes = new System.DateTime(2020, 8, 1, 0, 0, 0, 0);
            this.cboFecha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFecha.Location = new System.Drawing.Point(80, 25);
            this.cboFecha.Name = "cboFecha";
            this.cboFecha.Size = new System.Drawing.Size(197, 23);
            this.cboFecha.TabIndex = 211;
            this.cboFecha.VerAño = true;
            this.cboFecha.VerMes = true;
            this.cboFecha.CambioFechas += new System.EventHandler(this.cboFecha_CambioFechas);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 212;
            this.label5.Text = "Fecha Corte:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 212;
            this.label1.Text = "Resumen de Empleados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 213;
            this.label4.Text = "Opciones de Filtrado:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.Location = new System.Drawing.Point(622, 48);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(82, 24);
            this.btnActualizar.TabIndex = 214;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlimpiar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.Location = new System.Drawing.Point(622, 24);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(82, 24);
            this.btnlimpiar.TabIndex = 215;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // xtipoid
            // 
            this.xtipoid.DataPropertyName = "tipoid";
            this.xtipoid.HeaderText = "TipoId";
            this.xtipoid.Name = "xtipoid";
            this.xtipoid.Visible = false;
            // 
            // NroDoc
            // 
            this.NroDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.NroDoc.DataPropertyName = "nrodoc";
            this.NroDoc.HeaderText = "NumDoc";
            this.NroDoc.MinimumWidth = 65;
            this.NroDoc.Name = "NroDoc";
            this.NroDoc.Width = 65;
            // 
            // xNombres
            // 
            this.xNombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xNombres.DataPropertyName = "nombres";
            this.xNombres.FillWeight = 421.2599F;
            this.xNombres.HeaderText = "Nombre Empleado";
            this.xNombres.MinimumWidth = 150;
            this.xNombres.Name = "xNombres";
            // 
            // xFechaIngreso
            // 
            this.xFechaIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFechaIngreso.DataPropertyName = "fechaingreso";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "d";
            this.xFechaIngreso.DefaultCellStyle = dataGridViewCellStyle3;
            this.xFechaIngreso.FillWeight = 19.68504F;
            this.xFechaIngreso.HeaderText = "Fecha Ingreso";
            this.xFechaIngreso.MinimumWidth = 65;
            this.xFechaIngreso.Name = "xFechaIngreso";
            this.xFechaIngreso.Width = 65;
            // 
            // xaño
            // 
            this.xaño.DataPropertyName = "xaño";
            this.xaño.HeaderText = "xaño";
            this.xaño.Name = "xaño";
            this.xaño.Visible = false;
            // 
            // xmes
            // 
            this.xmes.DataPropertyName = "xmes";
            this.xmes.HeaderText = "xmes";
            this.xmes.Name = "xmes";
            this.xmes.Visible = false;
            // 
            // xdias
            // 
            this.xdias.DataPropertyName = "xdias";
            this.xdias.HeaderText = "xdias";
            this.xdias.Name = "xdias";
            this.xdias.Visible = false;
            // 
            // xDiasGanados
            // 
            this.xDiasGanados.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xDiasGanados.DataPropertyName = "diasganados";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.xDiasGanados.DefaultCellStyle = dataGridViewCellStyle4;
            this.xDiasGanados.FillWeight = 19.68504F;
            this.xDiasGanados.HeaderText = "Dias Ganados";
            this.xDiasGanados.MinimumWidth = 70;
            this.xDiasGanados.Name = "xDiasGanados";
            this.xDiasGanados.Width = 70;
            // 
            // xDiasTomados
            // 
            this.xDiasTomados.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xDiasTomados.DataPropertyName = "diastomados";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xDiasTomados.DefaultCellStyle = dataGridViewCellStyle5;
            this.xDiasTomados.FillWeight = 19.68504F;
            this.xDiasTomados.HeaderText = "Dias Tomados";
            this.xDiasTomados.MinimumWidth = 70;
            this.xDiasTomados.Name = "xDiasTomados";
            this.xDiasTomados.Width = 70;
            // 
            // xDiasPendientes
            // 
            this.xDiasPendientes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xDiasPendientes.DataPropertyName = "diaspendientes";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "n2";
            this.xDiasPendientes.DefaultCellStyle = dataGridViewCellStyle6;
            this.xDiasPendientes.FillWeight = 19.68504F;
            this.xDiasPendientes.HeaderText = "Dias Pendientes";
            this.xDiasPendientes.MinimumWidth = 70;
            this.xDiasPendientes.Name = "xDiasPendientes";
            this.xDiasPendientes.Width = 70;
            // 
            // frmVacacionesResumen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(716, 511);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboFecha);
            this.Controls.Add(this.txtbusEmpleado);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.buttonPer1);
            this.Controls.Add(this.dtgconten);
            this.Name = "frmVacacionesResumen";
            this.Nombre = "Resumen Vacaciones";
            this.Text = "Resumen Vacaciones";
            this.Load += new System.EventHandler(this.frmVacacionesResumen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Label lblRegistros;
        private HpResergerUserControls.ButtonPer buttonPer1;
        private HpResergerUserControls.TextBoxPer txtbusEmpleado;
        private HpResergerUserControls.ComboMesAño cboFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtipoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn xaño;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmes;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdias;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDiasGanados;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDiasTomados;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDiasPendientes;
    }
}