namespace HPReserger
{
    partial class frmCotizacionModificar
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdjunto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscarPDF = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCotizacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(328, 65);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Modificar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProveedor);
            this.groupBox1.Controls.Add(this.txtRUC);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAdjunto);
            this.groupBox1.Controls.Add(this.btnBuscarPDF);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtImporte);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 168);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(138, 32);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(428, 20);
            this.txtProveedor.TabIndex = 28;
            this.txtProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(9, 32);
            this.txtRUC.MaxLength = 11;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(110, 20);
            this.txtRUC.TabIndex = 27;
            this.txtRUC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRUC.TextChanged += new System.EventHandler(this.txtRUC_TextChanged);
            this.txtRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUC_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "R.U.C.";
            // 
            // txtAdjunto
            // 
            this.txtAdjunto.Location = new System.Drawing.Point(9, 135);
            this.txtAdjunto.Name = "txtAdjunto";
            this.txtAdjunto.ReadOnly = true;
            this.txtAdjunto.Size = new System.Drawing.Size(536, 20);
            this.txtAdjunto.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Adjuntar archivo";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(138, 81);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(102, 20);
            this.dtpFecha.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(135, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Fecha de Entrega";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(9, 81);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(58, 20);
            this.txtImporte.TabIndex = 19;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Importe";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(135, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Proveedor";
            // 
            // btnBuscarPDF
            // 
            this.btnBuscarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPDF.Location = new System.Drawing.Point(551, 135);
            this.btnBuscarPDF.Name = "btnBuscarPDF";
            this.btnBuscarPDF.Size = new System.Drawing.Size(25, 23);
            this.btnBuscarPDF.TabIndex = 24;
            this.btnBuscarPDF.Text = "...";
            this.btnBuscarPDF.UseVisualStyleBackColor = true;
            this.btnBuscarPDF.Click += new System.EventHandler(this.btnBuscarPDF_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPedido);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCotizacion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 86);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // txtPedido
            // 
            this.txtPedido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedido.Location = new System.Drawing.Point(109, 53);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.ReadOnly = true;
            this.txtPedido.Size = new System.Drawing.Size(77, 20);
            this.txtPedido.TabIndex = 33;
            this.txtPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nº Pedido";
            // 
            // txtCotizacion
            // 
            this.txtCotizacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotizacion.Location = new System.Drawing.Point(109, 19);
            this.txtCotizacion.Name = "txtCotizacion";
            this.txtCotizacion.ReadOnly = true;
            this.txtCotizacion.Size = new System.Drawing.Size(77, 20);
            this.txtCotizacion.TabIndex = 32;
            this.txtCotizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nº Cotización";
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(612, 2);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(335, 351);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 28;
            this.pbFoto.TabStop = false;
            // 
            // frmCotizacionModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(959, 365);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAceptar);
            this.MaximizeBox = false;
            this.Name = "frmCotizacionModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Modificar Cotización";
            this.Load += new System.EventHandler(this.frmCotizacionModificar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscarPDF;
        private System.Windows.Forms.TextBox txtAdjunto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.TextBox txtCotizacion;
        private System.Windows.Forms.PictureBox pbFoto;
    }
}