using HpResergerUserControls;

namespace HPReserger
{
    partial class frmCargaDatosProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaDatosProveedor));
            this.label1 = new System.Windows.Forms.Label();
            this.Dtguias = new HpResergerUserControls.Dtgconten();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbanco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcuenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.separadorOre1 = new HpResergerUserControls.SeparadorOre();
            this.xTipId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZONSOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRECOMERCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOPERSONA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERSONATIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANCOSOLES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENTIDADFINANCIERA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTASELECCIONADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOCUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTASOLES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTACCISOLES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANCOCUENTASOLES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dtguias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Proveedores:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dtguias
            // 
            this.Dtguias.AllowUserToAddRows = false;
            this.Dtguias.AllowUserToDeleteRows = false;
            this.Dtguias.AllowUserToResizeColumns = false;
            this.Dtguias.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.Dtguias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtguias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtguias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtguias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.Dtguias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dtguias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dtguias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtguias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dtguias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtguias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xTipId,
            this.Ruc,
            this.RAZONSOCIAL,
            this.NOMBRECOMERCIAL,
            this.TIPOPERSONA,
            this.PERSONATIPO,
            this.BANCOSOLES,
            this.ENTIDADFINANCIERA,
            this.CUENTASELECCIONADA,
            this.TIPOCUENTA,
            this.CUENTASOLES,
            this.CUENTACCISOLES,
            this.BANCOCUENTASOLES,
            this.xEMAIL,
            this.xmoneda});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dtguias.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dtguias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.Dtguias.EnableHeadersVisualStyles = false;
            this.Dtguias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.Dtguias.Location = new System.Drawing.Point(15, 69);
            this.Dtguias.MultiSelect = false;
            this.Dtguias.Name = "Dtguias";
            this.Dtguias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dtguias.RowHeadersVisible = false;
            this.Dtguias.RowTemplate.Height = 16;
            this.Dtguias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtguias.Size = new System.Drawing.Size(998, 244);
            this.Dtguias.TabIndex = 41;
            this.Dtguias.TabStop = false;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnaceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(836, 319);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(85, 23);
            this.btnaceptar.TabIndex = 42;
            this.btnaceptar.Text = "Generar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(925, 319);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(85, 23);
            this.btncancelar.TabIndex = 43;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Banco Seleccionado:";
            // 
            // txtbanco
            // 
            this.txtbanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtbanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbanco.Location = new System.Drawing.Point(129, 25);
            this.txtbanco.Name = "txtbanco";
            this.txtbanco.ReadOnly = true;
            this.txtbanco.Size = new System.Drawing.Size(227, 21);
            this.txtbanco.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Cuenta Seleccionada:";
            // 
            // txtcuenta
            // 
            this.txtcuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcuenta.Location = new System.Drawing.Point(489, 25);
            this.txtcuenta.Name = "txtcuenta";
            this.txtcuenta.ReadOnly = true;
            this.txtcuenta.Size = new System.Drawing.Size(227, 21);
            this.txtcuenta.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Datos de la Cuenta de Abono:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // separadorOre1
            // 
            this.separadorOre1.BackColor = System.Drawing.Color.Transparent;
            this.separadorOre1.Location = new System.Drawing.Point(0, 48);
            this.separadorOre1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre1.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre1.Name = "separadorOre1";
            this.separadorOre1.Size = new System.Drawing.Size(1028, 2);
            this.separadorOre1.TabIndex = 48;
            // 
            // xTipId
            // 
            this.xTipId.DataPropertyName = "tipoid";
            this.xTipId.HeaderText = "TipoId";
            this.xTipId.Name = "xTipId";
            this.xTipId.Visible = false;
            // 
            // Ruc
            // 
            this.Ruc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ruc.DataPropertyName = "ruc";
            this.Ruc.HeaderText = "RUC";
            this.Ruc.MinimumWidth = 40;
            this.Ruc.Name = "Ruc";
            this.Ruc.ReadOnly = true;
            this.Ruc.Width = 54;
            // 
            // RAZONSOCIAL
            // 
            this.RAZONSOCIAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RAZONSOCIAL.DataPropertyName = "razon_social";
            this.RAZONSOCIAL.HeaderText = "Razón Social";
            this.RAZONSOCIAL.MinimumWidth = 80;
            this.RAZONSOCIAL.Name = "RAZONSOCIAL";
            this.RAZONSOCIAL.ReadOnly = true;
            // 
            // NOMBRECOMERCIAL
            // 
            this.NOMBRECOMERCIAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOMBRECOMERCIAL.DataPropertyName = "nombre_comercial";
            this.NOMBRECOMERCIAL.HeaderText = "Nombre Comercial";
            this.NOMBRECOMERCIAL.MinimumWidth = 80;
            this.NOMBRECOMERCIAL.Name = "NOMBRECOMERCIAL";
            this.NOMBRECOMERCIAL.ReadOnly = true;
            // 
            // TIPOPERSONA
            // 
            this.TIPOPERSONA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TIPOPERSONA.DataPropertyName = "TIPO_PERSONA";
            this.TIPOPERSONA.HeaderText = "Tipo Persona";
            this.TIPOPERSONA.Name = "TIPOPERSONA";
            this.TIPOPERSONA.Visible = false;
            // 
            // PERSONATIPO
            // 
            this.PERSONATIPO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PERSONATIPO.DataPropertyName = "PERSONA_TIPO";
            this.PERSONATIPO.HeaderText = "Tipo Persona";
            this.PERSONATIPO.Name = "PERSONATIPO";
            this.PERSONATIPO.ReadOnly = true;
            // 
            // BANCOSOLES
            // 
            this.BANCOSOLES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BANCOSOLES.DataPropertyName = "banco_cta_soles";
            this.BANCOSOLES.HeaderText = "Banco Soles";
            this.BANCOSOLES.Name = "BANCOSOLES";
            this.BANCOSOLES.Visible = false;
            this.BANCOSOLES.Width = 94;
            // 
            // ENTIDADFINANCIERA
            // 
            this.ENTIDADFINANCIERA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ENTIDADFINANCIERA.DataPropertyName = "ENTIDAD_FINANCIERA";
            this.ENTIDADFINANCIERA.HeaderText = "Banco Soles";
            this.ENTIDADFINANCIERA.Name = "ENTIDADFINANCIERA";
            this.ENTIDADFINANCIERA.ReadOnly = true;
            this.ENTIDADFINANCIERA.Width = 94;
            // 
            // CUENTASELECCIONADA
            // 
            this.CUENTASELECCIONADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CUENTASELECCIONADA.DataPropertyName = "CTASELECCIONADA";
            this.CUENTASELECCIONADA.HeaderText = "Cta Seleccionada";
            this.CUENTASELECCIONADA.Name = "CUENTASELECCIONADA";
            this.CUENTASELECCIONADA.ReadOnly = true;
            this.CUENTASELECCIONADA.Width = 111;
            // 
            // TIPOCUENTA
            // 
            this.TIPOCUENTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TIPOCUENTA.DataPropertyName = "TIPOCUENTA";
            this.TIPOCUENTA.HeaderText = "Tipo Cuenta";
            this.TIPOCUENTA.MinimumWidth = 70;
            this.TIPOCUENTA.Name = "TIPOCUENTA";
            this.TIPOCUENTA.Width = 70;
            // 
            // CUENTASOLES
            // 
            this.CUENTASOLES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CUENTASOLES.DataPropertyName = "NRO_CTA_SOLES";
            this.CUENTASOLES.HeaderText = "Cuenta-Mon";
            this.CUENTASOLES.Name = "CUENTASOLES";
            this.CUENTASOLES.ReadOnly = true;
            this.CUENTASOLES.Width = 99;
            // 
            // CUENTACCISOLES
            // 
            this.CUENTACCISOLES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CUENTACCISOLES.DataPropertyName = "nro_cta_cci_soles";
            this.CUENTACCISOLES.HeaderText = "CtaCci-Mon";
            this.CUENTACCISOLES.Name = "CUENTACCISOLES";
            this.CUENTACCISOLES.ReadOnly = true;
            this.CUENTACCISOLES.Width = 96;
            // 
            // BANCOCUENTASOLES
            // 
            this.BANCOCUENTASOLES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BANCOCUENTASOLES.DataPropertyName = "BANCO_CTA_SOLES";
            this.BANCOCUENTASOLES.HeaderText = "BancoCuentaSoles";
            this.BANCOCUENTASOLES.Name = "BANCOCUENTASOLES";
            this.BANCOCUENTASOLES.Visible = false;
            this.BANCOCUENTASOLES.Width = 129;
            // 
            // xEMAIL
            // 
            this.xEMAIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xEMAIL.DataPropertyName = "email";
            this.xEMAIL.HeaderText = "Email";
            this.xEMAIL.Name = "xEMAIL";
            this.xEMAIL.Width = 60;
            // 
            // xmoneda
            // 
            this.xmoneda.DataPropertyName = "moneda";
            this.xmoneda.HeaderText = "moneda";
            this.xmoneda.Name = "xmoneda";
            this.xmoneda.Visible = false;
            // 
            // frmCargaDatosProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 348);
            this.Controls.Add(this.separadorOre1);
            this.Controls.Add(this.txtcuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbanco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.Dtguias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmCargaDatosProveedor";
            this.Nombre = "Seleccione Los Bancos de Los Proveedores";
            this.Text = "Seleccione Los Bancos de Los Proveedores";
            this.Load += new System.EventHandler(this.frmCargaDatosProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtguias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Dtgconten Dtguias;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtbanco;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtcuenta;
        private System.Windows.Forms.Label label4;
        private SeparadorOre separadorOre1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xTipId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZONSOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRECOMERCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOPERSONA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERSONATIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANCOSOLES;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENTIDADFINANCIERA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTASELECCIONADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOCUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTASOLES;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTACCISOLES;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANCOCUENTASOLES;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmoneda;
    }
}