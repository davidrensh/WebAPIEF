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
    
    public partial class ImportType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ImportType()
        {
            this.ImportLog = new HashSet<ImportLog>();
        }
    
        public int ImportTypeID { get; set; }
        public string ImportTypeName { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportLog> ImportLog { get; set; }
    }
}
