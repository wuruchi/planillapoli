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
    
    public partial class TablaAnalisi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TablaAnalisi()
        {
            this.TablaAnalisisVRs = new HashSet<TablaAnalisisVR>();
        }
    
        public int IdAnalisis { get; set; }
        public string CodAna { get; set; }
        public string Analisis { get; set; }
        public string Unidad { get; set; }
        public string Titulo { get; set; }
        public Nullable<int> IdProcedimiento { get; set; }
        public string CodPro { get; set; }
        public string Procedimiento { get; set; }
        public string AreaLaboratorio { get; set; }
        public string AreaAnalisis { get; set; }
        public string TituloPerfil { get; set; }
    
        public virtual Procedimiento Procedimiento1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TablaAnalisisVR> TablaAnalisisVRs { get; set; }
    }
}
