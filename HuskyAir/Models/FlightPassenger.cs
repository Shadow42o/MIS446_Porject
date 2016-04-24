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
        [Key]
        [Display(Name = "ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name = "Flight ID")]
        public int fk_FlightID { get; set; }

        [Display(Name = "Passenger ID")]
        public int? fk_PassengerID { get; set; }

        public virtual Flight Flight { get; set; }

        public virtual Passenger Passenger { get; set; }
    }
}
