namespace HuskyAir.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FlightModels : DbContext
    {
        public FlightModels()
            : base("name=FlightModels")
        {
        }

        public virtual DbSet<Flight> Flights { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>()
                .Property(e => e.FlightIDNumber)
                .IsFixedLength();

            modelBuilder.Entity<Flight>()
                .Property(e => e.fk_PilotID)
                .IsFixedLength();

            modelBuilder.Entity<Flight>()
                .Property(e => e.fk_PlaneID)
                .IsFixedLength();

            modelBuilder.Entity<Flight>()
                .Property(e => e.fk_PatientID)
                .IsFixedLength();

            modelBuilder.Entity<Flight>()
                .Property(e => e.DestinationInformation)
                .IsFixedLength();

            modelBuilder.Entity<Flight>()
                .Property(e => e.NumberOfPassengers)
                .IsFixedLength();

            modelBuilder.Entity<Flight>()
                .Property(e => e.FlightDuration)
                .IsFixedLength();

            modelBuilder.Entity<Flight>()
                .Property(e => e.Distance)
                .IsFixedLength();

            modelBuilder.Entity<Flight>()
                .Property(e => e.DateOfFlight)
                .IsFixedLength();

            modelBuilder.Entity<Flight>()
                .Property(e => e.TimeOfFlight)
                .IsFixedLength();

            modelBuilder.Entity<Flight>()
                .Property(e => e.WeightOfLuggage)
                .IsFixedLength();

            modelBuilder.Entity<Flight>()
                .Property(e => e.FuelUsed)
                .IsFixedLength();
        }
    }
}
