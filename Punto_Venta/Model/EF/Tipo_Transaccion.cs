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
    
    public partial class Tipo_Transaccion
    {
        public int Id_TipoTransaccion { get; set; }
        public string Descripcion { get; set; }
        public bool EsCredito { get; set; }
        public Nullable<bool> Fact_Credito { get; set; }
        public Nullable<bool> Fact_contado { get; set; }
        public Nullable<bool> Recibo_Cobro { get; set; }
    }
}
