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
    
    public partial class LotteryOpenTime
    {
        public int LotteryId { get; set; }
        public long OpenSequence { get; set; }
        public System.DateTime OpenTime { get; set; }
        public string OpenNumbers { get; set; }
        public long OpenningSequence { get; set; }
        public System.DateTime OpenningTime { get; set; }
        public long SaleSequence { get; set; }
        public System.DateTime SaleEndTime { get; set; }
        public int OpenDelaySeconds { get; set; }
        public int FrozenSeconds { get; set; }
    
        public virtual Lottery Lottery { get; set; }
    }
}
