namespace Punto_Venta.View
{
    partial class FrmCxC
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
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtIdCxC = new DevExpress.XtraEditors.TextEdit();
            this.lbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdVenta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdCliente = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTransaccionId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTipoTransaccion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtBalance = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtMontoRecibido = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtMontoAbornar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.dtAbono = new DevExpress.XtraEditors.DateEdit();
            this.txtActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtMontoFinal = new DevExpress.XtraEditors.TextEdit();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.gcCuentas = new DevExpress.XtraGrid.GridControl();
            this.gvCuentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCxC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransaccionId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoTransaccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoRecibido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoAbornar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAbono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAbono.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCuentas)).BeginInit();
            this.SuspendLayout();
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
            this.ribbon.Size = new System.Drawing.Size(845, 37);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Name = "gridColumn2";
            // 
            // txtIdCxC
            // 
            this.txtIdCxC.Location = new System.Drawing.Point(122, 43);
            this.txtIdCxC.MenuManager = this.ribbon;
            this.txtIdCxC.Name = "txtIdCxC";
            this.txtIdCxC.Properties.ReadOnly = true;
            this.txtIdCxC.Size = new System.Drawing.Size(100, 20);
            this.txtIdCxC.TabIndex = 6;
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(15, 46);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(33, 13);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "CxC ID";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Venta ID";
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Location = new System.Drawing.Point(122, 69);
            this.txtIdVenta.MenuManager = this.ribbon;
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Properties.ReadOnly = true;
            this.txtIdVenta.Size = new System.Drawing.Size(100, 20);
            this.txtIdVenta.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 98);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Cliente ID";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(122, 95);
            this.txtIdCliente.MenuManager = this.ribbon;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Properties.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 124);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Transacción ID";
            // 
            // txtTransaccionId
            // 
            this.txtTransaccionId.Location = new System.Drawing.Point(122, 121);
            this.txtTransaccionId.MenuManager = this.ribbon;
            this.txtTransaccionId.Name = "txtTransaccionId";
            this.txtTransaccionId.Properties.ReadOnly = true;
            this.txtTransaccionId.Size = new System.Drawing.Size(100, 20);
            this.txtTransaccionId.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 150);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Tipo Transacción ID";
            // 
            // txtTipoTransaccion
            // 
            this.txtTipoTransaccion.Location = new System.Drawing.Point(122, 147);
            this.txtTipoTransaccion.MenuManager = this.ribbon;
            this.txtTipoTransaccion.Name = "txtTipoTransaccion";
            this.txtTipoTransaccion.Properties.ReadOnly = true;
            this.txtTipoTransaccion.Size = new System.Drawing.Size(100, 20);
            this.txtTipoTransaccion.TabIndex = 14;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(18, 206);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 13);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(122, 199);
            this.txtBalance.MenuManager = this.ribbon;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Properties.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 18;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(17, 228);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(70, 13);
            this.labelControl7.TabIndex = 21;
            this.labelControl7.Text = "Monto recibido";
            // 
            // txtMontoRecibido
            // 
            this.txtMontoRecibido.Location = new System.Drawing.Point(122, 225);
            this.txtMontoRecibido.MenuManager = this.ribbon;
            this.txtMontoRecibido.Name = "txtMontoRecibido";
            this.txtMontoRecibido.Properties.ReadOnly = true;
            this.txtMontoRecibido.Size = new System.Drawing.Size(100, 20);
            this.txtMontoRecibido.TabIndex = 20;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(570, 46);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(75, 13);
            this.labelControl9.TabIndex = 25;
            this.labelControl9.Text = "Monto a abonar";
            // 
            // txtMontoAbornar
            // 
            this.txtMontoAbornar.Location = new System.Drawing.Point(675, 43);
            this.txtMontoAbornar.MenuManager = this.ribbon;
            this.txtMontoAbornar.Name = "txtMontoAbornar";
            this.txtMontoAbornar.Size = new System.Drawing.Size(100, 20);
            this.txtMontoAbornar.TabIndex = 24;
            this.txtMontoAbornar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoAbornar_KeyPress);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(570, 83);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(78, 13);
            this.labelControl10.TabIndex = 27;
            this.labelControl10.Text = "Fecha de abono";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(663, 153);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 19);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dtAbono
            // 
            this.dtAbono.EditValue = null;
            this.dtAbono.Location = new System.Drawing.Point(675, 76);
            this.dtAbono.MenuManager = this.ribbon;
            this.dtAbono.Name = "dtAbono";
            this.dtAbono.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtAbono.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtAbono.Size = new System.Drawing.Size(100, 20);
            this.dtAbono.TabIndex = 31;
            // 
            // txtActualizar
            // 
            this.txtActualizar.Location = new System.Drawing.Point(663, 121);
            this.txtActualizar.Name = "txtActualizar";
            this.txtActualizar.Size = new System.Drawing.Size(112, 19);
            this.txtActualizar.TabIndex = 33;
            this.txtActualizar.Text = "Actualizar";
            this.txtActualizar.Click += new System.EventHandler(this.txtActualizar_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(17, 176);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(53, 13);
            this.labelControl11.TabIndex = 36;
            this.labelControl11.Text = "Monto total";
            // 
            // txtMontoFinal
            // 
            this.txtMontoFinal.Location = new System.Drawing.Point(122, 173);
            this.txtMontoFinal.MenuManager = this.ribbon;
            this.txtMontoFinal.Name = "txtMontoFinal";
            this.txtMontoFinal.Properties.ReadOnly = true;
            this.txtMontoFinal.Size = new System.Drawing.Size(100, 20);
            this.txtMontoFinal.TabIndex = 35;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Grid = null;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 297);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Size = new System.Drawing.Size(1085, 222);
            this.gridSplitContainer1.TabIndex = 38;
            // 
            // gcCuentas
            // 
            this.gcCuentas.DataSource = typeof(Punto_Venta.Model.EF.Maestro_ctasxcobrar);
            this.gcCuentas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcCuentas.Location = new System.Drawing.Point(0, 277);
            this.gcCuentas.MainView = this.gvCuentas;
            this.gcCuentas.MenuManager = this.ribbon;
            this.gcCuentas.Name = "gcCuentas";
            this.gcCuentas.Size = new System.Drawing.Size(845, 197);
            this.gcCuentas.TabIndex = 38;
            this.gcCuentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCuentas});
            // 
            // gvCuentas
            // 
            this.gvCuentas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvCuentas.GridControl = this.gcCuentas;
            this.gvCuentas.Name = "gvCuentas";
            this.gvCuentas.OptionsBehavior.ReadOnly = true;
            this.gvCuentas.OptionsView.RowAutoHeight = true;
            this.gvCuentas.OptionsView.ShowAutoFilterRow = true;
            this.gvCuentas.OptionsView.ShowGroupPanel = false;
            this.gvCuentas.OptionsView.ShowViewCaption = true;
            this.gvCuentas.ViewCaption = "Cuentas por Cobrar";
            this.gvCuentas.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvCuentas_FocusedRowChanged);
            // 
            // FrmCxC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 474);
            this.Controls.Add(this.gcCuentas);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtMontoFinal);
            this.Controls.Add(this.txtActualizar);
            this.Controls.Add(this.dtAbono);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtMontoAbornar);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtMontoRecibido);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtTipoTransaccion);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtTransaccionId);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtIdVenta);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtIdCxC);
            this.Controls.Add(this.ribbon);
            this.Name = "FrmCxC";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.Text = "FrmCxC";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCxC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransaccionId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoTransaccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoRecibido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoAbornar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAbono.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAbono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.TextEdit txtIdCxC;
        private DevExpress.XtraEditors.LabelControl lbl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtIdVenta;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtIdCliente;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTransaccionId;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTipoTransaccion;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtBalance;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtMontoRecibido;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtMontoAbornar;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.DateEdit dtAbono;
        private DevExpress.XtraEditors.SimpleButton txtActualizar;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtMontoFinal;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl gcCuentas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCuentas;
    }
}