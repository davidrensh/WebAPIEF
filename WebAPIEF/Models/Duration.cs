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
    
    public partial class Duration
    {
        public int DurationID { get; set; }
        public int DurationTypeID { get; set; }
        public int ProjectSCBLSID { get; set; }
        public int Duration1 { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual DurationType DurationType { get; set; }
        public virtual ProjectSCBLS ProjectSCBLS { get; set; }
    }
}
