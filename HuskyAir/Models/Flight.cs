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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FlightIDNumber { get; set; }

        public int? fk_PilotID { get; set; }

        [StringLength(20)]
        public string fk_PlaneID { get; set; }

        public int? fk_PatientID { get; set; }

        [StringLength(20)]
        public string DestinationInformation { get; set; }

        [StringLength(20)]
        public string NumberOfPassengers { get; set; }

        [StringLength(20)]
        public string FlightDuration { get; set; }

        [StringLength(20)]
        public string Distance { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfFlight { get; set; }

        public TimeSpan? TimeOfFlight { get; set; }

        public int? WeightOfLuggage { get; set; }

        public int? FuelUsed { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Pilot Pilot { get; set; }

        public virtual Plane Plane { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightPassenger> FlightPassengers { get; set; }
    }
}
