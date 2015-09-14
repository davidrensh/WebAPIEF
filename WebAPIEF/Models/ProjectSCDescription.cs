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
    
    public partial class ProjectSCDescription
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProjectSCDescription()
        {
            this.ImportDataDescriptionDetail = new HashSet<ImportDataDescriptionDetail>();
            this.ImportRollUp = new HashSet<ImportRollUp>();
            this.UserProfileDetail = new HashSet<UserProfileDetail>();
        }
    
        public int ProjectSCDescriptionID { get; set; }
        public int ProjectSCID { get; set; }
        public int DescriptionID { get; set; }
        public int DisplaySequence { get; set; }
        public string DisplayName { get; set; }
        public bool IsDeleted { get; set; }
        public bool ShowInQCS { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public string SourceFieldName { get; set; }
        public bool ShowInView { get; set; }
    
        public virtual Description Description { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportDataDescriptionDetail> ImportDataDescriptionDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportRollUp> ImportRollUp { get; set; }
        public virtual ProjectScoreCard ProjectScoreCard { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserProfileDetail> UserProfileDetail { get; set; }
    }
}
