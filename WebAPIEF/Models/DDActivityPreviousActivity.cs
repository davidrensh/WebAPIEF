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
    
    public partial class DDActivityPreviousActivity
    {
        public int ScopeID { get; set; }
        public string ActivityID { get; set; }
        public string ActOrDescName { get; set; }
        public string PreviousActOrDescID { get; set; }
        public string PreviousActOrDescName { get; set; }
        public Nullable<int> UserNameID { get; set; }
    
        public virtual UserName UserName { get; set; }
    }
}