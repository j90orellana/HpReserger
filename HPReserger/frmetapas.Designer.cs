using HpResergerUserControls;

namespace HPReserger
{
    partial class frmetapas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmetapas));
            this.Dtgconten = new HpResergerUserControls.Dtgconten();
            this.id_etapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechainicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesesconstruccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtobserva = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmeses = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpfechafin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpfechainicio = new System.Windows.Forms.DateTimePicker();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dtgconten)).BeginInit();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dtgconten
            // 
            this.Dtgconten.AllowUserToAddRows = false;
            this.Dtgconten.AllowUserToDeleteRows = false;
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
            this.Dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_etapa,
            this.id_proyecto,
            this.descripcion,
            this.estado,
            this.fechainicio,
            this.fechafin,
            this.mesesconstruccion,
            this.Observacion,
            this.usuario,
            this.fecha});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dtgconten.DefaultCellStyle = dataGridViewCellStyle6;
            this.Dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dtgconten.EnableHeadersVisualStyles = false;
            this.Dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.Dtgconten.Location = new System.Drawing.Point(12, 145);
            this.Dtgconten.MultiSelect = false;
            this.Dtgconten.Name = "Dtgconten";
            this.Dtgconten.ReadOnly = true;
            this.Dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dtgconten.RowHeadersVisible = false;
            this.Dtgconten.RowTemplate.Height = 16;
            this.Dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtgconten.Size = new System.Drawing.Size(622, 231);
            this.Dtgconten.TabIndex = 12;
            this.Dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_RowEnter);
            // 
            // id_etapa
            // 
            this.id_etapa.DataPropertyName = "id_etapa";
            this.id_etapa.HeaderText = "id_etapa";
            this.id_etapa.Name = "id_etapa";
            this.id_etapa.ReadOnly = true;
            this.id_etapa.Visible = false;
            // 
            // id_proyecto
            // 
            this.id_proyecto.DataPropertyName = "fk_id_proyecto";
            this.id_proyecto.HeaderText = "id_proyecto";
            this.id_proyecto.Name = "id_proyecto";
            this.id_proyecto.ReadOnly = true;
            this.id_proyecto.Visible = false;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            // 
            // fechainicio
            // 
            this.fechainicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechainicio.DataPropertyName = "fecha_inicio";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.fechainicio.DefaultCellStyle = dataGridViewCellStyle3;
            this.fechainicio.HeaderText = "Fecha Inicio";
            this.fechainicio.Name = "fechainicio";
            this.fechainicio.ReadOnly = true;
            this.fechainicio.Width = 94;
            // 
            // fechafin
            // 
            this.fechafin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechafin.DataPropertyName = "fecha_fin";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.fechafin.DefaultCellStyle = dataGridViewCellStyle4;
            this.fechafin.HeaderText = "Fecha Fin";
            this.fechafin.Name = "fechafin";
            this.fechafin.ReadOnly = true;
            this.fechafin.Width = 81;
            // 
            // mesesconstruccion
            // 
            this.mesesconstruccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mesesconstruccion.DataPropertyName = "meses_construccion";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.mesesconstruccion.DefaultCellStyle = dataGridViewCellStyle5;
            this.mesesconstruccion.HeaderText = "Duracion Meses";
            this.mesesconstruccion.Name = "mesesconstruccion";
            this.mesesconstruccion.ReadOnly = true;
            this.mesesconstruccion.Width = 115;
            // 
            // Observacion
            // 
            this.Observacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Observacion.DataPropertyName = "Observacion";
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.Name = "Observacion";
            this.Observacion.ReadOnly = true;
            this.Observacion.Width = 97;
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
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Transparent;
            this.pnl1.Controls.Add(this.cboestado);
            this.pnl1.Controls.Add(this.label6);
            this.pnl1.Controls.Add(this.txtobserva);
            this.pnl1.Controls.Add(this.label5);
            this.pnl1.Controls.Add(this.txtmeses);
            this.pnl1.Controls.Add(this.label4);
            this.pnl1.Controls.Add(this.dtpfechafin);
            this.pnl1.Controls.Add(this.label3);
            this.pnl1.Controls.Add(this.dtpfechainicio);
            this.pnl1.Controls.Add(this.txtdescripcion);
            this.pnl1.Controls.Add(this.label2);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Enabled = false;
            this.pnl1.Location = new System.Drawing.Point(12, 12);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(541, 128);
            this.pnl1.TabIndex = 13;
            // 
            // cboestado
            // 
            this.cboestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(382, 58);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(138, 21);
            this.cboestado.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado:";
            // 
            // txtobserva
            // 
            this.txtobserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobserva.Location = new System.Drawing.Point(90, 82);
            this.txtobserva.Multiline = true;
            this.txtobserva.Name = "txtobserva";
            this.txtobserva.Size = new System.Drawing.Size(430, 42);
            this.txtobserva.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Observación:";
            // 
            // txtmeses
            // 
            this.txtmeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmeses.Location = new System.Drawing.Point(130, 58);
            this.txtmeses.Name = "txtmeses";
            this.txtmeses.Size = new System.Drawing.Size(100, 21);
            this.txtmeses.TabIndex = 7;
            this.txtmeses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmeses_KeyDown);
            this.txtmeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmeses_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Meses Construcción:";
            // 
            // dtpfechafin
            // 
            this.dtpfechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechafin.Location = new System.Drawing.Point(381, 35);
            this.dtpfechafin.Name = "dtpfechafin";
            this.dtpfechafin.Size = new System.Drawing.Size(139, 21);
            this.dtpfechafin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Fin:";
            // 
            // dtpfechainicio
            // 
            this.dtpfechainicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechainicio.Location = new System.Drawing.Point(90, 35);
            this.dtpfechainicio.Name = "dtpfechainicio";
            this.dtpfechainicio.Size = new System.Drawing.Size(140, 21);
            this.dtpfechainicio.TabIndex = 3;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.Location = new System.Drawing.Point(90, 12);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(430, 21);
            this.txtdescripcion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción:";
            // 
            // btnaceptar
            // 
            this.btnaceptar.Enabled = false;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(478, 382);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 17;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(559, 382);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 16;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.Location = new System.Drawing.Point(559, 38);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 15;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.Location = new System.Drawing.Point(559, 12);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 14;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // frmetapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 412);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.Dtgconten);
            this.MaximumSize = new System.Drawing.Size(665, 451);
            this.MinimumSize = new System.Drawing.Size(665, 451);
            this.Name = "frmetapas";
            this.Nombre = "Etapas";
            this.Text = "Etapas";
            this.Load += new System.EventHandler(this.frmetapas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtgconten)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Dtgconten Dtgconten;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.TextBox txtobserva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmeses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpfechafin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpfechainicio;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_etapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_proyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechainicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafin;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesesconstruccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
    }
}