using Punto_Venta.Model.EF;
using Punto_Venta.Model;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System;
public class VentaController
{
    private readonly Punto_ventasEntities dbContext;

    public VentaController ( )
    {
        dbContext = new Punto_ventasEntities();
    }


    public (bool exists, decimal price) ProductExist (int idProducto)
    {
        var product = dbContext.Productos.Find(idProducto);
        if (product != null)
        {
            return (true, product.Precio_venta ?? 0);
        }
        else
        {
            return (false, 0);
        }
    }

    public bool ClientExist (string correo)
    {
        var client = dbContext.Maestro_Cliente.FirstOrDefault(c => c.CorreoElectronico == correo);
        return client != null;
    }
    public int FindClientID (string correoCliente)
    {
        try
        {

            var cliente = dbContext.Maestro_Cliente.FirstOrDefault(c => c.CorreoElectronico == correoCliente);


            if (cliente != null)
            {
                return cliente.Id_cliente;
            }
            else
            {

                return -1;
            }
        }
        catch (Exception ex)
        {

            Console.WriteLine("Error al buscar el ID del cliente: " + ex.Message);
            return -1;
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
