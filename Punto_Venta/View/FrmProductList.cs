using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.XtraGrid.Views.Grid;
using Punto_Venta.Controllers;
using Punto_Venta.Model.EF;
using System;
using System.Windows.Forms;

namespace Punto_Venta.View
{
    public partial class FrmProductList : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly ProductController productController;
        public FrmProductList ( )
        {
            InitializeComponent();
            productController = new ProductController();
            gridViewProducts.FocusedRowChanged -= gridViewProducts_FocusedRowChanged;
            LoadData();
            gridViewProducts.FocusedRowChanged += gridViewProducts_FocusedRowChanged;
        }

        private int getCurrentRowId ( )
        {
            int rowIndex = gridViewProducts.FocusedRowHandle;

            int productId = Convert.ToInt32(gridViewProducts.GetRowCellValue(rowIndex, "Id_producto"));
            return productId;
        }
        private void LoadData ( )
        {
            var productList = productController.getList();

            gridControlProducts.DataSource = productList;
            gridViewProducts.Columns["Categoria_productos"].Visible = false;
            gridViewProducts.Columns["Detalles_ventas"].Visible = false;
            gridViewProducts.Columns["Maestro_ventas"].Visible = false;
        }
        private void ClearTextBox ( )
        {
            txtCodigoProducto.Text = "";
            txtNombreProducto.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtEstado.Text = "";
            txtExistencia.Text = "";
            txtStock.Text = "";
            txtIdCategoria.Text = "";
            btnAgregar.Enabled = true;
         
        }
        private void FillTextBox (Producto selectedProduct)
        {
            txtCodigoProducto.Text = selectedProduct.Codigo;
            txtNombreProducto.Text = selectedProduct.Nombre;
            txtPrecioCompra.Text = selectedProduct.Precio_compra.ToString();
            txtPrecioVenta.Text = selectedProduct.Precio_venta.ToString();
            txtEstado.Text = selectedProduct.Estado;
            txtExistencia.Text = selectedProduct.Existencia.ToString();
            txtStock.Text = selectedProduct.Stock.ToString();
            txtIdCategoria.Text = selectedProduct.Id_categoria.ToString();
        }

        //CRUD ACTIONS
        private void AddProduct ( )
        {
            Producto nuevoProducto = new Producto
            {
                Codigo = txtCodigoProducto.Text,
                Nombre = txtNombreProducto.Text,
                Precio_compra = Convert.ToDecimal(txtPrecioCompra.Text),
                Precio_venta = Convert.ToDecimal(txtPrecioVenta.Text),
                Estado = txtEstado.Text,
                Existencia = Convert.ToInt32(txtExistencia.Text),
                Stock = Convert.ToInt32(txtStock.Text),
                Id_categoria = Convert.ToInt32(txtIdCategoria.Text)
            };

            productController.AddProduct(nuevoProducto);
            LoadData();
            ClearTextBox();
            MessageBox.Show("Producto agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteProduct ( )
        {
            string codigoProducto = txtCodigoProducto.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigoProducto))
            {
                MessageBox.Show("Por favor, ingrese un código de producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!productController.ProductExist(codigoProducto))
            {
                MessageBox.Show("El producto con el código " + codigoProducto + " no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar el producto con el código " + codigoProducto + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                productController.DeleteProduct(codigoProducto);
                MessageBox.Show("Producto con el código " + codigoProducto + " eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearTextBox();
            }
            ClearTextBox();

        }

        private void UpdateProduct ( )
        {
            int productId = getCurrentRowId();
            string codigoProducto = txtCodigoProducto.Text;
            string nuevoNombre = txtNombreProducto.Text;
            decimal nuevoPrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
            decimal nuevoPrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            string nuevoEstado = txtEstado.Text;
            int nuevaExistencia = Convert.ToInt32(txtExistencia.Text);
            int nuevoStock = Convert.ToInt32(txtStock.Text);
            int nuevoIdCategoria = Convert.ToInt32(txtIdCategoria.Text);

            productController.updateProduct(productId, codigoProducto, nuevoNombre, nuevoPrecioCompra, nuevoPrecioVenta, nuevoEstado, nuevaExistencia, nuevoStock, nuevoIdCategoria);


           
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas actualizar el producto con el código " + codigoProducto + "?", "Confirmar actualizacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
            productController.updateProduct(productId, codigoProducto, nuevoNombre, nuevoPrecioCompra, nuevoPrecioVenta, nuevoEstado, nuevaExistencia, nuevoStock, nuevoIdCategoria);

                MessageBox.Show("Producto con el id " + productId + " actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
                LoadData();
            }

            ClearTextBox();



        }

        private void gridViewProducts_FocusedRowChanged (object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (sender is DevExpress.XtraGrid.Views.Grid.GridView gridView && gridView.FocusedRowHandle >= 0)
            {
                if (gridView.GetRow(e.FocusedRowHandle) is Producto selectedProduct)
                {
                   
                    

                    FillTextBox(selectedProduct);
                    btnAgregar.Enabled = false;
                    
                }
            }
        }

        private void txtLimpiar_Click (object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void btnAgregar_Click (object sender, EventArgs e)
        {
            AddProduct();
        }

        private void btnEliminar_Click (object sender, EventArgs e)
        {
            DeleteProduct();
        }
        private void btnActualizar_Click (object sender, EventArgs e)
        {
            UpdateProduct();
        }




    }
}