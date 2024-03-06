namespace Punto_Venta.View
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
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.txtMontoRecibido = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCantidadProducto = new DevExpress.XtraEditors.SpinEdit();
            this.btnSearchProduct = new DevExpress.XtraEditors.SimpleButton();
            this.gcClients = new DevExpress.XtraEditors.GroupControl();
            this.txtIdCliente = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearchCedula = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreCliente = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtExistenciaProducto = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreProducto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtMontoDevolver = new DevExpress.XtraEditors.TextEdit();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.ChkCredito = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoPagar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoRecibido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcClients)).BeginInit();
            this.gcClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistenciaProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoDevolver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkCredito.Properties)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(1003, 37);
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
            this.txtCedula.Location = new System.Drawing.Point(74, 35);
            this.txtCedula.MenuManager = this.ribbon;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Properties.NullValuePrompt = "40263556226";
            this.txtCedula.Size = new System.Drawing.Size(129, 20);
            this.txtCedula.TabIndex = 36;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
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
            this.txtIdProducto.Properties.NullValuePrompt = "100";
            this.txtIdProducto.Size = new System.Drawing.Size(104, 20);
            this.txtIdProducto.TabIndex = 40;
            this.txtIdProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProducto_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(847, 345);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 16);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "Monto a Pagar";
            // 
            // txtMontoPagar
            // 
            this.txtMontoPagar.Location = new System.Drawing.Point(847, 370);
            this.txtMontoPagar.MenuManager = this.ribbon;
            this.txtMontoPagar.Name = "txtMontoPagar";
            this.txtMontoPagar.Properties.ReadOnly = true;
            this.txtMontoPagar.Size = new System.Drawing.Size(122, 20);
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
            this.btnProcesar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnProcesar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProcesar.ImageOptions.SvgImage")));
            this.btnProcesar.Location = new System.Drawing.Point(847, 514);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(122, 34);
            this.btnProcesar.TabIndex = 48;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAgregar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAgregar.ImageOptions.SvgImage")));
            this.btnAgregar.Location = new System.Drawing.Point(847, 103);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 34);
            this.btnAgregar.TabIndex = 51;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtMontoRecibido
            // 
            this.txtMontoRecibido.Location = new System.Drawing.Point(847, 422);
            this.txtMontoRecibido.MenuManager = this.ribbon;
            this.txtMontoRecibido.Name = "txtMontoRecibido";
            this.txtMontoRecibido.Size = new System.Drawing.Size(122, 20);
            this.txtMontoRecibido.TabIndex = 54;
            this.txtMontoRecibido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoRecibido_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(847, 396);
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
            this.gcClients.Controls.Add(this.txtIdCliente);
            this.gcClients.Controls.Add(this.labelControl8);
            this.gcClients.Controls.Add(this.btnSearchCedula);
            this.gcClients.Controls.Add(this.labelControl5);
            this.gcClients.Controls.Add(this.txtNombreCliente);
            this.gcClients.Controls.Add(this.lblCorreo);
            this.gcClients.Controls.Add(this.txtCedula);
            this.gcClients.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcClients.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.gcClients.Location = new System.Drawing.Point(35, 128);
            this.gcClients.Name = "gcClients";
            this.gcClients.Size = new System.Drawing.Size(248, 122);
            this.gcClients.TabIndex = 62;
            this.gcClients.Text = "Información del cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(74, 88);
            this.txtIdCliente.MenuManager = this.ribbon;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Properties.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(129, 20);
            this.txtIdCliente.TabIndex = 62;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(5, 89);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(65, 19);
            this.labelControl8.TabIndex = 61;
            this.labelControl8.Text = "Id cliente";
            // 
            // btnSearchCedula
            // 
            this.btnSearchCedula.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCedula.ImageOptions.Image")));
            this.btnSearchCedula.Location = new System.Drawing.Point(206, 35);
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
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(74, 61);
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
            this.groupControl1.Controls.Add(this.txtExistenciaProducto);
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
            this.groupControl1.Location = new System.Drawing.Point(316, 128);
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
            this.labelControl7.Size = new System.Drawing.Size(69, 19);
            this.labelControl7.TabIndex = 62;
            this.labelControl7.Text = "Existencia";
            // 
            // txtExistenciaProducto
            // 
            this.txtExistenciaProducto.Location = new System.Drawing.Point(359, 68);
            this.txtExistenciaProducto.MenuManager = this.ribbon;
            this.txtExistenciaProducto.Name = "txtExistenciaProducto";
            this.txtExistenciaProducto.Properties.ReadOnly = true;
            this.txtExistenciaProducto.Size = new System.Drawing.Size(91, 20);
            this.txtExistenciaProducto.TabIndex = 61;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(299, 38);
            this.txtNombreProducto.MenuManager = this.ribbon;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Properties.ReadOnly = true;
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
            this.labelControl9.Location = new System.Drawing.Point(847, 448);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(98, 16);
            this.labelControl9.TabIndex = 64;
            this.labelControl9.Text = "Monto a devolver";
            // 
            // txtMontoDevolver
            // 
            this.txtMontoDevolver.Enabled = false;
            this.txtMontoDevolver.Location = new System.Drawing.Point(847, 473);
            this.txtMontoDevolver.MenuManager = this.ribbon;
            this.txtMontoDevolver.Name = "txtMontoDevolver";
            this.txtMontoDevolver.Properties.ReadOnly = true;
            this.txtMontoDevolver.Size = new System.Drawing.Size(122, 20);
            this.txtMontoDevolver.TabIndex = 65;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToOrderColumns = true;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.precioProducto,
            this.Cantidad,
            this.SubTotal});
            this.dgvVentas.GridColor = System.Drawing.Color.Silver;
            this.dgvVentas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvVentas.Location = new System.Drawing.Point(35, 284);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(795, 273);
            this.dgvVentas.TabIndex = 69;
            this.dgvVentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellDoubleClick);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "Id";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Nombre";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // precioProducto
            // 
            this.precioProducto.HeaderText = "Precio";
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Appearance.Options.UseFont = true;
            this.btnEliminar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEliminar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEliminar.ImageOptions.SvgImage")));
            this.btnEliminar.Location = new System.Drawing.Point(847, 150);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 34);
            this.btnEliminar.TabIndex = 72;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(69, 100);
            this.dateEdit1.MenuManager = this.ribbon;
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 79;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(33, 103);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(34, 16);
            this.labelControl10.TabIndex = 80;
            this.labelControl10.Text = "Fecha";
            // 
            // ChkCredito
            // 
            this.ChkCredito.Location = new System.Drawing.Point(199, 101);
            this.ChkCredito.MenuManager = this.ribbon;
            this.ChkCredito.Name = "ChkCredito";
            this.ChkCredito.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkCredito.Properties.Appearance.Options.UseFont = true;
            this.ChkCredito.Properties.Caption = "Es crédito";
            this.ChkCredito.Size = new System.Drawing.Size(84, 20);
            this.ChkCredito.TabIndex = 82;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 593);
            this.Controls.Add(this.ChkCredito);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.txtMontoDevolver);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcClients);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtMontoRecibido);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtMontoPagar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.ShowIcon = false;
            this.MinimizeBox = false;
            this.Name = "FrmVentas";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistenciaProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoDevolver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkCredito.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
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
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
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
        private DevExpress.XtraEditors.TextEdit txtExistenciaProducto;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtMontoDevolver;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.TextEdit txtIdCliente;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.CheckEdit ChkCredito;
    }
}