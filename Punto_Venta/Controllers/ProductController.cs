using Punto_Venta.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_Venta.Controllers
{
    internal class ProductController
    {
        private readonly Punto_ventasEntities dbContext;
        public ProductController()  {
            dbContext = new Punto_ventasEntities();
        }
        public List<Producto> getList()
        {
            return dbContext.Productos.ToList();
        }
        public void AddProduct(Producto nuevoProducto)
        {
            dbContext.Productos.Add(nuevoProducto);
            dbContext.SaveChanges();
        }
        public void DeleteProduct(string codigoProducto)
        {
            var productoAEliminar = dbContext.Productos.FirstOrDefault(p => p.Codigo == codigoProducto);
            if (productoAEliminar != null)
            {
                dbContext.Productos.Remove(productoAEliminar);
                dbContext.SaveChanges();
            }
        }
        public bool ProductExist(string codigoProducto)
        {
            return dbContext.Productos.Any(p => p.Codigo == codigoProducto);
        }
        public void UpdateProduct(string codigoProducto, string nuevoNombre, decimal nuevoPrecioCompra, decimal nuevoPrecioVenta, string nuevoEstado, int nuevaExistencia, int nuevoStock, int nuevoIdCategoria)
        {
            var productoActualizar = dbContext.Productos.FirstOrDefault(p => p.Codigo == codigoProducto);
            if (productoActualizar != null)
            {
                productoActualizar.Nombre = nuevoNombre;
                productoActualizar.Precio_compra = nuevoPrecioCompra;
                productoActualizar.Precio_venta = nuevoPrecioVenta;
                productoActualizar.Estado = nuevoEstado;
                productoActualizar.Existencia = nuevaExistencia;
                productoActualizar.Stock = nuevoStock;
                productoActualizar.Id_categoria = nuevoIdCategoria;
                dbContext.SaveChanges();
            }
        }


    }
}
