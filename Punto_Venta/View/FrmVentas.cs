using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Punto_Venta.Controller;
using Punto_Venta.Model.EF;
using Punto_Venta.View.Mdi;
using System;
using System.Windows.Forms;

namespace Punto_Venta.View
{
    public partial class FrmVentas : RibbonForm
    {
        private readonly VentaController ventaController;

        public FrmVentas ( )
        {
            InitializeComponent();
            ventaController = new VentaController();
            btnProcesar.Enabled = false;
            txtMontoPagar.Enabled = false;
        }

        /// <summary>
        /// Messages
        /// </summary>
        private void ShowWarningMessage (string message)
        {
            XtraMessageBox.Show(message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                ShowWarningMessage("Cliente no encontrado. Por favor, agregue un cliente antes de procesar la venta.");
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
                ShowWarningMessage("Producto no encontrado. Por favor, verifique el ID del producto.");
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


        private void ClearProductTextBox ( )
        {
            txtIdProducto.Clear();
            txtCantidadProducto.Clear();
            txtPrecioProducto.Clear();
            txtMontoPagar.Clear();
        }
/*
        private (bool exists, decimal price) GetProductInfo (int productId)
        {
            return ventaController.ProductExist(productId);
        }*/

        private decimal CalculateTotalPrice (decimal unitPrice, int quantity)
        {
            return unitPrice * quantity;
        }
        private void ClearTextBox ( )
        {
            txtIdProducto.Clear();
            txtCantidadProducto.Clear();
            txtPrecioProducto.Clear();
            txtMontoPagar.Clear();
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


        private void btnBuscar_Click (object sender, EventArgs e)
        {/*
            int productId;
            if (!int.TryParse(txtIdProducto.Text, out productId))
            {
                ShowWarningMessage("Por favor, ingrese un ID de producto válido.");
                return;
            }

            var productInfo = GetProductInfo(productId);
            if (!productInfo.exists)
            {
                ShowWarningMessage("El producto no existe. Por favor, agréguelo antes de procesar la venta.");
                return;
            }

            txtPrecioProducto.Text = productInfo.price.ToString("C");

            int quantity;
            if (!int.TryParse(txtCantidadProducto.Text, out quantity))
            {
                ShowWarningMessage("Por favor, ingrese una cantidad válida.");
                return;
            }

            decimal totalPrice = CalculateTotalPrice(productInfo.price, quantity);
            txtMontoPagar.Text = totalPrice.ToString("C");

            btnProcesar.Enabled = true;
            txtMontoPagar.Enabled = true;*/
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
                ShowWarningMessage("Error al actualizar la cantidad en la base de datos.");
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
        }

        private void btnSearchCedula_Click (object sender, EventArgs e)
        {
            CheckClient();
           
        }

        private void btnSearchProduct_Click (object sender, EventArgs e)
        {
            CheckProduct();
        }
    }
}
