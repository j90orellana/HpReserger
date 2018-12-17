namespace HPReserger
{
    partial class frmListarProductosVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarProductosVenta));
            this.dtgconten1 = new HpResergerUserControls.Dtgconten();
            this.Id_Proy_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Proy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Base = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_PreVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCorto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoLetras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new HpResergerUserControls.txtBuscar();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.cboempresa = new HpResergerUserControls.ComboBoxPer(this.components);
            this.cboproyecto = new HpResergerUserControls.ComboBoxPer(this.components);
            this.lblmsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgconten1
            // 
            this.dtgconten1.AllowUserToAddRows = false;
            this.dtgconten1.AllowUserToDeleteRows = false;
            this.dtgconten1.AllowUserToOrderColumns = true;
            this.dtgconten1.AllowUserToResizeColumns = false;
            this.dtgconten1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.dtgconten1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.dtgconten1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgconten1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Proy_Prod,
            this.idempresa,
            this.Id_Proy,
            this.Id_Prod,
            this.id_moneda,
            this.id_unidad,
            this.empresa,
            this.Proyecto,
            this.Producto,
            this.UnidadMedida,
            this.Cantidad,
            this.Precio_Base,
            this.Precio_PreVenta,
            this.NameCorto,
            this.Observacion,
            this.Etapa,
            this.Estado,
            this.EstadoLetras,
            this.usuario,
            this.fecha});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgconten1.EnableHeadersVisualStyles = false;
            this.dtgconten1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten1.Location = new System.Drawing.Point(12, 40);
            this.dtgconten1.Name = "dtgconten1";
            this.dtgconten1.ReadOnly = true;
            this.dtgconten1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten1.RowHeadersVisible = false;
            this.dtgconten1.RowTemplate.Height = 18;
            this.dtgconten1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten1.Size = new System.Drawing.Size(1040, 382);
            this.dtgconten1.TabIndex = 0;
            this.dtgconten1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten1_CellDoubleClick);
            // 
            // Id_Proy_Prod
            // 
            this.Id_Proy_Prod.DataPropertyName = "Id_Proy_Prod";
            this.Id_Proy_Prod.HeaderText = "Id_Proy_Prod";
            this.Id_Proy_Prod.Name = "Id_Proy_Prod";
            this.Id_Proy_Prod.ReadOnly = true;
            this.Id_Proy_Prod.Visible = false;
            // 
            // idempresa
            // 
            this.idempresa.DataPropertyName = "idempresa";
            this.idempresa.HeaderText = "idempresa";
            this.idempresa.Name = "idempresa";
            this.idempresa.ReadOnly = true;
            this.idempresa.Visible = false;
            // 
            // Id_Proy
            // 
            this.Id_Proy.DataPropertyName = "Id_Proy";
            this.Id_Proy.HeaderText = "Id_Proy";
            this.Id_Proy.Name = "Id_Proy";
            this.Id_Proy.ReadOnly = true;
            this.Id_Proy.Visible = false;
            // 
            // Id_Prod
            // 
            this.Id_Prod.DataPropertyName = "Id_Prod";
            this.Id_Prod.HeaderText = "Id_Prod";
            this.Id_Prod.Name = "Id_Prod";
            this.Id_Prod.ReadOnly = true;
            this.Id_Prod.Visible = false;
            // 
            // id_moneda
            // 
            this.id_moneda.DataPropertyName = "id_moneda";
            this.id_moneda.HeaderText = "id_moneda";
            this.id_moneda.Name = "id_moneda";
            this.id_moneda.ReadOnly = true;
            this.id_moneda.Visible = false;
            // 
            // id_unidad
            // 
            this.id_unidad.DataPropertyName = "id_unidad";
            this.id_unidad.HeaderText = "id_unidad";
            this.id_unidad.Name = "id_unidad";
            this.id_unidad.ReadOnly = true;
            this.id_unidad.Visible = false;
            // 
            // empresa
            // 
            this.empresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.empresa.DataPropertyName = "empresa";
            this.empresa.HeaderText = "Empresa";
            this.empresa.MinimumWidth = 70;
            this.empresa.Name = "empresa";
            this.empresa.ReadOnly = true;
            this.empresa.Width = 74;
            // 
            // Proyecto
            // 
            this.Proyecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Proyecto.DataPropertyName = "Proyecto";
            this.Proyecto.HeaderText = "Proyecto";
            this.Proyecto.MinimumWidth = 70;
            this.Proyecto.Name = "Proyecto";
            this.Proyecto.ReadOnly = true;
            this.Proyecto.Width = 75;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.DataPropertyName = "Producto";
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 200;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UnidadMedida.DataPropertyName = "UnidadMedida";
            this.UnidadMedida.HeaderText = "U.Medida";
            this.UnidadMedida.MinimumWidth = 50;
            this.UnidadMedida.Name = "UnidadMedida";
            this.UnidadMedida.ReadOnly = true;
            this.UnidadMedida.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cantidad.HeaderText = "Cant.";
            this.Cantidad.MinimumWidth = 50;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 58;
            // 
            // Precio_Base
            // 
            this.Precio_Base.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Precio_Base.DataPropertyName = "Precio_Base";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Precio_Base.DefaultCellStyle = dataGridViewCellStyle4;
            this.Precio_Base.HeaderText = "Precio Base";
            this.Precio_Base.MinimumWidth = 60;
            this.Precio_Base.Name = "Precio_Base";
            this.Precio_Base.ReadOnly = true;
            this.Precio_Base.Width = 89;
            // 
            // Precio_PreVenta
            // 
            this.Precio_PreVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Precio_PreVenta.DataPropertyName = "Precio_PreVenta";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Precio_PreVenta.DefaultCellStyle = dataGridViewCellStyle5;
            this.Precio_PreVenta.HeaderText = "P.PVenta";
            this.Precio_PreVenta.MinimumWidth = 60;
            this.Precio_PreVenta.Name = "Precio_PreVenta";
            this.Precio_PreVenta.ReadOnly = true;
            this.Precio_PreVenta.Width = 75;
            // 
            // NameCorto
            // 
            this.NameCorto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NameCorto.DataPropertyName = "NameCorto";
            this.NameCorto.HeaderText = "M";
            this.NameCorto.MinimumWidth = 20;
            this.NameCorto.Name = "NameCorto";
            this.NameCorto.ReadOnly = true;
            this.NameCorto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameCorto.Width = 22;
            // 
            // Observacion
            // 
            this.Observacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Observacion.DataPropertyName = "Observacion";
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.MinimumWidth = 150;
            this.Observacion.Name = "Observacion";
            this.Observacion.ReadOnly = true;
            this.Observacion.Width = 150;
            // 
            // Etapa
            // 
            this.Etapa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Etapa.DataPropertyName = "Etapa";
            this.Etapa.HeaderText = "Etapa";
            this.Etapa.MinimumWidth = 60;
            this.Etapa.Name = "Etapa";
            this.Etapa.ReadOnly = true;
            this.Etapa.Visible = false;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // EstadoLetras
            // 
            this.EstadoLetras.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EstadoLetras.DataPropertyName = "EstadoLetras";
            this.EstadoLetras.HeaderText = "Estado";
            this.EstadoLetras.MinimumWidth = 60;
            this.EstadoLetras.Name = "EstadoLetras";
            this.EstadoLetras.ReadOnly = true;
            this.EstadoLetras.Width = 66;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Visible = false;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Visible = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtBuscar.FondoBoton = ((System.Drawing.Image)(resources.GetObject("txtBuscar.FondoBoton")));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ImgBotonCerrar = null;
            this.txtBuscar.Location = new System.Drawing.Point(12, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(476, 22);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.BuscarClick += new System.EventHandler(this.txtBuscar_BuscarTextChanged);
            this.txtBuscar.BuscarTextChanged += new System.EventHandler(this.txtBuscar_BuscarTextChanged);
            this.txtBuscar.Load += new System.EventHandler(this.txtBuscar_Load);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(970, 428);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 23);
            this.btnaceptar.TabIndex = 135;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // cboempresa
            // 
            this.cboempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboempresa.FormattingEnabled = true;
            this.cboempresa.IndexText = null;
            this.cboempresa.Location = new System.Drawing.Point(494, 12);
            this.cboempresa.Name = "cboempresa";
            this.cboempresa.ReadOnly = false;
            this.cboempresa.Size = new System.Drawing.Size(213, 21);
            this.cboempresa.TabIndex = 136;
            this.cboempresa.SelectedIndexChanged += new System.EventHandler(this.cboempresa_SelectedIndexChanged);
            this.cboempresa.Click += new System.EventHandler(this.cboempresa_Click);
            // 
            // cboproyecto
            // 
            this.cboproyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboproyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboproyecto.FormattingEnabled = true;
            this.cboproyecto.IndexText = null;
            this.cboproyecto.Location = new System.Drawing.Point(713, 12);
            this.cboproyecto.Name = "cboproyecto";
            this.cboproyecto.ReadOnly = false;
            this.cboproyecto.Size = new System.Drawing.Size(213, 21);
            this.cboproyecto.TabIndex = 137;
            this.cboproyecto.SelectedIndexChanged += new System.EventHandler(this.cboproyecto_SelectedIndexChanged);
            this.cboproyecto.Click += new System.EventHandler(this.cboproyecto_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Location = new System.Drawing.Point(12, 433);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(113, 13);
            this.lblmsg.TabIndex = 138;
            this.lblmsg.Text = "Total de Registros : 0";
            // 
            // frmListarProductosVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 461);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.cboproyecto);
            this.Controls.Add(this.cboempresa);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dtgconten1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "frmListarProductosVenta";
            this.Nombre = "Productos a la Venta";
            this.Text = "Productos a la Venta";
            this.Load += new System.EventHandler(this.frmListarProductosVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HpResergerUserControls.Dtgconten dtgconten1;
        private HpResergerUserControls.txtBuscar txtBuscar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Proy_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Proy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Base;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_PreVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCorto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoLetras;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private HpResergerUserControls.ComboBoxPer cboempresa;
        private HpResergerUserControls.ComboBoxPer cboproyecto;
        private System.Windows.Forms.Label lblmsg;
    }
}