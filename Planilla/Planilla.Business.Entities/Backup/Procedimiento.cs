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
    
    public partial class Procedimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Procedimiento()
        {
            this.TablaAnalisis = new HashSet<TablaAnalisi>();
        }
    
        public int IdProcedimiento { get; set; }
        public string CodPro { get; set; }
        public string TipPro { get; set; }
        public string Procedimiento1 { get; set; }
        public Nullable<int> IdEspecialidad { get; set; }
        public string CodEsp { get; set; }
        public Nullable<decimal> PrecioProcedimiento { get; set; }
        public Nullable<decimal> MontoMedico { get; set; }
        public string Observacion { get; set; }
        public string ProImprimir { get; set; }
        public Nullable<int> IdAreaLaboratorio { get; set; }
        public string AreaLaboratorio { get; set; }
    
        public virtual AreaLaboratorio AreaLaboratorio1 { get; set; }
        public virtual Especialidad Especialidad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TablaAnalisi> TablaAnalisis { get; set; }
    }
}
