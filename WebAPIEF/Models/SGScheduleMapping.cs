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
    
    public partial class SGScheduleMapping
    {
        public int SGScheduleMappingID { get; set; }
        public int ScopeID { get; set; }
        public int ActivityCCMappingID { get; set; }
        public string ScheduleID { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual ActivityCCMapping ActivityCCMapping { get; set; }
        public virtual Scope Scope { get; set; }
    }
}