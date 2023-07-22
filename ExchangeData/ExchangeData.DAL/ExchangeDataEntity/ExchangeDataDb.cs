namespace ExchangeData.DAL.ExchangeDataEntity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ExchangeDataDb : DbContext
    {
        public ExchangeDataDb() : base("name=ExchangeDataDb")

        {
        }

        public virtual DbSet<SendMessage> SendMessages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
