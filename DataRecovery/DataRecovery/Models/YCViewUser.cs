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
    
    public partial class YCViewUser
    {
        public int AppId { get; set; }
        public long UserId { get; set; }
        public long ParentUserId { get; set; }
        public string NickName { get; set; }
        public int UserType { get; set; }
        public int Online { get; set; }
        public int Status { get; set; }
        public int Rebate { get; set; }
        public int UnfixedRebate { get; set; }
        public int TotalCent { get; set; }
        public int FrozenCent { get; set; }
        public int AvailableCent { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public System.DateTime UpdatedTime { get; set; }
        public Nullable<System.DateTime> LoginTime { get; set; }
        public string LoginIp { get; set; }
        public Nullable<System.DateTime> PenalizeStartTime { get; set; }
        public Nullable<int> IntervalDay { get; set; }
        public Nullable<decimal> BetAmount { get; set; }
        public Nullable<int> FanDianChengFaRebate { get; set; }
        public string GroupName { get; set; }
        public int GroupId { get; set; }
        public string LoginName { get; set; }
        public int Rebate11x5 { get; set; }
        public int Rebate11x5Unfixed { get; set; }
    }
}