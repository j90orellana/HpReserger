namespace HPReserger
{
    partial class frmCotizacionCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCotizacionCliente));
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.productox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.txtocupacion = new HpResergerUserControls.TextBoxPer();
            this.Email = new System.Windows.Forms.Label();
            this.txtemail = new HpResergerUserControls.TextBoxPer();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtapemat = new HpResergerUserControls.TextBoxPer();
            this.txtdireccion = new HpResergerUserControls.TextBoxPer();
            this.txttelfijo = new HpResergerUserControls.TextBoxPer();
            this.txttelcelular = new HpResergerUserControls.TextBoxPer();
            this.txtapetpat = new HpResergerUserControls.TextBoxPer();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new HpResergerUserControls.TextBoxPer();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnroid = new HpResergerUserControls.TextBoxPer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtubicacion = new HpResergerUserControls.TextBoxPer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btncotizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbotipoid = new HpResergerUserControls.ComboBoxPer(this.components);
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.panel1.SuspendLayout();
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productox,
            this.cantidadx,
            this.preciox});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(9, 154);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(835, 487);
            this.dtgconten.TabIndex = 1;
            // 
            // productox
            // 
            this.productox.HeaderText = "Producto";
            this.productox.Name = "productox";
            this.productox.ReadOnly = true;
            // 
            // cantidadx
            // 
            this.cantidadx.HeaderText = "Cantidad";
            this.cantidadx.Name = "cantidadx";
            this.cantidadx.ReadOnly = true;
            // 
            // preciox
            // 
            this.preciox.HeaderText = "Precio";
            this.preciox.Name = "preciox";
            this.preciox.ReadOnly = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(314, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 128;
            this.label16.Text = "Ocupación";
            // 
            // txtocupacion
            // 
            this.txtocupacion.BackColor = System.Drawing.Color.White;
            this.txtocupacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtocupacion.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtocupacion.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtocupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtocupacion.ForeColor = System.Drawing.Color.Black;
            this.txtocupacion.Location = new System.Drawing.Point(379, 93);
            this.txtocupacion.MaxLength = 50;
            this.txtocupacion.Name = "txtocupacion";
            this.txtocupacion.NextControlOnEnter = null;
            this.txtocupacion.Size = new System.Drawing.Size(177, 21);
            this.txtocupacion.TabIndex = 105;
            this.txtocupacion.Text = "Ingrese Ocupación";
            this.txtocupacion.TextoDefecto = "Ingrese Ocupación";
            this.txtocupacion.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtocupacion.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Location = new System.Drawing.Point(28, 97);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 127;
            this.Email.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.White;
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtemail.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.Black;
            this.txtemail.Location = new System.Drawing.Point(63, 93);
            this.txtemail.MaxLength = 50;
            this.txtemail.Name = "txtemail";
            this.txtemail.NextControlOnEnter = this.txtocupacion;
            this.txtemail.Size = new System.Drawing.Size(235, 21);
            this.txtemail.TabIndex = 104;
            this.txtemail.Text = "correo@prueba.com";
            this.txtemail.TextoDefecto = "correo@prueba.com";
            this.txtemail.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtemail.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(565, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 113;
            this.label6.Text = "Apellido Mat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(648, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 114;
            this.label12.Text = "Tel. Celular";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(485, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 112;
            this.label11.Text = "Tel. Fijo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(308, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 111;
            this.label5.Text = "Apellido Pat";
            // 
            // txtapemat
            // 
            this.txtapemat.BackColor = System.Drawing.Color.White;
            this.txtapemat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtapemat.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtapemat.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtapemat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapemat.ForeColor = System.Drawing.Color.Black;
            this.txtapemat.Location = new System.Drawing.Point(641, 45);
            this.txtapemat.MaxLength = 30;
            this.txtapemat.Name = "txtapemat";
            this.txtapemat.NextControlOnEnter = this.txtdireccion;
            this.txtapemat.Size = new System.Drawing.Size(206, 21);
            this.txtapemat.TabIndex = 100;
            this.txtapemat.Text = "Ingrese Apellido Materno";
            this.txtapemat.TextoDefecto = "Ingrese Apellido Materno";
            this.txtapemat.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtapemat.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.White;
            this.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdireccion.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtdireccion.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.ForeColor = System.Drawing.Color.Black;
            this.txtdireccion.Location = new System.Drawing.Point(63, 69);
            this.txtdireccion.MaxLength = 100;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.NextControlOnEnter = this.txttelfijo;
            this.txtdireccion.Size = new System.Drawing.Size(413, 21);
            this.txtdireccion.TabIndex = 101;
            this.txtdireccion.Text = "Ingrese Dirección";
            this.txtdireccion.TextoDefecto = "Ingrese Dirección";
            this.txtdireccion.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtdireccion.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // txttelfijo
            // 
            this.txttelfijo.BackColor = System.Drawing.Color.White;
            this.txttelfijo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttelfijo.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txttelfijo.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txttelfijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelfijo.ForeColor = System.Drawing.Color.Black;
            this.txttelfijo.Location = new System.Drawing.Point(533, 69);
            this.txttelfijo.MaxLength = 10;
            this.txttelfijo.Name = "txttelfijo";
            this.txttelfijo.NextControlOnEnter = this.txttelcelular;
            this.txttelfijo.Size = new System.Drawing.Size(105, 21);
            this.txttelfijo.TabIndex = 102;
            this.txttelfijo.Text = "00000";
            this.txttelfijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttelfijo.TextoDefecto = "00000";
            this.txttelfijo.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txttelfijo.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // txttelcelular
            // 
            this.txttelcelular.BackColor = System.Drawing.Color.White;
            this.txttelcelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttelcelular.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txttelcelular.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txttelcelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelcelular.ForeColor = System.Drawing.Color.Black;
            this.txttelcelular.Location = new System.Drawing.Point(712, 69);
            this.txttelcelular.MaxLength = 15;
            this.txttelcelular.Name = "txttelcelular";
            this.txttelcelular.NextControlOnEnter = this.txtemail;
            this.txttelcelular.Size = new System.Drawing.Size(135, 21);
            this.txttelcelular.TabIndex = 103;
            this.txttelcelular.Text = "00000";
            this.txttelcelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttelcelular.TextoDefecto = "00000";
            this.txttelcelular.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txttelcelular.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            // 
            // txtapetpat
            // 
            this.txtapetpat.BackColor = System.Drawing.Color.White;
            this.txtapetpat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtapetpat.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtapetpat.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtapetpat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapetpat.ForeColor = System.Drawing.Color.Black;
            this.txtapetpat.Location = new System.Drawing.Point(379, 45);
            this.txtapetpat.MaxLength = 30;
            this.txtapetpat.Name = "txtapetpat";
            this.txtapetpat.NextControlOnEnter = this.txtapemat;
            this.txtapetpat.Size = new System.Drawing.Size(177, 21);
            this.txtapetpat.TabIndex = 99;
            this.txtapetpat.Text = "Ingrese Apellido Paterno";
            this.txtapetpat.TextoDefecto = "Ingrese Apellido Paterno";
            this.txtapetpat.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtapetpat.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(8, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 110;
            this.label10.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(11, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 109;
            this.label4.Text = "Nombres";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.White;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtnombre.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.Black;
            this.txtnombre.Location = new System.Drawing.Point(63, 45);
            this.txtnombre.MaxLength = 100;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.NextControlOnEnter = this.txtapetpat;
            this.txtnombre.Size = new System.Drawing.Size(235, 21);
            this.txtnombre.TabIndex = 98;
            this.txtnombre.Text = "Ingrese Nombre";
            this.txtnombre.TextoDefecto = "Ingrese Nombre";
            this.txtnombre.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtnombre.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(337, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Nro Id";
            // 
            // txtnroid
            // 
            this.txtnroid.BackColor = System.Drawing.Color.White;
            this.txtnroid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnroid.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtnroid.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtnroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnroid.ForeColor = System.Drawing.Color.Black;
            this.txtnroid.Location = new System.Drawing.Point(379, 18);
            this.txtnroid.MaxLength = 10;
            this.txtnroid.Name = "txtnroid";
            this.txtnroid.NextControlOnEnter = this.txtnombre;
            this.txtnroid.Size = new System.Drawing.Size(177, 21);
            this.txtnroid.TabIndex = 97;
            this.txtnroid.Text = "000000";
            this.txtnroid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnroid.TextoDefecto = "000000";
            this.txtnroid.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtnroid.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            this.txtnroid.TextChanged += new System.EventHandler(this.txtnroid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(5, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 130;
            this.label1.Text = "Ubicación";
            // 
            // txtubicacion
            // 
            this.txtubicacion.BackColor = System.Drawing.Color.White;
            this.txtubicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtubicacion.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtubicacion.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtubicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtubicacion.ForeColor = System.Drawing.Color.Black;
            this.txtubicacion.Location = new System.Drawing.Point(63, 118);
            this.txtubicacion.MaxLength = 50;
            this.txtubicacion.Name = "txtubicacion";
            this.txtubicacion.NextControlOnEnter = null;
            this.txtubicacion.Size = new System.Drawing.Size(493, 21);
            this.txtubicacion.TabIndex = 129;
            this.txtubicacion.Text = "Ingrese Ubicación";
            this.txtubicacion.TextoDefecto = "Ingrese Ubicación";
            this.txtubicacion.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtubicacion.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnbuscar);
            this.panel1.Controls.Add(this.btncotizar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbotipoid);
            this.panel1.Controls.Add(this.txtnroid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.txtubicacion);
            this.panel1.Controls.Add(this.txtdireccion);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtocupacion);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.txtapetpat);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txttelfijo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txttelcelular);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtapemat);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 148);
            this.panel1.TabIndex = 133;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscar.BackgroundImage")));
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.Location = new System.Drawing.Point(562, 18);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(21, 21);
            this.btnbuscar.TabIndex = 135;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btncotizar
            // 
            this.btncotizar.Enabled = false;
            this.btncotizar.Image = ((System.Drawing.Image)(resources.GetObject("btncotizar.Image")));
            this.btncotizar.Location = new System.Drawing.Point(762, 120);
            this.btncotizar.Name = "btncotizar";
            this.btncotizar.Size = new System.Drawing.Size(82, 23);
            this.btncotizar.TabIndex = 134;
            this.btncotizar.Text = "Cotizar";
            this.btncotizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncotizar.UseVisualStyleBackColor = true;
            this.btncotizar.Click += new System.EventHandler(this.btncotizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 132;
            this.label2.Text = "Tipo Id";
            // 
            // cbotipoid
            // 
            this.cbotipoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cbotipoid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipoid.FormattingEnabled = true;
            this.cbotipoid.Location = new System.Drawing.Point(63, 18);
            this.cbotipoid.Name = "cbotipoid";
            this.cbotipoid.Size = new System.Drawing.Size(235, 21);
            this.cbotipoid.TabIndex = 131;
            this.cbotipoid.SelectedIndexChanged += new System.EventHandler(this.cbotipoid_SelectedIndexChanged);
            this.cbotipoid.Click += new System.EventHandler(this.cbotipoid_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(762, 648);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 23);
            this.btncancelar.TabIndex = 135;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(674, 648);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 23);
            this.btnaceptar.TabIndex = 134;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Location = new System.Drawing.Point(9, 653);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(108, 13);
            this.lblmsg.TabIndex = 136;
            this.lblmsg.Text = "Total de Registros : 0";
            // 
            // frmCotizacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 679);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgconten);
            this.Name = "frmCotizacionCliente";
            this.Nombre = "Cotización";
            this.Text = "Cotización";
            this.Load += new System.EventHandler(this.frmCotizacionCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Label label16;
        private HpResergerUserControls.TextBoxPer txtocupacion;
        private System.Windows.Forms.Label Email;
        private HpResergerUserControls.TextBoxPer txtemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private HpResergerUserControls.TextBoxPer txtapemat;
        private HpResergerUserControls.TextBoxPer txtdireccion;
        private HpResergerUserControls.TextBoxPer txttelfijo;
        private HpResergerUserControls.TextBoxPer txttelcelular;
        private HpResergerUserControls.TextBoxPer txtapetpat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private HpResergerUserControls.TextBoxPer txtnombre;
        private System.Windows.Forms.Label label3;
        private HpResergerUserControls.TextBoxPer txtnroid;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.TextBoxPer txtubicacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private HpResergerUserControls.ComboBoxPer cbotipoid;
        private System.Windows.Forms.Button btncotizar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn productox;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadx;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciox;
    }
}