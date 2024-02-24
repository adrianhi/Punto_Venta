using Punto_Venta.Model.EF;
using Punto_Venta.Model;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System;
public class VentaController
{
    private readonly Punto_ventasEntities dbContext; 

    public VentaController ()
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

    public bool ClientExist(string correo)
    {
        var client = dbContext.Maestro_Cliente.FirstOrDefault(c => c.CorreoElectronico == correo);
        return client !=null;
    }

    

}
