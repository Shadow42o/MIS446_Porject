namespace HuskyAir.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PlaneModels : DbContext
    {
        public PlaneModels()
            : base("name=PlaneModels")
        {
        }

        public virtual DbSet<Plane> Planes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plane>()
                .Property(e => e.NNumber)
                .IsFixedLength();

            modelBuilder.Entity<Plane>()
                .Property(e => e.fk_PilotIDNumber)
                .IsFixedLength();

            modelBuilder.Entity<Plane>()
                .Property(e => e.Type)
                .IsFixedLength();

            modelBuilder.Entity<Plane>()
                .Property(e => e.NumberOfEngines)
                .IsFixedLength();

            modelBuilder.Entity<Plane>()
                .Property(e => e.NumberOfPassengers)
                .IsFixedLength();

            modelBuilder.Entity<Plane>()
                .Property(e => e.CurrentLocation)
                .IsFixedLength();

            modelBuilder.Entity<Plane>()
                .Property(e => e.WeightCapacity)
                .IsFixedLength();
        }
    }
}
