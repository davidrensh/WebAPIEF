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
    
    public partial class ScopeCCBudget
    {
        public int ScopeCCBudgetID { get; set; }
        public Nullable<int> EstimateMethodID { get; set; }
        public int ScopeID { get; set; }
        public int ProjectCCID { get; set; }
        public Nullable<double> Hours { get; set; }
        public Nullable<double> Quantity { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual EstimateMethod EstimateMethod { get; set; }
        public virtual ProjectCC ProjectCC { get; set; }
        public virtual Scope Scope { get; set; }
    }
}
