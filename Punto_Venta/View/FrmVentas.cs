using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Punto_Venta.Model.EF;
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



        private bool ClientExist ( )
        {
            if (!string.IsNullOrEmpty(txtCorreo.Text))
            {
                string correoCliente = txtCorreo.Text;
                if (!ventaController.ClientExist(correoCliente))
                {
                    MessageBox.Show("El cliente no existe. Por favor, agréguelo antes de procesar la venta.", "Cliente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }


        private (bool exists, decimal price) GetProductInfo (int productId)
        {
            return ventaController.ProductExist(productId);
        }

        private decimal CalculateTotalPrice (decimal unitPrice, int quantity)
        {
            return unitPrice * quantity;
        }

        private void ShowWarningMessage (string message)
        {
            MessageBox.Show(message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowSuccessMessage (string message)
        {
            MessageBox.Show(message, "Venta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ClearTextBox ( )
        {
            txtIdProducto.Clear();
            txtCantidadProducto.Clear();
            txtPrecioProducto.Clear();
            txtMontoPagar.Clear();
        }




        private void btnBuscar_Click (object sender, EventArgs e)
        {
            if (!ClientExist())
            {
                ShowWarningMessage("Cliente no encontrado. Por favor, agregue un cliente antes de procesar la venta.");
                return;
            }

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
            txtMontoPagar.Enabled = true;
        }

        private void btnProcesar_Click (object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(txtIdProducto.Text);
            int cantidad = Convert.ToInt32(txtCantidadProducto.Text);

            string precioProductoText = txtPrecioProducto.Text.Replace("$", "");
            decimal precioProducto = Convert.ToDecimal(precioProductoText);

            decimal montoTotal = cantidad * precioProducto;

            string correoCliente = txtCorreo.Text;
            bool updated = ventaController.ActualizarCantidadProducto(idProducto, cantidad);
            if (!updated)
            {
                ShowWarningMessage("Error al actualizar la cantidad en la base de datos.");
                return;
            }

            int idCliente=ventaController.FindClientID(correoCliente);
            Maestro_ventas nuevaVenta = new Maestro_ventas
            {
                Id_cliente = idCliente,
                Id_producto=idProducto,
                Monto_total=montoTotal,
                Fecha=DateTime.Now
            };


            ventaController.RealizarVenta(nuevaVenta);
            ClearTextBox();

        }


    }
}
