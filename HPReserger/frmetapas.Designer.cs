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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dtgconten = new System.Windows.Forms.DataGridView();
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Dtgconten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtgconten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.Dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Dtgconten.Location = new System.Drawing.Point(12, 157);
            this.Dtgconten.MultiSelect = false;
            this.Dtgconten.Name = "Dtgconten";
            this.Dtgconten.ReadOnly = true;
            this.Dtgconten.RowHeadersVisible = false;
            this.Dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtgconten.Size = new System.Drawing.Size(622, 217);
            this.Dtgconten.TabIndex = 12;
            this.Dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtgconten_RowEnter);
            // 
            // pnl1
            // 
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
            this.pnl1.Size = new System.Drawing.Size(541, 139);
            this.pnl1.TabIndex = 13;
            // 
            // cboestado
            // 
            this.cboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(305, 62);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(138, 21);
            this.cboestado.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado:";
            // 
            // txtobserva
            // 
            this.txtobserva.Location = new System.Drawing.Point(85, 89);
            this.txtobserva.Multiline = true;
            this.txtobserva.Name = "txtobserva";
            this.txtobserva.Size = new System.Drawing.Size(435, 42);
            this.txtobserva.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Observación:";
            // 
            // txtmeses
            // 
            this.txtmeses.Location = new System.Drawing.Point(125, 63);
            this.txtmeses.Name = "txtmeses";
            this.txtmeses.Size = new System.Drawing.Size(100, 20);
            this.txtmeses.TabIndex = 7;
            this.txtmeses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmeses_KeyDown);
            this.txtmeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmeses_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Meses Construcción:";
            // 
            // dtpfechafin
            // 
            this.dtpfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechafin.Location = new System.Drawing.Point(304, 36);
            this.dtpfechafin.Name = "dtpfechafin";
            this.dtpfechafin.Size = new System.Drawing.Size(139, 20);
            this.dtpfechafin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Fin:";
            // 
            // dtpfechainicio
            // 
            this.dtpfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechainicio.Location = new System.Drawing.Point(85, 38);
            this.dtpfechainicio.Name = "dtpfechainicio";
            this.dtpfechainicio.Size = new System.Drawing.Size(140, 20);
            this.dtpfechainicio.TabIndex = 3;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescripcion.Location = new System.Drawing.Point(85, 12);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(435, 20);
            this.txtdescripcion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción:";
            // 
            // btnaceptar
            // 
            this.btnaceptar.Enabled = false;
            this.btnaceptar.Location = new System.Drawing.Point(478, 380);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 17;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(559, 380);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 16;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(559, 38);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 20);
            this.btnmodificar.TabIndex = 15;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(559, 12);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 20);
            this.btnnuevo.TabIndex = 14;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
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
            dataGridViewCellStyle6.Format = "d";
            this.fechainicio.DefaultCellStyle = dataGridViewCellStyle6;
            this.fechainicio.HeaderText = "Fecha Inicio";
            this.fechainicio.Name = "fechainicio";
            this.fechainicio.ReadOnly = true;
            this.fechainicio.Width = 90;
            // 
            // fechafin
            // 
            this.fechafin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechafin.DataPropertyName = "fecha_fin";
            dataGridViewCellStyle7.Format = "d";
            this.fechafin.DefaultCellStyle = dataGridViewCellStyle7;
            this.fechafin.HeaderText = "Fecha Fin";
            this.fechafin.Name = "fechafin";
            this.fechafin.ReadOnly = true;
            this.fechafin.Width = 79;
            // 
            // mesesconstruccion
            // 
            this.mesesconstruccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mesesconstruccion.DataPropertyName = "meses_construccion";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.mesesconstruccion.DefaultCellStyle = dataGridViewCellStyle8;
            this.mesesconstruccion.HeaderText = "Duracion Meses";
            this.mesesconstruccion.Name = "mesesconstruccion";
            this.mesesconstruccion.ReadOnly = true;
            this.mesesconstruccion.Width = 109;
            // 
            // Observacion
            // 
            this.Observacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Observacion.DataPropertyName = "Observacion";
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.Name = "Observacion";
            this.Observacion.ReadOnly = true;
            this.Observacion.Width = 92;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etapas";
            this.Load += new System.EventHandler(this.frmetapas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtgconten)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dtgconten;
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