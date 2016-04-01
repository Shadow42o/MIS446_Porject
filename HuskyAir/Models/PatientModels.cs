namespace HuskyAir.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PatientModels : DbContext
    {
        public PatientModels()
            : base("name=PatientModels")
        {
        }

        public virtual DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
                .Property(e => e.PatientIDNumber)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .Property(e => e.DOB)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .Property(e => e.City)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .Property(e => e.State)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .Property(e => e.ZipCode)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .Property(e => e.EMailAddress)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .Property(e => e.SpecialNeeds)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .Property(e => e.InsuranceIDNumber)
                .IsFixedLength();
        }
    }
}
