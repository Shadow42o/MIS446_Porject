namespace HuskyAir.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PatientOutsidePartyModels : DbContext
    {
        public PatientOutsidePartyModels()
            : base("name=HuskyAirDBModels")
        {
        }

        public virtual DbSet<Certification> Certifications { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<FlightPassenger> FlightPassengers { get; set; }
        public virtual DbSet<Insurance> Insurances { get; set; }
        public virtual DbSet<OutsideParty> OutsideParties { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientOutsideParty> PatientOutsideParties { get; set; }
        public virtual DbSet<Pilot> Pilots { get; set; }
        public virtual DbSet<PilotDate> PilotDates { get; set; }
        public virtual DbSet<Plane> Planes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Certification>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<Certification>()
                .Property(e => e.fk_PilotIDNumber)
                .IsFixedLength();

            modelBuilder.Entity<Certification>()
                .Property(e => e.Certification1)
                .IsFixedLength();

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

            modelBuilder.Entity<FlightPassenger>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<FlightPassenger>()
                .Property(e => e.fk_FlightID)
                .IsFixedLength();

            modelBuilder.Entity<FlightPassenger>()
                .Property(e => e.fk_PassengerID)
                .IsFixedLength();

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

            modelBuilder.Entity<OutsideParty>()
                .Property(e => e.OutsidePartyIDNumber)
                .IsFixedLength();

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

            modelBuilder.Entity<OutsideParty>()
                .HasMany(e => e.PatientOutsideParties)
                .WithRequired(e => e.OutsideParty)
                .HasForeignKey(e => e.fk_OutsidePartyIDNumber)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Passenger>()
                .Property(e => e.PassengerID)
                .IsFixedLength();

            modelBuilder.Entity<Passenger>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Passenger>()
                .Property(e => e.DOB)
                .IsFixedLength();

            modelBuilder.Entity<Passenger>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<Passenger>()
                .Property(e => e.City)
                .IsFixedLength();

            modelBuilder.Entity<Passenger>()
                .Property(e => e.State)
                .IsFixedLength();

            modelBuilder.Entity<Passenger>()
                .Property(e => e.ZipCode)
                .IsFixedLength();

            modelBuilder.Entity<Passenger>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<Passenger>()
                .Property(e => e.EMailAddress)
                .IsFixedLength();

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

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.PatientOutsideParties)
                .WithOptional(e => e.Patient)
                .HasForeignKey(e => e.fk_PatientIDNumber);

            modelBuilder.Entity<PatientOutsideParty>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<PatientOutsideParty>()
                .Property(e => e.fk_PatientIDNumber)
                .IsFixedLength();

            modelBuilder.Entity<PatientOutsideParty>()
                .Property(e => e.fk_OutsidePartyIDNumber)
                .IsFixedLength();

            modelBuilder.Entity<Pilot>()
                .Property(e => e.PilotIDNumber)
                .IsFixedLength();

            modelBuilder.Entity<Pilot>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Pilot>()
                .Property(e => e.DOB)
                .IsFixedLength();

            modelBuilder.Entity<Pilot>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<Pilot>()
                .Property(e => e.City)
                .IsFixedLength();

            modelBuilder.Entity<Pilot>()
                .Property(e => e.State)
                .IsFixedLength();

            modelBuilder.Entity<Pilot>()
                .Property(e => e.ZipCode)
                .IsFixedLength();

            modelBuilder.Entity<Pilot>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<Pilot>()
                .Property(e => e.EMailAddress)
                .IsFixedLength();

            modelBuilder.Entity<Pilot>()
                .Property(e => e.TotalHours)
                .IsFixedLength();

            modelBuilder.Entity<Pilot>()
                .Property(e => e.AverageRating)
                .IsFixedLength();

            modelBuilder.Entity<PilotDate>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<PilotDate>()
                .Property(e => e.fk_PilotIDNumber)
                .IsFixedLength();

            modelBuilder.Entity<PilotDate>()
                .Property(e => e.fk_PlaneIDNumber)
                .IsFixedLength();

            modelBuilder.Entity<PilotDate>()
                .Property(e => e.StartDateAvailable)
                .IsFixedLength();

            modelBuilder.Entity<PilotDate>()
                .Property(e => e.EndDateAvailable)
                .IsFixedLength();

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
