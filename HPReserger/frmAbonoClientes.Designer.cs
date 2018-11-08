namespace HPReserger
{
    partial class frmAbonoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbonoClientes));
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lkldocpago = new System.Windows.Forms.LinkLabel();
            this.panelllenado = new HpResergerUserControls.PanelOre();
            this.dtpabono = new System.Windows.Forms.DateTimePicker();
            this.txttipocambio = new HpResergerUserControls.TextBoxPer();
            this.txtdocpago = new HpResergerUserControls.TextBoxPer();
            this.label21 = new System.Windows.Forms.Label();
            this.btnimagendoc = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtimporte = new HpResergerUserControls.TextBoxPer();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.separadorOre4 = new HpResergerUserControls.SeparadorOre();
            this.separadorOre1 = new HpResergerUserControls.SeparadorOre();
            this.label28 = new System.Windows.Forms.Label();
            this.txtmoneda = new HpResergerUserControls.TextBoxPer();
            this.panelllenado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnaceptar.Enabled = false;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.ForeColor = System.Drawing.Color.White;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(759, 429);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 25);
            this.btnaceptar.TabIndex = 227;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(847, 429);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 25);
            this.btncancelar.TabIndex = 228;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // lkldocpago
            // 
            this.lkldocpago.AutoSize = true;
            this.lkldocpago.BackColor = System.Drawing.Color.Transparent;
            this.lkldocpago.Location = new System.Drawing.Point(616, 199);
            this.lkldocpago.Name = "lkldocpago";
            this.lkldocpago.Size = new System.Drawing.Size(43, 13);
            this.lkldocpago.TabIndex = 230;
            this.lkldocpago.TabStop = true;
            this.lkldocpago.Text = "Ver Pdf";
            // 
            // panelllenado
            // 
            this.panelllenado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelllenado.BackColor = System.Drawing.Color.Transparent;
            this.panelllenado.Controls.Add(this.txtmoneda);
            this.panelllenado.Controls.Add(this.dtpabono);
            this.panelllenado.Controls.Add(this.txttipocambio);
            this.panelllenado.Controls.Add(this.txtdocpago);
            this.panelllenado.Controls.Add(this.label21);
            this.panelllenado.Controls.Add(this.btnimagendoc);
            this.panelllenado.Controls.Add(this.label20);
            this.panelllenado.Controls.Add(this.txtimporte);
            this.panelllenado.Controls.Add(this.label17);
            this.panelllenado.Controls.Add(this.label9);
            this.panelllenado.Controls.Add(this.label15);
            this.panelllenado.Location = new System.Drawing.Point(0, 170);
            this.panelllenado.Movible = false;
            this.panelllenado.Name = "panelllenado";
            this.panelllenado.Size = new System.Drawing.Size(610, 50);
            this.panelllenado.TabIndex = 231;
            // 
            // dtpabono
            // 
            this.dtpabono.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpabono.Location = new System.Drawing.Point(404, 1);
            this.dtpabono.Name = "dtpabono";
            this.dtpabono.Size = new System.Drawing.Size(97, 22);
            this.dtpabono.TabIndex = 8;
            // 
            // txttipocambio
            // 
            this.txttipocambio.BackColor = System.Drawing.Color.White;
            this.txttipocambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttipocambio.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txttipocambio.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txttipocambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipocambio.ForeColor = System.Drawing.Color.Black;
            this.txttipocambio.Location = new System.Drawing.Point(554, 1);
            this.txttipocambio.MaxLength = 10;
            this.txttipocambio.Name = "txttipocambio";
            this.txttipocambio.NextControlOnEnter = this.dtpabono;
            this.txttipocambio.Size = new System.Drawing.Size(50, 21);
            this.txttipocambio.TabIndex = 7;
            this.txttipocambio.Text = "3.30";
            this.txttipocambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttipocambio.TextoDefecto = "3.30";
            this.txttipocambio.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txttipocambio.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // txtdocpago
            // 
            this.txtdocpago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtdocpago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdocpago.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtdocpago.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtdocpago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocpago.ForeColor = System.Drawing.Color.Black;
            this.txtdocpago.Location = new System.Drawing.Point(80, 25);
            this.txtdocpago.MaxLength = 100;
            this.txtdocpago.Name = "txtdocpago";
            this.txtdocpago.NextControlOnEnter = null;
            this.txtdocpago.ReadOnly = true;
            this.txtdocpago.Size = new System.Drawing.Size(498, 21);
            this.txtdocpago.TabIndex = 144;
            this.txtdocpago.Text = "Nombre Del Documento De Pago";
            this.txtdocpago.TextoDefecto = "Nombre del Documento de Pago";
            this.txtdocpago.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtdocpago.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(351, 5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 13);
            this.label21.TabIndex = 189;
            this.label21.Text = "Fec.Pago:";
            // 
            // btnimagendoc
            // 
            this.btnimagendoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnimagendoc.BackgroundImage")));
            this.btnimagendoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnimagendoc.FlatAppearance.BorderSize = 0;
            this.btnimagendoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimagendoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimagendoc.Location = new System.Drawing.Point(584, 25);
            this.btnimagendoc.Name = "btnimagendoc";
            this.btnimagendoc.Size = new System.Drawing.Size(20, 20);
            this.btnimagendoc.TabIndex = 9;
            this.btnimagendoc.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(23, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 13);
            this.label20.TabIndex = 185;
            this.label20.Text = "Doc.Pago:";
            // 
            // txtimporte
            // 
            this.txtimporte.BackColor = System.Drawing.Color.White;
            this.txtimporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtimporte.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtimporte.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtimporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimporte.ForeColor = System.Drawing.Color.Black;
            this.txtimporte.Location = new System.Drawing.Point(80, 1);
            this.txtimporte.MaxLength = 20;
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(102, 21);
            this.txtimporte.TabIndex = 5;
            this.txtimporte.Text = "0.00";
            this.txtimporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtimporte.TextoDefecto = "0.00";
            this.txtimporte.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtimporte.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(2, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 181;
            this.label9.Text = "MontoAbono:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(189, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 182;
            this.label15.Text = "Moneda:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(499, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 181;
            this.label17.Text = "T.Cambio:";
            // 
            // separadorOre4
            // 
            this.separadorOre4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separadorOre4.Location = new System.Drawing.Point(0, 150);
            this.separadorOre4.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre4.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre4.Name = "separadorOre4";
            this.separadorOre4.Size = new System.Drawing.Size(945, 2);
            this.separadorOre4.TabIndex = 232;
            // 
            // separadorOre1
            // 
            this.separadorOre1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separadorOre1.Location = new System.Drawing.Point(0, 222);
            this.separadorOre1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre1.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre1.Name = "separadorOre1";
            this.separadorOre1.Size = new System.Drawing.Size(945, 2);
            this.separadorOre1.TabIndex = 233;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(8, 154);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(104, 13);
            this.label28.TabIndex = 234;
            this.label28.Text = "Detalle del Abono:";
            // 
            // txtmoneda
            // 
            this.txtmoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtmoneda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmoneda.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtmoneda.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtmoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmoneda.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtmoneda.Location = new System.Drawing.Point(245, 1);
            this.txtmoneda.MaxLength = 100;
            this.txtmoneda.Name = "txtmoneda";
            this.txtmoneda.NextControlOnEnter = null;
            this.txtmoneda.ReadOnly = true;
            this.txtmoneda.Size = new System.Drawing.Size(100, 21);
            this.txtmoneda.TabIndex = 240;
            this.txtmoneda.Text = "Moneda";
            this.txtmoneda.TextoDefecto = "Moneda";
            this.txtmoneda.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtmoneda.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // frmAbonoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 462);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.separadorOre1);
            this.Controls.Add(this.separadorOre4);
            this.Controls.Add(this.lkldocpago);
            this.Controls.Add(this.panelllenado);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAbonoClientes";
            this.Nombre = "Abono Clientes";
            this.Text = "Abono Clientes";
            this.Load += new System.EventHandler(this.frmAbonoClientes_Load);
            this.panelllenado.ResumeLayout(false);
            this.panelllenado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.LinkLabel lkldocpago;
        private HpResergerUserControls.PanelOre panelllenado;
        private System.Windows.Forms.DateTimePicker dtpabono;
        private HpResergerUserControls.TextBoxPer txttipocambio;
        private HpResergerUserControls.TextBoxPer txtdocpago;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnimagendoc;
        private System.Windows.Forms.Label label20;
        private HpResergerUserControls.TextBoxPer txtimporte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private HpResergerUserControls.SeparadorOre separadorOre4;
        private HpResergerUserControls.SeparadorOre separadorOre1;
        private System.Windows.Forms.Label label28;
        private HpResergerUserControls.TextBoxPer txtmoneda;
    }
}