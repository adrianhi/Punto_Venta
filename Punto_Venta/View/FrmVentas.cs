using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Punto_Venta.Controller;
using Punto_Venta.Model.EF;
using Punto_Venta.View.Mdi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Punto_Venta.View
{
    public partial class FrmVentas : RibbonForm
    {
        private readonly VentaController ventaController;
        private DataTable dt = new DataTable();

        public FrmVentas ( )
        {
            InitializeComponent();
            ventaController = new VentaController();
            txtCedula.Select();
            btnProcesar.Enabled = false;
            txtMontoPagar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        /// <summary>
        /// Messages
        /// </summary>
        private void ShowErrorMessage (string message)
        {
            XtraMessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowSuccessMessage (string message)
        {
            XtraMessageBox.Show(message, "Venta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        ///MDI
        private void openMdiClients ( )
        {
            // Crear una instancia del formulario mdiClients
            mdiClients mdiClientes = new mdiClients();

            // Mostrar el formulario
            mdiClientes.ShowDialog();

            // Acceder a los valores seleccionados después de cerrar el formulario
            string cedula = mdiClientes.CedulaSeleccionada;
            string nombre = mdiClientes.NombreSeleccionado;
            string correo = mdiClientes.CorreoSeleccionado;

            // Mostrar los valores en los TextBoxes
            txtCedula.Text = cedula;
            txtNombreCliente.Text = nombre;
            txtCorreo.Text = correo;
        }
        private void openMdiProducts ( )
        {
            // Create an instance of the mdiProducts form
            mdiProducts mdiProductos = new mdiProducts();

            // Show the form
            mdiProductos.ShowDialog();

            // Access the selected values after closing the form
            int id = mdiProductos.IdSeleccionado;
            string nombre = mdiProductos.NombreSeleccionado;
            decimal precio = mdiProductos.PrecioSeleccionado;
            int stock = mdiProductos.StockSeleccionado;

            // Show the values in the text boxes
            txtIdProducto.Text = id.ToString();
            txtNombreProducto.Text = nombre;
            txtPrecioProducto.Text = precio.ToString();
            txtStockProducto.Text = stock.ToString();
        }

        /// <summary>
        /// Actions
        /// </summary>
        //Clients
        private void CheckClient ( )
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                openMdiClients();
            }
            else
            {
                CheckClientExistence();
            }
        }
        private void CheckClientExistence ( )
        {
            var clientInfo = ClientExist(txtCedula.Text);
            if (clientInfo == null)
            {
                ShowErrorMessage("Cliente no encontrado. Por favor, agregue un cliente antes de procesar la venta.");
                txtNombreCliente.Text = "";
                txtCorreo.Text = "";
                return;
            }

            var clientData = (dynamic)clientInfo;
            txtCedula.Text = clientData.Cedula;
            txtNombreCliente.Text = clientData.Nombre;
            txtCorreo.Text = clientData.Correo;
        }
        //Products

        //BD Checks
        private void CheckProduct ( )
        {
            if (string.IsNullOrWhiteSpace(txtIdProducto.Text))
            {
                openMdiProducts();
            }
            else
            {
                CheckProductExistence();
            }


        }
        private void CheckProductExistence ( )
        {
            var productInfo = ProductExist(Convert.ToInt32(txtIdProducto.Text));

            if (productInfo == null || productInfo.ToString() == "Producto no encontrado")
            {
                ShowErrorMessage("Producto no encontrado. Por favor, verifique el ID del producto.");
                txtNombreProducto.Text = "";
                txtPrecioProducto.Text = "";
                txtStockProducto.Text = "";
                return;
            }

            var productData = (dynamic)productInfo;
            txtNombreProducto.Text = productData.Nombre;
            txtPrecioProducto.Text = productData.Precio.ToString();
            txtStockProducto.Text = productData.Stock.ToString();
        }

        //dvg Actions
        private bool dgvProductExists (int productId)
        {
            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                if (row.Cells["IdProducto"].Value != null && Convert.ToInt32(row.Cells["IdProducto"].Value) == productId)
                {
                    return true;
                }
            }
            return false;
        }

        private void UpdateProduct (int productId, int quantity)
        {
            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                if (row.Cells["IdProducto"].Value != null && Convert.ToInt32(row.Cells["IdProducto"].Value) == productId)
                {
                    int currentQuantity = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    row.Cells["Cantidad"].Value = currentQuantity + quantity;
                    row.Cells["SubTotal"].Value = (currentQuantity + quantity) * Convert.ToDecimal(row.Cells["precioProducto"].Value);
                    break;
                }
            }
        }

        private void AddNewProduct (int productId, string productName, decimal price, int quantity)
        {
            dgvVentas.Rows.Add(new object[]
            {
        productId.ToString(),
        productName,
        price.ToString(),
        quantity.ToString(),
        (quantity * price).ToString()
            });
            CalcularTotal();
        }





        private void CalcularTotal ( )
        {
            decimal total = 0;

            // Recorrer todas las filas del DataGridView
            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                // Verificar si el valor de la celda no es null antes de intentar convertirlo y sumarlo al total
                if (row.Cells["SubTotal"].Value != null)
                {
                    decimal subtotal;
                    // Intentar convertir el valor de la celda a decimal
                    if (decimal.TryParse(row.Cells["SubTotal"].Value.ToString(), out subtotal))
                    {
                        // Sumar el subtotal al total
                        total += subtotal;
                    }
                
                }
                
            }

            // Mostrar el total en el TextBox txtMontoPagar
            txtMontoPagar.Text = total.ToString();
        }

        private void checkQuantity ( )
        {
            int stockQuantity;
            if (!int.TryParse(txtStockProducto.Text, out stockQuantity))
            {
                ShowErrorMessage("El valor del stock no es un número válido.");
                return;
            }

            int selectedQuantity = (int)txtCantidadProducto.Value;

            if (stockQuantity < selectedQuantity)
            {
                ShowErrorMessage("La cantidad no puede ser mayor al stock.");
                return;
            }
        }

        private void ClearTextBox ( )
        {
            txtNombreCliente.Clear();
            txtCedula.Clear();
            txtCorreo.Clear();
            txtIdProducto.Clear();
            txtNombreProducto.Clear();
            txtCantidadProducto.Clear();
            txtPrecioProducto.Clear();
            txtStockProducto.Clear();
        }
        private void ClearProducts( )
        {
            txtNombreCliente.Clear();
            txtCedula.Clear();
            txtCorreo.Clear();
            txtIdProducto.Clear();
            txtNombreProducto.Clear();
            txtCantidadProducto.Clear();
            txtPrecioProducto.Clear();
            txtStockProducto.Clear();
        }


        //DB checks
        private object ClientExist (string cedula)
        {
            return ventaController.GetClientInfo(cedula);
        }
        private object ProductExist (int idProducto)
        {
            return ventaController.ProductExist(idProducto);
        }


       


        private void btnProcesar_Click (object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(txtIdProducto.Text);
            int cantidad = Convert.ToInt32(txtCantidadProducto.Text);
            decimal precioProducto = Convert.ToDecimal(txtPrecioProducto.Text, System.Globalization.CultureInfo.CurrentCulture);
            decimal montoTotal = cantidad * precioProducto;
            string correoCliente = txtCedula.Text;
            bool updated = ventaController.ActualizarCantidadProducto(idProducto, cantidad);
            if (!updated)
            {
                ShowErrorMessage("Error al actualizar la cantidad en la base de datos.");
                return;
            }

            Maestro_ventas nuevaVenta = new Maestro_ventas
            {
                // Id_cliente = ventaController.FindClientID(correoCliente),
                Id_producto = idProducto,
                Monto_total = montoTotal,
                Fecha = DateTime.Now
            };

            ventaController.RealizarVenta(nuevaVenta);
            ClearTextBox();
            txtIdProducto.Select();
        }

        private void btnSearchCedula_Click (object sender, EventArgs e)
        {
            CheckClient();
           
        }

        private void btnSearchProduct_Click (object sender, EventArgs e)
        {
            CheckProduct();
        }



        private void btnAgregar_Click (object sender, EventArgs e)
        {
            checkQuantity();
            int productId = Convert.ToInt32(txtIdProducto.Text);
            string productName = txtNombreProducto.Text;
            int quantity = Convert.ToInt32(txtCantidadProducto.Value);
            decimal price = Convert.ToDecimal(txtPrecioProducto.Text);

            ClearProducts();

            if (dgvProductExists(productId))
            {
                UpdateProduct(productId, quantity);
            }
            else
            {
                AddNewProduct(productId, productName, price, quantity);
            }
        }

        
        private void dgvVentas_CellDoubleClick (object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row is double-clicked
            {
                DataGridViewRow selectedRow = dgvVentas.Rows[e.RowIndex];

                // Retrieve information from the selected row
                string productId = selectedRow.Cells["IdProducto"].Value.ToString();
                string productName = selectedRow.Cells["Producto"].Value.ToString();
                string price = selectedRow.Cells["precioProducto"].Value.ToString();
                string quantity = selectedRow.Cells["Cantidad"].Value.ToString();

                int stockQuantity = ventaController.GetStockForProduct(Convert.ToInt32(productId));
                // Populate the product text boxes with the retrieved information
                txtIdProducto.Text = productId;
                txtNombreProducto.Text = productName;
                txtPrecioProducto.Text = price;
                txtCantidadProducto.Text = quantity;
                txtStockProducto.Text = stockQuantity.ToString();
                btnEliminar.Enabled = true;
            }
        }

        private void btnEliminar_Click (object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                int productIdToDelete = Convert.ToInt32(dgvVentas.SelectedRows[0].Cells["IdProducto"].Value);

                foreach (DataGridViewRow row in dgvVentas.Rows)
                {
                    if (row.Cells["IdProducto"].Value != null && Convert.ToInt32(row.Cells["IdProducto"].Value) == productIdToDelete)
                    {
                        dgvVentas.Rows.Remove(row);
                        ClearProducts();
                        break;
                    }
                }
            }
            else
            {
                ShowErrorMessage("Por favor, seleccione una fila para eliminar.");
            }
        }

        private void txtIdProducto_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                CheckProduct();
            }
        }

        private void txtCedula_KeyPress (object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == (char)Keys.Enter)
            {
                CheckClient();
            }
        }
    }
}
