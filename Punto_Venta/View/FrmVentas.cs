using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Punto_Venta.Controllers;
using Punto_Venta.Model.EF;
using Punto_Venta.View.Mdi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Punto_Venta.View
{
    public partial class FrmVentas : RibbonForm
    {
        private readonly VentaController ventaController;
        private readonly CxcController cxcController;
        public FrmVentas ( )
        {
            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor;
            ventaController = new VentaController();
            cxcController=new CxcController(); 
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

        //Clear
        private void ClearTextBox ( )
        {
            txtNombreCliente.Clear();
            txtCedula.Clear();
            txtIdCliente.Clear();
            txtIdProducto.Clear();
            txtNombreProducto.Clear();
            txtCantidadProducto.Clear();
            txtPrecioProducto.Clear();
            txtExistenciaProducto.Clear();
            txtMontoPagar.Clear();
            txtMontoRecibido.Clear();
            txtMontoDevolver.Clear();
            ChkCredito.Checked = false;
            dateEdit1.DateTime = DateTime.Now;
        }
        private void ClearProducts ( )
        {
            txtIdProducto.Clear();
            txtNombreProducto.Clear();
            txtCantidadProducto.Clear();
            txtPrecioProducto.Clear();
            txtExistenciaProducto.Clear();
        }
        private void ClearAllFields ( )
        {
            ClearTextBox();
            ClearDataGridView();
        }

        private void ClearDataGridView ( )
        {
            dgvVentas.Rows.Clear();
            CalcularTotal();
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
            int idCliente = mdiClientes.idClienteSeleccionado;

            // Mostrar los valores en los TextBoxes
            txtCedula.Text = cedula;
            txtNombreCliente.Text = nombre;
            txtIdCliente.Text = idCliente.ToString();
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
            int stock = mdiProductos.ExistenciaSeleccionado;

            // Show the values in the text boxes
            txtIdProducto.Text = id.ToString();
            txtNombreProducto.Text = nombre;
            txtPrecioProducto.Text = precio.ToString();
            txtExistenciaProducto.Text = stock.ToString();
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
                txtIdCliente.Text = "";
                return;
            }

            var clientData = (dynamic)clientInfo;
            txtCedula.Text = clientData.Cedula;
            txtNombreCliente.Text = clientData.Nombre;
            txtIdCliente.Text = clientData.idCliente;
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
                txtExistenciaProducto.Text = "";
                return;
            }

            var productData = (dynamic)productInfo;
            txtNombreProducto.Text = productData.Nombre;
            txtPrecioProducto.Text = productData.Precio.ToString();
            txtExistenciaProducto.Text = productData.Existencia.ToString();
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




        //Products values checks
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

        private void CalculateChange (decimal subtotal)
        {
            decimal amountReceived;
            if (!decimal.TryParse(txtMontoRecibido.Text, out amountReceived))
            {
                ShowErrorMessage("La cantidad recibida no es un número válido.");
                return;
            }

            if (ChkCredito.Checked)
            {
                
                decimal change = amountReceived - subtotal;
                txtMontoDevolver.Text = Math.Max(change, 0).ToString();
                btnProcesar.Select();
            }
            else
            {
               
                if (amountReceived >= subtotal)
                {
                    decimal change = amountReceived - subtotal;
                    txtMontoDevolver.Text = Math.Max(change, 0).ToString(); 
                }
                else
                {
                   
                    ShowErrorMessage("La cantidad recibida es insuficiente para completar la transacción.");
                }
            }
        }



        private bool CheckProductQuantity ( )
        {
            int Existence;
            if (!int.TryParse(txtExistenciaProducto.Text, out Existence))
            {
                ShowErrorMessage("El valor de la existencia no es un número válido.");
                return false;
            }

            int selectedQuantity = (int)txtCantidadProducto.Value;

            if (selectedQuantity > Existence)
            {
                ShowErrorMessage("La cantidad seleccionada supera los productos disponibles disponible.");
                return false;
            }

            return true;
        }




        //Validate
        private bool ValidateFields ( )
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                ShowErrorMessage("Por favor, complete todos los campos obligatorios.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMontoRecibido.Text))
            {
                ShowErrorMessage("Por favor, ingrese el monto recibido.");
                return false;
            }
            return true;
        }

        private void ValidateNumericInput (TextEdit textBox, KeyPressEventArgs e)
        {
            // Permitir solo números, punto decimal y tecla retroceso.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }

            // Si ya hay un punto decimal, no permitir otro.
            if (e.KeyChar == '.' && textBox.Text.Contains('.'))
            {
                e.Handled = true;
                return;
            }

            // Si se ha introducido el número máximo de caracteres, no permitir más.
            if (textBox.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Si el cursor está al principio, no permitir un punto decimal.
            if (textBox.SelectionStart == 0 && e.KeyChar == '.')
            {
                e.Handled = true;
                return;
            }
        }

        private bool ValidarMontos ( )
        {
            decimal montoPagar;
            decimal montoRecibido;

            // Validar que los campos de monto existan y puedan ser convertidos a decimal
            if (!decimal.TryParse(txtMontoPagar.Text, out montoPagar) || !decimal.TryParse(txtMontoRecibido.Text, out montoRecibido))
            {
                XtraMessageBox.Show("Ingrese montos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Retornar false si no se pueden convertir los montos
            }

            // Validar que el monto recibido sea suficiente para cubrir el monto a pagar
            if (montoRecibido < montoPagar)
            {
                XtraMessageBox.Show("El monto recibido es menor que el monto a pagar. No se puede procesar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void IsCredit (bool EsCredito, DateTime fecha)
        {
            decimal montoPagar = Convert.ToDecimal(txtMontoPagar.Text);
            decimal montoRecibido = Convert.ToDecimal(txtMontoRecibido.Text);

            if (EsCredito && montoRecibido < montoPagar)
            {
                AddSale(EsCredito, fecha, true);
                XtraMessageBox.Show("Se generará una venta a crédito porque el monto recibido es menor al monto total a pagar.", "Venta a crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!EsCredito && montoRecibido < montoPagar)
            {
                XtraMessageBox.Show("El monto recibido es insuficiente para completar la transacción.", "Monto insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddSale(EsCredito, fecha, false);
                ClearAllFields();
                txtCedula.Select();
            }
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



        //CRUD
        private void AddSale (bool EsCredito, DateTime fecha, bool IsCxC)
        {
            string tipoTransaccionDescripcion = InsertarTipoTransaccion(EsCredito);
            if (tipoTransaccionDescripcion == null)
            {
                return;
            }

            Tipo_Transaccion tipoTransaccion = new Tipo_Transaccion
            {
                Descripcion = tipoTransaccionDescripcion,
                EsCredito = EsCredito
            };

            Maestro_ventas nuevaVenta = CreateVentaObject(fecha);
            List<Detalles_ventas> detallesVenta = CreateDetallesVentaList(fecha);

            ventaController.AddVenta(nuevaVenta, detallesVenta, tipoTransaccion, IsCxC);

            foreach (var detalle in detallesVenta)
            {
                ventaController.UpdateProductExistence((int)detalle.Id_producto, (int)detalle.Cantidad);
            }

            ClearAllFields();
            txtIdProducto.Select();
        }


        private string InsertarTipoTransaccion (bool esCredito)
        {
            // Obtener la descripción del tipo de transacción
            string tipoTransaccionDescripcion = esCredito ? "Venta con crédito" : "Venta contado";

            // Si la transacción es a crédito, no se requiere validar los montos
            if (!esCredito)
            {
                // Validar los montos y mostrar un mensaje de error si no son válidos
                if (!ValidarMontos())
                {
                    return null;
                }
            }

            return tipoTransaccionDescripcion;
        }

    

        private Maestro_ventas CreateVentaObject (DateTime fechaSeleccionada)
        {
            int clienteId = Convert.ToInt32(txtIdCliente.Text);
            decimal montoTotal = Convert.ToDecimal(txtMontoPagar.Text);
            decimal montoRecibido = Convert.ToDecimal(txtMontoRecibido.Text);

            return new Maestro_ventas
            {
                Id_cliente = clienteId,
                Monto_total = montoTotal,
                Monto_recibido = montoRecibido,
                Fecha = fechaSeleccionada
            };
        }

        private List<Detalles_ventas> CreateDetallesVentaList (DateTime fecha)
        {
            List<Detalles_ventas> detallesVenta = new List<Detalles_ventas>();

            foreach (DataGridViewRow fila in dgvVentas.Rows)
            {
                if (fila.Cells["IdProducto"].Value != null && !string.IsNullOrWhiteSpace(fila.Cells["IdProducto"].Value.ToString()))
                {
                    int idProducto = Convert.ToInt32(fila.Cells["IdProducto"].Value);
                    int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    decimal precioVenta = Convert.ToDecimal(fila.Cells["precioProducto"].Value);

                    Detalles_ventas detalleVenta = new Detalles_ventas
                    {
                        Id_producto = idProducto,
                        Cantidad = cantidad,
                        Precio_venta = precioVenta,
                        Fecha = fecha
                    };

                    detallesVenta.Add(detalleVenta);
                }
            }

            return detallesVenta;
        }


        //Actions
        private void btnProcesar_Click (object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }
            bool EsCredito = ChkCredito.Checked;
            DateTime fecha = dateEdit1.DateTime;
            IsCredit(EsCredito, fecha);
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
            bool IsValid=CheckProductQuantity();
            int productId = Convert.ToInt32(txtIdProducto.Text);
            string productName = txtNombreProducto.Text;
            int quantity = Convert.ToInt32(txtCantidadProducto.Value);
            decimal price = Convert.ToDecimal(txtPrecioProducto.Text);
            ClearProducts();
            btnProcesar.Enabled = true;
            btnEliminar.Enabled = true;
            if (IsValid)
            {
                if (dgvProductExists(productId))
                {
                    UpdateProduct(productId, quantity);
                }
                else
                {
                    AddNewProduct(productId, productName, price, quantity);
                }

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
                txtExistenciaProducto.Text = stockQuantity.ToString();
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
                        CalcularTotal();
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
            ValidateNumericInput(txtIdProducto, e);
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
                txtIdProducto.Select();
            }
        }

        private void txtMontoRecibido_KeyPress (object sender, KeyPressEventArgs e)
        {
            ValidateNumericInput(txtMontoRecibido, e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(txtMontoPagar.Text))
                {
                    CalculateChange(Convert.ToDecimal(txtMontoPagar.Text));
                }
                
            }
        }

       
    }
}
