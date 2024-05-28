using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

using Punto_Venta.Model.EF;
using DevExpress.XtraPrinting.Native;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace Punto_Venta.Controller
{
    public class ClientController
    {
    private readonly Punto_ventasEntities dbContext;
        public ClientController() {
            dbContext = new Punto_ventasEntities();
        }

      
        public void AddClient (Maestro_Clientes newClient)
        {
            try
            {

                dbContext.Maestro_Clientes.Add(newClient);
                dbContext.SaveChanges();
                MessageBox.Show("Cliente agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message, "Error al agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void DeleteClient (int id_Cliente)
        {
            var clienteAEliminar = dbContext.Maestro_Clientes.FirstOrDefault(c => c.idCliente == id_Cliente);
            if (clienteAEliminar != null)
            {
                dbContext.Maestro_Clientes.Remove(clienteAEliminar);
                dbContext.SaveChanges();
            }
        }


        public bool ClientExists (int idCliente)
        {
            return dbContext.Maestro_Clientes.Any(c => c.idCliente == idCliente);
        }

        public void UpdateClient (int idCliente, string correoElectronico, string newNombre, string newDireccion, string newTelefono)
        {
            try
            {
                var clientToUpdate = dbContext.Maestro_Clientes.FirstOrDefault(c => c.idCliente == idCliente);
                if (clientToUpdate != null)
                {
                    clientToUpdate.nombre = newNombre;
                    clientToUpdate.direccion = newDireccion;
                    clientToUpdate.telefono = newTelefono;
                    clientToUpdate.correo = correoElectronico;
                    dbContext.SaveChanges();
                }
                else
                {
                   MessageBox.Show("Cliente no encontrado en la base de datos.","error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al actualizar el cliente: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
            }
        }


        public async void CheckCedula ( )
        {
            string url = "https://api.digital.gob.do/v3/cedulas/40233176326/validate";

            using (HttpClient client = new HttpClient())
            {
                // Configurar la solicitud
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);

                // Enviar la solicitud y obtener la respuesta
                HttpResponseMessage response = await client.SendAsync(request);

                // Manejar la respuesta
                if (response.IsSuccessStatusCode)
                {
                    // Procesar los datos de la respuesta
                    string content = await response.Content.ReadAsStringAsync();

                    JObject json = JObject.Parse(content);


                   }
                else
                {
                    // Manejar el error
                    Console.WriteLine("Error: " + response.StatusCode);
                }
            }
        }

    }
}
