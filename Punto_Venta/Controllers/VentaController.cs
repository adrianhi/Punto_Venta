using Punto_Venta.Model.EF;
using Punto_Venta.Model;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System;
using System.Windows.Forms;
public class VentaController
{
    private readonly Punto_ventasEntities dbContext;

    public VentaController ( )
    {
        dbContext = new Punto_ventasEntities();
    }


    public object ProductExist (int idProducto)
    {
        var product = dbContext.Productos.FirstOrDefault(p => p.Id_producto == idProducto);

        if (product != null)
        {
            return new { Nombre = product.Nombre, Precio = product.Precio_venta ?? 0, Stock = product.Stock };
        }
        else
        {
            MessageBox.Show("Producto no encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return null;
        }
    }

    public object GetClientInfo (string cedula)
    {
        var client = dbContext.Maestro_Clientes.FirstOrDefault(c => c.cedula == cedula);

        if (client != null)
        {
            return new { Cedula = client.cedula, Nombre = client.nombre, Correo = client.correo };
        }
        else
        {
            MessageBox.Show("Cliente no encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return null;
        }
    }

    public bool ActualizarCantidadProducto (int idProducto, int cantidadVendida)
    {


        var producto = dbContext.Productos.FirstOrDefault(p => p.Id_producto == idProducto);

        if (producto != null)
        {
            // Restar la cantidad vendida a la existencia del producto
            producto.Existencia -= cantidadVendida;

            // Guardar los cambios en la base de datos
            dbContext.SaveChanges();

            // La actualización fue exitosa
            return true;
        }
        else
        {
            // El producto no fue encontrado
            return false;
        }

    }

    public bool RealizarVenta (Maestro_ventas venta)
    {
        try
        {
            dbContext.Maestro_ventas.Add(venta); // Agrega la venta al contexto de Entity Framework
            dbContext.SaveChanges(); // Guarda los cambios en la base de datos
            return true; // La venta se realizó con éxito
        }
        catch (Exception ex)
        {
            // Manejo de errores
            Console.WriteLine("Error al realizar la venta: " + ex.Message);
            return false; // La venta falló
        }
    }

}
