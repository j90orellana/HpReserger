using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using HpResergerNube;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace SISGEM.CRM
{
    partial class frmAddProducto
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProducto));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ID_ProductoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Detalle_ProductoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MarcaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ModeloTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TipoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UsoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Detalle_1TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Detalle_2TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Detalle_3TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Detalle_4TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Detalle_5TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Detalle_6TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Detalle_7TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Detalle_8TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FotosTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ArchivoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Precio_1TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Precio_2TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Precio_3TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ID_MonedaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UsuarioTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FechaDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ImagenPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForID_Producto = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDetalle_Producto = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMarca = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTipo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDetalle_1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDetalle_2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDetalle_3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDetalle_4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDetalle_7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDetalle_8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFotos = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForArchivo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPrecio_1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPrecio_2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPrecio_3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForID_Moneda = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFecha = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForImagen = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForModelo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUso = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDetalle_5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDetalle_6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.btnCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ID_ProductoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_ProductoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeloTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_1TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_2TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_3TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_4TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_5TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_6TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_7TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_8TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotosTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArchivoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precio_1TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precio_2TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precio_3TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_MonedaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDetalle_Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDetalle_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDetalle_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDetalle_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDetalle_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDetalle_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDetalle_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForArchivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrecio_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrecio_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrecio_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_Moneda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDetalle_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDetalle_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.ID_ProductoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Detalle_ProductoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MarcaTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ModeloTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TipoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UsoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Detalle_1TextEdit);
            this.dataLayoutControl1.Controls.Add(this.Detalle_2TextEdit);
            this.dataLayoutControl1.Controls.Add(this.Detalle_3TextEdit);
            this.dataLayoutControl1.Controls.Add(this.Detalle_4TextEdit);
            this.dataLayoutControl1.Controls.Add(this.Detalle_5TextEdit);
            this.dataLayoutControl1.Controls.Add(this.Detalle_6TextEdit);
            this.dataLayoutControl1.Controls.Add(this.Detalle_7TextEdit);
            this.dataLayoutControl1.Controls.Add(this.Detalle_8TextEdit);
            this.dataLayoutControl1.Controls.Add(this.FotosTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ArchivoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Precio_1TextEdit);
            this.dataLayoutControl1.Controls.Add(this.Precio_2TextEdit);
            this.dataLayoutControl1.Controls.Add(this.Precio_3TextEdit);
            this.dataLayoutControl1.Controls.Add(this.ID_MonedaTextEdit);
            this.dataLayoutControl1.Controls.Add(this.UsuarioTextEdit);
            this.dataLayoutControl1.Controls.Add(this.FechaDateEdit);
            this.dataLayoutControl1.Controls.Add(this.ImagenPictureEdit);
            this.dataLayoutControl1.DataSource = this.productoBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 24);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(908, 535);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // ID_ProductoTextEdit
            // 
            this.ID_ProductoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "ID_Producto", true));
            this.ID_ProductoTextEdit.Location = new System.Drawing.Point(60, 12);
            this.ID_ProductoTextEdit.Name = "ID_ProductoTextEdit";
            this.ID_ProductoTextEdit.Properties.ReadOnly = true;
            this.ID_ProductoTextEdit.Size = new System.Drawing.Size(589, 20);
            this.ID_ProductoTextEdit.StyleController = this.dataLayoutControl1;
            this.ID_ProductoTextEdit.TabIndex = 4;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(HpResergerNube.CRM_ProductoRepository.Producto);
            // 
            // Detalle_ProductoTextEdit
            // 
            this.Detalle_ProductoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Detalle_Producto", true));
            this.Detalle_ProductoTextEdit.Location = new System.Drawing.Point(60, 36);
            this.Detalle_ProductoTextEdit.Name = "Detalle_ProductoTextEdit";
            this.Detalle_ProductoTextEdit.Size = new System.Drawing.Size(589, 20);
            this.Detalle_ProductoTextEdit.StyleController = this.dataLayoutControl1;
            this.Detalle_ProductoTextEdit.TabIndex = 5;
            // 
            // MarcaTextEdit
            // 
            this.MarcaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Marca", true));
            this.MarcaTextEdit.Location = new System.Drawing.Point(60, 60);
            this.MarcaTextEdit.Name = "MarcaTextEdit";
            this.MarcaTextEdit.Size = new System.Drawing.Size(268, 20);
            this.MarcaTextEdit.StyleController = this.dataLayoutControl1;
            this.MarcaTextEdit.TabIndex = 6;
            // 
            // ModeloTextEdit
            // 
            this.ModeloTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Modelo", true));
            this.ModeloTextEdit.Location = new System.Drawing.Point(380, 60);
            this.ModeloTextEdit.Name = "ModeloTextEdit";
            this.ModeloTextEdit.Size = new System.Drawing.Size(269, 20);
            this.ModeloTextEdit.StyleController = this.dataLayoutControl1;
            this.ModeloTextEdit.TabIndex = 7;
            // 
            // TipoTextEdit
            // 
            this.TipoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Tipo", true));
            this.TipoTextEdit.Location = new System.Drawing.Point(60, 84);
            this.TipoTextEdit.Name = "TipoTextEdit";
            this.TipoTextEdit.Size = new System.Drawing.Size(268, 20);
            this.TipoTextEdit.StyleController = this.dataLayoutControl1;
            this.TipoTextEdit.TabIndex = 8;
            // 
            // UsoTextEdit
            // 
            this.UsoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Uso", true));
            this.UsoTextEdit.Location = new System.Drawing.Point(380, 84);
            this.UsoTextEdit.Name = "UsoTextEdit";
            this.UsoTextEdit.Size = new System.Drawing.Size(269, 20);
            this.UsoTextEdit.StyleController = this.dataLayoutControl1;
            this.UsoTextEdit.TabIndex = 9;
            // 
            // Detalle_1TextEdit
            // 
            this.Detalle_1TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Detalle_1", true));
            this.Detalle_1TextEdit.Location = new System.Drawing.Point(60, 108);
            this.Detalle_1TextEdit.Name = "Detalle_1TextEdit";
            this.Detalle_1TextEdit.Size = new System.Drawing.Size(589, 20);
            this.Detalle_1TextEdit.StyleController = this.dataLayoutControl1;
            this.Detalle_1TextEdit.TabIndex = 10;
            // 
            // Detalle_2TextEdit
            // 
            this.Detalle_2TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Detalle_2", true));
            this.Detalle_2TextEdit.Location = new System.Drawing.Point(60, 132);
            this.Detalle_2TextEdit.Name = "Detalle_2TextEdit";
            this.Detalle_2TextEdit.Size = new System.Drawing.Size(589, 20);
            this.Detalle_2TextEdit.StyleController = this.dataLayoutControl1;
            this.Detalle_2TextEdit.TabIndex = 11;
            // 
            // Detalle_3TextEdit
            // 
            this.Detalle_3TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Detalle_3", true));
            this.Detalle_3TextEdit.Location = new System.Drawing.Point(60, 156);
            this.Detalle_3TextEdit.Name = "Detalle_3TextEdit";
            this.Detalle_3TextEdit.Size = new System.Drawing.Size(589, 20);
            this.Detalle_3TextEdit.StyleController = this.dataLayoutControl1;
            this.Detalle_3TextEdit.TabIndex = 12;
            // 
            // Detalle_4TextEdit
            // 
            this.Detalle_4TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Detalle_4", true));
            this.Detalle_4TextEdit.Location = new System.Drawing.Point(60, 180);
            this.Detalle_4TextEdit.Name = "Detalle_4TextEdit";
            this.Detalle_4TextEdit.Size = new System.Drawing.Size(589, 20);
            this.Detalle_4TextEdit.StyleController = this.dataLayoutControl1;
            this.Detalle_4TextEdit.TabIndex = 13;
            // 
            // Detalle_5TextEdit
            // 
            this.Detalle_5TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Detalle_5", true));
            this.Detalle_5TextEdit.Location = new System.Drawing.Point(60, 204);
            this.Detalle_5TextEdit.Name = "Detalle_5TextEdit";
            this.Detalle_5TextEdit.Size = new System.Drawing.Size(589, 20);
            this.Detalle_5TextEdit.StyleController = this.dataLayoutControl1;
            this.Detalle_5TextEdit.TabIndex = 14;
            // 
            // Detalle_6TextEdit
            // 
            this.Detalle_6TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Detalle_6", true));
            this.Detalle_6TextEdit.Location = new System.Drawing.Point(60, 228);
            this.Detalle_6TextEdit.Name = "Detalle_6TextEdit";
            this.Detalle_6TextEdit.Size = new System.Drawing.Size(589, 20);
            this.Detalle_6TextEdit.StyleController = this.dataLayoutControl1;
            this.Detalle_6TextEdit.TabIndex = 15;
            // 
            // Detalle_7TextEdit
            // 
            this.Detalle_7TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Detalle_7", true));
            this.Detalle_7TextEdit.Location = new System.Drawing.Point(60, 252);
            this.Detalle_7TextEdit.Name = "Detalle_7TextEdit";
            this.Detalle_7TextEdit.Size = new System.Drawing.Size(836, 20);
            this.Detalle_7TextEdit.StyleController = this.dataLayoutControl1;
            this.Detalle_7TextEdit.TabIndex = 16;
            // 
            // Detalle_8TextEdit
            // 
            this.Detalle_8TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Detalle_8", true));
            this.Detalle_8TextEdit.Location = new System.Drawing.Point(60, 276);
            this.Detalle_8TextEdit.Name = "Detalle_8TextEdit";
            this.Detalle_8TextEdit.Size = new System.Drawing.Size(836, 20);
            this.Detalle_8TextEdit.StyleController = this.dataLayoutControl1;
            this.Detalle_8TextEdit.TabIndex = 17;
            // 
            // FotosTextEdit
            // 
            this.FotosTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Fotos", true));
            this.FotosTextEdit.Location = new System.Drawing.Point(60, 300);
            this.FotosTextEdit.Name = "FotosTextEdit";
            this.FotosTextEdit.Size = new System.Drawing.Size(836, 20);
            this.FotosTextEdit.StyleController = this.dataLayoutControl1;
            this.FotosTextEdit.TabIndex = 18;
            // 
            // ArchivoTextEdit
            // 
            this.ArchivoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Archivo", true));
            this.ArchivoTextEdit.Location = new System.Drawing.Point(60, 324);
            this.ArchivoTextEdit.Name = "ArchivoTextEdit";
            this.ArchivoTextEdit.Size = new System.Drawing.Size(836, 20);
            this.ArchivoTextEdit.StyleController = this.dataLayoutControl1;
            this.ArchivoTextEdit.TabIndex = 19;
            // 
            // Precio_1TextEdit
            // 
            this.Precio_1TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Precio_1", true));
            this.Precio_1TextEdit.Location = new System.Drawing.Point(60, 348);
            this.Precio_1TextEdit.Name = "Precio_1TextEdit";
            this.Precio_1TextEdit.Size = new System.Drawing.Size(836, 20);
            this.Precio_1TextEdit.StyleController = this.dataLayoutControl1;
            this.Precio_1TextEdit.TabIndex = 20;
            // 
            // Precio_2TextEdit
            // 
            this.Precio_2TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Precio_2", true));
            this.Precio_2TextEdit.Location = new System.Drawing.Point(60, 372);
            this.Precio_2TextEdit.Name = "Precio_2TextEdit";
            this.Precio_2TextEdit.Size = new System.Drawing.Size(836, 20);
            this.Precio_2TextEdit.StyleController = this.dataLayoutControl1;
            this.Precio_2TextEdit.TabIndex = 21;
            // 
            // Precio_3TextEdit
            // 
            this.Precio_3TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Precio_3", true));
            this.Precio_3TextEdit.Location = new System.Drawing.Point(60, 396);
            this.Precio_3TextEdit.Name = "Precio_3TextEdit";
            this.Precio_3TextEdit.Size = new System.Drawing.Size(836, 20);
            this.Precio_3TextEdit.StyleController = this.dataLayoutControl1;
            this.Precio_3TextEdit.TabIndex = 22;
            // 
            // ID_MonedaTextEdit
            // 
            this.ID_MonedaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "ID_Moneda", true));
            this.ID_MonedaTextEdit.Location = new System.Drawing.Point(60, 420);
            this.ID_MonedaTextEdit.Name = "ID_MonedaTextEdit";
            this.ID_MonedaTextEdit.Size = new System.Drawing.Size(836, 20);
            this.ID_MonedaTextEdit.StyleController = this.dataLayoutControl1;
            this.ID_MonedaTextEdit.TabIndex = 23;
            // 
            // UsuarioTextEdit
            // 
            this.UsuarioTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Usuario", true));
            this.UsuarioTextEdit.Location = new System.Drawing.Point(60, 444);
            this.UsuarioTextEdit.Name = "UsuarioTextEdit";
            this.UsuarioTextEdit.Size = new System.Drawing.Size(836, 20);
            this.UsuarioTextEdit.StyleController = this.dataLayoutControl1;
            this.UsuarioTextEdit.TabIndex = 24;
            // 
            // FechaDateEdit
            // 
            this.FechaDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Fecha", true));
            this.FechaDateEdit.EditValue = null;
            this.FechaDateEdit.Location = new System.Drawing.Point(60, 468);
            this.FechaDateEdit.Name = "FechaDateEdit";
            this.FechaDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.FechaDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FechaDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FechaDateEdit.Size = new System.Drawing.Size(836, 20);
            this.FechaDateEdit.StyleController = this.dataLayoutControl1;
            this.FechaDateEdit.TabIndex = 25;
            // 
            // ImagenPictureEdit
            // 
            this.ImagenPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productoBindingSource, "Imagen", true));
            this.ImagenPictureEdit.Location = new System.Drawing.Point(653, 12);
            this.ImagenPictureEdit.Name = "ImagenPictureEdit";
            this.ImagenPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImagenPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.ImagenPictureEdit.Size = new System.Drawing.Size(243, 236);
            this.ImagenPictureEdit.StyleController = this.dataLayoutControl1;
            this.ImagenPictureEdit.TabIndex = 26;
            this.ImagenPictureEdit.DoubleClick += new System.EventHandler(this.ImagenPictureEdit_DoubleClick);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(908, 535);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForID_Producto,
            this.ItemForDetalle_Producto,
            this.ItemForMarca,
            this.ItemForTipo,
            this.ItemForDetalle_1,
            this.ItemForDetalle_2,
            this.ItemForDetalle_3,
            this.ItemForDetalle_4,
            this.ItemForDetalle_7,
            this.ItemForDetalle_8,
            this.ItemForFotos,
            this.ItemForArchivo,
            this.ItemForPrecio_1,
            this.ItemForPrecio_2,
            this.ItemForPrecio_3,
            this.ItemForID_Moneda,
            this.ItemForUsuario,
            this.ItemForFecha,
            this.ItemForImagen,
            this.ItemForModelo,
            this.ItemForUso,
            this.ItemForDetalle_5,
            this.ItemForDetalle_6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(888, 515);
            // 
            // ItemForID_Producto
            // 
            this.ItemForID_Producto.Control = this.ID_ProductoTextEdit;
            this.ItemForID_Producto.Location = new System.Drawing.Point(0, 0);
            this.ItemForID_Producto.Name = "ItemForID_Producto";
            this.ItemForID_Producto.Size = new System.Drawing.Size(641, 24);
            this.ItemForID_Producto.Text = "ID";
            this.ItemForID_Producto.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForDetalle_Producto
            // 
            this.ItemForDetalle_Producto.Control = this.Detalle_ProductoTextEdit;
            this.ItemForDetalle_Producto.Location = new System.Drawing.Point(0, 24);
            this.ItemForDetalle_Producto.Name = "ItemForDetalle_Producto";
            this.ItemForDetalle_Producto.Size = new System.Drawing.Size(641, 24);
            this.ItemForDetalle_Producto.Text = "Detalle";
            this.ItemForDetalle_Producto.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForMarca
            // 
            this.ItemForMarca.Control = this.MarcaTextEdit;
            this.ItemForMarca.Location = new System.Drawing.Point(0, 48);
            this.ItemForMarca.Name = "ItemForMarca";
            this.ItemForMarca.Size = new System.Drawing.Size(320, 24);
            this.ItemForMarca.Text = "Marca";
            this.ItemForMarca.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForTipo
            // 
            this.ItemForTipo.Control = this.TipoTextEdit;
            this.ItemForTipo.Location = new System.Drawing.Point(0, 72);
            this.ItemForTipo.Name = "ItemForTipo";
            this.ItemForTipo.Size = new System.Drawing.Size(320, 24);
            this.ItemForTipo.Text = "Tipo";
            this.ItemForTipo.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForDetalle_1
            // 
            this.ItemForDetalle_1.Control = this.Detalle_1TextEdit;
            this.ItemForDetalle_1.Location = new System.Drawing.Point(0, 96);
            this.ItemForDetalle_1.Name = "ItemForDetalle_1";
            this.ItemForDetalle_1.Size = new System.Drawing.Size(641, 24);
            this.ItemForDetalle_1.Text = "Detalle_1";
            this.ItemForDetalle_1.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForDetalle_2
            // 
            this.ItemForDetalle_2.Control = this.Detalle_2TextEdit;
            this.ItemForDetalle_2.Location = new System.Drawing.Point(0, 120);
            this.ItemForDetalle_2.Name = "ItemForDetalle_2";
            this.ItemForDetalle_2.Size = new System.Drawing.Size(641, 24);
            this.ItemForDetalle_2.Text = "Detalle_2";
            this.ItemForDetalle_2.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForDetalle_3
            // 
            this.ItemForDetalle_3.Control = this.Detalle_3TextEdit;
            this.ItemForDetalle_3.Location = new System.Drawing.Point(0, 144);
            this.ItemForDetalle_3.Name = "ItemForDetalle_3";
            this.ItemForDetalle_3.Size = new System.Drawing.Size(641, 24);
            this.ItemForDetalle_3.Text = "Detalle_3";
            this.ItemForDetalle_3.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForDetalle_4
            // 
            this.ItemForDetalle_4.Control = this.Detalle_4TextEdit;
            this.ItemForDetalle_4.Location = new System.Drawing.Point(0, 168);
            this.ItemForDetalle_4.Name = "ItemForDetalle_4";
            this.ItemForDetalle_4.Size = new System.Drawing.Size(641, 24);
            this.ItemForDetalle_4.Text = "Detalle_4";
            this.ItemForDetalle_4.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForDetalle_7
            // 
            this.ItemForDetalle_7.Control = this.Detalle_7TextEdit;
            this.ItemForDetalle_7.Location = new System.Drawing.Point(0, 240);
            this.ItemForDetalle_7.Name = "ItemForDetalle_7";
            this.ItemForDetalle_7.Size = new System.Drawing.Size(888, 24);
            this.ItemForDetalle_7.Text = "Detalle_7";
            this.ItemForDetalle_7.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForDetalle_8
            // 
            this.ItemForDetalle_8.Control = this.Detalle_8TextEdit;
            this.ItemForDetalle_8.Location = new System.Drawing.Point(0, 264);
            this.ItemForDetalle_8.Name = "ItemForDetalle_8";
            this.ItemForDetalle_8.Size = new System.Drawing.Size(888, 24);
            this.ItemForDetalle_8.Text = "Detalle_8";
            this.ItemForDetalle_8.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForFotos
            // 
            this.ItemForFotos.Control = this.FotosTextEdit;
            this.ItemForFotos.Location = new System.Drawing.Point(0, 288);
            this.ItemForFotos.Name = "ItemForFotos";
            this.ItemForFotos.Size = new System.Drawing.Size(888, 24);
            this.ItemForFotos.Text = "Fotos";
            this.ItemForFotos.TextSize = new System.Drawing.Size(45, 13);
            this.ItemForFotos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // ItemForArchivo
            // 
            this.ItemForArchivo.Control = this.ArchivoTextEdit;
            this.ItemForArchivo.Location = new System.Drawing.Point(0, 312);
            this.ItemForArchivo.Name = "ItemForArchivo";
            this.ItemForArchivo.Size = new System.Drawing.Size(888, 24);
            this.ItemForArchivo.Text = "Archivo";
            this.ItemForArchivo.TextSize = new System.Drawing.Size(45, 13);
            this.ItemForArchivo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // ItemForPrecio_1
            // 
            this.ItemForPrecio_1.Control = this.Precio_1TextEdit;
            this.ItemForPrecio_1.Location = new System.Drawing.Point(0, 336);
            this.ItemForPrecio_1.Name = "ItemForPrecio_1";
            this.ItemForPrecio_1.Size = new System.Drawing.Size(888, 24);
            this.ItemForPrecio_1.Text = "Precio_1";
            this.ItemForPrecio_1.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForPrecio_2
            // 
            this.ItemForPrecio_2.Control = this.Precio_2TextEdit;
            this.ItemForPrecio_2.Location = new System.Drawing.Point(0, 360);
            this.ItemForPrecio_2.Name = "ItemForPrecio_2";
            this.ItemForPrecio_2.Size = new System.Drawing.Size(888, 24);
            this.ItemForPrecio_2.Text = "Precio_2";
            this.ItemForPrecio_2.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForPrecio_3
            // 
            this.ItemForPrecio_3.Control = this.Precio_3TextEdit;
            this.ItemForPrecio_3.Location = new System.Drawing.Point(0, 384);
            this.ItemForPrecio_3.Name = "ItemForPrecio_3";
            this.ItemForPrecio_3.Size = new System.Drawing.Size(888, 24);
            this.ItemForPrecio_3.Text = "Precio_3";
            this.ItemForPrecio_3.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForID_Moneda
            // 
            this.ItemForID_Moneda.Control = this.ID_MonedaTextEdit;
            this.ItemForID_Moneda.Location = new System.Drawing.Point(0, 408);
            this.ItemForID_Moneda.Name = "ItemForID_Moneda";
            this.ItemForID_Moneda.Size = new System.Drawing.Size(888, 24);
            this.ItemForID_Moneda.Text = "Moneda";
            this.ItemForID_Moneda.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForUsuario
            // 
            this.ItemForUsuario.Control = this.UsuarioTextEdit;
            this.ItemForUsuario.Location = new System.Drawing.Point(0, 432);
            this.ItemForUsuario.Name = "ItemForUsuario";
            this.ItemForUsuario.Size = new System.Drawing.Size(888, 24);
            this.ItemForUsuario.Text = "Usuario";
            this.ItemForUsuario.TextSize = new System.Drawing.Size(45, 13);
            this.ItemForUsuario.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // ItemForFecha
            // 
            this.ItemForFecha.Control = this.FechaDateEdit;
            this.ItemForFecha.Location = new System.Drawing.Point(0, 456);
            this.ItemForFecha.Name = "ItemForFecha";
            this.ItemForFecha.Size = new System.Drawing.Size(888, 59);
            this.ItemForFecha.Text = "Fecha";
            this.ItemForFecha.TextSize = new System.Drawing.Size(45, 13);
            this.ItemForFecha.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // ItemForImagen
            // 
            this.ItemForImagen.Control = this.ImagenPictureEdit;
            this.ItemForImagen.Location = new System.Drawing.Point(641, 0);
            this.ItemForImagen.MaxSize = new System.Drawing.Size(247, 240);
            this.ItemForImagen.MinSize = new System.Drawing.Size(247, 240);
            this.ItemForImagen.Name = "ItemForImagen";
            this.ItemForImagen.Size = new System.Drawing.Size(247, 240);
            this.ItemForImagen.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForImagen.StartNewLine = true;
            this.ItemForImagen.Text = "Imagen";
            this.ItemForImagen.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForImagen.TextVisible = false;
            // 
            // ItemForModelo
            // 
            this.ItemForModelo.Control = this.ModeloTextEdit;
            this.ItemForModelo.Location = new System.Drawing.Point(320, 48);
            this.ItemForModelo.Name = "ItemForModelo";
            this.ItemForModelo.Size = new System.Drawing.Size(321, 24);
            this.ItemForModelo.Text = "Modelo";
            this.ItemForModelo.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForUso
            // 
            this.ItemForUso.Control = this.UsoTextEdit;
            this.ItemForUso.Location = new System.Drawing.Point(320, 72);
            this.ItemForUso.Name = "ItemForUso";
            this.ItemForUso.Size = new System.Drawing.Size(321, 24);
            this.ItemForUso.Text = "Uso";
            this.ItemForUso.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForDetalle_5
            // 
            this.ItemForDetalle_5.Control = this.Detalle_5TextEdit;
            this.ItemForDetalle_5.Location = new System.Drawing.Point(0, 192);
            this.ItemForDetalle_5.Name = "ItemForDetalle_5";
            this.ItemForDetalle_5.Size = new System.Drawing.Size(641, 24);
            this.ItemForDetalle_5.Text = "Detalle_5";
            this.ItemForDetalle_5.TextSize = new System.Drawing.Size(45, 13);
            // 
            // ItemForDetalle_6
            // 
            this.ItemForDetalle_6.Control = this.Detalle_6TextEdit;
            this.ItemForDetalle_6.Location = new System.Drawing.Point(0, 216);
            this.ItemForDetalle_6.Name = "ItemForDetalle_6";
            this.ItemForDetalle_6.Size = new System.Drawing.Size(641, 24);
            this.ItemForDetalle_6.Text = "Detalle_6";
            this.ItemForDetalle_6.TextSize = new System.Drawing.Size(45, 13);
            // 
            // bar5
            // 
            this.bar5.BarName = "Menú principal";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawBorder = false;
            this.bar5.OptionsBar.MultiLine = true;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Menú principal";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnGuardar,
            this.btnCerrar});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Menú principal";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(268, 91);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGuardar, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Menú principal";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Caption = "Guardar";
            this.btnGuardar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Glyph")));
            this.btnGuardar.Id = 0;
            this.btnGuardar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGuardar.LargeGlyph")));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuardar_ItemClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Caption = "Cerrar";
            this.btnCerrar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Glyph")));
            this.btnCerrar.Id = 1;
            this.btnCerrar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCerrar.LargeGlyph")));
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCerrar_ItemClick_1);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(908, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 559);
            this.barDockControlBottom.Size = new System.Drawing.Size(908, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 535);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(908, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 535);
            // 
            // frmAddProducto
            // 
            this.ClientSize = new System.Drawing.Size(908, 559);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddProducto";
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.frmAddProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ID_ProductoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_ProductoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeloTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_1TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_2TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_3TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_4TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_5TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_6TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_7TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_8TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotosTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArchivoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precio_1TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precio_2TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precio_3TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_MonedaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDetalle_Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDetalle_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDetalle_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDetalle_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDetalle_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDetalle_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDetalle_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForArchivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrecio_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrecio_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrecio_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForID_Moneda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDetalle_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDetalle_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DataLayoutControl dataLayoutControl1;
        private TextEdit ID_ProductoTextEdit;
        private BindingSource productoBindingSource;
        private TextEdit Detalle_ProductoTextEdit;
        private TextEdit MarcaTextEdit;
        private TextEdit ModeloTextEdit;
        private TextEdit TipoTextEdit;
        private TextEdit UsoTextEdit;
        private TextEdit Detalle_1TextEdit;
        private TextEdit Detalle_2TextEdit;
        private TextEdit Detalle_3TextEdit;
        private TextEdit Detalle_4TextEdit;
        private TextEdit Detalle_5TextEdit;
        private TextEdit Detalle_6TextEdit;
        private TextEdit Detalle_7TextEdit;
        private TextEdit Detalle_8TextEdit;
        private TextEdit FotosTextEdit;
        private TextEdit ArchivoTextEdit;
        private TextEdit Precio_1TextEdit;
        private TextEdit Precio_2TextEdit;
        private TextEdit Precio_3TextEdit;
        private TextEdit ID_MonedaTextEdit;
        private TextEdit UsuarioTextEdit;
        private DateEdit FechaDateEdit;
        private PictureEdit ImagenPictureEdit;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlGroup layoutControlGroup2;
        private LayoutControlItem ItemForID_Producto;
        private LayoutControlItem ItemForDetalle_Producto;
        private LayoutControlItem ItemForMarca;
        private LayoutControlItem ItemForTipo;
        private LayoutControlItem ItemForDetalle_1;
        private LayoutControlItem ItemForDetalle_2;
        private LayoutControlItem ItemForDetalle_3;
        private LayoutControlItem ItemForDetalle_4;
        private LayoutControlItem ItemForDetalle_7;
        private LayoutControlItem ItemForDetalle_8;
        private LayoutControlItem ItemForFotos;
        private LayoutControlItem ItemForArchivo;
        private LayoutControlItem ItemForPrecio_1;
        private LayoutControlItem ItemForPrecio_2;
        private LayoutControlItem ItemForPrecio_3;
        private LayoutControlItem ItemForID_Moneda;
        private LayoutControlItem ItemForUsuario;
        private LayoutControlItem ItemForFecha;
        private LayoutControlItem ItemForImagen;
        private LayoutControlItem ItemForModelo;
        private LayoutControlItem ItemForUso;
        private LayoutControlItem ItemForDetalle_5;
        private LayoutControlItem ItemForDetalle_6;
        private Bar bar5;
        private BarManager barManager1;
        private Bar bar1;
        private BarButtonItem btnGuardar;
        private BarButtonItem btnCerrar;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
    }
}