namespace HuskyAir.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBModelsMaster : DbContext
    {
        public DBModelsMaster()
            : base("name=DBModelsMaster")
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
        public virtual DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Certification>()
                .Property(e => e.Certification1)
                .IsFixedLength();

            modelBuilder.Entity<Flight>()
                .Property(e => e.fk_PlaneID);

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
                .HasMany(e => e.FlightPassengers)
                .WithRequired(e => e.Flight)
                .HasForeignKey(e => e.fk_FlightID)
                .WillCascadeOnDelete(false);

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
                .Property(e => e.EMailAddress)
                .IsFixedLength();

            modelBuilder.Entity<Insurance>()
                .HasMany(e => e.Patients)
                .WithOptional(e => e.Insurance)
                .HasForeignKey(e => e.fk_InsuranceIDNumber);

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
                .Property(e => e.PhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<OutsideParty>()
                .Property(e => e.EmailAddress)
                .IsFixedLength();

            modelBuilder.Entity<OutsideParty>()
                .HasMany(e => e.PatientOutsideParties)
                .WithRequired(e => e.OutsideParty)
                .HasForeignKey(e => e.fk_OutsidePartyIDNumber)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Passenger>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<Passenger>()
                .Property(e => e.LastName)
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
                .Property(e => e.PhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<Passenger>()
                .Property(e => e.EMailAddress)
                .IsFixedLength();

            modelBuilder.Entity<Passenger>()
                .HasMany(e => e.FlightPassengers)
                .WithOptional(e => e.Passenger)
                .HasForeignKey(e => e.fk_PassengerID);

            modelBuilder.Entity<Patient>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .Property(e => e.LastName)
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
                .Property(e => e.EMailAddress)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .Property(e => e.SpecialNeeds)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Flights)
                .WithOptional(e => e.Patient)
                .HasForeignKey(e => e.fk_PatientID);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.PatientOutsideParties)
                .WithOptional(e => e.Patient)
                .HasForeignKey(e => e.fk_PatientIDNumber);

            modelBuilder.Entity<Pilot>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<Pilot>()
                .Property(e => e.LastName)
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
                .Property(e => e.PhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<Pilot>()
                .Property(e => e.EMailAddress)
                .IsFixedLength();

            modelBuilder.Entity<Pilot>()
                .HasMany(e => e.Certifications)
                .WithRequired(e => e.Pilot)
                .HasForeignKey(e => e.fk_PilotIDNumber)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pilot>()
                .HasMany(e => e.Flights)
                .WithOptional(e => e.Pilot)
                .HasForeignKey(e => e.fk_PilotID);

            modelBuilder.Entity<Pilot>()
                .HasMany(e => e.PilotDates)
                .WithOptional(e => e.Pilot)
                .HasForeignKey(e => e.fk_PilotIDNumber);

            modelBuilder.Entity<Pilot>()
                .HasMany(e => e.Planes)
                .WithOptional(e => e.Pilot)
                .HasForeignKey(e => e.fk_PilotIDNumber);

            modelBuilder.Entity<PilotDate>()
                .Property(e => e.fk_PlaneIDNumber);

            modelBuilder.Entity<Plane>()
                .Property(e => e.NNumber);

            modelBuilder.Entity<Plane>()
                .Property(e => e.Type)
                .IsFixedLength();

            modelBuilder.Entity<Plane>()
                .Property(e => e.CurrentLocation)
                .IsFixedLength();

            modelBuilder.Entity<Plane>()
                .HasMany(e => e.Flights)
                .WithOptional(e => e.Plane)
                .HasForeignKey(e => e.fk_PlaneID);

            modelBuilder.Entity<Plane>()
                .HasMany(e => e.PilotDates)
                .WithOptional(e => e.Plane)
                .HasForeignKey(e => e.fk_PlaneIDNumber);

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

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.Role)
                .IsFixedLength();
        }
    }
}
