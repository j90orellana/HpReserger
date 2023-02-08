namespace HPReserger
{
    partial class frmDetalleNroOp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleNroOp));
            this.txtnrobanco = new HpResergerUserControls.TextBoxPer();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtrazon = new HpResergerUserControls.TextBoxPer();
            this.label5 = new System.Windows.Forms.Label();
            this.txtruc = new HpResergerUserControls.TextBoxPer();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbanco = new HpResergerUserControls.TextBoxPer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnrocomp = new HpResergerUserControls.TextBoxPer();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnrobanco
            // 
            this.txtnrobanco.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtnrobanco.BackColor = System.Drawing.Color.White;
            this.txtnrobanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnrobanco.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtnrobanco.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtnrobanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnrobanco.ForeColor = System.Drawing.Color.Black;
            this.txtnrobanco.Format = null;
            this.txtnrobanco.Location = new System.Drawing.Point(117, 62);
            this.txtnrobanco.MaxLength = 20;
            this.txtnrobanco.Name = "txtnrobanco";
            this.txtnrobanco.NextControlOnEnter = this.btnaceptar;
            this.txtnrobanco.Size = new System.Drawing.Size(192, 21);
            this.txtnrobanco.TabIndex = 1;
            this.txtnrobanco.Text = "Ingrese Nro Op Bancaria";
            this.txtnrobanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnrobanco.TextoDefecto = "Ingrese Nro Op Bancaria";
            this.txtnrobanco.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtnrobanco.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.Todo;
            this.txtnrobanco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnrobanco_KeyDown);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.Location = new System.Drawing.Point(250, 89);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(82, 23);
            this.btnaceptar.TabIndex = 2;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 141;
            this.label7.Text = "Nro Op. Bancaria:";
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(337, 89);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(82, 23);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtrazon
            // 
            this.txtrazon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtrazon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtrazon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrazon.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtrazon.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtrazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrazon.ForeColor = System.Drawing.Color.Black;
            this.txtrazon.Format = null;
            this.txtrazon.Location = new System.Drawing.Point(392, 11);
            this.txtrazon.MaxLength = 100;
            this.txtrazon.Name = "txtrazon";
            this.txtrazon.NextControlOnEnter = null;
            this.txtrazon.ReadOnly = true;
            this.txtrazon.Size = new System.Drawing.Size(228, 21);
            this.txtrazon.TabIndex = 143;
            this.txtrazon.Text = " ";
            this.txtrazon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtrazon.TextoDefecto = " ";
            this.txtrazon.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtrazon.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 145;
            this.label5.Text = "Razon/Cliente:";
            // 
            // txtruc
            // 
            this.txtruc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtruc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtruc.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtruc.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruc.ForeColor = System.Drawing.Color.Black;
            this.txtruc.Format = null;
            this.txtruc.Location = new System.Drawing.Point(117, 11);
            this.txtruc.MaxLength = 12;
            this.txtruc.Name = "txtruc";
            this.txtruc.NextControlOnEnter = null;
            this.txtruc.ReadOnly = true;
            this.txtruc.Size = new System.Drawing.Size(192, 21);
            this.txtruc.TabIndex = 142;
            this.txtruc.Text = " ";
            this.txtruc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtruc.TextoDefecto = " ";
            this.txtruc.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtruc.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 144;
            this.label4.Text = "NroDocumento:";
            // 
            // txtbanco
            // 
            this.txtbanco.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtbanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtbanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbanco.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtbanco.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtbanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbanco.ForeColor = System.Drawing.Color.Black;
            this.txtbanco.Format = null;
            this.txtbanco.Location = new System.Drawing.Point(392, 35);
            this.txtbanco.MaxLength = 100;
            this.txtbanco.Name = "txtbanco";
            this.txtbanco.NextControlOnEnter = null;
            this.txtbanco.ReadOnly = true;
            this.txtbanco.Size = new System.Drawing.Size(228, 21);
            this.txtbanco.TabIndex = 146;
            this.txtbanco.Text = " ";
            this.txtbanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbanco.TextoDefecto = " ";
            this.txtbanco.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtbanco.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 147;
            this.label1.Text = "Banco:";
            // 
            // txtnrocomp
            // 
            this.txtnrocomp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtnrocomp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtnrocomp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnrocomp.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtnrocomp.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtnrocomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnrocomp.ForeColor = System.Drawing.Color.Black;
            this.txtnrocomp.Format = null;
            this.txtnrocomp.Location = new System.Drawing.Point(117, 35);
            this.txtnrocomp.MaxLength = 100;
            this.txtnrocomp.Name = "txtnrocomp";
            this.txtnrocomp.NextControlOnEnter = null;
            this.txtnrocomp.ReadOnly = true;
            this.txtnrocomp.Size = new System.Drawing.Size(192, 21);
            this.txtnrocomp.TabIndex = 148;
            this.txtnrocomp.Text = " ";
            this.txtnrocomp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnrocomp.TextoDefecto = " ";
            this.txtnrocomp.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtnrocomp.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 149;
            this.label2.Text = "Nro. Comp.";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(392, 62);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(228, 20);
            this.dtpFechaPago.TabIndex = 150;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 147;
            this.label3.Text = "Fecha Pago:";
            // 
            // frmDetalleNroOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 122);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnrocomp);
            this.Controls.Add(this.txtbanco);
            this.Controls.Add(this.txtrazon);
            this.Controls.Add(this.txtruc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnrobanco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.MaximumSize = new System.Drawing.Size(667, 161);
            this.MinimumSize = new System.Drawing.Size(667, 161);
            this.Name = "frmDetalleNroOp";
            this.Nombre = "Edición de Nro de Operación";
            this.Text = "Edición de Nro de Operación";
            this.Load += new System.EventHandler(this.frmDetalleNroOp_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDetalleNroOp_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmDetalleNroOp_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private HpResergerUserControls.TextBoxPer txtnrobanco;
        private System.Windows.Forms.Label label7;
        private HpResergerUserControls.TextBoxPer txtrazon;
        private System.Windows.Forms.Label label5;
        private HpResergerUserControls.TextBoxPer txtruc;
        private System.Windows.Forms.Label label4;
        private HpResergerUserControls.TextBoxPer txtbanco;
        private System.Windows.Forms.Label label1;
        private HpResergerUserControls.TextBoxPer txtnrocomp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label label3;
    }
}