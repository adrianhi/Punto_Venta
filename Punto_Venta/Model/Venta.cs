using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_Venta.Model
{
    public class Venta
    {
        public int IdCliente { get; set; }
        public decimal MontoTotal { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal SubTotal { get; set; }
    }

}
