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
    
    public partial class SCMilestoneTemplate
    {
        public int SCMilestoneTemplateID { get; set; }
        public int ScoreCardID { get; set; }
        public int MilestoneID { get; set; }
        public int DisplaySequence { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual Milestone Milestone { get; set; }
        public virtual ScoreCard ScoreCard { get; set; }
    }
}
