namespace HuskyAir.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OutsidePartyModels : DbContext
    {
        public OutsidePartyModels()
            : base("name=OutsidePartyModels")
        {
        }

        public virtual DbSet<OutsideParty> OutsideParties { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OutsideParty>()
                .Property(e => e.Title)
                .IsFixedLength();

            modelBuilder.Entity<OutsideParty>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<OutsideParty>()
                .Property(e => e.City)
                .IsFixedLength();

            modelBuilder.Entity<OutsideParty>()
                .Property(e => e.State)
                .IsFixedLength();

            modelBuilder.Entity<OutsideParty>()
                .Property(e => e.ZipCode)
                .IsFixedLength();

            modelBuilder.Entity<OutsideParty>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<OutsideParty>()
                .Property(e => e.EmailAddress)
                .IsFixedLength()
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<HuskyAir.Models.UserAccount> UserAccounts { get; set; }
    }
}
