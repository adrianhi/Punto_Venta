//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Punto_Venta.Model.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaccione
    {
        public int Id_Transaccion { get; set; }
        public Nullable<int> Id_Venta { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> Tipo_transaccion_id { get; set; }
        public Nullable<decimal> Total { get; set; }
    }
}
