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
    
    public partial class ProjectSCActivityCCLog
    {
        public int ProjectSCActivityCCLogID { get; set; }
        public int ProjectSCActivityCCID { get; set; }
        public int OldROC { get; set; }
        public int NewROC { get; set; }
        public Nullable<decimal> OldEarnedHours { get; set; }
        public Nullable<decimal> NewEarnedHours { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual ProjectSCActivityCC ProjectSCActivityCC { get; set; }
    }
}