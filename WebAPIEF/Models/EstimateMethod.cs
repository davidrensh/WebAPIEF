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
    
    public partial class EstimateMethod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstimateMethod()
        {
            this.GCCBudget = new HashSet<GCCBudget>();
            this.ScopeCCBudget = new HashSet<ScopeCCBudget>();
        }
    
        public int EstimateMethodID { get; set; }
        public string EstimateMethodName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GCCBudget> GCCBudget { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScopeCCBudget> ScopeCCBudget { get; set; }
    }
}