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
        [Key]
        [StringLength(10)]
        public string NNumber { get; set; }

        [StringLength(10)]
        public string fk_PilotIDNumber { get; set; }

        [StringLength(10)]
        public string Type { get; set; }

        [StringLength(10)]
        public string NumberOfEngines { get; set; }

        [StringLength(10)]
        public string NumberOfPassengers { get; set; }

        [StringLength(10)]
        public string CurrentLocation { get; set; }

        [StringLength(10)]
        public string WeightCapacity { get; set; }
    }
}
