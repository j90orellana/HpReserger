﻿using HpResergerUserControls;

namespace HPReserger
{
    partial class frmArticuloServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticuloServicio));
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.tipmsg = new System.Windows.Forms.ToolTip(this.components);
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Txtbusca = new System.Windows.Forms.TextBox();
            this.dtgconten = new Dtgconten();
            this.ida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centrodecosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctaactivox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.cbomarca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbomodelo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtobservacion = new System.Windows.Forms.TextBox();
            this.btnmarcamas = new System.Windows.Forms.Button();
            this.btnmodelomas = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.veri = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.chkcentro = new System.Windows.Forms.CheckBox();
            this.chkigv = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbocuenta = new System.Windows.Forms.ComboBox();
            this.gp1 = new System.Windows.Forms.GroupBox();
            this.btnctaact = new System.Windows.Forms.Button();
            this.btnctactble = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtctacble = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcntctbleact = new System.Windows.Forms.TextBox();
            this.btncentro = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbocentrocosto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veri)).BeginInit();
            this.gp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.Location = new System.Drawing.Point(493, 70);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(82, 23);
            this.btneliminar.TabIndex = 79;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.Location = new System.Drawing.Point(493, 44);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 23);
            this.btnmodificar.TabIndex = 80;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.Location = new System.Drawing.Point(493, 19);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 23);
            this.btnnuevo.TabIndex = 78;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // tipmsg
            // 
            this.tipmsg.IsBalloon = true;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.BackgroundImage")));
            this.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnlimpiar.FlatAppearance.BorderSize = 0;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.btnlimpiar.Location = new System.Drawing.Point(84, 250);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(20, 21);
            this.btnlimpiar.TabIndex = 86;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "BUSCAR";
            // 
            // Txtbusca
            // 
            this.Txtbusca.BackColor = System.Drawing.SystemColors.Info;
            this.Txtbusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txtbusca.Cursor = System.Windows.Forms.Cursors.Help;
            this.Txtbusca.Location = new System.Drawing.Point(110, 250);
            this.Txtbusca.Name = "Txtbusca";
            this.Txtbusca.Size = new System.Drawing.Size(377, 20);
            this.Txtbusca.TabIndex = 84;
            this.Txtbusca.TextChanged += new System.EventHandler(this.Txtbusca_TextChanged);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            //this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //this.dtgconten.BackgroundColor = System.Drawing.SystemColors.Control;
            //this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            //this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ida,
            this.GV,
            this.Descripcion,
            this.idm,
            this.Marca,
            this.idc,
            this.Tipo,
            this.Obs,
            this.cc,
            this.cuenta,
            this.centrodecosto,
            this.ctax,
            this.ctaactivox});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtgconten.Location = new System.Drawing.Point(12, 276);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            //this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(563, 289);
            this.dtgconten.TabIndex = 83;
            this.dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellContentClick);
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // ida
            // 
            this.ida.DataPropertyName = "ida";
            this.ida.HeaderText = "ida";
            this.ida.Name = "ida";
            this.ida.ReadOnly = true;
            this.ida.Visible = false;
            this.ida.Width = 27;
            // 
            // GV
            // 
            this.GV.DataPropertyName = "IGV";
            this.GV.HeaderText = "GV";
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.Visible = false;
            this.GV.Width = 28;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "DESCRIPCIÓN";
            this.Descripcion.MinimumWidth = 100;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // idm
            // 
            this.idm.DataPropertyName = "idm";
            this.idm.HeaderText = "idm";
            this.idm.Name = "idm";
            this.idm.ReadOnly = true;
            this.idm.Visible = false;
            this.idm.Width = 48;
            // 
            // Marca
            // 
            this.Marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Marca.DataPropertyName = "marca";
            this.Marca.HeaderText = "MARCA";
            this.Marca.MinimumWidth = 60;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 70;
            // 
            // idc
            // 
            this.idc.DataPropertyName = "idc";
            this.idc.HeaderText = "idc";
            this.idc.Name = "idc";
            this.idc.ReadOnly = true;
            this.idc.Visible = false;
            this.idc.Width = 46;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "tipo";
            this.Tipo.HeaderText = "TIPO";
            this.Tipo.MinimumWidth = 50;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 57;
            // 
            // Obs
            // 
            this.Obs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Obs.DataPropertyName = "ob";
            this.Obs.HeaderText = "OBSERVACIÓN";
            this.Obs.MinimumWidth = 50;
            this.Obs.Name = "Obs";
            this.Obs.ReadOnly = true;
            // 
            // cc
            // 
            this.cc.DataPropertyName = "cc";
            this.cc.HeaderText = "cc";
            this.cc.Name = "cc";
            this.cc.ReadOnly = true;
            this.cc.Visible = false;
            this.cc.Width = 44;
            // 
            // cuenta
            // 
            this.cuenta.DataPropertyName = "cuenta";
            this.cuenta.HeaderText = "cuenta";
            this.cuenta.Name = "cuenta";
            this.cuenta.ReadOnly = true;
            this.cuenta.Visible = false;
            this.cuenta.Width = 65;
            // 
            // centrodecosto
            // 
            this.centrodecosto.DataPropertyName = "centrodecosto";
            this.centrodecosto.HeaderText = "centrodecosto";
            this.centrodecosto.Name = "centrodecosto";
            this.centrodecosto.ReadOnly = true;
            this.centrodecosto.Visible = false;
            // 
            // ctax
            // 
            this.ctax.DataPropertyName = "cta";
            this.ctax.HeaderText = "ctax";
            this.ctax.Name = "ctax";
            this.ctax.ReadOnly = true;
            this.ctax.Visible = false;
            this.ctax.Width = 52;
            // 
            // ctaactivox
            // 
            this.ctaactivox.DataPropertyName = "ctAact";
            this.ctaactivox.HeaderText = "ctaactivo";
            this.ctaactivox.Name = "ctaactivox";
            this.ctaactivox.ReadOnly = true;
            this.ctaactivox.Visible = false;
            this.ctaactivox.Width = 76;
            // 
            // btncancelar
            // 
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(490, 571);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 29);
            this.btncancelar.TabIndex = 81;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnaceptar.Enabled = false;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaceptar.Location = new System.Drawing.Point(402, 571);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 29);
            this.btnaceptar.TabIndex = 82;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // cbotipo
            // 
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Location = new System.Drawing.Point(90, 15);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(206, 21);
            this.cbotipo.TabIndex = 87;
            this.cbotipo.SelectedIndexChanged += new System.EventHandler(this.cbotipo_SelectedIndexChanged);
            this.cbotipo.TextChanged += new System.EventHandler(this.cbotipo_TextChanged);
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(349, 15);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(116, 20);
            this.txtcodigo.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Descripción";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescripcion.Location = new System.Drawing.Point(92, 40);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(373, 20);
            this.txtdescripcion.TabIndex = 92;
            this.txtdescripcion.TextChanged += new System.EventHandler(this.txtdescripcion_TextChanged);
            // 
            // cbomarca
            // 
            this.cbomarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbomarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbomarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbomarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomarca.FormattingEnabled = true;
            this.cbomarca.Location = new System.Drawing.Point(90, 64);
            this.cbomarca.Name = "cbomarca";
            this.cbomarca.Size = new System.Drawing.Size(349, 21);
            this.cbomarca.TabIndex = 94;
            this.cbomarca.SelectedIndexChanged += new System.EventHandler(this.cbomarca_SelectedIndexChanged);
            this.cbomarca.TextChanged += new System.EventHandler(this.cbomarca_TextChanged);
            this.cbomarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbomarca_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "Modelo";
            // 
            // cbomodelo
            // 
            this.cbomodelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbomodelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbomodelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbomodelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomodelo.FormattingEnabled = true;
            this.cbomodelo.Location = new System.Drawing.Point(90, 90);
            this.cbomodelo.Name = "cbomodelo";
            this.cbomodelo.Size = new System.Drawing.Size(349, 21);
            this.cbomodelo.TabIndex = 96;
            this.cbomodelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbomodelo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 97;
            this.label7.Text = "Observaciones";
            // 
            // txtobservacion
            // 
            this.txtobservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtobservacion.Location = new System.Drawing.Point(91, 189);
            this.txtobservacion.Multiline = true;
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtobservacion.Size = new System.Drawing.Size(374, 45);
            this.txtobservacion.TabIndex = 98;
            // 
            // btnmarcamas
            // 
            this.btnmarcamas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmarcamas.BackgroundImage")));
            this.btnmarcamas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmarcamas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmarcamas.Location = new System.Drawing.Point(445, 64);
            this.btnmarcamas.Name = "btnmarcamas";
            this.btnmarcamas.Size = new System.Drawing.Size(20, 21);
            this.btnmarcamas.TabIndex = 99;
            this.btnmarcamas.UseVisualStyleBackColor = true;
            this.btnmarcamas.Click += new System.EventHandler(this.btnmarcamas_Click);
            // 
            // btnmodelomas
            // 
            this.btnmodelomas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmodelomas.BackgroundImage")));
            this.btnmodelomas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodelomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodelomas.Location = new System.Drawing.Point(445, 90);
            this.btnmodelomas.Name = "btnmodelomas";
            this.btnmodelomas.Size = new System.Drawing.Size(20, 21);
            this.btnmodelomas.TabIndex = 100;
            this.btnmodelomas.UseVisualStyleBackColor = true;
            this.btnmodelomas.Click += new System.EventHandler(this.btnmodelomas_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(9, 579);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(96, 13);
            this.lblmsg.TabIndex = 111;
            this.lblmsg.Text = "Total de Registros:";
            // 
            // veri
            // 
            this.veri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.veri.Location = new System.Drawing.Point(976, 394);
            this.veri.Name = "veri";
            this.veri.Size = new System.Drawing.Size(94, 119);
            this.veri.TabIndex = 112;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 97;
            this.label8.Text = "Centro de Costo";
            // 
            // chkcentro
            // 
            this.chkcentro.AutoSize = true;
            this.chkcentro.Location = new System.Drawing.Point(91, 117);
            this.chkcentro.Name = "chkcentro";
            this.chkcentro.Size = new System.Drawing.Size(35, 17);
            this.chkcentro.TabIndex = 113;
            this.chkcentro.Text = "Si";
            this.chkcentro.UseVisualStyleBackColor = true;
            this.chkcentro.CheckedChanged += new System.EventHandler(this.chkcentro_CheckedChanged);
            // 
            // chkigv
            // 
            this.chkigv.AutoSize = true;
            this.chkigv.Location = new System.Drawing.Point(204, 117);
            this.chkigv.Name = "chkigv";
            this.chkigv.Size = new System.Drawing.Size(35, 17);
            this.chkigv.TabIndex = 115;
            this.chkigv.Text = "Si";
            this.chkigv.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 114;
            this.label9.Text = "Afecto x IGV";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 116;
            this.label10.Text = "Cta. General";
            this.label10.Visible = false;
            // 
            // cbocuenta
            // 
            this.cbocuenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbocuenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbocuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbocuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocuenta.FormattingEnabled = true;
            this.cbocuenta.Location = new System.Drawing.Point(318, 115);
            this.cbocuenta.Name = "cbocuenta";
            this.cbocuenta.Size = new System.Drawing.Size(147, 21);
            this.cbocuenta.TabIndex = 117;
            this.cbocuenta.Visible = false;
            // 
            // gp1
            // 
            this.gp1.Controls.Add(this.btnctaact);
            this.gp1.Controls.Add(this.btnctactble);
            this.gp1.Controls.Add(this.label13);
            this.gp1.Controls.Add(this.txtctacble);
            this.gp1.Controls.Add(this.label12);
            this.gp1.Controls.Add(this.txtcntctbleact);
            this.gp1.Controls.Add(this.btncentro);
            this.gp1.Controls.Add(this.label11);
            this.gp1.Controls.Add(this.cbocentrocosto);
            this.gp1.Controls.Add(this.label2);
            this.gp1.Controls.Add(this.cbocuenta);
            this.gp1.Controls.Add(this.cbotipo);
            this.gp1.Controls.Add(this.label10);
            this.gp1.Controls.Add(this.label1);
            this.gp1.Controls.Add(this.chkigv);
            this.gp1.Controls.Add(this.txtcodigo);
            this.gp1.Controls.Add(this.label9);
            this.gp1.Controls.Add(this.label3);
            this.gp1.Controls.Add(this.chkcentro);
            this.gp1.Controls.Add(this.txtdescripcion);
            this.gp1.Controls.Add(this.label4);
            this.gp1.Controls.Add(this.cbomarca);
            this.gp1.Controls.Add(this.btnmodelomas);
            this.gp1.Controls.Add(this.label6);
            this.gp1.Controls.Add(this.btnmarcamas);
            this.gp1.Controls.Add(this.cbomodelo);
            this.gp1.Controls.Add(this.txtobservacion);
            this.gp1.Controls.Add(this.label7);
            this.gp1.Controls.Add(this.label8);
            this.gp1.Enabled = false;
            this.gp1.Location = new System.Drawing.Point(12, 5);
            this.gp1.Name = "gp1";
            this.gp1.Size = new System.Drawing.Size(475, 239);
            this.gp1.TabIndex = 118;
            this.gp1.TabStop = false;
            // 
            // btnctaact
            // 
            this.btnctaact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnctaact.BackgroundImage")));
            this.btnctaact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnctaact.Enabled = false;
            this.btnctaact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnctaact.Location = new System.Drawing.Point(219, 140);
            this.btnctaact.Name = "btnctaact";
            this.btnctaact.Size = new System.Drawing.Size(20, 21);
            this.btnctaact.TabIndex = 126;
            this.btnctaact.UseVisualStyleBackColor = true;
            this.btnctaact.Click += new System.EventHandler(this.btnctaact_Click);
            // 
            // btnctactble
            // 
            this.btnctactble.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnctactble.BackgroundImage")));
            this.btnctactble.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnctactble.Enabled = false;
            this.btnctactble.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnctactble.Location = new System.Drawing.Point(445, 140);
            this.btnctactble.Name = "btnctactble";
            this.btnctactble.Size = new System.Drawing.Size(20, 21);
            this.btnctactble.TabIndex = 125;
            this.btnctactble.UseVisualStyleBackColor = true;
            this.btnctactble.Click += new System.EventHandler(this.btnctactble_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(256, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 123;
            this.label13.Text = "Cta.Ctble.";
            // 
            // txtctacble
            // 
            this.txtctacble.Enabled = false;
            this.txtctacble.Location = new System.Drawing.Point(317, 140);
            this.txtctacble.Name = "txtctacble";
            this.txtctacble.Size = new System.Drawing.Size(122, 20);
            this.txtctacble.TabIndex = 124;
            this.txtctacble.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 121;
            this.label12.Text = "Cta.Ctble.Activo";
            // 
            // txtcntctbleact
            // 
            this.txtcntctbleact.Enabled = false;
            this.txtcntctbleact.Location = new System.Drawing.Point(90, 140);
            this.txtcntctbleact.Name = "txtcntctbleact";
            this.txtcntctbleact.Size = new System.Drawing.Size(122, 20);
            this.txtcntctbleact.TabIndex = 122;
            this.txtcntctbleact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btncentro
            // 
            this.btncentro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncentro.BackgroundImage")));
            this.btncentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncentro.Enabled = false;
            this.btncentro.FlatAppearance.BorderSize = 0;
            this.btncentro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncentro.Location = new System.Drawing.Point(445, 164);
            this.btncentro.Name = "btncentro";
            this.btncentro.Size = new System.Drawing.Size(20, 21);
            this.btncentro.TabIndex = 120;
            this.btncentro.UseVisualStyleBackColor = true;
            this.btncentro.Click += new System.EventHandler(this.btncentro_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 119;
            this.label11.Text = "Centro  Costo:";
            // 
            // cbocentrocosto
            // 
            this.cbocentrocosto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbocentrocosto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbocentrocosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbocentrocosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocentrocosto.FormattingEnabled = true;
            this.cbocentrocosto.Location = new System.Drawing.Point(90, 164);
            this.cbocentrocosto.Name = "cbocentrocosto";
            this.cbocentrocosto.Size = new System.Drawing.Size(349, 21);
            this.cbocentrocosto.TabIndex = 118;
            // 
            // frmArticuloServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 614);
            this.Controls.Add(this.gp1);
            this.Controls.Add(this.veri);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txtbusca);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.MaximumSize = new System.Drawing.Size(600, 653);
            this.MinimumSize = new System.Drawing.Size(600, 653);
            this.Name = "frmArticuloServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo/Servicio";
            this.Activated += new System.EventHandler(this.frmArticuloServicio_Activated);
            this.Load += new System.EventHandler(this.frmArticuloServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veri)).EndInit();
            this.gp1.ResumeLayout(false);
            this.gp1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.ToolTip tipmsg;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txtbusca;
        private Dtgconten dtgconten;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.ComboBox cbomarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbomodelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtobservacion;
        private System.Windows.Forms.Button btnmarcamas;
        private System.Windows.Forms.Button btnmodelomas;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.DataGridView veri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkcentro;
        private System.Windows.Forms.CheckBox chkigv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbocuenta;
        private System.Windows.Forms.GroupBox gp1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbocentrocosto;
        private System.Windows.Forms.Button btncentro;
        private System.Windows.Forms.Button btnctaact;
        private System.Windows.Forms.Button btnctactble;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtctacble;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcntctbleact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ida;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn idc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn cc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn centrodecosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctaactivox;
    }
}