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
    
    public partial class UserIncome
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public int IncomeType { get; set; }
        public Nullable<long> FromId { get; set; }
        public int IncomeCent { get; set; }
        public Nullable<int> BankAccountId { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string BankOprNo { get; set; }
        public int CurrentAvailableCent { get; set; }
        public string Description { get; set; }
        public Nullable<long> OrderId { get; set; }
    
        public virtual UserBankAccount UserBankAccount { get; set; }
    }
}
