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
        private string trim_Nnumber = string.Empty;
        private string trim_DestinationInfo = string.Empty;
        private string trim_NumPassengers = string.Empty;
        private string trim_FlightDuration = string.Empty;
        private string trim_Distance = string.Empty;

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
        public int? fk_PlaneID { get; set; }

        [Display(Name = "Patient ID")]
        public int? fk_PatientID { get; set; }

        [Display(Name = "Destination")]
        [StringLength(255)]
        public string DestinationInformation
        {
            get { return this.trim_DestinationInfo; }
            set { this.trim_DestinationInfo = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Display(Name = "Number of Passengers")]
        [StringLength(255)]
        public string NumberOfPassengers
        {
            get { return this.trim_NumPassengers; }
            set { this.trim_NumPassengers = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Display(Name = "Flight Duration")]
        [StringLength(255)]
        public string FlightDuration
        {
            get { return this.trim_FlightDuration; }
            set { this.trim_FlightDuration = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Display(Name = "Distance")]
        [StringLength(255)]
        public string Distance
        {
            get { return this.trim_Distance; }
            set { this.trim_Distance = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Display(Name = "Date of Flight")]
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        public DateTime? DateOfFlight { get; set; }

        [Display(Name = "Time of Flight")]
        [DataType(DataType.Time)]
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
