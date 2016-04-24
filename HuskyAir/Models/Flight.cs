namespace HuskyAir.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Flight")]
    public partial class Flight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flight()
        {
            FlightPassengers = new HashSet<FlightPassenger>();
        }

        [Key]
        [Display(Name = "Flight ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FlightIDNumber { get; set; }

        [Display(Name = "Pilot ID")]
        public int? fk_PilotID { get; set; }

        [Display(Name = "Plane ID")]
        [StringLength(255)]
        public string fk_PlaneID { get; set; }

        [Display(Name = "Patient ID")]
        public int? fk_PatientID { get; set; }

        [Display(Name = "Destination")]
        [StringLength(255)]
        public string DestinationInformation { get; set; }

        [Display(Name = "Number of Passengers")]
        [StringLength(255)]
        public string NumberOfPassengers { get; set; }

        [Display(Name = "Flight Duration")]
        [StringLength(255)]
        public string FlightDuration { get; set; }

        [Display(Name = "Distance")]
        [StringLength(255)]
        public string Distance { get; set; }

        [Display(Name = "Date of Flight")]
        [Column(TypeName = "date")]
        public DateTime? DateOfFlight { get; set; }

        [Display(Name = "Time of Flight")]
        public TimeSpan? TimeOfFlight { get; set; }

        [Display(Name = "Luggage Weight")]
        public int? WeightOfLuggage { get; set; }

        [Display(Name = "Fuel Used")]
        public int? FuelUsed { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Pilot Pilot { get; set; }

        public virtual Plane Plane { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightPassenger> FlightPassengers { get; set; }
    }
}
