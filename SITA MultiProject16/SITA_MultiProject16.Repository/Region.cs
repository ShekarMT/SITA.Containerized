//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SITA_MultiProject16.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Region
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Region()
        {
            this.Airport = new HashSet<Airport>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string PrimaryRegionUrlription { get; set; }
        public string Description { get; set; }
        public string ServiceUrl { get; set; }
        public Nullable<int> FailoverRegion { get; set; }
        public string FailoverRegionUrl { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Airport> Airport { get; set; }
    }
}
