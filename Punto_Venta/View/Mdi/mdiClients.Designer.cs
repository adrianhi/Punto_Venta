namespace Punto_Venta.View.Mdi
{
    partial class mdiClients
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
            this.gridControlClients = new DevExpress.XtraGrid.GridControl();
            this.gridViewClients = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlClients
            // 
            this.gridControlClients.DataSource = typeof(Punto_Venta.Model.EF.Maestro_Clientes);
            this.gridControlClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlClients.Location = new System.Drawing.Point(0, 0);
            this.gridControlClients.MainView = this.gridViewClients;
            this.gridControlClients.Name = "gridControlClients";
            this.gridControlClients.Size = new System.Drawing.Size(600, 367);
            this.gridControlClients.TabIndex = 66;
            this.gridControlClients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClients});
            // 
            // gridViewClients
            // 
            this.gridViewClients.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidCliente,
            this.colcedula,
            this.colnombre,
            this.coldireccion,
            this.colcorreo,
            this.coltelefono});
            this.gridViewClients.GridControl = this.gridControlClients;
            this.gridViewClients.Name = "gridViewClients";
            this.gridViewClients.OptionsBehavior.ReadOnly = true;
            this.gridViewClients.OptionsBehavior.UnboundColumnExpressionEditorMode = DevExpress.XtraEditors.ExpressionEditorMode.Standard;
            this.gridViewClients.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewClients.OptionsCustomization.AllowColumnResizing = false;
            this.gridViewClients.OptionsMenu.EnableColumnMenu = false;
            this.gridViewClients.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewClients.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridViewClients.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.gridViewClients.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewClients.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridViewClients.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;
            this.gridViewClients.OptionsView.RowAutoHeight = true;
            this.gridViewClients.OptionsView.ShowAutoFilterRow = true;
            this.gridViewClients.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridViewClients.OptionsView.ShowGroupPanel = false;
            this.gridViewClients.OptionsView.ShowViewCaption = true;
            this.gridViewClients.ViewCaption = "Lista de Clientes";
            this.gridViewClients.DoubleClick += new System.EventHandler(this.gridViewClients_DoubleClick);
            // 
            // colidCliente
            // 
            this.colidCliente.Caption = "Id Cliente";
            this.colidCliente.FieldName = "idCliente";
            this.colidCliente.Name = "colidCliente";
            this.colidCliente.Visible = true;
            this.colidCliente.VisibleIndex = 0;
            // 
            // colcedula
            // 
            this.colcedula.Caption = "Cedula";
            this.colcedula.FieldName = "cedula";
            this.colcedula.Name = "colcedula";
            this.colcedula.Visible = true;
            this.colcedula.VisibleIndex = 1;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 5;
            // 
            // coldireccion
            // 
            this.coldireccion.Caption = "Dirección";
            this.coldireccion.FieldName = "direccion";
            this.coldireccion.Name = "coldireccion";
            this.coldireccion.Visible = true;
            this.coldireccion.VisibleIndex = 2;
            // 
            // colcorreo
            // 
            this.colcorreo.Caption = "Correo";
            this.colcorreo.FieldName = "correo";
            this.colcorreo.Name = "colcorreo";
            this.colcorreo.Visible = true;
            this.colcorreo.VisibleIndex = 3;
            // 
            // coltelefono
            // 
            this.coltelefono.Caption = "Teléfono";
            this.coltelefono.FieldName = "telefono";
            this.coltelefono.Name = "coltelefono";
            this.coltelefono.Visible = true;
            this.coltelefono.VisibleIndex = 4;
            // 
            // mdiClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 367);
            this.Controls.Add(this.gridControlClients);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mdiClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdiClients";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlClients;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClients;
        private DevExpress.XtraGrid.Columns.GridColumn colidCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colcedula;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colcorreo;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
    }
}