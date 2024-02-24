using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Punto_Venta.Model.EF;

namespace Punto_Venta.Controller
{
    public class ClientController
    {
    private readonly Punto_ventasEntities dbContext;
        public ClientController() {
            dbContext = new Punto_ventasEntities();
        }

        public List<Maestro_Cliente> getClients()
        {
            return dbContext.Maestro_Cliente.ToList();
        }
        public void AddClient (Maestro_Cliente newClient)
        {
            dbContext.Maestro_Cliente.Add(newClient);
            dbContext.SaveChanges();
        }

        public void DeleteClientByEmail (string correoElectronico)
        {
            var clienteAEliminar = dbContext.Maestro_Cliente.FirstOrDefault(c => c.CorreoElectronico == correoElectronico);
            if (clienteAEliminar != null)
            {
                dbContext.Maestro_Cliente.Remove(clienteAEliminar);
                dbContext.SaveChanges();
            }
        }


        public bool ClientExists (string correoElectronico)
        {
            return dbContext.Maestro_Cliente.Any(c => c.CorreoElectronico == correoElectronico);
        }

        public void UpdateClient (string correoElectronico, string newNombre, string newDireccion, string newTelefono)
        {
            var clientToUpdate = dbContext.Maestro_Cliente.FirstOrDefault(c => c.CorreoElectronico == correoElectronico);
            if (clientToUpdate != null)
            {
                clientToUpdate.Nombre = newNombre;
                clientToUpdate.Direccion = newDireccion;
                clientToUpdate.Telefono = newTelefono;
                clientToUpdate.CorreoElectronico = correoElectronico;
                dbContext.SaveChanges();
            }
        }

    }
}
