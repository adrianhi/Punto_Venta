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
    
    public partial class Maestro_ventas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Maestro_ventas()
        {
            this.Detalles_ventas = new HashSet<Detalles_ventas>();
            this.Maestro_ctasxcobrar = new HashSet<Maestro_ctasxcobrar>();
        }
    
        public int Id_venta { get; set; }
        public Nullable<int> Id_cliente { get; set; }
        public Nullable<int> Id_producto { get; set; }
        public Nullable<decimal> Monto_total { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalles_ventas> Detalles_ventas { get; set; }
        public virtual Maestro_Cliente Maestro_Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maestro_ctasxcobrar> Maestro_ctasxcobrar { get; set; }
        public virtual Producto Producto { get; set; }
    }
}