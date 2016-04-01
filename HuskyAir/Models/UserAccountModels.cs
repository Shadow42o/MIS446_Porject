namespace HuskyAir.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UserAccountModels : DbContext
    {
        public UserAccountModels()
            : base("name=UserAccountModels")
        {
        }

        public virtual DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccount>()
                .Property(e => e.UserId)
                .IsFixedLength();

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.LastName)
                .IsFixedLength();

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.Username)
                .IsFixedLength();

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.ConfirmPassword)
                .IsFixedLength();
        }
    }
}
