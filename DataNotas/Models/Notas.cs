//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataNotas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Notas()
        {
            this.CompraNotasCatalogos = new HashSet<CompraNotasCatalogos>();
        }
    
        public int id { get; set; }
        public decimal Total { get; set; }
        public System.DateTime FechaCompra { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompraNotasCatalogos> CompraNotasCatalogos { get; set; }
    }
}