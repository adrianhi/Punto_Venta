using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Punto_Venta.Model.EF;

namespace Punto_Venta.Controllers
{
    public class CategoryController
    {
        private readonly Punto_ventasEntities dbcontext;
        public CategoryController() { 
        
            dbcontext = new Punto_ventasEntities();
        }  


    public List<Categoria_productos> GetCategories(){
            return dbcontext.Categoria_productos.ToList();
        }


    public void AddCategory(Categoria_productos category)
        {
            dbcontext.Categoria_productos.Add(category);
            dbcontext.SaveChanges();
        }
    public void DeleteCategory(Categoria_productos category)
        {
           
            if (category != null)
            {
              
                dbcontext.Categoria_productos.Remove(category);
                dbcontext.SaveChanges();
            }
        }
public bool CategoryExists(int idCategoria)
        {
            return dbcontext.Categoria_productos.Any(c => c.Id_categoria == idCategoria);
        }

        public Categoria_productos GetCategoryById(int categoryId)
        {

            return dbcontext.Categoria_productos.Find(categoryId);
        }
        public void updateCategory(int idCategoria, string nuevoNombre, string nuevaDescripcion)
        {
            var categoriaAActualizar = dbcontext.Categoria_productos.FirstOrDefault(c => c.Id_categoria == idCategoria);
            if (categoriaAActualizar != null)
            {
                categoriaAActualizar.Nombre_categoria = nuevoNombre;
                categoriaAActualizar.Descripcion = nuevaDescripcion;
                dbcontext.SaveChanges();
            }
        }

    }
    

}
