using HpResergerUserControls;

namespace HPReserger
{
    partial class frmDetalleAsientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleAsientos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dtgconten = new HpResergerUserControls.Dtgconten();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumasiento = new System.Windows.Forms.TextBox();
            this.txtcuenta = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChkDuplicar = new System.Windows.Forms.CheckBox();
            this.txttotalmonextranjera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotalmonedaNacional = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdiferencia = new System.Windows.Forms.TextBox();
            this.btnborrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idauxx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idasientox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentacontablex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkproyectox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodocx = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.numdocx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonsocialx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcomprobantex = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.codcomprobantex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcomprobantex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centrocostox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttonCentroCosto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.fechaemisionx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRecepcionx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimientox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importemnx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importemex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipocambiox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkAsix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glosax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtgconten
            // 
            this.Dtgconten.AllowUserToOrderColumns = true;
            this.Dtgconten.AllowUserToResizeColumns = false;
            this.Dtgconten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.Dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtgconten.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.Dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnborrar,
            this.idauxx,
            this.idasientox,
            this.cuentacontablex,
            this.fkproyectox,
            this.tipodocx,
            this.numdocx,
            this.razonsocialx,
            this.idcomprobantex,
            this.codcomprobantex,
            this.numcomprobantex,
            this.centrocostox,
            this.buttonCentroCosto,
            this.fechaemisionx,
            this.FechaRecepcionx,
            this.FechaVencimientox,
            this.importemnx,
            this.importemex,
            this.tipocambiox,
            this.fkAsix,
            this.glosax,
            this.usuariox,
            this.fechax});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dtgconten.DefaultCellStyle = dataGridViewCellStyle14;
            this.Dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Dtgconten.EnableHeadersVisualStyles = false;
            this.Dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.Dtgconten.Location = new System.Drawing.Point(12, 44);
            this.Dtgconten.Name = "Dtgconten";
            this.Dtgconten.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dtgconten.RowHeadersVisible = false;
            this.Dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dtgconten.ShowRowErrors = false;
            this.Dtgconten.Size = new System.Drawing.Size(1363, 526);
            this.Dtgconten.TabIndex = 2;
            this.Dtgconten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_CellContentClick);
            this.Dtgconten.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_CellContentDoubleClick);
            this.Dtgconten.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_CellDoubleClick);
            this.Dtgconten.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_CellValueChanged);
            this.Dtgconten.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Dtgconten_DataError);
            this.Dtgconten.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dtgconten_EditingControlShowing);
            this.Dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_RowEnter);
            this.Dtgconten.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Dtgconten_RowsAdded);
            this.Dtgconten.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.Dtgconten_RowsRemoved);
            this.Dtgconten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dtgconten_KeyDown);
            this.Dtgconten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dtgconten_KeyPress);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(1252, 576);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(123, 28);
            this.btncancelar.TabIndex = 158;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Enabled = false;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(1123, 576);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(123, 28);
            this.btnaceptar.TabIndex = 157;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.Location = new System.Drawing.Point(1252, 10);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(123, 28);
            this.btnmodificar.TabIndex = 1;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 160;
            this.label1.Text = "Num. Asiento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 161;
            this.label2.Text = "Cuenta Contable";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnumasiento
            // 
            this.txtnumasiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtnumasiento.Location = new System.Drawing.Point(88, 14);
            this.txtnumasiento.Name = "txtnumasiento";
            this.txtnumasiento.ReadOnly = true;
            this.txtnumasiento.Size = new System.Drawing.Size(81, 20);
            this.txtnumasiento.TabIndex = 162;
            this.txtnumasiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnumasiento.TextChanged += new System.EventHandler(this.txtnumasiento_TextChanged);
            // 
            // txtcuenta
            // 
            this.txtcuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtcuenta.Location = new System.Drawing.Point(267, 14);
            this.txtcuenta.Name = "txtcuenta";
            this.txtcuenta.ReadOnly = true;
            this.txtcuenta.Size = new System.Drawing.Size(97, 20);
            this.txtcuenta.TabIndex = 163;
            this.txtcuenta.TextChanged += new System.EventHandler(this.txtcuenta_TextChanged);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtdescripcion.Location = new System.Drawing.Point(439, 14);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.ReadOnly = true;
            this.txtdescripcion.Size = new System.Drawing.Size(429, 20);
            this.txtdescripcion.TabIndex = 165;
            this.txtdescripcion.TextChanged += new System.EventHandler(this.txtdescripcion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 164;
            this.label3.Text = "Descripción";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(12, 584);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(78, 13);
            this.lblmsg.TabIndex = 166;
            this.lblmsg.Text = "Total Registros";
            // 
            // txttotal
            // 
            this.txttotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txttotal.Location = new System.Drawing.Point(1135, 14);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttotal.Size = new System.Drawing.Size(111, 20);
            this.txttotal.TabIndex = 168;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1098, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 167;
            this.label4.Text = "Total";
            // 
            // ChkDuplicar
            // 
            this.ChkDuplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkDuplicar.AutoSize = true;
            this.ChkDuplicar.Location = new System.Drawing.Point(874, 16);
            this.ChkDuplicar.Name = "ChkDuplicar";
            this.ChkDuplicar.Size = new System.Drawing.Size(218, 17);
            this.ChkDuplicar.TabIndex = 169;
            this.ChkDuplicar.Text = "Este Detalle se Duplicará en las Cuentas";
            this.ChkDuplicar.UseVisualStyleBackColor = true;
            // 
            // txttotalmonextranjera
            // 
            this.txttotalmonextranjera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotalmonextranjera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txttotalmonextranjera.Location = new System.Drawing.Point(887, 584);
            this.txttotalmonextranjera.Name = "txttotalmonextranjera";
            this.txttotalmonextranjera.ReadOnly = true;
            this.txttotalmonextranjera.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttotalmonextranjera.Size = new System.Drawing.Size(111, 20);
            this.txttotalmonextranjera.TabIndex = 170;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(887, 571);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 171;
            this.label5.Text = "Total Moneda.Extranj.";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(770, 571);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 173;
            this.label6.Text = "TotalMonedaNacional";
            // 
            // txttotalmonedaNacional
            // 
            this.txttotalmonedaNacional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotalmonedaNacional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txttotalmonedaNacional.Location = new System.Drawing.Point(770, 584);
            this.txttotalmonedaNacional.Name = "txttotalmonedaNacional";
            this.txttotalmonedaNacional.ReadOnly = true;
            this.txttotalmonedaNacional.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttotalmonedaNacional.Size = new System.Drawing.Size(111, 20);
            this.txttotalmonedaNacional.TabIndex = 172;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1004, 571);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 175;
            this.label7.Text = "Diferencia";
            // 
            // txtdiferencia
            // 
            this.txtdiferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdiferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtdiferencia.Location = new System.Drawing.Point(1004, 584);
            this.txtdiferencia.Name = "txtdiferencia";
            this.txtdiferencia.ReadOnly = true;
            this.txtdiferencia.Size = new System.Drawing.Size(111, 20);
            this.txtdiferencia.TabIndex = 174;
            // 
            // btnborrar
            // 
            this.btnborrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.btnborrar.HeaderText = "Borrar";
            this.btnborrar.MinimumWidth = 50;
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnborrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseColumnTextForButtonValue = true;
            this.btnborrar.Width = 50;
            // 
            // idauxx
            // 
            this.idauxx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idauxx.DataPropertyName = "Id_Aux";
            this.idauxx.HeaderText = "idaux";
            this.idauxx.Name = "idauxx";
            this.idauxx.Visible = false;
            this.idauxx.Width = 59;
            // 
            // idasientox
            // 
            this.idasientox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idasientox.DataPropertyName = "Id_Asiento_Contable";
            this.idasientox.HeaderText = "idAsiento";
            this.idasientox.Name = "idasientox";
            this.idasientox.Visible = false;
            this.idasientox.Width = 80;
            // 
            // cuentacontablex
            // 
            this.cuentacontablex.DataPropertyName = "Cuenta_Contable";
            this.cuentacontablex.HeaderText = "CuentaContable";
            this.cuentacontablex.MaxInputLength = 12;
            this.cuentacontablex.Name = "cuentacontablex";
            this.cuentacontablex.Visible = false;
            // 
            // fkproyectox
            // 
            this.fkproyectox.DataPropertyName = "fk_proyecto";
            this.fkproyectox.HeaderText = "fkproyecto";
            this.fkproyectox.Name = "fkproyectox";
            this.fkproyectox.Visible = false;
            // 
            // tipodocx
            // 
            this.tipodocx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipodocx.DataPropertyName = "Tipo_Doc";
            this.tipodocx.HeaderText = "Tipo Doc.";
            this.tipodocx.MinimumWidth = 50;
            this.tipodocx.Name = "tipodocx";
            this.tipodocx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipodocx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tipodocx.Width = 79;
            // 
            // numdocx
            // 
            this.numdocx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.numdocx.DataPropertyName = "Num_Doc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.NullValue = "0";
            this.numdocx.DefaultCellStyle = dataGridViewCellStyle3;
            this.numdocx.HeaderText = "Num. Doc.";
            this.numdocx.MaxInputLength = 14;
            this.numdocx.MinimumWidth = 65;
            this.numdocx.Name = "numdocx";
            this.numdocx.Width = 65;
            // 
            // razonsocialx
            // 
            this.razonsocialx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.razonsocialx.DataPropertyName = "Razon_Social";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.razonsocialx.DefaultCellStyle = dataGridViewCellStyle4;
            this.razonsocialx.HeaderText = "Razon Social";
            this.razonsocialx.MaxInputLength = 200;
            this.razonsocialx.MinimumWidth = 70;
            this.razonsocialx.Name = "razonsocialx";
            this.razonsocialx.ReadOnly = true;
            this.razonsocialx.Width = 96;
            // 
            // idcomprobantex
            // 
            this.idcomprobantex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idcomprobantex.DataPropertyName = "Id_Comprobante";
            this.idcomprobantex.HeaderText = "Comprobante";
            this.idcomprobantex.MinimumWidth = 50;
            this.idcomprobantex.Name = "idcomprobantex";
            this.idcomprobantex.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idcomprobantex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idcomprobantex.Width = 102;
            // 
            // codcomprobantex
            // 
            this.codcomprobantex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.codcomprobantex.DataPropertyName = "Cod_Comprobante";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.NullValue = "0";
            this.codcomprobantex.DefaultCellStyle = dataGridViewCellStyle5;
            this.codcomprobantex.FillWeight = 50F;
            this.codcomprobantex.HeaderText = "Cod.Comp.";
            this.codcomprobantex.MaxInputLength = 4;
            this.codcomprobantex.MinimumWidth = 65;
            this.codcomprobantex.Name = "codcomprobantex";
            this.codcomprobantex.ToolTipText = "Ejemplo: 001";
            this.codcomprobantex.Width = 65;
            // 
            // numcomprobantex
            // 
            this.numcomprobantex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.numcomprobantex.DataPropertyName = "Num_Comprobante";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.NullValue = "0";
            this.numcomprobantex.DefaultCellStyle = dataGridViewCellStyle6;
            this.numcomprobantex.FillWeight = 70F;
            this.numcomprobantex.HeaderText = "Num.Comproban.";
            this.numcomprobantex.MaxInputLength = 10;
            this.numcomprobantex.MinimumWidth = 100;
            this.numcomprobantex.Name = "numcomprobantex";
            // 
            // centrocostox
            // 
            this.centrocostox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.centrocostox.DataPropertyName = "Centro_Costo";
            dataGridViewCellStyle7.NullValue = "NINGUNO";
            this.centrocostox.DefaultCellStyle = dataGridViewCellStyle7;
            this.centrocostox.FillWeight = 200F;
            this.centrocostox.HeaderText = "Centro de Costos";
            this.centrocostox.MinimumWidth = 200;
            this.centrocostox.Name = "centrocostox";
            this.centrocostox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.centrocostox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.centrocostox.Width = 200;
            // 
            // buttonCentroCosto
            // 
            this.buttonCentroCosto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.buttonCentroCosto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCentroCosto.HeaderText = "CC";
            this.buttonCentroCosto.MinimumWidth = 30;
            this.buttonCentroCosto.Name = "buttonCentroCosto";
            this.buttonCentroCosto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.buttonCentroCosto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.buttonCentroCosto.Text = "...";
            this.buttonCentroCosto.ToolTipText = "Buscar Centro de Costo";
            this.buttonCentroCosto.UseColumnTextForButtonValue = true;
            this.buttonCentroCosto.Width = 30;
            // 
            // fechaemisionx
            // 
            this.fechaemisionx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.fechaemisionx.DataPropertyName = "Fecha_Emision";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "d";
            this.fechaemisionx.DefaultCellStyle = dataGridViewCellStyle8;
            this.fechaemisionx.HeaderText = "FechaEmisión";
            this.fechaemisionx.MinimumWidth = 85;
            this.fechaemisionx.Name = "fechaemisionx";
            this.fechaemisionx.Width = 85;
            // 
            // FechaRecepcionx
            // 
            this.FechaRecepcionx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.FechaRecepcionx.DataPropertyName = "Fecha_Recepcion";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.Format = "d";
            this.FechaRecepcionx.DefaultCellStyle = dataGridViewCellStyle9;
            this.FechaRecepcionx.HeaderText = "FechaRecep.";
            this.FechaRecepcionx.MinimumWidth = 80;
            this.FechaRecepcionx.Name = "FechaRecepcionx";
            this.FechaRecepcionx.Width = 80;
            // 
            // FechaVencimientox
            // 
            this.FechaVencimientox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.FechaVencimientox.DataPropertyName = "Fecha_Vencimiento";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "d";
            this.FechaVencimientox.DefaultCellStyle = dataGridViewCellStyle10;
            this.FechaVencimientox.HeaderText = "FechaVenc.";
            this.FechaVencimientox.MinimumWidth = 75;
            this.FechaVencimientox.Name = "FechaVencimientox";
            this.FechaVencimientox.Width = 75;
            // 
            // importemnx
            // 
            this.importemnx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.importemnx.DataPropertyName = "Importe_MN";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "n2";
            dataGridViewCellStyle11.NullValue = "0.00";
            this.importemnx.DefaultCellStyle = dataGridViewCellStyle11;
            this.importemnx.HeaderText = "Imp.Mon.Nac.";
            this.importemnx.MinimumWidth = 85;
            this.importemnx.Name = "importemnx";
            this.importemnx.Width = 85;
            // 
            // importemex
            // 
            this.importemex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.importemex.DataPropertyName = "Importe_ME";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "n2";
            dataGridViewCellStyle12.NullValue = "0.00";
            this.importemex.DefaultCellStyle = dataGridViewCellStyle12;
            this.importemex.HeaderText = "Imp.Mon.Extran.";
            this.importemex.MinimumWidth = 90;
            this.importemex.Name = "importemex";
            this.importemex.Width = 90;
            // 
            // tipocambiox
            // 
            this.tipocambiox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.tipocambiox.DataPropertyName = "tipo_cambio";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "0.0000";
            dataGridViewCellStyle13.NullValue = "0.0000";
            this.tipocambiox.DefaultCellStyle = dataGridViewCellStyle13;
            this.tipocambiox.HeaderText = "T. Camb.";
            this.tipocambiox.MinimumWidth = 60;
            this.tipocambiox.Name = "tipocambiox";
            this.tipocambiox.Width = 60;
            // 
            // fkAsix
            // 
            this.fkAsix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.fkAsix.DataPropertyName = "fk_asi";
            this.fkAsix.HeaderText = "NroAsiento";
            this.fkAsix.MinimumWidth = 65;
            this.fkAsix.Name = "fkAsix";
            this.fkAsix.ReadOnly = true;
            this.fkAsix.Width = 65;
            // 
            // glosax
            // 
            this.glosax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.glosax.DataPropertyName = "Glosa";
            this.glosax.HeaderText = "Glosa";
            this.glosax.MaxInputLength = 300;
            this.glosax.MinimumWidth = 200;
            this.glosax.Name = "glosax";
            // 
            // usuariox
            // 
            this.usuariox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.usuariox.DataPropertyName = "Usuario";
            this.usuariox.HeaderText = "usuario";
            this.usuariox.Name = "usuariox";
            this.usuariox.Visible = false;
            this.usuariox.Width = 70;
            // 
            // fechax
            // 
            this.fechax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechax.DataPropertyName = "Fecha";
            this.fechax.HeaderText = "fecha";
            this.fechax.Name = "fechax";
            this.fechax.Visible = false;
            this.fechax.Width = 59;
            // 
            // frmDetalleAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 611);
            this.Colores = new System.Drawing.Color[0];
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdiferencia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttotalmonedaNacional);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttotalmonextranjera);
            this.Controls.Add(this.ChkDuplicar);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcuenta);
            this.Controls.Add(this.txtnumasiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.Dtgconten);
            this.MinimumSize = new System.Drawing.Size(1080, 650);
            this.Name = "frmDetalleAsientos";
            this.Nombre = "Detalle Asiento";
            this.Text = "Detalle Asiento";
            this.Load += new System.EventHandler(this.frmDetalleAsientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumasiento;
        private System.Windows.Forms.TextBox txtcuenta;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmsg;
        public Dtgconten Dtgconten;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.CheckBox ChkDuplicar;
        private System.Windows.Forms.TextBox txttotalmonextranjera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttotalmonedaNacional;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdiferencia;
        private System.Windows.Forms.DataGridViewButtonColumn btnborrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idauxx;
        private System.Windows.Forms.DataGridViewTextBoxColumn idasientox;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentacontablex;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkproyectox;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipodocx;
        private System.Windows.Forms.DataGridViewTextBoxColumn numdocx;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonsocialx;
        private System.Windows.Forms.DataGridViewComboBoxColumn idcomprobantex;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcomprobantex;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcomprobantex;
        private System.Windows.Forms.DataGridViewComboBoxColumn centrocostox;
        private System.Windows.Forms.DataGridViewButtonColumn buttonCentroCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaemisionx;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRecepcionx;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimientox;
        private System.Windows.Forms.DataGridViewTextBoxColumn importemnx;
        private System.Windows.Forms.DataGridViewTextBoxColumn importemex;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipocambiox;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkAsix;
        private System.Windows.Forms.DataGridViewTextBoxColumn glosax;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuariox;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechax;
    }
}