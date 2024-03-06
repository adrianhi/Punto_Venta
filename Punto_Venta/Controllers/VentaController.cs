using Punto_Venta.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Punto_Venta.Controllers;

public class VentaController
{
    private readonly Punto_ventasEntities dbContext;
    private readonly TransactionController transactionController;

    public VentaController ( )
    {
        dbContext = new Punto_ventasEntities();
        transactionController = new TransactionController();
    }

    public object ProductExist (int idProducto)
    {
        var product = dbContext.Productos.FirstOrDefault(p => p.Id_producto == idProducto);

        return product != null ? new { Nombre = product.Nombre, Precio = product.Precio_venta ?? 0, Existencia = product.Existencia } : null;
    }

    public object GetClientInfo (string cedula)
    {
        var client = dbContext.Maestro_Clientes.FirstOrDefault(c => c.cedula == cedula);

        return client != null ? new { Cedula = client.cedula, Nombre = client.nombre, Correo = client.correo } : null;
    }


    public int GetStockForProduct (int productId)
    {
        var product = dbContext.Productos.FirstOrDefault(p => p.Id_producto == productId);
        return product != null ? (int)product.Stock : 0;
    }

    public void AddVenta (Maestro_ventas newVenta, List<Detalles_ventas> detallesVenta, Tipo_Transaccion Tipo_Transaccion)
    {
        try
        {
            int idTipoTransaccion = transactionController.InsertTransactionType(Tipo_Transaccion, false);
            newVenta.Id_TipoTransaccion = idTipoTransaccion;
            dbContext.Maestro_ventas.Add(newVenta);
            dbContext.SaveChanges();

            int idVenta = newVenta.Id_venta; 
            int transactionId = transactionController.InsertTrasaction(idVenta, newVenta.Fecha.Value, idTipoTransaccion, newVenta.Monto_total.Value);
            newVenta.Id_Transaccion = transactionId;
            dbContext.SaveChanges();

            foreach (var detalle in detallesVenta)
            {
                detalle.Id_Transaccion = transactionId;
                detalle.Id_TipoTransaccion = idTipoTransaccion;
            }

            AddDetalleVenta(detallesVenta, idVenta);

            XtraMessageBox.Show("Venta agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            XtraMessageBox.Show($"Error al agregar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void AddDetalleVenta (List<Detalles_ventas> detallesVenta, int idVenta)
    {
        try
        {
            foreach (var detalle in detallesVenta)
            {
                detalle.Id_venta = idVenta;
                dbContext.Detalles_ventas.Add(detalle);
            }
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            XtraMessageBox.Show($"Error al agregar los detalles de la venta: {ex.Message}");
        }
    }

    public void UpdateProductExistence (int productId, int quantitySold)
    {
        try
        {
            Producto producto = dbContext.Productos.FirstOrDefault(p => p.Id_producto == productId);

            if (producto != null)
            {
                if (producto.Existencia >= quantitySold)
                {
                    producto.Existencia -= quantitySold;
                    if (producto.Existencia == 0)
                    {
                        producto.Estado = "No disponible";
                    }
                    dbContext.SaveChanges();
                }
                else
                {
                    XtraMessageBox.Show("La cantidad vendida es mayor que la existencia del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("El producto no fue encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            XtraMessageBox.Show("Error al actualizar la existencia del producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
