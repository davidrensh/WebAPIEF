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
    
    public partial class Scope
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Scope()
        {
            this.BOLDetails = new HashSet<BOLDetails>();
            this.ImportData = new HashSet<ImportData>();
            this.ProgressLog = new HashSet<ProgressLog>();
            this.ProjectSCSGActivity = new HashSet<ProjectSCSGActivity>();
            this.ScopeCCBudget = new HashSet<ScopeCCBudget>();
            this.SGDescription = new HashSet<SGDescription>();
            this.SGScheduleMapping = new HashSet<SGScheduleMapping>();
            this.UserProfileDetail = new HashSet<UserProfileDetail>();
        }
    
        public int ScopeID { get; set; }
        public int ActivityCCGroupID { get; set; }
        public int ProjectSCID { get; set; }
        public string RollupValue { get; set; }
        public Nullable<double> TotalHours { get; set; }
        public Nullable<double> TotalQty { get; set; }
        public bool IsManualEntry { get; set; }
        public Nullable<decimal> TotalProgress { get; set; }
        public string Comment { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> AcornCheckDate { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public bool OutOfScope { get; set; }
        public Nullable<int> FPRSourceID { get; set; }
        public string ScheduleID { get; set; }
        public string UM { get; set; }
        public string d0 { get; set; }
        public string d1 { get; set; }
        public string d2 { get; set; }
        public string d3 { get; set; }
        public string d4 { get; set; }
        public string d5 { get; set; }
        public string d6 { get; set; }
        public string d7 { get; set; }
        public string d8 { get; set; }
        public string d9 { get; set; }
        public string d10 { get; set; }
        public string d11 { get; set; }
        public string d12 { get; set; }
        public string d13 { get; set; }
        public string d14 { get; set; }
        public string d15 { get; set; }
        public string d16 { get; set; }
        public string d17 { get; set; }
        public string d18 { get; set; }
        public string d19 { get; set; }
        public string d20 { get; set; }
        public string d21 { get; set; }
        public string d22 { get; set; }
        public string d23 { get; set; }
        public string d24 { get; set; }
        public string d25 { get; set; }
        public string d26 { get; set; }
        public string d27 { get; set; }
        public string d28 { get; set; }
        public string d29 { get; set; }
        public string d30 { get; set; }
        public string d31 { get; set; }
        public string d32 { get; set; }
        public string d33 { get; set; }
        public string d34 { get; set; }
        public string d35 { get; set; }
        public string d36 { get; set; }
        public string d37 { get; set; }
        public string d38 { get; set; }
        public string d39 { get; set; }
        public string d40 { get; set; }
        public string d41 { get; set; }
        public string d42 { get; set; }
        public string d43 { get; set; }
        public string d44 { get; set; }
        public string d45 { get; set; }
        public string d46 { get; set; }
        public string d47 { get; set; }
        public string d48 { get; set; }
        public string d49 { get; set; }
        public string d50 { get; set; }
        public string d51 { get; set; }
        public string d52 { get; set; }
        public string d53 { get; set; }
        public string d54 { get; set; }
        public string d55 { get; set; }
        public string d56 { get; set; }
        public string d57 { get; set; }
        public string d58 { get; set; }
        public string d59 { get; set; }
        public string d60 { get; set; }
    
        public virtual ActivityCCGroup ActivityCCGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOLDetails> BOLDetails { get; set; }
        public virtual FPRSource FPRSource { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportData> ImportData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgressLog> ProgressLog { get; set; }
        public virtual ProjectScoreCard ProjectScoreCard { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectSCSGActivity> ProjectSCSGActivity { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScopeCCBudget> ScopeCCBudget { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SGDescription> SGDescription { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SGScheduleMapping> SGScheduleMapping { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserProfileDetail> UserProfileDetail { get; set; }
    }
}
