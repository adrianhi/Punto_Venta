﻿using DevExpress.XtraBars;
using DevExpress.XtraEditors.ColorPick.Picker;
using System.Data.Entity;


namespace Punto_Venta.View
{
    public partial class FrmMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
       

        public FrmMenu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
           
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmCategoryList mdiCategoryList = new FrmCategoryList();
            mdiCategoryList.MdiParent = ActiveForm;
            mdiCategoryList.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmProductList mdiProductList = new FrmProductList();
            mdiProductList.MdiParent=ActiveForm;
            mdiProductList.Show();
        }

       

        private void barButtonItem3_ItemClick (object sender, ItemClickEventArgs e)
        {
            FrmClientList mdiClientList = new FrmClientList();
            mdiClientList.MdiParent = ActiveForm;
            mdiClientList.Show();
        }

        private void barButtonItem4_ItemClick (object sender, ItemClickEventArgs e)
        {
            FrmVentas frmVentas = new FrmVentas();
            frmVentas.MdiParent = ActiveForm;
            frmVentas.Show();
        }

        private void barButtonItem5_ItemClick (object sender, ItemClickEventArgs e)
        {
            FrmDetalleVentas frmDetalleVentas = new FrmDetalleVentas();
            frmDetalleVentas.MdiParent = ActiveForm;
            frmDetalleVentas.Show();
        }
    }
}