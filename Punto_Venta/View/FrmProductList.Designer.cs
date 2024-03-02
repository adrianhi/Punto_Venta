namespace Punto_Venta.View
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
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridViewProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio_compra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio_venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlProducts = new DevExpress.XtraGrid.GridControl();
            this.lblStock = new DevExpress.XtraEditors.LabelControl();
            this.Existencia = new DevExpress.XtraEditors.LabelControl();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.lblPrecioVenta = new DevExpress.XtraEditors.LabelControl();
            this.txtPrecioVenta = new DevExpress.XtraEditors.TextEdit();
            this.lblPrecioCompra = new DevExpress.XtraEditors.LabelControl();
            this.txtPrecioCompra = new DevExpress.XtraEditors.TextEdit();
            this.lblNombreProducto = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreProducto = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigoProducto = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoProducto = new DevExpress.XtraEditors.TextEdit();
            this.lblidCategoria = new DevExpress.XtraEditors.LabelControl();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnLimpiar = new DevExpress.XtraEditors.SimpleButton();
            this.lkCategories = new DevExpress.XtraEditors.LookUpEdit();
            this.categoriaproductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.punto_ventasDataSet = new Punto_Venta.Punto_ventasDataSet();
            this.categoria_productosTableAdapter = new Punto_Venta.Punto_ventasDataSetTableAdapters.Categoria_productosTableAdapter();
            this.txtStock = new DevExpress.XtraEditors.SpinEdit();
            this.cmbEstado = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtExistencia = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkCategories.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaproductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_ventasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistencia.Properties)).BeginInit();
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
            this.gridViewProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId_producto,
            this.colCodigo,
            this.colNombre,
            this.colPrecio_compra,
            this.colPrecio_venta,
            this.colEstado,
            this.colExistencia,
            this.colStock,
            this.colId_categoria});
            this.gridViewProducts.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewProducts.GridControl = this.gridControlProducts;
            this.gridViewProducts.Name = "gridViewProducts";
            this.gridViewProducts.OptionsBehavior.ReadOnly = true;
            this.gridViewProducts.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewProducts.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewProducts.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridViewProducts.OptionsView.ColumnAutoWidth = false;
            this.gridViewProducts.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewProducts.OptionsView.RowAutoHeight = true;
            this.gridViewProducts.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProducts.OptionsView.ShowGroupPanel = false;
            this.gridViewProducts.OptionsView.ShowViewCaption = true;
            this.gridViewProducts.ViewCaption = "Productos";
            this.gridViewProducts.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewProducts_FocusedRowChanged);
            // 
            // colId_producto
            // 
            this.colId_producto.FieldName = "Id_producto";
            this.colId_producto.Name = "colId_producto";
            this.colId_producto.Visible = true;
            this.colId_producto.VisibleIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 1;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 2;
            // 
            // colPrecio_compra
            // 
            this.colPrecio_compra.FieldName = "Precio_compra";
            this.colPrecio_compra.Name = "colPrecio_compra";
            this.colPrecio_compra.Visible = true;
            this.colPrecio_compra.VisibleIndex = 3;
            // 
            // colPrecio_venta
            // 
            this.colPrecio_venta.FieldName = "Precio_venta";
            this.colPrecio_venta.Name = "colPrecio_venta";
            this.colPrecio_venta.Visible = true;
            this.colPrecio_venta.VisibleIndex = 4;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 5;
            // 
            // colExistencia
            // 
            this.colExistencia.FieldName = "Existencia";
            this.colExistencia.Name = "colExistencia";
            this.colExistencia.Visible = true;
            this.colExistencia.VisibleIndex = 6;
            // 
            // colStock
            // 
            this.colStock.FieldName = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.Visible = true;
            this.colStock.VisibleIndex = 7;
            // 
            // colId_categoria
            // 
            this.colId_categoria.FieldName = "Id_categoria";
            this.colId_categoria.Name = "colId_categoria";
            this.colId_categoria.Visible = true;
            this.colId_categoria.VisibleIndex = 8;
            // 
            // gridControlProducts
            // 
            this.gridControlProducts.DataSource = typeof(Punto_Venta.Model.EF.Producto);
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
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
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
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
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
            // lkCategories
            // 
            this.lkCategories.Location = new System.Drawing.Point(183, 332);
            this.lkCategories.MenuManager = this.ribbon;
            this.lkCategories.Name = "lkCategories";
            this.lkCategories.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkCategories.Properties.DataSource = this.categoriaproductosBindingSource;
            this.lkCategories.Properties.DisplayMember = "Nombre_categoria";
            this.lkCategories.Properties.NullText = "";
            this.lkCategories.Properties.ValueMember = "Id_categoria";
            this.lkCategories.Size = new System.Drawing.Size(150, 20);
            this.lkCategories.TabIndex = 72;
            // 
            // categoriaproductosBindingSource
            // 
            this.categoriaproductosBindingSource.DataMember = "Categoria_productos";
            this.categoriaproductosBindingSource.DataSource = this.punto_ventasDataSet;
            // 
            // punto_ventasDataSet
            // 
            this.punto_ventasDataSet.DataSetName = "Punto_ventasDataSet";
            this.punto_ventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoria_productosTableAdapter
            // 
            this.categoria_productosTableAdapter.ClearBeforeFill = true;
            // 
            // txtStock
            // 
            this.txtStock.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtStock.Location = new System.Drawing.Point(183, 305);
            this.txtStock.MenuManager = this.ribbon;
            this.txtStock.Name = "txtStock";
            this.txtStock.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStock.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtStock.Properties.IsFloatValue = false;
            this.txtStock.Properties.MaskSettings.Set("mask", "N00");
            this.txtStock.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtStock.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtStock.Properties.ValidateOnEnterKey = true;
            this.txtStock.Size = new System.Drawing.Size(150, 20);
            this.txtStock.TabIndex = 33;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(183, 255);
            this.cmbEstado.MenuManager = this.ribbon;
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Size = new System.Drawing.Size(150, 20);
            this.cmbEstado.TabIndex = 75;
            // 
            // txtExistencia
            // 
            this.txtExistencia.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtExistencia.Location = new System.Drawing.Point(183, 281);
            this.txtExistencia.MenuManager = this.ribbon;
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtExistencia.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtExistencia.Properties.IsFloatValue = false;
            this.txtExistencia.Properties.MaskSettings.Set("mask", "N00");
            this.txtExistencia.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtExistencia.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtExistencia.Properties.ValidateOnEnterKey = true;
            this.txtExistencia.Size = new System.Drawing.Size(150, 20);
            this.txtExistencia.TabIndex = 80;
           // 
            // FrmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1115, 512);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.lkCategories);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblidCategoria);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.Existencia);
            this.Controls.Add(this.lblEstado);
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
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.ribbon);
            this.IconOptions.ShowIcon = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductList";
            this.Ribbon = this.ribbon;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "ProductList";
            this.Load += new System.EventHandler(this.FrmProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkCategories.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaproductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punto_ventasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistencia.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl Existencia;
        private DevExpress.XtraEditors.LabelControl lblEstado;
        private DevExpress.XtraEditors.LabelControl lblPrecioVenta;
        private DevExpress.XtraEditors.TextEdit txtPrecioVenta;
        private DevExpress.XtraEditors.LabelControl lblPrecioCompra;
        private DevExpress.XtraEditors.TextEdit txtPrecioCompra;
        private DevExpress.XtraEditors.LabelControl lblNombreProducto;
        private DevExpress.XtraEditors.TextEdit txtNombreProducto;
        private DevExpress.XtraEditors.LabelControl lblCodigoProducto;
        private DevExpress.XtraEditors.TextEdit txtCodigoProducto;
        private DevExpress.XtraEditors.LabelControl lblidCategoria;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.SimpleButton btnActualizar;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnLimpiar;
        private DevExpress.XtraGrid.Columns.GridColumn colId_producto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio_compra;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio_venta;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colExistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colId_categoria;
        private DevExpress.XtraEditors.LookUpEdit lkCategories;
        private Punto_ventasDataSet punto_ventasDataSet;
        private System.Windows.Forms.BindingSource categoriaproductosBindingSource;
        private Punto_ventasDataSetTableAdapters.Categoria_productosTableAdapter categoria_productosTableAdapter;
        private DevExpress.XtraEditors.SpinEdit txtStock;
        private DevExpress.XtraEditors.ComboBoxEdit cmbEstado;
        private DevExpress.XtraEditors.SpinEdit txtExistencia;
    }
}