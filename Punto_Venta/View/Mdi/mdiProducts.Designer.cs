namespace Punto_Venta.View.Mdi
{
    partial class mdiProducts
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
            this.gridControlProducts = new DevExpress.XtraGrid.GridControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlProducts
            // 
            this.gridControlProducts.DataSource = typeof(Punto_Venta.Model.EF.Producto);
            this.gridControlProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProducts.Location = new System.Drawing.Point(0, 0);
            this.gridControlProducts.MainView = this.gridViewProducts;
            this.gridControlProducts.Name = "gridControlProducts";
            this.gridControlProducts.Size = new System.Drawing.Size(786, 422);
            this.gridControlProducts.TabIndex = 3;
            this.gridControlProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProducts});
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
            this.gridViewProducts.DoubleClick += new System.EventHandler(this.gridViewProducts_DoubleClick);
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
            // mdiProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 422);
            this.Controls.Add(this.gridControlProducts);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mdiProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdiProducts";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProducts;
        private DevExpress.XtraGrid.Columns.GridColumn colId_producto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio_compra;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio_venta;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colExistencia;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colId_categoria;
    }
}