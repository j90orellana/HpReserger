﻿using HpResergerUserControls;

namespace HPReserger
{
    partial class frmListarEmpleadosDesvinculados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarEmpleadosDesvinculados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.NRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NROID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIQUIDACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRELIQUIDACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRECTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONSTANCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRECONSTANCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRERENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRACTICAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBREPRACTICAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRESALIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttipoid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnroid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(684, 338);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 42;
            this.btnaceptar.Text = "Guardar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(765, 338);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 43;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
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
            this.dtgconten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgconten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgconten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NRO,
            this.TIPOID,
            this.TIPO,
            this.NROID,
            this.NOMBRES,
            this.APELLIDOS,
            this.LIQUIDACION,
            this.NOMBRELIQUIDACION,
            this.CTS,
            this.NOMBRECTS,
            this.CONSTANCIA,
            this.NOMBRECONSTANCIA,
            this.RENTA,
            this.NOMBRERENTA,
            this.PRACTICAS,
            this.NOMBREPRACTICAS,
            this.SALIDA,
            this.NOMBRESALIDA});
            this.dtgconten.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(12, 104);
            this.dtgconten.MultiSelect = false;
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 16;
            this.dtgconten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgconten.Size = new System.Drawing.Size(828, 228);
            this.dtgconten.TabIndex = 151;
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // NRO
            // 
            this.NRO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NRO.DataPropertyName = "NROCONTRATO";
            this.NRO.HeaderText = "NRO CONTRATO CESADO";
            this.NRO.Name = "NRO";
            this.NRO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.NRO.Width = 169;
            // 
            // TIPOID
            // 
            this.TIPOID.DataPropertyName = "TIPOID";
            this.TIPOID.HeaderText = "TIPOID";
            this.TIPOID.Name = "TIPOID";
            this.TIPOID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.TIPOID.Visible = false;
            // 
            // TIPO
            // 
            this.TIPO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TIPO.DataPropertyName = "TIPO";
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.Width = 57;
            // 
            // NROID
            // 
            this.NROID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NROID.DataPropertyName = "NROID";
            this.NROID.HeaderText = "NROID";
            this.NROID.Name = "NROID";
            this.NROID.Width = 67;
            // 
            // NOMBRES
            // 
            this.NOMBRES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NOMBRES.DataPropertyName = "NOMBRES";
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.NOMBRES.Width = 86;
            // 
            // APELLIDOS
            // 
            this.APELLIDOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.APELLIDOS.DataPropertyName = "APELLIDOS";
            this.APELLIDOS.HeaderText = "APELLIDOS";
            this.APELLIDOS.Name = "APELLIDOS";
            this.APELLIDOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // LIQUIDACION
            // 
            this.LIQUIDACION.DataPropertyName = "LIQUIDACION";
            this.LIQUIDACION.HeaderText = "LIQUIDACION";
            this.LIQUIDACION.Name = "LIQUIDACION";
            this.LIQUIDACION.Visible = false;
            // 
            // NOMBRELIQUIDACION
            // 
            this.NOMBRELIQUIDACION.DataPropertyName = "NOMBRELIQUIDACION";
            this.NOMBRELIQUIDACION.HeaderText = "NOMBRELIQUIDACION";
            this.NOMBRELIQUIDACION.Name = "NOMBRELIQUIDACION";
            this.NOMBRELIQUIDACION.Visible = false;
            // 
            // CTS
            // 
            this.CTS.DataPropertyName = "CTS";
            this.CTS.HeaderText = "CTS";
            this.CTS.Name = "CTS";
            this.CTS.Visible = false;
            // 
            // NOMBRECTS
            // 
            this.NOMBRECTS.DataPropertyName = "NOMBRECTS";
            this.NOMBRECTS.HeaderText = "NOMBRECTS";
            this.NOMBRECTS.Name = "NOMBRECTS";
            this.NOMBRECTS.Visible = false;
            // 
            // CONSTANCIA
            // 
            this.CONSTANCIA.DataPropertyName = "CONSTANCIA";
            this.CONSTANCIA.HeaderText = "CONSTANCIA";
            this.CONSTANCIA.Name = "CONSTANCIA";
            this.CONSTANCIA.Visible = false;
            // 
            // NOMBRECONSTANCIA
            // 
            this.NOMBRECONSTANCIA.DataPropertyName = "NOMBRECONSTANCIA";
            this.NOMBRECONSTANCIA.HeaderText = "NOMBRECONSTANCIA";
            this.NOMBRECONSTANCIA.Name = "NOMBRECONSTANCIA";
            this.NOMBRECONSTANCIA.Visible = false;
            // 
            // RENTA
            // 
            this.RENTA.DataPropertyName = "RENTA";
            this.RENTA.HeaderText = "RENTA";
            this.RENTA.Name = "RENTA";
            this.RENTA.Visible = false;
            // 
            // NOMBRERENTA
            // 
            this.NOMBRERENTA.DataPropertyName = "NOMBRERENTA";
            this.NOMBRERENTA.HeaderText = "NOMBRERENTA";
            this.NOMBRERENTA.Name = "NOMBRERENTA";
            this.NOMBRERENTA.Visible = false;
            // 
            // PRACTICAS
            // 
            this.PRACTICAS.DataPropertyName = "PRACTICAS";
            this.PRACTICAS.HeaderText = "PRACTICAS";
            this.PRACTICAS.Name = "PRACTICAS";
            this.PRACTICAS.Visible = false;
            // 
            // NOMBREPRACTICAS
            // 
            this.NOMBREPRACTICAS.DataPropertyName = "NOMBREPRACTICAS";
            this.NOMBREPRACTICAS.HeaderText = "NOMBREPRACTICAS";
            this.NOMBREPRACTICAS.Name = "NOMBREPRACTICAS";
            this.NOMBREPRACTICAS.Visible = false;
            // 
            // SALIDA
            // 
            this.SALIDA.DataPropertyName = "SALIDA";
            this.SALIDA.HeaderText = "SALIDA";
            this.SALIDA.Name = "SALIDA";
            this.SALIDA.Visible = false;
            // 
            // NOMBRESALIDA
            // 
            this.NOMBRESALIDA.DataPropertyName = "NOMBRESALIDA";
            this.NOMBRESALIDA.HeaderText = "NOMBRESALIDA";
            this.NOMBRESALIDA.Name = "NOMBRESALIDA";
            this.NOMBRESALIDA.Visible = false;
            // 
            // txttipoid
            // 
            this.txttipoid.BackColor = System.Drawing.Color.White;
            this.txttipoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipoid.Location = new System.Drawing.Point(149, 9);
            this.txttipoid.Name = "txttipoid";
            this.txttipoid.ReadOnly = true;
            this.txttipoid.Size = new System.Drawing.Size(144, 21);
            this.txttipoid.TabIndex = 152;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.White;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(149, 33);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.ReadOnly = true;
            this.txtnombre.Size = new System.Drawing.Size(337, 21);
            this.txtnombre.TabIndex = 153;
            // 
            // txtapellido
            // 
            this.txtapellido.BackColor = System.Drawing.Color.White;
            this.txtapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.Location = new System.Drawing.Point(149, 56);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.ReadOnly = true;
            this.txtapellido.Size = new System.Drawing.Size(337, 21);
            this.txtapellido.TabIndex = 154;
            // 
            // txtestado
            // 
            this.txtestado.BackColor = System.Drawing.Color.White;
            this.txtestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestado.Location = new System.Drawing.Point(149, 79);
            this.txtestado.Name = "txtestado";
            this.txtestado.ReadOnly = true;
            this.txtestado.Size = new System.Drawing.Size(337, 21);
            this.txtestado.TabIndex = 155;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 156;
            this.label1.Text = "Tipo Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 156;
            this.label2.Text = "Nombres Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 156;
            this.label3.Text = "Apellidos Empleado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 156;
            this.label4.Text = "Estado Actual Empleado:";
            // 
            // txtnroid
            // 
            this.txtnroid.BackColor = System.Drawing.Color.White;
            this.txtnroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnroid.Location = new System.Drawing.Point(299, 9);
            this.txtnroid.Name = "txtnroid";
            this.txtnroid.ReadOnly = true;
            this.txtnroid.Size = new System.Drawing.Size(187, 21);
            this.txtnroid.TabIndex = 157;
            // 
            // frmListarEmpleadosDesvinculados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 369);
            this.Controls.Add(this.txtnroid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txttipoid);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btncancelar);
            this.Name = "frmListarEmpleadosDesvinculados";
            this.Nombre = "Empleados Desvinculados";
            this.Text = "Empleados Desvinculados";
            this.Load += new System.EventHandler(this.frmListarEmpleadosDesvinculados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private Dtgconten dtgconten;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NROID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIQUIDACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRELIQUIDACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRECTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONSTANCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRECONSTANCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRERENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRACTICAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREPRACTICAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRESALIDA;
        private System.Windows.Forms.TextBox txttipoid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnroid;
    }
}