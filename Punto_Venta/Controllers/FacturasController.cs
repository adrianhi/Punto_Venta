using Punto_Venta.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_Venta.Controllers
{
    public class FacturasController
    {
        private readonly Punto_ventasEntities context;

        public FacturasController ( )
        {
            context = new Punto_ventasEntities();
        }

        public void CreateFactura (Maestro_ventas venta, string EstadoFactura)
        {
            Factura nuevaFactura = new Factura
            {
                Id_Venta = venta.Id_venta,
                Id_TipoTransaccion = venta.Id_TipoTransaccion ?? 0,
                Id_Transaccion = venta.Id_Transaccion,
                FechaEmision = venta.Fecha.Value,
                Id_Cliente = venta.Id_cliente ?? 0,
                Total = venta.Monto_total ?? 0,
                Total_Pagado = venta.Monto_recibido ?? 0,
                EstadoPago = EstadoFactura
            };

           
            context.Facturas.Add(nuevaFactura);
            context.SaveChanges();
        }


    }
}
