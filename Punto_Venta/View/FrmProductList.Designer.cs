﻿namespace Punto_Venta.View
{
    partial class FrmProductList
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridViewProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlProducts = new DevExpress.XtraGrid.GridControl();
            this.lblStock = new DevExpress.XtraEditors.LabelControl();
            this.txtStock = new DevExpress.XtraEditors.TextEdit();
            this.Existencia = new DevExpress.XtraEditors.LabelControl();
            this.txtExistencia = new DevExpress.XtraEditors.TextEdit();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.txtEstado = new DevExpress.XtraEditors.TextEdit();
            this.lblPrecioVenta = new DevExpress.XtraEditors.LabelControl();
            this.txtPrecioVenta = new DevExpress.XtraEditors.TextEdit();
            this.lblPrecioCompra = new DevExpress.XtraEditors.LabelControl();
            this.txtPrecioCompra = new DevExpress.XtraEditors.TextEdit();
            this.lblNombreProducto = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreProducto = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigoProducto = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoProducto = new DevExpress.XtraEditors.TextEdit();
            this.lblidCategoria = new DevExpress.XtraEditors.LabelControl();
            this.txtIdCategoria = new DevExpress.XtraEditors.TextEdit();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnLimpiar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCategoria.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.False;
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
            this.ribbon.Size = new System.Drawing.Size(1115, 135);
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
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 490);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1115, 22);
            // 
            // gridViewProducts
            // 
            this.gridViewProducts.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewProducts.GridControl = this.gridControlProducts;
            this.gridViewProducts.Name = "gridViewProducts";
            this.gridViewProducts.OptionsBehavior.ReadOnly = true;
            this.gridViewProducts.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewProducts.OptionsView.ColumnAutoWidth = false;
            this.gridViewProducts.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewProducts.OptionsView.RowAutoHeight = true;
            this.gridViewProducts.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProducts.OptionsView.ShowGroupPanel = false;
            this.gridViewProducts.OptionsView.ShowViewCaption = true;
            this.gridViewProducts.ViewCaption = "Productos";
            this.gridViewProducts.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewProducts_FocusedRowChanged);
            // 
            // gridControlProducts
            // 
            this.gridControlProducts.Location = new System.Drawing.Point(376, 141);
            this.gridControlProducts.MainView = this.gridViewProducts;
            this.gridControlProducts.MenuManager = this.ribbon;
            this.gridControlProducts.Name = "gridControlProducts";
            this.gridControlProducts.Size = new System.Drawing.Size(707, 317);
            this.gridControlProducts.TabIndex = 2;
            this.gridControlProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProducts});
            // 
            // lblStock
            // 
            this.lblStock.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Appearance.Options.UseFont = true;
            this.lblStock.Location = new System.Drawing.Point(17, 303);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(39, 19);
            this.lblStock.TabIndex = 34;
            this.lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(183, 305);
            this.txtStock.MenuManager = this.ribbon;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(150, 20);
            this.txtStock.TabIndex = 33;
            // 
            // Existencia
            // 
            this.Existencia.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Existencia.Appearance.Options.UseFont = true;
            this.Existencia.Location = new System.Drawing.Point(17, 278);
            this.Existencia.Name = "Existencia";
            this.Existencia.Size = new System.Drawing.Size(69, 19);
            this.Existencia.TabIndex = 32;
            this.Existencia.Text = "Existencia";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(183, 280);
            this.txtExistencia.MenuManager = this.ribbon;
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(150, 20);
            this.txtExistencia.TabIndex = 31;
            // 
            // lblEstado
            // 
            this.lblEstado.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Appearance.Options.UseFont = true;
            this.lblEstado.Location = new System.Drawing.Point(17, 253);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(47, 19);
            this.lblEstado.TabIndex = 30;
            this.lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(183, 255);
            this.txtEstado.MenuManager = this.ribbon;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(150, 20);
            this.txtEstado.TabIndex = 29;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.Appearance.Options.UseFont = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(17, 227);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(108, 19);
            this.lblPrecioVenta.TabIndex = 28;
            this.lblPrecioVenta.Text = "Precio de venta";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(183, 229);
            this.txtPrecioVenta.MenuManager = this.ribbon;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(150, 20);
            this.txtPrecioVenta.TabIndex = 27;
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCompra.Appearance.Options.UseFont = true;
            this.lblPrecioCompra.Location = new System.Drawing.Point(17, 201);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(123, 19);
            this.lblPrecioCompra.TabIndex = 26;
            this.lblPrecioCompra.Text = "Precio de compra";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(183, 203);
            this.txtPrecioCompra.MenuManager = this.ribbon;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(150, 20);
            this.txtPrecioCompra.TabIndex = 25;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Appearance.Options.UseFont = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(17, 175);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(62, 19);
            this.lblNombreProducto.TabIndex = 24;
            this.lblNombreProducto.Text = "Nombre ";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(183, 177);
            this.txtNombreProducto.MenuManager = this.ribbon;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(150, 20);
            this.txtNombreProducto.TabIndex = 23;
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProducto.Appearance.Options.UseFont = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(17, 150);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(50, 19);
            this.lblCodigoProducto.TabIndex = 22;
            this.lblCodigoProducto.Text = "Código";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(183, 152);
            this.txtCodigoProducto.MenuManager = this.ribbon;
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(150, 20);
            this.txtCodigoProducto.TabIndex = 21;
            // 
            // lblidCategoria
            // 
            this.lblidCategoria.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidCategoria.Appearance.Options.UseFont = true;
            this.lblidCategoria.Location = new System.Drawing.Point(17, 328);
            this.lblidCategoria.Name = "lblidCategoria";
            this.lblidCategoria.Size = new System.Drawing.Size(158, 19);
            this.lblidCategoria.TabIndex = 36;
            this.lblidCategoria.Text = "Código de la categoria";
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(183, 331);
            this.txtIdCategoria.MenuManager = this.ribbon;
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(150, 20);
            this.txtIdCategoria.TabIndex = 35;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.Location = new System.Drawing.Point(6, 399);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 23);
            this.btnAgregar.TabIndex = 39;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Appearance.Options.UseFont = true;
            this.btnActualizar.Location = new System.Drawing.Point(103, 399);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(82, 23);
            this.btnActualizar.TabIndex = 40;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Appearance.Options.UseFont = true;
            this.btnEliminar.Location = new System.Drawing.Point(191, 399);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 23);
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Appearance.Options.UseFont = true;
            this.btnLimpiar.Location = new System.Drawing.Point(277, 399);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(82, 23);
            this.btnLimpiar.TabIndex = 44;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.txtLimpiar_Click);
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1115, 512);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblidCategoria);
            this.Controls.Add(this.txtIdCategoria);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.Existencia);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.lblPrecioCompra);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblCodigoProducto);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.gridControlProducts);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.ShowIcon = false;
            this.MinimizeBox = false;
            this.Name = "ProductList";
            this.Ribbon = this.ribbon;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "ProductList";
          
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCategoria.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProducts;
        private DevExpress.XtraGrid.GridControl gridControlProducts;
        private DevExpress.XtraEditors.LabelControl lblStock;
        private DevExpress.XtraEditors.TextEdit txtStock;
        private DevExpress.XtraEditors.LabelControl Existencia;
        private DevExpress.XtraEditors.TextEdit txtExistencia;
        private DevExpress.XtraEditors.LabelControl lblEstado;
        private DevExpress.XtraEditors.TextEdit txtEstado;
        private DevExpress.XtraEditors.LabelControl lblPrecioVenta;
        private DevExpress.XtraEditors.TextEdit txtPrecioVenta;
        private DevExpress.XtraEditors.LabelControl lblPrecioCompra;
        private DevExpress.XtraEditors.TextEdit txtPrecioCompra;
        private DevExpress.XtraEditors.LabelControl lblNombreProducto;
        private DevExpress.XtraEditors.TextEdit txtNombreProducto;
        private DevExpress.XtraEditors.LabelControl lblCodigoProducto;
        private DevExpress.XtraEditors.TextEdit txtCodigoProducto;
        private DevExpress.XtraEditors.LabelControl lblidCategoria;
        private DevExpress.XtraEditors.TextEdit txtIdCategoria;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.SimpleButton btnActualizar;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnLimpiar;
    }
}