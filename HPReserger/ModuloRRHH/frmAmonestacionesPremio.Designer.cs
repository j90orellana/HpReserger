﻿using HpResergerUserControls;

namespace HPReserger
{
    partial class frmAmonestacionesPremio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAmonestacionesPremio));
            this.tab = new System.Windows.Forms.TabControl();
            this.Memo = new System.Windows.Forms.TabPage();
            this.lblMemo = new System.Windows.Forms.Label();
            this.txtObservacionesMemo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Premio = new System.Windows.Forms.TabPage();
            this.lblPremio = new System.Windows.Forms.Label();
            this.txtObservacionesPremio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblmensajito = new System.Windows.Forms.TextBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Grid = new HpResergerUserControls.Dtgconten();
            this.Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOTIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOSNOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACIONES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnAdjuntarSustento = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btndescargar = new System.Windows.Forms.Button();
            this.btnmodificiar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.Memo.SuspendLayout();
            this.Premio.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.Memo);
            this.tab.Controls.Add(this.Premio);
            this.tab.Enabled = false;
            this.tab.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.ItemSize = new System.Drawing.Size(100, 18);
            this.tab.Location = new System.Drawing.Point(11, 231);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(373, 401);
            this.tab.TabIndex = 0;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // Memo
            // 
            this.Memo.Controls.Add(this.lblMemo);
            this.Memo.Controls.Add(this.txtObservacionesMemo);
            this.Memo.Controls.Add(this.label6);
            this.Memo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memo.Location = new System.Drawing.Point(4, 22);
            this.Memo.Name = "Memo";
            this.Memo.Padding = new System.Windows.Forms.Padding(3);
            this.Memo.Size = new System.Drawing.Size(365, 375);
            this.Memo.TabIndex = 0;
            this.Memo.Text = "Memorandum";
            this.Memo.UseVisualStyleBackColor = true;
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemo.Location = new System.Drawing.Point(263, 353);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(87, 13);
            this.lblMemo.TabIndex = 81;
            this.lblMemo.Text = "8000 Caracteres";
            this.lblMemo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtObservacionesMemo
            // 
            this.txtObservacionesMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacionesMemo.Location = new System.Drawing.Point(15, 32);
            this.txtObservacionesMemo.MaxLength = 8000;
            this.txtObservacionesMemo.Multiline = true;
            this.txtObservacionesMemo.Name = "txtObservacionesMemo";
            this.txtObservacionesMemo.Size = new System.Drawing.Size(337, 314);
            this.txtObservacionesMemo.TabIndex = 80;
            this.txtObservacionesMemo.TextChanged += new System.EventHandler(this.txtObservacionesMemo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Observaciones";
            // 
            // Premio
            // 
            this.Premio.Controls.Add(this.lblPremio);
            this.Premio.Controls.Add(this.txtObservacionesPremio);
            this.Premio.Controls.Add(this.label7);
            this.Premio.Location = new System.Drawing.Point(4, 22);
            this.Premio.Name = "Premio";
            this.Premio.Padding = new System.Windows.Forms.Padding(3);
            this.Premio.Size = new System.Drawing.Size(365, 375);
            this.Premio.TabIndex = 1;
            this.Premio.Text = "Carta de Premio";
            this.Premio.UseVisualStyleBackColor = true;
            // 
            // lblPremio
            // 
            this.lblPremio.AutoSize = true;
            this.lblPremio.Location = new System.Drawing.Point(263, 353);
            this.lblPremio.Name = "lblPremio";
            this.lblPremio.Size = new System.Drawing.Size(87, 13);
            this.lblPremio.TabIndex = 83;
            this.lblPremio.Text = "8000 Caracteres";
            this.lblPremio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtObservacionesPremio
            // 
            this.txtObservacionesPremio.Location = new System.Drawing.Point(15, 32);
            this.txtObservacionesPremio.MaxLength = 8000;
            this.txtObservacionesPremio.Multiline = true;
            this.txtObservacionesPremio.Name = "txtObservacionesPremio";
            this.txtObservacionesPremio.Size = new System.Drawing.Size(337, 314);
            this.txtObservacionesPremio.TabIndex = 82;
            this.txtObservacionesPremio.TextChanged += new System.EventHandler(this.txtObservacionesPremio_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 81;
            this.label7.Text = "Observaciones";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblmensajito);
            this.groupBox2.Controls.Add(this.txtNumeroDocumento);
            this.groupBox2.Controls.Add(this.txtApellidoPaterno);
            this.groupBox2.Controls.Add(this.txtApellidoMaterno);
            this.groupBox2.Controls.Add(this.txtNombres);
            this.groupBox2.Controls.Add(this.cboTipoDocumento);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 175);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            // 
            // lblmensajito
            // 
            this.lblmensajito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lblmensajito.Enabled = false;
            this.lblmensajito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensajito.Location = new System.Drawing.Point(13, 149);
            this.lblmensajito.MaxLength = 30;
            this.lblmensajito.Name = "lblmensajito";
            this.lblmensajito.ReadOnly = true;
            this.lblmensajito.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblmensajito.ShortcutsEnabled = false;
            this.lblmensajito.Size = new System.Drawing.Size(343, 21);
            this.lblmensajito.TabIndex = 79;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDocumento.Location = new System.Drawing.Point(195, 46);
            this.txtNumeroDocumento.MaxLength = 10;
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(161, 21);
            this.txtNumeroDocumento.TabIndex = 1;
            this.txtNumeroDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroDocumento.TextChanged += new System.EventHandler(this.txtNumeroDocumento_TextChanged);
            this.txtNumeroDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroDocumento_KeyDown);
            this.txtNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDocumento_KeyPress);
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.Location = new System.Drawing.Point(195, 72);
            this.txtApellidoPaterno.MaxLength = 30;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.ReadOnly = true;
            this.txtApellidoPaterno.Size = new System.Drawing.Size(161, 21);
            this.txtApellidoPaterno.TabIndex = 76;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.Location = new System.Drawing.Point(194, 98);
            this.txtApellidoMaterno.MaxLength = 30;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.ReadOnly = true;
            this.txtApellidoMaterno.Size = new System.Drawing.Size(161, 21);
            this.txtApellidoMaterno.TabIndex = 75;
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(195, 124);
            this.txtNombres.MaxLength = 30;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.ShortcutsEnabled = false;
            this.txtNombres.Size = new System.Drawing.Size(161, 21);
            this.txtNombres.TabIndex = 74;
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(195, 19);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(161, 21);
            this.cboTipoDocumento.TabIndex = 73;
            this.cboTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cboTipoDocumento_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Número de Documento de Identidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Apellido Paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Tipo de Documento de Identidad";
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeColumns = false;
            this.Grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Registro,
            this.CODIGOTIPO,
            this.TIPOID,
            this.NDI,
            this.APELLIDOSNOMBRES,
            this.OBSERVACIONES});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle6;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.Grid.Location = new System.Drawing.Point(402, 12);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid.RowHeadersVisible = false;
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid.RowTemplate.Height = 16;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(418, 178);
            this.Grid.TabIndex = 73;
            this.Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellContentClick);
            this.Grid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_RowEnter);
            this.Grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // Registro
            // 
            this.Registro.DataPropertyName = "REGISTRO";
            this.Registro.HeaderText = "REGISTRO";
            this.Registro.Name = "Registro";
            this.Registro.ReadOnly = true;
            this.Registro.Visible = false;
            // 
            // CODIGOTIPO
            // 
            this.CODIGOTIPO.DataPropertyName = "CODIGOTIPO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CODIGOTIPO.DefaultCellStyle = dataGridViewCellStyle3;
            this.CODIGOTIPO.HeaderText = "CODIGOTIPO";
            this.CODIGOTIPO.Name = "CODIGOTIPO";
            this.CODIGOTIPO.ReadOnly = true;
            this.CODIGOTIPO.Visible = false;
            // 
            // TIPOID
            // 
            this.TIPOID.DataPropertyName = "TIPOID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIPOID.DefaultCellStyle = dataGridViewCellStyle4;
            this.TIPOID.HeaderText = "TIPO ID";
            this.TIPOID.Name = "TIPOID";
            this.TIPOID.ReadOnly = true;
            this.TIPOID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TIPOID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TIPOID.Visible = false;
            // 
            // NDI
            // 
            this.NDI.DataPropertyName = "NID";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.NDI.DefaultCellStyle = dataGridViewCellStyle5;
            this.NDI.HeaderText = "Nº ID";
            this.NDI.Name = "NDI";
            this.NDI.ReadOnly = true;
            this.NDI.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NDI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NDI.Visible = false;
            // 
            // APELLIDOSNOMBRES
            // 
            this.APELLIDOSNOMBRES.DataPropertyName = "EMPLEADO";
            this.APELLIDOSNOMBRES.HeaderText = "APELLIDOS Y NOMBRES";
            this.APELLIDOSNOMBRES.Name = "APELLIDOSNOMBRES";
            this.APELLIDOSNOMBRES.ReadOnly = true;
            this.APELLIDOSNOMBRES.Visible = false;
            // 
            // OBSERVACIONES
            // 
            this.OBSERVACIONES.DataPropertyName = "OBSERVACIONES";
            this.OBSERVACIONES.HeaderText = "OBSERVACIONES";
            this.OBSERVACIONES.Name = "OBSERVACIONES";
            this.OBSERVACIONES.ReadOnly = true;
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFoto.BackColor = System.Drawing.Color.Transparent;
            this.pbFoto.Location = new System.Drawing.Point(402, 196);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(418, 436);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 74;
            this.pbFoto.TabStop = false;
            this.pbFoto.DoubleClick += new System.EventHandler(this.pbFoto_DoubleClick);
            this.pbFoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbFoto_MouseMove);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerar.Enabled = false;
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.Location = new System.Drawing.Point(11, 638);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(94, 23);
            this.btnGenerar.TabIndex = 108;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnAdjuntarSustento
            // 
            this.btnAdjuntarSustento.Enabled = false;
            this.btnAdjuntarSustento.FlatAppearance.BorderSize = 0;
            this.btnAdjuntarSustento.Image = ((System.Drawing.Image)(resources.GetObject("btnAdjuntarSustento.Image")));
            this.btnAdjuntarSustento.Location = new System.Drawing.Point(12, 193);
            this.btnAdjuntarSustento.Name = "btnAdjuntarSustento";
            this.btnAdjuntarSustento.Size = new System.Drawing.Size(121, 23);
            this.btnAdjuntarSustento.TabIndex = 107;
            this.btnAdjuntarSustento.Text = "Adjuntar Imagen";
            this.btnAdjuntarSustento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdjuntarSustento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdjuntarSustento.UseVisualStyleBackColor = true;
            this.btnAdjuntarSustento.Click += new System.EventHandler(this.btnAdjuntarSustento_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Enabled = false;
            this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(139, 196);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(245, 21);
            this.txtRuta.TabIndex = 109;
            // 
            // btndescargar
            // 
            this.btndescargar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btndescargar.AutoEllipsis = true;
            this.btndescargar.ImageKey = "(ninguno)";
            this.btndescargar.Location = new System.Drawing.Point(583, 601);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(76, 23);
            this.btndescargar.TabIndex = 110;
            this.btndescargar.Text = "Descargar";
            this.btndescargar.UseVisualStyleBackColor = false;
            this.btndescargar.Visible = false;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            this.btndescargar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btndescargar_MouseMove);
            // 
            // btnmodificiar
            // 
            this.btnmodificiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnmodificiar.Enabled = false;
            this.btnmodificiar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificiar.Image")));
            this.btnmodificiar.Location = new System.Drawing.Point(402, 638);
            this.btnmodificiar.Name = "btnmodificiar";
            this.btnmodificiar.Size = new System.Drawing.Size(94, 23);
            this.btnmodificiar.TabIndex = 111;
            this.btnmodificiar.Text = "Modificiar";
            this.btnmodificiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificiar.UseVisualStyleBackColor = true;
            this.btnmodificiar.Click += new System.EventHandler(this.btnmodificiar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btneliminar.Enabled = false;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(502, 638);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(94, 23);
            this.btneliminar.TabIndex = 112;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(726, 638);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(94, 23);
            this.btncancelar.TabIndex = 113;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // frmAmonestacionesPremio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(832, 670);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificiar);
            this.Controls.Add(this.btndescargar);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnAdjuntarSustento);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tab);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(848, 709);
            this.Name = "frmAmonestacionesPremio";
            this.Nombre = "Registro de Amonestaciones y Premios";
            this.Text = "Registro de Amonestaciones y Premios";
            this.Load += new System.EventHandler(this.frmAmonestacionesPremio_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAmonestacionesPremio_MouseMove);
            this.tab.ResumeLayout(false);
            this.Memo.ResumeLayout(false);
            this.Memo.PerformLayout();
            this.Premio.ResumeLayout(false);
            this.Premio.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage Memo;
        private System.Windows.Forms.TabPage Premio;
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
        private Dtgconten Grid;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnAdjuntarSustento;
        private System.Windows.Forms.TextBox txtObservacionesMemo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.TextBox txtObservacionesPremio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPremio;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.TextBox lblmensajito;
        private System.Windows.Forms.Button btndescargar;
        private System.Windows.Forms.Button btnmodificiar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOTIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDI;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOSNOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACIONES;
        private System.Windows.Forms.Button btncancelar;
    }
}