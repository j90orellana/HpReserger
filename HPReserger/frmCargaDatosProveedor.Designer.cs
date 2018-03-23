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
            this.label1 = new System.Windows.Forms.Label();
            this.Dtguias = new System.Windows.Forms.DataGridView();
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
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbanco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcuenta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dtguias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Proveedores";
            // 
            // Dtguias
            // 
            this.Dtguias.AllowUserToAddRows = false;
            this.Dtguias.AllowUserToDeleteRows = false;
            this.Dtguias.AllowUserToResizeColumns = false;
            this.Dtguias.AllowUserToResizeRows = false;
            this.Dtguias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtguias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtguias.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dtguias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dtguias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtguias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.BANCOCUENTASOLES});
            this.Dtguias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.Dtguias.Location = new System.Drawing.Point(15, 97);
            this.Dtguias.MultiSelect = false;
            this.Dtguias.Name = "Dtguias";
            this.Dtguias.RowHeadersVisible = false;
            this.Dtguias.RowTemplate.Height = 16;
            this.Dtguias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtguias.Size = new System.Drawing.Size(998, 210);
            this.Dtguias.TabIndex = 41;
            this.Dtguias.TabStop = false;
            // 
            // Ruc
            // 
            this.Ruc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ruc.DataPropertyName = "ruc";
            this.Ruc.HeaderText = "RUC";
            this.Ruc.MinimumWidth = 40;
            this.Ruc.Name = "Ruc";
            this.Ruc.ReadOnly = true;
            this.Ruc.Width = 55;
            // 
            // RAZONSOCIAL
            // 
            this.RAZONSOCIAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RAZONSOCIAL.DataPropertyName = "razon_social";
            this.RAZONSOCIAL.HeaderText = "Razón Social";
            this.RAZONSOCIAL.Name = "RAZONSOCIAL";
            this.RAZONSOCIAL.ReadOnly = true;
            // 
            // NOMBRECOMERCIAL
            // 
            this.NOMBRECOMERCIAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOMBRECOMERCIAL.DataPropertyName = "nombre_comercial";
            this.NOMBRECOMERCIAL.HeaderText = "Nombre Comercial";
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
            this.PERSONATIPO.Width = 87;
            // 
            // BANCOSOLES
            // 
            this.BANCOSOLES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BANCOSOLES.DataPropertyName = "banco_cta_soles";
            this.BANCOSOLES.HeaderText = "Banco Soles";
            this.BANCOSOLES.Name = "BANCOSOLES";
            this.BANCOSOLES.Visible = false;
            // 
            // ENTIDADFINANCIERA
            // 
            this.ENTIDADFINANCIERA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ENTIDADFINANCIERA.DataPropertyName = "ENTIDAD_FINANCIERA";
            this.ENTIDADFINANCIERA.HeaderText = "Banco Soles";
            this.ENTIDADFINANCIERA.Name = "ENTIDADFINANCIERA";
            this.ENTIDADFINANCIERA.ReadOnly = true;
            this.ENTIDADFINANCIERA.Width = 85;
            // 
            // CUENTASELECCIONADA
            // 
            this.CUENTASELECCIONADA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CUENTASELECCIONADA.DataPropertyName = "CTASELECCIONADA";
            this.CUENTASELECCIONADA.HeaderText = "Cta Seleccionada";
            this.CUENTASELECCIONADA.Name = "CUENTASELECCIONADA";
            this.CUENTASELECCIONADA.ReadOnly = true;
            this.CUENTASELECCIONADA.Width = 106;
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
            this.CUENTASOLES.HeaderText = "Cuenta Soles";
            this.CUENTASOLES.Name = "CUENTASOLES";
            this.CUENTASOLES.ReadOnly = true;
            this.CUENTASOLES.Width = 87;
            // 
            // CUENTACCISOLES
            // 
            this.CUENTACCISOLES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CUENTACCISOLES.DataPropertyName = "nro_cta_cci_soles";
            this.CUENTACCISOLES.HeaderText = "Cta Cci Soles";
            this.CUENTACCISOLES.Name = "CUENTACCISOLES";
            this.CUENTACCISOLES.ReadOnly = true;
            this.CUENTACCISOLES.Width = 87;
            // 
            // BANCOCUENTASOLES
            // 
            this.BANCOCUENTASOLES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BANCOCUENTASOLES.DataPropertyName = "BANCO_CTA_SOLES";
            this.BANCOCUENTASOLES.HeaderText = "BancoCuentaSoles";
            this.BANCOCUENTASOLES.Name = "BANCOCUENTASOLES";
            this.BANCOCUENTASOLES.Visible = false;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnaceptar.Location = new System.Drawing.Point(854, 313);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 42;
            this.btnaceptar.Text = "Generar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Location = new System.Drawing.Point(935, 313);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 43;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Banco Seleccionado:";
            // 
            // txtbanco
            // 
            this.txtbanco.Location = new System.Drawing.Point(130, 22);
            this.txtbanco.Name = "txtbanco";
            this.txtbanco.ReadOnly = true;
            this.txtbanco.Size = new System.Drawing.Size(227, 20);
            this.txtbanco.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Cuenta Seleccionada:";
            // 
            // txtcuenta
            // 
            this.txtcuenta.Location = new System.Drawing.Point(130, 48);
            this.txtcuenta.Name = "txtcuenta";
            this.txtcuenta.ReadOnly = true;
            this.txtcuenta.Size = new System.Drawing.Size(227, 20);
            this.txtcuenta.TabIndex = 47;
            // 
            // frmCargaDatosProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 348);
            this.Controls.Add(this.txtcuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbanco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.Dtguias);
            this.Controls.Add(this.label1);
            this.Name = "frmCargaDatosProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione Los Bancos de Los Proveedores";
            this.Load += new System.EventHandler(this.frmCargaDatosProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtguias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dtguias;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtbanco;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtcuenta;
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
    }
}