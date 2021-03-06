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
    
    public partial class ImportLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ImportLog()
        {
            this.ActivityCCGroup = new HashSet<ActivityCCGroup>();
            this.ImportData = new HashSet<ImportData>();
            this.ImportRollUp = new HashSet<ImportRollUp>();
            this.ProgressLog = new HashSet<ProgressLog>();
            this.SGDescription = new HashSet<SGDescription>();
        }
    
        public int ImportLogID { get; set; }
        public Nullable<int> ProjectSCID { get; set; }
        public int ImportTypeID { get; set; }
        public string FileName { get; set; }
        public decimal TotalHours { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public string UpdateMethod { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityCCGroup> ActivityCCGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportData> ImportData { get; set; }
        public virtual ImportType ImportType { get; set; }
        public virtual Project Project { get; set; }
        public virtual ProjectScoreCard ProjectScoreCard { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportRollUp> ImportRollUp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgressLog> ProgressLog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SGDescription> SGDescription { get; set; }
    }
}
