namespace HPReserger.ModuloFinanzas
{
    partial class frmListadoPrestamosCancelados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoPrestamosCancelados));
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.xpkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfkEmpresaOri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfkidProyectoOri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfkidEtapaOri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xidBancoOri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xbancoOri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xsufijoori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xidCtaOri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCtaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCuoOri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCtaContableOri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfkEmpresaDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEmpresaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfkidProyectoDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfkidEtapaDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xidBancoDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xBancodes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xsufijodes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xidCtaDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCtaDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCuoDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCtaContableDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xidMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ximporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xfechaprestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaContable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xglosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btncleanfind = new System.Windows.Forms.Button();
            this.txtbusMoneda = new HpResergerUserControls.TextBoxPer();
            this.txtbusempresadestino = new HpResergerUserControls.TextBoxPer();
            this.txtbusempresaorigen = new HpResergerUserControls.TextBoxPer();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnexcel = new System.Windows.Forms.Button();
            this.dtpfechabus2 = new System.Windows.Forms.DateTimePicker();
            this.dtpfechabus1 = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
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
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xpkid,
            this.xfkEmpresaOri,
            this.xempresa,
            this.xfkidProyectoOri,
            this.xfkidEtapaOri,
            this.xidBancoOri,
            this.xbancoOri,
            this.xsufijoori,
            this.xidCtaOri,
            this.xCtaOrigen,
            this.xCuoOri,
            this.xCtaContableOri,
            this.xfkEmpresaDes,
            this.xEmpresaDestino,
            this.xfkidProyectoDes,
            this.xfkidEtapaDes,
            this.xidBancoDes,
            this.xBancodes,
            this.xsufijodes,
            this.xidCtaDes,
            this.xCtaDes,
            this.xCuoDes,
            this.xCtaContableDes,
            this.xidMoneda,
            this.xmon,
            this.ximporte,
            this.xfechaprestamo,
            this.xFechaContable,
            this.xtc,
            this.xglosa,
            this.xEstado,
            this.xNEstado});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 50);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(960, 374);
            this.dtgconten.TabIndex = 30;
            // 
            // xpkid
            // 
            this.xpkid.DataPropertyName = "pkid";
            this.xpkid.HeaderText = "pkid";
            this.xpkid.Name = "xpkid";
            this.xpkid.ReadOnly = true;
            this.xpkid.Visible = false;
            // 
            // xfkEmpresaOri
            // 
            this.xfkEmpresaOri.DataPropertyName = "fkEmpresaOri";
            this.xfkEmpresaOri.HeaderText = "fkEmpresaOri";
            this.xfkEmpresaOri.Name = "xfkEmpresaOri";
            this.xfkEmpresaOri.ReadOnly = true;
            this.xfkEmpresaOri.Visible = false;
            // 
            // xempresa
            // 
            this.xempresa.DataPropertyName = "EmpresaOri";
            this.xempresa.HeaderText = "Empresa Origen";
            this.xempresa.MinimumWidth = 120;
            this.xempresa.Name = "xempresa";
            this.xempresa.ReadOnly = true;
            // 
            // xfkidProyectoOri
            // 
            this.xfkidProyectoOri.DataPropertyName = "fkidProyectoOri";
            this.xfkidProyectoOri.HeaderText = "fkidProyectoOri";
            this.xfkidProyectoOri.Name = "xfkidProyectoOri";
            this.xfkidProyectoOri.ReadOnly = true;
            this.xfkidProyectoOri.Visible = false;
            // 
            // xfkidEtapaOri
            // 
            this.xfkidEtapaOri.DataPropertyName = "fkidEtapaOri";
            this.xfkidEtapaOri.HeaderText = "fkidEtapaOri";
            this.xfkidEtapaOri.Name = "xfkidEtapaOri";
            this.xfkidEtapaOri.ReadOnly = true;
            this.xfkidEtapaOri.Visible = false;
            // 
            // xidBancoOri
            // 
            this.xidBancoOri.DataPropertyName = "idBancoOri";
            this.xidBancoOri.HeaderText = "idBancoOri";
            this.xidBancoOri.Name = "xidBancoOri";
            this.xidBancoOri.ReadOnly = true;
            this.xidBancoOri.Visible = false;
            // 
            // xbancoOri
            // 
            this.xbancoOri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xbancoOri.DataPropertyName = "BancoOri";
            this.xbancoOri.HeaderText = "Banco Origen";
            this.xbancoOri.MinimumWidth = 70;
            this.xbancoOri.Name = "xbancoOri";
            this.xbancoOri.ReadOnly = true;
            this.xbancoOri.Width = 94;
            // 
            // xsufijoori
            // 
            this.xsufijoori.DataPropertyName = "sufijoori";
            this.xsufijoori.HeaderText = "xsufijoori";
            this.xsufijoori.Name = "xsufijoori";
            this.xsufijoori.ReadOnly = true;
            this.xsufijoori.Visible = false;
            // 
            // xidCtaOri
            // 
            this.xidCtaOri.DataPropertyName = "idCtaOri";
            this.xidCtaOri.HeaderText = "idCtaOri";
            this.xidCtaOri.Name = "xidCtaOri";
            this.xidCtaOri.ReadOnly = true;
            this.xidCtaOri.Visible = false;
            // 
            // xCtaOrigen
            // 
            this.xCtaOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xCtaOrigen.DataPropertyName = "NroCtaOri";
            this.xCtaOrigen.HeaderText = "Cta Origen";
            this.xCtaOrigen.MinimumWidth = 80;
            this.xCtaOrigen.Name = "xCtaOrigen";
            this.xCtaOrigen.ReadOnly = true;
            this.xCtaOrigen.Width = 80;
            // 
            // xCuoOri
            // 
            this.xCuoOri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xCuoOri.DataPropertyName = "CuoOri";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xCuoOri.DefaultCellStyle = dataGridViewCellStyle3;
            this.xCuoOri.HeaderText = "Cuo Origen";
            this.xCuoOri.MinimumWidth = 70;
            this.xCuoOri.Name = "xCuoOri";
            this.xCuoOri.ReadOnly = true;
            this.xCuoOri.Width = 70;
            // 
            // xCtaContableOri
            // 
            this.xCtaContableOri.DataPropertyName = "CtaContableOri";
            this.xCtaContableOri.HeaderText = "CtaContableOri";
            this.xCtaContableOri.Name = "xCtaContableOri";
            this.xCtaContableOri.ReadOnly = true;
            this.xCtaContableOri.Visible = false;
            // 
            // xfkEmpresaDes
            // 
            this.xfkEmpresaDes.DataPropertyName = "fkEmpresaDes";
            this.xfkEmpresaDes.HeaderText = "fkEmpresaDes";
            this.xfkEmpresaDes.Name = "xfkEmpresaDes";
            this.xfkEmpresaDes.ReadOnly = true;
            this.xfkEmpresaDes.Visible = false;
            // 
            // xEmpresaDestino
            // 
            this.xEmpresaDestino.DataPropertyName = "EmpresaDes";
            this.xEmpresaDestino.HeaderText = "Empresa Destino";
            this.xEmpresaDestino.MinimumWidth = 120;
            this.xEmpresaDestino.Name = "xEmpresaDestino";
            this.xEmpresaDestino.ReadOnly = true;
            // 
            // xfkidProyectoDes
            // 
            this.xfkidProyectoDes.DataPropertyName = "fkidProyectoDes";
            this.xfkidProyectoDes.HeaderText = "fkidProyectoDes";
            this.xfkidProyectoDes.Name = "xfkidProyectoDes";
            this.xfkidProyectoDes.ReadOnly = true;
            this.xfkidProyectoDes.Visible = false;
            // 
            // xfkidEtapaDes
            // 
            this.xfkidEtapaDes.DataPropertyName = "fkidEtapaDes";
            this.xfkidEtapaDes.HeaderText = "fkidEtapaDes";
            this.xfkidEtapaDes.Name = "xfkidEtapaDes";
            this.xfkidEtapaDes.ReadOnly = true;
            this.xfkidEtapaDes.Visible = false;
            // 
            // xidBancoDes
            // 
            this.xidBancoDes.DataPropertyName = "idBancoDes";
            this.xidBancoDes.HeaderText = "idBancoDes";
            this.xidBancoDes.Name = "xidBancoDes";
            this.xidBancoDes.ReadOnly = true;
            this.xidBancoDes.Visible = false;
            // 
            // xBancodes
            // 
            this.xBancodes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xBancodes.DataPropertyName = "BancoDes";
            this.xBancodes.HeaderText = "Banco Destino";
            this.xBancodes.MinimumWidth = 70;
            this.xBancodes.Name = "xBancodes";
            this.xBancodes.ReadOnly = true;
            this.xBancodes.Width = 97;
            // 
            // xsufijodes
            // 
            this.xsufijodes.DataPropertyName = "sufijodes";
            this.xsufijodes.HeaderText = "xsufijodes";
            this.xsufijodes.Name = "xsufijodes";
            this.xsufijodes.ReadOnly = true;
            this.xsufijodes.Visible = false;
            // 
            // xidCtaDes
            // 
            this.xidCtaDes.DataPropertyName = "idCtaDes";
            this.xidCtaDes.HeaderText = "idCtaDes";
            this.xidCtaDes.Name = "xidCtaDes";
            this.xidCtaDes.ReadOnly = true;
            this.xidCtaDes.Visible = false;
            // 
            // xCtaDes
            // 
            this.xCtaDes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xCtaDes.DataPropertyName = "NroCtaDes";
            this.xCtaDes.HeaderText = "Cta Destino";
            this.xCtaDes.MinimumWidth = 80;
            this.xCtaDes.Name = "xCtaDes";
            this.xCtaDes.ReadOnly = true;
            this.xCtaDes.Width = 84;
            // 
            // xCuoDes
            // 
            this.xCuoDes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xCuoDes.DataPropertyName = "CuoDes";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xCuoDes.DefaultCellStyle = dataGridViewCellStyle4;
            this.xCuoDes.HeaderText = "Cuo Destino";
            this.xCuoDes.MinimumWidth = 70;
            this.xCuoDes.Name = "xCuoDes";
            this.xCuoDes.ReadOnly = true;
            this.xCuoDes.Width = 70;
            // 
            // xCtaContableDes
            // 
            this.xCtaContableDes.DataPropertyName = "CtaContableDes";
            this.xCtaContableDes.HeaderText = "CtaContableDes";
            this.xCtaContableDes.Name = "xCtaContableDes";
            this.xCtaContableDes.ReadOnly = true;
            this.xCtaContableDes.Visible = false;
            // 
            // xidMoneda
            // 
            this.xidMoneda.DataPropertyName = "idMoneda";
            this.xidMoneda.HeaderText = "idMoneda";
            this.xidMoneda.Name = "xidMoneda";
            this.xidMoneda.ReadOnly = true;
            this.xidMoneda.Visible = false;
            // 
            // xmon
            // 
            this.xmon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xmon.DataPropertyName = "moneda";
            this.xmon.HeaderText = "Mon";
            this.xmon.MinimumWidth = 40;
            this.xmon.Name = "xmon";
            this.xmon.ReadOnly = true;
            this.xmon.Width = 40;
            // 
            // ximporte
            // 
            this.ximporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ximporte.DataPropertyName = "montoPrestado";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.ximporte.DefaultCellStyle = dataGridViewCellStyle5;
            this.ximporte.HeaderText = "Monto";
            this.ximporte.MinimumWidth = 50;
            this.ximporte.Name = "ximporte";
            this.ximporte.ReadOnly = true;
            this.ximporte.Width = 50;
            // 
            // xfechaprestamo
            // 
            this.xfechaprestamo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xfechaprestamo.DataPropertyName = "FechaPrestado";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            this.xfechaprestamo.DefaultCellStyle = dataGridViewCellStyle6;
            this.xfechaprestamo.HeaderText = "Fecha Prestamo";
            this.xfechaprestamo.MinimumWidth = 80;
            this.xfechaprestamo.Name = "xfechaprestamo";
            this.xfechaprestamo.ReadOnly = true;
            this.xfechaprestamo.Width = 80;
            // 
            // xFechaContable
            // 
            this.xFechaContable.DataPropertyName = "FechaContable";
            this.xFechaContable.HeaderText = "FechaContable";
            this.xFechaContable.Name = "xFechaContable";
            this.xFechaContable.ReadOnly = true;
            this.xFechaContable.Visible = false;
            // 
            // xtc
            // 
            this.xtc.DataPropertyName = "tc";
            this.xtc.HeaderText = "tc";
            this.xtc.Name = "xtc";
            this.xtc.ReadOnly = true;
            this.xtc.Visible = false;
            // 
            // xglosa
            // 
            this.xglosa.DataPropertyName = "glosa";
            this.xglosa.HeaderText = "Glosa";
            this.xglosa.MinimumWidth = 100;
            this.xglosa.Name = "xglosa";
            this.xglosa.ReadOnly = true;
            // 
            // xEstado
            // 
            this.xEstado.DataPropertyName = "Estado";
            this.xEstado.HeaderText = "Estado";
            this.xEstado.Name = "xEstado";
            this.xEstado.ReadOnly = true;
            this.xEstado.Visible = false;
            // 
            // xNEstado
            // 
            this.xNEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xNEstado.DataPropertyName = "nestado";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xNEstado.DefaultCellStyle = dataGridViewCellStyle7;
            this.xNEstado.HeaderText = "Estado";
            this.xNEstado.MinimumWidth = 50;
            this.xNEstado.Name = "xNEstado";
            this.xNEstado.ReadOnly = true;
            this.xNEstado.Width = 50;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(887, 430);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(85, 23);
            this.btncancelar.TabIndex = 357;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblmensaje.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(14, 436);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(94, 13);
            this.lblmensaje.TabIndex = 358;
            this.lblmensaje.Text = "Total Registros: 0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(12, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(183, 13);
            this.label20.TabIndex = 359;
            this.label20.Text = "Listado de Prestamos Cancelados:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(880, 25);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(92, 23);
            this.btnActualizar.TabIndex = 406;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btncleanfind
            // 
            this.btncleanfind.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncleanfind.Image = ((System.Drawing.Image)(resources.GetObject("btncleanfind.Image")));
            this.btncleanfind.Location = new System.Drawing.Point(788, 25);
            this.btncleanfind.Name = "btncleanfind";
            this.btncleanfind.Size = new System.Drawing.Size(25, 23);
            this.btncleanfind.TabIndex = 417;
            this.btncleanfind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncleanfind.UseVisualStyleBackColor = true;
            this.btncleanfind.Click += new System.EventHandler(this.btncleanfind_Click);
            // 
            // txtbusMoneda
            // 
            this.txtbusMoneda.BackColor = System.Drawing.Color.White;
            this.txtbusMoneda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusMoneda.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusMoneda.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusMoneda.ForeColor = System.Drawing.Color.Black;
            this.txtbusMoneda.Format = null;
            this.txtbusMoneda.Location = new System.Drawing.Point(384, 26);
            this.txtbusMoneda.MaxLength = 300;
            this.txtbusMoneda.Name = "txtbusMoneda";
            this.txtbusMoneda.NextControlOnEnter = null;
            this.txtbusMoneda.Size = new System.Drawing.Size(113, 21);
            this.txtbusMoneda.TabIndex = 416;
            this.txtbusMoneda.Text = "Buscar Moneda";
            this.txtbusMoneda.TextoDefecto = "Buscar Moneda";
            this.txtbusMoneda.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusMoneda.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusMoneda.TextChanged += new System.EventHandler(this.txtbusMoneda_TextChanged);
            // 
            // txtbusempresadestino
            // 
            this.txtbusempresadestino.BackColor = System.Drawing.Color.White;
            this.txtbusempresadestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusempresadestino.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusempresadestino.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusempresadestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusempresadestino.ForeColor = System.Drawing.Color.Black;
            this.txtbusempresadestino.Format = null;
            this.txtbusempresadestino.Location = new System.Drawing.Point(205, 26);
            this.txtbusempresadestino.MaxLength = 300;
            this.txtbusempresadestino.Name = "txtbusempresadestino";
            this.txtbusempresadestino.NextControlOnEnter = null;
            this.txtbusempresadestino.Size = new System.Drawing.Size(177, 21);
            this.txtbusempresadestino.TabIndex = 414;
            this.txtbusempresadestino.Text = "Buscar Empresa Destino";
            this.txtbusempresadestino.TextoDefecto = "Buscar Empresa Destino";
            this.txtbusempresadestino.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusempresadestino.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusempresadestino.TextChanged += new System.EventHandler(this.txtbusempresadestino_TextChanged);
            // 
            // txtbusempresaorigen
            // 
            this.txtbusempresaorigen.BackColor = System.Drawing.Color.White;
            this.txtbusempresaorigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbusempresaorigen.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbusempresaorigen.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbusempresaorigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusempresaorigen.ForeColor = System.Drawing.Color.Black;
            this.txtbusempresaorigen.Format = null;
            this.txtbusempresaorigen.Location = new System.Drawing.Point(12, 26);
            this.txtbusempresaorigen.MaxLength = 300;
            this.txtbusempresaorigen.Name = "txtbusempresaorigen";
            this.txtbusempresaorigen.NextControlOnEnter = null;
            this.txtbusempresaorigen.Size = new System.Drawing.Size(177, 21);
            this.txtbusempresaorigen.TabIndex = 413;
            this.txtbusempresaorigen.Text = "Buscar Empresa Origen";
            this.txtbusempresaorigen.TextoDefecto = "Buscar Empresa Origen";
            this.txtbusempresaorigen.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbusempresaorigen.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            this.txtbusempresaorigen.TextChanged += new System.EventHandler(this.txtbusempresaorigen_TextChanged);
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.Color.Transparent;
            this.btnCambiar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCambiar.FlatAppearance.BorderSize = 0;
            this.btnCambiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiar.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiar.Image")));
            this.btnCambiar.Location = new System.Drawing.Point(186, 26);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(20, 20);
            this.btnCambiar.TabIndex = 415;
            this.btnCambiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexcel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexcel.Image")));
            this.btnexcel.Location = new System.Drawing.Point(451, 430);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(82, 23);
            this.btnexcel.TabIndex = 418;
            this.btnexcel.Text = "Excel";
            this.btnexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // dtpfechabus2
            // 
            this.dtpfechabus2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechabus2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfechabus2.Location = new System.Drawing.Point(693, 25);
            this.dtpfechabus2.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpfechabus2.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpfechabus2.Name = "dtpfechabus2";
            this.dtpfechabus2.Size = new System.Drawing.Size(93, 22);
            this.dtpfechabus2.TabIndex = 420;
            this.dtpfechabus2.Value = new System.DateTime(2017, 4, 27, 9, 44, 35, 0);
            this.dtpfechabus2.ValueChanged += new System.EventHandler(this.dtpfechabus2_ValueChanged);
            // 
            // dtpfechabus1
            // 
            this.dtpfechabus1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechabus1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfechabus1.Location = new System.Drawing.Point(597, 25);
            this.dtpfechabus1.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpfechabus1.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpfechabus1.Name = "dtpfechabus1";
            this.dtpfechabus1.Size = new System.Drawing.Size(93, 22);
            this.dtpfechabus1.TabIndex = 419;
            this.dtpfechabus1.Value = new System.DateTime(2017, 4, 27, 9, 44, 35, 0);
            this.dtpfechabus1.ValueChanged += new System.EventHandler(this.dtpfechabus1_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoEllipsis = true;
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.label23.Location = new System.Drawing.Point(497, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 15);
            this.label23.TabIndex = 421;
            this.label23.Text = "Fecha Prestamo:";
            // 
            // frmListadoPrestamosCancelados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.dtpfechabus2);
            this.Controls.Add(this.dtpfechabus1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btncleanfind);
            this.Controls.Add(this.txtbusMoneda);
            this.Controls.Add(this.txtbusempresadestino);
            this.Controls.Add(this.txtbusempresaorigen);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.dtgconten);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "frmListadoPrestamosCancelados";
            this.Nombre = "Listado de Prestamos Cancelados";
            this.Text = "Listado de Prestamos Cancelados";
            this.Load += new System.EventHandler(this.frmListadoPrestamosCancelados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpkid;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfkEmpresaOri;
        private System.Windows.Forms.DataGridViewTextBoxColumn xempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfkidProyectoOri;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfkidEtapaOri;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidBancoOri;
        private System.Windows.Forms.DataGridViewTextBoxColumn xbancoOri;
        private System.Windows.Forms.DataGridViewTextBoxColumn xsufijoori;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidCtaOri;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCtaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuoOri;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCtaContableOri;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfkEmpresaDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEmpresaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfkidProyectoDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfkidEtapaDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidBancoDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn xBancodes;
        private System.Windows.Forms.DataGridViewTextBoxColumn xsufijodes;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidCtaDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCtaDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuoDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCtaContableDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn xidMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ximporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn xfechaprestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaContable;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xglosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNEstado;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btncleanfind;
        private HpResergerUserControls.TextBoxPer txtbusMoneda;
        private HpResergerUserControls.TextBoxPer txtbusempresadestino;
        private HpResergerUserControls.TextBoxPer txtbusempresaorigen;
        private System.Windows.Forms.Button btnCambiar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.DateTimePicker dtpfechabus2;
        private System.Windows.Forms.DateTimePicker dtpfechabus1;
        private System.Windows.Forms.Label label23;
    }
}