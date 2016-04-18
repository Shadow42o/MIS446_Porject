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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plane()
        {
            Flights = new HashSet<Flight>();
            PilotDates = new HashSet<PilotDate>();
        }

        [Key]
        [StringLength(20)]
        public string NNumber { get; set; }

        public int? fk_PilotIDNumber { get; set; }

        [StringLength(20)]
        public string Type { get; set; }

        public int? NumberOfEngines { get; set; }

        public int? NumberOfPassengers { get; set; }

        [StringLength(20)]
        public string CurrentLocation { get; set; }

        public int? WeightCapacity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flight> Flights { get; set; }

        public virtual Pilot Pilot { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PilotDate> PilotDates { get; set; }
    }
}
