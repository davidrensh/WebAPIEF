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
    
    public partial class DurationType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DurationType()
        {
            this.Duration = new HashSet<Duration>();
        }
    
        public int DurationTypeID { get; set; }
        public int ProjectSCID { get; set; }
        public int MatGroupId { get; set; }
        public float DILow { get; set; }
        public float DIUp { get; set; }
        public string Destination { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Duration> Duration { get; set; }
        public virtual MatGroupCode MatGroupCode { get; set; }
        public virtual ProjectScoreCard ProjectScoreCard { get; set; }
    }
}