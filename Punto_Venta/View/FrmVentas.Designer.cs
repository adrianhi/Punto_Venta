﻿namespace Punto_Venta.View
{
    partial class FrmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.lblCorreo = new DevExpress.XtraEditors.LabelControl();
            this.txtCedula = new DevExpress.XtraEditors.TextEdit();
            this.lblidProducto = new DevExpress.XtraEditors.LabelControl();
            this.txtIdProducto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMontoPagar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrecioProducto = new DevExpress.XtraEditors.TextEdit();
            this.btnProcesar = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.txtMontoRecibido = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCantidadProducto = new DevExpress.XtraEditors.SpinEdit();
            this.btnSearchProduct = new DevExpress.XtraEditors.SimpleButton();
            this.gcClients = new DevExpress.XtraEditors.GroupControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.btnSearchCedula = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreCliente = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtStockProducto = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreProducto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtMontoDevolver = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoPagar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoRecibido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcClients)).BeginInit();
            this.gcClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoDevolver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1017, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 623);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1017, 22);
            // 
            // lblCorreo
            // 
            this.lblCorreo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Appearance.Options.UseFont = true;
            this.lblCorreo.Location = new System.Drawing.Point(5, 36);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(48, 19);
            this.lblCorreo.TabIndex = 37;
            this.lblCorreo.Text = "Cedula";
            this.lblCorreo.UseMnemonic = false;
            // 
            // txtCedula
            // 
            this.txtCedula.EditValue = "";
            this.txtCedula.Location = new System.Drawing.Point(68, 35);
            this.txtCedula.MenuManager = this.ribbon;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Properties.NullValuePrompt = "40263556226";
            this.txtCedula.Size = new System.Drawing.Size(129, 20);
            this.txtCedula.TabIndex = 36;
            // 
            // lblidProducto
            // 
            this.lblidProducto.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidProducto.Appearance.Options.UseFont = true;
            this.lblidProducto.Location = new System.Drawing.Point(230, 39);
            this.lblidProducto.Name = "lblidProducto";
            this.lblidProducto.Size = new System.Drawing.Size(63, 19);
            this.lblidProducto.TabIndex = 41;
            this.lblidProducto.Text = "Producto";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(92, 38);
            this.txtIdProducto.MenuManager = this.ribbon;
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Properties.NullValuePrompt = "VG100";
            this.txtIdProducto.Size = new System.Drawing.Size(104, 20);
            this.txtIdProducto.TabIndex = 40;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(847, 348);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 16);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "Monto a Pagar";
            // 
            // txtMontoPagar
            // 
            this.txtMontoPagar.Location = new System.Drawing.Point(847, 373);
            this.txtMontoPagar.MenuManager = this.ribbon;
            this.txtMontoPagar.Name = "txtMontoPagar";
            this.txtMontoPagar.Properties.ReadOnly = true;
            this.txtMontoPagar.Size = new System.Drawing.Size(107, 20);
            this.txtMontoPagar.TabIndex = 42;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 19);
            this.labelControl2.TabIndex = 45;
            this.labelControl2.Text = "Cantidad";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(138, 69);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 19);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "Precio";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(187, 68);
            this.txtPrecioProducto.MenuManager = this.ribbon;
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Properties.ReadOnly = true;
            this.txtPrecioProducto.Size = new System.Drawing.Size(91, 20);
            this.txtPrecioProducto.TabIndex = 46;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Appearance.Options.UseFont = true;
            this.btnProcesar.Location = new System.Drawing.Point(847, 517);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(122, 34);
            this.btnProcesar.TabIndex = 48;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Appearance.Options.UseFont = true;
            this.btnBuscar.Location = new System.Drawing.Point(847, 218);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(122, 34);
            this.btnBuscar.TabIndex = 51;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtMontoRecibido
            // 
            this.txtMontoRecibido.Location = new System.Drawing.Point(847, 425);
            this.txtMontoRecibido.MenuManager = this.ribbon;
            this.txtMontoRecibido.Name = "txtMontoRecibido";
            this.txtMontoRecibido.Size = new System.Drawing.Size(107, 20);
            this.txtMontoRecibido.TabIndex = 54;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(847, 399);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(87, 16);
            this.labelControl4.TabIndex = 55;
            this.labelControl4.Text = "Monto Recibido";
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidadProducto.Location = new System.Drawing.Point(73, 68);
            this.txtCantidadProducto.MenuManager = this.ribbon;
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCantidadProducto.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtCantidadProducto.Properties.IsFloatValue = false;
            this.txtCantidadProducto.Properties.MaskSettings.Set("mask", "N00");
            this.txtCantidadProducto.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtCantidadProducto.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidadProducto.Size = new System.Drawing.Size(59, 20);
            this.txtCantidadProducto.TabIndex = 44;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchProduct.ImageOptions.Image")));
            this.btnSearchProduct.Location = new System.Drawing.Point(202, 37);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(22, 21);
            this.btnSearchProduct.TabIndex = 58;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // gcClients
            // 
            this.gcClients.Appearance.BackColor = System.Drawing.Color.White;
            this.gcClients.Appearance.Options.UseBackColor = true;
            this.gcClients.AppearanceCaption.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcClients.AppearanceCaption.Options.UseFont = true;
            this.gcClients.Controls.Add(this.labelControl8);
            this.gcClients.Controls.Add(this.txtCorreo);
            this.gcClients.Controls.Add(this.btnSearchCedula);
            this.gcClients.Controls.Add(this.labelControl5);
            this.gcClients.Controls.Add(this.txtNombreCliente);
            this.gcClients.Controls.Add(this.lblCorreo);
            this.gcClients.Controls.Add(this.txtCedula);
            this.gcClients.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcClients.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.gcClients.Location = new System.Drawing.Point(30, 188);
            this.gcClients.Name = "gcClients";
            this.gcClients.Size = new System.Drawing.Size(248, 122);
            this.gcClients.TabIndex = 62;
            this.gcClients.Text = "Información del cliente";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(5, 89);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 19);
            this.labelControl8.TabIndex = 61;
            this.labelControl8.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(68, 88);
            this.txtCorreo.MenuManager = this.ribbon;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Properties.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(129, 20);
            this.txtCorreo.TabIndex = 60;
            // 
            // btnSearchCedula
            // 
            this.btnSearchCedula.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCedula.ImageOptions.Image")));
            this.btnSearchCedula.Location = new System.Drawing.Point(203, 34);
            this.btnSearchCedula.Name = "btnSearchCedula";
            this.btnSearchCedula.Size = new System.Drawing.Size(23, 21);
            this.btnSearchCedula.TabIndex = 59;
            this.btnSearchCedula.Click += new System.EventHandler(this.btnSearchCedula_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 62);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(57, 19);
            this.labelControl5.TabIndex = 39;
            this.labelControl5.Text = "Nombre";
            this.labelControl5.UseMnemonic = false;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(68, 61);
            this.txtNombreCliente.MenuManager = this.ribbon;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Properties.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(129, 20);
            this.txtNombreCliente.TabIndex = 38;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtStockProducto);
            this.groupControl1.Controls.Add(this.txtNombreProducto);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtIdProducto);
            this.groupControl1.Controls.Add(this.txtCantidadProducto);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.lblidProducto);
            this.groupControl1.Controls.Add(this.txtPrecioProducto);
            this.groupControl1.Controls.Add(this.btnSearchProduct);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(311, 188);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(514, 122);
            this.groupControl1.TabIndex = 63;
            this.groupControl1.Text = "Información del Producto";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(284, 69);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(39, 19);
            this.labelControl7.TabIndex = 62;
            this.labelControl7.Text = "Stock";
            // 
            // txtStockProducto
            // 
            this.txtStockProducto.Location = new System.Drawing.Point(329, 68);
            this.txtStockProducto.MenuManager = this.ribbon;
            this.txtStockProducto.Name = "txtStockProducto";
            this.txtStockProducto.Properties.ReadOnly = true;
            this.txtStockProducto.Size = new System.Drawing.Size(91, 20);
            this.txtStockProducto.TabIndex = 61;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(299, 38);
            this.txtNombreProducto.MenuManager = this.ribbon;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(195, 20);
            this.txtNombreProducto.TabIndex = 59;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(5, 39);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(83, 19);
            this.labelControl6.TabIndex = 60;
            this.labelControl6.Text = "Id Producto";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(847, 451);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(98, 16);
            this.labelControl9.TabIndex = 64;
            this.labelControl9.Text = "Monto a devolver";
            // 
            // txtMontoDevolver
            // 
            this.txtMontoDevolver.Location = new System.Drawing.Point(847, 476);
            this.txtMontoDevolver.MenuManager = this.ribbon;
            this.txtMontoDevolver.Name = "txtMontoDevolver";
            this.txtMontoDevolver.Size = new System.Drawing.Size(107, 20);
            this.txtMontoDevolver.TabIndex = 65;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(30, 327);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(795, 290);
            this.gridControl1.TabIndex = 66;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 645);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtMontoDevolver);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcClients);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtMontoRecibido);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtMontoPagar);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.ShowIcon = false;
            this.MinimizeBox = false;
            this.Name = "FrmVentas";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoPagar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoRecibido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcClients)).EndInit();
            this.gcClients.ResumeLayout(false);
            this.gcClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoDevolver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.LabelControl lblCorreo;
        private DevExpress.XtraEditors.TextEdit txtCedula;
        private DevExpress.XtraEditors.LabelControl lblidProducto;
        private DevExpress.XtraEditors.TextEdit txtIdProducto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMontoPagar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPrecioProducto;
        private DevExpress.XtraEditors.SimpleButton btnProcesar;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.TextEdit txtMontoRecibido;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit txtCantidadProducto;
        private DevExpress.XtraEditors.SimpleButton btnSearchProduct;
        private DevExpress.XtraEditors.GroupControl gcClients;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtNombreCliente;
        private DevExpress.XtraEditors.SimpleButton btnSearchCedula;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtNombreProducto;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtStockProducto;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtCorreo;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtMontoDevolver;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}