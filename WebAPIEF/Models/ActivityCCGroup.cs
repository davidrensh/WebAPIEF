//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPIEF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActivityCCGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActivityCCGroup()
        {
            this.ActivityCCMapping = new HashSet<ActivityCCMapping>();
            this.Scope = new HashSet<Scope>();
        }
    
        public int ActivityCCGroupID { get; set; }
        public int ImportLogID { get; set; }
        public int GroupID { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDefault { get; set; }
    
        public virtual ImportLog ImportLog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityCCMapping> ActivityCCMapping { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Scope> Scope { get; set; }
    }
}
