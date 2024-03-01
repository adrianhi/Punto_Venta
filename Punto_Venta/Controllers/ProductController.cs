using Punto_Venta.Model.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public List<int> GetCategoryIds ( )
        {
            // Get all categories
            var categories = dbContext.Categoria_productos.ToList();

            // Extract and return category IDs
            return categories.Select(c => c.Id_categoria).ToList();
        }
        public string GetProductCode (string codigoProducto)
        {
            string codigoActual = string.Empty;
            var producto = dbContext.Productos.FirstOrDefault(p => p.Codigo == codigoProducto);

            if (producto != null)
            {
                codigoActual = producto.Codigo;
            }

            return codigoActual;
        }
        public void AddProduct(Producto newProduct)
        {
            try
            {
                dbContext.Productos.Add(newProduct);
                dbContext.SaveChanges();
                MessageBox.Show("Producto agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e) { 
                MessageBox.Show(e.Message, "Error al agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public void DeleteProduct(int idProducto)
        {
            var productoAEliminar = dbContext.Productos.FirstOrDefault(p => p.Id_producto == idProducto);
            if (productoAEliminar != null)
            {
                dbContext.Productos.Remove(productoAEliminar);
                dbContext.SaveChanges();
            }
        }
        public bool ProductExist(int idProducto)
        {
            return dbContext.Productos.Any(p => p.Id_producto == idProducto);
        }

        public void UpdateProduct (int id_producto,string codigoProducto, string nuevoNombre, decimal nuevoPrecioCompra, decimal nuevoPrecioVenta, string nuevoEstado, int nuevaExistencia, int nuevoStock, int nuevoIdCategoria)
        {
            var productoActualizar = dbContext.Productos.FirstOrDefault(p => p.Id_producto== id_producto);
            if (productoActualizar != null)
            {
                productoActualizar.Codigo = codigoProducto;
                productoActualizar.Nombre = nuevoNombre;
                productoActualizar.Precio_compra = nuevoPrecioCompra;
                productoActualizar.Precio_venta = nuevoPrecioVenta;
                productoActualizar.Estado = nuevoEstado;
                productoActualizar.Existencia = nuevaExistencia;
                productoActualizar.Stock = nuevoStock;
                productoActualizar.Id_categoria = nuevoIdCategoria;

                // Guardar los cambios en la base de datos
                dbContext.SaveChanges();

                // Aquí puedes usar idProducto para cualquier operación necesaria con el ID antes de la actualización
            }
        }



    }
}
