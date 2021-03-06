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
    
    public partial class Description
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Description()
        {
            this.DescriptionLog = new HashSet<DescriptionLog>();
            this.ProjectSCDescription = new HashSet<ProjectSCDescription>();
            this.SCDescriptionTemplate = new HashSet<SCDescriptionTemplate>();
        }
    
        public int DescriptionID { get; set; }
        public Nullable<int> DescriptionTypeID { get; set; }
        public string DescriptionName { get; set; }
        public bool IsStandard { get; set; }
        public bool IsDeleted { get; set; }
        public string DefaultDisplayName { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<int> WorkflowIdentifier { get; set; }
        public Nullable<int> DescriptionIdentifier { get; set; }
    
        public virtual DescriptionType DescriptionType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DescriptionLog> DescriptionLog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectSCDescription> ProjectSCDescription { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCDescriptionTemplate> SCDescriptionTemplate { get; set; }
    }
}
