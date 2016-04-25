namespace HuskyAir.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Plane")]
    public partial class Plane
    {
        private string trim_Nnumber = string.Empty;
        private string trim_Type = string.Empty;
        private string trim_Current = string.Empty;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plane()
        {
            Flights = new HashSet<Flight>();
            PilotDates = new HashSet<PilotDate>();
        }

        [Key]
        [Display(Name = "ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name = "N-number")]
        public int NNumber { get; set; }

        [Display(Name = "Pilot ID")]
        public int? fk_PilotIDNumber { get; set; }

        [Display(Name = "Type")]
        [StringLength(255)]
        public string Type
        {
            get { return this.trim_Type; }
            set { this.trim_Type = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Display(Name = "Engine Number")]
        public int? NumberOfEngines { get; set; }

        [Display(Name = "Number of Passengers")]
        public int? NumberOfPassengers { get; set; }

        [Display(Name = "Current Location")]
        [StringLength(255)]
        public string CurrentLocation
        {
            get { return this.trim_Current; }
            set { this.trim_Current = (string.IsNullOrEmpty(value)) ? value : value.Trim(); }
        }

        [Display(Name = "Weight Capacity")]
        public int? WeightCapacity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flight> Flights { get; set; }

        public virtual Pilot Pilot { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PilotDate> PilotDates { get; set; }
    }
}
