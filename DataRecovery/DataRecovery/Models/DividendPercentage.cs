//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataRecovery.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DividendPercentage
    {
        public DividendPercentage()
        {
            this.DividendRecord = new HashSet<DividendRecord>();
        }
    
        public long Id { get; set; }
        public long UserId { get; set; }
        public decimal LossAmount { get; set; }
        public decimal Percentage { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public int Status { get; set; }
    
        public virtual ICollection<DividendRecord> DividendRecord { get; set; }
    }
}
