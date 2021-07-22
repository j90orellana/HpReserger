namespace HPReserger
{
    partial class frmDetraccionVentaPagoBancoNacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblguia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRuc = new HpResergerUserControls.TextBoxPer();
            this.txtnombreempresa = new HpResergerUserControls.TextBoxPer();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcodbienserv = new HpResergerUserControls.TextBoxPer();
            this.txttasaDetraccion = new HpResergerUserControls.TextBoxPer();
            this.txtcodctacte = new HpResergerUserControls.TextBoxPer();
            this.txtaño = new HpResergerUserControls.TextBoxPer();
            this.txtmes = new HpResergerUserControls.TextBoxPer();
            this.txtlote = new HpResergerUserControls.TextBoxPer();
            this.txttotalpago = new HpResergerUserControls.TextBoxPer();
            this.txtreg = new HpResergerUserControls.TextBoxPer();
            this.separadorOre1 = new HpResergerUserControls.SeparadorOre();
            this.dtgconten = new HpResergerUserControls.Dtgconten();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnGenerar = new HpResergerUserControls.ButtonPer();
            this.btncancelar = new HpResergerUserControls.ButtonPer();
            this.xempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipodoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xserie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xnumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtipoid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xrazon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFechaContable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xigv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdetraccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCod_Detraccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).BeginInit();
            this.SuspendLayout();
            // 
            // lblguia
            // 
            this.lblguia.AutoSize = true;
            this.lblguia.BackColor = System.Drawing.Color.Transparent;
            this.lblguia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguia.Location = new System.Drawing.Point(16, 16);
            this.lblguia.Name = "lblguia";
            this.lblguia.Size = new System.Drawing.Size(124, 13);
            this.lblguia.TabIndex = 94;
            this.lblguia.Text = "Detracciones - Clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Ruc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "Empresa:";
            // 
            // txtRuc
            // 
            this.txtRuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtRuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRuc.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtRuc.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuc.ForeColor = System.Drawing.Color.Black;
            this.txtRuc.Format = null;
            this.txtRuc.Location = new System.Drawing.Point(71, 35);
            this.txtRuc.MaxLength = 100;
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.NextControlOnEnter = null;
            this.txtRuc.ReadOnly = true;
            this.txtRuc.Size = new System.Drawing.Size(167, 21);
            this.txtRuc.TabIndex = 0;
            this.txtRuc.Text = "00000000";
            this.txtRuc.TextoDefecto = "00000000";
            this.txtRuc.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtRuc.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumerosConCero;
            // 
            // txtnombreempresa
            // 
            this.txtnombreempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtnombreempresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombreempresa.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtnombreempresa.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtnombreempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreempresa.ForeColor = System.Drawing.Color.Black;
            this.txtnombreempresa.Format = null;
            this.txtnombreempresa.Location = new System.Drawing.Point(71, 58);
            this.txtnombreempresa.MaxLength = 100;
            this.txtnombreempresa.Name = "txtnombreempresa";
            this.txtnombreempresa.NextControlOnEnter = null;
            this.txtnombreempresa.ReadOnly = true;
            this.txtnombreempresa.Size = new System.Drawing.Size(387, 21);
            this.txtnombreempresa.TabIndex = 1;
            this.txtnombreempresa.Text = "Nombre de la Empresa";
            this.txtnombreempresa.TextoDefecto = "Nombre de la Empresa";
            this.txtnombreempresa.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtnombreempresa.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.MayusculaCadaPalabra;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 94;
            this.label3.Text = "Cod.Bien/Serv.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(545, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "Tasa Detr.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(464, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "Cod.Cta.Cte. (Carácter 11)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(707, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 94;
            this.label6.Text = "Año:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(707, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 94;
            this.label7.Text = "Mes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(706, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 94;
            this.label8.Text = "Lote:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(804, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 94;
            this.label9.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(804, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 94;
            this.label10.Text = "Reg.";
            // 
            // txtcodbienserv
            // 
            this.txtcodbienserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtcodbienserv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodbienserv.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtcodbienserv.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtcodbienserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodbienserv.ForeColor = System.Drawing.Color.Black;
            this.txtcodbienserv.Format = "000";
            this.txtcodbienserv.Location = new System.Drawing.Point(607, 12);
            this.txtcodbienserv.MaxLength = 4;
            this.txtcodbienserv.Name = "txtcodbienserv";
            this.txtcodbienserv.NextControlOnEnter = null;
            this.txtcodbienserv.ReadOnly = true;
            this.txtcodbienserv.Size = new System.Drawing.Size(95, 21);
            this.txtcodbienserv.TabIndex = 2;
            this.txtcodbienserv.Text = "000";
            this.txtcodbienserv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcodbienserv.TextoDefecto = "000";
            this.txtcodbienserv.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtcodbienserv.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumerosConCero;
            // 
            // txttasaDetraccion
            // 
            this.txttasaDetraccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txttasaDetraccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttasaDetraccion.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txttasaDetraccion.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txttasaDetraccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttasaDetraccion.ForeColor = System.Drawing.Color.Black;
            this.txttasaDetraccion.Format = null;
            this.txttasaDetraccion.Location = new System.Drawing.Point(607, 35);
            this.txttasaDetraccion.MaxLength = 4;
            this.txttasaDetraccion.Name = "txttasaDetraccion";
            this.txttasaDetraccion.NextControlOnEnter = null;
            this.txttasaDetraccion.ReadOnly = true;
            this.txttasaDetraccion.Size = new System.Drawing.Size(95, 21);
            this.txttasaDetraccion.TabIndex = 3;
            this.txttasaDetraccion.Text = "0.00";
            this.txttasaDetraccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttasaDetraccion.TextoDefecto = "0.00";
            this.txttasaDetraccion.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txttasaDetraccion.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // txtcodctacte
            // 
            this.txtcodctacte.BackColor = System.Drawing.Color.White;
            this.txtcodctacte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodctacte.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtcodctacte.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtcodctacte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodctacte.ForeColor = System.Drawing.Color.Black;
            this.txtcodctacte.Format = "00000000000";
            this.txtcodctacte.Location = new System.Drawing.Point(607, 58);
            this.txtcodctacte.MaxLength = 11;
            this.txtcodctacte.Name = "txtcodctacte";
            this.txtcodctacte.NextControlOnEnter = null;
            this.txtcodctacte.Size = new System.Drawing.Size(95, 21);
            this.txtcodctacte.TabIndex = 4;
            this.txtcodctacte.Text = "00000000000";
            this.txtcodctacte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcodctacte.TextoDefecto = "00000000000";
            this.txtcodctacte.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtcodctacte.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            // 
            // txtaño
            // 
            this.txtaño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtaño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaño.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtaño.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaño.ForeColor = System.Drawing.Color.Black;
            this.txtaño.Format = "0000";
            this.txtaño.Location = new System.Drawing.Point(744, 12);
            this.txtaño.MaxLength = 4;
            this.txtaño.Name = "txtaño";
            this.txtaño.NextControlOnEnter = null;
            this.txtaño.ReadOnly = true;
            this.txtaño.Size = new System.Drawing.Size(54, 21);
            this.txtaño.TabIndex = 5;
            this.txtaño.Text = "2000";
            this.txtaño.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtaño.TextoDefecto = "2000";
            this.txtaño.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtaño.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            // 
            // txtmes
            // 
            this.txtmes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtmes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmes.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtmes.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmes.ForeColor = System.Drawing.Color.Black;
            this.txtmes.Format = "00";
            this.txtmes.Location = new System.Drawing.Point(744, 35);
            this.txtmes.MaxLength = 2;
            this.txtmes.Name = "txtmes";
            this.txtmes.NextControlOnEnter = null;
            this.txtmes.ReadOnly = true;
            this.txtmes.Size = new System.Drawing.Size(54, 21);
            this.txtmes.TabIndex = 6;
            this.txtmes.Text = "01";
            this.txtmes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtmes.TextoDefecto = "01";
            this.txtmes.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtmes.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            // 
            // txtlote
            // 
            this.txtlote.BackColor = System.Drawing.Color.White;
            this.txtlote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlote.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtlote.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtlote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlote.ForeColor = System.Drawing.Color.Black;
            this.txtlote.Format = "0000";
            this.txtlote.Location = new System.Drawing.Point(744, 58);
            this.txtlote.MaxLength = 6;
            this.txtlote.Name = "txtlote";
            this.txtlote.NextControlOnEnter = null;
            this.txtlote.Size = new System.Drawing.Size(54, 21);
            this.txtlote.TabIndex = 7;
            this.txtlote.Text = "AANNNN";
            this.txtlote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtlote.TextoDefecto = "AANNNN";
            this.txtlote.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtlote.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            this.toolTip1.SetToolTip(this.txtlote, "AA = Año\r\nNNNN= Secuencia");
            // 
            // txttotalpago
            // 
            this.txttotalpago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txttotalpago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalpago.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txttotalpago.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txttotalpago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpago.ForeColor = System.Drawing.Color.Black;
            this.txttotalpago.Format = "n2";
            this.txttotalpago.Location = new System.Drawing.Point(841, 58);
            this.txttotalpago.MaxLength = 4;
            this.txttotalpago.Name = "txttotalpago";
            this.txttotalpago.NextControlOnEnter = null;
            this.txttotalpago.ReadOnly = true;
            this.txttotalpago.Size = new System.Drawing.Size(85, 21);
            this.txttotalpago.TabIndex = 9;
            this.txttotalpago.Text = "0.00";
            this.txttotalpago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttotalpago.TextoDefecto = "0.00";
            this.txttotalpago.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txttotalpago.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloDinero;
            // 
            // txtreg
            // 
            this.txtreg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(231)))));
            this.txtreg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtreg.ColorFondoMouseEncima = System.Drawing.Color.Empty;
            this.txtreg.ColorFondoMousePresionado = System.Drawing.Color.Empty;
            this.txtreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreg.ForeColor = System.Drawing.Color.Black;
            this.txtreg.Format = null;
            this.txtreg.Location = new System.Drawing.Point(882, 35);
            this.txtreg.MaxLength = 2;
            this.txtreg.Name = "txtreg";
            this.txtreg.NextControlOnEnter = null;
            this.txtreg.ReadOnly = true;
            this.txtreg.Size = new System.Drawing.Size(44, 21);
            this.txtreg.TabIndex = 8;
            this.txtreg.Text = "00";
            this.txtreg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtreg.TextoDefecto = "00";
            this.txtreg.TextoDefectoColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(129)))), ((int)(((byte)(189)))));
            this.txtreg.TiposDatos = HpResergerUserControls.TextBoxPer.ListaTipos.SoloNumeros;
            // 
            // separadorOre1
            // 
            this.separadorOre1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separadorOre1.BackColor = System.Drawing.Color.Transparent;
            this.separadorOre1.Location = new System.Drawing.Point(0, 82);
            this.separadorOre1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separadorOre1.MinimumSize = new System.Drawing.Size(0, 2);
            this.separadorOre1.Name = "separadorOre1";
            this.separadorOre1.Size = new System.Drawing.Size(1099, 2);
            this.separadorOre1.TabIndex = 95;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgconten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgconten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgconten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xempresa,
            this.xtipodoc,
            this.xserie,
            this.xnumero,
            this.xFechaEmision,
            this.xtipoid,
            this.xruc,
            this.xrazon,
            this.xmoneda,
            this.xtc,
            this.xFechaContable,
            this.xigv,
            this.xtotal,
            this.xdetraccion,
            this.xCod_Detraccion,
            this.xPorcentaje});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(207)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgconten.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgconten.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgconten.EnableHeadersVisualStyles = false;
            this.dtgconten.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(179)))), ((int)(((byte)(215)))));
            this.dtgconten.Location = new System.Drawing.Point(10, 90);
            this.dtgconten.Name = "dtgconten";
            this.dtgconten.ReadOnly = true;
            this.dtgconten.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgconten.RowHeadersVisible = false;
            this.dtgconten.RowTemplate.Height = 18;
            this.dtgconten.Size = new System.Drawing.Size(1075, 402);
            this.dtgconten.TabIndex = 96;
            this.dtgconten.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgconten_DataError);
            this.dtgconten.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgconten_RowEnter);
            // 
            // lblmensaje
            // 
            this.lblmensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblmensaje.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(10, 502);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(129, 13);
            this.lblmensaje.TabIndex = 99;
            this.lblmensaje.Text = "Número de Registros=0";
            // 
            // SaveFile
            // 
            this.SaveFile.Filter = "Archivos de Texto|*.txt";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(911, 497);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(85, 23);
            this.btnGenerar.TabIndex = 100;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Crimson;
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(1000, 497);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(85, 23);
            this.btncancelar.TabIndex = 101;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // xempresa
            // 
            this.xempresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xempresa.DataPropertyName = "empresa";
            this.xempresa.HeaderText = "Empresa";
            this.xempresa.MinimumWidth = 150;
            this.xempresa.Name = "xempresa";
            this.xempresa.ReadOnly = true;
            this.xempresa.Width = 150;
            // 
            // xtipodoc
            // 
            this.xtipodoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xtipodoc.DataPropertyName = "idComprobanteSunat";
            this.xtipodoc.HeaderText = "T. Doc.";
            this.xtipodoc.Name = "xtipodoc";
            this.xtipodoc.ReadOnly = true;
            this.xtipodoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xtipodoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xtipodoc.Width = 67;
            // 
            // xserie
            // 
            this.xserie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xserie.DataPropertyName = "NroFactura";
            this.xserie.HeaderText = "Serie";
            this.xserie.Name = "xserie";
            this.xserie.ReadOnly = true;
            this.xserie.Width = 56;
            // 
            // xnumero
            // 
            this.xnumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xnumero.DataPropertyName = "numero";
            this.xnumero.HeaderText = "Número";
            this.xnumero.Name = "xnumero";
            this.xnumero.ReadOnly = true;
            this.xnumero.Width = 75;
            // 
            // xFechaEmision
            // 
            this.xFechaEmision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xFechaEmision.DataPropertyName = "fechaemision";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.xFechaEmision.DefaultCellStyle = dataGridViewCellStyle3;
            this.xFechaEmision.HeaderText = "Fec. Doc";
            this.xFechaEmision.MinimumWidth = 65;
            this.xFechaEmision.Name = "xFechaEmision";
            this.xFechaEmision.ReadOnly = true;
            this.xFechaEmision.Width = 65;
            // 
            // xtipoid
            // 
            this.xtipoid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xtipoid.DataPropertyName = "tipoid";
            this.xtipoid.HeaderText = "Tipo";
            this.xtipoid.Name = "xtipoid";
            this.xtipoid.ReadOnly = true;
            this.xtipoid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xtipoid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xtipoid.Width = 54;
            // 
            // xruc
            // 
            this.xruc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xruc.DataPropertyName = "nroid";
            this.xruc.HeaderText = "Ruc Cliente";
            this.xruc.Name = "xruc";
            this.xruc.ReadOnly = true;
            this.xruc.Width = 84;
            // 
            // xrazon
            // 
            this.xrazon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xrazon.DataPropertyName = "nombre";
            this.xrazon.HeaderText = "Razón Social";
            this.xrazon.MinimumWidth = 150;
            this.xrazon.Name = "xrazon";
            this.xrazon.ReadOnly = true;
            // 
            // xmoneda
            // 
            this.xmoneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xmoneda.DataPropertyName = "namecorto";
            this.xmoneda.HeaderText = "Moneda";
            this.xmoneda.Name = "xmoneda";
            this.xmoneda.ReadOnly = true;
            this.xmoneda.Width = 75;
            // 
            // xtc
            // 
            this.xtc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xtc.DataPropertyName = "tc";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "n3";
            this.xtc.DefaultCellStyle = dataGridViewCellStyle4;
            this.xtc.HeaderText = "T.C.";
            this.xtc.Name = "xtc";
            this.xtc.ReadOnly = true;
            this.xtc.Width = 51;
            // 
            // xFechaContable
            // 
            this.xFechaContable.DataPropertyName = "FechaContable";
            this.xFechaContable.HeaderText = "FechaContable";
            this.xFechaContable.Name = "xFechaContable";
            this.xFechaContable.ReadOnly = true;
            this.xFechaContable.Visible = false;
            // 
            // xigv
            // 
            this.xigv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xigv.DataPropertyName = "igv";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "n2";
            this.xigv.DefaultCellStyle = dataGridViewCellStyle5;
            this.xigv.HeaderText = "IGV";
            this.xigv.Name = "xigv";
            this.xigv.ReadOnly = true;
            this.xigv.Width = 49;
            // 
            // xtotal
            // 
            this.xtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xtotal.DataPropertyName = "total";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "n2";
            this.xtotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.xtotal.HeaderText = "Total";
            this.xtotal.Name = "xtotal";
            this.xtotal.ReadOnly = true;
            this.xtotal.Width = 56;
            // 
            // xdetraccion
            // 
            this.xdetraccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xdetraccion.DataPropertyName = "redondeo";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "n2";
            this.xdetraccion.DefaultCellStyle = dataGridViewCellStyle7;
            this.xdetraccion.HeaderText = "Detrac.";
            this.xdetraccion.Name = "xdetraccion";
            this.xdetraccion.ReadOnly = true;
            this.xdetraccion.Width = 68;
            // 
            // xCod_Detraccion
            // 
            this.xCod_Detraccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.xCod_Detraccion.DataPropertyName = "Cod_Detraccion";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.xCod_Detraccion.DefaultCellStyle = dataGridViewCellStyle8;
            this.xCod_Detraccion.HeaderText = "Cod.Bien Serv";
            this.xCod_Detraccion.MinimumWidth = 70;
            this.xCod_Detraccion.Name = "xCod_Detraccion";
            this.xCod_Detraccion.ReadOnly = true;
            this.xCod_Detraccion.Visible = false;
            this.xCod_Detraccion.Width = 70;
            // 
            // xPorcentaje
            // 
            this.xPorcentaje.DataPropertyName = "Porcentaje";
            this.xPorcentaje.HeaderText = "Porcentaje";
            this.xPorcentaje.Name = "xPorcentaje";
            this.xPorcentaje.ReadOnly = true;
            this.xPorcentaje.Visible = false;
            // 
            // frmDetraccionVentaPagoBancoNacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 528);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.dtgconten);
            this.Controls.Add(this.separadorOre1);
            this.Controls.Add(this.txtnombreempresa);
            this.Controls.Add(this.txttotalpago);
            this.Controls.Add(this.txtlote);
            this.Controls.Add(this.txtreg);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.txtaño);
            this.Controls.Add(this.txtcodctacte);
            this.Controls.Add(this.txttasaDetraccion);
            this.Controls.Add(this.txtcodbienserv);
            this.Controls.Add(this.txtRuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblguia);
            this.MinimumSize = new System.Drawing.Size(1113, 567);
            this.Name = "frmDetraccionVentaPagoBancoNacion";
            this.Nombre = "Generación del TXT de Pago de Detracciones de Venta";
            this.Text = "Generación del TXT de Pago de Detracciones de Venta";
            this.Load += new System.EventHandler(this.frmDetraccionVentaPagoBancoNacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgconten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblguia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private HpResergerUserControls.TextBoxPer txtRuc;
        private HpResergerUserControls.TextBoxPer txtnombreempresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private HpResergerUserControls.TextBoxPer txtcodbienserv;
        private HpResergerUserControls.TextBoxPer txttasaDetraccion;
        private HpResergerUserControls.TextBoxPer txtcodctacte;
        private HpResergerUserControls.TextBoxPer txtaño;
        private HpResergerUserControls.TextBoxPer txtmes;
        private HpResergerUserControls.TextBoxPer txtlote;
        private HpResergerUserControls.TextBoxPer txttotalpago;
        private HpResergerUserControls.TextBoxPer txtreg;
        private HpResergerUserControls.SeparadorOre separadorOre1;
        private HpResergerUserControls.Dtgconten dtgconten;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.ToolTip toolTip1;
        private HpResergerUserControls.ButtonPer btnGenerar;
        private HpResergerUserControls.ButtonPer btncancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn xempresa;
        private System.Windows.Forms.DataGridViewComboBoxColumn xtipodoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xserie;
        private System.Windows.Forms.DataGridViewTextBoxColumn xnumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaEmision;
        private System.Windows.Forms.DataGridViewComboBoxColumn xtipoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn xruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xrazon;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtc;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFechaContable;
        private System.Windows.Forms.DataGridViewTextBoxColumn xigv;
        private System.Windows.Forms.DataGridViewTextBoxColumn xtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdetraccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCod_Detraccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPorcentaje;
    }
}