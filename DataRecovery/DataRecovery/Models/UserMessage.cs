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
    
    public partial class UserMessage
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long MessageId { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public int Status { get; set; }
    
        public virtual Message Message { get; set; }
    }
}