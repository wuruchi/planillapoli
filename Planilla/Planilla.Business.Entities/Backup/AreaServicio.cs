//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Planilla.Business.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class AreaServicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AreaServicio()
        {
            this.Personals = new HashSet<Personal>();
        }
    
        public int IdAreaServicio { get; set; }
        public string CodAre { get; set; }
        public string Area { get; set; }
        public Nullable<byte> Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personal> Personals { get; set; }
    }
}