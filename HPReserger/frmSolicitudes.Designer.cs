﻿namespace HPReserger
{
    partial class frmSolicitudes
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btncancelar = new System.Windows.Forms.Button();
            this.btnaprovar = new System.Windows.Forms.Button();
            this.dtgconten = new System.Windows.Forms.DataGridView();
            this.empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solicitaemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnrecargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitudes:";
            // 
            // Btncancelar
            // 
            this.Btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btncancelar.Location = new System.Drawing.Point(612, 462);
            this.Btncancelar.Name = "Btncancelar";
            this.Btncancelar.Size = new System.Drawing.Size(75, 23);
            this.Btncancelar.TabIndex = 1;
            this.Btncancelar.Text = "Cancelar";
            this.Btncancelar.UseVisualStyleBackColor = true;
            this.Btncancelar.Click += new System.EventHandler(this.Btncancelar_Click);
            // 
            // btnaprovar
            // 
            this.btnaprovar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaprovar.Location = new System.Drawing.Point(415, 462);
            this.btnaprovar.Name = "btnaprovar";
            this.btnaprovar.Size = new System.Drawing.Size(75, 23);
            this.btnaprovar.TabIndex = 2;
            this.btnaprovar.Text = "Aprobar";
            this.btnaprovar.UseVisualStyleBackColor = true;
            this.btnaprovar.Click += new System.EventHandler(this.btnaprovar_Click);
            // 
            // dtgconten
            // 
            this.dtgconten.AllowUserToAddRows = false;
            this.dtgconten.AllowUserToDeleteRows = false;
            this.dtgconten.AllowUserToResizeColumns = false;
            this.dtgconten.AllowUserToResizeRows = false;
            this.dtgconten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgconten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgconten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empleado,
            this.cod_empleado,
            this.Accion,
            this.Valores,
            this.estados,
            this.Solicitaemp,
            this.observacion});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.Location = new System.Drawing.Point(12, 46);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(675, 410);
            this.dtgconten.TabIndex = 57;
            // 
            // empleado
            // 
            this.empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empleado.DataPropertyName = "empleado";
            this.empleado.HeaderText = "Empleado";
            this.empleado.Name = "empleado";
            this.empleado.ReadOnly = true;
            // 
            // cod_empleado
            // 
            this.cod_empleado.DataPropertyName = "cod_emp";
            this.cod_empleado.HeaderText = "codempleado";
            this.cod_empleado.Name = "cod_empleado";
            this.cod_empleado.ReadOnly = true;
            this.cod_empleado.Visible = false;
            // 
            // Accion
            // 
            this.Accion.DataPropertyName = "accion";
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            this.Accion.Visible = false;
            // 
            // Valores
            // 
            this.Valores.DataPropertyName = "valores";
            this.Valores.HeaderText = "Valores";
            this.Valores.Name = "Valores";
            this.Valores.ReadOnly = true;
            this.Valores.Visible = false;
            // 
            // estados
            // 
            this.estados.DataPropertyName = "estado";
            this.estados.HeaderText = "estados";
            this.estados.Name = "estados";
            this.estados.ReadOnly = true;
            this.estados.Visible = false;
            // 
            // Solicitaemp
            // 
            this.Solicitaemp.DataPropertyName = "solicitaemp";
            this.Solicitaemp.HeaderText = "solicitaemp";
            this.Solicitaemp.Name = "Solicitaemp";
            this.Solicitaemp.ReadOnly = true;
            this.Solicitaemp.Visible = false;
            // 
            // observacion
            // 
            this.observacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.observacion.DataPropertyName = "observacion";
            this.observacion.HeaderText = "Solicitud";
            this.observacion.MinimumWidth = 270;
            this.observacion.Name = "observacion";
            this.observacion.ReadOnly = true;
            this.observacion.Width = 270;
            // 
            // btnrecargar
            // 
            this.btnrecargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrecargar.Location = new System.Drawing.Point(612, 17);
            this.btnrecargar.Name = "btnrecargar";
            this.btnrecargar.Size = new System.Drawing.Size(75, 23);
            this.btnrecargar.TabIndex = 58;
            this.btnrecargar.Text = "Recargar";
            this.btnrecargar.UseVisualStyleBackColor = true;
            this.btnrecargar.Click += new System.EventHandler(this.btnrecargar_Click);
            // 
            // frmSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 497);
            this.Controls.Add(this.btnrecargar);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.btnaprovar);
            this.Controls.Add(this.Btncancelar);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(571, 335);
            this.Name = "frmSolicitudes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitudes ";
            this.Load += new System.EventHandler(this.frmSolicitudes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btncancelar;
        private System.Windows.Forms.Button btnaprovar;
        private System.Windows.Forms.DataGridView dtgconten;
        private System.Windows.Forms.Button btnrecargar;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valores;
        private System.Windows.Forms.DataGridViewTextBoxColumn estados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solicitaemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
    }
}