namespace HuskyAir.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FlightPassenger")]
    public partial class FlightPassenger
    {
        [StringLength(10)]
        public string ID { get; set; }

        [Required]
        [StringLength(10)]
        public string fk_FlightID { get; set; }

        [StringLength(10)]
        public string fk_PassengerID { get; set; }
    }
}
