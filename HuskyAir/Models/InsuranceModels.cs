namespace HuskyAir.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class InsuranceModels : DbContext
    {
        public InsuranceModels()
            : base("name=InsuranceModels")
        {
        }

        public virtual DbSet<Insurance> Insurances { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Insurance>()
                .Property(e => e.InsuranceIDNumber)
                .IsFixedLength();

            modelBuilder.Entity<Insurance>()
                .Property(e => e.CompanyName)
                .IsFixedLength();

            modelBuilder.Entity<Insurance>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<Insurance>()
                .Property(e => e.City)
                .IsFixedLength();

            modelBuilder.Entity<Insurance>()
                .Property(e => e.State)
                .IsFixedLength();

            modelBuilder.Entity<Insurance>()
                .Property(e => e.ZipCode)
                .IsFixedLength();

            modelBuilder.Entity<Insurance>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<Insurance>()
                .Property(e => e.EMailAddress)
                .IsFixedLength();
        }
    }
}
