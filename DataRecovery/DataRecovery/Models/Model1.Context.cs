﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bcbzEntities : DbContext
    {
        public bcbzEntities()
            : base("name=bcbzEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Bank> Bank { get; set; }
        public DbSet<BetOrder> BetOrder { get; set; }
        public DbSet<BZSession> BZSession { get; set; }
        public DbSet<CustomerService> CustomerService { get; set; }
        public DbSet<CustomerServiceCategory> CustomerServiceCategory { get; set; }
        public DbSet<DividendApply> DividendApply { get; set; }
        public DbSet<DividendPercentage> DividendPercentage { get; set; }
        public DbSet<DividendRecord> DividendRecord { get; set; }
        public DbSet<FollowOrder> FollowOrder { get; set; }
        public DbSet<GlobalSetting> GlobalSetting { get; set; }
        public DbSet<History> History { get; set; }
        public DbSet<InnerLotteryOpenTime> InnerLotteryOpenTime { get; set; }
        public DbSet<Lottery> Lottery { get; set; }
        public DbSet<LotteryCategory> LotteryCategory { get; set; }
        public DbSet<LotteryOpen> LotteryOpen { get; set; }
        public DbSet<LotteryOpenTime> LotteryOpenTime { get; set; }
        public DbSet<LotteryPlayingMethodPrize> LotteryPlayingMethodPrize { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<PlatformDividend> PlatformDividend { get; set; }
        public DbSet<PlayingCategory> PlayingCategory { get; set; }
        public DbSet<PlayingMethod> PlayingMethod { get; set; }
        public DbSet<PlayTogether> PlayTogether { get; set; }
        public DbSet<ServerTime> ServerTime { get; set; }
        public DbSet<SystemBankAccount> SystemBankAccount { get; set; }
        public DbSet<SystemPost> SystemPost { get; set; }
        public DbSet<UserAdvice> UserAdvice { get; set; }
        public DbSet<UserBankAccount> UserBankAccount { get; set; }
        public DbSet<UserIncome> UserIncome { get; set; }
        public DbSet<UserMessage> UserMessage { get; set; }
        public DbSet<UserPlayTogetherRecord> UserPlayTogetherRecord { get; set; }
        public DbSet<WithdrawDeposit> WithdrawDeposit { get; set; }
        public DbSet<YCViewUser> YCViewUser { get; set; }
    }
}