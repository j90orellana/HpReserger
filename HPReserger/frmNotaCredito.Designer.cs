namespace HPReserger
{
    partial class frmNotaCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotaCredito));
            this.txtcodnota = new System.Windows.Forms.TextBox();
            this.lblnota = new System.Windows.Forms.Label();
            this.txtnronota = new System.Windows.Forms.TextBox();
            this.btnmaspro = new System.Windows.Forms.Button();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbofacturas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmoneda = new System.Windows.Forms.TextBox();
            this.txtruc = new HpResergerUserControls.TextBoxPer();
            this.btndetalle = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsubtotal = new HpResergerUserControls.TextBoxPer();
            this.txtigv = new HpResergerUserControls.TextBoxPer();
            this.txttotal = new HpResergerUserControls.TextBoxPer();
            this.txttotalm = new HpResergerUserControls.TextBoxPer();
            this.txtglosa = new HpResergerUserControls.TextBoxPer();
            this.txtigvm = new HpResergerUserControls.TextBoxPer();
            this.txtsubtotalm = new HpResergerUserControls.TextBoxPer();
            this.panelOre1 = new HpResergerUserControls.PanelOre();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbotiponota = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelOre1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcodnota
            // 
            this.txtcodnota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodnota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodnota.Location = new System.Drawing.Point(94, 9);
            this.txtcodnota.Name = "txtcodnota";
            this.txtcodnota.Size = new System.Drawing.Size(37, 21);
            this.txtcodnota.TabIndex = 1;
            this.txtcodnota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodfactura_KeyPress);
            this.txtcodnota.Leave += new System.EventHandler(this.txtcodfactura_Leave);
            // 
            // lblnota
            // 
            this.lblnota.AutoSize = true;
            this.lblnota.BackColor = System.Drawing.Color.Transparent;
            this.lblnota.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota.Location = new System.Drawing.Point(14, 13);
            this.lblnota.Name = "lblnota";
            this.lblnota.Size = new System.Drawing.Size(81, 13);
            this.lblnota.TabIndex = 27;
            this.lblnota.Text = "Nro N.Crédito:";
            // 
            // txtnronota
            // 
            this.txtnronota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnronota.Location = new System.Drawing.Point(134, 9);
            this.txtnronota.Name = "txtnronota";
            this.txtnronota.Size = new System.Drawing.Size(87, 21);
            this.txtnronota.TabIndex = 2;
            this.txtnronota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnrofactura_KeyPress);
            this.txtnronota.Leave += new System.EventHandler(this.txtnrofactura_Leave);
            // 
            // btnmaspro
            // 
            this.btnmaspro.BackColor = System.Drawing.SystemColors.Control;
            this.btnmaspro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmaspro.BackgroundImage")));
            this.btnmaspro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmaspro.FlatAppearance.BorderSize = 0;
            this.btnmaspro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmaspro.Location = new System.Drawing.Point(438, 9);
            this.btnmaspro.Name = "btnmaspro";
            this.btnmaspro.Size = new System.Drawing.Size(20, 20);
            this.btnmaspro.TabIndex = 31;
            this.toolTip1.SetToolTip(this.btnmaspro, "Buscar Proveedor");
            this.btnmaspro.UseVisualStyleBackColor = false;
            this.btnmaspro.Click += new System.EventHandler(this.btnmaspro_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(94, 32);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(339, 21);
            this.txtRazonSocial.TabIndex = 25;
            this.txtRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Razon Social:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ruc Proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nro Factura:";
            // 
            // cbofacturas
            // 
            this.cbofacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbofacturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbofacturas.FormattingEnabled = true;
            this.cbofacturas.Location = new System.Drawing.Point(94, 55);
            this.cbofacturas.Name = "cbofacturas";
            this.cbofacturas.Size = new System.Drawing.Size(127, 21);
            this.cbofacturas.TabIndex = 4;
            this.cbofacturas.SelectedIndexChanged += new System.EventHandler(this.cbofacturas_SelectedIndexChanged);
            this.cbofacturas.TextChanged += new System.EventHandler(this.cbofacturas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Moneda:";
            // 
            // txtmoneda
            // 
            this.txtmoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtmoneda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmoneda.Location = new System.Drawing.Point(315, 55);
            this.txtmoneda.MaxLength = 11;
            this.txtmoneda.Name = "txtmoneda";
            this.txtmoneda.ReadOnly = true;
            this.txtmoneda.Size = new System.Drawing.Size(118, 21);
            this.txtmoneda.TabIndex = 5;
            this.txtmoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtruc
            // 
            this.txtruc.BackColor = System.Drawing.Color.White;
            this.txtruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtruc.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtruc.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruc.ForeColor = System.Drawing.Color.Black;
            this.txtruc.Format = null;
            this.txtruc.Location = new System.Drawing.Point(315, 9);
            this.txtruc.MaxLength = 11;
            this.txtruc.Name = "txtruc";
            this.txtruc.NextControlOnEnter = null;
            this.txtruc.Size = new System.Drawing.Size(118, 21);
            this.txtruc.TabIndex = 3;
            this.txtruc.Text = "0";
            this.txtruc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtruc.TextoDefecto = "0";
            this.txtruc.TextoDefectoColor = System.Drawing.Color.Black;
            this.txtruc.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            this.txtruc.TextChanged += new System.EventHandler(this.txtruc_TextChanged);
            // 
            // btndetalle
            // 
            this.btndetalle.Enabled = false;
            this.btndetalle.Image = ((System.Drawing.Image)(resources.GetObject("btndetalle.Image")));
            this.btndetalle.Location = new System.Drawing.Point(404, 23);
            this.btndetalle.Name = "btndetalle";
            this.btndetalle.Size = new System.Drawing.Size(75, 23);
            this.btndetalle.TabIndex = 38;
            this.btndetalle.Text = "Detalle";
            this.btndetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndetalle.UseVisualStyleBackColor = true;
            this.btndetalle.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnaceptar.Enabled = false;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(163, 206);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 36;
            this.btnaceptar.Text = "Guardar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(244, 206);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 37;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Subtotal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "I.G.V.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Total:";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtsubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsubtotal.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtsubtotal.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.ForeColor = System.Drawing.Color.Black;
            this.txtsubtotal.Format = null;
            this.txtsubtotal.Location = new System.Drawing.Point(100, 24);
            this.txtsubtotal.MaxLength = 100;
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.NextControlOnEnter = null;
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(128, 21);
            this.txtsubtotal.TabIndex = 43;
            this.txtsubtotal.Text = "0.00";
            this.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtsubtotal.TextoDefecto = "0.00";
            this.txtsubtotal.TextoDefectoColor = System.Drawing.Color.Black;
            this.txtsubtotal.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // txtigv
            // 
            this.txtigv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtigv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtigv.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtigv.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtigv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtigv.ForeColor = System.Drawing.Color.Black;
            this.txtigv.Format = null;
            this.txtigv.Location = new System.Drawing.Point(100, 47);
            this.txtigv.MaxLength = 100;
            this.txtigv.Name = "txtigv";
            this.txtigv.NextControlOnEnter = null;
            this.txtigv.ReadOnly = true;
            this.txtigv.Size = new System.Drawing.Size(128, 21);
            this.txtigv.TabIndex = 44;
            this.txtigv.Text = "0.00";
            this.txtigv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtigv.TextoDefecto = "0.00";
            this.txtigv.TextoDefectoColor = System.Drawing.Color.Black;
            this.txtigv.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotal.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txttotal.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.Color.Black;
            this.txttotal.Format = null;
            this.txttotal.Location = new System.Drawing.Point(100, 70);
            this.txttotal.MaxLength = 100;
            this.txttotal.Name = "txttotal";
            this.txttotal.NextControlOnEnter = null;
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(128, 21);
            this.txttotal.TabIndex = 45;
            this.txttotal.Text = "0.00";
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttotal.TextoDefecto = "0.00";
            this.txttotal.TextoDefectoColor = System.Drawing.Color.Black;
            this.txttotal.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // txttotalm
            // 
            this.txttotalm.BackColor = System.Drawing.Color.White;
            this.txttotalm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalm.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txttotalm.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txttotalm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalm.ForeColor = System.Drawing.Color.Black;
            this.txttotalm.Format = null;
            this.txttotalm.Location = new System.Drawing.Point(270, 70);
            this.txttotalm.MaxLength = 100;
            this.txttotalm.Name = "txttotalm";
            this.txttotalm.NextControlOnEnter = this.txtglosa;
            this.txttotalm.Size = new System.Drawing.Size(128, 21);
            this.txttotalm.TabIndex = 48;
            this.txttotalm.Text = "0.00";
            this.txttotalm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttotalm.TextoDefecto = "0.00";
            this.txttotalm.TextoDefectoColor = System.Drawing.Color.Black;
            this.txttotalm.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            this.txttotalm.Leave += new System.EventHandler(this.txttotalm_Leave);
            // 
            // txtglosa
            // 
            this.txtglosa.BackColor = System.Drawing.Color.White;
            this.txtglosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtglosa.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtglosa.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtglosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtglosa.ForeColor = System.Drawing.Color.Black;
            this.txtglosa.Format = null;
            this.txtglosa.Location = new System.Drawing.Point(100, 93);
            this.txtglosa.MaxLength = 100;
            this.txtglosa.Name = "txtglosa";
            this.txtglosa.NextControlOnEnter = this.btnaceptar;
            this.txtglosa.Size = new System.Drawing.Size(298, 21);
            this.txtglosa.TabIndex = 51;
            this.txtglosa.Text = "Ingrese Glosa";
            this.txtglosa.TextoDefecto = "Ingrese Glosa";
            this.txtglosa.TextoDefectoColor = System.Drawing.Color.Black;
            this.txtglosa.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // txtigvm
            // 
            this.txtigvm.BackColor = System.Drawing.Color.White;
            this.txtigvm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtigvm.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtigvm.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtigvm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtigvm.ForeColor = System.Drawing.Color.Black;
            this.txtigvm.Format = null;
            this.txtigvm.Location = new System.Drawing.Point(270, 47);
            this.txtigvm.MaxLength = 100;
            this.txtigvm.Name = "txtigvm";
            this.txtigvm.NextControlOnEnter = this.txtsubtotalm;
            this.txtigvm.Size = new System.Drawing.Size(128, 21);
            this.txtigvm.TabIndex = 47;
            this.txtigvm.Text = "0.00";
            this.txtigvm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtigvm.TextoDefecto = "0.00";
            this.txtigvm.TextoDefectoColor = System.Drawing.Color.Black;
            this.txtigvm.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            this.txtigvm.Leave += new System.EventHandler(this.txtigvm_Leave);
            // 
            // txtsubtotalm
            // 
            this.txtsubtotalm.BackColor = System.Drawing.Color.White;
            this.txtsubtotalm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsubtotalm.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtsubtotalm.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtsubtotalm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotalm.ForeColor = System.Drawing.Color.Black;
            this.txtsubtotalm.Format = null;
            this.txtsubtotalm.Location = new System.Drawing.Point(270, 24);
            this.txtsubtotalm.MaxLength = 100;
            this.txtsubtotalm.Name = "txtsubtotalm";
            this.txtsubtotalm.NextControlOnEnter = this.txtigvm;
            this.txtsubtotalm.Size = new System.Drawing.Size(128, 21);
            this.txtsubtotalm.TabIndex = 46;
            this.txtsubtotalm.Text = "0.00";
            this.txtsubtotalm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtsubtotalm.TextoDefecto = "0.00";
            this.txtsubtotalm.TextoDefectoColor = System.Drawing.Color.Black;
            this.txtsubtotalm.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            this.txtsubtotalm.Leave += new System.EventHandler(this.txtsubtotalm_Leave);
            // 
            // panelOre1
            // 
            this.panelOre1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOre1.BackColor = System.Drawing.Color.Transparent;
            this.panelOre1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOre1.Controls.Add(this.txtglosa);
            this.panelOre1.Controls.Add(this.label11);
            this.panelOre1.Controls.Add(this.label10);
            this.panelOre1.Controls.Add(this.label9);
            this.panelOre1.Controls.Add(this.txtsubtotal);
            this.panelOre1.Controls.Add(this.txttotalm);
            this.panelOre1.Controls.Add(this.btndetalle);
            this.panelOre1.Controls.Add(this.txtigvm);
            this.panelOre1.Controls.Add(this.label6);
            this.panelOre1.Controls.Add(this.txtsubtotalm);
            this.panelOre1.Controls.Add(this.label7);
            this.panelOre1.Controls.Add(this.txttotal);
            this.panelOre1.Controls.Add(this.label8);
            this.panelOre1.Controls.Add(this.txtigv);
            this.panelOre1.Enabled = false;
            this.panelOre1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOre1.Location = new System.Drawing.Point(-8, 81);
            this.panelOre1.Movible = false;
            this.panelOre1.Name = "panelOre1";
            this.panelOre1.Size = new System.Drawing.Size(500, 121);
            this.panelOre1.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(59, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Glosa:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(270, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Modificado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(100, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Registrado";
            // 
            // cbotiponota
            // 
            this.cbotiponota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbotiponota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotiponota.FormattingEnabled = true;
            this.cbotiponota.Location = new System.Drawing.Point(331, 208);
            this.cbotiponota.Name = "cbotiponota";
            this.cbotiponota.Size = new System.Drawing.Size(127, 21);
            this.cbotiponota.TabIndex = 50;
            this.cbotiponota.Visible = false;
            this.cbotiponota.SelectedIndexChanged += new System.EventHandler(this.cbotiponota_SelectedIndexChanged);
            // 
            // frmNotaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 237);
            this.Controls.Add(this.cbotiponota);
            this.Controls.Add(this.panelOre1);
            this.Controls.Add(this.txtruc);
            this.Controls.Add(this.txtmoneda);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbofacturas);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcodnota);
            this.Controls.Add(this.lblnota);
            this.Controls.Add(this.txtnronota);
            this.Controls.Add(this.btnmaspro);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(499, 276);
            this.MinimumSize = new System.Drawing.Size(499, 276);
            this.Name = "frmNotaCredito";
            this.Nombre = "Nota Credito";
            this.Text = "Nota Credito";
            this.Load += new System.EventHandler(this.frmNotaCredito_Load);
            this.panelOre1.ResumeLayout(false);
            this.panelOre1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodnota;
        private System.Windows.Forms.Label lblnota;
        private System.Windows.Forms.TextBox txtnronota;
        private System.Windows.Forms.Button btnmaspro;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbofacturas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmoneda;
        private HpResergerUserControls.TextBoxPer txtruc;
        private System.Windows.Forms.Button btndetalle;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private HpResergerUserControls.TextBoxPer txtsubtotal;
        private HpResergerUserControls.TextBoxPer txtigv;
        private HpResergerUserControls.TextBoxPer txttotal;
        private HpResergerUserControls.TextBoxPer txttotalm;
        private HpResergerUserControls.TextBoxPer txtigvm;
        private HpResergerUserControls.TextBoxPer txtsubtotalm;
        private HpResergerUserControls.PanelOre panelOre1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private HpResergerUserControls.TextBoxPer txtglosa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbotiponota;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}