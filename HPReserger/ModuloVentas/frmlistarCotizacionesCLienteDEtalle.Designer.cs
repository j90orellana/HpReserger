namespace HPReserger
{
    partial class frmlistarCotizacionesCLienteDEtalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlistarCotizacionesCLienteDEtalle));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtnumcot = new HpResergerUserControls.TextBoxPer();
            this.txtnombre = new HpResergerUserControls.TextBoxPer();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnroid = new HpResergerUserControls.TextBoxPer();
            this.label3 = new System.Windows.Forms.Label();
            this.txttipoid = new HpResergerUserControls.TextBoxPer();
            this.label19 = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.txttipocambioref = new HpResergerUserControls.TextBoxPer();
            this.label7 = new System.Windows.Forms.Label();
            this.btnaddproducto = new System.Windows.Forms.Button();
            this.btnproductos = new System.Windows.Forms.Button();
            this.txtcodvendedor = new HpResergerUserControls.TextBoxPer();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreVendedor = new HpResergerUserControls.TextBoxPer();
            this.label14 = new System.Windows.Forms.Label();
            this.txtValorInicial = new HpResergerUserControls.TextBoxPer();
            this.label23 = new System.Windows.Forms.Label();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.idempresa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idproyecto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Etapa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idarticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantValido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Base = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TDesc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.VDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monedon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Coti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xsubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xigv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoLetras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsubtotal = new HpResergerUserControls.TextBoxPer();
            this.txtigv = new HpResergerUserControls.TextBoxPer();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txttotal = new HpResergerUserControls.TextBoxPer();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbldato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnumcot
            // 
            this.txtnumcot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtnumcot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumcot.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtnumcot.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtnumcot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumcot.ForeColor = System.Drawing.Color.Black;
            this.txtnumcot.Location = new System.Drawing.Point(64, 12);
            this.txtnumcot.MaxLength = 10;
            this.txtnumcot.Name = "txtnumcot";
            this.txtnumcot.NextControlOnEnter = this.txtnombre;
            this.txtnumcot.ReadOnly = true;
            this.txtnumcot.Size = new System.Drawing.Size(68, 21);
            this.txtnumcot.TabIndex = 149;
            this.txtnumcot.Text = "00000000";
            this.txtnumcot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnumcot.TextoDefecto = "00000000";
            this.txtnumcot.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtnumcot.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtnombre.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.Black;
            this.txtnombre.Location = new System.Drawing.Point(64, 37);
            this.txtnombre.MaxLength = 100;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.NextControlOnEnter = null;
            this.txtnombre.ReadOnly = true;
            this.txtnombre.Size = new System.Drawing.Size(235, 21);
            this.txtnombre.TabIndex = 144;
            this.txtnombre.Text = "Nombres Cliente";
            this.txtnombre.TextoDefecto = "Nombres Cliente";
            this.txtnombre.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtnombre.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 150;
            this.label6.Text = "Nro Cto.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 146;
            this.label4.Text = "Nombres";
            // 
            // txtnroid
            // 
            this.txtnroid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtnroid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnroid.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtnroid.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtnroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnroid.ForeColor = System.Drawing.Color.Black;
            this.txtnroid.Location = new System.Drawing.Point(353, 12);
            this.txtnroid.MaxLength = 10;
            this.txtnroid.Name = "txtnroid";
            this.txtnroid.NextControlOnEnter = this.txtnombre;
            this.txtnroid.ReadOnly = true;
            this.txtnroid.Size = new System.Drawing.Size(112, 21);
            this.txtnroid.TabIndex = 143;
            this.txtnroid.Text = "00000000";
            this.txtnroid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnroid.TextoDefecto = "00000000";
            this.txtnroid.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtnroid.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 145;
            this.label3.Text = "Nro Id";
            // 
            // txttipoid
            // 
            this.txttipoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txttipoid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttipoid.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txttipoid.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txttipoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipoid.ForeColor = System.Drawing.Color.Black;
            this.txttipoid.Location = new System.Drawing.Point(201, 12);
            this.txttipoid.MaxLength = 50;
            this.txttipoid.Name = "txttipoid";
            this.txttipoid.NextControlOnEnter = null;
            this.txttipoid.ReadOnly = true;
            this.txttipoid.Size = new System.Drawing.Size(98, 21);
            this.txttipoid.TabIndex = 153;
            this.txttipoid.Text = "Tipo Documento";
            this.txttipoid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttipoid.TextoDefecto = "Tipo Documento";
            this.txttipoid.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txttipoid.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(145, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 154;
            this.label19.Text = "Tipo Doc:";
            // 
            // btnmodificar
            // 
            this.btnmodificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnmodificar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnmodificar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.Location = new System.Drawing.Point(531, 357);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(82, 25);
            this.btnmodificar.TabIndex = 155;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnaceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnaceptar.Enabled = false;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.ForeColor = System.Drawing.Color.White;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(444, 357);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 25);
            this.btnaceptar.TabIndex = 156;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(617, 357);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 25);
            this.btncancelar.TabIndex = 157;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.Location = new System.Drawing.Point(12, 360);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(129, 16);
            this.lblmsg.TabIndex = 158;
            this.lblmsg.Text = "Total de Registros : 0";
            // 
            // txttipocambioref
            // 
            this.txttipocambioref.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txttipocambioref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttipocambioref.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txttipocambioref.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txttipocambioref.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipocambioref.ForeColor = System.Drawing.Color.Black;
            this.txttipocambioref.Location = new System.Drawing.Point(1037, 12);
            this.txttipocambioref.MaxLength = 10;
            this.txttipocambioref.Name = "txttipocambioref";
            this.txttipocambioref.NextControlOnEnter = null;
            this.txttipocambioref.ReadOnly = true;
            this.txttipocambioref.Size = new System.Drawing.Size(61, 21);
            this.txttipocambioref.TabIndex = 159;
            this.txttipocambioref.Text = "3.30";
            this.txttipocambioref.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttipocambioref.TextoDefecto = "3.30";
            this.txttipocambioref.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txttipocambioref.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            this.txttipocambioref.Visible = false;
            this.txttipocambioref.TextChanged += new System.EventHandler(this.txttipocambioref_TextChanged);
            this.txttipocambioref.Leave += new System.EventHandler(this.txttipocambioref_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(996, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 160;
            this.label7.Text = "T.C.R.";
            this.label7.Visible = false;
            // 
            // btnaddproducto
            // 
            this.btnaddproducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaddproducto.BackgroundImage")));
            this.btnaddproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaddproducto.Enabled = false;
            this.btnaddproducto.Location = new System.Drawing.Point(880, 37);
            this.btnaddproducto.Name = "btnaddproducto";
            this.btnaddproducto.Size = new System.Drawing.Size(21, 21);
            this.btnaddproducto.TabIndex = 162;
            this.btnaddproducto.UseVisualStyleBackColor = true;
            this.btnaddproducto.Click += new System.EventHandler(this.btnaddproducto_Click);
            // 
            // btnproductos
            // 
            this.btnproductos.Enabled = false;
            this.btnproductos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductos.Image = ((System.Drawing.Image)(resources.GetObject("btnproductos.Image")));
            this.btnproductos.Location = new System.Drawing.Point(904, 36);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(82, 23);
            this.btnproductos.TabIndex = 161;
            this.btnproductos.Text = "Productos";
            this.btnproductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnproductos.UseVisualStyleBackColor = true;
            this.btnproductos.Click += new System.EventHandler(this.btnproductos_Click);
            // 
            // txtcodvendedor
            // 
            this.txtcodvendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtcodvendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodvendedor.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtcodvendedor.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtcodvendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodvendedor.ForeColor = System.Drawing.Color.Black;
            this.txtcodvendedor.Location = new System.Drawing.Point(553, 12);
            this.txtcodvendedor.MaxLength = 8;
            this.txtcodvendedor.Name = "txtcodvendedor";
            this.txtcodvendedor.NextControlOnEnter = this.txtnombre;
            this.txtcodvendedor.ReadOnly = true;
            this.txtcodvendedor.Size = new System.Drawing.Size(84, 21);
            this.txtcodvendedor.TabIndex = 163;
            this.txtcodvendedor.Text = "000";
            this.txtcodvendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcodvendedor.TextoDefecto = "000";
            this.txtcodvendedor.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtcodvendedor.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            this.txtcodvendedor.TextChanged += new System.EventHandler(this.txtcodvendedor_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(471, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 166;
            this.label13.Text = "Cod.Vendedor:";
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtNombreVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreVendedor.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtNombreVendedor.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtNombreVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreVendedor.ForeColor = System.Drawing.Color.Black;
            this.txtNombreVendedor.Location = new System.Drawing.Point(688, 12);
            this.txtNombreVendedor.MaxLength = 100;
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.NextControlOnEnter = null;
            this.txtNombreVendedor.ReadOnly = true;
            this.txtNombreVendedor.Size = new System.Drawing.Size(298, 21);
            this.txtNombreVendedor.TabIndex = 164;
            this.txtNombreVendedor.Text = "Nombre Vendedor";
            this.txtNombreVendedor.TextoDefecto = "Nombre Vendedor";
            this.txtNombreVendedor.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtNombreVendedor.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(637, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 165;
            this.label14.Text = "Nombres:";
            // 
            // txtValorInicial
            // 
            this.txtValorInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtValorInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorInicial.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtValorInicial.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorInicial.ForeColor = System.Drawing.Color.Black;
            this.txtValorInicial.Location = new System.Drawing.Point(353, 37);
            this.txtValorInicial.MaxLength = 15;
            this.txtValorInicial.Name = "txtValorInicial";
            this.txtValorInicial.NextControlOnEnter = null;
            this.txtValorInicial.ReadOnly = true;
            this.txtValorInicial.Size = new System.Drawing.Size(84, 21);
            this.txtValorInicial.TabIndex = 168;
            this.txtValorInicial.Text = "0.00";
            this.txtValorInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorInicial.TextoDefecto = "0.00";
            this.txtValorInicial.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtValorInicial.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(314, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 13);
            this.label23.TabIndex = 167;
            this.label23.Text = "Inicial:";
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
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
            this.idempresa,
            this.idproyecto,
            this.Etapa,
            this.Producto,
            this.idarticulo,
            this.Observacion,
            this.CantValido,
            this.Cantidad,
            this.Precio_Base,
            this.idmoneda,
            this.TDesc,
            this.VDesc,
            this.monedon,
            this.P_Coti,
            this.xsubtotal,
            this.xigv,
            this.xtc,
            this.PInicial,
            this.tipo_inicial,
            this.valor_inicial,
            this.EstadoLetras});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(15, 65);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(1113, 286);
            this.dtgconten.TabIndex = 169;
            this.dtgconten.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_CellValueChanged_1);
            this.dtgconten.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgconten_DataError_1);
            this.dtgconten.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgconten_EditingControlShowing_1);
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter_1);
            this.dtgconten.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgconten_RowsAdded);
            this.dtgconten.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgconten_RowsRemoved);
            this.dtgconten.Sorted += new System.EventHandler(this.dtgconten_Sorted_1);
            this.dtgconten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgconten_KeyDown_1);
            // 
            // idempresa
            // 
            this.idempresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idempresa.DataPropertyName = "idempresa";
            this.idempresa.HeaderText = "Empresa";
            this.idempresa.MinimumWidth = 50;
            this.idempresa.Name = "idempresa";
            this.idempresa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idempresa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idempresa.Width = 74;
            // 
            // idproyecto
            // 
            this.idproyecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idproyecto.DataPropertyName = "idproyecto";
            this.idproyecto.HeaderText = "Proyecto";
            this.idproyecto.MinimumWidth = 50;
            this.idproyecto.Name = "idproyecto";
            this.idproyecto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idproyecto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idproyecto.Width = 75;
            // 
            // Etapa
            // 
            this.Etapa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Etapa.DataPropertyName = "Etapa";
            this.Etapa.HeaderText = "Etapa";
            this.Etapa.MinimumWidth = 50;
            this.Etapa.Name = "Etapa";
            this.Etapa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Etapa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Etapa.Width = 60;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.DataPropertyName = "idarticulo";
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 100;
            this.Producto.Name = "Producto";
            this.Producto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // idarticulo
            // 
            this.idarticulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idarticulo.DataPropertyName = "producto";
            this.idarticulo.HeaderText = "Id_Proy_Prod";
            this.idarticulo.MinimumWidth = 50;
            this.idarticulo.Name = "idarticulo";
            this.idarticulo.Visible = false;
            // 
            // Observacion
            // 
            this.Observacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Observacion.DataPropertyName = "Observacion";
            this.Observacion.HeaderText = "Observación";
            this.Observacion.MinimumWidth = 150;
            this.Observacion.Name = "Observacion";
            this.Observacion.ReadOnly = true;
            this.Observacion.Width = 150;
            // 
            // CantValido
            // 
            this.CantValido.DataPropertyName = "cantidadvalida";
            this.CantValido.HeaderText = "Cant";
            this.CantValido.Name = "CantValido";
            this.CantValido.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cantidad.HeaderText = "Cant";
            this.Cantidad.MinimumWidth = 50;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 55;
            // 
            // Precio_Base
            // 
            this.Precio_Base.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Precio_Base.DataPropertyName = "PVta";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n2";
            this.Precio_Base.DefaultCellStyle = dataGridViewCellStyle4;
            this.Precio_Base.HeaderText = "P.Base";
            this.Precio_Base.MinimumWidth = 60;
            this.Precio_Base.Name = "Precio_Base";
            this.Precio_Base.ReadOnly = true;
            this.Precio_Base.Width = 64;
            // 
            // idmoneda
            // 
            this.idmoneda.DataPropertyName = "idmoneda";
            this.idmoneda.HeaderText = "id_moneda";
            this.idmoneda.Name = "idmoneda";
            this.idmoneda.Visible = false;
            // 
            // TDesc
            // 
            this.TDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TDesc.DataPropertyName = "TDesc";
            this.TDesc.HeaderText = "TDesc";
            this.TDesc.MinimumWidth = 50;
            this.TDesc.Name = "TDesc";
            this.TDesc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TDesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TDesc.Width = 60;
            // 
            // VDesc
            // 
            this.VDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VDesc.DataPropertyName = "VDesc";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.VDesc.DefaultCellStyle = dataGridViewCellStyle5;
            this.VDesc.HeaderText = "VDesc";
            this.VDesc.MinimumWidth = 50;
            this.VDesc.Name = "VDesc";
            this.VDesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VDesc.Width = 50;
            // 
            // monedon
            // 
            this.monedon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.monedon.DataPropertyName = "moneda";
            this.monedon.HeaderText = "M";
            this.monedon.Name = "monedon";
            this.monedon.ReadOnly = true;
            this.monedon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.monedon.Width = 22;
            // 
            // P_Coti
            // 
            this.P_Coti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.P_Coti.DataPropertyName = "PCoti";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "n2";
            this.P_Coti.DefaultCellStyle = dataGridViewCellStyle6;
            this.P_Coti.HeaderText = "P.Coti.";
            this.P_Coti.MinimumWidth = 50;
            this.P_Coti.Name = "P_Coti";
            this.P_Coti.ReadOnly = true;
            this.P_Coti.Width = 64;
            // 
            // xsubtotal
            // 
            this.xsubtotal.DataPropertyName = "subtotal";
            this.xsubtotal.HeaderText = "Subtotal";
            this.xsubtotal.Name = "xsubtotal";
            this.xsubtotal.Visible = false;
            // 
            // xigv
            // 
            this.xigv.DataPropertyName = "igv";
            this.xigv.HeaderText = "Igv";
            this.xigv.Name = "xigv";
            this.xigv.Visible = false;
            // 
            // xtc
            // 
            this.xtc.DataPropertyName = "tc";
            this.xtc.HeaderText = "tc";
            this.xtc.Name = "xtc";
            this.xtc.Visible = false;
            // 
            // PInicial
            // 
            this.PInicial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PInicial.DataPropertyName = "Inicial";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "n2";
            this.PInicial.DefaultCellStyle = dataGridViewCellStyle7;
            this.PInicial.HeaderText = "Inicial";
            this.PInicial.Name = "PInicial";
            this.PInicial.ReadOnly = true;
            this.PInicial.Width = 61;
            // 
            // tipo_inicial
            // 
            this.tipo_inicial.DataPropertyName = "tipo_inicial";
            this.tipo_inicial.HeaderText = "tipo_inicial";
            this.tipo_inicial.Name = "tipo_inicial";
            this.tipo_inicial.Visible = false;
            // 
            // valor_inicial
            // 
            this.valor_inicial.DataPropertyName = "valor_inicial";
            this.valor_inicial.HeaderText = "valor_inicial";
            this.valor_inicial.Name = "valor_inicial";
            this.valor_inicial.Visible = false;
            // 
            // EstadoLetras
            // 
            this.EstadoLetras.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EstadoLetras.DataPropertyName = "EstadoLetras";
            this.EstadoLetras.HeaderText = "Estado";
            this.EstadoLetras.MinimumWidth = 60;
            this.EstadoLetras.Name = "EstadoLetras";
            this.EstadoLetras.ReadOnly = true;
            this.EstadoLetras.Visible = false;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtsubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsubtotal.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtsubtotal.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.ForeColor = System.Drawing.Color.Black;
            this.txtsubtotal.Location = new System.Drawing.Point(497, 37);
            this.txtsubtotal.MaxLength = 15;
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.NextControlOnEnter = null;
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(93, 21);
            this.txtsubtotal.TabIndex = 174;
            this.txtsubtotal.Text = "0.00";
            this.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtsubtotal.TextoDefecto = "0.00";
            this.txtsubtotal.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtsubtotal.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // txtigv
            // 
            this.txtigv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtigv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtigv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtigv.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtigv.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtigv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtigv.ForeColor = System.Drawing.Color.Black;
            this.txtigv.Location = new System.Drawing.Point(622, 37);
            this.txtigv.MaxLength = 15;
            this.txtigv.Name = "txtigv";
            this.txtigv.NextControlOnEnter = null;
            this.txtigv.ReadOnly = true;
            this.txtigv.Size = new System.Drawing.Size(93, 21);
            this.txtigv.TabIndex = 175;
            this.txtigv.Text = "0.00";
            this.txtigv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtigv.TextoDefecto = "0.00";
            this.txtigv.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtigv.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(446, 41);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 13);
            this.label24.TabIndex = 172;
            this.label24.Text = "Subtotal:";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(594, 41);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(28, 13);
            this.label25.TabIndex = 173;
            this.label25.Text = "IGV:";
            // 
            // txttotal
            // 
            this.txttotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotal.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txttotal.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.Color.Black;
            this.txttotal.Location = new System.Drawing.Point(750, 37);
            this.txttotal.MaxLength = 15;
            this.txttotal.Name = "txttotal";
            this.txttotal.NextControlOnEnter = null;
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(93, 21);
            this.txttotal.TabIndex = 171;
            this.txttotal.Text = "0.00";
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttotal.TextoDefecto = "0.00";
            this.txttotal.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txttotal.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(718, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 170;
            this.label1.Text = "Total:";
            // 
            // lbldato
            // 
            this.lbldato.AutoSize = true;
            this.lbldato.BackColor = System.Drawing.Color.Transparent;
            this.lbldato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldato.ForeColor = System.Drawing.Color.Blue;
            this.lbldato.Location = new System.Drawing.Point(705, 362);
            this.lbldato.Name = "lbldato";
            this.lbldato.Size = new System.Drawing.Size(288, 15);
            this.lbldato.TabIndex = 243;
            this.lbldato.Text = "No se puede Modificar, Ya tiene un abono separado";
            // 
            // frmlistarCotizacionesCLienteDEtalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 389);
            this.Controls.Add(this.lbldato);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.txtigv);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.txtValorInicial);
            this.Controls.Add(this.txtcodvendedor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNombreVendedor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnaddproducto);
            this.Controls.Add(this.btnproductos);
            this.Controls.Add(this.txttipocambioref);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txttipoid);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtnumcot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnroid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label23);
            this.MinimumSize = new System.Drawing.Size(1014, 428);
            this.Name = "frmlistarCotizacionesCLienteDEtalle";
            this.Nombre = "Cotizacion ";
            this.Text = "Cotizacion ";
            this.Load += new System.EventHandler(this.frmlistarCotizacionesCLienteDEtalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HpResergerUserControls.TextBoxPer txtnumcot;
        private HpResergerUserControls.TextBoxPer txtnombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private HpResergerUserControls.TextBoxPer txtnroid;
        private System.Windows.Forms.Label label3;
        private HpResergerUserControls.TextBoxPer txttipoid;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblmsg;
        private HpResergerUserControls.TextBoxPer txttipocambioref;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnaddproducto;
        private System.Windows.Forms.Button btnproductos;
        private HpResergerUserControls.TextBoxPer txtcodvendedor;
        private System.Windows.Forms.Label label13;
        private HpResergerUserControls.TextBoxPer txtNombreVendedor;
        private System.Windows.Forms.Label label14;
        private HpResergerUserControls.TextBoxPer txtValorInicial;
        private System.Windows.Forms.Label label23;
        private HpResergerUserControls.Dtgconten dtgconten;
        private HpResergerUserControls.TextBoxPer txtsubtotal;
        private HpResergerUserControls.TextBoxPer txtigv;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private HpResergerUserControls.TextBoxPer txttotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewComboBoxColumn idempresa;
        private System.Windows.Forms.DataGridViewComboBoxColumn idproyecto;
        private System.Windows.Forms.DataGridViewComboBoxColumn Etapa;
        private System.Windows.Forms.DataGridViewComboBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idarticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantValido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Base;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmoneda;
        private System.Windows.Forms.DataGridViewComboBoxColumn TDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn VDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn monedon;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Coti;
        private System.Windows.Forms.DataGridViewTextBoxColumn xsubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn xigv;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoLetras;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbldato;
    }
}