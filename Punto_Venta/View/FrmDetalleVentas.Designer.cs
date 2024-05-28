namespace Punto_Venta.View
{
    partial class FrmDetalleVentas
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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.detallesventasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detalleVentas = new Punto_Venta.DetalleVentas();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId_detallesVentas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio_venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.detalles_ventasTableAdapter = new Punto_Venta.DetalleVentasTableAdapters.Detalles_ventasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesventasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.detallesventasBindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(628, 449);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // detallesventasBindingSource1
            // 
            this.detallesventasBindingSource1.DataMember = "Detalles_ventas";
            this.detallesventasBindingSource1.DataSource = this.detalleVentas;
            // 
            // detalleVentas
            // 
            this.detalleVentas.DataSetName = "DetalleVentas";
            this.detalleVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId_detallesVentas,
            this.colId_venta,
            this.colId_producto,
            this.colCantidad,
            this.colPrecio_venta,
            this.colFecha});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Detalle de las Ventas";
            // 
            // colId_detallesVentas
            // 
            this.colId_detallesVentas.FieldName = "Id_detallesVentas";
            this.colId_detallesVentas.Name = "colId_detallesVentas";
            this.colId_detallesVentas.Visible = true;
            this.colId_detallesVentas.VisibleIndex = 0;
            // 
            // colId_venta
            // 
            this.colId_venta.FieldName = "Id_venta";
            this.colId_venta.Name = "colId_venta";
            this.colId_venta.Visible = true;
            this.colId_venta.VisibleIndex = 1;
            // 
            // colId_producto
            // 
            this.colId_producto.FieldName = "Id_producto";
            this.colId_producto.Name = "colId_producto";
            this.colId_producto.Visible = true;
            this.colId_producto.VisibleIndex = 2;
            // 
            // colCantidad
            // 
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 3;
            // 
            // colPrecio_venta
            // 
            this.colPrecio_venta.FieldName = "Precio_venta";
            this.colPrecio_venta.Name = "colPrecio_venta";
            this.colPrecio_venta.Visible = true;
            this.colPrecio_venta.VisibleIndex = 4;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 5;
            // 
            // detalles_ventasTableAdapter
            // 
            this.detalles_ventasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDetalleVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 449);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmDetalleVentas";
            this.Text = "FrmDetalleVentas";
            this.Load += new System.EventHandler(this.FrmDetalleVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesventasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId_detallesVentas;
        private DevExpress.XtraGrid.Columns.GridColumn colId_venta;
        private DevExpress.XtraGrid.Columns.GridColumn colId_producto;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio_venta;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DetalleVentas detalleVentas;
        private System.Windows.Forms.BindingSource detallesventasBindingSource1;
        private DetalleVentasTableAdapters.Detalles_ventasTableAdapter detalles_ventasTableAdapter;
    }
}